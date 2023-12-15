' RadixSort.vb
Imports System

Namespace RadixSortExample
    Public Class RadixSort
        Public Shared Sub Sort(arr As Integer())
            Dim n As Integer = arr.Length
            Dim max As Integer = GetMax(arr)

            For exp As Integer = 1 To max \ exp Step 10
                CountSort(arr, n, exp)
            Next
        End Sub

        Private Shared Sub CountSort(arr As Integer(), n As Integer, exp As Integer)
            Dim output As Integer() = New Integer(n - 1) {}
            Dim count As Integer() = New Integer(9) {}

            For i As Integer = 0 To n - 1
                count((arr(i) \ exp) Mod 10) += 1
            Next

            For i As Integer = 1 To 9
                count(i) += count(i - 1)
            Next

            For i As Integer = n - 1 To 0 Step -1
                output(count((arr(i) \ exp) Mod 10) - 1) = arr(i)
                count((arr(i) \ exp) Mod 10) -= 1
            Next

            For i As Integer = 0 To n - 1
                arr(i) = output(i)
            Next
        End Sub

        Private Shared Function GetMax(arr As Integer()) As Integer
            Dim max As Integer = arr(0)
            Dim n As Integer = arr.Length

            For i As Integer = 1 To n - 1
                If arr(i) > max Then
                    max = arr(i)
                End If
            Next

            Return max
        End Function
    End Class
End Namespace
