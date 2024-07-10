Imports System.Data.OleDb
Public Class Form2
    Dim hn As OleDb.OleDbDataReader
    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles diag_vente.Click
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from req_porst_vt", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            diag_vente.Series("vente").Points.AddXY(hn(0), hn(1))
        End While
        hn.Close()
        ft.Close()
    End Sub
End Class