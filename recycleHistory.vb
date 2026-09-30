Imports System.Collections
Imports System.Data.SQLite

Public Class recycleHistory
    Public Property CurrentUsername As String
    Private previousForm As Form
    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    ' --- Track sorting order for toggling ---  
    Private sortOrders As New Dictionary(Of Integer, SortOrder)

    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub

    Private Sub recycleHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        For Each btn As Button In {btnActivity, btnBack, btnExit, btnIG, btnFB}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.FlatAppearance.MouseOverBackColor = btn.BackColor
            btn.FlatAppearance.MouseDownBackColor = btn.BackColor
        Next

        SetupRecycleHis()

        ' Enable OwnerDraw and add handlers
        ListView1.OwnerDraw = True
        AddHandler ListView1.DrawColumnHeader, AddressOf ListView1_DrawColumnHeader
        AddHandler ListView1.DrawItem, AddressOf ListView1_DrawItem
        AddHandler ListView1.DrawSubItem, AddressOf ListView1_DrawSubItem

        SetupLeaderboardDGV()
        UpdateLeaderboardIfQualified(My.Settings.SavedUsername)
        LoadLeaderboard()

        SetupRecycleDGV()

        AutoRandomApprovalAndReject()


        LoadRecycleHistory()

        LoadRecycleData()

        UpdateRowColors()
        HighlightCurrentUser()
    End Sub

    Private Sub SetupRecycleDGV()
        dgvRecycle.Columns.Clear()

        dgvRecycle.Columns.Add("Date", "Date")
        dgvRecycle.Columns.Add("Category", "Category")
        dgvRecycle.Columns.Add("Quantity", "Quantity")
        dgvRecycle.Columns.Add("Weight", "Weight(kg)")
        dgvRecycle.Columns.Add("Status", "Approval Status")

        dgvRecycle.Columns("Date").Width = 120
        dgvRecycle.Columns("Category").Width = 150
        dgvRecycle.Columns("Quantity").Width = 128
        dgvRecycle.Columns("Weight").Width = 180
        dgvRecycle.Columns("Status").Width = 200

        ' Make all columns read-only
        For Each col As DataGridViewColumn In dgvRecycle.Columns
            col.ReadOnly = True
        Next

        dgvRecycle.EnableHeadersVisualStyles = False
        dgvRecycle.ColumnHeadersDefaultCellStyle.BackColor = Color.LemonChiffon
        dgvRecycle.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black
        dgvRecycle.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        dgvRecycle.DefaultCellStyle.BackColor = Color.White
        dgvRecycle.DefaultCellStyle.ForeColor = Color.Black
        dgvRecycle.DefaultCellStyle.Font = New Font("Segoe UI", 9)

        dgvRecycle.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvRecycle.MultiSelect = False

        dgvRecycle.AlternatingRowsDefaultCellStyle.BackColor = Color.LemonChiffon
    End Sub

    Private Sub LoadRecycleData()
        dgvRecycle.Rows.Clear()

        If String.IsNullOrWhiteSpace(My.Settings.SavedUsername) Then Return

        Using conn As New SQLiteConnection(cs)
            conn.Open()
            Dim query As String =
        "SELECT Date, Category, Quantity, Weight, Status 
         FROM RecycleHistory 
         WHERE Username = @Username
         ORDER BY Date DESC"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@Username", My.Settings.SavedUsername)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        dgvRecycle.Rows.Add(reader("Date"), reader("Category"), reader("Quantity"), reader("Weight"), reader("Status"))
                    End While
                End Using
            End Using
        End Using
    End Sub


    Private Sub AutoRandomApprovalAndReject()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                ' Only process pending items
                Dim selectQuery As String =
            "SELECT ID, Category, Quantity, Weight, Date 
             FROM RecycleHistory 
             WHERE LOWER(Status) = 'pending'"

                Dim pending As New List(Of (Integer, String, Integer, Double, String))

                Using cmd As New SQLiteCommand(selectQuery, conn)
                    Using r = cmd.ExecuteReader()
                        While r.Read()
                            pending.Add((
                            Convert.ToInt32(r("ID")),
                            r("Category").ToString(),
                            Convert.ToInt32(r("Quantity")),
                            Convert.ToDouble(r("Weight")),
                            r("Date").ToString()
                        ))
                        End While
                    End Using
                End Using

                If pending.Count = 0 Then Exit Sub

                Dim rand As New Random()

                For Each record In pending
                    Dim roll As Integer = rand.Next(1, 101)
                    Dim newStatus As String

                    If roll <= 60 Then
                        newStatus = "Approved"
                    ElseIf roll <= 80 Then
                        newStatus = "Rejected"
                    Else
                        newStatus = "Pending"
                    End If

                    Using cmd As New SQLiteCommand(
                    "UPDATE RecycleHistory 
                     SET Status = @status 
                     WHERE ID = @id", conn)

                        cmd.Parameters.AddWithValue("@status", newStatus)
                        cmd.Parameters.AddWithValue("@id", record.Item1)
                        cmd.ExecuteNonQuery()
                    End Using
                Next

            End Using

            LoadRecycleData()
            UpdateRowColors()

        Catch ex As Exception
            MessageBox.Show("Error during auto approval: " & ex.Message)
        End Try
    End Sub


    Private Sub UpdateRowColors()
        For Each row As DataGridViewRow In dgvRecycle.Rows
            ' Ensure the row is not a new row and the "Status" cell exists
            If Not row.IsNewRow AndAlso dgvRecycle.Columns.Contains("Status") AndAlso row.Cells("Status").Value IsNot Nothing Then
                Dim status As String = row.Cells("Status").Value.ToString().ToLower()

                Select Case status
                    Case "pending"
                        row.DefaultCellStyle.BackColor = Color.Yellow
                    Case "approved"
                        row.DefaultCellStyle.BackColor = Color.LightGreen
                    Case "rejected"
                        row.DefaultCellStyle.BackColor = Color.IndianRed
                    Case Else
                        row.DefaultCellStyle.BackColor = Color.White
                End Select
            End If
        Next
    End Sub

    Private Sub SetupRecycleHis()
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True

        ListView1.Columns.Clear()

        ListView1.Columns.Add("Date", 120, HorizontalAlignment.Left)
        ListView1.Columns.Add("Category", 150, HorizontalAlignment.Left)
        ListView1.Columns.Add("Quantity", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("Weight (kg)", 130, HorizontalAlignment.Left)
        ListView1.Columns.Add("Points", 120, HorizontalAlignment.Left)
        ListView1.Columns.Add("Location", 220, HorizontalAlignment.Left)

        For i As Integer = 0 To ListView1.Columns.Count - 1
            sortOrders(i) = SortOrder.Ascending
        Next
    End Sub

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

    ' Toggle sort function for Recycle History
    Private Sub ToggleSort(columnIndex As Integer, comparerType As Type)
        Dim currentOrder As SortOrder = sortOrders(columnIndex)
        ' Toggle Ascending/Descending
        If currentOrder = SortOrder.Ascending Then
            currentOrder = SortOrder.Descending
        Else
            currentOrder = SortOrder.Ascending
        End If
        sortOrders(columnIndex) = currentOrder

        ' Apply sorter to ListView1 (Recycle History)
        If comparerType Is GetType(ListViewDateComparer) Then
            ListView1.ListViewItemSorter = New ListViewDateComparer(columnIndex, currentOrder)
        ElseIf comparerType Is GetType(ListViewNumberComparer) Then
            ListView1.ListViewItemSorter = New ListViewNumberComparer(columnIndex, currentOrder)
        ElseIf comparerType Is GetType(ListViewStringComparer) Then
            ListView1.ListViewItemSorter = New ListViewStringComparer(columnIndex, currentOrder)
        End If

        ListView1.Sort()
    End Sub

    Private Sub btnSortByDate_Click(sender As Object, e As EventArgs) Handles btnSortByDate.Click
        ToggleSort(0, GetType(ListViewDateComparer))
    End Sub

    Private Sub btnSortByCategory_Click(sender As Object, e As EventArgs) Handles btnSortByCategory.Click
        ToggleSort(1, GetType(ListViewStringComparer))
    End Sub

    Private Sub btnSortByQuantity_Click(sender As Object, e As EventArgs) Handles btnSortByQuantity.Click
        ToggleSort(2, GetType(ListViewNumberComparer))
    End Sub

    Private Sub btnSortByWeight_Click(sender As Object, e As EventArgs) Handles btnSortByWeight.Click
        ToggleSort(3, GetType(ListViewNumberComparer))
    End Sub

    Private Sub btnSortByLocation_Click(sender As Object, e As EventArgs) Handles btnSortByLocation.Click
        ToggleSort(5, GetType(ListViewStringComparer))
    End Sub

    ' Comparer Classes for Recycle History ListView 
    Public Class ListViewDateComparer
        Implements IComparer

        Private columnIndex As Integer
        Private sortOrder As SortOrder

        Public Sub New(colIndex As Integer, order As SortOrder)
            columnIndex = colIndex
            sortOrder = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Try
                Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
                Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

                Dim dateX As Date = Date.Parse(itemX.SubItems(columnIndex).Text)
                Dim dateY As Date = Date.Parse(itemY.SubItems(columnIndex).Text)

                Dim result As Integer = dateX.CompareTo(dateY)

                Return If(sortOrder = SortOrder.Ascending, result, -result)
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class ListViewNumberComparer
        Implements IComparer

        Private columnIndex As Integer
        Private sortOrder As SortOrder

        Public Sub New(colIndex As Integer, order As SortOrder)
            columnIndex = colIndex
            sortOrder = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Try
                Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
                Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

                Dim numX As Double = Double.Parse(itemX.SubItems(columnIndex).Text)
                Dim numY As Double = Double.Parse(itemY.SubItems(columnIndex).Text)

                Dim result As Integer = numX.CompareTo(numY)

                Return If(sortOrder = SortOrder.Ascending, result, -result)
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Public Class ListViewStringComparer
        Implements IComparer

        Private columnIndex As Integer
        Private sortOrder As SortOrder

        Public Sub New(colIndex As Integer, order As SortOrder)
            columnIndex = colIndex
            sortOrder = order
        End Sub

        Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
            Try
                Dim itemX As ListViewItem = DirectCast(x, ListViewItem)
                Dim itemY As ListViewItem = DirectCast(y, ListViewItem)

                Dim result As Integer = String.Compare(itemX.SubItems(columnIndex).Text, itemY.SubItems(columnIndex).Text)

                Return If(sortOrder = SortOrder.Ascending, result, -result)
            Catch ex As Exception
                Return 0
            End Try
        End Function
    End Class

    Private Sub LoadRecycleHistory()

        If String.IsNullOrWhiteSpace(My.Settings.SavedUsername) Then
            ListView1.Items.Clear()
            Return
        End If

        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String =
            "SELECT Date, Category, Quantity, Weight, Points, Location 
             FROM RecycleHistory 
             WHERE Username = @Username AND LOWER(Status) = 'approved'
             ORDER BY Date DESC"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", My.Settings.SavedUsername)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListView1.Items.Clear()

                        While reader.Read()
                            Dim item As New ListViewItem(reader("Date").ToString())
                            item.SubItems.Add(reader("Category").ToString())
                            item.SubItems.Add(reader("Quantity").ToString())
                            item.SubItems.Add(reader("Weight").ToString())
                            item.SubItems.Add(reader("Points").ToString())
                            item.SubItems.Add(reader("Location").ToString())

                            ListView1.Items.Add(item)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading recycle history: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

    Private Function DetermineTier(points As Integer) As String
        If points >= 1000 Then
            Return "Platinum"
        ElseIf points >= 500 Then
            Return "Gold"
        ElseIf points >= 200 Then
            Return "Silver"
        ElseIf points >= 100 Then
            Return "Bronze"
        Else
            Return "Beginner"
        End If
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

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        Me.Hide()
        Dim homeForm As New Form1()
        homeForm.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        If previousForm IsNot Nothing Then
            previousForm.Show()
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReward_Click(sender As Object, e As EventArgs) Handles btnReward.Click
        Me.Hide()
        Dim rewardForm As New rewards(Me)
        rewardForm.Show()
    End Sub

    Private Sub btnTier_Click(sender As Object, e As EventArgs) Handles btnTier.Click
        Me.Hide()
        Dim tierForm As New tier(Me)
        tierForm.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Me.Hide()
        Dim profileForm As New profile(Me)
        profileForm.Show()
    End Sub

    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        LoadRecycleHistory()
        LoadLeaderboard()
    End Sub

    ' Column header click sorting (alternative to button sorting)
    Private Sub ListView1_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles ListView1.ColumnClick
        Select Case e.Column
            Case 0 ' Date
                ToggleSort(e.Column, GetType(ListViewDateComparer))
            Case 1 ' Category
                ToggleSort(e.Column, GetType(ListViewStringComparer))
            Case 2 ' Quantity
                ToggleSort(e.Column, GetType(ListViewNumberComparer))
            Case 3 ' Weight
                ToggleSort(e.Column, GetType(ListViewNumberComparer))
            Case 4 ' Location
                ToggleSort(e.Column, GetType(ListViewStringComparer))
        End Select
    End Sub

    Private Sub btnPointEx_Click(sender As Object, e As EventArgs) Handles btnPointEx.Click
        Dim f As New pointsEx(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub btnInbox_Click(sender As Object, e As EventArgs) Handles btnInbox.Click
        Dim f As New Inbox(Me)
        f.Show()
        Hide()
    End Sub

    Private Sub SearchRecycleHistory(searchText As String)
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT Date, Category, Quantity, Weight, Points, Location FROM RecycleHistory WHERE Username = @Username"

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    query &= " AND Category LIKE @search"
                End If

                query &= " ORDER BY Date DESC"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", My.Settings.SavedUsername)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", $"%{searchText}%")
                    End If

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListView1.Items.Clear()

                        While reader.Read()
                            Dim lvItem As New ListViewItem(reader("Date").ToString())
                            lvItem.SubItems.Add(reader("Category").ToString())
                            lvItem.SubItems.Add(reader("Quantity").ToString())
                            lvItem.SubItems.Add(reader("Weight").ToString())
                            lvItem.SubItems.Add(reader("Points").ToString())
                            lvItem.SubItems.Add(reader("Location").ToString())
                            ListView1.Items.Add(lvItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching recycle history: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchRecycleHistoryByLocation(searchText As String)
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT Date, Category, Quantity, Weight, Points, Location FROM RecycleHistory WHERE Username = @Username"

                If Not String.IsNullOrWhiteSpace(searchText) Then
                    query &= " AND Location LIKE @search"
                End If

                query &= " ORDER BY Date DESC"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", My.Settings.SavedUsername)
                    If Not String.IsNullOrWhiteSpace(searchText) Then
                        cmd.Parameters.AddWithValue("@search", $"%{searchText}%")
                    End If

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListView1.Items.Clear()

                        While reader.Read()
                            Dim lvItem As New ListViewItem(reader("Date").ToString())
                            lvItem.SubItems.Add(reader("Category").ToString())
                            lvItem.SubItems.Add(reader("Quantity").ToString())
                            lvItem.SubItems.Add(reader("Weight").ToString())
                            lvItem.SubItems.Add(reader("Points").ToString())
                            lvItem.SubItems.Add(reader("Location").ToString())
                            ListView1.Items.Add(lvItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error searching recycle history: " & ex.Message)
        End Try
    End Sub

    Private Sub RefreshRecycleHistory()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()

                Dim query As String = "SELECT Date, Category, Quantity, Weight, Points, Location " &
                                  "FROM RecycleHistory " &
                                  "WHERE Username = @Username AND LOWER(Status) = 'approved' " &
                                  "ORDER BY Date DESC"

                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Username", My.Settings.SavedUsername)

                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        ListView1.Items.Clear()

                        While reader.Read()
                            Dim lvItem As New ListViewItem(reader("Date").ToString())
                            lvItem.SubItems.Add(reader("Category").ToString())
                            lvItem.SubItems.Add(reader("Quantity").ToString())
                            lvItem.SubItems.Add(reader("Weight").ToString())
                            lvItem.SubItems.Add(reader("Points").ToString())
                            lvItem.SubItems.Add(reader("Location").ToString())

                            ListView1.Items.Add(lvItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error refreshing recycle history: " & ex.Message)
        End Try
    End Sub
    Private Sub btnSearchC_Click(sender As Object, e As EventArgs) Handles btnSearchC.Click
        SearchRecycleHistory(txtSearchC.Text)
    End Sub

    Private Sub btnSearchL_Click(sender As Object, e As EventArgs) Handles btnSearchL.Click
        SearchRecycleHistoryByLocation(txtSearchL.Text)
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        RefreshRecycleHistory()
    End Sub
End Class