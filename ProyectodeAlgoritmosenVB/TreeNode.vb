Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace ProyectoFinalAlgoritmos
    Public Class TreeNode
        Public Property Data As Integer
        Public Property Left As TreeNode
        Public Property Right As TreeNode

        Public Sub New(data As Integer)
            Me.Data = data
            Left = Nothing
            Right = Nothing
        End Sub
    End Class
End Namespace
