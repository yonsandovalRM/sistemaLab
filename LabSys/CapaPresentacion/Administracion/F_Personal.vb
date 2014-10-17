Imports System.Data.SqlClient
Public Class Frm_Personal
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtRut As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DTGElementosAna As System.Windows.Forms.DataGrid
    Friend WithEvents DTGElementos As System.Windows.Forms.DataGrid
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtFono As System.Windows.Forms.TextBox
    Friend WithEvents TxtCelular As System.Windows.Forms.TextBox
    Friend WithEvents DTPFechaContrato As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPFechaFiniquito As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents TxtCargo As System.Windows.Forms.TextBox
    Friend WithEvents CHKCotizador As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents DTPFechaNacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtViaFoto As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents BTEliminarEle As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents DTGPersonal As System.Windows.Forms.DataGrid
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtImpresoraPunto As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TxtImpresoraLaser As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents CHKDespacho As System.Windows.Forms.CheckBox
    Friend WithEvents CHKResultados As System.Windows.Forms.CheckBox
    Friend WithEvents CHKRevision As System.Windows.Forms.CheckBox
    Friend WithEvents CHKDigitacion As System.Windows.Forms.CheckBox
    Friend WithEvents CHKPlanificacion As System.Windows.Forms.CheckBox
    Friend WithEvents CHKIngresoOT As System.Windows.Forms.CheckBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents CHKAdministracion As System.Windows.Forms.CheckBox
    Friend WithEvents CHKConsultaMod As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents CHKCobranza As System.Windows.Forms.CheckBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents chDYemas As System.Windows.Forms.CheckBox
    Friend WithEvents chDCodPlan As System.Windows.Forms.CheckBox
    Friend WithEvents chDKitOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chDFertOrg As System.Windows.Forms.CheckBox
    Friend WithEvents chDFertQui As System.Windows.Forms.CheckBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents chDSuelo As System.Windows.Forms.CheckBox
    Friend WithEvents chDAgua As System.Windows.Forms.CheckBox
    Friend WithEvents chDTejido As System.Windows.Forms.CheckBox
    Friend WithEvents chDFoliar As System.Windows.Forms.CheckBox
    Friend WithEvents chDYMantencion As System.Windows.Forms.CheckBox
    Friend WithEvents chDYTraspaso As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents chRSuelo As System.Windows.Forms.CheckBox
    Friend WithEvents chRagua As System.Windows.Forms.CheckBox
    Friend WithEvents chRTejido As System.Windows.Forms.CheckBox
    Friend WithEvents chRFoliar As System.Windows.Forms.CheckBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents chRListInscrip As System.Windows.Forms.CheckBox
    Friend WithEvents chRKitOtros As System.Windows.Forms.CheckBox
    Friend WithEvents chRFertOrg As System.Windows.Forms.CheckBox
    Friend WithEvents chRFertQui As System.Windows.Forms.CheckBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents chEmYemas As System.Windows.Forms.CheckBox
    Friend WithEvents chEmResultados As System.Windows.Forms.CheckBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents chHorizFoliar As System.Windows.Forms.CheckBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents chLibroVentas As System.Windows.Forms.CheckBox
    Friend WithEvents chCancelFacturas As System.Windows.Forms.CheckBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents chCartaDespacho As System.Windows.Forms.CheckBox
    Friend WithEvents chDespacho As System.Windows.Forms.CheckBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents chEliminaOT As System.Windows.Forms.CheckBox
    Friend WithEvents chTHistorico As System.Windows.Forms.CheckBox
    Friend WithEvents chEstados As System.Windows.Forms.CheckBox
    Friend WithEvents chTablas As System.Windows.Forms.CheckBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents chCentroCosto As System.Windows.Forms.CheckBox
    Friend WithEvents chListados As System.Windows.Forms.CheckBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents PanelTablas As System.Windows.Forms.Panel
    Friend WithEvents chEspecieVariedad As System.Windows.Forms.CheckBox
    Friend WithEvents chMuestreadores As System.Windows.Forms.CheckBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents chRangos As System.Windows.Forms.CheckBox
    Friend WithEvents chProductor As System.Windows.Forms.CheckBox
    Friend WithEvents chElemento As System.Windows.Forms.CheckBox
    Friend WithEvents chLocalidad As System.Windows.Forms.CheckBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents chCondPago As System.Windows.Forms.CheckBox
    Friend WithEvents chTejido As System.Windows.Forms.CheckBox
    Friend WithEvents chPersonal As System.Windows.Forms.CheckBox
    Friend WithEvents chRelOTFact As System.Windows.Forms.CheckBox
    Friend WithEvents chCodElem As System.Windows.Forms.CheckBox
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents btnAceptaTablas As System.Windows.Forms.Button
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents chTipoMasc As System.Windows.Forms.CheckBox
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents chSalinidad As System.Windows.Forms.CheckBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents chFertilidad As System.Windows.Forms.CheckBox
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents chATdbf As System.Windows.Forms.CheckBox
    Friend WithEvents chEFactura As System.Windows.Forms.CheckBox
    Friend WithEvents chENlab As System.Windows.Forms.CheckBox
    Friend WithEvents chEOT As System.Windows.Forms.CheckBox
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents chEElementos As System.Windows.Forms.CheckBox
    Friend WithEvents chERangoOT As System.Windows.Forms.CheckBox
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents chGeneraXml As System.Windows.Forms.CheckBox
    Friend WithEvents cbCobranzaMod As System.Windows.Forms.CheckBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents CHKConsultaOTHistorico As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtRut = New System.Windows.Forms.TextBox
        Me.TxtApellido = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtNombre = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtFono = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtCelular = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DTPFechaContrato = New System.Windows.Forms.DateTimePicker
        Me.DTPFechaFiniquito = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.DTGPersonal = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtNombreUsuario = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.TxtImpresoraLaser = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtImpresoraPunto = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.DTPFechaNacimiento = New System.Windows.Forms.DateTimePicker
        Me.TxtClave = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtCargo = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cbCobranzaMod = New System.Windows.Forms.CheckBox
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.chGeneraXml = New System.Windows.Forms.CheckBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.chATdbf = New System.Windows.Forms.CheckBox
        Me.chEFactura = New System.Windows.Forms.CheckBox
        Me.chENlab = New System.Windows.Forms.CheckBox
        Me.chEOT = New System.Windows.Forms.CheckBox
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.chEElementos = New System.Windows.Forms.CheckBox
        Me.chERangoOT = New System.Windows.Forms.CheckBox
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.chSalinidad = New System.Windows.Forms.CheckBox
        Me.Label81 = New System.Windows.Forms.Label
        Me.chFertilidad = New System.Windows.Forms.CheckBox
        Me.Label80 = New System.Windows.Forms.Label
        Me.PanelTablas = New System.Windows.Forms.Panel
        Me.chTipoMasc = New System.Windows.Forms.CheckBox
        Me.Label79 = New System.Windows.Forms.Label
        Me.btnAceptaTablas = New System.Windows.Forms.Button
        Me.Label78 = New System.Windows.Forms.Label
        Me.chEspecieVariedad = New System.Windows.Forms.CheckBox
        Me.chMuestreadores = New System.Windows.Forms.CheckBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.chRangos = New System.Windows.Forms.CheckBox
        Me.chProductor = New System.Windows.Forms.CheckBox
        Me.chElemento = New System.Windows.Forms.CheckBox
        Me.chLocalidad = New System.Windows.Forms.CheckBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.chCondPago = New System.Windows.Forms.CheckBox
        Me.chTejido = New System.Windows.Forms.CheckBox
        Me.chPersonal = New System.Windows.Forms.CheckBox
        Me.chRelOTFact = New System.Windows.Forms.CheckBox
        Me.chCodElem = New System.Windows.Forms.CheckBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.chEliminaOT = New System.Windows.Forms.CheckBox
        Me.chTHistorico = New System.Windows.Forms.CheckBox
        Me.chEstados = New System.Windows.Forms.CheckBox
        Me.chTablas = New System.Windows.Forms.CheckBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.chCentroCosto = New System.Windows.Forms.CheckBox
        Me.chListados = New System.Windows.Forms.CheckBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.chLibroVentas = New System.Windows.Forms.CheckBox
        Me.chCancelFacturas = New System.Windows.Forms.CheckBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.chCartaDespacho = New System.Windows.Forms.CheckBox
        Me.chDespacho = New System.Windows.Forms.CheckBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.chEmYemas = New System.Windows.Forms.CheckBox
        Me.chEmResultados = New System.Windows.Forms.CheckBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.chHorizFoliar = New System.Windows.Forms.CheckBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.chRSuelo = New System.Windows.Forms.CheckBox
        Me.chRagua = New System.Windows.Forms.CheckBox
        Me.chRTejido = New System.Windows.Forms.CheckBox
        Me.chRFoliar = New System.Windows.Forms.CheckBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.chRListInscrip = New System.Windows.Forms.CheckBox
        Me.chRKitOtros = New System.Windows.Forms.CheckBox
        Me.chRFertOrg = New System.Windows.Forms.CheckBox
        Me.chRFertQui = New System.Windows.Forms.CheckBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Label51 = New System.Windows.Forms.Label
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.chDYMantencion = New System.Windows.Forms.CheckBox
        Me.chDYTraspaso = New System.Windows.Forms.CheckBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.chDSuelo = New System.Windows.Forms.CheckBox
        Me.chDAgua = New System.Windows.Forms.CheckBox
        Me.chDTejido = New System.Windows.Forms.CheckBox
        Me.chDFoliar = New System.Windows.Forms.CheckBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.chDYemas = New System.Windows.Forms.CheckBox
        Me.chDCodPlan = New System.Windows.Forms.CheckBox
        Me.chDKitOtros = New System.Windows.Forms.CheckBox
        Me.chDFertOrg = New System.Windows.Forms.CheckBox
        Me.chDFertQui = New System.Windows.Forms.CheckBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.CHKConsultaOTHistorico = New System.Windows.Forms.CheckBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.CHKCobranza = New System.Windows.Forms.CheckBox
        Me.CHKAdministracion = New System.Windows.Forms.CheckBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.CHKDespacho = New System.Windows.Forms.CheckBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CHKResultados = New System.Windows.Forms.CheckBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.CHKRevision = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.CHKDigitacion = New System.Windows.Forms.CheckBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.CHKPlanificacion = New System.Windows.Forms.CheckBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.CHKConsultaMod = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.CHKIngresoOT = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.CHKCotizador = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BTEliminarEle = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.DTGElementosAna = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DTGElementos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.TxtViaFoto = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DTGPersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.PanelTablas.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DTGElementosAna, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTGElementos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rut :"
        '
        'TxtRut
        '
        Me.TxtRut.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRut.Location = New System.Drawing.Point(136, 80)
        Me.TxtRut.Name = "TxtRut"
        Me.TxtRut.Size = New System.Drawing.Size(100, 21)
        Me.TxtRut.TabIndex = 1
        '
        'TxtApellido
        '
        Me.TxtApellido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellido.Location = New System.Drawing.Point(136, 143)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(176, 21)
        Me.TxtApellido.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(136, 111)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(176, 21)
        Me.TxtNombre.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(16, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nombre :"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(136, 208)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(176, 21)
        Me.TxtDireccion.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(16, 211)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Dirección :"
        '
        'TxtFono
        '
        Me.TxtFono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFono.Location = New System.Drawing.Point(136, 240)
        Me.TxtFono.Name = "TxtFono"
        Me.TxtFono.Size = New System.Drawing.Size(120, 21)
        Me.TxtFono.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fono :"
        '
        'TxtCelular
        '
        Me.TxtCelular.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCelular.Location = New System.Drawing.Point(136, 272)
        Me.TxtCelular.Name = "TxtCelular"
        Me.TxtCelular.Size = New System.Drawing.Size(120, 21)
        Me.TxtCelular.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Celular :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 307)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Cargo :"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(16, 341)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha Contrato :"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(16, 373)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Fecha Finiquito :"
        Me.Label10.Visible = False
        '
        'DTPFechaContrato
        '
        Me.DTPFechaContrato.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaContrato.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaContrato.Location = New System.Drawing.Point(136, 336)
        Me.DTPFechaContrato.Name = "DTPFechaContrato"
        Me.DTPFechaContrato.Size = New System.Drawing.Size(112, 21)
        Me.DTPFechaContrato.TabIndex = 19
        '
        'DTPFechaFiniquito
        '
        Me.DTPFechaFiniquito.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaFiniquito.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaFiniquito.Location = New System.Drawing.Point(136, 368)
        Me.DTPFechaFiniquito.Name = "DTPFechaFiniquito"
        Me.DTPFechaFiniquito.Size = New System.Drawing.Size(112, 21)
        Me.DTPFechaFiniquito.TabIndex = 20
        Me.DTPFechaFiniquito.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.TxtNombreUsuario)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.Label30)
        Me.GroupBox1.Controls.Add(Me.TxtImpresoraLaser)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TxtImpresoraPunto)
        Me.GroupBox1.Controls.Add(Me.Label26)
        Me.GroupBox1.Controls.Add(Me.DTPFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.TxtClave)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtCargo)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TxtRut)
        Me.GroupBox1.Controls.Add(Me.DTPFechaFiniquito)
        Me.GroupBox1.Controls.Add(Me.TxtApellido)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.DTPFechaContrato)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNombre)
        Me.GroupBox1.Controls.Add(Me.TxtCelular)
        Me.GroupBox1.Controls.Add(Me.TxtDireccion)
        Me.GroupBox1.Controls.Add(Me.TxtFono)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 618)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox5.Controls.Add(Me.DTGPersonal)
        Me.GroupBox5.Controls.Add(Me.Button5)
        Me.GroupBox5.Controls.Add(Me.Label28)
        Me.GroupBox5.Location = New System.Drawing.Point(11, 203)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(418, 384)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Visible = False
        '
        'DTGPersonal
        '
        Me.DTGPersonal.CaptionFont = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGPersonal.CaptionVisible = False
        Me.DTGPersonal.DataMember = ""
        Me.DTGPersonal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTGPersonal.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGPersonal.Location = New System.Drawing.Point(8, 32)
        Me.DTGPersonal.Name = "DTGPersonal"
        Me.DTGPersonal.Size = New System.Drawing.Size(404, 336)
        Me.DTGPersonal.TabIndex = 0
        Me.DTGPersonal.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DTGPersonal
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "PERSONAL"
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Usuario"
        Me.DataGridTextBoxColumn17.MappingName = "PER_NOMUSU"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Rut"
        Me.DataGridTextBoxColumn7.MappingName = "PER_RUT"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Apellido/Nombre"
        Me.DataGridTextBoxColumn8.MappingName = "PER_APENOM"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 140
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "F.Nacimiento"
        Me.DataGridTextBoxColumn9.MappingName = "PER_FNACTO"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Dirección"
        Me.DataGridTextBoxColumn10.MappingName = "PER_DIRECCION"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 130
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Fono"
        Me.DataGridTextBoxColumn11.MappingName = "PER_FONO"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 70
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Celular"
        Me.DataGridTextBoxColumn12.MappingName = "PER_CELULAR"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 70
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Cargo"
        Me.DataGridTextBoxColumn13.MappingName = "PER_CARGO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "F.Contrato"
        Me.DataGridTextBoxColumn14.MappingName = "PER_FCONTRATO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "F.Finiquito"
        Me.DataGridTextBoxColumn15.MappingName = "PER_FFINIQUITO"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Clave"
        Me.DataGridTextBoxColumn16.MappingName = "PER_CLAVE"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(393, 1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(24, 17)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Window
        Me.Label28.Location = New System.Drawing.Point(2, 1)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(415, 16)
        Me.Label28.TabIndex = 1
        Me.Label28.Text = "Personal"
        '
        'TxtNombreUsuario
        '
        Me.TxtNombreUsuario.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreUsuario.Location = New System.Drawing.Point(136, 48)
        Me.TxtNombreUsuario.Name = "TxtNombreUsuario"
        Me.TxtNombreUsuario.Size = New System.Drawing.Size(176, 21)
        Me.TxtNombreUsuario.TabIndex = 35
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(16, 51)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(114, 13)
        Me.Label31.TabIndex = 34
        Me.Label31.Text = "Nombre Usuario :"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(16, 467)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(114, 16)
        Me.Label30.TabIndex = 32
        Me.Label30.Text = "Impresora Laser :"
        '
        'TxtImpresoraLaser
        '
        Me.TxtImpresoraLaser.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpresoraLaser.Location = New System.Drawing.Point(136, 464)
        Me.TxtImpresoraLaser.Name = "TxtImpresoraLaser"
        Me.TxtImpresoraLaser.Size = New System.Drawing.Size(272, 21)
        Me.TxtImpresoraLaser.TabIndex = 33
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(16, 435)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(114, 16)
        Me.Label29.TabIndex = 30
        Me.Label29.Text = "Impresora Punto :"
        '
        'TxtImpresoraPunto
        '
        Me.TxtImpresoraPunto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtImpresoraPunto.Location = New System.Drawing.Point(136, 432)
        Me.TxtImpresoraPunto.Name = "TxtImpresoraPunto"
        Me.TxtImpresoraPunto.Size = New System.Drawing.Size(272, 21)
        Me.TxtImpresoraPunto.TabIndex = 31
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(16, 181)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(114, 16)
        Me.Label26.TabIndex = 28
        Me.Label26.Text = "Fecha Nacimiento :"
        '
        'DTPFechaNacimiento
        '
        Me.DTPFechaNacimiento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaNacimiento.Location = New System.Drawing.Point(136, 176)
        Me.DTPFechaNacimiento.Name = "DTPFechaNacimiento"
        Me.DTPFechaNacimiento.Size = New System.Drawing.Size(112, 21)
        Me.DTPFechaNacimiento.TabIndex = 29
        '
        'TxtClave
        '
        Me.TxtClave.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtClave.Location = New System.Drawing.Point(136, 400)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.Size = New System.Drawing.Size(120, 21)
        Me.TxtClave.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 403)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Clave Usuario :"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Datos Personales"
        '
        'TxtCargo
        '
        Me.TxtCargo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCargo.Location = New System.Drawing.Point(136, 304)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(120, 21)
        Me.TxtCargo.TabIndex = 24
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button1.Location = New System.Drawing.Point(313, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 23
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbCobranzaMod)
        Me.GroupBox2.Controls.Add(Me.Label89)
        Me.GroupBox2.Controls.Add(Me.Label88)
        Me.GroupBox2.Controls.Add(Me.chGeneraXml)
        Me.GroupBox2.Controls.Add(Me.Label87)
        Me.GroupBox2.Controls.Add(Me.chATdbf)
        Me.GroupBox2.Controls.Add(Me.chEFactura)
        Me.GroupBox2.Controls.Add(Me.chENlab)
        Me.GroupBox2.Controls.Add(Me.chEOT)
        Me.GroupBox2.Controls.Add(Me.Label82)
        Me.GroupBox2.Controls.Add(Me.Label83)
        Me.GroupBox2.Controls.Add(Me.chEElementos)
        Me.GroupBox2.Controls.Add(Me.chERangoOT)
        Me.GroupBox2.Controls.Add(Me.Label84)
        Me.GroupBox2.Controls.Add(Me.Label85)
        Me.GroupBox2.Controls.Add(Me.Label86)
        Me.GroupBox2.Controls.Add(Me.chSalinidad)
        Me.GroupBox2.Controls.Add(Me.Label81)
        Me.GroupBox2.Controls.Add(Me.chFertilidad)
        Me.GroupBox2.Controls.Add(Me.Label80)
        Me.GroupBox2.Controls.Add(Me.PanelTablas)
        Me.GroupBox2.Controls.Add(Me.chEliminaOT)
        Me.GroupBox2.Controls.Add(Me.chTHistorico)
        Me.GroupBox2.Controls.Add(Me.chEstados)
        Me.GroupBox2.Controls.Add(Me.chTablas)
        Me.GroupBox2.Controls.Add(Me.Label63)
        Me.GroupBox2.Controls.Add(Me.Label64)
        Me.GroupBox2.Controls.Add(Me.chCentroCosto)
        Me.GroupBox2.Controls.Add(Me.chListados)
        Me.GroupBox2.Controls.Add(Me.Label65)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.chLibroVentas)
        Me.GroupBox2.Controls.Add(Me.chCancelFacturas)
        Me.GroupBox2.Controls.Add(Me.Label59)
        Me.GroupBox2.Controls.Add(Me.Label60)
        Me.GroupBox2.Controls.Add(Me.chCartaDespacho)
        Me.GroupBox2.Controls.Add(Me.chDespacho)
        Me.GroupBox2.Controls.Add(Me.Label57)
        Me.GroupBox2.Controls.Add(Me.Label58)
        Me.GroupBox2.Controls.Add(Me.chEmYemas)
        Me.GroupBox2.Controls.Add(Me.chEmResultados)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.chHorizFoliar)
        Me.GroupBox2.Controls.Add(Me.Label55)
        Me.GroupBox2.Controls.Add(Me.Label56)
        Me.GroupBox2.Controls.Add(Me.chRSuelo)
        Me.GroupBox2.Controls.Add(Me.chRagua)
        Me.GroupBox2.Controls.Add(Me.chRTejido)
        Me.GroupBox2.Controls.Add(Me.chRFoliar)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.Label47)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Controls.Add(Me.chRListInscrip)
        Me.GroupBox2.Controls.Add(Me.chRKitOtros)
        Me.GroupBox2.Controls.Add(Me.chRFertOrg)
        Me.GroupBox2.Controls.Add(Me.chRFertQui)
        Me.GroupBox2.Controls.Add(Me.Label50)
        Me.GroupBox2.Controls.Add(Me.Label51)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.chDYMantencion)
        Me.GroupBox2.Controls.Add(Me.chDYTraspaso)
        Me.GroupBox2.Controls.Add(Me.Label45)
        Me.GroupBox2.Controls.Add(Me.chDSuelo)
        Me.GroupBox2.Controls.Add(Me.chDAgua)
        Me.GroupBox2.Controls.Add(Me.chDTejido)
        Me.GroupBox2.Controls.Add(Me.chDFoliar)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.Label43)
        Me.GroupBox2.Controls.Add(Me.Label44)
        Me.GroupBox2.Controls.Add(Me.chDYemas)
        Me.GroupBox2.Controls.Add(Me.chDCodPlan)
        Me.GroupBox2.Controls.Add(Me.chDKitOtros)
        Me.GroupBox2.Controls.Add(Me.chDFertOrg)
        Me.GroupBox2.Controls.Add(Me.chDFertQui)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.CHKConsultaOTHistorico)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.Label33)
        Me.GroupBox2.Controls.Add(Me.CHKCobranza)
        Me.GroupBox2.Controls.Add(Me.CHKAdministracion)
        Me.GroupBox2.Controls.Add(Me.Label32)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.CHKDespacho)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.CHKResultados)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.CHKRevision)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.CHKDigitacion)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.CHKPlanificacion)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.CHKConsultaMod)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.CHKIngresoOT)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CHKCotizador)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(401, 618)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        '
        'cbCobranzaMod
        '
        Me.cbCobranzaMod.Enabled = False
        Me.cbCobranzaMod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCobranzaMod.ForeColor = System.Drawing.Color.MediumBlue
        Me.cbCobranzaMod.Location = New System.Drawing.Point(189, 458)
        Me.cbCobranzaMod.Name = "cbCobranzaMod"
        Me.cbCobranzaMod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cbCobranzaMod.Size = New System.Drawing.Size(16, 16)
        Me.cbCobranzaMod.TabIndex = 127
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Black
        Me.Label89.Location = New System.Drawing.Point(46, 456)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(68, 16)
        Me.Label89.TabIndex = 126
        Me.Label89.Text = "Cobranza : "
        '
        'Label88
        '
        Me.Label88.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.ForeColor = System.Drawing.Color.Black
        Me.Label88.Location = New System.Drawing.Point(44, 534)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(78, 16)
        Me.Label88.TabIndex = 125
        Me.Label88.Text = "Genera Xml :"
        '
        'chGeneraXml
        '
        Me.chGeneraXml.Enabled = False
        Me.chGeneraXml.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chGeneraXml.ForeColor = System.Drawing.Color.MediumBlue
        Me.chGeneraXml.Location = New System.Drawing.Point(120, 533)
        Me.chGeneraXml.Name = "chGeneraXml"
        Me.chGeneraXml.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chGeneraXml.Size = New System.Drawing.Size(16, 16)
        Me.chGeneraXml.TabIndex = 124
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Black
        Me.Label87.Location = New System.Drawing.Point(285, 515)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(64, 16)
        Me.Label87.TabIndex = 123
        Me.Label87.Text = "T dbf :"
        '
        'chATdbf
        '
        Me.chATdbf.Enabled = False
        Me.chATdbf.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chATdbf.ForeColor = System.Drawing.Color.MediumBlue
        Me.chATdbf.Location = New System.Drawing.Point(347, 515)
        Me.chATdbf.Name = "chATdbf"
        Me.chATdbf.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chATdbf.Size = New System.Drawing.Size(16, 16)
        Me.chATdbf.TabIndex = 122
        '
        'chEFactura
        '
        Me.chEFactura.Enabled = False
        Me.chEFactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEFactura.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEFactura.Location = New System.Drawing.Point(237, 572)
        Me.chEFactura.Name = "chEFactura"
        Me.chEFactura.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEFactura.Size = New System.Drawing.Size(16, 16)
        Me.chEFactura.TabIndex = 121
        '
        'chENlab
        '
        Me.chENlab.Enabled = False
        Me.chENlab.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chENlab.ForeColor = System.Drawing.Color.MediumBlue
        Me.chENlab.Location = New System.Drawing.Point(237, 591)
        Me.chENlab.Name = "chENlab"
        Me.chENlab.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chENlab.Size = New System.Drawing.Size(16, 16)
        Me.chENlab.TabIndex = 120
        '
        'chEOT
        '
        Me.chEOT.Enabled = False
        Me.chEOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEOT.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEOT.Location = New System.Drawing.Point(140, 572)
        Me.chEOT.Name = "chEOT"
        Me.chEOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEOT.Size = New System.Drawing.Size(16, 16)
        Me.chEOT.TabIndex = 119
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.Black
        Me.Label82.Location = New System.Drawing.Point(276, 572)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(73, 16)
        Me.Label82.TabIndex = 118
        Me.Label82.Text = "Elementos :"
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.ForeColor = System.Drawing.Color.Black
        Me.Label83.Location = New System.Drawing.Point(47, 592)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(87, 16)
        Me.Label83.TabIndex = 117
        Me.Label83.Text = "D Rango OT :"
        '
        'chEElementos
        '
        Me.chEElementos.Enabled = False
        Me.chEElementos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEElementos.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEElementos.Location = New System.Drawing.Point(347, 572)
        Me.chEElementos.Name = "chEElementos"
        Me.chEElementos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEElementos.Size = New System.Drawing.Size(16, 16)
        Me.chEElementos.TabIndex = 116
        '
        'chERangoOT
        '
        Me.chERangoOT.Enabled = False
        Me.chERangoOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chERangoOT.ForeColor = System.Drawing.Color.MediumBlue
        Me.chERangoOT.Location = New System.Drawing.Point(140, 592)
        Me.chERangoOT.Name = "chERangoOT"
        Me.chERangoOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chERangoOT.Size = New System.Drawing.Size(16, 16)
        Me.chERangoOT.TabIndex = 115
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.ForeColor = System.Drawing.Color.Black
        Me.Label84.Location = New System.Drawing.Point(178, 572)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(60, 16)
        Me.Label84.TabIndex = 114
        Me.Label84.Text = "Factura :"
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.Black
        Me.Label85.Location = New System.Drawing.Point(178, 592)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(60, 16)
        Me.Label85.TabIndex = 113
        Me.Label85.Text = "N° lab :"
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(47, 572)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(93, 16)
        Me.Label86.TabIndex = 112
        Me.Label86.Text = "Orden Trabajo :"
        '
        'chSalinidad
        '
        Me.chSalinidad.Enabled = False
        Me.chSalinidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chSalinidad.ForeColor = System.Drawing.Color.MediumBlue
        Me.chSalinidad.Location = New System.Drawing.Point(263, 309)
        Me.chSalinidad.Name = "chSalinidad"
        Me.chSalinidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chSalinidad.Size = New System.Drawing.Size(16, 16)
        Me.chSalinidad.TabIndex = 111
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.ForeColor = System.Drawing.Color.Black
        Me.Label81.Location = New System.Drawing.Point(200, 309)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(72, 16)
        Me.Label81.TabIndex = 110
        Me.Label81.Text = "Salinidad :"
        '
        'chFertilidad
        '
        Me.chFertilidad.Enabled = False
        Me.chFertilidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chFertilidad.ForeColor = System.Drawing.Color.MediumBlue
        Me.chFertilidad.Location = New System.Drawing.Point(175, 309)
        Me.chFertilidad.Name = "chFertilidad"
        Me.chFertilidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chFertilidad.Size = New System.Drawing.Size(16, 16)
        Me.chFertilidad.TabIndex = 109
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.ForeColor = System.Drawing.Color.Black
        Me.Label80.Location = New System.Drawing.Point(114, 309)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(66, 16)
        Me.Label80.TabIndex = 108
        Me.Label80.Text = "Fertilidad :"
        '
        'PanelTablas
        '
        Me.PanelTablas.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.PanelTablas.Controls.Add(Me.chTipoMasc)
        Me.PanelTablas.Controls.Add(Me.Label79)
        Me.PanelTablas.Controls.Add(Me.btnAceptaTablas)
        Me.PanelTablas.Controls.Add(Me.Label78)
        Me.PanelTablas.Controls.Add(Me.chEspecieVariedad)
        Me.PanelTablas.Controls.Add(Me.chMuestreadores)
        Me.PanelTablas.Controls.Add(Me.Label61)
        Me.PanelTablas.Controls.Add(Me.chRangos)
        Me.PanelTablas.Controls.Add(Me.chProductor)
        Me.PanelTablas.Controls.Add(Me.chElemento)
        Me.PanelTablas.Controls.Add(Me.chLocalidad)
        Me.PanelTablas.Controls.Add(Me.Label62)
        Me.PanelTablas.Controls.Add(Me.Label69)
        Me.PanelTablas.Controls.Add(Me.Label70)
        Me.PanelTablas.Controls.Add(Me.Label71)
        Me.PanelTablas.Controls.Add(Me.Label72)
        Me.PanelTablas.Controls.Add(Me.chCondPago)
        Me.PanelTablas.Controls.Add(Me.chTejido)
        Me.PanelTablas.Controls.Add(Me.chPersonal)
        Me.PanelTablas.Controls.Add(Me.chRelOTFact)
        Me.PanelTablas.Controls.Add(Me.chCodElem)
        Me.PanelTablas.Controls.Add(Me.Label73)
        Me.PanelTablas.Controls.Add(Me.Label74)
        Me.PanelTablas.Controls.Add(Me.Label75)
        Me.PanelTablas.Controls.Add(Me.Label76)
        Me.PanelTablas.Controls.Add(Me.Label77)
        Me.PanelTablas.Location = New System.Drawing.Point(21, 35)
        Me.PanelTablas.Name = "PanelTablas"
        Me.PanelTablas.Size = New System.Drawing.Size(366, 171)
        Me.PanelTablas.TabIndex = 29
        Me.PanelTablas.Visible = False
        '
        'chTipoMasc
        '
        Me.chTipoMasc.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chTipoMasc.ForeColor = System.Drawing.Color.MediumBlue
        Me.chTipoMasc.Location = New System.Drawing.Point(137, 45)
        Me.chTipoMasc.Name = "chTipoMasc"
        Me.chTipoMasc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chTipoMasc.Size = New System.Drawing.Size(16, 16)
        Me.chTipoMasc.TabIndex = 71
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(11, 67)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(125, 16)
        Me.Label79.TabIndex = 70
        Me.Label79.Text = "Relación OT/Factura :"
        '
        'btnAceptaTablas
        '
        Me.btnAceptaTablas.BackColor = System.Drawing.Color.Transparent
        Me.btnAceptaTablas.Image = Global.LabSys.My.Resources.Resources.accept
        Me.btnAceptaTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAceptaTablas.Location = New System.Drawing.Point(285, 73)
        Me.btnAceptaTablas.Name = "btnAceptaTablas"
        Me.btnAceptaTablas.Size = New System.Drawing.Size(68, 24)
        Me.btnAceptaTablas.TabIndex = 69
        Me.btnAceptaTablas.Text = "Aceptar"
        Me.btnAceptaTablas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAceptaTablas.UseVisualStyleBackColor = False
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.SystemColors.Window
        Me.Label78.Location = New System.Drawing.Point(1, 0)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(364, 16)
        Me.Label78.TabIndex = 68
        Me.Label78.Text = "Tablas :"
        '
        'chEspecieVariedad
        '
        Me.chEspecieVariedad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEspecieVariedad.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEspecieVariedad.Location = New System.Drawing.Point(137, 89)
        Me.chEspecieVariedad.Name = "chEspecieVariedad"
        Me.chEspecieVariedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEspecieVariedad.Size = New System.Drawing.Size(16, 16)
        Me.chEspecieVariedad.TabIndex = 67
        '
        'chMuestreadores
        '
        Me.chMuestreadores.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chMuestreadores.ForeColor = System.Drawing.Color.MediumBlue
        Me.chMuestreadores.Location = New System.Drawing.Point(138, 133)
        Me.chMuestreadores.Name = "chMuestreadores"
        Me.chMuestreadores.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chMuestreadores.Size = New System.Drawing.Size(16, 16)
        Me.chMuestreadores.TabIndex = 66
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(12, 111)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(124, 16)
        Me.Label61.TabIndex = 65
        Me.Label61.Text = "Condición de Pago :"
        '
        'chRangos
        '
        Me.chRangos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRangos.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRangos.Location = New System.Drawing.Point(255, 111)
        Me.chRangos.Name = "chRangos"
        Me.chRangos.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRangos.Size = New System.Drawing.Size(16, 16)
        Me.chRangos.TabIndex = 64
        '
        'chProductor
        '
        Me.chProductor.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chProductor.ForeColor = System.Drawing.Color.MediumBlue
        Me.chProductor.Location = New System.Drawing.Point(255, 89)
        Me.chProductor.Name = "chProductor"
        Me.chProductor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chProductor.Size = New System.Drawing.Size(16, 16)
        Me.chProductor.TabIndex = 63
        '
        'chElemento
        '
        Me.chElemento.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chElemento.ForeColor = System.Drawing.Color.MediumBlue
        Me.chElemento.Location = New System.Drawing.Point(255, 45)
        Me.chElemento.Name = "chElemento"
        Me.chElemento.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chElemento.Size = New System.Drawing.Size(16, 16)
        Me.chElemento.TabIndex = 62
        '
        'chLocalidad
        '
        Me.chLocalidad.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chLocalidad.ForeColor = System.Drawing.Color.MediumBlue
        Me.chLocalidad.Location = New System.Drawing.Point(255, 23)
        Me.chLocalidad.Name = "chLocalidad"
        Me.chLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chLocalidad.Size = New System.Drawing.Size(16, 16)
        Me.chLocalidad.TabIndex = 61
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(12, 45)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(89, 16)
        Me.Label62.TabIndex = 60
        Me.Label62.Text = "Tipo Mascara :"
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(180, 111)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(68, 16)
        Me.Label69.TabIndex = 59
        Me.Label69.Text = "Rangos : "
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(180, 89)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(68, 16)
        Me.Label70.TabIndex = 58
        Me.Label70.Text = "Productor :"
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(12, 133)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(96, 16)
        Me.Label71.TabIndex = 57
        Me.Label71.Text = "Muestreadores :"
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(180, 67)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(59, 16)
        Me.Label72.TabIndex = 56
        Me.Label72.Text = "Tejido :"
        '
        'chCondPago
        '
        Me.chCondPago.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCondPago.ForeColor = System.Drawing.Color.MediumBlue
        Me.chCondPago.Location = New System.Drawing.Point(137, 111)
        Me.chCondPago.Name = "chCondPago"
        Me.chCondPago.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chCondPago.Size = New System.Drawing.Size(16, 16)
        Me.chCondPago.TabIndex = 55
        '
        'chTejido
        '
        Me.chTejido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chTejido.ForeColor = System.Drawing.Color.MediumBlue
        Me.chTejido.Location = New System.Drawing.Point(255, 67)
        Me.chTejido.Name = "chTejido"
        Me.chTejido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chTejido.Size = New System.Drawing.Size(16, 16)
        Me.chTejido.TabIndex = 54
        '
        'chPersonal
        '
        Me.chPersonal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chPersonal.ForeColor = System.Drawing.Color.MediumBlue
        Me.chPersonal.Location = New System.Drawing.Point(255, 133)
        Me.chPersonal.Name = "chPersonal"
        Me.chPersonal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chPersonal.Size = New System.Drawing.Size(16, 16)
        Me.chPersonal.TabIndex = 53
        '
        'chRelOTFact
        '
        Me.chRelOTFact.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRelOTFact.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRelOTFact.Location = New System.Drawing.Point(137, 67)
        Me.chRelOTFact.Name = "chRelOTFact"
        Me.chRelOTFact.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRelOTFact.Size = New System.Drawing.Size(16, 16)
        Me.chRelOTFact.TabIndex = 52
        '
        'chCodElem
        '
        Me.chCodElem.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCodElem.ForeColor = System.Drawing.Color.MediumBlue
        Me.chCodElem.Location = New System.Drawing.Point(137, 23)
        Me.chCodElem.Name = "chCodElem"
        Me.chCodElem.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chCodElem.Size = New System.Drawing.Size(16, 16)
        Me.chCodElem.TabIndex = 51
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(12, 89)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(111, 16)
        Me.Label73.TabIndex = 50
        Me.Label73.Text = "Especie/variedad :"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(180, 133)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(69, 16)
        Me.Label74.TabIndex = 49
        Me.Label74.Text = "Personal :"
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Black
        Me.Label75.Location = New System.Drawing.Point(12, 23)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(113, 16)
        Me.Label75.TabIndex = 48
        Me.Label75.Text = "Código/Elemento :"
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(180, 45)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(77, 16)
        Me.Label76.TabIndex = 47
        Me.Label76.Text = "Elemento :"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(180, 23)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(77, 16)
        Me.Label77.TabIndex = 46
        Me.Label77.Text = "Localidad :"
        '
        'chEliminaOT
        '
        Me.chEliminaOT.Enabled = False
        Me.chEliminaOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEliminaOT.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEliminaOT.Location = New System.Drawing.Point(120, 514)
        Me.chEliminaOT.Name = "chEliminaOT"
        Me.chEliminaOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEliminaOT.Size = New System.Drawing.Size(16, 16)
        Me.chEliminaOT.TabIndex = 107
        '
        'chTHistorico
        '
        Me.chTHistorico.Enabled = False
        Me.chTHistorico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chTHistorico.ForeColor = System.Drawing.Color.MediumBlue
        Me.chTHistorico.Location = New System.Drawing.Point(253, 492)
        Me.chTHistorico.Name = "chTHistorico"
        Me.chTHistorico.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chTHistorico.Size = New System.Drawing.Size(16, 16)
        Me.chTHistorico.TabIndex = 106
        '
        'chEstados
        '
        Me.chEstados.Enabled = False
        Me.chEstados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEstados.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEstados.Location = New System.Drawing.Point(120, 553)
        Me.chEstados.Name = "chEstados"
        Me.chEstados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEstados.Size = New System.Drawing.Size(16, 16)
        Me.chEstados.TabIndex = 105
        '
        'chTablas
        '
        Me.chTablas.Enabled = False
        Me.chTablas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chTablas.ForeColor = System.Drawing.Color.MediumBlue
        Me.chTablas.Location = New System.Drawing.Point(120, 495)
        Me.chTablas.Name = "chTablas"
        Me.chTablas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chTablas.Size = New System.Drawing.Size(16, 16)
        Me.chTablas.TabIndex = 104
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(149, 515)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(106, 16)
        Me.Label63.TabIndex = 101
        Me.Label63.Text = "Centro de costo :"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(285, 493)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(64, 16)
        Me.Label64.TabIndex = 100
        Me.Label64.Text = "Listados :"
        '
        'chCentroCosto
        '
        Me.chCentroCosto.Enabled = False
        Me.chCentroCosto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCentroCosto.ForeColor = System.Drawing.Color.MediumBlue
        Me.chCentroCosto.Location = New System.Drawing.Point(253, 514)
        Me.chCentroCosto.Name = "chCentroCosto"
        Me.chCentroCosto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chCentroCosto.Size = New System.Drawing.Size(16, 16)
        Me.chCentroCosto.TabIndex = 97
        '
        'chListados
        '
        Me.chListados.Enabled = False
        Me.chListados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chListados.ForeColor = System.Drawing.Color.MediumBlue
        Me.chListados.Location = New System.Drawing.Point(347, 493)
        Me.chListados.Name = "chListados"
        Me.chListados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chListados.Size = New System.Drawing.Size(16, 16)
        Me.chListados.TabIndex = 96
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(45, 514)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(75, 16)
        Me.Label65.TabIndex = 95
        Me.Label65.Text = "Elimina OT :"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(149, 492)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(75, 16)
        Me.Label66.TabIndex = 94
        Me.Label66.Text = "T. Historico :"
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(46, 553)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(64, 16)
        Me.Label67.TabIndex = 93
        Me.Label67.Text = "Estados :"
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(46, 495)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(50, 16)
        Me.Label68.TabIndex = 92
        Me.Label68.Text = "Tablas :"
        '
        'chLibroVentas
        '
        Me.chLibroVentas.Enabled = False
        Me.chLibroVentas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chLibroVentas.ForeColor = System.Drawing.Color.MediumBlue
        Me.chLibroVentas.Location = New System.Drawing.Point(323, 439)
        Me.chLibroVentas.Name = "chLibroVentas"
        Me.chLibroVentas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chLibroVentas.Size = New System.Drawing.Size(16, 16)
        Me.chLibroVentas.TabIndex = 91
        '
        'chCancelFacturas
        '
        Me.chCancelFacturas.Enabled = False
        Me.chCancelFacturas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCancelFacturas.ForeColor = System.Drawing.Color.MediumBlue
        Me.chCancelFacturas.Location = New System.Drawing.Point(189, 439)
        Me.chCancelFacturas.Name = "chCancelFacturas"
        Me.chCancelFacturas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chCancelFacturas.Size = New System.Drawing.Size(16, 16)
        Me.chCancelFacturas.TabIndex = 90
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(224, 439)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(100, 16)
        Me.Label59.TabIndex = 89
        Me.Label59.Text = "Libro de Ventas : "
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(46, 439)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(144, 16)
        Me.Label60.TabIndex = 88
        Me.Label60.Text = "Cancelelación Facturas :"
        '
        'chCartaDespacho
        '
        Me.chCartaDespacho.Enabled = False
        Me.chCartaDespacho.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chCartaDespacho.ForeColor = System.Drawing.Color.MediumBlue
        Me.chCartaDespacho.Location = New System.Drawing.Point(264, 402)
        Me.chCartaDespacho.Name = "chCartaDespacho"
        Me.chCartaDespacho.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chCartaDespacho.Size = New System.Drawing.Size(16, 16)
        Me.chCartaDespacho.TabIndex = 87
        '
        'chDespacho
        '
        Me.chDespacho.Enabled = False
        Me.chDespacho.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDespacho.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDespacho.Location = New System.Drawing.Point(120, 402)
        Me.chDespacho.Name = "chDespacho"
        Me.chDespacho.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDespacho.Size = New System.Drawing.Size(16, 16)
        Me.chDespacho.TabIndex = 86
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(160, 402)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(105, 16)
        Me.Label57.TabIndex = 85
        Me.Label57.Text = "Carta Despacho : "
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(50, 402)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(76, 16)
        Me.Label58.TabIndex = 84
        Me.Label58.Text = "Despacho :"
        '
        'chEmYemas
        '
        Me.chEmYemas.Enabled = False
        Me.chEmYemas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEmYemas.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEmYemas.Location = New System.Drawing.Point(313, 345)
        Me.chEmYemas.Name = "chEmYemas"
        Me.chEmYemas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEmYemas.Size = New System.Drawing.Size(16, 16)
        Me.chEmYemas.TabIndex = 83
        '
        'chEmResultados
        '
        Me.chEmResultados.Enabled = False
        Me.chEmResultados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chEmResultados.ForeColor = System.Drawing.Color.MediumBlue
        Me.chEmResultados.Location = New System.Drawing.Point(174, 345)
        Me.chEmResultados.Name = "chEmResultados"
        Me.chEmResultados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chEmResultados.Size = New System.Drawing.Size(16, 16)
        Me.chEmResultados.TabIndex = 82
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(50, 365)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(108, 16)
        Me.Label54.TabIndex = 81
        Me.Label54.Text = "Horizontal Foliar :"
        '
        'chHorizFoliar
        '
        Me.chHorizFoliar.Enabled = False
        Me.chHorizFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chHorizFoliar.ForeColor = System.Drawing.Color.MediumBlue
        Me.chHorizFoliar.Location = New System.Drawing.Point(174, 365)
        Me.chHorizFoliar.Name = "chHorizFoliar"
        Me.chHorizFoliar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chHorizFoliar.Size = New System.Drawing.Size(16, 16)
        Me.chHorizFoliar.TabIndex = 80
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(213, 345)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(101, 16)
        Me.Label55.TabIndex = 79
        Me.Label55.Text = "Emisión Yemas :"
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(50, 345)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(130, 16)
        Me.Label56.TabIndex = 78
        Me.Label56.Text = "Emisión Resultados : "
        '
        'chRSuelo
        '
        Me.chRSuelo.Enabled = False
        Me.chRSuelo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRSuelo.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRSuelo.Location = New System.Drawing.Point(96, 309)
        Me.chRSuelo.Name = "chRSuelo"
        Me.chRSuelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRSuelo.Size = New System.Drawing.Size(16, 16)
        Me.chRSuelo.TabIndex = 77
        '
        'chRagua
        '
        Me.chRagua.Enabled = False
        Me.chRagua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRagua.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRagua.Location = New System.Drawing.Point(174, 270)
        Me.chRagua.Name = "chRagua"
        Me.chRagua.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRagua.Size = New System.Drawing.Size(16, 16)
        Me.chRagua.TabIndex = 76
        '
        'chRTejido
        '
        Me.chRTejido.Enabled = False
        Me.chRTejido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRTejido.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRTejido.Location = New System.Drawing.Point(96, 290)
        Me.chRTejido.Name = "chRTejido"
        Me.chRTejido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRTejido.Size = New System.Drawing.Size(16, 16)
        Me.chRTejido.TabIndex = 75
        '
        'chRFoliar
        '
        Me.chRFoliar.Enabled = False
        Me.chRFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRFoliar.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRFoliar.Location = New System.Drawing.Point(96, 270)
        Me.chRFoliar.Name = "chRFoliar"
        Me.chRFoliar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRFoliar.Size = New System.Drawing.Size(16, 16)
        Me.chRFoliar.TabIndex = 74
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(291, 270)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(83, 16)
        Me.Label46.TabIndex = 73
        Me.Label46.Text = "List. Inscrip. : "
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(197, 289)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(68, 16)
        Me.Label47.TabIndex = 72
        Me.Label47.Text = "Kit y Otros :"
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(204, 270)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(62, 16)
        Me.Label48.TabIndex = 71
        Me.Label48.Text = "Fert. Org :"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(115, 289)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(59, 16)
        Me.Label49.TabIndex = 70
        Me.Label49.Text = "Fert. Qui :"
        '
        'chRListInscrip
        '
        Me.chRListInscrip.Enabled = False
        Me.chRListInscrip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRListInscrip.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRListInscrip.Location = New System.Drawing.Point(371, 272)
        Me.chRListInscrip.Name = "chRListInscrip"
        Me.chRListInscrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRListInscrip.Size = New System.Drawing.Size(16, 16)
        Me.chRListInscrip.TabIndex = 69
        '
        'chRKitOtros
        '
        Me.chRKitOtros.Enabled = False
        Me.chRKitOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRKitOtros.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRKitOtros.Location = New System.Drawing.Point(264, 289)
        Me.chRKitOtros.Name = "chRKitOtros"
        Me.chRKitOtros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRKitOtros.Size = New System.Drawing.Size(16, 16)
        Me.chRKitOtros.TabIndex = 68
        '
        'chRFertOrg
        '
        Me.chRFertOrg.Enabled = False
        Me.chRFertOrg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRFertOrg.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRFertOrg.Location = New System.Drawing.Point(264, 270)
        Me.chRFertOrg.Name = "chRFertOrg"
        Me.chRFertOrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRFertOrg.Size = New System.Drawing.Size(16, 16)
        Me.chRFertOrg.TabIndex = 67
        '
        'chRFertQui
        '
        Me.chRFertQui.Enabled = False
        Me.chRFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRFertQui.ForeColor = System.Drawing.Color.MediumBlue
        Me.chRFertQui.Location = New System.Drawing.Point(175, 289)
        Me.chRFertQui.Name = "chRFertQui"
        Me.chRFertQui.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chRFertQui.Size = New System.Drawing.Size(16, 16)
        Me.chRFertQui.TabIndex = 66
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(48, 309)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(50, 16)
        Me.Label50.TabIndex = 65
        Me.Label50.Text = "Suelo :"
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(130, 270)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(50, 16)
        Me.Label51.TabIndex = 64
        Me.Label51.Text = "Agua :"
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(48, 290)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(50, 16)
        Me.Label52.TabIndex = 63
        Me.Label52.Text = "Tejido :"
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(49, 270)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(50, 16)
        Me.Label53.TabIndex = 62
        Me.Label53.Text = "Foliar :"
        '
        'chDYMantencion
        '
        Me.chDYMantencion.Enabled = False
        Me.chDYMantencion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDYMantencion.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDYMantencion.Location = New System.Drawing.Point(297, 231)
        Me.chDYMantencion.Name = "chDYMantencion"
        Me.chDYMantencion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDYMantencion.Size = New System.Drawing.Size(16, 16)
        Me.chDYMantencion.TabIndex = 45
        '
        'chDYTraspaso
        '
        Me.chDYTraspaso.Enabled = False
        Me.chDYTraspaso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDYTraspaso.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDYTraspaso.Location = New System.Drawing.Point(194, 231)
        Me.chDYTraspaso.Name = "chDYTraspaso"
        Me.chDYTraspaso.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDYTraspaso.Size = New System.Drawing.Size(16, 16)
        Me.chDYTraspaso.TabIndex = 44
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(222, 231)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(80, 16)
        Me.Label45.TabIndex = 43
        Me.Label45.Text = "Mantención :"
        '
        'chDSuelo
        '
        Me.chDSuelo.Enabled = False
        Me.chDSuelo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDSuelo.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDSuelo.Location = New System.Drawing.Point(172, 211)
        Me.chDSuelo.Name = "chDSuelo"
        Me.chDSuelo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDSuelo.Size = New System.Drawing.Size(16, 16)
        Me.chDSuelo.TabIndex = 42
        '
        'chDAgua
        '
        Me.chDAgua.Enabled = False
        Me.chDAgua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDAgua.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDAgua.Location = New System.Drawing.Point(172, 191)
        Me.chDAgua.Name = "chDAgua"
        Me.chDAgua.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDAgua.Size = New System.Drawing.Size(16, 16)
        Me.chDAgua.TabIndex = 41
        '
        'chDTejido
        '
        Me.chDTejido.Enabled = False
        Me.chDTejido.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDTejido.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDTejido.Location = New System.Drawing.Point(94, 212)
        Me.chDTejido.Name = "chDTejido"
        Me.chDTejido.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDTejido.Size = New System.Drawing.Size(16, 16)
        Me.chDTejido.TabIndex = 40
        '
        'chDFoliar
        '
        Me.chDFoliar.Enabled = False
        Me.chDFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDFoliar.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDFoliar.Location = New System.Drawing.Point(94, 192)
        Me.chDFoliar.Name = "chDFoliar"
        Me.chDFoliar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDFoliar.Size = New System.Drawing.Size(16, 16)
        Me.chDFoliar.TabIndex = 39
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(130, 231)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(80, 16)
        Me.Label40.TabIndex = 38
        Me.Label40.Text = "Traspaso :"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(292, 211)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(74, 16)
        Me.Label41.TabIndex = 37
        Me.Label41.Text = "Cod. Plan. : "
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(292, 191)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(68, 16)
        Me.Label42.TabIndex = 36
        Me.Label42.Text = "Kit y Otros :"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(204, 211)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(62, 16)
        Me.Label43.TabIndex = 35
        Me.Label43.Text = "Fert. Org :"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Black
        Me.Label44.Location = New System.Drawing.Point(204, 191)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(59, 16)
        Me.Label44.TabIndex = 34
        Me.Label44.Text = "Fert. Qui :"
        '
        'chDYemas
        '
        Me.chDYemas.Enabled = False
        Me.chDYemas.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDYemas.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDYemas.Location = New System.Drawing.Point(94, 232)
        Me.chDYemas.Name = "chDYemas"
        Me.chDYemas.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDYemas.Size = New System.Drawing.Size(16, 16)
        Me.chDYemas.TabIndex = 33
        '
        'chDCodPlan
        '
        Me.chDCodPlan.Enabled = False
        Me.chDCodPlan.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDCodPlan.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDCodPlan.Location = New System.Drawing.Point(364, 211)
        Me.chDCodPlan.Name = "chDCodPlan"
        Me.chDCodPlan.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDCodPlan.Size = New System.Drawing.Size(16, 16)
        Me.chDCodPlan.TabIndex = 32
        '
        'chDKitOtros
        '
        Me.chDKitOtros.Enabled = False
        Me.chDKitOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDKitOtros.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDKitOtros.Location = New System.Drawing.Point(364, 191)
        Me.chDKitOtros.Name = "chDKitOtros"
        Me.chDKitOtros.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDKitOtros.Size = New System.Drawing.Size(16, 16)
        Me.chDKitOtros.TabIndex = 31
        '
        'chDFertOrg
        '
        Me.chDFertOrg.Enabled = False
        Me.chDFertOrg.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDFertOrg.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDFertOrg.Location = New System.Drawing.Point(264, 211)
        Me.chDFertOrg.Name = "chDFertOrg"
        Me.chDFertOrg.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDFertOrg.Size = New System.Drawing.Size(16, 16)
        Me.chDFertOrg.TabIndex = 30
        '
        'chDFertQui
        '
        Me.chDFertQui.Enabled = False
        Me.chDFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chDFertQui.ForeColor = System.Drawing.Color.MediumBlue
        Me.chDFertQui.Location = New System.Drawing.Point(264, 191)
        Me.chDFertQui.Name = "chDFertQui"
        Me.chDFertQui.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chDFertQui.Size = New System.Drawing.Size(16, 16)
        Me.chDFertQui.TabIndex = 29
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(46, 231)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(54, 16)
        Me.Label39.TabIndex = 28
        Me.Label39.Text = "Yemas :"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(130, 211)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(50, 16)
        Me.Label38.TabIndex = 27
        Me.Label38.Text = "Suelo :"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(130, 190)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(50, 16)
        Me.Label37.TabIndex = 26
        Me.Label37.Text = "Agua :"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(46, 211)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(50, 16)
        Me.Label36.TabIndex = 25
        Me.Label36.Text = "Tejido :"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(47, 192)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(50, 16)
        Me.Label35.TabIndex = 24
        Me.Label35.Text = "Foliar :"
        '
        'CHKConsultaOTHistorico
        '
        Me.CHKConsultaOTHistorico.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKConsultaOTHistorico.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKConsultaOTHistorico.Location = New System.Drawing.Point(28, 127)
        Me.CHKConsultaOTHistorico.Name = "CHKConsultaOTHistorico"
        Me.CHKConsultaOTHistorico.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKConsultaOTHistorico.Size = New System.Drawing.Size(16, 16)
        Me.CHKConsultaOTHistorico.TabIndex = 22
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(46, 127)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(134, 16)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "Consulta OT historico :"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(46, 422)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(88, 16)
        Me.Label33.TabIndex = 21
        Me.Label33.Text = "Cobranza"
        '
        'CHKCobranza
        '
        Me.CHKCobranza.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCobranza.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKCobranza.Location = New System.Drawing.Point(28, 422)
        Me.CHKCobranza.Name = "CHKCobranza"
        Me.CHKCobranza.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKCobranza.Size = New System.Drawing.Size(16, 16)
        Me.CHKCobranza.TabIndex = 20
        '
        'CHKAdministracion
        '
        Me.CHKAdministracion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKAdministracion.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKAdministracion.Location = New System.Drawing.Point(28, 475)
        Me.CHKAdministracion.Name = "CHKAdministracion"
        Me.CHKAdministracion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKAdministracion.Size = New System.Drawing.Size(16, 16)
        Me.CHKAdministracion.TabIndex = 19
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(46, 475)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 16)
        Me.Label32.TabIndex = 18
        Me.Label32.Text = "Administración"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(46, 384)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Despacho"
        '
        'CHKDespacho
        '
        Me.CHKDespacho.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDespacho.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKDespacho.Location = New System.Drawing.Point(28, 384)
        Me.CHKDespacho.Name = "CHKDespacho"
        Me.CHKDespacho.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKDespacho.Size = New System.Drawing.Size(16, 16)
        Me.CHKDespacho.TabIndex = 16
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(46, 328)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 16)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "Resultados"
        '
        'CHKResultados
        '
        Me.CHKResultados.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKResultados.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKResultados.Location = New System.Drawing.Point(28, 328)
        Me.CHKResultados.Name = "CHKResultados"
        Me.CHKResultados.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKResultados.Size = New System.Drawing.Size(16, 16)
        Me.CHKResultados.TabIndex = 14
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(46, 251)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(72, 16)
        Me.Label19.TabIndex = 13
        Me.Label19.Text = "Revisión"
        '
        'CHKRevision
        '
        Me.CHKRevision.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKRevision.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKRevision.Location = New System.Drawing.Point(28, 251)
        Me.CHKRevision.Name = "CHKRevision"
        Me.CHKRevision.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKRevision.Size = New System.Drawing.Size(16, 16)
        Me.CHKRevision.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(46, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 11
        Me.Label18.Text = "Digitación"
        '
        'CHKDigitacion
        '
        Me.CHKDigitacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDigitacion.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKDigitacion.Location = New System.Drawing.Point(28, 171)
        Me.CHKDigitacion.Name = "CHKDigitacion"
        Me.CHKDigitacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKDigitacion.Size = New System.Drawing.Size(16, 16)
        Me.CHKDigitacion.TabIndex = 10
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(46, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 16)
        Me.Label17.TabIndex = 9
        Me.Label17.Text = "Planificación :"
        '
        'CHKPlanificacion
        '
        Me.CHKPlanificacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKPlanificacion.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKPlanificacion.Location = New System.Drawing.Point(28, 149)
        Me.CHKPlanificacion.Name = "CHKPlanificacion"
        Me.CHKPlanificacion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKPlanificacion.Size = New System.Drawing.Size(16, 16)
        Me.CHKPlanificacion.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(46, 105)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Consulta/Mod OT :"
        '
        'CHKConsultaMod
        '
        Me.CHKConsultaMod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKConsultaMod.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKConsultaMod.Location = New System.Drawing.Point(28, 105)
        Me.CHKConsultaMod.Name = "CHKConsultaMod"
        Me.CHKConsultaMod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKConsultaMod.Size = New System.Drawing.Size(16, 16)
        Me.CHKConsultaMod.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(46, 83)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 16)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Ingreso OT :"
        '
        'CHKIngresoOT
        '
        Me.CHKIngresoOT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKIngresoOT.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKIngresoOT.Location = New System.Drawing.Point(28, 83)
        Me.CHKIngresoOT.Name = "CHKIngresoOT"
        Me.CHKIngresoOT.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKIngresoOT.Size = New System.Drawing.Size(16, 16)
        Me.CHKIngresoOT.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(11, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 16)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Permisos a LabSys"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(4, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 16)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Acceso"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(46, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cotizador :"
        '
        'CHKCotizador
        '
        Me.CHKCotizador.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCotizador.ForeColor = System.Drawing.Color.MediumBlue
        Me.CHKCotizador.Location = New System.Drawing.Point(28, 61)
        Me.CHKCotizador.Name = "CHKCotizador"
        Me.CHKCotizador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CHKCotizador.Size = New System.Drawing.Size(16, 16)
        Me.CHKCotizador.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTEliminarEle)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.DTGElementosAna)
        Me.GroupBox3.Controls.Add(Me.DTGElementos)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 619)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1080, 224)
        Me.GroupBox3.TabIndex = 24
        Me.GroupBox3.TabStop = False
        '
        'BTEliminarEle
        '
        Me.BTEliminarEle.BackColor = System.Drawing.Color.Transparent
        Me.BTEliminarEle.Image = Global.LabSys.My.Resources.Resources.cancel
        Me.BTEliminarEle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTEliminarEle.Location = New System.Drawing.Point(816, 101)
        Me.BTEliminarEle.Name = "BTEliminarEle"
        Me.BTEliminarEle.Size = New System.Drawing.Size(71, 24)
        Me.BTEliminarEle.TabIndex = 28
        Me.BTEliminarEle.Text = "Eliminar"
        Me.BTEliminarEle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTEliminarEle.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(552, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(72, 32)
        Me.Label25.TabIndex = 17
        Me.Label25.Text = "Elementos Analista"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(8, 48)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 16)
        Me.Label24.TabIndex = 16
        Me.Label24.Text = "Elementos"
        '
        'DTGElementosAna
        '
        Me.DTGElementosAna.CaptionVisible = False
        Me.DTGElementosAna.DataMember = ""
        Me.DTGElementosAna.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElementosAna.Location = New System.Drawing.Point(624, 40)
        Me.DTGElementosAna.Name = "DTGElementosAna"
        Me.DTGElementosAna.Size = New System.Drawing.Size(160, 168)
        Me.DTGElementosAna.TabIndex = 6
        Me.DTGElementosAna.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DTGElementosAna
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ELEMENTOS_ANALISTA"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn5.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Elemento"
        Me.DataGridTextBoxColumn6.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 55
        '
        'DTGElementos
        '
        Me.DTGElementos.CaptionVisible = False
        Me.DTGElementos.DataMember = ""
        Me.DTGElementos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTGElementos.Location = New System.Drawing.Point(88, 40)
        Me.DTGElementos.Name = "DTGElementos"
        Me.DTGElementos.Size = New System.Drawing.Size(344, 168)
        Me.DTGElementos.TabIndex = 5
        Me.DTGElementos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTGElementos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ELEMENTOS_TMU"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn1.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Elemento"
        Me.DataGridTextBoxColumn2.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 55
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Nombre"
        Me.DataGridTextBoxColumn3.MappingName = "ELE_NOMBRE"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 130
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Unidad"
        Me.DataGridTextBoxColumn4.MappingName = "ELE_UNIDAD"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(8, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(248, 16)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Elementos Relacionados a la digitación"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.TxtViaFoto)
        Me.GroupBox4.Controls.Add(Me.PictureBox1)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(840, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(240, 472)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(8, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(28, 16)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Via :"
        '
        'TxtViaFoto
        '
        Me.TxtViaFoto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtViaFoto.Location = New System.Drawing.Point(48, 48)
        Me.TxtViaFoto.Name = "TxtViaFoto"
        Me.TxtViaFoto.Size = New System.Drawing.Size(176, 21)
        Me.TxtViaFoto.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(16, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(208, 224)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(8, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(48, 16)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "Foto"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(841, 480)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(67, 24)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Grabar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.LabSys.My.Resources.Resources.cancel
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(929, 480)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(69, 24)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Eliminar"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(1017, 480)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(64, 24)
        Me.Button4.TabIndex = 28
        Me.Button4.Text = "Salir"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Frm_Personal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1098, 863)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "Frm_Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Personal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DTGPersonal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.PanelTablas.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DTGElementosAna, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTGElementos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Anti_Elimina_lineas()
        DTGElementos.DataSource = Cjto_Tablas1.Tables("ELEMENTOS_TMU")
        DTGElementosAna.DataSource = Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA")
        Me.DTGPersonal.DataSource = Cjto_Tablas1.Tables("PERSONAL")
    End Sub

    Private Sub Frm_Personal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cd As New CapaDato
        cd.Inicializar()
        cd.EjecutarQueryDt("usp_SelectPersonal", Cjto_Tablas1, "PERSONAL")

        Call Anti_Elimina_lineas()
        DTPFechaNacimiento.Text = ""
        DTPFechaContrato.Text = ""
        DTPFechaFiniquito.Text = ""

        Dim Test1 As DbManager = New DbManager("ELEMENTOS_TMU", Conexion1)
        Dim query1 As String = "Select TMU_CODIGO,ELE_CODIGO,ELE_NOMBRE,ELE_UNIDAD from ELEMENTO"
        Test1.Selecccionar(Cjto_Tablas1, query1)
    End Sub

    Private Sub TxtNombreUsuario_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreUsuario.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtRut.Focus()
        End If
    End Sub


    Private Sub TxtRut_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRut.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Rescata_Datos()
            TxtApellido.Focus()
        End If
    End Sub

    Private Sub DTGElementos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGElementos.DoubleClick
        Dim Fila_Num, TMU As Integer
        Dim ELEM As String
        Dim Fila_Elementos As DataRow
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Fila_Num = myGrid.CurrentCell.RowNumber
        ELEM = myGrid.Item(Fila_Num, 1)
        TMU = myGrid.Item(Fila_Num, 0)
        Fila_Elementos = Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").NewRow
        Fila_Elementos("TMU_CODIGO") = TMU
        Fila_Elementos("ELE_CODIGO") = ELEM
        Try
            Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").Rows.Add(Fila_Elementos)
        Catch ex As Exception
            MsgBox("Código ya existe")
        End Try
    End Sub

    Private Sub TxtApellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtNombre.Focus()
        End If
    End Sub

    Private Sub TxtNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPFechaNacimiento.Focus()
        End If
    End Sub

    Private Sub DTPFechaNacimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPFechaNacimiento.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtFono.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtFono.Focus()
        End If
    End Sub

    Private Sub TxtFono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFono.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCelular.Focus()
        End If
    End Sub

    Private Sub TxtCelular_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCelular.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtCargo.Focus()
        End If
    End Sub


    Private Sub TxtCargo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCargo.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtClave.Focus()
        End If
    End Sub

    Private Sub DTPFechaContrato_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPFechaContrato.KeyPress
        If e.KeyChar = Chr(13) Then
            DTPFechaFiniquito.Focus()
        End If
    End Sub

    Private Sub DTPFechaFiniquito_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPFechaFiniquito.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtClave.Focus()
        End If
    End Sub

    Private Sub TxtClave_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtClave.KeyPress
        If e.KeyChar = Chr(13) Then
            Button2.Focus()
        End If
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        Dim respuesta As MsgBoxResult
        con.Open()
        respuesta = MsgBox("Esta seguro de eliminar : " & TxtRut.Text, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then

            consulta_nota = "DELETE FROM ANALISTA_ELEMENTO WHERE PER_RUT=" & "'" & TxtRut.Text & "'"
            Dim myCommand3 As New SqlCommand(consulta_nota, con)
            Dim myReader2 As SqlDataReader
            myReader2 = myCommand3.ExecuteReader()
            myReader2.Close()

            consulta_nota = "DELETE FROM PERSONAL WHERE PER_NOMUSU='" & TxtNombreUsuario.Text & "' AND PER_RUT=" & "'" & TxtRut.Text & "'"
            Dim myCommand4 As New SqlCommand(consulta_nota, con)
            Dim myReader4 As SqlDataReader
            myReader4 = myCommand4.ExecuteReader()
            myReader4.Close()

        End If
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'graba
        Dim FILA_DATAROW, dr As DataRow
        Dim ana_codigo, ana_neto As Double
        Dim fila, tmu_codigo, sub_codigo As Integer
        Dim Tmu_Codigo_original, Costo, Factor As Integer
        Dim Ele_codigo_original, Nivel_permiso As String
        Dim con As New SqlConnection(Conexion1)
        Dim consulta_nota, consulta_nota2 As String
        con.Open()
        Nivel_permiso = ""
        If CHKCotizador.Checked = True Then Nivel_permiso = Nivel_permiso & "01"
        If CHKIngresoOT.Checked = True Then Nivel_permiso = Nivel_permiso & "02"
        If CHKConsultaMod.Checked = True Then Nivel_permiso = Nivel_permiso & "03"
        If CHKConsultaOTHistorico.Checked = True Then Nivel_permiso = Nivel_permiso & "04"
        If CHKPlanificacion.Checked = True Then Nivel_permiso = Nivel_permiso & "05"
        If CHKDigitacion.Checked = True Then Nivel_permiso = Nivel_permiso & "06"
        If CHKRevision.Checked = True Then Nivel_permiso = Nivel_permiso & "07"
        If CHKResultados.Checked = True Then Nivel_permiso = Nivel_permiso & "08"
        If CHKDespacho.Checked = True Then Nivel_permiso = Nivel_permiso & "09"
        If CHKCobranza.Checked = True Then Nivel_permiso = Nivel_permiso & "10"
        If CHKAdministracion.Checked = True Then Nivel_permiso = Nivel_permiso & "11"
        If Me.chDFoliar.Checked = True Then Nivel_permiso = Nivel_permiso & "12"
        If Me.chDTejido.Checked = True Then Nivel_permiso = Nivel_permiso & "13"
        If Me.chDAgua.Checked = True Then Nivel_permiso = Nivel_permiso & "14"
        If Me.chDSuelo.Checked = True Then Nivel_permiso = Nivel_permiso & "15"
        If Me.chDFertQui.Checked = True Then Nivel_permiso = Nivel_permiso & "16"
        If Me.chDFertOrg.Checked = True Then Nivel_permiso = Nivel_permiso & "17"
        If Me.chDKitOtros.Checked = True Then Nivel_permiso = Nivel_permiso & "18"
        If Me.chDCodPlan.Checked = True Then Nivel_permiso = Nivel_permiso & "19"
        If Me.chDYemas.Checked = True Then Nivel_permiso = Nivel_permiso & "20"
        If Me.chDYTraspaso.Checked = True Then Nivel_permiso = Nivel_permiso & "21"
        If Me.chDYMantencion.Checked = True Then Nivel_permiso = Nivel_permiso & "22"
        If Me.chRFoliar.Checked = True Then Nivel_permiso = Nivel_permiso & "23"
        If Me.chRTejido.Checked = True Then Nivel_permiso = Nivel_permiso & "24"
        If Me.chRagua.Checked = True Then Nivel_permiso = Nivel_permiso & "25"
        If Me.chRSuelo.Checked = True Then Nivel_permiso = Nivel_permiso & "26"
        If Me.chRFertQui.Checked = True Then Nivel_permiso = Nivel_permiso & "27"
        If Me.chRFertOrg.Checked = True Then Nivel_permiso = Nivel_permiso & "28"
        If Me.chRKitOtros.Checked = True Then Nivel_permiso = Nivel_permiso & "29"
        If Me.chRListInscrip.Checked = True Then Nivel_permiso = Nivel_permiso & "30"
        If Me.chEmResultados.Checked = True Then Nivel_permiso = Nivel_permiso & "31"
        If Me.chEmYemas.Checked = True Then Nivel_permiso = Nivel_permiso & "32"
        If Me.chHorizFoliar.Checked = True Then Nivel_permiso = Nivel_permiso & "33"
        If Me.chDespacho.Checked = True Then Nivel_permiso = Nivel_permiso & "34"
        If Me.chCartaDespacho.Checked = True Then Nivel_permiso = Nivel_permiso & "35"
        If Me.chCancelFacturas.Checked = True Then Nivel_permiso = Nivel_permiso & "36"
        If Me.chLibroVentas.Checked = True Then Nivel_permiso = Nivel_permiso & "37"
        If Me.chTablas.Checked = True Then Nivel_permiso = Nivel_permiso & "38"
        If Me.chEstados.Checked = True Then Nivel_permiso = Nivel_permiso & "39"
        If Me.chTHistorico.Checked = True Then Nivel_permiso = Nivel_permiso & "40"
        If Me.chEliminaOT.Checked = True Then Nivel_permiso = Nivel_permiso & "41"
        If Me.chListados.Checked = True Then Nivel_permiso = Nivel_permiso & "42"
        If Me.chCentroCosto.Checked = True Then Nivel_permiso = Nivel_permiso & "43"
        If Me.chCodElem.Checked = True Then Nivel_permiso = Nivel_permiso & "44"
        If Me.chTipoMasc.Checked = True Then Nivel_permiso = Nivel_permiso & "45"
        If Me.chRelOTFact.Checked = True Then Nivel_permiso = Nivel_permiso & "46"
        If Me.chEspecieVariedad.Checked = True Then Nivel_permiso = Nivel_permiso & "47"
        If Me.chCondPago.Checked = True Then Nivel_permiso = Nivel_permiso & "48"
        If Me.chMuestreadores.Checked = True Then Nivel_permiso = Nivel_permiso & "49"
        If Me.chLocalidad.Checked = True Then Nivel_permiso = Nivel_permiso & "50"
        If Me.chElemento.Checked = True Then Nivel_permiso = Nivel_permiso & "51"
        If Me.chTejido.Checked = True Then Nivel_permiso = Nivel_permiso & "52"
        If Me.chProductor.Checked = True Then Nivel_permiso = Nivel_permiso & "53"
        If Me.chRangos.Checked = True Then Nivel_permiso = Nivel_permiso & "54"
        If Me.chPersonal.Checked = True Then Nivel_permiso = Nivel_permiso & "55"
        If Me.chFertilidad.Checked = True Then Nivel_permiso = Nivel_permiso & "56"
        If Me.chSalinidad.Checked = True Then Nivel_permiso = Nivel_permiso & "57"
        If Me.chEOT.Checked = True Then Nivel_permiso = Nivel_permiso & "58"
        If Me.chEFactura.Checked = True Then Nivel_permiso = Nivel_permiso & "59"
        If Me.chENlab.Checked = True Then Nivel_permiso = Nivel_permiso & "60"
        If Me.chEElementos.Checked = True Then Nivel_permiso = Nivel_permiso & "61"
        If Me.chERangoOT.Checked = True Then Nivel_permiso = Nivel_permiso & "62"
        If Me.chATdbf.Checked = True Then Nivel_permiso = Nivel_permiso & "63"
        If Me.chGeneraXml.Checked = True Then Nivel_permiso = Nivel_permiso & "64"
        If Me.cbCobranzaMod.Checked = True Then Nivel_permiso = Nivel_permiso & "65"






        consulta_nota = "INSERT INTO PERSONAL (PER_NOMUSU,PER_RUT,PER_APENOM,PER_FNACTO,PER_DIRECCION,PER_FONO,PER_CELULAR,PER_CARGO,PER_TIPO,PER_FCONTRATO,PER_FFINIQUITO,PER_PERMISO,PER_FOTO,PER_CLAVE,PER_IMPPUNTO,PER_IMPLASER) " & _
                        " VALUES ('" & TxtNombreUsuario.Text & "'," & _
                        "'" & TxtRut.Text & "','" & Me.TxtApellido.Text & " " & TxtNombre.Text & "','" & _
                        Me.DTPFechaNacimiento.Text & "','" & TxtDireccion.Text & "','" & _
                        TxtFono.Text & "','" & TxtCelular.Text & "','" & _
                        TxtCargo.Text & "','1','" & Me.DTPFechaContrato.Text & "','" & _
                        Me.DTPFechaFiniquito.Text & "','" & _
                        Nivel_permiso & "','" & TxtViaFoto.Text & "','" & TxtClave.Text & "','" & TxtImpresoraPunto.Text & "','" & TxtImpresoraLaser.Text & "')"
        Dim myCommand4 As New SqlCommand(consulta_nota, con)
        Dim myReader3 As SqlDataReader
        Try
            myReader3 = myCommand4.ExecuteReader()
            myReader3.Close()
        Catch ex As Exception

            consulta_nota = "UPDATE PERSONAL SET PER_NOMUSU='" & TxtNombreUsuario.Text & "', PER_RUT='" & TxtRut.Text & "'," & _
                            "PER_APENOM='" & TxtApellido.Text & " " & TxtNombre.Text & "'," & _
                            "PER_FNACTO='" & DTPFechaNacimiento.Text & "'," & _
                            "PER_DIRECCION='" & TxtDireccion.Text & "'," & _
                            "PER_FONO='" & TxtFono.Text & "'," & _
                            "PER_CELULAR='" & TxtCelular.Text & "'," & _
                            "PER_CARGO='" & TxtCargo.Text & "'," & _
                            "PER_TIPO='1'," & _
                            "PER_FCONTRATO='" & DTPFechaContrato.Text & "'," & _
                            "PER_FFINIQUITO='" & DTPFechaFiniquito.Text & "'," & _
                            "PER_PERMISO='" & Nivel_permiso & "'," & _
                            "PER_FOTO='" & TxtViaFoto.Text & "'," & _
                            "PER_CLAVE='" & TxtClave.Text & "'," & _
                            "PER_IMPPUNTO='" & TxtImpresoraPunto.Text & "'," & _
                            "PER_IMPLASER='" & TxtImpresoraLaser.Text & "'" & _
                            " WHERE PER_NOMUSU='" & TxtNombreUsuario.Text & "' AND PER_RUT='" & TxtRut.Text & "'"

            Dim myCommand5 As New SqlCommand(consulta_nota, con)
            Dim myReader5 As SqlDataReader

            myReader5 = myCommand5.ExecuteReader()
            myReader5.Close()
        End Try

        For Each FILA_DATAROW In Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                consulta_nota = "INSERT INTO ANALISTA_ELEMENTO (PER_RUT,TMU_CODIGO,ELE_CODIGO) " & _
                                       " VALUES (" & _
                                       "'" & TxtRut.Text & "','" & FILA_DATAROW("TMU_CODIGO") & "','" & _
                                       FILA_DATAROW("ELE_CODIGO") & "')"

                Dim myCommand6 As New SqlCommand(consulta_nota, con)
                Dim myReader6 As SqlDataReader
                Try
                    myReader6 = myCommand6.ExecuteReader()
                    myReader6.Close()
                Catch ex As Exception
                End Try
            End If
        Next

        Cjto_Tablas1.Tables("PERSONAL").Clear()
        Dim Test1 As DbManager = New DbManager("PERSONAL", Conexion1)
        Dim query1 As String = "Select * from PERSONAL"
        Test1.Selecccionar(Cjto_Tablas1, query1)

        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub BTEliminarEle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTEliminarEle.Click
        Dim cll, fila, DALE, CodM As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_ele As String
        Dim respuesta As MsgBoxResult
        cll = DTGElementosAna.CurrentCell.ColumnNumber
        fila = DTGElementosAna.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").Rows(fila)
        Cod_ele = FILA_DATAROW("ELE_CODIGO")
        CodM = FILA_DATAROW("TMU_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_ele & " Muestra : " & CodM, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            Call elimina_fila_grilla(Cod_ele, CodM, FILA_DATAROW)
        End If
    End Sub
    Private Sub elimina_fila_grilla(ByVal COD_ELE As String, ByVal codm As Integer, ByVal FILA_DATAROW As DataRow)
        Dim consulta_nota As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        consulta_nota = "DELETE FROM ANALISTA_ELEMENTO WHERE TMU_CODIGO=" & codm & " AND ELE_CODIGO='" & COD_ELE & "'"
        Dim myCommand3 As New SqlCommand(consulta_nota, con)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        con.Close()
        Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").Rows.Remove(FILA_DATAROW)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GroupBox5.Visible = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        GroupBox5.Visible = False
    End Sub

    Private Sub DTGPersonal_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTGPersonal.DoubleClick
        Dim Fila_Num As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Fila_Num = myGrid.CurrentCell.RowNumber
        TxtNombreUsuario.Text = myGrid(Fila_Num, 0)
        TxtRut.Text = myGrid(Fila_Num, 1)
        Call Rescata_Datos()
        GroupBox5.Visible = False
        TxtApellido.Focus()
    End Sub


    Private Sub Rescata_Datos()
        Dim consulta_nota, ape, nom As String
        Dim Mypos, NumPer, tt As Integer
        Dim con As New SqlConnection(Conexion1)

        DTPFechaNacimiento.Text = ""
        TxtDireccion.Text = ""
        TxtFono.Text = ""
        TxtCelular.Text = ""
        TxtCargo.Text = ""
        DTPFechaContrato.Text = ""
        DTPFechaFiniquito.Text = ""
        TxtClave.Text = ""
        TxtViaFoto.Text = ""
        TxtImpresoraPunto.Text = ""
        TxtImpresoraLaser.Text = ""

        CHKCotizador.Checked = False
        CHKIngresoOT.Checked = False
        CHKConsultaMod.Checked = False
        CHKPlanificacion.Checked = False
        CHKDigitacion.Checked = False
        CHKRevision.Checked = False
        CHKResultados.Checked = False
        CHKDespacho.Checked = False
        CHKCobranza.Checked = False
        CHKAdministracion.Checked = False

        Cjto_Tablas1.Tables("ELEMENTOS_ANALISTA").Clear()
        Dim Test1 As DbManager = New DbManager("ELEMENTOS_ANALISTA", Conexion1)
        Dim query1 As String = "Select TMU_CODIGO,ELE_CODIGO from ANALISTA_ELEMENTO WHERE PER_RUT=" & "'" & TxtRut.Text & "'"
        Test1.Selecccionar(Cjto_Tablas1, query1)

        con.Open()
        consulta_nota = " exec ls_datosPersonalMant '" & TxtNombreUsuario.Text & "','" & TxtRut.Text & "'"

        Dim myCommand5 As New SqlCommand(consulta_nota, con)
        Dim myReader5 As SqlDataReader

        myReader5 = myCommand5.ExecuteReader()
        myReader5.Read()
        'TxtRut.Text = myReader5.GetString(0)
        If IsDBNull(myReader5.GetString(0)) = False Then
            Mypos = InStr(myReader5.GetString(0), " ")
            If Mypos > 0 Then nom = Mid(myReader5.GetString(0), 1, Mypos - 1) : ape = Mid(myReader5.GetString(0), Mypos + 1)
            TxtApellido.Text = ape
            TxtNombre.Text = nom
        End If
        If IsDBNull(myReader5.GetDateTime(1)) = False Then DTPFechaNacimiento.Text = myReader5.GetDateTime(1)
        If IsDBNull(myReader5.GetString(2)) = False Then TxtDireccion.Text = myReader5.GetString(2)
        If IsDBNull(myReader5.GetString(3)) = False Then TxtFono.Text = myReader5.GetString(3)
        If IsDBNull(myReader5.GetString(4)) = False Then TxtCelular.Text = myReader5.GetString(4)
        If IsDBNull(myReader5.GetString(5)) = False Then TxtCargo.Text = myReader5.GetString(5)
        If IsDBNull(myReader5.GetDateTime(7)) = False Then DTPFechaContrato.Text = myReader5.GetDateTime(7)
        If IsDBNull(myReader5.GetDateTime(8)) = False Then DTPFechaFiniquito.Text = myReader5.GetDateTime(8)
        If IsDBNull(myReader5.GetString(10)) = False Then TxtViaFoto.Text = myReader5.GetString(10)
        If IsDBNull(myReader5.GetString(11)) = False Then TxtClave.Text = myReader5.GetString(11)
        If IsDBNull(myReader5.GetString(12)) = False Then TxtImpresoraPunto.Text = myReader5.GetString(12)
        If IsDBNull(myReader5.GetString(13)) = False Then TxtImpresoraLaser.Text = myReader5.GetString(13)

        If IsDBNull(myReader5.GetString(9)) = False Then
            For tt = 1 To Len(myReader5.GetString(9))
                If (tt Mod 2) <> 0 Or tt = 1 Then
                    NumPer = Mid(myReader5.GetString(9), tt, 2)
                    Select Case NumPer
                        Case 1
                            CHKCotizador.Checked = True
                        Case 2
                            CHKIngresoOT.Checked = True
                        Case 3
                            CHKConsultaMod.Checked = True
                        Case 4
                            CHKConsultaOTHistorico.Checked = True
                        Case 5
                            CHKPlanificacion.Checked = True
                        Case 6
                            CHKDigitacion.Checked = True
                        Case 7
                            CHKRevision.Checked = True
                        Case 8
                            CHKResultados.Checked = True
                        Case 9
                            Me.CHKDespacho.Checked = True
                        Case 10
                            Me.CHKCobranza.Checked = True
                        Case 11
                            Me.CHKAdministracion.Checked = True
                        Case 12
                            Me.chDFoliar.Checked = True
                        Case 13
                            Me.chDTejido.Checked = True
                        Case 14
                            Me.chDAgua.Checked = True
                        Case 15
                            Me.chDSuelo.Checked = True
                        Case 16
                            Me.chDFertQui.Checked = True
                        Case 17
                            Me.chDFertOrg.Checked = True
                        Case 18
                            Me.chDKitOtros.Checked = True
                        Case 19
                            Me.chDCodPlan.Checked = True
                        Case 20
                            Me.chDYemas.Checked = True
                        Case 21
                            Me.chDYTraspaso.Checked = True
                        Case 22
                            Me.chDYMantencion.Checked = True
                        Case 23
                            Me.chRFoliar.Checked = True
                        Case 24
                            Me.chRTejido.Checked = True
                        Case 25
                            Me.chRagua.Checked = True
                        Case 26
                            Me.chRSuelo.Checked = True
                        Case 27
                            Me.chRFertQui.Checked = True
                        Case 28
                            Me.chRFertOrg.Checked = True
                        Case 29
                            Me.chRKitOtros.Checked = True
                        Case 30
                            Me.chRListInscrip.Checked = True
                        Case 31
                            Me.chEmResultados.Checked = True
                        Case 32
                            Me.chEmYemas.Checked = True
                        Case 33
                            Me.chHorizFoliar.Checked = True
                        Case 34
                            Me.chDespacho.Checked = True
                        Case 35
                            Me.chCartaDespacho.Checked = True
                        Case 36
                            Me.chCancelFacturas.Checked = True
                        Case 37
                            Me.chLibroVentas.Checked = True
                        Case 38
                            Me.chTablas.Checked = True
                        Case 39
                            Me.chEstados.Checked = True
                        Case 40
                            Me.chTHistorico.Checked = True
                        Case 41
                            Me.chEliminaOT.Checked = True
                        Case 42
                            Me.chListados.Checked = True
                        Case 43
                            Me.chCentroCosto.Checked = True
                        Case 44
                            Me.chCodElem.Checked = True
                        Case 45
                            Me.chTipoMasc.Checked = True
                        Case 46
                            Me.chRelOTFact.Checked = True
                        Case 47
                            Me.chEspecieVariedad.Checked = True
                        Case 48
                            Me.chCondPago.Checked = True
                        Case 49
                            Me.chMuestreadores.Checked = True
                        Case 50
                            Me.chLocalidad.Checked = True
                        Case 51
                            Me.chElemento.Checked = True
                        Case 52
                            Me.chTejido.Checked = True
                        Case 53
                            Me.chProductor.Checked = True
                        Case 54
                            Me.chRangos.Checked = True
                        Case 55
                            Me.chPersonal.Checked = True
                        Case 56
                            Me.chFertilidad.Checked = True
                        Case 57
                            Me.chSalinidad.Checked = True
                        Case 58
                            Me.chEOT.Checked = True
                        Case 59
                            Me.chEFactura.Checked = True
                        Case 60
                            Me.chENlab.Checked = True
                        Case 61
                            Me.chEElementos.Checked = True
                        Case 62
                            Me.chERangoOT.Checked = True
                        Case 63
                            Me.chATdbf.Checked = True
                        Case 64
                            Me.chGeneraXml.Checked = True
                        Case 65
                            Me.cbCobranzaMod.Checked = True
                    End Select
                End If
            Next
        End If
        myReader5.Close()
        con.Close()
    End Sub

 
    Private Sub btnAceptaTablas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptaTablas.Click
        Me.PanelTablas.Visible = False

    End Sub

    Private Sub chTablas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chTablas.CheckedChanged
        If Me.chTablas.Checked = True Then
            Me.PanelTablas.Visible = True
        Else
            Me.PanelTablas.Visible = False
            Me.chLocalidad.Checked = False
            Me.chElemento.Checked = False
            Me.chEspecieVariedad.Checked = False
            Me.chCodElem.Checked = False
            Me.chPersonal.Checked = False
            Me.chTipoMasc.Checked = False
            Me.chTejido.Checked = False
            Me.chMuestreadores.Checked = False
            Me.chCondPago.Checked = False
            Me.chProductor.Checked = False
            Me.chRangos.Checked = False
            Me.chRelOTFact.Checked = False
        End If


    End Sub

    Private Sub CHKAdministracion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKAdministracion.CheckedChanged
        If Me.CHKAdministracion.Checked = True Then
            Me.chTablas.Enabled = True
            Me.chEstados.Enabled = True
            Me.chTHistorico.Enabled = True
            Me.chEliminaOT.Enabled = True
            Me.chListados.Enabled = True
            Me.chCentroCosto.Enabled = True
            Me.chATdbf.Enabled = True
            Me.chGeneraXml.Enabled = True
        ElseIf Me.CHKAdministracion.Checked = False Then
            Me.chTablas.Enabled = False
            Me.chEstados.Enabled = False
            Me.chTHistorico.Enabled = False
            Me.chEliminaOT.Enabled = False
            Me.chListados.Enabled = False
            Me.chCentroCosto.Enabled = False
            Me.chATdbf.Enabled = False
            Me.chATdbf.Checked = False
            Me.chTablas.Checked = False
            Me.chEstados.Checked = False
            Me.chTHistorico.Checked = False
            Me.chEliminaOT.Checked = False
            Me.chListados.Checked = False
            Me.chCentroCosto.Checked = False
            Me.chLocalidad.Checked = False
            Me.chElemento.Checked = False
            Me.chEspecieVariedad.Checked = False
            Me.chCodElem.Checked = False
            Me.chPersonal.Checked = False
            Me.chTipoMasc.Checked = False
            Me.chTejido.Checked = False
            Me.chMuestreadores.Checked = False
            Me.chCondPago.Checked = False
            Me.chProductor.Checked = False
            Me.chRangos.Checked = False
            Me.chRelOTFact.Checked = False
            Me.chEOT.Enabled = False
            Me.chEFactura.Enabled = False
            Me.chENlab.Enabled = False
            Me.chEElementos.Enabled = False
            Me.chERangoOT.Enabled = False
            Me.chGeneraXml.Enabled = False
            Me.chGeneraXml.Checked = False
            Me.chEOT.Checked = False
            Me.chEFactura.Checked = False
            Me.chENlab.Checked = False
            Me.chEElementos.Checked = False
            Me.chERangoOT.Checked = False
        End If
    End Sub

    Private Sub CHKCobranza_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKCobranza.CheckedChanged
        If Me.CHKCobranza.Checked = True Then
            Me.chCancelFacturas.Enabled = True
            Me.chLibroVentas.Enabled = True
            Me.cbCobranzaMod.Enabled = True
        ElseIf Me.CHKCobranza.Checked = False Then
            Me.chCancelFacturas.Enabled = False
            Me.chLibroVentas.Enabled = False
            Me.cbCobranzaMod.Enabled = False
            Me.cbCobranzaMod.Checked = False
            Me.chCancelFacturas.Checked = False
            Me.chLibroVentas.Checked = False
        End If
    End Sub

    Private Sub CHKDespacho_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKDespacho.CheckedChanged
        If Me.CHKDespacho.Checked = True Then
            Me.chDespacho.Enabled = True
            Me.chCartaDespacho.Enabled = True
        ElseIf Me.CHKDespacho.Checked = False Then
            Me.chDespacho.Enabled = False
            Me.chCartaDespacho.Enabled = False
            Me.chDespacho.Checked = False
            Me.chCartaDespacho.Checked = False
        End If
    End Sub

    Private Sub CHKResultados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKResultados.CheckedChanged
        If Me.CHKResultados.Checked = True Then
            Me.chEmResultados.Enabled = True
            Me.chEmYemas.Enabled = True
            Me.chHorizFoliar.Enabled = True
        ElseIf Me.CHKResultados.Checked = False Then
            Me.chEmResultados.Enabled = False
            Me.chEmYemas.Enabled = False
            Me.chHorizFoliar.Enabled = False
            Me.chEmResultados.Checked = False
            Me.chEmYemas.Checked = False
            Me.chHorizFoliar.Checked = False
        End If
    End Sub

    Private Sub CHKRevision_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKRevision.CheckedChanged
        If Me.CHKRevision.Checked = True Then
            Me.chRFoliar.Enabled = True
            Me.chRTejido.Enabled = True
            Me.chRagua.Enabled = True
            Me.chRSuelo.Enabled = True
            Me.chRFertQui.Enabled = True
            Me.chRFertOrg.Enabled = True
            Me.chRKitOtros.Enabled = True
            Me.chRListInscrip.Enabled = True
        Else
            Me.chRFoliar.Enabled = False
            Me.chRTejido.Enabled = False
            Me.chRagua.Enabled = False
            Me.chRSuelo.Enabled = False
            Me.chRFertQui.Enabled = False
            Me.chRFertOrg.Enabled = False
            Me.chRKitOtros.Enabled = False
            Me.chRListInscrip.Enabled = False
            Me.chRFoliar.Checked = False
            Me.chRTejido.Checked = False
            Me.chRagua.Checked = False
            Me.chRSuelo.Checked = False
            Me.chRFertQui.Checked = False
            Me.chRFertOrg.Checked = False
            Me.chRKitOtros.Checked = False
            Me.chRListInscrip.Checked = False
            Me.chFertilidad.Enabled = False
            Me.chSalinidad.Enabled = False
            Me.chFertilidad.Checked = False
            Me.chSalinidad.Checked = False
        End If
    End Sub

    Private Sub CHKDigitacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKDigitacion.CheckedChanged
        If Me.CHKDigitacion.Checked = True Then
            Me.chDFoliar.Enabled = True
            Me.chDTejido.Enabled = True
            Me.chDAgua.Enabled = True
            Me.chDSuelo.Enabled = True
            Me.chDFertOrg.Enabled = True
            Me.chDFertQui.Enabled = True
            Me.chDKitOtros.Enabled = True
            Me.chDCodPlan.Enabled = True
            Me.chDYemas.Enabled = True
        Else
            Me.chDFoliar.Enabled = False
            Me.chDTejido.Enabled = False
            Me.chDAgua.Enabled = False
            Me.chDSuelo.Enabled = False
            Me.chDFertOrg.Enabled = False
            Me.chDFertQui.Enabled = False
            Me.chDKitOtros.Enabled = False
            Me.chDCodPlan.Enabled = False
            Me.chDYemas.Enabled = False
            Me.chDYMantencion.Enabled = False
            Me.chDYTraspaso.Enabled = False
            Me.chDYMantencion.Checked = False
            Me.chDYTraspaso.Checked = False
            Me.chDFoliar.Checked = False
            Me.chDTejido.Checked = False
            Me.chDAgua.Checked = False
            Me.chDSuelo.Checked = False
            Me.chDFertOrg.Checked = False
            Me.chDFertQui.Checked = False
            Me.chDKitOtros.Checked = False
            Me.chDCodPlan.Checked = False
            Me.chDYemas.Checked = False
            Me.chDYMantencion.Checked = False
            Me.chDYTraspaso.Checked = False
        End If
    End Sub

    Private Sub chDYemas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chDYemas.CheckedChanged
        If Me.chDYemas.Checked = True Then
            Me.chDYMantencion.Enabled = True
            Me.chDYTraspaso.Enabled = True
        Else
            Me.chDYMantencion.Enabled = False
            Me.chDYTraspaso.Enabled = False
            Me.chDYMantencion.Checked = False
            Me.chDYTraspaso.Checked = False
        End If
    End Sub

    Private Sub chEstados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chEstados.CheckedChanged
        If Me.chEstados.Checked = True Then
            Me.chEOT.Enabled = True
            Me.chEFactura.Enabled = True
            Me.chENlab.Enabled = True
            Me.chEElementos.Enabled = True
            Me.chERangoOT.Enabled = True
        Else
            Me.chEOT.Enabled = False
            Me.chEFactura.Enabled = False
            Me.chENlab.Enabled = False
            Me.chEElementos.Enabled = False
            Me.chERangoOT.Enabled = False
            Me.chEOT.Checked = False
            Me.chEFactura.Checked = False
            Me.chENlab.Checked = False
            Me.chEElementos.Checked = False
            Me.chERangoOT.Checked = False
        End If
    End Sub

    Private Sub chRSuelo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chRSuelo.CheckedChanged
        If Me.chRSuelo.Checked = True Then
            Me.chFertilidad.Enabled = True
            Me.chSalinidad.Enabled = True
        Else
            Me.chFertilidad.Enabled = False
            Me.chSalinidad.Enabled = False
            Me.chFertilidad.Checked = False
            Me.chSalinidad.Checked = False
        End If


    End Sub
End Class
