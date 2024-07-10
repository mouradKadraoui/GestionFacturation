Imports System.Data.OleDb

Public Class Form4_Consult_Fct_Numr
    Dim hn As OleDb.OleDbDataReader
    Private Sub Form4_Consult_Fct_Numr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'liste Facture

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select numéro from facture", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_nfct.Items.Add(hn(0))
        End While
       
        hn.Close()
        ft.Close()
    End Sub

  
    Private Sub l_nfct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_nfct.SelectedIndexChanged

        'Remlir les zones textes

        Dim i As Integer, j As Integer, ava As Single
        ft.Open()
        Dim cmd1 As New OleDb.OleDbCommand("select [date facture],cdclt  from facture  where numéro='" & l_nfct.Text & "'", ft)
        hn = cmd1.ExecuteReader
        hn.Read()
        z_dtf.Text = hn(0)
        z_cin.Text = hn(1)
        Dim cmd2 As New OleDb.OleDbCommand("select nmpr  from client where cdclt='" & z_cin.Text & "'", ft)
        Dim s As Single
        hn = cmd2.ExecuteReader
        hn.Read()
        z_np.Text = hn(0)

        Dim cmd4 As New OleDb.OleDbCommand("select [type Réglement],avance from Réglement where numéro='" & l_nfct.Text & "'", ft)
        hn = cmd4.ExecuteReader
        While hn.Read()
            ava = ava + hn(1)
        End While

        'z_mp.Text = hn(0)
        z_av.Text = ava

        'Remplir la Grille

        'Dim cmd3 As New OleDbCommand("select  [type Produit],Produit.Réference,Designation,[Prix Unitaire],[Quantité Vendue]  from Produit, DétailFacture where Produit.Réference=DétailFacture.Réference and Numéro='" & l_nfct.Text & "'", ft)
        Dim cmd3 As New OleDbCommand("select *  from reqdetfact where  Numéro='" & l_nfct.Text & "'", ft)
        hn = cmd3.ExecuteReader
        grid.Rows.Clear()
        i = 0
        While hn.Read
            grid.Rows.Add()
            For j = 0 To 4
                grid.Rows(i).Cells(j).Value = hn(j)
            Next
            grid.Rows(i).Cells(5).Value = hn(3) * hn(4)
            i = i + 1
        End While
        grid.Rows(i).Cells(5).Value = tot
        s = 0

        For i = 0 To grid.RowCount - 2
            s = s + grid.Rows(i).Cells(5).Value
        Next

        'Remise

        z_tot.Text = s
        If z_tot.Text < 1500 Then
            z_rm.Text = 0
        ElseIf z_tot.Text < 3000 Then
            z_rm.Text = z_tot.Text * 0.05
        ElseIf z_tot.Text < 7000 Then
            z_rm.Text = z_tot.Text * 0.1
        Else
            z_rm.Text = z_tot.Text * 0.15
        End If

        'Remplir les zones de calcule

        Dim nc As Single, tva As Single
        z_ntc.Text = z_tot.Text - z_rm.Text
        z_tva.Text = z_ntc.Text * 0.2
        nc = z_ntc.Text
        tva = z_tva.Text
        z_tcc.Text = nc + tva

        'Button d'option

        z_rst.Text = Val(z_tcc.Text) - Val(z_av.Text)
        If z_rst.Text < 0 Then
            MsgBox("L'avance obtenue est supérieure que le montant que doit payer!!!", vbOK + MsgBoxStyle.Exclamation, "Attention")
        ElseIf z_rst.Text = 0 Then
            R_ok.Checked = True
        Else
            R_no.Checked = True
        End If
        hn.Close()
        ft.Close()
    End Sub

    'Button Fermer
    Private Sub addf(ByVal x As Form)
        Try
            Form_Menu.Pac.Controls.Clear()
            x.TopLevel = False
            x.TopMost = True
            x.Dock = DockStyle.Fill
            Form_Menu.Pac.Controls.Add(x)
            x.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub change_menu(ByVal a As String)
        Dim d As New Form_mn_fact
        Select Case a
            Case "b2"
                addf(d)
        End Select
    End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b2")
        End If
    End Sub

    'Button Mise à Jour

    Private Sub B_maj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_maj.Click
        'If ft.State = ConnectionState.Closed Then ft.Open()
        'Dim cmd As New OleDb.OleDbCommand("update Réglement set Montant='" & z_av.Text & "' where Numéro='" & l_nfct.Text & "'", ft)
        'Dim rep As String
        'rep = MsgBox("voulez-vous modifier les données du Facture N° " & l_nfct.Text & " du client" & z_np.Text & "?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        'If rep = vbYes Then
        '    hn = cmd.ExecuteReader
        '    hn.Read()
        '    MsgBox("la modification  du Facture N° " & l_nfct.Text & " du client" & z_np.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")

        'Else
        '    MsgBox("la modification du Facture N° " & l_nfct.Text & " du client" & z_np.Text & "est annulée", MsgBoxStyle.Information, "information")
        'End If

        hn.Close()
        ft.Close()
    End Sub

    Private Sub z_av_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles z_av.TextChanged
        'Button d'option

        'z_rst.Text = Val(z_tcc.Text) - Val(z_av.Text)
        'If z_rst.Text < 0 Then
        '    MsgBox("L'avance obtenue est supérieure que le montant que doit payer!!!", vbOK + MsgBoxStyle.Exclamation, "Attention")
        'ElseIf z_rst.Text = 0 Then
        '    R_ok.Checked = True
        'Else
        '    R_no.Checked = True
        'End If
    End Sub

    Private Sub cmdmodifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdmodifier.Click
        Form_avance.Show()
        Form_avance.z_nf.Text = l_nfct.Text
    End Sub

    Private Sub grid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid.CellContentClick

    End Sub
End Class