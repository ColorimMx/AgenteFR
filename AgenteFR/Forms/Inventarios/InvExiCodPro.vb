﻿Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class InvExiCodPro

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New ExiCodProd
        Me.CrystalReportViewer1.ReportSource = CR1
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "ODBC"
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "ODBC"
    End Sub
End Class