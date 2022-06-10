Imports System.Windows.Forms

Public Class dlg_addfees


    Private Sub dlg_addsdnt_yes_Click(sender As Object, e As EventArgs) Handles dlg_addsdnt_yes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub dlg_addsdnt_no_Click(sender As Object, e As EventArgs) Handles dlg_addsdnt_no.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
