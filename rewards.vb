Imports System.Data.SQLite

Public Class rewards
    Private previousForm As Form
    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    ' Store current logged-in user (from login or My.Settings)
    Private currentUser As String = My.Settings.SavedUsername

    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub

    Private Sub rewards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        btnReward.BackColor = Color.SeaGreen
        Me.BackColor = Color.SeaGreen

        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.AutoSize = False
        lblTitle.Width = 800

        For Each btn As Button In {btnHome, btnTier, btnActivity, btnProfile}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.PaleGreen
        Next

        For Each btn As Button In {btnReward, btnBack, btnExit, lblTokens}
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

        LoadTokenBalance()

    End Sub

    Private Sub ClaimReward(item As String, cost As Integer)
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim getPointsQuery As String = "SELECT tokens FROM UserSignUp WHERE username=@u"
                Dim userToken As Integer = 0

                Using cmd As New SQLiteCommand(getPointsQuery, conn)
                    cmd.Parameters.AddWithValue("@u", currentUser)
                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing Then
                        userToken = Convert.ToInt32(result)
                    Else
                        MessageBox.Show("Please Login To Continue.", "Reward Claim Failed")
                        Dim f As New Login
                        f.Show()
                        Exit Sub
                    End If
                End Using

                If userToken < cost Then
                    MessageBox.Show("Not enough token to redeem this reward.", "Insufficient Token", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim deductQuery As String =
                "UPDATE UserSignUp SET tokens = tokens - @t WHERE username=@u"

                Using cmd As New SQLiteCommand(deductQuery, conn)
                    cmd.Parameters.AddWithValue("@t", cost)
                    cmd.Parameters.AddWithValue("@u", currentUser)
                    cmd.ExecuteNonQuery()
                End Using

                Dim insertQuery As String =
                "INSERT INTO TokenExchange (username, item, token_spent, status)
                 VALUES (@u, @i, @t, 'Completed')"

                Using cmd As New SQLiteCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@u", currentUser)
                    cmd.Parameters.AddWithValue("@i", item)
                    cmd.Parameters.AddWithValue("@t", cost)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show(
                "Reward redeemed successfully!" & vbCrLf &
                "Item: " & item & vbCrLf &
                "Token Spent: " & cost,
                "Success"
            )

            End Using

        Catch ex As Exception
            MessageBox.Show("Error redeeming reward: " & ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub LoadTokenBalance()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT tokens FROM UserSignUp WHERE username = @u"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@u", currentUser)

                    Dim result = cmd.ExecuteScalar()

                    If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                        lblTokens.Text = "Token balance : " & result.ToString()
                    Else
                        lblTokens.Text = "Tokens balance : 0"
                    End If
                End Using
            End Using

        Catch ex As Exception
            lblTokens.Text = "Tokens: 0"
            MessageBox.Show("Error loading token balance: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClaimTng5_Click(sender As Object, e As EventArgs) Handles btnClaimTng5.Click
        ClaimReward("Touch 'n Go RM5", 5000)
    End Sub

    Private Sub btnClaimTng10_Click(sender As Object, e As EventArgs) Handles btnClaimTng10.Click
        ClaimReward("Touch 'n Go RM10", 8000)
    End Sub

    Private Sub btnClaimTng15_Click(sender As Object, e As EventArgs) Handles btnClaimTng15.Click
        ClaimReward("Touch 'n Go RM15", 15000)
    End Sub
    Private Sub btnClaimTng20_Click(sender As Object, e As EventArgs) Handles btnClaimTng20.Click
        ClaimReward("Touch 'n Go RM20", 20000)
    End Sub

    Private Sub btnClaimLzd5_Click(sender As Object, e As EventArgs) Handles btnClaimLzd5.Click
        ClaimReward("Lazada RM5", 5000)
    End Sub

    Private Sub btnClaimLzd10_Click(sender As Object, e As EventArgs) Handles btnClaimLzd10.Click
        ClaimReward("Lazada RM10", 8000)
    End Sub

    Private Sub btnClaimLzd15_Click(sender As Object, e As EventArgs) Handles btnClaimLzd15.Click
        ClaimReward("Lazada RM15", 15000)
    End Sub

    Private Sub btnClaimLzd20_Click(sender As Object, e As EventArgs) Handles btnClaimLzd20.Click
        ClaimReward("Lazada RM20", 20000)
    End Sub

    Private Sub btnClaimGrab5_Click(sender As Object, e As EventArgs) Handles btnClaimGrab5.Click
        ClaimReward("Grab RM5", 5000)
    End Sub

    Private Sub btnClaimGrab10_Click(sender As Object, e As EventArgs) Handles btnClaimGrab10.Click
        ClaimReward("Grab RM10", 8000)
    End Sub

    Private Sub btnClaimGrab15_Click(sender As Object, e As EventArgs) Handles btnClaimGrab15.Click
        ClaimReward("Grab RM15", 15000)
    End Sub

    Private Sub btnClaimGrab20_Click(sender As Object, e As EventArgs) Handles btnClaimGrab20.Click
        ClaimReward("Grab RM20", 20000)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        previousForm.Show()
        Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Dim f As New Form1(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnTier_Click(sender As Object, e As EventArgs) Handles btnTier.Click
        Dim f As New tier(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        Dim f As New recycleHistory(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Dim f As New profile(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
