Imports MySql.Data.MySqlClient

Public Class Form1
    Dim connectionString As String = "server=localhost;user id=root;password=;database=payroll_system"

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn As New MySqlConnection(connectionString)
            Try
                conn.Open()
                Dim query As String = "SELECT * FROM users WHERE Username=@username AND Password=@password"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtUsername.Text)
                cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                Dim reader As MySqlDataReader = cmd.ExecuteReader()
                If reader.HasRows Then
                    Dim payrollForm As New PayrollForm
                    payrollForm.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Invalid username or password!")
                End If
            Catch ex As Exception
                MessageBox.Show("Database connection error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CheckBoxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxShowPassword.CheckedChanged
        If CheckBoxShowPassword.Checked Then
            txtPassword.PasswordChar = ControlChars.NullChar
        Else
            txtPassword.PasswordChar = "*"c
        End If
    End Sub
End Class