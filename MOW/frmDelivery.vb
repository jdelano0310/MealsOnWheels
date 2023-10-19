Public Class frmDelivery

    Dim _tb As DataTable = Nothing
    Dim dbLayer As New dbLayer

    Private Sub frmDelivery_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load recipients into combodox

        _tb = dbLayer.GetRecipients

        cboRecipients.DataSource = _tb
        cboRecipients.DisplayMember = "fullname"
        cboRecipients.ValueMember = "ID"

        dpStarting.MinDate = Now
        dpStarting.MaxDate = Now.AddDays(365)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class