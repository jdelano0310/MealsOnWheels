Public Class frmRecipient
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSaveRecipient_Click(sender As Object, e As EventArgs) Handles btnSaveRecipient.Click

    End Sub

    Private Sub frmRecipient_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Me.Tag.ToString().Length > 0 Then
            ' there is a recipient to edit in the tag

        End If
    End Sub
End Class