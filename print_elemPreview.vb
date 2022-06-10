Public Class print_elemPreview
    Private Sub print_elemPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'elem_ds.tbl_elem_accounts' table. You can move, or remove it, as needed.
        Me.tbl_elem_accountsTableAdapter.Fill(Me.elem_ds.tbl_elem_accounts)

        Me.elemrpt_viewer.RefreshReport()
    End Sub
End Class