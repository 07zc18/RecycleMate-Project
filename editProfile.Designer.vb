<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class editProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditProfile))
        lblEditProfile = New Label()
        lblUsername = New Label()
        lblName = New Label()
        lblEmail = New Label()
        lblPN = New Label()
        txtUsername = New TextBox()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        btnCancel = New Button()
        btnSave = New Button()
        btnProfilepic = New Button()
        SuspendLayout()
        ' 
        ' lblEditProfile
        ' 
        lblEditProfile.AutoSize = True
        lblEditProfile.Font = New Font("Sylfaen", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblEditProfile.Location = New Point(29, 9)
        lblEditProfile.Name = "lblEditProfile"
        lblEditProfile.Size = New Size(275, 52)
        lblEditProfile.TabIndex = 72
        lblEditProfile.Text = "Edit Profile✏️"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Tempus Sans ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(209, 141)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(166, 37)
        lblUsername.TabIndex = 74
        lblUsername.Text = "UserName :"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Tempus Sans ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(209, 197)
        lblName.Name = "lblName"
        lblName.Size = New Size(109, 37)
        lblName.TabIndex = 75
        lblName.Text = "Name :"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Tempus Sans ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(29, 270)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(220, 37)
        lblEmail.TabIndex = 76
        lblEmail.Text = "Email Address : "
        ' 
        ' lblPN
        ' 
        lblPN.AutoSize = True
        lblPN.Font = New Font("Tempus Sans ITC", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPN.Location = New Point(29, 338)
        lblPN.Name = "lblPN"
        lblPN.Size = New Size(228, 37)
        lblPN.TabIndex = 77
        lblPN.Text = "Phone Number :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Segoe UI", 12F)
        txtUsername.Location = New Point(395, 139)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(243, 39)
        txtUsername.TabIndex = 78
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI", 12F)
        txtName.Location = New Point(343, 195)
        txtName.Name = "txtName"
        txtName.Size = New Size(243, 39)
        txtName.TabIndex = 79
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI", 12F)
        txtEmail.Location = New Point(282, 268)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(243, 39)
        txtEmail.TabIndex = 80
        ' 
        ' txtPhone
        ' 
        txtPhone.Font = New Font("Segoe UI", 12F)
        txtPhone.Location = New Point(282, 336)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(243, 39)
        txtPhone.TabIndex = 81
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(526, 416)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 82
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(655, 416)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 83
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnProfilepic
        ' 
        btnProfilepic.BackColor = Color.Ivory
        btnProfilepic.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnProfilepic.Image = CType(resources.GetObject("btnProfilepic.Image"), Image)
        btnProfilepic.Location = New Point(29, 84)
        btnProfilepic.Name = "btnProfilepic"
        btnProfilepic.Size = New Size(150, 150)
        btnProfilepic.TabIndex = 84
        btnProfilepic.TextImageRelation = TextImageRelation.ImageAboveText
        btnProfilepic.UseVisualStyleBackColor = False
        ' 
        ' EditProfile
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(800, 473)
        Controls.Add(btnProfilepic)
        Controls.Add(btnSave)
        Controls.Add(btnCancel)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(txtUsername)
        Controls.Add(lblPN)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(lblUsername)
        Controls.Add(lblEditProfile)
        Name = "EditProfile"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblEditProfile As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPN As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnProfilepic As Button
End Class
