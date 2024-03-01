Public Class Form1
    Sub show()
        Img1.Show()
        cmd_btn_show.Enabled = False
        cmd_btn_hide.Enabled = True
        CheckImg1.Checked = True
    End Sub
    Sub hide()
        Img1.Hide()
        cmd_btn_show.Enabled = True
        cmd_btn_hide.Enabled = False
        CheckImg1.Checked = False
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'isto é um comentário
        MessageBox.Show("Bem vindo à programação em vb.net", "vb.net", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub CheckImg1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckImg1.CheckedChanged
        If CheckImg1.Checked = True Then
            show()
        Else
            hide()
        End If
    End Sub

    Private Sub cmd_btn_exit_Click(sender As Object, e As EventArgs) Handles cmd_btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub cmd_btn_show_Click(sender As Object, e As EventArgs) Handles cmd_btn_show.Click
        show()
    End Sub

    Private Sub cmd_btn_hide_Click(sender As Object, e As EventArgs) Handles cmd_btn_hide.Click
        hide()
    End Sub
End Class
