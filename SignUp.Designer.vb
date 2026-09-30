<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Label9 = New Label()
        Panel1 = New Panel()
        txtReferral = New TextBox()
        lblReferral = New Label()
        chkShowPassword2 = New CheckBox()
        chkShowPassword1 = New CheckBox()
        txtConfirm = New TextBox()
        txtphone = New TextBox()
        txtPassword = New TextBox()
        lbConfirm = New Label()
        lblUsername = New Label()
        lblPassword = New Label()
        lblPhone = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        txtUsername = New TextBox()
        btnBack = New Button()
        btnClear = New Button()
        btnSignup = New Button()
        Label7 = New Label()
        Label8 = New Label()
        btnLogin = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(137, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(603, 67)
        Label9.TabIndex = 21
        Label9.Text = "♻️RECYCLEMATE SIGNUP"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txtReferral)
        Panel1.Controls.Add(lblReferral)
        Panel1.Controls.Add(chkShowPassword2)
        Panel1.Controls.Add(chkShowPassword1)
        Panel1.Controls.Add(txtConfirm)
        Panel1.Controls.Add(txtphone)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(lbConfirm)
        Panel1.Controls.Add(lblUsername)
        Panel1.Controls.Add(lblPassword)
        Panel1.Controls.Add(lblPhone)
        Panel1.Controls.Add(txtName)
        Panel1.Controls.Add(txtEmail)
        Panel1.Controls.Add(lblName)
        Panel1.Controls.Add(lblEmail)
        Panel1.Controls.Add(txtUsername)
        Panel1.Location = New Point(104, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(683, 407)
        Panel1.TabIndex = 22
        ' 
        ' txtReferral
        ' 
        txtReferral.Location = New Point(220, 343)
        txtReferral.Name = "txtReferral"
        txtReferral.Size = New Size(200, 31)
        txtReferral.TabIndex = 16
        ' 
        ' lblReferral
        ' 
        lblReferral.AutoSize = True
        lblReferral.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReferral.Location = New Point(18, 344)
        lblReferral.Name = "lblReferral"
        lblReferral.Size = New Size(188, 30)
        lblReferral.TabIndex = 15
        lblReferral.Text = "Referral Code : "
        ' 
        ' chkShowPassword2
        ' 
        chkShowPassword2.AutoSize = True
        chkShowPassword2.Location = New Point(505, 291)
        chkShowPassword2.Name = "chkShowPassword2"
        chkShowPassword2.Size = New Size(162, 29)
        chkShowPassword2.TabIndex = 14
        chkShowPassword2.Text = "Show Password"
        chkShowPassword2.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword1
        ' 
        chkShowPassword1.AutoSize = True
        chkShowPassword1.Location = New Point(410, 237)
        chkShowPassword1.Name = "chkShowPassword1"
        chkShowPassword1.Size = New Size(162, 29)
        chkShowPassword1.TabIndex = 13
        chkShowPassword1.Text = "Show Password"
        chkShowPassword1.UseVisualStyleBackColor = True
        ' 
        ' txtConfirm
        ' 
        txtConfirm.Location = New Point(277, 292)
        txtConfirm.Name = "txtConfirm"
        txtConfirm.Size = New Size(200, 31)
        txtConfirm.TabIndex = 8
        ' 
        ' txtphone
        ' 
        txtphone.Location = New Point(220, 134)
        txtphone.Name = "txtphone"
        txtphone.Size = New Size(225, 31)
        txtphone.TabIndex = 12
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(175, 235)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(218, 31)
        txtPassword.TabIndex = 5
        ' 
        ' lbConfirm
        ' 
        lbConfirm.AutoSize = True
        lbConfirm.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lbConfirm.Location = New Point(18, 291)
        lbConfirm.Name = "lbConfirm"
        lbConfirm.Size = New Size(240, 30)
        lbConfirm.TabIndex = 7
        lbConfirm.Text = "Comfirm Password :"
        ' 
        ' lblUsername
        ' 
        lblUsername.AutoSize = True
        lblUsername.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblUsername.Location = New Point(18, 26)
        lblUsername.Name = "lblUsername"
        lblUsername.Size = New Size(138, 30)
        lblUsername.TabIndex = 10
        lblUsername.Text = "Username :"
        ' 
        ' lblPassword
        ' 
        lblPassword.AutoSize = True
        lblPassword.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPassword.Location = New Point(18, 234)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New Size(133, 30)
        lblPassword.TabIndex = 6
        lblPassword.Text = "Password :"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPhone.Location = New Point(18, 133)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(196, 30)
        lblPhone.TabIndex = 11
        lblPhone.Text = "Phone Number :"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(121, 79)
        txtName.Name = "txtName"
        txtName.Size = New Size(207, 31)
        txtName.TabIndex = 9
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(121, 184)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(250, 31)
        txtEmail.TabIndex = 4
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(18, 80)
        lblName.Name = "lblName"
        lblName.Size = New Size(90, 30)
        lblName.TabIndex = 1
        lblName.Text = "Name :"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(18, 183)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(97, 30)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(166, 25)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(227, 31)
        txtUsername.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(107, 511)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 23
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Location = New Point(250, 511)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnSignup
        ' 
        btnSignup.BackColor = Color.MediumSeaGreen
        btnSignup.ForeColor = Color.White
        btnSignup.Location = New Point(641, 511)
        btnSignup.Name = "btnSignup"
        btnSignup.Size = New Size(112, 34)
        btnSignup.TabIndex = 25
        btnSignup.Text = "Sign Up"
        btnSignup.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(103, 565)
        Label7.Name = "Label7"
        Label7.Size = New Size(684, 25)
        Label7.TabIndex = 26
        Label7.Text = "------------------------------------------------------------------------------------------------"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Leelawadee UI", 10F)
        Label8.Location = New Point(263, 609)
        Label8.Name = "Label8"
        Label8.Size = New Size(234, 28)
        Label8.TabIndex = 27
        Label8.Text = "Already have an account?"
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = SystemColors.Control
        btnLogin.Font = New Font("Segoe UI", 7F)
        btnLogin.Location = New Point(514, 612)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(90, 28)
        btnLogin.TabIndex = 28
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' SignUp
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(879, 677)
        Controls.Add(btnLogin)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnSignup)
        Controls.Add(btnClear)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Name = "SignUp"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkShowPassword2 As CheckBox
    Friend WithEvents chkShowPassword1 As CheckBox
    Friend WithEvents txtConfirm As TextBox
    Friend WithEvents txtphone As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lbConfirm As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSignup As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents txtReferral As TextBox
    Friend WithEvents lblReferral As Label
End Class
