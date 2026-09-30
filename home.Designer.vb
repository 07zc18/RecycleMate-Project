<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnBack = New Button()
        Panel1 = New Panel()
        btnProfile = New Button()
        btnActivity = New Button()
        btnTier = New Button()
        btnReward = New Button()
        btnHome = New Button()
        lblTitle = New Label()
        btnExit = New Button()
        lblWelcome = New Label()
        ecoTips = New Label()
        lblnews = New Label()
        news1 = New Label()
        news2 = New Label()
        news3 = New Label()
        news4 = New Label()
        recycleThings = New Label()
        Panel2 = New Panel()
        glasses = New Button()
        aluminium = New Button()
        clothes = New Button()
        papers = New Button()
        electronicDevices = New Button()
        battery = New Button()
        plasticBottles = New Button()
        mixedMetals = New Button()
        lblLocation = New Label()
        Panel3 = New Panel()
        lblFooter = New Label()
        btnFB = New Button()
        btnIG = New Button()
        ListView1 = New ListView()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
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
        ' Panel1
        ' 
        Panel1.Controls.Add(btnProfile)
        Panel1.Controls.Add(btnActivity)
        Panel1.Controls.Add(btnTier)
        Panel1.Controls.Add(btnReward)
        Panel1.Controls.Add(btnHome)
        Panel1.Controls.Add(lblTitle)
        Panel1.Controls.Add(btnBack)
        Panel1.Controls.Add(btnExit)
        Panel1.Location = New Point(1, 1)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1925, 75)
        Panel1.TabIndex = 1
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
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe Print", 26F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(151, 8)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(753, 91)
        lblTitle.TabIndex = 11
        lblTitle.Text = "RECYCLEMATE MALAYSIA"
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
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Font = New Font("STXingkai", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        lblWelcome.ForeColor = Color.DarkGreen
        lblWelcome.Location = New Point(49, 125)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(282, 51)
        lblWelcome.TabIndex = 25
        lblWelcome.Text = "Welcome, User!"
        ' 
        ' ecoTips
        ' 
        ecoTips.AutoSize = True
        ecoTips.Font = New Font("Tw Cen MT Condensed Extra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ecoTips.Location = New Point(49, 192)
        ecoTips.Name = "ecoTips"
        ecoTips.Size = New Size(842, 28)
        ecoTips.TabIndex = 31
        ecoTips.Text = "🌏Track your recycling progress under " & ChrW(8220) & "Activity" & ChrW(8221) & " — see how much you’ve helped the planet!"
        ' 
        ' lblnews
        ' 
        lblnews.AutoSize = True
        lblnews.Font = New Font("Arial Rounded MT Bold", 16F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblnews.ImageAlign = ContentAlignment.BottomRight
        lblnews.Location = New Point(49, 274)
        lblnews.Name = "lblnews"
        lblnews.Size = New Size(144, 37)
        lblnews.TabIndex = 32
        lblnews.Text = "News 📰"
        ' 
        ' news1
        ' 
        news1.AutoSize = True
        news1.Font = New Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        news1.ForeColor = SystemColors.ControlText
        news1.Location = New Point(49, 325)
        news1.Name = "news1"
        news1.Size = New Size(618, 28)
        news1.TabIndex = 33
        news1.Text = "🏆Congratulations! Our users recycled 10,000 bottles this month."
        ' 
        ' news2
        ' 
        news2.AutoSize = True
        news2.Font = New Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        news2.Location = New Point(49, 373)
        news2.Name = "news2"
        news2.Size = New Size(627, 28)
        news2.TabIndex = 34
        news2.Text = "💚Our community saved 5 tons of paper — equivalent to 85 trees !"
        ' 
        ' news3
        ' 
        news3.AutoSize = True
        news3.Font = New Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        news3.Location = New Point(49, 421)
        news3.Name = "news3"
        news3.Size = New Size(735, 28)
        news3.TabIndex = 35
        news3.Text = "🌿Major tech company announces phone recycling program to reduce e-waste."
        ' 
        ' news4
        ' 
        news4.AutoSize = True
        news4.Font = New Font("Comic Sans MS", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        news4.Location = New Point(49, 468)
        news4.Name = "news4"
        news4.Size = New Size(536, 28)
        news4.TabIndex = 36
        news4.Text = "♻️New recycling bins have been installed in many areas !"
        ' 
        ' recycleThings
        ' 
        recycleThings.AutoSize = True
        recycleThings.Font = New Font("Arial Rounded MT Bold", 16F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        recycleThings.ImageAlign = ContentAlignment.BottomRight
        recycleThings.Location = New Point(49, 571)
        recycleThings.Name = "recycleThings"
        recycleThings.Size = New Size(478, 37)
        recycleThings.TabIndex = 39
        recycleThings.Text = "What do you plan to Recycle ?"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(glasses)
        Panel2.Controls.Add(aluminium)
        Panel2.Controls.Add(clothes)
        Panel2.Controls.Add(papers)
        Panel2.Controls.Add(electronicDevices)
        Panel2.Controls.Add(battery)
        Panel2.Controls.Add(plasticBottles)
        Panel2.Controls.Add(mixedMetals)
        Panel2.Location = New Point(49, 686)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1267, 293)
        Panel2.TabIndex = 40
        ' 
        ' glasses
        ' 
        glasses.BackColor = Color.Teal
        glasses.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        glasses.Image = CType(resources.GetObject("glasses.Image"), Image)
        glasses.Location = New Point(1024, 191)
        glasses.Name = "glasses"
        glasses.Size = New Size(241, 101)
        glasses.TabIndex = 19
        glasses.Text = "Glass"
        glasses.TextImageRelation = TextImageRelation.ImageBeforeText
        glasses.UseVisualStyleBackColor = False
        ' 
        ' aluminium
        ' 
        aluminium.BackColor = Color.Teal
        aluminium.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        aluminium.Image = CType(resources.GetObject("aluminium.Image"), Image)
        aluminium.Location = New Point(1024, 0)
        aluminium.Name = "aluminium"
        aluminium.Size = New Size(241, 101)
        aluminium.TabIndex = 18
        aluminium.Text = "Aluminium"
        aluminium.TextImageRelation = TextImageRelation.ImageBeforeText
        aluminium.UseVisualStyleBackColor = False
        ' 
        ' clothes
        ' 
        clothes.BackColor = Color.Teal
        clothes.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        clothes.Image = CType(resources.GetObject("clothes.Image"), Image)
        clothes.Location = New Point(679, 191)
        clothes.Name = "clothes"
        clothes.Size = New Size(241, 101)
        clothes.TabIndex = 17
        clothes.Text = "Clothes"
        clothes.TextImageRelation = TextImageRelation.ImageBeforeText
        clothes.UseVisualStyleBackColor = False
        ' 
        ' papers
        ' 
        papers.BackColor = Color.Teal
        papers.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        papers.Image = CType(resources.GetObject("papers.Image"), Image)
        papers.Location = New Point(679, 3)
        papers.Name = "papers"
        papers.Size = New Size(241, 101)
        papers.TabIndex = 16
        papers.Text = "Papers"
        papers.TextImageRelation = TextImageRelation.ImageBeforeText
        papers.UseVisualStyleBackColor = False
        ' 
        ' electronicDevices
        ' 
        electronicDevices.BackColor = Color.Teal
        electronicDevices.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        electronicDevices.Image = CType(resources.GetObject("electronicDevices.Image"), Image)
        electronicDevices.Location = New Point(340, 3)
        electronicDevices.Name = "electronicDevices"
        electronicDevices.Size = New Size(241, 101)
        electronicDevices.TabIndex = 12
        electronicDevices.Text = "Electronic Devices"
        electronicDevices.TextImageRelation = TextImageRelation.ImageBeforeText
        electronicDevices.UseVisualStyleBackColor = False
        ' 
        ' battery
        ' 
        battery.BackColor = Color.Teal
        battery.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        battery.Image = CType(resources.GetObject("battery.Image"), Image)
        battery.Location = New Point(3, 191)
        battery.Name = "battery"
        battery.Size = New Size(241, 101)
        battery.TabIndex = 13
        battery.Text = "Batteries"
        battery.TextImageRelation = TextImageRelation.ImageBeforeText
        battery.UseVisualStyleBackColor = False
        ' 
        ' plasticBottles
        ' 
        plasticBottles.BackColor = Color.Teal
        plasticBottles.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        plasticBottles.Image = CType(resources.GetObject("plasticBottles.Image"), Image)
        plasticBottles.Location = New Point(3, 3)
        plasticBottles.Name = "plasticBottles"
        plasticBottles.Size = New Size(241, 101)
        plasticBottles.TabIndex = 14
        plasticBottles.Text = "Plastic"
        plasticBottles.TextImageRelation = TextImageRelation.ImageBeforeText
        plasticBottles.UseVisualStyleBackColor = False
        ' 
        ' mixedMetals
        ' 
        mixedMetals.BackColor = Color.Teal
        mixedMetals.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        mixedMetals.Image = CType(resources.GetObject("mixedMetals.Image"), Image)
        mixedMetals.Location = New Point(340, 191)
        mixedMetals.Name = "mixedMetals"
        mixedMetals.Size = New Size(241, 101)
        mixedMetals.TabIndex = 15
        mixedMetals.Text = "Metals"
        mixedMetals.TextImageRelation = TextImageRelation.ImageBeforeText
        mixedMetals.UseVisualStyleBackColor = False
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Arial Rounded MT Bold", 16F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblLocation.ImageAlign = ContentAlignment.BottomRight
        lblLocation.Location = New Point(1459, 149)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(192, 37)
        lblLocation.TabIndex = 41
        lblLocation.Text = "Location 📍"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(lblFooter)
        Panel3.Controls.Add(btnFB)
        Panel3.Controls.Add(btnIG)
        Panel3.Location = New Point(1, 1047)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1898, 122)
        Panel3.TabIndex = 45
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
        ' ListView1
        ' 
        ListView1.Location = New Point(1459, 225)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(388, 628)
        ListView1.TabIndex = 46
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaGreen
        ClientSize = New Size(1924, 1170)
        Controls.Add(ListView1)
        Controls.Add(Panel3)
        Controls.Add(lblLocation)
        Controls.Add(Panel2)
        Controls.Add(recycleThings)
        Controls.Add(news4)
        Controls.Add(news3)
        Controls.Add(news2)
        Controls.Add(news1)
        Controls.Add(lblnews)
        Controls.Add(ecoTips)
        Controls.Add(lblWelcome)
        Controls.Add(Panel1)
        Name = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents btnTier As Button
    Friend WithEvents btnReward As Button
    Friend WithEvents btnActivity As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWelcome As Label
    Friend WithEvents ecoTips As Label
    Friend WithEvents lblnews As Label
    Friend WithEvents news1 As Label
    Friend WithEvents news2 As Label
    Friend WithEvents news3 As Label
    Friend WithEvents news4 As Label
    Friend WithEvents recycleThings As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents glasses As Button
    Friend WithEvents aluminium As Button
    Friend WithEvents clothes As Button
    Friend WithEvents papers As Button
    Friend WithEvents electronicDevices As Button
    Friend WithEvents battery As Button
    Friend WithEvents plasticBottles As Button
    Friend WithEvents mixedMetals As Button
    Friend WithEvents lblLocation As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblFooter As Label
    Friend WithEvents btnFB As Button
    Friend WithEvents btnIG As Button
    Friend WithEvents ListView1 As ListView

End Class
