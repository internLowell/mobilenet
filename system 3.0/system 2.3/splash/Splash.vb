Public NotInheritable Class Splash

    Private Sub Splash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SystemTitle.Text = My.Settings.title
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        My.Computer.Audio.Play(My.Resources.curve, AudioPlayMode.Background)
    End Sub

End Class
