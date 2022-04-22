<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_slists
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.college_dept = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_backStudAcct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.dg_studR = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.s_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_fName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_lName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_Midi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sem_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yl_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.crs_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_gotoAcct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_updtStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_addNstud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cbo_schyear = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbo_yearlevel = New System.Windows.Forms.ComboBox()
        Me.txtb_studFname = New System.Windows.Forms.TextBox()
        Me.txtb_studMI = New System.Windows.Forms.TextBox()
        Me.txtb_noUnits = New System.Windows.Forms.TextBox()
        Me.txtb_studLname = New System.Windows.Forms.TextBox()
        Me.txtb_RpU = New System.Windows.Forms.TextBox()
        Me.cbo_course = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_sem = New System.Windows.Forms.ComboBox()
        Me.txtb_studId = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_SearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_Search = New System.Windows.Forms.TextBox()
        Me.elem_dept = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton11 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.RadioButton6 = New System.Windows.Forms.RadioButton()
        Me.dg_eStudRecords = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.col_estud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estud_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estud_lname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_estud_mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_esy_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_egl_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_eCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_eViewAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_eSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_eUpdateNewStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_eAddNewStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cbo_eSYName = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cbo_eGradeLevel = New System.Windows.Forms.ComboBox()
        Me.txtb_eStudFname = New System.Windows.Forms.TextBox()
        Me.txtb_estudMI = New System.Windows.Forms.TextBox()
        Me.txtb_estudLname = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtb_eStudID = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.cbo_eSearchBY = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtb_eSearch = New System.Windows.Forms.TextBox()
        Me.seniorHigh_dept = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton6 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.dg_sStudRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.col_sStud_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sStud_fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sStud_lanme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sStud_mi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sSY = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sGL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_sCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_sViewAccount = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_sSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_sUpdateStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_sAddStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cbo_sSY = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbo_sGL = New System.Windows.Forms.ComboBox()
        Me.txtb_sFname = New System.Windows.Forms.TextBox()
        Me.txtb_smi = New System.Windows.Forms.TextBox()
        Me.txtb_sLname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtb_sStud_id = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_sSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtb_sSearch = New System.Windows.Forms.TextBox()
        Me.juniorHigh_dept = New System.Windows.Forms.TabPage()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton13 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.RadioButton7 = New System.Windows.Forms.RadioButton()
        Me.RadioButton8 = New System.Windows.Forms.RadioButton()
        Me.dg_jStudRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.btn_jCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_jViewAcct = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_jSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_jUpdateStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_jAddStud = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cbo_jSY = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbo_jGL = New System.Windows.Forms.ComboBox()
        Me.txtb_jStudFname = New System.Windows.Forms.TextBox()
        Me.txtb_jStudMI = New System.Windows.Forms.TextBox()
        Me.txtb_jStudLname = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtb_jStud_id = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbo_jSearchBy = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtb_jSearch = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.college_dept.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_studR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.elem_dept.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.dg_eStudRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.seniorHigh_dept.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dg_sStudRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.juniorHigh_dept.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.dg_jStudRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.college_dept)
        Me.TabControl1.Controls.Add(Me.elem_dept)
        Me.TabControl1.Controls.Add(Me.seniorHigh_dept)
        Me.TabControl1.Controls.Add(Me.juniorHigh_dept)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1154, 664)
        Me.TabControl1.TabIndex = 0
        '
        'college_dept
        '
        Me.college_dept.BackColor = System.Drawing.SystemColors.Control
        Me.college_dept.Controls.Add(Me.Panel2)
        Me.college_dept.Controls.Add(Me.Panel1)
        Me.college_dept.Controls.Add(Me.GroupBox1)
        Me.college_dept.Location = New System.Drawing.Point(4, 29)
        Me.college_dept.Name = "college_dept"
        Me.college_dept.Padding = New System.Windows.Forms.Padding(3)
        Me.college_dept.Size = New System.Drawing.Size(1146, 631)
        Me.college_dept.TabIndex = 0
        Me.college_dept.Text = "College  Dept."
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.dg_studR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(373, 73)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 555)
        Me.Panel2.TabIndex = 48
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_backStudAcct)
        Me.Panel3.Controls.Add(Me.RadioButton1)
        Me.Panel3.Controls.Add(Me.RadioButton2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 498)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(770, 57)
        Me.Panel3.TabIndex = 48
        '
        'btn_backStudAcct
        '
        Me.btn_backStudAcct.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_backStudAcct.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btn_backStudAcct.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_backStudAcct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_backStudAcct.BorderRadius = 0
        Me.btn_backStudAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_backStudAcct.ButtonText = "BACKUP STUDENTS ACCOUNT"
        Me.btn_backStudAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_backStudAcct.DisabledColor = System.Drawing.Color.Gray
        Me.btn_backStudAcct.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_backStudAcct.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_backStudAcct.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_backStudAcct.Iconimage = Nothing
        Me.btn_backStudAcct.Iconimage_right = Nothing
        Me.btn_backStudAcct.Iconimage_right_Selected = Nothing
        Me.btn_backStudAcct.Iconimage_Selected = Nothing
        Me.btn_backStudAcct.IconMarginLeft = 0
        Me.btn_backStudAcct.IconMarginRight = 0
        Me.btn_backStudAcct.IconRightVisible = False
        Me.btn_backStudAcct.IconRightZoom = 0R
        Me.btn_backStudAcct.IconVisible = False
        Me.btn_backStudAcct.IconZoom = 90.0R
        Me.btn_backStudAcct.IsTab = False
        Me.btn_backStudAcct.Location = New System.Drawing.Point(43, 8)
        Me.btn_backStudAcct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_backStudAcct.Name = "btn_backStudAcct"
        Me.btn_backStudAcct.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_backStudAcct.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_backStudAcct.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_backStudAcct.selected = False
        Me.btn_backStudAcct.Size = New System.Drawing.Size(212, 35)
        Me.btn_backStudAcct.TabIndex = 52
        Me.btn_backStudAcct.Text = "BACKUP STUDENTS ACCOUNT"
        Me.btn_backStudAcct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_backStudAcct.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_backStudAcct.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(341, 18)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(133, 25)
        Me.RadioButton1.TabIndex = 50
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ACTIVE STUDENTS"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(489, 18)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(146, 25)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "INACTIVE STUDENTS"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'dg_studR
        '
        Me.dg_studR.AllowUserToAddRows = False
        Me.dg_studR.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_studR.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_studR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_studR.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_studR.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_studR.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_studR.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_studR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_studR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.s_id, Me.s_fName, Me.s_lName, Me.s_Midi, Me.sy_id, Me.sem_id, Me.yl_id, Me.crs_id})
        Me.dg_studR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_studR.DoubleBuffered = True
        Me.dg_studR.EnableHeadersVisualStyles = False
        Me.dg_studR.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_studR.HeaderForeColor = System.Drawing.Color.White
        Me.dg_studR.Location = New System.Drawing.Point(0, 0)
        Me.dg_studR.Name = "dg_studR"
        Me.dg_studR.ReadOnly = True
        Me.dg_studR.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_studR.RowHeadersVisible = False
        Me.dg_studR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_studR.Size = New System.Drawing.Size(770, 555)
        Me.dg_studR.TabIndex = 47
        '
        's_id
        '
        Me.s_id.DataPropertyName = "stud_id"
        Me.s_id.HeaderText = "Stud. id"
        Me.s_id.Name = "s_id"
        Me.s_id.ReadOnly = True
        '
        's_fName
        '
        Me.s_fName.DataPropertyName = "stud_fname"
        Me.s_fName.HeaderText = "First Name"
        Me.s_fName.Name = "s_fName"
        Me.s_fName.ReadOnly = True
        '
        's_lName
        '
        Me.s_lName.DataPropertyName = "stud_Lname"
        Me.s_lName.HeaderText = "Last Name"
        Me.s_lName.Name = "s_lName"
        Me.s_lName.ReadOnly = True
        '
        's_Midi
        '
        Me.s_Midi.DataPropertyName = "stud_midI"
        Me.s_Midi.HeaderText = "Middle Initial"
        Me.s_Midi.Name = "s_Midi"
        Me.s_Midi.ReadOnly = True
        '
        'sy_id
        '
        Me.sy_id.DataPropertyName = "sy_id"
        Me.sy_id.HeaderText = "S/Y"
        Me.sy_id.Name = "sy_id"
        Me.sy_id.ReadOnly = True
        Me.sy_id.Visible = False
        '
        'sem_id
        '
        Me.sem_id.DataPropertyName = "sem_id"
        Me.sem_id.HeaderText = "sem"
        Me.sem_id.Name = "sem_id"
        Me.sem_id.ReadOnly = True
        Me.sem_id.Visible = False
        '
        'yl_id
        '
        Me.yl_id.DataPropertyName = "yl_id"
        Me.yl_id.HeaderText = "YL"
        Me.yl_id.Name = "yl_id"
        Me.yl_id.ReadOnly = True
        Me.yl_id.Visible = False
        '
        'crs_id
        '
        Me.crs_id.DataPropertyName = "crs_id"
        Me.crs_id.HeaderText = "course"
        Me.crs_id.Name = "crs_id"
        Me.crs_id.ReadOnly = True
        Me.crs_id.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_gotoAcct)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_updtStud)
        Me.Panel1.Controls.Add(Me.btn_addNstud)
        Me.Panel1.Controls.Add(Me.cbo_schyear)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cbo_yearlevel)
        Me.Panel1.Controls.Add(Me.txtb_studFname)
        Me.Panel1.Controls.Add(Me.txtb_studMI)
        Me.Panel1.Controls.Add(Me.txtb_noUnits)
        Me.Panel1.Controls.Add(Me.txtb_studLname)
        Me.Panel1.Controls.Add(Me.txtb_RpU)
        Me.Panel1.Controls.Add(Me.cbo_course)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cbo_sem)
        Me.Panel1.Controls.Add(Me.txtb_studId)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(3, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(370, 555)
        Me.Panel1.TabIndex = 47
        '
        'btn_cancel
        '
        Me.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_cancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.BorderRadius = 0
        Me.btn_cancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_cancel.ButtonText = "CANCEL"
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_cancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_cancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_cancel.Iconimage = Nothing
        Me.btn_cancel.Iconimage_right = Nothing
        Me.btn_cancel.Iconimage_right_Selected = Nothing
        Me.btn_cancel.Iconimage_Selected = Nothing
        Me.btn_cancel.IconMarginLeft = 0
        Me.btn_cancel.IconMarginRight = 0
        Me.btn_cancel.IconRightVisible = False
        Me.btn_cancel.IconRightZoom = 0R
        Me.btn_cancel.IconVisible = False
        Me.btn_cancel.IconZoom = 90.0R
        Me.btn_cancel.IsTab = False
        Me.btn_cancel.Location = New System.Drawing.Point(44, 477)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancel.selected = False
        Me.btn_cancel.Size = New System.Drawing.Size(136, 35)
        Me.btn_cancel.TabIndex = 54
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_cancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_gotoAcct
        '
        Me.btn_gotoAcct.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_gotoAcct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_gotoAcct.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_gotoAcct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_gotoAcct.BorderRadius = 0
        Me.btn_gotoAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_gotoAcct.ButtonText = "VIEW ACCOUNT"
        Me.btn_gotoAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_gotoAcct.DisabledColor = System.Drawing.Color.Gray
        Me.btn_gotoAcct.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_gotoAcct.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_gotoAcct.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_gotoAcct.Iconimage = Nothing
        Me.btn_gotoAcct.Iconimage_right = Nothing
        Me.btn_gotoAcct.Iconimage_right_Selected = Nothing
        Me.btn_gotoAcct.Iconimage_Selected = Nothing
        Me.btn_gotoAcct.IconMarginLeft = 0
        Me.btn_gotoAcct.IconMarginRight = 0
        Me.btn_gotoAcct.IconRightVisible = False
        Me.btn_gotoAcct.IconRightZoom = 0R
        Me.btn_gotoAcct.IconVisible = False
        Me.btn_gotoAcct.IconZoom = 90.0R
        Me.btn_gotoAcct.IsTab = False
        Me.btn_gotoAcct.Location = New System.Drawing.Point(44, 396)
        Me.btn_gotoAcct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_gotoAcct.Name = "btn_gotoAcct"
        Me.btn_gotoAcct.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_gotoAcct.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_gotoAcct.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_gotoAcct.selected = False
        Me.btn_gotoAcct.Size = New System.Drawing.Size(283, 35)
        Me.btn_gotoAcct.TabIndex = 53
        Me.btn_gotoAcct.Text = "VIEW ACCOUNT"
        Me.btn_gotoAcct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_gotoAcct.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_gotoAcct.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_save
        '
        Me.btn_save.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_save.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_save.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.BorderRadius = 0
        Me.btn_save.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_save.ButtonText = "SAVE"
        Me.btn_save.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_save.DisabledColor = System.Drawing.Color.Gray
        Me.btn_save.Enabled = False
        Me.btn_save.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_save.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_save.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_save.Iconimage = Nothing
        Me.btn_save.Iconimage_right = Nothing
        Me.btn_save.Iconimage_right_Selected = Nothing
        Me.btn_save.Iconimage_Selected = Nothing
        Me.btn_save.IconMarginLeft = 0
        Me.btn_save.IconMarginRight = 0
        Me.btn_save.IconRightVisible = False
        Me.btn_save.IconRightZoom = 0R
        Me.btn_save.IconVisible = False
        Me.btn_save.IconZoom = 90.0R
        Me.btn_save.IsTab = False
        Me.btn_save.Location = New System.Drawing.Point(192, 477)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(136, 35)
        Me.btn_save.TabIndex = 52
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_save.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_updtStud
        '
        Me.btn_updtStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_updtStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_updtStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updtStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updtStud.BorderRadius = 0
        Me.btn_updtStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_updtStud.ButtonText = "UPDATE STUDENT"
        Me.btn_updtStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_updtStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_updtStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_updtStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_updtStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_updtStud.Iconimage = Nothing
        Me.btn_updtStud.Iconimage_right = Nothing
        Me.btn_updtStud.Iconimage_right_Selected = Nothing
        Me.btn_updtStud.Iconimage_Selected = Nothing
        Me.btn_updtStud.IconMarginLeft = 0
        Me.btn_updtStud.IconMarginRight = 0
        Me.btn_updtStud.IconRightVisible = False
        Me.btn_updtStud.IconRightZoom = 0R
        Me.btn_updtStud.IconVisible = False
        Me.btn_updtStud.IconZoom = 90.0R
        Me.btn_updtStud.IsTab = False
        Me.btn_updtStud.Location = New System.Drawing.Point(192, 437)
        Me.btn_updtStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_updtStud.Name = "btn_updtStud"
        Me.btn_updtStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_updtStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_updtStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_updtStud.selected = False
        Me.btn_updtStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_updtStud.TabIndex = 51
        Me.btn_updtStud.Text = "UPDATE STUDENT"
        Me.btn_updtStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_updtStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_updtStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_addNstud
        '
        Me.btn_addNstud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_addNstud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_addNstud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addNstud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addNstud.BorderRadius = 0
        Me.btn_addNstud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_addNstud.ButtonText = "ADD NEW STUDENT"
        Me.btn_addNstud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addNstud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_addNstud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_addNstud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_addNstud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_addNstud.Iconimage = Nothing
        Me.btn_addNstud.Iconimage_right = Nothing
        Me.btn_addNstud.Iconimage_right_Selected = Nothing
        Me.btn_addNstud.Iconimage_Selected = Nothing
        Me.btn_addNstud.IconMarginLeft = 0
        Me.btn_addNstud.IconMarginRight = 0
        Me.btn_addNstud.IconRightVisible = False
        Me.btn_addNstud.IconRightZoom = 0R
        Me.btn_addNstud.IconVisible = False
        Me.btn_addNstud.IconZoom = 90.0R
        Me.btn_addNstud.IsTab = False
        Me.btn_addNstud.Location = New System.Drawing.Point(45, 437)
        Me.btn_addNstud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_addNstud.Name = "btn_addNstud"
        Me.btn_addNstud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_addNstud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_addNstud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_addNstud.selected = False
        Me.btn_addNstud.Size = New System.Drawing.Size(136, 35)
        Me.btn_addNstud.TabIndex = 49
        Me.btn_addNstud.Text = "ADD NEW STUDENT"
        Me.btn_addNstud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_addNstud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_addNstud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbo_schyear
        '
        Me.cbo_schyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_schyear.Enabled = False
        Me.cbo_schyear.FormattingEnabled = True
        Me.cbo_schyear.Location = New System.Drawing.Point(117, 164)
        Me.cbo_schyear.Name = "cbo_schyear"
        Me.cbo_schyear.Size = New System.Drawing.Size(223, 29)
        Me.cbo_schyear.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(27, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 21)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "SCH-YEAR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(25, 322)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 21)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "NO. OF UNITS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(26, 359)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 21)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "RATE PER UNIT"
        '
        'cbo_yearlevel
        '
        Me.cbo_yearlevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_yearlevel.Enabled = False
        Me.cbo_yearlevel.FormattingEnabled = True
        Me.cbo_yearlevel.Location = New System.Drawing.Point(116, 200)
        Me.cbo_yearlevel.Name = "cbo_yearlevel"
        Me.cbo_yearlevel.Size = New System.Drawing.Size(223, 29)
        Me.cbo_yearlevel.TabIndex = 46
        '
        'txtb_studFname
        '
        Me.txtb_studFname.BackColor = System.Drawing.Color.White
        Me.txtb_studFname.Enabled = False
        Me.txtb_studFname.Location = New System.Drawing.Point(117, 61)
        Me.txtb_studFname.Name = "txtb_studFname"
        Me.txtb_studFname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_studFname.TabIndex = 45
        '
        'txtb_studMI
        '
        Me.txtb_studMI.BackColor = System.Drawing.Color.White
        Me.txtb_studMI.Enabled = False
        Me.txtb_studMI.Location = New System.Drawing.Point(117, 127)
        Me.txtb_studMI.Name = "txtb_studMI"
        Me.txtb_studMI.Size = New System.Drawing.Size(222, 26)
        Me.txtb_studMI.TabIndex = 43
        '
        'txtb_noUnits
        '
        Me.txtb_noUnits.BackColor = System.Drawing.Color.White
        Me.txtb_noUnits.Enabled = False
        Me.txtb_noUnits.Location = New System.Drawing.Point(218, 317)
        Me.txtb_noUnits.Name = "txtb_noUnits"
        Me.txtb_noUnits.Size = New System.Drawing.Size(121, 26)
        Me.txtb_noUnits.TabIndex = 38
        '
        'txtb_studLname
        '
        Me.txtb_studLname.BackColor = System.Drawing.Color.White
        Me.txtb_studLname.Enabled = False
        Me.txtb_studLname.Location = New System.Drawing.Point(117, 95)
        Me.txtb_studLname.Name = "txtb_studLname"
        Me.txtb_studLname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_studLname.TabIndex = 34
        '
        'txtb_RpU
        '
        Me.txtb_RpU.BackColor = System.Drawing.Color.White
        Me.txtb_RpU.Enabled = False
        Me.txtb_RpU.Location = New System.Drawing.Point(218, 354)
        Me.txtb_RpU.Name = "txtb_RpU"
        Me.txtb_RpU.Size = New System.Drawing.Size(121, 26)
        Me.txtb_RpU.TabIndex = 38
        '
        'cbo_course
        '
        Me.cbo_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_course.Enabled = False
        Me.cbo_course.FormattingEnabled = True
        Me.cbo_course.Location = New System.Drawing.Point(117, 274)
        Me.cbo_course.Name = "cbo_course"
        Me.cbo_course.Size = New System.Drawing.Size(223, 29)
        Me.cbo_course.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(25, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(33, 21)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "M.I."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(27, 282)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 21)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "COURSE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(25, 245)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "SEMESTER"
        '
        'cbo_sem
        '
        Me.cbo_sem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sem.Enabled = False
        Me.cbo_sem.FormattingEnabled = True
        Me.cbo_sem.Location = New System.Drawing.Point(116, 237)
        Me.cbo_sem.Name = "cbo_sem"
        Me.cbo_sem.Size = New System.Drawing.Size(223, 29)
        Me.cbo_sem.TabIndex = 29
        '
        'txtb_studId
        '
        Me.txtb_studId.BackColor = System.Drawing.Color.White
        Me.txtb_studId.Enabled = False
        Me.txtb_studId.Location = New System.Drawing.Point(117, 24)
        Me.txtb_studId.Name = "txtb_studId"
        Me.txtb_studId.Size = New System.Drawing.Size(222, 26)
        Me.txtb_studId.TabIndex = 28
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(26, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "STUDENT ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(26, 208)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "YEAR LEVEL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(25, 100)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 21)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "LAST NAME"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(26, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 21)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "FIRST NAME"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_SearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtb_Search)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1140, 70)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH FOR STUDENT"
        '
        'cbo_SearchBy
        '
        Me.cbo_SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SearchBy.FormattingEnabled = True
        Me.cbo_SearchBy.Items.AddRange(New Object() {"ID Number", "Name"})
        Me.cbo_SearchBy.Location = New System.Drawing.Point(328, 19)
        Me.cbo_SearchBy.Name = "cbo_SearchBy"
        Me.cbo_SearchBy.Size = New System.Drawing.Size(142, 33)
        Me.cbo_SearchBy.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(298, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "BY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(218, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "SEARCH"
        '
        'txtb_Search
        '
        Me.txtb_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtb_Search.Location = New System.Drawing.Point(497, 20)
        Me.txtb_Search.Name = "txtb_Search"
        Me.txtb_Search.Size = New System.Drawing.Size(425, 30)
        Me.txtb_Search.TabIndex = 13
        '
        'elem_dept
        '
        Me.elem_dept.BackColor = System.Drawing.SystemColors.Control
        Me.elem_dept.Controls.Add(Me.Panel8)
        Me.elem_dept.Controls.Add(Me.Panel7)
        Me.elem_dept.Controls.Add(Me.GroupBox5)
        Me.elem_dept.Location = New System.Drawing.Point(4, 29)
        Me.elem_dept.Name = "elem_dept"
        Me.elem_dept.Size = New System.Drawing.Size(1146, 631)
        Me.elem_dept.TabIndex = 4
        Me.elem_dept.Text = "Elementary Dept."
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.dg_eStudRecords)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(370, 70)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(776, 561)
        Me.Panel8.TabIndex = 49
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.BunifuFlatButton11)
        Me.Panel9.Controls.Add(Me.RadioButton5)
        Me.Panel9.Controls.Add(Me.RadioButton6)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 504)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(776, 57)
        Me.Panel9.TabIndex = 48
        '
        'BunifuFlatButton11
        '
        Me.BunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton11.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuFlatButton11.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton11.BorderRadius = 0
        Me.BunifuFlatButton11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuFlatButton11.ButtonText = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.BunifuFlatButton11.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton11.Iconimage = Nothing
        Me.BunifuFlatButton11.Iconimage_right = Nothing
        Me.BunifuFlatButton11.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton11.Iconimage_Selected = Nothing
        Me.BunifuFlatButton11.IconMarginLeft = 0
        Me.BunifuFlatButton11.IconMarginRight = 0
        Me.BunifuFlatButton11.IconRightVisible = False
        Me.BunifuFlatButton11.IconRightZoom = 0R
        Me.BunifuFlatButton11.IconVisible = False
        Me.BunifuFlatButton11.IconZoom = 90.0R
        Me.BunifuFlatButton11.IsTab = False
        Me.BunifuFlatButton11.Location = New System.Drawing.Point(49, 8)
        Me.BunifuFlatButton11.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BunifuFlatButton11.Name = "BunifuFlatButton11"
        Me.BunifuFlatButton11.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton11.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.BunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton11.selected = False
        Me.BunifuFlatButton11.Size = New System.Drawing.Size(212, 35)
        Me.BunifuFlatButton11.TabIndex = 52
        Me.BunifuFlatButton11.Text = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton11.Textcolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton11.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Checked = True
        Me.RadioButton5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(341, 18)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(133, 25)
        Me.RadioButton5.TabIndex = 50
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "ACTIVE STUDENTS"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'RadioButton6
        '
        Me.RadioButton6.AutoSize = True
        Me.RadioButton6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(489, 18)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.Size = New System.Drawing.Size(146, 25)
        Me.RadioButton6.TabIndex = 1
        Me.RadioButton6.Text = "INACTIVE STUDENTS"
        Me.RadioButton6.UseVisualStyleBackColor = True
        '
        'dg_eStudRecords
        '
        Me.dg_eStudRecords.AllowUserToAddRows = False
        Me.dg_eStudRecords.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_eStudRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_eStudRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_eStudRecords.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_eStudRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_eStudRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_eStudRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dg_eStudRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_eStudRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_estud_id, Me.col_estud_fname, Me.col_estud_lname, Me.col_estud_mi, Me.col_esy_id, Me.col_egl_id})
        Me.dg_eStudRecords.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_eStudRecords.DoubleBuffered = True
        Me.dg_eStudRecords.EnableHeadersVisualStyles = False
        Me.dg_eStudRecords.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_eStudRecords.HeaderForeColor = System.Drawing.Color.White
        Me.dg_eStudRecords.Location = New System.Drawing.Point(0, 0)
        Me.dg_eStudRecords.Name = "dg_eStudRecords"
        Me.dg_eStudRecords.ReadOnly = True
        Me.dg_eStudRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_eStudRecords.RowHeadersVisible = False
        Me.dg_eStudRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_eStudRecords.Size = New System.Drawing.Size(776, 561)
        Me.dg_eStudRecords.TabIndex = 47
        '
        'col_estud_id
        '
        Me.col_estud_id.DataPropertyName = "estud_id"
        Me.col_estud_id.HeaderText = "Stud. id"
        Me.col_estud_id.Name = "col_estud_id"
        Me.col_estud_id.ReadOnly = True
        '
        'col_estud_fname
        '
        Me.col_estud_fname.DataPropertyName = "estud_fname"
        Me.col_estud_fname.HeaderText = "First Name"
        Me.col_estud_fname.Name = "col_estud_fname"
        Me.col_estud_fname.ReadOnly = True
        '
        'col_estud_lname
        '
        Me.col_estud_lname.DataPropertyName = "estud_Lname"
        Me.col_estud_lname.HeaderText = "Last Name"
        Me.col_estud_lname.Name = "col_estud_lname"
        Me.col_estud_lname.ReadOnly = True
        '
        'col_estud_mi
        '
        Me.col_estud_mi.DataPropertyName = "estud_mi"
        Me.col_estud_mi.HeaderText = "Middle Initial"
        Me.col_estud_mi.Name = "col_estud_mi"
        Me.col_estud_mi.ReadOnly = True
        '
        'col_esy_id
        '
        Me.col_esy_id.DataPropertyName = "esy_id"
        Me.col_esy_id.HeaderText = "S/Y"
        Me.col_esy_id.Name = "col_esy_id"
        Me.col_esy_id.ReadOnly = True
        Me.col_esy_id.Visible = False
        '
        'col_egl_id
        '
        Me.col_egl_id.DataPropertyName = "egl_id"
        Me.col_egl_id.HeaderText = "GL"
        Me.col_egl_id.Name = "col_egl_id"
        Me.col_egl_id.ReadOnly = True
        Me.col_egl_id.Visible = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btn_eCancel)
        Me.Panel7.Controls.Add(Me.btn_eViewAccount)
        Me.Panel7.Controls.Add(Me.btn_eSave)
        Me.Panel7.Controls.Add(Me.btn_eUpdateNewStud)
        Me.Panel7.Controls.Add(Me.btn_eAddNewStud)
        Me.Panel7.Controls.Add(Me.cbo_eSYName)
        Me.Panel7.Controls.Add(Me.Label23)
        Me.Panel7.Controls.Add(Me.cbo_eGradeLevel)
        Me.Panel7.Controls.Add(Me.txtb_eStudFname)
        Me.Panel7.Controls.Add(Me.txtb_estudMI)
        Me.Panel7.Controls.Add(Me.txtb_estudLname)
        Me.Panel7.Controls.Add(Me.Label30)
        Me.Panel7.Controls.Add(Me.txtb_eStudID)
        Me.Panel7.Controls.Add(Me.Label33)
        Me.Panel7.Controls.Add(Me.Label34)
        Me.Panel7.Controls.Add(Me.Label35)
        Me.Panel7.Controls.Add(Me.Label36)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(0, 70)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(370, 561)
        Me.Panel7.TabIndex = 48
        '
        'btn_eCancel
        '
        Me.btn_eCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eCancel.BorderRadius = 0
        Me.btn_eCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eCancel.ButtonText = "CANCEL"
        Me.btn_eCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eCancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eCancel.Enabled = False
        Me.btn_eCancel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eCancel.Iconimage = Nothing
        Me.btn_eCancel.Iconimage_right = Nothing
        Me.btn_eCancel.Iconimage_right_Selected = Nothing
        Me.btn_eCancel.Iconimage_Selected = Nothing
        Me.btn_eCancel.IconMarginLeft = 0
        Me.btn_eCancel.IconMarginRight = 0
        Me.btn_eCancel.IconRightVisible = False
        Me.btn_eCancel.IconRightZoom = 0R
        Me.btn_eCancel.IconVisible = False
        Me.btn_eCancel.IconZoom = 90.0R
        Me.btn_eCancel.IsTab = False
        Me.btn_eCancel.Location = New System.Drawing.Point(43, 457)
        Me.btn_eCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eCancel.Name = "btn_eCancel"
        Me.btn_eCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eCancel.selected = False
        Me.btn_eCancel.Size = New System.Drawing.Size(136, 35)
        Me.btn_eCancel.TabIndex = 54
        Me.btn_eCancel.Text = "CANCEL"
        Me.btn_eCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_eViewAccount
        '
        Me.btn_eViewAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eViewAccount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eViewAccount.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eViewAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eViewAccount.BorderRadius = 0
        Me.btn_eViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eViewAccount.ButtonText = "VIEW ACCOUNT"
        Me.btn_eViewAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eViewAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eViewAccount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eViewAccount.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eViewAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eViewAccount.Iconimage = Nothing
        Me.btn_eViewAccount.Iconimage_right = Nothing
        Me.btn_eViewAccount.Iconimage_right_Selected = Nothing
        Me.btn_eViewAccount.Iconimage_Selected = Nothing
        Me.btn_eViewAccount.IconMarginLeft = 0
        Me.btn_eViewAccount.IconMarginRight = 0
        Me.btn_eViewAccount.IconRightVisible = False
        Me.btn_eViewAccount.IconRightZoom = 0R
        Me.btn_eViewAccount.IconVisible = False
        Me.btn_eViewAccount.IconZoom = 90.0R
        Me.btn_eViewAccount.IsTab = False
        Me.btn_eViewAccount.Location = New System.Drawing.Point(43, 350)
        Me.btn_eViewAccount.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eViewAccount.Name = "btn_eViewAccount"
        Me.btn_eViewAccount.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eViewAccount.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eViewAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eViewAccount.selected = False
        Me.btn_eViewAccount.Size = New System.Drawing.Size(283, 35)
        Me.btn_eViewAccount.TabIndex = 53
        Me.btn_eViewAccount.Text = "VIEW ACCOUNT"
        Me.btn_eViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eViewAccount.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eViewAccount.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_eSave
        '
        Me.btn_eSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eSave.BorderRadius = 0
        Me.btn_eSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eSave.ButtonText = "SAVE"
        Me.btn_eSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eSave.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eSave.Enabled = False
        Me.btn_eSave.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eSave.Iconimage = Nothing
        Me.btn_eSave.Iconimage_right = Nothing
        Me.btn_eSave.Iconimage_right_Selected = Nothing
        Me.btn_eSave.Iconimage_Selected = Nothing
        Me.btn_eSave.IconMarginLeft = 0
        Me.btn_eSave.IconMarginRight = 0
        Me.btn_eSave.IconRightVisible = False
        Me.btn_eSave.IconRightZoom = 0R
        Me.btn_eSave.IconVisible = False
        Me.btn_eSave.IconZoom = 90.0R
        Me.btn_eSave.IsTab = False
        Me.btn_eSave.Location = New System.Drawing.Point(191, 457)
        Me.btn_eSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eSave.Name = "btn_eSave"
        Me.btn_eSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eSave.selected = False
        Me.btn_eSave.Size = New System.Drawing.Size(136, 35)
        Me.btn_eSave.TabIndex = 52
        Me.btn_eSave.Text = "SAVE"
        Me.btn_eSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_eUpdateNewStud
        '
        Me.btn_eUpdateNewStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eUpdateNewStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eUpdateNewStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eUpdateNewStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eUpdateNewStud.BorderRadius = 0
        Me.btn_eUpdateNewStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eUpdateNewStud.ButtonText = "UPDATE STUDENT"
        Me.btn_eUpdateNewStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eUpdateNewStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eUpdateNewStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eUpdateNewStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eUpdateNewStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eUpdateNewStud.Iconimage = Nothing
        Me.btn_eUpdateNewStud.Iconimage_right = Nothing
        Me.btn_eUpdateNewStud.Iconimage_right_Selected = Nothing
        Me.btn_eUpdateNewStud.Iconimage_Selected = Nothing
        Me.btn_eUpdateNewStud.IconMarginLeft = 0
        Me.btn_eUpdateNewStud.IconMarginRight = 0
        Me.btn_eUpdateNewStud.IconRightVisible = False
        Me.btn_eUpdateNewStud.IconRightZoom = 0R
        Me.btn_eUpdateNewStud.IconVisible = False
        Me.btn_eUpdateNewStud.IconZoom = 90.0R
        Me.btn_eUpdateNewStud.IsTab = False
        Me.btn_eUpdateNewStud.Location = New System.Drawing.Point(191, 401)
        Me.btn_eUpdateNewStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eUpdateNewStud.Name = "btn_eUpdateNewStud"
        Me.btn_eUpdateNewStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eUpdateNewStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eUpdateNewStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eUpdateNewStud.selected = False
        Me.btn_eUpdateNewStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_eUpdateNewStud.TabIndex = 51
        Me.btn_eUpdateNewStud.Text = "UPDATE STUDENT"
        Me.btn_eUpdateNewStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eUpdateNewStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eUpdateNewStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_eAddNewStud
        '
        Me.btn_eAddNewStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eAddNewStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_eAddNewStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eAddNewStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eAddNewStud.BorderRadius = 0
        Me.btn_eAddNewStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eAddNewStud.ButtonText = "ADD NEW STUDENT"
        Me.btn_eAddNewStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eAddNewStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eAddNewStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eAddNewStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eAddNewStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eAddNewStud.Iconimage = Nothing
        Me.btn_eAddNewStud.Iconimage_right = Nothing
        Me.btn_eAddNewStud.Iconimage_right_Selected = Nothing
        Me.btn_eAddNewStud.Iconimage_Selected = Nothing
        Me.btn_eAddNewStud.IconMarginLeft = 0
        Me.btn_eAddNewStud.IconMarginRight = 0
        Me.btn_eAddNewStud.IconRightVisible = False
        Me.btn_eAddNewStud.IconRightZoom = 0R
        Me.btn_eAddNewStud.IconVisible = False
        Me.btn_eAddNewStud.IconZoom = 90.0R
        Me.btn_eAddNewStud.IsTab = False
        Me.btn_eAddNewStud.Location = New System.Drawing.Point(44, 401)
        Me.btn_eAddNewStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eAddNewStud.Name = "btn_eAddNewStud"
        Me.btn_eAddNewStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eAddNewStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eAddNewStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eAddNewStud.selected = False
        Me.btn_eAddNewStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_eAddNewStud.TabIndex = 49
        Me.btn_eAddNewStud.Text = "ADD NEW STUDENT"
        Me.btn_eAddNewStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eAddNewStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eAddNewStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbo_eSYName
        '
        Me.cbo_eSYName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eSYName.Enabled = False
        Me.cbo_eSYName.FormattingEnabled = True
        Me.cbo_eSYName.Location = New System.Drawing.Point(117, 191)
        Me.cbo_eSYName.Name = "cbo_eSYName"
        Me.cbo_eSYName.Size = New System.Drawing.Size(223, 29)
        Me.cbo_eSYName.TabIndex = 50
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label23.Location = New System.Drawing.Point(22, 196)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 21)
        Me.Label23.TabIndex = 49
        Me.Label23.Text = "SCH-YEAR"
        '
        'cbo_eGradeLevel
        '
        Me.cbo_eGradeLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eGradeLevel.Enabled = False
        Me.cbo_eGradeLevel.FormattingEnabled = True
        Me.cbo_eGradeLevel.Location = New System.Drawing.Point(116, 236)
        Me.cbo_eGradeLevel.Name = "cbo_eGradeLevel"
        Me.cbo_eGradeLevel.Size = New System.Drawing.Size(223, 29)
        Me.cbo_eGradeLevel.TabIndex = 46
        '
        'txtb_eStudFname
        '
        Me.txtb_eStudFname.BackColor = System.Drawing.Color.White
        Me.txtb_eStudFname.Enabled = False
        Me.txtb_eStudFname.Location = New System.Drawing.Point(117, 65)
        Me.txtb_eStudFname.Name = "txtb_eStudFname"
        Me.txtb_eStudFname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_eStudFname.TabIndex = 45
        '
        'txtb_estudMI
        '
        Me.txtb_estudMI.BackColor = System.Drawing.Color.White
        Me.txtb_estudMI.Enabled = False
        Me.txtb_estudMI.Location = New System.Drawing.Point(117, 149)
        Me.txtb_estudMI.Name = "txtb_estudMI"
        Me.txtb_estudMI.Size = New System.Drawing.Size(222, 26)
        Me.txtb_estudMI.TabIndex = 43
        '
        'txtb_estudLname
        '
        Me.txtb_estudLname.BackColor = System.Drawing.Color.White
        Me.txtb_estudLname.Enabled = False
        Me.txtb_estudLname.Location = New System.Drawing.Point(117, 107)
        Me.txtb_estudLname.Name = "txtb_estudLname"
        Me.txtb_estudLname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_estudLname.TabIndex = 34
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label30.Location = New System.Drawing.Point(20, 153)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(33, 21)
        Me.Label30.TabIndex = 39
        Me.Label30.Text = "M.I."
        '
        'txtb_eStudID
        '
        Me.txtb_eStudID.BackColor = System.Drawing.Color.White
        Me.txtb_eStudID.Enabled = False
        Me.txtb_eStudID.Location = New System.Drawing.Point(117, 23)
        Me.txtb_eStudID.Name = "txtb_eStudID"
        Me.txtb_eStudID.Size = New System.Drawing.Size(222, 26)
        Me.txtb_eStudID.TabIndex = 28
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label33.Location = New System.Drawing.Point(21, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(80, 21)
        Me.Label33.TabIndex = 27
        Me.Label33.Text = "STUDENT ID"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label34.Location = New System.Drawing.Point(21, 239)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(89, 21)
        Me.Label34.TabIndex = 26
        Me.Label34.Text = "GRADE LEVEL"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label35.Location = New System.Drawing.Point(20, 110)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(77, 21)
        Me.Label35.TabIndex = 24
        Me.Label35.Text = "LAST NAME"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label36.Location = New System.Drawing.Point(21, 67)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(81, 21)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "FIRST NAME"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbo_eSearchBY)
        Me.GroupBox5.Controls.Add(Me.Label20)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Controls.Add(Me.txtb_eSearch)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1146, 70)
        Me.GroupBox5.TabIndex = 39
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SEARCH FOR STUDENT"
        '
        'cbo_eSearchBY
        '
        Me.cbo_eSearchBY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eSearchBY.FormattingEnabled = True
        Me.cbo_eSearchBY.Items.AddRange(New Object() {"ID Number", "Name"})
        Me.cbo_eSearchBY.Location = New System.Drawing.Point(328, 19)
        Me.cbo_eSearchBY.Name = "cbo_eSearchBY"
        Me.cbo_eSearchBY.Size = New System.Drawing.Size(142, 33)
        Me.cbo_eSearchBY.TabIndex = 15
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label20.Location = New System.Drawing.Point(298, 24)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(31, 25)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "BY"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label21.Location = New System.Drawing.Point(218, 23)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(74, 25)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "SEARCH"
        '
        'txtb_eSearch
        '
        Me.txtb_eSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtb_eSearch.Location = New System.Drawing.Point(497, 20)
        Me.txtb_eSearch.Name = "txtb_eSearch"
        Me.txtb_eSearch.Size = New System.Drawing.Size(425, 30)
        Me.txtb_eSearch.TabIndex = 13
        '
        'seniorHigh_dept
        '
        Me.seniorHigh_dept.BackColor = System.Drawing.SystemColors.Control
        Me.seniorHigh_dept.Controls.Add(Me.Panel5)
        Me.seniorHigh_dept.Controls.Add(Me.Panel4)
        Me.seniorHigh_dept.Controls.Add(Me.GroupBox3)
        Me.seniorHigh_dept.Location = New System.Drawing.Point(4, 29)
        Me.seniorHigh_dept.Name = "seniorHigh_dept"
        Me.seniorHigh_dept.Size = New System.Drawing.Size(1146, 631)
        Me.seniorHigh_dept.TabIndex = 2
        Me.seniorHigh_dept.Text = "SeniorHigh Dept."
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.dg_sStudRec)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(370, 70)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(776, 561)
        Me.Panel5.TabIndex = 50
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BunifuFlatButton6)
        Me.Panel6.Controls.Add(Me.RadioButton3)
        Me.Panel6.Controls.Add(Me.RadioButton4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 504)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(776, 57)
        Me.Panel6.TabIndex = 48
        '
        'BunifuFlatButton6
        '
        Me.BunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton6.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuFlatButton6.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton6.BorderRadius = 0
        Me.BunifuFlatButton6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuFlatButton6.ButtonText = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.BunifuFlatButton6.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton6.Iconimage = Nothing
        Me.BunifuFlatButton6.Iconimage_right = Nothing
        Me.BunifuFlatButton6.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton6.Iconimage_Selected = Nothing
        Me.BunifuFlatButton6.IconMarginLeft = 0
        Me.BunifuFlatButton6.IconMarginRight = 0
        Me.BunifuFlatButton6.IconRightVisible = False
        Me.BunifuFlatButton6.IconRightZoom = 0R
        Me.BunifuFlatButton6.IconVisible = False
        Me.BunifuFlatButton6.IconZoom = 90.0R
        Me.BunifuFlatButton6.IsTab = False
        Me.BunifuFlatButton6.Location = New System.Drawing.Point(49, 8)
        Me.BunifuFlatButton6.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BunifuFlatButton6.Name = "BunifuFlatButton6"
        Me.BunifuFlatButton6.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton6.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.BunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton6.selected = False
        Me.BunifuFlatButton6.Size = New System.Drawing.Size(212, 35)
        Me.BunifuFlatButton6.TabIndex = 52
        Me.BunifuFlatButton6.Text = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton6.Textcolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton6.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(341, 18)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(133, 25)
        Me.RadioButton3.TabIndex = 50
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "ACTIVE STUDENTS"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(489, 18)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(146, 25)
        Me.RadioButton4.TabIndex = 1
        Me.RadioButton4.Text = "INACTIVE STUDENTS"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'dg_sStudRec
        '
        Me.dg_sStudRec.AllowUserToAddRows = False
        Me.dg_sStudRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_sStudRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_sStudRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sStudRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_sStudRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_sStudRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_sStudRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_sStudRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sStudRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_sStud_id, Me.col_sStud_fname, Me.col_sStud_lanme, Me.col_sStud_mi, Me.col_sSY, Me.col_sGL})
        Me.dg_sStudRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_sStudRec.DoubleBuffered = True
        Me.dg_sStudRec.EnableHeadersVisualStyles = False
        Me.dg_sStudRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_sStudRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_sStudRec.Location = New System.Drawing.Point(0, 0)
        Me.dg_sStudRec.Name = "dg_sStudRec"
        Me.dg_sStudRec.ReadOnly = True
        Me.dg_sStudRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_sStudRec.RowHeadersVisible = False
        Me.dg_sStudRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_sStudRec.Size = New System.Drawing.Size(776, 561)
        Me.dg_sStudRec.TabIndex = 47
        '
        'col_sStud_id
        '
        Me.col_sStud_id.DataPropertyName = "estud_id"
        Me.col_sStud_id.HeaderText = "Stud. id"
        Me.col_sStud_id.Name = "col_sStud_id"
        Me.col_sStud_id.ReadOnly = True
        '
        'col_sStud_fname
        '
        Me.col_sStud_fname.DataPropertyName = "estud_fname"
        Me.col_sStud_fname.HeaderText = "First Name"
        Me.col_sStud_fname.Name = "col_sStud_fname"
        Me.col_sStud_fname.ReadOnly = True
        '
        'col_sStud_lanme
        '
        Me.col_sStud_lanme.DataPropertyName = "estud_Lname"
        Me.col_sStud_lanme.HeaderText = "Last Name"
        Me.col_sStud_lanme.Name = "col_sStud_lanme"
        Me.col_sStud_lanme.ReadOnly = True
        '
        'col_sStud_mi
        '
        Me.col_sStud_mi.DataPropertyName = "estud_mi"
        Me.col_sStud_mi.HeaderText = "Middle Initial"
        Me.col_sStud_mi.Name = "col_sStud_mi"
        Me.col_sStud_mi.ReadOnly = True
        '
        'col_sSY
        '
        Me.col_sSY.DataPropertyName = "esy_id"
        Me.col_sSY.HeaderText = "S/Y"
        Me.col_sSY.Name = "col_sSY"
        Me.col_sSY.ReadOnly = True
        Me.col_sSY.Visible = False
        '
        'col_sGL
        '
        Me.col_sGL.DataPropertyName = "egl_id"
        Me.col_sGL.HeaderText = "G/L"
        Me.col_sGL.Name = "col_sGL"
        Me.col_sGL.ReadOnly = True
        Me.col_sGL.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.btn_sCancel)
        Me.Panel4.Controls.Add(Me.btn_sViewAccount)
        Me.Panel4.Controls.Add(Me.btn_sSave)
        Me.Panel4.Controls.Add(Me.btn_sUpdateStud)
        Me.Panel4.Controls.Add(Me.btn_sAddStud)
        Me.Panel4.Controls.Add(Me.cbo_sSY)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.cbo_sGL)
        Me.Panel4.Controls.Add(Me.txtb_sFname)
        Me.Panel4.Controls.Add(Me.txtb_smi)
        Me.Panel4.Controls.Add(Me.txtb_sLname)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtb_sStud_id)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.Label25)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(0, 70)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(370, 561)
        Me.Panel4.TabIndex = 49
        '
        'btn_sCancel
        '
        Me.btn_sCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_sCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sCancel.BorderRadius = 0
        Me.btn_sCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sCancel.ButtonText = "CANCEL"
        Me.btn_sCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sCancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sCancel.Enabled = False
        Me.btn_sCancel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sCancel.Iconimage = Nothing
        Me.btn_sCancel.Iconimage_right = Nothing
        Me.btn_sCancel.Iconimage_right_Selected = Nothing
        Me.btn_sCancel.Iconimage_Selected = Nothing
        Me.btn_sCancel.IconMarginLeft = 0
        Me.btn_sCancel.IconMarginRight = 0
        Me.btn_sCancel.IconRightVisible = False
        Me.btn_sCancel.IconRightZoom = 0R
        Me.btn_sCancel.IconVisible = False
        Me.btn_sCancel.IconZoom = 90.0R
        Me.btn_sCancel.IsTab = False
        Me.btn_sCancel.Location = New System.Drawing.Point(43, 457)
        Me.btn_sCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sCancel.Name = "btn_sCancel"
        Me.btn_sCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sCancel.selected = False
        Me.btn_sCancel.Size = New System.Drawing.Size(136, 35)
        Me.btn_sCancel.TabIndex = 54
        Me.btn_sCancel.Text = "CANCEL"
        Me.btn_sCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sViewAccount
        '
        Me.btn_sViewAccount.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sViewAccount.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_sViewAccount.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sViewAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sViewAccount.BorderRadius = 0
        Me.btn_sViewAccount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sViewAccount.ButtonText = "VIEW ACCOUNT"
        Me.btn_sViewAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sViewAccount.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sViewAccount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sViewAccount.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sViewAccount.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sViewAccount.Iconimage = Nothing
        Me.btn_sViewAccount.Iconimage_right = Nothing
        Me.btn_sViewAccount.Iconimage_right_Selected = Nothing
        Me.btn_sViewAccount.Iconimage_Selected = Nothing
        Me.btn_sViewAccount.IconMarginLeft = 0
        Me.btn_sViewAccount.IconMarginRight = 0
        Me.btn_sViewAccount.IconRightVisible = False
        Me.btn_sViewAccount.IconRightZoom = 0R
        Me.btn_sViewAccount.IconVisible = False
        Me.btn_sViewAccount.IconZoom = 90.0R
        Me.btn_sViewAccount.IsTab = False
        Me.btn_sViewAccount.Location = New System.Drawing.Point(43, 350)
        Me.btn_sViewAccount.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sViewAccount.Name = "btn_sViewAccount"
        Me.btn_sViewAccount.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sViewAccount.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sViewAccount.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sViewAccount.selected = False
        Me.btn_sViewAccount.Size = New System.Drawing.Size(283, 35)
        Me.btn_sViewAccount.TabIndex = 53
        Me.btn_sViewAccount.Text = "VIEW ACCOUNT"
        Me.btn_sViewAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sViewAccount.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sViewAccount.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sSave
        '
        Me.btn_sSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_sSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sSave.BorderRadius = 0
        Me.btn_sSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sSave.ButtonText = "SAVE"
        Me.btn_sSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sSave.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sSave.Enabled = False
        Me.btn_sSave.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sSave.Iconimage = Nothing
        Me.btn_sSave.Iconimage_right = Nothing
        Me.btn_sSave.Iconimage_right_Selected = Nothing
        Me.btn_sSave.Iconimage_Selected = Nothing
        Me.btn_sSave.IconMarginLeft = 0
        Me.btn_sSave.IconMarginRight = 0
        Me.btn_sSave.IconRightVisible = False
        Me.btn_sSave.IconRightZoom = 0R
        Me.btn_sSave.IconVisible = False
        Me.btn_sSave.IconZoom = 90.0R
        Me.btn_sSave.IsTab = False
        Me.btn_sSave.Location = New System.Drawing.Point(191, 457)
        Me.btn_sSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sSave.Name = "btn_sSave"
        Me.btn_sSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sSave.selected = False
        Me.btn_sSave.Size = New System.Drawing.Size(136, 35)
        Me.btn_sSave.TabIndex = 52
        Me.btn_sSave.Text = "SAVE"
        Me.btn_sSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sUpdateStud
        '
        Me.btn_sUpdateStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sUpdateStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_sUpdateStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sUpdateStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sUpdateStud.BorderRadius = 0
        Me.btn_sUpdateStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sUpdateStud.ButtonText = "UPDATE STUDENT"
        Me.btn_sUpdateStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sUpdateStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sUpdateStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sUpdateStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sUpdateStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sUpdateStud.Iconimage = Nothing
        Me.btn_sUpdateStud.Iconimage_right = Nothing
        Me.btn_sUpdateStud.Iconimage_right_Selected = Nothing
        Me.btn_sUpdateStud.Iconimage_Selected = Nothing
        Me.btn_sUpdateStud.IconMarginLeft = 0
        Me.btn_sUpdateStud.IconMarginRight = 0
        Me.btn_sUpdateStud.IconRightVisible = False
        Me.btn_sUpdateStud.IconRightZoom = 0R
        Me.btn_sUpdateStud.IconVisible = False
        Me.btn_sUpdateStud.IconZoom = 90.0R
        Me.btn_sUpdateStud.IsTab = False
        Me.btn_sUpdateStud.Location = New System.Drawing.Point(191, 401)
        Me.btn_sUpdateStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sUpdateStud.Name = "btn_sUpdateStud"
        Me.btn_sUpdateStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sUpdateStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sUpdateStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sUpdateStud.selected = False
        Me.btn_sUpdateStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_sUpdateStud.TabIndex = 51
        Me.btn_sUpdateStud.Text = "UPDATE STUDENT"
        Me.btn_sUpdateStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sUpdateStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sUpdateStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sAddStud
        '
        Me.btn_sAddStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sAddStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_sAddStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sAddStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sAddStud.BorderRadius = 0
        Me.btn_sAddStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sAddStud.ButtonText = "ADD NEW STUDENT"
        Me.btn_sAddStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sAddStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sAddStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sAddStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sAddStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sAddStud.Iconimage = Nothing
        Me.btn_sAddStud.Iconimage_right = Nothing
        Me.btn_sAddStud.Iconimage_right_Selected = Nothing
        Me.btn_sAddStud.Iconimage_Selected = Nothing
        Me.btn_sAddStud.IconMarginLeft = 0
        Me.btn_sAddStud.IconMarginRight = 0
        Me.btn_sAddStud.IconRightVisible = False
        Me.btn_sAddStud.IconRightZoom = 0R
        Me.btn_sAddStud.IconVisible = False
        Me.btn_sAddStud.IconZoom = 90.0R
        Me.btn_sAddStud.IsTab = False
        Me.btn_sAddStud.Location = New System.Drawing.Point(44, 401)
        Me.btn_sAddStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sAddStud.Name = "btn_sAddStud"
        Me.btn_sAddStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sAddStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sAddStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sAddStud.selected = False
        Me.btn_sAddStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_sAddStud.TabIndex = 49
        Me.btn_sAddStud.Text = "ADD NEW STUDENT"
        Me.btn_sAddStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sAddStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sAddStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbo_sSY
        '
        Me.cbo_sSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sSY.Enabled = False
        Me.cbo_sSY.FormattingEnabled = True
        Me.cbo_sSY.Location = New System.Drawing.Point(117, 191)
        Me.cbo_sSY.Name = "cbo_sSY"
        Me.cbo_sSY.Size = New System.Drawing.Size(223, 29)
        Me.cbo_sSY.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(22, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 21)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "SCH-YEAR"
        '
        'cbo_sGL
        '
        Me.cbo_sGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sGL.Enabled = False
        Me.cbo_sGL.FormattingEnabled = True
        Me.cbo_sGL.Location = New System.Drawing.Point(116, 236)
        Me.cbo_sGL.Name = "cbo_sGL"
        Me.cbo_sGL.Size = New System.Drawing.Size(223, 29)
        Me.cbo_sGL.TabIndex = 46
        '
        'txtb_sFname
        '
        Me.txtb_sFname.BackColor = System.Drawing.Color.White
        Me.txtb_sFname.Enabled = False
        Me.txtb_sFname.Location = New System.Drawing.Point(117, 65)
        Me.txtb_sFname.Name = "txtb_sFname"
        Me.txtb_sFname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_sFname.TabIndex = 45
        '
        'txtb_smi
        '
        Me.txtb_smi.BackColor = System.Drawing.Color.White
        Me.txtb_smi.Enabled = False
        Me.txtb_smi.Location = New System.Drawing.Point(117, 149)
        Me.txtb_smi.Name = "txtb_smi"
        Me.txtb_smi.Size = New System.Drawing.Size(222, 26)
        Me.txtb_smi.TabIndex = 43
        '
        'txtb_sLname
        '
        Me.txtb_sLname.BackColor = System.Drawing.Color.White
        Me.txtb_sLname.Enabled = False
        Me.txtb_sLname.Location = New System.Drawing.Point(117, 107)
        Me.txtb_sLname.Name = "txtb_sLname"
        Me.txtb_sLname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_sLname.TabIndex = 34
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(20, 153)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 21)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "M.I."
        '
        'txtb_sStud_id
        '
        Me.txtb_sStud_id.BackColor = System.Drawing.Color.White
        Me.txtb_sStud_id.Enabled = False
        Me.txtb_sStud_id.Location = New System.Drawing.Point(117, 23)
        Me.txtb_sStud_id.Name = "txtb_sStud_id"
        Me.txtb_sStud_id.Size = New System.Drawing.Size(222, 26)
        Me.txtb_sStud_id.TabIndex = 28
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label19.Location = New System.Drawing.Point(21, 24)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 21)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "STUDENT ID"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label22.Location = New System.Drawing.Point(21, 239)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(89, 21)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "GRADE LEVEL"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label24.Location = New System.Drawing.Point(20, 110)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 21)
        Me.Label24.TabIndex = 24
        Me.Label24.Text = "LAST NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label25.Location = New System.Drawing.Point(21, 67)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 21)
        Me.Label25.TabIndex = 25
        Me.Label25.Text = "FIRST NAME"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbo_sSearchBy)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtb_sSearch)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1146, 70)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SEARCH FOR STUDENT"
        '
        'cbo_sSearchBy
        '
        Me.cbo_sSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sSearchBy.FormattingEnabled = True
        Me.cbo_sSearchBy.Items.AddRange(New Object() {"ID Number", "Name"})
        Me.cbo_sSearchBy.Location = New System.Drawing.Point(328, 19)
        Me.cbo_sSearchBy.Name = "cbo_sSearchBy"
        Me.cbo_sSearchBy.Size = New System.Drawing.Size(142, 33)
        Me.cbo_sSearchBy.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label15.Location = New System.Drawing.Point(298, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 25)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "BY"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(218, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(74, 25)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "SEARCH"
        '
        'txtb_sSearch
        '
        Me.txtb_sSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtb_sSearch.Location = New System.Drawing.Point(497, 20)
        Me.txtb_sSearch.Name = "txtb_sSearch"
        Me.txtb_sSearch.Size = New System.Drawing.Size(425, 30)
        Me.txtb_sSearch.TabIndex = 13
        '
        'juniorHigh_dept
        '
        Me.juniorHigh_dept.BackColor = System.Drawing.SystemColors.Control
        Me.juniorHigh_dept.Controls.Add(Me.Panel11)
        Me.juniorHigh_dept.Controls.Add(Me.Panel10)
        Me.juniorHigh_dept.Controls.Add(Me.GroupBox4)
        Me.juniorHigh_dept.Location = New System.Drawing.Point(4, 29)
        Me.juniorHigh_dept.Name = "juniorHigh_dept"
        Me.juniorHigh_dept.Size = New System.Drawing.Size(1146, 631)
        Me.juniorHigh_dept.TabIndex = 3
        Me.juniorHigh_dept.Text = "JuniorHigh Dept."
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Panel12)
        Me.Panel11.Controls.Add(Me.dg_jStudRec)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(370, 70)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(3, 3, 10, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(776, 561)
        Me.Panel11.TabIndex = 51
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.BunifuFlatButton13)
        Me.Panel12.Controls.Add(Me.RadioButton7)
        Me.Panel12.Controls.Add(Me.RadioButton8)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel12.Location = New System.Drawing.Point(0, 504)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(776, 57)
        Me.Panel12.TabIndex = 48
        '
        'BunifuFlatButton13
        '
        Me.BunifuFlatButton13.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton13.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BunifuFlatButton13.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton13.BorderRadius = 0
        Me.BunifuFlatButton13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuFlatButton13.ButtonText = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton13.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.BunifuFlatButton13.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton13.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton13.Iconimage = Nothing
        Me.BunifuFlatButton13.Iconimage_right = Nothing
        Me.BunifuFlatButton13.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton13.Iconimage_Selected = Nothing
        Me.BunifuFlatButton13.IconMarginLeft = 0
        Me.BunifuFlatButton13.IconMarginRight = 0
        Me.BunifuFlatButton13.IconRightVisible = False
        Me.BunifuFlatButton13.IconRightZoom = 0R
        Me.BunifuFlatButton13.IconVisible = False
        Me.BunifuFlatButton13.IconZoom = 90.0R
        Me.BunifuFlatButton13.IsTab = False
        Me.BunifuFlatButton13.Location = New System.Drawing.Point(49, 8)
        Me.BunifuFlatButton13.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.BunifuFlatButton13.Name = "BunifuFlatButton13"
        Me.BunifuFlatButton13.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton13.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.BunifuFlatButton13.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton13.selected = False
        Me.BunifuFlatButton13.Size = New System.Drawing.Size(212, 35)
        Me.BunifuFlatButton13.TabIndex = 52
        Me.BunifuFlatButton13.Text = "BACKUP STUDENTS ACCOUNT"
        Me.BunifuFlatButton13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton13.Textcolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton13.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'RadioButton7
        '
        Me.RadioButton7.AutoSize = True
        Me.RadioButton7.Checked = True
        Me.RadioButton7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(341, 18)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.Size = New System.Drawing.Size(133, 25)
        Me.RadioButton7.TabIndex = 50
        Me.RadioButton7.TabStop = True
        Me.RadioButton7.Text = "ACTIVE STUDENTS"
        Me.RadioButton7.UseVisualStyleBackColor = True
        '
        'RadioButton8
        '
        Me.RadioButton8.AutoSize = True
        Me.RadioButton8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton8.Location = New System.Drawing.Point(489, 18)
        Me.RadioButton8.Name = "RadioButton8"
        Me.RadioButton8.Size = New System.Drawing.Size(146, 25)
        Me.RadioButton8.TabIndex = 1
        Me.RadioButton8.Text = "INACTIVE STUDENTS"
        Me.RadioButton8.UseVisualStyleBackColor = True
        '
        'dg_jStudRec
        '
        Me.dg_jStudRec.AllowUserToAddRows = False
        Me.dg_jStudRec.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_jStudRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dg_jStudRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_jStudRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_jStudRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_jStudRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_jStudRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dg_jStudRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jStudRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.dg_jStudRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_jStudRec.DoubleBuffered = True
        Me.dg_jStudRec.EnableHeadersVisualStyles = False
        Me.dg_jStudRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_jStudRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_jStudRec.Location = New System.Drawing.Point(0, 0)
        Me.dg_jStudRec.Name = "dg_jStudRec"
        Me.dg_jStudRec.ReadOnly = True
        Me.dg_jStudRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_jStudRec.RowHeadersVisible = False
        Me.dg_jStudRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_jStudRec.Size = New System.Drawing.Size(776, 561)
        Me.dg_jStudRec.TabIndex = 47
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "estud_id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Stud. id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "estud_fname"
        Me.DataGridViewTextBoxColumn8.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "estud_Lname"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "estud_mi"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Middle Initial"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "esy_id"
        Me.DataGridViewTextBoxColumn17.HeaderText = "S/Y"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "egl_id"
        Me.DataGridViewTextBoxColumn18.HeaderText = "YL"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.btn_jCancel)
        Me.Panel10.Controls.Add(Me.btn_jViewAcct)
        Me.Panel10.Controls.Add(Me.btn_jSave)
        Me.Panel10.Controls.Add(Me.btn_jUpdateStud)
        Me.Panel10.Controls.Add(Me.btn_jAddStud)
        Me.Panel10.Controls.Add(Me.cbo_jSY)
        Me.Panel10.Controls.Add(Me.Label26)
        Me.Panel10.Controls.Add(Me.cbo_jGL)
        Me.Panel10.Controls.Add(Me.txtb_jStudFname)
        Me.Panel10.Controls.Add(Me.txtb_jStudMI)
        Me.Panel10.Controls.Add(Me.txtb_jStudLname)
        Me.Panel10.Controls.Add(Me.Label27)
        Me.Panel10.Controls.Add(Me.txtb_jStud_id)
        Me.Panel10.Controls.Add(Me.Label28)
        Me.Panel10.Controls.Add(Me.Label29)
        Me.Panel10.Controls.Add(Me.Label31)
        Me.Panel10.Controls.Add(Me.Label32)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel10.Location = New System.Drawing.Point(0, 70)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(370, 561)
        Me.Panel10.TabIndex = 49
        '
        'btn_jCancel
        '
        Me.btn_jCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jCancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_jCancel.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jCancel.BorderRadius = 0
        Me.btn_jCancel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jCancel.ButtonText = "CANCEL"
        Me.btn_jCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jCancel.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jCancel.Enabled = False
        Me.btn_jCancel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jCancel.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jCancel.Iconimage = Nothing
        Me.btn_jCancel.Iconimage_right = Nothing
        Me.btn_jCancel.Iconimage_right_Selected = Nothing
        Me.btn_jCancel.Iconimage_Selected = Nothing
        Me.btn_jCancel.IconMarginLeft = 0
        Me.btn_jCancel.IconMarginRight = 0
        Me.btn_jCancel.IconRightVisible = False
        Me.btn_jCancel.IconRightZoom = 0R
        Me.btn_jCancel.IconVisible = False
        Me.btn_jCancel.IconZoom = 90.0R
        Me.btn_jCancel.IsTab = False
        Me.btn_jCancel.Location = New System.Drawing.Point(43, 457)
        Me.btn_jCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jCancel.Name = "btn_jCancel"
        Me.btn_jCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jCancel.selected = False
        Me.btn_jCancel.Size = New System.Drawing.Size(136, 35)
        Me.btn_jCancel.TabIndex = 54
        Me.btn_jCancel.Text = "CANCEL"
        Me.btn_jCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_jViewAcct
        '
        Me.btn_jViewAcct.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jViewAcct.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_jViewAcct.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jViewAcct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jViewAcct.BorderRadius = 0
        Me.btn_jViewAcct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jViewAcct.ButtonText = "VIEW ACCOUNT"
        Me.btn_jViewAcct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jViewAcct.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jViewAcct.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jViewAcct.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jViewAcct.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jViewAcct.Iconimage = Nothing
        Me.btn_jViewAcct.Iconimage_right = Nothing
        Me.btn_jViewAcct.Iconimage_right_Selected = Nothing
        Me.btn_jViewAcct.Iconimage_Selected = Nothing
        Me.btn_jViewAcct.IconMarginLeft = 0
        Me.btn_jViewAcct.IconMarginRight = 0
        Me.btn_jViewAcct.IconRightVisible = False
        Me.btn_jViewAcct.IconRightZoom = 0R
        Me.btn_jViewAcct.IconVisible = False
        Me.btn_jViewAcct.IconZoom = 90.0R
        Me.btn_jViewAcct.IsTab = False
        Me.btn_jViewAcct.Location = New System.Drawing.Point(43, 350)
        Me.btn_jViewAcct.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jViewAcct.Name = "btn_jViewAcct"
        Me.btn_jViewAcct.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jViewAcct.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jViewAcct.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jViewAcct.selected = False
        Me.btn_jViewAcct.Size = New System.Drawing.Size(283, 35)
        Me.btn_jViewAcct.TabIndex = 53
        Me.btn_jViewAcct.Text = "VIEW ACCOUNT"
        Me.btn_jViewAcct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jViewAcct.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jViewAcct.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_jSave
        '
        Me.btn_jSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jSave.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_jSave.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jSave.BorderRadius = 0
        Me.btn_jSave.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jSave.ButtonText = "SAVE"
        Me.btn_jSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jSave.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jSave.Enabled = False
        Me.btn_jSave.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jSave.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jSave.Iconimage = Nothing
        Me.btn_jSave.Iconimage_right = Nothing
        Me.btn_jSave.Iconimage_right_Selected = Nothing
        Me.btn_jSave.Iconimage_Selected = Nothing
        Me.btn_jSave.IconMarginLeft = 0
        Me.btn_jSave.IconMarginRight = 0
        Me.btn_jSave.IconRightVisible = False
        Me.btn_jSave.IconRightZoom = 0R
        Me.btn_jSave.IconVisible = False
        Me.btn_jSave.IconZoom = 90.0R
        Me.btn_jSave.IsTab = False
        Me.btn_jSave.Location = New System.Drawing.Point(191, 457)
        Me.btn_jSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jSave.Name = "btn_jSave"
        Me.btn_jSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jSave.selected = False
        Me.btn_jSave.Size = New System.Drawing.Size(136, 35)
        Me.btn_jSave.TabIndex = 52
        Me.btn_jSave.Text = "SAVE"
        Me.btn_jSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_jUpdateStud
        '
        Me.btn_jUpdateStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jUpdateStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_jUpdateStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jUpdateStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jUpdateStud.BorderRadius = 0
        Me.btn_jUpdateStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jUpdateStud.ButtonText = "UPDATE STUDENT"
        Me.btn_jUpdateStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jUpdateStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jUpdateStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jUpdateStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jUpdateStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jUpdateStud.Iconimage = Nothing
        Me.btn_jUpdateStud.Iconimage_right = Nothing
        Me.btn_jUpdateStud.Iconimage_right_Selected = Nothing
        Me.btn_jUpdateStud.Iconimage_Selected = Nothing
        Me.btn_jUpdateStud.IconMarginLeft = 0
        Me.btn_jUpdateStud.IconMarginRight = 0
        Me.btn_jUpdateStud.IconRightVisible = False
        Me.btn_jUpdateStud.IconRightZoom = 0R
        Me.btn_jUpdateStud.IconVisible = False
        Me.btn_jUpdateStud.IconZoom = 90.0R
        Me.btn_jUpdateStud.IsTab = False
        Me.btn_jUpdateStud.Location = New System.Drawing.Point(191, 401)
        Me.btn_jUpdateStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jUpdateStud.Name = "btn_jUpdateStud"
        Me.btn_jUpdateStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jUpdateStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jUpdateStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jUpdateStud.selected = False
        Me.btn_jUpdateStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_jUpdateStud.TabIndex = 51
        Me.btn_jUpdateStud.Text = "UPDATE STUDENT"
        Me.btn_jUpdateStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jUpdateStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jUpdateStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_jAddStud
        '
        Me.btn_jAddStud.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jAddStud.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_jAddStud.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jAddStud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jAddStud.BorderRadius = 0
        Me.btn_jAddStud.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jAddStud.ButtonText = "ADD NEW STUDENT"
        Me.btn_jAddStud.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jAddStud.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jAddStud.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jAddStud.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jAddStud.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jAddStud.Iconimage = Nothing
        Me.btn_jAddStud.Iconimage_right = Nothing
        Me.btn_jAddStud.Iconimage_right_Selected = Nothing
        Me.btn_jAddStud.Iconimage_Selected = Nothing
        Me.btn_jAddStud.IconMarginLeft = 0
        Me.btn_jAddStud.IconMarginRight = 0
        Me.btn_jAddStud.IconRightVisible = False
        Me.btn_jAddStud.IconRightZoom = 0R
        Me.btn_jAddStud.IconVisible = False
        Me.btn_jAddStud.IconZoom = 90.0R
        Me.btn_jAddStud.IsTab = False
        Me.btn_jAddStud.Location = New System.Drawing.Point(44, 401)
        Me.btn_jAddStud.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jAddStud.Name = "btn_jAddStud"
        Me.btn_jAddStud.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jAddStud.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jAddStud.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jAddStud.selected = False
        Me.btn_jAddStud.Size = New System.Drawing.Size(136, 35)
        Me.btn_jAddStud.TabIndex = 49
        Me.btn_jAddStud.Text = "ADD NEW STUDENT"
        Me.btn_jAddStud.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jAddStud.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jAddStud.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbo_jSY
        '
        Me.cbo_jSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jSY.Enabled = False
        Me.cbo_jSY.FormattingEnabled = True
        Me.cbo_jSY.Location = New System.Drawing.Point(117, 191)
        Me.cbo_jSY.Name = "cbo_jSY"
        Me.cbo_jSY.Size = New System.Drawing.Size(223, 29)
        Me.cbo_jSY.TabIndex = 50
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label26.Location = New System.Drawing.Point(22, 196)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(70, 21)
        Me.Label26.TabIndex = 49
        Me.Label26.Text = "SCH-YEAR"
        '
        'cbo_jGL
        '
        Me.cbo_jGL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jGL.Enabled = False
        Me.cbo_jGL.FormattingEnabled = True
        Me.cbo_jGL.Location = New System.Drawing.Point(116, 236)
        Me.cbo_jGL.Name = "cbo_jGL"
        Me.cbo_jGL.Size = New System.Drawing.Size(223, 29)
        Me.cbo_jGL.TabIndex = 46
        '
        'txtb_jStudFname
        '
        Me.txtb_jStudFname.BackColor = System.Drawing.Color.White
        Me.txtb_jStudFname.Enabled = False
        Me.txtb_jStudFname.Location = New System.Drawing.Point(117, 65)
        Me.txtb_jStudFname.Name = "txtb_jStudFname"
        Me.txtb_jStudFname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_jStudFname.TabIndex = 45
        '
        'txtb_jStudMI
        '
        Me.txtb_jStudMI.BackColor = System.Drawing.Color.White
        Me.txtb_jStudMI.Enabled = False
        Me.txtb_jStudMI.Location = New System.Drawing.Point(117, 149)
        Me.txtb_jStudMI.Name = "txtb_jStudMI"
        Me.txtb_jStudMI.Size = New System.Drawing.Size(222, 26)
        Me.txtb_jStudMI.TabIndex = 43
        '
        'txtb_jStudLname
        '
        Me.txtb_jStudLname.BackColor = System.Drawing.Color.White
        Me.txtb_jStudLname.Enabled = False
        Me.txtb_jStudLname.Location = New System.Drawing.Point(117, 107)
        Me.txtb_jStudLname.Name = "txtb_jStudLname"
        Me.txtb_jStudLname.Size = New System.Drawing.Size(222, 26)
        Me.txtb_jStudLname.TabIndex = 34
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label27.Location = New System.Drawing.Point(20, 153)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(33, 21)
        Me.Label27.TabIndex = 39
        Me.Label27.Text = "M.I."
        '
        'txtb_jStud_id
        '
        Me.txtb_jStud_id.BackColor = System.Drawing.Color.White
        Me.txtb_jStud_id.Enabled = False
        Me.txtb_jStud_id.Location = New System.Drawing.Point(117, 23)
        Me.txtb_jStud_id.Name = "txtb_jStud_id"
        Me.txtb_jStud_id.Size = New System.Drawing.Size(222, 26)
        Me.txtb_jStud_id.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label28.Location = New System.Drawing.Point(21, 24)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 21)
        Me.Label28.TabIndex = 27
        Me.Label28.Text = "STUDENT ID"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(21, 239)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(89, 21)
        Me.Label29.TabIndex = 26
        Me.Label29.Text = "GRADE LEVEL"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label31.Location = New System.Drawing.Point(20, 110)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 21)
        Me.Label31.TabIndex = 24
        Me.Label31.Text = "LAST NAME"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label32.Location = New System.Drawing.Point(21, 67)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(81, 21)
        Me.Label32.TabIndex = 25
        Me.Label32.Text = "FIRST NAME"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbo_jSearchBy)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.txtb_jSearch)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1146, 70)
        Me.GroupBox4.TabIndex = 39
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SEARCH FOR STUDENT"
        '
        'cbo_jSearchBy
        '
        Me.cbo_jSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jSearchBy.FormattingEnabled = True
        Me.cbo_jSearchBy.Items.AddRange(New Object() {"ID Number", "Name"})
        Me.cbo_jSearchBy.Location = New System.Drawing.Point(328, 19)
        Me.cbo_jSearchBy.Name = "cbo_jSearchBy"
        Me.cbo_jSearchBy.Size = New System.Drawing.Size(142, 33)
        Me.cbo_jSearchBy.TabIndex = 15
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label17.Location = New System.Drawing.Point(298, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 25)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "BY"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label18.Location = New System.Drawing.Point(218, 23)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 25)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "SEARCH"
        '
        'txtb_jSearch
        '
        Me.txtb_jSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtb_jSearch.Location = New System.Drawing.Point(497, 20)
        Me.txtb_jSearch.Name = "txtb_jSearch"
        Me.txtb_jSearch.Size = New System.Drawing.Size(425, 30)
        Me.txtb_jSearch.TabIndex = 13
        '
        'frm_slists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_slists"
        Me.Size = New System.Drawing.Size(1154, 664)
        Me.TabControl1.ResumeLayout(False)
        Me.college_dept.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dg_studR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.elem_dept.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.dg_eStudRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.seniorHigh_dept.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.dg_sStudRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.juniorHigh_dept.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.dg_jStudRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents college_dept As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_gotoAcct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_updtStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_addNstud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_schyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbo_yearlevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_studFname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_studMI As System.Windows.Forms.TextBox
    Friend WithEvents txtb_noUnits As System.Windows.Forms.TextBox
    Friend WithEvents txtb_studLname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_RpU As System.Windows.Forms.TextBox
    Friend WithEvents cbo_course As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_sem As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_studId As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_backStudAcct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents dg_studR As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents cbo_SearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtb_Search As System.Windows.Forms.TextBox
    Friend WithEvents seniorHigh_dept As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_sSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtb_sSearch As System.Windows.Forms.TextBox
    Friend WithEvents juniorHigh_dept As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_jSearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtb_jSearch As System.Windows.Forms.TextBox
    Friend WithEvents elem_dept As System.Windows.Forms.TabPage
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton11 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents dg_eStudRecords As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btn_eCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_eViewAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_eSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_eUpdateNewStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_eAddNewStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_eSYName As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbo_eGradeLevel As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_eStudFname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_estudMI As System.Windows.Forms.TextBox
    Friend WithEvents txtb_estudLname As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtb_eStudID As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_eSearchBY As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtb_eSearch As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btn_sCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_sViewAccount As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_sSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_sUpdateStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_sAddStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_sSY As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbo_sGL As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_sFname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_smi As System.Windows.Forms.TextBox
    Friend WithEvents txtb_sLname As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtb_sStud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton6 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents dg_sStudRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton13 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton8 As System.Windows.Forms.RadioButton
    Friend WithEvents dg_jStudRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents btn_jCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_jViewAcct As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_jSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_jUpdateStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_jAddStud As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_jSY As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents cbo_jGL As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_jStudFname As System.Windows.Forms.TextBox
    Friend WithEvents txtb_jStudMI As System.Windows.Forms.TextBox
    Friend WithEvents txtb_jStudLname As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtb_jStud_id As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents s_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s_fName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s_lName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents s_Midi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sy_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sem_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yl_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents crs_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_estud_id As DataGridViewTextBoxColumn
    Friend WithEvents col_estud_fname As DataGridViewTextBoxColumn
    Friend WithEvents col_estud_lname As DataGridViewTextBoxColumn
    Friend WithEvents col_estud_mi As DataGridViewTextBoxColumn
    Friend WithEvents col_esy_id As DataGridViewTextBoxColumn
    Friend WithEvents col_egl_id As DataGridViewTextBoxColumn
    Friend WithEvents col_sStud_id As DataGridViewTextBoxColumn
    Friend WithEvents col_sStud_fname As DataGridViewTextBoxColumn
    Friend WithEvents col_sStud_lanme As DataGridViewTextBoxColumn
    Friend WithEvents col_sStud_mi As DataGridViewTextBoxColumn
    Friend WithEvents col_sSY As DataGridViewTextBoxColumn
    Friend WithEvents col_sGL As DataGridViewTextBoxColumn
End Class
