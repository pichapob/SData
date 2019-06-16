<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepQOF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepQOF))
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.reportData_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.report_title_tf = New DevComponents.DotNetBar.PanelEx()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.qof_1_b = New DevComponents.AdvTree.Node()
        Me.qof_2_b = New DevComponents.AdvTree.Node()
        Me.qof_3_b = New DevComponents.AdvTree.Node()
        Me.qof_4_b = New DevComponents.AdvTree.Node()
        Me.qof_5_b = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx5.Size = New System.Drawing.Size(1020, 30)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 14
        Me.PanelEx5.Text = "  ระบบรายงาน QOF เขต 9"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel1.Controls.Add(Me.AdvTree1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 523)
        Me.Panel1.TabIndex = 15
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reportData_table)
        Me.Panel2.Controls.Add(Me.report_title_tf)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(325, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(695, 523)
        Me.Panel2.TabIndex = 3
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
        Me.reportData_table.Location = New System.Drawing.Point(3, 30)
        Me.reportData_table.MultiSelect = False
        Me.reportData_table.Name = "reportData_table"
        Me.reportData_table.ReadOnly = True
        Me.reportData_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData_table.Size = New System.Drawing.Size(689, 490)
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
        Me.report_title_tf.Size = New System.Drawing.Size(695, 30)
        Me.report_title_tf.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.report_title_tf.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.report_title_tf.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.report_title_tf.Style.ForeColor.Color = System.Drawing.Color.White
        Me.report_title_tf.Style.GradientAngle = 90
        Me.report_title_tf.TabIndex = 15
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
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(319, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 523)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 2
        Me.ExpandableSplitter1.TabStop = False
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
        Me.AdvTree1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AdvTree1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AdvTree1.Location = New System.Drawing.Point(0, 0)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(319, 523)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 1
        Me.AdvTree1.Text = " "
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Image = Global.SData.My.Resources.Resources.graph16
        Me.Node1.Name = "Node1"
        Me.Node1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.qof_1_b, Me.qof_2_b, Me.qof_3_b, Me.qof_4_b, Me.qof_5_b})
        Me.Node1.Text = "รายงาน QOF"
        '
        'qof_1_b
        '
        Me.qof_1_b.Expanded = True
        Me.qof_1_b.Name = "qof_1_b"
        Me.qof_1_b.Text = "เด็กอายุ 9, 18, 30, 42 เดือน ที่ได้รับการตรวจคัดกรองพัฒนาการ"
        '
        'qof_2_b
        '
        Me.qof_2_b.Expanded = True
        Me.qof_2_b.Name = "qof_2_b"
        Me.qof_2_b.Text = "เด็กอายุ 9,18,30,42 เดือน ที่ตรวจพบสงสัยล่าช้า"
        '
        'qof_3_b
        '
        Me.qof_3_b.Expanded = True
        Me.qof_3_b.Name = "qof_3_b"
        Me.qof_3_b.Text = "เด็กพัฒนาการสงสัยล่าช้า ที่ได้รับการกระตุ้น และติดตามภายใน 30 วัน"
        '
        'qof_4_b
        '
        Me.qof_4_b.Expanded = True
        Me.qof_4_b.Name = "qof_4_b"
        Me.qof_4_b.Text = "ร้อยละของเด็กนักเรียนมีภาวะเริ่มอ้วนและอ้วน"
        Me.qof_4_b.Visible = False
        '
        'qof_5_b
        '
        Me.qof_5_b.Expanded = True
        Me.qof_5_b.Name = "qof_5_b"
        Me.qof_5_b.Text = "ร้อยละการตั้งครรภ์ซ้าในหญิงอายุน้อยกว่า 20 ปี"
        Me.qof_5_b.Visible = False
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
        'frmRepQOF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepQOF"
        Me.Text = "รายงาน QOF"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents qof_1_b As DevComponents.AdvTree.Node
    Friend WithEvents qof_2_b As DevComponents.AdvTree.Node
    Friend WithEvents qof_3_b As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents qof_4_b As DevComponents.AdvTree.Node
    Friend WithEvents qof_5_b As DevComponents.AdvTree.Node
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents report_title_tf As DevComponents.DotNetBar.PanelEx
    Friend WithEvents reportData_table As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
