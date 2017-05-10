Public Class Form1
    Dim Operando1 As Double
    Dim Operacion As String
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "7"
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "8"
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "9"
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "4"
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "5"
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "6"
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "3"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "2"
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "1"
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If lblResultado.Text = "0" Then
            lblResultado.Text = ""
        End If
        lblResultado.Text &= "0"
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Operando1 = CDbl(lblResultado.Text)
        lblResultado.Text = "0"
        Operacion = "/"
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Operando1 = CDbl(lblResultado.Text)
        lblResultado.Text = "0"
        Operacion = "*"
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnRes_Click(sender As Object, e As EventArgs) Handles btnRes.Click
        Operando1 = CDbl(lblResultado.Text)
        lblResultado.Text = "0"
        Operacion = "-"
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnSum_Click(sender As Object, e As EventArgs) Handles btnSum.Click
        Operando1 = CDbl(lblResultado.Text)
        lblResultado.Text = "0"
        Operacion = "+"
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnIgual_Click(sender As Object, e As EventArgs) Handles btnIgual.Click
        Select Case Operacion
            Case "+"
                lblResultado.Text = Operando1 + CDbl(lblResultado.Text)
            Case "-"
                lblResultado.Text = Operando1 - CDbl(lblResultado.Text)
            Case "*"
                lblResultado.Text = Operando1 * CDbl(lblResultado.Text)
            Case "/"
                lblResultado.Text = Operando1 / CDbl(lblResultado.Text)
        End Select
        btnDecimal.Enabled = True
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        lblResultado.Text = "0"
    End Sub

    Private Sub btnAC_Click(sender As Object, e As EventArgs) Handles btnAC.Click
        lblResultado.Text = "0"
        Operando1 = 0
        Operacion = ""
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        lblResultado.Text &= ","
        btnDecimal.Enabled = False
    End Sub
End Class
