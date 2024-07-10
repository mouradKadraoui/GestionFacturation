Public Class Form_Menu

    Private Sub addf(ByVal x As Form)
        Try
            pac.Controls.Clear()
            x.TopLevel = False
            x.TopMost = True
            x.Dock = DockStyle.Fill
            pac.Controls.Add(x)
            x.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub change_menu(ByVal a As String)
        Dim d As New Formmen_clt
        Dim c As New Form_mn_fact
        Dim h As New Form_mn_Prod
        Dim i As New Form_py_imp
        Dim o As New Form_fornss
        Dim y As New Form_page_de_garde
        Select Case a
            Case "b2"
                addf(d)
            Case "b1"
                addf(h)
            Case "b3"
                addf(c)
            Case "b4"
                addf(i)
            Case "b5"
                addf(o)
            Case "b6"
                addf(y)
        End Select
    End Sub




    Private Sub Client_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Client.Click
        change_menu("b2")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))


    End Sub

    Private Sub Produit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Produit.Click
        change_menu("b1")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))

    End Sub

    Private Sub Facture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Facture.Click
        change_menu("b3")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))

    End Sub



    Private Sub Etat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Etat.Click
        change_menu("b4")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim rep As String
        rep = MsgBox("voulez-vous quitter l'application", vbYesNo + MsgBoxStyle.Information, "information")
        If rep = vbYes Then
            Me.Close()
            ActiveButton(sender, Color.FromArgb(0, 0, 64))

        End If
    End Sub

    Private Sub Fournisseur_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Fournisseur.Click
        change_menu("b5")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))

    End Sub

    Private Sub Acceuil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Acceuil.Click
        change_menu("b6")
        ActiveButton(sender, Color.FromArgb(0, 0, 64))
    End Sub
    Private currentBtn As Button
    Private Sub ActiveButton(ByVal senderBtn As Object, ByVal customColor As Color)
        If senderBtn IsNot Nothing Then
            DisableButton()
            currentBtn = CType(senderBtn, Button)
            currentBtn.BackColor = Color.FromArgb(0, 0, 64)
            currentBtn.ForeColor = Color.White
            'currentBtn.IconColor = Color.White
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(6, 82, 221)
            currentBtn.ForeColor = Color.Black
            'currentBtn.IconColor = Color.White
        End If
    End Sub

    Private Sub Pac_Paint(sender As Object, e As PaintEventArgs) Handles Pac.Paint

    End Sub
End Class