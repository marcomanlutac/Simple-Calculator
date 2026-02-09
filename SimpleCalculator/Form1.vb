Public Class Form1
    Private Sub Num_Click(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click

        Dim ButtonValue As Button = CType(sender, Button)
        If txtNumbers.Text = "Syntax Error" Then

        Else
            txtNumbers.Text &= ButtonValue.Text
        End If


    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtNumbers.Text = String.Empty Then

        Else
            txtNumbers.Text &= "0"
        End If


    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnPeriod.Click
        If txtNumbers.Text = String.Empty Then
            txtNumbers.Text &= "0."
        ElseIf Not txtNumbers.Text.Contains(".") Then
            txtNumbers.Text &= "."
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumbers.Text = ""
    End Sub

    Private Sub Operations(sender As Object, e As EventArgs) Handles btnAdd.Click, btnMinus.Click, btnDivide.Click, btnMultiply.Click
        txtNumbers.Text &= CType(sender, Button).Text
    End Sub

    Private Sub btnResult_Click(sender As Object, e As EventArgs) Handles btnResult.Click


        Try
            Dim expression As String = txtNumbers.Text
            Dim result As Object
            Dim table As New DataTable

            result = table.Compute(expression, String.Empty)

            txtNumbers.Text = result.ToString
        Catch ex As Exception
            txtNumbers.Text = "Syntax Error"
        End Try
    End Sub
End Class
