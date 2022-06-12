<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_studAcct
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
        Me.btn_save = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.TXTB_BAL = New System.Windows.Forms.TextBox()
        Me.TXTB_aMOUNT = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
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
        Me.btn_save.Location = New System.Drawing.Point(255, 268)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_save.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_save.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_save.selected = False
        Me.btn_save.Size = New System.Drawing.Size(136, 40)
        Me.btn_save.TabIndex = 55
        Me.btn_save.Text = "SAVE"
        Me.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_save.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_save.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.BunifuFlatButton1.ButtonText = "CANCEL"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.BunifuFlatButton1.ForeColor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = False
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = False
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(97, 268)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(136, 40)
        Me.BunifuFlatButton1.TabIndex = 56
        Me.BunifuFlatButton1.Text = "CANCEL"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.SeaGreen
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'TXTB_BAL
        '
        Me.TXTB_BAL.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!)
        Me.TXTB_BAL.Location = New System.Drawing.Point(175, 194)
        Me.TXTB_BAL.Name = "TXTB_BAL"
        Me.TXTB_BAL.ReadOnly = True
        Me.TXTB_BAL.Size = New System.Drawing.Size(193, 38)
        Me.TXTB_BAL.TabIndex = 57
        Me.TXTB_BAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTB_aMOUNT
        '
        Me.TXTB_aMOUNT.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!)
        Me.TXTB_aMOUNT.Location = New System.Drawing.Point(175, 150)
        Me.TXTB_aMOUNT.Name = "TXTB_aMOUNT"
        Me.TXTB_aMOUNT.Size = New System.Drawing.Size(193, 38)
        Me.TXTB_aMOUNT.TabIndex = 58
        Me.TXTB_aMOUNT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label29.Location = New System.Drawing.Point(73, 160)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(90, 25)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "AMOUNT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Demi", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(73, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 25)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "BALANCE"
        '
        'update_studAcct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 335)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TXTB_aMOUNT)
        Me.Controls.Add(Me.TXTB_BAL)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.btn_save)
        Me.Font = New System.Drawing.Font("Franklin Gothic Demi", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "update_studAcct"
        Me.Text = "update_studAcct"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents TXTB_BAL As TextBox
    Friend WithEvents TXTB_aMOUNT As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Label1 As Label
End Class
