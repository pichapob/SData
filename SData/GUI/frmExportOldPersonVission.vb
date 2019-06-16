Imports System.Globalization

Public Class frmExportOldPersonVission
    Dim sqlf As New SQLManager
    Dim assoc As New AccessoriesFunction

    Private Sub reloadPerson_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles reloadPerson_b.Click
        Cursor = Cursors.WaitCursor
        My.Settings.y_old_vission = year_older_person_tf.Value
        My.Settings.Save()
        Dim sql As String = "DELETE FROM sd_older_person"
        sqlf.Excute(sql)
        sql = "INSERT IGNORE INTO sd_older_person(person_id,hn,cid,year_entry) SELECT p.person_id,p.patient_hn,p.cid,'" & year_older_person_tf.Value & "' AS year_entry FROM (SELECT p.person_id,p.patient_hn,p.cid FROM person p LEFT JOIN village v ON v.village_id = p.village_id WHERE YEAR('" & year_older_person_tf.Value - 543 & "-01-01')-YEAR(p.birthdate) BETWEEN " & year_begin_tf.Value & " AND " & year_end_tf.Value & " AND p.house_regist_type_id IN(1,3) AND p.death <> 'Y' AND p.person_discharge_id = '9' AND v.village_moo<>0) AS p"
        sqlf.Excute(sql)
        reFreshTable()
        Cursor = Cursors.Default
    End Sub

    Private Sub reFreshTable()
        Cursor = Cursors.WaitCursor
        Dim sql As String = " SELECT valist.vn,p.cid,p.person_id,CONCAT(p.pname,p.fname,'  ',p.lname) AS full_name,p.birthdate,"
        sql &= "CONVERT(CONCAT(LPAD(timestampdiff(year,p.birthdate,NOW()),3,'0')+0,' ปี ',LPAD(timestampdiff(month,p.birthdate,NOW())-(timestampdiff(year,p.birthdate,NOW())*12),2,'0')+0,' เดือน ',LPAD(timestampdiff(day,date_add(p.birthdate,interval (timestampdiff(month,p.birthdate,NOW())) month),NOW()),2,'0')+0,' วัน'),CHAR) AS age,"
        sql &= "se.`name` AS sex,valist.vstdate,valist.vsttime,valist.l01,valist.r01,valist.lph,valist.rph,"
        sql &= "svtl.va_tranf_desc AS va_tranf_desc_l,svtr.va_tranf_desc As va_tranf_desc_r,hrt.house_regist_type_name,h.address,v.village_moo,v.village_name,t.full_name AS full_name_add "
        sql &= "FROM sd_older_person s LEFT JOIN person p ON p.cid = s.cid LEFT JOIN sex se ON se.`code` = p.sex "
        sql &= "LEFT JOIN ( "
        sql &= "    SELECT o.hn,o.vn,o.vstdate,o.vsttime,e.r01,e.l01,e.rph,e.lph "
        sql &= "    FROM eye_screen e INNER JOIN ovst o ON e.vn = o.vn AND o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' "
        sql &= "    WHERE o.vstdate = (SELECT MAX(vstdate) FROM eye_screen es INNER JOIN ovst ov ON ov.vn = es.vn WHERE ov.hn = o.hn AND ov.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "') "
        sql &= ") AS valist ON s.hn = valist.hn "
        sql &= "LEFT JOIN sd_va_list svll ON valist.l01 = svll.va_value "
        sql &= "LEFT JOIN sd_va_list svlr ON valist.r01 = svlr.va_value LEFT JOIN sd_va_tranf svtl ON svll.va_tranf = svtl.va_tranf_id "
        sql &= "LEFT JOIN sd_va_tranf svtr ON svlr.va_tranf = svtr.va_tranf_id LEFT JOIN house_regist_type hrt ON p.house_regist_type_id = hrt.house_regist_type_id "
        sql &= "LEFT JOIN village v ON v.village_id = p.village_id LEFT JOIN house h ON h.house_id = p.house_id "
        sql &= "LEFT JOIN thaiaddress t ON t.addressid = v.address_id"
        Dim rs As DataTable = sqlf.QueryAsDatatable(sql)
        Dim person As Integer = 0
        Dim va_screen As Integer = 0
        Dim va_risk As Integer = 0
        For i As Integer = 0 To rs.Rows.Count - 1
            person = person + 1
            If rs.Rows(i).Item("va_tranf_desc_l").ToString <> "" And rs.Rows(i).Item("va_tranf_desc_r").ToString <> "" Then
                va_screen = va_screen + 1
            End If
            If rs.Rows(i).Item("va_tranf_desc_l").ToString = "มองไม่เห็น" Or rs.Rows(i).Item("va_tranf_desc_r").ToString = "มองไม่เห็น" Then
                va_risk = va_risk + 1
            End If
        Next
        person_older_table.DataSource = rs
        status_tf.Text = "Status: ประชากร = " & person & " คน,คัดกรองแล้ว = " & va_screen & " คน,เสี่ยง = " & va_risk & " คน"
        Cursor = Cursors.Default
    End Sub

    Private Sub frmExportOldPersonVission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cursor = Cursors.WaitCursor

        year_older_person_tf.Value = My.Settings.y_old_vission
        Dim year_set As String = Date.Now.ToString("yyyy", New CultureInfo("en-GB")) + 543
        year_older_person_tf.Value = year_set
        begindate_tf.Value = Date.Now
        enddate_tf.Value = Date.Now
        reFreshTable()
        Cursor = Cursors.Default
    End Sub

    Private Sub refreshOutput_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles refreshOutput_b.Click
        reFreshTable()
    End Sub

    Private Sub Export_person_table_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export_person_table_b.Click
        Cursor = Cursors.WaitCursor
        Dim person As DataTable = person_older_table.DataSource
        Dim save As New SaveFileDialog
        save.Title = "ส่งออกข้อมูลในตาราง"
        save.Filter = "CSV|*.csv"
        Me.CenterToScreen()
        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            assoc.ExportDataToCSV(save.FileName, person)
            MessageBox.Show("ส่งออกข้อมูลเรียบร้อย", "SData Message")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub export_person_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_person_b.Click
        Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT p.cid,p.pname,p.fname,p.lname,p.sex,DATE_FORMAT(p.birthdate,'%d/%m/%Y') AS birthdate,v.village_moo,h.address,v.address_id,p.pttype_hospmain,p.pttype_hospsub,p.nationality,'1' AS his FROM sd_older_person sop LEFT JOIN person p ON sop.cid = p.cid LEFT JOIN village v ON v.village_id = p.village_id LEFT OUTER JOIN house h ON p.house_id = h.house_id "
        Dim person As DataTable = sqlf.QueryAsDatatable(sql)
        Dim save As New SaveFileDialog
        save.Title = "ส่งออกประชากรสำหรับ Vission2020"
        save.Filter = "CSV|*.csv"
        Dim d As String = Date.Now.ToString("yyyyMMdd_HHmmss", New CultureInfo("th-th"))
        save.FileName = "ExportPerson" & d
        Me.CenterToScreen()
        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            assoc.ExportDataToCSV(save.FileName, person)
            MessageBox.Show("ส่งออกข้อมูลเรียบร้อย", "SData Message")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub export_osm_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_osm_b.Click
        Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT p.cid,p.pname,p.fname,p.lname,DATE_FORMAT(p.birthdate, '%Y-%m-%d') AS birthday,p.sex,h.address,v.village_moo as moo,SUBSTRING(v.village_code,1,6) AS aid,DATE_FORMAT(e.vstdate,'%Y-%m-%d') AS screen_date,'Y' AS screen_status,IF(sdvr.va_tranf =2,'N','Y') AS screen_right, IF(sdvl.va_tranf =2,'N','Y') AS screen_left,(SELECT hospitalcode FROM opdconfig) as hospcode FROM (SELECT o.hn,o.vstdate,o.vsttime,s.l01,s.r01,s.lph,s.rph FROM eye_screen s	INNER JOIN ovst o ON o.vn = s.vn LEFT JOIN (SELECT o.hn,MAX(o.vstdate) AS max_date FROM eye_screen s INNER JOIN ovst o ON o.vn = s.vn WHERE o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' GROUP BY o.hn	) as m  ON o.hn = m.hn AND o.vstdate = m.max_date WHERE m.max_date IS NOT NULL AND CONCAT(ISNULL(s.l01),ISNULL(s.r01),ISNULL(lph),ISNULL(rph)) <> '' AND o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' GROUP BY m.hn,o.vstdate,o.vsttime,s.l01,s.r01,s.lph,s.rph ) AS e INNER JOIN sd_older_person op ON op.hn = e.hn INNER JOIN person p ON p.cid = op.cid INNER JOIN village v ON v.village_id = p.village_id INNER JOIN house h ON h.house_id = p.house_id LEFT JOIN sd_va_list sdvl ON e.l01 = sdvl.va_value AND sdvl.va_active='Y' LEFT JOIN sd_va_list sdvr  ON e.r01 = sdvr.va_value AND sdvr.va_active='Y' WHERE sdvl.va_tranf IS NOT NULL AND sdvr.va_tranf IS NOT NULL ORDER BY p.person_id ASC"
        Dim osm As DataTable = sqlf.QueryAsDatatable(sql)
        Dim save As New SaveFileDialog
        save.Title = "ส่งออกแปรผล อสม. สำหรับ Vission2020"
        save.Filter = "TXT|*.txt"
        Dim d As String = Date.Now.ToString("yyyyMMdd_HHmmss", New CultureInfo("th-th"))
        save.FileName = "ExportOSM" & d
        Me.CenterToScreen()
        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            assoc.ExportDataToText(save.FileName, osm)
            MessageBox.Show("ส่งออกข้อมูลเรียบร้อย", "SData Message")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub export_va_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_va_b.Click
        Dim sql As String = "SELECT p.cid,p.pname,p.fname,p.lname,DATE_FORMAT(p.birthdate, '%Y-%m-%d') AS birthday,p.sex,h.address,v.village_moo as moo,SUBSTRING(v.village_code,1,6) AS aid,IF(sdvl.va_unit=2 OR sdvr.va_unit=2,'M','F')  as unit,exr.sd_va_vission2020_export_id AS va_r,exl.sd_va_vission2020_export_id AS va_l,DATE_FORMAT(e.vstdate,'%Y-%m-%d') AS va_date,(SELECT s.hospitalcode FROM opdconfig s ) AS hospcode FROM (SELECT o.hn,o.vstdate,o.vsttime,s.l01,s.r01,s.lph,s.rph FROM eye_screen s	INNER JOIN ovst o ON o.vn = s.vn LEFT JOIN (SELECT o.hn,MAX(o.vstdate) AS max_date FROM eye_screen s INNER JOIN ovst o ON o.vn = s.vn WHERE o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' GROUP BY o.hn	) as m  ON o.hn = m.hn AND o.vstdate = m.max_date WHERE m.max_date IS NOT NULL AND CONCAT(ISNULL(s.l01),ISNULL(s.r01),ISNULL(lph),ISNULL(rph)) <> '' AND o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' ) AS e INNER JOIN sd_older_person op ON op.hn = e.hn INNER JOIN person p ON p.cid = op.cid INNER JOIN village v ON v.village_id = p.village_id INNER JOIN house h ON h.house_id = p.house_id LEFT JOIN sd_va_list sdvl ON e.l01 = sdvl.va_value AND sdvl.va_active='Y' LEFT JOIN sd_va_list sdvr  ON e.r01 = sdvr.va_value AND sdvr.va_active='Y' LEFT JOIN sd_va_vission2020 exl ON sdvl.sd_va_vission2020_id = exl.sd_va_vission2020_id LEFT JOIN sd_va_vission2020 exr ON sdvr.sd_va_vission2020_id = exr.sd_va_vission2020_id WHERE sdvl.va_tranf IS NOT NULL AND sdvr.va_tranf IS NOT NULL AND (sdvl.va_tranf = 2 OR sdvr.va_tranf = 2) ORDER BY p.person_id ASC"
        Dim valist As DataTable = sqlf.QueryAsDatatable(sql)
        Dim save As New SaveFileDialog
        save.Title = "ส่งออกผลการคัดกรอง VA สำหรับ Vission2020"
        save.Filter = "TXT|*.txt"
        Dim d As String = Date.Now.ToString("yyyyMMdd_HHmmss", New CultureInfo("th-th"))
        save.FileName = "ExportVA" & d
        Me.CenterToScreen()
        If save.ShowDialog() = Windows.Forms.DialogResult.OK Then
            assoc.ExportDataToText(save.FileName, valist)
            MessageBox.Show("ส่งออกข้อมูลเรียบร้อย", "SData Message")
        End If
        Cursor = Cursors.Default
    End Sub

    Private Sub person_older_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles person_older_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(person_older_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub
End Class