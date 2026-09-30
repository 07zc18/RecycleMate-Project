Imports System.Data.SQLite

Public Class tier
    Private previousForm As Form 'to store the previous form
    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub

    Private achievements As New Dictionary(Of Integer, (Points As Integer, Name As String)) From {
    {1, (1000, "Eco Starter")},
    {2, (5000, "Green Guardian")},
    {3, (10000, "Sustainability Hero")},
    {4, (50000, "Planet Protector")}
}
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        btnTier.BackColor = Color.SeaGreen
        Me.BackColor = Color.SeaGreen

        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.AutoSize = False
        lblTitle.Width = 800

        For Each btn As Button In {btnHome, btnReward, btnActivity, btnProfile}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.PaleGreen
        Next

        For Each btn As Button In {btnTier, btnBack, btnExit}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        For Each btn As Button In {btnCurrentTier}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        For Each btn As Button In {btn1, btn2, btn3, btn4}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 2
            btn.FlatAppearance.BorderColor = Color.Blue
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor

        Next

        Panel1.BorderStyle = BorderStyle.Fixed3D

        For Each btn As Button In {btnBronze, btnSilver, btnGold, btnPlatinum}
            btn.Text = ""
            btn.FlatStyle = FlatStyle.Flat
            btn.UseVisualStyleBackColor = False
        Next

        For Each btn As Button In {btnIG, btnFB}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        ' Get total points from SQL
        Dim points As Integer = GetTotalPoints(My.Settings.SavedUsername)
        Dim nextThreshold As Integer = GetNextAchievementPoints(points)

        ' Update progress bar
        PBpoints.Minimum = 0
        PBpoints.Maximum = nextThreshold
        PBpoints.Value = Math.Min(points, PBpoints.Maximum) ' prevent exceeding max
        PBpoints.Style = ProgressBarStyle.Continuous

        lblPBpoints.Text = $"{points}/{PBpoints.Maximum} points"

        lblNextB.Text = GetNextAchievement(points)
        btnCurrentTier.Text = "Current Tier : " & GetCurrentTier(points)

        UpdateTierBadges()

        CheckAchievements(My.Settings.SavedUsername)
    End Sub

    Private Sub CheckAchievements(username As String)
        Try
            Using conn As New SQLiteConnection("Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;")
                conn.Open()

                Dim query As String = "SELECT points FROM UserSignUp WHERE username = @username"
                Dim totalPoints As Double = 0
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then
                        totalPoints = Convert.ToDouble(result)
                    End If
                End Using

                Dim achievements As New Dictionary(Of Integer, Double) From {
                {1, 1000},
                {2, 5000},
                {3, 10000},
                {4, 50000}
            }

                Dim achievementNames As New Dictionary(Of Integer, String) From {
                {1, "Eco Starter"},
                {2, "Green Guardian"},
                {3, "Sustainability Hero"},
                {4, "Planet Protector"}
            }

                For Each kvp In achievements
                    Dim achID = kvp.Key
                    Dim requiredPoints = kvp.Value

                    ' Check if already unlocked
                    Dim checkQuery As String = "SELECT COUNT(*) FROM achievements WHERE username = @username AND achievementId = @achID AND unlocked = 1"
                    Using checkCmd As New SQLiteCommand(checkQuery, conn)
                        checkCmd.Parameters.AddWithValue("@username", username)
                        checkCmd.Parameters.AddWithValue("@achID", achID)
                        Dim alreadyUnlocked = Convert.ToInt32(checkCmd.ExecuteScalar())

                        ' Unlock if points threshold reached and not yet unlocked
                        If totalPoints >= requiredPoints AndAlso alreadyUnlocked = 0 Then
                            Dim unlockQuery As String = "INSERT INTO achievements (username, achievementId, unlocked) VALUES (@username, @achID, 1)"
                            Using unlockCmd As New SQLiteCommand(unlockQuery, conn)
                                unlockCmd.Parameters.AddWithValue("@username", username)
                                unlockCmd.Parameters.AddWithValue("@achID", achID)
                                unlockCmd.Parameters.AddWithValue("@name", achievementNames(achID))
                                unlockCmd.ExecuteNonQuery()
                            End Using

                            MessageBox.Show($"Congratulations! You unlocked achievement '{achievementNames(achID)}'!", "Achievement Unlocked", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Error checking achievements: " & ex.Message)
        End Try
    End Sub

    Private Function GetTotalPoints(username As String) As Integer
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
            MessageBox.Show("Error loading points: " & ex.Message)
        End Try

        Return points
    End Function

    Private Function GetUserTier(username As String) As String
        Dim points As Integer = 0
        Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

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

        Return GetCurrentTier(points)
    End Function

    Private Function GetNextAchievementPoints(points As Integer) As Integer
        ' Define achievement thresholds
        Dim thresholds As Integer() = {1000, 5000, 10000, 50000}

        ' Find the first threshold greater than current points
        For Each threshold In thresholds
            If points < threshold Then
                Return threshold
            End If
        Next

        ' If user already maxed out, return the highest threshold
        Return thresholds.Last()
    End Function
    Private Function GetNextAchievement(points As Integer) As String
        For Each kvp In achievements
            If points < kvp.Value.Points Then
                Return kvp.Value.Name
            End If
        Next
        Return "All Achievements Unlocked!"
    End Function
    Private Function GetCurrentTier(points As Integer) As String
        If points >= 50000 Then
            Return "Platinum"
        ElseIf points >= 10000 Then
            Return "Gold"
        ElseIf points >= 1000 Then
            Return "Silver"
        ElseIf points >= 10 Then
            Return "Bronze"
        Else
            Return "No Tier Yet"
        End If
    End Function
    Private Sub UpdateTierBadges()
        Dim points = GetTotalPoints(My.Settings.SavedUsername)

        btn1.Enabled = (points >= 1000)
        btn2.Enabled = (points >= 5000)
        btn3.Enabled = (points >= 10000)
        btn4.Enabled = (points >= 50000)
    End Sub

    Private Sub btnBronze_Paint(sender As Object, e As PaintEventArgs) Handles btnBronze.Paint
        Dim rect As Rectangle = btnBronze.ClientRectangle

        ' Colors for bronze gradient
        Dim bronzeLight As Color = Color.FromArgb(205, 127, 50)
        Dim bronzeDark As Color = Color.FromArgb(150, 90, 40)

        ' Fill background gradient
        Using brush As New Drawing2D.LinearGradientBrush(rect, bronzeLight, bronzeDark, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        ' Draw border
        Using pen As New Pen(Color.FromArgb(128, 70, 27), 3)
            e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1)
        End Using

        ' Draw text at top-left
        Dim text As String = "Bronze"
        Using textFont As New Font("Showcard Gothic", 16, FontStyle.Bold)
            ' Padding from edges
            Dim x As Single = 10   ' distance from left
            Dim y As Single = 8    ' distance from top

            ' Shadow
            e.Graphics.DrawString(text, textFont, Brushes.Black, x + 2, y + 2)
            ' Main text
            e.Graphics.DrawString(text, textFont, Brushes.White, x, y)
        End Using

        Dim text01 As String = "[10 Rpoints to unlock]"
        Using textFont As New Font("Times New Roman", 12, FontStyle.Bold)
            Dim x As Single = 150
            Dim y As Single = 15

            e.Graphics.DrawString(text01, textFont, Brushes.Blue, x, y)
        End Using

        Dim text1 As String = "Eco Starter Badge Unlocked!"
        Using textFont As New Font("Segoe UI", 12, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 45

            e.Graphics.DrawString(text1, textFont, Brushes.Black, x, y)
        End Using

        Dim text11 As String = "> Earn 1x Rpoints"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 80

            e.Graphics.DrawString(text11, textFont, Brushes.Black, x, y)
        End Using

        Dim text31 As String = "> Unlock Title: You're Growing Greener!"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 110

            e.Graphics.DrawString(text31, textFont, Brushes.Black, x, y)
        End Using
    End Sub
    Private Sub btnSilver_Paint(sender As Object, e As PaintEventArgs) Handles btnSilver.Paint
        Dim rect As Rectangle = btnSilver.ClientRectangle
        Dim silverLight As Color = Color.FromArgb(210, 210, 210)
        Dim silverDark As Color = Color.FromArgb(100, 100, 100)

        Using brush As New Drawing2D.LinearGradientBrush(rect, silverLight, silverDark, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        Using pen As New Pen(Color.FromArgb(130, 130, 130), 3)
            e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1)
        End Using

        Dim text As String = "Silver"
        Using textFont As New Font("Showcard Gothic", 16, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 8
            e.Graphics.DrawString(text, textFont, Brushes.Black, x + 2, y + 2)
            e.Graphics.DrawString(text, textFont, Brushes.White, x, y)
        End Using

        Dim text02 As String = "[1000 Rpoints to unlock]"
        Using textFont As New Font("Times New Roman", 12, FontStyle.Bold)
            Dim x As Single = 135
            Dim y As Single = 15

            e.Graphics.DrawString(text02, textFont, Brushes.Blue, x, y)
        End Using

        Dim text2 As String = "Green Guardian Badge Unlocked!"
        Using textFont As New Font("Segoe UI", 12, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 45

            e.Graphics.DrawString(text2, textFont, Brushes.Black, x, y)
        End Using

        Dim text12 As String = "> Earn 1.5x Rpoints"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 80

            e.Graphics.DrawString(text12, textFont, Brushes.Black, x, y)
        End Using

        Dim text32 As String = "> Unlock Title: Shining with Sustainability!"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 110

            e.Graphics.DrawString(text32, textFont, Brushes.Black, x, y)
        End Using
    End Sub

    Private Sub btnGold_Paint(sender As Object, e As PaintEventArgs) Handles btnGold.Paint
        Dim rect As Rectangle = btnGold.ClientRectangle
        Dim goldLight As Color = Color.FromArgb(255, 215, 128)
        Dim goldDark As Color = Color.FromArgb(153, 101, 21)

        Using brush As New Drawing2D.LinearGradientBrush(rect, goldLight, goldDark, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        Using pen As New Pen(Color.FromArgb(212, 175, 55), 3)
            e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1)
        End Using

        Dim text As String = "Gold"
        Using textFont As New Font("Showcard Gothic", 16, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 8
            e.Graphics.DrawString(text, textFont, Brushes.Black, x + 2, y + 2)
            e.Graphics.DrawString(text, textFont, Brushes.White, x, y)
        End Using

        Dim text03 As String = "[10000 Rpoints to unlock]"
        Using textFont As New Font("Times New Roman", 12, FontStyle.Bold)
            Dim x As Single = 110
            Dim y As Single = 15

            e.Graphics.DrawString(text03, textFont, Brushes.Blue, x, y)
        End Using

        Dim text3 As String = "Sustainability Hero Badge Unlocked!"
        Using textFont As New Font("Segoe UI", 12, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 45

            e.Graphics.DrawString(text3, textFont, Brushes.Black, x, y)
        End Using

        Dim text13 As String = "> Earn 2x Rpoints"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 80

            e.Graphics.DrawString(text13, textFont, Brushes.Black, x, y)
        End Using

        Dim text33 As String = "> Unlock Title: Golden Guardian of the Earth!"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 110

            e.Graphics.DrawString(text33, textFont, Brushes.Black, x, y)
        End Using
    End Sub

    Private Sub btnPlatinum_Paint(sender As Object, e As PaintEventArgs) Handles btnPlatinum.Paint
        Dim rect As Rectangle = btnPlatinum.ClientRectangle
        Dim platinumLight As Color = Color.FromArgb(245, 245, 255)
        Dim platinumDark As Color = Color.FromArgb(160, 160, 200)

        Using brush As New Drawing2D.LinearGradientBrush(rect, platinumLight, platinumDark, Drawing2D.LinearGradientMode.Vertical)
            e.Graphics.FillRectangle(brush, rect)
        End Using

        Using pen As New Pen(Color.FromArgb(200, 200, 230), 3)
            e.Graphics.DrawRectangle(pen, 0, 0, rect.Width - 1, rect.Height - 1)
        End Using

        Dim text As String = "Platinum"
        Using textFont As New Font("Showcard Gothic", 16, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 8
            e.Graphics.DrawString(text, textFont, Brushes.Black, x + 2, y + 2)
            e.Graphics.DrawString(text, textFont, Brushes.White, x, y)
        End Using

        Dim text04 As String = "[50000 Rpoints to unlock]"
        Using textFont As New Font("Times New Roman", 12, FontStyle.Bold)
            Dim x As Single = 190
            Dim y As Single = 15

            e.Graphics.DrawString(text04, textFont, Brushes.Blue, x, y)
        End Using

        Dim text4 As String = "Planet Protector Badge Unlocked!"
        Using textFont As New Font("Segoe UI", 12, FontStyle.Bold)
            Dim x As Single = 10
            Dim y As Single = 45

            e.Graphics.DrawString(text4, textFont, Brushes.Black, x, y)
        End Using

        Dim text14 As String = "> Earn 3x Rpoints"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 80

            e.Graphics.DrawString(text14, textFont, Brushes.Black, x, y)
        End Using

        Dim text34 As String = "> Unlock Title: Planet Protector Supreme!"
        Using textFont As New Font("Tw Cen MT", 11, FontStyle.Regular)
            Dim x As Single = 10
            Dim y As Single = 110

            e.Graphics.DrawString(text34, textFont, Brushes.Black, x, y)
        End Using
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        previousForm.Show()
        Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim form1 As New Form1(Me)
        form1.Show()
        Hide()
    End Sub

    Private Sub btnReward_Click(sender As Object, e As EventArgs) Handles btnReward.Click
        Dim form2 As New rewards(Me)
        form2.Show()
        Hide()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        Dim f As New recycleHistory(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim form5 As New profile(Me)
        form5.Show()
        Hide()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

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
End Class