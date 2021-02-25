<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmComprobantes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FolioSolicitudDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLNOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReferenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UuidPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComprobantesCXPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDS = New InterfaceFactor100.ProductionDS()
        Me.ComprobantesCXPTableAdapter = New InterfaceFactor100.ProductionDSTableAdapters.ComprobantesCXPTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComprobantesCXPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(58, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdPagosTesoreriaDataGridViewTextBoxColumn, Me.TipoSolicitudDataGridViewTextBoxColumn, Me.FolioSolicitudDataGridViewTextBoxColumn, Me.ClienteDataGridViewTextBoxColumn, Me.CLNOMBREDataGridViewTextBoxColumn, Me.ReferenciaDataGridViewTextBoxColumn, Me.UuidPagoDataGridViewTextBoxColumn, Me.ImporteDataGridViewTextBoxColumn, Me.FechaPagoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ComprobantesCXPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 31)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(988, 407)
        Me.DataGridView1.TabIndex = 2
        '
        'IdPagosTesoreriaDataGridViewTextBoxColumn
        '
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.DataPropertyName = "idPagosTesoreria"
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.HeaderText = "idPagosTesoreria"
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.Name = "IdPagosTesoreriaDataGridViewTextBoxColumn"
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.Visible = False
        Me.IdPagosTesoreriaDataGridViewTextBoxColumn.Width = 80
        '
        'TipoSolicitudDataGridViewTextBoxColumn
        '
        Me.TipoSolicitudDataGridViewTextBoxColumn.DataPropertyName = "tipoSolicitud"
        Me.TipoSolicitudDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoSolicitudDataGridViewTextBoxColumn.Name = "TipoSolicitudDataGridViewTextBoxColumn"
        Me.TipoSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoSolicitudDataGridViewTextBoxColumn.Width = 50
        '
        'FolioSolicitudDataGridViewTextBoxColumn
        '
        Me.FolioSolicitudDataGridViewTextBoxColumn.DataPropertyName = "folioSolicitud"
        Me.FolioSolicitudDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioSolicitudDataGridViewTextBoxColumn.Name = "FolioSolicitudDataGridViewTextBoxColumn"
        Me.FolioSolicitudDataGridViewTextBoxColumn.ReadOnly = True
        Me.FolioSolicitudDataGridViewTextBoxColumn.Width = 50
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 80
        '
        'CLNOMBREDataGridViewTextBoxColumn
        '
        Me.CLNOMBREDataGridViewTextBoxColumn.DataPropertyName = "CL_NOMBRE"
        Me.CLNOMBREDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.CLNOMBREDataGridViewTextBoxColumn.Name = "CLNOMBREDataGridViewTextBoxColumn"
        Me.CLNOMBREDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLNOMBREDataGridViewTextBoxColumn.Width = 270
        '
        'ReferenciaDataGridViewTextBoxColumn
        '
        Me.ReferenciaDataGridViewTextBoxColumn.DataPropertyName = "referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.HeaderText = "Referencia"
        Me.ReferenciaDataGridViewTextBoxColumn.Name = "ReferenciaDataGridViewTextBoxColumn"
        Me.ReferenciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReferenciaDataGridViewTextBoxColumn.Width = 70
        '
        'UuidPagoDataGridViewTextBoxColumn
        '
        Me.UuidPagoDataGridViewTextBoxColumn.DataPropertyName = "uuidPago"
        Me.UuidPagoDataGridViewTextBoxColumn.HeaderText = "Uuid Pago"
        Me.UuidPagoDataGridViewTextBoxColumn.Name = "UuidPagoDataGridViewTextBoxColumn"
        Me.UuidPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.UuidPagoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.UuidPagoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.UuidPagoDataGridViewTextBoxColumn.Width = 230
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "importe"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaPagoDataGridViewTextBoxColumn
        '
        Me.FechaPagoDataGridViewTextBoxColumn.DataPropertyName = "fechaPago"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.FechaPagoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.FechaPagoDataGridViewTextBoxColumn.HeaderText = "Fecha de Pago"
        Me.FechaPagoDataGridViewTextBoxColumn.Name = "FechaPagoDataGridViewTextBoxColumn"
        Me.FechaPagoDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechaPagoDataGridViewTextBoxColumn.Width = 80
        '
        'ComprobantesCXPBindingSource
        '
        Me.ComprobantesCXPBindingSource.DataMember = "ComprobantesCXP"
        Me.ComprobantesCXPBindingSource.DataSource = Me.ProductionDS
        '
        'ProductionDS
        '
        Me.ProductionDS.DataSetName = "ProductionDS"
        Me.ProductionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ComprobantesCXPTableAdapter
        '
        Me.ComprobantesCXPTableAdapter.ClearBeforeFill = True
        '
        'FrmComprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 450)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmComprobantes"
        Me.Text = "Comprobantes Bancarios"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComprobantesCXPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComprobantesCXPBindingSource As BindingSource
    Friend WithEvents ProductionDS As ProductionDS
    Friend WithEvents ComprobantesCXPTableAdapter As ProductionDSTableAdapters.ComprobantesCXPTableAdapter
    Friend WithEvents IdPagosTesoreriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolioSolicitudDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CLNOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReferenciaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UuidPagoDataGridViewTextBoxColumn As DataGridViewLinkColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaPagoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
