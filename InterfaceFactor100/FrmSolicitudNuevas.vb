Public Class FrmSolicitudNuevas


    Private Sub FrmProcesarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PagosFactor100TableAdapter.UpdateMoneda()
        Me.Vw_PagosTableAdapter.Fill(Me.Factor100DS.Vw_Pagos, "Pendiente")
    End Sub

    Private Sub CheckALL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckALL.CheckedChanged
        For Each Fila As DataGridViewRow In DataGridPAgos.Rows
            Fila.Cells("Procesar").Value = CheckALL.Checked
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inserta_CXP_MOVS_FACT()
        MessageBox.Show("Proceso Terminado", "Factoraje CXP ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Vw_PagosTableAdapter.Fill(Me.Factor100DS.Vw_Pagos, "Pendiente")
    End Sub

End Class