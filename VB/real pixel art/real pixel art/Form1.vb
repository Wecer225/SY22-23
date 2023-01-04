Public Class Form1
    Dim drawcolor As Color
    Sub clear()
        For index = 1 To 100
            Controls("button" & index).BackColor = Color.White
        Next
    End Sub
    Sub fill(c As Color)
        For index = 1 To 100
            Controls("button" & index).BackColor = c
        Next
    End Sub

    Private Sub Clearbutton_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear()
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs)
        fill(sender.backcolor)
    End Sub

End Class
