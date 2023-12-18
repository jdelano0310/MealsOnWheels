Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Net

Public Class frmReports
    Private Sub lbReports_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbReports.SelectedIndexChanged

        Dim outputPDF As String = Path.Combine(Application.StartupPath, $"{Format(Now, "MMddyyyyHHmmss")}.PDF")
        Dim MSAccess As New Microsoft.Office.Interop.Access.Application

        Try
            ' use Access to create the report and save it as a PDF
            MSAccess.OpenCurrentDatabase(My.Settings.DatabaseLocation, False)

            MSAccess.DoCmd.OutputTo(Access.AcOutputObjectType.acOutputReport, "rptDeliveriesForWorkerByDate",
                                Access.Constants.acFormatPDF, outputPDF,,,, Access.AcExportQuality.acExportQualityPrint)
        Catch ex As Exception
            outputPDF = ""
        Finally
            MSAccess.DoCmd.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(MSAccess)

        End Try

        ' use the WebView control to displauy the local PDF file
        wvPDF.CoreWebView2.Navigate(outputPDF)
        wvPDF.Visible = True

    End Sub
End Class