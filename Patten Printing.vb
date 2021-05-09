Public Class Patten_Printing
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, i, j As Integer
        n = TextBox1.Text
        For i = 1 To n
            For j = 1 To i
                RichTextBox1.Text = RichTextBox1.Text & " " & "*"
            Next
            RichTextBox1.Text = RichTextBox1.Text & vbNewLine

        Next
    End Sub
End Class