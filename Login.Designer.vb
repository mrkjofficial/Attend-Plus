<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ServerStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ConnectionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.LoginStatusLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.LoginPanel = New System.Windows.Forms.Panel()
        Me.PasswordPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernamePictureBox = New System.Windows.Forms.PictureBox()
        Me.TechnoPictureBox = New System.Windows.Forms.PictureBox()
        Me.InfoButton = New System.Windows.Forms.Button()
        Me.CStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.MinusButton = New System.Windows.Forms.Button()
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.LoginPanel.SuspendLayout()
        CType(Me.PasswordPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsernamePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TechnoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.DarkBlue
        Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.Color.White
        Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(640, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Login"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.BackColor = System.Drawing.Color.DarkBlue
        Me.StatusStrip.Font = New System.Drawing.Font("Segoe Print", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerStatusLabel, Me.ConnectionStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 370)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(640, 30)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 0
        '
        'ServerStatusLabel
        '
        Me.ServerStatusLabel.ActiveLinkColor = System.Drawing.Color.White
        Me.ServerStatusLabel.BackColor = System.Drawing.Color.Transparent
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
        'ConnectionTimer
        '
        Me.ConnectionTimer.Interval = 1000
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.Location = New System.Drawing.Point(350, 85)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(240, 29)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.Location = New System.Drawing.Point(350, 135)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(240, 29)
        Me.PasswordTextBox.TabIndex = 2
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.Color.Green
        Me.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginButton.ForeColor = System.Drawing.Color.White
        Me.LoginButton.Location = New System.Drawing.Point(295, 215)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(128, 40)
        Me.LoginButton.TabIndex = 4
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(462, 215)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'LoginStatusLabel
        '
        Me.LoginStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.LoginStatusLabel.Location = New System.Drawing.Point(350, 36)
        Me.LoginStatusLabel.Name = "LoginStatusLabel"
        Me.LoginStatusLabel.Size = New System.Drawing.Size(240, 28)
        Me.LoginStatusLabel.TabIndex = 0
        Me.LoginStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ForgotPasswordLinkLabel
        '
        Me.ForgotPasswordLinkLabel.ActiveLinkColor = System.Drawing.Color.DarkBlue
        Me.ForgotPasswordLinkLabel.AutoSize = True
        Me.ForgotPasswordLinkLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordLinkLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.ForgotPasswordLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.ForgotPasswordLinkLabel.LinkColor = System.Drawing.Color.DarkBlue
        Me.ForgotPasswordLinkLabel.Location = New System.Drawing.Point(295, 265)
        Me.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel"
        Me.ForgotPasswordLinkLabel.Size = New System.Drawing.Size(117, 17)
        Me.ForgotPasswordLinkLabel.TabIndex = 6
        Me.ForgotPasswordLinkLabel.TabStop = True
        Me.ForgotPasswordLinkLabel.Text = "Forgot Password?"
        Me.ForgotPasswordLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ForgotPasswordLinkLabel.VisitedLinkColor = System.Drawing.Color.DarkBlue
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(295, 179)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(148, 28)
        Me.ShowPasswordCheckBox.TabIndex = 3
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'LoginPanel
        '
        Me.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LoginPanel.Controls.Add(Me.ShowPasswordCheckBox)
        Me.LoginPanel.Controls.Add(Me.ForgotPasswordLinkLabel)
        Me.LoginPanel.Controls.Add(Me.PasswordPictureBox)
        Me.LoginPanel.Controls.Add(Me.UsernamePictureBox)
        Me.LoginPanel.Controls.Add(Me.LoginStatusLabel)
        Me.LoginPanel.Controls.Add(Me.ClearButton)
        Me.LoginPanel.Controls.Add(Me.LoginButton)
        Me.LoginPanel.Controls.Add(Me.PasswordTextBox)
        Me.LoginPanel.Controls.Add(Me.UsernameTextBox)
        Me.LoginPanel.Controls.Add(Me.TechnoPictureBox)
        Me.LoginPanel.Location = New System.Drawing.Point(0, 50)
        Me.LoginPanel.Name = "LoginPanel"
        Me.LoginPanel.Size = New System.Drawing.Size(640, 322)
        Me.LoginPanel.TabIndex = 0
        '
        'PasswordPictureBox
        '
        Me.PasswordPictureBox.Image = Global.AMS.My.Resources.Resources.Password
        Me.PasswordPictureBox.Location = New System.Drawing.Point(295, 135)
        Me.PasswordPictureBox.Name = "PasswordPictureBox"
        Me.PasswordPictureBox.Size = New System.Drawing.Size(30, 30)
        Me.PasswordPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PasswordPictureBox.TabIndex = 40
        Me.PasswordPictureBox.TabStop = False
        '
        'UsernamePictureBox
        '
        Me.UsernamePictureBox.Image = Global.AMS.My.Resources.Resources.Username
        Me.UsernamePictureBox.Location = New System.Drawing.Point(295, 85)
        Me.UsernamePictureBox.Name = "UsernamePictureBox"
        Me.UsernamePictureBox.Size = New System.Drawing.Size(30, 30)
        Me.UsernamePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UsernamePictureBox.TabIndex = 39
        Me.UsernamePictureBox.TabStop = False
        '
        'TechnoPictureBox
        '
        Me.TechnoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TechnoPictureBox.Image = Global.AMS.My.Resources.Resources.Techno_India_Group_Logo
        Me.TechnoPictureBox.Location = New System.Drawing.Point(50, 65)
        Me.TechnoPictureBox.Name = "TechnoPictureBox"
        Me.TechnoPictureBox.Size = New System.Drawing.Size(198, 198)
        Me.TechnoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.TechnoPictureBox.TabIndex = 38
        Me.TechnoPictureBox.TabStop = False
        '
        'InfoButton
        '
        Me.InfoButton.BackColor = System.Drawing.Color.DarkBlue
        Me.InfoButton.FlatAppearance.BorderSize = 0
        Me.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InfoButton.Image = Global.AMS.My.Resources.Resources.Info
        Me.InfoButton.Location = New System.Drawing.Point(611, 371)
        Me.InfoButton.Name = "InfoButton"
        Me.InfoButton.Size = New System.Drawing.Size(28, 28)
        Me.InfoButton.TabIndex = 7
        Me.InfoButton.UseVisualStyleBackColor = False
        '
        'CStatusPictureBox
        '
        Me.CStatusPictureBox.BackColor = System.Drawing.Color.DarkBlue
        Me.CStatusPictureBox.Location = New System.Drawing.Point(88, 371)
        Me.CStatusPictureBox.Name = "CStatusPictureBox"
        Me.CStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.CStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CStatusPictureBox.TabIndex = 35
        Me.CStatusPictureBox.TabStop = False
        '
        'MinusButton
        '
        Me.MinusButton.BackColor = System.Drawing.Color.Orange
        Me.MinusButton.BackgroundImage = Global.AMS.My.Resources.Resources.Minimize
        Me.MinusButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MinusButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.MinusButton.FlatAppearance.BorderSize = 2
        Me.MinusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinusButton.Location = New System.Drawing.Point(558, 9)
        Me.MinusButton.Name = "MinusButton"
        Me.MinusButton.Size = New System.Drawing.Size(32, 32)
        Me.MinusButton.TabIndex = 8
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
        Me.CrossButton.Location = New System.Drawing.Point(599, 9)
        Me.CrossButton.Name = "CrossButton"
        Me.CrossButton.Size = New System.Drawing.Size(32, 32)
        Me.CrossButton.TabIndex = 9
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.InfoButton)
        Me.Controls.Add(Me.LoginPanel)
        Me.Controls.Add(Me.CStatusPictureBox)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.MinusButton)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.LoginPanel.ResumeLayout(False)
        Me.LoginPanel.PerformLayout()
        CType(Me.PasswordPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsernamePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TechnoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TitleLabel As Label
    Friend WithEvents CrossButton As Button
    Friend WithEvents MinusButton As Button
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ServerStatusLabel As ToolStripStatusLabel
    Friend WithEvents ConnectionStatusLabel As ToolStripStatusLabel
    Friend WithEvents CStatusPictureBox As PictureBox
    Friend WithEvents ConnectionTimer As Timer
    Friend WithEvents TechnoPictureBox As PictureBox
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents LoginStatusLabel As Label
    Friend WithEvents UsernamePictureBox As PictureBox
    Friend WithEvents PasswordPictureBox As PictureBox
    Friend WithEvents ForgotPasswordLinkLabel As LinkLabel
    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents LoginPanel As Panel
    Friend WithEvents InfoButton As Button
End Class
