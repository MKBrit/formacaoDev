Public Class LoginForm1
    Dim counter As Integer = 3

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user, pw As String
        user = UserTextBox.Text
        pw = PwTextBox.Text

        If counter = 0 Then
            MessageBox.Show("Esgotou o nr de tentativas disponíveis", "Hacker boy allert")
            Application.Exit()

        ElseIf user.Equals("") And pw.Equals("") Then
            MessageBox.Show("Autenticação com sucesso!", "vb.net",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form1.Show()
            Me.Hide()
            counter = 3
        Else
            MessageBox.Show("Credenciais erradas", "vb.net",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            counter -= 1
        End If

    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub
End Class
