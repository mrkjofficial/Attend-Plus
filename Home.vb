Imports MySql.Data.MySqlClient
Public Class Home
    Public Property StaffDetails As Boolean
    Public Property StudentDetails As Boolean
    Dim MysqlConn As MySqlConnection
    Dim MySqlComm As MySqlCommand
    Public Property ID As String
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
    Private Sub AddStaffDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles AddStaffDetailsMenuItem.Click
        StaffDetails = True
        AddUpdateStaffDetails.AddStaffDetailsMenuItem.Enabled = False
        AddUpdateStaffDetails.AddButton.Visible = True
        AddUpdateStaffDetails.UpdateButton.Visible = False
        AddUpdateStaffDetails.AddUpdateStaffDetails_Load(e, e)
        AddUpdateStaffDetails.Show()
        Hide()
    End Sub
    Private Sub AddStudentDetailsMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentDetailsMenuItem.Click
        StudentDetails = True
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
    Public Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        TimeTimer.Enabled = True
        HomeStatusLabel.Text = ""
        AttendenceStatusLabel.Text = ""
        SemesterComboBox.SelectedIndex = 0
        ActiveControl = HomePanel
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
        Dim SDA As New MySqlDataAdapter
        Dim DataTab As New DataTable
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select student_id as 'ID', roll_no as 'Roll No.', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', mobile_no as 'Mobile No.' from ams.student where binary semester = @semester", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@semester", value:=SemesterComboBox.SelectedItem)
            SDA.SelectCommand = MySqlComm
            SDA.Fill(DataTab)
            AttendenceDetailsDataGridView.DataSource = DataTab
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
        AttendenceDetailsDataGridView.Columns(0).Visible = False
        AttendenceDetailsDataGridView.Sort(AttendenceDetailsDataGridView.Columns(1), ComponentModel.ListSortDirection.Ascending)
        AttendenceDetailsDataGridView.ClearSelection()
        ID = Nothing
    End Sub
    Private Sub AttendenceDetailsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AttendenceDetailsDataGridView.CellClick
        HomeStatusLabel.Text = ""
        If e.RowIndex >= 0 Then
            Dim Row As DataGridViewRow
            Row = AttendenceDetailsDataGridView.Rows(e.RowIndex)
            ID = Row.Cells("ID").Value.ToString
        End If
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Counter As Boolean = False
            MySqlComm = New MySqlCommand("select attendence_status from ams.attendence where date = @date and binary student_id = @userid", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@date", value:=Date.Now.ToString("yyyy-MM-dd"))
            MySqlComm.Parameters.AddWithValue("@userid", value:=ID)
            MySqlRead = MySqlComm.ExecuteReader
            While MySqlRead.Read
                Counter = True
                If Not IsDBNull(MySqlRead("attendence_status")) Then
                    If MySqlRead.GetString("attendence_status") = "Present" Then
                        AttendenceStatusLabel.ForeColor = Color.Green
                        AttendenceStatusLabel.Text = MySqlRead.GetString("attendence_status")
                    ElseIf MySqlRead.GetString("attendence_status") = "Absent" Then
                        AttendenceStatusLabel.ForeColor = Color.Red
                        AttendenceStatusLabel.Text = MySqlRead.GetString("attendence_status")
                    End If
                End If
            End While
            If Counter = False Then
                AttendenceStatusLabel.ForeColor = Color.Orange
                AttendenceStatusLabel.Text = "Not Recorded!"
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
    Private Sub SemesterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SemesterComboBox.SelectedIndexChanged
        HomeStatusLabel.Text = ""
        AttendenceStatusLabel.Text = ""
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim SDA As New MySqlDataAdapter
        Dim DataTab As New DataTable
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select student_id as 'ID', roll_no as 'Roll No.', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', mobile_no as 'Mobile No.' from ams.student where binary semester = @semester", MysqlConn)
            MySqlComm.Parameters.AddWithValue("@semester", value:=SemesterComboBox.SelectedItem)
            SDA.SelectCommand = MySqlComm
            SDA.Fill(DataTab)
            AttendenceDetailsDataGridView.DataSource = DataTab
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
        AttendenceDetailsDataGridView.Columns(0).Visible = False
        AttendenceDetailsDataGridView.Sort(AttendenceDetailsDataGridView.Columns(1), ComponentModel.ListSortDirection.Ascending)
        AttendenceDetailsDataGridView.ClearSelection()
        ID = Nothing
    End Sub
    Private Sub PresentButton_Click(sender As Object, e As EventArgs) Handles PresentButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        If AttendenceStatusLabel.Text <> "Present" And AttendenceStatusLabel.Text <> "Absent" Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("insert into ams.attendence set date = @date,staff_id = @userid,student_id = @studentid,attendence_status = @status", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@date", value:=Date.Now.ToString("yyyy-MM-dd"))
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlComm.Parameters.AddWithValue("@studentid", value:=ID)
                MySqlComm.Parameters.AddWithValue("@status", value:="Present")
                MySqlRead = MySqlComm.ExecuteReader
                AttendenceStatusLabel.ForeColor = Color.Green
                AttendenceStatusLabel.Text = "Present"
                MysqlConn.Close()
            Catch ex As MySqlException
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = ex.Message
                ErrorBox.ShowDialog()
            Finally
                MysqlConn.Dispose()
            End Try
        ElseIf ID = Nothing Then
            HomeStatusLabel.Text = "Please select a student first!"
        Else
            HomeStatusLabel.Text = "Today's Attendence already recorded for this student!"
        End If
    End Sub
    Private Sub AbsentButton_Click(sender As Object, e As EventArgs) Handles AbsentButton.Click
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim MySqlRead As MySqlDataReader
        If AttendenceStatusLabel.Text <> "Present" And AttendenceStatusLabel.Text <> "Absent" Then
            Try
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("insert into ams.attendence set date = @date,staff_id = @userid,student_id = @studentid,attendence_status = @status", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@date", value:=Date.Now.ToString("yyyy-MM-dd"))
                MySqlComm.Parameters.AddWithValue("@userid", value:=Login.UserID)
                MySqlComm.Parameters.AddWithValue("@studentid", value:=ID)
                MySqlComm.Parameters.AddWithValue("@status", value:="Absent")
                MySqlRead = MySqlComm.ExecuteReader
                AttendenceStatusLabel.ForeColor = Color.Red
                AttendenceStatusLabel.Text = "Absent"
                MysqlConn.Close()
            Catch ex As MySqlException
                ErrorBox.ErrorBox_Load(e, e)
                ErrorBox.StatusLabel.Text = ex.Message
                ErrorBox.ShowDialog()
            Finally
                MysqlConn.Dispose()
            End Try
        ElseIf ID = Nothing Then
            HomeStatusLabel.Text = "Please select a student first!"
        Else
            HomeStatusLabel.Text = "Today's Attendence already recorded for this student!"
        End If
    End Sub
End Class