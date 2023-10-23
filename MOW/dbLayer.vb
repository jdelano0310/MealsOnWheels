Imports System.Data.OleDb
Imports System.IO

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

        ' try to close all possible objects - don't care if anything complains
        On Error Resume Next
        _tb.Dispose()
        _ds.Dispose()
        _da.Dispose()
        _rdr.Close()
        _cmd.Dispose()
        _cn.Close()

        _tb = Nothing
        _ds = Nothing
        _da = Nothing
        _rdr = Nothing
        _cmd = Nothing
        _cn = Nothing

    End Sub

    Public ReadOnly Property GetActiveWorkersWithDeliveries() As DataTable
        Get
            ' returns those workers that have deliveries scheduled
            Return CreateNewTable("Select 0 as ID, 'Select Worker' as fullname from tblWorkers union Select * from qryActiveWorkersWithDeliveries")

        End Get
    End Property

    Public ReadOnly Property GetActiveRecipientsWithDeliveries() As DataTable
        Get
            ' returns those recipients that have deliveries scheduled
            Return CreateNewTable("Select 0 as ID, 'Select Recipient' as fullname, '' from tblMealRecipients union Select * from qryActiveRecipientsWithDeliveries")

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

    Public ReadOnly Property NewDelieryTable() As DataTable
        Get
            ' just returns an empty table with the needed columns to create a new record
            Return CreateNewTable("Select * from tblDeliveryCalendar where id=0")

        End Get
    End Property

    Public ReadOnly Property NewRecipientTable() As DataTable
        Get
            ' just returns an empty table with the needed columns to create a new record
            Return CreateNewTable("Select * from tblMealRecipients where id=0")

        End Get
    End Property

    Public ReadOnly Property NewWorkerTable() As DataTable
        Get

            ' just returns an empty table with the needed columns to create a new record
            Return CreateNewTable("Select * from tblWorkers where id=0")
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

            Return CreateNewTable($"Select * from tblMealRecipients where id={_recordID}")
        End Get
    End Property

    Public ReadOnly Property GetWorker() As DataTable
        Get

            Return CreateNewTable($"Select * from tblWorkers where id={_recordID}")
        End Get
    End Property

    Public ReadOnly Property GetRecipients() As DataTable
        Get

            Return CreateNewTable("Select * from qryActiveRecipients")
        End Get
    End Property

    Public ReadOnly Property GetRecipientsForDelivery() As DataTable
        Get
            Dim SQL As String
            SQL = "Select -1 as ID, 'Select Recipient' as fullname from tblMealRecipients union "
            SQL += "Select id, LastName + ',' + FirstName as fullname from qryActiveRecipients "

            Return CreateNewTable(SQL)
        End Get
    End Property

    Public ReadOnly Property GetWorkersForDelivery() As DataTable
        Get
            Dim SQL As String
            SQL = "Select -1 as ID, 'Select Worker' as fullname from tblWorkers union "
            SQL += "Select id, LastName + ',' + FirstName as fullname from qryActiveWorkers "

            Return CreateNewTable(SQL)
        End Get
    End Property

    Public ReadOnly Property GetDelivery() As DataTable
        Get
            Dim SQL As String
            SQL = "Select -1 as ID, 'Select Recipient' as fullname from tblMealRecipients union "
            SQL += "Select id, LastName + ',' + FirstName as fullname from qryActiveRecipients "

            Return CreateNewTable(SQL)
        End Get
    End Property

    Public ReadOnly Property ErrorInfo As dbError
        Get
            Return _dbError
        End Get
    End Property

    Public ReadOnly Property Getworkers() As DataTable
        Get

            Return CreateNewTable("Select * from qryActiveWorkers")
        End Get
    End Property

    Public ReadOnly Property GetDeliveryCalendar(secondCriteria As String) As DataTable
        Get
            Dim SQL As String
            SQL = "SELECT [tblCalculatedDeliveryCalendar].[ID], DeliveryCalendarID, tblCalculatedDeliveryCalendar.ScheduledDeliveryDate, "
            SQL += "[tblMealRecipients].[LastName]+', '+[tblMealRecipients].[FirstName] AS Recipient, "
            SQL += "[tblWorkers].[LastName]+', '+[tblWorkers].[FirstName] AS Deliverer "
            SQL += "FROM (tblCalculatedDeliveryCalendar "
            SQL += "INNER JOIN tblWorkers ON tblCalculatedDeliveryCalendar.WorkerID = tblWorkers.ID) "
            SQL += "INNER JOIN tblMealRecipients ON tblCalculatedDeliveryCalendar.RecipientID = tblMealRecipients.ID "
            SQL += $"WHERE (((tblCalculatedDeliveryCalendar.ScheduledDeliveryDate)>=Date()) AND {secondCriteria}"

            Return CreateNewTable(SQL)
        End Get
    End Property

    Public ReadOnly Property GetDeliveryCalendarByDate(fromDate As String, toDate As String) As DataTable
        Get
            Dim SQL As String
            SQL = "SELECT [tblCalculatedDeliveryCalendar].[ID], DeliveryCalendarID, tblCalculatedDeliveryCalendar.ScheduledDeliveryDate, "
            SQL += "[tblMealRecipients].[LastName]+', '+[tblMealRecipients].[FirstName] AS Recipient, "
            SQL += "[tblWorkers].[LastName]+', '+[tblWorkers].[FirstName] AS Deliverer "
            SQL += "FROM (tblCalculatedDeliveryCalendar "
            SQL += "INNER JOIN tblWorkers ON tblCalculatedDeliveryCalendar.WorkerID = tblWorkers.ID) "
            SQL += "INNER JOIN tblMealRecipients ON tblCalculatedDeliveryCalendar.RecipientID = tblMealRecipients.ID "
            SQL += $"WHERE tblCalculatedDeliveryCalendar.ScheduledDeliveryDate BETWEEN #{fromDate}# AND #{toDate}# "
            SQL += "ORDER By tblCalculatedDeliveryCalendar.ScheduledDeliveryDate ASC"

            Return CreateNewTable(SQL)

        End Get
    End Property

    Private Function CreateNewTable(SQL As String) As DataTable

        _da = New OleDbDataAdapter(SQL, _cn)

        _ds = New DataSet
        _da.Fill(_ds, "tablename")

        _tb = New DataTable
        _tb = _ds.Tables(0)

        _cn.Close()

        Return _tb

    End Function

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

    Public Function SaveNewDelivery(tbl As DataTable) As Long

        InsertRecordFromTable("tblDeliveryCalendar", tbl)
        CreateCalculatedDeliveryCalendarRecords(tbl)

        Return _recordID

    End Function

    Public Function UpdateDelivery(tbl As DataTable) As Long

        UpdateRecordFromTable("tblDeliveryCalendar", tbl)

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

            SQL = String.Concat(SQL.AsSpan(0, SQL.Length - 1), ") values (")
            SQL += String.Concat(sqlValues.AsSpan(0, sqlValues.Length - 1), ")")

            _cmd = New OleDbCommand(SQL, _cn)
            _rdr = _cmd.ExecuteReader()
            If _rdr.RecordsAffected > 0 Then
                ' record saved correctly - return the new id number
                CleanUp()
                SetNewRecordID(toTableName)
            End If

        Catch ex As Exception
            _dbError.Message = ex.Message
            CreateDbLogFile("InsertRecordFromTable", (SQL & vbCrLf & ex.Message), ex.StackTrace)
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
                CreateDbLogFile("UpdateRecordFromTable", (SQL & vbCrLf & "No record affected"), "Line: 375")
                _recordID = 0
            End If

        Catch ex As Exception
            _dbError.Message = ex.Message
            _recordID = 0
            CreateDbLogFile("UpdateRecordFromTable", (SQL & vbCrLf & ex.Message), ex.StackTrace)
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

    Private Sub CreateCalculatedDeliveryCalendarRecords(deliveryTable As DataTable)

        ' with the new delivery information, create the individual delivery records for each delivery in the
        ' span of start and end dates
        Dim frequencyDays As Integer
        Dim calculatedDeliveryDate As Date
        Dim deliveryRow As DataRow = deliveryTable.Rows(0)
        Dim delFrequency As String = deliveryRow("Frequency")
        Dim startDateTime As Date = deliveryRow("StartDateTime")
        Dim endDate As Date = deliveryRow("EndDate")
        Dim deliveryCalendarID As Long = _recordID
        Dim recipientID As Long = deliveryRow("RecipientID")
        Dim workerID As Long = deliveryRow("WorkerID")
        Dim deliveryNotes As String = deliveryRow("Notes")
        Dim endDateTime As Date
        Dim insertSQL As String
        Dim SQL As String
        insertSQL = "Insert into tblCalculatedDeliveryCalendar (DeliveryCalendarID, ScheduledDeliveryDate, RecipientID, WorkerID, Notes) values "

        Select Case delFrequency
            Case "Weekly"
                frequencyDays = 7
            Case "Bi-Weekly"
                frequencyDays = 14
            Case "Monthly"
                frequencyDays = 30
        End Select

        endDateTime = $"{endDate.ToString("d")} {startDateTime.ToShortTimeString}"

        If _cn.State = ConnectionState.Closed Then
            _cn.Open()
        End If

        calculatedDeliveryDate = startDateTime
        Do Until calculatedDeliveryDate >= endDateTime
            SQL = $"{insertSQL} ({deliveryCalendarID}, #{calculatedDeliveryDate}#, {recipientID}, {workerID}, '{deliveryNotes}')"

            _cmd = New OleDbCommand(SQL, _cn)
            _rdr = _cmd.ExecuteReader()

            _rdr.Close()
            _cmd.Dispose()

            calculatedDeliveryDate = calculatedDeliveryDate.AddDays(frequencyDays)
        Loop

        _cn.Close()
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

    Private Sub CreateDbLogFile(errWhere As String, errMessage As String, errStackTrace As String)

        ' write any errors encountered to a log file to help in diagnostics
        Dim logFileName As String = $"{Application.StartupPath()}\DbLayerErrorLog_{DateTime.Today.ToString("dd-MMM-yyyy")}.txt"
        Dim fs As FileStream = Nothing
        Using sw As StreamWriter = New StreamWriter(File.Open(logFileName, FileMode.Append))
            sw.WriteLine($"{DateTime.Now:f}: Error in {errWhere} code")
            sw.WriteLine(errStackTrace)
            sw.WriteLine(errMessage)
            sw.WriteLine("-------------------------------------------------------------------------------------")
        End Using

        MsgBox($"The log file {logFileName} has been created with the neccessary debugging information.", MsgBoxStyle.OkOnly, "Log File")

    End Sub

End Class
