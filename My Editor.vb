
'my_Editor

Public Class My_Editor

    'New menuitem
    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        RichTextBox1.Clear()
        Me.Text = "Untitled"
    End Sub

    'open menutiem
    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        OpenFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (OpenFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.LoadFile(OpenFileDialog1.FileName,
           RichTextBoxStreamType.RichText)
            Me.Text = OpenFileDialog1.FileName
        End If

    End Sub

    'save menutiem
    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click

        SaveFileDialog1.Filter = "Text Files|*.txt|All Files|*.*"
        If (SaveFileDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SaveFile(SaveFileDialog1.FileName, RichTextBoxStreamType.RichText)
            Me.Text = SaveFileDialog1.FileName
        End If

    End Sub

    'exit_menutiem
    Private Sub ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem7.Click
        End
    End Sub

    'undo_button
    Private Sub ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem8.Click
        If (RichTextBox1.CanUndo()) Then
            RichTextBox1.Undo()
        End If
    End Sub

    'redo_menutiem
    Private Sub ToolStripMenuItem9_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem9.Click
        If (RichTextBox1.CanRedo()) Then
            RichTextBox1.Redo()
        End If
    End Sub

    'cut_menutiem
    Private Sub ToolStripMenuItem10_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem10.Click
        RichTextBox1.Cut()
    End Sub

    'copy_menutiem
    Private Sub ToolStripMenuItem11_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem11.Click
        RichTextBox1.Copy()
    End Sub

    'paste_menutiem
    Private Sub ToolStripMenuItem12_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem12.Click
        RichTextBox1.Paste()
    End Sub

    'selectall_menutiem
    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        RichTextBox1.SelectAll()
    End Sub

    'font_menutiem
    Private Sub ToolStripMenuItem14_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem14.Click
        If (FontDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SelectionFont = FontDialog1.Font
        End If
    End Sub

    'color_menutiem
    Private Sub ToolStripMenuItem15_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem15.Click
        If (ColorDialog1.ShowDialog() <> DialogResult.Cancel) Then
            RichTextBox1.SelectionColor = ColorDialog1.Color
        End If
    End Sub

    'about_us
    Private Sub ToolStripMenuItem16_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem16.Click
        Dim f As New My_editor_about_us
        f.Show()
    End Sub

    Private Sub ToolStripMenuItem17_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem17.Click
        PrintDialog1.ShowDialog()
    End Sub


End Class