Public Class Form1

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblBread As Double = 0.1
        Dim dblTopping As Double = 0.5
        Dim dblSide As Double = 1.99
        Dim dblTotal As Double
        If radCheeseBurger.Checked = True Then
            lblResult.Text = "You Selected Cheese Burger"
            dblTotal = dblBurger + dblTotal
        ElseIf radChicken.Checked = True Then
            lblResult.Text = "You Selected Chicken Sandwich"
            dblTotal = dblBurger + dblTotal
        ElseIf radHamburger.Checked = True Then
            lblResult.Text = "You Selected Hamburger"
            dblTotal = dblBurger + dblTotal
        ElseIf radBread.Checked = True Then
            lblResult.Text = "You selected Bread"
            dblTotal = dblBread + dblTotal
        End If

        If chkTomato.Checked = True Then
            lblResult.Text &= ", and Tomato"
            dblTotal = dblTopping + dblTotal
        ElseIf chkLettuce.Checked = True Then
            lblResult.Text &= ", and Lettuce"
            dblTotal = dblTopping + dblTotal
        ElseIf chkMayo.Checked = True Then
            lblResult.Text &= ", and Mayo"
            dblTotal = dblTopping + dblTotal
        ElseIf chkBacon.Checked = True Then
            lblResult.Text &= ", and Bacon"
            dblTotal = dblTopping + dblTotal
        End If

        If radFries.Checked = True Then
            lblResult.Text &= ", and Fries"
            dblTotal = dblSide + dblTotal
        ElseIf radOnionRings.Checked = True Then
            lblResult.Text &= ", and Onion Rings"
            dblTotal = dblSide + dblTotal
        ElseIf radChickenTenders.Checked = True Then
            lblResult.Text &= ", and Chicken Tenders "
            dblTotal = dblSide + dblTotal

        End If
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
