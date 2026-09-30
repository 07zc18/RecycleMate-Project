<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(settings))
        lblReferralProgram = New Label()
        lblAccSettings = New Label()
        lblNoti = New Label()
        chkRecycleReminder = New CheckBox()
        chkAchievementUpdate = New CheckBox()
        chkEmailPromo = New CheckBox()
        Label1 = New Label()
        btnBack = New Button()
        btnSave = New Button()
        btnChangePass = New Button()
        btnLogout = New Button()
        btnPrivacy = New Button()
        SuspendLayout()
        ' 
        ' lblReferralProgram
        ' 
        lblReferralProgram.AutoSize = True
        lblReferralProgram.Font = New Font("Sylfaen", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblReferralProgram.Location = New Point(12, 9)
        lblReferralProgram.Name = "lblReferralProgram"
        lblReferralProgram.Size = New Size(224, 52)
        lblReferralProgram.TabIndex = 74
        lblReferralProgram.Text = "Settings ⚙️"
        ' 
        ' lblAccSettings
        ' 
        lblAccSettings.AutoSize = True
        lblAccSettings.Font = New Font("Lucida Calligraphy", 14F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblAccSettings.Location = New Point(26, 87)
        lblAccSettings.Name = "lblAccSettings"
        lblAccSettings.Size = New Size(331, 36)
        lblAccSettings.TabIndex = 75
        lblAccSettings.Text = "👤 Account Settings"
        ' 
        ' lblNoti
        ' 
        lblNoti.AutoSize = True
        lblNoti.Font = New Font("Lucida Calligraphy", 14F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblNoti.Location = New Point(26, 220)
        lblNoti.Name = "lblNoti"
        lblNoti.Size = New Size(452, 36)
        lblNoti.TabIndex = 82
        lblNoti.Text = "🔔 Notification Preferences"
        ' 
        ' chkRecycleReminder
        ' 
        chkRecycleReminder.AutoSize = True
        chkRecycleReminder.Font = New Font("MS PGothic", 10F, FontStyle.Bold)
        chkRecycleReminder.Location = New Point(72, 277)
        chkRecycleReminder.Name = "chkRecycleReminder"
        chkRecycleReminder.Size = New Size(256, 24)
        chkRecycleReminder.TabIndex = 90
        chkRecycleReminder.Text = "Daily Recycle Reminder"
        chkRecycleReminder.UseVisualStyleBackColor = True
        ' 
        ' chkAchievementUpdate
        ' 
        chkAchievementUpdate.AutoSize = True
        chkAchievementUpdate.Font = New Font("MS PGothic", 10F, FontStyle.Bold)
        chkAchievementUpdate.Location = New Point(72, 319)
        chkAchievementUpdate.Name = "chkAchievementUpdate"
        chkAchievementUpdate.Size = New Size(227, 24)
        chkAchievementUpdate.TabIndex = 92
        chkAchievementUpdate.Text = "Achivement Updates"
        chkAchievementUpdate.UseVisualStyleBackColor = True
        ' 
        ' chkEmailPromo
        ' 
        chkEmailPromo.AutoSize = True
        chkEmailPromo.Font = New Font("MS PGothic", 10F, FontStyle.Bold)
        chkEmailPromo.Location = New Point(392, 277)
        chkEmailPromo.Name = "chkEmailPromo"
        chkEmailPromo.Size = New Size(195, 24)
        chkEmailPromo.TabIndex = 93
        chkEmailPromo.Text = "Email Promotions"
        chkEmailPromo.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Lucida Calligraphy", 14F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(26, 375)
        Label1.Name = "Label1"
        Label1.Size = New Size(373, 36)
        Label1.TabIndex = 94
        Label1.Text = " 📊 Data and Privacy "
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(494, 497)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 96
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(647, 497)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 97
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnChangePass
        ' 
        btnChangePass.BackColor = Color.MistyRose
        btnChangePass.Font = New Font("MS Reference Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnChangePass.Image = CType(resources.GetObject("btnChangePass.Image"), Image)
        btnChangePass.Location = New Point(76, 142)
        btnChangePass.Name = "btnChangePass"
        btnChangePass.Size = New Size(252, 38)
        btnChangePass.TabIndex = 98
        btnChangePass.Text = "Change Password"
        btnChangePass.TextImageRelation = TextImageRelation.TextBeforeImage
        btnChangePass.UseVisualStyleBackColor = False
        ' 
        ' btnLogout
        ' 
        btnLogout.BackColor = Color.MistyRose
        btnLogout.Font = New Font("MS Reference Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), Image)
        btnLogout.Location = New Point(392, 142)
        btnLogout.Name = "btnLogout"
        btnLogout.Size = New Size(252, 38)
        btnLogout.TabIndex = 99
        btnLogout.Text = "Logout"
        btnLogout.TextImageRelation = TextImageRelation.TextBeforeImage
        btnLogout.UseVisualStyleBackColor = False
        ' 
        ' btnPrivacy
        ' 
        btnPrivacy.BackColor = Color.MistyRose
        btnPrivacy.Font = New Font("MS Reference Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPrivacy.Image = CType(resources.GetObject("btnPrivacy.Image"), Image)
        btnPrivacy.Location = New Point(76, 441)
        btnPrivacy.Name = "btnPrivacy"
        btnPrivacy.Size = New Size(252, 38)
        btnPrivacy.TabIndex = 100
        btnPrivacy.Text = "Privacy Policy"
        btnPrivacy.TextImageRelation = TextImageRelation.TextBeforeImage
        btnPrivacy.UseVisualStyleBackColor = False
        ' 
        ' settings
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(800, 549)
        Controls.Add(btnPrivacy)
        Controls.Add(btnLogout)
        Controls.Add(btnChangePass)
        Controls.Add(btnSave)
        Controls.Add(btnBack)
        Controls.Add(Label1)
        Controls.Add(chkEmailPromo)
        Controls.Add(chkAchievementUpdate)
        Controls.Add(chkRecycleReminder)
        Controls.Add(lblNoti)
        Controls.Add(lblAccSettings)
        Controls.Add(lblReferralProgram)
        Name = "settings"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblReferralProgram As Label
    Friend WithEvents lblAccSettings As Label
    Friend WithEvents lblNoti As Label
    Friend WithEvents chkRecycleReminder As CheckBox
    Friend WithEvents chkAchievementUpdate As CheckBox
    Friend WithEvents chkEmailPromo As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnPrivacy As Button
End Class
