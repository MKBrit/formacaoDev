Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = Val(TextBox1.Text)

        If n > 0 Then
            Label1.Text = "Número positivo"
        ElseIf n < 0 Then
            Label1.Text = "Número negativo"
        Else
            Label1.Text = "Número nulo"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

End Class
