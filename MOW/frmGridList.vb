Imports System.Data.OleDb
Public Class frmGridList
    Private Sub frmGridList_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        ' resize the grid to match the form
        grdView.Height = (Me.Height - btnPanel.Height) - 35
        grdView.Width = Me.Width - 5

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

        lblViewing.Text = "Viewing " & Me.Tag
        Application.DoEvents()

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

End Class