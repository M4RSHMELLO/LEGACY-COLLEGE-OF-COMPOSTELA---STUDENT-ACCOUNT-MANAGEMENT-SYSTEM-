<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_inputGradeLevel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg_addgl_no = New System.Windows.Forms.Button()
        Me.dlg_addgl_yes = New System.Windows.Forms.Button()
        Me.txtb_gradelevel = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(337, 38)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "INSERT NEW GRADE LEVEL"
        '
        'dlg_addgl_no
        '
        Me.dlg_addgl_no.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dlg_addgl_no.BackColor = System.Drawing.Color.ForestGreen
        Me.dlg_addgl_no.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.dlg_addgl_no.FlatAppearance.BorderSize = 0
        Me.dlg_addgl_no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addgl_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addgl_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dlg_addgl_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg_addgl_no.Location = New System.Drawing.Point(227, 130)
        Me.dlg_addgl_no.Name = "dlg_addgl_no"
        Me.dlg_addgl_no.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addgl_no.TabIndex = 40
        Me.dlg_addgl_no.Text = "CANCEL"
        Me.dlg_addgl_no.UseVisualStyleBackColor = False
        '
        'dlg_addgl_yes
        '
        Me.dlg_addgl_yes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dlg_addgl_yes.BackColor = System.Drawing.Color.ForestGreen
        Me.dlg_addgl_yes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.dlg_addgl_yes.FlatAppearance.BorderSize = 0
        Me.dlg_addgl_yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addgl_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addgl_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dlg_addgl_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg_addgl_yes.Location = New System.Drawing.Point(114, 130)
        Me.dlg_addgl_yes.Name = "dlg_addgl_yes"
        Me.dlg_addgl_yes.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addgl_yes.TabIndex = 39
        Me.dlg_addgl_yes.Text = "SAVE"
        Me.dlg_addgl_yes.UseVisualStyleBackColor = False
        '
        'txtb_gradelevel
        '
        Me.txtb_gradelevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtb_gradelevel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_gradelevel.Location = New System.Drawing.Point(63, 67)
        Me.txtb_gradelevel.MaxLength = 100
        Me.txtb_gradelevel.Name = "txtb_gradelevel"
        Me.txtb_gradelevel.Size = New System.Drawing.Size(312, 38)
        Me.txtb_gradelevel.TabIndex = 38
        '
        'dlg_inputGradeLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.dlg_addgl_no)
        Me.Controls.Add(Me.dlg_addgl_yes)
        Me.Controls.Add(Me.txtb_gradelevel)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_inputGradeLevel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlg_inputGradeLevel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dlg_addgl_no As Button
    Friend WithEvents dlg_addgl_yes As Button
    Friend WithEvents txtb_gradelevel As TextBox
End Class
