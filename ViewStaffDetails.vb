Imports MySql.Data.MySqlClient
Imports System.IO
Public Class ViewStaffDetails
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub MenuStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub MenuStrip_MouseUp(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub MenuStrip_MouseMove(sender As Object, e As MouseEventArgs) Handles MenuStrip.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point With {
                    .X = Location.X + (e.X - MouseDownX),
                    .Y = Location.Y + (e.Y - MouseDownY)
                }
            Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub MinusButton_Click(sender As Object, e As EventArgs) Handles MinusButton.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub CrossButton_Click(sender As Object, e As EventArgs) Handles CrossButton.Click
        End
    End Sub
    Private Sub AddMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles AddMenuItem.DropDownOpened
        AddMenuItem.ForeColor = Color.DarkBlue
    End Sub
    Private Sub AddMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles AddMenuItem.DropDownClosed
        AddMenuItem.ForeColor = Color.White
    End Sub
    Private Sub ManageMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles ManageMenuItem.DropDownOpened
        ManageMenuItem.ForeColor = Color.DarkBlue
    End Sub
    Private Sub ManageMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ManageMenuItem.DropDownClosed
        ManageMenuItem.ForeColor = Color.White
    End Sub
    Private Sub OptionsMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles OptionsMenuItem.DropDownOpened
        OptionsMenuItem.ForeColor = Color.DarkBlue
    End Sub
    Private Sub OptionsMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles OptionsMenuItem.DropDownClosed
        OptionsMenuItem.ForeColor = Color.White
    End Sub
    Private Sub ProfileMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles ProfileMenuItem.DropDownOpened
        ProfileMenuItem.ForeColor = Color.DarkBlue
    End Sub
    Private Sub ProfileMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles ProfileMenuItem.DropDownClosed
        ProfileMenuItem.ForeColor = Color.White
    End Sub
    Private Sub AboutMenuItem_DropDownOpened(sender As Object, e As EventArgs) Handles AboutMenuItem.DropDownOpened
        AboutMenuItem.ForeColor = Color.DarkBlue
    End Sub
    Private Sub AboutMenuItem_DropDownClosed(sender As Object, e As EventArgs) Handles AboutMenuItem.DropDownClosed
        AboutMenuItem.ForeColor = Color.White
    End Sub
    Private Sub HomeMenuItem_Click(sender As Object, e As EventArgs) Handles HomeMenuItem.Click
        Home.Home_Load(e, e)
        Home.Show()
        Hide()
    End Sub
    Private Sub AddStaffDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffDetailsMenuItem.Click
        Home.StaffDetails = True
        AddUpdateStaffDetails.AddStaffDetailsMenuItem.Enabled = False
        AddUpdateStaffDetails.AddButton.Visible = True
        AddUpdateStaffDetails.UpdateButton.Visible = False
        AddUpdateStaffDetails.AddUpdateStaffDetails_Load(e, e)
        AddUpdateStaffDetails.Show()
        Hide()
    End Sub
    Private Sub AddStudentDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentDetailsMenuItem.Click
        Home.StudentDetails = True
        AddUpdateStudentDetails.AddStudentDetailsMenuItem.Enabled = False
        AddUpdateStudentDetails.AddButton.Visible = True
        AddUpdateStudentDetails.UpdateButton.Visible = False
        AddUpdateStudentDetails.AddUpdateStudentDetails_Load(e, e)
        AddUpdateStudentDetails.Show()
        Hide()
    End Sub
    Private Sub ManageStaffDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStaffDetailsMenuItem.Click
        ManageStaffDetails.ManageStaffDetails_Load(e, e)
        ManageStaffDetails.Show()
        Hide()
    End Sub
    Private Sub ManageStudentDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles ManageStudentDetailsMenuItem.Click
        ManageStudentDetails.ManageStudentDetails_Load(e, e)
        ManageStudentDetails.Show()
        Hide()
    End Sub
    Private Sub ViewAttendenceMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAttendenceMenuItem.Click
        ViewAttendence.ViewAttendence_Load(e, e)
        ViewAttendence.Show()
        Hide()
    End Sub
    Private Sub ChangeMobileNoMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeMobileNoMenuItem.Click
        ChangeMobileNo.ChangeMobileNo_Load(e, e)
        ChangeMobileNo.ShowDialog()
    End Sub
    Private Sub ChangeSecurityQuestionMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeSecurityQuestionMenuItem.Click
        ChangeSecurityQuestion.ChangeSecurityQuestion_Load(e, e)
        ChangeSecurityQuestion.ShowDialog()
    End Sub
    Private Sub RestoreDefaultsMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreDefaultsMenuItem.Click
        RestoreDefaults.ShowDialog()
    End Sub
    Private Sub ViewProfileMenuItem_Click(sender As Object, e As EventArgs) Handles ViewProfileMenuItem.Click
        ViewProfile.ViewProfile_Load(e, e)
        ViewProfile.Show()
        Hide()
    End Sub
    Private Sub UpdateProfileMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateProfileMenuItem.Click
        UpdateProfile.UpdateProfile_Load(e, e)
        UpdateProfile.Show()
        Hide()
    End Sub
    Private Sub ChangePasswordMenuItem_Click(sender As Object, e As EventArgs) Handles ChangePasswordMenuItem.Click
        ChangePassword.ChangePassword_Load(e, e)
        ChangePassword.ShowDialog()
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutMenuItem.Click
        Login.Login_Load(e, e)
        Login.Show()
        Hide()
    End Sub
    Private Sub AboutAttendMenuItem_Click(sender As Object, e As EventArgs) Handles AboutAttendMenuItem.Click
        AboutAttend.ShowDialog()
    End Sub
    Private Sub AboutUsMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsMenuItem.Click
        AboutUs.ShowDialog()
    End Sub
    Private Sub ConnectionTimer_Tick(sender As Object, e As EventArgs) Handles ConnectionTimer.Tick
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
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
    Private Sub TimeTimer_Tick(sender As Object, e As EventArgs) Handles TimeTimer.Tick
        TimeLabel.Text = Date.Now.ToString("hh:mm:ss tt | dd-MM-yyyy")
    End Sub
    Public Sub ViewStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        TimeTimer.Enabled = True
        ActiveControl = ViewStaffDetailsPanel
        If Login.UserID = 1 Then
            AddStaffDetailsMenuItem.Visible = True
            AddStudentDetailsMenuItem.Visible = True
            ManageStaffDetailsMenuItem.Visible = True
            ManageStudentDetailsMenuItem.Visible = True
            ViewAttendenceMenuItem.Visible = True
            ChangeMobileNoMenuItem.Visible = False
            ChangeSecurityQuestionMenuItem.Visible = False
            RestoreDefaultsMenuItem.Visible = True
            ViewProfileMenuItem.Visible = False
            UpdateProfileMenuItem.Visible = True
            ChangePasswordMenuItem.Visible = True
            LogoutMenuItem.Visible = True
            AboutAttendMenuItem.Visible = True
            AboutUsMenuItem.Visible = True
        Else
            AddStaffDetailsMenuItem.Visible = False
            AddStudentDetailsMenuItem.Visible = True
            ManageStaffDetailsMenuItem.Visible = False
            ManageStudentDetailsMenuItem.Visible = True
            ViewAttendenceMenuItem.Visible = True
            ChangeMobileNoMenuItem.Visible = True
            ChangeSecurityQuestionMenuItem.Visible = True
            RestoreDefaultsMenuItem.Visible = False
            ViewProfileMenuItem.Visible = True
            UpdateProfileMenuItem.Visible = False
            ChangePasswordMenuItem.Visible = True
            LogoutMenuItem.Visible = True
            AboutAttendMenuItem.Visible = True
            AboutUsMenuItem.Visible = True
        End If
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select * from ams.staff where binary staff_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@userid", value:=ManageStaffDetails.ID)
            MySqlRead = MySqlComm.ExecuteReader
            Dim PP() As Byte
            While MySqlRead.Read
                If Not IsDBNull(MySqlRead("first_name")) Then
                    FirstNameStatusLabel.ForeColor = Color.Black
                    FirstNameStatusLabel.Text = MySqlRead.GetString("first_name")
                Else
                    FirstNameStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("middle_name")) Then
                    MiddleNameStatusLabel.ForeColor = Color.Black
                    MiddleNameStatusLabel.Text = MySqlRead.GetString("middle_name")
                Else
                    MiddleNameStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("last_name")) Then
                    LastNameStatusLabel.ForeColor = Color.Black
                    LastNameStatusLabel.Text = MySqlRead.GetString("last_name")
                Else
                    LastNameStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("dob")) Then
                    BirthDateStatusLabel.ForeColor = Color.Black
                    BirthDateStatusLabel.Text = MySqlRead.GetDateTime("dob").ToString("dd-MMM-yyyy")
                Else
                    BirthDateStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("gender")) Then
                    GenderStatusLabel.ForeColor = Color.Black
                    GenderStatusLabel.Text = MySqlRead.GetString("gender")
                Else
                    GenderStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("email_id")) Then
                    EmailIDStatusLabel.ForeColor = Color.Black
                    EmailIDStatusLabel.Text = MySqlRead.GetString("email_id")
                Else
                    EmailIDStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("mobile_no")) And MySqlRead.GetInt64("mobile_no") <> 0 Then
                    MobileNoStatusLabel.ForeColor = Color.Black
                    MobileNoStatusLabel.Text = MySqlRead.GetInt64("mobile_no")
                Else
                    MobileNoStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("address")) Then
                    AddressStatusLabel.ForeColor = Color.Black
                    AddressStatusLabel.Text = MySqlRead.GetString("address")
                Else
                    AddressStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("zip_code")) And MySqlRead.GetInt32("zip_code") <> 0 Then
                    ZIPCodeStatusLabel.ForeColor = Color.Black
                    ZIPCodeStatusLabel.Text = MySqlRead.GetInt32("zip_code")
                Else
                    ZIPCodeStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("city")) Then
                    CityStatusLabel.ForeColor = Color.Black
                    CityStatusLabel.Text = MySqlRead.GetString("city")
                Else
                    CityStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("province")) Then
                    ProvinceStatusLabel.ForeColor = Color.Black
                    ProvinceStatusLabel.Text = MySqlRead.GetString("province")
                Else
                    ProvinceStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("country")) Then
                    CountryStatusLabel.ForeColor = Color.Black
                    CountryStatusLabel.Text = MySqlRead.GetString("country")
                Else
                    CountryStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("username")) Then
                    UsernameStatusLabel.ForeColor = Color.Black
                    UsernameStatusLabel.Text = MySqlRead.GetString("username")
                Else
                    UsernameStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("password")) Then
                    PasswordStatusLabel.ForeColor = Color.Black
                    PasswordStatusLabel.Text = MySqlRead.GetString("password")
                Else
                    PasswordStatusLabel.Text = ""
                End If
                If Not IsDBNull(MySqlRead("profile_picture")) Then
                    PP = MySqlRead("profile_picture")
                    Dim MS As New MemoryStream(PP)
                    ProfilePictureBox.Image = Image.FromStream(MS)
                Else
                    ProfilePictureBox.Image = My.Resources.Profile_Picture
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
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Home.StaffDetails = False
        AddUpdateStaffDetails.AddStaffDetailsMenuItem.Enabled = True
        AddUpdateStaffDetails.AddButton.Visible = False
        AddUpdateStaffDetails.UpdateButton.Visible = True
        AddUpdateStaffDetails.AddUpdateStaffDetails_Load(e, e)
        AddUpdateStaffDetails.Show()
        Hide()
    End Sub
    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        DeleteStaffDetails.DeleteStaffDetails_Load(e, e)
        DeleteStaffDetails.ShowDialog()
    End Sub
    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        ManageStaffDetails.ManageStaffDetails_Load(e, e)
        ManageStaffDetails.Show()
        Hide()
    End Sub
End Class