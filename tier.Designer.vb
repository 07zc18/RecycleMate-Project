<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class tier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(tier))
        PBpoints = New ProgressBar()
        lblPBpoints = New Label()
        lblNextBadge = New Label()
        lblNextB = New Label()
        btnCurrentTier = New Button()
        Panel4 = New Panel()
        btnPlatinum = New Button()
        btnGold = New Button()
        btnSilver = New Button()
        btnBronze = New Button()
        Panel3 = New Panel()
        btnExit = New Button()
        btnProfile = New Button()
        btnActivity = New Button()
        btnTier = New Button()
        btnReward = New Button()
        btnHome = New Button()
        btnBack = New Button()
        Panel7 = New Panel()
        lblFooter = New Label()
        btnFB = New Button()
        btnIG = New Button()
        Panel1 = New Panel()
        Panel8 = New Panel()
        lbl50000 = New Label()
        lbl4 = New Label()
        btn4 = New Button()
        Panel6 = New Panel()
        lbl5000 = New Label()
        lbl2 = New Label()
        btn2 = New Button()
        Panel5 = New Panel()
        lbl10000 = New Label()
        lbl3 = New Label()
        btn3 = New Button()
        Panel2 = New Panel()
        lbl1000 = New Label()
        lbl1 = New Label()
        btn1 = New Button()
        lblAchivement = New Label()
        lblTitle = New Label()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel1.SuspendLayout()
        Panel8.SuspendLayout()
        Panel6.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PBpoints
        ' 
        PBpoints.ForeColor = SystemColors.ControlText
        PBpoints.Location = New Point(103, 117)
        PBpoints.Maximum = 1000
        PBpoints.Name = "PBpoints"
        PBpoints.Size = New Size(465, 34)
        PBpoints.Style = ProgressBarStyle.Continuous
        PBpoints.TabIndex = 47
        PBpoints.Value = 70
        ' 
        ' lblPBpoints
        ' 
        lblPBpoints.AutoSize = True
        lblPBpoints.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPBpoints.Location = New Point(574, 119)
        lblPBpoints.Name = "lblPBpoints"
        lblPBpoints.Size = New Size(85, 32)
        lblPBpoints.TabIndex = 49
        lblPBpoints.Text = "Label2"
        ' 
        ' lblNextBadge
        ' 
        lblNextBadge.AutoSize = True
        lblNextBadge.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNextBadge.Location = New Point(103, 185)
        lblNextBadge.Name = "lblNextBadge"
        lblNextBadge.Size = New Size(161, 32)
        lblNextBadge.TabIndex = 50
        lblNextBadge.Text = "Next badge : "
        ' 
        ' lblNextB
        ' 
        lblNextB.AutoSize = True
        lblNextB.Font = New Font("Monotype Corsiva", 16F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lblNextB.Location = New Point(247, 181)
        lblNextB.Name = "lblNextB"
        lblNextB.Size = New Size(95, 39)
        lblNextB.TabIndex = 51
        lblNextB.Text = "Label3"
        ' 
        ' btnCurrentTier
        ' 
        btnCurrentTier.Font = New Font("SimHei", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCurrentTier.Location = New Point(1346, 108)
        btnCurrentTier.Name = "btnCurrentTier"
        btnCurrentTier.Size = New Size(418, 43)
        btnCurrentTier.TabIndex = 56
        btnCurrentTier.Text = "Current Tier: "
        btnCurrentTier.UseVisualStyleBackColor = True
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(btnPlatinum)
        Panel4.Controls.Add(btnGold)
        Panel4.Controls.Add(btnSilver)
        Panel4.Controls.Add(btnBronze)
        Panel4.Location = New Point(1322, 155)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(539, 867)
        Panel4.TabIndex = 58
        ' 
        ' btnPlatinum
        ' 
        btnPlatinum.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPlatinum.Location = New Point(24, 3)
        btnPlatinum.Name = "btnPlatinum"
        btnPlatinum.Size = New Size(489, 206)
        btnPlatinum.TabIndex = 51
        btnPlatinum.TextAlign = ContentAlignment.TopLeft
        btnPlatinum.UseVisualStyleBackColor = False
        ' 
        ' btnGold
        ' 
        btnGold.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnGold.Location = New Point(24, 215)
        btnGold.Name = "btnGold"
        btnGold.Size = New Size(489, 206)
        btnGold.TabIndex = 52
        btnGold.TextAlign = ContentAlignment.TopLeft
        btnGold.UseVisualStyleBackColor = False
        ' 
        ' btnSilver
        ' 
        btnSilver.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSilver.Location = New Point(24, 427)
        btnSilver.Name = "btnSilver"
        btnSilver.Size = New Size(489, 206)
        btnSilver.TabIndex = 53
        btnSilver.TextAlign = ContentAlignment.TopLeft
        btnSilver.UseVisualStyleBackColor = False
        ' 
        ' btnBronze
        ' 
        btnBronze.Font = New Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBronze.Location = New Point(24, 639)
        btnBronze.Name = "btnBronze"
        btnBronze.Size = New Size(489, 206)
        btnBronze.TabIndex = 54
        btnBronze.TextAlign = ContentAlignment.TopLeft
        btnBronze.UseVisualStyleBackColor = False
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
        Panel3.TabIndex = 46
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.SeaGreen
        btnExit.BackgroundImageLayout = ImageLayout.None
        btnExit.Image = CType(resources.GetObject("btnExit.Image"), Image)
        btnExit.Location = New Point(1882, -1)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(40, 40)
        btnExit.TabIndex = 64
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
        btnActivity.BackColor = Color.PaleGreen
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
        btnHome.BackColor = Color.SeaGreen
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
        ' Panel7
        ' 
        Panel7.Controls.Add(lblFooter)
        Panel7.Controls.Add(btnFB)
        Panel7.Controls.Add(btnIG)
        Panel7.Location = New Point(1, 1047)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(1898, 122)
        Panel7.TabIndex = 59
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
        ' Panel1
        ' 
        Panel1.BackColor = Color.LemonChiffon
        Panel1.Controls.Add(Panel8)
        Panel1.Controls.Add(Panel6)
        Panel1.Controls.Add(Panel5)
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(lblAchivement)
        Panel1.Location = New Point(103, 251)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1102, 739)
        Panel1.TabIndex = 60
        ' 
        ' Panel8
        ' 
        Panel8.Controls.Add(lbl50000)
        Panel8.Controls.Add(lbl4)
        Panel8.Controls.Add(btn4)
        Panel8.Location = New Point(618, 410)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(397, 268)
        Panel8.TabIndex = 8
        ' 
        ' lbl50000
        ' 
        lbl50000.AutoSize = True
        lbl50000.BackColor = Color.Honeydew
        lbl50000.Font = New Font("STFangsong", 9.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl50000.Location = New Point(219, 181)
        lbl50000.Name = "lbl50000"
        lbl50000.Size = New Size(134, 22)
        lbl50000.TabIndex = 4
        lbl50000.Text = "50000 Rpoints"
        ' 
        ' lbl4
        ' 
        lbl4.AutoSize = True
        lbl4.BackColor = Color.Honeydew
        lbl4.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl4.Location = New Point(96, 125)
        lbl4.Name = "lbl4"
        lbl4.Size = New Size(201, 28)
        lbl4.TabIndex = 2
        lbl4.Text = "Planet Protector"
        ' 
        ' btn4
        ' 
        btn4.BackColor = Color.Honeydew
        btn4.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn4.Image = CType(resources.GetObject("btn4.Image"), Image)
        btn4.ImageAlign = ContentAlignment.TopCenter
        btn4.Location = New Point(38, 14)
        btn4.Name = "btn4"
        btn4.Size = New Size(325, 230)
        btn4.TabIndex = 1
        btn4.TextAlign = ContentAlignment.MiddleLeft
        btn4.TextImageRelation = TextImageRelation.ImageAboveText
        btn4.UseVisualStyleBackColor = False
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(lbl5000)
        Panel6.Controls.Add(lbl2)
        Panel6.Controls.Add(btn2)
        Panel6.Location = New Point(618, 92)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(397, 268)
        Panel6.TabIndex = 7
        ' 
        ' lbl5000
        ' 
        lbl5000.AutoSize = True
        lbl5000.BackColor = Color.Honeydew
        lbl5000.Font = New Font("STFangsong", 9.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl5000.Location = New Point(229, 182)
        lbl5000.Name = "lbl5000"
        lbl5000.Size = New Size(124, 22)
        lbl5000.TabIndex = 4
        lbl5000.Text = "5000 Rpoints"
        ' 
        ' lbl2
        ' 
        lbl2.AutoSize = True
        lbl2.BackColor = Color.Honeydew
        lbl2.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl2.Location = New Point(99, 125)
        lbl2.Name = "lbl2"
        lbl2.Size = New Size(198, 28)
        lbl2.TabIndex = 2
        lbl2.Text = "Green Guardian"
        ' 
        ' btn2
        ' 
        btn2.BackColor = Color.Honeydew
        btn2.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn2.Image = CType(resources.GetObject("btn2.Image"), Image)
        btn2.ImageAlign = ContentAlignment.TopCenter
        btn2.Location = New Point(38, 17)
        btn2.Name = "btn2"
        btn2.Size = New Size(325, 230)
        btn2.TabIndex = 1
        btn2.TextAlign = ContentAlignment.MiddleLeft
        btn2.TextImageRelation = TextImageRelation.ImageAboveText
        btn2.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(lbl10000)
        Panel5.Controls.Add(lbl3)
        Panel5.Controls.Add(btn3)
        Panel5.Location = New Point(57, 410)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(400, 268)
        Panel5.TabIndex = 6
        ' 
        ' lbl10000
        ' 
        lbl10000.AutoSize = True
        lbl10000.BackColor = Color.Honeydew
        lbl10000.Font = New Font("STFangsong", 9.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl10000.Location = New Point(223, 181)
        lbl10000.Name = "lbl10000"
        lbl10000.Size = New Size(134, 22)
        lbl10000.TabIndex = 4
        lbl10000.Text = "10000 Rpoints"
        ' 
        ' lbl3
        ' 
        lbl3.AutoSize = True
        lbl3.BackColor = Color.Honeydew
        lbl3.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl3.Location = New Point(87, 125)
        lbl3.Name = "lbl3"
        lbl3.Size = New Size(232, 28)
        lbl3.TabIndex = 2
        lbl3.Text = "Sustainability Hero"
        ' 
        ' btn3
        ' 
        btn3.BackColor = Color.Honeydew
        btn3.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn3.Image = CType(resources.GetObject("btn3.Image"), Image)
        btn3.ImageAlign = ContentAlignment.TopCenter
        btn3.Location = New Point(36, 14)
        btn3.Name = "btn3"
        btn3.Size = New Size(325, 230)
        btn3.TabIndex = 1
        btn3.TextAlign = ContentAlignment.MiddleLeft
        btn3.TextImageRelation = TextImageRelation.ImageAboveText
        btn3.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lbl1000)
        Panel2.Controls.Add(lbl1)
        Panel2.Controls.Add(btn1)
        Panel2.Location = New Point(48, 92)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(409, 268)
        Panel2.TabIndex = 3
        ' 
        ' lbl1000
        ' 
        lbl1000.AutoSize = True
        lbl1000.BackColor = Color.Honeydew
        lbl1000.Font = New Font("STFangsong", 9.999999F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbl1000.Location = New Point(232, 182)
        lbl1000.Name = "lbl1000"
        lbl1000.Size = New Size(124, 22)
        lbl1000.TabIndex = 4
        lbl1000.Text = "1000 Rpoints"
        ' 
        ' lbl1
        ' 
        lbl1.AutoSize = True
        lbl1.BackColor = Color.Honeydew
        lbl1.Font = New Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbl1.Location = New Point(136, 125)
        lbl1.Name = "lbl1"
        lbl1.Size = New Size(144, 28)
        lbl1.TabIndex = 2
        lbl1.Text = "Eco Starter"
        ' 
        ' btn1
        ' 
        btn1.BackColor = Color.Honeydew
        btn1.Font = New Font("Segoe UI Variable Display Semib", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn1.Image = CType(resources.GetObject("btn1.Image"), Image)
        btn1.ImageAlign = ContentAlignment.TopCenter
        btn1.Location = New Point(45, 14)
        btn1.Name = "btn1"
        btn1.Size = New Size(325, 230)
        btn1.TabIndex = 1
        btn1.TextAlign = ContentAlignment.MiddleLeft
        btn1.TextImageRelation = TextImageRelation.ImageAboveText
        btn1.UseVisualStyleBackColor = False
        ' 
        ' lblAchivement
        ' 
        lblAchivement.AutoSize = True
        lblAchivement.Font = New Font("Snap ITC", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblAchivement.ForeColor = Color.DarkSlateGray
        lblAchivement.Location = New Point(22, 15)
        lblAchivement.Name = "lblAchivement"
        lblAchivement.Size = New Size(345, 51)
        lblAchivement.TabIndex = 0
        lblAchivement.Text = "Achievements"
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
        ' tier
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(1924, 1170)
        Controls.Add(Panel1)
        Controls.Add(Panel7)
        Controls.Add(Panel3)
        Controls.Add(Panel4)
        Controls.Add(btnCurrentTier)
        Controls.Add(lblNextB)
        Controls.Add(lblNextBadge)
        Controls.Add(lblPBpoints)
        Controls.Add(PBpoints)
        Name = "tier"
        Panel4.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBpoints As ProgressBar
    Friend WithEvents lblPBpoints As Label
    Friend WithEvents lblNextBadge As Label
    Friend WithEvents lblNextB As Label
    Friend WithEvents btnCurrentTier As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnPlatinum As Button
    Friend WithEvents btnGold As Button
    Friend WithEvents btnSilver As Button
    Friend WithEvents btnBronze As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnTier As Button
    Friend WithEvents btnReward As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnFB As Button
    Friend WithEvents btnIG As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lbl50000 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents btn4 As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl5000 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents btn2 As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl10000 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents btn3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl1000 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btn1 As Button
    Friend WithEvents lblAchivement As Label
    Friend WithEvents lblTitle As Label
End Class
