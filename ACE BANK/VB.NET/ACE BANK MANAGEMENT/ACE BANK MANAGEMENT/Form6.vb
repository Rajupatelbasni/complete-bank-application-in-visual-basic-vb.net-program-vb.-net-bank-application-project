Imports System.Data.OleDb
Imports System.Data
Public Class Form6
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ACE BANK\MS ACCESS\openaccount.accdb"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Form2.Show()
        Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        Form1.Show()
        Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else
            Try

                If Integer.TryParse(TextBox1.Text, Nothing) Then
                    connection.Open()
                    Dim query As String = "SELECT balance FROM acopen WHERE ID = @ID"
                    Dim cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        TextBox3.Text = reader.GetValue(0)
                    Else
                        MessageBox.Show("ACCOUNT NOT FOUND")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else
            Try

                If Integer.TryParse(TextBox1.Text, Nothing) Then
                    connection.Open()


                    Dim query As String = "UPDATE acopen SET balance = @Name WHERE ID = @ID"
                    Dim cmd As New OleDbCommand(query, connection)

                    Dim current As Integer = TextBox3.Text
                    Dim updt As Integer = TextBox2.Text
                    Dim nw As Integer = current + updt

                    cmd.Parameters.AddWithValue("@Name", nw)
                    cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("DEPOSIT SUCCESS")
                        MessageBox.Show("CURRENT BALANCE ₹ " & nw)
                        TextBox1.Clear()
                        TextBox2.Clear()
                        TextBox3.Clear()

                    Else
                        MessageBox.Show("ACCOUNT NOT FOUND")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub
End Class