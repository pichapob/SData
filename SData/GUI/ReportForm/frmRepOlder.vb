Public Class frmRepOlder
    Dim sqlf As New SQLManager
    Dim keyin As Boolean = False
    Dim data As DataTable
    Private Sub older_report_1_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles older_report_1_b.NodeDoubleClick
        OlderRep1()
    End Sub

    Private Sub older_report_2_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles older_report_2_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        OlderRep2()
    End Sub

    Public Sub OlderRep1()
        Cursor = Cursors.WaitCursor
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        report_title_tf.Text = older_report_1_b.Text
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname," & _
        "p.birthdate,TIMESTAMPDIFF(YEAR,p.birthdate,NOW()) AS age,h.address,v.village_moo," & _
        "v.village_name,tha.full_name,ppsp.vstdate,ppsp.pp_special_code,ppsp.pp_special_type_name " & _
        "FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id " & _
        "LEFT JOIN house h ON p.house_id = h.house_id " & _
        "LEFT JOIN village v ON h.village_id = v.village_id " & _
        "LEFT JOIN nationality n ON p.nationality =  n.nationality " & _
        "LEFT JOIN thaiaddress tha ON tha.addressid = v.address_id " & _
        "LEFT JOIN patient pt ON p.cid = pt.cid " & _
        "LEFT JOIN (" & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name " & _
        "	FROM pp_special pp " & _
        "	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id " & _
        "	INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1280','1B1281','1B1282') AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' " & _
        "	GROUP BY o.hn " & _
        "   HAVING(MAX(vstdate)) " & _
        ") AS ppsp ON pt.hn = ppsp.hn " & _
        "WHERE hrt.export_code IN(1,3) " & _
        "AND n.nhso_code IN('099') " & _
        "AND p.person_discharge_id = 9 " & _
        "AND TIMESTAMPDIFF(YEAR,p.birthdate,'" & (SharingEntrities.year_set - 1) & "-10-01') >= 60 "

        data = sqlf.QueryAsDatatable(sql)
        Dim br_score As New DataColumn("BRSCORE", GetType(Image))
        data.Columns.Add(br_score)
        Dim total As Integer = 0
        Dim screen As Integer = 0
        Dim g1 As Integer = 0
        Dim g2 As Integer = 0
        Dim g3 As Integer = 0

        For i = 0 To data.Rows.Count - 1
            total += 1
            If data.Rows(i).Item("vstdate").ToString <> "" Then
                screen += 1
                data.Rows(i).Item("BRSCORE") = My.Resources.check16
                If data.Rows(i).Item("pp_special_code").ToString = "1B1280" Then
                    g1 += 1
                ElseIf data.Rows(i).Item("pp_special_code").ToString = "1B1281" Then
                    g2 += 1
                ElseIf data.Rows(i).Item("pp_special_code").ToString = "1B1282" Then
                    g3 += 1
                End If
            Else
                data.Rows(i).Item("BRSCORE") = My.Resources.cross16
            End If


        Next
        reportData_table.DataSource = data
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("age").HeaderText = "อายุ"
        reportData_table.Columns("vstdate").HeaderText = "วันที่รับบริการ"
        reportData_table.Columns("pp_special_type_name").HeaderText = "ชื่อกิจกรรมเฉพาะ"
        reportData_table.Columns("pp_special_code").HeaderText = "รหัสกิจกรรมเฉพาะ"
        status_tf.Text = "จำนวนผู้สูงอายุ = " & total & " คน ได้รับการประเมิน = " & screen & " คน,กลุ่มติดบ้าน = " & g3 & " คน,กลุ่มติดเตียง = " & g2 & " คน,กลุ่มติดสังคม = " & g1 & " คน"
        keyin = False
        Cursor = Cursors.Default
    End Sub

    Public Sub OlderRep2()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = older_report_2_b.Text
        Dim sql = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname," & _
        "p.birthdate,TIMESTAMPDIFF(YEAR,p.birthdate,NOW()) AS age,h.address,v.village_moo," & _
        "v.village_name,tha.full_name," & _
        "pp2q.vstdate AS 2q_date,pp2q.pp_special_code AS 2q_code,pp2q.pp_special_type_name AS 2q_name," & _
        "fall.vstdate AS fall_date,fall.pp_special_code AS fall_code,fall.pp_special_type_name AS fall_name," & _
        "amt.vstdate AS amt_date,amt.pp_special_code AS amt_code,amt.pp_special_type_name AS amt_name," & _
        "eyen.vstdate AS eyen_date,eyen.pp_special_code AS eyen_code,eyen.pp_special_type_name AS eyen_name," & _
        "eyel.vstdate AS eyel_date,eyel.pp_special_code AS eyel_code,eyel.pp_special_type_name AS eyel_name," & _
        "eyetor.vstdate AS eyetor_date,eyetor.pp_special_code AS eyetor_code,eyetor.pp_special_type_name AS eyetor_name," & _
        "eyetorhin.vstdate AS eyetorhin_date,eyetorhin.pp_special_code AS eyetorhin_code,eyetorhin.pp_special_type_name AS eyetorhin_name," & _
        "eyerisk.vstdate AS eyerisk_date,eyerisk.pp_special_code AS eyerisk_code,eyerisk.pp_special_type_name AS eyerisk_name," & _
        "park.vstdate AS park_date, park.pp_special_code AS park_code,park.pp_special_type_name AS park_name," & _
        "neck.vstdate AS neck_date, neck.pp_special_code AS neck_code,neck.pp_special_type_name AS neck_name," & _
        "longterm.vstdate AS longterm_date,longterm.pp_special_code AS longterm_code,longterm.pp_special_type_name AS longterm_name," & _
        "adl.vstdate AS adl_date,adl.pp_special_code AS adl_code,adl.pp_special_type_name AS adl_name," & _
        "passawa.vstdate AS passawa_date,passawa.pp_special_code AS passawa_code,passawa.pp_special_type_name AS passawa_name " & _
        "FROM person p " & _
        "LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id " & _
        "LEFT JOIN house h ON p.house_id = h.house_id " & _
        "LEFT JOIN village v ON h.village_id = v.village_id " & _
        "LEFT JOIN nationality n ON p.nationality =  n.nationality " & _
        "LEFT JOIN thaiaddress tha ON tha.addressid = v.address_id " & _
        "LEFT JOIN patient pt ON p.cid = pt.cid " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id " & _
        "	INNER JOIN ovst o ON o.vn = pp.vn WHERE ppt.pp_special_code IN('1B0280','1B0281') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' GROUP BY o.hn HAVING MAX(vstdate) " & _
        ") AS pp2q ON pt.hn = pp2q.hn " & _
        "LEFT JOIN (" & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp 	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1200','1B1201','1B1202','1B1209') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' GROUP BY o.hn HAVING MAX(vstdate) " & _
        ") AS fall ON pt.hn = fall.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1220','1B1221','1B1223','1B1229') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS amt ON pt.hn = amt.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1240','1B1241','1B1242') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS eyen ON pt.hn = eyen.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1243','1B1244','1B1245') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS eyel ON pt.hn = eyel.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1250','1B1251','1B1252') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' GROUP BY o.hn HAVING MAX(vstdate) " & _
        ") AS eyetor ON pt.hn = eyetor.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name	FROM pp_special pp	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id	INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1253','1B1254','1B1255') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS eyetorhin ON pt.hn = eyetorhin.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1256','1B1257','1B1258') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS eyerisk ON pt.hn = eyerisk.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name	FROM pp_special pp	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id	INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1260','1B1261','1B1269') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS park ON pt.hn = park.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1270','1B1271','1B1272') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS neck ON pt.hn = neck.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name	FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1273','1B1274','1B1275') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS longterm ON pt.hn = longterm.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name FROM pp_special pp 	INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1280','1B1281','1B1282') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS adl ON pt.hn = adl.hn " & _
        "LEFT JOIN ( " & _
        "	SELECT o.hn,o.vstdate,pp.vn,ppt.pp_special_code,ppt.pp_special_type_name	FROM pp_special pp INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id	INNER JOIN ovst o ON o.vn = pp.vn " & _
        "	WHERE ppt.pp_special_code IN('1B1284','1B1285') " & _
        "	AND o.vstdate BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30'	GROUP BY o.hn	HAVING MAX(vstdate) " & _
        ") AS passawa ON pt.hn = passawa.hn " & _
        "WHERE hrt.export_code IN(1,3) AND n.nhso_code IN('099') AND p.person_discharge_id = 9 AND TIMESTAMPDIFF(YEAR,p.birthdate,'" & (SharingEntrities.year_set - 1) & "-10-01') >= 60"
        data = sqlf.QueryAsDatatable(sql)
        Dim br_score As New DataColumn("BRSCORE", GetType(Image))
        data.Columns.Add(br_score)
        Dim total As Integer = 0
        Dim screen As Integer = 0
        For i = 0 To data.Rows.Count - 1
            total += 1
            If data.Rows(i).Item("2q_date").ToString <> "" And
               data.Rows(i).Item("fall_date").ToString <> "" And
               data.Rows(i).Item("amt_date").ToString <> "" And
               data.Rows(i).Item("eyen_date").ToString <> "" And
               data.Rows(i).Item("eyel_date").ToString <> "" And
               data.Rows(i).Item("eyetor_date").ToString <> "" And
               data.Rows(i).Item("eyetorhin_date").ToString <> "" And
               data.Rows(i).Item("eyerisk_date").ToString <> "" And
               data.Rows(i).Item("park_date").ToString <> "" And
               data.Rows(i).Item("neck_date").ToString <> "" And
               data.Rows(i).Item("longterm_date").ToString <> "" And
               data.Rows(i).Item("adl_date").ToString <> "" And
               data.Rows(i).Item("passawa_date").ToString <> "" Then
                data.Rows(i).Item("BRSCORE") = My.Resources.check16
                screen += 1
            Else
                data.Rows(i).Item("BRSCORE") = My.Resources.cross16
            End If
        Next

        reportData_table.DataSource = data
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("age").HeaderText = "อายุ"
        '1) 2Q
        reportData_table.Columns("2q_date").HeaderText = "วันที่คัดกรองซึมเศร้า 2Q"
        reportData_table.Columns("2q_code").HeaderText = "รหัสผลคัดกรองซึมเศร้า 2Q"
        reportData_table.Columns("2q_name").HeaderText = "ชื่อผลคัดกรองซึมเศร้า 2Q"
        '2) หกล้ม
        reportData_table.Columns("fall_date").HeaderText = "วันที่คัดกรองภาวะหกล้ม"
        reportData_table.Columns("fall_code").HeaderText = "รหัสผลคัดกรองภาวะหกล้ม"
        reportData_table.Columns("fall_name").HeaderText = "ชื่อผลคัดกรองภาวะหกล้ม"
        '3) สมรรถภาพสมอง (สมองเสื่อม)
        reportData_table.Columns("amt_date").HeaderText = "วันที่คัดกรองสมรรถภาพสมอง (สมองเสื่อม)"
        reportData_table.Columns("amt_code").HeaderText = "รหัสผลคัดกรองสมรรถภาพสมอง (สมองเสื่อม)"
        reportData_table.Columns("amt_name").HeaderText = "ชื่อผลคัดกรองสมรรถภาพสมอง (สมองเสื่อม)"
        '4) สายตาระยะใกล้
        reportData_table.Columns("eyen_date").HeaderText = "วันที่คัดกรองสายตาระยะใกล้"
        reportData_table.Columns("eyen_code").HeaderText = "รหัสผลคัดกรองสายตาระยะใกล้"
        reportData_table.Columns("eyen_name").HeaderText = "ชื่อผลคัดกรองสายตาระยะใกล้"
        '5) สายตาระยะไกล
        reportData_table.Columns("eyel_date").HeaderText = "วันที่คัดกรองสายตาระยะไกล"
        reportData_table.Columns("eyel_code").HeaderText = "รหัสผลคัดกรองสายตาระยะไกล"
        reportData_table.Columns("eyel_name").HeaderText = "ชื่อผลคัดกรองสายตาระยะไกล"
        '6) ความเสี่ยงต้อกระจก
        reportData_table.Columns("eyetor_date").HeaderText = "วันที่คัดกรองความเสี่ยงต้อกระจก"
        reportData_table.Columns("eyetor_code").HeaderText = "รหัสผลคัดกรองความเสี่ยงต้อกระจก"
        reportData_table.Columns("eyetor_name").HeaderText = "ชื่อผลคัดกรองความเสี่ยงต้อกระจก"
        '7) ความเสี่ยงต้อหิน
        reportData_table.Columns("eyetorhin_date").HeaderText = "วันที่คัดกรองความเสี่ยงต้อหิน"
        reportData_table.Columns("eyetorhin_code").HeaderText = "รหัสผลคัดกรองความเสี่ยงต้อหิน"
        reportData_table.Columns("eyetorhin_name").HeaderText = "ชื่อผลคัดกรองความเสี่ยงต้อหิน"
        '8) ความเสี่ยงประสาทตาเสื่อม
        reportData_table.Columns("eyerisk_date").HeaderText = "วันที่คัดกรองความเสี่ยงประสาทตาเสื่อม"
        reportData_table.Columns("eyerisk_code").HeaderText = "รหัสผลคัดกรองความเสี่ยงประสาทตาเสื่อม"
        reportData_table.Columns("eyerisk_name").HeaderText = "ชื่อผลคัดกรองความเสี่ยงประสาทตาเสื่อม"
        '9) พฤติกรรมเสี่ยงต่อสุขภาพช่องปาก
        reportData_table.Columns("park_date").HeaderText = "วันที่คัดกรองพฤติกรรมเสี่ยงต่อสุขภาพช่องปาก"
        reportData_table.Columns("park_code").HeaderText = "รหัสผลคัดกรองพฤติกรรมเสี่ยงต่อสุขภาพช่องปาก"
        reportData_table.Columns("park_name").HeaderText = "ชื่อผลคัดกรองพฤติกรรมเสี่ยงต่อสุขภาพช่องปาก"
        '10) ข้อเข่าเสื่อม
        reportData_table.Columns("neck_date").HeaderText = "วันที่คัดกรองข้อเข่าเสื่อม"
        reportData_table.Columns("neck_code").HeaderText = "รหัสผลคัดกรองข้อเข่าเสื่อม"
        reportData_table.Columns("neck_name").HeaderText = "ชื่อผลคัดกรองข้อเข่าเสื่อม"
        '11) การดูแลระยะยาว
        reportData_table.Columns("longterm_date").HeaderText = "วันที่คัดกรองการดูแลระยะยาว"
        reportData_table.Columns("longterm_code").HeaderText = "รหัสผลคัดกรองการดูแลระยะยาว"
        reportData_table.Columns("longterm_name").HeaderText = "ชื่อผลคัดกรองการดูแลระยะยาว"
        '12) ความสามารถในการทำกิจวัตรประจำ (ADL)
        reportData_table.Columns("adl_date").HeaderText = "วันที่คัดกรองความสามารถในการทำกิจวัตรประจำ (ADL)"
        reportData_table.Columns("adl_code").HeaderText = "รหัสผลคัดกรองความสามารถในการทำกิจวัตรประจำ (ADL)"
        reportData_table.Columns("adl_name").HeaderText = "ชื่อผลคัดกรองความสามารถในการทำกิจวัตรประจำ (ADL)"
        '13) ภาวะกลั้นปัสสาวะ
        reportData_table.Columns("passawa_date").HeaderText = "วันที่คัดกรองภาวะกลั้นปัสสาวะ"
        reportData_table.Columns("passawa_code").HeaderText = "รหัสผลคัดกรองภาวะกลั้นปัสสาวะ"
        reportData_table.Columns("passawa_name").HeaderText = "ชื่อผลคัดกรองภาวะกลั้นปัสสาวะ"
        status_tf.Text = "จำนวนผู้สูงอายุ = " & total & " คน ได้รับการประเมินครบทุกกิจกรรม = " & screen & " คน"
        keyin = True
        Cursor = Cursors.Default
    End Sub

    Private Sub reportData_table_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles reportData_table.CellDoubleClick
        If keyin And reportData_table.RowCount > 0 Then
            Dim frmsv As New frmSelectVisit
            frmsv.SetCID(reportData_table.Item("cid", e.RowIndex).Value.ToString)
            frmsv.setfrm(Me)
            frmsv.ShowDialog()
        End If

    End Sub

    Private Sub search_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles search_b.Click
        data.DefaultView.RowFilter = "cid LIKE '%" & cid_find_tf.Text & "%' OR fullname LIKE '%" & cid_find_tf.Text & "%'"
    End Sub

    Private Sub cid_find_tf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cid_find_tf.TextChanged
        If cid_find_tf.Text.Length = 0 Then
            data.DefaultView.RowFilter = ""
        End If
    End Sub
End Class