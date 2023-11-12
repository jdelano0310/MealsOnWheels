Public Class frmCalculatedCalendar
    Public Note As String

    Private Sub FillCombobox(cbo As ComboBox, withTable As DataTable)

        cbo.DataSource = withTable
        cbo.DisplayMember = "fullname"
        cbo.ValueMember = "ID"

    End Sub

    Private Sub FillComboboxDates(cbo As ComboBox, withTable As DataTable)

        cbo.DataSource = withTable
        cbo.DisplayMember = "DeliveryDateOnly"

    End Sub

    Private Sub ToggleRadioButtonColor(rdo As RadioButton)

        If rdo.Checked Then
            rdo.BackColor = Color.FromArgb(0, 56, 81)
            rdo.ForeColor = Color.White

            ToggleDisplayedControls(rdo)
        Else
            rdo.BackColor = Color.FromArgb(171, 208, 55)
            rdo.ForeColor = Color.FromArgb(0, 56, 81)
        End If

    End Sub

    Private Sub ToggleDisplayedControls(rdo As RadioButton)

        ' display the controls and data required to filter by the current radio button
        Dim _tb As DataTable = Nothing
        Dim dbLayer As New dbLayer

        lblFilterType2.Visible = False
        cboFilterList2.Visible = False
        btnApply.Visible = False

        lblFilterType1.Visible = True
        cboFilterList1.Visible = True

        grdView.DataSource = Nothing

        Select Case rdo.Name
            Case "rdoByRecipient"
                lblFilterType1.Text = "Recipient"
                _tb = dbLayer.GetActiveRecipientsWithDeliveries
                FillCombobox(cboFilterList1, _tb)

            Case "rdoByWorker"
                lblFilterType1.Text = "Worker"
                _tb = dbLayer.GetActiveWorkersWithDeliveries
                FillCombobox(cboFilterList1, _tb)

            Case "rdoByDeliveryDate"
                Dim _ds As DataSet
                lblFilterType1.Text = "From"
                lblFilterType2.Text = "To"

                lblFilterType2.Visible = True
                cboFilterList2.Visible = True
                btnApply.Visible = True

                _ds = dbLayer.GetCalculatedDeliveryDates()
                FillComboboxDates(cboFilterList1, _ds.Tables("Ascending"))
                FillComboboxDates(cboFilterList2, _ds.Tables("Descending"))

        End Select

    End Sub

    Private Sub FillDataGrid(secondCriteria As String)

        Dim _tb As New DataTable
        Dim dbLayer As New dbLayer

        _tb = dbLayer.GetDeliveryCalendar(secondCriteria)

        grdView.DataSource = _tb

        ' hide the columns the user doesn't need to see in the grid
        grdView.Columns(0).Visible = False   ' hide ID
        grdView.Columns(1).Visible = False   ' parent delivery id 
        grdView.Columns(2).Width = 200

        Application.DoEvents()

        grdView.EnableHeadersVisualStyles = False

    End Sub

    Private Sub frmCalculatedCalendar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' resize the grid to match the form
        grdView.Height = ((Me.Height - btnPanel.Height) - pnFilter.Height) - 30
        grdView.Width = Me.Width - 16
    End Sub

    Private Sub rdoByRecipient_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByRecipient.CheckedChanged

        ToggleRadioButtonColor(rdoByRecipient)

    End Sub

    Private Sub rdoByWorker_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByWorker.CheckedChanged

        ToggleRadioButtonColor(rdoByWorker)

    End Sub

    Private Sub rdoByDeliveryDate_CheckedChanged(sender As Object, e As EventArgs) Handles rdoByDeliveryDate.CheckedChanged

        ToggleRadioButtonColor(rdoByDeliveryDate)

    End Sub

    Private Sub cboFilterList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFilterList1.SelectedIndexChanged

        If cboFilterList1.SelectedIndex < 1 Then Exit Sub

        If rdoByRecipient.Checked Then
            FillDataGrid($"(([tblMealRecipients].[ID])={cboFilterList1.SelectedValue}));")
        ElseIf rdoByWorker.Checked Then
            FillDataGrid($"(([tblWorkers].[ID])={cboFilterList1.SelectedValue}));")
        End If

    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        Dim _tb As DataTable = Nothing
        Dim dbLayer As New dbLayer

        _tb = dbLayer.GetDeliveryCalendarByDate(cboFilterList1.Text, cboFilterList2.Text)

        grdView.DataSource = _tb

        ' hide the columns the user doesn't need to see in the grid
        grdView.Columns(0).Visible = False   ' hide ID
        grdView.Columns(1).Visible = False   ' parent delivery id 
        grdView.Columns(2).Width = 200

        Application.DoEvents()

        grdView.EnableHeadersVisualStyles = False
    End Sub

    Private Sub cmAddNote_Click(sender As Object, e As EventArgs) Handles cmAddNote.Click

        ' add a note to any selected delivery records
        If grdView.SelectedRows.Count = 0 Then
            MsgBox("Please select at least 1 row.", MsgBoxStyle.Information, "Add Notes")
            Exit Sub
        End If

        ' find each of the IDs for the selected records and build the IN CLAUSE value
        Dim selectedDeliveryIDs As String = ""
        For Each r As DataGridViewRow In grdView.SelectedRows
            selectedDeliveryIDs += r.Cells(0).Value & ","
        Next
        ' remove the trailing comma
        selectedDeliveryIDs = selectedDeliveryIDs.Substring(0, selectedDeliveryIDs.Length - 1)

        Note = ""

        Dim frm As New frmNotes
        frm.lblHeader.Text = $"Add Notes"
        frm.lblWhyANoteIsNeeded.Text = $"Enter the note for the {grdView.SelectedRows.Count} " & IIf(grdView.SelectedRows.Count = 1, "delivery", "deliveries") & " below."
        frm.Tag = "calcdelivery"

        frm.ShowDialog(Me)

        If Not Note = "Cancel" Then
            ' the user hasn't selected to cancel this process
            Dim dbLayer As New dbLayer
            If dbLayer.AddNoteToUpcomingDeliveries(frmMDI.currentUser, Note, selectedDeliveryIDs) Then
                MsgBox("Delivery note added.", MsgBoxStyle.Information, "Success")
            Else
                MsgBox("Delivery note could not be saved.", MsgBoxStyle.Exclamation, "PROBLEM")
            End If
        End If

    End Sub

    Private Sub cmCancel_Click(sender As Object, e As EventArgs) Handles cmCancel.Click

        ' add a note to any selected delivery records
        If grdView.SelectedRows.Count = 0 Then
            MsgBox("Please select at least 1 row.", MsgBoxStyle.Information, "Cancel Delivery")
            Exit Sub
        End If

        ' find each of the IDs for the selected records and build the IN CLAUSE value
        Dim selectedDeliveryIDs As String = ""
        For Each r As DataGridViewRow In grdView.SelectedRows
            selectedDeliveryIDs += r.Cells(0).Value & ","
        Next
        ' remove the trailing comma
        selectedDeliveryIDs = selectedDeliveryIDs.Substring(0, selectedDeliveryIDs.Length - 1)

        Note = ""
        Dim deliveryOrDeliveries As String = IIf(grdView.SelectedRows.Count = 1, "delivery", "deliveries")

        Dim frm As New frmNotes
        frm.lblHeader.Text = $"Cancel {deliveryOrDeliveries}"
        frm.lblWhyANoteIsNeeded.Text = $"Enter the reason for the cancellation of {grdView.SelectedRows.Count} {deliveryOrDeliveries} below."
        frm.Tag = "calcdelivery"

        frm.ShowDialog(Me)

        If Not Note = "Cancel" Then
            ' the user hasn't decided to cancel this process 
            Dim dbLayer As New dbLayer
            If dbLayer.CancelUpcomingDeliveriesFromCalendarForm(frmMDI.currentUser, Note, selectedDeliveryIDs) Then

                ' the data has been updated, let the user know
                MsgBox($"The selected {deliveryOrDeliveries} have been cancelled.", MsgBoxStyle.Information, "Success")

                ' refresh the grid by forcing selected index changed event to run or reapply the date query
                If rdoByRecipient.Checked Or rdoByWorker.Checked Then
                    cboFilterList1_SelectedIndexChanged(sender, e)
                Else
                    btnApply_Click(sender, e)
                End If

                If grdView.RowCount = 0 Then

                    ' there aren't any deliveries to display for the selected view
                    ' force it to refresh
                    Dim viewType As String = ""

                    If rdoByRecipient.Checked Then
                        viewType = "recipient"
                        rdoByRecipient_CheckedChanged(sender, e)
                    ElseIf rdoByWorker.Checked Then
                        viewType = "worker"
                        rdoByWorker_CheckedChanged(sender, e)
                    Else
                        viewType = "date range"
                        rdoByDeliveryDate_CheckedChanged(sender, e)
                    End If

                    MsgBox($"There are no more deliveries to display for the {viewType}, the form has been reset", MsgBoxStyle.Information, "Scheduled Deliveries")
                End If
            Else
                MsgBox($"The selected {deliveryOrDeliveries} could not be cancelled.", MsgBoxStyle.Exclamation, "PROBLEM")
            End If

        End If

    End Sub
End Class