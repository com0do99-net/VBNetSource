Public Class IMain

    '
    '         * Read more command
    '         * https://www.bitvise.com/files/tunnelier-params.txt
    '

    Private fStartStop As Boolean
    Private command As String
    Private location As String

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        location = Application.StartupPath + "\App\BvSsh.exe"
        If Me.fStartStop Then
            Me.fStartStop = False
            Me.btnStart.Text = "Start"

            command = " -host=" + txtHost.Text & " -port=" + txtPortHost.Text & " -username=" + txtusername.Text & " -password=" + txtPassword.Text & " -loginOnStartup -title=[com0do99.net]SshTunnel" & " -proxy=n" & " -proxyUsername=" + txtusername.Text & " -proxyPassword=" + txtPassword.Text
            Process.Start(location, command)
        Else
            Me.fStartStop = True
            Me.btnStart.Text = "Stop"
            StopBvSsh("BvSsh.exe")
        End If
    End Sub

    Private Sub StopBvSsh(name As String)
        Dim pcs As Process()
        pcs = Process.GetProcessesByName(name)
        If pcs.Length > 0 Then
            For Each tn As Process In pcs
                tn.Kill()
            Next
        End If
    End Sub
End Class
