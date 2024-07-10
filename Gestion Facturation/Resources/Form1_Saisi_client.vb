
Imports System.Data.OleDb
Public Class Form_Saisi_Client
    Dim hn As OleDb.OleDbDataReader


    Private Sub Form_Saisi_Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Zone_liste Profession

        l_prf.Items.Add("Ingénieur")
        l_prf.Items.Add("Architecte")
        l_prf.Items.Add("Technicien")
        l_prf.Items.Add("Technicien spécialisé")
        l_prf.Items.Add("Professeur")
        l_prf.Items.Add("Retraité")
        l_prf.Items.Add("Comptable")

        'zone_liste Rechercher

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select cdclt from client", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_rech.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()

    End Sub
   

    'change de Rechercher


    Private Sub l_rech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_rech.SelectedIndexChanged
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from client where cdclt='" & l_rech.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_cin.Text = hn(0)
        z_np.Text = hn(1)
        l_prf.Text = hn(2)
        z_ad.Text = hn(3)
        z_vil.Text = hn(4)
        z_tl.Text = hn(5)
        Dim cmd1 As New OleDb.OleDbCommand("select cdclt from client", ft)
        hn = cmd1.ExecuteReader
        While hn.Read()
            l_rech.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()

    End Sub

    'Button Modifier

    Private Sub B_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_mod.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("update client set Cdclt ='" & z_cin.Text & "' , Nmpr='" & z_np.Text & "',Profession='" & l_prf.Text & "',Adresse='" & z_ad.Text & "',Ville='" & z_vil.Text & "',Téléphone='" & z_tl.Text & "' where cdclt='" & z_cin.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous modifier les données du client " & z_np.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader

            MsgBox("la modification  de client" & z_np.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")

        Else
            MsgBox("la modification de client" & z_np.Text & "est annulée", MsgBoxStyle.Information, "information")

        End If
        hn.Close()
        ft.Close()

    End Sub

    'Button Lister
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
        Dim d As New Form_liste_client
        Dim x As New Formmen_clt
        Select Case a
            Case "b2"
                addf(d)
            Case "b3"
                addf(x)
        End Select
    End Sub
    Private Sub B_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_list.Click
        change_menu("b2")
    End Sub

    'Button Annuler

    Private Sub B_anl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_anl.Click
        z_cin.Clear()
        z_np.Clear()
        l_prf.Text = ""
        z_ad.Clear()
        z_vil.Clear()
        z_tl.Clear()
        hn.Close()
        ft.Close()
    End Sub

    'Button Fermer

    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b3")
        End If
    End Sub

    'Button Supprimer

    Private Sub B_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_sup.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("delete from client where cdclt='" & z_cin.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous supprimmer le client " & z_np.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            Dim hn As OleDb.OleDbDataReader
            hn = cmd.ExecuteReader()
            MsgBox("La suppression de client " & z_np.Text & " effectuée avec succès", MsgBoxStyle.Information, "Information")
            ' Effacer les champs
            z_cin.Clear()
            z_np.Clear()
            z_ad.Clear()
            z_tl.Clear()
            z_vil.Clear()
            l_prf.Text = ""
            hn.Close()
        Else
            MsgBox("La suppression de client " & z_np.Text & " est annulée", MsgBoxStyle.Information, "Information")
        End If
        ft.Close()
    End Sub


    'Button ajouter

    Private Sub B_aj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_aj.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("insert into client values('" & z_cin.Text & "','" & z_np.Text & "','" & l_prf.Text & "','" & z_ad.Text & "','" & z_vil.Text & "','" & z_tl.Text & "')", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_ad.Clear()
        z_cin.Clear()
        z_np.Clear()
        z_tl.Clear()
        z_vil.Clear()
        l_prf.Text = ""
        hn.Close()
        ft.Close()
    End Sub
    
    
    
   
End Class