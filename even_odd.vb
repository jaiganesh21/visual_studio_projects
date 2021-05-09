Public Class even_odd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        If a Mod 2 = 0 Then
            MsgBox("Entered Number is Even", vbOK, "Result")
        Else
            MsgBox("Entered Number is Odd", vbCritical, "Result")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class