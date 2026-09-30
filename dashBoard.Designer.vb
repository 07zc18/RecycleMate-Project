<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashBoard
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
        Label1 = New Label()
        Panel1 = New Panel()
        lblPlastic = New Label()
        lblTPlastic = New Label()
        Panel2 = New Panel()
        lblElectronic = New Label()
        lblTElectronic = New Label()
        Panel3 = New Panel()
        lblPaper = New Label()
        lblTPapers = New Label()
        Panel4 = New Panel()
        lblAluminium = New Label()
        lblTAluminium = New Label()
        Panel5 = New Panel()
        lblBatteries = New Label()
        lblTBatteries = New Label()
        Panel6 = New Panel()
        lblMetals = New Label()
        lblTMetals = New Label()
        Panel7 = New Panel()
        lblClothes = New Label()
        lblTClothes = New Label()
        Panel8 = New Panel()
        lblGlass = New Label()
        lblTGlass = New Label()
        Panel9 = New Panel()
        lblTotal = New Label()
        lblTItems = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        Panel8.SuspendLayout()
        Panel9.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Comic Sans MS", 18F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 50)
        Label1.TabIndex = 0
        Label1.Text = "Statistic Dashboard"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(lblPlastic)
        Panel1.Controls.Add(lblTPlastic)
        Panel1.Location = New Point(32, 86)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(324, 166)
        Panel1.TabIndex = 1
        ' 
        ' lblPlastic
        ' 
        lblPlastic.AutoSize = True
        lblPlastic.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPlastic.Location = New Point(220, 100)
        lblPlastic.Name = "lblPlastic"
        lblPlastic.Size = New Size(84, 32)
        lblPlastic.TabIndex = 1
        lblPlastic.Text = "Label3"
        ' 
        ' lblTPlastic
        ' 
        lblTPlastic.AutoSize = True
        lblTPlastic.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTPlastic.Location = New Point(3, 16)
        lblTPlastic.MaximumSize = New Size(250, 0)
        lblTPlastic.Name = "lblTPlastic"
        lblTPlastic.Size = New Size(190, 46)
        lblTPlastic.TabIndex = 0
        lblTPlastic.Text = "Total Recycled Plastics : "
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(lblElectronic)
        Panel2.Controls.Add(lblTElectronic)
        Panel2.Location = New Point(471, 86)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(324, 166)
        Panel2.TabIndex = 2
        ' 
        ' lblElectronic
        ' 
        lblElectronic.AutoSize = True
        lblElectronic.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblElectronic.Location = New Point(220, 100)
        lblElectronic.Name = "lblElectronic"
        lblElectronic.Size = New Size(84, 32)
        lblElectronic.TabIndex = 1
        lblElectronic.Text = "Label4"
        ' 
        ' lblTElectronic
        ' 
        lblTElectronic.AutoSize = True
        lblTElectronic.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTElectronic.Location = New Point(3, 16)
        lblTElectronic.MaximumSize = New Size(250, 0)
        lblTElectronic.Name = "lblTElectronic"
        lblTElectronic.Size = New Size(250, 46)
        lblTElectronic.TabIndex = 0
        lblTElectronic.Text = "Total Recycled Electronic Devices : "
        ' 
        ' Panel3
        ' 
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(lblPaper)
        Panel3.Controls.Add(lblTPapers)
        Panel3.Location = New Point(916, 86)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(324, 166)
        Panel3.TabIndex = 2
        ' 
        ' lblPaper
        ' 
        lblPaper.AutoSize = True
        lblPaper.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblPaper.Location = New Point(214, 100)
        lblPaper.Name = "lblPaper"
        lblPaper.Size = New Size(84, 32)
        lblPaper.TabIndex = 1
        lblPaper.Text = "Label6"
        ' 
        ' lblTPapers
        ' 
        lblTPapers.AutoSize = True
        lblTPapers.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTPapers.Location = New Point(3, 16)
        lblTPapers.MaximumSize = New Size(250, 0)
        lblTPapers.Name = "lblTPapers"
        lblTPapers.Size = New Size(190, 46)
        lblTPapers.TabIndex = 0
        lblTPapers.Text = "Total Recycled Papers : "
        ' 
        ' Panel4
        ' 
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(lblAluminium)
        Panel4.Controls.Add(lblTAluminium)
        Panel4.Location = New Point(32, 316)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(324, 166)
        Panel4.TabIndex = 3
        ' 
        ' lblAluminium
        ' 
        lblAluminium.AutoSize = True
        lblAluminium.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAluminium.Location = New Point(214, 100)
        lblAluminium.Name = "lblAluminium"
        lblAluminium.Size = New Size(84, 32)
        lblAluminium.TabIndex = 1
        lblAluminium.Text = "Label8"
        ' 
        ' lblTAluminium
        ' 
        lblTAluminium.AutoSize = True
        lblTAluminium.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTAluminium.Location = New Point(3, 16)
        lblTAluminium.MaximumSize = New Size(250, 0)
        lblTAluminium.Name = "lblTAluminium"
        lblTAluminium.Size = New Size(190, 46)
        lblTAluminium.TabIndex = 0
        lblTAluminium.Text = "Total Recycled Aluminium : "
        ' 
        ' Panel5
        ' 
        Panel5.BorderStyle = BorderStyle.Fixed3D
        Panel5.Controls.Add(lblBatteries)
        Panel5.Controls.Add(lblTBatteries)
        Panel5.Location = New Point(471, 316)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(324, 166)
        Panel5.TabIndex = 4
        ' 
        ' lblBatteries
        ' 
        lblBatteries.AutoSize = True
        lblBatteries.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblBatteries.Location = New Point(214, 100)
        lblBatteries.Name = "lblBatteries"
        lblBatteries.Size = New Size(96, 32)
        lblBatteries.TabIndex = 1
        lblBatteries.Text = "Label10"
        ' 
        ' lblTBatteries
        ' 
        lblTBatteries.AutoSize = True
        lblTBatteries.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTBatteries.Location = New Point(3, 16)
        lblTBatteries.MaximumSize = New Size(250, 0)
        lblTBatteries.Name = "lblTBatteries"
        lblTBatteries.Size = New Size(190, 46)
        lblTBatteries.TabIndex = 0
        lblTBatteries.Text = "Total Recycled Batteries : "
        ' 
        ' Panel6
        ' 
        Panel6.BorderStyle = BorderStyle.Fixed3D
        Panel6.Controls.Add(lblMetals)
        Panel6.Controls.Add(lblTMetals)
        Panel6.Location = New Point(916, 316)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(324, 166)
        Panel6.TabIndex = 2
        ' 
        ' lblMetals
        ' 
        lblMetals.AutoSize = True
        lblMetals.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblMetals.Location = New Point(214, 100)
        lblMetals.Name = "lblMetals"
        lblMetals.Size = New Size(96, 32)
        lblMetals.TabIndex = 1
        lblMetals.Text = "Label12"
        ' 
        ' lblTMetals
        ' 
        lblTMetals.AutoSize = True
        lblTMetals.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTMetals.Location = New Point(3, 16)
        lblTMetals.MaximumSize = New Size(250, 0)
        lblTMetals.Name = "lblTMetals"
        lblTMetals.Size = New Size(190, 46)
        lblTMetals.TabIndex = 0
        lblTMetals.Text = "Total Recycled Metals : "
        ' 
        ' Panel7
        ' 
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(lblClothes)
        Panel7.Controls.Add(lblTClothes)
        Panel7.Location = New Point(32, 555)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(324, 166)
        Panel7.TabIndex = 2
        ' 
        ' lblClothes
        ' 
        lblClothes.AutoSize = True
        lblClothes.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblClothes.Location = New Point(214, 100)
        lblClothes.Name = "lblClothes"
        lblClothes.Size = New Size(96, 32)
        lblClothes.TabIndex = 1
        lblClothes.Text = "Label14"
        ' 
        ' lblTClothes
        ' 
        lblTClothes.AutoSize = True
        lblTClothes.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTClothes.Location = New Point(3, 16)
        lblTClothes.MaximumSize = New Size(250, 0)
        lblTClothes.Name = "lblTClothes"
        lblTClothes.Size = New Size(190, 46)
        lblTClothes.TabIndex = 0
        lblTClothes.Text = "Total Recycled Clothes : "
        ' 
        ' Panel8
        ' 
        Panel8.BorderStyle = BorderStyle.Fixed3D
        Panel8.Controls.Add(lblGlass)
        Panel8.Controls.Add(lblTGlass)
        Panel8.Location = New Point(471, 555)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(324, 166)
        Panel8.TabIndex = 2
        ' 
        ' lblGlass
        ' 
        lblGlass.AutoSize = True
        lblGlass.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblGlass.Location = New Point(214, 100)
        lblGlass.Name = "lblGlass"
        lblGlass.Size = New Size(96, 32)
        lblGlass.TabIndex = 1
        lblGlass.Text = "Label16"
        ' 
        ' lblTGlass
        ' 
        lblTGlass.AutoSize = True
        lblTGlass.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTGlass.Location = New Point(3, 16)
        lblTGlass.MaximumSize = New Size(230, 0)
        lblTGlass.Name = "lblTGlass"
        lblTGlass.Size = New Size(190, 46)
        lblTGlass.TabIndex = 0
        lblTGlass.Text = "Total Recycled Glass : "
        ' 
        ' Panel9
        ' 
        Panel9.BorderStyle = BorderStyle.Fixed3D
        Panel9.Controls.Add(lblTotal)
        Panel9.Controls.Add(lblTItems)
        Panel9.Location = New Point(916, 555)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(324, 166)
        Panel9.TabIndex = 3
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(214, 100)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(96, 32)
        lblTotal.TabIndex = 1
        lblTotal.Text = "Label18"
        ' 
        ' lblTItems
        ' 
        lblTItems.AutoSize = True
        lblTItems.Font = New Font("Lucida Sans Typewriter", 10F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTItems.Location = New Point(3, 16)
        lblTItems.MaximumSize = New Size(0, 100)
        lblTItems.Name = "lblTItems"
        lblTItems.Size = New Size(274, 23)
        lblTItems.TabIndex = 0
        lblTItems.Text = "Total Items Recycled :"
        ' 
        ' dashBoard
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        ClientSize = New Size(1289, 758)
        Controls.Add(Panel9)
        Controls.Add(Panel6)
        Controls.Add(Panel7)
        Controls.Add(Panel8)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "dashBoard"
        Text = " "
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel8.ResumeLayout(False)
        Panel8.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblPlastic As Label
    Friend WithEvents lblTPlastic As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblElectronic As Label
    Friend WithEvents lblTElectronic As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblPaper As Label
    Friend WithEvents lblTPapers As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lblAluminium As Label
    Friend WithEvents lblTAluminium As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lblBatteries As Label
    Friend WithEvents lblTBatteries As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblMetals As Label
    Friend WithEvents lblTMetals As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents lblClothes As Label
    Friend WithEvents lblTClothes As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblGlass As Label
    Friend WithEvents lblTGlass As Label
    Friend WithEvents Panel9 As Panel
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTItems As Label
End Class
