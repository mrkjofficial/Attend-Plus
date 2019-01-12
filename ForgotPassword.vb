Imports MySql.Data.MySqlClient
Public Class ForgotPassword
    Dim UserID As Integer
    Dim Password As String
    Dim SecurityQuestion As String
    Dim SecurityAnswer As String
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
        If ActiveControl Is NewPasswordTextBox And NewPasswordTextBox.Text = "" Then
            NewPasswordStatusLabel.Text = "Enter your New Password!"
            NewPasswordStatusPictureBox.Image = Nothing
        ElseIf ActiveControl Is NewPasswordTextBox And NewPasswordTextBox.Text <> "" And Password = NewPasswordTextBox.Text Then
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
    Private Sub UsernameTextBox_GotFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.GotFocus
        If UsernameTextBox.Text = "Username" And UsernameTextBox.ForeColor = Color.Gray Then
            UsernameTextBox.Text = ""
            UsernameTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub UsernameTextBox_LostFocus(sender As Object, e As EventArgs) Handles UsernameTextBox.LostFocus
        If UsernameTextBox.Text = "" And UsernameTextBox.ForeColor = Color.Black Then
            UsernameTextBox.Text = "Username"
            UsernameTextBox.ForeColor = Color.Gray
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
    Private Sub SecurityAnswerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SecurityAnswerTextBox.KeyUp
        SecurityAnswerTextBox = Script.AutoCapitalize(SecurityAnswerTextBox)
    End Sub
    Public Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ValidationTimer.Enabled = True
        ActiveControl = ForgotPasswordPanel
        UsernameLabel.Visible = True
        UsernameTextBox.Visible = True
        UsernameStatusLabel.Visible = True
        Next1Button.Visible = True
        SecurityQuestionLabel.Visible = False
        SecurityAnswerLabel.Visible = False
        SecurityAnswerTextBox.Visible = False
        SecurityAnswerStatusLabel.Visible = False
        Next2Button.Visible = False
        ForgotPasswordStatusLabel.Visible = False
        NewPasswordLabel.Visible = False
        NewPasswordTextBox.Visible = False
        NewPasswordStatusPictureBox.Visible = False
        NewPasswordStatusLabel.Visible = False
        ConfirmPasswordLabel.Visible = False
        ConfirmPasswordTextBox.Visible = False
        ConfirmPasswordStatusPictureBox.Visible = False
        ConfirmPasswordStatusLabel.Visible = False
        ChangeButton.Visible = False
        ClearButton.Visible = False
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.Gray
        SecurityAnswerTextBox.Text = "Security Answer"
        SecurityAnswerTextBox.ForeColor = Color.Gray
        NewPasswordTextBox.Text = "New Password"
        NewPasswordTextBox.ForeColor = Color.Gray
        NewPasswordTextBox.PasswordChar = ""
        ConfirmPasswordTextBox.Text = "Confirm Password"
        ConfirmPasswordTextBox.ForeColor = Color.Gray
        ConfirmPasswordTextBox.PasswordChar = ""
        UsernameStatusLabel.Text = ""
        SecurityAnswerStatusLabel.Text = ""
        NewPasswordStatusLabel.Text = ""
        ConfirmPasswordStatusLabel.Text = ""
        NewPasswordStatusPictureBox.Image = Nothing
        ConfirmPasswordStatusPictureBox.Image = Nothing
    End Sub
    Private Sub Next1Button_Click(sender As Object, e As EventArgs) Handles Next1Button.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Counter As Boolean = False
            MySqlComm = New MySqlCommand("select * from ams.staff where binary username = @username", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@username", value:=UsernameTextBox.Text)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Counter = True
                UserID = MySqlRead.GetInt64("staff_id")
                Password = MySqlRead.GetString("password")
                If Not IsDBNull(MySqlRead("security_question")) Then
                    SecurityQuestion = MySqlRead.GetString("security_question")
                Else
                    SecurityQuestion = Nothing
                End If
                If Not IsDBNull(MySqlRead("security_answer")) Then
                    SecurityAnswer = MySqlRead.GetString("security_answer")
                Else
                    SecurityAnswer = Nothing
                End If
            End While
            If Counter = True And SecurityQuestion <> Nothing And SecurityAnswer <> Nothing Then
                UsernameLabel.Visible = False
                UsernameTextBox.Visible = False
                UsernameStatusLabel.Visible = False
                Next1Button.Visible = False
                SecurityQuestionLabel.Visible = True
                SecurityAnswerLabel.Visible = True
                SecurityAnswerTextBox.Visible = True
                SecurityAnswerStatusLabel.Visible = True
                Next2Button.Visible = True
                SecurityQuestionLabel.Text = SecurityQuestion
            ElseIf Counter = True And (SecurityQuestion = String.Empty Or SecurityAnswer = String.Empty) Then
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = "Security Question not yet selected. In case of first login, Please use default Username/Password!"
                ErrorBox.ShowDialog()
            Else
                UsernameStatusLabel.Text = "Invalid Username!"
            End If
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Next2Button_Click(sender As Object, e As EventArgs) Handles Next2Button.Click
        If SecurityAnswerTextBox.Text = SecurityAnswer Then
            SecurityQuestionLabel.Visible = False
            SecurityAnswerLabel.Visible = False
            SecurityAnswerTextBox.Visible = False
            SecurityAnswerStatusLabel.Visible = False
            Next2Button.Visible = False
            ForgotPasswordStatusLabel.Visible = True
            NewPasswordLabel.Visible = True
            NewPasswordTextBox.Visible = True
            NewPasswordStatusPictureBox.Visible = True
            NewPasswordStatusLabel.Visible = True
            ConfirmPasswordLabel.Visible = True
            ConfirmPasswordTextBox.Visible = True
            ConfirmPasswordStatusPictureBox.Visible = True
            ConfirmPasswordStatusLabel.Visible = True
            ChangeButton.Visible = True
            ClearButton.Visible = True
        Else
            SecurityAnswerStatusLabel.Text = "Incorrect Security Answer"
        End If
    End Sub
    Private Sub ChangeButton_Click(sender As Object, e As EventArgs) Handles ChangeButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        If NewPasswordTextBox.Text = ConfirmPasswordTextBox.Text And Script.CheckPassword(NewPasswordTextBox.Text) = 1 And (NewPasswordTextBox.Text <> "New Password" Or NewPasswordTextBox.ForeColor <> Color.Gray) And (ConfirmPasswordTextBox.Text <> "Confirm Password" Or ConfirmPasswordTextBox.ForeColor <> Color.Gray) Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("update ams.staff set password = @password where binary staff_id = @userid", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@password", value:=NewPasswordTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@userid", value:=UserID)
                MySqlRead = MySqlComm.ExecuteReader
                Password = NewPasswordTextBox.Text
                ForgotPasswordStatusLabel.ForeColor = Color.Green
                ForgotPasswordStatusLabel.Text = "Password Successfully Changed!"
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
            If NewPasswordTextBox.Text = "New Password" And NewPasswordTextBox.ForeColor = Color.Gray Then
                NewPasswordStatusLabel.Text = "Enter your New Password!"
            End If
            If ConfirmPasswordTextBox.Text = "Confirm Password" And ConfirmPasswordTextBox.ForeColor = Color.Gray Then
                ConfirmPasswordStatusLabel.Text = "Retype your New Password!"
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ForgotPasswordStatusLabel.Text = ""
        NewPasswordTextBox.Text = "New Password"
        NewPasswordTextBox.ForeColor = Color.Gray
        NewPasswordTextBox.PasswordChar = ""
        ConfirmPasswordTextBox.Text = "Confirm Password"
        ConfirmPasswordTextBox.ForeColor = Color.Gray
        ConfirmPasswordTextBox.PasswordChar = ""
        NewPasswordStatusLabel.Text = ""
        ConfirmPasswordStatusLabel.Text = ""
        NewPasswordStatusPictureBox.Image = Nothing
        ConfirmPasswordStatusPictureBox.Image = Nothing
    End Sub
End Class