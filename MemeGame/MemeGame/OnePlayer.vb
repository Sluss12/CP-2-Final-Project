Public Class OnePlayer
    'ball sides
    Dim BallLeft As Integer
    Dim BallRight As Integer
    Dim BallTop As Integer
    Dim BallBottom As Integer
    'walls
    Dim LeftWall As Integer
    Dim RightWall As Integer
    Dim TopWall As Integer
    Dim BottomWall As Integer
    'Bar
    Dim BarTop As Integer
    Dim BarLeft As Integer
    Dim Barright As Integer
    'others
    Dim bsX, bsY As Integer

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Me.Visible = False
        Start.Visible = True
    End Sub

    Private Sub OnePlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ball_Timer.Enabled = True
        bsX = 1
        bsY = 1
    End Sub

    Private Sub OnePlayer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        'left movement
        If e.KeyChar = "a" Then
            Asset_Bar.Left = Asset_Bar.Left - 5
        End If
        'right movement
        If e.KeyChar = "d" Then
            Asset_Bar.Left = Asset_Bar.Left + 5
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Asset_Ball.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Ball_Timer.Tick
        'Get Positions
        BallLeft = Asset_Ball.Left
        BallRight = Asset_Ball.Left + Asset_Ball.Width
        BallTop = Asset_Ball.Top
        BallBottom = Asset_Ball.Top + Asset_Ball.Height
        'walls
        LeftWall = Me.Left
        RightWall = Me.Left + Width
        TopWall = Me.Top
        BottomWall = Me.Top + Height
        'Bar
        BarTop = Asset_Bar.Top
        BarLeft = Asset_Bar.Left
        Barright = Asset_Bar.Left + Height

        'Movement
        Asset_Ball.Left = Asset_Ball.Left + bsX * 8
        Asset_Ball.Top = Asset_Ball.Top + bsY * 8

        If Asset_Ball.Left < 0 Then
            bsX = bsX * -1
        End If
        If Asset_Ball.Top < 0 Then
            bsY = bsY * -1
        End If
        If Asset_Ball.Left + Asset_Ball.Width > Me.Width Then
            bsX = bsX * -1
        End If
        If Asset_Ball.Top + Asset_Ball.Height > Me.Height Then
            bsY = bsY * -1
        End If
        If Asset_Ball.Top + Asset_Ball.Height > Asset_Bar.Top Then
            If Asset_Ball.Left > Asset_Bar.Left Then
                If Asset_Ball.Left + Asset_Ball.Width < Asset_Bar.Left + Asset_Bar.Width Then
                    bsX = bsX * 1
                    bsY = bsY * -1
                End If
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Point_counter.Tick
        'Point counter
        Dim points As Integer
        points = points + 1

    End Sub
End Class