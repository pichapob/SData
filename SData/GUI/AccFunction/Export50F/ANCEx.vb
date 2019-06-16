Public Class ANCEx
    Dim sql As String
    Dim sqlf As New SQLManager
    Public Function ExportANCWithDUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim anc As DataTable
        sql = "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(pas.anc_service_date,'%Y%m%d') AS DATE_SERV,pa.preg_no AS GRAVIDA,IF(pas.pa_week BETWEEN 0 AND 12,1,IF(pas.pa_week BETWEEN 16 AND 20,2,IF(pas.pa_week BETWEEN 24 AND 28,3,IF(pas.pa_week BETWEEN 30 AND 34,4,IF(pas.pa_week BETWEEN 36 AND 40,5,NULL))))) AS ANCNO,pas.pa_week AS GA,IF(pas.service_result IS NULL ,1,IF(pas.service_result ='Y',1,2)) AS ANCRESULT,IF(pas.anc_location_type_id = 1,(SELECT o.hospitalcode FROM opdconfig o),'00000') AS ANCPLACE,o.doctor AS PROVIDER,DATE_FORMAT(pa.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc pa INNER JOIN person_anc_service pas ON pa.person_anc_id = pas.person_anc_id INNER JOIN person p ON pa.person_id = p.person_id LEFT JOIN ovst o ON pas.vn = o.vn LEFT JOIN ovst_seq os ON o.vn = os.vn " & _
        "WHERE DATE(pa.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,'' AS SEQ,DATE_FORMAT(paop.precare_date,'%Y%m%d') AS DATE_SEVE,pa.preg_no AS GRAVIDA,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 0 AND 12,1,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 16 AND 20,2,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 24 AND 28,3,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 30 AND 34,4,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 36 AND 40,5,NULL))))) AS ANCNO,TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) AS GA,IFNULL(paop.anc_result,9) AS ANCRESULT,paop.precare_hospcode AS ANCPLACE,'' AS PROVIDER, DATE_FORMAT(pa.last_update ,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc_other_precare paop LEFT JOIN person_anc pa ON paop.person_anc_id = pa.person_anc_id LEFT JOIN person p ON pa.person_id = p.person_id " & _
        "WHERE DATE(pa.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        Console.WriteLine(sql)
        anc = sqlf.QueryAsDatatable(sql)
        Return anc

    End Function
    Public Function ExportANCWithDateserv(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim anc As DataTable
        sql = "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,os.seq_id AS SEQ,DATE_FORMAT(pas.anc_service_date,'%Y%m%d') AS DATE_SERV,pa.preg_no AS GRAVIDA,IF(pas.pa_week BETWEEN 0 AND 12,1,IF(pas.pa_week BETWEEN 16 AND 20,2,IF(pas.pa_week BETWEEN 24 AND 28,3,IF(pas.pa_week BETWEEN 30 AND 34,4,IF(pas.pa_week BETWEEN 36 AND 40,5,NULL))))) AS ANCNO,pas.pa_week AS GA,IF(pas.service_result IS NULL ,1,IF(pas.service_result ='Y',1,2)) AS ANCRESULT,IF(pas.anc_location_type_id = 1,(SELECT o.hospitalcode FROM opdconfig o),'00000') AS ANCPLACE,o.doctor AS PROVIDER,DATE_FORMAT(pa.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc_service pas INNER JOIN person_anc pa ON pas.person_anc_id = pa.person_anc_id INNER JOIN person p ON pa.person_id = p.person_id INNER JOIN ovst_seq os ON pas.vn = os.vn INNER JOIN ovst o ON o.vn = os.vn " & _
        "WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,'' AS SEQ,DATE_FORMAT(paop.precare_date,'%Y%m%d') AS DATE_SEVE,pa.preg_no AS GRAVIDA,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 0 AND 12,1,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 16 AND 20,2,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 24 AND 28,3,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 30 AND 34,4,IF(TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) BETWEEN 36 AND 40,5,NULL))))) AS ANCNO,TIMESTAMPDIFF(WEEK,pa.lmp,paop.precare_date) AS GA,IFNULL(paop.anc_result,9) AS ANCRESULT,paop.precare_hospcode AS ANCPLACE,'' AS PROVIDER, DATE_FORMAT(pa.last_update ,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc_other_precare paop LEFT JOIN person_anc pa ON paop.person_anc_id = pa.person_anc_id LEFT JOIN person p ON pa.person_id = p.person_id " & _
        "WHERE paop.precare_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        anc = sqlf.QueryAsDatatable(sql)
        Return anc
    End Function
End Class
