Imports MySql.Data.MySqlClient
Public Class ChangeSecurityQuestion
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
        If ActiveControl Is SecurityQuestionComboBox And SecurityQuestionComboBox.SelectedIndex = 0 Then
            SecurityQuestionStatusLabel.Text = "Please select your Security Question!"
        ElseIf ActiveControl Is SecurityQuestionComboBox And SecurityQuestionComboBox.SelectedIndex <> 0 Then
            SecurityQuestionStatusLabel.Text = ""
        End If
        If ActiveControl Is SecurityAnswerTextBox And SecurityAnswerTextBox.Text = "" Then
            SecurityAnswerStatusLabel.Text = "Please enter your Security Answer!"
        ElseIf ActiveControl Is SecurityAnswerTextBox And SecurityAnswerTextBox.Text <> "" Then
            SecurityAnswerStatusLabel.Text = ""
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
    Private Sub SecurityAnswerTextBox_GotFocus(sender As Object, e As EventArgs) Handles SecurityAnswerTextBox.GotFocus
        If SecurityAnswerTextBox.Text = "Security Answer" And SecurityAnswerTextBox.ForeColor = Color.Gray Then
            SecurityAnswerTextBox.Text = ""
            SecurityAnswerTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub SecurityAnswerTextBox_LostFocus(sender As Object, e As EventArgs) Handles SecurityAnswerTextBox.LostFocus
        If SecurityAnswerTextBox.Text = "" And SecurityAnswerTextBox.ForeColor = Color.Black Then
            SecurityAnswerTextBox.Text = "Security Answer"
            SecurityAnswerTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub SecurityAnswerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SecurityAnswerTextBox.KeyUp
        SecurityAnswerTextBox = Script.AutoCapitalize(SecurityAnswerTextBox)
    End Sub
    Public Sub ChangeSecurityQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidationTimer.Enabled = True
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        ActiveControl = ChangeSecurityQuestionPanel
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select password,security_question,security_answer from ams.staff where binary staff_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Password = MySqlRead.GetString("password")
                If Not IsDBNull(MySqlRead("security_question")) Then
                    SecurityQuestionComboBox.SelectedIndex = SecurityQuestionComboBox.FindString(MySqlRead.GetString("security_question"))
                Else
                    SecurityQuestionComboBox.SelectedIndex = 0
                End If
                If Not IsDBNull(MySqlRead("security_answer")) Then
                    SecurityAnswerTextBox.ForeColor = Color.Black
                    SecurityAnswerTextBox.Text = MySqlRead.GetString("security_answer")
                Else
                    SecurityAnswerTextBox.ForeColor = Color.Gray
                    SecurityAnswerTextBox.Text = "Security Answer"
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
        If Password = CurrentPasswordTextBox.Text And SecurityQuestionComboBox.SelectedIndex <> 0 And (SecurityAnswerTextBox.Text <> "Security Answer" Or SecurityAnswerTextBox.ForeColor <> Color.Gray) Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("update ams.staff set security_question = @securityquestion,security_answer = @securityanswer where binary staff_id = @userid", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@securityquestion", value:=SecurityQuestionComboBox.SelectedItem)
                MySqlComm.Parameters.AddWithValue("@securityanswer", value:=SecurityAnswerTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlRead = MySqlComm.ExecuteReader
                ChangeSecurityQuestionStatusLabel.ForeColor = Color.Green
                ChangeSecurityQuestionStatusLabel.Text = "Security Question Successfully Changed!"
                CurrentPasswordTextBox.Text = "Current Password"
                CurrentPasswordTextBox.ForeColor = Color.Gray
                CurrentPasswordTextBox.PasswordChar = ""
                SecurityQuestionComboBox.SelectedIndex = 0
                SecurityAnswerTextBox.Text = "Security Answer"
                SecurityAnswerTextBox.ForeColor = Color.Gray
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
            If SecurityQuestionComboBox.SelectedIndex = 0 Then
                SecurityQuestionStatusLabel.Text = "Please select your Security Question!"
            End If
            If SecurityAnswerTextBox.Text = "Security Answer" And SecurityAnswerTextBox.ForeColor = Color.Gray Then
                SecurityAnswerStatusLabel.Text = "Please enter your Security Answer!"
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ChangeSecurityQuestionStatusLabel.Text = ""
        CurrentPasswordTextBox.Text = "Current Password"
        CurrentPasswordTextBox.ForeColor = Color.Gray
        CurrentPasswordTextBox.PasswordChar = ""
        SecurityQuestionComboBox.SelectedIndex = 0
        SecurityAnswerTextBox.Text = "Security Answer"
        SecurityAnswerTextBox.ForeColor = Color.Gray
        CurrentPasswordStatusLabel.Text = ""
        SecurityQuestionStatusLabel.Text = ""
        SecurityAnswerStatusLabel.Text = ""
        CurrentPasswordStatusPictureBox.Image = Nothing
    End Sub
End Class