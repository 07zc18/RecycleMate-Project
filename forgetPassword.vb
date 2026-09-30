Imports System.Data.SQLite

Public Class forgetPassword
    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
    Dim conn As New SQLiteConnection(cs)
    Dim cmd As New SQLiteCommand(conn)
    Dim reader As SQLiteDataReader
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtusername.Text = "" Or txtemail.Text = "" Then
            MessageBox.Show("Please enter both username and email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM UserSignUP WHERE username=@username AND email=@email", conn)
                    cmd.Parameters.AddWithValue("@username", txtusername.Text)
                    cmd.Parameters.AddWithValue("@email", txtemail.Text)

                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    If count > 0 Then
                        Dim f26 As New resetPassword()
                        f26.UsernameToReset = txtusername.Text   ' 👈 Pass the username to resetPassword form
                        f26.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Invalid Username or Email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub forgetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class