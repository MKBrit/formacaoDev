Public Class Form1
    Private Sub cmdBtn1_Click(sender As Object, e As EventArgs) Handles cmdBtn1.Click
        Dim n As Integer
        n = InputBox("Inserir numero", "vb.net")
        Select Case n
            Case 1
                MessageBox.Show("Segunda", "vb.net")
            Case 2
                MessageBox.Show("Terça", "vb.net")
            Case 3
                MessageBox.Show("Quarta", "vb.net")
            Case 4
                MessageBox.Show("Quinta", "vb.net")
            Case 5
                MessageBox.Show("Sexta", "vb.net")
            Case 6
                MessageBox.Show("Sábado", "vb.net")
            Case 7
                MessageBox.Show("Domingo", "vb.net")
            Case Else
                MessageBox.Show("Warning! Só existem 7 dias por semana..", "vb.net")
        End Select
    End Sub

    Private Sub cmdBtn2_Click(sender As Object, e As EventArgs) Handles cmdBtn2.Click
        Dim n As Integer
        n = InputBox("Inserir numero", "vb.net")
        If n = 1 Then
            MessageBox.Show("Segunda", "vb.net")
        ElseIf n = 2 Then
            MessageBox.Show("Terça", "vb.net")
        ElseIf n = 3 Then
            MessageBox.Show("Quarta", "vb.net")
        ElseIf n = 4 Then
            MessageBox.Show("Quinta", "vb.net")
        ElseIf n = 5 Then
            MessageBox.Show("Sexta", "vb.net")
        ElseIf n = 6 Then
            MessageBox.Show("Sábado", "vb.net")
        ElseIf n = 7 Then
            MessageBox.Show("Domingo", "vb.net")
        Else
            MessageBox.Show("Warning! Só existem 7 dias por semana.", "vb.net")
        End If

    End Sub

    Private Sub cmdBtn3_Click(sender As Object, e As EventArgs) Handles cmdBtn3.Click
        Dim n As Integer
        n = InputBox("Inserir mes", "vb.net")
        Select Case n
            Case 1, 2, 3, 4, 5, 6
                MessageBox.Show("1º Semestre", "vb.net")
            Case 7, 8, 9, 10, 11, 12
                MessageBox.Show("2º Semestre", "vb.net")
            Case Else
                MessageBox.Show("Warning! Só existem 12 meses por ano.", "vb.net")
        End Select
    End Sub

    Sub a()
        imgA.Show()
        imgB.Hide()
        imgC.Hide()
        imgD.Hide()
        CheckedListBox1.SetItemChecked(0, True)
        CheckedListBox1.SetItemChecked(1, False)
        CheckedListBox1.SetItemChecked(2, False)
        CheckedListBox1.SetItemChecked(3, False)
        ComboBox1.SelectedItem = "Plan A"
    End Sub
    Sub b()
        imgA.Hide()
        imgB.Show()
        imgC.Hide()
        imgD.Hide()
        CheckedListBox1.SetItemChecked(0, False)
        CheckedListBox1.SetItemChecked(1, True)
        CheckedListBox1.SetItemChecked(2, False)
        CheckedListBox1.SetItemChecked(3, False)
        ComboBox1.SelectedItem = "Plan B"
    End Sub
    Sub c()
        imgA.Hide()
        imgB.Hide()
        imgC.Show()
        imgD.Hide()
        CheckedListBox1.SetItemChecked(0, False)
        CheckedListBox1.SetItemChecked(1, False)
        CheckedListBox1.SetItemChecked(2, True)
        CheckedListBox1.SetItemChecked(3, False)
        ComboBox1.SelectedItem = "Plan C"
    End Sub
    Sub d()
        imgA.Hide()
        imgB.Hide()
        imgC.Hide()
        imgD.Show()
        CheckedListBox1.SetItemChecked(0, False)
        CheckedListBox1.SetItemChecked(1, False)
        CheckedListBox1.SetItemChecked(2, False)
        CheckedListBox1.SetItemChecked(3, True)
        ComboBox1.SelectedItem = "Plan D"

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        If CheckedListBox1.SelectedIndex = 0 Then
            a()
        End If
        If CheckedListBox1.SelectedIndex = 1 Then
            b()
        End If
        If CheckedListBox1.SelectedIndex = 2 Then
            c()
        End If
        If CheckedListBox1.SelectedIndex = 3 Then
            d()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Plan A" Then
            a()
        End If
        If ComboBox1.SelectedItem = "Plan B" Then
            b()
        End If
        If ComboBox1.SelectedItem = "Plan C" Then
            c()
        End If
        If ComboBox1.SelectedItem = "Plan D" Then
            d()
        End If
    End Sub
End Class
