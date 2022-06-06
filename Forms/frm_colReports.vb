
Imports System.Data

Public Class frm_colReports

    Private Sub btn_collDept_Click(sender As Object, e As EventArgs) Handles btn_collDept.Click
        dg_coll_rpt.Columns(0).DataPropertyName = "stdacct_tN"
        dg_coll_rpt.Columns(1).DataPropertyName = "stdacct_tDate"
        dg_coll_rpt.Columns(2).DataPropertyName = "fees_name"
        dg_coll_rpt.Columns(3).DataPropertyName = "stdacct_tAmount"
        Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  order by sa.stdacct_tDate asc"
        _displayRecords(coll_rpt, dg_coll_rpt)


    End Sub
    'Declaration



    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  order by sa.stdacct_tDate asc"
        Try
            dbConn.Open()
            da = New MySqlDataAdapter(coll_rpt, dbConn)
            dt = New DataTable
            da.Fill(dt)
            rpt.SetDataSource(dt)

            rpt.SetDatabaseLogon("raldz", "d74r3j93527", "127.0.0.1", "db_lccsams")

            collection_rpt.CrystalReportViewer1.ReportSource = rpt
            collection_rpt.CrystalReportViewer1.Refresh()
            collection_rpt.Show()
        Catch ex As Exception
            erromessage("error 103: Display Record " & ex.Message)
        Finally
            dbConn.Close()
        End Try


    End Sub

    Private Sub cbo_dailyweekly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_dailyweekly.SelectedIndexChanged

    End Sub
End Class
