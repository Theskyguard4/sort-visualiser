Module mergesort
    
    Function mergesorting(ByVal items() As thingstosort, ByVal howmany As Integer)
        Dim groupsize As Integer = 1
        Dim isodd As Boolean = False
        Dim howmanys As Integer
        Dim u As Integer
        If howmany + 1 Mod 2 = 1 Then
            isodd = True
        Else
            isodd = False

        End If
        If isodd = True Then
            For x = 0 To (howmany / groupsize) - 2 Step groupsize + 1
                For y = 0 To groupsize
                    u = y + x
                    If items(u).getvalue > items(u + 1).getvalue Then
                        Form1.tempitem = items(u)
                        items(u) = items(u + 1)
                        items(u + 1) = Form1.tempitem
                        items(u).draw(u)
                        items(u + 1).draw(u + 1)

                    End If

                Next
            Next
        Else

            Do Until groupsize >= howmany + 1
                For x = 0 To (howmany / groupsize) - 2 Step groupsize * 2
                    For y = 0 To groupsize
                        u = y + x
                        If items(u).getvalue > items(u + 1).getvalue Then
                            Form1.tempitem = items(u)
                            items(u) = items(u + 1)
                            items(u + 1) = Form1.tempitem
                            items(u).draw(u)
                            items(u + 1).draw(u + 1)

                        End If

                    Next
                Next
                groupsize = groupsize * 2
            Loop

            
            
        End If
      


    End Function
End Module
