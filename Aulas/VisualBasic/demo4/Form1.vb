Option Explicit On

Public Class Form1
    Dim nr, nrInicial, nrFinal, i As Integer
    Dim txt As String

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnWhile_Click(sender As Object, e As EventArgs) Handles btnWhile.Click
        nrInicial = Val(txtBoxInicial.Text)
        nrFinal = Val(txtBoxFinal.Text)
        nr = nrInicial

        If nrInicial <= nrFinal Then
            Do While nr <= nrFinal

                txt = nr & "- While"
                MessageBox.Show(txt, "Contagem Crescente")
                nr += 1
            Loop
        End If

    End Sub

    Private Sub btnFor_Click(sender As Object, e As EventArgs) Handles btnFor.Click
        nrInicial = Val(txtBoxInicial.Text)
        nrFinal = Val(txtBoxFinal.Text)

        If nrInicial < nrFinal Then
            For nr As Integer = nrInicial To nrFinal
                txt = nr & "- For"
                MessageBox.Show(txt, "Contagem Crescente")
            Next nr
        End If
    End Sub
End Class
