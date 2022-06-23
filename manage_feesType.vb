Public Class manage_feesType
    Dim btnS As Integer
    Dim feesType_id As Integer
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        If MessageBox.Show("Do You want to add new Fees Type", "", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            txtb_FeesType.Enabled = True
            btn_update.Enabled = False
            btn_save.Enabled = True
            btn_new.Enabled = False
            btnS = 1
        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MessageBox.Show("Do You want to update This Fees Type" & vbNewLine & lbo_feesType.Text, "", MessageBoxButtons.OKCancel) = DialogResult.OK Then
            txtb_FeesType.Enabled = True
            btn_update.Enabled = False
            btn_new.Enabled = False
            btn_save.Enabled = True

            btnS = 2
        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtb_FeesType.Text = "" Then
            dlg_fillup.ShowDialog()
        Else
            txtb_FeesType.Enabled = False
            btn_new.Enabled = True
            txtb_FeesType.Enabled = False
            btn_update.Enabled = True
            btn_save.Enabled = False
            If btnS = 1 Then
                Dim newFeeType As String = "Insert into tbl_fees_type values(0,'" & txtb_FeesType.Text & "')"
                _insertData(newFeeType)
                If dlg_savesuccessfully.ShowDialog = DialogResult.OK Then

                    _loadToListBox(slctFeesType, lbo_feesType)
                End If
            ElseIf btnS = 2 Then
                Dim updatefeesType As String = "Update tbl_fees_type set feestype_name='" & txtb_FeesType.Text & "' where feestype_id='" & lbo_feesType.SelectedValue & "'"
                _updateData(updatefeesType)
                If UpdatedSuccessfully.ShowDialog = DialogResult.OK Then

                    _loadToListBox(slctFeesType, lbo_feesType)
                End If
            End If
        End If

    End Sub

    Private Sub lbo_feesType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbo_feesType.SelectedIndexChanged
        Try

            txtb_FeesType.Text = lbo_feesType.Text
            feesType_id = lbo_feesType.SelectedValue
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Dashboard.BunifuFlatButton8_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        txtb_FeesType.Enabled = False
        btn_new.Enabled = True
        btn_update.Enabled = True
        btn_save.Enabled = False
        txtb_FeesType.Clear()
    End Sub
End Class