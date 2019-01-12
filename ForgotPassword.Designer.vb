<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordPanel = New System.Windows.Forms.Panel()
        Me.SecurityAnswerStatusLabel = New System.Windows.Forms.Label()
        Me.SecurityAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityAnswerLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionLabel = New System.Windows.Forms.Label()
        Me.Next1Button = New System.Windows.Forms.Button()
        Me.UsernameStatusLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.ConfirmPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.NewPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.ConfirmPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.NewPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.ForgotPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.NewPasswordLabel = New System.Windows.Forms.Label()
        Me.Next2Button = New System.Windows.Forms.Button()
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.ForgotPasswordPanel.SuspendLayout()
        CType(Me.ConfirmPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitleLabel.Size = New System.Drawing.Size(480, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Forgot Password"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ForgotPasswordPanel
        '
        Me.ForgotPasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ForgotPasswordPanel.Controls.Add(Me.SecurityAnswerStatusLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.SecurityAnswerTextBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.SecurityAnswerLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.SecurityQuestionLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.Next1Button)
        Me.ForgotPasswordPanel.Controls.Add(Me.UsernameStatusLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.UsernameTextBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.UsernameLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.ConfirmPasswordStatusPictureBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.NewPasswordStatusPictureBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.ConfirmPasswordStatusLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.NewPasswordStatusLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.ForgotPasswordStatusLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.ClearButton)
        Me.ForgotPasswordPanel.Controls.Add(Me.ChangeButton)
        Me.ForgotPasswordPanel.Controls.Add(Me.NewPasswordTextBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.ForgotPasswordPanel.Controls.Add(Me.ConfirmPasswordLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.NewPasswordLabel)
        Me.ForgotPasswordPanel.Controls.Add(Me.Next2Button)
        Me.ForgotPasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ForgotPasswordPanel.Location = New System.Drawing.Point(0, 50)
        Me.ForgotPasswordPanel.Name = "ForgotPasswordPanel"
        Me.ForgotPasswordPanel.Size = New System.Drawing.Size(480, 270)
        Me.ForgotPasswordPanel.TabIndex = 0
        '
        'SecurityAnswerStatusLabel
        '
        Me.SecurityAnswerStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityAnswerStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityAnswerStatusLabel.Location = New System.Drawing.Point(187, 145)
        Me.SecurityAnswerStatusLabel.Name = "SecurityAnswerStatusLabel"
        Me.SecurityAnswerStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.SecurityAnswerStatusLabel.TabIndex = 0
        Me.SecurityAnswerStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SecurityAnswerStatusLabel.Visible = False
        '
        'SecurityAnswerTextBox
        '
        Me.SecurityAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecurityAnswerTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityAnswerTextBox.Location = New System.Drawing.Point(187, 110)
        Me.SecurityAnswerTextBox.Name = "SecurityAnswerTextBox"
        Me.SecurityAnswerTextBox.Size = New System.Drawing.Size(240, 29)
        Me.SecurityAnswerTextBox.TabIndex = 3
        Me.SecurityAnswerTextBox.Visible = False
        '
        'SecurityAnswerLabel
        '
        Me.SecurityAnswerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerLabel.Location = New System.Drawing.Point(25, 110)
        Me.SecurityAnswerLabel.Name = "SecurityAnswerLabel"
        Me.SecurityAnswerLabel.Size = New System.Drawing.Size(150, 30)
        Me.SecurityAnswerLabel.TabIndex = 0
        Me.SecurityAnswerLabel.Text = "Security Answer:"
        Me.SecurityAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SecurityAnswerLabel.Visible = False
        '
        'SecurityQuestionLabel
        '
        Me.SecurityQuestionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityQuestionLabel.Location = New System.Drawing.Point(40, 60)
        Me.SecurityQuestionLabel.Name = "SecurityQuestionLabel"
        Me.SecurityQuestionLabel.Size = New System.Drawing.Size(400, 30)
        Me.SecurityQuestionLabel.TabIndex = 74
        Me.SecurityQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.SecurityQuestionLabel.Visible = False
        '
        'Next1Button
        '
        Me.Next1Button.BackColor = System.Drawing.Color.DodgerBlue
        Me.Next1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next1Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next1Button.ForeColor = System.Drawing.Color.White
        Me.Next1Button.Location = New System.Drawing.Point(176, 200)
        Me.Next1Button.Name = "Next1Button"
        Me.Next1Button.Size = New System.Drawing.Size(128, 40)
        Me.Next1Button.TabIndex = 2
        Me.Next1Button.Text = "Next"
        Me.Next1Button.UseVisualStyleBackColor = False
        Me.Next1Button.Visible = False
        '
        'UsernameStatusLabel
        '
        Me.UsernameStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.UsernameStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.UsernameStatusLabel.Location = New System.Drawing.Point(162, 145)
        Me.UsernameStatusLabel.Name = "UsernameStatusLabel"
        Me.UsernameStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.UsernameStatusLabel.TabIndex = 0
        Me.UsernameStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.UsernameStatusLabel.Visible = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.UsernameTextBox.Location = New System.Drawing.Point(162, 110)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(240, 29)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.Visible = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(50, 110)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(100, 30)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Username:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.UsernameLabel.Visible = False
        '
        'ConfirmPasswordStatusPictureBox
        '
        Me.ConfirmPasswordStatusPictureBox.Location = New System.Drawing.Point(427, 130)
        Me.ConfirmPasswordStatusPictureBox.Name = "ConfirmPasswordStatusPictureBox"
        Me.ConfirmPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.ConfirmPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ConfirmPasswordStatusPictureBox.TabIndex = 68
        Me.ConfirmPasswordStatusPictureBox.TabStop = False
        Me.ConfirmPasswordStatusPictureBox.Visible = False
        '
        'NewPasswordStatusPictureBox
        '
        Me.NewPasswordStatusPictureBox.Location = New System.Drawing.Point(427, 60)
        Me.NewPasswordStatusPictureBox.Name = "NewPasswordStatusPictureBox"
        Me.NewPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.NewPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NewPasswordStatusPictureBox.TabIndex = 67
        Me.NewPasswordStatusPictureBox.TabStop = False
        Me.NewPasswordStatusPictureBox.Visible = False
        '
        'ConfirmPasswordStatusLabel
        '
        Me.ConfirmPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ConfirmPasswordStatusLabel.Location = New System.Drawing.Point(187, 165)
        Me.ConfirmPasswordStatusLabel.Name = "ConfirmPasswordStatusLabel"
        Me.ConfirmPasswordStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.ConfirmPasswordStatusLabel.TabIndex = 0
        Me.ConfirmPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ConfirmPasswordStatusLabel.Visible = False
        '
        'NewPasswordStatusLabel
        '
        Me.NewPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.NewPasswordStatusLabel.Location = New System.Drawing.Point(187, 95)
        Me.NewPasswordStatusLabel.Name = "NewPasswordStatusLabel"
        Me.NewPasswordStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.NewPasswordStatusLabel.TabIndex = 0
        Me.NewPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NewPasswordStatusLabel.Visible = False
        '
        'ForgotPasswordStatusLabel
        '
        Me.ForgotPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForgotPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ForgotPasswordStatusLabel.Location = New System.Drawing.Point(40, 20)
        Me.ForgotPasswordStatusLabel.Name = "ForgotPasswordStatusLabel"
        Me.ForgotPasswordStatusLabel.Size = New System.Drawing.Size(400, 30)
        Me.ForgotPasswordStatusLabel.TabIndex = 0
        Me.ForgotPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ForgotPasswordStatusLabel.Visible = False
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(270, 200)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 8
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        Me.ClearButton.Visible = False
        '
        'ChangeButton
        '
        Me.ChangeButton.BackColor = System.Drawing.Color.Orange
        Me.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeButton.ForeColor = System.Drawing.Color.White
        Me.ChangeButton.Location = New System.Drawing.Point(82, 200)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(128, 40)
        Me.ChangeButton.TabIndex = 7
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = False
        Me.ChangeButton.Visible = False
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(187, 60)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(240, 29)
        Me.NewPasswordTextBox.TabIndex = 5
        Me.NewPasswordTextBox.Visible = False
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConfirmPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(187, 130)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(240, 29)
        Me.ConfirmPasswordTextBox.TabIndex = 6
        Me.ConfirmPasswordTextBox.Visible = False
        '
        'ConfirmPasswordLabel
        '
        Me.ConfirmPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(25, 130)
        Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.ConfirmPasswordLabel.TabIndex = 0
        Me.ConfirmPasswordLabel.Text = "Confirm Password:"
        Me.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ConfirmPasswordLabel.Visible = False
        '
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordLabel.Location = New System.Drawing.Point(25, 60)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.NewPasswordLabel.TabIndex = 0
        Me.NewPasswordLabel.Text = "New Password:"
        Me.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NewPasswordLabel.Visible = False
        '
        'Next2Button
        '
        Me.Next2Button.BackColor = System.Drawing.Color.DodgerBlue
        Me.Next2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Next2Button.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next2Button.ForeColor = System.Drawing.Color.White
        Me.Next2Button.Location = New System.Drawing.Point(176, 200)
        Me.Next2Button.Name = "Next2Button"
        Me.Next2Button.Size = New System.Drawing.Size(128, 40)
        Me.Next2Button.TabIndex = 4
        Me.Next2Button.Text = "Next"
        Me.Next2Button.UseVisualStyleBackColor = False
        Me.Next2Button.Visible = False
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
        Me.CrossButton.Location = New System.Drawing.Point(439, 9)
        Me.CrossButton.Name = "CrossButton"
        Me.CrossButton.Size = New System.Drawing.Size(32, 32)
        Me.CrossButton.TabIndex = 9
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 320)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.ForgotPasswordPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Forgot Password"
        Me.ForgotPasswordPanel.ResumeLayout(False)
        Me.ForgotPasswordPanel.PerformLayout()
        CType(Me.ConfirmPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ForgotPasswordPanel As Panel
    Friend WithEvents ConfirmPasswordStatusPictureBox As PictureBox
    Friend WithEvents NewPasswordStatusPictureBox As PictureBox
    Friend WithEvents ConfirmPasswordStatusLabel As Label
    Friend WithEvents NewPasswordStatusLabel As Label
    Friend WithEvents ForgotPasswordStatusLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordLabel As Label
    Friend WithEvents NewPasswordLabel As Label
    Friend WithEvents ValidationTimer As Timer
    Friend WithEvents CrossButton As Button
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents UsernameStatusLabel As Label
    Friend WithEvents Next1Button As Button
    Friend WithEvents SecurityQuestionLabel As Label
    Friend WithEvents SecurityAnswerLabel As Label
    Friend WithEvents SecurityAnswerTextBox As TextBox
    Friend WithEvents SecurityAnswerStatusLabel As Label
    Friend WithEvents Next2Button As Button
End Class
