Public Class FrmClientesConMC
    Private Sub FrmClientesConMC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ClientesFactorTableAdapter.Fill_not(Me.ProductionDS.ClientesFactor)
        Me.ClientesFactorTableAdapter.Fill_in(Me.ProductionDS1.ClientesFactor)
    End Sub

    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        If ListBox1.Items.Count > 0 Then
            If ListBox1.SelectedIndex >= 0 Then
                If MessageBox.Show("Estas seguro de pasar a " & ListBox1.text, "Cambio de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.CxP_FactorClientesMCTableAdapter1.Insert(ListBox1.SelectedValue)
                    Me.ClientesFactorTableAdapter.Fill_not(Me.ProductionDS.ClientesFactor)
                    Me.ClientesFactorTableAdapter.Fill_in(Me.ProductionDS1.ClientesFactor)
                End If
            End If
        End If
    End Sub
    Private Sub ListBox2_DoubleClick(sender As Object, e As EventArgs) Handles ListBox2.DoubleClick
        If ListBox2.Items.Count > 0 Then
            If ListBox2.SelectedIndex >= 0 Then
                If MessageBox.Show("Estas seguro de pasar a " & ListBox2.Text, "Cambio de lista", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Me.CxP_FactorClientesMCTableAdapter1.Delete(ListBox2.SelectedValue)
                    Me.ClientesFactorTableAdapter.Fill_not(Me.ProductionDS.ClientesFactor)
                    Me.ClientesFactorTableAdapter.Fill_in(Me.ProductionDS1.ClientesFactor)
                End If
            End If
        End If
    End Sub
End Class