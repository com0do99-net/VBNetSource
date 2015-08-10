Public Class IMain

    Private fStartStop As Boolean
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        If Me.fStartStop Then
            Me.fStartStop = False
            Me.button1.Text = "Start"
            timer1.Stop()
        Else
            Me.fStartStop = True
            Me.button1.Text = "Stop"
            timer1.Start()
        End If
    End Sub

    Private Sub timer1_Tick(sender As Object, e As EventArgs) Handles timer1.Tick
        If textBoxProcess.Text <> String.Empty Then
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value) * 1000
            WorkingSet.setMaximizeProcess(textBoxProcess.Text, 568000, 568000)
        End If
    End Sub
End Class
