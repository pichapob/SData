Public Class CHRONICEx
    Dim sql As String
    Dim sqlf As New SQLManager
    Public Function ExportChronicAll() As DataTable
        Dim chronic As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig LIMIT 1) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,DATE_FORMAT(cm.regdate,'%Y%m%d') AS DATE_DIAG,c.icd10 AS CHRONIC,cm.register_hospcode AS HOSP_DX,(SELECT hospitalcode FROM opdconfig) AS HOSP_RX,DATE_FORMAT(cm.dchdate,'%Y%m%d') AS DATE_DISCH,IF(cms.provis_typedis NOT IN(SELECT code FROM provis_typedis),'03',LPAD(cms.provis_typedis,2,'0')) AS TYPEDISCH,DATE_FORMAT(cm.lastupdate,'%Y%m%d%H%i%s') AS D_UPDATE /*,pt.cid AS CID*/ FROM clinicmember cm  LEFT OUTER JOIN patient pt ON pt.hn = cm.hn  LEFT OUTER JOIN ptcardno pc ON pc.hn = cm.hn and pc.cardtype = '01'  LEFT OUTER JOIN clinic c ON c.clinic = cm.clinic LEFT JOIN clinic_member_status cms ON cm.clinic_member_status_id = cms.clinic_member_status_id LEFT JOIN person p ON p.cid  = pt.cid WHERE cm.clinic in (SELECT clinic FROM clinic WHERE chronic='Y' AND (no_export IS NULL OR no_export='N' OR no_export=''))"
        chronic = sqlf.QueryAsDatatable(sql)
        Return chronic
    End Function
    Public Function ExportChronicWithDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim chronic As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig LIMIT 1) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,DATE_FORMAT(cm.regdate,'%Y%m%d') AS DATE_DIAG,c.icd10 AS CHRONIC,cm.register_hospcode AS HOSP_DX,(SELECT hospitalcode FROM opdconfig) AS HOSP_RX,DATE_FORMAT(cm.dchdate,'%Y%m%d') AS DATE_DISCH,IF(cms.provis_typedis NOT IN(SELECT code FROM provis_typedis),'03',LPAD(cms.provis_typedis,2,'0')) AS TYPEDISCH,DATE_FORMAT(cm.lastupdate,'%Y%m%d%H%i%s') AS D_UPDATE /*,pt.cid AS CID*/ FROM clinicmember cm  LEFT OUTER JOIN patient pt ON pt.hn = cm.hn  LEFT OUTER JOIN ptcardno pc ON pc.hn = cm.hn and pc.cardtype = '01'  LEFT OUTER JOIN clinic c ON c.clinic = cm.clinic LEFT JOIN clinic_member_status cms ON cm.clinic_member_status_id = cms.clinic_member_status_id LEFT JOIN person p ON p.cid  = pt.cid WHERE cm.clinic in (SELECT clinic FROM clinic WHERE chronic='Y' AND (no_export IS NULL OR no_export='N' OR no_export='')) AND pt.hn IN(SELECT DISTINCT o.hn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL))"
        chronic = sqlf.QueryAsDatatable(sql)
        Return chronic
    End Function
    Public Function ExportChronicUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim chronic As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig LIMIT 1) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,DATE_FORMAT(cm.regdate,'%Y%m%d') AS DATE_DIAG,c.icd10 AS CHRONIC,cm.register_hospcode AS HOSP_DX,(SELECT hospitalcode FROM opdconfig) AS HOSP_RX,DATE_FORMAT(cm.dchdate,'%Y%m%d') AS DATE_DISCH,IF(cms.provis_typedis NOT IN(SELECT code FROM provis_typedis),'03',LPAD(cms.provis_typedis,2,'0')) AS TYPEDISCH,DATE_FORMAT(cm.lastupdate,'%Y%m%d%H%i%s') AS D_UPDATE /*,pt.cid AS CID*/ FROM clinicmember cm  LEFT OUTER JOIN patient pt ON pt.hn = cm.hn  LEFT OUTER JOIN ptcardno pc ON pc.hn = cm.hn and pc.cardtype = '01'  LEFT OUTER JOIN clinic c ON c.clinic = cm.clinic LEFT JOIN clinic_member_status cms ON cm.clinic_member_status_id = cms.clinic_member_status_id LEFT JOIN person p ON p.cid  = pt.cid WHERE cm.clinic in (SELECT clinic FROM clinic WHERE chronic='Y' AND (no_export IS NULL OR no_export='N' OR no_export='')) " & _
        "  AND DATE(cm.lastupdate) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        chronic = sqlf.QueryAsDatatable(sql)
        Return chronic
    End Function
End Class
