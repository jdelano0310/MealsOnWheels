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
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        grdView = New DataGridView()
        btnPanel = New Panel()
        lblViewing = New Label()
        pnFilter = New Panel()
        RadioButton1 = New RadioButton()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        btnPanel.SuspendLayout()
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
        pnFilter.Location = New Point(1, 64)
        pnFilter.Name = "pnFilter"
        pnFilter.Size = New Size(798, 42)
        pnFilter.TabIndex = 35
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        RadioButton1.Location = New Point(2, 46)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(97, 19)
        RadioButton1.TabIndex = 36
        RadioButton1.TabStop = True
        RadioButton1.Text = "RadioButton1"
        RadioButton1.UseVisualStyleBackColor = False
        ' 
        ' frmCalculatedCalendar
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        ClientSize = New Size(800, 450)
        Controls.Add(RadioButton1)
        Controls.Add(pnFilter)
        Controls.Add(grdView)
        Controls.Add(btnPanel)
        Name = "frmCalculatedCalendar"
        Text = "Delivery Calendar"
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        btnPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grdView As DataGridView
    Friend WithEvents btnPanel As Panel
    Friend WithEvents lblViewing As Label
    Friend WithEvents pnFilter As Panel
    Friend WithEvents RadioButton1 As RadioButton
End Class
