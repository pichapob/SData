﻿Public Class PERSONEx
    Dim sql As String
    Dim sqlf As New SQLManager
    Public Function ExportPersonWithDateServ(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname WHERE pt.hn IN(SELECT DISTINCT o.hn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL)) ORDER BY p.person_id ASC"
        Console.WriteLine(sql)
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonWithDUpdate(ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname WHERE DATE(p.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' ORDER BY p.person_id ASC"
        Console.WriteLine(sql)
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonAll() As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname  ORDER BY p.person_id ASC"
        Console.WriteLine(sql)
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonWithPID_Dupdate(ByVal pid As String, ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname  " & _
        "WHERE p.person_id IN(" & pid & ") OR DATE(p.last_update) BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "'"
        Console.WriteLine(sql)
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
    Public Function ExportPersonWithPID_Dateserv(ByVal pid As String, ByVal STARTDATE As String, ByVal ENDDATE As String) As DataTable
        Dim person As DataTable
        sql = "SELECT (SELECT hospitalcode from opdconfig) AS HOSPCODE,p.cid AS CID,IF(LENGTH(p.person_id)>=6,p.person_id,LPAD(p.person_id,6,0)) AS PID,h.house_id AS HID,IF(pn.provis_code IS NULL OR pn.provis_code = '',IF(ppn.provis_pname_code IS NULL,p.sex,ppn.provis_pname_code),pn.provis_code) AS PRENAME,p.fname AS NAME,p.lname AS LNAME,pt.hn AS HN,p.sex AS SEX,DATE_FORMAT(p.birthdate,'%Y%m%d') AS BIRTH,p.marrystatus AS MSTATUS,p.occupation AS OCCUPATION_OLD,oc.nhso_code AS OCCUPATION_NEW,nt2.nhso_code AS RACE,nt.nhso_code AS NATION,rl.nhso_code AS RELIGION,ed.provis_code AS EDUCATION,p.person_house_position_id AS FSTATUS,p.father_cid AS FATHER,p.mother_cid AS MOTHER,p.sps_cid AS COUPLE,(SELECT pd.hcis_code FROM person_village_duty pvd,person_duty pd WHERE pvd.person_id = p.person_id AND pvd.person_duty_id = pd.person_duty_id LIMIT 1) AS VSTATUS,DATE_FORMAT(p.movein_date,'%Y%m%d') AS MOVEIN,p.person_discharge_id AS DISCHARGE,DATE_FORMAT(p.discharge_date,'%Y%m%d') AS DDISCHARGE,pb.code AS ABOGROUP,'' AS RHGROUP,pl.nhso_code AS LABOR,pt.passport_no AS PASSPORT,hr.export_code AS TYPEAREA,DATE_FORMAT(p.last_update,'%Y%m%d%H%i%s') AS D_UPDATE FROM person p LEFT OUTER JOIN house h ON h.house_id = p.house_id  LEFT OUTER JOIN patient pt ON pt.cid = p.cid  AND pt.cid is not null and pt.cid<>'' and pt.cid not like '%00000000%' and pt.cid not like '%11111111%' LEFT OUTER JOIN occupation oc ON oc.occupation = p.occupation LEFT OUTER JOIN nationality nt ON nt.nationality = p.nationality LEFT OUTER JOIN nationality nt2 ON nt2.nationality = p.citizenship LEFT OUTER JOIN education ed ON ed.education = p.education LEFT OUTER JOIN religion rl ON rl.religion = p.religion LEFT OUTER JOIN provis_bgroup pb ON pb.name = p.blood_group LEFT OUTER JOIN house_regist_type hr ON hr.house_regist_type_id = p.house_regist_type_id LEFT OUTER JOIN village v ON v.village_id = h.village_id LEFT OUTER JOIN pname pn ON pn.name = p.pname LEFT OUTER JOIN person_labor_type pl ON pl.person_labor_type_id = p.person_labor_type_id LEFT JOIN provis_pname ppn ON ppn.provis_pname_short_name = p.pname  " & _
        "WHERE p.person_id IN(" & pid & ") OR pt.hn IN(SELECT DISTINCT o.hn FROM ovst o,spclty sp WHERE o.vstdate BETWEEN '" & STARTDATE & "' AND '" & ENDDATE & "' AND o.spclty = sp.spclty AND (sp.no_export_43='N' OR sp.no_export_43 IS NULL) AND (o.anonymous_visit='N' OR o.anonymous_visit IS NULL)) "
        Console.WriteLine(sql)
        person = sqlf.QueryAsDatatable(sql)
        Return person
    End Function
End Class
