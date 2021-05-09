Public Class changing_picture
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        PictureBox1.Image = My.Resources.doraemon

    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        PictureBox1.Image = My.Resources.pokemon

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        PictureBox1.Image = My.Resources.powerrangers

    End Sub


End Class