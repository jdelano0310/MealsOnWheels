Imports System.Data.OleDb
Public Class frmGridList
    Private Sub frmGridList_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' resize the grid to match the form
        grdView.Height = (Me.Height - btnPanel.Height) - 39
        grdView.Width = Me.Width - 16

        ' keep add button in its location
        btnNew.Left = Me.Width - 101

    End Sub

    Private Sub frmGridList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load the data list depending on the tag set from the MDI form

        Dim _tb As DataTable = Nothing
        Dim dbLayer As New dbLayer

        Select Case Me.Tag
            Case "Recipients"
                _tb = dbLayer.GetRecipients()

            Case "Workers"
                _tb = dbLayer.Getworkers()

        End Select

        grdView.DataSource = _tb

        ' hide the columns the user doesn't need to see in the grid
        grdView.Columns(0).Visible = False   ' hide ID

        grdView.Columns(15).Visible = False  ' user the deactivated the record
        grdView.Columns(16).Visible = False  ' when it was deactivated

        lblViewing.Text = "Viewing active " & Me.Tag
        Application.DoEvents()

        grdView.EnableHeadersVisualStyles = False

    End Sub

    Private Sub grdView_DoubleClick(sender As Object, e As EventArgs) Handles grdView.DoubleClick
        ' display the record in its for, in edit mode

        Dim recordID As Int16
        Dim grd As DataGridView

        grd = DirectCast(sender, DataGridView)
        recordID = grd.SelectedRows(0).Cells(0).Value

        Select Case Me.Tag
            Case "Recipients"
                Dim frm As New frmRecipient
                frmMDI.OpenChild(frm, recordID)

            Case "Workers"
                Dim frm As New frmWorker
                frmMDI.OpenChild(frm, recordID)

        End Select

    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        Select Case Me.Tag
            Case "Recipients"
                Dim frm As New frmRecipient
                frmMDI.OpenChild(frm, "0")

            Case "Workers"
                Dim frm As New frmWorker
                frmMDI.OpenChild(frm, "0")

        End Select

    End Sub
End Class