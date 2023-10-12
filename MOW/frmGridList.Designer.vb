<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGridList
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
        btnPanel = New Panel()
        lblViewing = New Label()
        grdView = New DataGridView()
        btnPanel.SuspendLayout()
        CType(grdView, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(lblViewing)
        btnPanel.Location = New Point(0, 0)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(800, 46)
        btnPanel.TabIndex = 31
        ' 
        ' lblViewing
        ' 
        lblViewing.BackColor = Color.Transparent
        lblViewing.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblViewing.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblViewing.Location = New Point(0, 9)
        lblViewing.Name = "lblViewing"
        lblViewing.Size = New Size(139, 29)
        lblViewing.TabIndex = 29
        lblViewing.Text = "Viewing"
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
        grdView.Location = New Point(0, 47)
        grdView.MultiSelect = False
        grdView.Name = "grdView"
        grdView.ReadOnly = True
        grdView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        grdView.RowTemplate.Height = 25
        grdView.Size = New Size(800, 403)
        grdView.TabIndex = 32
        ' 
        ' frmGridList
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(grdView)
        Controls.Add(btnPanel)
        Name = "frmGridList"
        Text = "Viewing"
        btnPanel.ResumeLayout(False)
        CType(grdView, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnPanel As Panel
    Friend WithEvents grdView As DataGridView
    Friend WithEvents lblViewing As Label
End Class
