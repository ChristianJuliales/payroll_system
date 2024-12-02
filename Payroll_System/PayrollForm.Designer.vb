<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PayrollForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.txtSalary = New System.Windows.Forms.TextBox()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.txtPhilHealth = New System.Windows.Forms.TextBox()
        Me.txtPagIbig = New System.Windows.Forms.TextBox()
        Me.txtTotalDeduction = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.dgvEmployees = New System.Windows.Forms.DataGridView()
        Me.btnLogout = New System.Windows.Forms.Button()
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(964, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAYROLL SYSTEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeName.Location = New System.Drawing.Point(109, 103)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(100, 26)
        Me.txtEmployeeName.TabIndex = 1
        '
        'txtSalary
        '
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(109, 230)
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.Size = New System.Drawing.Size(100, 26)
        Me.txtSalary.TabIndex = 2
        '
        'txtSSS
        '
        Me.txtSSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSS.Location = New System.Drawing.Point(419, 103)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.ReadOnly = True
        Me.txtSSS.Size = New System.Drawing.Size(100, 26)
        Me.txtSSS.TabIndex = 3
        '
        'txtPhilHealth
        '
        Me.txtPhilHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhilHealth.Location = New System.Drawing.Point(419, 164)
        Me.txtPhilHealth.Name = "txtPhilHealth"
        Me.txtPhilHealth.ReadOnly = True
        Me.txtPhilHealth.Size = New System.Drawing.Size(100, 26)
        Me.txtPhilHealth.TabIndex = 4
        '
        'txtPagIbig
        '
        Me.txtPagIbig.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagIbig.Location = New System.Drawing.Point(419, 230)
        Me.txtPagIbig.Name = "txtPagIbig"
        Me.txtPagIbig.ReadOnly = True
        Me.txtPagIbig.Size = New System.Drawing.Size(100, 26)
        Me.txtPagIbig.TabIndex = 5
        '
        'txtTotalDeduction
        '
        Me.txtTotalDeduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDeduction.Location = New System.Drawing.Point(738, 103)
        Me.txtTotalDeduction.Name = "txtTotalDeduction"
        Me.txtTotalDeduction.ReadOnly = True
        Me.txtTotalDeduction.Size = New System.Drawing.Size(100, 26)
        Me.txtTotalDeduction.TabIndex = 6
        '
        'txtNetPay
        '
        Me.txtNetPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNetPay.Location = New System.Drawing.Point(738, 164)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.ReadOnly = True
        Me.txtNetPay.Size = New System.Drawing.Size(100, 26)
        Me.txtNetPay.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(106, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(106, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Salary"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(416, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "SSS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(416, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "PhilHealth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(416, 207)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "PAG-IBIG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(734, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Total Deduction"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(734, 141)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Net Pay"
        '
        'cmbRole
        '
        Me.cmbRole.FormattingEnabled = True
        Me.cmbRole.Location = New System.Drawing.Point(109, 169)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(121, 21)
        Me.cmbRole.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(106, 146)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Role"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(409, 301)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(110, 44)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'dgvEmployees
        '
        Me.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployees.Location = New System.Drawing.Point(55, 380)
        Me.dgvEmployees.Name = "dgvEmployees"
        Me.dgvEmployees.Size = New System.Drawing.Size(856, 267)
        Me.dgvEmployees.TabIndex = 18
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(880, 39)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(84, 30)
        Me.btnLogout.TabIndex = 19
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'PayrollForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GrayText
        Me.ClientSize = New System.Drawing.Size(964, 724)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.dgvEmployees)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbRole)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtTotalDeduction)
        Me.Controls.Add(Me.txtPagIbig)
        Me.Controls.Add(Me.txtPhilHealth)
        Me.Controls.Add(Me.txtSSS)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtEmployeeName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "PayrollForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PayrollForm"
        CType(Me.dgvEmployees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtSalary As TextBox
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents txtPagIbig As TextBox
    Friend WithEvents txtTotalDeduction As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents dgvEmployees As DataGridView
    Friend WithEvents btnLogout As Button
End Class
