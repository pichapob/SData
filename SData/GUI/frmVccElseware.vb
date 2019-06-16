Imports System.Net
Imports System.IO
Imports Newtonsoft.Json.Linq

Public Class frmVccElseware
    Public pid As String
    Public RepId As Integer
    Dim sqlf As New SQLManager
    Public Sub set_pid(ByVal person_id As String)
        Me.pid = person_id
    End Sub
    Public Sub set_RepID(ByVal id As Integer)
        Me.RepId = id
    End Sub
    Public Sub reload_vcc()
        Dim sql As String = "SELECT p.person_vaccine_elsewhere_id,p.vaccine_date,pv.vaccine_name,CONCAT(h.hosptype,h.`name`) hospcode FROM person_vaccine_elsewhere p LEFT JOIN hospcode h ON h.hospcode = p.hospcode LEFT JOIN person_vaccine pv ON p.person_vaccine_id = pv.person_vaccine_id  WHERE p.person_id = '" & pid & "'"
        Dim data As DataTable = sqlf.QueryAsDatatable(sql)
        Data_table.DataSource = data
    End Sub
    Private Sub frmVccElseware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reload_vcc()
    End Sub

    Private Sub vccinsert_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vccinsert_b.Click
        Dim inc As New frmVccelsewareInsert
        Dim vcccode As String
        If RepId = 1 Then
            vcccode = "'010','041','091','D51','H31','033','093','D13','D23','D33','D43','D53','043','093','H33','D23','D53','083','D33','D43','D53','I13','061','M11','401','D32','D42','D52','I12'"
            inc.set_vcccode(vcccode)
        ElseIf RepId = 2 Then
            vcccode = "'034','D14','D24','D34','D44','D54','084','D34','D44','D54','I14','051','052','J11'"
            inc.set_vcccode(vcccode)
        End If

        inc.set_pid(pid)
        inc.setfrm(Me)
        inc.ShowDialog()
    End Sub

    Private Sub del_vcc_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles del_vcc_b.Click
        Dim vccew_id As String = Data_table.Item("person_vaccine_elsewhere_id", Data_table.CurrentRow.Index).Value.ToString()
        If vccew_id <> "" Then
            Dim conf As Integer = MessageBox.Show("ยืนยันการลบข้อมูล", "SData Alert", MessageBoxButtons.OKCancel)
            If conf = DialogResult.OK Then
                Dim sql As String = "DELETE FROM person_vaccine_elsewhere WHERE person_vaccine_elsewhere_id = " & vccew_id
                If sqlf.Excute(sql) Then
                    MessageBox.Show("ลบข้อมูลเรียบร้อย", "SData Alert")
                    reload_vcc()
                End If
            End If
        End If

    End Sub

    Private Sub sync_epi_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sync_epi_b.Click
        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim reader As StreamReader
        Dim sql As String = "SELECT *  FROM person p where p.person_id = '" & Me.pid & "'"
        Dim ps = sqlf.QueryAsDatatable(sql)
        If ps.Rows.Count > 0 Then
            request = DirectCast(WebRequest.Create(SharingEntrities.url_epi & "method=GetEPICID&cid=" & ps.Rows(0).Item("cid").ToString), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String = reader.ReadToEnd()
            Dim jResults As JObject = JObject.Parse(rawresp)
            Dim export_code As String = ""
            If jResults("DATA").ToString <> "" Then
                For Each token As JToken In jResults("DATA")
                    sql = "SELECT COUNT(*) AS cc FROM ( " & _
                    "	SELECT p.cid FROM person p 	INNER JOIN person_wbc pw ON p.person_id = pw.person_id " & _
                    "	INNER JOIN person_wbc_service pws ON pw.person_wbc_id = pws.person_wbc_id 	INNER JOIN person_wbc_vaccine_detail pwvd ON pws.person_wbc_service_id = pwvd.person_wbc_service_id 	INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id " & _
                    "	WHERE p.cid = '" & ps.Rows(0).Item("cid").ToString & "' AND wv.export_vaccine_code IN('" & token("export_vaccine_code").ToString & "') " & _
                    "	UNION ALL " & _
                    "	SELECT p.cid 	FROM person p 	INNER JOIN person_epi pe ON p.person_id = pe.person_id 	INNER JOIN person_epi_vaccine pev ON pe.person_epi_id = pev.person_epi_id 	INNER JOIN person_epi_vaccine_list pevl ON pev.person_epi_vaccine_id = pevl.person_epi_vaccine_id 	INNER JOIN epi_vaccine ev ON pevl.epi_vaccine_id = ev.epi_vaccine_id " & _
                    "	WHERE p.cid = '" & ps.Rows(0).Item("cid").ToString & "' 	AND export_vaccine_code IN('" & token("export_vaccine_code").ToString & "') " & _
                    "   UNION " & _
                    "	SELECT p.cid 	FROM person p INNER JOIN person_vaccine_elsewhere pve ON p.person_id = pve.person_id 	INNER JOIN person_vaccine pv ON pv.person_vaccine_id = pve.person_vaccine_id " & _
                    "	WHERE p.cid = '" & ps.Rows(0).Item("cid").ToString & "' AND export_vaccine_code IN('" & token("export_vaccine_code").ToString & "') " & _
                    "   UNION " & _
                    "	SELECT pt.cid 	FROM patient pt  	INNER JOIN ovst o ON o.hn = pt.hn 	INNER JOIN ovst_vaccine ov ON o.vn = ov.vn 	INNER JOIN person_vaccine pv ON ov.person_vaccine_id = pv.person_vaccine_id " & _
                    "	WHERE pt.cid = '" & ps.Rows(0).Item("cid").ToString & "' 	AND pv.export_vaccine_code IN('" & token("export_vaccine_code").ToString & "') " & _
                    ") AS t "
                    Console.WriteLine(sql)
                    Dim cc As DataTable = sqlf.QueryAsDatatable(sql)
                    If cc.Rows(0).Item("cc").ToString > 0 Then
                    Else
                        sql = "SELECT p.person_vaccine_id FROM person_vaccine p WHERE p.export_vaccine_code IN('" & token("export_vaccine_code").ToString & "') LIMIT 1"
                        Dim vccitem As DataTable = sqlf.QueryAsDatatable(sql)
                        If vccitem.Rows.Count > 0 Then
                            sql = "SELECT get_serialnumber('person_vaccine_elsewhere_id') cc"
                            Dim rerial As DataTable = sqlf.QueryAsDatatable(sql)
                            Dim serail As String = rerial.Rows(0).Item("cc").ToString
                            sql = "INSERT INTO person_vaccine_elsewhere(person_vaccine_elsewhere_id,person_id,person_vaccine_id,vaccine_date,update_datetime,hospcode,vaccine_hospcode) VALUES('" & serail & "','" & pid & "','" & vccitem.Rows(0).Item("person_vaccine_id").ToString & "','" & token("service_date").ToString & "',NOW(),'" & token("hospcode").ToString & "','" & token("hospcode").ToString & "')"
                            sqlf.Excute(sql)
                            reload_vcc()
                        End If
                    End If
                Next
                MessageBox.Show("ตรวจสอบข้อมูลเรียบร้อย")
            Else
                MessageBox.Show("ไม่มีข้อมูล")
            End If

        End If
    End Sub
End Class