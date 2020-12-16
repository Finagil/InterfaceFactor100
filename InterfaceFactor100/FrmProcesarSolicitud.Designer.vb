<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProcesarSolicitud
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridPAgos = New System.Windows.Forms.DataGridView()
        Me.VwPagosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Factor100DS = New InterfaceFactor100.Factor100DS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextImporte = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckALL = New System.Windows.Forms.CheckBox()
        Me.Vw_PagosTableAdapter = New InterfaceFactor100.Factor100DSTableAdapters.Vw_PagosTableAdapter()
        Me.PagosFactor100TableAdapter = New InterfaceFactor100.Factor100DSTableAdapters.PagosFactor100TableAdapter()
        Me.ClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CL_NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImporteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.moneda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RfcDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClabeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Procesar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DataGridPAgos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwPagosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Factor100DS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridPAgos
        '
        Me.DataGridPAgos.AllowUserToAddRows = False
        Me.DataGridPAgos.AllowUserToDeleteRows = False
        Me.DataGridPAgos.AutoGenerateColumns = False
        Me.DataGridPAgos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridPAgos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClienteDataGridViewTextBoxColumn, Me.CL_NOMBRE, Me.ImporteDataGridViewTextBoxColumn, Me.moneda, Me.RfcDataGridViewTextBoxColumn, Me.ClabeDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.Procesar})
        Me.DataGridPAgos.DataSource = Me.VwPagosBindingSource
        Me.DataGridPAgos.Location = New System.Drawing.Point(12, 27)
        Me.DataGridPAgos.Name = "DataGridPAgos"
        Me.DataGridPAgos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridPAgos.Size = New System.Drawing.Size(930, 296)
        Me.DataGridPAgos.TabIndex = 0
        '
        'VwPagosBindingSource
        '
        Me.VwPagosBindingSource.DataMember = "Vw_Pagos"
        Me.VwPagosBindingSource.DataSource = Me.Factor100DS
        '
        'Factor100DS
        '
        Me.Factor100DS.DataSetName = "Factor100DS"
        Me.Factor100DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Solicitudes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Beneficiario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 330)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Importe"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwPagosBindingSource, "CL_NOMBRE", True))
        Me.TextBox1.Location = New System.Drawing.Point(12, 346)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(308, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextImporte
        '
        Me.TextImporte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwPagosBindingSource, "importe", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "N2"))
        Me.TextImporte.Location = New System.Drawing.Point(326, 346)
        Me.TextImporte.Name = "TextImporte"
        Me.TextImporte.Size = New System.Drawing.Size(108, 20)
        Me.TextImporte.TabIndex = 5
        Me.TextImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(440, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cambiar Importe"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(841, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 36)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Pasar para Autorización"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckALL
        '
        Me.CheckALL.AutoSize = True
        Me.CheckALL.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CheckALL.Location = New System.Drawing.Point(858, 7)
        Me.CheckALL.Name = "CheckALL"
        Me.CheckALL.Size = New System.Drawing.Size(51, 17)
        Me.CheckALL.TabIndex = 8
        Me.CheckALL.Text = "Todo"
        Me.CheckALL.UseVisualStyleBackColor = True
        '
        'Vw_PagosTableAdapter
        '
        Me.Vw_PagosTableAdapter.ClearBeforeFill = True
        '
        'PagosFactor100TableAdapter
        '
        Me.PagosFactor100TableAdapter.ClearBeforeFill = True
        '
        'ClienteDataGridViewTextBoxColumn
        '
        Me.ClienteDataGridViewTextBoxColumn.DataPropertyName = "cliente"
        Me.ClienteDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.ClienteDataGridViewTextBoxColumn.Name = "ClienteDataGridViewTextBoxColumn"
        Me.ClienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClienteDataGridViewTextBoxColumn.Width = 70
        '
        'CL_NOMBRE
        '
        Me.CL_NOMBRE.DataPropertyName = "CL_NOMBRE"
        Me.CL_NOMBRE.HeaderText = "Nombre"
        Me.CL_NOMBRE.Name = "CL_NOMBRE"
        Me.CL_NOMBRE.ReadOnly = True
        Me.CL_NOMBRE.Width = 250
        '
        'ImporteDataGridViewTextBoxColumn
        '
        Me.ImporteDataGridViewTextBoxColumn.DataPropertyName = "importe"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "n2"
        Me.ImporteDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ImporteDataGridViewTextBoxColumn.HeaderText = "Importe"
        Me.ImporteDataGridViewTextBoxColumn.Name = "ImporteDataGridViewTextBoxColumn"
        Me.ImporteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'moneda
        '
        Me.moneda.DataPropertyName = "moneda"
        Me.moneda.HeaderText = "Moneda"
        Me.moneda.Name = "moneda"
        Me.moneda.ReadOnly = True
        Me.moneda.Width = 60
        '
        'RfcDataGridViewTextBoxColumn
        '
        Me.RfcDataGridViewTextBoxColumn.DataPropertyName = "rfc"
        Me.RfcDataGridViewTextBoxColumn.HeaderText = "RFC"
        Me.RfcDataGridViewTextBoxColumn.Name = "RfcDataGridViewTextBoxColumn"
        Me.RfcDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClabeDataGridViewTextBoxColumn
        '
        Me.ClabeDataGridViewTextBoxColumn.DataPropertyName = "clabe"
        Me.ClabeDataGridViewTextBoxColumn.FillWeight = 150.0!
        Me.ClabeDataGridViewTextBoxColumn.HeaderText = "Cuenta Clabe"
        Me.ClabeDataGridViewTextBoxColumn.Name = "ClabeDataGridViewTextBoxColumn"
        Me.ClabeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ClabeDataGridViewTextBoxColumn.Width = 120
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "fecha"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.FechaDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Procesar
        '
        Me.Procesar.HeaderText = "Procesar"
        Me.Procesar.Name = "Procesar"
        Me.Procesar.Width = 80
        '
        'FrmProcesarSolicitud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 375)
        Me.Controls.Add(Me.CheckALL)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextImporte)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridPAgos)
        Me.Name = "FrmProcesarSolicitud"
        Me.Text = "Procesar Solicitudes"
        CType(Me.DataGridPAgos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwPagosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Factor100DS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridPAgos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Factor100DS As Factor100DS
    Friend WithEvents VwPagosBindingSource As BindingSource
    Friend WithEvents Vw_PagosTableAdapter As Factor100DSTableAdapters.Vw_PagosTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextImporte As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents PagosFactor100TableAdapter As Factor100DSTableAdapters.PagosFactor100TableAdapter
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckALL As CheckBox
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CL_NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents ImporteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents moneda As DataGridViewTextBoxColumn
    Friend WithEvents RfcDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClabeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Procesar As DataGridViewCheckBoxColumn
End Class
