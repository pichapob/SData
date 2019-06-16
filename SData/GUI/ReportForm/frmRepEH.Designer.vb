<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRepEH
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRepEH))
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.reportChildMonthSpB = New DevComponents.AdvTree.Node()
        Me.NodeConnector1 = New DevComponents.AdvTree.NodeConnector()
        Me.Node1 = New DevComponents.AdvTree.Node()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdvTree1 = New DevComponents.AdvTree.AdvTree()
        Me.ElementStyle1 = New DevComponents.DotNetBar.ElementStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.reportData_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.ExpandableSplitter1 = New DevComponents.DotNetBar.ExpandableSplitter()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AdvTree2 = New DevComponents.AdvTree.AdvTree()
        Me.Node2 = New DevComponents.AdvTree.Node()
        Me.rep_checksex_b = New DevComponents.AdvTree.Node()
        Me.Node5 = New DevComponents.AdvTree.Node()
        Me.NodeConnector2 = New DevComponents.AdvTree.NodeConnector()
        Me.ElementStyle2 = New DevComponents.DotNetBar.ElementStyle()
        Me.Panel2.SuspendLayout()
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx5.Text = "  ระบบรายงานคุณภาพข้อมูล EH"
        '
        'reportChildMonthSpB
        '
        Me.reportChildMonthSpB.Expanded = True
        Me.reportChildMonthSpB.Name = "reportChildMonthSpB"
        Me.reportChildMonthSpB.Text = "เด็ก 9,18,30,42 เดือน ได้รับการประเมินพัฒนาการ"
        '
        'NodeConnector1
        '
        Me.NodeConnector1.LineColor = System.Drawing.SystemColors.ControlText
        '
        'Node1
        '
        Me.Node1.Expanded = True
        Me.Node1.Image = Global.SData.My.Resources.Resources.graph16
        Me.Node1.Name = "Node1"
        Me.Node1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.reportChildMonthSpB})
        Me.Node1.Text = "ประเมินพัฒนาการเด็ก "
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AdvTree1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(369, 553)
        Me.Panel2.TabIndex = 0
        '
        'AdvTree1
        '
        Me.AdvTree1.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree1.AllowDrop = True
        Me.AdvTree1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTree1.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree1.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AdvTree1.Location = New System.Drawing.Point(3, 3)
        Me.AdvTree1.Name = "AdvTree1"
        Me.AdvTree1.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node1})
        Me.AdvTree1.NodesConnector = Me.NodeConnector1
        Me.AdvTree1.NodeStyle = Me.ElementStyle1
        Me.AdvTree1.PathSeparator = ";"
        Me.AdvTree1.Size = New System.Drawing.Size(363, 547)
        Me.AdvTree1.Styles.Add(Me.ElementStyle1)
        Me.AdvTree1.TabIndex = 0
        '
        'ElementStyle1
        '
        Me.ElementStyle1.Class = ""
        Me.ElementStyle1.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle1.Name = "ElementStyle1"
        Me.ElementStyle1.TextColor = System.Drawing.SystemColors.ControlText
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.reportData_table)
        Me.Panel1.Controls.Add(Me.ExpandableSplitter1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1020, 523)
        Me.Panel1.TabIndex = 15
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
        Me.reportData_table.Location = New System.Drawing.Point(354, 1)
        Me.reportData_table.MultiSelect = False
        Me.reportData_table.Name = "reportData_table"
        Me.reportData_table.ReadOnly = True
        Me.reportData_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData_table.Size = New System.Drawing.Size(663, 520)
        Me.reportData_table.TabIndex = 13
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
        Me.ExpandableSplitter1.Location = New System.Drawing.Point(348, 0)
        Me.ExpandableSplitter1.Name = "ExpandableSplitter1"
        Me.ExpandableSplitter1.Size = New System.Drawing.Size(6, 523)
        Me.ExpandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007
        Me.ExpandableSplitter1.TabIndex = 1
        Me.ExpandableSplitter1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.AdvTree2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(348, 523)
        Me.Panel3.TabIndex = 0
        '
        'AdvTree2
        '
        Me.AdvTree2.AccessibleRole = System.Windows.Forms.AccessibleRole.Outline
        Me.AdvTree2.AllowDrop = True
        Me.AdvTree2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AdvTree2.BackColor = System.Drawing.SystemColors.Window
        '
        '
        '
        Me.AdvTree2.BackgroundStyle.Class = "TreeBorderKey"
        Me.AdvTree2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.AdvTree2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.AdvTree2.Location = New System.Drawing.Point(3, 3)
        Me.AdvTree2.Name = "AdvTree2"
        Me.AdvTree2.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.Node2, Me.Node5})
        Me.AdvTree2.NodesConnector = Me.NodeConnector2
        Me.AdvTree2.NodeStyle = Me.ElementStyle2
        Me.AdvTree2.PathSeparator = ";"
        Me.AdvTree2.Size = New System.Drawing.Size(342, 517)
        Me.AdvTree2.Styles.Add(Me.ElementStyle2)
        Me.AdvTree2.TabIndex = 1
        Me.AdvTree2.Text = " "
        '
        'Node2
        '
        Me.Node2.Expanded = True
        Me.Node2.Image = Global.SData.My.Resources.Resources.graph16
        Me.Node2.Name = "Node2"
        Me.Node2.Nodes.AddRange(New DevComponents.AdvTree.Node() {Me.rep_checksex_b})
        Me.Node2.Text = "ประชากร"
        '
        'rep_checksex_b
        '
        Me.rep_checksex_b.Expanded = True
        Me.rep_checksex_b.Name = "rep_checksex_b"
        Me.rep_checksex_b.Text = "ตรวจสอบ บุคคลที่มรรหัสเพศไม่ตรงตามมาตรฐาน"
        '
        'Node5
        '
        Me.Node5.Expanded = True
        Me.Node5.Image = Global.SData.My.Resources.Resources.graph16
        Me.Node5.Name = "Node5"
        Me.Node5.Text = "อนามัยแม่และเด็ก"
        '
        'NodeConnector2
        '
        Me.NodeConnector2.LineColor = System.Drawing.SystemColors.ControlText
        '
        'ElementStyle2
        '
        Me.ElementStyle2.Class = ""
        Me.ElementStyle2.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.ElementStyle2.Name = "ElementStyle2"
        Me.ElementStyle2.TextColor = System.Drawing.SystemColors.ControlText
        '
        'frmRepEH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1020, 553)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelEx5)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmRepEH"
        Me.Text = "frmRepEH"
        Me.Panel2.ResumeLayout(False)
        CType(Me.AdvTree1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.AdvTree2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents reportChildMonthSpB As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector1 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents Node1 As DevComponents.AdvTree.Node
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents AdvTree1 As DevComponents.AdvTree.AdvTree
    Friend WithEvents ElementStyle1 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents AdvTree2 As DevComponents.AdvTree.AdvTree
    Friend WithEvents Node2 As DevComponents.AdvTree.Node
    Friend WithEvents rep_checksex_b As DevComponents.AdvTree.Node
    Friend WithEvents NodeConnector2 As DevComponents.AdvTree.NodeConnector
    Friend WithEvents ElementStyle2 As DevComponents.DotNetBar.ElementStyle
    Friend WithEvents ExpandableSplitter1 As DevComponents.DotNetBar.ExpandableSplitter
    Friend WithEvents Node5 As DevComponents.AdvTree.Node
    Friend WithEvents reportData_table As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
