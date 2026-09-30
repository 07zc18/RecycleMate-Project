Imports System.Data.SQLite

Public Class Form1
    Public Property LoggedInUsername As String
    Public Property LoggedInName As String
    Public Property LoggedInEmail As String
    Public Property LoggedInPhone As String
    Public Property LoggedInDate As String

    Private previousForm As Form
    Public Sub New()
        InitializeComponent()
    End Sub
    Public Sub New(prev As Form)
        InitializeComponent()
        previousForm = prev
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblWelcome.Text = "Welcome " & My.Settings.SavedUsername & "!"

        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        btnHome.PerformClick()
        btnHome.BackColor = Color.SeaGreen
        Me.BackColor = Color.SeaGreen

        ListView1.OwnerDraw = True
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True

        ListView1.Columns.Clear()
        ListView1.Columns.Add("Num", 80)
        ListView1.Columns.Add("Location", 300)

        Try
            Using conn As New SQLiteConnection("Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;")
                conn.Open()
                Using cmd As New SQLiteCommand("SELECT id, location FROM location", conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim lvItem As New ListViewItem(reader("id").ToString())
                            lvItem.SubItems.Add(reader("location").ToString())
                            ListView1.Items.Add(lvItem)
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading location: " & ex.Message)
        End Try

        lblTitle.TextAlign = ContentAlignment.MiddleLeft
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.AutoSize = False
        lblTitle.Width = 800

        lblnews.TextAlign = ContentAlignment.MiddleLeft
        lblnews.ImageAlign = ContentAlignment.MiddleRight
        lblnews.AutoSize = False
        lblnews.Width = 150

        lblLocation.TextAlign = ContentAlignment.MiddleLeft
        lblLocation.ImageAlign = ContentAlignment.MiddleRight
        lblLocation.AutoSize = False
        lblLocation.Width = 195

        For Each btn As Button In {btnReward, btnTier, btnActivity, btnProfile}
            btn.FlatStyle = FlatStyle.Flat
            btn.FlatAppearance.BorderSize = 0
            btn.BackColor = Color.PaleGreen
        Next

        For Each btn As Button In {btnHome, btnBack, btnExit}
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
    End Sub

    Private Sub ListView1_DrawColumnHeader(sender As Object, e As DrawListViewColumnHeaderEventArgs) Handles ListView1.DrawColumnHeader
        Dim headerFont As New Font("Segoe UI", 10, FontStyle.Bold)
        e.Graphics.FillRectangle(Brushes.LightGreen, e.Bounds)
        TextRenderer.DrawText(e.Graphics, e.Header.Text, headerFont, e.Bounds, Color.Black, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
        e.Graphics.DrawRectangle(Pens.LightGreen, e.Bounds)
    End Sub

    Private Sub ListView1_DrawSubItem(sender As Object, e As DrawListViewSubItemEventArgs) Handles ListView1.DrawSubItem
        ' Draw the background
        If e.ItemIndex Mod 2 = 0 Then
            e.Graphics.FillRectangle(Brushes.White, e.Bounds)
        Else
            e.Graphics.FillRectangle(Brushes.LightGray, e.Bounds)
        End If

        ' Draw the text
        Dim itemFont As New Font("Segoe UI", 9, FontStyle.Regular)
        TextRenderer.DrawText(e.Graphics, e.SubItem.Text, itemFont, e.Bounds, Color.Black, TextFormatFlags.VerticalCenter Or TextFormatFlags.Left)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        previousForm.Show()
        Hide()
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        btnHome.BackColor = Color.SeaGreen
        BackColor = Color.SeaGreen

    End Sub

    Private Sub btnReward_Click(sender As Object, e As EventArgs) Handles btnReward.Click
        Dim Form2 As New rewards(Me)
        Form2.Show()
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

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        ' Create Form5 with current form as previous form
        Dim f5 As New profile(Me)

        ' Pass user details to the Form5 instance you're actually showing
        f5.LoggedInUsername = LoggedInUsername
        f5.LoggedInName = LoggedInName
        f5.LoggedInEmail = LoggedInEmail
        f5.LoggedInPhone = LoggedInPhone
        f5.LoggedInDate = LoggedInDate

        f5.Show()
        Hide()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub plasticBottles_Click(sender As Object, e As EventArgs) Handles plasticBottles.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f6 As New plastic
            f6.Show()
        End If
    End Sub

    Private Sub electronicDevices_Click(sender As Object, e As EventArgs) Handles electronicDevices.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f7 As New electronicDevices
            f7.Show()
        End If
    End Sub

    Private Sub papers_Click(sender As Object, e As EventArgs) Handles papers.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f8 As New paper
            f8.Show()
        End If
    End Sub

    Private Sub aluminium_Click(sender As Object, e As EventArgs) Handles aluminium.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f9 As New aluminium
            f9.Show()
        End If
    End Sub

    Private Sub battery_Click(sender As Object, e As EventArgs) Handles battery.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f10 As New batteries
            f10.Show()
        End If
    End Sub

    Private Sub mixedMetals_Click(sender As Object, e As EventArgs) Handles mixedMetals.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f11 As New mixedMetals
            f11.Show()
        End If
    End Sub

    Private Sub clothes_Click(sender As Object, e As EventArgs) Handles clothes.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f12 As New clothes
            f12.Show()
        End If
    End Sub

    Private Sub glasses_Click(sender As Object, e As EventArgs) Handles glasses.Click
        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            MessageBox.Show("Please login first!", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Dim f As New Login
            f.Show()
        Else
            Dim f13 As New glasses
            f13.Show()
        End If
    End Sub
End Class
