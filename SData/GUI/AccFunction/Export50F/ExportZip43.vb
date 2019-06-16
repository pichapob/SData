Imports System.IO
Imports System.Globalization
Imports Ionic.Zip

Public Class ExportZip43
    Dim sqlf As New SQLManager
    Dim person As New DataTable
    Dim specialpp As New DataTable
    Dim anc As New DataTable
    Dim epi As New DataTable
    Dim chronic As New DataTable
    Public Sub setPERSON(ByVal person As DataTable)
        Me.person = person
    End Sub
    Public Sub setEPI(ByVal epi As DataTable)
        Me.epi = epi
    End Sub
    Public Sub setSPECIALPP(ByVal specialpp As DataTable)
        Me.specialpp = specialpp
    End Sub
    Public Sub setANC(ByVal anc As DataTable)
        Me.anc = anc
    End Sub
    Public Sub setCHRONIC(ByVal chronic As DataTable)
        Me.chronic = chronic
    End Sub
    Public Sub ExportData(ByVal path As String)
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
            Dim fileExportFoder As String = path & "\F43_" & hospcode & "_" & dupdate
            If (Not System.IO.Directory.Exists(fileExportFoder)) Then
                System.IO.Directory.CreateDirectory(fileExportFoder)
            End If
            'epi
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
            End If
            'anc
            If anc.Rows.Count > 0 Then
                sw = New StreamWriter(fileExportFoder & "\ANC.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                Dim data As String = ""
                For i As Integer = 0 To anc.Columns.Count - 1
                    header &= anc.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                For r As Integer = 0 To anc.Rows.Count - 1
                    data = ""
                    For c As Integer = 0 To anc.Columns.Count - 1
                        data &= anc.Rows(r).Item(c).ToString() & "|"
                    Next
                    sw.WriteLine(data.Substring(0, data.Length - 1))
                Next
                sw.Close()
            End If
            'chronic
            If chronic.Rows.Count > 0 Then
                sw = New StreamWriter(fileExportFoder & "\CHRONIC.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                Dim data As String = ""
                For i As Integer = 0 To chronic.Columns.Count - 1
                    header &= chronic.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                For r As Integer = 0 To chronic.Rows.Count - 1
                    data = ""
                    For c As Integer = 0 To chronic.Columns.Count - 1
                        data &= chronic.Rows(r).Item(c).ToString() & "|"
                    Next
                    sw.WriteLine(data.Substring(0, data.Length - 1))
                Next
                sw.Close()
            End If
            'person
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
            End If
            'specialpp
            If specialpp.Rows.Count > 0 Then
                sw = New StreamWriter(fileExportFoder & "\SPECIALPP.txt", appendMode, utf8WithoutBom)
                Dim header As String = ""
                Dim data As String = ""
                For i As Integer = 0 To specialpp.Columns.Count - 1
                    header &= specialpp.Columns(i).ColumnName & "|"
                Next
                sw.WriteLine(header.Substring(0, header.Length - 1))
                For r As Integer = 0 To specialpp.Rows.Count - 1
                    data = ""
                    For c As Integer = 0 To specialpp.Columns.Count - 1
                        data &= specialpp.Rows(r).Item(c).ToString() & "|"
                    Next
                    sw.WriteLine(data.Substring(0, data.Length - 1))
                Next
                sw.Close()
            End If

            Dim zip As ZipFile = New ZipFile
            zip.AddDirectory(fileExportFoder)
            zip.Save(fileExportFoder & ".ZIP")
            zip.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
