Public Class Form_py_imp

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
        Dim d As New Form5_Etat_Payement
        Dim f As New Form6_Etat_Vent_Périod
        Dim u As New Form9_Etat_Impayés
        Dim i As New Form8_Analyse_Ventes
        Select Case a
            Case "b1"
                addf(f)
            Case "b2"
                addf(d)
            Case "b3"
                addf(u)
            Case "b4"
                addf(i)
        End Select
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, L1.Click
        change_menu("b2")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, L2.Click
        change_menu("b3")
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click, L3.Click
        change_menu("b1")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click, L4.Click
        change_menu("b4")
    End Sub

    Private Sub Form_py_imp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class