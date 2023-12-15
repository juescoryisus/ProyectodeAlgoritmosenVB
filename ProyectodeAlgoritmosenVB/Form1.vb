Imports System.Runtime.InteropServices.JavaScript.JSType

Namespace ProyectoFinalAlgoritmos
    Partial Public Class Form1
        Inherits Form
        Private binaryTree As BinaryTree
        Private arrayToSort As Integer()
        Private arrayToSort1 As Integer()
        Private txtNumbers As TextBox
        Private btnSort14 As Button

        Public Sub New()
            InitializeComponent()
            binaryTree = New BinaryTree()

            txtNumbers2345 = New TextBox With {
                .Location = New System.Drawing.Point(10, 10),
                .Size = New System.Drawing.Size(200, 20)
            }
            Controls.Add(txtNumbers2345)

            btnSort14 = New Button With {
                .Location = New System.Drawing.Point(220, 10),
                .Size = New System.Drawing.Size(75, 23),
                .Text = "Ordenar"
            }
            AddHandler btnSort14.Click, AddressOf btnSort_Click
            Controls.Add(btnSort14)
        End Sub

        Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs)
            If Integer.TryParse(txtNumber.Text, Number) Then
                binaryTree.Insert(Number)
                txtNumber.Clear()
            Else
                MessageBox.Show("Ingrese Un Numero Etero.")
            End If
        End Sub

        Private Sub btnSort_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim sortedList As List(Of Integer) = binaryTree.InOrderTraversal()
            MessageBox.Show("Numeros Ordenados: " & String.Join(", ", sortedList))
        End Sub

        Private Sub btnSortBubble_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Leer los números desde el cuadro de texto y convertirlos a un array
            Dim numbersString As String() = txtNumbers2345.Text.Split(","c)
            Dim numbers As Integer() = Array.ConvertAll(numbersString, Integer.Parse)

            ' Aplicar Bubble Sort
            BubbleSort.Sort(numbers)

            ' Mostrar los números ordenados en el cuadro de texto.
            MessageBox.Show("Numeros Ordenados: " & String.Join(", ", numbers))
        End Sub

        Private Sub btnSortBucket_Click(ByVal sender As Object, ByVal e As EventArgs)
            ' Obtén los números ingresados por el usuario desde el TextBox
            Dim input As String = txtInput.Text

            If String.IsNullOrWhiteSpace(input) Then
                MessageBox.Show("Ingrese al menos un número.", "Error")
                Return
            End If

            ' Convierte la cadena de entrada en una matriz de enteros
            Dim arrayToSort As Integer()
            Try
                arrayToSort = input.Split(","c).Select(Function(x) Integer.Parse(x)).ToArray()
            Catch generatedExceptionName As FormatException
                MessageBox.Show("Formato de entrada incorrecto. Ingrese números separados por comas.", "Error")
                Return
            End Try

            ' Ordena la matriz utilizando BucketSort
            Dim sortedArray As Integer() = BucketSort.Sort(arrayToSort)

            ' Muestra el resultado en un MessageBox
            MessageBox.Show("Array ordenado: " & String.Join(", ", sortedArray), "Resultado")
        End Sub

        Friend WithEvents Panel1 As Panel
        Friend WithEvents Label2 As Label
        Friend WithEvents Label1 As Label

        Private Sub InitializeComponent()
            Panel1 = New Panel()
            btnSort = New Button()
            btnAdd = New Button()
            txtNumber = New TextBox()
            Label2 = New Label()
            Label1 = New Label()
            Panel2 = New Panel()
            btnSortBubble = New Button()
            btnNumbers = New TextBox()
            Label3 = New Label()
            Label4 = New Label()
            Panel3 = New Panel()
            btnSortBucket = New Button()
            txtInput = New TextBox()
            Label5 = New Label()
            Label6 = New Label()
            Panel4 = New Panel()
            Button4 = New Button()
            Label10 = New Label()
            Label9 = New Label()
            TextBox5 = New TextBox()
            TextBox4 = New TextBox()
            Button3 = New Button()
            TextBox3 = New TextBox()
            Label7 = New Label()
            Label8 = New Label()
            Panel5 = New Panel()
            Panel8 = New Panel()
            Button9 = New Button()
            TextBox11 = New TextBox()
            Label19 = New Label()
            Label20 = New Label()
            txtOutput2 = New TextBox()
            Label13 = New Label()
            btnSortCouting = New Button()
            txtInput2 = New TextBox()
            Label11 = New Label()
            Label12 = New Label()
            Panel6 = New Panel()
            btnGenerateArray1 = New Button()
            btnSortGnomeSort = New Button()
            txtInput3 = New TextBox()
            Label14 = New Label()
            Label15 = New Label()
            Panel7 = New Panel()
            txtOutput9 = New TextBox()
            Label16 = New Label()
            btnSortHeapSort = New Button()
            txtInput8 = New TextBox()
            Label17 = New Label()
            Label18 = New Label()
            Panel9 = New Panel()
            btnSortInsertionsort = New Button()
            txtInput34 = New TextBox()
            Label21 = New Label()
            Label22 = New Label()
            Panel10 = New Panel()
            txtOutput11 = New TextBox()
            Label23 = New Label()
            btnSortMargesort = New Button()
            txtInput12 = New TextBox()
            Label24 = New Label()
            Label25 = New Label()
            Panel11 = New Panel()
            txtNumbers98 = New TextBox()
            Label26 = New Label()
            Button12 = New Button()
            lblSortedArray73 = New TextBox()
            Label27 = New Label()
            Label28 = New Label()
            Panel12 = New Panel()
            txtOutput1 = New TextBox()
            Label29 = New Label()
            btnSortCombsort = New Button()
            txtInput1 = New TextBox()
            Label30 = New Label()
            Label31 = New Label()
            Panel13 = New Panel()
            btnSortPigeonholeSort = New Button()
            txtInputNumbers88 = New TextBox()
            Label32 = New Label()
            Label33 = New Label()
            Panel14 = New Panel()
            txtOutput43 = New TextBox()
            Label34 = New Label()
            btnSortQuickSort = New Button()
            txtInput67 = New TextBox()
            Label35 = New Label()
            Label36 = New Label()
            Panel15 = New Panel()
            txtOutput843 = New TextBox()
            Label37 = New Label()
            btnSortShellSort = New Button()
            txtInput732 = New TextBox()
            Label38 = New Label()
            Label39 = New Label()
            Panel16 = New Panel()
            btnSortSmoothSort = New Button()
            txtNumbers2345 = New TextBox()
            Panel17 = New Panel()
            txtSortedNumbers09 = New TextBox()
            Label40 = New Label()
            btnSortRadixSor = New Button()
            txtInputNumbers76 = New TextBox()
            Label41 = New Label()
            Label42 = New Label()
            Panel1.SuspendLayout()
            Panel2.SuspendLayout()
            Panel3.SuspendLayout()
            Panel4.SuspendLayout()
            Panel5.SuspendLayout()
            Panel8.SuspendLayout()
            Panel6.SuspendLayout()
            Panel7.SuspendLayout()
            Panel9.SuspendLayout()
            Panel10.SuspendLayout()
            Panel11.SuspendLayout()
            Panel12.SuspendLayout()
            Panel13.SuspendLayout()
            Panel14.SuspendLayout()
            Panel15.SuspendLayout()
            Panel16.SuspendLayout()
            Panel17.SuspendLayout()
            SuspendLayout()
            ' 
            ' Panel1
            ' 
            Panel1.Controls.Add(btnSort)
            Panel1.Controls.Add(btnAdd)
            Panel1.Controls.Add(txtNumber)
            Panel1.Controls.Add(Label2)
            Panel1.Controls.Add(Label1)
            Panel1.Location = New Point(8, 9)
            Panel1.Name = "Panel1"
            Panel1.Size = New Size(250, 150)
            Panel1.TabIndex = 0
            ' 
            ' btnSort
            ' 
            btnSort.Location = New Point(123, 91)
            btnSort.Name = "btnSort"
            btnSort.Size = New Size(112, 34)
            btnSort.TabIndex = 4
            btnSort.Text = "btnSort"
            btnSort.UseVisualStyleBackColor = True
            ' 
            ' btnAdd
            ' 
            btnAdd.Location = New Point(5, 91)
            btnAdd.Name = "btnAdd"
            btnAdd.Size = New Size(112, 34)
            btnAdd.TabIndex = 3
            btnAdd.Text = "Agregar"
            btnAdd.UseVisualStyleBackColor = True
            ' 
            ' txtNumber
            ' 
            txtNumber.Location = New Point(52, 54)
            txtNumber.Name = "txtNumber"
            txtNumber.Size = New Size(150, 31)
            txtNumber.TabIndex = 2
            ' 
            ' Label2
            ' 
            Label2.AutoSize = True
            Label2.Location = New Point(40, 26)
            Label2.Name = "Label2"
            Label2.Size = New Size(162, 25)
            Label2.TabIndex = 1
            Label2.Text = "Ingrese un numero"
            ' 
            ' Label1
            ' 
            Label1.AutoSize = True
            Label1.BackColor = Color.Yellow
            Label1.Location = New Point(59, 1)
            Label1.Name = "Label1"
            Label1.Size = New Size(124, 25)
            Label1.TabIndex = 0
            Label1.Text = "BinaryTreeSort"
            ' 
            ' Panel2
            ' 
            Panel2.Controls.Add(btnSortBubble)
            Panel2.Controls.Add(btnNumbers)
            Panel2.Controls.Add(Label3)
            Panel2.Controls.Add(Label4)
            Panel2.Location = New Point(263, 8)
            Panel2.Name = "Panel2"
            Panel2.Size = New Size(405, 150)
            Panel2.TabIndex = 1
            ' 
            ' btnSortBubble
            ' 
            btnSortBubble.Location = New Point(147, 104)
            btnSortBubble.Name = "btnSortBubble"
            btnSortBubble.Size = New Size(112, 34)
            btnSortBubble.TabIndex = 3
            btnSortBubble.Text = "Ordenar"
            btnSortBubble.UseVisualStyleBackColor = True
            ' 
            ' btnNumbers
            ' 
            btnNumbers.Location = New Point(19, 67)
            btnNumbers.Name = "btnNumbers"
            btnNumbers.Size = New Size(370, 31)
            btnNumbers.TabIndex = 2
            ' 
            ' Label3
            ' 
            Label3.AutoSize = True
            Label3.Location = New Point(8, 39)
            Label3.Name = "Label3"
            Label3.Size = New Size(394, 25)
            Label3.TabIndex = 1
            Label3.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label4
            ' 
            Label4.AutoSize = True
            Label4.BackColor = Color.Yellow
            Label4.Location = New Point(159, 14)
            Label4.Name = "Label4"
            Label4.Size = New Size(100, 25)
            Label4.TabIndex = 0
            Label4.Text = "BubbleSort"
            ' 
            ' Panel3
            ' 
            Panel3.Controls.Add(btnSortBucket)
            Panel3.Controls.Add(txtInput)
            Panel3.Controls.Add(Label5)
            Panel3.Controls.Add(Label6)
            Panel3.Location = New Point(674, 10)
            Panel3.Name = "Panel3"
            Panel3.Size = New Size(405, 150)
            Panel3.TabIndex = 2
            ' 
            ' btnSortBucket
            ' 
            btnSortBucket.Location = New Point(147, 104)
            btnSortBucket.Name = "btnSortBucket"
            btnSortBucket.Size = New Size(112, 34)
            btnSortBucket.TabIndex = 3
            btnSortBucket.Text = "Ordenar"
            btnSortBucket.UseVisualStyleBackColor = True
            ' 
            ' txtInput
            ' 
            txtInput.Location = New Point(19, 67)
            txtInput.Name = "txtInput"
            txtInput.Size = New Size(370, 31)
            txtInput.TabIndex = 2
            ' 
            ' Label5
            ' 
            Label5.AutoSize = True
            Label5.Location = New Point(8, 39)
            Label5.Name = "Label5"
            Label5.Size = New Size(394, 25)
            Label5.TabIndex = 1
            Label5.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label6
            ' 
            Label6.AutoSize = True
            Label6.BackColor = Color.Yellow
            Label6.Location = New Point(159, 14)
            Label6.Name = "Label6"
            Label6.Size = New Size(97, 25)
            Label6.TabIndex = 0
            Label6.Text = "BucketSort"
            ' 
            ' Panel4
            ' 
            Panel4.Controls.Add(Button4)
            Panel4.Controls.Add(Label10)
            Panel4.Controls.Add(Label9)
            Panel4.Controls.Add(TextBox5)
            Panel4.Controls.Add(TextBox4)
            Panel4.Controls.Add(Button3)
            Panel4.Controls.Add(TextBox3)
            Panel4.Controls.Add(Label7)
            Panel4.Controls.Add(Label8)
            Panel4.Location = New Point(1085, 8)
            Panel4.Name = "Panel4"
            Panel4.Size = New Size(245, 279)
            Panel4.TabIndex = 3
            ' 
            ' Button4
            ' 
            Button4.Location = New Point(111, 233)
            Button4.Name = "Button4"
            Button4.Size = New Size(127, 34)
            Button4.TabIndex = 4
            Button4.Text = "GenerarArray"
            Button4.UseVisualStyleBackColor = True
            ' 
            ' Label10
            ' 
            Label10.AutoSize = True
            Label10.Location = New Point(11, 155)
            Label10.Name = "Label10"
            Label10.Size = New Size(179, 25)
            Label10.TabIndex = 7
            Label10.Text = "Numeros Ordenados"
            ' 
            ' Label9
            ' 
            Label9.AutoSize = True
            Label9.Location = New Point(11, 93)
            Label9.Name = "Label9"
            Label9.Size = New Size(170, 25)
            Label9.TabIndex = 6
            Label9.Text = "Numeros Aleatorios"
            ' 
            ' TextBox5
            ' 
            TextBox5.Location = New Point(11, 184)
            TextBox5.Name = "TextBox5"
            TextBox5.Size = New Size(219, 31)
            TextBox5.TabIndex = 5
            ' 
            ' TextBox4
            ' 
            TextBox4.Location = New Point(11, 121)
            TextBox4.Name = "TextBox4"
            TextBox4.Size = New Size(219, 31)
            TextBox4.TabIndex = 4
            ' 
            ' Button3
            ' 
            Button3.Location = New Point(8, 233)
            Button3.Name = "Button3"
            Button3.Size = New Size(97, 34)
            Button3.TabIndex = 3
            Button3.Text = "Ordenar"
            Button3.UseVisualStyleBackColor = True
            ' 
            ' TextBox3
            ' 
            TextBox3.Location = New Point(11, 67)
            TextBox3.Name = "TextBox3"
            TextBox3.Size = New Size(124, 31)
            TextBox3.TabIndex = 2
            ' 
            ' Label7
            ' 
            Label7.AutoSize = True
            Label7.Location = New Point(8, 39)
            Label7.Name = "Label7"
            Label7.Size = New Size(164, 25)
            Label7.TabIndex = 1
            Label7.Text = "Tamaño del arreglo"
            ' 
            ' Label8
            ' 
            Label8.AutoSize = True
            Label8.BackColor = Color.Yellow
            Label8.Location = New Point(28, 14)
            Label8.Name = "Label8"
            Label8.Size = New Size(107, 25)
            Label8.TabIndex = 0
            Label8.Text = "CocktailSort"
            ' 
            ' Panel5
            ' 
            Panel5.Controls.Add(Panel8)
            Panel5.Controls.Add(txtOutput2)
            Panel5.Controls.Add(Label13)
            Panel5.Controls.Add(btnSortCouting)
            Panel5.Controls.Add(txtInput2)
            Panel5.Controls.Add(Label11)
            Panel5.Controls.Add(Label12)
            Panel5.Location = New Point(7, 163)
            Panel5.Name = "Panel5"
            Panel5.Size = New Size(405, 209)
            Panel5.TabIndex = 4
            ' 
            ' Panel8
            ' 
            Panel8.Controls.Add(Button9)
            Panel8.Controls.Add(TextBox11)
            Panel8.Controls.Add(Label19)
            Panel8.Controls.Add(Label20)
            Panel8.Location = New Point(403, 157)
            Panel8.Name = "Panel8"
            Panel8.Size = New Size(405, 150)
            Panel8.TabIndex = 7
            ' 
            ' Button9
            ' 
            Button9.Location = New Point(147, 104)
            Button9.Name = "Button9"
            Button9.Size = New Size(112, 34)
            Button9.TabIndex = 3
            Button9.Text = "Ordenar"
            Button9.UseVisualStyleBackColor = True
            ' 
            ' TextBox11
            ' 
            TextBox11.Location = New Point(19, 67)
            TextBox11.Name = "TextBox11"
            TextBox11.Size = New Size(370, 31)
            TextBox11.TabIndex = 2
            ' 
            ' Label19
            ' 
            Label19.AutoSize = True
            Label19.Location = New Point(8, 39)
            Label19.Name = "Label19"
            Label19.Size = New Size(394, 25)
            Label19.TabIndex = 1
            Label19.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label20
            ' 
            Label20.AutoSize = True
            Label20.BackColor = Color.Yellow
            Label20.Location = New Point(159, 14)
            Label20.Name = "Label20"
            Label20.Size = New Size(97, 25)
            Label20.TabIndex = 0
            Label20.Text = "BucketSort"
            ' 
            ' txtOutput2
            ' 
            txtOutput2.Location = New Point(17, 127)
            txtOutput2.Name = "txtOutput2"
            txtOutput2.Size = New Size(372, 31)
            txtOutput2.TabIndex = 6
            ' 
            ' Label13
            ' 
            Label13.AutoSize = True
            Label13.Location = New Point(124, 99)
            Label13.Name = "Label13"
            Label13.Size = New Size(179, 25)
            Label13.TabIndex = 8
            Label13.Text = "Numeros Ordenados"
            ' 
            ' btnSortCouting
            ' 
            btnSortCouting.Location = New Point(138, 172)
            btnSortCouting.Name = "btnSortCouting"
            btnSortCouting.Size = New Size(112, 34)
            btnSortCouting.TabIndex = 3
            btnSortCouting.Text = "Ordenar"
            btnSortCouting.UseVisualStyleBackColor = True
            ' 
            ' txtInput2
            ' 
            txtInput2.Location = New Point(19, 67)
            txtInput2.Name = "txtInput2"
            txtInput2.Size = New Size(370, 31)
            txtInput2.TabIndex = 2
            ' 
            ' Label11
            ' 
            Label11.AutoSize = True
            Label11.Location = New Point(8, 39)
            Label11.Name = "Label11"
            Label11.Size = New Size(394, 25)
            Label11.TabIndex = 1
            Label11.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label12
            ' 
            Label12.AutoSize = True
            Label12.BackColor = Color.Yellow
            Label12.Location = New Point(159, 14)
            Label12.Name = "Label12"
            Label12.Size = New Size(108, 25)
            Label12.TabIndex = 0
            Label12.Text = "CoutingSort"
            ' 
            ' Panel6
            ' 
            Panel6.Controls.Add(btnGenerateArray1)
            Panel6.Controls.Add(btnSortGnomeSort)
            Panel6.Controls.Add(txtInput3)
            Panel6.Controls.Add(Label14)
            Panel6.Controls.Add(Label15)
            Panel6.Location = New Point(415, 164)
            Panel6.Name = "Panel6"
            Panel6.Size = New Size(253, 150)
            Panel6.TabIndex = 5
            ' 
            ' btnGenerateArray1
            ' 
            btnGenerateArray1.Location = New Point(125, 104)
            btnGenerateArray1.Name = "btnGenerateArray1"
            btnGenerateArray1.Size = New Size(112, 34)
            btnGenerateArray1.TabIndex = 6
            btnGenerateArray1.Text = "Ordenar"
            btnGenerateArray1.UseVisualStyleBackColor = True
            ' 
            ' btnSortGnomeSort
            ' 
            btnSortGnomeSort.Location = New Point(19, 104)
            btnSortGnomeSort.Name = "btnSortGnomeSort"
            btnSortGnomeSort.Size = New Size(112, 34)
            btnSortGnomeSort.TabIndex = 3
            btnSortGnomeSort.Text = "Ordenar"
            btnSortGnomeSort.UseVisualStyleBackColor = True
            ' 
            ' txtInput3
            ' 
            txtInput3.Location = New Point(19, 67)
            txtInput3.Name = "txtInput3"
            txtInput3.Size = New Size(218, 31)
            txtInput3.TabIndex = 2
            ' 
            ' Label14
            ' 
            Label14.AutoSize = True
            Label14.Location = New Point(44, 39)
            Label14.Name = "Label14"
            Label14.Size = New Size(167, 25)
            Label14.TabIndex = 1
            Label14.Text = "Tamaño del Arreglo"
            ' 
            ' Label15
            ' 
            Label15.AutoSize = True
            Label15.BackColor = Color.Yellow
            Label15.Location = New Point(87, 13)
            Label15.Name = "Label15"
            Label15.Size = New Size(103, 25)
            Label15.TabIndex = 0
            Label15.Text = "GnomeSort"
            ' 
            ' Panel7
            ' 
            Panel7.Controls.Add(txtOutput9)
            Panel7.Controls.Add(Label16)
            Panel7.Controls.Add(btnSortHeapSort)
            Panel7.Controls.Add(txtInput8)
            Panel7.Controls.Add(Label17)
            Panel7.Controls.Add(Label18)
            Panel7.Location = New Point(7, 378)
            Panel7.Name = "Panel7"
            Panel7.Size = New Size(405, 209)
            Panel7.TabIndex = 6
            ' 
            ' txtOutput9
            ' 
            txtOutput9.Location = New Point(17, 127)
            txtOutput9.Name = "txtOutput9"
            txtOutput9.Size = New Size(372, 31)
            txtOutput9.TabIndex = 6
            ' 
            ' Label16
            ' 
            Label16.AutoSize = True
            Label16.Location = New Point(124, 99)
            Label16.Name = "Label16"
            Label16.Size = New Size(179, 25)
            Label16.TabIndex = 8
            Label16.Text = "Numeros Ordenados"
            ' 
            ' btnSortHeapSort
            ' 
            btnSortHeapSort.Location = New Point(138, 172)
            btnSortHeapSort.Name = "btnSortHeapSort"
            btnSortHeapSort.Size = New Size(112, 34)
            btnSortHeapSort.TabIndex = 3
            btnSortHeapSort.Text = "Ordenar"
            btnSortHeapSort.UseVisualStyleBackColor = True
            ' 
            ' txtInput8
            ' 
            txtInput8.Location = New Point(19, 67)
            txtInput8.Name = "txtInput8"
            txtInput8.Size = New Size(370, 31)
            txtInput8.TabIndex = 2
            ' 
            ' Label17
            ' 
            Label17.AutoSize = True
            Label17.Location = New Point(8, 39)
            Label17.Name = "Label17"
            Label17.Size = New Size(394, 25)
            Label17.TabIndex = 1
            Label17.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label18
            ' 
            Label18.AutoSize = True
            Label18.BackColor = Color.Yellow
            Label18.Location = New Point(159, 14)
            Label18.Name = "Label18"
            Label18.Size = New Size(87, 25)
            Label18.TabIndex = 0
            Label18.Text = "HeapSort"
            ' 
            ' Panel9
            ' 
            Panel9.Controls.Add(btnSortInsertionsort)
            Panel9.Controls.Add(txtInput34)
            Panel9.Controls.Add(Label21)
            Panel9.Controls.Add(Label22)
            Panel9.Location = New Point(418, 366)
            Panel9.Name = "Panel9"
            Panel9.Size = New Size(405, 150)
            Panel9.TabIndex = 7
            ' 
            ' btnSortInsertionsort
            ' 
            btnSortInsertionsort.Location = New Point(147, 104)
            btnSortInsertionsort.Name = "btnSortInsertionsort"
            btnSortInsertionsort.Size = New Size(112, 34)
            btnSortInsertionsort.TabIndex = 3
            btnSortInsertionsort.Text = "Ordenar"
            btnSortInsertionsort.UseVisualStyleBackColor = True
            ' 
            ' txtInput34
            ' 
            txtInput34.Location = New Point(27, 67)
            txtInput34.Name = "txtInput34"
            txtInput34.Size = New Size(370, 31)
            txtInput34.TabIndex = 2
            ' 
            ' Label21
            ' 
            Label21.AutoSize = True
            Label21.Location = New Point(8, 39)
            Label21.Name = "Label21"
            Label21.Size = New Size(394, 25)
            Label21.TabIndex = 1
            Label21.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label22
            ' 
            Label22.AutoSize = True
            Label22.BackColor = Color.Yellow
            Label22.Location = New Point(147, 14)
            Label22.Name = "Label22"
            Label22.Size = New Size(114, 25)
            Label22.TabIndex = 0
            Label22.Text = "InsertionSort"
            ' 
            ' Panel10
            ' 
            Panel10.Controls.Add(txtOutput11)
            Panel10.Controls.Add(Label23)
            Panel10.Controls.Add(btnSortMargesort)
            Panel10.Controls.Add(txtInput12)
            Panel10.Controls.Add(Label24)
            Panel10.Controls.Add(Label25)
            Panel10.Location = New Point(829, 366)
            Panel10.Name = "Panel10"
            Panel10.Size = New Size(405, 209)
            Panel10.TabIndex = 8
            ' 
            ' txtOutput11
            ' 
            txtOutput11.Location = New Point(17, 127)
            txtOutput11.Name = "txtOutput11"
            txtOutput11.Size = New Size(372, 31)
            txtOutput11.TabIndex = 6
            ' 
            ' Label23
            ' 
            Label23.AutoSize = True
            Label23.Location = New Point(124, 99)
            Label23.Name = "Label23"
            Label23.Size = New Size(179, 25)
            Label23.TabIndex = 8
            Label23.Text = "Numeros Ordenados"
            ' 
            ' btnSortMargesort
            ' 
            btnSortMargesort.Location = New Point(138, 172)
            btnSortMargesort.Name = "btnSortMargesort"
            btnSortMargesort.Size = New Size(112, 34)
            btnSortMargesort.TabIndex = 3
            btnSortMargesort.Text = "Ordenar"
            btnSortMargesort.UseVisualStyleBackColor = True
            ' 
            ' txtInput12
            ' 
            txtInput12.Location = New Point(19, 67)
            txtInput12.Name = "txtInput12"
            txtInput12.Size = New Size(370, 31)
            txtInput12.TabIndex = 2
            ' 
            ' Label24
            ' 
            Label24.AutoSize = True
            Label24.Location = New Point(8, 39)
            Label24.Name = "Label24"
            Label24.Size = New Size(394, 25)
            Label24.TabIndex = 1
            Label24.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label25
            ' 
            Label25.AutoSize = True
            Label25.BackColor = Color.Yellow
            Label25.Location = New Point(159, 14)
            Label25.Name = "Label25"
            Label25.Size = New Size(96, 25)
            Label25.TabIndex = 0
            Label25.Text = "MargeSort"
            ' 
            ' Panel11
            ' 
            Panel11.Controls.Add(txtNumbers98)
            Panel11.Controls.Add(Label26)
            Panel11.Controls.Add(Button12)
            Panel11.Controls.Add(lblSortedArray73)
            Panel11.Controls.Add(Label27)
            Panel11.Controls.Add(Label28)
            Panel11.Location = New Point(1237, 317)
            Panel11.Name = "Panel11"
            Panel11.Size = New Size(405, 209)
            Panel11.TabIndex = 9
            ' 
            ' txtNumbers98
            ' 
            txtNumbers98.Location = New Point(17, 127)
            txtNumbers98.Name = "txtNumbers98"
            txtNumbers98.Size = New Size(372, 31)
            txtNumbers98.TabIndex = 6
            ' 
            ' Label26
            ' 
            Label26.AutoSize = True
            Label26.Location = New Point(124, 99)
            Label26.Name = "Label26"
            Label26.Size = New Size(179, 25)
            Label26.TabIndex = 8
            Label26.Text = "Numeros Ordenados"
            ' 
            ' Button12
            ' 
            Button12.Location = New Point(138, 172)
            Button12.Name = "Button12"
            Button12.Size = New Size(112, 34)
            Button12.TabIndex = 3
            Button12.Text = "Ordenar"
            Button12.UseVisualStyleBackColor = True
            ' 
            ' lblSortedArray73
            ' 
            lblSortedArray73.Location = New Point(19, 67)
            lblSortedArray73.Name = "lblSortedArray73"
            lblSortedArray73.Size = New Size(370, 31)
            lblSortedArray73.TabIndex = 2
            ' 
            ' Label27
            ' 
            Label27.AutoSize = True
            Label27.Location = New Point(8, 39)
            Label27.Name = "Label27"
            Label27.Size = New Size(394, 25)
            Label27.TabIndex = 1
            Label27.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label28
            ' 
            Label28.AutoSize = True
            Label28.BackColor = Color.Yellow
            Label28.Location = New Point(159, 14)
            Label28.Name = "Label28"
            Label28.Size = New Size(116, 25)
            Label28.TabIndex = 0
            Label28.Text = "SelectionSort"
            ' 
            ' Panel12
            ' 
            Panel12.Controls.Add(txtOutput1)
            Panel12.Controls.Add(Label29)
            Panel12.Controls.Add(btnSortCombsort)
            Panel12.Controls.Add(txtInput1)
            Panel12.Controls.Add(Label30)
            Panel12.Controls.Add(Label31)
            Panel12.Location = New Point(1336, 8)
            Panel12.Name = "Panel12"
            Panel12.Size = New Size(405, 209)
            Panel12.TabIndex = 10
            ' 
            ' txtOutput1
            ' 
            txtOutput1.Location = New Point(17, 127)
            txtOutput1.Name = "txtOutput1"
            txtOutput1.Size = New Size(372, 31)
            txtOutput1.TabIndex = 6
            ' 
            ' Label29
            ' 
            Label29.AutoSize = True
            Label29.Location = New Point(124, 99)
            Label29.Name = "Label29"
            Label29.Size = New Size(179, 25)
            Label29.TabIndex = 8
            Label29.Text = "Numeros Ordenados"
            ' 
            ' btnSortCombsort
            ' 
            btnSortCombsort.Location = New Point(138, 172)
            btnSortCombsort.Name = "btnSortCombsort"
            btnSortCombsort.Size = New Size(112, 34)
            btnSortCombsort.TabIndex = 3
            btnSortCombsort.Text = "Ordenar"
            btnSortCombsort.UseVisualStyleBackColor = True
            ' 
            ' txtInput1
            ' 
            txtInput1.Location = New Point(19, 67)
            txtInput1.Name = "txtInput1"
            txtInput1.Size = New Size(370, 31)
            txtInput1.TabIndex = 2
            ' 
            ' Label30
            ' 
            Label30.AutoSize = True
            Label30.Location = New Point(8, 39)
            Label30.Name = "Label30"
            Label30.Size = New Size(394, 25)
            Label30.TabIndex = 1
            Label30.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label31
            ' 
            Label31.AutoSize = True
            Label31.BackColor = Color.Yellow
            Label31.Location = New Point(159, 14)
            Label31.Name = "Label31"
            Label31.Size = New Size(94, 25)
            Label31.TabIndex = 0
            Label31.Text = "CombSort"
            ' 
            ' Panel13
            ' 
            Panel13.Controls.Add(btnSortPigeonholeSort)
            Panel13.Controls.Add(txtInputNumbers88)
            Panel13.Controls.Add(Label32)
            Panel13.Controls.Add(Label33)
            Panel13.Location = New Point(7, 593)
            Panel13.Name = "Panel13"
            Panel13.Size = New Size(405, 150)
            Panel13.TabIndex = 11
            ' 
            ' btnSortPigeonholeSort
            ' 
            btnSortPigeonholeSort.Location = New Point(147, 104)
            btnSortPigeonholeSort.Name = "btnSortPigeonholeSort"
            btnSortPigeonholeSort.Size = New Size(112, 34)
            btnSortPigeonholeSort.TabIndex = 3
            btnSortPigeonholeSort.Text = "Ordenar"
            btnSortPigeonholeSort.UseVisualStyleBackColor = True
            ' 
            ' txtInputNumbers88
            ' 
            txtInputNumbers88.Location = New Point(19, 67)
            txtInputNumbers88.Name = "txtInputNumbers88"
            txtInputNumbers88.Size = New Size(370, 31)
            txtInputNumbers88.TabIndex = 2
            ' 
            ' Label32
            ' 
            Label32.AutoSize = True
            Label32.Location = New Point(8, 39)
            Label32.Name = "Label32"
            Label32.Size = New Size(394, 25)
            Label32.TabIndex = 1
            Label32.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label33
            ' 
            Label33.AutoSize = True
            Label33.BackColor = Color.Yellow
            Label33.Location = New Point(138, 14)
            Label33.Name = "Label33"
            Label33.Size = New Size(144, 25)
            Label33.TabIndex = 0
            Label33.Text = "PingeonholeSort"
            ' 
            ' Panel14
            ' 
            Panel14.Controls.Add(txtOutput43)
            Panel14.Controls.Add(Label34)
            Panel14.Controls.Add(btnSortQuickSort)
            Panel14.Controls.Add(txtInput67)
            Panel14.Controls.Add(Label35)
            Panel14.Controls.Add(Label36)
            Panel14.Location = New Point(419, 522)
            Panel14.Name = "Panel14"
            Panel14.Size = New Size(405, 209)
            Panel14.TabIndex = 12
            ' 
            ' txtOutput43
            ' 
            txtOutput43.Location = New Point(17, 127)
            txtOutput43.Name = "txtOutput43"
            txtOutput43.Size = New Size(372, 31)
            txtOutput43.TabIndex = 6
            ' 
            ' Label34
            ' 
            Label34.AutoSize = True
            Label34.Location = New Point(124, 99)
            Label34.Name = "Label34"
            Label34.Size = New Size(179, 25)
            Label34.TabIndex = 8
            Label34.Text = "Numeros Ordenados"
            ' 
            ' btnSortQuickSort
            ' 
            btnSortQuickSort.Location = New Point(138, 172)
            btnSortQuickSort.Name = "btnSortQuickSort"
            btnSortQuickSort.Size = New Size(112, 34)
            btnSortQuickSort.TabIndex = 3
            btnSortQuickSort.Text = "Ordenar"
            btnSortQuickSort.UseVisualStyleBackColor = True
            ' 
            ' txtInput67
            ' 
            txtInput67.Location = New Point(19, 67)
            txtInput67.Name = "txtInput67"
            txtInput67.Size = New Size(370, 31)
            txtInput67.TabIndex = 2
            ' 
            ' Label35
            ' 
            Label35.AutoSize = True
            Label35.Location = New Point(8, 39)
            Label35.Name = "Label35"
            Label35.Size = New Size(394, 25)
            Label35.TabIndex = 1
            Label35.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label36
            ' 
            Label36.AutoSize = True
            Label36.BackColor = Color.Yellow
            Label36.Location = New Point(159, 14)
            Label36.Name = "Label36"
            Label36.Size = New Size(90, 25)
            Label36.TabIndex = 0
            Label36.Text = "QuickSort"
            ' 
            ' Panel15
            ' 
            Panel15.Controls.Add(txtOutput843)
            Panel15.Controls.Add(Label37)
            Panel15.Controls.Add(btnSortShellSort)
            Panel15.Controls.Add(txtInput732)
            Panel15.Controls.Add(Label38)
            Panel15.Controls.Add(Label39)
            Panel15.Location = New Point(830, 576)
            Panel15.Name = "Panel15"
            Panel15.Size = New Size(405, 209)
            Panel15.TabIndex = 13
            ' 
            ' txtOutput843
            ' 
            txtOutput843.Location = New Point(17, 127)
            txtOutput843.Name = "txtOutput843"
            txtOutput843.Size = New Size(372, 31)
            txtOutput843.TabIndex = 6
            ' 
            ' Label37
            ' 
            Label37.AutoSize = True
            Label37.Location = New Point(124, 99)
            Label37.Name = "Label37"
            Label37.Size = New Size(179, 25)
            Label37.TabIndex = 8
            Label37.Text = "Numeros Ordenados"
            ' 
            ' btnSortShellSort
            ' 
            btnSortShellSort.Location = New Point(138, 172)
            btnSortShellSort.Name = "btnSortShellSort"
            btnSortShellSort.Size = New Size(112, 34)
            btnSortShellSort.TabIndex = 3
            btnSortShellSort.Text = "Ordenar"
            btnSortShellSort.UseVisualStyleBackColor = True
            ' 
            ' txtInput732
            ' 
            txtInput732.Location = New Point(19, 67)
            txtInput732.Name = "txtInput732"
            txtInput732.Size = New Size(370, 31)
            txtInput732.TabIndex = 2
            ' 
            ' Label38
            ' 
            Label38.AutoSize = True
            Label38.Location = New Point(8, 39)
            Label38.Name = "Label38"
            Label38.Size = New Size(394, 25)
            Label38.TabIndex = 1
            Label38.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label39
            ' 
            Label39.AutoSize = True
            Label39.BackColor = Color.Yellow
            Label39.Location = New Point(159, 14)
            Label39.Name = "Label39"
            Label39.Size = New Size(82, 25)
            Label39.TabIndex = 0
            Label39.Text = "ShellSort"
            ' 
            ' Panel16
            ' 
            Panel16.Controls.Add(btnSortSmoothSort)
            Panel16.Controls.Add(txtNumbers2345)
            Panel16.Location = New Point(1245, 534)
            Panel16.Name = "Panel16"
            Panel16.Size = New Size(405, 209)
            Panel16.TabIndex = 14
            ' 
            ' btnSortSmoothSort
            ' 
            btnSortSmoothSort.Location = New Point(151, 123)
            btnSortSmoothSort.Name = "btnSortSmoothSort"
            btnSortSmoothSort.Size = New Size(112, 34)
            btnSortSmoothSort.TabIndex = 3
            btnSortSmoothSort.Text = "Ordenar"
            btnSortSmoothSort.UseVisualStyleBackColor = True
            ' 
            ' txtNumbers2345
            ' 
            txtNumbers2345.Location = New Point(19, 67)
            txtNumbers2345.Name = "txtNumbers2345"
            txtNumbers2345.Size = New Size(370, 31)
            txtNumbers2345.TabIndex = 2
            ' 
            ' Panel17
            ' 
            Panel17.Controls.Add(txtSortedNumbers09)
            Panel17.Controls.Add(Label40)
            Panel17.Controls.Add(btnSortRadixSor)
            Panel17.Controls.Add(txtInputNumbers76)
            Panel17.Controls.Add(Label41)
            Panel17.Controls.Add(Label42)
            Panel17.Location = New Point(671, 163)
            Panel17.Name = "Panel17"
            Panel17.Size = New Size(405, 200)
            Panel17.TabIndex = 15
            ' 
            ' txtSortedNumbers09
            ' 
            txtSortedNumbers09.Location = New Point(17, 127)
            txtSortedNumbers09.Name = "txtSortedNumbers09"
            txtSortedNumbers09.Size = New Size(372, 31)
            txtSortedNumbers09.TabIndex = 6
            ' 
            ' Label40
            ' 
            Label40.AutoSize = True
            Label40.Location = New Point(124, 99)
            Label40.Name = "Label40"
            Label40.Size = New Size(179, 25)
            Label40.TabIndex = 8
            Label40.Text = "Numeros Ordenados"
            ' 
            ' btnSortRadixSor
            ' 
            btnSortRadixSor.Location = New Point(143, 159)
            btnSortRadixSor.Name = "btnSortRadixSor"
            btnSortRadixSor.Size = New Size(112, 34)
            btnSortRadixSor.TabIndex = 3
            btnSortRadixSor.Text = "Ordenar"
            btnSortRadixSor.UseVisualStyleBackColor = True
            ' 
            ' txtInputNumbers76
            ' 
            txtInputNumbers76.Location = New Point(19, 67)
            txtInputNumbers76.Name = "txtInputNumbers76"
            txtInputNumbers76.Size = New Size(370, 31)
            txtInputNumbers76.TabIndex = 2
            ' 
            ' Label41
            ' 
            Label41.AutoSize = True
            Label41.Location = New Point(8, 39)
            Label41.Name = "Label41"
            Label41.Size = New Size(394, 25)
            Label41.TabIndex = 1
            Label41.Text = "Ingrese 2 Numeros o Mas separados por comas"
            ' 
            ' Label42
            ' 
            Label42.AutoSize = True
            Label42.BackColor = Color.Yellow
            Label42.Location = New Point(159, 14)
            Label42.Name = "Label42"
            Label42.Size = New Size(88, 25)
            Label42.TabIndex = 0
            Label42.Text = "RadixSort"
            ' 
            ' Form1
            ' 
            ClientSize = New Size(1750, 782)
            Controls.Add(Panel17)
            Controls.Add(Panel16)
            Controls.Add(Panel15)
            Controls.Add(Panel14)
            Controls.Add(Panel13)
            Controls.Add(Panel12)
            Controls.Add(Panel11)
            Controls.Add(Panel10)
            Controls.Add(Panel9)
            Controls.Add(Panel7)
            Controls.Add(Panel6)
            Controls.Add(Panel5)
            Controls.Add(Panel4)
            Controls.Add(Panel3)
            Controls.Add(Panel2)
            Controls.Add(Panel1)
            Name = "Form1"
            Panel1.ResumeLayout(False)
            Panel1.PerformLayout()
            Panel2.ResumeLayout(False)
            Panel2.PerformLayout()
            Panel3.ResumeLayout(False)
            Panel3.PerformLayout()
            Panel4.ResumeLayout(False)
            Panel4.PerformLayout()
            Panel5.ResumeLayout(False)
            Panel5.PerformLayout()
            Panel8.ResumeLayout(False)
            Panel8.PerformLayout()
            Panel6.ResumeLayout(False)
            Panel6.PerformLayout()
            Panel7.ResumeLayout(False)
            Panel7.PerformLayout()
            Panel9.ResumeLayout(False)
            Panel9.PerformLayout()
            Panel10.ResumeLayout(False)
            Panel10.PerformLayout()
            Panel11.ResumeLayout(False)
            Panel11.PerformLayout()
            Panel12.ResumeLayout(False)
            Panel12.PerformLayout()
            Panel13.ResumeLayout(False)
            Panel13.PerformLayout()
            Panel14.ResumeLayout(False)
            Panel14.PerformLayout()
            Panel15.ResumeLayout(False)
            Panel15.PerformLayout()
            Panel16.ResumeLayout(False)
            Panel16.PerformLayout()
            Panel17.ResumeLayout(False)
            Panel17.PerformLayout()
            ResumeLayout(False)

        End Sub

        Friend WithEvents btnSort As Button
        Friend WithEvents btnAdd As Button
        Friend WithEvents Panel2 As Panel
        Friend WithEvents btnSortBubble As Button
        Friend WithEvents btnNumbers As TextBox
        Friend WithEvents Label3 As Label
        Friend WithEvents Label4 As Label
        Friend WithEvents Panel3 As Panel
        Friend WithEvents btnSortBucket As Button
        Friend WithEvents txtInput As TextBox
        Friend WithEvents Label5 As Label
        Friend WithEvents Label6 As Label
        Friend WithEvents Panel4 As Panel
        Friend WithEvents TextBox3 As TextBox
        Friend WithEvents Label7 As Label
        Friend WithEvents Label8 As Label
        Friend WithEvents Button4 As Button
        Friend WithEvents Label10 As Label
        Friend WithEvents Label9 As Label
        Friend WithEvents TextBox5 As TextBox
        Friend WithEvents TextBox4 As TextBox
        Friend WithEvents Button3 As Button
        Friend WithEvents Panel5 As Panel
        Friend WithEvents Label13 As Label
        Friend WithEvents btnSortCouting As Button
        Friend WithEvents txtInput2 As TextBox
        Friend WithEvents Label11 As Label
        Friend WithEvents Label12 As Label
        Friend WithEvents txtOutput2 As TextBox
        Friend WithEvents Panel8 As Panel
        Friend WithEvents Button9 As Button
        Friend WithEvents TextBox11 As TextBox
        Friend WithEvents Label19 As Label
        Friend WithEvents Label20 As Label
        Friend WithEvents Panel6 As Panel
        Friend WithEvents btnGenerateArray1 As Button
        Friend WithEvents btnSortGnomeSort As Button
        Friend WithEvents txtInput3 As TextBox
        Friend WithEvents Label14 As Label
        Friend WithEvents Label15 As Label
        Friend WithEvents Panel7 As Panel
        Friend WithEvents txtOutput9 As TextBox
        Friend WithEvents Label16 As Label
        Friend WithEvents btnSortHeapSort As Button
        Friend WithEvents txtInput8 As TextBox
        Friend WithEvents Label17 As Label
        Friend WithEvents Label18 As Label
        Friend WithEvents Panel9 As Panel
        Friend WithEvents btnSortInsertionsort As Button
        Friend WithEvents txtInput34 As TextBox
        Friend WithEvents Label21 As Label
        Friend WithEvents Label22 As Label
        Friend WithEvents Panel10 As Panel
        Friend WithEvents txtOutput11 As TextBox
        Friend WithEvents Label23 As Label
        Friend WithEvents btnSortMargesort As Button
        Friend WithEvents txtInput12 As TextBox
        Friend WithEvents Label24 As Label
        Friend WithEvents Label25 As Label
        Friend WithEvents Panel11 As Panel
        Friend WithEvents txtNumbers98 As TextBox
        Friend WithEvents Label26 As Label
        Friend WithEvents Button12 As Button
        Friend WithEvents lblSortedArray73 As TextBox
        Friend WithEvents Label27 As Label
        Friend WithEvents Label28 As Label
        Friend WithEvents Panel12 As Panel
        Friend WithEvents txtOutput1 As TextBox
        Friend WithEvents Label29 As Label
        Friend WithEvents btnSortCombsort As Button
        Friend WithEvents txtInput1 As TextBox
        Friend WithEvents Label30 As Label
        Friend WithEvents Label31 As Label
        Friend WithEvents Panel13 As Panel
        Friend WithEvents btnSortPigeonholeSort As Button
        Friend WithEvents txtInputNumbers88 As TextBox
        Friend WithEvents Label32 As Label
        Friend WithEvents Label33 As Label
        Friend WithEvents Panel14 As Panel
        Friend WithEvents txtOutput43 As TextBox
        Friend WithEvents Label34 As Label
        Friend WithEvents btnSortQuickSort As Button
        Friend WithEvents txtInput67 As TextBox
        Friend WithEvents Label35 As Label
        Friend WithEvents Label36 As Label
        Friend WithEvents Panel15 As Panel
        Friend WithEvents txtOutput843 As TextBox
        Friend WithEvents Label37 As Label
        Friend WithEvents btnSortShellSort As Button
        Friend WithEvents txtInput732 As TextBox
        Friend WithEvents Label38 As Label
        Friend WithEvents Label39 As Label
        Friend WithEvents txtNumber As TextBox
        Friend WithEvents Panel16 As Panel
        Friend WithEvents btnSortSmoothSort As Button
        Friend WithEvents txtNumbers2345 As TextBox
        Friend WithEvents Panel17 As Panel
        Friend WithEvents txtSortedNumbers09 As TextBox
        Friend WithEvents Label40 As Label
        Friend WithEvents btnSortRadixSor As Button
        Friend WithEvents txtInputNumbers76 As TextBox
        Friend WithEvents Label41 As Label
        Friend WithEvents Label42 As Label

        ' ... (Resto del código convertido)
    End Class
End Namespace
