<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab8
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
        Me.lstSubject = New System.Windows.Forms.ListBox()
        Me.lstScore = New System.Windows.Forms.ListBox()
        Me.lstCredit = New System.Windows.Forms.ListBox()
        Me.lstGrade = New System.Windows.Forms.ListBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.txtScore = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblOldTotalScore = New System.Windows.Forms.Label()
        Me.lblOldTotalCredit = New System.Windows.Forms.Label()
        Me.lblOldGPA = New System.Windows.Forms.Label()
        Me.lblNewGPA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstSubject
        '
        Me.lstSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSubject.FormattingEnabled = True
        Me.lstSubject.ItemHeight = 20
        Me.lstSubject.Location = New System.Drawing.Point(77, 142)
        Me.lstSubject.Name = "lstSubject"
        Me.lstSubject.Size = New System.Drawing.Size(117, 164)
        Me.lstSubject.TabIndex = 0
        '
        'lstScore
        '
        Me.lstScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScore.FormattingEnabled = True
        Me.lstScore.ItemHeight = 20
        Me.lstScore.Location = New System.Drawing.Point(200, 142)
        Me.lstScore.Name = "lstScore"
        Me.lstScore.Size = New System.Drawing.Size(117, 164)
        Me.lstScore.TabIndex = 0
        '
        'lstCredit
        '
        Me.lstCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCredit.FormattingEnabled = True
        Me.lstCredit.ItemHeight = 20
        Me.lstCredit.Location = New System.Drawing.Point(323, 142)
        Me.lstCredit.Name = "lstCredit"
        Me.lstCredit.Size = New System.Drawing.Size(117, 164)
        Me.lstCredit.TabIndex = 0
        '
        'lstGrade
        '
        Me.lstGrade.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstGrade.FormattingEnabled = True
        Me.lstGrade.ItemHeight = 20
        Me.lstGrade.Location = New System.Drawing.Point(446, 142)
        Me.lstGrade.Name = "lstGrade"
        Me.lstGrade.Size = New System.Drawing.Size(117, 164)
        Me.lstGrade.TabIndex = 0
        '
        'txtSubject
        '
        Me.txtSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubject.Location = New System.Drawing.Point(77, 312)
        Me.txtSubject.Multiline = True
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(117, 35)
        Me.txtSubject.TabIndex = 1
        '
        'txtScore
        '
        Me.txtScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScore.Location = New System.Drawing.Point(200, 312)
        Me.txtScore.Multiline = True
        Me.txtScore.Name = "txtScore"
        Me.txtScore.Size = New System.Drawing.Size(117, 35)
        Me.txtScore.TabIndex = 1
        '
        'txtCredit
        '
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(323, 312)
        Me.txtCredit.Multiline = True
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(117, 35)
        Me.txtCredit.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(446, 312)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 35)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(532, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(80, 35)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblOldTotalScore
        '
        Me.lblOldTotalScore.BackColor = System.Drawing.Color.MistyRose
        Me.lblOldTotalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldTotalScore.Location = New System.Drawing.Point(200, 110)
        Me.lblOldTotalScore.Name = "lblOldTotalScore"
        Me.lblOldTotalScore.Size = New System.Drawing.Size(117, 28)
        Me.lblOldTotalScore.TabIndex = 3
        Me.lblOldTotalScore.Text = "คะแนนสอบ"
        '
        'lblOldTotalCredit
        '
        Me.lblOldTotalCredit.BackColor = System.Drawing.Color.MistyRose
        Me.lblOldTotalCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldTotalCredit.Location = New System.Drawing.Point(381, 363)
        Me.lblOldTotalCredit.Name = "lblOldTotalCredit"
        Me.lblOldTotalCredit.Size = New System.Drawing.Size(65, 28)
        Me.lblOldTotalCredit.TabIndex = 3
        Me.lblOldTotalCredit.Text = "50"
        '
        'lblOldGPA
        '
        Me.lblOldGPA.BackColor = System.Drawing.Color.MistyRose
        Me.lblOldGPA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOldGPA.Location = New System.Drawing.Point(560, 363)
        Me.lblOldGPA.Name = "lblOldGPA"
        Me.lblOldGPA.Size = New System.Drawing.Size(64, 28)
        Me.lblOldGPA.TabIndex = 3
        Me.lblOldGPA.Text = "3.00"
        '
        'lblNewGPA
        '
        Me.lblNewGPA.BackColor = System.Drawing.Color.MistyRose
        Me.lblNewGPA.Location = New System.Drawing.Point(382, 419)
        Me.lblNewGPA.Name = "lblNewGPA"
        Me.lblNewGPA.Size = New System.Drawing.Size(97, 28)
        Me.lblNewGPA.TabIndex = 3
        Me.lblNewGPA.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.MistyRose
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "วิชา"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.MistyRose
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(448, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 28)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "เกรด"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.MistyRose
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "หน่วยกิต"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.MistyRose
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(219, 363)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "150"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(40, 363)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(173, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "คะแนนสะสมก่อนหน้า"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(279, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "หน่วยกิตสะสม"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(464, 363)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "เกรดเฉลี่ยสะสม"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 419)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(193, 23)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "เกรดเฉลี่ยสะสมภาคปัจจุบัน"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(186, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(296, 28)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "โปรแกรมคำนวณเกรดค่าเฉลี่ยสะสม"
        '
        'frmLab8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 541)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblNewGPA)
        Me.Controls.Add(Me.lblOldGPA)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblOldTotalCredit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOldTotalScore)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.txtScore)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lstGrade)
        Me.Controls.Add(Me.lstCredit)
        Me.Controls.Add(Me.lstScore)
        Me.Controls.Add(Me.lstSubject)
        Me.Name = "frmLab8"
        Me.Text = "frmLab8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstSubject As System.Windows.Forms.ListBox
    Friend WithEvents lstScore As System.Windows.Forms.ListBox
    Friend WithEvents lstCredit As System.Windows.Forms.ListBox
    Friend WithEvents lstGrade As System.Windows.Forms.ListBox
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtScore As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblOldTotalScore As System.Windows.Forms.Label
    Friend WithEvents lblOldTotalCredit As System.Windows.Forms.Label
    Friend WithEvents lblOldGPA As System.Windows.Forms.Label
    Friend WithEvents lblNewGPA As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
