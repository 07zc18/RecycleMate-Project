Imports System.Data.SQLite

Public Class EditProfile
    ' Logged-in username must be passed from login or home form
    Public Property CurrentUsername As String

    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Private Sub EditProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsername.ReadOnly = False

        If String.IsNullOrEmpty(CurrentUsername) Then
            MessageBox.Show("Error: No logged-in user found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
            Return
        End If

        LoadUserData()
    End Sub

    Private Sub LoadUserData()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Dim query As String = "SELECT username, email, phone_num, name FROM UserSignUp WHERE username=@username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", CurrentUsername)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtUsername.Text = reader("username").ToString()
                            txtEmail.Text = reader("email").ToString()
                            txtPhone.Text = reader("phone_num").ToString()
                            txtName.Text = reader("name").ToString()
                        Else
                            MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            Me.Close()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading user data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse
           String.IsNullOrWhiteSpace(txtEmail.Text) OrElse
           String.IsNullOrWhiteSpace(txtPhone.Text) OrElse
           String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Not txtEmail.Text.Contains("@") Then
            MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                If txtUsername.Text <> CurrentUsername Then
                    Using checkCmd As New SQLiteCommand("SELECT COUNT(*) FROM UserSignUp WHERE username=@username", conn)
                        checkCmd.Parameters.AddWithValue("@username", txtUsername.Text)
                        Dim exists = Convert.ToInt32(checkCmd.ExecuteScalar())
                        If exists > 0 Then
                            MessageBox.Show("This username is already taken. Please choose another.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            Return
                        End If
                    End Using
                End If

                Using cmd As New SQLiteCommand(
                    "UPDATE UserSignUp SET username=@newUsername, email=@email, phone_num=@phone_num, name=@name WHERE username=@oldUsername", conn)
                    cmd.Parameters.AddWithValue("@newUsername", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text)
                    cmd.Parameters.AddWithValue("@phone_num", txtPhone.Text)
                    cmd.Parameters.AddWithValue("@name", txtName.Text)
                    cmd.Parameters.AddWithValue("@oldUsername", CurrentUsername)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand("UPDATE RecycleHistory SET username=@newUsername WHERE username=@oldUsername", conn)
                    cmd.Parameters.AddWithValue("@newUsername", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@oldUsername", CurrentUsername)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd As New SQLiteCommand("UPDATE Leaderboard SET Username=@newUsername WHERE Username=@oldUsername", conn)
                    cmd.Parameters.AddWithValue("@newUsername", txtUsername.Text)
                    cmd.Parameters.AddWithValue("@oldUsername", CurrentUsername)
                    cmd.ExecuteNonQuery()
                End Using

                My.Settings.IsLoggedIn = False
                My.Settings.SavedUsername = ""
                My.Settings.SavedName = ""
                My.Settings.SavedEmail = ""
                My.Settings.SavedPhone = ""
                My.Settings.SavedDate = ""
                My.Settings.RememberMe = False
                My.Settings.Save()

                MessageBox.Show("Profile updated successfully! All forms will reset. Please log in again.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Close all open forms
                For Each frm As Form In Application.OpenForms.Cast(Of Form).ToArray()
                    frm.Hide()
                Next

                Dim loginForm As New login()
                loginForm.txtUsername.Clear()
                loginForm.txtPassword.Clear()
                loginForm.chkRememberMe.Checked = False
                loginForm.Show()

            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
