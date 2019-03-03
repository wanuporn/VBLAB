Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSelsctData
    Dim strCon As String = ConfigurationManager.ConnectionStrings("lab1.My.MySettings.myDB").ConnectionString
    Dim myCon As New SqlConnection 'ถนน
    Dim myDA As New SqlDataAdapter 'รถบรรทุก
    Dim myDS As New DataSet 'โกดัง
    Dim strSQL As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "Select * from products"
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro")
        DataGridView1.DataSource = myDS.Tables("myPro")
    End Sub

    Private Sub frmSelsctData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class