Imports System.ComponentModel

Public Class frmWorker
    Dim _tb As DataTable = Nothing
    Dim _dr As DataRow
    Dim _dbLayer As New dbLayer
    Dim _recordID As Long = 0

    Private Sub GetWorkerData()

        ' the record id is in the tag property of the form
        _recordID = Me.Tag

        _dbLayer.RecordID = _recordID
        _tb = _dbLayer.GetWorker()

    End Sub

    Private Sub WriteDataToForm()

        ' fill in the form with the data in the table retrieved from the database
        _dr = _tb.Rows(0)

        txtFirstName.Text = _dr("firstname")
        txtLastName.Text = _dr("lastname")
        txtAddress.Text = _dr("address")
        txtCity.Text = _dr("city")
        txtCounty.Text = _dr("county")
        txtZip.Text = _dr("zipcode")
        txtState.Text = _dr("state")
        mskCellPhone.Text = _dr("cellphone")
        mskHomePhone.Text = _dr("homephone")
        chkActive.Checked = _dr("active")
        txtNotes.Text = "" & _dr("notes")

        ' build info section
        lblInfo.Text = $"Created by: {_dr("CreatedUser")} on {_dr("DateCreated")}"

        If Not chkActive.Checked Then
            ' the worker is deactivated
            lblInfo.Text += vbCrLf & $"Deactivated by: {_dr("DeactivatedUser")} on {_dr("DateDeactivated")}"
        End If

        lblInfo.Visible = True

    End Sub

    Private Sub SetFormEdit(AllowEditing As Boolean)

        ' set the form to allow (or not) editing of the information 
        For Each ctr As Control In Me.Controls
            If ctr.Name.StartsWith("txt") Then
                DirectCast(ctr, TextBox).ReadOnly = Not AllowEditing
            ElseIf ctr.Name.StartsWith("msk") Then
                DirectCast(ctr, MaskedTextBox).ReadOnly = Not AllowEditing
            ElseIf ctr.Name.StartsWith("chk") Then
                DirectCast(ctr, CheckBox).Enabled = AllowEditing
            End If
        Next

    End Sub

    Private Sub WriteDataToTable()

        ' fill in the table with the data from the form to be saved to the db
        _dr("firstname") = txtFirstName.Text
        _dr("lastname") = txtLastName.Text
        _dr("address") = txtAddress.Text
        _dr("city") = txtCity.Text
        _dr("county") = txtCounty.Text
        _dr("zipcode") = txtZip.Text
        _dr("state") = txtState.Text
        _dr("cellphone") = mskCellPhone.Text
        _dr("homephone") = mskHomePhone.Text
        _dr("emailaddress") = txtEmail.Text
        _dr("active") = chkActive.Checked
        _dr("notes") = txtNotes.Text

        If Not chkActive.Checked Then
            ' the worker is deactivated
            _dr("DeactivatedUser") = frmMDI.currentUser
            _dr("DateDeactivated") = Now
        End If

        If Me.Tag = 0 Then
            ' this is a new worker
            _dr("CreatedUser") = frmMDI.currentUser
            _dr("DateCreated") = Now

            _recordID = _dbLayer.SaveNewWorker(_tb)
            If _recordID = 0 Then
                ' if the record id sent back it zero then there was a problem saving the record
                MsgBox("There was an issue attempting to save the worker")
                Exit Sub
            End If

            Me.Tag = _recordID
        Else
            _dr("LastModifiedUser") = frmMDI.currentUser
            _dr("DateLastModified") = Now

            _recordID = _dbLayer.UpdateRecipient(_tb)
            If _recordID = 0 Then
                MsgBox("There was an issue attempting to save the worker")
            End If
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        If btnToggleEdit.Text = "Stop" Then
            If MsgBox("You are still in Edit Mode, are you sure you'd like to cancel?", MsgBoxStyle.YesNo, "Edit Mode in Progress") = MsgBoxResult.No Then
                Exit Sub
            End If
        End If

        Me.Close()
    End Sub

    Private Sub btnSaveWorker_Click(sender As Object, e As EventArgs) Handles btnSaveWorker.Click

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
        Else

        End If

        lblHeader.Text = "Viewing Worker"
        btnSaveWorker.Visible = False

        Dim frm As frmGridList = frmMDI.IsChildFormOpen("frmGridList")

        If frm IsNot Nothing Then
            ' the gridlist form is displayed, update the grid
            frm.FillGrid()
        End If

        Application.DoEvents()

    End Sub

    Private Sub frmWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set the tag as an integer
        Tag = Int(Me.Tag)

        If Tag > 0 Then
            ' there is a recipient to view/edit in the tag
            GetWorkerData()
            WriteDataToForm()
            lblHeader.Text = "Viewing Worker"
            btnSaveWorker.Visible = False
            btnToggleEdit.Visible = True
        Else
            _tb = _dbLayer.NewWorkerTable()
            _dr = _tb.Rows.Add()
            SetFormEdit(True)
            chkActive.Checked = True  ' default the receipient to active status
        End If

    End Sub

    Private Sub btnToggleEdit_Click(sender As Object, e As EventArgs) Handles btnToggleEdit.Click

        ' toggle the form in and out of edit mode
        If btnToggleEdit.Text = "Edit" Then
            lblHeader.Text = "Editing Worker"
            btnSaveWorker.Visible = True
            btnToggleEdit.Text = "Stop"
            SetFormEdit(True)
        Else
            lblHeader.Text = "Viewing Worker"
            btnSaveWorker.Visible = False
            btnToggleEdit.Text = "Edit"
            SetFormEdit(False)
        End If

        Application.DoEvents()

    End Sub

    Private Sub frmWorker_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        ' make enter act like tab
        If e.KeyChar = Chr(13) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If

    End Sub

    Private Sub frmWorker_Closing(sender As Object, e As CancelEventArgs) Handles MyBase.Closing
        _dbLayer.Dispose()
        _dbLayer = Nothing
    End Sub
End Class