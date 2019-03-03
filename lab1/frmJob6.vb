Public Class frmJob6
    Dim total As Integer
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click, Label4.Click, Label12.Click, Label11.Click

    End Sub

    Private Sub chkcarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkcarForMe.CheckedChanged
        If chkcarForMe.Checked Then
            GroupBox1.Enabled = True
            GroupBox2.Enabled = True
            lblPaidPrice.Enabled = True
            lblPaidPrice.Text = total
        Else
            If MsgBox("คุณต้องการยกเลิกการซื้อรถใช่หรือไม่ใช่", vbYesNo) = vbYes Then
                GroupBox1.Enabled = False
                GroupBox2.Enabled = False
                chkItemsAdd1.Checked = False
                chkItemsAdd2.Checked = False
                chkItemsAdd3.Checked = False
                chkItemsAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""

            Else
                chkcarForMe.Checked = True
            End If
        End If
    End Sub

    Private Sub frmJob6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False
        lblPaidPrice.Enabled = False
        total = Val(lblSartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
        lblPaidPrice.Text = total
    End Sub

    Private Sub chkItemsAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd1.CheckedChanged
        If chkItemsAdd1.Checked Then
            total = Val(lblItemsPrice1.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPrice1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd2.CheckedChanged
        If chkItemsAdd2.Checked Then
            total = Val(lblItemsPrice2.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPrice2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd3.CheckedChanged
        If chkItemsAdd3.Checked Then
            total = Val(lblItemsPrice3.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPrice3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkItemsAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemsAdd4.CheckedChanged
        If chkItemsAdd4.Checked Then
            total = Val(lblItemsPrice4.Text) + Val(lblPaidPrice.Text)
            lblPaidPrice.Text = total
        Else
            total -= (lblItemsPrice4.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            total -= Val(lblFree1.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree1.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            total -= Val(lblFree2.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree2.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            total -= Val(lblFree3.Text)
            lblPaidPrice.Text = total
        Else
            total = Val(lblPaidPrice.Text) + Val(lblFree3.Text)
            lblPaidPrice.Text = total
        End If
    End Sub

    Private Sub lblSartPrice_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSartPrice.Click

    End Sub

    Private Sub lblPaidPrice_Click(sender As Object, e As EventArgs) Handles lblPaidPrice.Click

    End Sub
End Class