Public Class Form1
    Private Sub ButtonStart_Click(sender As Object, e As EventArgs) Handles ButtonStart.Click
        ButtonStart.Visible = False
        ButtonExit.Visible = True
        ButtonHappy.Enabled = True
        ButtonSad.Enabled = True
        ButtonHappy.Visible = True
        ButtonSad.Visible = True
        CheckBoxHappy.Enabled = True
        CheckBoxSad.Enabled = True
        CheckBoxHappy.Visible = True
        CheckBoxSad.Visible = True
    End Sub
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        Application.Exit()
    End Sub
    Sub showHappy()
        LabelHappy.Visible = True
        LabelSad.Visible = False
        PictureHappy.Visible = True
        PictureSad.Visible = False
        ButtonHappy.Enabled = False
        ButtonSad.Enabled = True
        CheckBoxHappy.Enabled = False
        CheckBoxSad.Enabled = True
        CheckBoxHappy.Checked = True
        CheckBoxSad.Checked = False
    End Sub
    Sub showSad()
        LabelHappy.Visible = False
        LabelSad.Visible = True
        PictureHappy.Visible = False
        PictureSad.Visible = True
        ButtonHappy.Enabled = True
        ButtonSad.Enabled = False
        CheckBoxHappy.Enabled = True
        CheckBoxSad.Enabled = False
        CheckBoxHappy.Checked = False
        CheckBoxSad.Checked = True
    End Sub
    Private Sub ButtonHappy_Click(sender As Object, e As EventArgs) Handles ButtonHappy.Click
        showHappy()
    End Sub
    Private Sub ButtonSad_Click(sender As Object, e As EventArgs) Handles ButtonSad.Click
        showSad()
    End Sub
    Private Sub CheckBoxHappy_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxHappy.CheckedChanged
        If CheckBoxHappy.Checked Then
            showHappy()
        End If
    End Sub
    Private Sub CheckBoxSad_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxSad.CheckedChanged
        If CheckBoxSad.Checked Then
            showSad()
        End If
    End Sub
End Class
