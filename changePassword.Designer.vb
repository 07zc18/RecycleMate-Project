<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class changePassword
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
        lblChangePass = New Label()
        lblCurrentPass = New Label()
        lblNewPass = New Label()
        lblComfirmPass = New Label()
        txtOldPassword = New TextBox()
        txtNewPassword = New TextBox()
        txtConfirmPassword = New TextBox()
        btnChangePass = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' lblChangePass
        ' 
        lblChangePass.AutoSize = True
        lblChangePass.Font = New Font("Calisto MT", 16F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblChangePass.Location = New Point(12, 21)
        lblChangePass.Name = "lblChangePass"
        lblChangePass.Size = New Size(260, 37)
        lblChangePass.TabIndex = 2
        lblChangePass.Text = "Change Password"
        ' 
        ' lblCurrentPass
        ' 
        lblCurrentPass.AutoSize = True
        lblCurrentPass.Font = New Font("NSimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblCurrentPass.Location = New Point(34, 101)
        lblCurrentPass.Name = "lblCurrentPass"
        lblCurrentPass.Size = New Size(238, 24)
        lblCurrentPass.TabIndex = 3
        lblCurrentPass.Text = "Current Password : "
        ' 
        ' lblNewPass
        ' 
        lblNewPass.AutoSize = True
        lblNewPass.Font = New Font("NSimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNewPass.Location = New Point(34, 163)
        lblNewPass.Name = "lblNewPass"
        lblNewPass.Size = New Size(190, 24)
        lblNewPass.TabIndex = 5
        lblNewPass.Text = "New Password : "
        ' 
        ' lblComfirmPass
        ' 
        lblComfirmPass.AutoSize = True
        lblComfirmPass.Font = New Font("NSimSun", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblComfirmPass.Location = New Point(34, 223)
        lblComfirmPass.Name = "lblComfirmPass"
        lblComfirmPass.Size = New Size(238, 24)
        lblComfirmPass.TabIndex = 7
        lblComfirmPass.Text = "Comfirm Password : "
        ' 
        ' txtOldPassword
        ' 
        txtOldPassword.Location = New Point(278, 99)
        txtOldPassword.Name = "txtOldPassword"
        txtOldPassword.Size = New Size(273, 31)
        txtOldPassword.TabIndex = 8
        ' 
        ' txtNewPassword
        ' 
        txtNewPassword.Location = New Point(230, 161)
        txtNewPassword.Name = "txtNewPassword"
        txtNewPassword.Size = New Size(273, 31)
        txtNewPassword.TabIndex = 9
        ' 
        ' txtConfirmPassword
        ' 
        txtConfirmPassword.Location = New Point(278, 221)
        txtConfirmPassword.Name = "txtConfirmPassword"
        txtConfirmPassword.Size = New Size(273, 31)
        txtConfirmPassword.TabIndex = 10
        ' 
        ' btnChangePass
        ' 
        btnChangePass.Location = New Point(34, 301)
        btnChangePass.Name = "btnChangePass"
        btnChangePass.Size = New Size(206, 34)
        btnChangePass.TabIndex = 11
        btnChangePass.Text = "Change Password"
        btnChangePass.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(278, 301)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' changePassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.AliceBlue
        ClientSize = New Size(649, 361)
        Controls.Add(btnCancel)
        Controls.Add(btnChangePass)
        Controls.Add(txtConfirmPassword)
        Controls.Add(txtNewPassword)
        Controls.Add(txtOldPassword)
        Controls.Add(lblComfirmPass)
        Controls.Add(lblNewPass)
        Controls.Add(lblCurrentPass)
        Controls.Add(lblChangePass)
        Name = "changePassword"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblChangePass As Label
    Friend WithEvents lblCurrentPass As Label
    Friend WithEvents lblNewPass As Label
    Friend WithEvents lblComfirmPass As Label
    Friend WithEvents txtOldPassword As TextBox
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtConfirmPassword As TextBox
    Friend WithEvents btnChangePass As Button
    Friend WithEvents btnCancel As Button
End Class
