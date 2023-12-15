Public Class BubbleSort
    Public Shared Sub Sort(array As Integer())
        Dim n As Integer = array.Length
        For i As Integer = 0 To n - 2
            For j As Integer = 0 To n - i - 2
                If array(j) > array(j + 1) Then
                    ' intercambiar array(j) y array(j+1)
                    Dim temp As Integer = array(j)
                    array(j) = array(j + 1)
                    array(j + 1) = temp
                End If
            Next
        Next
    End Sub
End Class
