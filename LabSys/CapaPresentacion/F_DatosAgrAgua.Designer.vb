<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrAgua
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrAgua))
        Me.dgDArgonomicoAgua = New System.Windows.Forms.DataGridView
        Me.nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.pred = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.loc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fmues = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.horaMues = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.origen = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Origendes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestread = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipomu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tipomdesc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tiporecip = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.det = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.volumenmu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.estadoAgua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Preserv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.fIng = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hingreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Regi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.est = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbCAOtro = New System.Windows.Forms.RadioButton
        Me.rbCASa = New System.Windows.Forms.RadioButton
        Me.rbCACompuesta = New System.Windows.Forms.RadioButton
        Me.rbCAPuntual = New System.Windows.Forms.RadioButton
        Me.Label18 = New System.Windows.Forms.Label
        Me.gbTextura = New System.Windows.Forms.GroupBox
        Me.rbOOtro = New System.Windows.Forms.RadioButton
        Me.rbOPotable = New System.Windows.Forms.RadioButton
        Me.rbOSa = New System.Windows.Forms.RadioButton
        Me.rbOPozo = New System.Windows.Forms.RadioButton
        Me.rbOCanal = New System.Windows.Forms.RadioButton
        Me.rbORio = New System.Windows.Forms.RadioButton
        Me.Label12 = New System.Windows.Forms.Label
        Me.dtFechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.dtFechaMuestreo = New System.Windows.Forms.DateTimePicker
        Me.txCAOtro = New System.Windows.Forms.TextBox
        Me.txOOtro = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txVolumen = New System.Windows.Forms.TextBox
        Me.txHoraMuestreo = New System.Windows.Forms.TextBox
        Me.txHoraIngreso = New System.Windows.Forms.TextBox
        Me.txDetalle = New System.Windows.Forms.TextBox
        Me.cbTipoRecipiente = New System.Windows.Forms.ComboBox
        Me.cbPreservante = New System.Windows.Forms.ComboBox
        Me.cbEstado = New System.Windows.Forms.ComboBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txIdentificacion1 = New System.Windows.Forms.TextBox
        Me.txIdentificacion2 = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txPredio = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txNlab = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtMuestreador = New System.Windows.Forms.DateTimePicker
        Me.cbMuestreador = New System.Windows.Forms.ComboBox
        Me.txMuestras = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.dgDArgonomicoAgua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbTextura.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDArgonomicoAgua
        '
        Me.dgDArgonomicoAgua.AllowUserToAddRows = False
        Me.dgDArgonomicoAgua.AllowUserToDeleteRows = False
        Me.dgDArgonomicoAgua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDArgonomicoAgua.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nlab, Me.id1, Me.id2, Me.pred, Me.loc, Me.fmues, Me.horaMues, Me.origen, Me.Origendes, Me.Muestread, Me.tipomu, Me.Tipomdesc, Me.tiporecip, Me.det, Me.volumenmu, Me.estadoAgua, Me.Preserv, Me.fIng, Me.Hingreso, Me.Observ, Me.Regi, Me.est})
        Me.dgDArgonomicoAgua.Location = New System.Drawing.Point(-2, 270)
        Me.dgDArgonomicoAgua.Name = "dgDArgonomicoAgua"
        Me.dgDArgonomicoAgua.ReadOnly = True
        Me.dgDArgonomicoAgua.Size = New System.Drawing.Size(995, 451)
        Me.dgDArgonomicoAgua.TabIndex = 14
        '
        'nlab
        '
        Me.nlab.HeaderText = "Nlab"
        Me.nlab.Name = "nlab"
        Me.nlab.ReadOnly = True
        Me.nlab.Width = 60
        '
        'id1
        '
        Me.id1.HeaderText = "Identificación1"
        Me.id1.Name = "id1"
        Me.id1.ReadOnly = True
        Me.id1.Width = 160
        '
        'id2
        '
        Me.id2.HeaderText = "Identificación2"
        Me.id2.Name = "id2"
        Me.id2.ReadOnly = True
        Me.id2.Width = 160
        '
        'pred
        '
        Me.pred.HeaderText = "Predio"
        Me.pred.Name = "pred"
        Me.pred.ReadOnly = True
        Me.pred.Width = 140
        '
        'loc
        '
        Me.loc.HeaderText = "Localidad"
        Me.loc.Name = "loc"
        Me.loc.ReadOnly = True
        Me.loc.Width = 60
        '
        'fmues
        '
        Me.fmues.HeaderText = "F.Muestreo"
        Me.fmues.Name = "fmues"
        Me.fmues.ReadOnly = True
        Me.fmues.Width = 60
        '
        'horaMues
        '
        Me.horaMues.HeaderText = "Hora.Muestreo"
        Me.horaMues.Name = "horaMues"
        Me.horaMues.ReadOnly = True
        Me.horaMues.Width = 60
        '
        'origen
        '
        Me.origen.HeaderText = "Origen"
        Me.origen.Name = "origen"
        Me.origen.ReadOnly = True
        Me.origen.Width = 60
        '
        'Origendes
        '
        Me.Origendes.HeaderText = "Origen.Descripción"
        Me.Origendes.Name = "Origendes"
        Me.Origendes.ReadOnly = True
        Me.Origendes.Width = 60
        '
        'Muestread
        '
        Me.Muestread.HeaderText = "Muestreador"
        Me.Muestread.Name = "Muestread"
        Me.Muestread.ReadOnly = True
        Me.Muestread.Width = 60
        '
        'tipomu
        '
        Me.tipomu.HeaderText = "CargaActual"
        Me.tipomu.Name = "tipomu"
        Me.tipomu.ReadOnly = True
        Me.tipomu.Width = 60
        '
        'Tipomdesc
        '
        Me.Tipomdesc.HeaderText = "CargaActualDesc"
        Me.Tipomdesc.Name = "Tipomdesc"
        Me.Tipomdesc.ReadOnly = True
        Me.Tipomdesc.Width = 60
        '
        'tiporecip
        '
        Me.tiporecip.HeaderText = "TipoRecipiente"
        Me.tiporecip.Name = "tiporecip"
        Me.tiporecip.ReadOnly = True
        Me.tiporecip.Width = 60
        '
        'det
        '
        Me.det.HeaderText = "Detalle"
        Me.det.Name = "det"
        Me.det.ReadOnly = True
        Me.det.Width = 60
        '
        'volumenmu
        '
        Me.volumenmu.HeaderText = "VolumenMu"
        Me.volumenmu.Name = "volumenmu"
        Me.volumenmu.ReadOnly = True
        Me.volumenmu.Width = 60
        '
        'estadoAgua
        '
        Me.estadoAgua.HeaderText = "EstadoAgua"
        Me.estadoAgua.Name = "estadoAgua"
        Me.estadoAgua.ReadOnly = True
        Me.estadoAgua.Width = 60
        '
        'Preserv
        '
        Me.Preserv.HeaderText = "Preservantes"
        Me.Preserv.Name = "Preserv"
        Me.Preserv.ReadOnly = True
        Me.Preserv.Width = 60
        '
        'fIng
        '
        Me.fIng.HeaderText = "F.Ingreso"
        Me.fIng.Name = "fIng"
        Me.fIng.ReadOnly = True
        Me.fIng.Width = 60
        '
        'Hingreso
        '
        Me.Hingreso.HeaderText = "HoraIngreso"
        Me.Hingreso.Name = "Hingreso"
        Me.Hingreso.ReadOnly = True
        Me.Hingreso.Width = 60
        '
        'Observ
        '
        Me.Observ.HeaderText = "Observaciones"
        Me.Observ.Name = "Observ"
        Me.Observ.ReadOnly = True
        Me.Observ.Width = 60
        '
        'Regi
        '
        Me.Regi.HeaderText = "Región"
        Me.Regi.Name = "Regi"
        Me.Regi.ReadOnly = True
        Me.Regi.Width = 60
        '
        'est
        '
        Me.est.HeaderText = "Estado"
        Me.est.Name = "est"
        Me.est.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.gbTextura)
        Me.Panel2.Controls.Add(Me.dtFechaIngreso)
        Me.Panel2.Controls.Add(Me.dtFechaMuestreo)
        Me.Panel2.Controls.Add(Me.txCAOtro)
        Me.Panel2.Controls.Add(Me.txOOtro)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.Label26)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txVolumen)
        Me.Panel2.Controls.Add(Me.txHoraMuestreo)
        Me.Panel2.Controls.Add(Me.txHoraIngreso)
        Me.Panel2.Controls.Add(Me.txDetalle)
        Me.Panel2.Controls.Add(Me.cbTipoRecipiente)
        Me.Panel2.Controls.Add(Me.cbPreservante)
        Me.Panel2.Controls.Add(Me.cbEstado)
        Me.Panel2.Controls.Add(Me.btnOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txIdentificacion1)
        Me.Panel2.Controls.Add(Me.txIdentificacion2)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-2, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 210)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbCAOtro)
        Me.GroupBox1.Controls.Add(Me.rbCASa)
        Me.GroupBox1.Controls.Add(Me.rbCACompuesta)
        Me.GroupBox1.Controls.Add(Me.rbCAPuntual)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(547, 27)
        Me.GroupBox1.TabIndex = 142
        Me.GroupBox1.TabStop = False
        '
        'rbCAOtro
        '
        Me.rbCAOtro.AutoSize = True
        Me.rbCAOtro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbCAOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbCAOtro.Location = New System.Drawing.Point(487, 8)
        Me.rbCAOtro.Name = "rbCAOtro"
        Me.rbCAOtro.Size = New System.Drawing.Size(45, 17)
        Me.rbCAOtro.TabIndex = 29
        Me.rbCAOtro.Text = "Otro"
        Me.rbCAOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCAOtro.UseVisualStyleBackColor = True
        '
        'rbCASa
        '
        Me.rbCASa.AutoSize = True
        Me.rbCASa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbCASa.Checked = True
        Me.rbCASa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbCASa.Location = New System.Drawing.Point(412, 8)
        Me.rbCASa.Name = "rbCASa"
        Me.rbCASa.Size = New System.Drawing.Size(41, 17)
        Me.rbCASa.TabIndex = 28
        Me.rbCASa.TabStop = True
        Me.rbCASa.Text = "s/a"
        Me.rbCASa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCASa.UseVisualStyleBackColor = True
        '
        'rbCACompuesta
        '
        Me.rbCACompuesta.AutoSize = True
        Me.rbCACompuesta.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbCACompuesta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbCACompuesta.Location = New System.Drawing.Point(180, 8)
        Me.rbCACompuesta.Name = "rbCACompuesta"
        Me.rbCACompuesta.Size = New System.Drawing.Size(78, 17)
        Me.rbCACompuesta.TabIndex = 27
        Me.rbCACompuesta.Text = "Compuesta"
        Me.rbCACompuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCACompuesta.UseVisualStyleBackColor = True
        '
        'rbCAPuntual
        '
        Me.rbCAPuntual.AutoSize = True
        Me.rbCAPuntual.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbCAPuntual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbCAPuntual.Location = New System.Drawing.Point(98, 8)
        Me.rbCAPuntual.Name = "rbCAPuntual"
        Me.rbCAPuntual.Size = New System.Drawing.Size(61, 17)
        Me.rbCAPuntual.TabIndex = 26
        Me.rbCAPuntual.Text = "Puntual"
        Me.rbCAPuntual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbCAPuntual.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(74, 13)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "Carga Actual :"
        '
        'gbTextura
        '
        Me.gbTextura.Controls.Add(Me.rbOOtro)
        Me.gbTextura.Controls.Add(Me.rbOPotable)
        Me.gbTextura.Controls.Add(Me.rbOSa)
        Me.gbTextura.Controls.Add(Me.rbOPozo)
        Me.gbTextura.Controls.Add(Me.rbOCanal)
        Me.gbTextura.Controls.Add(Me.rbORio)
        Me.gbTextura.Controls.Add(Me.Label12)
        Me.gbTextura.Location = New System.Drawing.Point(9, 128)
        Me.gbTextura.Name = "gbTextura"
        Me.gbTextura.Size = New System.Drawing.Size(547, 27)
        Me.gbTextura.TabIndex = 141
        Me.gbTextura.TabStop = False
        '
        'rbOOtro
        '
        Me.rbOOtro.AutoSize = True
        Me.rbOOtro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbOOtro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbOOtro.Location = New System.Drawing.Point(487, 8)
        Me.rbOOtro.Name = "rbOOtro"
        Me.rbOOtro.Size = New System.Drawing.Size(45, 17)
        Me.rbOOtro.TabIndex = 24
        Me.rbOOtro.Text = "Otro"
        Me.rbOOtro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOOtro.UseVisualStyleBackColor = True
        '
        'rbOPotable
        '
        Me.rbOPotable.AutoSize = True
        Me.rbOPotable.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbOPotable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbOPotable.Location = New System.Drawing.Point(323, 8)
        Me.rbOPotable.Name = "rbOPotable"
        Me.rbOPotable.Size = New System.Drawing.Size(61, 17)
        Me.rbOPotable.TabIndex = 22
        Me.rbOPotable.Text = "Potable"
        Me.rbOPotable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOPotable.UseVisualStyleBackColor = True
        '
        'rbOSa
        '
        Me.rbOSa.AutoSize = True
        Me.rbOSa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbOSa.Checked = True
        Me.rbOSa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbOSa.Location = New System.Drawing.Point(412, 8)
        Me.rbOSa.Name = "rbOSa"
        Me.rbOSa.Size = New System.Drawing.Size(41, 17)
        Me.rbOSa.TabIndex = 23
        Me.rbOSa.TabStop = True
        Me.rbOSa.Text = "s/a"
        Me.rbOSa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOSa.UseVisualStyleBackColor = True
        '
        'rbOPozo
        '
        Me.rbOPozo.AutoSize = True
        Me.rbOPozo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbOPozo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbOPozo.Location = New System.Drawing.Point(252, 8)
        Me.rbOPozo.Name = "rbOPozo"
        Me.rbOPozo.Size = New System.Drawing.Size(49, 17)
        Me.rbOPozo.TabIndex = 21
        Me.rbOPozo.Text = "Pozo"
        Me.rbOPozo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOPozo.UseVisualStyleBackColor = True
        '
        'rbOCanal
        '
        Me.rbOCanal.AutoSize = True
        Me.rbOCanal.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbOCanal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbOCanal.Location = New System.Drawing.Point(176, 8)
        Me.rbOCanal.Name = "rbOCanal"
        Me.rbOCanal.Size = New System.Drawing.Size(52, 17)
        Me.rbOCanal.TabIndex = 20
        Me.rbOCanal.Text = "Canal"
        Me.rbOCanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbOCanal.UseVisualStyleBackColor = True
        '
        'rbORio
        '
        Me.rbORio.AutoSize = True
        Me.rbORio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rbORio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.rbORio.Location = New System.Drawing.Point(98, 8)
        Me.rbORio.Name = "rbORio"
        Me.rbORio.Size = New System.Drawing.Size(41, 17)
        Me.rbORio.TabIndex = 19
        Me.rbORio.Text = "Rio"
        Me.rbORio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rbORio.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(41, 13)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "Origen:"
        '
        'dtFechaIngreso
        '
        Me.dtFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaIngreso.Location = New System.Drawing.Point(108, 103)
        Me.dtFechaIngreso.Name = "dtFechaIngreso"
        Me.dtFechaIngreso.Size = New System.Drawing.Size(81, 20)
        Me.dtFechaIngreso.TabIndex = 14
        '
        'dtFechaMuestreo
        '
        Me.dtFechaMuestreo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaMuestreo.Location = New System.Drawing.Point(108, 80)
        Me.dtFechaMuestreo.Name = "dtFechaMuestreo"
        Me.dtFechaMuestreo.Size = New System.Drawing.Size(81, 20)
        Me.dtFechaMuestreo.TabIndex = 10
        '
        'txCAOtro
        '
        Me.txCAOtro.Location = New System.Drawing.Point(562, 161)
        Me.txCAOtro.Name = "txCAOtro"
        Me.txCAOtro.Size = New System.Drawing.Size(110, 20)
        Me.txCAOtro.TabIndex = 30
        '
        'txOOtro
        '
        Me.txOOtro.Location = New System.Drawing.Point(562, 134)
        Me.txOOtro.Name = "txOOtro"
        Me.txOOtro.Size = New System.Drawing.Size(110, 20)
        Me.txOOtro.TabIndex = 25
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(768, 105)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 13)
        Me.Label28.TabIndex = 86
        Me.Label28.Text = "Preservante"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(18, 84)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(84, 13)
        Me.Label27.TabIndex = 85
        Me.Label27.Text = "Fecha Muestreo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(18, 105)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(75, 13)
        Me.Label26.TabIndex = 84
        Me.Label26.Text = "Fecha Ingreso"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(200, 84)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 13)
        Me.Label25.TabIndex = 83
        Me.Label25.Text = "Hora Muestreo"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(200, 105)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 13)
        Me.Label24.TabIndex = 82
        Me.Label24.Text = "Hora Ingreso"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(336, 84)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "hh:mm"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(408, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 80
        Me.Label20.Text = "Volumen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(629, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Detalle"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(629, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Estado"
        '
        'txVolumen
        '
        Me.txVolumen.Location = New System.Drawing.Point(492, 102)
        Me.txVolumen.Name = "txVolumen"
        Me.txVolumen.Size = New System.Drawing.Size(123, 20)
        Me.txVolumen.TabIndex = 16
        '
        'txHoraMuestreo
        '
        Me.txHoraMuestreo.Location = New System.Drawing.Point(278, 81)
        Me.txHoraMuestreo.Name = "txHoraMuestreo"
        Me.txHoraMuestreo.Size = New System.Drawing.Size(53, 20)
        Me.txHoraMuestreo.TabIndex = 11
        '
        'txHoraIngreso
        '
        Me.txHoraIngreso.Location = New System.Drawing.Point(277, 103)
        Me.txHoraIngreso.Name = "txHoraIngreso"
        Me.txHoraIngreso.Size = New System.Drawing.Size(54, 20)
        Me.txHoraIngreso.TabIndex = 15
        '
        'txDetalle
        '
        Me.txDetalle.Location = New System.Drawing.Point(672, 79)
        Me.txDetalle.Name = "txDetalle"
        Me.txDetalle.Size = New System.Drawing.Size(303, 20)
        Me.txDetalle.TabIndex = 13
        '
        'cbTipoRecipiente
        '
        Me.cbTipoRecipiente.FormattingEnabled = True
        Me.cbTipoRecipiente.Location = New System.Drawing.Point(492, 78)
        Me.cbTipoRecipiente.Name = "cbTipoRecipiente"
        Me.cbTipoRecipiente.Size = New System.Drawing.Size(123, 21)
        Me.cbTipoRecipiente.TabIndex = 12
        '
        'cbPreservante
        '
        Me.cbPreservante.FormattingEnabled = True
        Me.cbPreservante.Location = New System.Drawing.Point(838, 101)
        Me.cbPreservante.Name = "cbPreservante"
        Me.cbPreservante.Size = New System.Drawing.Size(137, 21)
        Me.cbPreservante.TabIndex = 18
        '
        'cbEstado
        '
        Me.cbEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEstado.FormattingEnabled = True
        Me.cbEstado.Location = New System.Drawing.Point(672, 102)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(79, 21)
        Me.cbEstado.TabIndex = 17
        '
        'btnOK
        '
        Me.btnOK.Image = Global.LabSys.My.Resources.Resources.accept
        Me.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOK.Location = New System.Drawing.Point(830, 159)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(44, 23)
        Me.btnOK.TabIndex = 31
        Me.btnOK.Text = "OK"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLimpiar.Location = New System.Drawing.Point(880, 159)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 32
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(336, 105)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(38, 13)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "hh:mm"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(373, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(373, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(408, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Tipo Recipiente"
        '
        'txIdentificacion1
        '
        Me.txIdentificacion1.Location = New System.Drawing.Point(88, 42)
        Me.txIdentificacion1.MaxLength = 16
        Me.txIdentificacion1.Name = "txIdentificacion1"
        Me.txIdentificacion1.Size = New System.Drawing.Size(110, 20)
        Me.txIdentificacion1.TabIndex = 7
        '
        'txIdentificacion2
        '
        Me.txIdentificacion2.Location = New System.Drawing.Point(203, 42)
        Me.txIdentificacion2.MaxLength = 16
        Me.txIdentificacion2.Name = "txIdentificacion2"
        Me.txIdentificacion2.Size = New System.Drawing.Size(110, 20)
        Me.txIdentificacion2.TabIndex = 8
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(454, 42)
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(521, 20)
        Me.txObservacion.TabIndex = 9
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(454, 17)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(178, 21)
        Me.cbLocalidad.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Predio"
        '
        'txPredio
        '
        Me.txPredio.Location = New System.Drawing.Point(89, 18)
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(225, 20)
        Me.txPredio.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Identificación"
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
        Me.Panel1.Location = New System.Drawing.Point(-2, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(995, 57)
        Me.Panel1.TabIndex = 12
        '
        'txNlab
        '
        Me.txNlab.Location = New System.Drawing.Point(88, 16)
        Me.txNlab.Name = "txNlab"
        Me.txNlab.Size = New System.Drawing.Size(74, 20)
        Me.txNlab.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(735, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Muestreador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(418, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Muestreador"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nº Lab"
        '
        'dtMuestreador
        '
        Me.dtMuestreador.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtMuestreador.Location = New System.Drawing.Point(841, 14)
        Me.dtMuestreador.Name = "dtMuestreador"
        Me.dtMuestreador.Size = New System.Drawing.Size(93, 20)
        Me.dtMuestreador.TabIndex = 4
        '
        'cbMuestreador
        '
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(502, 15)
        Me.cbMuestreador.Name = "cbMuestreador"
        Me.cbMuestreador.Size = New System.Drawing.Size(181, 21)
        Me.cbMuestreador.TabIndex = 3
        '
        'txMuestras
        '
        Me.txMuestras.Location = New System.Drawing.Point(299, 15)
        Me.txMuestras.Name = "txMuestras"
        Me.txMuestras.Size = New System.Drawing.Size(74, 20)
        Me.txMuestras.TabIndex = 2
        Me.txMuestras.Text = "1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Muestras"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(-2, 722)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 47)
        Me.Panel3.TabIndex = 15
        '
        'btnAceptar
        '
        Me.btnAceptar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptar.Location = New System.Drawing.Point(460, 11)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 27)
        Me.btnAceptar.TabIndex = 34
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(541, 11)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 27)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Imprimir"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'F_DatosAgrAgua
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDArgonomicoAgua)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_DatosAgrAgua"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Datos Argonómicos Agua"
        CType(Me.dgDArgonomicoAgua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbTextura.ResumeLayout(False)
        Me.gbTextura.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDArgonomicoAgua As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMuestreador As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents txMuestras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txHoraMuestreo As System.Windows.Forms.TextBox
    Friend WithEvents txHoraIngreso As System.Windows.Forms.TextBox
    Friend WithEvents txDetalle As System.Windows.Forms.TextBox
    Friend WithEvents cbTipoRecipiente As System.Windows.Forms.ComboBox
    Friend WithEvents cbPreservante As System.Windows.Forms.ComboBox
    Friend WithEvents cbEstado As System.Windows.Forms.ComboBox
    Friend WithEvents txIdentificacion1 As System.Windows.Forms.TextBox
    Friend WithEvents txIdentificacion2 As System.Windows.Forms.TextBox
    Friend WithEvents txCAOtro As System.Windows.Forms.TextBox
    Friend WithEvents txOOtro As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txVolumen As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dtFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtFechaMuestreo As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCAOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rbCASa As System.Windows.Forms.RadioButton
    Friend WithEvents rbCACompuesta As System.Windows.Forms.RadioButton
    Friend WithEvents rbCAPuntual As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents gbTextura As System.Windows.Forms.GroupBox
    Friend WithEvents rbOOtro As System.Windows.Forms.RadioButton
    Friend WithEvents rbOPotable As System.Windows.Forms.RadioButton
    Friend WithEvents rbOSa As System.Windows.Forms.RadioButton
    Friend WithEvents rbOPozo As System.Windows.Forms.RadioButton
    Friend WithEvents rbOCanal As System.Windows.Forms.RadioButton
    Friend WithEvents rbORio As System.Windows.Forms.RadioButton
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txNlab As System.Windows.Forms.TextBox
    Friend WithEvents nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pred As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents loc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fmues As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents horaMues As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents origen As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Origendes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestread As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipomu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipomdesc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tiporecip As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents det As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents volumenmu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estadoAgua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Preserv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fIng As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hingreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Regi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
