Public Class Form2

    Private Sub btnproduct_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproduct.Click
        Dim productX5 As Double
        Dim productHP As Double
        Dim TotalSales As Double
        Dim commiionX5 As Double
        Dim commiionHP As Double
        Dim Tolalcommiion As Double

        productX5 = Val(txtx5.Text)
        productHP = Val(txtHP.Text)
        TotalSales = productX5 + productHP

        commiionX5 = productX5 * 0.05
        commiionHP = productHP * 0.1
        Tolalcommiion = commiionX5 + commiionHP

        labTotalsales.Text = TotalSales
        labCommissionX5.Text = commiionX5
        labCommissionHP.Text = commiionHP
        labTotalCommission.Text = Tolalcommiion
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class