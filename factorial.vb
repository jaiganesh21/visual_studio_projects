Public Class factorial
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, f, i As Integer
        f = 1
        n = Val(TextBox1.Text)
        For i = 1 To n
            f = f * i
        Next
        MsgBox("Factorial is :" & f, vbInformation, "Factorial")

    End Sub
End Class