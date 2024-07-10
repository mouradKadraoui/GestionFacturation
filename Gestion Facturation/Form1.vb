Imports System.Data.OleDb
Public Class Form1
    Dim hn As OleDb.OleDbDataReader
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        l_cat.Items.Add("Matériel Bureautique")
        l_cat.Items.Add("Matériel Informatique")
    End Sub

    Private Sub l_cat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_cat.SelectedIndexChanged
        ft.Open()
        l_nst.Items.Clear()

        Dim cmd As New OleDb.OleDbCommand("select * from fournisseur where ctg='" & l_cat.Text & "'", ft)
        hn = cmd.ExecuteReader

        While hn.Read
            l_nst.Items.Add(hn(1))

        End While
        hn.Close()
        ft.Close()
    End Sub
End Class