Imports System.IO

Public Class frmUpgradeStructure
    Dim sql As String
    Dim sqlf As New SQLManager
    Private Sub upgradeStructureWorker_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles upgradeStructureWorker.DoWork
        Dim fileEntries() As String = Directory.GetFiles(CurDir() & "\DB", "*.sql")
        upgrade_progres.Maximum = fileEntries.Length - 1
        For index As Integer = 0 To fileEntries.Length - 1
            Dim filename As String = fileEntries(index).Split("\")(fileEntries(index).Split("\").Length - 1)
            Me.upgradeStatustf.AppendText("Update Table " & filename.Replace(".sql", "") & vbNewLine)
            If File.Exists(CurDir() & "\DB\" & filename) Then
                sql = File.OpenText(CurDir() & "\DB\" & filename).ReadToEnd()
                sqlf.Excute(sql)
            End If
            upgradeStatustf.AppendText("Update Table " & filename.Replace(".sql", "") & " Success" & vbNewLine)
            upgrade_progres.Value = index + 1
        Next
    End Sub

    Private Sub upgradeb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles upgradeb.Click
        upgradeStructureWorker.RunWorkerAsync()
    End Sub

    Private Sub upgradeStructureWorker_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles upgradeStructureWorker.RunWorkerCompleted
        MessageBox.Show("Upgrade Success", "SData Message")
    End Sub
End Class