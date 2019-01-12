<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdateProfile
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProfile))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ServerStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimeLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UpdateProfilePanel = New System.Windows.Forms.Panel()
        Me.SecurityAnswerStatusLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionStatusLabel = New System.Windows.Forms.Label()
        Me.CountryStatusLabel = New System.Windows.Forms.Label()
        Me.ProvinceStatusLabel = New System.Windows.Forms.Label()
        Me.CityStatusLabel = New System.Windows.Forms.Label()
        Me.ZIPCodeStatusLabel = New System.Windows.Forms.Label()
        Me.AddressStatusLabel = New System.Windows.Forms.Label()
        Me.MobileNoStatusLabel = New System.Windows.Forms.Label()
        Me.EmailIDStatusLabel = New System.Windows.Forms.Label()
        Me.GenderStatusLabel = New System.Windows.Forms.Label()
        Me.BirthDateStatusLabel = New System.Windows.Forms.Label()
        Me.LastNameStatusLabel = New System.Windows.Forms.Label()
        Me.FirstNameStatusLabel = New System.Windows.Forms.Label()
        Me.SecurityAnswerImpLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionImpLabel = New System.Windows.Forms.Label()
        Me.CountryImpLabel = New System.Windows.Forms.Label()
        Me.ProvinceImpLabel = New System.Windows.Forms.Label()
        Me.CityImpLabel = New System.Windows.Forms.Label()
        Me.ZIPCodeImpLabel = New System.Windows.Forms.Label()
        Me.AddressImpLabel = New System.Windows.Forms.Label()
        Me.LastNameImpLabel = New System.Windows.Forms.Label()
        Me.BirthDateImpLabel = New System.Windows.Forms.Label()
        Me.GenderImpLabel = New System.Windows.Forms.Label()
        Me.MobileNoImpLabel = New System.Windows.Forms.Label()
        Me.EmailIDImpLabel = New System.Windows.Forms.Label()
        Me.FirstNameImpLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionComboBox = New System.Windows.Forms.ComboBox()
        Me.FemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.MaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.BirthDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.SecurityAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.MobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.EmailIDTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityAnswerLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionLabel = New System.Windows.Forms.Label()
        Me.MobileNoLabel = New System.Windows.Forms.Label()
        Me.EmailIDLabel = New System.Windows.Forms.Label()
        Me.UpdateProfileStatusLabel = New System.Windows.Forms.Label()
        Me.ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ZipCodeLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.CountryTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddleNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.CountryLabel = New System.Windows.Forms.Label()
        Me.ProvinceLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.GenderLabel = New System.Windows.Forms.Label()
        Me.BirthDateLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.MiddleNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.OpenProfilePictureDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TimeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ConnectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.CStatusPictureBox = New System.Windows.Forms.PictureBox()
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
        Me.StatusStrip.SuspendLayout()
        Me.UpdateProfilePanel.SuspendLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
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
        Me.StatusStrip.TabIndex = 2
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
        'UpdateProfilePanel
        '
        Me.UpdateProfilePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityAnswerStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityQuestionStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.CountryStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ProvinceStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.CityStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ZIPCodeStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.AddressStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.MobileNoStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.EmailIDStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.GenderStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.BirthDateStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.LastNameStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.FirstNameStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityAnswerImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityQuestionImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.CountryImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ProvinceImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.CityImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ZIPCodeImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.AddressImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.LastNameImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.BirthDateImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.GenderImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.MobileNoImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.EmailIDImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.FirstNameImpLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityQuestionComboBox)
        Me.UpdateProfilePanel.Controls.Add(Me.FemaleRadioButton)
        Me.UpdateProfilePanel.Controls.Add(Me.MaleRadioButton)
        Me.UpdateProfilePanel.Controls.Add(Me.BirthDatePicker)
        Me.UpdateProfilePanel.Controls.Add(Me.ProfilePictureBox)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityAnswerTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.MobileNoTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.EmailIDTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityAnswerLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.SecurityQuestionLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.MobileNoLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.EmailIDLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.UpdateProfileStatusLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ZipCodeTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.ZipCodeLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ClearButton)
        Me.UpdateProfilePanel.Controls.Add(Me.UpdateButton)
        Me.UpdateProfilePanel.Controls.Add(Me.ProvinceTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.CountryTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.CityTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.AddressTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.LastNameTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.MiddleNameTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.FirstNameTextBox)
        Me.UpdateProfilePanel.Controls.Add(Me.CountryLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.ProvinceLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.CityLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.AddressLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.GenderLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.BirthDateLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.LastNameLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.MiddleNameLabel)
        Me.UpdateProfilePanel.Controls.Add(Me.FirstNameLabel)
        Me.UpdateProfilePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.UpdateProfilePanel.Location = New System.Drawing.Point(0, 50)
        Me.UpdateProfilePanel.Name = "UpdateProfilePanel"
        Me.UpdateProfilePanel.Size = New System.Drawing.Size(1280, 640)
        Me.UpdateProfilePanel.TabIndex = 0
        '
        'SecurityAnswerStatusLabel
        '
        Me.SecurityAnswerStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityAnswerStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityAnswerStatusLabel.Location = New System.Drawing.Point(780, 529)
        Me.SecurityAnswerStatusLabel.Name = "SecurityAnswerStatusLabel"
        Me.SecurityAnswerStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.SecurityAnswerStatusLabel.TabIndex = 0
        Me.SecurityAnswerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SecurityQuestionStatusLabel
        '
        Me.SecurityQuestionStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityQuestionStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityQuestionStatusLabel.Location = New System.Drawing.Point(780, 459)
        Me.SecurityQuestionStatusLabel.Name = "SecurityQuestionStatusLabel"
        Me.SecurityQuestionStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.SecurityQuestionStatusLabel.TabIndex = 0
        Me.SecurityQuestionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CountryStatusLabel
        '
        Me.CountryStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountryStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.CountryStatusLabel.Location = New System.Drawing.Point(780, 389)
        Me.CountryStatusLabel.Name = "CountryStatusLabel"
        Me.CountryStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.CountryStatusLabel.TabIndex = 0
        Me.CountryStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProvinceStatusLabel
        '
        Me.ProvinceStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProvinceStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ProvinceStatusLabel.Location = New System.Drawing.Point(780, 319)
        Me.ProvinceStatusLabel.Name = "ProvinceStatusLabel"
        Me.ProvinceStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.ProvinceStatusLabel.TabIndex = 0
        Me.ProvinceStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CityStatusLabel
        '
        Me.CityStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.CityStatusLabel.Location = New System.Drawing.Point(780, 249)
        Me.CityStatusLabel.Name = "CityStatusLabel"
        Me.CityStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.CityStatusLabel.TabIndex = 0
        Me.CityStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ZIPCodeStatusLabel
        '
        Me.ZIPCodeStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZIPCodeStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPCodeStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ZIPCodeStatusLabel.Location = New System.Drawing.Point(780, 179)
        Me.ZIPCodeStatusLabel.Name = "ZIPCodeStatusLabel"
        Me.ZIPCodeStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.ZIPCodeStatusLabel.TabIndex = 0
        Me.ZIPCodeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AddressStatusLabel
        '
        Me.AddressStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.AddressStatusLabel.Location = New System.Drawing.Point(780, 109)
        Me.AddressStatusLabel.Name = "AddressStatusLabel"
        Me.AddressStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.AddressStatusLabel.TabIndex = 0
        Me.AddressStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MobileNoStatusLabel
        '
        Me.MobileNoStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.MobileNoStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.MobileNoStatusLabel.Location = New System.Drawing.Point(260, 529)
        Me.MobileNoStatusLabel.Name = "MobileNoStatusLabel"
        Me.MobileNoStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.MobileNoStatusLabel.TabIndex = 0
        Me.MobileNoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'EmailIDStatusLabel
        '
        Me.EmailIDStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailIDStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.EmailIDStatusLabel.Location = New System.Drawing.Point(260, 459)
        Me.EmailIDStatusLabel.Name = "EmailIDStatusLabel"
        Me.EmailIDStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.EmailIDStatusLabel.TabIndex = 0
        Me.EmailIDStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GenderStatusLabel
        '
        Me.GenderStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.GenderStatusLabel.Location = New System.Drawing.Point(260, 389)
        Me.GenderStatusLabel.Name = "GenderStatusLabel"
        Me.GenderStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.GenderStatusLabel.TabIndex = 0
        Me.GenderStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BirthDateStatusLabel
        '
        Me.BirthDateStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.BirthDateStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.BirthDateStatusLabel.Location = New System.Drawing.Point(260, 319)
        Me.BirthDateStatusLabel.Name = "BirthDateStatusLabel"
        Me.BirthDateStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.BirthDateStatusLabel.TabIndex = 0
        Me.BirthDateStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LastNameStatusLabel
        '
        Me.LastNameStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.LastNameStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.LastNameStatusLabel.Location = New System.Drawing.Point(260, 249)
        Me.LastNameStatusLabel.Name = "LastNameStatusLabel"
        Me.LastNameStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.LastNameStatusLabel.TabIndex = 0
        Me.LastNameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FirstNameStatusLabel
        '
        Me.FirstNameStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.FirstNameStatusLabel.Location = New System.Drawing.Point(260, 109)
        Me.FirstNameStatusLabel.Name = "FirstNameStatusLabel"
        Me.FirstNameStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.FirstNameStatusLabel.TabIndex = 0
        Me.FirstNameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SecurityAnswerImpLabel
        '
        Me.SecurityAnswerImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityAnswerImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerImpLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityAnswerImpLabel.Location = New System.Drawing.Point(720, 495)
        Me.SecurityAnswerImpLabel.Name = "SecurityAnswerImpLabel"
        Me.SecurityAnswerImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.SecurityAnswerImpLabel.TabIndex = 0
        Me.SecurityAnswerImpLabel.Text = "*"
        Me.SecurityAnswerImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SecurityQuestionImpLabel
        '
        Me.SecurityQuestionImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityQuestionImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionImpLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityQuestionImpLabel.Location = New System.Drawing.Point(720, 425)
        Me.SecurityQuestionImpLabel.Name = "SecurityQuestionImpLabel"
        Me.SecurityQuestionImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.SecurityQuestionImpLabel.TabIndex = 0
        Me.SecurityQuestionImpLabel.Text = "*"
        Me.SecurityQuestionImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CountryImpLabel
        '
        Me.CountryImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountryImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryImpLabel.ForeColor = System.Drawing.Color.Red
        Me.CountryImpLabel.Location = New System.Drawing.Point(720, 355)
        Me.CountryImpLabel.Name = "CountryImpLabel"
        Me.CountryImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.CountryImpLabel.TabIndex = 0
        Me.CountryImpLabel.Text = "*"
        Me.CountryImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProvinceImpLabel
        '
        Me.ProvinceImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProvinceImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceImpLabel.ForeColor = System.Drawing.Color.Red
        Me.ProvinceImpLabel.Location = New System.Drawing.Point(720, 285)
        Me.ProvinceImpLabel.Name = "ProvinceImpLabel"
        Me.ProvinceImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.ProvinceImpLabel.TabIndex = 0
        Me.ProvinceImpLabel.Text = "*"
        Me.ProvinceImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CityImpLabel
        '
        Me.CityImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityImpLabel.ForeColor = System.Drawing.Color.Red
        Me.CityImpLabel.Location = New System.Drawing.Point(720, 215)
        Me.CityImpLabel.Name = "CityImpLabel"
        Me.CityImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.CityImpLabel.TabIndex = 0
        Me.CityImpLabel.Text = "*"
        Me.CityImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZIPCodeImpLabel
        '
        Me.ZIPCodeImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZIPCodeImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPCodeImpLabel.ForeColor = System.Drawing.Color.Red
        Me.ZIPCodeImpLabel.Location = New System.Drawing.Point(720, 145)
        Me.ZIPCodeImpLabel.Name = "ZIPCodeImpLabel"
        Me.ZIPCodeImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.ZIPCodeImpLabel.TabIndex = 0
        Me.ZIPCodeImpLabel.Text = "*"
        Me.ZIPCodeImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddressImpLabel
        '
        Me.AddressImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressImpLabel.ForeColor = System.Drawing.Color.Red
        Me.AddressImpLabel.Location = New System.Drawing.Point(720, 75)
        Me.AddressImpLabel.Name = "AddressImpLabel"
        Me.AddressImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.AddressImpLabel.TabIndex = 0
        Me.AddressImpLabel.Text = "*"
        Me.AddressImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LastNameImpLabel
        '
        Me.LastNameImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.LastNameImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameImpLabel.ForeColor = System.Drawing.Color.Red
        Me.LastNameImpLabel.Location = New System.Drawing.Point(200, 215)
        Me.LastNameImpLabel.Name = "LastNameImpLabel"
        Me.LastNameImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.LastNameImpLabel.TabIndex = 0
        Me.LastNameImpLabel.Text = "*"
        Me.LastNameImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BirthDateImpLabel
        '
        Me.BirthDateImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.BirthDateImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateImpLabel.ForeColor = System.Drawing.Color.Red
        Me.BirthDateImpLabel.Location = New System.Drawing.Point(200, 285)
        Me.BirthDateImpLabel.Name = "BirthDateImpLabel"
        Me.BirthDateImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.BirthDateImpLabel.TabIndex = 0
        Me.BirthDateImpLabel.Text = "*"
        Me.BirthDateImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GenderImpLabel
        '
        Me.GenderImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderImpLabel.ForeColor = System.Drawing.Color.Red
        Me.GenderImpLabel.Location = New System.Drawing.Point(200, 355)
        Me.GenderImpLabel.Name = "GenderImpLabel"
        Me.GenderImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.GenderImpLabel.TabIndex = 0
        Me.GenderImpLabel.Text = "*"
        Me.GenderImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MobileNoImpLabel
        '
        Me.MobileNoImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.MobileNoImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoImpLabel.ForeColor = System.Drawing.Color.Red
        Me.MobileNoImpLabel.Location = New System.Drawing.Point(200, 495)
        Me.MobileNoImpLabel.Name = "MobileNoImpLabel"
        Me.MobileNoImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.MobileNoImpLabel.TabIndex = 0
        Me.MobileNoImpLabel.Text = "*"
        Me.MobileNoImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'EmailIDImpLabel
        '
        Me.EmailIDImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailIDImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDImpLabel.ForeColor = System.Drawing.Color.Red
        Me.EmailIDImpLabel.Location = New System.Drawing.Point(200, 425)
        Me.EmailIDImpLabel.Name = "EmailIDImpLabel"
        Me.EmailIDImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.EmailIDImpLabel.TabIndex = 0
        Me.EmailIDImpLabel.Text = "*"
        Me.EmailIDImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FirstNameImpLabel
        '
        Me.FirstNameImpLabel.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameImpLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameImpLabel.ForeColor = System.Drawing.Color.Red
        Me.FirstNameImpLabel.Location = New System.Drawing.Point(200, 75)
        Me.FirstNameImpLabel.Name = "FirstNameImpLabel"
        Me.FirstNameImpLabel.Size = New System.Drawing.Size(30, 30)
        Me.FirstNameImpLabel.TabIndex = 0
        Me.FirstNameImpLabel.Text = "*"
        Me.FirstNameImpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SecurityQuestionComboBox
        '
        Me.SecurityQuestionComboBox.BackColor = System.Drawing.Color.White
        Me.SecurityQuestionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SecurityQuestionComboBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionComboBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityQuestionComboBox.FormattingEnabled = True
        Me.SecurityQuestionComboBox.ItemHeight = 21
        Me.SecurityQuestionComboBox.Items.AddRange(New Object() {"Select a Security Question", "What is your birth place?", "What is your father's name?", "What is your mother's name?", "What is your pet's name?", "What was your first mobile no.?", "What was your first school name?"})
        Me.SecurityQuestionComboBox.Location = New System.Drawing.Point(780, 425)
        Me.SecurityQuestionComboBox.Name = "SecurityQuestionComboBox"
        Me.SecurityQuestionComboBox.Size = New System.Drawing.Size(250, 29)
        Me.SecurityQuestionComboBox.Sorted = True
        Me.SecurityQuestionComboBox.TabIndex = 14
        '
        'FemaleRadioButton
        '
        Me.FemaleRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.FemaleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FemaleRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FemaleRadioButton.Location = New System.Drawing.Point(390, 355)
        Me.FemaleRadioButton.Name = "FemaleRadioButton"
        Me.FemaleRadioButton.Size = New System.Drawing.Size(100, 29)
        Me.FemaleRadioButton.TabIndex = 6
        Me.FemaleRadioButton.TabStop = True
        Me.FemaleRadioButton.Text = "Female"
        Me.FemaleRadioButton.UseVisualStyleBackColor = True
        '
        'MaleRadioButton
        '
        Me.MaleRadioButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue
        Me.MaleRadioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaleRadioButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaleRadioButton.Location = New System.Drawing.Point(280, 355)
        Me.MaleRadioButton.Name = "MaleRadioButton"
        Me.MaleRadioButton.Size = New System.Drawing.Size(100, 29)
        Me.MaleRadioButton.TabIndex = 5
        Me.MaleRadioButton.TabStop = True
        Me.MaleRadioButton.Text = "Male"
        Me.MaleRadioButton.UseVisualStyleBackColor = True
        '
        'BirthDatePicker
        '
        Me.BirthDatePicker.CalendarForeColor = System.Drawing.Color.DarkBlue
        Me.BirthDatePicker.CalendarMonthBackground = System.Drawing.Color.DarkBlue
        Me.BirthDatePicker.CalendarTitleBackColor = System.Drawing.Color.DarkBlue
        Me.BirthDatePicker.CalendarTitleForeColor = System.Drawing.Color.DarkBlue
        Me.BirthDatePicker.CalendarTrailingForeColor = System.Drawing.Color.DarkBlue
        Me.BirthDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.BirthDatePicker.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDatePicker.Location = New System.Drawing.Point(260, 285)
        Me.BirthDatePicker.Name = "BirthDatePicker"
        Me.BirthDatePicker.ShowUpDown = True
        Me.BirthDatePicker.Size = New System.Drawing.Size(250, 29)
        Me.BirthDatePicker.TabIndex = 4
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProfilePictureBox.Image = Global.AMS.My.Resources.Resources.Profile_Picture
        Me.ProfilePictureBox.ImageLocation = ""
        Me.ProfilePictureBox.Location = New System.Drawing.Point(1080, 75)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(160, 200)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePictureBox.TabIndex = 135
        Me.ProfilePictureBox.TabStop = False
        '
        'SecurityAnswerTextBox
        '
        Me.SecurityAnswerTextBox.BackColor = System.Drawing.Color.White
        Me.SecurityAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecurityAnswerTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerTextBox.ForeColor = System.Drawing.Color.Black
        Me.SecurityAnswerTextBox.Location = New System.Drawing.Point(780, 495)
        Me.SecurityAnswerTextBox.Name = "SecurityAnswerTextBox"
        Me.SecurityAnswerTextBox.Size = New System.Drawing.Size(250, 29)
        Me.SecurityAnswerTextBox.TabIndex = 15
        '
        'MobileNoTextBox
        '
        Me.MobileNoTextBox.BackColor = System.Drawing.Color.White
        Me.MobileNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MobileNoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoTextBox.ForeColor = System.Drawing.Color.Black
        Me.MobileNoTextBox.Location = New System.Drawing.Point(260, 495)
        Me.MobileNoTextBox.Name = "MobileNoTextBox"
        Me.MobileNoTextBox.Size = New System.Drawing.Size(250, 29)
        Me.MobileNoTextBox.TabIndex = 8
        '
        'EmailIDTextBox
        '
        Me.EmailIDTextBox.BackColor = System.Drawing.Color.White
        Me.EmailIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailIDTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDTextBox.ForeColor = System.Drawing.Color.Black
        Me.EmailIDTextBox.Location = New System.Drawing.Point(260, 425)
        Me.EmailIDTextBox.Name = "EmailIDTextBox"
        Me.EmailIDTextBox.Size = New System.Drawing.Size(250, 29)
        Me.EmailIDTextBox.TabIndex = 7
        '
        'SecurityAnswerLabel
        '
        Me.SecurityAnswerLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityAnswerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityAnswerLabel.Location = New System.Drawing.Point(570, 495)
        Me.SecurityAnswerLabel.Name = "SecurityAnswerLabel"
        Me.SecurityAnswerLabel.Size = New System.Drawing.Size(150, 30)
        Me.SecurityAnswerLabel.TabIndex = 0
        Me.SecurityAnswerLabel.Text = "Security Answer:"
        Me.SecurityAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SecurityQuestionLabel
        '
        Me.SecurityQuestionLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityQuestionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityQuestionLabel.Location = New System.Drawing.Point(570, 425)
        Me.SecurityQuestionLabel.Name = "SecurityQuestionLabel"
        Me.SecurityQuestionLabel.Size = New System.Drawing.Size(150, 30)
        Me.SecurityQuestionLabel.TabIndex = 0
        Me.SecurityQuestionLabel.Text = "Security Question:"
        Me.SecurityQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MobileNoLabel
        '
        Me.MobileNoLabel.BackColor = System.Drawing.Color.Transparent
        Me.MobileNoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.MobileNoLabel.Location = New System.Drawing.Point(50, 495)
        Me.MobileNoLabel.Name = "MobileNoLabel"
        Me.MobileNoLabel.Size = New System.Drawing.Size(150, 30)
        Me.MobileNoLabel.TabIndex = 0
        Me.MobileNoLabel.Text = "Mobile No.:"
        Me.MobileNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'EmailIDLabel
        '
        Me.EmailIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.EmailIDLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailIDLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.EmailIDLabel.Location = New System.Drawing.Point(50, 425)
        Me.EmailIDLabel.Name = "EmailIDLabel"
        Me.EmailIDLabel.Size = New System.Drawing.Size(150, 30)
        Me.EmailIDLabel.TabIndex = 0
        Me.EmailIDLabel.Text = "Email ID:"
        Me.EmailIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'UpdateProfileStatusLabel
        '
        Me.UpdateProfileStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.UpdateProfileStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateProfileStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.UpdateProfileStatusLabel.Location = New System.Drawing.Point(330, 25)
        Me.UpdateProfileStatusLabel.Name = "UpdateProfileStatusLabel"
        Me.UpdateProfileStatusLabel.Size = New System.Drawing.Size(500, 28)
        Me.UpdateProfileStatusLabel.TabIndex = 0
        Me.UpdateProfileStatusLabel.Text = "Fields marked with * are mandatory!"
        Me.UpdateProfileStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ZipCodeTextBox
        '
        Me.ZipCodeTextBox.BackColor = System.Drawing.Color.White
        Me.ZipCodeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ZipCodeTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeTextBox.ForeColor = System.Drawing.Color.Black
        Me.ZipCodeTextBox.Location = New System.Drawing.Point(780, 145)
        Me.ZipCodeTextBox.Name = "ZipCodeTextBox"
        Me.ZipCodeTextBox.Size = New System.Drawing.Size(250, 29)
        Me.ZipCodeTextBox.TabIndex = 10
        '
        'ZipCodeLabel
        '
        Me.ZipCodeLabel.BackColor = System.Drawing.Color.Transparent
        Me.ZipCodeLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZipCodeLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ZipCodeLabel.Location = New System.Drawing.Point(570, 145)
        Me.ZipCodeLabel.Name = "ZipCodeLabel"
        Me.ZipCodeLabel.Size = New System.Drawing.Size(150, 30)
        Me.ZipCodeLabel.TabIndex = 0
        Me.ZipCodeLabel.Text = "ZIP Code:"
        Me.ZipCodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(570, 565)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 17
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.Orange
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(382, 565)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(128, 40)
        Me.UpdateButton.TabIndex = 16
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'ProvinceTextBox
        '
        Me.ProvinceTextBox.BackColor = System.Drawing.Color.White
        Me.ProvinceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProvinceTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceTextBox.ForeColor = System.Drawing.Color.Black
        Me.ProvinceTextBox.Location = New System.Drawing.Point(780, 285)
        Me.ProvinceTextBox.Name = "ProvinceTextBox"
        Me.ProvinceTextBox.Size = New System.Drawing.Size(250, 29)
        Me.ProvinceTextBox.TabIndex = 12
        '
        'CountryTextBox
        '
        Me.CountryTextBox.BackColor = System.Drawing.Color.White
        Me.CountryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CountryTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryTextBox.ForeColor = System.Drawing.Color.Black
        Me.CountryTextBox.Location = New System.Drawing.Point(780, 355)
        Me.CountryTextBox.Name = "CountryTextBox"
        Me.CountryTextBox.Size = New System.Drawing.Size(250, 29)
        Me.CountryTextBox.TabIndex = 13
        '
        'CityTextBox
        '
        Me.CityTextBox.BackColor = System.Drawing.Color.White
        Me.CityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CityTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.ForeColor = System.Drawing.Color.Black
        Me.CityTextBox.Location = New System.Drawing.Point(780, 215)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(250, 29)
        Me.CityTextBox.TabIndex = 11
        '
        'AddressTextBox
        '
        Me.AddressTextBox.BackColor = System.Drawing.Color.White
        Me.AddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AddressTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressTextBox.ForeColor = System.Drawing.Color.Black
        Me.AddressTextBox.Location = New System.Drawing.Point(780, 75)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(250, 29)
        Me.AddressTextBox.TabIndex = 9
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.BackColor = System.Drawing.Color.White
        Me.LastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LastNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.LastNameTextBox.Location = New System.Drawing.Point(260, 215)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(250, 29)
        Me.LastNameTextBox.TabIndex = 3
        '
        'MiddleNameTextBox
        '
        Me.MiddleNameTextBox.BackColor = System.Drawing.Color.White
        Me.MiddleNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MiddleNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.MiddleNameTextBox.Location = New System.Drawing.Point(260, 145)
        Me.MiddleNameTextBox.Name = "MiddleNameTextBox"
        Me.MiddleNameTextBox.Size = New System.Drawing.Size(250, 29)
        Me.MiddleNameTextBox.TabIndex = 2
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.BackColor = System.Drawing.Color.White
        Me.FirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTextBox.Location = New System.Drawing.Point(260, 75)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(250, 29)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'CountryLabel
        '
        Me.CountryLabel.BackColor = System.Drawing.Color.Transparent
        Me.CountryLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.CountryLabel.Location = New System.Drawing.Point(570, 355)
        Me.CountryLabel.Name = "CountryLabel"
        Me.CountryLabel.Size = New System.Drawing.Size(150, 30)
        Me.CountryLabel.TabIndex = 0
        Me.CountryLabel.Text = "Country:"
        Me.CountryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ProvinceLabel
        '
        Me.ProvinceLabel.BackColor = System.Drawing.Color.Transparent
        Me.ProvinceLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProvinceLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ProvinceLabel.Location = New System.Drawing.Point(570, 285)
        Me.ProvinceLabel.Name = "ProvinceLabel"
        Me.ProvinceLabel.Size = New System.Drawing.Size(150, 30)
        Me.ProvinceLabel.TabIndex = 0
        Me.ProvinceLabel.Text = "Province:"
        Me.ProvinceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CityLabel
        '
        Me.CityLabel.BackColor = System.Drawing.Color.Transparent
        Me.CityLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.CityLabel.Location = New System.Drawing.Point(570, 215)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(150, 30)
        Me.CityLabel.TabIndex = 0
        Me.CityLabel.Text = "City:"
        Me.CityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AddressLabel
        '
        Me.AddressLabel.BackColor = System.Drawing.Color.Transparent
        Me.AddressLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddressLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.AddressLabel.Location = New System.Drawing.Point(570, 75)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(150, 30)
        Me.AddressLabel.TabIndex = 0
        Me.AddressLabel.Text = "Address:"
        Me.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GenderLabel
        '
        Me.GenderLabel.BackColor = System.Drawing.Color.Transparent
        Me.GenderLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.GenderLabel.Location = New System.Drawing.Point(50, 355)
        Me.GenderLabel.Name = "GenderLabel"
        Me.GenderLabel.Size = New System.Drawing.Size(150, 30)
        Me.GenderLabel.TabIndex = 0
        Me.GenderLabel.Text = "Gender:"
        Me.GenderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'BirthDateLabel
        '
        Me.BirthDateLabel.BackColor = System.Drawing.Color.Transparent
        Me.BirthDateLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BirthDateLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.BirthDateLabel.Location = New System.Drawing.Point(50, 285)
        Me.BirthDateLabel.Name = "BirthDateLabel"
        Me.BirthDateLabel.Size = New System.Drawing.Size(150, 30)
        Me.BirthDateLabel.TabIndex = 0
        Me.BirthDateLabel.Text = "Birth Date:"
        Me.BirthDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LastNameLabel
        '
        Me.LastNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.LastNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.LastNameLabel.Location = New System.Drawing.Point(50, 215)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(150, 30)
        Me.LastNameLabel.TabIndex = 0
        Me.LastNameLabel.Text = "Last Name:"
        Me.LastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MiddleNameLabel
        '
        Me.MiddleNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.MiddleNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleNameLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.MiddleNameLabel.Location = New System.Drawing.Point(50, 145)
        Me.MiddleNameLabel.Name = "MiddleNameLabel"
        Me.MiddleNameLabel.Size = New System.Drawing.Size(150, 30)
        Me.MiddleNameLabel.TabIndex = 0
        Me.MiddleNameLabel.Text = "Middle Name:"
        Me.MiddleNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.BackColor = System.Drawing.Color.Transparent
        Me.FirstNameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.FirstNameLabel.Location = New System.Drawing.Point(50, 75)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(150, 30)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name:"
        Me.FirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OpenProfilePictureDialog
        '
        Me.OpenProfilePictureDialog.Filter = "Image Files(*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG)|*.BMP;*.GIF;*.JPG;*.JPEG;*.PNG|All Fi" &
    "les(*.*)|*.*"
        Me.OpenProfilePictureDialog.InitialDirectory = "My.Computer.FileSystem.SpecialDirectories.MyPictures"
        Me.OpenProfilePictureDialog.SupportMultiDottedExtensions = True
        Me.OpenProfilePictureDialog.Title = "Select your Profile Picture"
        '
        'TimeTimer
        '
        Me.TimeTimer.Interval = 1000
        '
        'ConnectionTimer
        '
        Me.ConnectionTimer.Interval = 1000
        '
        'ValidationTimer
        '
        Me.ValidationTimer.Interval = 1000
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
        Me.CrossButton.TabIndex = 19
        Me.CrossButton.UseVisualStyleBackColor = False
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
        Me.MinusButton.TabIndex = 18
        Me.MinusButton.UseVisualStyleBackColor = False
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackColor = System.Drawing.Color.DarkBlue
        Me.LogoPictureBox.Image = Global.AMS.My.Resources.Resources.Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(5, 5)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(160, 40)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 40
        Me.LogoPictureBox.TabStop = False
        '
        'CStatusPictureBox
        '
        Me.CStatusPictureBox.BackColor = System.Drawing.Color.DarkBlue
        Me.CStatusPictureBox.Location = New System.Drawing.Point(88, 691)
        Me.CStatusPictureBox.Name = "CStatusPictureBox"
        Me.CStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.CStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CStatusPictureBox.TabIndex = 37
        Me.CStatusPictureBox.TabStop = False
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
        Me.MenuStrip.TabIndex = 41
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
        Me.UpdateProfileMenuItem.Enabled = False
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
        'UpdateProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.UpdateProfilePanel)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.Controls.Add(Me.CStatusPictureBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Profile"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.UpdateProfilePanel.ResumeLayout(False)
        Me.UpdateProfilePanel.PerformLayout()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ServerStatusLabel As ToolStripStatusLabel
    Friend WithEvents ConnectionStatusLabel As ToolStripStatusLabel
    Friend WithEvents TimeLabel As ToolStripStatusLabel
    Friend WithEvents CStatusPictureBox As PictureBox
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents MinusButton As Button
    Friend WithEvents CrossButton As Button
    Friend WithEvents UpdateProfilePanel As Panel
    Friend WithEvents SecurityAnswerTextBox As TextBox
    Friend WithEvents MobileNoTextBox As TextBox
    Friend WithEvents EmailIDTextBox As TextBox
    Friend WithEvents SecurityAnswerLabel As Label
    Friend WithEvents SecurityQuestionLabel As Label
    Friend WithEvents MobileNoLabel As Label
    Friend WithEvents EmailIDLabel As Label
    Friend WithEvents UpdateProfileStatusLabel As Label
    Friend WithEvents ZipCodeTextBox As TextBox
    Friend WithEvents ZipCodeLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ProvinceTextBox As TextBox
    Friend WithEvents CountryTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents MiddleNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents CountryLabel As Label
    Friend WithEvents ProvinceLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents AddressLabel As Label
    Friend WithEvents GenderLabel As Label
    Friend WithEvents BirthDateLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents MiddleNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents FemaleRadioButton As RadioButton
    Friend WithEvents MaleRadioButton As RadioButton
    Friend WithEvents BirthDatePicker As DateTimePicker
    Friend WithEvents SecurityQuestionComboBox As ComboBox
    Friend WithEvents OpenProfilePictureDialog As OpenFileDialog
    Friend WithEvents TimeTimer As Timer
    Friend WithEvents ConnectionTimer As Timer
    Friend WithEvents ValidationTimer As Timer
    Friend WithEvents SecurityAnswerImpLabel As Label
    Friend WithEvents SecurityQuestionImpLabel As Label
    Friend WithEvents CountryImpLabel As Label
    Friend WithEvents ProvinceImpLabel As Label
    Friend WithEvents CityImpLabel As Label
    Friend WithEvents ZIPCodeImpLabel As Label
    Friend WithEvents AddressImpLabel As Label
    Friend WithEvents LastNameImpLabel As Label
    Friend WithEvents BirthDateImpLabel As Label
    Friend WithEvents GenderImpLabel As Label
    Friend WithEvents MobileNoImpLabel As Label
    Friend WithEvents EmailIDImpLabel As Label
    Friend WithEvents FirstNameImpLabel As Label
    Friend WithEvents FirstNameStatusLabel As Label
    Friend WithEvents SecurityAnswerStatusLabel As Label
    Friend WithEvents SecurityQuestionStatusLabel As Label
    Friend WithEvents CountryStatusLabel As Label
    Friend WithEvents ProvinceStatusLabel As Label
    Friend WithEvents CityStatusLabel As Label
    Friend WithEvents ZIPCodeStatusLabel As Label
    Friend WithEvents AddressStatusLabel As Label
    Friend WithEvents MobileNoStatusLabel As Label
    Friend WithEvents EmailIDStatusLabel As Label
    Friend WithEvents GenderStatusLabel As Label
    Friend WithEvents BirthDateStatusLabel As Label
    Friend WithEvents LastNameStatusLabel As Label
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
End Class
