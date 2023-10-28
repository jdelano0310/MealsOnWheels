<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotes
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
        txtNotes = New TextBox()
        btnPanel = New Panel()
        btnToggleEdit = New Button()
        lblHeader = New Label()
        Panel1 = New Panel()
        btnCancel = New Button()
        btnSaveNote = New Button()
        lblWhyANoteIsNeeded = New Label()
        btnPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(1, 62)
        txtNotes.MaxLength = 200
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.Size = New Size(311, 68)
        txtNotes.TabIndex = 0
        ' 
        ' btnPanel
        ' 
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(btnToggleEdit)
        btnPanel.Controls.Add(lblHeader)
        btnPanel.Dock = DockStyle.Top
        btnPanel.Location = New Point(0, 0)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(312, 35)
        btnPanel.TabIndex = 31
        ' 
        ' btnToggleEdit
        ' 
        btnToggleEdit.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnToggleEdit.FlatAppearance.BorderSize = 0
        btnToggleEdit.FlatStyle = FlatStyle.Flat
        btnToggleEdit.ForeColor = Color.White
        btnToggleEdit.Location = New Point(238, 5)
        btnToggleEdit.Name = "btnToggleEdit"
        btnToggleEdit.Size = New Size(64, 25)
        btnToggleEdit.TabIndex = 4
        btnToggleEdit.Text = "Edit"
        btnToggleEdit.UseVisualStyleBackColor = False
        btnToggleEdit.Visible = False
        ' 
        ' lblHeader
        ' 
        lblHeader.BackColor = Color.Transparent
        lblHeader.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblHeader.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblHeader.Location = New Point(0, 2)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(139, 29)
        lblHeader.TabIndex = 28
        lblHeader.Text = "Note"
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.FooterBackground
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnSaveNote)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 129)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(312, 44)
        Panel1.TabIndex = 32
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnCancel.Location = New Point(221, 6)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(79, 33)
        btnCancel.TabIndex = 25
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSaveNote
        ' 
        btnSaveNote.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnSaveNote.FlatAppearance.BorderSize = 0
        btnSaveNote.FlatStyle = FlatStyle.Flat
        btnSaveNote.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnSaveNote.Location = New Point(7, 6)
        btnSaveNote.Name = "btnSaveNote"
        btnSaveNote.Size = New Size(79, 33)
        btnSaveNote.TabIndex = 24
        btnSaveNote.Text = "Save"
        btnSaveNote.UseVisualStyleBackColor = False
        btnSaveNote.Visible = False
        ' 
        ' lblWhyANoteIsNeeded
        ' 
        lblWhyANoteIsNeeded.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        lblWhyANoteIsNeeded.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblWhyANoteIsNeeded.Location = New Point(0, 35)
        lblWhyANoteIsNeeded.Name = "lblWhyANoteIsNeeded"
        lblWhyANoteIsNeeded.Size = New Size(312, 25)
        lblWhyANoteIsNeeded.TabIndex = 33
        lblWhyANoteIsNeeded.Text = "Please give a reason "
        lblWhyANoteIsNeeded.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' frmNotes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(312, 173)
        Controls.Add(lblWhyANoteIsNeeded)
        Controls.Add(Panel1)
        Controls.Add(btnPanel)
        Controls.Add(txtNotes)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "frmNotes"
        StartPosition = FormStartPosition.CenterParent
        Text = "Notes"
        btnPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNotes As TextBox
    Friend WithEvents btnPanel As Panel
    Friend WithEvents btnToggleEdit As Button
    Friend WithEvents lblHeader As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveNote As Button
    Friend WithEvents lblWhyANoteIsNeeded As Label
End Class
