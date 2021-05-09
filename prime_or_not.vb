Public Class prime_or_not
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Boolean = True
        Dim n As Integer
        n = TextBox1.Text
        For i = 2 To n / 2
            If (n Mod i = 0) Then
                a = False
                Exit For
            End If
        Next i
        If a = False Then
            MsgBox("Number Is Not Prime",vbCritical ,"Result")
        Else
            MsgBox("Number Is Prime", vbOK, "Result")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub
End Class