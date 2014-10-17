Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO

Public Class F_ModificaOT
    Inherits System.Windows.Forms.Form
    Dim FSO As System.Object
    Dim sRutaDest, guardaRegistro As String
    Private Fila_grilla, codigo_antiguo, TxtDeDG, Muestra, ffi, Columna34, Num_Muestra, PreAna1, PreAna2, PreAna3, le, Fila_Cod, Columna_Cod As Integer
    Private myGriC As DataGrid
    Private DesAna1, DesAna2, DesAna3, ErrorDuplicacion As String
    Friend WithEvents DirectoryEntry1 As System.DirectoryServices.DirectoryEntry
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn108 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn107 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn74 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn73 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn72 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn66 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn106 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn100 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn65 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn64 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CBBusMuestra As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusRutFact As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents TxtBusFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents TxtBusRut As System.Windows.Forms.TextBox
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtBusLabDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtBusLabHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents CKBAnaxA As System.Windows.Forms.CheckBox
    Friend WithEvents CKBFacxF As System.Windows.Forms.CheckBox
    Friend WithEvents CKBPagPte As System.Windows.Forms.CheckBox
    Friend WithEvents GrbModificacion As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents ElGroupBox1 As Klik.Windows.Forms.v1.EntryLib.ELGroupBox
    Friend WithEvents txOTSeleccionada As System.Windows.Forms.TextBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents CmdOrdenTrabajo As System.Windows.Forms.Button
    Friend WithEvents CmdEliminarAnálisis As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmdAgregarAnalisis As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BTrevisaResultados As System.Windows.Forms.Button
    Friend WithEvents GrpFiltroBusqueda As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdAceptarFiltros As System.Windows.Forms.Button
    Friend WithEvents BTCerrarJocker As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CKBEFacCan As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CKBEFacPte As System.Windows.Forms.CheckBox
    Friend WithEvents CKBEFaccNC As System.Windows.Forms.CheckBox
    Friend WithEvents CKBEFacAbo As System.Windows.Forms.CheckBox
    Friend WithEvents CKBEFacNula As System.Windows.Forms.CheckBox
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CKBFacnoF As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CKBPagsc As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CKBPagCan As System.Windows.Forms.CheckBox
    Friend WithEvents CKBFacnoR As System.Windows.Forms.CheckBox
    Friend WithEvents CKBAnaNula As System.Windows.Forms.CheckBox
    Friend WithEvents CKBAnaDex As System.Windows.Forms.CheckBox
    Friend WithEvents CKBPagAbo As System.Windows.Forms.CheckBox
    Friend WithEvents CKBFacFac As System.Windows.Forms.CheckBox
    Friend WithEvents CKBFacAgr As System.Windows.Forms.CheckBox
    Friend WithEvents CKBAnaxDe As System.Windows.Forms.CheckBox
    Friend WithEvents CKBAnaDe As System.Windows.Forms.CheckBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents CBBusLocalidad As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusSolicita As System.Windows.Forms.TextBox
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents CBBusComuna As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents TxtBusDesCod As System.Windows.Forms.TextBox
    Friend WithEvents CBBusProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents TxtBusDesRegion As System.Windows.Forms.TextBox
    Friend WithEvents CBBusRegion As System.Windows.Forms.ComboBox
    Friend WithEvents TxtBusProductor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtBusOtDesde As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusOtHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtBusRemite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtBusEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents TxtBusFactura As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents pnl_resultados As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lbx_lista As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTBusAceptar As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents ElPanel1 As Klik.Windows.Forms.v1.EntryLib.ELPanel
    Friend WithEvents DGOrdenes As System.Windows.Forms.DataGridView
    Friend WithEvents OTNUMERODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTFECHAORDENDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PROPRODUCTORDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRORUTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTFACRUTDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTEMPRESADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTREMITEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMUMUESTRADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTCCANTIDADDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTCNLABDESDEDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTESTADOANADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTESTADOPAGDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTESTADOFACDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FACNUMERODataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FECHAFACTURADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OTESTADOFACTURADataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cjto_Tablas1 As LabSys.Cjto_Tablas

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Codigo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn75 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn76 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn77 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn78 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn79 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn81 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TT As LabSys.Cjto_Tablas
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(F_ModificaOT))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.TT = New LabSys.Cjto_Tablas
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Codigo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn75 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn76 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn77 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn78 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn79 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn81 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Cjto_Tablas1 = New LabSys.Cjto_Tablas
        Me.DirectoryEntry1 = New System.DirectoryServices.DirectoryEntry
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn108 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn107 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn74 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn73 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn72 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn66 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn106 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn100 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn65 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn64 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CBBusMuestra = New System.Windows.Forms.ComboBox
        Me.TxtBusRutFact = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.TxtBusFechaDesde = New System.Windows.Forms.TextBox
        Me.DtpFechaDesde = New System.Windows.Forms.DateTimePicker
        Me.Label81 = New System.Windows.Forms.Label
        Me.TxtBusRut = New System.Windows.Forms.TextBox
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.TxtBusLabDesde = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtBusLabHasta = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.CKBAnaxA = New System.Windows.Forms.CheckBox
        Me.CKBFacxF = New System.Windows.Forms.CheckBox
        Me.CKBPagPte = New System.Windows.Forms.CheckBox
        Me.GrbModificacion = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.ElGroupBox1 = New Klik.Windows.Forms.v1.EntryLib.ELGroupBox
        Me.txOTSeleccionada = New System.Windows.Forms.TextBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.CmdOrdenTrabajo = New System.Windows.Forms.Button
        Me.CmdEliminarAnálisis = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.CmdAgregarAnalisis = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.BTrevisaResultados = New System.Windows.Forms.Button
        Me.GrpFiltroBusqueda = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdAceptarFiltros = New System.Windows.Forms.Button
        Me.BTCerrarJocker = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CKBEFacCan = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CKBEFacPte = New System.Windows.Forms.CheckBox
        Me.CKBEFaccNC = New System.Windows.Forms.CheckBox
        Me.CKBEFacAbo = New System.Windows.Forms.CheckBox
        Me.CKBEFacNula = New System.Windows.Forms.CheckBox
        Me.Label88 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CKBFacnoF = New System.Windows.Forms.CheckBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.CKBPagsc = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CKBPagCan = New System.Windows.Forms.CheckBox
        Me.CKBFacnoR = New System.Windows.Forms.CheckBox
        Me.CKBAnaNula = New System.Windows.Forms.CheckBox
        Me.CKBAnaDex = New System.Windows.Forms.CheckBox
        Me.CKBPagAbo = New System.Windows.Forms.CheckBox
        Me.CKBFacFac = New System.Windows.Forms.CheckBox
        Me.CKBFacAgr = New System.Windows.Forms.CheckBox
        Me.CKBAnaxDe = New System.Windows.Forms.CheckBox
        Me.CKBAnaDe = New System.Windows.Forms.CheckBox
        Me.Label91 = New System.Windows.Forms.Label
        Me.CBBusLocalidad = New System.Windows.Forms.ComboBox
        Me.TxtBusSolicita = New System.Windows.Forms.TextBox
        Me.Label96 = New System.Windows.Forms.Label
        Me.CBBusComuna = New System.Windows.Forms.ComboBox
        Me.TxtBusCodigo = New System.Windows.Forms.TextBox
        Me.Label95 = New System.Windows.Forms.Label
        Me.TxtBusDesCod = New System.Windows.Forms.TextBox
        Me.CBBusProvincia = New System.Windows.Forms.ComboBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.TxtBusDesRegion = New System.Windows.Forms.TextBox
        Me.CBBusRegion = New System.Windows.Forms.ComboBox
        Me.TxtBusProductor = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtBusOtDesde = New System.Windows.Forms.TextBox
        Me.TxtBusOtHasta = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtBusRemite = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtBusEmpresa = New System.Windows.Forms.TextBox
        Me.TxtBusFactura = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.pnl_resultados = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.lbx_lista = New System.Windows.Forms.ListBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BTBusAceptar = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.ElPanel1 = New Klik.Windows.Forms.v1.EntryLib.ELPanel
        Me.DGOrdenes = New System.Windows.Forms.DataGridView
        Me.OTNUMERODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTFECHAORDENDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PROPRODUCTORDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PRORUTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTFACRUTDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTEMPRESADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTREMITEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TMUMUESTRADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTCCANTIDADDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTESTADOANADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTESTADOPAGDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTESTADOFACDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FACNUMERODataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FECHAFACTURADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.OTESTADOFACTURADataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.TT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrbModificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbModificacion.SuspendLayout()
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElGroupBox1.SuspendLayout()
        CType(Me.GrpFiltroBusqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpFiltroBusqueda.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pnl_resultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_resultados.SuspendLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElPanel1.SuspendLayout()
        CType(Me.DGOrdenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TT
        '
        Me.TT.DataSetName = "Cjto_Tablas"
        Me.TT.Locale = New System.Globalization.CultureInfo("en-US")
        Me.TT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Rut"
        Me.DataGridTextBoxColumn1.MappingName = "IRUT"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn2.MappingName = "ISRE"
        Me.DataGridTextBoxColumn2.Width = 115
        '
        'Codigo
        '
        Me.Codigo.Format = "Codigo"
        Me.Codigo.FormatInfo = Nothing
        Me.Codigo.Width = 75
        '
        'DataGridTextBoxColumn75
        '
        Me.DataGridTextBoxColumn75.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn75.Format = ""
        Me.DataGridTextBoxColumn75.FormatInfo = Nothing
        Me.DataGridTextBoxColumn75.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn75.MappingName = "TMU_MUESTRA"
        Me.DataGridTextBoxColumn75.NullText = ""
        Me.DataGridTextBoxColumn75.Width = 70
        '
        'DataGridTextBoxColumn76
        '
        Me.DataGridTextBoxColumn76.Format = ""
        Me.DataGridTextBoxColumn76.FormatInfo = Nothing
        Me.DataGridTextBoxColumn76.HeaderText = "N° Lab"
        Me.DataGridTextBoxColumn76.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn76.NullText = ""
        Me.DataGridTextBoxColumn76.Width = 60
        '
        'DataGridTextBoxColumn77
        '
        Me.DataGridTextBoxColumn77.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn77.Format = ""
        Me.DataGridTextBoxColumn77.FormatInfo = Nothing
        Me.DataGridTextBoxColumn77.HeaderText = "Código"
        Me.DataGridTextBoxColumn77.MappingName = "ANA_CODIGO1"
        Me.DataGridTextBoxColumn77.NullText = ""
        Me.DataGridTextBoxColumn77.Width = 60
        '
        'DataGridTextBoxColumn78
        '
        Me.DataGridTextBoxColumn78.Format = ""
        Me.DataGridTextBoxColumn78.FormatInfo = Nothing
        Me.DataGridTextBoxColumn78.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn78.MappingName = "ANA_DESCRIPCION1"
        Me.DataGridTextBoxColumn78.NullText = ""
        Me.DataGridTextBoxColumn78.Width = 610
        '
        'DataGridTextBoxColumn79
        '
        Me.DataGridTextBoxColumn79.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn79.Format = ""
        Me.DataGridTextBoxColumn79.FormatInfo = Nothing
        Me.DataGridTextBoxColumn79.HeaderText = "Código"
        Me.DataGridTextBoxColumn79.MappingName = "ANA_CODIGO2"
        Me.DataGridTextBoxColumn79.NullText = ""
        Me.DataGridTextBoxColumn79.Width = 60
        '
        'DataGridTextBoxColumn81
        '
        Me.DataGridTextBoxColumn81.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn81.Format = ""
        Me.DataGridTextBoxColumn81.FormatInfo = Nothing
        Me.DataGridTextBoxColumn81.HeaderText = "Código"
        Me.DataGridTextBoxColumn81.MappingName = "ANA_CODIGO3"
        Me.DataGridTextBoxColumn81.NullText = ""
        Me.DataGridTextBoxColumn81.Width = 60
        '
        'Cjto_Tablas1
        '
        Me.Cjto_Tablas1.DataSetName = "Cjto_Tablas"
        Me.Cjto_Tablas1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Cjto_Tablas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Est."
        Me.DataGridTextBoxColumn16.MappingName = "OT_ESTADO_FACTURA"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 30
        '
        'DataGridTextBoxColumn108
        '
        Me.DataGridTextBoxColumn108.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn108.Format = ""
        Me.DataGridTextBoxColumn108.FormatInfo = Nothing
        Me.DataGridTextBoxColumn108.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn108.MappingName = "FECHA_FACTURA"
        Me.DataGridTextBoxColumn108.NullText = ""
        Me.DataGridTextBoxColumn108.Width = 65
        '
        'DataGridTextBoxColumn107
        '
        Me.DataGridTextBoxColumn107.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn107.Format = ""
        Me.DataGridTextBoxColumn107.FormatInfo = Nothing
        Me.DataGridTextBoxColumn107.HeaderText = "Numero"
        Me.DataGridTextBoxColumn107.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn107.NullText = ""
        Me.DataGridTextBoxColumn107.Width = 50
        '
        'DataGridTextBoxColumn74
        '
        Me.DataGridTextBoxColumn74.Format = ""
        Me.DataGridTextBoxColumn74.FormatInfo = Nothing
        Me.DataGridTextBoxColumn74.HeaderText = "Fac"
        Me.DataGridTextBoxColumn74.MappingName = "OT_ESTADO_FAC"
        Me.DataGridTextBoxColumn74.NullText = ""
        Me.DataGridTextBoxColumn74.Width = 30
        '
        'DataGridTextBoxColumn73
        '
        Me.DataGridTextBoxColumn73.Format = ""
        Me.DataGridTextBoxColumn73.FormatInfo = Nothing
        Me.DataGridTextBoxColumn73.HeaderText = "Pag"
        Me.DataGridTextBoxColumn73.MappingName = "OT_ESTADO_PAG"
        Me.DataGridTextBoxColumn73.NullText = ""
        Me.DataGridTextBoxColumn73.Width = 30
        '
        'DataGridTextBoxColumn72
        '
        Me.DataGridTextBoxColumn72.Format = ""
        Me.DataGridTextBoxColumn72.FormatInfo = Nothing
        Me.DataGridTextBoxColumn72.HeaderText = "Ana"
        Me.DataGridTextBoxColumn72.MappingName = "OT_ESTADO_ANA"
        Me.DataGridTextBoxColumn72.NullText = ""
        Me.DataGridTextBoxColumn72.Width = 30
        '
        'DataGridTextBoxColumn66
        '
        Me.DataGridTextBoxColumn66.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn66.Format = "###,###"
        Me.DataGridTextBoxColumn66.FormatInfo = Nothing
        Me.DataGridTextBoxColumn66.HeaderText = "Desde"
        Me.DataGridTextBoxColumn66.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn66.NullText = ""
        Me.DataGridTextBoxColumn66.Width = 50
        '
        'DataGridTextBoxColumn106
        '
        Me.DataGridTextBoxColumn106.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn106.Format = ""
        Me.DataGridTextBoxColumn106.FormatInfo = Nothing
        Me.DataGridTextBoxColumn106.HeaderText = "Cant."
        Me.DataGridTextBoxColumn106.MappingName = "OTC_CANTIDAD"
        Me.DataGridTextBoxColumn106.NullText = ""
        Me.DataGridTextBoxColumn106.Width = 40
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn58.MappingName = "TMU_MUESTRA"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 40
        '
        'DataGridTextBoxColumn100
        '
        Me.DataGridTextBoxColumn100.Format = ""
        Me.DataGridTextBoxColumn100.FormatInfo = Nothing
        Me.DataGridTextBoxColumn100.HeaderText = "Remite"
        Me.DataGridTextBoxColumn100.MappingName = "OT_REMITE"
        Me.DataGridTextBoxColumn100.NullText = ""
        Me.DataGridTextBoxColumn100.Width = 85
        '
        'DataGridTextBoxColumn65
        '
        Me.DataGridTextBoxColumn65.Format = ""
        Me.DataGridTextBoxColumn65.FormatInfo = Nothing
        Me.DataGridTextBoxColumn65.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn65.MappingName = "OT_EMPRESA"
        Me.DataGridTextBoxColumn65.NullText = ""
        Me.DataGridTextBoxColumn65.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Rut Factura"
        Me.DataGridTextBoxColumn4.MappingName = "OT_FAC_RUT"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Rut Productor"
        Me.DataGridTextBoxColumn3.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn64
        '
        Me.DataGridTextBoxColumn64.Format = ""
        Me.DataGridTextBoxColumn64.FormatInfo = Nothing
        Me.DataGridTextBoxColumn64.HeaderText = "Productor"
        Me.DataGridTextBoxColumn64.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn64.NullText = ""
        Me.DataGridTextBoxColumn64.Width = 300
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Format = ""
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.HeaderText = "F.Ingreso"
        Me.DataGridTextBoxColumn56.MappingName = "OT_FECHA_ORDEN"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 70
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.HeaderText = "N° OT"
        Me.DataGridTextBoxColumn49.MappingName = "OT_NUMERO"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 50
        '
        'CBBusMuestra
        '
        Me.CBBusMuestra.DisplayMember = "MUESTRA.TMU_CODIGO"
        Me.CBBusMuestra.Location = New System.Drawing.Point(378, 821)
        Me.CBBusMuestra.Name = "CBBusMuestra"
        Me.CBBusMuestra.Size = New System.Drawing.Size(208, 21)
        Me.CBBusMuestra.TabIndex = 199
        Me.CBBusMuestra.ValueMember = "MUESTRA.TMU_CODIGO"
        '
        'TxtBusRutFact
        '
        Me.TxtBusRutFact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRutFact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusRutFact.Location = New System.Drawing.Point(983, 821)
        Me.TxtBusRutFact.Name = "TxtBusRutFact"
        Me.TxtBusRutFact.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusRutFact.TabIndex = 202
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(900, 823)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 140
        Me.Label1.Text = "Rut Fact :"
        '
        'Label73
        '
        Me.Label73.BackColor = System.Drawing.Color.Transparent
        Me.Label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(12, 822)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(64, 16)
        Me.Label73.TabIndex = 9
        Me.Label73.Text = "F. Desde "
        '
        'TxtBusFechaDesde
        '
        Me.TxtBusFechaDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusFechaDesde.Location = New System.Drawing.Point(90, 820)
        Me.TxtBusFechaDesde.MaxLength = 4
        Me.TxtBusFechaDesde.Name = "TxtBusFechaDesde"
        Me.TxtBusFechaDesde.Size = New System.Drawing.Size(92, 20)
        Me.TxtBusFechaDesde.TabIndex = 200
        '
        'DtpFechaDesde
        '
        Me.DtpFechaDesde.CustomFormat = "dd-mm-yyyy"
        Me.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaDesde.Location = New System.Drawing.Point(181, 820)
        Me.DtpFechaDesde.Name = "DtpFechaDesde"
        Me.DtpFechaDesde.Size = New System.Drawing.Size(20, 20)
        Me.DtpFechaDesde.TabIndex = 143
        '
        'Label81
        '
        Me.Label81.BackColor = System.Drawing.Color.Transparent
        Me.Label81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(900, 797)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(63, 17)
        Me.Label81.TabIndex = 21
        Me.Label81.Text = "Rut Prod :"
        '
        'TxtBusRut
        '
        Me.TxtBusRut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRut.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusRut.Location = New System.Drawing.Point(983, 795)
        Me.TxtBusRut.Name = "TxtBusRut"
        Me.TxtBusRut.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusRut.TabIndex = 201
        '
        'Label90
        '
        Me.Label90.BackColor = System.Drawing.Color.Transparent
        Me.Label90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(291, 823)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(86, 16)
        Me.Label90.TabIndex = 5
        Me.Label90.Text = "Tipo muestra"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(291, 850)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 16)
        Me.Label12.TabIndex = 181
        Me.Label12.Text = "N°Lab.Del"
        '
        'TxtBusLabDesde
        '
        Me.TxtBusLabDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabDesde.Location = New System.Drawing.Point(378, 848)
        Me.TxtBusLabDesde.Name = "TxtBusLabDesde"
        Me.TxtBusLabDesde.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabDesde.TabIndex = 197
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(449, 850)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(24, 16)
        Me.Label11.TabIndex = 183
        Me.Label11.Text = "Al"
        '
        'TxtBusLabHasta
        '
        Me.TxtBusLabHasta.AllowDrop = True
        Me.TxtBusLabHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusLabHasta.Location = New System.Drawing.Point(466, 848)
        Me.TxtBusLabHasta.Name = "TxtBusLabHasta"
        Me.TxtBusLabHasta.Size = New System.Drawing.Size(64, 20)
        Me.TxtBusLabHasta.TabIndex = 198
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label78.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label78.ForeColor = System.Drawing.Color.Black
        Me.Label78.Location = New System.Drawing.Point(1097, 9)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(156, 24)
        Me.Label78.TabIndex = 30
        Me.Label78.Text = "Factura"
        Me.Label78.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label72
        '
        Me.Label72.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label72.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(1007, 9)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(90, 24)
        Me.Label72.TabIndex = 29
        Me.Label72.Text = "Estado OT"
        Me.Label72.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label41
        '
        Me.Label41.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label41.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(867, 9)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(140, 24)
        Me.Label41.TabIndex = 28
        Me.Label41.Text = "N° Laboratorio"
        Me.Label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CKBAnaxA
        '
        Me.CKBAnaxA.BackColor = System.Drawing.Color.Transparent
        Me.CKBAnaxA.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKBAnaxA.ForeColor = System.Drawing.Color.Black
        Me.CKBAnaxA.Location = New System.Drawing.Point(664, 866)
        Me.CKBAnaxA.Name = "CKBAnaxA"
        Me.CKBAnaxA.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBAnaxA.Size = New System.Drawing.Size(111, 16)
        Me.CKBAnaxA.TabIndex = 25
        Me.CKBAnaxA.Text = "Por Analizar"
        Me.CKBAnaxA.UseVisualStyleBackColor = False
        '
        'CKBFacxF
        '
        Me.CKBFacxF.BackColor = System.Drawing.Color.Transparent
        Me.CKBFacxF.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKBFacxF.ForeColor = System.Drawing.Color.Black
        Me.CKBFacxF.Location = New System.Drawing.Point(885, 866)
        Me.CKBFacxF.Name = "CKBFacxF"
        Me.CKBFacxF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBFacxF.Size = New System.Drawing.Size(106, 16)
        Me.CKBFacxF.TabIndex = 27
        Me.CKBFacxF.Text = "Por Facturar"
        Me.CKBFacxF.UseVisualStyleBackColor = False
        '
        'CKBPagPte
        '
        Me.CKBPagPte.BackColor = System.Drawing.Color.Transparent
        Me.CKBPagPte.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKBPagPte.ForeColor = System.Drawing.Color.Black
        Me.CKBPagPte.Location = New System.Drawing.Point(766, 866)
        Me.CKBPagPte.Name = "CKBPagPte"
        Me.CKBPagPte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBPagPte.Size = New System.Drawing.Size(113, 16)
        Me.CKBPagPte.TabIndex = 29
        Me.CKBPagPte.Text = "Por Cancelar"
        Me.CKBPagPte.UseVisualStyleBackColor = False
        '
        'GrbModificacion
        '
        Me.GrbModificacion.BackgroundStyle.GradientAngle = 45.0!
        Me.GrbModificacion.BackgroundStyle.GradientEndColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GrbModificacion.BackgroundStyle.GradientStartColor = System.Drawing.Color.White
        Me.GrbModificacion.BackgroundStyle.PaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.GrbModificacion.BackgroundStyle.SolidColor = System.Drawing.Color.DimGray
        Me.GrbModificacion.Controls.Add(Me.ElGroupBox1)
        Me.GrbModificacion.Controls.Add(Me.Button6)
        Me.GrbModificacion.Controls.Add(Me.CmdOrdenTrabajo)
        Me.GrbModificacion.Controls.Add(Me.CmdEliminarAnálisis)
        Me.GrbModificacion.Controls.Add(Me.Button2)
        Me.GrbModificacion.Controls.Add(Me.CmdAgregarAnalisis)
        Me.GrbModificacion.Controls.Add(Me.Button3)
        Me.GrbModificacion.Controls.Add(Me.BTrevisaResultados)
        Me.GrbModificacion.Location = New System.Drawing.Point(-3, 504)
        Me.GrbModificacion.Name = "GrbModificacion"
        Me.GrbModificacion.Size = New System.Drawing.Size(1276, 193)
        Me.GrbModificacion.TabIndex = 197
        Me.GrbModificacion.Visible = False
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
        Me.ElGroupBox1.Controls.Add(Me.txOTSeleccionada)
        Me.ElGroupBox1.Location = New System.Drawing.Point(43, 18)
        Me.ElGroupBox1.Name = "ElGroupBox1"
        Me.ElGroupBox1.Padding = New System.Windows.Forms.Padding(4, 27, 4, 3)
        Me.ElGroupBox1.Size = New System.Drawing.Size(175, 144)
        Me.ElGroupBox1.TabIndex = 61
        '
        'txOTSeleccionada
        '
        Me.txOTSeleccionada.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txOTSeleccionada.Location = New System.Drawing.Point(50, 70)
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
        Me.Button6.Location = New System.Drawing.Point(491, 100)
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
        Me.CmdOrdenTrabajo.Location = New System.Drawing.Point(248, 31)
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
        Me.CmdEliminarAnálisis.Location = New System.Drawing.Point(491, 31)
        Me.CmdEliminarAnálisis.Name = "CmdEliminarAnálisis"
        Me.CmdEliminarAnálisis.Size = New System.Drawing.Size(231, 63)
        Me.CmdEliminarAnálisis.TabIndex = 58
        Me.CmdEliminarAnálisis.Text = "Anular  Análisis"
        Me.CmdEliminarAnálisis.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(1010, 67)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(231, 63)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cerrar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'CmdAgregarAnalisis
        '
        Me.CmdAgregarAnalisis.BackColor = System.Drawing.Color.Transparent
        Me.CmdAgregarAnalisis.Image = CType(resources.GetObject("CmdAgregarAnalisis.Image"), System.Drawing.Image)
        Me.CmdAgregarAnalisis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAgregarAnalisis.Location = New System.Drawing.Point(248, 100)
        Me.CmdAgregarAnalisis.Name = "CmdAgregarAnalisis"
        Me.CmdAgregarAnalisis.Size = New System.Drawing.Size(231, 63)
        Me.CmdAgregarAnalisis.TabIndex = 57
        Me.CmdAgregarAnalisis.Text = "Agregar Análisis (genera nueva OT)"
        Me.CmdAgregarAnalisis.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Button3.Location = New System.Drawing.Point(732, 100)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(231, 63)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Estados"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BTrevisaResultados
        '
        Me.BTrevisaResultados.BackColor = System.Drawing.Color.Transparent
        Me.BTrevisaResultados.Image = CType(resources.GetObject("BTrevisaResultados.Image"), System.Drawing.Image)
        Me.BTrevisaResultados.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BTrevisaResultados.Location = New System.Drawing.Point(732, 31)
        Me.BTrevisaResultados.Name = "BTrevisaResultados"
        Me.BTrevisaResultados.Size = New System.Drawing.Size(231, 63)
        Me.BTrevisaResultados.TabIndex = 7
        Me.BTrevisaResultados.Text = "Revisa Resultados"
        Me.BTrevisaResultados.UseVisualStyleBackColor = False
        '
        'GrpFiltroBusqueda
        '
        Me.GrpFiltroBusqueda.BackgroundStyle.GradientAngle = 45.0!
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label3)
        Me.GrpFiltroBusqueda.Controls.Add(Me.CmdAceptarFiltros)
        Me.GrpFiltroBusqueda.Controls.Add(Me.BTCerrarJocker)
        Me.GrpFiltroBusqueda.Controls.Add(Me.GroupBox2)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label88)
        Me.GrpFiltroBusqueda.Controls.Add(Me.GroupBox1)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label91)
        Me.GrpFiltroBusqueda.Controls.Add(Me.CBBusLocalidad)
        Me.GrpFiltroBusqueda.Controls.Add(Me.TxtBusSolicita)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label96)
        Me.GrpFiltroBusqueda.Controls.Add(Me.CBBusComuna)
        Me.GrpFiltroBusqueda.Controls.Add(Me.TxtBusCodigo)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label95)
        Me.GrpFiltroBusqueda.Controls.Add(Me.TxtBusDesCod)
        Me.GrpFiltroBusqueda.Controls.Add(Me.CBBusProvincia)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label92)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label94)
        Me.GrpFiltroBusqueda.Controls.Add(Me.Label93)
        Me.GrpFiltroBusqueda.Controls.Add(Me.TxtBusDesRegion)
        Me.GrpFiltroBusqueda.Controls.Add(Me.CBBusRegion)
        Me.GrpFiltroBusqueda.Location = New System.Drawing.Point(378, 103)
        Me.GrpFiltroBusqueda.Name = "GrpFiltroBusqueda"
        Me.GrpFiltroBusqueda.Size = New System.Drawing.Size(505, 442)
        Me.GrpFiltroBusqueda.TabIndex = 198
        Me.GrpFiltroBusqueda.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(1, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(480, 16)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Parámetros de Busqueda"
        '
        'CmdAceptarFiltros
        '
        Me.CmdAceptarFiltros.BackColor = System.Drawing.Color.Transparent
        Me.CmdAceptarFiltros.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdAceptarFiltros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAceptarFiltros.Location = New System.Drawing.Point(217, 403)
        Me.CmdAceptarFiltros.Name = "CmdAceptarFiltros"
        Me.CmdAceptarFiltros.Size = New System.Drawing.Size(72, 23)
        Me.CmdAceptarFiltros.TabIndex = 42
        Me.CmdAceptarFiltros.Text = "Aceptar"
        Me.CmdAceptarFiltros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdAceptarFiltros.UseVisualStyleBackColor = False
        '
        'BTCerrarJocker
        '
        Me.BTCerrarJocker.BackColor = System.Drawing.Color.Transparent
        Me.BTCerrarJocker.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTCerrarJocker.Location = New System.Drawing.Point(480, 3)
        Me.BTCerrarJocker.Name = "BTCerrarJocker"
        Me.BTCerrarJocker.Size = New System.Drawing.Size(24, 16)
        Me.BTCerrarJocker.TabIndex = 39
        Me.BTCerrarJocker.Text = "X"
        Me.BTCerrarJocker.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CKBEFacCan)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.CKBEFacPte)
        Me.GroupBox2.Controls.Add(Me.CKBEFaccNC)
        Me.GroupBox2.Controls.Add(Me.CKBEFacAbo)
        Me.GroupBox2.Controls.Add(Me.CKBEFacNula)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(361, 223)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 168)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estados de la Factura"
        '
        'CKBEFacCan
        '
        Me.CKBEFacCan.ForeColor = System.Drawing.Color.Black
        Me.CKBEFacCan.Location = New System.Drawing.Point(24, 96)
        Me.CKBEFacCan.Name = "CKBEFacCan"
        Me.CKBEFacCan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBEFacCan.Size = New System.Drawing.Size(96, 16)
        Me.CKBEFacCan.TabIndex = 41
        Me.CKBEFacCan.Text = "Cancelada"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(48, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Factura"
        '
        'CKBEFacPte
        '
        Me.CKBEFacPte.ForeColor = System.Drawing.Color.Black
        Me.CKBEFacPte.Location = New System.Drawing.Point(8, 48)
        Me.CKBEFacPte.Name = "CKBEFacPte"
        Me.CKBEFacPte.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBEFacPte.Size = New System.Drawing.Size(112, 16)
        Me.CKBEFacPte.TabIndex = 27
        Me.CKBEFacPte.Text = "Pendiente"
        '
        'CKBEFaccNC
        '
        Me.CKBEFaccNC.ForeColor = System.Drawing.Color.Black
        Me.CKBEFaccNC.Location = New System.Drawing.Point(24, 144)
        Me.CKBEFaccNC.Name = "CKBEFaccNC"
        Me.CKBEFaccNC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBEFaccNC.Size = New System.Drawing.Size(96, 16)
        Me.CKBEFaccNC.TabIndex = 34
        Me.CKBEFaccNC.Text = "c/NC"
        '
        'CKBEFacAbo
        '
        Me.CKBEFacAbo.ForeColor = System.Drawing.Color.Black
        Me.CKBEFacAbo.Location = New System.Drawing.Point(6, 72)
        Me.CKBEFacAbo.Name = "CKBEFacAbo"
        Me.CKBEFacAbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBEFacAbo.Size = New System.Drawing.Size(114, 16)
        Me.CKBEFacAbo.TabIndex = 33
        Me.CKBEFacAbo.Text = "Cancelada Parcial"
        '
        'CKBEFacNula
        '
        Me.CKBEFacNula.ForeColor = System.Drawing.Color.Black
        Me.CKBEFacNula.Location = New System.Drawing.Point(24, 120)
        Me.CKBEFacNula.Name = "CKBEFacNula"
        Me.CKBEFacNula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBEFacNula.Size = New System.Drawing.Size(96, 16)
        Me.CKBEFacNula.TabIndex = 35
        Me.CKBEFacNula.Text = "Nula"
        '
        'Label88
        '
        Me.Label88.BackColor = System.Drawing.Color.Transparent
        Me.Label88.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Black
        Me.Label88.Location = New System.Drawing.Point(14, 35)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(64, 16)
        Me.Label88.TabIndex = 31
        Me.Label88.Text = "Solicita :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CKBFacnoF)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CKBPagsc)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CKBPagCan)
        Me.GroupBox1.Controls.Add(Me.CKBFacnoR)
        Me.GroupBox1.Controls.Add(Me.CKBAnaNula)
        Me.GroupBox1.Controls.Add(Me.CKBAnaDex)
        Me.GroupBox1.Controls.Add(Me.CKBPagAbo)
        Me.GroupBox1.Controls.Add(Me.CKBFacFac)
        Me.GroupBox1.Controls.Add(Me.CKBFacAgr)
        Me.GroupBox1.Controls.Add(Me.CKBAnaxDe)
        Me.GroupBox1.Controls.Add(Me.CKBAnaDe)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(9, 223)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 168)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estados de la OT"
        '
        'CKBFacnoF
        '
        Me.CKBFacnoF.ForeColor = System.Drawing.Color.Black
        Me.CKBFacnoF.Location = New System.Drawing.Point(248, 72)
        Me.CKBFacnoF.Name = "CKBFacnoF"
        Me.CKBFacnoF.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBFacnoF.Size = New System.Drawing.Size(96, 16)
        Me.CKBFacnoF.TabIndex = 41
        Me.CKBFacnoF.Text = "s/Factura"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(256, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Facturación"
        '
        'CKBPagsc
        '
        Me.CKBPagsc.ForeColor = System.Drawing.Color.Black
        Me.CKBPagsc.Location = New System.Drawing.Point(120, 96)
        Me.CKBPagsc.Name = "CKBPagsc"
        Me.CKBPagsc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBPagsc.Size = New System.Drawing.Size(96, 16)
        Me.CKBPagsc.TabIndex = 39
        Me.CKBPagsc.Text = "s/costo"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(160, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Pago"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(48, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Análisis"
        '
        'CKBPagCan
        '
        Me.CKBPagCan.ForeColor = System.Drawing.Color.Black
        Me.CKBPagCan.Location = New System.Drawing.Point(120, 72)
        Me.CKBPagCan.Name = "CKBPagCan"
        Me.CKBPagCan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBPagCan.Size = New System.Drawing.Size(96, 16)
        Me.CKBPagCan.TabIndex = 31
        Me.CKBPagCan.Text = "Cancelada"
        '
        'CKBFacnoR
        '
        Me.CKBFacnoR.ForeColor = System.Drawing.Color.Black
        Me.CKBFacnoR.Location = New System.Drawing.Point(248, 96)
        Me.CKBFacnoR.Name = "CKBFacnoR"
        Me.CKBFacnoR.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBFacnoR.Size = New System.Drawing.Size(96, 16)
        Me.CKBFacnoR.TabIndex = 34
        Me.CKBFacnoR.Text = "No Retirada"
        '
        'CKBAnaNula
        '
        Me.CKBAnaNula.ForeColor = System.Drawing.Color.Black
        Me.CKBAnaNula.Location = New System.Drawing.Point(40, 72)
        Me.CKBAnaNula.Name = "CKBAnaNula"
        Me.CKBAnaNula.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBAnaNula.Size = New System.Drawing.Size(64, 16)
        Me.CKBAnaNula.TabIndex = 36
        Me.CKBAnaNula.Text = "Nula"
        '
        'CKBAnaDex
        '
        Me.CKBAnaDex.ForeColor = System.Drawing.Color.Black
        Me.CKBAnaDex.Location = New System.Drawing.Point(8, 48)
        Me.CKBAnaDex.Name = "CKBAnaDex"
        Me.CKBAnaDex.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBAnaDex.Size = New System.Drawing.Size(96, 16)
        Me.CKBAnaDex.TabIndex = 32
        Me.CKBAnaDex.Text = "Desp. Parcial"
        '
        'CKBPagAbo
        '
        Me.CKBPagAbo.ForeColor = System.Drawing.Color.Black
        Me.CKBPagAbo.Location = New System.Drawing.Point(120, 48)
        Me.CKBPagAbo.Name = "CKBPagAbo"
        Me.CKBPagAbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBPagAbo.Size = New System.Drawing.Size(96, 16)
        Me.CKBPagAbo.TabIndex = 30
        Me.CKBPagAbo.Text = "Con Abono"
        '
        'CKBFacFac
        '
        Me.CKBFacFac.ForeColor = System.Drawing.Color.Black
        Me.CKBFacFac.Location = New System.Drawing.Point(248, 48)
        Me.CKBFacFac.Name = "CKBFacFac"
        Me.CKBFacFac.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBFacFac.Size = New System.Drawing.Size(96, 16)
        Me.CKBFacFac.TabIndex = 33
        Me.CKBFacFac.Text = "Facturada"
        '
        'CKBFacAgr
        '
        Me.CKBFacAgr.ForeColor = System.Drawing.Color.Black
        Me.CKBFacAgr.Location = New System.Drawing.Point(248, 120)
        Me.CKBFacAgr.Name = "CKBFacAgr"
        Me.CKBFacAgr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBFacAgr.Size = New System.Drawing.Size(96, 16)
        Me.CKBFacAgr.TabIndex = 35
        Me.CKBFacAgr.Text = "Ensayo Agro"
        '
        'CKBAnaxDe
        '
        Me.CKBAnaxDe.ForeColor = System.Drawing.Color.Black
        Me.CKBAnaxDe.Location = New System.Drawing.Point(24, 96)
        Me.CKBAnaxDe.Name = "CKBAnaxDe"
        Me.CKBAnaxDe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBAnaxDe.Size = New System.Drawing.Size(80, 16)
        Me.CKBAnaxDe.TabIndex = 26
        Me.CKBAnaxDe.Text = "Por Despachar"
        '
        'CKBAnaDe
        '
        Me.CKBAnaDe.ForeColor = System.Drawing.Color.Black
        Me.CKBAnaDe.Location = New System.Drawing.Point(8, 120)
        Me.CKBAnaDe.Name = "CKBAnaDe"
        Me.CKBAnaDe.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CKBAnaDe.Size = New System.Drawing.Size(96, 16)
        Me.CKBAnaDe.TabIndex = 30
        Me.CKBAnaDe.Text = "Despachada"
        '
        'Label91
        '
        Me.Label91.BackColor = System.Drawing.Color.Transparent
        Me.Label91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.Black
        Me.Label91.Location = New System.Drawing.Point(14, 60)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(102, 16)
        Me.Label91.TabIndex = 7
        Me.Label91.Text = "Código Análisis :"
        '
        'CBBusLocalidad
        '
        Me.CBBusLocalidad.Location = New System.Drawing.Point(116, 188)
        Me.CBBusLocalidad.Name = "CBBusLocalidad"
        Me.CBBusLocalidad.Size = New System.Drawing.Size(120, 21)
        Me.CBBusLocalidad.TabIndex = 19
        '
        'TxtBusSolicita
        '
        Me.TxtBusSolicita.Location = New System.Drawing.Point(116, 33)
        Me.TxtBusSolicita.Name = "TxtBusSolicita"
        Me.TxtBusSolicita.Size = New System.Drawing.Size(192, 20)
        Me.TxtBusSolicita.TabIndex = 32
        '
        'Label96
        '
        Me.Label96.BackColor = System.Drawing.Color.Transparent
        Me.Label96.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.ForeColor = System.Drawing.Color.Black
        Me.Label96.Location = New System.Drawing.Point(13, 190)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(88, 16)
        Me.Label96.TabIndex = 18
        Me.Label96.Text = "Localidad :"
        '
        'CBBusComuna
        '
        Me.CBBusComuna.Location = New System.Drawing.Point(116, 161)
        Me.CBBusComuna.Name = "CBBusComuna"
        Me.CBBusComuna.Size = New System.Drawing.Size(120, 21)
        Me.CBBusComuna.TabIndex = 17
        '
        'TxtBusCodigo
        '
        Me.TxtBusCodigo.Location = New System.Drawing.Point(116, 58)
        Me.TxtBusCodigo.Name = "TxtBusCodigo"
        Me.TxtBusCodigo.Size = New System.Drawing.Size(48, 20)
        Me.TxtBusCodigo.TabIndex = 8
        '
        'Label95
        '
        Me.Label95.BackColor = System.Drawing.Color.Transparent
        Me.Label95.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.ForeColor = System.Drawing.Color.Black
        Me.Label95.Location = New System.Drawing.Point(13, 163)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(88, 16)
        Me.Label95.TabIndex = 16
        Me.Label95.Text = "Comuna :"
        '
        'TxtBusDesCod
        '
        Me.TxtBusDesCod.Location = New System.Drawing.Point(171, 58)
        Me.TxtBusDesCod.Name = "TxtBusDesCod"
        Me.TxtBusDesCod.Size = New System.Drawing.Size(280, 20)
        Me.TxtBusDesCod.TabIndex = 12
        '
        'CBBusProvincia
        '
        Me.CBBusProvincia.Location = New System.Drawing.Point(116, 134)
        Me.CBBusProvincia.Name = "CBBusProvincia"
        Me.CBBusProvincia.Size = New System.Drawing.Size(120, 21)
        Me.CBBusProvincia.TabIndex = 15
        '
        'Label92
        '
        Me.Label92.BackColor = System.Drawing.Color.Transparent
        Me.Label92.Font = New System.Drawing.Font("Arial", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.Black
        Me.Label92.Location = New System.Drawing.Point(6, 87)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(64, 16)
        Me.Label92.TabIndex = 9
        Me.Label92.Text = "Ubicación"
        '
        'Label94
        '
        Me.Label94.BackColor = System.Drawing.Color.Transparent
        Me.Label94.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(14, 136)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(88, 16)
        Me.Label94.TabIndex = 14
        Me.Label94.Text = "Provincia :"
        '
        'Label93
        '
        Me.Label93.BackColor = System.Drawing.Color.Transparent
        Me.Label93.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.Black
        Me.Label93.Location = New System.Drawing.Point(14, 109)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(88, 16)
        Me.Label93.TabIndex = 10
        Me.Label93.Text = "Región :"
        '
        'TxtBusDesRegion
        '
        Me.TxtBusDesRegion.Location = New System.Drawing.Point(180, 107)
        Me.TxtBusDesRegion.Name = "TxtBusDesRegion"
        Me.TxtBusDesRegion.Size = New System.Drawing.Size(184, 20)
        Me.TxtBusDesRegion.TabIndex = 13
        '
        'CBBusRegion
        '
        Me.CBBusRegion.Location = New System.Drawing.Point(116, 107)
        Me.CBBusRegion.Name = "CBBusRegion"
        Me.CBBusRegion.Size = New System.Drawing.Size(56, 21)
        Me.CBBusRegion.TabIndex = 11
        '
        'TxtBusProductor
        '
        Me.TxtBusProductor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusProductor.Location = New System.Drawing.Point(90, 794)
        Me.TxtBusProductor.Name = "TxtBusProductor"
        Me.TxtBusProductor.Size = New System.Drawing.Size(182, 20)
        Me.TxtBusProductor.TabIndex = 208
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 797)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 209
        Me.Label2.Text = "Productor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(12, 849)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 210
        Me.Label8.Text = "N° OT Del"
        '
        'TxtBusOtDesde
        '
        Me.TxtBusOtDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusOtDesde.Location = New System.Drawing.Point(89, 846)
        Me.TxtBusOtDesde.Name = "TxtBusOtDesde"
        Me.TxtBusOtDesde.Size = New System.Drawing.Size(79, 20)
        Me.TxtBusOtDesde.TabIndex = 211
        '
        'TxtBusOtHasta
        '
        Me.TxtBusOtHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusOtHasta.Location = New System.Drawing.Point(193, 846)
        Me.TxtBusOtHasta.Name = "TxtBusOtHasta"
        Me.TxtBusOtHasta.Size = New System.Drawing.Size(79, 20)
        Me.TxtBusOtHasta.TabIndex = 212
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(171, 849)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 213
        Me.Label9.Text = "Al"
        '
        'TxtBusRemite
        '
        Me.TxtBusRemite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusRemite.Location = New System.Drawing.Point(649, 795)
        Me.TxtBusRemite.Name = "TxtBusRemite"
        Me.TxtBusRemite.Size = New System.Drawing.Size(210, 20)
        Me.TxtBusRemite.TabIndex = 214
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(596, 797)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 215
        Me.Label10.Text = "Remite"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(291, 797)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 216
        Me.Label13.Text = "Empresa"
        '
        'TxtBusEmpresa
        '
        Me.TxtBusEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusEmpresa.Location = New System.Drawing.Point(378, 795)
        Me.TxtBusEmpresa.Name = "TxtBusEmpresa"
        Me.TxtBusEmpresa.Size = New System.Drawing.Size(208, 20)
        Me.TxtBusEmpresa.TabIndex = 217
        '
        'TxtBusFactura
        '
        Me.TxtBusFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBusFactura.Location = New System.Drawing.Point(649, 822)
        Me.TxtBusFactura.Name = "TxtBusFactura"
        Me.TxtBusFactura.Size = New System.Drawing.Size(100, 20)
        Me.TxtBusFactura.TabIndex = 218
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(596, 824)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 13)
        Me.Label14.TabIndex = 219
        Me.Label14.Text = "Factura"
        '
        'pnl_resultados
        '
        Me.pnl_resultados.BackgroundStyle.GradientAngle = 45.0!
        Me.pnl_resultados.Controls.Add(Me.Button8)
        Me.pnl_resultados.Controls.Add(Me.Button7)
        Me.pnl_resultados.Controls.Add(Me.Label15)
        Me.pnl_resultados.Controls.Add(Me.lbx_lista)
        Me.pnl_resultados.Location = New System.Drawing.Point(226, 645)
        Me.pnl_resultados.Name = "pnl_resultados"
        Me.pnl_resultados.Size = New System.Drawing.Size(752, 117)
        Me.pnl_resultados.TabIndex = 221
        Me.pnl_resultados.Visible = False
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(663, 63)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 66
        Me.Button8.Text = "Cerrar"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(663, 34)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 65
        Me.Button7.Text = "Adjuntar"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(12, 11)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 13)
        Me.Label15.TabIndex = 64
        Me.Label15.Text = "Resultados Encontrados:"
        '
        'lbx_lista
        '
        Me.lbx_lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbx_lista.FormattingEnabled = True
        Me.lbx_lista.Location = New System.Drawing.Point(15, 27)
        Me.lbx_lista.Name = "lbx_lista"
        Me.lbx_lista.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbx_lista.Size = New System.Drawing.Size(642, 69)
        Me.lbx_lista.TabIndex = 63
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.add
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1109, 802)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(74, 40)
        Me.Button1.TabIndex = 205
        Me.Button1.Text = "Filtros"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTBusAceptar
        '
        Me.BTBusAceptar.BackColor = System.Drawing.Color.Transparent
        Me.BTBusAceptar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.BTBusAceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTBusAceptar.Location = New System.Drawing.Point(1109, 853)
        Me.BTBusAceptar.Name = "BTBusAceptar"
        Me.BTBusAceptar.Size = New System.Drawing.Size(74, 40)
        Me.BTBusAceptar.TabIndex = 203
        Me.BTBusAceptar.Text = "Aceptar"
        Me.BTBusAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTBusAceptar.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1189, 802)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 40)
        Me.Button4.TabIndex = 206
        Me.Button4.Text = "Limpiar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.LabSys.My.Resources.Resources.arrow_refresh_small
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(1189, 853)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(74, 40)
        Me.Button5.TabIndex = 204
        Me.Button5.Text = "Refrescar"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ElPanel1
        '
        Me.ElPanel1.BackgroundStyle.GradientAngle = 45.0!
        Me.ElPanel1.Controls.Add(Me.DGOrdenes)
        Me.ElPanel1.Controls.Add(Me.CKBAnaxA)
        Me.ElPanel1.Controls.Add(Me.Label13)
        Me.ElPanel1.Controls.Add(Me.CKBFacxF)
        Me.ElPanel1.Controls.Add(Me.Label10)
        Me.ElPanel1.Controls.Add(Me.Label81)
        Me.ElPanel1.Controls.Add(Me.Label8)
        Me.ElPanel1.Controls.Add(Me.Label90)
        Me.ElPanel1.Controls.Add(Me.Label2)
        Me.ElPanel1.Controls.Add(Me.Label1)
        Me.ElPanel1.Controls.Add(Me.Label12)
        Me.ElPanel1.Controls.Add(Me.Label73)
        Me.ElPanel1.Controls.Add(Me.Label14)
        Me.ElPanel1.Controls.Add(Me.CKBPagPte)
        Me.ElPanel1.Controls.Add(Me.Label11)
        Me.ElPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ElPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ElPanel1.Name = "ElPanel1"
        Me.ElPanel1.Size = New System.Drawing.Size(1270, 925)
        Me.ElPanel1.TabIndex = 224
        '
        'DGOrdenes
        '
        Me.DGOrdenes.AllowUserToAddRows = False
        Me.DGOrdenes.AllowUserToDeleteRows = False
        Me.DGOrdenes.AutoGenerateColumns = False
        Me.DGOrdenes.BackgroundColor = System.Drawing.Color.DimGray
        Me.DGOrdenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGOrdenes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OTNUMERODataGridViewTextBoxColumn1, Me.OTFECHAORDENDataGridViewTextBoxColumn1, Me.PROPRODUCTORDataGridViewTextBoxColumn1, Me.PRORUTDataGridViewTextBoxColumn1, Me.OTFACRUTDataGridViewTextBoxColumn1, Me.OTEMPRESADataGridViewTextBoxColumn1, Me.OTREMITEDataGridViewTextBoxColumn1, Me.TMUMUESTRADataGridViewTextBoxColumn1, Me.OTCCANTIDADDataGridViewTextBoxColumn1, Me.OTCNLABDESDEDataGridViewTextBoxColumn1, Me.OTESTADOANADataGridViewTextBoxColumn1, Me.OTESTADOPAGDataGridViewTextBoxColumn1, Me.OTESTADOFACDataGridViewTextBoxColumn1, Me.FACNUMERODataGridViewTextBoxColumn1, Me.FECHAFACTURADataGridViewTextBoxColumn1, Me.OTESTADOFACTURADataGridViewTextBoxColumn1})
        Me.DGOrdenes.DataMember = "CONSULTA_ORDEN"
        Me.DGOrdenes.DataSource = Me.TT
        Me.DGOrdenes.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.DGOrdenes.Location = New System.Drawing.Point(11, 27)
        Me.DGOrdenes.Name = "DGOrdenes"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        Me.DGOrdenes.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGOrdenes.Size = New System.Drawing.Size(1256, 746)
        Me.DGOrdenes.TabIndex = 221
        '
        'OTNUMERODataGridViewTextBoxColumn1
        '
        Me.OTNUMERODataGridViewTextBoxColumn1.DataPropertyName = "OT_NUMERO"
        Me.OTNUMERODataGridViewTextBoxColumn1.HeaderText = "N° OT"
        Me.OTNUMERODataGridViewTextBoxColumn1.Name = "OTNUMERODataGridViewTextBoxColumn1"
        Me.OTNUMERODataGridViewTextBoxColumn1.Width = 50
        '
        'OTFECHAORDENDataGridViewTextBoxColumn1
        '
        Me.OTFECHAORDENDataGridViewTextBoxColumn1.DataPropertyName = "OT_FECHA_ORDEN"
        Me.OTFECHAORDENDataGridViewTextBoxColumn1.HeaderText = "Fecha Ingreso"
        Me.OTFECHAORDENDataGridViewTextBoxColumn1.Name = "OTFECHAORDENDataGridViewTextBoxColumn1"
        Me.OTFECHAORDENDataGridViewTextBoxColumn1.Width = 70
        '
        'PROPRODUCTORDataGridViewTextBoxColumn1
        '
        Me.PROPRODUCTORDataGridViewTextBoxColumn1.DataPropertyName = "PRO_PRODUCTOR"
        Me.PROPRODUCTORDataGridViewTextBoxColumn1.HeaderText = "Productor"
        Me.PROPRODUCTORDataGridViewTextBoxColumn1.Name = "PROPRODUCTORDataGridViewTextBoxColumn1"
        Me.PROPRODUCTORDataGridViewTextBoxColumn1.Width = 280
        '
        'PRORUTDataGridViewTextBoxColumn1
        '
        Me.PRORUTDataGridViewTextBoxColumn1.DataPropertyName = "PRO_RUT"
        Me.PRORUTDataGridViewTextBoxColumn1.HeaderText = "Rut Productor"
        Me.PRORUTDataGridViewTextBoxColumn1.Name = "PRORUTDataGridViewTextBoxColumn1"
        Me.PRORUTDataGridViewTextBoxColumn1.Width = 90
        '
        'OTFACRUTDataGridViewTextBoxColumn1
        '
        Me.OTFACRUTDataGridViewTextBoxColumn1.DataPropertyName = "OT_FAC_RUT"
        Me.OTFACRUTDataGridViewTextBoxColumn1.HeaderText = "Rut Factura"
        Me.OTFACRUTDataGridViewTextBoxColumn1.Name = "OTFACRUTDataGridViewTextBoxColumn1"
        Me.OTFACRUTDataGridViewTextBoxColumn1.Width = 90
        '
        'OTEMPRESADataGridViewTextBoxColumn1
        '
        Me.OTEMPRESADataGridViewTextBoxColumn1.DataPropertyName = "OT_EMPRESA"
        Me.OTEMPRESADataGridViewTextBoxColumn1.HeaderText = "Empresa"
        Me.OTEMPRESADataGridViewTextBoxColumn1.Name = "OTEMPRESADataGridViewTextBoxColumn1"
        Me.OTEMPRESADataGridViewTextBoxColumn1.Width = 150
        '
        'OTREMITEDataGridViewTextBoxColumn1
        '
        Me.OTREMITEDataGridViewTextBoxColumn1.DataPropertyName = "OT_REMITE"
        Me.OTREMITEDataGridViewTextBoxColumn1.HeaderText = "Remite"
        Me.OTREMITEDataGridViewTextBoxColumn1.Name = "OTREMITEDataGridViewTextBoxColumn1"
        Me.OTREMITEDataGridViewTextBoxColumn1.Width = 85
        '
        'TMUMUESTRADataGridViewTextBoxColumn1
        '
        Me.TMUMUESTRADataGridViewTextBoxColumn1.DataPropertyName = "TMU_MUESTRA"
        Me.TMUMUESTRADataGridViewTextBoxColumn1.HeaderText = "Tipo"
        Me.TMUMUESTRADataGridViewTextBoxColumn1.Name = "TMUMUESTRADataGridViewTextBoxColumn1"
        Me.TMUMUESTRADataGridViewTextBoxColumn1.Width = 40
        '
        'OTCCANTIDADDataGridViewTextBoxColumn1
        '
        Me.OTCCANTIDADDataGridViewTextBoxColumn1.DataPropertyName = "OTC_CANTIDAD"
        Me.OTCCANTIDADDataGridViewTextBoxColumn1.HeaderText = "Cant."
        Me.OTCCANTIDADDataGridViewTextBoxColumn1.Name = "OTCCANTIDADDataGridViewTextBoxColumn1"
        Me.OTCCANTIDADDataGridViewTextBoxColumn1.Width = 40
        '
        'OTCNLABDESDEDataGridViewTextBoxColumn1
        '
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1.DataPropertyName = "OTC_NLAB_DESDE"
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1.HeaderText = "Desde"
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1.Name = "OTCNLABDESDEDataGridViewTextBoxColumn1"
        Me.OTCNLABDESDEDataGridViewTextBoxColumn1.Width = 60
        '
        'OTESTADOANADataGridViewTextBoxColumn1
        '
        Me.OTESTADOANADataGridViewTextBoxColumn1.DataPropertyName = "OT_ESTADO_ANA"
        Me.OTESTADOANADataGridViewTextBoxColumn1.HeaderText = "Ana"
        Me.OTESTADOANADataGridViewTextBoxColumn1.Name = "OTESTADOANADataGridViewTextBoxColumn1"
        Me.OTESTADOANADataGridViewTextBoxColumn1.Width = 30
        '
        'OTESTADOPAGDataGridViewTextBoxColumn1
        '
        Me.OTESTADOPAGDataGridViewTextBoxColumn1.DataPropertyName = "OT_ESTADO_PAG"
        Me.OTESTADOPAGDataGridViewTextBoxColumn1.HeaderText = "Pag"
        Me.OTESTADOPAGDataGridViewTextBoxColumn1.Name = "OTESTADOPAGDataGridViewTextBoxColumn1"
        Me.OTESTADOPAGDataGridViewTextBoxColumn1.Width = 30
        '
        'OTESTADOFACDataGridViewTextBoxColumn1
        '
        Me.OTESTADOFACDataGridViewTextBoxColumn1.DataPropertyName = "OT_ESTADO_FAC"
        Me.OTESTADOFACDataGridViewTextBoxColumn1.HeaderText = "Fac"
        Me.OTESTADOFACDataGridViewTextBoxColumn1.Name = "OTESTADOFACDataGridViewTextBoxColumn1"
        Me.OTESTADOFACDataGridViewTextBoxColumn1.Width = 30
        '
        'FACNUMERODataGridViewTextBoxColumn1
        '
        Me.FACNUMERODataGridViewTextBoxColumn1.DataPropertyName = "FAC_NUMERO"
        Me.FACNUMERODataGridViewTextBoxColumn1.HeaderText = "Número"
        Me.FACNUMERODataGridViewTextBoxColumn1.Name = "FACNUMERODataGridViewTextBoxColumn1"
        Me.FACNUMERODataGridViewTextBoxColumn1.Width = 50
        '
        'FECHAFACTURADataGridViewTextBoxColumn1
        '
        Me.FECHAFACTURADataGridViewTextBoxColumn1.DataPropertyName = "FECHA_FACTURA"
        Me.FECHAFACTURADataGridViewTextBoxColumn1.HeaderText = "Fecha"
        Me.FECHAFACTURADataGridViewTextBoxColumn1.Name = "FECHAFACTURADataGridViewTextBoxColumn1"
        Me.FECHAFACTURADataGridViewTextBoxColumn1.Width = 65
        '
        'OTESTADOFACTURADataGridViewTextBoxColumn1
        '
        Me.OTESTADOFACTURADataGridViewTextBoxColumn1.DataPropertyName = "OT_ESTADO_FACTURA"
        Me.OTESTADOFACTURADataGridViewTextBoxColumn1.HeaderText = "Est."
        Me.OTESTADOFACTURADataGridViewTextBoxColumn1.Name = "OTESTADOFACTURADataGridViewTextBoxColumn1"
        Me.OTESTADOFACTURADataGridViewTextBoxColumn1.Width = 40
        '
        'F_ModificaOT
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1270, 925)
        Me.Controls.Add(Me.pnl_resultados)
        Me.Controls.Add(Me.Label78)
        Me.Controls.Add(Me.GrpFiltroBusqueda)
        Me.Controls.Add(Me.TxtBusLabHasta)
        Me.Controls.Add(Me.GrbModificacion)
        Me.Controls.Add(Me.Label41)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.BTBusAceptar)
        Me.Controls.Add(Me.TxtBusLabDesde)
        Me.Controls.Add(Me.TxtBusOtHasta)
        Me.Controls.Add(Me.TxtBusFactura)
        Me.Controls.Add(Me.TxtBusFechaDesde)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TxtBusEmpresa)
        Me.Controls.Add(Me.TxtBusOtDesde)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CBBusMuestra)
        Me.Controls.Add(Me.DtpFechaDesde)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtBusRemite)
        Me.Controls.Add(Me.TxtBusProductor)
        Me.Controls.Add(Me.TxtBusRutFact)
        Me.Controls.Add(Me.TxtBusRut)
        Me.Controls.Add(Me.ElPanel1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.MinimizeBox = False
        Me.Name = "F_ModificaOT"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta/Modifica Orden"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrbModificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbModificacion.ResumeLayout(False)
        CType(Me.ElGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElGroupBox1.ResumeLayout(False)
        Me.ElGroupBox1.PerformLayout()
        CType(Me.GrpFiltroBusqueda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpFiltroBusqueda.ResumeLayout(False)
        Me.GrpFiltroBusqueda.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pnl_resultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_resultados.ResumeLayout(False)
        Me.pnl_resultados.PerformLayout()
        CType(Me.ElPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElPanel1.ResumeLayout(False)
        Me.ElPanel1.PerformLayout()
        CType(Me.DGOrdenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub ModificaOrden_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FILA_PASO As DataRow
        Dim MyDate As Date
        Dim fila_p As DataRow
        Dim tempAdapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim query As String
        Dim fila As DataRow
        Dim conexion As New SqlConnection(Conexion1)
        Dim dbman As DbManager
        Call Anti_Elimina_lineas()
        Historico = "N"
        Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Clear()

        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")
        End With

        For Each fila In Cjto_Tablas1.Tables("MUESTRA").Rows
            CBBusMuestra.Items.Add(fila("TMU_MUESTRA"))
        Next

        CBBusRegion.Items.Add("")
        For Each fila In Cjto_Tablas1.Tables("REGION").Rows
            CBBusRegion.Items.Add(fila("REGION"))
        Next

        For Each fila In Cjto_Tablas1.Tables("PROVINCIA").Rows
            CBBusProvincia.Items.Add(fila("PROVINCIA"))
        Next

        For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
            CBBusComuna.Items.Add(fila("COMUNA"))
        Next

        Button3.Visible = False
        BTrevisaResultados.Visible = False
        'CKBAnaxA.Checked = True

        If Tipo_Ingreso_OT = "Consulta" Then
            Me.Text = "Consulta/Modifica OT"
        End If

        If Tipo_Ingreso_OT = "Resultados" Then
            Me.Text = "Emisión de Resultados"
            'CKBAnaxA.Checked = False
            'CKBAnaxDe.Checked = True
            'If ResultadosMuestrayOrden = 1000 Then CBBusMuestra.Text = "FOLIAR" : Muestra = 1000
            'If ResultadosMuestrayOrden = 2000 Then CBBusMuestra.Text = "TEJIDOS" : Muestra = 2000
            'If ResultadosMuestrayOrden = 3000 Then CBBusMuestra.Text = "AGUA" : Muestra = 3000
            'If ResultadosMuestrayOrden = 4000 Or ResultadosMuestrayOrden = 4500 Then CBBusMuestra.Text = "SUELO" : Muestra = 4000
            'If ResultadosMuestrayOrden = 5000 Then CBBusMuestra.Text = "FERTILIZANTES QUIMICOS" : Muestra = 5000
            'If ResultadosMuestrayOrden = 6000 Then CBBusMuestra.Text = "FERTILIZANTES ORGANICOS" : Muestra = 6000
            'If ResultadosMuestrayOrden = 7000 Then CBBusMuestra.Text = "OTROS" : Muestra = 7000
        End If

        If Tipo_Ingreso_OT = "Agrega" Then
            Button3.Visible = False
            BTrevisaResultados.Visible = False
            Me.Text = "Agrega Análisis OT"
        End If

        If Tipo_Ingreso_OT = "Elimina" Then
            Button3.Visible = False
            BTrevisaResultados.Visible = False
            Me.Text = "Elimina Análisis OT"
        End If


        'Call Anti_Elimina_lineas()
        'Historico = "N"

        Dim cd As New CapaDato
        'cd.Inicializar()
        'cd.EjecutarQueryDt("usp_SelectMuestras", Cjto_Tablas1, "MUESTRA")


        'Dim fila As DataRow
        'For Each fila In Cjto_Tablas1.Tables("MUESTRA").Rows
        '    CBBusMuestra.Items.Add(fila("TMU_MUESTRA"))
        'Next

        'Button3.Visible = False
        'BTrevisaResultados.Visible = False

        'If Tipo_Ingreso_OT = "Consulta" Then
        '    Me.Text = "Consulta/Modifica OT"
        'End If

        'If Tipo_Ingreso_OT = "Resultados" Then
        '    Me.Text = "Emisión de Resultados"
        'End If

        'If Tipo_Ingreso_OT = "Agrega" Then
        '    Button3.Visible = False
        '    BTrevisaResultados.Visible = False
        '    Me.Text = "Agrega Análisis OT"
        'End If

        'If Tipo_Ingreso_OT = "Elimina" Then
        '    Button3.Visible = False
        '    BTrevisaResultados.Visible = False
        '    Me.Text = "Elimina Análisis OT"
        'End If
        'Dim con As New SqlConnection(Conexion1)


        Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Clear()
        Cjto_Tablas1.Tables("FACTURA_PASO").Clear()

        With cd
            .Inicializar()
            .EjecutarQueryDt("usp_SelectFacturaPaso", Cjto_Tablas1, "FACTURA_PASO")

            .Inicializar()
            .EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")
        End With



    End Sub

    Private Sub Carga_Analisis(ByVal cod_muestra As Integer, ByVal nombre_tabla As String)
        Dim Fila_Traspaso, Fila_Analisis As DataRow
        Cjto_Tablas1.Tables(nombre_tabla).Clear()
        For Each Fila_Traspaso In Cjto_Tablas1.Tables("ANALISIS").Rows
            If Fila_Traspaso("TMU_CODIGO") = cod_muestra Then
                Fila_Analisis = Cjto_Tablas1.Tables(nombre_tabla).NewRow
                Fila_Analisis.BeginEdit()
                Fila_Analisis.Item("ANA_CODIGO") = Fila_Traspaso.Item("ANA_CODIGO")
                Fila_Analisis.Item("ANA_NETO") = Fila_Traspaso.Item("ANA_NETO")
                Fila_Analisis.Item("ANA_ANALISIS") = Fila_Traspaso.Item("ANA_ANALISIS")
                Fila_Analisis.Item("ANA_NIVEL_PRECIO") = Fila_Traspaso.Item("ANA_NIVEL_PRECIO")
                Fila_Analisis.EndEdit()
                Cjto_Tablas1.Tables(nombre_tabla).Rows.Add(Fila_Analisis)
            End If
        Next
    End Sub

    Private Sub Cambia_Codigos_nlabcod(ByVal codigo As Integer, ByVal NLAB_DESDE As Integer, ByVal NLAB_HASTA As Integer)
        Dim MM, LABN, CAMBIO As Integer
        Dim BUSCACOD(1), buscaana As Object
        Dim FILA_NLABCOD, FILA_ANA As DataRow
        MM = CInt(Mid(CStr(codigo), 1, 1) & "000")
        CAMBIO = 0
        buscaana = codigo
        FILA_ANA = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(buscaana)
        For LABN = NLAB_DESDE To NLAB_HASTA
            BUSCACOD(0) = MM
            BUSCACOD(1) = LABN
            FILA_NLABCOD = Cjto_Tablas1.Tables("TABLA_NLABCOD").Rows.Find(BUSCACOD)

            If IsDBNull(FILA_NLABCOD("ANA_CODIGO1")) = False Then
                If FILA_NLABCOD("ANA_CODIGO1") = codigo_antiguo Then FILA_NLABCOD("ANA_CODIGO1") = codigo : FILA_NLABCOD("ANA_DESCRIPCION1") = FILA_ANA("ANA_ANALISIS") : CAMBIO = 1
            End If

            If IsDBNull(FILA_NLABCOD("ANA_CODIGO2")) = False Then
                If FILA_NLABCOD("ANA_CODIGO2") = codigo_antiguo Then FILA_NLABCOD("ANA_CODIGO2") = codigo : CAMBIO = 1
            End If

            If IsDBNull(FILA_NLABCOD("ANA_CODIGO3")) = False Then
                If FILA_NLABCOD("ANA_CODIGO3") = codigo_antiguo Then FILA_NLABCOD("ANA_CODIGO3") = codigo : CAMBIO = 1
            End If

            'If CAMBIO = 0 Then
            '    If IsDBNull(FILA_NLABCOD("ANA_CODIGO1")) = True Then FILA_NLABCOD("ANA_CODIGO1") = codigo : FILA_NLABCOD("ANA_DESCRIPCION1") = FILA_ANA("ANA_ANALISIS")
            '    If IsDBNull(FILA_NLABCOD("ANA_CODIGO2")) = True Then FILA_NLABCOD("ANA_CODIGO2") = codigo : FILA_NLABCOD("ANA_DESCRIPCION2") = FILA_ANA("ANA_ANALISIS")
            '    If IsDBNull(FILA_NLABCOD("ANA_CODIGO3")) = True Then FILA_NLABCOD("ANA_CODIGO3") = codigo : FILA_NLABCOD("ANA_DESCRIPCION3") = FILA_ANA("ANA_ANALISIS")
            'End If
        Next
    End Sub

    Private Sub DGOrdenes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BTAntPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOrdenTrabajo.Click

        Dim datos As New DataSet
        Dim query As String
        Tipo_Ingreso_OT = "Consulta"
        If Orden_Trabajo_Bus = 0 Then
            MsgBox("Orden : " & Orden_Trabajo_Bus & " no existe")
        Else
            Dim Form_Aux As New F_OrdenTrabajo
            Form_Aux.Owner = Me
            Form_Aux.ShowDialog()
        End If
    End Sub

    Function EstaFacturada() As Boolean
        Dim query, estn As String
        Dim BB As Boolean
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        query = "SELECT FAC_ESTADO FROM FACTURA WHERE FAC_NUMERO=" & Num_Factura
        Dim myCommand7 As New SqlCommand(query, con)
        Dim myReader7 As SqlDataReader
        Try
            myReader7 = myCommand7.ExecuteReader()
            myReader7.Read()
            estn = myReader7.GetString(0)
            If estn = "Nula" Then BB = False Else BB = True
            myReader7.Close()
        Catch ex As Exception
            BB = False
        End Try
        con.Close()
        Return BB

    End Function

    Private Sub BTBusAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBusAceptar.Click


        If CBBusMuestra.Text <> "" Then
            Select Case CBBusMuestra.Text
                Case "FOLIAR"
                    Muestra = 1000
                Case "OTROS TEJIDOS"
                    Muestra = 2000
                Case "AGUA"
                    Muestra = 3000
                Case "SUELO"
                    Muestra = 4000
                Case "FERTILIZANTES QUIMICOS"
                    Muestra = 5000
                Case "FERTILIZANTES ORGANICOS"
                    Muestra = 6000
                Case "FITOPATOLOGICOS"
                    Muestra = 7000
            End Select
        End If
        Call Filtro_Busqueda()

    End Sub
    Private Sub Filtro_Busqueda()
        Dim Fila_Ot, Fila_Codi, Fila_Con, Des_Muestra, Fila_Mue As DataRow
        Dim BuscaMuestra As Object
        Dim DbMan As DbManager
        Dim query, EstFact, Pro_aux As String
        Dim Datos As New DataSet
        Dim con As New SqlConnection(Conexion1)
        Dim NADA, PASO, FECHA_MA, FECHA_CONH, MyPos, NLAB_HASTA, PASOCOD As Integer


        Cjto_Tablas1.Tables("CONSULTA_ORDEN").Clear()
        con.Open()
        For Each Fila_Ot In Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Rows
            PASO = 1
            'If Fila_Ot("OT_NUMERO") = 63535 Then
            '    query = ""
            'End If
            If IsDBNull(Fila_Ot("OT_FECHA_ORDEN")) = False Then
                FECHA_MA = CInt(Mid(CStr(Fila_Ot("OT_FECHA_ORDEN")), 7) & Mid(CStr(Fila_Ot("OT_FECHA_ORDEN")), 4, 2))
            End If

            If TxtBusOtDesde.Text <> "" Then
                If Fila_Ot("OT_NUMERO") >= TxtBusOtDesde.Text And Fila_Ot("OT_NUMERO") <= TxtBusOtHasta.Text Then
                    NADA = 0
                Else
                    PASO = 0
                End If
            End If

            If TxtBusFechaDesde.Text <> "" Then
                If Fila_Ot("OT_FECHA_ORDEN") >= CDate(TxtBusFechaDesde.Text) Then
                    NADA = 0
                Else
                    PASO = 0
                End If

            End If

            If TxtBusProductor.Text <> "" Then
                If IsDBNull(Fila_Ot("PRO_PRODUCTOR")) = False Then MyPos = InStr(UCase(Fila_Ot("PRO_PRODUCTOR")), UCase(TxtBusProductor.Text))
                If MyPos = 0 Then PASO = 0
            End If

            If TxtBusRut.Text <> "" Then
                If IsDBNull(Fila_Ot("PRO_RUT")) = False Then
                    If Fila_Ot("PRO_RUT") <> TxtBusRut.Text Then PASO = 0
                Else
                    PASO = 0
                End If
            End If

            If TxtBusRutFact.Text <> "" Then
                If IsDBNull(Fila_Ot("OT_FAC_RUT")) = False Then
                    If Fila_Ot("OT_FAC_RUT") <> TxtBusRutFact.Text Then PASO = 0
                Else
                    PASO = 0
                End If
            End If

            If TxtBusFactura.Text <> "" Then
                If IsDBNull(Fila_Ot("FAC_NUMERO")) = False Then
                    If Fila_Ot("FAC_NUMERO") <> TxtBusFactura.Text Then PASO = 0
                Else
                    PASO = 0
                End If
            End If

            If TxtBusEmpresa.Text <> "" Then
                If IsDBNull(Fila_Ot("OT_EMPRESA")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_EMPRESA")), UCase(TxtBusEmpresa.Text))
                If MyPos = 0 Then PASO = 0
            End If

            If TxtBusRemite.Text <> "" Then
                If IsDBNull(Fila_Ot("OT_REMITE")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_REMITE")), UCase(TxtBusRemite.Text))
                If MyPos = 0 Then PASO = 0
            End If

            If TxtBusSolicita.Text <> "" Then
                If IsDBNull(Fila_Ot("OT_SOL_NOMBRE")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_SOL_NOMBRE")), UCase(TxtBusSolicita.Text))
                If MyPos = 0 Then PASO = 0
            End If

            If CBBusRegion.Text <> "" Then
                If CBBusRegion.Text <> Fila_Ot("OT_REGION") Then PASO = 0
            End If

            If CBBusProvincia.Text <> "" Then
                If CBBusProvincia.Text <> Fila_Ot("OT_PROVINCIA") Then PASO = 0
            End If

            If CBBusComuna.Text <> "" Then
                If CBBusComuna.Text <> Fila_Ot("OT_COMUNA") Then PASO = 0
            End If

            If CBBusLocalidad.Text <> "" Then
                If CBBusLocalidad.Text <> Fila_Ot("OT_LOCALIDAD") Then PASO = 0
            End If

            If CKBAnaxA.Checked = True Then
                If Fila_Ot("OT_ESTADO_ANA") <> "xA" Then PASO = 0
            End If

            If CKBAnaxDe.Checked = True Then
                If Fila_Ot("OT_ESTADO_ANA") <> "xDe" Then PASO = 0
            End If

            If CKBAnaDex.Checked = True Then
                If Fila_Ot("OT_ESTADO_ANA") <> "Dex" Then PASO = 0
            End If

            If CKBAnaDe.Checked = True Then
                If Fila_Ot("OT_ESTADO_ANA") <> "De" Then PASO = 0
            End If

            If CKBAnaNula.Checked = True Then
                If Fila_Ot("OT_ESTADO_ANA") <> "Nula" Then PASO = 0
            End If


            If CKBPagPte.Checked = True Then
                If Fila_Ot("OT_ESTADO_PAG") <> "Pte" Then PASO = 0
            End If

            If CKBPagAbo.Checked = True Then
                If Fila_Ot("OT_ESTADO_PAG") <> "Abo" Then PASO = 0
            End If

            If CKBPagCan.Checked = True Then
                If Fila_Ot("OT_ESTADO_PAG") <> "Can" Then PASO = 0
            End If

            If CKBPagsc.Checked = True Then
                If Fila_Ot("OT_ESTADO_PAG") <> "s/c" Then PASO = 0
            End If

            If CKBFacxF.Checked = True Then
                If Fila_Ot("OT_ESTADO_FAC") <> "xF" Then PASO = 0
            End If

            If CKBFacFac.Checked = True Then
                If Fila_Ot("OT_ESTADO_FAC") <> "Fac" Then PASO = 0
            End If

            If CKBFacnoF.Checked = True Then
                If Fila_Ot("OT_ESTADO_FAC") <> "noF" Then PASO = 0
            End If

            If CKBFacAgr.Checked = True Then
                If Fila_Ot("OT_ESTADO_FAC") <> "Agr" Then PASO = 0
            End If

            If CKBFacnoR.Checked = True Then
                If Fila_Ot("OT_ESTADO_FAC") <> "noR" Then PASO = 0
            End If
            EstFact = ""
            If IsDBNull(Fila_Ot("FAC_NUMERO")) = False Then
                Call VerEstadoFactura(Fila_Ot("FAC_NUMERO"), PASO, EstFact)
            End If


            If PASO = 1 Then
                query = "SELECT TMU_CODIGO,OTC_NLAB_DESDE,OTC_CANT_MUESTRAS,ANA_CODIGO,OTC_NLAB_HASTA FROM OT_CODIFICACION WHERE OT_NUMERO=" & Fila_Ot("OT_NUMERO")
                Dim mycom As New SqlCommand(query, con)
                Dim myReader4 As SqlDataReader
                myReader4 = mycom.ExecuteReader()
                While myReader4.Read
                    PASOCOD = 1
                    If TxtBusLabDesde.Text <> "" Then
                        If (myReader4.GetInt32(1) >= CInt(TxtBusLabDesde.Text) And myReader4.GetInt32(1) <= CInt(TxtBusLabHasta.Text)) Or _
                           (myReader4.GetInt32(4) >= CInt(TxtBusLabDesde.Text) And myReader4.GetInt32(4) <= CInt(TxtBusLabHasta.Text)) Or _
                           (CInt(TxtBusLabDesde.Text) >= myReader4.GetInt32(1) And CInt(TxtBusLabDesde.Text) <= myReader4.GetInt32(4)) Or _
                           (CInt(TxtBusLabHasta.Text) >= myReader4.GetInt32(1) And CInt(TxtBusLabHasta.Text) <= myReader4.GetInt32(4)) Then
                            NADA = 0
                        Else
                            PASOCOD = 0
                        End If
                    End If

                    If CBBusMuestra.Text <> "" Then
                        If Muestra = 7000 Then
                            If myReader4.GetInt32(0) < 7000 Or myReader4.GetInt32(0) >= 8000 Then PASOCOD = 0
                        Else
                            If myReader4.GetInt32(0) <> Muestra Then PASOCOD = 0
                        End If
                    End If

                    If TxtBusCodigo.Text <> "" Then
                        If myReader4.GetDouble(3) <> TxtBusCodigo.Text Then PASOCOD = 0
                    End If

                    If PASOCOD = 1 Then
                        Fila_Con = Cjto_Tablas1.Tables("CONSULTA_ORDEN").NewRow
                        Fila_Con("OT_NUMERO") = Fila_Ot("OT_NUMERO")
                        Fila_Con("OT_FECHA_ORDEN") = Fila_Ot("OT_FECHA_ORDEN")

                        If Fila_Ot("PRO_PRODUCTOR") <> Pro_aux Then
                            Fila_Con("PRO_PRODUCTOR") = Fila_Ot("PRO_PRODUCTOR")
                        Else
                            Fila_Con("PRO_PRODUCTOR") = ""
                        End If

                        Fila_Con("OT_EMPRESA") = Fila_Ot("OT_EMPRESA")
                        Fila_Con("OT_REMITE") = Fila_Ot("OT_REMITE")
                        Select Case Mid(CStr(myReader4.GetInt32(0)), 1, 1)
                            Case "1"
                                Fila_Con("TMU_MUESTRA") = "FOL"
                            Case "2"
                                Fila_Con("TMU_MUESTRA") = "+TEJ"
                            Case "3"
                                Fila_Con("TMU_MUESTRA") = "AGUA"
                            Case "4"
                                Fila_Con("TMU_MUESTRA") = "SUE"
                            Case "5"
                                Fila_Con("TMU_MUESTRA") = "FQUI"
                            Case "6"
                                Fila_Con("TMU_MUESTRA") = "FORG"
                            Case "7"
                                Fila_Con("TMU_MUESTRA") = "FITO"
                            Case "8"
                                Fila_Con("TMU_MUESTRA") = "OTRO"
                        End Select
                        Fila_Con("OT_ESTADO_ANA") = Fila_Ot("OT_ESTADO_ANA")
                        Fila_Con("OT_ESTADO_PAG") = Fila_Ot("OT_ESTADO_PAG")
                        Fila_Con("OT_ESTADO_FAC") = Fila_Ot("OT_ESTADO_FAC")
                        Fila_Con("OTC_NLAB_DESDE") = myReader4.GetInt32(1)
                        Fila_Con("OTC_CANTIDAD") = myReader4.GetInt32(2)
                        Fila_Con("FAC_NUMERO") = Fila_Ot("FAC_NUMERO")
                        Fila_Con("FECHA_FACTURA") = Fila_Ot("FAC_FECHA")
                        Fila_Con("PRO_RUT") = Fila_Ot("PRO_RUT")
                        Fila_Con("OT_FAC_RUT") = Fila_Ot("OT_FAC_RUT")
                        Fila_Con("OT_ESTADO_FACTURA") = EstFact
                        Try
                            Cjto_Tablas1.Tables("CONSULTA_ORDEN").Rows.Add(Fila_Con)
                        Catch ex As Exception
                        End Try
                        Pro_aux = Fila_Ot("PRO_PRODUCTOR")
                    End If
                End While
                myReader4.Close()
            End If
SaltoXIng:
        Next
        Me.GrpFiltroBusqueda.Visible = False
        con.Close()


    End Sub
    '    Private Sub Filtro_Busqueda()
    '        'Try

    '        Dim Fila_Ot, Fila_Codi, Fila_Con, Des_Muestra, Fila_Mue As DataRow
    '        Dim BuscaMuestra As Object
    '        Dim query, EstFact, Pro_aux As String
    '        Dim Datos As New DataSet
    '        Dim con As New SqlConnection(Conexion1)
    '        Dim NADA, PASO, FECHA_MA, FECHA_CONH, MyPos, NLAB_HASTA, PASOCOD As Integer
    '        'Dim cd As New CapaDato

    '        'Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Clear()

    '        'With cd
    '        '    .Inicializar()
    '        '    .EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")
    '        'End With


    '        Cjto_Tablas1.Tables("CONSULTA_ORDEN").Clear()
    '        con.Open()
    '        For Each Fila_Ot In Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Rows
    '            PASO = 1

    '            If IsDBNull(Fila_Ot("OT_FECHA_ORDEN")) = False Then
    '                FECHA_MA = CInt(Mid(CStr(Fila_Ot("OT_FECHA_ORDEN")), 7) & Mid(CStr(Fila_Ot("OT_FECHA_ORDEN")), 4, 2))
    '            End If

    '            If TxtBusOtDesde.Text <> "" Then
    '                If Fila_Ot("OT_NUMERO") >= TxtBusOtDesde.Text And Fila_Ot("OT_NUMERO") <= TxtBusOtHasta.Text Then
    '                    NADA = 0
    '                Else
    '                    PASO = 0
    '                End If
    '            End If

    '            If TxtBusFechaDesde.Text <> "" Then
    '                If Fila_Ot("OT_FECHA_ORDEN") >= CDate(TxtBusFechaDesde.Text) Then
    '                    NADA = 0
    '                Else
    '                    PASO = 0
    '                End If

    '            End If

    '            If TxtBusProductor.Text <> "" Then
    '                If IsDBNull(Fila_Ot("PRO_PRODUCTOR")) = False Then MyPos = InStr(UCase(Fila_Ot("PRO_PRODUCTOR")), UCase(TxtBusProductor.Text))
    '                If MyPos = 0 Then PASO = 0
    '            End If

    '            If TxtBusRut.Text <> "" Then
    '                If IsDBNull(Fila_Ot("PRO_RUT")) = False Then
    '                    If Fila_Ot("PRO_RUT") <> TxtBusRut.Text Then PASO = 0
    '                Else
    '                    PASO = 0
    '                End If
    '            End If

    '            If TxtBusRutFact.Text <> "" Then
    '                If IsDBNull(Fila_Ot("OT_FAC_RUT")) = False Then
    '                    If Fila_Ot("OT_FAC_RUT") <> TxtBusRutFact.Text Then PASO = 0
    '                Else
    '                    PASO = 0
    '                End If
    '            End If

    '            If TxtBusFactura.Text <> "" Then
    '                If IsDBNull(Fila_Ot("FAC_NUMERO")) = False Then
    '                    If Fila_Ot("FAC_NUMERO") <> TxtBusFactura.Text Then PASO = 0
    '                Else
    '                    PASO = 0
    '                End If
    '            End If

    '            If TxtBusEmpresa.Text <> "" Then
    '                If IsDBNull(Fila_Ot("OT_EMPRESA")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_EMPRESA")), UCase(TxtBusEmpresa.Text))
    '                If MyPos = 0 Then PASO = 0
    '            End If

    '            If TxtBusRemite.Text <> "" Then
    '                If IsDBNull(Fila_Ot("OT_REMITE")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_REMITE")), UCase(TxtBusRemite.Text))
    '                If MyPos = 0 Then PASO = 0
    '            End If

    '            If TxtBusSolicita.Text <> "" Then
    '                If IsDBNull(Fila_Ot("OT_SOL_NOMBRE")) = False Then MyPos = InStr(UCase(Fila_Ot("OT_SOL_NOMBRE")), UCase(TxtBusSolicita.Text))
    '                If MyPos = 0 Then PASO = 0
    '            End If

    '            If CBBusRegion.Text <> "" Then
    '                If CBBusRegion.Text <> Fila_Ot("OT_REGION") Then PASO = 0
    '            End If

    '            If CBBusProvincia.Text <> "" Then
    '                If CBBusProvincia.Text <> Fila_Ot("OT_PROVINCIA") Then PASO = 0
    '            End If

    '            If CBBusComuna.Text <> "" Then
    '                If CBBusComuna.Text <> Fila_Ot("OT_COMUNA") Then PASO = 0
    '            End If

    '            If CBBusLocalidad.Text <> "" Then
    '                If CBBusLocalidad.Text <> Fila_Ot("OT_LOCALIDAD") Then PASO = 0
    '            End If

    '            If CKBAnaxA.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_ANA") <> "xA" Then PASO = 0
    '            End If

    '            If CKBAnaxDe.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_ANA") <> "xDe" Then PASO = 0
    '            End If

    '            If CKBAnaDex.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_ANA") <> "Dex" Then PASO = 0
    '            End If

    '            If CKBAnaDe.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_ANA") <> "De" Then PASO = 0
    '            End If

    '            If CKBAnaNula.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_ANA") <> "Nula" Then PASO = 0
    '            End If


    '            If CKBPagPte.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_PAG") <> "Pte" Then PASO = 0
    '            End If

    '            If CKBPagAbo.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_PAG") <> "Abo" Then PASO = 0
    '            End If

    '            If CKBPagCan.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_PAG") <> "Can" Then PASO = 0
    '            End If

    '            If CKBPagsc.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_PAG") <> "s/c" Then PASO = 0
    '            End If

    '            If CKBFacxF.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_FAC") <> "xF" Then PASO = 0
    '            End If

    '            If CKBFacFac.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_FAC") <> "Fac" Then PASO = 0
    '            End If

    '            If CKBFacnoF.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_FAC") <> "noF" Then PASO = 0
    '            End If

    '            If CKBFacAgr.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_FAC") <> "Agr" Then PASO = 0
    '            End If

    '            If CKBFacnoR.Checked = True Then
    '                If Fila_Ot("OT_ESTADO_FAC") <> "noR" Then PASO = 0
    '            End If

    '            'si es null o vacio me asigna el valor paso=0

    '            EstFact = ""
    '            If IsDBNull(Fila_Ot("FAC_NUMERO")) = False Then Call VerEstadoFactura(Fila_Ot("FAC_NUMERO"), PASO, EstFact)

    '            If PASO = 1 Then
    '                query = "SELECT TMU_CODIGO,OTC_NLAB_DESDE,OTC_CANT_MUESTRAS,ANA_CODIGO,OTC_NLAB_HASTA FROM OT_CODIFICACION WHERE OT_NUMERO=" & Fila_Ot("OT_NUMERO")
    '                Dim mycom As New SqlCommand(query, con)
    '                Dim myReader4 As SqlDataReader
    '                myReader4 = mycom.ExecuteReader()
    '                While myReader4.Read
    '                    PASOCOD = 1
    '                    If TxtBusLabDesde.Text <> "" Then
    '                        If (myReader4.GetInt32(1) >= CInt(TxtBusLabDesde.Text) And myReader4.GetInt32(1) <= CInt(TxtBusLabHasta.Text)) Or _
    '                           (myReader4.GetInt32(4) >= CInt(TxtBusLabDesde.Text) And myReader4.GetInt32(4) <= CInt(TxtBusLabHasta.Text)) Or _
    '                           (CInt(TxtBusLabDesde.Text) >= myReader4.GetInt32(1) And CInt(TxtBusLabDesde.Text) <= myReader4.GetInt32(4)) Or _
    '                           (CInt(TxtBusLabHasta.Text) >= myReader4.GetInt32(1) And CInt(TxtBusLabHasta.Text) <= myReader4.GetInt32(4)) Then
    '                            NADA = 0
    '                        Else
    '                            PASOCOD = 0
    '                        End If
    '                    End If

    '                    If CBBusMuestra.Text <> "" Then
    '                        If Muestra = 7000 Then
    '                            If myReader4.GetInt32(0) < 7000 Or myReader4.GetInt32(0) >= 8000 Then PASOCOD = 0
    '                        Else
    '                            If myReader4.GetInt32(0) <> Muestra Then PASOCOD = 0
    '                        End If
    '                    End If

    '                    If TxtBusCodigo.Text <> "" Then
    '                        If myReader4.GetDouble(3) <> TxtBusCodigo.Text Then PASOCOD = 0
    '                    End If

    '                    If PASOCOD = 1 Then
    '                        Fila_Con = Cjto_Tablas1.Tables("CONSULTA_ORDEN").NewRow
    '                        Fila_Con("OT_NUMERO") = Fila_Ot("OT_NUMERO")
    '                        Fila_Con("OT_FECHA_ORDEN") = Fila_Ot("OT_FECHA_ORDEN")

    '                        If Fila_Ot("PRO_PRODUCTOR") <> Pro_aux Then
    '                            Fila_Con("PRO_PRODUCTOR") = Fila_Ot("PRO_PRODUCTOR")
    '                        Else
    '                            Fila_Con("PRO_PRODUCTOR") = ""
    '                        End If

    '                        Fila_Con("OT_EMPRESA") = Fila_Ot("OT_EMPRESA")
    '                        Fila_Con("OT_REMITE") = Fila_Ot("OT_REMITE")
    '                        Select Case Mid(CStr(myReader4.GetInt32(0)), 1, 1)
    '                            Case "1"
    '                                Fila_Con("TMU_MUESTRA") = "FOL"
    '                            Case "2"
    '                                Fila_Con("TMU_MUESTRA") = "+TEJ"
    '                            Case "3"
    '                                Fila_Con("TMU_MUESTRA") = "AGUA"
    '                            Case "4"
    '                                Fila_Con("TMU_MUESTRA") = "SUE"
    '                            Case "5"
    '                                Fila_Con("TMU_MUESTRA") = "FQUI"
    '                            Case "6"
    '                                Fila_Con("TMU_MUESTRA") = "FORG"
    '                            Case "7"
    '                                Fila_Con("TMU_MUESTRA") = "FITO"
    '                            Case "8"
    '                                Fila_Con("TMU_MUESTRA") = "OTRO"
    '                        End Select
    '                        Fila_Con("OT_ESTADO_ANA") = Fila_Ot("OT_ESTADO_ANA")
    '                        Fila_Con("OT_ESTADO_PAG") = Fila_Ot("OT_ESTADO_PAG")
    '                        Fila_Con("OT_ESTADO_FAC") = Fila_Ot("OT_ESTADO_FAC")
    '                        Fila_Con("OTC_NLAB_DESDE") = myReader4.GetInt32(1)
    '                        Fila_Con("OTC_CANTIDAD") = myReader4.GetInt32(2)
    '                        Fila_Con("FAC_NUMERO") = Fila_Ot("FAC_NUMERO")
    '                        Fila_Con("FECHA_FACTURA") = Fila_Ot("FAC_FECHA")
    '                        Fila_Con("PRO_RUT") = Fila_Ot("PRO_RUT")
    '                        Fila_Con("OT_FAC_RUT") = Fila_Ot("OT_FAC_RUT")
    '                        Fila_Con("OT_ESTADO_FACTURA") = EstFact
    '                        Try
    '                            Cjto_Tablas1.Tables("CONSULTA_ORDEN").Rows.Add(Fila_Con)
    '                        Catch ex As Exception
    '                        End Try
    '                        Pro_aux = Fila_Ot("PRO_PRODUCTOR")
    '                    End If
    '                End While
    '                myReader4.Close()
    '            End If
    'SaltoXIng:
    '        Next
    '        Me.GrpFiltroBusqueda.Visible = False
    '        con.Close()

    '        'Catch ex As Exception

    '        'End Try
    '    End Sub

    Private Sub VerEstadoFactura(ByVal NumFac As String, ByRef PASOO As Integer, ByRef Estfact As String)
        Try
            Dim query As String
            Dim BusFac As Object
            Dim Fila_Fact As DataRow

            BusFac = NumFac
            Fila_Fact = Cjto_Tablas1.Tables("FACTURA_PASO").Rows.Find(BusFac)


            If (Fila_Fact Is Nothing) = False Then
              

                Estfact = Fila_Fact("FAC_ESTADO")

                If CKBEFacPte.Checked = True Then
                    If Fila_Fact("FAC_ESTADO") <> "Pte" Then PASOO = 0
                End If

                If CKBEFacAbo.Checked = True Then
                    If Fila_Fact("FAC_ESTADO") <> "Abo" Then PASOO = 0
                End If

                If CKBEFacCan.Checked = True Then
                    If Fila_Fact("FAC_ESTADO") <> "Can" Then PASOO = 0
                End If

                If CKBEFacNula.Checked = True Then
                    If Fila_Fact("FAC_ESTADO") <> "Nula" Then PASOO = 0
                End If

                If Me.CKBEFaccNC.Checked = True Then
                    If Fila_Fact("FAC_ESTADO") <> "NC" Then PASOO = 0
                End If

            End If
        Catch ex As Exception

        End Try
       
    End Sub


    Private Sub TxtBusEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusEmpresa.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub TxtBusRemite_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRemite.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub TxtBusRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRut.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub



    Private Sub TxtBusLabDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtBusLabHasta.Text = TxtBusLabDesde.Text
            TxtBusLabHasta.Focus()
        End If
    End Sub

    Private Sub TxtBusLabHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusLabHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub TxtBusCodigo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusCodigo.KeyPress
        Dim buscades As Object
        Dim Fila_Ana As DataRow
        If e.KeyChar = Chr(13) Then
            Try
                buscades = TxtBusCodigo.Text
                Fila_Ana = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(buscades)
                If Not (Fila_Ana Is Nothing) Then Me.TxtBusDesCod.Text = Fila_Ana("ANA_ANALISIS")
            Catch ex As Exception
            End Try
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim fila As DataRow
        Dim cd As New CapaDato
        With cd
            .Inicializar()
            .AgregarParametro("@TipoConsulta", 1, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "COMUNA")


            .Inicializar()
            .AgregarParametro("@TipoConsulta", 4, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "PROVINCIA")

            .Inicializar()
            .AgregarParametro("@TipoConsulta", 5, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "REGION")

            .Inicializar()
            .AgregarParametro("@TipoConsulta", 3, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectLocalidad", Cjto_Tablas1, "LOCALIDAD")

        End With
        CBBusRegion.Items.Add("")
        For Each fila In Cjto_Tablas1.Tables("REGION").Rows
            CBBusRegion.Items.Add(fila("REGION"))
        Next

        For Each fila In Cjto_Tablas1.Tables("PROVINCIA").Rows
            CBBusProvincia.Items.Add(fila("PROVINCIA"))
        Next

        For Each fila In Cjto_Tablas1.Tables("COMUNA").Rows
            CBBusComuna.Items.Add(fila("COMUNA"))
        Next

        For Each fila In Cjto_Tablas1.Tables("LOCALIDAD").Rows
            Me.CBBusLocalidad.Items.Add(fila("LOCALIDAD"))
        Next

        Me.GrpFiltroBusqueda.Visible = True
        BTBusAceptar.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.GrpFiltroBusqueda.Visible = False
    End Sub

    Private Sub Anti_Elimina_lineas()
        Me.DGOrdenes.DataSource = Cjto_Tablas1.Tables("CONSULTA_ORDEN")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GrbModificacion.Visible = False
        Me.pnl_resultados.Visible = False
        lbx_lista.Items.Clear()
    End Sub

    Private Sub BTCerrarJocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCerrarJocker.Click
        Me.GrpFiltroBusqueda.Visible = False
        BTBusAceptar.Enabled = True
    End Sub

    Private Sub CBBusRegion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBBusRegion.KeyPress
        'Dim dbman As DbManager
        'Dim query As String
        'Dim fila As DataRow
        'Dim reader As SqlDataReader
        'Dim con As New SqlConnection(Conexion1)
        'If e.KeyChar = Chr(13) Then
        '    query = "Select REG_NOMBRE from REGION where COD_REGION = '" + Me.CBBusRegion.Text + "'"
        '    Dim command As New SqlCommand(query, con)
        '    con.Open()
        '    reader = command.ExecuteReader
        '    While reader.Read
        '        TxtBusDesRegion.Text = reader.GetString(0)
        '    End While
        '    reader.Close()
        '    con.Close()
        '    CBBusProvincia.Focus()
        'End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        '  Dim Form_Aux As New Frm_Modificacion_Estados : Form_Aux.Show()
        '    Form_Aux.Location = New System.Drawing.Point(0, 40)
        '    Form_Aux.Size = New Size(1155, 796)
    End Sub

    Private Sub BTrevisaResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTrevisaResultados.Click
        'Dim Form_Aux As New Frm_Resultados_Anteriores : Form_Aux.Show()
        'Form_Aux.Location = New System.Drawing.Point(0, 40)
        'Form_Aux.Size = New Size(1155, 796)
    End Sub

    Private Sub DTPFechaDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DtpFechaDesde.ValueChanged
        TxtBusFechaDesde.Text = DtpFechaDesde.Text
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TxtBusCodigo.Text = ""
        TxtBusDesCod.Text = ""
        TxtBusDesRegion.Text = ""
        TxtBusEmpresa.Text = ""
        TxtBusFechaDesde.Text = ""
        TxtBusLabDesde.Text = ""
        TxtBusLabHasta.Text = ""
        TxtBusOtDesde.Text = ""
        TxtBusOtHasta.Text = ""
        TxtBusProductor.Text = ""
        TxtBusRemite.Text = ""
        TxtBusRut.Text = ""
        TxtBusRutFact.Text = ""
        TxtBusSolicita.Text = ""
        TxtBusFactura.Text = ""

        CBBusComuna.Text = ""
        CBBusLocalidad.Text = ""
        CBBusMuestra.Text = ""
        CBBusProvincia.Text = ""
        CBBusRegion.Text = ""

        CKBAnaDe.Checked = False
        CKBAnaDex.Checked = False
        CKBAnaNula.Checked = False
        CKBAnaxA.Checked = False
        CKBAnaxDe.Checked = False
        CKBEFacAbo.Checked = False
        CKBEFacCan.Checked = False
        CKBEFaccNC.Checked = False
        CKBEFacNula.Checked = False
        CKBEFacPte.Checked = False
        CKBFacAgr.Checked = False
        CKBFacFac.Checked = False
        CKBFacnoF.Checked = False
        CKBFacnoF.Checked = False
        CKBFacnoR.Checked = False
        CKBFacxF.Checked = False
        CKBPagAbo.Checked = False
        CKBPagCan.Checked = False
        CKBPagPte.Checked = False
        CKBPagsc.Checked = False
    End Sub

    Private Sub CmdAceptarFiltros_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdAceptarFiltros.Click
        Select Case CBBusMuestra.Text
            Case "FOLIAR"
                Muestra = 1000
            Case "OTROS TEJIDOS"
                Muestra = 2000
            Case "AGUA"
                Muestra = 3000
            Case "SUELO"
                Muestra = 4000
        End Select
        BTBusAceptar.Enabled = True
        Call Filtro_Busqueda()
    End Sub

    Private Sub CmdAgregarAnalisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAgregarAnalisis.Click
        Dim datos As New DataSet
        Dim query As String
        Tipo_Ingreso_OT = "Agrega"
        If Orden_Trabajo_Bus = 0 Then
            MsgBox("Orden : " & Orden_Trabajo_Bus & " no existe")
        Else
            Dim Form_Aux As New F_OrdenTrabajo
            Form_Aux.Owner = Me
            Form_Aux.tbOT.SelectedTab = Form_Aux.tbOT.TabPages(1)

            Form_Aux.ShowDialog()
        End If
    End Sub

    Private Sub CmdEliminarAnálisis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEliminarAnálisis.Click

        Try
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim respuesta As MsgBoxResult
            Try
                respuesta = MsgBox("Esta seguro de Eliminar la OT : " & Orden_Trabajo_Bus.ToString, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@NumOt", Orden_Trabajo_Bus, SqlDbType.Int)
                        .EjecutarQuery("usp_EliminaxOrden")
                    End With
                End If
            Catch ex As Exception
                MsgBox("Se debe haber generado la orden antes de  borrarla", MsgBoxStyle.Information)
            End Try
        Catch ex As Exception
            MsgBox("Se ha producido un error al anular la Orden de Trabajo, error: ", ex.Message)
        End Try

    End Sub

    Private Sub CBBusProvincia_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBBusProvincia.KeyPress
        If e.KeyChar = Chr(13) Then
            CBBusComuna.Focus()
        End If
    End Sub

    Private Sub CBBusComuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBBusComuna.KeyPress
        If e.KeyChar = Chr(13) Then
            CBBusLocalidad.Focus()
        End If
    End Sub

    Private Sub CBBusLocalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CBBusLocalidad.KeyPress
        If e.KeyChar = Chr(13) Then
            CmdAceptarFiltros.Focus()
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim cd As New CapaDato
        Cjto_Tablas1.Tables("ORDEN_TRABAJO_PASO").Clear()
        Cjto_Tablas1.Tables("FACTURA_PASO").Clear()

        With cd
            .Inicializar()
            .EjecutarQueryDt("usp_SelectOrdenTrabajoPaso", Cjto_Tablas1, "ORDEN_TRABAJO_PASO")
        End With

        With cd
            .Inicializar()
            .EjecutarQueryDt("usp_SelectFacturaPaso", Cjto_Tablas1, "FACTURA_PASO")
        End With

        'Select Case CBBusMuestra.Text
        '    Case "FOLIAR"
        '        Muestra = 1000
        '    Case "OTROS TEJIDOS"
        '        Muestra = 2000
        '    Case "AGUA"
        '        Muestra = 3000
        '    Case "SUELO"
        '        Muestra = 4000
        'End Select

        Call Filtro_Busqueda()

    End Sub
    Private Sub TxtBusOTtHasta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

            BTBusAceptar.Focus()
        End If
    End Sub
    Private Sub TxtBusOtDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TxtBusOtHasta.Text = TxtBusOtDesde.Text
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub TxtBusFactura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusFactura.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub TxtBusRutFact_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusRutFact.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub
    Sub corrigeMargen(ByVal va1 As String)

        Dim oExcel As Excel.Application
        Dim oBook As Excel.Workbook
        Dim oBooks As Excel.Workbooks
        Dim hoja_excel As Excel.Worksheet

        'Start Excel y abrir el doc
        oExcel = CreateObject("Excel.Application")
        'oExcel.Visible = True
        oBooks = oExcel.Workbooks
        oBook = oBooks.Open(va1)
        hoja_excel = oExcel.Worksheets(1)
        hoja_excel.Activate()
        'Run the macros.

        With oExcel.ActiveSheet.PageSetup

            .LeftMargin = oExcel.Application.InchesToPoints(0.748031496062992)
            .RightMargin = oExcel.Application.InchesToPoints(0)
            .TopMargin = oExcel.Application.InchesToPoints(0)
            .BottomMargin = oExcel.Application.InchesToPoints(0)
            .HeaderMargin = oExcel.Application.InchesToPoints(0)
            .FooterMargin = oExcel.Application.InchesToPoints(0)

        End With
        oExcel.Application.PrintCommunication = True

        oExcel.ActiveWorkbook.Save() 'guarda solamente, no pregunta si desea reemplazar
        oBook.Close(False)
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBook)
        oBook = Nothing
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oBooks)
        oBooks = Nothing
        oExcel.Quit()
        System.Runtime.InteropServices.Marshal.ReleaseComObject(oExcel)
        oExcel = Nothing

    End Sub

    Sub adjuntaPDF()

        Dim nompr, carpr, via, empn, ate, email, email2, sAño As String
        Dim srutadestPDF, porEstado As String
        Dim dsOT, dsAvisafono As New DataSet
        Dim porFono, porEmail As Boolean

        Dim BOLA As Object
        Dim entroNL As Integer
        Dim sRutaDestSuelo2 As String

        Dim num_com, f As Integer
        lbx_lista.Items.Clear()

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
            dsOT = .EjecutarQuery("ls_obtieneOtNumero")
        End With

        Dim sRutaDest, NlabD, NlabH, pro As String
        Dim i, r, tmu, anac As Integer

        r = dsOT.Tables(0).Rows.Count

        While i < 1

            pro = dsOT.Tables(0).Rows.Item(i).Item(0).ToString
            NlabD = dsOT.Tables(0).Rows.Item(i).Item(5).ToString
            NlabH = "-" & Microsoft.VisualBasic.Right(CStr(dsOT.Tables(0).Rows.Item(i).Item(6).ToString), 3)
            sAño = Year(Today)
            tmu = CInt(dsOT.Tables(0).Rows.Item(i).Item(4))
            anac = CInt(dsOT.Tables(0).Rows.Item(i).Item(7))

            If tmu = 1000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"
            ElseIf tmu = 2000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"
            ElseIf tmu = 3000 Then
                If anac > 3600 And anac < 3623 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Bactereologicos-Labsys\"
                Else
                    sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"
                End If
            ElseIf tmu = 4000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"
            ElseIf tmu = 5000 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".FertQuimicos-Labsys\"
            ElseIf tmu = 6000 Then
                If anac > 6800 And anac < 6819 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + " Guanos Bacteriologicos\"
                ElseIf anac = 6001 Then
                    sRutaDest = "F:\Mis Documentos\" + sAño + " Guanos Bacteriologicos\"
                Else
                    sRutaDest = "F:\Mis Documentos\" + sAño + " FertOrganicos-Labsys\"
                End If
            ElseIf tmu = 8700 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"
            ElseIf tmu = 8758 Then
                sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"
            End If



            ' entroNL = 0

            'Try
            Dim arr(), arr2() As String
            Dim Archivo As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
            ' busca "Hola mundo" en un solo nivel ( SearchTopLevelOnly ) en el directorio c:   
            Archivo = My.Computer.FileSystem.GetFiles(sRutaDest)
            ' recorre la lista  
            Dim sum As Integer
            sum = 0
            For Each names As String In Archivo
                arr = Split(names, "\")
                arr2 = Split(arr(3).ToString, "-")
                If arr2.Length = 1 Then
                    arr2 = Split(arr(3).ToString, " ")
                End If

                If NlabD = arr2(0).ToString Then

                    sRutaDest = names
                    'If sRutaDest = sRutaDest2 Then
                    '    MsgBox("ya se ingreso")
                    'End If
                    srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"
                    If File.Exists(srutadestPDF) Then
                        File.Delete(srutadestPDF)
                    End If
                    'sRutaDest2 = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "xls"
                    'guardaRegistro = "nada"
                    If File.Exists(sRutaDest) Then '######### si existe(
                        lbx_lista.Items.Add(sRutaDest)

                    Else '###############################si no existe(
                        sAño = sAño - 1

                        If tmu = 1000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Foliar-Labsys\"
                        ElseIf tmu = 2000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Frutos-Labsys\"
                        ElseIf tmu = 3000 Then
                            If anac > 3600 And anac < 3623 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Bactereologicos-Labsys\"
                            Else
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Agua-Labsys\"
                            End If
                        ElseIf tmu = 4000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Suelo-Labsys\"
                        ElseIf tmu = 5000 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".FertQuimicos-Labsys\"
                        ElseIf tmu = 6000 Then
                            If anac > 6800 And anac < 6819 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Guanos Bacteriologicos\"
                            ElseIf anac = 6001 Then
                                sRutaDest = "F:\Mis Documentos\" + sAño + ".Guanos Bacteriologicos\"
                            Else
                                sRutaDest = "F:\Mis Documentos\" + sAño + " FertOrganicos-Labsys\"
                            End If
                        ElseIf tmu = 8700 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Yemas-Labsys\"
                        ElseIf tmu = 8758 Then
                            sRutaDest = "F:\Mis Documentos\" + sAño + ".Nematodos-Labsys\"
                        End If




                        ' sRutaDest = names
                        srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"

                        sRutaDest = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "xls"
                        If File.Exists(sRutaDest) Then
                            lbx_lista.Items.Add(sRutaDest)

                        End If
                    End If



                End If '######### fin si existe)
            Next

            'srutadestPDF = Mid(sRutaDest, 1, sRutaDest.Length - 3) & "pdf"

            ' Catch ex As Exception

            'End Try




            i = i + 1
        End While
        pnl_resultados.Visible = True


    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try


            Dim mOutLookApp As Outlook.Application
            Dim mNameSpace As Outlook.NameSpace
            Dim mItem As Outlook.MailItem
            Dim colAttach As Outlook.Attachments
            Dim l_Attach As Outlook.Attachment
            Dim srutadestPDF, porEstado, envioM As String
            Dim dsOT, dsAvisafono As New DataSet
            Dim porFono, porEmail As Boolean


            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP
                .Inicializar()

                .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
                dsOT = .EjecutarQuery("ls_obtieneOtNumero")
            End With

            Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
            With SP2
                .Inicializar()

                .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
                dsAvisafono = .EjecutarQuery("ys_obtieneavisafono")
            End With

            porFono = dsAvisafono.Tables(0).Rows.Item(0).Item(0).ToString()
            porEmail = dsAvisafono.Tables(0).Rows.Item(0).Item(1).ToString()
            porEstado = dsAvisafono.Tables(0).Rows.Item(0).Item(2).ToString()
            envioM = "no"
            If porFono = True And porEstado = "Can" Then

                adjuntaPDF()
                envioM = "si"

            ElseIf porEmail = True And envioM = "no" Then

                adjuntaPDF()
                envioM = "si"
            ElseIf porEstado = "Can" And envioM = "no" Then
                adjuntaPDF()
            Else
                MsgBox("Estado: " & porEstado)

            End If



        Catch ex As Exception
            MsgBox("Error :" & ex.Message.ToString, MsgBoxStyle.Information)


        End Try



    End Sub

    Private Sub ConvertirXLSaPDF(ByVal sRutaDest As String, ByVal srutadestPDF As String)

        Dim excelApplication As ApplicationClass = New ApplicationClass()
        Dim excelWorkbook As Workbook = Nothing
        Dim paramSourceBookPath As String = sRutaDest

        Dim paramExportFilePath As String = srutadestPDF
        Dim paramExportFormat As XlFixedFormatType = XlFixedFormatType.xlTypePDF
        Dim paramExportQuality As XlFixedFormatQuality = XlFixedFormatQuality.xlQualityStandard
        Dim paramOpenAfterPublish As Boolean = False
        Dim paramIncludeDocProps As Boolean = True
        Dim paramIgnorePrintAreas As Boolean = False
        Dim paramFromPage As Object = Type.Missing
        Dim paramToPage As Object = Type.Missing

        Try
            ' Open the source workbook.
            excelWorkbook = excelApplication.Workbooks.Open(paramSourceBookPath)

            ' Save it in the target format.
            If Not excelWorkbook Is Nothing Then
                excelWorkbook.ExportAsFixedFormat(paramExportFormat, _
                    paramExportFilePath, paramExportQuality, _
                    paramIncludeDocProps, paramIgnorePrintAreas, _
                    paramFromPage, paramToPage, paramOpenAfterPublish)
            End If
        Catch ex As Exception
            ' Respond to the error.
        Finally
            ' Close the workbook object.
            If Not excelWorkbook Is Nothing Then
                excelWorkbook.Close(False)
                excelWorkbook = Nothing
            End If

            ' Quit Excel and release the ApplicationClass object.
            If Not excelApplication Is Nothing Then
                excelApplication.Quit()
                excelApplication = Nothing
            End If

            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            GC.WaitForPendingFinalizers()
        End Try

    End Sub



    Private Sub ElPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub TxtBusProductor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusProductor.KeyPress
        If e.KeyChar = Chr(13) Then
            BTBusAceptar.Focus()
        End If
    End Sub


    Private Sub TxtBusOtDesde_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusOtDesde.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtBusOtHasta.Text = TxtBusOtDesde.Text
            TxtBusOtHasta.Focus()
        End If
    End Sub

    Private Sub TxtBusOtHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBusOtHasta.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BTBusAceptar.Focus()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        pnl_resultados.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim dsOT As New DataSet
        Dim num_com, f As Integer
        Dim va1 As String

        Dim nompr, carpr, via, empn, ate, email, email2, sAño, archivoPDF As String

        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        With SP
            .Inicializar()

            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
            dsOT = .EjecutarQuery("ls_obtieneOtNumero")
        End With

        nompr = dsOT.Tables(0).Rows.Item(0).Item(0).ToString
        ate = dsOT.Tables(0).Rows.Item(0).Item(1).ToString
        Call control_nombre(ate)
        If ate <> "" Then ate = "Atención: " & ate & Chr(13) Else ate = ""
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        email = dsOT.Tables(0).Rows.Item(0).Item(2).ToString
        email2 = dsOT.Tables(0).Rows.Item(0).Item(3).ToString
        mOutLookApp = New Outlook.Application
        mNameSpace = mOutLookApp.GetNamespace("MAPI")
        mItem = mOutLookApp.CreateItem(0)
        mItem.To = email
        mItem.CC = email2
        mItem.Subject = "Resultado Análisis Agrolab Ltda."
        mItem.Body = "Señor(es): " & Chr(13) & _
                     nompr & Chr(13) & _
                     ate & Chr(13) & _
                     "Adjunto resultado de análisis solicitado." & Chr(13) & _
                     "Atentamente," & Chr(13) & Chr(13) & _
                     "Agrolab Ltda." & Chr(13) & Chr(13) & _
                     "Fono   : (02) 225 8087" & Chr(13) & _
                     "e-mail : secreagro@agrolab.cl" & Chr(13) & _
                     "Web    : www.agrolab.cl" & Chr(13) & Chr(13)

        colAttach = mItem.Attachments


        For Each item As Object In lbx_lista.SelectedItems
            If MsgBox("Desea adjuntar el resultado en PDF", MsgBoxStyle.YesNo, "Adjuntando...") = MsgBoxResult.Yes Then



                va1 = item
                corrigeMargen(va1)
                archivoPDF = Mid(va1, 1, va1.Length - 3) & "pdf"

                If File.Exists(archivoPDF) Then
                    File.Delete(archivoPDF)
                End If

                ConvertirXLSaPDF(va1, archivoPDF)

                If File.Exists(archivoPDF) Then
                    l_Attach = colAttach.Add(archivoPDF)
                End If

            Else

                va1 = item
                va1 = Mid(va1, 1, va1.Length - 3) & "xls"
                l_Attach = colAttach.Add(va1)

            End If

        Next
        mItem.Display()

        With SP

            .Inicializar()
            .AgregarParametro("@ot", Me.txOTSeleccionada.Text, SqlDbType.Int)
            .EjecutarQuery("ls_actualizaEstadoOtDesp")

        End With



    End Sub



    Private Sub DGOrdenes_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGOrdenes.CellDoubleClick
        Dim numFila, NumOOt As Integer
        Dim DbMan As DbManager
        Dim query As String
        Try
            Me.Button6.Visible = True
            numFila = Me.DGOrdenes.CurrentCell.RowIndex
            Orden_Trabajo_Bus = Me.DGOrdenes.Rows(numFila).Cells(0).Value
            Orden_Trabajo = Orden_Trabajo_Bus
            Me.txOTSeleccionada.Text = Orden_Trabajo
            If Tipo_Ingreso_OT = "Resultados" Then
                ResultadosMuestrayOrden = Orden_Trabajo_Bus
                ResultadosCantidad = Me.DGOrdenes.Rows(numFila).Cells(8).Value
                ResultadosNLab = Me.DGOrdenes.Rows(numFila).Cells(9).Value
                Me.Close()
            End If
            If Es_Revision = "S" Then
                'Dim Form_Aux As New Frm_Resultados_Anteriores : Form_Aux.Show()
                GoTo SaltoxRevision
            End If
            Select Case Me.DGOrdenes.Rows(numFila).Cells(7).Value
                Case "FOL"
                    CodMuestraRev = 1000
                Case "+TEJ"
                    CodMuestraRev = 2000
                Case "AGU"
                    CodMuestraRev = 3000
                Case "SUE"
                    CodMuestraRev = 4000
                Case "FORG"
                    CodMuestraRev = 5000
                Case "FQUI"
                    CodMuestraRev = 6000
                Case "VEN"
                    CodMuestraRev = 7000
                Case "OTRO"
                    CodMuestraRev = 8000
            End Select
            Ant_NLabDesde = Me.DGOrdenes.Rows(numFila).Cells(9).Value
            Ant_NLabHasta = Me.DGOrdenes.Rows(numFila).Cells(9).Value + Me.DGOrdenes.Rows(numFila).Cells(8).Value - 1
            Num_Factura = Me.DGOrdenes.Rows(numFila).Cells(13).Value
            Select Case Me.DGOrdenes.Rows(numFila).Cells(7).Value
                Case "FOL"
                    Muestra = 1000
                    Cjto_Orden1.Tables("OT_FOLIAR_ANTECEDENTES").Clear()
                    DbMan = New DbManager("OT_FOLIAR_ANTECEDENTES", Conexion1)
                    query = "Select * from OT_FOLIAR_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
                    DbMan.Selecccionar(Cjto_Orden1, query)
                Case "+TEJ"
                    Muestra = 2000
                    Cjto_Orden1.Tables("OT_TEJIDOS_ANTECEDENTES").Clear()
                    DbMan = New DbManager("OT_TEJIDOS_ANTECEDENTES", Conexion1)
                    query = "Select * from OT_TEJIDOS_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
                    DbMan.Selecccionar(Cjto_Orden1, query)
                Case "AGUA"
                    Muestra = 3000
                    Cjto_Orden1.Tables("OT_AGUA_ANTECEDENTES").Clear()
                    DbMan = New DbManager("OT_AGUA_ANTECEDENTES", Conexion1)
                    query = "Select * from OT_AGUA_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
                    DbMan.Selecccionar(Cjto_Orden1, query)
                Case "SUE"
                    Muestra = 4000
                    Cjto_Orden1.Tables("OT_SUELO_ANTECEDENTES").Clear()
                    DbMan = New DbManager("OT_SUELO_ANTECEDENTES", Conexion1)
                    query = "Select * from OT_SUELO_ANTECEDENTES where OT_NUMERO =" & Orden_Trabajo_Bus
                    DbMan.Selecccionar(Cjto_Orden1, query)
            End Select
        Catch ex As Exception
        End Try




        GrbModificacion.Visible = True
        GrbModificacion.Location = New System.Drawing.Point(0, 738)
        GrbModificacion.BringToFront()

SaltoxRevision:

    End Sub


End Class

