Public Module Moveimpl

    Public Sub setmoveable(ByRef cts() As Control, ByRef _fm As Form)
        Dim mv As New moveclass(cts, _fm)
    End Sub

    Public Class moveclass
        Dim prevposx As Integer
        Dim prevposy As Integer

        Dim fm As Form

        Public Sub New(ByRef ct As Control, ByRef _fm As Form)
            fm = _fm
            AddHandler ct.MouseMove, AddressOf ctl_MouseMove
        End Sub
        Public Sub New(ByRef cts() As Control, ByRef _fm As Form)
            fm = _fm
            cts.ToList().ForEach(Sub(c) AddHandler c.MouseMove, AddressOf ctl_MouseMove)

        End Sub

        Private Sub ctl_MouseMove(sender As Object, e As MouseEventArgs)
            If e.Button = Windows.Forms.MouseButtons.Left Then
                Dim difx = prevposx - e.X
                Dim dify = prevposy - e.Y
                fm.Location = New Point(fm.Location.X - difx, fm.Location.Y - dify)
            Else
                prevposx = e.X
                prevposy = e.Y
            End If
        End Sub
    End Class
End Module
