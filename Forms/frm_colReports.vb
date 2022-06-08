
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class frm_colReports
    Sub _lbl_tittle()

    End Sub



    Sub loadreport()
        Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
        Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  where sa.stdacct_tDate='" & selectDate & "' order by sa.stdacct_tDate asc"
        Dim rpt_ds As ReportDataSource
        Try
            _dbConnection("db_lccsams")
            dbConn.Open()
            da = New MySqlDataAdapter(coll_rpt, dbConn)
            dt = New DataTable
            da.Fill(dt)
            With print_preview.ReportViewer1.LocalReport
                .DataSources.Clear()
                .ReportPath = "C:\Users\RJR-PC\Documents\Visual Studio 2019\LCC-SAMS_Project\Report2.rdlc"
                .DataSources.Add(New ReportDataSource("coll_rpt", dt))
            End With
            print_preview.ReportViewer1.RefreshReport()
            print_preview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            print_preview.ReportViewer1.ZoomMode = ZoomMode.Percent
            print_preview.ReportViewer1.ZoomPercent = 75
            print_preview.ReportViewer1.ShowPrintButton = True
            print_preview.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_printrev.Click

        loadreport()
    End Sub

    Private Sub frm_colReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_dailyweekly.SelectedIndex = 0
        cbo_department.SelectedIndex = -1
    End Sub

    Private Sub cbo_department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_department.SelectedIndexChanged
        If cbo_department.SelectedIndex = 0 Then
            dg_coll_rpt.Columns(0).DataPropertyName = "stdacct_tN"
            dg_coll_rpt.Columns(1).DataPropertyName = "stdacct_tDate"
            dg_coll_rpt.Columns(2).DataPropertyName = "fees_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "stdacct_tAmount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR COLLEGE DEPARTMENT AS OF"
            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR COLLEGE DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,cf.fees_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_coll_fees cf on cf.fees_id=sa.stdacct_tName  where sa.stdacct_tDate='" & selectDate & "' order by sa.stdacct_tDate asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
            End If
        End If
        If cbo_department.SelectedIndex = 1 Then
            dg_coll_rpt.Columns(0).DataPropertyName = "etan"
            dg_coll_rpt.Columns(1).DataPropertyName = "edate_paidamount"
            dg_coll_rpt.Columns(2).DataPropertyName = "efees_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "epay_amount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR ELEMENTARY DEPARTMENT AS OF"
            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR ELEMENTARY DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.etan,sa.edate_paidamount,f.efees_name,sa.epay_amount from tbl_elem_accounts sa inner join tbl_elem_fees f on f.efees_id=sa.efees_id  where sa.edate_paidamount='" & selectDate & "' order by sa.edate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
            End If
        End If
        If cbo_department.SelectedIndex = 2 Then

        End If
        If cbo_department.SelectedIndex = 3 Then

        End If
    End Sub

    Private Sub dg_coll_rpt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_coll_rpt.CellClick

    End Sub
End Class
