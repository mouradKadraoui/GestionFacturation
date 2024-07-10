Imports System.Data.OleDb
Public Class Form10_Saisi_Nouv_Fournisseur
    Dim hn As OleDb.OleDbDataReader
    Private Sub l_rech_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_rech.SelectedIndexChanged
        'Change Liste Recherche

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from Fournisseur where nmst='" & l_rech.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_rc.Text = hn(0)
        z_nmst.Text = hn(1)
        l_cat.Text = hn(2)
        z_ad.Text = hn(3)
        z_vil.Text = hn(4)
        z_tl.Text = hn(5)
        z_email.Text = hn(6)
        hn.Close()
        ft.Close()
    End Sub

    Private Sub Form10_Saisi_Nouv_Fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Liste Recherche
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select nmst from Fournisseur", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_rech.Items.Add(hn(0))
        End While
        Dim cmd1 As New OleDb.OleDbCommand("select ctg from Req_reg_ctg", ft)
        hn = cmd1.ExecuteReader
        While hn.Read()
            l_cat.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()

    End Sub

    'Button Fermer
    'Private Sub addf(ByVal x As Form)
    '    Try
    '        Form_Menu.Pac.Controls.Clear()
    '        x.TopLevel = False
    '        x.TopMost = True
    '        x.Dock = DockStyle.Fill
    '        Form_Menu.Pac.Controls.Add(x)
    '        x.Show()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    'Private Sub change_menu(ByVal a As String)
    '    Dim d As New Form_fornss
    '    Select Case a
    '        Case "b2"
    '            addf(d)
    '    End Select
    'End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b1")
        End If
    End Sub
    'Button Supprimer

    Private Sub B_sup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_sup.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("delete from fournisseur where rgcl='" & z_rc.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous supprimmer le Fournisseur " & z_nmst.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader
            z_rc.Text.Remove(z_rc.Text)
            MsgBox("la suppression  de client" & z_nmst.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")
            z_ad.Clear()
            z_rc.Clear()
            z_nmst.Clear()
            z_tl.Clear()
            z_vil.Clear()
            l_cat.Text = ""
            z_email.Clear()
        Else
            MsgBox("la suppression de client" & z_nmst.Text & "est annulée", MsgBoxStyle.Information, "information")
        End If
    End Sub

    'Button Ajouter
    Private Sub B_aj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_aj.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("insert into Fournisseur values('" & z_rc.Text & "','" & z_nmst.Text & "','" & l_cat.Text & "','" & z_ad.Text & "','" & z_vil.Text & "','" & z_tl.Text & "','" & z_email.Text & "')", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_ad.Clear()
        z_rc.Clear()
        z_nmst.Clear()
        z_tl.Clear()
        z_vil.Clear()
        l_cat.Text = ""
        z_email.Clear()
        hn.Close()
        ft.Close()
    End Sub
    'Button Modifier

    Private Sub B_mod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_mod.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("update Fournisseur set rgcl ='" & z_rc.Text & "' , Nmst='" & z_nmst.Text & "',ctg='" & l_cat.Text & "',Ad='" & z_ad.Text & "',Vl='" & z_vil.Text & "',tl='" & z_tl.Text & "', email ='" & z_email.Text & "' where rgcl='" & z_rc.Text & "'", ft)
        Dim rep As String
        rep = MsgBox("voulez-vous modifier les données du Fournisseur " & z_nmst.Text & " ?", vbYesNo + MsgBoxStyle.Exclamation, "Attention")
        If rep = vbYes Then
            hn = cmd.ExecuteReader

            MsgBox("la modification  de Fournisseur" & z_nmst.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")

        Else
            MsgBox("la modification de Fournisseur" & z_nmst.Text & "est annulée", MsgBoxStyle.Information, "information")

        End If
        hn.Close()
        ft.Close()
    End Sub

    Private Sub z_nmst_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles z_nmst.LostFocus
       

    End Sub

    'Liste Catégorie
    'Private Sub z_nmst_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles z_nmst.TextChanged
    '    l_cat.Items.Clear()
    '    If z_nmst.Text = "PHP" Then
    '        l_cat.Items.Add("Matériel Informatique")
    '        l_cat.Items.Add("Matériel Informatique1")
    '        l_cat.Items.Add("Matériel Informatique2")

    '    End If

    'End Sub
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
        Dim d As New Form_List_Fournisseur
        Dim q As New Form_fornss
        Select Case a
            Case "b2"
                addf(d)
            Case "b1"
                addf(q)
        End Select
    End Sub
    'Button Lister
    Private Sub B_list_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_list.Click
        'Form_List_Fournisseur.Show()
        change_menu("b2")
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class