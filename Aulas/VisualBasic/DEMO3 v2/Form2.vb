Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim N_txt As String
        Dim N As Long

        N_txt = Me.Txt_Numero.Text
        If IsNumeric(N_txt) Then
            MessageBox.Show("Digitou um número", "Valida campo")
            N = Val(N_txt)
        Else
            MessageBox.Show("Digitou um texto ou caracter" & vbLf & "Digite um número Pf", "Atenção")
            Txt_Numero.Clear()
            Txt_Numero.Focus()
        End If
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim N_txt As String
        Dim N As Long

        N_txt = Me.Txt_Numero.Text


        N = Val(N_txt)
        If N <> 0 Then
            MessageBox.Show("Digitou um número", "Valida campo")
            N = Val(N_txt)
        Else
            MessageBox.Show("Digitou um texto ou caracter" & vbLf & "Digite um número Pf", "Atenção")
            Txt_Numero.Clear()
            Txt_Numero.Focus()
        End If

    End Sub








    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form1.Show()
    End Sub

End Class