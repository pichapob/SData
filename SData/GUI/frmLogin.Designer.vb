<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.login_b = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx2 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.PanelEx3 = New DevComponents.DotNetBar.PanelEx()
        Me.LabelX5 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX3 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.username_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.password_tf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.cancle_b = New DevComponents.DotNetBar.ButtonX()
        Me.connection_b = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelEx2.SuspendLayout()
        Me.PanelEx3.SuspendLayout()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'login_b
        '
        Me.login_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.login_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.login_b.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.login_b.Location = New System.Drawing.Point(313, 143)
        Me.login_b.Name = "login_b"
        Me.login_b.Size = New System.Drawing.Size(75, 30)
        Me.login_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.login_b.TabIndex = 0
        Me.login_b.Text = "ตกลง"
        '
        'PanelEx2
        '
        Me.PanelEx2.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx2.Controls.Add(Me.LabelX1)
        Me.PanelEx2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelEx2.Location = New System.Drawing.Point(0, 208)
        Me.PanelEx2.Name = "PanelEx2"
        Me.PanelEx2.Size = New System.Drawing.Size(500, 31)
        Me.PanelEx2.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx2.Style.BackColor1.Color = System.Drawing.Color.Silver
        Me.PanelEx2.Style.BackColor2.Color = System.Drawing.Color.DimGray
        Me.PanelEx2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx2.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx2.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx2.Style.GradientAngle = 90
        Me.PanelEx2.TabIndex = 1
        '
        'LabelX1
        '
        '
        '
        '
        Me.LabelX1.BackgroundStyle.Class = ""
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX1.Location = New System.Drawing.Point(3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(497, 23)
        Me.LabelX1.TabIndex = 0
        Me.LabelX1.Text = "Copyright © 2560 By ICT Buriram Province Public Health"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PanelEx3
        '
        Me.PanelEx3.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx3.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx3.Controls.Add(Me.LabelX5)
        Me.PanelEx3.Controls.Add(Me.LabelX2)
        Me.PanelEx3.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx3.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx3.Name = "PanelEx3"
        Me.PanelEx3.Size = New System.Drawing.Size(500, 31)
        Me.PanelEx3.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx3.Style.BackColor1.Color = System.Drawing.Color.DimGray
        Me.PanelEx3.Style.BackColor2.Color = System.Drawing.Color.Silver
        Me.PanelEx3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx3.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx3.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx3.Style.GradientAngle = 90
        Me.PanelEx3.TabIndex = 3
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
        Me.LabelX5.Text = "    กรุณาเข้าสู่ระบบ"
        '
        'LabelX2
        '
        Me.LabelX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelX2.Location = New System.Drawing.Point(313, 3)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(179, 28)
        Me.LabelX2.TabIndex = 1
        Me.LabelX2.Text = "SData : Hospital Information"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX3
        '
        '
        '
        '
        Me.LabelX3.BackgroundStyle.Class = ""
        Me.LabelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX3.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX3.Location = New System.Drawing.Point(184, 54)
        Me.LabelX3.Name = "LabelX3"
        Me.LabelX3.Size = New System.Drawing.Size(75, 27)
        Me.LabelX3.TabIndex = 4
        Me.LabelX3.Text = "ชื่อผู้ใช้งาน : "
        Me.LabelX3.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'LabelX4
        '
        '
        '
        '
        Me.LabelX4.BackgroundStyle.Class = ""
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX4.Location = New System.Drawing.Point(184, 96)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(75, 27)
        Me.LabelX4.TabIndex = 5
        Me.LabelX4.Text = "รหัสผู้ใช้งาน : "
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'username_tf
        '
        '
        '
        '
        Me.username_tf.Border.Class = "TextBoxBorder"
        Me.username_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.username_tf.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.username_tf.Location = New System.Drawing.Point(265, 54)
        Me.username_tf.Name = "username_tf"
        Me.username_tf.Size = New System.Drawing.Size(204, 33)
        Me.username_tf.TabIndex = 6
        '
        'password_tf
        '
        '
        '
        '
        Me.password_tf.Border.Class = "TextBoxBorder"
        Me.password_tf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.password_tf.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.password_tf.Location = New System.Drawing.Point(265, 92)
        Me.password_tf.Name = "password_tf"
        Me.password_tf.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password_tf.Size = New System.Drawing.Size(204, 32)
        Me.password_tf.TabIndex = 7
        '
        'cancle_b
        '
        Me.cancle_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cancle_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cancle_b.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.cancle_b.Location = New System.Drawing.Point(394, 143)
        Me.cancle_b.Name = "cancle_b"
        Me.cancle_b.Size = New System.Drawing.Size(75, 30)
        Me.cancle_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cancle_b.TabIndex = 8
        Me.cancle_b.Text = "ยกเลิก"
        '
        'connection_b
        '
        Me.connection_b.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.connection_b.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.connection_b.Font = New System.Drawing.Font("Angsana New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.connection_b.Location = New System.Drawing.Point(203, 143)
        Me.connection_b.Name = "connection_b"
        Me.connection_b.Size = New System.Drawing.Size(104, 30)
        Me.connection_b.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.connection_b.TabIndex = 9
        Me.connection_b.Text = "การเชื่อมต่อ"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.connection_b)
        Me.PanelEx1.Controls.Add(Me.cancle_b)
        Me.PanelEx1.Controls.Add(Me.password_tf)
        Me.PanelEx1.Controls.Add(Me.username_tf)
        Me.PanelEx1.Controls.Add(Me.LabelX4)
        Me.PanelEx1.Controls.Add(Me.LabelX3)
        Me.PanelEx1.Controls.Add(Me.PanelEx3)
        Me.PanelEx1.Controls.Add(Me.PictureBox1)
        Me.PanelEx1.Controls.Add(Me.PanelEx2)
        Me.PanelEx1.Controls.Add(Me.login_b)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(500, 239)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.Image = Global.SData.My.Resources.Resources.login
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(12, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(150, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 239)
        Me.Controls.Add(Me.PanelEx1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelEx2.ResumeLayout(False)
        Me.PanelEx3.ResumeLayout(False)
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents login_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx2 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents PanelEx3 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents LabelX5 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX3 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents username_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents password_tf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents cancle_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents connection_b As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
