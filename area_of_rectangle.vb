Public Class area_of_rectangle
    Dim l, b, preimeter, area As Integer

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        preimeter = 2 * (Val(TextBox1.Text) + Val(TextBox2.Text))
        TextBox4.Text = preimeter

        area = Val(TextBox1.Text) * Val(TextBox2.Text)
        TextBox3.Text = area



    End Sub
End Class