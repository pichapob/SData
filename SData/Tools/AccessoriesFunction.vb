Imports System.IO
Imports Microsoft.Office.Interop
Imports System.Globalization

Public Class AccessoriesFunction
    Public Sub ExportDataToCSV(ByVal filename As String, ByVal data As DataTable)
        Dim myWriter As New System.IO.StreamWriter(filename, True, System.Text.Encoding.GetEncoding("TIS-620"))
        Try
            If data.Rows.Count > 0 Then

                Dim sep As String = ""
                Dim builder As New System.Text.StringBuilder
                For Each col As DataColumn In data.Columns
                    builder.Append(sep).Append(col.ColumnName)
                    sep = ","
                Next
                myWriter.WriteLine(builder.ToString())

                ' then write all the rows
                For Each row As DataRow In data.Rows
                    sep = ""
                    builder = New System.Text.StringBuilder

                    For Each col As DataColumn In data.Columns
                        builder.Append(sep).Append(row(col.ColumnName).ToString)
                        sep = ","
                    Next
                    myWriter.WriteLine(builder.ToString())
                Next
            Else
                MessageBox.Show("ไม่มีข้อมูลที่จะส่งออก")
            End If
        Catch ex As Exception
            MessageBox.Show("ERROR MODULE Accesories Function : ExportDataToCSV :" & ex.ToString)
            myWriter.Close()
        End Try
        myWriter.Close()
    End Sub
    Public Sub ExportDataToText(ByVal filename As String, ByVal data As DataTable)
        Try
            Dim output As String = ""
            Dim SwFromFileTrueUTF8 As StreamWriter = New StreamWriter(filename, True, System.Text.Encoding.UTF8)
            If data.Rows.Count > 0 Then
                For j As Integer = 0 To data.Columns.Count - 1
                    output &= data.Columns.Item(j).ColumnName & "|"
                Next
                output = output.Substring(0, output.Length - 1) & vbCrLf

                For i As Integer = 0 To data.Rows.Count - 1
                    For j As Integer = 0 To data.Columns.Count - 1
                        output &= data.Rows(i).Item(j).ToString() & "|"
                    Next
                    output = output.Substring(0, output.Length - 1) & vbCrLf
                Next
            Else
                MessageBox.Show("ไม่มีข้อมูลที่จะส่งออก")
            End If
            SwFromFileTrueUTF8.Write(output)
            SwFromFileTrueUTF8.Flush()
            SwFromFileTrueUTF8.Close()
        Catch ex As Exception
            MessageBox.Show("ERROR MODULE Accesories Function : ExportDataToText : " & ex.ToString)
        End Try
    End Sub
    Public Sub ExportExcelTemplateStudentVaScreen(ByVal data As DataTable, ByVal path As String, ByVal export_status As Integer)
        Dim name_ex As String = ""
        If data.Rows.Count > 0 Then
            Dim APP As New Excel.Application
            Dim worksheet As Excel.Worksheet
            Dim workbook As Excel.Workbook

            Dim path_excel As String = ""
            Dim type_export As String = ""
            If export_status = 1 Then
                path_excel = "Eye_Examination_for_school.xlsx"
                type_export = "scholl"
            ElseIf export_status = 2 Then
                path_excel = "Eye_Examination_for_pcu.xlsx"
                type_export = "pcu"
            ElseIf export_status = 3 Then
                path_excel = "Eye_Examination_for_school.xlsx"
                type_export = "student"
            End If
            workbook = APP.Workbooks.Open(CurDir() & "\" & path_excel)


            worksheet = workbook.Worksheets("DATA")
            Dim row As Integer = 0
            For i As Integer = 0 To data.Rows.Count - 1

                If (export_status = 1 And data.Rows(i).Item("student_right_eye_score").ToString <> "" And data.Rows(i).Item("student_left_eye_score").ToString <> "") Or (export_status = 2 And data.Rows(i).Item("r01").ToString <> "" And data.Rows(i).Item("l01").ToString <> "") Or export_status = 3 Then

                    worksheet.Cells(5 + row, 2).Value = data.Rows(i).Item("cid").ToString
                    worksheet.Cells(5 + row, 3).Value = data.Rows(i).Item("fname").ToString
                    worksheet.Cells(5 + row, 4).Value = data.Rows(i).Item("lname").ToString
                    worksheet.Cells(5 + row, 5).Value = data.Rows(i).Item("sex_id").ToString
                    worksheet.Cells(5 + row, 6).Value = Date.Parse(data.Rows(i).Item("birthdate").ToString).ToString("dd/MM/yyyy", New CultureInfo("th-TH"))
                    worksheet.Cells(5 + row, 8).Value = data.Rows(i).Item("school_room_no").ToString

                    If data.Rows(i).Item("village_school_class_id").ToString = 1 Then
                        worksheet.Cells(5 + row, 7).Value = "อ1"
                        name_ex = "อ1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 2 Then
                        worksheet.Cells(5 + row, 7).Value = "อ2"
                        name_ex = "อ2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 3 Then
                        worksheet.Cells(5 + row, 7).Value = "อ3"
                        name_ex = "อ3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 4 Then
                        worksheet.Cells(5 + row, 7).Value = "ป1"
                        name_ex = "ป1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 5 Then
                        worksheet.Cells(5 + row, 7).Value = "ป2"
                        name_ex = "ป2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 6 Then
                        worksheet.Cells(5 + row, 7).Value = "ป3"
                        name_ex = "ป3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 7 Then
                        worksheet.Cells(5 + row, 7).Value = "ป4"
                        name_ex = "ป4"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 8 Then
                        worksheet.Cells(5 + row, 7).Value = "ป5"
                        name_ex = "ป5"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 9 Then
                        worksheet.Cells(5 + row, 7).Value = "ป6"
                        name_ex = "ป6"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 10 Then
                        worksheet.Cells(5 + row, 7).Value = "ม1"
                        name_ex = "ม1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 11 Then
                        worksheet.Cells(5 + row, 7).Value = "ม2"
                        name_ex = "ม2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 12 Then
                        worksheet.Cells(5 + row, 7).Value = "ม3"
                        name_ex = "ม3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 13 Then
                        worksheet.Cells(5 + row, 7).Value = "ม4"
                        name_ex = "ม4"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 14 Then
                        worksheet.Cells(5 + row, 7).Value = "ม5"
                        name_ex = "ม5"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 15 Then
                        worksheet.Cells(5 + row, 7).Value = "ม6"
                        name_ex = "ม6"
                    Else
                        worksheet.Cells(5 + row, 7).Value = ""
                    End If

                    If export_status = 2 Then
                        worksheet.Cells(5 + row, 9).Value = data.Rows(i).Item("r01").ToString
                        worksheet.Cells(5 + row, 10).Value = data.Rows(i).Item("rph").ToString
                        worksheet.Cells(5 + row, 11).Value = data.Rows(i).Item("l01").ToString
                        worksheet.Cells(5 + row, 12).Value = data.Rows(i).Item("lph").ToString
                    Else
                        worksheet.Cells(5 + row, 9).Value = data.Rows(i).Item("student_right_eye_score").ToString
                        worksheet.Cells(5 + row, 11).Value = data.Rows(i).Item("student_left_eye_score").ToString
                    End If
                    row += 1
                Else
                    If data.Rows(i).Item("village_school_class_id").ToString = 1 Then
                        name_ex = "อ1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 2 Then
                        name_ex = "อ2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 3 Then
                        name_ex = "อ3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 4 Then
                        name_ex = "ป1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 5 Then
                        name_ex = "ป2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 6 Then
                        name_ex = "ป3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 7 Then
                        name_ex = "ป4"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 8 Then
                        name_ex = "ป5"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 9 Then
                        name_ex = "ป6"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 10 Then
                        name_ex = "ม1"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 11 Then
                        name_ex = "ม2"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 12 Then
                        name_ex = "ม3"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 13 Then
                        name_ex = "ม4"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 14 Then
                        name_ex = "ม5"
                    ElseIf data.Rows(i).Item("village_school_class_id").ToString = 15 Then
                        name_ex = "ม6"
                    End If
                End If
            Next
            workbook.SaveAs(path & data.Rows(0).Item("school_name").ToString & "_" & name_ex & "_" & type_export & ".xlsx")
            workbook.Close()
            APP.Quit()
            MessageBox.Show("ส่งออกเรียบร้อย")
        End If
    End Sub
    Public Function EncryptText(ByVal text As String, ByVal key As String) As String
        Dim text_plain As Byte() = System.Text.Encoding.UTF8.GetBytes(text)
        Dim text_key As Byte() = System.Text.Encoding.UTF8.GetBytes(key)
        Dim chitext(text_plain.Length - 1) As Byte
        Dim output As String = ""
        For i As Integer = 0 To text_plain.Length - 1
            chitext((text_plain.Length - (i + 1))) = (text_plain(i) Xor text_key(i Mod text_key.Length))
        Next
        output = Convert.ToBase64String(chitext)
        Return output
    End Function
    Public Function DecryptText(ByVal text As String, ByVal key As String) As String
        Dim chitext As Byte() = Convert.FromBase64String(text)
        Dim text_key As Byte() = System.Text.Encoding.UTF8.GetBytes(key)
        Dim text_plain(chitext.Length - 1) As Byte
        Dim output As String = ""
        For i As Integer = 0 To chitext.Length - 1
            text_plain(i) = (chitext(chitext.Length - (i + 1)) Xor text_key(i Mod text_key.Length))
        Next
        output = System.Text.Encoding.UTF8.GetString(text_plain)
        Return output
    End Function
End Class
