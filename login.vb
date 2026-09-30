Imports System.Data.SQLite

Public Class Login
    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    ' Logged-in user info (can be accessed from other forms if declared public/shared)
    Public Shared LoggedInUser As String
    Public Shared LoggedInName As String
    Public Shared LoggedInEmail As String
    Public Shared LoggedInPhone As String
    Public Shared LoggedInDate As String

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The textBox hides the actual characters typed
        txtPassword.UseSystemPasswordChar = True

        ' Auto-login if RememberMe is checked
        If My.Settings.IsLoggedIn AndAlso My.Settings.RememberMe Then
            AutoLogin()
        End If
    End Sub

    ' Login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If String.IsNullOrWhiteSpace(txtUsername.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsername.Focus()
            Return
        End If

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT * FROM UserSignUp WHERE username=@username COLLATE NOCASE AND [password]=@password"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            ' Save user info
                            LoggedInUser = reader("username").ToString()
                            LoggedInName = reader("name").ToString()
                            LoggedInEmail = reader("email").ToString()
                            LoggedInPhone = reader("phone_num").ToString()
                            LoggedInDate = reader("date").ToString()

                            ' Save login state
                            My.Settings.SavedUsername = LoggedInUser
                            My.Settings.SavedName = LoggedInName
                            My.Settings.SavedEmail = LoggedInEmail
                            My.Settings.SavedPhone = LoggedInPhone
                            My.Settings.SavedDate = LoggedInDate
                            My.Settings.IsLoggedIn = True
                            My.Settings.RememberMe = chkRememberMe.Checked
                            My.Settings.Save()

                            ' Open home form
                            Dim homeForm As New Form1()
                            homeForm.LoggedInUsername = LoggedInUser
                            homeForm.LoggedInName = LoggedInName
                            homeForm.LoggedInEmail = LoggedInEmail
                            homeForm.LoggedInPhone = LoggedInPhone
                            homeForm.LoggedInDate = LoggedInDate
                            homeForm.Show()

                            Me.Hide()
                        Else
                            MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            txtPassword.Clear()
                            txtPassword.Focus()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Auto-login using saved settings
    Private Sub AutoLogin()
        If String.IsNullOrWhiteSpace(My.Settings.SavedUsername) Then Return

        LoggedInUser = My.Settings.SavedUsername
        LoggedInName = My.Settings.SavedName
        LoggedInEmail = My.Settings.SavedEmail
        LoggedInPhone = My.Settings.SavedPhone
        LoggedInDate = My.Settings.SavedDate

        Dim homeForm As New Form1()
        homeForm.LoggedInUsername = LoggedInUser
        homeForm.LoggedInName = LoggedInName
        homeForm.LoggedInEmail = LoggedInEmail
        homeForm.LoggedInPhone = LoggedInPhone
        homeForm.LoggedInDate = LoggedInDate
        homeForm.Show()

        Me.Hide()
    End Sub

    ' Show/hide password
    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtPassword.Clear()
        txtUsername.Focus()
    End Sub

    Private Sub btnForgetPass_Click(sender As Object, e As EventArgs) Handles btnForgetPass.Click
        Dim f As New forgetPassword()
        f.Show()
    End Sub

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Clear login state if RememberMe is not checked
        If Not My.Settings.RememberMe Then
            My.Settings.IsLoggedIn = False
            My.Settings.SavedUsername = ""
            My.Settings.Save()
        End If
    End Sub
End Class
