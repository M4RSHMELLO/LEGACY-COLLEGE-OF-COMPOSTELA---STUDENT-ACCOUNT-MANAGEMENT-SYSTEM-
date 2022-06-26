Imports System
Imports System.Globalization
Imports System.Threading
Imports System.Data
Imports Microsoft.Reporting.WinForms
Public Class frm_colReports
    Sub _lbl_tittle()

    End Sub



    Sub loadreport()
        Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
        Dim selectWDate As String = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dp_dailyWeekly.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)

        If cbo_department.SelectedIndex = 0 Then
            Dim coll_rpt1 As String = "Select sa.stdacct_tN,sa.stdacct_tDate,ft.feestype_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_fees_type ft on ft.feestype_id=sa.stdacct_tName  where  DATE_FORMAT(sa.stdacct_tDate, '%u')='" & selectDate & "' order by sa.stdacct_tDate asc"
            Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,ft.feestype_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_fees_type ft on ft.feestype_id=sa.stdacct_tName  where sa.stdacct_tDate='" & selectDate & "' order by sa.stdacct_tDate asc"
            Dim rpt_ds As ReportDataSource
            Try
                _dbConnection("db_lccsams")
                dbConn.Open()
                If cbo_dailyweekly.Text = "WEEKLY" Then
                    da = New MySqlDataAdapter(coll_rpt1, dbConn)
                ElseIf cbo_dailyweekly.Text = "DAILY" Then
                    da = New MySqlDataAdapter(coll_rpt, dbConn)
                Else
                    MessageBox.Show("PLEASE SELECT A REPORT TYPE")
                End If
                dt = New DataTable
                da.Fill(dt)
                print_preview.ReportViewer1.Refresh()
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
                print_preview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dbConn.Close()
            End Try
        End If
        If cbo_department.SelectedIndex = 1 Then
            Dim coll_rpt1 As String = "Select sa.etan,sa.edate_paidamount,ft.feestype_name,sa.epay_amount from tbl_elem_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.efees_id  where DATE_FORMAT(sa.edate_paidamount,'%u')='" & selectDate & "' order by sa.edate_paidamount asc"
            Dim coll_rpt As String = "Select sa.etan,sa.edate_paidamount,ft.feestype_name,sa.epay_amount from tbl_elem_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.efees_id  where sa.edate_paidamount='" & selectDate & "' order by sa.edate_paidamount asc"
            Dim rpt_ds As ReportDataSource
            Try
                _dbConnection("db_lccsams")
                dbConn.Open()
                If cbo_dailyweekly.Text = "WEEKLY" Then
                    da = New MySqlDataAdapter(coll_rpt1, dbConn)
                ElseIf cbo_dailyweekly.Text = "DAILY" Then
                    da = New MySqlDataAdapter(coll_rpt, dbConn)
                Else
                    MessageBox.Show("PLEASE SELECT A REPORT TYPE")
                End If

                dt = New DataTable
                da.Fill(dt)
                print_preview.ReportViewer1.Refresh()
                With print_preview.ReportViewer1.LocalReport
                    .DataSources.Clear()
                    .ReportPath = "C:\Users\RJR-PC\Documents\Visual Studio 2019\LCC-SAMS_Project\Report1.rdlc"
                    .DataSources.Add(New ReportDataSource("elem_ds", dt))
                End With
                print_preview.ReportViewer1.RefreshReport()
                print_preview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                print_preview.ReportViewer1.ZoomMode = ZoomMode.Percent
                print_preview.ReportViewer1.ZoomPercent = 75
                print_preview.ReportViewer1.ShowPrintButton = True
                print_preview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dbConn.Close()
            End Try
        End If
        If cbo_department.SelectedIndex = 2 Then
            Dim coll_rpt1 As String = "Select sa.stan,sa.sdate_paidamount,ft.feestype_name,sa.spay_amount from tbl_senior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.sfees_id  where DATE_FORMAT(sa.sdate_paidamount,'%u')='" & selectDate & "' order by sa.sdate_paidamount asc"

            Dim coll_rpt As String = "Select sa.stan,sa.sdate_paidamount,ft.feestype_name,sa.spay_amount from tbl_senior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.sfees_id  where sa.sdate_paidamount='" & selectDate & "' order by sa.sdate_paidamount asc"
            Dim rpt_ds As ReportDataSource
            Try
                _dbConnection("db_lccsams")
                dbConn.Open()
                If cbo_dailyweekly.Text = "WEEKLY" Then
                    da = New MySqlDataAdapter(coll_rpt1, dbConn)
                ElseIf cbo_dailyweekly.Text = "DAILY" Then
                    da = New MySqlDataAdapter(coll_rpt, dbConn)
                Else
                    MessageBox.Show("PLEASE SELECT A REPORT TYPE")
                End If
                dt = New DataTable
                da.Fill(dt)
                print_studStateOfAcct.elemrpt_viewer.Refresh()
                With print_studStateOfAcct.elemrpt_viewer.LocalReport
                    .DataSources.Clear()
                    .ReportPath = "C:\Users\RJR-PC\Documents\Visual Studio 2019\LCC-SAMS_Project\Report3.rdlc"
                    .DataSources.Add(New ReportDataSource("senior_ds", dt))
                End With

                print_preview.ReportViewer1.RefreshReport()
                print_preview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                print_preview.ReportViewer1.ZoomMode = ZoomMode.Percent
                print_preview.ReportViewer1.ZoomPercent = 75
                print_preview.ReportViewer1.ShowPrintButton = True
                print_preview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dbConn.Close()
            End Try

        End If
        If cbo_department.SelectedIndex = 3 Then
            Dim coll_rpt1 As String = "Select sa.jtan,sa.jdate_paidamount,ft.feestype_name,sa.jpay_amount from tbl_junior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.jfees_id  where DATE_FORMAT(sa.jdate_paidamount,'%u')='" & selectDate & "' order by sa.jdate_paidamount asc"

            Dim coll_rpt As String = "Select sa.jtan,sa.jdate_paidamount,ft.feestype_name,sa.jpay_amount from tbl_junior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.jfees_id  where sa.jdate_paidamount='" & selectDate & "' order by sa.jdate_paidamount asc"
            Dim rpt_ds As ReportDataSource
            Try
                _dbConnection("db_lccsams")
                dbConn.Open()
                If cbo_dailyweekly.Text = "WEEKLY" Then
                    da = New MySqlDataAdapter(coll_rpt1, dbConn)
                ElseIf cbo_dailyweekly.Text = "DAILY" Then
                    da = New MySqlDataAdapter(coll_rpt, dbConn)
                Else
                    MessageBox.Show("PLEASE SELECT A REPORT TYPE")
                End If
                dt = New DataTable
                da.Fill(dt)
                print_studStateOfAcct.elemrpt_viewer.Refresh()
                With print_studStateOfAcct.elemrpt_viewer.LocalReport
                    .DataSources.Clear()
                    .ReportPath = "C:\Users\RJR-PC\Documents\Visual Studio 2019\LCC-SAMS_Project\Report4.rdlc"
                    .DataSources.Add(New ReportDataSource("junior_ds", dt))
                End With

                print_preview.ReportViewer1.RefreshReport()
                print_preview.ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
                print_preview.ReportViewer1.ZoomMode = ZoomMode.Percent
                print_preview.ReportViewer1.ZoomPercent = 75
                print_preview.ReportViewer1.ShowPrintButton = True
                print_preview.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                dbConn.Close()
            End Try

        End If

    End Sub

    Private Sub btn_printrev_Click(sender As Object, e As EventArgs) Handles btn_printrev.Click

        loadreport()
    End Sub

    Private Sub frm_colReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_dailyweekly.SelectedIndex = 0
        cbo_department.SelectedIndex = -1
    End Sub

    Private Sub cbo_department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_department.SelectedIndexChanged
        Dim totalColl As Integer

        If cbo_department.SelectedIndex = 0 Then

            '_loadToCombobox(slctYL, ComboBox1)

            totalColl = 0
            dg_coll_rpt.Columns(0).DataPropertyName = "stdacct_tN"
            dg_coll_rpt.Columns(1).DataPropertyName = "stdacct_tDate"
            dg_coll_rpt.Columns(2).DataPropertyName = "feestype_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "stdacct_tAmount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR COLLEGE DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim selectDate As String = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dp_dailyWeekly.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,ft.feestype_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_fees_type ft on ft.feestype_id=sa.stdacct_tName  where  DATE_FORMAT(sa.stdacct_tDate, '%u')='" & selectDate & "' order by sa.stdacct_tDate asc"
                _displayRecords(coll_rpt, dg_coll_rpt)


                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select stdacct_tName from tbl_studaccount  group by stdacct_tName having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.stdacct_tAmount)  as totalpay from tbl_studaccount sa inner join tbl_fees_type ft on sa.stdacct_tName=ft.feestype_id where  DATE_FORMAT(sa.stdacct_tDate, '%u')='" & selectDate & "' and stdacct_tName='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try
            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                totalColl = 0
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR COLLEGE DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.stdacct_tN,sa.stdacct_tDate,ft.feestype_name,sa.stdacct_tAmount from tbl_studaccount sa inner join tbl_fees_type ft on ft.feestype_id=sa.stdacct_tName  where sa.stdacct_tDate='" & selectDate & "' order by sa.stdacct_tDate asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select stdacct_tName from tbl_studaccount  group by stdacct_tName having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.stdacct_tAmount)  as totalpay from tbl_studaccount sa inner join tbl_fees_type ft on sa.stdacct_tName=ft.feestype_id where  sa.stdacct_tDate='" & selectDate & "' and stdacct_tName='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try

            End If

        End If
        If cbo_department.SelectedIndex = 1 Then
            totalColl = 0
            dg_coll_rpt.Columns(0).DataPropertyName = "etan"
            dg_coll_rpt.Columns(1).DataPropertyName = "edate_paidamount"
            dg_coll_rpt.Columns(2).DataPropertyName = "feestype_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "epay_amount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR ELEMENTARY DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim selectDate As String = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dp_dailyWeekly.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                Dim coll_rpt As String = "Select sa.etan,sa.edate_paidamount,ft.feestype_name,sa.epay_amount from tbl_elem_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.efees_id  where DATE_FORMAT(sa.edate_paidamount,'%u')='" & selectDate & "' order by sa.edate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select efees_id from tbl_elem_accounts  group by efees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.epay_amount)  as totalpay from tbl_elem_accounts sa inner join tbl_fees_type ft on sa.efees_id=ft.feestype_id where  DATE_FORMAT(sa.edate_paidamount, '%u')='" & selectDate & "' and sa.efees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try
            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR ELEMENTARY DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.etan,sa.edate_paidamount,ft.feestype_name,sa.epay_amount from tbl_elem_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.efees_id  where sa.edate_paidamount='" & selectDate & "' order by sa.edate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select efees_id from tbl_elem_accounts  group by efees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.epay_amount)  as totalpay from tbl_elem_accounts sa inner join tbl_fees_type ft on sa.efees_id=ft.feestype_id where sa.edate_paidamount='" & selectDate & "' and sa.efees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try
            End If
        End If
        If cbo_department.SelectedIndex = 2 Then
            totalColl = 0
            dg_coll_rpt.Columns(0).DataPropertyName = "stan"
            dg_coll_rpt.Columns(1).DataPropertyName = "sdate_paidamount"
            dg_coll_rpt.Columns(2).DataPropertyName = "feestype_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "spay_amount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR SENIOR-HIGH DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim selectDate As String = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dp_dailyWeekly.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                Dim coll_rpt As String = "Select sa.stan,sa.sdate_paidamount,ft.feestype_name,sa.spay_amount from tbl_senior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.sfees_id  where DATE_FORMAT(sa.sdate_paidamount,'%u')='" & selectDate & "' order by sa.sdate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select sfees_id from tbl_senior_accounts  group by sfees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.spay_amount)  as totalpay from tbl_senior_accounts sa inner join tbl_fees_type ft on sa.sfees_id=ft.feestype_id where  DATE_FORMAT(sa.sdate_paidamount, '%u')='" & selectDate & "' and sa.sfees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try
            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR SENIOR-HIGH DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.stan,sa.sdate_paidamount,ft.feestype_name,sa.spay_amount from tbl_senior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.sfees_id  where sa.sdate_paidamount='" & selectDate & "' order by sa.sdate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select sfees_id from tbl_senior_accounts  group by sfees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.spay_amount)  as totalpay from tbl_senior_accounts sa inner join tbl_fees_type ft on sa.sfees_id=ft.feestype_id where sa.sdate_paidamount='" & selectDate & "' and sa.sfees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try

            End If

        End If
        If cbo_department.SelectedIndex = 3 Then
            totalColl = 0
            dg_coll_rpt.Columns(0).DataPropertyName = "jtan"
            dg_coll_rpt.Columns(1).DataPropertyName = "jdate_paidamount"
            dg_coll_rpt.Columns(2).DataPropertyName = "feestype_name"
            dg_coll_rpt.Columns(3).DataPropertyName = "jpay_amount"
            If cbo_dailyweekly.Text = "WEEKLY" Then
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR JUNIOR-HIGH DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim selectDate As String = CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(dp_dailyWeekly.Text, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday)
                Dim coll_rpt As String = "Select sa.jtan,sa.jdate_paidamount,ft.feestype_name,sa.jpay_amount from tbl_junior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.jfees_id  where DATE_FORMAT(sa.jdate_paidamount,'%u')='" & selectDate & "' order by sa.jdate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select jfees_id from tbl_junior_accounts  group by jfees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.jpay_amount)  as totalpay from tbl_junior_accounts sa inner join tbl_fees_type ft on sa.jfees_id=ft.feestype_id where  DATE_FORMAT(sa.jdate_paidamount, '%u')='" & selectDate & "' and sa.jfees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try

            End If
            If cbo_dailyweekly.Text = "DAILY" Then
                Dim selectDate As String = dp_dailyWeekly.Value.ToString("yyyy-MM-dd")
                lbl_titleReport.Text = cbo_dailyweekly.Text.ToUpper & " COLLECTION REPORT FOR JUNIOR-HIGH DEPARTMENT AS OF " & dp_dailyWeekly.Text
                Dim coll_rpt As String = "Select sa.jtan,sa.jdate_paidamount,ft.feestype_name,sa.jpay_amount from tbl_junior_accounts sa inner join tbl_fees_type ft on ft.feestype_id=sa.jfees_id  where sa.jdate_paidamount='" & selectDate & "' order by sa.jdate_paidamount asc"
                _displayRecords(coll_rpt, dg_coll_rpt)
                Try
                    dg_FeesCategory_report.Rows.Clear()
                    Dim totalStudFees As Double = 0
                    _dbConnection("db_lccsams")

                    Dim getFeesType As String = "Select jfees_id from tbl_junior_accounts  group by jfees_id having count(*) > 0 "
                    dbConn.Open()
                    da = New MySqlDataAdapter(getFeesType, dbConn)
                    dt = New DataTable
                    da.Fill(dt)
                    For Each r As DataRow In dt.Rows
                        Dim displayTotalFees As String = " select ft.feestype_name,sum(sa.jpay_amount)  as totalpay from tbl_junior_accounts sa inner join tbl_fees_type ft on sa.jfees_id=ft.feestype_id where  sa.jdate_paidamount='" & selectDate & "' and sa.jfees_id='" & Integer.Parse(r.Item(0).ToString) & "' "
                        sqlCommand = New MySqlCommand(displayTotalFees, dbConn)
                        dr = sqlCommand.ExecuteReader
                        While dr.Read()
                            dg_FeesCategory_report.Rows.Add(dr("feestype_name").ToString, dr("totalpay").ToString)
                            totalStudFees += Double.Parse(dr("totalpay").ToString)
                        End While
                        dr.Close()
                    Next
                Catch ex As Exception
                    'MessageBox.Show(ex.Message)
                Finally
                    dbConn.Close()
                End Try
            End If

        End If
        For Each rowX As DataGridViewRow In dg_coll_rpt.Rows
            totalColl += rowX.Cells(3).Value
        Next
        lbl_total.Text = "TOTAL: " & totalColl
    End Sub

    Private Sub dg_coll_rpt_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_coll_rpt.CellClick

    End Sub
End Class
