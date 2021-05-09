Public Class Form1

    'ADDITION_button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Integer
        sum = Val(TextBox1.Text) + Val(TextBox2.Text)
        TextBox3.Text = sum

    End Sub

    'End_button
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    'Clear_button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1.Clear()


    End Sub
    'sub button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim sum As Integer
        sum = Val(TextBox1.Text) - Val(TextBox2.Text)
        TextBox3.Text = sum
    End Sub

    'multiplaction_button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sum As Integer
        sum = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox3.Text = sum
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim sum As Integer
        sum = Val(TextBox1.Text) / Val(TextBox2.Text)
        TextBox3.Text = sum
    End Sub



    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim sum As Integer
        sum = Val(TextBox1.Text) Mod Val(TextBox2.Text)
        TextBox3.Text = sum
    End Sub
End Class