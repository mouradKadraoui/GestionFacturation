Imports System.Data.OleDb
Public Class Form6_Etat_Vent_Périod
    Dim hn As OleDb.OleDbDataReader
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ft.Open()
        Dim i As Integer, j As Integer, s As Single, tot As Single
        If t_du.Value.Date > t_au.Value.Date Then
            MsgBox("Aucune date entre les deux date saisissent", vbOK + MsgBoxStyle.Information, "Information")
        Else
            Dim cmd2 As New OleDb.OleDbCommand("select *  from Req_Etat_Vent where [Date Facture] Between ? and ? ", ft)
            cmd2.Parameters.AddWithValue("?", t_du.Value.Date)
            cmd2.Parameters.AddWithValue("?", t_au.Value.Date)
            hn = cmd2.ExecuteReader
            grid.Rows.Clear()
            i = 0
            s = 0
            tot = 0
            While hn.Read()
                grid.Rows.Add()
                For j = 0 To 4
                    grid.Rows(i).Cells(j).Value = hn(j)
                Next
                s = s + grid.Rows(i).Cells(3).Value
                tot = tot + grid.Rows(i).Cells(4).Value
                i = i + 1
            End While
            z_tot.Text = Format(tot, "# ##0.00")
            z_av.Text = Format(s, "# ##0.00")
            z_rst.Text = Format(CDbl(z_tot.Text) - CDbl(z_av.Text), "# ##0.00")
        End If
        hn.Close()
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
        Dim d As New Form_py_imp
        Select Case a
            Case "b2"
                addf(d)
        End Select
    End Sub
    Private Sub B_fer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_fer.Click
        Dim rep As String
        rep = MsgBox("voulez-vous fermer le formulaire ?", vbYesNo + MsgBoxStyle.Information, "Information")
        If rep = vbYes Then
            change_menu("b2")
        End If
    End Sub

    Private Sub Form6_Etat_Vent_Périod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class