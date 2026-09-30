<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recycleHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recycleHistory))
        Panel2 = New Panel()
        Label1 = New Label()
        dvgPanel = New Panel()
        dgvLeaderboard = New DataGridView()
        ListView1 = New ListView()
        txtSearchC = New TextBox()
        btnSearchC = New Button()
        btnSortByCategory = New Button()
        btnSortByDate = New Button()
        btnSortByLocation = New Button()
        btnSortByWeight = New Button()
        btnSortByQuantity = New Button()
        txtSearchL = New TextBox()
        btnSearchL = New Button()
        btnRefresh = New Button()
        dgvRecycle = New DataGridView()
        Panel1 = New Panel()
        btnExit = New Button()
        btnProfile = New Button()
        btnActivity = New Button()
        btnTier = New Button()
        btnReward = New Button()
        btnHome = New Button()
        btnBack = New Button()
        Panel3 = New Panel()
        btnPointEx = New Button()
        btnRecycleHis = New Button()
        btnInbox = New Button()
        lblTitle = New Label()
        Panel6 = New Panel()
        lblFooter = New Label()
        btnFB = New Button()
        btnIG = New Button()
        Panel2.SuspendLayout()
        dvgPanel.SuspendLayout()
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvRecycle, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(dvgPanel)
        Panel2.Location = New Point(1155, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(703, 891)
        Panel2.TabIndex = 57
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
        ListView1.Location = New Point(276, 542)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(842, 459)
        ListView1.TabIndex = 64
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' txtSearchC
        ' 
        txtSearchC.Location = New Point(22, 542)
        txtSearchC.Name = "txtSearchC"
        txtSearchC.PlaceholderText = "Search by Category"
        txtSearchC.Size = New Size(210, 31)
        txtSearchC.TabIndex = 66
        ' 
        ' btnSearchC
        ' 
        btnSearchC.Location = New Point(120, 595)
        btnSearchC.Name = "btnSearchC"
        btnSearchC.Size = New Size(112, 34)
        btnSearchC.TabIndex = 67
        btnSearchC.Text = "Search"
        btnSearchC.UseVisualStyleBackColor = True
        ' 
        ' btnSortByCategory
        ' 
        btnSortByCategory.Font = New Font("Segoe UI", 8F)
        btnSortByCategory.Location = New Point(276, 485)
        btnSortByCategory.Name = "btnSortByCategory"
        btnSortByCategory.Size = New Size(140, 34)
        btnSortByCategory.TabIndex = 68
        btnSortByCategory.Text = "Sort By Category"
        btnSortByCategory.UseVisualStyleBackColor = True
        ' 
        ' btnSortByDate
        ' 
        btnSortByDate.Font = New Font("Segoe UI", 8F)
        btnSortByDate.Location = New Point(422, 485)
        btnSortByDate.Name = "btnSortByDate"
        btnSortByDate.Size = New Size(140, 34)
        btnSortByDate.TabIndex = 69
        btnSortByDate.Text = "Sort By Date"
        btnSortByDate.UseVisualStyleBackColor = True
        ' 
        ' btnSortByLocation
        ' 
        btnSortByLocation.Font = New Font("Segoe UI", 8F)
        btnSortByLocation.Location = New Point(568, 485)
        btnSortByLocation.Name = "btnSortByLocation"
        btnSortByLocation.Size = New Size(140, 34)
        btnSortByLocation.TabIndex = 70
        btnSortByLocation.Text = "Sort By Location"
        btnSortByLocation.UseVisualStyleBackColor = True
        ' 
        ' btnSortByWeight
        ' 
        btnSortByWeight.Font = New Font("Segoe UI", 8F)
        btnSortByWeight.Location = New Point(714, 485)
        btnSortByWeight.Name = "btnSortByWeight"
        btnSortByWeight.Size = New Size(140, 34)
        btnSortByWeight.TabIndex = 71
        btnSortByWeight.Text = "Sort By Weight"
        btnSortByWeight.UseVisualStyleBackColor = True
        ' 
        ' btnSortByQuantity
        ' 
        btnSortByQuantity.Font = New Font("Segoe UI", 8F)
        btnSortByQuantity.Location = New Point(860, 485)
        btnSortByQuantity.Name = "btnSortByQuantity"
        btnSortByQuantity.Size = New Size(140, 34)
        btnSortByQuantity.TabIndex = 72
        btnSortByQuantity.Text = "Sort By Quantity"
        btnSortByQuantity.UseVisualStyleBackColor = True
        ' 
        ' txtSearchL
        ' 
        txtSearchL.Location = New Point(22, 647)
        txtSearchL.Name = "txtSearchL"
        txtSearchL.PlaceholderText = "Search by Location"
        txtSearchL.Size = New Size(210, 31)
        txtSearchL.TabIndex = 73
        ' 
        ' btnSearchL
        ' 
        btnSearchL.Location = New Point(120, 698)
        btnSearchL.Name = "btnSearchL"
        btnSearchL.Size = New Size(112, 34)
        btnSearchL.TabIndex = 74
        btnSearchL.Text = "Search"
        btnSearchL.UseVisualStyleBackColor = True
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Location = New Point(1006, 485)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 75
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = True
        ' 
        ' dgvRecycle
        ' 
        dgvRecycle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecycle.Location = New Point(276, 181)
        dgvRecycle.Name = "dgvRecycle"
        dgvRecycle.RowHeadersWidth = 62
        dgvRecycle.Size = New Size(842, 271)
        dgvRecycle.TabIndex = 76
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnActivity)
        Panel1.Controls.Add(btnTier)
        Panel1.Controls.Add(btnReward)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnBack)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1925, 75)
        Panel1.TabIndex = 77
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SeaGreen
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(1882, -1)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 63
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
        ' Panel3
        ' 
        Panel3.Controls.Add(btnPointEx)
        Panel3.Controls.Add(btnRecycleHis)
        Panel3.Controls.Add(btnInbox)
        Panel3.Location = New Point(0, 167)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(206, 261)
        Panel3.TabIndex = 78
        ' 
        ' btnPointEx
        ' 
        btnPointEx.BackColor = Color.PaleTurquoise
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
        btnRecycleHis.BackColor = Color.Plum
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), Image)
        lblTitle.Location = New Point(151, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(753, 91)
        lblTitle.TabIndex = 65
        lblTitle.Text = "RECYCLEMATE MALAYSIA"
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(lblFooter)
        Panel6.Controls.Add(btnFB)
        Panel6.Controls.Add(btnIG)
        Panel6.Location = New Point(1, 1047)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1898, 122)
        Panel6.TabIndex = 79
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
        ' recycleHistory
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(1924, 1170)
        Controls.Add(Panel6)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(dgvRecycle)
        Controls.Add(btnRefresh)
        Controls.Add(btnSortByCategory)
        Controls.Add(btnSortByQuantity)
        Controls.Add(btnSortByWeight)
        Controls.Add(btnSortByLocation)
        Controls.Add(btnSortByDate)
        Controls.Add(btnSearchL)
        Controls.Add(txtSearchL)
        Controls.Add(btnSearchC)
        Controls.Add(txtSearchC)
        Controls.Add(ListView1)
        Controls.Add(Panel2)
        Name = "recycleHistory"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        dvgPanel.ResumeLayout(False)
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvRecycle, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgPanel As Panel
    Friend WithEvents dgvLeaderboard As DataGridView
    Friend WithEvents ListView1 As ListView
    Friend WithEvents txtSearchC As TextBox
    Friend WithEvents btnSearchC As Button
    Friend WithEvents btnSortByCategory As Button
    Friend WithEvents btnSortByDate As Button
    Friend WithEvents btnSortByLocation As Button
    Friend WithEvents btnSortByWeight As Button
    Friend WithEvents btnSortByQuantity As Button
    Friend WithEvents txtSearchL As TextBox
    Friend WithEvents btnSearchL As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvRecycle As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnTier As Button
    Friend WithEvents btnReward As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnPointEx As Button
    Friend WithEvents btnRecycleHis As Button
    Friend WithEvents btnInbox As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnFB As Button
    Friend WithEvents btnIG As Button
End Class
