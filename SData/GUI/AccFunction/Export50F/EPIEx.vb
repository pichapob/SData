﻿Public Class EPIEx
    Dim sql As String
    Dim sqlf As New SQLManager
    Public Function ExportEPIWithDUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim epi As DataTable
        sql = "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(pas.anc_service_date,'%Y%m%d') AS DATE_SERV,ass.export_vaccine_code AS VACCINETYPE,IF(pas.anc_location_type_id = 1,(SELECT o.hospitalcode FROM opdconfig o),'00000') AS VACCINEPLACE,pasd.anc_doctor_code AS PROVIDER,DATE_FORMAT(pa.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc pa INNER JOIN person_anc_service pas ON pas.person_anc_id = pa.person_anc_id INNER JOIN person_anc_service_detail pasd ON pasd.person_anc_service_id = pas.person_anc_service_id INNER JOIN anc_service ass ON pasd.anc_service_id = ass.anc_service_id INNER JOIN person p ON p.person_id = pa.person_id LEFT JOIN ovst_seq os ON pas.vn = os.vn " & _
        "WHERE DATE(pa.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(pws.service_date,'%Y%m%d') AS DATE_SERV,wv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o LIMIT 1) AS VACCINEPLACE,pwvd.doctor_code AS PROVIDER,DATE_FORMAT(pw.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_wbc pw INNER JOIN person_wbc_service pws ON pw.person_wbc_id = pws.person_wbc_id INNER JOIN person_wbc_vaccine_detail pwvd ON pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN wbc_vaccine wv ON pwvd.wbc_vaccine_id = wv.wbc_vaccine_id INNER JOIN person p ON p.person_id  = pw.person_id LEFT JOIN ovst_seq os ON pws.vn = os.vn " & _
        "WHERE DATE(pw.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(pev.vaccine_date,'%Y%m%d') AS DATE_SERV,ev.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,pevl.doctor_code AS PROVIDER,DATE_FORMAT(pe.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_epi pe INNER JOIN person_epi_vaccine pev ON pe.person_epi_id = pev.person_epi_id INNER JOIN person_epi_vaccine_list pevl ON pev.person_epi_vaccine_id = pevl.person_epi_vaccine_id INNER JOIN epi_vaccine ev ON pevl.epi_vaccine_id = ev.epi_vaccine_id INNER JOIN person p ON pe.person_id = p.person_id LEFT JOIN ovst_seq os ON pev.vn = os.vn " & _
        "WHERE DATE(pe.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(vsv.vaccine_date,'%Y%m%d') AS DATE_SERV,sv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,vsvl.doctor_code AS PROVIDER,DATE_FORMAT(vs.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM village_student vs INNER JOIN village_student_vaccine vsv ON vs.village_student_id = vsv.village_student_id INNER JOIN village_student_vaccine_list vsvl ON vsv.village_student_vaccine_id = vsvl.village_student_vaccine_id INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN person p ON p.person_id = vs.person_id LEFT JOIN ovst_seq os ON vsv.vn = os.vn " & _
        "WHERE DATE(vs.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,'' AS SEQ,DATE_FORMAT(pve.vaccine_date,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,pve.hospcode AS VACCINEPLACE,'' AS PROVIDER,DATE_FORMAT(pve.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id INNER JOIN person p ON pve.person_id = p.person_id " & _
        "WHERE DATE(pve.update_datetime) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,s.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,ov.staff AS PROVIDER,DATE_FORMAT(s.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM ovst_vaccine ov INNER JOIN ovst o ON o.vn = ov.vn INNER JOIN ovst_seq s ON o.vn = s.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person_vaccine pv ON ov.person_vaccine_id = pv.person_vaccine_id LEFT JOIN person p ON pt.cid = p.cid " & _
        "WHERE DATE(s.update_datetime) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        epi = sqlf.QueryAsDatatable(sql)
        Return epi
    End Function
    Public Function ExportEPIWithDateserv(ByVal STARTDATE As String, ByVal ENDDATE As String)
        Dim epi As DataTable
        sql = "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(p2.anc_service_date,'%Y%m%d') AS DATE_SERV,a1.export_vaccine_code AS VACCINETYPE,IF(p2.anc_location_type_id = 1,(SELECT o.hospitalcode FROM opdconfig o),'00000') AS VACCINEPLACE,p1.anc_doctor_code AS PROVIDER,DATE_FORMAT(p3.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc_service_detail p1 INNER JOIN anc_service a1 ON p1.anc_service_id = a1.anc_service_id INNER JOIN person_anc_service p2 ON p1.person_anc_service_id = p2.person_anc_service_id INNER JOIN person_anc p3 ON p2.person_anc_id = p3.person_anc_id INNER JOIN ovst_seq q ON q.vn = p2.vn INNER JOIN ovst o ON o.vn = q.vn INNER JOIN person p ON p3.person_id = p.person_id " & _
        "WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(pws.service_date,'%Y%m%d') AS DATE_SERV,wv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,pwvd.doctor_code AS PROVIDER,DATE_FORMAT(pw.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON wv.wbc_vaccine_id = pwvd.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id INNER JOIN person p ON pw.person_id = p.person_id INNER JOIN ovst_seq q ON q.vn = pws.vn " & _
        "WHERE pws.service_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(pev.vaccine_date,'%Y%m%d') AS DATE_SERV,ev.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,pevl.doctor_code AS PROVIDER,DATE_FORMAT(pe.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id INNER JOIN person p ON pe.person_id = p.person_id INNER JOIN ovst_seq q ON pev.vn = q.vn " & _
        "WHERE pev.vaccine_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(vsv.vaccine_date,'%Y%m%d') AS DATE_SERV,sv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,vsvl.doctor_code AS PROVIDER,DATE_FORMAT(vs.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id INNER JOIN person p ON p.person_id = vs.person_id INNER JOIN ovst_seq q ON vsv.vn = q.vn " & _
        "WHERE vsv.vaccine_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,'' AS SEQ,DATE_FORMAT(pve.vaccine_date,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,pve.hospcode AS VACCINEPLACE,'' AS PROVIDER,DATE_FORMAT(pve.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id INNER JOIN person p ON pve.person_id = p.person_id " & _
        "WHERE pve.vaccine_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,s.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,ov.staff AS PROVIDER,DATE_FORMAT(s.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM ovst_vaccine ov INNER JOIN ovst o ON o.vn = ov.vn INNER JOIN ovst_seq s ON o.vn = s.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person_vaccine pv ON ov.person_vaccine_id = pv.person_vaccine_id LEFT JOIN person p ON pt.cid = p.cid " & _
        "WHERE o.vstdate BETWEEN  '" & STARTDATE & "' AND '" & ENDDATE & "'"
        epi = sqlf.QueryAsDatatable(sql)
        Return epi
    End Function
End Class
