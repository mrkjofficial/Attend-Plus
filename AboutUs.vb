Public Class AboutUs
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer
    Private Sub TitleLabel_MouseDown(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseDown
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub
    Private Sub TitleLabel_MouseUp(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseUp
        If e.Button = MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub
    Private Sub TitleLabel_MouseMove(sender As Object, e As MouseEventArgs) Handles TitleLabel.MouseMove
        If IsFormBeingDragged Then
            Dim temp As Point = New Point With {
                .X = Location.X + (e.X - MouseDownX),
                .Y = Location.Y + (e.Y - MouseDownY)
            }
            Location = temp
            temp = Nothing
        End If
    End Sub
    Private Sub AboutUsPanel_Click(sender As Object, e As EventArgs) Handles AboutUsPanel.Click
        Close()
    End Sub
    Private Sub TechnoCodersPictureBox_Click(sender As Object, e As EventArgs) Handles TechnoCodersPictureBox.Click
        Close()
    End Sub
    Private Sub KaranPictureBox_Click(sender As Object, e As EventArgs) Handles KaranPictureBox.Click
        Close()
    End Sub
    Private Sub AnirbanMPictureBox_Click(sender As Object, e As EventArgs) Handles AnirbanMPictureBox.Click
        Close()
    End Sub
    Private Sub AnkurPictureBox_Click(sender As Object, e As EventArgs) Handles AnkurPictureBox.Click
        Close()
    End Sub
    Private Sub AngshudeepPictureBox_Click(sender As Object, e As EventArgs) Handles AngshudeepPictureBox.Click
        Close()
    End Sub
    Private Sub AnirbanBPictureBox_Click(sender As Object, e As EventArgs) Handles AnirbanBPictureBox.Click
        Close()
    End Sub
    Private Sub ChayanPictureBox_Click(sender As Object, e As EventArgs) Handles ChayanPictureBox.Click
        Close()
    End Sub
    Private Sub KaranNameLabel_Click(sender As Object, e As EventArgs) Handles KaranNameLabel.Click
        Close()
    End Sub
    Private Sub AnirbanMNameLabel_Click(sender As Object, e As EventArgs) Handles AnirbanMNameLabel.Click
        Close()
    End Sub
    Private Sub AnkurNameLabel_Click(sender As Object, e As EventArgs) Handles AnkurNameLabel.Click
        Close()
    End Sub
    Private Sub AngshudeepNameLabel_Click(sender As Object, e As EventArgs) Handles AngshudeepNameLabel.Click
        Close()
    End Sub
    Private Sub AnirbanBNameLabel_Click(sender As Object, e As EventArgs) Handles AnirbanBNameLabel.Click
        Close()
    End Sub
    Private Sub ChayanNameLabel_Click(sender As Object, e As EventArgs) Handles ChayanNameLabel.Click
        Close()
    End Sub
    Private Sub KaranPostLabel_Click(sender As Object, e As EventArgs) Handles KaranPostLabel.Click
        Close()
    End Sub
    Private Sub AnirbanMPostLabel_Click(sender As Object, e As EventArgs) Handles AnirbanMPostLabel.Click
        Close()
    End Sub
    Private Sub AnkurPostLabel_Click(sender As Object, e As EventArgs) Handles AnkurPostLabel.Click
        Close()
    End Sub
    Private Sub AngshudeepPostLabel_Click(sender As Object, e As EventArgs) Handles AngshudeepPostLabel.Click
        Close()
    End Sub
    Private Sub AnirbanBPostLabel_Click(sender As Object, e As EventArgs) Handles AnirbanBPostLabel.Click
        Close()
    End Sub
    Private Sub ChayanPostLabel_Click(sender As Object, e As EventArgs) Handles ChayanPostLabel.Click
        Close()
    End Sub
End Class