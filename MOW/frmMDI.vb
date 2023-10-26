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
    Private Sub RoundButton(btn As Button)

        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0
        'btn.BackColor = Color.Red
        'btn.ForeColor = Color.White
        btn.Cursor = Cursors.Hand
        'btn.Font = New Font("Century Gothic", 14)

        Dim Raduis As New Drawing2D.GraphicsPath

        Raduis.StartFigure()
        'appends an elliptical arc to the current figure
        'left corner top
        Raduis.AddArc(New Rectangle(0, 0, 20, 20), 180, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(10, 0, btn.Width - 20, 0)
        'appends an elliptical arc to the current figure
        'right corner top
        Raduis.AddArc(New Rectangle(btn.Width - 20, 0, 20, 20), -90, 90)
        'appends a line segment to the current figure
        Raduis.AddLine(btn.Width, 20, btn.Width, btn.Height - 10)
        'appends an elliptical arc to the current figure 
        'right corner buttom
        Raduis.AddArc(New Rectangle(btn.Width - 25, btn.Height - 25, 25, 25), 0, 90)
        'appends a line segment to the current figure
        'left corner bottom
        Raduis.AddLine(btn.Width - 10, btn.Width, 20, btn.Height)
        'appends an elliptical arc to the current figure
        Raduis.AddArc(New Rectangle(0, btn.Height - 20, 20, 20), 90, 90)
        'Close the current figure and start a new one.
        Raduis.CloseFigure()
        'set the window associated with the control
        btn.Region = New Region(Raduis)

    End Sub

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

        'For Each c As Control In btnPanel.Controls
        '    If TypeOf c Is Button Then
        '        RoundButton(c)
        '    End If
        'Next

    End Sub

    Private Sub frmMDI_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        ' this is required to update the location of the logo
        Me.Refresh()
    End Sub

    Private Sub btnNewDelivery_Click(sender As Object, e As EventArgs) Handles btnNewDelivery.Click

        Dim frm As New frmDelivery
        OpenChild(frm, "0")

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
