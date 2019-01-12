<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeMobileNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeMobileNo))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.ChangeMobileNoPanel = New System.Windows.Forms.Panel()
        Me.CurrentPasswordStatusPictureBox = New System.Windows.Forms.PictureBox()
        Me.CurrentPasswordStatusLabel = New System.Windows.Forms.Label()
        Me.MobileNoStatusLabel = New System.Windows.Forms.Label()
        Me.CurrentPasswordTextBox = New System.Windows.Forms.TextBox()
        Me.MobileNoTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentPasswordLabel = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ChangeButton = New System.Windows.Forms.Button()
        Me.MobileNoLabel = New System.Windows.Forms.Label()
        Me.ChangeMobileNoStatusLabel = New System.Windows.Forms.Label()
        Me.ValidationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ChangeMobileNoPanel.SuspendLayout()
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
        Me.TitleLabel.Size = New System.Drawing.Size(480, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Change Mobile No."
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.CrossButton.TabIndex = 5
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'ChangeMobileNoPanel
        '
        Me.ChangeMobileNoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ChangeMobileNoPanel.Controls.Add(Me.CurrentPasswordStatusPictureBox)
        Me.ChangeMobileNoPanel.Controls.Add(Me.CurrentPasswordStatusLabel)
        Me.ChangeMobileNoPanel.Controls.Add(Me.MobileNoStatusLabel)
        Me.ChangeMobileNoPanel.Controls.Add(Me.CurrentPasswordTextBox)
        Me.ChangeMobileNoPanel.Controls.Add(Me.MobileNoTextBox)
        Me.ChangeMobileNoPanel.Controls.Add(Me.CurrentPasswordLabel)
        Me.ChangeMobileNoPanel.Controls.Add(Me.ClearButton)
        Me.ChangeMobileNoPanel.Controls.Add(Me.ChangeButton)
        Me.ChangeMobileNoPanel.Controls.Add(Me.MobileNoLabel)
        Me.ChangeMobileNoPanel.Controls.Add(Me.ChangeMobileNoStatusLabel)
        Me.ChangeMobileNoPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ChangeMobileNoPanel.Location = New System.Drawing.Point(0, 50)
        Me.ChangeMobileNoPanel.Name = "ChangeMobileNoPanel"
        Me.ChangeMobileNoPanel.Size = New System.Drawing.Size(480, 270)
        Me.ChangeMobileNoPanel.TabIndex = 0
        '
        'CurrentPasswordStatusPictureBox
        '
        Me.CurrentPasswordStatusPictureBox.Location = New System.Drawing.Point(427, 60)
        Me.CurrentPasswordStatusPictureBox.Name = "CurrentPasswordStatusPictureBox"
        Me.CurrentPasswordStatusPictureBox.Size = New System.Drawing.Size(28, 28)
        Me.CurrentPasswordStatusPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.CurrentPasswordStatusPictureBox.TabIndex = 68
        Me.CurrentPasswordStatusPictureBox.TabStop = False
        '
        'CurrentPasswordStatusLabel
        '
        Me.CurrentPasswordStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.CurrentPasswordStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.CurrentPasswordStatusLabel.Location = New System.Drawing.Point(187, 95)
        Me.CurrentPasswordStatusLabel.Name = "CurrentPasswordStatusLabel"
        Me.CurrentPasswordStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.CurrentPasswordStatusLabel.TabIndex = 0
        Me.CurrentPasswordStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MobileNoStatusLabel
        '
        Me.MobileNoStatusLabel.BackColor = System.Drawing.Color.Transparent
        Me.MobileNoStatusLabel.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.MobileNoStatusLabel.Location = New System.Drawing.Point(187, 165)
        Me.MobileNoStatusLabel.Name = "MobileNoStatusLabel"
        Me.MobileNoStatusLabel.Size = New System.Drawing.Size(240, 30)
        Me.MobileNoStatusLabel.TabIndex = 0
        Me.MobileNoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CurrentPasswordTextBox
        '
        Me.CurrentPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CurrentPasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.CurrentPasswordTextBox.Location = New System.Drawing.Point(187, 60)
        Me.CurrentPasswordTextBox.Name = "CurrentPasswordTextBox"
        Me.CurrentPasswordTextBox.Size = New System.Drawing.Size(240, 29)
        Me.CurrentPasswordTextBox.TabIndex = 1
        '
        'MobileNoTextBox
        '
        Me.MobileNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MobileNoTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoTextBox.ForeColor = System.Drawing.Color.DarkBlue
        Me.MobileNoTextBox.Location = New System.Drawing.Point(187, 130)
        Me.MobileNoTextBox.Name = "MobileNoTextBox"
        Me.MobileNoTextBox.Size = New System.Drawing.Size(240, 29)
        Me.MobileNoTextBox.TabIndex = 2
        '
        'CurrentPasswordLabel
        '
        Me.CurrentPasswordLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPasswordLabel.Location = New System.Drawing.Point(25, 60)
        Me.CurrentPasswordLabel.Name = "CurrentPasswordLabel"
        Me.CurrentPasswordLabel.Size = New System.Drawing.Size(150, 30)
        Me.CurrentPasswordLabel.TabIndex = 0
        Me.CurrentPasswordLabel.Text = "Current Password:"
        Me.CurrentPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ClearButton
        '
        Me.ClearButton.BackColor = System.Drawing.Color.Red
        Me.ClearButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.ForeColor = System.Drawing.Color.White
        Me.ClearButton.Location = New System.Drawing.Point(263, 198)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(128, 40)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = False
        '
        'ChangeButton
        '
        Me.ChangeButton.BackColor = System.Drawing.Color.Orange
        Me.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangeButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeButton.ForeColor = System.Drawing.Color.White
        Me.ChangeButton.Location = New System.Drawing.Point(75, 198)
        Me.ChangeButton.Name = "ChangeButton"
        Me.ChangeButton.Size = New System.Drawing.Size(128, 40)
        Me.ChangeButton.TabIndex = 3
        Me.ChangeButton.Text = "Change"
        Me.ChangeButton.UseVisualStyleBackColor = False
        '
        'MobileNoLabel
        '
        Me.MobileNoLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobileNoLabel.Location = New System.Drawing.Point(25, 130)
        Me.MobileNoLabel.Name = "MobileNoLabel"
        Me.MobileNoLabel.Size = New System.Drawing.Size(150, 30)
        Me.MobileNoLabel.TabIndex = 0
        Me.MobileNoLabel.Text = "Mobile No.:"
        Me.MobileNoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ChangeMobileNoStatusLabel
        '
        Me.ChangeMobileNoStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangeMobileNoStatusLabel.ForeColor = System.Drawing.Color.Red
        Me.ChangeMobileNoStatusLabel.Location = New System.Drawing.Point(40, 20)
        Me.ChangeMobileNoStatusLabel.Name = "ChangeMobileNoStatusLabel"
        Me.ChangeMobileNoStatusLabel.Size = New System.Drawing.Size(400, 30)
        Me.ChangeMobileNoStatusLabel.TabIndex = 0
        Me.ChangeMobileNoStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValidationTimer
        '
        Me.ValidationTimer.Interval = 1000
        '
        'ChangeMobileNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 320)
        Me.Controls.Add(Me.ChangeMobileNoPanel)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangeMobileNo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Change Mobile No."
        Me.ChangeMobileNoPanel.ResumeLayout(False)
        Me.ChangeMobileNoPanel.PerformLayout()
        CType(Me.CurrentPasswordStatusPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents CrossButton As Button
    Friend WithEvents ChangeMobileNoPanel As Panel
    Friend WithEvents ChangeMobileNoStatusLabel As Label
    Friend WithEvents MobileNoLabel As Label
    Friend WithEvents CurrentPasswordLabel As Label
    Friend WithEvents ClearButton As Button
    Friend WithEvents ChangeButton As Button
    Friend WithEvents CurrentPasswordTextBox As TextBox
    Friend WithEvents MobileNoTextBox As TextBox
    Friend WithEvents MobileNoStatusLabel As Label
    Friend WithEvents CurrentPasswordStatusLabel As Label
    Friend WithEvents CurrentPasswordStatusPictureBox As PictureBox
    Friend WithEvents ValidationTimer As Timer
End Class
