Imports System.Data.SQLite

Public Class SignUp

    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtConfirm.UseSystemPasswordChar = True
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        Dim name As String = txtName.Text.Trim()
        Dim username As String = txtUsername.Text.Trim()
        Dim phonenum As String = txtphone.Text.Trim()
        Dim email As String = txtEmail.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()
        Dim confirm As String = txtConfirm.Text.Trim()
        Dim enteredReferral As String = txtReferral.Text.Trim()

        ' Validate input fields
        If username = "" Or email = "" Or password = "" Or confirm = "" Then
            MessageBox.Show("Please fill in all required fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Password match check
        If password <> confirm Then
            MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Using conn As New SQLiteConnection(cs)
            conn.Open()

            ' Check for duplicate username
            Dim checkUsername As String = "SELECT COUNT(*) FROM UserSignUp WHERE username=@username"
            Using cmdCheck As New SQLiteCommand(checkUsername, conn)
                cmdCheck.Parameters.AddWithValue("@username", username)
                If Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0 Then
                    MessageBox.Show("Username already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End Using

            ' Validate referral code if entered
            Dim referralStatus As Object = DBNull.Value
            Dim referredBy As Object = DBNull.Value

            If enteredReferral <> "" Then

                ' Check if referral code exists
                Dim checkReferral As String = "SELECT COUNT(*) FROM UserSignUp WHERE ReferralCode=@code"
                Using cmdRef As New SQLiteCommand(checkReferral, conn)
                    cmdRef.Parameters.AddWithValue("@code", enteredReferral)

                    If Convert.ToInt32(cmdRef.ExecuteScalar()) = 0 Then
                        MessageBox.Show("Invalid referral code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                End Using

                ' Referral code found → mark as pending
                referredBy = enteredReferral
                referralStatus = "Pending"

            End If

            ' Generate unique referral code for this new user
            Dim myReferralCode As String = GetUniqueReferralCode(conn)

            ' Insert new user record
            Dim insertQuery As String = "
                INSERT INTO UserSignUp 
                (username, name, phone_num, email, password, ReferralCode, ReferredBy, ReferralStatus, rewardedToken)
                VALUES 
                (@u, @n, @p, @e, @pw, @myCode, @refBy, @status, 0)
            "

            Using cmdInsert As New SQLiteCommand(insertQuery, conn)
                cmdInsert.Parameters.AddWithValue("@u", username)
                cmdInsert.Parameters.AddWithValue("@n", name)
                cmdInsert.Parameters.AddWithValue("@p", phonenum)
                cmdInsert.Parameters.AddWithValue("@e", email)
                cmdInsert.Parameters.AddWithValue("@pw", password)
                cmdInsert.Parameters.AddWithValue("@myCode", myReferralCode)
                cmdInsert.Parameters.AddWithValue("@refBy", referredBy)
                cmdInsert.Parameters.AddWithValue("@status", referralStatus)

                cmdInsert.ExecuteNonQuery()
            End Using

            MessageBox.Show(
                "Account created successfully!" & vbCrLf &
                "Your referral code: " & myReferralCode,
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            )

            Me.Close()
        End Using
    End Sub

    ' Generate unique referral code
    Private Function GenerateReferralCode() As String
        'Creates a new globally unique identifier (GUID)
        'Converts the GUID to a string without dashes
        'Takes the first 6 characters of the GUID string
        'Converts the substring to uppercase letters
        Return "ECO-" & Guid.NewGuid().ToString("N").Substring(0, 6).ToUpper()
    End Function

    Private Function GetUniqueReferralCode(conn As SQLiteConnection) As String
        Dim code As String = ""
        Dim exists As Boolean = True

        While exists
            code = GenerateReferralCode()
            Dim sql As String = "SELECT COUNT(*) FROM UserSignUp WHERE ReferralCode=@code"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@code", code)
                exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
            End Using
        End While

        Return code
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim f As New Login
        f.Show()
        Me.Close()
    End Sub

    Private Sub chkShowPassword1_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword1.CheckedChanged
        txtPassword.UseSystemPasswordChar = Not chkShowPassword1.Checked
    End Sub

    Private Sub chkShowPassword2_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword2.CheckedChanged
        txtConfirm.UseSystemPasswordChar = Not chkShowPassword2.Checked
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUsername.Clear()
        txtName.Clear()
        txtphone.Clear()
        txtEmail.Clear()
        txtPassword.Clear()
        txtConfirm.Clear()
        txtReferral.Clear()
    End Sub
End Class
