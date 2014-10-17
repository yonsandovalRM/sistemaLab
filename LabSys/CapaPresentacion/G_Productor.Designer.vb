<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class G_Productor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(G_Productor))
        Me.CIUDADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet4 = New LabSys.LabsysDataSet4
        Me.CIUDADTableAdapter = New LabSys.LabsysDataSet4TableAdapters.CIUDADTableAdapter
        Me.gbPoductor = New System.Windows.Forms.GroupBox
        Me.cbCiudad = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txDireccion = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txNombre = New System.Windows.Forms.TextBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txRut = New System.Windows.Forms.TextBox
        Me.dgProductor = New System.Windows.Forms.DataGridView
        Me.txUltimaOt = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txNombreProductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txEmpresa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txPredio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txRemite = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txLocalidad = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txComuna = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txRutProductor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txRutFacturacion = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LsDatosProductorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabsysDataSet2 = New LabSys.LabsysDataSet2
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Ls_DatosProductorTableAdapter = New LabSys.LabsysDataSet2TableAdapters.ls_DatosProductorTableAdapter
        CType(Me.CIUDADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbPoductor.SuspendLayout()
        CType(Me.dgProductor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LsDatosProductorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabsysDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CIUDADBindingSource
        '
        Me.CIUDADBindingSource.DataMember = "CIUDAD"
        Me.CIUDADBindingSource.DataSource = Me.LabsysDataSet4
        '
        'LabsysDataSet4
        '
        Me.LabsysDataSet4.DataSetName = "LabsysDataSet4"
        Me.LabsysDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CIUDADTableAdapter
        '
        Me.CIUDADTableAdapter.ClearBeforeFill = True
        '
        'gbPoductor
        '
        Me.gbPoductor.Controls.Add(Me.cbCiudad)
        Me.gbPoductor.Controls.Add(Me.Label5)
        Me.gbPoductor.Controls.Add(Me.Label6)
        Me.gbPoductor.Controls.Add(Me.txDireccion)
        Me.gbPoductor.Controls.Add(Me.Label4)
        Me.gbPoductor.Controls.Add(Me.txNombre)
        Me.gbPoductor.Controls.Add(Me.btnBuscar)
        Me.gbPoductor.Controls.Add(Me.Label1)
        Me.gbPoductor.Controls.Add(Me.txRut)
        Me.gbPoductor.Location = New System.Drawing.Point(12, 12)
        Me.gbPoductor.Name = "gbPoductor"
        Me.gbPoductor.Size = New System.Drawing.Size(1006, 84)
        Me.gbPoductor.TabIndex = 1
        Me.gbPoductor.TabStop = False
        Me.gbPoductor.Text = "Buscar Por:"
        '
        'cbCiudad
        '
        Me.cbCiudad.DataSource = Me.CIUDADBindingSource
        Me.cbCiudad.DisplayMember = "COD_CIUDAD"
        Me.cbCiudad.FormattingEnabled = True
        Me.cbCiudad.Location = New System.Drawing.Point(645, 19)
        Me.cbCiudad.Name = "cbCiudad"
        Me.cbCiudad.Size = New System.Drawing.Size(211, 21)
        Me.cbCiudad.TabIndex = 12
        Me.cbCiudad.ValueMember = "COD_CIUDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(600, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Ciudad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dirección"
        '
        'txDireccion
        '
        Me.txDireccion.Location = New System.Drawing.Point(77, 52)
        Me.txDireccion.Name = "txDireccion"
        Me.txDireccion.Size = New System.Drawing.Size(340, 20)
        Me.txDireccion.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(218, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre"
        '
        'txNombre
        '
        Me.txNombre.Location = New System.Drawing.Point(268, 19)
        Me.txNombre.Name = "txNombre"
        Me.txNombre.Size = New System.Drawing.Size(283, 20)
        Me.txNombre.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Image = Global.LabSys.My.Resources.Resources.magnifier
        Me.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBuscar.Location = New System.Drawing.Point(547, 50)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(93, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Rut"
        '
        'txRut
        '
        Me.txRut.Location = New System.Drawing.Point(77, 19)
        Me.txRut.Name = "txRut"
        Me.txRut.Size = New System.Drawing.Size(100, 20)
        Me.txRut.TabIndex = 0
        '
        'dgProductor
        '
        Me.dgProductor.AllowUserToAddRows = False
        Me.dgProductor.AllowUserToDeleteRows = False
        Me.dgProductor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProductor.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.txUltimaOt, Me.txNombreProductor, Me.txEmpresa, Me.txPredio, Me.txRemite, Me.txLocalidad, Me.txComuna, Me.txRutProductor, Me.txRutFacturacion})
        Me.dgProductor.Location = New System.Drawing.Point(3, 102)
        Me.dgProductor.Name = "dgProductor"
        Me.dgProductor.ReadOnly = True
        Me.dgProductor.Size = New System.Drawing.Size(1023, 356)
        Me.dgProductor.TabIndex = 2
        '
        'txUltimaOt
        '
        Me.txUltimaOt.HeaderText = "Ultima OT"
        Me.txUltimaOt.Name = "txUltimaOt"
        Me.txUltimaOt.ReadOnly = True
        Me.txUltimaOt.Width = 80
        '
        'txNombreProductor
        '
        Me.txNombreProductor.HeaderText = "Nombre Produtor"
        Me.txNombreProductor.Name = "txNombreProductor"
        Me.txNombreProductor.ReadOnly = True
        Me.txNombreProductor.Width = 200
        '
        'txEmpresa
        '
        Me.txEmpresa.HeaderText = "Empresa"
        Me.txEmpresa.Name = "txEmpresa"
        Me.txEmpresa.ReadOnly = True
        '
        'txPredio
        '
        Me.txPredio.HeaderText = "Predio"
        Me.txPredio.Name = "txPredio"
        Me.txPredio.ReadOnly = True
        Me.txPredio.Width = 90
        '
        'txRemite
        '
        Me.txRemite.HeaderText = "Remite"
        Me.txRemite.Name = "txRemite"
        Me.txRemite.ReadOnly = True
        Me.txRemite.Width = 90
        '
        'txLocalidad
        '
        Me.txLocalidad.HeaderText = "Localidad"
        Me.txLocalidad.Name = "txLocalidad"
        Me.txLocalidad.ReadOnly = True
        Me.txLocalidad.Width = 90
        '
        'txComuna
        '
        Me.txComuna.HeaderText = "Comuna"
        Me.txComuna.Name = "txComuna"
        Me.txComuna.ReadOnly = True
        '
        'txRutProductor
        '
        Me.txRutProductor.HeaderText = "Rut Productor"
        Me.txRutProductor.Name = "txRutProductor"
        Me.txRutProductor.ReadOnly = True
        Me.txRutProductor.Width = 120
        '
        'txRutFacturacion
        '
        Me.txRutFacturacion.HeaderText = "Rut Facturación"
        Me.txRutFacturacion.Name = "txRutFacturacion"
        Me.txRutFacturacion.ReadOnly = True
        Me.txRutFacturacion.Width = 130
        '
        'LsDatosProductorBindingSource
        '
        Me.LsDatosProductorBindingSource.DataMember = "ls_DatosProductor"
        Me.LsDatosProductorBindingSource.DataSource = Me.LabsysDataSet2
        '
        'LabsysDataSet2
        '
        Me.LabsysDataSet2.DataSetName = "LabsysDataSet2"
        Me.LabsysDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.dgProductor)
        Me.Panel1.Controls.Add(Me.gbPoductor)
        Me.Panel1.Location = New System.Drawing.Point(0, -8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1080, 468)
        Me.Panel1.TabIndex = 0
        '
        'Ls_DatosProductorTableAdapter
        '
        Me.Ls_DatosProductorTableAdapter.ClearBeforeFill = True
        '
        'G_Productor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(1030, 462)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "G_Productor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.CIUDADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbPoductor.ResumeLayout(False)
        Me.gbPoductor.PerformLayout()
        CType(Me.dgProductor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LsDatosProductorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabsysDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents ProrutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PronombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProdireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcelularDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProfaxDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Proemail1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LabsysDataSet4 As LabSys.LabsysDataSet4
    Friend WithEvents CIUDADBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CIUDADTableAdapter As LabSys.LabsysDataSet4TableAdapters.CIUDADTableAdapter
    ' Friend WithEvents LabsysProductor As LabSys.LabsysProductor
    ' Friend WithEvents Ls_DatosProductorTableAdapter As LabSys.LabsysProductorTableAdapters.ls_DatosProductorTableAdapter
    Friend WithEvents gbPoductor As System.Windows.Forms.GroupBox
    Friend WithEvents cbCiudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txRut As System.Windows.Forms.TextBox
    Friend WithEvents dgProductor As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPRODUCTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROEMPRESADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPREDIODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROLOCALIDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROCOMUNADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROCIUDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPROVINCIADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREGIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFONO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFONO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROCELULAR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROCELULAR2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFAX1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFAX2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROEMAIL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMITEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMFONO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMFONO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMCELULAR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMCELULAR2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMFAX1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMFAX2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMEMAIL1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROREMEMAIL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLNOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLFONO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLFONO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLCELULAR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLCELULAR2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLFAX1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLFAX2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLEMAIL1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROSOLEMAIL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACRUTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACRSOCIALDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACFONO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACFONO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACGIRODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACDIRECCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACCOMUNADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACCIUDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACENCPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACF1PAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACF2PAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACOBSPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACEMAIL1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACEMAIL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROFACCONDICIONPAGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPORRETIRALABDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPORFONODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPORFAXDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPOREMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPORCORREODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPORBUSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPOROTRODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPPOROTROGLOSADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPSENORESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPATENCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPDIRECCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPCASILLADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPCOMUNADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPCIUDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPFECHADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPFONO1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPFONO2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPCELULAR1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPCELULAR2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPFAX1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPFAX2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPEMAIL1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODESPEMAIL2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTENTREGODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROMUESTREADORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ULTIMAOTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPORCDESCUENTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LsDatosProductorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LabsysDataSet2 As LabSys.LabsysDataSet2
    Friend WithEvents Ls_DatosProductorTableAdapter As LabSys.LabsysDataSet2TableAdapters.ls_DatosProductorTableAdapter
    Friend WithEvents txUltimaOt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txNombreProductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txEmpresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txPredio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txRemite As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txLocalidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txComuna As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txRutProductor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txRutFacturacion As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
