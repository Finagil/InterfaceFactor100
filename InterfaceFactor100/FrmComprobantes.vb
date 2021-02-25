Public Class FrmComprobantes
    Private Sub FrmComprobantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Today.DayOfWeek = DayOfWeek.Monday Then
            DateTimePicker1.Value = Today.AddDays(-3)
        Else
            DateTimePicker1.Value = Today.AddDays(-1)
        End If
        Me.ComprobantesCXPTableAdapter.Fill(ProductionDS.ComprobantesCXP, DateTimePicker1.Value)
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Me.ComprobantesCXPTableAdapter.Fill(ProductionDS.ComprobantesCXP, DateTimePicker1.Value)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If DataGridView1.Columns(DataGridView1.CurrentCell.ColumnIndex).HeaderText = "Uuid Pago" Then
            Try
                Process.Start("\\server-nas\TMPFINAGIL\CXP\ComPago\" & DataGridView1.CurrentCell.Value & ".pdf")
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class