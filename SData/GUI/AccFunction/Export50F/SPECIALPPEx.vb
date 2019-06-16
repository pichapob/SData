Public Class SPECIALPPEx
    Dim sql As String
    Dim sqlf As New SQLManager
    Public Function ExportSPECIALWithDUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim specialpp As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,q.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pps.pp_special_service_place_type_id AS SERVPLACE,pst.pp_special_code AS PPSPECIAL,pps.doctor AS PROVIDER,DATE_FORMAT(pps.entry_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM pp_special pps INNER JOIN ovst o ON pps.vn = o.vn INNER JOIN ovst_seq q ON q.vn = pps.vn INNER JOIN patient pt ON o.hn = pt.hn LEFT JOIN person p ON p.cid = pt.cid INNER JOIN pp_special_type pst ON pps.pp_special_type_id = pst.pp_special_type_id " & _
        "WHERE DATE(pps.entry_datetime) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        specialpp = sqlf.QueryAsDatatable(sql)
        Return specialpp
    End Function
    Public Function ExportSPECIALWithDateserv(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim specialpp As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,q.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pps.pp_special_service_place_type_id AS SERVPLACE,pst.pp_special_code AS PPSPECIAL,pps.doctor AS PROVIDER,DATE_FORMAT(pps.entry_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM pp_special pps INNER JOIN ovst o ON pps.vn = o.vn INNER JOIN ovst_seq q ON q.vn = pps.vn INNER JOIN patient pt ON o.hn = pt.hn LEFT JOIN person p ON p.cid = pt.cid INNER JOIN pp_special_type pst ON pps.pp_special_type_id = pst.pp_special_type_id " & _
        "WHERE pps.vn IN(SELECT o.vn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL))"
        specialpp = sqlf.QueryAsDatatable(sql)
        Return specialpp
    End Function
End Class
