Imports System.Data.OleDb
Public Class frmGridList
    Private Sub frmGridList_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' resize the grid to match the form
        grdView.Height = (Me.Height - btnPanel.Height) - 39
        grdView.Width = Me.Width - 16

    End Sub

    Private Sub frmGridList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' load the data list depending on the tag set from the MDI form

        Dim SQL As String = ""

        Select Case Me.Tag
            Case "Recipients"
                SQL = "Select * from qryActiveRecipients"
            Case "Workers"
                SQL = "Select * from qryActiveWorkers"
        End Select

        grdView.DataSource = GetData(SQL)

        ' hide the columns the user doesn't need to see in the grid
        grdView.Columns(0).Visible = False   ' hide ID

        grdView.Columns(15).Visible = False  ' user the deactivated the record
        grdView.Columns(16).Visible = False  ' when it was deactivated

        lblViewing.Text = "Viewing " & Me.Tag
        Application.DoEvents()

        grdView.EnableHeadersVisualStyles = False

    End Sub

    Private Function GetData(SQL As String) As DataTable

        Dim accessDataFile As String = "C:\Users\jd310\Documents\MOW_Dev.accdb"

        Dim cn As New OleDbConnection
        Dim cnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & accessDataFile

        cn.ConnectionString = cnStr
        cn.Open()

        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Dim tb As DataTable

        da = New OleDbDataAdapter(SQL, cn)
        da.Fill(ds, Me.Tag)
        tb = ds.Tables(0)

        cn.Close()

        Return tb

    End Function

    Private Sub grdView_DoubleClick(sender As Object, e As EventArgs) Handles grdView.DoubleClick
        ' display the record in its for, in edit mode

        Dim recordID As Int16
        Dim grd As DataGridView

        grd = DirectCast(sender, DataGridView)
        recordID = grd.SelectedRows(0).Cells(0).Value

        'DirectCast((New System.Collections.ArrayList.ArrayListDebugView(DirectCast(sender, System.Windows.Forms.DataGridView).SelectedCells.List).Items(0)), System.Windows.Forms.DataGridViewCell).Value
        Select Case Me.Tag
            Case "Recipients"
                Dim frm As New frmRecipient
                frmMDI.OpenChild(frm, $"Edit-{recordID}")

            Case "Workers"

        End Select

    End Sub
End Class