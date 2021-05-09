Public Class student_marks

    'Private Sub calculate()
    'Dim total As Double
    '   total = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
    '  TextBox5.Text = total
    ' TextBox6.Text = total / 3

    'If Val(TextBox2.Text) >= 40 And Val(TextBox3.Text) >= 40 And Val(TextBox4.Text) >= 40 Then
    '       TextBox7.Text = "Pass"
    'Else
    '       TextBox7.Text = "Fail"
    'End If
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total, per As Double
        total = Val(TextBox2.Text) + Val(TextBox3.Text) + Val(TextBox4.Text)
        TextBox5.Text = total
        per = total / 3
        TextBox6.Text = per

        If Val(TextBox2.Text) >= 40 And Val(TextBox3.Text) >= 40 And Val(TextBox4.Text) >= 40 Then
       '     If per >= 100 And per <= 70 Then

            TextBox7.Text = "Pass"
        Else
            TextBox7.Text = "Fail"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub



    'Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
    '   calculate()

    ' End Sub

    'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
    '   calculate()

    ' End Sub

    ' Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
    '    calculate()

    'End Sub

End Class