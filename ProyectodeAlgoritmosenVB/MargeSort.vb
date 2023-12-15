Namespace MergeSortApp
    Public Module Mergesort
        Public Sub Sort(array As Integer())
            If array.Length <= 1 Then
                Return
            End If

            Dim middle As Integer = array.Length \ 2

            ' Dividir el array en dos partes
            Dim left(middle - 1) As Integer
            Dim right(array.Length - middle - 1) As Integer

            For i As Integer = 0 To middle - 1
                left(i) = array(i)
            Next

            For i As Integer = middle To array.Length - 1
                right(i - middle) = array(i)
            Next

            ' Recursivamente ordenar ambas partes
            Sort(left)
            Sort(right)

            ' Combinar las dos partes ordenadas
            Merge(array, left, right)
        End Sub

        Private Sub Merge(result As Integer(), left As Integer(), right As Integer())
            Dim i As Integer = 0, j As Integer = 0, k As Integer = 0

            While i < left.Length AndAlso j < right.Length
                If left(i) < right(j) Then
                    result(k) = left(i)
                    i += 1
                Else
                    result(k) = right(j)
                    j += 1
                End If
                k += 1
            End While

            ' Copiar los elementos restantes de left (si hay alguno)
            While i < left.Length
                result(k) = left(i)
                i += 1
                k += 1
            End While

            ' Copiar los elementos restantes de right (si hay alguno)
            While j < right.Length
                result(k) = right(j)
                j += 1
                k += 1
            End While
        End Sub
    End Module
End Namespace
