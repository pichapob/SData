<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectVisit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectVisit))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.cancle_b = New DevComponents.DotNetBar.ButtonX()
        Me.select_visit_b = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.report_title_tf = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.full_address_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.age_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.hn_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.cid_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.ptname_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.visit_list_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.visit_list_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.cancle_b)
        Me.PanelEx1.Controls.Add(Me.select_visit_b)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.report_title_tf)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Controls.Add(Me.GroupBox2)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(832, 487)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'cancle_b
        '
        Me.cancle_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cancle_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cancle_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cancle_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cancle_b.Image = Global.SData.My.Resources.Resources.cross16
        Me.cancle_b.Location = New System.Drawing.Point(760, 447)
        Me.cancle_b.Name = "cancle_b"
        Me.cancle_b.Size = New System.Drawing.Size(68, 35)
        Me.cancle_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cancle_b.TabIndex = 21
        Me.cancle_b.Text = "ยกเลิก"
        '
        'select_visit_b
        '
        Me.select_visit_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.select_visit_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.select_visit_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.select_visit_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.select_visit_b.Image = Global.SData.My.Resources.Resources.check16
        Me.select_visit_b.Location = New System.Drawing.Point(686, 447)
        Me.select_visit_b.Name = "select_visit_b"
        Me.select_visit_b.Size = New System.Drawing.Size(68, 35)
        Me.select_visit_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.select_visit_b.TabIndex = 20
        Me.select_visit_b.Text = "เลือก"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx2.Location = New System.Drawing.Point(0, 130)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(832, 30)
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 18
        Me.PanelEx2.Text = "   ข้อมูลบริการ"
        '
        'report_title_tf
        '
        Me.report_title_tf.CanvasColor = System.Drawing.SystemColors.Control
        Me.report_title_tf.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.report_title_tf.Dock = System.Windows.Forms.DockStyle.Top
        Me.report_title_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.report_title_tf.Location = New System.Drawing.Point(0, 0)
        Me.report_title_tf.Name = "report_title_tf"
        Me.report_title_tf.Size = New System.Drawing.Size(832, 30)
        Me.report_title_tf.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.report_title_tf.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.report_title_tf.Style.ForeColor.Color = System.Drawing.Color.White
        Me.report_title_tf.Style.GradientAngle = 90
        Me.report_title_tf.TabIndex = 16
        Me.report_title_tf.Text = "   ข้อมูลบุคคล"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.full_address_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX5)
        Me.GroupBox1.Controls.Add(Me.age_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.hn_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.cid_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.ptname_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(826, 102)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'full_address_tf
        '
        '
        '
        '
        Me.full_address_tf.Border.Class = "TextBoxBorder"
        Me.full_address_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.full_address_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.full_address_tf.Location = New System.Drawing.Point(64, 48)
        Me.full_address_tf.Name = "full_address_tf"
        Me.full_address_tf.Size = New System.Drawing.Size(710, 32)
        Me.full_address_tf.TabIndex = 10
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
        Me.LabelX5.Location = New System.Drawing.Point(26, 50)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(32, 29)
        Me.LabelX5.TabIndex = 9
        Me.LabelX5.Text = "ที่อยู่ :"
        '
        'age_tf
        '
        '
        '
        '
        Me.age_tf.Border.Class = "TextBoxBorder"
        Me.age_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.age_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.age_tf.Location = New System.Drawing.Point(709, 10)
        Me.age_tf.Name = "age_tf"
        Me.age_tf.Size = New System.Drawing.Size(65, 32)
        Me.age_tf.TabIndex = 8
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
        Me.LabelX4.Location = New System.Drawing.Point(680, 10)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(23, 29)
        Me.LabelX4.TabIndex = 7
        Me.LabelX4.Text = "อายุ"
        '
        'hn_tf
        '
        '
        '
        '
        Me.hn_tf.Border.Class = "TextBoxBorder"
        Me.hn_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.hn_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.hn_tf.Location = New System.Drawing.Point(609, 10)
        Me.hn_tf.Name = "hn_tf"
        Me.hn_tf.Size = New System.Drawing.Size(65, 32)
        Me.hn_tf.TabIndex = 6
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
        Me.LabelX3.Location = New System.Drawing.Point(584, 11)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(19, 29)
        Me.LabelX3.TabIndex = 5
        Me.LabelX3.Text = "HN"
        '
        'cid_tf
        '
        '
        '
        '
        Me.cid_tf.Border.Class = "TextBoxBorder"
        Me.cid_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cid_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cid_tf.Location = New System.Drawing.Point(386, 11)
        Me.cid_tf.Name = "cid_tf"
        Me.cid_tf.Size = New System.Drawing.Size(192, 32)
        Me.cid_tf.TabIndex = 4
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
        Me.LabelX2.Location = New System.Drawing.Point(262, 13)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(118, 29)
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "เลขประจำตัวประชาชน"
        '
        'ptname_tf
        '
        '
        '
        '
        Me.ptname_tf.Border.Class = "TextBoxBorder"
        Me.ptname_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ptname_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ptname_tf.Location = New System.Drawing.Point(64, 10)
        Me.ptname_tf.Name = "ptname_tf"
        Me.ptname_tf.Size = New System.Drawing.Size(192, 32)
        Me.ptname_tf.TabIndex = 1
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
        Me.LabelX1.Location = New System.Drawing.Point(10, 11)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(50, 29)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "ชื่อ-สกุล :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.visit_list_table)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 156)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 285)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        '
        'visit_list_table
        '
        Me.visit_list_table.AllowUserToAddRows = False
        Me.visit_list_table.AllowUserToDeleteRows = False
        Me.visit_list_table.AllowUserToResizeColumns = False
        Me.visit_list_table.AllowUserToResizeRows = False
        Me.visit_list_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.visit_list_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.visit_list_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.visit_list_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.visit_list_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.visit_list_table.ColumnHeadersHeight = 25
        Me.visit_list_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.visit_list_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.visit_list_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.visit_list_table.HighlightSelectedColumnHeaders = False
        Me.visit_list_table.Location = New System.Drawing.Point(4, 10)
        Me.visit_list_table.MultiSelect = False
        Me.visit_list_table.Name = "visit_list_table"
        Me.visit_list_table.ReadOnly = True
        Me.visit_list_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.visit_list_table.Size = New System.Drawing.Size(818, 271)
        Me.visit_list_table.TabIndex = 17
        '
        'frmSelectVisit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 487)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectVisit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกข้อมูล Visit"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.visit_list_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents report_title_tf As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents ptname_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cid_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents hn_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents age_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents full_address_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cancle_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents select_visit_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents visit_list_table As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
