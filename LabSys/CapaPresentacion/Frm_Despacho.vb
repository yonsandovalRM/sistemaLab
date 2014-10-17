Imports System.Math
Imports Microsoft.Office.Interop

Public Class Frm_Despacho
    Inherits System.Windows.Forms.Form
    Dim Fila_Lectura As Integer
    Public Abono, Total, SubTotal, Muestreo, Neto, Iva, CantMuestreo, TotalDesc As Integer
    Public RutFactura, RutProductor As String
    Public NumOT, NumFactura As Integer
    Public EstadoGlo As String
    Public Estado As String
    Public Arreglo_OT(10) As Integer
    Friend WithEvents CBCalcular As System.Windows.Forms.Button
    Friend WithEvents TxtDespachoFax2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoFax1 As System.Windows.Forms.TextBox
    Friend WithEvents Cbx_CondPago As System.Windows.Forms.ComboBox
    Friend WithEvents Rdb_ResyFact As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Factura As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Resultados As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cb_condpago As System.Windows.Forms.ComboBox
    Friend WithEvents ElTab1 As Klik.Windows.Forms.v1.EntryLib.ELTab
    Friend WithEvents ElTabPage1 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ElTabPage2 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents ElTabPage3 As Klik.Windows.Forms.v1.EntryLib.ELTabPage
    Friend WithEvents txt_son As System.Windows.Forms.TextBox
    Friend WithEvents chk_FacElectronica As System.Windows.Forms.CheckBox
    Friend WithEvents TxtFechaRetiro As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private i As Integer = 1

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
    Friend WithEvents Dtg_DespachoResumen As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Cjto_Tablas1 As LabSys.Cjto_Tablas
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents CbxUrgente As System.Windows.Forms.CheckBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CbxDespRetiraLab As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDespachoNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoAtencion As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents CbxDespEmail As System.Windows.Forms.CheckBox
    Friend WithEvents CbxDespFax As System.Windows.Forms.CheckBox
    Friend WithEvents CbxDespCorreo As System.Windows.Forms.CheckBox
    Friend WithEvents CbxDespBus As System.Windows.Forms.CheckBox
    Friend WithEvents CbxDespAvisoFono As System.Windows.Forms.CheckBox
    Friend WithEvents CbxDespOtro As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDespOtra As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TxtDespachoDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents TxtDespachoCasilla As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents DTPDespachoFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents TxtDespachoEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents TxtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtEntrego As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Dtg_SeleccionDatos As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtObsPago As System.Windows.Forms.TextBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents TxtFonoPago1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFonoPago2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtEncPago As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdenCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents TxtFono1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtSolicitadoPor As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtGiro As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtFono2 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GRBRecibo As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents TxtRutRetira As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TxtNombreRetira As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtRecintoRetira As System.Windows.Forms.TextBox
    Friend WithEvents GRBAbono As System.Windows.Forms.GroupBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents ChkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents RdbAbonoEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RdbAbonoCheque As System.Windows.Forms.RadioButton
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents TxtAbono As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GRBMuestreo As System.Windows.Forms.GroupBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreoPrecioUn As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreoCant As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents GRBTotales As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents TxtDesctPesos As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescto As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents TxtRutFacturacion As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_DesComuna As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesCiudad As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Txt_DesFacSeñores As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacComuna As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Txt_DesFacObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacF1Pago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacF2Pago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacEncPago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacOCompra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacF1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacSolicita As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacGiro As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacF2 As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Seleccionado As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn50 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn51 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn55 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn57 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn59 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn60 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn61 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn62 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn63 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Txt_RSocial As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Ciudad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Empresa As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Comuna As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_SelFactura As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn88 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn89 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Check_Correo As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Bus As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Fax As System.Windows.Forms.CheckBox
    Friend WithEvents Check_Email As System.Windows.Forms.CheckBox
    Friend WithEvents Check_RetLab As System.Windows.Forms.CheckBox
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Gbx_DatDesp As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_DespFacFono2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacFono1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacCasilla As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DespFacCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DespFacComuna As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacDirec As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacIngSr As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacAtencion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacRetira As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DespFacObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DesFacEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Txt_DesFacEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Txt_DesFacFax1 As System.Windows.Forms.TextBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Txt_DesFacFax2 As System.Windows.Forms.TextBox
    Friend WithEvents Bt_Grabar As System.Windows.Forms.Button
    Friend WithEvents Bt_GrabaFactura As System.Windows.Forms.Button
    Friend WithEvents Chk_Nomina As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_ImpFacRes As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_ImpFactyCart As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_ImpFact As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_ImpResyCart As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_ImpRes As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_ImpFacResCart As System.Windows.Forms.RadioButton
    Friend WithEvents Bt_Aceptar As System.Windows.Forms.Button
    Friend WithEvents Rdb_EnvEmail As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn68 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn69 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn70 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn71 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn72 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn73 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn74 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn75 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn76 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn77 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn78 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn79 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn80 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn81 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn82 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn83 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn84 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn85 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn86 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn87 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Rdb_Nomina As System.Windows.Forms.RadioButton
    Friend WithEvents DTPFechaIng As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtDespachoFono1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoFono2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoCelular1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDespachoCelular2 As System.Windows.Forms.TextBox
    Friend WithEvents Bt_AceptaQuery As System.Windows.Forms.Button
    Friend WithEvents Rdb_Despacho As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Facturar As System.Windows.Forms.RadioButton
    Friend WithEvents Txtfactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtFechaCancelacion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GRBRecibo = New System.Windows.Forms.GroupBox
        Me.TxtFechaRetiro = New System.Windows.Forms.TextBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.TxtRutRetira = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.TxtNombreRetira = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtRecintoRetira = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Rdb_Facturar = New System.Windows.Forms.RadioButton
        Me.Label15 = New System.Windows.Forms.Label
        Me.Rdb_Despacho = New System.Windows.Forms.RadioButton
        Me.Bt_AceptaQuery = New System.Windows.Forms.Button
        Me.Dtg_DespachoResumen = New System.Windows.Forms.DataGrid
        Me.Cjto_Tablas1 = New LabSys.Cjto_Tablas
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
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
        Me.Dtg_Seleccionado = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn50 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn51 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn55 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn57 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn59 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn60 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn61 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn62 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn63 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Cbx_CondPago = New System.Windows.Forms.ComboBox
        Me.Bt_GrabaFactura = New System.Windows.Forms.Button
        Me.Label84 = New System.Windows.Forms.Label
        Me.Txt_DesFacComuna = New System.Windows.Forms.TextBox
        Me.Txt_DesFacEmpresa = New System.Windows.Forms.TextBox
        Me.Txt_DesFacCiudad = New System.Windows.Forms.TextBox
        Me.Txt_DesFacSeñores = New System.Windows.Forms.TextBox
        Me.Txt_DesFacObservacion = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Txt_DesFacF1Pago = New System.Windows.Forms.TextBox
        Me.Txt_DesFacF2Pago = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.Txt_DesFacEncPago = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.Txt_DesFacOCompra = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.Txt_DesFacF1 = New System.Windows.Forms.TextBox
        Me.Txt_DesFacSolicita = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Txt_DesFacGiro = New System.Windows.Forms.TextBox
        Me.Txt_DesFacDireccion = New System.Windows.Forms.TextBox
        Me.Txt_DesFacF2 = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.TxtDespachoFax2 = New System.Windows.Forms.TextBox
        Me.TxtDespachoFax1 = New System.Windows.Forms.TextBox
        Me.TxtDespachoCelular2 = New System.Windows.Forms.TextBox
        Me.TxtDespachoCelular1 = New System.Windows.Forms.TextBox
        Me.TxtDespachoFono2 = New System.Windows.Forms.TextBox
        Me.TxtDespachoFono1 = New System.Windows.Forms.TextBox
        Me.Bt_Grabar = New System.Windows.Forms.Button
        Me.Txt_DesCiudad = New System.Windows.Forms.TextBox
        Me.Txt_DesComuna = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.TxtObservaciones = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtEntrego = New System.Windows.Forms.TextBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.CbxUrgente = New System.Windows.Forms.CheckBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.CbxDespRetiraLab = New System.Windows.Forms.CheckBox
        Me.TxtDespachoNombre = New System.Windows.Forms.TextBox
        Me.TxtDespachoAtencion = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.CbxDespEmail = New System.Windows.Forms.CheckBox
        Me.CbxDespFax = New System.Windows.Forms.CheckBox
        Me.CbxDespCorreo = New System.Windows.Forms.CheckBox
        Me.CbxDespBus = New System.Windows.Forms.CheckBox
        Me.CbxDespAvisoFono = New System.Windows.Forms.CheckBox
        Me.CbxDespOtro = New System.Windows.Forms.CheckBox
        Me.TxtDespOtra = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.TxtDespachoDireccion = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.TxtDespachoCasilla = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.DTPDespachoFecha = New System.Windows.Forms.DateTimePicker
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label36 = New System.Windows.Forms.Label
        Me.TxtDespachoEmail1 = New System.Windows.Forms.TextBox
        Me.TxtDespachoEmail2 = New System.Windows.Forms.TextBox
        Me.Dtg_SeleccionDatos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn88 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn89 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Rdb_Nomina = New System.Windows.Forms.RadioButton
        Me.Rdb_EnvEmail = New System.Windows.Forms.RadioButton
        Me.Bt_Aceptar = New System.Windows.Forms.Button
        Me.Rdb_ImpFacResCart = New System.Windows.Forms.RadioButton
        Me.Rdb_ImpFacRes = New System.Windows.Forms.RadioButton
        Me.Rdb_ImpFactyCart = New System.Windows.Forms.RadioButton
        Me.Rdb_ImpFact = New System.Windows.Forms.RadioButton
        Me.Rdb_ImpResyCart = New System.Windows.Forms.RadioButton
        Me.Rdb_ImpRes = New System.Windows.Forms.RadioButton
        Me.Rdb_Resultados = New System.Windows.Forms.RadioButton
        Me.Rdb_Factura = New System.Windows.Forms.RadioButton
        Me.Rdb_ResyFact = New System.Windows.Forms.RadioButton
        Me.Txtfactura = New System.Windows.Forms.TextBox
        Me.DTPFechaIng = New System.Windows.Forms.DateTimePicker
        Me.Gbx_DatDesp = New System.Windows.Forms.GroupBox
        Me.Txt_DesFacFax2 = New System.Windows.Forms.TextBox
        Me.Txt_DesFacFax1 = New System.Windows.Forms.TextBox
        Me.Label94 = New System.Windows.Forms.Label
        Me.Txt_DesFacEmail2 = New System.Windows.Forms.TextBox
        Me.Label89 = New System.Windows.Forms.Label
        Me.Txt_DesFacEmail1 = New System.Windows.Forms.TextBox
        Me.Label85 = New System.Windows.Forms.Label
        Me.Txt_DespFacFono2 = New System.Windows.Forms.TextBox
        Me.Txt_DesFacFono1 = New System.Windows.Forms.TextBox
        Me.Label120 = New System.Windows.Forms.Label
        Me.Txt_DesFacCasilla = New System.Windows.Forms.TextBox
        Me.Label121 = New System.Windows.Forms.Label
        Me.Txt_DespFacCiudad = New System.Windows.Forms.TextBox
        Me.Label122 = New System.Windows.Forms.Label
        Me.Txt_DespFacComuna = New System.Windows.Forms.TextBox
        Me.Label123 = New System.Windows.Forms.Label
        Me.Txt_DesFacDirec = New System.Windows.Forms.TextBox
        Me.Label124 = New System.Windows.Forms.Label
        Me.Txt_DesFacIngSr = New System.Windows.Forms.TextBox
        Me.Label125 = New System.Windows.Forms.Label
        Me.Txt_DesFacAtencion = New System.Windows.Forms.TextBox
        Me.Label126 = New System.Windows.Forms.Label
        Me.Txt_DesFacRetira = New System.Windows.Forms.TextBox
        Me.Label127 = New System.Windows.Forms.Label
        Me.Txt_DespFacObservacion = New System.Windows.Forms.TextBox
        Me.Label128 = New System.Windows.Forms.Label
        Me.Dtg_SelFactura = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn68 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn69 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn70 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn71 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn72 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn73 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn74 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn75 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn76 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn77 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn78 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn79 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn80 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn81 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn82 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn83 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn84 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn85 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn86 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn87 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Check_Correo = New System.Windows.Forms.CheckBox
        Me.Check_Bus = New System.Windows.Forms.CheckBox
        Me.Chk_Nomina = New System.Windows.Forms.CheckBox
        Me.Check_Fax = New System.Windows.Forms.CheckBox
        Me.Check_Email = New System.Windows.Forms.CheckBox
        Me.Check_RetLab = New System.Windows.Forms.CheckBox
        Me.Label96 = New System.Windows.Forms.Label
        Me.TxtRutFacturacion = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.GRBAbono = New System.Windows.Forms.GroupBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.ChkCancelado = New System.Windows.Forms.CheckBox
        Me.Label91 = New System.Windows.Forms.Label
        Me.RdbAbonoEfectivo = New System.Windows.Forms.RadioButton
        Me.RdbAbonoCheque = New System.Windows.Forms.RadioButton
        Me.Label90 = New System.Windows.Forms.Label
        Me.TxtAbono = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.TxtFechaCancelacion = New System.Windows.Forms.TextBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.GRBMuestreo = New System.Windows.Forms.GroupBox
        Me.CBCalcular = New System.Windows.Forms.Button
        Me.Label86 = New System.Windows.Forms.Label
        Me.TxtMuestreoPrecioUn = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.TxtMuestreoCant = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.GRBTotales = New System.Windows.Forms.GroupBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.TxtIva = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.TxtMuestreo = New System.Windows.Forms.TextBox
        Me.TxtNeto = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.TxtSubTotal = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.TxtDesctPesos = New System.Windows.Forms.TextBox
        Me.TxtDescto = New System.Windows.Forms.TextBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cb_condpago = New System.Windows.Forms.ComboBox
        Me.Txt_Comuna = New System.Windows.Forms.TextBox
        Me.Txt_Empresa = New System.Windows.Forms.TextBox
        Me.Txt_Ciudad = New System.Windows.Forms.TextBox
        Me.Txt_RSocial = New System.Windows.Forms.TextBox
        Me.TxtObsPago = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.TxtFonoPago1 = New System.Windows.Forms.TextBox
        Me.TxtFonoPago2 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.TxtEncPago = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.TxtOrdenCompra = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.TxtFono1 = New System.Windows.Forms.TextBox
        Me.TxtSolicitadoPor = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.TxtGiro = New System.Windows.Forms.TextBox
        Me.TxtDireccion = New System.Windows.Forms.TextBox
        Me.TxtFono2 = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.ElTab1 = New Klik.Windows.Forms.v1.EntryLib.ELTab
        Me.ElTabPage1 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.ElTabPage2 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage
        Me.ElTabPage3 = New Klik.Windows.Forms.v1.EntryLib.ELTabPage
        Me.chk_FacElectronica = New System.Windows.Forms.CheckBox
        Me.txt_son = New System.Windows.Forms.TextBox
        Me.GRBRecibo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_DespachoResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_Seleccionado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.Dtg_SeleccionDatos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Gbx_DatDesp.SuspendLayout()
        CType(Me.Dtg_SelFactura, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRBAbono.SuspendLayout()
        Me.GRBMuestreo.SuspendLayout()
        Me.GRBTotales.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.ElTab1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTab1.SuspendLayout()
        CType(Me.ElTabPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage1.SuspendLayout()
        CType(Me.ElTabPage2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage2.SuspendLayout()
        CType(Me.ElTabPage3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ElTabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRBRecibo
        '
        Me.GRBRecibo.Controls.Add(Me.TxtFechaRetiro)
        Me.GRBRecibo.Controls.Add(Me.Label44)
        Me.GRBRecibo.Controls.Add(Me.Label45)
        Me.GRBRecibo.Controls.Add(Me.Label46)
        Me.GRBRecibo.Controls.Add(Me.TxtRutRetira)
        Me.GRBRecibo.Controls.Add(Me.Label47)
        Me.GRBRecibo.Controls.Add(Me.TxtNombreRetira)
        Me.GRBRecibo.Controls.Add(Me.Label48)
        Me.GRBRecibo.Controls.Add(Me.TxtRecintoRetira)
        Me.GRBRecibo.Controls.Add(Me.DateTimePicker1)
        Me.GRBRecibo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBRecibo.Location = New System.Drawing.Point(3, 726)
        Me.GRBRecibo.Name = "GRBRecibo"
        Me.GRBRecibo.Size = New System.Drawing.Size(297, 162)
        Me.GRBRecibo.TabIndex = 183
        Me.GRBRecibo.TabStop = False
        Me.GRBRecibo.Text = "Acuso recibo"
        '
        'TxtFechaRetiro
        '
        Me.TxtFechaRetiro.Location = New System.Drawing.Point(80, 80)
        Me.TxtFechaRetiro.Name = "TxtFechaRetiro"
        Me.TxtFechaRetiro.Size = New System.Drawing.Size(104, 21)
        Me.TxtFechaRetiro.TabIndex = 215
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label44.Location = New System.Drawing.Point(184, 56)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(96, 16)
        Me.Label44.TabIndex = 172
        Me.Label44.Text = "(ej.: 9999999-9)"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(8, 104)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(56, 16)
        Me.Label45.TabIndex = 101
        Me.Label45.Text = "Recinto"
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(8, 82)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(56, 16)
        Me.Label46.TabIndex = 34
        Me.Label46.Text = "F.Retiro"
        '
        'TxtRutRetira
        '
        Me.TxtRutRetira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRutRetira.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRutRetira.Location = New System.Drawing.Point(80, 56)
        Me.TxtRutRetira.Name = "TxtRutRetira"
        Me.TxtRutRetira.Size = New System.Drawing.Size(104, 21)
        Me.TxtRutRetira.TabIndex = 29
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(8, 56)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(56, 16)
        Me.Label47.TabIndex = 33
        Me.Label47.Text = "RUT"
        '
        'TxtNombreRetira
        '
        Me.TxtNombreRetira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNombreRetira.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreRetira.Location = New System.Drawing.Point(80, 32)
        Me.TxtNombreRetira.Name = "TxtNombreRetira"
        Me.TxtNombreRetira.Size = New System.Drawing.Size(200, 21)
        Me.TxtNombreRetira.TabIndex = 11
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(8, 32)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(56, 16)
        Me.Label48.TabIndex = 32
        Me.Label48.Text = "Nombre"
        '
        'TxtRecintoRetira
        '
        Me.TxtRecintoRetira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRecintoRetira.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRecintoRetira.Location = New System.Drawing.Point(80, 104)
        Me.TxtRecintoRetira.Name = "TxtRecintoRetira"
        Me.TxtRecintoRetira.Size = New System.Drawing.Size(200, 21)
        Me.TxtRecintoRetira.TabIndex = 100
        Me.TxtRecintoRetira.Text = "Laboratorio Agrolab"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(177, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(24, 21)
        Me.DateTimePicker1.TabIndex = 215
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rdb_Facturar)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Rdb_Despacho)
        Me.GroupBox1.Location = New System.Drawing.Point(807, 719)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 40)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        '
        'Rdb_Facturar
        '
        Me.Rdb_Facturar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Facturar.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Facturar.Location = New System.Drawing.Point(224, 16)
        Me.Rdb_Facturar.Name = "Rdb_Facturar"
        Me.Rdb_Facturar.Size = New System.Drawing.Size(104, 16)
        Me.Rdb_Facturar.TabIndex = 29
        Me.Rdb_Facturar.Text = "Factura: xF"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(8, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Estados OT"
        '
        'Rdb_Despacho
        '
        Me.Rdb_Despacho.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Despacho.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Despacho.Location = New System.Drawing.Point(104, 16)
        Me.Rdb_Despacho.Name = "Rdb_Despacho"
        Me.Rdb_Despacho.Size = New System.Drawing.Size(104, 16)
        Me.Rdb_Despacho.TabIndex = 28
        Me.Rdb_Despacho.Text = "Análisis: xDe"
        '
        'Bt_AceptaQuery
        '
        Me.Bt_AceptaQuery.BackColor = System.Drawing.Color.Transparent
        Me.Bt_AceptaQuery.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_AceptaQuery.Image = Global.LabSys.My.Resources.Resources.accept
        Me.Bt_AceptaQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_AceptaQuery.Location = New System.Drawing.Point(1157, 735)
        Me.Bt_AceptaQuery.Name = "Bt_AceptaQuery"
        Me.Bt_AceptaQuery.Size = New System.Drawing.Size(74, 24)
        Me.Bt_AceptaQuery.TabIndex = 26
        Me.Bt_AceptaQuery.Text = "Aceptar"
        Me.Bt_AceptaQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_AceptaQuery.UseVisualStyleBackColor = False
        '
        'Dtg_DespachoResumen
        '
        Me.Dtg_DespachoResumen.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dtg_DespachoResumen.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Dtg_DespachoResumen.CaptionVisible = False
        Me.Dtg_DespachoResumen.DataMember = "DESPACHO"
        Me.Dtg_DespachoResumen.DataSource = Me.Cjto_Tablas1
        Me.Dtg_DespachoResumen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_DespachoResumen.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_DespachoResumen.Location = New System.Drawing.Point(3, 31)
        Me.Dtg_DespachoResumen.Name = "Dtg_DespachoResumen"
        Me.Dtg_DespachoResumen.Size = New System.Drawing.Size(1248, 658)
        Me.Dtg_DespachoResumen.TabIndex = 0
        Me.Dtg_DespachoResumen.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Cjto_Tablas1
        '
        Me.Cjto_Tablas1.DataSetName = "Cjto_Tablas"
        Me.Cjto_Tablas1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Cjto_Tablas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_DespachoResumen
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "DESPACHO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N° Ot"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NUMERO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "F.Ingreso"
        Me.DataGridTextBoxColumn2.MappingName = "OT_FECHA_ORDEN"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 65
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Productor"
        Me.DataGridTextBoxColumn3.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 278
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Rut Productor"
        Me.DataGridTextBoxColumn4.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Rut Factura"
        Me.DataGridTextBoxColumn5.MappingName = "OT_FAC_RUT"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 80
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn6.MappingName = "OT_EMPRESA"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Remite"
        Me.DataGridTextBoxColumn7.MappingName = "OT_REMITE"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn8.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 40
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Cant"
        Me.DataGridTextBoxColumn9.MappingName = "OTC_CANT_MUESTRAS"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 35
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Desde"
        Me.DataGridTextBoxColumn10.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Ana"
        Me.DataGridTextBoxColumn11.MappingName = "OT_ESTADO_ANA"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 35
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Pag"
        Me.DataGridTextBoxColumn12.MappingName = "OT_ESTADO_PAG"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 35
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Fac"
        Me.DataGridTextBoxColumn13.MappingName = "OT_ESTADO_FAC"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 35
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Número"
        Me.DataGridTextBoxColumn14.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 50
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn15.MappingName = "FAC_FECHA"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 50
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Est"
        Me.DataGridTextBoxColumn16.MappingName = "FAC_ESTADO"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 30
        '
        'Dtg_Seleccionado
        '
        Me.Dtg_Seleccionado.CaptionVisible = False
        Me.Dtg_Seleccionado.DataMember = "DESPACHO_RESULTADO1"
        Me.Dtg_Seleccionado.DataSource = Me.Cjto_Tablas1
        Me.Dtg_Seleccionado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Seleccionado.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Seleccionado.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Seleccionado.Location = New System.Drawing.Point(3, 763)
        Me.Dtg_Seleccionado.Name = "Dtg_Seleccionado"
        Me.Dtg_Seleccionado.Size = New System.Drawing.Size(1256, 152)
        Me.Dtg_Seleccionado.TabIndex = 15
        Me.Dtg_Seleccionado.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.Dtg_Seleccionado
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn47, Me.DataGridTextBoxColumn48, Me.DataGridTextBoxColumn49, Me.DataGridTextBoxColumn50, Me.DataGridTextBoxColumn51, Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54, Me.DataGridTextBoxColumn55, Me.DataGridTextBoxColumn56, Me.DataGridTextBoxColumn57, Me.DataGridTextBoxColumn58, Me.DataGridTextBoxColumn59, Me.DataGridTextBoxColumn60, Me.DataGridTextBoxColumn61, Me.DataGridTextBoxColumn62, Me.DataGridTextBoxColumn63})
        Me.DataGridTableStyle5.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "DESPACHO_RESULTADO1"
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "N°Ot"
        Me.DataGridTextBoxColumn46.MappingName = "OT_NUMERO"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 50
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn47.Format = ""
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "F.Ingreso"
        Me.DataGridTextBoxColumn47.MappingName = "OT_FECHA_ORDEN"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.Width = 60
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Format = ""
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "Productor"
        Me.DataGridTextBoxColumn48.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 180
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.HeaderText = "Rut Productor"
        Me.DataGridTextBoxColumn49.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 77
        '
        'DataGridTextBoxColumn50
        '
        Me.DataGridTextBoxColumn50.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn50.Format = ""
        Me.DataGridTextBoxColumn50.FormatInfo = Nothing
        Me.DataGridTextBoxColumn50.HeaderText = "Rut Factura"
        Me.DataGridTextBoxColumn50.MappingName = "OT_FAC_RUT"
        Me.DataGridTextBoxColumn50.NullText = ""
        Me.DataGridTextBoxColumn50.Width = 77
        '
        'DataGridTextBoxColumn51
        '
        Me.DataGridTextBoxColumn51.Format = ""
        Me.DataGridTextBoxColumn51.FormatInfo = Nothing
        Me.DataGridTextBoxColumn51.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn51.MappingName = "OT_EMPRESA"
        Me.DataGridTextBoxColumn51.NullText = ""
        Me.DataGridTextBoxColumn51.Width = 180
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn52.Format = ""
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "Remite"
        Me.DataGridTextBoxColumn52.MappingName = "OT_REMITE"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 80
        '
        'DataGridTextBoxColumn53
        '
        Me.DataGridTextBoxColumn53.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn53.Format = ""
        Me.DataGridTextBoxColumn53.FormatInfo = Nothing
        Me.DataGridTextBoxColumn53.HeaderText = "Solicita"
        Me.DataGridTextBoxColumn53.MappingName = "OT_SOL_NOMBRE"
        Me.DataGridTextBoxColumn53.NullText = ""
        Me.DataGridTextBoxColumn53.Width = 80
        '
        'DataGridTextBoxColumn54
        '
        Me.DataGridTextBoxColumn54.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn54.Format = ""
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "Atención"
        Me.DataGridTextBoxColumn54.MappingName = "OT_DESP_ATENCION"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 80
        '
        'DataGridTextBoxColumn55
        '
        Me.DataGridTextBoxColumn55.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn55.Format = ""
        Me.DataGridTextBoxColumn55.FormatInfo = Nothing
        Me.DataGridTextBoxColumn55.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn55.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn55.NullText = ""
        Me.DataGridTextBoxColumn55.Width = 40
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn56.Format = ""
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.HeaderText = "Cant"
        Me.DataGridTextBoxColumn56.MappingName = "OTC_CANT_MUESTRAS"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 30
        '
        'DataGridTextBoxColumn57
        '
        Me.DataGridTextBoxColumn57.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn57.Format = ""
        Me.DataGridTextBoxColumn57.FormatInfo = Nothing
        Me.DataGridTextBoxColumn57.HeaderText = "Desde"
        Me.DataGridTextBoxColumn57.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn57.NullText = ""
        Me.DataGridTextBoxColumn57.Width = 50
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "Ana"
        Me.DataGridTextBoxColumn58.MappingName = "OT_ESTADO_ANA"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 30
        '
        'DataGridTextBoxColumn59
        '
        Me.DataGridTextBoxColumn59.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn59.Format = ""
        Me.DataGridTextBoxColumn59.FormatInfo = Nothing
        Me.DataGridTextBoxColumn59.HeaderText = "Pag"
        Me.DataGridTextBoxColumn59.MappingName = "OT_ESTADO_PAG"
        Me.DataGridTextBoxColumn59.NullText = ""
        Me.DataGridTextBoxColumn59.Width = 30
        '
        'DataGridTextBoxColumn60
        '
        Me.DataGridTextBoxColumn60.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn60.Format = ""
        Me.DataGridTextBoxColumn60.FormatInfo = Nothing
        Me.DataGridTextBoxColumn60.HeaderText = "Fac"
        Me.DataGridTextBoxColumn60.MappingName = "OT_ESTADO_FAC"
        Me.DataGridTextBoxColumn60.NullText = ""
        Me.DataGridTextBoxColumn60.Width = 30
        '
        'DataGridTextBoxColumn61
        '
        Me.DataGridTextBoxColumn61.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn61.Format = ""
        Me.DataGridTextBoxColumn61.FormatInfo = Nothing
        Me.DataGridTextBoxColumn61.HeaderText = "Número"
        Me.DataGridTextBoxColumn61.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn61.NullText = ""
        Me.DataGridTextBoxColumn61.Width = 50
        '
        'DataGridTextBoxColumn62
        '
        Me.DataGridTextBoxColumn62.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn62.Format = ""
        Me.DataGridTextBoxColumn62.FormatInfo = Nothing
        Me.DataGridTextBoxColumn62.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn62.MappingName = "FAC_FECHA"
        Me.DataGridTextBoxColumn62.NullText = ""
        Me.DataGridTextBoxColumn62.Width = 50
        '
        'DataGridTextBoxColumn63
        '
        Me.DataGridTextBoxColumn63.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn63.Format = ""
        Me.DataGridTextBoxColumn63.FormatInfo = Nothing
        Me.DataGridTextBoxColumn63.HeaderText = "Est"
        Me.DataGridTextBoxColumn63.MappingName = "FAC_ESTADO"
        Me.DataGridTextBoxColumn63.NullText = ""
        Me.DataGridTextBoxColumn63.Width = 30
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = "FACTURA_DETALLE_DESPACHO"
        Me.DataGrid2.DataSource = Me.Cjto_Tablas1
        Me.DataGrid2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(3, 613)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(902, 142)
        Me.DataGrid2.TabIndex = 14
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn40, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "FACTURA_DETALLE_DESPACHO"
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Cod"
        Me.DataGridTextBoxColumn40.MappingName = "DET_CODIGO"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 45
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn41.MappingName = "DET_DETALLE"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 600
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "Cant"
        Me.DataGridTextBoxColumn42.MappingName = "DET_CANTIDAD"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.Width = 50
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn43.Format = ""
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.HeaderText = "$ Unitario"
        Me.DataGridTextBoxColumn43.MappingName = "DET_PUNITARIO"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 75
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "$ Total"
        Me.DataGridTextBoxColumn44.MappingName = "DET_TOTAL"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 75
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = ""
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.Width = 75
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Cbx_CondPago)
        Me.GroupBox2.Controls.Add(Me.Bt_GrabaFactura)
        Me.GroupBox2.Controls.Add(Me.Label84)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacComuna)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacEmpresa)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacCiudad)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacSeñores)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacObservacion)
        Me.GroupBox2.Controls.Add(Me.Label65)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacF1Pago)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacF2Pago)
        Me.GroupBox2.Controls.Add(Me.Label66)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacEncPago)
        Me.GroupBox2.Controls.Add(Me.Label67)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacOCompra)
        Me.GroupBox2.Controls.Add(Me.Label68)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacF1)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacSolicita)
        Me.GroupBox2.Controls.Add(Me.Label69)
        Me.GroupBox2.Controls.Add(Me.Label72)
        Me.GroupBox2.Controls.Add(Me.Label73)
        Me.GroupBox2.Controls.Add(Me.Label74)
        Me.GroupBox2.Controls.Add(Me.Label75)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacGiro)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacDireccion)
        Me.GroupBox2.Controls.Add(Me.Txt_DesFacF2)
        Me.GroupBox2.Controls.Add(Me.Label76)
        Me.GroupBox2.Controls.Add(Me.Label77)
        Me.GroupBox2.Controls.Add(Me.Label78)
        Me.GroupBox2.Controls.Add(Me.Label79)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(3, 434)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1248, 172)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Cbx_CondPago
        '
        Me.Cbx_CondPago.FormattingEnabled = True
        Me.Cbx_CondPago.Location = New System.Drawing.Point(560, 86)
        Me.Cbx_CondPago.Name = "Cbx_CondPago"
        Me.Cbx_CondPago.Size = New System.Drawing.Size(163, 23)
        Me.Cbx_CondPago.TabIndex = 171
        '
        'Bt_GrabaFactura
        '
        Me.Bt_GrabaFactura.BackColor = System.Drawing.Color.Transparent
        Me.Bt_GrabaFactura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_GrabaFactura.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_GrabaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_GrabaFactura.Location = New System.Drawing.Point(1160, 144)
        Me.Bt_GrabaFactura.Name = "Bt_GrabaFactura"
        Me.Bt_GrabaFactura.Size = New System.Drawing.Size(80, 24)
        Me.Bt_GrabaFactura.TabIndex = 170
        Me.Bt_GrabaFactura.Text = "Grabar"
        Me.Bt_GrabaFactura.UseVisualStyleBackColor = False
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(16, 16)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(96, 16)
        Me.Label84.TabIndex = 169
        Me.Label84.Text = "FACTURA :"
        '
        'Txt_DesFacComuna
        '
        Me.Txt_DesFacComuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacComuna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacComuna.Location = New System.Drawing.Point(960, 64)
        Me.Txt_DesFacComuna.MaxLength = 15
        Me.Txt_DesFacComuna.Name = "Txt_DesFacComuna"
        Me.Txt_DesFacComuna.Size = New System.Drawing.Size(200, 20)
        Me.Txt_DesFacComuna.TabIndex = 168
        '
        'Txt_DesFacEmpresa
        '
        Me.Txt_DesFacEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacEmpresa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacEmpresa.Location = New System.Drawing.Point(960, 40)
        Me.Txt_DesFacEmpresa.MaxLength = 15
        Me.Txt_DesFacEmpresa.Name = "Txt_DesFacEmpresa"
        Me.Txt_DesFacEmpresa.Size = New System.Drawing.Size(200, 20)
        Me.Txt_DesFacEmpresa.TabIndex = 167
        '
        'Txt_DesFacCiudad
        '
        Me.Txt_DesFacCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacCiudad.Location = New System.Drawing.Point(560, 40)
        Me.Txt_DesFacCiudad.MaxLength = 35
        Me.Txt_DesFacCiudad.Name = "Txt_DesFacCiudad"
        Me.Txt_DesFacCiudad.Size = New System.Drawing.Size(163, 20)
        Me.Txt_DesFacCiudad.TabIndex = 166
        '
        'Txt_DesFacSeñores
        '
        Me.Txt_DesFacSeñores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacSeñores.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacSeñores.Location = New System.Drawing.Point(120, 40)
        Me.Txt_DesFacSeñores.MaxLength = 35
        Me.Txt_DesFacSeñores.Name = "Txt_DesFacSeñores"
        Me.Txt_DesFacSeñores.Size = New System.Drawing.Size(240, 20)
        Me.Txt_DesFacSeñores.TabIndex = 165
        '
        'Txt_DesFacObservacion
        '
        Me.Txt_DesFacObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacObservacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacObservacion.Location = New System.Drawing.Point(960, 112)
        Me.Txt_DesFacObservacion.MaxLength = 15
        Me.Txt_DesFacObservacion.Name = "Txt_DesFacObservacion"
        Me.Txt_DesFacObservacion.Size = New System.Drawing.Size(232, 20)
        Me.Txt_DesFacObservacion.TabIndex = 164
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Black
        Me.Label65.Location = New System.Drawing.Point(896, 112)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(64, 16)
        Me.Label65.TabIndex = 163
        Me.Label65.Text = "Obs. Pago"
        '
        'Txt_DesFacF1Pago
        '
        Me.Txt_DesFacF1Pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacF1Pago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacF1Pago.Location = New System.Drawing.Point(560, 112)
        Me.Txt_DesFacF1Pago.MaxLength = 15
        Me.Txt_DesFacF1Pago.Name = "Txt_DesFacF1Pago"
        Me.Txt_DesFacF1Pago.Size = New System.Drawing.Size(104, 20)
        Me.Txt_DesFacF1Pago.TabIndex = 161
        '
        'Txt_DesFacF2Pago
        '
        Me.Txt_DesFacF2Pago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacF2Pago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacF2Pago.Location = New System.Drawing.Point(672, 112)
        Me.Txt_DesFacF2Pago.MaxLength = 15
        Me.Txt_DesFacF2Pago.Name = "Txt_DesFacF2Pago"
        Me.Txt_DesFacF2Pago.Size = New System.Drawing.Size(101, 20)
        Me.Txt_DesFacF2Pago.TabIndex = 162
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Black
        Me.Label66.Location = New System.Drawing.Point(488, 112)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(72, 16)
        Me.Label66.TabIndex = 160
        Me.Label66.Text = "Fonos Pago"
        '
        'Txt_DesFacEncPago
        '
        Me.Txt_DesFacEncPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacEncPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacEncPago.Location = New System.Drawing.Point(120, 136)
        Me.Txt_DesFacEncPago.MaxLength = 35
        Me.Txt_DesFacEncPago.Name = "Txt_DesFacEncPago"
        Me.Txt_DesFacEncPago.Size = New System.Drawing.Size(240, 20)
        Me.Txt_DesFacEncPago.TabIndex = 159
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Black
        Me.Label67.Location = New System.Drawing.Point(16, 136)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(112, 16)
        Me.Label67.TabIndex = 158
        Me.Label67.Text = "Enc. Pago"
        '
        'Txt_DesFacOCompra
        '
        Me.Txt_DesFacOCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacOCompra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacOCompra.Location = New System.Drawing.Point(960, 88)
        Me.Txt_DesFacOCompra.MaxLength = 15
        Me.Txt_DesFacOCompra.Name = "Txt_DesFacOCompra"
        Me.Txt_DesFacOCompra.Size = New System.Drawing.Size(64, 20)
        Me.Txt_DesFacOCompra.TabIndex = 157
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Black
        Me.Label68.Location = New System.Drawing.Point(896, 88)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(72, 23)
        Me.Label68.TabIndex = 156
        Me.Label68.Text = "O.Compra"
        '
        'Txt_DesFacF1
        '
        Me.Txt_DesFacF1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacF1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacF1.Location = New System.Drawing.Point(560, 64)
        Me.Txt_DesFacF1.MaxLength = 15
        Me.Txt_DesFacF1.Name = "Txt_DesFacF1"
        Me.Txt_DesFacF1.Size = New System.Drawing.Size(104, 20)
        Me.Txt_DesFacF1.TabIndex = 132
        '
        'Txt_DesFacSolicita
        '
        Me.Txt_DesFacSolicita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacSolicita.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacSolicita.Location = New System.Drawing.Point(120, 112)
        Me.Txt_DesFacSolicita.MaxLength = 35
        Me.Txt_DesFacSolicita.Name = "Txt_DesFacSolicita"
        Me.Txt_DesFacSolicita.Size = New System.Drawing.Size(240, 20)
        Me.Txt_DesFacSolicita.TabIndex = 155
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Black
        Me.Label69.Location = New System.Drawing.Point(16, 112)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(112, 16)
        Me.Label69.TabIndex = 154
        Me.Label69.Text = "Solicitado Por"
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(896, 40)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(64, 23)
        Me.Label72.TabIndex = 151
        Me.Label72.Text = "Empresa"
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.ForeColor = System.Drawing.Color.Black
        Me.Label73.Location = New System.Drawing.Point(488, 88)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(80, 23)
        Me.Label73.TabIndex = 144
        Me.Label73.Text = "Cond. Pago"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.Color.Black
        Me.Label74.Location = New System.Drawing.Point(488, 40)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(56, 23)
        Me.Label74.TabIndex = 142
        Me.Label74.Text = "Ciudad"
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.ForeColor = System.Drawing.Color.Black
        Me.Label75.Location = New System.Drawing.Point(16, 88)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(40, 23)
        Me.Label75.TabIndex = 139
        Me.Label75.Text = "Giro"
        '
        'Txt_DesFacGiro
        '
        Me.Txt_DesFacGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacGiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacGiro.Location = New System.Drawing.Point(120, 88)
        Me.Txt_DesFacGiro.MaxLength = 35
        Me.Txt_DesFacGiro.Name = "Txt_DesFacGiro"
        Me.Txt_DesFacGiro.Size = New System.Drawing.Size(240, 20)
        Me.Txt_DesFacGiro.TabIndex = 138
        '
        'Txt_DesFacDireccion
        '
        Me.Txt_DesFacDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacDireccion.Location = New System.Drawing.Point(120, 64)
        Me.Txt_DesFacDireccion.MaxLength = 50
        Me.Txt_DesFacDireccion.Name = "Txt_DesFacDireccion"
        Me.Txt_DesFacDireccion.Size = New System.Drawing.Size(240, 20)
        Me.Txt_DesFacDireccion.TabIndex = 134
        '
        'Txt_DesFacF2
        '
        Me.Txt_DesFacF2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacF2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacF2.Location = New System.Drawing.Point(671, 64)
        Me.Txt_DesFacF2.MaxLength = 15
        Me.Txt_DesFacF2.Name = "Txt_DesFacF2"
        Me.Txt_DesFacF2.Size = New System.Drawing.Size(102, 20)
        Me.Txt_DesFacF2.TabIndex = 133
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Black
        Me.Label76.Location = New System.Drawing.Point(488, 64)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(64, 23)
        Me.Label76.TabIndex = 131
        Me.Label76.Text = "Fonos"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.ForeColor = System.Drawing.Color.Black
        Me.Label77.Location = New System.Drawing.Point(16, 40)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(72, 16)
        Me.Label77.TabIndex = 128
        Me.Label77.Text = "Señor(es)"
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.Color.Black
        Me.Label78.Location = New System.Drawing.Point(16, 64)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(72, 23)
        Me.Label78.TabIndex = 135
        Me.Label78.Text = "Dirección "
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Black
        Me.Label79.Location = New System.Drawing.Point(896, 64)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(64, 23)
        Me.Label79.TabIndex = 140
        Me.Label79.Text = "Comuna"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1115, 2)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 16)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Factura"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(1027, 2)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(88, 16)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Estado OT"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(907, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(112, 16)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "N°Laboratorio"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.TxtDespachoFax2)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoFax1)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoCelular2)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoCelular1)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoFono2)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoFono1)
        Me.GroupBox10.Controls.Add(Me.Bt_Grabar)
        Me.GroupBox10.Controls.Add(Me.Txt_DesCiudad)
        Me.GroupBox10.Controls.Add(Me.Txt_DesComuna)
        Me.GroupBox10.Controls.Add(Me.Label32)
        Me.GroupBox10.Controls.Add(Me.TxtObservaciones)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Controls.Add(Me.TxtEntrego)
        Me.GroupBox10.Controls.Add(Me.Label87)
        Me.GroupBox10.Controls.Add(Me.CbxUrgente)
        Me.GroupBox10.Controls.Add(Me.Label22)
        Me.GroupBox10.Controls.Add(Me.CbxDespRetiraLab)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoNombre)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoAtencion)
        Me.GroupBox10.Controls.Add(Me.Label28)
        Me.GroupBox10.Controls.Add(Me.CbxDespEmail)
        Me.GroupBox10.Controls.Add(Me.CbxDespFax)
        Me.GroupBox10.Controls.Add(Me.CbxDespCorreo)
        Me.GroupBox10.Controls.Add(Me.CbxDespBus)
        Me.GroupBox10.Controls.Add(Me.CbxDespAvisoFono)
        Me.GroupBox10.Controls.Add(Me.CbxDespOtro)
        Me.GroupBox10.Controls.Add(Me.TxtDespOtra)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.Label49)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoDireccion)
        Me.GroupBox10.Controls.Add(Me.Label35)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoCasilla)
        Me.GroupBox10.Controls.Add(Me.Label33)
        Me.GroupBox10.Controls.Add(Me.Label31)
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.DTPDespachoFecha)
        Me.GroupBox10.Controls.Add(Me.Label39)
        Me.GroupBox10.Controls.Add(Me.Label37)
        Me.GroupBox10.Controls.Add(Me.Label38)
        Me.GroupBox10.Controls.Add(Me.Label36)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoEmail1)
        Me.GroupBox10.Controls.Add(Me.TxtDespachoEmail2)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(3, 234)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(1248, 200)
        Me.GroupBox10.TabIndex = 7
        Me.GroupBox10.TabStop = False
        '
        'TxtDespachoFax2
        '
        Me.TxtDespachoFax2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoFax2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoFax2.Location = New System.Drawing.Point(232, 112)
        Me.TxtDespachoFax2.MaxLength = 40
        Me.TxtDespachoFax2.Name = "TxtDespachoFax2"
        Me.TxtDespachoFax2.Size = New System.Drawing.Size(101, 20)
        Me.TxtDespachoFax2.TabIndex = 125
        '
        'TxtDespachoFax1
        '
        Me.TxtDespachoFax1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoFax1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoFax1.Location = New System.Drawing.Point(120, 112)
        Me.TxtDespachoFax1.MaxLength = 40
        Me.TxtDespachoFax1.Name = "TxtDespachoFax1"
        Me.TxtDespachoFax1.Size = New System.Drawing.Size(104, 20)
        Me.TxtDespachoFax1.TabIndex = 124
        '
        'TxtDespachoCelular2
        '
        Me.TxtDespachoCelular2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoCelular2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoCelular2.Location = New System.Drawing.Point(1076, 88)
        Me.TxtDespachoCelular2.MaxLength = 40
        Me.TxtDespachoCelular2.Name = "TxtDespachoCelular2"
        Me.TxtDespachoCelular2.Size = New System.Drawing.Size(108, 20)
        Me.TxtDespachoCelular2.TabIndex = 123
        '
        'TxtDespachoCelular1
        '
        Me.TxtDespachoCelular1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoCelular1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoCelular1.Location = New System.Drawing.Point(960, 88)
        Me.TxtDespachoCelular1.MaxLength = 40
        Me.TxtDespachoCelular1.Name = "TxtDespachoCelular1"
        Me.TxtDespachoCelular1.Size = New System.Drawing.Size(108, 20)
        Me.TxtDespachoCelular1.TabIndex = 122
        '
        'TxtDespachoFono2
        '
        Me.TxtDespachoFono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoFono2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoFono2.Location = New System.Drawing.Point(672, 88)
        Me.TxtDespachoFono2.MaxLength = 40
        Me.TxtDespachoFono2.Name = "TxtDespachoFono2"
        Me.TxtDespachoFono2.Size = New System.Drawing.Size(101, 20)
        Me.TxtDespachoFono2.TabIndex = 121
        '
        'TxtDespachoFono1
        '
        Me.TxtDespachoFono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoFono1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoFono1.Location = New System.Drawing.Point(560, 88)
        Me.TxtDespachoFono1.MaxLength = 40
        Me.TxtDespachoFono1.Name = "TxtDespachoFono1"
        Me.TxtDespachoFono1.Size = New System.Drawing.Size(104, 20)
        Me.TxtDespachoFono1.TabIndex = 120
        '
        'Bt_Grabar
        '
        Me.Bt_Grabar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Grabar.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Grabar.Location = New System.Drawing.Point(1160, 168)
        Me.Bt_Grabar.Name = "Bt_Grabar"
        Me.Bt_Grabar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Grabar.TabIndex = 119
        Me.Bt_Grabar.Text = "Grabar"
        Me.Bt_Grabar.UseVisualStyleBackColor = False
        '
        'Txt_DesCiudad
        '
        Me.Txt_DesCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesCiudad.Location = New System.Drawing.Point(960, 64)
        Me.Txt_DesCiudad.MaxLength = 35
        Me.Txt_DesCiudad.Name = "Txt_DesCiudad"
        Me.Txt_DesCiudad.Size = New System.Drawing.Size(168, 20)
        Me.Txt_DesCiudad.TabIndex = 118
        '
        'Txt_DesComuna
        '
        Me.Txt_DesComuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesComuna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesComuna.Location = New System.Drawing.Point(120, 64)
        Me.Txt_DesComuna.MaxLength = 35
        Me.Txt_DesComuna.Name = "Txt_DesComuna"
        Me.Txt_DesComuna.Size = New System.Drawing.Size(168, 20)
        Me.Txt_DesComuna.TabIndex = 117
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Black
        Me.Label32.Location = New System.Drawing.Point(16, 136)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(104, 24)
        Me.Label32.TabIndex = 114
        Me.Label32.Text = "Observaciones"
        '
        'TxtObservaciones
        '
        Me.TxtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObservaciones.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObservaciones.Location = New System.Drawing.Point(120, 136)
        Me.TxtObservaciones.MaxLength = 255
        Me.TxtObservaciones.Multiline = True
        Me.TxtObservaciones.Name = "TxtObservaciones"
        Me.TxtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtObservaciones.Size = New System.Drawing.Size(1088, 20)
        Me.TxtObservaciones.TabIndex = 115
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 160)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 16)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Ingresó Sr."
        '
        'TxtEntrego
        '
        Me.TxtEntrego.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEntrego.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEntrego.Location = New System.Drawing.Point(120, 160)
        Me.TxtEntrego.MaxLength = 35
        Me.TxtEntrego.Name = "TxtEntrego"
        Me.TxtEntrego.Size = New System.Drawing.Size(256, 20)
        Me.TxtEntrego.TabIndex = 116
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.Black
        Me.Label87.Location = New System.Drawing.Point(296, 94)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(72, 16)
        Me.Label87.TabIndex = 112
        Me.Label87.Text = "50% Recarg."
        '
        'CbxUrgente
        '
        Me.CbxUrgente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxUrgente.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxUrgente.ForeColor = System.Drawing.Color.Black
        Me.CbxUrgente.Location = New System.Drawing.Point(232, 94)
        Me.CbxUrgente.Name = "CbxUrgente"
        Me.CbxUrgente.Size = New System.Drawing.Size(64, 16)
        Me.CbxUrgente.TabIndex = 109
        Me.CbxUrgente.TabStop = False
        Me.CbxUrgente.Text = "Urgente"
        Me.CbxUrgente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(896, 112)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(56, 16)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "e-mail 2"
        '
        'CbxDespRetiraLab
        '
        Me.CbxDespRetiraLab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespRetiraLab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespRetiraLab.ForeColor = System.Drawing.Color.Black
        Me.CbxDespRetiraLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CbxDespRetiraLab.Location = New System.Drawing.Point(136, 14)
        Me.CbxDespRetiraLab.Name = "CbxDespRetiraLab"
        Me.CbxDespRetiraLab.Size = New System.Drawing.Size(80, 16)
        Me.CbxDespRetiraLab.TabIndex = 37
        Me.CbxDespRetiraLab.TabStop = False
        Me.CbxDespRetiraLab.Text = "Retira Lab."
        Me.CbxDespRetiraLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDespachoNombre
        '
        Me.TxtDespachoNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoNombre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoNombre.Location = New System.Drawing.Point(120, 40)
        Me.TxtDespachoNombre.MaxLength = 35
        Me.TxtDespachoNombre.Name = "TxtDespachoNombre"
        Me.TxtDespachoNombre.Size = New System.Drawing.Size(248, 20)
        Me.TxtDespachoNombre.TabIndex = 49
        '
        'TxtDespachoAtencion
        '
        Me.TxtDespachoAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoAtencion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoAtencion.Location = New System.Drawing.Point(560, 40)
        Me.TxtDespachoAtencion.MaxLength = 35
        Me.TxtDespachoAtencion.Name = "TxtDespachoAtencion"
        Me.TxtDespachoAtencion.Size = New System.Drawing.Size(237, 20)
        Me.TxtDespachoAtencion.TabIndex = 50
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(16, 14)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(96, 16)
        Me.Label28.TabIndex = 45
        Me.Label28.Text = "DESPACHO :"
        '
        'CbxDespEmail
        '
        Me.CbxDespEmail.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespEmail.ForeColor = System.Drawing.Color.Black
        Me.CbxDespEmail.Location = New System.Drawing.Point(496, 14)
        Me.CbxDespEmail.Name = "CbxDespEmail"
        Me.CbxDespEmail.Size = New System.Drawing.Size(56, 16)
        Me.CbxDespEmail.TabIndex = 38
        Me.CbxDespEmail.TabStop = False
        Me.CbxDespEmail.Text = "e-mail"
        Me.CbxDespEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDespFax
        '
        Me.CbxDespFax.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespFax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespFax.ForeColor = System.Drawing.Color.Black
        Me.CbxDespFax.Location = New System.Drawing.Point(376, 14)
        Me.CbxDespFax.Name = "CbxDespFax"
        Me.CbxDespFax.Size = New System.Drawing.Size(48, 16)
        Me.CbxDespFax.TabIndex = 39
        Me.CbxDespFax.TabStop = False
        Me.CbxDespFax.Text = "Fax"
        Me.CbxDespFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDespCorreo
        '
        Me.CbxDespCorreo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespCorreo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespCorreo.ForeColor = System.Drawing.Color.Black
        Me.CbxDespCorreo.Location = New System.Drawing.Point(600, 14)
        Me.CbxDespCorreo.Name = "CbxDespCorreo"
        Me.CbxDespCorreo.Size = New System.Drawing.Size(64, 16)
        Me.CbxDespCorreo.TabIndex = 40
        Me.CbxDespCorreo.TabStop = False
        Me.CbxDespCorreo.Text = "Correo"
        Me.CbxDespCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDespBus
        '
        Me.CbxDespBus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespBus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespBus.ForeColor = System.Drawing.Color.Black
        Me.CbxDespBus.Location = New System.Drawing.Point(712, 14)
        Me.CbxDespBus.Name = "CbxDespBus"
        Me.CbxDespBus.Size = New System.Drawing.Size(48, 16)
        Me.CbxDespBus.TabIndex = 41
        Me.CbxDespBus.TabStop = False
        Me.CbxDespBus.Text = "Bus"
        Me.CbxDespBus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDespAvisoFono
        '
        Me.CbxDespAvisoFono.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespAvisoFono.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespAvisoFono.ForeColor = System.Drawing.Color.Black
        Me.CbxDespAvisoFono.Location = New System.Drawing.Point(256, 14)
        Me.CbxDespAvisoFono.Name = "CbxDespAvisoFono"
        Me.CbxDespAvisoFono.Size = New System.Drawing.Size(80, 16)
        Me.CbxDespAvisoFono.TabIndex = 42
        Me.CbxDespAvisoFono.TabStop = False
        Me.CbxDespAvisoFono.Text = "Aviso Fono"
        Me.CbxDespAvisoFono.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbxDespOtro
        '
        Me.CbxDespOtro.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CbxDespOtro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxDespOtro.ForeColor = System.Drawing.Color.Black
        Me.CbxDespOtro.Location = New System.Drawing.Point(896, 14)
        Me.CbxDespOtro.Name = "CbxDespOtro"
        Me.CbxDespOtro.Size = New System.Drawing.Size(48, 16)
        Me.CbxDespOtro.TabIndex = 43
        Me.CbxDespOtro.TabStop = False
        Me.CbxDespOtro.Text = "Otro"
        Me.CbxDespOtro.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtDespOtra
        '
        Me.TxtDespOtra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespOtra.Enabled = False
        Me.TxtDespOtra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespOtra.Location = New System.Drawing.Point(960, 11)
        Me.TxtDespOtra.MaxLength = 30
        Me.TxtDespOtra.Name = "TxtDespOtra"
        Me.TxtDespOtra.Size = New System.Drawing.Size(152, 20)
        Me.TxtDespOtra.TabIndex = 46
        Me.TxtDespOtra.TabStop = False
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(16, 40)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 23)
        Me.Label29.TabIndex = 47
        Me.Label29.Text = "Señor(es)"
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(496, 40)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(72, 23)
        Me.Label49.TabIndex = 90
        Me.Label49.Text = "Atención"
        '
        'TxtDespachoDireccion
        '
        Me.TxtDespachoDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoDireccion.Location = New System.Drawing.Point(960, 40)
        Me.TxtDespachoDireccion.MaxLength = 50
        Me.TxtDespachoDireccion.Name = "TxtDespachoDireccion"
        Me.TxtDespachoDireccion.Size = New System.Drawing.Size(248, 20)
        Me.TxtDespachoDireccion.TabIndex = 51
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.Black
        Me.Label35.Location = New System.Drawing.Point(896, 40)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(72, 23)
        Me.Label35.TabIndex = 53
        Me.Label35.Text = "Dirección"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.Black
        Me.Label34.Location = New System.Drawing.Point(496, 64)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(56, 27)
        Me.Label34.TabIndex = 52
        Me.Label34.Text = "Casilla"
        '
        'TxtDespachoCasilla
        '
        Me.TxtDespachoCasilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoCasilla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoCasilla.Location = New System.Drawing.Point(560, 64)
        Me.TxtDespachoCasilla.MaxLength = 10
        Me.TxtDespachoCasilla.Name = "TxtDespachoCasilla"
        Me.TxtDespachoCasilla.Size = New System.Drawing.Size(88, 20)
        Me.TxtDespachoCasilla.TabIndex = 53
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(16, 64)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(64, 16)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "Comuna"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Black
        Me.Label31.Location = New System.Drawing.Point(896, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(56, 23)
        Me.Label31.TabIndex = 49
        Me.Label31.Text = "Ciudad"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Black
        Me.Label30.Location = New System.Drawing.Point(16, 88)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(80, 23)
        Me.Label30.TabIndex = 48
        Me.Label30.Text = "F.despacho"
        '
        'DTPDespachoFecha
        '
        Me.DTPDespachoFecha.CustomFormat = ""
        Me.DTPDespachoFecha.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPDespachoFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPDespachoFecha.Location = New System.Drawing.Point(120, 88)
        Me.DTPDespachoFecha.Name = "DTPDespachoFecha"
        Me.DTPDespachoFecha.Size = New System.Drawing.Size(88, 20)
        Me.DTPDespachoFecha.TabIndex = 104
        Me.DTPDespachoFecha.TabStop = False
        Me.DTPDespachoFecha.Value = New Date(2008, 11, 4, 0, 0, 0, 0)
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Black
        Me.Label39.Location = New System.Drawing.Point(496, 88)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 16)
        Me.Label39.TabIndex = 66
        Me.Label39.Text = "Fonos"
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Black
        Me.Label37.Location = New System.Drawing.Point(896, 88)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(56, 16)
        Me.Label37.TabIndex = 64
        Me.Label37.Text = "Celular"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Black
        Me.Label38.Location = New System.Drawing.Point(16, 112)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(32, 16)
        Me.Label38.TabIndex = 65
        Me.Label38.Text = "Fax"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Black
        Me.Label36.Location = New System.Drawing.Point(496, 112)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 63
        Me.Label36.Text = "e-mail 1"
        '
        'TxtDespachoEmail1
        '
        Me.TxtDespachoEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoEmail1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoEmail1.Location = New System.Drawing.Point(560, 112)
        Me.TxtDespachoEmail1.MaxLength = 40
        Me.TxtDespachoEmail1.Name = "TxtDespachoEmail1"
        Me.TxtDespachoEmail1.Size = New System.Drawing.Size(237, 20)
        Me.TxtDespachoEmail1.TabIndex = 61
        '
        'TxtDespachoEmail2
        '
        Me.TxtDespachoEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDespachoEmail2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDespachoEmail2.Location = New System.Drawing.Point(960, 112)
        Me.TxtDespachoEmail2.MaxLength = 40
        Me.TxtDespachoEmail2.Name = "TxtDespachoEmail2"
        Me.TxtDespachoEmail2.Size = New System.Drawing.Size(248, 20)
        Me.TxtDespachoEmail2.TabIndex = 62
        '
        'Dtg_SeleccionDatos
        '
        Me.Dtg_SeleccionDatos.CaptionVisible = False
        Me.Dtg_SeleccionDatos.DataMember = "DESPACHO_RESULTADO"
        Me.Dtg_SeleccionDatos.DataSource = Me.Cjto_Tablas1
        Me.Dtg_SeleccionDatos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_SeleccionDatos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_SeleccionDatos.Location = New System.Drawing.Point(3, 18)
        Me.Dtg_SeleccionDatos.Name = "Dtg_SeleccionDatos"
        Me.Dtg_SeleccionDatos.Size = New System.Drawing.Size(1248, 216)
        Me.Dtg_SeleccionDatos.TabIndex = 0
        Me.Dtg_SeleccionDatos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.Dtg_SeleccionDatos
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn88, Me.DataGridTextBoxColumn89})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "DESPACHO_RESULTADO"
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "N° OT"
        Me.DataGridTextBoxColumn17.MappingName = "OT_NUMERO"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 50
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "F.Ingreso"
        Me.DataGridTextBoxColumn18.MappingName = "OT_FECHA_ORDEN"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 60
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Productor"
        Me.DataGridTextBoxColumn19.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 180
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Rut Productor"
        Me.DataGridTextBoxColumn20.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 77
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Rut Factura"
        Me.DataGridTextBoxColumn21.MappingName = "OT_FAC_RUT"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 77
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn22.MappingName = "OT_EMPRESA"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 180
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Remite"
        Me.DataGridTextBoxColumn23.MappingName = "OT_REMITE"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 80
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Solicita"
        Me.DataGridTextBoxColumn24.MappingName = "OT_SOL_NOMBRE"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 80
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Atención"
        Me.DataGridTextBoxColumn25.MappingName = "OT_DESP_ATENCION"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 80
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn26.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 40
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Cant"
        Me.DataGridTextBoxColumn27.MappingName = "OTC_CANT_MUESTRAS"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 30
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "Desde"
        Me.DataGridTextBoxColumn28.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 50
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Ana"
        Me.DataGridTextBoxColumn29.MappingName = "OT_ESTADO_ANA"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 30
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Pag"
        Me.DataGridTextBoxColumn30.MappingName = "OT_ESTADO_PAG"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 30
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Fac"
        Me.DataGridTextBoxColumn31.MappingName = "OT_ESTADO_FAC"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 30
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Número"
        Me.DataGridTextBoxColumn32.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 50
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn33.MappingName = "FAC_FECHA"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 50
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "Est"
        Me.DataGridTextBoxColumn34.MappingName = "FAC_ESTADO"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 30
        '
        'DataGridTextBoxColumn88
        '
        Me.DataGridTextBoxColumn88.Format = ""
        Me.DataGridTextBoxColumn88.FormatInfo = Nothing
        Me.DataGridTextBoxColumn88.HeaderText = "Email1"
        Me.DataGridTextBoxColumn88.MappingName = "OT_EMAIL1"
        Me.DataGridTextBoxColumn88.NullText = ""
        Me.DataGridTextBoxColumn88.Width = 35
        '
        'DataGridTextBoxColumn89
        '
        Me.DataGridTextBoxColumn89.Format = ""
        Me.DataGridTextBoxColumn89.FormatInfo = Nothing
        Me.DataGridTextBoxColumn89.HeaderText = "Email2"
        Me.DataGridTextBoxColumn89.MappingName = "OT_EMAIL2"
        Me.DataGridTextBoxColumn89.NullText = ""
        Me.DataGridTextBoxColumn89.Width = 35
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.Rdb_Resultados)
        Me.GroupBox3.Controls.Add(Me.Rdb_Factura)
        Me.GroupBox3.Controls.Add(Me.Rdb_ResyFact)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(919, 488)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(326, 281)
        Me.GroupBox3.TabIndex = 209
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de Despacho"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Rdb_Nomina)
        Me.GroupBox6.Controls.Add(Me.Rdb_EnvEmail)
        Me.GroupBox6.Controls.Add(Me.Bt_Aceptar)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpFacResCart)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpFacRes)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpFactyCart)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpFact)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpResyCart)
        Me.GroupBox6.Controls.Add(Me.Rdb_ImpRes)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 35)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(304, 239)
        Me.GroupBox6.TabIndex = 206
        Me.GroupBox6.TabStop = False
        '
        'Rdb_Nomina
        '
        Me.Rdb_Nomina.Enabled = False
        Me.Rdb_Nomina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Nomina.Location = New System.Drawing.Point(8, 184)
        Me.Rdb_Nomina.Name = "Rdb_Nomina"
        Me.Rdb_Nomina.Size = New System.Drawing.Size(216, 24)
        Me.Rdb_Nomina.TabIndex = 212
        Me.Rdb_Nomina.Text = "Imprimir Nomina"
        '
        'Rdb_EnvEmail
        '
        Me.Rdb_EnvEmail.Enabled = False
        Me.Rdb_EnvEmail.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_EnvEmail.Location = New System.Drawing.Point(8, 64)
        Me.Rdb_EnvEmail.Name = "Rdb_EnvEmail"
        Me.Rdb_EnvEmail.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_EnvEmail.TabIndex = 211
        Me.Rdb_EnvEmail.Text = "Envia Resultados por e-mail"
        '
        'Bt_Aceptar
        '
        Me.Bt_Aceptar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Aceptar.Enabled = False
        Me.Bt_Aceptar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Aceptar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.Bt_Aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Aceptar.Location = New System.Drawing.Point(125, 207)
        Me.Bt_Aceptar.Name = "Bt_Aceptar"
        Me.Bt_Aceptar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Aceptar.TabIndex = 210
        Me.Bt_Aceptar.Text = "Aceptar"
        Me.Bt_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Aceptar.UseVisualStyleBackColor = False
        '
        'Rdb_ImpFacResCart
        '
        Me.Rdb_ImpFacResCart.Enabled = False
        Me.Rdb_ImpFacResCart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpFacResCart.Location = New System.Drawing.Point(8, 160)
        Me.Rdb_ImpFacResCart.Name = "Rdb_ImpFacResCart"
        Me.Rdb_ImpFacResCart.Size = New System.Drawing.Size(216, 24)
        Me.Rdb_ImpFacResCart.TabIndex = 209
        Me.Rdb_ImpFacResCart.Text = "Imprimir Factura + Resultado + Carta"
        '
        'Rdb_ImpFacRes
        '
        Me.Rdb_ImpFacRes.Enabled = False
        Me.Rdb_ImpFacRes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpFacRes.Location = New System.Drawing.Point(8, 136)
        Me.Rdb_ImpFacRes.Name = "Rdb_ImpFacRes"
        Me.Rdb_ImpFacRes.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_ImpFacRes.TabIndex = 208
        Me.Rdb_ImpFacRes.Text = "Imprimir Factura + Resultado"
        '
        'Rdb_ImpFactyCart
        '
        Me.Rdb_ImpFactyCart.Enabled = False
        Me.Rdb_ImpFactyCart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpFactyCart.Location = New System.Drawing.Point(8, 112)
        Me.Rdb_ImpFactyCart.Name = "Rdb_ImpFactyCart"
        Me.Rdb_ImpFactyCart.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_ImpFactyCart.TabIndex = 207
        Me.Rdb_ImpFactyCart.Text = "Imprimir Factura + Carta"
        '
        'Rdb_ImpFact
        '
        Me.Rdb_ImpFact.Enabled = False
        Me.Rdb_ImpFact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpFact.Location = New System.Drawing.Point(8, 88)
        Me.Rdb_ImpFact.Name = "Rdb_ImpFact"
        Me.Rdb_ImpFact.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_ImpFact.TabIndex = 206
        Me.Rdb_ImpFact.Text = "Imprimir Factura"
        '
        'Rdb_ImpResyCart
        '
        Me.Rdb_ImpResyCart.Enabled = False
        Me.Rdb_ImpResyCart.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpResyCart.Location = New System.Drawing.Point(8, 40)
        Me.Rdb_ImpResyCart.Name = "Rdb_ImpResyCart"
        Me.Rdb_ImpResyCart.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_ImpResyCart.TabIndex = 205
        Me.Rdb_ImpResyCart.Text = "Imprimir Resultados + Carta"
        '
        'Rdb_ImpRes
        '
        Me.Rdb_ImpRes.Enabled = False
        Me.Rdb_ImpRes.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ImpRes.Location = New System.Drawing.Point(8, 16)
        Me.Rdb_ImpRes.Name = "Rdb_ImpRes"
        Me.Rdb_ImpRes.Size = New System.Drawing.Size(184, 24)
        Me.Rdb_ImpRes.TabIndex = 204
        Me.Rdb_ImpRes.Text = "Imprimir Resultados"
        '
        'Rdb_Resultados
        '
        Me.Rdb_Resultados.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Resultados.Location = New System.Drawing.Point(16, 17)
        Me.Rdb_Resultados.Name = "Rdb_Resultados"
        Me.Rdb_Resultados.Size = New System.Drawing.Size(80, 24)
        Me.Rdb_Resultados.TabIndex = 203
        Me.Rdb_Resultados.Text = "Resultados"
        '
        'Rdb_Factura
        '
        Me.Rdb_Factura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Factura.Location = New System.Drawing.Point(104, 17)
        Me.Rdb_Factura.Name = "Rdb_Factura"
        Me.Rdb_Factura.Size = New System.Drawing.Size(72, 24)
        Me.Rdb_Factura.TabIndex = 204
        Me.Rdb_Factura.Text = "Factura"
        '
        'Rdb_ResyFact
        '
        Me.Rdb_ResyFact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_ResyFact.Location = New System.Drawing.Point(184, 17)
        Me.Rdb_ResyFact.Name = "Rdb_ResyFact"
        Me.Rdb_ResyFact.Size = New System.Drawing.Size(128, 24)
        Me.Rdb_ResyFact.TabIndex = 205
        Me.Rdb_ResyFact.Text = "Resultado + Factura"
        '
        'Txtfactura
        '
        Me.Txtfactura.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Txtfactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txtfactura.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtfactura.Location = New System.Drawing.Point(127, 297)
        Me.Txtfactura.Name = "Txtfactura"
        Me.Txtfactura.Size = New System.Drawing.Size(64, 21)
        Me.Txtfactura.TabIndex = 208
        '
        'DTPFechaIng
        '
        Me.DTPFechaIng.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaIng.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaIng.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaIng.Location = New System.Drawing.Point(577, 296)
        Me.DTPFechaIng.Name = "DTPFechaIng"
        Me.DTPFechaIng.Size = New System.Drawing.Size(88, 22)
        Me.DTPFechaIng.TabIndex = 207
        '
        'Gbx_DatDesp
        '
        Me.Gbx_DatDesp.BackColor = System.Drawing.Color.Transparent
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacFax2)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacFax1)
        Me.Gbx_DatDesp.Controls.Add(Me.Label94)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacEmail2)
        Me.Gbx_DatDesp.Controls.Add(Me.Label89)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacEmail1)
        Me.Gbx_DatDesp.Controls.Add(Me.Label85)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DespFacFono2)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacFono1)
        Me.Gbx_DatDesp.Controls.Add(Me.Label120)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacCasilla)
        Me.Gbx_DatDesp.Controls.Add(Me.Label121)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DespFacCiudad)
        Me.Gbx_DatDesp.Controls.Add(Me.Label122)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DespFacComuna)
        Me.Gbx_DatDesp.Controls.Add(Me.Label123)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacDirec)
        Me.Gbx_DatDesp.Controls.Add(Me.Label124)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacIngSr)
        Me.Gbx_DatDesp.Controls.Add(Me.Label125)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacAtencion)
        Me.Gbx_DatDesp.Controls.Add(Me.Label126)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DesFacRetira)
        Me.Gbx_DatDesp.Controls.Add(Me.Label127)
        Me.Gbx_DatDesp.Controls.Add(Me.Txt_DespFacObservacion)
        Me.Gbx_DatDesp.Controls.Add(Me.Label128)
        Me.Gbx_DatDesp.Location = New System.Drawing.Point(10, 18)
        Me.Gbx_DatDesp.Name = "Gbx_DatDesp"
        Me.Gbx_DatDesp.Size = New System.Drawing.Size(1232, 142)
        Me.Gbx_DatDesp.TabIndex = 202
        Me.Gbx_DatDesp.TabStop = False
        '
        'Txt_DesFacFax2
        '
        Me.Txt_DesFacFax2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacFax2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacFax2.Location = New System.Drawing.Point(680, 88)
        Me.Txt_DesFacFax2.MaxLength = 35
        Me.Txt_DesFacFax2.Name = "Txt_DesFacFax2"
        Me.Txt_DesFacFax2.Size = New System.Drawing.Size(104, 20)
        Me.Txt_DesFacFax2.TabIndex = 82
        '
        'Txt_DesFacFax1
        '
        Me.Txt_DesFacFax1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacFax1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacFax1.Location = New System.Drawing.Point(560, 88)
        Me.Txt_DesFacFax1.MaxLength = 35
        Me.Txt_DesFacFax1.Name = "Txt_DesFacFax1"
        Me.Txt_DesFacFax1.Size = New System.Drawing.Size(110, 20)
        Me.Txt_DesFacFax1.TabIndex = 81
        '
        'Label94
        '
        Me.Label94.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.Black
        Me.Label94.Location = New System.Drawing.Point(464, 88)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(88, 16)
        Me.Label94.TabIndex = 80
        Me.Label94.Text = "Fax"
        '
        'Txt_DesFacEmail2
        '
        Me.Txt_DesFacEmail2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacEmail2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacEmail2.Location = New System.Drawing.Point(104, 88)
        Me.Txt_DesFacEmail2.MaxLength = 35
        Me.Txt_DesFacEmail2.Name = "Txt_DesFacEmail2"
        Me.Txt_DesFacEmail2.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacEmail2.TabIndex = 79
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.ForeColor = System.Drawing.Color.Black
        Me.Label89.Location = New System.Drawing.Point(8, 88)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(88, 16)
        Me.Label89.TabIndex = 78
        Me.Label89.Text = "E-mail2"
        '
        'Txt_DesFacEmail1
        '
        Me.Txt_DesFacEmail1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacEmail1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacEmail1.Location = New System.Drawing.Point(992, 64)
        Me.Txt_DesFacEmail1.MaxLength = 35
        Me.Txt_DesFacEmail1.Name = "Txt_DesFacEmail1"
        Me.Txt_DesFacEmail1.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacEmail1.TabIndex = 77
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.ForeColor = System.Drawing.Color.Black
        Me.Label85.Location = New System.Drawing.Point(888, 64)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(88, 16)
        Me.Label85.TabIndex = 76
        Me.Label85.Text = "E-mail1"
        '
        'Txt_DespFacFono2
        '
        Me.Txt_DespFacFono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DespFacFono2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DespFacFono2.Location = New System.Drawing.Point(680, 64)
        Me.Txt_DespFacFono2.MaxLength = 35
        Me.Txt_DespFacFono2.Name = "Txt_DespFacFono2"
        Me.Txt_DespFacFono2.Size = New System.Drawing.Size(104, 20)
        Me.Txt_DespFacFono2.TabIndex = 75
        '
        'Txt_DesFacFono1
        '
        Me.Txt_DesFacFono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacFono1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacFono1.Location = New System.Drawing.Point(560, 64)
        Me.Txt_DesFacFono1.MaxLength = 35
        Me.Txt_DesFacFono1.Name = "Txt_DesFacFono1"
        Me.Txt_DesFacFono1.Size = New System.Drawing.Size(110, 20)
        Me.Txt_DesFacFono1.TabIndex = 73
        '
        'Label120
        '
        Me.Label120.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.ForeColor = System.Drawing.Color.Black
        Me.Label120.Location = New System.Drawing.Point(464, 64)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(88, 16)
        Me.Label120.TabIndex = 72
        Me.Label120.Text = "Fono"
        '
        'Txt_DesFacCasilla
        '
        Me.Txt_DesFacCasilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacCasilla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacCasilla.Location = New System.Drawing.Point(104, 64)
        Me.Txt_DesFacCasilla.MaxLength = 35
        Me.Txt_DesFacCasilla.Name = "Txt_DesFacCasilla"
        Me.Txt_DesFacCasilla.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacCasilla.TabIndex = 71
        '
        'Label121
        '
        Me.Label121.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.ForeColor = System.Drawing.Color.Black
        Me.Label121.Location = New System.Drawing.Point(8, 64)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(88, 16)
        Me.Label121.TabIndex = 70
        Me.Label121.Text = "Casilla"
        '
        'Txt_DespFacCiudad
        '
        Me.Txt_DespFacCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DespFacCiudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DespFacCiudad.Location = New System.Drawing.Point(992, 40)
        Me.Txt_DespFacCiudad.MaxLength = 35
        Me.Txt_DespFacCiudad.Name = "Txt_DespFacCiudad"
        Me.Txt_DespFacCiudad.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DespFacCiudad.TabIndex = 69
        '
        'Label122
        '
        Me.Label122.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.Black
        Me.Label122.Location = New System.Drawing.Point(888, 40)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(88, 16)
        Me.Label122.TabIndex = 68
        Me.Label122.Text = "Ciudad"
        '
        'Txt_DespFacComuna
        '
        Me.Txt_DespFacComuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DespFacComuna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DespFacComuna.Location = New System.Drawing.Point(560, 40)
        Me.Txt_DespFacComuna.MaxLength = 35
        Me.Txt_DespFacComuna.Name = "Txt_DespFacComuna"
        Me.Txt_DespFacComuna.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DespFacComuna.TabIndex = 67
        '
        'Label123
        '
        Me.Label123.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.ForeColor = System.Drawing.Color.Black
        Me.Label123.Location = New System.Drawing.Point(464, 40)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(88, 16)
        Me.Label123.TabIndex = 66
        Me.Label123.Text = "Comuna"
        '
        'Txt_DesFacDirec
        '
        Me.Txt_DesFacDirec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacDirec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacDirec.Location = New System.Drawing.Point(104, 40)
        Me.Txt_DesFacDirec.MaxLength = 50
        Me.Txt_DesFacDirec.Name = "Txt_DesFacDirec"
        Me.Txt_DesFacDirec.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacDirec.TabIndex = 65
        '
        'Label124
        '
        Me.Label124.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.Black
        Me.Label124.Location = New System.Drawing.Point(8, 40)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(88, 16)
        Me.Label124.TabIndex = 64
        Me.Label124.Text = "Dirección"
        '
        'Txt_DesFacIngSr
        '
        Me.Txt_DesFacIngSr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacIngSr.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacIngSr.Location = New System.Drawing.Point(992, 16)
        Me.Txt_DesFacIngSr.MaxLength = 35
        Me.Txt_DesFacIngSr.Name = "Txt_DesFacIngSr"
        Me.Txt_DesFacIngSr.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacIngSr.TabIndex = 63
        '
        'Label125
        '
        Me.Label125.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.Black
        Me.Label125.Location = New System.Drawing.Point(888, 16)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(88, 16)
        Me.Label125.TabIndex = 62
        Me.Label125.Text = "Ingresó Sr."
        '
        'Txt_DesFacAtencion
        '
        Me.Txt_DesFacAtencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacAtencion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacAtencion.Location = New System.Drawing.Point(560, 16)
        Me.Txt_DesFacAtencion.MaxLength = 35
        Me.Txt_DesFacAtencion.Name = "Txt_DesFacAtencion"
        Me.Txt_DesFacAtencion.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacAtencion.TabIndex = 61
        '
        'Label126
        '
        Me.Label126.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.ForeColor = System.Drawing.Color.Black
        Me.Label126.Location = New System.Drawing.Point(464, 16)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(88, 16)
        Me.Label126.TabIndex = 60
        Me.Label126.Text = "Atención"
        '
        'Txt_DesFacRetira
        '
        Me.Txt_DesFacRetira.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DesFacRetira.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DesFacRetira.Location = New System.Drawing.Point(104, 16)
        Me.Txt_DesFacRetira.MaxLength = 35
        Me.Txt_DesFacRetira.Name = "Txt_DesFacRetira"
        Me.Txt_DesFacRetira.Size = New System.Drawing.Size(224, 20)
        Me.Txt_DesFacRetira.TabIndex = 55
        '
        'Label127
        '
        Me.Label127.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.ForeColor = System.Drawing.Color.Black
        Me.Label127.Location = New System.Drawing.Point(8, 16)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(88, 16)
        Me.Label127.TabIndex = 54
        Me.Label127.Text = "Retira Sr."
        '
        'Txt_DespFacObservacion
        '
        Me.Txt_DespFacObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_DespFacObservacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DespFacObservacion.Location = New System.Drawing.Point(104, 114)
        Me.Txt_DespFacObservacion.MaxLength = 35
        Me.Txt_DespFacObservacion.Name = "Txt_DespFacObservacion"
        Me.Txt_DespFacObservacion.Size = New System.Drawing.Size(680, 20)
        Me.Txt_DespFacObservacion.TabIndex = 59
        '
        'Label128
        '
        Me.Label128.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.ForeColor = System.Drawing.Color.Black
        Me.Label128.Location = New System.Drawing.Point(8, 114)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(88, 16)
        Me.Label128.TabIndex = 58
        Me.Label128.Text = "Observaciones"
        '
        'Dtg_SelFactura
        '
        Me.Dtg_SelFactura.CaptionVisible = False
        Me.Dtg_SelFactura.DataMember = "DESPACHO_RESULTADO1"
        Me.Dtg_SelFactura.DataSource = Me.Cjto_Tablas1
        Me.Dtg_SelFactura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_SelFactura.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_SelFactura.Location = New System.Drawing.Point(-1, 162)
        Me.Dtg_SelFactura.Name = "Dtg_SelFactura"
        Me.Dtg_SelFactura.Size = New System.Drawing.Size(1248, 128)
        Me.Dtg_SelFactura.TabIndex = 194
        Me.Dtg_SelFactura.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle7})
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.DataGrid = Me.Dtg_SelFactura
        Me.DataGridTableStyle7.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn68, Me.DataGridTextBoxColumn69, Me.DataGridTextBoxColumn70, Me.DataGridTextBoxColumn71, Me.DataGridTextBoxColumn72, Me.DataGridTextBoxColumn73, Me.DataGridTextBoxColumn74, Me.DataGridTextBoxColumn75, Me.DataGridTextBoxColumn76, Me.DataGridTextBoxColumn77, Me.DataGridTextBoxColumn78, Me.DataGridTextBoxColumn79, Me.DataGridTextBoxColumn80, Me.DataGridTextBoxColumn81, Me.DataGridTextBoxColumn82, Me.DataGridTextBoxColumn83, Me.DataGridTextBoxColumn84, Me.DataGridTextBoxColumn85, Me.DataGridTextBoxColumn86, Me.DataGridTextBoxColumn87})
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "DESPACHO_RESULTADO1"
        '
        'DataGridTextBoxColumn68
        '
        Me.DataGridTextBoxColumn68.Format = ""
        Me.DataGridTextBoxColumn68.FormatInfo = Nothing
        Me.DataGridTextBoxColumn68.HeaderText = "N°Ot"
        Me.DataGridTextBoxColumn68.MappingName = "OT_NUMERO"
        Me.DataGridTextBoxColumn68.NullText = ""
        Me.DataGridTextBoxColumn68.Width = 50
        '
        'DataGridTextBoxColumn69
        '
        Me.DataGridTextBoxColumn69.Format = ""
        Me.DataGridTextBoxColumn69.FormatInfo = Nothing
        Me.DataGridTextBoxColumn69.HeaderText = "F.Ingreso"
        Me.DataGridTextBoxColumn69.MappingName = "OT_FECHA_ORDEN"
        Me.DataGridTextBoxColumn69.NullText = ""
        Me.DataGridTextBoxColumn69.Width = 65
        '
        'DataGridTextBoxColumn70
        '
        Me.DataGridTextBoxColumn70.Format = ""
        Me.DataGridTextBoxColumn70.FormatInfo = Nothing
        Me.DataGridTextBoxColumn70.HeaderText = "Productor"
        Me.DataGridTextBoxColumn70.MappingName = "PRO_PRODUCTOR"
        Me.DataGridTextBoxColumn70.NullText = ""
        Me.DataGridTextBoxColumn70.Width = 180
        '
        'DataGridTextBoxColumn71
        '
        Me.DataGridTextBoxColumn71.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn71.Format = ""
        Me.DataGridTextBoxColumn71.FormatInfo = Nothing
        Me.DataGridTextBoxColumn71.HeaderText = "Rut Productor"
        Me.DataGridTextBoxColumn71.MappingName = "PRO_RUT"
        Me.DataGridTextBoxColumn71.NullText = ""
        Me.DataGridTextBoxColumn71.Width = 80
        '
        'DataGridTextBoxColumn72
        '
        Me.DataGridTextBoxColumn72.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn72.Format = ""
        Me.DataGridTextBoxColumn72.FormatInfo = Nothing
        Me.DataGridTextBoxColumn72.HeaderText = "Rut Factura"
        Me.DataGridTextBoxColumn72.MappingName = "OT_FAC_RUT"
        Me.DataGridTextBoxColumn72.NullText = ""
        Me.DataGridTextBoxColumn72.Width = 80
        '
        'DataGridTextBoxColumn73
        '
        Me.DataGridTextBoxColumn73.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn73.Format = ""
        Me.DataGridTextBoxColumn73.FormatInfo = Nothing
        Me.DataGridTextBoxColumn73.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn73.MappingName = "OT_EMPRESA"
        Me.DataGridTextBoxColumn73.NullText = ""
        Me.DataGridTextBoxColumn73.Width = 180
        '
        'DataGridTextBoxColumn74
        '
        Me.DataGridTextBoxColumn74.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn74.Format = ""
        Me.DataGridTextBoxColumn74.FormatInfo = Nothing
        Me.DataGridTextBoxColumn74.HeaderText = "Remite"
        Me.DataGridTextBoxColumn74.MappingName = "OT_REMITE"
        Me.DataGridTextBoxColumn74.NullText = ""
        Me.DataGridTextBoxColumn74.Width = 80
        '
        'DataGridTextBoxColumn75
        '
        Me.DataGridTextBoxColumn75.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn75.Format = ""
        Me.DataGridTextBoxColumn75.FormatInfo = Nothing
        Me.DataGridTextBoxColumn75.HeaderText = "Solicita"
        Me.DataGridTextBoxColumn75.MappingName = "OT_SOL_NOMBRE"
        Me.DataGridTextBoxColumn75.NullText = ""
        Me.DataGridTextBoxColumn75.Width = 80
        '
        'DataGridTextBoxColumn76
        '
        Me.DataGridTextBoxColumn76.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn76.Format = ""
        Me.DataGridTextBoxColumn76.FormatInfo = Nothing
        Me.DataGridTextBoxColumn76.HeaderText = "Atención"
        Me.DataGridTextBoxColumn76.MappingName = "OT_DESP_ATENCION"
        Me.DataGridTextBoxColumn76.NullText = ""
        Me.DataGridTextBoxColumn76.Width = 80
        '
        'DataGridTextBoxColumn77
        '
        Me.DataGridTextBoxColumn77.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn77.Format = ""
        Me.DataGridTextBoxColumn77.FormatInfo = Nothing
        Me.DataGridTextBoxColumn77.HeaderText = "Tipo"
        Me.DataGridTextBoxColumn77.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn77.NullText = ""
        Me.DataGridTextBoxColumn77.Width = 40
        '
        'DataGridTextBoxColumn78
        '
        Me.DataGridTextBoxColumn78.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn78.Format = ""
        Me.DataGridTextBoxColumn78.FormatInfo = Nothing
        Me.DataGridTextBoxColumn78.HeaderText = "Cant"
        Me.DataGridTextBoxColumn78.MappingName = "OTC_CANT_MUESTRAS"
        Me.DataGridTextBoxColumn78.NullText = ""
        Me.DataGridTextBoxColumn78.Width = 35
        '
        'DataGridTextBoxColumn79
        '
        Me.DataGridTextBoxColumn79.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn79.Format = ""
        Me.DataGridTextBoxColumn79.FormatInfo = Nothing
        Me.DataGridTextBoxColumn79.HeaderText = "Desde"
        Me.DataGridTextBoxColumn79.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn79.NullText = ""
        Me.DataGridTextBoxColumn79.Width = 50
        '
        'DataGridTextBoxColumn80
        '
        Me.DataGridTextBoxColumn80.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn80.Format = ""
        Me.DataGridTextBoxColumn80.FormatInfo = Nothing
        Me.DataGridTextBoxColumn80.HeaderText = "Ana"
        Me.DataGridTextBoxColumn80.MappingName = "OT_ESTADO_ANA"
        Me.DataGridTextBoxColumn80.NullText = ""
        Me.DataGridTextBoxColumn80.Width = 35
        '
        'DataGridTextBoxColumn81
        '
        Me.DataGridTextBoxColumn81.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn81.Format = ""
        Me.DataGridTextBoxColumn81.FormatInfo = Nothing
        Me.DataGridTextBoxColumn81.HeaderText = "Pag"
        Me.DataGridTextBoxColumn81.MappingName = "OT_ESTADO_PAG"
        Me.DataGridTextBoxColumn81.NullText = ""
        Me.DataGridTextBoxColumn81.Width = 35
        '
        'DataGridTextBoxColumn82
        '
        Me.DataGridTextBoxColumn82.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn82.Format = ""
        Me.DataGridTextBoxColumn82.FormatInfo = Nothing
        Me.DataGridTextBoxColumn82.HeaderText = "Fac"
        Me.DataGridTextBoxColumn82.MappingName = "OT_ESTADO_FAC"
        Me.DataGridTextBoxColumn82.NullText = ""
        Me.DataGridTextBoxColumn82.Width = 35
        '
        'DataGridTextBoxColumn83
        '
        Me.DataGridTextBoxColumn83.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn83.Format = ""
        Me.DataGridTextBoxColumn83.FormatInfo = Nothing
        Me.DataGridTextBoxColumn83.HeaderText = "Número"
        Me.DataGridTextBoxColumn83.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn83.NullText = ""
        Me.DataGridTextBoxColumn83.Width = 50
        '
        'DataGridTextBoxColumn84
        '
        Me.DataGridTextBoxColumn84.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn84.Format = ""
        Me.DataGridTextBoxColumn84.FormatInfo = Nothing
        Me.DataGridTextBoxColumn84.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn84.MappingName = "FAC_FECHA"
        Me.DataGridTextBoxColumn84.NullText = ""
        Me.DataGridTextBoxColumn84.Width = 50
        '
        'DataGridTextBoxColumn85
        '
        Me.DataGridTextBoxColumn85.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn85.Format = ""
        Me.DataGridTextBoxColumn85.FormatInfo = Nothing
        Me.DataGridTextBoxColumn85.HeaderText = "Est"
        Me.DataGridTextBoxColumn85.MappingName = "FAC_ESTADO"
        Me.DataGridTextBoxColumn85.NullText = ""
        Me.DataGridTextBoxColumn85.Width = 30
        '
        'DataGridTextBoxColumn86
        '
        Me.DataGridTextBoxColumn86.Format = ""
        Me.DataGridTextBoxColumn86.FormatInfo = Nothing
        Me.DataGridTextBoxColumn86.HeaderText = "e-mail"
        Me.DataGridTextBoxColumn86.MappingName = "OT_EMAIL1"
        Me.DataGridTextBoxColumn86.NullText = ""
        Me.DataGridTextBoxColumn86.Width = 35
        '
        'DataGridTextBoxColumn87
        '
        Me.DataGridTextBoxColumn87.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn87.Format = ""
        Me.DataGridTextBoxColumn87.FormatInfo = Nothing
        Me.DataGridTextBoxColumn87.HeaderText = "e-mail2"
        Me.DataGridTextBoxColumn87.MappingName = "OT_EMAIL2"
        Me.DataGridTextBoxColumn87.NullText = ""
        Me.DataGridTextBoxColumn87.Width = 35
        '
        'Check_Correo
        '
        Me.Check_Correo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_Correo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Correo.ForeColor = System.Drawing.Color.Black
        Me.Check_Correo.Location = New System.Drawing.Point(507, 3)
        Me.Check_Correo.Name = "Check_Correo"
        Me.Check_Correo.Size = New System.Drawing.Size(64, 16)
        Me.Check_Correo.TabIndex = 50
        Me.Check_Correo.TabStop = False
        Me.Check_Correo.Text = "Correo"
        Me.Check_Correo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Check_Bus
        '
        Me.Check_Bus.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_Bus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Bus.ForeColor = System.Drawing.Color.Black
        Me.Check_Bus.Location = New System.Drawing.Point(635, 3)
        Me.Check_Bus.Name = "Check_Bus"
        Me.Check_Bus.Size = New System.Drawing.Size(48, 16)
        Me.Check_Bus.TabIndex = 51
        Me.Check_Bus.TabStop = False
        Me.Check_Bus.Text = "Bus"
        Me.Check_Bus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Chk_Nomina
        '
        Me.Chk_Nomina.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_Nomina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Nomina.ForeColor = System.Drawing.Color.Black
        Me.Chk_Nomina.Location = New System.Drawing.Point(739, 3)
        Me.Chk_Nomina.Name = "Chk_Nomina"
        Me.Chk_Nomina.Size = New System.Drawing.Size(64, 16)
        Me.Chk_Nomina.TabIndex = 52
        Me.Chk_Nomina.TabStop = False
        Me.Chk_Nomina.Text = "Nomina"
        Me.Chk_Nomina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Check_Fax
        '
        Me.Check_Fax.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_Fax.Enabled = False
        Me.Check_Fax.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Fax.ForeColor = System.Drawing.Color.Black
        Me.Check_Fax.Location = New System.Drawing.Point(403, 3)
        Me.Check_Fax.Name = "Check_Fax"
        Me.Check_Fax.Size = New System.Drawing.Size(48, 16)
        Me.Check_Fax.TabIndex = 49
        Me.Check_Fax.TabStop = False
        Me.Check_Fax.Text = "Fax"
        Me.Check_Fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Check_Email
        '
        Me.Check_Email.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_Email.Enabled = False
        Me.Check_Email.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_Email.ForeColor = System.Drawing.Color.Black
        Me.Check_Email.Location = New System.Drawing.Point(283, 3)
        Me.Check_Email.Name = "Check_Email"
        Me.Check_Email.Size = New System.Drawing.Size(56, 16)
        Me.Check_Email.TabIndex = 48
        Me.Check_Email.TabStop = False
        Me.Check_Email.Text = "e-mail"
        Me.Check_Email.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Check_RetLab
        '
        Me.Check_RetLab.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Check_RetLab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Check_RetLab.ForeColor = System.Drawing.Color.Black
        Me.Check_RetLab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Check_RetLab.Location = New System.Drawing.Point(139, 3)
        Me.Check_RetLab.Name = "Check_RetLab"
        Me.Check_RetLab.Size = New System.Drawing.Size(80, 16)
        Me.Check_RetLab.TabIndex = 47
        Me.Check_RetLab.TabStop = False
        Me.Check_RetLab.Text = "Retira Lab."
        Me.Check_RetLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(19, 3)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(96, 16)
        Me.Label96.TabIndex = 46
        Me.Label96.Text = "Despacho :"
        '
        'TxtRutFacturacion
        '
        Me.TxtRutFacturacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtRutFacturacion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRutFacturacion.HideSelection = False
        Me.TxtRutFacturacion.Location = New System.Drawing.Point(991, 297)
        Me.TxtRutFacturacion.MaxLength = 12
        Me.TxtRutFacturacion.Name = "TxtRutFacturacion"
        Me.TxtRutFacturacion.Size = New System.Drawing.Size(104, 22)
        Me.TxtRutFacturacion.TabIndex = 189
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.Color.Black
        Me.Label62.Location = New System.Drawing.Point(879, 297)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(112, 16)
        Me.Label62.TabIndex = 190
        Me.Label62.Text = "Rut Facturación"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Black
        Me.Label63.Location = New System.Drawing.Point(471, 297)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(96, 16)
        Me.Label63.TabIndex = 188
        Me.Label63.Text = "Fecha Factura"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Black
        Me.Label64.Location = New System.Drawing.Point(7, 297)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(96, 16)
        Me.Label64.TabIndex = 187
        Me.Label64.Text = "Nº Factura"
        '
        'GRBAbono
        '
        Me.GRBAbono.Controls.Add(Me.Label52)
        Me.GRBAbono.Controls.Add(Me.Label53)
        Me.GRBAbono.Controls.Add(Me.ChkCancelado)
        Me.GRBAbono.Controls.Add(Me.Label91)
        Me.GRBAbono.Controls.Add(Me.RdbAbonoEfectivo)
        Me.GRBAbono.Controls.Add(Me.RdbAbonoCheque)
        Me.GRBAbono.Controls.Add(Me.Label90)
        Me.GRBAbono.Controls.Add(Me.TxtAbono)
        Me.GRBAbono.Controls.Add(Me.Label54)
        Me.GRBAbono.Controls.Add(Me.Label93)
        Me.GRBAbono.Controls.Add(Me.TxtSaldo)
        Me.GRBAbono.Controls.Add(Me.Label55)
        Me.GRBAbono.Controls.Add(Me.TxtFechaCancelacion)
        Me.GRBAbono.Controls.Add(Me.DateTimePicker2)
        Me.GRBAbono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBAbono.ForeColor = System.Drawing.Color.Black
        Me.GRBAbono.Location = New System.Drawing.Point(300, 726)
        Me.GRBAbono.Name = "GRBAbono"
        Me.GRBAbono.Size = New System.Drawing.Size(264, 162)
        Me.GRBAbono.TabIndex = 184
        Me.GRBAbono.TabStop = False
        Me.GRBAbono.Text = "Cancelación"
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(168, 112)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(53, 16)
        Me.Label52.TabIndex = 34
        Me.Label52.Text = "Efectivo"
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(168, 96)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(53, 16)
        Me.Label53.TabIndex = 33
        Me.Label53.Text = "Cheque"
        '
        'ChkCancelado
        '
        Me.ChkCancelado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCancelado.ForeColor = System.Drawing.Color.Black
        Me.ChkCancelado.Location = New System.Drawing.Point(8, 48)
        Me.ChkCancelado.Name = "ChkCancelado"
        Me.ChkCancelado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCancelado.Size = New System.Drawing.Size(88, 16)
        Me.ChkCancelado.TabIndex = 32
        Me.ChkCancelado.Text = "Cancelada"
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.Black
        Me.Label91.Location = New System.Drawing.Point(16, 88)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(52, 16)
        Me.Label91.TabIndex = 31
        Me.Label91.Text = "Abono"
        '
        'RdbAbonoEfectivo
        '
        Me.RdbAbonoEfectivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAbonoEfectivo.ForeColor = System.Drawing.Color.MediumBlue
        Me.RdbAbonoEfectivo.Location = New System.Drawing.Point(227, 112)
        Me.RdbAbonoEfectivo.Name = "RdbAbonoEfectivo"
        Me.RdbAbonoEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbAbonoEfectivo.Size = New System.Drawing.Size(16, 16)
        Me.RdbAbonoEfectivo.TabIndex = 25
        '
        'RdbAbonoCheque
        '
        Me.RdbAbonoCheque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAbonoCheque.ForeColor = System.Drawing.Color.MediumBlue
        Me.RdbAbonoCheque.Location = New System.Drawing.Point(227, 96)
        Me.RdbAbonoCheque.Name = "RdbAbonoCheque"
        Me.RdbAbonoCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbAbonoCheque.Size = New System.Drawing.Size(16, 16)
        Me.RdbAbonoCheque.TabIndex = 26
        '
        'Label90
        '
        Me.Label90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.Black
        Me.Label90.Location = New System.Drawing.Point(56, 88)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(24, 16)
        Me.Label90.TabIndex = 21
        Me.Label90.Text = "  $"
        Me.Label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtAbono
        '
        Me.TxtAbono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtAbono.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAbono.Location = New System.Drawing.Point(88, 88)
        Me.TxtAbono.Name = "TxtAbono"
        Me.TxtAbono.Size = New System.Drawing.Size(64, 21)
        Me.TxtAbono.TabIndex = 11
        Me.TxtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(16, 112)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(52, 16)
        Me.Label54.TabIndex = 27
        Me.Label54.Text = "Saldo"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.Black
        Me.Label93.Location = New System.Drawing.Point(56, 112)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(24, 16)
        Me.Label93.TabIndex = 28
        Me.Label93.Text = "  $"
        Me.Label93.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtSaldo
        '
        Me.TxtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSaldo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldo.Location = New System.Drawing.Point(88, 112)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(64, 21)
        Me.TxtSaldo.TabIndex = 29
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(16, 24)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 16)
        Me.Label55.TabIndex = 31
        Me.Label55.Text = "F.Cancelación"
        '
        'TxtFechaCancelacion
        '
        Me.TxtFechaCancelacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFechaCancelacion.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFechaCancelacion.Location = New System.Drawing.Point(110, 22)
        Me.TxtFechaCancelacion.Name = "TxtFechaCancelacion"
        Me.TxtFechaCancelacion.Size = New System.Drawing.Size(104, 21)
        Me.TxtFechaCancelacion.TabIndex = 174
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(207, 22)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(24, 21)
        Me.DateTimePicker2.TabIndex = 216
        '
        'GRBMuestreo
        '
        Me.GRBMuestreo.Controls.Add(Me.CBCalcular)
        Me.GRBMuestreo.Controls.Add(Me.Label86)
        Me.GRBMuestreo.Controls.Add(Me.TxtMuestreoPrecioUn)
        Me.GRBMuestreo.Controls.Add(Me.Label56)
        Me.GRBMuestreo.Controls.Add(Me.TxtMuestreoCant)
        Me.GRBMuestreo.Controls.Add(Me.Label57)
        Me.GRBMuestreo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBMuestreo.ForeColor = System.Drawing.Color.Black
        Me.GRBMuestreo.Location = New System.Drawing.Point(564, 726)
        Me.GRBMuestreo.Name = "GRBMuestreo"
        Me.GRBMuestreo.Size = New System.Drawing.Size(191, 162)
        Me.GRBMuestreo.TabIndex = 185
        Me.GRBMuestreo.TabStop = False
        Me.GRBMuestreo.Text = "Muestreo"
        '
        'CBCalcular
        '
        Me.CBCalcular.BackColor = System.Drawing.Color.Transparent
        Me.CBCalcular.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCalcular.Image = Global.LabSys.My.Resources.Resources.calculator
        Me.CBCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CBCalcular.Location = New System.Drawing.Point(45, 102)
        Me.CBCalcular.Name = "CBCalcular"
        Me.CBCalcular.Size = New System.Drawing.Size(107, 24)
        Me.CBCalcular.TabIndex = 212
        Me.CBCalcular.Text = "Calcular Totales"
        Me.CBCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBCalcular.UseVisualStyleBackColor = False
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.Black
        Me.Label86.Location = New System.Drawing.Point(152, 64)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(28, 16)
        Me.Label86.TabIndex = 20
        Me.Label86.Text = "c/u"
        '
        'TxtMuestreoPrecioUn
        '
        Me.TxtMuestreoPrecioUn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMuestreoPrecioUn.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestreoPrecioUn.Location = New System.Drawing.Point(88, 64)
        Me.TxtMuestreoPrecioUn.Name = "TxtMuestreoPrecioUn"
        Me.TxtMuestreoPrecioUn.Size = New System.Drawing.Size(64, 21)
        Me.TxtMuestreoPrecioUn.TabIndex = 17
        Me.TxtMuestreoPrecioUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(8, 64)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(80, 16)
        Me.Label56.TabIndex = 19
        Me.Label56.Text = "Valor Unit.$"
        '
        'TxtMuestreoCant
        '
        Me.TxtMuestreoCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMuestreoCant.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestreoCant.Location = New System.Drawing.Point(88, 32)
        Me.TxtMuestreoCant.Name = "TxtMuestreoCant"
        Me.TxtMuestreoCant.Size = New System.Drawing.Size(32, 21)
        Me.TxtMuestreoCant.TabIndex = 18
        Me.TxtMuestreoCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(8, 32)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(64, 16)
        Me.Label57.TabIndex = 16
        Me.Label57.Text = "Cantidad"
        '
        'GRBTotales
        '
        Me.GRBTotales.Controls.Add(Me.Label71)
        Me.GRBTotales.Controls.Add(Me.TxtTotal)
        Me.GRBTotales.Controls.Add(Me.Label59)
        Me.GRBTotales.Controls.Add(Me.TxtIva)
        Me.GRBTotales.Controls.Add(Me.Label60)
        Me.GRBTotales.Controls.Add(Me.TxtMuestreo)
        Me.GRBTotales.Controls.Add(Me.TxtNeto)
        Me.GRBTotales.Controls.Add(Me.Label70)
        Me.GRBTotales.Controls.Add(Me.TxtSubTotal)
        Me.GRBTotales.Controls.Add(Me.Label61)
        Me.GRBTotales.Controls.Add(Me.TxtDesctPesos)
        Me.GRBTotales.Controls.Add(Me.TxtDescto)
        Me.GRBTotales.Controls.Add(Me.Label92)
        Me.GRBTotales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRBTotales.Location = New System.Drawing.Point(755, 726)
        Me.GRBTotales.Name = "GRBTotales"
        Me.GRBTotales.Size = New System.Drawing.Size(152, 162)
        Me.GRBTotales.TabIndex = 186
        Me.GRBTotales.TabStop = False
        Me.GRBTotales.Text = "Total"
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(8, 133)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(64, 16)
        Me.Label71.TabIndex = 22
        Me.Label71.Text = "Total     $"
        '
        'TxtTotal
        '
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(80, 133)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(64, 21)
        Me.TxtTotal.TabIndex = 23
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(8, 109)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(64, 16)
        Me.Label59.TabIndex = 20
        Me.Label59.Text = "Iva 19%"
        '
        'TxtIva
        '
        Me.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(80, 109)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(64, 21)
        Me.TxtIva.TabIndex = 21
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(8, 61)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(64, 16)
        Me.Label60.TabIndex = 18
        Me.Label60.Text = "Muestreo"
        '
        'TxtMuestreo
        '
        Me.TxtMuestreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMuestreo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestreo.Location = New System.Drawing.Point(80, 61)
        Me.TxtMuestreo.Name = "TxtMuestreo"
        Me.TxtMuestreo.Size = New System.Drawing.Size(64, 21)
        Me.TxtMuestreo.TabIndex = 19
        Me.TxtMuestreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNeto
        '
        Me.TxtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNeto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto.Location = New System.Drawing.Point(80, 85)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.Size = New System.Drawing.Size(64, 21)
        Me.TxtNeto.TabIndex = 15
        Me.TxtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Black
        Me.Label70.Location = New System.Drawing.Point(8, 85)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(48, 16)
        Me.Label70.TabIndex = 14
        Me.Label70.Text = "Neto"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.Location = New System.Drawing.Point(80, 37)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(64, 21)
        Me.TxtSubTotal.TabIndex = 9
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Black
        Me.Label61.Location = New System.Drawing.Point(8, 37)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(64, 16)
        Me.Label61.TabIndex = 8
        Me.Label61.Text = "Subtotal"
        '
        'TxtDesctPesos
        '
        Me.TxtDesctPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesctPesos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesctPesos.Location = New System.Drawing.Point(80, 13)
        Me.TxtDesctPesos.Name = "TxtDesctPesos"
        Me.TxtDesctPesos.Size = New System.Drawing.Size(64, 21)
        Me.TxtDesctPesos.TabIndex = 22
        Me.TxtDesctPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescto
        '
        Me.TxtDescto.BackColor = System.Drawing.SystemColors.Window
        Me.TxtDescto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescto.Location = New System.Drawing.Point(8, 13)
        Me.TxtDescto.Name = "TxtDescto"
        Me.TxtDescto.Size = New System.Drawing.Size(24, 21)
        Me.TxtDescto.TabIndex = 17
        Me.TxtDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.Black
        Me.Label92.Location = New System.Drawing.Point(48, 13)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(24, 16)
        Me.Label92.TabIndex = 24
        Me.Label92.Text = "  $"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = "FACTURA_DETALLE_DESPACHO1"
        Me.DataGrid1.DataSource = Me.Cjto_Tablas1
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(-1, 458)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(912, 267)
        Me.DataGrid1.TabIndex = 4
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39})
        Me.DataGridTableStyle3.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "FACTURA_DETALLE_DESPACHO1"
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "Cod"
        Me.DataGridTextBoxColumn35.MappingName = "DET_CODIGO"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 45
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = ""
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn36.MappingName = "DET_DETALLE"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 600
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn37.Format = ""
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.HeaderText = "Cant."
        Me.DataGridTextBoxColumn37.MappingName = "DET_CANTIDAD"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 50
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn38.Format = ""
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.HeaderText = "$Unitario"
        Me.DataGridTextBoxColumn38.MappingName = "DET_PUNITARIO"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 75
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn39.Format = ""
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "$Total"
        Me.DataGridTextBoxColumn39.MappingName = "DET_TOTAL"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 77
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.cb_condpago)
        Me.GroupBox4.Controls.Add(Me.Txt_Comuna)
        Me.GroupBox4.Controls.Add(Me.Txt_Empresa)
        Me.GroupBox4.Controls.Add(Me.Txt_Ciudad)
        Me.GroupBox4.Controls.Add(Me.Txt_RSocial)
        Me.GroupBox4.Controls.Add(Me.TxtObsPago)
        Me.GroupBox4.Controls.Add(Me.Label50)
        Me.GroupBox4.Controls.Add(Me.TxtFonoPago1)
        Me.GroupBox4.Controls.Add(Me.TxtFonoPago2)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.TxtEncPago)
        Me.GroupBox4.Controls.Add(Me.Label42)
        Me.GroupBox4.Controls.Add(Me.TxtOrdenCompra)
        Me.GroupBox4.Controls.Add(Me.Label40)
        Me.GroupBox4.Controls.Add(Me.TxtFono1)
        Me.GroupBox4.Controls.Add(Me.TxtSolicitadoPor)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label58)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.TxtGiro)
        Me.GroupBox4.Controls.Add(Me.TxtDireccion)
        Me.GroupBox4.Controls.Add(Me.TxtFono2)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label41)
        Me.GroupBox4.Controls.Add(Me.Label43)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(-1, 316)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1248, 136)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'cb_condpago
        '
        Me.cb_condpago.FormattingEnabled = True
        Me.cb_condpago.Items.AddRange(New Object() {"Contado", "30 Días", "60 Días", "90 Días"})
        Me.cb_condpago.Location = New System.Drawing.Point(576, 66)
        Me.cb_condpago.Name = "cb_condpago"
        Me.cb_condpago.Size = New System.Drawing.Size(224, 23)
        Me.cb_condpago.TabIndex = 169
        '
        'Txt_Comuna
        '
        Me.Txt_Comuna.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Comuna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Comuna.Location = New System.Drawing.Point(992, 40)
        Me.Txt_Comuna.MaxLength = 35
        Me.Txt_Comuna.Name = "Txt_Comuna"
        Me.Txt_Comuna.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Comuna.TabIndex = 168
        '
        'Txt_Empresa
        '
        Me.Txt_Empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Empresa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Empresa.Location = New System.Drawing.Point(992, 16)
        Me.Txt_Empresa.MaxLength = 35
        Me.Txt_Empresa.Name = "Txt_Empresa"
        Me.Txt_Empresa.Size = New System.Drawing.Size(232, 20)
        Me.Txt_Empresa.TabIndex = 167
        '
        'Txt_Ciudad
        '
        Me.Txt_Ciudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Ciudad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Ciudad.Location = New System.Drawing.Point(576, 16)
        Me.Txt_Ciudad.MaxLength = 35
        Me.Txt_Ciudad.Name = "Txt_Ciudad"
        Me.Txt_Ciudad.Size = New System.Drawing.Size(224, 20)
        Me.Txt_Ciudad.TabIndex = 166
        '
        'Txt_RSocial
        '
        Me.Txt_RSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_RSocial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RSocial.Location = New System.Drawing.Point(128, 16)
        Me.Txt_RSocial.MaxLength = 50
        Me.Txt_RSocial.Name = "Txt_RSocial"
        Me.Txt_RSocial.Size = New System.Drawing.Size(240, 20)
        Me.Txt_RSocial.TabIndex = 165
        '
        'TxtObsPago
        '
        Me.TxtObsPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtObsPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtObsPago.Location = New System.Drawing.Point(992, 92)
        Me.TxtObsPago.MaxLength = 15
        Me.TxtObsPago.Name = "TxtObsPago"
        Me.TxtObsPago.Size = New System.Drawing.Size(232, 20)
        Me.TxtObsPago.TabIndex = 164
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(896, 96)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(72, 23)
        Me.Label50.TabIndex = 163
        Me.Label50.Text = "Obs. Pago"
        '
        'TxtFonoPago1
        '
        Me.TxtFonoPago1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFonoPago1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFonoPago1.Location = New System.Drawing.Point(576, 96)
        Me.TxtFonoPago1.MaxLength = 15
        Me.TxtFonoPago1.Name = "TxtFonoPago1"
        Me.TxtFonoPago1.Size = New System.Drawing.Size(106, 20)
        Me.TxtFonoPago1.TabIndex = 161
        '
        'TxtFonoPago2
        '
        Me.TxtFonoPago2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFonoPago2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFonoPago2.Location = New System.Drawing.Point(692, 96)
        Me.TxtFonoPago2.MaxLength = 15
        Me.TxtFonoPago2.Name = "TxtFonoPago2"
        Me.TxtFonoPago2.Size = New System.Drawing.Size(108, 20)
        Me.TxtFonoPago2.TabIndex = 162
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(488, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(80, 23)
        Me.Label20.TabIndex = 160
        Me.Label20.Text = "Fonos Pago"
        '
        'TxtEncPago
        '
        Me.TxtEncPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEncPago.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEncPago.Location = New System.Drawing.Point(128, 112)
        Me.TxtEncPago.MaxLength = 35
        Me.TxtEncPago.Name = "TxtEncPago"
        Me.TxtEncPago.Size = New System.Drawing.Size(240, 20)
        Me.TxtEncPago.TabIndex = 159
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Black
        Me.Label42.Location = New System.Drawing.Point(8, 112)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(112, 16)
        Me.Label42.TabIndex = 158
        Me.Label42.Text = "Enc. Pago"
        '
        'TxtOrdenCompra
        '
        Me.TxtOrdenCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtOrdenCompra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdenCompra.Location = New System.Drawing.Point(992, 65)
        Me.TxtOrdenCompra.MaxLength = 15
        Me.TxtOrdenCompra.Name = "TxtOrdenCompra"
        Me.TxtOrdenCompra.Size = New System.Drawing.Size(64, 20)
        Me.TxtOrdenCompra.TabIndex = 157
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Black
        Me.Label40.Location = New System.Drawing.Point(896, 67)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 23)
        Me.Label40.TabIndex = 156
        Me.Label40.Text = "O.Compra"
        '
        'TxtFono1
        '
        Me.TxtFono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFono1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFono1.Location = New System.Drawing.Point(576, 40)
        Me.TxtFono1.MaxLength = 15
        Me.TxtFono1.Name = "TxtFono1"
        Me.TxtFono1.Size = New System.Drawing.Size(106, 20)
        Me.TxtFono1.TabIndex = 132
        '
        'TxtSolicitadoPor
        '
        Me.TxtSolicitadoPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSolicitadoPor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSolicitadoPor.Location = New System.Drawing.Point(128, 88)
        Me.TxtSolicitadoPor.MaxLength = 35
        Me.TxtSolicitadoPor.Name = "TxtSolicitadoPor"
        Me.TxtSolicitadoPor.Size = New System.Drawing.Size(240, 20)
        Me.TxtSolicitadoPor.TabIndex = 155
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(8, 88)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 16)
        Me.Label21.TabIndex = 154
        Me.Label21.Text = "Solicitado Por"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(896, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 23)
        Me.Label23.TabIndex = 151
        Me.Label23.Text = "Empresa"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(488, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(80, 23)
        Me.Label24.TabIndex = 144
        Me.Label24.Text = "Cond. Pago"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(488, 16)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(56, 23)
        Me.Label58.TabIndex = 142
        Me.Label58.Text = "Ciudad"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(8, 64)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 23)
        Me.Label25.TabIndex = 139
        Me.Label25.Text = "Giro"
        '
        'TxtGiro
        '
        Me.TxtGiro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtGiro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGiro.Location = New System.Drawing.Point(128, 64)
        Me.TxtGiro.MaxLength = 35
        Me.TxtGiro.Name = "TxtGiro"
        Me.TxtGiro.Size = New System.Drawing.Size(240, 20)
        Me.TxtGiro.TabIndex = 138
        '
        'TxtDireccion
        '
        Me.TxtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDireccion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDireccion.Location = New System.Drawing.Point(128, 40)
        Me.TxtDireccion.MaxLength = 50
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(240, 20)
        Me.TxtDireccion.TabIndex = 134
        '
        'TxtFono2
        '
        Me.TxtFono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFono2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFono2.Location = New System.Drawing.Point(692, 40)
        Me.TxtFono2.MaxLength = 15
        Me.TxtFono2.Name = "TxtFono2"
        Me.TxtFono2.Size = New System.Drawing.Size(108, 20)
        Me.TxtFono2.TabIndex = 133
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(488, 42)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(64, 23)
        Me.Label26.TabIndex = 131
        Me.Label26.Text = "Fonos"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(8, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(72, 16)
        Me.Label27.TabIndex = 128
        Me.Label27.Text = "Señor(es)"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Black
        Me.Label41.Location = New System.Drawing.Point(8, 40)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 23)
        Me.Label41.TabIndex = 135
        Me.Label41.Text = "Dirección "
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Black
        Me.Label43.Location = New System.Drawing.Point(894, 42)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(64, 23)
        Me.Label43.TabIndex = 140
        Me.Label43.Text = "Comuna"
        '
        'ElTab1
        '
        Me.ElTab1.Location = New System.Drawing.Point(0, -4)
        Me.ElTab1.Name = "ElTab1"
        Me.ElTab1.Size = New System.Drawing.Size(1292, 970)
        Me.ElTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundPaintType = Klik.Windows.Forms.v1.Common.PaintTypes.Solid
        Me.ElTab1.TabCaptionStyle.StateStyles.FocusStyle.BackgroundSolidColor = System.Drawing.SystemColors.ActiveCaption
        Me.ElTab1.TabIndex = 2
        Me.ElTab1.TabPages.Add(Me.ElTabPage1)
        Me.ElTab1.TabPages.Add(Me.ElTabPage2)
        Me.ElTab1.TabPages.Add(Me.ElTabPage3)
        '
        'ElTabPage1
        '
        Me.ElTabPage1.CaptionTextStyle.Text = "OT Por Despachar"
        Me.ElTabPage1.Controls.Add(Me.Label3)
        Me.ElTabPage1.Controls.Add(Me.Dtg_DespachoResumen)
        Me.ElTabPage1.Controls.Add(Me.Label2)
        Me.ElTabPage1.Controls.Add(Me.Bt_AceptaQuery)
        Me.ElTabPage1.Controls.Add(Me.Label1)
        Me.ElTabPage1.Controls.Add(Me.GroupBox1)
        Me.ElTabPage1.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage1.Name = "ElTabPage1"
        Me.ElTabPage1.Size = New System.Drawing.Size(1290, 946)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1115, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Factura"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1011, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Estado OT"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(883, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "N°Laboratorio"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ElTabPage2
        '
        Me.ElTabPage2.CaptionTextStyle.Text = "OT Pendientes"
        Me.ElTabPage2.Controls.Add(Me.Dtg_Seleccionado)
        Me.ElTabPage2.Controls.Add(Me.Dtg_SeleccionDatos)
        Me.ElTabPage2.Controls.Add(Me.DataGrid2)
        Me.ElTabPage2.Controls.Add(Me.GroupBox10)
        Me.ElTabPage2.Controls.Add(Me.GroupBox2)
        Me.ElTabPage2.Controls.Add(Me.Label19)
        Me.ElTabPage2.Controls.Add(Me.Label17)
        Me.ElTabPage2.Controls.Add(Me.Label18)
        Me.ElTabPage2.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage2.Name = "ElTabPage2"
        Me.ElTabPage2.Size = New System.Drawing.Size(1290, 946)
        '
        'ElTabPage3
        '
        Me.ElTabPage3.CaptionTextStyle.Text = "Despacho"
        Me.ElTabPage3.Controls.Add(Me.chk_FacElectronica)
        Me.ElTabPage3.Controls.Add(Me.txt_son)
        Me.ElTabPage3.Controls.Add(Me.GRBRecibo)
        Me.ElTabPage3.Controls.Add(Me.Check_Correo)
        Me.ElTabPage3.Controls.Add(Me.Gbx_DatDesp)
        Me.ElTabPage3.Controls.Add(Me.Dtg_SelFactura)
        Me.ElTabPage3.Controls.Add(Me.GRBMuestreo)
        Me.ElTabPage3.Controls.Add(Me.Label64)
        Me.ElTabPage3.Controls.Add(Me.Check_Bus)
        Me.ElTabPage3.Controls.Add(Me.GRBTotales)
        Me.ElTabPage3.Controls.Add(Me.TxtRutFacturacion)
        Me.ElTabPage3.Controls.Add(Me.DTPFechaIng)
        Me.ElTabPage3.Controls.Add(Me.Label63)
        Me.ElTabPage3.Controls.Add(Me.Chk_Nomina)
        Me.ElTabPage3.Controls.Add(Me.Label96)
        Me.ElTabPage3.Controls.Add(Me.Label62)
        Me.ElTabPage3.Controls.Add(Me.GroupBox3)
        Me.ElTabPage3.Controls.Add(Me.DataGrid1)
        Me.ElTabPage3.Controls.Add(Me.GRBAbono)
        Me.ElTabPage3.Controls.Add(Me.Check_Fax)
        Me.ElTabPage3.Controls.Add(Me.Check_RetLab)
        Me.ElTabPage3.Controls.Add(Me.Txtfactura)
        Me.ElTabPage3.Controls.Add(Me.GroupBox4)
        Me.ElTabPage3.Controls.Add(Me.Check_Email)
        Me.ElTabPage3.Location = New System.Drawing.Point(1, 23)
        Me.ElTabPage3.Name = "ElTabPage3"
        Me.ElTabPage3.Size = New System.Drawing.Size(1290, 946)
        '
        'chk_FacElectronica
        '
        Me.chk_FacElectronica.AutoSize = True
        Me.chk_FacElectronica.Checked = True
        Me.chk_FacElectronica.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_FacElectronica.Location = New System.Drawing.Point(197, 299)
        Me.chk_FacElectronica.Name = "chk_FacElectronica"
        Me.chk_FacElectronica.Size = New System.Drawing.Size(137, 17)
        Me.chk_FacElectronica.TabIndex = 213
        Me.chk_FacElectronica.Text = "Documento Electrónico"
        Me.chk_FacElectronica.UseVisualStyleBackColor = True
        '
        'txt_son
        '
        Me.txt_son.Location = New System.Drawing.Point(919, 775)
        Me.txt_son.Multiline = True
        Me.txt_son.Name = "txt_son"
        Me.txt_son.Size = New System.Drawing.Size(324, 36)
        Me.txt_son.TabIndex = 211
        '
        'Frm_Despacho
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1284, 1002)
        Me.Controls.Add(Me.ElTab1)
        Me.Name = "Frm_Despacho"
        Me.Text = "Despacho"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GRBRecibo.ResumeLayout(False)
        Me.GRBRecibo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dtg_DespachoResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_Seleccionado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        CType(Me.Dtg_SeleccionDatos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.Gbx_DatDesp.ResumeLayout(False)
        Me.Gbx_DatDesp.PerformLayout()
        CType(Me.Dtg_SelFactura, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRBAbono.ResumeLayout(False)
        Me.GRBAbono.PerformLayout()
        Me.GRBMuestreo.ResumeLayout(False)
        Me.GRBMuestreo.PerformLayout()
        Me.GRBTotales.ResumeLayout(False)
        Me.GRBTotales.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.ElTab1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTab1.ResumeLayout(False)
        CType(Me.ElTabPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage1.ResumeLayout(False)
        CType(Me.ElTabPage2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage2.ResumeLayout(False)
        CType(Me.ElTabPage3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ElTabPage3.ResumeLayout(False)
        Me.ElTabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Carga_Grilla()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow
            Dim mycell As New DataGridCell
            Dim fii As Integer

            Fila_Lectura = 0
            Cjto_Tablas1.Tables("DESPACHO").Clear()
            TxtFechaCancelacion.Text = ""
            ChkCancelado.Checked = False
            With SP
                .Inicializar()
                .EjecutarQueryDt("usp_CuadroResumenOT", Cjto_Tablas1, "DESPACHO")
            End With


            For Each Fila In Cjto_Tablas1.Tables("DESPACHO").Rows
                If IsDBNull(Fila("TMU_CODIGO")) = False Then
                    If Fila("TMU_CODIGO") = "1000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Fol"
                    If Fila("TMU_CODIGO") = "2000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Tej"
                    If Fila("TMU_CODIGO") = "3000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Agu"
                    If Fila("TMU_CODIGO") = "4000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Sue"
                    If Fila("TMU_CODIGO") = "5000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "F Qui"
                    If Fila("TMU_CODIGO") = "6000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "F Org"
                    If Fila("TMU_CODIGO") = "7000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Fito"
                    If Fila("TMU_CODIGO") = "8000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Kits"

                    Fila_Lectura = Fila_Lectura + 1
                Else
                    Fila_Lectura = Fila_Lectura + 1
                End If
            Next

            fii = Dtg_DespachoResumen.CurrentCell.RowNumber.MinValue
            mycell.ColumnNumber = 0
            mycell.RowNumber = fii
            Dtg_DespachoResumen.CurrentCell = mycell
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Carga_GrillaFactura()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow
            Dim mycell As New DataGridCell
            Dim fii As Integer

            Fila_Lectura = 0
            Cjto_Tablas1.Tables("DESPACHO").Clear()
            With SP
                .Inicializar()
                .EjecutarQueryDt("usp_CargaGrillaDespachoFactura", Cjto_Tablas1, "DESPACHO")
            End With

            For Each Fila In Cjto_Tablas1.Tables("DESPACHO").Rows
                If IsDBNull(Fila("TMU_CODIGO")) = True Then
                    GoTo Salto
                End If
                If Fila("TMU_CODIGO") = "1000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Fol"
                If Fila("TMU_CODIGO") = "2000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Tej"
                If Fila("TMU_CODIGO") = "3000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Agu"
                If Fila("TMU_CODIGO") = "4000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Sue"
                If Fila("TMU_CODIGO") = "5000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "F Qui"
                If Fila("TMU_CODIGO") = "6000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "F Org"
                If Fila("TMU_CODIGO") > "6999" And Fila("TMU_CODIGO") < "7500" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Fito"
                If Fila("TMU_CODIGO") > "7999" And Fila("TMU_CODIGO") < "9000" Then Dtg_DespachoResumen(Fila_Lectura, 7) = "Kits"
                Fila_Lectura = Fila_Lectura + 1
            Next
Salto:
            fii = Dtg_DespachoResumen.CurrentCell.RowNumber.MinValue
            mycell.ColumnNumber = 0
            mycell.RowNumber = fii
            Dtg_DespachoResumen.CurrentCell = mycell
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub ActualizaGrillas()
        Cjto_Tablas1.Tables("DESPACHO").Clear()

        Cjto_Tablas1.Tables("DESPACHO_RESULTADO").Clear()
        Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").Clear()
        Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").Clear()
        Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Clear()
        Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Clear()
        Cjto_Tablas1.Tables("CARTA_ENC_DESPACHO").Clear()

        Call Carga_Grilla()
    End Sub

    Private Sub ActualizaGrillas2()
        Cjto_Tablas1.Tables("DESPACHO").Clear()

        Cjto_Tablas1.Tables("DESPACHO_RESULTADO").Clear()
        Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").Clear()
        Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Clear()
        Cjto_Tablas1.Tables("CARTA_ENC_DESPACHO").Clear()
        Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").Clear()
        Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Clear()

        Call Carga_Grilla()
    End Sub

    Private Sub Limpia_Nomina()
        Cjto_Tablas1.Tables("NOMINA_DESPACHO").Clear()
    End Sub

    Private Sub Frm_Despacho_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim FilaDes As DataRow
            Dim Fila_Lect As Integer

            Dim SP As New CapaDato
            If TipoFacturacion = "DesdeOrden" Then
                Me.ElTab1.SelectedTabPageIndex = 1

                'realizar cambio
                With SP
                    .Inicializar()
                    .AgregarParametro("@RutFactura", Aux_Rut_Facturacion, SqlDbType.NVarChar)
                    .EjecutarQueryDt("usp_CargaGrillaDespacho", Cjto_Tablas1, "DESPACHO_RESULTADO")
                End With

                For Each FilaDes In Cjto_Tablas1.Tables("DESPACHO_RESULTADO").Rows
                    If IsDBNull(FilaDes("TMU_CODIGO")) = False Then
                        If FilaDes("TMU_CODIGO") = "1000" Then FilaDes("TMU_CODIGO") = "Fol"
                        If FilaDes("TMU_CODIGO") = "2000" Then FilaDes("TMU_CODIGO") = "Tej"
                        If FilaDes("TMU_CODIGO") = "3000" Then FilaDes("TMU_CODIGO") = "Agu"
                        If FilaDes("TMU_CODIGO") = "4000" Then FilaDes("TMU_CODIGO") = "Sue"
                        If FilaDes("TMU_CODIGO") = "5000" Then FilaDes("TMU_CODIGO") = "F Qui"
                        If FilaDes("TMU_CODIGO") = "6000" Then FilaDes("TMU_CODIGO") = "F Org"
                        If FilaDes("TMU_CODIGO") = "7000" Then FilaDes("TMU_CODIGO") = "Fito"
                        If FilaDes("TMU_CODIGO") = "8000" Then FilaDes("TMU_CODIGO") = "Kits"
                    End If
                    Fila_Lect = Fila_Lect + 1
                Next
                'TabControl1.SelectedTab = TabControl1.TabPages(1)
            End If
            Call Carga_Grilla()
            Call Carga_Notas()
            Call Limpia_Nomina()
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Dtg_DespachoResumen_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_DespachoResumen.DoubleClick
        Dim fila As Integer
        fila = Dtg_DespachoResumen.CurrentCell.RowNumber
        RutFactura = Dtg_DespachoResumen(fila, 4)
        RutProductor = Dtg_DespachoResumen(fila, 3)
        Call Carga_GrillaDespacho()
        Me.ElTab1.SelectedTabPageIndex = 1
        'Me.ElTab1.SelectedTabPage = Me.TabPage2
    End Sub

    Private Sub Carga_GrillaDespacho()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow
            Dim Fila_Lect As Integer

            With SP
                .Inicializar()
                .AgregarParametro("@RutFactura", RutFactura, SqlDbType.NVarChar)
                .EjecutarQueryDt("usp_DespachoOT", Cjto_Tablas1, "DESPACHO_RESULTADO")
            End With

            For Each Fila In Cjto_Tablas1.Tables("DESPACHO_RESULTADO").Rows
                If IsDBNull(Dtg_SeleccionDatos(Fila_Lect, 9)) = False Then
                    If Fila("TMU_CODIGO") = "1000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Fol"
                    If Fila("TMU_CODIGO") = "2000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Tej"
                    If Fila("TMU_CODIGO") = "3000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Agu"
                    If Fila("TMU_CODIGO") = "4000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Sue"
                    If Fila("TMU_CODIGO") = "5000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "F Qui"
                    If Fila("TMU_CODIGO") = "6000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "F Org"
                    If Fila("TMU_CODIGO") = "7000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Fito"
                    If Fila("TMU_CODIGO") = "8000" Then Dtg_SeleccionDatos(Fila_Lect, 9) = "Kits"
                End If
                Fila_Lect = Fila_Lect + 1
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Carga_DetFact(ByVal NumOt As Integer)
        Try
            Dim Fila_OtCod, Fila_Det, Fila_Muestra As DataRow
            Dim Muestra_Aux, Largo As Integer
            Dim Descripcion_Recibo, NumLabo, Matriz As String
            Dim BusMue As Object
            Dim SP As New CapaDato
            Dim Fila As Integer

            Fila = 0
            Cjto_Tablas1.Tables("OT_CODIFICACION_PASO").Clear()

            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", NumOt, SqlDbType.Int)
                .EjecutarQueryDt("usp_CargaOtCodificacionPaso", Cjto_Tablas1, "OT_CODIFICACION_PASO")
            End With

            For Each Fila_OtCod In Cjto_Tablas1.Tables("OT_CODIFICACION_PASO").Rows
                Fila = Fila + 1
                If Fila = 1 Then
                    Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").NewRow
                    Fila_Det("DET_DETALLE") = "N° Orden de Trabajo " & NumOt
                    Fila_Det("DET_LINEA") = Fila
                    Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").Rows.Add(Fila_Det)
                    Fila += 1
                End If
                Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").NewRow

                'MUESTRA
                If Fila_OtCod("TMU_CODIGO") = 1000 Then Matriz = "Foliar"
                If Fila_OtCod("TMU_CODIGO") = 2000 Then Matriz = "Tejido"
                If Fila_OtCod("TMU_CODIGO") = 3000 Then Matriz = "Agua"
                If Fila_OtCod("TMU_CODIGO") = 4000 Then Matriz = "Suelo"
                If Fila_OtCod("TMU_CODIGO") = 5000 Then Matriz = "Fertilizante Químico"
                If Fila_OtCod("TMU_CODIGO") = 6000 Then Matriz = "Fertilizante Orgánico"
                If Fila_OtCod("TMU_CODIGO") = 7302 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7304 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7306 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7308 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7310 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 8758 Then Matriz = "Nemátodo"

                'BusMue = CInt(Mid(CStr(Fila_OtCod("ANA_CODIGO")), 1, 1) & "000")
                'Fila_Muestra = Cjto_Tablas1.Tables("MUESTRA").Rows.Find(BusMue)

                Descripcion_Recibo = Matriz & ":  "

                'Nº LAB
                If Matriz = "Fitopatológico" Then
                    NumLabo = "Nº Laboratorio " & CStr(Format(Fila_OtCod("OTC_NLAB_DESDE"), "###.###")) & "-" & CStr(Fila_OtCod("OTC_NLAB_HASTA"))
                Else
                    Largo = Len(CStr(Fila_OtCod("OTC_NLAB_HASTA")))
                    NumLabo = "Nº Laboratorio " & CStr(Format(Fila_OtCod("OTC_NLAB_DESDE"), "###.###")) & "-" & Mid(CStr(Fila_OtCod("OTC_NLAB_HASTA")), (Largo - 3))
                End If

                'Muestra + Num Lab
                Descripcion_Recibo = Descripcion_Recibo & NumLabo
                Fila_Det("DET_DETALLE") = Descripcion_Recibo
                Fila_Det("DET_LINEA") = Fila
                Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").Rows.Add(Fila_Det)
                Fila += 1

                'DESCRIPCION 
                Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").NewRow
                Fila_Det("DET_CODIGO") = Fila_OtCod("ANA_CODIGO")
                Fila_Det("DET_DETALLE") = Fila_OtCod("ANA_ANALISIS")
                Fila_Det("DET_CANTIDAD") = Fila_OtCod("OTC_CANT_MUESTRAS")
                Fila_Det("DET_PUNITARIO") = Fila_OtCod("OTC_PRECIOUN")
                Fila_Det("DET_TOTAL") = Fila_OtCod("OTC_PRECIONET")
                Fila_Det("DET_LINEA") = Fila
                Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO").Rows.Add(Fila_Det)
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Dtg_SeleccionDatos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_SeleccionDatos.DoubleClick
        Try
            Dim Fila, Fila_Exp As Integer
            Dim Fila_Data As DataRow
            Dim Fila_Despacho As DataRow
            Dim Estado As String

            Fila = Dtg_SeleccionDatos.CurrentCell.RowNumber
            NumOT = Dtg_SeleccionDatos(Fila, 0)
            Estado = Dtg_SeleccionDatos(Fila, 14)
            Call CargaDatosDespacho()
            Call CargaTablaFacturaDespacho()
            If Estado = "xF" Then
                Call Carga_DetFact(NumOT)
            Else
                NumFactura = Dtg_SeleccionDatos(Fila, 15)
                Call CargaTablaDetalleFactura()
            End If


            ' For Each Fila_Data In Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").Rows
            If IsNothing(Dtg_SeleccionDatos(Fila, 0)) = False Then
                Fila_Data = Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").NewRow()

                Fila_Data.Item("OT_NUMERO") = Dtg_SeleccionDatos(Fila, 0)
                Fila_Data.Item("OT_FECHA_ORDEN") = Dtg_SeleccionDatos(Fila, 1)
                Fila_Data.Item("PRO_PRODUCTOR") = Dtg_SeleccionDatos(Fila, 2)
                Fila_Data.Item("PRO_RUT") = Dtg_SeleccionDatos(Fila, 3)
                Fila_Data.Item("OT_FAC_RUT") = Dtg_SeleccionDatos(Fila, 4)
                Fila_Data.Item("OT_EMPRESA") = Dtg_SeleccionDatos(Fila, 5)
                Fila_Data.Item("OT_DESP_ATENCION") = Dtg_SeleccionDatos(Fila, 8)
                Fila_Data.Item("OT_SOL_NOMBRE") = Dtg_SeleccionDatos(Fila, 7)
                Fila_Data.Item("OT_REMITE") = Dtg_SeleccionDatos(Fila, 6)
                Fila_Data.Item("TMU_CODIGO") = Dtg_SeleccionDatos(Fila, 9)
                Fila_Data.Item("OTC_CANT_MUESTRAS") = Dtg_SeleccionDatos(Fila, 10)
                Fila_Data.Item("OTC_NLAB_DESDE") = Dtg_SeleccionDatos(Fila, 11)
                Fila_Data.Item("OT_ESTADO_ANA") = Dtg_SeleccionDatos(Fila, 12)
                Fila_Data.Item("OT_ESTADO_PAG") = Dtg_SeleccionDatos(Fila, 13)
                Fila_Data.Item("OT_ESTADO_FAC") = Dtg_SeleccionDatos(Fila, 14)
                Fila_Data.Item("FAC_NUMERO") = Dtg_SeleccionDatos(Fila, 15)
                Fila_Data.Item("FAC_FECHA") = Dtg_SeleccionDatos(Fila, 16)
                Fila_Data.Item("FAC_ESTADO") = Dtg_SeleccionDatos(Fila, 17)
                Fila_Data.Item("OT_EMAIL1") = Dtg_SeleccionDatos(Fila, 18)
                Fila_Data.Item("OT_EMAIL2") = Dtg_SeleccionDatos(Fila, 19)
                Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").Rows.Add(Fila_Data)
            End If

            If IsNothing(Dtg_SeleccionDatos(Fila, 0)) = False Then
                Fila_Despacho = Cjto_Tablas1.Tables("GENERA_DESPACHO").NewRow()

                Fila_Despacho.Item("OTC_NLAB_DESDE") = Dtg_SeleccionDatos(Fila, 11)
                Fila_Despacho.Item("TMU_CODIGO") = Dtg_SeleccionDatos(Fila, 9)
                Fila_Despacho.Item("OTC_CANT_MUESTRAS") = Dtg_SeleccionDatos(Fila, 10)
                Fila_Despacho.Item("PRO_PRODUCTOR") = Dtg_SeleccionDatos(Fila, 2)

                Cjto_Tablas1.Tables("GENERA_DESPACHO").Rows.Add(Fila_Despacho)
            End If
            'Next
            Txt_DesFacEmpresa.Text = Dtg_SeleccionDatos(Fila, 5)

            Me.ElTab1.SelectedTabPageIndex = 2
            'Dtg_Seleccionado_DoubleClick(sender, e)
            ' Dtg_SelFactura_DoubleClick(sender, e)


            Try
                Dim SP As New CapaDato
                Dim File As Integer = Dtg_SelFactura.CurrentCell.RowNumber
                Dim EstFac As String
                Dim NumOt As Integer = Dtg_SelFactura.Item(File, 0)
                Dim NumFact As Integer

                If IsDBNull(Dtg_SelFactura.Item(File, 17)) = True Then
                    EstFac = ""
                Else
                    EstFac = Dtg_SelFactura.Item(File, 17)
                End If

                EstadoGlo = EstFac
                'If EstFac = "xF" Then******* modificado JCruces
                If EstFac = "" Then
                    With SP
                        .Inicializar()
                        NumFact = .EjecutarEscalar("usp_NumFactura")
                        NumFact = NumFact + 1
                    End With
                    'With SP
                    '    .Inicializar()
                    '    .AgregarParametro("@NumOt", NumOt, SqlDbType.Int)
                    '    .AgregarParametro("@NumFact", NumFact, SqlDbType.Int)
                    '    .EjecutarEscalar("usp_InsertaNumFactura")
                    'End With
                    Call Carga_Datos_Despacho_Fac()
                    Call Carga_EncFactPaso(NumOt, NumFact)
                    'Call Carga_DetFactPaso(NumOt)
                Else
                    Call CargaTablaFactura()
                    Call Carga_Valores_Factura()
                    Call CargaTablaDetalleFactura2()
                    ' Call Carga_Datos_Factura()
                    Call Carga_Datos_Despacho_Fac()
                End If
                Try

                    'Arreglo_OT(i) = NumOt
                    'i = i + 1
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Catch ex As Exception
                MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
            End Try






           
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub CargaDatosDespacho()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow

            Cjto_Tablas1.Tables("DATOS_DESPACHO").Clear()
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", NumOT, SqlDbType.Int)
                .EjecutarQueryDt("usp_DatosDespacho_Prueba", Cjto_Tablas1, "DATOS_DESPACHO")
            End With

            For Each Fila In Cjto_Tablas1.Tables("DATOS_DESPACHO").Rows
                TxtDespachoNombre.Text = Fila("OT_DESP_SENORES")
                TxtDespachoAtencion.Text = Fila("OT_DESP_ATENCION")
                TxtDespachoDireccion.Text = Fila("OT_DESP_DIRECCION")
                Txt_DesComuna.Text = Fila("OT_DESP_COMUNA")
                Txt_DesCiudad.Text = Fila("OT_DESP_CIUDAD")
                TxtDespachoCasilla.Text = Fila("OT_DESP_CASILLA")
                TxtDespachoFono1.Text = Fila("OT_DESP_FONO1")
                TxtDespachoFono2.Text = Fila("OT_DESP_FONO2")
                TxtDespachoCelular1.Text = Fila("OT_DESP_CELULAR1")
                TxtDespachoCelular2.Text = Fila("OT_DESP_CELULAR2")
                TxtDespachoFax1.Text = Fila("OT_DESP_FAX1")
                TxtDespachoFax2.Text = Fila("OT_DESP_FAX2")
                TxtDespachoEmail1.Text = Fila("OT_DESP_EMAIL1")
                TxtDespachoEmail2.Text = Fila("OT_DESP_EMAIL2")
                'If Fila("OT_OBSERVACIONES") <> Nothing Then
                '    TxtObservaciones.Text = Fila("OT_OBSERVACIONES")
                'Else
                '    TxtObservaciones.Text = ""
                'End If
                If IsDBNull(Fila("OT_OBSERVACIONES")) Then
                    TxtObservaciones.Text = ""
                Else
                    TxtObservaciones.Text = Fila("OT_OBSERVACIONES")

                End If

                TxtEntrego.Text = Fila("OT_ENTREGO")
                Txt_DesFacSeñores.Text = Fila("OT_FAC_RSOCIAL")
                Txt_DesFacCiudad.Text = Fila("OT_FAC_CIUDAD")
                Txt_DesFacDireccion.Text = Fila("OT_FAC_DIRECCION")
                Txt_DesFacGiro.Text = Fila("OT_FAC_GIRO")
                Txt_DesFacF1.Text = Fila("OT_FAC_FONO1")
                Txt_DesFacF2.Text = Fila("OT_FAC_FONO2")
                Txt_DesFacComuna.Text = Fila("OT_FAC_COMUNA")
                If IsDBNull(Fila("OT_FAC_CONDICION_PAGO")) Then
                    Cbx_CondPago.Text = "Contado"
                Else
                    Cbx_CondPago.Text = Fila("OT_FAC_CONDICION_PAGO")
                End If
                'Cbx_CondPago.Text = Fila("OT_FAC_CONDICION_PAGO")
                Txt_DesFacEncPago.Text = Fila("OT_FAC_ENCPAGO")
                Txt_DesFacF1Pago.Text = Fila("OT_FAC_F1PAGO")
                Txt_DesFacF2Pago.Text = Fila("OT_FAC_F2PAGO")
                Txt_DesFacObservacion.Text = Fila("OT_FAC_OBSPAGO")
                Txt_DesFacOCompra.Text = Fila("OT_ORDENCOMPRA")

                If Fila("OT_DESP_POR_RETIRALAB") = 1 Then CbxDespRetiraLab.Checked = True
                If Fila("OT_DESP_POR_FONO") = 1 Then CbxDespAvisoFono.Checked = True
                If Fila("OT_DESP_POR_FAX") = 1 Then CbxDespFax.Checked = True
                If Fila("OT_DESP_POR_EMAIL") = 1 Then CbxDespEmail.Checked = True
                If Fila("OT_DESP_POR_CORREO") = 1 Then CbxDespCorreo.Checked = True
                If Fila("OT_DESP_POR_BUS") = 1 Then CbxDespBus.Checked = True

            Next
        Catch ex As Exception
            MsgBox("se ha producido un error en el sub 'CargaDatosDespacho', error: ", ex.Message)
        End Try

    End Sub

    Private Sub Carga_Datos_Despacho_Fac()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow
            Dim NumFila, Num_Ot As Integer

            NumFila = Dtg_SelFactura.CurrentCell.RowNumber
            Num_Ot = Dtg_SelFactura.Item(NumFila, 0)
            Cjto_Tablas1.Tables("DATOS_DESPACHO").Clear()
            With SP
                .Inicializar()
                .AgregarParametro("@NumOT", Num_Ot, SqlDbType.Int)
                .EjecutarQueryDt("usp_DatosDespacho_Prueba", Cjto_Tablas1, "DATOS_DESPACHO")
            End With

            For Each Fila In Cjto_Tablas1.Tables("DATOS_DESPACHO").Rows
                Txt_DesFacRetira.Text = Fila("OT_DESP_SENORES")
                Txt_DesFacAtencion.Text = Fila("OT_DESP_ATENCION")
                Txt_DesFacDirec.Text = Fila("OT_DESP_DIRECCION")
                Txt_DespFacComuna.Text = Fila("OT_DESP_COMUNA")
                Txt_DespFacCiudad.Text = Fila("OT_DESP_CIUDAD")
                Txt_DesFacCasilla.Text = Fila("OT_DESP_CASILLA")
                Txt_DesFacFono1.Text = Fila("OT_DESP_FONO1")
                Txt_DespFacFono2.Text = Fila("OT_DESP_FONO2")
                Txt_DesFacFax1.Text = Fila("OT_DESP_FAX1")
                Txt_DesFacFax2.Text = Fila("OT_DESP_FAX2")
                Txt_DesFacEmail1.Text = Fila("OT_DESP_EMAIL1")
                Txt_DesFacEmail2.Text = Fila("OT_DESP_EMAIL2")
                If IsDBNull(Fila("OT_OBSERVACIONES")) = True Then
                    Txt_DespFacObservacion.Text = ""
                Else
                    Txt_DespFacObservacion.Text = Fila("OT_OBSERVACIONES")
                End If
                'Txt_DespFacObservacion.Text = Fila("OT_OBSERVACIONES")
                Txt_DesFacIngSr.Text = Fila("OT_ENTREGO")
                If Fila("OT_DESP_POR_RETIRALAB") = 1 Then Check_RetLab.Checked = True
                If Fila("OT_DESP_POR_CORREO") = 1 Then CbxDespCorreo.Checked = True
                If Fila("OT_DESP_POR_BUS") = 1 Then CbxDespBus.Checked = True
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub CargaDatosSubGrupos()
        If CbxDespRetiraLab.Checked = True Then
        End If
    End Sub

    Private Sub Carga_Valores_Factura()
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow

            With SP
                .Inicializar()
                .AgregarParametro("@NumFactura", NumFactura, SqlDbType.Int)
                .EjecutarQueryDt("usp_Carga_ValoresFactura", Cjto_Tablas1, "VALORES_FACTURA_DESPACHO")
            End With

            For Each Fila In Cjto_Tablas1.Tables("VALORES_FACTURA_DESPACHO").Rows
                If IsDBNull(Fila("OT_SUBTOTAL")) = True Then Fila("OT_SUBTOTAL") = 0
                If IsDBNull(Fila("OT_NETO")) = True Then Fila("OT_NETO") = 0
                If IsDBNull(Fila("OT_IVA")) = True Then Fila("OT_IVA") = 0
                If IsDBNull(Fila("OT_DESCUENTOPOR")) = True Then Fila("OT_DESCUENTOPOR") = 0
                If IsDBNull(Fila("OT_DESCUENTOPESOS")) = True Then Fila("OT_DESCUENTOPESOS") = 0
                If IsDBNull(Fila("OT_MUESTREO_CANT")) = True Then Fila("OT_MUESTREO_CANT") = 0
                If IsDBNull(Fila("OT_MUESTREO_PRECIOUN")) = True Then Fila("OT_MUESTREO_PRECIOUN") = 0
                If IsDBNull(Fila("OT_MUESTREO")) = True Then Fila("OT_MUESTREO") = 0
                If IsDBNull(Fila("OT_ABONO")) = True Then Fila("OT_ABONO") = 0
                If IsDBNull(Fila("OT_ABONOCON")) = True Then Fila("OT_ABONOCON") = 0
                If IsDBNull(Fila("OT_TOTAL")) = True Then Fila("OT_TOTAL") = 0
                TxtAbono.Text = Fila("OT_ABONO")
                TxtMuestreoCant.Text = Fila("OT_MUESTREO_CANT")
                TxtMuestreoPrecioUn.Text = Fila("OT_MUESTREO_PRECIOUN")
                TxtDescto.Text = Fila("OT_DESCUENTOPOR")
                TxtDesctPesos.Text = Fila("OT_DESCUENTOPESOS")
                TxtSubTotal.Text = Fila("OT_SUBTOTAL")
                TxtMuestreo.Text = Fila("OT_MUESTREO")
                TxtNeto.Text = Fila("OT_NETO")
                TxtIva.Text = Fila("OT_IVA")
                TxtTotal.Text = Fila("OT_TOTAL")
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub CargaTablaFactura()
        Try
            Dim sp As New CapaDato
            Dim Fila As DataRow

            With sp
                .Inicializar()
                .AgregarParametro("@NumFactura", NumFactura, SqlDbType.Int)
                .EjecutarQueryDt("usp_CargaFactura_Prueba", Cjto_Tablas1, "Factura_Despacho")
            End With

            For Each Fila In Cjto_Tablas1.Tables("FACTURA_DESPACHO").Rows
                If IsDBNull(Fila("FAC_NUMERO")) = True Then Fila("FAC_NUMERO") = ""
                Txtfactura.Text = Fila("FAC_NUMERO")
                If IsDBNull(Fila("FAC_RUT")) = True Then Fila("FAC_RUT") = ""
                TxtRutFacturacion.Text = Fila("FAC_RUT")
                If IsDBNull(Fila("FAC_RSOCIAL")) = True Then Fila("FAC_RSOCIAL") = ""
                Txt_RSocial.Text = Fila("FAC_RSOCIAL")
                If IsDBNull(Fila("FAC_EMPRESA")) = True Then Fila("FAC_EMPRESA") = ""
                Txt_Empresa.Text = Fila("FAC_EMPRESA")
                If IsDBNull(Fila("FAC_DIRECCION")) = True Then Fila("FAC_DIRECCION") = ""
                TxtDireccion.Text = Fila("FAC_DIRECCION")
                If IsDBNull(Fila("FAC_CIUDAD")) = True Then Fila("FAC_CIUDAD") = ""
                Txt_Ciudad.Text = Fila("FAC_CIUDAD")
                If IsDBNull(Fila("FAC_COMUNA")) = True Then Fila("FAC_COMUNA") = ""
                Txt_Comuna.Text = Fila("FAC_COMUNA")
                If IsDBNull(Fila("FAC_GIRO")) = True Then Fila("FAC_GIRO") = ""
                TxtGiro.Text = Fila("FAC_GIRO")
                If IsDBNull(Fila("FAC_FONO1")) = True Then Fila("FAC_FONO1") = ""
                TxtFono1.Text = Fila("FAC_FONO1")
                If IsDBNull(Fila("FAC_FONO2")) = True Then Fila("FAC_FONO2") = ""
                TxtFono2.Text = Fila("FAC_FONO2")
                If IsDBNull(Fila("FAC_SOL_NOMBRE")) = True Then Fila("FAC_SOL_NOMBRE") = ""
                TxtSolicitadoPor.Text = Fila("FAC_SOL_NOMBRE")
                If IsDBNull(Fila("FAC_CONDICION_PAGO")) = True Then Fila("FAC_CONDICION_PAGO") = ""
                Me.cb_condpago.Text = Fila("FAC_CONDICION_PAGO")
                If IsDBNull(Fila("FAC_ENCPAGO")) = True Then Fila("FAC_ENCPAGO") = ""
                TxtEncPago.Text = Fila("FAC_ENCPAGO")
                If IsDBNull(Fila("FAC_F1PAGO")) = True Then Fila("FAC_F1PAGO") = ""
                TxtFonoPago1.Text = Fila("FAC_F1PAGO")
                If IsDBNull(Fila("FAC_F2PAGO")) = True Then Fila("FAC_F2PAGO") = ""
                TxtFonoPago2.Text = Fila("FAC_F2PAGO")
                If IsDBNull(Fila("FAC_OBSPAGO")) = True Then Fila("FAC_OBSPAGO") = ""
                TxtObsPago.Text = Fila("FAC_OBSPAGO")
                If IsDBNull(Fila("FAC_ORDEN_COMPRA")) = True Then Fila("FAC_ORDEN_COMPRA") = 0
                TxtOrdenCompra.Text = Fila("FAC_ORDEN_COMPRA")
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub CargaTablaDetalleFactura()
        Dim SP As New CapaDato
        With SP
            .Inicializar()
            .AgregarParametro("@Num_Factura", NumFactura, SqlDbType.Int)
            .EjecutarQueryDt("usp_CargaDetalleFactura", Cjto_Tablas1, "FACTURA_DETALLE_DESPACHO")
        End With
    End Sub

    Private Sub CargaTablaDetalleFactura2()
        Dim SP As New CapaDato
        With SP
            .Inicializar()
            .AgregarParametro("@Num_Factura", NumFactura, SqlDbType.Int)
            .EjecutarQueryDt("usp_CargaDetalleFactura", Cjto_Tablas1, "FACTURA_DETALLE_DESPACHO1")
        End With

    End Sub

    Private Sub CargaTablaFacturaDespacho()
        Try
            Dim sp As New CapaDato
            Dim Fila As DataRow
            Cjto_Tablas1.Tables("FACTURA_DESPACHO1").Clear()
            With sp
                .Inicializar()
                .AgregarParametro("@NumFactura", NumFactura, SqlDbType.Int)
                .EjecutarQueryDt("usp_CargaFactura_prueba", Cjto_Tablas1, "FACTURA_DESPACHO1")
            End With

            For Each Fila In Cjto_Tablas1.Tables("FACTURA_DESPACHO1").Rows
                'If IsDBNull(Fila("FAC_NUMERO")) = True Then Fila("FAC_NUMERO") = ""
                'TxtFactura.Text = Fila("FAC_NUMERO")
                'If IsDBNull(Fila("FAC_RUT")) = True Then Fila("FAC_RUT") = ""
                'TxtRutFacturacion.Text = Fila("FAC_RUT")
                If IsDBNull(Fila("FAC_RSOCIAL")) = True Then Fila("FAC_RSOCIAL") = ""
                Txt_DesFacSeñores.Text = Fila("FAC_RSOCIAL")
                If IsDBNull(Fila("FAC_EMPRESA")) = True Then Fila("FAC_EMPRESA") = ""
                Txt_DesFacEmpresa.Text = Fila("FAC_EMPRESA")
                If IsDBNull(Fila("FAC_DIRECCION")) = True Then Fila("FAC_DIRECCION") = ""
                Txt_DesFacDireccion.Text = Fila("FAC_DIRECCION")
                If IsDBNull(Fila("FAC_CIUDAD")) = True Then Fila("FAC_CIUDAD") = ""
                Txt_DesFacCiudad.Text = Fila("FAC_CIUDAD")
                If IsDBNull(Fila("FAC_COMUNA")) = True Then Fila("FAC_COMUNA") = ""
                Txt_DesFacComuna.Text = Fila("FAC_COMUNA")
                If IsDBNull(Fila("FAC_GIRO")) = True Then Fila("FAC_GIRO") = ""
                Txt_DesFacGiro.Text = Fila("FAC_GIRO")
                If IsDBNull(Fila("FAC_FONO1")) = True Then Fila("FAC_FONO1") = ""
                Txt_DesFacF1.Text = Fila("FAC_FONO1")
                If IsDBNull(Fila("FAC_FONO2")) = True Then Fila("FAC_FONO2") = ""
                Txt_DesFacF2.Text = Fila("FAC_FONO2")
                If IsDBNull(Fila("FAC_SOL_NOMBRE")) = True Then Fila("FAC_SOL_NOMBRE") = ""
                Txt_DesFacSolicita.Text = Fila("FAC_SOL_NOMBRE")
                'If IsDBNull(Fila("FAC_CONDICION_PAGO")) = True Then Fila("FAC_CONDICION_PAGO") = ""
                'Txt_DesFac.Text = Fila("FAC_CONDICION_PAGO")
                If IsDBNull(Fila("FAC_ENCPAGO")) = True Then Fila("FAC_ENCPAGO") = ""
                Txt_DesFacEncPago.Text = Fila("FAC_ENCPAGO")
                If IsDBNull(Fila("FAC_F1PAGO")) = True Then Fila("FAC_F1PAGO") = ""
                Txt_DesFacF1Pago.Text = Fila("FAC_F1PAGO")
                If IsDBNull(Fila("FAC_F2PAGO")) = True Then Fila("FAC_F2PAGO") = ""
                Txt_DesFacF2Pago.Text = Fila("FAC_F2PAGO")
                If IsDBNull(Fila("FAC_OBSPAGO")) = True Then Fila("FAC_OBSPAGO") = ""
                Txt_DesFacObservacion.Text = Fila("FAC_OBSPAGO")
                If IsDBNull(Fila("FAC_ORDEN_COMPRA")) = True Then Fila("FAC_ORDEN_COMPRA") = ""
                Txt_DesFacOCompra.Text = Fila("FAC_ORDEN_COMPRA")

            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Carga_EncFactPaso(ByVal Numero_OT As Integer, ByVal NumeroFactura As Integer)
        Try
            Dim SP As New CapaDato
            Dim Fila As DataRow
            Cjto_Tablas1.Tables("FACTURA_DESPACHO_PASO").Clear()
            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", Numero_OT, SqlDbType.Int)
                .EjecutarQueryDt("usp_CargaEncFacturaPaso_Prueba", Cjto_Tablas1, "FACTURA_DESPACHO_PASO")
            End With

            ' Inserta datos en los campos
            Dim dsNFacE As DataSet
            With SP
                .Inicializar()
                .AgregarParametro("@opcion", "E", SqlDbType.VarChar)
                dsNFacE = .EjecutarQuery("ys_ObtieneFacNumero")

            End With



            Txtfactura.Text = dsNFacE.Tables(0).Rows.Item(0).Item(0).ToString


            For Each Fila In Cjto_Tablas1.Tables("FACTURA_DESPACHO_PASO").Rows
                If IsDBNull(Fila("OT_FAC_RUT")) = True Then Fila("OT_FAC_RUT") = ""
                TxtRutFacturacion.Text = Fila("OT_FAC_RUT")
                If IsDBNull(Fila("OT_FAC_RSOCIAL")) = True Then Fila("OT_FAC_RSOCIAL") = ""
                Txt_RSocial.Text = Fila("OT_FAC_RSOCIAL")
                If IsDBNull(Fila("OT_EMPRESA")) = True Then Fila("OT_EMPRESA") = ""
                Txt_Empresa.Text = Fila("OT_EMPRESA")
                If IsDBNull(Fila("OT_FAC_DIRECCION")) = True Then Fila("OT_FAC_DIRECCION") = ""
                TxtDireccion.Text = Fila("OT_FAC_DIRECCION")
                If IsDBNull(Fila("OT_FAC_CIUDAD")) = True Then Fila("OT_FAC_CIUDAD") = ""
                Txt_Ciudad.Text = Fila("OT_FAC_CIUDAD")
                If IsDBNull(Fila("OT_FAC_COMUNA")) = True Then Fila("OT_FAC_COMUNA") = ""
                Txt_Comuna.Text = Fila("OT_FAC_COMUNA")
                If IsDBNull(Fila("OT_FAC_GIRO")) = True Then Fila("OT_FAC_GIRO") = ""
                TxtGiro.Text = Fila("OT_FAC_GIRO")
                If IsDBNull(Fila("OT_FAC_FONO1")) = True Then Fila("OT_FAC_FONO1") = ""
                TxtFono1.Text = Fila("OT_FAC_FONO1")
                If IsDBNull(Fila("OT_FAC_FONO2")) = True Then Fila("OT_FAC_FONO2") = ""
                TxtFono2.Text = Fila("OT_FAC_FONO2")
                If IsDBNull(Fila("OT_SOL_NOMBRE")) = True Then Fila("OT_SOL_NOMBRE") = ""
                TxtSolicitadoPor.Text = Fila("OT_SOL_NOMBRE")
                If IsDBNull(Fila("OT_FAC_CONDICION_PAGO")) = True Then Fila("OT_FAC_CONDICION_PAGO") = ""
                Me.cb_condpago.Text = Fila("OT_FAC_CONDICION_PAGO")
                If IsDBNull(Fila("OT_FAC_ENCPAGO")) = True Then Fila("OT_FAC_ENCPAGO") = ""
                TxtEncPago.Text = Fila("OT_FAC_ENCPAGO")
                If IsDBNull(Fila("OT_FAC_F1PAGO")) = True Then Fila("OT_FAC_F1PAGO") = ""
                TxtFonoPago1.Text = Fila("OT_FAC_F1PAGO")
                If IsDBNull(Fila("OT_FAC_F2PAGO")) = True Then Fila("OT_FAC_F2PAGO") = ""
                TxtFonoPago2.Text = Fila("OT_FAC_F2PAGO")
                If IsDBNull(Fila("OT_FAC_OBSPAGO")) = True Then Fila("OT_FAC_OBSPAGO") = ""
                TxtObsPago.Text = Fila("OT_FAC_OBSPAGO")
                If IsDBNull(Fila("OT_ORDENCOMPRA")) = True Then Fila("OT_ORDENCOMPRA") = ""
                TxtOrdenCompra.Text = Fila("OT_ORDENCOMPRA")
                If IsDBNull(Fila("OT_DESCUENTOPOR")) = True Then Fila("OT_DESCUENTOPOR") = 0
                TxtDescto.Text = Fila("OT_DESCUENTOPOR")
                If IsDBNull(Fila("OT_DESCUENTOPESOS")) = True Then Fila("OT_DESCUENTOPESOS") = 0
                TotalDesc = Fila("OT_DESCUENTOPESOS") + TotalDesc
                TxtDesctPesos.Text = TotalDesc
                If IsDBNull(Fila("OT_SUBTOTAL")) = True Then Fila("OT_SUBTOTAL") = 0
                SubTotal = Fila("OT_SUBTOTAL") + SubTotal
                TxtSubTotal.Text = SubTotal
                If IsDBNull(Fila("OT_NETO")) = True Then Fila("OT_NETO") = 0
                Neto = Fila("OT_NETO") + Neto
                TxtNeto.Text = Neto
                If IsDBNull(Fila("OT_IVA")) = True Then Fila("OT_IVA") = 0
                Iva = Fila("OT_IVA") + Iva
                TxtIva.Text = Iva

                'If IsDBNull(Fila("OT_DESCUENTOPOR")) = True Then Fila("OT_DESCUENTOPOR") = 0
                'TxtDescto.Text = Fila("OT_DESCUENTOPOR")
                'If IsDBNull(Fila("OT_DESCUENTOPESOS")) = True Then Fila("OT_DESCUENTOPESOS") = 0
                'TxtDesctPesos.Text = Fila("OT_DESCUENTOPESOS")

                If IsDBNull(Fila("OT_MUESTREO_CANT")) = True Then Fila("OT_MUESTREO_CANT") = 0
                CantMuestreo = Fila("OT_MUESTREO_CANT") + CantMuestreo
                TxtMuestreoCant.Text = CantMuestreo
                If IsDBNull(Fila("OT_MUESTREO_PRECIOUN")) = True Then Fila("OT_MUESTREO_PRECIOUN") = 0
                TxtMuestreoPrecioUn.Text = Fila("OT_MUESTREO_PRECIOUN")
                If IsDBNull(Fila("OT_MUESTREO")) = True Then Fila("OT_MUESTREO") = 0
                Muestreo = Fila("OT_MUESTREO") + Muestreo
                TxtMuestreo.Text = Muestreo
                If IsDBNull(Fila("OT_ABONO")) = True Then Fila("OT_ABONO") = 0
                Abono = Fila("OT_ABONO") + Abono
                TxtAbono.Text = Abono
                'If IsDBNull(Fila("OT_ABONOCON")) = True Then Fila("OT_ABONOCON") = ""
                'TxtAbono.Text = Fila("OT_ABONOCON")
                If IsDBNull(Fila("OT_TOTAL")) = True Then Fila("OT_TOTAL") = 0
                Total = Fila("OT_TOTAL") + Total
                TxtTotal.Text = Total
                TxtSaldo.Text = Total - Abono
                If IsDBNull(Fila("OT_FECHA_CANCELADA")) = True Then
                    TxtFechaCancelacion.Text = ""
                Else
                    TxtFechaCancelacion.Text = Fila("OT_FECHA_CANCELADA")
                End If
                If Fila("OT_ESTADO_PAG") = "Can" Then
                    ChkCancelado.Checked = True
                End If
            Next
        Catch ex As Exception
            MsgBox("Error " & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Carga_DetFactPaso(ByVal NumOt As Integer)
        Try
            Dim Fila_OtCod, Fila_Det, Fila_Muestra As DataRow
            Dim Muestra_Aux, Largo As Integer
            Dim Descripcion_Recibo, NumLabo, Matriz As String
            Dim BusMue As Object
            Dim SP As New CapaDato
            Dim Fila As Integer
            Fila = 0
            ' Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Clear()
            Cjto_Tablas1.Tables("OT_CODIFICACION_PASO").Clear()

            With SP
                .Inicializar()
                .AgregarParametro("@NumOt", NumOt, SqlDbType.Int)
                .EjecutarQueryDt("usp_CargaOtCodificacionPaso", Cjto_Tablas1, "OT_CODIFICACION_PASO")
            End With

            For Each Fila_OtCod In Cjto_Tablas1.Tables("OT_CODIFICACION_PASO").Rows
                Fila = Fila + 1
                If Fila = 1 Then
                    Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").NewRow
                    Fila_Det("DET_DETALLE") = "N° Orden de Trabajo " & NumOt
                    Fila_Det("DET_LINEA") = Fila
                    Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows.Add(Fila_Det)
                    Fila += 1
                End If
                Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").NewRow

                'MUESTRA
                If Fila_OtCod("TMU_CODIGO") = 1000 Then Matriz = "Foliar"
                If Fila_OtCod("TMU_CODIGO") = 2000 Then Matriz = "Tejido"
                If Fila_OtCod("TMU_CODIGO") = 3000 Then Matriz = "Agua"
                If Fila_OtCod("TMU_CODIGO") = 4000 Then Matriz = "Suelo"
                If Fila_OtCod("TMU_CODIGO") = 5000 Then Matriz = "Fertilizante Químico"
                If Fila_OtCod("TMU_CODIGO") = 6000 Then Matriz = "Fertilizante Orgánico"
                If Fila_OtCod("TMU_CODIGO") = 7000 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7302 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7304 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7306 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7308 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 7310 Then Matriz = "Fitopatológico"
                If Fila_OtCod("TMU_CODIGO") = 8758 Then Matriz = "Nemátodo"
                If Fila_OtCod("TMU_CODIGO") = 8000 Then Matriz = "Ventas"

                'BusMue = CInt(Mid(CStr(Fila_OtCod("ANA_CODIGO")), 1, 1) & "000")
                'Fila_Muestra = Cjto_Tablas1.Tables("MUESTRA").Rows.Find(BusMue)

                Descripcion_Recibo = Matriz & ":  "

                'Nº LAB
                Largo = Len(CStr(Fila_OtCod("OTC_NLAB_HASTA")))
                NumLabo = "Nº Laboratorio " & CStr(Format(Fila_OtCod("OTC_NLAB_DESDE"), "###.###")) & "-" & Mid(CStr(Fila_OtCod("OTC_NLAB_HASTA")), (Largo - 3))

                'Muestra + Num Lab
                Descripcion_Recibo = Descripcion_Recibo & NumLabo
                Fila_Det("DET_DETALLE") = Descripcion_Recibo
                Fila_Det("DET_LINEA") = Fila
                Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows.Add(Fila_Det)
                Fila += 1

                'DESCRIPCION 
                Fila_Det = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").NewRow
                Fila_Det("DET_CODIGO") = Fila_OtCod("ANA_CODIGO")
                Fila_Det("DET_DETALLE") = Fila_OtCod("ANA_ANALISIS")
                Fila_Det("DET_CANTIDAD") = Fila_OtCod("OTC_CANT_MUESTRAS")
                Fila_Det("DET_PUNITARIO") = Fila_OtCod("OTC_PRECIOUN")
                Fila_Det("DET_TOTAL") = Fila_OtCod("OTC_PRECIONET")
                Fila_Det("DET_LINEA") = Fila
                Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows.Add(Fila_Det)
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Dtg_SelFactura_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_SelFactura.DoubleClick
        'Try
        '    Dim SP As New CapaDato
        Dim File As Integer = Dtg_SelFactura.CurrentCell.RowNumber
        '    Dim EstFac As String
        Dim NumOt As Integer = Dtg_SelFactura.Item(File, 0)
        '    Dim NumFact As Integer

        '    If IsDBNull(Dtg_SelFactura.Item(File, 17)) = True Then
        '        EstFac = ""
        '    Else
        '        EstFac = Dtg_SelFactura.Item(File, 17)
        '    End If

        '    EstadoGlo = EstFac
        '    'If EstFac = "xF" Then******* modificado JCruces
        '    If EstFac = "" Then
        '        With SP
        '            .Inicializar()
        '            NumFact = .EjecutarEscalar("usp_NumFactura")
        '            NumFact = NumFact + 1
        '        End With
        '        'With SP
        '        '    .Inicializar()
        '        '    .AgregarParametro("@NumOt", NumOt, SqlDbType.Int)
        '        '    .AgregarParametro("@NumFact", NumFact, SqlDbType.Int)
        '        '    .EjecutarEscalar("usp_InsertaNumFactura")
        '        'End With
        '        Call Carga_Datos_Despacho_Fac()
        '        Call Carga_EncFactPaso(NumOt, NumFact)
        Call Carga_DetFactPaso(NumOT)
        '    Else
        'Call CargaTablaFactura()
        'Call Carga_Valores_Factura()
        'Call CargaTablaDetalleFactura2()
        '' Call Carga_Datos_Factura()
        'Call Carga_Datos_Despacho_Fac()
        '    End If
        'Try

        Arreglo_OT(i) = NumOT
        i = i + 1
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        'Catch ex As Exception
        '    MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        'End Try
        Try
            Dim Total_Sf2 As Integer
            Dim palabra_valor2 As String
            Total_Sf2 = Format(CInt(TxtTotal.Text), "#######")
            palabra_valor2 = Letras(CStr(Total_Sf2))
            Me.txt_son.Text = "Son : " & UCase(Mid(palabra_valor2, 1, 1)) & Mid(palabra_valor2, 2) & "  pesos"

        Catch ex As Exception

        End Try
       

    End Sub

    Private Sub Dtg_Seleccionado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Seleccionado.DoubleClick
        Dim numOt, fila As Integer
        Dim Fila_Dat As DataRow
        Dim SP As New CapaDato
        fila = Dtg_Seleccionado.CurrentCell.RowNumber
        numOt = Dtg_Seleccionado.Item(fila, 0)

        For Each Fila_Dat In Cjto_Tablas1.Tables("DESPACHO_RESULTADO1").Rows
            If Fila_Dat.Item("OT_NUMERO") = numOt Then
                Fila_Dat.Table.Rows.Remove(Fila_Dat)
            End If
        Next
    End Sub

    Private Sub Carga_Datos_Factura()
        Try
            Dim Fila As DataRow
            Dim Suma As Integer = 0

            If TxtAbono.Text = "" Then TxtAbono.Text = 0
            If TxtSaldo.Text = "" Then TxtSaldo.Text = 0
            If TxtMuestreoCant.Text = "" Then TxtMuestreoCant.Text = 0
            If TxtMuestreoPrecioUn.Text = "" Then TxtMuestreoPrecioUn.Text = 0
            If TxtDesctPesos.Text = "" Then TxtDesctPesos.Text = 0
            If TxtMuestreo.Text = "" Then TxtMuestreo.Text = 0
            If TxtDescto.Text = "" Then TxtDescto.Text = 0
            If TxtOrdenCompra.Text = "" Then TxtOrdenCompra.Text = 0

            For Each Fila In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
                Suma = Suma + CInt(Fila("DET_TOTAL"))
                TxtSubTotal.Text = Suma
                TxtNeto.Text = CInt(TxtSubTotal.Text)
                TxtIva.Text = CInt(Suma * (Pa_Iva / 100))
                TxtTotal.Text = CInt(TxtNeto.Text) + CInt(TxtIva.Text)
            Next
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Actualiza_Datos_Muestreo()
        Dim Muestreo As Integer
        Muestreo = CInt(TxtMuestreoCant.Text) * CInt(TxtMuestreoPrecioUn.Text)
        TxtMuestreo.Text = Muestreo
        TxtNeto.Text = CInt(TxtMuestreo.Text) + CInt(TxtSubTotal.Text)
        TxtIva.Text = CInt(TxtNeto.Text * (Pa_Iva / 100))
        TxtTotal.Text = CInt(TxtNeto.Text) + CInt(TxtIva.Text)
    End Sub

    Private Sub TxtMuestreoPrecioUn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreoPrecioUn.KeyPress
        Dim totalmuestreo As Integer
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If Me.TxtMuestreoCant.Text = 0 Then MsgBox("Falta cantidad de Muestreos") : GoTo falta
            totalmuestreo = CInt(TxtMuestreoCant.Text) * CInt(TxtMuestreoPrecioUn.Text)
            Me.TxtMuestreo.Text = Format(totalmuestreo, "####,##0")
            Me.TxtMuestreoPrecioUn.Text = Format(CInt(TxtMuestreoPrecioUn.Text), "###,##0")
            Call Calcula_Valores_Factura()
        End If
falta:
        'Comentado x Jorge 06-11-2008
        'If e.KeyChar = Chr(13) Then
        '    Call Actualiza_Datos_Muestreo()
        'End If
    End Sub

    Private Sub Imprime_Excel()
        Try
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim Fila As Integer
            Dim Nlab, Cantidad, Final, Largo, i, Año As Integer
            Dim Prod, Dat, Tipo As String
            Dim Destino As String


            Fila = Dtg_SelFactura.CurrentCell.RowNumber
            Nlab = Dtg_SelFactura(Fila, 11)
            Cantidad = Dtg_SelFactura(Fila, 10)
            Prod = Dtg_SelFactura(Fila, 2)
            Tipo = Dtg_SelFactura(Fila, 9)
            Año = Mid(Dtg_SelFactura(Fila, 1), 7, 10)

            Final = Nlab + Cantidad
            Final = Final - 1
            'Largo = Len(CStr(Final))
            Dat = Mid(Final, 4, 3)


            Dim sRutaDestino As String

            Dim MyDate As Date, sAño As String

            sRutaDestino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys"
            If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
                MkDir(sRutaDestino)
            End If



            If Tipo = "Fol" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Agu" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Agua-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Agua-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Tej" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Frutos-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Frutos-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Sue" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Suelo-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Suelo-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            '+++++++++++++++++ EJEMPLO DE COMO SE GUARDAN LOS RESULTADOS +++++++++++++++++++++'

            'Destino = "F:\Mis documentos\" & Año & ".Foliar-Labsys\127339          Fernando Bravo Herrera"

            '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++'



            m_Excel = CreateObject("EXCEL.APPLICATION")
            objLibroExcel = m_Excel.Workbooks.Open(Destino)
            m_Excel.Visible = True

        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Envia_Outlook()
        Try
            Dim mOutLookApp As Outlook.Application
            Dim mNameSpace As Outlook.NameSpace
            Dim mItem As Outlook.MailItem
            Dim colAttach As Outlook.Attachments
            Dim l_Attach As Outlook.Attachment
            Dim Direccion, Copia, Asunto As String
            Dim fila As Integer
            Dim Destino As String
            Dim Nlab, Cantidad, Final, Largo, i, Año As Integer
            Dim Prod, Dat, Tipo As String

            fila = Dtg_SelFactura.CurrentCell.RowNumber
            Nlab = Dtg_SelFactura(fila, 11)
            Cantidad = Dtg_SelFactura(fila, 10)
            Prod = Dtg_SelFactura(fila, 2)
            Tipo = Dtg_SelFactura(fila, 9)
            Año = Mid(Dtg_SelFactura(fila, 1), 7, 10)

            Final = Nlab + Cantidad
            Final = Final - 1
            'Largo = Len(CStr(Final))
            Dat = Mid(Final, 4, 3)

            Dim sRutaDestino As String

            Dim MyDate As Date, sAño As String

            sRutaDestino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys"
            If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
                MkDir(sRutaDestino)
            End If


            If Tipo = "Fol" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Foliar-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Agu" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Agua-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Agua-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Tej" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Frutos-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Frutos-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If

            If Tipo = "Sue" Then
                If Final > Nlab Then
                    Destino = "F:\Archivos LabSys\" & Año & ".Suelo-Labsys\" & Nlab & "-" & Dat & "   " & Prod & ".xls"
                Else
                    Destino = "F:\Archivos LabSys\" & Año & ".Suelo-Labsys\" & Nlab & "          " & Prod & ".xls"
                End If
            End If


            fila = Dtg_SelFactura.CurrentCell.RowNumber
            'Direccion = Dtg_SelFactura.Item(fila, 18)
            Direccion = Txt_DesFacEmail1.Text
            'Copia = Dtg_SelFactura.Item(fila, 19)
            Copia = Txt_DesFacEmail2.Text
            Asunto = "Envio de Resultados Agrolab"

            mOutLookApp = New Outlook.Application
            mNameSpace = mOutLookApp.GetNamespace("MAPI")
            'mNameSpace.Logon(, , False, True)
            mItem = mOutLookApp.CreateItem(0)

            mItem.To = Direccion
            mItem.CC = Copia
            mItem.Subject = Asunto
            colAttach = mItem.Attachments
            l_Attach = colAttach.Add(Destino)
            mItem.Display()
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Bt_EmailResultados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Envia_Outlook()
    End Sub

    Private Sub Check_RetLab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_RetLab.Click
        Txt_DesFacRetira.Enabled = True
        Txt_DesFacAtencion.Enabled = True
        Txt_DesFacIngSr.Enabled = True
        Txt_DesFacDirec.Enabled = False
        Txt_DespFacComuna.Enabled = False
        Txt_DespFacCiudad.Enabled = False
        Txt_DesFacCasilla.Enabled = False
        Txt_DesFacFono1.Enabled = False
        Txt_DespFacFono2.Enabled = False
        Txt_DespFacObservacion.Enabled = True
        Txt_DesFacEmail1.Enabled = False
        Txt_DesFacEmail2.Enabled = False
        Txt_DesFacFax1.Enabled = False
        Txt_DesFacFax2.Enabled = False
    End Sub

    Private Sub Check_Email_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_Email.Click
        Txt_DesFacRetira.Enabled = True
        Txt_DesFacAtencion.Enabled = True
        Txt_DesFacIngSr.Enabled = True
        Txt_DesFacDirec.Enabled = False
        Txt_DespFacComuna.Enabled = False
        Txt_DespFacCiudad.Enabled = False
        Txt_DesFacCasilla.Enabled = False
        Txt_DesFacFono1.Enabled = False
        Txt_DespFacFono2.Enabled = False
        Txt_DespFacObservacion.Enabled = True
        Txt_DesFacEmail1.Enabled = True
        Txt_DesFacEmail2.Enabled = True
        Txt_DesFacFax1.Enabled = False
        Txt_DesFacFax2.Enabled = False
    End Sub

    Private Sub Check_Fax_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_Fax.Click
        Txt_DesFacRetira.Enabled = True
        Txt_DesFacAtencion.Enabled = True
        Txt_DesFacIngSr.Enabled = True
        Txt_DesFacDirec.Enabled = False
        Txt_DespFacComuna.Enabled = False
        Txt_DespFacCiudad.Enabled = False
        Txt_DesFacCasilla.Enabled = False
        Txt_DesFacFono1.Enabled = False
        Txt_DespFacFono2.Enabled = False
        Txt_DespFacObservacion.Enabled = True
        Txt_DesFacEmail1.Enabled = False
        Txt_DesFacEmail2.Enabled = False
        Txt_DesFacFax1.Enabled = True
        Txt_DesFacFax2.Enabled = True
    End Sub

    Private Sub Check_Correo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_Correo.Click
        Txt_DesFacRetira.Enabled = True
        Txt_DesFacAtencion.Enabled = True
        Txt_DesFacIngSr.Enabled = True
        Txt_DesFacDirec.Enabled = True
        Txt_DespFacComuna.Enabled = True
        Txt_DespFacCiudad.Enabled = True
        Txt_DesFacCasilla.Enabled = True
        Txt_DesFacFono1.Enabled = True
        Txt_DespFacFono2.Enabled = True
        Txt_DespFacObservacion.Enabled = True
        Txt_DesFacEmail1.Enabled = False
        Txt_DesFacEmail2.Enabled = False
        Txt_DesFacFax1.Enabled = False
        Txt_DesFacFax2.Enabled = False
    End Sub

    Private Sub Check_Bus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Check_Bus.Click
        Txt_DesFacRetira.Enabled = True
        Txt_DesFacAtencion.Enabled = True
        Txt_DesFacIngSr.Enabled = True
        Txt_DesFacDirec.Enabled = True
        Txt_DespFacComuna.Enabled = True
        Txt_DespFacCiudad.Enabled = True
        Txt_DesFacCasilla.Enabled = True
        Txt_DesFacFono1.Enabled = True
        Txt_DespFacFono2.Enabled = True
        Txt_DespFacObservacion.Enabled = True
        Txt_DesFacEmail1.Enabled = False
        Txt_DesFacEmail2.Enabled = False
        Txt_DesFacFax1.Enabled = False
        Txt_DesFacFax2.Enabled = False
    End Sub

    Private Sub Txt_DesFacRetira_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacRetira.KeyPress
        If e.KeyChar = Chr(13) Then
            Dim NOMBREX As String
            If e.KeyChar = Chr(13) Then
                NOMBREX = Txt_DesFacRetira.Text
                Call control_nombre(NOMBREX)
                Txt_DesFacRetira.Text = NOMBREX
                Me.Txt_DesFacAtencion.Focus()
            End If
            TxtNombreRetira.Text = Txt_DesFacRetira.Text
        End If
    End Sub

    Private Sub Bt_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Grabar.Click

        Dim SP As New CapaDato
        Dim Fila As Integer
        Fila = Dtg_SeleccionDatos.CurrentCell.RowNumber
        With SP
            Try
                .Inicializar()
                .AgregarParametro("@NumOT", Dtg_SeleccionDatos.Item(Fila, 0), SqlDbType.Int)
                .AgregarParametro("@Señor", TxtDespachoNombre.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Atencion", TxtDespachoAtencion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Direccion", TxtDespachoDireccion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Casilla", TxtDespachoCasilla.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Comuna", Txt_DesComuna.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Ciudad", Txt_DesCiudad.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fecha", DTPDespachoFecha.Text, SqlDbType.DateTime)
                .AgregarParametro("@Fono1", TxtDespachoFono1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono2", TxtDespachoFono2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Cel1", TxtDespachoCelular1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Cel2", TxtDespachoCelular2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fax1", TxtDespachoFax1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fax2", TxtDespachoFax2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Email1", TxtDespachoEmail1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Email2", TxtDespachoEmail2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Observaciones", TxtObservaciones.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Entrego", TxtEntrego.Text, SqlDbType.NVarChar)
                .EjecutarEscalar("usp_ActualizaDatosDespacho")
                MsgBox("Grabación Finalizada")

            Catch ex As Exception
                MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
            End Try

        End With
    End Sub

    Private Sub Graba_Detalle_Factura()
        Dim sp As New CapaDato
        Dim Fila As DataRow
        Dim cont As Integer = 1

        For Each Fila In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
            Try
                With sp
                    .Inicializar()
                    .AgregarParametro("@fac_numero", CInt(Txtfactura.Text), SqlDbType.Int)
                    .AgregarParametro("@linea", cont, SqlDbType.Int)

                    If IsDBNull(Fila("DET_CODIGO")) = True Then Fila("DET_CODIGO") = 0
                    .AgregarParametro("@codigo", CInt(Fila("DET_CODIGO")), SqlDbType.Int)

                    If IsDBNull(Fila("DET_DETALLE")) = True Then Fila("DET_DETALLE") = 0
                    .AgregarParametro("@detalle", Fila("DET_DETALLE"), SqlDbType.NVarChar)

                    If IsDBNull(Fila("DET_CANTIDAD")) = True Then Fila("DET_CANTIDAD") = 0
                    .AgregarParametro("@cantidad", CInt(Fila("DET_CANTIDAD")), SqlDbType.Int)

                    If IsDBNull(Fila("DET_PUNITARIO")) = True Then Fila("DET_PUNITARIO") = 0
                    .AgregarParametro("@pre_unitario", CInt(Fila("DET_PUNITARIO")), SqlDbType.Int)

                    If IsDBNull(Fila("DET_TOTAL")) = True Then Fila("DET_TOTAL") = 0
                    .AgregarParametro("@total", CInt(Fila("DET_TOTAL")), SqlDbType.Int)

                    .EjecutarEscalar("usp_grabaDetalleFactura")
                End With
            Catch ex As Exception
                MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
            End Try
            cont = cont + 1
        Next
    End Sub

    Private Sub Actualizafactura()
        Try
            Dim SP As New CapaDato
            With SP
                .Inicializar()
                .AgregarParametro("@NumFactura", CInt(Txtfactura.Text), SqlDbType.Int)
                .AgregarParametro("@FechaFac", DTPFechaIng.Text, SqlDbType.DateTime)
                .AgregarParametro("@RSocial", Txt_RSocial.Text, SqlDbType.NVarChar)
                .AgregarParametro("@RutFactura", TxtRutFacturacion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Empresa", Txt_Empresa.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Direccion", TxtDireccion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Ciudad", Txt_Ciudad.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Giro", TxtGiro.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Comuna", Txt_Comuna.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono1", TxtFono1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono2", TxtFono2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@CondPago", "", SqlDbType.NVarChar)
                .AgregarParametro("@Solicita", TxtSolicitadoPor.Text, SqlDbType.NVarChar)
                .AgregarParametro("@EncPago", TxtEncPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@F1Pago", TxtFonoPago1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@F2Pago", TxtFonoPago2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Observacion", TxtObsPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@SubTotal", CInt(TxtSubTotal.Text), SqlDbType.Int)
                .AgregarParametro("@Neto", CInt(TxtNeto.Text), SqlDbType.Int)
                .AgregarParametro("@Iva", CInt(TxtIva.Text), SqlDbType.Int)
                .AgregarParametro("@DescuentoPor", CInt(TxtDescto.Text), SqlDbType.Int)
                .AgregarParametro("@DescuentoPesos", CInt(TxtDesctPesos.Text), SqlDbType.Int)
                .AgregarParametro("@Muest_Cant", CInt(TxtMuestreoCant.Text), SqlDbType.Int)
                .AgregarParametro("@Muest_PreciUnit", CInt(TxtMuestreoPrecioUn.Text), SqlDbType.Int)
                .AgregarParametro("@Muestreo", CInt(TxtMuestreo.Text), SqlDbType.Int)
                .AgregarParametro("@Abono", CInt(TxtAbono.Text), SqlDbType.Int)
                .AgregarParametro("@Total", CInt(TxtTotal.Text), SqlDbType.Int)
                .AgregarParametro("@Fecha_Retiro", TxtFechaRetiro.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Nombre_Retira", TxtNombreRetira.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Rut_Retira", TxtRutRetira.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Recinto", TxtRecintoRetira.Text, SqlDbType.NVarChar)

                If ChkCancelado.Checked = True Then
                    .AgregarParametro("@Fac_Estado", "Can", SqlDbType.NVarChar)
                    .AgregarParametro("@Fecha_Cancela", TxtFechaCancelacion.Text, SqlDbType.NVarChar)
                Else
                    .AgregarParametro("@Fac_Estado", "Pte", SqlDbType.NVarChar)
                    .AgregarParametro("@Fecha_Cancela", "", SqlDbType.NVarChar)
                End If
                .AgregarParametro("@Usuario", "", SqlDbType.NVarChar)
                .AgregarParametro("@OrdenCompra", TxtOrdenCompra.Text, SqlDbType.NVarChar)
                .EjecutarEscalar("usp_ActualizaFactura")
            End With
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Bt_GrabaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_GrabaFactura.Click
        Dim SP As New CapaDato
        Dim Fila As Integer
        Fila = Dtg_SeleccionDatos.CurrentCell.RowNumber
        If Txt_DesFacOCompra.Text = "" Then Txt_DesFacOCompra.Text = "0"
        With SP
            Try
                .Inicializar()
                .AgregarParametro("@NumOt", CInt(Dtg_SeleccionDatos.Item(Fila, 0)), SqlDbType.Int)
                .AgregarParametro("@RSocial", Txt_DesFacSeñores.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Empresa", Txt_DesFacEmpresa.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Direccion", Txt_DesFacDireccion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Ciudad", Txt_DesFacCiudad.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Giro", Txt_DesFacGiro.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Comuna", Txt_DesFacComuna.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono1", Txt_DesFacF1.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono2", Txt_DesFacF2.Text, SqlDbType.NVarChar)
                .AgregarParametro("@CondPago", Cbx_CondPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Solicita", Txt_DesFacSolicita.Text, SqlDbType.NVarChar)
                .AgregarParametro("@EncPago", Txt_DesFacEncPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@F1Pago", Txt_DesFacF1Pago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@F2Pago", Txt_DesFacF2Pago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Observacion", Txt_DesFacObservacion.Text, SqlDbType.NVarChar)
                .AgregarParametro("@OrdenCompra", Txt_DesFacOCompra.Text, SqlDbType.NVarChar)
                .EjecutarEscalar("usp_ActualizaDatosFacturaOrden")
                MsgBox("Grabación Finalizada")
            Catch ex As Exception
                MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
            End Try
        End With
    End Sub

    Private Sub Carga_Enc_Carta()
        Dim Fila As DataRow
        Fila = Cjto_Tablas1.Tables("CARTA_ENC_DESPACHO").NewRow
        Fila.Item("R_SOCIAL") = Txt_RSocial.Text
        Fila.Item("DIRECCION") = Txt_DesFacDirec.Text
        Fila.Item("CASILLA") = Txt_DesFacCasilla.Text
        Fila.Item("COMUNA") = Txt_DespFacComuna.Text
        Fila.Item("CIUDAD") = Txt_DespFacCiudad.Text
        Fila.Item("ATENCION") = Txt_DesFacAtencion.Text
        Cjto_Tablas1.Tables("CARTA_ENC_DESPACHO").Rows.Add(Fila)
    End Sub

    Private Sub Carga_Cuerpo_Carta()
        Dim fila As DataRow
        Dim Fila_Dtg As Integer
        Dim NlabHasta As Integer
        Fila_Dtg = Dtg_SelFactura.CurrentCell.RowNumber
        NlabHasta = CInt(Dtg_SelFactura.Item(Fila_Dtg, 11)) + CInt(Dtg_SelFactura.Item(Fila_Dtg, 10))
        fila = Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").NewRow
        fila.Item("PRODUCTOR") = Dtg_SelFactura.Item(Fila_Dtg, 2)
        fila.Item("NUM_LAB_DESDE") = Dtg_SelFactura.Item(Fila_Dtg, 11)
        fila.Item("NUM_LAB_HASTA") = NlabHasta
        fila.Item("CANTIDAD") = Dtg_SelFactura.Item(Fila_Dtg, 10)
        fila.Item("NUM_FACTURA") = Txtfactura.Text
        fila.Item("TOTAL") = TxtTotal.Text
        Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows.Add(fila)
    End Sub

    Private Sub Carga_Datos_Nomina()
        Dim Fila As DataRow

        If Chk_Nomina.Checked = True Then
            ' Cjto_Tablas1.Tables("NOMINA_DESPACHO").Clear()
            Fila = Cjto_Tablas1.Tables("NOMINA_DESPACHO").NewRow
            Fila.Item("EMPRESA") = Txt_Empresa.Text
            Fila.Item("DIRECCION") = TxtDireccion.Text
            Fila.Item("CIUDAD") = Txt_Ciudad.Text
            Fila.Item("ATENCION") = Txt_DesFacAtencion.Text
            Cjto_Tablas1.Tables("NOMINA_DESPACHO").Rows.Add(Fila)
        End If

    End Sub

    Private Sub Rdb_Resultados_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Resultados.Click
        Rdb_ImpFacRes.Enabled = False
        Rdb_ImpFact.Enabled = False
        Rdb_ImpFactyCart.Enabled = False
        Rdb_ImpRes.Enabled = True
        Rdb_ImpResyCart.Enabled = True
        Rdb_ImpFacResCart.Enabled = False
        Rdb_EnvEmail.Enabled = True
    End Sub

    Private Sub Rdb_Factura_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Factura.Click

        If EstadoGlo <> "" Then
            Rdb_ImpFacRes.Enabled = False
            Rdb_ImpFact.Enabled = False
            Rdb_ImpFactyCart.Enabled = False
            Rdb_ImpRes.Enabled = False
            Rdb_ImpResyCart.Enabled = False
            Rdb_ImpFacResCart.Enabled = False
            Rdb_EnvEmail.Enabled = False
            MsgBox("Factura generada")
        Else
            Rdb_ImpFacRes.Enabled = False
            Rdb_ImpFact.Enabled = True
            Rdb_ImpFactyCart.Enabled = True
            Rdb_ImpRes.Enabled = False
            Rdb_ImpResyCart.Enabled = False
            Rdb_ImpFacResCart.Enabled = False
            Rdb_EnvEmail.Enabled = False
        End If

    End Sub

    Private Sub Rdb_ResyFact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ResyFact.Click
        If EstadoGlo <> "" Then
            Rdb_ImpFacRes.Enabled = False
            Rdb_ImpFact.Enabled = False
            Rdb_ImpFactyCart.Enabled = False
            Rdb_ImpRes.Enabled = False
            Rdb_ImpResyCart.Enabled = False
            Rdb_ImpFacResCart.Enabled = False
            Rdb_EnvEmail.Enabled = False
            MsgBox("Factura generada")
        Else
            Rdb_ImpFacRes.Enabled = True
            Rdb_ImpFact.Enabled = False
            Rdb_ImpFactyCart.Enabled = False
            Rdb_ImpRes.Enabled = False
            Rdb_ImpResyCart.Enabled = False
            Rdb_ImpFacResCart.Enabled = True
            Rdb_EnvEmail.Enabled = False
        End If

    End Sub

    Private Sub Seleccion()
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet

        If Rdb_ImpRes.Checked = True Then
            Call Imprime_Excel()
            Call Envia_Outlook()
            Call ActEstAna()
        End If

        If Rdb_ImpResyCart.Checked = True Then
            Call Imprime_Excel()
            Call Imprime_Carta()
            Call Envia_Outlook()
            Call ActEstAna()
        End If

        If Rdb_EnvEmail.Checked = True Then
            Call Envia_Outlook()
            Call ActEstAna()
        End If

        If Rdb_ImpFact.Checked = True Then
            If Me.chk_FacElectronica.Checked = True Then
                Call Imprime_Factura2(objHojaExcel)
            ElseIf Me.chk_FacElectronica.Checked = False Then
                Call Imprime_Factura(objHojaExcel)
            End If

            Call Actualizafactura()
            Call Graba_Detalle_Factura()
            Call InsertaNumFactura()
            Call ActEstFactura()
            Call ActEstOT()

            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

            If ChkCancelado.Checked = True Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumFac", Txtfactura.Text, SqlDbType.Int)
                    .AgregarParametro("@fecha", Me.TxtFechaCancelacion.Text, SqlDbType.DateTime)
                    .EjecutarEscalar("ys_GrabaFechaCancelacionFAC")
                End With
            End If

        End If

        If Rdb_ImpFactyCart.Checked = True Then
            Call Imprime_Factura(objHojaExcel)
            Call Actualizafactura()
            Call Graba_Detalle_Factura()
            Call InsertaNumFactura()
            Call ActEstFactura()
            Call Imprime_Carta()
        End If

        If Rdb_ImpFacResCart.Checked = True Then
            Call Imprime_Excel()
            Call Imprime_Factura(objHojaExcel)
            Call Envia_Outlook()
            Call Actualizafactura()
            Call Graba_Detalle_Factura()
            Call InsertaNumFactura()
            Call ActEstAna()
            Call ActEstFactura()
            Call Imprime_Carta()
        End If

        If Rdb_ImpFacRes.Checked = True Then
            Call Imprime_Excel()
            Call Imprime_Factura(objHojaExcel)
            Call Envia_Outlook()
            Call Actualizafactura()
            Call Graba_Detalle_Factura()
            Call InsertaNumFactura()
            Call ActEstAna()
            Call ActEstFactura()
        End If

        If Rdb_Nomina.Checked = True Then
            Call Imprime_Nomina()
        End If

        '++++++++++++++++++++++++++ Otro metodo de Impreción de Factura ++++++++++++++++++++'

        'Imprime_Fact(m_Excel, objLibroExcel, objHojaExcel, TxtNombreRetira.Text, TxtRutRetira.Text, TxtFechaRetiro.Text, TxtRecintoRetira.Text, txtFechaCancelacion.Text, TxtAbono.Text, TxtSaldo.Text, TxtMuestreoCant.Text, TxtMuestreoPrecioUn.Text, TxtDesctPesos.Text, TxtSubTotal.Text, TxtMuestreo.Text, TxtNeto.Text, TxtIva.Text, TxtTotal.Text, TxtFactura.Text, Txt_RSocial.Text, DTPFechaIng.Text, TxtDireccion.Text, CBCondicionPago.Text, Txt_Comuna.Text, Txt_Ciudad.Text, TxtOrdenCompra.Text, TxtRutFacturacion.Text, TxtObsPago.Text, TxtGiro.Text, TxtFono1.Text, Txt_Empresa.Text, TxtDescto.Text, TxtSolicitadoPor.Text)

        '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++'

    End Sub
    Sub ActEstOT()
        Dim NumOT, Fila As Integer
        Dim sp As New CapaDato
        For i = 1 To 10
            If Arreglo_OT(i) <> 0 Then
                With sp
                    .Inicializar()
                    .AgregarParametro("@Num_OT", Arreglo_OT(i), SqlDbType.Int)
                    .EjecutarEscalar("ys_ActEstOT")
                End With
            End If
        Next

    End Sub
    Private Sub Traspaso_Historico()
        Dim Fila As Integer
        Dim SP As New CapaDato
        For i = 1 To 10
            If Arreglo_OT(i) <> 0 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", Arreglo_OT(i), SqlDbType.Int)
                    .EjecutarEscalar("usp_TraspasoActualaHistorico")
                End With

            End If
        Next
    End Sub

    Private Sub Bt_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Aceptar.Click
        Try
            Dim FF As Integer
            If Txt_Comuna.Text = "" Then
                MsgBox("El campo comuna es obligatorio", MsgBoxStyle.Information)
                GoTo SaltoNoImprime
            End If
            If ValidaRut(TxtRutFacturacion.Text) = False Then
                MsgBox("Rut facturacion mal ingresado", MsgBoxStyle.Information)
                GoTo SaltoNoImprime
            End If
            If Dtg_DespachoResumen.IsSelected(FF) = False Then
                Call Seleccion()
            Else
                Call Carga_Cuerpo_Carta()
                Call Carga_Enc_Carta()
                Call Seleccion()
            End If

            ' Call ActEstOt()
            If Chk_Nomina.Checked = False Then
                Call ActualizaGrillas()
            Else
                Call Carga_Datos_Nomina()
                Call ActualizaGrillas2()
            End If

            Call LimpiaDespachar()


            If TipoFacturacion = "DesdeOrden" Then
                Me.Close()
            Else
                'TabControl1.SelectedTab = TabControl1.TabPages(0)
            End If

            'Call Traspaso_Historico()
            Abono = 0
            Total = 0
            SubTotal = 0
            Muestreo = 0
            CantMuestreo = 0
            Neto = 0
            Iva = 0
            i = 1
            ReDim Arreglo_OT(10)
SaltoNoImprime:
        Catch ex As Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub ActEstAna()
        Dim NumOT, Fila As Integer
        Dim sp As New CapaDato
        For i = 1 To 10
            If Arreglo_OT(i) <> 0 Then
                With sp
                    .Inicializar()
                    .AgregarParametro("@Num_OT", Arreglo_OT(i), SqlDbType.Int)
                    .EjecutarEscalar("usp_ActEstOT")
                End With
            End If
        Next

    End Sub

    Private Sub ActEstPagOt()
        Dim SP As New CapaDato
        With SP
            .Inicializar()
            .AgregarParametro("@Num_Factura", CInt(Txtfactura.Text), SqlDbType.Int)
            .EjecutarEscalar("usp_ActEstPagOt")
        End With
    End Sub


    Private Sub Imprime_Nomina()
        Try
            ' Call Carga_Cuerpo_Carta()
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim Fila_E As Integer = 2
            Dim Fila_Dat As DataRow
            Dim Fila_Ini As Integer
            Dim Cont As Integer = 1
            Dim Destino As String = "F:\Archivos LabSys\Formatos Labsys\Formato Cartas Despacho\Formato_Nomina.xls"
            Dim Destino2 As String = "F:\Archivos LabSys\Nomina\Nomina" & " " & Format(Today, "dd MM yyyy") & " " & "Labsys.xls"
            Try
                FileCopy(Destino, Destino2)
            Catch ex As Exception
                MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
            End Try


            m_Excel = CreateObject("EXCEL.APPLICATION")
            objLibroExcel = m_Excel.Workbooks.Open(Destino2)
            m_Excel.Visible = True
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()

            objHojaExcel.Range("A" & Fila_E.ToString & ":AH" & Fila_E.ToString).Merge()
            objHojaExcel.Range("A" & Fila_E.ToString).Value = "NOMINA CORREO"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 11
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 11
            objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Fila_E = Fila_E + 1

            objHojaExcel.Range("A" & Fila_E.ToString & ":AH" & Fila_E.ToString).Merge()
            objHojaExcel.Range("A" & Fila_E.ToString).Value = DTPFechaIng.Text
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 11
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 11
            objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Fila_E = Fila_E + 3

            objHojaExcel.Range("A" & Fila_E.ToString & ":B" & Fila_E.ToString).Merge()
            objHojaExcel.Range("A" & Fila_E.ToString).Value = "N°"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 7
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Bold = 7
            objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("C" & Fila_E.ToString & ":K" & Fila_E.ToString).Merge()
            objHojaExcel.Range("C" & Fila_E.ToString).Value = "EMPRESA"
            objHojaExcel.Range("C" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("C" & Fila_E.ToString).Font.Size = 7
            objHojaExcel.Range("C" & Fila_E.ToString).Font.Bold = 7
            objHojaExcel.Range("C" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("C" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("L" & Fila_E.ToString & ":S" & Fila_E.ToString).Merge()
            objHojaExcel.Range("L" & Fila_E.ToString).Value = "DIRECCION"
            objHojaExcel.Range("L" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("L" & Fila_E.ToString).Font.Size = 7
            objHojaExcel.Range("L" & Fila_E.ToString).Font.Bold = 7
            objHojaExcel.Range("L" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("L" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("T" & Fila_E.ToString & ":Y" & Fila_E.ToString).Merge()
            objHojaExcel.Range("T" & Fila_E.ToString).Value = "CIUDAD"
            objHojaExcel.Range("T" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("T" & Fila_E.ToString).Font.Size = 7
            objHojaExcel.Range("T" & Fila_E.ToString).Font.Bold = 7
            objHojaExcel.Range("T" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("T" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("Z" & Fila_E.ToString & ":AH" & Fila_E.ToString).Merge()
            objHojaExcel.Range("Z" & Fila_E.ToString).Value = "ATENCION"
            objHojaExcel.Range("Z" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("Z" & Fila_E.ToString).Font.Size = 7
            objHojaExcel.Range("Z" & Fila_E.ToString).Font.Bold = 7
            objHojaExcel.Range("Z" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("Z" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            'BORDES_DER(objHojaExcel, "B", Fila_E, Fila_E)
            'BORDES_DER(objHojaExcel, "K", Fila_E, Fila_E)
            'BORDES_DER(objHojaExcel, "S", Fila_E, Fila_E)
            'BORDES_DER(objHojaExcel, "Y", Fila_E, Fila_E)

            objHojaExcel.Range("A" & Fila_E.ToString & ":AH" & Fila_E.ToString).BorderAround()
            Fila_E = Fila_E + 1
            Fila_Ini = Fila_E
            For Each Fila_Dat In Cjto_Tablas1.Tables("NOMINA_DESPACHO").Rows

                objHojaExcel.Range("A" & Fila_E.ToString & ":B" & Fila_E.ToString).Merge()
                objHojaExcel.Range("A" & Fila_E.ToString).Value = Cont
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 7
                objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("C" & Fila_E.ToString & ":K" & Fila_E.ToString).Merge()
                objHojaExcel.Range("C" & Fila_E.ToString).Value = Fila_Dat("EMPRESA")
                objHojaExcel.Range("C" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("C" & Fila_E.ToString).Font.Size = 7
                objHojaExcel.Range("C" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("C" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("L" & Fila_E.ToString & ":S" & Fila_E.ToString).Merge()
                objHojaExcel.Range("L" & Fila_E.ToString).Value = Fila_Dat("DIRECCION")
                objHojaExcel.Range("L" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("L" & Fila_E.ToString).Font.Size = 7
                objHojaExcel.Range("L" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("L" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("T" & Fila_E.ToString & ":Y" & Fila_E.ToString).Merge()
                objHojaExcel.Range("T" & Fila_E.ToString).Value = Fila_Dat("CIUDAD")
                objHojaExcel.Range("T" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("T" & Fila_E.ToString).Font.Size = 7
                objHojaExcel.Range("T" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("T" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                objHojaExcel.Range("Z" & Fila_E.ToString & ":AH" & Fila_E.ToString).Merge()
                objHojaExcel.Range("Z" & Fila_E.ToString).Value = Fila_Dat("ATENCION")
                objHojaExcel.Range("Z" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("Z" & Fila_E.ToString).Font.Size = 7
                objHojaExcel.Range("Z" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("Z" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                Cont = Cont + 1
                Fila_E = Fila_E + 1
            Next
            'BORDES_DER(objHojaExcel, "B", Fila_Ini, Fila_E - 1)
            'BORDES_DER(objHojaExcel, "K", Fila_Ini, Fila_E - 1)
            'BORDES_DER(objHojaExcel, "S", Fila_Ini, Fila_E - 1)
            'BORDES_DER(objHojaExcel, "Y", Fila_Ini, Fila_E - 1)

            objHojaExcel.Range("A" & Fila_Ini.ToString & ":AH" & Fila_E - 1.ToString).BorderAround()
        Catch ex As Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Carga_Notas()
        Dim SP As New CapaDato
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_CargaNotas", Cjto_Tablas1, "NOTA_CARTA_DESPACHO")
        End With
    End Sub

    Private Sub Imprime_Carta()
        Try
            Dim m_Excel As Excel.Application
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim Fila_E As Integer = 6
            Dim Fila_D As Integer = 21
            Dim fila_ini As Integer
            Dim Fila_Dg As Integer
            Dim Fila_Dat As DataRow
            Dim Fila_Dato As DataRow
            Dim Destino2 As String
            Dim Fcorta As String
            Dim Largo As Integer
            Dim Destino As String = "F:\Archivos LabSys\Formatos Labsys\Formato Cartas Despacho\Formato_Carta_Despacho.xls"
            Dim Msj1, Msj2, Msj3, Msj4, Msj5, Msj6, Msj7 As String
            Fila_Dg = Dtg_SelFactura.CurrentCell.RowNumber
            Estado = Dtg_SelFactura.Item(Fila_Dg, 13)
            Fcorta = Format(Today, "dd MMMM yyyy")
            Largo = Len(Fcorta)
            Fcorta = "Santiago , " & Mid(Fcorta, 1, 2) & " de " + Mid(Fcorta, 4, (Largo - 8)) & " de" & Mid(Fcorta, (Largo - 4))

            If Estado = "Can" Then Destino2 = "F:\Archivos LabSys\Cartas\Carta cancelada" & " " & Format(Today, "dd MM yyyy") & " " & "Labsys.xls"
            If Estado = "Pte" Then Destino2 = "F:\Archivos LabSys\Cartas\Carta pendiente" & " " & Format(Today, "dd MM yyyy") & " " & "Labsys.xls"
            If Estado = "Abo" Then Destino2 = "F:\Archivos LabSys\Cartas\Carta abonada" & " " & Format(Today, "dd MM yyyy") & " " & "Labsys.xls"
            If ChkCancelado.Checked = True Then Estado = "Can"

            Try
                FileCopy(Destino, Destino2)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            m_Excel = CreateObject("EXCEL.APPLICATION")
            objLibroExcel = m_Excel.Workbooks.Open(Destino2)
            m_Excel.Visible = True
            objHojaExcel = objLibroExcel.Worksheets(1)
            objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
            objHojaExcel.Activate()


            objHojaExcel.Range("V" & Fila_E.ToString & ":AH" & Fila_E.ToString).Merge()
            objHojaExcel.Range("V" & Fila_E.ToString).Value = Fcorta
            objHojaExcel.Range("V" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("V" & Fila_E.ToString).Font.Size = 10
            objHojaExcel.Range("V" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("V" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Fila_E = Fila_E + 3

            objHojaExcel.Range("A" & Fila_E.ToString & ":C" & Fila_E.ToString).Merge()
            objHojaExcel.Range("A" & Fila_E.ToString).Value = "Sr.(es)"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
            objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Fila_E = Fila_E + 1

            For Each Fila_Dat In Cjto_Tablas1.Tables("CARTA_ENC_DESPACHO").Rows
                objHojaExcel.Range("A" & Fila_E.ToString & ":N" & Fila_E.ToString).Merge()
                objHojaExcel.Range("A" & Fila_E.ToString).Value = Fila_Dat("R_SOCIAL")
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                Fila_E = Fila_E + 1

                If Txt_DesFacCasilla.Text <> "" Then
                    objHojaExcel.Range("A" & Fila_E.ToString & ":N" & Fila_E.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_E.ToString).Value = "Casilla" & " " & Fila_Dat("CASILLA")
                    objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                Else
                    objHojaExcel.Range("A" & Fila_E.ToString & ":Z" & Fila_E.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_E.ToString).Value = "Dirección" & " " & Txt_DesFacDireccion.Text
                    objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                End If

                Fila_E = Fila_E + 1

                objHojaExcel.Range("A" & Fila_E.ToString & ":N" & Fila_E.ToString).Merge()
                objHojaExcel.Range("A" & Fila_E.ToString).Value = Fila_Dat("COMUNA")
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Underline = True
                objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                Fila_E = Fila_E + 2

                objHojaExcel.Range("A" & Fila_E.ToString & ":N" & Fila_E.ToString).Merge()
                objHojaExcel.Range("A" & Fila_E.ToString).Value = "At.:" & Fila_Dat("ATENCION")
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Arial"
                objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Next

            objHojaExcel.Range("A" & Fila_D.ToString & ":N" & Fila_D.ToString).Merge()
            objHojaExcel.Range("A" & Fila_D.ToString).Value = "De nuestra consideración:"
            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            Fila_D = Fila_D + 2

            If Rdb_ImpResyCart.Checked = True Then

                For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                    If Fila_Dato("NOD_TIPO") = "Res Solo" And Fila_Dato("NOD_NUMERO") = 1 Then
                        objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    End If
                Next

                If Estado = "Can" Then
                    Fila_D = Fila_D + 3
                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)


                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        Fila_D = Fila_D + 1
                    Next
                    Fila_D = Fila_D + 2

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Solo" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Mid(Fila_Dato("NOD_DESCRIPCION"), 1, 104)
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        End If
                    Next

                    Fila_D = Fila_D + 3

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Despedida" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Mid(Fila_Dato("NOD_DESCRIPCION"), 1, 104)
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        End If
                    Next
                End If

                If Estado = "Pte" Then

                    Fila_D = Fila_D + 3
                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AA" & Fila_D.ToString).Value = Txtfactura.Text
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                        Fila_D = Fila_D + 3
                    Next

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 3 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 4 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 1.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                End If

            End If

            If Rdb_ImpFactyCart.Checked = True Then
                If Estado = "Can" Then
                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Can" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 4

                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AA" & Fila_D.ToString).Value = Fila_Dato("NUM_FACTURA")
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                        Fila_D = Fila_D + 3
                    Next

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Can" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 4

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Despedida" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 1.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next
                End If

                If Estado = "Pte" Then

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Can" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 4

                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AA" & Fila_D.ToString).Value = Fila_Dato("NUM_FACTURA")
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                        Fila_D = Fila_D + 3
                    Next

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 3 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 4 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 1.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                End If

                If Estado = "Abo" Then

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Can" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 4

                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AA" & Fila_D.ToString).Value = Fila_Dato("NUM_FACTURA")
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                        ' Fila_D = Fila_D + 3
                    Next
                    Fila_D = Fila_D + 3

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 2 Then Msj1 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 3 Then Msj2 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 4 Then Msj3 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 5 Then Msj4 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 6 Then Msj5 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 7 Then Msj6 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 8 Then Msj7 = Fila_Dato("NOD_DESCRIPCION")

                    Next
                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 4.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj1 & " " & Txtfactura.Text & " " & Msj2 & " " & TxtAbono.Text & " " & Msj3 & " " & TxtSaldo.Text & " " & Msj4
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    Fila_D = Fila_D + 6

                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj5
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    Fila_D = Fila_D + 5

                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj6
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop






                End If
            End If


            If Rdb_ImpFacResCart.Checked = True Then
                For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                    If Fila_Dato("NOD_TIPO") = "Res Fac Can" And Fila_Dato("NOD_NUMERO") = 1 Then
                        objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                    End If
                Next


                Fila_D = Fila_D + 4
                fila_ini = Fila_D
                objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                Fila_D = Fila_D + 1
                For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = Fila_Dato("NUM_FACTURA")
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                    Fila_D = Fila_D + 3
                Next



                If Estado = "Pte" Then
                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 3 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 5

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Pte" And Fila_Dato("NOD_NUMERO") = 4 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 1.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Mid(Fila_Dato("NOD_DESCRIPCION"), 1, 104)
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        End If
                    Next

                End If

                If Estado = "Abo" Then

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Can" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 2.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                        End If
                    Next

                    Fila_D = Fila_D + 4

                    fila_ini = Fila_D
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = "PRODUCTOR"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Bold = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("P" & Fila_D.ToString).Value = "N°LABORATORIO"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("X" & Fila_D.ToString).Value = "CANT."
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("x" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila_D.ToString).Value = "N°FACTURA"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                    objHojaExcel.Range("AE" & Fila_D.ToString).Value = "$ TOTAL"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).Font.Bold = 8
                    objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()
                    objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Interior.Color = RGB(175, 238, 238)

                    Fila_D = Fila_D + 1
                    For Each Fila_Dato In Cjto_Tablas1.Tables("CARTA_CUERPO_DESPACHO").Rows
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("PRODUCTOR")
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                        objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("A" & Fila_D.ToString & ":O" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("P" & Fila_D.ToString).Value = Fila_Dato("NUM_LAB_DESDE") & "-" & Fila_Dato("NUM_LAB_HASTA")
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("P" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("P" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("P" & Fila_D.ToString & ":W" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("X" & Fila_D.ToString).Value = Fila_Dato("CANTIDAD")
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("X" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("X" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("X" & Fila_D.ToString & ":Z" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AA" & Fila_D.ToString).Value = Fila_Dato("NUM_FACTURA")
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AA" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AA" & Fila_D.ToString & ":AD" & Fila_D.ToString).BorderAround()

                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                        objHojaExcel.Range("AE" & Fila_D.ToString).Value = Fila_Dato("TOTAL")
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Name = "Arial"
                        objHojaExcel.Range("AE" & Fila_D.ToString).Font.Size = 8
                        objHojaExcel.Range("AE" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        objHojaExcel.Range("AE" & Fila_D.ToString & ":AH" & Fila_D.ToString).BorderAround()

                        ' Fila_D = Fila_D + 3
                    Next
                    Fila_D = Fila_D + 3

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 2 Then Msj1 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 3 Then Msj2 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 4 Then Msj3 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 5 Then Msj4 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 6 Then Msj5 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 7 Then Msj6 = Fila_Dato("NOD_DESCRIPCION")
                        If Fila_Dato("NOD_TIPO") = "Fac Abo" And Fila_Dato("NOD_NUMERO") = 8 Then Msj7 = Fila_Dato("NOD_DESCRIPCION")

                    Next
                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 4.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj1 & " " & Txtfactura.Text & " " & Msj2 & " " & TxtAbono.Text & " " & Msj3 & " " & TxtSaldo.Text & " " & Msj4
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    Fila_D = Fila_D + 6

                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj5
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                    Fila_D = Fila_D + 5

                    objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                    objHojaExcel.Range("A" & Fila_D.ToString).Value = Msj6
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                    objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                    objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                    objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop


                End If

                If Estado = "Can" Then

                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Res Fac Can" And Fila_Dato("NOD_NUMERO") = 2 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D + 3.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Fila_Dato("NOD_DESCRIPCION")
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

                        End If
                    Next

                    Fila_D = Fila_D + 4
                    For Each Fila_Dato In Cjto_Tablas1.Tables("NOTA_CARTA_DESPACHO").Rows
                        If Fila_Dato("NOD_TIPO") = "Despedida" And Fila_Dato("NOD_NUMERO") = 1 Then
                            objHojaExcel.Range("A" & Fila_D.ToString & ":AH" & Fila_D.ToString).Merge()
                            objHojaExcel.Range("A" & Fila_D.ToString).Value = Mid(Fila_Dato("NOD_DESCRIPCION"), 1, 104)
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Name = "Arial"
                            objHojaExcel.Range("A" & Fila_D.ToString).Font.Size = 10
                            objHojaExcel.Range("A" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                            objHojaExcel.Range("A" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox("error" & ex.Message.ToString, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub Chk_Nomina_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Nomina.Click
        Rdb_Nomina.Enabled = True
        If Chk_Nomina.Checked = False Then
            Rdb_Nomina.Enabled = False
        End If
    End Sub

    Private Sub ActEstFactura()
        Try
            Dim SP As New CapaDato
            With SP
                .Inicializar()
                .AgregarParametro("@Num_Factura", CInt(Txtfactura.Text), SqlDbType.Int)
                .AgregarParametro("@Fecha_Factura", DTPFechaIng.Text, SqlDbType.DateTime)
                If ChkCancelado.Checked = True Then
                    .AgregarParametro("@Est_Pago", "Can", SqlDbType.NVarChar)
                Else
                    .AgregarParametro("@Est_Pago", "Pte", SqlDbType.NVarChar)
                End If
                .EjecutarEscalar("usp_ActEstFactura")
            End With


            If ChkCancelado.Checked = True Then
                ' Call Graba_Historia_Estado(0, "NULL", "NULL", "NULL", CInt(Txtfactura.Text), "Can", "Ingreso Factura")
            Else
                ' Call Graba_Historia_Estado(0, "NULL", "NULL", "NULL", CInt(Txtfactura.Text), "Pte", "Ingreso Factura")
            End If
        Catch ex As Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        End Try


    End Sub

    Private Sub Imprime_Factura2(ByVal m_Excel As Excel.Application)
     


        'Try
        Dim objLibroExcel As Excel.Workbook
        Dim HOJA_EXCEL As Excel.Worksheet
        Dim oexcel As Excel.Application


        Dim Total_Muestreo, Fila_Precios, i, Largo, fila, fila_merge, fila_borde, fila_pie, fila_logo, fila_nota, Muestra_Aux, Total_SF As Integer
        Dim Palabra_Valor, DIA, MES, ANO, Descripcion_Recibo, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula As String
        Dim BUSCA, BusMue As Object
        Dim Fila_Orden, FILA_FAC_DET, FILA_MUESTRA As DataRow
        Dim fuente, destino As String
        Dim sAño As String = Year(Today)
        Dim CambioColumnas As Boolean = False
        BUSCA = Orden_Trabajo

        Dim sRutaDestino As String

        Dim MyDate As Date

        sRutaDestino = "F:\Mis Documentos\LabSys-Pruebas\Facturas " & sAño & ""
        If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
            MkDir(sRutaDestino)
        End If


        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Factura2.xls"
        destino = "F:\Mis Documentos\LabSys-Pruebas\Facturas " & sAño & "\Factura " & Txtfactura.Text & ".xls"
        'destino = "F:\Archivos LabSys\Factura\Facturas " & sAño & "\Factura " & Txtfactura.Text & ".xls"

        m_Excel = CreateObject("EXCEL.APPLICATION")

        'Try
        '    FileCopy(fuente, destino)
        'Catch ex As Exception
        '    MsgBox("Documento Abierto")
        '    'GoTo noimprime
        'End Try
        objLibroExcel = m_Excel.Workbooks.Open(fuente)
        m_Excel.Visible = False
        HOJA_EXCEL = objLibroExcel.Worksheets(1)
        HOJA_EXCEL.Activate()

        fila = 4
        HOJA_EXCEL.Range("A1").Select()
        'PRODUCTOR
        fila = fila + 5
        'numero
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CI" & fila.ToString).Value = CInt(Txtfactura.Text)
        HOJA_EXCEL.Range("CI" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'FechaI = Format(CDate(Me.DTPFechaIng.Text), "dd MMMMMM yyyy")
        'DIA = Mid(FechaI, 1, 2)
        'MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
        'ANO = Trim(Mid(FechaI, Len(FechaI) - 4))
        fila = fila + 6
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 9
        'fila = fila + 1

        'fecha dia
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Fecha"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = DTPFechaIng.Text '"Santiago, " & DIA & " de " & MES & " de " & ANO
        ' HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "dd MMMMMM aaaa"
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'rsocial
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Señores"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_RSocial.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'direccion
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Dirección"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtDireccion.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'comuna/ciudad
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Comuna/Ciudad"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_Comuna.Text & " - " & Txt_Ciudad.Text
        'HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        'HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        'HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        'desde aqui 
        HOJA_EXCEL.Range("U" & fila.ToString & ":AP" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_Comuna.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":AP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("AR" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AR" & fila.ToString).Value = Txt_Ciudad.Text
        HOJA_EXCEL.Range("AR" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("AR" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("AR" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'hasta aqui es profactura

        'condicion de pago
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Cond.de pago"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = cb_condpago.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1

        'rut
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Rut"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtRutFacturacion.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'orden de compra
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Orden de compra"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        If TxtOrdenCompra.Text = "0" Then
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = ""
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        Else
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = TxtOrdenCompra.Text
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End If
        

        fila = fila + 1

        'giro
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Giro"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtGiro.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Solicitado por
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Solicitado por"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = TxtSolicitadoPor.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1

        'fono
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Fono"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtFono1.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'observaciones de pago
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Observaciones"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = TxtObsPago.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 5
        Muestra_Aux = 0

        CambioColumnas = False
        For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
            If IsDBNull(FILA_FAC_DET("DET_PUNITARIO")) = False Then
                If Len(CStr(FILA_FAC_DET("DET_PUNITARIO"))) > 5 Then CambioColumnas = True
            End If
        Next

        For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
            fila = fila + 1

            'CODIGO(electronica)

            HOJA_EXCEL.Range("D" & fila.ToString & ":I" & fila.ToString).Merge()
            HOJA_EXCEL.Range("D" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
            HOJA_EXCEL.Range("D" & fila.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("E" & fila.ToString & ":J" & fila.ToString).NumberFormat = "####"
            HOJA_EXCEL.Range("D" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            'CODIGO(Normal)
            'HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).Merge()
            'HOJA_EXCEL.Range("E" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
            'HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 8.5
            'HOJA_EXCEL.Range("E" & fila.ToString & ":J" & fila.ToString).NumberFormat = "####"
            'HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            'DESCRIPCION 
            Fila_Precios = fila
            query = FILA_FAC_DET("DET_DETALLE")
            Acumula = ""
            For i = 1 To query.Length
                caracter = Mid(query, i, 1)
                If Asc(caracter) = 13 Then caracter = " "
                If Asc(caracter) = 10 Then
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                    HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8.5
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    fila = fila + 1
                    Acumula = ""
                Else
                    Acumula = Acumula + caracter
                End If
            Next
            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            If CambioColumnas = False Then
                'CANTIDAD
                HOJA_EXCEL.Range("CI" & fila.ToString & ":CO" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CI" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                HOJA_EXCEL.Range("CI" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("CI" & fila.ToString & ":CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'Precio Unitario
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).NumberFormat = "######"
                HOJA_EXCEL.Range("CP" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'total
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).Merge()
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "#######"
                HOJA_EXCEL.Range("DA" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                HOJA_EXCEL.Range("DA" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            ElseIf CambioColumnas = True Then
                'CANTIDAD
                HOJA_EXCEL.Range("CI" & fila.ToString & ":CO" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CI" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                HOJA_EXCEL.Range("CI" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("CI" & fila.ToString & ":CO" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'Precio Unitario
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).NumberFormat = "######"
                HOJA_EXCEL.Range("CP" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("CP" & fila.ToString & ":CZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'total
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).Merge()
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "#######"
                HOJA_EXCEL.Range("DA" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                HOJA_EXCEL.Range("DA" & fila.ToString).Font.Size = 9
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                ' ''CANTIDAD
                ''HOJA_EXCEL.Range("CJ" & fila.ToString & ":CN" & fila.ToString).Merge()
                ''HOJA_EXCEL.Range("CJ" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                ''HOJA_EXCEL.Range("CJ" & fila.ToString).Font.Size = 10
                ''HOJA_EXCEL.Range("CJ" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                ' ''Precio Unitario
                ''HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).Merge()
                ''HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).NumberFormat = "###.###"
                ''HOJA_EXCEL.Range("CO" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                ''HOJA_EXCEL.Range("CO" & fila.ToString).Font.Size = 10
                ''HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                ' ''total
                ''HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).Merge()
                ''HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "#.###.###"
                ''HOJA_EXCEL.Range("CZ" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                ''HOJA_EXCEL.Range("CZ" & fila.ToString).Font.Size = 10
                ''HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                ''HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End If
        Next

        ' +++++++++++++++++++++     Imprime Muestreo    +++++++++++++++++++++++++++++++++

        If TxtMuestreoCant.Text <> 0 Then
            HOJA_EXCEL.Range("L" & fila + 1.ToString & ":CG" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila + 1.ToString).Value = "Servicio de Muestreo"
            HOJA_EXCEL.Range("L" & fila + 1.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("L" & fila + 1.ToString & ":CG" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            If TxtMuestreoCant.Text = "" Then
                HOJA_EXCEL.Range("CI" & fila + 1.ToString & ":CO" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CI" & fila + 1.ToString).Value = ""
                HOJA_EXCEL.Range("CI" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CI" & fila + 1.ToString & ":CO" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            Else
                HOJA_EXCEL.Range("CI" & fila + 1.ToString & ":CO" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CI" & fila + 1.ToString).Value = TxtMuestreoCant.Text
                HOJA_EXCEL.Range("CI" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CI" & fila + 1.ToString & ":CO" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If

            If TxtMuestreoPrecioUn.Text = "" Then
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).NumberFormat = "######"
                HOJA_EXCEL.Range("CP" & fila + 1.ToString).Value = ""
                HOJA_EXCEL.Range("CP" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            Else
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).NumberFormat = "######"
                HOJA_EXCEL.Range("CP" & fila + 1.ToString).Value = TxtMuestreoPrecioUn.Text
                HOJA_EXCEL.Range("CP" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CP" & fila + 1.ToString & ":CZ" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If

            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DA" & fila + 1.ToString).Value = TxtMuestreo.Text
            HOJA_EXCEL.Range("DA" & fila + 1.ToString).Font.Size = 10
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        End If

        '++++++++++++++++++++++++++++++  Imprime Descuento ++++++++++++++++++++++++++++++++

        If TxtDescto.Text <> 0 Then
            HOJA_EXCEL.Range("L" & fila + 2.ToString & ":CG" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila + 2.ToString).Value = TxtDescto.Text & "%" & "Descuento"
            HOJA_EXCEL.Range("L" & fila + 2.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("L" & fila + 2.ToString & ":CG" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("DL" & fila + 2.ToString & ":DT" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("DL" & fila + 2.ToString & ":DT" & fila + 2.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DL" & fila + 2.ToString).Value = TxtDesctPesos.Text
            HOJA_EXCEL.Range("DL" & fila + 2.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("DL" & fila + 2.ToString & ":DT" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("DL" & fila + 2.ToString & ":DT" & fila + 2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        End If

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'CALL VALOR_A_CIFRAS()
        If Me.txt_son.Text = "" Then
            Total_SF = Format(CInt(TxtTotal.Text), "#######")
            Palabra_Valor = Letras(CStr(Total_SF))
            HOJA_EXCEL.Range("L53:CU53").Merge()
            HOJA_EXCEL.Range("L53").Value = "Son : " & UCase(Mid(Palabra_Valor, 1, 1)) & Mid(Palabra_Valor, 2) & "  pesos"
            HOJA_EXCEL.Range("L53").Font.Size = 10
            HOJA_EXCEL.Range("L53:CU53").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("L53:CU53").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        Else

            HOJA_EXCEL.Range("L53:CU53").Merge()
            HOJA_EXCEL.Range("L53").Value = Me.txt_son.Text
            HOJA_EXCEL.Range("L53").Font.Size = 10
            HOJA_EXCEL.Range("L53:CU53").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("L53:CU53").VerticalAlignment = Excel.XlVAlign.xlVAlignTop


        End If

        If TxtFechaCancelacion.Text <> "" Then
            FechaI = Format(CDate(Me.TxtFechaCancelacion.Text), "dd MMMMMM yyyy")
            DIA = Mid(FechaI, 1, 2)
            MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
            ANO = Trim(Mid(FechaI, Len(FechaI) - 4))

            If ChkCancelado.Checked = True Then
                HOJA_EXCEL.Range("F55:Q55").Merge()
                HOJA_EXCEL.Range("F55").Value = "CANCELADO :"
                HOJA_EXCEL.Range("F55").Font.Size = 8
                HOJA_EXCEL.Range("F55").Font.Bold = False
                HOJA_EXCEL.Range("F55: Q55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                HOJA_EXCEL.Range("R55:AA55").Merge()
                HOJA_EXCEL.Range("R55").Value = "Fecha,"
                HOJA_EXCEL.Range("R55").Font.Size = 8.5
                HOJA_EXCEL.Range("R55").Font.Bold = False
                HOJA_EXCEL.Range("R55:AA55").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                'fecha 
                HOJA_EXCEL.Range("AB55:AZ55").Merge()
                HOJA_EXCEL.Range("AB55").Value = DIA & " de " & MES & " de " & ANO
                HOJA_EXCEL.Range("AB55").Font.Size = 8.5
                HOJA_EXCEL.Range("AB55").Font.Bold = False
                HOJA_EXCEL.Range("AB55:AZ55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            End If
        End If

        If TxtAbono.Text <> "" And TxtAbono.Text <> "0" Then
            HOJA_EXCEL.Range("F55:Q55").Merge()
            HOJA_EXCEL.Range("F55").Value = "ABONO     :"
            HOJA_EXCEL.Range("F55").Font.Size = 8
            HOJA_EXCEL.Range("F55").Font.Bold = False
            HOJA_EXCEL.Range("F55:Q55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("R55:AD55").Merge()
            HOJA_EXCEL.Range("R55").Value = TxtAbono.Text
            HOJA_EXCEL.Range("R55:AD55").NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("R55").Font.Size = 8.5
            HOJA_EXCEL.Range("R55").Font.Bold = False
            HOJA_EXCEL.Range("R55:AD55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End If


        'nombre retira
        HOJA_EXCEL.Range("F57:L57").Merge()
        HOJA_EXCEL.Range("F57").Value = "Nombre"
        HOJA_EXCEL.Range("F57").Font.Size = 8.5
        HOJA_EXCEL.Range("F57:L57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("F57:L57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("M57").Value = ":"
        HOJA_EXCEL.Range("M57").Font.Size = 8.5
        HOJA_EXCEL.Range("M57:M57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("M57:M57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("N57:BD57").Merge()
        HOJA_EXCEL.Range("N57").Value = TxtNombreRetira.Text
        HOJA_EXCEL.Range("N57").Font.Size = 8.5
        HOJA_EXCEL.Range("N57:BD57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("N57:BD57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'rut retira
        HOJA_EXCEL.Range("BM57:BQ57").Merge()
        HOJA_EXCEL.Range("BM57").Value = "R.U.T"
        HOJA_EXCEL.Range("BM57").Font.Size = 8.5
        HOJA_EXCEL.Range("BM57:BQ57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BM57:BQ57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BR57").Value = ":"
        HOJA_EXCEL.Range("BR57").Font.Size = 8.5
        HOJA_EXCEL.Range("BR57:BR57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BR57:BR57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BS57:CC57").Merge()
        HOJA_EXCEL.Range("BS57").Value = TxtRutRetira.Text
        HOJA_EXCEL.Range("BS57").Font.Size = 8.5
        HOJA_EXCEL.Range("BS57:CC57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BS57:CC57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        HOJA_EXCEL.Range("BS57:CC57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("F58:K58").Merge()
        HOJA_EXCEL.Range("F58").Value = "Fecha"
        HOJA_EXCEL.Range("F58").Font.Size = 8.5
        HOJA_EXCEL.Range("F58:K58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("F58:K58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("M58").Value = ":"
        HOJA_EXCEL.Range("M58").Font.Size = 8.5
        HOJA_EXCEL.Range("M58:M58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("M58:M58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop


        If TxtFechaRetiro.Text <> "" Then
            'fecha 
            HOJA_EXCEL.Range("N58:AD58").Merge()
            HOJA_EXCEL.Range("N58").Value = TxtFechaRetiro.Text
            HOJA_EXCEL.Range("N58").Font.Size = 8.5
            HOJA_EXCEL.Range("N58").Font.Bold = False
            HOJA_EXCEL.Range("N58:AD58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("N58:AD58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        'Recinto
        HOJA_EXCEL.Range("AE58:AK58").Merge()
        HOJA_EXCEL.Range("AE58").Value = "Recinto"
        HOJA_EXCEL.Range("AE58").Font.Size = 8.5
        HOJA_EXCEL.Range("AE58:AK58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AE58:AK58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("AL58").Value = ":"
        HOJA_EXCEL.Range("AL58").Font.Size = 8.5
        HOJA_EXCEL.Range("AL58:AL58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AL58:AL58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("AM58:BL58").Merge()
        HOJA_EXCEL.Range("AM58").Value = TxtRecintoRetira.Text
        HOJA_EXCEL.Range("AM58").Font.Size = 8.5
        HOJA_EXCEL.Range("AM58:BL58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AM58:BL58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'Firma

        HOJA_EXCEL.Range("BM58:BQ58").Merge()
        HOJA_EXCEL.Range("BM58").Value = "Firma"
        HOJA_EXCEL.Range("BM58").Font.Size = 8.5
        HOJA_EXCEL.Range("BM58:BQ58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BM58:BQ58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BR58").Value = ":"
        HOJA_EXCEL.Range("BR58").Font.Size = 8.5
        HOJA_EXCEL.Range("BR58:BR58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BR58:BR58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'NETO
        'HOJA_EXCEL.Range("A56").RowHeight = 15

        HOJA_EXCEL.Range("CP57:CX57").Merge()
        HOJA_EXCEL.Range("CP57").Value = "NETO"
        HOJA_EXCEL.Range("CP57").Font.Size = 8
        HOJA_EXCEL.Range("CP57:CX57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP57:CX57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY57").Value = ":"
        HOJA_EXCEL.Range("CY57").Font.Size = 10
        HOJA_EXCEL.Range("CY57:CY57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY57:CY57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ57:DK57").Merge()
        HOJA_EXCEL.Range("CZ57:DK57").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CZ57").Value = TxtNeto.Text
        HOJA_EXCEL.Range("CZ57").Font.Size = 10
        HOJA_EXCEL.Range("CZ57:DK57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ57:DK57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'IVA (VALOR)

        HOJA_EXCEL.Range("CP58:CX58").Merge()
        HOJA_EXCEL.Range("CP58").Value = "% IVA"
        HOJA_EXCEL.Range("CP58").Font.Size = 8
        HOJA_EXCEL.Range("CP58:CX58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP58:CX58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY58").Value = ":"
        HOJA_EXCEL.Range("CY58").Font.Size = 10
        HOJA_EXCEL.Range("CY58:CY58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY58:CY58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ58:DK58").Merge()
        HOJA_EXCEL.Range("CZ58:DK58").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CZ58").Value = TxtIva.Text
        HOJA_EXCEL.Range("CZ58").Font.Size = 10
        HOJA_EXCEL.Range("CZ58:DK58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ58:DK58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'TOTAL
        'HOJA_EXCEL.Range("A45").RowHeight = 15

        HOJA_EXCEL.Range("CP59:CX59").Merge()
        HOJA_EXCEL.Range("CP59").Value = "TOTAL"
        HOJA_EXCEL.Range("CP59").Font.Size = 8
        HOJA_EXCEL.Range("CP59:CX59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP59:CX59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY59").Value = ":"
        HOJA_EXCEL.Range("CY59").Font.Size = 10
        HOJA_EXCEL.Range("CY59:CY59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY59:CY59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ59:DK59").Merge()
        HOJA_EXCEL.Range("CZ59:DK59").NumberFormat = "#.###.###"
        HOJA_EXCEL.Range("CZ59").Value = TxtTotal.Text
        HOJA_EXCEL.Range("CZ59").Font.Size = 10
        HOJA_EXCEL.Range("CZ59:DK59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ59:DK59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("A1").Select()
        'm_Excel.ActivePrinter = "\\AGRO2\"
        'm_Excel.Dialogs(Excel.XlBuiltInDialog.xlDialogPrint).Show()
        'm_Excel.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, Collate:=True)

        '#######################aqui
        ViaImpresoraMatriz = "PROFACTURA en RPT1:" '"Okidata ML 320 Turbo/D (IBM) en Ne00:" 			String
        'ViaImpresoraMatriz = "OKIDATA ML320/1 TURBO en Ne00:"
        'ViaImpresoraMatriz = "\\AGRO2\HP P2015 Sin Logo en Ne04:"

        m_Excel.ActivePrinter = ViaImpresoraMatriz
        MsgBox("Impresora:'" & (ViaImpresoraMatriz) & "'")

        'selecciona el tamaño de papel DTE
        With HOJA_EXCEL.PageSetup
            .PaperSize = papel '183 '183 'paola 'DTE '127 cony 119 eddy
        End With
        'Fin seleccion papel



        m_Excel.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:=ViaImpresoraMatriz, Collate:=True)
        '#######################aqui


        Try
            HOJA_EXCEL.SaveAs(destino)
            m_Excel.Quit()
            m_Excel = Nothing
        Catch ex As Exception
            objLibroExcel.Close(False, , )
            m_Excel.Quit()
            m_Excel = Nothing
        End Try
        'Catch ex As Exception
        '    MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        'End Try

    End Sub
    Private Sub Imprime_Factura(ByVal m_Excel As Excel.Application)
        'Try
        Dim objLibroExcel As Excel.Workbook
        Dim HOJA_EXCEL As Excel.Worksheet


        Dim Total_Muestreo, Fila_Precios, i, Largo, fila, fila_merge, fila_borde, fila_pie, fila_logo, fila_nota, Muestra_Aux, Total_SF As Integer
        Dim Palabra_Valor, DIA, MES, ANO, Descripcion_Recibo, caracter, query, vernom, FechaI, CodMueC, NumLabo, Acumula As String
        Dim BUSCA, BusMue As Object
        Dim Fila_Orden, FILA_FAC_DET, FILA_MUESTRA As DataRow
        Dim fuente, destino As String
        Dim sAño As String = Year(Today)
        Dim CambioColumnas As Boolean = False
        BUSCA = Orden_Trabajo


        Dim sRutaDestino As String

        Dim MyDate As Date

        sRutaDestino = "F:\Mis Documentos\LabSys-Pruebas\Facturas " & sAño & ""
        If Dir(sRutaDestino, FileAttribute.Directory) = "" Then
            MkDir(sRutaDestino)
        End If


        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato Factura2.xls"
        destino = "F:\Mis Documentos\LabSys-Pruebas\Facturas " & sAño & "\Factura " & Txtfactura.Text & ".xls"
        'destino = "F:\Archivos LabSys\Factura\Facturas " & sAño & "\Factura " & Txtfactura.Text & ".xls"

        m_Excel = CreateObject("EXCEL.APPLICATION")

        'Try
        '    FileCopy(fuente, destino)
        'Catch ex As Exception
        '    MsgBox("Documento Abierto")
        '    'GoTo noimprime
        'End Try

        objLibroExcel = m_Excel.Workbooks.Open(fuente)
        m_Excel.Visible = False
        HOJA_EXCEL = objLibroExcel.Worksheets(1)
        HOJA_EXCEL.Activate()

        fila = 4
        HOJA_EXCEL.Range("A1").Select()
        'PRODUCTOR
        fila = fila + 6
        'numero
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CI" & fila.ToString).Value = CInt(Txtfactura.Text)
        HOJA_EXCEL.Range("CI" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("CI" & fila.ToString & ":CS" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        FechaI = Format(CDate(Me.DTPFechaIng.Text), "dd MMMMMM yyyy")
        DIA = Mid(FechaI, 1, 2)
        MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
        ANO = Trim(Mid(FechaI, Len(FechaI) - 4))
        fila = fila + 6
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 9
        'fila = fila + 1

        'fecha dia
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Fecha"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "Santiago, " & DIA & " de " & MES & " de " & ANO
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "dd MMMMMM aaaa"
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'rsocial
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Señores"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_RSocial.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'direccion
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Dirección"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtDireccion.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).RowHeight = 10

        'comuna/ciudad
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Comuna/Ciudad"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_Comuna.Text & " - " & Txt_Ciudad.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft


        'desde aqui 
        'HOJA_EXCEL.Range("U" & fila.ToString & ":AP" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("U" & fila.ToString).Value = Txt_Comuna.Text
        'HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        'HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        'HOJA_EXCEL.Range("U" & fila.ToString & ":AP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'HOJA_EXCEL.Range("AR" & fila.ToString & ":BM" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("AR" & fila.ToString).Value = Txt_Ciudad.Text
        'HOJA_EXCEL.Range("AR" & fila.ToString).Font.Size = 8.5
        'HOJA_EXCEL.Range("AR" & fila.ToString).Font.Bold = False
        'HOJA_EXCEL.Range("AR" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'hasta aqui es profactura

        'condicion de pago
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Cond.de pago"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = cb_condpago.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1

        'rut
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Rut"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtRutFacturacion.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'orden de compra
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Orden de compra"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = "'" & TxtOrdenCompra.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1

        'giro
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Giro"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtGiro.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'Solicitado por
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Solicitado por"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = TxtSolicitadoPor.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 1

        'fono
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).Merge()
        HOJA_EXCEL.Range("F" & fila.ToString).Value = "Fono"
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("F" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("F" & fila.ToString & ":S" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("T" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("T" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("T" & fila.ToString & ":T" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).Merge()
        HOJA_EXCEL.Range("U" & fila.ToString).Value = TxtFono1.Text
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("U" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("U" & fila.ToString & ":BM" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        'observaciones de pago
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BQ" & fila.ToString).Value = "Observaciones"
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("BQ" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("BQ" & fila.ToString & ":CE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CF" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CG" & fila.ToString).Value = TxtObsPago.Text
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 8.5
        HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = False
        HOJA_EXCEL.Range("CG" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

        fila = fila + 5
        Muestra_Aux = 0

        CambioColumnas = False
        For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
            If IsDBNull(FILA_FAC_DET("DET_PUNITARIO")) = False Then
                If Len(CStr(FILA_FAC_DET("DET_PUNITARIO"))) > 5 Then CambioColumnas = True
            End If
        Next

        For Each FILA_FAC_DET In Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Rows
            fila = fila + 1

            'CODIGO(electronica)

            'HOJA_EXCEL.Range("D" & fila.ToString & ":I" & fila.ToString).Merge()
            'HOJA_EXCEL.Range("D" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
            'HOJA_EXCEL.Range("D" & fila.ToString).Font.Size = 8.5
            ''   HOJA_EXCEL.Range("E" & fila.ToString & ":J" & fila.ToString).NumberFormat = "####"
            'HOJA_EXCEL.Range("D" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            'CODIGO(Normal)
            HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).Merge()
            HOJA_EXCEL.Range("E" & fila.ToString).Value = FILA_FAC_DET("DET_CODIGO")
            HOJA_EXCEL.Range("E" & fila.ToString).Font.Size = 8.5
            '   HOJA_EXCEL.Range("E" & fila.ToString & ":J" & fila.ToString).NumberFormat = "####"
            HOJA_EXCEL.Range("E" & fila.ToString & ":I" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


            'DESCRIPCION 
            Fila_Precios = fila
            query = FILA_FAC_DET("DET_DETALLE")
            Acumula = ""
            For i = 1 To query.Length
                caracter = Mid(query, i, 1)
                If Asc(caracter) = 13 Then caracter = " "
                If Asc(caracter) = 10 Then
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
                    HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
                    HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 8.5
                    HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    fila = fila + 1
                    Acumula = ""
                Else
                    Acumula = Acumula + caracter
                End If
            Next
            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila.ToString).Value = Acumula
            HOJA_EXCEL.Range("L" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("L" & fila.ToString & ":CG" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            If CambioColumnas = False Then
                'CANTIDAD
                HOJA_EXCEL.Range("CN" & fila.ToString & ":CR" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CN" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                HOJA_EXCEL.Range("CN" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CN" & fila.ToString & ":CR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'Precio Unitario
                HOJA_EXCEL.Range("CS" & fila.ToString & ":CZ" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CS" & fila.ToString & ":CZ" & fila.ToString).NumberFormat = "###.###"
                HOJA_EXCEL.Range("CS" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CS" & fila.ToString & ":CZ" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'total
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).Merge()
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "#.###.###"
                HOJA_EXCEL.Range("DA" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                HOJA_EXCEL.Range("DA" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("DA" & fila.ToString & ":DK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            ElseIf CambioColumnas = True Then
                'CANTIDAD
                HOJA_EXCEL.Range("CJ" & fila.ToString & ":CN" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CJ" & fila.ToString).Value = FILA_FAC_DET("DET_CANTIDAD")
                HOJA_EXCEL.Range("CJ" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CJ" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'Precio Unitario
                HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).NumberFormat = "###.###"
                HOJA_EXCEL.Range("CO" & fila.ToString).Value = FILA_FAC_DET("DET_PUNITARIO")
                HOJA_EXCEL.Range("CO" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CO" & fila.ToString & ":CY" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

                'total
                HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).Merge()
                HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).NumberFormat = "#.###.###"
                HOJA_EXCEL.Range("CZ" & fila.ToString).Value = FILA_FAC_DET("DET_TOTAL")
                HOJA_EXCEL.Range("CZ" & fila.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("CZ" & fila.ToString & ":DK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End If
        Next

        ' +++++++++++++++++++++     Imprime Muestreo    +++++++++++++++++++++++++++++++++

        If TxtMuestreoCant.Text <> 0 Then
            HOJA_EXCEL.Range("L" & fila + 1.ToString & ":CG" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila + 1.ToString).Value = "Servicio de Muestreo"
            HOJA_EXCEL.Range("L" & fila + 1.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("L" & fila + 1.ToString & ":CG" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            If TxtMuestreoCant.Text = "" Then
                HOJA_EXCEL.Range("CN" & fila + 1.ToString & ":CR" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CN" & fila + 1.ToString).Value = ""
                HOJA_EXCEL.Range("CN" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CN" & fila + 1.ToString & ":CR" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            Else
                HOJA_EXCEL.Range("CN" & fila + 1.ToString & ":CR" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CN" & fila + 1.ToString).Value = TxtMuestreoCant.Text
                HOJA_EXCEL.Range("CN" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CN" & fila + 1.ToString & ":CR" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If

            If TxtMuestreoPrecioUn.Text = "" Then
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).NumberFormat = "###.###"
                HOJA_EXCEL.Range("CS" & fila + 1.ToString).Value = ""
                HOJA_EXCEL.Range("CS" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            Else
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).Merge()
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).NumberFormat = "###.###"
                HOJA_EXCEL.Range("CS" & fila + 1.ToString).Value = TxtMuestreoPrecioUn.Text
                HOJA_EXCEL.Range("CS" & fila + 1.ToString).Font.Size = 10
                HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":CZ" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If

            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DA" & fila + 1.ToString).Value = TxtMuestreo.Text
            HOJA_EXCEL.Range("DA" & fila + 1.ToString).Font.Size = 10
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("DA" & fila + 1.ToString & ":DK" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        End If

        ' ++++++++++++++++++++++++++++++  Imprime Descuento ++++++++++++++++++++++++++++++++

        If TxtDescto.Text <> 0 Then
            HOJA_EXCEL.Range("L" & fila + 2.ToString & ":CG" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("L" & fila + 2.ToString).Value = TxtDescto.Text & "%" & "Descuento"
            HOJA_EXCEL.Range("L" & fila + 2.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("L" & fila + 2.ToString & ":CG" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("DA" & fila + 2.ToString & ":DK" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("DA" & fila + 2.ToString & ":DK" & fila + 2.ToString).NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("DA" & fila + 2.ToString).Value = TxtDesctPesos.Text
            HOJA_EXCEL.Range("DA" & fila + 2.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("DA" & fila + 2.ToString & ":DK" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("DA" & fila + 2.ToString & ":DK" & fila + 2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        End If

        ' ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        'CALL VALOR_A_CIFRAS()
        If Me.txt_son.Text = "" Then
            Total_SF = Format(CInt(TxtTotal.Text), "#######")
            Palabra_Valor = Letras(CStr(Total_SF))
            HOJA_EXCEL.Range("L53:CU53").Merge()
            HOJA_EXCEL.Range("L53").Value = "Son : " & UCase(Mid(Palabra_Valor, 1, 1)) & Mid(Palabra_Valor, 2) & "  pesos"
            HOJA_EXCEL.Range("L53").Font.Size = 10
            HOJA_EXCEL.Range("L53:CU53").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("L53:CU53").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        Else

            HOJA_EXCEL.Range("L53:CU53").Merge()
            HOJA_EXCEL.Range("L53").Value = Me.txt_son.Text
            HOJA_EXCEL.Range("L53").Font.Size = 10
            HOJA_EXCEL.Range("L53:CU53").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("L53:CU53").VerticalAlignment = Excel.XlVAlign.xlVAlignTop


        End If

        If TxtFechaCancelacion.Text <> "" Then
            FechaI = Format(CDate(Me.TxtFechaCancelacion.Text), "dd MMMMMM yyyy")
            DIA = Mid(FechaI, 1, 2)
            MES = Trim(Mid(FechaI, 3, Len(FechaI) - 6))
            ANO = Trim(Mid(FechaI, Len(FechaI) - 4))

            If ChkCancelado.Checked = True Then
                HOJA_EXCEL.Range("F55:Q55").Merge()
                HOJA_EXCEL.Range("F55").Value = "CANCELADO :"
                HOJA_EXCEL.Range("F55").Font.Size = 8
                HOJA_EXCEL.Range("F55").Font.Bold = False
                HOJA_EXCEL.Range("F55: Q55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                HOJA_EXCEL.Range("R55:AA55").Merge()
                HOJA_EXCEL.Range("R55").Value = "Fecha,"
                HOJA_EXCEL.Range("R55").Font.Size = 8.5
                HOJA_EXCEL.Range("R55").Font.Bold = False
                HOJA_EXCEL.Range("R55:AA55").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                'fecha 
                HOJA_EXCEL.Range("AB55:AZ55").Merge()
                HOJA_EXCEL.Range("AB55").Value = DIA & " de " & MES & " de " & ANO
                HOJA_EXCEL.Range("AB55").Font.Size = 8.5
                HOJA_EXCEL.Range("AB55").Font.Bold = False
                HOJA_EXCEL.Range("AB55:AZ55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            End If
        End If

        If TxtAbono.Text <> "" And TxtAbono.Text <> "0" Then
            HOJA_EXCEL.Range("F55:Q55").Merge()
            HOJA_EXCEL.Range("F55").Value = "ABONO     :"
            HOJA_EXCEL.Range("F55").Font.Size = 8
            HOJA_EXCEL.Range("F55").Font.Bold = False
            HOJA_EXCEL.Range("F55:Q55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

            HOJA_EXCEL.Range("R55:AD55").Merge()
            HOJA_EXCEL.Range("R55").Value = TxtAbono.Text
            HOJA_EXCEL.Range("R55:AD55").NumberFormat = "#.###.###"
            HOJA_EXCEL.Range("R55").Font.Size = 8.5
            HOJA_EXCEL.Range("R55").Font.Bold = False
            HOJA_EXCEL.Range("R55:AD55").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        End If


        'nombre retira
        HOJA_EXCEL.Range("F57:L57").Merge()
        HOJA_EXCEL.Range("F57").Value = "Nombre"
        HOJA_EXCEL.Range("F57").Font.Size = 8.5
        HOJA_EXCEL.Range("F57:L57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("F57:L57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("M57").Value = ":"
        HOJA_EXCEL.Range("M57").Font.Size = 8.5
        HOJA_EXCEL.Range("M57:M57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("M57:M57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("N57:BD57").Merge()
        HOJA_EXCEL.Range("N57").Value = TxtNombreRetira.Text
        HOJA_EXCEL.Range("N57").Font.Size = 8.5
        HOJA_EXCEL.Range("N57:BD57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("N57:BD57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'rut retira
        HOJA_EXCEL.Range("BM57:BQ57").Merge()
        HOJA_EXCEL.Range("BM57").Value = "R.U.T"
        HOJA_EXCEL.Range("BM57").Font.Size = 8.5
        HOJA_EXCEL.Range("BM57:BQ57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BM57:BQ57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BR57").Value = ":"
        HOJA_EXCEL.Range("BR57").Font.Size = 8.5
        HOJA_EXCEL.Range("BR57:BR57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BR57:BR57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BS57:CC57").Merge()
        HOJA_EXCEL.Range("BS57").Value = TxtRutRetira.Text
        HOJA_EXCEL.Range("BS57").Font.Size = 8.5
        HOJA_EXCEL.Range("BS57:CC57").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BS57:CC57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        HOJA_EXCEL.Range("BS57:CC57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("F58:K58").Merge()
        HOJA_EXCEL.Range("F58").Value = "Fecha"
        HOJA_EXCEL.Range("F58").Font.Size = 8.5
        HOJA_EXCEL.Range("F58:K58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("F58:K58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("M58").Value = ":"
        HOJA_EXCEL.Range("M58").Font.Size = 8.5
        HOJA_EXCEL.Range("M58:M58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("M58:M58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop


        If TxtFechaRetiro.Text <> "" Then
            'fecha 
            HOJA_EXCEL.Range("N58:AD58").Merge()
            HOJA_EXCEL.Range("N58").Value = TxtFechaRetiro.Text
            HOJA_EXCEL.Range("N58").Font.Size = 8.5
            HOJA_EXCEL.Range("N58").Font.Bold = False
            HOJA_EXCEL.Range("N58:AD58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            HOJA_EXCEL.Range("N58:AD58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        End If

        'Recinto
        HOJA_EXCEL.Range("AE58:AK58").Merge()
        HOJA_EXCEL.Range("AE58").Value = "Recinto"
        HOJA_EXCEL.Range("AE58").Font.Size = 8.5
        HOJA_EXCEL.Range("AE58:AK58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AE58:AK58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("AL58").Value = ":"
        HOJA_EXCEL.Range("AL58").Font.Size = 8.5
        HOJA_EXCEL.Range("AL58:AL58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AL58:AL58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("AM58:BL58").Merge()
        HOJA_EXCEL.Range("AM58").Value = TxtRecintoRetira.Text
        HOJA_EXCEL.Range("AM58").Font.Size = 8.5
        HOJA_EXCEL.Range("AM58:BL58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AM58:BL58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'Firma

        HOJA_EXCEL.Range("BM58:BQ58").Merge()
        HOJA_EXCEL.Range("BM58").Value = "Firma"
        HOJA_EXCEL.Range("BM58").Font.Size = 8.5
        HOJA_EXCEL.Range("BM58:BQ58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BM58:BQ58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("BR58").Value = ":"
        HOJA_EXCEL.Range("BR58").Font.Size = 8.5
        HOJA_EXCEL.Range("BR58:BR58").HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BR58:BR58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'NETO
        'HOJA_EXCEL.Range("A56").RowHeight = 15

        HOJA_EXCEL.Range("CP57:CX57").Merge()
        HOJA_EXCEL.Range("CP57").Value = "NETO"
        HOJA_EXCEL.Range("CP57").Font.Size = 8
        HOJA_EXCEL.Range("CP57:CX57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP57:CX57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY57").Value = ":"
        HOJA_EXCEL.Range("CY57").Font.Size = 10
        HOJA_EXCEL.Range("CY57:CY57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY57:CY57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ57:DK57").Merge()
        HOJA_EXCEL.Range("CZ57:DK57").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CZ57").Value = TxtNeto.Text
        HOJA_EXCEL.Range("CZ57").Font.Size = 10
        HOJA_EXCEL.Range("CZ57:DK57").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ57:DK57").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'IVA (VALOR)

        HOJA_EXCEL.Range("CP58:CX58").Merge()
        HOJA_EXCEL.Range("CP58").Value = "% IVA"
        HOJA_EXCEL.Range("CP58").Font.Size = 8
        HOJA_EXCEL.Range("CP58:CX58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP58:CX58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY58").Value = ":"
        HOJA_EXCEL.Range("CY58").Font.Size = 10
        HOJA_EXCEL.Range("CY58:CY58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY58:CY58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ58:DK58").Merge()
        HOJA_EXCEL.Range("CZ58:DK58").NumberFormat = "###.###"
        HOJA_EXCEL.Range("CZ58").Value = TxtIva.Text
        HOJA_EXCEL.Range("CZ58").Font.Size = 10
        HOJA_EXCEL.Range("CZ58:DK58").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ58:DK58").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        'TOTAL
        'HOJA_EXCEL.Range("A45").RowHeight = 15

        HOJA_EXCEL.Range("CP59:CX59").Merge()
        HOJA_EXCEL.Range("CP59").Value = "TOTAL"
        HOJA_EXCEL.Range("CP59").Font.Size = 8
        HOJA_EXCEL.Range("CP59:CX59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CP59:CX59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CY59").Value = ":"
        HOJA_EXCEL.Range("CY59").Font.Size = 10
        HOJA_EXCEL.Range("CY59:CY59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CY59:CY59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("CZ59:DK59").Merge()
        HOJA_EXCEL.Range("CZ59:DK59").NumberFormat = "#.###.###"
        HOJA_EXCEL.Range("CZ59").Value = TxtTotal.Text
        HOJA_EXCEL.Range("CZ59").Font.Size = 10
        HOJA_EXCEL.Range("CZ59:DK59").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        HOJA_EXCEL.Range("CZ59:DK59").VerticalAlignment = Excel.XlVAlign.xlVAlignTop

        HOJA_EXCEL.Range("A1").Select()
        'm_Excel.ActivePrinter = "\\AGRO2\"
        'm_Excel.Dialogs(Excel.XlBuiltInDialog.xlDialogPrint).Show()
        'm_Excel.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, Collate:=True)

        'ViaImpresoraMatriz = "PROFACTURA en RPT1:" '"Okidata ML 320 Turbo/D (IBM) en Ne00:" 			String
        ViaImpresoraMatriz = "OKIDATA ML320/1 TURBO en Ne00:"
        'ViaImpresoraMatriz = "\\AGRO2\HP P2015 Sin Logo en Ne04:"

        m_Excel.ActivePrinter = ViaImpresoraMatriz
        MsgBox("Impresora:'" & (ViaImpresoraMatriz) & "'")
        m_Excel.ActiveWindow.SelectedSheets.PrintOut(Copies:=1, ActivePrinter:=ViaImpresoraMatriz, Collate:=True)

        Try
            HOJA_EXCEL.SaveAs(destino)
            m_Excel.Quit()
            m_Excel = Nothing
        Catch ex As Exception
            objLibroExcel.Close(False, , )
            m_Excel.Quit()
            m_Excel = Nothing
        End Try
        'Catch ex As Exception
        '    MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        'End Try

    End Sub

    Private Sub InsertaNumFactura()
        Dim SP As New CapaDato
        For i = 1 To 10
            If Arreglo_OT(i) <> 0 Then
                With SP
                    .Inicializar()
                    .AgregarParametro("@NumOt", Arreglo_OT(i), SqlDbType.Int)
                    .AgregarParametro("@NumFact", CInt(Txtfactura.Text), SqlDbType.Int)
                    .EjecutarEscalar("usp_InsertaNumFactura")
                End With
            End If
        Next

    End Sub

    'Private Sub Dtg_SeleccionDatos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_SeleccionDatos.Click
    '    Dim Fila As Integer

    '    Fila = Dtg_SeleccionDatos.CurrentCell.RowNumber
    '    NumOT = Dtg_SeleccionDatos(Fila, 0)

    '    Call CargaDatosDespacho()
    '    Txt_DesFacEmpresa.Text = Dtg_SeleccionDatos(Fila, 5)

    'End Sub

    Private Sub Bt_AceptaQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_AceptaQuery.Click
        Dim SP As New CapaDato
        Dim FilaDes As DataRow
        Dim Fila_Lect As Integer

        If Rdb_Facturar.Checked = True Then
            Call Carga_GrillaFactura()
        End If

        If Rdb_Despacho.Checked = True Then
            Call Carga_Grilla()
        End If

    End Sub

    Private Sub Rdb_ImpRes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpRes.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_ImpResyCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpResyCart.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_EnvEmail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_EnvEmail.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_ImpFact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpFact.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_ImpFactyCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpFactyCart.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_ImpFacRes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpFacRes.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_ImpFacResCart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_ImpFacResCart.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub Rdb_Nomina_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Nomina.Click
        Bt_Aceptar.Enabled = True
    End Sub

    Private Sub TxtDescto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescto.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(13) Then
            If TxtDescto.Text = "" Then TxtDescto.Text = 0
            TxtDesctPesos.Text = "0"
            Call Calcula_Valores_Factura()
        End If

        'Comentado x Jorge  06-11-2008 
        'Dim Porcentaje, SubTot, Iva As Double
        'If e.KeyChar = Chr(13) And TxtDescto.Text <> "" Then
        '    Porcentaje = CDbl(TxtSubTotal.Text) * CDbl(TxtDescto.Text / 100)
        '    TxtDesctPesos.Text = Round(Porcentaje, 0)
        '    SubTot = CDbl(TxtSubTotal.Text) - Porcentaje
        '    TxtSubTotal.Text = Round(SubTot, 0)

        '    If TxtMuestreo.Text = "" Then
        '        TxtNeto.Text = TxtSubTotal.Text
        '    Else
        '        TxtNeto.Text = CInt(TxtSubTotal.Text) + CInt(TxtMuestreo.Text)
        '    End If

        '    Iva = CDbl(TxtNeto.Text) * 0.19
        '    TxtIva.Text = Round(Iva, 0)

        '    TxtTotal.Text = CInt(TxtNeto.Text) + CInt(TxtIva.Text)
        'End If

    End Sub

    Private Sub TxtDesctPesos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDesctPesos.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If TxtDesctPesos.Text = "" Then TxtDesctPesos.Text = 0
            TxtDesctPesos.Text = CInt(TxtDesctPesos.Text)
            TxtDescto.Text = ""
            Call Calcula_Valores_Factura()
            TxtMuestreo.Focus()
        End If

        'Comentado x Jorge 06-11-2008
        'Dim Iva As Double
        'If e.KeyChar = Chr(13) Then
        '    TxtSubTotal.Text = CInt(TxtSubTotal.Text) - CInt(TxtDesctPesos.Text)
        '    If TxtMuestreo.Text = "" Then
        '        TxtNeto.Text = TxtSubTotal.Text
        '    Else
        '        TxtNeto.Text = CInt(TxtSubTotal.Text) + CInt(TxtMuestreo.Text)
        '    End If

        '    Iva = CDbl(TxtNeto.Text) * 0.19
        '    TxtIva.Text = Round(Iva, 0)

        '    TxtTotal.Text = CInt(TxtNeto.Text) + CInt(TxtIva.Text)

        'End If
    End Sub

    Private Sub Calcula_Valores_Factura()
        Try
            Dim ObjSum As Object
            Dim SubTotal As Integer
            Dim RESTA, Csubtotal, TotalDesct, CNeto, CMuestreo, Cabono, CDesctPesos, CSaldo, CDesct As Integer
            Dim Cdescuento, RestaSub As Double
            ObjSum = Cjto_Tablas1.Tables("FACTURA_DETALLE_DESPACHO1").Compute("Sum(DET_TOTAL)", "DET_TOTAL > 0")
            Try
                SubTotal = CInt(ObjSum)
            Catch ex As Exception

            End Try
            If CInt(Me.TxtMuestreoCant.Text) <> 0 And CInt(Me.TxtMuestreoPrecioUn.Text) <> 0 Then
                Me.TxtMuestreo.Text = CInt(Me.TxtMuestreoCant.Text) * CInt(Me.TxtMuestreoPrecioUn.Text)

            End If

            If TxtMuestreo.Text <> "0" Then
                CMuestreo = CInt(TxtMuestreo.Text)
            Else
                CMuestreo = 0
            End If



            If TxtAbono.Text <> "0" Then Cabono = CDbl(Me.TxtAbono.Text) Else Cabono = 0


            If TxtDescto.Text <> "0" Then Cdescuento = CDbl(Me.TxtDescto.Text) Else Cdescuento = 0
            If TxtDesctPesos.Text <> "0" Then CDesctPesos = CDbl(Me.TxtDesctPesos.Text) Else CDesctPesos = 0

            If CDesctPesos <> 0 And Cdescuento = 0 Then
                If SubTotal <> 0 Then
                    RestaSub = CDesctPesos / SubTotal
                    Cdescuento = (RestaSub * 100)
                    TxtDesctPesos.Text = CInt(CDesctPesos)
                    TxtDescto.Text = Cdescuento
                End If
            End If

            If CDesctPesos = 0 And Cdescuento <> 0 Then
                TxtDescto.Text = Cdescuento
                CDesctPesos = CInt((SubTotal * CDbl(Cdescuento / 100)))
                TxtDesctPesos.Text = CInt(CDesctPesos)
            End If

            TxtAbono.Text = Cabono

            TxtMuestreo.Text = CMuestreo
            CNeto = (SubTotal + CMuestreo) - CDesctPesos
            Pa_Iva = "19"
            TxtSubTotal.Text = SubTotal
            TxtNeto.Text = CNeto
            TxtIva.Text = CInt((CNeto * (CInt(Pa_Iva) / 100)))
            TxtTotal.Text = (CNeto + CInt(TxtIva.Text))
            If ChkCancelado.Checked = True Then
                CSaldo = 0
            Else

                CSaldo = CInt(TxtTotal.Text) - CInt(TxtAbono.Text)
            End If

            TxtSaldo.Text = CSaldo

        Catch ex As Exception
            MsgBox("error" & ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub TxtAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAbono.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            If TxtAbono.Text = "" Then TxtAbono.Text = 0
            Me.TxtAbono.Text = CInt(TxtAbono.Text)
            Call Calcula_Valores_Factura()
            TxtSubTotal.Focus()
        End If
    End Sub

    Private Sub TxtMuestreoCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreoCant.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            TxtMuestreoPrecioUn.Focus()
        End If
    End Sub

    Private Sub TxtMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreo.KeyPress
        Dim KeyAscii As Short = CShort(Asc(e.KeyChar))
        KeyAscii = CShort(SoloNumeros(KeyAscii))
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(13) Then
            Me.TxtMuestreo.Text = TxtMuestreo.Text
            Call Calcula_Valores_Factura()
        End If
    End Sub

    Private Sub CBCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCalcular.Click
        Try
            If Me.TxtAbono.Text = "" And Me.TxtSaldo.Text = "" Then
                Me.TxtAbono.Text = 0
                Me.TxtSaldo.Text = 0
            End If

            Dim Total_Sf2, vaCantidadUnidad As Integer
            Dim palabra_valor2 As String
            TxtDesctPesos.Text = "0"
            Call Calcula_Valores_Factura()
            Total_Sf2 = Format(CInt(TxtTotal.Text), "#######")
            palabra_valor2 = Letras(CStr(Total_Sf2))
            Me.txt_son.Text = "Son : " & UCase(Mid(palabra_valor2, 1, 1)) & Mid(palabra_valor2, 2) & "  pesos"
            vaCantidadUnidad = Len(Me.TxtDescto.Text)

            If vaCantidadUnidad < 2 And vaCantidadUnidad <> 0 Then
                Me.TxtDescto.Text = "0" & Me.TxtDescto.Text
            End If

        Catch ex As Exception
            MsgBox("No hay datos para calcular", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub TxtDespachoNombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDespachoNombre.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtDespachoNombre.Text
            Call control_nombre(NOMBREX)
            TxtDespachoNombre.Text = NOMBREX
            Me.TxtDespachoAtencion.Focus()
        End If
    End Sub

    Private Sub TxtDespachoAtencion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDespachoAtencion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtDespachoAtencion.Text
            Call control_nombre(NOMBREX)
            TxtDespachoAtencion.Text = NOMBREX
            Me.TxtDespachoDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDespachoDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDespachoDireccion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtDespachoDireccion.Text
            Call control_nombre(NOMBREX)
            TxtDespachoDireccion.Text = NOMBREX
            Me.Txt_DesComuna.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacSeñores_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacSeñores.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacSeñores.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacSeñores.Text = NOMBREX
            Me.Txt_DesComuna.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacDireccion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacDireccion.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacDireccion.Text = NOMBREX
            Me.Txt_DesFacGiro.Focus()
        End If
    End Sub

    Private Sub Txt_RSocial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_RSocial.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_RSocial.Text
            Call control_nombre(NOMBREX)
            Txt_RSocial.Text = NOMBREX
            Me.TxtDireccion.Focus()
        End If
    End Sub

    Private Sub TxtDireccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtDireccion.Text
            Call control_nombre(NOMBREX)
            TxtDireccion.Text = NOMBREX
            Me.Txt_DesFacF1.Focus()
        End If
    End Sub

    Private Sub TxtGiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGiro.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtGiro.Text
            Call control_nombre(NOMBREX)
            TxtGiro.Text = NOMBREX
            Me.TxtSolicitadoPor.Focus()
        End If
    End Sub

    Private Sub TxtSolicitadoPor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSolicitadoPor.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtSolicitadoPor.Text
            Call control_nombre(NOMBREX)
            TxtSolicitadoPor.Text = NOMBREX
            Me.TxtEncPago.Focus()
        End If
    End Sub

    Private Sub TxtEncPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEncPago.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtEncPago.Text
            Call control_nombre(NOMBREX)
            TxtEncPago.Text = NOMBREX
            Me.Txt_Ciudad.Focus()
        End If
    End Sub

    Private Sub ChkCancelado_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChkCancelado.CheckedChanged
        If ChkCancelado.Checked = True Then
            TxtAbono.Text = 0 'Format(CInt(TxtTotal2.Text), "####,###")
            TxtSaldo.Text = 0
            'Me.TxtFechaCancelacion.Text = Today
        Else
            TxtAbono.Text = "" 'Format(CInt(TxtTotal2.Text), "####,###")
            TxtSaldo.Text = ""
            Me.TxtFechaCancelacion.Text = ""
        End If
    End Sub

    Private Sub Txt_DesFacGiro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacGiro.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacGiro.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacGiro.Text = NOMBREX
            Me.Txt_DesFacSolicita.Focus()
        End If
    End Sub

    Private Sub Txt_DespFacCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DespFacCiudad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DespFacCiudad.Text
            Call control_nombre(NOMBREX)
            Txt_DespFacCiudad.Text = NOMBREX
            Me.Txt_DesFacSolicita.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacEmpresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacEmpresa.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacEmpresa.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacEmpresa.Text = NOMBREX
            Me.Txt_DesFacSolicita.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacComuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacComuna.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacComuna.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacComuna.Text = NOMBREX
            Me.Txt_DesFacSolicita.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacSolicita_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacSolicita.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacSolicita.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacSolicita.Text = NOMBREX
            Me.Txt_DesFacEncPago.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacEncPago_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacEncPago.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacEncPago.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacEncPago.Text = NOMBREX
            Me.Txt_DesFacSolicita.Focus()
        End If
    End Sub

    Private Sub Txt_DesCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesCiudad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesCiudad.Text
            Call control_nombre(NOMBREX)
            Txt_DesCiudad.Text = NOMBREX
            Me.TxtEntrego.Focus()
        End If
    End Sub

    Private Sub Txt_DesComuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesComuna.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesComuna.Text
            Call control_nombre(NOMBREX)
            Txt_DesComuna.Text = NOMBREX
            Me.TxtEntrego.Focus()
        End If
    End Sub

    Private Sub TxtEntrego_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtEntrego.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = TxtEntrego.Text
            Call control_nombre(NOMBREX)
            TxtEntrego.Text = NOMBREX
            Me.Txt_DesComuna.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacAtencion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacAtencion.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacAtencion.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacAtencion.Text = NOMBREX
            Me.Txt_DesFacIngSr.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacIngSr_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacIngSr.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacIngSr.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacIngSr.Text = NOMBREX
            Me.Txt_DesFacDirec.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacDirec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacDirec.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacDirec.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacDirec.Text = NOMBREX
            Me.Txt_DesFacComuna.Focus()
        End If
    End Sub

    Private Sub Txt_DesFacCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DesFacCiudad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_DesFacCiudad.Text
            Call control_nombre(NOMBREX)
            Txt_DesFacCiudad.Text = NOMBREX
            Me.Txt_DesFacComuna.Focus()
        End If
    End Sub

    Private Sub Txt_Ciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Ciudad.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_Ciudad.Text
            Call control_nombre(NOMBREX)
            Txt_Ciudad.Text = NOMBREX
            Me.Txt_Empresa.Focus()
        End If
    End Sub

    Private Sub Txt_Comuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Comuna.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_Comuna.Text
            Call control_nombre(NOMBREX)
            Txt_Comuna.Text = NOMBREX
            Me.Txt_Empresa.Focus()
        End If
    End Sub

    Private Sub LimpiaDespachar()
        TxtNombreRetira.Text = ""
        TxtRutRetira.Text = ""
        TxtFechaRetiro.Text = ""

        TxtFechaCancelacion.Text = ""
        ChkCancelado.Checked = False
        TxtAbono.Text = ""
        TxtSaldo.Text = ""

        TxtMuestreoCant.Text = ""
        TxtMuestreoPrecioUn.Text = ""

        TxtDescto.Text = ""
        TxtDesctPesos.Text = ""
        TxtSubTotal.Text = ""
        TxtMuestreo.Text = ""
        TxtNeto.Text = ""
        TxtIva.Text = ""
        TxtTotal.Text = ""

    End Sub

    Private Sub Txt_Empresa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Empresa.KeyPress
        Dim NOMBREX As String
        If e.KeyChar = Chr(13) Then
            NOMBREX = Txt_Empresa.Text
            Call control_nombre(NOMBREX)
            Txt_Empresa.Text = NOMBREX
            Me.TxtDireccion.Focus()
        End If
    End Sub






    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        Call Calcula_Valores_Factura()
    End Sub

    Private Sub chk_FacElectronica_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_FacElectronica.CheckedChanged
        Dim dsNFacE As New DataSet
        Dim SP As New CapaDato

        dsNFacE.Tables.Clear()
        dsNFacE = Nothing

        If Txtfactura.Text <> "" Then

            If chk_FacElectronica.Checked = False Then
                If MsgBox("Si desactiva esta opción se facturará de manera TRADICIONAL, ¿Desea Continuar?", MsgBoxStyle.YesNo, "Facturar") = MsgBoxResult.Yes Then

                    With SP
                        .Inicializar()
                        .AgregarParametro("@opcion", "T", SqlDbType.VarChar)
                        dsNFacE = .EjecutarQuery("ys_ObtieneFacNumero")

                    End With

                    Txtfactura.Text = dsNFacE.Tables(0).Rows.Item(0).Item(0).ToString
                    'chk_FacElectronica.Checked = False

                Else

                    With SP
                        .Inicializar()
                        .AgregarParametro("@opcion", "E", SqlDbType.VarChar)
                        dsNFacE = .EjecutarQuery("ys_ObtieneFacNumero")

                    End With

                    Txtfactura.Text = dsNFacE.Tables(0).Rows.Item(0).Item(0).ToString
                    chk_FacElectronica.Checked = True

                End If
            Else

                With SP
                    .Inicializar()
                    .AgregarParametro("@opcion", "E", SqlDbType.VarChar)
                    dsNFacE = .EjecutarQuery("ys_ObtieneFacNumero")

                End With

                Txtfactura.Text = dsNFacE.Tables(0).Rows.Item(0).Item(0).ToString
                'chk_FacElectronica.Checked = True
            End If

        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        TxtFechaRetiro.Text = DateTimePicker1.Text
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        TxtFechaCancelacion.Text = DateTimePicker2.Text

    End Sub
End Class
