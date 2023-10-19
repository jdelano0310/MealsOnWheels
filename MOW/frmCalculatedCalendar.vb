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

        lblFilterType1.Visible = True
        cboFilterList1.Visible = True

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

                _ds = dbLayer.GetCalculatedDeliveryDates()
                FillComboboxDates(cboFilterList1, _ds.Tables("Ascending"))
                FillComboboxDates(cboFilterList2, _ds.Tables("Descending"))

        End Select

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
End Class