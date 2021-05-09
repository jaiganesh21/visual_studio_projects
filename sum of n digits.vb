Public Class sum_of_n_digits
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        Dim r, s As Integer

        n = TextBox1.Text
        s = 0

        While (n > 0)

            r = n Mod 10
            s = s + r
            n = n / 10

            'MsgBox("sum of the digits", s)
            ' MsgBox(s)
            'MsgBox("The sum is : " & s)

        End While

        'TextBox2.Text = s.ToString()
        MsgBox("Sum Of The Digits is  : " & s, vbOK, "Result")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class