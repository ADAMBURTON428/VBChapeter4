Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim intPassword As Integer = 1234

        If txtPassword.Text = intPassword Then
            MessageBox.Show("Hello you are right")
        Else
            MessageBox.Show("Are you even trying")

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
