Public Class Form1
    Private Sub bHowToPlay_Click(sender As Object, e As EventArgs) Handles bHowToPlay.Click
        Form2.Show()
    End Sub

    Private Sub bStart_Click(sender As Object, e As EventArgs) Handles bStart.Click
        Form3.Show()
    End Sub


    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
