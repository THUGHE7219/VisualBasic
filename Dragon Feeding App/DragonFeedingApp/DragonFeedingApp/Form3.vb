Public Class Form3
    Dim flameOnClick As Boolean
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pbFlame.Hide()
        pbFlameOff.Hide()
        tmTime.Start()
        tmTemperature.Start()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub bFoodDrinks_Click(sender As Object, e As EventArgs) Handles bFoodDrinks.Click
        Form4.Show()
    End Sub

    Private Sub bFlameOn_Click(sender As Object, e As EventArgs) Handles pbFlameOn.Click
        pbFlame.Show()
        pbFlameOn.Hide()
        pbFlameOff.Show()
        flameOnClick = True
    End Sub

    Private Sub pbFlameOff_Click(sender As Object, e As EventArgs) Handles pbFlameOff.Click
        pbFlameOn.Show()
        pbFlame.Hide()
        pbFlameOff.Hide()
        flameOnClick = False
    End Sub

    Private Sub tmTemperature_Tick(sender As Object, e As EventArgs) Handles tmTemperature.Tick
        If flameOnClick = True Then
            Dim degrees As Integer
            degrees = CInt(lbDegrees.Text)
            Dim addDegrees = degrees + 1
            lbDegrees.Text = addDegrees
        Else
            Dim degrees As Integer
            degrees = CInt(lbDegrees.Text)
            Dim subtractDegrees = degrees - 1
            lbDegrees.Text = subtractDegrees
        End If
        If lbDegrees.Text = 100 Then
            pbDragon.Image = Image.FromFile("E:\Dragon Feeding App\DragonFeedingApp\dragonA\babyDragonA.png")
            pbFlame.Hide()
            flameOnClick = False
            pbFlameOff.Hide()
            pbFlameOn.Hide()
        End If
    End Sub

    Private Sub tmTime_Tick(sender As Object, e As EventArgs) Handles tmTime.Tick
        Dim time As Integer
        time = CInt(lbTimer.Text)
        Dim addTime = time + 1
        lbTimer.Text = addTime
    End Sub
End Class