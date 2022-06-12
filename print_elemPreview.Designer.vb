<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_elemPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.tbl_elem_accountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.elem_ds = New LCC_SAMS_Project.elem_ds()
        Me.tbl_elem_accountsTableAdapter = New LCC_SAMS_Project.elem_dsTableAdapters.tbl_elem_accountsTableAdapter()
        Me.elemrpt_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.tbl_elem_accountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.elem_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbl_elem_accountsBindingSource
        '
        Me.tbl_elem_accountsBindingSource.DataMember = "tbl_elem_accounts"
        Me.tbl_elem_accountsBindingSource.DataSource = Me.elem_ds
        '
        'elem_ds
        '
        Me.elem_ds.DataSetName = "elem_ds"
        Me.elem_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_elem_accountsTableAdapter
        '
        Me.tbl_elem_accountsTableAdapter.ClearBeforeFill = True
        '
        'elemrpt_viewer
        '
        Me.elemrpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "elem_ds"
        ReportDataSource1.Value = Me.tbl_elem_accountsBindingSource
        Me.elemrpt_viewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.elemrpt_viewer.LocalReport.ReportEmbeddedResource = "LCC_SAMS_Project.Report1.rdlc"
        Me.elemrpt_viewer.Location = New System.Drawing.Point(0, 0)
        Me.elemrpt_viewer.Name = "elemrpt_viewer"
        Me.elemrpt_viewer.Size = New System.Drawing.Size(774, 466)
        Me.elemrpt_viewer.TabIndex = 0
        '
        'print_elemPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(774, 466)
        Me.Controls.Add(Me.elemrpt_viewer)
        Me.Name = "print_elemPreview"
        Me.Text = "PRINT PREVIEW"
        CType(Me.tbl_elem_accountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.elem_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbl_elem_accountsBindingSource As BindingSource
    Friend WithEvents elem_ds As elem_ds
    Friend WithEvents tbl_elem_accountsTableAdapter As elem_dsTableAdapters.tbl_elem_accountsTableAdapter
    Friend WithEvents elemrpt_viewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
