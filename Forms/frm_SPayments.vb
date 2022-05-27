Imports System.Data
Public Class frm_SPayments
    Dim Sem_id As Integer
    Dim totalAmount As Double
    Dim nameSuggestion As String = "Select stud_Fname,stud_Lname from tbl_student"
    Dim enameSuggestion As String = "select estud_fname,estud_lname from tbl_elem_students"
    Dim snameSuggestion As String = "Select sstud_fname, sstud_lname from tbl_seniorhigh_students"
    Dim jnameSuggestion As String = "Select jstud_Fname,jstud_Lname from tbl_juniorhigh_students"

    Function random_TaN() As Integer
        Dim tan_NO As Integer = 0
        'Create an instance of the Random class
        Dim rnd As New Random()
        'Get a random number from 10 to 99  (2 digits)
        tan_NO = rnd.Next(10, 100000)
        Return tan_NO
    End Function

    Public Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If cboSearchBy.SelectedIndex = 1 Then
            _displayToTextbox_name()
        Else
            _displayToTextbox_id()
        End If
        lbl_name.Text = "Name: " + txtb_name.Text
        txtb_TransNo.Text = random_TaN()
        txtb_TransDate.Text = current_date.ToString("yyyy-MM-dd")
        _dateforSemester()
        _loadToCurrentAccount()
        _loadToOldAccount()
        txtb_TotalAmount.Text = _addOldCurrent(txtb_BackAccount, txtb_CurrentAccount)
        totalAmount = Double.Parse(txtb_TotalAmount.Text)
        'transfer data to string
        stud_id = txtb_studID.Text
        stud_name = txtb_name.Text
        stud_sy = txtb_sy.Text
        stud_sem = txtb_sem.Text
        stud_yl = txtb_yL.Text
        stud_crs = txtb_course.Text
        stud_nUnits = txtb_noUnits.Text
        stud_rpu = txtb_rpu.Text
    End Sub

    Function _addOldCurrent(ByVal txb1 As TextBox, ByVal txb2 As TextBox) As Double
        Try
            Dim old As Double = 0
            Dim Curr As Double = 0
            old = Double.Parse(txb1.Text)
            Curr = Double.Parse(txb2.Text)
            totalAmount = old + Curr
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return totalAmount
    End Function


    Private Sub frm_SPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSearchBy.SelectedIndex = 1
        cbo_eSearchBy.SelectedIndex = 1
        cbo_sSearchBY.SelectedIndex = 1
        cbo_jSearchBY.SelectedIndex = 1
        _loadStudentNameToTextbox(nameSuggestion, txtb_Search)
        _loadStudentNameToTextbox(enameSuggestion, txtb_eSearch)
        _loadStudentNameToTextbox(snameSuggestion, txtb_sSearch)
        _loadStudentNameToTextbox(jnameSuggestion, txtb_jSearch)
        selectpaymentype()
    End Sub

    Sub _retrieveStudData()
        Try
            _dbConnection("db_lccsams")
            Dim student_id As Integer = 0
            Dim querry2 As String = " Select s.stud_id,s.stud_Fname,s.stud_midI,s.stud_Lname,sy.sy_name,sem.sem_name,yl.yl_name ,c.crs_name,sn.st_noUnits,sn.st_rateperunit,s.sem_id from tbl_student s inner join tbl_sch_year sy on  sy.sy_id=s.sy_id inner join tbl_semester sem  on sem.sem_id=s.sem_id inner join tbl_year_level yl on yl.yl_id=s.yl_id inner join tbl_coll_course c on c.crs_id=s.crs_id  inner join tbl_studnounits sn   on s.sy_id=sn.sy_id and s.yl_id=sn.yl_id and s.sem_id=sn.sem_id and s.crs_id=sn.crs_id and s.stud_id=sn.stud_id where s.stud_Fname='" & fname & "' and s.stud_Lname='" & lname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry2, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_studID.Text = dr(0).ToString
                txtb_name.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_sy.Text = dr(4).ToString
                txtb_sem.Text = dr(5).ToString
                txtb_yL.Text = dr(6).ToString
                txtb_course.Text = dr(7).ToString
                txtb_noUnits.Text = dr(8).ToString
                txtb_rpu.Text = dr(9).ToString
                Sem_id = Integer.Parse(dr(10).ToString)
                student_id = Integer.Parse(dr(0).ToString)
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.fees_id, f.fees_name from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.sem_id=f.sem_id and s.yl_id=f.yl_id and s.crs_id=f.crs_id where s.stud_id='" & student_id & "'"
            _loadToCombobox(particular_list, cbo_particular)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub _displayToTextbox_name()

        Try
            Dim sp() As String
            sp = txtb_Search.Text.Split(" ")
            If UBound(sp) = 1 Then
                fname = sp(0)
                lname = sp(1)
                _retrieveStudData()
            ElseIf UBound(sp) = 2 Then
                fname = sp(0) + " " + sp(1)
                lname = sp(2)
                _retrieveStudData()
            Else
                _retrieveStudData()
            End If
        Catch ex As Exception
            MessageBox.Show("please retry and select format in the suggestion")
        Finally
            dbConn.Close()
        End Try
    End Sub

    Sub _displayToTextbox_id()
        _dbConnection("db_lccsams")
        Try
            Dim querry3 As String = " Select s.stud_id,s.stud_Fname,s.stud_midI,s.stud_Lname,sy.sy_name,sem.sem_name,yl.yl_name ,c.crs_name,sn.st_noUnits,sn.st_rateperunit from tbl_student s inner join tbl_sch_year sy on  sy.sy_id=s.sy_id inner join tbl_semester sem  on sem.sem_id=s.sem_id inner join tbl_year_level yl on yl.yl_id=s.yl_id inner join tbl_coll_course c on c.crs_id=s.crs_id  inner join tbl_studnounits sn   on s.sy_id=sn.sy_id and s.yl_id=sn.yl_id and s.sem_id=sn.sem_id and s.crs_id=sn.crs_id and s.stud_id=sn.stud_id where s.stud_id='" & txtb_Search.Text & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry3, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_studID.Text = dr(0).ToString
                txtb_name.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_sy.Text = dr(4).ToString
                txtb_sem.Text = dr(5).ToString
                txtb_yL.Text = dr(6).ToString
                txtb_course.Text = dr(7).ToString
                txtb_noUnits.Text = dr(8).ToString
                txtb_rpu.Text = dr(9).ToString
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.fees_id, f.fees_name from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.sem_id=f.sem_id and s.yl_id=f.yl_id and s.crs_id=f.crs_id where s.stud_id='" & dr(0).ToString & "'"
            _loadToCombobox(particular_list, cbo_particular)
        Catch ex As Exception
        Finally
            dbConn.Close()
        End Try
    End Sub

    Sub _loadToCurrentAccount()

        Dim querry1 As String = "select f.fees_amount,f.tuition_rpu_id from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.yl_id=f.yl_id and s.sem_id=f.sem_id and s.crs_id=f.crs_id  where s.stud_id='" & txtb_studID.Text & "' "
        Try
            Dim totalfees As Double
            dbConn.Open()
            da = New MySqlDataAdapter(querry1, dbConn)
            dt = New DataTable
            da.Fill(dt)
            For Each r As DataRow In dt.Rows
                If Integer.Parse(r.Item(1).ToString) = 1 Then
                    r.Item(0) = Double.Parse(r.Item(0).ToString) * Double.Parse(txtb_noUnits.Text)
                End If
                totalfees += Double.Parse(r.Item(0).ToString)
            Next
            dbConn.Close()
            Dim querry2 As String = "select st.stdacct_tAmount  from tbl_studaccount st  inner join  tbl_student s on s.stud_id=st.stdacct_id where s.stud_id='" & txtb_studID.Text & "' and stdacct_tDate between '" & sy_sDate & "' and '" & sy_eDate & "' order by stdacct_tDate desc "
            Dim totalCurrAccount As Double
            dbConn.Open()
            da = New MySqlDataAdapter(querry2, dbConn)
            dt = New DataTable
            da.Fill(dt)
            For Each rc As DataRow In dt.Rows
                totalCurrAccount += Double.Parse(rc.Item(0).ToString)
            Next
            txtb_CurrentAccount.Text = totalfees - totalCurrAccount
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    Sub _dateforSemester()
        Dim querry1 = "Select ssy_sDate,sy_eDate from  tbl_sch_year  where sy_name='" & txtb_sy.Text & "' and sem_id='" & Sem_id & "'"
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                Dim sd As Date = dr(0).ToString()
                Dim ed As Date = dr(1).ToString()
                sy_sDate = sd.ToString("yyyy-MM-dd")
                sy_eDate = ed.ToString("yyyy-MM-dd")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub _loadToOldAccount()
        Dim querry1 As String = "select st.stdacct_tBalance from tbl_studaccount  st inner join tbl_student  s on s.stud_id=st.stdacct_id where s.stud_id='" & txtb_studID.Text & "' and stdacct_tDate < '" & sy_sDate & "' order by stdacct_tDate desc"
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            da = New MySqlDataAdapter(querry1, dbConn)
            dt = New DataTable
            da.Fill(dt)
            Dim count As Integer = 0
            txtb_BackAccount.Text = 0
            For Each r As DataRow In dt.Rows
                txtb_BackAccount.Text = Double.Parse(r.Item(0).ToString)
                count += 1
                If count > 0 Then
                    Exit For
                End If

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub txtb_Payment_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_Payment.KeyUp
        Try
            If txtb_Payment.Text = "" Then
                txtb_Payment.Text = 0
            End If
            txtb_CurrentBalance.Text = totalAmount - Double.Parse(txtb_Payment.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If txtb_studID.Text = "" Then
                MessageBox.Show("Please Select a student First!")
            Else
                If txtb_Payment.Text = 0 And txtb_Payment.Text = "" Then
                    MessageBox.Show("Please add payment!")
                Else

                    'For Each row As DataGridViewRow In dg_viewCurrentPayment.Rows
                    '    Dim InsertPayments As String = "Insert into tbl_studaccount values('" & txtb_studID.Text & "','" & txtb_TransNo.Text & "','" & txtb_TransDate.Text & "','" & Integer.Parse(row.Cells("fees_id").Value) & "','" & Double.Parse(row.Cells("t_amount").Value) & "','" & Double.Parse(row.Cells("t_balance").Value) & "')"
                    '    _dbConnection("db_lccsams")
                    '    _insertData(InsertPayments)
                    'Next
                    Dim InsertPayments As String = "Insert into tbl_studaccount values('" & txtb_studID.Text & "','" & txtb_TransNo.Text & "','" & txtb_TransDate.Text & "','" & Integer.Parse(cbo_particular.SelectedValue) & "','" & Double.Parse(txtb_Payment.Text) & "','" & Double.Parse(txtb_CurrentBalance.Text) & "')"
                    _dbConnection("db_lccsams")
                    _insertData(InsertPayments)
                    If dlg_payments.ShowDialog = DialogResult.OK Then
                        lbl_particularName.Text = cbo_particular.Text
                        lbl_amount.Text = txtb_Payment.Text
                        lbl_tAmnt.Text = "TOTAL AMOUNT: " & txtb_Payment.Text
                        lbl_Tbal.Text = "BALANCE: " & txtb_CurrentBalance.Text
                        _clearCurrentStudData(btn_save.Text)
                        btn_Enter_Click(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txtb_Payment.Text = "" Or txtb_Payment.Text = 0 Then
                MessageBox.Show("Please Input a payment")
            Else
                dg_viewCurrentPayment.Rows.Add(cbo_particular.SelectedValue, cbo_particular.Text, txtb_Payment.Text, txtb_CurrentBalance.Text)
                totalAmount -= Double.Parse(txtb_Payment.Text)
                txtb_Payment.Text = 0
                lbl_particularName.Text = ""
                lbl_particularName.Text += cbo_particular.Text & vbCrLf
                lbl_amount.Text = ""
                lbl_amount.Text += txtb_Payment.Text & vbCrLf

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtb_TransNo_TextChanged(sender As Object, e As EventArgs) Handles txtb_TransNo.TextChanged
        lbl_orN.Text = "No. " + txtb_TransNo.Text
    End Sub

    Private Sub txtb_TransDate_TextChanged(sender As Object, e As EventArgs) Handles txtb_TransDate.TextChanged
        lbl_date.Text = txtb_TransDate.Text
    End Sub

    Private Sub btn_manage_Click(sender As Object, e As EventArgs) Handles btn_manage.Click
        Try
            Dashboard.btn_menuStudentsAccount_click(sender, e)
            current_menu = 1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim DepartMent_level As Integer = TabControl1.SelectedIndex
        Try
            Select Case DepartMent_level
                Case 0
                    _loadStudentNameToTextbox(nameSuggestion, txtb_Search)
                    cboSearchBy.SelectedIndex = 1


                Case 1
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Sub _clearCurrentStudData(ByVal btn As String)
        Select Case btn
            Case "SAVE"
                txtb_TransNo.Clear()
                txtb_TransDate.Clear()
                cbo_particular.SelectedIndex = -1
                txtb_Payment.Text = 0
                txtb_CurrentAccount.Text = 0
                txtb_BackAccount.Text = 0
                txtb_TotalAmount.Text = 0
                txtb_CurrentBalance.Text = 0
                dg_viewCurrentPayment.Rows.Clear()
                totalAmount = 0

            Case "CLEAR"

                txtb_Search.Clear()
                txtb_name.Clear()
                txtb_studID.Clear()
                txtb_sy.Clear()
                txtb_sem.Clear()
                txtb_yL.Clear()
                txtb_course.Clear()
                txtb_noUnits.Clear()
                txtb_rpu.Clear()
                lbl_name.Text = ""

                txtb_TransNo.Clear()
                txtb_TransDate.Clear()
                cbo_particular.SelectedIndex = -1

                txtb_Payment.Text = 0
                txtb_CurrentAccount.Text = 0
                txtb_BackAccount.Text = 0
                txtb_TotalAmount.Text = 0
                txtb_CurrentBalance.Text = 0
                totalAmount = 0
        End Select





    End Sub


    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        _clearCurrentStudData(btn_clear.Text)
    End Sub

    Private Sub dg_viewCurrentPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_viewCurrentPayment.CellClick
        Try
            If dg_viewCurrentPayment.Columns(e.ColumnIndex).Name = "delete" Then

                totalAmount += Double.Parse(dg_viewCurrentPayment.Rows(e.RowIndex).Cells(2).Value)
                dg_viewCurrentPayment.Rows.RemoveAt(dg_viewCurrentPayment.SelectedRows(0).Index)
                txtb_Payment.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub txtb_Payment_TextChanged(sender As Object, e As EventArgs) Handles txtb_Payment.TextChanged
        Try
            If txtb_Payment.Text = "" Then
                txtb_Payment.Text = 0
            End If
            txtb_CurrentBalance.Text = totalAmount - Double.Parse(txtb_Payment.Text)
        Catch ex As Exception
        End Try
    End Sub



    '################################################################################################ElemenTary Section######################################################
    Private Sub btn_eManage_Click(sender As Object, e As EventArgs) Handles btn_eManage.Click
        Try
            current_menu = 1
            Dashboard.btn_menuStudentsAccount_click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub rbtn_partial_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_partial.CheckedChanged
        selectpaymentype()
    End Sub

    Private Sub rbtn_full_CheckedChanged(sender As Object, e As EventArgs) Handles rbtn_full.CheckedChanged
        selectpaymentype()
    End Sub
    Sub selectpaymentype()
        If rbtn_partial.Checked = True Then
            txtb_Payment.Enabled = True
            lbl_tobepaid.Visible = True
            lbl_tobepaid.Text = "To be paid: " & 0
            txtb_Payment.Clear()
            'Dim diff As TimeSpan = Date.Parse(sSy_eDate) - Date.Parse(sSy_sDate)
            'Label30.Text = diff.Days.ToString
            lbl_tobepaid.Text = "Exam fee to be paid: " & Double.Parse(txtb_TotalAmount.Text)
        Else
            txtb_Payment.Enabled = False
            lbl_tobepaid.Visible = False
            txtb_Payment.Text = txtb_TotalAmount.Text


        End If
    End Sub
    Sub dateIntervalFortheSem()

    End Sub
    ''###########################################################Elementary Section ################################################################################
    Sub _retrieve_eStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry2 As String = "Select s.estud_id,s.estud_Fname,s.estud_mi,s.estud_Lname,sy.esy_name,gl.egl_name from tbl_elem_students s inner join tbl_elem_sy  sy on  sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on gl.egl_id=s.egl_id  where s.estud_Fname='" & eFname & "' and s.estud_Lname='" & eLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry2, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_eStudID.Text = dr(0).ToString
                txtb_eStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_eSY.Text = dr(4).ToString
                txtb_eGL.Text = dr(5).ToString
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.efees_id, f.efees_name from tbl_elem_fees f inner join tbl_elem_students s on s.esy_id=f.esy_id where s.estud_id='" & txtb_eStudID.Text & "'"
            _loadToCombobox(particular_list, cbo_eParticulars)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub display_estudData()
        Select Case cbo_eSearchBy.Text
            Case "Id Number"
                _dbConnection("db_lccsams")
                Try
                    Dim querry3 As String = " Select s.estud_id,s.estud_Fname,s.estud_mi,s.estud_Lname,sy.esy_name,gl.egl_name from tbl_elem_students s inner join tbl_elem_sy  sy on  sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on gl.egl_id=s.egl_id   where s.estud_id='" & txtb_eSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(querry3, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read
                        txtb_eStudID.Text = dr(0).ToString
                        txtb_eStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_eSY.Text = dr(4).ToString
                        txtb_eGL.Text = dr(5).ToString
                    End While
                    dbConn.Close()
                    Dim particular_list As String = "select f.efees_id, f.efees_name from tbl_elem_fees f inner join tbl_elem_students s on s.esy_id=f.esy_id where s.estud_id='" & txtb_eStudID.Text & "'"
                    _loadToCombobox(particular_list, cbo_eParticulars)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try

            Case "Name"
                Try
                    Dim sp() As String
                    sp = txtb_eSearch.Text.Split(" ")
                    If UBound(sp) = 1 Then
                        eFname = sp(0)
                        eLname = sp(1)
                        _retrieve_eStudData()
                    ElseIf UBound(sp) = 2 Then
                        eFname = sp(0) + " " + sp(1)
                        eLname = sp(2)
                        _retrieveStudData()
                    Else

                        _retrieveStudData()
                    End If
                Catch ex As Exception
                    MessageBox.Show("please retry and select format in the suggestion")
                Finally
                    dbConn.Close()
                End Try
            Case Else
                MessageBox.Show("please retry and select format in the suggestion")

        End Select
    End Sub


    Private Sub btn_eClear_Click(sender As Object, e As EventArgs) Handles btn_eClear.Click

    End Sub
    Private Sub btn_eEnter_Click(sender As Object, e As EventArgs) Handles btn_eEnter.Click
        display_estudData()
    End Sub
    Private Sub btn_eSave_Click(sender As Object, e As EventArgs) Handles btn_eSave.Click

    End Sub
    Private Sub btn_ePrint_Click(sender As Object, e As EventArgs) Handles btn_ePrint.Click

    End Sub
    '#############################################################Senior-High depatment Section#########################################################
    Sub _retrieve_sStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry2 As String = " Select s.sstud_id,s.sstud_Fname,s.sstud_mi,s.sstud_Lname,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students s inner join tbl_seniorhigh_sy  sy on  sy.ssy_id=s.ssy_id inner join tbl_seniorhigh_gl  gl on gl.sgl_id=s.sgl_id  where s.sstud_Fname='" & sFname & "' and s.sstud_Lname='" & sLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry2, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_sStudID.Text = dr(0).ToString
                txtb_sStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_sSY.Text = dr(4).ToString
                txtb_sGL.Text = dr(5).ToString
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.sfees_id, f.sfees_name from tbl_senior_fees f inner join tbl_seniorhigh_students s on s.ssy_id=f.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  where s.sstud_id='" & txtb_sStudID.Text & "'"
            _loadToCombobox(particular_list, cbo_sParticulars)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub display_sstudData()
        Select Case cbo_eSearchBy.Text
            Case "Id Number"
                _dbConnection("db_lccsams")
                Try
                    Dim querry3 As String = " Select s.sstud_id,s.sstud_Fname,s.sstud_mi,s.sstud_Lname,sy.ssy_name,gl.sgl_name from tbl_seniorhigh_students s inner join tbl_seniorhigh_sy  sy on  sy.ssy_id=s.ssy_id inner join tbl_seniorhigh_gl  gl on gl.sgl_id=s.sgl_id   where s.sstud_id='" & txtb_sSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(querry3, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read
                        txtb_sStudID.Text = dr(0).ToString
                        txtb_sStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_sSY.Text = dr(4).ToString
                        txtb_sGL.Text = dr(5).ToString
                    End While
                    dbConn.Close()
                    Dim particular_list As String = "select f.sfees_id, f.sfees_name from tbl_senior_fees f inner join tbl_seniorhigh_students s on s.ssy_id=f.ssy_id inner join tbl_seniorhigh_gl gl on s.sgl_id=gl.sgl_id  where s.sstud_id='" & txtb_sStudID.Text & "'"
                    _loadToCombobox(particular_list, cbo_sParticulars)
                Catch ex As Exception
                Finally
                    dbConn.Close()
                End Try

            Case "Name"
                Try
                    Dim sp() As String
                    sp = txtb_sSearch.Text.Split(" ")
                    If UBound(sp) = 1 Then
                        sFname = sp(0)
                        sLname = sp(1)
                        _retrieve_sStudData()
                    ElseIf UBound(sp) = 2 Then
                        sFname = sp(0) + " " + sp(1)
                        sLname = sp(2)
                        _retrieve_sStudData()
                    Else

                        _retrieve_sStudData()
                    End If
                Catch ex As Exception
                    MessageBox.Show("please retry and select format in the suggestion")
                Finally
                    dbConn.Close()
                End Try
        End Select
    End Sub

    Private Sub btn_sEnter_Click(sender As Object, e As EventArgs) Handles btn_sEnter.Click
        display_sstudData()
    End Sub

    Private Sub btn_sClear_Click(sender As Object, e As EventArgs) Handles btn_sClear.Click

    End Sub
    Private Sub btn_sSave_Click(sender As Object, e As EventArgs) Handles btn_sSave.Click

    End Sub
    Private Sub btn_sPrint_Click(sender As Object, e As EventArgs) Handles btn_sPrint.Click

    End Sub
    '####################################################Junior-High department Section##################################################################
    Sub _retrieve_jStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry5 As String = " Select s.jstud_id,s.jstud_Fname,s.jstud_mi,s.jstud_Lname,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy  sy on  sy.jsy_id=s.jsy_id inner join tbl_juniorhigh_gradelevel  gl on gl.jgl_id=s.jgl_id  where s.jstud_Fname='" & jFname & "' and s.jstud_Lname='" & jLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry5, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_jStudID.Text = dr(0).ToString
                txtb_jStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_jSY.Text = dr(4).ToString
                txtb_jGL.Text = dr(5).ToString
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.jfees_id, f.jfees_name from tbl_junior_fees f inner join tbl_juniorhigh_students s on s.jsy_id=f.jsy_id  where s.jstud_id='" & txtb_jStudID.Text & "'"
            _loadToCombobox(particular_list, cbo_jParticulars)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub display_jstudData()
        Select Case cbo_jSearchBY.Text
            Case "Id Number"
                Try
                    _dbConnection("db_lccsams")
                    Dim selectjStudAcct As String = " Select s.jstud_id,s.jstud_Fname,s.jstud_mi,s.jstud_Lname,sy.jsy_name,gl.jgl_name from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy on  sy.jsy_id=s.jsy_id  where s.jstud_id='" & txtb_jSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(selectjStudAcct, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read
                        txtb_jStudID.Text = dr(0).ToString
                        txtb_jStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_jSY.Text = dr(4).ToString
                        txtb_jGL.Text = dr(5).ToString
                    End While
                    dbConn.Close()
                    Dim particular_list As String = "select f.jfees_id, f.jfees_name from tbl_junior_fees f inner join tbl_juniorhigh_students s on s.jsy_id=f.jsy_id where s.jstud_id='" & txtb_jStudID.Text & "'"
                    _loadToCombobox(particular_list, cbo_jParticulars)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try

            Case "Name"
                Try
                    Dim sp() As String
                    sp = txtb_jSearch.Text.Split(" ")
                    If UBound(sp) = 1 Then
                        jFname = sp(0)
                        jLname = sp(1)
                        _retrieve_jStudData()
                    ElseIf UBound(sp) = 2 Then
                        jFname = sp(0) + " " + sp(1)
                        jLname = sp(2)
                        _retrieve_jStudData()
                    Else
                        _retrieve_jStudData()
                    End If
                Catch ex As Exception
                    MessageBox.Show("please retry and select format in the suggestion!")
                Finally
                    dbConn.Close()
                End Try
        End Select
    End Sub

    Private Sub btn_jEnter_Click(sender As Object, e As EventArgs) Handles btn_jEnter.Click
        display_jstudData()
    End Sub

    Private Sub btn_jClear_Click(sender As Object, e As EventArgs) Handles btn_jClear.Click

    End Sub

    Private Sub btn_jSave_Click(sender As Object, e As EventArgs) Handles btn_jSave.Click

    End Sub

    Private Sub btn_jPrint_Click(sender As Object, e As EventArgs) Handles btn_jPrint.Click

    End Sub
End Class
