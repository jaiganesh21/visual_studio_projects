Public Class username_and_paswrd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TextBox1.Text = "BCA" And TextBox2.Text = "B" Then

            MsgBox("Successfully Login", vbInformation, "LOGIN_PAGE")

        Else
            MsgBox("Wrong Credentials", vbCritical, "LOGIN_PAGE")
        End If
    End Sub
End Class