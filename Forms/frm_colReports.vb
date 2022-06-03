
Imports System.Data

Public Class frm_colReports

    Private Sub btn_collDept_Click(sender As Object, e As EventArgs) Handles btn_collDept.Click
        Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  where  WEEK(sa.stdacct_tDate) = WEEK(NOW()) - 1  order by sa.stdacct_tDate desc"
        _displayRecords(coll_rpt, dg_coll_rpt)


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  where  WEEK(sa.stdacct_tDate) = WEEK(NOW()) - 1  order by sa.stdacct_tDate desc"
        Try
            da = New MySqlDataAdapter(coll_rpt, dbConn)
            dt = New DataTable
            da.Fill(dt)
            rpt.SetDataSource(dt)
            collection_rpt.CrystalReportViewer1.ReportSource = rpt
            collection_rpt.CrystalReportViewer1.Refresh()
            collection_rpt.Show()
        Catch ex As Exception
            erromessage("error 103: Display Record" & ex.Message)
        Finally
            dbConn.Close()
        End Try
        dbConn.Open()

    End Sub
End Class
