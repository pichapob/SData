Public Class frmAddSpecialPP
    Private cid As String
    Private vn As String
    Private hn As String
    Private frm As frmRepOlder
    Dim sqlf As New SQLManager
    Public Sub setINFO(ByVal cid As String, ByVal vn As String, ByVal hn As String, ByVal frm As frmRepOlder)
        Me.cid = cid
        Me.vn = vn
        Me.hn = hn
        Me.frm = frm
    End Sub

    Private Sub frmAddSpecialPP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT p.cid,p.hn,CONCAT(p.pname,p.fname,' ',p.lname) AS ptname," & _
        "TIMESTAMPDIFF(YEAR,p.birthday,NOW()) AS age,p.addrpart,p.moopart,th.full_name " & _
        "FROM patient p " & _
        "LEFT JOIN thaiaddress th ON CONCAT(p.chwpart,p.amppart,p.tmbpart) = th.addressid " & _
        "WHERE p.cid = '" & cid & "'"
        Dim di As DataTable = sqlf.QueryAsDatatable(sql)
        If di.Rows.Count > 0 Then
            hn_i_tf.Text = di.Rows(0).Item("hn").ToString
            ptname_i_tf.Text = di.Rows(0).Item("ptname").ToString
            cid_i_tf.Text = di.Rows(0).Item("cid").ToString
            age_i_tf.Text = di.Rows(0).Item("age").ToString
            moo_i_tf.Text = di.Rows(0).Item("moopart").ToString
            address_i_tf.Text = di.Rows(0).Item("addrpart").ToString
            fulladd_i_tf.Text = di.Rows(0).Item("full_name").ToString
        End If
        'สถานที่
        sql = "select * from pp_special_service_place_type"
        di = sqlf.QueryAsDatatable(sql)
        Dim comboSource As New Dictionary(Of String, String)()
        For Each row As DataRow In di.Rows
            comboSource.Add(row("pp_special_service_place_type_id").ToString, row("pp_special_service_place_type_name").ToString)
        Next
        If comboSource.Count > 0 Then
            pp_special_service_place_type_tf.DataSource = New BindingSource(comboSource, Nothing)
            pp_special_service_place_type_tf.DisplayMember = "Value"
            pp_special_service_place_type_tf.ValueMember = "Key"
        End If
        'เจ้าหน้าที่
        sql = "select code,name from doctor order by name"
        di = sqlf.QueryAsDatatable(sql)
        comboSource = New Dictionary(Of String, String)()
        For Each row As DataRow In di.Rows
            comboSource.Add(row("code").ToString, row("name").ToString)
        Next
        If comboSource.Count > 0 Then
            doctor_tf.DataSource = New BindingSource(comboSource, Nothing)
            doctor_tf.DisplayMember = "Value"
            doctor_tf.ValueMember = "Key"
        End If

        sql = "SELECT * FROM ovst o WHERE o.vn = '" & Me.vn & "'"
        di = sqlf.QueryAsDatatable(sql)
        If di.Rows.Count > 0 Then
            vn_tf.Text = di.Rows(0).Item("vn").ToString
            dateserve_tf.Value = di.Rows(0).Item("vstdate").ToString
            doctor_tf.SelectedValue = di.Rows(0).Item("doctor").ToString
        End If

        sql = "SELECT ppt.pp_special_code,ppt.pp_special_type_name,ppspt.pp_special_service_place_type_name,d.`name` AS d_name " & _
        "FROM pp_special pp " & _
        "INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id " & _
        "LEFT JOIN doctor d ON pp.doctor = d.`code` " & _
        "LEFT JOIN pp_special_service_place_type ppspt ON pp.pp_special_service_place_type_id = ppspt.pp_special_service_place_type_id " & _
        "WHERE vn = '" & Me.vn & "'"
        di = sqlf.QueryAsDatatable(sql)
        pp_special_tb.DataSource = di
        For index As Integer = 0 To pp_special_tb.RowCount - 1
            '2Q
            If pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B0280" Then
                pp_1B0280.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B0281" Then
                pp_1B0281.Checked = True
                'fall
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1200" Then
                pp_1B1200.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1201" Then
                pp_1B1201.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1202" Then
                pp_1B1202.Checked = True
                'smong
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1220" Then
                pp_1B1220.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1221" Then
                pp_1B1221.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1223" Then
                pp_1B1223.Checked = True
                'eyen
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1240" Then
                pp_1B1240.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1241" Then
                pp_1B1241.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1242" Then
                pp_1B1242.Checked = True
                'eyel
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1243" Then
                pp_1B1243.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1244" Then
                pp_1B1244.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1245" Then
                pp_1B1245.Checked = True
                'tor krajok
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1250" Then
                pp_1B1250.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1251" Then
                pp_1B1251.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1252" Then
                pp_1B1252.Checked = True
                'tor hin
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1253" Then
                pp_1B1253.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1254" Then
                pp_1B1254.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1255" Then
                pp_1B1255.Checked = True
                'eye risk
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1256" Then
                pp_1B1256.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1257" Then
                pp_1B1257.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1258" Then
                pp_1B1258.Checked = True
                'mount
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1260" Then
                pp_1B1260.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1261" Then
                pp_1B1261.Checked = True
                'neck
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1270" Then
                pp_1B1270.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1271" Then
                pp_1B1271.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1272" Then
                pp_1B1272.Checked = True
                'Long term care
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1273" Then
                pp_1B1273.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1274" Then
                pp_1B1274.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1275" Then
                pp_1B1275.Checked = True
                'ADL
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1280" Then
                pp_1B1280.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1281" Then
                pp_1B1281.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1282" Then
                pp_1B1282.Checked = True
                'ปัสสาวะ
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1284" Then
                pp_1B1284.Checked = True
            ElseIf pp_special_tb.Item("pp_special_code", index).Value.ToString = "1B1285" Then
                pp_1B1285.Checked = True
            End If
        Next


    End Sub

    Private Sub pp_1B0280_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B0280.CheckedChanged
        If pp_1B0280.Checked Then
            Dim rev As String() = {"1B0281"}
            Dim add As String = "1B0280"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub
    Public Sub RemovedAndInsertRow(ByVal rev As String(), ByVal add As String)
        Dim add_ch As Boolean = True
        Dim index As Integer = -1
        For i As Integer = 0 To pp_special_tb.RowCount - 1
            For r As Integer = 0 To rev.Length - 1
                If pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains(rev(r)) Then
                    index = i
                End If
            Next
        Next

        If index > -1 Then
            pp_special_tb.Rows().RemoveAt(index)
        End If
        pp_special_tb.Update()
        For i As Integer = 0 To pp_special_tb.Rows.Count - 1
            If pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains(add) Then
                add_ch = False
            End If
        Next
        If add_ch Then
            Dim sql = "SELECT p.pp_special_code,p.pp_special_type_name," & _
            "(SELECT i.pp_special_service_place_type_name FROM pp_special_service_place_type i WHERE i.pp_special_service_place_type_id = " & pp_special_service_place_type_tf.SelectedValue & ") AS pp_special_service_place_type_name," & _
            "(SELECT d.`name` FROM doctor d WHERE d.`code` = '" & doctor_tf.SelectedValue & "' ) AS d_name " & _
            "FROM pp_special_type p WHERE p.pp_special_code LIKE '" & add & "' "
            Dim dtsp As DataTable = sqlf.QueryAsDatatable(sql)
            
            If dtsp.Rows.Count > 0 Then
                Dim data As DataTable = pp_special_tb.DataSource
                Dim dr As DataRow = data.NewRow
                dr.Item("pp_special_code") = dtsp.Rows(0).Item("pp_special_code").ToString
                dr.Item("pp_special_type_name") = dtsp.Rows(0).Item("pp_special_type_name").ToString
                dr.Item("pp_special_service_place_type_name") = dtsp.Rows(0).Item("pp_special_service_place_type_name").ToString
                dr.Item("d_name") = dtsp.Rows(0).Item("d_name").ToString
                data.Rows.Add(dr)
                pp_special_tb.DataSource = data
            End If
        End If
    End Sub
   

    Private Sub pp_1B0281_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B0281.CheckedChanged
        If pp_1B0281.Checked Then
            Dim rev As String() = {"1B0280"}
            Dim add As String = "1B0281"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1220_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1220.CheckedChanged
        If pp_1B1220.Checked Then
            Dim rev As String() = {"1B1221", "1B1223"}
            Dim add As String = "1B1220"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1221_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1221.CheckedChanged
        If pp_1B1221.Checked Then
            Dim rev As String() = {"1B1220", "1B1223"}
            Dim add As String = "1B1221"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1223_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1223.CheckedChanged
        If pp_1B1223.Checked Then
            Dim rev As String() = {"1B1220", "1B1221"}
            Dim add As String = "1B1223"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1243_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1243.CheckedChanged
        If pp_1B1243.Checked Then
            Dim rev As String() = {"1B1244", "1B1245"}
            Dim add As String = "1B1243"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1244_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1244.CheckedChanged
        If pp_1B1244.Checked Then
            Dim rev As String() = {"1B1243", "1B1245"}
            Dim add As String = "1B1244"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1245_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1245.CheckedChanged
        If pp_1B1245.Checked Then
            Dim rev As String() = {"1B1243", "1B1244"}
            Dim add As String = "1B1245"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1253_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1253.CheckedChanged
        If pp_1B1253.Checked Then
            Dim rev As String() = {"1B1254", "1B1255"}
            Dim add As String = "1B1253"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1254_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1254.CheckedChanged
        If pp_1B1254.Checked Then
            Dim rev As String() = {"1B1253", "1B1255"}
            Dim add As String = "1B1254"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1255_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1255.CheckedChanged
        If pp_1B1255.Checked Then
            Dim rev As String() = {"1B1253", "1B1254"}
            Dim add As String = "1B1255"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1260_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1260.CheckedChanged
        If pp_1B1260.Checked Then
            Dim rev As String() = {"1B1261"}
            Dim add As String = "1B1260"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1261_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1261.CheckedChanged
        If pp_1B1261.Checked Then
            Dim rev As String() = {"1B1260"}
            Dim add As String = "1B1261"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1273_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1273.CheckedChanged
        If pp_1B1273.Checked Then
            Dim rev As String() = {"1B1274", "1B1275"}
            Dim add As String = "1B1273"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1274_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1274.CheckedChanged
        If pp_1B1274.Checked Then
            Dim rev As String() = {"1B1273", "1B1275"}
            Dim add As String = "1B1274"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1275_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1275.CheckedChanged
        If pp_1B1275.Checked Then
            Dim rev As String() = {"1B1273", "1B1274"}
            Dim add As String = "1B1275"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1285_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1285.CheckedChanged
        If pp_1B1285.Checked Then
            Dim rev As String() = {"1B1284"}
            Dim add As String = "1B1285"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1284_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1284.CheckedChanged
        If pp_1B1284.Checked Then
            Dim rev As String() = {"1B1285"}
            Dim add As String = "1B1284"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1200_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1200.CheckedChanged
        If pp_1B1200.Checked Then
            Dim rev As String() = {"1B1201", "1B1202"}
            Dim add As String = "1B1200"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1201_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1201.CheckedChanged
        If pp_1B1201.Checked Then
            Dim rev As String() = {"1B1200", "1B1202"}
            Dim add As String = "1B1201"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1202_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1202.CheckedChanged
        If pp_1B1202.Checked Then
            Dim rev As String() = {"1B1200", "1B1201"}
            Dim add As String = "1B1202"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1240_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1240.CheckedChanged
        If pp_1B1240.Checked Then
            Dim rev As String() = {"1B1241", "1B1242"}
            Dim add As String = "1B1240"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1241_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1241.CheckedChanged
        If pp_1B1241.Checked Then
            Dim rev As String() = {"1B1240", "1B1242"}
            Dim add As String = "1B1241"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1242_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1242.CheckedChanged
        If pp_1B1242.Checked Then
            Dim rev As String() = {"1B1240", "1B1241"}
            Dim add As String = "1B1242"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1250_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1250.CheckedChanged
        If pp_1B1250.Checked Then
            Dim rev As String() = {"1B1251", "1B1252"}
            Dim add As String = "1B1250"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1251_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1251.CheckedChanged
        If pp_1B1251.Checked Then
            Dim rev As String() = {"1B1250", "1B1252"}
            Dim add As String = "1B1251"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1252_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1252.CheckedChanged
        If pp_1B1252.Checked Then
            Dim rev As String() = {"1B1250", "1B1251"}
            Dim add As String = "1B1252"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1256_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1256.CheckedChanged
        If pp_1B1256.Checked Then
            Dim rev As String() = {"1B1257", "1B1258"}
            Dim add As String = "1B1256"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1257_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1257.CheckedChanged
        If pp_1B1257.Checked Then
            Dim rev As String() = {"1B1256", "1B1258"}
            Dim add As String = "1B1257"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1258_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1258.CheckedChanged
        If pp_1B1258.Checked Then
            Dim rev As String() = {"1B1256", "1B1257"}
            Dim add As String = "1B1258"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1270_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1270.CheckedChanged
        If pp_1B1270.Checked Then
            Dim rev As String() = {"1B1271", "1B1272"}
            Dim add As String = "1B1270"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1271_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1271.CheckedChanged
        If pp_1B1271.Checked Then
            Dim rev As String() = {"1B1270", "1B1272"}
            Dim add As String = "1B1271"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1272_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1272.CheckedChanged
        If pp_1B1272.Checked Then
            Dim rev As String() = {"1B1270", "1B1271"}
            Dim add As String = "1B1272"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1280_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1280.CheckedChanged
        If pp_1B1280.Checked Then
            Dim rev As String() = {"1B1281", "1B1282"}
            Dim add As String = "1B1280"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1281_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1281.CheckedChanged
        If pp_1B1281.Checked Then
            Dim rev As String() = {"1B1280", "1B1282"}
            Dim add As String = "1B1281"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub pp_1B1282_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pp_1B1282.CheckedChanged
        If pp_1B1282.Checked Then
            Dim rev As String() = {"1B1280", "1B1281"}
            Dim add As String = "1B1282"
            RemovedAndInsertRow(rev, add)
        End If
    End Sub

    Private Sub select_visit_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_visit_b.Click
        If doctor_tf.SelectedValue <> "" And pp_special_service_place_type_tf.SelectedValue <> "" And pp_special_tb.RowCount > 0 Then
            For i As Integer = 0 To pp_special_tb.RowCount - 1
                Dim add As String = ""
                Dim rev As String()
                If pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B0280") Then
                    rev = {"1B0281"}
                    add = "1B0280"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B0281") Then
                    rev = {"1B0280"}
                    add = "1B0281"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1200") Then
                    rev = {"1B1201", "1B1202"}
                    add = "1B1200"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1201") Then
                    rev = {"1B1200", "1B1202"}
                    add = "1B1201"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1202") Then
                    rev = {"1B1200", "1B1201"}
                    add = "1B1202"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1220") Then
                    rev = {"1B1221", "1B1223"}
                    add = "1B1220"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1221") Then
                    rev = {"1B1220", "1B1223"}
                    add = "1B1221"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1223") Then
                    rev = {"1B1220", "1B1221"}
                    add = "1B1223"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1240") Then
                    rev = {"1B1241", "1B1242"}
                    add = "1B1240"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1241") Then
                    rev = {"1B1240", "1B1242"}
                    add = "1B1241"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1242") Then
                    rev = {"1B1240", "1B1241"}
                    add = "1B1242"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1243") Then
                    rev = {"1B1244", "1B1245"}
                    add = "1B1243"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1244") Then
                    rev = {"1B1243", "1B1245"}
                    add = "1B1244"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1245") Then
                    rev = {"1B1243", "1B1244"}
                    add = "1B1245"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1250") Then
                    rev = {"1B1251", "1B1252"}
                    add = "1B1250"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1251") Then
                    rev = {"1B1250", "1B1252"}
                    add = "1B1251"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1252") Then
                    rev = {"1B1250", "1B1251"}
                    add = "1B1252"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1253") Then
                    rev = {"1B1254", "1B1255"}
                    add = "1B1253"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1254") Then
                    rev = {"1B1253", "1B1255"}
                    add = "1B1254"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1255") Then
                    rev = {"1B1253", "1B1254"}
                    add = "1B1255"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1256") Then
                    rev = {"1B1257", "1B1258"}
                    add = "1B1256"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1257") Then
                    rev = {"1B1256", "1B1258"}
                    add = "1B1257"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1258") Then
                    rev = {"1B1256", "1B1257"}
                    add = "1B1258"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1260") Then
                    rev = {"1B1261"}
                    add = "1B1260"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1261") Then
                    rev = {"1B1260"}
                    add = "1B1261"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1270") Then
                    rev = {"1B1271", "1B1272"}
                    add = "1B1270"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1271") Then
                    rev = {"1B1270", "1B1272"}
                    add = "1B1271"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1272") Then
                    rev = {"1B1270", "1B1271"}
                    add = "1B1272"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1273") Then
                    rev = {"1B1274", "1B1275"}
                    add = "1B1273"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1274") Then
                    rev = {"1B1273", "1B1275"}
                    add = "1B1274"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1275") Then
                    rev = {"1B1273", "1B1274"}
                    add = "1B1275"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1280") Then
                    rev = {"1B1281", "1B1282"}
                    add = "1B1280"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1281") Then
                    rev = {"1B1280", "1B1282"}
                    add = "1B1281"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1282") Then
                    rev = {"1B1280", "1B1281"}
                    add = "1B1282"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1284") Then
                    rev = {"1B1285"}
                    add = "1B1284"
                    RemovedAndInsertDB(rev, add)
                ElseIf pp_special_tb.Item("pp_special_code", i).Value.ToString.Contains("1B1285") Then
                    rev = {"1B1284"}
                    add = "1B1285"
                    RemovedAndInsertDB(rev, add)
                End If
            Next
            MessageBox.Show("บันทึกข้อมูลเรียบร้อย")
        Else
            MessageBox.Show("กรุณาเลือกข้อมูล สถานที่ และผู้รักษา")
        End If
        frm.OlderRep2()
        Dispose()
    End Sub
    Public Sub RemovedAndInsertDB(ByVal rev As String(), ByVal add As String)
        Dim condition As String = ""
        For i As Integer = 0 To rev.Length - 1
            condition &= "'" & rev(i) & "',"
        Next
        condition = condition.Substring(0, condition.Length - 1)
        Dim sql As String = "SELECT COUNT(*) AS cc FROM pp_special ps WHERE ps.pp_special_type_id IN( Select pp_special_type_id	FROM pp_special_type pp WHERE pp.pp_special_code IN(" & condition & ")) AND vn = '" & Me.vn & "'"
        Dim rs As DataTable = sqlf.QueryAsDatatable(sql)
        If rs.Rows(0).Item("cc") > 0 Then
            sql = "DELETE FROM pp_special WHERE vn = '" & Me.vn & "' AND pp_special_type_id IN(SELECT pp_special_type_id	FROM pp_special_type pp WHERE pp.pp_special_code IN(" & condition & "))"
            sqlf.Excute(sql)
        End If
        sql = "SELECT COUNT(*) AS cc FROM pp_special ps WHERE ps.pp_special_type_id IN( Select pp_special_type_id	FROM pp_special_type pp WHERE pp.pp_special_code IN('" & add & "')) AND vn = '" & Me.vn & "'"
        rs = sqlf.QueryAsDatatable(sql)
        If rs.Rows(0).Item("cc") = 0 Then
            sql = "SELECT get_serialnumber('pp_special_id') AS cc"
            rs = sqlf.QueryAsDatatable(sql)
            Dim serail As String = rs.Rows(0).Item("cc").ToString
            sql = "SELECT pst.pp_special_type_id from pp_special_type pst WHERE pst.pp_special_code like '" & add & "'"
            rs = sqlf.QueryAsDatatable(sql)
            Dim pp_special_type_id As String = rs.Rows(0).Item("pp_special_type_id").ToString
            sql = "SELECT o.hospitalcode FROM opdconfig o limit 1"
            rs = sqlf.QueryAsDatatable(sql)
            Dim hospcode As String = rs.Rows(0).Item("hospitalcode").ToString

            sql = "INSERT INTO pp_special(pp_special_id,vn,pp_special_type_id,doctor,pp_special_service_place_type_id,entry_datetime,dest_hospcode) VALUES(" & _
            "'" & serail & "'," & _
            "'" & Me.vn & "'," & _
            "'" & pp_special_type_id & "'," & _
            "'" & doctor_tf.SelectedValue & "'," & _
            "'" & pp_special_service_place_type_tf.SelectedValue & "'," & _
            "now()," & _
            "'" & hospcode & "')"
            sqlf.Excute(sql)
        End If
    End Sub
End Class