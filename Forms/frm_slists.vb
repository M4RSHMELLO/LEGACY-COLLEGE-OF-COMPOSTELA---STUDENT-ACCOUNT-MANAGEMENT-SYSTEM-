
Public Class frm_slists
    Dim sAccount As New frm_SAccounts
    Sub random()

        'Create an instance of the Random class
        Dim rnd As New Random()

        'Get a random number from 10 to 99  (2 digits)
        randomNumber = rnd.Next(10, 100000)
    End Sub

    Dim randomNumber As Integer

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim SelecteDepartment As Integer = TabControl1.SelectedIndex
        Select Case SelecteDepartment
            Case 0
                txtb_studId.Clear()
                txtb_studFname.Clear()
                txtb_studLname.Clear()
                txtb_studMI.Clear()
                txtb_RpU.Clear()
                txtb_noUnits.Clear()
                txtb_Search.Clear()
                cbo_SearchBy.SelectedIndex = 1
                cbo_schyear.SelectedIndex = -1
                cbo_sem.SelectedIndex = -1
                cbo_yearlevel.SelectedIndex = -1
                cbo_course.SelectedIndex = -1
                cbo_studType.SelectedIndex = -1
                _dbConnection("db_lccsams")
                _displayRecords(sStudR, dg_studR)
                cbo_SearchBy.SelectedIndex = 1

            Case 1
                _dbConnection("db_lccsams")
                _loadToCombobox(eSelect_SY, cbo_eSYName)
                _loadToCombobox(eSelect_GL, cbo_eGradeLevel)
                cbo_eSearchBY.SelectedIndex = 1
                txtb_eStudID.Clear()
                txtb_eStudFname.Clear()
                txtb_estudLname.Clear()
                txtb_estudMI.Clear()
                cbo_eSYName.SelectedIndex = -1
                cbo_eGradeLevel.SelectedIndex = -1
                _displayRecords(eSelect_studRec, dg_eStudRecords)
                cbo_eSearchBY.SelectedIndex = 1

            Case 2
                _dbConnection("db_lccsams")
                _loadToCombobox(sSelect_SY, cbo_sSY)
                _loadToCombobox(sSelect_GL, cbo_sGL)
                cbo_sSearchBy.SelectedIndex = 1
                txtb_sFname.Clear()
                txtb_sLname.Clear()
                txtb_smi.Clear()
                cbo_sSY.SelectedIndex = -1
                cbo_sGL.SelectedIndex = -1
                _displayRecords(sSelect_studRec, dg_sStudRec)

            Case 3
                _loadToCombobox(jSelect_SY, cbo_jSY)
                _loadToCombobox(jSelect_GL, cbo_jGL)
                cbo_jSearchBy.SelectedIndex = 1
                txtb_jStudFname.Clear()
                txtb_jStudLname.Clear()
                txtb_jStudMI.Clear()
                cbo_jSY.SelectedIndex = -1
                cbo_jGL.SelectedIndex = -1
                _dbConnection("db_lccsams")
                _displayRecords(jSelect_studRec, dg_jStudRec)





        End Select
    End Sub
    '######################################################College Dept Section#####################################################################
    Private Sub btn_addNstud_Click(sender As Object, e As EventArgs) Handles btn_addNstud.Click

        If dlg_addstudents.ShowDialog = DialogResult.Yes Then
            txtb_studFname.Enabled = True
            txtb_studLname.Enabled = True
            txtb_studMI.Enabled = True
            txtb_noUnits.Enabled = True
            cbo_schyear.Enabled = True
            cbo_yearlevel.Enabled = True
            cbo_sem.Enabled = True
            cbo_course.Enabled = True
            cbo_studType.Enabled = True
            dg_studR.Enabled = False
            btn_gotoAcct.Enabled = False
            btn_cancel.Enabled = True

            'clear selection
            txtb_studFname.Clear()
            txtb_studLname.Clear()
            txtb_studMI.Clear()
            cbo_yearlevel.SelectedIndex = -1
            cbo_sem.SelectedIndex = -1
            cbo_course.SelectedIndex = -1
            txtb_noUnits.Clear()
            txtb_RpU.Clear()

            random()
            txtb_studId.Text = randomNumber
            btn_save.Enabled = True
            btn_addNstud.Enabled = False
            btn_updtStud.Enabled = False
            a = 1
        End If
    End Sub
    Dim a As Integer
    Sub _insertdataOfStudents()
        Try
            _dbConnection("db_lccsams")
            Dim sql As String = "select stud_id from tbl_student where stud_Fname='" & txtb_studFname.Text & "' and stud_Lname='" & txtb_studLname.Text & "' "
            Dim querry2 = "insert into tbl_studnounits values ('" & randomNumber & "','" & txtb_noUnits.Text & "','" & txtb_RpU.Text & "','" & cbo_schyear.SelectedValue & "','" & cbo_sem.SelectedValue & "','" & cbo_yearlevel.SelectedValue & "','" & cbo_course.SelectedValue & "')"
            dbConn.Open()
            sqlCommand = New MySqlCommand(sql, dbConn)
            dr = sqlCommand.ExecuteReader
            If dr.HasRows Then
                MessageBox.Show("This data already Exist!")
            Else
                Dim stype As Integer
                dbConn.Close()
                If cbo_yearlevel.SelectedValue = 1 Then
                    stype = 1
                ElseIf cbo_yearlevel.SelectedValue > 1 Then

                End If
                Dim querry1 = "insert into tbl_student (stud_id,stud_Fname,stud_Lname,stud_midI,crs_id,sem_id,yl_id,sy_id,educ_level,stype_id) values('" & randomNumber & "','" & txtb_studFname.Text & "','" & txtb_studLname.Text & "','" & txtb_studMI.Text & "','" & cbo_course.SelectedValue & "','" & cbo_sem.SelectedValue & "','" & cbo_yearlevel.SelectedValue & "','" & cbo_schyear.SelectedValue & "','" & 0 & "','" & cbo_studType.SelectedValue & "')"
                _insertData(querry1)
                _insertData(querry2)
            End If
        Catch ex As Exception
            MessageBox.Show("Error: ", ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txtb_studFname.Text = "" Or txtb_studLname.Text = "" Or cbo_course.Text = "" Or cbo_yearlevel.Text = "" Or cbo_sem.Text = "" Then
            dlg_fillup.ShowDialog()
        Else
            txtb_studFname.Enabled = False
            txtb_studLname.Enabled = False
            txtb_studMI.Enabled = False
            cbo_schyear.Enabled = False
            cbo_yearlevel.Enabled = False
            cbo_sem.Enabled = False
            cbo_course.Enabled = False
            txtb_noUnits.Enabled = False
            btn_cancel.Enabled = False
            cbo_studType.Enabled = False
            Select Case a
                Case 1
                    _insertdataOfStudents()
                    dlg_savesuccessfully.ShowDialog()
                    _displayRecords(sStudR, dg_studR)
                    _loadToCombobox(slctC, cbo_course)
                    _loadToCombobox(slctS, cbo_sem)
                    _loadToCombobox(slctYL, cbo_yearlevel)
                    _loadToCombobox(slctSY, cbo_schyear)

                    btn_save.Enabled = False
                    btn_addNstud.Enabled = True
                    btn_updtStud.Enabled = True
                    dg_studR.Enabled = True
                    btn_gotoAcct.Enabled = True

                Case 2
                    Dim querry3 = "update tbl_student set stud_Fname='" & txtb_studFname.Text & "',stud_Lname='" & txtb_studLname.Text & "',stud_midI='" & txtb_studMI.Text & "',crs_id='" & cbo_course.SelectedValue & "',sem_id='" & cbo_sem.SelectedValue & "',yl_id='" & cbo_yearlevel.SelectedValue & "',sy_id='" & cbo_schyear.SelectedValue & "' where stud_id='" & stud_id & "' "
                    Dim querry4 = "update tbl_studnounits set st_noUnits='" & txtb_noUnits.Text & "',st_rateperunit='" & txtb_RpU.Text & "',crs_id='" & cbo_course.SelectedValue & "',sem_id='" & cbo_sem.SelectedValue & "',yl_id='" & cbo_yearlevel.SelectedValue & "',sy_id='" & cbo_schyear.SelectedValue & "'  where stud_id='" & stud_id & "' "
                    _dbConnection("db_lccsams")

                    _updateData(querry3)
                    _updateData(querry4)
                    UpdatedSuccessfully.ShowDialog()
                    _displayRecords(sStudR, dg_studR)
                    btn_updtStud.Enabled = True
                    btn_save.Enabled = False
                    btn_addNstud.Enabled = True
                    dg_studR.Enabled = True
                    btn_gotoAcct.Enabled = True
            End Select


        End If


    End Sub

    Private Sub btn_updtStud_Click(sender As Object, e As EventArgs) Handles btn_updtStud.Click
        If dlg_updatestudents.ShowDialog = DialogResult.Yes Then
            txtb_studFname.Enabled = True
            txtb_studLname.Enabled = True
            txtb_studMI.Enabled = True
            txtb_noUnits.Enabled = True
            cbo_schyear.Enabled = True
            cbo_yearlevel.Enabled = True
            cbo_sem.Enabled = True
            cbo_course.Enabled = True
            btn_updtStud.Enabled = False
            btn_save.Enabled = True
            btn_addNstud.Enabled = False
            dg_studR.Enabled = False
            btn_gotoAcct.Enabled = False
            btn_cancel.Enabled = True
            a = 2


            cbo_course.Text = ""
            cbo_yearlevel.Text = ""
            cbo_sem.Text = ""
            cbo_schyear.Text = ""
            txtb_noUnits.Clear()
            txtb_RpU.Clear()
        End If

    End Sub

    Private Sub btn_enter_Click(sender As Object, e As EventArgs)
        'Dim querry1 = "select "
        '_dbConnection("db_lccsams")
        '_displayRecords(querry1, dg_studR)
    End Sub

    Private Sub dg_studR_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_studR.CellClick
        Try
            Dim i = e.RowIndex
            With dg_studR
                If .Item("yl_id", i).Value = 1 Then

                End If
                stud_id = .Item("s_id", i).Value
                stud_name = .Item("s_fName", i).Value.ToString.ToUpper + " " + .Item("s_Midi", i).Value.ToString.ToUpper + " " + .Item("s_lName", i).Value.ToString.ToUpper

                txtb_studId.Text = .Item("s_id", i).Value
                Dim querry As String = "Select c.crs_name from tbl_student s inner join tbl_coll_course c on s.crs_id=c.crs_id where s.stud_id = '" & txtb_studId.Text & "'"
                Dim querry2 As String = "Select y.yl_name from tbl_student s inner join tbl_year_level y on s.yl_id=y.yl_id where s.stud_id = '" & txtb_studId.Text & "'"
                Dim querry3 As String = "Select sem.sem_name from tbl_student s inner join tbl_semester sem  on s.sem_id=sem.sem_id where s.stud_id = '" & txtb_studId.Text & "'"
                Dim querry4 As String = "Select sy.sy_name from tbl_student s inner join tbl_sch_year sy  on s.sy_id=sy.sy_id where s.stud_id = '" & txtb_studId.Text & "' group by sy_name having count(*) > 0"
                Dim querry6 As String = "select  st_rateperunit  from tbl_studnounits where stud_id = '" & stud_id & "' and sy_id='" & .Item("sy_id", i).Value & "' and sem_id='" & .Item("sem_id", i).Value & "' and yl_id='" & .Item("yl_id", i).Value & "' and  crs_id='" & .Item("crs_id", i).Value & "'"
                Dim querry5 As String = "select  st_noUnits from tbl_studnounits where stud_id ='" & stud_id & "' and sy_id='" & .Item("sy_id", i).Value & "' and sem_id='" & .Item("sem_id", i).Value & "' and yl_id='" & .Item("yl_id", i).Value & "' and  crs_id='" & .Item("crs_id", i).Value & "'"
                Dim querry7 As String = "select  st.stype_name from tbl_student_type st inner join tbl_student s on st.stype_id=s.stype_id  where s.stud_id ='" & stud_id & "'"
                _dbConnection("db_lccsams")
                txtb_studFname.Text = .Item("s_fName", i).Value
                txtb_studLname.Text = .Item("s_lName", i).Value
                txtb_studMI.Text = .Item("s_Midi", i).Value

                txtb_noUnits.Clear()
                txtb_RpU.Clear()
                _loadToTextbox(querry5, txtb_noUnits)
                _loadToTextbox(querry6, txtb_RpU)

                _selectComboBoxText(querry, cbo_course)
                _selectComboBoxText(querry2, cbo_yearlevel)
                _selectComboBoxText(querry3, cbo_sem)
                _selectComboBoxText(querry4, cbo_schyear)
                _selectComboBoxText(querry7, cbo_studType)

                stud_sy = cbo_schyear.Text
                stud_sem = cbo_sem.Text
                stud_yl = cbo_yearlevel.Text
                stud_crs = cbo_course.Text
                stud_nUnits = txtb_noUnits.Text
                stud_rpu = txtb_RpU.Text

                sy_fid = .Item("sy_id", i).Value

            End With
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub txtb_Search_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_Search.KeyUp
        Select Case cbo_SearchBy.SelectedItem.ToString
            Case "Name"
                _dbConnection("db_lccsams")
                _displayRecords(sStudR + " where stud_Lname Like '%" & txtb_Search.Text & "%' or stud_Fname  Like '%" & txtb_Search.Text & "%' ", dg_studR)

            Case "ID Number"
                _dbConnection("db_lccsams")
                _displayRecords(sStudR + " where stud_id Like '" & txtb_Search.Text & "%' ", dg_studR)
        End Select
    End Sub
    Private Sub btn_gotoAcct_Click(sender As Object, e As EventArgs) Handles btn_gotoAcct.Click
        Try
            If txtb_studId.Text = "" Then
                MessageBox.Show("Please select student first")
            Else
                current_menu = 2
                Dashboard.btn_menuStudentsAccount_click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Dim rpu_id As Integer = 1
    Private Sub cbo_course_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_course.SelectionChangeCommitted
        txtb_RpU.Clear()
        Dim querry2 As String = "Select fees_amount from tbl_coll_fees where sy_id='" & cbo_schyear.SelectedValue & "' and sem_id='" & cbo_sem.SelectedValue & "' and yl_id='" & cbo_yearlevel.SelectedValue & "' and  crs_id='" & cbo_course.SelectedValue & "' and tuition_rpu_id='" & rpu_id & "'"
        If cbo_sem.Text <> "" Then
            _dbConnection("db_lccsams")
            txtb_RpU.Clear()
            _loadToTextbox(querry2, txtb_RpU)
        End If

    End Sub

    Private Sub cbo_yearlevel_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_yearlevel.SelectionChangeCommitted
        cbo_sem.SelectedIndex = -1
        cbo_course.SelectedIndex = -1
    End Sub

    Private Sub cbo_sem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_sem.SelectionChangeCommitted
        cbo_course.SelectedIndex = -1
    End Sub
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        'disabled
        txtb_studFname.Enabled = False
        txtb_studLname.Enabled = False
        txtb_studMI.Enabled = False
        cbo_schyear.Enabled = False
        cbo_yearlevel.Enabled = False
        cbo_sem.Enabled = False
        cbo_course.Enabled = False
        txtb_noUnits.Enabled = False
        'clear selection
        txtb_studFname.Clear()
        txtb_studLname.Clear()
        txtb_studMI.Clear()
        cbo_schyear.SelectedIndex = -1
        cbo_yearlevel.SelectedIndex = -1
        cbo_course.SelectedIndex = -1
        cbo_sem.SelectedIndex = -1

        txtb_noUnits.Clear()
        txtb_RpU.Clear()
        txtb_studId.Clear()

        btn_save.Enabled = False
        btn_addNstud.Enabled = True
        btn_updtStud.Enabled = True
        dg_studR.Enabled = True
        btn_gotoAcct.Enabled = True
        btn_cancel.Enabled = False
    End Sub




    Private Sub frm_slists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctC, cbo_course)
        _loadToCombobox(slctS, cbo_sem)
        _loadToCombobox(slctYL, cbo_yearlevel)
        _displayRecords(sStudR, dg_studR)
        _loadToCombobox(slctSY, cbo_schyear)
        _loadToCombobox(student_type, cbo_studType)
        cbo_SearchBy.SelectedIndex = 1
        cbo_schyear.SelectedIndex = -1
        cbo_sem.SelectedIndex = -1
        cbo_yearlevel.SelectedIndex = -1
        cbo_course.SelectedIndex = -1

    End Sub


    ''###########################################################Elementary Section ################################################################################
    Dim b As Integer
    Private Sub txtb_eSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_eSearch.KeyUp
        Select Case cbo_SearchBy.SelectedItem.ToString
            Case "Name"
                _dbConnection("db_lccsams")
                _displayRecords(" select * from tbl_elem_students where estud_fname Like '%" & txtb_eSearch.Text & "%' or estud_lname  Like '%" & txtb_eSearch.Text & "%' ", dg_eStudRecords)

            Case "ID Number"
                _dbConnection("db_lccsams")
                _displayRecords("select * from tbl_elem_students where estud_id Like '" & txtb_eSearch.Text & "%' ", dg_eStudRecords)
        End Select
    End Sub


    Private Sub btn_eViewAccount_Click(sender As Object, e As EventArgs) Handles btn_eViewAccount.Click
        Try
            If txtb_eStudID.Text = "" Then
                MessageBox.Show("please select a student before you proceed")
            Else
                current_menu = 2
                Dashboard.btn_menuStudentsAccount_click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_eSave_Click(sender As Object, e As EventArgs) Handles btn_eSave.Click
        If txtb_eStudFname.Text = "" Or txtb_eStudFname.Text = "" Or cbo_eGradeLevel.Text = "" Or cbo_eSYName.Text = "" Then
            dlg_fillup.ShowDialog()
        Else
            txtb_eStudFname.Enabled = False
            txtb_eStudFname.Enabled = False
            txtb_estudMI.Enabled = False
            cbo_eGradeLevel.Enabled = False
            cbo_eSYName.Enabled = False
            btn_eSave.Enabled = False
            btn_eViewAccount.Enabled = True
            btn_eAddNewStud.Enabled = True
            btn_eUpdateNewStud.Enabled = True
            dg_eStudRecords.Enabled = True

            Select Case b
                Case 1
                    Dim insertStudData = "Insert into tbl_elem_students values ('" & txtb_eStudID.Text & "','" & txtb_eStudFname.Text & "','" & txtb_estudLname.Text & "','" & txtb_estudMI.Text & "','" & cbo_eSYName.SelectedValue & "','" & cbo_eGradeLevel.SelectedValue & "')"
                    _dbConnection("db_lccsams")
                    _insertData(insertStudData)
                    dlg_savesuccessfully.ShowDialog()
                    _displayRecords(eSelect_studRec, dg_eStudRecords)
                Case 2
                    Dim querry2 = "update tbl_elem_students set estud_fname='" & txtb_eStudFname.Text & "',estud_lname='" & txtb_estudLname.Text & "',estud_mi='" & txtb_estudMI.Text & "',esy_id='" & cbo_eSYName.SelectedValue & "',egl_id='" & cbo_eGradeLevel.SelectedValue & "' where estud_id='" & txtb_eStudID.Text & "' "
                    _dbConnection("db_lccsams")
                    _updateData(querry2)
                    _displayRecords(eSelect_studRec, dg_eStudRecords)
                    UpdatedSuccessfully.ShowDialog()
            End Select
        End If

    End Sub

    Private Sub btn_eAddNewStud_Click(sender As Object, e As EventArgs) Handles btn_eAddNewStud.Click
        If dlg_addstudents.ShowDialog = DialogResult.Yes Then
            txtb_eStudFname.Enabled = True
            txtb_estudLname.Enabled = True
            txtb_estudMI.Enabled = True

            cbo_eSYName.Enabled = True
            cbo_eGradeLevel.Enabled = True
            dg_eStudRecords.Enabled = False


            'clear selection
            txtb_eStudFname.Clear()
            txtb_estudLname.Clear()
            txtb_estudMI.Clear()
            cbo_eSYName.SelectedIndex = -1
            cbo_eGradeLevel.SelectedIndex = -1
            random()
            txtb_eStudID.Text = randomNumber

            btn_eAddNewStud.Enabled = False
            btn_eCancel.Enabled = True
            btn_eSave.Enabled = True
            btn_eUpdateNewStud.Enabled = False
            b = 1
        End If

    End Sub

    Private Sub btn_eUpdateNewStud_Click(sender As Object, e As EventArgs) Handles btn_eUpdateNewStud.Click
        If dlg_updatestudents.ShowDialog = DialogResult.Yes Then
            txtb_eStudFname.Enabled = True
            txtb_estudLname.Enabled = True
            txtb_estudMI.Enabled = True
            cbo_eSYName.Enabled = True
            cbo_eGradeLevel.Enabled = True
            dg_eStudRecords.Enabled = False

            btn_eUpdateNewStud.Enabled = False
            btn_eSave.Enabled = True
            btn_eAddNewStud.Enabled = False
            dg_eStudRecords.Enabled = False
            btn_eViewAccount.Enabled = False
            btn_eCancel.Enabled = True
            b = 2
        End If

    End Sub

    Private Sub btn_eCancel_Click(sender As Object, e As EventArgs) Handles btn_eCancel.Click
        'disabled
        txtb_eStudFname.Enabled = False
        txtb_estudLname.Enabled = False
        txtb_estudMI.Enabled = False
        cbo_eGradeLevel.Enabled = False
        cbo_eSYName.Enabled = False
        'clear selection
        txtb_eStudFname.Clear()
        txtb_estudLname.Clear()
        txtb_estudMI.Clear()
        cbo_eGradeLevel.SelectedIndex = -1
        cbo_eSYName.SelectedIndex = -1

        btn_eSave.Enabled = False
        btn_eAddNewStud.Enabled = True
        btn_eUpdateNewStud.Enabled = True
        dg_eStudRecords.Enabled = True
        btn_eViewAccount.Enabled = True
        btn_eCancel.Enabled = False
    End Sub

    Private Sub dg_eStudRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_eStudRecords.CellClick
        Try
            Dim i = e.RowIndex
            With dg_eStudRecords

                Dim querry As String = "Select esy_name from tbl_elem_sy where esy_id='" & .Item(4, i).Value & "'"
                Dim querry2 As String = "Select egl_name from tbl_elem_gradelevel where egl_id='" & .Item(5, i).Value & "'"
                _dbConnection("db_lccsams")
                eStud_id = .Item(0, i).Value
                eStudname = .Item(1, i).Value.ToString.ToUpper + " " + .Item(2, i).Value.ToString.ToUpper + " " + .Item(3, i).Value.ToString.ToUpper
                eStudSY = _selectComboBoxText(querry, cbo_eSYName)
                eStudGL = _selectComboBoxText(querry2, cbo_eGradeLevel)

                txtb_eStudID.Text = .Item("col_estud_id", i).Value
                txtb_eStudFname.Text = .Item("col_estud_fname", i).Value.ToString.ToUpper
                txtb_estudLname.Text = .Item("col_estud_lname", i).Value.ToString.ToUpper
                txtb_estudMI.Text = .Item("col_estud_mi", i).Value.ToString.ToUpper




            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    '#############################################################Senior-High depatment Section#########################################################
    Dim C As Integer = 0
    Private Sub txtb_sSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_sSearch.KeyUp
        Select Case cbo_SearchBy.SelectedItem.ToString
            Case "Name"
                _dbConnection("db_lccsams")
                _displayRecords(" select * from tbl_seniorhigh_students where sstud_fname Like '%" & txtb_sSearch.Text & "%' or sstud_lname  Like '%" & txtb_sSearch.Text & "%' ", dg_sStudRec)

            Case "ID Number"
                _dbConnection("db_lccsams")
                _displayRecords("select * from tbl_seniorhigh_students where sstud_id Like '" & txtb_sSearch.Text & "%' ", dg_sStudRec)
        End Select
    End Sub

    Private Sub btn_sViewAccount_Click(sender As Object, e As EventArgs) Handles btn_sViewAccount.Click
        Try
            If txtb_sStud_id.Text = "" Then
                MessageBox.Show("Select a student first")
            Else
                current_menu = 2
                Dashboard.btn_menuStudentsAccount_click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_sAddStud_Click(sender As Object, e As EventArgs) Handles btn_sAddStud.Click
        If dlg_addstudents.ShowDialog = DialogResult.Yes Then
            txtb_sFname.Enabled = True
            txtb_sLname.Enabled = True
            txtb_smi.Enabled = True

            cbo_sSY.Enabled = True
            cbo_sGL.Enabled = True
            dg_sStudRec.Enabled = False


            'clear selection
            txtb_sFname.Clear()
            txtb_sLname.Clear()
            txtb_smi.Clear()
            cbo_sSY.SelectedIndex = -1
            cbo_sGL.SelectedIndex = -1
            random()
            txtb_sStud_id.Text = randomNumber

            btn_sAddStud.Enabled = False
            btn_sCancel.Enabled = True
            btn_sSave.Enabled = True
            btn_sUpdateStud.Enabled = False
            C = 1
        End If

    End Sub

    Private Sub btn_sUpdateStud_Click(sender As Object, e As EventArgs) Handles btn_sUpdateStud.Click
        If dlg_updatestudents.ShowDialog = DialogResult.Yes Then
            txtb_sFname.Enabled = True
            txtb_sLname.Enabled = True
            txtb_smi.Enabled = True
            cbo_sSY.Enabled = True
            cbo_sGL.Enabled = True
            dg_sStudRec.Enabled = False

            btn_sUpdateStud.Enabled = False
            btn_sSave.Enabled = True
            btn_sAddStud.Enabled = False
            dg_sStudRec.Enabled = False
            btn_sViewAccount.Enabled = False
            btn_sCancel.Enabled = True
            C = 2
        End If
    End Sub

    Private Sub btn_sSave_Click(sender As Object, e As EventArgs) Handles btn_sSave.Click
        If txtb_sFname.Text = "" Or txtb_sLname.Text = "" Or cbo_sGL.Text = "" Or cbo_sSY.Text = "" Then
            dlg_fillup.ShowDialog()
        Else
            txtb_sFname.Enabled = False
            txtb_sLname.Enabled = False
            txtb_smi.Enabled = False
            cbo_sSY.Enabled = False
            cbo_sGL.Enabled = False


            btn_sAddStud.Enabled = True
            btn_sUpdateStud.Enabled = True
            dg_sStudRec.Enabled = True
            btn_sViewAccount.Enabled = True
            btn_sCancel.Enabled = False
            btn_sSave.Enabled = False
            Select Case C
                Case 1
                    Dim shAddNewStud = "Insert into tbl_seniorhigh_students values('" & txtb_sStud_id.Text & "','" & txtb_sFname.Text & "','" & txtb_sLname.Text & "','" & txtb_smi.Text & "','" & cbo_sSY.SelectedValue & "','" & cbo_sGL.SelectedValue & "')"
                    _dbConnection("db_lccsams")
                    _insertData(shAddNewStud)
                    dlg_savesuccessfully.ShowDialog()
                    _displayRecords(sSelect_studRec, dg_sStudRec)
                Case 2
                    Dim querry3 = "update tbl_seniorhigh_students set sstud_fname='" & txtb_sFname.Text & "',sstud_lname='" & txtb_sLname.Text & "',sstud_mi='" & txtb_smi.Text & "',ssy_id='" & cbo_sSY.SelectedValue & "',sgl_id='" & cbo_sGL.SelectedValue & "' where sstud_id='" & txtb_sStud_id.Text & "' "
                    _dbConnection("db_lccsams")
                    _updateData(querry3)
                    _displayRecords(sSelect_studRec, dg_sStudRec)
                    UpdatedSuccessfully.ShowDialog()
            End Select
        End If
    End Sub

    Private Sub btn_sCancel_Click(sender As Object, e As EventArgs) Handles btn_sCancel.Click
        'disabled
        txtb_sFname.Enabled = False
        txtb_sLname.Enabled = False
        txtb_smi.Enabled = False
        cbo_sSY.Enabled = False
        cbo_sGL.Enabled = False
        'clear selection
        txtb_sFname.Clear()
        txtb_sLname.Clear()
        txtb_smi.Clear()
        cbo_sSY.SelectedIndex = -1
        cbo_sGL.SelectedIndex = -1

        btn_sSave.Enabled = False
        btn_sAddStud.Enabled = True
        btn_sUpdateStud.Enabled = True
        dg_sStudRec.Enabled = True
        btn_sViewAccount.Enabled = True
        btn_sCancel.Enabled = False
    End Sub

    Private Sub dg_sStudRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_sStudRec.CellClick
        Try
            Dim i = e.RowIndex
            With dg_sStudRec

                Dim querry As String = "Select ssy_name from tbl_seniorhigh_sy where ssy_id='" & .Item("col_sSY", i).Value & "'"
                Dim querry2 As String = "Select sgl_name from tbl_seniorhigh_gl where sgl_id='" & .Item("col_sGl", i).Value & "'"
                _dbConnection("db_lccsams")
                sStud_id = .Item("col_sStud_id", i).Value
                sStudname = .Item("col_sStud_fname", i).Value.ToString.ToUpper + " " + .Item("col_sStud_mi", i).Value.ToString.ToUpper + " " + .Item("col_sStud_lname", i).Value.ToString.ToUpper
                sStudSY = _selectComboBoxText(querry, cbo_sSY)
                sStudGL = _selectComboBoxText(querry2, cbo_sGL)

                txtb_sStud_id.Text = .Item("col_sStud_id", i).Value
                txtb_sFname.Text = .Item("col_sStud_fname", i).Value.ToString.ToUpper
                txtb_sLname.Text = .Item("col_sStud_lname", i).Value.ToString.ToUpper
                txtb_smi.Text = .Item("col_sStud_mi", i).Value.ToString.ToUpper



            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    '####################################################Junior-High department Section##################################################################
    Dim d As Integer = 0
    Private Sub txtb_jSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_jSearch.KeyUp
        Select Case cbo_jSearchBy.SelectedItem.ToString
            Case "Name"
                _dbConnection("db_lccsams")
                _displayRecords(" select * from tbl_juniorhigh_students where jstud_fname Like '%" & txtb_jSearch.Text & "%' or jstud_lname  Like '%" & txtb_jSearch.Text & "%' ", dg_jStudRec)

            Case "ID Number"
                _dbConnection("db_lccsams")
                _displayRecords("select * from tbl_juniorhigh_students where jstud_id Like '" & txtb_jSearch.Text & "%' ", dg_jStudRec)
        End Select
    End Sub

    Private Sub btn_jViewAcct_Click(sender As Object, e As EventArgs) Handles btn_jViewAcct.Click
        Try
            If txtb_jStud_id.Text = "" Then
                MessageBox.Show("Please select student first to proceed")
            Else
                current_menu = 2
                Dashboard.btn_menuStudentsAccount_click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_jAddStud_Click(sender As Object, e As EventArgs) Handles btn_jAddStud.Click
        If dlg_addstudents.ShowDialog = DialogResult.Yes Then
            txtb_jStudFname.Enabled = True
            txtb_jStudLname.Enabled = True
            txtb_jStudMI.Enabled = True

            cbo_jSY.Enabled = True
            cbo_jGL.Enabled = True
            dg_jStudRec.Enabled = False


            'clear selection
            txtb_jStudFname.Clear()
            txtb_jStudLname.Clear()
            txtb_jStudMI.Clear()
            cbo_jSY.SelectedIndex = -1
            cbo_jGL.SelectedIndex = -1
            random()
            txtb_jStud_id.Text = randomNumber

            btn_jAddStud.Enabled = False
            btn_jCancel.Enabled = True
            btn_jSave.Enabled = True
            btn_jUpdateStud.Enabled = False
            btn_jViewAcct.Enabled = False
            d = 1
        End If

    End Sub

    Private Sub btn_jUpdateStud_Click(sender As Object, e As EventArgs) Handles btn_jUpdateStud.Click
        If dlg_updatestudents.ShowDialog = DialogResult.Yes Then
            txtb_jStudFname.Enabled = True
            txtb_jStudLname.Enabled = True
            txtb_jStudMI.Enabled = True
            cbo_jSY.Enabled = True
            cbo_jGL.Enabled = True
            dg_jStudRec.Enabled = False

            btn_jUpdateStud.Enabled = False
            btn_jSave.Enabled = True
            btn_jAddStud.Enabled = False
            dg_jStudRec.Enabled = False
            btn_jViewAcct.Enabled = False
            btn_jCancel.Enabled = True
            d = 2
        End If


    End Sub

    Private Sub btn_jSave_Click(sender As Object, e As EventArgs) Handles btn_jSave.Click
        If txtb_jStudFname.Text = "" Or txtb_jStudLname.Text = "" Or cbo_jGL.Text = "" Or cbo_jSY.Text = "" Then
            dlg_fillup.ShowDialog()
        Else
            txtb_jStudFname.Enabled = False
            txtb_jStudLname.Enabled = False
            txtb_jStudMI.Enabled = False
            cbo_jSY.Enabled = False
            cbo_jGL.Enabled = False


            btn_jAddStud.Enabled = True
            btn_jUpdateStud.Enabled = True
            dg_jStudRec.Enabled = True
            btn_jViewAcct.Enabled = True
            btn_jCancel.Enabled = False
            btn_jSave.Enabled = False
            Select Case d
                Case 1
                    Dim jNewStud As String = "Insert into tbl_juniorhigh_students values ('" & txtb_jStud_id.Text & "','" & txtb_jStudFname.Text & "','" & txtb_jStudLname.Text & "','" & txtb_jStudMI.Text & "','" & cbo_jSY.SelectedValue & "','" & cbo_jGL.SelectedValue & "')"
                    _insertData(jNewStud)
                    dlg_savesuccessfully.ShowDialog()
                    _displayRecords(jSelect_studRec, dg_jStudRec)
                Case 2
                    Dim jUpdateStud = "Update tbl_juniorhigh_students set jstud_fname='" & txtb_jStudFname.Text & "',jstud_lname='" & txtb_jStudLname.Text & "',jstud_mi='" & txtb_jStudMI.Text & "',jsy_id='" & cbo_jSY.SelectedValue & "',jgl_id='" & cbo_jGL.SelectedValue & "' where jstud_id='" & txtb_jStud_id.Text & "' "
                    _dbConnection("db_lccsams")
                    _updateData(jUpdateStud)
                    _displayRecords(jSelect_studRec, dg_jStudRec)
                    UpdatedSuccessfully.ShowDialog()
            End Select
        End If
    End Sub

    Private Sub btn_jCancel_Click(sender As Object, e As EventArgs) Handles btn_jCancel.Click
        'disabled
        txtb_jStudFname.Enabled = False
        txtb_jStudLname.Enabled = False
        txtb_jStudMI.Enabled = False
        cbo_jSY.Enabled = False
        cbo_jGL.Enabled = False
        'clear selection
        txtb_jStudFname.Clear()
        txtb_jStudLname.Clear()
        txtb_jStudMI.Clear()
        cbo_jSY.SelectedIndex = -1
        cbo_jGL.SelectedIndex = -1

        btn_jSave.Enabled = False
        btn_jAddStud.Enabled = True
        btn_jUpdateStud.Enabled = True
        dg_jStudRec.Enabled = True
        btn_jViewAcct.Enabled = True
        btn_jCancel.Enabled = False
    End Sub

    Private Sub dg_jStudRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_jStudRec.CellClick
        Try
            Dim i = e.RowIndex
            With dg_jStudRec

                Dim querry As String = "Select jsy_name from tbl_juniorhigh_sy where jsy_id='" & .Item(4, i).Value & "'"
                Dim querry2 As String = "Select jgl_name from tbl_juniorhigh_gradelevel where jgl_id='" & .Item(5, i).Value & "'"
                _dbConnection("db_lccsams")
                jStud_id = .Item(0, i).Value
                jStudname = .Item(1, i).Value.ToString.ToUpper + " " + .Item(2, i).Value.ToString.ToUpper + " " + .Item(3, i).Value.ToString.ToUpper
                jStudSY = _selectComboBoxText(querry, cbo_jSY)
                jStudGL = _selectComboBoxText(querry2, cbo_jGL)

                txtb_jStud_id.Text = .Item(0, i).Value
                txtb_jStudFname.Text = .Item(1, i).Value.ToString.ToUpper
                txtb_jStudLname.Text = .Item(2, i).Value.ToString.ToUpper
                txtb_jStudMI.Text = .Item(3, i).Value.ToString.ToUpper

            End With

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub txtb_studMI_TextChanged(sender As Object, e As EventArgs) Handles txtb_studMI.TextChanged

    End Sub


End Class
