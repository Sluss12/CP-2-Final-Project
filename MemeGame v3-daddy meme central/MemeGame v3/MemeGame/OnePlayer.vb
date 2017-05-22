Public Class OnePlayer
#Region "Dims"
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
    Dim tim As Integer

    'Saving Scores
    Dim Path As String
    Dim Save As String
    Dim Arr(10) As Integer
    Dim SaveArr(10) As String
    Dim i As Integer
    Dim j As Integer
    Dim Open As Integer
    Dim Higher As Boolean
    Dim Score As Integer
    Dim F, B As Integer
    'lifes
    Dim Lives As Integer
    Structure top10
        Dim score As Long
        Dim name As String
    End Structure
    Dim topt(10) As top10


#End Region

    'high score loader
    Sub LoadScores()
        Path = "X:\MemeGame v3-daddy meme central\MemeGame v3\HighScores.txt"
        'load text file to check if they top a highscore
        Try
            ' Create new StreamReader instance with Using block.
            Dim t As Integer
            Dim arrin(10) As String
            t = 0
            FileOpen(1, Path, OpenMode.Input)
            Do While Not EOF(1)
                arrin(t) = LineInput(1)        'filling up an array
                topt(t).name = Mid(arrin(t), 1, 3)
                topt(t).score = Int(Mid(arrin(t), 4))
                i = i + 1
            Loop
            FileClose(1)

            ' Write the line we read from "file.txt"
            'error check
        Catch ex As Exception
            MsgBox("The file specified could not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OkOnly, "File Could Not Be Opened!")
            Exit Sub
        End Try
    End Sub
    'quit
    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub

    'main menu return
    Private Sub BackToMainMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainMenuToolStripMenuItem.Click
        Me.Visible = False
        Start.Visible = True
        Ball_Timer.Enabled = False
        Point_counter.Enabled = False
    End Sub

    'form load 
    Private Sub OnePlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ball_Timer.Enabled = True
        Point_counter.Enabled = True
        LifeChecker.Enabled = True
        Lives = 3
        bsX = 1
        bsY = 1
        LoadScores()
        tim = 1
    End Sub

    'ball movement
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

#Region "Movement"
        Asset_Ball.Left = Asset_Ball.Left + bsX * 8
        Asset_Ball.Top = Asset_Ball.Top + bsY * 8

        If Asset_Ball.Left < 0 Then
            bsX = bsX * -1
        End If
        If Asset_Ball.Top < 0 Then
            My.Computer.Audio.Play("X:\MemeGame v3-daddy meme central\269718__michorvath__ping-pong-ball-hit.wav")
            bsY = bsY * -1
        End If
        If Asset_Ball.Left + Asset_Ball.Width > Me.Width Then
            bsX = bsX * -1
        End If
        If Asset_Ball.Top + Asset_Ball.Height > Me.Height Then
            bsY = bsY * -1
            Lives = Lives - 1

        End If
        If Asset_Bar.Bounds.IntersectsWith(Asset_Ball.Bounds) Then
            bsX = bsX * 1
            bsY = bsY * -1
            My.Computer.Audio.Play("X:\MemeGame v3-daddy meme central\269718__michorvath__ping-pong-ball-hit.wav")
        End If
#End Region
        lblLives.Text = "Your Lives: " & Lives
    End Sub

    'view scores
    Private Sub ViewHighscoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHighscoresToolStripMenuItem.Click
        Me.Visible = False
        HighScores.Visible = True
        Ball_Timer.Enabled = False
        Point_counter.Enabled = False
    End Sub

    'game pause when clicking high score menu button
    Private Sub HighScoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighScoresToolStripMenuItem.Click
        Ball_Timer.Enabled = False
        Point_counter.Enabled = False
    End Sub

    'resume button
    Private Sub ResumeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResumeToolStripMenuItem.Click
        Ball_Timer.Enabled = True
        Point_counter.Enabled = True
    End Sub

    'game pause when clicking settings menu button
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Ball_Timer.Enabled = False
        Point_counter.Enabled = False
    End Sub

    'score saving
    Private Sub SaveYourScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveYourScoreToolStripMenuItem.Click
        Dim TempInt As top10
        'Test if score is higher than lowest highscore
        If Score > topt(10).score Then
            topt(10).score = Score
            topt(10).name = UCase(Mid(InputBox("enter 3 letter name"), 1, 3))
            Higher = True
        End If
        'If score is higher then sort and save highscore
        If Higher = True Then
            For F = 1 To 10 - 1
                For B = F + 1 To 10
                    If topt(F).score > topt(B).score Then
                        TempInt = topt(F)
                        topt(F) = topt(B)
                        topt(B) = TempInt
                    End If
                Next B
            Next F
            For i = 1 To 10
                SaveArr(i) = topt(i).name & topt(i).score
            Next i
            Path = "X:\MemeGame v3-daddy meme central\MemeGame v3\HighScores.txt"
            Try
                Dim m As Integer
                FileOpen(1, Path, OpenMode.Output)
                For m = 1 To 10
                    PrintLine(1, SaveArr(m))
                Next m
                FileClose(1)
                MessageBox.Show("Score saved")
            Catch ex As Exception
                MsgBox("The file specified could not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OkOnly, "File Could Not Be Opened!")
                Exit Sub
            End Try
        Else
            MsgBox("Your score didn't make it into the top 10!")
            Exit Sub
        End If
    End Sub

    'life check for end game
    Private Sub LifeChecker_Tick(sender As Object, e As EventArgs) Handles LifeChecker.Tick
        If Lives <= 0 Then
            tim = tim - 1
            If tim = 0 Then
                Point_counter.Enabled = False
                Ball_Timer.Enabled = False
                ResumeToolStripMenuItem.Enabled = False
                MsgBox("game over")
            End If
        End If

    End Sub

    Private Sub Asset_Ball_Click(sender As Object, e As EventArgs) Handles Asset_Ball.Click

    End Sub

    'score timer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Point_counter.Tick
        'Point counter
        Score = Score + 1
        lblScore.Text = "Your Score: " & Score
        If Score = 51 Then
            Ball_Timer.Interval = 50
        End If
    End Sub

    'a and d movement
    Private Sub OnePlayer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
#Region "Player One A and D movement"
        'left movement
        If e.KeyCode = Keys.A Then
            Asset_Bar.Left = Asset_Bar.Left - 5
        End If
        'right movement
        If e.KeyCode = Keys.D Then
            Asset_Bar.Left = Asset_Bar.Left + 5
        End If
#End Region
    End Sub
End Class