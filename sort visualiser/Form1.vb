Public Class Form1
    Dim isgraphon As Boolean = False
    Public items() As thingstosort
    Dim howmanyitems As Integer
    Public tempitem As New thingstosort
    Public tempitem2 As New thingstosort
    Public tempitem3 As New thingstosort
    Public isxokay As Boolean
    Public isyokay As Boolean
    Public isokaycheck As Boolean
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Randomize()


    End Sub

    

    Private Sub createnewgraphbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles createnewgraphbut.Click
        

        If howmanyitemsinputbox.Text <> "" Then
            If howmanyitemsinputbox.Text < 130 And howmanyitemsinputbox.Text >= 5 Then
                

                howmanyitems = howmanyitemsinputbox.Text - 1
                TrackBar1.Value = howmanyitems

               

                If isgraphon = False Then
                    ReDim Preserve items(howmanyitems)
                End If


                For x = 0 To howmanyitems
                    If isgraphon = False Or x > items.Length - 1 Then
                        ReDim Preserve items(x)
                        items(x) = New thingstosort
                    End If

                    items(x).getrandomval()
                    items(x).deleteline()
                    items(x).draw(x)
                Next
                If howmanyitems < items.Length Then
                    For y = howmanyitems To items.Length - 1
                        items(y).deleteline()
                    Next
                End If
                isgraphon = True
                ReDim Preserve items(howmanyitems)

            Else
                MsgBox("Error: number must be above 4 and below 131")
                howmanyitemsinputbox.Text = ""
            End If

        End If

    End Sub

    Private Sub bubblesortbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bubblesortbut.Click
        If howmanyitems > 4 And howmanyitems <= 130 Then
            bubblesortbut.BackColor = Color.Red
            bubblesortbut.Update()

            Dim isdone As Boolean = False

            Do Until isdone = True
                isdone = True
                For x = 0 To howmanyitems - 1
                    bubblesort.shouldswap(items, x, isdone)



                Next
            Loop

        Else
            MsgBox("Error: No Values To Sort")
        End If
        bubblesortbut.BackColor = Color.Gainsboro
        bubblesortbut.Update()
    End Sub


    Private Sub quicksortbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quicksortbut.Click




        If howmanyitems > 4 And howmanyitems <= 130 Then



            quicksortbut.BackColor = Color.Red
            quicksortbut.Update()
            Dim isdone As Boolean = False
            Dim list1() As thingstosort
            Dim list2() As thingstosort

            Dim y As Integer = howmanyitems
            Dim pivot As Integer
            isxokay = True
            isyokay = True
            For looper = 0 To 15


                isxokay = True
                isyokay = True
                For piv = howmanyitems - 1 To 1 Step -1
                    pivot = piv
                    quicksort.checkishighlow(items, pivot, howmanyitems)
                Next
                If isxokay = False And isyokay = False Then
                    isxokay = False
                End If
            Next

        Else
            MsgBox("Error: No Values To Sort")
        End If
        quicksortbut.BackColor = Color.Gainsboro
        quicksortbut.Update()
    End Sub

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        
        If TrackBar1.Value < 130 And TrackBar1.Value >= 5 Then


            howmanyitems = TrackBar1.Value - 1
            howmanyitemsinputbox.Text = howmanyitems



            If isgraphon = False Then
                ReDim Preserve items(howmanyitems)
            End If


            For x = 0 To howmanyitems
                If isgraphon = False Or x > items.Length - 1 Then
                    ReDim Preserve items(x)
                    items(x) = New thingstosort
                End If

                items(x).getrandomval()
                items(x).deleteline()
                items(x).draw(x)
            Next
            If howmanyitems < items.Length Then
                For y = howmanyitems To items.Length - 1
                    items(y).deleteline()
                Next
            End If
            isgraphon = True
            ReDim Preserve items(howmanyitems)

       
        End If



    End Sub

    
    Private Sub mergesortbut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mergesortbut.Click
        mergesort.mergesorting(items, howmanyitems)
    End Sub
 
End Class
