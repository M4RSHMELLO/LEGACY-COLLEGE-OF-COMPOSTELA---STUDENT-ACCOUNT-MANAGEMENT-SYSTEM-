Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class frm_user
    Dim strQuerry As String
    Dim creationDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If btn_update.Text = "UPDATE" Then
            If dlg_updatefees.ShowDialog() = DialogResult.OK Then
                btn_update.Text = "SAVE"
                txtb_name.Enabled = True
                txtb_Uname.Enabled = True
                txtb_pass.Enabled = True
                cbo_usertype.Enabled = True
            End If

        ElseIf btn_update.Text = "SAVE" Then
            If txtb_name.Text = "" Or txtb_Uname.Text = "" Or txtb_pass.Text = "" Then
                dlg_fillup.ShowDialog()
            Else
                Dim strQuerry1 As String = "update tbl_users set Name='" & txtb_name.Text & "',username='" & txtb_Uname.Text & "',password=md5('" & txtb_pass.Text & "'),updated_at=NOW() where user_id='" & user_id & "'"
                _dbConnection("db_lccsams")
                _updateData(strQuerry1)
                If dlg_savesuccessfully.ShowDialog() Then
                    txtb_name.Enabled = False
                    txtb_Uname.Enabled = False
                    txtb_pass.Enabled = False
                    cbo_usertype.Enabled = False
                    _displayRecords(strQuerry, dg_users)

                End If
            End If
        End If

    End Sub
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strQuerry = "Select user_id,Name,username, md5(password) as password,user_type from tbl_users order by Name"

        _displayRecords(strQuerry, dg_users)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If btnSave.Text = "ADD" Then
            If dlg_addfees.ShowDialog() = DialogResult.OK Then
                btnSave.Text = "SAVE"
                txtb_name.Enabled = True
                txtb_Uname.Enabled = True
                txtb_pass.Enabled = True
                cbo_usertype.Enabled = True

                txtb_name.Clear()
                txtb_Uname.Clear()
                txtb_pass.Clear()
            End If

        ElseIf btnSave.Text = "SAVE" Then
            If txtb_name.Text = "" Or txtb_Uname.Text = "" Or txtb_pass.Text = "" Then
                dlg_fillup.ShowDialog()
            Else
                Dim strQuerry1 As String = "Insert into  tbl_users  (user_id,Name, username, password, user_type,creation_date) values (0,'" & txtb_name.Text & "','" & txtb_Uname.Text & "',md5('" & txtb_pass.Text & "'),'" & cbo_usertype.Text & "',NOW())"
                _dbConnection("db_lccsams")
                _insertData(strQuerry1)
                If dlg_savesuccessfully.ShowDialog() Then
                    txtb_name.Enabled = False
                    txtb_Uname.Enabled = False
                    txtb_pass.Enabled = False
                    cbo_usertype.Enabled = False
                    _displayRecords(strQuerry, dg_users)

                End If
            End If

        End If


    End Sub
    Dim user_id As Integer
    Private Sub dg_users_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_users.CellClick
        Try
            Dim i = e.RowIndex
            With dg_users
                user_id = .Item(0, i).Value
                txtb_name.Text = .Item(1, i).Value
                txtb_Uname.Text = .Item(2, i).Value
                'txtb_pass.Text = .Item(3, i).Value
                cbo_usertype.Text = .Item(4, i).Value
            End With

        Catch ex As Exception

        End Try

    End Sub

    Private Sub dg_users_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dg_users.CellFormatting
        If e.ColumnIndex = 3 Then
            e.Value = New String("*", e.Value.ToString.Length)
        End If
    End Sub
End Class
