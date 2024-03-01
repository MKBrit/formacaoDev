Public Class Form2
    Dim dia, crn, px, bebida, cafe, sopa, sobr, soma, media As Double
    Public Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("Artigo", 120)
        ListView1.Columns.Add("Preço", 80)
        ListView1.Columns.Add("€", 20)
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        If ListView1.Items.Count > 0 Then
            ListView1.Clear()
        Else
            MessageBox.Show("Não há itens na lista")
        End If
    End Sub

    Private Sub clear1Btn_Click(sender As Object, e As EventArgs) Handles clear1Btn.Click
        If ListView1.Items.Count > 0 Then
            ListView1.Items.RemoveAt(ListView1.Items.Count - 1)
        Else
            MessageBox.Show("Não há itens na lista")
        End If

    End Sub

    Private Sub diaBtn_Click(sender As Object, e As EventArgs) Handles diaBtn.Click
        dia = InputBox("Digite o preço do prato do dia")
        soma += dia
        Dim newItem As New ListViewItem({"Prato do Dia", dia, "€"})
        ListView1.Items.Add(newItem)
    End Sub

    Private Sub crnBtn_Click(sender As Object, e As EventArgs) Handles crnBtn.Click
        crn = InputBox("Digite o preço do prato de carne")
        soma += crn
        Dim newItem As New ListViewItem({"Prato de Carne", crn, "€"})
        ListView1.Items.Add(newItem)

    End Sub

    Private Sub pxBtn_Click(sender As Object, e As EventArgs) Handles pxBtn.Click
        px = InputBox("Digite o preço do prato de peixe")
        soma += px
        Dim newItem As New ListViewItem({"Prato de peixe", px, "€"})
        ListView1.Items.Add(newItem)

    End Sub

    Private Sub sopaBtn_Click(sender As Object, e As EventArgs) Handles sopaBtn.Click
        sopa = InputBox("Digite o preço da sopa")
        soma += sopa
        Dim newItem As New ListViewItem({"Sopa", sopa, "€"})
        ListView1.Items.Add(newItem)

    End Sub

    Private Sub bebidaBtn_Click(sender As Object, e As EventArgs) Handles bebidaBtn.Click
        bebida = InputBox("Digite o preço da bebida")
        soma += bebida
        Dim newItem As New ListViewItem({"Bebida", bebida, "€"})
        ListView1.Items.Add(newItem)

    End Sub

    Private Sub sobrBtn_Click(sender As Object, e As EventArgs) Handles sobrBtn.Click
        sobr = InputBox("Digite o preço da sobremesa")
        soma += sobr
        Dim newItem As New ListViewItem({"Sobremesa", sobr, "€"})
        ListView1.Items.Add(newItem)

    End Sub

    Private Sub cafeBtn_Click(sender As Object, e As EventArgs) Handles cafeBtn.Click
        cafe = InputBox("Digite o preço do café")
        soma += cafe
        Dim newItem As New ListViewItem({"Café", cafe, "€"})
        ListView1.Items.Add(newItem)

    End Sub
    Private Sub contaBtn_Click(sender As Object, e As EventArgs) Handles contaBtn.Click
        If soma <= 10 Then
            MessageBox.Show(String.Format("Total: €{0:F2}", soma), "Tá barato")
        ElseIf soma > 10 And soma <= 20 Then
            MessageBox.Show(String.Format("Total: €{0:F2}", soma), "Boa relação preço/qualidade")
        Else
            MessageBox.Show(String.Format("Total: €{0:F2}", soma), "É lidar irmoum")
        End If
        media = soma / ListView1.Items.Count
        MessageBox.Show("Média: €" & media.ToString("F2"), "Média dos preços")
    End Sub


End Class