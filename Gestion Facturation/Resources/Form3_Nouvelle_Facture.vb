Imports System.Data.OleDb
Public Class Form3_nouvl_Facture
    Dim hn As OleDb.OleDbDataReader

    Private Sub Form3_nouvl_Facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        z_dat.Text = Today
        'Liste CIN

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select cdclt from client", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_cin.Items.Add(hn(0))
        End While

        'Liste Catégorie
        l_ctg.Items.Add("Matériel Informatique")
        l_ctg.Items.Add("Matériel Bureautique")
        l_ctg.Items.Add("Autre")


        'Liste mode Paiement
        l_mp.Items.Add("Espèce")
        l_mp.Items.Add("Chèque")
        l_mp.Items.Add("Carte Bancaire")
        l_mp.Items.Add("Virement Bancaire")

        'Nombre Max Facture
        Dim cmd2 As New OleDb.OleDbCommand("select * from Req_NFact_Max", ft)
        Dim nbr As Integer
        hn = cmd2.ExecuteReader
        hn.Read()
        nbr = hn(0) + 1
        z_nfct.Text = "Fct" & Str(nbr)
        hn.Close()
        ft.Close()

    End Sub
    'Change CIN

    Private Sub l_cin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_cin.SelectedIndexChanged
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select nmpr,Adresse  from client where cdclt='" & l_cin.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_np.Text = hn(0)
        z_ad.Text = hn(1)
        hn.Close()
        ft.Close()
    End Sub

    'Liste Réference
    Private Sub l_ref_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_ref.SelectedIndexChanged
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select Désignation,[Prix Unitaire],Quantité  from produit where Réference='" & l_ref.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_des.Text = hn(0)
        z_pu.Text = hn(1)
        z_qsk.Text = hn(2)
        hn.Close()
        ft.Close()
    End Sub

    'Button Fermer
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b2")
        End If
    End Sub

    'Button Annuler 
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
    Private Sub B_af_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_af.Click
        z_ad.Clear()
        l_cin.Text = ""
        z_nfct.Clear()
        z_np.Clear()
        l_ctg.Text = ""
        l_ref.Text = ""
        l_mp.Text = ""
        z_av.Text = 0
        z_tot.Clear()
        z_pu.Clear()
        z_rst.Text = 0
        z_tva.Clear()
        z_tcc.Text = 0
        z_ntc.Clear()
        z_rm.Clear()
        z_qtv.Clear()
        z_des.Clear()
        grid.Rows.Clear()

    End Sub

    'Button d'Option
    
    Private Sub z_av_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles z_av.TextChanged
        z_rst.Text = Val(z_tcc.Text) - Val(z_av.Text)
        If z_rst.Text < 0 Then
            MsgBox("L'avance obtenue est supérieure que le montant que doit payer!!!", vbOK + MsgBoxStyle.Exclamation, "Attention")
        ElseIf z_rst.Text = 0 Then
            R_ok.Checked = True
        Else
            R_no.Checked = True
        End If
    End Sub

    'Button OK
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer, j As Integer, tot As Single, n As Integer, s As Integer
        If l_ctg.Text = "" Or l_ref.Text = "" Or z_des.Text = "" Or z_pu.Text = "" Or z_qtv.Text = "" Then
            MsgBox("Il doit remplir tous les champs", vbOK + MsgBoxStyle.Exclamation, "Attention")
        Else
            ft.Open()
            z_qsk.Text = Val(z_qsk.Text) - Val(z_qtv.Text)
            Dim cmd As New OleDb.OleDbCommand("update Produit set Quantité='" & z_qsk.Text & "'where Réference='" & l_ref.Text & "'", ft)
            hn = cmd.ExecuteReader
            n = grid.Rows.Add()
            grid.Rows(n).Cells(0).Value = Me.l_ctg.Text
            grid.Rows(n).Cells(1).Value = Me.l_ref.Text
            grid.Rows(n).Cells(2).Value = Me.z_des.Text
            grid.Rows(n).Cells(3).Value = Me.z_pu.Text
            grid.Rows(n).Cells(4).Value = Me.z_qtv.Text
            tot = Val(Me.z_pu.Text) * Val(Me.z_qtv.Text)
            grid.Rows(n).Cells(5).Value = tot
            s = 0

            For i = 0 To grid.RowCount - 2
                s = s + grid.Rows(n).Cells(5).Value
            Next
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
            Dim nc As Single, tva As Single
            z_ntc.Text = z_tot.Text - z_rm.Text
            z_tva.Text = z_ntc.Text * 0.2
            nc = z_ntc.Text
            tva = z_tva.Text
            z_tcc.Text = nc + tva
        End If
        'z_qsk.Text = Val(z_qsk.Text) - (z_qtv.Text)
        hn.Close()
        ft.Close()
    End Sub

    'Nouvelle Facture

    Private Sub B_nf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_nf.Click
        z_ad.Clear()
        l_cin.Text = ""
        z_nfct.Clear()
        z_np.Clear()
        l_ctg.Text = ""
        l_ref.Text = ""
        l_mp.Text = ""
        z_av.Clear()
        z_tot.Clear()
        z_pu.Clear()
        z_rst.Clear()
        z_tva.Clear()
        z_tcc.Clear()
        z_ntc.Clear()
        z_rm.Clear()
        z_qtv.Clear()
        z_des.Clear()
        grid.Rows.Clear()
        ft.Open()
        Dim cmd2 As New OleDb.OleDbCommand("select * from Req_NFact_Max", ft)
        hn = cmd2.ExecuteReader
        hn.Read()
        z_nfct.Text = "Fct" & " " & hn(0) + 1
        hn.Close()
        ft.Close()


    End Sub

    'Button enregistrer

    Private Sub B_ef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ef.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("insert into Facture values('" & z_nfct.Text & "','" & z_dat.Text & "','" & z_tcc.Text & "','" & l_cin.Text & "')", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous Enregistrer les données du client" & z_np.Text & "?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader
            hn.Read()
            For i = 0 To grid.RowCount - 2
                Dim cmd1 As New OleDb.OleDbCommand("insert into détailFacture values('" & z_nfct.Text & "','" & l_ref.Text & "','" & z_qtv.Text & "')", ft)
                hn = cmd1.ExecuteReader
                hn.Read()
            Next
            hn.Close()
            ft.Close()
            ft.Open()
            Dim cmd2 As New OleDb.OleDbCommand("insert into Réglement values('" & z_dat.Text & "','" & z_av.Text & "','" & l_mp.Text & "','" & z_nfct.Text & "')", ft)
            hn = cmd2.ExecuteReader
            hn.Read()
            MsgBox("l'enregistrement du client" & z_np.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")
        Else
            MsgBox("l'enregistrement du client" & z_np.Text & "est annulée", MsgBoxStyle.Information, "information")
        End If
        hn.Close()
        ft.Close()
    End Sub

    Private Sub z_qtv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles z_qtv.TextChanged
        'ft.Open()
        'Dim cmd2 As New OleDb.OleDbCommand("select Quantité from Produit", ft)
        'hn = cmd2.ExecuteReader
        'While hn.Read()
        If Val(z_qsk.Text) < Val(z_qtv.Text) Then
            MsgBox("La quantité à commander n'est pas disponible!! Elle y a que " & z_qsk.Text & "piéces dans le stock", vbOK + MsgBoxStyle.Exclamation, "Attention")

        End If

        'End While
        'hn.Close()
        'ft.Close()
    End Sub

    Private Sub l_ctg_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_ctg.SelectedIndexChanged

        'Liste Réference
        ft.Open()
        Dim cmd1 As New OleDb.OleDbCommand("select  Réference from  produit where [type produit]='" & l_ctg.Text & "'", ft)
        hn = cmd1.ExecuteReader
        While hn.Read()
            l_ref.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()
    End Sub

   
End Class