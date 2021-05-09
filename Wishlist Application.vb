Public Class Wishlist_Application
    Private Sub Wishlist_Application_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("EAT")
        ComboBox1.Items.Add("CODE")
        ComboBox1.Items.Add("SLEEP")
        ComboBox1.Items.Add("REPEAT")
        ComboBox1.Items.Add("I LOVE CODING")
        ComboBox1.Items.Add("HAVE A BEST YEAR")
        ComboBox1.Items.Add("LEARN MORE GAIN MORE")
    End Sub

    'add wish
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ListBox1.Items.IndexOf(ComboBox1.Text) = -1) Then
            ListBox1.Items.Add(ComboBox1.Text)
            TextBox1.Text = ListBox1.Items.Count
        End If
    End Sub

    'delete wish
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (ListBox1.SelectedIndex = -1) Then
            MsgBox("select item to be deleted")
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
            TextBox1.Text = ListBox1.Items.Count
        End If
    End Sub

    'sorts
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        ListBox1.Sorted = True
    End Sub

    'exit
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        End
    End Sub

    'clear
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ListBox1.Items.Clear()

    End Sub
End Class