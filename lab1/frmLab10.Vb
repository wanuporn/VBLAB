Public Class frmLab10
    Dim decSale(4, 2), i As Integer
    Dim saleName(4) As String
    Dim intIndex As Decimal
    Dim decSumSale As Decimal
    Dim cnt As Integer
    Dim sale(2) As Integer

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        cnt = cboIndex.SelectedIndex

        If Not IsNumeric(txtSaleA.Text) Or Not IsNumeric(txtSaleB.Text) Or Not IsNumeric(txtSaleC.Text) Then
            MessageBox.Show("กรุณาป้อนข้อมูลให้ครบ")
            txtSaleA.Clear()
            txtSaleB.Clear()
            txtSaleC.Clear()
            txtSaleA.Focus()
        Else
            sale(0) = Val(txtSaleA.Text)
            sale(1) = Val(txtSaleB.Text)
            sale(2) = Val(txtSaleC.Text)

            For i = 0 To 2
                saleName(cnt) = txtSaleName.Text
                decSale(cnt, i) = sale(i)
            Next

            Call showData()

        End If

    End Sub
    Private Sub showData()
        Dim SaleA, SaleB, SaleC As Integer
        lstData.Items.Clear()
        For i = 0 To cboIndex.Items.Count - 1
            lstData.Items.Add(saleName(i) & "," & decSale(i, 0) & "," & decSale(i, 1) & "," & decSale(i, 2))
        Next
        For i = 0 To 4
            SaleA = SaleA + decSale(i, 0)
            SaleB = SaleB + decSale(i, 1)
            SaleC = SaleC + decSale(i, 2)
        Next
        lblSumA.Text = SaleA
        lblSumB.Text = SaleB
        lblSumC.Text = SaleC

        Dim max As Integer = decSale(0, 0) + decSale(0, 1) + decSale(0, 2)
        Dim n As Integer = 0
        For i = 1 To cboIndex.Items.Count - 1
            If max < decSale(i, 0) + decSale(i, 1) + decSale(i, 2) Then
                max = decSale(i, 0) + decSale(i, 1) + decSale(i, 2)
                n = i
            End If
            lblMaxSaleAmount.Text = max
            lblMaxSaleName.Text = saleName(n)
        Next
    End Sub

    Private Sub lblMaxSaleName_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub lblMaxSaleName_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboIndex.SelectedIndex = 0
    End Sub
End Class