<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ESTADO_RESULTADOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ESTADO_RESULTADOS))
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_buscar = New System.Windows.Forms.Button
        Me.cb_tipo = New System.Windows.Forms.ComboBox
        Me.grillaEstados = New System.Windows.Forms.DataGridView
        Me.btn_generaExcel = New System.Windows.Forms.Button
        Me.dt_desde = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.AGROLAB_PRUEBADataSet4 = New LabSys.AGROLAB_PRUEBADataSet4
        Me.ESTADOSOTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESTADOS_OTTableAdapter1 = New LabSys.AGROLAB_PRUEBADataSet4TableAdapters.ESTADOS_OTTableAdapter
        Me.OTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NlabDesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoAnalisisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoPagoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.grillaEstados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGROLAB_PRUEBADataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESTADOSOTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Muestra"
        '
        'btn_buscar
        '
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.Location = New System.Drawing.Point(221, 36)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscar.TabIndex = 1
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'cb_tipo
        '
        Me.cb_tipo.FormattingEnabled = True
        Me.cb_tipo.Items.AddRange(New Object() {"Agu", "Sue", "Fol", "FOrg", "FQui", "Fito", "Tej", "Otro"})
        Me.cb_tipo.Location = New System.Drawing.Point(94, 12)
        Me.cb_tipo.Name = "cb_tipo"
        Me.cb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cb_tipo.TabIndex = 2
        '
        'grillaEstados
        '
        Me.grillaEstados.AllowUserToAddRows = False
        Me.grillaEstados.AllowUserToDeleteRows = False
        Me.grillaEstados.AutoGenerateColumns = False
        Me.grillaEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grillaEstados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OTDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.ProductorDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn, Me.RemiteDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.NlabDesdeDataGridViewTextBoxColumn, Me.EstadoAnalisisDataGridViewTextBoxColumn, Me.EstadoPagoDataGridViewTextBoxColumn})
        Me.grillaEstados.DataSource = Me.ESTADOSOTBindingSource1
        Me.grillaEstados.Location = New System.Drawing.Point(22, 74)
        Me.grillaEstados.Name = "grillaEstados"
        Me.grillaEstados.Size = New System.Drawing.Size(1216, 668)
        Me.grillaEstados.TabIndex = 3
        '
        'btn_generaExcel
        '
        Me.btn_generaExcel.Image = CType(resources.GetObject("btn_generaExcel.Image"), System.Drawing.Image)
        Me.btn_generaExcel.Location = New System.Drawing.Point(1156, 748)
        Me.btn_generaExcel.Name = "btn_generaExcel"
        Me.btn_generaExcel.Size = New System.Drawing.Size(82, 73)
        Me.btn_generaExcel.TabIndex = 4
        Me.btn_generaExcel.UseVisualStyleBackColor = True
        '
        'dt_desde
        '
        Me.dt_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_desde.Location = New System.Drawing.Point(94, 37)
        Me.dt_desde.Name = "dt_desde"
        Me.dt_desde.Size = New System.Drawing.Size(121, 20)
        Me.dt_desde.TabIndex = 5
        Me.dt_desde.Value = New Date(2013, 1, 1, 11, 14, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Desde"
        '
        'AGROLAB_PRUEBADataSet4
        '
        Me.AGROLAB_PRUEBADataSet4.DataSetName = "AGROLAB_PRUEBADataSet4"
        Me.AGROLAB_PRUEBADataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESTADOSOTBindingSource1
        '
        Me.ESTADOSOTBindingSource1.DataMember = "ESTADOS_OT"
        Me.ESTADOSOTBindingSource1.DataSource = Me.AGROLAB_PRUEBADataSet4
        '
        'ESTADOS_OTTableAdapter1
        '
        Me.ESTADOS_OTTableAdapter1.ClearBeforeFill = True
        '
        'OTDataGridViewTextBoxColumn
        '
        Me.OTDataGridViewTextBoxColumn.DataPropertyName = "OT"
        Me.OTDataGridViewTextBoxColumn.HeaderText = "OT"
        Me.OTDataGridViewTextBoxColumn.Name = "OTDataGridViewTextBoxColumn"
        Me.OTDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 60
        '
        'ProductorDataGridViewTextBoxColumn
        '
        Me.ProductorDataGridViewTextBoxColumn.DataPropertyName = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.HeaderText = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.Name = "ProductorDataGridViewTextBoxColumn"
        Me.ProductorDataGridViewTextBoxColumn.Width = 250
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.Width = 250
        '
        'RemiteDataGridViewTextBoxColumn
        '
        Me.RemiteDataGridViewTextBoxColumn.DataPropertyName = "Remite"
        Me.RemiteDataGridViewTextBoxColumn.HeaderText = "Remite"
        Me.RemiteDataGridViewTextBoxColumn.Name = "RemiteDataGridViewTextBoxColumn"
        Me.RemiteDataGridViewTextBoxColumn.Width = 250
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 60
        '
        'NlabDesdeDataGridViewTextBoxColumn
        '
        Me.NlabDesdeDataGridViewTextBoxColumn.DataPropertyName = "Nlab Desde"
        Me.NlabDesdeDataGridViewTextBoxColumn.HeaderText = "Nlab Desde"
        Me.NlabDesdeDataGridViewTextBoxColumn.Name = "NlabDesdeDataGridViewTextBoxColumn"
        Me.NlabDesdeDataGridViewTextBoxColumn.Width = 60
        '
        'EstadoAnalisisDataGridViewTextBoxColumn
        '
        Me.EstadoAnalisisDataGridViewTextBoxColumn.DataPropertyName = "Estado Analisis"
        Me.EstadoAnalisisDataGridViewTextBoxColumn.HeaderText = "Estado Analisis"
        Me.EstadoAnalisisDataGridViewTextBoxColumn.Name = "EstadoAnalisisDataGridViewTextBoxColumn"
        Me.EstadoAnalisisDataGridViewTextBoxColumn.Width = 70
        '
        'EstadoPagoDataGridViewTextBoxColumn
        '
        Me.EstadoPagoDataGridViewTextBoxColumn.DataPropertyName = "Estado Pago"
        Me.EstadoPagoDataGridViewTextBoxColumn.HeaderText = "Estado Pago"
        Me.EstadoPagoDataGridViewTextBoxColumn.Name = "EstadoPagoDataGridViewTextBoxColumn"
        Me.EstadoPagoDataGridViewTextBoxColumn.Width = 70
        '
        'FRM_ESTADO_RESULTADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 998)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dt_desde)
        Me.Controls.Add(Me.btn_generaExcel)
        Me.Controls.Add(Me.grillaEstados)
        Me.Controls.Add(Me.cb_tipo)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FRM_ESTADO_RESULTADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estado de Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grillaEstados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGROLAB_PRUEBADataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESTADOSOTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_buscar As System.Windows.Forms.Button
    Friend WithEvents cb_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents grillaEstados As System.Windows.Forms.DataGridView
    Friend WithEvents btn_generaExcel As System.Windows.Forms.Button
    Friend WithEvents dt_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AGROLAB_PRUEBADataSet4 As LabSys.AGROLAB_PRUEBADataSet4
    Friend WithEvents ESTADOSOTBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ESTADOS_OTTableAdapter1 As LabSys.AGROLAB_PRUEBADataSet4TableAdapters.ESTADOS_OTTableAdapter
    Friend WithEvents OTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NlabDesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoAnalisisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoPagoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
