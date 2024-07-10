Imports System.Data.OleDb
Public Class Form_List_Fournisseur
    Dim hn As OleDb.OleDbDataReader
    Dim bs As New BindingSource
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

    Private Sub Form_List_Fournisseur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ft.Open()
        Dim x As OleDb.OleDbDataReader
        Dim y As New OleDbDataAdapter("Select * from fournisseur", ft)
        Dim d As New DataSet
        Dim ds As New DataView
        y.Fill(d, "fournisseur")
        ft.Close()
        ds = d.Tables(0).DefaultView
        bs.DataSource = ds
        Me.grid.DataSource = bs
        'Dim i As Integer, j As Integer
        'Dim cmd As New OleDb.OleDbCommand("select * from Fournisseur", ft)
        'hn = cmd.ExecuteReader
        'hn.Read()
        'i = 0
        'While hn.Read
        '    grid.Rows.Add()
        '    For j = 0 To 6
        '        grid.Rows(i).Cells(j).Value = hn(j)
        '        MsgBox(grid.Rows(i).Cells(j).Value = hn(j))
        '    Next
        '    i = i + 1
        'End While
        'hn.Close()
        ft.Close()
    End Sub

    Private Sub grid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub
End Class