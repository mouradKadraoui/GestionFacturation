Imports System.Data.OleDb
Public Class Form7_List_Factur_Client
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
        Dim d As New Form_mn_fact
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

    Private Sub Form7_List_Factur_Client_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Liste CIN

        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select cdclt from Facture Group By cdclt", ft)
        hn = cmd.ExecuteReader
        While hn.Read()
            l_cin.Items.Add(hn(0))
        End While
        hn.Close()
        ft.Close()
    End Sub

    Private Sub l_cin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles l_cin.SelectedIndexChanged
        ft.Open()
        Dim cmd As New OleDb.OleDbCommand("select nmpr,Adresse  from client where cdclt='" & l_cin.Text & "'", ft)
        hn = cmd.ExecuteReader
        hn.Read()
        z_np.Text = hn(0)
        z_ad.Text = hn(1)
        hn.Close()
        ft.Close()
        ft.Open()
        Dim i As Integer, j As Integer, s As Single, tot As Single
        Dim cmd2 As New OleDb.OleDbCommand("select numéro,[date facture],sommedeavance,montantttc from Req_Etat_Vent where cdclt='" & l_cin.Text & "'", ft)
        hn = cmd2.ExecuteReader
        grid.Rows.Clear()
        i = 0
        s = 0
        tot = 0
        While hn.Read()
            grid.Rows.Add()
            For j = 0 To 3
                grid.Rows(i).Cells(j).Value = hn(j)
            Next
            s = s + grid.Rows(i).Cells(2).Value
            tot = tot + grid.Rows(i).Cells(3).Value
            i = i + 1
        End While
        z_tot.Text = Format(tot, "# ##0.00")
        z_av.Text = Format(s, "# ##0.00")
        z_rst.Text = Format(CDbl(z_tot.Text) - CDbl(z_av.Text), "# ##0.00")
        hn.Close()
        ft.Close()
    End Sub

    
  
End Class