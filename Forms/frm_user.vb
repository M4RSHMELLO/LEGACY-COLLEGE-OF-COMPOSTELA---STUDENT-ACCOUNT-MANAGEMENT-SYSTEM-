Imports MySql.Data.MySqlClient
Public Class frm_user
    Dim strQuerry As String
    Dim creationDate As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Updated  Succesfully")
    End Sub
    Private Sub frm_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strQuerry = "Select Name,username, password from tbl_users order by Name"
        _displayRecords(strQuerry, dg_users)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim strQuerry1 As String = "Insert into  tbl_users  (Name, username, password, user_type) values ('" & txtb_name.Text & "','" & txtb_Uname.Text & "','" & txtb_pass.Text & "','" & cbo_usertype.Text & "')"
        _dbConnection("db_lccsams")
        _insertData(strQuerry1)
        _displayRecords(strQuerry, dg_users)
    End Sub
End Class
