<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeSecurityQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeSecurityQuestion))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ChangeSecurityQuestionPanel = New System.Windows.Forms.Panel()
        Me.SecurityQuestionComboBox = New System.Windows.Forms.ComboBox()
        Me.CurrentPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.SecurityAnswerStatusLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionStatusLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.ChangeSecurityQuestionStatusLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecurityAnswerLabel = New System.Windows.Forms.Label()
        Me.SecurityQuestionLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordLabel = New System.Windows.Forms.Label()
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeSecurityQuestionPanel.SuspendLayout()
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
        Me.TitleLabel.Text = "Change Security Question"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ChangeSecurityQuestionPanel
        '
        Me.ChangeSecurityQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityQuestionComboBox)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.CurrentPasswordStatusPictureBox)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityAnswerStatusLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityQuestionStatusLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.CurrentPasswordStatusLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.ChangeSecurityQuestionStatusLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.ClearButton)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.ChangeButton)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.CurrentPasswordTextBox)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityAnswerTextBox)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityAnswerLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.SecurityQuestionLabel)
        Me.ChangeSecurityQuestionPanel.Controls.Add(Me.CurrentPasswordLabel)
        Me.ChangeSecurityQuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeSecurityQuestionPanel.Location = New System.Drawing.Point(0, 50)
        Me.ChangeSecurityQuestionPanel.Name = "ChangeSecurityQuestionPanel"
        Me.ChangeSecurityQuestionPanel.Size = New System.Drawing.Size(640, 350)
        Me.ChangeSecurityQuestionPanel.TabIndex = 0
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
        Me.SecurityQuestionComboBox.Location = New System.Drawing.Point(295, 145)
        Me.SecurityQuestionComboBox.Name = "SecurityQuestionComboBox"
        Me.SecurityQuestionComboBox.Size = New System.Drawing.Size(250, 29)
        Me.SecurityQuestionComboBox.Sorted = True
        Me.SecurityQuestionComboBox.TabIndex = 2
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
        'SecurityAnswerStatusLabel
        '
        Me.SecurityAnswerStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.SecurityAnswerStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.SecurityAnswerStatusLabel.Location = New System.Drawing.Point(295, 249)
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
        Me.SecurityQuestionStatusLabel.Location = New System.Drawing.Point(295, 179)
        Me.SecurityQuestionStatusLabel.Name = "SecurityQuestionStatusLabel"
        Me.SecurityQuestionStatusLabel.Size = New System.Drawing.Size(250, 30)
        Me.SecurityQuestionStatusLabel.TabIndex = 0
        Me.SecurityQuestionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'ChangeSecurityQuestionStatusLabel
        '
        Me.ChangeSecurityQuestionStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeSecurityQuestionStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ChangeSecurityQuestionStatusLabel.Location = New System.Drawing.Point(70, 25)
        Me.ChangeSecurityQuestionStatusLabel.Name = "ChangeSecurityQuestionStatusLabel"
        Me.ChangeSecurityQuestionStatusLabel.Size = New System.Drawing.Size(500, 28)
        Me.ChangeSecurityQuestionStatusLabel.TabIndex = 0
        Me.ChangeSecurityQuestionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'SecurityAnswerTextBox
        '
        Me.SecurityAnswerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SecurityAnswerTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.SecurityAnswerTextBox.Location = New System.Drawing.Point(295, 215)
        Me.SecurityAnswerTextBox.Name = "SecurityAnswerTextBox"
        Me.SecurityAnswerTextBox.Size = New System.Drawing.Size(250, 29)
        Me.SecurityAnswerTextBox.TabIndex = 3
        '
        'SecurityAnswerLabel
        '
        Me.SecurityAnswerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityAnswerLabel.Location = New System.Drawing.Point(95, 215)
        Me.SecurityAnswerLabel.Name = "SecurityAnswerLabel"
        Me.SecurityAnswerLabel.Size = New System.Drawing.Size(150, 30)
        Me.SecurityAnswerLabel.TabIndex = 0
        Me.SecurityAnswerLabel.Text = "Security Answer:"
        Me.SecurityAnswerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SecurityQuestionLabel
        '
        Me.SecurityQuestionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecurityQuestionLabel.Location = New System.Drawing.Point(95, 145)
        Me.SecurityQuestionLabel.Name = "SecurityQuestionLabel"
        Me.SecurityQuestionLabel.Size = New System.Drawing.Size(150, 30)
        Me.SecurityQuestionLabel.TabIndex = 0
        Me.SecurityQuestionLabel.Text = "Security Question:"
        Me.SecurityQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'ValidationTimer
        '
        Me.ValidationTimer.Interval = 1000
        '
        'ChangeSecurityQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 400)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.ChangeSecurityQuestionPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangeSecurityQuestion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Security Question"
        Me.ChangeSecurityQuestionPanel.ResumeLayout(False)
        Me.ChangeSecurityQuestionPanel.PerformLayout()
        CType(Me.CurrentPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ChangeSecurityQuestionPanel As Panel
    Friend WithEvents CurrentPasswordStatusPictureBox As PictureBox
    Friend WithEvents SecurityAnswerStatusLabel As Label
    Friend WithEvents SecurityQuestionStatusLabel As Label
    Friend WithEvents CurrentPasswordStatusLabel As Label
    Friend WithEvents ChangeSecurityQuestionStatusLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents SecurityAnswerTextBox As TextBox
    Friend WithEvents SecurityAnswerLabel As Label
    Friend WithEvents SecurityQuestionLabel As Label
    Friend WithEvents CurrentPasswordLabel As Label
    Friend WithEvents SecurityQuestionComboBox As ComboBox
    Friend WithEvents CrossButton As Button
    Friend WithEvents ValidationTimer As Timer
End Class
