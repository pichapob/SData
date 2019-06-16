<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConnectionSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmConnectionSetting))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.port_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.password_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.user_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.dbname_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.host_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.LabelX6 = New DevComponents.DotNetBar.LabelX()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.test_connection_b = New DevComponents.DotNetBar.ButtonX()
        Me.ok_b = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.Panel1)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(521, 271)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 0
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(521, 31)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.DimGray
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.Silver
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 20
        '
        'LabelX5
        '
        '
        '
        '
        Me.LabelX5.BackgroundStyle.Class = ""
        Me.LabelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX5.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX5.ForeColor = System.Drawing.Color.White
        Me.LabelX5.Location = New System.Drawing.Point(1, 3)
        Me.LabelX5.Name = "LabelX5"
        Me.LabelX5.Size = New System.Drawing.Size(163, 28)
        Me.LabelX5.TabIndex = 2
        Me.LabelX5.Text = "  ตั้งค่าการเชื่อมต่อฐานข้อมูล"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.port_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX3)
        Me.GroupBox1.Controls.Add(Me.password_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.user_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.dbname_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX4)
        Me.GroupBox1.Controls.Add(Me.host_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX6)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(515, 198)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.SData.My.Resources.Resources.database_config
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(19, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(140, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'port_tf
        '
        '
        '
        '
        Me.port_tf.Border.Class = "TextBoxBorder"
        Me.port_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.port_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.port_tf.Location = New System.Drawing.Point(242, 156)
        Me.port_tf.Name = "port_tf"
        Me.port_tf.Size = New System.Drawing.Size(165, 32)
        Me.port_tf.TabIndex = 15
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(165, 20)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(74, 27)
        Me.LabelX3.TabIndex = 6
        Me.LabelX3.Text = "Host : "
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'password_tf
        '
        '
        '
        '
        Me.password_tf.Border.Class = "TextBoxBorder"
        Me.password_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.password_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.password_tf.Location = New System.Drawing.Point(242, 121)
        Me.password_tf.Name = "password_tf"
        Me.password_tf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tf.Size = New System.Drawing.Size(165, 32)
        Me.password_tf.TabIndex = 14
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.Location = New System.Drawing.Point(165, 53)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(74, 27)
        Me.LabelX1.TabIndex = 7
        Me.LabelX1.Text = "Database : "
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'user_tf
        '
        '
        '
        '
        Me.user_tf.Border.Class = "TextBoxBorder"
        Me.user_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.user_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.user_tf.Location = New System.Drawing.Point(242, 85)
        Me.user_tf.Name = "user_tf"
        Me.user_tf.Size = New System.Drawing.Size(165, 32)
        Me.user_tf.TabIndex = 13
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(165, 87)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(74, 27)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "User : "
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dbname_tf
        '
        '
        '
        '
        Me.dbname_tf.Border.Class = "TextBoxBorder"
        Me.dbname_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dbname_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.dbname_tf.Location = New System.Drawing.Point(242, 51)
        Me.dbname_tf.Name = "dbname_tf"
        Me.dbname_tf.Size = New System.Drawing.Size(264, 32)
        Me.dbname_tf.TabIndex = 12
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(165, 118)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(74, 27)
        Me.LabelX4.TabIndex = 9
        Me.LabelX4.Text = "Password : "
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'host_tf
        '
        '
        '
        '
        Me.host_tf.Border.Class = "TextBoxBorder"
        Me.host_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.host_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.host_tf.Location = New System.Drawing.Point(242, 17)
        Me.host_tf.Name = "host_tf"
        Me.host_tf.Size = New System.Drawing.Size(264, 32)
        Me.host_tf.TabIndex = 11
        '
        'LabelX6
        '
        '
        '
        '
        Me.LabelX6.BackgroundStyle.Class = ""
        Me.LabelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX6.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX6.Location = New System.Drawing.Point(165, 153)
        Me.LabelX6.Name = "LabelX6"
        Me.LabelX6.Size = New System.Drawing.Size(74, 27)
        Me.LabelX6.TabIndex = 10
        Me.LabelX6.Text = "Port : "
        Me.LabelX6.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.test_connection_b)
        Me.Panel1.Controls.Add(Me.ok_b)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 228)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(521, 43)
        Me.Panel1.TabIndex = 22
        '
        'test_connection_b
        '
        Me.test_connection_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.test_connection_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.test_connection_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.test_connection_b.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.test_connection_b.Location = New System.Drawing.Point(290, 5)
        Me.test_connection_b.Name = "test_connection_b"
        Me.test_connection_b.Size = New System.Drawing.Size(140, 30)
        Me.test_connection_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.test_connection_b.TabIndex = 24
        Me.test_connection_b.Text = "ทดสอบการเชื่อมต่อ"
        '
        'ok_b
        '
        Me.ok_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ok_b.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ok_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ok_b.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.ok_b.Location = New System.Drawing.Point(436, 5)
        Me.ok_b.Name = "ok_b"
        Me.ok_b.Size = New System.Drawing.Size(75, 30)
        Me.ok_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ok_b.TabIndex = 23
        Me.ok_b.Text = "ตกลง"
        '
        'frmConnectionSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 271)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConnectionSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Setting"
        Me.PanelEx1.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents port_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents password_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents user_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dbname_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents host_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents LabelX6 As DevComponents.DotNetBar.LabelX
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents test_connection_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ok_b As DevComponents.DotNetBar.ButtonX
End Class
