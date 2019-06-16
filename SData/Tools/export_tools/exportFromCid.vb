Imports System.Globalization
Imports System.IO
Imports Ionic.Zip

Public Class exportFromCid
    Dim epi As DataTable = Nothing
    Dim person As DataTable = Nothing
    Dim sqlf As New SQLManager
    Public Sub exportEpiCid(ByVal cidlist As List(Of String))
        Dim cid As String = ""
        For i As Integer = 0 To cidlist.Count - 1
            cid &= "'" & cidlist(i) & "',"
        Next
        cid = cid.Substring(0, cid.Length - 1)
        'บัญชี 3
        Dim sql = "SELECT " & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0')) AS PID," & _
        "os.seq_id AS SEQ," & _
        "DATE_FORMAT(pws.service_date,'%Y%m%d') AS DATE_SERV," & _
        "wv.export_vaccine_code AS VACCINETYPE," & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS VACCINEPLACE," & _
        "pwvd.doctor_code AS PROVIDER," & _
        "DATE_FORMAT(pw.last_update,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p " & _
        "INNER JOIN person_wbc pw ON p.person_id = pw.person_id " & _
        "INNER JOIN person_wbc_service pws ON pws.person_wbc_id = pw.person_wbc_id " & _
        "INNER JOIN person_wbc_vaccine_detail pwvd  ON pws.person_wbc_service_id = pwvd.person_wbc_service_id " & _
        "INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id " & _
        "LEFT JOIN ovst o ON o.vn = pws.vn " & _
        "LEFT JOIN ovst_seq os ON o.vn = os.vn " & _
        "WHERE p.cid IN(" & cid & ")"
        epi = sqlf.QueryAsDatatable(sql)
        'บัญชี 4
        sql = "SELECT " & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0')) AS PID," & _
        "s.seq_id AS SEQ," & _
        "DATE_FORMAT(pev.vaccine_date,'%Y%m%d') AS DATE_SERV," & _
        "ev.export_vaccine_code AS VACCINETYPE," & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS VACCINEPLACE," & _
        "pevl.doctor_code AS PROVIDER," & _
        "DATE_FORMAT(pe.last_update,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p " & _
        "INNER JOIN person_epi pe ON p.person_id = pe.person_id " & _
        "INNER JOIN person_epi_vaccine pev ON pe.person_epi_id = pev.person_epi_id " & _
        "INNER JOIN person_epi_vaccine_list pevl ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id " & _
        "INNER JOIN epi_vaccine ev ON pevl.epi_vaccine_id = ev.epi_vaccine_id " & _
        "LEFT JOIN ovst_seq s ON pev.vn = s.vn " & _
        "WHERE p.cid IN(" & cid & ")"
        epi.Merge(sqlf.QueryAsDatatable(sql), True, MissingSchemaAction.Ignore)
        'บัญชี 5
        sql = "SELECT " & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0')) AS PID," & _
        "s.seq_id AS SEQ," & _
        "DATE_FORMAT(vsv.vaccine_date,'%Y%m%d') AS DATE_SERV," & _
        "sv.export_vaccine_code AS VACCINETYPE," & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS VACCINEPLACE ," & _
        "vsvl.doctor_code AS PROVIDER," & _
        "DATE_FORMAT(vs.last_update,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p " & _
        "INNER JOIN village_student vs ON p.person_id = vs.person_id " & _
        "INNER JOIN village_student_vaccine vsv ON vsv.village_student_id = vs.village_student_id " & _
        "INNER JOIN village_student_vaccine_list vsvl ON vsv.village_student_vaccine_id = vsvl.village_student_vaccine_id " & _
        "INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id " & _
        "LEFT JOIN ovst_seq s ON vsv.vn = s.vn " & _
        "WHERE p.cid IN(" & cid & ")"
        epi.Merge(sqlf.QueryAsDatatable(sql), True, MissingSchemaAction.Ignore)
        'Other
        sql = "SELECT " & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0')) AS PID," & _
        "NULL AS SEQ ," & _
        "DATE_FORMAT(pve.vaccine_date,'%Y%m%d') AS DATE_SERV," & _
        "pv.export_vaccine_code AS VACCINETYPE," & _
        "pve.hospcode AS VACCINEPLACE ," & _
        "NULL AS PROVIDER," & _
        "DATE_FORMAT(pve.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p " & _
        "INNER JOIN person_vaccine_elsewhere pve ON p.person_id = pve.person_id " & _
        "INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id " & _
        "WHERE p.cid IN(" & cid & ")"
        epi.Merge(sqlf.QueryAsDatatable(sql), True, MissingSchemaAction.Ignore)
        'One Stop
        sql = "SELECT " & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0')) AS PID," & _
        "os.seq_id AS SEQ ," & _
        "DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV," & _
        "pv.export_vaccine_code AS VACCINETYPE," & _
        "(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS VACCINEPLACE ," & _
        "ov.doctor_code AS PROVIDER," & _
        "DATE_FORMAT(os.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p " & _
        "INNER JOIN patient pt ON pt.cid = p.cid " & _
        "INNER JOIN ovst o ON pt.hn = o.hn " & _
        "INNER JOIN ovst_vaccine ov ON o.vn = ov.vn " & _
        "INNER JOIN person_vaccine pv ON pv.person_vaccine_id = ov.person_vaccine_id " & _
        "LEFT JOIN ovst_seq os ON os.vn = o.vn " & _
        "WHERE p.cid IN(" & cid & ")"
        epi.Merge(sqlf.QueryAsDatatable(sql), True, MissingSchemaAction.Ignore)
    End Sub
    Public Sub exportPersonCid(ByVal cidlist As List(Of String))
        Dim cid As String = ""
        For i As Integer = 0 To cidlist.Count - 1
            cid &= "'" & cidlist(i) & "',"
        Next
        cid = cid.Substring(0, cid.Length - 1)
        Dim sql As String = "SELECT   " & _
        "(SELECT hospitalcode from opdconfig LIMIT 1) AS HOSPCODE," & _
        "p.cid AS CID," & _
        "IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID," & _
        "h.house_id AS HID," & _
        "IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME," & _
        "p.fname AS NAME," & _
        "p.lname AS LNAME," & _
        "pt.hn AS HN," & _
        "p.sex AS SEX," & _
        "DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH," & _
        "p.marrystatus AS MSTATUS," & _
        "p.occupation AS OCCUPATION_OLD," & _
        "oc.nhso_code AS OCCUPATION_NEW," & _
        "nt2.nhso_code AS RACE," & _
        "nt.nhso_code AS NATION," & _
        "rl.nhso_code AS RELIGION," & _
        "ed.provis_code AS EDUCATION," & _
        "p.person_house_position_id AS FSTATUS," & _
        "p.father_cid AS FATHER,  " & _
        "p.mother_cid AS MOTHER," & _
        "p.sps_cid AS COUPLE," & _
        "(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS," & _
        "DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN," & _
        "p.person_discharge_id AS DISCHARGE," & _
        "DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE," & _
        "pb.code AS ABOGROUP," & _
        "'' AS RHGROUP," & _
        "pl.nhso_code AS LABOR," & _
        "pt.passport_no AS PASSPORT," & _
        "hr.export_code AS TYPEAREA," & _
        "DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE " & _
        "FROM person p  " & _
        "LEFT OUTER JOIN house h ON h.house_id = p.house_id  " & _
        "LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%'   " & _
        "LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation  " & _
        "LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality  " & _
        "LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship  " & _
        "LEFT OUTER JOIN education ed ON ed.education = p.education  " & _
        "LEFT OUTER JOIN religion rl ON rl.religion = p.religion  " & _
        "LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group  " & _
        "LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id  " & _
        "LEFT OUTER JOIN village v ON v.village_id = h.village_id  " & _
        "LEFT OUTER JOIN pname pn ON pn.name = p.pname  " & _
        "LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id  " & _
        "LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname " & _
        "WHERE p.cid IN(" & cid & ") " & _
        "ORDER BY p.person_id ASC"
        person = sqlf.QueryAsDatatable(sql)
    End Sub
    Public Sub Export43FEPI()
        Try
            Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
            Dim sw As StreamWriter
            Dim appendMode As Boolean = False
            Dim sql = "SELECT hospitalcode FROM opdconfig LIMIT 1"
            Dim hos As DataTable = sqlf.QueryAsDatatable(sql)
            Dim hospcode As String = "00000"
            If hos.Rows.Count > 0 Then
                hospcode = hos.Rows(0).Item("hospitalcode").ToString
            End If
            Dim dupdate As String = Date.Now.ToString("yyyyMMddHHmmss", New CultureInfo("en-GB"))
            Dim fileExportFoder As String = "C:\temp\F43_" & hospcode & "_" & dupdate
            If (Not System.IO.Directory.Exists(fileExportFoder)) Then
                System.IO.Directory.CreateDirectory(fileExportFoder)
            End If

            If epi.Rows.Count > 0 Then
                sw = New StreamWriter(fileExportFoder & "\EPI.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                Dim data As String = ""
                For i As Integer = 0 To epi.Columns.Count - 1
                    header &= epi.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                For r As Integer = 0 To epi.Rows.Count - 1
                    data = ""
                    For c As Integer = 0 To epi.Columns.Count - 1
                        data &= epi.Rows(r).Item(c).ToString() & "|"
                    Next
                    sw.WriteLine(data.Substring(0, data.Length - 1))
                Next
                sw.Close()
            Else
                sw = New StreamWriter(fileExportFoder & "\EPI.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                For i As Integer = 0 To epi.Columns.Count - 1
                    header &= epi.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                sw.Close()
            End If

            If person.Rows.Count > 0 Then
                sw = New StreamWriter(fileExportFoder & "\PERSON.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                Dim data As String = ""
                For i As Integer = 0 To person.Columns.Count - 1
                    header &= person.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                For r As Integer = 0 To person.Rows.Count - 1
                    data = ""
                    For c As Integer = 0 To person.Columns.Count - 1
                        data &= person.Rows(r).Item(c).ToString() & "|"
                    Next
                    sw.WriteLine(data.Substring(0, data.Length - 1))
                Next
                sw.Close()
            Else
                sw = New StreamWriter(fileExportFoder & "\PERSON.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                For i As Integer = 0 To person.Columns.Count - 1
                    header &= person.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                sw.Close()
            End If
            Dim zip As ZipFile = New ZipFile
            zip.AddDirectory(fileExportFoder)
            zip.Save(fileExportFoder & ".ZIP")
            zip.Dispose()
            MessageBox.Show("ส่งออกข้อมูลเรียบร้อย")
        Catch ex As Exception
            MessageBox.Show("ERROR Class : exportFromCid, Method : Export43FEPI")
        End Try
        
    End Sub
End Class
