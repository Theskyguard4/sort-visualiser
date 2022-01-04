Public Class thingstosort
    Protected value As Integer
    Protected height As Integer
    Protected visrep As TextBox
    Sub New()

        Me.visrep = New TextBox
        Me.value = New Integer
        Me.visrep.Multiline = True
        Me.visrep.BackColor = Color.Aqua
        

    End Sub
    Public Sub getrandomval()
        getrandomvalue()
    End Sub
    Public Sub draw(ByVal x As Integer)

        setheight()
        Me.visrep.SetBounds(x * 10 + 10, 420 - Me.value, 5, Me.value)
        deleteline()
        Form1.Controls.Add(Me.visrep)

    End Sub
    Public Sub setheight()
        Me.height = Me.value


    End Sub
    Public Function getheight()

    End Function
    Public Function getvalue()
        Return Me.value

    End Function
    Public Sub setvalue(ByVal newvalue)

    End Sub
    Public Sub getrandomvalue()

        Me.value = Int((Rnd() * 360) + 5)


    End Sub
    Public Sub deleteline()
        Form1.Controls.Remove(Me.visrep)
    End Sub
End Class
