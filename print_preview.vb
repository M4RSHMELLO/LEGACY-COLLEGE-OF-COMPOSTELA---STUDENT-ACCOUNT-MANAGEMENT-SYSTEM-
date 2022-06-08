Public Class print_preview
    Private Sub print_preview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'coll_ds.tbl_studaccount' table. You can move, or remove it, as needed.
        Me.tbl_studaccountTableAdapter.Fill(Me.coll_ds.tbl_studaccount)
        'TODO: This line of code loads data into the 'db_lccsamsDataSet.tbl_elem_accounts' table. You can move, or remove it, as needed.
        Me.tbl_elem_accountsTableAdapter.Fill(Me.db_lccsamsDataSet.tbl_elem_accounts)
        'TODO: This line of code loads data into the 'coll_ds.tbl_studaccount' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the 'db_lccsamsDataSet.tbl_elem_accounts' table. You can move, or remove it, as needed.

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class