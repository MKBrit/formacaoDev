Public Class Form3
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim n As Integer
        n = InputBox("Inserir número ")
        ListView1.Items.Add(n)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListView1.Clear()
    End Sub

    Private Sub btnAddMulti_Click(sender As Object, e As EventArgs) Handles btnAddMulti.Click
        Dim n, i, resp As Integer
        resp = InputBox("Quantos números quer introduzir? ", "Prompt", 10)
        For i = 1 To resp
            n = InputBox("Inserir número ", "Prompt", i)
            ListView1.Items.Add(n)
        Next
    End Sub

    Private Sub btnAddMultis_Click(sender As Object, e As EventArgs) Handles btnAddMultis.Click
        Dim n1, n2, n3 As Integer
        n1 = InputBox("Indique o 1º nr ", "Prompt",)
        n2 = InputBox("Indique o último nr ", "Prompt", n1 * 10)
        n3 = InputBox("Indique o multiplicador ", "Prompt", n1)
        For n1 = n3 To n2 Step n3
            ListView1.Items.Add(n1)
        Next
    End Sub
End Class