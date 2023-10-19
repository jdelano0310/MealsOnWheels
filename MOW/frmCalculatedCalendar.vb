Public Class frmCalculatedCalendar

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

        Dim _tb As DataTable = Nothing
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
        grdView.Height = (Me.Height - btnPanel.Height) - 39
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
End Class