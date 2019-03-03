
Public Class frms
    Dim s1 As Double 'กว้าง
    Dim s2 As Double 'ยาว
    Dim sto As Double

    Dim n1 As Double
    Dim n2 As Double
    Dim nto As Double
    Dim n3 As Double
    Dim n4 As Double
    Dim nto1, totel As Double
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click, Label10.Click, Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox6.TextChanged, TextBox5.TextChanged, TextBox3.TextChanged, TextBox7.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        s1 = Val(TextBox1.Text)
        s2 = Val(TextBox2.Text)
            sto = s1 * s2
        n1 = sto * 50
        TextBox7.Text = n1

        n2 = sto * 5
        TextBox3.Text = n1

        n3 = sto / 600
        n3 = Math.Round(n3) + 1
        TextBox5.Text = n3

        n4 = Val(TextBox6.Text)
            nto = n1 * n2
            nto1 = (n1 * n3) + n4
            Label1.Text = sto
            totel = nto + nto1
            Label12.Text = totel

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged, RadioButton2.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)


    End Sub
End Class