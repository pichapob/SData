Imports System.Globalization
Imports System.IO
Imports Ionic.Zip

Public Class DataCorrectExport
    Dim sqlf As New SQLManager
    Dim person As DataTable = Nothing
    Dim specailpp As DataTable = Nothing
    Dim diagnosisopd As DataTable = Nothing
    Dim chronic As DataTable = Nothing
    Dim address As DataTable = Nothing
    Dim death As DataTable = Nothing
    Dim card As DataTable = Nothing
    Dim home As DataTable = Nothing
    Dim village As DataTable = Nothing
    Dim disability As DataTable = Nothing
    Dim provider As DataTable = Nothing
    Dim woment As DataTable = Nothing
    Dim drugallergy As DataTable = Nothing
    Dim functional As DataTable = Nothing
    Dim icf As DataTable = Nothing
    Dim service As DataTable = Nothing
    Dim drugopd As DataTable = Nothing
    Dim procedureopd As DataTable = Nothing
    Dim chargeopd As DataTable = Nothing
    Dim surveillance As DataTable = Nothing
    Dim accident As DataTable = Nothing
    Dim labfu As DataTable = Nothing
    Dim chronicfu As DataTable = Nothing
    Dim admission As DataTable = Nothing
    Dim diagnosisipd As DataTable = Nothing
    Dim drugipd As DataTable = Nothing
    Dim procedureipd As DataTable = Nothing
    Dim chargeipd As DataTable = Nothing
    Dim appoinment As DataTable = Nothing
    Dim dental As DataTable = Nothing
    Dim rehabilitation As DataTable = Nothing
    Dim ncdscreen As DataTable = Nothing
    Dim fp As DataTable = Nothing
    Dim prenatal As DataTable = Nothing
    Dim anc As DataTable = Nothing
    Dim labor As DataTable = Nothing
    Dim postnatal As DataTable = Nothing
    Dim newborn As DataTable = Nothing
    Dim newborncare As DataTable = Nothing
    Dim epi As DataTable = Nothing
    Dim nutrition As DataTable
    Dim communityactivity As DataTable = Nothing
    Dim dommunityservice As DataTable = Nothing


    Public Sub Set_person(ByVal data As DataTable)
        Me.person = data
    End Sub
    Public Sub Set_specialpp(ByVal data As DataTable)
        Me.specailpp = data
    End Sub
    Public Sub Set_diagnosisopd(ByVal data As DataTable)
        Me.diagnosisopd = data
    End Sub
    Public Sub Set_chronic(ByVal data As DataTable)
        Me.chronic = data
    End Sub
    Public Sub Set_address(ByVal data As DataTable)
        Me.address = data
    End Sub
    Public Sub Set_death(ByVal data As DataTable)
        Me.death = data
    End Sub
    Public Sub Set_card(ByVal data As DataTable)
        Me.card = data
    End Sub
    Public Sub Set_drugopd(ByVal data As DataTable)
        Me.drugopd = data
    End Sub
    Public Sub Set_procedureopd(ByVal data As DataTable)
        Me.procedureopd = data
    End Sub
    Public Sub Set_service(ByVal data As DataTable)
        Me.service = data
    End Sub


    Public Sub exportDataCorrect(ByVal path As String, ByVal hospcode As String)
        Dim utf8WithoutBom As New System.Text.UTF8Encoding(False)
        Dim sw As StreamWriter
        Dim appendMode As Boolean = False
        Dim dupdate As String = Date.Now.ToString("yyyyMMddHHmmss", New CultureInfo("en-GB"))
        Dim fileExportFoder As String = path & "\F43_" & hospcode & "_" & dupdate
        If (Not System.IO.Directory.Exists(fileExportFoder)) Then
            System.IO.Directory.CreateDirectory(fileExportFoder)
        End If
        sw = New StreamWriter(fileExportFoder & "\DATA_CORRECT.txt", appendMode, utf8WithoutBom)
        Dim st_header As String = "HOSPCODE|TABLENAME|DATA_CORRECT|D_UPDATE"
        sw.WriteLine(st_header)
        Dim st_data As String = ""
        Dim sql As String = ""
        Dim rs As DataTable
        Dim data_correct() As String = Nothing

        If person IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'PERSON'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To person.Rows.Count - 1
                st_data = person.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "PERSON|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    st_data &= "'" & data_correct(j).ToUpper & "':'" & person.Rows(i).Item(data_correct(j)).ToString & "',"
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If diagnosisopd IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'DIAGNOSIS_OPD'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To diagnosisopd.Rows.Count - 1
                st_data = diagnosisopd.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "DIAGNOSIS_OPD|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString = "DATE_SERV" Then
                        Dim datest As String = Date.Parse(diagnosisopd.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & diagnosisopd.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If specailpp IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'SPECIALPP'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To specailpp.Rows.Count - 1
                st_data = specailpp.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "SPECIALPP|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString = "DATE_SERV" Then
                        Dim datest As String = Date.Parse(specailpp.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & specailpp.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If address IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'ADDRESS'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To address.Rows.Count - 1
                st_data = address.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "ADDRESS|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString = "DATE_SERV" Then
                        Dim datest As String = Date.Parse(address.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & address.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If chronic IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'CHRONIC'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To chronic.Rows.Count - 1
                st_data = chronic.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "CHRONIC|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString.Contains("DATE") Then
                        Dim datest As String = Date.Parse(chronic.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & chronic.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If death IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'DEATH'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To death.Rows.Count - 1
                st_data = death.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "DEATH|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString.Contains("DATE") Then
                        Dim datest As String = Date.Parse(death.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & death.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If drugopd IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'DRUG_OPD'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To drugopd.Rows.Count - 1
                st_data = drugopd.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "DRUG_OPD|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString.Contains("DATE") Then
                        Dim datest As String = Date.Parse(drugopd.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & drugopd.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If procedureopd IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'PROCEDURE_OPD'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To procedureopd.Rows.Count - 1
                st_data = procedureopd.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "PROCEDURE_OPD|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString.Contains("DATE") Then
                        Dim datest As String = Date.Parse(procedureopd.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & procedureopd.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        If service IsNot Nothing Then
            sql = "SELECT sd.tablename,sd.keysearch FROM sd_cdata_correct sd WHERE sd.tablename LIKE 'SERVICE'"
            rs = sqlf.QueryAsDatatable(sql)
            If rs.Rows.Count > 0 Then
                data_correct = rs.Rows(0).Item("keysearch").ToString.Split("|")
            End If
            For i As Integer = 0 To service.Rows.Count - 1
                st_data = service.Rows(i).Item("HOSPCODE").ToString & "|"
                st_data &= "SERVICE|"
                st_data &= "{"
                For j As Integer = 0 To data_correct.Length - 1
                    If data_correct(j).ToString.Contains("DATE") Then
                        Dim datest As String = Date.Parse(service.Rows(i).Item(data_correct(j)).ToString).ToString("yyyyMMdd", New CultureInfo("en-GB"))
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & datest & "',"
                    Else
                        st_data &= "'" & data_correct(j).ToUpper & "':'" & service.Rows(i).Item(data_correct(j).ToString).ToString & "',"
                    End If
                Next
                st_data &= "'EDITOR_CID':'" & SharingEntrities.cid & "'}|"
                st_data &= dupdate
                sw.WriteLine(st_data)
            Next
        End If

        sw.Close()
        Dim zip As ZipFile = New ZipFile
        zip.AddDirectory(fileExportFoder)
        zip.Save(fileExportFoder & ".ZIP")
        zip.Dispose()
    End Sub
End Class
