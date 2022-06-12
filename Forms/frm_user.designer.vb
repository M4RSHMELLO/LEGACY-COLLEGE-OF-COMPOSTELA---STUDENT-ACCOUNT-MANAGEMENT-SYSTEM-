<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_user
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dg_users = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_usertype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb_pass = New System.Windows.Forms.TextBox()
        Me.txtb_name = New System.Windows.Forms.TextBox()
        Me.txtb_Uname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.btn_BACKUP = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_restore = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(900, 570)
        Me.TabControl1.TabIndex = 60
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.dg_users)
        Me.TabPage1.Controls.Add(Me.btn_update)
        Me.TabPage1.Controls.Add(Me.btnSave)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(892, 544)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "MANAGE USER"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(892, 544)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "BACKUP DATA"
        '
        'dg_users
        '
        Me.dg_users.AllowUserToAddRows = False
        Me.dg_users.AllowUserToDeleteRows = False
        Me.dg_users.AllowUserToResizeColumns = False
        Me.dg_users.AllowUserToResizeRows = False
        Me.dg_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column1, Me.M, Me.Column2, Me.user_type})
        Me.dg_users.Location = New System.Drawing.Point(215, 255)
        Me.dg_users.MultiSelect = False
        Me.dg_users.Name = "dg_users"
        Me.dg_users.ReadOnly = True
        Me.dg_users.RowHeadersVisible = False
        Me.dg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_users.Size = New System.Drawing.Size(462, 150)
        Me.dg_users.TabIndex = 63
        '
        'id
        '
        Me.id.DataPropertyName = "user_id"
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "Name"
        Me.Column1.HeaderText = "NAME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'M
        '
        Me.M.DataPropertyName = "username"
        Me.M.HeaderText = "USERNAME"
        Me.M.Name = "M"
        Me.M.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "password"
        Me.Column2.HeaderText = "PASSWORD"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'user_type
        '
        Me.user_type.DataPropertyName = "user_type"
        Me.user_type.HeaderText = "USER TYPE"
        Me.user_type.Name = "user_type"
        Me.user_type.ReadOnly = True
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(456, 446)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 42)
        Me.btn_update.TabIndex = 62
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(355, 446)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 42)
        Me.btnSave.TabIndex = 61
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGreen
        Me.GroupBox1.Controls.Add(Me.cbo_usertype)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtb_pass)
        Me.GroupBox1.Controls.Add(Me.txtb_name)
        Me.GroupBox1.Controls.Add(Me.txtb_Uname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblId)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(215, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 174)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "USER DETAILS"
        '
        'cbo_usertype
        '
        Me.cbo_usertype.Enabled = False
        Me.cbo_usertype.FormattingEnabled = True
        Me.cbo_usertype.Items.AddRange(New Object() {"ADMIN", "STAFF"})
        Me.cbo_usertype.Location = New System.Drawing.Point(140, 127)
        Me.cbo_usertype.Name = "cbo_usertype"
        Me.cbo_usertype.Size = New System.Drawing.Size(287, 28)
        Me.cbo_usertype.TabIndex = 18
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 20)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "USER TYPE:"
        '
        'txtb_pass
        '
        Me.txtb_pass.Enabled = False
        Me.txtb_pass.Location = New System.Drawing.Point(140, 94)
        Me.txtb_pass.Name = "txtb_pass"
        Me.txtb_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtb_pass.Size = New System.Drawing.Size(287, 26)
        Me.txtb_pass.TabIndex = 16
        Me.txtb_pass.UseSystemPasswordChar = True
        '
        'txtb_name
        '
        Me.txtb_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtb_name.Enabled = False
        Me.txtb_name.Location = New System.Drawing.Point(140, 25)
        Me.txtb_name.Name = "txtb_name"
        Me.txtb_name.Size = New System.Drawing.Size(287, 26)
        Me.txtb_name.TabIndex = 2
        '
        'txtb_Uname
        '
        Me.txtb_Uname.Enabled = False
        Me.txtb_Uname.Location = New System.Drawing.Point(140, 60)
        Me.txtb_Uname.Name = "txtb_Uname"
        Me.txtb_Uname.Size = New System.Drawing.Size(287, 26)
        Me.txtb_Uname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PASSWORD:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FULL NAME:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "USERNAME:"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(285, 22)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 20)
        Me.lblId.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_restore)
        Me.Panel1.Controls.Add(Me.btn_BACKUP)
        Me.Panel1.Controls.Add(Me.Label29)
        Me.Panel1.Location = New System.Drawing.Point(151, 178)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(591, 188)
        Me.Panel1.TabIndex = 0
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Franklin Gothic Demi", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(58, 15)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(474, 30)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "BACKUP AND RESTORE LCCSAMS RECORD"
        '
        'btn_BACKUP
        '
        Me.btn_BACKUP.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_BACKUP.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_BACKUP.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_BACKUP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_BACKUP.BorderRadius = 0
        Me.btn_BACKUP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_BACKUP.ButtonText = "BACKUP"
        Me.btn_BACKUP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_BACKUP.DisabledColor = System.Drawing.Color.Gray
        Me.btn_BACKUP.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_BACKUP.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_BACKUP.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_BACKUP.Iconimage = Nothing
        Me.btn_BACKUP.Iconimage_right = Nothing
        Me.btn_BACKUP.Iconimage_right_Selected = Nothing
        Me.btn_BACKUP.Iconimage_Selected = Nothing
        Me.btn_BACKUP.IconMarginLeft = 0
        Me.btn_BACKUP.IconMarginRight = 0
        Me.btn_BACKUP.IconRightVisible = False
        Me.btn_BACKUP.IconRightZoom = 0R
        Me.btn_BACKUP.IconVisible = False
        Me.btn_BACKUP.IconZoom = 90.0R
        Me.btn_BACKUP.IsTab = False
        Me.btn_BACKUP.Location = New System.Drawing.Point(156, 77)
        Me.btn_BACKUP.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_BACKUP.Name = "btn_BACKUP"
        Me.btn_BACKUP.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_BACKUP.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_BACKUP.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_BACKUP.selected = False
        Me.btn_BACKUP.Size = New System.Drawing.Size(136, 35)
        Me.btn_BACKUP.TabIndex = 53
        Me.btn_BACKUP.Text = "BACKUP"
        Me.btn_BACKUP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_BACKUP.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_BACKUP.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_restore
        '
        Me.btn_restore.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_restore.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_restore.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_restore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_restore.BorderRadius = 0
        Me.btn_restore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_restore.ButtonText = "RESTORE"
        Me.btn_restore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_restore.DisabledColor = System.Drawing.Color.Gray
        Me.btn_restore.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_restore.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_restore.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_restore.Iconimage = Nothing
        Me.btn_restore.Iconimage_right = Nothing
        Me.btn_restore.Iconimage_right_Selected = Nothing
        Me.btn_restore.Iconimage_Selected = Nothing
        Me.btn_restore.IconMarginLeft = 0
        Me.btn_restore.IconMarginRight = 0
        Me.btn_restore.IconRightVisible = False
        Me.btn_restore.IconRightZoom = 0R
        Me.btn_restore.IconVisible = False
        Me.btn_restore.IconZoom = 90.0R
        Me.btn_restore.IsTab = False
        Me.btn_restore.Location = New System.Drawing.Point(298, 77)
        Me.btn_restore.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_restore.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_restore.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_restore.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_restore.selected = False
        Me.btn_restore.Size = New System.Drawing.Size(136, 35)
        Me.btn_restore.TabIndex = 54
        Me.btn_restore.Text = "RESTORE"
        Me.btn_restore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_restore.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_restore.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_user"
        Me.Size = New System.Drawing.Size(900, 570)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dg_users As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents M As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents user_type As DataGridViewTextBoxColumn
    Friend WithEvents btn_update As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbo_usertype As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtb_pass As TextBox
    Friend WithEvents txtb_name As TextBox
    Friend WithEvents txtb_Uname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblId As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents btn_restore As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_BACKUP As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
