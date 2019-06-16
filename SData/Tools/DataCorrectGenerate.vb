Public Class DataCorrectGenerate
    Dim sqlf As New SQLManager
    Public Function PersonChecking() As DataTable
        Dim person As DataTable
        Dim sql As String = "SELECT sp.* FROM sd_person sp "
        sql &= "LEFT JOIN person p ON sp.CID = p.cid "
        sql &= "LEFT JOIN patient pt ON sp.CID = pt.cid "
        sql &= "WHERE ((p.person_id IS null OR p.person_id ='') AND (pt.hn = '' OR pt.hn IS NULL)) OR (sp.PID <> p.person_id AND sp.PID <> pt.hn)"
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function DiagnosisOpdChecking() As DataTable
        Dim diagnosisopd As DataTable
        Dim sql As String = "SELECT s.* FROM sd_diagnosis_opd s LEFT JOIN ovst_seq os ON s.SEQ = os.seq_id LEFT JOIN ovst o ON os.vn = o.vn LEFT JOIN ovstdiag od ON o.vn = od.vn AND od.diagtype = s.DIAGTYPE AND od.icd10 = s.DIAGCODE WHERE s.SEQ <> IFNULL(os.seq_id,'') OR s.DATE_SERV <> IFNULL(o.vstdate,'') OR s.DIAGCODE <> IFNULL(od.icd10,'') OR s.DIAGTYPE <> IFNULL(od.diagtype,'')"
        diagnosisopd = sqlf.QueryAsDatatable(sql)
        Return diagnosisopd
    End Function
    Public Function SpecialPPchecking(ByVal begindate As String, ByVal enddate As String) As DataTable
        Dim specialpp As DataTable
        Dim sql As String = "SELECT ss.* FROM sd_specialpp ss LEFT JOIN (SELECT IF(p.person_id IS NOT NULL,LPAD(p.person_id,6,'0'),pt.hn) AS person_id,v.vstdate,s.seq_id,pst.pp_special_code FROM pp_special d "
        sql &= " INNER JOIN ovst v ON d.vn = v.vn LEFT JOIN ovst_seq s ON v.vn = s.vn LEFT JOIN patient pt ON v.hn = pt.hn LEFT JOIN pp_special_type pst ON  pst.pp_special_type_id = d.pp_special_type_id LEFT JOIN person p ON pt.cid = p.cid "
        sql &= "where d.vn in (SELECT DISTINCT vn from ovst where vstdate BETWEEN '" & begindate & "' AND '" & enddate & "') ) AS pp ON ss.PID = pp.person_id AND ss.DATE_SERV = pp.vstdate AND pp.pp_special_code = ss.PPSPECIAL WHERE pp.person_id IS NULL"
        specialpp = sqlf.QueryAsDatatable(sql)
        Return specialpp
    End Function
    Public Function AddressChecking() As DataTable
        Dim address As DataTable
        Dim sql As String = "SELECT a.* FROM sd_address a LEFT JOIN person p ON a.PID-0 = p.person_id LEFT JOIN person_address pa ON pa.person_id = p.person_id WHERE IF(pa.person_address_id IS NULL,1,2) <> ADDRESSTYPE OR p.house_regist_type_id IN(1,2)"
        address = sqlf.QueryAsDatatable(sql)
        Return address
    End Function
    Public Function ChronicChecking() As DataTable
        Dim chronic As DataTable
        Dim sql As String = "SELECT c.* FROM sd_chronic c LEFT OUTER JOIN ( SELECT LPAD(IF(p.person_id IS NULL,pt.hn,p.person_id),6,'0') AS PID,c.icd10 AS CHRONIC FROM clinicmember cm LEFT OUTER JOIN patient pt ON pt.hn = cm.hn LEFT OUTER JOIN ptcardno pc ON pc.hn = cm.hn and pc.cardtype = '01' LEFT OUTER JOIN clinic c ON c.clinic = cm.clinic LEFT JOIN person p ON p.cid  = pt.cid	WHERE cm.clinic in (SELECT clinic FROM clinic WHERE chronic='Y' AND (no_export IS NULL OR no_export='N' OR no_export=''))) AS cc ON c.CHRONIC = cc.CHRONIC AND c.PID = cc.PID WHERE cc.PID IS NULL OR cc.PID = ''"
        chronic = sqlf.QueryAsDatatable(sql)
        Return chronic
    End Function

    Public Function DeathChecking() As DataTable
        Dim death As DataTable
        Dim sql As String = "SELECT s.* FROM sd_death s LEFT JOIN person p ON LPAD(p.person_id,6,'0') = s.PID LEFT JOIN patient pt ON s.PID = pt.hn LEFT JOIN person_death pd ON p.person_id = pd.person_id LEFT JOIN death d ON d.hn = pt.hn WHERE pd.person_id IS NULL AND d.hn IS NULL"
        death = sqlf.QueryAsDatatable(sql)
        Return death
    End Function
    Public Function DrugOPDChecking() As DataTable
        Dim drugopd As DataTable
        Dim sql As String = "SELECT o.* FROM sd_drug_opd o LEFT JOIN ovst_seq s ON o.SEQ = s.seq_id LEFT JOIN ovst ov ON s.vn = ov.vn LEFT JOIN patient pt ON pt.hn = ov.hn LEFT JOIN person p ON pt.cid = p.cid LEFT JOIN (	SELECT s.vn,s.seq_id,di.did 	FROM ovst_seq s 	LEFT JOIN opitemrece oi ON s.vn = oi.vn	LEFT JOIN drugitems di ON oi.icode = di.icode 	WHERE seq_id IN(SELECT SEQ FROM sd_drug_opd) AND oi.icode LIKE '1%' ) di ON ov.vn = di.vn AND o.DIDSTD = di.did WHERE o.PID-0 <> IFNULL(p.person_id-0,pt.hn-0) OR o.SEQ <> IFNULL(s.seq_id,'') OR o.DATE_SERV <> IFNULL(ov.vstdate,'') OR o.DIDSTD <> IFNULL(di.did,'')"
        drugopd = sqlf.QueryAsDatatable(sql)
        Return drugopd
    End Function
    Public Function ProcedureOPDChecking() As DataTable
        Dim procedureopd As DataTable
        Dim sql As String = "SELECT sd.* FROM sd_procedure_opd sd LEFT JOIN ovst_seq os ON sd.SEQ = os.seq_id LEFT JOIN ovst o ON os.vn = o.vn LEFT JOIN patient pt ON o.hn = pt.hn LEFT JOIN person p ON pt.cid = p.cid LEFT JOIN (SELECT os.seq_id,os.vn,IF(eoc.icd10tm IS NULL,eoc.icd9cm,eoc.icd10tm) AS proc FROM ovst_seq os LEFT JOIN er_regist_oper ero ON os.vn = ero.vn 	LEFT JOIN er_oper_code eoc ON ero.er_oper_code = eoc.er_oper_code 	WHERE os.seq_id IN(SELECT SEQ FROM sd_procedure_opd)) er ON o.vn = er.vn AND sd.PROCEDCODE = er.proc  LEFT JOIN (SELECT os.seq_id,os.vn,h4.icd10tm AS proc 	FROM ovst_seq os LEFT JOIN health_med_service h1  ON os.vn = h1.vn left outer join health_med_service_operation h2 on h2.health_med_service_id = h1.health_med_service_id left outer join health_med_operation_item h3 on h3.health_med_operation_item_id = h2.health_med_operation_item_id left outer join health_med_organ g1 on g1.health_med_organ_id = h2.health_med_organ_id left outer join health_med_operation_type t1 on t1.health_med_operation_type_id = h2.health_med_operation_type_id left outer join health_med_operation_code h4 on h4.code = concat(g1.health_med_organ_code,'-',t1.health_med_operation_type_code,'-',h3.health_med_operation_item_code) WHERE os.seq_id IN(SELECT SEQ FROM sd_procedure_opd) ) AS h ON o.vn = h.vn AND sd.PROCEDCODE = h.proc LEFT JOIN (	SELECT os.seq_id,e.name,os.vn,IF(e.icd10tm_operation_code IS NULL,e.icd9cm,e.icd10tm_operation_code) AS proc FROM ovst_seq os LEFT JOIN dtmain r ON os.vn = r.vn LEFT OUTER JOIN dttm e on e.code=r.tmcode WHERE os.seq_id IN(SELECT SEQ FROM sd_procedure_opd) ) AS d ON d.vn = o.vn AND sd.PROCEDCODE = d.proc LEFT JOIN (	SELECT os.seq_id,os.vn,IF(e2.icd10tm_operation_code IS NULL,IFNULL(e.icd10tm,e.icd9cm),e2.icd10tm_operation_code) AS proc FROM ovst_seq os LEFT JOIN doctor_operation r  ON os.vn = r.vn LEFT OUTER JOIN er_oper_code e on e.er_oper_code=r.er_oper_code LEFT OUTER JOIN er_oper_code_area e2 on e2.er_oper_code_area_id= r.er_oper_code_area_id WHERE os.seq_id IN(SELECT SEQ FROM sd_procedure_opd)) doc ON doc.vn = o.vn AND doc.proc = sd.PROCEDCODE WHERE sd.PID-0 <> IFNULL(p.person_id-0,pt.hn-0)  OR o.vstdate <> IFNULL(sd.DATE_SERV,'') OR os.seq_id <> IFNULL(sd.SEQ,'') OR (er.proc IS NULL AND h.proc IS NULL AND d.proc IS NULL AND doc.proc IS NULL)"
        procedureopd = sqlf.QueryAsDatatable(sql)
        Return procedureopd
    End Function
    Public Function ServiceChecking() As DataTable
        Dim service As DataTable
        Dim sql As String = "SELECT sd.* FROM sd_service sd LEFT JOIN ovst_seq os ON sd.SEQ = os.seq_id LEFT JOIN ovst o ON os.vn = o.vn LEFT JOIN patient pt ON pt.hn = o.hn LEFT JOIN person p ON pt.cid = p.cid left outer join pttype y on y.pttype = o.pttype left outer join provis_instype pts on pts.code = y.nhso_code WHERE sd.PID-0 <> IFNULL(p.person_id-0,pt.hn-0) OR sd.SEQ <> IFNULL(os.seq_id,'') OR sd.DATE_SERV <> IFNULL(o.vstdate,'') OR sd.INSTYPE <> IFNULL(pts.pttype_std_code,'')"
        service = sqlf.QueryAsDatatable(sql)
        Return service
    End Function
End Class
