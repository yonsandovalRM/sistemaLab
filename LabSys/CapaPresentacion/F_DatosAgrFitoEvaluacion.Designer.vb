<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrFitoEvaluacion

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrFitoEvaluacion))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label18 = New System.Windows.Forms.Label
        Me.dtInicio = New System.Windows.Forms.DateTimePicker
        Me.txNEnsayo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtTermino = New System.Windows.Forms.DateTimePicker
        Me.txNlab = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbMuestreador = New System.Windows.Forms.ComboBox
        Me.MUESTREADORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet3 = New LabSys.LabsysDataSet3
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txCuartel = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txHasta = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txFechaGuarda = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txFechaCosecha = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txDesde = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txNAplicaciones = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txAnoPlantacion = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txDisPlantacion = New System.Windows.Forms.TextBox
        Me.cbVariedad = New System.Windows.Forms.ComboBox
        Me.ESPECIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet6 = New LabSys.LabsysDataSet6
        Me.Label8 = New System.Windows.Forms.Label
        Me.cbEspecie = New System.Windows.Forms.ComboBox
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txNtratamiento = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.LOCALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet7 = New LabSys.LabsysDataSet7
        Me.cbNomEnsayo = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txPredio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.TEJIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet8 = New LabSys.LabsysDataSet8
        Me.ESPECIEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ESPECIEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgDatArgFertOrg = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuartel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NEnsayo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Especie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DPlantacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NTratamiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnoPlantacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NAplicaciones = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DDesde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DFHasta = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FCosecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FDesde = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FTermino = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FGuarda = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumEnsayo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cuartel2 = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatArgFertOrg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.dtInicio)
        Me.Panel1.Controls.Add(Me.txNEnsayo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dtTermino)
        Me.Panel1.Controls.Add(Me.txNlab)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbMuestreador)
        Me.Panel1.Location = New System.Drawing.Point(-3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 57)
        Me.Panel1.TabIndex = 0
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(616, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 15)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "F.Inicio :"
        '
        'dtInicio
        '
        Me.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtInicio.Location = New System.Drawing.Point(676, 18)
        Me.dtInicio.Name = "dtInicio"
        Me.dtInicio.Size = New System.Drawing.Size(103, 21)
        Me.dtInicio.TabIndex = 4
        '
        'txNEnsayo
        '
        Me.txNEnsayo.BackColor = System.Drawing.Color.White
        Me.txNEnsayo.Location = New System.Drawing.Point(235, 18)
        Me.txNEnsayo.Name = "txNEnsayo"
        Me.txNEnsayo.ReadOnly = True
        Me.txNEnsayo.Size = New System.Drawing.Size(74, 21)
        Me.txNEnsayo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "N° Ensayo :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(793, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "F. Termino :"
        '
        'dtTermino
        '
        Me.dtTermino.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtTermino.Location = New System.Drawing.Point(867, 18)
        Me.dtTermino.Name = "dtTermino"
        Me.dtTermino.Size = New System.Drawing.Size(103, 21)
        Me.dtTermino.TabIndex = 5
        '
        'txNlab
        '
        Me.txNlab.BackColor = System.Drawing.Color.White
        Me.txNlab.Location = New System.Drawing.Point(74, 18)
        Me.txNlab.Name = "txNlab"
        Me.txNlab.ReadOnly = True
        Me.txNlab.Size = New System.Drawing.Size(74, 21)
        Me.txNlab.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(327, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Muestreador :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Lab :"
        '
        'cbMuestreador
        '
        Me.cbMuestreador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMuestreador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMuestreador.DataSource = Me.MUESTREADORESBindingSource
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(412, 17)
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
        Me.Panel2.Controls.Add(Me.txCuartel)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.txHasta)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.txFechaGuarda)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txFechaCosecha)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txDesde)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.txNAplicaciones)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txAnoPlantacion)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txDisPlantacion)
        Me.Panel2.Controls.Add(Me.cbVariedad)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cbEspecie)
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txNtratamiento)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.cbNomEnsayo)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(-3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 201)
        Me.Panel2.TabIndex = 10
        '
        'txCuartel
        '
        Me.txCuartel.Location = New System.Drawing.Point(118, 128)
        Me.txCuartel.Name = "txCuartel"
        Me.txCuartel.Size = New System.Drawing.Size(225, 21)
        Me.txCuartel.TabIndex = 19
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(19, 131)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(52, 15)
        Me.Label17.TabIndex = 61
        Me.Label17.Text = "Cuartel :"
        '
        'txHasta
        '
        Me.txHasta.Location = New System.Drawing.Point(266, 101)
        Me.txHasta.Name = "txHasta"
        Me.txHasta.Size = New System.Drawing.Size(77, 21)
        Me.txHasta.TabIndex = 16
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(215, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 15)
        Me.Label16.TabIndex = 59
        Me.Label16.Text = "Hasta :"
        '
        'txFechaGuarda
        '
        Me.txFechaGuarda.Location = New System.Drawing.Point(786, 101)
        Me.txFechaGuarda.Name = "txFechaGuarda"
        Me.txFechaGuarda.Size = New System.Drawing.Size(68, 21)
        Me.txFechaGuarda.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(683, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 15)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "Fecha Guarda :"
        '
        'txFechaCosecha
        '
        Me.txFechaCosecha.Location = New System.Drawing.Point(466, 101)
        Me.txFechaCosecha.Name = "txFechaCosecha"
        Me.txFechaCosecha.Size = New System.Drawing.Size(73, 21)
        Me.txFechaCosecha.TabIndex = 17
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(372, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 15)
        Me.Label14.TabIndex = 55
        Me.Label14.Text = "Fecha Cosecha:"
        '
        'txDesde
        '
        Me.txDesde.Location = New System.Drawing.Point(118, 101)
        Me.txDesde.Name = "txDesde"
        Me.txDesde.Size = New System.Drawing.Size(77, 21)
        Me.txDesde.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(19, 104)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 15)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Duración Desde :"
        '
        'txNAplicaciones
        '
        Me.txNAplicaciones.Location = New System.Drawing.Point(786, 74)
        Me.txNAplicaciones.Name = "txNAplicaciones"
        Me.txNAplicaciones.Size = New System.Drawing.Size(69, 21)
        Me.txNAplicaciones.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(683, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 15)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "N° Aplicaciones :"
        '
        'txAnoPlantacion
        '
        Me.txAnoPlantacion.Location = New System.Drawing.Point(465, 74)
        Me.txAnoPlantacion.Name = "txAnoPlantacion"
        Me.txAnoPlantacion.Size = New System.Drawing.Size(74, 21)
        Me.txAnoPlantacion.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(372, 77)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 15)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Año Plantación :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(683, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 15)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Dis. Plantación :"
        '
        'txDisPlantacion
        '
        Me.txDisPlantacion.Location = New System.Drawing.Point(786, 47)
        Me.txDisPlantacion.Name = "txDisPlantacion"
        Me.txDisPlantacion.Size = New System.Drawing.Size(182, 21)
        Me.txDisPlantacion.TabIndex = 11
        '
        'cbVariedad
        '
        Me.cbVariedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVariedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVariedad.DataSource = Me.ESPECIEBindingSource
        Me.cbVariedad.DisplayMember = "variedad"
        Me.cbVariedad.FormattingEnabled = True
        Me.cbVariedad.Location = New System.Drawing.Point(465, 45)
        Me.cbVariedad.Name = "cbVariedad"
        Me.cbVariedad.Size = New System.Drawing.Size(178, 23)
        Me.cbVariedad.TabIndex = 10
        Me.cbVariedad.ValueMember = "variedad"
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Variedad :"
        '
        'cbEspecie
        '
        Me.cbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEspecie.DataSource = Me.ESPECIEBindingSource
        Me.cbEspecie.DisplayMember = "ESPECIE"
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Location = New System.Drawing.Point(118, 45)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(178, 23)
        Me.cbEspecie.TabIndex = 9
        Me.cbEspecie.ValueMember = "ESPECIE"
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(839, 165)
        Me.btnAceptarOK.Name = "btnAceptarOK"
        Me.btnAceptarOK.Size = New System.Drawing.Size(48, 23)
        Me.btnAceptarOK.TabIndex = 21
        Me.btnAceptarOK.Text = "OK"
        Me.btnAceptarOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptarOK.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = CType(resources.GetObject("btnLimpiar.Image"), System.Drawing.Image)
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(893, 165)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 21
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(372, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(372, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación :"
        '
        'txNtratamiento
        '
        Me.txNtratamiento.Location = New System.Drawing.Point(118, 74)
        Me.txNtratamiento.Name = "txNtratamiento"
        Me.txNtratamiento.Size = New System.Drawing.Size(77, 21)
        Me.txNtratamiento.TabIndex = 12
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(465, 128)
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(503, 21)
        Me.txObservacion.TabIndex = 20
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocalidad.DataSource = Me.LOCALIDADBindingSource
        Me.cbLocalidad.DisplayMember = "LOCALIDAD"
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(465, 16)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(178, 23)
        Me.cbLocalidad.TabIndex = 7
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
        'cbNomEnsayo
        '
        Me.cbNomEnsayo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbNomEnsayo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNomEnsayo.FormattingEnabled = True
        Me.cbNomEnsayo.Location = New System.Drawing.Point(786, 18)
        Me.cbNomEnsayo.Name = "cbNomEnsayo"
        Me.cbNomEnsayo.Size = New System.Drawing.Size(182, 23)
        Me.cbNomEnsayo.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(683, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombre Ensayo :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Especie :"
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
        Me.txPredio.Location = New System.Drawing.Point(118, 18)
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(225, 21)
        Me.txPredio.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(18, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 15)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "N° Tratamientos :"
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
        Me.dgDatArgFertOrg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Cuartel, Me.NEnsayo, Me.Localidad, Me.Especie, Me.Variedad, Me.Predio, Me.DPlantacion, Me.NTratamiento, Me.AnoPlantacion, Me.NAplicaciones, Me.DDesde, Me.DFHasta, Me.FCosecha, Me.FDesde, Me.FTermino, Me.FGuarda, Me.Muestreador, Me.NumEnsayo, Me.Observacion, Me.Estado, Me.cuartel2})
        Me.dgDatArgFertOrg.Location = New System.Drawing.Point(-3, 258)
        Me.dgDatArgFertOrg.Name = "dgDatArgFertOrg"
        Me.dgDatArgFertOrg.ReadOnly = True
        Me.dgDatArgFertOrg.Size = New System.Drawing.Size(995, 447)
        Me.dgDatArgFertOrg.TabIndex = 42
        '
        'Nlab
        '
        Me.Nlab.HeaderText = "Nlab"
        Me.Nlab.Name = "Nlab"
        Me.Nlab.ReadOnly = True
        Me.Nlab.Width = 60
        '
        'Cuartel
        '
        Me.Cuartel.HeaderText = "Cuartel"
        Me.Cuartel.Name = "Cuartel"
        Me.Cuartel.ReadOnly = True
        '
        'NEnsayo
        '
        Me.NEnsayo.HeaderText = "Ensayo"
        Me.NEnsayo.Name = "NEnsayo"
        Me.NEnsayo.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'Especie
        '
        Me.Especie.HeaderText = "Especie"
        Me.Especie.Name = "Especie"
        Me.Especie.ReadOnly = True
        '
        'Variedad
        '
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 70
        '
        'Predio
        '
        Me.Predio.HeaderText = "Predio"
        Me.Predio.Name = "Predio"
        Me.Predio.ReadOnly = True
        '
        'DPlantacion
        '
        Me.DPlantacion.HeaderText = "D. Plantación"
        Me.DPlantacion.Name = "DPlantacion"
        Me.DPlantacion.ReadOnly = True
        Me.DPlantacion.Width = 130
        '
        'NTratamiento
        '
        Me.NTratamiento.HeaderText = "N° Tratamiento"
        Me.NTratamiento.Name = "NTratamiento"
        Me.NTratamiento.ReadOnly = True
        Me.NTratamiento.Width = 130
        '
        'AnoPlantacion
        '
        Me.AnoPlantacion.HeaderText = "Año Plantación"
        Me.AnoPlantacion.Name = "AnoPlantacion"
        Me.AnoPlantacion.ReadOnly = True
        Me.AnoPlantacion.Width = 140
        '
        'NAplicaciones
        '
        Me.NAplicaciones.HeaderText = "N° Aplicaciones"
        Me.NAplicaciones.Name = "NAplicaciones"
        Me.NAplicaciones.ReadOnly = True
        Me.NAplicaciones.Width = 140
        '
        'DDesde
        '
        Me.DDesde.HeaderText = "D.F.Desde"
        Me.DDesde.Name = "DDesde"
        Me.DDesde.ReadOnly = True
        '
        'DFHasta
        '
        Me.DFHasta.HeaderText = "D.F.Hasta"
        Me.DFHasta.Name = "DFHasta"
        Me.DFHasta.ReadOnly = True
        '
        'FCosecha
        '
        Me.FCosecha.HeaderText = "F.Cosecha"
        Me.FCosecha.Name = "FCosecha"
        Me.FCosecha.ReadOnly = True
        '
        'FDesde
        '
        Me.FDesde.HeaderText = "F.Inicio"
        Me.FDesde.Name = "FDesde"
        Me.FDesde.ReadOnly = True
        '
        'FTermino
        '
        Me.FTermino.HeaderText = "F.Termino"
        Me.FTermino.Name = "FTermino"
        Me.FTermino.ReadOnly = True
        '
        'FGuarda
        '
        Me.FGuarda.HeaderText = "F.Guarda"
        Me.FGuarda.Name = "FGuarda"
        Me.FGuarda.ReadOnly = True
        '
        'Muestreador
        '
        Me.Muestreador.HeaderText = "Muestreador"
        Me.Muestreador.Name = "Muestreador"
        Me.Muestreador.ReadOnly = True
        '
        'NumEnsayo
        '
        Me.NumEnsayo.HeaderText = "N°Ensayo"
        Me.NumEnsayo.Name = "NumEnsayo"
        Me.NumEnsayo.ReadOnly = True
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
        'cuartel2
        '
        Me.cuartel2.HeaderText = "Cuartel 2"
        Me.cuartel2.Name = "cuartel2"
        Me.cuartel2.ReadOnly = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(-3, 705)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 64)
        Me.Panel3.TabIndex = 20
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = CType(resources.GetObject("btnAceptar.Image"), System.Drawing.Image)
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(443, 13)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(73, 23)
        Me.btnAceptar.TabIndex = 22
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
        'F_DatosAgrFitoEvaluacion
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
        Me.Name = "F_DatosAgrFitoEvaluacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Agronómicos Fito Evaluacón"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatArgFertOrg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbNomEnsayo As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txNtratamiento As System.Windows.Forms.TextBox
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txDisPlantacion As System.Windows.Forms.TextBox
    Friend WithEvents txNAplicaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txAnoPlantacion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txFechaGuarda As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txFechaCosecha As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txCuartel As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents txNEnsayo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuartel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NEnsayo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DPlantacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NTratamiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnoPlantacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAplicaciones As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DDesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DFHasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FCosecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDesde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FTermino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FGuarda As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumEnsayo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cuartel2 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
