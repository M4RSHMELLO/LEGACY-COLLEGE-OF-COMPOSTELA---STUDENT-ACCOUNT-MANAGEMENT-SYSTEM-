Imports System.Windows.Forms

Public Class loginSuccessfully
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            Dashboard.Show()
            Close()
            form_login.Hide()
        Catch ex As Exception

        End Try
    End Sub
End Class
