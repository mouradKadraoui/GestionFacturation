Public Class Form_mn_Prod

    Private Sub addf(ByVal x As Form)
        Try
            Form_Menu.pac.Controls.Clear()
            x.TopLevel = False
            x.TopMost = True
            x.Dock = DockStyle.Fill
            Form_Menu.pac.Controls.Add(x)
            x.Show()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub change_menu(ByVal a As String)
        Dim d As New Form_saisi_produit
        Dim f As New Form_List_Produit
        Select Case a
            Case "b1"
                addf(f)
            Case "b2"
                addf(d)
        End Select
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, L1.Click
        change_menu("b2")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click, L2.Click
        change_menu("b1")
    End Sub

    Private Sub Form_mn_Prod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class