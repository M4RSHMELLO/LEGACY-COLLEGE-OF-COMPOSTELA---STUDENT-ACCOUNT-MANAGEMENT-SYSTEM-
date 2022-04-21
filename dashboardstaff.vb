Public Class Dashboard
    Dim frm_sP As New frm_SPayments
    Dim frm_sA As New frm_SAccounts
    Dim frm_sL As New frm_sLists
    Dim frm_sTR As New frm_sTransactionR
    Dim frm_mY As New frm_MYear
    Dim frm_mP As New frm_Mpayments
    Dim frm_U As New frm_user
    Dim frm_sSg As New frm_sSG


    Public Sub addContent(frm As UserControl, btn As Object)

        Try
            pnlMContainer.Controls.Clear()
            pnl_subcontainer.Controls.Clear()
            Dim f As UserControl = New UserControl()
            Dim g As UserControl = New UserControl()
            f = frm
            g = frm
            f.Dock = DockStyle.Fill
            g.Dock = DockStyle.Fill
            pnl_subcontainer.Controls.Add(g)
            pnlMContainer.Controls.Add(f)
            lbl_title.Text = btn.Text
            lbl_title.Text = btn.Text

            'My.Settings.addtoform()
            ' f.Visible = False
            ' animation.ShowSync(f)


        Catch ex As Exception

        End Try

    End Sub
    Public Sub addsContent(frm As UserControl, btn As Object)

        Try
            ' pnlMContainer.Visible = False
            pnl_subcontainer.Controls.Clear()

            Dim g As UserControl = New UserControl()
            g = frm
            '  g.Dock = DockStyle.Fill
            pnl_subcontainer.Controls.Add(g)
            lbl_title.Text = btn.Text

            'My.Settings.addtoform()
            ' f.Visible = False
            ' animation.ShowSync(f)


        Catch ex As Exception

        End Try

    End Sub





    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click


    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        addContent(frm_sP, BunifuFlatButton1)

    End Sub

    Private Sub BunifuFlatButton6_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton6.Click
        addContent(frm_sL, BunifuFlatButton6)
    End Sub
    Private Sub BunifuFlatButton9_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton9.Click
        addContent(frm_sA, BunifuFlatButton9)
    End Sub

    Private Sub btn_sTransactionR_Click(sender As Object, e As EventArgs) Handles btn_sTransactionR.Click
        addContent(frm_sTR, btn_sTransactionR)
    End Sub

    Private Sub BunifuFlatButton8_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton8.Click
        addsContent(frm_mY, BunifuFlatButton8)
    End Sub

    Private Sub BunifuFlatButton5_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton5.Click
        addsContent(frm_mP, BunifuFlatButton5)

    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        addContent(frm_U, BunifuFlatButton3)
    End Sub

    Private Sub BunifuFlatButton4_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton4.Click
        addContent(frm_sSg, BunifuFlatButton4)
    End Sub
End Class