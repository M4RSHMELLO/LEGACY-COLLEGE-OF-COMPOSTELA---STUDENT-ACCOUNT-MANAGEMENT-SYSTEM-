Public Class frm_sSG

    Private Sub cbo_SelectDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_SelectDept.SelectedIndexChanged

        ''txtb_Search.Clear()
        If cbo_SelectDept.SelectedIndex = 0 Then
            dg_StudScholarRec.Columns(0).DataPropertyName = "stud_id"
            dg_StudScholarRec.Columns(1).DataPropertyName = "stud_fname"
            dg_StudScholarRec.Columns(2).DataPropertyName = "stud_lname"
            dg_StudScholarRec.Columns(3).DataPropertyName = "stud_midI"
            dg_StudScholarRec.Columns(4).DataPropertyName = "sl_name"
            dg_StudScholarRec.Columns(5).DataPropertyName = "sy_name"
            dg_StudScholarRec.Columns(6).DataPropertyName = "yl_name"
            lbl_level.Text = "YEAR LEVEL"
            lbl_course.Visible = True
            lbl_sem.Visible = True
            txtb_studCourse.Visible = True
            txtb_studSem.Visible = True
            Dim coll_studScholar As String = "select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,sl.sl_name,sy.sy_name,yl.yl_name  from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id  inner join tbl_coll_scholarlist sl on sl.stud_id=s.stud_id order by stud_lname asc"
            _displayRecords(coll_studScholar, dg_StudScholarRec)

        End If
        If cbo_SelectDept.SelectedIndex = 1 Then

            dg_StudScholarRec.Columns(0).DataPropertyName = "estud_id"
            dg_StudScholarRec.Columns(1).DataPropertyName = "estud_fname"
            dg_StudScholarRec.Columns(2).DataPropertyName = "estud_lname"
            dg_StudScholarRec.Columns(3).DataPropertyName = "estud_mi"
            dg_StudScholarRec.Columns(4).DataPropertyName = "sl_name"
            dg_StudScholarRec.Columns(5).DataPropertyName = "esy_name"
            dg_StudScholarRec.Columns(6).DataPropertyName = "egl_name"
            lbl_level.Text = "GRADE LEVEL"
            lbl_course.Visible = False
            lbl_sem.Visible = False
            txtb_studCourse.Visible = False
            txtb_studSem.Visible = False
            Dim elem_studScholar As String = "select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,sl.sl_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id  inner join tbl_elem_scholarlist sl on sl.stud_id=s.estud_id  order by s.estud_lname asc"
            _displayRecords(elem_studScholar, dg_StudScholarRec)
        End If
        If cbo_SelectDept.SelectedIndex = 2 Then
            dg_StudScholarRec.Columns(0).DataPropertyName = "sstud_id"
            dg_StudScholarRec.Columns(1).DataPropertyName = "sstud_fname"
            dg_StudScholarRec.Columns(2).DataPropertyName = "sstud_lname"
            dg_StudScholarRec.Columns(3).DataPropertyName = "sstud_mi"
            dg_StudScholarRec.Columns(4).DataPropertyName = "sl_name"
            dg_StudScholarRec.Columns(5).DataPropertyName = "ssy_name"
            dg_StudScholarRec.Columns(6).DataPropertyName = "sgl_name"
            lbl_level.Text = "GRADE LEVEL"
            lbl_course.Visible = False
            lbl_sem.Visible = False

            txtb_studCourse.Visible = False
            txtb_studSem.Visible = False
            Dim senior_studScholar As String = "select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,sl.sl_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id inner join tbl_senior_scholarlist sl on sl.stud_id=s.sstud_id  order by s.sstud_lname asc"
            _displayRecords(senior_studScholar, dg_StudScholarRec)

        End If
        If cbo_SelectDept.SelectedIndex = 3 Then
            dg_StudScholarRec.Columns(0).DataPropertyName = "jstud_id"
            dg_StudScholarRec.Columns(1).DataPropertyName = "jstud_fname"
            dg_StudScholarRec.Columns(2).DataPropertyName = "jstud_lname"
            dg_StudScholarRec.Columns(3).DataPropertyName = "jstud_mi"
            dg_StudScholarRec.Columns(4).DataPropertyName = "sl_name"
            dg_StudScholarRec.Columns(5).DataPropertyName = "jsy_name"
            dg_StudScholarRec.Columns(6).DataPropertyName = "jgl_name"
            lbl_level.Text = "GRADE LEVEL"

            txtb_studCourse.Visible = False
            txtb_studSem.Visible = False
            Dim junior_studScholar As String = "select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,sl.sl_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id  inner join tbl_elem_scholarlist sl on sl.stud_id=s.jstud_id  order by s.jstud_lname asc"
            _displayRecords(junior_studScholar, dg_StudScholarRec)
        End If

    End Sub


    Private Sub txtb_Search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_Search.KeyUp

        Select Case cbo_SearchBy.SelectedItem.ToString
            Case "Name"
                Select Case cbo_SelectDept.SelectedIndex
                    Case 0

                        _displayRecords("select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,sl.sl_name,sy.sy_name,yl.yl_name from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id left join tbl_coll_scholarlist sl on sl.stud_id=s.stud_id where stud_Lname Like '%" & txtb_Search.Text & "%' or stud_Fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 1
                        _displayRecords("select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,sl.sl_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id    left join tbl_elem_scholarlist sl on sl.stud_id=estud_id where estud_lname Like '%" & txtb_Search.Text & "%' or estud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 2
                        _displayRecords("select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,sl.sl_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  left join tbl_senior_scholarlist sl on sl.stud_id=sstud_id where sstud_lname Like '%" & txtb_Search.Text & "%' or sstud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 3
                        _displayRecords("select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,sl.sl_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id  left join tbl_junior_scholarlist sl on sl.stud_id=jstud_id  where jstud_lname Like '%" & txtb_Search.Text & "%' or jstud_fname  Like '%" & txtb_Search.Text & "%' ", dg_StudScholarRec)


                End Select
            Case "ID Number"
                Select Case cbo_SelectDept.SelectedIndex
                    Case 0

                        _displayRecords(" select s.stud_id,s.stud_fname,s.stud_lname,s.stud_midI,sl.sl_name,sy.sy_name,yl.yl_name from tbl_student s  inner join tbl_sch_year sy  on s.sy_id=sy.sy_id inner join tbl_year_level yl on s.yl_id=yl.yl_id  left join tbl_coll_scholarlist sl on sl.stud_id=stud_id  where stud_id Like '" & txtb_Search.Text & "%' ", dg_StudScholarRec)
                    Case 1
                        _displayRecords("select s.estud_id,s.estud_fname,s.estud_lname,s.estud_mi,sl.sl_name ,sy.esy_name,gl.egl_name from tbl_elem_students  s inner join tbl_elem_sy sy  on sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on  s.egl_id=gl.egl_id    left join tbl_elem_scholarlist sl on sl.stud_id=estud_id where estud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)
                    Case 2
                        _displayRecords("select  s.sstud_id,s.sstud_fname,s.sstud_lname,s.sstud_mi,sl.sl_name,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students  s inner join tbl_seniorhigh_sy sy  on s.ssy_id=sy.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  left join tbl_senior_scholarlist sl on sl.stud_id=sstud_id where sstud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)
                    Case 3
                        _displayRecords("select  s.jstud_id,s.jstud_fname,s.jstud_lname,s.jstud_mi,sl.sl_name,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy  on s.jsy_id=sy.jsy_id inner join tbl_juniorhigh_gradelevel gl on s.jgl_id=gl.jgl_id   left join tbl_junior_scholarlist sl on sl.stud_id=s.jstud_id where jstud_id='" & txtb_Search.Text & "' ", dg_StudScholarRec)

                End Select
            Case False
                MessageBox.Show("")
        End Select

    End Sub

    Private Sub frm_sSG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_SearchBy.SelectedIndex = 1
    End Sub

    Private Sub dg_StudScholarRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_StudScholarRec.CellClick
        Try
            Dim i = e.RowIndex
            With dg_StudScholarRec

                Dim Course As String = "Select c.crs_name from tbl_coll_course  c inner join tbl_student sc on sc.crs_id=c.crs_id  where sc.stud_id='" & .Item(0, i).Value & "'"
                Dim Semester As String = "Select sm.sem_name from tbl_semester sm inner join tbl_student s on s.sem_id=sm.sem_id where s.stud_id='" & .Item(0, i).Value & "'"
                Dim coll_sl As String = "Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_student s on sl.stud_id=s.stud_id where s.stud_id='" & .Item(0, i).Value & "'"
                Dim elem_sl As String = "Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_elem_students s on sl.stud_id=s.estud_id where s.estud_id='" & .Item(0, i).Value & "'"
                Dim senior_sl As String = "Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_seniorhigh_students s on sl.stud_id=s.sstud_id where s.sstud_id='" & .Item(0, i).Value & "'"
                Dim junior_sl As String = "Select sl.sl_amnt,sl.sl_status  from  tbl_coll_scholarlist sl inner join tbl_student s on sl.stud_id=s.jstud_id where s.jstud_id='" & .Item(0, i).Value & "'"


                _dbConnection("db_lccsams")
                txtb_studid.Text = .Item(0, i).Value.ToString
                txtb_studFname.Text = .Item(1, i).Value.ToString
                txtb_studLname.Text = .Item(2, i).Value.ToString
                txtb_studMI.Text = .Item(3, i).Value.ToString
                txtb_ScholarType.Text = .Item(4, i).Value.ToString
                txtb_SY.Text = .Item(5, i).Value.ToString
                txtb_studLevel.Text = .Item(6, i).Value.ToString
                _loadToTextbox(Course, txtb_studCourse)
                _loadToTextbox(Semester, txtb_studSem)

                If cbo_SelectDept.SelectedIndex = 0 Then
                    Try
                        dbConn.Open()
                        sqlCommand = New MySqlCommand(coll_sl, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()

                            txtb_ScholarAmnt.Text = dr(0)
                            If dr(1) = 1 Then
                                rb_active.Checked = True
                            End If
                            If dr(1) = 0 Then
                                rb_inactive.Checked = True
                            End If

                        End While
                    Catch ex As Exception
                        erromessage("error 108: loadToTextbox " & ex.Message)
                    Finally
                        dbConn.Close()
                    End Try
                End If
                If cbo_SelectDept.SelectedIndex = 1 Then
                    Try
                        dbConn.Open()
                        sqlCommand = New MySqlCommand(elem_sl, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()

                            txtb_ScholarAmnt.Text = dr(0)
                            If dr(1) = 1 Then
                                rb_active.Checked = True
                            End If
                            If dr(1) = 0 Then
                                rb_inactive.Checked = True
                            End If

                        End While
                    Catch ex As Exception
                        erromessage("error 108: loadToTextbox " & ex.Message)
                    Finally
                        dbConn.Close()
                    End Try
                End If
                If cbo_SelectDept.SelectedIndex = 2 Then
                    Try
                        dbConn.Open()
                        sqlCommand = New MySqlCommand(senior_sl, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()

                            txtb_ScholarAmnt.Text = dr(0)
                            If dr(1) = 1 Then
                                rb_active.Checked = True
                            End If
                            If dr(1) = 0 Then
                                rb_inactive.Checked = True
                            End If

                        End While
                    Catch ex As Exception
                        erromessage("error 108: loadToTextbox " & ex.Message)
                    Finally
                        dbConn.Close()
                    End Try
                End If
                If cbo_SelectDept.SelectedIndex = 3 Then
                    Try
                        dbConn.Open()
                        sqlCommand = New MySqlCommand(junior_sl, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()

                            txtb_ScholarAmnt.Text = dr(0)
                            If dr(1) = 1 Then
                                rb_active.Checked = True
                            End If
                            If dr(1) = 0 Then
                                rb_inactive.Checked = True
                            End If

                        End While
                    Catch ex As Exception
                        erromessage("error 108: loadToTextbox " & ex.Message)
                    Finally
                        dbConn.Close()
                    End Try
                End If




            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

    End Sub
End Class
