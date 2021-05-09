Public Class bmi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim w, h, bmi As Double

        w = TextBox1.Text
        h = TextBox2.Text
        bmi = w / (h * h)
        TextBox3.Text = bmi
        If (bmi < 15.0) Then
            MsgBox("Severly Underweight")
        ElseIf (bmi >= 15.0 And bmi <= 18.0) Then
            MsgBox("Underweight")
        ElseIf (bmi >= 19.0 And bmi <= 25.0) Then
            MsgBox("Normal")
        ElseIf (bmi >= 25.0 And bmi <= 30.0) Then
            MsgBox("Overweight")
        Else
            MsgBox("Severe Obesity")
        End If
    End Sub
End Class