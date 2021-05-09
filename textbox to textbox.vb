Public Class textbox_to_textbox
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a As String
        a = TextBox1.Text
        TextBox2.Text = a
    End Sub
End Class