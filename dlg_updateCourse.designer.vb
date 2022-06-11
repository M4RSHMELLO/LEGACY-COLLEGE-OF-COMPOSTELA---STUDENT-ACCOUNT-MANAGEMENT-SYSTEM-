<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_updateCourse
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
        Me.dlg_addsdnt_no = New System.Windows.Forms.Button()
        Me.dlg_addsdnt_yes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtb_uCourse = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dlg_addsdnt_no
        '
        Me.dlg_addsdnt_no.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dlg_addsdnt_no.BackColor = System.Drawing.Color.ForestGreen
        Me.dlg_addsdnt_no.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.dlg_addsdnt_no.FlatAppearance.BorderSize = 0
        Me.dlg_addsdnt_no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addsdnt_no.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addsdnt_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dlg_addsdnt_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg_addsdnt_no.Location = New System.Drawing.Point(227, 141)
        Me.dlg_addsdnt_no.Name = "dlg_addsdnt_no"
        Me.dlg_addsdnt_no.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_no.TabIndex = 43
        Me.dlg_addsdnt_no.Text = "CANCEL"
        Me.dlg_addsdnt_no.UseVisualStyleBackColor = False
        '
        'dlg_addsdnt_yes
        '
        Me.dlg_addsdnt_yes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dlg_addsdnt_yes.BackColor = System.Drawing.Color.ForestGreen
        Me.dlg_addsdnt_yes.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.dlg_addsdnt_yes.FlatAppearance.BorderSize = 0
        Me.dlg_addsdnt_yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addsdnt_yes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.dlg_addsdnt_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dlg_addsdnt_yes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dlg_addsdnt_yes.Location = New System.Drawing.Point(114, 141)
        Me.dlg_addsdnt_yes.Name = "dlg_addsdnt_yes"
        Me.dlg_addsdnt_yes.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_yes.TabIndex = 42
        Me.dlg_addsdnt_yes.Text = "SAVE"
        Me.dlg_addsdnt_yes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 38)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "UPDATE COURSE"
        '
        'txtb_uCourse
        '
        Me.txtb_uCourse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtb_uCourse.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_uCourse.Location = New System.Drawing.Point(63, 78)
        Me.txtb_uCourse.MaxLength = 100
        Me.txtb_uCourse.Name = "txtb_uCourse"
        Me.txtb_uCourse.Size = New System.Drawing.Size(312, 38)
        Me.txtb_uCourse.TabIndex = 40
        '
        'dlg_updateCourse
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.dlg_addsdnt_no)
        Me.Controls.Add(Me.dlg_addsdnt_yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtb_uCourse)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_updateCourse"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlg_addsdnt_no As System.Windows.Forms.Button
    Friend WithEvents dlg_addsdnt_yes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtb_uCourse As System.Windows.Forms.TextBox

End Class
