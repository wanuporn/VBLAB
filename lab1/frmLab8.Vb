Public Class frmLab8
    Dim sumScore As Integer
    Dim sumCredit As Integer
    Dim GPA As Decimal
    Private Sub frmLab8_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
  
    End Sub

    Private Function getCalNewGPA(ByVal score As Integer) As String
        Dim grade As String
        If score >= 80 Then
            grade = "A"
        ElseIf score >= 75 Then
            grade = "B+"
        ElseIf score >= 70 Then
            grade = "B"
        ElseIf score >= 65 Then
            grade = "c+"
        ElseIf score >= 60 Then
            grade = "C"
        ElseIf score >= 55 Then
            grade = "D+"
        ElseIf score >= 50 Then
            grade = "D"
        Else
            grade = "F"

        End If
        Return grade
    End Function
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim grade As String
        If txtSubject.Text = "" Or txtScore.Text = "" Or txtCredit.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Erer", MessageBoxButtons.OK)
            txtSubject.Focus()
            Exit Sub
        Else
            grade = getCalNewGPA(Val(txtScore.Text))
            lstSubject.Items.Add(txtSubject.Text)
            lstScore.Items.Add(Val(txtScore.Text))
            lstCredit.Items.Add(Val(txtCredit.Text))
            lstGrade.Items.Add(grade)


            Call GPANEw()

            txtSubject.Text = ""
            txtScore.Text = ""
            txtCredit.Text = ""
        End If
    End Sub

    Private Sub GPANEw()
        Dim G, gad, sum As Double

        sumScore = Val(Label4.Text)
        sumCredit = Val(lblOldTotalCredit.Text)

        For i = 0 To lstCredit.Items.Count - 1

            sum = lstCredit.Items(i)


            If lstGrade.Items(i) = "A" Then
                gad = 4
            ElseIf lstGrade.Items(i) = "B+" Then
                gad = 3.5
            ElseIf lstGrade.Items(i) = "B" Then
                gad = 3
            ElseIf lstGrade.Items(i) = "C+" Then
                gad = 2.5
            ElseIf lstGrade.Items(i) = "C" Then
                gad = 2
            ElseIf lstGrade.Items(i) = "D+" Then
                gad = 1.5
            ElseIf lstGrade.Items(i) = "D" Then
                gad = 1
            ElseIf lstGrade.Items(i) = "F" Then
                gad = 0
            End If

            sumScore += gad * sum
            sumCredit += sum

        Next

        G = sumScore / sumCredit
        lblNewGPA.Text = G.ToString("n")
    End Sub

    Private Sub lstSubjest_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstSubject.SelectedIndexChanged


        lstScore.SelectedIndex = lstSubject.SelectedIndex
        lstCredit.SelectedIndex = lstSubject.SelectedIndex
        lstGrade.SelectedIndex = lstSubject.SelectedIndex



    End Sub

    Private Sub lstScore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstScore.SelectedIndexChanged
        lstSubject.SelectedIndex = lstScore.SelectedIndex

    End Sub

    Private Sub lstCredit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstCredit.SelectedIndexChanged
        lstSubject.SelectedIndex = lstCredit.SelectedIndex
    End Sub

    Private Sub lstGrade_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstGrade.SelectedIndexChanged
        lstSubject.SelectedIndex = lstGrade.SelectedIndex
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lstCredit.Items.Clear()
        lstSubject.Items.Clear()
        lstScore.Items.Clear()
        lstGrade.Items.Clear()
        txtCredit.Text = ""
        txtScore.Text = ""
        txtSubject.Text = ""
        lblNewGPA.Text = ""

    End Sub

    Private Sub txtScore_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtScore.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

    Private Sub txtCredit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCredit.KeyPress
        If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
            If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 8 Then
                e.KeyChar = Nothing
            End If
        End If
    End Sub

End Class





