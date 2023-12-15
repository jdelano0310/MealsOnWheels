Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Net

Public Class frmReports
    Private Sub lbReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbReports.SelectedIndexChanged

        Dim outputPDF As String = Path.Combine(Application.StartupPath, $"{Format(Now, "MMddyyyyHHmmss")}.PDF")
        Dim MSAccess As New Microsoft.Office.Interop.Access.Application

        Try
            MSAccess.OpenCurrentDatabase(My.Settings.DatabaseLocation, False)

            'MSAccess.DoCmd.OpenReport("rptDeliveriesForWorkerByDate", Access.AcView.acViewPreview, , "")
            MSAccess.DoCmd.OutputTo(Access.AcOutputObjectType.acOutputReport, "rptDeliveriesForWorkerByDate",
                                Access.Constants.acFormatPDF, outputPDF,,,, Access.AcExportQuality.acExportQualityPrint)
        Catch ex As Exception
            outputPDF = ""
        Finally
            MSAccess.DoCmd.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(MSAccess)

        End Try

        wvPDF.NavigateToString(outputPDF)

    End Sub
End Class