Public Class shopping_cart
    'Total button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double = 0
        If CheckBox1.Checked Then
            total += 65000
        End If

        If CheckBox2.Checked Then
            total += 45000
        End If

        If CheckBox3.Checked Then
            total += 58999
        End If

        If CheckBox4.Checked Then
            total += 72346
        End If

        TextBox1.Text = total

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        TextBox1.Clear()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub


End Class