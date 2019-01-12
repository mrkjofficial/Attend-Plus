<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutAttend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutAttend))
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.AboutAttendPanel = New System.Windows.Forms.Panel()
        Me.AboutInfoLabel = New System.Windows.Forms.Label()
        Me.AboutDesignerLabel = New System.Windows.Forms.Label()
        Me.AboutVersionLabel = New System.Windows.Forms.Label()
        Me.AboutTitleLabel = New System.Windows.Forms.Label()
        Me.AboutLogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.AboutAttendPanel.SuspendLayout()
        CType(Me.AboutLogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TitleLabel.TabIndex = 2
        Me.TitleLabel.Text = "About Attend+"
        Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutAttendPanel
        '
        Me.AboutAttendPanel.BackColor = System.Drawing.Color.Transparent
        Me.AboutAttendPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutAttendPanel.Controls.Add(Me.AboutInfoLabel)
        Me.AboutAttendPanel.Controls.Add(Me.AboutDesignerLabel)
        Me.AboutAttendPanel.Controls.Add(Me.AboutVersionLabel)
        Me.AboutAttendPanel.Controls.Add(Me.AboutTitleLabel)
        Me.AboutAttendPanel.Controls.Add(Me.AboutLogoPictureBox)
        Me.AboutAttendPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AboutAttendPanel.Location = New System.Drawing.Point(0, 50)
        Me.AboutAttendPanel.Name = "AboutAttendPanel"
        Me.AboutAttendPanel.Size = New System.Drawing.Size(640, 430)
        Me.AboutAttendPanel.TabIndex = 67
        '
        'AboutInfoLabel
        '
        Me.AboutInfoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutInfoLabel.BackColor = System.Drawing.Color.Transparent
        Me.AboutInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutInfoLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutInfoLabel.ForeColor = System.Drawing.Color.DimGray
        Me.AboutInfoLabel.Location = New System.Drawing.Point(130, 230)
        Me.AboutInfoLabel.Name = "AboutInfoLabel"
        Me.AboutInfoLabel.Size = New System.Drawing.Size(380, 100)
        Me.AboutInfoLabel.TabIndex = 71
        Me.AboutInfoLabel.Text = "Attend+ is designed for storing, managing, analyzing student's attendence eficien" &
    "tly and effectively without any errors."
        Me.AboutInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AboutDesignerLabel
        '
        Me.AboutDesignerLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutDesignerLabel.BackColor = System.Drawing.Color.Transparent
        Me.AboutDesignerLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutDesignerLabel.Location = New System.Drawing.Point(170, 330)
        Me.AboutDesignerLabel.Name = "AboutDesignerLabel"
        Me.AboutDesignerLabel.Size = New System.Drawing.Size(300, 50)
        Me.AboutDesignerLabel.TabIndex = 70
        Me.AboutDesignerLabel.Text = "Designed by TechnoCoders"
        Me.AboutDesignerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutVersionLabel
        '
        Me.AboutVersionLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutVersionLabel.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutVersionLabel.Location = New System.Drawing.Point(170, 180)
        Me.AboutVersionLabel.Name = "AboutVersionLabel"
        Me.AboutVersionLabel.Size = New System.Drawing.Size(300, 50)
        Me.AboutVersionLabel.TabIndex = 69
        Me.AboutVersionLabel.Text = "Version: 1.0"
        Me.AboutVersionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutTitleLabel
        '
        Me.AboutTitleLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutTitleLabel.Font = New System.Drawing.Font("Segoe Script", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutTitleLabel.Location = New System.Drawing.Point(200, 80)
        Me.AboutTitleLabel.Name = "AboutTitleLabel"
        Me.AboutTitleLabel.Size = New System.Drawing.Size(340, 100)
        Me.AboutTitleLabel.TabIndex = 68
        Me.AboutTitleLabel.Text = "Attend+"
        Me.AboutTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutLogoPictureBox
        '
        Me.AboutLogoPictureBox.BackColor = System.Drawing.Color.Transparent
        Me.AboutLogoPictureBox.Image = Global.AMS.My.Resources.Resources.Logo_Icon
        Me.AboutLogoPictureBox.Location = New System.Drawing.Point(100, 80)
        Me.AboutLogoPictureBox.Name = "AboutLogoPictureBox"
        Me.AboutLogoPictureBox.Size = New System.Drawing.Size(100, 100)
        Me.AboutLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AboutLogoPictureBox.TabIndex = 67
        Me.AboutLogoPictureBox.TabStop = False
        '
        'AboutAttend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(640, 480)
        Me.Controls.Add(Me.AboutAttendPanel)
        Me.Controls.Add(Me.TitleLabel)
        Me.ForeColor = System.Drawing.Color.DarkBlue
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AboutAttend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About Attend+"
        Me.AboutAttendPanel.ResumeLayout(False)
        CType(Me.AboutLogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents AboutAttendPanel As Panel
    Friend WithEvents AboutInfoLabel As Label
    Friend WithEvents AboutDesignerLabel As Label
    Friend WithEvents AboutVersionLabel As Label
    Friend WithEvents AboutTitleLabel As Label
    Friend WithEvents AboutLogoPictureBox As PictureBox
End Class
