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

    Private Sub Clearbutton_Click(sender As Object, e As EventArgs) Handles Clearbutton.Click
        clear()
    End Sub

    Private Sub Button101_Click(sender As Object, e As EventArgs)
        fill(sender.backcolor)
    End Sub


    Private Sub Button51_MouseMove(sender As Object, e As MouseEventArgs) Handles Button99.MouseMove, Button98.MouseMove, Button97.MouseMove, Button96.MouseMove, Button95.MouseMove, Button94.MouseMove, Button93.MouseMove, Button92.MouseMove, Button91.MouseMove, Button90.MouseMove, Button9.MouseMove, Button89.MouseMove, Button88.MouseMove, Button87.MouseMove, Button86.MouseMove, Button85.MouseMove, Button84.MouseMove, Button83.MouseMove, Button82.MouseMove, Button81.MouseMove, Button80.MouseMove, Button8.MouseMove, Button79.MouseMove, Button78.MouseMove, Button77.MouseMove, Button76.MouseMove, Button75.MouseMove, Button74.MouseMove, Button73.MouseMove, Button72.MouseMove, Button71.MouseMove, Button70.MouseMove, Button7.MouseMove, Button69.MouseMove, Button68.MouseMove, Button67.MouseMove, Button66.MouseMove, Button65.MouseMove, Button64.MouseMove, Button63.MouseMove, Button62.MouseMove, Button61.MouseMove, Button60.MouseMove, Button6.MouseMove, Button59.MouseMove, Button58.MouseMove, Button57.MouseMove, Button56.MouseMove, Button55.MouseMove, Button54.MouseMove, Button53.MouseMove, Button52.MouseMove, Button51.MouseMove, Button50.MouseMove, Button5.MouseMove, Button49.MouseMove, Button48.MouseMove, Button47.MouseMove, Button46.MouseMove, Button45.MouseMove, Button44.MouseMove, Button43.MouseMove, Button42.MouseMove, Button41.MouseMove, Button40.MouseMove, Button4.MouseMove, Button39.MouseMove, Button38.MouseMove, Button37.MouseMove, Button36.MouseMove, Button35.MouseMove, Button34.MouseMove, Button33.MouseMove, Button32.MouseMove, Button31.MouseMove, Button30.MouseMove, Button3.MouseMove, Button29.MouseMove, Button28.MouseMove, Button27.MouseMove, Button26.MouseMove, Button25.MouseMove, Button24.MouseMove, Button23.MouseMove, Button22.MouseMove, Button21.MouseMove, Button20.MouseMove, Button2.MouseMove, Button19.MouseMove, Button18.MouseMove, Button17.MouseMove, Button16.MouseMove, Button15.MouseMove, Button14.MouseMove, Button13.MouseMove, Button12.MouseMove, Clearbutton.MouseMove, Button100.MouseMove, Button10.MouseMove, Button1.MouseMove
        sender.backcolor = drawcolor
    End Sub
    Private Sub Button104_Click(sender As Object, e As EventArgs) Handles Button105.Click, Button104.Click, Button103.Click, Button102.Click, Button101.Click
        drawcolor = sender.backcolor
    End Sub
End Class
