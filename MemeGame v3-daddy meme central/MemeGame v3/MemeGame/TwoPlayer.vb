Imports System.Net
Imports System.Net.Sockets
Public Class TwoPlayer
    Dim tim As Integer = 60
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

    'network code
    Dim ball As String
    Dim paddle1 As String
    Dim paddle2 As String
    Dim server As Socket
    Dim listener As TcpListener
    Dim canstr As String
    Dim IPadress As String
    'Saving Scores
    Dim Path As String
    Dim Save As String
    Dim Arr(10) As String
    Dim i As Integer
    Dim j As Integer
    Dim Open As Integer
    Dim Higher As Boolean
    Dim Score As Integer
    Dim F, B As Integer
    Dim keysPressed As New HashSet(Of Keys)

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        End
    End Sub



    Private Sub OnePlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ball_Timer.Enabled = True
        bsX = 1
        bsY = 1
        Timer1.Enabled = True
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
        If Asset_Bar.Bounds.IntersectsWith(Asset_Ball.Bounds) Then
            bsX = bsX * 1
            bsY = bsY * -1
            My.Computer.Audio.Play("X:\MemeGame v3-daddy meme central\269718__michorvath__ping-pong-ball-hit.wav")
        ElseIf Asset_Bar2.Bounds.IntersectsWith(Asset_Ball.Bounds) Then
            bsX = bsX * 1
            bsY = bsY * -1
            My.Computer.Audio.Play("X:\MemeGame v3-daddy meme central\269718__michorvath__ping-pong-ball-hit.wav")
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Point_counter.Tick
        'Point counter
        Dim points As Integer
        points = points + 1

    End Sub


    Private Sub TwoPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StartGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'server side code here
        IPadress = InputBox("Enter Desired IP Adress")
        Timersend.Enabled = True
    End Sub

    Private Sub FindGameToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'client side code here

    End Sub

    Private Sub ConnectToPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timersend_Tick(sender As Object, e As EventArgs) Handles Timersend.Tick
        'get the item positions
        'sending and receiving the paddle positions
        canstr = paddle1 + paddle2 + ball
        server.Send(System.Text.Encoding.ASCII.GetBytes(canstr))
        Try
            Dim rcvbytes(server.ReceiveBufferSize) As Byte
            server.Receive(rcvbytes)
            'TextBox3.Text = System.Text.Encoding.ASCII.GetString(rcvbytes)
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Asset_Bar_Click(sender As Object, e As EventArgs) Handles Asset_Bar.Click

    End Sub

    Private Sub ViewHighscoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHighscoreToolStripMenuItem.Click
        Me.Visible = False
        HighScores.Visible = True
    End Sub

    Private Sub SaveHighscoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveHighscoreToolStripMenuItem.Click
        Dim TempInt As Integer
        Path = "X:\MemeGame v3-daddy meme central\MemeGame v3\HighScores.txt"
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
            Try
                Dim objWriter As New IO.StreamWriter(Path)
                Save = Arr(1)
                For i = 2 To j
                    Save = Save + vbNewLine + Arr(i)
                Next i
                objWriter.Write(Save)
                objWriter.Close()
                MessageBox.Show("Score saved")
                'Else
                MessageBox.Show("File Does Not Exist")
                'End If
            Catch ex As Exception
                MsgBox("The file specified could not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OkOnly, "File Could Not Be Opened!")
                Exit Sub
            End Try
        Else
            MsgBox("Your score didn't make it into the top 10!")
            Exit Sub
        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Movecount.Tick
#Region "Dank combo shit"


        'left movement
        If keysPressed.Contains(Keys.Left) AndAlso keysPressed.Contains(Keys.A) Then
            Asset_Bar.Left = Asset_Bar.Left - 5
            Asset_Bar2.Left = Asset_Bar2.Left - 5
        End If
        'right movement
        If keysPressed.Contains(Keys.Left) AndAlso keysPressed.Contains(Keys.D) Then
            Asset_Bar2.Left = Asset_Bar2.Left - 5
            Asset_Bar.Left = Asset_Bar.Left + 5
        End If
        If keysPressed.Contains(Keys.Right) AndAlso keysPressed.Contains(Keys.A) Then
            Asset_Bar.Left = Asset_Bar.Left - 5
            Asset_Bar2.Left = Asset_Bar2.Left + 5
        End If
        If keysPressed.Contains(Keys.Right) AndAlso keysPressed.Contains(Keys.D) Then
            Asset_Bar2.Left = Asset_Bar2.Left + 5
            Asset_Bar.Left = Asset_Bar.Left + 5
        End If
#End Region
#Region "Player One A and D movement"
        'left movement
        If keysPressed.Contains(Keys.A) Then
            Asset_Bar.Left = Asset_Bar.Left - 5
            'right movement
        ElseIf keysPressed.Contains(Keys.D) Then
            Asset_Bar.Left = Asset_Bar.Left + 5
        End If
#End Region
#Region "player2 arrowkey movement shit"
        If keysPressed.Contains(Keys.Left) Then
            Asset_Bar2.Left = Asset_Bar2.Left - 5
            'right movement
        ElseIf keysPressed.Contains(Keys.Right) Then
            Asset_Bar2.Left = Asset_Bar2.Left + 5
        End If
#End Region
    End Sub

    Private Sub BackToMainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainToolStripMenuItem.Click
        Me.Visible = False
        Start.Visible = True
    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles Timer1.Tick
        tim = tim - 1
        Label1.Text = "Time:" + Str(tim)
        If tim = 0 Then
            Ball_Timer.Enabled = False
            MsgBox("game over")

        End If
    End Sub

    Private Sub TwoPlayer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keysPressed.Add(e.KeyCode)

    End Sub

    Private Sub TwoPlayer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        keysPressed.Remove(e.KeyCode)
    End Sub
End Class