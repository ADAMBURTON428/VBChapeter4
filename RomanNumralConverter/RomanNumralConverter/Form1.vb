Public Class Form1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumber As Integer

        Try
            intnumber = txtRange.Text
            If intNumber = 1 Then
                lblNumeral.Text = "I"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 2 Then
                lblNumeral.Text = "II"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 3 Then
                lblNumeral.Text = "III"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 4 Then
                lblNumeral.Text = "IV"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 5 Then
                lblNumeral.Text = "V"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 6 Then
                lblNumeral.Text = "VI"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 7 Then
                lblNumeral.Text = "VII"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 8 Then
                lblNumeral.Text = "VIII"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 9 Then
                lblNumeral.Text = "IX"
                lblError.Text = "Good you can count"
            ElseIf intNumber = 10 Then
                lblNumeral.Text = "X"
                lblError.Text = "Good you can count"
            ElseIf intNumber > 10 Then
                lblError.Text = "Make sure it is between 1 and 10."
            End If

        Catch
            lblError.Text = "Enter a number."
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
