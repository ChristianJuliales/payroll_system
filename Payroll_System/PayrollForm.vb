Imports MySql.Data.MySqlClient

Public Class PayrollForm
    Dim connectionString As String = "server=localhost;user id=root;password=;database=payroll_system"
    Private Const SSS_RATE As Double = 0.045
    Private Const PHILHEALTH_RATE As Double = 0.05
    Private Const PAGIBIG_RATE As Double = 0.02
    Private Const TOTAL_DEDUCTION_RATE As Double = 0.115

    Private Sub PayrollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbRole.Items.AddRange(New String() {"Manager", "Senior Developer", "Junior Developer", "HR", "Intern"})
        cmbRole.SelectedIndex = 0
        LoadEmployeeData()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim salary As Double

        If Double.TryParse(txtSalary.Text, salary) Then
            Dim sssDeduction As Double = salary * SSS_RATE
            Dim philHealthDeduction As Double = salary * PHILHEALTH_RATE
            Dim pagIbigDeduction As Double = salary * PAGIBIG_RATE
            Dim totalDeduction As Double = salary * TOTAL_DEDUCTION_RATE
            Dim netPay As Double = salary - totalDeduction

            txtSSS.Text = sssDeduction.ToString("F2")
            txtPhilHealth.Text = philHealthDeduction.ToString("F2")
            txtPagIbig.Text = pagIbigDeduction.ToString("F2")
            txtTotalDeduction.Text = totalDeduction.ToString("F2")
            txtNetPay.Text = netPay.ToString("F2")

            SaveToDatabase(txtEmployeeName.Text, cmbRole.SelectedItem.ToString(), salary, sssDeduction, philHealthDeduction, pagIbigDeduction, totalDeduction, netPay)

            LoadEmployeeData()
        Else
            MessageBox.Show("Please enter a valid salary amount.")
        End If
    End Sub

    Private Sub SaveToDatabase(name As String, role As String, salary As Double, sss As Double, philhealth As Double, pagibig As Double, totalDeduction As Double, netPay As Double)
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO employees (Name, Role, Salary, SSS, PhilHealth, PagIbig, Deductions, NetPay) VALUES (@name, @role, @salary, @sss, @philhealth, @pagibig, @deductions, @netpay)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@name", name)
                cmd.Parameters.AddWithValue("@role", role)
                cmd.Parameters.AddWithValue("@salary", salary)
                cmd.Parameters.AddWithValue("@sss", sss)
                cmd.Parameters.AddWithValue("@philhealth", philhealth)
                cmd.Parameters.AddWithValue("@pagibig", pagibig)
                cmd.Parameters.AddWithValue("@deductions", totalDeduction)
                cmd.Parameters.AddWithValue("@netpay", netPay)

                cmd.ExecuteNonQuery()
                MessageBox.Show("Payroll record saved successfully!")
            Catch ex As Exception
                MessageBox.Show("Database error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub LoadEmployeeData()
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT Name, Role, Salary, SSS, PhilHealth, PagIbig, Deductions, NetPay FROM employees"
                Dim cmd As New MySqlCommand(query, conn)
                Dim adapter As New MySqlDataAdapter(cmd)
                Dim table As New DataTable()
                adapter.Fill(table)

                dgvEmployees.DataSource = table
            Catch ex As Exception
                MessageBox.Show("Failed to load data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim Form1 As New Form1()
        Form1.Show()
        Me.Close()
    End Sub
End Class
