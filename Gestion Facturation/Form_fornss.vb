Public Class Form_fornss

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
        Dim d As New Form10_Saisi_Nouv_Fournisseur
        Dim f As New Form11_Consult_Fournisseur
        Dim s As New Form_List_Fournisseur
        Select Case a
            Case "b1"
                addf(f)
            Case "b2"
                addf(d)
            Case "b3"
                addf(s)
        End Select
    End Sub



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, L2.Click
        change_menu("b2")
    End Sub

   
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, L1.Click
        change_menu("b1")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click, L3.Click
        change_menu("b3")
    End Sub

    Private Sub Form_fornss_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class