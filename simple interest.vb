Public Class simple_interest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p, n, r, si As Integer
        p = TextBox1.Text
        r = TextBox2.Text
        n = TextBox3.Text
        si = p * n * r / 100
        TextBox4.Text = si

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class