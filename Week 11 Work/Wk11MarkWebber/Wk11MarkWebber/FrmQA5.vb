Public Class FrmQA5

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intProduct As Integer
        Dim intStart As Integer
        Dim intRemainder As Integer
        Dim remainderList As New ArrayList

        intStart = Convert.ToInt32(txtInputNumber.Text)
        intProduct = intStart

        Do While intProduct > 0
            intRemainder = intProduct Mod 2
            intProduct = Fix(intProduct / 2)
            remainderList.Add(intRemainder)
        Loop

        remainderList.Reverse()

        Dim ObjectsInList As Integer = remainderList.Count
        Dim binaryNumber As String = ""
        Dim elementNumber As Integer = 0

        Do While ObjectsInList > 0
            binaryNumber = binaryNumber & remainderList.Item(elementNumber)
            elementNumber += 1
            ObjectsInList -= 1
        Loop

        txtBinary.Text = binaryNumber




    End Sub
End Class