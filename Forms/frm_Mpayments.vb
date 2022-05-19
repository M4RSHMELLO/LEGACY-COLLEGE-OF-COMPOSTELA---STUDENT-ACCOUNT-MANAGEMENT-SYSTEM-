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
        If MessageBox.Show("", "Do You want to add new tertiary fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
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
            Dim cFeesR_sort As String = "select fees_id,fees_name, fees_amount, tuition_rpu_id from tbl_coll_fees where sy_id='" & cbo_SortSY.SelectedValue & "' and sem_id='" & cbo_SortSem.SelectedValue & "' and yl_id='" & cbo_SortYL.SelectedValue & "' and  crs_id='" & cbo_SortCrs.SelectedValue & "'"
            cbo_MS.SelectedIndex = -1
            cbo_yl.SelectedIndex = -1
            cbo_course.SelectedIndex = -1
            txtb_CollName.Clear()
            txtb_collAmnt.Clear()
            _displayRecords(cFeesR_sort, dg_pRecords)

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
            Case 1
                _dbConnection("db_lccsams")
                _loadToCombobox(eSelect_SY, cbo_eSY)
                _loadToCombobox(eSelect_SY, cbo_eSortSy)
                cbo_eSortSy.SelectedIndex = -1
            Case 2
                _dbConnection("db_lccsams")
                _loadToCombobox(sSelect_SY, cbo_sSY)
                _loadToCombobox(sSelect_SY, cbo_sSortSY)
                cbo_sSortSY.SelectedIndex = -1
            Case 3
                _dbConnection("db_lccsams")
                _loadToCombobox(jSelect_SY, cbo_jSY)
                _loadToCombobox(jSelect_SY, cbo_jSortSY)
                cbo_jSortSY.SelectedIndex = -1
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


    '###########################################################Elementary Depatment Section##############################################################
    Dim b As Integer = 0
    Dim efees_id As Integer = 0


    Private Sub btn_eAdd_Click(sender As Object, e As EventArgs) Handles btn_eAdd.Click
        If MessageBox.Show("", "Do You want to add new elementary fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cbo_eSY.Enabled = True
            txtb_eFeeName.Enabled = True
            txtb_eFeeAmnt.Enabled = True

            btn_eAdd.Enabled = False
            btn_eUpdate.Enabled = False
            btn_eCancel.Enabled = True
            btn_eSave.Enabled = True
            dg_eFeesRec.Enabled = False
            b = 1

        End If
    End Sub

    Private Sub btn_eUpdate_Click(sender As Object, e As EventArgs) Handles btn_eUpdate.Click
        If MessageBox.Show("", "Do You want to Update this fees?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            b = 2
            cbo_eSY.Enabled = True
            txtb_eFeeName.Enabled = True
            txtb_eFeeAmnt.Enabled = True

            btn_eAdd.Enabled = False
            btn_eUpdate.Enabled = False
            btn_eCancel.Enabled = True
            btn_eSave.Enabled = True
            dg_eFeesRec.Enabled = False
        End If
    End Sub

    Private Sub btn_eCancel_Click(sender As Object, e As EventArgs) Handles btn_eCancel.Click
        cbo_eSY.Enabled = False
        txtb_eFeeName.Enabled = False
        txtb_eFeeAmnt.Enabled = False

        btn_eAdd.Enabled = True
        btn_eUpdate.Enabled = True
        btn_eCancel.Enabled = False
        btn_eSave.Enabled = False
        dg_eFeesRec.Enabled = True
    End Sub

    Private Sub btn_eSave_Click(sender As Object, e As EventArgs) Handles btn_eSave.Click
        Dim efeesR As String = "select efees_id,efees_name, efees_amount from tbl_elem_fees where esy_id='" & cbo_eSortSy.SelectedValue & "' "
        Select Case b
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_elem_fees values (0,'" & txtb_eFeeName.Text & "','" & txtb_eFeeAmnt.Text & "','" & cbo_eSY.SelectedValue & "')")
                _displayRecords(efeesR, dg_eFeesRec)
                dlg_savesuccessfully.ShowDialog()
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_elem_fees set efees_name='" & txtb_eFeeName.Text & "',efees_amount= '" & txtb_eFeeName.Text & "' where efees_id='" & efees_id & "' ")

                _displayRecords(efeesR, dg_eFeesRec)
                UpdatedSuccessfully.ShowDialog()
        End Select
        btn_eAdd.Enabled = True
        btn_eUpdate.Enabled = True
        btn_eCancel.Enabled = False
        btn_eSave.Enabled = False
        dg_eFeesRec.Enabled = True
        cbo_eSY.Enabled = False
        txtb_eFeeName.Enabled = False
        txtb_eFeeAmnt.Enabled = False
    End Sub

    Private Sub cbo_eSortSy_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_eSortSy.SelectionChangeCommitted
        Try
            Dim eFeesR_sort As String = "select efees_id,efees_name, efees_amount from tbl_elem_fees where esy_id='" & cbo_eSortSy.SelectedValue & "' "
            _dbConnection("db_lccsams")

            txtb_eFeeAmnt.Clear()
            txtb_eFeeName.Clear()
            _displayRecords(eFeesR_sort, dg_eFeesRec)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub dg_eFeesRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_eFeesRec.CellClick
        Try
            Dim s = e.RowIndex
            With dg_eFeesRec
                cbo_eSY.Text = cbo_eSortSy.Text
                efees_id = .Item(0, s).Value.ToString
                txtb_eFeeName.Text = .Item(1, s).Value.ToString
                txtb_eFeeAmnt.Text = .Item(2, s).Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show("Error:", ex.Message)

        End Try
    End Sub
    '###########################################################Senior High Department Section##############################################################
    Dim c As Integer = 0
    Dim ssy_id As Integer = 0

    Private Sub btn_sAdd_Click(sender As Object, e As EventArgs) Handles btn_sAdd.Click
        If MessageBox.Show("", "Do You want to add new Senior High fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cbo_sSY.Enabled = True
            txtb_sfeeName.Enabled = True
            txtb_sFeeAmnt.Enabled = True


            btn_sAdd.Enabled = False
            btn_sUpdate.Enabled = False
            btn_sCancel.Enabled = True
            btn_sSave.Enabled = True
            dg_sfeesRec.Enabled = False
            c = 1

        End If
    End Sub

    Private Sub btn_sUpdate_Click(sender As Object, e As EventArgs) Handles btn_sUpdate.Click
        If MessageBox.Show("", "Do You want to Update this fees?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            c = 2
            cbo_sSY.Enabled = True
            txtb_sfeeName.Enabled = True
            txtb_sFeeAmnt.Enabled = True


            btn_sAdd.Enabled = False
            btn_sUpdate.Enabled = False
            btn_sCancel.Enabled = True
            btn_sSave.Enabled = True
            dg_sfeesRec.Enabled = False
        End If
    End Sub

    Private Sub btn_sCancel_Click(sender As Object, e As EventArgs) Handles btn_sCancel.Click
        cbo_sSY.Enabled = False
        txtb_sfeeName.Enabled = False
        txtb_sFeeAmnt.Enabled = False


        btn_sAdd.Enabled = True
        btn_sUpdate.Enabled = True
        btn_sCancel.Enabled = False
        btn_sSave.Enabled = False
        dg_sfeesRec.Enabled = True
    End Sub

    Private Sub btn_sSave_Click(sender As Object, e As EventArgs) Handles btn_sSave.Click
        Dim sFeesR As String = "select sfees_id,sfees_name, sfees_amount from tbl_senior_fees where ssy_id='" & cbo_sSortSY.SelectedValue & "' "

        Select Case c
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_senior_fees values (0,'" & txtb_sfeeName.Text & "','" & txtb_sFeeAmnt.Text & "','" & cbo_sSY.SelectedValue & "')")
                _displayRecords(sFeesR, dg_sfeesRec)
                dlg_savesuccessfully.ShowDialog()
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_senior_fees  set sfees_name='" & txtb_sfeeName.Text & "', sfees_amount='" & txtb_sFeeAmnt.Text & "' where sfees_id='" & sfees_id & "'")
                btn_sUpdate.Enabled = True
                btn_sSave.Enabled = False
                UpdatedSuccessfully.ShowDialog()
                _displayRecords(sFeesR, dg_sfeesRec)

        End Select
        cbo_sSY.Enabled = False
        txtb_sfeeName.Enabled = False
        txtb_sFeeAmnt.Enabled = False


        btn_sAdd.Enabled = True
        btn_sUpdate.Enabled = True
        btn_sCancel.Enabled = False
        btn_sSave.Enabled = False
        dg_sfeesRec.Enabled = True
    End Sub

    Private Sub cbo_sSortSY_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_sSortSY.SelectionChangeCommitted
        Try
            Dim sFeesR_sort As String = "select sfees_id,sfees_name, sfees_amount from tbl_senior_fees where ssy_id='" & cbo_sSortSY.SelectedValue & "' "

            _dbConnection("db_lccsams")

            txtb_sFeeAmnt.Clear()
            txtb_sfeeName.Clear()
            _displayRecords(sFeesR_sort, dg_sfeesRec)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub dg_sfeesRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_sfeesRec.CellClick
        Try
            Dim s = e.RowIndex
            With dg_sfeesRec
                cbo_sSY.Text = cbo_sSortSY.Text
                ssy_id = .Item(0, s).Value.ToString
                txtb_sfeeName.Text = .Item(1, s).Value.ToString
                txtb_sFeeAmnt.Text = .Item(2, s).Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show("Error:", ex.Message)

        End Try
    End Sub
    '###########################################################junior high Depatment Section##############################################################
    Dim d As Integer = 0
    Dim jfees_id As Integer = 0

    Private Sub btn_jAdd_Click(sender As Object, e As EventArgs) Handles btn_jAdd.Click
        If MessageBox.Show("", "Do You want to add new Junior High fees", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            cbo_jSY.Enabled = True
            txtb_jFeesName.Enabled = True
            txtb_jFeesAmnt.Enabled = True


            btn_jAdd.Enabled = False
            btn_jUpdate.Enabled = False
            btn_jCancel.Enabled = True
            btn_jSave.Enabled = True
            dg_jFeesRec.Enabled = False
            d = 1

        End If
    End Sub

    Private Sub btn_jUpdate_Click(sender As Object, e As EventArgs) Handles btn_jUpdate.Click
        If MessageBox.Show("", "Do You want to Update this fees?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            d = 2
            cbo_jSY.Enabled = True
            txtb_jFeesName.Enabled = True
            txtb_jFeesAmnt.Enabled = True


            btn_jAdd.Enabled = False
            btn_jUpdate.Enabled = False
            btn_jCancel.Enabled = True
            btn_jSave.Enabled = True
            dg_jFeesRec.Enabled = False

        End If
    End Sub

    Private Sub btn_jCancel_Click(sender As Object, e As EventArgs) Handles btn_jCancel.Click
        cbo_jSY.Enabled = False
        txtb_jFeesName.Enabled = False
        txtb_jFeesAmnt.Enabled = False
        btn_jAdd.Enabled = True
        btn_jUpdate.Enabled = True
        btn_jCancel.Enabled = False
        btn_jSave.Enabled = False
        dg_jFeesRec.Enabled = True
    End Sub

    Private Sub btn_jSave_Click(sender As Object, e As EventArgs) Handles btn_jSave.Click
        Dim jFeesR As String = "select jfees_id,jfees_name, jfees_amount from tbl_junior_fees where jsy_id='" & cbo_jSortSY.SelectedValue & "' "

        Select Case d
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_junior_fees values (0,'" & txtb_sfeeName.Text & "','" & txtb_sFeeAmnt.Text & "','" & cbo_sSY.SelectedValue & "')")
                _displayRecords(jFeesR, dg_jFeesRec)
                dlg_savesuccessfully.ShowDialog()
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_junior_fees set jfees_name='" & txtb_jFeesName.Text & "', jfees_amount='" & txtb_jFeesAmnt.Text & "' where jfees_id='" & jfees_id & "'")
                btn_sUpdate.Enabled = True
                btn_sSave.Enabled = False

                UpdatedSuccessfully.ShowDialog()
                _displayRecords(jFeesR, dg_jFeesRec)
        End Select
        cbo_jSY.Enabled = False
        txtb_jFeesName.Enabled = False
        txtb_jFeesAmnt.Enabled = False
        btn_jAdd.Enabled = True
        btn_jUpdate.Enabled = True
        btn_jCancel.Enabled = False
        btn_jSave.Enabled = False
        dg_jFeesRec.Enabled = True
    End Sub
    Private Sub cbo_jSortSY_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_jSortSY.SelectionChangeCommitted
        Try
            Dim jFeesR_sort As String = "select jfees_id,jfees_name, jfees_amount from tbl_junior_fees where jsy_id='" & cbo_jSortSY.SelectedValue & "' "
            _dbConnection("db_lccsams")
            txtb_jFeesAmnt.Clear()
            txtb_jFeesName.Clear()
            _displayRecords(jFeesR_sort, dg_jFeesRec)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub dg_jFeesRec_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_jFeesRec.CellClick
        Try
            Dim s = e.RowIndex
            With dg_jFeesRec
                jfees_id = .Item(0, s).Value.ToString
                cbo_jSY.Text = cbo_jSortSY.Text
                txtb_jFeesName.Text = .Item(1, s).Value.ToString
                txtb_jFeesAmnt.Text = .Item(2, s).Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show("Error:", ex.Message)

        End Try
    End Sub

End Class
