Imports Microsoft

Public Class frmMDI

    Public currentUser As String

    Public Sub OpenChild(childForm As Form, Optional formMode As String = "")

        childForm.MdiParent = Me
        childForm.Tag = formMode
        childForm.StartPosition = FormStartPosition.CenterScreen
        childForm.Show()

    End Sub

    Public Function IsChildFormOpen(frmName As String) As Form

        Dim foundForm As Form = Nothing

        For Each frm As Form In Me.MdiChildren
            If frm.Name = frmName And frm.Visible Then
                foundForm = frm
            End If
        Next

        Return foundForm

    End Function

    Private Sub frmMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' set the background color of the main form
        Dim myColor As Color = System.Drawing.ColorTranslator.FromHtml("#003851")

        For Each ctrl As Control In Me.Controls
            If TypeOf ctrl Is MdiClient Then
                ctrl.BackColor = myColor
                Exit For
            End If
        Next

        currentUser = Environ("username")
        lblCurrentUser.Text = currentUser

    End Sub

    Private Sub frmMDI_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' this is required to update the location of the logo
        Me.Refresh()
    End Sub

    Private Sub btnNewDelivery_Click(sender As Object, e As EventArgs) Handles btnNewDelivery.Click


    End Sub

    Private Sub btnNewRecipient_Click(sender As Object, e As EventArgs) Handles btnNewRecipient.Click

        Dim frm As New frmRecipient
        OpenChild(frm, "0")

    End Sub

    Private Sub btnRecipients_Click(sender As Object, e As EventArgs) Handles btnRecipients.Click

        Dim frm As New frmGridList
        OpenChild(frm, "Recipients")

    End Sub

    Private Sub btnWorkers_Click(sender As Object, e As EventArgs) Handles btnWorkers.Click
        Dim frm As New frmGridList
        OpenChild(frm, "Workers")

    End Sub

    Private Sub btnViewDeliveryCalendar_Click(sender As Object, e As EventArgs) Handles btnViewDeliveryCalendar.Click
        Dim frm As New frmCalculatedCalendar
        OpenChild(frm, "0")

    End Sub
End Class
