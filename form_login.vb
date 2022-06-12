
Public Class form_login
    Dim strQuery As String
    Private Sub Button2_Click(sender As Object, e As EventArgs)
        MessageBox.Show("login Successfully")
        dashboard.ShowDialog()
        Me.Close()
    End Sub
    Private Sub btn_login_click(sender As Object, e As EventArgs) Handles btn_login.Click
        strQuery = "Select username, Name ,user_type from tbl_users where username = '" & txtb_username.Text & "' and password = md5('" & txtb_password.Text & "') "
        _dbConnection("db_lccsams")
        _retrieveData(strQuery)
        If result = 1 Then
            loginSuccessfully.ShowDialog()
        Else
            MessageError_Dialog.ShowDialog()
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If txtb_password.UseSystemPasswordChar = True Then
            txtb_password.UseSystemPasswordChar = False
        Else
            txtb_password.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class