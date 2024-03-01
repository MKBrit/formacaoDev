Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String
        Dim pw As String
        user = UserTextBox.Text
        pw = PwTextBox.Text

        If user.Equals("IEFP") And pw.Equals("programador") Then
            MessageBox.Show("Autenticação com sucesso!", "vb.net",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Credenciais erradas", "vb.net",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class

