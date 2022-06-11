<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlg_scholarship_update
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
        Me.dlg_addsdnt_yes = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dlg_addsdnt_no = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.dlg_addsdnt_yes.Location = New System.Drawing.Point(220, 132)
        Me.dlg_addsdnt_yes.Name = "dlg_addsdnt_yes"
        Me.dlg_addsdnt_yes.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_yes.TabIndex = 38
        Me.dlg_addsdnt_yes.Text = "YES"
        Me.dlg_addsdnt_yes.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(261, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = " A SCHOLARSHIP?"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium Cond", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(228, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "DO YOU WANT TO  UPDATE"
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
        Me.dlg_addsdnt_no.Location = New System.Drawing.Point(330, 132)
        Me.dlg_addsdnt_no.Name = "dlg_addsdnt_no"
        Me.dlg_addsdnt_no.Size = New System.Drawing.Size(97, 37)
        Me.dlg_addsdnt_no.TabIndex = 35
        Me.dlg_addsdnt_no.Text = "NO"
        Me.dlg_addsdnt_no.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LCC_SAMS_Project.My.Resources.Resources.scholarship_update_icon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 178)
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'dlg_scholarship_update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 202)
        Me.Controls.Add(Me.dlg_addsdnt_yes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dlg_addsdnt_no)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlg_scholarship_update"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dlg_addsdnt_yes As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dlg_addsdnt_no As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
