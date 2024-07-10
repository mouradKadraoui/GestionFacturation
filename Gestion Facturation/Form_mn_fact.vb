Public Class Form_mn_fact
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
        Dim d As New Form3_nouvl_Facture
        Dim r As New Form4_Consult_Fct_Numr
        Dim y As New Form7_List_Factur_Client
        Select Case a
            Case "b1"
                addf(d)
            Case "b2"
                addf(r)
            Case "b3"
                addf(y)
        End Select
    End Sub


   
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click, L1.Click
        change_menu("b1")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, L2.Click
        change_menu("b2")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click, L3.Click
        change_menu("b3")
    End Sub

    Private Sub Form_mn_fact_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class