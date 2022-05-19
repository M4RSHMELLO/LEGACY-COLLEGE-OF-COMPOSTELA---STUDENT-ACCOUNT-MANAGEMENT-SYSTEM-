Public Class Dashboard
    Dim frm_sP As New frm_SPayments
    Dim frm_sA As New frm_SAccounts
    Dim frm_sL As New frm_slists
    Dim frm_sTR As New frm_colReports
    Dim frm_mY As New frm_MSY
    Dim frm_mP As New frm_Mpayments
    Dim frm_U As New frm_user
    Dim frm_sSg As New frm_sSG
    Dim isCollapsed As Boolean = True
    Dim isCollapsed2 As Boolean = True

    Public Sub addContent(frm As UserControl, btn As Object)
        Try
            pnlMContainer.Controls.Clear()
            Dim f As UserControl = New UserControl()
            f = frm
            f.Dock = DockStyle.Fill
            pnlMContainer.Controls.Add(f)
            lbl_title.Text = btn.Text
        Catch ex As Exception
            erromessage(ex.Message)
        End Try
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btn_manageP.Click
        addContent(frm_sP, btn_manageP)

    End Sub

    Public Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles btn_menuStudentsList.Click
        addContent(frm_sL, btn_menuStudentsList)

    End Sub
    Public studIdClick As Integer

    Sub selected_menu(tabCTRL As TabControl)
        studIdClick = tabCTRL.SelectedIndex
        Select Case tabCTRL.SelectedIndex
            Case 0
                frm_sA.TabControl1.SelectedIndex = 0
            Case 1
                frm_sA.TabControl1.SelectedIndex = 1
            Case 2
                frm_sA.TabControl1.SelectedIndex = 2
            Case 3
                frm_sA.TabControl1.SelectedIndex = 3
            Case Else
        End Select
    End Sub
    Public Sub btn_menuStudentsAccount_click(sender As Object, e As EventArgs) Handles btn_menuStudentsAccount.Click
        Try
            Select Case current_menu
                Case 1
                    addContent(frm_sA, btn_menuStudentsAccount)
                    selected_menu(frm_sP.TabControl1)
                    Select Case studIdClick
                        Case 0
                            frm_sA.txtb_studAcct_ID_Click(sender, e)
                        Case 1
                            frm_sA.txtb_eStud_id_Click(sender, e)
                        Case 2
                            frm_sA.txtb_sStud_id_Click(sender, e)
                        Case 3
                            frm_sA.txtb_jStud_id_Click(sender, e)


                        Case Else
                            MessageBox.Show("")
                    End Select

                Case 2
                    addContent(frm_sA, btn_menuStudentsAccount)
                    selected_menu(frm_sL.TabControl1)
                    Select Case studIdClick
                        Case 0
                            frm_sA.txtb_studAcct_ID_Click(sender, e)
                        Case 1
                            frm_sA.txtb_eStud_id_Click(sender, e)
                        Case 2
                            frm_sA.txtb_sStud_id_Click(sender, e)
                        Case 3
                            frm_sA.txtb_jStud_ID_Click(sender, e)

                        Case Else
                            MessageBox.Show("")
                    End Select
                Case Else
                    MessageBox.Show("Please select a student first")
            End Select


        Catch ex As Exception

        End Try

    End Sub

    Private Sub btn_sTransactionR_Click(sender As Object, e As EventArgs) Handles btn_colRprt.Click
        addContent(frm_sTR, btn_colRprt)
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles btn_menuMP.Click
        addContent(frm_mP, btn_menuMP)
        frm_mP.frm_Mpayments_Load(sender, e)

    End Sub
    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles btn_menuMSY.Click
        addContent(frm_mY, btn_menuMSY)
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles btn_menuMU.Click
        addContent(frm_U, btn_menuMU)
    End Sub
    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        addContent(frm_sSg, BunifuFlatButton4)
    End Sub
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        dlg_logout.ShowDialog()
        If dlg_logout.DialogResult = DialogResult.Yes Then
            Try
                pnlMContainer.Controls.Clear()
                pnlMContainer.Controls.Add(PictureBox2)
                pnlMContainer.Controls.Add(Label4)
                Label4.BringToFront()
                pnlMContainer.Controls.Add(Label3)
                Panel3.Size = Panel3.MinimumSize
                Panel2.Size = Panel2.MinimumSize
                Me.Hide()
                form_login.Show()
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isCollapsed Then
            ' btn_dropmenu1.Image 
            Panel3.Height += 10
            If Panel3.Size.Height = Panel3.MaximumSize.Height Then
                Timer1.Stop()
                isCollapsed = False
            End If
        Else
            '  DropButton1.Image = My.Resources.Arrow_Left
            Panel3.Height -= 10
            If Panel3.Size.Height = Panel3.MinimumSize.Height Then
                Timer1.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel3.Size = Panel3.MinimumSize
        Panel2.Size = Panel2.MinimumSize
    End Sub
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles btn_dropmenu1.Click
        isCollapsed2 = False
        Timer1.Start()
        Timer2.Start()
    End Sub
    Private Sub btn_dropmenu2_Click(sender As Object, e As EventArgs) Handles btn_dropmenu2.Click
        isCollapsed = False
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If isCollapsed2 Then
            ' btn_dropmenu1.Image 
            Panel2.Height += 10
            If Panel2.Size.Height = Panel2.MaximumSize.Height Then
                Timer2.Stop()
                isCollapsed2 = False
            End If
        Else
            '  DropButton1.Image = My.Resources.Arrow_Left
            Panel2.Height -= 10
            If Panel2.Size.Height = Panel2.MinimumSize.Height Then
                Timer2.Stop()
                isCollapsed2 = True
            End If
        End If
    End Sub


End Class