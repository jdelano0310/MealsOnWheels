﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculatedCalendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        grdView = New DataGridView()
        btnPanel = New Panel()
        lblViewing = New Label()
        pnFilter = New Panel()
        lblFilterType1 = New Label()
        cboFilterList1 = New ComboBox()
        rdoByDeliveryDate = New RadioButton()
        rdoByWorker = New RadioButton()
        rdoByRecipient = New RadioButton()
        lblFilterType2 = New Label()
        cboFilterList2 = New ComboBox()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        btnPanel.SuspendLayout()
        pnFilter.SuspendLayout()
        SuspendLayout()
        ' 
        ' grdView
        ' 
        grdView.AllowUserToAddRows = False
        grdView.AllowUserToDeleteRows = False
        grdView.BackgroundColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        grdView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        grdView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        grdView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdView.Location = New Point(0, 106)
        grdView.MultiSelect = False
        grdView.Name = "grdView"
        grdView.ReadOnly = True
        grdView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grdView.RowHeadersVisible = False
        grdView.RowTemplate.Height = 25
        grdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdView.ShowEditingIcon = False
        grdView.Size = New Size(800, 344)
        grdView.TabIndex = 34
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(lblViewing)
        btnPanel.Location = New Point(0, 0)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(800, 46)
        btnPanel.TabIndex = 33
        ' 
        ' lblViewing
        ' 
        lblViewing.BackColor = Color.Transparent
        lblViewing.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblViewing.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblViewing.Location = New Point(0, 9)
        lblViewing.Name = "lblViewing"
        lblViewing.Size = New Size(339, 29)
        lblViewing.TabIndex = 29
        lblViewing.Text = "Viewing Delivery Calendar"
        ' 
        ' pnFilter
        ' 
        pnFilter.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        pnFilter.Controls.Add(lblFilterType2)
        pnFilter.Controls.Add(cboFilterList2)
        pnFilter.Controls.Add(lblFilterType1)
        pnFilter.Controls.Add(cboFilterList1)
        pnFilter.Controls.Add(rdoByDeliveryDate)
        pnFilter.Controls.Add(rdoByWorker)
        pnFilter.Controls.Add(rdoByRecipient)
        pnFilter.Location = New Point(1, 47)
        pnFilter.Name = "pnFilter"
        pnFilter.Size = New Size(798, 57)
        pnFilter.TabIndex = 35
        ' 
        ' lblFilterType1
        ' 
        lblFilterType1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        lblFilterType1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblFilterType1.Location = New Point(10, 27)
        lblFilterType1.Name = "lblFilterType1"
        lblFilterType1.Size = New Size(56, 23)
        lblFilterType1.TabIndex = 41
        lblFilterType1.Text = "Recipient"
        lblFilterType1.TextAlign = ContentAlignment.MiddleCenter
        lblFilterType1.Visible = False
        ' 
        ' cboFilterList1
        ' 
        cboFilterList1.FormattingEnabled = True
        cboFilterList1.Location = New Point(69, 27)
        cboFilterList1.Name = "cboFilterList1"
        cboFilterList1.Size = New Size(175, 23)
        cboFilterList1.TabIndex = 40
        cboFilterList1.Visible = False
        ' 
        ' rdoByDeliveryDate
        ' 
        rdoByDeliveryDate.AutoSize = True
        rdoByDeliveryDate.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByDeliveryDate.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByDeliveryDate.Location = New Point(200, 4)
        rdoByDeliveryDate.Name = "rdoByDeliveryDate"
        rdoByDeliveryDate.Size = New Size(110, 19)
        rdoByDeliveryDate.TabIndex = 39
        rdoByDeliveryDate.TabStop = True
        rdoByDeliveryDate.Text = "By Delivery Date"
        rdoByDeliveryDate.UseVisualStyleBackColor = False
        ' 
        ' rdoByWorker
        ' 
        rdoByWorker.AutoSize = True
        rdoByWorker.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByWorker.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByWorker.Location = New Point(97, 4)
        rdoByWorker.Name = "rdoByWorker"
        rdoByWorker.Size = New Size(79, 19)
        rdoByWorker.TabIndex = 38
        rdoByWorker.TabStop = True
        rdoByWorker.Text = "By Worker"
        rdoByWorker.UseVisualStyleBackColor = False
        ' 
        ' rdoByRecipient
        ' 
        rdoByRecipient.AutoSize = True
        rdoByRecipient.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByRecipient.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByRecipient.Location = New Point(3, 4)
        rdoByRecipient.Name = "rdoByRecipient"
        rdoByRecipient.Size = New Size(90, 19)
        rdoByRecipient.TabIndex = 37
        rdoByRecipient.TabStop = True
        rdoByRecipient.Text = "By Recipient"
        rdoByRecipient.UseVisualStyleBackColor = False
        ' 
        ' lblFilterType2
        ' 
        lblFilterType2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        lblFilterType2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblFilterType2.Location = New Point(254, 27)
        lblFilterType2.Name = "lblFilterType2"
        lblFilterType2.Size = New Size(56, 23)
        lblFilterType2.TabIndex = 43
        lblFilterType2.Text = "Recipient"
        lblFilterType2.TextAlign = ContentAlignment.MiddleCenter
        lblFilterType2.Visible = False
        ' 
        ' cboFilterList2
        ' 
        cboFilterList2.FormattingEnabled = True
        cboFilterList2.Location = New Point(313, 27)
        cboFilterList2.Name = "cboFilterList2"
        cboFilterList2.Size = New Size(175, 23)
        cboFilterList2.TabIndex = 42
        cboFilterList2.Visible = False
        ' 
        ' frmCalculatedCalendar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        ClientSize = New Size(800, 450)
        Controls.Add(pnFilter)
        Controls.Add(grdView)
        Controls.Add(btnPanel)
        Name = "frmCalculatedCalendar"
        Text = "Delivery Calendar"
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        btnPanel.ResumeLayout(False)
        pnFilter.ResumeLayout(False)
        pnFilter.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents grdView As DataGridView
    Friend WithEvents btnPanel As Panel
    Friend WithEvents lblViewing As Label
    Friend WithEvents pnFilter As Panel
    Friend WithEvents rdoByDeliveryDate As RadioButton
    Friend WithEvents rdoByWorker As RadioButton
    Friend WithEvents rdoByRecipient As RadioButton
    Friend WithEvents lblFilterType1 As Label
    Friend WithEvents cboFilterList1 As ComboBox
    Friend WithEvents lblFilterType2 As Label
    Friend WithEvents cboFilterList2 As ComboBox
End Class
