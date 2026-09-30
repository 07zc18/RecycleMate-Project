<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pointsEx
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(pointsEx))
        Panel2 = New Panel()
        Label1 = New Label()
        dvgPanel = New Panel()
        dgvLeaderboard = New DataGridView()
        ListView1 = New ListView()
        Panel3 = New Panel()
        btnExit = New Button()
        btnProfile = New Button()
        btnActivity = New Button()
        btnTier = New Button()
        btnReward = New Button()
        btnHome = New Button()
        btnBack = New Button()
        Panel4 = New Panel()
        lblFooter = New Label()
        btnFB = New Button()
        btnIG = New Button()
        lblTitle = New Label()
        Panel1 = New Panel()
        btnPointEx = New Button()
        btnRecycleHis = New Button()
        btnInbox = New Button()
        Panel2.SuspendLayout()
        dvgPanel.SuspendLayout()
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(dvgPanel)
        Panel2.Location = New Point(1155, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(703, 891)
        Panel2.TabIndex = 56
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Snap ITC", 18F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(3, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(421, 46)
        Label1.TabIndex = 52
        Label1.Text = "Points Leaderboard"
        ' 
        ' dvgPanel
        ' 
        dvgPanel.Controls.Add(dgvLeaderboard)
        dvgPanel.Location = New Point(3, 89)
        dvgPanel.Name = "dvgPanel"
        dvgPanel.Size = New Size(617, 787)
        dvgPanel.TabIndex = 51
        ' 
        ' dgvLeaderboard
        ' 
        dgvLeaderboard.AllowUserToAddRows = False
        dgvLeaderboard.AllowUserToDeleteRows = False
        dgvLeaderboard.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvLeaderboard.Location = New Point(3, 3)
        dgvLeaderboard.Name = "dgvLeaderboard"
        dgvLeaderboard.ReadOnly = True
        dgvLeaderboard.RowHeadersWidth = 62
        dgvLeaderboard.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvLeaderboard.Size = New Size(611, 781)
        dgvLeaderboard.TabIndex = 50
        ' 
        ' ListView1
        ' 
        ListView1.Location = New Point(245, 181)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(734, 459)
        ListView1.TabIndex = 65
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblTitle)
        Panel3.Controls.Add(btnExit)
        Panel3.Controls.Add(btnProfile)
        Panel3.Controls.Add(btnActivity)
        Panel3.Controls.Add(btnTier)
        Panel3.Controls.Add(btnReward)
        Panel3.Controls.Add(btnHome)
        Panel3.Controls.Add(btnBack)
        Panel3.Location = New Point(0, 1)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1925, 75)
        Panel3.TabIndex = 66
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SeaGreen
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(1882, -1)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 67
        btnExit.TextImageRelation = TextImageRelation.TextBeforeImage
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnProfile
        ' 
        btnProfile.BackColor = Color.PaleGreen
        btnProfile.BackgroundImageLayout = ImageLayout.None
        btnProfile.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfile.Image = CType(resources.GetObject("btnProfile.Image"), Image)
        btnProfile.Location = New Point(1525, -1)
        btnProfile.Name = "btnProfile"
        btnProfile.Size = New Size(125, 50)
        btnProfile.TabIndex = 15
        btnProfile.Text = "Profile"
        btnProfile.TextImageRelation = TextImageRelation.TextBeforeImage
        btnProfile.UseVisualStyleBackColor = False
        ' 
        ' btnActivity
        ' 
        btnActivity.BackColor = Color.SeaGreen
        btnActivity.BackgroundImageLayout = ImageLayout.None
        btnActivity.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnActivity.Image = CType(resources.GetObject("btnActivity.Image"), Image)
        btnActivity.Location = New Point(1394, -1)
        btnActivity.Name = "btnActivity"
        btnActivity.Size = New Size(125, 50)
        btnActivity.TabIndex = 14
        btnActivity.Text = "Activity"
        btnActivity.TextImageRelation = TextImageRelation.TextBeforeImage
        btnActivity.UseVisualStyleBackColor = False
        ' 
        ' btnTier
        ' 
        btnTier.BackColor = Color.PaleGreen
        btnTier.BackgroundImageLayout = ImageLayout.None
        btnTier.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnTier.Image = CType(resources.GetObject("btnTier.Image"), Image)
        btnTier.Location = New Point(1263, -1)
        btnTier.Name = "btnTier"
        btnTier.Size = New Size(125, 50)
        btnTier.TabIndex = 13
        btnTier.Text = "Tier"
        btnTier.TextImageRelation = TextImageRelation.TextBeforeImage
        btnTier.UseVisualStyleBackColor = False
        ' 
        ' btnReward
        ' 
        btnReward.BackColor = Color.PaleGreen
        btnReward.BackgroundImageLayout = ImageLayout.None
        btnReward.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnReward.Image = CType(resources.GetObject("btnReward.Image"), Image)
        btnReward.Location = New Point(1132, -1)
        btnReward.Name = "btnReward"
        btnReward.Size = New Size(125, 50)
        btnReward.TabIndex = 12
        btnReward.Text = "Rewards"
        btnReward.TextImageRelation = TextImageRelation.TextBeforeImage
        btnReward.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.BackColor = Color.PaleGreen
        btnHome.BackgroundImageLayout = ImageLayout.None
        btnHome.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnHome.Image = CType(resources.GetObject("btnHome.Image"), Image)
        btnHome.Location = New Point(1001, -1)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(125, 50)
        btnHome.TabIndex = 2
        btnHome.Text = "Home"
        btnHome.TextImageRelation = TextImageRelation.TextBeforeImage
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.SeaGreen
        btnBack.Image = CType(resources.GetObject("btnBack.Image"), Image)
        btnBack.Location = New Point(0, 0)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(50, 50)
        btnBack.TabIndex = 0
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(lblFooter)
        Panel4.Controls.Add(btnFB)
        Panel4.Controls.Add(btnIG)
        Panel4.Location = New Point(1, 1047)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1898, 122)
        Panel4.TabIndex = 46
        ' 
        ' lblFooter
        ' 
        lblFooter.AutoSize = True
        lblFooter.Font = New Font("Yu Gothic UI", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblFooter.Location = New Point(988, 44)
        lblFooter.Name = "lblFooter"
        lblFooter.Size = New Size(897, 54)
        lblFooter.TabIndex = 45
        lblFooter.Text = "🌱 Keep Recycling • Earn Points • Save Earth 🌎"
        ' 
        ' btnFB
        ' 
        btnFB.Font = New Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnFB.Image = CType(resources.GetObject("btnFB.Image"), Image)
        btnFB.Location = New Point(520, 22)
        btnFB.Name = "btnFB"
        btnFB.Size = New Size(422, 87)
        btnFB.TabIndex = 44
        btnFB.Text = "@RecycleMateMalaysia"
        btnFB.TextImageRelation = TextImageRelation.ImageBeforeText
        btnFB.UseVisualStyleBackColor = True
        ' 
        ' btnIG
        ' 
        btnIG.Font = New Font("Tahoma", 16F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIG.Image = CType(resources.GetObject("btnIG.Image"), Image)
        btnIG.Location = New Point(32, 22)
        btnIG.Name = "btnIG"
        btnIG.Size = New Size(423, 87)
        btnIG.TabIndex = 43
        btnIG.Text = "@RecycleMateMalaysia"
        btnIG.TextImageRelation = TextImageRelation.ImageBeforeText
        btnIG.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), Image)
        lblTitle.Location = New Point(151, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(753, 91)
        lblTitle.TabIndex = 68
        lblTitle.Text = "RECYCLEMATE MALAYSIA"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnPointEx)
        Panel1.Controls.Add(btnRecycleHis)
        Panel1.Controls.Add(btnInbox)
        Panel1.Location = New Point(0, 167)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(206, 261)
        Panel1.TabIndex = 67
        ' 
        ' btnPointEx
        ' 
        btnPointEx.BackColor = Color.Turquoise
        btnPointEx.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnPointEx.Image = CType(resources.GetObject("btnPointEx.Image"), Image)
        btnPointEx.Location = New Point(0, 93)
        btnPointEx.Name = "btnPointEx"
        btnPointEx.Size = New Size(192, 73)
        btnPointEx.TabIndex = 47
        btnPointEx.Text = "Token Exchange History"
        btnPointEx.TextImageRelation = TextImageRelation.TextBeforeImage
        btnPointEx.UseVisualStyleBackColor = False
        ' 
        ' btnRecycleHis
        ' 
        btnRecycleHis.BackColor = Color.Lavender
        btnRecycleHis.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecycleHis.Image = CType(resources.GetObject("btnRecycleHis.Image"), Image)
        btnRecycleHis.Location = New Point(0, 14)
        btnRecycleHis.Name = "btnRecycleHis"
        btnRecycleHis.Size = New Size(192, 73)
        btnRecycleHis.TabIndex = 46
        btnRecycleHis.Text = "Recycle History"
        btnRecycleHis.TextImageRelation = TextImageRelation.TextBeforeImage
        btnRecycleHis.UseVisualStyleBackColor = False
        ' 
        ' btnInbox
        ' 
        btnInbox.BackColor = Color.Pink
        btnInbox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInbox.Image = CType(resources.GetObject("btnInbox.Image"), Image)
        btnInbox.Location = New Point(0, 172)
        btnInbox.Name = "btnInbox"
        btnInbox.Size = New Size(192, 73)
        btnInbox.TabIndex = 48
        btnInbox.Text = "Inbox"
        btnInbox.TextImageRelation = TextImageRelation.TextBeforeImage
        btnInbox.UseVisualStyleBackColor = False
        ' 
        ' pointsEx
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(1924, 1170)
        Controls.Add(Panel1)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(ListView1)
        Controls.Add(Panel2)
        Name = "pointsEx"
        Text = "Form4"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        dvgPanel.ResumeLayout(False)
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgPanel As Panel
    Friend WithEvents dgvLeaderboard As DataGridView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnTier As Button
    Friend WithEvents btnReward As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnFB As Button
    Friend WithEvents btnIG As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPointEx As Button
    Friend WithEvents btnRecycleHis As Button
    Friend WithEvents btnInbox As Button
End Class
