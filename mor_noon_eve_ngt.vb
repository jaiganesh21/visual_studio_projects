Public Class mor_noon_eve_ngt
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Hour = Val(TextBox1.Text)

        If Hour >= 6 And Hour <= 11.59 Then
            MsgBox("Morning", vbCritical, "Result")

        ElseIf Hour = 12 Then
            MsgBox("Noon", vbCritical, "Result")


        ElseIf Hour >= 12.01 And Hour <= 17 Then
            MsgBox("Afternoon", vbCritical, "Result")


        ElseIf Hour >= 17.01 And Hour <= 20 Then
            MsgBox("Evening", vbCritical, "Result")


        ElseIf Hour >= 20 And Hour <= 24 Or Hour >= 0 And Hour <= 5.59 Then
            MsgBox("Night", vbCritical, "Result")

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class