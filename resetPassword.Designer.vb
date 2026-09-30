<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class resetPassword
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
        lblResetPass = New Label()
        lblEnterNewPass = New Label()
        lblEnterNewPassAgain = New Label()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnCancel = New Button()
        btnReset = New Button()
        chkShowPassword1 = New CheckBox()
        chkShowPassword2 = New CheckBox()
        SuspendLayout()
        ' 
        ' lblResetPass
        ' 
        lblResetPass.AutoSize = True
        lblResetPass.Font = New Font("PMingLiU-ExtB", 16F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblResetPass.Location = New Point(12, 9)
        lblResetPass.Name = "lblResetPass"
        lblResetPass.Size = New Size(218, 32)
        lblResetPass.TabIndex = 1
        lblResetPass.Text = "Reset Password"
        ' 
        ' lblEnterNewPass
        ' 
        lblEnterNewPass.AutoSize = True
        lblEnterNewPass.Font = New Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnterNewPass.Location = New Point(83, 87)
        lblEnterNewPass.Name = "lblEnterNewPass"
        lblEnterNewPass.Size = New Size(278, 25)
        lblEnterNewPass.TabIndex = 3
        lblEnterNewPass.Text = "Enter your new password : "
        ' 
        ' lblEnterNewPassAgain
        ' 
        lblEnterNewPassAgain.AutoSize = True
        lblEnterNewPassAgain.Font = New Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnterNewPassAgain.Location = New Point(83, 177)
        lblEnterNewPassAgain.Name = "lblEnterNewPassAgain"
        lblEnterNewPassAgain.Size = New Size(338, 25)
        lblEnterNewPassAgain.TabIndex = 4
        lblEnterNewPassAgain.Text = "Enter your new password again : "
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(85, 127)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(276, 31)
        txtNewPassword.TabIndex = 5
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(85, 221)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(276, 31)
        txtConfirmPassword.TabIndex = 6
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(322, 302)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 7
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(452, 302)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(155, 34)
        btnReset.TabIndex = 8
        btnReset.Text = "Reset Password"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword1
        ' 
        chkShowPassword1.AutoSize = True
        chkShowPassword1.Location = New Point(392, 127)
        chkShowPassword1.Name = "chkShowPassword1"
        chkShowPassword1.Size = New Size(162, 29)
        chkShowPassword1.TabIndex = 12
        chkShowPassword1.Text = "Show Password"
        chkShowPassword1.UseVisualStyleBackColor = True
        ' 
        ' chkShowPassword2
        ' 
        chkShowPassword2.AutoSize = True
        chkShowPassword2.Location = New Point(392, 221)
        chkShowPassword2.Name = "chkShowPassword2"
        chkShowPassword2.Size = New Size(162, 29)
        chkShowPassword2.TabIndex = 13
        chkShowPassword2.Text = "Show Password"
        chkShowPassword2.UseVisualStyleBackColor = True
        ' 
        ' resetPassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(620, 359)
        Controls.Add(chkShowPassword2)
        Controls.Add(chkShowPassword1)
        Controls.Add(btnReset)
        Controls.Add(btnCancel)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(lblEnterNewPassAgain)
        Controls.Add(lblEnterNewPass)
        Controls.Add(lblResetPass)
        Name = "resetPassword"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResetPass As Label
    Friend WithEvents lblEnterNewPass As Label
    Friend WithEvents lblEnterNewPassAgain As Label
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents chkShowPassword1 As CheckBox
    Friend WithEvents chkShowPassword2 As CheckBox
End Class
