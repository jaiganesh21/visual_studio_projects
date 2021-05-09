Public Class moving_object
    'start button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Interval = 300
        Timer1.Enabled = True

    End Sub

    'stop button
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'left
        If (RadioButton1.Checked) Then
            '    PictureBox1.Left -= 30
            If PictureBox1.Left > 0 Then
                PictureBox1.Left -= 30
            Else
                PictureBox1.Left = Me.Width
            End If
        End If

        'Right
        If (RadioButton2.Checked) Then
            If PictureBox1.Left < Me.Width Then
                PictureBox1.Left += 30
            Else
                PictureBox1.Left = 0
            End If
        End If
        'Up
        If (RadioButton3.Checked) Then
            If PictureBox1.Top > 0 Then
                PictureBox1.Top -= 30
            Else
                PictureBox1.Top = Me.Height
            End If
        End If
        'Down
        If (RadioButton4.Checked) Then
            If PictureBox1.Top < Me.Height Then
                PictureBox1.Top += 30
            Else
                PictureBox1.Top = 0
            End If
        End If

    End Sub


End Class