Public Class biggest_and_smallest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        If a > b And a > c Then

            MsgBox(" Largest Number is : " & a, vbOK, "Result")

        ElseIf b > c Then

            MsgBox(" Largest Number is : " & b, vbOK, "Result")

        Else

            MsgBox(" Largest Number is : " & c, vbOK, "Result")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class