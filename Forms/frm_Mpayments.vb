Public Class frm_Mpayments
    Public Sub frm_Mpayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctC, cbo_course)
        _loadToCombobox(slctS, cbo_MS)
        _loadToCombobox(slctYL, cbo_yl)
        _loadToCombobox(slctSY, cbo_MSY)
        _loadToCombobox(slctFeesType, cbo_collFeesName)

        cbo_MS.SelectedIndex = -1
        cbo_yl.SelectedIndex = -1
        cbo_course.SelectedIndex = -1
        cbo_collFeesName.SelectedIndex = -1
        'Sort by

        _loadToCombobox(slctSY, cbo_SortSY)
        _loadToCombobox(slctS, cbo_SortSem)
        _loadToCombobox(slctYL, cbo_SortYL)
        _loadToCombobox(slctC, cbo_SortCrs)
        cbo_SortSY.SelectedIndex = -1
        cbo_SortCrs.SelectedIndex = -1
        cbo_SortSem.SelectedIndex = -1
        cbo_SortYL.SelectedIndex = -1
    End Sub

    Dim a As Integer = 0
    Dim cfees_id As Integer
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If dlg_addfees.ShowDialog() = DialogResult.OK Then
            cbo_yl.Enabled = True
            cbo_course.Enabled = True
            cbo_MSY.Enabled = True
            cbo_MS.Enabled = True
            cbo_collFeesName.Enabled = True
            cbo_SortCrs.Enabled = True
            cbo_SortYL.Enabled = True

            btn_add.Enabled = False
            a = 1

            txtb_collAmnt.Enabled = True
            btn_update.Enabled = False
            btn_save.Enabled = True
            btn_cancel.Enabled = True
            dg_pRecords.Enabled = False


            txtb_collAmnt.Clear()

        End If
    End Sub
    Dim tuition_rpu_id As Integer = 0
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click


        Dim sFeesR As String = "select f.fees_id,ft.feestype_name, f.fees_amount  from tbl_coll_fees f  inner join tbl_fees_type ft on f.fees_name=ft.feestype_id where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "' "
        Dim querry1 = "Select fees_name from tbl_coll_fees where sy_id='" & cbo_MSY.SelectedValue & "' and yl_id='" & cbo_yl.SelectedValue & "' and sem_id='" & cbo_MS.SelectedValue & "' and crs_id='" & cbo_course.SelectedValue & "' and fees_name='" & cbo_collFeesName.SelectedValue & "' "

        Select Case a
            Case 1
                'If (checkb_tuitionfee_indicator.Checked = True) Then
                '    tuition_rpu_id = 1
                'Else
                '    tuition_rpu_id = 0
                'End If
                Try
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(querry1, dbConn)
                    dr = sqlCommand.ExecuteReader
                    If dr.HasRows Then
                        MessageBox.Show("Fees Type  you want to add is already exist!")
                    Else

                        dbConn.Close()
                        _dbConnection("db_lccsams")
                        _insertData("insert into tbl_coll_fees values (0,'" & cbo_collFeesName.SelectedValue & "','" & txtb_collAmnt.Text & "','" & cbo_MSY.SelectedValue & "','" & cbo_yl.SelectedValue & "','" & cbo_MS.SelectedValue & "','" & cbo_course.SelectedValue & "')")
                        If dlg_savesuccessfully.ShowDialog = DialogResult.OK Then
                            btn_save.Enabled = False
                            btn_add.Enabled = True
                            btn_update.Enabled = True
                            btn_cancel.Enabled = False
                            _displayRecords(sFeesR, dg_pRecords)
                            cbo_course.Enabled = False
                            cbo_MSY.Enabled = False
                            cbo_MS.Enabled = False
                            cbo_yl.Enabled = False

                            txtb_collAmnt.Enabled = False
                            dg_pRecords.Enabled = True
                            cbo_collFeesName.Enabled = False

                        End If

                    End If
                Catch ex As Exception
                    MessageBox.Show("Error: ", ex.Message)
                Finally
                    dbConn.Close()
                End Try

            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_coll_fees set fees_amount='" & txtb_collAmnt.Text & "' where fees_id='" & cfees_id & "'  ")
                UpdatedSuccessfully.ShowDialog()
                If UpdatedSuccessfully.DialogResult = DialogResult.OK Then
                    btn_update.Enabled = True
                    btn_cancel.Enabled = False
                    btn_save.Enabled = False
                    cbo_collFeesName.Enabled = False
                    _displayRecords(sFeesR, dg_pRecords)
                End If


        End Select
    End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If dlg_updatefees.ShowDialog() = DialogResult.OK Then
            a = 2
            'cbo_yl.Enabled = True
            'cbo_course.Enabled = True
            'cbo_MSY.Enabled = True
            'cbo_MS.Enabled = True
            txtb_collAmnt.Enabled = True
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

                cbo_collFeesName.Text = .Item("feestype_name", s).Value.ToString
                txtb_collAmnt.Text = .Item("fees_amount", s).Value.ToString
                cfees_id = .Item(0, s).Value.ToString

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

            Dim cFeesR_sort As String = "select f.fees_id,ft.feestype_name, f.fees_amount  from tbl_coll_fees f  inner join tbl_fees_type ft on f.fees_name=ft.feestype_id where sy_id='" & Integer.Parse(cbo_SortSY.SelectedValue) & "' and sem_id='" & cbo_SortSem.SelectedValue & "' and yl_id='" & cbo_SortYL.SelectedValue & "' and  crs_id='" & cbo_SortCrs.SelectedValue & "'"
            _dbConnection("db_lccsams")
            cbo_MS.SelectedIndex = -1
            cbo_yl.SelectedIndex = -1
            cbo_course.SelectedIndex = -1
            cbo_collFeesName.SelectedIndex = -1
            txtb_collAmnt.Clear()
            _displayRecords(cFeesR_sort, dg_pRecords)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Select Case TabControl1.SelectedIndex
            Case 0
                _dbConnection("db_lccsams")
                _loadToCombobox(slctC, cbo_course)
                _loadToCombobox(slctS, cbo_MS)
                _loadToCombobox(slctYL, cbo_yl)
                _loadToCombobox(slctSY, cbo_MSY)
                _loadToCombobox(slctFeesType, cbo_collFeesName)
                'Sort by
                _loadToCombobox(slctSY, cbo_SortSY)
                _loadToCombobox(slctC, cbo_SortCrs)
                _loadToCombobox(slctS, cbo_SortSem)
                _loadToCombobox(slctYL, cbo_SortYL)
                cbo_SortCrs.SelectedIndex = -1
                cbo_SortSem.SelectedIndex = -1
                cbo_SortYL.SelectedIndex = -1
                cbo_collFeesName.SelectedIndex = -1
            Case 1
                _dbConnection("db_lccsams")
                _loadToCombobox(eSelect_SY, cbo_eSY)
                _loadToCombobox(eSelect_SY, cbo_eSortSy)
                cbo_eSortSy.SelectedIndex = -1
                _loadToCombobox(slctFeesType, cbo_elemFeesType)
                cbo_elemFeesType.SelectedIndex = -1
            Case 2
                _dbConnection("db_lccsams")
                _loadToCombobox(sSelect_SY, cbo_sSY)
                _loadToCombobox(sSelect_SY, cbo_sSortSY)
                _loadToCombobox(slctFeesType, cbo_seniorFeesType)
                cbo_seniorFeesType.SelectedIndex = -1

                cbo_sSortSY.SelectedIndex = -1
            Case 3
                _dbConnection("db_lccsams")
                _loadToCombobox(jSelect_SY, cbo_jSY)
                _loadToCombobox(jSelect_SY, cbo_jSortSY)

                _loadToCombobox(slctFeesType, cbo_juniorFeesType)
                cbo_juniorFeesType.SelectedIndex = -1
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
        cbo_collFeesName.SelectedIndex = -1

        txtb_collAmnt.Clear()

        btn_add.Enabled = True
        btn_update.Enabled = True
        dg_pRecords.Enabled = True

        txtb_collAmnt.Enabled = False
        cbo_yl.Enabled = False
        cbo_course.Enabled = False
        cbo_MSY.Enabled = False
        cbo_MS.Enabled = False
        cbo_collFeesName.Enabled = False
        btn_save.Enabled = False
    End Sub


    '###########################################################Elementary Depatment Section##############################################################
    Dim b As Integer = 0
    Dim efees_id As Integer = 0


    Private Sub btn_eAdd_Click(sender As Object, e As EventArgs) Handles btn_eAdd.Click
        If dlg_addfees.ShowDialog() = DialogResult.OK Then
            cbo_eSY.Enabled = True
            cbo_elemFeesType.Enabled = True
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
        If dlg_updatefees.ShowDialog() = DialogResult.OK Then
            b = 2
            cbo_eSY.Enabled = True
            cbo_elemFeesType.Enabled = True
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
        cbo_elemFeesType.Enabled = False
        txtb_eFeeAmnt.Enabled = False

        btn_eAdd.Enabled = True
        btn_eUpdate.Enabled = True
        btn_eCancel.Enabled = False
        btn_eSave.Enabled = False
        dg_eFeesRec.Enabled = True
    End Sub

    Private Sub btn_eSave_Click(sender As Object, e As EventArgs) Handles btn_eSave.Click
        Dim efeesR As String = "select f.efees_id,ft.feestype_name, f.efees_amount from tbl_elem_fees f inner join tbl_fees_type ft on f.efees_name=ft.feestype_id where esy_id='" & cbo_eSortSy.SelectedValue & "' "
        Select Case b
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_elem_fees values (0,'" & cbo_elemFeesType.SelectedValue & "','" & txtb_eFeeAmnt.Text & "','" & cbo_eSY.SelectedValue & "')")

                If dlg_savesuccessfully.ShowDialog() = dlg_savesuccessfully.DialogResult.OK Then
                    _displayRecords(efeesR, dg_eFeesRec)
                    btn_eAdd.Enabled = True
                    btn_eUpdate.Enabled = True
                    btn_eCancel.Enabled = False
                    btn_eSave.Enabled = False
                    dg_eFeesRec.Enabled = True
                    cbo_eSY.Enabled = False
                    cbo_elemFeesType.Enabled = False
                    txtb_eFeeAmnt.Enabled = False
                End If
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_elem_fees set efees_name='" & cbo_elemFeesType.SelectedValue & "',efees_amount= '" & txtb_eFeeAmnt.Text & "' where efees_id='" & efees_id & "' ")


                If UpdatedSuccessfully.ShowDialog() = UpdatedSuccessfully.DialogResult.OK Then
                    _displayRecords(efeesR, dg_eFeesRec)
                    btn_eAdd.Enabled = True
                    btn_eUpdate.Enabled = True
                    btn_eCancel.Enabled = False
                    btn_eSave.Enabled = False
                    dg_eFeesRec.Enabled = True
                    cbo_eSY.Enabled = False
                    cbo_elemFeesType.Enabled = False
                    txtb_eFeeAmnt.Enabled = False

                End If


        End Select



    End Sub

    Private Sub cbo_eSortSy_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_eSortSy.SelectionChangeCommitted

        Try
            Dim eFeesR_sort As String = "select f.efees_id,ft.feestype_name, f.efees_amount from tbl_elem_fees f inner join tbl_fees_type ft on f.efees_name=ft.feestype_id where esy_id='" & cbo_eSortSy.SelectedValue & "' "
            _dbConnection("db_lccsams")

            txtb_eFeeAmnt.Clear()
            cbo_elemFeesType.SelectedIndex = -1
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
                cbo_elemFeesType.Text = .Item(1, s).Value.ToString
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
        If dlg_addfees.ShowDialog() = DialogResult.OK Then
            cbo_sSY.Enabled = True
            cbo_seniorFeesType.Enabled = True
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
        If dlg_updatefees.ShowDialog() = DialogResult.OK Then
            c = 2
            cbo_sSY.Enabled = True
            cbo_seniorFeesType.Enabled = True
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
        cbo_seniorFeesType.Enabled = False
        txtb_sFeeAmnt.Enabled = False


        btn_sAdd.Enabled = True
        btn_sUpdate.Enabled = True
        btn_sCancel.Enabled = False
        btn_sSave.Enabled = False
        dg_sfeesRec.Enabled = True
    End Sub

    Private Sub btn_sSave_Click(sender As Object, e As EventArgs) Handles btn_sSave.Click
        Dim sFeesR As String = "select f.sfees_id,ft.feestype_name, f.sfees_amount from tbl_senior_fees f inner join tbl_fees_type ft on f.sfees_name=ft.feestype_id  where ssy_id='" & cbo_sSortSY.SelectedValue & "' "

        Select Case c
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_senior_fees values (0,'" & cbo_seniorFeesType.SelectedValue & "','" & txtb_sFeeAmnt.Text & "','" & cbo_sSY.SelectedValue & "')")
                _displayRecords(sFeesR, dg_sfeesRec)
                If dlg_savesuccessfully.ShowDialog() = DialogResult.OK Then
                    cbo_sSY.Enabled = False
                    cbo_seniorFeesType.Enabled = False
                    txtb_sFeeAmnt.Enabled = False


                    btn_sAdd.Enabled = True
                    btn_sUpdate.Enabled = True
                    btn_sCancel.Enabled = False
                    btn_sSave.Enabled = False
                    dg_sfeesRec.Enabled = True
                End If
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_senior_fees  set sfees_name='" & cbo_seniorFeesType.SelectedValue & "', sfees_amount='" & txtb_sFeeAmnt.Text & "' where sfees_id='" & sfees_id & "'")
                btn_sUpdate.Enabled = True
                btn_sSave.Enabled = False
                If UpdatedSuccessfully.ShowDialog() = DialogResult.OK Then
                    _displayRecords(sFeesR, dg_sfeesRec)


                    btn_sAdd.Enabled = True
                    btn_sUpdate.Enabled = True
                    btn_sCancel.Enabled = False
                    btn_sSave.Enabled = False
                    dg_sfeesRec.Enabled = True
                End If


        End Select

    End Sub

    Private Sub cbo_sSortSY_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_sSortSY.SelectionChangeCommitted
        Try
            Dim sFeesR_sort As String = "select f.sfees_id,ft.feestype_name, f.sfees_amount from tbl_senior_fees f inner join tbl_fees_type ft on f.sfees_name=ft.feestype_id  where ssy_id='" & cbo_sSortSY.SelectedValue & "' "

            _dbConnection("db_lccsams")

            txtb_sFeeAmnt.Clear()
            cbo_seniorFeesType.SelectedIndex = -1
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
                cbo_seniorFeesType.Text = .Item(1, s).Value.ToString
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
        If dlg_addfees.ShowDialog() = DialogResult.OK Then
            cbo_jSY.Enabled = True
            cbo_juniorFeesType.Enabled = True
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
        If dlg_updatefees.ShowDialog() = DialogResult.OK Then
            d = 2
            cbo_jSY.Enabled = True
            cbo_juniorFeesType.Enabled = True
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
        cbo_juniorFeesType.Enabled = False
        txtb_jFeesAmnt.Enabled = False
        btn_jAdd.Enabled = True
        btn_jUpdate.Enabled = True
        btn_jCancel.Enabled = False
        btn_jSave.Enabled = False
        dg_jFeesRec.Enabled = True
    End Sub

    Private Sub btn_jSave_Click(sender As Object, e As EventArgs) Handles btn_jSave.Click
        Dim jFeesR As String = "select f.jfees_id,ft.feestype_name, f.jfees_amount from tbl_junior_fees f inner join tbl_fees_type on  f.jfees_name=ft.feestype_id where jsy_id='" & cbo_jSortSY.SelectedValue & "' "

        Select Case d
            Case 1

                _dbConnection("db_lccsams")
                _insertData("insert into tbl_junior_fees values (0,'" & cbo_juniorFeesType.SelectedValue & "','" & txtb_jFeesAmnt.Text & "','" & cbo_jSY.SelectedValue & "')")

                If dlg_savesuccessfully.ShowDialog() = DialogResult.OK Then
                    cbo_jSY.Enabled = False
                    cbo_juniorFeesType.Enabled = False
                    txtb_jFeesAmnt.Enabled = False
                    btn_jAdd.Enabled = True
                    btn_jUpdate.Enabled = True
                    btn_jCancel.Enabled = False
                    btn_jSave.Enabled = False
                    dg_jFeesRec.Enabled = True
                    _displayRecords(jFeesR, dg_jFeesRec)
                End If
            Case 2
                _dbConnection("db_lccsams")
                _updateData("update tbl_junior_fees set jfees_name='" & cbo_juniorFeesType.SelectedValue & "', jfees_amount='" & txtb_jFeesAmnt.Text & "' where jfees_id='" & jfees_id & "'")
                btn_sUpdate.Enabled = True
                btn_sSave.Enabled = False

                If UpdatedSuccessfully.ShowDialog() = DialogResult.OK Then
                    cbo_jSY.Enabled = False
                    cbo_juniorFeesType.Enabled = False
                    txtb_jFeesAmnt.Enabled = False
                    btn_jAdd.Enabled = True
                    btn_jUpdate.Enabled = True
                    btn_jCancel.Enabled = False
                    btn_jSave.Enabled = False
                    dg_jFeesRec.Enabled = True
                    _displayRecords(jFeesR, dg_jFeesRec)
                End If

        End Select

    End Sub
    Private Sub cbo_jSortSY_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_jSortSY.SelectionChangeCommitted
        Try
            Dim jFeesR_sort As String = "select f.jfees_id,ft.feestype_name, f.jfees_amount from tbl_junior_fees f inner join tbl_fees_type on  f.jfees_name=ft.feestype_id  where jsy_id='" & cbo_jSortSY.SelectedValue & "' "
            _dbConnection("db_lccsams")
            txtb_jFeesAmnt.Clear()
            cbo_juniorFeesType.SelectedIndex = -1
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
                cbo_juniorFeesType.Text = .Item(1, s).Value.ToString
                txtb_jFeesAmnt.Text = .Item(2, s).Value.ToString
            End With
        Catch ex As Exception
            MessageBox.Show("Error:", ex.Message)

        End Try
    End Sub


    Private Sub btn_managefeestype_Click(sender As Object, e As EventArgs) Handles btn_managefeestype.Click
        _loadToListBox(slctFeesType, manage_feesType.lbo_feesType)
        manage_feesType.ShowDialog()

    End Sub

    Private Sub cbo_collFeesName_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_collFeesName.SelectionChangeCommitted
        If cbo_collFeesName.SelectedValue = 2 Then
            lbl_tuitionFee.Visible = True
        Else
            lbl_tuitionFee.Visible = False
        End If
    End Sub

    Private Sub btn_manageStudentAcct_Click(sender As Object, e As EventArgs) Handles btn_manageStudentAcct.Click
        Dashboard.BunifuFlatButton6_Click(sender, e)
        manageStudentList = 1
    End Sub

    Private Sub btn_manageSchoolYear_Click(sender As Object, e As EventArgs) Handles btn_manageSchoolYear.Click
        Dashboard.BunifuFlatButton5_Click(sender, e)
        manageSY = 2
    End Sub
End Class
