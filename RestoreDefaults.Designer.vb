<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RestoreDefaults
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RestoreDefaults))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.RestoreDefaultsPanel = New System.Windows.Forms.Panel()
        Me.RestoreDefaultsStatusLabel = New System.Windows.Forms.Label()
        Me.NoButton = New System.Windows.Forms.Button()
        Me.YesButton = New System.Windows.Forms.Button()
        Me.RestoreDefaultsPanel.SuspendLayout()
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
        Me.TitleLabel.Text = "Restore Defaults"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RestoreDefaultsPanel
        '
        Me.RestoreDefaultsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RestoreDefaultsPanel.Controls.Add(Me.RestoreDefaultsStatusLabel)
        Me.RestoreDefaultsPanel.Controls.Add(Me.NoButton)
        Me.RestoreDefaultsPanel.Controls.Add(Me.YesButton)
        Me.RestoreDefaultsPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RestoreDefaultsPanel.Location = New System.Drawing.Point(0, 50)
        Me.RestoreDefaultsPanel.Name = "RestoreDefaultsPanel"
        Me.RestoreDefaultsPanel.Size = New System.Drawing.Size(480, 270)
        Me.RestoreDefaultsPanel.TabIndex = 0
        '
        'RestoreDefaultsStatusLabel
        '
        Me.RestoreDefaultsStatusLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RestoreDefaultsStatusLabel.ForeColor = System.Drawing.Color.DarkBlue
        Me.RestoreDefaultsStatusLabel.Location = New System.Drawing.Point(40, 40)
        Me.RestoreDefaultsStatusLabel.Name = "RestoreDefaultsStatusLabel"
        Me.RestoreDefaultsStatusLabel.Size = New System.Drawing.Size(400, 60)
        Me.RestoreDefaultsStatusLabel.TabIndex = 0
        Me.RestoreDefaultsStatusLabel.Text = "Are you sure, You want to restore the application to its default state?"
        Me.RestoreDefaultsStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NoButton
        '
        Me.NoButton.BackColor = System.Drawing.Color.Green
        Me.NoButton.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.NoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NoButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoButton.ForeColor = System.Drawing.Color.White
        Me.NoButton.Location = New System.Drawing.Point(270, 180)
        Me.NoButton.Name = "NoButton"
        Me.NoButton.Size = New System.Drawing.Size(128, 40)
        Me.NoButton.TabIndex = 2
        Me.NoButton.Text = "No"
        Me.NoButton.UseVisualStyleBackColor = False
        '
        'YesButton
        '
        Me.YesButton.BackColor = System.Drawing.Color.Red
        Me.YesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.YesButton.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.YesButton.ForeColor = System.Drawing.Color.White
        Me.YesButton.Location = New System.Drawing.Point(82, 180)
        Me.YesButton.Name = "YesButton"
        Me.YesButton.Size = New System.Drawing.Size(128, 40)
        Me.YesButton.TabIndex = 1
        Me.YesButton.Text = "Yes"
        Me.YesButton.UseVisualStyleBackColor = False
        '
        'RestoreDefaults
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(480, 320)
        Me.Controls.Add(Me.RestoreDefaultsPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "RestoreDefaults"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Restore Defaults"
        Me.RestoreDefaultsPanel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents RestoreDefaultsPanel As Panel
    Friend WithEvents NoButton As Button
    Friend WithEvents YesButton As Button
    Friend WithEvents RestoreDefaultsStatusLabel As Label
End Class
