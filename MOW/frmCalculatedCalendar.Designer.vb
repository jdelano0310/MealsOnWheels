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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        grdView = New DataGridView()
        cMenu = New ContextMenuStrip(components)
        cmAddNote = New ToolStripMenuItem()
        cmCancel = New ToolStripMenuItem()
        btnPanel = New Panel()
        lblViewing = New Label()
        pnFilter = New Panel()
        chkDisplayHidden = New CheckBox()
        btnApply = New Button()
        lblFilterType2 = New Label()
        cboFilterList2 = New ComboBox()
        lblFilterType1 = New Label()
        cboFilterList1 = New ComboBox()
        rdoByDeliveryDate = New RadioButton()
        rdoByWorker = New RadioButton()
        rdoByRecipient = New RadioButton()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        cMenu.SuspendLayout()
        btnPanel.SuspendLayout()
        pnFilter.SuspendLayout()
        SuspendLayout()
        ' 
        ' grdView
        ' 
        grdView.AllowUserToAddRows = False
        grdView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        grdView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
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
        grdView.ContextMenuStrip = cMenu
        grdView.Location = New Point(0, 106)
        grdView.Name = "grdView"
        grdView.ReadOnly = True
        grdView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grdView.RowHeadersVisible = False
        grdView.RowTemplate.Height = 25
        grdView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        grdView.ShowEditingIcon = False
        grdView.Size = New Size(593, 344)
        grdView.TabIndex = 34
        ' 
        ' cMenu
        ' 
        cMenu.Items.AddRange(New ToolStripItem() {cmAddNote, cmCancel})
        cMenu.Name = "cMenu"
        cMenu.Size = New Size(156, 48)
        ' 
        ' cmAddNote
        ' 
        cmAddNote.Name = "cmAddNote"
        cmAddNote.Size = New Size(155, 22)
        cmAddNote.Text = "Add Note"
        cmAddNote.ToolTipText = "Add a note to any selected deliveries"
        ' 
        ' cmCancel
        ' 
        cmCancel.Name = "cmCancel"
        cmCancel.Size = New Size(155, 22)
        cmCancel.Text = "Cancel Delivery"
        cmCancel.ToolTipText = "Cancel any selected deliveries"
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(lblViewing)
        btnPanel.Location = New Point(0, 0)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(593, 46)
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
        lblViewing.Text = "View Delivery Calendar"
        ' 
        ' pnFilter
        ' 
        pnFilter.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        pnFilter.Controls.Add(chkDisplayHidden)
        pnFilter.Controls.Add(btnApply)
        pnFilter.Controls.Add(lblFilterType2)
        pnFilter.Controls.Add(cboFilterList2)
        pnFilter.Controls.Add(lblFilterType1)
        pnFilter.Controls.Add(cboFilterList1)
        pnFilter.Controls.Add(rdoByDeliveryDate)
        pnFilter.Controls.Add(rdoByWorker)
        pnFilter.Controls.Add(rdoByRecipient)
        pnFilter.Location = New Point(1, 47)
        pnFilter.Name = "pnFilter"
        pnFilter.Size = New Size(592, 57)
        pnFilter.TabIndex = 35
        ' 
        ' chkDisplayHidden
        ' 
        chkDisplayHidden.AutoSize = True
        chkDisplayHidden.Location = New Point(300, 4)
        chkDisplayHidden.Name = "chkDisplayHidden"
        chkDisplayHidden.Size = New Size(169, 19)
        chkDisplayHidden.TabIndex = 45
        chkDisplayHidden.Text = "Display cancelled deliveries"
        chkDisplayHidden.UseVisualStyleBackColor = True
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        btnApply.FlatStyle = FlatStyle.Flat
        btnApply.Location = New Point(477, 26)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(48, 25)
        btnApply.TabIndex = 44
        btnApply.Text = "Apply"
        btnApply.UseVisualStyleBackColor = False
        btnApply.Visible = False
        ' 
        ' lblFilterType2
        ' 
        lblFilterType2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        lblFilterType2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblFilterType2.Location = New Point(243, 27)
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
        cboFilterList2.Location = New Point(300, 27)
        cboFilterList2.Name = "cboFilterList2"
        cboFilterList2.Size = New Size(175, 23)
        cboFilterList2.TabIndex = 42
        cboFilterList2.Visible = False
        ' 
        ' lblFilterType1
        ' 
        lblFilterType1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        lblFilterType1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblFilterType1.Location = New Point(6, 27)
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
        cboFilterList1.Location = New Point(63, 27)
        cboFilterList1.Name = "cboFilterList1"
        cboFilterList1.Size = New Size(175, 23)
        cboFilterList1.TabIndex = 40
        cboFilterList1.Visible = False
        ' 
        ' rdoByDeliveryDate
        ' 
        rdoByDeliveryDate.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByDeliveryDate.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByDeliveryDate.Location = New Point(181, 2)
        rdoByDeliveryDate.Name = "rdoByDeliveryDate"
        rdoByDeliveryDate.Size = New Size(110, 21)
        rdoByDeliveryDate.TabIndex = 39
        rdoByDeliveryDate.TabStop = True
        rdoByDeliveryDate.Text = "By Delivery Date"
        rdoByDeliveryDate.TextAlign = ContentAlignment.MiddleCenter
        rdoByDeliveryDate.UseVisualStyleBackColor = False
        ' 
        ' rdoByWorker
        ' 
        rdoByWorker.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByWorker.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByWorker.Location = New Point(100, 2)
        rdoByWorker.Name = "rdoByWorker"
        rdoByWorker.Size = New Size(79, 21)
        rdoByWorker.TabIndex = 38
        rdoByWorker.TabStop = True
        rdoByWorker.Text = "By Worker"
        rdoByWorker.UseVisualStyleBackColor = False
        ' 
        ' rdoByRecipient
        ' 
        rdoByRecipient.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        rdoByRecipient.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        rdoByRecipient.Location = New Point(3, 2)
        rdoByRecipient.Name = "rdoByRecipient"
        rdoByRecipient.Size = New Size(91, 21)
        rdoByRecipient.TabIndex = 37
        rdoByRecipient.TabStop = True
        rdoByRecipient.Text = "By Recipient"
        rdoByRecipient.UseVisualStyleBackColor = False
        ' 
        ' frmCalculatedCalendar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        ClientSize = New Size(593, 450)
        Controls.Add(pnFilter)
        Controls.Add(grdView)
        Controls.Add(btnPanel)
        Name = "frmCalculatedCalendar"
        Text = "Delivery Calendar"
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        cMenu.ResumeLayout(False)
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
    Friend WithEvents btnApply As Button
    Friend WithEvents cMenu As ContextMenuStrip
    Friend WithEvents cmAddNote As ToolStripMenuItem
    Friend WithEvents cmCancel As ToolStripMenuItem
    Friend WithEvents chkDisplayHidden As CheckBox
End Class
