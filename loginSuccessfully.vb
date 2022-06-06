Public Class loginSuccessfully
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            Dashboard.Show()
            form_login.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
