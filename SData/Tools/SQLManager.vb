Imports MySql.Data.MySqlClient

Public Class SQLManager
    Private StringConnection As String = "server={0};user id={1}; password={2}; Port={3}; database={4}; pooling=false;Allow Zero Datetime=true;default command timeout=0;Character Set=utf8;"
    Public Function TestConnectionDB(ByVal HOST As String, ByVal DBNAME As String, ByVal USERNAME As String, ByVal PASSWORD As String, ByVal PORT As String) As Boolean
        Dim ret As Boolean = False
        Try
            Dim SQLConnection As MySqlConnection = New MySqlConnection(String.Format(StringConnection, HOST, USERNAME, PASSWORD, PORT, DBNAME))
            SQLConnection.Open()
            SQLConnection.Close()
            ret = True
        Catch ex As Exception
            ret = False
        End Try
        Return ret
    End Function
    Public Function SetConnectionDB(ByVal HOST As String, ByVal DBNAME As String, ByVal USERNAME As String, ByVal PASSWORD As String, ByVal PORT As String) As Boolean
        Dim ret As Boolean = False
        Try
            SharingEntrities.SQLConnection = New MySqlConnection(String.Format(StringConnection, HOST, USERNAME, PASSWORD, PORT, DBNAME))
            SharingEntrities.SQLConnection.Open()
            ret = True
        Catch ex As Exception
            ret = False
        End Try
        Return ret
    End Function
    Public Function Excute(ByVal Query As String) As Integer
        Dim ret As Integer
        Try
            Dim Mycmd As New MySqlCommand(Query, SharingEntrities.SQLConnection)
            ret = Mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("ERROR MODUL SQLFuction : Excute Please Contact Admin" & Query)
        End Try
        Return ret
    End Function
    Public Function CheckLogin(ByVal USERNAME As String, ByVal PASSWORD As String) As Boolean
        Dim ret As Boolean = False
        Dim lv As String = ""
        Dim cid As String = ""
        Dim loginname As String = ""
        Dim Query As String = "SELECT *,if(accessright like '%ADMIN%',1,0) AS lv FROM opduser WHERE loginname = '" & USERNAME & "' AND passweb = MD5('" & PASSWORD & "')"
        Dim userch As DataTable = QueryAsDatatable(Query)
        If userch.Rows.Count > 0 Then
            SharingEntrities.UserLevel = userch.Rows(0).Item("lv").ToString
            SharingEntrities.loginname = userch.Rows(0).Item("loginname").ToString
            SharingEntrities.cid = userch.Rows(0).Item("cid").ToString
            ret = True
        End If
        Return ret
    End Function
    Public Function QueryAsDatatable(ByVal Query As String) As DataTable
        Dim ds As DataTable = New DataTable
        Dim SQLMDA As MySqlDataAdapter
        Dim SQLCB As MySqlCommandBuilder
        SQLMDA = New MySqlDataAdapter(Query, SharingEntrities.SQLConnection)
        SQLCB = New MySqlCommandBuilder(SQLMDA)
        SQLMDA.Fill(ds)
        Return ds
    End Function
End Class
