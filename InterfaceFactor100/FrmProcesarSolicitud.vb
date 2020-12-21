Public Class FrmProcesarSolicitud
    Private Sub FrmProcesarSolicitud_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PagosFactor100TableAdapter.UpdateMoneda()
        Me.Vw_PagosTableAdapter.Fill(Me.Factor100DS.Vw_Pagos, "VoboMC")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not IsNumeric(TextImporte.Text) Then
            MessageBox.Show("Importe no Valido", "Cambio de Importe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim Imp As Decimal = Me.Vw_PagosTableAdapter.SacaImporte(Me.VwPagosBindingSource.Current("id"))
        If Val(TextImporte.Text) > Imp Then
            MessageBox.Show("el Importe no puede ser mayor al solicitado: " & Imp.ToString("n2"), "Cambio de Importe", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        If MessageBox.Show("Está seguro de cambiar el importe para " & Me.VwPagosBindingSource.Current("Nombre"), "Cambio de Importe", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Me.VwPagosBindingSource.Current("Importe") = CDec(TextImporte.Text).ToString("n2")
            Me.PagosFactor100TableAdapter.UpdateImporte(TextImporte.Text, Me.VwPagosBindingSource.Current("id"))
            MessageBox.Show("Cambio realizado", "Cambio de Importe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Vw_PagosTableAdapter.Fill(Me.Factor100DS.Vw_Pagos, "Pendiente")
        End If
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
            MessageBox.Show("No hay filas seleccionadas.", "Procesar", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Me.VwPagosBindingSource.MoveFirst()
        For Each Fila As DataGridViewRow In DataGridPAgos.Rows
            If Fila.Cells("Procesar").Value = True Then
                Me.PagosFactor100TableAdapter.UpdateEstatus("MesaControl", Me.VwPagosBindingSource.Current("id"))
            End If
            Me.VwPagosBindingSource.MoveNext()
        Next
        Inserta_CXP_MOVS_FACT()
        MessageBox.Show("Proceso Terminado", "Factoraje CXP ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Vw_PagosTableAdapter.Fill(Me.Factor100DS.Vw_Pagos, "VoboMC")
    End Sub
End Class