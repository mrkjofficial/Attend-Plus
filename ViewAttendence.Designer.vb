<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewAttendence
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewAttendence))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.HomeMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStaffDetailsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddStudentDetailsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStaffDetailsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageStudentDetailsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewAttendenceMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeMobileNoMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSecurityQuestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestoreDefaultsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateProfileMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangePasswordMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutAttendMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ServerStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.CStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.ViewAttendencePanel = New System.Windows.Forms.Panel()
        Me.ToDateStatusLabel = New System.Windows.Forms.Label()
        Me.FromDateStatusLabel = New System.Windows.Forms.Label()
        Me.ToDateLabel = New System.Windows.Forms.Label()
        Me.FromDateLabel = New System.Windows.Forms.Label()
        Me.SemesterLabel = New System.Windows.Forms.Label()
        Me.ToDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ActionsGroupBox = New System.Windows.Forms.GroupBox()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SemesterComboBox = New System.Windows.Forms.ComboBox()
        Me.FromDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ViewAttendenceDataGridView = New System.Windows.Forms.DataGridView()
        Me.ConnectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip.SuspendLayout()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ViewAttendencePanel.SuspendLayout()
        Me.ActionsGroupBox.SuspendLayout()
        CType(Me.ViewAttendenceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.AutoSize = False
        Me.MenuStrip.BackColor = System.Drawing.Color.DarkBlue
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeMenuItem, Me.AddMenuItem, Me.ManageMenuItem, Me.OptionsMenuItem, Me.ProfileMenuItem, Me.AboutMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.Size = New System.Drawing.Size(1280, 50)
        Me.MenuStrip.TabIndex = 143
        '
        'HomeMenuItem
        '
        Me.HomeMenuItem.BackColor = System.Drawing.Color.DarkBlue
        Me.HomeMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomeMenuItem.ForeColor = System.Drawing.Color.White
        Me.HomeMenuItem.Margin = New System.Windows.Forms.Padding(160, 0, 0, 0)
        Me.HomeMenuItem.Name = "HomeMenuItem"
        Me.HomeMenuItem.Size = New System.Drawing.Size(86, 46)
        Me.HomeMenuItem.Text = "HOME"
        '
        'AddMenuItem
        '
        Me.AddMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffDetailsMenuItem, Me.AddStudentDetailsMenuItem})
        Me.AddMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddMenuItem.ForeColor = System.Drawing.Color.White
        Me.AddMenuItem.Name = "AddMenuItem"
        Me.AddMenuItem.Size = New System.Drawing.Size(69, 46)
        Me.AddMenuItem.Text = "ADD"
        '
        'AddStaffDetailsMenuItem
        '
        Me.AddStaffDetailsMenuItem.BackColor = System.Drawing.Color.White
        Me.AddStaffDetailsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStaffDetailsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.AddStaffDetailsMenuItem.Name = "AddStaffDetailsMenuItem"
        Me.AddStaffDetailsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.AddStaffDetailsMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AddStaffDetailsMenuItem.Text = "Staff Details"
        '
        'AddStudentDetailsMenuItem
        '
        Me.AddStudentDetailsMenuItem.BackColor = System.Drawing.Color.White
        Me.AddStudentDetailsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddStudentDetailsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.AddStudentDetailsMenuItem.Name = "AddStudentDetailsMenuItem"
        Me.AddStudentDetailsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.AddStudentDetailsMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AddStudentDetailsMenuItem.Text = "Student Details"
        '
        'ManageMenuItem
        '
        Me.ManageMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManageStaffDetailsMenuItem, Me.ManageStudentDetailsMenuItem})
        Me.ManageMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageMenuItem.ForeColor = System.Drawing.Color.White
        Me.ManageMenuItem.Name = "ManageMenuItem"
        Me.ManageMenuItem.Size = New System.Drawing.Size(114, 46)
        Me.ManageMenuItem.Text = "MANAGE"
        '
        'ManageStaffDetailsMenuItem
        '
        Me.ManageStaffDetailsMenuItem.BackColor = System.Drawing.Color.White
        Me.ManageStaffDetailsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageStaffDetailsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ManageStaffDetailsMenuItem.Name = "ManageStaffDetailsMenuItem"
        Me.ManageStaffDetailsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ManageStaffDetailsMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ManageStaffDetailsMenuItem.Text = "Staff Details"
        '
        'ManageStudentDetailsMenuItem
        '
        Me.ManageStudentDetailsMenuItem.BackColor = System.Drawing.Color.White
        Me.ManageStudentDetailsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManageStudentDetailsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ManageStudentDetailsMenuItem.Name = "ManageStudentDetailsMenuItem"
        Me.ManageStudentDetailsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ManageStudentDetailsMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ManageStudentDetailsMenuItem.Text = "Student Details"
        '
        'OptionsMenuItem
        '
        Me.OptionsMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewAttendenceMenuItem, Me.ChangeMobileNoMenuItem, Me.ChangeSecurityQuestionMenuItem, Me.RestoreDefaultsMenuItem})
        Me.OptionsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsMenuItem.ForeColor = System.Drawing.Color.White
        Me.OptionsMenuItem.Name = "OptionsMenuItem"
        Me.OptionsMenuItem.Size = New System.Drawing.Size(114, 46)
        Me.OptionsMenuItem.Text = "OPTIONS"
        '
        'ViewAttendenceMenuItem
        '
        Me.ViewAttendenceMenuItem.BackColor = System.Drawing.Color.White
        Me.ViewAttendenceMenuItem.Enabled = False
        Me.ViewAttendenceMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewAttendenceMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ViewAttendenceMenuItem.Name = "ViewAttendenceMenuItem"
        Me.ViewAttendenceMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ViewAttendenceMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ViewAttendenceMenuItem.Text = "View Attendence"
        '
        'ChangeMobileNoMenuItem
        '
        Me.ChangeMobileNoMenuItem.BackColor = System.Drawing.Color.White
        Me.ChangeMobileNoMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeMobileNoMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ChangeMobileNoMenuItem.Name = "ChangeMobileNoMenuItem"
        Me.ChangeMobileNoMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ChangeMobileNoMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeMobileNoMenuItem.Text = "Change Mobile No."
        '
        'ChangeSecurityQuestionMenuItem
        '
        Me.ChangeSecurityQuestionMenuItem.BackColor = System.Drawing.Color.White
        Me.ChangeSecurityQuestionMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeSecurityQuestionMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ChangeSecurityQuestionMenuItem.Name = "ChangeSecurityQuestionMenuItem"
        Me.ChangeSecurityQuestionMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ChangeSecurityQuestionMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.ChangeSecurityQuestionMenuItem.Text = "Change Security Question"
        '
        'RestoreDefaultsMenuItem
        '
        Me.RestoreDefaultsMenuItem.BackColor = System.Drawing.Color.White
        Me.RestoreDefaultsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreDefaultsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.RestoreDefaultsMenuItem.Name = "RestoreDefaultsMenuItem"
        Me.RestoreDefaultsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.RestoreDefaultsMenuItem.Size = New System.Drawing.Size(273, 26)
        Me.RestoreDefaultsMenuItem.Text = "Restore Defaults"
        '
        'ProfileMenuItem
        '
        Me.ProfileMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileMenuItem, Me.UpdateProfileMenuItem, Me.ChangePasswordMenuItem, Me.LogoutMenuItem})
        Me.ProfileMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProfileMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProfileMenuItem.Name = "ProfileMenuItem"
        Me.ProfileMenuItem.Size = New System.Drawing.Size(104, 46)
        Me.ProfileMenuItem.Text = "PROFILE"
        '
        'ViewProfileMenuItem
        '
        Me.ViewProfileMenuItem.BackColor = System.Drawing.Color.White
        Me.ViewProfileMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewProfileMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ViewProfileMenuItem.Name = "ViewProfileMenuItem"
        Me.ViewProfileMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ViewProfileMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ViewProfileMenuItem.Text = "View Profile"
        '
        'UpdateProfileMenuItem
        '
        Me.UpdateProfileMenuItem.BackColor = System.Drawing.Color.White
        Me.UpdateProfileMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateProfileMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.UpdateProfileMenuItem.Name = "UpdateProfileMenuItem"
        Me.UpdateProfileMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.UpdateProfileMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.UpdateProfileMenuItem.Text = "Update Profile"
        '
        'ChangePasswordMenuItem
        '
        Me.ChangePasswordMenuItem.BackColor = System.Drawing.Color.White
        Me.ChangePasswordMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.ChangePasswordMenuItem.Name = "ChangePasswordMenuItem"
        Me.ChangePasswordMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.ChangePasswordMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.ChangePasswordMenuItem.Text = "Change Password"
        '
        'LogoutMenuItem
        '
        Me.LogoutMenuItem.BackColor = System.Drawing.Color.White
        Me.LogoutMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.LogoutMenuItem.Name = "LogoutMenuItem"
        Me.LogoutMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.LogoutMenuItem.Size = New System.Drawing.Size(213, 26)
        Me.LogoutMenuItem.Text = "Logout"
        '
        'AboutMenuItem
        '
        Me.AboutMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutAttendMenuItem, Me.AboutUsMenuItem})
        Me.AboutMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutMenuItem.Name = "AboutMenuItem"
        Me.AboutMenuItem.Size = New System.Drawing.Size(95, 46)
        Me.AboutMenuItem.Text = "ABOUT"
        '
        'AboutAttendMenuItem
        '
        Me.AboutAttendMenuItem.BackColor = System.Drawing.Color.White
        Me.AboutAttendMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutAttendMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.AboutAttendMenuItem.Name = "AboutAttendMenuItem"
        Me.AboutAttendMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.AboutAttendMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.AboutAttendMenuItem.Text = "About Attend+"
        '
        'AboutUsMenuItem
        '
        Me.AboutUsMenuItem.BackColor = System.Drawing.Color.White
        Me.AboutUsMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutUsMenuItem.ForeColor = System.Drawing.Color.DarkBlue
        Me.AboutUsMenuItem.Name = "AboutUsMenuItem"
        Me.AboutUsMenuItem.Padding = New System.Windows.Forms.Padding(1)
        Me.AboutUsMenuItem.Size = New System.Drawing.Size(197, 26)
        Me.AboutUsMenuItem.Text = "About Us"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.DarkBlue
        Me.LogoPictureBox.Image = Global.AMS.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 5)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(160, 40)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 144
        Me.LogoPictureBox.TabStop = False
        '
        'MinusButton
        '
        Me.MinusButton.BackColor = System.Drawing.Color.Orange
        Me.MinusButton.BackgroundImage = Global.AMS.My.Resources.Resources.Minimize
        Me.MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinusButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MinusButton.FlatAppearance.BorderSize = 2
        Me.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinusButton.Location = New System.Drawing.Point(1198, 9)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(32, 32)
        Me.MinusButton.TabIndex = 145
        Me.MinusButton.UseVisualStyleBackColor = False
        '
        'CrossButton
        '
        Me.CrossButton.BackColor = System.Drawing.Color.Red
        Me.CrossButton.BackgroundImage = Global.AMS.My.Resources.Resources.Close
        Me.CrossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CrossButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CrossButton.FlatAppearance.BorderSize = 2
        Me.CrossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrossButton.Location = New System.Drawing.Point(1239, 9)
        Me.CrossButton.Name = "CrossButton"
        Me.CrossButton.Size = New System.Drawing.Size(32, 32)
        Me.CrossButton.TabIndex = 146
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.BackColor = System.Drawing.Color.DarkBlue
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerStatusLabel, Me.ConnectionStatusLabel, Me.TimeLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 690)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1280, 30)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 147
        '
        'ServerStatusLabel
        '
        Me.ServerStatusLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.ServerStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ServerStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ServerStatusLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ServerStatusLabel.LinkColor = System.Drawing.Color.White
        Me.ServerStatusLabel.Margin = New System.Windows.Forms.Padding(0)
        Me.ServerStatusLabel.Name = "ServerStatusLabel"
        Me.ServerStatusLabel.Size = New System.Drawing.Size(92, 30)
        Me.ServerStatusLabel.Text = "Server Status:"
        Me.ServerStatusLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'ConnectionStatusLabel
        '
        Me.ConnectionStatusLabel.ActiveLinkColor = System.Drawing.Color.Transparent
        Me.ConnectionStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConnectionStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConnectionStatusLabel.ForeColor = System.Drawing.Color.White
        Me.ConnectionStatusLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ConnectionStatusLabel.LinkColor = System.Drawing.Color.White
        Me.ConnectionStatusLabel.Margin = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.ConnectionStatusLabel.Name = "ConnectionStatusLabel"
        Me.ConnectionStatusLabel.Size = New System.Drawing.Size(0, 0)
        Me.ConnectionStatusLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'TimeLabel
        '
        Me.TimeLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.TimeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLabel.ForeColor = System.Drawing.Color.White
        Me.TimeLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.TimeLabel.LinkColor = System.Drawing.Color.White
        Me.TimeLabel.Margin = New System.Windows.Forms.Padding(920, 0, 0, 0)
        Me.TimeLabel.Name = "TimeLabel"
        Me.TimeLabel.Size = New System.Drawing.Size(0, 0)
        Me.TimeLabel.VisitedLinkColor = System.Drawing.Color.White
        '
        'CStatusPictureBox
        '
        Me.CStatusPictureBox.BackColor = System.Drawing.Color.DarkBlue
        Me.CStatusPictureBox.Location = New System.Drawing.Point(88, 691)
        Me.CStatusPictureBox.Name = "CStatusPictureBox"
        Me.CStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.CStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CStatusPictureBox.TabIndex = 148
        Me.CStatusPictureBox.TabStop = False
        '
        'ViewAttendencePanel
        '
        Me.ViewAttendencePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ViewAttendencePanel.Controls.Add(Me.ToDateStatusLabel)
        Me.ViewAttendencePanel.Controls.Add(Me.FromDateStatusLabel)
        Me.ViewAttendencePanel.Controls.Add(Me.ToDateLabel)
        Me.ViewAttendencePanel.Controls.Add(Me.FromDateLabel)
        Me.ViewAttendencePanel.Controls.Add(Me.SemesterLabel)
        Me.ViewAttendencePanel.Controls.Add(Me.ToDatePicker)
        Me.ViewAttendencePanel.Controls.Add(Me.ActionsGroupBox)
        Me.ViewAttendencePanel.Controls.Add(Me.SemesterComboBox)
        Me.ViewAttendencePanel.Controls.Add(Me.FromDatePicker)
        Me.ViewAttendencePanel.Controls.Add(Me.ViewAttendenceDataGridView)
        Me.ViewAttendencePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ViewAttendencePanel.Location = New System.Drawing.Point(0, 50)
        Me.ViewAttendencePanel.Name = "ViewAttendencePanel"
        Me.ViewAttendencePanel.Size = New System.Drawing.Size(1280, 640)
        Me.ViewAttendencePanel.TabIndex = 149
        '
        'ToDateStatusLabel
        '
        Me.ToDateStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToDateStatusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDateStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ToDateStatusLabel.Location = New System.Drawing.Point(1080, 280)
        Me.ToDateStatusLabel.Name = "ToDateStatusLabel"
        Me.ToDateStatusLabel.Size = New System.Drawing.Size(180, 30)
        Me.ToDateStatusLabel.TabIndex = 17
        Me.ToDateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FromDateStatusLabel
        '
        Me.FromDateStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.FromDateStatusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDateStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.FromDateStatusLabel.Location = New System.Drawing.Point(1080, 160)
        Me.FromDateStatusLabel.Name = "FromDateStatusLabel"
        Me.FromDateStatusLabel.Size = New System.Drawing.Size(180, 30)
        Me.FromDateStatusLabel.TabIndex = 16
        Me.FromDateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToDateLabel
        '
        Me.ToDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.ToDateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDateLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ToDateLabel.Location = New System.Drawing.Point(1075, 200)
        Me.ToDateLabel.Name = "ToDateLabel"
        Me.ToDateLabel.Size = New System.Drawing.Size(180, 30)
        Me.ToDateLabel.TabIndex = 15
        Me.ToDateLabel.Text = "To:"
        Me.ToDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FromDateLabel
        '
        Me.FromDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.FromDateLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDateLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.FromDateLabel.Location = New System.Drawing.Point(1075, 80)
        Me.FromDateLabel.Name = "FromDateLabel"
        Me.FromDateLabel.Size = New System.Drawing.Size(180, 30)
        Me.FromDateLabel.TabIndex = 14
        Me.FromDateLabel.Text = "From:"
        Me.FromDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SemesterLabel
        '
        Me.SemesterLabel.BackColor = System.Drawing.Color.Transparent
        Me.SemesterLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.SemesterLabel.Location = New System.Drawing.Point(1075, 320)
        Me.SemesterLabel.Name = "SemesterLabel"
        Me.SemesterLabel.Size = New System.Drawing.Size(180, 30)
        Me.SemesterLabel.TabIndex = 13
        Me.SemesterLabel.Text = "Select Semester:"
        Me.SemesterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToDatePicker
        '
        Me.ToDatePicker.CalendarForeColor = System.Drawing.Color.DarkBlue
        Me.ToDatePicker.CalendarMonthBackground = System.Drawing.Color.DarkBlue
        Me.ToDatePicker.CalendarTitleBackColor = System.Drawing.Color.DarkBlue
        Me.ToDatePicker.CalendarTitleForeColor = System.Drawing.Color.DarkBlue
        Me.ToDatePicker.CalendarTrailingForeColor = System.Drawing.Color.DarkBlue
        Me.ToDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.ToDatePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDatePicker.Location = New System.Drawing.Point(1080, 240)
        Me.ToDatePicker.Name = "ToDatePicker"
        Me.ToDatePicker.ShowUpDown = True
        Me.ToDatePicker.Size = New System.Drawing.Size(180, 29)
        Me.ToDatePicker.TabIndex = 12
        '
        'ActionsGroupBox
        '
        Me.ActionsGroupBox.Controls.Add(Me.ViewButton)
        Me.ActionsGroupBox.Controls.Add(Me.ClearButton)
        Me.ActionsGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionsGroupBox.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionsGroupBox.Location = New System.Drawing.Point(1075, 450)
        Me.ActionsGroupBox.Name = "ActionsGroupBox"
        Me.ActionsGroupBox.Size = New System.Drawing.Size(180, 170)
        Me.ActionsGroupBox.TabIndex = 11
        Me.ActionsGroupBox.TabStop = False
        Me.ActionsGroupBox.Text = "Actions"
        '
        'ViewButton
        '
        Me.ViewButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.ViewButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ViewButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewButton.ForeColor = System.Drawing.Color.White
        Me.ViewButton.Location = New System.Drawing.Point(26, 30)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(128, 40)
        Me.ViewButton.TabIndex = 5
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(26, 100)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'SemesterComboBox
        '
        Me.SemesterComboBox.BackColor = System.Drawing.Color.White
        Me.SemesterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SemesterComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SemesterComboBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.SemesterComboBox.FormattingEnabled = True
        Me.SemesterComboBox.ItemHeight = 21
        Me.SemesterComboBox.Items.AddRange(New Object() {"Semester 1", "Semester 2", "Semester 3", "Semester 4", "Semester 5", "Semester 6"})
        Me.SemesterComboBox.Location = New System.Drawing.Point(1075, 360)
        Me.SemesterComboBox.Name = "SemesterComboBox"
        Me.SemesterComboBox.Size = New System.Drawing.Size(180, 29)
        Me.SemesterComboBox.TabIndex = 10
        '
        'FromDatePicker
        '
        Me.FromDatePicker.CalendarForeColor = System.Drawing.Color.DarkBlue
        Me.FromDatePicker.CalendarMonthBackground = System.Drawing.Color.DarkBlue
        Me.FromDatePicker.CalendarTitleBackColor = System.Drawing.Color.DarkBlue
        Me.FromDatePicker.CalendarTitleForeColor = System.Drawing.Color.DarkBlue
        Me.FromDatePicker.CalendarTrailingForeColor = System.Drawing.Color.DarkBlue
        Me.FromDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.FromDatePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDatePicker.Location = New System.Drawing.Point(1080, 120)
        Me.FromDatePicker.Name = "FromDatePicker"
        Me.FromDatePicker.ShowUpDown = True
        Me.FromDatePicker.Size = New System.Drawing.Size(180, 29)
        Me.FromDatePicker.TabIndex = 6
        '
        'ViewAttendenceDataGridView
        '
        Me.ViewAttendenceDataGridView.AllowUserToAddRows = False
        Me.ViewAttendenceDataGridView.AllowUserToDeleteRows = False
        Me.ViewAttendenceDataGridView.AllowUserToResizeColumns = False
        Me.ViewAttendenceDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = "Empty"
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ViewAttendenceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ViewAttendenceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ViewAttendenceDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ViewAttendenceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "Empty"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ViewAttendenceDataGridView.ColumnHeadersHeight = 40
        Me.ViewAttendenceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle3.NullValue = "Empty"
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ViewAttendenceDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.ViewAttendenceDataGridView.EnableHeadersVisualStyles = False
        Me.ViewAttendenceDataGridView.GridColor = System.Drawing.Color.Black
        Me.ViewAttendenceDataGridView.Location = New System.Drawing.Point(50, 80)
        Me.ViewAttendenceDataGridView.MultiSelect = False
        Me.ViewAttendenceDataGridView.Name = "ViewAttendenceDataGridView"
        Me.ViewAttendenceDataGridView.ReadOnly = True
        Me.ViewAttendenceDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.NullValue = "Empty"
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.ViewAttendenceDataGridView.RowHeadersVisible = False
        Me.ViewAttendenceDataGridView.RowHeadersWidth = 50
        Me.ViewAttendenceDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.NullValue = "Empty"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.ViewAttendenceDataGridView.RowTemplate.Height = 40
        Me.ViewAttendenceDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ViewAttendenceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ViewAttendenceDataGridView.Size = New System.Drawing.Size(1000, 550)
        Me.ViewAttendenceDataGridView.StandardTab = True
        Me.ViewAttendenceDataGridView.TabIndex = 5
        Me.ViewAttendenceDataGridView.VirtualMode = True
        '
        'ConnectionTimer
        '
        Me.ConnectionTimer.Interval = 1000
        '
        'TimeTimer
        '
        Me.TimeTimer.Interval = 1000
        '
        'ValidationTimer
        '
        Me.ValidationTimer.Interval = 1000
        '
        'ViewAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.ViewAttendencePanel)
        Me.Controls.Add(Me.CStatusPictureBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ViewAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Attendence"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ViewAttendencePanel.ResumeLayout(False)
        Me.ActionsGroupBox.ResumeLayout(False)
        CType(Me.ViewAttendenceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents HomeMenuItem As ToolStripMenuItem
    Friend WithEvents AddMenuItem As ToolStripMenuItem
    Friend WithEvents AddStaffDetailsMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentDetailsMenuItem As ToolStripMenuItem
    Friend WithEvents ManageMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStaffDetailsMenuItem As ToolStripMenuItem
    Friend WithEvents ManageStudentDetailsMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsMenuItem As ToolStripMenuItem
    Friend WithEvents ViewAttendenceMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeMobileNoMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSecurityQuestionMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreDefaultsMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProfileMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateProfileMenuItem As ToolStripMenuItem
    Friend WithEvents ChangePasswordMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutMenuItem As ToolStripMenuItem
    Friend WithEvents AboutMenuItem As ToolStripMenuItem
    Friend WithEvents AboutAttendMenuItem As ToolStripMenuItem
    Friend WithEvents AboutUsMenuItem As ToolStripMenuItem
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents MinusButton As Button
    Friend WithEvents CrossButton As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ServerStatusLabel As ToolStripStatusLabel
    Friend WithEvents ConnectionStatusLabel As ToolStripStatusLabel
    Friend WithEvents TimeLabel As ToolStripStatusLabel
    Friend WithEvents CStatusPictureBox As PictureBox
    Friend WithEvents ViewAttendencePanel As Panel
    Friend WithEvents ViewAttendenceDataGridView As DataGridView
    Friend WithEvents FromDatePicker As DateTimePicker
    Friend WithEvents ClearButton As Button
    Friend WithEvents SemesterComboBox As ComboBox
    Friend WithEvents ToDatePicker As DateTimePicker
    Friend WithEvents ActionsGroupBox As GroupBox
    Friend WithEvents ViewButton As Button
    Friend WithEvents SemesterLabel As Label
    Friend WithEvents ToDateLabel As Label
    Friend WithEvents FromDateLabel As Label
    Friend WithEvents ToDateStatusLabel As Label
    Friend WithEvents FromDateStatusLabel As Label
    Friend WithEvents ConnectionTimer As Timer
    Friend WithEvents TimeTimer As Timer
    Friend WithEvents ValidationTimer As Timer
End Class
