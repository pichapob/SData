Imports MySql.Data.MySqlClient

Public Class SharingEntrities
    Public Shared SQLConnection As MySqlConnection
    Public Shared UserLevel As Integer = 0
    Public Shared loginname As String = ""
    Public Shared cid As String = ""

    Public Shared startdate As String
    Public Shared enddate As String
    Public Shared year_set As String
    Public Shared url_epi As String = "http://203.157.162.18/PHPRest/EPIRest.php?"
    Public Shared version As String
End Class
