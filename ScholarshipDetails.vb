Public Class ScholarshipDetails
    Dim frm_sSg As New frm_sSG
    Dim btnS As Integer
    Dim schStatus As Integer
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If MessageBox.Show("", "Do You want to add new scholar", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            txtb_sType.Enabled = True
            btnS = 1
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        txtb_sType.Enabled = False
        If rbtn_active.Checked = True Then
            schStatus = 1
        ElseIf rbtn_inactive.Checked = True Then
            schStatus = 0
        Else
            schStatus = 1
        End If
        If btnS = 1 Then

            Dim insertS As String = "Insert into tbl_scholar_type values(0,'" & txtb_sType.Text & "','" & schStatus & "')"
            _insertData(insertS)
            If dlg_savesuccessfully.ShowDialog = DialogResult.OK Then
                txtb_sType.Clear()
                txtb_sType.Enabled = False
                _displayRecords(scholar_list, dg_scholarTypeList)
            End If
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtb_sType.Enabled = False
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dashboard.BunifuFlatButton4_Click(sender, e)
        Me.Close()

    End Sub


End Class