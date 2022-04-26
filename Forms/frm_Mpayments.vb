Public Class frm_Mpayments
    Public Sub frm_Mpayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctC, cbo_course)
        _loadToCombobox(slctS, cbo_MS)
        _loadToCombobox(slctYL, cbo_yl)
        _loadToCombobox(slctSY, cbo_MSY)
        cbo_MS.SelectedIndex = -1
        cbo_yl.SelectedIndex = -1
        cbo_course.SelectedIndex = -1

        'Sort by
        _loadToCombobox(slctSY, cbo_SortSY)
        _loadToCombobox(slctC, cbo_SortCrs)
        _loadToCombobox(slctS, cbo_SortSem)
        _loadToCombobox(slctYL, cbo_SortYL)
        cbo_SortCrs.SelectedIndex = -1
        cbo_SortSem.SelectedIndex = -1
        cbo_SortYL.SelectedIndex = -1
    End Sub

    Dim a As Integer = 0

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If MessageBox.Show("", "Do You want to add new college fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cbo_yl.Enabled = True
            cbo_course.Enabled = True
            cbo_MSY.Enabled = True
            cbo_MS.Enabled = True

            cbo_SortCrs.Enabled = True
            cbo_SortYL.Enabled = True

            btn_add.Enabled = False
            a = 1
            txtb_CollName.Enabled = True
            txtb_collAmnt.Enabled = True
            btn_update.Enabled = False
            btn_save.Enabled = True
            btn_cancel.Enabled = True
            dg_pRecords.Enabled = False

            txtb_CollName.Clear()
            txtb_collAmnt.Clear()
            checkb_tuitionfee_indicator.Checked = False
        End If
    End Sub
    Dim tuition_rpu_id As Integer = 0
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim sFeesR As String = "select fees_id,fees_name,fees_amount,tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "' "
        Dim querry1 = "Select tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "'and tuition_rpu_id='" & 1 & "'"

        Select Case a
            Case 1
                If (checkb_tuitionfee_indicator.Checked = True) Then
                    tuition_rpu_id = 1
                Else
                    tuition_rpu_id = 0
                End If
                Try
                    dbConn.Open()
                    sqlCommand = New MySql.Data.MySqlClient.MySqlCommand(querry1, dbConn)
                    dr = sqlCommand.ExecuteReader
                    If dr.HasRows And checkb_tuitionfee_indicator.Checked = True Then
                        MessageBox.Show("Tuition fee is already exist!")
                    Else

                        dbConn.Close()
                        _dbConnection("db_lccsams")
                        _insertData("insert into tbl_coll_fees values (0,'" & txtb_CollName.Text & "','" & txtb_collAmnt.Text & "','" & cbo_MSY.SelectedValue & "','" & cbo_yl.SelectedValue & "','" & cbo_MS.SelectedValue & "','" & cbo_course.SelectedValue & "','" & tuition_rpu_id & "')")
                        btn_save.Enabled = False
                        btn_add.Enabled = True
                        btn_update.Enabled = True
                        btn_cancel.Enabled = False
                        _displayRecords(sFeesR, dg_pRecords)
                        cbo_course.Enabled = False
                        cbo_MSY.Enabled = False
                        cbo_MS.Enabled = False
                        cbo_yl.Enabled = False
                        txtb_CollName.Enabled = False
                        txtb_collAmnt.Enabled = False
                        dg_pRecords.Enabled = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: ", ex.Message)
                Finally
                    dbConn.Close()


                End Try

            Case 2
                _dbConnection("db_lccsams")
                _updateData("")
                btn_update.Enabled = True
                btn_save.Enabled = False
                _displayRecords(sFeesR, dg_pRecords)
        End Select
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MessageBox.Show("", "Do You want to Update this fees?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            a = 2
            cbo_yl.Enabled = True
            cbo_course.Enabled = True
            cbo_MSY.Enabled = True
            cbo_MS.Enabled = True

            btn_save.Enabled = True
            btn_update.Enabled = False

            btn_cancel.Enabled = True
            dg_pRecords.Enabled = False
        End If
    End Sub

    Dim educ_stagesSelect As Integer = 0

    Private Sub dg_pRecords_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_pRecords.CellClick
        Try
            Dim s = e.RowIndex
            With dg_pRecords
                cbo_MSY.Text = cbo_SortSY.Text
                cbo_MS.Text = cbo_SortSem.Text
                cbo_yl.Text = cbo_SortYL.Text
                cbo_course.Text = cbo_SortCrs.Text
                txtb_CollName.Text = .Item("fees_name", s).Value.ToString
                txtb_collAmnt.Text = .Item("fees_amount", s).Value.ToString
                If .Item("rpu_id", s).Value = 1 Then
                    checkb_tuitionfee_indicator.Checked = True
                Else
                    checkb_tuitionfee_indicator.Checked = False
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error:", ex.Message)

        End Try
    End Sub




    Private Sub cbo_SortYL_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_SortYL.SelectionChangeCommitted
        cbo_SortCrs.SelectedIndex = -1
    End Sub

    Private Sub cbo_SortCrs_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_SortCrs.SelectionChangeCommitted
        Try
            _dbConnection("db_lccsams")
            Dim sFeesR_sort As String = "select fees_id,fees_name, fees_amount, tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_SortSY.SelectedValue & "' and sem_id='" & cbo_SortSem.SelectedValue & "' and yl_id='" & cbo_SortYL.SelectedValue & "' and  crs_id='" & cbo_SortCrs.SelectedValue & "'"
            cbo_MS.SelectedIndex = -1
            cbo_yl.SelectedIndex = -1
            cbo_course.SelectedIndex = -1
            txtb_CollName.Clear()
            txtb_collAmnt.Clear()
            _displayRecords(sFeesR_sort, dg_pRecords)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Dim departmentChange As Integer = 0
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        departmentChange = TabControl1.SelectedIndex
        Select Case departmentChange
            Case 0
                _dbConnection("db_lccsams")
                _loadToCombobox(slctC, cbo_course)
                _loadToCombobox(slctS, cbo_MS)
                _loadToCombobox(slctYL, cbo_yl)
                _loadToCombobox(slctSY, cbo_MSY)
                'Sort by
                _loadToCombobox(slctSY, cbo_SortSY)
                _loadToCombobox(slctC, cbo_SortCrs)
                _loadToCombobox(slctS, cbo_SortSem)
                _loadToCombobox(slctYL, cbo_SortYL)
                cbo_SortCrs.SelectedIndex = -1
                cbo_SortSem.SelectedIndex = -1
                cbo_SortYL.SelectedIndex = -1

        End Select
    End Sub

    Private Sub cbo_SortSem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_SortSem.SelectionChangeCommitted
        cbo_SortCrs.SelectedIndex = -1
        cbo_SortYL.SelectedIndex = -1
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cbo_MS.SelectedIndex = -1
        cbo_yl.SelectedIndex = -1
        cbo_course.SelectedIndex = -1
        txtb_CollName.Clear()
        txtb_collAmnt.Clear()
        checkb_tuitionfee_indicator.Checked = False
        btn_add.Enabled = True
        btn_update.Enabled = True
        dg_pRecords.Enabled = True
    End Sub

    ''###########################################################Elementary Section ################################################################################
    Dim b As Integer = 0
    Private Sub btn_eFeesAdd_Click(sender As Object, e As EventArgs) Handles btn_eFeesAdd.Click
        If MessageBox.Show("", "Do You want to add new elementary fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            b = 1
            cbo_egl.Enabled = True
            cbo_esy.Enabled = True
            btn_eFeesAdd.Enabled = False

            txtb_efeesName.Enabled = True
            txtb_efeesAmount.Enabled = True
            btn_eFeesUpdate.Enabled = False
            btn_eFeesCancel.Enabled = True
            btn_eFeesSave.Enabled = True
            dg_eFeesRec.Enabled = False

            txtb_efeesName.Clear()
            txtb_efeesAmount.Clear()
        End If
    End Sub

    Private Sub btn_eFeesUpdate_Click(sender As Object, e As EventArgs) Handles btn_eFeesUpdate.Click
        If MessageBox.Show("", "Do You want to Update this fees?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            b = 2

            cbo_egl.Enabled = True
            cbo_esy.Enabled = True
            txtb_efeesName.Enabled = True
            txtb_efeesAmount.Enabled = True

            btn_eFeesSave.Enabled = True
            btn_eFeesUpdate.Enabled = False
            btn_eFeesCancel.Enabled = True

            dg_eFeesRec.Enabled = False
        End If
    End Sub

    Private Sub btn_eFeesSave_Click(sender As Object, e As EventArgs) Handles btn_eFeesSave.Click
        Dim sFeesR As String = "select fees_id,fees_name,fees_amount,tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "' "
        Dim querry1 = "Select tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "'and tuition_rpu_id='" & 1 & "'"

        Select Case a
            Case 1
                If (checkb_tuitionfee_indicator.Checked = True) Then
                    tuition_rpu_id = 1
                Else
                    tuition_rpu_id = 0
                End If
                Try
                    dbConn.Open()
                    sqlCommand = New MySql.Data.MySqlClient.MySqlCommand(querry1, dbConn)
                    dr = sqlCommand.ExecuteReader
                    If dr.HasRows And checkb_tuitionfee_indicator.Checked = True Then
                        MessageBox.Show("Tuition fee is already exist!")
                    Else

                        dbConn.Close()
                        _dbConnection("db_lccsams")
                        _insertData("insert into tbl_coll_fees values (0,'" & txtb_CollName.Text & "','" & txtb_collAmnt.Text & "','" & cbo_MSY.SelectedValue & "','" & cbo_yl.SelectedValue & "','" & cbo_MS.SelectedValue & "','" & cbo_course.SelectedValue & "','" & tuition_rpu_id & "')")
                        btn_save.Enabled = False
                        btn_add.Enabled = True
                        btn_update.Enabled = True
                        btn_cancel.Enabled = False
                        _displayRecords(sFeesR, dg_pRecords)
                        cbo_course.Enabled = False
                        cbo_MSY.Enabled = False
                        cbo_MS.Enabled = False
                        cbo_yl.Enabled = False
                        txtb_CollName.Enabled = False
                        txtb_collAmnt.Enabled = False
                        dg_pRecords.Enabled = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: ", ex.Message)
                Finally
                    dbConn.Close()


                End Try

            Case 2
                _dbConnection("db_lccsams")
                _updateData("")
                btn_update.Enabled = True
                btn_save.Enabled = False
                _displayRecords(sFeesR, dg_pRecords)
        End Select
    End Sub
End Class
