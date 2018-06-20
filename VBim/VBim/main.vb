Public Class main

    Private Sub OptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionToolStripMenuItem.Click
        options.Show()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog.ShowDialog()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        about.show()
    End Sub
End Class