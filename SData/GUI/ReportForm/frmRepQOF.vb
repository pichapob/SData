Public Class frmRepQOF
    Dim sql As String
    Dim sqlf As New SQLManager
    Dim repID As Integer
    Public Sub qof_1_rep()
        Cursor = Cursors.WaitCursor
        repID = 1
        Dim rep As DataTable = Nothing
        reportData_table.DataSource = Nothing
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        Dim stardate As String = SharingEntrities.year_set - 1 & "-04-01"
        Dim enddate As String = SharingEntrities.year_set & "-03-31"
        report_title_tf.Text = "   " & qof_1_b.Text
        Dim age As Integer = 9
        sql = "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 18
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 30
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 42
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        Dim status As New DataColumn("STATUS", GetType(Image))
        rep = sqlf.QueryAsDatatable(sql)
        rep.Columns.Add(status)
        Dim result As Integer = 0
        For i = 0 To rep.Rows.Count - 1
            If rep.Rows(i).Item("SERVICE").ToString <> "" Then
                rep.Rows(i).Item("STATUS") = My.Resources.check16
                result += 1
            Else
                rep.Rows(i).Item("STATUS") = My.Resources.cross16
            End If
        Next

        reportData_table.DataSource = rep
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("START_DATE_SCREEN").HeaderText = "วันเริ้มต้นคัดกรอง"
        reportData_table.Columns("END_DATE_SCREEN").HeaderText = "วันสิ้นสุดการคัดกรอง"
        reportData_table.Columns("sex").HeaderText = "เพศ"
        reportData_table.Columns("AGEGROUP").HeaderText = "กลุ่มอายุ"
        reportData_table.Columns("SERVICE").HeaderText = "วันที่ได้รับคัดกรองในช่วง"
        reportData_table.Columns("STATUS").HeaderText = "สถานะ"
        report_title_tf.Text = report_title_tf.Text & " [เป้าหมาย : " & rep.Rows.Count & ", ผลงาน : " & result & ", ร้อยละ : " & (result * 100 / rep.Rows.Count).ToString("0.00") & " ]"
        Cursor = Cursors.Default
    End Sub
    Public Sub qof_2_rep()
        Cursor = Cursors.WaitCursor
        repID = 2
        report_title_tf.Text = qof_2_b.Text
        Dim rep As DataTable = Nothing
        reportData_table.DataSource = Nothing
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        Dim stardate As String = SharingEntrities.year_set - 1 & "-04-01"
        Dim enddate As String = SharingEntrities.year_set & "-03-31"
        Dim sp1 As New DataColumn("SP1", GetType(Image))
        Dim sp2 As New DataColumn("SP2", GetType(Image))
        Dim sp3 As New DataColumn("SP3", GetType(Image))
        Dim status As New DataColumn("STATUS", GetType(Image))
        Dim age As Integer = 9
        sql = "SELECT * FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE tar.SERVICE IS NOT NULL"
        sql &= " UNION ALL "
        age = 18
        sql &= "SELECT * FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE tar.SERVICE IS NOT NULL"
        sql &= " UNION ALL "
        age = 30
        sql &= "SELECT * FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE tar.SERVICE IS NOT NULL"
        sql &= " UNION ALL "
        age = 42
        sql &= "SELECT * FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE tar.SERVICE IS NOT NULL"
        rep = sqlf.QueryAsDatatable(sql)
        rep.Columns.Add(sp1)
        rep.Columns.Add(sp2)
        rep.Columns.Add(sp3)
        rep.Columns.Add(status)
        Dim spc1 As Integer = 0
        Dim spc2 As Integer = 0
        Dim spc3 As Integer = 0
        For i = 0 To rep.Rows.Count - 1
            If InStr(rep.Rows(i).Item("SP_FIRST").ToString, "1B260") Then
                rep.Rows(i).Item("SP1") = My.Resources.check16
                spc1 += 1
            Else
                rep.Rows(i).Item("SP1") = My.Resources.blank
            End If
            If InStr(rep.Rows(i).Item("SP_FIRST").ToString, "1B261") Then
                rep.Rows(i).Item("SP2") = My.Resources.check16
                spc2 += 1
            Else
                rep.Rows(i).Item("SP2") = My.Resources.blank
            End If
            If InStr(rep.Rows(i).Item("SP_FIRST").ToString, "1B262") Then
                rep.Rows(i).Item("SP3") = My.Resources.check16
                spc3 += 1
            Else
                rep.Rows(i).Item("SP3") = My.Resources.blank
            End If
        Next
        reportData_table.DataSource = rep
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("START_DATE_SCREEN").HeaderText = "วันเริ้มต้นคัดกรอง"
        reportData_table.Columns("END_DATE_SCREEN").HeaderText = "วันสิ้นสุดการคัดกรอง"
        reportData_table.Columns("sex").HeaderText = "เพศ"
        reportData_table.Columns("AGEGROUP").HeaderText = "กลุ่มอายุ"
        reportData_table.Columns("SERVICE").HeaderText = "วันที่ได้รับคัดกรองในช่วง"
        reportData_table.Columns("SP1").HeaderText = "ปกติ"
        reportData_table.Columns("SP2").HeaderText = "สงสัยล่าช้า"
        reportData_table.Columns("SP3").HeaderText = "ส่งต่อ"
        report_title_tf.Text = report_title_tf.Text & " [เป้าหมาย : " & rep.Rows.Count & ", ผลงาน : (ปกติ=" & spc1 & ",ล่าช้า=" & spc2 & ",ส่งต่อ=" & spc3 & "), ร้อยละ : (ปกติ=" & (spc1 * 100 / rep.Rows.Count).ToString("0.00") & ",ล่าช้า=" & (spc2 * 100 / rep.Rows.Count).ToString("0.00") & ",ส่งต่อ=" & (spc3 * 100 / rep.Rows.Count).ToString("0.00") & ") ]"
        Cursor = Cursors.Default
    End Sub
    Public Sub qof_3_rep()
        Cursor = Cursors.WaitCursor
        repID = 3
        report_title_tf.Text = qof_3_b.Text
        Dim rep As DataTable = Nothing
        reportData_table.DataSource = Nothing
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        Dim stardate As String = SharingEntrities.year_set - 1 & "-04-01"
        Dim enddate As String = SharingEntrities.year_set & "-03-31"


        Dim status As New DataColumn("STATUS", GetType(Image))
        Dim age As Integer = 9
        sql = "SELECT *,TIMESTAMPADD(DAY,30,tar.SERVICE) AS END_DATE_SCREEN2,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND_VAL FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE INSTR(SP_FIRST,'1B261')"
        sql &= " UNION ALL "
        age = 18
        sql &= "SELECT *,TIMESTAMPADD(DAY,30,tar.SERVICE) AS END_DATE_SCREEN2,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND_VAL FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE INSTR(SP_FIRST,'1B261')"
        sql &= " UNION ALL "
        age = 30
        sql &= "SELECT *,TIMESTAMPADD(DAY,30,tar.SERVICE) AS END_DATE_SCREEN2,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND_VAL FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE INSTR(SP_FIRST,'1B261')"
        sql &= " UNION ALL "
        age = 42
        sql &= "SELECT *,TIMESTAMPADD(DAY,30,tar.SERVICE) AS END_DATE_SCREEN2,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = tar.cid AND o.vstdate BETWEEN TIMESTAMPADD(DAY,1,tar.SERVICE) AND TIMESTAMPADD(DAY,30,tar.SERVICE) AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC LIMIT 1) AS SP_SECOND_VAL FROM (SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE,( SELECT GROUP_CONCAT(ppt.pp_special_code SEPARATOR ',') FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') GROUP BY o.vstdate	ORDER BY o.vstdate ASC  LIMIT 1) AS SP_FIRST FROM ( SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name," & age & " AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t) AS tar WHERE INSTR(SP_FIRST,'1B261')"
        rep = sqlf.QueryAsDatatable(sql)
        Console.WriteLine(sql)
        rep.Columns.Add(status)
        Dim result As Integer = 0
        For i = 0 To rep.Rows.Count - 1
            If rep.Rows(i).Item("SP_SECOND").ToString <> "" Then
                rep.Rows(i).Item("STATUS") = My.Resources.check16
                result += 1
            Else
                rep.Rows(i).Item("STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = rep
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("START_DATE_SCREEN").HeaderText = "วันเริ้มต้นคัดกรอง"
        reportData_table.Columns("END_DATE_SCREEN").HeaderText = "วันสิ้นสุดการคัดกรอง"
        reportData_table.Columns("sex").HeaderText = "เพศ"
        reportData_table.Columns("AGEGROUP").HeaderText = "กลุ่มอายุ"
        reportData_table.Columns("SERVICE").HeaderText = "วันที่ได้รับคัดกรองในช่วง"
        reportData_table.Columns("SP_FIRST").HeaderText = "ผลการคัดกรองในช่วง"
        reportData_table.Columns("END_DATE_SCREEN2").HeaderText = "วันสิ้นสุดการติดตาม"
        reportData_table.Columns("SP_SECOND").HeaderText = "วันที่ติดตาม"
        reportData_table.Columns("SP_SECOND_VAL").HeaderText = "ผลการติดตาม"
        reportData_table.Columns("STATUS").HeaderText = "ผลงาน"
        report_title_tf.Text = report_title_tf.Text & " [เป้าหมาย : " & rep.Rows.Count & ", ผลงาน : " & result & ", ร้อยละ : " & (result * 100 / rep.Rows.Count).ToString("0.00") & " ]"
        Cursor = Cursors.Default
    End Sub
    Private Sub qof_1_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qof_1_b.NodeDoubleClick
        qof_1_rep()
    End Sub

    Private Sub reportData_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles reportData_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(reportData_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub qof_2_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qof_2_b.NodeDoubleClick
        qof_2_rep()
    End Sub

    Private Sub qof_3_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qof_3_b.NodeDoubleClick
        qof_3_rep()
    End Sub
End Class