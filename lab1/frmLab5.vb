Public Class frmLab5
    Dim decTotal, decDiscount, decNet, decCredit As Double
    Private Sub btuCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btuCalculate.Click
        Dim num As String = txtProduct.Text
        Dim num1 As Integer = Val(txtPrice.Text)
        Dim num2 As Integer = Val(txtUni.Text)
        decTotal = Val(txtUni.Text) * Val(txtPrice.Text)
        If num = "" Or num2 = 0 Or num1 = 0 Then
            MessageBox.Show("ป้อนข้อมูลให้สมบูรณ์")
        Else
            If radMember.Checked = True And radPaid.Checked = True Then
                If lblTotal.Text < 1000 Then
                    decDiscount = 0

                ElseIf lblTotal.Text < 5000 Then
                    decDiscount = 0.05 * decTotal


                ElseIf lblTotal.Text < 10000 Then
                    decDiscount = 0.1 * decTotal


                Else
                    decDiscount = 0.15 * decTotal

                End If
                decNet = decTotal - decDiscount
                decCredit = 0

            ElseIf radMember.Checked = True And radCredit.Checked = True Then
                decDiscount = 0
                decNet = decTotal
                decCredit = decTotal

            Else
                decDiscount = 0
                decNet = decTotal
                decCredit = 0
            End If
            lblCredit.Text = decCredit
            lblDiscount.Text = decDiscount
            lblPaid.Text = decNet
        End If

    End Sub

    Private Sub frmLab5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
    End Sub

    Private Sub txtPrice_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrice.TextChanged
        lblTotal.Text = Val(txtUni.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub txtUni_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUni.TextChanged
        lblTotal.Text = Val(txtUni.Text) * Val(txtPrice.Text)
    End Sub

    Private Sub radOther_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.Click
       
    End Sub

    Private Sub radMember_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.CheckedChanged
      
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = True
    End Sub

    Private Sub radMember_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radMember.Click
       
    End Sub

    Private Sub radPaid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radPaid.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radCaedit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radCredit.Click
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
    End Sub

    Private Sub radOther_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radOther.CheckedChanged
        lblDiscount.Text = ""
        lblPaid.Text = ""
        lblCredit.Text = ""
        gpbPaid.Enabled = False
        radPaid.Checked = True
    End Sub
End Class