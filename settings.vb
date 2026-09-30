Imports System.Data.SQLite
Public Class settings
    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Private Sub settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadSettings()
    End Sub

    Private Sub LoadSettings()
        Try
            Using conn As New SQLiteConnection(cs)
                conn.Open()
                Dim query As String = "SELECT daily_recycle_reminder, achievement_updates, email_promotions 
                                       FROM UserNotifications WHERE username=@username"
                Using cmd As New SQLiteCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            chkRecycleReminder.Checked = If(IsDBNull(reader("daily_recycle_reminder")), False, Convert.ToInt32(reader("daily_recycle_reminder")) = 1)
                            chkAchievementUpdate.Checked = If(IsDBNull(reader("achievement_updates")), False, Convert.ToInt32(reader("achievement_updates")) = 1)
                            chkEmailPromo.Checked = If(IsDBNull(reader("email_promotions")), False, Convert.ToInt32(reader("email_promotions")) = 1)
                        Else
                            ' Default values for new users
                            chkRecycleReminder.Checked = False
                            chkAchievementUpdate.Checked = False
                            chkEmailPromo.Checked = False
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim daily As Integer = If(chkRecycleReminder.Checked, 1, 0)
        Dim achievement As Integer = If(chkAchievementUpdate.Checked, 1, 0)
        Dim promo As Integer = If(chkEmailPromo.Checked, 1, 0)
        Dim username As String = My.Settings.SavedUsername

        Using conn As New SQLiteConnection(cs)
            conn.Open()

            Dim checkQuery As String = "SELECT COUNT(*) FROM UserNotifications WHERE username=@username"
            Dim exists As Boolean
            Using cmd As New SQLiteCommand(checkQuery, conn)
                cmd.Parameters.AddWithValue("@username", username)
                exists = Convert.ToInt32(cmd.ExecuteScalar()) > 0
            End Using

            If exists Then
                Dim updateQuery As String = "
                    UPDATE UserNotifications
                    SET daily_recycle_reminder=@daily,
                        achievement_updates=@achievement,
                        email_promotions=@promo,
                        last_updated=CURRENT_TIMESTAMP
                    WHERE username=@username"
                Using cmd As New SQLiteCommand(updateQuery, conn)
                    cmd.Parameters.AddWithValue("@daily", daily)
                    cmd.Parameters.AddWithValue("@achievement", achievement)
                    cmd.Parameters.AddWithValue("@promo", promo)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.ExecuteNonQuery()
                End Using
            Else
                Dim insertQuery As String = "
                    INSERT INTO UserNotifications (username, daily_recycle_reminder, achievement_updates, email_promotions)
                    VALUES (@username, @daily, @achievement, @promo)"
                Using cmd As New SQLiteCommand(insertQuery, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@daily", daily)
                    cmd.Parameters.AddWithValue("@achievement", achievement)
                    cmd.Parameters.AddWithValue("@promo", promo)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        End Using

        MessageBox.Show("Settings saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        My.Settings.SavedUsername = ""
        My.Settings.Save()

        Hide()

        For Each frm In Application.OpenForms.Cast(Of Form).ToList
            frm.Hide()
        Next
        Dim emptyForm As New profile(Nothing)
        emptyForm.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

    Private Sub btnChangePass_Click(Sender As Object, e As EventArgs) Handles btnChangePass.Click
        Dim f As New changePassword
        f.Show()
    End Sub
    Private Sub btnPrivacy_Click(Sender As Object, e As EventArgs) Handles btnPrivacy.Click
        Dim f As New PrivacyPolicy
        f.Show()
    End Sub
End Class
