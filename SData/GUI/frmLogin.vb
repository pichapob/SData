Public Class frmLogin
    Private checked As Boolean = False
    Private Sub cancle_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancle_b.Click
        Me.Close()
        Application.Exit()
    End Sub

    Private Sub frmLogin_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        If checked Then
            Dispose()
        Else
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub connection_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles connection_b.Click
        Dim a As New frmConnectionSetting
        a.ShowDialog()
    End Sub

    Private Sub login_b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_b.Click
        Dim sqlf As New SQLManager
        Try
            If sqlf.SetConnectionDB(My.Settings.db_host, My.Settings.db_name, My.Settings.db_username, My.Settings.db_password, My.Settings.db_port) Then
                If sqlf.CheckLogin(username_tf.Text, password_tf.Text) Then
                    checked = True
                    Me.Dispose()
                Else
                    MessageBox.Show("ชื่อผู้ใช้งานหนือรหัสผู้ใช้งานไม่ภูกต้อง", "SData Message")
                End If
            Else
                MessageBox.Show("ตรวจสอบการตั้งค่าเชื่อมต่อ", "SData Message")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class