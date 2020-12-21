<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MDIform
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesConAutorizaciónMCToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InterfaceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesarSolicitudesFactor100CXPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProcesarPagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelarSolicitudToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosPRocesadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosClientesToolStripMenuItem, Me.InterfaceToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1069, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CatalogosClientesToolStripMenuItem
        '
        Me.CatalogosClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesConAutorizaciónMCToolStripMenuItem})
        Me.CatalogosClientesToolStripMenuItem.Name = "CatalogosClientesToolStripMenuItem"
        Me.CatalogosClientesToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.CatalogosClientesToolStripMenuItem.Text = "Catalogos Clientes"
        '
        'ClientesConAutorizaciónMCToolStripMenuItem
        '
        Me.ClientesConAutorizaciónMCToolStripMenuItem.Name = "ClientesConAutorizaciónMCToolStripMenuItem"
        Me.ClientesConAutorizaciónMCToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ClientesConAutorizaciónMCToolStripMenuItem.Text = "Clientes con Autorización MC"
        '
        'InterfaceToolStripMenuItem
        '
        Me.InterfaceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProcesarSolicitudesFactor100CXPToolStripMenuItem, Me.ProcesarPagosToolStripMenuItem, Me.PagosPendientesToolStripMenuItem, Me.CancelarSolicitudToolStripMenuItem, Me.PagosPRocesadosToolStripMenuItem})
        Me.InterfaceToolStripMenuItem.Name = "InterfaceToolStripMenuItem"
        Me.InterfaceToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.InterfaceToolStripMenuItem.Text = "Solicitudes "
        '
        'ProcesarSolicitudesFactor100CXPToolStripMenuItem
        '
        Me.ProcesarSolicitudesFactor100CXPToolStripMenuItem.Name = "ProcesarSolicitudesFactor100CXPToolStripMenuItem"
        Me.ProcesarSolicitudesFactor100CXPToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.ProcesarSolicitudesFactor100CXPToolStripMenuItem.Text = "Procesar Solicitudes Factor100 - CXP"
        '
        'ProcesarPagosToolStripMenuItem
        '
        Me.ProcesarPagosToolStripMenuItem.Name = "ProcesarPagosToolStripMenuItem"
        Me.ProcesarPagosToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.ProcesarPagosToolStripMenuItem.Text = "Procesar Solicitud para MC"
        '
        'PagosPendientesToolStripMenuItem
        '
        Me.PagosPendientesToolStripMenuItem.Name = "PagosPendientesToolStripMenuItem"
        Me.PagosPendientesToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.PagosPendientesToolStripMenuItem.Text = "Solicitudes con Error En Cuenta"
        '
        'CancelarSolicitudToolStripMenuItem
        '
        Me.CancelarSolicitudToolStripMenuItem.Name = "CancelarSolicitudToolStripMenuItem"
        Me.CancelarSolicitudToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.CancelarSolicitudToolStripMenuItem.Text = "Cancelar Solicitud"
        '
        'PagosPRocesadosToolStripMenuItem
        '
        Me.PagosPRocesadosToolStripMenuItem.Name = "PagosPRocesadosToolStripMenuItem"
        Me.PagosPRocesadosToolStripMenuItem.Size = New System.Drawing.Size(266, 22)
        Me.PagosPRocesadosToolStripMenuItem.Text = "Solicitudes Procesadas y Canceladas"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'MDIform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 507)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MDIform"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clientes con Autorización MC"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogosClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesConAutorizaciónMCToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InterfaceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesarPagosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPendientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PagosPRocesadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProcesarSolicitudesFactor100CXPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CancelarSolicitudToolStripMenuItem As ToolStripMenuItem
End Class
