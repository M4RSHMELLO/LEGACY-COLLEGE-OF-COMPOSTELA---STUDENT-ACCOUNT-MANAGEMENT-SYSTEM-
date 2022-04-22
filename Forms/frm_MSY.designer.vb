<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_MSY
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.college_dept = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_ylUpate = New System.Windows.Forms.Button()
        Me.lbo_yearL = New System.Windows.Forms.ListBox()
        Me.btn_nYearlevel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Ucourse = New System.Windows.Forms.Button()
        Me.lbo_courses = New System.Windows.Forms.ListBox()
        Me.btn_nCourse = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dp_End = New System.Windows.Forms.DateTimePicker()
        Me.txtb_syS = New System.Windows.Forms.TextBox()
        Me.dp_Start = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbo_semester = New System.Windows.Forms.ComboBox()
        Me.txtb_syE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_updateSchY = New System.Windows.Forms.Button()
        Me.dg_syR = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.elem_dep = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_egl_update = New System.Windows.Forms.Button()
        Me.lbo_eglRec = New System.Windows.Forms.ListBox()
        Me.btn_egl_new = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dp_esy_endDate = New System.Windows.Forms.DateTimePicker()
        Me.txtb_esy_start = New System.Windows.Forms.TextBox()
        Me.dp_esy_startDate = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtb_esy_end = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_esy_New = New System.Windows.Forms.Button()
        Me.btn_esy_save = New System.Windows.Forms.Button()
        Me.btn_esy_update = New System.Windows.Forms.Button()
        Me.dg_esyRec = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sh_dept = New System.Windows.Forms.TabPage()
        Me.jh_dept = New System.Windows.Forms.TabPage()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.TabControl1.SuspendLayout()
        Me.college_dept.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_syR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.elem_dep.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dg_esyRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.college_dept)
        Me.TabControl1.Controls.Add(Me.elem_dep)
        Me.TabControl1.Controls.Add(Me.sh_dept)
        Me.TabControl1.Controls.Add(Me.jh_dept)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(924, 571)
        Me.TabControl1.TabIndex = 0
        '
        'college_dept
        '
        Me.college_dept.BackColor = System.Drawing.SystemColors.Control
        Me.college_dept.Controls.Add(Me.Panel1)
        Me.college_dept.Location = New System.Drawing.Point(4, 30)
        Me.college_dept.Name = "college_dept"
        Me.college_dept.Padding = New System.Windows.Forms.Padding(3)
        Me.college_dept.Size = New System.Drawing.Size(916, 537)
        Me.college_dept.TabIndex = 0
        Me.college_dept.Text = "COLLEGE Dept"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-1, -13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(918, 570)
        Me.Panel1.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_ylUpate)
        Me.GroupBox2.Controls.Add(Me.lbo_yearL)
        Me.GroupBox2.Controls.Add(Me.btn_nYearlevel)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(585, 293)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(301, 246)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Year Level"
        '
        'btn_ylUpate
        '
        Me.btn_ylUpate.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_ylUpate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ylUpate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ylUpate.Location = New System.Drawing.Point(80, 189)
        Me.btn_ylUpate.Name = "btn_ylUpate"
        Me.btn_ylUpate.Size = New System.Drawing.Size(68, 33)
        Me.btn_ylUpate.TabIndex = 21
        Me.btn_ylUpate.Text = "UPDATE"
        Me.btn_ylUpate.UseVisualStyleBackColor = False
        '
        'lbo_yearL
        '
        Me.lbo_yearL.FormattingEnabled = True
        Me.lbo_yearL.ItemHeight = 25
        Me.lbo_yearL.Location = New System.Drawing.Point(6, 29)
        Me.lbo_yearL.Name = "lbo_yearL"
        Me.lbo_yearL.Size = New System.Drawing.Size(289, 154)
        Me.lbo_yearL.TabIndex = 23
        '
        'btn_nYearlevel
        '
        Me.btn_nYearlevel.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nYearlevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nYearlevel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nYearlevel.Location = New System.Drawing.Point(6, 189)
        Me.btn_nYearlevel.Name = "btn_nYearlevel"
        Me.btn_nYearlevel.Size = New System.Drawing.Size(68, 33)
        Me.btn_nYearlevel.TabIndex = 20
        Me.btn_nYearlevel.Text = "NEW"
        Me.btn_nYearlevel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Ucourse)
        Me.GroupBox1.Controls.Add(Me.lbo_courses)
        Me.GroupBox1.Controls.Add(Me.btn_nCourse)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(585, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 246)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Courses"
        '
        'btn_Ucourse
        '
        Me.btn_Ucourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_Ucourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Ucourse.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ucourse.Location = New System.Drawing.Point(80, 189)
        Me.btn_Ucourse.Name = "btn_Ucourse"
        Me.btn_Ucourse.Size = New System.Drawing.Size(68, 33)
        Me.btn_Ucourse.TabIndex = 21
        Me.btn_Ucourse.Text = "UPDATE"
        Me.btn_Ucourse.UseVisualStyleBackColor = False
        '
        'lbo_courses
        '
        Me.lbo_courses.FormattingEnabled = True
        Me.lbo_courses.ItemHeight = 25
        Me.lbo_courses.Location = New System.Drawing.Point(6, 29)
        Me.lbo_courses.Name = "lbo_courses"
        Me.lbo_courses.Size = New System.Drawing.Size(289, 154)
        Me.lbo_courses.TabIndex = 23
        '
        'btn_nCourse
        '
        Me.btn_nCourse.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_nCourse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nCourse.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nCourse.Location = New System.Drawing.Point(6, 189)
        Me.btn_nCourse.Name = "btn_nCourse"
        Me.btn_nCourse.Size = New System.Drawing.Size(68, 33)
        Me.btn_nCourse.TabIndex = 20
        Me.btn_nCourse.Text = "NEW"
        Me.btn_nCourse.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.btn_new)
        Me.Panel3.Controls.Add(Me.btn_save)
        Me.Panel3.Controls.Add(Me.btn_updateSchY)
        Me.Panel3.Controls.Add(Me.dg_syR)
        Me.Panel3.Location = New System.Drawing.Point(3, 34)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(576, 505)
        Me.Panel3.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.dp_End)
        Me.Panel2.Controls.Add(Me.txtb_syS)
        Me.Panel2.Controls.Add(Me.dp_Start)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbo_semester)
        Me.Panel2.Controls.Add(Me.txtb_syE)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(24, 27)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 148)
        Me.Panel2.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(25, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "TO"
        '
        'dp_End
        '
        Me.dp_End.CustomFormat = "yyyy-MM-dd"
        Me.dp_End.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_End.Location = New System.Drawing.Point(294, 94)
        Me.dp_End.Name = "dp_End"
        Me.dp_End.Size = New System.Drawing.Size(108, 26)
        Me.dp_End.TabIndex = 19
        Me.dp_End.Value = New Date(2022, 4, 30, 0, 0, 0, 0)
        '
        'txtb_syS
        '
        Me.txtb_syS.Enabled = False
        Me.txtb_syS.Location = New System.Drawing.Point(149, 19)
        Me.txtb_syS.Multiline = True
        Me.txtb_syS.Name = "txtb_syS"
        Me.txtb_syS.Size = New System.Drawing.Size(108, 24)
        Me.txtb_syS.TabIndex = 3
        '
        'dp_Start
        '
        Me.dp_Start.CustomFormat = "yyyy-MM-dd"
        Me.dp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_Start.Location = New System.Drawing.Point(149, 94)
        Me.dp_Start.Name = "dp_Start"
        Me.dp_Start.Size = New System.Drawing.Size(108, 26)
        Me.dp_Start.TabIndex = 18
        Me.dp_Start.Value = New Date(2022, 2, 24, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(25, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 21)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "DATE"
        '
        'cbo_semester
        '
        Me.cbo_semester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_semester.FormattingEnabled = True
        Me.cbo_semester.Location = New System.Drawing.Point(149, 57)
        Me.cbo_semester.Name = "cbo_semester"
        Me.cbo_semester.Size = New System.Drawing.Size(253, 29)
        Me.cbo_semester.TabIndex = 5
        '
        'txtb_syE
        '
        Me.txtb_syE.Enabled = False
        Me.txtb_syE.Location = New System.Drawing.Point(294, 19)
        Me.txtb_syE.Multiline = True
        Me.txtb_syE.Name = "txtb_syE"
        Me.txtb_syE.Size = New System.Drawing.Size(108, 24)
        Me.txtb_syE.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SELECT SEMESTER"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SCH YEAR FROM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(263, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "TO"
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_new.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(25, 454)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(68, 33)
        Me.btn_new.TabIndex = 8
        Me.btn_new.Text = "NEW"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_save.Enabled = False
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(173, 454)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(68, 33)
        Me.btn_save.TabIndex = 9
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_updateSchY
        '
        Me.btn_updateSchY.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_updateSchY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_updateSchY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateSchY.Location = New System.Drawing.Point(99, 454)
        Me.btn_updateSchY.Name = "btn_updateSchY"
        Me.btn_updateSchY.Size = New System.Drawing.Size(68, 33)
        Me.btn_updateSchY.TabIndex = 10
        Me.btn_updateSchY.Text = "UPDATE"
        Me.btn_updateSchY.UseVisualStyleBackColor = False
        '
        'dg_syR
        '
        Me.dg_syR.AllowUserToAddRows = False
        Me.dg_syR.AllowUserToDeleteRows = False
        Me.dg_syR.AllowUserToOrderColumns = True
        Me.dg_syR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_syR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_syR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_syR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dg_syR.Location = New System.Drawing.Point(24, 187)
        Me.dg_syR.Name = "dg_syR"
        Me.dg_syR.ReadOnly = True
        Me.dg_syR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_syR.Size = New System.Drawing.Size(525, 261)
        Me.dg_syR.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "sy_name"
        Me.Column1.HeaderText = "SCH YEAR"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "sem_name"
        Me.Column2.HeaderText = "SEMESTER"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ssy_sDate"
        Me.Column3.HeaderText = "START DATE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "sy_eDate"
        Me.Column4.HeaderText = "END DATE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'elem_dep
        '
        Me.elem_dep.BackColor = System.Drawing.SystemColors.Control
        Me.elem_dep.Controls.Add(Me.GroupBox3)
        Me.elem_dep.Controls.Add(Me.Panel4)
        Me.elem_dep.Location = New System.Drawing.Point(4, 30)
        Me.elem_dep.Name = "elem_dep"
        Me.elem_dep.Padding = New System.Windows.Forms.Padding(3)
        Me.elem_dep.Size = New System.Drawing.Size(916, 537)
        Me.elem_dep.TabIndex = 1
        Me.elem_dep.Text = "ELEMENTARY Dept"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_egl_update)
        Me.GroupBox3.Controls.Add(Me.lbo_eglRec)
        Me.GroupBox3.Controls.Add(Me.btn_egl_new)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(596, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 253)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Grade Level"
        '
        'btn_egl_update
        '
        Me.btn_egl_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_egl_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_egl_update.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_egl_update.Location = New System.Drawing.Point(80, 189)
        Me.btn_egl_update.Name = "btn_egl_update"
        Me.btn_egl_update.Size = New System.Drawing.Size(68, 33)
        Me.btn_egl_update.TabIndex = 21
        Me.btn_egl_update.Text = "UPDATE"
        Me.btn_egl_update.UseVisualStyleBackColor = False
        '
        'lbo_eglRec
        '
        Me.lbo_eglRec.FormattingEnabled = True
        Me.lbo_eglRec.ItemHeight = 25
        Me.lbo_eglRec.Location = New System.Drawing.Point(6, 29)
        Me.lbo_eglRec.Name = "lbo_eglRec"
        Me.lbo_eglRec.Size = New System.Drawing.Size(289, 154)
        Me.lbo_eglRec.TabIndex = 23
        '
        'btn_egl_new
        '
        Me.btn_egl_new.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_egl_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_egl_new.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_egl_new.Location = New System.Drawing.Point(6, 189)
        Me.btn_egl_new.Name = "btn_egl_new"
        Me.btn_egl_new.Size = New System.Drawing.Size(68, 33)
        Me.btn_egl_new.TabIndex = 20
        Me.btn_egl_new.Text = "NEW"
        Me.btn_egl_new.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.btn_esy_New)
        Me.Panel4.Controls.Add(Me.btn_esy_save)
        Me.Panel4.Controls.Add(Me.btn_esy_update)
        Me.Panel4.Controls.Add(Me.dg_esyRec)
        Me.Panel4.Location = New System.Drawing.Point(3, 6)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(576, 505)
        Me.Panel4.TabIndex = 22
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.dp_esy_endDate)
        Me.Panel5.Controls.Add(Me.txtb_esy_start)
        Me.Panel5.Controls.Add(Me.dp_esy_startDate)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.txtb_esy_end)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Location = New System.Drawing.Point(24, 27)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(525, 116)
        Me.Panel5.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(263, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 21)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "TO"
        '
        'dp_esy_endDate
        '
        Me.dp_esy_endDate.CustomFormat = "yyyy-MM-dd"
        Me.dp_esy_endDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_esy_endDate.Location = New System.Drawing.Point(294, 67)
        Me.dp_esy_endDate.Name = "dp_esy_endDate"
        Me.dp_esy_endDate.Size = New System.Drawing.Size(108, 26)
        Me.dp_esy_endDate.TabIndex = 19
        Me.dp_esy_endDate.Value = New Date(2022, 4, 30, 0, 0, 0, 0)
        '
        'txtb_esy_start
        '
        Me.txtb_esy_start.Enabled = False
        Me.txtb_esy_start.Location = New System.Drawing.Point(149, 19)
        Me.txtb_esy_start.Multiline = True
        Me.txtb_esy_start.Name = "txtb_esy_start"
        Me.txtb_esy_start.Size = New System.Drawing.Size(108, 24)
        Me.txtb_esy_start.TabIndex = 3
        '
        'dp_esy_startDate
        '
        Me.dp_esy_startDate.CustomFormat = "yyyy-MM-dd"
        Me.dp_esy_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dp_esy_startDate.Location = New System.Drawing.Point(149, 67)
        Me.dp_esy_startDate.Name = "dp_esy_startDate"
        Me.dp_esy_startDate.Size = New System.Drawing.Size(108, 26)
        Me.dp_esy_startDate.TabIndex = 18
        Me.dp_esy_startDate.Value = New Date(2022, 2, 24, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(25, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "DATE"
        '
        'txtb_esy_end
        '
        Me.txtb_esy_end.Enabled = False
        Me.txtb_esy_end.Location = New System.Drawing.Point(294, 19)
        Me.txtb_esy_end.Multiline = True
        Me.txtb_esy_end.Name = "txtb_esy_end"
        Me.txtb_esy_end.Size = New System.Drawing.Size(108, 24)
        Me.txtb_esy_end.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "SCH YEAR FROM"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(263, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 21)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "TO"
        '
        'btn_esy_New
        '
        Me.btn_esy_New.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_esy_New.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esy_New.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esy_New.Location = New System.Drawing.Point(25, 454)
        Me.btn_esy_New.Name = "btn_esy_New"
        Me.btn_esy_New.Size = New System.Drawing.Size(68, 33)
        Me.btn_esy_New.TabIndex = 8
        Me.btn_esy_New.Text = "NEW"
        Me.btn_esy_New.UseVisualStyleBackColor = False
        '
        'btn_esy_save
        '
        Me.btn_esy_save.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_esy_save.Enabled = False
        Me.btn_esy_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esy_save.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esy_save.Location = New System.Drawing.Point(173, 454)
        Me.btn_esy_save.Name = "btn_esy_save"
        Me.btn_esy_save.Size = New System.Drawing.Size(68, 33)
        Me.btn_esy_save.TabIndex = 9
        Me.btn_esy_save.Text = "SAVE"
        Me.btn_esy_save.UseVisualStyleBackColor = False
        '
        'btn_esy_update
        '
        Me.btn_esy_update.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.btn_esy_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_esy_update.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_esy_update.Location = New System.Drawing.Point(99, 454)
        Me.btn_esy_update.Name = "btn_esy_update"
        Me.btn_esy_update.Size = New System.Drawing.Size(68, 33)
        Me.btn_esy_update.TabIndex = 10
        Me.btn_esy_update.Text = "UPDATE"
        Me.btn_esy_update.UseVisualStyleBackColor = False
        '
        'dg_esyRec
        '
        Me.dg_esyRec.AllowUserToAddRows = False
        Me.dg_esyRec.AllowUserToDeleteRows = False
        Me.dg_esyRec.AllowUserToOrderColumns = True
        Me.dg_esyRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_esyRec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_esyRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_esyRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.dg_esyRec.Location = New System.Drawing.Point(24, 187)
        Me.dg_esyRec.Name = "dg_esyRec"
        Me.dg_esyRec.ReadOnly = True
        Me.dg_esyRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_esyRec.Size = New System.Drawing.Size(525, 261)
        Me.dg_esyRec.TabIndex = 13
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "sy_name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "SCH YEAR"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ssy_sDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "START DATE"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "sy_eDate"
        Me.DataGridViewTextBoxColumn4.HeaderText = "END DATE"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'sh_dept
        '
        Me.sh_dept.Location = New System.Drawing.Point(4, 30)
        Me.sh_dept.Name = "sh_dept"
        Me.sh_dept.Size = New System.Drawing.Size(916, 537)
        Me.sh_dept.TabIndex = 2
        Me.sh_dept.Text = "Senior-High Dept"
        Me.sh_dept.UseVisualStyleBackColor = True
        '
        'jh_dept
        '
        Me.jh_dept.Location = New System.Drawing.Point(4, 30)
        Me.jh_dept.Name = "jh_dept"
        Me.jh_dept.Size = New System.Drawing.Size(916, 537)
        Me.jh_dept.TabIndex = 3
        Me.jh_dept.Text = "Junior-High Dept"
        Me.jh_dept.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frm_MSY
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_MSY"
        Me.Size = New System.Drawing.Size(924, 571)
        Me.TabControl1.ResumeLayout(False)
        Me.college_dept.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dg_syR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.elem_dep.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.dg_esyRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents college_dept As System.Windows.Forms.TabPage
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ylUpate As System.Windows.Forms.Button
    Friend WithEvents lbo_yearL As System.Windows.Forms.ListBox
    Friend WithEvents btn_nYearlevel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Ucourse As System.Windows.Forms.Button
    Friend WithEvents lbo_courses As System.Windows.Forms.ListBox
    Friend WithEvents btn_nCourse As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dp_End As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtb_syS As System.Windows.Forms.TextBox
    Friend WithEvents dp_Start As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_semester As System.Windows.Forms.ComboBox
    Friend WithEvents txtb_syE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_updateSchY As System.Windows.Forms.Button
    Friend WithEvents dg_syR As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents elem_dep As System.Windows.Forms.TabPage
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dp_esy_endDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtb_esy_start As System.Windows.Forms.TextBox
    Friend WithEvents dp_esy_startDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtb_esy_end As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_esy_New As System.Windows.Forms.Button
    Friend WithEvents btn_esy_save As System.Windows.Forms.Button
    Friend WithEvents btn_esy_update As System.Windows.Forms.Button
    Friend WithEvents dg_esyRec As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_egl_update As System.Windows.Forms.Button
    Friend WithEvents lbo_eglRec As System.Windows.Forms.ListBox
    Friend WithEvents btn_egl_new As System.Windows.Forms.Button
    Friend WithEvents sh_dept As System.Windows.Forms.TabPage
    Friend WithEvents jh_dept As System.Windows.Forms.TabPage

End Class
