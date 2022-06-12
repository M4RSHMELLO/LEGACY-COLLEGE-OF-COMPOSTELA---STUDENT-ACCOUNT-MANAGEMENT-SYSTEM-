Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.IO
Public Class frm_user
    Dim strQuerry As String
    Dim creationDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub btn_update_Click(sender As Object, e As EventArgs)
        If btn_update.Text = "UPDATE" Then
            If dlg_updateuser.ShowDialog() = DialogResult.OK Then
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
                    btn_update.Text = "UPDATE"
                End If
            End If
        End If

    End Sub
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        strQuerry = "Select user_id,Name,username, md5(password) as password,user_type from tbl_users order by Name"

        _displayRecords(strQuerry, dg_users)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        If btnSave.Text = "ADD" Then
            If dlg_addusers.ShowDialog() = DialogResult.OK Then
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
                    btnSave.Text = "ADD"
                End If
            End If

        End If


    End Sub
    Dim user_id As Integer
    Private Sub dg_users_CellClick(sender As Object, e As DataGridViewCellEventArgs)
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

    Private Sub dg_users_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If e.ColumnIndex = 3 Then
            e.Value = New String("*", e.Value.ToString.Length)
        End If
    End Sub
    Dim Path As String
    Dim BackupPath As String = "C:\Users\RJR-PC\Desktop\backup\"
    Dim DatabaseName As String = "lccsams_Backup-" + Date.Now.ToString("dd-MM-yyyy-HH-mm-ss")
    Sub Backup()
        'XAMPP SERVER
        Process.Start("C:\xampp\MySql\bin\mysqldump.exe", " --host=localhost --user=raldz --password=d74r3j93527  db_lccsams -r """ & BackupPath & "" & DatabaseName & ".sql""")
        dlg_backupsuccessfully.ShowDialog()
    End Sub
    Sub Restore()
        Dim myProcess As New Process()

        myProcess.StartInfo.FileName = "cmd.exe"
        myProcess.StartInfo.UseShellExecute = False
        myProcess.StartInfo.WorkingDirectory = "C:\xampp\mysql\bin"
        myProcess.StartInfo.RedirectStandardInput = True
        myProcess.StartInfo.RedirectStandardOutput = True
        myProcess.Start()
        Dim myStreamerWriter As StreamWriter = myProcess.StandardInput
        Dim myStreamerReader As StreamReader = myProcess.StandardOutput
        myStreamerWriter.WriteLine("mysql--host=localhost --user=raldz --password=d74r3j93527 db_lccsams  < " & Path & "")
        myStreamerWriter.Close()
        myProcess.WaitForExit()
        myProcess.Close()
    End Sub
    Private Sub btn_BACKUP_Click(sender As Object, e As EventArgs) Handles btn_BACKUP.Click

        Backup()

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_restore.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\Users\RJR-PC\Desktop\backup\"
        OpenFileDialog1.ShowDialog()

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Path = OpenFileDialog1.FileName.ToString()
        Restore()
        dlg_backuprestoresuccessfully.ShowDialog()
    End Sub
End Class
