Public Class frm_sSG

    Private Sub cbo_SelectDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_SelectDept.SelectedIndexChanged
        ''txtb_Search.Clear()

        'Select Case cbo_SelectDept.SelectedIndex

        '    Case 0
        '        dg_StudScholarRec.Columns(0).DataPropertyName = "stud_id"
        '        dg_StudScholarRec.Columns(1).DataPropertyName = "stud_fname"
        '        dg_StudScholarRec.Columns(2).DataPropertyName = "stud_lname"
        '        dg_StudScholarRec.Columns(3).DataPropertyName = "stud_midI"
        '        Dim coll_studScholar As String = "select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,sl.sl_name  from tbl_student s inner join tbl_coll_scholarlist sl on sl.stud_id=s.stud_id order by stud_lname asc"
        '        _displayRecords(coll_studScholar, dg_StudScholarRec)

        '    Case 1
        '        dg_StudScholarRec.Columns(0).DataPropertyName = "estud_id"
        '        dg_StudScholarRec.Columns(1).DataPropertyName = "estud_fname"
        '        dg_StudScholarRec.Columns(2).DataPropertyName = "estud_lname"
        '        dg_StudScholarRec.Columns(3).DataPropertyName = "estud_mi"
        '        Dim elem_studScholar As String = "select estud_id,estud_fname,estud_lname,estud_mi from tbl_elem_students  order by estud_lname asc"
        '        _displayRecords(elem_studScholar, dg_StudScholarRec)

        '    Case 2
        '        dg_StudScholarRec.Columns(0).DataPropertyName = "sstud_id"
        '        dg_StudScholarRec.Columns(1).DataPropertyName = "sstud_fname"
        '        dg_StudScholarRec.Columns(2).DataPropertyName = "sstud_lname"
        '        dg_StudScholarRec.Columns(3).DataPropertyName = "sstud_mi"
        '        Dim senior_studScholar As String = "select  sstud_id,sstud_fname,sstud_lname,sstud_mi from tbl_seniorhigh_students order by sstud_lname asc"
        '        _displayRecords(senior_studScholar, dg_StudScholarRec)

        '    Case 3
        '        dg_StudScholarRec.Columns(0).DataPropertyName = "jstud_id"
        '        dg_StudScholarRec.Columns(1).DataPropertyName = "jstud_fname"
        '        dg_StudScholarRec.Columns(2).DataPropertyName = "jstud_lname"
        '        dg_StudScholarRec.Columns(3).DataPropertyName = "jstud_mi"
        '        Dim junior_studScholar As String = "select  jstud_id,jstud_fname,jstud_lname,jstud_mi from tbl_juniorhigh_students order by jstud_lname asc"
        '        _displayRecords(junior_studScholar, dg_StudScholarRec)

        'End Select
    End Sub


    Private Sub txtb_Search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_Search.KeyUp

        Select Case cbo_SearchBy.SelectedItem.ToString
            Case "Name"
                Select Case cbo_SelectDept.SelectedIndex
                    Case 0

                        _displayRecords(" select stud_id,stud_fname,stud_lname,stud_midI,sl.sl_name  from tbl_student where stud_Lname Like '%" & txtb_Search.Text & "%' or stud_Fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 1
                        _displayRecords("select estud_id,estud_fname,estud_lname,estud_mi from tbl_elem_students where estud_lname Like '%" & txtb_Search.Text & "%' or estud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 2
                        _displayRecords("select sstud_id,sstud_fname,sstud_lname,sstud_mi from tbl_seniorhigh_students where sstud_lname Like '%" & txtb_Search.Text & "%' or sstud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 3
                        _displayRecords("select jstud_id,jstud_fname,jstud_lname,jstud_mi from tbl_juniorhigh_students where jstud_lname Like '%" & txtb_Search.Text & "%' or jstud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                End Select
            Case "ID Number"
                Select Case cbo_SelectDept.SelectedIndex
                    Case 0

                        _displayRecords(" select stud_id,stud_fname,stud_lname,stud_midI,sl.sl_name  from tbl_student where stud_id Like '" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 1
                        _displayRecords("select estud_id,estud_fname,estud_lname,estud_mi from tbl_elem_students where estud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)
                    Case 2
                        _displayRecords("select sstud_id,sstud_fname,sstud_lname,sstud_mi from tbl_seniorhigh_students where sstud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)
                    Case 3
                        _displayRecords("select jstud_id,jstud_fname,jstud_lname,jstud_mi from tbl_juniorhigh_students where jstud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)
                End Select
        End Select

    End Sub
End Class
