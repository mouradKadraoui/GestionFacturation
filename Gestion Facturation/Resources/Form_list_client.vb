Imports System.Data.OleDb
Public Class Form_liste_client

    'Dim hn As OleDb.OleDbDataReader
    Dim bs As New BindingSource
    Private Sub Form_liste_client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       ft.Open()
        Dim x As OleDb.OleDbDataReader
        Dim y As New OleDbDataAdapter("Select * from client", ft)
        Dim d As New DataSet
        Dim ds As New DataView
        y.Fill(d, "client")
        ft.Close()
        ds = d.Tables(0).DefaultView
        bs.DataSource = ds
        Me.grid.DataSource = bs
        'hn.Close()
        ft.Close()
    End Sub

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
        Dim d As New Formmen_clt
        Select Case a
            Case "b2"
                addf(d)
         
        End Select
    End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        change_menu("b2")
    End Sub

    
End Class