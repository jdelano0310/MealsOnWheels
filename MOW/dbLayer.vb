Imports System.Data.OleDb
Imports System.Net.NetworkInformation
Imports System.Runtime.InteropServices.JavaScript.JSType

Public Class dbLayer

    Private _dbFile As String = "C:\Users\jd310\Documents\MOW_Dev.accdb"
    Private _cn As New OleDbConnection
    Private _cnStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & _dbFile
    Private _ds As New DataSet
    Private _da As OleDbDataAdapter
    Private _tb As DataTable
    Private _recordID As Long

    Public Sub New()

        ' when this class is initialized, open a connection to the db
        _cn.ConnectionString = _cnStr
        _cn.Open()

    End Sub

    Public Sub Dispose()

    End Sub

    Public ReadOnly Property NewRecipientTable() As DataTable
        Get
            ' just returns an empty table with the needed columns to create a new record
            _da = New OleDbDataAdapter("Select * from tblMealRecipients where id=0", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property
    Public Property RecordID As Long
        Get
            Return _recordID
        End Get
        Set(value As Long)
            _recordID = value
        End Set
    End Property
    Public ReadOnly Property GetRecipient() As DataTable
        Get
            _da = New OleDbDataAdapter($"Select * from tblMealRecipients where id={_recordID}", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public ReadOnly Property GetRecipients() As DataTable
        Get
            _da = New OleDbDataAdapter("Select * from qryActiveRecipients", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public Function SaveRecipient(tbl As DataTable) As Boolean

        _cn.Open()

        _da = New OleDbDataAdapter($"Select * from tblMealRecipients Where ID={_recordID}", _cn)
        _da.Fill(_ds, "tablename")
        _tb = _ds.Tables(0)

        Dim dr As DataRow
        Dim frmDr As DataRow = tbl.Rows(0)

        If _recordID = 0 Then
            ' a new recipient is being saved
            dr = _tb.NewRow()
            For Each clm As DataColumn In tbl.Columns
                dr(clm.ColumnName) = frmDr(clm.ColumnName)
            Next
            _tb.Rows.Add()
        Else
            ' editing an existing recipient
            dr = _tb.Rows(0)
            For Each clm As DataColumn In tbl.Columns
                dr(clm.ColumnName) = frmDr(clm.ColumnName)
            Next

        End If

        _cn.Close()

        Return True

    End Function

    Public ReadOnly Property Getworkers() As DataTable
        Get
            _da = New OleDbDataAdapter("Select * from qryActiveWorkers", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

End Class
