<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        btnForgetPass = New Button()
        chkRememberMe = New CheckBox()
        chkShowPassword = New CheckBox()
        txtPassword = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        txtUsername = New TextBox()
        btnBack = New Button()
        btnClear = New Button()
        btnLogin = New Button()
        Label7 = New Label()
        Label8 = New Label()
        btnSignUp = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe Script", 20F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(96, 9)
        Label9.Name = "Label9"
        Label9.Size = New Size(574, 67)
        Label9.TabIndex = 22
        Label9.Text = "♻️RECYCLEMATE LOGIN"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btnForgetPass)
        Panel1.Controls.Add(chkRememberMe)
        Panel1.Controls.Add(chkShowPassword)
        Panel1.Controls.Add(txtPassword)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(txtUsername)
        Panel1.Location = New Point(134, 79)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(487, 281)
        Panel1.TabIndex = 23
        ' 
        ' btnForgetPass
        ' 
        btnForgetPass.Font = New Font("Segoe UI", 7F)
        btnForgetPass.Location = New Point(328, 235)
        btnForgetPass.Name = "btnForgetPass"
        btnForgetPass.Size = New Size(137, 34)
        btnForgetPass.TabIndex = 101
        btnForgetPass.Text = "Forgot Password"
        btnForgetPass.UseVisualStyleBackColor = True
        ' 
        ' chkRememberMe
        ' 
        chkRememberMe.AutoSize = True
        chkRememberMe.Font = New Font("MS PGothic", 10F, FontStyle.Bold)
        chkRememberMe.Location = New Point(18, 208)
        chkRememberMe.Name = "chkRememberMe"
        chkRememberMe.Size = New Size(167, 24)
        chkRememberMe.TabIndex = 100
        chkRememberMe.Text = "Remember Me"
        chkRememberMe.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword
        ' 
        chkShowPassword.AutoSize = True
        chkShowPassword.Location = New Point(303, 157)
        chkShowPassword.Name = "chkShowPassword"
        chkShowPassword.Size = New Size(162, 29)
        chkShowPassword.TabIndex = 11
        chkShowPassword.Text = "Show Password"
        chkShowPassword.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(18, 155)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(278, 31)
        txtPassword.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(13, 12)
        Label5.Name = "Label5"
        Label5.Size = New Size(138, 30)
        Label5.TabIndex = 10
        Label5.Text = "Username :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Modern No. 20", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(18, 107)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 30)
        Label3.TabIndex = 6
        Label3.Text = "Password :"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(18, 56)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(278, 31)
        txtUsername.TabIndex = 2
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(147, 376)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 24
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.LightGray
        btnClear.Location = New Point(283, 376)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 34)
        btnClear.TabIndex = 25
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.MediumSeaGreen
        btnLogin.ForeColor = Color.White
        btnLogin.Location = New Point(487, 376)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(112, 34)
        btnLogin.TabIndex = 26
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(132, 413)
        Label7.Name = "Label7"
        Label7.Size = New Size(481, 25)
        Label7.TabIndex = 27
        Label7.Text = "-------------------------------------------------------------------"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Leelawadee UI", 10F)
        Label8.Location = New Point(191, 453)
        Label8.Name = "Label8"
        Label8.Size = New Size(216, 28)
        Label8.TabIndex = 28
        Label8.Text = "Don't have an account?"
        ' 
        ' btnSignUp
        ' 
        btnSignUp.BackColor = SystemColors.Control
        btnSignUp.Font = New Font("Segoe UI", 7F)
        btnSignUp.Location = New Point(446, 453)
        btnSignUp.Name = "btnSignUp"
        btnSignUp.Size = New Size(90, 28)
        btnSignUp.TabIndex = 29
        btnSignUp.Text = "Sign Up"
        btnSignUp.UseVisualStyleBackColor = False
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Honeydew
        ClientSize = New Size(772, 521)
        Controls.Add(btnSignUp)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(btnLogin)
        Controls.Add(btnClear)
        Controls.Add(btnBack)
        Controls.Add(Panel1)
        Controls.Add(Label9)
        Name = "login"
        StartPosition = FormStartPosition.CenterScreen
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chkShowPassword As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSignUp As Button
    Friend WithEvents chkRememberMe As CheckBox
    Friend WithEvents btnForgetPass As Button
End Class
