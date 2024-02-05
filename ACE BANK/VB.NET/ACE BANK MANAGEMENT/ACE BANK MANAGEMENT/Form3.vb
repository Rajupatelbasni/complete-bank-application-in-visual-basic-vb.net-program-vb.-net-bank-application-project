Imports System.Data.OleDb
Imports System.Data
Public Class Form3
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ACE BANK\MS ACCESS\openaccount.accdb"
    Dim connection As New OleDbConnection(connectionString)

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        Form2.Show()
        Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        Form1.Show()
        Hide()

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else
            Try
                connection.Open()
                Dim query As String = "INSERT INTO acopen (name, fathername, aadharnumber, mobilenumber, address, city, balance) VALUES (@Value1, @Value2, @Value3, @Value4, @Value5, @Value6, @Value7)"
                Dim cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Value1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Value2", TextBox2.Text)
                cmd.Parameters.AddWithValue("@Value3", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Value4", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Value5", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Value6", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Value7", TextBox7.Text)
                Dim show As String =
                cmd.ExecuteNonQuery()
                MessageBox.Show("ACCOUNT CREATED SUCCESSFULLY.")
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
                TextBox6.Clear()
                TextBox7.Clear()

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class