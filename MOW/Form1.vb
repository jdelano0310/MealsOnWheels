Public Class frmMDI

    Private Sub OpenChild(childForm As Form, Optional formMode As String = "")

        childForm.MdiParent = Me
        childForm.Tag = formMode
        childForm.Top = 55
        childForm.Show()

    End Sub

    Private Sub PositionContainersToParentMiddle()
        'Dim xCoordinate As Int16 = (Me.Size.Width - pbLogo.Size.Width) / 2
        'Dim yCoordinate As Int16 = (Me.Size.Height - pbLogo.Size.Height) / 2

        'pbLogo.Location = New Point(xCoordinate, yCoordinate)

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

        PositionContainersToParentMiddle()
    End Sub

    Private Sub frmMDI_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        PositionContainersToParentMiddle()
    End Sub

    Private Sub btnNewDelivery_Click(sender As Object, e As EventArgs) Handles btnNewDelivery.Click


    End Sub

    Private Sub btnNewRecipient_Click(sender As Object, e As EventArgs) Handles btnNewRecipient.Click

        Dim frm As New frmRecipient
        OpenChild(frm)

    End Sub
End Class
