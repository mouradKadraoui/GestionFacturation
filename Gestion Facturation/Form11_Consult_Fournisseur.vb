Imports System.Data.OleDb
Public Class Form11_Consult_Fournisseur
    Dim hn As OleDb.OleDbDataReader
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
        Dim d As New Form_fornss
        Select Case a
            Case "b2"
                addf(d)
        End Select
    End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        change_menu("b2")
    End Sub

    
    Private Sub Form11_Consult_Fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        ft.Open()

        Dim cmd As New OleDb.OleDbCommand("select ctg from Req_reg_ctg", ft)
        hn = cmd.ExecuteReader

        While hn.Read
            l_cat.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()
    End Sub

    Private Sub l_cat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_cat.SelectedIndexChanged
        ft.Open()
        l_nst.Items.Clear()
        Dim cmd As New OleDb.OleDbCommand("select * from fournisseur where ctg='" & l_cat.Text & "'", ft)
        hn = cmd.ExecuteReader

        While hn.Read
            l_nst.Items.Add(hn(1))
        End While
        Dim i As Integer, j As Integer
        Dim cmd2 As New OleDb.OleDbCommand("select Désignation,[Type Produit],[Prix Unitaire] from Produit where [Type Produit]='" & l_cat.Text & "'", ft)
        hn = cmd2.ExecuteReader
        grid.Rows.Clear()
        i = 0
        While hn.Read()
            grid.Rows.Add()
            For j = 0 To 2
                grid.Rows(i).Cells(j).Value = hn(j)
            Next
            i = i + 1
        End While
        hn.Close()
        ft.Close()
    End Sub

   
End Class