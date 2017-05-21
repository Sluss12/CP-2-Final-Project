Public Class Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("controls: A & D for player 1 and right and left arrow keys for player two") = vbOK Then
            Me.Visible = False
            OnePlayer.Visible = True
        Else
            OnePlayer.Visible = False
            Me.Visible = True
        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Visible = False
        TwoPlayer.Visible = True
    End Sub
End Class
