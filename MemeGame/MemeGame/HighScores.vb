Public Class HighScores
    Public Shared Path As String
    Public Shared Save As String
    Public Shared Arr(10) As Integer
    Public Shared i As Integer
    Public Shared j As Integer
    Public Shared Open As Integer
    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TempInt As Integer
        Path = "L:\MemeGame (1)\HighScores.txt"
        Try
            ' Create new StreamReader instance with Using block.
            Using reader As IO.StreamReader = New IO.StreamReader(Path)
                ' Read one line from file
                i = 1
                Do Until reader.Peek = -1
                    Open = reader.ReadLine()
                    'EXPORT!!!!
                    'lstScores.Items.Add(Open)
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
            lstScores.Items.Add(Arr(i))
        Next
    End Sub

    Private Sub BackToGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToGameToolStripMenuItem.Click
        Me.Visible = False
        OnePlayer.Visible = True
        OnePlayer.ResumeToolStripMenuItem.Select()
    End Sub
End Class