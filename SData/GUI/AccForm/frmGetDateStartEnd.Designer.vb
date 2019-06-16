<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGetDateStartEnd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGetDateStartEnd))
        Me.PanelEx5 = New DevComponents.DotNetBar.PanelEx()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.OK_B = New DevComponents.DotNetBar.ButtonX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.enddate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.begindate_tf = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelEx5.Size = New System.Drawing.Size(420, 30)
        Me.PanelEx5.Style.BackColor1.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.BackColor2.Color = System.Drawing.Color.Gray
        Me.PanelEx5.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx5.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx5.Style.ForeColor.Color = System.Drawing.Color.White
        Me.PanelEx5.Style.GradientAngle = 90
        Me.PanelEx5.TabIndex = 13
        Me.PanelEx5.Text = "  เลือกช่วงวันที่"
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 30)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(420, 60)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 14
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
        Me.LabelX1.Size = New System.Drawing.Size(39, 32)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "วันที่"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.enddate_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX2)
        Me.GroupBox1.Controls.Add(Me.begindate_tf)
        Me.GroupBox1.Controls.Add(Me.LabelX1)
        Me.GroupBox1.Controls.Add(Me.OK_B)
        Me.GroupBox1.Location = New System.Drawing.Point(3, -3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(414, 60)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
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
        Me.enddate_tf.Location = New System.Drawing.Point(194, 19)
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
        Me.enddate_tf.Size = New System.Drawing.Size(120, 28)
        Me.enddate_tf.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.enddate_tf.TabIndex = 9
        Me.enddate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'LabelX2
        '
        '
        '
        '
        Me.LabelX2.BackgroundStyle.Class = ""
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.LabelX2.Location = New System.Drawing.Point(164, 20)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(24, 27)
        Me.LabelX2.TabIndex = 8
        Me.LabelX2.Text = "ถึง"
        Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Center
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
        Me.begindate_tf.Location = New System.Drawing.Point(43, 19)
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
        Me.begindate_tf.TabIndex = 7
        Me.begindate_tf.Value = New Date(2017, 10, 3, 21, 54, 3, 0)
        '
        'frmGetDateStartEnd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 90)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelEx1)
        Me.Controls.Add(Me.PanelEx5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGetDateStartEnd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เลือกช่วงเวลา"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.enddate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.begindate_tf, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx5 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents OK_B As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents enddate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents begindate_tf As DevComponents.Editors.DateTimeAdv.DateTimeInput
End Class
