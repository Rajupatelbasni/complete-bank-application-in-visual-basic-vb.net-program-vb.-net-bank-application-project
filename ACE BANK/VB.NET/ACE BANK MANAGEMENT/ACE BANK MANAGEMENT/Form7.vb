Imports System.Data.OleDb
Imports System.Data
Public Class Form7
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ACE BANK\MS ACCESS\USER ACCOUNT.accdb"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
     
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else

            Try
                connection.Open()
                Dim query As String = "INSERT INTO Table1 VALUES (@Value1, @Value2)"
                Dim cmd As New OleDbCommand(query, connection)
                cmd.Parameters.AddWithValue("@Value1", TextBox1.Text)
                cmd.Parameters.AddWithValue("@Value2", TextBox2.Text)

                Dim show As String = cmd.ExecuteNonQuery()
                MessageBox.Show("USERNAME AND PASSWORD CREATED SUCCESSFULLY")
                TextBox1.Clear()
                TextBox2.Clear()
                Form1.Show()
                Hide()


            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class