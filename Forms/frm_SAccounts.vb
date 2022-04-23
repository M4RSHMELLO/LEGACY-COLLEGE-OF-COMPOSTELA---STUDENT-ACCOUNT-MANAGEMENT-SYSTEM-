Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frm_SAccounts

    Public Sub frm_SAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _dbConnection("db_lccsams")
        _loadToCombobox(slctSY, cbo_sortSY)
        _loadToCombobox(slctS, cbo_sortSem)
    End Sub

    Public Sub txtb_studAcct_ID_Click(sender As Object, e As EventArgs) Handles txtb_studAcct_ID.Click
        Dim displayFees = "Select  f.fees_id,f.fees_name,f.fees_amount,tuition_rpu_id from tbl_coll_fees f inner join tbl_student s on s.sy_id=f.sy_id and s.yl_id=f.yl_id and s.sem_id=f.sem_id and s.crs_id=f.crs_id where stud_id='" & stud_id & "'"
        Dim total_fees As Double = 0
        _dbConnection("db_lccsams")
        _shareID(txtb_studAcct_ID)
        load_stud_data()
        cbo_sortSem.Text = stud_sem
        _displayRecords(displayFees, dg_studFeesType)
        _displayStudAccount()
        For Each rowX As DataGridViewRow In dg_studFeesType.Rows
            If rowX.Cells("rpu_id").Value = 1 Then
                rowX.Cells("FeesAmount").Value = rowX.Cells("FeesAmount").Value * txtb_nUnits.Text
            End If
            total_fees += rowX.Cells("FeesAmount").Value
        Next
        txtb_totalFees.Text = total_fees
        _displayTotalForEachparticulars()
    End Sub
    Sub load_stud_data()
        Try
            txtStudentName.Text = stud_name
            txtb_sy.Text = stud_sy
            txtb_sem.Text = stud_sem
            txtb_crs.Text = stud_crs
            txtb_yl.Text = stud_yl
            txtb_nUnits.Text = stud_nUnits
            txtb_rpu.Text = stud_rpu
        Catch ex As Exception
        End Try
    End Sub



    Private Sub cbo_sortSem_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbo_sortSem.SelectionChangeCommitted
        _displayStudAccount()
    End Sub

    Sub _displayStudAccount()
        Dim querry1 = "Select ssy_sDate,sy_eDate from  tbl_sch_year where sy_name='" & cbo_sortSY.Text & "' and sem_id='" & cbo_sortSem.SelectedValue & "'"
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
            dbConn.Open()
            Dim querry2 = "Select sa.stdacct_id,sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount,sa.stdacct_tBalance from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  where sa.stdacct_id='" & stud_id & "' and sa.stdacct_tDate between '" & sy_sDate & "' and '" & sy_eDate & "' order by sa.stdacct_tDate desc , sa.stdacct_tBalance asc"
            da = New MySqlDataAdapter(querry2, dbConn)
            dt = New DataTable
            da.Fill(dt)
            dg_acctRec.DataSource = dt
        Catch ex As Exception
            erromessage("error 108: Retrieve Specific Data to DataGrid " & ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Sub _displayTotalForEachparticulars()
        Try
            Dim totalStudFees As Double = 0
            _dbConnection("db_lccsams")
            dg_displayTotalFees.Rows.Clear()
            txtb_totalFeesAmount.Clear()
            txtb_totalBal.Clear()

            Dim getFeesType As String = "Select stdacct_tName from tbl_studaccount  where stdacct_id='" & stud_id & "' group by stdacct_tName having count(*) > 0 "
            dbConn.Open()
            da = New MySqlDataAdapter(getFeesType, dbConn)
            dt = New DataTable
            da.Fill(dt)
            For Each r As DataRow In dt.Rows
                Dim displayTotalFees As String = " select f.fees_name,sum(stdacct_tAmount)  as totalpay from tbl_studaccount inner join tbl_coll_fees f on stdacct_tName=f.fees_id where stdacct_id ='" & stud_id & "' and stdacct_tName='" & Integer.Parse(r.Item(0).ToString) & "' "
                sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                dr = sqlCommand.ExecuteReader
                While dr.Read
                    dg_displayTotalFees.Rows.Add(dr("fees_name").ToString, dr("totalpay").ToString)
                    totalStudFees += Double.Parse(dr("totalpay").ToString)
                End While
                dr.Close()
            Next
            txtb_totalFeesAmount.Text = totalStudFees
            txtb_totalBal.Text = Double.Parse(txtb_totalFees.Text) - totalStudFees
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try



    End Sub
    ''###########################################################Elementary Section ################################################################################

    Public Sub txtb_eStud_id_Click(sender As Object, e As EventArgs) Handles txtb_eStud_id.Click
        txtb_eStud_id.Text = eStud_id
        txtb_eStud_name.Text = eStudname
        txtb_eSY.Text = eStudSY
        txtb_eGL.Text = eStudGL


    End Sub


End Class
