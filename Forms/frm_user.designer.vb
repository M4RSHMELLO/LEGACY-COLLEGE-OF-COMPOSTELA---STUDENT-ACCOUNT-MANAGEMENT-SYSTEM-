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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtb_name = New System.Windows.Forms.TextBox()
        Me.txtb_Uname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_usertype = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtb_pass = New System.Windows.Forms.TextBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dg_users = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.M = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.ForestGreen
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(359, 474)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(81, 42)
        Me.btnSave.TabIndex = 57
        Me.btnSave.Text = "ADD"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Location = New System.Drawing.Point(285, 22)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(0, 20)
        Me.lblId.TabIndex = 15
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
        Me.GroupBox1.Location = New System.Drawing.Point(219, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(462, 174)
        Me.GroupBox1.TabIndex = 54
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
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.ForestGreen
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_update.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(460, 474)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 42)
        Me.btn_update.TabIndex = 58
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'dg_users
        '
        Me.dg_users.AllowUserToAddRows = False
        Me.dg_users.AllowUserToDeleteRows = False
        Me.dg_users.AllowUserToResizeColumns = False
        Me.dg_users.AllowUserToResizeRows = False
        Me.dg_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.Column1, Me.M, Me.Column2, Me.user_type})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dg_users.DefaultCellStyle = DataGridViewCellStyle2
        Me.dg_users.Location = New System.Drawing.Point(219, 283)
        Me.dg_users.MultiSelect = False
        Me.dg_users.Name = "dg_users"
        Me.dg_users.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_users.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_users.RowHeadersVisible = False
        Me.dg_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_users.Size = New System.Drawing.Size(462, 150)
        Me.dg_users.TabIndex = 59
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
        'frm_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.dg_users)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_user"
        Me.Size = New System.Drawing.Size(900, 570)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtb_name As System.Windows.Forms.TextBox
    Friend WithEvents txtb_Uname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents dg_users As System.Windows.Forms.DataGridView
    Friend WithEvents txtb_pass As System.Windows.Forms.TextBox
    Friend WithEvents cbo_usertype As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents M As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents user_type As DataGridViewTextBoxColumn
End Class
