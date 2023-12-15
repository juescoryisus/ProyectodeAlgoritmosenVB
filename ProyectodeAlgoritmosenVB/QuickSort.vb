Public Class QuickSort
    Public Shared Sub Sort(array As Integer())
        If array Is Nothing OrElse array.Length = 0 Then
            Return
        End If

        QuickSortAlgorithm(array, 0, array.Length - 1)
    End Sub

    Private Shared Sub QuickSortAlgorithm(array As Integer(), left As Integer, right As Integer)
        If left < right Then
            Dim pivotIndex As Integer = Partition(array, left, right)

            If pivotIndex > 1 Then
                QuickSortAlgorithm(array, left, pivotIndex - 1)
            End If

            If pivotIndex + 1 < right Then
                QuickSortAlgorithm(array, pivotIndex + 1, right)
            End If
        End If
    End Sub

    Private Shared Function Partition(array As Integer(), left As Integer, right As Integer) As Integer
        Dim pivot As Integer = array(left)
        While True
            While array(left) < pivot
                left += 1
            End While

            While array(right) > pivot
                right -= 1
            End While

            If left < right Then
                Swap(array, left, right)
            Else
                Return right
            End If
        End While
    End Function

    Private Shared Sub Swap(array As Integer(), left As Integer, right As Integer)
        Dim temp As Integer = array(left)
        array(left) = array(right)
        array(right) = temp
    End Sub
End Class
