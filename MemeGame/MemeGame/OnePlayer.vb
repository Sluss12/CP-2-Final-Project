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

#End Region

    'high score loader
    Sub LoadScores()
        Path = "L:\MemeGame\HighScores.txt"
        'load text file to check if they top a highscore
        Try
            ' Create new StreamReader instance with Using block.
            Using reader As IO.StreamReader = New IO.StreamReader(Path)
                ' Read one line from file
                i = 1
                Do Until reader.Peek = -1
                    Open = reader.ReadLine()
                    Arr(i) = Open
                    i = i + 1
                Loop
            End Using
            ' Write the line we read from "file.txt"
            Console.WriteLine(Open)
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
        Lives = 3
        bsX = 1
        bsY = 1
        LoadScores()
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
        Dim TempInt As Integer
        'Test if score is higher than lowest highscore
        If Score > Arr(10) Then
            Arr(10) = Score
            Higher = True
        End If
        'If score is higher then sort and save highscore
        If Higher = True Then
            For F = 1 To 10 - 1
                For B = F + 1 To 10
                    If Arr(F) > Arr(B) Then
                        TempInt = Arr(F)
                        Arr(F) = Arr(B)
                        Arr(B) = TempInt
                    End If
                Next B
            Next F
            For i = 1 To 10
                SaveArr(i) = Arr(i)
            Next i
            Path = "L:\MemeGame\HighScores.txt"
            Try
                Dim objWriter As New IO.StreamWriter(Path)
                Save = SaveArr(1)
                For i = 2 To j
                    Save = Save + vbNewLine + SaveArr(i)
                Next i
                objWriter.Write(Save)
                objWriter.Close()
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
            Point_counter.Enabled = False
            Ball_Timer.Enabled = False
        End If
    End Sub

    'score timer
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Point_counter.Tick
        'Point counter
        Score = Score + 1
        lblScore.Text = "Your Score: " & Score
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