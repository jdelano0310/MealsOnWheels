<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReports
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lbReports = New ListBox()
        wvPDF = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(wvPDF, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbReports
        ' 
        lbReports.Dock = DockStyle.Left
        lbReports.FormattingEnabled = True
        lbReports.ItemHeight = 15
        lbReports.Items.AddRange(New Object() {"Deliveries By Worker"})
        lbReports.Location = New Point(0, 0)
        lbReports.Name = "lbReports"
        lbReports.Size = New Size(120, 432)
        lbReports.TabIndex = 0
        ' 
        ' wvPDF
        ' 
        wvPDF.AllowExternalDrop = True
        wvPDF.CreationProperties = Nothing
        wvPDF.DefaultBackgroundColor = Color.White
        wvPDF.Dock = DockStyle.Fill
        wvPDF.Location = New Point(120, 0)
        wvPDF.Name = "wvPDF"
        wvPDF.Size = New Size(778, 432)
        wvPDF.Source = New Uri("https://www.microsoft.com", UriKind.Absolute)
        wvPDF.TabIndex = 1
        wvPDF.Visible = False
        wvPDF.ZoomFactor = 1R
        ' 
        ' frmReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(898, 432)
        Controls.Add(wvPDF)
        Controls.Add(lbReports)
        Name = "frmReports"
        Text = "Reports"
        CType(wvPDF, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents lbReports As ListBox
    Friend WithEvents wvPDF As Microsoft.Web.WebView2.WinForms.WebView2
End Class
