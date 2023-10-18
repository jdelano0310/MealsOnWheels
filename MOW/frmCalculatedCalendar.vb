Public Class frmCalculatedCalendar
    Private Sub frmCalculatedCalendar_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' resize the grid to match the form
        grdView.Height = (Me.Height - btnPanel.Height) - 39
        grdView.Width = Me.Width - 16
    End Sub
End Class