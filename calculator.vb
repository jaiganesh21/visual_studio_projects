Public Class calculator

    Dim a As Decimal
    Dim b As Decimal
    Dim c As Integer
    'Dim operation As Boolean = False


    'button zero
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += "0"
    End Sub

    'button dot
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim s As String
        s = TextBox1.Text
        If Not s.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    'button clear
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()

    End Sub

    'button delete
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If TextBox1.Text.Length > 0 Then
            TextBox1.Text = TextBox1.Text.Remove(TextBox1.Text.Length - 1, 1)
        End If

        'If TextBox2.Text.Length > 0 Then
        'TextBox2.Text = TextBox2.Text.Remove(TextBox2.Text.Length - 1, 1)
        'End If

    End Sub

    'button end
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        End
    End Sub

    'button one
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text += "1"
    End Sub

    'button two
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text += "2"
    End Sub

    'button three
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += "3"
    End Sub

    'button four
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += "4"
    End Sub

    'button five
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text += "5"
    End Sub

    'button six
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text += "6"
    End Sub

    'button seven
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text += "7"
    End Sub

    'button eight
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text += "8"
    End Sub

    'button nine
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text += "9"
    End Sub

    'button addtion
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text += " + "
    End Sub

    'button subraction
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text += " - "
    End Sub

    'button multiplication
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text += " * "
    End Sub

    'button division
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text += " / "
    End Sub

    'button equal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim query As String = TextBox1.Text
        Dim result = New DataTable().Compute(query, Nothing)
        TextBox2.Text = result
    End Sub

    Private Sub calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class