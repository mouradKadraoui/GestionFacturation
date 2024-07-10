Imports System.Data.OleDb
Public Class Form_avance
    Dim hn As OleDb.OleDbDataReader
    Private Sub Form_avance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        z_dt.Text = Date.Today

        'Liste mode Paiement
        l_mp.Items.Add("Espèce")
        l_mp.Items.Add("Chèque")
        l_mp.Items.Add("Carte Bancaire")
        l_mp.Items.Add("Virement Bancaire")

    End Sub

    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Me.Close()
    End Sub

    Private Sub B_ajout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_ajout.Click
        ft.Open()
        Dim cmd2 As New OleDb.OleDbCommand("insert into Réglement values('" & z_dt.Text & "','" & z_av.Text & "','" & l_mp.Text & "','" & z_nf.Text & "')", ft)
        hn = cmd2.ExecuteReader
        hn.Read()
        MsgBox("l'avance du numéro facture" & z_nf.Text & "effectuée par succésés", MsgBoxStyle.Information, "information")
        Form4_Consult_Fct_Numr.z_av.Text = Val(Form4_Consult_Fct_Numr.z_av.Text) + Val(z_av.Text)
        Form4_Consult_Fct_Numr.z_rst.Text = Val(Form4_Consult_Fct_Numr.z_tcc.Text) - Val(Form4_Consult_Fct_Numr.z_av.Text)
        hn.Close()
        ft.Close()
    End Sub
End Class