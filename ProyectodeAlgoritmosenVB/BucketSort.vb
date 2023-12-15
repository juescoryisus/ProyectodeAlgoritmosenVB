﻿Imports System.Collections.Generic

Public Class BucketSort
    Public Shared Function Sort(array As Integer()) As Integer()
        If array Is Nothing OrElse array.Length <= 1 Then
            Return array
        End If

        Dim minValue As Integer = array(0)
        Dim maxValue As Integer = array(0)

        ' Encuentra los valores mínimo y máximo en el array
        For i As Integer = 1 To array.Length - 1
            If array(i) < minValue Then
                minValue = array(i)
            ElseIf array(i) > maxValue Then
                maxValue = array(i)
            End If
        Next

        ' Crea los buckets
        Dim buckets(maxValue - minValue) As List(Of Integer)
        For i As Integer = 0 To buckets.Length - 1
            buckets(i) = New List(Of Integer)()
        Next

        ' Distribuye los elementos en los buckets
        For i As Integer = 0 To array.Length - 1
            buckets(array(i) - minValue).Add(array(i))
        Next

        ' Ordena cada bucket y combina los resultados
        Dim result As New List(Of Integer)()
        For Each bucket In buckets
            If bucket.Count > 0 Then
                Dim bucketArray As Integer() = Sort(bucket.ToArray())
                result.AddRange(bucketArray)
            End If
        Next

        Return result.ToArray()
    End Function
End Class
