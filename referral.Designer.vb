<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class referral
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
        lblReferralProgram = New Label()
        lblIntro = New Label()
        Label2 = New Label()
        lblReferral = New Label()
        lblReferralCode = New Label()
        btnCopy = New Button()
        Label3 = New Label()
        btnBack = New Button()
        dgv = New DataGridView()
        CType(dgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblReferralProgram
        ' 
        lblReferralProgram.AutoSize = True
        lblReferralProgram.Font = New Font("Sylfaen", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblReferralProgram.Location = New Point(21, 9)
        lblReferralProgram.Name = "lblReferralProgram"
        lblReferralProgram.Size = New Size(379, 52)
        lblReferralProgram.TabIndex = 73
        lblReferralProgram.Text = "Referral Program👥"
        ' 
        ' lblIntro
        ' 
        lblIntro.AutoSize = True
        lblIntro.Font = New Font("Sylfaen", 12F)
        lblIntro.Location = New Point(21, 73)
        lblIntro.Name = "lblIntro"
        lblIntro.Size = New Size(423, 31)
        lblIntro.TabIndex = 74
        lblIntro.Text = "🌱Invite your friends and earn rewards! "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("STXinwei", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        Label2.Location = New Point(21, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(618, 21)
        Label2.TabIndex = 76
        Label2.Text = "💡Earn 100 token for each friends who signs up with your code!"
        ' 
        ' lblReferral
        ' 
        lblReferral.AutoSize = True
        lblReferral.Font = New Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReferral.Location = New Point(48, 176)
        lblReferral.Name = "lblReferral"
        lblReferral.Size = New Size(185, 28)
        lblReferral.TabIndex = 77
        lblReferral.Text = "Your Referral Code :"
        ' 
        ' lblReferralCode
        ' 
        lblReferralCode.AutoSize = True
        lblReferralCode.Font = New Font("Segoe UI Symbol", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblReferralCode.Location = New Point(230, 176)
        lblReferralCode.Name = "lblReferralCode"
        lblReferralCode.Size = New Size(110, 28)
        lblReferralCode.TabIndex = 82
        lblReferralCode.Text = "[ECO7294] "
        ' 
        ' btnCopy
        ' 
        btnCopy.Location = New Point(535, 174)
        btnCopy.Name = "btnCopy"
        btnCopy.Size = New Size(112, 34)
        btnCopy.TabIndex = 83
        btnCopy.Text = "[Copy]"
        btnCopy.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("SimSun-ExtB", 12F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(218, 24)
        Label3.TabIndex = 84
        Label3.Text = "Referral History"
        ' 
        ' btnBack
        ' 
        btnBack.Location = New Point(667, 570)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(112, 34)
        btnBack.TabIndex = 86
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' dgv
        ' 
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv.Location = New Point(21, 308)
        dgv.Name = "dgv"
        dgv.ReadOnly = True
        dgv.RowHeadersWidth = 62
        dgv.Size = New Size(591, 225)
        dgv.TabIndex = 85
        ' 
        ' referral
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SeaShell
        ClientSize = New Size(800, 633)
        Controls.Add(dgv)
        Controls.Add(btnBack)
        Controls.Add(Label3)
        Controls.Add(btnCopy)
        Controls.Add(lblReferralCode)
        Controls.Add(lblReferral)
        Controls.Add(Label2)
        Controls.Add(lblIntro)
        Controls.Add(lblReferralProgram)
        Name = "referral"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblReferralProgram As Label
    Friend WithEvents lblIntro As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblReferral As Label
    Friend WithEvents lblReferralCode As Label
    Friend WithEvents btnCopy As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents dgv As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents dvgPanel As Panel
End Class
