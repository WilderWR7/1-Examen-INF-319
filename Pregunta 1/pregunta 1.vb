Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Function MayorDosNumeros(ByVal x As Integer, ByVal y As Integer) As Integer
        If (x > y) Then
            Return x
        Else
            Return y
        End If
    End Function

    Function MenorDosNumeros(ByVal x As Integer, ByVal y As Integer) As Integer
        If (x < y) Then
            Return x
        Else
            Return y
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim a, b, c, d, f As Integer
        a = Convert.ToInt32(TextBox1.Text)
        b = Convert.ToInt32(TextBox2.Text)
        c = Convert.ToInt32(TextBox4.Text)

        If (a >= b And a >= c) Then
            GoTo MayorPrimero
        ElseIf (b >= a And b >= c) Then
            GoTo MayorSegundo
        Else
            GoTo MayorTercero
        End If

MayorPrimero:
        d = MayorDosNumeros(c, b)
        f = MenorDosNumeros(c, b)

        TextBox3.Text = "Mayor es " + a.ToString() + ", Medio " + d.ToString() + ", Menor " + f.ToString()

        GoTo salir
MayorSegundo:
        d = MayorDosNumeros(a, c)
        f = MenorDosNumeros(a, c)
        TextBox3.Text = "Mayor es " + b.ToString() + ", Medio " + d.ToString() + ", Menor " + f.ToString()
        GoTo salir

MayorTercero:
        d = MayorDosNumeros(b, a)
        f = MenorDosNumeros(b, a)
        TextBox3.Text = "Mayor es " + c.ToString() + ", Medio " + d.ToString() + ", Menor " + f.ToString()
        GoTo salir
salir:

    End Sub
End Class
