<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class print_preview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.coll_ds = New LCC_SAMS_Project.coll_ds()
        Me.tbl_studaccountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_studaccountTableAdapter = New LCC_SAMS_Project.coll_dsTableAdapters.tbl_studaccountTableAdapter()
        Me.db_lccsamsDataSet = New LCC_SAMS_Project.db_lccsamsDataSet()
        Me.tbl_elem_accountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_elem_accountsTableAdapter = New LCC_SAMS_Project.db_lccsamsDataSetTableAdapters.tbl_elem_accountsTableAdapter()
        CType(Me.coll_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_studaccountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.db_lccsamsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_elem_accountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "LCC_SAMS_Project.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.ReportServerUrl = New System.Uri("", System.UriKind.Relative)
        Me.ReportViewer1.Size = New System.Drawing.Size(790, 505)
        Me.ReportViewer1.TabIndex = 0
        '
        'coll_ds
        '
        Me.coll_ds.DataSetName = "coll_ds"
        Me.coll_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_studaccountBindingSource
        '
        Me.tbl_studaccountBindingSource.DataMember = "tbl_studaccount"
        Me.tbl_studaccountBindingSource.DataSource = Me.coll_ds
        '
        'tbl_studaccountTableAdapter
        '
        Me.tbl_studaccountTableAdapter.ClearBeforeFill = True
        '
        'db_lccsamsDataSet
        '
        Me.db_lccsamsDataSet.DataSetName = "db_lccsamsDataSet"
        Me.db_lccsamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_elem_accountsBindingSource
        '
        Me.tbl_elem_accountsBindingSource.DataMember = "tbl_elem_accounts"
        Me.tbl_elem_accountsBindingSource.DataSource = Me.db_lccsamsDataSet
        '
        'tbl_elem_accountsTableAdapter
        '
        Me.tbl_elem_accountsTableAdapter.ClearBeforeFill = True
        '
        'print_preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 505)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "print_preview"
        Me.Text = "PRINT PREVIEW"
        CType(Me.coll_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_studaccountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.db_lccsamsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_elem_accountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_studaccountBindingSource As BindingSource
    Friend WithEvents coll_ds As coll_ds
    Friend WithEvents tbl_elem_accountsBindingSource As BindingSource
    Friend WithEvents db_lccsamsDataSet As db_lccsamsDataSet
    Friend WithEvents tbl_studaccountTableAdapter As coll_dsTableAdapters.tbl_studaccountTableAdapter
    Friend WithEvents tbl_elem_accountsTableAdapter As db_lccsamsDataSetTableAdapters.tbl_elem_accountsTableAdapter
End Class
