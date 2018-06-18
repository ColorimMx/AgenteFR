Public Class MenuR

    Private Sub MenuR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim Response As MsgBoxResult
        msg = "Esta seguro que desea salir?"
        style = MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
        title = "Salir"
        Response = MsgBox(msg, style, title)
        If Response = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub ExistenciaGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciaGeneralToolStripMenuItem.Click
        Dim a As New InvExiGen
        a.Show()
        Me.FindForm()
    End Sub
    Private Sub ExistenciaCodProductoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExistenciaCodProductoToolStripMenuItem.Click
        Dim a As New InvExiCodPro
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub PrincipalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrincipalToolStripMenuItem.Click
        Dim a As New CobGenPri
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub ClienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem.Click
        Dim a As New CobGenCli
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub FormaDePagoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormaDePagoToolStripMenuItem.Click
        Dim a As New CobGenForPag
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub OrigenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenToolStripMenuItem.Click
        Dim a As New CobGenOri
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub PrincipalToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrincipalToolStripMenuItem1.Click
        Dim a As New CobDetPri
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        Dim a As New CobDetCli
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub FormaDePagoToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FormaDePagoToolStripMenuItem1.Click
        Dim a As New CobDetForPag
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub OrigenToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrigenToolStripMenuItem1.Click
        Dim a As New CobDetOri
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub TablaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles TablaToolStripMenuItem.Click
        Dim a As New FrVenTab
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub ClienteRangoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ClienteRangoToolStripMenuItem.Click
        Dim a As New FrVenCliRan
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub RangoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles RangoClienteToolStripMenuItem.Click
        Dim a As New FrVenRanCli
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub GraficaClienteRangoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GraficaClienteRangoToolStripMenuItem.Click
        Dim a As New FrGrafCliRan
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub GraficaRangoClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles GraficaRangoClienteToolStripMenuItem.Click
        Dim a As New FrGrafRanCli
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub FichaClienteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FichaClienteToolStripMenuItem.Click
        Dim a As New VenCliFic
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub FacturaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles FacturaciónToolStripMenuItem.Click
        Dim a As New VenDetVen
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub PedidosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PedidosToolStripMenuItem.Click
        Dim a As New VenPedDetUni
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub EstatusPedidosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstatusPedidosToolStripMenuItem.Click
        Dim a As New VenDetPed
        a.Show()
        Me.FindForm()
    End Sub

    Private Sub EstatusFacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstatusFacturasToolStripMenuItem.Click
        Dim a As New VenEstFac
        a.Show()
        Me.FindForm()
    End Sub
End Class