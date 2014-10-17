<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrFitopatologia

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrFitopatologia))
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbRCNo = New System.Windows.Forms.RadioButton
        Me.Label11 = New System.Windows.Forms.Label
        Me.rbRCSi = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbIdNo = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.rbIDSi = New System.Windows.Forms.RadioButton
        Me.Label10 = New System.Windows.Forms.Label
        Me.txIdentificacion1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txSintomatologia = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txEdad = New System.Windows.Forms.TextBox
        Me.cbVariedad = New System.Windows.Forms.ComboBox
        Me.ESPECIEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet6 = New LabSys.LabsysDataSet6
        Me.cbEspecie = New System.Windows.Forms.ComboBox
        Me.ESPECIEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet8 = New LabSys.LabsysDataSet8
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.LOCALIDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet7 = New LabSys.LabsysDataSet7
        Me.cbtejido = New System.Windows.Forms.ComboBox
        Me.TEJIDOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txPredio = New System.Windows.Forms.TextBox
        Me.ESPECIEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgDatArgFitopatologia = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Id1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TXTMUESTRA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Especie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.edad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sintomatologia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FMuestreo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txIdespecie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txRcolonia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tmuestra = New System.Windows.Forms.DataGridViewTextBoxColumn
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
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDatArgFitopatologia, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Location = New System.Drawing.Point(743, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "F. Muestreo:"
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
        Me.dtMuestreador.Location = New System.Drawing.Point(822, 16)
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
        Me.txMuestras.Size = New System.Drawing.Size(42, 21)
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
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txIdentificacion1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txSintomatologia)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.txEdad)
        Me.Panel2.Controls.Add(Me.cbVariedad)
        Me.Panel2.Controls.Add(Me.cbEspecie)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.cbtejido)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Location = New System.Drawing.Point(-3, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 220)
        Me.Panel2.TabIndex = 10
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbRCNo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.rbRCSi)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 32)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'rbRCNo
        '
        Me.rbRCNo.AutoSize = True
        Me.rbRCNo.Location = New System.Drawing.Point(183, 11)
        Me.rbRCNo.Name = "rbRCNo"
        Me.rbRCNo.Size = New System.Drawing.Size(41, 19)
        Me.rbRCNo.TabIndex = 17
        Me.rbRCNo.TabStop = True
        Me.rbRCNo.Text = "No"
        Me.rbRCNo.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 15)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Recuento de Colonia :"
        '
        'rbRCSi
        '
        Me.rbRCSi.AutoSize = True
        Me.rbRCSi.Location = New System.Drawing.Point(139, 11)
        Me.rbRCSi.Name = "rbRCSi"
        Me.rbRCSi.Size = New System.Drawing.Size(36, 19)
        Me.rbRCSi.TabIndex = 16
        Me.rbRCSi.TabStop = True
        Me.rbRCSi.Text = "Si"
        Me.rbRCSi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbIdNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.rbIDSi)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 32)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'rbIdNo
        '
        Me.rbIdNo.AutoSize = True
        Me.rbIdNo.Location = New System.Drawing.Point(183, 11)
        Me.rbIdNo.Name = "rbIdNo"
        Me.rbIdNo.Size = New System.Drawing.Size(41, 19)
        Me.rbIdNo.TabIndex = 15
        Me.rbIdNo.TabStop = True
        Me.rbIdNo.Text = "No"
        Me.rbIdNo.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 15)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Identificación Especie :"
        '
        'rbIDSi
        '
        Me.rbIDSi.AutoSize = True
        Me.rbIDSi.Location = New System.Drawing.Point(139, 11)
        Me.rbIDSi.Name = "rbIDSi"
        Me.rbIDSi.Size = New System.Drawing.Size(36, 19)
        Me.rbIDSi.TabIndex = 14
        Me.rbIDSi.TabStop = True
        Me.rbIDSi.Text = "Si"
        Me.rbIDSi.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 15)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "Identificación :"
        '
        'txIdentificacion1
        '
        Me.txIdentificacion1.Location = New System.Drawing.Point(115, 126)
        Me.txIdentificacion1.Name = "txIdentificacion1"
        Me.txIdentificacion1.Size = New System.Drawing.Size(197, 21)
        Me.txIdentificacion1.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 15)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Sintomatología :"
        '
        'txSintomatologia
        '
        Me.txSintomatologia.Location = New System.Drawing.Point(115, 72)
        Me.txSintomatologia.Multiline = True
        Me.txSintomatologia.Name = "txSintomatologia"
        Me.txSintomatologia.Size = New System.Drawing.Size(517, 48)
        Me.txSintomatologia.TabIndex = 11
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(378, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 15)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "Variedad :"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(743, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(42, 15)
        Me.Label20.TabIndex = 46
        Me.Label20.Text = "Edad :"
        '
        'txEdad
        '
        Me.txEdad.Location = New System.Drawing.Point(786, 45)
        Me.txEdad.Name = "txEdad"
        Me.txEdad.Size = New System.Drawing.Size(137, 21)
        Me.txEdad.TabIndex = 10
        '
        'cbVariedad
        '
        Me.cbVariedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVariedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVariedad.DataSource = Me.ESPECIEBindingSource
        Me.cbVariedad.DisplayMember = "variedad"
        Me.cbVariedad.FormattingEnabled = True
        Me.cbVariedad.Location = New System.Drawing.Point(454, 45)
        Me.cbVariedad.Name = "cbVariedad"
        Me.cbVariedad.Size = New System.Drawing.Size(178, 23)
        Me.cbVariedad.TabIndex = 9
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
        'cbEspecie
        '
        Me.cbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEspecie.DataSource = Me.ESPECIEBindingSource2
        Me.cbEspecie.DisplayMember = "ESP_ESPECIE"
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Location = New System.Drawing.Point(115, 45)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(197, 23)
        Me.cbEspecie.TabIndex = 8
        Me.cbEspecie.ValueMember = "ESP_ESPECIE"
        '
        'ESPECIEBindingSource2
        '
        Me.ESPECIEBindingSource2.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource2.DataSource = Me.LabsysDataSet8
        '
        'LabsysDataSet8
        '
        Me.LabsysDataSet8.DataSetName = "LabsysDataSet8"
        Me.LabsysDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(57, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Especie :"
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(841, 168)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(894, 168)
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
        Me.Label22.Location = New System.Drawing.Point(374, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(67, 15)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad :"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(374, 129)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(81, 15)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación :"
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(455, 126)
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
        'cbtejido
        '
        Me.cbtejido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbtejido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbtejido.DataSource = Me.TEJIDOBindingSource
        Me.cbtejido.DisplayMember = "tejido"
        Me.cbtejido.FormattingEnabled = True
        Me.cbtejido.Location = New System.Drawing.Point(786, 16)
        Me.cbtejido.Name = "cbtejido"
        Me.cbtejido.Size = New System.Drawing.Size(137, 23)
        Me.cbtejido.TabIndex = 7
        Me.cbtejido.ValueMember = "tejido"
        '
        'TEJIDOBindingSource
        '
        Me.TEJIDOBindingSource.DataMember = "TEJIDO"
        Me.TEJIDOBindingSource.DataSource = Me.LabsysDataSet8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(741, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tejido:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 15)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Predio :"
        '
        'txPredio
        '
        Me.txPredio.Location = New System.Drawing.Point(115, 18)
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(197, 21)
        Me.txPredio.TabIndex = 5
        '
        'ESPECIEBindingSource1
        '
        Me.ESPECIEBindingSource1.DataMember = "ESPECIE"
        Me.ESPECIEBindingSource1.DataSource = Me.LabsysDataSet6
        '
        'dgDatArgFitopatologia
        '
        Me.dgDatArgFitopatologia.AllowUserToAddRows = False
        Me.dgDatArgFitopatologia.AllowUserToDeleteRows = False
        Me.dgDatArgFitopatologia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatArgFitopatologia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Id1, Me.Predio, Me.Localidad, Me.TXTMUESTRA, Me.Especie, Me.variedad, Me.edad, Me.sintomatologia, Me.Observacion, Me.Muestreador, Me.FMuestreo, Me.txIdespecie, Me.txRcolonia, Me.Estado, Me.id2, Me.tmuestra})
        Me.dgDatArgFitopatologia.Location = New System.Drawing.Point(-3, 277)
        Me.dgDatArgFitopatologia.Name = "dgDatArgFitopatologia"
        Me.dgDatArgFitopatologia.ReadOnly = True
        Me.dgDatArgFitopatologia.Size = New System.Drawing.Size(995, 440)
        Me.dgDatArgFitopatologia.TabIndex = 42
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
        'Predio
        '
        Me.Predio.HeaderText = "Predio"
        Me.Predio.Name = "Predio"
        Me.Predio.ReadOnly = True
        '
        'Localidad
        '
        Me.Localidad.HeaderText = "Localidad"
        Me.Localidad.Name = "Localidad"
        Me.Localidad.ReadOnly = True
        '
        'TXTMUESTRA
        '
        Me.TXTMUESTRA.HeaderText = "Tejido"
        Me.TXTMUESTRA.Name = "TXTMUESTRA"
        Me.TXTMUESTRA.ReadOnly = True
        '
        'Especie
        '
        Me.Especie.HeaderText = "Especie"
        Me.Especie.Name = "Especie"
        Me.Especie.ReadOnly = True
        '
        'variedad
        '
        Me.variedad.HeaderText = "Variedad"
        Me.variedad.Name = "variedad"
        Me.variedad.ReadOnly = True
        '
        'edad
        '
        Me.edad.HeaderText = "Edad"
        Me.edad.Name = "edad"
        Me.edad.ReadOnly = True
        '
        'sintomatologia
        '
        Me.sintomatologia.HeaderText = "Sintomatología"
        Me.sintomatologia.Name = "sintomatologia"
        Me.sintomatologia.ReadOnly = True
        '
        'Observacion
        '
        Me.Observacion.HeaderText = "Observación"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Width = 150
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
        'txIdespecie
        '
        Me.txIdespecie.HeaderText = "ID Especie"
        Me.txIdespecie.Name = "txIdespecie"
        Me.txIdespecie.ReadOnly = True
        '
        'txRcolonia
        '
        Me.txRcolonia.HeaderText = "Rec.Colonia"
        Me.txRcolonia.Name = "txRcolonia"
        Me.txRcolonia.ReadOnly = True
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
        '
        'tmuestra
        '
        Me.tmuestra.HeaderText = "T.Muestra"
        Me.tmuestra.Name = "tmuestra"
        Me.tmuestra.ReadOnly = True
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
        'F_DatosAgrFitopatologia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDatArgFitopatologia)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_DatosAgrFitopatologia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Agronómicos Fitopatología"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MUESTREADORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ESPECIEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOCALIDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TEJIDOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ESPECIEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDatArgFitopatologia, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cbtejido As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptarOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dgDatArgFitopatologia As System.Windows.Forms.DataGridView
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txSintomatologia As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txEdad As System.Windows.Forms.TextBox
    Friend WithEvents cbVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents cbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txIdentificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbIdNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents rbIDSi As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbRCNo As System.Windows.Forms.RadioButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents rbRCSi As System.Windows.Forms.RadioButton
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TXTMUESTRA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sintomatologia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMuestreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txIdespecie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txRcolonia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tmuestra As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
