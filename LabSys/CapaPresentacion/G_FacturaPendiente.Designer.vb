<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_FacturaPendiente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.dgPendiente = New System.Windows.Forms.DataGridView
        Me.OTNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTFECHAORDENDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PROPRODUCTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTABONODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTTOTALDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FACNUMERODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FACFECHADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CLIENTEPAGOPENDIENTEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cjto_Tablas = New LabSys.Cjto_Tablas
        CType(Me.dgPendiente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTEPAGOPENDIENTEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Tablas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgPendiente
        '
        Me.dgPendiente.AllowUserToAddRows = False
        Me.dgPendiente.AllowUserToDeleteRows = False
        Me.dgPendiente.AutoGenerateColumns = False
        Me.dgPendiente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPendiente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OTNUMERODataGridViewTextBoxColumn, Me.OTFECHAORDENDataGridViewTextBoxColumn, Me.PROPRODUCTORDataGridViewTextBoxColumn, Me.OTABONODataGridViewTextBoxColumn, Me.OTTOTALDataGridViewTextBoxColumn, Me.FACNUMERODataGridViewTextBoxColumn, Me.FACFECHADataGridViewTextBoxColumn})
        Me.dgPendiente.DataSource = Me.CLIENTEPAGOPENDIENTEBindingSource
        Me.dgPendiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPendiente.Location = New System.Drawing.Point(0, 0)
        Me.dgPendiente.Name = "dgPendiente"
        Me.dgPendiente.ReadOnly = True
        Me.dgPendiente.Size = New System.Drawing.Size(698, 439)
        Me.dgPendiente.TabIndex = 0
        '
        'OTNUMERODataGridViewTextBoxColumn
        '
        Me.OTNUMERODataGridViewTextBoxColumn.DataPropertyName = "OT_NUMERO"
        Me.OTNUMERODataGridViewTextBoxColumn.HeaderText = "N° OT"
        Me.OTNUMERODataGridViewTextBoxColumn.Name = "OTNUMERODataGridViewTextBoxColumn"
        Me.OTNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.OTNUMERODataGridViewTextBoxColumn.Width = 60
        '
        'OTFECHAORDENDataGridViewTextBoxColumn
        '
        Me.OTFECHAORDENDataGridViewTextBoxColumn.DataPropertyName = "OT_FECHA_ORDEN"
        Me.OTFECHAORDENDataGridViewTextBoxColumn.HeaderText = "Fecha Orden"
        Me.OTFECHAORDENDataGridViewTextBoxColumn.Name = "OTFECHAORDENDataGridViewTextBoxColumn"
        Me.OTFECHAORDENDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PROPRODUCTORDataGridViewTextBoxColumn
        '
        Me.PROPRODUCTORDataGridViewTextBoxColumn.DataPropertyName = "PRO_PRODUCTOR"
        Me.PROPRODUCTORDataGridViewTextBoxColumn.HeaderText = "Productor"
        Me.PROPRODUCTORDataGridViewTextBoxColumn.Name = "PROPRODUCTORDataGridViewTextBoxColumn"
        Me.PROPRODUCTORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OTABONODataGridViewTextBoxColumn
        '
        Me.OTABONODataGridViewTextBoxColumn.DataPropertyName = "OT_ABONO"
        Me.OTABONODataGridViewTextBoxColumn.HeaderText = "Abono"
        Me.OTABONODataGridViewTextBoxColumn.Name = "OTABONODataGridViewTextBoxColumn"
        Me.OTABONODataGridViewTextBoxColumn.ReadOnly = True
        Me.OTABONODataGridViewTextBoxColumn.Width = 60
        '
        'OTTOTALDataGridViewTextBoxColumn
        '
        Me.OTTOTALDataGridViewTextBoxColumn.DataPropertyName = "OT_TOTAL"
        Me.OTTOTALDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.OTTOTALDataGridViewTextBoxColumn.Name = "OTTOTALDataGridViewTextBoxColumn"
        Me.OTTOTALDataGridViewTextBoxColumn.ReadOnly = True
        Me.OTTOTALDataGridViewTextBoxColumn.Width = 50
        '
        'FACNUMERODataGridViewTextBoxColumn
        '
        Me.FACNUMERODataGridViewTextBoxColumn.DataPropertyName = "FAC_NUMERO"
        Me.FACNUMERODataGridViewTextBoxColumn.HeaderText = "N° Fac"
        Me.FACNUMERODataGridViewTextBoxColumn.Name = "FACNUMERODataGridViewTextBoxColumn"
        Me.FACNUMERODataGridViewTextBoxColumn.ReadOnly = True
        Me.FACNUMERODataGridViewTextBoxColumn.Width = 80
        '
        'FACFECHADataGridViewTextBoxColumn
        '
        Me.FACFECHADataGridViewTextBoxColumn.DataPropertyName = "FAC_FECHA"
        Me.FACFECHADataGridViewTextBoxColumn.HeaderText = "Fecha Fac"
        Me.FACFECHADataGridViewTextBoxColumn.Name = "FACFECHADataGridViewTextBoxColumn"
        Me.FACFECHADataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIENTEPAGOPENDIENTEBindingSource
        '
        Me.CLIENTEPAGOPENDIENTEBindingSource.DataMember = "CLIENTE_PAGO_PENDIENTE"
        Me.CLIENTEPAGOPENDIENTEBindingSource.DataSource = Me.Cjto_Tablas
        '
        'Cjto_Tablas
        '
        Me.Cjto_Tablas.DataSetName = "Cjto_Tablas"
        Me.Cjto_Tablas.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Cjto_Tablas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'G_FacturaPendiente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 439)
        Me.Controls.Add(Me.dgPendiente)
        Me.Name = "G_FacturaPendiente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturación Pendiente"
        CType(Me.dgPendiente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTEPAGOPENDIENTEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Tablas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgPendiente As System.Windows.Forms.DataGridView
    Friend WithEvents CLIENTEPAGOPENDIENTEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cjto_Tablas As LabSys.Cjto_Tablas
    Friend WithEvents OTNUMERODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTFECHAORDENDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUTPRODUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPRODUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTABONODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTTOTALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACNUMERODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACFECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
