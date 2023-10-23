<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelivery
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
        lblHeader = New Label()
        btnPanel = New Panel()
        btnToggleEdit = New Button()
        btnCancel = New Button()
        btnSaveDelivery = New Button()
        Panel1 = New Panel()
        txtEmail = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        txtZip = New TextBox()
        Label7 = New Label()
        txtState = New TextBox()
        Label5 = New Label()
        txtCity = New TextBox()
        Label4 = New Label()
        txtAddress = New TextBox()
        Label3 = New Label()
        mskCellPhone = New MaskedTextBox()
        mskHomePhone = New MaskedTextBox()
        txtCounty = New TextBox()
        Label6 = New Label()
        Label1 = New Label()
        dpStarting = New DateTimePicker()
        dpEnding = New DateTimePicker()
        Label2 = New Label()
        lblFilterType1 = New Label()
        cboRecipients = New ComboBox()
        dpDeliveryTime = New DateTimePicker()
        Label11 = New Label()
        Label12 = New Label()
        cboFrequency = New ComboBox()
        Label13 = New Label()
        cboWorkers = New ComboBox()
        btnNewRecipient = New Button()
        lblInfo = New Label()
        btnStopDelivery = New Button()
        btnPanel.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
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
        lblHeader.Text = "Delivery"
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
        btnPanel.TabIndex = 32
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
        ' btnSaveDelivery
        ' 
        btnSaveDelivery.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnSaveDelivery.FlatAppearance.BorderSize = 0
        btnSaveDelivery.FlatStyle = FlatStyle.Flat
        btnSaveDelivery.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnSaveDelivery.Location = New Point(7, 6)
        btnSaveDelivery.Name = "btnSaveDelivery"
        btnSaveDelivery.Size = New Size(79, 33)
        btnSaveDelivery.TabIndex = 24
        btnSaveDelivery.Text = "Save"
        btnSaveDelivery.UseVisualStyleBackColor = False
        btnSaveDelivery.Visible = False
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = My.Resources.Resources.FooterBackground
        Panel1.Controls.Add(btnCancel)
        Panel1.Controls.Add(btnSaveDelivery)
        Panel1.Location = New Point(0, 384)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(308, 44)
        Panel1.TabIndex = 31
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(71, 253)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(233, 23)
        txtEmail.TabIndex = 44
        txtEmail.Tag = "x"
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label10.Location = New Point(4, 253)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 22)
        Label10.TabIndex = 43
        Label10.Text = "Email"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label9.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label9.Location = New Point(155, 228)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 22)
        Label9.TabIndex = 42
        Label9.Text = "Cell"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label8.Location = New Point(4, 228)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 22)
        Label8.TabIndex = 41
        Label8.Text = "Home"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(207, 178)
        txtZip.Name = "txtZip"
        txtZip.ReadOnly = True
        txtZip.Size = New Size(97, 23)
        txtZip.TabIndex = 39
        txtZip.Tag = "x"
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label7.Location = New Point(140, 178)
        Label7.Name = "Label7"
        Label7.Size = New Size(64, 22)
        Label7.TabIndex = 40
        Label7.Text = "Zip"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(71, 178)
        txtState.Name = "txtState"
        txtState.ReadOnly = True
        txtState.Size = New Size(66, 23)
        txtState.TabIndex = 38
        txtState.Tag = "x"
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label5.Location = New Point(4, 178)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 22)
        Label5.TabIndex = 37
        Label5.Text = "State"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(71, 153)
        txtCity.Name = "txtCity"
        txtCity.ReadOnly = True
        txtCity.Size = New Size(233, 23)
        txtCity.TabIndex = 36
        txtCity.Tag = "x"
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label4.Location = New Point(4, 153)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 22)
        Label4.TabIndex = 35
        Label4.Text = "City"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(71, 128)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(233, 23)
        txtAddress.TabIndex = 33
        txtAddress.Tag = "x"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label3.Location = New Point(4, 128)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 22)
        Label3.TabIndex = 34
        Label3.Text = "Address"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mskCellPhone
        ' 
        mskCellPhone.Location = New Point(221, 228)
        mskCellPhone.Mask = "(999) 000-0000"
        mskCellPhone.Name = "mskCellPhone"
        mskCellPhone.ReadOnly = True
        mskCellPhone.Size = New Size(83, 23)
        mskCellPhone.TabIndex = 46
        mskCellPhone.Tag = "x"
        ' 
        ' mskHomePhone
        ' 
        mskHomePhone.Location = New Point(71, 228)
        mskHomePhone.Mask = "(999) 000-0000"
        mskHomePhone.Name = "mskHomePhone"
        mskHomePhone.ReadOnly = True
        mskHomePhone.Size = New Size(82, 23)
        mskHomePhone.TabIndex = 45
        mskHomePhone.Tag = "x"
        ' 
        ' txtCounty
        ' 
        txtCounty.Location = New Point(71, 203)
        txtCounty.Name = "txtCounty"
        txtCounty.ReadOnly = True
        txtCounty.Size = New Size(233, 23)
        txtCounty.TabIndex = 48
        txtCounty.Tag = "x"
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label6.Location = New Point(4, 203)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 22)
        Label6.TabIndex = 47
        Label6.Text = "County"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label1.Location = New Point(4, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 22)
        Label1.TabIndex = 49
        Label1.Text = "Starting"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' dpStarting
        ' 
        dpStarting.Format = DateTimePickerFormat.Short
        dpStarting.Location = New Point(70, 49)
        dpStarting.Name = "dpStarting"
        dpStarting.Size = New Size(96, 23)
        dpStarting.TabIndex = 50
        ' 
        ' dpEnding
        ' 
        dpEnding.Enabled = False
        dpEnding.Format = DateTimePickerFormat.Short
        dpEnding.Location = New Point(70, 74)
        dpEnding.Name = "dpEnding"
        dpEnding.Size = New Size(96, 23)
        dpEnding.TabIndex = 52
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label2.Location = New Point(4, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 22)
        Label2.TabIndex = 51
        Label2.Text = "Ending"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' lblFilterType1
        ' 
        lblFilterType1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        lblFilterType1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        lblFilterType1.Location = New Point(4, 103)
        lblFilterType1.Name = "lblFilterType1"
        lblFilterType1.Size = New Size(64, 23)
        lblFilterType1.TabIndex = 54
        lblFilterType1.Text = "Recipient"
        lblFilterType1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboRecipients
        ' 
        cboRecipients.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboRecipients.FormattingEnabled = True
        cboRecipients.Location = New Point(70, 103)
        cboRecipients.Name = "cboRecipients"
        cboRecipients.Size = New Size(194, 23)
        cboRecipients.TabIndex = 53
        ' 
        ' dpDeliveryTime
        ' 
        dpDeliveryTime.CustomFormat = """HH:mm:ss"""
        dpDeliveryTime.Format = DateTimePickerFormat.Time
        dpDeliveryTime.Location = New Point(220, 50)
        dpDeliveryTime.Name = "dpDeliveryTime"
        dpDeliveryTime.ShowUpDown = True
        dpDeliveryTime.Size = New Size(85, 23)
        dpDeliveryTime.TabIndex = 55
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label11.Location = New Point(168, 50)
        Label11.Name = "Label11"
        Label11.Size = New Size(51, 22)
        Label11.TabIndex = 56
        Label11.Text = "Time"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label12.Location = New Point(168, 74)
        Label12.Name = "Label12"
        Label12.Size = New Size(51, 22)
        Label12.TabIndex = 58
        Label12.Text = "Freq"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' cboFrequency
        ' 
        cboFrequency.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboFrequency.FormattingEnabled = True
        cboFrequency.Items.AddRange(New Object() {"Weekly", "Bi-Weekly", "Monthly"})
        cboFrequency.Location = New Point(220, 74)
        cboFrequency.Name = "cboFrequency"
        cboFrequency.Size = New Size(85, 23)
        cboFrequency.TabIndex = 59
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label13.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label13.Location = New Point(4, 289)
        Label13.Name = "Label13"
        Label13.Size = New Size(64, 23)
        Label13.TabIndex = 61
        Label13.Text = "Worker"
        Label13.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cboWorkers
        ' 
        cboWorkers.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        cboWorkers.FormattingEnabled = True
        cboWorkers.Location = New Point(70, 289)
        cboWorkers.Name = "cboWorkers"
        cboWorkers.Size = New Size(235, 23)
        cboWorkers.TabIndex = 60
        ' 
        ' btnNewRecipient
        ' 
        btnNewRecipient.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnNewRecipient.FlatAppearance.BorderSize = 0
        btnNewRecipient.FlatStyle = FlatStyle.Flat
        btnNewRecipient.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnNewRecipient.Location = New Point(265, 103)
        btnNewRecipient.Name = "btnNewRecipient"
        btnNewRecipient.Size = New Size(39, 23)
        btnNewRecipient.TabIndex = 62
        btnNewRecipient.Text = "New"
        btnNewRecipient.UseVisualStyleBackColor = False
        btnNewRecipient.Visible = False
        ' 
        ' lblInfo
        ' 
        lblInfo.ForeColor = Color.White
        lblInfo.Location = New Point(4, 348)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(300, 33)
        lblInfo.TabIndex = 63
        lblInfo.Visible = False
        ' 
        ' btnStopDelivery
        ' 
        btnStopDelivery.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnStopDelivery.FlatAppearance.BorderSize = 0
        btnStopDelivery.FlatStyle = FlatStyle.Flat
        btnStopDelivery.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnStopDelivery.Location = New Point(116, 315)
        btnStopDelivery.Name = "btnStopDelivery"
        btnStopDelivery.Size = New Size(86, 24)
        btnStopDelivery.TabIndex = 26
        btnStopDelivery.Text = "Stop Delivery"
        btnStopDelivery.TextAlign = ContentAlignment.TopCenter
        btnStopDelivery.UseVisualStyleBackColor = False
        btnStopDelivery.Visible = False
        ' 
        ' frmDelivery
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        ClientSize = New Size(309, 427)
        Controls.Add(btnStopDelivery)
        Controls.Add(lblInfo)
        Controls.Add(btnNewRecipient)
        Controls.Add(Label13)
        Controls.Add(cboWorkers)
        Controls.Add(cboFrequency)
        Controls.Add(Label12)
        Controls.Add(Label11)
        Controls.Add(dpDeliveryTime)
        Controls.Add(lblFilterType1)
        Controls.Add(cboRecipients)
        Controls.Add(dpEnding)
        Controls.Add(Label2)
        Controls.Add(dpStarting)
        Controls.Add(Label1)
        Controls.Add(txtCounty)
        Controls.Add(Label6)
        Controls.Add(mskCellPhone)
        Controls.Add(mskHomePhone)
        Controls.Add(txtEmail)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(txtZip)
        Controls.Add(Label7)
        Controls.Add(txtState)
        Controls.Add(Label5)
        Controls.Add(txtCity)
        Controls.Add(Label4)
        Controls.Add(txtAddress)
        Controls.Add(Label3)
        Controls.Add(btnPanel)
        Controls.Add(Panel1)
        KeyPreview = True
        Name = "frmDelivery"
        Text = "Delivery"
        btnPanel.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnPanel As Panel
    Friend WithEvents btnToggleEdit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSaveDelivery As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtZip As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents mskCellPhone As MaskedTextBox
    Friend WithEvents mskHomePhone As MaskedTextBox
    Friend WithEvents txtCounty As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dpStarting As DateTimePicker
    Friend WithEvents dpEnding As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents lblFilterType1 As Label
    Friend WithEvents cboRecipients As ComboBox
    Friend WithEvents dpDeliveryTime As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents cboFrequency As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cboWorkers As ComboBox
    Friend WithEvents btnNewRecipient As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnStopDelivery As Button
End Class
