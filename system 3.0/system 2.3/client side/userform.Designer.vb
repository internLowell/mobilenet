<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class userform
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
        Me.nav_prev = New System.Windows.Forms.Button()
        Me.nav_next = New System.Windows.Forms.Button()
        Me.btn_backspace = New System.Windows.Forms.Button()
        Me.npad1 = New System.Windows.Forms.Button()
        Me.npad2 = New System.Windows.Forms.Button()
        Me.npad3 = New System.Windows.Forms.Button()
        Me.npad4 = New System.Windows.Forms.Button()
        Me.npad5 = New System.Windows.Forms.Button()
        Me.npad0 = New System.Windows.Forms.Button()
        Me.npad9 = New System.Windows.Forms.Button()
        Me.npad8 = New System.Windows.Forms.Button()
        Me.npad7 = New System.Windows.Forms.Button()
        Me.npad6 = New System.Windows.Forms.Button()
        Me.numDisplay = New System.Windows.Forms.Label()
        Me.titlebar_bg = New System.Windows.Forms.Panel()
        Me.admin_launch = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.titlebar_dropShadow = New System.Windows.Forms.Panel()
        Me.panel_phase2 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.textbox_container = New System.Windows.Forms.Panel()
        Me.textbox_holder = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_errclose = New System.Windows.Forms.Label()
        Me.lbl_errmsg = New System.Windows.Forms.Label()
        Me.phase2 = New System.Windows.Forms.Timer(Me.components)
        Me.phase1 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_phase1 = New System.Windows.Forms.Panel()
        Me.phase1_container = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_hint = New System.Windows.Forms.Label()
        Me.lbl_paystat = New System.Windows.Forms.Label()
        Me.lbl_amt = New System.Windows.Forms.Label()
        Me.panel_phase3 = New System.Windows.Forms.Panel()
        Me.lbl_response = New System.Windows.Forms.Label()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_resend = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.lbl_ty = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.lbl_step3 = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.lbl_step1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_step2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.close_event = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPortSMS = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialPortArduino = New System.IO.Ports.SerialPort(Me.components)
        Me.titlebar_bg.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_phase2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.textbox_container.SuspendLayout()
        Me.textbox_holder.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.panel_phase1.SuspendLayout()
        Me.phase1_container.SuspendLayout()
        Me.panel_phase3.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'nav_prev
        '
        Me.nav_prev.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nav_prev.FlatAppearance.BorderSize = 0
        Me.nav_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_prev.Font = New System.Drawing.Font("Webdings", 68.0!)
        Me.nav_prev.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.nav_prev.Location = New System.Drawing.Point(3, 84)
        Me.nav_prev.Name = "nav_prev"
        Me.nav_prev.Size = New System.Drawing.Size(78, 94)
        Me.nav_prev.TabIndex = 0
        Me.nav_prev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nav_prev.UseVisualStyleBackColor = True
        Me.nav_prev.Visible = False
        '
        'nav_next
        '
        Me.nav_next.Dock = System.Windows.Forms.DockStyle.Fill
        Me.nav_next.FlatAppearance.BorderSize = 0
        Me.nav_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.nav_next.Font = New System.Drawing.Font("Webdings", 68.0!)
        Me.nav_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.nav_next.Location = New System.Drawing.Point(3, 84)
        Me.nav_next.Name = "nav_next"
        Me.nav_next.Size = New System.Drawing.Size(78, 94)
        Me.nav_next.TabIndex = 1
        Me.nav_next.UseVisualStyleBackColor = True
        Me.nav_next.Visible = False
        '
        'btn_backspace
        '
        Me.btn_backspace.BackColor = System.Drawing.SystemColors.Control
        Me.btn_backspace.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_backspace.FlatAppearance.BorderSize = 0
        Me.btn_backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_backspace.Font = New System.Drawing.Font("Wingdings 3", 42.0!)
        Me.btn_backspace.Location = New System.Drawing.Point(0, 0)
        Me.btn_backspace.Name = "btn_backspace"
        Me.btn_backspace.Size = New System.Drawing.Size(84, 95)
        Me.btn_backspace.TabIndex = 2
        Me.btn_backspace.Text = "f"
        Me.btn_backspace.UseVisualStyleBackColor = False
        Me.btn_backspace.Visible = False
        '
        'npad1
        '
        Me.npad1.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad1.FlatAppearance.BorderSize = 0
        Me.npad1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad1.ForeColor = System.Drawing.Color.White
        Me.npad1.Location = New System.Drawing.Point(110, 34)
        Me.npad1.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad1.Name = "npad1"
        Me.npad1.Size = New System.Drawing.Size(2, 70)
        Me.npad1.TabIndex = 3
        Me.npad1.Text = "1"
        Me.npad1.UseVisualStyleBackColor = False
        '
        'npad2
        '
        Me.npad2.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad2.FlatAppearance.BorderSize = 0
        Me.npad2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad2.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad2.ForeColor = System.Drawing.Color.White
        Me.npad2.Location = New System.Drawing.Point(132, 34)
        Me.npad2.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad2.Name = "npad2"
        Me.npad2.Size = New System.Drawing.Size(2, 70)
        Me.npad2.TabIndex = 4
        Me.npad2.Text = "2"
        Me.npad2.UseVisualStyleBackColor = False
        '
        'npad3
        '
        Me.npad3.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad3.FlatAppearance.BorderSize = 0
        Me.npad3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad3.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad3.ForeColor = System.Drawing.Color.White
        Me.npad3.Location = New System.Drawing.Point(154, 34)
        Me.npad3.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad3.Name = "npad3"
        Me.npad3.Size = New System.Drawing.Size(2, 70)
        Me.npad3.TabIndex = 5
        Me.npad3.Text = "3"
        Me.npad3.UseVisualStyleBackColor = False
        '
        'npad4
        '
        Me.npad4.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad4.FlatAppearance.BorderSize = 0
        Me.npad4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad4.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad4.ForeColor = System.Drawing.Color.White
        Me.npad4.Location = New System.Drawing.Point(176, 34)
        Me.npad4.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad4.Name = "npad4"
        Me.npad4.Size = New System.Drawing.Size(2, 70)
        Me.npad4.TabIndex = 6
        Me.npad4.Text = "4"
        Me.npad4.UseVisualStyleBackColor = False
        '
        'npad5
        '
        Me.npad5.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad5.FlatAppearance.BorderSize = 0
        Me.npad5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad5.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad5.ForeColor = System.Drawing.Color.White
        Me.npad5.Location = New System.Drawing.Point(198, 34)
        Me.npad5.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad5.Name = "npad5"
        Me.npad5.Size = New System.Drawing.Size(2, 70)
        Me.npad5.TabIndex = 7
        Me.npad5.Text = "5"
        Me.npad5.UseVisualStyleBackColor = False
        '
        'npad0
        '
        Me.npad0.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad0.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad0.FlatAppearance.BorderSize = 0
        Me.npad0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad0.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad0.ForeColor = System.Drawing.Color.White
        Me.npad0.Location = New System.Drawing.Point(198, 114)
        Me.npad0.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad0.Name = "npad0"
        Me.npad0.Size = New System.Drawing.Size(2, 70)
        Me.npad0.TabIndex = 12
        Me.npad0.Text = "0"
        Me.npad0.UseVisualStyleBackColor = False
        '
        'npad9
        '
        Me.npad9.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad9.FlatAppearance.BorderSize = 0
        Me.npad9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad9.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad9.ForeColor = System.Drawing.Color.White
        Me.npad9.Location = New System.Drawing.Point(176, 114)
        Me.npad9.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad9.Name = "npad9"
        Me.npad9.Size = New System.Drawing.Size(2, 70)
        Me.npad9.TabIndex = 11
        Me.npad9.Text = "9"
        Me.npad9.UseVisualStyleBackColor = False
        '
        'npad8
        '
        Me.npad8.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad8.FlatAppearance.BorderSize = 0
        Me.npad8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad8.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad8.ForeColor = System.Drawing.Color.White
        Me.npad8.Location = New System.Drawing.Point(154, 114)
        Me.npad8.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad8.Name = "npad8"
        Me.npad8.Size = New System.Drawing.Size(2, 70)
        Me.npad8.TabIndex = 10
        Me.npad8.Text = "8"
        Me.npad8.UseVisualStyleBackColor = False
        '
        'npad7
        '
        Me.npad7.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad7.FlatAppearance.BorderSize = 0
        Me.npad7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad7.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad7.ForeColor = System.Drawing.Color.White
        Me.npad7.Location = New System.Drawing.Point(132, 114)
        Me.npad7.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad7.Name = "npad7"
        Me.npad7.Size = New System.Drawing.Size(2, 70)
        Me.npad7.TabIndex = 9
        Me.npad7.Text = "7"
        Me.npad7.UseVisualStyleBackColor = False
        '
        'npad6
        '
        Me.npad6.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(74, Byte), Integer))
        Me.npad6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.npad6.FlatAppearance.BorderSize = 0
        Me.npad6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.npad6.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.npad6.ForeColor = System.Drawing.Color.White
        Me.npad6.Location = New System.Drawing.Point(110, 114)
        Me.npad6.Margin = New System.Windows.Forms.Padding(10, 5, 10, 5)
        Me.npad6.Name = "npad6"
        Me.npad6.Size = New System.Drawing.Size(2, 70)
        Me.npad6.TabIndex = 8
        Me.npad6.Text = "6"
        Me.npad6.UseVisualStyleBackColor = False
        '
        'numDisplay
        '
        Me.numDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.numDisplay.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold)
        Me.numDisplay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.numDisplay.Location = New System.Drawing.Point(0, 0)
        Me.numDisplay.Name = "numDisplay"
        Me.numDisplay.Size = New System.Drawing.Size(30, 95)
        Me.numDisplay.TabIndex = 23
        Me.numDisplay.Text = "ENTER NUMBER"
        Me.numDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'titlebar_bg
        '
        Me.titlebar_bg.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.titlebar_bg.Controls.Add(Me.admin_launch)
        Me.titlebar_bg.Controls.Add(Me.PictureBox1)
        Me.titlebar_bg.Controls.Add(Me.lbl_title)
        Me.titlebar_bg.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar_bg.Location = New System.Drawing.Point(0, 0)
        Me.titlebar_bg.Name = "titlebar_bg"
        Me.titlebar_bg.Size = New System.Drawing.Size(551, 72)
        Me.titlebar_bg.TabIndex = 24
        '
        'admin_launch
        '
        Me.admin_launch.Dock = System.Windows.Forms.DockStyle.Right
        Me.admin_launch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.admin_launch.FlatAppearance.BorderSize = 0
        Me.admin_launch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.admin_launch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.admin_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.admin_launch.Location = New System.Drawing.Point(523, 0)
        Me.admin_launch.Name = "admin_launch"
        Me.admin_launch.Size = New System.Drawing.Size(28, 72)
        Me.admin_launch.TabIndex = 29
        Me.admin_launch.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(185, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.system_2._3.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 72)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(118, 24)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(27, 30)
        Me.lbl_title.TabIndex = 27
        Me.lbl_title.Text = "[]"
        '
        'titlebar_dropShadow
        '
        Me.titlebar_dropShadow.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.titlebar_dropShadow.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar_dropShadow.Location = New System.Drawing.Point(0, 72)
        Me.titlebar_dropShadow.Name = "titlebar_dropShadow"
        Me.titlebar_dropShadow.Size = New System.Drawing.Size(551, 3)
        Me.titlebar_dropShadow.TabIndex = 25
        '
        'panel_phase2
        '
        Me.panel_phase2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_phase2.Controls.Add(Me.TableLayoutPanel5)
        Me.panel_phase2.Controls.Add(Me.textbox_container)
        Me.panel_phase2.Controls.Add(Me.lbl_errclose)
        Me.panel_phase2.Controls.Add(Me.lbl_errmsg)
        Me.panel_phase2.Location = New System.Drawing.Point(250, 0)
        Me.panel_phase2.Name = "panel_phase2"
        Me.panel_phase2.Padding = New System.Windows.Forms.Padding(10)
        Me.panel_phase2.Size = New System.Drawing.Size(334, 263)
        Me.panel_phase2.TabIndex = 27
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 7
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.npad1, 1, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.npad2, 2, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.npad3, 3, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.npad0, 5, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.npad4, 4, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.npad9, 4, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.npad5, 5, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.npad8, 3, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.npad6, 1, 2)
        Me.TableLayoutPanel5.Controls.Add(Me.npad7, 2, 2)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(10, 162)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 4
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(314, 91)
        Me.TableLayoutPanel5.TabIndex = 30
        '
        'textbox_container
        '
        Me.textbox_container.Controls.Add(Me.textbox_holder)
        Me.textbox_container.Controls.Add(Me.Panel4)
        Me.textbox_container.Dock = System.Windows.Forms.DockStyle.Top
        Me.textbox_container.Location = New System.Drawing.Point(10, 47)
        Me.textbox_container.Name = "textbox_container"
        Me.textbox_container.Padding = New System.Windows.Forms.Padding(100, 10, 100, 10)
        Me.textbox_container.Size = New System.Drawing.Size(314, 115)
        Me.textbox_container.TabIndex = 29
        '
        'textbox_holder
        '
        Me.textbox_holder.Controls.Add(Me.numDisplay)
        Me.textbox_holder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textbox_holder.Location = New System.Drawing.Point(100, 10)
        Me.textbox_holder.Name = "textbox_holder"
        Me.textbox_holder.Size = New System.Drawing.Size(30, 95)
        Me.textbox_holder.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_backspace)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(130, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(84, 95)
        Me.Panel4.TabIndex = 0
        '
        'lbl_errclose
        '
        Me.lbl_errclose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_errclose.AutoSize = True
        Me.lbl_errclose.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_errclose.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_errclose.ForeColor = System.Drawing.Color.Gray
        Me.lbl_errclose.Location = New System.Drawing.Point(286, 19)
        Me.lbl_errclose.Name = "lbl_errclose"
        Me.lbl_errclose.Size = New System.Drawing.Size(18, 19)
        Me.lbl_errclose.TabIndex = 28
        Me.lbl_errclose.Text = "x"
        Me.lbl_errclose.Visible = False
        '
        'lbl_errmsg
        '
        Me.lbl_errmsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_errmsg.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_errmsg.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_errmsg.ForeColor = System.Drawing.Color.Black
        Me.lbl_errmsg.Location = New System.Drawing.Point(10, 10)
        Me.lbl_errmsg.Margin = New System.Windows.Forms.Padding(18, 15, 18, 15)
        Me.lbl_errmsg.Name = "lbl_errmsg"
        Me.lbl_errmsg.Size = New System.Drawing.Size(314, 37)
        Me.lbl_errmsg.TabIndex = 27
        Me.lbl_errmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_errmsg.Visible = False
        '
        'phase2
        '
        Me.phase2.Interval = 5
        '
        'phase1
        '
        Me.phase1.Interval = 5
        '
        'panel_phase1
        '
        Me.panel_phase1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_phase1.Controls.Add(Me.phase1_container)
        Me.panel_phase1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panel_phase1.Location = New System.Drawing.Point(0, 0)
        Me.panel_phase1.Name = "panel_phase1"
        Me.panel_phase1.Size = New System.Drawing.Size(334, 263)
        Me.panel_phase1.TabIndex = 28
        '
        'phase1_container
        '
        Me.phase1_container.ColumnCount = 1
        Me.phase1_container.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.phase1_container.Controls.Add(Me.lbl_hint, 0, 0)
        Me.phase1_container.Controls.Add(Me.lbl_paystat, 0, 1)
        Me.phase1_container.Controls.Add(Me.lbl_amt, 0, 2)
        Me.phase1_container.Dock = System.Windows.Forms.DockStyle.Fill
        Me.phase1_container.Location = New System.Drawing.Point(0, 0)
        Me.phase1_container.Name = "phase1_container"
        Me.phase1_container.RowCount = 3
        Me.phase1_container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.phase1_container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.phase1_container.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.phase1_container.Size = New System.Drawing.Size(334, 263)
        Me.phase1_container.TabIndex = 2
        '
        'lbl_hint
        '
        Me.lbl_hint.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.lbl_hint.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_hint.Location = New System.Drawing.Point(20, 10)
        Me.lbl_hint.Margin = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.lbl_hint.Name = "lbl_hint"
        Me.lbl_hint.Padding = New System.Windows.Forms.Padding(8)
        Me.lbl_hint.Size = New System.Drawing.Size(294, 45)
        Me.lbl_hint.TabIndex = 1
        Me.lbl_hint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_paystat
        '
        Me.lbl_paystat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_paystat.Font = New System.Drawing.Font("Segoe UI", 24.0!)
        Me.lbl_paystat.Location = New System.Drawing.Point(3, 65)
        Me.lbl_paystat.Name = "lbl_paystat"
        Me.lbl_paystat.Size = New System.Drawing.Size(328, 131)
        Me.lbl_paystat.TabIndex = 0
        Me.lbl_paystat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_amt
        '
        Me.lbl_amt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_amt.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_amt.Location = New System.Drawing.Point(3, 196)
        Me.lbl_amt.Name = "lbl_amt"
        Me.lbl_amt.Size = New System.Drawing.Size(328, 67)
        Me.lbl_amt.TabIndex = 2
        Me.lbl_amt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'panel_phase3
        '
        Me.panel_phase3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_phase3.Controls.Add(Me.lbl_response)
        Me.panel_phase3.Controls.Add(Me.TableLayoutPanel6)
        Me.panel_phase3.Controls.Add(Me.lbl_ty)
        Me.panel_phase3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.panel_phase3.Location = New System.Drawing.Point(345, 0)
        Me.panel_phase3.Name = "panel_phase3"
        Me.panel_phase3.Padding = New System.Windows.Forms.Padding(30, 15, 30, 10)
        Me.panel_phase3.Size = New System.Drawing.Size(334, 263)
        Me.panel_phase3.TabIndex = 29
        '
        'lbl_response
        '
        Me.lbl_response.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_response.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.lbl_response.Location = New System.Drawing.Point(30, 72)
        Me.lbl_response.Name = "lbl_response"
        Me.lbl_response.Size = New System.Drawing.Size(274, 29)
        Me.lbl_response.TabIndex = 0
        Me.lbl_response.Text = "..."
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.btn_resend, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.btn_new, 2, 1)
        Me.TableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(30, 101)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 3
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(274, 152)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'btn_resend
        '
        Me.btn_resend.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.btn_resend.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_resend.FlatAppearance.BorderSize = 0
        Me.btn_resend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_resend.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.btn_resend.ForeColor = System.Drawing.Color.White
        Me.btn_resend.Location = New System.Drawing.Point(53, 23)
        Me.btn_resend.Name = "btn_resend"
        Me.btn_resend.Size = New System.Drawing.Size(80, 60)
        Me.btn_resend.TabIndex = 1
        Me.btn_resend.Text = "RESEND CODE"
        Me.btn_resend.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btn_new.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btn_new.FlatAppearance.BorderSize = 0
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.btn_new.ForeColor = System.Drawing.Color.White
        Me.btn_new.Location = New System.Drawing.Point(139, 23)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(80, 60)
        Me.btn_new.TabIndex = 2
        Me.btn_new.Text = "NEW TRANSACTION"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'lbl_ty
        '
        Me.lbl_ty.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_ty.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_ty.Location = New System.Drawing.Point(30, 15)
        Me.lbl_ty.Name = "lbl_ty"
        Me.lbl_ty.Size = New System.Drawing.Size(274, 57)
        Me.lbl_ty.TabIndex = 3
        Me.lbl_ty.Text = "THANK YOU!"
        Me.lbl_ty.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 338)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(551, 51)
        Me.Panel1.TabIndex = 30
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_step3, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar2, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_step1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.ProgressBar1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_step2, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(551, 51)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'lbl_step3
        '
        Me.lbl_step3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_step3.AutoSize = True
        Me.lbl_step3.Font = New System.Drawing.Font("Wingdings 2", 32.0!)
        Me.lbl_step3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lbl_step3.Location = New System.Drawing.Point(497, 3)
        Me.lbl_step3.Name = "lbl_step3"
        Me.lbl_step3.Size = New System.Drawing.Size(51, 45)
        Me.lbl_step3.TabIndex = 25
        Me.lbl_step3.Text = "w"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar2.Location = New System.Drawing.Point(305, 21)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(186, 8)
        Me.ProgressBar2.TabIndex = 27
        '
        'lbl_step1
        '
        Me.lbl_step1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_step1.AutoSize = True
        Me.lbl_step1.Font = New System.Drawing.Font("Wingdings 2", 32.0!)
        Me.lbl_step1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lbl_step1.Location = New System.Drawing.Point(3, 3)
        Me.lbl_step1.Name = "lbl_step1"
        Me.lbl_step1.Size = New System.Drawing.Size(49, 45)
        Me.lbl_step1.TabIndex = 23
        Me.lbl_step1.Text = "u"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(58, 21)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(186, 8)
        Me.ProgressBar1.TabIndex = 26
        '
        'lbl_step2
        '
        Me.lbl_step2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_step2.AutoSize = True
        Me.lbl_step2.Font = New System.Drawing.Font("Wingdings 2", 32.0!)
        Me.lbl_step2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.lbl_step2.Location = New System.Drawing.Point(247, 3)
        Me.lbl_step2.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_step2.Name = "lbl_step2"
        Me.lbl_step2.Size = New System.Drawing.Size(55, 45)
        Me.lbl_step2.TabIndex = 24
        Me.lbl_step2.Text = "v"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.nav_prev, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 75)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(84, 263)
        Me.TableLayoutPanel2.TabIndex = 31
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.nav_next, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(467, 75)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(84, 263)
        Me.TableLayoutPanel3.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.panel_phase3)
        Me.Panel2.Controls.Add(Me.panel_phase2)
        Me.Panel2.Controls.Add(Me.panel_phase1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(84, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(383, 263)
        Me.Panel2.TabIndex = 33
        '
        'close_event
        '
        Me.close_event.Interval = 1000
        '
        'SerialPortArduino
        '
        '
        'userform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(551, 389)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.titlebar_dropShadow)
        Me.Controls.Add(Me.titlebar_bg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "userform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SYSTEM"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.titlebar_bg.ResumeLayout(False)
        Me.titlebar_bg.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_phase2.ResumeLayout(False)
        Me.panel_phase2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.textbox_container.ResumeLayout(False)
        Me.textbox_holder.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.panel_phase1.ResumeLayout(False)
        Me.phase1_container.ResumeLayout(False)
        Me.panel_phase3.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents nav_prev As System.Windows.Forms.Button
    Friend WithEvents nav_next As System.Windows.Forms.Button
    Friend WithEvents btn_backspace As System.Windows.Forms.Button
    Friend WithEvents npad1 As System.Windows.Forms.Button
    Friend WithEvents npad2 As System.Windows.Forms.Button
    Friend WithEvents npad3 As System.Windows.Forms.Button
    Friend WithEvents npad4 As System.Windows.Forms.Button
    Friend WithEvents npad5 As System.Windows.Forms.Button
    Friend WithEvents npad0 As System.Windows.Forms.Button
    Friend WithEvents npad9 As System.Windows.Forms.Button
    Friend WithEvents npad8 As System.Windows.Forms.Button
    Friend WithEvents npad7 As System.Windows.Forms.Button
    Friend WithEvents npad6 As System.Windows.Forms.Button
    Friend WithEvents numDisplay As System.Windows.Forms.Label
    Friend WithEvents titlebar_bg As System.Windows.Forms.Panel
    Friend WithEvents titlebar_dropShadow As System.Windows.Forms.Panel
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents panel_phase2 As System.Windows.Forms.Panel
    Friend WithEvents phase2 As System.Windows.Forms.Timer
    Friend WithEvents phase1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_errmsg As System.Windows.Forms.Label
    Friend WithEvents lbl_errclose As System.Windows.Forms.Label
    Friend WithEvents panel_phase1 As System.Windows.Forms.Panel
    Friend WithEvents lbl_paystat As System.Windows.Forms.Label
    Friend WithEvents lbl_hint As System.Windows.Forms.Label
    Friend WithEvents panel_phase3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_ty As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_resend As System.Windows.Forms.Button
    Friend WithEvents lbl_response As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents lbl_step3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_step1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lbl_step2 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents phase1_container As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents textbox_container As System.Windows.Forms.Panel
    Friend WithEvents textbox_holder As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents TableLayoutPanel6 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents close_event As System.Windows.Forms.Timer
    Friend WithEvents SerialPortSMS As System.IO.Ports.SerialPort
    Friend WithEvents SerialPortArduino As System.IO.Ports.SerialPort
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents admin_launch As System.Windows.Forms.Button
    Friend WithEvents lbl_amt As System.Windows.Forms.Label

End Class
