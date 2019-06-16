<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExportOldPersonVission
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExportOldPersonVission))
        Me.vsttime = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.person_older_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.cid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.person_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.birthdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vstdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.l01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.r01 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lph = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rph = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.va_tranf_desc_l = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.va_tranf_desc_r = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.house_regist_type_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.village_moo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.village_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.full_name_add = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.exportdata_cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.สงออกขอมลToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Export_person_table_b = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.refreshOutput_b = New DevComponents.DotNetBar.ButtonX()
        Me.enddate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.begindate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.year_end_tf = New System.Windows.Forms.NumericUpDown()
        Me.year_begin_tf = New System.Windows.Forms.NumericUpDown()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.year_older_person_tf = New System.Windows.Forms.NumericUpDown()
        Me.reloadPerson_b = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.status_tf = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.export_va_b = New DevComponents.DotNetBar.ButtonX()
        Me.export_osm_b = New DevComponents.DotNetBar.ButtonX()
        Me.export_person_b = New DevComponents.DotNetBar.ButtonX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.person_older_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.exportdata_cms.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.year_end_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.year_begin_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.year_older_person_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'vsttime
        '
        Me.vsttime.DataPropertyName = "vsttime"
        Me.vsttime.HeaderText = "เวลารับบริการครั้งล่าสุด"
        Me.vsttime.Name = "vsttime"
        Me.vsttime.ReadOnly = True
        Me.vsttime.Width = 133
        '
        'person_older_table
        '
        Me.person_older_table.AllowUserToAddRows = False
        Me.person_older_table.AllowUserToDeleteRows = False
        Me.person_older_table.AllowUserToResizeColumns = False
        Me.person_older_table.AllowUserToResizeRows = False
        Me.person_older_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.person_older_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.person_older_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.person_older_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.person_older_table.ColumnHeadersHeight = 25
        Me.person_older_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.person_older_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cid, Me.person_id, Me.full_name, Me.birthdate, Me.age, Me.sex, Me.vstdate, Me.vsttime, Me.l01, Me.r01, Me.lph, Me.rph, Me.va_tranf_desc_l, Me.va_tranf_desc_r, Me.house_regist_type_name, Me.address, Me.village_moo, Me.village_name, Me.full_name_add})
        Me.person_older_table.ContextMenuStrip = Me.exportdata_cms
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.person_older_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.person_older_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.person_older_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.person_older_table.HighlightSelectedColumnHeaders = False
        Me.person_older_table.Location = New System.Drawing.Point(0, 0)
        Me.person_older_table.MultiSelect = False
        Me.person_older_table.Name = "person_older_table"
        Me.person_older_table.ReadOnly = True
        Me.person_older_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.person_older_table.Size = New System.Drawing.Size(1020, 430)
        Me.person_older_table.TabIndex = 11
        '
        'cid
        '
        Me.cid.DataPropertyName = "cid"
        Me.cid.HeaderText = "เลขบัตรประจำตัวประชาชน"
        Me.cid.Name = "cid"
        Me.cid.ReadOnly = True
        Me.cid.Width = 150
        '
        'person_id
        '
        Me.person_id.DataPropertyName = "person_id"
        Me.person_id.HeaderText = "ทะเบียนบุคคล"
        Me.person_id.Name = "person_id"
        Me.person_id.ReadOnly = True
        Me.person_id.Width = 96
        '
        'full_name
        '
        Me.full_name.DataPropertyName = "full_name"
        Me.full_name.HeaderText = "ชื่อ-สกุล"
        Me.full_name.Name = "full_name"
        Me.full_name.ReadOnly = True
        Me.full_name.Width = 68
        '
        'birthdate
        '
        Me.birthdate.DataPropertyName = "birthdate"
        Me.birthdate.HeaderText = "วันเดือนปีเกิด"
        Me.birthdate.Name = "birthdate"
        Me.birthdate.ReadOnly = True
        Me.birthdate.Width = 91
        '
        'age
        '
        Me.age.DataPropertyName = "age"
        Me.age.HeaderText = "อายุ"
        Me.age.Name = "age"
        Me.age.ReadOnly = True
        Me.age.Width = 52
        '
        'sex
        '
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "เพศ"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        Me.sex.Width = 51
        '
        'vstdate
        '
        Me.vstdate.DataPropertyName = "vstdate"
        Me.vstdate.HeaderText = "วันรับบริการครั้งล่าสุด"
        Me.vstdate.Name = "vstdate"
        Me.vstdate.ReadOnly = True
        Me.vstdate.Width = 126
        '
        'l01
        '
        Me.l01.DataPropertyName = "l01"
        Me.l01.HeaderText = "ค่า VA ตาซ้าย"
        Me.l01.Name = "l01"
        Me.l01.ReadOnly = True
        Me.l01.Width = 91
        '
        'r01
        '
        Me.r01.DataPropertyName = "r01"
        Me.r01.HeaderText = "ค่า VA ตาขวา"
        Me.r01.Name = "r01"
        Me.r01.ReadOnly = True
        Me.r01.Width = 90
        '
        'lph
        '
        Me.lph.DataPropertyName = "lph"
        Me.lph.HeaderText = "ค่า PH ตาซ้าย"
        Me.lph.Name = "lph"
        Me.lph.ReadOnly = True
        Me.lph.Width = 93
        '
        'rph
        '
        Me.rph.DataPropertyName = "rph"
        Me.rph.HeaderText = "ค่า PH ตาขวา"
        Me.rph.Name = "rph"
        Me.rph.ReadOnly = True
        Me.rph.Width = 92
        '
        'va_tranf_desc_l
        '
        Me.va_tranf_desc_l.DataPropertyName = "va_tranf_desc_l"
        Me.va_tranf_desc_l.HeaderText = "แปรผล อสม. ตาซ้าย"
        Me.va_tranf_desc_l.Name = "va_tranf_desc_l"
        Me.va_tranf_desc_l.ReadOnly = True
        Me.va_tranf_desc_l.Width = 120
        '
        'va_tranf_desc_r
        '
        Me.va_tranf_desc_r.DataPropertyName = "va_tranf_desc_r"
        Me.va_tranf_desc_r.HeaderText = "แปรผล อสม. ตาขวา"
        Me.va_tranf_desc_r.Name = "va_tranf_desc_r"
        Me.va_tranf_desc_r.ReadOnly = True
        Me.va_tranf_desc_r.Width = 119
        '
        'house_regist_type_name
        '
        Me.house_regist_type_name.DataPropertyName = "house_regist_type_name"
        Me.house_regist_type_name.HeaderText = "ประเภทการอยู่อาศัย"
        Me.house_regist_type_name.Name = "house_regist_type_name"
        Me.house_regist_type_name.ReadOnly = True
        Me.house_regist_type_name.Width = 121
        '
        'address
        '
        Me.address.DataPropertyName = "address"
        Me.address.HeaderText = "บ้านเลขที่"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        Me.address.Width = 76
        '
        'village_moo
        '
        Me.village_moo.DataPropertyName = "village_moo"
        Me.village_moo.HeaderText = "หมู่ที่"
        Me.village_moo.Name = "village_moo"
        Me.village_moo.ReadOnly = True
        Me.village_moo.Width = 55
        '
        'village_name
        '
        Me.village_name.DataPropertyName = "village_name"
        Me.village_name.HeaderText = "หมู่บ้าน"
        Me.village_name.Name = "village_name"
        Me.village_name.ReadOnly = True
        Me.village_name.Width = 67
        '
        'full_name_add
        '
        Me.full_name_add.DataPropertyName = "full_name_add"
        Me.full_name_add.HeaderText = "ตำบล อำเภอ จังหวัด"
        Me.full_name_add.Name = "full_name_add"
        Me.full_name_add.ReadOnly = True
        Me.full_name_add.Width = 121
        '
        'exportdata_cms
        '
        Me.exportdata_cms.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exportdata_cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.สงออกขอมลToolStripMenuItem})
        Me.exportdata_cms.Name = "exportdata_cms"
        Me.exportdata_cms.Size = New System.Drawing.Size(192, 34)
        '
        'สงออกขอมลToolStripMenuItem
        '
        Me.สงออกขอมลToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Export_person_table_b})
        Me.สงออกขอมลToolStripMenuItem.Image = Global.SData.My.Resources.Resources.Export_logo32
        Me.สงออกขอมลToolStripMenuItem.Name = "สงออกขอมลToolStripMenuItem"
        Me.สงออกขอมลToolStripMenuItem.Size = New System.Drawing.Size(191, 30)
        Me.สงออกขอมลToolStripMenuItem.Text = "ส่งออกข้อมูลในตาราง"
        '
        'Export_person_table_b
        '
        Me.Export_person_table_b.Name = "Export_person_table_b"
        Me.Export_person_table_b.Size = New System.Drawing.Size(152, 30)
        Me.Export_person_table_b.Text = "ส่งออก Excel"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.person_older_table)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1020, 430)
        Me.Panel3.TabIndex = 14
        '
        'refreshOutput_b
        '
        Me.refreshOutput_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.refreshOutput_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.refreshOutput_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.refreshOutput_b.Location = New System.Drawing.Point(925, 12)
        Me.refreshOutput_b.Name = "refreshOutput_b"
        Me.refreshOutput_b.Size = New System.Drawing.Size(96, 29)
        Me.refreshOutput_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.refreshOutput_b.TabIndex = 24
        Me.refreshOutput_b.Text = "ประมวลผลงาน"
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
        Me.enddate_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.enddate_tf.IsPopupCalendarOpen = False
        Me.enddate_tf.Location = New System.Drawing.Point(805, 13)
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
        Me.enddate_tf.Size = New System.Drawing.Size(114, 28)
        Me.enddate_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.enddate_tf.TabIndex = 23
        Me.enddate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX5.Location = New System.Drawing.Point(782, 13)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(17, 29)
        Me.LabelX5.TabIndex = 22
        Me.LabelX5.Text = "ถึง"
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
        Me.begindate_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.begindate_tf.IsPopupCalendarOpen = False
        Me.begindate_tf.Location = New System.Drawing.Point(662, 13)
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
        Me.begindate_tf.Size = New System.Drawing.Size(114, 28)
        Me.begindate_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.begindate_tf.TabIndex = 21
        Me.begindate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(448, 13)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(17, 29)
        Me.LabelX3.TabIndex = 18
        Me.LabelX3.Text = "ถึง"
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(572, 13)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(84, 29)
        Me.LabelX4.TabIndex = 20
        Me.LabelX4.Text = "เลือกช่วงผลงาน"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 44)
        Me.Panel1.TabIndex = 12
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.refreshOutput_b)
        Me.GroupBox1.Controls.Add(Me.enddate_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.begindate_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.year_end_tf)
        Me.GroupBox1.Controls.Add(Me.year_begin_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.year_older_person_tf)
        Me.GroupBox1.Controls.Add(Me.reloadPerson_b)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(1, -5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 46)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'year_end_tf
        '
        Me.year_end_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.year_end_tf.Location = New System.Drawing.Point(470, 13)
        Me.year_end_tf.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.year_end_tf.Name = "year_end_tf"
        Me.year_end_tf.Size = New System.Drawing.Size(50, 28)
        Me.year_end_tf.TabIndex = 19
        Me.year_end_tf.Value = New Decimal(New Integer() {120, 0, 0, 0})
        '
        'year_begin_tf
        '
        Me.year_begin_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.year_begin_tf.Location = New System.Drawing.Point(393, 13)
        Me.year_begin_tf.Name = "year_begin_tf"
        Me.year_begin_tf.Size = New System.Drawing.Size(48, 28)
        Me.year_begin_tf.TabIndex = 18
        Me.year_begin_tf.Value = New Decimal(New Integer() {60, 0, 0, 0})
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(350, 12)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(48, 29)
        Me.LabelX2.TabIndex = 17
        Me.LabelX2.Text = "ช่วงอายุ"
        '
        'year_older_person_tf
        '
        Me.year_older_person_tf.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.year_older_person_tf.Location = New System.Drawing.Point(250, 13)
        Me.year_older_person_tf.Maximum = New Decimal(New Integer() {2600, 0, 0, 0})
        Me.year_older_person_tf.Minimum = New Decimal(New Integer() {2550, 0, 0, 0})
        Me.year_older_person_tf.Name = "year_older_person_tf"
        Me.year_older_person_tf.Size = New System.Drawing.Size(83, 28)
        Me.year_older_person_tf.TabIndex = 15
        Me.year_older_person_tf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.year_older_person_tf.Value = New Decimal(New Integer() {2560, 0, 0, 0})
        '
        'reloadPerson_b
        '
        Me.reloadPerson_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.reloadPerson_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.reloadPerson_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.reloadPerson_b.Location = New System.Drawing.Point(6, 12)
        Me.reloadPerson_b.Name = "reloadPerson_b"
        Me.reloadPerson_b.Size = New System.Drawing.Size(150, 29)
        Me.reloadPerson_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.reloadPerson_b.TabIndex = 0
        Me.reloadPerson_b.Text = "ประมวลผลกลุ่มเป้าหมาย"
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(179, 13)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(73, 29)
        Me.LabelX1.TabIndex = 16
        Me.LabelX1.Text = "ปีงบประมาณ"
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1020, 35)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 11
        Me.PanelEx5.Text = "  ระบบส่งออกข้อมูลการคัดกรองสายตาผู้สูงอายุ เข้าเว็บ Vission2020"
        '
        'status_tf
        '
        Me.status_tf.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.status_tf.BackgroundStyle.Class = ""
        Me.status_tf.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.status_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.status_tf.Location = New System.Drawing.Point(531, 11)
        Me.status_tf.Name = "status_tf"
        Me.status_tf.Size = New System.Drawing.Size(482, 29)
        Me.status_tf.TabIndex = 4
        Me.status_tf.Text = "Status:"
        Me.status_tf.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.status_tf)
        Me.GroupBox2.Controls.Add(Me.export_va_b)
        Me.GroupBox2.Controls.Add(Me.export_osm_b)
        Me.GroupBox2.Controls.Add(Me.export_person_b)
        Me.GroupBox2.Location = New System.Drawing.Point(1, -2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1019, 43)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'export_va_b
        '
        Me.export_va_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.export_va_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.export_va_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.export_va_b.Image = Global.SData.My.Resources.Resources.Export_logo32
        Me.export_va_b.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.export_va_b.Location = New System.Drawing.Point(306, 9)
        Me.export_va_b.Name = "export_va_b"
        Me.export_va_b.Size = New System.Drawing.Size(168, 29)
        Me.export_va_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.export_va_b.TabIndex = 3
        Me.export_va_b.Text = " ส่งออกข้อมูลคัดกรอง VA"
        '
        'export_osm_b
        '
        Me.export_osm_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.export_osm_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.export_osm_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.export_osm_b.Image = Global.SData.My.Resources.Resources.Export_logo32
        Me.export_osm_b.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.export_osm_b.Location = New System.Drawing.Point(138, 9)
        Me.export_osm_b.Name = "export_osm_b"
        Me.export_osm_b.Size = New System.Drawing.Size(162, 29)
        Me.export_osm_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.export_osm_b.TabIndex = 2
        Me.export_osm_b.Text = " ส่งออกข้อมูลแปรผล อสม."
        '
        'export_person_b
        '
        Me.export_person_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.export_person_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.export_person_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.export_person_b.Image = Global.SData.My.Resources.Resources.Export_logo32
        Me.export_person_b.ImageFixedSize = New System.Drawing.Size(16, 16)
        Me.export_person_b.Location = New System.Drawing.Point(6, 9)
        Me.export_person_b.Name = "export_person_b"
        Me.export_person_b.Size = New System.Drawing.Size(126, 29)
        Me.export_person_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.export_person_b.TabIndex = 1
        Me.export_person_b.Text = " ส่งออกประชากร"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 509)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1020, 44)
        Me.Panel2.TabIndex = 13
        '
        'frmExportOldPersonVission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 553)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx5)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmExportOldPersonVission"
        Me.Text = "คัดกรองสายตาผู้สูงอายุ"
        CType(Me.person_older_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.exportdata_cms.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.year_end_tf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.year_begin_tf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.year_older_person_tf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsttime As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents person_older_table As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents cid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents person_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents full_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents birthdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents age As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sex As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vstdate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents l01 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents r01 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rph As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents va_tranf_desc_l As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents va_tranf_desc_r As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents house_regist_type_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents address As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents village_moo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents village_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents full_name_add As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents exportdata_cms As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents สงออกขอมลToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Export_person_table_b As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents refreshOutput_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents enddate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents begindate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents export_person_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents year_end_tf As System.Windows.Forms.NumericUpDown
    Friend WithEvents year_begin_tf As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents year_older_person_tf As System.Windows.Forms.NumericUpDown
    Friend WithEvents reloadPerson_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents status_tf As DevComponents.DotNetBar.LabelX
    Friend WithEvents export_va_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents export_osm_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
