Imports System.Data.SQLite

Public Class changePassword
    Private Sub changePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim oldPass = txtOldPassword.Text
        Dim newPass = txtNewPassword.Text
        Dim confirmPass = txtConfirmPassword.Text

        If String.IsNullOrWhiteSpace(oldPass) OrElse String.IsNullOrWhiteSpace(newPass) OrElse String.IsNullOrWhiteSpace(confirmPass) Then
            MessageBox.Show("Please fill in all password fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If newPass <> confirmPass Then
            MessageBox.Show("New password and confirmation do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ChangePassword(My.Settings.SavedUsername, oldPass, newPass)
    End Sub

    Public Sub ChangePassword(username As String, oldPassword As String, newPassword As String)
        Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

        Using conn As New SQLiteConnection(cs)
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM UserSignUp WHERE username=@username AND password=@oldPassword"
            Using cmd As New SQLiteCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@username", username)
                cmd.Parameters.AddWithValue("@oldPassword", oldPassword)

                Dim result = Convert.ToInt32(cmd.ExecuteScalar())
                If result = 0 Then
                    MessageBox.Show("Old password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return
                End If
            End Using

            Dim updateQuery As String = "UPDATE UserSignUp SET password=@newPassword WHERE username=@username"
            Using cmd As New SQLiteCommand(updateQuery, conn)
                cmd.Parameters.AddWithValue("@newPassword", newPassword)
                cmd.Parameters.AddWithValue("@username", username)

                Dim rowsAffected = cmd.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Password changed successfully! Please log in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    My.Settings.SavedUsername = ""
                    My.Settings.Save()

                    Me.Close()

                    For Each f As Form In Application.OpenForms.OfType(Of Form).ToList()
                        If Not TypeOf f Is login Then
                            f.Hide()
                        End If
                    Next

                    Dim f1 As New profile(Me)
                    f1.Show()
                    Dim login As New login()
                    login.Show()
                Else
                    MessageBox.Show("Failed to change password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        End Using
    End Sub
End Class
