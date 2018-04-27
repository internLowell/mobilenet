<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.SystemTitle = New System.Windows.Forms.Label()
        Me.Version = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ApplicationTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ApplicationTitle.Location = New System.Drawing.Point(35, 123)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(426, 27)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Application Title"
        '
        'SystemTitle
        '
        Me.SystemTitle.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.SystemTitle.ForeColor = System.Drawing.Color.White
        Me.SystemTitle.Location = New System.Drawing.Point(34, 53)
        Me.SystemTitle.Name = "SystemTitle"
        Me.SystemTitle.Size = New System.Drawing.Size(427, 67)
        Me.SystemTitle.TabIndex = 2
        Me.SystemTitle.Text = "System Title"
        Me.SystemTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Version
        '
        Me.Version.BackColor = System.Drawing.Color.White
        Me.Version.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Version.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Version.Location = New System.Drawing.Point(0, 267)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(496, 36)
        Me.Version.TabIndex = 3
        Me.Version.Text = "Version {0}.{1:00}"
        Me.Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(215, Byte), Integer), CType(CType(92, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(496, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.Version)
        Me.Controls.Add(Me.SystemTitle)
        Me.Controls.Add(Me.ApplicationTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Splash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SystemTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label

End Class
