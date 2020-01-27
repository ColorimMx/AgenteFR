Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class VenDetVen

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load
        Dim CR1 As New DetVen
        Me.CrystalReportViewer1.ReportSource = CR1
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.UserID = "ODBC"
        Me.CrystalReportViewer1.LogOnInfo.Item(0).ConnectionInfo.Password = "ODBC"

        Dim crParameterFieldDefinitions As ParameterFieldDefinitions
        Dim crParameterFieldDefinition As ParameterFieldDefinition
        Dim crParameterValues As New ParameterValues
        Dim crParameterDiscreteValue As New ParameterDiscreteValue

        crParameterDiscreteValue.Value = agente
        crParameterFieldDefinitions = CR1.DataDefinition.ParameterFields()
        crParameterFieldDefinition = crParameterFieldDefinitions.Item("for")
        crParameterValues = crParameterFieldDefinition.CurrentValues
        crParameterValues.Clear()
        crParameterValues.Add(crParameterDiscreteValue)
        crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)
    End Sub
End Class