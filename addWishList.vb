Imports System.Data.SQLite

Public Class addWishList

    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
    Dim conn As New SQLiteConnection(cs)

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtItem.Text = "" Then
            MessageBox.Show("Please fill in the category you wish to recycle.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()

            If IsWishlistFull(conn) Then
                MessageBox.Show("You can only save 6 wishlist items.")
                conn.Close()
                Exit Sub
            End If

            Dim item = txtItem.Text
            Dim query As String = "INSERT INTO WishList (username, item)
                                   VALUES (@username, @item)"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                cmd.Parameters.AddWithValue("@item", item)
                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show($"You have successfully added {item} into your wish list",
                            "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' all currently open forms, reats each as a Form object, creates a separate list to safely iterate, loops through each open form
            For Each frm As Form In Application.OpenForms.Cast(Of Form).ToList()
                frm.Hide()
            Next

            Dim profileForm As New profile(Me)
            profileForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Function IsWishlistFull(conn As SQLiteConnection) As Boolean
        Dim cmd As New SQLiteCommand("SELECT COUNT(*) FROM wishlist", conn)
        Return Convert.ToInt32(cmd.ExecuteScalar()) >= 6
    End Function

    Private Sub addWishList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
