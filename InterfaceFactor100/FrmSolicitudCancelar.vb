Public Class FrmSolicitudCancelar
    Private Sub FrmProcesarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PagosFactor100TableAdapter.UpdateMoneda()
        Me.Vw_PagosTableAdapter.FillByEnProceso(Me.Factor100DS.Vw_Pagos)
    End Sub

    Private Sub CheckALL_CheckedChanged(sender As Object, e As EventArgs) Handles CheckALL.CheckedChanged
        For Each Fila As DataGridViewRow In DataGridPAgos.Rows
            Fila.Cells("Procesar").Value = CheckALL.Checked
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Seleccion As Boolean
        For Each Fila As DataGridViewRow In DataGridPAgos.Rows
            If Fila.Cells("Procesar").Value = True Then
                Seleccion = True
            End If
        Next
        If Seleccion = False Then
            MessageBox.Show("No hay filas seleccionadas.", "Procesaro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.VwPagosBindingSource.MoveFirst()
        For Each Fila As DataGridViewRow In DataGridPAgos.Rows
            If Fila.Cells("Procesar").Value = True Then
                Me.PagosFactor100TableAdapter.UpdateEstatus("CANCELADO", Me.VwPagosBindingSource.Current("id"))
            End If
            Me.VwPagosBindingSource.MoveNext()
        Next
        Me.Vw_PagosTableAdapter.FillByEnProceso(Me.Factor100DS.Vw_Pagos)
    End Sub
End Class