<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class plastic
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
        GroupBox1 = New GroupBox()
        btnOK = New Button()
        lblTitle = New Label()
        lblLocation = New Label()
        btnCancel = New Button()
        CBLocation = New ComboBox()
        DateTimePicker1 = New DateTimePicker()
        lblQuantity = New Label()
        lblDate = New Label()
        CBQuantity = New ComboBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btnOK)
        GroupBox1.Controls.Add(lblTitle)
        GroupBox1.Controls.Add(lblLocation)
        GroupBox1.Controls.Add(btnCancel)
        GroupBox1.Controls.Add(CBLocation)
        GroupBox1.Controls.Add(DateTimePicker1)
        GroupBox1.Controls.Add(lblQuantity)
        GroupBox1.Controls.Add(lblDate)
        GroupBox1.Controls.Add(CBQuantity)
        GroupBox1.Location = New Point(1, -17)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(535, 360)
        GroupBox1.TabIndex = 13
        GroupBox1.TabStop = False
        ' 
        ' btnOK
        ' 
        btnOK.Location = New Point(393, 289)
        btnOK.Name = "btnOK"
        btnOK.Size = New Size(112, 34)
        btnOK.TabIndex = 10
        btnOK.Text = "OK"
        btnOK.UseVisualStyleBackColor = True
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Snap ITC", 12F, FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(6, 26)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(112, 31)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Plastic"
        ' 
        ' lblLocation
        ' 
        lblLocation.AutoSize = True
        lblLocation.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblLocation.Location = New Point(50, 90)
        lblLocation.Name = "lblLocation"
        lblLocation.Size = New Size(107, 26)
        lblLocation.TabIndex = 2
        lblLocation.Text = "Location: "
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(263, 289)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 8
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' CBLocation
        ' 
        CBLocation.FormattingEnabled = True
        CBLocation.Location = New Point(193, 87)
        CBLocation.Name = "CBLocation"
        CBLocation.Size = New Size(182, 33)
        CBLocation.TabIndex = 5
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(149, 209)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 7
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblQuantity.Location = New Point(50, 149)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(105, 26)
        lblQuantity.TabIndex = 4
        lblQuantity.Text = "Quantity:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Sylfaen", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(50, 214)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(62, 26)
        lblDate.TabIndex = 3
        lblDate.Text = "Date:"
        ' 
        ' CBQuantity
        ' 
        CBQuantity.FormattingEnabled = True
        CBQuantity.Location = New Point(193, 146)
        CBQuantity.Name = "CBQuantity"
        CBQuantity.Size = New Size(182, 33)
        CBQuantity.TabIndex = 6
        ' 
        ' plastic
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(536, 332)
        Controls.Add(GroupBox1)
        Name = "plastic"
        StartPosition = FormStartPosition.CenterScreen
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents btnOK As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblLocation As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents CBLocation As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents CBQuantity As ComboBox
End Class
