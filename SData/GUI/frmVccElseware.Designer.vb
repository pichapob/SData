<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVccElseware
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVccElseware))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.sync_epi_b = New DevComponents.DotNetBar.ButtonX()
        Me.del_vcc_b = New DevComponents.DotNetBar.ButtonX()
        Me.vccinsert_b = New DevComponents.DotNetBar.ButtonX()
        Me.Data_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        Me.person_vaccine_elsewhere_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vaccine_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vaccine_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hospcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.vcc_desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1.SuspendLayout()
        CType(Me.Data_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.sync_epi_b)
        Me.PanelEx1.Controls.Add(Me.del_vcc_b)
        Me.PanelEx1.Controls.Add(Me.vccinsert_b)
        Me.PanelEx1.Controls.Add(Me.Data_table)
        Me.PanelEx1.Controls.Add(Me.PanelEx5)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(737, 315)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'sync_epi_b
        '
        Me.sync_epi_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.sync_epi_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.sync_epi_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.sync_epi_b.Image = Global.SData.My.Resources.Resources.sync_icon16
        Me.sync_epi_b.Location = New System.Drawing.Point(190, 280)
        Me.sync_epi_b.Name = "sync_epi_b"
        Me.sync_epi_b.Size = New System.Drawing.Size(182, 30)
        Me.sync_epi_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.sync_epi_b.TabIndex = 18
        Me.sync_epi_b.Text = "ตรวจสอบจาก Data Center"
        '
        'del_vcc_b
        '
        Me.del_vcc_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.del_vcc_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.del_vcc_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.del_vcc_b.Image = Global.SData.My.Resources.Resources.cross16
        Me.del_vcc_b.Location = New System.Drawing.Point(97, 280)
        Me.del_vcc_b.Name = "del_vcc_b"
        Me.del_vcc_b.Size = New System.Drawing.Size(87, 30)
        Me.del_vcc_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.del_vcc_b.TabIndex = 17
        Me.del_vcc_b.Text = "ลบรายการ"
        '
        'vccinsert_b
        '
        Me.vccinsert_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.vccinsert_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.vccinsert_b.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.vccinsert_b.Image = Global.SData.My.Resources.Resources.add16
        Me.vccinsert_b.Location = New System.Drawing.Point(4, 280)
        Me.vccinsert_b.Name = "vccinsert_b"
        Me.vccinsert_b.Size = New System.Drawing.Size(87, 30)
        Me.vccinsert_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.vccinsert_b.TabIndex = 16
        Me.vccinsert_b.Text = "เพิ่มรายการ"
        '
        'Data_table
        '
        Me.Data_table.AllowUserToAddRows = False
        Me.Data_table.AllowUserToDeleteRows = False
        Me.Data_table.AllowUserToResizeColumns = False
        Me.Data_table.AllowUserToResizeRows = False
        Me.Data_table.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Data_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Data_table.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.Data_table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data_table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.Data_table.ColumnHeadersHeight = 25
        Me.Data_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Data_table.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.person_vaccine_elsewhere_id, Me.vaccine_date, Me.vaccine_name, Me.hospcode, Me.vcc_desc})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("TH SarabunPSK", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Data_table.DefaultCellStyle = DataGridViewCellStyle2
        Me.Data_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Data_table.HighlightSelectedColumnHeaders = False
        Me.Data_table.Location = New System.Drawing.Point(3, 32)
        Me.Data_table.MultiSelect = False
        Me.Data_table.Name = "Data_table"
        Me.Data_table.ReadOnly = True
        Me.Data_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Data_table.Size = New System.Drawing.Size(731, 244)
        Me.Data_table.TabIndex = 15
        '
        'person_vaccine_elsewhere_id
        '
        Me.person_vaccine_elsewhere_id.DataPropertyName = "person_vaccine_elsewhere_id"
        Me.person_vaccine_elsewhere_id.HeaderText = "Column1"
        Me.person_vaccine_elsewhere_id.Name = "person_vaccine_elsewhere_id"
        Me.person_vaccine_elsewhere_id.ReadOnly = True
        Me.person_vaccine_elsewhere_id.Visible = False
        '
        'vaccine_date
        '
        Me.vaccine_date.DataPropertyName = "vaccine_date"
        Me.vaccine_date.HeaderText = "วันที่ได้รับ Vaccine"
        Me.vaccine_date.Name = "vaccine_date"
        Me.vaccine_date.ReadOnly = True
        '
        'vaccine_name
        '
        Me.vaccine_name.DataPropertyName = "vaccine_name"
        Me.vaccine_name.HeaderText = "ชื่อ Vaccine"
        Me.vaccine_name.Name = "vaccine_name"
        Me.vaccine_name.ReadOnly = True
        '
        'hospcode
        '
        Me.hospcode.DataPropertyName = "hospcode"
        Me.hospcode.HeaderText = "ได้รับจาก"
        Me.hospcode.Name = "hospcode"
        Me.hospcode.ReadOnly = True
        '
        'vcc_desc
        '
        Me.vcc_desc.HeaderText = "หมายเหตุ"
        Me.vcc_desc.Name = "vcc_desc"
        Me.vcc_desc.ReadOnly = True
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(737, 30)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 14
        Me.PanelEx5.Text = "  วัคซีนที่ได้รับจากที่อื่น"
        '
        'frmVccElseware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 315)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVccElseware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "วัคซีนจากที่อื่น"
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.Data_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Data_table As DevComponents.DotNetBar.Controls.DataGridViewX
    Friend WithEvents person_vaccine_elsewhere_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vaccine_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vaccine_name As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hospcode As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vcc_desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents vccinsert_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents del_vcc_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents sync_epi_b As DevComponents.DotNetBar.ButtonX
End Class
