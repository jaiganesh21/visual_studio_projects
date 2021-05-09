Public Class positive_and_negative
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        a = CInt(TextBox1.Text)


        If (a > 0) Then
            MessageBox.Show("The Given  Number is Positive")

        ElseIf (a = 0) Then

            MessageBox.Show("The Given  Number is neigther Positive or negative")

        Else
            MessageBox.Show("The Given  Number is Negative")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class