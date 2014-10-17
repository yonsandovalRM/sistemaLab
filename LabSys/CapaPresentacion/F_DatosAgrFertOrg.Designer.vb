<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrFertOrg

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrFertOrg))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txNlab = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtMuestreador = New System.Windows.Forms.DateTimePicker
        Me.cbMuestreador = New System.Windows.Forms.ComboBox
        Me.MUESTREADORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet3 = New LabSys.LabsysDataSet3
        Me.txMuestras = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txIdentificacion1 = New System.Windows.Forms.TextBox
        Me.txIdentificacion2 = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.LOCALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet7 = New LabSys.LabsysDataSet7
        Me.cbTeipoFert = New System.Windows.Forms.ComboBox
        Me.TEJIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet8 = New LabSys.LabsysDataSet8
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txPredio = New System.Windows.Forms.TextBox
        Me.ESPECIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet6 = New LabSys.LabsysDataSet6
        Me.ESPECIEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESPECIEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgDatArgFertOrg = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FMuestreo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipFert = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.MUESTREADORESTableAdapter = New LabSys.LabsysDataSet3TableAdapters.MUESTREADORESTableAdapter
        Me.ESPECIETableAdapter = New LabSys.LabsysDataSet6TableAdapters.ESPECIETableAdapter
        Me.LOCALIDADTableAdapter = New LabSys.LabsysDataSet7TableAdapters.LOCALIDADTableAdapter
        Me.ESPECIETableAdapter1 = New LabSys.LabsysDataSet8TableAdapters.ESPECIETableAdapter
        Me.TEJIDOTableAdapter = New LabSys.LabsysDataSet8TableAdapters.TEJIDOTableAdapter
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatArgFertOrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.txNlab)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtMuestreador)
        Me.Panel1.Controls.Add(Me.cbMuestreador)
        Me.Panel1.Controls.Add(Me.txMuestras)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 57)
        Me.Panel1.TabIndex = 0
        '
        'txNlab
        '
        Me.txNlab.BackColor = System.Drawing.Color.White
        Me.txNlab.Location = New System.Drawing.Point(89, 16)
        Me.txNlab.Name = "txNlab"
        Me.txNlab.ReadOnly = True
        Me.txNlab.Size = New System.Drawing.Size(74, 21)
        Me.txNlab.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(735, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Muestreador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Muestreador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Lab"
        '
        'dtMuestreador
        '
        Me.dtMuestreador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMuestreador.Location = New System.Drawing.Point(841, 14)
        Me.dtMuestreador.Name = "dtMuestreador"
        Me.dtMuestreador.Size = New System.Drawing.Size(125, 21)
        Me.dtMuestreador.TabIndex = 4
        '
        'cbMuestreador
        '
        Me.cbMuestreador.DataSource = Me.MUESTREADORESBindingSource
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(502, 15)
        Me.cbMuestreador.Name = "cbMuestreador"
        Me.cbMuestreador.Size = New System.Drawing.Size(181, 23)
        Me.cbMuestreador.TabIndex = 3
        Me.cbMuestreador.ValueMember = "MUE_NOMBRE"
        '
        'MUESTREADORESBindingSource
        '
        Me.MUESTREADORESBindingSource.DataMember = "MUESTREADORES"
        Me.MUESTREADORESBindingSource.DataSource = Me.LabsysDataSet3
        '
        'LabsysDataSet3
        '
        Me.LabsysDataSet3.DataSetName = "LabsysDataSet3"
        Me.LabsysDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txMuestras
        '
        Me.txMuestras.BackColor = System.Drawing.Color.White
        Me.txMuestras.Location = New System.Drawing.Point(299, 15)
        Me.txMuestras.Name = "txMuestras"
        Me.txMuestras.Size = New System.Drawing.Size(66, 21)
        Me.txMuestras.TabIndex = 2
        Me.txMuestras.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Muestras"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txIdentificacion1)
        Me.Panel2.Controls.Add(Me.txIdentificacion2)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.cbTeipoFert)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Location = New System.Drawing.Point(-3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 125)
        Me.Panel2.TabIndex = 12
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(841, 81)
        Me.btnAceptarOK.Name = "btnAceptarOK"
        Me.btnAceptarOK.Size = New System.Drawing.Size(46, 23)
        Me.btnAceptarOK.TabIndex = 40
        Me.btnAceptarOK.Text = "OK"
        Me.btnAceptarOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptarOK.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(893, 81)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 41
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(373, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(373, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación :"
        '
        'txIdentificacion1
        '
        Me.txIdentificacion1.Location = New System.Drawing.Point(106, 42)
        Me.txIdentificacion1.MaxLength = 16
        Me.txIdentificacion1.Name = "txIdentificacion1"
        Me.txIdentificacion1.Size = New System.Drawing.Size(110, 21)
        Me.txIdentificacion1.TabIndex = 11
        '
        'txIdentificacion2
        '
        Me.txIdentificacion2.Location = New System.Drawing.Point(221, 42)
        Me.txIdentificacion2.MaxLength = 16
        Me.txIdentificacion2.Name = "txIdentificacion2"
        Me.txIdentificacion2.Size = New System.Drawing.Size(110, 21)
        Me.txIdentificacion2.TabIndex = 12
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(454, 42)
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(514, 21)
        Me.txObservacion.TabIndex = 13
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocalidad.DataSource = Me.LOCALIDADBindingSource
        Me.cbLocalidad.DisplayMember = "LOCALIDAD"
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(454, 16)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(178, 23)
        Me.cbLocalidad.TabIndex = 6
        Me.cbLocalidad.ValueMember = "LOCALIDAD"
        '
        'LOCALIDADBindingSource
        '
        Me.LOCALIDADBindingSource.DataMember = "LOCALIDAD"
        Me.LOCALIDADBindingSource.DataSource = Me.LabsysDataSet7
        '
        'LabsysDataSet7
        '
        Me.LabsysDataSet7.DataSetName = "LabsysDataSet7"
        Me.LabsysDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbTeipoFert
        '
        Me.cbTeipoFert.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbTeipoFert.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTeipoFert.DataSource = Me.TEJIDOBindingSource
        Me.cbTeipoFert.DisplayMember = "tejido"
        Me.cbTeipoFert.FormattingEnabled = True
        Me.cbTeipoFert.Location = New System.Drawing.Point(786, 16)
        Me.cbTeipoFert.Name = "cbTeipoFert"
        Me.cbTeipoFert.Size = New System.Drawing.Size(182, 23)
        Me.cbTeipoFert.TabIndex = 7
        Me.cbTeipoFert.ValueMember = "tejido"
        '
        'TEJIDOBindingSource
        '
        Me.TEJIDOBindingSource.DataMember = "TEJIDO"
        Me.TEJIDOBindingSource.DataSource = Me.LabsysDataSet8
        '
        'LabsysDataSet8
        '
        Me.LabsysDataSet8.DataSetName = "LabsysDataSet8"
        Me.LabsysDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(683, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo Fertilizante :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Identificación :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Predio :"
        '
        'txPredio
        '
        Me.txPredio.Location = New System.Drawing.Point(106, 18)
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(225, 21)
        Me.txPredio.TabIndex = 5
        '
        'ESPECIEBindingSource
        '
        Me.ESPECIEBindingSource.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource.DataSource = Me.LabsysDataSet6
        '
        'LabsysDataSet6
        '
        Me.LabsysDataSet6.DataSetName = "LabsysDataSet6"
        Me.LabsysDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ESPECIEBindingSource2
        '
        Me.ESPECIEBindingSource2.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource2.DataSource = Me.LabsysDataSet8
        '
        'ESPECIEBindingSource1
        '
        Me.ESPECIEBindingSource1.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource1.DataSource = Me.LabsysDataSet6
        '
        'dgDatArgFertOrg
        '
        Me.dgDatArgFertOrg.AllowUserToAddRows = False
        Me.dgDatArgFertOrg.AllowUserToDeleteRows = False
        Me.dgDatArgFertOrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatArgFertOrg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Id1, Me.id2, Me.Predio, Me.Muestreador, Me.FMuestreo, Me.Localidad, Me.TipFert, Me.Observacion, Me.Estado})
        Me.dgDatArgFertOrg.Location = New System.Drawing.Point(-3, 183)
        Me.dgDatArgFertOrg.Name = "dgDatArgFertOrg"
        Me.dgDatArgFertOrg.ReadOnly = True
        Me.dgDatArgFertOrg.Size = New System.Drawing.Size(995, 534)
        Me.dgDatArgFertOrg.TabIndex = 42
        '
        'Nlab
        '
        Me.Nlab.HeaderText = "Nlab"
        Me.Nlab.Name = "Nlab"
        Me.Nlab.ReadOnly = True
        Me.Nlab.Width = 60
        '
        'Id1
        '
        Me.Id1.HeaderText = "Identificación(1)"
        Me.Id1.Name = "Id1"
        Me.Id1.ReadOnly = True
        Me.Id1.Width = 160
        '
        'id2
        '
        Me.id2.HeaderText = "Identificación(2)"
        Me.id2.Name = "id2"
        Me.id2.ReadOnly = True
        Me.id2.Width = 160
        '
        'Predio
        '
        Me.Predio.HeaderText = "Predio"
        Me.Predio.Name = "Predio"
        Me.Predio.ReadOnly = True
        Me.Predio.Width = 160
        '
        'Muestreador
        '
        Me.Muestreador.HeaderText = "Muestreador"
        Me.Muestreador.Name = "Muestreador"
        Me.Muestreador.ReadOnly = True
        '
        'FMuestreo
        '
        Me.FMuestreo.HeaderText = "F.Muestreo"
        Me.FMuestreo.Name = "FMuestreo"
        Me.FMuestreo.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'TipFert
        '
        Me.TipFert.HeaderText = "TipoFert"
        Me.TipFert.Name = "TipFert"
        Me.TipFert.ReadOnly = True
        Me.TipFert.Width = 70
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 150
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 70
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(-3, 718)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 51)
        Me.Panel3.TabIndex = 20
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(443, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 27)
        Me.btnAceptar.TabIndex = 43
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'MUESTREADORESTableAdapter
        '
        Me.MUESTREADORESTableAdapter.ClearBeforeFill = True
        '
        'ESPECIETableAdapter
        '
        Me.ESPECIETableAdapter.ClearBeforeFill = True
        '
        'LOCALIDADTableAdapter
        '
        Me.LOCALIDADTableAdapter.ClearBeforeFill = True
        '
        'ESPECIETableAdapter1
        '
        Me.ESPECIETableAdapter1.ClearBeforeFill = True
        '
        'TEJIDOTableAdapter
        '
        Me.TEJIDOTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(522, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 27)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_DatosAgrFertOrg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDatArgFertOrg)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_DatosAgrFertOrg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Agronómicos Fertilizantes Orgánicos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatArgFertOrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMuestreador As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents txMuestras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbTeipoFert As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txIdentificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents txIdentificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgDatArgFertOrg As System.Windows.Forms.DataGridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents txNlab As System.Windows.Forms.TextBox
    Friend WithEvents LabsysDataSet3 As LabSys.LabsysDataSet3
    Friend WithEvents MUESTREADORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MUESTREADORESTableAdapter As LabSys.LabsysDataSet3TableAdapters.MUESTREADORESTableAdapter
    Friend WithEvents LabsysDataSet6 As LabSys.LabsysDataSet6
    Friend WithEvents ESPECIEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ESPECIETableAdapter As LabSys.LabsysDataSet6TableAdapters.ESPECIETableAdapter
    Friend WithEvents LabsysDataSet7 As LabSys.LabsysDataSet7
    Friend WithEvents LOCALIDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOCALIDADTableAdapter As LabSys.LabsysDataSet7TableAdapters.LOCALIDADTableAdapter
    Friend WithEvents ESPECIEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents LabsysDataSet8 As LabSys.LabsysDataSet8
    Friend WithEvents ESPECIEBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ESPECIETableAdapter1 As LabSys.LabsysDataSet8TableAdapters.ESPECIETableAdapter
    Friend WithEvents TEJIDOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TEJIDOTableAdapter As LabSys.LabsysDataSet8TableAdapters.TEJIDOTableAdapter
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMuestreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipFert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
