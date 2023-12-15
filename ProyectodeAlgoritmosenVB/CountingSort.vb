Public Class CountingSort
    Public Shared Sub Sort(array As Integer())
        Dim max As Integer = FindMax(array)
        Dim count(max) As Integer
        Dim output(array.Length - 1) As Integer

        ' Inicializar el array de conteo
        For i As Integer = 0 To count.Length - 1
            count(i) = 0
        Next

        ' Contar la frecuencia de cada elemento
        For i As Integer = 0 To array.Length - 1
            count(array(i)) += 1
        Next

        ' Actualizar el array de conteo para contener las posiciones reales de los elementos en el output
        For i As Integer = 1 To max
            count(i) += count(i - 1)
        Next

        ' Construir el array de salida
        For i As Integer = array.Length - 1 To 0 Step -1
            output(count(array(i)) - 1) = array(i)
            count(array(i)) -= 1
        Next

        ' Copiar el array de salida de nuevo al array original
        For i As Integer = 0 To array.Length - 1
            array(i) = output(i)
        Next
    End Sub

    Private Shared Function FindMax(array As Integer()) As Integer
        Dim max As Integer = array(0)
        For i As Integer = 1 To array.Length - 1
            If array(i) > max Then
                max = array(i)
            End If
        Next
        Return max
    End Function
End Class
