<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport50F
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExport50F))
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Export53tb = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.brows_b = New DevComponents.DotNetBar.ButtonX()
        Me.export_path_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.d_update_ch = New System.Windows.Forms.RadioButton()
        Me.date_serv_ch = New System.Windows.Forms.RadioButton()
        Me.enddate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.begindate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.allpp_ch = New System.Windows.Forms.CheckBox()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.person_ch = New System.Windows.Forms.CheckBox()
        Me.chronic_ch = New System.Windows.Forms.CheckBox()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.epi_ch = New System.Windows.Forms.CheckBox()
        Me.LabelX9 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX7 = New DevComponents.DotNetBar.LabelX()
        Me.anc_ch = New System.Windows.Forms.CheckBox()
        Me.specialpp_ch = New System.Windows.Forms.CheckBox()
        Me.reportData_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.table_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1191, 35)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 12
        Me.PanelEx5.Text = "  ส่งออกแฟ้มตามโครงสร้าง 53 แฟ้ม แบบเลือกเงื่อนไข"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.GroupBox2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 35)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1191, 518)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Export53tb)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Controls.Add(Me.enddate_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.begindate_tf)
        Me.GroupBox1.Location = New System.Drawing.Point(2, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1186, 50)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Export53tb
        '
        Me.Export53tb.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.Export53tb.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Export53tb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.Export53tb.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Export53tb.Location = New System.Drawing.Point(1105, 11)
        Me.Export53tb.Name = "Export53tb"
        Me.Export53tb.Size = New System.Drawing.Size(75, 33)
        Me.Export53tb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.Export53tb.TabIndex = 26
        Me.Export53tb.Text = "ส่งออกข้อมูล"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.brows_b)
        Me.Panel2.Controls.Add(Me.export_path_tf)
        Me.Panel2.Controls.Add(Me.LabelX4)
        Me.Panel2.Location = New System.Drawing.Point(612, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(441, 36)
        Me.Panel2.TabIndex = 2
        '
        'brows_b
        '
        Me.brows_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.brows_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.brows_b.Font = New System.Drawing.Font("TH SarabunPSK", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.brows_b.Location = New System.Drawing.Point(358, 3)
        Me.brows_b.Name = "brows_b"
        Me.brows_b.Size = New System.Drawing.Size(76, 28)
        Me.brows_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.brows_b.TabIndex = 31
        Me.brows_b.Text = "BROWS..."
        '
        'export_path_tf
        '
        Me.export_path_tf.BackColor = System.Drawing.SystemColors.ControlLightLight
        '
        '
        '
        Me.export_path_tf.Border.Class = "TextBoxBorder"
        Me.export_path_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.export_path_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.export_path_tf.Location = New System.Drawing.Point(49, 2)
        Me.export_path_tf.Name = "export_path_tf"
        Me.export_path_tf.ReadOnly = True
        Me.export_path_tf.Size = New System.Drawing.Size(305, 30)
        Me.export_path_tf.TabIndex = 30
        Me.export_path_tf.Text = "C:\temp"
        '
        'LabelX4
        '
        Me.LabelX4.AutoSize = True
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX4.Location = New System.Drawing.Point(3, 2)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(40, 29)
        Me.LabelX4.TabIndex = 29
        Me.LabelX4.Text = "PATH :"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LabelX3)
        Me.Panel1.Controls.Add(Me.d_update_ch)
        Me.Panel1.Controls.Add(Me.date_serv_ch)
        Me.Panel1.Location = New System.Drawing.Point(340, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(269, 36)
        Me.Panel1.TabIndex = 1
        '
        'LabelX3
        '
        Me.LabelX3.AutoSize = True
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX3.Location = New System.Drawing.Point(6, 3)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(66, 29)
        Me.LabelX3.TabIndex = 26
        Me.LabelX3.Text = "ส่งออกตาม :"
        '
        'd_update_ch
        '
        Me.d_update_ch.AutoSize = True
        Me.d_update_ch.Checked = True
        Me.d_update_ch.Location = New System.Drawing.Point(78, 8)
        Me.d_update_ch.Name = "d_update_ch"
        Me.d_update_ch.Size = New System.Drawing.Size(83, 17)
        Me.d_update_ch.TabIndex = 27
        Me.d_update_ch.TabStop = True
        Me.d_update_ch.Text = "D_UPDATE"
        Me.d_update_ch.UseVisualStyleBackColor = True
        '
        'date_serv_ch
        '
        Me.date_serv_ch.AutoSize = True
        Me.date_serv_ch.Location = New System.Drawing.Point(173, 8)
        Me.date_serv_ch.Name = "date_serv_ch"
        Me.date_serv_ch.Size = New System.Drawing.Size(89, 17)
        Me.date_serv_ch.TabIndex = 28
        Me.date_serv_ch.Text = "DATE_SERV"
        Me.date_serv_ch.UseVisualStyleBackColor = True
        '
        'enddate_tf
        '
        '
        '
        '
        Me.enddate_tf.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.enddate_tf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.enddate_tf.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.enddate_tf.ButtonDropDown.Visible = True
        Me.enddate_tf.CustomFormat = "dd/MM/yyyy"
        Me.enddate_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.enddate_tf.IsPopupCalendarOpen = False
        Me.enddate_tf.Location = New System.Drawing.Point(214, 13)
        '
        '
        '
        Me.enddate_tf.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.enddate_tf.MonthCalendar.BackgroundStyle.Class = ""
        Me.enddate_tf.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.enddate_tf.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.enddate_tf.MonthCalendar.DisplayMonth = New Date(2017, 10, 1, 0, 0, 0, 0)
        Me.enddate_tf.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.enddate_tf.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.enddate_tf.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.enddate_tf.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.enddate_tf.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.enddate_tf.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.enddate_tf.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.enddate_tf.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.enddate_tf.MonthCalendar.TodayButtonVisible = True
        Me.enddate_tf.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.enddate_tf.Name = "enddate_tf"
        Me.enddate_tf.Size = New System.Drawing.Size(120, 30)
        Me.enddate_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.enddate_tf.TabIndex = 25
        Me.enddate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX2.Location = New System.Drawing.Point(193, 14)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(15, 29)
        Me.LabelX2.TabIndex = 24
        Me.LabelX2.Text = "ถึง"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX1.Location = New System.Drawing.Point(10, 14)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(51, 29)
        Me.LabelX1.TabIndex = 23
        Me.LabelX1.Text = "ช่วงวันที่ :"
        '
        'begindate_tf
        '
        '
        '
        '
        Me.begindate_tf.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.begindate_tf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.begindate_tf.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.begindate_tf.ButtonDropDown.Visible = True
        Me.begindate_tf.CustomFormat = "dd/MM/yyyy"
        Me.begindate_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.begindate_tf.IsPopupCalendarOpen = False
        Me.begindate_tf.Location = New System.Drawing.Point(67, 13)
        '
        '
        '
        Me.begindate_tf.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.begindate_tf.MonthCalendar.BackgroundStyle.Class = ""
        Me.begindate_tf.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        '
        '
        '
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.begindate_tf.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.begindate_tf.MonthCalendar.DisplayMonth = New Date(2017, 10, 1, 0, 0, 0, 0)
        Me.begindate_tf.MonthCalendar.FirstDayOfWeek = System.DayOfWeek.Monday
        Me.begindate_tf.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.begindate_tf.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.begindate_tf.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.begindate_tf.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.begindate_tf.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.begindate_tf.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.begindate_tf.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.begindate_tf.MonthCalendar.TodayButtonVisible = True
        Me.begindate_tf.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.begindate_tf.Name = "begindate_tf"
        Me.begindate_tf.Size = New System.Drawing.Size(120, 30)
        Me.begindate_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.begindate_tf.TabIndex = 22
        Me.begindate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Panel3)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1186, 474)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 16)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1180, 455)
        Me.Panel3.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.GroupBox3)
        Me.Panel4.Controls.Add(Me.allpp_ch)
        Me.Panel4.Controls.Add(Me.LabelX5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(394, 455)
        Me.Panel4.TabIndex = 0
        '
        'LabelX5
        '
        Me.LabelX5.AutoSize = True
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX5.Location = New System.Drawing.Point(7, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(82, 29)
        Me.LabelX5.TabIndex = 24
        Me.LabelX5.Text = "ส่งออก All PP :"
        '
        'allpp_ch
        '
        Me.allpp_ch.AutoSize = True
        Me.allpp_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.allpp_ch.Location = New System.Drawing.Point(95, 11)
        Me.allpp_ch.Name = "allpp_ch"
        Me.allpp_ch.Size = New System.Drawing.Size(62, 17)
        Me.allpp_ch.TabIndex = 25
        Me.allpp_ch.Text = "ALL PP"
        Me.allpp_ch.UseVisualStyleBackColor = True
        '
        'ExpandableSplitter1
        '
        Me.ExpandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.ExpandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ExpandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2
        Me.ExpandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground
        Me.ExpandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ExpandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText
        Me.ExpandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.ExpandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.ExpandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExpandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(394, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 455)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 1
        Me.ExpandableSplitter1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.reportData_table)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(400, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(780, 455)
        Me.Panel5.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.specialpp_ch)
        Me.GroupBox3.Controls.Add(Me.anc_ch)
        Me.GroupBox3.Controls.Add(Me.LabelX7)
        Me.GroupBox3.Controls.Add(Me.LabelX9)
        Me.GroupBox3.Controls.Add(Me.epi_ch)
        Me.GroupBox3.Controls.Add(Me.LabelX6)
        Me.GroupBox3.Controls.Add(Me.chronic_ch)
        Me.GroupBox3.Controls.Add(Me.person_ch)
        Me.GroupBox3.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox3.Location = New System.Drawing.Point(2, 26)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(390, 426)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "เลือกแฟ้ม"
        '
        'person_ch
        '
        Me.person_ch.AutoSize = True
        Me.person_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.person_ch.Location = New System.Drawing.Point(11, 45)
        Me.person_ch.Name = "person_ch"
        Me.person_ch.Size = New System.Drawing.Size(76, 30)
        Me.person_ch.TabIndex = 26
        Me.person_ch.Text = "PERSON"
        Me.person_ch.UseVisualStyleBackColor = True
        '
        'chronic_ch
        '
        Me.chronic_ch.AutoSize = True
        Me.chronic_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.chronic_ch.Location = New System.Drawing.Point(100, 45)
        Me.chronic_ch.Name = "chronic_ch"
        Me.chronic_ch.Size = New System.Drawing.Size(82, 30)
        Me.chronic_ch.TabIndex = 27
        Me.chronic_ch.Text = "CHRONIC"
        Me.chronic_ch.UseVisualStyleBackColor = True
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX6.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX6.Location = New System.Drawing.Point(5, 21)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(381, 26)
        Me.LabelX6.TabIndex = 28
        Me.LabelX6.Text = "แฟ้มสะสม"
        '
        'epi_ch
        '
        Me.epi_ch.AutoSize = True
        Me.epi_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.epi_ch.Location = New System.Drawing.Point(11, 190)
        Me.epi_ch.Name = "epi_ch"
        Me.epi_ch.Size = New System.Drawing.Size(48, 30)
        Me.epi_ch.TabIndex = 31
        Me.epi_ch.Text = "EPI"
        Me.epi_ch.UseVisualStyleBackColor = True
        '
        'LabelX9
        '
        '
        '
        '
        Me.LabelX9.BackgroundStyle.Class = ""
        Me.LabelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX9.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX9.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX9.Location = New System.Drawing.Point(5, 101)
        Me.LabelX9.Name = "LabelX9"
        Me.LabelX9.Size = New System.Drawing.Size(381, 26)
        Me.LabelX9.TabIndex = 32
        Me.LabelX9.Text = "แฟ้มบริการ"
        Me.LabelX9.Visible = False
        '
        'LabelX7
        '
        '
        '
        '
        Me.LabelX7.BackgroundStyle.Class = ""
        Me.LabelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX7.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX7.ForeColor = System.Drawing.Color.MediumBlue
        Me.LabelX7.Location = New System.Drawing.Point(5, 170)
        Me.LabelX7.Name = "LabelX7"
        Me.LabelX7.Size = New System.Drawing.Size(381, 26)
        Me.LabelX7.TabIndex = 33
        Me.LabelX7.Text = "แฟ้มบริการกึ่งสำรวจ"
        '
        'anc_ch
        '
        Me.anc_ch.AutoSize = True
        Me.anc_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.anc_ch.Location = New System.Drawing.Point(100, 190)
        Me.anc_ch.Name = "anc_ch"
        Me.anc_ch.Size = New System.Drawing.Size(55, 30)
        Me.anc_ch.TabIndex = 34
        Me.anc_ch.Text = "ANC"
        Me.anc_ch.UseVisualStyleBackColor = True
        '
        'specialpp_ch
        '
        Me.specialpp_ch.AutoSize = True
        Me.specialpp_ch.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.specialpp_ch.Location = New System.Drawing.Point(188, 190)
        Me.specialpp_ch.Name = "specialpp_ch"
        Me.specialpp_ch.Size = New System.Drawing.Size(92, 30)
        Me.specialpp_ch.TabIndex = 35
        Me.specialpp_ch.Text = "SPECIALPP"
        Me.specialpp_ch.UseVisualStyleBackColor = True
        '
        'reportData_table
        '
        Me.reportData_table.AllowUserToAddRows = False
        Me.reportData_table.AllowUserToDeleteRows = False
        Me.reportData_table.AllowUserToResizeRows = False
        Me.reportData_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.reportData_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportData_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.reportData_table.ColumnHeadersHeight = 25
        Me.reportData_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.table_name, Me.amount})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportData_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.reportData_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportData_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.reportData_table.HighlightSelectedColumnHeaders = False
        Me.reportData_table.Location = New System.Drawing.Point(0, 0)
        Me.reportData_table.MultiSelect = False
        Me.reportData_table.Name = "reportData_table"
        Me.reportData_table.ReadOnly = True
        Me.reportData_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData_table.Size = New System.Drawing.Size(780, 455)
        Me.reportData_table.TabIndex = 17
        '
        'id
        '
        Me.id.HeaderText = "สำดับ"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        '
        'table_name
        '
        Me.table_name.HeaderText = "ตาราง"
        Me.table_name.Name = "table_name"
        Me.table_name.ReadOnly = True
        '
        'amount
        '
        Me.amount.HeaderText = "จำนวนข้อมูล"
        Me.amount.Name = "amount"
        Me.amount.ReadOnly = True
        '
        'frmExport50F
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 553)
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExport50F"
        Me.Text = "ส่งออก 50 แฟ้ม"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents begindate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents enddate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents d_update_ch As System.Windows.Forms.RadioButton
    Friend WithEvents date_serv_ch As System.Windows.Forms.RadioButton
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents export_path_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents brows_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Export53tb As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents allpp_ch As System.Windows.Forms.CheckBox
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents chronic_ch As System.Windows.Forms.CheckBox
    Friend WithEvents person_ch As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents anc_ch As System.Windows.Forms.CheckBox
    Friend WithEvents LabelX7 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX9 As DevComponents.DotNetBar.LabelX
    Friend WithEvents epi_ch As System.Windows.Forms.CheckBox
    Friend WithEvents specialpp_ch As System.Windows.Forms.CheckBox
    Friend WithEvents reportData_table As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents table_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents amount As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
