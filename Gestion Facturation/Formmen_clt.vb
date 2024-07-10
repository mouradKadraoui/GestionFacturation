Public Class Formmen_clt
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
        Dim d As New Form_Saisi_Client
        Dim f As New Form_liste_client
        Select Case a
            Case "b1"
                addf(f)
            Case "b2"
                addf(d)
        End Select
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, l1.Click
        change_menu("b2")
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, L2.Click
        change_menu("b1")
    End Sub

   
End Class