<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        grdView = New DataGridView()
        btnPanel = New Panel()
        lblViewing = New Label()
        tbFilters = New TabControl()
        tbByRecip = New TabPage()
        tbByWorker = New TabPage()
        tbByDate = New TabPage()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        btnPanel.SuspendLayout()
        tbFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' grdView
        ' 
        grdView.AllowUserToAddRows = False
        grdView.AllowUserToDeleteRows = False
        grdView.BackgroundColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        grdView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        grdView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
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
        ' tbFilters
        ' 
        tbFilters.Controls.Add(tbByRecip)
        tbFilters.Controls.Add(tbByWorker)
        tbFilters.Controls.Add(tbByDate)
        tbFilters.Location = New Point(0, 41)
        tbFilters.Name = "tbFilters"
        tbFilters.SelectedIndex = 0
        tbFilters.Size = New Size(798, 36)
        tbFilters.TabIndex = 30
        ' 
        ' tbByRecip
        ' 
        tbByRecip.Location = New Point(4, 24)
        tbByRecip.Name = "tbByRecip"
        tbByRecip.Padding = New Padding(3)
        tbByRecip.Size = New Size(790, 8)
        tbByRecip.TabIndex = 0
        tbByRecip.Text = "By Recipient"
        tbByRecip.UseVisualStyleBackColor = True
        ' 
        ' tbByWorker
        ' 
        tbByWorker.Location = New Point(4, 24)
        tbByWorker.Name = "tbByWorker"
        tbByWorker.Padding = New Padding(3)
        tbByWorker.Size = New Size(790, 8)
        tbByWorker.TabIndex = 1
        tbByWorker.Text = "By Worker"
        tbByWorker.UseVisualStyleBackColor = True
        ' 
        ' tbByDate
        ' 
        tbByDate.Location = New Point(4, 24)
        tbByDate.Name = "tbByDate"
        tbByDate.Size = New Size(790, 8)
        tbByDate.TabIndex = 2
        tbByDate.Text = "By Date"
        tbByDate.UseVisualStyleBackColor = True
        ' 
        ' frmCalculatedCalendar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tbFilters)
        Controls.Add(grdView)
        Controls.Add(btnPanel)
        Name = "frmCalculatedCalendar"
        Text = "Delivery Calendar"
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        btnPanel.ResumeLayout(False)
        tbFilters.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents grdView As DataGridView
    Friend WithEvents btnPanel As Panel
    Friend WithEvents lblViewing As Label
    Friend WithEvents tbFilters As TabControl
    Friend WithEvents tbByRecip As TabPage
    Friend WithEvents tbByWorker As TabPage
    Friend WithEvents tbByDate As TabPage
End Class
