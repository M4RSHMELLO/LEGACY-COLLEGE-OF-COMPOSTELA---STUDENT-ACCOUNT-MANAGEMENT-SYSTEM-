<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Mpayments
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.dg_jFeesRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.cbo_jSortSY = New System.Windows.Forms.ComboBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.btn_jCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.cbo_jSY = New System.Windows.Forms.ComboBox()
        Me.txtb_jFeesAmnt = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.btn_jSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtb_jFeesName = New System.Windows.Forms.TextBox()
        Me.btn_jUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_jAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.dg_sfeesRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbo_sSortSY = New System.Windows.Forms.ComboBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbo_sSY = New System.Windows.Forms.ComboBox()
        Me.btn_sCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtb_sFeeAmnt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btn_sSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtb_sfeeName = New System.Windows.Forms.TextBox()
        Me.btn_sUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_sAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.elem_dept = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dg_eFeesRec = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_eSortSy = New System.Windows.Forms.ComboBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btn_eCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cbo_eSY = New System.Windows.Forms.ComboBox()
        Me.txtb_eFeeAmnt = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.btn_eSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtb_eFeeName = New System.Windows.Forms.TextBox()
        Me.btn_eUpdate = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_eAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dg_pRecords = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.fees_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fees_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fees_amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rpu_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cbo_SortCrs = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbo_SortYL = New System.Windows.Forms.ComboBox()
        Me.cbo_SortSem = New System.Windows.Forms.ComboBox()
        Me.cbo_SortSY = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbo_yl = New System.Windows.Forms.ComboBox()
        Me.checkb_tuitionfee_indicator = New Bunifu.Framework.UI.BunifuCheckbox()
        Me.cbo_MSY = New System.Windows.Forms.ComboBox()
        Me.txtb_collAmnt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtb_CollName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_update = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.cbo_MS = New System.Windows.Forms.ComboBox()
        Me.cbo_course = New System.Windows.Forms.ComboBox()
        Me.btn_add = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.dg_jFeesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.dg_sfeesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.elem_dept.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dg_eFeesRec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dg_pRecords, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Controls.Add(Me.Panel8)
        Me.TabPage3.Controls.Add(Me.Panel9)
        Me.TabPage3.Location = New System.Drawing.Point(4, 30)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1067, 684)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Junior-High Dept"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.dg_jFeesRec)
        Me.Panel8.Controls.Add(Me.GroupBox3)
        Me.Panel8.Location = New System.Drawing.Point(395, 103)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(639, 479)
        Me.Panel8.TabIndex = 61
        '
        'dg_jFeesRec
        '
        Me.dg_jFeesRec.AllowDrop = True
        Me.dg_jFeesRec.AllowUserToAddRows = False
        Me.dg_jFeesRec.AllowUserToDeleteRows = False
        Me.dg_jFeesRec.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_jFeesRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dg_jFeesRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_jFeesRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_jFeesRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_jFeesRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_jFeesRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dg_jFeesRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_jFeesRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.dg_jFeesRec.DoubleBuffered = True
        Me.dg_jFeesRec.EnableHeadersVisualStyles = False
        Me.dg_jFeesRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_jFeesRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_jFeesRec.Location = New System.Drawing.Point(13, 97)
        Me.dg_jFeesRec.Name = "dg_jFeesRec"
        Me.dg_jFeesRec.ReadOnly = True
        Me.dg_jFeesRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_jFeesRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_jFeesRec.Size = New System.Drawing.Size(609, 377)
        Me.dg_jFeesRec.TabIndex = 58
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "jfees_id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Fees ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "jfees_name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "jfees_amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.cbo_jSortSY)
        Me.GroupBox3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(609, 65)
        Me.GroupBox3.TabIndex = 57
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "SORT BY"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(22, 26)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(30, 20)
        Me.Label29.TabIndex = 31
        Me.Label29.Text = "S/Y"
        '
        'cbo_jSortSY
        '
        Me.cbo_jSortSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jSortSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_jSortSY.FormattingEnabled = True
        Me.cbo_jSortSY.Location = New System.Drawing.Point(80, 26)
        Me.cbo_jSortSY.Name = "cbo_jSortSY"
        Me.cbo_jSortSY.Size = New System.Drawing.Size(218, 24)
        Me.cbo_jSortSY.TabIndex = 11
        '
        'Panel9
        '
        Me.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel9.Controls.Add(Me.btn_jCancel)
        Me.Panel9.Controls.Add(Me.Label31)
        Me.Panel9.Controls.Add(Me.Label32)
        Me.Panel9.Controls.Add(Me.cbo_jSY)
        Me.Panel9.Controls.Add(Me.txtb_jFeesAmnt)
        Me.Panel9.Controls.Add(Me.Label34)
        Me.Panel9.Controls.Add(Me.btn_jSave)
        Me.Panel9.Controls.Add(Me.txtb_jFeesName)
        Me.Panel9.Controls.Add(Me.btn_jUpdate)
        Me.Panel9.Controls.Add(Me.btn_jAdd)
        Me.Panel9.Location = New System.Drawing.Point(33, 103)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(356, 479)
        Me.Panel9.TabIndex = 60
        '
        'btn_jCancel
        '
        Me.btn_jCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_jCancel.Location = New System.Drawing.Point(69, 346)
        Me.btn_jCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jCancel.Name = "btn_jCancel"
        Me.btn_jCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jCancel.selected = False
        Me.btn_jCancel.Size = New System.Drawing.Size(84, 29)
        Me.btn_jCancel.TabIndex = 58
        Me.btn_jCancel.Text = "CANCEL"
        Me.btn_jCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(24, 40)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 21)
        Me.Label31.TabIndex = 26
        Me.Label31.Text = "SCHOOL YEAR"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(24, 194)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(45, 21)
        Me.Label32.TabIndex = 31
        Me.Label32.Text = "NAME"
        '
        'cbo_jSY
        '
        Me.cbo_jSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_jSY.Enabled = False
        Me.cbo_jSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_jSY.FormattingEnabled = True
        Me.cbo_jSY.Location = New System.Drawing.Point(123, 40)
        Me.cbo_jSY.Name = "cbo_jSY"
        Me.cbo_jSY.Size = New System.Drawing.Size(217, 29)
        Me.cbo_jSY.TabIndex = 25
        '
        'txtb_jFeesAmnt
        '
        Me.txtb_jFeesAmnt.Enabled = False
        Me.txtb_jFeesAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_jFeesAmnt.Location = New System.Drawing.Point(87, 229)
        Me.txtb_jFeesAmnt.Name = "txtb_jFeesAmnt"
        Me.txtb_jFeesAmnt.Size = New System.Drawing.Size(253, 26)
        Me.txtb_jFeesAmnt.TabIndex = 32
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(24, 229)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(62, 21)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "AMOUNT"
        '
        'btn_jSave
        '
        Me.btn_jSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_jSave.Location = New System.Drawing.Point(199, 346)
        Me.btn_jSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jSave.Name = "btn_jSave"
        Me.btn_jSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jSave.selected = False
        Me.btn_jSave.Size = New System.Drawing.Size(84, 29)
        Me.btn_jSave.TabIndex = 53
        Me.btn_jSave.Text = "SAVE"
        Me.btn_jSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtb_jFeesName
        '
        Me.txtb_jFeesName.Enabled = False
        Me.txtb_jFeesName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_jFeesName.Location = New System.Drawing.Point(87, 191)
        Me.txtb_jFeesName.Name = "txtb_jFeesName"
        Me.txtb_jFeesName.Size = New System.Drawing.Size(253, 26)
        Me.txtb_jFeesName.TabIndex = 24
        '
        'btn_jUpdate
        '
        Me.btn_jUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jUpdate.BorderRadius = 0
        Me.btn_jUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jUpdate.ButtonText = "UPDATE"
        Me.btn_jUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jUpdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jUpdate.Iconimage = Nothing
        Me.btn_jUpdate.Iconimage_right = Nothing
        Me.btn_jUpdate.Iconimage_right_Selected = Nothing
        Me.btn_jUpdate.Iconimage_Selected = Nothing
        Me.btn_jUpdate.IconMarginLeft = 0
        Me.btn_jUpdate.IconMarginRight = 0
        Me.btn_jUpdate.IconRightVisible = False
        Me.btn_jUpdate.IconRightZoom = 0R
        Me.btn_jUpdate.IconVisible = False
        Me.btn_jUpdate.IconZoom = 90.0R
        Me.btn_jUpdate.IsTab = False
        Me.btn_jUpdate.Location = New System.Drawing.Point(199, 307)
        Me.btn_jUpdate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jUpdate.Name = "btn_jUpdate"
        Me.btn_jUpdate.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jUpdate.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jUpdate.selected = False
        Me.btn_jUpdate.Size = New System.Drawing.Size(84, 29)
        Me.btn_jUpdate.TabIndex = 55
        Me.btn_jUpdate.Text = "UPDATE"
        Me.btn_jUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jUpdate.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jUpdate.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_jAdd
        '
        Me.btn_jAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_jAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_jAdd.BorderRadius = 0
        Me.btn_jAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_jAdd.ButtonText = "ADD"
        Me.btn_jAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_jAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btn_jAdd.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_jAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_jAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_jAdd.Iconimage = Nothing
        Me.btn_jAdd.Iconimage_right = Nothing
        Me.btn_jAdd.Iconimage_right_Selected = Nothing
        Me.btn_jAdd.Iconimage_Selected = Nothing
        Me.btn_jAdd.IconMarginLeft = 0
        Me.btn_jAdd.IconMarginRight = 0
        Me.btn_jAdd.IconRightVisible = False
        Me.btn_jAdd.IconRightZoom = 0R
        Me.btn_jAdd.IconVisible = False
        Me.btn_jAdd.IconZoom = 90.0R
        Me.btn_jAdd.IsTab = False
        Me.btn_jAdd.Location = New System.Drawing.Point(69, 307)
        Me.btn_jAdd.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_jAdd.Name = "btn_jAdd"
        Me.btn_jAdd.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_jAdd.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_jAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_jAdd.selected = False
        Me.btn_jAdd.Size = New System.Drawing.Size(84, 29)
        Me.btn_jAdd.TabIndex = 54
        Me.btn_jAdd.Text = "ADD"
        Me.btn_jAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_jAdd.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_jAdd.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel6)
        Me.TabPage2.Controls.Add(Me.Panel7)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1067, 684)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Senior-High Dept"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.dg_sfeesRec)
        Me.Panel6.Controls.Add(Me.GroupBox2)
        Me.Panel6.Location = New System.Drawing.Point(395, 103)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(639, 479)
        Me.Panel6.TabIndex = 61
        '
        'dg_sfeesRec
        '
        Me.dg_sfeesRec.AllowDrop = True
        Me.dg_sfeesRec.AllowUserToAddRows = False
        Me.dg_sfeesRec.AllowUserToDeleteRows = False
        Me.dg_sfeesRec.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_sfeesRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dg_sfeesRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_sfeesRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_sfeesRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_sfeesRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_sfeesRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dg_sfeesRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sfeesRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.dg_sfeesRec.DoubleBuffered = True
        Me.dg_sfeesRec.EnableHeadersVisualStyles = False
        Me.dg_sfeesRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_sfeesRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_sfeesRec.Location = New System.Drawing.Point(13, 97)
        Me.dg_sfeesRec.Name = "dg_sfeesRec"
        Me.dg_sfeesRec.ReadOnly = True
        Me.dg_sfeesRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_sfeesRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_sfeesRec.Size = New System.Drawing.Size(609, 377)
        Me.dg_sfeesRec.TabIndex = 58
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cbo_sSortSY)
        Me.GroupBox2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(609, 65)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SORT BY"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "S/Y"
        '
        'cbo_sSortSY
        '
        Me.cbo_sSortSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sSortSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_sSortSY.FormattingEnabled = True
        Me.cbo_sSortSY.Location = New System.Drawing.Point(80, 26)
        Me.cbo_sSortSY.Name = "cbo_sSortSY"
        Me.cbo_sSortSY.Size = New System.Drawing.Size(218, 24)
        Me.cbo_sSortSY.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Controls.Add(Me.cbo_sSY)
        Me.Panel7.Controls.Add(Me.btn_sCancel)
        Me.Panel7.Controls.Add(Me.Label24)
        Me.Panel7.Controls.Add(Me.txtb_sFeeAmnt)
        Me.Panel7.Controls.Add(Me.Label26)
        Me.Panel7.Controls.Add(Me.btn_sSave)
        Me.Panel7.Controls.Add(Me.txtb_sfeeName)
        Me.Panel7.Controls.Add(Me.btn_sUpdate)
        Me.Panel7.Controls.Add(Me.btn_sAdd)
        Me.Panel7.Location = New System.Drawing.Point(33, 103)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(356, 479)
        Me.Panel7.TabIndex = 60
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(24, 40)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 21)
        Me.Label16.TabIndex = 62
        Me.Label16.Text = "SCHOOL YEAR"
        '
        'cbo_sSY
        '
        Me.cbo_sSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_sSY.Enabled = False
        Me.cbo_sSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_sSY.FormattingEnabled = True
        Me.cbo_sSY.Location = New System.Drawing.Point(123, 40)
        Me.cbo_sSY.Name = "cbo_sSY"
        Me.cbo_sSY.Size = New System.Drawing.Size(217, 29)
        Me.cbo_sSY.TabIndex = 61
        '
        'btn_sCancel
        '
        Me.btn_sCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_sCancel.Location = New System.Drawing.Point(69, 346)
        Me.btn_sCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sCancel.Name = "btn_sCancel"
        Me.btn_sCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sCancel.selected = False
        Me.btn_sCancel.Size = New System.Drawing.Size(84, 29)
        Me.btn_sCancel.TabIndex = 58
        Me.btn_sCancel.Text = "CANCEL"
        Me.btn_sCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(24, 194)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 21)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "NAME"
        '
        'txtb_sFeeAmnt
        '
        Me.txtb_sFeeAmnt.Enabled = False
        Me.txtb_sFeeAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sFeeAmnt.Location = New System.Drawing.Point(87, 229)
        Me.txtb_sFeeAmnt.Name = "txtb_sFeeAmnt"
        Me.txtb_sFeeAmnt.Size = New System.Drawing.Size(253, 26)
        Me.txtb_sFeeAmnt.TabIndex = 32
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(24, 229)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 21)
        Me.Label26.TabIndex = 23
        Me.Label26.Text = "AMOUNT"
        '
        'btn_sSave
        '
        Me.btn_sSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_sSave.Location = New System.Drawing.Point(199, 346)
        Me.btn_sSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sSave.Name = "btn_sSave"
        Me.btn_sSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sSave.selected = False
        Me.btn_sSave.Size = New System.Drawing.Size(84, 29)
        Me.btn_sSave.TabIndex = 53
        Me.btn_sSave.Text = "SAVE"
        Me.btn_sSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtb_sfeeName
        '
        Me.txtb_sfeeName.Enabled = False
        Me.txtb_sfeeName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sfeeName.Location = New System.Drawing.Point(87, 191)
        Me.txtb_sfeeName.Name = "txtb_sfeeName"
        Me.txtb_sfeeName.Size = New System.Drawing.Size(253, 26)
        Me.txtb_sfeeName.TabIndex = 24
        '
        'btn_sUpdate
        '
        Me.btn_sUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sUpdate.BorderRadius = 0
        Me.btn_sUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sUpdate.ButtonText = "UPDATE"
        Me.btn_sUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sUpdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sUpdate.Iconimage = Nothing
        Me.btn_sUpdate.Iconimage_right = Nothing
        Me.btn_sUpdate.Iconimage_right_Selected = Nothing
        Me.btn_sUpdate.Iconimage_Selected = Nothing
        Me.btn_sUpdate.IconMarginLeft = 0
        Me.btn_sUpdate.IconMarginRight = 0
        Me.btn_sUpdate.IconRightVisible = False
        Me.btn_sUpdate.IconRightZoom = 0R
        Me.btn_sUpdate.IconVisible = False
        Me.btn_sUpdate.IconZoom = 90.0R
        Me.btn_sUpdate.IsTab = False
        Me.btn_sUpdate.Location = New System.Drawing.Point(199, 307)
        Me.btn_sUpdate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sUpdate.Name = "btn_sUpdate"
        Me.btn_sUpdate.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sUpdate.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sUpdate.selected = False
        Me.btn_sUpdate.Size = New System.Drawing.Size(84, 29)
        Me.btn_sUpdate.TabIndex = 55
        Me.btn_sUpdate.Text = "UPDATE"
        Me.btn_sUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sUpdate.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sUpdate.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_sAdd
        '
        Me.btn_sAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_sAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_sAdd.BorderRadius = 0
        Me.btn_sAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_sAdd.ButtonText = "ADD"
        Me.btn_sAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_sAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btn_sAdd.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_sAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_sAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_sAdd.Iconimage = Nothing
        Me.btn_sAdd.Iconimage_right = Nothing
        Me.btn_sAdd.Iconimage_right_Selected = Nothing
        Me.btn_sAdd.Iconimage_Selected = Nothing
        Me.btn_sAdd.IconMarginLeft = 0
        Me.btn_sAdd.IconMarginRight = 0
        Me.btn_sAdd.IconRightVisible = False
        Me.btn_sAdd.IconRightZoom = 0R
        Me.btn_sAdd.IconVisible = False
        Me.btn_sAdd.IconZoom = 90.0R
        Me.btn_sAdd.IsTab = False
        Me.btn_sAdd.Location = New System.Drawing.Point(69, 307)
        Me.btn_sAdd.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_sAdd.Name = "btn_sAdd"
        Me.btn_sAdd.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_sAdd.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_sAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_sAdd.selected = False
        Me.btn_sAdd.Size = New System.Drawing.Size(84, 29)
        Me.btn_sAdd.TabIndex = 54
        Me.btn_sAdd.Text = "ADD"
        Me.btn_sAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_sAdd.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_sAdd.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'elem_dept
        '
        Me.elem_dept.BackColor = System.Drawing.SystemColors.Control
        Me.elem_dept.Controls.Add(Me.Panel3)
        Me.elem_dept.Controls.Add(Me.Panel5)
        Me.elem_dept.Location = New System.Drawing.Point(4, 30)
        Me.elem_dept.Name = "elem_dept"
        Me.elem_dept.Padding = New System.Windows.Forms.Padding(3)
        Me.elem_dept.Size = New System.Drawing.Size(1067, 684)
        Me.elem_dept.TabIndex = 1
        Me.elem_dept.Text = "Elementary Dept"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.dg_eFeesRec)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(395, 103)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(639, 479)
        Me.Panel3.TabIndex = 59
        '
        'dg_eFeesRec
        '
        Me.dg_eFeesRec.AllowDrop = True
        Me.dg_eFeesRec.AllowUserToAddRows = False
        Me.dg_eFeesRec.AllowUserToDeleteRows = False
        Me.dg_eFeesRec.AllowUserToResizeRows = False
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_eFeesRec.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dg_eFeesRec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_eFeesRec.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_eFeesRec.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_eFeesRec.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_eFeesRec.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dg_eFeesRec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_eFeesRec.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dg_eFeesRec.DoubleBuffered = True
        Me.dg_eFeesRec.EnableHeadersVisualStyles = False
        Me.dg_eFeesRec.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_eFeesRec.HeaderForeColor = System.Drawing.Color.White
        Me.dg_eFeesRec.Location = New System.Drawing.Point(13, 97)
        Me.dg_eFeesRec.Name = "dg_eFeesRec"
        Me.dg_eFeesRec.ReadOnly = True
        Me.dg_eFeesRec.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_eFeesRec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_eFeesRec.Size = New System.Drawing.Size(609, 377)
        Me.dg_eFeesRec.TabIndex = 58
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
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "efees_name"
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cbo_eSortSy)
        Me.GroupBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(609, 65)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SORT BY"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 26)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "S/Y"
        '
        'cbo_eSortSy
        '
        Me.cbo_eSortSy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eSortSy.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_eSortSy.FormattingEnabled = True
        Me.cbo_eSortSy.Location = New System.Drawing.Point(80, 26)
        Me.cbo_eSortSy.Name = "cbo_eSortSy"
        Me.cbo_eSortSy.Size = New System.Drawing.Size(218, 24)
        Me.cbo_eSortSy.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.btn_eCancel)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.cbo_eSY)
        Me.Panel5.Controls.Add(Me.txtb_eFeeAmnt)
        Me.Panel5.Controls.Add(Me.Label20)
        Me.Panel5.Controls.Add(Me.btn_eSave)
        Me.Panel5.Controls.Add(Me.txtb_eFeeName)
        Me.Panel5.Controls.Add(Me.btn_eUpdate)
        Me.Panel5.Controls.Add(Me.btn_eAdd)
        Me.Panel5.Location = New System.Drawing.Point(33, 103)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(356, 479)
        Me.Panel5.TabIndex = 58
        '
        'btn_eCancel
        '
        Me.btn_eCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_eCancel.Location = New System.Drawing.Point(69, 346)
        Me.btn_eCancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eCancel.Name = "btn_eCancel"
        Me.btn_eCancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eCancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eCancel.selected = False
        Me.btn_eCancel.Size = New System.Drawing.Size(84, 29)
        Me.btn_eCancel.TabIndex = 58
        Me.btn_eCancel.Text = "CANCEL"
        Me.btn_eCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eCancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eCancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(24, 37)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(93, 21)
        Me.Label17.TabIndex = 26
        Me.Label17.Text = "SCHOOL YEAR"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(24, 194)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(45, 21)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "NAME"
        '
        'cbo_eSY
        '
        Me.cbo_eSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_eSY.Enabled = False
        Me.cbo_eSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_eSY.FormattingEnabled = True
        Me.cbo_eSY.Location = New System.Drawing.Point(123, 37)
        Me.cbo_eSY.Name = "cbo_eSY"
        Me.cbo_eSY.Size = New System.Drawing.Size(217, 29)
        Me.cbo_eSY.TabIndex = 25
        '
        'txtb_eFeeAmnt
        '
        Me.txtb_eFeeAmnt.Enabled = False
        Me.txtb_eFeeAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_eFeeAmnt.Location = New System.Drawing.Point(87, 229)
        Me.txtb_eFeeAmnt.Name = "txtb_eFeeAmnt"
        Me.txtb_eFeeAmnt.Size = New System.Drawing.Size(253, 26)
        Me.txtb_eFeeAmnt.TabIndex = 32
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(24, 229)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 21)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "AMOUNT"
        '
        'btn_eSave
        '
        Me.btn_eSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_eSave.Location = New System.Drawing.Point(199, 346)
        Me.btn_eSave.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eSave.Name = "btn_eSave"
        Me.btn_eSave.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eSave.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eSave.selected = False
        Me.btn_eSave.Size = New System.Drawing.Size(84, 29)
        Me.btn_eSave.TabIndex = 53
        Me.btn_eSave.Text = "SAVE"
        Me.btn_eSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eSave.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eSave.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtb_eFeeName
        '
        Me.txtb_eFeeName.Enabled = False
        Me.txtb_eFeeName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_eFeeName.Location = New System.Drawing.Point(87, 191)
        Me.txtb_eFeeName.Name = "txtb_eFeeName"
        Me.txtb_eFeeName.Size = New System.Drawing.Size(253, 26)
        Me.txtb_eFeeName.TabIndex = 24
        '
        'btn_eUpdate
        '
        Me.btn_eUpdate.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eUpdate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eUpdate.BorderRadius = 0
        Me.btn_eUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eUpdate.ButtonText = "UPDATE"
        Me.btn_eUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eUpdate.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eUpdate.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eUpdate.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eUpdate.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eUpdate.Iconimage = Nothing
        Me.btn_eUpdate.Iconimage_right = Nothing
        Me.btn_eUpdate.Iconimage_right_Selected = Nothing
        Me.btn_eUpdate.Iconimage_Selected = Nothing
        Me.btn_eUpdate.IconMarginLeft = 0
        Me.btn_eUpdate.IconMarginRight = 0
        Me.btn_eUpdate.IconRightVisible = False
        Me.btn_eUpdate.IconRightZoom = 0R
        Me.btn_eUpdate.IconVisible = False
        Me.btn_eUpdate.IconZoom = 90.0R
        Me.btn_eUpdate.IsTab = False
        Me.btn_eUpdate.Location = New System.Drawing.Point(199, 307)
        Me.btn_eUpdate.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eUpdate.Name = "btn_eUpdate"
        Me.btn_eUpdate.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eUpdate.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eUpdate.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eUpdate.selected = False
        Me.btn_eUpdate.Size = New System.Drawing.Size(84, 29)
        Me.btn_eUpdate.TabIndex = 55
        Me.btn_eUpdate.Text = "UPDATE"
        Me.btn_eUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eUpdate.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eUpdate.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_eAdd
        '
        Me.btn_eAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_eAdd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_eAdd.BorderRadius = 0
        Me.btn_eAdd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_eAdd.ButtonText = "ADD"
        Me.btn_eAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btn_eAdd.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_eAdd.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_eAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_eAdd.Iconimage = Nothing
        Me.btn_eAdd.Iconimage_right = Nothing
        Me.btn_eAdd.Iconimage_right_Selected = Nothing
        Me.btn_eAdd.Iconimage_Selected = Nothing
        Me.btn_eAdd.IconMarginLeft = 0
        Me.btn_eAdd.IconMarginRight = 0
        Me.btn_eAdd.IconRightVisible = False
        Me.btn_eAdd.IconRightZoom = 0R
        Me.btn_eAdd.IconVisible = False
        Me.btn_eAdd.IconZoom = 90.0R
        Me.btn_eAdd.IsTab = False
        Me.btn_eAdd.Location = New System.Drawing.Point(69, 307)
        Me.btn_eAdd.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_eAdd.Name = "btn_eAdd"
        Me.btn_eAdd.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_eAdd.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_eAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_eAdd.selected = False
        Me.btn_eAdd.Size = New System.Drawing.Size(84, 29)
        Me.btn_eAdd.TabIndex = 54
        Me.btn_eAdd.Text = "ADD"
        Me.btn_eAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_eAdd.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_eAdd.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1067, 684)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "College Dept"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1061, 678)
        Me.Panel1.TabIndex = 35
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dg_pRecords)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(387, 90)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(639, 479)
        Me.Panel2.TabIndex = 57
        '
        'dg_pRecords
        '
        Me.dg_pRecords.AllowDrop = True
        Me.dg_pRecords.AllowUserToAddRows = False
        Me.dg_pRecords.AllowUserToDeleteRows = False
        Me.dg_pRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dg_pRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dg_pRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_pRecords.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_pRecords.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_pRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_pRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dg_pRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pRecords.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fees_id, Me.fees_name, Me.fees_amount, Me.rpu_id})
        Me.dg_pRecords.DoubleBuffered = True
        Me.dg_pRecords.EnableHeadersVisualStyles = False
        Me.dg_pRecords.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dg_pRecords.HeaderForeColor = System.Drawing.Color.White
        Me.dg_pRecords.Location = New System.Drawing.Point(13, 151)
        Me.dg_pRecords.Name = "dg_pRecords"
        Me.dg_pRecords.ReadOnly = True
        Me.dg_pRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dg_pRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_pRecords.Size = New System.Drawing.Size(609, 323)
        Me.dg_pRecords.TabIndex = 58
        '
        'fees_id
        '
        Me.fees_id.DataPropertyName = "fees_id"
        Me.fees_id.HeaderText = "Fees ID"
        Me.fees_id.Name = "fees_id"
        Me.fees_id.ReadOnly = True
        Me.fees_id.Visible = False
        '
        'fees_name
        '
        Me.fees_name.DataPropertyName = "fees_name"
        Me.fees_name.HeaderText = "Fees Type"
        Me.fees_name.Name = "fees_name"
        Me.fees_name.ReadOnly = True
        '
        'fees_amount
        '
        Me.fees_amount.DataPropertyName = "fees_amount"
        Me.fees_amount.HeaderText = "Fees Amount"
        Me.fees_amount.Name = "fees_amount"
        Me.fees_amount.ReadOnly = True
        '
        'rpu_id
        '
        Me.rpu_id.DataPropertyName = "tuition_rpu_id"
        Me.rpu_id.HeaderText = "Rate_per_unit"
        Me.rpu_id.Name = "rpu_id"
        Me.rpu_id.ReadOnly = True
        Me.rpu_id.Visible = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cbo_SortCrs)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.cbo_SortYL)
        Me.GroupBox4.Controls.Add(Me.cbo_SortSem)
        Me.GroupBox4.Controls.Add(Me.cbo_SortSY)
        Me.GroupBox4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(609, 118)
        Me.GroupBox4.TabIndex = 57
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SORT BY"
        '
        'cbo_SortCrs
        '
        Me.cbo_SortCrs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SortCrs.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SortCrs.FormattingEnabled = True
        Me.cbo_SortCrs.Location = New System.Drawing.Point(371, 68)
        Me.cbo_SortCrs.Name = "cbo_SortCrs"
        Me.cbo_SortCrs.Size = New System.Drawing.Size(218, 24)
        Me.cbo_SortCrs.TabIndex = 34
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(313, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 20)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "COURSE"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(24, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 20)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Y/L"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(313, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "SEM"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 26)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(30, 20)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "S/Y"
        '
        'cbo_SortYL
        '
        Me.cbo_SortYL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SortYL.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SortYL.FormattingEnabled = True
        Me.cbo_SortYL.Location = New System.Drawing.Point(80, 68)
        Me.cbo_SortYL.Name = "cbo_SortYL"
        Me.cbo_SortYL.Size = New System.Drawing.Size(218, 24)
        Me.cbo_SortYL.TabIndex = 11
        '
        'cbo_SortSem
        '
        Me.cbo_SortSem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SortSem.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SortSem.FormattingEnabled = True
        Me.cbo_SortSem.Location = New System.Drawing.Point(371, 26)
        Me.cbo_SortSem.Name = "cbo_SortSem"
        Me.cbo_SortSem.Size = New System.Drawing.Size(218, 24)
        Me.cbo_SortSem.TabIndex = 11
        '
        'cbo_SortSY
        '
        Me.cbo_SortSY.DisplayMember = "sy_id"
        Me.cbo_SortSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_SortSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_SortSY.FormattingEnabled = True
        Me.cbo_SortSY.Location = New System.Drawing.Point(80, 26)
        Me.cbo_SortSY.Name = "cbo_SortSY"
        Me.cbo_SortSY.Size = New System.Drawing.Size(218, 24)
        Me.cbo_SortSY.TabIndex = 11
        Me.cbo_SortSY.ValueMember = "sy_id"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel4.Controls.Add(Me.btn_cancel)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.cbo_yl)
        Me.Panel4.Controls.Add(Me.checkb_tuitionfee_indicator)
        Me.Panel4.Controls.Add(Me.cbo_MSY)
        Me.Panel4.Controls.Add(Me.txtb_collAmnt)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.btn_save)
        Me.Panel4.Controls.Add(Me.txtb_CollName)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.btn_update)
        Me.Panel4.Controls.Add(Me.cbo_MS)
        Me.Panel4.Controls.Add(Me.cbo_course)
        Me.Panel4.Controls.Add(Me.btn_add)
        Me.Panel4.Location = New System.Drawing.Point(25, 90)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(356, 479)
        Me.Panel4.TabIndex = 56
        '
        'btn_cancel
        '
        Me.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_cancel.Location = New System.Drawing.Point(69, 346)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancel.selected = False
        Me.btn_cancel.Size = New System.Drawing.Size(84, 29)
        Me.btn_cancel.TabIndex = 58
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_cancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(105, 262)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(193, 21)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "CHECK IF TUITION FEE IN UNITS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "SCHOOL YEAR"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(24, 194)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "NAME"
        '
        'cbo_yl
        '
        Me.cbo_yl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_yl.Enabled = False
        Me.cbo_yl.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_yl.FormattingEnabled = True
        Me.cbo_yl.Location = New System.Drawing.Point(123, 83)
        Me.cbo_yl.Name = "cbo_yl"
        Me.cbo_yl.Size = New System.Drawing.Size(217, 29)
        Me.cbo_yl.TabIndex = 20
        '
        'checkb_tuitionfee_indicator
        '
        Me.checkb_tuitionfee_indicator.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.checkb_tuitionfee_indicator.ChechedOffColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.checkb_tuitionfee_indicator.Checked = False
        Me.checkb_tuitionfee_indicator.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(205, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.checkb_tuitionfee_indicator.ForeColor = System.Drawing.Color.White
        Me.checkb_tuitionfee_indicator.Location = New System.Drawing.Point(79, 262)
        Me.checkb_tuitionfee_indicator.Name = "checkb_tuitionfee_indicator"
        Me.checkb_tuitionfee_indicator.Size = New System.Drawing.Size(20, 20)
        Me.checkb_tuitionfee_indicator.TabIndex = 56
        '
        'cbo_MSY
        '
        Me.cbo_MSY.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_MSY.Enabled = False
        Me.cbo_MSY.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_MSY.FormattingEnabled = True
        Me.cbo_MSY.Location = New System.Drawing.Point(123, 11)
        Me.cbo_MSY.Name = "cbo_MSY"
        Me.cbo_MSY.Size = New System.Drawing.Size(217, 29)
        Me.cbo_MSY.TabIndex = 25
        '
        'txtb_collAmnt
        '
        Me.txtb_collAmnt.Enabled = False
        Me.txtb_collAmnt.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_collAmnt.Location = New System.Drawing.Point(87, 229)
        Me.txtb_collAmnt.Name = "txtb_collAmnt"
        Me.txtb_collAmnt.Size = New System.Drawing.Size(253, 26)
        Me.txtb_collAmnt.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "SEMESTER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "AMOUNT"
        '
        'btn_save
        '
        Me.btn_save.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_save.Location = New System.Drawing.Point(199, 346)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(84, 29)
        Me.btn_save.TabIndex = 53
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_save.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtb_CollName
        '
        Me.txtb_CollName.Enabled = False
        Me.txtb_CollName.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_CollName.Location = New System.Drawing.Point(87, 191)
        Me.txtb_CollName.Name = "txtb_CollName"
        Me.txtb_CollName.Size = New System.Drawing.Size(253, 26)
        Me.txtb_CollName.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "COURSE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "YEAR LVL"
        '
        'btn_update
        '
        Me.btn_update.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_update.Location = New System.Drawing.Point(199, 307)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(84, 29)
        Me.btn_update.TabIndex = 55
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_update.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_update.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cbo_MS
        '
        Me.cbo_MS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_MS.Enabled = False
        Me.cbo_MS.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_MS.FormattingEnabled = True
        Me.cbo_MS.Location = New System.Drawing.Point(123, 47)
        Me.cbo_MS.Name = "cbo_MS"
        Me.cbo_MS.Size = New System.Drawing.Size(217, 29)
        Me.cbo_MS.TabIndex = 29
        '
        'cbo_course
        '
        Me.cbo_course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbo_course.Enabled = False
        Me.cbo_course.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_course.FormattingEnabled = True
        Me.cbo_course.Location = New System.Drawing.Point(123, 119)
        Me.cbo_course.Name = "cbo_course"
        Me.cbo_course.Size = New System.Drawing.Size(217, 29)
        Me.cbo_course.TabIndex = 21
        '
        'btn_add
        '
        Me.btn_add.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
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
        Me.btn_add.Location = New System.Drawing.Point(69, 307)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_add.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_add.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_add.selected = False
        Me.btn_add.Size = New System.Drawing.Size(84, 29)
        Me.btn_add.TabIndex = 54
        Me.btn_add.Text = "ADD"
        Me.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_add.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_add.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.elem_dept)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1075, 718)
        Me.TabControl1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "sfees_id"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fees ID"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "sfees_name"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fees Type"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "sfees_amount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fees Amount"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'frm_Mpayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_Mpayments"
        Me.Size = New System.Drawing.Size(1075, 718)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        CType(Me.dg_jFeesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.dg_sfeesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.elem_dept.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dg_eFeesRec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dg_pRecords, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Panel8 As Panel
    Friend WithEvents dg_jFeesRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label29 As Label
    Friend WithEvents cbo_jSortSY As ComboBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents btn_jCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents cbo_jSY As ComboBox
    Friend WithEvents txtb_jFeesAmnt As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btn_jSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtb_jFeesName As TextBox
    Friend WithEvents btn_jUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_jAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel6 As Panel
    Friend WithEvents dg_sfeesRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cbo_sSortSY As ComboBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label16 As Label
    Friend WithEvents cbo_sSY As ComboBox
    Friend WithEvents btn_sCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label24 As Label
    Friend WithEvents txtb_sFeeAmnt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents btn_sSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtb_sfeeName As TextBox
    Friend WithEvents btn_sUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_sAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents elem_dept As TabPage
    Friend WithEvents Panel3 As Panel
    Friend WithEvents dg_eFeesRec As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbo_eSortSy As ComboBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btn_eCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cbo_eSY As ComboBox
    Friend WithEvents txtb_eFeeAmnt As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents btn_eSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtb_eFeeName As TextBox
    Friend WithEvents btn_eUpdate As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_eAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents dg_pRecords As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents fees_id As DataGridViewTextBoxColumn
    Friend WithEvents fees_name As DataGridViewTextBoxColumn
    Friend WithEvents fees_amount As DataGridViewTextBoxColumn
    Friend WithEvents rpu_id As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents cbo_SortCrs As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbo_SortYL As ComboBox
    Friend WithEvents cbo_SortSem As ComboBox
    Friend WithEvents cbo_SortSY As ComboBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label14 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbo_yl As ComboBox
    Friend WithEvents checkb_tuitionfee_indicator As Bunifu.Framework.UI.BunifuCheckbox
    Friend WithEvents cbo_MSY As ComboBox
    Friend WithEvents txtb_collAmnt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtb_CollName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_update As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbo_MS As ComboBox
    Friend WithEvents cbo_course As ComboBox
    Friend WithEvents btn_add As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
