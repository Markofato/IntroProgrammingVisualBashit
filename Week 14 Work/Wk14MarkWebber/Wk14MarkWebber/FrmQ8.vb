Public Class FrmQ8


    Dim names() As String = {"Name0", "Name1", "Name2", "Name3", "Name4", "Name5", "Name6"} ', "Name7", "Name8", "Name9", "Name10", "Name11", "Name12", "Name13", "Name14", "Name15", "Name16", "Name17", "Name18", "Name19"}
    Dim age() As Integer = {10, 21, 32, 43, 54, 65, 76} ', 87, 98, 109, 1110, 1211, 1312, 1413, 1514, 1615, 1716, 1817, 1918, 2019}
    Dim index As Integer = 6
    'Dim names(20) As String
    'Dim age(20) As Integer
    'Dim index As Integer = 0

    Private Sub btnAppend_Click(sender As Object, e As EventArgs) Handles btnAppend.Click
        Dim nameOkay As Boolean = False
        Dim ageOkay As Boolean = False

        If index >= names.Length - 1 Then 'Array full.
            MessageBox.Show("Array is full.")
            Exit Sub
        Else
            If Not IsNumeric(txtName.Text) And txtName.Text <> Nothing Then
                nameOkay = True
            End If

            If IsNumeric(txtAge.Text) And txtAge.Text <> Nothing Then
                ageOkay = True
            End If
        End If

        If nameOkay And ageOkay Then
            names(index) = txtName.Text
            age(index) = Convert.ToInt16(txtAge.Text)
            index += 1
            txtAge.Clear()
            txtName.Clear()
        Else
            If nameOkay = False Then
                MessageBox.Show("Error with Name.", "Data Entry Error.")
                txtName.Clear()
                txtName.Focus()
            ElseIf ageOkay = False Then
                MessageBox.Show("Error with Age.", "Data Entry Error.")
                txtAge.Clear()
                txtAge.Focus()
            End If

            Exit Sub
        End If
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        Dim ageTotal As Decimal = 0
        Dim ageAverage As Decimal
        Dim abvAgeAvgCounter As Integer = 0
        Dim tempIndex As Integer = 0
        Dim highestIndex As Integer = 0

        For i = 0 To names.Length - 1
            ageTotal += age(i)
        Next
        ageAverage = ageTotal / names.Length

        For i = 0 To names.Length - 1
            If age(i) > ageAverage Then
                lbxNames.Items.Add(names(i))
                abvAgeAvgCounter += 1
            End If
        Next
        txtAboveAverageAge.Text = abvAgeAvgCounter
        txtAverageAge.Text = ageAverage

        'Dim orderedAges(abvAgeAvgCounter) As Integer
        'Dim orderedNames(abvAgeAvgCounter) As String
        Dim tempAge(abvAgeAvgCounter) As Integer
        Dim tempNames(abvAgeAvgCounter) As String

        For i = 0 To names.Length - 1
            If age(i) > ageAverage Then
                tempAge(tempIndex) = age(i)
                tempNames(tempIndex) = names(i)
                tempIndex += 1
            End If
        Next
    End Sub
End Class
