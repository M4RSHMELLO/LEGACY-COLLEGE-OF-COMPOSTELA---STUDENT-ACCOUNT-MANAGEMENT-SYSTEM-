<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_colReports
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dp_dailyWeekly = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbo_dailyweekly = New System.Windows.Forms.ComboBox()
        Me.txtb_totalFeesAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_printrev = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.fees_amnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fees_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fees_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tran_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dg_coll_rpt = New System.Windows.Forms.DataGridView()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_titleReport = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_department = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dg_FeesCategory_report = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_coll_rpt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_FeesCategory_report, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dp_dailyWeekly)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cbo_dailyweekly)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 64)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(687, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 29)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "SELECT DATE"
        '
        'dp_dailyWeekly
        '
        Me.dp_dailyWeekly.CustomFormat = "MM-dd-yyyy"
        Me.dp_dailyWeekly.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dp_dailyWeekly.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_dailyWeekly.Location = New System.Drawing.Point(818, 22)
        Me.dp_dailyWeekly.Name = "dp_dailyWeekly"
        Me.dp_dailyWeekly.Size = New System.Drawing.Size(228, 30)
        Me.dp_dailyWeekly.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(103, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "SELECT REPORTS"
        '
        'cbo_dailyweekly
        '
        Me.cbo_dailyweekly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_dailyweekly.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_dailyweekly.FormattingEnabled = True
        Me.cbo_dailyweekly.Items.AddRange(New Object() {"DAILY", "WEEKLY"})
        Me.cbo_dailyweekly.Location = New System.Drawing.Point(270, 20)
        Me.cbo_dailyweekly.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbo_dailyweekly.Name = "cbo_dailyweekly"
        Me.cbo_dailyweekly.Size = New System.Drawing.Size(228, 33)
        Me.cbo_dailyweekly.TabIndex = 26
        '
        'txtb_totalFeesAmount
        '
        Me.txtb_totalFeesAmount.BackColor = System.Drawing.Color.White
        Me.txtb_totalFeesAmount.Enabled = False
        Me.txtb_totalFeesAmount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_totalFeesAmount.Location = New System.Drawing.Point(837, 758)
        Me.txtb_totalFeesAmount.Name = "txtb_totalFeesAmount"
        Me.txtb_totalFeesAmount.Size = New System.Drawing.Size(155, 26)
        Me.txtb_totalFeesAmount.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(721, 761)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 21)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "TOTAL AMOUNT"
        '
        'btn_printrev
        '
        Me.btn_printrev.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_printrev.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_printrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_printrev.BorderRadius = 0
        Me.btn_printrev.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_printrev.ButtonText = "PRINT PREVIEW"
        Me.btn_printrev.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_printrev.DisabledColor = System.Drawing.Color.Gray
        Me.btn_printrev.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btn_printrev.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_printrev.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_printrev.Iconimage = Nothing
        Me.btn_printrev.Iconimage_right = Nothing
        Me.btn_printrev.Iconimage_right_Selected = Nothing
        Me.btn_printrev.Iconimage_Selected = Nothing
        Me.btn_printrev.IconMarginLeft = 0
        Me.btn_printrev.IconMarginRight = 0
        Me.btn_printrev.IconRightVisible = False
        Me.btn_printrev.IconRightZoom = 0R
        Me.btn_printrev.IconVisible = False
        Me.btn_printrev.IconZoom = 90.0R
        Me.btn_printrev.IsTab = False
        Me.btn_printrev.Location = New System.Drawing.Point(790, 8)
        Me.btn_printrev.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_printrev.Name = "btn_printrev"
        Me.btn_printrev.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_printrev.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_printrev.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_printrev.selected = False
        Me.btn_printrev.Size = New System.Drawing.Size(180, 33)
        Me.btn_printrev.TabIndex = 54
        Me.btn_printrev.Text = "PRINT PREVIEW"
        Me.btn_printrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_printrev.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_printrev.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'fees_amnt
        '
        Me.fees_amnt.HeaderText = "Amount"
        Me.fees_amnt.Name = "fees_amnt"
        Me.fees_amnt.ReadOnly = True
        '
        'fees_name
        '
        Me.fees_name.HeaderText = "Particulars"
        Me.fees_name.Name = "fees_name"
        Me.fees_name.ReadOnly = True
        '
        'fees_date
        '
        Me.fees_date.HeaderText = "Date"
        Me.fees_date.Name = "fees_date"
        Me.fees_date.ReadOnly = True
        '
        'tran_id
        '
        Me.tran_id.HeaderText = "Invoice No."
        Me.tran_id.Name = "tran_id"
        Me.tran_id.ReadOnly = True
        '
        'dg_coll_rpt
        '
        Me.dg_coll_rpt.AllowUserToAddRows = False
        Me.dg_coll_rpt.AllowUserToDeleteRows = False
        Me.dg_coll_rpt.AllowUserToResizeRows = False
        Me.dg_coll_rpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_coll_rpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_coll_rpt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.tran_id, Me.fees_date, Me.fees_name, Me.fees_amnt})
        Me.dg_coll_rpt.Location = New System.Drawing.Point(32, 49)
        Me.dg_coll_rpt.Name = "dg_coll_rpt"
        Me.dg_coll_rpt.ReadOnly = True
        Me.dg_coll_rpt.RowHeadersVisible = False
        Me.dg_coll_rpt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_coll_rpt.Size = New System.Drawing.Size(938, 304)
        Me.dg_coll_rpt.TabIndex = 25
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(668, 363)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(68, 25)
        Me.lbl_total.TabIndex = 55
        Me.lbl_total.Text = "TOTAL:"
        '
        'lbl_titleReport
        '
        Me.lbl_titleReport.AutoSize = True
        Me.lbl_titleReport.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_titleReport.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_titleReport.Location = New System.Drawing.Point(36, 17)
        Me.lbl_titleReport.Name = "lbl_titleReport"
        Me.lbl_titleReport.Size = New System.Drawing.Size(321, 29)
        Me.lbl_titleReport.TabIndex = 57
        Me.lbl_titleReport.Text = "DAILY COLLECTION REPORTS FOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(341, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 29)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "SELECT DEPARTMENT"
        '
        'cbo_department
        '
        Me.cbo_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_department.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_department.FormattingEnabled = True
        Me.cbo_department.Items.AddRange(New Object() {"College Dept.", "Elementary Dept.", "Senior-High Dept", "Junior-High Dept"})
        Me.cbo_department.Location = New System.Drawing.Point(544, 74)
        Me.cbo_department.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.cbo_department.Name = "cbo_department"
        Me.cbo_department.Size = New System.Drawing.Size(274, 33)
        Me.cbo_department.TabIndex = 58
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.dg_FeesCategory_report)
        Me.Panel2.Controls.Add(Me.dg_coll_rpt)
        Me.Panel2.Controls.Add(Me.btn_printrev)
        Me.Panel2.Controls.Add(Me.lbl_total)
        Me.Panel2.Controls.Add(Me.lbl_titleReport)
        Me.Panel2.Location = New System.Drawing.Point(76, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(982, 527)
        Me.Panel2.TabIndex = 60
        '
        'dg_FeesCategory_report
        '
        Me.dg_FeesCategory_report.AllowUserToAddRows = False
        Me.dg_FeesCategory_report.AllowUserToDeleteRows = False
        Me.dg_FeesCategory_report.AllowUserToResizeColumns = False
        Me.dg_FeesCategory_report.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_FeesCategory_report.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_FeesCategory_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_FeesCategory_report.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dg_FeesCategory_report.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_FeesCategory_report.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dg_FeesCategory_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_FeesCategory_report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_FeesCategory_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_FeesCategory_report.ColumnHeadersVisible = False
        Me.dg_FeesCategory_report.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_FeesCategory_report.DefaultCellStyle = DataGridViewCellStyle3
        Me.dg_FeesCategory_report.DoubleBuffered = True
        Me.dg_FeesCategory_report.EnableHeadersVisualStyles = False
        Me.dg_FeesCategory_report.HeaderBgColor = System.Drawing.SystemColors.Control
        Me.dg_FeesCategory_report.HeaderForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_FeesCategory_report.Location = New System.Drawing.Point(65, 391)
        Me.dg_FeesCategory_report.Name = "dg_FeesCategory_report"
        Me.dg_FeesCategory_report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_FeesCategory_report.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_FeesCategory_report.RowHeadersVisible = False
        Me.dg_FeesCategory_report.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_FeesCategory_report.Size = New System.Drawing.Size(357, 124)
        Me.dg_FeesCategory_report.TabIndex = 66
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.FillWeight = 147.2081!
        Me.DataGridViewTextBoxColumn21.HeaderText = "Particular"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(36, 359)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(421, 29)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "TOTAL COLLECTION REPORT FOR EACH FEES"
        '
        'frm_colReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.cbo_department)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtb_totalFeesAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frm_colReports"
        Me.Size = New System.Drawing.Size(1154, 664)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_coll_rpt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_FeesCategory_report, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbo_dailyweekly As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_totalFeesAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btn_printrev As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dp_dailyWeekly As DateTimePicker
    Friend WithEvents fees_amnt As DataGridViewTextBoxColumn
    Friend WithEvents fees_name As DataGridViewTextBoxColumn
    Friend WithEvents fees_date As DataGridViewTextBoxColumn
    Friend WithEvents tran_id As DataGridViewTextBoxColumn
    Friend WithEvents dg_coll_rpt As DataGridView
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_titleReport As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbo_department As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dg_FeesCategory_report As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
End Class
