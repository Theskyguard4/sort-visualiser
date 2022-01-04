Module quicksort
    Sub checkishighlow(ByRef items() As thingstosort, ByVal pivot As Integer, ByVal howmany As Integer)
        Form1.isxokay = False
        Form1.isyokay = False
        Dim x2 As Integer
        Dim y2 As Integer
        For x = 0 To pivot
            If items(x).getvalue >= items(pivot).getvalue Then
                Form1.tempitem = items(x)
                Form1.isxokay = True
                x2 = x
                x = pivot
            End If
        Next
        For y = howmany To pivot Step -1
            If items(y).getvalue <= items(pivot).getvalue Then
                Form1.tempitem2 = items(y)
                Form1.isyokay = True
                y2 = y
                y = pivot
            End If
        Next
        If Form1.isyokay = True And Form1.isxokay = True Then
            If y2 = pivot And x2 = pivot Then
            Else
                'items(x2).deleteline()
                'items(y2).deleteline()
                items(x2) = Form1.tempitem2
                items(y2) = Form1.tempitem


                items(x2).draw(x2)
                items(y2).draw(y2)
            End If
            
        End If
    End Sub
End Module
