Public Class FrPanel
    Public WriteOnly Property setnro() As String
        Set(value As String)
            Label1.Text = Label1.Text.Split(":")(0) & ": " & value
        End Set
    End Property
    Public WriteOnly Property setpos() As String
        Set(value As String)
            Label2.Text = Label2.Text.Split(":")(0) & ": " & value
        End Set
    End Property
    Public WriteOnly Property setfaltam() As String
        Set(value As String)
            Label3.Text = Label3.Text.Split(":")(0) & ": " & value
        End Set
    End Property

    Private Sub FrPanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setmoveable({Label1, Label2, Label3, Me}, Me)
    End Sub
End Class