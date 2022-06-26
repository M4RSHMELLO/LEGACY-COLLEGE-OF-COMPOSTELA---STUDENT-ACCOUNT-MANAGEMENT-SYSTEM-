<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class proceespayment
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
        Me.btn_PrintCreceipts = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'btn_PrintCreceipts
        '
        Me.btn_PrintCreceipts.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_PrintCreceipts.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_PrintCreceipts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_PrintCreceipts.BorderRadius = 0
        Me.btn_PrintCreceipts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_PrintCreceipts.ButtonText = "CANCEL"
        Me.btn_PrintCreceipts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_PrintCreceipts.DisabledColor = System.Drawing.Color.Gray
        Me.btn_PrintCreceipts.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_PrintCreceipts.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_PrintCreceipts.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_PrintCreceipts.Iconimage = Nothing
        Me.btn_PrintCreceipts.Iconimage_right = Nothing
        Me.btn_PrintCreceipts.Iconimage_right_Selected = Nothing
        Me.btn_PrintCreceipts.Iconimage_Selected = Nothing
        Me.btn_PrintCreceipts.IconMarginLeft = 0
        Me.btn_PrintCreceipts.IconMarginRight = 0
        Me.btn_PrintCreceipts.IconRightVisible = False
        Me.btn_PrintCreceipts.IconRightZoom = 0R
        Me.btn_PrintCreceipts.IconVisible = False
        Me.btn_PrintCreceipts.IconZoom = 90.0R
        Me.btn_PrintCreceipts.IsTab = False
        Me.btn_PrintCreceipts.Location = New System.Drawing.Point(249, 529)
        Me.btn_PrintCreceipts.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_PrintCreceipts.Name = "btn_PrintCreceipts"
        Me.btn_PrintCreceipts.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_PrintCreceipts.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_PrintCreceipts.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_PrintCreceipts.selected = False
        Me.btn_PrintCreceipts.Size = New System.Drawing.Size(136, 35)
        Me.btn_PrintCreceipts.TabIndex = 58
        Me.btn_PrintCreceipts.Text = "CANCEL"
        Me.btn_PrintCreceipts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_PrintCreceipts.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_PrintCreceipts.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.btn_save.Location = New System.Drawing.Point(404, 529)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(136, 35)
        Me.btn_save.TabIndex = 57
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_save.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Location = New System.Drawing.Point(2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(538, 520)
        Me.Panel1.TabIndex = 59
        '
        'proceespayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 578)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_PrintCreceipts)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "proceespayment"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_PrintCreceipts As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
End Class
