Imports MySql.Data.MySqlClient
Public Class Login
    Public Property UserID As String
    Public Property FirstName As String
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
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
    Private Sub ConnectionTimer_Tick(sender As Object, e As EventArgs) Handles ConnectionTimer.Tick
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = karan; password = 9832011896; database = ams;"}
        Try
            MysqlConn.Open()
            ConnectionStatusLabel.Text = "Connected!"
            ConnectionStatusLabel.ForeColor = Color.LimeGreen
            CStatusPictureBox.Image = My.Resources.Connected
            MysqlConn.Close()
        Catch
            ConnectionStatusLabel.Text = "Disconnected!"
            ConnectionStatusLabel.ForeColor = Color.Red
            CStatusPictureBox.Image = My.Resources.Disconnected
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CrossButton_Click(sender As Object, e As EventArgs) Handles CrossButton.Click
        End
    End Sub
    Public Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        LoginStatusLabel.Text = ""
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.Gray
        PasswordTextBox.Text = "Password"
        PasswordTextBox.ForeColor = Color.Gray
        PasswordTextBox.PasswordChar = ""
        ShowPasswordCheckBox.CheckState = False
        ActiveControl = LoginPanel
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
    Private Sub PasswordTextBox_GotFocus(sender As Object, e As EventArgs) Handles PasswordTextBox.GotFocus
        If PasswordTextBox.Text = "Password" And PasswordTextBox.ForeColor = Color.Gray Then
            PasswordTextBox.Text = ""
            PasswordTextBox.ForeColor = Color.Black
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub PasswordTextBox_LostFocus(sender As Object, e As EventArgs) Handles PasswordTextBox.LostFocus
        If PasswordTextBox.Text = "" And PasswordTextBox.ForeColor = Color.Black Then
            PasswordTextBox.Text = "Password"
            PasswordTextBox.ForeColor = Color.Gray
            PasswordTextBox.PasswordChar = ""
        End If
    End Sub
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Counter As Boolean = False
            MySqlComm = New MySqlCommand("select * from ams.staff where binary username = @username and binary password = @password", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@username", value:=UsernameTextBox.Text)
            MySqlComm.Parameters.AddWithValue("@password", value:=PasswordTextBox.Text)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Counter = True
                UserID = MySqlRead.GetInt64("staff_id")
                FirstName = MySqlRead.GetString("first_name")
            End While
            If Counter = True Then
                Home.WelcomeLabel.Text = "Welcome" & vbNewLine & FirstName + "!"
                Home.Home_Load(e, e)
                Home.Show()
                Hide()
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
            Else
                LoginStatusLabel.Text = "Invalid Username/Password!"
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
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        UsernameTextBox.Text = "Username"
        UsernameTextBox.ForeColor = Color.Gray
        PasswordTextBox.Text = "Password"
        PasswordTextBox.PasswordChar = ""
        PasswordTextBox.ForeColor = Color.Gray
        LoginStatusLabel.Text = ""
        ShowPasswordCheckBox.CheckState = 0
    End Sub
    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        If ShowPasswordCheckBox.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        ElseIf PasswordTextBox.Text = "Password" Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "*"
        End If
    End Sub
    Private Sub ForgotPasswordLinkLabel_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ForgotPasswordLinkLabel.LinkClicked
        ForgotPassword.ForgotPassword_Load(e, e)
        ForgotPassword.ShowDialog()
    End Sub
    Private Sub InfoButton_Click(sender As Object, e As EventArgs) Handles InfoButton.Click
        Info.ShowDialog()
    End Sub
End Class