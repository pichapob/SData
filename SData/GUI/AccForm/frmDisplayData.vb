Public Class frmDisplayData

    Dim data As New DataTable
    Public Sub setData(ByVal data As DataTable)
        Me.data = data
    End Sub
    Private Sub frmDisplayData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reportData_table.DataSource = data
    End Sub
End Class