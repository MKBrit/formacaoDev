Public Class Form1
    Sub clear_txt()
        txt_nome.Clear()
        txt_morada.Clear()
        txt_cod.Clear()
        txt_local.Clear()
        txt_tlm.Clear()
        txt_results.Clear()
    End Sub

    Sub add_txt()
        txt_results.Text = "Nome:" & txt_nome.Text & vbCrLf & "Morada:" & txt_morada.Text & vbCrLf & "Cód Postal:" & txt_cod.Text & vbCrLf & "Localidade:" & txt_local.Text & vbCrLf & "Tlm:" & txt_tlm.Text
    End Sub

    Sub format_txt()
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt_results.Font = FontDialog1.Font
            txt_results.ForeColor = FontDialog1.Color
        End If
    End Sub

    Sub open()
        Dim abreF As New OpenFileDialog
        abreF.Filter = "txt files (*.txt)|*.txt"
        abreF.FilterIndex = 2
        abreF.RestoreDirectory = False

        If abreF.ShowDialog() = DialogResult.OK Then
            txt_results.Text = IO.File.ReadAllText(abreF.FileName)
        End If
    End Sub

    Sub save()
        Dim guardaF As New SaveFileDialog
        guardaF.Filter = "txt files (*.txt)|*.txt"
        guardaF.FilterIndex = 2
        guardaF.RestoreDirectory = False

        If guardaF.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(guardaF.FileName, txt_results.Text)
        End If
    End Sub

    Sub print()
        Dim printDialog As New PrintDialog()
        If printDialog.ShowDialog() = DialogResult.OK Then
            Dim printDocument As New Printing.PrintDocument()
            printDocument.DocumentName = "Document Name" ' Set a name for the document
            printDocument.PrinterSettings = printDialog.PrinterSettings

            AddHandler printDocument.PrintPage, Sub(sender As Object, e As Printing.PrintPageEventArgs)
                Dim printFont As New Font("Arial", 12)
                Dim printText As String = txt_results.Text

                e.Graphics.DrawString(printText, printFont, Brushes.Black, e.MarginBounds.Left, e.MarginBounds.Top)
                End Sub

            printDocument.Print()
        End If
    End Sub



    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        End
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        End
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear_txt()
    End Sub

    Private Sub LimparToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimparToolStripMenuItem.Click
        clear_txt()
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        add_txt()
    End Sub

    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        add_txt()
    End Sub

    Private Sub btn_format_Click(sender As Object, e As EventArgs) Handles btn_format.Click
        format_txt()
    End Sub

    Private Sub FormatarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatarToolStripMenuItem.Click
        format_txt()
    End Sub

    Private Sub AbrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbrirToolStripMenuItem.Click
        open()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        save()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        print()
    End Sub

End Class
