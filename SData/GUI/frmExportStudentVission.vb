Imports System.Globalization

Public Class frmExportStudentVission
    Dim sqlf As New SQLManager
    Dim acce As New AccessoriesFunction
    Private Sub frmExportStudentVission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        reloadScholl()
        reloadClass(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value)
        reloadStudent(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value, class_table.Rows(class_table.CurrentRow.Index).Cells(0).Value)
    End Sub
    Public Sub reloadScholl()
        Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT vs.village_school_id,vs.school_name,vst.school_type_name,(SELECT COUNT(DISTINCT v.village_student_id) FROM village_student v WHERE (v.discharge<>'Y' or v.discharge is null) AND v.village_school_id = vs.village_school_id) AS student_count FROM village_school vs LEFT JOIN village_school_type vst ON vs.school_type_id = vst.school_type_id"
        Dim school As DataTable = sqlf.QueryAsDatatable(sql)
        school_table.DataSource = school
        Cursor = Cursors.Default
    End Sub
    Public Sub reloadClass(ByVal class_id As String)
        Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT vsc.village_school_class_id,vsc.village_school_class_name,(SELECT COUNT(DISTINCT vs.village_student_id) FROM village_student vs WHERE (vs.discharge<>'Y' or vs.discharge is null) AND vs.village_school_class_id = vsc.village_school_class_id AND vs.village_school_id = '" & class_id & "') AS student_count FROM village_school_class vsc ORDER BY vsc.village_school_class_id ASC"
        Dim class_sc As DataTable = sqlf.QueryAsDatatable(sql)
        class_table.DataSource = class_sc
        Cursor = Cursors.Default
    End Sub

    Public Sub reloadStudent(ByVal school_id As String, ByVal class_id As String)
        Cursor = Cursors.WaitCursor
        Dim sql As String = "SELECT vsh.school_name,vsc.village_school_class_id,vsc.village_school_class_name,"
        sql &= "vs.school_room_no,p.cid,p.fname,p.lname,p.sex as sex_id,s.`name` AS sex,p.birthdate,"
        sql &= "sc5.screen_date,sc5.student_left_eye_score,sc5.student_right_eye_score,"
        sql &= "ones.vstdate,ones.l01,ones.r01,ones.lph,ones.rph "
        sql &= "FROM village_student vs "
        sql &= "LEFT JOIN village_school vsh ON vs.village_school_id = vsh.village_school_id "
        sql &= "LEFT JOIN village_school_class vsc ON vs.village_school_class_id = vsc.village_school_class_id "
        sql &= "LEFT JOIN person p ON vs.person_id = p.person_id "
        sql &= "LEFT JOIN sex s ON p.sex = s.`code` "
        sql &= "LEFT JOIN ( "
        sql &= "	SELECT v1.* "
        sql &= "	FROM village_student_screen v1 "
        sql &= "	WHERE v1.screen_date BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' "
        sql &= "	AND v1.screen_date = (SELECT MAX(screen_date) FROM village_student_screen v2 WHERE v2.village_student_id = v1.village_student_id AND v2.student_left_eye_score IS NOT NULL) "
        sql &= ") AS sc5 ON vs.village_student_id = sc5.village_student_id "
        sql &= "LEFT JOIN ( "
        sql &= "    SELECT p.person_id,o.vn,o.vstdate,o.vsttime,e.r01,e.l01,e.rph,e.lph "
        sql &= "	FROM eye_screen e "
        sql &= "	INNER JOIN ovst o ON e.vn = o.vn AND o.vstdate BETWEEN '" & begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' AND '" & enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB")) & "' "
        sql &= "	INNER JOIN patient pt ON pt.hn = o.hn "
        sql &= "	INNER JOIN person p ON pt.cid = p.cid "
        sql &= "	WHERE o.vstdate = (SELECT MAX(vstdate) FROM eye_screen es INNER JOIN ovst ov ON ov.vn = es.vn "
        sql &= "	WHERE ov.hn = o.hn AND es.l01 IS NOT NULL) "
        sql &= ") as ones ON p.person_id = ones.person_id "
        sql &= "        WHERE(vs.village_school_id = " & school_id & ") "
        sql &= "AND vs.village_school_class_id = " & class_id & " AND (vs.discharge<>'Y' or vs.discharge is null)"
        Dim student As DataTable = sqlf.QueryAsDatatable(sql)
        student_table.DataSource = student
        Cursor = Cursors.Default
    End Sub

    Private Sub school_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles school_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(school_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub class_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles class_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(class_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub student_table_RowPostPaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPostPaintEventArgs) Handles student_table.RowPostPaint
        Using b As SolidBrush = New SolidBrush(student_table.RowHeadersDefaultCellStyle.ForeColor)
            e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y)
        End Using
    End Sub

    Private Sub export_student_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_student_b.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            acce.ExportExcelTemplateStudentVaScreen(student_table.DataSource, folderDlg.SelectedPath & "\", 3)
        End If
    End Sub

    Private Sub export_school_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_school_b.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            acce.ExportExcelTemplateStudentVaScreen(student_table.DataSource, folderDlg.SelectedPath & "\", 1)
        End If
    End Sub

    Private Sub export_va_pcu_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export_va_pcu_b.Click
        Dim folderDlg As New FolderBrowserDialog
        folderDlg.ShowNewFolderButton = True
        If (folderDlg.ShowDialog() = DialogResult.OK) Then
            acce.ExportExcelTemplateStudentVaScreen(student_table.DataSource, folderDlg.SelectedPath & "\", 2)
        End If
    End Sub

    Private Sub enddate_tf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enddate_tf.ValueChanged
        reloadStudent(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value, class_table.Rows(class_table.CurrentRow.Index).Cells(0).Value)
    End Sub

    Private Sub begindate_tf_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles begindate_tf.ValueChanged
        reloadStudent(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value, class_table.Rows(class_table.CurrentRow.Index).Cells(0).Value)
    End Sub

    Private Sub school_table_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles school_table.CellClick
        reloadClass(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value)
        reloadStudent(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value, class_table.Rows(class_table.CurrentRow.Index).Cells(0).Value)
    End Sub

    Private Sub class_table_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles class_table.CellClick
        reloadStudent(school_table.Rows(school_table.CurrentRow.Index).Cells(0).Value, class_table.Rows(class_table.CurrentRow.Index).Cells(0).Value)
    End Sub
End Class