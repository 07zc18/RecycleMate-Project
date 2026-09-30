Imports System.Data.SQLite
Imports System.IO

Public Class resetPassword
    ' Username to reset (should be passed from forgetPassword form)
    Public Property UsernameToReset As String
    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Private Sub resetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewPassword.UseSystemPasswordChar = True
        txtConfirmPassword.UseSystemPasswordChar = True
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        If txtNewPassword.Text = "" Or txtConfirmPassword.Text = "" Then
            MessageBox.Show("Please enter both password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Using cmd As New SQLiteCommand("UPDATE UserSignUp SET password=@password WHERE username=@username", conn)
                    cmd.Parameters.AddWithValue("@password", txtNewPassword.Text)
                    cmd.Parameters.AddWithValue("@username", UsernameToReset)


                    Dim rows As Integer = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("Password successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                    Else
                        MessageBox.Show("Error: Password update unsuccesful. Please Try again..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub chkShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword1.CheckedChanged
        txtNewPassword.UseSystemPasswordChar = Not chkShowPassword1.Checked
    End Sub
    Private Sub chkShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        txtConfirmPassword.UseSystemPasswordChar = Not chkShowPassword2.Checked
    End Sub
End Class
