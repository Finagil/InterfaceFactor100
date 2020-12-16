Public Class FrmSolicitudProcesada
    Private Sub FrmProcesarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PagosFactor100TableAdapter.UpdateMoneda()
        Me.Vw_PagosTableAdapter.FillByProcesado(Me.Factor100DS.Vw_Pagos)
    End Sub
End Class