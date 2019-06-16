Imports System.ServiceModel
Imports System.Globalization

Public Class frmExportDataCorrect
    Dim sqlf As New SQLManager
    Dim acc As New AccessoriesFunction
    Dim dcg As New DataCorrectGenerate
    Private Sub innitTable()
        Dim sql As String = "select * from sd_person limit 0"
        Dim rs As DataTable = sqlf.QueryAsDatatable(sql)
        person_table.DataSource = rs
        sql = "select * from sd_specialpp limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        specialpp_table.DataSource = rs
        sql = "select * from sd_diagnosis_opd limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        diagnosisopd_table.DataSource = rs
        sql = "select * from sd_chronic limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        chronic_table.DataSource = rs
        sql = "select * from sd_address limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        address_table.DataSource = rs
        sql = "select * from sd_death limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        Death_table.DataSource = rs
        sql = "select * from sd_drug_opd limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        Drug_opd_table.DataSource = rs
        sql = "select * from sd_procedure_opd limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        Procedure_opd_table.DataSource = rs
        sql = "select * from sd_service limit 0"
        rs = sqlf.QueryAsDatatable(sql)
        Service_table.DataSource = rs
    End Sub
    Private Sub frmExportDataCorrect_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        innitTable()
        begindate_tf.Value = Date.Now
        enddate_tf.Value = Date.Now
    End Sub

    Private Sub checking_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checking_b.Click
        Cursor = Cursors.WaitCursor
        innitTable()
        Dim sql As String = "SELECT * FROM sd_sys_var s WHERE s.sd_sys_var_name ='BRHSERVICE-DATA-AUDIT-ACTIVE'"
        Dim rs As DataTable = sqlf.QueryAsDatatable(sql)
        If rs.Rows.Count > 0 Then
            If rs.Rows(0).Item("sd_sys_var_value").ToString = "Y" Then
                'SELECT TED CHECK
                If person_ch.Checked Or diagnosisopd_ch.Checked Or specialpp_ch.Checked Or Address_ch.Checked Or Chronic_ch.Checked Or Death_ch.Checked Or drugopd_ch.Checked Or procedure_opd_ch.Checked Or Service_ch.Checked Then

                    Dim auditdata As New BRHServiceDataAudit.DataAuditServiceClient
                    sql = "SELECT * FROM sd_sys_var s WHERE s.sd_sys_var_name ='BRHSERVICE-DATA-AUDIT'"
                    rs = sqlf.QueryAsDatatable(sql)
                    If rs.Rows.Count > 0 Then
                        auditdata.Endpoint.Address = New EndpointAddress(rs.Rows(0).Item("sd_sys_var_value").ToString)
                    End If
                    sql = "SELECT * FROM sys_var s WHERE sys_name ='PCU_DW_EMR_SECRET'"
                    Dim valsk As DataTable = sqlf.QueryAsDatatable(sql)
                    Dim secret_key As String = ""
                    If valsk.Rows.Count > 0 Then
                        secret_key = valsk.Rows(0).Item("sys_value").ToString
                    End If
                    Dim hospcode As String = ""
                    sql = "SELECT o.hospitalcode FROM opdconfig o LIMIT 1"
                    valsk = sqlf.QueryAsDatatable(sql)
                    If valsk.Rows.Count > 0 Then
                        hospcode = valsk.Rows(0).Item("hospitalcode").ToString
                    End If
                    Dim startdate As String = ""
                    Dim enddate As String = ""

                    startdate = begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
                    enddate = enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))

                    If begindate_tf.Value.Month = enddate_tf.Value.Month Then
                        'PERSON
                        If person_ch.Checked Then
                            sql = "DELETE FROM sd_person"
                            sqlf.Excute(sql)
                            Dim person_ws() As BRHServiceDataAudit.person = auditdata.GetPersonAll(hospcode, secret_key)
                            If person_ws IsNot Nothing Then
                                For i As Integer = 0 To person_ws.Length - 1
                                    sql = "INSERT INTO sd_person(HOSPCODE,CID,PID,HID,PRENAME,NAME,LNAME,HN,SEX,BIRTH,MSTATUS,OCCUPATION_OLD,OCCUPATION_NEW,RACE,NATION,RELIGION,EDUCATION,FSTATUS,FATHER,MOTHER,COUPLE,VSTATUS,MOVEIN,DISCHARGE,DDISCHARGE,ABOGROUP,RHGROUP,LABOR,PASSPORT,TYPEAREA,D_UPDATE) "
                                    sql &= "VALUES ('" & person_ws(i).HOSPCODE & "',"
                                    sql &= "'" & acc.DecryptText(person_ws(i).CID, secret_key) & "',"
                                    sql &= "'" & person_ws(i).PID & "',"
                                    sql &= "'" & person_ws(i).HID & "',"
                                    sql &= "'" & person_ws(i).PRENAME & "',"
                                    sql &= "'" & acc.DecryptText(person_ws(i).NAME, secret_key) & "',"
                                    sql &= "'" & acc.DecryptText(person_ws(i).LNAME, secret_key) & "',"
                                    sql &= "'" & person_ws(i).HN & "',"
                                    sql &= "'" & person_ws(i).SEX & "',"
                                    sql &= "'" & person_ws(i).BIRTH & "',"
                                    sql &= "'" & person_ws(i).mstatus & "',"
                                    sql &= "'" & person_ws(i).OCCUPATION_OLD & "',"
                                    sql &= "'" & person_ws(i).OCCUPATION_NEW & "',"
                                    sql &= "'" & person_ws(i).RACE & "',"
                                    sql &= "'" & person_ws(i).NATION & "',"
                                    sql &= "'" & person_ws(i).RELIGION & "',"
                                    sql &= "'" & person_ws(i).EDUCATION & "',"
                                    sql &= "'" & person_ws(i).FSTATUS & "',"
                                    sql &= "'" & person_ws(i).FATHER & "',"
                                    sql &= "'" & person_ws(i).MOTHER & "',"
                                    sql &= "'" & person_ws(i).COUPLE & "',"
                                    sql &= "'" & person_ws(i).VSTATUS & "',"
                                    If (person_ws(i).MOVEIN = "") Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & person_ws(i).MOVEIN & "',"
                                    End If
                                    sql &= "'" & person_ws(i).discharge & "',"
                                    If (person_ws(i).DDISCHARGE = "") Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & person_ws(i).DDISCHARGE & "',"
                                    End If

                                    sql &= "'" & person_ws(i).ABOGROUP & "',"
                                    sql &= "'" & person_ws(i).RHGROUP & "',"
                                    sql &= "'" & person_ws(i).LABOR & "',"
                                    sql &= "'" & person_ws(i).PASSPORT & "',"
                                    sql &= "'" & person_ws(i).TYPEAREA & "',"
                                    sql &= "'" & person_ws(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                person_table.DataSource = dcg.PersonChecking()
                            End If
                        End If
                        'DIAGNOSIS_OPD
                        If diagnosisopd_ch.Checked Then
                            sql = "DELETE FROM sd_diagnosis_opd"
                            sqlf.Excute(sql)
                            Dim diagnosis_ws() As BRHServiceDataAudit.diagnosisOpd = auditdata.GetDiagnosisopdWithDateServ(hospcode, startdate, enddate, secret_key)
                            If diagnosis_ws IsNot Nothing Then
                                For i As Integer = 0 To diagnosis_ws.Length - 1
                                    sql = "INSERT INTO sd_diagnosis_opd(HOSPCODE,PID,SEQ,DATE_SERV,DIAGTYPE,DIAGCODE,CLINIC,PROVIDER,D_UPDATE) "
                                    sql &= "VALUES ('" & diagnosis_ws(i).HOSPCODE & "',"
                                    sql &= "'" & diagnosis_ws(i).PID & "',"
                                    sql &= "'" & diagnosis_ws(i).SEQ & "',"
                                    sql &= "'" & diagnosis_ws(i).DATE_SERV & "',"
                                    sql &= "'" & diagnosis_ws(i).DIAGTYPE & "',"
                                    sql &= "'" & diagnosis_ws(i).DIAGCODE & "',"
                                    sql &= "'" & diagnosis_ws(i).CLINIC & "',"
                                    sql &= "'" & diagnosis_ws(i).PROVIDER & "',"
                                    sql &= "'" & diagnosis_ws(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                diagnosisopd_table.DataSource = dcg.DiagnosisOpdChecking
                            End If
                        End If
                        'SPECIALPP
                        If specialpp_ch.Checked Then
                            sql = "DELETE FROM sd_specialpp"
                            sqlf.Excute(sql)
                            Dim specialpp_ws() As BRHServiceDataAudit.specialpp = auditdata.GetSpecialppWithDateServ(hospcode, startdate, enddate, secret_key)
                            If specialpp_ws IsNot Nothing Then
                                For i As Integer = 0 To specialpp_ws.Length - 1
                                    sql = "INSERT INTO sd_specialpp(HOSPCODE,PID,SEQ,DATE_SERV,SERVPLACE,PPSPECIAL,PPSPLACE,PROVIDER,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & specialpp_ws(i).HOSPCODE & "',"
                                    sql &= "'" & specialpp_ws(i).PID & "',"
                                    sql &= "'" & specialpp_ws(i).SEQ & "',"
                                    sql &= "'" & specialpp_ws(i).DATE_SERV & "',"
                                    sql &= "'" & specialpp_ws(i).SERVPLACE & "',"
                                    sql &= "'" & specialpp_ws(i).PPSPECIAL & "',"
                                    sql &= "'" & specialpp_ws(i).PPSPLACE & "',"
                                    sql &= "'" & specialpp_ws(i).PROVIDER & "',"
                                    sql &= "'" & specialpp_ws(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                specialpp_table.DataSource = dcg.SpecialPPchecking(startdate, enddate)
                            End If
                        End If
                        'ADDRESS
                        If Address_ch.Checked Then
                            sql = "DELETE FROM sd_address"
                            sqlf.Excute(sql)
                            Dim address_ws() As BRHServiceDataAudit.address = auditdata.GetAddressAll(hospcode, secret_key)
                            If address_ws IsNot Nothing Then
                                For i As Integer = 0 To address_ws.Length - 1
                                    sql = "INSERT INTO sd_address(HOSPCODE,PID,ADDRESSTYPE,HOUSE_ID,HOUSETYPE,ROOMNO,CONDO,HOUSENO,SOISUB,SOIMAIN,ROAD,VILLANAME,VILLAGE,TAMBON,AMPUR,CHANGWAT,TELEPHONE,MOBILE,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & address_ws(i).HOSPCODE & "',"
                                    sql &= "'" & address_ws(i).PID & "',"
                                    sql &= "'" & address_ws(i).ADDRESSTYPE & "',"
                                    sql &= "'" & address_ws(i).HOUSE_ID & "',"
                                    sql &= "'" & address_ws(i).HOUSETYPE & "',"
                                    sql &= "'" & address_ws(i).ROOMNO & "',"
                                    sql &= "'" & address_ws(i).CONDO & "',"
                                    sql &= "'" & address_ws(i).HOUSENO & "',"
                                    sql &= "'" & address_ws(i).SOISUB & "',"
                                    sql &= "'" & address_ws(i).SOIMAIN & "',"
                                    sql &= "'" & address_ws(i).ROAD & "',"
                                    sql &= "'" & address_ws(i).VILLANAME & "',"
                                    sql &= "'" & address_ws(i).VILLAGE & "',"
                                    sql &= "'" & address_ws(i).TAMBON & "',"
                                    sql &= "'" & address_ws(i).AMPUR & "',"
                                    sql &= "'" & address_ws(i).CHANGWAT & "',"
                                    sql &= "'" & address_ws(i).TELEPHONE & "',"
                                    sql &= "'" & address_ws(i).MOBILE & "',"
                                    sql &= "'" & address_ws(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                address_table.DataSource = dcg.AddressChecking
                            End If
                        End If
                        'CHRONIC
                        If Chronic_ch.Checked Then
                            sql = "DELETE FROM sd_chronic"
                            sqlf.Excute(sql)
                            Dim chronic() As BRHServiceDataAudit.chronic = auditdata.GetChronicAll(hospcode, secret_key)
                            If chronic IsNot Nothing Then
                                For i As Integer = 0 To chronic.Length - 1
                                    sql = "REPLACE INTO sd_chronic(HOSPCODE,PID,DATE_DIAG,CHRONIC,HOSP_DX,HOSP_RX,DATE_DISCH,TYPEDISCH,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & chronic(i).HOSPCODE & "',"
                                    sql &= "'" & chronic(i).PID & "',"
                                    If chronic(i).DATE_DIAG = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & chronic(i).DATE_DIAG & "',"
                                    End If
                                    sql &= "'" & chronic(i).CHRONIC & "',"
                                    sql &= "'" & chronic(i).HOSP_DX & "',"
                                    sql &= "'" & chronic(i).HOSP_RX & "',"
                                    If chronic(i).DATE_DISCH = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & chronic(i).DATE_DISCH & "',"
                                    End If

                                    sql &= "'" & chronic(i).TYPEDISCH & "',"
                                    If chronic(i).d_UPDATE = "" Then
                                        sql &= "NULL)"
                                    Else
                                        sql &= "'" & chronic(i).d_UPDATE.Split(".")(0) & "')"
                                    End If
                                    Try
                                        sqlf.Excute(sql)
                                    Catch ex As Exception

                                    End Try

                                Next
                                chronic_table.DataSource = dcg.ChronicChecking
                            End If
                        End If
                        'DEATH
                        If Death_ch.Checked Then
                            sql = "DELETE FROM sd_death"
                            sqlf.Excute(sql)
                            Dim death() As BRHServiceDataAudit.death = auditdata.GetDeathWithDateServ(hospcode, startdate, enddate, secret_key)
                            If death IsNot Nothing Then
                                For i As Integer = 0 To death.Length - 1
                                    sql = "INSERT INTO sd_death(HOSPCODE,PID,HOSPDEATH,AN,SEQ,ddeath,cdeath_a,CDEATH_B,CDEATH_C,CDEATH_D,ODISEASE,cdeath, PREGDEATH, pdeath, PROVIDER, d_update) "
                                    sql &= "VALUES ("
                                    sql &= "'" & death(i).HOSPCODE & "',"
                                    sql &= "'" & death(i).PID & "',"
                                    sql &= "'" & death(i).HOSPDEATH & "',"
                                    sql &= "'" & death(i).AN & "',"
                                    sql &= "'" & death(i).SEQ & "',"
                                    If death(i).ddeath = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & death(i).ddeath & "',"
                                    End If
                                    sql &= "'" & death(i).cdeath_a & "',"
                                    sql &= "'" & death(i).CDEATH_B & "',"
                                    sql &= "'" & death(i).CDEATH_C & "',"
                                    sql &= "'" & death(i).CDEATH_D & "',"
                                    sql &= "'" & death(i).ODISEASE & "',"
                                    sql &= "'" & death(i).CDEATH & "',"
                                    sql &= "'" & death(i).PREGDEATH & "',"
                                    sql &= "'" & death(i).PDEATH & "',"
                                    sql &= "'" & death(i).PROVIDER & "',"
                                    sql &= "'" & death(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                Death_table.DataSource = dcg.DeathChecking
                            End If
                        End If
                        'DRUGOPD
                        If drugopd_ch.Checked Then
                            sql = "DELETE FROM sd_drug_opd"
                            sqlf.Excute(sql)
                            Dim drugopd() As BRHServiceDataAudit.drugOpd = auditdata.GetDrugOPDWithDateServ(hospcode, secret_key, startdate, enddate)

                            If drugopd IsNot Nothing Then
                                For i As Integer = 0 To drugopd.Length - 1
                                    sql = "INSERT INTO sd_drug_opd(HOSPCODE,PID,SEQ,DATE_SERV,CLINIC,DIDSTD,DNAME,AMOUNT,UNIT,UNIT_PACKING,DRUGPRICE,DRUGCOST,PROVIDER,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & drugopd(i).HOSPCODE & "',"
                                    sql &= "'" & drugopd(i).PID & "',"
                                    sql &= "'" & drugopd(i).SEQ & "',"
                                    If drugopd(i).DATE_SERV = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & drugopd(i).DATE_SERV & "',"
                                    End If
                                    sql &= "'" & drugopd(i).CLINIC & "',"
                                    sql &= "'" & drugopd(i).DIDSTD & "',"
                                    sql &= "'" & drugopd(i).DNAME & "',"
                                    sql &= "'" & drugopd(i).AMOUNT & "',"
                                    sql &= "'" & drugopd(i).UNIT & "',"
                                    sql &= "'" & drugopd(i).UNIT_PACKING & "',"
                                    sql &= "'" & drugopd(i).DRUGPRICE & "',"
                                    sql &= "'" & drugopd(i).DRUGCOST & "',"
                                    sql &= "'" & drugopd(i).PROVIDER & "',"
                                    sql &= "'" & drugopd(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                Drug_opd_table.DataSource = dcg.DrugOPDChecking
                            End If
                        End If
                        'PROCEDURE GOPD
                        If procedure_opd_ch.Checked Then
                            sql = "DELETE FROM sd_procedure_opd"
                            sqlf.Excute(sql)
                            Dim procedureopd() As BRHServiceDataAudit.procedureOpd = auditdata.GetProcedureOPDWithDateServ(hospcode, secret_key, startdate, enddate)

                            If procedureopd IsNot Nothing Then
                                For i As Integer = 0 To procedureopd.Length - 1
                                    sql = "INSERT INTO sd_procedure_opd(HOSPCODE,PID,SEQ,DATE_SERV,CLINIC,PROCEDCODE,SERVICEPRICE,PROVIDER,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & procedureopd(i).HOSPCODE & "',"
                                    sql &= "'" & procedureopd(i).PID & "',"
                                    sql &= "'" & procedureopd(i).SEQ & "',"
                                    If procedureopd(i).DATE_SERV = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & procedureopd(i).DATE_SERV & "',"
                                    End If
                                    sql &= "'" & procedureopd(i).CLINIC & "',"
                                    sql &= "'" & procedureopd(i).PROCEDCODE & "',"
                                    sql &= "'" & procedureopd(i).SERVICEPRICE & "',"
                                    sql &= "'" & procedureopd(i).PROVIDER & "',"
                                    sql &= "'" & procedureopd(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                Procedure_opd_table.DataSource = dcg.ProcedureOPDChecking
                            End If
                        End If
                        'PROCEDURE GOPD
                        If Service_ch.Checked Then
                            sql = "DELETE FROM sd_service"
                            sqlf.Excute(sql)
                            Dim service() As BRHServiceDataAudit.service = auditdata.GetServiceWithDateServ(hospcode, secret_key, startdate, enddate)

                            If service IsNot Nothing Then
                                For i As Integer = 0 To service.Length - 1
                                    sql = "INSERT INTO sd_service(HOSPCODE,PID,HN,SEQ,DATE_SERV,TIME_SERV,LOCATION,INTIME,INSTYPE,INSID,MAIN,TYPEIN,REFERINHOSP,CAUSEIN,CHIEFCOMP,SERVPLACE,BTEMP,SBP,DBP,PR,RR,TYPEOUT,REFEROUTHOSP,CAUSEOUT,COST,PRICE,PAYPRICE,ACTUALPAY,D_UPDATE) "
                                    sql &= "VALUES ("
                                    sql &= "'" & service(i).HOSPCODE & "',"
                                    sql &= "'" & service(i).PID & "',"
                                    sql &= "'" & service(i).HN & "',"
                                    sql &= "'" & service(i).SEQ & "',"
                                    If service(i).DATE_SERV = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & service(i).DATE_SERV & "',"
                                    End If
                                    If service(i).TIME_SERV = "" Then
                                        sql &= "NULL,"
                                    Else
                                        sql &= "'" & service(i).TIME_SERV & "',"
                                    End If
                                    sql &= "'" & service(i).LOCATION & "',"
                                    sql &= "'" & service(i).INTIME & "',"
                                    sql &= "'" & service(i).INSTYPE & "',"
                                    sql &= "'" & service(i).INSID & "',"
                                    sql &= "'" & service(i).MAIN & "',"
                                    sql &= "'" & service(i).TYPEIN & "',"
                                    sql &= "'" & service(i).REFERINHOSP & "',"
                                    sql &= "'" & service(i).CAUSEIN & "',"
                                    sql &= "'" & service(i).CHIEFCOMP & "',"
                                    sql &= "'" & service(i).SERVPLACE & "',"
                                    sql &= "'" & service(i).BTEMP & "',"
                                    sql &= "'" & service(i).SBP & "',"
                                    sql &= "'" & service(i).DBP & "',"
                                    sql &= "'" & service(i).PR & "',"
                                    sql &= "'" & service(i).RR & "',"
                                    sql &= "'" & service(i).TYPEOUT & "',"
                                    sql &= "'" & service(i).REFEROUTHOSP & "',"
                                    sql &= "'" & service(i).CAUSEOUT & "',"
                                    sql &= "'" & service(i).COST & "',"
                                    sql &= "'" & service(i).PRICE & "',"
                                    sql &= "'" & service(i).PAYPRICE & "',"
                                    sql &= "'" & service(i).ACTUALPAY & "',"
                                    sql &= "'" & service(i).d_UPDATE & "')"
                                    sqlf.Excute(sql)
                                Next
                                Service_table.DataSource = dcg.ServiceChecking
                            End If
                        End If

                        MessageBox.Show("ตรวจสอบเรียบร้อย", "SData Message")
                    Else
                        MessageBox.Show("ยังไม่อนุญาติให้ตรวจสอบทีละหลายๆเดือน", "SData Message")
                    End If
                Else
                    MessageBox.Show("กรุณาเลือกแฟ้มที่จะตรวจสอบ", "SData Message")
                End If
            Else
                MessageBox.Show("คุณยังไม่ได้เปิดใช้งาน BRHService", "SData Message")
            End If
        Else
            MessageBox.Show("กรุณา Upgrade Structure", "SData Message")
        End If
        Cursor = Cursors.Default
        exportData_b.Enabled = True
    End Sub

    Private Sub person_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles person_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(person_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub diagnosisopd_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles diagnosisopd_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(diagnosisopd_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub specialpp_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles specialpp_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(specialpp_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub exportData_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exportData_b.Click
        Dim export As New DataCorrectExport
        If person_table.RowCount > 0 Then
            export.Set_person(person_table.DataSource)
        End If
        If specialpp_table.RowCount > 0 Then
            export.Set_specialpp(specialpp_table.DataSource)
        End If
        If diagnosisopd_table.RowCount > 0 Then
            export.Set_diagnosisopd(diagnosisopd_table.DataSource)
        End If
        If address_table.RowCount > 0 Then
            export.Set_address(address_table.DataSource)
        End If
        If chronic_table.RowCount > 0 Then
            export.Set_chronic(chronic_table.DataSource)
        End If
        If Death_table.RowCount > 0 Then
            export.Set_death(Death_table.DataSource)
        End If
        If Drug_opd_table.RowCount > 0 Then
            export.Set_drugopd(Drug_opd_table.DataSource)
        End If
        If Procedure_opd_table.RowCount > 0 Then
            export.Set_procedureopd(Procedure_opd_table.DataSource)
        End If
        If Service_table.RowCount > 0 Then
            export.Set_service(Service_table.DataSource)
        End If

        Dim sql As String = "SELECT hospitalcode FROM opdconfig LIMIT 1"
        Dim rs As DataTable = sqlf.QueryAsDatatable(sql)
        Dim hcode As String = ""
        If rs.Rows.Count > 0 Then
            hcode = rs.Rows(0).Item("hospitalcode").ToString
        End If
        export.exportDataCorrect(path_export_tf.Text, hcode)
        MessageBox.Show("ส่งออกเรียบร้อย", "SData Message")
    End Sub

    Private Sub close_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles close_b.Click
        Dispose()
    End Sub

    Private Sub address_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles address_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(address_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub Death_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Death_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(Death_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub chronic_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles chronic_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(chronic_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub Drug_opd_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles Drug_opd_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(Drug_opd_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub
End Class