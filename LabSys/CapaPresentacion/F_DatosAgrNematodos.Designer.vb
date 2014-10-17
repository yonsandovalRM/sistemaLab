<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_DatosAgrNematodos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_DatosAgrNematodos))
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.dgDatArgNematodos = New System.Windows.Forms.DataGridView
        Me.Nlab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuartel1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Cuartel2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Predio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProdAnt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prodAct = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tejido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.especie = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Variedad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Vig = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cultivo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Muestreador = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FMuestreo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.est = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txCultivo = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txTipo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txPActual = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txPAnterior = New System.Windows.Forms.TextBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.rbVigSA = New System.Windows.Forms.RadioButton
        Me.rbVigAlto = New System.Windows.Forms.RadioButton
        Me.rbVigNormal2 = New System.Windows.Forms.RadioButton
        Me.rbVigNormal = New System.Windows.Forms.RadioButton
        Me.rbVigNorma = New System.Windows.Forms.RadioButton
        Me.rbVigBajo = New System.Windows.Forms.RadioButton
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnAceptarOK = New System.Windows.Forms.Button
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txCuartel1 = New System.Windows.Forms.TextBox
        Me.txCuartel2 = New System.Windows.Forms.TextBox
        Me.txObservacion = New System.Windows.Forms.TextBox
        Me.txEdad = New System.Windows.Forms.TextBox
        Me.cbLocalidad = New System.Windows.Forms.ComboBox
        Me.cbVariedad = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cbEspecie = New System.Windows.Forms.ComboBox
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
        Me.Panel3.SuspendLayout()
        CType(Me.dgDatArgNematodos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.btnAceptar)
        Me.Panel3.Location = New System.Drawing.Point(-2, 720)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(995, 51)
        Me.Panel3.TabIndex = 45
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
        'dgDatArgNematodos
        '
        Me.dgDatArgNematodos.AllowUserToAddRows = False
        Me.dgDatArgNematodos.AllowUserToDeleteRows = False
        Me.dgDatArgNematodos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDatArgNematodos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nlab, Me.Cuartel1, Me.Cuartel2, Me.Predio, Me.Localidad, Me.ProdAnt, Me.prodAct, Me.Tejido, Me.especie, Me.Variedad, Me.Edad, Me.Vig, Me.cultivo, Me.Observacion, Me.Muestreador, Me.FMuestreo, Me.est})
        Me.dgDatArgNematodos.Location = New System.Drawing.Point(-2, 301)
        Me.dgDatArgNematodos.Name = "dgDatArgNematodos"
        Me.dgDatArgNematodos.ReadOnly = True
        Me.dgDatArgNematodos.Size = New System.Drawing.Size(995, 418)
        Me.dgDatArgNematodos.TabIndex = 46
        '
        'Nlab
        '
        Me.Nlab.HeaderText = "Nlab"
        Me.Nlab.Name = "Nlab"
        Me.Nlab.ReadOnly = True
        Me.Nlab.Width = 60
        '
        'Cuartel1
        '
        Me.Cuartel1.HeaderText = "Cuartel(1)"
        Me.Cuartel1.Name = "Cuartel1"
        Me.Cuartel1.ReadOnly = True
        Me.Cuartel1.Width = 150
        '
        'Cuartel2
        '
        Me.Cuartel2.HeaderText = "Cuartel(2)"
        Me.Cuartel2.Name = "Cuartel2"
        Me.Cuartel2.ReadOnly = True
        Me.Cuartel2.Width = 150
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
        'ProdAnt
        '
        Me.ProdAnt.HeaderText = "Prod.Anterior"
        Me.ProdAnt.Name = "ProdAnt"
        Me.ProdAnt.ReadOnly = True
        '
        'prodAct
        '
        Me.prodAct.HeaderText = "Prod.Actual"
        Me.prodAct.Name = "prodAct"
        Me.prodAct.ReadOnly = True
        '
        'Tejido
        '
        Me.Tejido.HeaderText = "Tipo"
        Me.Tejido.Name = "Tejido"
        Me.Tejido.ReadOnly = True
        Me.Tejido.Width = 70
        '
        'especie
        '
        Me.especie.HeaderText = "Especie"
        Me.especie.Name = "especie"
        Me.especie.ReadOnly = True
        Me.especie.Width = 70
        '
        'Variedad
        '
        Me.Variedad.HeaderText = "Variedad"
        Me.Variedad.Name = "Variedad"
        Me.Variedad.ReadOnly = True
        Me.Variedad.Width = 70
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 30
        '
        'Vig
        '
        Me.Vig.HeaderText = "Vig"
        Me.Vig.Name = "Vig"
        Me.Vig.ReadOnly = True
        Me.Vig.Width = 30
        '
        'cultivo
        '
        Me.cultivo.HeaderText = "Cultivo"
        Me.cultivo.Name = "cultivo"
        Me.cultivo.ReadOnly = True
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
        Me.FMuestreo.Width = 60
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
        Me.Panel2.Controls.Add(Me.txCultivo)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.txTipo)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.txPActual)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txPAnterior)
        Me.Panel2.Controls.Add(Me.GroupBox3)
        Me.Panel2.Controls.Add(Me.btnAceptarOK)
        Me.Panel2.Controls.Add(Me.btnLimpiar)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txCuartel1)
        Me.Panel2.Controls.Add(Me.txCuartel2)
        Me.Panel2.Controls.Add(Me.txObservacion)
        Me.Panel2.Controls.Add(Me.txEdad)
        Me.Panel2.Controls.Add(Me.cbLocalidad)
        Me.Panel2.Controls.Add(Me.cbVariedad)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.cbEspecie)
        Me.Panel2.Controls.Add(Me.txPredio)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(-2, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(995, 241)
        Me.Panel2.TabIndex = 44
        '
        'txCultivo
        '
        Me.txCultivo.Location = New System.Drawing.Point(786, 68)
        Me.txCultivo.Name = "txCultivo"
        Me.txCultivo.Size = New System.Drawing.Size(182, 20)
        Me.txCultivo.TabIndex = 80
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(733, 71)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(39, 13)
        Me.Label18.TabIndex = 79
        Me.Label18.Text = "Cultivo"
        '
        'txTipo
        '
        Me.txTipo.Location = New System.Drawing.Point(786, 18)
        Me.txTipo.Name = "txTipo"
        Me.txTipo.Size = New System.Drawing.Size(182, 20)
        Me.txTipo.TabIndex = 78
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(375, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Prod. Actual"
        '
        'txPActual
        '
        Me.txPActual.Location = New System.Drawing.Point(454, 69)
        Me.txPActual.MaxLength = 190
        Me.txPActual.Name = "txPActual"
        Me.txPActual.Size = New System.Drawing.Size(126, 20)
        Me.txPActual.TabIndex = 76
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(18, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Prod. Anterior"
        '
        'txPAnterior
        '
        Me.txPAnterior.Location = New System.Drawing.Point(89, 68)
        Me.txPAnterior.MaxLength = 190
        Me.txPAnterior.Name = "txPAnterior"
        Me.txPAnterior.Size = New System.Drawing.Size(126, 20)
        Me.txPAnterior.TabIndex = 74
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbVigSA)
        Me.GroupBox3.Controls.Add(Me.rbVigAlto)
        Me.GroupBox3.Controls.Add(Me.rbVigNormal2)
        Me.GroupBox3.Controls.Add(Me.rbVigNormal)
        Me.GroupBox3.Controls.Add(Me.rbVigNorma)
        Me.GroupBox3.Controls.Add(Me.rbVigBajo)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 155)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(474, 30)
        Me.GroupBox3.TabIndex = 73
        Me.GroupBox3.TabStop = False
        '
        'rbVigSA
        '
        Me.rbVigSA.AutoSize = True
        Me.rbVigSA.Checked = True
        Me.rbVigSA.Location = New System.Drawing.Point(431, 11)
        Me.rbVigSA.Name = "rbVigSA"
        Me.rbVigSA.Size = New System.Drawing.Size(14, 13)
        Me.rbVigSA.TabIndex = 31
        Me.rbVigSA.TabStop = True
        Me.rbVigSA.UseVisualStyleBackColor = True
        '
        'rbVigAlto
        '
        Me.rbVigAlto.AutoSize = True
        Me.rbVigAlto.Location = New System.Drawing.Point(367, 11)
        Me.rbVigAlto.Name = "rbVigAlto"
        Me.rbVigAlto.Size = New System.Drawing.Size(14, 13)
        Me.rbVigAlto.TabIndex = 30
        Me.rbVigAlto.UseVisualStyleBackColor = True
        '
        'rbVigNormal2
        '
        Me.rbVigNormal2.AutoSize = True
        Me.rbVigNormal2.Location = New System.Drawing.Point(310, 10)
        Me.rbVigNormal2.Name = "rbVigNormal2"
        Me.rbVigNormal2.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNormal2.TabIndex = 29
        Me.rbVigNormal2.UseVisualStyleBackColor = True
        '
        'rbVigNormal
        '
        Me.rbVigNormal.AutoSize = True
        Me.rbVigNormal.Location = New System.Drawing.Point(242, 11)
        Me.rbVigNormal.Name = "rbVigNormal"
        Me.rbVigNormal.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNormal.TabIndex = 28
        Me.rbVigNormal.UseVisualStyleBackColor = True
        '
        'rbVigNorma
        '
        Me.rbVigNorma.AutoSize = True
        Me.rbVigNorma.Location = New System.Drawing.Point(183, 11)
        Me.rbVigNorma.Name = "rbVigNorma"
        Me.rbVigNorma.Size = New System.Drawing.Size(14, 13)
        Me.rbVigNorma.TabIndex = 27
        Me.rbVigNorma.UseVisualStyleBackColor = True
        '
        'rbVigBajo
        '
        Me.rbVigBajo.AutoSize = True
        Me.rbVigBajo.Location = New System.Drawing.Point(131, 10)
        Me.rbVigBajo.Name = "rbVigBajo"
        Me.rbVigBajo.Size = New System.Drawing.Size(14, 13)
        Me.rbVigBajo.TabIndex = 26
        Me.rbVigBajo.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(12, 9)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 13)
        Me.Label17.TabIndex = 59
        Me.Label17.Text = "Vigor Plantas :"
        '
        'btnAceptarOK
        '
        Me.btnAceptarOK.Image = CType(resources.GetObject("btnAceptarOK.Image"), System.Drawing.Image)
        Me.btnAceptarOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptarOK.Location = New System.Drawing.Point(841, 201)
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
        Me.btnLimpiar.Location = New System.Drawing.Point(893, 201)
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
        Me.Label22.Location = New System.Drawing.Point(387, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(53, 13)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "Localidad"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(391, 45)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Variedad"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(740, 45)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "Edad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(373, 97)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 13)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Observación"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(135, 142)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(28, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Bajo"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(177, 142)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 23
        Me.Label15.Text = "- Normal"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(236, 142)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Normal"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(306, 142)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "+Normal"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(371, 142)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(25, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Alto"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(434, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(32, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "s/ant"
        '
        'txCuartel1
        '
        Me.txCuartel1.Location = New System.Drawing.Point(89, 94)
        Me.txCuartel1.MaxLength = 16
        Me.txCuartel1.Name = "txCuartel1"
        Me.txCuartel1.Size = New System.Drawing.Size(110, 20)
        Me.txCuartel1.TabIndex = 60
        '
        'txCuartel2
        '
        Me.txCuartel2.Location = New System.Drawing.Point(204, 94)
        Me.txCuartel2.MaxLength = 16
        Me.txCuartel2.Name = "txCuartel2"
        Me.txCuartel2.Size = New System.Drawing.Size(110, 20)
        Me.txCuartel2.TabIndex = 12
        '
        'txObservacion
        '
        Me.txObservacion.Location = New System.Drawing.Point(454, 94)
        Me.txObservacion.MaxLength = 250
        Me.txObservacion.Name = "txObservacion"
        Me.txObservacion.Size = New System.Drawing.Size(514, 20)
        Me.txObservacion.TabIndex = 13
        '
        'txEdad
        '
        Me.txEdad.Location = New System.Drawing.Point(786, 42)
        Me.txEdad.Name = "txEdad"
        Me.txEdad.Size = New System.Drawing.Size(182, 20)
        Me.txEdad.TabIndex = 10
        '
        'cbLocalidad
        '
        Me.cbLocalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbLocalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbLocalidad.DisplayMember = "LOCALIDAD"
        Me.cbLocalidad.FormattingEnabled = True
        Me.cbLocalidad.Location = New System.Drawing.Point(454, 16)
        Me.cbLocalidad.Name = "cbLocalidad"
        Me.cbLocalidad.Size = New System.Drawing.Size(178, 21)
        Me.cbLocalidad.TabIndex = 6
        Me.cbLocalidad.ValueMember = "LOCALIDAD"
        '
        'cbVariedad
        '
        Me.cbVariedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbVariedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbVariedad.DisplayMember = "variedad"
        Me.cbVariedad.FormattingEnabled = True
        Me.cbVariedad.Location = New System.Drawing.Point(454, 42)
        Me.cbVariedad.Name = "cbVariedad"
        Me.cbVariedad.Size = New System.Drawing.Size(178, 21)
        Me.cbVariedad.TabIndex = 9
        Me.cbVariedad.ValueMember = "variedad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(744, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Tipo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Cuartel"
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
        'cbEspecie
        '
        Me.cbEspecie.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEspecie.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEspecie.DisplayMember = "ESP_ESPECIE"
        Me.cbEspecie.FormattingEnabled = True
        Me.cbEspecie.Location = New System.Drawing.Point(89, 42)
        Me.cbEspecie.Name = "cbEspecie"
        Me.cbEspecie.Size = New System.Drawing.Size(225, 21)
        Me.cbEspecie.TabIndex = 8
        Me.cbEspecie.ValueMember = "ESP_ESPECIE"
        '
        'txPredio
        '
        Me.txPredio.Location = New System.Drawing.Point(89, 18)
        Me.txPredio.MaxLength = 190
        Me.txPredio.Name = "txPredio"
        Me.txPredio.Size = New System.Drawing.Size(225, 20)
        Me.txPredio.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(18, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Especie"
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
        Me.Panel1.TabIndex = 43
        '
        'txNlab
        '
        Me.txNlab.BackColor = System.Drawing.Color.White
        Me.txNlab.Location = New System.Drawing.Point(89, 16)
        Me.txNlab.Name = "txNlab"
        Me.txNlab.ReadOnly = True
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
        Me.dtMuestreador.Size = New System.Drawing.Size(125, 20)
        Me.dtMuestreador.TabIndex = 4
        '
        'cbMuestreador
        '
        Me.cbMuestreador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbMuestreador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbMuestreador.DisplayMember = "MUE_NOMBRE"
        Me.cbMuestreador.FormattingEnabled = True
        Me.cbMuestreador.Location = New System.Drawing.Point(502, 15)
        Me.cbMuestreador.Name = "cbMuestreador"
        Me.cbMuestreador.Size = New System.Drawing.Size(181, 21)
        Me.cbMuestreador.TabIndex = 3
        Me.cbMuestreador.ValueMember = "MUE_NOMBRE"
        '
        'txMuestras
        '
        Me.txMuestras.BackColor = System.Drawing.Color.White
        Me.txMuestras.Location = New System.Drawing.Point(299, 15)
        Me.txMuestras.Name = "txMuestras"
        Me.txMuestras.Size = New System.Drawing.Size(38, 20)
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
        'F_DatosAgrNematodos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(995, 772)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgDatArgNematodos)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "F_DatosAgrNematodos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "F_DatosAgrNematodos"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgDatArgNematodos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents dgDatArgNematodos As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txPActual As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txPAnterior As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbVigSA As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigAlto As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNormal2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNormal As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigNorma As System.Windows.Forms.RadioButton
    Friend WithEvents rbVigBajo As System.Windows.Forms.RadioButton
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnAceptarOK As System.Windows.Forms.Button
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txCuartel1 As System.Windows.Forms.TextBox
    Friend WithEvents txCuartel2 As System.Windows.Forms.TextBox
    Friend WithEvents txObservacion As System.Windows.Forms.TextBox
    Friend WithEvents txEdad As System.Windows.Forms.TextBox
    Friend WithEvents cbLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents cbVariedad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbEspecie As System.Windows.Forms.ComboBox
    Friend WithEvents txPredio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txNlab As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtMuestreador As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbMuestreador As System.Windows.Forms.ComboBox
    Friend WithEvents txMuestras As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Nlab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuartel1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cuartel2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Predio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdAnt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prodAct As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tejido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents especie As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Variedad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vig As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cultivo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Muestreador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FMuestreo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents est As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txCultivo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txTipo As System.Windows.Forms.TextBox
End Class
