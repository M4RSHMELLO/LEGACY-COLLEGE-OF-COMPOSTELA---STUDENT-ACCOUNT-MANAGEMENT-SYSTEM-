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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sSG))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_SearchBy = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtb_Search = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtb_studid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.x = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.BunifuThinButton23 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.BunifuThinButton22 = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtb_ScholarAmnt = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtb_ScholarType = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dg_StudScholarRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.s_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_fName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_lName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.midd_i = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.s_yLevel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbo_SelectDept = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Db_lccsamsDataSet = New LCC_SAMS_Project.db_lccsamsDataSet()
        Me.TblcollscholarlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_coll_scholarlistTableAdapter = New LCC_SAMS_Project.db_lccsamsDataSetTableAdapters.tbl_coll_scholarlistTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_StudScholarRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Db_lccsamsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblcollscholarlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtb_Search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtb_Search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtb_Search.Location = New System.Drawing.Point(264, 25)
        Me.txtb_Search.Name = "txtb_Search"
        Me.txtb_Search.Size = New System.Drawing.Size(264, 30)
        Me.txtb_Search.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtb_studid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.x)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label6.Location = New System.Drawing.Point(6, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "SEMESTER"
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
        'x
        '
        Me.x.BackColor = System.Drawing.Color.White
        Me.x.Enabled = False
        Me.x.Location = New System.Drawing.Point(402, 60)
        Me.x.Name = "x"
        Me.x.Size = New System.Drawing.Size(30, 26)
        Me.x.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(6, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 21)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "COURSE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(188, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "YEAR LEVEL"
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
        Me.txtb_studLevel.Location = New System.Drawing.Point(265, 97)
        Me.txtb_studLevel.Name = "txtb_studLevel"
        Me.txtb_studLevel.Size = New System.Drawing.Size(167, 26)
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
        Me.GroupBox3.Controls.Add(Me.BunifuThinButton23)
        Me.GroupBox3.Controls.Add(Me.BunifuThinButton22)
        Me.GroupBox3.Controls.Add(Me.RadioButton2)
        Me.GroupBox3.Controls.Add(Me.RadioButton3)
        Me.GroupBox3.Controls.Add(Me.RadioButton1)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txtb_ScholarAmnt)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtb_ScholarType)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(11, 235)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(441, 201)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SCHOLARSHIP INFORMATION"
        '
        'BunifuThinButton23
        '
        Me.BunifuThinButton23.ActiveBorderThickness = 1
        Me.BunifuThinButton23.ActiveCornerRadius = 20
        Me.BunifuThinButton23.ActiveFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton23.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton23.BackgroundImage = CType(resources.GetObject("BunifuThinButton23.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton23.ButtonText = "UPDATE"
        Me.BunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton23.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton23.ForeColor = System.Drawing.Color.DarkGreen
        Me.BunifuThinButton23.IdleBorderThickness = 1
        Me.BunifuThinButton23.IdleCornerRadius = 20
        Me.BunifuThinButton23.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton23.Location = New System.Drawing.Point(230, 146)
        Me.BunifuThinButton23.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton23.Name = "BunifuThinButton23"
        Me.BunifuThinButton23.Size = New System.Drawing.Size(80, 45)
        Me.BunifuThinButton23.TabIndex = 9
        Me.BunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuThinButton22
        '
        Me.BunifuThinButton22.ActiveBorderThickness = 1
        Me.BunifuThinButton22.ActiveCornerRadius = 20
        Me.BunifuThinButton22.ActiveFillColor = System.Drawing.Color.Transparent
        Me.BunifuThinButton22.ActiveForecolor = System.Drawing.Color.White
        Me.BunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.BackColor = System.Drawing.SystemColors.Control
        Me.BunifuThinButton22.BackgroundImage = CType(resources.GetObject("BunifuThinButton22.BackgroundImage"), System.Drawing.Image)
        Me.BunifuThinButton22.ButtonText = "ADD"
        Me.BunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuThinButton22.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuThinButton22.ForeColor = System.Drawing.Color.DarkGreen
        Me.BunifuThinButton22.IdleBorderThickness = 1
        Me.BunifuThinButton22.IdleCornerRadius = 20
        Me.BunifuThinButton22.IdleFillColor = System.Drawing.Color.White
        Me.BunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen
        Me.BunifuThinButton22.Location = New System.Drawing.Point(121, 146)
        Me.BunifuThinButton22.Margin = New System.Windows.Forms.Padding(5)
        Me.BunifuThinButton22.Name = "BunifuThinButton22"
        Me.BunifuThinButton22.Size = New System.Drawing.Size(80, 45)
        Me.BunifuThinButton22.TabIndex = 9
        Me.BunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(252, 103)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(81, 25)
        Me.RadioButton2.TabIndex = 21
        Me.RadioButton2.Text = "INACTIVE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(163, 105)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(68, 25)
        Me.RadioButton3.TabIndex = 20
        Me.RadioButton3.Text = "ACTIVE"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(163, 105)
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
        Me.Label13.Location = New System.Drawing.Point(6, 107)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(144, 21)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "SCHOLARSHIP STATUS"
        '
        'txtb_ScholarAmnt
        '
        Me.txtb_ScholarAmnt.BackColor = System.Drawing.Color.White
        Me.txtb_ScholarAmnt.Enabled = False
        Me.txtb_ScholarAmnt.Location = New System.Drawing.Point(163, 68)
        Me.txtb_ScholarAmnt.Name = "txtb_ScholarAmnt"
        Me.txtb_ScholarAmnt.Size = New System.Drawing.Size(252, 26)
        Me.txtb_ScholarAmnt.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label12.Location = New System.Drawing.Point(6, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 21)
        Me.Label12.TabIndex = 17
        Me.Label12.Text = "SCHOLARSHIP AMOUNT"
        '
        'txtb_ScholarType
        '
        Me.txtb_ScholarType.BackColor = System.Drawing.Color.White
        Me.txtb_ScholarType.Enabled = False
        Me.txtb_ScholarType.Location = New System.Drawing.Point(163, 25)
        Me.txtb_ScholarType.Name = "txtb_ScholarType"
        Me.txtb_ScholarType.Size = New System.Drawing.Size(252, 26)
        Me.txtb_ScholarType.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(163, 25)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(252, 26)
        Me.TextBox5.TabIndex = 16
        Me.TextBox5.Text = "CHED-UniFAST"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(6, 31)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(127, 21)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "SCHOLARSHIP TYPE"
        '
        'dg_StudScholarRec
        '
        Me.dg_StudScholarRec.AllowUserToAddRows = False
        Me.dg_StudScholarRec.AllowUserToDeleteRows = False
        Me.dg_StudScholarRec.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_StudScholarRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_StudScholarRec.AutoGenerateColumns = False
        Me.dg_StudScholarRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_StudScholarRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_StudScholarRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_StudScholarRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_StudScholarRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_StudScholarRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_StudScholarRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.s_id, Me.s_fName, Me.s_lName, Me.midd_i, Me.s_yLevel})
        Me.dg_StudScholarRec.DataSource = Me.TblcollscholarlistBindingSource
        Me.dg_StudScholarRec.DoubleBuffered = True
        Me.dg_StudScholarRec.EnableHeadersVisualStyles = False
        Me.dg_StudScholarRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_StudScholarRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_StudScholarRec.Location = New System.Drawing.Point(3, 79)
        Me.dg_StudScholarRec.Name = "dg_StudScholarRec"
        Me.dg_StudScholarRec.ReadOnly = True
        Me.dg_StudScholarRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_StudScholarRec.RowHeadersVisible = False
        Me.dg_StudScholarRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_StudScholarRec.Size = New System.Drawing.Size(548, 357)
        Me.dg_StudScholarRec.TabIndex = 48
        '
        's_id
        '
        Me.s_id.HeaderText = "Stud. id"
        Me.s_id.Name = "s_id"
        Me.s_id.ReadOnly = True
        '
        's_fName
        '
        Me.s_fName.HeaderText = "First Name"
        Me.s_fName.Name = "s_fName"
        Me.s_fName.ReadOnly = True
        '
        's_lName
        '
        Me.s_lName.HeaderText = "Last Name"
        Me.s_lName.Name = "s_lName"
        Me.s_lName.ReadOnly = True
        '
        'midd_i
        '
        Me.midd_i.HeaderText = "M.I"
        Me.midd_i.Name = "midd_i"
        Me.midd_i.ReadOnly = True
        '
        's_yLevel
        '
        Me.s_yLevel.HeaderText = "Scholar Type"
        Me.s_yLevel.Name = "s_yLevel"
        Me.s_yLevel.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Location = New System.Drawing.Point(15, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(459, 448)
        Me.Panel1.TabIndex = 49
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.dg_StudScholarRec)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(480, 135)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(562, 448)
        Me.FlowLayoutPanel1.TabIndex = 50
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
        'Db_lccsamsDataSet
        '
        Me.Db_lccsamsDataSet.DataSetName = "db_lccsamsDataSet"
        Me.Db_lccsamsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblcollscholarlistBindingSource
        '
        Me.TblcollscholarlistBindingSource.DataMember = "tbl_coll_scholarlist"
        Me.TblcollscholarlistBindingSource.DataSource = Me.Db_lccsamsDataSet
        '
        'Tbl_coll_scholarlistTableAdapter
        '
        Me.Tbl_coll_scholarlistTableAdapter.ClearBeforeFill = True
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
        CType(Me.dg_StudScholarRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Db_lccsamsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblcollscholarlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtb_studid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents x As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
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
    Friend WithEvents BunifuThinButton23 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents BunifuThinButton22 As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtb_ScholarAmnt As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dg_StudScholarRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents txtb_ScholarType As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cbo_SelectDept As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents s_id As DataGridViewTextBoxColumn
    Friend WithEvents s_fName As DataGridViewTextBoxColumn
    Friend WithEvents s_lName As DataGridViewTextBoxColumn
    Friend WithEvents midd_i As DataGridViewTextBoxColumn
    Friend WithEvents s_yLevel As DataGridViewTextBoxColumn
    Friend WithEvents TblcollscholarlistBindingSource As BindingSource
    Friend WithEvents Db_lccsamsDataSet As db_lccsamsDataSet
    Friend WithEvents Tbl_coll_scholarlistTableAdapter As db_lccsamsDataSetTableAdapters.tbl_coll_scholarlistTableAdapter
End Class
