Public Class frmGetQuarter

    Private Sub frmGetQuarter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim y As Integer = Date.Now.Year
        Dim m As Integer = Date.Now.Month
        Dim comboSource As New Dictionary(Of String, String)()
        For i As Integer = 2014 To y + 5
            comboSource.Add(i.ToString, i + 543)
        Next
        year_set_tf.DataSource = New BindingSource(comboSource, Nothing)
        year_set_tf.DisplayMember = "Value"
        year_set_tf.ValueMember = "Key"

        If m >= 10 Then
            year_set_tf.SelectedValue = (y + 1).ToString
        Else
            year_set_tf.SelectedValue = y.ToString
        End If

    End Sub

    Private Sub OK_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_B.Click
        If year_set_tf.SelectedValue > 2500 Then
            SharingEntrities.year_set = year_set_tf.SelectedValue - 543
        Else
            SharingEntrities.year_set = year_set_tf.SelectedValue
        End If
        MessageBox.Show(SharingEntrities.year_set)
        Dispose()
    End Sub
End Class