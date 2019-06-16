Imports System.Globalization

Public Class frmExport50F
    Dim person As New DataTable
    Dim chronic As New DataTable
    Dim epi As New DataTable
    Dim anc As New DataTable
    Dim specialpp As New DataTable
    Private Sub brows_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles brows_b.Click
        Dim fselecte As New FolderBrowserDialog
        If (fselecte.ShowDialog() = DialogResult.OK) Then
            export_path_tf.Text = fselecte.SelectedPath
        End If
    End Sub

    Private Sub Export53tb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export53tb.Click
        reportData_table.Rows.Clear()
        Dim startdate As String = begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
        Dim enddate As String = enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))

        
        Dim id_tb As Integer = 1
        Dim pid As String = ""
        'CHRONIC
        If chronic_ch.Checked Then
            Dim chrx As New CHRONICEx
            If allpp_ch.Checked Then
                chronic = chrx.ExportChronicAll()
            Else
                If d_update_ch.Checked Then
                    chronic = chrx.ExportChronicUpdate(startdate, enddate)
                ElseIf date_serv_ch.Checked Then
                    chronic = chrx.ExportChronicWithDateServ(startdate, enddate)
                End If
            End If
            For i As Integer = 0 To chronic.Rows.Count - 1
                pid &= chronic.Rows(i).Item("PID").ToString & ","
            Next
            reportData_table.Rows.Add(id_tb, "CHRONIC", chronic.Rows.Count)
            id_tb += 1
        End If
        'EPI
        If epi_ch.Checked Then
            Dim epiex As New EPIEx
            If d_update_ch.Checked Then
                epi = epiex.ExportEPIWithDUpdate(startdate, enddate)
            ElseIf date_serv_ch.Checked Then
                epi = epiex.ExportEPIWithDateserv(startdate, enddate)
            End If
            For i As Integer = 0 To epi.Rows.Count - 1
                pid &= epi.Rows(i).Item("PID").ToString & ","
            Next
            reportData_table.Rows.Add(id_tb, "EPI", epi.Rows.Count)
            id_tb += 1
        End If
        'ANC
        If anc_ch.Checked Then
            Dim ancex As New ANCEx
            If d_update_ch.Checked Then
                anc = ancex.ExportANCWithDUpdate(startdate, enddate)
            ElseIf date_serv_ch.Checked Then
                anc = ancex.ExportANCWithDateserv(startdate, enddate)
            End If
            For i As Integer = 0 To anc.Rows.Count - 1
                pid &= anc.Rows(i).Item("PID").ToString & ","
            Next
            reportData_table.Rows.Add(id_tb, "ANC", anc.Rows.Count)
            id_tb += 1
        End If
        'SPECIALPP
        If specialpp_ch.Checked Then
            Dim specialppex As New SPECIALPPEx
            If d_update_ch.Checked Then
                specialpp = specialppex.ExportSPECIALWithDUpdate(startdate, enddate)
            ElseIf date_serv_ch.Checked Then
                specialpp = specialppex.ExportSPECIALWithDateserv(startdate, enddate)
            End If
            For i As Integer = 0 To specialpp.Rows.Count - 1
                pid &= specialpp.Rows(i).Item("PID").ToString & ","
            Next
            reportData_table.Rows.Add(id_tb, "SPECIALPP", specialpp.Rows.Count)
            id_tb += 1
        End If

        If pid <> "" Then
            pid = pid.Substring(0, pid.Length - 1)
        Else
            pid = "0"
        End If
        'PERSON
        If person_ch.Checked Then
            Dim px As New PERSONEx
            If allpp_ch.Checked Then
                person = px.ExportPersonAll()
            Else
                If d_update_ch.Checked Then
                    person = px.ExportPersonWithPID_Dupdate(pid, startdate, enddate)
                ElseIf date_serv_ch.Checked Then
                    person = px.ExportPersonWithPID_Dateserv(pid, startdate, enddate)
                End If
            End If
            reportData_table.Rows.Add(id_tb, "PERSON", person.Rows.Count)
            id_tb += 1
        End If


        Dim export As New ExportZip43
        export.setPERSON(person)
        export.setANC(anc)
        export.setCHRONIC(chronic)
        export.setEPI(epi)
        export.setSPECIALPP(specialpp)
        export.ExportData(export_path_tf.Text)
        MessageBox.Show("ส่งออกข้อเรียบร้อย")
    End Sub

    Private Sub frmExport50F_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        begindate_tf.Value = Date.Now
        enddate_tf.Value = Date.Now
    End Sub

    Private Sub reportData_table_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles reportData_table.CellDoubleClick
        If reportData_table.Rows.Count > 0 Then
            Dim dis As New frmDisplayData

            If reportData_table.Item("table_name", e.RowIndex).Value.ToString.Contains("PERSON") Then
                dis.setData(person)
            ElseIf reportData_table.Item("table_name", e.RowIndex).Value.ToString.Contains("ANC") Then
                dis.setData(anc)
            ElseIf reportData_table.Item("table_name", e.RowIndex).Value.ToString.Contains("EPI") Then
                dis.setData(epi)
            ElseIf reportData_table.Item("table_name", e.RowIndex).Value.ToString.Contains("SPECIALPP") Then
                dis.setData(specialpp)
            ElseIf reportData_table.Item("table_name", e.RowIndex).Value.ToString.Contains("CHRONIC") Then
                dis.setData(chronic)
            End If
            dis.ShowDialog()
        End If
    End Sub
End Class