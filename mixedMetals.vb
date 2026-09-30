Imports System.Data.SQLite

Public Class mixedMetals
    ' Store the logged-in username
    Public Property CurrentUsername As String

    Dim cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
    Dim conn As New SQLiteConnection(cs)

    Private Sub mixedMetalsl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate location list
        CBLocation.Text = "Select Location"
        CBLocation.Items.AddRange({
            "Caltex Setapak", "Subang Parade", "Petron Serdang", "KPJ Ampang", "Shell Kota Damansara",
            "BHP Melawati", "Plus Rawang", "MyTown Cheras", "Shell Kajang", "Petronas Kota Kemuning",
            "Shell Bukit Rimau", "Pavilion Bukit Jalil", "Paradigm", "BHP Taman Connaught",
            "MCD KL Sentral", "DBKL", "The Gardens", "Pavilion Damansara Heights",
            "KPJ Damansara", "BHP Damansara Utama"
        })

        ' Populate quantity list
        CBQuantity.Text = "Select Quantity"
        For i As Integer = 1 To 10
            CBQuantity.Items.Add(i.ToString())
        Next

        ' Auto-set and lock date
        DateTimePicker1.Value = DateTime.Now
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If CBLocation.Text = "Select Location" Or CBQuantity.Text = "Select Quantity" Then
            MessageBox.Show("Please select both location and quantity.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            conn.Open()

            Dim getPointsQuery As String = "SELECT points FROM UserSignUp WHERE username = @username"
            Dim currentPoints As Double = 0
            Using cmdTier As New SQLiteCommand(getPointsQuery, conn)
                cmdTier.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                Dim result = cmdTier.ExecuteScalar()
                If result IsNot Nothing AndAlso Not IsDBNull(result) Then
                    currentPoints = CDbl(result)
                End If
            End Using

            Dim multiplier As Double = 1.0
            Dim currentTier As String = ""

            If currentPoints >= 50000 Then
                currentTier = "Platinum"
                multiplier = 3.0
            ElseIf currentPoints >= 10000 Then
                currentTier = "Gold"
                multiplier = 2.0
            ElseIf currentPoints >= 1000 Then
                currentTier = "Silver"
                multiplier = 1.5
            ElseIf currentPoints >= 10 Then
                currentTier = "Bronze"
                multiplier = 1.0
            Else
                currentTier = "New"
                multiplier = 1.0
            End If

            Dim quantity As Integer = CInt(CBQuantity.Text)

            Dim category = "Metal"
            Dim location = CBLocation.Text
            Dim dateStr = DateTimePicker1.Value.ToString("yyyy/MM/dd")

            Dim weight As Double = CDbl(CBQuantity.Text) * 0.6
            weight = Math.Round(weight, 2)

            Dim basePoints As Double = weight * 80
            basePoints = Math.Round(basePoints, 2)
            Dim totalPointsEarned As Double = Math.Round(basePoints * multiplier, 2)

            Dim query As String = "INSERT INTO RecycleHistory (username, date, category, quantity, weight, points, location)
                           VALUES (@username, @date, @category, @quantity, @weight, @points, @location)"
            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                cmd.Parameters.AddWithValue("@date", dateStr)
                cmd.Parameters.AddWithValue("@category", category)
                cmd.Parameters.AddWithValue("@quantity", quantity)
                cmd.Parameters.AddWithValue("@weight", weight)
                cmd.Parameters.AddWithValue("@points", totalPointsEarned)
                cmd.Parameters.AddWithValue("@location", location)
                cmd.ExecuteNonQuery()
            End Using


            Dim tokensEarned As Double = basePoints

            Dim updateQuery As String = "UPDATE UserSignUp 
                             SET points = points + @points,
                                 tokens = tokens + @tokens
                             WHERE username = @username"

            Using cmd2 As New SQLiteCommand(updateQuery, conn)
                cmd2.Parameters.AddWithValue("@points", totalPointsEarned)
                cmd2.Parameters.AddWithValue("@tokens", tokensEarned)
                cmd2.Parameters.AddWithValue("@username", My.Settings.SavedUsername)
                cmd2.ExecuteNonQuery()
            End Using

            MarkReferralSuccessful(My.Settings.SavedUsername)

            MessageBox.Show($"You earned {basePoints} points! ({multiplier}x {currentTier} bonus applied)" & vbCrLf &
                $"Total Points Earned: {totalPointsEarned}" & vbCrLf &
                $"Tokens Earned: {tokensEarned}",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Close()

        Catch ex As Exception
            MessageBox.Show("Error saving data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub MarkReferralSuccessful(currentUsername As String)

        Using conn As New SQLiteConnection(cs)
            conn.Open()

            Dim sqlCheck As String = "SELECT ReferredBy, ReferralStatus FROM UserSignUp WHERE username=@u"
            Using cmd As New SQLiteCommand(sqlCheck, conn)
                cmd.Parameters.AddWithValue("@u", currentUsername)

                Using reader = cmd.ExecuteReader()
                    If reader.Read() Then

                        Dim refCode As String = reader("ReferredBy").ToString()
                        Dim status As String = reader("ReferralStatus").ToString()

                        ' Only reward if referral exists AND still pending
                        If refCode <> "" AndAlso status = "Pending" Then

                            Dim sqlUpdateReferred As String =
                            "UPDATE UserSignUp SET 
                                ReferralStatus='Successful',
                                rewardedToken = rewardedToken + 100,
                                tokens = tokens + 100
                             WHERE username=@u"

                            Using cmd2 As New SQLiteCommand(sqlUpdateReferred, conn)
                                cmd2.Parameters.AddWithValue("@u", currentUsername)
                                cmd2.ExecuteNonQuery()
                            End Using

                            Dim sqlUpdateReferrer As String =
                            "UPDATE UserSignUp SET 
                                rewardedToken = rewardedToken + 100,
                                tokens = tokens + 100
                             WHERE ReferralCode=@ref"

                            Using cmd3 As New SQLiteCommand(sqlUpdateReferrer, conn)
                                cmd3.Parameters.AddWithValue("@ref", refCode)
                                cmd3.ExecuteNonQuery()
                            End Using
                        End If
                    End If
                End Using
            End Using
        End Using
    End Sub
End Class
