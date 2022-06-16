<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScholarshipDetails
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
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtb_sType = New System.Windows.Forms.TextBox()
        Me.dg_scholarTypeList = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_update = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_new = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_cancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.rbtn_active = New System.Windows.Forms.RadioButton()
        Me.rbtn_inactive = New System.Windows.Forms.RadioButton()
        Me.btn_close = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dg_scholarTypeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(22, 52)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(151, 21)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "SCHOLARSHIP TYPE"
        '
        'txtb_sType
        '
        Me.txtb_sType.Enabled = False
        Me.txtb_sType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_sType.Location = New System.Drawing.Point(179, 49)
        Me.txtb_sType.Name = "txtb_sType"
        Me.txtb_sType.Size = New System.Drawing.Size(247, 26)
        Me.txtb_sType.TabIndex = 17
        '
        'dg_scholarTypeList
        '
        Me.dg_scholarTypeList.AllowUserToAddRows = False
        Me.dg_scholarTypeList.AllowUserToDeleteRows = False
        Me.dg_scholarTypeList.AllowUserToResizeColumns = False
        Me.dg_scholarTypeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_scholarTypeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_scholarTypeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dg_scholarTypeList.Location = New System.Drawing.Point(117, 177)
        Me.dg_scholarTypeList.Name = "dg_scholarTypeList"
        Me.dg_scholarTypeList.RowHeadersVisible = False
        Me.dg_scholarTypeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dg_scholarTypeList.Size = New System.Drawing.Size(326, 150)
        Me.dg_scholarTypeList.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtn_inactive)
        Me.Panel1.Controls.Add(Me.rbtn_active)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.btn_new)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.btn_cancel)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.txtb_sType)
        Me.Panel1.Location = New System.Drawing.Point(56, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(449, 159)
        Me.Panel1.TabIndex = 19
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
        Me.btn_update.Location = New System.Drawing.Point(147, 125)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_update.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_update.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_update.selected = False
        Me.btn_update.Size = New System.Drawing.Size(68, 29)
        Me.btn_update.TabIndex = 59
        Me.btn_update.Text = "UPDATE"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_update.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_update.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_new
        '
        Me.btn_new.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_new.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_new.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_new.BorderRadius = 0
        Me.btn_new.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_new.ButtonText = "NEW"
        Me.btn_new.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_new.DisabledColor = System.Drawing.Color.Gray
        Me.btn_new.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_new.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_new.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_new.Iconimage = Nothing
        Me.btn_new.Iconimage_right = Nothing
        Me.btn_new.Iconimage_right_Selected = Nothing
        Me.btn_new.Iconimage_Selected = Nothing
        Me.btn_new.IconMarginLeft = 0
        Me.btn_new.IconMarginRight = 0
        Me.btn_new.IconRightVisible = False
        Me.btn_new.IconRightZoom = 0R
        Me.btn_new.IconVisible = False
        Me.btn_new.IconZoom = 90.0R
        Me.btn_new.IsTab = False
        Me.btn_new.Location = New System.Drawing.Point(73, 125)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_new.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_new.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_new.selected = False
        Me.btn_new.Size = New System.Drawing.Size(68, 29)
        Me.btn_new.TabIndex = 58
        Me.btn_new.Text = "NEW"
        Me.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_new.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_new.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_save.Location = New System.Drawing.Point(234, 125)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(68, 29)
        Me.btn_save.TabIndex = 58
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_save.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_cancel.Location = New System.Drawing.Point(308, 125)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_cancel.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_cancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_cancel.selected = False
        Me.btn_cancel.Size = New System.Drawing.Size(68, 29)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "CANCEL"
        Me.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_cancel.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_cancel.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'rbtn_active
        '
        Me.rbtn_active.AutoSize = True
        Me.rbtn_active.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_active.Location = New System.Drawing.Point(217, 81)
        Me.rbtn_active.Name = "rbtn_active"
        Me.rbtn_active.Size = New System.Drawing.Size(72, 25)
        Me.rbtn_active.TabIndex = 60
        Me.rbtn_active.TabStop = True
        Me.rbtn_active.Text = "Active"
        Me.rbtn_active.UseVisualStyleBackColor = True
        '
        'rbtn_inactive
        '
        Me.rbtn_inactive.AutoSize = True
        Me.rbtn_inactive.Font = New System.Drawing.Font("Franklin Gothic Demi", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtn_inactive.Location = New System.Drawing.Point(308, 81)
        Me.rbtn_inactive.Name = "rbtn_inactive"
        Me.rbtn_inactive.Size = New System.Drawing.Size(85, 25)
        Me.rbtn_inactive.TabIndex = 61
        Me.rbtn_inactive.TabStop = True
        Me.rbtn_inactive.Text = "Inactive"
        Me.rbtn_inactive.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_close.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.BorderRadius = 0
        Me.btn_close.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_close.ButtonText = "CLOSE"
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.DisabledColor = System.Drawing.Color.Gray
        Me.btn_close.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_close.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_close.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_close.Iconimage = Nothing
        Me.btn_close.Iconimage_right = Nothing
        Me.btn_close.Iconimage_right_Selected = Nothing
        Me.btn_close.Iconimage_Selected = Nothing
        Me.btn_close.IconMarginLeft = 0
        Me.btn_close.IconMarginRight = 0
        Me.btn_close.IconRightVisible = False
        Me.btn_close.IconRightZoom = 0R
        Me.btn_close.IconVisible = False
        Me.btn_close.IconZoom = 90.0R
        Me.btn_close.IsTab = False
        Me.btn_close.Location = New System.Drawing.Point(480, 329)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_close.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_close.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_close.selected = False
        Me.btn_close.Size = New System.Drawing.Size(68, 29)
        Me.btn_close.TabIndex = 62
        Me.btn_close.Text = "CLOSE"
        Me.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_close.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_close.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "scholar_id"
        Me.Column1.HeaderText = "sid"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "scholar_name"
        Me.Column2.HeaderText = "Scholar Type"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "scholar_status"
        Me.Column3.HeaderText = "status"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'ScholarshipDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 372)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dg_scholarTypeList)
        Me.Name = "ScholarshipDetails"
        Me.Text = "ScholarshipDetails"
        CType(Me.dg_scholarTypeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label16 As Label
    Friend WithEvents txtb_sType As TextBox
    Friend WithEvents dg_scholarTypeList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_new As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_cancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_update As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents rbtn_inactive As RadioButton
    Friend WithEvents rbtn_active As RadioButton
    Friend WithEvents btn_close As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
