<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APISend
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
        Me.diflghdflghdfhkg = New System.Windows.Forms.Panel()
        Me.dkslkdfsldkhfdsf = New System.Windows.Forms.Button()
        Me.oifsfhsd = New System.Windows.Forms.TextBox()
        Me.ksjdfhdf = New System.Windows.Forms.TextBox()
        Me.skf = New System.Windows.Forms.TextBox()
        Me.flsdkfdshflsdhf = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.diflghdflghdfhkg.SuspendLayout()
        Me.SuspendLayout()
        '
        'diflghdflghdfhkg
        '
        Me.diflghdflghdfhkg.Controls.Add(Me.dkslkdfsldkhfdsf)
        Me.diflghdflghdfhkg.Controls.Add(Me.oifsfhsd)
        Me.diflghdflghdfhkg.Controls.Add(Me.ksjdfhdf)
        Me.diflghdflghdfhkg.Controls.Add(Me.skf)
        Me.diflghdflghdfhkg.Dock = System.Windows.Forms.DockStyle.Left
        Me.diflghdflghdfhkg.Location = New System.Drawing.Point(0, 0)
        Me.diflghdflghdfhkg.Name = "diflghdflghdfhkg"
        Me.diflghdflghdfhkg.Size = New System.Drawing.Size(200, 131)
        Me.diflghdflghdfhkg.TabIndex = 0
        '
        'dkslkdfsldkhfdsf
        '
        Me.dkslkdfsldkhfdsf.Location = New System.Drawing.Point(104, 218)
        Me.dkslkdfsldkhfdsf.Name = "dkslkdfsldkhfdsf"
        Me.dkslkdfsldkhfdsf.Size = New System.Drawing.Size(75, 23)
        Me.dkslkdfsldkhfdsf.TabIndex = 3
        Me.dkslkdfsldkhfdsf.Text = "send"
        Me.dkslkdfsldkhfdsf.UseVisualStyleBackColor = True
        '
        'oifsfhsd
        '
        Me.oifsfhsd.Location = New System.Drawing.Point(28, 131)
        Me.oifsfhsd.Name = "oifsfhsd"
        Me.oifsfhsd.Size = New System.Drawing.Size(151, 20)
        Me.oifsfhsd.TabIndex = 2
        '
        'ksjdfhdf
        '
        Me.ksjdfhdf.Location = New System.Drawing.Point(28, 79)
        Me.ksjdfhdf.Name = "ksjdfhdf"
        Me.ksjdfhdf.Size = New System.Drawing.Size(151, 20)
        Me.ksjdfhdf.TabIndex = 1
        '
        'skf
        '
        Me.skf.Location = New System.Drawing.Point(25, 36)
        Me.skf.Name = "skf"
        Me.skf.Size = New System.Drawing.Size(154, 20)
        Me.skf.TabIndex = 0
        '
        'flsdkfdshflsdhf
        '
        Me.flsdkfdshflsdhf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.flsdkfdshflsdhf.Location = New System.Drawing.Point(200, 0)
        Me.flsdkfdshflsdhf.MinimumSize = New System.Drawing.Size(20, 20)
        Me.flsdkfdshflsdhf.Name = "flsdkfdshflsdhf"
        Me.flsdkfdshflsdhf.Size = New System.Drawing.Size(586, 131)
        Me.flsdkfdshflsdhf.TabIndex = 1
        Me.flsdkfdshflsdhf.Url = New System.Uri("http://localhost/smstest/index.php", System.UriKind.Absolute)
        '
        'Timer1
        '
        '
        'APISend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(786, 131)
        Me.Controls.Add(Me.flsdkfdshflsdhf)
        Me.Controls.Add(Me.diflghdflghdfhkg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "APISend"
        Me.Opacity = 0.0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "API"
        Me.TopMost = True
        Me.diflghdflghdfhkg.ResumeLayout(False)
        Me.diflghdflghdfhkg.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents diflghdflghdfhkg As System.Windows.Forms.Panel
    Friend WithEvents oifsfhsd As System.Windows.Forms.TextBox
    Friend WithEvents ksjdfhdf As System.Windows.Forms.TextBox
    Friend WithEvents skf As System.Windows.Forms.TextBox
    Friend WithEvents flsdkfdshflsdhf As System.Windows.Forms.WebBrowser
    Friend WithEvents dkslkdfsldkhfdsf As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
