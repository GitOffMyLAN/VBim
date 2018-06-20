Public Class about

    Private Sub OpenGitHub_Click(sender As Object, e As EventArgs) Handles OpenGitHub.Click
        Dim webAddress As String = "https://github.com/GitOffMyLAN/VBim"
        Process.Start(webAddress)
    End Sub

    Private Sub OpenSad_Click(sender As Object, e As EventArgs) Handles OpenSad.Click
        Process.Start("C:\Users\jscanlan\Videos\VBim\VBim\VBim\img\cfb.png")
    End Sub
End Class