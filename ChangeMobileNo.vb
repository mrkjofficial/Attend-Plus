Imports MySql.Data.MySqlClient
Public Class ChangeMobileNo
    Dim Password As String
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Dim Script As New Scripts
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub TitleLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub TitleLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub TitleLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point With {
                .X = Location.X + (e.X - MouseDownX),
                .Y = Location.Y + (e.Y - MouseDownY)
            }
            Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub CrossButton_Click(sender As Object, e As EventArgs) Handles CrossButton.Click
        Close()
    End Sub
    Private Sub ValidationTimer_Tick(sender As Object, e As EventArgs) Handles ValidationTimer.Tick
        If ActiveControl Is CurrentPasswordTextBox And CurrentPasswordTextBox.Text = "" Then
            CurrentPasswordStatusLabel.Text = "Enter your Current Password!"
            CurrentPasswordStatusPictureBox.Image = Nothing
        ElseIf ActiveControl Is CurrentPasswordTextBox And CurrentPasswordTextBox.Text <> "" And Password <> CurrentPasswordTextBox.Text Then
            CurrentPasswordStatusLabel.Text = "Invalid Current Password!"
            CurrentPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is CurrentPasswordTextBox And Password = CurrentPasswordTextBox.Text Then
            CurrentPasswordStatusLabel.Text = ""
            CurrentPasswordStatusPictureBox.Image = My.Resources.Correct
        ElseIf CurrentPasswordTextBox.Text = "Current Password" And CurrentPasswordTextBox.ForeColor = Color.Gray Then
            CurrentPasswordStatusPictureBox.Image = Nothing
        End If
        If ActiveControl Is MobileNoTextBox And MobileNoTextBox.Text = "" Then
            MobileNoStatusLabel.Text = "Please enter your Mobile No.!"
        ElseIf ActiveControl Is MobileNoTextBox And IsNumeric(MobileNoTextBox.Text) = False Or MobileNoTextBox.Text.Length() <> 10 Then
            MobileNoStatusLabel.Text = "Invalid Mobile No.!"
        ElseIf ActiveControl Is MobileNoTextBox And IsNumeric(MobileNoTextBox.Text) = True And MobileNoTextBox.Text.Length() = 10 And MobileNoTextBox.Text <> "" Then
            MobileNoStatusLabel.Text = ""
        End If
    End Sub
    Private Sub CurrentPasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles CurrentPasswordTextBox.GotFocus
        If CurrentPasswordTextBox.Text = "Current Password" And CurrentPasswordTextBox.ForeColor = Color.Gray Then
            CurrentPasswordTextBox.Text = ""
            CurrentPasswordTextBox.ForeColor = Color.Black
            CurrentPasswordTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub CurrentPasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles CurrentPasswordTextBox.LostFocus
        If CurrentPasswordTextBox.Text = "" And CurrentPasswordTextBox.ForeColor = Color.Black Then
            CurrentPasswordTextBox.Text = "Current Password"
            CurrentPasswordTextBox.ForeColor = Color.Gray
            CurrentPasswordTextBox.PasswordChar = ""
        End If
    End Sub
    Private Sub MobileNoTextBox_GotFocus(sender As Object, e As EventArgs) Handles MobileNoTextBox.GotFocus
        If MobileNoTextBox.Text = "Mobile No." And MobileNoTextBox.ForeColor = Color.Gray Then
            MobileNoTextBox.Text = ""
            MobileNoTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub MobileNoTextBox_LostFocus(sender As Object, e As EventArgs) Handles MobileNoTextBox.LostFocus
        If MobileNoTextBox.Text = "" And MobileNoTextBox.ForeColor = Color.Black Then
            MobileNoTextBox.Text = "Mobile No."
            MobileNoTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Public Sub ChangeMobileNo_Load(sender As Object, e As EventArgs) Handles Me.Load
        ValidationTimer.Enabled = True
        ChangeMobileNoStatusLabel.Text = ""
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        MobileNoTextBox.Text = "Mobile No."
        MobileNoTextBox.ForeColor = Color.Gray
        CurrentPasswordStatusPictureBox.Image = Nothing
        ActiveControl = ChangeMobileNoPanel
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select * from ams.staff where binary staff_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Password = MySqlRead.GetString("password")
                If Not IsDBNull(MySqlRead("mobile_no")) And MySqlRead.GetInt64("mobile_no") <> 0 Then
                    MobileNoTextBox.ForeColor = Color.Black
                    MobileNoTextBox.Text = MySqlRead.GetInt64("mobile_no")
                Else
                    MobileNoTextBox.ForeColor = Color.Gray
                    MobileNoTextBox.Text = "Mobile No."
                End If
            End While
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        If Password = CurrentPasswordTextBox.Text And (MobileNoTextBox.Text <> "Mobile No." Or MobileNoTextBox.ForeColor <> Color.Gray) And IsNumeric(MobileNoTextBox.Text) = True And MobileNoTextBox.Text.Length() = 10 Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("update ams.staff set mobile_no = @mobileno where binary staff_id = @userid", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@mobileno", value:=MobileNoTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlRead = MySqlComm.ExecuteReader
                ChangeMobileNoStatusLabel.ForeColor = Color.Green
                ChangeMobileNoStatusLabel.Text = "Mobile No. Successfully Changed!"
                CurrentPasswordTextBox.Text = "Current Password"
                CurrentPasswordTextBox.ForeColor = Color.Gray
                CurrentPasswordTextBox.PasswordChar = ""
                MobileNoTextBox.Text = "Mobile No."
                MobileNoTextBox.ForeColor = Color.Gray
                MysqlConn.Close()
            Catch ex As MySqlException
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = ex.Message
                ErrorBox.ShowDialog()
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            If CurrentPasswordTextBox.Text = "Current Password" And CurrentPasswordTextBox.ForeColor = Color.Gray Then
                CurrentPasswordStatusLabel.Text = "Enter your Current Password!"
            End If
            If MobileNoTextBox.Text = "Mobile No." And MobileNoTextBox.ForeColor = Color.Gray Then
                MobileNoStatusLabel.Text = "Please enter your Mobile No.!"
            ElseIf IsNumeric(MobileNoTextBox.Text) = False Or MobileNoTextBox.Text.Length() <> 10 Then
                MobileNoStatusLabel.Text = "Invalid Mobile No.!"
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ChangeMobileNoStatusLabel.Text = ""
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        CurrentPasswordStatusLabel.Text = ""
        MobileNoTextBox.ForeColor = Color.Gray
        MobileNoTextBox.Text = "Mobile No."
        MobileNoStatusLabel.Text = ""
        CurrentPasswordStatusPictureBox.Image = Nothing
    End Sub
End Class