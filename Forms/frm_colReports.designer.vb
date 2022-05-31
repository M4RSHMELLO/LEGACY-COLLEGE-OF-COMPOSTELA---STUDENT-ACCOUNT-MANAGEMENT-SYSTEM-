<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_colReports
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_seniordept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_juniordept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_elemdept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btn_collDept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtb_totalFeesAmount = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer2 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_seniordept)
        Me.Panel1.Controls.Add(Me.btn_juniordept)
        Me.Panel1.Controls.Add(Me.btn_elemdept)
        Me.Panel1.Controls.Add(Me.btn_collDept)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 85)
        Me.Panel1.TabIndex = 0
        '
        'btn_seniordept
        '
        Me.btn_seniordept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_seniordept.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_seniordept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_seniordept.BorderRadius = 0
        Me.btn_seniordept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_seniordept.ButtonText = "Senior-High Dept"
        Me.btn_seniordept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_seniordept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_seniordept.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_seniordept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_seniordept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_seniordept.Iconimage = Nothing
        Me.btn_seniordept.Iconimage_right = Nothing
        Me.btn_seniordept.Iconimage_right_Selected = Nothing
        Me.btn_seniordept.Iconimage_Selected = Nothing
        Me.btn_seniordept.IconMarginLeft = 0
        Me.btn_seniordept.IconMarginRight = 0
        Me.btn_seniordept.IconRightVisible = False
        Me.btn_seniordept.IconRightZoom = 0R
        Me.btn_seniordept.IconVisible = False
        Me.btn_seniordept.IconZoom = 90.0R
        Me.btn_seniordept.IsTab = False
        Me.btn_seniordept.Location = New System.Drawing.Point(885, 24)
        Me.btn_seniordept.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_seniordept.Name = "btn_seniordept"
        Me.btn_seniordept.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_seniordept.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_seniordept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_seniordept.selected = False
        Me.btn_seniordept.Size = New System.Drawing.Size(158, 33)
        Me.btn_seniordept.TabIndex = 53
        Me.btn_seniordept.Text = "Senior-High Dept"
        Me.btn_seniordept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_seniordept.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_seniordept.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_juniordept
        '
        Me.btn_juniordept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_juniordept.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_juniordept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_juniordept.BorderRadius = 0
        Me.btn_juniordept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_juniordept.ButtonText = "Junior-High Dept"
        Me.btn_juniordept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_juniordept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_juniordept.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_juniordept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_juniordept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_juniordept.Iconimage = Nothing
        Me.btn_juniordept.Iconimage_right = Nothing
        Me.btn_juniordept.Iconimage_right_Selected = Nothing
        Me.btn_juniordept.Iconimage_Selected = Nothing
        Me.btn_juniordept.IconMarginLeft = 0
        Me.btn_juniordept.IconMarginRight = 0
        Me.btn_juniordept.IconRightVisible = False
        Me.btn_juniordept.IconRightZoom = 0R
        Me.btn_juniordept.IconVisible = False
        Me.btn_juniordept.IconZoom = 90.0R
        Me.btn_juniordept.IsTab = False
        Me.btn_juniordept.Location = New System.Drawing.Point(720, 24)
        Me.btn_juniordept.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_juniordept.Name = "btn_juniordept"
        Me.btn_juniordept.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_juniordept.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_juniordept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_juniordept.selected = False
        Me.btn_juniordept.Size = New System.Drawing.Size(158, 33)
        Me.btn_juniordept.TabIndex = 53
        Me.btn_juniordept.Text = "Junior-High Dept"
        Me.btn_juniordept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_juniordept.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_juniordept.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_elemdept
        '
        Me.btn_elemdept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_elemdept.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_elemdept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_elemdept.BorderRadius = 0
        Me.btn_elemdept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_elemdept.ButtonText = "Elementary Dept"
        Me.btn_elemdept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_elemdept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_elemdept.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_elemdept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_elemdept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_elemdept.Iconimage = Nothing
        Me.btn_elemdept.Iconimage_right = Nothing
        Me.btn_elemdept.Iconimage_right_Selected = Nothing
        Me.btn_elemdept.Iconimage_Selected = Nothing
        Me.btn_elemdept.IconMarginLeft = 0
        Me.btn_elemdept.IconMarginRight = 0
        Me.btn_elemdept.IconRightVisible = False
        Me.btn_elemdept.IconRightZoom = 0R
        Me.btn_elemdept.IconVisible = False
        Me.btn_elemdept.IconZoom = 90.0R
        Me.btn_elemdept.IsTab = False
        Me.btn_elemdept.Location = New System.Drawing.Point(552, 24)
        Me.btn_elemdept.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_elemdept.Name = "btn_elemdept"
        Me.btn_elemdept.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_elemdept.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_elemdept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_elemdept.selected = False
        Me.btn_elemdept.Size = New System.Drawing.Size(158, 33)
        Me.btn_elemdept.TabIndex = 53
        Me.btn_elemdept.Text = "Elementary Dept"
        Me.btn_elemdept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_elemdept.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_elemdept.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btn_collDept
        '
        Me.btn_collDept.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btn_collDept.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_collDept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_collDept.BorderRadius = 0
        Me.btn_collDept.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btn_collDept.ButtonText = "College Dept"
        Me.btn_collDept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_collDept.DisabledColor = System.Drawing.Color.Gray
        Me.btn_collDept.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!)
        Me.btn_collDept.ForeColor = System.Drawing.Color.SeaGreen
        Me.btn_collDept.Iconcolor = System.Drawing.Color.Transparent
        Me.btn_collDept.Iconimage = Nothing
        Me.btn_collDept.Iconimage_right = Nothing
        Me.btn_collDept.Iconimage_right_Selected = Nothing
        Me.btn_collDept.Iconimage_Selected = Nothing
        Me.btn_collDept.IconMarginLeft = 0
        Me.btn_collDept.IconMarginRight = 0
        Me.btn_collDept.IconRightVisible = False
        Me.btn_collDept.IconRightZoom = 0R
        Me.btn_collDept.IconVisible = False
        Me.btn_collDept.IconZoom = 90.0R
        Me.btn_collDept.IsTab = False
        Me.btn_collDept.Location = New System.Drawing.Point(384, 24)
        Me.btn_collDept.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
        Me.btn_collDept.Name = "btn_collDept"
        Me.btn_collDept.Normalcolor = System.Drawing.SystemColors.ButtonFace
        Me.btn_collDept.OnHovercolor = System.Drawing.Color.Goldenrod
        Me.btn_collDept.OnHoverTextColor = System.Drawing.Color.White
        Me.btn_collDept.selected = False
        Me.btn_collDept.Size = New System.Drawing.Size(158, 33)
        Me.btn_collDept.TabIndex = 53
        Me.btn_collDept.Text = "College Dept"
        Me.btn_collDept.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btn_collDept.Textcolor = System.Drawing.Color.SeaGreen
        Me.btn_collDept.TextFont = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 17.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label8.Location = New System.Drawing.Point(16, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 29)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "SELECT REPORTS"
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DAILY", "WEEKLY"})
        Me.ComboBox1.Location = New System.Drawing.Point(217, 24)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 33)
        Me.ComboBox1.TabIndex = 26
        '
        'txtb_totalFeesAmount
        '
        Me.txtb_totalFeesAmount.BackColor = System.Drawing.Color.White
        Me.txtb_totalFeesAmount.Enabled = False
        Me.txtb_totalFeesAmount.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_totalFeesAmount.Location = New System.Drawing.Point(837, 758)
        Me.txtb_totalFeesAmount.Name = "txtb_totalFeesAmount"
        Me.txtb_totalFeesAmount.Size = New System.Drawing.Size(155, 26)
        Me.txtb_totalFeesAmount.TabIndex = 23
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label16.Location = New System.Drawing.Point(721, 761)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 21)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "TOTAL AMOUNT"
        '
        'CrystalReportViewer2
        '
        Me.CrystalReportViewer2.ActiveViewIndex = -1
        Me.CrystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer2.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer2.Location = New System.Drawing.Point(0, 85)
        Me.CrystalReportViewer2.Name = "CrystalReportViewer2"
        Me.CrystalReportViewer2.Size = New System.Drawing.Size(1154, 579)
        Me.CrystalReportViewer2.TabIndex = 24
        Me.CrystalReportViewer2.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'frm_colReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.CrystalReportViewer2)
        Me.Controls.Add(Me.txtb_totalFeesAmount)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frm_colReports"
        Me.Size = New System.Drawing.Size(1154, 664)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btn_seniordept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_juniordept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_elemdept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btn_collDept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtb_totalFeesAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReportViewer2 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
