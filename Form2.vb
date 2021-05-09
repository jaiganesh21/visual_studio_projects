Public Class Form2

    Dim a As Decimal
    Dim b As Decimal
    Dim c As Integer
    Dim operation As Boolean = False


    'butoon_1
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        TextBox1.Text += "1"
    End Sub

    'butoon_2
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click

        TextBox1.Text += "2"
    End Sub

    'butoon_3
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click

        TextBox1.Text += "3"

    End Sub

    'butoon_4
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        TextBox1.Text += "4"

    End Sub

    'butoon_5
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text += "5"

    End Sub

    'butoon_6
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text += "6"

    End Sub

    'butoon_7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text += "7"

    End Sub

    'butoon_8
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text += "8"

    End Sub

    'butoon_9
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text += "9"
    End Sub

    'butoon_0
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += "0"
    End Sub

    'butoon_dot
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim s As String
        s = TextBox1.Text
        If Not s.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    'clear_button
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = ""

    End Sub

    'addition_button
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        a = TextBox1.Text
        TextBox1.Text = ""
        c = 1
        operation = True

    End Sub

    'subraction_button
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        a = TextBox1.Text
        TextBox1.Text = ""
        c = 2
        operation = True
    End Sub

    'multiplication_button
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        a = TextBox1.Text
        TextBox1.Text = ""
        c = 3
        operation = True
    End Sub

    'division_button
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        a = TextBox1.Text
        TextBox1.Text = ""
        c = 4
        operation = True
    End Sub

    'equal_button
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If operation = True Then
            b = TextBox1.Text
            If c = 1 Then
                TextBox1.Text = a + b
            ElseIf c = 2 Then
                TextBox1.Text = a - b
            ElseIf c = 3 Then
                TextBox1.Text = a * b
            ElseIf b = 0 Then
                TextBox1.Text = "Error..!!"
            Else
                TextBox1.Text = a / b

            End If
        End If


    End Sub

    'delete_button
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If
    End Sub
End Class