﻿Imports System.ComponentModel

Public Class frmWorker
    Dim _tb As DataTable = Nothing
    Dim _dr As DataRow
    Dim _dbLayer As New dbLayer
    Dim _recordID As Long = 0

    Public Note As String
    Dim _deliveriesLeft As Integer

    Dim _dtAvail As New DataTable
    Dim _currentGridRow As Int16
    Dim _currentGridCol As Int16
    Dim _currentDTPicker As DateTimePicker


    Private Sub GetWorkerData()

        ' the record id is in the tag property of the form
        _recordID = Me.Tag

        _dbLayer.RecordID = _recordID
        _tb = _dbLayer.GetWorker()
        _dtAvail = _dbLayer.GetWorkersAvailability(_recordID)

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

        If _dr("LastModifiedUser").ToString().Length > 0 Then
            lblInfo.Text += vbCrLf & $"Modified by: {_dr("LastModifiedUser")} on {_dr("DateLastModified")}"
        End If

        If Not chkActive.Checked Then
            ' the worker is deactivated
            lblInfo.Text += vbCrLf & $"Deactivated by: {_dr("DeactivatedUser")} on {_dr("DateDeactivated")}"
        End If

        ' must refresh the datasource with the updated table data
        grdAvailable.DataSource = _dtAvail

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
            ElseIf ctr.Name.StartsWith("grd") Then
                DirectCast(ctr, DataGridView).ReadOnly = Not AllowEditing
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
            _dr("notes") = txtNotes.Text & vbCrLf & Note

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

            If Not _dbLayer.SaveWorkerAvailability(_dtAvail, "Insert") Then
                MsgBox("There was an issue attempting to save the worker availability")
            End If

            Me.Tag = _recordID
        Else
            _dr("LastModifiedUser") = frmMDI.currentUser
            _dr("DateLastModified") = Now

            _recordID = _dbLayer.UpdateWorker(_tb)
            If _recordID = 0 Then
                MsgBox("There was an issue attempting to save the worker")
            Else
                If Not _dbLayer.SaveWorkerAvailability(_dtAvail, "Update") Then
                    MsgBox("There was an issue attempting to save the worker availability")
                End If

                If Not chkActive.Checked And _deliveriesLeft > 0 Then
                    ' you can only cancel deliveries for a pre-existing receipient
                    _dbLayer.CancelWorkersUpcomingDeliveries(frmMDI.currentUser, Note)

                    If _dbLayer.RecordID = 0 Then
                        MsgBox("There was a problem cancelling the upcoming deliveries for this worker", MsgBoxStyle.Critical, "Deactivate Worker")
                    Else
                        MsgBox("The worker's upcoming deliveries have been cancelled.", MsgBoxStyle.Information, "Deactivate Worker")
                    End If

                End If

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
                ' if a new receipient, change the view of the form
                btnToggleEdit.Visible = True

            Else
                ' of an edit to a previous worker
                btnToggleEdit.Text = "Edit"

            End If
            SetFormEdit(False)

            ' build info section
            lblInfo.Text = $"Created by: {_dr("CreatedUser")} on {_dr("DateCreated")}"

            If _dr("LastModifiedUser").ToString().Length > 0 Then
                lblInfo.Text += vbCrLf & $"Modified by: {_dr("LastModifiedUser")} on {_dr("DateLastModified")}"
            End If

            If Not chkActive.Checked Then
                ' the worker is deactivated
                lblInfo.Text += vbCrLf & $"Deactivated by: {_dr("DeactivatedUser")} on {_dr("DateDeactivated")}"
            End If

            Dim frm As frmGridList = frmMDI.IsChildFormOpen("frmGridList")

            If frm IsNot Nothing Then
                ' the gridlist form is displayed, update the grid
                frm.FillGrid()
            End If

            Application.DoEvents()

        Else

        End If

        lblHeader.Text = "Viewing Worker"
        btnSaveWorker.Visible = False

    End Sub

    Private Sub frmWorker_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set the tag as an integer
        Tag = Int(Me.Tag)

        BuildAvailabilityGrid()

        If Tag > 0 Then
            ' there is a worker to view/edit in the tag
            GetWorkerData()
            WriteDataToForm()
            lblHeader.Text = "Viewing Worker"
            btnSaveWorker.Visible = False
            btnToggleEdit.Visible = True
        Else
            _tb = _dbLayer.NewWorkerTable()
            _dr = _tb.Rows.Add()

            SetFormEdit(True)
            chkActive.Checked = True  ' default the worker to active status
        End If

    End Sub

    Private Sub BuildAvailabilityGrid()

        ' create the table that will be used to hold and display the workers
        ' available delivery schedule

        With _dtAvail
            .Columns.Add("TimeHeader", GetType(String))
            .Columns.Add("Sunday", GetType(String))
            .Columns.Add("Monday", GetType(String))
            .Columns.Add("Tuesday", GetType(String))
            .Columns.Add("Wednesday", GetType(String))
            .Columns.Add("Thursday", GetType(String))
            .Columns.Add("Friday", GetType(String))
            .Columns.Add("Saturday", GetType(String))
            .Columns.Add("WorkerID", GetType(Long))
            .Columns.Add("ID", GetType(Long))
        End With

        _dtAvail.Rows.Add("From", "", "", "", "", "", "", "")
        _dtAvail.Rows.Add("To", "", "", "", "", "", "", "")

        grdAvailable.DataSource = _dtAvail
        grdAvailable.EnableHeadersVisualStyles = False


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

    Private Sub chkActive_Click(sender As Object, e As EventArgs) Handles chkActive.Click

        If Not chkActive.Checked And Me.Tag > 0 Then
            ' deactivating the worker
            ' check for remaining scheduled deliveries
            ' ask why

            _deliveriesLeft = _dbLayer.GetWorkersRemainingDeliveries(Me.Tag)

            If _deliveriesLeft > 0 Then
                If MsgBox($"Deactivating the worker will cancel their {_deliveriesLeft} remaining deliveries, a new delivery person will need to be selected, are you sure?",
                          MsgBoxStyle.YesNo, "Confirm") = MsgBoxResult.No Then

                    ' if they decide against this, recheck the box and exit this code
                    chkActive.Checked = True
                    Exit Sub
                End If
            End If

            Note = ""

            Dim frm As New frmNotes
            frm.lblHeader.Text = "Add Notes"
            frm.lblWhyANoteIsNeeded.Text = "Please indicate why this worker is being deactivated."
            frm.Tag = "worker"

            frm.ShowDialog(Me)

            If Note = "Cancel" Then
                ' they've canceled the process
                'MsgBox("You've canceled the deactivation process", MsgBoxStyle.Information, "Deactivate Worker")
                chkActive.Checked = True
                Exit Sub
            End If

        End If
    End Sub

    Private Sub grdAvailable_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grdAvailable.CellEndEdit

        ' the user is done editing the value, put it in the table used as the record source
        Dim dr As DataRow = _dtAvail.Rows.Item(_currentGridRow)
        dr(_currentGridCol - 2) = _currentDTPicker.Value.ToString("hh:mm tt")

        ' remove the datepicker from the grid 
        grdAvailable.Controls.Remove(_currentDTPicker)

        _currentDTPicker = Nothing
        _currentGridRow = -1
        _currentGridCol = -1

    End Sub

    Private Sub grdAvailable_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grdAvailable.CellBeginEdit

        If e.ColumnIndex > 0 And grdAvailable.ReadOnly = False Then
            ' the user has clicked in a day column
            _currentGridRow = e.RowIndex
            _currentGridCol = e.ColumnIndex

            Dim currentValue As String = grdAvailable.Rows(_currentGridRow).Cells(_currentGridCol).Value

            ' create the selection control to place in the grid
            Dim dateTimePicker As New DateTimePicker
            Dim dtPickerName As String = grdAvailable.Columns(_currentGridCol).HeaderText & "-" & grdAvailable.Rows(_currentGridRow).Cells(4).Value
            Dim rectangle As Rectangle = grdAvailable.GetCellDisplayRectangle(_currentGridCol, _currentGridRow, True)

            grdAvailable.Controls.Add(dateTimePicker)

            With dateTimePicker
                .Name = dtPickerName
                .Format = DateTimePickerFormat.Custom
                .CustomFormat = "hh:mm tt"
                .ShowUpDown = True
                .Size = New Size(rectangle.Width, rectangle.Height)
                .Location = New Point(rectangle.X, rectangle.Y)
                .Visible = True
            End With

            _currentDTPicker = dateTimePicker

            If currentValue.Length > 0 Then
                ' the current cell has a value, display it in the picker
                dateTimePicker.Value = Convert.ToDateTime(currentValue)
            End If
        End If
    End Sub

End Class