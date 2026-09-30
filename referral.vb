Imports System.Data.SQLite

Public Class referral

    Private cs As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"

    Private Sub refferalProgram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgv.ColumnCount = 3
        dgv.Columns(0).Name = "Name"
        dgv.Columns(1).Name = "Status"
        dgv.Columns(2).Name = "Rewarded Token"

        dgv.Columns(0).Width = 150
        dgv.Columns(1).Width = 150
        dgv.Columns(2).Width = 225
        dgv.BorderStyle = BorderStyle.FixedSingle

        dgv.Columns("Name").HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.Columns("Status").HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.Columns("Rewarded Token").HeaderCell.Style.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        If String.IsNullOrEmpty(My.Settings.SavedUsername) Then
            lblReferralCode.Text = "Login to see your referral code"
            lblReferralCode.Enabled = False
            btnCopy.Enabled = False
        Else
            LoadReferralCode(My.Settings.SavedUsername)
            btnCopy.Enabled = True

            LoadReferralFriends(My.Settings.SavedUsername)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgv.CellFormatting
        If dgv.Columns(e.ColumnIndex).Name = "Status" AndAlso e.Value IsNot Nothing Then
            Dim status As String = e.Value.ToString().ToLower()
            If status = "successful" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
            ElseIf status = "pending" Then
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Khaki
            Else
                dgv.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.White
                dgv.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub

    '  Copy Referral Code
    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        If Not String.IsNullOrEmpty(lblReferralCode.Text) AndAlso lblReferralCode.Enabled Then
            Clipboard.SetText(lblReferralCode.Text)
            MessageBox.Show("Referral code copied!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub LoadReferralCode(username As String)
        Using conn As New SQLiteConnection(cs)
            conn.Open()
            Dim sql As String = "SELECT ReferralCode FROM UserSignUp WHERE username=@username"
            Using cmd As New SQLiteCommand(sql, conn)
                cmd.Parameters.AddWithValue("@username", username)
                Dim code = cmd.ExecuteScalar()
                If code IsNot Nothing Then
                    lblReferralCode.Text = code.ToString()
                End If
            End Using
        End Using
    End Sub

    Private Sub LoadReferralFriends(username As String)
        dgv.Rows.Clear()

        Dim referralCode As String = ""
        Using conn As New SQLiteConnection(cs)
            conn.Open()
            Dim sqlCode As String = "SELECT ReferralCode FROM UserSignUp WHERE username=@username"
            Using cmd As New SQLiteCommand(sqlCode, conn)
                cmd.Parameters.AddWithValue("@username", username)
                Dim code = cmd.ExecuteScalar()
                If code IsNot Nothing Then referralCode = code.ToString()
            End Using

            If referralCode <> "" Then
                Dim sql As String = "SELECT Username, ReferralStatus, rewardedToken FROM UserSignUp WHERE ReferredBy=@refcode"
                Using cmd As New SQLiteCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@refcode", referralCode)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            Dim user As String = reader("Username").ToString()
                            Dim status As String = reader("ReferralStatus").ToString()
                            Dim token As String = reader("rewardedToken").ToString()
                            dgv.Rows.Add(user, status, token)
                        End While
                    End Using
                End Using
            End If
        End Using
    End Sub
End Class
