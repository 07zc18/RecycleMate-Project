Imports System.Data.SQLite

Public Class wishList

    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
    Dim conn As New SQLiteConnection(cs)
    Private Sub wishList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()

            Dim count As Integer = GetWishlistCount(conn)

            Panel1.Visible = False
            Panel2.Visible = False
            Panel3.Visible = False
            Panel4.Visible = False
            Panel5.Visible = False
            Panel6.Visible = False

            If count >= 1 Then Panel1.Visible = True
            If count >= 2 Then Panel2.Visible = True
            If count >= 3 Then Panel3.Visible = True
            If count >= 4 Then Panel4.Visible = True
            If count >= 5 Then Panel5.Visible = True
            If count >= 6 Then Panel6.Visible = True

            LoadWishlistItems(conn)

        Catch ex As Exception
            MessageBox.Show("Error checking wishlist: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function GetWishlistCount(conn As SQLiteConnection) As Integer
        Dim query As String = "SELECT COUNT(*) FROM WishList WHERE username = @username"
        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
            Return Convert.ToInt32(cmd.ExecuteScalar())
        End Using
    End Function

    Private Sub LoadWishlistItems(conn As SQLiteConnection)
        Dim query As String = "SELECT item FROM WishList WHERE username = @username LIMIT 6"
        Dim items As New List(Of String)

        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)

            Using reader As SQLiteDataReader = cmd.ExecuteReader()
                While reader.Read()
                    items.Add(reader("item").ToString())
                End While
            End Using
        End Using

        wl1.Text = ""
        wl2.Text = ""
        wl3.Text = ""
        wl4.Text = ""
        wl5.Text = ""
        wl6.Text = ""

        ' Fill labels based on number of items
        If items.Count >= 1 Then wl1.Text = items(0)
        If items.Count >= 2 Then wl2.Text = items(1)
        If items.Count >= 3 Then wl3.Text = items(2)
        If items.Count >= 4 Then wl4.Text = items(3)
        If items.Count >= 5 Then wl5.Text = items(4)
        If items.Count >= 6 Then wl6.Text = items(5)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If String.IsNullOrWhiteSpace(My.Settings.SavedUsername) Then
            MessageBox.Show("Please log in to add items to your wishlist.", "Login Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Dim loginForm As New Login()
            loginForm.Show()

            Return
        End If

        Dim f As New addWishList()
        f.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
    Private Sub btnDelete1_Click(sender As Object, e As EventArgs) Handles btnDelete1.Click
        DeleteItemAndRefresh(wl1.Text)
    End Sub

    Private Sub btnDelete2_Click(sender As Object, e As EventArgs) Handles btnDelete2.Click
        DeleteItemAndRefresh(wl2.Text)
    End Sub
    Private Sub btnDelete3_Click(sender As Object, e As EventArgs) Handles btnDelete3.Click
        DeleteItemAndRefresh(wl3.Text)
    End Sub
    Private Sub btnDelete4_Click(sender As Object, e As EventArgs) Handles btnDelete4.Click
        DeleteItemAndRefresh(wl4.Text)
    End Sub
    Private Sub btnDelete5_Click(sender As Object, e As EventArgs) Handles btnDelete5.Click
        DeleteItemAndRefresh(wl5.Text)
    End Sub
    Private Sub btnDelete6_Click(sender As Object, e As EventArgs) Handles btnDelete6.Click
        DeleteItemAndRefresh(wl6.Text)
    End Sub

    Private Sub DeleteItemAndRefresh(itemName As String)
        Try
            conn.Open()

            If DeleteWishlistItem(conn, itemName) Then
                MessageBox.Show("Item removed.")
            Else
                MessageBox.Show("Item not found.")
            End If

            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
                frm.Hide()
            Next

            Dim profileForm As New profile(Me)
            profileForm.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
    Private Function DeleteWishlistItem(conn As SQLiteConnection, itemName As String) As Boolean
        Dim query As String = "DELETE FROM WishList WHERE username = @username AND item = @item"

        Using cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
            cmd.Parameters.AddWithValue("@item", itemName)

            Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
            Return rowsAffected > 0
        End Using
    End Function
End Class