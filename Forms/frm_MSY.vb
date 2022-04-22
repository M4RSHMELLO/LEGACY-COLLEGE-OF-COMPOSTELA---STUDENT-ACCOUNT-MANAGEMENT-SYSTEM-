Public Class frm_MSY
    Dim inputedV As String
    Dim strQuery3 As String
    Dim strQuerry5 As String
    Dim a As Integer = 0
    Dim sy_id As Integer
    Private Sub frm_MYear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctS, cbo_semester)
        _loadToListBox(slctC, lbo_courses)
        _loadToListBox(slctYL, lbo_yearL)
        _displayRecords(s_msyR, dg_syR)

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                _dbConnection("db_lccsams")
                _loadToCombobox(slctS, cbo_semester)
                _loadToListBox(slctC, lbo_courses)
                _loadToListBox(slctYL, lbo_yearL)
                _displayRecords(s_msyR, dg_syR)
            Case 1

        End Select

    End Sub

    Private Sub btn_nCourse_Click(sender As Object, e As EventArgs) Handles btn_nCourse.Click
        inputedV = InputBox("Input New Course")
        strQuery3 = "Insert into tbl_coll_course values ('0','" & inputedV & "')"
        _dbConnection("db_lccsams")
        _insertData(strQuery3)
        _loadToListBox(slctC, lbo_courses)

    End Sub


    Private Sub dg_syR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_syR.CellClick
        Dim i = e.RowIndex
        With dg_syR
            sy_id = .Item("col_sy_id", i).Value
        End With
    End Sub

    Private Sub btn_Ucourse_Click(sender As Object, e As EventArgs) Handles btn_Ucourse.Click
        If MessageBox.Show("Do you want to update this course? " & vbNewLine & "Name: " & lbo_courses.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            inputedV = InputBox("Enter a new name ")
            _updateData("Update tbl_course set crs_name='" & inputedV & "' where crs_id='" & lbo_courses.SelectedValue & "'")

            _loadToListBox(slctC, lbo_courses)
        End If
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

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        txtb_syS.Enabled = True
        txtb_syE.Enabled = True
        btn_save.Enabled = True
        a = 1
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Select Case a
            Case 1
                Dim syN As String = txtb_syS.Text & "-" & txtb_syE.Text
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
    ''###########################################################Elementary Section ################################################################################
    Dim b As Integer = 0
    Dim esy_id As Integer
    Dim egl_name As String

    Private Sub btn_esy_New_Click(sender As Object, e As EventArgs) Handles btn_esy_New.Click
        txtb_esy_start.Enabled = True
        txtb_esy_end.Enabled = True
        btn_esy_save.Enabled = True
        b = 1
    End Sub

    Private Sub btn_esy_update_Click(sender As Object, e As EventArgs) Handles btn_esy_update.Click
        If MessageBox.Show("", "Do You want to Update a School Year ?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            txtb_esy_start.Enabled = True
            txtb_esy_end.Enabled = True
            btn_esy_save.Enabled = True
        End If
        b = 2
    End Sub

    Private Sub btn_esy_save_Click(sender As Object, e As EventArgs) Handles btn_esy_save.Click
        Select Case b
            Case 1
                Dim esyN As String = txtb_esy_start.Text & "-" & txtb_esy_end.Text
                Dim strQueery6 As String = "Insert Into tbl_elem_sy values(0,'" & esyN & "','" & dp_esy_startDate.Text & "','" & dp_esy_endDate.Text & "')"
                _dbConnection("db_lccsams")
                _insertData(strQueery6)
                _displayRecords(eSelect_SY, dg_esyRec)
            Case 2
                Dim esyName As String = txtb_esy_start.Text & "-" & txtb_esy_end.Text
                _dbConnection("db_lccsams")
                _updateData("update tbl_elem_sy  set esy_name='" & esyName & "',esy_sdate='" & dp_Start.Text & "',esy_edate='" & dp_End.Text & "' where esy_id ='" & esy_id & "' ")
                _displayRecords(eSelect_SY, dg_esyRec)
        End Select
    End Sub

    Private Sub btn_egl_new_Click(sender As Object, e As EventArgs) Handles btn_egl_new.Click
        egl_name = InputBox("Input New Year Level")
        strQuerry5 = "Insert into tbl_elem_gradelevel values ('0','" & egl_name & "')"
        _dbConnection("db_lccsams")
        _insertData(strQuerry5)
        _loadToListBox(eSelect_GL, lbo_eglRec)

    End Sub

    Private Sub btn_egl_update_Click(sender As Object, e As EventArgs) Handles btn_egl_update.Click
        If MessageBox.Show("Do you want to update this year level? " & vbNewLine & "Name: " & lbo_eglRec.Text, "", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            egl_name = InputBox("Enter a new name ")
            _updateData("Update tbl_elem_gradelevel  set esy_eglname='" & egl_name & "' where egl_id='" & lbo_eglRec.SelectedValue & "'")
            _loadToListBox(eSelect_GL, lbo_eglRec)
        End If
    End Sub

    Private Sub dg_esyRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_esyRec.CellClick
        Dim i = e.RowIndex
        With dg_esyRec
            esy_id = .Item(0, i).Value
        End With
    End Sub


End Class
