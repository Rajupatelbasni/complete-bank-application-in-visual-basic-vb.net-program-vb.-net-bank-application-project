Imports System.Data.OleDb
Imports System.Data
Public Class Form4
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ACE BANK\MS ACCESS\openaccount.accdb"
    Dim connection As New OleDbConnection(connectionString)
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        Form2.Show()
        Hide()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
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
                    Dim query As String = "SELECT name FROM acopen WHERE ID = @ID"
                    Dim cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

                    Dim reader As OleDbDataReader = cmd.ExecuteReader()

                    If reader.Read() Then

                        TextBox2.Text = reader.GetString(0)
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
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else
            Try

                If Integer.TryParse(TextBox1.Text, Nothing) Then
                    connection.Open()


                    Dim query As String = "DELETE FROM acopen WHERE ID = @ID"
                    Dim cmd As New OleDbCommand(query, connection)
                    cmd.Parameters.AddWithValue("@ID", TextBox1.Text)

                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        MessageBox.Show("ACCOUNT REMOVED SUCCESSFULLY")
                        TextBox1.Clear()
                        TextBox2.Clear()

                    Else
                        MessageBox.Show("NO RECORD FOUND")
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