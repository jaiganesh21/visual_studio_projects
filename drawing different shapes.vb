Public Class drawing_different_shapes
    Dim xdown, ydown, xup, yup As Integer
    Dim c As String
    Dim w, h As Integer
    Dim g As Graphics

    'filter ellipse
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        c = "fe"
    End Sub

    Private Sub PictureBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseDown
        xdown = e.X
        ydown = e.Y
    End Sub

    Private Sub PictureBox1_MouseUp(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseUp
        '  xup = e.X
        ' xup = e.Y
        'w = xup - xdown
        ' h = yup - ydown
        '    g = PictureBox1.CreateGraphics()
        '  Select Case c
        '       Case "l"
        '      g.DrawLine(Pens.DarkGreen, xdown, ydown, xup, yup)
        '     Case "r"
        '    g.DrawRectangle(Pens.Orange, xdown, ydown, w, h)
        '   Case "fr"
        '  g.FillRectangle(Brushes.BlueViolet, xdown, ydown, w, h)
        ' Case "e"
        'g.DrawEllipse(Pens.Orange, xdown, ydown, w, h)
        'Case "fe"
        'g.FillEllipse(Brushes.Aqua, xdown, ydown, w, h)
        'End Select

        xup = e.X
        yup = e.Y
        w = xup - xdown
        h = yup - ydown
        g = PictureBox1.CreateGraphics()
        Select Case c
            Case "L"
                g.DrawLine(Pens.DarkGreen, xdown, ydown, xup, yup)
            Case "r"
                g.DrawRectangle(Pens.Red, xdown, ydown, w, h)
            Case "fr"
                g.FillRectangle(Brushes.BlueViolet, xdown, ydown, w, h)
            Case "e"
                g.DrawEllipse(Pens.DarkOrange, xdown, ydown, w, h)
            Case "fe"
                g.FillEllipse(Brushes.Aqua, xdown, ydown, w, h)
        End Select
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        PictureBox1.Refresh()
    End Sub


    'ellipse
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        c = "e"
    End Sub

    'filter rectangle
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        c = "fr"
    End Sub

    'rectangle
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        c = "r"
    End Sub

    'line
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        c = "L"
    End Sub

End Class