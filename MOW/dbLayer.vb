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
    Private _cmd As OleDbCommand
    Private _rdr As OleDbDataReader

    Structure dbError
        Public Message As String
        Public Num As String
    End Structure

    Private _dbError As dbError
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

    Public ReadOnly Property ErrorInfo As dbError
        Get
            Return _dbError
        End Get
    End Property

    Public ReadOnly Property Getworkers() As DataTable
        Get
            _da = New OleDbDataAdapter("Select * from qryActiveWorkers", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public Function SaveNewRecipient(tbl As DataTable) As Long

        InsertRecordFromTable("tblMealRecipients", tbl)

        Return _recordID

    End Function

    Public Function SaveNewWorker(tbl As DataTable) As Long

        InsertRecordFromTable("tblWorkers", tbl)

        Return _recordID

    End Function

    Private Sub InsertRecordFromTable(toTableName As String, fromTable As DataTable)

        ' a new record is being saved
        Dim frmDr As DataRow = fromTable.Rows(0)
        Dim SQL As String = $"Insert Into {toTableName} ("
        Dim sqlValues As String = ""

        _cn.Open()
        _recordID = 0

        Try
            ' build the insert query using the fieldnames and values from the table passsed in
            For Each clm As DataColumn In fromTable.Columns
                If clm.ColumnName <> "ID" Then
                    ' don't include the ID field
                    SQL += $"{clm.ColumnName},"
                    If clm.ColumnName = "Active" Then
                        sqlValues += $"{frmDr(clm.ColumnName)},"
                    ElseIf clm.ColumnName.IndexOf("Date") > -1 Then
                        If frmDr(clm.ColumnName).ToString.Length > 0 Then
                            sqlValues += $"#{frmDr(clm.ColumnName)}#,"
                        Else
                            sqlValues += "Null,"
                        End If
                    Else
                        sqlValues += $"'{frmDr(clm.ColumnName)}',"
                    End If
                End If
            Next

            SQL = SQL.Substring(0, SQL.Length - 1) & ") values ("
            SQL += sqlValues.Substring(0, sqlValues.Length - 1) & ")"

            _cmd = New OleDbCommand(SQL, _cn)
            _rdr = _cmd.ExecuteReader()
            If _rdr.Item(0) > 0 Then
                ' record saved correctly - return the new id number
                CleanUp()
                SetNewRecordID(toTableName)
            End If

        Catch ex As Exception
            _dbError.Message = ex.Message
            _dbError.Num = ex.StackTrace
        End Try

        CleanUp()
    End Sub

    Private Sub SetNewRecordID(tableName As String)

        ' get the new ID created from the previous insert, place it in the record id property
        _cmd = New OleDbCommand($"Select @@Identity from {tableName}", _cn)
        _rdr = _cmd.ExecuteReader()
        _recordID = _rdr.Item(0)

    End Sub

    Private Sub CleanUp()

        ' attempt to close any readers or commands
        Try
            _rdr.Close()
            _cmd.Dispose()

        Catch

        End Try

        _rdr = Nothing
        _cmd = Nothing

    End Sub
End Class
