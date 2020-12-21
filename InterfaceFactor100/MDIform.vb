Public Class MDIform
    '1 Pendiente
    '2 VoboFactor (usuario MCONTROL_CXP)
    '3 MesaControl
    '4 AutorizadoMC
    '5 ErrorEnCuenta (MC, aUTMC)
    '6 Procesado (ya esta en CXP)
    '7 Rechazado (no paso a CXP)

    Private Sub ClientesConAutorizaciónMCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesConAutorizaciónMCToolStripMenuItem.Click
        Dim f As New FrmClientesConMC
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProcesarPagosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarPagosToolStripMenuItem.Click
        Dim f As New FrmProcesarSolicitud
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PagosPendientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPendientesToolStripMenuItem.Click
        Dim f As New FrmSolicitudConError
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub PagosPRocesadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagosPRocesadosToolStripMenuItem.Click
        Dim f As New FrmSolicitudProcesada
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ProcesarSolicitudesFactor100CXPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProcesarSolicitudesFactor100CXPToolStripMenuItem.Click
        Dim f As New FrmSolicitudNuevas
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub CancelarSolicitudToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelarSolicitudToolStripMenuItem.Click
        Dim f As New FrmSolicitudCancelar
        f.WindowState = FormWindowState.Maximized
        f.MdiParent = Me
        f.Show()
    End Sub
End Class