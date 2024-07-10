Public Class Form_mot_passe


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        If i = 3 Then
            MsgBox("Le max de saisir est 3 fois!!!")
            Me.Close()
        End If
        Try
            If T1.Text = "Admin" And T2.Text = "1234" Then
                Form_Menu.Show()
                Me.Hide()
            ElseIf T1.Text = "" Or T2.Text = "" Then
                MsgBox("Il faut remplir les Deux champs!!!")
                T1.Clear()
                T2.Clear()
                T1.Focus()
            Else
                i = i + 1
                MsgBox("Le mot de passe incorrect!!!")
                T1.Clear()
                T2.Clear()
                T1.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class