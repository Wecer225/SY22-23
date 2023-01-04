Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For row = 0 To 40
            For col = 0 To 40
                CreatePicture(PictureBox1, row, col)
            Next
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For row = 0 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For row = 0 To 20
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Green
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For Row = 0 To 40
            For col = 0 To 20
                GetPicture(Row, col).BackColor = Color.Red
            Next
        Next

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Row = 0 To 40
            For col = 0 To 40 Step 2
                GetPicture(Row, col).BackColor = Color.Purple
            Next
        Next

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For Row = 0 To 40 Step 2
            For col = 0 To 40 Step 2
                GetPicture(Row, col).BackColor = Color.Yellow
            Next
        Next

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For row = 0 To 40
            For col = 0 To 40
                If row Mod 2 = 0 Then
                    GetPicture(row, col).BackColor = Color.Black
                End If
            Next
        Next

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For row = 0 To 40
            For col = 0 To 40
                If col < row Then
                    GetPicture(row, col).BackColor = Color.Aqua
                End If
            Next
        Next

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For row = 0 To 40
            For col = 40 - row To 40

                GetPicture(row, col).BackColor = Color.Orange
            Next
        Next
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For Row = 0 To 40
            For col = 20 To 40
                GetPicture(Row, col).BackColor = Color.Red
            Next
        Next
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        For row = 20 To 40
            For col = 0 To 40
                GetPicture(row, col).BackColor = Color.Green
            Next
        Next
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        For Row = 0 To 40 Step 5
            For col = 0 To 40 Step 5
                GetPicture(Row, col).BackColor = Color.Pink
            Next
        Next

    End Sub
End Class
