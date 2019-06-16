Imports System.Globalization

Public Class frmGetDateStartEnd

    Private Sub OK_B_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_B.Click
        SharingEntrities.startdate = begindate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
        SharingEntrities.enddate = enddate_tf.Value.ToString("yyyy-MM-dd", New CultureInfo("en-GB"))
        Dispose()
    End Sub

    Private Sub frmGetDateStartEnd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        begindate_tf.Value = Date.Now
        enddate_tf.Value = Date.Now
    End Sub
End Class