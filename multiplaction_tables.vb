Public Class multiplaction_tables
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, n As Integer
        n = TextBox1.Text
        For i = 1 To 10
            RichTextBox1.Text = RichTextBox1.Text & i & " " & "*" & n & "=" & n * i
            RichTextBox1.Text = RichTextBox1.Text & vbNewLine

        Next
    End Sub
End Class