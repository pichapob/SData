Public Class frmSelectVisit
    Dim sqlf As New SQLManager
    Dim cid As String = ""
    Dim sql As String
    Dim rebOlder As frmRepOlder
    Public Sub SetCID(ByVal cid_val As String)
        cid = cid_val
    End Sub
    Public Sub setfrm(ByVal frm As frmRepOlder)
        rebOlder = frm
    End Sub
    Private Sub frmSelectVisit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If cid <> "" Then

            sql = "SELECT CONCAT(pt.pname,pt.fname,' ',pt.lname) AS ptname,pt.cid,pt.hn,TIMESTAMPDIFF(YEAR,p.birthdate,NOW()) AS age ,p.person_id " & _
            "FROM patient pt " & _
            "LEFT JOIN person p ON pt.cid = p.cid " & _
            "WHERE pt.cid = '" & cid & "'"
            Dim info As DataTable = sqlf.QueryAsDatatable(sql)
            If info.Rows.Count > 0 Then
                ptname_tf.Text = info.Rows(0).Item("ptname").ToString
                cid_tf.Text = info.Rows(0).Item("cid").ToString
                hn_tf.Text = info.Rows(0).Item("hn").ToString
                age_tf.Text = info.Rows(0).Item("age").ToString
                If info.Rows(0).Item("person_id").ToString <> "" Then
                    sql = "SELECT h.address,v.village_moo,v.village_name,th.full_name " & _
                    "FROM person p " & _
                    "LEFT JOIN house h ON p.house_id = h.house_id " & _
                    "LEFT JOIN village v ON v.village_id = h.village_id " & _
                    "LEFT JOIN thaiaddress th ON v.address_id = th.addressid " & _
                    "WHERE p.cid = '" & cid & "'"
                    Dim addr As DataTable = sqlf.QueryAsDatatable(sql)
                    If addr.Rows.Count > 0 Then
                        full_address_tf.Text = "บ้านเลขที่ " & addr.Rows(0).Item("address").ToString & " หมู่ที่ " & addr.Rows(0).Item("village_moo").ToString
                        full_address_tf.Text &= " " & addr.Rows(0).Item("full_name").ToString
                    End If
                Else
                    sql = "SELECT pt.addrpart,pt.moopart,th.full_name " & _
                    "FROM patient pt " & _
                    "LEFT JOIN thaiaddress th ON CONCAT(pt.chwpart,pt.amppart,pt.tmbpart) = th.addressid " & _
                    "WHERE pt.cid = '" & cid & "'"
                    Dim addr As DataTable = sqlf.QueryAsDatatable(sql)
                    If addr.Rows.Count > 0 Then
                        full_address_tf.Text = "บ้านเลขที่ " & addr.Rows(0).Item("address").ToString & " หมู่ที่ " & addr.Rows(0).Item("moopart").ToString
                        full_address_tf.Text &= " " & addr.Rows(0).Item("full_name").ToString
                    End If
                End If
            End If
            sql = "SELECT o.vn,o.vstdate,pt.cid,os.seq_id,pt.hn," & _
            "t.`name` AS pttype_name,od.cc " & _
            "FROM patient pt " & _
            "INNER JOIN ovst o ON pt.hn = o.hn " & _
            "LEFT JOIN ovst_seq os ON o.vn = os.vn " & _
            "LEFT OUTER JOIN pttype t on t.pttype = o.pttype " & _
            "LEFT JOIN opdscreen od ON o.vn = od.vn " & _
            "WHERE pt.cid = '" & cid & "' " & _
            "AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' " & _
            "ORDER BY o.vstdate DESC LIMIT 20 "
            Console.WriteLine(sql)
            Dim datalist As DataTable = sqlf.QueryAsDatatable(sql)
            visit_list_table.DataSource = datalist
            visit_list_table.Columns("vstdate").HeaderText = "วันที่รับบริการ"
            visit_list_table.Columns("cid").HeaderText = "เลขประจำตัวประชาชน"
            visit_list_table.Columns("seq_id").HeaderText = "SEQ"
            visit_list_table.Columns("hn").HeaderText = "HN"
            visit_list_table.Columns("pttype_name").HeaderText = "สิทธการรักษา"
            visit_list_table.Columns("vn").HeaderText = "Visit Number"
        End If

    End Sub

    Private Sub cancle_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle_b.Click
        Dispose()
    End Sub

    Private Sub select_visit_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles select_visit_b.Click
        If visit_list_table.RowCount > 0 And visit_list_table.CurrentRow.Index >= 0 Then
            'MessageBox.Show(visit_list_table.Item("vn", visit_list_table.CurrentRow.Index).Value.ToString)
            Dim frm As New frmAddSpecialPP
            frm.setINFO(visit_list_table.Item("cid", visit_list_table.CurrentRow.Index).Value.ToString, visit_list_table.Item("vn", visit_list_table.CurrentRow.Index).Value.ToString, visit_list_table.Item("hn", visit_list_table.CurrentRow.Index).Value.ToString, Me.rebOlder)
            frm.ShowDialog()
            Dispose()
        End If
    End Sub
End Class