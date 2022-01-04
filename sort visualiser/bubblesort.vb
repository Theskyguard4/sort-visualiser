Module bubblesort
    Sub shouldswap(ByVal items() As thingstosort, ByVal x As Integer, ByRef isdone As Boolean)

        If items(x).getvalue > items(x + 1).getvalue Then
            isdone = False
            Form1.tempitem = items(x)
            items(x) = items(x + 1)
            items(x + 1) = Form1.tempitem
            items(x).draw(x)
            items(x + 1).draw(x + 1)

        End If
    End Sub
End Module
