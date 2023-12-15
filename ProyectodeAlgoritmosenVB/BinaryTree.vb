Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ProyectoFinalAlgoritmos
    Public Class BinaryTree
        Private root As TreeNode

        Public Sub Insert(data As Integer)
            root = InsertRecursive(root, data)
        End Sub

        Private Function InsertRecursive(root As TreeNode, data As Integer) As TreeNode
            If root Is Nothing Then
                Return New TreeNode(data)
            End If

            If data < root.Data Then
                root.Left = InsertRecursive(root.Left, data)
            ElseIf data > root.Data Then
                root.Right = InsertRecursive(root.Right, data)
            End If

            Return root
        End Function

        Public Function InOrderTraversal() As List(Of Integer)
            Dim result As New List(Of Integer)()
            InOrderTraversalRecursive(root, result)
            Return result
        End Function

        Private Sub InOrderTraversalRecursive(root As TreeNode, result As List(Of Integer))
            If root IsNot Nothing Then
                InOrderTraversalRecursive(root.Left, result)
                result.Add(root.Data)
                InOrderTraversalRecursive(root.Right, result)
            End If
        End Sub
    End Class
End Namespace
