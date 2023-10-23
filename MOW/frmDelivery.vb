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

        cboRecipients.DataSource = _dbLayer.GetRecipientsForDelivery
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

    Private Sub FillWorkersCombo(Optional WorkerID As Long = 0)

        cboWorkers.DataSource = _dbLayer.GetWorkersForDelivery
        cboWorkers.DisplayMember = "fullname"
        cboWorkers.ValueMember = "ID"

        If WorkerID > 0 Then
            ' select the recipient from the combobox
            For i As Int16 = 0 To cboWorkers.Items.Count - 1
                If cboWorkers.Items(i) = WorkerID Then
                    cboWorkers.SelectedIndex = i
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub WriteDataToForm()

        ' fill in the form with the data in the table retrieved from the database
        _dr = _tb.Rows(0)

        dpStarting.Value = Format(_dr("StartDateTime").ToString(), "d")
        dpEnding.Value = _dr("EndDate")
        dpDeliveryTime.Value = Format(_dr("StartDateTime").ToString(), "t")

        FillRecipientsCombo(_dr("RecipientID"))
        FillWorkersCombo(_dr("WorkerID"))

        FillReceipientAddressInfo()

        ' build info section
        lblInfo.Text = $"Created by: {_dr("CreatedUser")} on {_dr("DateCreated")}"

        lblInfo.Visible = True

    End Sub

    Private Sub FillReceipientAddressInfo()

        _dbLayer.RecordID = cboRecipients.SelectedValue

        Dim tbRecipient As DataTable
        tbRecipient = _dbLayer.GetRecipient
        Dim drRecipient = tbRecipient.Rows(0)

        txtAddress.Text = drRecipient("address")
        txtCity.Text = drRecipient("city")
        txtCounty.Text = drRecipient("county")
        txtZip.Text = drRecipient("zipcode")
        txtState.Text = drRecipient("state")
        mskCellPhone.Text = drRecipient("cellphone")
        mskHomePhone.Text = drRecipient("homephone")
        txtEmail.Text = drRecipient("emailaddress")

        drRecipient = Nothing
        tbRecipient.Dispose()

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

    Private Sub WriteDataToTable()

        ' fill in the table with the data from the form to be saved to the db
        _dr("StartDateTime") = dpStarting.Value
        _dr("EndDate") = dpEnding.Value
        _dr("StartDateTime") = dpDeliveryTime.Value
        _dr("Frequency") = cboFrequency.Text
        _dr("RecipientID") = cboRecipients.SelectedValue
        _dr("WorkerID") = cboWorkers.SelectedValue

        _dr("notes") = ""

        If btnStopDelivery.Text = "Stopped" Then
            ' the delivery is deactivated
            _dr("DeactivatedUser") = frmMDI.currentUser
            _dr("DateDeactivated") = Now

        End If

        If Me.Tag = 0 Then
            ' this is a new recipient
            _dr("CreatedUser") = frmMDI.currentUser
            _dr("DateCreated") = Now

            _recordID = _dbLayer.SaveNewDelivery(_tb)
            If _recordID = 0 Then
                ' if the record id sent back it zero then there was a problem saving the record
                MsgBox("There was an issue attempting to save the delivery")
                Exit Sub
            End If

            Me.Tag = _recordID
        Else
            _dr("LastModifiedUser") = frmMDI.currentUser
            _dr("DateLastModified") = Now

            _recordID = _dbLayer.UpdateDelivery(_tb)
            If _recordID = 0 Then
                MsgBox("There was an issue attempting to save the delivery")
            End If
        End If

    End Sub

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Tag = Int(Me.Tag)

        If Tag > 0 Then
            ' there is a delivery to view/edit in the tag

            GetDeliveryData()

            lblHeader.Text = "Viewing Delivery"
            btnSaveDelivery.Visible = False
            btnToggleEdit.Visible = True

        Else

            lblHeader.Text = "New Delivery"

            ' load recipients and workers into combodox
            FillRecipientsCombo()
            FillWorkersCombo()

            ' create a table to write this forms data to
            _tb = _dbLayer.NewDelieryTable
            _dr = _tb.Rows.Add()

            SetFormEdit(True)

            ' from what date can deliveries start
            dpStarting.MinDate = Now
            dpStarting.MaxDate = Now.AddDays(365)

            ' user can't select and end date until a start date is selected
            dpEnding.Enabled = False

            btnSaveDelivery.Visible = True
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dpStarting_ValueChanged(sender As Object, e As EventArgs) Handles dpStarting.ValueChanged

        ' what can be selected as the end, once the start date is selected
        dpEnding.MinDate = dpStarting.Value.AddDays(7)
        dpEnding.MaxDate = dpStarting.Value.AddDays(365)
        dpEnding.Enabled = True

    End Sub

    Private Sub btnNewRecipient_Click(sender As Object, e As EventArgs) Handles btnNewRecipient.Click

        ' user needs to create a new recipient for this delivery
        Dim frm As New frmRecipient
        frmMDI.OpenChild(frm, "0")

    End Sub

    Private Sub cboRecipients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRecipients.SelectedIndexChanged

        If cboRecipients.SelectedIndex > 0 Then FillReceipientAddressInfo()

    End Sub

    Private Sub frmDelivery_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        ' make enter act like tab
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub btnToggleEdit_Click(sender As Object, e As EventArgs) Handles btnToggleEdit.Click

        ' toggle the form in and out of edit mode
        If btnToggleEdit.Text = "Edit" Then
            lblHeader.Text = "Editing Delivery"
            btnSaveDelivery.Visible = True
            btnToggleEdit.Text = "Stop"
            btnStopDelivery.Visible = True
            SetFormEdit(True)
        Else
            lblHeader.Text = "Viewing Delivery"
            btnSaveDelivery.Visible = False
            btnToggleEdit.Text = "Edit"
            btnStopDelivery.Visible = False
            SetFormEdit(False)
        End If

        Application.DoEvents()
    End Sub

    Private Sub btnSaveDelivery_Click(sender As Object, e As EventArgs) Handles btnSaveDelivery.Click

        WriteDataToTable()

        If Me.Tag > 0 Then
            ' the save was successfull
            If btnToggleEdit.Visible = False Then
                ' of a new receipient, change the view of the form
                btnToggleEdit.Visible = True
            Else
                ' of an edit to a previous recipient
                btnToggleEdit.Text = "Edit"
            End If
            SetFormEdit(False)

            lblHeader.Text = "Viewing Delivery"
            btnSaveDelivery.Visible = False
        Else

        End If

        'Dim frm As Form = frmMDI.IsChildFormOpen("frmGridList")

        'If frm IsNot Nothing Then
        '    ' the gridlist form is displayed, update the grid
        '    DirectCast(frm, frmGridList).FillGrid()
        'End If

        Application.DoEvents()

    End Sub

    Private Sub btnStopDelivery_Click(sender As Object, e As EventArgs) Handles btnStopDelivery.Click

        If btnStopDelivery.Text = "Stop Delivery" Then
            If MsgBox("Stopping the delivery will remove any remaining deliveries from the calendar, when you save this change. Are you sure?", MsgBoxStyle.YesNo, "Please Confirm") = MsgBoxResult.Yes Then
                btnStopDelivery.Text = "Stopped"
            End If

        Else
            btnStopDelivery.Text = "Stop Delivery"
        End If
    End Sub

End Class