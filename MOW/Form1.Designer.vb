﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        btnNewRecipient = New Button()
        btnNewDelivery = New Button()
        btnWorkers = New Button()
        btnRecipients = New Button()
        btnPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(btnRecipients)
        btnPanel.Controls.Add(btnWorkers)
        btnPanel.Controls.Add(btnNewRecipient)
        btnPanel.Controls.Add(btnNewDelivery)
        btnPanel.Location = New Point(1, 1)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(960, 46)
        btnPanel.TabIndex = 1
        ' 
        ' btnNewRecipient
        ' 
        btnNewRecipient.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        btnNewRecipient.FlatAppearance.BorderSize = 0
        btnNewRecipient.FlatStyle = FlatStyle.Flat
        btnNewRecipient.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnNewRecipient.Location = New Point(100, 0)
        btnNewRecipient.Name = "btnNewRecipient"
        btnNewRecipient.Size = New Size(96, 45)
        btnNewRecipient.TabIndex = 1
        btnNewRecipient.Text = "New Recipient"
        btnNewRecipient.UseVisualStyleBackColor = False
        ' 
        ' btnNewDelivery
        ' 
        btnNewDelivery.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        btnNewDelivery.FlatAppearance.BorderSize = 0
        btnNewDelivery.FlatStyle = FlatStyle.Flat
        btnNewDelivery.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnNewDelivery.Location = New Point(1, 0)
        btnNewDelivery.Name = "btnNewDelivery"
        btnNewDelivery.Size = New Size(96, 45)
        btnNewDelivery.TabIndex = 0
        btnNewDelivery.Text = "New Delivery"
        btnNewDelivery.UseVisualStyleBackColor = False
        ' 
        ' btnWorkers
        ' 
        btnWorkers.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        btnWorkers.FlatAppearance.BorderSize = 0
        btnWorkers.FlatStyle = FlatStyle.Flat
        btnWorkers.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnWorkers.Location = New Point(531, 0)
        btnWorkers.Name = "btnWorkers"
        btnWorkers.Size = New Size(96, 45)
        btnWorkers.TabIndex = 2
        btnWorkers.Text = "Workers"
        btnWorkers.UseVisualStyleBackColor = False
        ' 
        ' btnRecipients
        ' 
        btnRecipients.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        btnRecipients.FlatAppearance.BorderSize = 0
        btnRecipients.FlatStyle = FlatStyle.Flat
        btnRecipients.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnRecipients.Location = New Point(432, 1)
        btnRecipients.Name = "btnRecipients"
        btnRecipients.Size = New Size(96, 45)
        btnRecipients.TabIndex = 3
        btnRecipients.Text = "Recipients"
        btnRecipients.UseVisualStyleBackColor = False
        ' 
        ' frmMDI
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        BackgroundImage = My.Resources.Resources.MOW_Logo
        BackgroundImageLayout = ImageLayout.Center
        ClientSize = New Size(964, 841)
        Controls.Add(btnPanel)
        DoubleBuffered = True
        IsMdiContainer = True
        Name = "frmMDI"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Meals On Wheels"
        btnPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPanel As Panel
    Friend WithEvents btnNewDelivery As Button
    Friend WithEvents btnNewRecipient As Button
    Friend WithEvents btnWorkers As Button
    Friend WithEvents btnRecipients As Button
End Class
