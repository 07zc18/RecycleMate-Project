<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inbox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inbox))
        Panel2 = New Panel()
        Label1 = New Label()
        dvgPanel = New Panel()
        dgvLeaderboard = New DataGridView()
        Panel1 = New Panel()
        btnProfile = New Button()
        btnActivity = New Button()
        btnTier = New Button()
        btnReward = New Button()
        btnHome = New Button()
        btnBack = New Button()
        btnExit = New Button()
        lblTitle = New Label()
        mainPanel = New FlowLayoutPanel()
        P5 = New Panel()
        btnClick5 = New Button()
        lblTime5 = New Label()
        noti5 = New Label()
        PB5 = New PictureBox()
        P4 = New Panel()
        btnClick4 = New Button()
        lblTime4 = New Label()
        noti4 = New Label()
        PB4 = New PictureBox()
        P3 = New Panel()
        btnClick3 = New Button()
        lblTime3 = New Label()
        noti3 = New Label()
        PB3 = New PictureBox()
        P2 = New Panel()
        btnClick2 = New Button()
        lblTime2 = New Label()
        noti2 = New Label()
        PB2 = New PictureBox()
        P1 = New Panel()
        btnClick = New Button()
        lblTime1 = New Label()
        noti1 = New Label()
        PB1 = New PictureBox()
        Panel4 = New Panel()
        btnPointEx = New Button()
        btnRecycleHis = New Button()
        btnInbox = New Button()
        Panel3 = New Panel()
        lblFooter = New Label()
        btnFB = New Button()
        btnIG = New Button()
        Panel2.SuspendLayout()
        dvgPanel.SuspendLayout()
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        mainPanel.SuspendLayout()
        P5.SuspendLayout()
        CType(PB5, ComponentModel.ISupportInitialize).BeginInit()
        P4.SuspendLayout()
        CType(PB4, ComponentModel.ISupportInitialize).BeginInit()
        P3.SuspendLayout()
        CType(PB3, ComponentModel.ISupportInitialize).BeginInit()
        P2.SuspendLayout()
        CType(PB2, ComponentModel.ISupportInitialize).BeginInit()
        P1.SuspendLayout()
        CType(PB1, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(dvgPanel)
        Panel2.Location = New Point(1155, 128)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(703, 891)
        Panel2.TabIndex = 60
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
        ' Panel1
        ' 
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnActivity)
        Panel1.Controls.Add(btnTier)
        Panel1.Controls.Add(btnReward)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnExit)
        Panel1.Location = New Point(0, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1925, 75)
        Panel1.TabIndex = 64
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
        ' btnExit
        ' 
        btnExit.BackColor = Color.SeaGreen
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(1882, -1)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 6
        btnExit.TextImageRelation = TextImageRelation.TextBeforeImage
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Image = CType(resources.GetObject("lblTitle.Image"), Image)
        lblTitle.Location = New Point(151, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(753, 91)
        lblTitle.TabIndex = 66
        lblTitle.Text = "RECYCLEMATE MALAYSIA"
        ' 
        ' mainPanel
        ' 
        mainPanel.AutoScroll = True
        mainPanel.Controls.Add(P5)
        mainPanel.Controls.Add(P4)
        mainPanel.Controls.Add(P3)
        mainPanel.Controls.Add(P2)
        mainPanel.Controls.Add(P1)
        mainPanel.FlowDirection = FlowDirection.TopDown
        mainPanel.Location = New Point(246, 181)
        mainPanel.Name = "mainPanel"
        mainPanel.Size = New Size(841, 759)
        mainPanel.TabIndex = 65
        mainPanel.WrapContents = False
        ' 
        ' P5
        ' 
        P5.Controls.Add(btnClick5)
        P5.Controls.Add(lblTime5)
        P5.Controls.Add(noti5)
        P5.Controls.Add(PB5)
        P5.Location = New Point(3, 3)
        P5.Name = "P5"
        P5.Size = New Size(831, 140)
        P5.TabIndex = 3
        ' 
        ' btnClick5
        ' 
        btnClick5.BackColor = Color.LightGreen
        btnClick5.Font = New Font("Segoe UI", 6F)
        btnClick5.Location = New Point(84, 94)
        btnClick5.Name = "btnClick5"
        btnClick5.Size = New Size(91, 36)
        btnClick5.TabIndex = 7
        btnClick5.Text = "Click Me !"
        btnClick5.UseVisualStyleBackColor = False
        ' 
        ' lblTime5
        ' 
        lblTime5.AutoSize = True
        lblTime5.Font = New Font("MS PGothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime5.Location = New Point(634, 103)
        lblTime5.MaximumSize = New Size(750, 0)
        lblTime5.Name = "lblTime5"
        lblTime5.Size = New Size(60, 20)
        lblTime5.TabIndex = 2
        lblTime5.Text = "Time5"
        ' 
        ' noti5
        ' 
        noti5.AutoSize = True
        noti5.Font = New Font("Mongolian Baiti", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        noti5.Location = New Point(77, 30)
        noti5.MaximumSize = New Size(750, 0)
        noti5.Name = "noti5"
        noti5.Size = New Size(746, 48)
        noti5.TabIndex = 1
        noti5.Text = """Join the fun! Take part in our Monthly Recycle Challenge and earn extra points and tokens for your eco-efforts!"""
        ' 
        ' PB5
        ' 
        PB5.Image = CType(resources.GetObject("PB5.Image"), Image)
        PB5.Location = New Point(19, 31)
        PB5.Name = "PB5"
        PB5.Size = New Size(52, 53)
        PB5.TabIndex = 0
        PB5.TabStop = False
        ' 
        ' P4
        ' 
        P4.Controls.Add(btnClick4)
        P4.Controls.Add(lblTime4)
        P4.Controls.Add(noti4)
        P4.Controls.Add(PB4)
        P4.Location = New Point(3, 149)
        P4.Name = "P4"
        P4.Size = New Size(831, 140)
        P4.TabIndex = 3
        ' 
        ' btnClick4
        ' 
        btnClick4.BackColor = Color.LightGreen
        btnClick4.Font = New Font("Segoe UI", 6F)
        btnClick4.Location = New Point(84, 94)
        btnClick4.Name = "btnClick4"
        btnClick4.Size = New Size(91, 36)
        btnClick4.TabIndex = 6
        btnClick4.Text = "Click Me !"
        btnClick4.UseVisualStyleBackColor = False
        ' 
        ' lblTime4
        ' 
        lblTime4.AutoSize = True
        lblTime4.Font = New Font("MS PGothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime4.Location = New Point(634, 110)
        lblTime4.MaximumSize = New Size(750, 0)
        lblTime4.Name = "lblTime4"
        lblTime4.Size = New Size(60, 20)
        lblTime4.TabIndex = 2
        lblTime4.Text = "Time4"
        ' 
        ' noti4
        ' 
        noti4.AutoSize = True
        noti4.Font = New Font("Mongolian Baiti", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        noti4.Location = New Point(77, 30)
        noti4.MaximumSize = New Size(750, 0)
        noti4.Name = "noti4"
        noti4.Size = New Size(741, 48)
        noti4.TabIndex = 1
        noti4.Text = "Earn points and tokens as you recycle, then redeem them for rewards and special perks!"""
        ' 
        ' PB4
        ' 
        PB4.Image = CType(resources.GetObject("PB4.Image"), Image)
        PB4.Location = New Point(19, 31)
        PB4.Name = "PB4"
        PB4.Size = New Size(52, 53)
        PB4.TabIndex = 0
        PB4.TabStop = False
        ' 
        ' P3
        ' 
        P3.Controls.Add(btnClick3)
        P3.Controls.Add(lblTime3)
        P3.Controls.Add(noti3)
        P3.Controls.Add(PB3)
        P3.Location = New Point(3, 295)
        P3.Name = "P3"
        P3.Size = New Size(831, 140)
        P3.TabIndex = 3
        ' 
        ' btnClick3
        ' 
        btnClick3.BackColor = Color.LightGreen
        btnClick3.Font = New Font("Segoe UI", 6F)
        btnClick3.Location = New Point(84, 93)
        btnClick3.Name = "btnClick3"
        btnClick3.Size = New Size(91, 36)
        btnClick3.TabIndex = 5
        btnClick3.Text = "Click Me !"
        btnClick3.UseVisualStyleBackColor = False
        ' 
        ' lblTime3
        ' 
        lblTime3.AutoSize = True
        lblTime3.Font = New Font("MS PGothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime3.Location = New Point(634, 109)
        lblTime3.MaximumSize = New Size(750, 0)
        lblTime3.Name = "lblTime3"
        lblTime3.Size = New Size(60, 20)
        lblTime3.TabIndex = 2
        lblTime3.Text = "Time3"
        ' 
        ' noti3
        ' 
        noti3.AutoSize = True
        noti3.Font = New Font("Mongolian Baiti", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        noti3.Location = New Point(77, 30)
        noti3.MaximumSize = New Size(750, 0)
        noti3.Name = "noti3"
        noti3.Size = New Size(651, 48)
        noti3.TabIndex = 1
        noti3.Text = """Invite your friends to RecycleMate and get 100 tokens for each successful referral!"""
        ' 
        ' PB3
        ' 
        PB3.Image = CType(resources.GetObject("PB3.Image"), Image)
        PB3.Location = New Point(19, 31)
        PB3.Name = "PB3"
        PB3.Size = New Size(52, 53)
        PB3.TabIndex = 0
        PB3.TabStop = False
        ' 
        ' P2
        ' 
        P2.Controls.Add(btnClick2)
        P2.Controls.Add(lblTime2)
        P2.Controls.Add(noti2)
        P2.Controls.Add(PB2)
        P2.Location = New Point(3, 441)
        P2.Name = "P2"
        P2.Size = New Size(831, 140)
        P2.TabIndex = 3
        ' 
        ' btnClick2
        ' 
        btnClick2.BackColor = Color.LightGreen
        btnClick2.Font = New Font("Segoe UI", 6F)
        btnClick2.Location = New Point(84, 92)
        btnClick2.Name = "btnClick2"
        btnClick2.Size = New Size(91, 36)
        btnClick2.TabIndex = 4
        btnClick2.Text = "Click Me !"
        btnClick2.UseVisualStyleBackColor = False
        ' 
        ' lblTime2
        ' 
        lblTime2.AutoSize = True
        lblTime2.Font = New Font("MS PGothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime2.Location = New Point(634, 109)
        lblTime2.MaximumSize = New Size(750, 0)
        lblTime2.Name = "lblTime2"
        lblTime2.Size = New Size(60, 20)
        lblTime2.TabIndex = 2
        lblTime2.Text = "Time2"
        ' 
        ' noti2
        ' 
        noti2.AutoSize = True
        noti2.Font = New Font("Mongolian Baiti", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        noti2.Location = New Point(77, 30)
        noti2.MaximumSize = New Size(750, 0)
        noti2.Name = "noti2"
        noti2.Size = New Size(713, 48)
        noti2.TabIndex = 1
        noti2.Text = """Hooray! Your account is now active. Get daily recycle reminders and helpful email notifications to stay on track!"""
        ' 
        ' PB2
        ' 
        PB2.Image = CType(resources.GetObject("PB2.Image"), Image)
        PB2.Location = New Point(19, 31)
        PB2.Name = "PB2"
        PB2.Size = New Size(52, 53)
        PB2.TabIndex = 0
        PB2.TabStop = False
        ' 
        ' P1
        ' 
        P1.Controls.Add(btnClick)
        P1.Controls.Add(lblTime1)
        P1.Controls.Add(noti1)
        P1.Controls.Add(PB1)
        P1.Location = New Point(3, 587)
        P1.Name = "P1"
        P1.Size = New Size(831, 140)
        P1.TabIndex = 4
        ' 
        ' btnClick
        ' 
        btnClick.BackColor = Color.LightGreen
        btnClick.Font = New Font("Segoe UI", 6F)
        btnClick.Location = New Point(84, 90)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(91, 36)
        btnClick.TabIndex = 3
        btnClick.Text = "Click Me !"
        btnClick.UseVisualStyleBackColor = False
        ' 
        ' lblTime1
        ' 
        lblTime1.AutoSize = True
        lblTime1.Font = New Font("MS PGothic", 10F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblTime1.Location = New Point(634, 106)
        lblTime1.MaximumSize = New Size(750, 0)
        lblTime1.Name = "lblTime1"
        lblTime1.Size = New Size(60, 20)
        lblTime1.TabIndex = 2
        lblTime1.Text = "Time1"
        ' 
        ' noti1
        ' 
        noti1.AutoSize = True
        noti1.Font = New Font("Mongolian Baiti", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        noti1.Location = New Point(77, 30)
        noti1.MaximumSize = New Size(750, 0)
        noti1.Name = "noti1"
        noti1.Size = New Size(724, 48)
        noti1.TabIndex = 1
        noti1.Text = """Welcome to RecycleMate Malaysia ! Start recycling today and make a positive impact on the planet. Click to get started!"""
        ' 
        ' PB1
        ' 
        PB1.Image = CType(resources.GetObject("PB1.Image"), Image)
        PB1.Location = New Point(19, 31)
        PB1.Name = "PB1"
        PB1.Size = New Size(52, 53)
        PB1.TabIndex = 0
        PB1.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnPointEx)
        Panel4.Controls.Add(btnRecycleHis)
        Panel4.Controls.Add(btnInbox)
        Panel4.Location = New Point(0, 167)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(206, 261)
        Panel4.TabIndex = 59
        ' 
        ' btnPointEx
        ' 
        btnPointEx.BackColor = Color.PaleTurquoise
        btnPointEx.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnPointEx.Image = CType(resources.GetObject("btnPointEx.Image"), Image)
        btnPointEx.ImeMode = ImeMode.NoControl
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
        btnRecycleHis.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnRecycleHis.Image = CType(resources.GetObject("btnRecycleHis.Image"), Image)
        btnRecycleHis.ImeMode = ImeMode.NoControl
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
        btnInbox.BackColor = Color.PaleVioletRed
        btnInbox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnInbox.Image = CType(resources.GetObject("btnInbox.Image"), Image)
        btnInbox.ImeMode = ImeMode.NoControl
        btnInbox.Location = New Point(0, 172)
        btnInbox.Name = "btnInbox"
        btnInbox.Size = New Size(192, 73)
        btnInbox.TabIndex = 48
        btnInbox.Text = "Inbox"
        btnInbox.TextImageRelation = TextImageRelation.TextBeforeImage
        btnInbox.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblFooter)
        Panel3.Controls.Add(btnFB)
        Panel3.Controls.Add(btnIG)
        Panel3.Location = New Point(1, 1047)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1898, 122)
        Panel3.TabIndex = 46
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
        ' Inbox
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(1924, 1170)
        Controls.Add(mainPanel)
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Name = "Inbox"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        dvgPanel.ResumeLayout(False)
        CType(dgvLeaderboard, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        mainPanel.ResumeLayout(False)
        P5.ResumeLayout(False)
        P5.PerformLayout()
        CType(PB5, ComponentModel.ISupportInitialize).EndInit()
        P4.ResumeLayout(False)
        P4.PerformLayout()
        CType(PB4, ComponentModel.ISupportInitialize).EndInit()
        P3.ResumeLayout(False)
        P3.PerformLayout()
        CType(PB3, ComponentModel.ISupportInitialize).EndInit()
        P2.ResumeLayout(False)
        P2.PerformLayout()
        CType(PB2, ComponentModel.ISupportInitialize).EndInit()
        P1.ResumeLayout(False)
        P1.PerformLayout()
        CType(PB1, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents dvgPanel As Panel
    Friend WithEvents dgvLeaderboard As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnTier As Button
    Friend WithEvents btnReward As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents mainPanel As FlowLayoutPanel
    Friend WithEvents P5 As Panel
    Friend WithEvents btnClick5 As Button
    Friend WithEvents lblTime5 As Label
    Friend WithEvents noti5 As Label
    Friend WithEvents PB5 As PictureBox
    Friend WithEvents P4 As Panel
    Friend WithEvents btnClick4 As Button
    Friend WithEvents lblTime4 As Label
    Friend WithEvents noti4 As Label
    Friend WithEvents PB4 As PictureBox
    Friend WithEvents P3 As Panel
    Friend WithEvents btnClick3 As Button
    Friend WithEvents lblTime3 As Label
    Friend WithEvents noti3 As Label
    Friend WithEvents PB3 As PictureBox
    Friend WithEvents P2 As Panel
    Friend WithEvents btnClick2 As Button
    Friend WithEvents lblTime2 As Label
    Friend WithEvents noti2 As Label
    Friend WithEvents PB2 As PictureBox
    Friend WithEvents P1 As Panel
    Friend WithEvents btnClick As Button
    Friend WithEvents lblTime1 As Label
    Friend WithEvents noti1 As Label
    Friend WithEvents PB1 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPointEx As Button
    Friend WithEvents btnRecycleHis As Button
    Friend WithEvents btnInbox As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnFB As Button
    Friend WithEvents btnIG As Button
End Class
