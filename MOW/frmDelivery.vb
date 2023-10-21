Public Class frmDelivery

    Dim _tb As DataTable = Nothing
    Dim _dr As DataRow
    Dim dbLayer As New dbLayer

    Public Sub FillRecipientsCombo(Optional RecipID As Long = 0)

        _tb = dbLayer.GetRecipientsForDelivery

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

    Private Sub FillReceipientAddressInfo()

        dbLayer.RecordID = cboRecipients.SelectedValue

        _tb = New DataTable
        _tb = dbLayer.GetRecipient
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

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load recipients into combodox
        FillRecipientsCombo()

        ' from what date can deliveries start
        dpStarting.MinDate = Now.AddDays(1)
        dpStarting.MaxDate = Now.AddDays(365)

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