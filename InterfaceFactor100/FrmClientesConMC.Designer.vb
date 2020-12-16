<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmClientesConMC
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ClientesFactorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDS = New InterfaceFactor100.ProductionDS()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ClientesFactorBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductionDS1 = New InterfaceFactor100.ProductionDS()
        Me.ClientesFactorTableAdapter = New InterfaceFactor100.ProductionDSTableAdapters.ClientesFactorTableAdapter()
        Me.CxP_FactorClientesMCTableAdapter1 = New InterfaceFactor100.ProductionDSTableAdapters.CXP_FactorClientesMCTableAdapter()
        CType(Me.ClientesFactorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesFactorBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionDS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.ClientesFactorBindingSource
        Me.ListBox1.DisplayMember = "CL_NOMBRE"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 24)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(341, 420)
        Me.ListBox1.TabIndex = 0
        Me.ListBox1.ValueMember = "CL_NUM"
        '
        'ClientesFactorBindingSource
        '
        Me.ClientesFactorBindingSource.DataMember = "ClientesFactor"
        Me.ClientesFactorBindingSource.DataSource = Me.ProductionDS
        '
        'ProductionDS
        '
        Me.ProductionDS.DataSetName = "ProductionDS"
        Me.ProductionDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Clientes sin Autorizacion MC (doble clic para pasar)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Clientes con Autorizacion MC"
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.ClientesFactorBindingSource1
        Me.ListBox2.DisplayMember = "CL_NOMBRE"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(359, 24)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(341, 420)
        Me.ListBox2.TabIndex = 2
        Me.ListBox2.ValueMember = "CL_NUM"
        '
        'ClientesFactorBindingSource1
        '
        Me.ClientesFactorBindingSource1.DataMember = "ClientesFactor"
        Me.ClientesFactorBindingSource1.DataSource = Me.ProductionDS1
        '
        'ProductionDS1
        '
        Me.ProductionDS1.DataSetName = "ProductionDS"
        Me.ProductionDS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesFactorTableAdapter
        '
        Me.ClientesFactorTableAdapter.ClearBeforeFill = True
        '
        'CxP_FactorClientesMCTableAdapter1
        '
        Me.CxP_FactorClientesMCTableAdapter1.ClearBeforeFill = True
        '
        'FrmClientesConMC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "FrmClientesConMC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Clientes con Autorización de MC"
        CType(Me.ClientesFactorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesFactorBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionDS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ProductionDS As ProductionDS
    Friend WithEvents ClientesFactorBindingSource As BindingSource
    Friend WithEvents ClientesFactorTableAdapter As ProductionDSTableAdapters.ClientesFactorTableAdapter
    Friend WithEvents ProductionDS1 As ProductionDS
    Friend WithEvents ClientesFactorBindingSource1 As BindingSource
    Friend WithEvents CxP_FactorClientesMCTableAdapter1 As ProductionDSTableAdapters.CXP_FactorClientesMCTableAdapter
End Class
