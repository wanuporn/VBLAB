Public Class Form1

    Private Sub bntcalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bntcalculate.Click
        lblYear.Text = Val(txtSalary.Text * 12)
        lbltax.Text = Val(lblYear.Text * 5 / 100)
        lblbalance.Text = Val(lblYear.Text - lbltax.Text)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
