Imports System.Data.OleDb
Public Class Form8_Analyse_Ventes
    Dim hn As OleDb.OleDbDataReader
    Private Sub Form8_Analyse_Ventes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = 2022 To 2030
            l_an.Items.Add(i)
        Next
        For i = 1 To 12
            l_moi.Items.Add(i)
        Next
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

    Private Sub l_moi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_moi.SelectedIndexChanged
        ft.Open()
        Dim v1 As Single, v2 As Single, v3 As Single, tot As Single
            Dim cmd As New OleDb.OleDbCommand("select * from Req_anals_Vent where mois='" & l_moi.Text & "' and année='" & l_an.Text & "'", ft)
            hn = cmd.ExecuteReader
            While hn.Read()
                If hn(0) = "Matériel Informatique" Then
                    v1 = v1 + hn(1)
                ElseIf hn(0) = "Matériel Bureautique" Then
                    v2 = v2 + hn(1)
                ElseIf hn(0) = "Autre" Then
                    v3 = v3 + hn(1)
                End If

            End While

        tot = v1 + v2 + v3
        z_cat1.Text = Format((v1 / tot) * 100, "##0.00") & "%"
        z_cat2.Text = Format((v2 / tot) * 100, "##0.00") & "%"
        z_cat3.Text = Format((v3 / tot) * 100, "##0.00") & "%"
        z_tot.Text = tot
        hn.Close()
        ft.Close()
    End Sub

    Private Sub l_an_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_an.SelectedIndexChanged
        ft.Open()
        Dim v1 As Single, v2 As Single, v3 As Single, tot As Single
        Dim cmd As New OleDb.OleDbCommand("select * from Req_anals_Vent where mois='" & l_moi.Text & "' and année='" & l_an.Text & "'", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            If hn(0) = "Matériel Informatique" Then
                v1 = v1 + hn(1)
            ElseIf hn(0) = "Matériel Bureautique" Then
                v2 = v2 + hn(1)
            ElseIf hn(0) = "Autre" Then
                v3 = v3 + hn(1)
            End If


        End While
        tot = v1 + v2 + v3
        z_cat1.Text = Format((v1 / tot) * 100, "##0.00") & "%"
        z_cat2.Text = Format((v2 / tot) * 100, "##0.00") & "%"
        z_cat3.Text = Format((v3 / tot) * 100, "##0.00") & "%"
        z_tot.Text = tot
        hn.Close()
        ft.Close()
    End Sub
End Class