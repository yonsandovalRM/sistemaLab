<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_COM
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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_COM))
        Me.grilla_COM = New System.Windows.Forms.DataGridView
        Me.NOTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RutProductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RutFacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RemiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TipoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.COMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGROLAB_PRUEBADataSet2 = New LabSys.AGROLAB_PRUEBADataSet2
        Me.btn_Aceptar = New System.Windows.Forms.Button
        Me.TxtBusOtHasta = New System.Windows.Forms.TextBox
        Me.TxtBusFactura = New System.Windows.Forms.TextBox
        Me.TxtBusFechaDesde = New System.Windows.Forms.TextBox
        Me.TxtBusEmpresa = New System.Windows.Forms.TextBox
        Me.TxtBusOtDesde = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CBBusMuestra = New System.Windows.Forms.ComboBox
        Me.TxtBusProductor = New System.Windows.Forms.TextBox
        Me.TxtBusRutFact = New System.Windows.Forms.TextBox
        Me.TxtBusRut = New System.Windows.Forms.TextBox
        Me.TxtBusRemite = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.btn_buscaProductor = New System.Windows.Forms.Button
        Me.btn_buscaFecha = New System.Windows.Forms.Button
        Me.COMTableAdapter = New LabSys.AGROLAB_PRUEBADataSet2TableAdapters.COMTableAdapter
        Me.ElGroupBox1 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_EstadoFac = New System.Windows.Forms.TextBox
        Me.txOTSeleccionada = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.CmdOrdenTrabajo = New System.Windows.Forms.Button
        Me.CmdEliminarAnálisis = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.CmdAgregarAnalisis = New System.Windows.Forms.Button
        Me.TxtBusLabDesde = New System.Windows.Forms.TextBox
        Me.TxtBusLabHasta = New System.Windows.Forms.TextBox
        Me.DtpFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.btn_buscaNlab = New System.Windows.Forms.Button
        Me.btn_buscaTipoMuestra = New System.Windows.Forms.Button
        Me.btn_buscaEmpresa = New System.Windows.Forms.Button
        Me.btn_buscaRemite = New System.Windows.Forms.Button
        Me.btn_buscaFactura = New System.Windows.Forms.Button
        Me.btn_buscaRutPro = New System.Windows.Forms.Button
        Me.btn_buscaRutFac = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.PanelTipo = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.dt_Tipo = New System.Windows.Forms.DateTimePicker
        Me.btn_buscaNlabY = New System.Windows.Forms.Button
        Me.TxtBusLabDesdeY = New System.Windows.Forms.TextBox
        Me.TxtBusLabHastaY = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.pnl_resultados = New System.Windows.Forms.Panel
        Me.Button8 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.lbx_lista = New System.Windows.Forms.ListBox
        Me.GrbModificacion = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        CType(Me.grilla_COM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGROLAB_PRUEBADataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox1.SuspendLayout()
        Me.PanelTipo.SuspendLayout()
        Me.pnl_resultados.SuspendLayout()
        Me.GrbModificacion.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grilla_COM
        '
        Me.grilla_COM.AllowUserToAddRows = False
        Me.grilla_COM.AllowUserToDeleteRows = False
        Me.grilla_COM.AutoGenerateColumns = False
        Me.grilla_COM.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_COM.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grilla_COM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla_COM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOTDataGridViewTextBoxColumn, Me.FIngreso, Me.ProductorDataGridViewTextBoxColumn, Me.RutProductorDataGridViewTextBoxColumn, Me.RutFacturaDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn, Me.RemiteDataGridViewTextBoxColumn, Me.TipoDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.DesdeDataGridViewTextBoxColumn, Me.AnaDataGridViewTextBoxColumn, Me.PagDataGridViewTextBoxColumn, Me.FacDataGridViewTextBoxColumn, Me.NumeroDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn})
        Me.grilla_COM.DataSource = Me.COMBindingSource
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grilla_COM.DefaultCellStyle = DataGridViewCellStyle15
        Me.grilla_COM.GridColor = System.Drawing.SystemColors.Control
        Me.grilla_COM.Location = New System.Drawing.Point(-16, 37)
        Me.grilla_COM.Name = "grilla_COM"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grilla_COM.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.grilla_COM.Size = New System.Drawing.Size(1290, 691)
        Me.grilla_COM.TabIndex = 0
        '
        'NOTDataGridViewTextBoxColumn
        '
        Me.NOTDataGridViewTextBoxColumn.DataPropertyName = "N° OT"
        Me.NOTDataGridViewTextBoxColumn.HeaderText = "N° OT"
        Me.NOTDataGridViewTextBoxColumn.Name = "NOTDataGridViewTextBoxColumn"
        Me.NOTDataGridViewTextBoxColumn.Width = 50
        '
        'FIngreso
        '
        Me.FIngreso.DataPropertyName = "FIngreso"
        Me.FIngreso.HeaderText = "F.Ingreso"
        Me.FIngreso.Name = "FIngreso"
        Me.FIngreso.Width = 90
        '
        'ProductorDataGridViewTextBoxColumn
        '
        Me.ProductorDataGridViewTextBoxColumn.DataPropertyName = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.HeaderText = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.Name = "ProductorDataGridViewTextBoxColumn"
        Me.ProductorDataGridViewTextBoxColumn.Width = 260
        '
        'RutProductorDataGridViewTextBoxColumn
        '
        Me.RutProductorDataGridViewTextBoxColumn.DataPropertyName = "Rut Productor"
        Me.RutProductorDataGridViewTextBoxColumn.HeaderText = "Rut Productor"
        Me.RutProductorDataGridViewTextBoxColumn.Name = "RutProductorDataGridViewTextBoxColumn"
        Me.RutProductorDataGridViewTextBoxColumn.Width = 90
        '
        'RutFacturaDataGridViewTextBoxColumn
        '
        Me.RutFacturaDataGridViewTextBoxColumn.DataPropertyName = "Rut Factura"
        Me.RutFacturaDataGridViewTextBoxColumn.HeaderText = "Rut Factura"
        Me.RutFacturaDataGridViewTextBoxColumn.Name = "RutFacturaDataGridViewTextBoxColumn"
        Me.RutFacturaDataGridViewTextBoxColumn.Width = 90
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.Width = 150
        '
        'RemiteDataGridViewTextBoxColumn
        '
        Me.RemiteDataGridViewTextBoxColumn.DataPropertyName = "Remite"
        Me.RemiteDataGridViewTextBoxColumn.HeaderText = "Remite"
        Me.RemiteDataGridViewTextBoxColumn.Name = "RemiteDataGridViewTextBoxColumn"
        Me.RemiteDataGridViewTextBoxColumn.Width = 150
        '
        'TipoDataGridViewTextBoxColumn
        '
        Me.TipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.HeaderText = "Tipo"
        Me.TipoDataGridViewTextBoxColumn.Name = "TipoDataGridViewTextBoxColumn"
        Me.TipoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TipoDataGridViewTextBoxColumn.Width = 40
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.Width = 40
        '
        'DesdeDataGridViewTextBoxColumn
        '
        Me.DesdeDataGridViewTextBoxColumn.DataPropertyName = "Desde"
        DataGridViewCellStyle14.Format = "N0"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.DesdeDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.DesdeDataGridViewTextBoxColumn.HeaderText = "Desde"
        Me.DesdeDataGridViewTextBoxColumn.Name = "DesdeDataGridViewTextBoxColumn"
        Me.DesdeDataGridViewTextBoxColumn.Width = 60
        '
        'AnaDataGridViewTextBoxColumn
        '
        Me.AnaDataGridViewTextBoxColumn.DataPropertyName = "Ana"
        Me.AnaDataGridViewTextBoxColumn.HeaderText = "Ana"
        Me.AnaDataGridViewTextBoxColumn.Name = "AnaDataGridViewTextBoxColumn"
        Me.AnaDataGridViewTextBoxColumn.Width = 30
        '
        'PagDataGridViewTextBoxColumn
        '
        Me.PagDataGridViewTextBoxColumn.DataPropertyName = "Pag"
        Me.PagDataGridViewTextBoxColumn.HeaderText = "Pag"
        Me.PagDataGridViewTextBoxColumn.Name = "PagDataGridViewTextBoxColumn"
        Me.PagDataGridViewTextBoxColumn.Width = 30
        '
        'FacDataGridViewTextBoxColumn
        '
        Me.FacDataGridViewTextBoxColumn.DataPropertyName = "Fac"
        Me.FacDataGridViewTextBoxColumn.HeaderText = "Fac"
        Me.FacDataGridViewTextBoxColumn.Name = "FacDataGridViewTextBoxColumn"
        Me.FacDataGridViewTextBoxColumn.Width = 30
        '
        'NumeroDataGridViewTextBoxColumn
        '
        Me.NumeroDataGridViewTextBoxColumn.DataPropertyName = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.HeaderText = "Numero"
        Me.NumeroDataGridViewTextBoxColumn.Name = "NumeroDataGridViewTextBoxColumn"
        Me.NumeroDataGridViewTextBoxColumn.Width = 50
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.Width = 65
        '
        'COMBindingSource
        '
        Me.COMBindingSource.DataMember = "COM"
        Me.COMBindingSource.DataSource = Me.AGROLAB_PRUEBADataSet2
        '
        'AGROLAB_PRUEBADataSet2
        '
        Me.AGROLAB_PRUEBADataSet2.DataSetName = "AGROLAB_PRUEBADataSet2"
        Me.AGROLAB_PRUEBADataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btn_Aceptar
        '
        Me.btn_Aceptar.Image = CType(resources.GetObject("btn_Aceptar.Image"), System.Drawing.Image)
        Me.btn_Aceptar.Location = New System.Drawing.Point(288, 62)
        Me.btn_Aceptar.Name = "btn_Aceptar"
        Me.btn_Aceptar.Size = New System.Drawing.Size(31, 23)
        Me.btn_Aceptar.TabIndex = 2
        Me.btn_Aceptar.UseVisualStyleBackColor = True
        '
        'TxtBusOtHasta
        '
        Me.TxtBusOtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusOtHasta.Location = New System.Drawing.Point(203, 64)
        Me.TxtBusOtHasta.Name = "TxtBusOtHasta"
        Me.TxtBusOtHasta.Size = New System.Drawing.Size(79, 20)
        Me.TxtBusOtHasta.TabIndex = 237
        '
        'TxtBusFactura
        '
        Me.TxtBusFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusFactura.Location = New System.Drawing.Point(740, 36)
        Me.TxtBusFactura.Name = "TxtBusFactura"
        Me.TxtBusFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusFactura.TabIndex = 243
        '
        'TxtBusFechaDesde
        '
        Me.TxtBusFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusFechaDesde.Location = New System.Drawing.Point(100, 35)
        Me.TxtBusFechaDesde.MaxLength = 4
        Me.TxtBusFechaDesde.Name = "TxtBusFechaDesde"
        Me.TxtBusFechaDesde.Size = New System.Drawing.Size(92, 20)
        Me.TxtBusFechaDesde.TabIndex = 230
        '
        'TxtBusEmpresa
        '
        Me.TxtBusEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusEmpresa.Location = New System.Drawing.Point(430, 9)
        Me.TxtBusEmpresa.Name = "TxtBusEmpresa"
        Me.TxtBusEmpresa.Size = New System.Drawing.Size(208, 20)
        Me.TxtBusEmpresa.TabIndex = 242
        '
        'TxtBusOtDesde
        '
        Me.TxtBusOtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusOtDesde.Location = New System.Drawing.Point(99, 64)
        Me.TxtBusOtDesde.Name = "TxtBusOtDesde"
        Me.TxtBusOtDesde.Size = New System.Drawing.Size(79, 20)
        Me.TxtBusOtDesde.TabIndex = 236
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(184, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 238
        Me.Label9.Text = "Al"
        '
        'CBBusMuestra
        '
        Me.CBBusMuestra.DisplayMember = "MUESTRA.TMU_CODIGO"
        Me.CBBusMuestra.Items.AddRange(New Object() {"FITOPATOLOGIA", "SUELO", "TEJIDO", "FOLIAR", "AGUA", "FERT. QUIMICO", "FERT. ORGANICO", "OTROS"})
        Me.CBBusMuestra.Location = New System.Drawing.Point(103, 3)
        Me.CBBusMuestra.Name = "CBBusMuestra"
        Me.CBBusMuestra.Size = New System.Drawing.Size(181, 21)
        Me.CBBusMuestra.TabIndex = 229
        Me.CBBusMuestra.ValueMember = "MUESTRA.TMU_CODIGO"
        '
        'TxtBusProductor
        '
        Me.TxtBusProductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusProductor.Location = New System.Drawing.Point(100, 9)
        Me.TxtBusProductor.Name = "TxtBusProductor"
        Me.TxtBusProductor.Size = New System.Drawing.Size(182, 20)
        Me.TxtBusProductor.TabIndex = 233
        '
        'TxtBusRutFact
        '
        Me.TxtBusRutFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRutFact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusRutFact.Location = New System.Drawing.Point(1112, 34)
        Me.TxtBusRutFact.Name = "TxtBusRutFact"
        Me.TxtBusRutFact.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusRutFact.TabIndex = 232
        '
        'TxtBusRut
        '
        Me.TxtBusRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusRut.Location = New System.Drawing.Point(1112, 8)
        Me.TxtBusRut.Name = "TxtBusRut"
        Me.TxtBusRut.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusRut.TabIndex = 231
        '
        'TxtBusRemite
        '
        Me.TxtBusRemite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRemite.Location = New System.Drawing.Point(740, 9)
        Me.TxtBusRemite.Name = "TxtBusRemite"
        Me.TxtBusRemite.Size = New System.Drawing.Size(210, 20)
        Me.TxtBusRemite.TabIndex = 239
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(343, 12)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 241
        Me.Label13.Text = "Empresa"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(687, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 240
        Me.Label10.Text = "Remite"
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(1029, 10)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(63, 17)
        Me.Label81.TabIndex = 222
        Me.Label81.Text = "Rut Prod :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(22, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 235
        Me.Label8.Text = "N° OT Del"
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(343, 39)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(86, 16)
        Me.Label90.TabIndex = 220
        Me.Label90.Text = "Tipo muestra"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 234
        Me.Label2.Text = "Productor"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(1029, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 18)
        Me.Label3.TabIndex = 226
        Me.Label3.Text = "Rut Fact :"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(343, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 227
        Me.Label12.Text = "N°Lab.Del"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(22, 37)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(64, 16)
        Me.Label73.TabIndex = 221
        Me.Label73.Text = "F. Desde "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(687, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 244
        Me.Label14.Text = "Factura"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(508, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 228
        Me.Label11.Text = "Al"
        '
        'btn_buscaProductor
        '
        Me.btn_buscaProductor.Image = CType(resources.GetObject("btn_buscaProductor.Image"), System.Drawing.Image)
        Me.btn_buscaProductor.Location = New System.Drawing.Point(288, 7)
        Me.btn_buscaProductor.Name = "btn_buscaProductor"
        Me.btn_buscaProductor.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaProductor.TabIndex = 245
        Me.btn_buscaProductor.UseVisualStyleBackColor = True
        '
        'btn_buscaFecha
        '
        Me.btn_buscaFecha.Image = CType(resources.GetObject("btn_buscaFecha.Image"), System.Drawing.Image)
        Me.btn_buscaFecha.Location = New System.Drawing.Point(213, 34)
        Me.btn_buscaFecha.Name = "btn_buscaFecha"
        Me.btn_buscaFecha.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaFecha.TabIndex = 246
        Me.btn_buscaFecha.UseVisualStyleBackColor = True
        '
        'COMTableAdapter
        '
        Me.COMTableAdapter.ClearBeforeFill = True
        '
        'ElGroupBox1
        '
        Me.ElGroupBox1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElGroupBox1.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.BackgroundStyle.SolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.BottomRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopLeft = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.BorderShape.TopRight = Klik.Windows.Forms.v1.Common.BorderShapes.Circle
        Me.ElGroupBox1.CaptionStyle.BorderStyle.SmoothingMode = Klik.Windows.Forms.v1.Common.SmoothingModes.AntiAlias
        Me.ElGroupBox1.CaptionStyle.FlashStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElGroupBox1.CaptionStyle.FlashStyle.SolidColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.ElGroupBox1.CaptionStyle.ForegroundImageStyle.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.CaptionStyle.TextStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.ElGroupBox1.CaptionStyle.TextStyle.Text = "Orden"
        Me.ElGroupBox1.CaptionStyle.TextStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ElGroupBox1.Controls.Add(Me.Label1)
        Me.ElGroupBox1.Controls.Add(Me.txt_EstadoFac)
        Me.ElGroupBox1.Controls.Add(Me.txOTSeleccionada)
        Me.ElGroupBox1.Location = New System.Drawing.Point(62, 6)
        Me.ElGroupBox1.Name = "ElGroupBox1"
        Me.ElGroupBox1.Office2007Scheme = Klik.Windows.Forms.v1.Common.Office2007Schemes.ClassicBlue
        Me.ElGroupBox1.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox1.Size = New System.Drawing.Size(175, 144)
        Me.ElGroupBox1.TabIndex = 61
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 260
        Me.Label1.Text = "Estado Factura"
        '
        'txt_EstadoFac
        '
        Me.txt_EstadoFac.Location = New System.Drawing.Point(40, 98)
        Me.txt_EstadoFac.Name = "txt_EstadoFac"
        Me.txt_EstadoFac.Size = New System.Drawing.Size(100, 20)
        Me.txt_EstadoFac.TabIndex = 258
        '
        'txOTSeleccionada
        '
        Me.txOTSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txOTSeleccionada.Location = New System.Drawing.Point(48, 49)
        Me.txOTSeleccionada.Name = "txOTSeleccionada"
        Me.txOTSeleccionada.Size = New System.Drawing.Size(78, 20)
        Me.txOTSeleccionada.TabIndex = 59
        Me.txOTSeleccionada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button6.Location = New System.Drawing.Point(510, 88)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(231, 63)
        Me.Button6.TabIndex = 60
        Me.Button6.Text = "Enviar Resultado"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'CmdOrdenTrabajo
        '
        Me.CmdOrdenTrabajo.BackColor = System.Drawing.Color.Transparent
        Me.CmdOrdenTrabajo.Image = CType(resources.GetObject("CmdOrdenTrabajo.Image"), System.Drawing.Image)
        Me.CmdOrdenTrabajo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdOrdenTrabajo.Location = New System.Drawing.Point(267, 19)
        Me.CmdOrdenTrabajo.Name = "CmdOrdenTrabajo"
        Me.CmdOrdenTrabajo.Size = New System.Drawing.Size(231, 63)
        Me.CmdOrdenTrabajo.TabIndex = 0
        Me.CmdOrdenTrabajo.Text = "Orden de Trabajo"
        Me.CmdOrdenTrabajo.UseVisualStyleBackColor = False
        '
        'CmdEliminarAnálisis
        '
        Me.CmdEliminarAnálisis.BackColor = System.Drawing.Color.Transparent
        Me.CmdEliminarAnálisis.Image = CType(resources.GetObject("CmdEliminarAnálisis.Image"), System.Drawing.Image)
        Me.CmdEliminarAnálisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdEliminarAnálisis.Location = New System.Drawing.Point(510, 19)
        Me.CmdEliminarAnálisis.Name = "CmdEliminarAnálisis"
        Me.CmdEliminarAnálisis.Size = New System.Drawing.Size(231, 63)
        Me.CmdEliminarAnálisis.TabIndex = 58
        Me.CmdEliminarAnálisis.Text = "Anular  Análisis"
        Me.CmdEliminarAnálisis.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(1029, 55)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 63)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'CmdAgregarAnalisis
        '
        Me.CmdAgregarAnalisis.BackColor = System.Drawing.Color.Transparent
        Me.CmdAgregarAnalisis.Image = CType(resources.GetObject("CmdAgregarAnalisis.Image"), System.Drawing.Image)
        Me.CmdAgregarAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAgregarAnalisis.Location = New System.Drawing.Point(267, 88)
        Me.CmdAgregarAnalisis.Name = "CmdAgregarAnalisis"
        Me.CmdAgregarAnalisis.Size = New System.Drawing.Size(231, 63)
        Me.CmdAgregarAnalisis.TabIndex = 57
        Me.CmdAgregarAnalisis.Text = "Agregar Análisis (genera nueva OT)"
        Me.CmdAgregarAnalisis.UseVisualStyleBackColor = False
        '
        'TxtBusLabDesde
        '
        Me.TxtBusLabDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabDesde.Location = New System.Drawing.Point(430, 64)
        Me.TxtBusLabDesde.Name = "TxtBusLabDesde"
        Me.TxtBusLabDesde.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabDesde.TabIndex = 200
        '
        'TxtBusLabHasta
        '
        Me.TxtBusLabHasta.AllowDrop = True
        Me.TxtBusLabHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabHasta.Location = New System.Drawing.Point(538, 64)
        Me.TxtBusLabHasta.Name = "TxtBusLabHasta"
        Me.TxtBusLabHasta.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabHasta.TabIndex = 201
        '
        'DtpFechaDesde
        '
        Me.DtpFechaDesde.CustomFormat = "dd-mm-yyyy"
        Me.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDesde.Location = New System.Drawing.Point(188, 35)
        Me.DtpFechaDesde.Name = "DtpFechaDesde"
        Me.DtpFechaDesde.Size = New System.Drawing.Size(20, 20)
        Me.DtpFechaDesde.TabIndex = 249
        '
        'btn_buscaNlab
        '
        Me.btn_buscaNlab.Image = CType(resources.GetObject("btn_buscaNlab.Image"), System.Drawing.Image)
        Me.btn_buscaNlab.Location = New System.Drawing.Point(608, 63)
        Me.btn_buscaNlab.Name = "btn_buscaNlab"
        Me.btn_buscaNlab.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaNlab.TabIndex = 250
        Me.btn_buscaNlab.UseVisualStyleBackColor = True
        '
        'btn_buscaTipoMuestra
        '
        Me.btn_buscaTipoMuestra.Image = CType(resources.GetObject("btn_buscaTipoMuestra.Image"), System.Drawing.Image)
        Me.btn_buscaTipoMuestra.Location = New System.Drawing.Point(290, 3)
        Me.btn_buscaTipoMuestra.Name = "btn_buscaTipoMuestra"
        Me.btn_buscaTipoMuestra.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaTipoMuestra.TabIndex = 251
        Me.btn_buscaTipoMuestra.UseVisualStyleBackColor = True
        '
        'btn_buscaEmpresa
        '
        Me.btn_buscaEmpresa.Image = CType(resources.GetObject("btn_buscaEmpresa.Image"), System.Drawing.Image)
        Me.btn_buscaEmpresa.Location = New System.Drawing.Point(644, 7)
        Me.btn_buscaEmpresa.Name = "btn_buscaEmpresa"
        Me.btn_buscaEmpresa.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaEmpresa.TabIndex = 252
        Me.btn_buscaEmpresa.UseVisualStyleBackColor = True
        '
        'btn_buscaRemite
        '
        Me.btn_buscaRemite.Image = CType(resources.GetObject("btn_buscaRemite.Image"), System.Drawing.Image)
        Me.btn_buscaRemite.Location = New System.Drawing.Point(963, 7)
        Me.btn_buscaRemite.Name = "btn_buscaRemite"
        Me.btn_buscaRemite.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaRemite.TabIndex = 253
        Me.btn_buscaRemite.UseVisualStyleBackColor = True
        '
        'btn_buscaFactura
        '
        Me.btn_buscaFactura.Image = CType(resources.GetObject("btn_buscaFactura.Image"), System.Drawing.Image)
        Me.btn_buscaFactura.Location = New System.Drawing.Point(846, 34)
        Me.btn_buscaFactura.Name = "btn_buscaFactura"
        Me.btn_buscaFactura.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaFactura.TabIndex = 254
        Me.btn_buscaFactura.UseVisualStyleBackColor = True
        '
        'btn_buscaRutPro
        '
        Me.btn_buscaRutPro.Image = CType(resources.GetObject("btn_buscaRutPro.Image"), System.Drawing.Image)
        Me.btn_buscaRutPro.Location = New System.Drawing.Point(1218, 6)
        Me.btn_buscaRutPro.Name = "btn_buscaRutPro"
        Me.btn_buscaRutPro.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaRutPro.TabIndex = 255
        Me.btn_buscaRutPro.UseVisualStyleBackColor = True
        '
        'btn_buscaRutFac
        '
        Me.btn_buscaRutFac.Image = CType(resources.GetObject("btn_buscaRutFac.Image"), System.Drawing.Image)
        Me.btn_buscaRutFac.Location = New System.Drawing.Point(1218, 32)
        Me.btn_buscaRutFac.Name = "btn_buscaRutFac"
        Me.btn_buscaRutFac.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaRutFac.TabIndex = 256
        Me.btn_buscaRutFac.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1175, 68)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 56)
        Me.Button1.TabIndex = 257
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(430, 41)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 258
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'PanelTipo
        '
        Me.PanelTipo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelTipo.Controls.Add(Me.Label5)
        Me.PanelTipo.Controls.Add(Me.Label4)
        Me.PanelTipo.Controls.Add(Me.dt_Tipo)
        Me.PanelTipo.Controls.Add(Me.CBBusMuestra)
        Me.PanelTipo.Controls.Add(Me.btn_buscaTipoMuestra)
        Me.PanelTipo.Location = New System.Drawing.Point(690, 63)
        Me.PanelTipo.Name = "PanelTipo"
        Me.PanelTipo.Size = New System.Drawing.Size(332, 61)
        Me.PanelTipo.TabIndex = 259
        Me.PanelTipo.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(11, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 16)
        Me.Label5.TabIndex = 261
        Me.Label5.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(11, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 260
        Me.Label4.Text = "Tipo muestra"
        '
        'dt_Tipo
        '
        Me.dt_Tipo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_Tipo.Location = New System.Drawing.Point(103, 31)
        Me.dt_Tipo.Name = "dt_Tipo"
        Me.dt_Tipo.Size = New System.Drawing.Size(181, 20)
        Me.dt_Tipo.TabIndex = 252
        '
        'btn_buscaNlabY
        '
        Me.btn_buscaNlabY.Image = CType(resources.GetObject("btn_buscaNlabY.Image"), System.Drawing.Image)
        Me.btn_buscaNlabY.Location = New System.Drawing.Point(608, 93)
        Me.btn_buscaNlabY.Name = "btn_buscaNlabY"
        Me.btn_buscaNlabY.Size = New System.Drawing.Size(31, 23)
        Me.btn_buscaNlabY.TabIndex = 264
        Me.btn_buscaNlabY.UseVisualStyleBackColor = True
        '
        'TxtBusLabDesdeY
        '
        Me.TxtBusLabDesdeY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabDesdeY.Location = New System.Drawing.Point(430, 94)
        Me.TxtBusLabDesdeY.Name = "TxtBusLabDesdeY"
        Me.TxtBusLabDesdeY.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabDesdeY.TabIndex = 260
        '
        'TxtBusLabHastaY
        '
        Me.TxtBusLabHastaY.AllowDrop = True
        Me.TxtBusLabHastaY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabHastaY.Location = New System.Drawing.Point(538, 94)
        Me.TxtBusLabHastaY.Name = "TxtBusLabHastaY"
        Me.TxtBusLabHastaY.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabHastaY.TabIndex = 261
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(294, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 16)
        Me.Label6.TabIndex = 262
        Me.Label6.Text = "(Yemas) N°Lab.Del"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(508, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 263
        Me.Label7.Text = "Al"
        '
        'pnl_resultados
        '
        Me.pnl_resultados.Controls.Add(Me.Button8)
        Me.pnl_resultados.Controls.Add(Me.Label15)
        Me.pnl_resultados.Controls.Add(Me.Button7)
        Me.pnl_resultados.Controls.Add(Me.lbx_lista)
        Me.pnl_resultados.Location = New System.Drawing.Point(232, 623)
        Me.pnl_resultados.Name = "pnl_resultados"
        Me.pnl_resultados.Size = New System.Drawing.Size(752, 116)
        Me.pnl_resultados.TabIndex = 265
        Me.pnl_resultados.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(667, 63)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Resultados Encontrados:"
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(667, 34)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "Adjuntar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'lbx_lista
        '
        Me.lbx_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_lista.FormattingEnabled = True
        Me.lbx_lista.Location = New System.Drawing.Point(19, 27)
        Me.lbx_lista.Name = "lbx_lista"
        Me.lbx_lista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbx_lista.Size = New System.Drawing.Size(642, 69)
        Me.lbx_lista.TabIndex = 63
        '
        'GrbModificacion
        '
        Me.GrbModificacion.Controls.Add(Me.ElGroupBox1)
        Me.GrbModificacion.Controls.Add(Me.Button6)
        Me.GrbModificacion.Controls.Add(Me.CmdAgregarAnalisis)
        Me.GrbModificacion.Controls.Add(Me.CmdOrdenTrabajo)
        Me.GrbModificacion.Controls.Add(Me.Button3)
        Me.GrbModificacion.Controls.Add(Me.CmdEliminarAnálisis)
        Me.GrbModificacion.Location = New System.Drawing.Point(-2, 126)
        Me.GrbModificacion.Name = "GrbModificacion"
        Me.GrbModificacion.Size = New System.Drawing.Size(1276, 193)
        Me.GrbModificacion.TabIndex = 266
        Me.GrbModificacion.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.DtpFechaDesde)
        Me.Panel1.Controls.Add(Me.btn_Aceptar)
        Me.Panel1.Controls.Add(Me.btn_buscaNlabY)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtBusLabDesdeY)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtBusLabHastaY)
        Me.Panel1.Controls.Add(Me.Label73)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PanelTipo)
        Me.Panel1.Controls.Add(Me.Label90)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label81)
        Me.Panel1.Controls.Add(Me.btn_buscaRutFac)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btn_buscaRutPro)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.btn_buscaFactura)
        Me.Panel1.Controls.Add(Me.TxtBusRemite)
        Me.Panel1.Controls.Add(Me.btn_buscaRemite)
        Me.Panel1.Controls.Add(Me.TxtBusRut)
        Me.Panel1.Controls.Add(Me.btn_buscaEmpresa)
        Me.Panel1.Controls.Add(Me.TxtBusRutFact)
        Me.Panel1.Controls.Add(Me.btn_buscaNlab)
        Me.Panel1.Controls.Add(Me.TxtBusProductor)
        Me.Panel1.Controls.Add(Me.TxtBusLabDesde)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtBusLabHasta)
        Me.Panel1.Controls.Add(Me.TxtBusOtDesde)
        Me.Panel1.Controls.Add(Me.btn_buscaFecha)
        Me.Panel1.Controls.Add(Me.TxtBusEmpresa)
        Me.Panel1.Controls.Add(Me.btn_buscaProductor)
        Me.Panel1.Controls.Add(Me.TxtBusFechaDesde)
        Me.Panel1.Controls.Add(Me.TxtBusOtHasta)
        Me.Panel1.Controls.Add(Me.TxtBusFactura)
        Me.Panel1.Location = New System.Drawing.Point(-2, 745)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1274, 130)
        Me.Panel1.TabIndex = 267
        '
        'FRM_COM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1284, 985)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrbModificacion)
        Me.Controls.Add(Me.pnl_resultados)
        Me.Controls.Add(Me.grilla_COM)
        Me.KeyPreview = True
        Me.Name = "FRM_COM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_COM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grilla_COM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGROLAB_PRUEBADataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox1.ResumeLayout(False)
        Me.ElGroupBox1.PerformLayout()
        Me.PanelTipo.ResumeLayout(False)
        Me.pnl_resultados.ResumeLayout(False)
        Me.pnl_resultados.PerformLayout()
        Me.GrbModificacion.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grilla_COM As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents TxtBusOtHasta As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusFactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusOtDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBBusMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusProductor As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusRutFact As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusRut As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusRemite As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_buscaProductor As System.Windows.Forms.Button
    Friend WithEvents btn_buscaFecha As System.Windows.Forms.Button
    Friend WithEvents AGROLAB_PRUEBADataSet2 As LabSys.AGROLAB_PRUEBADataSet2
    Friend WithEvents COMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents COMTableAdapter As LabSys.AGROLAB_PRUEBADataSet2TableAdapters.COMTableAdapter
    Friend WithEvents FIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ElGroupBox1 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txOTSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CmdOrdenTrabajo As System.Windows.Forms.Button
    Friend WithEvents CmdEliminarAnálisis As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents CmdAgregarAnalisis As System.Windows.Forms.Button
    Friend WithEvents TxtBusLabDesde As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusLabHasta As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_buscaNlab As System.Windows.Forms.Button
    Friend WithEvents btn_buscaTipoMuestra As System.Windows.Forms.Button
    Friend WithEvents btn_buscaEmpresa As System.Windows.Forms.Button
    Friend WithEvents btn_buscaRemite As System.Windows.Forms.Button
    Friend WithEvents btn_buscaFactura As System.Windows.Forms.Button
    Friend WithEvents btn_buscaRutPro As System.Windows.Forms.Button
    Friend WithEvents btn_buscaRutFac As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_EstadoFac As System.Windows.Forms.TextBox
    Friend WithEvents NOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIngreso As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutProductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutFacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemiteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TipoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumeroDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents PanelTipo As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dt_Tipo As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_buscaNlabY As System.Windows.Forms.Button
    Friend WithEvents TxtBusLabDesdeY As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusLabHastaY As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnl_resultados As System.Windows.Forms.Panel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents lbx_lista As System.Windows.Forms.ListBox
    Friend WithEvents GrbModificacion As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
