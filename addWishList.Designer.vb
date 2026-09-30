<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addWishList
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
        lblAddWish = New Label()
        Label1 = New Label()
        btnSave = New Button()
        btnCancel = New Button()
        txtItem = New TextBox()
        SuspendLayout()
        ' 
        ' lblAddWish
        ' 
        lblAddWish.AutoSize = True
        lblAddWish.Font = New Font("Javanese Text", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblAddWish.Location = New Point(-1, -13)
        lblAddWish.Name = "lblAddWish"
        lblAddWish.Size = New Size(376, 91)
        lblAddWish.TabIndex = 1
        lblAddWish.Text = "Add Wish List ❤"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(47, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 28)
        Label1.TabIndex = 2
        Label1.Text = "Item :"
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(391, 229)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(112, 34)
        btnSave.TabIndex = 10
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(263, 229)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 12
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(113, 92)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(180, 31)
        txtItem.TabIndex = 13
        ' 
        ' addWishList
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lavender
        ClientSize = New Size(523, 275)
        Controls.Add(txtItem)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(Label1)
        Controls.Add(lblAddWish)
        Name = "addWishList"
        StartPosition = FormStartPosition.CenterScreen
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblAddWish As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtItem As TextBox
End Class
