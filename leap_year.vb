Public Class leap_year
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim a As Integer
        a = TextBox1.Text

        If (((a Mod 4 = 0) And (a Mod 100 <> 0)) Or (a Mod 400 = 0)) Then
            MsgBox(a & " is a Leap Year ", vbInformation, "Result")
        Else
            MsgBox(a & " is a Not Leap Year ", vbCritical, "Result")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class