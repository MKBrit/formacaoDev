Imports System.Runtime.Remoting.Messaging

Public Class Form2
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Me.Hide()
        Form1.Show()
        Form3.Hide()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Me.Hide()
        Form1.Hide()
        Form3.Show()
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MessageBox.Show("Hello!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnYNC_Click(sender As Object, e As EventArgs) Handles btnYNC.Click
        Dim resp As Integer
        resp = MessageBox.Show("Choose your option", "Prompt", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation)
        If resp = vbYes Then
            MessageBox.Show("Pressionou Sim!", "Prompt")
        ElseIf resp = vbNo Then
            MessageBox.Show("Pressionou Não!", "Prompt")
        End If
    End Sub

    Private Sub btnARI_Click(sender As Object, e As EventArgs) Handles btnARI.Click
        Dim resp As Integer
        resp = MessageBox.Show("Choose your option", "Prompt", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
        If resp = vbAbort Then
            MessageBox.Show("Abortando...", "Prompt")
        ElseIf resp = vbRetry Then
            MessageBox.Show("Reiniciando...", "Prompt")
        End If
    End Sub
End Class