<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrFitoMonitoreo

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrFitoMonitoreo))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtIngreso = New System.Windows.Forms.DateTimePicker
        Me.txNlab = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtMuestreador = New System.Windows.Forms.DateTimePicker
        Me.cbMuestreador = New System.Windows.Forms.ComboBox
        Me.MUESTREADORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet3 = New LabSys.LabsysDataSet3
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txNMDactilares = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txNaguas = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txEspProcesada = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txNtuneles = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txNplacas3 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txNplacas2 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txNplacas1 = New System.Windows.Forms.TextBox
        Me.txNCamaras = New System.Windows.Forms.TextBox
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txIdentificacion1 = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txNLineas = New System.Windows.Forms.TextBox
        Me.LOCALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet7 = New LabSys.LabsysDataSet7
        Me.TEJIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet8 = New LabSys.LabsysDataSet8
        Me.ESPECIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet6 = New LabSys.LabsysDataSet6
        Me.ESPECIEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESPECIEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgDatArgMonitoreo = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipFert = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ntuneles = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EProcesada = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nplacas1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nplacas2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nplacas3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Naguas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ndactilares = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FMuestreo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fingreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.MUESTREADORESTableAdapter = New LabSys.LabsysDataSet3TableAdapters.MUESTREADORESTableAdapter
        Me.ESPECIETableAdapter = New LabSys.LabsysDataSet6TableAdapters.ESPECIETableAdapter
        Me.LOCALIDADTableAdapter = New LabSys.LabsysDataSet7TableAdapters.LOCALIDADTableAdapter
        Me.ESPECIETableAdapter1 = New LabSys.LabsysDataSet8TableAdapters.ESPECIETableAdapter
        Me.TEJIDOTableAdapter = New LabSys.LabsysDataSet8TableAdapters.TEJIDOTableAdapter
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
        CType(Me.dgDatArgMonitoreo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtIngreso)
        Me.Panel1.Controls.Add(Me.txNlab)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtMuestreador)
        Me.Panel1.Controls.Add(Me.cbMuestreador)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(778, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "F.Ingreso:"
        '
        'dtIngreso
        '
        Me.dtIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtIngreso.Location = New System.Drawing.Point(843, 17)
        Me.dtIngreso.Name = "dtIngreso"
        Me.dtIngreso.Size = New System.Drawing.Size(106, 21)
        Me.dtIngreso.TabIndex = 5
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
        Me.Label4.Location = New System.Drawing.Point(535, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "F.Muestreo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Muestreador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Lab:"
        '
        'dtMuestreador
        '
        Me.dtMuestreador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMuestreador.Location = New System.Drawing.Point(612, 17)
        Me.dtMuestreador.Name = "dtMuestreador"
        Me.dtMuestreador.Size = New System.Drawing.Size(105, 21)
        Me.dtMuestreador.TabIndex = 4
        '
        'cbMuestreador
        '
        Me.cbMuestreador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMuestreador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMuestreador.DataSource = Me.MUESTREADORESBindingSource
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(297, 16)
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txNMDactilares)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txNaguas)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.txEspProcesada)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txNtuneles)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txNplacas3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txNplacas2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txNplacas1)
        Me.Panel2.Controls.Add(Me.txNCamaras)
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txIdentificacion1)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txNLineas)
        Me.Panel2.Location = New System.Drawing.Point(-3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 173)
        Me.Panel2.TabIndex = 10
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(371, 72)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(134, 23)
        Me.cbLocalidad.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(301, 75)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 15)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Localidad :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 15)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "N° M. Dactilares :"
        '
        'txNMDactilares
        '
        Me.txNMDactilares.Location = New System.Drawing.Point(128, 72)
        Me.txNMDactilares.Name = "txNMDactilares"
        Me.txNMDactilares.Size = New System.Drawing.Size(110, 21)
        Me.txNMDactilares.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(789, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 15)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "N° Aguas :"
        '
        'txNaguas
        '
        Me.txNaguas.Location = New System.Drawing.Point(854, 45)
        Me.txNaguas.Name = "txNaguas"
        Me.txNaguas.Size = New System.Drawing.Size(110, 21)
        Me.txNaguas.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(734, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 15)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Especie Procesada :"
        '
        'txEspProcesada
        '
        Me.txEspProcesada.Location = New System.Drawing.Point(854, 18)
        Me.txEspProcesada.Name = "txEspProcesada"
        Me.txEspProcesada.Size = New System.Drawing.Size(110, 21)
        Me.txEspProcesada.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(534, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 15)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "N° Túneles :"
        '
        'txNtuneles
        '
        Me.txNtuneles.Location = New System.Drawing.Point(607, 18)
        Me.txNtuneles.Name = "txNtuneles"
        Me.txNtuneles.Size = New System.Drawing.Size(110, 21)
        Me.txNtuneles.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(539, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 15)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "N° Placas :"
        '
        'txNplacas3
        '
        Me.txNplacas3.Location = New System.Drawing.Point(607, 45)
        Me.txNplacas3.Name = "txNplacas3"
        Me.txNplacas3.Size = New System.Drawing.Size(110, 21)
        Me.txNplacas3.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(301, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 15)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "N° Placas :"
        '
        'txNplacas2
        '
        Me.txNplacas2.Location = New System.Drawing.Point(371, 45)
        Me.txNplacas2.Name = "txNplacas2"
        Me.txNplacas2.Size = New System.Drawing.Size(110, 21)
        Me.txNplacas2.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "N° Placas :"
        '
        'txNplacas1
        '
        Me.txNplacas1.Location = New System.Drawing.Point(128, 45)
        Me.txNplacas1.Name = "txNplacas1"
        Me.txNplacas1.Size = New System.Drawing.Size(110, 21)
        Me.txNplacas1.TabIndex = 10
        '
        'txNCamaras
        '
        Me.txNCamaras.Location = New System.Drawing.Point(371, 18)
        Me.txNCamaras.Name = "txNCamaras"
        Me.txNCamaras.Size = New System.Drawing.Size(110, 21)
        Me.txNCamaras.TabIndex = 7
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(821, 118)
        Me.btnAceptarOK.Name = "btnAceptarOK"
        Me.btnAceptarOK.Size = New System.Drawing.Size(47, 23)
        Me.btnAceptarOK.TabIndex = 40
        Me.btnAceptarOK.Text = "OK"
        Me.btnAceptarOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptarOK.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(874, 118)
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
        Me.Label22.Location = New System.Drawing.Point(290, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(80, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "N° Camaras :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(41, 104)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación :"
        '
        'txIdentificacion1
        '
        Me.txIdentificacion1.Location = New System.Drawing.Point(607, 72)
        Me.txIdentificacion1.MaxLength = 190
        Me.txIdentificacion1.Name = "txIdentificacion1"
        Me.txIdentificacion1.Size = New System.Drawing.Size(213, 21)
        Me.txIdentificacion1.TabIndex = 11
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(128, 101)
        Me.txObservacion.MaxLength = 250
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(514, 21)
        Me.txObservacion.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(523, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Identificación :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "N° Lineas :"
        '
        'txNLineas
        '
        Me.txNLineas.Location = New System.Drawing.Point(128, 18)
        Me.txNLineas.Name = "txNLineas"
        Me.txNLineas.Size = New System.Drawing.Size(110, 21)
        Me.txNLineas.TabIndex = 6
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
        'dgDatArgMonitoreo
        '
        Me.dgDatArgMonitoreo.AllowUserToAddRows = False
        Me.dgDatArgMonitoreo.AllowUserToDeleteRows = False
        Me.dgDatArgMonitoreo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatArgMonitoreo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Id1, Me.Localidad, Me.TipFert, Me.Predio, Me.Ntuneles, Me.EProcesada, Me.Nplacas1, Me.Nplacas2, Me.Nplacas3, Me.Naguas, Me.Ndactilares, Me.Observacion, Me.FMuestreo, Me.Muestreador, Me.fingreso, Me.Estado, Me.id2})
        Me.dgDatArgMonitoreo.Location = New System.Drawing.Point(-3, 231)
        Me.dgDatArgMonitoreo.Name = "dgDatArgMonitoreo"
        Me.dgDatArgMonitoreo.ReadOnly = True
        Me.dgDatArgMonitoreo.Size = New System.Drawing.Size(995, 486)
        Me.dgDatArgMonitoreo.TabIndex = 42
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
        Me.Id1.HeaderText = "Identificación"
        Me.Id1.Name = "Id1"
        Me.Id1.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'TipFert
        '
        Me.TipFert.HeaderText = "N° Lineas"
        Me.TipFert.Name = "TipFert"
        Me.TipFert.ReadOnly = True
        Me.TipFert.Width = 90
        '
        'Predio
        '
        Me.Predio.HeaderText = "N° Camaras"
        Me.Predio.Name = "Predio"
        Me.Predio.ReadOnly = True
        '
        'Ntuneles
        '
        Me.Ntuneles.HeaderText = "N° Túneles"
        Me.Ntuneles.Name = "Ntuneles"
        Me.Ntuneles.ReadOnly = True
        '
        'EProcesada
        '
        Me.EProcesada.HeaderText = "Esp. Procesada"
        Me.EProcesada.Name = "EProcesada"
        Me.EProcesada.ReadOnly = True
        Me.EProcesada.Width = 120
        '
        'Nplacas1
        '
        Me.Nplacas1.HeaderText = "N° Placas1"
        Me.Nplacas1.Name = "Nplacas1"
        Me.Nplacas1.ReadOnly = True
        '
        'Nplacas2
        '
        Me.Nplacas2.HeaderText = "N° Placas2"
        Me.Nplacas2.Name = "Nplacas2"
        Me.Nplacas2.ReadOnly = True
        '
        'Nplacas3
        '
        Me.Nplacas3.HeaderText = "N° Placas3"
        Me.Nplacas3.Name = "Nplacas3"
        Me.Nplacas3.ReadOnly = True
        '
        'Naguas
        '
        Me.Naguas.HeaderText = "N° Aguas"
        Me.Naguas.Name = "Naguas"
        Me.Naguas.ReadOnly = True
        '
        'Ndactilares
        '
        Me.Ndactilares.HeaderText = "N° D.Dactilares"
        Me.Ndactilares.Name = "Ndactilares"
        Me.Ndactilares.ReadOnly = True
        Me.Ndactilares.Width = 120
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 150
        '
        'FMuestreo
        '
        Me.FMuestreo.HeaderText = "F.Muestreo"
        Me.FMuestreo.Name = "FMuestreo"
        Me.FMuestreo.ReadOnly = True
        '
        'Muestreador
        '
        Me.Muestreador.HeaderText = "Muestreador"
        Me.Muestreador.Name = "Muestreador"
        Me.Muestreador.ReadOnly = True
        Me.Muestreador.Width = 120
        '
        'fingreso
        '
        Me.fingreso.HeaderText = "F.Ingreso"
        Me.fingreso.Name = "fingreso"
        Me.fingreso.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 70
        '
        'id2
        '
        Me.id2.HeaderText = "Identificación(2)"
        Me.id2.Name = "id2"
        Me.id2.ReadOnly = True
        Me.id2.Width = 120
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
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
        Me.btnAceptar.Location = New System.Drawing.Point(443, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 23)
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
        'F_DatosAgrFitoMonitoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDatArgMonitoreo)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_DatosAgrFitoMonitoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Agronómicos Fito. Monitoreos"
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
        CType(Me.dgDatArgMonitoreo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMuestreador As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txNLineas As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txIdentificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgDatArgMonitoreo As System.Windows.Forms.DataGridView
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
    Friend WithEvents txNCamaras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txNMDactilares As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txNaguas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txEspProcesada As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txNtuneles As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txNplacas3 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txNplacas2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txNplacas1 As System.Windows.Forms.TextBox
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipFert As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ntuneles As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EProcesada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nplacas1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nplacas2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nplacas3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Naguas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ndactilares As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMuestreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
