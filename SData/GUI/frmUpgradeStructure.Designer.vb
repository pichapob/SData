<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpgradeStructure
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpgradeStructure))
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.upgradeb = New DevComponents.DotNetBar.ButtonX()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.upgrade_progres = New DevComponents.DotNetBar.Controls.ProgressBarX()
        Me.upgradeStatustf = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.upgradeStructureWorker = New System.ComponentModel.BackgroundWorker()
        Me.PanelEx1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelEx1
        '
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.upgradeb)
        Me.PanelEx1.Controls.Add(Me.GroupBox1)
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(546, 322)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.PanelEx1.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 3
        '
        'upgradeb
        '
        Me.upgradeb.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.upgradeb.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.upgradeb.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.upgradeb.Location = New System.Drawing.Point(9, 282)
        Me.upgradeb.Name = "upgradeb"
        Me.upgradeb.Size = New System.Drawing.Size(164, 32)
        Me.upgradeb.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.upgradeb.TabIndex = 1
        Me.upgradeb.Text = "Upgrade Structure"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.upgrade_progres)
        Me.GroupBox1.Controls.Add(Me.upgradeStatustf)
        Me.GroupBox1.Font = New System.Drawing.Font("TH SarabunPSK", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(540, 273)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "สถานะ"
        '
        'upgrade_progres
        '
        Me.upgrade_progres.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.upgrade_progres.BackgroundStyle.Class = ""
        Me.upgrade_progres.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.upgrade_progres.Location = New System.Drawing.Point(6, 253)
        Me.upgrade_progres.Name = "upgrade_progres"
        Me.upgrade_progres.Size = New System.Drawing.Size(528, 14)
        Me.upgrade_progres.TabIndex = 1
        Me.upgrade_progres.Text = "ProgressBarX1"
        '
        'upgradeStatustf
        '
        Me.upgradeStatustf.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.upgradeStatustf.Border.Class = "TextBoxBorder"
        Me.upgradeStatustf.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.upgradeStatustf.Location = New System.Drawing.Point(6, 28)
        Me.upgradeStatustf.Multiline = True
        Me.upgradeStatustf.Name = "upgradeStatustf"
        Me.upgradeStatustf.ReadOnly = True
        Me.upgradeStatustf.Size = New System.Drawing.Size(528, 219)
        Me.upgradeStatustf.TabIndex = 0
        '
        'upgradeStructureWorker
        '
        Me.upgradeStructureWorker.WorkerSupportsCancellation = True
        '
        'frmUpgradeStructure
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 322)
        Me.Controls.Add(Me.PanelEx1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpgradeStructure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Upgrade Structure"
        Me.PanelEx1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents upgradeb As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents upgrade_progres As DevComponents.DotNetBar.Controls.ProgressBarX
    Friend WithEvents upgradeStatustf As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents upgradeStructureWorker As System.ComponentModel.BackgroundWorker
End Class
