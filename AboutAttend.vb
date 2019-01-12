Public Class AboutAttend
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
    Private Sub AboutAttendPanel_Click(sender As Object, e As EventArgs) Handles AboutAttendPanel.Click
        Close()
    End Sub
    Private Sub AboutLogoPictureBox_Click(sender As Object, e As EventArgs) Handles AboutLogoPictureBox.Click
        Close()
    End Sub
    Private Sub AboutTitleLabel_Click(sender As Object, e As EventArgs) Handles AboutTitleLabel.Click
        Close()
    End Sub
    Private Sub AboutVersionLabel_Click(sender As Object, e As EventArgs) Handles AboutVersionLabel.Click
        Close()
    End Sub
    Private Sub AboutInfoLabel_Click(sender As Object, e As EventArgs) Handles AboutInfoLabel.Click
        Close()
    End Sub
    Private Sub AboutDesignerLabel_Click(sender As Object, e As EventArgs) Handles AboutDesignerLabel.Click
        Close()
    End Sub
End Class