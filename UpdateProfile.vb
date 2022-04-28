Imports System.IO
Imports MySql.Data.MySqlClient
Public Class UpdateProfile
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Dim GenderValue As String
    Dim InvalidEmail As Boolean
    Dim EmailIDExists As Boolean
    Dim Script As New Scripts
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
    Private Sub ValidationTimer_Tick(sender As Object, e As EventArgs) Handles ValidationTimer.Tick
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        EmailIDExists = False
        MysqlConn.Open()
        MySqlComm = New MySqlCommand("select * from ams.staff where email_id = @emailid and binary staff_id != @userid", MysqlConn)
        MySqlComm.Parameters.AddWithValue("@emailid", value:=EmailIDTextBox.Text)
        MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
        MySqlRead = MySqlComm.ExecuteReader
        While MySqlRead.Read
            EmailIDExists = True
        End While
        MysqlConn.Close()
        MysqlConn.Dispose()
        If ActiveControl Is FirstNameTextBox And FirstNameTextBox.Text = "" Then
            FirstNameStatusLabel.Text = "Please enter your First Name!"
        ElseIf ActiveControl Is FirstNameTextBox And FirstNameTextBox.Text <> "" Then
            FirstNameStatusLabel.Text = ""
        End If
        If ActiveControl Is LastNameTextBox And LastNameTextBox.Text = "" Then
            LastNameStatusLabel.Text = "Please enter your Last Name!"
        ElseIf ActiveControl Is LastNameTextBox And LastNameTextBox.Text <> "" Then
            LastNameStatusLabel.Text = ""
        End If
        If ActiveControl Is BirthDatePicker And BirthDatePicker.Value.Date = Date.Now.Date Then
            BirthDateStatusLabel.Text = "Please select your Birth Date!"
        ElseIf ActiveControl Is BirthDatePicker And BirthDatePicker.Value.Date > Date.Now.Date Then
            BirthDateStatusLabel.Text = "Invalid Birth Date!"
        ElseIf ActiveControl Is BirthDatePicker And BirthDatePicker.Value.Date < Date.Now.Date Then
            BirthDateStatusLabel.Text = ""
        End If
        If MaleRadioButton.Checked = True Then
            GenderValue = "Male"
            GenderStatusLabel.Text = ""
        ElseIf FemaleRadioButton.Checked = True Then
            GenderValue = "Female"
            GenderStatusLabel.Text = ""
        End If
        If ActiveControl Is EmailIDTextBox And EmailIDTextBox.Text = "" Then
            EmailIDStatusLabel.Text = "Please enter your Email ID!"
        ElseIf ActiveControl Is EmailIDTextBox And (InStr(EmailIDTextBox.Text, "@") = False Or InStr(EmailIDTextBox.Text, ".") = False) Then
            EmailIDStatusLabel.Text = "Invalid Email ID!"
            InvalidEmail = True
        ElseIf ActiveControl Is EmailIDTextBox And EmailIDExists = True Then
            EmailIDStatusLabel.Text = "Email ID already exists!"
        ElseIf ActiveControl Is EmailIDTextBox And EmailIDExists = False And EmailIDTextBox.Text <> "" Then
            EmailIDStatusLabel.Text = ""
            InvalidEmail = False
        End If
        If ActiveControl Is MobileNoTextBox And MobileNoTextBox.Text = "" Then
            MobileNoStatusLabel.Text = "Please enter your Mobile No.!"
        ElseIf ActiveControl Is MobileNoTextBox And (IsNumeric(MobileNoTextBox.Text) = False Or MobileNoTextBox.Text.Length() <> 10) Then
            MobileNoStatusLabel.Text = "Invalid Mobile No.!"
        ElseIf ActiveControl Is MobileNoTextBox And IsNumeric(MobileNoTextBox.Text) = True And MobileNoTextBox.Text.Length() = 10 And MobileNoTextBox.Text <> "" Then
            MobileNoStatusLabel.Text = ""
        End If
        If ActiveControl Is AddressTextBox And AddressTextBox.Text = "" Then
            AddressStatusLabel.Text = "Please enter your Address!"
        ElseIf ActiveControl Is AddressTextBox And AddressTextBox.Text <> "" Then
            AddressStatusLabel.Text = ""
        End If
        If ActiveControl Is ZipCodeTextBox And ZipCodeTextBox.Text = "" Then
            ZIPCodeStatusLabel.Text = "Please enter your ZIP Code!"
        ElseIf ActiveControl Is ZipCodeTextBox And ZipCodeTextBox.Text <> "" Then
            ZIPCodeStatusLabel.Text = ""
        End If
        If ActiveControl Is CityTextBox And CityTextBox.Text = "" Then
            CityStatusLabel.Text = "Please enter your City!"
        ElseIf ActiveControl Is CityTextBox And CityTextBox.Text <> "" Then
            CityStatusLabel.Text = ""
        End If
        If ActiveControl Is ProvinceTextBox And ProvinceTextBox.Text = "" Then
            ProvinceStatusLabel.Text = "Please enter your Province!"
        ElseIf ActiveControl Is ProvinceTextBox And ProvinceTextBox.Text <> "" Then
            ProvinceStatusLabel.Text = ""
        End If
        If ActiveControl Is CountryTextBox And CountryTextBox.Text = "" Then
            CountryStatusLabel.Text = "Please enter your Country!"
        ElseIf ActiveControl Is CountryTextBox And CountryTextBox.Text <> "" Then
            CountryStatusLabel.Text = ""
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
    Private Sub FirstNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.GotFocus
        If FirstNameTextBox.Text = "First Name" And FirstNameTextBox.ForeColor = Color.Gray Then
            FirstNameTextBox.Text = ""
            FirstNameTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub FirstNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles FirstNameTextBox.LostFocus
        If FirstNameTextBox.Text = "" And FirstNameTextBox.ForeColor = Color.Black Then
            FirstNameTextBox.Text = "First Name"
            FirstNameTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub MiddleNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.GotFocus
        If MiddleNameTextBox.Text = "Middle Name" And MiddleNameTextBox.ForeColor = Color.Gray Then
            MiddleNameTextBox.Text = ""
            MiddleNameTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub MiddleNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles MiddleNameTextBox.LostFocus
        If MiddleNameTextBox.Text = "" And MiddleNameTextBox.ForeColor = Color.Black Then
            MiddleNameTextBox.Text = "Middle Name"
            MiddleNameTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub LastNameTextBox_GotFocus(sender As Object, e As EventArgs) Handles LastNameTextBox.GotFocus
        If LastNameTextBox.Text = "Last Name" And LastNameTextBox.ForeColor = Color.Gray Then
            LastNameTextBox.Text = ""
            LastNameTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub LastNameTextBox_LostFocus(sender As Object, e As EventArgs) Handles LastNameTextBox.LostFocus
        If LastNameTextBox.Text = "" And LastNameTextBox.ForeColor = Color.Black Then
            LastNameTextBox.Text = "Last Name"
            LastNameTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub EmailIDTextBox_GotFocus(sender As Object, e As EventArgs) Handles EmailIDTextBox.GotFocus
        If EmailIDTextBox.Text = "Email ID" And EmailIDTextBox.ForeColor = Color.Gray Then
            EmailIDTextBox.Text = ""
            EmailIDTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub EmailIDTextBox_LostFocus(sender As Object, e As EventArgs) Handles EmailIDTextBox.LostFocus
        If EmailIDTextBox.Text = "" And EmailIDTextBox.ForeColor = Color.Black Then
            EmailIDTextBox.Text = "Email ID"
            EmailIDTextBox.ForeColor = Color.Gray
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
    Private Sub AddressTextBox_GotFocus(sender As Object, e As EventArgs) Handles AddressTextBox.GotFocus
        If AddressTextBox.Text = "Address" And AddressTextBox.ForeColor = Color.Gray Then
            AddressTextBox.Text = ""
            AddressTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub AddressTextBox_LostFocus(sender As Object, e As EventArgs) Handles AddressTextBox.LostFocus
        If AddressTextBox.Text = "" And AddressTextBox.ForeColor = Color.Black Then
            AddressTextBox.Text = "Address"
            AddressTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub ZipCodeTextBox_GotFocus(sender As Object, e As EventArgs) Handles ZipCodeTextBox.GotFocus
        If ZipCodeTextBox.Text = "ZIP Code" And ZipCodeTextBox.ForeColor = Color.Gray Then
            ZipCodeTextBox.Text = ""
            ZipCodeTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ZipCodeTextBox_LostFocus(sender As Object, e As EventArgs) Handles ZipCodeTextBox.LostFocus
        If ZipCodeTextBox.Text = "" And ZipCodeTextBox.ForeColor = Color.Black Then
            ZipCodeTextBox.Text = "ZIP Code"
            ZipCodeTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub CityTextBox_GotFocus(sender As Object, e As EventArgs) Handles CityTextBox.GotFocus
        If CityTextBox.Text = "City" And CityTextBox.ForeColor = Color.Gray Then
            CityTextBox.Text = ""
            CityTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CityTextBox_LostFocus(sender As Object, e As EventArgs) Handles CityTextBox.LostFocus
        If CityTextBox.Text = "" And CityTextBox.ForeColor = Color.Black Then
            CityTextBox.Text = "City"
            CityTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub ProvinceTextBox_GotFocus(sender As Object, e As EventArgs) Handles ProvinceTextBox.GotFocus
        If ProvinceTextBox.Text = "Province" And ProvinceTextBox.ForeColor = Color.Gray Then
            ProvinceTextBox.Text = ""
            ProvinceTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub ProvinceTextBox_LostFocus(sender As Object, e As EventArgs) Handles ProvinceTextBox.LostFocus
        If ProvinceTextBox.Text = "" And ProvinceTextBox.ForeColor = Color.Black Then
            ProvinceTextBox.Text = "Province"
            ProvinceTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Private Sub CountryTextBox_GotFocus(sender As Object, e As EventArgs) Handles CountryTextBox.GotFocus
        If CountryTextBox.Text = "Country" And CountryTextBox.ForeColor = Color.Gray Then
            CountryTextBox.Text = ""
            CountryTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub CountryTextBox_LostFocus(sender As Object, e As EventArgs) Handles CountryTextBox.LostFocus
        If CountryTextBox.Text = "" And CountryTextBox.ForeColor = Color.Black Then
            CountryTextBox.Text = "Country"
            CountryTextBox.ForeColor = Color.Gray
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
    Private Sub FirstNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles FirstNameTextBox.KeyUp
        FirstNameTextBox = Script.AutoCapitalize(FirstNameTextBox)
    End Sub
    Private Sub MiddleNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles MiddleNameTextBox.KeyUp
        MiddleNameTextBox = Script.AutoCapitalize(MiddleNameTextBox)
    End Sub
    Private Sub LastNameTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles LastNameTextBox.KeyUp
        LastNameTextBox = Script.AutoCapitalize(LastNameTextBox)
    End Sub
    Private Sub AddressTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles AddressTextBox.KeyUp
        AddressTextBox = Script.AutoCapitalize(AddressTextBox)
    End Sub
    Private Sub CityTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles CityTextBox.KeyUp
        CityTextBox = Script.AutoCapitalize(CityTextBox)
    End Sub
    Private Sub ProvinceTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles ProvinceTextBox.KeyUp
        ProvinceTextBox = Script.AutoCapitalize(ProvinceTextBox)
    End Sub
    Private Sub CountryTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles CountryTextBox.KeyUp
        CountryTextBox = Script.AutoCapitalize(CountryTextBox)
    End Sub
    Private Sub SecurityAnswerTextBox_KeyUp(sender As Object, e As KeyEventArgs) Handles SecurityAnswerTextBox.KeyUp
        SecurityAnswerTextBox = Script.AutoCapitalize(SecurityAnswerTextBox)
    End Sub
    Public Sub UpdateProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        TimeTimer.Enabled = True
        ValidationTimer.Enabled = True
        ActiveControl = UpdateProfilePanel
        UpdateProfileStatusLabel.Text = "Fields marked with * are mandatory!"
        UpdateProfileStatusLabel.ForeColor = Color.Red
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
            MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
            MySqlRead = MySqlComm.ExecuteReader
            Dim PP() As Byte
            While MySqlRead.Read
                If Not IsDBNull(MySqlRead("first_name")) Then
                    FirstNameTextBox.ForeColor = Color.Black
                    FirstNameTextBox.Text = MySqlRead.GetString("first_name")
                Else
                    FirstNameTextBox.ForeColor = Color.Gray
                    FirstNameTextBox.Text = "First Name"
                End If
                If Not IsDBNull(MySqlRead("middle_name")) Then
                    MiddleNameTextBox.ForeColor = Color.Black
                    MiddleNameTextBox.Text = MySqlRead.GetString("middle_name")
                Else
                    MiddleNameTextBox.ForeColor = Color.Gray
                    MiddleNameTextBox.Text = "Middle Name"
                End If
                If Not IsDBNull(MySqlRead("last_name")) Then
                    LastNameTextBox.ForeColor = Color.Black
                    LastNameTextBox.Text = MySqlRead.GetString("last_name")
                Else
                    LastNameTextBox.ForeColor = Color.Gray
                    LastNameTextBox.Text = "Last Name"
                End If
                If Not IsDBNull(MySqlRead("dob")) Then
                    BirthDatePicker.Value = MySqlRead.GetDateTime("dob")
                Else
                    BirthDatePicker.Value = Date.Now
                End If
                If Not IsDBNull(MySqlRead("gender")) Then
                    If MySqlRead.GetString("gender") = "Male" Then
                        MaleRadioButton.Checked = True
                    ElseIf MySqlRead.GetString("gender") = "Female" Then
                        FemaleRadioButton.Checked = True
                    End If
                Else
                    MaleRadioButton.Checked = False
                    FemaleRadioButton.Checked = False
                End If
                If Not IsDBNull(MySqlRead("email_id")) Then
                    EmailIDTextBox.ForeColor = Color.Black
                    EmailIDTextBox.Text = MySqlRead.GetString("email_id")
                Else
                    EmailIDTextBox.ForeColor = Color.Gray
                    EmailIDTextBox.Text = "Email ID"
                End If
                If Not IsDBNull(MySqlRead("mobile_no")) And MySqlRead.GetInt64("mobile_no") <> 0 Then
                    MobileNoTextBox.ForeColor = Color.Black
                    MobileNoTextBox.Text = MySqlRead.GetInt64("mobile_no")
                Else
                    MobileNoTextBox.ForeColor = Color.Gray
                    MobileNoTextBox.Text = "Mobile No."
                End If
                If Not IsDBNull(MySqlRead("address")) Then
                    AddressTextBox.ForeColor = Color.Black
                    AddressTextBox.Text = MySqlRead.GetString("address")
                Else
                    AddressTextBox.ForeColor = Color.Gray
                    AddressTextBox.Text = "Address"
                End If
                If Not IsDBNull(MySqlRead("zip_code")) And MySqlRead.GetInt32("zip_code") <> 0 Then
                    ZipCodeTextBox.ForeColor = Color.Black
                    ZipCodeTextBox.Text = MySqlRead.GetInt32("zip_code")
                Else
                    ZipCodeTextBox.ForeColor = Color.Gray
                    ZipCodeTextBox.Text = "ZIP Code"
                End If
                If Not IsDBNull(MySqlRead("city")) Then
                    CityTextBox.ForeColor = Color.Black
                    CityTextBox.Text = MySqlRead.GetString("city")
                Else
                    CityTextBox.ForeColor = Color.Gray
                    CityTextBox.Text = "City"
                End If
                If Not IsDBNull(MySqlRead("province")) Then
                    ProvinceTextBox.ForeColor = Color.Black
                    ProvinceTextBox.Text = MySqlRead.GetString("province")
                Else
                    ProvinceTextBox.ForeColor = Color.Gray
                    ProvinceTextBox.Text = "Province"
                End If
                If Not IsDBNull(MySqlRead("country")) Then
                    CountryTextBox.ForeColor = Color.Black
                    CountryTextBox.Text = MySqlRead.GetString("country")
                Else
                    CountryTextBox.ForeColor = Color.Gray
                    CountryTextBox.Text = "Country"
                End If
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
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Dim MName As String
        Dim MS As New MemoryStream
        ProfilePictureBox.Image.Save(MS, ProfilePictureBox.Image.RawFormat)
        If MiddleNameTextBox.Text = "Middle Name" And MiddleNameTextBox.ForeColor = Color.Gray Then
            MName = Nothing
        Else
            MName = MiddleNameTextBox.Text
        End If
        If (FirstNameTextBox.Text <> "" Or FirstNameTextBox.ForeColor <> Color.Gray) And (LastNameTextBox.Text <> "" Or LastNameTextBox.ForeColor <> Color.Gray) And BirthDatePicker.Value.Date < Date.Now.Date And GenderValue <> "" And (EmailIDTextBox.Text <> "" Or EmailIDTextBox.ForeColor <> Color.Gray) And InvalidEmail = False And EmailIDExists = False And (MobileNoTextBox.Text <> "" Or MobileNoTextBox.ForeColor <> Color.Gray) And IsNumeric(MobileNoTextBox.Text) = True And MobileNoTextBox.Text.Length() = 10 And (AddressTextBox.Text <> "" Or AddressTextBox.ForeColor <> Color.Gray) And (ZipCodeTextBox.Text <> "" Or ZipCodeTextBox.ForeColor <> Color.Gray) And (CityTextBox.Text <> "" Or CityTextBox.ForeColor <> Color.Gray) And (ProvinceTextBox.Text <> "" Or ProvinceTextBox.ForeColor <> Color.Gray) And (CountryTextBox.Text <> "" Or CountryTextBox.ForeColor <> Color.Gray) And SecurityQuestionComboBox.SelectedIndex <> 0 And (SecurityAnswerTextBox.Text <> "" Or SecurityAnswerTextBox.ForeColor <> Color.Gray) Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("update ams.staff set first_name = @firstname,middle_name = @middlename,last_name = @lastname,dob = @birthdate,gender = @gender,email_id = @emailid,mobile_no = @mobileno,address = @address,zip_code = @zipcode,city = @city,province = @province,country = @country,security_question = @securityquestion,security_answer = @securityanswer,profile_picture = @profilepicture where binary staff_id = @userid", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@firstname", value:=FirstNameTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@middlename", value:=MName)
                MySqlComm.Parameters.AddWithValue("@lastname", value:=LastNameTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@birthdate", value:=BirthDatePicker.Value.ToString("yyyy-MM-dd"))
                MySqlComm.Parameters.AddWithValue("@gender", value:=GenderValue)
                MySqlComm.Parameters.AddWithValue("@emailid", value:=EmailIDTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@mobileno", value:=Val(MobileNoTextBox.Text))
                MySqlComm.Parameters.AddWithValue("@address", value:=AddressTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@zipcode", value:=Val(ZipCodeTextBox.Text))
                MySqlComm.Parameters.AddWithValue("@city", value:=CityTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@province", value:=ProvinceTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@country", value:=CountryTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@securityquestion", value:=SecurityQuestionComboBox.SelectedItem)
                MySqlComm.Parameters.AddWithValue("@securityanswer", value:=SecurityAnswerTextBox.Text)
                MySqlComm.Parameters.AddWithValue("@profilepicture", value:=MS.ToArray())
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlRead = MySqlComm.ExecuteReader
                UpdateProfileStatusLabel.ForeColor = Color.Green
                UpdateProfileStatusLabel.Text = "Profile Updated!"
                MysqlConn.Close()
            Catch ex As MySqlException
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = ex.Message
                ErrorBox.ShowDialog()
            Finally
                MysqlConn.Dispose()
            End Try
        Else
            If FirstNameTextBox.Text = "First Name" And FirstNameTextBox.ForeColor = Color.Gray Then
                FirstNameStatusLabel.Text = "Please enter your First Name!"
            End If
            If LastNameTextBox.Text = "Last Name" And LastNameTextBox.ForeColor = Color.Gray Then
                LastNameStatusLabel.Text = "Please enter your Last Name!"
            End If
            If BirthDatePicker.Value.Date = Date.Now.Date Then
                BirthDateStatusLabel.Text = "Please select your Birth Date!"
            ElseIf BirthDatePicker.Value.Date > Date.Now.Date Then
                BirthDateStatusLabel.Text = "Invalid Birth Date!"
            End If
            If MaleRadioButton.Checked = False And FemaleRadioButton.Checked = False Then
                GenderStatusLabel.Text = "Please select your Gender!"
            End If
            If EmailIDTextBox.Text = "Email ID" And EmailIDTextBox.ForeColor = Color.Gray Then
                EmailIDStatusLabel.Text = "Please enter your Email ID!"
            ElseIf InvalidEmail = True Then
                EmailIDStatusLabel.Text = "Invalid Email ID!"
            ElseIf EmailIDExists = True Then
                EmailIDStatusLabel.Text = "Email ID already exists!"
            End If
            If MobileNoTextBox.Text = "Mobile No." And MobileNoTextBox.ForeColor = Color.Gray Then
                MobileNoStatusLabel.Text = "Please enter your Mobile No.!"
            ElseIf IsNumeric(MobileNoTextBox.Text) = False Or MobileNoTextBox.Text.Length() <> 10 Then
                MobileNoStatusLabel.Text = "Invalid Mobile No.!"
            End If
            If AddressTextBox.Text = "Address" And AddressTextBox.ForeColor = Color.Gray Then
                AddressStatusLabel.Text = "Please enter your Address!"
            End If
            If ZipCodeTextBox.Text = "ZIP Code" And ZipCodeTextBox.ForeColor = Color.Gray Then
                ZIPCodeStatusLabel.Text = "Please enter your ZIP Code!"
            End If
            If CityTextBox.Text = "City" And CityTextBox.ForeColor = Color.Gray Then
                CityStatusLabel.Text = "Please enter your City!"
            End If
            If ProvinceTextBox.Text = "Province" And ProvinceTextBox.ForeColor = Color.Gray Then
                ProvinceStatusLabel.Text = "Please enter your Province!"
            End If
            If CountryTextBox.Text = "Country" And CountryTextBox.ForeColor = Color.Gray Then
                CountryStatusLabel.Text = "Please enter your Country!"
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
        FirstNameTextBox.ForeColor = Color.Gray
        FirstNameTextBox.Text = "First Name"
        MiddleNameTextBox.ForeColor = Color.Gray
        MiddleNameTextBox.Text = "Middle Name"
        LastNameTextBox.ForeColor = Color.Gray
        LastNameTextBox.Text = "Last Name"
        BirthDatePicker.Value = Date.Now
        MaleRadioButton.Checked = False
        FemaleRadioButton.Checked = False
        GenderValue = String.Empty
        EmailIDTextBox.ForeColor = Color.Gray
        EmailIDTextBox.Text = "Email ID"
        MobileNoTextBox.ForeColor = Color.Gray
        MobileNoTextBox.Text = "Mobile No."
        AddressTextBox.ForeColor = Color.Gray
        AddressTextBox.Text = "Address"
        ZipCodeTextBox.ForeColor = Color.Gray
        ZipCodeTextBox.Text = "ZIP Code"
        CityTextBox.ForeColor = Color.Gray
        CityTextBox.Text = "City"
        ProvinceTextBox.ForeColor = Color.Gray
        ProvinceTextBox.Text = "Province"
        CountryTextBox.ForeColor = Color.Gray
        CountryTextBox.Text = "Country"
        SecurityQuestionComboBox.SelectedIndex = 0
        SecurityAnswerTextBox.ForeColor = Color.Gray
        SecurityAnswerTextBox.Text = "Security Answer"
        FirstNameStatusLabel.Text = ""
        LastNameStatusLabel.Text = ""
        BirthDateStatusLabel.Text = ""
        GenderStatusLabel.Text = ""
        EmailIDStatusLabel.Text = ""
        MobileNoStatusLabel.Text = ""
        AddressStatusLabel.Text = ""
        ZIPCodeStatusLabel.Text = ""
        CityStatusLabel.Text = ""
        ProvinceStatusLabel.Text = ""
        CountryStatusLabel.Text = ""
        SecurityQuestionStatusLabel.Text = ""
        SecurityAnswerStatusLabel.Text = ""
        ProfilePictureBox.Image = My.Resources.Profile_Picture
        UpdateProfileStatusLabel.ForeColor = Color.Red
        UpdateProfileStatusLabel.Text = "Fields marked with * are mandatory!"
    End Sub
    Private Sub ProfilePictureBox_Click(sender As Object, e As EventArgs) Handles ProfilePictureBox.Click
        OpenProfilePictureDialog.ShowDialog()
    End Sub
    Private Sub OpenProfilePictureDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenProfilePictureDialog.FileOk
        ProfilePictureBox.Image = Image.FromFile(OpenProfilePictureDialog.FileName)
    End Sub
End Class
