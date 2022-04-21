Public Class frm_MSY
    Dim inputedV As String
    Dim strQuery3 As String
    Dim strQuerry5 As String
    Dim a As Integer = 0
    Dim sy_id As String
    Private Sub frm_MYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctS, cbo_semester)
        _loadToListBox(slctC, lbo_courses)
        _loadToListBox(slctYL, lbo_yearL)
        _displayRecords(s_msyR, dg_syR)
        dg_syR.Columns("sy_id").Visible = False
    End Sub

    Private Sub btn_nCourse_Click(sender As Object, e As EventArgs) Handles btn_nCourse.Click
        inputedV = InputBox("Input New Course")
        strQuery3 = "Insert into tbl_coll_course values ('0','" & inputedV & "')"
        _dbConnection("db_lccsams")
        _insertData(strQuery3)
        _loadToListBox(slctC, lbo_courses)

    End Sub


    Private Sub dg_syR_CellClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim i = e.RowIndex
        With dg_syR
            sy_id = .Item(0, i).Value
        End With
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Do you want to update this course? " & vbNewLine & "Name: " & lbo_courses.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            inputedV = InputBox("Enter a new name ")
            _updateData("Update tbl_course set crs_name='" & inputedV & "' where crs_id='" & lbo_courses.SelectedValue & "'")

            _loadToListBox(slctC, lbo_courses)
        End If


    End Sub

    Private Sub lbo_courses_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub



    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Select Case a
            Case 1
                Dim syN As String = txtb_syS.Text + "-" + " " + txtb_syE.Text
                Dim strQueery6 As String = "Insert Into tbl_sch_year values(0,'" & syN & "','" & dp_Start.Text & "','" & dp_End.Text & "','" & cbo_semester.SelectedValue & "')"
                _dbConnection("db_lccsams")
                _insertData(strQueery6)
                _displayRecords(s_msyR, dg_syR)
            Case 2
                Dim syName As String = txtb_syS.Text & "-" & txtb_syE.Text
                _dbConnection("db_lccsams")
                _updateData("update tbl_sch_year  set sy_name='" & syName & "',ssy_sDate='" & dp_Start.Text & "',sy_eDate='" & dp_End.Text & "',sem_id='" & cbo_semester.SelectedValue & "' where sy_id ='" & sy_id & "' ")
                _displayRecords(s_msyR, dg_syR)
        End Select
    End Sub

    Private Sub btn_nYearlevel_Click_1(sender As Object, e As EventArgs) Handles btn_nYearlevel.Click
        inputedV = InputBox("Input New Year Level")
        strQuerry5 = "Insert into tbl_year_level values ('0','" & inputedV & "')"
        _dbConnection("db_lccsams")
        _insertData(strQuerry5)
        _loadToListBox(slctYL, lbo_yearL)
    End Sub

    Private Sub btn_ylUpate_Click_1(sender As Object, e As EventArgs) Handles btn_ylUpate.Click
        If MessageBox.Show("Do you want to update this year level? " & vbNewLine & "Name: " & lbo_yearL.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            inputedV = InputBox("Enter a new name ")
            _updateData("Update tbl_year_level  set yl_name='" & inputedV & "' where yl_id='" & lbo_courses.SelectedValue & "'")
            _loadToListBox(slctYL, lbo_yearL)
        End If
    End Sub

    Private Sub btn_updateSchY_Click(sender As Object, e As EventArgs) Handles btn_updateSchY.Click
        If MessageBox.Show("", "Do You want to Update a School Year ?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            txtb_syS.Enabled = True
            txtb_syE.Enabled = True
            btn_save.Enabled = True
        End If
        a = 2
    End Sub

    Private Sub btn_new_Click_1(sender As Object, e As EventArgs) Handles btn_new.Click
        txtb_syS.Enabled = True
        txtb_syE.Enabled = True
        btn_save.Enabled = True
        a = 1
    End Sub
End Class
