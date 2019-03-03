<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.cboIndex = New System.Windows.Forms.ComboBox()
        Me.txtSaleName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblSumA = New System.Windows.Forms.Label()
        Me.lblSumB = New System.Windows.Forms.Label()
        Me.lblSumC = New System.Windows.Forms.Label()
        Me.lblMaxSaleName = New System.Windows.Forms.Label()
        Me.lblMaxSaleAmount = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtSaleA = New System.Windows.Forms.TextBox()
        Me.txtSaleB = New System.Windows.Forms.TextBox()
        Me.txtSaleC = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(242, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(257, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณยอดขายจากอาร์เรย์"
        '
        'lstData
        '
        Me.lstData.FormattingEnabled = True
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(93, 109)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(202, 180)
        Me.lstData.TabIndex = 1
        '
        'cboIndex
        '
        Me.cboIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndex.FormattingEnabled = True
        Me.cboIndex.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cboIndex.Location = New System.Drawing.Point(93, 330)
        Me.cboIndex.Name = "cboIndex"
        Me.cboIndex.Size = New System.Drawing.Size(121, 24)
        Me.cboIndex.TabIndex = 2
        '
        'txtSaleName
        '
        Me.txtSaleName.Location = New System.Drawing.Point(94, 418)
        Me.txtSaleName.Multiline = True
        Me.txtSaleName.Name = "txtSaleName"
        Me.txtSaleName.Size = New System.Drawing.Size(121, 33)
        Me.txtSaleName.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(314, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รวมยอดขายสินค้า A"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(314, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "รวมยอดขายสินค้า B"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(314, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 23)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "รวมยอดขายสินค้า C"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 309)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(169, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ผู้ที่ทำยอดขายสูงสุด"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(314, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(169, 23)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "เป็นเงิน"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "พนักงานขายคนที่"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(90, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 23)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "ชื่อพนง. ขาย"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(96, 81)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "รายการข้อมูล"
        '
        'lblSumA
        '
        Me.lblSumA.BackColor = System.Drawing.Color.Pink
        Me.lblSumA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumA.Location = New System.Drawing.Point(500, 112)
        Me.lblSumA.Name = "lblSumA"
        Me.lblSumA.Size = New System.Drawing.Size(130, 32)
        Me.lblSumA.TabIndex = 0
        '
        'lblSumB
        '
        Me.lblSumB.BackColor = System.Drawing.Color.Pink
        Me.lblSumB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumB.Location = New System.Drawing.Point(500, 153)
        Me.lblSumB.Name = "lblSumB"
        Me.lblSumB.Size = New System.Drawing.Size(130, 32)
        Me.lblSumB.TabIndex = 0
        '
        'lblSumC
        '
        Me.lblSumC.BackColor = System.Drawing.Color.Pink
        Me.lblSumC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSumC.Location = New System.Drawing.Point(500, 194)
        Me.lblSumC.Name = "lblSumC"
        Me.lblSumC.Size = New System.Drawing.Size(130, 32)
        Me.lblSumC.TabIndex = 0
        '
        'lblMaxSaleName
        '
        Me.lblMaxSaleName.BackColor = System.Drawing.Color.Pink
        Me.lblMaxSaleName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSaleName.Location = New System.Drawing.Point(500, 304)
        Me.lblMaxSaleName.Name = "lblMaxSaleName"
        Me.lblMaxSaleName.Size = New System.Drawing.Size(130, 32)
        Me.lblMaxSaleName.TabIndex = 0
        '
        'lblMaxSaleAmount
        '
        Me.lblMaxSaleAmount.BackColor = System.Drawing.Color.Pink
        Me.lblMaxSaleAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaxSaleAmount.Location = New System.Drawing.Point(500, 340)
        Me.lblMaxSaleAmount.Name = "lblMaxSaleAmount"
        Me.lblMaxSaleAmount.Size = New System.Drawing.Size(130, 32)
        Me.lblMaxSaleAmount.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Gray
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(252, 391)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(373, 23)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "ยอดขาย A             ยอดขาย B          ยอดขาย C"
        '
        'txtSaleA
        '
        Me.txtSaleA.Location = New System.Drawing.Point(250, 418)
        Me.txtSaleA.Multiline = True
        Me.txtSaleA.Name = "txtSaleA"
        Me.txtSaleA.Size = New System.Drawing.Size(121, 33)
        Me.txtSaleA.TabIndex = 3
        '
        'txtSaleB
        '
        Me.txtSaleB.Location = New System.Drawing.Point(377, 418)
        Me.txtSaleB.Multiline = True
        Me.txtSaleB.Name = "txtSaleB"
        Me.txtSaleB.Size = New System.Drawing.Size(121, 33)
        Me.txtSaleB.TabIndex = 3
        '
        'txtSaleC
        '
        Me.txtSaleC.Location = New System.Drawing.Point(504, 418)
        Me.txtSaleC.Multiline = True
        Me.txtSaleC.Name = "txtSaleC"
        Me.txtSaleC.Size = New System.Drawing.Size(121, 33)
        Me.txtSaleC.TabIndex = 3
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(530, 471)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(86, 42)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'frmLab10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 608)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtSaleC)
        Me.Controls.Add(Me.txtSaleB)
        Me.Controls.Add(Me.txtSaleA)
        Me.Controls.Add(Me.txtSaleName)
        Me.Controls.Add(Me.cboIndex)
        Me.Controls.Add(Me.lstData)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblMaxSaleAmount)
        Me.Controls.Add(Me.lblMaxSaleName)
        Me.Controls.Add(Me.lblSumC)
        Me.Controls.Add(Me.lblSumB)
        Me.Controls.Add(Me.lblSumA)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLab10"
        Me.Text = "frmLab10"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents cboIndex As System.Windows.Forms.ComboBox
    Friend WithEvents txtSaleName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblSumA As System.Windows.Forms.Label
    Friend WithEvents lblSumB As System.Windows.Forms.Label
    Friend WithEvents lblSumC As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleName As System.Windows.Forms.Label
    Friend WithEvents lblMaxSaleAmount As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSaleA As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleB As System.Windows.Forms.TextBox
    Friend WithEvents txtSaleC As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
End Class
