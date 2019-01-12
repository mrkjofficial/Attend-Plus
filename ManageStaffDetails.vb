Imports MySql.Data.MySqlClient
Public Class ManageStaffDetails
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
    Private Sub SearchTextBox_GotFocus(sender As Object, e As EventArgs) Handles SearchTextBox.GotFocus
        If SearchTextBox.Text = "Search" And SearchTextBox.ForeColor = Color.Gray Then
            SearchTextBox.Text = ""
            SearchTextBox.ForeColor = Color.Black
        End If
    End Sub
    Private Sub SearchTextBox_LostFocus(sender As Object, e As EventArgs) Handles SearchTextBox.LostFocus
        If SearchTextBox.Text = "" And SearchTextBox.ForeColor = Color.Black Then
            SearchTextBox.Text = "Search"
            SearchTextBox.ForeColor = Color.Gray
        End If
    End Sub
    Public Sub ManageStaffDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConnectionTimer.Enabled = True
        TimeTimer.Enabled = True
        SearchTextBox.ForeColor = Color.Gray
        SearchTextBox.Text = "Search"
        SearchComboBox.SelectedIndex = 0
        ActiveControl = ManageStaffDetailsPanel
        ManageStaffDetailsStatusLabel.Text = ""
        ManageStaffDetailsStatusLabel.ForeColor = Color.Red
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
            MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where binary staff_id != 1", MysqlConn)
            SDA.SelectCommand = MySqlComm
            SDA.Fill(DataTab)
            StaffDetailsDataGridView.DataSource = DataTab
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
        StaffDetailsDataGridView.Columns(0).Visible = False
        StaffDetailsDataGridView.Sort(StaffDetailsDataGridView.Columns(1), ComponentModel.ListSortDirection.Ascending)
        StaffDetailsDataGridView.ClearSelection()
        ID = Nothing
    End Sub
    Private Sub StaffDetailsDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StaffDetailsDataGridView.CellClick
        If e.RowIndex >= 0 Then
            Dim Row As DataGridViewRow
            Row = StaffDetailsDataGridView.Rows(e.RowIndex)
            ID = Row.Cells("ID").Value.ToString
        End If
    End Sub
    Private Sub SearchTextBox_TextChanged(sender As Object, e As EventArgs) Handles SearchTextBox.TextChanged
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Try
            If SearchTextBox.Text <> "Search" And SearchTextBox.ForeColor <> Color.Gray And SearchComboBox.SelectedIndex = 0 Then
                Dim SDA As New MySqlDataAdapter
                Dim DataTab As New DataTable
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where staff_id != 1 and (first_name like concat('%',@searchstring,'%') or middle_name like concat('%',@searchstring,'%') or last_name like concat('%',@searchstring,'%'))", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@searchstring", value:=SearchTextBox.Text)
                SDA.SelectCommand = MySqlComm
                SDA.Fill(DataTab)
                StaffDetailsDataGridView.DataSource = DataTab
                MysqlConn.Close()
            ElseIf SearchTextBox.Text <> "Search" And SearchTextBox.ForeColor <> Color.Gray And SearchComboBox.SelectedIndex = 1 Then
                Dim SDA As New MySqlDataAdapter
                Dim DataTab As New DataTable
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where staff_id != 1 and email_id like concat('%',@searchstring,'%')", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@searchstring", value:=SearchTextBox.Text)
                SDA.SelectCommand = MySqlComm
                SDA.Fill(DataTab)
                StaffDetailsDataGridView.DataSource = DataTab
                MysqlConn.Close()
            ElseIf SearchTextBox.Text <> "Search" And SearchTextBox.ForeColor <> Color.Gray And SearchComboBox.SelectedIndex = 2 Then
                Dim SDA As New MySqlDataAdapter
                Dim DataTab As New DataTable
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where staff_id != 1 and mobile_no like concat('%',@searchstring,'%')", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@searchstring", value:=SearchTextBox.Text)
                SDA.SelectCommand = MySqlComm
                SDA.Fill(DataTab)
                StaffDetailsDataGridView.DataSource = DataTab
                MysqlConn.Close()
            ElseIf SearchTextBox.Text <> "Search" And SearchTextBox.ForeColor <> Color.Gray And SearchComboBox.SelectedIndex = 3 Then
                Dim SDA As New MySqlDataAdapter
                Dim DataTab As New DataTable
                MysqlConn.Open()
                MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where staff_id != 1 and (city like concat('%',@searchstring,'%') or country like concat('%',@searchstring,'%'))", MysqlConn)
                MySqlComm.Parameters.AddWithValue("@searchstring", value:=SearchTextBox.Text)
                SDA.SelectCommand = MySqlComm
                SDA.Fill(DataTab)
                StaffDetailsDataGridView.DataSource = DataTab
                MysqlConn.Close()
            End If
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
        StaffDetailsDataGridView.ClearSelection()
    End Sub
    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        SearchTextBox.ForeColor = Color.Gray
        SearchTextBox.Text = "Search"
        SearchComboBox.SelectedIndex = 0
        ActiveControl = ManageStaffDetailsPanel
        ManageStaffDetailsStatusLabel.Text = ""
        ManageStaffDetailsStatusLabel.ForeColor = Color.Red
        MysqlConn = New MySqlConnection With {.ConnectionString = "server = localhost; userid = root; password = root; database = ams;"}
        Dim SDA As New MySqlDataAdapter
        Dim DataTab As New DataTable
        Try
            MysqlConn.Open()
            MySqlComm = New MySqlCommand("select staff_id as 'ID', concat_ws(' ', ' ', first_name, middle_name, last_name) as 'Name', gender as 'Gender', email_id as 'Email ID', mobile_no as 'Mobile No.', concat_ws(', ', city, country) as 'Location' from ams.staff where binary staff_id != 1", MysqlConn)
            SDA.SelectCommand = MySqlComm
            SDA.Fill(DataTab)
            StaffDetailsDataGridView.DataSource = DataTab
            MysqlConn.Close()
        Catch ex As MySqlException
            ErrorBox.ErrorBox_Load(e, e)
            ErrorBox.StatusLabel.Text = ex.Message
            ErrorBox.ShowDialog()
        Finally
            MysqlConn.Dispose()
        End Try
        StaffDetailsDataGridView.Sort(StaffDetailsDataGridView.Columns(1), ComponentModel.ListSortDirection.Ascending)
        StaffDetailsDataGridView.ClearSelection()
        ID = Nothing
    End Sub
    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        If ID = Nothing Then
            ManageStaffDetailsStatusLabel.Text = "Please select a staff record first!"
        Else
            ViewStaffDetails.ViewStaffDetails_Load(e, e)
            ViewStaffDetails.Show()
            Hide()
            ManageStaffDetailsStatusLabel.Text = ""
        End If
    End Sub
End Class