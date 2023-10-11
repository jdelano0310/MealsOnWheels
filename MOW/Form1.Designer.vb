<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMDI
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
        btnPanel = New Panel()
        Button2 = New Button()
        Button1 = New Button()
        pbLogo = New PictureBox()
        btnPanel.SuspendLayout()
        CType(pbLogo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(Button2)
        btnPanel.Controls.Add(Button1)
        btnPanel.Location = New Point(1, 1)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(930, 46)
        btnPanel.TabIndex = 1
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Button2.Location = New Point(100, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(96, 45)
        Button2.TabIndex = 1
        Button2.Text = "New Recipient"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Button1.Location = New Point(1, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 45)
        Button1.TabIndex = 0
        Button1.Text = "New Delivery"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' pbLogo
        ' 
        pbLogo.Image = My.Resources.Resources.MOW_Logo
        pbLogo.Location = New Point(237, 197)
        pbLogo.Name = "pbLogo"
        pbLogo.Size = New Size(457, 78)
        pbLogo.TabIndex = 3
        pbLogo.TabStop = False
        ' 
        ' frmMDI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        ClientSize = New Size(934, 501)
        Controls.Add(pbLogo)
        Controls.Add(btnPanel)
        IsMdiContainer = True
        Name = "frmMDI"
        Text = "Meals On Wheels"
        btnPanel.ResumeLayout(False)
        CType(pbLogo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPanel As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pbLogo As PictureBox
End Class
