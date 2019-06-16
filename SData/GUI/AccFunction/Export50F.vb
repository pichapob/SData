﻿Public Class Export50F
    Dim sql As String = ""
    Dim sqlf As New SQLManager
    'PERSON
    Public Function ExportPersonDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname WHERE pt.hn IN(SELECT DISTINCT o.hn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL)) ORDER BY p.person_id ASC"
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonAllPP() As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname ORDER BY p.person_id ASC"
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonDUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE,p.home_phone AS TELEPHONE,p.mobile_phone AS MOBILE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname WHERE DATE(p.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' ORDER BY p.person_id ASC"
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    'SERVICE
    Public Function ExportServiceDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim service As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,pt.hn AS HN,q.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,DATE_FORMAT(o.vsttime,'%H%i%s') AS TIME_SERV,IF(v.moopart <> '0',1,2) AS LOCATION,IF(o.visit_type = 'O',2,1) AS INTIME,pts.pttype_std_code AS INSTYPE,o.pttypeno AS INSID,o.hospmain AS MAIN,IF(oi.export_code IS NULL,1,oi.export_code) AS TYPEIN,rf.refer_hospcode AS REFERINHOSP,rf.f43_causein_id AS CAUSEIN,s.cc AS CHIEFCOMP,1 AS SERVPLACE,s.temperature AS BTEMP,s.bps AS SBP,s.bpd AS DBP,s.hr AS PR,s.rr AS RR,IF(oo.export_code IS NULL,1,oo.export_code) AS TYPEOUT,ro.hospcode AS REFEROUTHOSP,rc1.export_code AS CAUSEOUT,FORMAT(q.service_cost,2) AS COST,FORMAT(v.item_money,2) AS PRICE,FORMAT(v.paid_money,2) AS PAYPRICE,FORMAT(v.rcpt_money,2) AS ACTUALPAY,DATE_FORMAT(q.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE /*,o.hospsub AS SUB,pt.cid AS CID*/ FROM ovst o left outer join vn_stat v on v.vn=o.vn  left outer join opdscreen s on s.vn=o.vn  left outer join doctor d on d.code=v.dx_doctor  left outer join ovst_seq q on q.vn = o.vn  left outer join patient pt on pt.hn = o.hn  left outer join ovstist oi on oi.ovstist = o.ovstist  left outer join ovstost oo on oo.ovstost = o.ovstost  left outer join pttype y on y.pttype = o.pttype  left outer join provis_instype pts on pts.code = y.nhso_code  left outer join referin rf on rf.vn = o.vn  left outer join referout ro on ro.vn = o.vn  left outer join rfrcs rc1 on rc1.rfrcs = ro.rfrcs  left outer join health_med_service hm on hm.vn = o.vn  left outer join spclty sp on sp.spclty = o.spclty LEFT JOIN person p  ON p.cid = pt.cid WHERE o.vn IN (SELECT o.vn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL))  order by o.vn"
        service = sqlf.QueryAsDatatable(sql)
        Return service
        End
    End Function
    'DIAGNOSIS_OPD
    Public Function ExportDiagOPDDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim diagnosisopd As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,q.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,d.diagtype AS DIAGTYPE,d.icd10 AS DIAGCODE,sp.provis_code AS CLINIC,DATE_FORMAT(q.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE /*,pt.cid AS CID*/ FROM ovstdiag d  LEFT OUTER JOIN ovst o ON o.vn = d.vn  LEFT OUTER JOIN vn_stat v ON v.vn = d.vn  LEFT OUTER JOIN ovst_seq q ON q.vn = o.vn  LEFT OUTER JOIN patient pt ON pt.hn = o.hn  LEFT OUTER JOIN doctor dt ON dt.code = d.doctor  LEFT OUTER JOIN spclty sp ON sp.spclty = o.spclty  LEFT OUTER JOIN person p ON pt.cid = p.cid WHERE d.vn IN (SELECT o.vn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL))"
        diagnosisopd = sqlf.QueryAsDatatable(sql)
        Return diagnosisopd
    End Function
    'SPECIAL PP
    Public Function ExportSpecialPPDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim specialpp As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,q.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pps.pp_special_service_place_type_id AS SERVPLACE,pst.pp_special_code AS PPSPECIAL,pps.doctor AS PROVIDER,DATE_FORMAT(pps.entry_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM pp_special pps INNER JOIN ovst o ON pps.vn = o.vn INNER JOIN ovst_seq q ON q.vn = pps.vn INNER JOIN patient pt ON o.hn = pt.hn LEFT JOIN person p ON p.cid = pt.cid INNER JOIN pp_special_type pst ON pps.pp_special_type_id = pst.pp_special_type_id WHERE pps.vn IN(SELECT o.vn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL)) "
        specialpp = sqlf.QueryAsDatatable(sql)
        Return specialpp
    End Function
    'EPI
    Public Function ExportEpiDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim epi As DataTable
        'account 2
        sql = "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(p2.anc_service_date,'%Y%m%d') AS DATE_SERV,a1.export_vaccine_code AS VACCINETYPE,IF(p2.anc_location_type_id = 1,(SELECT o.hospitalcode FROM opdconfig o),'00000') AS VACCINEPLACE,p1.anc_doctor_code AS PROVIDER,DATE_FORMAT(p3.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_anc_service_detail p1 INNER JOIN anc_service a1 ON p1.anc_service_id = a1.anc_service_id INNER JOIN person_anc_service p2 ON p1.person_anc_service_id = p2.person_anc_service_id INNER JOIN person_anc p3 ON p2.person_anc_id = p3.person_anc_id INNER JOIN ovst_seq q ON q.vn = p2.vn INNER JOIN ovst o ON o.vn = q.vn INNER JOIN person p ON p3.person_id = p.person_id WHERE o.vstdate BETWEEN '" & STARTDATE & "' and '" & ENDDATE & "'"
        sql &= " UNION ALL "
        'account 3
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(pws.service_date,'%Y%m%d') AS DATE_SERV,wv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,pwvd.doctor_code AS PROVIDER,DATE_FORMAT(pw.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_wbc_vaccine_detail pwvd INNER JOIN wbc_vaccine wv ON wv.wbc_vaccine_id = pwvd.wbc_vaccine_id INNER JOIN person_wbc_service pws ON  pws.person_wbc_service_id = pwvd.person_wbc_service_id INNER JOIN person_wbc pw ON pws.person_wbc_id = pw.person_wbc_id INNER JOIN person p ON pw.person_id = p.person_id INNER JOIN ovst_seq q ON q.vn = pws.vn WHERE pws.service_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        'account 4
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(pev.vaccine_date,'%Y%m%d') AS DATE_SERV,ev.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,pevl.doctor_code AS PROVIDER,DATE_FORMAT(pe.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM epi_vaccine ev INNER JOIN person_epi_vaccine_list pevl ON ev.epi_vaccine_id = pevl.epi_vaccine_id  INNER JOIN person_epi_vaccine pev ON pevl.person_epi_vaccine_id = pev.person_epi_vaccine_id INNER JOIN person_epi pe ON pev.person_epi_id = pe.person_epi_id INNER JOIN person p ON pe.person_id = p.person_id INNER JOIN ovst_seq q ON pev.vn = q.vn WHERE pev.vaccine_date BETWEEN '" & STARTDATE & "' and '" & ENDDATE & "'"
        sql &= " UNION ALL "
        'account 5
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,q.seq_id AS SEQ,DATE_FORMAT(vsv.vaccine_date,'%Y%m%d') AS DATE_SERV,sv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,vsvl.doctor_code AS PROVIDER,DATE_FORMAT(vs.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM village_student_vaccine_list vsvl INNER JOIN student_vaccine sv ON vsvl.student_vaccine_id = sv.student_vaccine_id INNER JOIN village_student_vaccine vsv ON vsvl.village_student_vaccine_id = vsv.village_student_vaccine_id INNER JOIN village_student vs ON vsv.village_student_id = vs.village_student_id INNER JOIN person p ON p.person_id = vs.person_id INNER JOIN ovst_seq q ON vsv.vn = q.vn WHERE vsv.vaccine_date BETWEEN '" & STARTDATE & "' and '" & ENDDATE & "'"
        sql &= " UNION ALL "
        'Other
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,'' AS SEQ,DATE_FORMAT(pve.vaccine_date,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,pve.hospcode AS VACCINEPLACE,'' AS PROVIDER,DATE_FORMAT(pve.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM person_vaccine_elsewhere pve INNER JOIN person_vaccine pv ON pve.person_vaccine_id = pv.person_vaccine_id INNER JOIN person p ON pve.person_id = p.person_id WHERE pve.vaccine_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        'One Stop Service
        sql &= "SELECT (SELECT o.hospitalcode FROM opdconfig o) AS HOSPCODE,IF(p.person_id IS NULL,pt.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0))) AS PID,s.seq_id AS SEQ,DATE_FORMAT(o.vstdate,'%Y%m%d') AS DATE_SERV,pv.export_vaccine_code AS VACCINETYPE,(SELECT o.hospitalcode FROM opdconfig o) AS VACCINEPLACE,ov.staff AS PROVIDER,DATE_FORMAT(s.update_datetime,'%Y%m%d%H%i%s') AS D_UPDATE FROM ovst_vaccine ov INNER JOIN ovst o ON o.vn = ov.vn INNER JOIN ovst_seq s ON o.vn = s.vn INNER JOIN patient pt ON o.hn = pt.hn INNER JOIN person_vaccine pv ON ov.person_vaccine_id = pv.person_vaccine_id LEFT JOIN person p ON pt.cid = p.cid WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        epi = sqlf.QueryAsDatatable(sql)
        Return epi
    End Function


    Public Function ExportDEATHDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim death As DataTable
        sql = "SELECT (SELECT hospitalcode FROM opdconfig) AS HOSPCODE,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,IF(pd.death_place = 2,pd.hcode,'') AS HOSPDEATH,'' AS AN,'' AS SEQ,DATE_FORMAT(pd.death_date,'%Y%m%d') AS DDEATH,pd.death_diag_1 AS CDEATH_A,pd.death_diag_2 AS CDEATH_B,pd.death_diag_3 AS CDEATH_C,pd.death_diag_4 AS CDEATH_D,pd.odisease AS ODISEASE,IF(pd.death_diag_4 IS NULL OR pd.death_diag_4 = '',IF(pd.death_diag_3 IS NULL OR pd.death_diag_3 = '',IF(pd.death_diag_2 IS NULL OR pd.death_diag_2 = '',pd.death_diag_1,pd.death_diag_2),pd.death_diag_3),pd.death_diag_4) AS CDEATH,IF(pd.nopreg <> 'Y','',IF(pd.wpreg <= 6,1,2)) AS PREGDEATH,'' AS PROVIDER,DATE_FORMAT(pd.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p INNER JOIN person_death pd  ON pd.person_id = p.person_id WHERE pd.death_diag_1 IS NOT NULL AND pd.death_diag_1<>'' AND pd.death_date BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        sql &= " UNION ALL "
        sql &= "SELECT (SELECT hospitalcode FROM opdconfig) AS HOSPCODE,IF(p.person_id IS NULL,p2.hn,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,'0'))) AS PID,p1.death_hospcode AS HOSPDEATH,p1.an AS AN,'' AS SEQ,DATE_FORMAT(p1.death_date,'%Y%m%d') AS DDEATH,p1.death_diag_1 AS CDEATH_A,p1.death_diag_2 AS CDEATH_B,p1.death_diag_3 AS CDEATH_C,p1.death_diag_4 AS CDEATH_D,p1.odisease AS ODISEASE,IF(p1.death_diag_4 IS NULL OR p1.death_diag_4 = '',IF(p1.death_diag_3 IS NULL OR p1.death_diag_3 = '',IF(p1.death_diag_2 IS NULL OR p1.death_diag_2 = '',p1.death_diag_1,p1.death_diag_2),p1.death_diag_3),p1.death_diag_4) AS CDEATH,IF(p1.nopreg<>'Y','',IF(p1.death_preg_42_day = 'Y',1,2)) AS PREGDEATH,'' AS PROVIDER,DATE_FORMAT(p1.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM patient p2 INNER JOIN death p1 ON p1.hn = p2.hn LEFT JOIN person p ON p.cid = p2.cid WHERE p1.death_diag_1 IS NOT NULL AND p1.death_diag_1<>'' AND p1.death_date  BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        death = sqlf.QueryAsDatatable(sql)
        Return death
    End Function
End Class
