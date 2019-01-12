Imports MySql.Data.MySqlClient
Public Class ViewAttendence
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
    Private Sub ValidationTimer_Tick(sender As Object, e As EventArgs) Handles ValidationTimer.Tick
        If ActiveControl Is FromDatePicker And FromDatePicker.Value.Date > Date.Now.Date Then
            FromDateStatusLabel.Text = "Invalid Date!"
        ElseIf ActiveControl Is FromDatePicker And FromDatePicker.Value.Date <= Date.Now.Date Then
            FromDateStatusLabel.Text = ""
        End If
        If ActiveControl Is ToDatePicker And ToDatePicker.Value.Date > Date.Now.Date Then
            ToDateStatusLabel.Text = "Invalid Date!"
        ElseIf ActiveControl Is ToDatePicker And ToDatePicker.Value.Date <= Date.Now.Date Then
            ToDateStatusLabel.Text = ""
        End If
        If FromDatePicker.Value > ToDatePicker.Value Then
            FromDateStatusLabel.Text = "Invalid Date!"
        End If
    End Sub
    Public Sub ViewAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        TimeTimer.Enabled = True
        ValidationTimer.Enabled = True
        ActiveControl = ViewAttendencePanel
        SemesterComboBox.SelectedIndex = 0
        FromDatePicker.Value = Date.Now
        ToDatePicker.Value = Date.Now
        FromDateStatusLabel.Text = ""
        ToDateStatusLabel.Text = ""
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
    End Sub
    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        If FromDatePicker.Value <= Date.Now And ToDatePicker.Value <= Date.Now And FromDatePicker.Value <= ToDatePicker.Value Then
            MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
            Dim SDA As New MySqlDataAdapter
            Dim DataTab As New DataTable
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("select distinct student.student_id as 'ID', student.roll_no as 'Roll No.', concat_ws(' ', ' ', student.first_name, student.middle_name, student.last_name) as 'Name', student.gender as 'Gender', (select count(*) from ams.attendence where student_id = student.student_id and attendence_status = @status and date between @fromdate and @todate) * 100/(select count(Distinct(date)) from ams.attendence where date between @fromdate and @todate) as 'Attendence (%)' from ams.student join ams.attendence where student.student_id = attendence.student_id and binary student.semester = @semester", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@status", value:="Present")
                MySqlComm.Parameters.AddWithValue("@fromdate", value:=FromDatePicker.Value.ToString("yyyy-MM-dd"))
                MySqlComm.Parameters.AddWithValue("@todate", value:=ToDatePicker.Value.ToString("yyyy-MM-dd"))
                MySqlComm.Parameters.AddWithValue("@semester", value:=SemesterComboBox.SelectedItem)
                SDA.SelectCommand = MySqlComm
                SDA.Fill(DataTab)
                ViewAttendenceDataGridView.DataSource = DataTab
                MysqlConn.Close()
            Catch ex As MySqlException
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = ex.Message
                ErrorBox.ShowDialog()
            Finally
                MysqlConn.Dispose()
            End Try
            ViewAttendenceDataGridView.Columns(0).Visible = False
            ViewAttendenceDataGridView.Sort(ViewAttendenceDataGridView.Columns(1), ComponentModel.ListSortDirection.Ascending)
            ViewAttendenceDataGridView.ClearSelection()
        Else
            If FromDatePicker.Value.Date > Date.Now.Date Then
                FromDateStatusLabel.Text = "Invalid Date!"
            End If
            If ToDatePicker.Value.Date > Date.Now.Date Then
                ToDateStatusLabel.Text = "Invalid Date!"
            End If
            If FromDatePicker.Value > ToDatePicker.Value Then
                FromDateStatusLabel.Text = "Invalid Date!"
            End If
        End If
    End Sub
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ViewAttendenceDataGridView.DataSource = Nothing
        SemesterComboBox.SelectedIndex = 0
        FromDatePicker.Value = Date.Now
        ToDatePicker.Value = Date.Now
        FromDateStatusLabel.Text = ""
        ToDateStatusLabel.Text = ""
    End Sub
End Class