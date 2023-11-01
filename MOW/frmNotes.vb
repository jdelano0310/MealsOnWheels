﻿Public Class frmNotes
    Private callingForm

    Private Sub btnSaveNote_Click(sender As Object, e As EventArgs) Handles btnSaveNote.Click

        If txtNotes.Text.Length < 25 Then
            MsgBox($"Please enter at least 25 characters for the reason you're deactivating this {Me.Tag}.", MsgBoxStyle.Exclamation, "Notes")
            Exit Sub
        End If

        callingForm.deactivateNote = txtNotes.Text

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        callingForm.deactivateNote = "Cancel"
        Me.Close()

    End Sub

    Private Sub frmNotes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set the parent form that called this notes popup
        Select Case Me.Tag
            Case "recipient"
                callingForm = DirectCast(Me.Parent, frmRecipient)
            Case "worker"
                callingForm = DirectCast(Me.Parent, frmWorker)
            Case Else
                MsgBox("Unknown calling form")
        End Select

    End Sub
End Class