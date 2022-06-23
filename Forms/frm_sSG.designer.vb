<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sSG
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_SearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_Search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_sem = New System.Windows.Forms.Label()
        Me.txtb_studid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtb_studMI = New System.Windows.Forms.TextBox()
        Me.lbl_course = New System.Windows.Forms.Label()
        Me.lbl_level = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtb_studLname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtb_studSem = New System.Windows.Forms.TextBox()
        Me.txtb_studCourse = New System.Windows.Forms.TextBox()
        Me.txtb_SY = New System.Windows.Forms.TextBox()
        Me.txtb_studLevel = New System.Windows.Forms.TextBox()
        Me.txtb_studFname = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb_refNo = New System.Windows.Forms.TextBox()
        Me.cbo_scholarType = New System.Windows.Forms.ComboBox()
        Me.rb_inactive = New System.Windows.Forms.RadioButton()
        Me.rb_active = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtb_ScholarAmnt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_add = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_update = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_manageScholar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dg_StudScholarRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.StudidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudFnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudLnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudmidIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sy = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.level = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbo_SelectDept = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_StudScholarRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_SearchBy)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtb_Search)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 70)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SEARCH FOR STUDENT"
        '
        'cbo_SearchBy
        '
        Me.cbo_SearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SearchBy.FormattingEnabled = True
        Me.cbo_SearchBy.Items.AddRange(New Object() {"Id Number", "Name"})
        Me.cbo_SearchBy.Location = New System.Drawing.Point(122, 25)
        Me.cbo_SearchBy.Name = "cbo_SearchBy"
        Me.cbo_SearchBy.Size = New System.Drawing.Size(134, 33)
        Me.cbo_SearchBy.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(85, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "BY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(17, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "SEARCH"
        '
        'txtb_Search
        '
        Me.txtb_Search.AutoCompleteCustomSource.AddRange(New String() {"Niño Agsoy", "Tajmahal Amarila", "Joshua Avila", "Harvey Baloria", "Faith Claire Bawan", "Mark Bello", "Charmel Camposo", "Kristel Ann Corpuz", "Princess Anne Dadul", "Vj Debuque", "Juvy Dela Cruz", "Laica Joy Delostrico", "Charles Deragosa", "Chris Lyn Joyce Diaz", "Amado Doverte", "John Mark Dulce", "James Bryan N. Dumail", "Junelyn Gumia", "Jessa Langwas", "Annalyn Larita", "Rhea Lynn Legaspi", "Mayter Lumiguid", "Charlene Manabat", "John Vincent A. Medillo", "Jericho Montealto", "Wendel Odilao", "Kurt Randall Oviedo", "Elson Patac", "Kate Pendon", "Carren Polinio", "Jhon Philip Pondar", "Arnic Reponte", "Quirjhon Dave Rivera", "Hanna Gladys Sala", "ARIEL SAOCEJO", "Rea Siarot", "Robel Sta Teresa", "Venus Torrevillas", "Tyrone Vibas", "Jerald Jose"})
        Me.txtb_Search.Location = New System.Drawing.Point(264, 25)
        Me.txtb_Search.Name = "txtb_Search"
        Me.txtb_Search.Size = New System.Drawing.Size(264, 30)
        Me.txtb_Search.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lbl_sem)
        Me.GroupBox2.Controls.Add(Me.txtb_studid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtb_studMI)
        Me.GroupBox2.Controls.Add(Me.lbl_course)
        Me.GroupBox2.Controls.Add(Me.lbl_level)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtb_studLname)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtb_studSem)
        Me.GroupBox2.Controls.Add(Me.txtb_studCourse)
        Me.GroupBox2.Controls.Add(Me.txtb_SY)
        Me.GroupBox2.Controls.Add(Me.txtb_studLevel)
        Me.GroupBox2.Controls.Add(Me.txtb_studFname)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(441, 201)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "STUDENT INFORMATION"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label10.Location = New System.Drawing.Point(6, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 21)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "SCH-YEAR"
        '
        'lbl_sem
        '
        Me.lbl_sem.AutoSize = True
        Me.lbl_sem.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_sem.Location = New System.Drawing.Point(6, 169)
        Me.lbl_sem.Name = "lbl_sem"
        Me.lbl_sem.Size = New System.Drawing.Size(72, 21)
        Me.lbl_sem.TabIndex = 19
        Me.lbl_sem.Text = "SEMESTER"
        '
        'txtb_studid
        '
        Me.txtb_studid.BackColor = System.Drawing.Color.White
        Me.txtb_studid.Enabled = False
        Me.txtb_studid.Location = New System.Drawing.Point(88, 23)
        Me.txtb_studid.Name = "txtb_studid"
        Me.txtb_studid.Size = New System.Drawing.Size(344, 26)
        Me.txtb_studid.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(6, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 21)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "STUDENT ID"
        '
        'txtb_studMI
        '
        Me.txtb_studMI.BackColor = System.Drawing.Color.White
        Me.txtb_studMI.Enabled = False
        Me.txtb_studMI.Location = New System.Drawing.Point(402, 60)
        Me.txtb_studMI.Name = "txtb_studMI"
        Me.txtb_studMI.Size = New System.Drawing.Size(30, 26)
        Me.txtb_studMI.TabIndex = 14
        '
        'lbl_course
        '
        Me.lbl_course.AutoSize = True
        Me.lbl_course.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_course.Location = New System.Drawing.Point(6, 135)
        Me.lbl_course.Name = "lbl_course"
        Me.lbl_course.Size = New System.Drawing.Size(59, 21)
        Me.lbl_course.TabIndex = 11
        Me.lbl_course.Text = "COURSE"
        '
        'lbl_level
        '
        Me.lbl_level.AutoSize = True
        Me.lbl_level.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lbl_level.Location = New System.Drawing.Point(188, 102)
        Me.lbl_level.Name = "lbl_level"
        Me.lbl_level.Size = New System.Drawing.Size(78, 21)
        Me.lbl_level.TabIndex = 9
        Me.lbl_level.Text = "YEAR LEVEL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(369, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "M.I"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(188, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 21)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "LAST NAME"
        '
        'txtb_studLname
        '
        Me.txtb_studLname.BackColor = System.Drawing.Color.White
        Me.txtb_studLname.Enabled = False
        Me.txtb_studLname.Location = New System.Drawing.Point(265, 60)
        Me.txtb_studLname.Name = "txtb_studLname"
        Me.txtb_studLname.Size = New System.Drawing.Size(105, 26)
        Me.txtb_studLname.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(6, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "FIRST NAME"
        '
        'txtb_studSem
        '
        Me.txtb_studSem.BackColor = System.Drawing.Color.White
        Me.txtb_studSem.Enabled = False
        Me.txtb_studSem.Location = New System.Drawing.Point(88, 165)
        Me.txtb_studSem.Name = "txtb_studSem"
        Me.txtb_studSem.Size = New System.Drawing.Size(344, 26)
        Me.txtb_studSem.TabIndex = 6
        '
        'txtb_studCourse
        '
        Me.txtb_studCourse.BackColor = System.Drawing.Color.White
        Me.txtb_studCourse.Enabled = False
        Me.txtb_studCourse.Location = New System.Drawing.Point(90, 132)
        Me.txtb_studCourse.Name = "txtb_studCourse"
        Me.txtb_studCourse.Size = New System.Drawing.Size(342, 26)
        Me.txtb_studCourse.TabIndex = 6
        '
        'txtb_SY
        '
        Me.txtb_SY.BackColor = System.Drawing.Color.White
        Me.txtb_SY.Enabled = False
        Me.txtb_SY.Location = New System.Drawing.Point(90, 97)
        Me.txtb_SY.Name = "txtb_SY"
        Me.txtb_SY.Size = New System.Drawing.Size(100, 26)
        Me.txtb_SY.TabIndex = 6
        '
        'txtb_studLevel
        '
        Me.txtb_studLevel.BackColor = System.Drawing.Color.White
        Me.txtb_studLevel.Enabled = False
        Me.txtb_studLevel.Location = New System.Drawing.Point(283, 97)
        Me.txtb_studLevel.Name = "txtb_studLevel"
        Me.txtb_studLevel.Size = New System.Drawing.Size(149, 26)
        Me.txtb_studLevel.TabIndex = 6
        '
        'txtb_studFname
        '
        Me.txtb_studFname.BackColor = System.Drawing.Color.White
        Me.txtb_studFname.Enabled = False
        Me.txtb_studFname.Location = New System.Drawing.Point(88, 60)
        Me.txtb_studFname.Name = "txtb_studFname"
        Me.txtb_studFname.Size = New System.Drawing.Size(103, 26)
        Me.txtb_studFname.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(383, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(299, 34)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "SCHOLARSHIP GRANT LIST"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txtb_refNo)
        Me.GroupBox3.Controls.Add(Me.cbo_scholarType)
        Me.GroupBox3.Controls.Add(Me.rb_inactive)
        Me.GroupBox3.Controls.Add(Me.rb_active)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtb_ScholarAmnt)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(441, 165)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SCHOLARSHIP INFORMATION"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(19, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 21)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "SCHOLAR REF. NO."
        '
        'txtb_refNo
        '
        Me.txtb_refNo.AutoCompleteCustomSource.AddRange(New String() {"Niño Agsoy", "Tajmahal Amarila", "Joshua Avila", "Harvey Baloria", "Faith Claire Bawan", "Mark Bello", "Charmel Camposo", "Kristel Ann Corpuz", "Princess Anne Dadul", "Vj Debuque", "Juvy Dela Cruz", "Laica Joy Delostrico", "Charles Deragosa", "Chris Lyn Joyce Diaz", "Amado Doverte", "John Mark Dulce", "James Bryan N. Dumail", "Junelyn Gumia", "Jessa Langwas", "Annalyn Larita", "Rhea Lynn Legaspi", "Mayter Lumiguid", "Charlene Manabat", "John Vincent A. Medillo", "Jericho Montealto", "Wendel Odilao", "Kurt Randall Oviedo", "Elson Patac", "Kate Pendon", "Carren Polinio", "Jhon Philip Pondar", "Arnic Reponte", "Quirjhon Dave Rivera", "Hanna Gladys Sala", "ARIEL SAOCEJO", "Rea Siarot", "Robel Sta Teresa", "Venus Torrevillas", "Tyrone Vibas", "Jerald Jose"})
        Me.txtb_refNo.Enabled = False
        Me.txtb_refNo.Location = New System.Drawing.Point(180, 23)
        Me.txtb_refNo.Name = "txtb_refNo"
        Me.txtb_refNo.Size = New System.Drawing.Size(252, 26)
        Me.txtb_refNo.TabIndex = 8
        '
        'cbo_scholarType
        '
        Me.cbo_scholarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_scholarType.Enabled = False
        Me.cbo_scholarType.FormattingEnabled = True
        Me.cbo_scholarType.Items.AddRange(New Object() {"Id Number", "Name"})
        Me.cbo_scholarType.Location = New System.Drawing.Point(180, 59)
        Me.cbo_scholarType.Name = "cbo_scholarType"
        Me.cbo_scholarType.Size = New System.Drawing.Size(252, 29)
        Me.cbo_scholarType.TabIndex = 8
        '
        'rb_inactive
        '
        Me.rb_inactive.AutoSize = True
        Me.rb_inactive.Location = New System.Drawing.Point(265, 136)
        Me.rb_inactive.Name = "rb_inactive"
        Me.rb_inactive.Size = New System.Drawing.Size(81, 25)
        Me.rb_inactive.TabIndex = 21
        Me.rb_inactive.Text = "INACTIVE"
        Me.rb_inactive.UseVisualStyleBackColor = True
        '
        'rb_active
        '
        Me.rb_active.AutoSize = True
        Me.rb_active.Location = New System.Drawing.Point(176, 136)
        Me.rb_active.Name = "rb_active"
        Me.rb_active.Size = New System.Drawing.Size(68, 25)
        Me.rb_active.TabIndex = 20
        Me.rb_active.Text = "ACTIVE"
        Me.rb_active.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(176, 136)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 25)
        Me.RadioButton1.TabIndex = 20
        Me.RadioButton1.Text = "Active"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label13.Location = New System.Drawing.Point(19, 138)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 21)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "SCHOLARSHIP STATUS"
        '
        'txtb_ScholarAmnt
        '
        Me.txtb_ScholarAmnt.BackColor = System.Drawing.Color.White
        Me.txtb_ScholarAmnt.Enabled = False
        Me.txtb_ScholarAmnt.Location = New System.Drawing.Point(180, 99)
        Me.txtb_ScholarAmnt.Name = "txtb_ScholarAmnt"
        Me.txtb_ScholarAmnt.Size = New System.Drawing.Size(252, 26)
        Me.txtb_ScholarAmnt.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(19, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "SCHOLARSHIP AMOUNT"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(19, 62)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "SCHOLARSHIP TYPE"
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
        Me.btn_cancel.Location = New System.Drawing.Point(21, 462)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancel.selected = False
        Me.btn_cancel.Size = New System.Drawing.Size(136, 35)
        Me.btn_cancel.TabIndex = 55
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_cancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_add
        '
        Me.btn_add.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_add.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_add.BorderRadius = 0
        Me.btn_add.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_add.ButtonText = "ADD"
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.DisabledColor = System.Drawing.Color.Gray
        Me.btn_add.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_add.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_add.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_add.Iconimage = Nothing
        Me.btn_add.Iconimage_right = Nothing
        Me.btn_add.Iconimage_right_Selected = Nothing
        Me.btn_add.Iconimage_Selected = Nothing
        Me.btn_add.IconMarginLeft = 0
        Me.btn_add.IconMarginRight = 0
        Me.btn_add.IconRightVisible = False
        Me.btn_add.IconRightZoom = 0R
        Me.btn_add.IconVisible = False
        Me.btn_add.IconZoom = 90.0R
        Me.btn_add.IsTab = False
        Me.btn_add.Location = New System.Drawing.Point(161, 462)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(136, 35)
        Me.btn_add.TabIndex = 54
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_add.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_add.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_update
        '
        Me.btn_update.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_update.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_update.BorderRadius = 0
        Me.btn_update.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_update.ButtonText = "UPDATE"
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.DisabledColor = System.Drawing.Color.Gray
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_update.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_update.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_update.Iconimage = Nothing
        Me.btn_update.Iconimage_right = Nothing
        Me.btn_update.Iconimage_right_Selected = Nothing
        Me.btn_update.Iconimage_Selected = Nothing
        Me.btn_update.IconMarginLeft = 0
        Me.btn_update.IconMarginRight = 0
        Me.btn_update.IconRightVisible = False
        Me.btn_update.IconRightZoom = 0R
        Me.btn_update.IconVisible = False
        Me.btn_update.IconZoom = 90.0R
        Me.btn_update.IsTab = False
        Me.btn_update.Location = New System.Drawing.Point(303, 462)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(136, 35)
        Me.btn_update.TabIndex = 53
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_update.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_update.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_manageScholar)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.btn_add)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(15, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 506)
        Me.Panel1.TabIndex = 49
        '
        'btn_manageScholar
        '
        Me.btn_manageScholar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_manageScholar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_manageScholar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_manageScholar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_manageScholar.BorderRadius = 0
        Me.btn_manageScholar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_manageScholar.ButtonText = "MANAGE SCHOLARSHIP DETAILS"
        Me.btn_manageScholar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_manageScholar.DisabledColor = System.Drawing.Color.Gray
        Me.btn_manageScholar.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_manageScholar.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_manageScholar.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_manageScholar.Iconimage = Nothing
        Me.btn_manageScholar.Iconimage_right = Nothing
        Me.btn_manageScholar.Iconimage_right_Selected = Nothing
        Me.btn_manageScholar.Iconimage_Selected = Nothing
        Me.btn_manageScholar.IconMarginLeft = 0
        Me.btn_manageScholar.IconMarginRight = 0
        Me.btn_manageScholar.IconRightVisible = False
        Me.btn_manageScholar.IconRightZoom = 0R
        Me.btn_manageScholar.IconVisible = False
        Me.btn_manageScholar.IconZoom = 90.0R
        Me.btn_manageScholar.IsTab = False
        Me.btn_manageScholar.Location = New System.Drawing.Point(227, 221)
        Me.btn_manageScholar.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_manageScholar.Name = "btn_manageScholar"
        Me.btn_manageScholar.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_manageScholar.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_manageScholar.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_manageScholar.selected = False
        Me.btn_manageScholar.Size = New System.Drawing.Size(216, 35)
        Me.btn_manageScholar.TabIndex = 56
        Me.btn_manageScholar.Text = "MANAGE SCHOLARSHIP DETAILS"
        Me.btn_manageScholar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_manageScholar.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_manageScholar.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(480, 135)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(564, 506)
        Me.FlowLayoutPanel1.TabIndex = 50
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dg_StudScholarRec)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(3, 79)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(557, 418)
        Me.Panel3.TabIndex = 38
        '
        'dg_StudScholarRec
        '
        Me.dg_StudScholarRec.AllowUserToAddRows = False
        Me.dg_StudScholarRec.AllowUserToDeleteRows = False
        Me.dg_StudScholarRec.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_StudScholarRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dg_StudScholarRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_StudScholarRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_StudScholarRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_StudScholarRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_StudScholarRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dg_StudScholarRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_StudScholarRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudidDataGridViewTextBoxColumn, Me.StudFnameDataGridViewTextBoxColumn, Me.StudLnameDataGridViewTextBoxColumn, Me.Column1, Me.StudmidIDataGridViewTextBoxColumn, Me.sy, Me.level})
        Me.dg_StudScholarRec.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_StudScholarRec.DoubleBuffered = True
        Me.dg_StudScholarRec.EnableHeadersVisualStyles = False
        Me.dg_StudScholarRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_StudScholarRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_StudScholarRec.Location = New System.Drawing.Point(0, 0)
        Me.dg_StudScholarRec.Name = "dg_StudScholarRec"
        Me.dg_StudScholarRec.ReadOnly = True
        Me.dg_StudScholarRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_StudScholarRec.RowHeadersVisible = False
        Me.dg_StudScholarRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_StudScholarRec.Size = New System.Drawing.Size(557, 418)
        Me.dg_StudScholarRec.TabIndex = 53
        '
        'StudidDataGridViewTextBoxColumn
        '
        Me.StudidDataGridViewTextBoxColumn.HeaderText = "stud_id"
        Me.StudidDataGridViewTextBoxColumn.Name = "StudidDataGridViewTextBoxColumn"
        Me.StudidDataGridViewTextBoxColumn.ReadOnly = True
        Me.StudidDataGridViewTextBoxColumn.Visible = False
        '
        'StudFnameDataGridViewTextBoxColumn
        '
        Me.StudFnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.StudFnameDataGridViewTextBoxColumn.Name = "StudFnameDataGridViewTextBoxColumn"
        Me.StudFnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudLnameDataGridViewTextBoxColumn
        '
        Me.StudLnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.StudLnameDataGridViewTextBoxColumn.Name = "StudLnameDataGridViewTextBoxColumn"
        Me.StudLnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "M.I"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'StudmidIDataGridViewTextBoxColumn
        '
        Me.StudmidIDataGridViewTextBoxColumn.HeaderText = "Scholar Type"
        Me.StudmidIDataGridViewTextBoxColumn.Name = "StudmidIDataGridViewTextBoxColumn"
        Me.StudmidIDataGridViewTextBoxColumn.ReadOnly = True
        '
        'sy
        '
        Me.sy.HeaderText = "SY"
        Me.sy.Name = "sy"
        Me.sy.ReadOnly = True
        Me.sy.Visible = False
        '
        'level
        '
        Me.level.HeaderText = "Level"
        Me.level.Name = "level"
        Me.level.ReadOnly = True
        Me.level.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbo_SelectDept)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1064, 70)
        Me.Panel2.TabIndex = 51
        '
        'cbo_SelectDept
        '
        Me.cbo_SelectDept.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SelectDept.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SelectDept.FormattingEnabled = True
        Me.cbo_SelectDept.Items.AddRange(New Object() {"COLLEGE DEPARTMENT", "ELEMENTARY DEPARTMENT", "SENIOR-HIGH DEPARTMENT", "JUNIOR-HIGH DEPARTMENT"})
        Me.cbo_SelectDept.Location = New System.Drawing.Point(489, 17)
        Me.cbo_SelectDept.Name = "cbo_SelectDept"
        Me.cbo_SelectDept.Size = New System.Drawing.Size(282, 33)
        Me.cbo_SelectDept.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label14.Location = New System.Drawing.Point(294, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(189, 25)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "SELECT DEPARTMENT"
        '
        'frm_sSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "frm_sSG"
        Me.Size = New System.Drawing.Size(1064, 664)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg_StudScholarRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_SearchBy As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtb_Search As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_sem As System.Windows.Forms.Label
    Friend WithEvents txtb_studid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtb_studMI As System.Windows.Forms.TextBox
    Friend WithEvents lbl_course As System.Windows.Forms.Label
    Friend WithEvents lbl_level As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtb_studLname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtb_studSem As System.Windows.Forms.TextBox
    Friend WithEvents txtb_studCourse As System.Windows.Forms.TextBox
    Friend WithEvents txtb_SY As System.Windows.Forms.TextBox
    Friend WithEvents txtb_studLevel As System.Windows.Forms.TextBox
    Friend WithEvents txtb_studFname As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_inactive As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtb_ScholarAmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents rb_active As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dg_StudScholarRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents StudidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudFnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudLnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents StudmidIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents sy As DataGridViewTextBoxColumn
    Friend WithEvents level As DataGridViewTextBoxColumn
    Friend WithEvents btn_add As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_update As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_manageScholar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_scholarType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_refNo As TextBox
    Friend WithEvents cbo_SelectDept As ComboBox
End Class
