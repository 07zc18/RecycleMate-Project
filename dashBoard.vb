Imports System.Data.SQLite

Public Class dashBoard
    Private Sub dashBoard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecyclingData()
    End Sub

    Private Sub LoadRecyclingData()
        Dim connStr As String = "Data Source=C:\Users\USER\Documents\VB NET PROGRAMMING\M44100433_WONG ZHENG CHYI\RecycleMate Malaysia - SQL.db; Version=3;"
        Dim conn As New SQLiteConnection(connStr)

        Dim totals As New Dictionary(Of String, Integer)()

        Try
            conn.Open()
            Dim query As String = "SELECT category, SUM(quantity) AS total FROM RecycleHistory WHERE username=@username GROUP BY category"

            Using cmd As New SQLiteCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", My.Settings.SavedUsername)

                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim category As String = reader("category").ToString()
                        Dim total As Integer = Convert.ToInt32(reader("total"))
                        totals(category) = total
                    End While
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try

        UpdateLabels(totals)
    End Sub

    Private Sub UpdateLabels(totals As Dictionary(Of String, Integer))
        Try
            lblPlastic.Text = If(totals.ContainsKey("Plastic"), totals("Plastic").ToString(), "0")
            lblPaper.Text = If(totals.ContainsKey("Paper"), totals("Paper").ToString(), "0")
            lblBatteries.Text = If(totals.ContainsKey("Battery"), totals("Battery").ToString(), "0")
            lblAluminium.Text = If(totals.ContainsKey("Aluminium"), totals("Aluminium").ToString(), "0")
            lblElectronic.Text = If(totals.ContainsKey("Electronic"), totals("Electronic").ToString(), "0")
            lblMetals.Text = If(totals.ContainsKey("Metal"), totals("Metal").ToString(), "0")
            lblClothes.Text = If(totals.ContainsKey("Clothes"), totals("Clothes").ToString(), "0")
            lblGlass.Text = If(totals.ContainsKey("Glass"), totals("Glass").ToString(), "0")

            Dim total As Integer = totals.Values.Sum()
            lblTotal.Text = total.ToString()
        Catch ex As Exception
            MessageBox.Show("Error updating labels: " & ex.Message)
        End Try
    End Sub
End Class