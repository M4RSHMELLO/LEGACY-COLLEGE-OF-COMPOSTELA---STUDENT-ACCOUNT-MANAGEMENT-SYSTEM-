Public Class loginSuccessfully
    Private Sub OK_Button_Click(sender As Object, e As EventArgs) Handles OK_Button.Click
        Try
            Dashboard.Show()
            Dashboard.lbl_usertype.Text = "Welcome, " & user_type & "!"
            If user_type = "STAFF" Then
                Dashboard.btn_manageP.Visible = False
                Dashboard.btn_colRprt.Visible = False
                Dashboard.btn_dropmenu2.Visible = False
                Dashboard.btn_menuMSY.Visible = False
                Dashboard.btn_menuMU.Visible = False
                Dashboard.btn_menuMP.Visible = False
                Dashboard.BunifuGradientPanel1.GradientBottomRight = Color.Chartreuse
                Dashboard.BunifuGradientPanel1.GradientTopRight = Color.Chartreuse
                Dashboard.BunifuGradientPanel4.GradientTopRight = Color.Chartreuse
                Dashboard.BunifuGradientPanel4.GradientTopRight = Color.Chartreuse
                Dashboard.TableLayoutPanel1.BackColor = Color.Chartreuse
            ElseIf user_type = "ADMIN" Then
                Dashboard.btn_manageP.Visible = True
                Dashboard.btn_colRprt.Visible = True
                Dashboard.btn_dropmenu2.Visible = True
                Dashboard.btn_menuMSY.Visible = True
                Dashboard.btn_menuMU.Visible = True
                Dashboard.btn_menuMP.Visible = True
                Dashboard.BunifuGradientPanel1.GradientBottomRight = Color.DarkGreen
                Dashboard.BunifuGradientPanel1.GradientTopRight = Color.DarkGreen
                Dashboard.BunifuGradientPanel4.GradientTopRight = Color.DarkGreen
                Dashboard.BunifuGradientPanel4.GradientTopRight = Color.DarkGreen
                Dashboard.TableLayoutPanel1.BackColor = Color.DarkGreen
            End If
            form_login.Hide()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
