Public Class Combsort
    Public Shared Sub Sort(Of T As IComparable(Of T))(array As T())
        Dim gap As Integer = array.Length
        Dim swapped As Boolean = True

        While gap > 1 OrElse swapped
            ' Reduce gap according to shrink factor
            gap = GetNextGap(gap)

            ' Initialize swapped as false so that we can
            ' check if the array is already sorted
            swapped = False

            ' Compare all elements with the current gap
            For i As Integer = 0 To array.Length - gap - 1
                Dim j As Integer = i + gap

                If array(i).CompareTo(array(j)) > 0 Then
                    ' Swap array(i) and array(j)
                    Swap(array(i), array(j))
                    swapped = True
                End If
            Next
        End While
    End Sub

    Private Shared Function GetNextGap(gap As Integer) As Integer
        ' Shrink factor
        Const shrink As Double = 1.3

        gap = CInt(gap / shrink)

        Return If(gap > 1, gap, 1)
    End Function

    Private Shared Sub Swap(Of T)(ByRef a As T, ByRef b As T)
        Dim temp As T = a
        a = b
        b = temp
    End Sub
End Class
