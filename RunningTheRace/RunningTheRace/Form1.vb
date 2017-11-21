Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtTime1.Text
        dblTime2 = txtTime2.Text
        dblTime3 = txtTime3.Text

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblPlace1.Text = txtName1.Text
            If dblTime2 < dblTime3 Then
                lblPlace2.Text = txtName2.Text
                lblPlace3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblPlace2.Text = txtName3.Text
                lblPlace3.Text = txtName2.Text
            End If
        End If

    End Sub
End Class
