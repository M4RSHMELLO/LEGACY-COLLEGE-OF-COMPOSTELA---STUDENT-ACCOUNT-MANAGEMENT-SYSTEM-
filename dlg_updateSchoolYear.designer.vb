<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_updateSchoolYear
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dlg_addsdnt_yes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(176, 141)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 37)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "CANCEL"
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.dlg_addsdnt_yes.Location = New System.Drawing.Point(63, 141)
        Me.dlg_addsdnt_yes.Name = "dlg_addsdnt_yes"
        Me.dlg_addsdnt_yes.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_yes.TabIndex = 46
        Me.dlg_addsdnt_yes.Text = "SAVE"
        Me.dlg_addsdnt_yes.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 24.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 38)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "UPDATE SCHOOL YEAR"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(63, 78)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(312, 47)
        Me.TextBox1.TabIndex = 44
        '
        'dlg_updateSchoolYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dlg_addsdnt_yes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_updateSchoolYear"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dlg_addsdnt_yes As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
