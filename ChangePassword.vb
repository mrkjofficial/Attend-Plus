Imports MySql.Data.MySqlClient
Public Class ChangePassword
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
        If ActiveControl Is NewPasswordTextBox And NewPasswordTextBox.Text = "" Then
            NewPasswordStatusLabel.Text = "Enter your New Password!"
            NewPasswordStatusPictureBox.Image = Nothing
        ElseIf ActiveControl Is NewPasswordTextBox And NewPasswordTextBox.Text <> "" And CurrentPasswordTextBox.Text = NewPasswordTextBox.Text Then
            NewPasswordStatusLabel.Text = "Current and New Password cannot be same!"
            NewPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is NewPasswordTextBox And Script.CheckPassword(NewPasswordTextBox.Text) = 3 Then
            NewPasswordStatusLabel.Text = "Allowed Characters are A-Z, a-z, 0-9!"
            NewPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is NewPasswordTextBox And Script.CheckPassword(NewPasswordTextBox.Text) = 2 Then
            NewPasswordStatusLabel.Text = "New Password must atleast contain 1 U-Case letter, 1 L-Case letter and 1 number!"
            NewPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is NewPasswordTextBox And Script.CheckPassword(NewPasswordTextBox.Text) <> 3 And NewPasswordTextBox.Text.Length() < 8 Or NewPasswordTextBox.Text.Length() > 16 Then
            NewPasswordStatusLabel.Text = "New Password must be betwwen 8-16 letters!"
            NewPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is NewPasswordTextBox And NewPasswordTextBox.Text <> "" And Script.CheckPassword(NewPasswordTextBox.Text) = 1 And NewPasswordTextBox.Text.Length() >= 8 And NewPasswordTextBox.Text.Length() <= 16 Then
            NewPasswordStatusLabel.Text = ""
            NewPasswordStatusPictureBox.Image = My.Resources.Correct
        ElseIf NewPasswordTextBox.Text = "New Password" And NewPasswordTextBox.ForeColor = Color.Gray Then
            NewPasswordStatusPictureBox.Image = Nothing
        End If
        If ActiveControl Is ConfirmPasswordTextBox And NewPasswordTextBox.Text = "New Password" Then
            ConfirmPasswordStatusLabel.Text = "Enter your New Password First!"
            ConfirmPasswordStatusPictureBox.Image = Nothing
        ElseIf ActiveControl Is ConfirmPasswordTextBox And ConfirmPasswordTextBox.Text <> "" And NewPasswordTextBox.Text <> ConfirmPasswordTextBox.Text Then
            ConfirmPasswordStatusLabel.Text = "Passwords do not match!"
            ConfirmPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf ActiveControl Is ConfirmPasswordTextBox And ConfirmPasswordTextBox.Text = "" Then
            ConfirmPasswordStatusLabel.Text = "Retype your New Password!"
            ConfirmPasswordStatusPictureBox.Image = Nothing
        ElseIf ActiveControl Is ConfirmPasswordTextBox And ConfirmPasswordTextBox.Text <> "" And NewPasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            ConfirmPasswordStatusLabel.Text = ""
            ConfirmPasswordStatusPictureBox.Image = My.Resources.Correct
        ElseIf ConfirmPasswordTextBox.Text = "Confirm Password" Then
            ConfirmPasswordStatusPictureBox.Image = Nothing
        End If
        If (NewPasswordTextBox.Text <> "New Password" And NewPasswordTextBox.ForeColor <> Color.Gray) And (ConfirmPasswordTextBox.Text <> "Confirm Password" And ConfirmPasswordTextBox.ForeColor <> Color.Gray) And NewPasswordTextBox.Text <> ConfirmPasswordTextBox.Text And ConfirmPasswordTextBox.Text <> "" Then
            ConfirmPasswordStatusLabel.Text = "Passwords do not match!"
            ConfirmPasswordStatusPictureBox.Image = My.Resources.Incorrect
        ElseIf (NewPasswordTextBox.Text <> "New Password" And NewPasswordTextBox.ForeColor <> Color.Gray) And (ConfirmPasswordTextBox.Text <> "Confirm Password" And ConfirmPasswordTextBox.ForeColor <> Color.Gray) And NewPasswordTextBox.Text = ConfirmPasswordTextBox.Text Then
            ConfirmPasswordStatusLabel.Text = ""
            ConfirmPasswordStatusPictureBox.Image = My.Resources.Correct
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
    Private Sub NewPasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles NewPasswordTextBox.GotFocus
        If NewPasswordTextBox.Text = "New Password" And NewPasswordTextBox.ForeColor = Color.Gray Then
            NewPasswordTextBox.Text = ""
            NewPasswordTextBox.ForeColor = Color.Black
            NewPasswordTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub NewPasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles NewPasswordTextBox.LostFocus
        If NewPasswordTextBox.Text = "" And NewPasswordTextBox.ForeColor = Color.Black Then
            NewPasswordTextBox.Text = "New Password"
            NewPasswordTextBox.ForeColor = Color.Gray
            NewPasswordTextBox.PasswordChar = ""
        End If
    End Sub
    Private Sub ConfirmPasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.GotFocus
        If ConfirmPasswordTextBox.Text = "Confirm Password" And ConfirmPasswordTextBox.ForeColor = Color.Gray Then
            ConfirmPasswordTextBox.Text = ""
            ConfirmPasswordTextBox.ForeColor = Color.Black
            ConfirmPasswordTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub ConfirmPasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles ConfirmPasswordTextBox.LostFocus
        If ConfirmPasswordTextBox.Text = "" And ConfirmPasswordTextBox.ForeColor = Color.Black Then
            ConfirmPasswordTextBox.Text = "Confirm Password"
            ConfirmPasswordTextBox.ForeColor = Color.Gray
            ConfirmPasswordTextBox.PasswordChar = ""
        End If
    End Sub
    Public Sub ChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidationTimer.Enabled = True
        ChangePasswordStatusLabel.Text = ""
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        NewPasswordTextBox.Text = "New Password"
        NewPasswordTextBox.ForeColor = Color.Gray
        NewPasswordTextBox.PasswordChar = ""
        ConfirmPasswordTextBox.Text = "Confirm Password"
        ConfirmPasswordTextBox.ForeColor = Color.Gray
        ConfirmPasswordTextBox.PasswordChar = ""
        CurrentPasswordStatusLabel.Text = ""
        NewPasswordStatusLabel.Text = ""
        ConfirmPasswordStatusLabel.Text = ""
        CurrentPasswordStatusPictureBox.Image = Nothing
        NewPasswordStatusPictureBox.Image = Nothing
        ConfirmPasswordStatusPictureBox.Image = Nothing
        ActiveControl = ChangePasswordPanel
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select password from ams.staff where binary staff_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Password = MySqlRead.GetString("password")
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
        If Password = CurrentPasswordTextBox.Text And NewPasswordTextBox.Text = ConfirmPasswordTextBox.Text And Script.CheckPassword(NewPasswordTextBox.Text) = 1 And (NewPasswordTextBox.Text <> "New Password" Or NewPasswordTextBox.ForeColor <> Color.Gray) And (ConfirmPasswordTextBox.Text <> "Confirm Password" Or ConfirmPasswordTextBox.ForeColor <> Color.Gray) Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("update ams.staff set password = @password where binary staff_id = @userid", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@password", NewPasswordTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlRead = MySqlComm.ExecuteReader
                Password = NewPasswordTextBox.Text
                ChangePasswordStatusLabel.ForeColor = Color.Green
                ChangePasswordStatusLabel.Text = "Password Successfully Changed!"
                CurrentPasswordTextBox.Text = "Current Password"
                CurrentPasswordTextBox.ForeColor = Color.Gray
                CurrentPasswordTextBox.PasswordChar = ""
                NewPasswordTextBox.Text = "New Password"
                NewPasswordTextBox.ForeColor = Color.Gray
                NewPasswordTextBox.PasswordChar = ""
                ConfirmPasswordTextBox.Text = "Confirm Password"
                ConfirmPasswordTextBox.ForeColor = Color.Gray
                ConfirmPasswordTextBox.PasswordChar = ""
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
            If NewPasswordTextBox.Text = "New Password" And NewPasswordTextBox.ForeColor = Color.Gray Then
                NewPasswordStatusLabel.Text = "Enter your New Password!"
            End If
            If ConfirmPasswordTextBox.Text = "Confirm Password" And ConfirmPasswordTextBox.ForeColor = Color.Gray Then
                ConfirmPasswordStatusLabel.Text = "Retype your New Password!"
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ChangePasswordStatusLabel.Text = ""
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        NewPasswordTextBox.Text = "New Password"
        NewPasswordTextBox.ForeColor = Color.Gray
        NewPasswordTextBox.PasswordChar = ""
        ConfirmPasswordTextBox.Text = "Confirm Password"
        ConfirmPasswordTextBox.ForeColor = Color.Gray
        ConfirmPasswordTextBox.PasswordChar = ""
        CurrentPasswordStatusLabel.Text = ""
        NewPasswordStatusLabel.Text = ""
        ConfirmPasswordStatusLabel.Text = ""
        CurrentPasswordStatusPictureBox.Image = Nothing
        NewPasswordStatusPictureBox.Image = Nothing
        ConfirmPasswordStatusPictureBox.Image = Nothing
    End Sub
End Class