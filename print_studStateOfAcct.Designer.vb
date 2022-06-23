<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class print_studStateOfAcct
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
        Me.elemrpt_viewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'elemrpt_viewer
        '
        Me.elemrpt_viewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "elem_ds"
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents elemrpt_viewer As Microsoft.Reporting.WinForms.ReportViewer
End Class
