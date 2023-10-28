Imports System.IO
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

    Private Function GetApplicationDatabase() As Boolean

        ' find the database file
        ' if there isn't one saved then ask teh user to point to it's location
        Dim result As Boolean = False

        If My.Settings.DatabaseLocation.Length = 0 Then
            ' there hasn't been a database file pointed yet, is it in the exe path
            MsgBox("Please select the MOW database to use", MsgBoxStyle.Information, "Required Database")

            Dim dbPath As String = Path.Combine(Application.StartupPath, "mow.accdb")
            Dim mowDBSelected As DialogResult

            If Not File.Exists(dbPath) Then
                ' ask the user where the default database is located
                Dim mowDBDlg As New OpenFileDialog

                mowDBDlg.Title = "Select MOW.ACCDB file"
                mowDBDlg.FileName = "mow.accdb"
                mowDBDlg.Filter = "MS Access Databases (*.accdb)|*.accdb"
                mowDBDlg.InitialDirectory = Application.StartupPath

                mowDBSelected = mowDBDlg.ShowDialog()
                Do Until mowDBSelected = DialogResult.OK Or mowDBSelected = DialogResult.Cancel
                    If mowDBDlg.FileName.ToUpper.IndexOf("MOW.ACCDB") > 0 Then
                        My.Settings.DatabaseLocation = mowDBDlg.FileName
                        Exit Do
                    Else
                        MsgBox("Please select the mow.accdb file.", MsgBoxStyle.Exclamation, "Select Database")
                        mowDBSelected = mowDBDlg.ShowDialog()
                    End If
                Loop

                mowDBDlg = Nothing

                result = My.Settings.DatabaseLocation.Length > 0
            Else
                My.Settings.DatabaseLocation = dbPath
            End If

            My.Settings.Save()
        Else
            result = True
        End If

        Return result

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

        If Not GetApplicationDatabase() Then
            If MsgBox("The mow database is required to run this application. Close the app?", MsgBoxStyle.YesNo, "Required Database Missing") = MsgBoxResult.Yes Then
                End
            Else
                frmMDI_Load(sender, e)
            End If
        End If

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
