Imports System.Data
Public Class frm_SPayments
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
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim DepartMent_level As Integer = TabControl1.SelectedIndex
        Try
            Select Case DepartMent_level
                Case 0
                    _loadStudentNameToTextbox(nameSuggestion, txtb_Search)
                    cboSearchBy.SelectedIndex = 1
                    lbl_tobepaid.Visible = False
                    totalAmount = 0
                Case 1
                    _loadStudentNameToTextbox(enameSuggestion, txtb_eSearch)
                    cbo_eSearchBy.SelectedIndex = 1
                    totalAmount = 0
                Case 2
                    _loadStudentNameToTextbox(snameSuggestion, txtb_sSearch)
                    cbo_sSearchBY.SelectedIndex = 1
                    totalAmount = 0
                Case 3
                    _loadStudentNameToTextbox(jnameSuggestion, txtb_sSearch)
                    cbo_jSearchBY.SelectedIndex = 1
                    totalAmount = 0
            End Select
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_SPayments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboSearchBy.SelectedIndex = 1
        cbo_eSearchBy.SelectedIndex = 1
        cbo_sSearchBY.SelectedIndex = 1
        cbo_jSearchBY.SelectedIndex = 1
        _loadStudentNameToTextbox(nameSuggestion, txtb_Search)
        _loadStudentNameToTextbox(enameSuggestion, txtb_eSearch)
        _loadStudentNameToTextbox(snameSuggestion, txtb_sSearch)
        _loadStudentNameToTextbox(jnameSuggestion, txtb_jSearch)

    End Sub

    '######################################################################College dept section####################################################################
    Dim cRtotal As Integer = 0

    Public Sub btn_Enter_Click(sender As Object, e As EventArgs) Handles btn_enter.Click
        If cboSearchBy.SelectedIndex = 1 Then
            _displayToTextbox_name()

        Else
            _displayToTextbox_id()
        End If
        lbl_name.Text = "Name: " + txtb_name.Text
        lbl_cashier.Text = cashier_name.ToUpper
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



    Sub _retrieveStudData()
        Try
            _dbConnection("db_lccsams")
            Dim student_id As Integer = 0
            Dim querry2 As String = " Select s.stud_id,s.stud_Fname,s.stud_midI,s.stud_Lname,sy.sy_name,sem.sem_name,yl.yl_name ,c.crs_name,sn.st_noUnits,sn.st_rateperunit,s.sy_id,s.yl_id,s.sem_id,s.crs_id from tbl_student s inner join tbl_sch_year sy on  sy.sy_id=s.sy_id inner join tbl_semester sem  on sem.sem_id=s.sem_id inner join tbl_year_level yl on yl.yl_id=s.yl_id inner join tbl_coll_course c on c.crs_id=s.crs_id  inner join tbl_studnounits sn   on s.sy_id=sn.sy_id and s.yl_id=sn.yl_id and s.sem_id=sn.sem_id and s.crs_id=sn.crs_id and s.stud_id=sn.stud_id where s.stud_Fname='" & fname & "' and s.stud_Lname='" & lname & "'"
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
                csy_id = Integer.Parse(dr(10).ToString)
                csem_id = Integer.Parse(dr(11).ToString)
                cyl_id = Integer.Parse(dr(12).ToString)
                ccrs_id = Integer.Parse(dr(12).ToString)

            End While
            dbConn.Close()
            Dim particular_list As String = "select f.fees_id, f.fees_name from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.sem_id=f.sem_id and s.yl_id=f.yl_id and s.crs_id=f.crs_id where s.stud_id='" & txtb_studID.Text & "'"
            _loadToCombobox(particular_list, cbo_particular)
            cbo_particular.SelectedIndex = -1
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
            Dim querry3 As String = " Select s.stud_id,s.stud_Fname,s.stud_midI,s.stud_Lname,sy.sy_name,sem.sem_name,yl.yl_name ,c.crs_name,sn.st_noUnits,sn.st_rateperunit,s.sy_id,s.yl_id,s.sem_id,s.crs_id from tbl_student s inner join tbl_sch_year sy on  sy.sy_id=s.sy_id inner join tbl_semester sem  on sem.sem_id=s.sem_id inner join tbl_year_level yl on yl.yl_id=s.yl_id inner join tbl_coll_course c on c.crs_id=s.crs_id  inner join tbl_studnounits sn   on s.sy_id=sn.sy_id and s.yl_id=sn.yl_id and s.sem_id=sn.sem_id and s.crs_id=sn.crs_id and s.stud_id=sn.stud_id where s.stud_id='" & txtb_Search.Text & "'"
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
                csy_id = Integer.Parse(dr(10).ToString)
                csem_id = Integer.Parse(dr(11).ToString)
                cyl_id = Integer.Parse(dr(12).ToString)
                ccrs_id = Integer.Parse(dr(12).ToString)
            End While
            dbConn.Close()
            Dim particular_list As String = "select f.fees_id, f.fees_name from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.sem_id=f.sem_id and s.yl_id=f.yl_id and s.crs_id=f.crs_id where s.stud_id='" & dr(0).ToString & "'"
            _loadToCombobox(particular_list, cbo_particular)
            cbo_particular.SelectedIndex = -1
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
        Dim querry1 = "Select ssy_sDate,sy_eDate from  tbl_sch_year  where sy_name='" & txtb_sy.Text & "' and sem_id='" & csem_id & "'"
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
                If txtb_Payment.Text = 0 And txtb_Payment.Text = "" And cbo_particular.Text = "" Then
                    MessageBox.Show("Please add payment!")
                Else

                    For Each row As DataGridViewRow In dg_viewCurrentPayment.Rows
                        Dim InsertPayments As String = "Insert into tbl_studaccount values('" & txtb_studID.Text & "','" & txtb_TransNo.Text & "','" & txtb_TransDate.Text & "','" & Integer.Parse(row.Cells(0).Value) & "','" & Double.Parse(row.Cells(2).Value) & "','" & Double.Parse(row.Cells(3).Value) & "','" & csy_id & "','" & cyl_id & "','" & csem_id & "','" & ccrs_id & "',0)"
                        _dbConnection("db_lccsams")
                        _insertData(InsertPayments)
                    Next
                    If dlg_payments.ShowDialog = DialogResult.OK Then
                        lbl_date.Text = txtb_TransDate.Text
                        lbl_orN.Text = "No. " + txtb_TransNo.Text
                        _clearCurrentStudData(btn_save.Text)
                        btn_Enter_Click(sender, e)
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbo_particular_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_particular.SelectionChangeCommitted
        lbl_tobepaid.Visible = True
        Dim CStud_FeeTypeToBePaid As String = "select f.fees_amount - ifNull(sum(sa.stdacct_tamount),0)as studAmountPaid,(f.fees_amount * '" & txtb_noUnits.Text & "') - ifNull(sum(sa.stdacct_tamount),0) as studAmntpaidRPu, tuition_rpu_id from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.sem_id=f.sem_id and s.yl_id=f.yl_id and s.crs_id=f.crs_id left join tbl_studaccount sa on sa.stdacct_tname=f.fees_id and s.stud_id=sa.stdacct_id where s.stud_id='" & txtb_studID.Text & "' and f.fees_id='" & cbo_particular.SelectedValue & "' "
        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(CStud_FeeTypeToBePaid, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                If dr(2) = 1 Then
                    lbl_tobepaid.Text = cbo_particular.Text & " to be paid: " & dr(1)
                Else
                    lbl_tobepaid.Text = cbo_particular.Text & " to be paid: " & dr(0)
                End If

            End While
        Catch ex As Exception
            erromessage("error 108: loadTolabel " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub



    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            If txtb_Payment.Text = "" Or txtb_Payment.Text = 0 Then
                MessageBox.Show("Please Input a payment")
            Else
                dg_viewCurrentPayment.Rows.Add(cbo_particular.SelectedValue, cbo_particular.Text, txtb_Payment.Text, txtb_CurrentBalance.Text)
                dg_receipts.Rows.Add(cbo_particular.Text, txtb_Payment.Text)
                totalAmount -= Double.Parse(txtb_Payment.Text)
                txtb_Payment.Text = 0


            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub dg_receipts_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dg_receipts.RowsAdded
        Dim total_amnt As Double
        For Each rowX As DataGridViewRow In dg_receipts.Rows
            total_amnt += Double.Parse(rowX.Cells(1).Value)
        Next
        lbl_tAmnt.Text = "TOTAL AMOUNT: " & total_amnt
        lbl_Tbal.Text = "BALANCE: " & totalAmount - total_amnt
    End Sub




    Private Sub btn_manage_Click(sender As Object, e As EventArgs) Handles btn_manage.Click
        Try
            Dashboard.btn_menuStudentsAccount_click(sender, e)
            current_menu = 1

        Catch ex As Exception
            MessageBox.Show(ex.Message)
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
                lbl_name.Text = "Name"

                txtb_TransNo.Clear()
                txtb_TransDate.Clear()
                cbo_particular.SelectedIndex = -1

                txtb_Payment.Text = 0
                txtb_CurrentAccount.Text = 0
                txtb_BackAccount.Text = 0
                txtb_TotalAmount.Text = 0
                txtb_CurrentBalance.Text = 0
                totalAmount = 0

                dg_viewCurrentPayment.Rows.Clear()
                dg_receipts.Rows.Clear()
                lbl_tAmnt.Text = "TOTAL AMOUNT:"
                lbl_Tbal.Text = "BALANCE:"
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
                dg_receipts.Rows.RemoveAt(dg_receipts.SelectedRows(0).Index)
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




    'Private Sub rbtn_partial_CheckedChanged(sender As Object, e As EventArgs)
    '    selectpaymentype()
    'End Sub

    'Private Sub rbtn_full_CheckedChanged(sender As Object, e As EventArgs)
    '    selectpaymentype()
    'End Sub
    'Sub selectpaymentype()
    '    If rbtn_partial.Checked = True Then
    '        txtb_Payment.Enabled = True
    '        lbl_tobepaid.Visible = True
    '        lbl_tobepaid.Text = "To be paid: " & 0
    '        txtb_Payment.Clear()
    '        'Dim diff As TimeSpan = Date.Parse(sSy_eDate) - Date.Parse(sSy_sDate)
    '        'Label30.Text = diff.Days.ToString
    '        lbl_tobepaid.Text = "Exam fee to be paid: " & Double.Parse(txtb_TotalAmount.Text)
    '    Else
    '        'txtb_Payment.Enabled = False
    '        'lbl_tobepaid.Visible = False
    '        'txtb_Payment.Text = txtb_TotalAmount.Text


    '    End If
    'End Sub
    <System.Runtime.InteropServices.DllImport("gdi32.dll")>
    Public Shared Function BitBlt(ByVal hdcDest As IntPtr, ByVal nXDest As Integer, ByVal nYDest As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hdcSrc As IntPtr,
 ByVal nXSrc As Integer, ByVal nYSrc As Integer, ByVal dwRop As Integer) As Long
    End Function
    'get the screenshot
    Private memoryImage As Bitmap
    Private Sub CaptureScreen()
        Dim mygraphics As Graphics = Me.pnl_receipts.CreateGraphics()
        Dim s As Size = Me.pnl_receipts.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.pnl_receipts.ClientRectangle.Width, Me.pnl_receipts.ClientRectangle.Height, dc1,
     0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub
    Private Sub print_collR_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles print_collR.PrintPage
        e.Graphics.DrawImage(memoryImage, 0, 0)
    End Sub
    Private Sub btn_PrintCreceipts_Click(sender As Object, e As EventArgs) Handles btn_PrintCreceipts.Click
        CaptureScreen()
        print_collR.Print()

        If dlg_printedsuccessfully.ShowDialog = DialogResult.OK Then
            dg_receipts.Rows.Clear()
            dg_viewCurrentPayment.Rows.Clear()
            dg_receipts.Rows.Clear()
            lbl_tAmnt.Text = "TOTAL AMOUNT:"
            lbl_Tbal.Text = "BALANCE:"
            lbl_name.Text = "Name: "
            lbl_orN.Text = "No. 00000"
            lbl_date.Text = "0000-00-00"
            totalAmount = 0
        End If

    End Sub
    ''###########################################################Elementary Section ################################################################################

    Private Sub btn_eManage_Click(sender As Object, e As EventArgs) Handles btn_eManage.Click
        Try
            current_menu = 1
            Dashboard.btn_menuStudentsAccount_click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Sub _clearECurrentStudData(ByVal btn As String)
        Select Case btn
            Case "SAVE"

                cbo_eParticulars.SelectedIndex = -1
                txtb_eStudAmntPay.Text = 0
                txtb_eStudCurrAcct.Text = 0
                txtb_eStudCurrBal.Text = 0


                totalAmount = 0

            Case "CLEAR"

                txtb_eSearch.Clear()
                txtb_eStudName.Clear()
                txtb_eStudID.Clear()
                txtb_eSY.Clear()
                txtb_eGL.Clear()
                lbl_name.Text = ""

                txtb_eTN.Clear()
                txtb_eTD.Clear()
                cbo_eParticulars.SelectedIndex = -1
                txtb_eStudAmntPay.Text = 0
                txtb_eStudCurrAcct.Text = 0
                txtb_eStudCurrBal.Text = 0
                txtb_eStudTotAmnt.Text = 0

                totalAmount = 0
        End Select
    End Sub

    Sub _retrieve_eStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry2 As String = "Select s.estud_id,s.estud_Fname,s.estud_mi,s.estud_Lname,sy.esy_name,gl.egl_name,s.esy_id,s.egl_id from tbl_elem_students s inner join tbl_elem_sy  sy on  sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on gl.egl_id=s.egl_id  where s.estud_Fname='" & eFname & "' and s.estud_Lname='" & eLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry2, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_eStudID.Text = dr(0).ToString
                txtb_eStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_eSY.Text = dr(4).ToString
                txtb_eGL.Text = dr(5).ToString
                eSy_id = dr(6).ToString
                egl_id = dr(7).ToString

            End While
            dbConn.Close()
            Dim particular_list As String = "select f.efees_id, f.efees_name from tbl_elem_fees f inner join tbl_elem_students s on s.esy_id=f.esy_id where s.estud_id='" & txtb_eStudID.Text & "'"
            _loadToCombobox(particular_list, cbo_eParticulars)
            cbo_eParticulars.SelectedIndex = -1

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    Sub display_estudData()
        Select Case cbo_eSearchBy.Text
            Case "Id Number"
                _dbConnection("db_lccsams")
                Try
                    Dim querry3 As String = " Select s.estud_id,s.estud_Fname,s.estud_mi,s.estud_Lname,sy.esy_name,gl.egl_name,s.esy_id,gl.egl_id  from tbl_elem_students s inner join tbl_elem_sy  sy on  sy.esy_id=s.esy_id inner join tbl_elem_gradelevel gl on gl.egl_id=s.egl_id   where s.estud_id='" & txtb_eSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(querry3, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read
                        txtb_eStudID.Text = dr(0).ToString
                        txtb_eStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_eSY.Text = dr(4).ToString
                        txtb_eGL.Text = dr(5).ToString
                        eSy_id = dr(6).ToString
                        egl_id = dr(7).ToString


                    End While
                    dbConn.Close()
                    Dim particular_list As String = "select f.efees_id, f.efees_name from tbl_elem_fees f inner join tbl_elem_students s on s.esy_id=f.esy_id where s.estud_id='" & txtb_eStudID.Text & "'"
                    _loadToCombobox(particular_list, cbo_eParticulars)
                    cbo_eParticulars.SelectedIndex = -1
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

    Sub _dateforeSy()
        Dim querry1 = "Select esy_sDate,esy_edate from  tbl_elem_sy  where esy_name='" & txtb_eSY.Text & "' "
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                Dim sd As Date = dr(0).ToString()
                Dim ed As Date = dr(1).ToString()

                esy_sDate = sd.ToString("yyyy-MM-dd")
                esy_eDate = ed.ToString("yyyy-MM-dd")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub _loadToEoldAccount()
        txtb_eStudOldAcct.Text = 0
        Dim totalFee As Double
        Dim totalPay As Double
        Dim querry1 As String = "SELECT ifnull(SUM(epay_amount),0) as total from tbl_elem_accounts  where estud_id='" & txtb_eStudID.Text & "' and  esy_id='" & eSy_id - 1 & "'  "
        Dim totalFees As String = "SELECT ifNull(SUM(efees_amount),0) as total from tbl_elem_fees where esy_id='" & eSy_id - 1 & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_eStudOldAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    Sub _loadToECurrentAccount()
        Dim totalFee As Double
        Dim totalPay As Double
        txtb_eStudCurrAcct.Text = 0
        Dim querry1 As String = "SELECT ifnull(SUM(epay_amount),0) as total from tbl_elem_accounts  where estud_id='" & txtb_eStudID.Text & "' and esy_id='" & eSy_id& & "' "
        Dim totalFees As String = "SELECT ifNull(SUM(efees_amount),0) as total from tbl_elem_fees where esy_id='" & eSy_id & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_eStudCurrAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub btn_eClear_Click(sender As Object, e As EventArgs) Handles btn_eClear.Click
        _clearECurrentStudData(btn_eClear.Text)
    End Sub
    Private Sub btn_eEnter_Click(sender As Object, e As EventArgs) Handles btn_eEnter.Click

        display_estudData()
        txtb_eTN.Text = random_TaN()
        _dateforeSy()
        txtb_eTD.Text = current_date.ToString("yyyy-MM-dd")
        _loadToEoldAccount()
        _loadToECurrentAccount()
        txtb_eStudTotAmnt.Text = _addOldCurrent(txtb_eStudCurrAcct, txtb_eStudOldAcct)
        totalAmount = Double.Parse(txtb_eStudTotAmnt.Text)


        lbl_eName.Text = "Name: " & txtb_eStudName.Text.ToUpper
        lbl_eTn.Text = "No. " & txtb_eTN.Text
        lbl_eDate.Text = txtb_eTD.Text
        lbl_cashierE.Text = cashier_name.ToUpper
        'transfer data to string
        eStud_id = Integer.Parse(txtb_eStudID.Text)
        eStudname = txtb_eStudName.Text
        eStudSY = txtb_eSY.Text
        eStudGL = txtb_eGL.Text
    End Sub
    Private Sub btn_eSave_Click(sender As Object, e As EventArgs) Handles btn_eSave.Click
        Try
            If txtb_eStudID.Text = "" Then
                MessageBox.Show("Please Select a student First!")
            Else


                For Each row As DataGridViewRow In dg_ePayment.Rows
                        Dim InsertPayments As String = "Insert into tbl_elem_accounts values('" & txtb_eStudID.Text & "','" & txtb_eTN.Text & "','" & txtb_eTD.Text & "','" & Integer.Parse(row.Cells(0).Value) & "','" & Double.Parse(row.Cells(2).Value) & "','" & Double.Parse(row.Cells(3).Value) & "','" & eSy_id & "','" & egl_id & "')"
                        _dbConnection("db_lccsams")
                        _insertData(InsertPayments)
                    Next
                If dlg_payments.ShowDialog = DialogResult.OK Then
                    dg_ePayment.Rows.Clear()
                    _clearECurrentStudData(btn_eSave.Text)

                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub txtb_eStudAmntPay_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_eStudAmntPay.KeyUp
        Try
            If txtb_eStudAmntPay.Text = "" Then
                txtb_eStudAmntPay.Text = 0
            End If
            txtb_eStudCurrBal.Text = totalAmount - Double.Parse(txtb_eStudAmntPay.Text)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CaptureEScreen()
        Dim mygraphics As Graphics = Me.pnl_elemReceipts.CreateGraphics()
        Dim s As Size = Me.pnl_elemReceipts.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.pnl_elemReceipts.ClientRectangle.Width, Me.pnl_elemReceipts.ClientRectangle.Height, dc1,
     0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub

    Private Sub btn_ePrint_Click(sender As Object, e As EventArgs) Handles btn_ePrint.Click
        CaptureEScreen()
        print_collR.Print()
        If dlg_printedsuccessfully.ShowDialog = DialogResult.OK Then
            txtb_eTN.Clear()
            txtb_eTD.Clear()

            dg_eReceipts.Rows.Clear()
            txtb_eStudTotAmnt.Text = 0
            btn_eEnter_Click(sender, e)
            lbl_eTamnt.Text = "TOTAL AMOUNT:"
            lbl_eBal.Text = "BALANCE:"
            lbl_eName.Text = "Name: "
            lbl_eTn.Text = "No. 00000"
            lbl_eDate.Text = "0000-00-00"
        End If
    End Sub

    Private Sub btn_eAdd_Click(sender As Object, e As EventArgs) Handles btn_eAdd.Click
        Try
            If txtb_eStudAmntPay.Text = "" Or txtb_eStudAmntPay.Text = 0 Or cbo_eParticulars.Text = "" Then
                MessageBox.Show("Please Input a payment")
            Else
                dg_ePayment.Rows.Add(cbo_eParticulars.SelectedValue, cbo_eParticulars.Text, txtb_eStudAmntPay.Text, txtb_eStudCurrBal.Text)
                dg_eReceipts.Rows.Add(cbo_eParticulars.Text, txtb_eStudAmntPay.Text)
                totalAmount -= Double.Parse(txtb_eStudAmntPay.Text)
                txtb_eStudAmntPay.Text = 0
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dg_ePayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ePayment.CellClick
        Try
            If dg_ePayment.Columns(e.ColumnIndex).Name = "delete_elemP" Then

                totalAmount += Double.Parse(dg_ePayment.Rows(e.RowIndex).Cells(2).Value)
                dg_ePayment.Rows.RemoveAt(dg_ePayment.SelectedRows(0).Index)
                dg_eReceipts.Rows.RemoveAt(dg_eReceipts.SelectedRows(0).Index)
                txtb_eStudAmntPay.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cbo_eParticulars_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_eParticulars.SelectionChangeCommitted

    End Sub

    '#############################################################Senior-High depatment Section#########################################################
    Sub _retrieve_sStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry2 As String = " Select s.sstud_id,s.sstud_Fname,s.sstud_mi,s.sstud_Lname,sy.ssy_name,gl.sgl_name,s.ssy_id,gl.sgl_id  from tbl_seniorhigh_students s inner join tbl_seniorhigh_sy  sy on  sy.ssy_id=s.ssy_id inner join tbl_seniorhigh_gl  gl on gl.sgl_id=s.sgl_id  where s.sstud_Fname='" & sFname & "' and s.sstud_Lname='" & sLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry2, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read
                txtb_sStudID.Text = dr(0).ToString
                txtb_sStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_sSY.Text = dr(4).ToString
                txtb_sGL.Text = dr(5).ToString
                sSy_id = dr(6).ToString
                sgl_id = dr(7).ToString

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
                    Dim querry3 As String = " Select s.sstud_id,s.sstud_Fname,s.sstud_mi,s.sstud_Lname,sy.ssy_name,gl.sgl_name,s.ssy_id,gl.sgl_id from tbl_seniorhigh_students s inner join tbl_seniorhigh_sy  sy on  sy.ssy_id=s.ssy_id inner join tbl_seniorhigh_gl  gl on gl.sgl_id=s.sgl_id   where s.sstud_id='" & txtb_sSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(querry3, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read
                        txtb_sStudID.Text = dr(0).ToString
                        txtb_sStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_sSY.Text = dr(4).ToString
                        txtb_sGL.Text = dr(5).ToString
                        sSy_id = dr(6).ToString
                        sgl_id = dr(7).ToString

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
    Sub _dateforsSy()
        Dim querry1 = "Select ssy_sdate,ssy_edate  from  tbl_seniorhigh_sy  where ssy_name='" & txtb_sSY.Text & "' "
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                Dim sd As Date = dr(0).ToString()
                Dim ed As Date = dr(1).ToString()
                sSy_sDate = sd.ToString("yyyy-MM-dd")
                sSy_eDate = ed.ToString("yyyy-MM-dd")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub _loadtosOldAccount()

        txtb_sOldAcct.Text = 0
        Dim totalFee As Double
        Dim totalPay As Double
        Dim querry1 As String = "SELECT ifnull(SUM(spay_amount),0)  as totalpay  from tbl_senior_accounts where sstud_id='" & txtb_sStudID.Text & "'  and ssy_id='" & sSy_id - 1 & "' "
        Dim totalFees As String = "SELECT ifNull(SUM(sfees_amount),0) as total from tbl_senior_fees where ssy_id='" & sSy_id - 1 & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_sOldAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try


    End Sub
    Sub _loadTosCurrentAccount()
        Dim totalFee As Double
        Dim totalPay As Double
        txtb_sCurrAcct.Text = 0
        Dim querry1 As String = "SELECT ifnull(SUM(spay_amount),0) as total from tbl_senior_accounts   where sstud_id='" & txtb_sStudID.Text & "' AND ssy_id='" & sSy_id & "' "
        Dim totalFees As String = "SELECT ifNull(SUM(sfees_amount),0) as total from tbl_senior_fees where ssy_id='" & sSy_id & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_sCurrAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub btn_sEnter_Click(sender As Object, e As EventArgs) Handles btn_sEnter.Click
        display_sstudData()
        txtb_sTN.Text = random_TaN()
        _dateforsSy()
        txtb_sTD.Text = current_date.ToString("yyyy-MM-dd")
        _loadtosOldAccount()
        _loadTosCurrentAccount()
        txtb_sToAmnt.Text = _addOldCurrent(txtb_sCurrAcct, txtb_sOldAcct)
        totalAmount = Double.Parse(txtb_sToAmnt.Text)

        lbl_cashierS.Text = cashier_name.ToUpper
        lbl_sName.Text = "Name: " & txtb_sStudName.Text
        lbl_sTn.Text = "No. " & txtb_sTN.Text
        lbl_sDate.Text = txtb_sTD.Text
        lbl_cashierS.Text = cashier_name.ToUpper

        'transfer data to string
        sStud_id = txtb_sStudID.Text
        sStudname = txtb_sStudName.Text
        sStudSY = txtb_sSY.Text
        sStudGL = txtb_sGL.Text
    End Sub
    Sub _clearsCurrentStudData(ByVal btn As String)
        Select Case btn
            Case "SAVE"

                cbo_sParticulars.SelectedIndex = -1
                txtb_sAmntPay.Text = 0
                txtb_sCurrAcct.Text = 0
                txtb_sOldAcct.Text = 0
                txtb_sCurrBal.Text = 0
                totalAmount = 0
            Case "CLEAR"

                txtb_sSearch.Clear()
                txtb_sStudName.Clear()
                txtb_sStudID.Clear()
                txtb_sSY.Clear()
                txtb_sGL.Clear()
                lbl_sName.Text = ""

                txtb_sTN.Clear()
                txtb_sTD.Clear()
                cbo_sParticulars.SelectedIndex = -1
                txtb_sAmntPay.Text = 0
                txtb_sCurrAcct.Text = 0
                txtb_sOldAcct.Text = 0
                txtb_sToAmnt.Text = 0
                txtb_sCurrBal.Text = 0
                totalAmount = 0
        End Select
    End Sub
    Private Sub btn_sClear_Click(sender As Object, e As EventArgs) Handles btn_sClear.Click
        _clearsCurrentStudData(btn_sClear.Text)
    End Sub
    Private Sub btn_sSave_Click(sender As Object, e As EventArgs) Handles btn_sSave.Click
        Try
            If txtb_sStudID.Text = "" Then
                MessageBox.Show("Please Select a student First!")
            Else
                If txtb_sAmntPay.Text = 0 And txtb_sAmntPay.Text = "" Then
                    MessageBox.Show("Please add payment!")
                Else

                    For Each row As DataGridViewRow In dg_sPayment.Rows
                        Dim InsertPayments As String = "Insert into tbl_senior_accounts values('" & txtb_sStudID.Text & "','" & txtb_sTN.Text & "','" & txtb_sTD.Text & "','" & Integer.Parse(row.Cells(0).Value) & "','" & Double.Parse(row.Cells(2).Value) & "','" & Double.Parse(row.Cells(3).Value) & "','" & sSy_id & "','" & sgl_id & "')"
                        _dbConnection("db_lccsams")
                        _insertData(InsertPayments)
                    Next
                    If dlg_payments.ShowDialog = DialogResult.OK Then
                        _clearsCurrentStudData(btn_eSave.Text)
                        dg_sPayment.Rows.Clear()
                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CapturesScreen()
        Dim mygraphics As Graphics = Me.pnl_sReceipts.CreateGraphics()
        Dim s As Size = Me.pnl_sReceipts.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.pnl_sReceipts.ClientRectangle.Width, Me.pnl_sReceipts.ClientRectangle.Height, dc1,
     0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub
    Private Sub btn_sPrint_Click(sender As Object, e As EventArgs) Handles btn_sPrint.Click
        CapturesScreen()
        print_collR.Print()
        If dlg_printedsuccessfully.ShowDialog = DialogResult.OK Then
            txtb_sTN.Clear()
            txtb_sTD.Clear()
            dg_sReceipts.Rows.Clear()
            txtb_sToAmnt.Text = 0
            btn_sEnter_Click(sender, e)
            lbl_sTamnt.Text = "TOTAL AMOUNT:"
            lbl_sBal.Text = "BALANCE:"
            lbl_sName.Text = "Name: "
            lbl_sTn.Text = "No. 00000"
            lbl_sDate.Text = "0000-00-00"
        End If
    End Sub


    Private Sub dg_sPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_sPayment.CellClick
        Try
            If dg_sPayment.Columns(e.ColumnIndex).Name = "delete_seniorP" Then

                totalAmount += Double.Parse(dg_sPayment.Rows(e.RowIndex).Cells(2).Value)
                dg_sPayment.Rows.RemoveAt(dg_sPayment.SelectedRows(0).Index)
                dg_sReceipts.Rows.RemoveAt(dg_sReceipts.SelectedRows(0).Index)
                txtb_sAmntPay.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub txtb_sAmntPay_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_sAmntPay.KeyUp
        Try
            If txtb_sAmntPay.Text = "" Then
                txtb_sAmntPay.Text = 0
            End If
            txtb_sCurrBal.Text = totalAmount - Double.Parse(txtb_sAmntPay.Text)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cbo_sParticulars_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_sParticulars.SelectionChangeCommitted

    End Sub

    Private Sub btn_sAdd_Click(sender As Object, e As EventArgs) Handles btn_sAdd.Click
        Try
            If txtb_sAmntPay.Text = "" Or txtb_sAmntPay.Text = 0 Then
                MessageBox.Show("Please Input a payment")
            Else
                dg_sPayment.Rows.Add(cbo_sParticulars.SelectedValue, cbo_sParticulars.Text, txtb_sAmntPay.Text, txtb_sCurrBal.Text)
                dg_sReceipts.Rows.Add(cbo_sParticulars.Text, txtb_sAmntPay.Text)
                totalAmount -= Double.Parse(txtb_sAmntPay.Text)
                txtb_sAmntPay.Text = 0


            End If
        Catch ex As Exception

        End Try

    End Sub
    '####################################################Junior-High department Section##################################################################
    Sub _retrieve_jStudData()
        Try
            _dbConnection("db_lccsams")
            Dim querry5 As String = " Select s.jstud_id,s.jstud_Fname,s.jstud_mi,s.jstud_Lname,sy.jsy_name,gl.jgl_name,s.jsy_id,gl.jgl_id from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy  sy on  sy.jsy_id=s.jsy_id inner join tbl_juniorhigh_gradelevel  gl on gl.jgl_id=s.jgl_id  where s.jstud_Fname='" & jFname & "' and s.jstud_Lname='" & jLname & "'"
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry5, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                txtb_jStudID.Text = dr(0).ToString
                txtb_jStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                txtb_jSY.Text = dr(4).ToString
                txtb_jGL.Text = dr(5).ToString
                jSy_id = dr(6).ToString
                jgl_id = dr(7).ToString

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
                    Dim selectjStudAcct As String = " Select s.jstud_id,s.jstud_Fname,s.jstud_mi,s.jstud_Lname,sy.jsy_name,gl.jgl_name,s.jsy_id,gl.jgl_id from tbl_juniorhigh_students s inner join tbl_juniorhigh_sy sy on  sy.jsy_id=s.jsy_id inner join tbl_junior_gradelevel gl on s.jgl_id=gl.jgl_id   where s.jstud_id='" & txtb_jSearch.Text & "'"
                    dbConn.Open()
                    sqlCommand = New MySqlCommand(selectjStudAcct, dbConn)
                    dr = sqlCommand.ExecuteReader
                    While dr.Read()
                        txtb_jStudID.Text = dr(0).ToString
                        txtb_jStudName.Text = dr(1).ToString.ToUpper + " " + dr(2).ToString.ToUpper + " " + dr(3).ToString.ToUpper
                        txtb_jSY.Text = dr(4).ToString
                        txtb_jGL.Text = dr(5).ToString
                        jSy_id = dr(6).ToString
                        jgl_id = dr(7).ToString

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
    Sub _dateforjSy()
        Dim querry1 = "Select jsy_sdate,jsy_edate from  tbl_juniorhigh_sy  where jsy_name='" & txtb_jSY.Text & "' "
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                Dim sd As Date = dr(0).ToString()
                Dim ed As Date = dr(1).ToString()
                jSy_sDate = sd.ToString("yyyy-MM-dd")
                jSy_eDate = ed.ToString("yyyy-MM-dd")
            End While

            dbConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Sub _loadtojOldAccount()

        txtb_jOldAcct.Text = 0
        Dim totalFee As Double
        Dim totalPay As Double
        Dim querry1 As String = "SELECT  ifnull(SUM(jpay_amount),0) as total from tbl_junior_accounts  where jstud_id='" & txtb_jStudID.Text & "'and jsy_id='" & jSy_id - 1 & "'"
        Dim totalFees As String = "SELECT ifNull(SUM(jfees_amount),0) as total from tbl_junior_fees where jsy_id='" & jSy_id - 1 & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_jOldAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub
    Sub _loadTojCurrentAccount()

        Dim totalFee As Double
        Dim totalPay As Double
        txtb_jCurrAcct.Text = 0
        Dim querry1 As String = "SELECT  ifnull(SUM(jpay_amount),0) as  total from tbl_junior_accounts  where jstud_id='" & txtb_jStudID.Text & "' and jsy_id='" & jSy_id & "'"
        Dim totalFees As String = "SELECT ifNull(SUM(jfees_amount),0) as total from tbl_junior_fees where jsy_id='" & jSy_id & "' "

        Try
            dbConn.Open()
            sqlCommand = New MySqlCommand(totalFees, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalFee = dr(0)
            End While
            dbConn.Close()
            dbConn.Open()
            sqlCommand = New MySqlCommand(querry1, dbConn)
            dr = sqlCommand.ExecuteReader
            While dr.Read()
                totalPay = dr(0)
            End While
            txtb_jCurrAcct.Text = totalFee - totalPay
        Catch ex As Exception
            erromessage("error 108: loadToTextbox " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub btn_jEnter_Click(sender As Object, e As EventArgs) Handles btn_jEnter.Click
        display_jstudData()
        txtb_jTN.Text = random_TaN()
        _dateforjSy()
        txtb_jTD.Text = current_date.ToString("yyyy-MM-dd")
        _loadtojOldAccount()
        _loadTojCurrentAccount()
        txtb_jToAmnt.Text = _addOldCurrent(txtb_jCurrAcct, txtb_jOldAcct)
        totalAmount = Double.Parse(txtb_jToAmnt.Text)


        lbl_cashierJ.Text = cashier_name.ToUpper
        lbl_jName.Text = "Name: " & txtb_jStudName.Text
        lbl_jOn.Text = "No. " & txtb_jTN.Text
        lbl_jDate.Text = txtb_jTD.Text
        lbl_cashierJ.Text = cashier_name.ToUpper
        'transfer data to string
        jStud_id = txtb_jStudID.Text
        jStudname = txtb_jStudName.Text
        jStudSY = txtb_jSY.Text
        jStudGL = txtb_jGL.Text
    End Sub
    Sub _clearjCurrentStudData(ByVal btn As String)
        Select Case btn
            Case "SAVE"

                cbo_jParticulars.SelectedIndex = -1
                txtb_jAmntPay.Text = 0
                txtb_jCurrAcct.Text = 0
                txtb_jOldAcct.Text = 0

                txtb_jCurrBal.Text = 0
                totalAmount = 0
            Case "CLEAR"

                txtb_jSearch.Clear()
                txtb_jStudName.Clear()
                txtb_jStudID.Clear()
                txtb_jSY.Clear()
                txtb_jGL.Clear()
                lbl_jName.Text = ""

                txtb_jSY.Clear()
                txtb_jTD.Clear()
                cbo_jParticulars.SelectedIndex = -1
                txtb_jAmntPay.Text = 0
                txtb_jCurrAcct.Text = 0
                txtb_jOldAcct.Text = 0
                txtb_jToAmnt.Text = 0
                txtb_jCurrBal.Text = 0
                totalAmount = 0
        End Select
    End Sub

    Private Sub btn_jClear_Click(sender As Object, e As EventArgs) Handles btn_jClear.Click
        _clearjCurrentStudData(btn_jClear.Text)
    End Sub

    Private Sub btn_jSave_Click(sender As Object, e As EventArgs) Handles btn_jSave.Click
        Try
            If txtb_jStudID.Text = "" Then
                MessageBox.Show("Please Select a student First!")
            Else
                If txtb_jAmntPay.Text = 0 And txtb_jAmntPay.Text = "" Then
                    MessageBox.Show("Please add payment!")
                Else

                    For Each row As DataGridViewRow In dg_jPayment.Rows
                        Dim InsertPayments As String = "Insert into tbl_junior_accounts values('" & txtb_jStudID.Text & "','" & txtb_jTN.Text & "','" & txtb_jTD.Text & "','" & Integer.Parse(row.Cells(0).Value) & "','" & Double.Parse(row.Cells(2).Value) & "','" & Double.Parse(row.Cells(3).Value) & "','" & jSy_id & "','" & jgl_id & "')"
                        _dbConnection("db_lccsams")
                        _insertData(InsertPayments)
                    Next
                    If dlg_payments.ShowDialog = DialogResult.OK Then
                        dg_jPayment.Rows.Clear()
                        _clearjCurrentStudData(btn_jSave.Text)

                    End If
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub CapturejScreen()
        Dim mygraphics As Graphics = Me.pnl_jReceipts.CreateGraphics()
        Dim s As Size = Me.pnl_jReceipts.Size
        memoryImage = New Bitmap(s.Width, s.Height, mygraphics)
        Dim memoryGraphics As Graphics = Graphics.FromImage(memoryImage)
        Dim dc1 As IntPtr = mygraphics.GetHdc()
        Dim dc2 As IntPtr = memoryGraphics.GetHdc()
        BitBlt(dc2, 0, 0, Me.pnl_jReceipts.ClientRectangle.Width, Me.pnl_jReceipts.ClientRectangle.Height, dc1,
     0, 0, 13369376)
        mygraphics.ReleaseHdc(dc1)
        memoryGraphics.ReleaseHdc(dc2)
    End Sub
    Private Sub btn_jPrint_Click(sender As Object, e As EventArgs) Handles btn_jPrint.Click

        CapturejScreen()
        print_collR.Print()
        If dlg_printedsuccessfully.ShowDialog = DialogResult.OK Then
            txtb_jSY.Clear()
            txtb_jTD.Clear()
            txtb_jToAmnt.Text = 0
            dg_jReceipts.Rows.Clear()
            btn_jEnter_Click(sender, e)
            lbl_jTamnt.Text = "TOTAL AMOUNT:"
            lbl_jBal.Text = "BALANCE:"
            lbl_jName.Text = "Name: "
            lbl_jOn.Text = "No. 00000"
            lbl_jDate.Text = "0000-00-00"
        End If
    End Sub



    Private Sub Print_Receipts_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        'Using Bm As New Bitmap(Me.pnl_receipts.Width)
    End Sub





    Private Sub dg_jPayment_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_jPayment.CellClick
        Try
            If dg_jPayment.Columns(e.ColumnIndex).Name = "delete_juniorP" Then

                totalAmount += Double.Parse(dg_jPayment.Rows(e.RowIndex).Cells(2).Value)
                dg_jPayment.Rows.RemoveAt(dg_jPayment.SelectedRows(0).Index)
                dg_jReceipts.Rows.RemoveAt(dg_jReceipts.SelectedRows(0).Index)
                txtb_jAmntPay.Text = 0
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub



    Private Sub txtb_jAmntPay_KeyUp(sender As Object, e As KeyEventArgs) Handles txtb_jAmntPay.KeyUp
        Try
            If txtb_jAmntPay.Text = "" Then
                txtb_jAmntPay.Text = 0
            End If
            txtb_jCurrBal.Text = totalAmount - Double.Parse(txtb_jAmntPay.Text)
        Catch ex As Exception
        End Try

    End Sub



    Private Sub cbo_jParticulars_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_jParticulars.SelectionChangeCommitted

    End Sub

    Private Sub btn_jAdd_Click(sender As Object, e As EventArgs) Handles btn_jAdd.Click
        Try
            If txtb_jAmntPay.Text = "" Or txtb_jAmntPay.Text = 0 Then
                MessageBox.Show("Please Input a payment")
            Else
                dg_jPayment.Rows.Add(cbo_jParticulars.SelectedValue, cbo_jParticulars.Text, txtb_jAmntPay.Text, txtb_jCurrBal.Text)
                dg_jReceipts.Rows.Add(cbo_jParticulars.Text, txtb_jAmntPay.Text)
                totalAmount -= Double.Parse(txtb_jAmntPay.Text)
                txtb_jAmntPay.Text = 0


            End If
        Catch ex As Exception

        End Try

    End Sub



    Private Sub dg_eReceipts_RowsAdded_1(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dg_eReceipts.RowsAdded
        Dim total_amnt As Double
        For Each rowX As DataGridViewRow In dg_eReceipts.Rows
            total_amnt += Double.Parse(rowX.Cells(1).Value)
        Next
        lbl_eTamnt.Text = "TOTAL AMOUNT: " & total_amnt
        lbl_eBal.Text = "BALANCE: " & Double.Parse(txtb_eStudTotAmnt.Text) - total_amnt
    End Sub

    Private Sub dg_sReceipts_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dg_sReceipts.RowsAdded
        Dim total_amnt As Double
        For Each rowX As DataGridViewRow In dg_sReceipts.Rows
            total_amnt += Double.Parse(rowX.Cells(1).Value)
        Next
        lbl_sTamnt.Text = "TOTAL AMOUNT: " & total_amnt
        lbl_sBal.Text = "BALANCE: " & Double.Parse(txtb_sToAmnt.Text) - total_amnt
    End Sub

    Private Sub dg_jReceipts_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dg_jReceipts.RowsAdded
        Dim total_amnt As Double
        For Each rowX As DataGridViewRow In dg_jReceipts.Rows
            total_amnt += Double.Parse(rowX.Cells(1).Value)
        Next
        lbl_jTamnt.Text = "TOTAL AMOUNT: " & total_amnt
        lbl_jBal.Text = "BALANCE: " & Double.Parse(txtb_jToAmnt.Text) - total_amnt
    End Sub

    Private Sub btn_sManage_Click(sender As Object, e As EventArgs) Handles btn_sManage.Click
        Try
            current_menu = 1
            Dashboard.btn_menuStudentsAccount_click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btn_jManage_Click(sender As Object, e As EventArgs) Handles btn_jManage.Click
        Try
            current_menu = 1
            Dashboard.btn_menuStudentsAccount_click(sender, e)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


End Class
