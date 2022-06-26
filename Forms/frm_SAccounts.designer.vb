<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_SAccounts
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_SAccounts))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.college_dept = New System.Windows.Forms.TabPage()
        Me.btn_UpdateCacct = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dg_studFeesType = New System.Windows.Forms.DataGridView()
        Me.fees_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fFeestype_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FeesAmount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtb_totalFees = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtb_studAcct_ID = New System.Windows.Forms.TextBox()
        Me.txtb_rpu = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtb_nUnits = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtb_yl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.txtb_sem = New System.Windows.Forms.TextBox()
        Me.txtb_crs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_sy = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.cbo_sortSem = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbo_sortSY = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dg_displayTotalFees = New System.Windows.Forms.DataGridView()
        Me.TypeFees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountFees = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtb_totalBal = New System.Windows.Forms.TextBox()
        Me.txtb_totalFeesAmount = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnl_scholar = New System.Windows.Forms.Panel()
        Me.txtb_sPaidAmnt = New System.Windows.Forms.TextBox()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.txtb_sType = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtb_sAmnt = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.dg_acctRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.stdacct_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.or_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sa_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sa_particulars = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sa_amountPaid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sa_balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elem_dept = New System.Windows.Forms.TabPage()
        Me.GroupBox18 = New System.Windows.Forms.GroupBox()
        Me.cbo_eSortSY = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.dg_eStudAcctRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.dg_eStudFees = New System.Windows.Forms.DataGridView()
        Me.ef_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtb_eStud_TBal = New System.Windows.Forms.TextBox()
        Me.txtb_eStudFees_TAmount = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.dg_Fees = New System.Windows.Forms.DataGridView()
        Me.txtb_eTotalFees = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtb_eStud_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtb_eGL = New System.Windows.Forms.TextBox()
        Me.txtb_eStud_name = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtb_eSY = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.sh_dept = New System.Windows.Forms.TabPage()
        Me.GroupBox19 = New System.Windows.Forms.GroupBox()
        Me.cbo_sSortBY = New System.Windows.Forms.ComboBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.dg_sStudAcctRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox15 = New System.Windows.Forms.GroupBox()
        Me.dg_sStudFees = New System.Windows.Forms.DataGridView()
        Me.sfees_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtb_sStud_Bal = New System.Windows.Forms.TextBox()
        Me.txtb_sStud_TAmount = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox16 = New System.Windows.Forms.GroupBox()
        Me.dg_sFeesRec = New System.Windows.Forms.DataGridView()
        Me.txtb_sTFees = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.GroupBox17 = New System.Windows.Forms.GroupBox()
        Me.txtb_sStud_id = New System.Windows.Forms.TextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.txtb_sGL = New System.Windows.Forms.TextBox()
        Me.txtb_sStud_name = New System.Windows.Forms.TextBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txtb_sSY = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.jh_dept = New System.Windows.Forms.TabPage()
        Me.GroupBox20 = New System.Windows.Forms.GroupBox()
        Me.cbo_jSortBY = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.dg_jStudAcctRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.dg_jStudFees = New System.Windows.Forms.DataGridView()
        Me.txtb_jStudTBal = New System.Windows.Forms.TextBox()
        Me.txtb_jStudTAmount = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.dg_jFees = New System.Windows.Forms.DataGridView()
        Me.txtb_jTFees = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.txtb_jStud_ID = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtb_jGL = New System.Windows.Forms.TextBox()
        Me.txtb_jStud_name = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txtb_jSY = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.sp_balance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jf_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.college_dept.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_studFeesType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg_displayTotalFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_scholar.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dg_acctRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.elem_dept.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dg_eStudAcctRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_eStudFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.dg_Fees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.sh_dept.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        CType(Me.dg_sStudAcctRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox15.SuspendLayout()
        CType(Me.dg_sStudFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox16.SuspendLayout()
        CType(Me.dg_sFeesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        Me.jh_dept.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dg_jStudAcctRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dg_jStudFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dg_jFees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox13.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.college_dept)
        Me.TabControl1.Controls.Add(Me.elem_dept)
        Me.TabControl1.Controls.Add(Me.sh_dept)
        Me.TabControl1.Controls.Add(Me.jh_dept)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1043, 610)
        Me.TabControl1.TabIndex = 0
        '
        'college_dept
        '
        Me.college_dept.BackColor = System.Drawing.SystemColors.Control
        Me.college_dept.Controls.Add(Me.btn_UpdateCacct)
        Me.college_dept.Controls.Add(Me.GroupBox3)
        Me.college_dept.Controls.Add(Me.GroupBox2)
        Me.college_dept.Controls.Add(Me.GroupBox6)
        Me.college_dept.Controls.Add(Me.GroupBox4)
        Me.college_dept.Controls.Add(Me.GroupBox5)
        Me.college_dept.Location = New System.Drawing.Point(4, 30)
        Me.college_dept.Name = "college_dept"
        Me.college_dept.Padding = New System.Windows.Forms.Padding(3)
        Me.college_dept.Size = New System.Drawing.Size(1035, 576)
        Me.college_dept.TabIndex = 0
        Me.college_dept.Text = "College Dept"
        '
        'btn_UpdateCacct
        '
        Me.btn_UpdateCacct.ActiveBorderThickness = 1
        Me.btn_UpdateCacct.ActiveCornerRadius = 20
        Me.btn_UpdateCacct.ActiveFillColor = System.Drawing.Color.Transparent
        Me.btn_UpdateCacct.ActiveForecolor = System.Drawing.Color.White
        Me.btn_UpdateCacct.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.btn_UpdateCacct.BackColor = System.Drawing.SystemColors.Control
        Me.btn_UpdateCacct.BackgroundImage = CType(resources.GetObject("btn_UpdateCacct.BackgroundImage"), System.Drawing.Image)
        Me.btn_UpdateCacct.ButtonText = "UPDATE"
        Me.btn_UpdateCacct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_UpdateCacct.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_UpdateCacct.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_UpdateCacct.IdleBorderThickness = 1
        Me.btn_UpdateCacct.IdleCornerRadius = 20
        Me.btn_UpdateCacct.IdleFillColor = System.Drawing.Color.White
        Me.btn_UpdateCacct.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.btn_UpdateCacct.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.btn_UpdateCacct.Location = New System.Drawing.Point(542, 527)
        Me.btn_UpdateCacct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_UpdateCacct.Name = "btn_UpdateCacct"
        Me.btn_UpdateCacct.Size = New System.Drawing.Size(86, 35)
        Me.btn_UpdateCacct.TabIndex = 42
        Me.btn_UpdateCacct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_UpdateCacct.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dg_studFeesType)
        Me.GroupBox3.Controls.Add(Me.txtb_totalFees)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(5, 176)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(531, 169)
        Me.GroupBox3.TabIndex = 43
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FEES"
        '
        'dg_studFeesType
        '
        Me.dg_studFeesType.AllowUserToAddRows = False
        Me.dg_studFeesType.AllowUserToDeleteRows = False
        Me.dg_studFeesType.AllowUserToResizeColumns = False
        Me.dg_studFeesType.AllowUserToResizeRows = False
        Me.dg_studFeesType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_studFeesType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_studFeesType.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fees_name, Me.fFeestype_name, Me.FeesAmount})
        Me.dg_studFeesType.Location = New System.Drawing.Point(13, 25)
        Me.dg_studFeesType.Name = "dg_studFeesType"
        Me.dg_studFeesType.ReadOnly = True
        Me.dg_studFeesType.RowHeadersVisible = False
        Me.dg_studFeesType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_studFeesType.Size = New System.Drawing.Size(506, 107)
        Me.dg_studFeesType.TabIndex = 23
        '
        'fees_name
        '
        Me.fees_name.DataPropertyName = "fees_name"
        Me.fees_name.HeaderText = "Fees ID"
        Me.fees_name.Name = "fees_name"
        Me.fees_name.ReadOnly = True
        Me.fees_name.Visible = False
        '
        'fFeestype_name
        '
        Me.fFeestype_name.DataPropertyName = "feestype_name"
        Me.fFeestype_name.HeaderText = "Fees Type"
        Me.fFeestype_name.Name = "fFeestype_name"
        Me.fFeestype_name.ReadOnly = True
        '
        'FeesAmount
        '
        Me.FeesAmount.DataPropertyName = "fees_amount"
        Me.FeesAmount.HeaderText = "Fees Amount"
        Me.FeesAmount.Name = "FeesAmount"
        Me.FeesAmount.ReadOnly = True
        '
        'txtb_totalFees
        '
        Me.txtb_totalFees.BackColor = System.Drawing.Color.White
        Me.txtb_totalFees.Enabled = False
        Me.txtb_totalFees.Location = New System.Drawing.Point(417, 137)
        Me.txtb_totalFees.Name = "txtb_totalFees"
        Me.txtb_totalFees.Size = New System.Drawing.Size(102, 26)
        Me.txtb_totalFees.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(324, 138)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 21)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "TOTAL FEES"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(-141, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 21)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "TUITION FEE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtb_studAcct_ID)
        Me.GroupBox2.Controls.Add(Me.txtb_rpu)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtb_nUnits)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtb_yl)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtStudentName)
        Me.GroupBox2.Controls.Add(Me.txtb_sem)
        Me.GroupBox2.Controls.Add(Me.txtb_crs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtb_sy)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 166)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STUDENT DETAILS"
        '
        'txtb_studAcct_ID
        '
        Me.txtb_studAcct_ID.BackColor = System.Drawing.Color.White
        Me.txtb_studAcct_ID.Enabled = False
        Me.txtb_studAcct_ID.Location = New System.Drawing.Point(93, 28)
        Me.txtb_studAcct_ID.Name = "txtb_studAcct_ID"
        Me.txtb_studAcct_ID.Size = New System.Drawing.Size(216, 26)
        Me.txtb_studAcct_ID.TabIndex = 20
        '
        'txtb_rpu
        '
        Me.txtb_rpu.BackColor = System.Drawing.Color.White
        Me.txtb_rpu.Enabled = False
        Me.txtb_rpu.Location = New System.Drawing.Point(415, 128)
        Me.txtb_rpu.Name = "txtb_rpu"
        Me.txtb_rpu.Size = New System.Drawing.Size(101, 26)
        Me.txtb_rpu.TabIndex = 21
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(316, 133)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(96, 21)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "RATE PER UNIT"
        '
        'txtb_nUnits
        '
        Me.txtb_nUnits.BackColor = System.Drawing.Color.White
        Me.txtb_nUnits.Enabled = False
        Me.txtb_nUnits.Location = New System.Drawing.Point(93, 128)
        Me.txtb_nUnits.Name = "txtb_nUnits"
        Me.txtb_nUnits.Size = New System.Drawing.Size(116, 26)
        Me.txtb_nUnits.TabIndex = 18
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(7, 30)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(80, 21)
        Me.Label29.TabIndex = 19
        Me.Label29.Text = "STUDENT ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(6, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "YEAR LEVEL"
        '
        'txtb_yl
        '
        Me.txtb_yl.BackColor = System.Drawing.Color.White
        Me.txtb_yl.Enabled = False
        Me.txtb_yl.Location = New System.Drawing.Point(94, 94)
        Me.txtb_yl.Name = "txtb_yl"
        Me.txtb_yl.Size = New System.Drawing.Size(116, 26)
        Me.txtb_yl.TabIndex = 17
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(7, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 21)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "NO. OF UNITS"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.White
        Me.txtStudentName.Enabled = False
        Me.txtStudentName.Location = New System.Drawing.Point(93, 62)
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(216, 26)
        Me.txtStudentName.TabIndex = 6
        '
        'txtb_sem
        '
        Me.txtb_sem.BackColor = System.Drawing.Color.White
        Me.txtb_sem.Enabled = False
        Me.txtb_sem.Location = New System.Drawing.Point(402, 64)
        Me.txtb_sem.Name = "txtb_sem"
        Me.txtb_sem.Size = New System.Drawing.Size(115, 26)
        Me.txtb_sem.TabIndex = 14
        '
        'txtb_crs
        '
        Me.txtb_crs.BackColor = System.Drawing.Color.White
        Me.txtb_crs.Enabled = False
        Me.txtb_crs.Location = New System.Drawing.Point(281, 94)
        Me.txtb_crs.Name = "txtb_crs"
        Me.txtb_crs.Size = New System.Drawing.Size(236, 26)
        Me.txtb_crs.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(312, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 21)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "SCHOOL YEAR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(216, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 21)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "COURSE"
        '
        'txtb_sy
        '
        Me.txtb_sy.BackColor = System.Drawing.Color.White
        Me.txtb_sy.Enabled = False
        Me.txtb_sy.Location = New System.Drawing.Point(401, 28)
        Me.txtb_sy.Name = "txtb_sy"
        Me.txtb_sy.Size = New System.Drawing.Size(115, 26)
        Me.txtb_sy.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(330, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "SEMESTER"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(6, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "FULL NAME"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.cbo_sortSem)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.cbo_sortSY)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(539, 13)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(491, 57)
        Me.GroupBox6.TabIndex = 47
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SORT BY"
        '
        'cbo_sortSem
        '
        Me.cbo_sortSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sortSem.FormattingEnabled = True
        Me.cbo_sortSem.Items.AddRange(New Object() {"1ST SEMESTER", "2ND SEMESTER"})
        Me.cbo_sortSem.Location = New System.Drawing.Point(272, 22)
        Me.cbo_sortSem.Name = "cbo_sortSem"
        Me.cbo_sortSem.Size = New System.Drawing.Size(140, 29)
        Me.cbo_sortSem.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(194, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 21)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "SEMESTER"
        '
        'cbo_sortSY
        '
        Me.cbo_sortSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sortSY.FormattingEnabled = True
        Me.cbo_sortSY.Items.AddRange(New Object() {"2029-2030", "2028-2029", "2027-2028", "2026-2027", "2025-2026", "2024-2025", "2023-2024", "2022-2023", "2021-2022", "2020-2021"})
        Me.cbo_sortSY.Location = New System.Drawing.Point(46, 22)
        Me.cbo_sortSY.Name = "cbo_sortSY"
        Me.cbo_sortSY.Size = New System.Drawing.Size(140, 29)
        Me.cbo_sortSY.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(7, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 21)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "S.Y."
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dg_displayTotalFees)
        Me.GroupBox4.Controls.Add(Me.txtb_totalBal)
        Me.GroupBox4.Controls.Add(Me.txtb_totalFeesAmount)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.pnl_scholar)
        Me.GroupBox4.Enabled = False
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(5, 351)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(531, 222)
        Me.GroupBox4.TabIndex = 44
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " TOTAL STUDENT PAYMENTS FOR THE SEMESTER"
        '
        'dg_displayTotalFees
        '
        Me.dg_displayTotalFees.AllowUserToAddRows = False
        Me.dg_displayTotalFees.AllowUserToDeleteRows = False
        Me.dg_displayTotalFees.AllowUserToResizeColumns = False
        Me.dg_displayTotalFees.AllowUserToResizeRows = False
        Me.dg_displayTotalFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_displayTotalFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_displayTotalFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypeFees, Me.AmountFees})
        Me.dg_displayTotalFees.Enabled = False
        Me.dg_displayTotalFees.Location = New System.Drawing.Point(13, 25)
        Me.dg_displayTotalFees.Name = "dg_displayTotalFees"
        Me.dg_displayTotalFees.ReadOnly = True
        Me.dg_displayTotalFees.RowHeadersVisible = False
        Me.dg_displayTotalFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_displayTotalFees.Size = New System.Drawing.Size(506, 97)
        Me.dg_displayTotalFees.TabIndex = 22
        '
        'TypeFees
        '
        Me.TypeFees.DataPropertyName = "fees_name"
        Me.TypeFees.HeaderText = "Fees Type"
        Me.TypeFees.Name = "TypeFees"
        Me.TypeFees.ReadOnly = True
        '
        'AmountFees
        '
        Me.AmountFees.DataPropertyName = "totalpay"
        Me.AmountFees.HeaderText = "Fees Amount"
        Me.AmountFees.Name = "AmountFees"
        Me.AmountFees.ReadOnly = True
        '
        'txtb_totalBal
        '
        Me.txtb_totalBal.BackColor = System.Drawing.Color.White
        Me.txtb_totalBal.Enabled = False
        Me.txtb_totalBal.Location = New System.Drawing.Point(417, 190)
        Me.txtb_totalBal.Name = "txtb_totalBal"
        Me.txtb_totalBal.Size = New System.Drawing.Size(102, 26)
        Me.txtb_totalBal.TabIndex = 21
        '
        'txtb_totalFeesAmount
        '
        Me.txtb_totalFeesAmount.BackColor = System.Drawing.Color.White
        Me.txtb_totalFeesAmount.Enabled = False
        Me.txtb_totalFeesAmount.Location = New System.Drawing.Point(417, 134)
        Me.txtb_totalFeesAmount.Name = "txtb_totalFeesAmount"
        Me.txtb_totalFeesAmount.Size = New System.Drawing.Size(102, 26)
        Me.txtb_totalFeesAmount.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(307, 193)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(105, 21)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "TOTAL BALANCE"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(301, 139)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(101, 21)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "TOTAL AMOUNT"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(-141, 4)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 21)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "TUITION FEE"
        '
        'pnl_scholar
        '
        Me.pnl_scholar.Controls.Add(Me.txtb_sPaidAmnt)
        Me.pnl_scholar.Controls.Add(Me.Label49)
        Me.pnl_scholar.Controls.Add(Me.txtb_sType)
        Me.pnl_scholar.Controls.Add(Me.Label48)
        Me.pnl_scholar.Controls.Add(Me.Label47)
        Me.pnl_scholar.Controls.Add(Me.txtb_sAmnt)
        Me.pnl_scholar.Controls.Add(Me.Label46)
        Me.pnl_scholar.Location = New System.Drawing.Point(11, 128)
        Me.pnl_scholar.Name = "pnl_scholar"
        Me.pnl_scholar.Size = New System.Drawing.Size(290, 94)
        Me.pnl_scholar.TabIndex = 26
        Me.pnl_scholar.Visible = False
        '
        'txtb_sPaidAmnt
        '
        Me.txtb_sPaidAmnt.BackColor = System.Drawing.Color.White
        Me.txtb_sPaidAmnt.Enabled = False
        Me.txtb_sPaidAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sPaidAmnt.Location = New System.Drawing.Point(192, 68)
        Me.txtb_sPaidAmnt.Name = "txtb_sPaidAmnt"
        Me.txtb_sPaidAmnt.Size = New System.Drawing.Size(93, 20)
        Me.txtb_sPaidAmnt.TabIndex = 30
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label49.Location = New System.Drawing.Point(-1, 68)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(187, 18)
        Me.Label49.TabIndex = 29
        Me.Label49.Text = "TOTAL PAID BY SCHOLARSHIP"
        '
        'txtb_sType
        '
        Me.txtb_sType.BackColor = System.Drawing.Color.White
        Me.txtb_sType.Enabled = False
        Me.txtb_sType.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sType.Location = New System.Drawing.Point(121, 24)
        Me.txtb_sType.Name = "txtb_sType"
        Me.txtb_sType.Size = New System.Drawing.Size(104, 20)
        Me.txtb_sType.TabIndex = 28
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label48.Location = New System.Drawing.Point(12, 47)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(107, 18)
        Me.Label48.TabIndex = 27
        Me.Label48.Text = "SCHOLAR AMOUNT"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label47.Location = New System.Drawing.Point(12, 26)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(85, 18)
        Me.Label47.TabIndex = 26
        Me.Label47.Text = "SCHOLAR TYPE"
        '
        'txtb_sAmnt
        '
        Me.txtb_sAmnt.BackColor = System.Drawing.Color.White
        Me.txtb_sAmnt.Enabled = False
        Me.txtb_sAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sAmnt.Location = New System.Drawing.Point(121, 46)
        Me.txtb_sAmnt.Name = "txtb_sAmnt"
        Me.txtb_sAmnt.Size = New System.Drawing.Size(104, 20)
        Me.txtb_sAmnt.TabIndex = 25
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label46.Location = New System.Drawing.Point(66, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(158, 21)
        Me.Label46.TabIndex = 24
        Me.Label46.Text = "HAS AN ACTIVE SCHOLAR"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.dg_acctRec)
        Me.GroupBox5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(539, 76)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(491, 454)
        Me.GroupBox5.TabIndex = 45
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PARTICULARS OF PAYMENT"
        '
        'dg_acctRec
        '
        Me.dg_acctRec.AllowUserToAddRows = False
        Me.dg_acctRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_acctRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dg_acctRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_acctRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_acctRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_acctRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_acctRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dg_acctRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_acctRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stdacct_id, Me.or_id, Me.sa_date, Me.sa_particulars, Me.sa_amountPaid, Me.sa_balance})
        Me.dg_acctRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_acctRec.DoubleBuffered = True
        Me.dg_acctRec.EnableHeadersVisualStyles = False
        Me.dg_acctRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_acctRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_acctRec.Location = New System.Drawing.Point(3, 19)
        Me.dg_acctRec.MultiSelect = False
        Me.dg_acctRec.Name = "dg_acctRec"
        Me.dg_acctRec.ReadOnly = True
        Me.dg_acctRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_acctRec.RowHeadersVisible = False
        Me.dg_acctRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_acctRec.Size = New System.Drawing.Size(485, 432)
        Me.dg_acctRec.TabIndex = 0
        '
        'stdacct_id
        '
        Me.stdacct_id.DataPropertyName = "stdacct_id"
        Me.stdacct_id.HeaderText = "ID"
        Me.stdacct_id.Name = "stdacct_id"
        Me.stdacct_id.ReadOnly = True
        Me.stdacct_id.Visible = False
        '
        'or_id
        '
        Me.or_id.DataPropertyName = "stdacct_tN"
        Me.or_id.HeaderText = "OR No."
        Me.or_id.Name = "or_id"
        Me.or_id.ReadOnly = True
        '
        'sa_date
        '
        Me.sa_date.DataPropertyName = "stdacct_tDate"
        DataGridViewCellStyle15.Format = "yyyy-MM-dd"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.sa_date.DefaultCellStyle = DataGridViewCellStyle15
        Me.sa_date.HeaderText = "DATE"
        Me.sa_date.Name = "sa_date"
        Me.sa_date.ReadOnly = True
        '
        'sa_particulars
        '
        Me.sa_particulars.DataPropertyName = "feestype_name"
        Me.sa_particulars.HeaderText = "PARTICULARS"
        Me.sa_particulars.Name = "sa_particulars"
        Me.sa_particulars.ReadOnly = True
        '
        'sa_amountPaid
        '
        Me.sa_amountPaid.DataPropertyName = "stdacct_tAmount"
        Me.sa_amountPaid.HeaderText = "AMOUNT PAID"
        Me.sa_amountPaid.Name = "sa_amountPaid"
        Me.sa_amountPaid.ReadOnly = True
        '
        'sa_balance
        '
        Me.sa_balance.DataPropertyName = "stdacct_tBalance"
        Me.sa_balance.HeaderText = "Balance"
        Me.sa_balance.Name = "sa_balance"
        Me.sa_balance.ReadOnly = True
        '
        'elem_dept
        '
        Me.elem_dept.BackColor = System.Drawing.SystemColors.Control
        Me.elem_dept.Controls.Add(Me.GroupBox18)
        Me.elem_dept.Controls.Add(Me.GroupBox9)
        Me.elem_dept.Controls.Add(Me.GroupBox8)
        Me.elem_dept.Controls.Add(Me.GroupBox7)
        Me.elem_dept.Controls.Add(Me.GroupBox1)
        Me.elem_dept.Location = New System.Drawing.Point(4, 30)
        Me.elem_dept.Name = "elem_dept"
        Me.elem_dept.Padding = New System.Windows.Forms.Padding(3)
        Me.elem_dept.Size = New System.Drawing.Size(1035, 576)
        Me.elem_dept.TabIndex = 1
        Me.elem_dept.Text = "Elementary Dept"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.cbo_eSortSY)
        Me.GroupBox18.Controls.Add(Me.Label44)
        Me.GroupBox18.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox18.Location = New System.Drawing.Point(477, 194)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(538, 52)
        Me.GroupBox18.TabIndex = 51
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "SORT BY"
        '
        'cbo_eSortSY
        '
        Me.cbo_eSortSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eSortSY.FormattingEnabled = True
        Me.cbo_eSortSY.Items.AddRange(New Object() {"2029-2030", "2028-2029", "2027-2028", "2026-2027", "2025-2026", "2024-2025", "2023-2024", "2022-2023", "2021-2022", "2020-2021"})
        Me.cbo_eSortSY.Location = New System.Drawing.Point(46, 22)
        Me.cbo_eSortSY.Name = "cbo_eSortSY"
        Me.cbo_eSortSY.Size = New System.Drawing.Size(188, 25)
        Me.cbo_eSortSY.TabIndex = 19
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label44.Location = New System.Drawing.Point(7, 30)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(31, 18)
        Me.Label44.TabIndex = 19
        Me.Label44.Text = "S.Y."
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.dg_eStudAcctRec)
        Me.GroupBox9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(477, 252)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(538, 301)
        Me.GroupBox9.TabIndex = 50
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "PARTICULARS OF PAYMENT"
        '
        'dg_eStudAcctRec
        '
        Me.dg_eStudAcctRec.AllowUserToAddRows = False
        Me.dg_eStudAcctRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_eStudAcctRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dg_eStudAcctRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_eStudAcctRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_eStudAcctRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_eStudAcctRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_eStudAcctRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dg_eStudAcctRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_eStudAcctRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.dg_eStudAcctRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_eStudAcctRec.DoubleBuffered = True
        Me.dg_eStudAcctRec.EnableHeadersVisualStyles = False
        Me.dg_eStudAcctRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_eStudAcctRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_eStudAcctRec.Location = New System.Drawing.Point(3, 19)
        Me.dg_eStudAcctRec.MultiSelect = False
        Me.dg_eStudAcctRec.Name = "dg_eStudAcctRec"
        Me.dg_eStudAcctRec.ReadOnly = True
        Me.dg_eStudAcctRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_eStudAcctRec.RowHeadersVisible = False
        Me.dg_eStudAcctRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_eStudAcctRec.Size = New System.Drawing.Size(532, 279)
        Me.dg_eStudAcctRec.TabIndex = 0
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Panel1)
        Me.GroupBox8.Controls.Add(Me.dg_eStudFees)
        Me.GroupBox8.Controls.Add(Me.txtb_eStud_TBal)
        Me.GroupBox8.Controls.Add(Me.txtb_eStudFees_TAmount)
        Me.GroupBox8.Controls.Add(Me.Label17)
        Me.GroupBox8.Controls.Add(Me.Label18)
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Enabled = False
        Me.GroupBox8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.Location = New System.Drawing.Point(6, 175)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(456, 375)
        Me.GroupBox8.TabIndex = 49
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = " TOTAL STUDENT PAYMENTS FOR THE SCHOOL YEAR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label50)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label51)
        Me.Panel1.Controls.Add(Me.Label52)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label53)
        Me.Panel1.Location = New System.Drawing.Point(18, 219)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 94)
        Me.Panel1.TabIndex = 27
        Me.Panel1.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(192, 68)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(93, 20)
        Me.TextBox1.TabIndex = 30
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label50.Location = New System.Drawing.Point(-1, 68)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(187, 18)
        Me.Label50.TabIndex = 29
        Me.Label50.Text = "TOTAL PAID BY SCHOLARSHIP"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(121, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label51.Location = New System.Drawing.Point(12, 47)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(107, 18)
        Me.Label51.TabIndex = 27
        Me.Label51.Text = "SCHOLAR AMOUNT"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label52.Location = New System.Drawing.Point(12, 26)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(85, 18)
        Me.Label52.TabIndex = 26
        Me.Label52.Text = "SCHOLAR TYPE"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(121, 46)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 25
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label53.Location = New System.Drawing.Point(66, 0)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(158, 21)
        Me.Label53.TabIndex = 24
        Me.Label53.Text = "HAS AN ACTIVE SCHOLAR"
        '
        'dg_eStudFees
        '
        Me.dg_eStudFees.AllowUserToAddRows = False
        Me.dg_eStudFees.AllowUserToDeleteRows = False
        Me.dg_eStudFees.AllowUserToResizeColumns = False
        Me.dg_eStudFees.AllowUserToResizeRows = False
        Me.dg_eStudFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_eStudFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_eStudFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ef_id, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.dg_eStudFees.Enabled = False
        Me.dg_eStudFees.Location = New System.Drawing.Point(18, 36)
        Me.dg_eStudFees.Name = "dg_eStudFees"
        Me.dg_eStudFees.RowHeadersVisible = False
        Me.dg_eStudFees.Size = New System.Drawing.Size(421, 177)
        Me.dg_eStudFees.TabIndex = 22
        '
        'ef_id
        '
        Me.ef_id.DataPropertyName = "efees_id"
        Me.ef_id.HeaderText = "ID"
        Me.ef_id.Name = "ef_id"
        Me.ef_id.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "efees_name"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "totalpay"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'txtb_eStud_TBal
        '
        Me.txtb_eStud_TBal.BackColor = System.Drawing.Color.White
        Me.txtb_eStud_TBal.Enabled = False
        Me.txtb_eStud_TBal.Location = New System.Drawing.Point(350, 346)
        Me.txtb_eStud_TBal.Name = "txtb_eStud_TBal"
        Me.txtb_eStud_TBal.Size = New System.Drawing.Size(102, 26)
        Me.txtb_eStud_TBal.TabIndex = 21
        '
        'txtb_eStudFees_TAmount
        '
        Me.txtb_eStudFees_TAmount.BackColor = System.Drawing.Color.White
        Me.txtb_eStudFees_TAmount.Enabled = False
        Me.txtb_eStudFees_TAmount.Location = New System.Drawing.Point(350, 310)
        Me.txtb_eStudFees_TAmount.Name = "txtb_eStudFees_TAmount"
        Me.txtb_eStudFees_TAmount.Size = New System.Drawing.Size(102, 26)
        Me.txtb_eStudFees_TAmount.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(234, 351)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(105, 21)
        Me.Label17.TabIndex = 19
        Me.Label17.Text = "TOTAL BALANCE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(234, 315)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(101, 21)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "TOTAL AMOUNT"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(-141, 4)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 21)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "TUITION FEE"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.dg_Fees)
        Me.GroupBox7.Controls.Add(Me.txtb_eTotalFees)
        Me.GroupBox7.Controls.Add(Me.Label2)
        Me.GroupBox7.Controls.Add(Me.Label11)
        Me.GroupBox7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(477, 6)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(538, 191)
        Me.GroupBox7.TabIndex = 48
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "FEES"
        '
        'dg_Fees
        '
        Me.dg_Fees.AllowUserToAddRows = False
        Me.dg_Fees.AllowUserToDeleteRows = False
        Me.dg_Fees.AllowUserToResizeColumns = False
        Me.dg_Fees.AllowUserToResizeRows = False
        Me.dg_Fees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_Fees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_Fees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dg_Fees.Location = New System.Drawing.Point(15, 25)
        Me.dg_Fees.Name = "dg_Fees"
        Me.dg_Fees.ReadOnly = True
        Me.dg_Fees.RowHeadersVisible = False
        Me.dg_Fees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_Fees.Size = New System.Drawing.Size(505, 114)
        Me.dg_Fees.TabIndex = 23
        '
        'txtb_eTotalFees
        '
        Me.txtb_eTotalFees.BackColor = System.Drawing.Color.White
        Me.txtb_eTotalFees.Enabled = False
        Me.txtb_eTotalFees.Location = New System.Drawing.Point(125, 156)
        Me.txtb_eTotalFees.Name = "txtb_eTotalFees"
        Me.txtb_eTotalFees.Size = New System.Drawing.Size(102, 26)
        Me.txtb_eTotalFees.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(32, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 21)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "TOTAL FEES"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(-141, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 21)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "TUITION FEE"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtb_eStud_id)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtb_eGL)
        Me.GroupBox1.Controls.Add(Me.txtb_eStud_name)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtb_eSY)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 163)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENT DETAILS"
        '
        'txtb_eStud_id
        '
        Me.txtb_eStud_id.BackColor = System.Drawing.Color.White
        Me.txtb_eStud_id.Enabled = False
        Me.txtb_eStud_id.Location = New System.Drawing.Point(161, 27)
        Me.txtb_eStud_id.Name = "txtb_eStud_id"
        Me.txtb_eStud_id.Size = New System.Drawing.Size(268, 26)
        Me.txtb_eStud_id.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(40, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "STUDENT ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(40, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 21)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "GRADE LEVEL"
        '
        'txtb_eGL
        '
        Me.txtb_eGL.BackColor = System.Drawing.Color.White
        Me.txtb_eGL.Enabled = False
        Me.txtb_eGL.Location = New System.Drawing.Point(161, 125)
        Me.txtb_eGL.Name = "txtb_eGL"
        Me.txtb_eGL.Size = New System.Drawing.Size(268, 26)
        Me.txtb_eGL.TabIndex = 17
        '
        'txtb_eStud_name
        '
        Me.txtb_eStud_name.BackColor = System.Drawing.Color.White
        Me.txtb_eStud_name.Enabled = False
        Me.txtb_eStud_name.Location = New System.Drawing.Point(161, 61)
        Me.txtb_eStud_name.Name = "txtb_eStud_name"
        Me.txtb_eStud_name.Size = New System.Drawing.Size(268, 26)
        Me.txtb_eStud_name.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(40, 96)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "SCHOOL YEAR"
        '
        'txtb_eSY
        '
        Me.txtb_eSY.BackColor = System.Drawing.Color.White
        Me.txtb_eSY.Enabled = False
        Me.txtb_eSY.Location = New System.Drawing.Point(161, 93)
        Me.txtb_eSY.Name = "txtb_eSY"
        Me.txtb_eSY.Size = New System.Drawing.Size(268, 26)
        Me.txtb_eSY.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(40, 64)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 21)
        Me.Label22.TabIndex = 7
        Me.Label22.Text = "FULL NAME"
        '
        'sh_dept
        '
        Me.sh_dept.BackColor = System.Drawing.SystemColors.Control
        Me.sh_dept.Controls.Add(Me.GroupBox19)
        Me.sh_dept.Controls.Add(Me.GroupBox14)
        Me.sh_dept.Controls.Add(Me.GroupBox15)
        Me.sh_dept.Controls.Add(Me.GroupBox16)
        Me.sh_dept.Controls.Add(Me.GroupBox17)
        Me.sh_dept.Location = New System.Drawing.Point(4, 30)
        Me.sh_dept.Name = "sh_dept"
        Me.sh_dept.Size = New System.Drawing.Size(1035, 576)
        Me.sh_dept.TabIndex = 3
        Me.sh_dept.Text = "Senior-High Dept"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.cbo_sSortBY)
        Me.GroupBox19.Controls.Add(Me.Label43)
        Me.GroupBox19.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox19.Location = New System.Drawing.Point(484, 216)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(538, 52)
        Me.GroupBox19.TabIndex = 55
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "SORT BY"
        '
        'cbo_sSortBY
        '
        Me.cbo_sSortBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sSortBY.FormattingEnabled = True
        Me.cbo_sSortBY.Location = New System.Drawing.Point(46, 22)
        Me.cbo_sSortBY.Name = "cbo_sSortBY"
        Me.cbo_sSortBY.Size = New System.Drawing.Size(188, 25)
        Me.cbo_sSortBY.TabIndex = 19
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label43.Location = New System.Drawing.Point(7, 30)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(31, 18)
        Me.Label43.TabIndex = 19
        Me.Label43.Text = "S.Y."
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.dg_sStudAcctRec)
        Me.GroupBox14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox14.Location = New System.Drawing.Point(484, 272)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(538, 281)
        Me.GroupBox14.TabIndex = 54
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "PARTICULARS OF PAYMENT"
        '
        'dg_sStudAcctRec
        '
        Me.dg_sStudAcctRec.AllowUserToAddRows = False
        Me.dg_sStudAcctRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_sStudAcctRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dg_sStudAcctRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sStudAcctRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_sStudAcctRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_sStudAcctRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_sStudAcctRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.dg_sStudAcctRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sStudAcctRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30})
        Me.dg_sStudAcctRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_sStudAcctRec.DoubleBuffered = True
        Me.dg_sStudAcctRec.EnableHeadersVisualStyles = False
        Me.dg_sStudAcctRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_sStudAcctRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_sStudAcctRec.Location = New System.Drawing.Point(3, 19)
        Me.dg_sStudAcctRec.MultiSelect = False
        Me.dg_sStudAcctRec.Name = "dg_sStudAcctRec"
        Me.dg_sStudAcctRec.ReadOnly = True
        Me.dg_sStudAcctRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_sStudAcctRec.RowHeadersVisible = False
        Me.dg_sStudAcctRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_sStudAcctRec.Size = New System.Drawing.Size(532, 259)
        Me.dg_sStudAcctRec.TabIndex = 0
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.Panel2)
        Me.GroupBox15.Controls.Add(Me.dg_sStudFees)
        Me.GroupBox15.Controls.Add(Me.txtb_sStud_Bal)
        Me.GroupBox15.Controls.Add(Me.txtb_sStud_TAmount)
        Me.GroupBox15.Controls.Add(Me.Label34)
        Me.GroupBox15.Controls.Add(Me.Label35)
        Me.GroupBox15.Controls.Add(Me.Label36)
        Me.GroupBox15.Enabled = False
        Me.GroupBox15.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(13, 174)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(456, 379)
        Me.GroupBox15.TabIndex = 53
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = " TOTAL STUDENT PAYMENTS FOR THE SCHOOL YEAR"
        '
        'dg_sStudFees
        '
        Me.dg_sStudFees.AllowUserToAddRows = False
        Me.dg_sStudFees.AllowUserToDeleteRows = False
        Me.dg_sStudFees.AllowUserToResizeColumns = False
        Me.dg_sStudFees.AllowUserToResizeRows = False
        Me.dg_sStudFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sStudFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sStudFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sfees_id, Me.DataGridViewTextBoxColumn31, Me.DataGridViewTextBoxColumn32})
        Me.dg_sStudFees.Enabled = False
        Me.dg_sStudFees.Location = New System.Drawing.Point(18, 36)
        Me.dg_sStudFees.Name = "dg_sStudFees"
        Me.dg_sStudFees.RowHeadersVisible = False
        Me.dg_sStudFees.Size = New System.Drawing.Size(421, 177)
        Me.dg_sStudFees.TabIndex = 22
        '
        'sfees_id
        '
        Me.sfees_id.DataPropertyName = "sfees_id"
        Me.sfees_id.HeaderText = "ID"
        Me.sfees_id.Name = "sfees_id"
        Me.sfees_id.Visible = False
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "sfees_name"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "totalpay"
        Me.DataGridViewTextBoxColumn32.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'txtb_sStud_Bal
        '
        Me.txtb_sStud_Bal.BackColor = System.Drawing.Color.White
        Me.txtb_sStud_Bal.Enabled = False
        Me.txtb_sStud_Bal.Location = New System.Drawing.Point(343, 346)
        Me.txtb_sStud_Bal.Name = "txtb_sStud_Bal"
        Me.txtb_sStud_Bal.Size = New System.Drawing.Size(102, 26)
        Me.txtb_sStud_Bal.TabIndex = 21
        '
        'txtb_sStud_TAmount
        '
        Me.txtb_sStud_TAmount.BackColor = System.Drawing.Color.White
        Me.txtb_sStud_TAmount.Enabled = False
        Me.txtb_sStud_TAmount.Location = New System.Drawing.Point(343, 310)
        Me.txtb_sStud_TAmount.Name = "txtb_sStud_TAmount"
        Me.txtb_sStud_TAmount.Size = New System.Drawing.Size(102, 26)
        Me.txtb_sStud_TAmount.TabIndex = 21
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(227, 351)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(105, 21)
        Me.Label34.TabIndex = 19
        Me.Label34.Text = "TOTAL BALANCE"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(227, 315)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(101, 21)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "TOTAL AMOUNT"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(-141, 4)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(81, 21)
        Me.Label36.TabIndex = 15
        Me.Label36.Text = "TUITION FEE"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.dg_sFeesRec)
        Me.GroupBox16.Controls.Add(Me.txtb_sTFees)
        Me.GroupBox16.Controls.Add(Me.Label37)
        Me.GroupBox16.Controls.Add(Me.Label38)
        Me.GroupBox16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.Location = New System.Drawing.Point(484, 6)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(538, 191)
        Me.GroupBox16.TabIndex = 52
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "FEES"
        '
        'dg_sFeesRec
        '
        Me.dg_sFeesRec.AllowUserToAddRows = False
        Me.dg_sFeesRec.AllowUserToDeleteRows = False
        Me.dg_sFeesRec.AllowUserToResizeColumns = False
        Me.dg_sFeesRec.AllowUserToResizeRows = False
        Me.dg_sFeesRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sFeesRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sFeesRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35})
        Me.dg_sFeesRec.Location = New System.Drawing.Point(15, 25)
        Me.dg_sFeesRec.Name = "dg_sFeesRec"
        Me.dg_sFeesRec.ReadOnly = True
        Me.dg_sFeesRec.RowHeadersVisible = False
        Me.dg_sFeesRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_sFeesRec.Size = New System.Drawing.Size(505, 120)
        Me.dg_sFeesRec.TabIndex = 23
        '
        'txtb_sTFees
        '
        Me.txtb_sTFees.BackColor = System.Drawing.Color.White
        Me.txtb_sTFees.Enabled = False
        Me.txtb_sTFees.Location = New System.Drawing.Point(125, 156)
        Me.txtb_sTFees.Name = "txtb_sTFees"
        Me.txtb_sTFees.Size = New System.Drawing.Size(102, 26)
        Me.txtb_sTFees.TabIndex = 20
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label37.Location = New System.Drawing.Point(32, 157)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(78, 21)
        Me.Label37.TabIndex = 19
        Me.Label37.Text = "TOTAL FEES"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label38.Location = New System.Drawing.Point(-141, 4)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(81, 21)
        Me.Label38.TabIndex = 15
        Me.Label38.Text = "TUITION FEE"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.txtb_sStud_id)
        Me.GroupBox17.Controls.Add(Me.Label39)
        Me.GroupBox17.Controls.Add(Me.Label40)
        Me.GroupBox17.Controls.Add(Me.txtb_sGL)
        Me.GroupBox17.Controls.Add(Me.txtb_sStud_name)
        Me.GroupBox17.Controls.Add(Me.Label41)
        Me.GroupBox17.Controls.Add(Me.txtb_sSY)
        Me.GroupBox17.Controls.Add(Me.Label42)
        Me.GroupBox17.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GroupBox17.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(456, 162)
        Me.GroupBox17.TabIndex = 51
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "STUDENT DETAILS"
        '
        'txtb_sStud_id
        '
        Me.txtb_sStud_id.BackColor = System.Drawing.Color.White
        Me.txtb_sStud_id.Enabled = False
        Me.txtb_sStud_id.Location = New System.Drawing.Point(161, 27)
        Me.txtb_sStud_id.Name = "txtb_sStud_id"
        Me.txtb_sStud_id.Size = New System.Drawing.Size(268, 26)
        Me.txtb_sStud_id.TabIndex = 20
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label39.Location = New System.Drawing.Point(40, 30)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 21)
        Me.Label39.TabIndex = 19
        Me.Label39.Text = "STUDENT ID"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label40.Location = New System.Drawing.Point(40, 128)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(89, 21)
        Me.Label40.TabIndex = 16
        Me.Label40.Text = "GRADE LEVEL"
        '
        'txtb_sGL
        '
        Me.txtb_sGL.BackColor = System.Drawing.Color.White
        Me.txtb_sGL.Enabled = False
        Me.txtb_sGL.Location = New System.Drawing.Point(161, 125)
        Me.txtb_sGL.Name = "txtb_sGL"
        Me.txtb_sGL.Size = New System.Drawing.Size(268, 26)
        Me.txtb_sGL.TabIndex = 17
        '
        'txtb_sStud_name
        '
        Me.txtb_sStud_name.BackColor = System.Drawing.Color.White
        Me.txtb_sStud_name.Enabled = False
        Me.txtb_sStud_name.Location = New System.Drawing.Point(161, 61)
        Me.txtb_sStud_name.Name = "txtb_sStud_name"
        Me.txtb_sStud_name.Size = New System.Drawing.Size(268, 26)
        Me.txtb_sStud_name.TabIndex = 6
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label41.Location = New System.Drawing.Point(40, 96)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(93, 21)
        Me.Label41.TabIndex = 13
        Me.Label41.Text = "SCHOOL YEAR"
        '
        'txtb_sSY
        '
        Me.txtb_sSY.BackColor = System.Drawing.Color.White
        Me.txtb_sSY.Enabled = False
        Me.txtb_sSY.Location = New System.Drawing.Point(161, 93)
        Me.txtb_sSY.Name = "txtb_sSY"
        Me.txtb_sSY.Size = New System.Drawing.Size(268, 26)
        Me.txtb_sSY.TabIndex = 12
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label42.Location = New System.Drawing.Point(40, 64)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(78, 21)
        Me.Label42.TabIndex = 7
        Me.Label42.Text = "FULL NAME"
        '
        'jh_dept
        '
        Me.jh_dept.BackColor = System.Drawing.SystemColors.Control
        Me.jh_dept.Controls.Add(Me.GroupBox20)
        Me.jh_dept.Controls.Add(Me.GroupBox10)
        Me.jh_dept.Controls.Add(Me.GroupBox11)
        Me.jh_dept.Controls.Add(Me.GroupBox12)
        Me.jh_dept.Controls.Add(Me.GroupBox13)
        Me.jh_dept.Location = New System.Drawing.Point(4, 30)
        Me.jh_dept.Name = "jh_dept"
        Me.jh_dept.Size = New System.Drawing.Size(1035, 576)
        Me.jh_dept.TabIndex = 2
        Me.jh_dept.Text = "Junior-High Dept"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.cbo_jSortBY)
        Me.GroupBox20.Controls.Add(Me.Label45)
        Me.GroupBox20.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox20.Location = New System.Drawing.Point(481, 220)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(538, 52)
        Me.GroupBox20.TabIndex = 55
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "SORT BY"
        '
        'cbo_jSortBY
        '
        Me.cbo_jSortBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jSortBY.FormattingEnabled = True
        Me.cbo_jSortBY.Location = New System.Drawing.Point(46, 22)
        Me.cbo_jSortBY.Name = "cbo_jSortBY"
        Me.cbo_jSortBY.Size = New System.Drawing.Size(188, 25)
        Me.cbo_jSortBY.TabIndex = 19
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label45.Location = New System.Drawing.Point(7, 30)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(31, 18)
        Me.Label45.TabIndex = 19
        Me.Label45.Text = "S.Y."
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.dg_jStudAcctRec)
        Me.GroupBox10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(484, 278)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(538, 275)
        Me.GroupBox10.TabIndex = 54
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "PARTICULARS OF PAYMENT"
        '
        'dg_jStudAcctRec
        '
        Me.dg_jStudAcctRec.AllowUserToAddRows = False
        Me.dg_jStudAcctRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_jStudAcctRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle22
        Me.dg_jStudAcctRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_jStudAcctRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_jStudAcctRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_jStudAcctRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_jStudAcctRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle23
        Me.dg_jStudAcctRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jStudAcctRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.dg_jStudAcctRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_jStudAcctRec.DoubleBuffered = True
        Me.dg_jStudAcctRec.EnableHeadersVisualStyles = False
        Me.dg_jStudAcctRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_jStudAcctRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_jStudAcctRec.Location = New System.Drawing.Point(3, 19)
        Me.dg_jStudAcctRec.MultiSelect = False
        Me.dg_jStudAcctRec.Name = "dg_jStudAcctRec"
        Me.dg_jStudAcctRec.ReadOnly = True
        Me.dg_jStudAcctRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_jStudAcctRec.RowHeadersVisible = False
        Me.dg_jStudAcctRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_jStudAcctRec.Size = New System.Drawing.Size(532, 253)
        Me.dg_jStudAcctRec.TabIndex = 0
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Panel3)
        Me.GroupBox11.Controls.Add(Me.dg_jStudFees)
        Me.GroupBox11.Controls.Add(Me.txtb_jStudTBal)
        Me.GroupBox11.Controls.Add(Me.txtb_jStudTAmount)
        Me.GroupBox11.Controls.Add(Me.Label24)
        Me.GroupBox11.Controls.Add(Me.Label25)
        Me.GroupBox11.Controls.Add(Me.Label26)
        Me.GroupBox11.Enabled = False
        Me.GroupBox11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(13, 177)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(456, 373)
        Me.GroupBox11.TabIndex = 53
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = " TOTAL STUDENT PAYMENTS FOR THE SCHOOL YEAR"
        '
        'dg_jStudFees
        '
        Me.dg_jStudFees.AllowUserToAddRows = False
        Me.dg_jStudFees.AllowUserToDeleteRows = False
        Me.dg_jStudFees.AllowUserToResizeColumns = False
        Me.dg_jStudFees.AllowUserToResizeRows = False
        Me.dg_jStudFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_jStudFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jStudFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jf_id, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20})
        Me.dg_jStudFees.Enabled = False
        Me.dg_jStudFees.Location = New System.Drawing.Point(18, 25)
        Me.dg_jStudFees.Name = "dg_jStudFees"
        Me.dg_jStudFees.RowHeadersVisible = False
        Me.dg_jStudFees.Size = New System.Drawing.Size(421, 177)
        Me.dg_jStudFees.TabIndex = 22
        '
        'txtb_jStudTBal
        '
        Me.txtb_jStudTBal.BackColor = System.Drawing.Color.White
        Me.txtb_jStudTBal.Enabled = False
        Me.txtb_jStudTBal.Location = New System.Drawing.Point(345, 342)
        Me.txtb_jStudTBal.Name = "txtb_jStudTBal"
        Me.txtb_jStudTBal.Size = New System.Drawing.Size(102, 26)
        Me.txtb_jStudTBal.TabIndex = 21
        '
        'txtb_jStudTAmount
        '
        Me.txtb_jStudTAmount.BackColor = System.Drawing.Color.White
        Me.txtb_jStudTAmount.Enabled = False
        Me.txtb_jStudTAmount.Location = New System.Drawing.Point(345, 306)
        Me.txtb_jStudTAmount.Name = "txtb_jStudTAmount"
        Me.txtb_jStudTAmount.Size = New System.Drawing.Size(102, 26)
        Me.txtb_jStudTAmount.TabIndex = 21
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(229, 347)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(105, 21)
        Me.Label24.TabIndex = 19
        Me.Label24.Text = "TOTAL BALANCE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(229, 311)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(101, 21)
        Me.Label25.TabIndex = 19
        Me.Label25.Text = "TOTAL AMOUNT"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(-141, 4)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 21)
        Me.Label26.TabIndex = 15
        Me.Label26.Text = "TUITION FEE"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.dg_jFees)
        Me.GroupBox12.Controls.Add(Me.txtb_jTFees)
        Me.GroupBox12.Controls.Add(Me.Label27)
        Me.GroupBox12.Controls.Add(Me.Label28)
        Me.GroupBox12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(484, 6)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(538, 191)
        Me.GroupBox12.TabIndex = 52
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "FEES"
        '
        'dg_jFees
        '
        Me.dg_jFees.AllowUserToAddRows = False
        Me.dg_jFees.AllowUserToDeleteRows = False
        Me.dg_jFees.AllowUserToResizeColumns = False
        Me.dg_jFees.AllowUserToResizeRows = False
        Me.dg_jFees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_jFees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jFees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23})
        Me.dg_jFees.Location = New System.Drawing.Point(15, 25)
        Me.dg_jFees.Name = "dg_jFees"
        Me.dg_jFees.ReadOnly = True
        Me.dg_jFees.RowHeadersVisible = False
        Me.dg_jFees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_jFees.Size = New System.Drawing.Size(505, 120)
        Me.dg_jFees.TabIndex = 23
        '
        'txtb_jTFees
        '
        Me.txtb_jTFees.BackColor = System.Drawing.Color.White
        Me.txtb_jTFees.Enabled = False
        Me.txtb_jTFees.Location = New System.Drawing.Point(125, 156)
        Me.txtb_jTFees.Name = "txtb_jTFees"
        Me.txtb_jTFees.Size = New System.Drawing.Size(102, 26)
        Me.txtb_jTFees.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(32, 157)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 21)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "TOTAL FEES"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(-141, 4)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(81, 21)
        Me.Label28.TabIndex = 15
        Me.Label28.Text = "TUITION FEE"
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.txtb_jStud_ID)
        Me.GroupBox13.Controls.Add(Me.Label30)
        Me.GroupBox13.Controls.Add(Me.Label31)
        Me.GroupBox13.Controls.Add(Me.txtb_jGL)
        Me.GroupBox13.Controls.Add(Me.txtb_jStud_name)
        Me.GroupBox13.Controls.Add(Me.Label32)
        Me.GroupBox13.Controls.Add(Me.txtb_jSY)
        Me.GroupBox13.Controls.Add(Me.Label33)
        Me.GroupBox13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.GroupBox13.Location = New System.Drawing.Point(13, 6)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(456, 162)
        Me.GroupBox13.TabIndex = 51
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "STUDENT DETAILS"
        '
        'txtb_jStud_ID
        '
        Me.txtb_jStud_ID.BackColor = System.Drawing.Color.White
        Me.txtb_jStud_ID.Enabled = False
        Me.txtb_jStud_ID.Location = New System.Drawing.Point(161, 27)
        Me.txtb_jStud_ID.Name = "txtb_jStud_ID"
        Me.txtb_jStud_ID.Size = New System.Drawing.Size(268, 26)
        Me.txtb_jStud_ID.TabIndex = 20
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(40, 30)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(80, 21)
        Me.Label30.TabIndex = 19
        Me.Label30.Text = "STUDENT ID"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(40, 128)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(89, 21)
        Me.Label31.TabIndex = 16
        Me.Label31.Text = "GRADE LEVEL"
        '
        'txtb_jGL
        '
        Me.txtb_jGL.BackColor = System.Drawing.Color.White
        Me.txtb_jGL.Enabled = False
        Me.txtb_jGL.Location = New System.Drawing.Point(161, 125)
        Me.txtb_jGL.Name = "txtb_jGL"
        Me.txtb_jGL.Size = New System.Drawing.Size(268, 26)
        Me.txtb_jGL.TabIndex = 17
        '
        'txtb_jStud_name
        '
        Me.txtb_jStud_name.BackColor = System.Drawing.Color.White
        Me.txtb_jStud_name.Enabled = False
        Me.txtb_jStud_name.Location = New System.Drawing.Point(161, 61)
        Me.txtb_jStud_name.Name = "txtb_jStud_name"
        Me.txtb_jStud_name.Size = New System.Drawing.Size(268, 26)
        Me.txtb_jStud_name.TabIndex = 6
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(40, 96)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(93, 21)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "SCHOOL YEAR"
        '
        'txtb_jSY
        '
        Me.txtb_jSY.BackColor = System.Drawing.Color.White
        Me.txtb_jSY.Enabled = False
        Me.txtb_jSY.Location = New System.Drawing.Point(161, 93)
        Me.txtb_jSY.Name = "txtb_jSY"
        Me.txtb_jSY.Size = New System.Drawing.Size(268, 26)
        Me.txtb_jSY.TabIndex = 12
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(40, 64)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(78, 21)
        Me.Label33.TabIndex = 7
        Me.Label33.Text = "FULL NAME"
        '
        'sp_balance
        '
        Me.sp_balance.HeaderText = "Balance"
        Me.sp_balance.Name = "sp_balance"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox4)
        Me.Panel2.Controls.Add(Me.Label54)
        Me.Panel2.Controls.Add(Me.TextBox5)
        Me.Panel2.Controls.Add(Me.Label55)
        Me.Panel2.Controls.Add(Me.Label56)
        Me.Panel2.Controls.Add(Me.TextBox6)
        Me.Panel2.Controls.Add(Me.Label57)
        Me.Panel2.Location = New System.Drawing.Point(18, 219)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(290, 94)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(192, 68)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(93, 20)
        Me.TextBox4.TabIndex = 30
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label54.Location = New System.Drawing.Point(-1, 68)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(187, 18)
        Me.Label54.TabIndex = 29
        Me.Label54.Text = "TOTAL PAID BY SCHOLARSHIP"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(121, 24)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 20)
        Me.TextBox5.TabIndex = 28
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label55.Location = New System.Drawing.Point(12, 47)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(107, 18)
        Me.Label55.TabIndex = 27
        Me.Label55.Text = "SCHOLAR AMOUNT"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label56.Location = New System.Drawing.Point(12, 26)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(85, 18)
        Me.Label56.TabIndex = 26
        Me.Label56.Text = "SCHOLAR TYPE"
        '
        'TextBox6
        '
        Me.TextBox6.BackColor = System.Drawing.Color.White
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(121, 46)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(104, 20)
        Me.TextBox6.TabIndex = 25
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label57.Location = New System.Drawing.Point(66, 0)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(158, 21)
        Me.Label57.TabIndex = 24
        Me.Label57.Text = "HAS AN ACTIVE SCHOLAR"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox7)
        Me.Panel3.Controls.Add(Me.Label58)
        Me.Panel3.Controls.Add(Me.TextBox8)
        Me.Panel3.Controls.Add(Me.Label59)
        Me.Panel3.Controls.Add(Me.Label60)
        Me.Panel3.Controls.Add(Me.TextBox9)
        Me.Panel3.Controls.Add(Me.Label61)
        Me.Panel3.Location = New System.Drawing.Point(18, 208)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(290, 94)
        Me.Panel3.TabIndex = 27
        Me.Panel3.Visible = False
        '
        'TextBox7
        '
        Me.TextBox7.BackColor = System.Drawing.Color.White
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(192, 68)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(93, 20)
        Me.TextBox7.TabIndex = 30
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label58.Location = New System.Drawing.Point(-1, 68)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(187, 18)
        Me.Label58.TabIndex = 29
        Me.Label58.Text = "TOTAL PAID BY SCHOLARSHIP"
        '
        'TextBox8
        '
        Me.TextBox8.BackColor = System.Drawing.Color.White
        Me.TextBox8.Enabled = False
        Me.TextBox8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(121, 24)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(104, 20)
        Me.TextBox8.TabIndex = 28
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label59.Location = New System.Drawing.Point(12, 47)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(107, 18)
        Me.Label59.TabIndex = 27
        Me.Label59.Text = "SCHOLAR AMOUNT"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label60.Location = New System.Drawing.Point(12, 26)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(85, 18)
        Me.Label60.TabIndex = 26
        Me.Label60.Text = "SCHOLAR TYPE"
        '
        'TextBox9
        '
        Me.TextBox9.BackColor = System.Drawing.Color.White
        Me.TextBox9.Enabled = False
        Me.TextBox9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(121, 46)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(104, 20)
        Me.TextBox9.TabIndex = 25
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label61.Location = New System.Drawing.Point(66, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(158, 21)
        Me.Label61.TabIndex = 24
        Me.Label61.Text = "HAS AN ACTIVE SCHOLAR"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "efees_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Fees ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "efees_amount"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "sfees_id"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Fees ID"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.ReadOnly = True
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.ReadOnly = True
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "sfees_amount"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.ReadOnly = True
        '
        'jf_id
        '
        Me.jf_id.DataPropertyName = "jfees_id"
        Me.jf_id.HeaderText = "ID"
        Me.jf_id.Name = "jf_id"
        Me.jf_id.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn19.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "totalpay"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "estud_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "etan"
        Me.DataGridViewTextBoxColumn8.HeaderText = "OR No."
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "edate_paidamount"
        DataGridViewCellStyle18.Format = "yyyy-MM-dd"
        DataGridViewCellStyle18.NullValue = Nothing
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn9.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "PARTICULARS"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "epay_amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "AMOUNT PAID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "ebal_amount"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "sstud_id"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "stan"
        Me.DataGridViewTextBoxColumn26.HeaderText = "OR No."
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "sdate_paidamount"
        DataGridViewCellStyle21.Format = "yyyy-MM-dd"
        DataGridViewCellStyle21.NullValue = Nothing
        Me.DataGridViewTextBoxColumn27.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn27.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn28.HeaderText = "PARTICULARS"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.ReadOnly = True
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "spay_amount"
        Me.DataGridViewTextBoxColumn29.HeaderText = "AMOUNT PAID"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "sbal_amount"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "jstud_id"
        Me.DataGridViewTextBoxColumn13.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "jtan"
        Me.DataGridViewTextBoxColumn14.HeaderText = "OR No."
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "jdate_paidamount"
        DataGridViewCellStyle24.Format = "yyyy-MM-dd"
        DataGridViewCellStyle24.NullValue = Nothing
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle24
        Me.DataGridViewTextBoxColumn15.HeaderText = "DATE"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn16.HeaderText = "PARTICULARS"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "jpay_amount"
        Me.DataGridViewTextBoxColumn17.HeaderText = "AMOUNT PAID"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "jbal_amount"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "jfees_name"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Fees ID"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "feestype_name"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "jfees_amount"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.ReadOnly = True
        '
        'frm_SAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_SAccounts"
        Me.Size = New System.Drawing.Size(1043, 610)
        Me.TabControl1.ResumeLayout(False)
        Me.college_dept.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_studFeesType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dg_displayTotalFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_scholar.ResumeLayout(False)
        Me.pnl_scholar.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dg_acctRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.elem_dept.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox18.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dg_eStudAcctRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_eStudFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.dg_Fees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.sh_dept.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox19.PerformLayout()
        Me.GroupBox14.ResumeLayout(False)
        CType(Me.dg_sStudAcctRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox15.PerformLayout()
        CType(Me.dg_sStudFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox16.PerformLayout()
        CType(Me.dg_sFeesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox17.PerformLayout()
        Me.jh_dept.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox20.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.dg_jStudAcctRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        CType(Me.dg_jStudFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        CType(Me.dg_jFees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents college_dept As System.Windows.Forms.TabPage
    Friend WithEvents btn_UpdateCacct As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_studFeesType As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_totalFees As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents txtb_studAcct_ID As System.Windows.Forms.TextBox
    Friend WithEvents txtb_rpu As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtb_nUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtb_yl As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents txtStudentName As System.Windows.Forms.TextBox
    Friend WithEvents txtb_sem As System.Windows.Forms.TextBox
    Friend WithEvents txtb_crs As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtb_sy As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_sortSem As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cbo_sortSY As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_displayTotalFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_totalBal As System.Windows.Forms.TextBox
    Friend WithEvents txtb_totalFeesAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_acctRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents elem_dept As System.Windows.Forms.TabPage
    Friend WithEvents sp_balance As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_eStudFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_eStud_TBal As System.Windows.Forms.TextBox
    Friend WithEvents txtb_eStudFees_TAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_Fees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_eTotalFees As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtb_eStud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtb_eGL As System.Windows.Forms.TextBox
    Public WithEvents txtb_eStud_name As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtb_eSY As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_eStudAcctRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents TypeFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AmountFees As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents jh_dept As System.Windows.Forms.TabPage
    Friend WithEvents sh_dept As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_jStudAcctRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_jStudFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_jStudTBal As System.Windows.Forms.TextBox
    Friend WithEvents txtb_jStudTAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_jFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_jTFees As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Private WithEvents txtb_jStud_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtb_jGL As System.Windows.Forms.TextBox
    Public WithEvents txtb_jStud_name As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtb_jSY As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_sStudAcctRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_sStudFees As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_sStud_Bal As System.Windows.Forms.TextBox
    Friend WithEvents txtb_sStud_TAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_sFeesRec As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_sTFees As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Private WithEvents txtb_sStud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtb_sGL As System.Windows.Forms.TextBox
    Public WithEvents txtb_sStud_name As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtb_sSY As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents GroupBox18 As GroupBox
    Friend WithEvents cbo_eSortSY As ComboBox
    Friend WithEvents Label44 As Label
    Friend WithEvents GroupBox19 As GroupBox
    Friend WithEvents cbo_sSortBY As ComboBox
    Friend WithEvents Label43 As Label
    Friend WithEvents GroupBox20 As GroupBox
    Friend WithEvents cbo_jSortBY As ComboBox
    Friend WithEvents Label45 As Label
    Friend WithEvents ef_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents sfees_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents pnl_scholar As Panel
    Friend WithEvents txtb_sType As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents txtb_sAmnt As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents txtb_sPaidAmnt As TextBox
    Friend WithEvents Label49 As Label
    Friend WithEvents fees_name As DataGridViewTextBoxColumn
    Friend WithEvents fFeestype_name As DataGridViewTextBoxColumn
    Friend WithEvents FeesAmount As DataGridViewTextBoxColumn
    Friend WithEvents stdacct_id As DataGridViewTextBoxColumn
    Friend WithEvents or_id As DataGridViewTextBoxColumn
    Friend WithEvents sa_date As DataGridViewTextBoxColumn
    Friend WithEvents sa_particulars As DataGridViewTextBoxColumn
    Friend WithEvents sa_amountPaid As DataGridViewTextBoxColumn
    Friend WithEvents sa_balance As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label50 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label51 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label53 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label54 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents Label56 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label57 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label58 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label59 As Label
    Friend WithEvents Label60 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label61 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents jf_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
End Class
