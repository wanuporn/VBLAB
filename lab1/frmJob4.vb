Public Class frmJob4

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Dim bonus As Double = 0.2
        Dim allow As Double = 0.01
        Dim tax As Double = 0.07
        Dim datNowDate As Double
        Dim dblTaerSalary As Double
        Dim dblBonus As Double
        Dim dblAllIncome As Double
        Dim dblAllowance As Double
        Dim dblTax As Double

        dblTaerSalary = Val(txtSalary.Text)
        dblTaerSalary = dblTaerSalary * 12

        dblBonus = Val(txtSale.Text)
        dblBonus = dblBonus * bonus

        dblAllIncome = Val(lblAllIncoms.Text)
        dblAllIncome = dblTaerSalary + dblBonus

        dblAllowance = Val(lblAllowance.Text)
        dblAllowance = dblAllIncome * allow

        dblTax = Val(lblTax.Text)
        dblTax = (dblAllIncome - dblAllowance) * tax

        lblYearSalary.Text = dblTaerSalary.ToString("#,###.##")
        lblBonus.Text = dblBonus.ToString("#,###.##")
        lblAllIncoms.Text = dblAllIncome.ToString("#,###.##")
        lblAllowance.Text = dblAllowance.ToString("#,###.##")
        lblTax.Text = dblTax.ToString("#,###.##")
    End Sub

    Private Sub frmJob4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Date.Now
    End Sub

    Private Sub radShortDatte_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDatte.CheckedChanged

    End Sub

    Private Sub radShortDatte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDatte.Click
        lblDate.Text = Format(Now, "Short Date")
    End Sub

    Private Sub radGenDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.Click
        lblDate.Text = Format(Now, "General Date")
    End Sub

    Private Sub radLongDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.Click
        lblDate.Text = Format(Now, "long Date")
    End Sub
End Class