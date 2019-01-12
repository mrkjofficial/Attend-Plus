<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ChangePasswordPanel = New System.Windows.Forms.Panel()
        Me.ConfirmPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.NewPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.ChangePasswordStatusLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.NewPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmPasswordLabel = New System.Windows.Forms.Label()
        Me.NewPasswordLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordLabel = New System.Windows.Forms.Label()
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.ConfirmPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.NewPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.CurrentPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.ChangePasswordPanel.SuspendLayout()
        CType(Me.ConfirmPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NewPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CurrentPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitleLabel.Text = "Change Password"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangePasswordPanel
        '
        Me.ChangePasswordPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangePasswordPanel.Controls.Add(Me.ConfirmPasswordStatusPictureBox)
        Me.ChangePasswordPanel.Controls.Add(Me.NewPasswordStatusPictureBox)
        Me.ChangePasswordPanel.Controls.Add(Me.CurrentPasswordStatusPictureBox)
        Me.ChangePasswordPanel.Controls.Add(Me.ConfirmPasswordStatusLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.NewPasswordStatusLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.CurrentPasswordStatusLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.ChangePasswordStatusLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.ClearButton)
        Me.ChangePasswordPanel.Controls.Add(Me.ChangeButton)
        Me.ChangePasswordPanel.Controls.Add(Me.CurrentPasswordTextBox)
        Me.ChangePasswordPanel.Controls.Add(Me.NewPasswordTextBox)
        Me.ChangePasswordPanel.Controls.Add(Me.ConfirmPasswordTextBox)
        Me.ChangePasswordPanel.Controls.Add(Me.ConfirmPasswordLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.NewPasswordLabel)
        Me.ChangePasswordPanel.Controls.Add(Me.CurrentPasswordLabel)
        Me.ChangePasswordPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangePasswordPanel.Location = New System.Drawing.Point(0, 50)
        Me.ChangePasswordPanel.Name = "ChangePasswordPanel"
        Me.ChangePasswordPanel.Size = New System.Drawing.Size(640, 350)
        Me.ChangePasswordPanel.TabIndex = 4
        '
        'ConfirmPasswordStatusLabel
        '
        Me.ConfirmPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.ConfirmPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ConfirmPasswordStatusLabel.Location = New System.Drawing.Point(295, 249)
        Me.ConfirmPasswordStatusLabel.Name = "ConfirmPasswordStatusLabel"
        Me.ConfirmPasswordStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.ConfirmPasswordStatusLabel.TabIndex = 0
        Me.ConfirmPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NewPasswordStatusLabel
        '
        Me.NewPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.NewPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.NewPasswordStatusLabel.Location = New System.Drawing.Point(295, 179)
        Me.NewPasswordStatusLabel.Name = "NewPasswordStatusLabel"
        Me.NewPasswordStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.NewPasswordStatusLabel.TabIndex = 0
        Me.NewPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurrentPasswordStatusLabel
        '
        Me.CurrentPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.CurrentPasswordStatusLabel.Location = New System.Drawing.Point(295, 109)
        Me.CurrentPasswordStatusLabel.Name = "CurrentPasswordStatusLabel"
        Me.CurrentPasswordStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.CurrentPasswordStatusLabel.TabIndex = 0
        Me.CurrentPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ChangePasswordStatusLabel
        '
        Me.ChangePasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangePasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ChangePasswordStatusLabel.Location = New System.Drawing.Point(70, 25)
        Me.ChangePasswordStatusLabel.Name = "ChangePasswordStatusLabel"
        Me.ChangePasswordStatusLabel.Size = New System.Drawing.Size(500, 28)
        Me.ChangePasswordStatusLabel.TabIndex = 0
        Me.ChangePasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(350, 285)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ChangeButton
        '
        Me.ChangeButton.BackColor = System.Drawing.Color.Orange
        Me.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeButton.ForeColor = System.Drawing.Color.White
        Me.ChangeButton.Location = New System.Drawing.Point(162, 285)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(128, 40)
        Me.ChangeButton.TabIndex = 4
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = False
        '
        'CurrentPasswordTextBox
        '
        Me.CurrentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.CurrentPasswordTextBox.Location = New System.Drawing.Point(295, 75)
        Me.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox"
        Me.CurrentPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.CurrentPasswordTextBox.Size = New System.Drawing.Size(250, 29)
        Me.CurrentPasswordTextBox.TabIndex = 1
        '
        'NewPasswordTextBox
        '
        Me.NewPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.NewPasswordTextBox.Location = New System.Drawing.Point(295, 145)
        Me.NewPasswordTextBox.Name = "NewPasswordTextBox"
        Me.NewPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.NewPasswordTextBox.Size = New System.Drawing.Size(250, 29)
        Me.NewPasswordTextBox.TabIndex = 2
        '
        'ConfirmPasswordTextBox
        '
        Me.ConfirmPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConfirmPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.ConfirmPasswordTextBox.Location = New System.Drawing.Point(295, 215)
        Me.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox"
        Me.ConfirmPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmPasswordTextBox.Size = New System.Drawing.Size(250, 29)
        Me.ConfirmPasswordTextBox.TabIndex = 3
        '
        'ConfirmPasswordLabel
        '
        Me.ConfirmPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPasswordLabel.Location = New System.Drawing.Point(95, 215)
        Me.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel"
        Me.ConfirmPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.ConfirmPasswordLabel.TabIndex = 0
        Me.ConfirmPasswordLabel.Text = "Confirm Password:"
        Me.ConfirmPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'NewPasswordLabel
        '
        Me.NewPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordLabel.Location = New System.Drawing.Point(95, 145)
        Me.NewPasswordLabel.Name = "NewPasswordLabel"
        Me.NewPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.NewPasswordLabel.TabIndex = 0
        Me.NewPasswordLabel.Text = "New Password:"
        Me.NewPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CurrentPasswordLabel
        '
        Me.CurrentPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordLabel.Location = New System.Drawing.Point(95, 75)
        Me.CurrentPasswordLabel.Name = "CurrentPasswordLabel"
        Me.CurrentPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.CurrentPasswordLabel.TabIndex = 0
        Me.CurrentPasswordLabel.Text = "Current Password:"
        Me.CurrentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.CrossButton.Location = New System.Drawing.Point(599, 9)
        Me.CrossButton.Name = "CrossButton"
        Me.CrossButton.Size = New System.Drawing.Size(32, 32)
        Me.CrossButton.TabIndex = 6
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'ConfirmPasswordStatusPictureBox
        '
        Me.ConfirmPasswordStatusPictureBox.Location = New System.Drawing.Point(545, 215)
        Me.ConfirmPasswordStatusPictureBox.Name = "ConfirmPasswordStatusPictureBox"
        Me.ConfirmPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.ConfirmPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ConfirmPasswordStatusPictureBox.TabIndex = 68
        Me.ConfirmPasswordStatusPictureBox.TabStop = False
        '
        'NewPasswordStatusPictureBox
        '
        Me.NewPasswordStatusPictureBox.Location = New System.Drawing.Point(545, 145)
        Me.NewPasswordStatusPictureBox.Name = "NewPasswordStatusPictureBox"
        Me.NewPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.NewPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.NewPasswordStatusPictureBox.TabIndex = 67
        Me.NewPasswordStatusPictureBox.TabStop = False
        '
        'CurrentPasswordStatusPictureBox
        '
        Me.CurrentPasswordStatusPictureBox.Location = New System.Drawing.Point(545, 75)
        Me.CurrentPasswordStatusPictureBox.Name = "CurrentPasswordStatusPictureBox"
        Me.CurrentPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.CurrentPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CurrentPasswordStatusPictureBox.TabIndex = 66
        Me.CurrentPasswordStatusPictureBox.TabStop = False
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.ChangePasswordPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Password"
        Me.ChangePasswordPanel.ResumeLayout(False)
        Me.ChangePasswordPanel.PerformLayout()
        CType(Me.ConfirmPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NewPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CurrentPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ChangePasswordPanel As Panel
    Friend WithEvents ChangePasswordStatusLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents NewPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordTextBox As TextBox
    Friend WithEvents ConfirmPasswordLabel As Label
    Friend WithEvents NewPasswordLabel As Label
    Friend WithEvents CurrentPasswordLabel As Label
    Friend WithEvents CrossButton As Button
    Friend WithEvents ValidationTimer As Timer
    Friend WithEvents CurrentPasswordStatusLabel As Label
    Friend WithEvents ConfirmPasswordStatusLabel As Label
    Friend WithEvents NewPasswordStatusLabel As Label
    Friend WithEvents ConfirmPasswordStatusPictureBox As PictureBox
    Friend WithEvents NewPasswordStatusPictureBox As PictureBox
    Friend WithEvents CurrentPasswordStatusPictureBox As PictureBox
End Class
