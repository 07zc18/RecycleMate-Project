Imports System.Data.SQLite
Imports System.Drawing.Drawing2D
Public Class profile
    Public Sub CloseIfEmpty()
        ' Close this form only if there are no details
        If String.IsNullOrEmpty(LoggedInUsername) AndAlso
           String.IsNullOrEmpty(LoggedInName) AndAlso
           String.IsNullOrEmpty(LoggedInEmail) AndAlso
           String.IsNullOrEmpty(LoggedInPhone) Then

            Me.Close()
        End If
    End Sub
    Public Property LoggedInUsername As String
    Public Property LoggedInName As String
    Public Property LoggedInEmail As String
    Public Property LoggedInPhone As String
    Public Property LoggedInDate As String

    Private previousForm As Form

    ' Constructor receives previous form
    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = My.Settings.SavedUsername
        Call LoadUserPoints()

        btnUserN.Text = My.Settings.SavedUsername
        ' Auto load user details if previously logged in
        If String.IsNullOrEmpty(LoggedInUsername) AndAlso Not String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            LoadSavedUserDetails()
        End If

        ' Set user details
        If String.IsNullOrEmpty(LoggedInUsername) Then
            lblUsername.Text = "Username: "
        Else
            lblUsername.Text = "Username: " & LoggedInUsername
        End If

        If String.IsNullOrEmpty(LoggedInName) Then
            lblName.Text = "Name: "
        Else
            lblName.Text = "Name: " & LoggedInName
        End If

        If String.IsNullOrEmpty(LoggedInEmail) Then
            lblEmail.Text = "Email: "
        Else
            lblEmail.Text = "Email: " & LoggedInEmail
        End If

        If String.IsNullOrEmpty(LoggedInPhone) Then
            lblPhone.Text = "Phone Number: "
        Else
            lblPhone.Text = "Phone Number: " & LoggedInPhone
        End If

        If String.IsNullOrEmpty(LoggedInDate) Then
            lblDate.Text = "Member Since: "
        Else
            lblDate.Text = "Member Since: " & LoggedInDate
        End If

        ' Fullscreen without border
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        btnProfile.BackColor = Color.SeaGreen
        Me.BackColor = Color.SeaGreen
        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.AutoSize = False
        lblTitle.Width = 800

        ' Circular buttons
        MakeButtonCircle(btnWL)
        MakeButtonCircle(btnTier2)

        For Each btn As Button In {btnHome, btnReward, btnTier, btnActivity, btnWL}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.PaleGreen
        Next

        btnWL.FlatStyle = FlatStyle.Flat
        btnWL.FlatAppearance.BorderSize = 0
        btnWL.BackColor = Color.LightPink

        For Each btn As Button In {btnProfile, btnBack, btnUserN, btnExit}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        For Each btn As Button In {btnIG, btnFB}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        ' Disable certain buttons
        For Each btn As Button In {btnPoints, btnAchievement}
            btn.Enabled = False
        Next

        btnProfilepic.FlatStyle = FlatStyle.Flat
        btnProfilepic.FlatAppearance.BorderSize = 3
        btnProfilepic.FlatAppearance.MouseOverBackColor = btnProfilepic.BackColor
        btnProfilepic.FlatAppearance.MouseDownBackColor = btnProfilepic.BackColor

        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel5.BorderStyle = BorderStyle.FixedSingle

        UpdateAchievementButtons()

        Dim unlocked As Integer = GetUnlockedAchievementsCount(username)
        Dim total As Integer = 4

        btnAchievement.Text = "Achievement Unlocked : " & unlocked & " / " & total

        RecycleStatistics(My.Settings.SavedUsername)

        Dim tier As String = GetCurrentTier(My.Settings.SavedUsername)
        btnTier2.Text = tier  ' Display tier in a label

        CheckAndDisplayTierTitle()
    End Sub

    Private Sub CheckAndDisplayTierTitle()
        Try
            Using conn As New SQLiteConnection("Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;")
                conn.Open()

                ' Get user's total points
                Dim query As String = "SELECT points FROM UserSignUp WHERE username = @username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                    Dim totalPoints As Integer = Convert.ToInt32(cmd.ExecuteScalar())

                    ' Determine current tier and unlock title
                    Dim tier As String = ""
                    Dim title As String = ""

                    If totalPoints >= 50000 Then
                        tier = "Platinum"
                        title = "Title : Planet Protector Supreme!"
                    ElseIf totalPoints >= 10000 Then
                        tier = "Gold"
                        title = "Title : Golden Guardian of the Earth"
                    ElseIf totalPoints >= 1000 Then
                        tier = "Silver"
                        title = "Title : Shining with Sustainability"
                    ElseIf totalPoints >= 10 Then
                        tier = "Bronze"
                        title = "Title : You're Growing Greener!"
                    Else
                        tier = "No Tier"
                    End If

                    lblTierTitle.Text = title

                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking tier: " & ex.Message)
        End Try
    End Sub

    Private Function GetCurrentTier(username As String) As String
        Dim points As Integer = 0
        Try
            Using conn As New SQLiteConnection("Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;")
                conn.Open()
                Dim query As String = "SELECT points FROM UserSignUp WHERE username = @username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        points = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error fetching points: " & ex.Message)
        End Try

        Select Case points
            Case >= 50000
                Return "Platinum"
            Case >= 10000
                Return "Gold"
            Case >= 1000
                Return "Silver"
            Case >= 10
                Return "Bronze"
            Case Else
                Return "No Tier"
        End Select
    End Function

    Private Sub RecycleStatistics(username As String)
        Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim totalItemsQuery As String = "SELECT COUNT(*) FROM RecycleHistory WHERE username = @username"
                Dim totalCounts As Integer
                Using cmd As New SQLiteCommand(totalItemsQuery, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    totalCounts = Convert.ToInt32(cmd.ExecuteScalar())
                End Using

                Dim totalWasteQuery As String = "SELECT IFNULL(SUM(weight),0) FROM RecycleHistory WHERE username = @username"
                Dim totalWaste As Double
                Using cmd As New SQLiteCommand(totalWasteQuery, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    totalWaste = Convert.ToDouble(cmd.ExecuteScalar())
                End Using

                Dim totalCO2Saved As Double = totalWaste * 1.5

                Dim totalEnergySaved As Double = totalWaste * 2.0

                lblCount.Text = totalCounts.ToString("N0") & " times"
                lblWaste.Text = totalWaste.ToString("N2") & " kg"
                lblCO2.Text = totalCO2Saved.ToString("N2") & " kg CO₂"
                lblEnergy.Text = totalEnergySaved.ToString("N2") & " kWh"
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading recycle statistics: " & ex.Message)
        End Try
    End Sub

    Private Function GetUnlockedAchievementsCount(username As String) As Integer
        Dim count As Integer = 0
        Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM achievements WHERE username = @username AND unlocked = 1"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        count = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error getting achievements count: " & ex.Message)
        End Try

        Return count
    End Function
    Private Sub LoadUserPoints()
        Dim username As String = My.Settings.SavedUsername
        Dim totalPoints As Double = 0

        Try
            Using conn As New SQLiteConnection("Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;")
                conn.Open()

                Dim query As String = "SELECT points FROM UserSignUp WHERE username = @username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        totalPoints = Convert.ToDouble(result)
                    End If
                End Using
            End Using

            btnPoints.Text = "Total Points: " & totalPoints.ToString()

        Catch ex As Exception
            MessageBox.Show("Error loading points: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadSavedUserDetails()
        Try
            Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
            Using conn As New SQLite.SQLiteConnection(cs)
                conn.Open()
                Dim query As String = "SELECT * FROM UserSignUp WHERE username=@username"
                Using cmd As New SQLite.SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                    Using reader As SQLite.SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            LoggedInUsername = reader("username").ToString()
                            LoggedInName = reader("name").ToString()
                            LoggedInEmail = reader("email").ToString()
                            LoggedInPhone = reader("phone_num").ToString()
                            LoggedInDate = reader("date").ToString()
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading saved user details: " & ex.Message)
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If previousForm IsNot Nothing Then
            previousForm.Show()
        End If
        Close()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim form1 As New Form1(Me)
        form1.LoggedInUsername = LoggedInUsername
        form1.LoggedInName = LoggedInName
        form1.LoggedInEmail = LoggedInEmail
        form1.LoggedInPhone = LoggedInPhone
        form1.LoggedInDate = LoggedInDate
        form1.Show()
        Hide()
    End Sub

    Private Sub btnReward_Click(sender As Object, e As EventArgs) Handles btnReward.Click
        Dim form2 As New rewards(Me)
        form2.Show()
        Hide()
    End Sub

    Private Sub btnTier_Click(sender As Object, e As EventArgs) Handles btnTier.Click
        Dim form3 As New tier(Me)
        form3.Show()
        Hide()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        Dim f As New recycleHistory(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Function GetUserPoints(username As String) As Integer
        Dim points As Integer = 0
        Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Dim query As String = "SELECT points FROM UserSignUp WHERE username = @username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        points = Convert.ToInt32(result)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error reading points: " & ex.Message)
        End Try

        Return points
    End Function
    Private Sub UpdateAchievementButtons()
        Dim username As String = My.Settings.SavedUsername
        Dim points As Integer = GetUserPoints(username)

        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False

        ' Enable depending on points
        If points >= 1000 Then btn1.Enabled = True
        If points >= 5000 Then btn2.Enabled = True
        If points >= 10000 Then btn3.Enabled = True
        If points >= 50000 Then btn4.Enabled = True
    End Sub

    Private Sub MakeButtonCircle(btn As Button)
        Dim path As New GraphicsPath()
        path.AddEllipse(0, 0, btn.Width, btn.Height)
        btn.Region = New Region(path)
    End Sub

    Private Sub btnTier2_Click(sender As Object, e As EventArgs) Handles btnTier2.Click
        Dim form3 As New tier(Me)
        form3.Show()
        Me.Hide()
    End Sub

    ' Achievement buttons
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        MessageBox.Show("You've taken your first step toward a greener world!", "🌱 Eco Starter 🌱")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        MessageBox.Show("Your effort keeps the Earth smiling.", "🌿 Green Guardian 🌿")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        MessageBox.Show("A true hero for our planet!", "🌞 Sustainability Hero 🌞")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        MessageBox.Show("You've gone above and beyond for sustainability.", "🌎 Planet Protector 🌎")
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim editForm As New EditProfile()
        editForm.CurrentUsername = My.Settings.SavedUsername
        editForm.ShowDialog()
    End Sub

    Private Sub btnReferral_Click(sender As Object, e As EventArgs) Handles btnReferral.Click
        Dim f17 As New referral
        f17.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        If String.IsNullOrWhiteSpace(My.Settings.SavedUsername) Then
            MessageBox.Show("Please log in to access Settings.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Dim loginForm As New Login
            loginForm.Show()

            Return
        End If

        Dim settingsForm As New settings
        settingsForm.Show()
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim f23 As New SignUp
        f23.Show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim f24 As New Login()
        f24.Owner = Me ' set this detailed Form5 as owner for login
        f24.Show()
    End Sub

    Private Sub btnWL_Click(sender As Object, e As EventArgs) Handles btnWL.Click
        Dim f As New wishList
        f.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim f As New dashBoard
        f.Show()
    End Sub
End Class