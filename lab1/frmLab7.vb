Public Class frmLab7

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click, lblOutput.Click

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        Dim num As Integer
        num = lstAdd.Items.Count
        lstAdd.SelectedIndex = num - 1
        num = cboOutput.Items.Count
        cboOutput.SelectedIndex = num - 1
    End Sub

    Private Sub frmLab7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub

    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If

    End Sub

    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรอกข้อมูล")
            Exit Sub
        Else
            Dim ann As Integer = lstAdd.SelectedIndex
            cboOutput.Items.Add(lstAdd.SelectedIndex)
            cboOutput.SelectedIndex = cboOutput.Items.Count - 1
            lstAdd.Items.Remove(lstAdd.SelectedItem)
            If lstAdd.Items.Count <> 0 Then
                If lstAdd.Items.Count <= ann Then
                    lstAdd.SelectedIndex = lstAdd.Items.Count - 1
                Else
                    lstAdd.SelectedIndex = ann
                End If
            End If
        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรอกข้อมูล")
            Exit Sub
        Else
            For Each Item In lstAdd.Items
                cboOutput.Items.Add(Item)
            Next
            lstAdd.Items.Clear()
            Dim ann1 As Integer
            ann1 = lstAdd.Items.Count
            lstAdd.SelectedIndex = ann1 - 1
            ann1 = cboOutput.Items.Count
            cboOutput.SelectedIndex = ann1 - 1
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรอกข้อมูล")
            Exit Sub
        Else
            lstAdd.Items.Add(cboOutput.Text)
            cboOutput.Items.Remove(cboOutput.Text)
            Dim ann1 As Integer
            ann1 = lstAdd.Items.Count
            lstAdd.SelectedIndex = ann1 - 1
            ann1 = cboOutput.Items.Count
            cboOutput.SelectedIndex = ann1 - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรอกข้อมูล")
            Exit Sub
        Else
            For Each Item In cboOutput.Items()
                lstAdd.Items.Add(Item)

            Next
            cboOutput.Items.Clear()
            lblOutput.Text = ""
            Dim ann1 As Integer
            ann1 = lstAdd.Items.Count
            'lstAdd.SelectedIndex = ann1 - 1
            cboOutput.Text = ""
            lstAdd.SelectedIndex = ann1 - 1
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btuClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btuClear.Click
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
        txtAdd.Text = ""
        lblOutput.Text = ""
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = Val(cboOutput.Text)
    End Sub

    Private Sub lstAdd_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstAdd.SelectedIndexChanged
        lblOutput.Text = lstAdd.SelectedItem
    End Sub
End Class