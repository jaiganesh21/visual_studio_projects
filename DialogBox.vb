Public Class DialogBox
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        OpenFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.* Text files (*.txt)|*.txt| Word Documents|*.doc|Excel Worksheets|*.xls|PowerPoint Presentations|*.ppt|Office Files|*.doc;*.xls;*.ppt|"
        If (OpenFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (FontDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.Font = FontDialog1.Font
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ColorDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.ForeColor = ColorDialog1.Color
        End If
    End Sub
End Class