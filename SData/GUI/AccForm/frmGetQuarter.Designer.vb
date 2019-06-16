<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetQuarter
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGetQuarter))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.OK_B = New DevComponents.DotNetBar.ButtonX()
        Me.year_set_tf = New DevComponents.DotNetBar.Controls.ComboBoxEx()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.PanelEx5)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(437, 87)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx5
        '
        Me.PanelEx5.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx5.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx5.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx5.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.PanelEx5.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx5.Name = "PanelEx5"
        Me.PanelEx5.Size = New System.Drawing.Size(437, 30)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 14
        Me.PanelEx5.Text = "  เลือกปีงบประมาณ"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.year_set_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.OK_B)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 58)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(14, 16)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(76, 32)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "ปีงบประมาณ"
        '
        'OK_B
        '
        Me.OK_B.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.OK_B.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.OK_B.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.OK_B.Location = New System.Drawing.Point(329, 20)
        Me.OK_B.Name = "OK_B"
        Me.OK_B.Size = New System.Drawing.Size(75, 27)
        Me.OK_B.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.OK_B.TabIndex = 0
        Me.OK_B.Text = "ตกลง"
        '
        'year_set_tf
        '
        Me.year_set_tf.DisplayMember = "Text"
        Me.year_set_tf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.year_set_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.year_set_tf.FormattingEnabled = True
        Me.year_set_tf.ItemHeight = 26
        Me.year_set_tf.Location = New System.Drawing.Point(96, 17)
        Me.year_set_tf.Name = "year_set_tf"
        Me.year_set_tf.Size = New System.Drawing.Size(207, 32)
        Me.year_set_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.year_set_tf.TabIndex = 2
        '
        'frmGetQuarter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 87)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGetQuarter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกปีงบประมาณ"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents OK_B As DevComponents.DotNetBar.ButtonX
    Friend WithEvents year_set_tf As DevComponents.DotNetBar.Controls.ComboBoxEx
End Class
