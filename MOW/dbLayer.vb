Imports System.Data.OleDb
Imports System.IO
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

    Public ReadOnly Property GetActiveWorkersWithDeliveries() As DataTable
        Get
            ' returns those workers that have deliveries scheduled
            _da = New OleDbDataAdapter("Select 0 as ID, 'Select Worker' as fullname from tblWorkers union Select * from qryActiveWorkersWithDeliveries", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public ReadOnly Property GetActiveRecipientsWithDeliveries() As DataTable
        Get
            ' returns those recipients that have deliveries scheduled
            _da = New OleDbDataAdapter("Select 0 as ID, 'Select Recipient' as fullname, '' from tblMealRecipients union Select * from qryActiveRecipientsWithDeliveries", _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public ReadOnly Property GetCalculatedDeliveryDates() As DataSet
        Get
            ' returns delivery dates that have scheduled deliveries
            _da = New OleDbDataAdapter("Select ' Select From Date' as DeliveryDateOnly from tblMealRecipients union Select * from qryCalculatedDeliveryDatesASC", _cn)
            _da.Fill(_ds, "Ascending")

            _da = New OleDbDataAdapter("Select ' Select To Date' as DeliveryDateOnly from tblMealRecipients union Select * from qryCalculatedDeliveryDatesDESC", _cn)
            _da.Fill(_ds, "Descending")

            _cn.Close()

            Return _ds
        End Get
    End Property

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

    Public ReadOnly Property NewWorkerTable() As DataTable
        Get
            ' just returns an empty table with the needed columns to create a new record
            _da = New OleDbDataAdapter("Select * from tblWorkers where id=0", _cn)
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

    Public ReadOnly Property GetWorker() As DataTable
        Get
            _da = New OleDbDataAdapter($"Select * from tblWorkers where id={_recordID}", _cn)
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

    Public ReadOnly Property GetDeliveryCalendar(secondCriteria As String) As DataTable
        Get
            Dim SQL As String
            SQL = "SELECT [tblCalculatedDeliveryCalendar].[ID], DeliveryCalendarID, tblCalculatedDeliveryCalendar.DeliveryDate, "
            SQL += "[tblMealRecipients].[LastName]+', '+[tblMealRecipients].[FirstName] AS Recipient, "
            SQL += "[tblWorkers].[LastName]+', '+[tblWorkers].[FirstName] AS Deliverer "
            SQL += "FROM (tblCalculatedDeliveryCalendar "
            SQL += "INNER JOIN tblWorkers ON tblCalculatedDeliveryCalendar.WorkerID = tblWorkers.ID) "
            SQL += "INNER JOIN tblMealRecipients ON tblCalculatedDeliveryCalendar.RecipientID = tblMealRecipients.ID "
            SQL += "WHERE (((tblCalculatedDeliveryCalendar.DeliveryDate)>=Date()) AND "
            SQL += secondCriteria

            _da = New OleDbDataAdapter(SQL, _cn)
            _da.Fill(_ds, "tablename")
            _tb = _ds.Tables(0)

            _cn.Close()

            Return _tb
        End Get
    End Property

    Public ReadOnly Property GetDeliveryCalendarByDate(fromDate As String, toDate As String) As DataTable
        Get
            Dim SQL As String
            SQL = "SELECT [tblCalculatedDeliveryCalendar].[ID], DeliveryCalendarID, tblCalculatedDeliveryCalendar.DeliveryDate, "
            SQL += "[tblMealRecipients].[LastName]+', '+[tblMealRecipients].[FirstName] AS Recipient, "
            SQL += "[tblWorkers].[LastName]+', '+[tblWorkers].[FirstName] AS Deliverer "
            SQL += "FROM (tblCalculatedDeliveryCalendar "
            SQL += "INNER JOIN tblWorkers ON tblCalculatedDeliveryCalendar.WorkerID = tblWorkers.ID) "
            SQL += "INNER JOIN tblMealRecipients ON tblCalculatedDeliveryCalendar.RecipientID = tblMealRecipients.ID "
            SQL += "WHERE tblCalculatedDeliveryCalendar.DeliveryDate BETWEEN #" + fromDate + "# AND #" + toDate + "# "
            SQL += "ORDER By tblCalculatedDeliveryCalendar.DeliveryDate ASC"

            _da = New OleDbDataAdapter(SQL, _cn)
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

    Public Function UpdateRecipient(tbl As DataTable) As Long

        UpdateRecordFromTable("tblMealRecipients", tbl)

        Return _recordID

    End Function


    Public Function SaveNewWorker(tbl As DataTable) As Long

        InsertRecordFromTable("tblWorkers", tbl)

        Return _recordID

    End Function

    Public Function UpdateWorker(tbl As DataTable) As Long

        UpdateRecordFromTable("tblWorkers", tbl)

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
                        If frmDr(clm.ColumnName).ToString().IndexOf("'") > -1 Then
                            ' the text value contains a single quote which needs to be replaced
                            ' to add this to the query string
                            sqlValues += $"'{frmDr(clm.ColumnName).frmDr(clm.ColumnName).ToString().Replace("'", "''")}',"
                        Else
                            sqlValues += $"'{frmDr(clm.ColumnName)}',"
                        End If

                    End If
                End If
            Next

            SQL = SQL.Substring(0, SQL.Length - 1) & ") values ("
            SQL += sqlValues.Substring(0, sqlValues.Length - 1) & ")"

            _cmd = New OleDbCommand(SQL, _cn)
            _rdr = _cmd.ExecuteReader()
            If _rdr.RecordsAffected > 0 Then
                ' record saved correctly - return the new id number
                CleanUp()
                SetNewRecordID(toTableName)
            End If

        Catch ex As Exception
            _dbError.Message = ex.Message
            _dbError.Num = ex.StackTrace
            CreateDbLogFile("InsertRecordFromTable", (SQL & vbCrLf & ex.Message))
        End Try

        CleanUp()
    End Sub

    Private Sub UpdateRecordFromTable(toTableName As String, fromTable As DataTable)

        ' a new record is being saved
        Dim frmDr As DataRow = fromTable.Rows(0)
        Dim SQL As String = $"Update {toTableName} Set "
        Dim successfullSave As Boolean = False

        _cn.Open()

        Try
            ' build the update query using the fieldnames and values from the table passsed in
            For Each clm As DataColumn In fromTable.Columns
                If clm.ColumnName <> "ID" Then
                    ' don't include the ID field
                    SQL += $"{clm.ColumnName} = "
                    If clm.ColumnName = "Active" Then
                        SQL += $"{frmDr(clm.ColumnName)},"
                    ElseIf clm.ColumnName.IndexOf("Date") > -1 Then
                        If frmDr(clm.ColumnName).ToString.Length > 0 Then
                            SQL += $"#{frmDr(clm.ColumnName)}#,"
                        Else
                            SQL += "Null,"
                        End If
                    Else
                        If frmDr(clm.ColumnName).ToString().IndexOf("'") > -1 Then
                            ' the text value contains a single quote which needs to be replaced
                            ' to add this to the query string
                            SQL += $"'{frmDr(clm.ColumnName).frmDr(clm.ColumnName).ToString().Replace("'", "''")}',"
                        Else
                            SQL += $"'{frmDr(clm.ColumnName)}',"
                        End If

                    End If
                End If
            Next

            ' remove the last coma and add the ID that is being updated
            SQL = SQL.Substring(0, SQL.Length - 1) & $" Where ID = {_recordID}"

            _cmd = New OleDbCommand(SQL, _cn)
            _rdr = _cmd.ExecuteReader()
            If _rdr.RecordsAffected = 0 Then
                ' record was not saved
                CreateDbLogFile("UpdateRecordFromTable", (SQL & vbCrLf & "No record affected"))
                _recordID = 0
            End If

        Catch ex As Exception
            _dbError.Message = ex.Message
            _dbError.Num = ex.StackTrace
            _recordID = 0
            CreateDbLogFile("UpdateRecordFromTable", (SQL & vbCrLf & ex.Message))
        End Try

        CleanUp()

    End Sub

    Private Sub SetNewRecordID(tableName As String)

        ' get the new ID created from the previous insert, place it in the record id property
        _cmd = New OleDbCommand($"Select @@Identity from {tableName}", _cn)
        _rdr = _cmd.ExecuteReader()
        _rdr.Read()
        _recordID = _rdr.GetInt32(0)

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

    Private Sub CreateDbLogFile(errWhere As String, errMessage As String)

        ' write any errors encountered to a log file to help in diagnostics
        Dim strFile As String = $"{Application.StartupPath()}\DbLayerErrorLog_{DateTime.Today.ToString("dd-MMM-yyyy")}.txt"
        Dim fs As FileStream = Nothing
        Using sw As StreamWriter = New StreamWriter(File.Open(strFile, FileMode.Append))
            sw.WriteLine($"{DateTime.Now:f}: Error in {errWhere} code")
            sw.WriteLine(errMessage)
            sw.WriteLine("-------------------------------------------------------------------------------------")
        End Using

    End Sub

End Class
