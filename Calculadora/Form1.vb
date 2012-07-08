Public Class Form1

    Private pilha As Stack(Of Double)
    Private operacao As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pilha = New Stack(Of Double)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        InsereCaractere(0)
    End Sub

    Private Sub Ponto(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        InsereCaractere(",")
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        InsereCaractere(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        InsereCaractere(2)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        InsereCaractere(3)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        InsereCaractere(4)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        InsereCaractere(5)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        InsereCaractere(6)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        InsereCaractere(7)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        InsereCaractere(8)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        InsereCaractere(9)
    End Sub

    Private Sub Deleta(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click        
        Dim text = TextBox1.Text
        Dim size = text.Length

        If size > 0 Then TextBox1.Text = text.Remove(size - 1, 1)

        If TextBox1.TextLength = 0 Or TextBox1.Text.Equals("-") Then
            TextBox1.Text = 0
        End If

        If TextBox1.Text.LastOrDefault() = "," Then
            size = TextBox1.Text.Length
            TextBox1.Text = TextBox1.Text.Remove(size - 1)
        End If

    End Sub

    Private Sub Soma(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Empilha()
        operacao = "+"
    End Sub

    Private Sub ApresentaResultado(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If IsNothing(operacao) Then Exit Sub

        Empilha()

        While pilha.Count > 1
            Dim a, b As Double
            a = pilha.Pop()
            b = pilha.Pop()
            Select Case operacao
                Case "+"
                    pilha.Push(b + a)
                Case "-"
                    pilha.Push(b - a)
                Case "/"
                    pilha.Push(b / a)
                Case "*"
                    pilha.Push(b * a)
            End Select
        End While

        operacao = Nothing
        If pilha.Count > 0 Then TextBox1.Text = pilha.Peek()
        pilha.Clear()

    End Sub

    Private Sub Empilha()
        Dim valido As Boolean
        Dim resultado As Double
        valido = Double.TryParse(TextBox1.Text, resultado)
        If valido Then
            pilha.Push(resultado)            
        End If
        Reset()
    End Sub

    Private Sub InsereCaractere(ByVal c As String)
        If TextBox1.Text.Equals("0") Then
            TextBox1.Text = c
        Else
            TextBox1.AppendText(c)
        End If
    End Sub

    Private Sub Subtrai(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click        
        Empilha()
        operacao = "-"
    End Sub

    Private Sub Multiplica(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Empilha()
        operacao = "*"
    End Sub

    Private Sub Divide(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        Empilha()
        operacao = "/"
    End Sub

    Private Sub Reset()
        TextBox1.Text = 0
    End Sub
End Class
