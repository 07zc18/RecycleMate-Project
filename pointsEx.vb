Imports System.Data.SQLite
Public Class pointsEx
    Public Property CurrentUsername As String
    Private previousForm As Form
    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub

    Private Sub pointsEx_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.SeaGreen
        btnActivity.BackColor = Color.SeaGreen

        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.AutoSize = False
        lblTitle.Width = 800

        For Each btn As Button In {btnHome, btnReward, btnTier, btnProfile}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.PaleGreen
        Next

        For Each btn As Button In {btnActivity, btnBack}
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

        SetupPointsExchangeHis()

        ListView1.OwnerDraw = True
        AddHandler ListView1.DrawColumnHeader, AddressOf ListView1_DrawColumnHeader
        AddHandler ListView1.DrawItem, AddressOf ListView1_DrawItem
        AddHandler ListView1.DrawSubItem, AddressOf ListView1_DrawSubItem

        SetupLeaderboardDGV()

        UpdateLeaderboardIfQualified(My.Settings.SavedUsername)
        LoadLeaderboard()

        LoadPointsExchangeHistory()

        HighlightCurrentUser()
    End Sub

    Private Sub SetupPointsExchangeHis()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
        ListView1.Columns.Clear()

        ListView1.Columns.Add("Date", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Item", 200, HorizontalAlignment.Left)
        ListView1.Columns.Add("Token Spent", 180, HorizontalAlignment.Left)
        ListView1.Columns.Add("Status", 200, HorizontalAlignment.Left)
    End Sub

    ' OwnerDraw handlers
    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs)
        Using brush As New SolidBrush(Color.LightGreen)
            e.Graphics.FillRectangle(brush, e.Bounds)
        End Using
        Using font As New Font(e.Font, FontStyle.Bold)
            TextRenderer.DrawText(e.Graphics, e.Header.Text, font, e.Bounds, Color.Black, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
        End Using
    End Sub

    Private Sub ListView1_DrawItem(sender As Object, e As DrawListViewItemEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs)
        e.DrawDefault = True
    End Sub

    Private Sub SetupLeaderboardDGV()
        dgvLeaderboard.ColumnCount = 4
        dgvLeaderboard.Columns(0).Name = "Rank"
        dgvLeaderboard.Columns(1).Name = "Username"
        dgvLeaderboard.Columns(2).Name = "Points"
        dgvLeaderboard.Columns(3).Name = "Tier"

        dgvLeaderboard.Columns(0).Width = 50
        dgvLeaderboard.Columns(1).Width = 150
        dgvLeaderboard.Columns(2).Width = 100
        dgvLeaderboard.Columns(3).Width = 120

        dgvLeaderboard.BorderStyle = BorderStyle.None
        dgvLeaderboard.Parent = dvgPanel
        dgvLeaderboard.Location = New Point(2, 2)
        dgvLeaderboard.Size = New Size(dvgPanel.Width - 6, dvgPanel.Height - 6)

        For Each col As DataGridViewColumn In dgvLeaderboard.Columns
            col.HeaderCell.Style.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        Next
    End Sub

    Private Sub UpdateLeaderboardIfQualified(username As String)
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Dim userPoints As Integer = 0
                Using cmd As New SQLiteCommand("SELECT Points FROM UserSignUp WHERE Username=@username", conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then userPoints = Convert.ToInt32(result)
                End Using

                Dim userTier As String = GetTier(userPoints)

                Dim lastRankPoints As Integer = 0
                Using cmd As New SQLiteCommand("SELECT Points FROM Leaderboard WHERE Rank=100", conn)
                    Dim result = cmd.ExecuteScalar()
                    If result IsNot Nothing Then lastRankPoints = Convert.ToInt32(result)
                End Using

                If userPoints > lastRankPoints OrElse ExistsInLeaderboard(username, conn) Then
                    If ExistsInLeaderboard(username, conn) Then
                        Using cmd As New SQLiteCommand("UPDATE Leaderboard SET Points=@points, Tier=@tier WHERE Username=@username", conn)
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.Parameters.AddWithValue("@points", userPoints)
                            cmd.Parameters.AddWithValue("@tier", userTier)
                            cmd.ExecuteNonQuery()
                        End Using
                    Else
                        Using cmd As New SQLiteCommand("INSERT INTO Leaderboard (Username, Points, Tier, Rank) VALUES (@username, @points, @tier, 101)", conn)
                            cmd.Parameters.AddWithValue("@username", username)
                            cmd.Parameters.AddWithValue("@points", userPoints)
                            cmd.Parameters.AddWithValue("@tier", userTier)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If

                    ' Recalculate ranks
                    Dim rank As Integer = 1
                    Using cmd As New SQLiteCommand("SELECT Username FROM Leaderboard ORDER BY Points DESC", conn)
                        Using reader As SQLiteDataReader = cmd.ExecuteReader()
                            While reader.Read()
                                Using updateCmd As New SQLiteCommand("UPDATE Leaderboard SET Rank=@rank WHERE Username=@username", conn)
                                    updateCmd.Parameters.AddWithValue("@rank", rank)
                                    updateCmd.Parameters.AddWithValue("@username", reader("Username").ToString())
                                    updateCmd.ExecuteNonQuery()
                                End Using
                                rank += 1
                            End While
                        End Using
                    End Using

                    Using cmd As New SQLiteCommand("DELETE FROM Leaderboard WHERE Rank>100", conn)
                        cmd.ExecuteNonQuery()
                    End Using
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error updating leaderboard: " & ex.Message)
        End Try
    End Sub

    Private Function ExistsInLeaderboard(username As String, conn As SQLiteConnection) As Boolean
        Using cmd As New SQLiteCommand("SELECT COUNT(*) FROM Leaderboard WHERE Username=@username", conn)
            cmd.Parameters.AddWithValue("@username", username)
            Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
        End Using
    End Function

    Private Function GetTier(points As Integer) As String
        Select Case points
            Case >= 50000 : Return "Platinum"
            Case >= 10000 : Return "Gold"
            Case >= 1000 : Return "Silver"
            Case Else : Return "Bronze"
        End Select
    End Function

    Private Sub LoadLeaderboard()
        Try
            dgvLeaderboard.Rows.Clear()
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT username, points, tier FROM Leaderboard ORDER BY points DESC", conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        Dim rank As Integer = 1
                        While reader.Read()
                            dgvLeaderboard.Rows.Add(rank.ToString(), reader("username").ToString(), reader("points").ToString(), reader("tier").ToString())
                            rank += 1
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading leaderboard: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadPointsExchangeHistory()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Dim query As String = "SELECT date, item, token_spent, status 
                                       FROM TokenExchange
                                       WHERE username = @username
                                       ORDER BY date DESC"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListView1.Items.Clear()
                        While reader.Read()
                            Dim fullDate As String = reader("date").ToString()

                            If fullDate.Contains(" ") Then
                                fullDate = fullDate.Split(" "c)(0)     ' Part before the space
                            End If

                            Dim lvItem As New ListViewItem(fullDate)

                            lvItem.SubItems.Add(reader("item").ToString())
                            lvItem.SubItems.Add(reader("token_spent").ToString())
                            lvItem.SubItems.Add(reader("status").ToString())
                            ListView1.Items.Add(lvItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading token exchange history: " & ex.Message)
        End Try
    End Sub
    Private Sub HighlightCurrentUser()
        Dim currentUser As String = My.Settings.SavedUsername

        For Each row As DataGridViewRow In dgvLeaderboard.Rows
            If row.Cells("Username").Value.ToString() = currentUser Then

                row.DefaultCellStyle.BackColor = Color.LightBlue
                row.DefaultCellStyle.Font = New Font(dgvLeaderboard.Font, FontStyle.Bold)

                dgvLeaderboard.FirstDisplayedScrollingRowIndex = row.Index ' Auto-scroll to user
                Exit For
            End If
        Next
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

    Private Sub btnTier_Click(sender As Object, e As EventArgs) Handles btnTier.Click
        Dim form3 As New tier(Me)
        form3.Show()
        Hide()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        Dim f4 As New pointsEx(Me)
        f4.Show()
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

    Private Sub btnRecycleHis_Click(sender As Object, e As EventArgs) Handles btnRecycleHis.Click
        Dim f4 As New recycleHistory(Me)
        f4.Show()
        Hide()
    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnInbox.Click
        Dim f15 As New Inbox(Me)
        f15.Show()
        Hide()
    End Sub
End Class
