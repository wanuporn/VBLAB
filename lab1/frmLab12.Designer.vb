<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLab12
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
        Me.DgvEmp = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtEmpld = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtEmpName = New System.Windows.Forms.TextBox()
        Me.txtEmpLname = New System.Windows.Forms.TextBox()
        Me.cboDepart = New System.Windows.Forms.ComboBox()
        Me.radMale = New System.Windows.Forms.RadioButton()
        Me.radFamale = New System.Windows.Forms.RadioButton()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.bnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.panEmp = New System.Windows.Forms.Panel()
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvEmp
        '
        Me.DgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmp.Location = New System.Drawing.Point(30, 49)
        Me.DgvEmp.Name = "DgvEmp"
        Me.DgvEmp.RowTemplate.Height = 24
        Me.DgvEmp.Size = New System.Drawing.Size(876, 286)
        Me.DgvEmp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(293, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "โปรแกรมจัดการข้อมูลพนักงาน"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "รหัสพนักงาน"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 31)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "ที่อยู่"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 31)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "เงินเดือน"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(288, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 31)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "ชื่อพนักงาน"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(296, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 31)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "แผนก"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(592, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 31)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "นามสกุล"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(592, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 31)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "เพศ"
        '
        'txtEmpld
        '
        Me.txtEmpld.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpld.Location = New System.Drawing.Point(114, 13)
        Me.txtEmpld.Multiline = True
        Me.txtEmpld.Name = "txtEmpld"
        Me.txtEmpld.Size = New System.Drawing.Size(158, 31)
        Me.txtEmpld.TabIndex = 2
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(114, 56)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(472, 31)
        Me.txtAddress.TabIndex = 2
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(114, 102)
        Me.txtSalary.Multiline = True
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(158, 31)
        Me.txtSalary.TabIndex = 2
        '
        'txtEmpName
        '
        Me.txtEmpName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpName.Location = New System.Drawing.Point(424, 13)
        Me.txtEmpName.Multiline = True
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(162, 31)
        Me.txtEmpName.TabIndex = 2
        '
        'txtEmpLname
        '
        Me.txtEmpLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpLname.Location = New System.Drawing.Point(687, 16)
        Me.txtEmpLname.Multiline = True
        Me.txtEmpLname.Name = "txtEmpLname"
        Me.txtEmpLname.Size = New System.Drawing.Size(169, 31)
        Me.txtEmpLname.TabIndex = 2
        '
        'cboDepart
        '
        Me.cboDepart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepart.FormattingEnabled = True
        Me.cboDepart.Location = New System.Drawing.Point(424, 101)
        Me.cboDepart.Name = "cboDepart"
        Me.cboDepart.Size = New System.Drawing.Size(162, 28)
        Me.cboDepart.TabIndex = 3
        '
        'radMale
        '
        Me.radMale.AutoSize = True
        Me.radMale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMale.Location = New System.Drawing.Point(687, 59)
        Me.radMale.Name = "radMale"
        Me.radMale.Size = New System.Drawing.Size(57, 24)
        Me.radMale.TabIndex = 4
        Me.radMale.TabStop = True
        Me.radMale.Text = "ชาย"
        Me.radMale.UseVisualStyleBackColor = True
        '
        'radFamale
        '
        Me.radFamale.AutoSize = True
        Me.radFamale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFamale.Location = New System.Drawing.Point(777, 57)
        Me.radFamale.Name = "radFamale"
        Me.radFamale.Size = New System.Drawing.Size(61, 24)
        Me.radFamale.TabIndex = 5
        Me.radFamale.TabStop = True
        Me.radFamale.Text = "หญิง"
        Me.radFamale.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.BackColor = System.Drawing.Color.DarkOrange
        Me.btninsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.Location = New System.Drawing.Point(222, 508)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 37)
        Me.btninsert.TabIndex = 6
        Me.btninsert.Text = "เพิ่ม"
        Me.btninsert.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(332, 508)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 37)
        Me.btnEdit.TabIndex = 6
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.DarkOrange
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(433, 508)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 37)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "ลบ"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'bnClose
        '
        Me.bnClose.BackColor = System.Drawing.Color.DarkOrange
        Me.bnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnClose.Location = New System.Drawing.Point(547, 508)
        Me.bnClose.Name = "bnClose"
        Me.bnClose.Size = New System.Drawing.Size(75, 37)
        Me.bnClose.TabIndex = 6
        Me.bnClose.Text = "ออก"
        Me.bnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSave.Location = New System.Drawing.Point(687, 101)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(57, 29)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(759, 102)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(59, 28)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'panEmp
        '
        Me.panEmp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.panEmp.Controls.Add(Me.txtEmpld)
        Me.panEmp.Controls.Add(Me.btnCancel)
        Me.panEmp.Controls.Add(Me.Label2)
        Me.panEmp.Controls.Add(Me.btnSave)
        Me.panEmp.Controls.Add(Me.Label5)
        Me.panEmp.Controls.Add(Me.Label7)
        Me.panEmp.Controls.Add(Me.Label8)
        Me.panEmp.Controls.Add(Me.Label6)
        Me.panEmp.Controls.Add(Me.Label3)
        Me.panEmp.Controls.Add(Me.radFamale)
        Me.panEmp.Controls.Add(Me.Label4)
        Me.panEmp.Controls.Add(Me.radMale)
        Me.panEmp.Controls.Add(Me.txtAddress)
        Me.panEmp.Controls.Add(Me.cboDepart)
        Me.panEmp.Controls.Add(Me.txtEmpName)
        Me.panEmp.Controls.Add(Me.txtSalary)
        Me.panEmp.Controls.Add(Me.txtEmpLname)
        Me.panEmp.Location = New System.Drawing.Point(30, 341)
        Me.panEmp.Name = "panEmp"
        Me.panEmp.Size = New System.Drawing.Size(876, 143)
        Me.panEmp.TabIndex = 7
        '
        'frmLab12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 581)
        Me.Controls.Add(Me.panEmp)
        Me.Controls.Add(Me.bnClose)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvEmp)
        Me.Name = "frmLab12"
        Me.Text = "frmLab12"
        CType(Me.DgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panEmp.ResumeLayout(False)
        Me.panEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DgvEmp As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmpld As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtEmpName As TextBox
    Friend WithEvents txtEmpLname As TextBox
    Friend WithEvents cboDepart As ComboBox
    Friend WithEvents radMale As RadioButton
    Friend WithEvents radFamale As RadioButton
    Friend WithEvents btninsert As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents bnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents panEmp As Panel
End Class
