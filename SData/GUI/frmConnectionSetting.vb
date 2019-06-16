Public Class frmConnectionSetting
    Private Sub frmConnectionSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        host_tf.Text = My.Settings.db_host
        dbname_tf.Text = My.Settings.db_name
        port_tf.Text = My.Settings.db_port
        user_tf.Text = My.Settings.db_username
        password_tf.Text = My.Settings.db_password
    End Sub

    Private Sub ok_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ok_b.Click
        My.Settings.db_host = host_tf.Text
        My.Settings.db_name = dbname_tf.Text
        My.Settings.db_port = port_tf.Text
        My.Settings.db_username = user_tf.Text
        My.Settings.db_password = password_tf.Text
        My.Settings.Save()
        Dispose()
    End Sub

    Private Sub test_connection_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles test_connection_b.Click
        Try
            Dim con As SQLManager = New SQLManager
            If con.TestConnectionDB(host_tf.Text, dbname_tf.Text, user_tf.Text, password_tf.Text, port_tf.Text) Then
                MessageBox.Show("เชื่อมต่อฐานข้อมูลาเร็จ", "SData Messages")
            Else
                MessageBox.Show("เกิดข้อผิดพลาดในการเชื่อมต่อ", "SData Messages")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class