<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class forgetPassword
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
        lblforgotpass = New Label()
        lblEnterUsername = New Label()
        txtusername = New TextBox()
        btnReset = New Button()
        btnCancel = New Button()
        lblEnterEmail = New Label()
        txtemail = New TextBox()
        SuspendLayout()
        ' 
        ' lblResetPass
        ' 
        lblResetPass.AutoSize = True
        lblResetPass.Font = New Font("PMingLiU-ExtB", 16F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblResetPass.Location = New Point(12, 9)
        lblResetPass.Name = "lblResetPass"
        lblResetPass.Size = New Size(253, 32)
        lblResetPass.TabIndex = 0
        lblResetPass.Text = "Recover Password"
        ' 
        ' lblforgotpass
        ' 
        lblforgotpass.AutoSize = True
        lblforgotpass.Font = New Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblforgotpass.Location = New Point(69, 74)
        lblforgotpass.Name = "lblforgotpass"
        lblforgotpass.Size = New Size(306, 34)
        lblforgotpass.TabIndex = 1
        lblforgotpass.Text = "Forgot your password?"
        ' 
        ' lblEnterUsername
        ' 
        lblEnterUsername.AutoSize = True
        lblEnterUsername.Font = New Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnterUsername.Location = New Point(69, 125)
        lblEnterUsername.Name = "lblEnterUsername"
        lblEnterUsername.Size = New Size(230, 25)
        lblEnterUsername.TabIndex = 2
        lblEnterUsername.Text = "Enter your username :"
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(69, 168)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(276, 31)
        txtusername.TabIndex = 3
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(436, 328)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(174, 34)
        btnReset.TabIndex = 4
        btnReset.Text = "Recover Password"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(307, 328)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 5
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' lblEnterEmail
        ' 
        lblEnterEmail.AutoSize = True
        lblEnterEmail.Font = New Font("Modern No. 20", 11.999999F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEnterEmail.Location = New Point(69, 222)
        lblEnterEmail.Name = "lblEnterEmail"
        lblEnterEmail.Size = New Size(193, 25)
        lblEnterEmail.TabIndex = 6
        lblEnterEmail.Text = "Enter your email :"
        ' 
        ' txtemail
        ' 
        txtemail.Location = New Point(69, 261)
        txtemail.Name = "txtemail"
        txtemail.Size = New Size(276, 31)
        txtemail.TabIndex = 7
        ' 
        ' forgetPassword
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(623, 384)
        Controls.Add(txtemail)
        Controls.Add(lblEnterEmail)
        Controls.Add(btnCancel)
        Controls.Add(btnReset)
        Controls.Add(txtusername)
        Controls.Add(lblEnterUsername)
        Controls.Add(lblforgotpass)
        Controls.Add(lblResetPass)
        Name = "forgetPassword"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResetPass As Label
    Friend WithEvents lblforgotpass As Label
    Friend WithEvents lblEnterUsername As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblEnterEmail As Label
    Friend WithEvents txtemail As TextBox
End Class
