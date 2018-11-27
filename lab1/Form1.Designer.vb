<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblbalance = New System.Windows.Forms.Label()
        Me.lbltax = New System.Windows.Forms.Label()
        Me.bntcalculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label1.Location = New System.Drawing.Point(63, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รายได้ทั้งปี"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(63, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(205, 29)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ภาษีที่ต้องชำระ 5%"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(63, 216)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 29)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "เงินเดือนคงเหลือหลังหักภาษี"
        '
        'txtSalary
        '
        Me.txtSalary.BackColor = System.Drawing.Color.OrangeRed
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(325, 71)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(126, 29)
        Me.txtSalary.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(63, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 29)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(325, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 25)
        Me.Label5.TabIndex = 2
        '
        'lblYear
        '
        Me.lblYear.BackColor = System.Drawing.Color.Coral
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(325, 124)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(126, 29)
        Me.lblYear.TabIndex = 0
        '
        'lblbalance
        '
        Me.lblbalance.BackColor = System.Drawing.Color.Tomato
        Me.lblbalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbalance.Location = New System.Drawing.Point(325, 216)
        Me.lblbalance.Name = "lblbalance"
        Me.lblbalance.Size = New System.Drawing.Size(126, 29)
        Me.lblbalance.TabIndex = 0
        '
        'lbltax
        '
        Me.lbltax.BackColor = System.Drawing.Color.Coral
        Me.lbltax.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltax.Location = New System.Drawing.Point(325, 172)
        Me.lbltax.Name = "lbltax"
        Me.lbltax.Size = New System.Drawing.Size(126, 29)
        Me.lbltax.TabIndex = 0
        '
        'bntcalculate
        '
        Me.bntcalculate.BackColor = System.Drawing.Color.OrangeRed
        Me.bntcalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bntcalculate.Location = New System.Drawing.Point(325, 268)
        Me.bntcalculate.Name = "bntcalculate"
        Me.bntcalculate.Size = New System.Drawing.Size(126, 40)
        Me.bntcalculate.TabIndex = 3
        Me.bntcalculate.Text = "คำนวณ"
        Me.bntcalculate.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 377)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(402, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "ชื่อ นางสาว วานุพร ภูขาว 60342110025-4 BIS2/1N"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 506)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bntcalculate)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbltax)
        Me.Controls.Add(Me.lblbalance)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSalary As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblYear As System.Windows.Forms.Label
    Friend WithEvents lblbalance As System.Windows.Forms.Label
    Friend WithEvents lbltax As System.Windows.Forms.Label
    Friend WithEvents bntcalculate As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
