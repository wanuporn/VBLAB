Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class frmLab11
    Dim strCon As String = ConfigurationManager.ConnectionStrings("lab1.My.MySettings.myDB").ConnectionString
    Dim myCon As New SqlConnection
    Dim myDA As New SqlDataAdapter
    Dim myDS As New DataSet
    Dim strSQL As String
    Private Sub frmLab11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "Select * from products WHERE productname LIKE 'N%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro")
        dgvdata.DataSource = myDS.Tables("myPro")
        myCon.Close()
    End Sub
    Private Sub btnchoice1_Click(sender As Object, e As EventArgs) Handles btnchoice1.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "Select * from products WHERE productname LIKE 'N%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro1")
        dgvdata.DataSource = myDS.Tables("myPro1")
        myCon.Close()
    End Sub

    Private Sub btnchoice2_Click(sender As Object, e As EventArgs) Handles btnchoice2.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "select* , (unitprice *unitsinstock)from Products where productid in (64)"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro2")
        dgvdata.DataSource = myDS.Tables("myPro2")
        myCon.Close()
    End Sub

    Private Sub btnchoice3_Click(sender As Object, e As EventArgs) Handles btnchoice3.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT COUNT(*) AS BrazilCustomers FROM Customers WHERE country LIKE '%BRAZIL%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro3")
        dgvdata.DataSource = myDS.Tables("myPro3")
        myCon.Close()

    End Sub

    Private Sub btnchoice4_Click(sender As Object, e As EventArgs) Handles btnchoice4.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT productname,quantity,contactname  FROM Customers,Orders,[Order Details],Products WHERE Customers.customerID = Orders.customerID AND Orders.orderID = [Order Details].orderID AND [Order Details].productID = Products.productID AND contactname LIKE 'Yang Wang'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro4")
        dgvdata.DataSource = myDS.Tables("myPro4")
        myCon.Close()
    End Sub

    Private Sub btnchoice5_Click(sender As Object, e As EventArgs) Handles btnchoice5.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT  productname,unitsinstock FROM Products WHERE unitsinstock < 10"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro5")
        dgvdata.DataSource = myDS.Tables("myPro5")
        myCon.Close()
    End Sub

    Private Sub btnchoice6_Click(sender As Object, e As EventArgs) Handles btnchoice6.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT * FROM [Order Details],Products WHERE [Order Details].ProductID = Products.ProductID AND OrderID LIKE 10255"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro6")
        dgvdata.DataSource = myDS.Tables("myPro6")
        myCon.Close()
    End Sub

    Private Sub btnchoice7_Click(sender As Object, e As EventArgs) Handles btnchoice7.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT SUM(unitprice * quantity) AS TotalSale  FROM [Order Details] WHERE OrderID LIKE 10255"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro7")
        dgvdata.DataSource = myDS.Tables("myPro7")
        myCon.Close()
    End Sub

    Private Sub btnchoice8_Click(sender As Object, e As EventArgs) Handles btnchoice8.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT Orders.OrderID,* FROM Customers,Orders WHERE Customers.customerID = Orders.customerID AND OrderID LIKE '10347'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro8")
        dgvdata.DataSource = myDS.Tables("myPro8")
        myCon.Close()
    End Sub

    Private Sub btnchoice9_Click(sender As Object, e As EventArgs) Handles btnchoice9.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT Suppliers.companyname,Orders.orderid,Orders.orderdate,Products.productname,Products.unitprice,[Order Details].quantity FROM Orders,[Order Details],Products,Suppliers WHERE Orders.orderid = [Order Details].orderid AND [Order Details].productid = Products.productid AND Products.supplierid = Suppliers.supplierid AND Suppliers.companyname LIKE '%Exotic Liquids%'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro9")
        dgvdata.DataSource = myDS.Tables("myPro9")
    End Sub

    Private Sub btnchoice10_Click(sender As Object, e As EventArgs) Handles btnchoice10.Click
        If myCon.State = ConnectionState.Open Then
            myCon.Close()
        End If
        myCon.ConnectionString = strCon
        myCon.Open()

        strSQL = "SELECT COUNT(*) AS CountOrder FROM Customers,Orders,[Order Details],Products WHERE Customers.customerid = Orders.customerid AND Orders.orderid = [Order Details].orderid AND [Order Details].productid = Products.productid AND Customers.country LIKE 'ITALY'"
        myDS.Clear()
        myDA = New SqlDataAdapter(strSQL, myCon)
        myDA.Fill(myDS, "myPro10")
        dgvdata.DataSource = myDS.Tables("myPro10")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class