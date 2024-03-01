Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim command As MySqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_mysql.Click
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password='';database=test"
        Try
            conn.Open()
            MessageBox.Show("Ligação à DB test com sucesso", "Teste de acesso à DB-test")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cmd_mysqldbtest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password='';database=pessoal "
        Try
            conn.Open()
            MessageBox.Show("Ligação à DB pessoal com sucesso", "Teste de acesso à DB-pessoal")
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cmd_dataTest_Click(sender As Object, e As EventArgs) Handles cmd_dataTest.Click
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password='';database=pessoal "
        Try
            conn.Open()
            MessageBox.Show("Ligação à DB pessoal com sucesso", "Teste de acesso à DB-pessoal - tabela produtos")
            Dim table As New DataTable
            Dim adap As New MySqlDataAdapter("Select * from produtos", conn)
            adap.Fill(table)
            DataGridView1.DataSource = table

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub

    Private Sub cmd_dataPessoal_Click(sender As Object, e As EventArgs) Handles cmd_dataPessoal.Click
        conn = New MySqlConnection
        conn.ConnectionString = "Server=localhost;userid=root;password='';database=pessoal "
        Try
            MessageBox.Show("Ligação à DB pessoal com sucesso", "Teste de acesso à DB-pessoal - tabela contatos")
            Dim table As New DataTable
            Dim adap As New MySqlDataAdapter("Select * from contatos", conn)
            adap.Fill(table)
            DataGridView1.DataSource = table

            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
    End Sub
End Class
