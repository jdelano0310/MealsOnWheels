Public Class frmDelivery

    Dim _tb As DataTable = Nothing
    Dim _dr As DataRow
    Dim _dbLayer As New dbLayer
    Dim _recordID As Long = 0

    Private Sub GetDeliveryData()

        ' the record id is in the tag property of the form
        _recordID = Me.Tag

        _dbLayer.RecordID = _recordID
        _tb = _dbLayer.GetRecipient()

    End Sub

    Public Sub FillRecipientsCombo(Optional RecipID As Long = 0)

        _tb = _dbLayer.GetRecipientsForDelivery

        cboRecipients.DataSource = _tb
        cboRecipients.DisplayMember = "fullname"
        cboRecipients.ValueMember = "ID"

        If RecipID > 0 Then
            ' select the recipient from the combobox
            For i As Int16 = 0 To cboRecipients.Items.Count - 1
                If cboRecipients.Items(i) = RecipID Then
                    cboRecipients.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub WriteDataToForm()

        ' fill in the form with the data in the table retrieved from the database
        _dr = _tb.Rows(0)

        dpStarting.Value = _dr("")
        dpEnding.Value = _dr("")
        dpDeliveryTime.Value = _dr("")

        FillRecipientsCombo(_dr("recipientID"))

        FillReceipientAddressInfo()

        ' build info section
        lblInfo.Text = $"Created by: {_dr("CreatedUser")} on {_dr("DateCreated")}"

        lblInfo.Visible = True

    End Sub

    Private Sub FillReceipientAddressInfo()

        _dbLayer.RecordID = cboRecipients.SelectedValue

        _tb = New DataTable
        _tb = _dbLayer.GetRecipient
        _dr = _tb.Rows(_tb.Rows.Count - 1)

        txtAddress.Text = _dr("address")
        txtCity.Text = _dr("city")
        txtCounty.Text = _dr("county")
        txtZip.Text = _dr("zipcode")
        txtState.Text = _dr("state")
        mskCellPhone.Text = _dr("cellphone")
        mskHomePhone.Text = _dr("homephone")
        txtEmail.Text = _dr("emailaddress")

        _dr = Nothing

    End Sub

    Private Sub SetFormEdit(AllowEditing As Boolean)

        ' set the form to allow (or not) editing of the information 
        For Each ctr As Control In Me.Controls
            If ctr.Name.StartsWith("txt") Then
                DirectCast(ctr, TextBox).ReadOnly = Not AllowEditing
            ElseIf ctr.Name.StartsWith("msk") Then
                DirectCast(ctr, MaskedTextBox).ReadOnly = Not AllowEditing
            End If
        Next

    End Sub

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Tag = Int(Me.Tag)

        If Tag > 0 Then
            ' there is a recipient to view/edit in the tag

            GetDeliveryData()

            lblHeader.Text = "Viewing Delivery"
            btnSaveRecipient.Visible = False
            btnToggleEdit.Visible = True

        Else

            ' load recipients into combodox
            FillRecipientsCombo()

            _tb = _dbLayer.NewRecipientTable()
            _dr = _tb.Rows.Add()
            SetFormEdit(True)

            ' from what date can deliveries start
            dpStarting.MinDate = Now.AddDays(1)
            dpStarting.MaxDate = Now.AddDays(365)

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dpStarting_ValueChanged(sender As Object, e As EventArgs) Handles dpStarting.ValueChanged

        ' what can be selected as the end, once the start date is selected
        dpEnding.MinDate = dpStarting.Value.AddDays(7)
        dpEnding.MaxDate = dpStarting.Value.AddDays(365)

    End Sub

    Private Sub btnNewRecipient_Click(sender As Object, e As EventArgs) Handles btnNewRecipient.Click

        ' user needs to create a new recipient for this delivery
        Dim frm As New frmRecipient
        frmMDI.OpenChild(frm, "0")

    End Sub

    Private Sub cboRecipients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecipients.SelectedIndexChanged

        If cboRecipients.SelectedIndex > 0 Then FillReceipientAddressInfo()

    End Sub
End Class