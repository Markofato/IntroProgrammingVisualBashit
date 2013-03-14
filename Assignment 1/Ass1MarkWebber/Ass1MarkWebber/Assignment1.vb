'Name: Mark Webber
'Date: 05/03/2013
'Assignment 1 - Calculator

Public Class Assignment1

    Private Sub txtNumber1_GotFocus(sender As Object, e As System.EventArgs) Handles txtNumber1.GotFocus
        'when person(s) click on txt box corrisponding to label "Number 1", clears all texts boxes and removes signs
        txtNumber1.Clear()
        txtNumber2.Clear()
        txtAnswer.Clear()
        lblActiveSign.Visible = False
        lblEqualsSign.Visible = False
    End Sub

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        Dim decNumber1 As Decimal
        Dim decNumber2 As Decimal

        'Double checks input is numerical
        If Not IsNumeric(txtNumber1.Text) Then
            MessageBox.Show("The value of Number 1 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber1.Clear()
            txtNumber1.Focus()
            Exit Sub
        End If

        'Double checks input is numerical
        If Not IsNumeric(txtNumber2.Text) Then
            MessageBox.Show("The value of number 2 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        decNumber1 = Convert.ToDecimal(txtNumber1.Text)
        decNumber2 = Convert.ToDecimal(txtNumber2.Text)

        'Displays correct sign and changes them to visible.
        lblActiveSign.Text = "+"
        lblActiveSign.Visible = True
        lblEqualsSign.Visible = True

        'If both values are numerical, add Number 1 and 2 together and return the answer.
        txtAnswer.Text = decNumber1 + decNumber2
    End Sub

    Private Sub btnMinus_Click(sender As System.Object, e As System.EventArgs) Handles btnMinus.Click
        Dim decNumber1 As Decimal
        Dim decNumber2 As Decimal

        'Double checks input is numerical
        If Not IsNumeric(txtNumber1.Text) Then
            MessageBox.Show("The value of Number 1 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber1.Clear()
            txtNumber1.Focus()
            Exit Sub
        End If

        'Double checks input is numerical
        If Not IsNumeric(txtNumber2.Text) Then
            MessageBox.Show("The value of number 2 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        decNumber1 = Convert.ToDecimal(txtNumber1.Text)
        decNumber2 = Convert.ToDecimal(txtNumber2.Text)

        'Displays correct sign and changes them to visible.
        lblActiveSign.Text = "-"
        lblActiveSign.Visible = True
        lblEqualsSign.Visible = True

        'If both values are numerical, subtract Number 2 from Number 1 and return the answer.
        txtAnswer.Text = decNumber1 - decNumber2
    End Sub

    Private Sub btnDivide_Click(sender As System.Object, e As System.EventArgs) Handles btnDivide.Click
        Dim decNumber1 As Decimal
        Dim decNumber2 As Decimal

        'Double checks input is numerical
        If Not IsNumeric(txtNumber1.Text) Then
            MessageBox.Show("The value of Number 1 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber1.Clear()
            txtNumber1.Focus()
            Exit Sub
        End If

        'Double checks input is numerical
        If Not IsNumeric(txtNumber2.Text) Then
            MessageBox.Show("The value of number 2 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        decNumber1 = Convert.ToDecimal(txtNumber1.Text)
        decNumber2 = Convert.ToDecimal(txtNumber2.Text)

        'Displays correct sign and changes them to visible.
        lblActiveSign.Text = "/"
        lblActiveSign.Visible = True
        lblEqualsSign.Visible = True

        'Checker for Number 2 = 0, if this is the case, return error and exit sub.
        If decNumber2 = 0 Then
            MessageBox.Show("Cannot divide by 0.")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If
        'If both values are numerical, Divide Number 1 by Number 2 and return the answer.
        txtAnswer.Text = decNumber1 / decNumber2
    End Sub

    Private Sub btnMultiply_Click(sender As System.Object, e As System.EventArgs) Handles btnMultiply.Click
        Dim decNumber1 As Decimal
        Dim decNumber2 As Decimal

        'Double checks input is numerical
        If Not IsNumeric(txtNumber1.Text) Then
            MessageBox.Show("The value of Number 1 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber1.Clear()
            txtNumber1.Focus()
            Exit Sub
        End If

        'Double checks input is numerical
        If Not IsNumeric(txtNumber2.Text) Then
            MessageBox.Show("The value of number 2 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        'Displays correct sign and changes them to visible.
        lblActiveSign.Text = "x"
        lblActiveSign.Visible = True
        lblEqualsSign.Visible = True

        decNumber1 = Convert.ToDecimal(txtNumber1.Text)
        decNumber2 = Convert.ToDecimal(txtNumber2.Text)

        'If both values are numerical, Multiply Number 1 and 2 then return the answer.
        txtAnswer.Text = decNumber1 * decNumber2
    End Sub

    Private Sub btnMod_Click(sender As System.Object, e As System.EventArgs) Handles btnMod.Click
        Dim decNumber1 As Decimal
        Dim decNumber2 As Decimal

        'Double checks input is numerical
        If Not IsNumeric(txtNumber1.Text) Then
            MessageBox.Show("The value of Number 1 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber1.Clear()
            txtNumber1.Focus()
            Exit Sub
        End If

        'Double checks input is numerical
        If Not IsNumeric(txtNumber2.Text) Then
            MessageBox.Show("The value of number 2 isn't numerical, re-enter.", "Data Entry Error")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        decNumber1 = Convert.ToDecimal(txtNumber1.Text)
        decNumber2 = Convert.ToDecimal(txtNumber2.Text)

        'Displays correct sign and changes them to visible.
        lblActiveSign.Text = "%"
        lblActiveSign.Visible = True
        lblEqualsSign.Visible = True

        'Checker for Number 2 = 0, if this is the case, return error and exit sub.
        If decNumber2 = 0 Then
            MessageBox.Show("Cannot divide by 0.")
            txtNumber2.Clear()
            txtNumber2.Focus()
            Exit Sub
        End If

        'If both values are numerical, Num 1 divide Num 2 and return the remainder.
        txtAnswer.Text = decNumber1 Mod decNumber2
    End Sub
End Class
