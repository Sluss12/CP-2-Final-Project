Public Class HighScores
    Public Shared Path As String
    Public Shared Save As String
    Public Shared Arr(10) As Integer
    Public Shared i As Integer
    Public Shared j As Integer
    Public Shared Open As Integer
    Structure top10
        Dim name As String
        Dim score As String

    End Structure
    Dim topt(10) As top10

    Private Sub HighScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim TempInt As top10
        Path = "X:\MemeGame v3-daddy meme central\MemeGame v3\HighScores.txt"
        Try
            Dim t As Integer
            Dim arrin(10) As String
            t = 1
            FileOpen(1, Path, OpenMode.Input)
            Do While Not EOF(1)
                arrin(t) = LineInput(1)        'filling up an array
                topt(t).name = Mid(arrin(t), 1, 3)
                topt(t).score = Int(Mid(arrin(t), 4))
                t = t + 1
            Loop
            FileClose(1)
            'error check
        Catch ex As Exception
            MsgBox("The file specified could not be opened." & vbNewLine & "Error message:" & vbNewLine & vbNewLine & ex.Message, MsgBoxStyle.OkOnly, "File Could Not Be Opened!")
            Exit Sub
        End Try
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
            lstScores.Items.Add(topt(i).name + "--" + topt(i).score)
        Next
    End Sub

    Private Sub BackToGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToGameToolStripMenuItem.Click
        Me.Visible = False
        OnePlayer.Visible = True
        OnePlayer.ResumeToolStripMenuItem.Select()
    End Sub

    Private Sub MenuStrip2_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip2.ItemClicked

    End Sub
End Class