<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepOlder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepOlder))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cid_find_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.status_tf = New DevComponents.DotNetBar.LabelX()
        Me.reportData_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.report_title_tf = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.older_report_1_b = New DevComponents.AdvTree.Node()
        Me.older_report_2_b = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.search_b = New DevComponents.DotNetBar.ButtonX()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.PanelEx5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 553)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.search_b)
        Me.Panel3.Controls.Add(Me.cid_find_tf)
        Me.Panel3.Controls.Add(Me.PanelEx1)
        Me.Panel3.Controls.Add(Me.reportData_table)
        Me.Panel3.Controls.Add(Me.report_title_tf)
        Me.Panel3.Controls.Add(Me.LabelX1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(313, 30)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(707, 523)
        Me.Panel3.TabIndex = 17
        '
        'cid_find_tf
        '
        '
        '
        '
        Me.cid_find_tf.Border.Class = "TextBoxBorder"
        Me.cid_find_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cid_find_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cid_find_tf.Location = New System.Drawing.Point(118, 35)
        Me.cid_find_tf.Name = "cid_find_tf"
        Me.cid_find_tf.Size = New System.Drawing.Size(263, 32)
        Me.cid_find_tf.TabIndex = 19
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.status_tf)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx1.Location = New System.Drawing.Point(0, 490)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(707, 33)
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 17
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
        Me.status_tf.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.status_tf.Location = New System.Drawing.Point(6, 2)
        Me.status_tf.Name = "status_tf"
        Me.status_tf.Size = New System.Drawing.Size(698, 29)
        Me.status_tf.TabIndex = 5
        Me.status_tf.Text = "Status:"
        Me.status_tf.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'reportData_table
        '
        Me.reportData_table.AllowUserToAddRows = False
        Me.reportData_table.AllowUserToDeleteRows = False
        Me.reportData_table.AllowUserToResizeColumns = False
        Me.reportData_table.AllowUserToResizeRows = False
        Me.reportData_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.reportData_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.reportData_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.reportData_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportData_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.reportData_table.ColumnHeadersHeight = 25
        Me.reportData_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.reportData_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.reportData_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.reportData_table.HighlightSelectedColumnHeaders = False
        Me.reportData_table.Location = New System.Drawing.Point(0, 71)
        Me.reportData_table.MultiSelect = False
        Me.reportData_table.Name = "reportData_table"
        Me.reportData_table.ReadOnly = True
        Me.reportData_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData_table.Size = New System.Drawing.Size(707, 418)
        Me.reportData_table.TabIndex = 16
        '
        'report_title_tf
        '
        Me.report_title_tf.CanvasColor = System.Drawing.SystemColors.Control
        Me.report_title_tf.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.report_title_tf.Dock = System.Windows.Forms.DockStyle.Top
        Me.report_title_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.report_title_tf.Location = New System.Drawing.Point(0, 0)
        Me.report_title_tf.Name = "report_title_tf"
        Me.report_title_tf.Size = New System.Drawing.Size(707, 30)
        Me.report_title_tf.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.report_title_tf.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.report_title_tf.Style.ForeColor.Color = System.Drawing.Color.White
        Me.report_title_tf.Style.GradientAngle = 90
        Me.report_title_tf.TabIndex = 15
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(5, 32)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(107, 37)
        Me.LabelX1.TabIndex = 18
        Me.LabelX1.Text = "ค้นหา CID/ชื่อ/สกุล"
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
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(307, 30)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 523)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 16
        Me.ExpandableSplitter1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AdvTree1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 30)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(307, 523)
        Me.Panel2.TabIndex = 15
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.AllowDrop = True
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdvTree1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AdvTree1.Location = New System.Drawing.Point(0, 0)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(307, 523)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 1
        Me.AdvTree1.Text = " "
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Image = Global.SData.My.Resources.Resources.graph16
        Me.Node1.Name = "Node1"
        Me.Node1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.older_report_1_b, Me.older_report_2_b})
        Me.Node1.Text = "รายงานการคัดกรองผู้สูงอายุ"
        '
        'older_report_1_b
        '
        Me.older_report_1_b.Expanded = True
        Me.older_report_1_b.Image = Global.SData.My.Resources.Resources.pensil16
        Me.older_report_1_b.Name = "older_report_1_b"
        Me.older_report_1_b.Text = "ร้อยละของผู้สูงอายุที่ได้รับการคัดกรอง/ประเมินสุขภาพ Healthy Ageing"
        '
        'older_report_2_b
        '
        Me.older_report_2_b.Expanded = True
        Me.older_report_2_b.Image = Global.SData.My.Resources.Resources.pensil16
        Me.older_report_2_b.Name = "older_report_2_b"
        Me.older_report_2_b.Text = "ร้อยละของผู้สูงอายุที่สามารถช่วยเหลือตนเองได้ในการทํากิจวัตรประจําวันพื้นฐาน"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle1
        '
        Me.ElementStyle1.Class = ""
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(1020, 30)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 14
        Me.PanelEx5.Text = "  ระบบรายงานการคัดกรองผู้สูงอายุ"
        '
        'search_b
        '
        Me.search_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.search_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.search_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.search_b.Location = New System.Drawing.Point(387, 36)
        Me.search_b.Name = "search_b"
        Me.search_b.Size = New System.Drawing.Size(75, 30)
        Me.search_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.search_b.TabIndex = 20
        Me.search_b.Text = "ค้นหา"
        '
        'frmRepOlder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepOlder"
        Me.Text = "รายงานการคัดกรองผู้สูงอายุ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents older_report_1_b As DevComponents.AdvTree.Node
    Friend WithEvents older_report_2_b As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents report_title_tf As DevComponents.DotNetBar.PanelEx
    Friend WithEvents reportData_table As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents status_tf As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cid_find_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents search_b As DevComponents.DotNetBar.ButtonX
End Class
