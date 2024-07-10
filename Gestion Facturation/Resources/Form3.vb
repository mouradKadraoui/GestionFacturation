Imports System.Data.OleDb
Public Class Form3
    Dim bs As New BindingSource
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ft.Open()
        Dim x As OleDb.OleDbDataReader
        Dim y As New OleDbDataAdapter("Select * from Fournisseur", ft)
        Dim d As New DataSet
        Dim ds As New DataView
        y.Fill(d, "Fournisseur")
        ft.Close()
        ds = d.Tables(0).DefaultView
        bs.DataSource = ds
        Me.grid.DataSource = bs


    End Sub
End Class