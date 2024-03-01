Imports System.Reflection.Emit
Imports System.Runtime.Serialization

Public Class Form1
    Dim pratoDia As Integer
    Dim pratoCrn As Integer
    Dim pratoPx As Integer
    Dim sopa As Integer
    Dim bebida As Integer
    Dim sobremesa As Integer
    Dim cafe As Integer

    Dim soma As Integer
    Dim pago As Integer
    Dim troco As Integer
    Dim totalTroco As Integer


    Sub segunda()
        Me.BackgroundImage = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\seg\diaSeg_fn.png")
        PictureBox1.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\seg\crnSeg_fn.png")
        PictureBox2.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\seg\pxSeg_fn.png")
        labelDia.Text = "Feijoada"
        labelDia.ForeColor = Color.White
        labelCarne.Text = "Entrecosto"
        labelPeixe.Text = "Solha"
    End Sub
    Sub terca()
        Me.BackgroundImage = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\ter\diaTer_fn.png")
        PictureBox1.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\ter\crnTer_fn.png")
        PictureBox2.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\ter\pxTer_fn.jpg")
        labelDia.Text = "Cozido à Portuguesa"
        labelDia.ForeColor = Color.White
        labelCarne.Text = "Coxinhas Assadas"
        labelPeixe.Text = "Sardinha Assada"
    End Sub
    Sub quarta()
        Me.BackgroundImage = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qua\diaQua_fn.png")
        PictureBox1.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qua\crnQua_fn.png")
        PictureBox2.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qua\pxQua_fn.png")
        labelDia.Text = "Carne de Porco" & vbCrLf & "à Alentejana"
        labelDia.ForeColor = Color.White
        labelCarne.Text = "Carne Guisada"
        labelPeixe.Text = "Pescada Cozida"
    End Sub
    Sub quinta()
        Me.BackgroundImage = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qui\diaQui_fn.png")
        PictureBox1.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qui\crnQui_fn.png")
        PictureBox2.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\qui\pxQui_fn.png")
        labelDia.Text = "Leitão à Bairrada"
        labelDia.ForeColor = Color.Black
        labelCarne.Text = "Bitoque"
        labelPeixe.Text = "Bacalhau com Natas"
    End Sub
    Sub sexta()
        Me.BackgroundImage = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\sex\diaSex_fn.png")
        PictureBox1.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\sex\crnSex_fn.png")
        PictureBox2.Image = Image.FromFile("C:\Life Data\EFA NS PRO Programador\Teotónio\repos\Projeto2\sex\pxSex_fn.png")
        labelDia.Text = "Picanha"
        labelDia.ForeColor = Color.Black
        labelCarne.Text = "Francesinha"
        labelPeixe.Text = "Arroz de Tamboril"
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxDias.SelectedIndexChanged
        labelCarne.Show()
        labelPeixe.Show()
        PictureBox1.Show()
        PictureBox2.Show()
        PictureBox3.Hide()
        If ComboBoxDias.SelectedItem = "Segunda Feira" Then
            segunda()
        End If
        If ComboBoxDias.SelectedItem = "Terça Feira" Then
            terca()
        End If
        If ComboBoxDias.SelectedItem = "Quarta Feira" Then
            quarta()
        End If
        If ComboBoxDias.SelectedItem = "Quinta Feira" Then
            quinta()
        End If
        If ComboBoxDias.SelectedItem = "Sexta Feira" Then
            sexta()
        End If

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        labelDia.BackColor = Color.Transparent
        labelPeixe.BackColor = Color.Transparent
        labelCarne.BackColor = Color.Transparent
        pratoDia = 10
        pratoCrn = 12
        pratoPx = 12
        sopa = 2
        bebida = 2
        sobremesa = 4
        cafe = 1
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Private Sub btnConta_Click(sender As Object, e As EventArgs) Handles btnConta.Click
        Me.Hide()
        Form2.Show()
    End Sub


    Private Sub lblTroco_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTotal_Click(sender As Object, e As EventArgs)

    End Sub
End Class