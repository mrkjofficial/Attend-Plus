<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Info))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.ErrorBoxPanel = New System.Windows.Forms.Panel()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.CrossButton = New System.Windows.Forms.Button()
        Me.ErrorBoxPanel.SuspendLayout()
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
        Me.TitleLabel.Size = New System.Drawing.Size(320, 50)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "Info"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ErrorBoxPanel
        '
        Me.ErrorBoxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrorBoxPanel.Controls.Add(Me.StatusLabel)
        Me.ErrorBoxPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ErrorBoxPanel.Location = New System.Drawing.Point(0, 50)
        Me.ErrorBoxPanel.Name = "ErrorBoxPanel"
        Me.ErrorBoxPanel.Size = New System.Drawing.Size(320, 190)
        Me.ErrorBoxPanel.TabIndex = 0
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Location = New System.Drawing.Point(20, 20)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(280, 150)
        Me.StatusLabel.TabIndex = 0
        Me.StatusLabel.Text = "Default Login Credentials:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Username: admin" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Password: 1234" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "* Note: Please cha" &
    "nge your password after first login also add a Security Question for Password re" &
    "covery options."
        Me.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CrossButton
        '
        Me.CrossButton.BackColor = System.Drawing.Color.Red
        Me.CrossButton.BackgroundImage = Global.AMS.My.Resources.Resources.Close
        Me.CrossButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CrossButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CrossButton.FlatAppearance.BorderSize = 2
        Me.CrossButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CrossButton.Location = New System.Drawing.Point(279, 9)
        Me.CrossButton.Name = "CrossButton"
        Me.CrossButton.Size = New System.Drawing.Size(32, 32)
        Me.CrossButton.TabIndex = 1
        Me.CrossButton.UseVisualStyleBackColor = False
        '
        'Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(320, 240)
        Me.Controls.Add(Me.CrossButton)
        Me.Controls.Add(Me.ErrorBoxPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Info"
        Me.ErrorBoxPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents ErrorBoxPanel As Panel
    Friend WithEvents StatusLabel As Label
    Friend WithEvents CrossButton As Button
End Class
