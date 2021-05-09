Public Class digital_clock
    Private Sub digital_clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Label1.Text = Now
        ' Timer1.Enabled = True
        'Timer1.Interval = 300
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Label1.Text = TimeString   '24 hours
        Label1.Text = DateTime.Now.ToString("hh:mm:ss tt")   'time with AM and PM
        Label2.Text = DateTime.Now.ToString("dddd")   'Day
        Label4.Text = DateTime.Now.ToString("MMMM dd yyyy")   'Date

    End Sub

End Class