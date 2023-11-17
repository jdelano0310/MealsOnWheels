<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmWorker
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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        btnSaveWorker = New Button()
        btnPanel = New Panel()
        btnToggleEdit = New Button()
        lblHeader = New Label()
        lblInfo = New Label()
        Label13 = New Label()
        grdAvailable = New DataGridView()
        header = New DataGridViewTextBoxColumn()
        Sunday = New DataGridViewTextBoxColumn()
        Monday = New DataGridViewTextBoxColumn()
        Tuesday = New DataGridViewTextBoxColumn()
        Wednesday = New DataGridViewTextBoxColumn()
        Thursday = New DataGridViewTextBoxColumn()
        Friday = New DataGridViewTextBoxColumn()
        Saturday = New DataGridViewTextBoxColumn()
        WorkerID = New DataGridViewTextBoxColumn()
        ID = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        btnPanel.SuspendLayout()
        CType(grdAvailable, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label1.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label1.Location = New Point(4, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 22)
        Label1.TabIndex = 0
        Label1.Text = "First Name"
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(71, 50)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.ReadOnly = True
        txtFirstName.Size = New Size(233, 23)
        txtFirstName.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(71, 74)
        txtLastName.Name = "txtLastName"
        txtLastName.ReadOnly = True
        txtLastName.Size = New Size(233, 23)
        txtLastName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label2.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label2.Location = New Point(4, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 22)
        Label2.TabIndex = 2
        Label2.Text = "Last Name"
        Label2.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(71, 98)
        txtAddress.Name = "txtAddress"
        txtAddress.ReadOnly = True
        txtAddress.Size = New Size(233, 23)
        txtAddress.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label3.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label3.Location = New Point(4, 98)
        Label3.Name = "Label3"
        Label3.Size = New Size(64, 22)
        Label3.TabIndex = 4
        Label3.Text = "Address"
        Label3.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCity
        ' 
        txtCity.Location = New Point(71, 122)
        txtCity.Name = "txtCity"
        txtCity.ReadOnly = True
        txtCity.Size = New Size(233, 23)
        txtCity.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label4.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label4.Location = New Point(4, 122)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 22)
        Label4.TabIndex = 6
        Label4.Text = "City"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtState
        ' 
        txtState.Location = New Point(71, 146)
        txtState.Name = "txtState"
        txtState.ReadOnly = True
        txtState.Size = New Size(66, 23)
        txtState.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label5.Location = New Point(4, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 22)
        Label5.TabIndex = 8
        Label5.Text = "State"
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtCounty
        ' 
        txtCounty.Location = New Point(71, 170)
        txtCounty.Name = "txtCounty"
        txtCounty.ReadOnly = True
        txtCounty.Size = New Size(233, 23)
        txtCounty.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label6.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label6.Location = New Point(4, 170)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 22)
        Label6.TabIndex = 10
        Label6.Text = "County"
        Label6.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtZip
        ' 
        txtZip.Location = New Point(207, 146)
        txtZip.Name = "txtZip"
        txtZip.ReadOnly = True
        txtZip.Size = New Size(97, 23)
        txtZip.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label7.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label7.Location = New Point(139, 146)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 22)
        Label7.TabIndex = 12
        Label7.Text = "Zip"
        Label7.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label8.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label8.Location = New Point(309, 51)
        Label8.Name = "Label8"
        Label8.Size = New Size(64, 22)
        Label8.TabIndex = 14
        Label8.Text = "Home"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' mskHomePhone
        ' 
        mskHomePhone.Location = New Point(376, 51)
        mskHomePhone.Mask = "(999) 000-0000"
        mskHomePhone.Name = "mskHomePhone"
        mskHomePhone.ReadOnly = True
        mskHomePhone.Size = New Size(82, 23)
        mskHomePhone.TabIndex = 16
        ' 
        ' mskCellPhone
        ' 
        mskCellPhone.Location = New Point(526, 51)
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
        Label9.Location = New Point(460, 51)
        Label9.Name = "Label9"
        Label9.Size = New Size(64, 22)
        Label9.TabIndex = 17
        Label9.Text = "Cell"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(376, 75)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(233, 23)
        txtEmail.TabIndex = 20
        ' 
        ' Label10
        ' 
        Label10.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label10.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label10.Location = New Point(309, 75)
        Label10.Name = "Label10"
        Label10.Size = New Size(64, 22)
        Label10.TabIndex = 19
        Label10.Text = "Email"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtNotes
        ' 
        txtNotes.Location = New Point(376, 123)
        txtNotes.Multiline = True
        txtNotes.Name = "txtNotes"
        txtNotes.ReadOnly = True
        txtNotes.Size = New Size(233, 69)
        txtNotes.TabIndex = 25
        ' 
        ' Label11
        ' 
        Label11.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label11.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label11.Location = New Point(309, 123)
        Label11.Name = "Label11"
        Label11.Size = New Size(64, 69)
        Label11.TabIndex = 21
        Label11.Text = "Notes"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' chkActive
        ' 
        chkActive.AutoSize = True
        chkActive.Enabled = False
        chkActive.Location = New Point(376, 104)
        chkActive.Name = "chkActive"
        chkActive.Size = New Size(15, 14)
        chkActive.TabIndex = 24
        chkActive.UseVisualStyleBackColor = True
        ' 
        ' Label12
        ' 
        Label12.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        Label12.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label12.Location = New Point(309, 99)
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
        Panel1.Controls.Add(btnSaveWorker)
        Panel1.Location = New Point(0, 368)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(616, 44)
        Panel1.TabIndex = 29
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnCancel.FlatAppearance.BorderSize = 0
        btnCancel.FlatStyle = FlatStyle.Flat
        btnCancel.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnCancel.Location = New Point(522, 6)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(79, 33)
        btnCancel.TabIndex = 3
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnSaveWorker
        ' 
        btnSaveWorker.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        btnSaveWorker.FlatAppearance.BorderSize = 0
        btnSaveWorker.FlatStyle = FlatStyle.Flat
        btnSaveWorker.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnSaveWorker.Location = New Point(7, 6)
        btnSaveWorker.Name = "btnSaveWorker"
        btnSaveWorker.Size = New Size(79, 33)
        btnSaveWorker.TabIndex = 2
        btnSaveWorker.Text = "Save"
        btnSaveWorker.UseVisualStyleBackColor = False
        ' 
        ' btnPanel
        ' 
        btnPanel.Anchor = AnchorStyles.None
        btnPanel.BackgroundImage = My.Resources.Resources.HeaderBackground
        btnPanel.Controls.Add(btnToggleEdit)
        btnPanel.Controls.Add(lblHeader)
        btnPanel.Location = New Point(0, -1)
        btnPanel.Name = "btnPanel"
        btnPanel.Size = New Size(616, 46)
        btnPanel.TabIndex = 30
        ' 
        ' btnToggleEdit
        ' 
        btnToggleEdit.BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        btnToggleEdit.FlatAppearance.BorderSize = 0
        btnToggleEdit.FlatStyle = FlatStyle.Flat
        btnToggleEdit.ForeColor = Color.White
        btnToggleEdit.Location = New Point(537, 12)
        btnToggleEdit.Name = "btnToggleEdit"
        btnToggleEdit.Size = New Size(64, 25)
        btnToggleEdit.TabIndex = 29
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
        lblHeader.Size = New Size(219, 29)
        lblHeader.TabIndex = 28
        lblHeader.Text = "New Worker"
        ' 
        ' lblInfo
        ' 
        lblInfo.ForeColor = Color.White
        lblInfo.Location = New Point(3, 307)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(606, 57)
        lblInfo.TabIndex = 33
        lblInfo.Visible = False
        ' 
        ' Label13
        ' 
        Label13.BackColor = Color.FromArgb(CByte(171), CByte(208), CByte(55))
        Label13.ForeColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        Label13.Location = New Point(4, 195)
        Label13.Name = "Label13"
        Label13.Size = New Size(605, 22)
        Label13.TabIndex = 34
        Label13.Text = "Availability"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' grdAvailable
        ' 
        grdAvailable.AllowUserToAddRows = False
        grdAvailable.AllowUserToDeleteRows = False
        grdAvailable.AllowUserToResizeColumns = False
        grdAvailable.AllowUserToResizeRows = False
        grdAvailable.BackgroundColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        grdAvailable.BorderStyle = BorderStyle.None
        grdAvailable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        grdAvailable.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        grdAvailable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        grdAvailable.Columns.AddRange(New DataGridViewColumn() {header, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, WorkerID, ID})
        grdAvailable.Location = New Point(3, 220)
        grdAvailable.MultiSelect = False
        grdAvailable.Name = "grdAvailable"
        grdAvailable.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        grdAvailable.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        grdAvailable.RowHeadersVisible = False
        grdAvailable.RowTemplate.Height = 25
        grdAvailable.ScrollBars = ScrollBars.None
        grdAvailable.Size = New Size(605, 84)
        grdAvailable.TabIndex = 35
        ' 
        ' header
        ' 
        header.DataPropertyName = "TimeHeader"
        DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(0), CByte(183), CByte(196))
        header.DefaultCellStyle = DataGridViewCellStyle2
        header.Frozen = True
        header.HeaderText = ""
        header.Name = "header"
        header.ReadOnly = True
        header.Resizable = DataGridViewTriState.False
        header.Width = 45
        ' 
        ' Sunday
        ' 
        Sunday.DataPropertyName = "Sunday"
        Sunday.HeaderText = "Sunday"
        Sunday.Name = "Sunday"
        Sunday.ReadOnly = True
        Sunday.Width = 80
        ' 
        ' Monday
        ' 
        Monday.DataPropertyName = "Monday"
        Monday.HeaderText = "Monday"
        Monday.Name = "Monday"
        Monday.ReadOnly = True
        Monday.Width = 80
        ' 
        ' Tuesday
        ' 
        Tuesday.DataPropertyName = "Tuesday"
        Tuesday.HeaderText = "Tuesday"
        Tuesday.Name = "Tuesday"
        Tuesday.ReadOnly = True
        Tuesday.Width = 80
        ' 
        ' Wednesday
        ' 
        Wednesday.DataPropertyName = "Wednesday"
        Wednesday.HeaderText = "Wednesday"
        Wednesday.Name = "Wednesday"
        Wednesday.ReadOnly = True
        Wednesday.Width = 80
        ' 
        ' Thursday
        ' 
        Thursday.DataPropertyName = "Thursday"
        Thursday.HeaderText = "Thursday"
        Thursday.Name = "Thursday"
        Thursday.ReadOnly = True
        Thursday.Width = 80
        ' 
        ' Friday
        ' 
        Friday.DataPropertyName = "Friday"
        Friday.HeaderText = "Friday"
        Friday.Name = "Friday"
        Friday.ReadOnly = True
        Friday.Width = 80
        ' 
        ' Saturday
        ' 
        Saturday.DataPropertyName = "Saturday"
        Saturday.HeaderText = "Saturday"
        Saturday.Name = "Saturday"
        Saturday.ReadOnly = True
        Saturday.Width = 80
        ' 
        ' WorkerID
        ' 
        WorkerID.HeaderText = "WorkerID"
        WorkerID.Name = "WorkerID"
        WorkerID.ReadOnly = True
        WorkerID.Visible = False
        ' 
        ' ID
        ' 
        ID.HeaderText = "RecordID"
        ID.Name = "ID"
        ID.ReadOnly = True
        ID.Visible = False
        ' 
        ' frmWorker
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(56), CByte(81))
        ClientSize = New Size(613, 412)
        ControlBox = False
        Controls.Add(grdAvailable)
        Controls.Add(Label13)
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
        Name = "frmWorker"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Worker"
        Panel1.ResumeLayout(False)
        btnPanel.ResumeLayout(False)
        CType(grdAvailable, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnSaveWorker As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnToggleEdit As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents grdAvailable As DataGridView
    Friend WithEvents header As DataGridViewTextBoxColumn
    Friend WithEvents Sunday As DataGridViewTextBoxColumn
    Friend WithEvents Monday As DataGridViewTextBoxColumn
    Friend WithEvents Tuesday As DataGridViewTextBoxColumn
    Friend WithEvents Wednesday As DataGridViewTextBoxColumn
    Friend WithEvents Thursday As DataGridViewTextBoxColumn
    Friend WithEvents Friday As DataGridViewTextBoxColumn
    Friend WithEvents Saturday As DataGridViewTextBoxColumn
    Friend WithEvents WorkerID As DataGridViewTextBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
End Class
