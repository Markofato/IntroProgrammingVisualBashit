Public Class FrmQB4

    Dim Months() As String = {"January", "February", "March", "April", _
                              "May", "June", "July", "August", _
                              "September", "October", "November", "December"}

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMonth.Clear()
        txtMonth.Focus()
    End Sub

    Function monthNumXth(ByVal monthNumber As Integer) As String        'Takes in Month Number (Not index)
        Dim xstndrd() As String = {"st", "nd", "rd"}
        Dim xth As String = "th"
        Dim yth As String

        If monthNumber > 3 Then                                         'if outside first three, gives us correct suffix
            yth = xth
        Else
            yth = xstndrd(monthNumber - 1)                              'if within the first three months, gives correct suffix
        End If

        Return monthNumber & yth                                        'returns Month Number and Suffix
    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        Dim monthNumber As Integer
        Dim monthIndex As Integer

        If Not IsNumeric(txtMonth.Text) Then                            'Checks for Number or Text input.
            If Months.Contains(txtMonth.Text) Then                      'Checks if Text Input is inside months()
                Me.Text = "FrmQB5"
                Do Until Months(monthIndex) = txtMonth.Text             'Finds where Text input = Months(monthIndex), giving us the index
                    monthIndex += 1
                Loop
                monthNumber = monthIndex + 1                            'converts Index into it's position in array
                MessageBox.Show("The month " & Months(monthIndex) & " is the " & monthNumXth(monthNumber) & " Month", "Months")
            Else
                MessageBox.Show("A number was not entered.", "Months")
                btnClear.PerformClick()
                Exit Sub
            End If
        Else
            If txtMonth.Text >= 1 And txtMonth.Text <= 12 Then          'Checks if Number Input follows 1 >= x <= 12
                Me.Text = "FrmQB4"
                monthNumber = Convert.ToInt16(txtMonth.Text)
                MessageBox.Show("The " & monthNumXth(monthNumber) & " month is " & Months(monthNumber - 1), "Months")
            Else
                MessageBox.Show("Not a valid month.", "Months")
                btnClear.PerformClick()
                Exit Sub
            End If
        End If


    End Sub
End Class