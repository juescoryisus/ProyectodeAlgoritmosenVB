Public Class HeapSort
    Public Sub Sort(arr As Integer())
        Dim n As Integer = arr.Length

        ' Construir el heap (reorganizar el arreglo)
        For i As Integer = n \ 2 - 1 To 0 Step -1
            Heapify(arr, n, i)
        Next

        ' Extraer elementos del heap uno por uno
        For i As Integer = n - 1 To 1 Step -1
            ' Mover la raíz actual al final
            Dim temp As Integer = arr(0)
            arr(0) = arr(i)
            arr(i) = temp

            ' Llamar a heapify en el subárbol reducido
            Heapify(arr, i, 0)
        Next
    End Sub

    Private Sub Heapify(arr As Integer(), n As Integer, i As Integer)
        Dim largest As Integer = i ' Inicializar el más grande como la raíz
        Dim left As Integer = 2 * i + 1 ' Índice del hijo izquierdo
        Dim right As Integer = 2 * i + 2 ' Índice del hijo derecho

        ' Si el hijo izquierdo es más grande que la raíz
        If left < n AndAlso arr(left) > arr(largest) Then
            largest = left
        End If

        ' Si el hijo derecho es más grande que el más grande hasta ahora
        If right < n AndAlso arr(right) > arr(largest) Then
            largest = right
        End If

        ' Si el más grande no es la raíz
        If largest <> i Then
            Dim swap As Integer = arr(i)
            arr(i) = arr(largest)
            arr(largest) = swap

            ' Recursivamente heapify el subárbol afectado
            Heapify(arr, n, largest)
        End If
    End Sub
End Class
