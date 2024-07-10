Imports System.Data.OleDb
Public Class Form_saisi_produit
    Dim hn As OleDb.OleDbDataReader
    Private Sub Form_saisi_produit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Zone_liste Catégorie

        l_ctg.Items.Add("Matériel Informatique")
        l_ctg.Items.Add("Matériel Bureautique")
        l_ctg.Items.Add("Autre")

        'zone_liste Rechercher

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select Réference from produit", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_rech.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()

    End Sub

    'Button Ajouter

    Private Sub B_aj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_aj.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("insert into Produit values('" & z_ref.Text & "','" & z_des.Text & "','" & l_ctg.Text & "','" & z_pu.Text & "','" & z_qt.Text & "')", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_des.Clear()
        z_ref.Clear()
        z_pu.Clear()
        z_qt.Clear()
        l_ctg.Text = ""
        Dim cmd1 As New OleDb.OleDbCommand("select Réference from produit", ft)
        hn = cmd1.ExecuteReader
        While hn.Read()
            l_rech.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()
    End Sub

    'Button Supprimer

    Private Sub B_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_sup.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("delete from produit where Réference='" & z_ref.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous supprimmer le Produit " & z_des.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader
            z_ref.Text.Remove(Val(z_ref.Text))
            MsgBox("la suppression  de Produit" & z_des.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")
            z_des.Clear()
            z_ref.Clear()
            z_pu.Clear()
            z_qt.Clear()
            l_ctg.Text = ""
        Else
            MsgBox("la suppression de Produit" & z_des.Text & "est annulée", MsgBoxStyle.Information, "information")
        End If

        hn.Close()
        ft.Close()

    End Sub

    'Button Modifier

    Private Sub B_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_mod.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("update Produit set Réference ='" & z_ref.Text & "', Désignation='" & z_des.Text & "',[Type Produit]='" & l_ctg.Text & "',[Prix Unitaire]='" & z_pu.Text & "',Quantité='" & z_qt.Text & "' where Réference='" & z_ref.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous modifier les données du Produit " & z_des.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader

            MsgBox("la modification  de Produit" & z_des.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")

        Else
            MsgBox("la modification de Produit" & z_des.Text & "est annulée", MsgBoxStyle.Information, "information")
        End If

        hn.Close()
        ft.Close()

    End Sub

    'Button Annuler

    Private Sub B_anl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_anl.Click
        z_ref.Clear()
        z_des.Clear()
        l_ctg.Text = ""
        z_pu.Clear()
        z_qt.Clear()

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
        Dim d As New Form_mn_Prod
        Dim q As New Form_List_Produit
        Select Case a
            Case "b2"
                addf(d)
            Case "b1"
                addf(q)
        End Select
    End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b2")
        End If


    End Sub

    'Button Lister

    Private Sub B_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_list.Click
        'Form_List_Produit.Show()
        change_menu("b1")
    End Sub

    'change de Rechercher

    Private Sub l_rech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_rech.SelectedIndexChanged
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from produit where Réference='" & l_rech.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_ref.Text = hn(0)
        z_des.Text = hn(1)
        l_ctg.Text = hn(2)
        z_pu.Text = hn(3)
        z_qt.Text = hn(4)
        hn.Close()
        ft.Close()

    End Sub
End Class