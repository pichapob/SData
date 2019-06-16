<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDisplayData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDisplayData))
        Me.reportData_table = New DevComponents.DotNetBar.Controls.DataGridViewX()
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'reportData_table
        '
        Me.reportData_table.AllowUserToAddRows = False
        Me.reportData_table.AllowUserToDeleteRows = False
        Me.reportData_table.AllowUserToResizeColumns = False
        Me.reportData_table.AllowUserToResizeRows = False
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
        Me.reportData_table.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportData_table.GridColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.reportData_table.HighlightSelectedColumnHeaders = False
        Me.reportData_table.Location = New System.Drawing.Point(0, 0)
        Me.reportData_table.MultiSelect = False
        Me.reportData_table.Name = "reportData_table"
        Me.reportData_table.ReadOnly = True
        Me.reportData_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData_table.Size = New System.Drawing.Size(725, 396)
        Me.reportData_table.TabIndex = 13
        '
        'frmDisplayData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 396)
        Me.Controls.Add(Me.reportData_table)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDisplayData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDisplayData"
        CType(Me.reportData_table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportData_table As DevComponents.DotNetBar.Controls.DataGridViewX
End Class
