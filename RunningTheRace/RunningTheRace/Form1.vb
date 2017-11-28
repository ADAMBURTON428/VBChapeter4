Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = (txtTime1.Text)
        dblTime2 = (txtTime2.Text)
        dblTime3 = (txtTime3.Text)

        If dblTime1 < dblTime2 And dblTime1 < dblTime3 Then
            lblPlace1.Text = (txtName1.Text)
            If dblTime2 < dblTime3 Then
                lblPlace2.Text = txtName2.Text
                lblPlace3.Text = txtName3.Text
            ElseIf dblTime3 < dblTime2 Then
                lblPlace2.Text = txtName3.Text
                lblPlace3.Text = txtName2.Text
            End If
            If dblTime2 < dblTime1 And dblTime2 < dblTime3 Then
                lblPlace1.Text = (txtName2.Text)
                If dblTime1 < dblTime3 Then
                    lblPlace2.Text = txtName1.Text
                    lblPlace2.Text = txtName3.Text
                ElseIf dblTime3 < dblTime1 Then
                    lblPlace2.Text = txtName3.Text
                    lblPlace3.Text = txtName1.Text
                End If
            End If
            If dblTime3 < dblTime1 And dblTime3 < dblTime2 Then
                lblPlace1.Text = (txtName3.Text)
                If dblTime1 < dblTime2 Then
                    lblPlace2.Text = txtName1.Text
                    lblPlace3.Text = txtName2.Text
                ElseIf dblTime2 < dblTime1 Then
                    lblPlace2.Text = txtName2.Text
                    lblPlace3.Text = txtName1.Text
                End If
            End If

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtName1.Clear()
        txtName2.Clear()
        txtName3.Clear()
        txtTime1.Clear()
        txtTime2.Clear()
        txtTime3.Clear()
        lblPlace1.Text = String.Empty
        lblPlace2.Text = String.Empty
        lblPlace3.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
