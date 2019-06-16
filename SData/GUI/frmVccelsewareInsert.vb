Imports System.Globalization

Public Class frmVccelsewareInsert
    Dim pid As String
    Dim frms As frmVccElseware
    Dim sqlf As New SQLManager
    Dim vcccode As String
    Public Sub set_pid(ByVal person_id As String)
        pid = person_id
    End Sub
    Public Sub setfrm(ByVal frm As frmVccElseware)
        frms = frm
    End Sub
    Public Sub set_vcccode(ByVal vcc As String)
        Me.vcccode = vcc
    End Sub

    Private Sub frmVccelsewareInsert_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT pv.person_vaccine_id,pv.vaccine_name FROM person_vaccine pv"
        If vcccode <> "" Then
            sql &= " WHERE pv.export_vaccine_code IN(" & vcccode & ")"
        End If

        Dim comboSource As New Dictionary(Of String, String)()
        Dim vcclist As DataTable = sqlf.QueryAsDatatable(sql)
        For Each row As DataRow In vcclist.Rows
            comboSource.Add(row("person_vaccine_id").ToString, row("vaccine_name").ToString)
        Next
        vcc_list_tf.DataSource = New BindingSource(comboSource, Nothing)
        vcc_list_tf.DisplayMember = "Value"
        vcc_list_tf.ValueMember = "Key"
        vaccine_date_tf.Value = Date.Now
    End Sub

    Private Sub hospcode_tf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hospcode_tf.TextChanged
        If hospcode_tf.Text.Length = 5 Then
            Dim sql As String = "SELECT h.hosptype,h.hospcode,h.`name` As hospname from hospcode h WHERE h.hospcode = '" & hospcode_tf.Text & "' LIMIT 1"
            Dim hcode As DataTable = sqlf.QueryAsDatatable(sql)
            hospname_tf.Text = hcode.Rows(0).Item("hosptype").ToString & hcode.Rows(0).Item("hospname").ToString
        End If
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        Dim sql As String = "SELECT get_serialnumber('person_vaccine_elsewhere_id') cc"
        Dim rerial As DataTable = sqlf.QueryAsDatatable(sql)
        Dim serail As String = rerial.Rows(0).Item("cc").ToString
        Dim vcc_code As String = vcc_list_tf.SelectedValue
        Dim hospcode As String = hospcode_tf.Text
        Dim vaccine_date As String = vaccine_date_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
        sql = "INSERT INTO person_vaccine_elsewhere(person_vaccine_elsewhere_id,person_id,person_vaccine_id,vaccine_date,update_datetime,hospcode,vaccine_hospcode) VALUES('" & serail & "','" & pid & "','" & vcc_code & "','" & vaccine_date & "',NOW(),'" & hospcode & "','" & hospcode & "')"
        sqlf.Excute(sql)
        frms.reload_vcc()
        Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class