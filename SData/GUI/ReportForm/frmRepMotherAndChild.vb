Public Class frmRepMotherAndChild
    Public stardate As String = "2017-10-01"
    Public enddate As String = "2017-10-31"
    Private sqlf As New SQLManager
    Dim keyin As Boolean = False
    Private Sub reportChildRegisterMontB_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportChildRegisterMontB.NodeDoubleClick
        Dim getdate As New frmGetDateStartEnd
        getdate.ShowDialog()
        stardate = SharingEntrities.startdate
        enddate = SharingEntrities.enddate
        Dim sql As String = "SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,9 AS AGEGROUP,TIMESTAMPADD(MONTH,9,p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH,10,p.birthdate) AS END_DATE_SCREEN FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id LEFT OUTER JOIN sex s ON p.sex = s.`code` LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN house h ON p.house_id = h.house_id WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH,9,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH,10,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')"
        sql &= " UNION ALL "
        sql &= " SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,18 AS AGEGROUP,TIMESTAMPADD(MONTH,18,p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH,19,p.birthdate) AS END_DATE_SCREEN FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id LEFT OUTER JOIN sex s ON p.sex = s.`code` LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN house h ON p.house_id = h.house_id WHERE p.person_discharge_id = 9 AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH,18,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH,19,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "') "
        sql &= " UNION ALL "
        sql &= " SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,30 AS AGEGROUP, TIMESTAMPADD(MONTH,30,p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH,31,p.birthdate) AS END_DATE_SCREEN FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id LEFT OUTER JOIN sex s ON p.sex = s.`code` LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN house h ON p.house_id = h.house_id WHERE p.person_discharge_id = 9 AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH,30,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "'   OR TIMESTAMPADD(MONTH,31,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "') "
        sql &= " UNION ALL "
        sql &= " SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,42 AS AGEGROUP,TIMESTAMPADD(MONTH,42,p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH,43,p.birthdate) AS END_DATE_SCREEN FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id LEFT OUTER JOIN sex s ON p.sex = s.`code` LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN house h ON p.house_id = h.house_id WHERE p.person_discharge_id = 9 AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH,42,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH,43,p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "') "
        Dim report_table As DataTable = sqlf.QueryAsDatatable(sql)
        reportData_table.DataSource = report_table
        keyin = False
    End Sub

    Private Sub reportData_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles reportData_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(reportData_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub reportChildMonthSpB_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reportChildMonthSpB.NodeDoubleClick

        Dim getdate As New frmGetDateStartEnd
        getdate.ShowDialog()
        stardate = SharingEntrities.startdate
        enddate = SharingEntrities.enddate
        Dim age As Integer = 9
        Dim sql As String = "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,9 AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 18
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,9 AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 30
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,9 AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        sql &= " UNION ALL "
        age = 42
        sql &= "SELECT  t.*,( SELECT o.vstdate FROM patient pt LEFT JOIN ovst o ON pt.hn = o.hn LEFT JOIN pp_special pp ON o.vn = pp.vn INNER JOIN pp_special_type ppt ON pp.pp_special_type_id = ppt.pp_special_type_id WHERE pt.cid = t.cid AND o.vstdate BETWEEN t.START_DATE_SCREEN AND t.END_DATE_SCREEN 	AND ppt.pp_special_code IN('1B260','1B261','1B262' ,'1B200','1B201','1B202','1B209','1B210','1B211','1B212',	'1B219','1B220','1B221','1B222','1B229','1B230','1B231','1B232','1B239','1B240','1B241','1B242','1B249') 	ORDER BY o.vstdate ASC LIMIT 1) AS SERVICE FROM ( SELECT p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,s.`name` AS sex,p.birthdate,	hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,9 AS AGEGROUP,	TIMESTAMPADD(MONTH," & age & ",p.birthdate) AS START_DATE_SCREEN,TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) AS END_DATE_SCREEN 	FROM person p LEFT OUTER JOIN village v ON v.village_id = p.village_id 	LEFT OUTER JOIN sex s ON p.sex = s.`code` 	LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id 	LEFT JOIN house h ON p.house_id = h.house_id 	WHERE p.person_discharge_id = 9  AND p.house_regist_type_id IN(1,3) AND (TIMESTAMPADD(MONTH," & age & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "' OR TIMESTAMPADD(MONTH," & (age + 1) & ",p.birthdate) BETWEEN '" & stardate & "' AND '" & enddate & "')) AS t"
        Dim report_table As DataTable = sqlf.QueryAsDatatable(sql)
        Dim calN As New DataColumn("STATUS", GetType(Image))
        report_table.Columns.Add(calN)
        For i = 0 To report_table.Rows.Count - 1
            If report_table.Rows(i).Item("SERVICE").ToString <> "" Then
                report_table.Rows(i).Item("STATUS") = My.Resources.check16
            Else
                report_table.Rows(i).Item("STATUS") = My.Resources.cross16
            End If

        Next

        reportData_table.DataSource = report_table
        keyin = False
    End Sub

    Private Sub Node4_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Node4.NodeDoubleClick
        report4()
    End Sub
    Public Sub report4()
        Dim qt As New frmGetQuarter
        qt.ShowDialog()
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS ptname,p.birthdate,h.address,v.village_moo," & _
        "v.village_name,t.full_name,pa.lmp,pa.preg_no,pa.labor_date,MOD(QUARTER(pa.labor_date),4)+1 AS quarter_y," & _
        "anc.anc_service_date, anc.service_result_id, anc.service_result_name, anc.week_q " & _
        "FROM person_anc pa " & _
        "INNER JOIN person p ON pa.person_id = p.person_id " & _
        "LEFT JOIN house h ON p.house_id = h.house_id " & _
        "LEFT JOIN village v ON h.village_id = v.village_id " & _
        "LEFT JOIN house_regist_type hrt ON hrt.house_regist_type_id = p.house_regist_type_id " & _
        "LEFT JOIN thaiaddress t ON v.address_id = t.addressid " & _
        "LEFT JOIN ( " & _
        "	SELECT * " & _
        "	FROM (" & _
        "		SELECT pa.person_id,pas.anc_service_date,IF(pas.service_result IS NULL ,'9',IF(pas.service_result = 'Y','1','2')) AS service_result_id," & _
        "		IF(pas.service_result IS NULL ,'ไม่ทราบ',IF(pas.service_result = 'Y','ปกติ','ผิดปกติ')) AS service_result_name," & _
        "		TIMESTAMPDIFF(WEEK,pa.lmp,pas.anc_service_date) AS week_q " & _
        "		FROM person_anc pa " & _
        "		INNER JOIN person_anc_service pas ON pa.person_anc_id = pas.person_anc_id " & _
        "		WHERE TIMESTAMPDIFF(WEEK,pa.lmp,pas.anc_service_date) <= 12 " & _
        "		AND pas.anc_service_date BETWEEN '2015-10-01' AND NOW() " & _
        "		GROUP BY person_id " & _
        "		HAVING MAX(pas.anc_service_date) " & _
        "  UNION " & _
        "		SELECT pa.person_id,paop.precare_date," & _
        "		IF(paop.anc_result IS NULL,9,paop.anc_result) AS service_result_id," & _
        "		IF(paop.anc_result IS NULL,'ไม่ทราบ',art.anc_result_type_name ) AS service_result_name," & _
        "		TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) AS week_q " & _
        "		FROM person_anc_other_precare paop " & _
        "		INNER JOIN person_anc pa ON paop.person_anc_id = pa.person_anc_id " & _
        "		LEFT JOIN anc_result_type art ON paop.anc_result = art.anc_result_type_id " & _
        "		WHERE paop.precare_date BETWEEN '" & (SharingEntrities.year_set - 2) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' " & _
        "		AND TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) <= 12 " & _
        "		GROUP BY pa.person_id " & _
        "		HAVING MAX(paop.precare_date) " & _
        "	) AS anc " & _
        "	GROUP BY anc.person_id " & _
        "	HAVING MAX(anc.anc_service_date) " & _
        ") AS anc ON pa.person_id = anc.person_id " & _
        "WHERE p.person_discharge_id = 9 " & _
        "AND hrt.export_code IN(1,3) " & _
        "AND pa.labor_date BETWEEN '" & (SharingEntrities.year_set - 1) & "-10-01' AND '" & SharingEntrities.year_set & "-09-30' " & _
        "ORDER BY (MOD(QUARTER(pa.labor_date),4)+1) ASC "
        Dim report_table As DataTable = sqlf.QueryAsDatatable(sql)
        Dim calN As New DataColumn("STATUS", GetType(Image))
        report_table.Columns.Add(calN)
        For i = 0 To report_table.Rows.Count - 1
            If report_table.Rows(i).Item("anc_service_date").ToString <> "" Then
                report_table.Rows(i).Item("STATUS") = My.Resources.check16
            Else
                report_table.Rows(i).Item("STATUS") = My.Resources.cross16
            End If

        Next

        keyin = True
        reportData_table.DataSource = report_table
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("ptname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("preg_no").HeaderText = "ครรภ์ที่"
        reportData_table.Columns("labor_date").HeaderText = "วันที่คลอด"
        reportData_table.Columns("quarter_y").HeaderText = "ไตรมาส"
        reportData_table.Columns("anc_service_date").HeaderText = "วันที่ฝากครรภ์ครั้งที่ 1"
    End Sub
End Class