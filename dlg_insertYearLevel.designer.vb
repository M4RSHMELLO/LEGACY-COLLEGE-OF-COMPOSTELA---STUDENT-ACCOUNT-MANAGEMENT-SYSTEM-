<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_insertYearLevel
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
        Me.txtb_yearlevel = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg_addsdnt_yes = New System.Windows.Forms.Button()
        Me.dlg_addsdnt_no = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtb_yearlevel
        '
        Me.txtb_yearlevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtb_yearlevel.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtb_yearlevel.Location = New System.Drawing.Point(63, 79)
        Me.txtb_yearlevel.MaxLength = 100
        Me.txtb_yearlevel.Name = "txtb_yearlevel"
        Me.txtb_yearlevel.Size = New System.Drawing.Size(312, 38)
        Me.txtb_yearlevel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 38)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INSERT NEW YEAR LEVEL"
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
        Me.dlg_addsdnt_yes.Location = New System.Drawing.Point(114, 142)
        Me.dlg_addsdnt_yes.Name = "dlg_addsdnt_yes"
        Me.dlg_addsdnt_yes.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_yes.TabIndex = 34
        Me.dlg_addsdnt_yes.Text = "SAVE"
        Me.dlg_addsdnt_yes.UseVisualStyleBackColor = False
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
        Me.dlg_addsdnt_no.Location = New System.Drawing.Point(227, 142)
        Me.dlg_addsdnt_no.Name = "dlg_addsdnt_no"
        Me.dlg_addsdnt_no.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_no.TabIndex = 35
        Me.dlg_addsdnt_no.Text = "CANCEL"
        Me.dlg_addsdnt_no.UseVisualStyleBackColor = False
        '
        'dlg_insertYearLevel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.dlg_addsdnt_no)
        Me.Controls.Add(Me.dlg_addsdnt_yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtb_yearlevel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_insertYearLevel"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "dlg_insertYearLevel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtb_yearlevel As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dlg_addsdnt_yes As System.Windows.Forms.Button
    Friend WithEvents dlg_addsdnt_no As System.Windows.Forms.Button

End Class
