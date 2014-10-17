<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_GeneradorXml
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txRutEmpresa = New System.Windows.Forms.TextBox
        Me.cbEmpresa = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txRutProductor = New System.Windows.Forms.TextBox
        Me.txNlabHasta = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txNFolio = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txNOT = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cbProductor = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txNLabDesde = New System.Windows.Forms.TextBox
        Me.dgBusquedaXML = New System.Windows.Forms.DataGridView
        Me.OrdenTrabajoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RutProductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProductorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.RutEmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmpresaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NlabHastaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FolioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NlabDesdeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnálisisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NLabDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AnaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CuartelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LsobtieneBusquedaXMLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AGROLAB_PRUEBADataSet = New LabSys.AGROLAB_PRUEBADataSet
        Me.Ls_obtieneBusquedaXMLTableAdapter = New LabSys.AGROLAB_PRUEBADataSetTableAdapters.ls_obtieneBusquedaXMLTableAdapter
        Me.dgAsignado = New System.Windows.Forms.DataGridView
        Me.txOT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txProductorSel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txEmpresaSel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txNlabDesdeSel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txNlabHastaSel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txFolioSel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txAnalisis = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txCantidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnGeneraXML = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnBuscarXML = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        CType(Me.dgBusquedaXML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LsobtieneBusquedaXMLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AGROLAB_PRUEBADataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgAsignado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnBuscarXML)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txRutEmpresa)
        Me.Panel1.Controls.Add(Me.cbEmpresa)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txRutProductor)
        Me.Panel1.Controls.Add(Me.txNlabHasta)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txNFolio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txNOT)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cbProductor)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txNLabDesde)
        Me.Panel1.Location = New System.Drawing.Point(2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1270, 148)
        Me.Panel1.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(289, 105)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Ej: F/00000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Rut Empresa"
        '
        'txRutEmpresa
        '
        Me.txRutEmpresa.Location = New System.Drawing.Point(167, 48)
        Me.txRutEmpresa.Name = "txRutEmpresa"
        Me.txRutEmpresa.Size = New System.Drawing.Size(116, 21)
        Me.txRutEmpresa.TabIndex = 14
        '
        'cbEmpresa
        '
        Me.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(464, 48)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(224, 23)
        Me.cbEmpresa.TabIndex = 13
        Me.cbEmpresa.Text = "Seleccione"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(328, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Empresa:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Rut Productor:"
        '
        'txRutProductor
        '
        Me.txRutProductor.Location = New System.Drawing.Point(167, 21)
        Me.txRutProductor.Name = "txRutProductor"
        Me.txRutProductor.Size = New System.Drawing.Size(116, 21)
        Me.txRutProductor.TabIndex = 10
        '
        'txNlabHasta
        '
        Me.txNlabHasta.Location = New System.Drawing.Point(633, 77)
        Me.txNlabHasta.Name = "txNlabHasta"
        Me.txNlabHasta.Size = New System.Drawing.Size(116, 21)
        Me.txNlabHasta.TabIndex = 9
        Me.txNlabHasta.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(587, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "hasta"
        Me.Label5.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "N° Folio (MYV):"
        '
        'txNFolio
        '
        Me.txNFolio.Location = New System.Drawing.Point(167, 102)
        Me.txNFolio.Name = "txNFolio"
        Me.txNFolio.Size = New System.Drawing.Size(116, 21)
        Me.txNFolio.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "N° Orden de Trabajo:"
        '
        'txNOT
        '
        Me.txNOT.Location = New System.Drawing.Point(167, 75)
        Me.txNOT.Name = "txNOT"
        Me.txNOT.Size = New System.Drawing.Size(116, 21)
        Me.txNOT.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "N° Laboratorio: "
        '
        'cbProductor
        '
        Me.cbProductor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbProductor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProductor.FormattingEnabled = True
        Me.cbProductor.Location = New System.Drawing.Point(464, 21)
        Me.cbProductor.Name = "cbProductor"
        Me.cbProductor.Size = New System.Drawing.Size(224, 23)
        Me.cbProductor.TabIndex = 2
        Me.cbProductor.Text = "Seleccione"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(328, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Productor:"
        '
        'txNLabDesde
        '
        Me.txNLabDesde.Location = New System.Drawing.Point(464, 77)
        Me.txNLabDesde.Name = "txNLabDesde"
        Me.txNLabDesde.Size = New System.Drawing.Size(116, 21)
        Me.txNLabDesde.TabIndex = 0
        '
        'dgBusquedaXML
        '
        Me.dgBusquedaXML.AllowUserToAddRows = False
        Me.dgBusquedaXML.AllowUserToDeleteRows = False
        Me.dgBusquedaXML.AutoGenerateColumns = False
        Me.dgBusquedaXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBusquedaXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OrdenTrabajoDataGridViewTextBoxColumn, Me.RutProductorDataGridViewTextBoxColumn, Me.ProductorDataGridViewTextBoxColumn, Me.RutEmpresaDataGridViewTextBoxColumn, Me.EmpresaDataGridViewTextBoxColumn, Me.NlabHastaDataGridViewTextBoxColumn, Me.FolioDataGridViewTextBoxColumn, Me.NlabDesdeDataGridViewTextBoxColumn, Me.CódigoDataGridViewTextBoxColumn, Me.AnálisisDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.NLabDataGridViewTextBoxColumn, Me.AnaDataGridViewTextBoxColumn, Me.PagDataGridViewTextBoxColumn, Me.FacDataGridViewTextBoxColumn, Me.TMUDataGridViewTextBoxColumn, Me.CuartelDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.dgBusquedaXML.DataSource = Me.LsobtieneBusquedaXMLBindingSource
        Me.dgBusquedaXML.Location = New System.Drawing.Point(2, 150)
        Me.dgBusquedaXML.Name = "dgBusquedaXML"
        Me.dgBusquedaXML.ReadOnly = True
        Me.dgBusquedaXML.Size = New System.Drawing.Size(1270, 413)
        Me.dgBusquedaXML.TabIndex = 1
        '
        'OrdenTrabajoDataGridViewTextBoxColumn
        '
        Me.OrdenTrabajoDataGridViewTextBoxColumn.DataPropertyName = "Orden Trabajo"
        Me.OrdenTrabajoDataGridViewTextBoxColumn.HeaderText = "Orden Trabajo"
        Me.OrdenTrabajoDataGridViewTextBoxColumn.Name = "OrdenTrabajoDataGridViewTextBoxColumn"
        Me.OrdenTrabajoDataGridViewTextBoxColumn.ReadOnly = True
        Me.OrdenTrabajoDataGridViewTextBoxColumn.Width = 115
        '
        'RutProductorDataGridViewTextBoxColumn
        '
        Me.RutProductorDataGridViewTextBoxColumn.DataPropertyName = "Rut Productor"
        Me.RutProductorDataGridViewTextBoxColumn.HeaderText = "Rut Productor"
        Me.RutProductorDataGridViewTextBoxColumn.Name = "RutProductorDataGridViewTextBoxColumn"
        Me.RutProductorDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutProductorDataGridViewTextBoxColumn.Width = 115
        '
        'ProductorDataGridViewTextBoxColumn
        '
        Me.ProductorDataGridViewTextBoxColumn.DataPropertyName = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.HeaderText = "Productor"
        Me.ProductorDataGridViewTextBoxColumn.Name = "ProductorDataGridViewTextBoxColumn"
        Me.ProductorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RutEmpresaDataGridViewTextBoxColumn
        '
        Me.RutEmpresaDataGridViewTextBoxColumn.DataPropertyName = "Rut Empresa"
        Me.RutEmpresaDataGridViewTextBoxColumn.HeaderText = "Rut Empresa"
        Me.RutEmpresaDataGridViewTextBoxColumn.Name = "RutEmpresaDataGridViewTextBoxColumn"
        Me.RutEmpresaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RutEmpresaDataGridViewTextBoxColumn.Width = 115
        '
        'EmpresaDataGridViewTextBoxColumn
        '
        Me.EmpresaDataGridViewTextBoxColumn.DataPropertyName = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.HeaderText = "Empresa"
        Me.EmpresaDataGridViewTextBoxColumn.Name = "EmpresaDataGridViewTextBoxColumn"
        Me.EmpresaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NlabHastaDataGridViewTextBoxColumn
        '
        Me.NlabHastaDataGridViewTextBoxColumn.DataPropertyName = "Nlab Hasta"
        Me.NlabHastaDataGridViewTextBoxColumn.HeaderText = "Nlab Hasta"
        Me.NlabHastaDataGridViewTextBoxColumn.Name = "NlabHastaDataGridViewTextBoxColumn"
        Me.NlabHastaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FolioDataGridViewTextBoxColumn
        '
        Me.FolioDataGridViewTextBoxColumn.DataPropertyName = "Folio"
        Me.FolioDataGridViewTextBoxColumn.HeaderText = "Folio"
        Me.FolioDataGridViewTextBoxColumn.Name = "FolioDataGridViewTextBoxColumn"
        Me.FolioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NlabDesdeDataGridViewTextBoxColumn
        '
        Me.NlabDesdeDataGridViewTextBoxColumn.DataPropertyName = "Nlab Desde"
        Me.NlabDesdeDataGridViewTextBoxColumn.HeaderText = "Nlab Desde"
        Me.NlabDesdeDataGridViewTextBoxColumn.Name = "NlabDesdeDataGridViewTextBoxColumn"
        Me.NlabDesdeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        Me.CódigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnálisisDataGridViewTextBoxColumn
        '
        Me.AnálisisDataGridViewTextBoxColumn.DataPropertyName = "Análisis"
        Me.AnálisisDataGridViewTextBoxColumn.HeaderText = "Análisis"
        Me.AnálisisDataGridViewTextBoxColumn.Name = "AnálisisDataGridViewTextBoxColumn"
        Me.AnálisisDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NLabDataGridViewTextBoxColumn
        '
        Me.NLabDataGridViewTextBoxColumn.DataPropertyName = "N Lab"
        Me.NLabDataGridViewTextBoxColumn.HeaderText = "N Lab"
        Me.NLabDataGridViewTextBoxColumn.Name = "NLabDataGridViewTextBoxColumn"
        Me.NLabDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnaDataGridViewTextBoxColumn
        '
        Me.AnaDataGridViewTextBoxColumn.DataPropertyName = "Ana"
        Me.AnaDataGridViewTextBoxColumn.HeaderText = "Ana"
        Me.AnaDataGridViewTextBoxColumn.Name = "AnaDataGridViewTextBoxColumn"
        Me.AnaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PagDataGridViewTextBoxColumn
        '
        Me.PagDataGridViewTextBoxColumn.DataPropertyName = "Pag"
        Me.PagDataGridViewTextBoxColumn.HeaderText = "Pag"
        Me.PagDataGridViewTextBoxColumn.Name = "PagDataGridViewTextBoxColumn"
        Me.PagDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FacDataGridViewTextBoxColumn
        '
        Me.FacDataGridViewTextBoxColumn.DataPropertyName = "Fac"
        Me.FacDataGridViewTextBoxColumn.HeaderText = "Fac"
        Me.FacDataGridViewTextBoxColumn.Name = "FacDataGridViewTextBoxColumn"
        Me.FacDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TMUDataGridViewTextBoxColumn
        '
        Me.TMUDataGridViewTextBoxColumn.DataPropertyName = "TMU"
        Me.TMUDataGridViewTextBoxColumn.HeaderText = "TMU"
        Me.TMUDataGridViewTextBoxColumn.Name = "TMUDataGridViewTextBoxColumn"
        Me.TMUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CuartelDataGridViewTextBoxColumn
        '
        Me.CuartelDataGridViewTextBoxColumn.DataPropertyName = "Cuartel"
        Me.CuartelDataGridViewTextBoxColumn.HeaderText = "Cuartel"
        Me.CuartelDataGridViewTextBoxColumn.Name = "CuartelDataGridViewTextBoxColumn"
        Me.CuartelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        Me.EstadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LsobtieneBusquedaXMLBindingSource
        '
        Me.LsobtieneBusquedaXMLBindingSource.DataMember = "ls_obtieneBusquedaXML"
        Me.LsobtieneBusquedaXMLBindingSource.DataSource = Me.AGROLAB_PRUEBADataSet
        '
        'AGROLAB_PRUEBADataSet
        '
        Me.AGROLAB_PRUEBADataSet.DataSetName = "AGROLAB_PRUEBADataSet"
        Me.AGROLAB_PRUEBADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Ls_obtieneBusquedaXMLTableAdapter
        '
        Me.Ls_obtieneBusquedaXMLTableAdapter.ClearBeforeFill = True
        '
        'dgAsignado
        '
        Me.dgAsignado.AllowUserToAddRows = False
        Me.dgAsignado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAsignado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txOT, Me.txProductorSel, Me.txEmpresaSel, Me.txNlabDesdeSel, Me.txNlabHastaSel, Me.txFolioSel, Me.txCodigo, Me.txAnalisis, Me.txCantidad, Me.txEstado})
        Me.dgAsignado.Location = New System.Drawing.Point(2, 604)
        Me.dgAsignado.Name = "dgAsignado"
        Me.dgAsignado.ReadOnly = True
        Me.dgAsignado.Size = New System.Drawing.Size(1113, 350)
        Me.dgAsignado.TabIndex = 2
        '
        'txOT
        '
        Me.txOT.HeaderText = "Orden Trabajo"
        Me.txOT.Name = "txOT"
        Me.txOT.ReadOnly = True
        Me.txOT.Width = 120
        '
        'txProductorSel
        '
        Me.txProductorSel.HeaderText = "Productor"
        Me.txProductorSel.Name = "txProductorSel"
        Me.txProductorSel.ReadOnly = True
        Me.txProductorSel.Width = 120
        '
        'txEmpresaSel
        '
        Me.txEmpresaSel.HeaderText = "Empresa"
        Me.txEmpresaSel.Name = "txEmpresaSel"
        Me.txEmpresaSel.ReadOnly = True
        '
        'txNlabDesdeSel
        '
        Me.txNlabDesdeSel.HeaderText = "N Lab Desde"
        Me.txNlabDesdeSel.Name = "txNlabDesdeSel"
        Me.txNlabDesdeSel.ReadOnly = True
        Me.txNlabDesdeSel.Width = 105
        '
        'txNlabHastaSel
        '
        Me.txNlabHastaSel.HeaderText = "N Lab Hasta"
        Me.txNlabHastaSel.Name = "txNlabHastaSel"
        Me.txNlabHastaSel.ReadOnly = True
        '
        'txFolioSel
        '
        Me.txFolioSel.HeaderText = "Folio"
        Me.txFolioSel.Name = "txFolioSel"
        Me.txFolioSel.ReadOnly = True
        '
        'txCodigo
        '
        Me.txCodigo.HeaderText = "Código"
        Me.txCodigo.Name = "txCodigo"
        Me.txCodigo.ReadOnly = True
        '
        'txAnalisis
        '
        Me.txAnalisis.HeaderText = "Análisis"
        Me.txAnalisis.Name = "txAnalisis"
        Me.txAnalisis.ReadOnly = True
        '
        'txCantidad
        '
        Me.txCantidad.HeaderText = "Cantidad"
        Me.txCantidad.Name = "txCantidad"
        Me.txCantidad.ReadOnly = True
        '
        'txEstado
        '
        Me.txEstado.HeaderText = "Estado"
        Me.txEstado.Name = "txEstado"
        Me.txEstado.ReadOnly = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Location = New System.Drawing.Point(2, 565)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1270, 38)
        Me.Panel2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 11)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Ordenes Seleccionadas Para Generar XML"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.btnGeneraXML)
        Me.Panel3.Location = New System.Drawing.Point(1116, 605)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(156, 349)
        Me.Panel3.TabIndex = 4
        '
        'btnGeneraXML
        '
        Me.btnGeneraXML.Image = Global.LabSys.My.Resources.Resources.accept
        Me.btnGeneraXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneraXML.Location = New System.Drawing.Point(31, 33)
        Me.btnGeneraXML.Name = "btnGeneraXML"
        Me.btnGeneraXML.Size = New System.Drawing.Size(103, 23)
        Me.btnGeneraXML.TabIndex = 0
        Me.btnGeneraXML.Text = "Generar XML"
        Me.btnGeneraXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneraXML.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.LabSys.My.Resources.Resources.xml
        Me.PictureBox1.Location = New System.Drawing.Point(1133, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(130, 124)
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'btnBuscarXML
        '
        Me.btnBuscarXML.Image = Global.LabSys.My.Resources.Resources.magnifier
        Me.btnBuscarXML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscarXML.Location = New System.Drawing.Point(464, 108)
        Me.btnBuscarXML.Name = "btnBuscarXML"
        Me.btnBuscarXML.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarXML.TabIndex = 16
        Me.btnBuscarXML.Text = "Buscar"
        Me.btnBuscarXML.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBuscarXML.UseVisualStyleBackColor = True
        '
        'F_GeneradorXml
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1284, 1006)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgAsignado)
        Me.Controls.Add(Me.dgBusquedaXML)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "F_GeneradorXml"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador XML 2.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgBusquedaXML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LsobtieneBusquedaXMLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AGROLAB_PRUEBADataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgAsignado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txNLabDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txNFolio As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txNOT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbProductor As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txRutProductor As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarXML As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txRutEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents cbEmpresa As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dgBusquedaXML As System.Windows.Forms.DataGridView
    Friend WithEvents LsobtieneBusquedaXMLBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AGROLAB_PRUEBADataSet As AGROLAB_PRUEBADataSet
    Friend WithEvents Ls_obtieneBusquedaXMLTableAdapter As AGROLAB_PRUEBADataSetTableAdapters.ls_obtieneBusquedaXMLTableAdapter
    Friend WithEvents dgAsignado As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnGeneraXML As System.Windows.Forms.Button
    Friend WithEvents OrdenTrabajoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutProductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RutEmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpresaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NlabHastaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FolioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NlabDesdeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CódigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnálisisDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NLabDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PagDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CuartelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txOT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txProductorSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txEmpresaSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txNlabDesdeSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txNlabHastaSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txFolioSel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txAnalisis As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txCantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txNlabHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
