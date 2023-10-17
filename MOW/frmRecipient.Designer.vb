<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecipient
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
        Label1 = New Label()
        txtFirstName = New TextBox()
        txtLastName = New TextBox()
        Label2 = New Label()
        txtAddress = New TextBox()
        Label3 = New Label()
        txtCity = New TextBox()
        Label4 = New Label()
        txtState = New TextBox()
        Label5 = New Label()
        txtCounty = New TextBox()
        Label6 = New Label()
        txtZip = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        mskHomePhone = New MaskedTextBox()
        mskCellPhone = New MaskedTextBox()
        Label9 = New Label()
        txtEmail = New TextBox()
        Label10 = New Label()
        txtNotes = New TextBox()
        Label11 = New Label()
        chkActive = New CheckBox()
        Label12 = New Label()
        Panel1 = New Panel()
        btnCancel = New Button()
        btnSaveRecipient = New Button()
        btnPanel = New Panel()
        btnToggleEdit = New Button()
        lblHeader = New Label()
        lblInfo = New Label()
        Panel1.SuspendLayout()
        btnPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label1.Location = New Point(4, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 22)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(71, 53)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.ReadOnly = True
        txtFirstName.Size = New Size(233, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(71, 79)
        txtLastName.Name = "txtLastName"
        txtLastName.ReadOnly = True
        txtLastName.Size = New Size(233, 23)
        txtLastName.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label2.Location = New Point(4, 79)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 22)
        Label2.TabIndex = 2
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(71, 105)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(233, 23)
        txtAddress.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label3.Location = New Point(4, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 22)
        Label3.TabIndex = 4
        Label3.Text = "Address"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(71, 131)
        txtCity.Name = "txtCity"
        txtCity.ReadOnly = True
        txtCity.Size = New Size(233, 23)
        txtCity.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label4.Location = New Point(4, 131)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 22)
        Label4.TabIndex = 6
        Label4.Text = "City"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(71, 157)
        txtState.Name = "txtState"
        txtState.ReadOnly = True
        txtState.Size = New Size(66, 23)
        txtState.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label5.Location = New Point(4, 157)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 22)
        Label5.TabIndex = 8
        Label5.Text = "State"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCounty
        ' 
        txtCounty.Location = New Point(71, 183)
        txtCounty.Name = "txtCounty"
        txtCounty.ReadOnly = True
        txtCounty.Size = New Size(233, 23)
        txtCounty.TabIndex = 13
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label6.Location = New Point(4, 183)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 22)
        Label6.TabIndex = 10
        Label6.Text = "County"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(207, 157)
        txtZip.Name = "txtZip"
        txtZip.ReadOnly = True
        txtZip.Size = New Size(97, 23)
        txtZip.TabIndex = 11
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label7.Location = New Point(140, 157)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 22)
        Label7.TabIndex = 12
        Label7.Text = "Zip"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label8.Location = New Point(4, 208)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 22)
        Label8.TabIndex = 14
        Label8.Text = "Home"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mskHomePhone
        ' 
        mskHomePhone.Location = New Point(71, 208)
        mskHomePhone.Mask = "(999) 000-0000"
        mskHomePhone.Name = "mskHomePhone"
        mskHomePhone.ReadOnly = True
        mskHomePhone.Size = New Size(82, 23)
        mskHomePhone.TabIndex = 16
        ' 
        ' mskCellPhone
        ' 
        mskCellPhone.Location = New Point(221, 208)
        mskCellPhone.Mask = "(999) 000-0000"
        mskCellPhone.Name = "mskCellPhone"
        mskCellPhone.ReadOnly = True
        mskCellPhone.Size = New Size(83, 23)
        mskCellPhone.TabIndex = 18
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label9.Location = New Point(155, 208)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 22)
        Label9.TabIndex = 17
        Label9.Text = "Cell"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(71, 233)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(233, 23)
        txtEmail.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label10.Location = New Point(4, 233)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 22)
        Label10.TabIndex = 19
        Label10.Text = "Email"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(71, 283)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ReadOnly = True
        txtNotes.Size = New Size(233, 48)
        txtNotes.TabIndex = 23
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label11.Location = New Point(4, 283)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 48)
        Label11.TabIndex = 21
        Label11.Text = "Notes"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' chkActive
        ' 
        chkActive.AutoSize = True
        chkActive.Enabled = False
        chkActive.Location = New Point(71, 263)
        chkActive.Name = "chkActive"
        chkActive.Size = New Size(15, 14)
        chkActive.TabIndex = 24
        chkActive.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label12.Location = New Point(4, 258)
        Label12.Name = "Label12"
        Label12.Size = New Size(64, 22)
        Label12.TabIndex = 23
        Label12.Text = "Active"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.FooterBackground
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnSaveRecipient)
        Panel1.Location = New Point(0, 383)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 44)
        Panel1.TabIndex = 29
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
        ' btnSaveRecipient
        ' 
        btnSaveRecipient.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnSaveRecipient.FlatAppearance.BorderSize = 0
        btnSaveRecipient.FlatStyle = FlatStyle.Flat
        btnSaveRecipient.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnSaveRecipient.Location = New Point(7, 6)
        btnSaveRecipient.Name = "btnSaveRecipient"
        btnSaveRecipient.Size = New Size(79, 33)
        btnSaveRecipient.TabIndex = 24
        btnSaveRecipient.Text = "Save"
        btnSaveRecipient.UseVisualStyleBackColor = False
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.None
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(btnToggleEdit)
        btnPanel.Controls.Add(lblHeader)
        btnPanel.Location = New Point(0, 0)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(308, 46)
        btnPanel.TabIndex = 30
        ' 
        ' btnToggleEdit
        ' 
        btnToggleEdit.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnToggleEdit.FlatAppearance.BorderSize = 0
        btnToggleEdit.FlatStyle = FlatStyle.Flat
        btnToggleEdit.ForeColor = Color.White
        btnToggleEdit.Location = New Point(236, 12)
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
        lblHeader.Location = New Point(0, 9)
        lblHeader.Name = "lblHeader"
        lblHeader.Size = New Size(139, 29)
        lblHeader.TabIndex = 28
        lblHeader.Text = "New Recipient"
        ' 
        ' lblInfo
        ' 
        lblInfo.ForeColor = Color.White
        lblInfo.Location = New Point(4, 342)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(300, 33)
        lblInfo.TabIndex = 32
        lblInfo.Visible = False
        ' 
        ' frmRecipient
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        ClientSize = New Size(308, 427)
        ControlBox = False
        Controls.Add(lblInfo)
        Controls.Add(btnPanel)
        Controls.Add(Panel1)
        Controls.Add(chkActive)
        Controls.Add(Label12)
        Controls.Add(txtNotes)
        Controls.Add(Label11)
        Controls.Add(txtEmail)
        Controls.Add(Label10)
        Controls.Add(mskCellPhone)
        Controls.Add(Label9)
        Controls.Add(mskHomePhone)
        Controls.Add(Label8)
        Controls.Add(txtZip)
        Controls.Add(Label7)
        Controls.Add(txtCounty)
        Controls.Add(Label6)
        Controls.Add(txtState)
        Controls.Add(Label5)
        Controls.Add(txtCity)
        Controls.Add(Label4)
        Controls.Add(txtAddress)
        Controls.Add(Label3)
        Controls.Add(txtLastName)
        Controls.Add(Label2)
        Controls.Add(txtFirstName)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Name = "frmRecipient"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Recipient"
        Panel1.ResumeLayout(False)
        btnPanel.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents mskHomePhone As MaskedTextBox
    Friend WithEvents mskCellPhone As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNotes As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents chkActive As CheckBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnPanel As Panel
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSaveRecipient As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnToggleEdit As Button
End Class
