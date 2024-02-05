Imports System.Data.OleDb
Imports System.Data
Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim uname As String
        Dim ppass As String
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("PLEASE FILL THE INFORMATION")
        Else
            uname = TextBox1.Text
            ppass = TextBox2.Text

            Dim run As String = "select password from Table1 where name = '" & uname & "' ;"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\ACE BANK\MS ACCESS\USER ACCOUNT.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(run, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString

            Catch ex As Exception
                MsgBox("USER ACCOUNT NOT EXISTED")
            End Try
            If (ppass = pass) Then
                MsgBox("LOGIN SUCCESS")
                Form2.Show()
                TextBox1.Clear()
                TextBox2.Clear()
                If Form2.Visible Then
                    Me.Hide()

                End If
            Else
                MsgBox("LOGIN FILED")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If

    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form7.Show()
        Hide()

    End Sub
End Class
