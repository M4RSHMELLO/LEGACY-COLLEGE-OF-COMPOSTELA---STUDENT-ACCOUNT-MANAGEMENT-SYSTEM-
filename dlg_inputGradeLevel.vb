Imports System.Windows.Forms

Public Class dlg_inputGradeLevel



    Private Sub dlg_addgl_yes_Click(sender As Object, e As EventArgs) Handles dlg_addgl_yes.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub dlg_addgl_no_Click(sender As Object, e As EventArgs) Handles dlg_addgl_no.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.No
        Me.Close()
    End Sub


End Class
