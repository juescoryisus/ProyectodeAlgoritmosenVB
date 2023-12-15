Imports System.Collections.Generic

Public Class PigeonholeSort
    Public Shared Sub Sort(arr As Integer())
        Dim min As Integer = arr(0)
        Dim max As Integer = arr(0)
        Dim range, i, j, index As Integer

        For a As Integer = 0 To arr.Length - 1
            If arr(a) > max Then
                max = arr(a)
            End If
            If arr(a) < min Then
                min = arr(a)
            End If
        Next

        range = max - min + 1
        Dim pigeonhole(range - 1) As List(Of Integer)

        For i = 0 To range - 1
            pigeonhole(i) = New List(Of Integer)()
        Next

        For i = 0 To arr.Length - 1
            pigeonhole(arr(i) - min).Add(arr(i))
        Next

        index = 0
        For i = 0 To range - 1
            Dim list As List(Of Integer) = pigeonhole(i)
            For j = 0 To list.Count - 1
                arr(index) = list(j)
                index += 1
            Next
        Next
    End Sub
End Class
