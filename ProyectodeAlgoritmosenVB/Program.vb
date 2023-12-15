Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace ProyectoFinalAlgoritmos
    Friend Module Program
        ''' <summary>
        ''' Punto de entrada principal para la aplicación.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace
