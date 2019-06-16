Public Class frmRepEIP
    Dim sqlf As New SQLManager
    Dim keyin As Boolean = False
    Dim reportindex As Integer = 0

    Private Sub rep1()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานเด็กอายุครบ 1 ปีที่ได้รับวัคซีน BCG ,HBV1,DTP-HBV3,โปลิโอ3, MMR1,IPV"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE    WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 7 and 9 then 4 END quater_y, DATE_ADD(p.birthdate,INTERVAL 1 YEAR) AS date_target,bcg.bcg_service_date,hbv1.hbv1_service_date,dtp3.service_date AS dtp3_service_date,hbv3.service_date AS hbv3_service_date,opv3.service_date AS opv3_service_date,mmr1.service_date AS mmr1_service_date,ipv.service_date AS ipv_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date AS bcg_service_date 	FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('010') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('010') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('010') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('010') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('010') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS bcg ON p.person_id = bcg.person_id LEFT JOIN (SELECT e2.person_id,e2.service_date AS hbv1_service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('041','091','D51','H31') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('041','091','D51','H31') GROUP BY vs.person_id ) AS e2 GROUP BY e2.person_id ) hbv1 ON p.person_id = hbv1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS dtp3 ON p.person_id = dtp3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) hbv3 ON p.person_id = hbv3.person_id LEFT JOIN ( SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) opv3 ON p.person_id = opv3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('061','M11') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('061','M11') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('061','M11') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('061','M11') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('061','M11') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) mmr1 ON p.person_id = mmr1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('401','D32','D42','D52','I12') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('401','D32','D42','D52','I12') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('401','D32','D42','D52','I12') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('401','D32','D42','D52','I12') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('401','D32','D42','D52','I12') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS ipv ON p.person_id = ipv.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 1 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir1 As DataTable = sqlf.QueryAsDatatable(sql)
        Dim bcg As New DataColumn("BCG_STATUS", GetType(Image))
        Dim hbv1 As New DataColumn("HBV1_STATUS", GetType(Image))
        Dim dtp_hbv3 As New DataColumn("DTP_HBV3_STATUS", GetType(Image))
        Dim opv3 As New DataColumn("OPV3_STATUS", GetType(Image))
        Dim mmr1 As New DataColumn("MMR1_STATUS", GetType(Image))
        Dim ipv As New DataColumn("IPV_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir1.Columns.Add(bcg)
        epir1.Columns.Add(hbv1)
        epir1.Columns.Add(dtp_hbv3)
        epir1.Columns.Add(opv3)
        epir1.Columns.Add(mmr1)
        epir1.Columns.Add(ipv)
        epir1.Columns.Add(cov)
        epir1.Columns("BCG_STATUS").SetOrdinal(12)
        epir1.Columns("HBV1_STATUS").SetOrdinal(14)
        epir1.Columns("DTP_HBV3_STATUS").SetOrdinal(17)
        epir1.Columns("OPV3_STATUS").SetOrdinal(19)
        epir1.Columns("MMR1_STATUS").SetOrdinal(21)
        epir1.Columns("IPV_STATUS").SetOrdinal(23)
        For i = 0 To epir1.Rows.Count - 1
            'BCG
            If epir1.Rows(i).Item("bcg_service_date").ToString <> "" Then
                epir1.Rows(i).Item("BCG_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("BCG_STATUS") = My.Resources.cross16
            End If
            'HBV1
            If epir1.Rows(i).Item("hbv1_service_date").ToString <> "" Then
                epir1.Rows(i).Item("HBV1_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("HBV1_STATUS") = My.Resources.cross16
            End If
            'dtp-hbv3
            If epir1.Rows(i).Item("dtp3_service_date").ToString <> "" And epir1.Rows(i).Item("hbv3_service_date").ToString <> "" Then
                epir1.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.cross16
            End If
            'OPV3
            If epir1.Rows(i).Item("opv3_service_date").ToString <> "" Then
                epir1.Rows(i).Item("OPV3_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("OPV3_STATUS") = My.Resources.cross16
            End If
            'MMR1
            If epir1.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir1.Rows(i).Item("MMR1_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("MMR1_STATUS") = My.Resources.cross16
            End If
            'IPV
            If epir1.Rows(i).Item("ipv_service_date").ToString <> "" Then
                epir1.Rows(i).Item("IPV_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("IPV_STATUS") = My.Resources.cross16
            End If
            'Coverage
            If epir1.Rows(i).Item("bcg_service_date").ToString <> "" And epir1.Rows(i).Item("hbv1_service_date").ToString <> "" And epir1.Rows(i).Item("dtp3_service_date").ToString <> "" And epir1.Rows(i).Item("hbv3_service_date").ToString <> "" And epir1.Rows(i).Item("opv3_service_date").ToString <> "" And epir1.Rows(i).Item("mmr1_service_date").ToString <> "" And epir1.Rows(i).Item("ipv_service_date").ToString <> "" Then
                epir1.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir1
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("bcg_service_date").HeaderText = "วันที่ได้รับ BCG"
        reportData_table.Columns("BCG_STATUS").HeaderText = "การได้รับ BCG"
        reportData_table.Columns("hbv1_service_date").HeaderText = "วันที่ได้รับ HBV1"
        reportData_table.Columns("HBV1_STATUS").HeaderText = "การได้รับ HBV1"
        reportData_table.Columns("dtp3_service_date").HeaderText = "วันที่ได้รับ DTP3"
        reportData_table.Columns("hbv3_service_date").HeaderText = "วันที่ได้รับ HBV3"
        reportData_table.Columns("DTP_HBV3_STATUS").HeaderText = "การได้รับ DTP-HBV3"
        reportData_table.Columns("opv3_service_date").HeaderText = "วันที่ได้รับ OPV3"
        reportData_table.Columns("OPV3_STATUS").HeaderText = "การได้รับ OPV3"
        reportData_table.Columns("mmr1_service_date").HeaderText = "วันที่ได้รับ MMR1"
        reportData_table.Columns("MMR1_STATUS").HeaderText = "การได้รับ MMR1"
        reportData_table.Columns("ipv_service_date").HeaderText = "วันที่ได้รับ IPV"
        reportData_table.Columns("IPV_STATUS").HeaderText = "การได้รับ IPV"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub rep2()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานเด็กอายุครบ 2 ปีที่ได้รับวัคซีน DTP4,โปลิโอ4,JE"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE     WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 10 and 12 then 1 	WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 1 and 3 then 2 	WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 4 and 6 then 3 	WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 7 and 9 then 4 END quater_y,DATE_ADD(p.birthdate,INTERVAL 2 YEAR) AS date_target,dtp4.service_date AS dtp4_service_date,opv4.service_date AS opv4_service_date,je1.service_date AS je1_service_date,je2.service_date AS je2_service_date,j11.service_date AS j11_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp4 ON p.person_id = dtp4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('084','D34','D44','D54','I14') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id ) AS opv4 ON p.person_id = opv4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('051') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('051') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('051') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('051') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('051') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je1 ON p.person_id = je1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('052') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('052') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('052') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('052') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id  		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('052') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je2 ON p.person_id = je2.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J11') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J11') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J11') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J11') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl 		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J11') GROUP BY vs.person_id 	) AS e1 GROUP BY e1.person_id ) AS j11 ON p.person_id = j11.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 2 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir2 As DataTable = sqlf.QueryAsDatatable(sql)
        Dim dtp4 As New DataColumn("DTP4_STATUS", GetType(Image))
        Dim opv4 As New DataColumn("OPV4_STATUS", GetType(Image))
        Dim je As New DataColumn("JE_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir2.Columns.Add(dtp4)
        epir2.Columns.Add(opv4)
        epir2.Columns.Add(je)
        epir2.Columns.Add(cov)
        epir2.Columns("DTP4_STATUS").SetOrdinal(12)
        epir2.Columns("OPV4_STATUS").SetOrdinal(14)
        epir2.Columns("JE_STATUS").SetOrdinal(18)
        For i = 0 To epir2.Rows.Count - 1
            'DTP4
            If epir2.Rows(i).Item("dtp4_service_date").ToString <> "" Then
                epir2.Rows(i).Item("DTP4_STATUS") = My.Resources.check16
            Else
                epir2.Rows(i).Item("DTP4_STATUS") = My.Resources.cross16
            End If
            'OPV4
            If epir2.Rows(i).Item("opv4_service_date").ToString <> "" Then
                epir2.Rows(i).Item("OPV4_STATUS") = My.Resources.check16
            Else
                epir2.Rows(i).Item("OPV4_STATUS") = My.Resources.cross16
            End If
            'JE
            If (epir2.Rows(i).Item("je1_service_date").ToString <> "" And epir2.Rows(i).Item("je2_service_date").ToString <> "") Or epir2.Rows(i).Item("j11_service_date").ToString <> "" Then
                If epir2.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir2.Rows(i).Item("JE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir2.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir2.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir2.Rows(i).Item("JE_STATUS") = My.Resources.check16
                Else
                    epir2.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                End If
            Else
                epir2.Rows(i).Item("JE_STATUS") = My.Resources.cross16
            End If
            If epir2.Rows(i).Item("dtp4_service_date").ToString <> "" And epir2.Rows(i).Item("opv4_service_date").ToString <> "" And ((epir2.Rows(i).Item("je1_service_date").ToString <> "" And epir2.Rows(i).Item("je2_service_date").ToString <> "") Or epir2.Rows(i).Item("j11_service_date").ToString <> "") Then
                If epir2.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir2.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir2.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir2.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir2.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                Else
                    epir2.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
                End If
            Else
                epir2.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir2
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("DTP4_STATUS").HeaderText = "การได้รับ DTP4"
        reportData_table.Columns("dtp4_service_date").HeaderText = "วันที่ได้รับ DTP4"
        reportData_table.Columns("JE_STATUS").HeaderText = "การได้รับ JE"
        reportData_table.Columns("je1_service_date").HeaderText = "วันที่ได้รับ JE1 เชื้อตาย"
        reportData_table.Columns("je2_service_date").HeaderText = "วันที่ได้รับ JE2 เชื้อตาย"
        reportData_table.Columns("j11_service_date").HeaderText = "วันที่ได้รับ J11 เชื้อเป็น"
        reportData_table.Columns("OPV4_STATUS").HeaderText = "การได้รับ OPV4"
        reportData_table.Columns("opv4_service_date").HeaderText = "วันที่ได้รับ OPV4"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub rep3()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานเด็กอายุครบ 3 ปีที่ได้รับวัคซีน JE,MMR2"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE   WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 7 and 9 then 4 END quater_y,DATE_ADD(p.birthdate,INTERVAL 3 YEAR) AS date_target,je1.service_date AS je1_service_date,je2.service_date As je2_service_date,je3.service_date AS je3_service_date,j11.service_date AS j11_service_date,j12.service_date AS j12_service_date,mmr2.service_date AS mmr2_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('051') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('051') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('051') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('051') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 	WHERE sv.export_vaccine_code IN('051') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je1 ON p.person_id = je1.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('052') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('052') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('052') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('052') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('052') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je2 ON p.person_id = je2.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('053') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('053') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('053') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('053') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('053') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je3 ON p.person_id = je3.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J11') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J11') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J11') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J11') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J11') GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS j11 ON p.person_id = j11.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J12') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J12') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J12') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS j12 ON p.person_id = j12.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('073','M12') GROUP BY pw.person_id 		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('073','M12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY pve.person_id		UNION ALL 		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid  		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('073','M12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS mmr2 ON p.person_id = mmr2.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 3 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir3 As DataTable = sqlf.QueryAsDatatable(sql)
        Dim je As New DataColumn("JE_STATUS", GetType(Image))
        Dim mmr2 As New DataColumn("MMR2_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir3.Columns.Add(je)
        epir3.Columns.Add(mmr2)
        epir3.Columns.Add(cov)
        epir3.Columns("JE_STATUS").SetOrdinal(16)
        epir3.Columns("MMR2_STATUS").SetOrdinal(18)
        For i = 0 To epir3.Rows.Count - 1
            Dim cov_st As Boolean = False
            Dim cov_st2 As Boolean = False
            If (epir3.Rows(i).Item("je1_service_date").ToString <> "" And epir3.Rows(i).Item("je2_service_date").ToString <> "" And epir3.Rows(i).Item("je3_service_date").ToString <> "") Then
                If Date.Parse(epir3.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir3.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("je3_service_date").ToString).Date Then
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    cov_st = True
                Else
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    cov_st = False
                End If
            ElseIf (epir3.Rows(i).Item("je1_service_date").ToString <> "" And epir3.Rows(i).Item("je2_service_date").ToString <> "" And epir3.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir3.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir3.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    cov_st = True
                Else
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    cov_st = False
                End If
            ElseIf (epir3.Rows(i).Item("j11_service_date").ToString <> "" And epir3.Rows(i).Item("j12_service_date").ToString <> "") Then
                If Date.Parse(epir3.Rows(i).Item("j11_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("j12_service_date").ToString).Date Then
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    cov_st = True
                Else
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    cov_st = False
                End If
            ElseIf (epir3.Rows(i).Item("je1_service_date").ToString <> "" And epir3.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir3.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir3.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    cov_st = True
                Else
                    epir3.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    cov_st = False
                End If
            Else
                epir3.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                cov_st = False
            End If

            If epir3.Rows(i).Item("mmr2_service_date").ToString <> "" Then
                epir3.Rows(i).Item("MMR2_STATUS") = My.Resources.check16
                cov_st2 = True
            Else
                epir3.Rows(i).Item("MMR2_STATUS") = My.Resources.cross16
                cov_st2 = False
            End If
            If cov_st And cov_st2 Then
                epir3.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
            Else
                epir3.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir3
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("je1_service_date").HeaderText = "วันที่ได้รับ JE1"
        reportData_table.Columns("je2_service_date").HeaderText = "วันที่ได้รับ JE2"
        reportData_table.Columns("je3_service_date").HeaderText = "วันที่ได้รับ JE3"
        reportData_table.Columns("j11_service_date").HeaderText = "วันที่ได้รับ J11"
        reportData_table.Columns("j12_service_date").HeaderText = "วันที่ได้รับ J12"
        reportData_table.Columns("JE_STATUS").HeaderText = "การได้รับ JE"
        reportData_table.Columns("mmr2_service_date").HeaderText = "วันที่ได้รับ MMR2"
        reportData_table.Columns("MMR2_STATUS").HeaderText = "การได้รับ MMR2"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub rep4()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานเด็กอายุครบ 5 ปีที่ได้รับวัคซีน DTP5,โปลิโอ5"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE   WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 7 and 9 then 4 END quater_y,DATE_ADD(p.birthdate,INTERVAL 5 YEAR) AS date_target,dtp5.service_date AS dtp5_service_date,opv5.service_date AS opv5_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('035','D35','D45','D55') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp5 ON p.person_id = dtp5.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('085','D35','D45','D55','I15') 		GROUP BY vs.person_id 	) AS e1 GROUP BY e1.person_id ) AS opv5 ON p.person_id = opv5.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 5 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir4 As DataTable = sqlf.QueryAsDatatable(sql)
        Dim dtp As New DataColumn("DTP5_STATUS", GetType(Image))
        Dim opv As New DataColumn("OPV5_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir4.Columns.Add(dtp)
        epir4.Columns.Add(opv)
        epir4.Columns.Add(cov)
        epir4.Columns("DTP5_STATUS").SetOrdinal(12)
        epir4.Columns("OPV5_STATUS").SetOrdinal(14)
        For i = 0 To epir4.Rows.Count - 1
            If epir4.Rows(i).Item("dtp5_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP5_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP5_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv5_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV5_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV5_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp5_service_date").ToString <> "" And epir4.Rows(i).Item("opv5_service_date").ToString <> "" Then
                epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir4
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("dtp5_service_date").HeaderText = "วันที่ได้รับ DTP5"
        reportData_table.Columns("DTP5_STATUS").HeaderText = "การได้รับ DTP5"
        reportData_table.Columns("opv5_service_date").HeaderText = "วันที่ได้รับ OPV5"
        reportData_table.Columns("OPV5_STATUS").HeaderText = "การได้รับ OPV5"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub covrage1year()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานความครอบคลุมการได้รับวัคซีนแครบตามเกณฑ์ในเด็กอายุครบ 1 ปี (fully immunized)"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE    WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 1 YEAR)) BETWEEN 7 and 9 then 4 END quater_y, DATE_ADD(p.birthdate,INTERVAL 1 YEAR) AS date_target,bcg.bcg_service_date,hbv1.hbv1_service_date,dtp3.service_date AS dtp3_service_date,hbv3.service_date AS hbv3_service_date,opv3.service_date AS opv3_service_date,mmr1.service_date AS mmr1_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date AS bcg_service_date 	FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('010') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('010') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('010') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('010') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('010') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS bcg ON p.person_id = bcg.person_id LEFT JOIN (SELECT e2.person_id,e2.service_date AS hbv1_service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('041','091','D51','H31') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('041','091','D51','H31') GROUP BY vs.person_id ) AS e2 GROUP BY e2.person_id ) hbv1 ON p.person_id = hbv1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS dtp3 ON p.person_id = dtp3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) hbv3 ON p.person_id = hbv3.person_id LEFT JOIN ( SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) opv3 ON p.person_id = opv3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('061','M11') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('061','M11') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('061','M11') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('061','M11') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('061','M11') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) mmr1 ON p.person_id = mmr1.person_id  WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 1 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir1 As DataTable = sqlf.QueryAsDatatable(sql)
        Dim bcg As New DataColumn("BCG_STATUS", GetType(Image))
        Dim hbv1 As New DataColumn("HBV1_STATUS", GetType(Image))
        Dim dtp_hbv3 As New DataColumn("DTP_HBV3_STATUS", GetType(Image))
        Dim opv3 As New DataColumn("OPV3_STATUS", GetType(Image))
        Dim mmr1 As New DataColumn("MMR1_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir1.Columns.Add(bcg)
        epir1.Columns.Add(hbv1)
        epir1.Columns.Add(dtp_hbv3)
        epir1.Columns.Add(opv3)
        epir1.Columns.Add(mmr1)
        epir1.Columns.Add(cov)
        epir1.Columns("BCG_STATUS").SetOrdinal(12)
        epir1.Columns("HBV1_STATUS").SetOrdinal(14)
        epir1.Columns("DTP_HBV3_STATUS").SetOrdinal(17)
        epir1.Columns("OPV3_STATUS").SetOrdinal(19)
        epir1.Columns("MMR1_STATUS").SetOrdinal(21)
        For i = 0 To epir1.Rows.Count - 1
            'BCG
            If epir1.Rows(i).Item("bcg_service_date").ToString <> "" Then
                epir1.Rows(i).Item("BCG_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("BCG_STATUS") = My.Resources.cross16
            End If
            'HBV1
            If epir1.Rows(i).Item("hbv1_service_date").ToString <> "" Then
                epir1.Rows(i).Item("HBV1_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("HBV1_STATUS") = My.Resources.cross16
            End If
            'dtp-hbv3
            If epir1.Rows(i).Item("dtp3_service_date").ToString <> "" And epir1.Rows(i).Item("hbv3_service_date").ToString <> "" Then
                epir1.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.cross16
            End If
            'OPV3
            If epir1.Rows(i).Item("opv3_service_date").ToString <> "" Then
                epir1.Rows(i).Item("OPV3_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("OPV3_STATUS") = My.Resources.cross16
            End If
            'MMR1
            If epir1.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir1.Rows(i).Item("MMR1_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("MMR1_STATUS") = My.Resources.cross16
            End If


            'Coverage
            If epir1.Rows(i).Item("bcg_service_date").ToString <> "" And epir1.Rows(i).Item("hbv1_service_date").ToString <> "" And epir1.Rows(i).Item("dtp3_service_date").ToString <> "" And epir1.Rows(i).Item("hbv3_service_date").ToString <> "" And epir1.Rows(i).Item("opv3_service_date").ToString <> "" And epir1.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir1.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
            Else
                epir1.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir1
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("bcg_service_date").HeaderText = "วันที่ได้รับ BCG"
        reportData_table.Columns("BCG_STATUS").HeaderText = "การได้รับ BCG"
        reportData_table.Columns("hbv1_service_date").HeaderText = "วันที่ได้รับ HBV1"
        reportData_table.Columns("HBV1_STATUS").HeaderText = "การได้รับ HBV1"
        reportData_table.Columns("dtp3_service_date").HeaderText = "วันที่ได้รับ DTP3"
        reportData_table.Columns("hbv3_service_date").HeaderText = "วันที่ได้รับ HBV3"
        reportData_table.Columns("DTP_HBV3_STATUS").HeaderText = "การได้รับ DTP-HBV3"
        reportData_table.Columns("opv3_service_date").HeaderText = "วันที่ได้รับ OPV3"
        reportData_table.Columns("OPV3_STATUS").HeaderText = "การได้รับ OPV3"
        reportData_table.Columns("mmr1_service_date").HeaderText = "วันที่ได้รับ MMR1"
        reportData_table.Columns("MMR1_STATUS").HeaderText = "การได้รับ MMR1"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub covrage2year()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานความครอบคลุมการได้รับวัคซีนแครบตามเกณฑ์ในเด็กอายุครบ 2 ปี (fully immunized)"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE    WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 2 YEAR)) BETWEEN 7 and 9 then 4 END quater_y, DATE_ADD(p.birthdate,INTERVAL 2 YEAR) AS date_target,bcg.bcg_service_date,hbv1.hbv1_service_date,dtp3.service_date AS dtp3_service_date,hbv3.service_date AS hbv3_service_date,opv3.service_date AS opv3_service_date,mmr1.service_date AS mmr1_service_date,dtp4.service_date AS dtp4_service_date,opv4.service_date AS opv4_service_date,je1.service_date AS je1_service_date,je2.service_date AS je2_service_date,j11.service_date AS j11_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date AS bcg_service_date 	FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('010') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('010') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('010') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('010') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('010') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS bcg ON p.person_id = bcg.person_id LEFT JOIN (SELECT e2.person_id,e2.service_date AS hbv1_service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('041','091','D51','H31') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('041','091','D51','H31') GROUP BY vs.person_id ) AS e2 GROUP BY e2.person_id ) hbv1 ON p.person_id = hbv1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS dtp3 ON p.person_id = dtp3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) hbv3 ON p.person_id = hbv3.person_id LEFT JOIN ( SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) opv3 ON p.person_id = opv3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('061','M11') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('061','M11') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('061','M11') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('061','M11') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('061','M11') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) mmr1 ON p.person_id = mmr1.person_id  LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp4 ON p.person_id = dtp4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('084','D34','D44','D54','I14') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id ) AS opv4 ON p.person_id = opv4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('051') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('051') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('051') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('051') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('051') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je1 ON p.person_id = je1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('052') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('052') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('052') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('052') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id  		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('052') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je2 ON p.person_id = je2.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J11') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J11') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J11') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J11') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl 		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J11') GROUP BY vs.person_id 	) AS e1 GROUP BY e1.person_id ) AS j11 ON p.person_id = j11.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 2 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir4 As DataTable = sqlf.QueryAsDatatable(sql)
        '1 Year
        Dim bcg As New DataColumn("BCG_STATUS", GetType(Image))
        Dim hbv1 As New DataColumn("HBV1_STATUS", GetType(Image))
        Dim dtp_hbv3 As New DataColumn("DTP_HBV3_STATUS", GetType(Image))
        Dim opv3 As New DataColumn("OPV3_STATUS", GetType(Image))
        Dim mmr1 As New DataColumn("MMR1_STATUS", GetType(Image))
        '2 Year
        Dim dtp4 As New DataColumn("DTP4_STATUS", GetType(Image))
        Dim opv4 As New DataColumn("OPV4_STATUS", GetType(Image))
        Dim je As New DataColumn("JE_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        epir4.Columns.Add(bcg)
        epir4.Columns.Add(hbv1)
        epir4.Columns.Add(dtp_hbv3)
        epir4.Columns.Add(opv3)
        epir4.Columns.Add(mmr1)
        epir4.Columns.Add(dtp4)
        epir4.Columns.Add(opv4)
        epir4.Columns.Add(je)
        epir4.Columns.Add(cov)

        For i = 0 To epir4.Rows.Count - 1
            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" Then
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("hbv1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.cross16
            End If
            If (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "") Or epir4.Rows(i).Item("j11_service_date").ToString <> "" Then
                If epir4.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                End If
            Else
                epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
            End If

            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" And epir4.Rows(i).Item("hbv1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" And epir4.Rows(i).Item("opv3_service_date").ToString <> "" And epir4.Rows(i).Item("mmr1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp4_service_date").ToString <> "" And epir4.Rows(i).Item("opv4_service_date").ToString <> "" And ((epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "") Or epir4.Rows(i).Item("j11_service_date").ToString <> "") Then
                If epir4.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                Else
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
                End If
            Else
                epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If


        Next
        reportData_table.DataSource = epir4
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("bcg_service_date").HeaderText = "วันที่ได้รับ BCG"
        reportData_table.Columns("BCG_STATUS").HeaderText = "การได้รับ BCG"
        reportData_table.Columns("hbv1_service_date").HeaderText = "วันที่ได้รับ HBV1"
        reportData_table.Columns("HBV1_STATUS").HeaderText = "การได้รับ HBV1"
        reportData_table.Columns("dtp3_service_date").HeaderText = "วันที่ได้รับ DTP3"
        reportData_table.Columns("hbv3_service_date").HeaderText = "วันที่ได้รับ HBV3"
        reportData_table.Columns("DTP_HBV3_STATUS").HeaderText = "การได้รับ DTP-HBV3"
        reportData_table.Columns("opv3_service_date").HeaderText = "วันที่ได้รับ OPV3"
        reportData_table.Columns("OPV3_STATUS").HeaderText = "การได้รับ OPV3"
        reportData_table.Columns("mmr1_service_date").HeaderText = "วันที่ได้รับ MMR1"
        reportData_table.Columns("MMR1_STATUS").HeaderText = "การได้รับ MMR1"
        reportData_table.Columns("DTP4_STATUS").HeaderText = "การได้รับ DTP4"
        reportData_table.Columns("dtp4_service_date").HeaderText = "วันที่ได้รับ DTP4"
        reportData_table.Columns("JE_STATUS").HeaderText = "การได้รับ JE"
        reportData_table.Columns("je1_service_date").HeaderText = "วันที่ได้รับ JE1 เชื้อตาย"
        reportData_table.Columns("je2_service_date").HeaderText = "วันที่ได้รับ JE2 เชื้อตาย"
        reportData_table.Columns("j11_service_date").HeaderText = "วันที่ได้รับ J11 เชื้อเป็น"
        reportData_table.Columns("OPV4_STATUS").HeaderText = "การได้รับ OPV4"
        reportData_table.Columns("opv4_service_date").HeaderText = "วันที่ได้รับ OPV4"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub covrage3year()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานความครอบคลุมการได้รับวัคซีนแครบตามเกณฑ์ในเด็กอายุครบ 3 ปี (fully immunized)"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE    WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 3 YEAR)) BETWEEN 7 and 9 then 4 END quater_y, DATE_ADD(p.birthdate,INTERVAL 3 YEAR) AS date_target,bcg.bcg_service_date,hbv1.hbv1_service_date,dtp3.service_date AS dtp3_service_date,hbv3.service_date AS hbv3_service_date,opv3.service_date AS opv3_service_date,mmr1.service_date AS mmr1_service_date,dtp4.service_date AS dtp4_service_date,opv4.service_date AS opv4_service_date,je1.service_date AS je1_service_date,je2.service_date AS je2_service_date,je3.service_date AS je3_service_date,j11.service_date AS j11_service_date ,j12.service_date AS j12_service_date,mmr2.service_date AS mmr2_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date AS bcg_service_date 	FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('010') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('010') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('010') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('010') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('010') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS bcg ON p.person_id = bcg.person_id LEFT JOIN (SELECT e2.person_id,e2.service_date AS hbv1_service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('041','091','D51','H31') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('041','091','D51','H31') GROUP BY vs.person_id ) AS e2 GROUP BY e2.person_id ) hbv1 ON p.person_id = hbv1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS dtp3 ON p.person_id = dtp3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) hbv3 ON p.person_id = hbv3.person_id LEFT JOIN ( SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) opv3 ON p.person_id = opv3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('061','M11') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('061','M11') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('061','M11') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('061','M11') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('061','M11') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) mmr1 ON p.person_id = mmr1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp4 ON p.person_id = dtp4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('084','D34','D44','D54','I14') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id ) AS opv4 ON p.person_id = opv4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('051') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('051') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('051') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('051') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('051') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je1 ON p.person_id = je1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('052') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('052') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('052') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('052') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id  		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('052') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je2 ON p.person_id = je2.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J11') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J11') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J11') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J11') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl 		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J11') GROUP BY vs.person_id 	) AS e1 GROUP BY e1.person_id ) AS j11 ON p.person_id = j11.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('053') GROUP BY pw.person_id UNION ALL 		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('053') GROUP BY pe.person_id 		UNION ALL 		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('053') GROUP BY pve.person_id 		UNION ALL 		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('053') GROUP BY p.person_id 		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('053') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je3 ON p.person_id = je3.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J12') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J12') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J12') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS j12 ON p.person_id = j12.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('073','M12') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('073','M12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('073','M12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS mmr2 ON p.person_id = mmr2.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 3 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir4 As DataTable = sqlf.QueryAsDatatable(sql)

        '1 Year
        Dim bcg As New DataColumn("BCG_STATUS", GetType(Image))
        Dim hbv1 As New DataColumn("HBV1_STATUS", GetType(Image))
        Dim dtp_hbv3 As New DataColumn("DTP_HBV3_STATUS", GetType(Image))
        Dim opv3 As New DataColumn("OPV3_STATUS", GetType(Image))
        Dim mmr1 As New DataColumn("MMR1_STATUS", GetType(Image))
        '2 Year
        Dim dtp4 As New DataColumn("DTP4_STATUS", GetType(Image))
        Dim opv4 As New DataColumn("OPV4_STATUS", GetType(Image))
        '3 Year
        Dim je As New DataColumn("JE_STATUS", GetType(Image))
        Dim mmr2 As New DataColumn("MMR2_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))

        epir4.Columns.Add(bcg)
        epir4.Columns.Add(hbv1)
        epir4.Columns.Add(dtp_hbv3)
        epir4.Columns.Add(opv3)
        epir4.Columns.Add(mmr1)
        epir4.Columns.Add(dtp4)
        epir4.Columns.Add(opv4)
        epir4.Columns.Add(je)
        epir4.Columns.Add(mmr2)
        epir4.Columns.Add(cov)
        For i = 0 To epir4.Rows.Count - 1
            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" Then
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("hbv1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.cross16
            End If
            Dim je_cov As Boolean = False
            If (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "" And epir4.Rows(i).Item("je3_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je3_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "" And epir4.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("j11_service_date").ToString <> "" And epir4.Rows(i).Item("j12_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j12_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            Else
                epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                je_cov = False
            End If
            If epir4.Rows(i).Item("mmr2_service_date").ToString <> "" Then
                epir4.Rows(i).Item("MMR2_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("MMR2_STATUS") = My.Resources.cross16
            End If

            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" And epir4.Rows(i).Item("hbv1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" And epir4.Rows(i).Item("opv3_service_date").ToString <> "" And epir4.Rows(i).Item("mmr1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp4_service_date").ToString <> "" And epir4.Rows(i).Item("opv4_service_date").ToString <> "" And je_cov And epir4.Rows(i).Item("mmr2_service_date").ToString <> "" And epir4.Rows(i).Item("mmr2_service_date").ToString <> "" Then
                If epir4.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                Else
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
                End If
            Else
                epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir4
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("bcg_service_date").HeaderText = "วันที่ได้รับ BCG"
        reportData_table.Columns("BCG_STATUS").HeaderText = "การได้รับ BCG"
        reportData_table.Columns("hbv1_service_date").HeaderText = "วันที่ได้รับ HBV1"
        reportData_table.Columns("HBV1_STATUS").HeaderText = "การได้รับ HBV1"
        reportData_table.Columns("dtp3_service_date").HeaderText = "วันที่ได้รับ DTP3"
        reportData_table.Columns("hbv3_service_date").HeaderText = "วันที่ได้รับ HBV3"
        reportData_table.Columns("DTP_HBV3_STATUS").HeaderText = "การได้รับ DTP-HBV3"
        reportData_table.Columns("opv3_service_date").HeaderText = "วันที่ได้รับ OPV3"
        reportData_table.Columns("OPV3_STATUS").HeaderText = "การได้รับ OPV3"
        reportData_table.Columns("mmr1_service_date").HeaderText = "วันที่ได้รับ MMR1"
        reportData_table.Columns("MMR1_STATUS").HeaderText = "การได้รับ MMR1"
        reportData_table.Columns("DTP4_STATUS").HeaderText = "การได้รับ DTP4"
        reportData_table.Columns("dtp4_service_date").HeaderText = "วันที่ได้รับ DTP4"
        reportData_table.Columns("JE_STATUS").HeaderText = "การได้รับ JE"
        reportData_table.Columns("je1_service_date").HeaderText = "วันที่ได้รับ JE1 เชื้อตาย"
        reportData_table.Columns("je2_service_date").HeaderText = "วันที่ได้รับ JE2 เชื้อตาย"
        reportData_table.Columns("je3_service_date").HeaderText = "วันที่ได้รับ JE3 เชื้อตาย"
        reportData_table.Columns("j11_service_date").HeaderText = "วันที่ได้รับ J11 เชื้อเป็น"
        reportData_table.Columns("j12_service_date").HeaderText = "วันที่ได้รับ J12 เชื้อเป็น"
        reportData_table.Columns("OPV4_STATUS").HeaderText = "การได้รับ OPV4"
        reportData_table.Columns("opv4_service_date").HeaderText = "วันที่ได้รับ OPV4"
        reportData_table.Columns("mmr2_service_date").HeaderText = "วันที่ได้รับ MMR2"
        reportData_table.Columns("MMR2_STATUS").HeaderText = "การได้รับ MMR2"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub covrage5year()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานความครอบคลุมการได้รับวัคซีนแครบตามเกณฑ์ในเด็กอายุครบ 5 ปี (fully immunized)"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,CASE    WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 10 and 12 then 1 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 1 and 3 then 2 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 4 and 6 then 3 WHEN MONTH(DATE_ADD(p.birthdate,INTERVAL 5 YEAR)) BETWEEN 7 and 9 then 4 END quater_y, DATE_ADD(p.birthdate,INTERVAL 5 YEAR) AS date_target,bcg.bcg_service_date,hbv1.hbv1_service_date,dtp3.service_date AS dtp3_service_date,hbv3.service_date AS hbv3_service_date,opv3.service_date AS opv3_service_date,mmr1.service_date AS mmr1_service_date,dtp4.service_date AS dtp4_service_date,opv4.service_date AS opv4_service_date,je1.service_date AS je1_service_date,je2.service_date AS je2_service_date,je3.service_date AS je3_service_date,j11.service_date AS j11_service_date ,j12.service_date AS j12_service_date,mmr2.service_date AS mmr2_service_date,dtp5.service_date AS dtp5_service_date,opv5.service_date AS opv5_service_date FROM person p LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (	SELECT e1.person_id,e1.service_date AS bcg_service_date 	FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('010') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('010') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('010') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('010') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('010') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS bcg ON p.person_id = bcg.person_id LEFT JOIN (SELECT e2.person_id,e2.service_date AS hbv1_service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('041','091','D51','H31') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('041','091','D51','H31') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('041','091','D51','H31') GROUP BY vs.person_id ) AS e2 GROUP BY e2.person_id ) hbv1 ON p.person_id = hbv1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('033','093','D13','D23','D33','D43','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) AS dtp3 ON p.person_id = dtp3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('043','093','H33','D23','D53') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) hbv3 ON p.person_id = hbv3.person_id LEFT JOIN ( SELECT e1.person_id,e1.service_date AS service_date FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('083','D33','D43','D53','I13') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) opv3 ON p.person_id = opv3.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date AS service_date FROM ( SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('061','M11') GROUP BY pw.person_id UNION ALL SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id WHERE ev.export_vaccine_code IN('061','M11') GROUP BY pe.person_id UNION ALL SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id WHERE pv.export_vaccine_code IN('061','M11') GROUP BY pve.person_id UNION ALL SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid WHERE pv.export_vaccine_code IN('061','M11') GROUP BY p.person_id UNION ALL SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id WHERE sv.export_vaccine_code IN('061','M11') GROUP BY vs.person_id ) AS e1 GROUP BY e1.person_id ) mmr1 ON p.person_id = mmr1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('034','D14','D24','D34','D44','D54') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp4 ON p.person_id = dtp4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('084','D34','D44','D54','I14') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('084','D34','D44','D54','I14') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id ) AS opv4 ON p.person_id = opv4.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('051') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('051') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('051') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('051') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('051') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je1 ON p.person_id = je1.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('052') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('052') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('052') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('052') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id  		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('052') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je2 ON p.person_id = je2.person_id LEFT JOIN (		SELECT e1.person_id,e1.service_date 	FROM (		SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J11') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J11') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J11') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J11') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl 		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J11') GROUP BY vs.person_id 	) AS e1 GROUP BY e1.person_id ) AS j11 ON p.person_id = j11.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('053') GROUP BY pw.person_id UNION ALL 		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('053') GROUP BY pe.person_id 		UNION ALL 		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('053') GROUP BY pve.person_id 		UNION ALL 		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('053') GROUP BY p.person_id 		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('053') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS je3 ON p.person_id = je3.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('J12') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('J12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('J12') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('J12') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('J12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS j12 ON p.person_id = j12.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('073','M12') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('073','M12') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('073','M12') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('073','M12') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS mmr2 ON p.person_id = mmr2.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('035','D35','D45','D55') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('035','D35','D45','D55') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dtp5 ON p.person_id = dtp5.person_id LEFT JOIN (	SELECT e1.person_id,e1.service_date FROM (		SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate FROM person_vaccine pv INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id INNER JOIN ovst o ON ov.vn = o.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('085','D35','D45','D55','I15') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('085','D35','D45','D55','I15') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS opv5 ON p.person_id = opv5.person_id WHERE hrt.export_code IN(1,3) AND p.person_discharge_id = 9 AND n.nhso_code IN('099') AND DATE_ADD(p.birthdate,INTERVAL 5 YEAR) BETWEEN '" & SharingEntrities.year_set - 1 & "-10-01' AND '" & SharingEntrities.year_set & "-09-31'"
        Dim epir4 As DataTable = sqlf.QueryAsDatatable(sql)

        '1 Year
        Dim bcg As New DataColumn("BCG_STATUS", GetType(Image))
        Dim hbv1 As New DataColumn("HBV1_STATUS", GetType(Image))
        Dim dtp_hbv3 As New DataColumn("DTP_HBV3_STATUS", GetType(Image))
        Dim opv3 As New DataColumn("OPV3_STATUS", GetType(Image))
        Dim mmr1 As New DataColumn("MMR1_STATUS", GetType(Image))
        '2 Year
        Dim dtp4 As New DataColumn("DTP4_STATUS", GetType(Image))
        Dim opv4 As New DataColumn("OPV4_STATUS", GetType(Image))
        '3 Year
        Dim je As New DataColumn("JE_STATUS", GetType(Image))
        Dim mmr2 As New DataColumn("MMR2_STATUS", GetType(Image))
        Dim cov As New DataColumn("COVERAGE_STATUS", GetType(Image))
        '5 year 
        Dim dtp5 As New DataColumn("DTP5_STATUS", GetType(Image))
        Dim opv5 As New DataColumn("OPV5_STATUS", GetType(Image))
        epir4.Columns.Add(bcg)
        epir4.Columns.Add(hbv1)
        epir4.Columns.Add(dtp_hbv3)
        epir4.Columns.Add(opv3)
        epir4.Columns.Add(mmr1)
        epir4.Columns.Add(dtp4)
        epir4.Columns.Add(opv4)
        epir4.Columns.Add(je)
        epir4.Columns.Add(mmr2)
        epir4.Columns.Add(dtp5)
        epir4.Columns.Add(opv5)
        epir4.Columns.Add(cov)
        For i = 0 To epir4.Rows.Count - 1
            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" Then
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("BCG_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("hbv1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("HBV1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP_HBV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv3_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV3_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("mmr1_service_date").ToString <> "" Then
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("MMR1_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP4_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv4_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV4_STATUS") = My.Resources.cross16
            End If
            Dim je_cov As Boolean = False
            If (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "" And epir4.Rows(i).Item("je3_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je3_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("je2_service_date").ToString <> "" And epir4.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date And Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("j11_service_date").ToString <> "" And epir4.Rows(i).Item("j12_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j12_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            ElseIf (epir4.Rows(i).Item("je1_service_date").ToString <> "" And epir4.Rows(i).Item("j11_service_date").ToString <> "") Then
                If Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("j11_service_date").ToString).Date Then
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.check16
                    je_cov = True
                Else
                    epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                    je_cov = False
                End If
            Else
                epir4.Rows(i).Item("JE_STATUS") = My.Resources.cross16
                je_cov = False
            End If
            If epir4.Rows(i).Item("mmr2_service_date").ToString <> "" Then
                epir4.Rows(i).Item("MMR2_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("MMR2_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("dtp5_service_date").ToString <> "" Then
                epir4.Rows(i).Item("DTP5_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("DTP5_STATUS") = My.Resources.cross16
            End If
            If epir4.Rows(i).Item("opv5_service_date").ToString <> "" Then
                epir4.Rows(i).Item("OPV5_STATUS") = My.Resources.check16
            Else
                epir4.Rows(i).Item("OPV5_STATUS") = My.Resources.cross16
            End If

            If epir4.Rows(i).Item("bcg_service_date").ToString <> "" And epir4.Rows(i).Item("hbv1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp3_service_date").ToString <> "" And epir4.Rows(i).Item("hbv3_service_date").ToString <> "" And epir4.Rows(i).Item("opv3_service_date").ToString <> "" And epir4.Rows(i).Item("mmr1_service_date").ToString <> "" And epir4.Rows(i).Item("dtp4_service_date").ToString <> "" And epir4.Rows(i).Item("opv4_service_date").ToString <> "" And je_cov And epir4.Rows(i).Item("mmr2_service_date").ToString <> "" And epir4.Rows(i).Item("mmr2_service_date").ToString <> "" And epir4.Rows(i).Item("dtp5_service_date").ToString <> "" And epir4.Rows(i).Item("opv5_service_date").ToString <> "" Then
                If epir4.Rows(i).Item("j11_service_date").ToString <> "" Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                ElseIf Date.Parse(epir4.Rows(i).Item("je1_service_date").ToString).Date < Date.Parse(epir4.Rows(i).Item("je2_service_date").ToString).Date Then
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.check16
                Else
                    epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
                End If
            Else
                epir4.Rows(i).Item("COVERAGE_STATUS") = My.Resources.cross16
            End If
        Next
        reportData_table.DataSource = epir4
        reportData_table.Columns("person_id").HeaderText = "เลขทะเบียนบุคคล"
        reportData_table.Columns("cid").HeaderText = "เลขบัตรประชาชน"
        reportData_table.Columns("fullname").HeaderText = "ชื่อ-สกุล"
        reportData_table.Columns("birthdate").HeaderText = "วันเกิด"
        reportData_table.Columns("address").HeaderText = "บ้านเลขที่"
        reportData_table.Columns("village_moo").HeaderText = "หมู่ที่"
        reportData_table.Columns("village_name").HeaderText = "ชื่อหมู่บ้าน"
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("quater_y").HeaderText = "ไตรมาศที่อายุครบ"
        reportData_table.Columns("date_target").HeaderText = "วันที่อายุครบ"

        reportData_table.Columns("bcg_service_date").HeaderText = "วันที่ได้รับ BCG"
        reportData_table.Columns("BCG_STATUS").HeaderText = "การได้รับ BCG"
        reportData_table.Columns("hbv1_service_date").HeaderText = "วันที่ได้รับ HBV1"
        reportData_table.Columns("HBV1_STATUS").HeaderText = "การได้รับ HBV1"
        reportData_table.Columns("dtp3_service_date").HeaderText = "วันที่ได้รับ DTP3"
        reportData_table.Columns("hbv3_service_date").HeaderText = "วันที่ได้รับ HBV3"
        reportData_table.Columns("DTP_HBV3_STATUS").HeaderText = "การได้รับ DTP-HBV3"
        reportData_table.Columns("opv3_service_date").HeaderText = "วันที่ได้รับ OPV3"
        reportData_table.Columns("OPV3_STATUS").HeaderText = "การได้รับ OPV3"
        reportData_table.Columns("mmr1_service_date").HeaderText = "วันที่ได้รับ MMR1"
        reportData_table.Columns("MMR1_STATUS").HeaderText = "การได้รับ MMR1"
        reportData_table.Columns("DTP4_STATUS").HeaderText = "การได้รับ DTP4"
        reportData_table.Columns("dtp4_service_date").HeaderText = "วันที่ได้รับ DTP4"
        reportData_table.Columns("JE_STATUS").HeaderText = "การได้รับ JE"
        reportData_table.Columns("je1_service_date").HeaderText = "วันที่ได้รับ JE1 เชื้อตาย"
        reportData_table.Columns("je2_service_date").HeaderText = "วันที่ได้รับ JE2 เชื้อตาย"
        reportData_table.Columns("je3_service_date").HeaderText = "วันที่ได้รับ JE3 เชื้อตาย"
        reportData_table.Columns("j11_service_date").HeaderText = "วันที่ได้รับ J11 เชื้อเป็น"
        reportData_table.Columns("j12_service_date").HeaderText = "วันที่ได้รับ J12 เชื้อเป็น"
        reportData_table.Columns("OPV4_STATUS").HeaderText = "การได้รับ OPV4"
        reportData_table.Columns("opv4_service_date").HeaderText = "วันที่ได้รับ OPV4"
        reportData_table.Columns("mmr2_service_date").HeaderText = "วันที่ได้รับ MMR2"
        reportData_table.Columns("MMR2_STATUS").HeaderText = "การได้รับ MMR2"
        reportData_table.Columns("dtp5_service_date").HeaderText = "วันที่ได้รับ DTP5"
        reportData_table.Columns("DTP5_STATUS").HeaderText = "การได้รับ DTP5"
        reportData_table.Columns("opv5_service_date").HeaderText = "วันที่ได้รับ OPV5"
        reportData_table.Columns("OPV5_STATUS").HeaderText = "การได้รับ OPV5"
        reportData_table.Columns("COVERAGE_STATUS").HeaderText = "ความครอบคลุม"
        Cursor = Cursors.Default
    End Sub
    Private Sub reportStudent6()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานนักเรียนชั้น ป.6 ที่ได้รับวัคซีน dT"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,vo.school_name,vsc.village_school_class_name,dts4.service_date AS dts4_service_date FROM village_student vs LEFT JOIN village_school_class vsc ON vs.village_school_class_id = vsc.village_school_class_id LEFT JOIN village_school vo ON vs.village_school_id = vo.village_school_id LEFT JOIN person p ON vs.person_id = p.person_id LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (SELECT e1.person_id,e1.service_date 	FROM (SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('024') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('024') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('024') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('024') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('024') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS dts4 ON p.person_id = dts4.person_id WHERE (discharge IS  NULL OR discharge <> 'Y') AND vsc.village_school_class_id IN(9)"
        Dim rep As DataTable = sqlf.QueryAsDatatable(sql)
        Dim dts4 As New DataColumn("DTS4_STATUS", GetType(Image))
        rep.Columns.Add(dts4)
        For i = 0 To rep.Rows.Count - 1
            If rep.Rows(i).Item("dts4_service_date").ToString <> "" Then
                rep.Rows(i).Item("DTS4_STATUS") = My.Resources.check16
            Else
                rep.Rows(i).Item("DTS4_STATUS") = My.Resources.cross16
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
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"

        reportData_table.Columns("DTS4_STATUS").HeaderText = "การได้รับ DTs4"
        reportData_table.Columns("dts4_service_date").HeaderText = "วันที่ได้รับ DTs4"
        reportData_table.Columns("school_name").HeaderText = "ชื่อโรงเรียน"
        reportData_table.Columns("village_school_class_name").HeaderText = "ชั้นเรียน"
        Cursor = Cursors.Default
    End Sub
    Private Sub reportStudent5()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานการได้รับวัคซีนเอชพีวีในเด็กนักเรียนหญิงชั้น ป.5"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,vo.school_name,vsc.village_school_class_name,hpvs1.service_date AS hpvs1_service_date,hpvs2.service_date AS hpvs2_service_date FROM village_student vs LEFT JOIN village_school_class vsc ON vs.village_school_class_id = vsc.village_school_class_id LEFT JOIN village_school vo ON vs.village_school_id = vo.village_school_id LEFT JOIN person p ON vs.person_id = p.person_id LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (SELECT e1.person_id,e1.service_date	FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id WHERE wv.export_vaccine_code IN('310') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('310') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('310') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('310') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('310') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS hpvs1 ON p.person_id = hpvs1.person_id LEFT JOIN (SELECT e1.person_id,e1.service_date	FROM (SELECT pw.person_id,pws.service_date FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 	WHERE wv.export_vaccine_code IN('320') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('320') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('320') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('320') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('320') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS hpvs2 ON p.person_id = hpvs2.person_id WHERE (discharge IS  NULL OR discharge <> 'Y') AND vsc.village_school_class_id IN(8)"
        Dim rep As DataTable = sqlf.QueryAsDatatable(sql)
        Dim hpv1 As New DataColumn("HPVs1_STATUS", GetType(Image))
        Dim hpv2 As New DataColumn("HPVs2_STATUS", GetType(Image))
        rep.Columns.Add(hpv1)
        rep.Columns.Add(hpv2)
        For i = 0 To rep.Rows.Count - 1
            If rep.Rows(i).Item("hpvs1_service_date").ToString <> "" Then
                rep.Rows(i).Item("HPVs1_STATUS") = My.Resources.check16
            Else
                rep.Rows(i).Item("HPVs1_STATUS") = My.Resources.cross16
            End If
            If rep.Rows(i).Item("hpvs2_service_date").ToString <> "" Then
                rep.Rows(i).Item("HPVs2_STATUS") = My.Resources.check16
            Else
                rep.Rows(i).Item("HPVs2_STATUS") = My.Resources.cross16
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
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("HPVs1_STATUS").HeaderText = "การได้รับ HPVs1"
        reportData_table.Columns("hpvs1_service_date").HeaderText = "วันที่ได้รับ HPVs1"
        reportData_table.Columns("HPVs2_STATUS").HeaderText = "การได้รับ HPVs2"
        reportData_table.Columns("hpvs2_service_date").HeaderText = "วันที่ได้รับ HPVs2"
        reportData_table.Columns("school_name").HeaderText = "ชื่อโรงเรียน"
        reportData_table.Columns("village_school_class_name").HeaderText = "ชั้นเรียน"
        Cursor = Cursors.Default
    End Sub
    Private Sub reportStudent1()
        Cursor = Cursors.WaitCursor
        report_title_tf.Text = "   รายงานนักเรียนชั้น ป.1 ที่ได้รับวัคซีน MMR"
        reportData_table.DataSource = Nothing
        Dim sql As String = "SELECT p.person_id,p.cid,CONCAT(p.pname,p.fname,' ',p.lname) AS fullname,p.birthdate,h.address,v.village_moo,v.village_name,th.full_name,hrt.house_regist_type_name,vo.school_name,vsc.village_school_class_name,mmrs.service_date AS mmrs_service_date FROM village_student vs LEFT JOIN village_school_class vsc ON vs.village_school_class_id = vsc.village_school_class_id LEFT JOIN village_school vo ON vs.village_school_id = vo.village_school_id LEFT JOIN person p ON vs.person_id = p.person_id LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id LEFT JOIN nationality n ON p.nationality = n.nationality LEFT JOIN house h ON p.house_id = h.house_id LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN thaiaddress th ON v.address_id = th.addressid LEFT JOIN (SELECT e1.person_id,e1.service_date 	FROM (SELECT pw.person_id,pws.service_date 		FROM person_wbc_vaccine_detail pwvd 		INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id 		INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id 		INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id 		WHERE wv.export_vaccine_code IN('072','075') GROUP BY pw.person_id		UNION ALL		SELECT pe.person_id,pev.vaccine_date 		FROM epi_vaccine ev 		INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id 		INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id 		INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id 		WHERE ev.export_vaccine_code IN('072','075') GROUP BY pe.person_id		UNION ALL		SELECT pve.person_id,pve.vaccine_date 		FROM person_vaccine_elsewhere pve 		INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id 		WHERE pv.export_vaccine_code IN('072','075') GROUP BY pve.person_id		UNION ALL		SELECT p.person_id,o.vstdate 		FROM person_vaccine pv 		INNER JOIN ovst_vaccine ov ON pv.person_vaccine_id = ov.person_vaccine_id 		INNER JOIN ovst o ON ov.vn = o.vn 		INNER JOIN patient pt ON o.hn = pt.hn 		INNER JOIN person p ON pt.cid = p.cid 		WHERE pv.export_vaccine_code IN('072','075') GROUP BY p.person_id		UNION ALL 		SELECT vs.person_id,vsv.vaccine_date FROM village_student_vaccine_list vsvl		INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id		INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id   		INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id 		WHERE sv.export_vaccine_code IN('072','075') 		GROUP BY vs.person_id	) AS e1 GROUP BY e1.person_id) AS mmrs ON p.person_id = mmrs.person_id WHERE (discharge IS  NULL OR discharge <> 'Y') AND vsc.village_school_class_id IN(4)"
        Dim rep As DataTable = sqlf.QueryAsDatatable(sql)
        Dim mmrs As New DataColumn("MMRs_STATUS", GetType(Image))
        rep.Columns.Add(mmrs)
        For i = 0 To rep.Rows.Count - 1
            If rep.Rows(i).Item("mmrs_service_date").ToString <> "" Then
                rep.Rows(i).Item("MMrs_STATUS") = My.Resources.check16
            Else
                rep.Rows(i).Item("MMrs_STATUS") = My.Resources.cross16
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
        reportData_table.Columns("full_name").HeaderText = "ตำบล อำเภอ จังหวัด"
        reportData_table.Columns("house_regist_type_name").HeaderText = "TYPEAREA"
        reportData_table.Columns("MMRs_STATUS").HeaderText = "การได้รับ MMRs"
        reportData_table.Columns("mmrs_service_date").HeaderText = "วันที่ได้รับ MMRs"
        reportData_table.Columns("school_name").HeaderText = "ชื่อโรงเรียน"
        reportData_table.Columns("village_school_class_name").HeaderText = "ชั้นเรียน"
        Cursor = Cursors.Default
    End Sub
    Private Sub epi1y_epi_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi1y_epi_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        rep1()
        reportindex = 1
        keyin = True
    End Sub

    Private Sub reportData_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles reportData_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(reportData_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub epi2y_epi_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi2y_epi_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        rep2()
        reportindex = 2
        keyin = True
    End Sub

    Private Sub reportData_table_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles reportData_table.CellDoubleClick
        If reportData_table.RowCount > 0 And keyin Then
            Dim els As New frmVccElseware
            els.set_pid(reportData_table.Item("person_id", e.RowIndex).Value.ToString)
            els.set_RepID(reportindex)
            els.ShowDialog()
            If reportindex = 1 Then
                rep1()
            ElseIf reportindex = 2 Then
                rep2()
            ElseIf reportindex = 3 Then
                rep3()
            ElseIf reportindex = 4 Then
                rep4()
            ElseIf reportindex = 5 Then
                covrage1year()
            ElseIf reportindex = 6 Then
                covrage2year()
            ElseIf reportindex = 7 Then
                covrage3year()
            ElseIf reportindex = 8 Then
                covrage5year()
            ElseIf reportindex = 9 Then
                reportStudent6()
            ElseIf reportindex = 10 Then
                reportStudent5()
            ElseIf reportindex = 11 Then
                reportStudent1()
            End If

        End If
    End Sub

    Private Sub epi3y_epi_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi3y_epi_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        rep3()
        reportindex = 3
        keyin = True
    End Sub

    Private Sub epi5y_epi_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi5y_epi_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        rep4()
        reportindex = 4
        keyin = True
    End Sub

    Private Sub epi1y_epi_cov_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi1y_epi_cov_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        covrage1year()
        reportindex = 5
        keyin = True
    End Sub

    Private Sub epi2y_epi_cov_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi2y_epi_cov_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        covrage2year()
        reportindex = 6
        keyin = True
    End Sub

    Private Sub epi3y_epi_cov_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi3y_epi_cov_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        covrage3year()
        reportindex = 7
        keyin = True
    End Sub

    Private Sub epi5y_epi_cov_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles epi5y_epi_cov_b.NodeDoubleClick
        Dim ys As New frmGetQuarter
        ys.ShowDialog()
        covrage5year()
        reportindex = 8
        keyin = True
    End Sub

    Private Sub studentRep6_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentRep6_b.NodeDoubleClick
        reportStudent6()
        reportindex = 9
        keyin = True
    End Sub

    Private Sub studentRep5_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentRep5_b.NodeDoubleClick
        reportStudent5()
        reportindex = 10
        keyin = True
    End Sub

    Private Sub studentRep1_b_NodeDoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles studentRep1_b.NodeDoubleClick
        reportStudent1()
        reportindex = 11
        keyin = True
    End Sub

    Private Sub export_43f_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_43f_b.Click
        If reportData_table.RowCount > 0 Then
            Dim cidlist As New List(Of String)
            For i As Integer = 0 To reportData_table.RowCount - 1
                cidlist.Add(reportData_table.Item("cid", i).Value.ToString)
            Next
            Dim exportclass As New exportFromCid
            exportclass.exportEpiCid(cidlist)
            exportclass.exportPersonCid(cidlist)
            exportclass.Export43FEPI()
        Else
            MessageBox.Show("กรุณาประมวลผลรายงานก่อนส่งออก")
        End If
    End Sub
End Class