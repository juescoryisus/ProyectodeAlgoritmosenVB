Public Class SmoothSort
    Public Shared Sub Sort(arr As Integer())
        Dim n As Integer = arr.Length

        For i As Integer = 1 To n - 1
            Dim j As Integer = i

            While j > 0 AndAlso arr(j) < arr((j - 1) \ 2)
                Swap(arr, j, (j - 1) \ 2)
                j = (j - 1) \ 2
            End While
        Next

        For i As Integer = n - 1 To 1 Step -1
            Swap(arr, 0, i)

            Dim j As Integer = 0
            Dim child As Integer

            While (child = 2 * j + 1) < i
                If child + 1 < i AndAlso arr(child) < arr(child + 1) Then
                    child += 1
                End If

                If arr(j) < arr(child) Then
                    Swap(arr, j, child)
                    j = child
                Else
                    Exit While
                End If
            End While
        Next
    End Sub

    Private Shared Sub Swap(arr As Integer(), i As Integer, j As Integer)
        Dim temp As Integer = arr(i)
        arr(i) = arr(j)
        arr(j) = temp
    End Sub
End Class
