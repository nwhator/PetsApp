Public Class Form1
    Dim draggable As Boolean
    Dim mouseX As Integer
    Dim mouseY As Integer
    Private Sub UC_Home1_MouseDown(sender As Object, e As MouseEventArgs) Handles UC_Home1.MouseDown
        draggable = True
        mouseX = Cursor.Position.X - Me.Left
        mouseY = Cursor.Position.Y - Me.Top
    End Sub
    Private Sub UC_Home1_MouseMove(sender As Object, e As MouseEventArgs) Handles UC_Home1.MouseMove
        If draggable Then
            Me.Top = Cursor.Position.Y - mouseY
            Me.Left = Cursor.Position.X - mouseX
        End If
    End Sub
    Private Sub UC_Home1_MouseUp(sender As Object, e As MouseEventArgs) Handles UC_Home1.MouseUp
        draggable = False
    End Sub

End Class
