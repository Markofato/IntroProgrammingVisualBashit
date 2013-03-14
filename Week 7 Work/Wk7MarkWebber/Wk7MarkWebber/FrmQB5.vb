Public Class FrmQB5

    Private Sub btnConvert_Click(sender As System.Object, e As System.EventArgs) Handles btnConvert.Click
        Dim intInputTime As Integer = Convert.ToInt32(txtInputTime.Text)
        Dim intHours As Integer
        Dim intMinutes As Integer
        Dim ampm As String
        Dim extraZero As String

        'breaks up the 24hr number into Hours and Minutes respectively.
        intHours = Fix(intInputTime / 100)
        intMinutes = intInputTime Mod 100

        'checks for hours <24 and minutes <60
        If intHours >= 24 Or intMinutes >= 60 Then
            MessageBox.Show("The Amount is not a valid time", "Data Entry Error")
            txtInputTime.Clear()
            txtInputTime.Focus()
            Exit Sub
        End If

        If intHours <= 12 Then 'checks if before or equal to noon
            If intHours = 0 Then 'if 00xx convert hours to 12AM
                intHours = 12
                ampm = "AM"
            ElseIf intHours = 12 Then 'if 12xx convert <ampm> to PM
                intHours = intHours
                ampm = "PM"
            Else
                intHours = intHours 'converts before noon hours times to AM
                ampm = "AM"
            End If
        Else
            intHours = intHours - 12 'remainder hours converted to PM
            ampm = "PM"
        End If

        If intMinutes < 10 Then
            extraZero = "0"
        Else
            extraZero = ""
        End If

        txtOutputTime.Text = intHours & ":" & extraZero & intMinutes & ampm
    End Sub
End Class