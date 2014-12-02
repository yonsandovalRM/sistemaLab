Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.Xml
Imports System.Math

Public Class F_DigitaResultado
    Inherits System.Windows.Forms.Form
    Private simbolo, Codigo, Tit_Formula, Unidad, ForFact, Metodo2, CalFact As String
    Private Muestra_Control, Fila_Lectura As Integer
    Private Dilucion1, Dilucion2, FDilucion, FCalculo, FCalPoten, FCalNNH4 As Double
    Public Fila_ini, Fila_ini2 As Integer
    Private Num_Pag As Integer
    Dim Blanco_Aux, Peso_Atomico, Ultimo_Blanco, EntBl, DecBl, EntFac, DecFac, EntLec, DecLec, EntRes, DecRes, Factor_Propu As Double
    Dim Mascara As Integer

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Cbx_Digitador As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_PMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_VAforo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_VAlicuota As System.Windows.Forms.TextBox
    Friend WithEvents Txt_AforoAlicuota As System.Windows.Forms.TextBox
    Friend WithEvents Txt_FactRegresion As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NLabInicial As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NLabDesde As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NLabHasta As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Elementos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Gbx_Regresion As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Ocacional As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_Frecuentes As System.Windows.Forms.RadioButton
    Friend WithEvents TxtLectura As System.Windows.Forms.TextBox
    Friend WithEvents TxtNumLab As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LecRes As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Digitado As System.Windows.Forms.DataGrid
    Friend WithEvents Dtg_Elenf As System.Windows.Forms.DataGrid
    Friend WithEvents Dtp_FechaDigitacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaAnalisis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaPlanilla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbx_Analista As System.Windows.Forms.ComboBox
    Friend WithEvents Bt_Carga As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Lb_LectBlanco As System.Windows.Forms.Label
    Friend WithEvents Lb_LectFactor As System.Windows.Forms.Label
    Friend WithEvents Gbx_Lectura As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNH4PesoMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NNH4Normalidad As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NNH4VolumenAforo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NNH4Alicuota As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_NNH4 As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Nitrogeno As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_GasFactor As System.Windows.Forms.Label
    Friend WithEvents Txt_GasFactor As System.Windows.Forms.TextBox
    Friend WithEvents Lb_GasNormailidad As System.Windows.Forms.Label
    Friend WithEvents Txt_GasNormalidad As System.Windows.Forms.TextBox
    Friend WithEvents Lb_GasPMuestra As System.Windows.Forms.Label
    Friend WithEvents Txt_GasPMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Lb_NNH4Factor As System.Windows.Forms.Label
    Friend WithEvents Txt_NNH4Factor As System.Windows.Forms.TextBox
    Friend WithEvents GBX_pyb1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtCalculaCoe As System.Windows.Forms.Button
    Friend WithEvents LabResultado As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_pyb_tram10 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem10 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram9 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem9 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem7 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem8 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram8 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram7 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem6 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram6 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram5 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_elem4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram3 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txt_pyb_elem1 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txt_pyb_elem2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_pyb_tram1 As System.Windows.Forms.TextBox
    Friend WithEvents Lb_Metodo As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Lb_Metodo2 As System.Windows.Forms.Label
    Friend WithEvents Txt_LectAforo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Lb_VolAforoAlicuota As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Txt_LectPesoMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LectVolAlicuota As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LectVolAforoAlic As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_Comentarios As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_Metodologia As System.Windows.Forms.Label
    Friend WithEvents Lb_TitCalculo As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Txt_1ºDilucion As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txt_Lect2ºFactor As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Txt_LectFactDilucion As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Txt_PAtomico As System.Windows.Forms.TextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txt_FacConv As System.Windows.Forms.TextBox
    Friend WithEvents Lnk_ChekeoNorm As System.Windows.Forms.LinkLabel
    Public WithEvents Txt_Chequeo As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_Potenciometrico As System.Windows.Forms.GroupBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Lb_PotNormailidad As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNormalidad As System.Windows.Forms.TextBox
    Friend WithEvents Lb_PotFactConv As System.Windows.Forms.Label
    Friend WithEvents Txt_PotFactConv As System.Windows.Forms.TextBox
    Friend WithEvents Lb_PotPesoAtomico As System.Windows.Forms.Label
    Friend WithEvents Txt_PotPesoAtomico As System.Windows.Forms.TextBox
    Friend WithEvents Lb_PotPesoMuestra As System.Windows.Forms.Label
    Friend WithEvents Txt_PotPesoMuestra As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Public WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PotFactor As System.Windows.Forms.TextBox
    Friend WithEvents Lnk_PotChequeo As System.Windows.Forms.LinkLabel
    Friend WithEvents Gbx_PotNNH4 As System.Windows.Forms.GroupBox
    Public WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4FacConvercion As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4PesoAtomico As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4Factor As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4Normalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4PMuestra As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4VAforo As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Txt_PotNNH4Alicuota As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Gbx_Clorofila As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_CloFact1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CloAbs1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CloFac2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CloAbs2 As System.Windows.Forms.TextBox
    Friend WithEvents Bt_ClorofilaAceptar As System.Windows.Forms.Button
    Friend WithEvents Txt_MasaMue As System.Windows.Forms.TextBox
    Friend WithEvents Txt_VolExt As System.Windows.Forms.TextBox
    Friend WithEvents Txt_VolAli As System.Windows.Forms.TextBox
    Friend WithEvents Txt_AfoAli As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Factor As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Dtg_DigitaNNO3 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Dtg_DigitaVolumetrico As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_LecturaVolumetrico As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NNO3FacDil As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3FacExt As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3Fac2dil As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3VolAfoAli As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3VolAli As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3VolExt As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Txt_NNO3MasaMuestra As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents TextBox17 As System.Windows.Forms.TextBox
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents TextBox18 As System.Windows.Forms.TextBox
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents Gbx_NNO3 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_FactorVolumetrico As System.Windows.Forms.TextBox
    Friend WithEvents TxtFactor As System.Windows.Forms.TextBox
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Public WithEvents Txt_NTitrisol As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Lectura As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_LectResultado As System.Windows.Forms.TextBox
    Friend WithEvents Txt_LectObservacion As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Dtg_Potenciometrico As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_LectPotenciometrico As System.Windows.Forms.TextBox
    Friend WithEvents Lb_TipoAna As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cbx_Analista = New System.Windows.Forms.ComboBox
        Me.Dtp_FechaAnalisis = New System.Windows.Forms.DateTimePicker
        Me.Cbx_Digitador = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Dtp_FechaDigitacion = New System.Windows.Forms.DateTimePicker
        Me.Lb_TipoAna = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Dtp_FechaPlanilla = New System.Windows.Forms.DateTimePicker
        Me.Bt_Carga = New System.Windows.Forms.Button
        Me.Txt_NLabHasta = New System.Windows.Forms.TextBox
        Me.Txt_NLabDesde = New System.Windows.Forms.TextBox
        Me.Txt_NLabInicial = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Gbx_Regresion = New System.Windows.Forms.GroupBox
        Me.Txt_FactRegresion = New System.Windows.Forms.TextBox
        Me.Txt_AforoAlicuota = New System.Windows.Forms.TextBox
        Me.Txt_VAlicuota = New System.Windows.Forms.TextBox
        Me.Txt_VAforo = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txt_PMuestra = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Gbx_Nitrogeno = New System.Windows.Forms.GroupBox
        Me.Txt_NTitrisol = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.Txt_Chequeo = New System.Windows.Forms.TextBox
        Me.Lnk_ChekeoNorm = New System.Windows.Forms.LinkLabel
        Me.Label32 = New System.Windows.Forms.Label
        Me.txt_FacConv = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Txt_PAtomico = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Lb_GasFactor = New System.Windows.Forms.Label
        Me.Txt_GasFactor = New System.Windows.Forms.TextBox
        Me.Lb_GasNormailidad = New System.Windows.Forms.Label
        Me.Txt_GasNormalidad = New System.Windows.Forms.TextBox
        Me.Lb_GasPMuestra = New System.Windows.Forms.Label
        Me.Txt_GasPMuestra = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Rdb_Todos = New System.Windows.Forms.RadioButton
        Me.Rdb_Ocacional = New System.Windows.Forms.RadioButton
        Me.Rdb_Frecuentes = New System.Windows.Forms.RadioButton
        Me.Gbx_Lectura = New System.Windows.Forms.GroupBox
        Me.Txt_LectFactDilucion = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Txt_1ºDilucion = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Txt_Lect2ºFactor = New System.Windows.Forms.TextBox
        Me.Lb_VolAforoAlicuota = New System.Windows.Forms.Label
        Me.Txt_LectVolAforoAlic = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt_LectVolAlicuota = New System.Windows.Forms.TextBox
        Me.Lb_LectFactor = New System.Windows.Forms.Label
        Me.Txt_LectAforo = New System.Windows.Forms.TextBox
        Me.Lb_LectBlanco = New System.Windows.Forms.Label
        Me.Txt_LectPesoMuestra = New System.Windows.Forms.TextBox
        Me.Gbx_NNH4 = New System.Windows.Forms.GroupBox
        Me.Lb_NNH4Factor = New System.Windows.Forms.Label
        Me.Txt_NNH4Factor = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Txt_NNH4Alicuota = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Txt_NNH4VolumenAforo = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Txt_NNH4Normalidad = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txt_NNH4PesoMuestra = New System.Windows.Forms.TextBox
        Me.Dtg_Elementos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Dtg_Digitado = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Dtg_DigitaNNO3 = New System.Windows.Forms.DataGrid
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Limpiar = New System.Windows.Forms.Button
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.TxtLectura = New System.Windows.Forms.TextBox
        Me.TxtNumLab = New System.Windows.Forms.TextBox
        Me.Txt_LecRes = New System.Windows.Forms.TextBox
        Me.Dtg_Elenf = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Dtg_DigitaVolumetrico = New System.Windows.Forms.DataGrid
        Me.GBX_pyb1 = New System.Windows.Forms.GroupBox
        Me.BtCalculaCoe = New System.Windows.Forms.Button
        Me.LabResultado = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.txt_pyb_tram10 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem10 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram9 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem9 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem7 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem8 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram8 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram7 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem5 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem6 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram6 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram5 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem3 = New System.Windows.Forms.TextBox
        Me.txt_pyb_elem4 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram4 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram3 = New System.Windows.Forms.TextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txt_pyb_elem1 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txt_pyb_elem2 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram2 = New System.Windows.Forms.TextBox
        Me.txt_pyb_tram1 = New System.Windows.Forms.TextBox
        Me.Lb_Metodo2 = New System.Windows.Forms.Label
        Me.Lb_Metodo = New System.Windows.Forms.Label
        Me.Gbx_Comentarios = New System.Windows.Forms.GroupBox
        Me.Lb_Metodologia = New System.Windows.Forms.Label
        Me.Lb_TitCalculo = New System.Windows.Forms.Label
        Me.Gbx_Potenciometrico = New System.Windows.Forms.GroupBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Lnk_PotChequeo = New System.Windows.Forms.LinkLabel
        Me.Label34 = New System.Windows.Forms.Label
        Me.Txt_PotFactor = New System.Windows.Forms.TextBox
        Me.Lb_PotFactConv = New System.Windows.Forms.Label
        Me.Txt_PotFactConv = New System.Windows.Forms.TextBox
        Me.Lb_PotPesoAtomico = New System.Windows.Forms.Label
        Me.Txt_PotPesoAtomico = New System.Windows.Forms.TextBox
        Me.Lb_PotPesoMuestra = New System.Windows.Forms.Label
        Me.Txt_PotPesoMuestra = New System.Windows.Forms.TextBox
        Me.Lb_PotNormailidad = New System.Windows.Forms.Label
        Me.Txt_PotNormalidad = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Gbx_PotNNH4 = New System.Windows.Forms.GroupBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4Alicuota = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4VAforo = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.Label35 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4FacConvercion = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4PesoAtomico = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4Factor = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4Normalidad = New System.Windows.Forms.TextBox
        Me.Label40 = New System.Windows.Forms.Label
        Me.Txt_PotNNH4PMuestra = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Label43 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.Gbx_Clorofila = New System.Windows.Forms.GroupBox
        Me.Bt_ClorofilaAceptar = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Txt_CloAbs2 = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.Txt_CloFac2 = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.Txt_CloAbs1 = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.Txt_CloFact1 = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.Txt_MasaMue = New System.Windows.Forms.TextBox
        Me.Txt_VolExt = New System.Windows.Forms.TextBox
        Me.Txt_VolAli = New System.Windows.Forms.TextBox
        Me.Txt_AfoAli = New System.Windows.Forms.TextBox
        Me.Txt_Factor = New System.Windows.Forms.TextBox
        Me.Txt_LecturaVolumetrico = New System.Windows.Forms.TextBox
        Me.Txt_NNO3FacDil = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label54 = New System.Windows.Forms.Label
        Me.Txt_NNO3FacExt = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.Txt_NNO3Fac2dil = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.Txt_NNO3VolAfoAli = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.Txt_NNO3VolAli = New System.Windows.Forms.TextBox
        Me.Label61 = New System.Windows.Forms.Label
        Me.Txt_NNO3VolExt = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.Txt_NNO3MasaMuestra = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.TextBox17 = New System.Windows.Forms.TextBox
        Me.Label66 = New System.Windows.Forms.Label
        Me.TextBox18 = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.Gbx_NNO3 = New System.Windows.Forms.GroupBox
        Me.Txt_FactorVolumetrico = New System.Windows.Forms.TextBox
        Me.TxtFactor = New System.Windows.Forms.TextBox
        Me.Dtg_Lectura = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Txt_LectResultado = New System.Windows.Forms.TextBox
        Me.Txt_LectObservacion = New System.Windows.Forms.TextBox
        Me.Dtg_Potenciometrico = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Txt_LectPotenciometrico = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Gbx_Regresion.SuspendLayout()
        Me.Gbx_Nitrogeno.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Gbx_Lectura.SuspendLayout()
        Me.Gbx_NNH4.SuspendLayout()
        CType(Me.Dtg_Elementos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_Digitado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_DigitaNNO3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_Elenf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_DigitaVolumetrico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBX_pyb1.SuspendLayout()
        Me.Gbx_Comentarios.SuspendLayout()
        Me.Gbx_Potenciometrico.SuspendLayout()
        Me.Gbx_PotNNH4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Gbx_Clorofila.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.Gbx_NNO3.SuspendLayout()
        CType(Me.Dtg_Lectura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_Potenciometrico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Cbx_Analista)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaAnalisis)
        Me.GroupBox1.Controls.Add(Me.Cbx_Digitador)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaDigitacion)
        Me.GroupBox1.Controls.Add(Me.Lb_TipoAna)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Cbx_Analista
        '
        Me.Cbx_Analista.Location = New System.Drawing.Point(389, 54)
        Me.Cbx_Analista.Name = "Cbx_Analista"
        Me.Cbx_Analista.Size = New System.Drawing.Size(122, 21)
        Me.Cbx_Analista.TabIndex = 9
        '
        'Dtp_FechaAnalisis
        '
        Me.Dtp_FechaAnalisis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaAnalisis.Location = New System.Drawing.Point(389, 24)
        Me.Dtp_FechaAnalisis.Name = "Dtp_FechaAnalisis"
        Me.Dtp_FechaAnalisis.Size = New System.Drawing.Size(122, 20)
        Me.Dtp_FechaAnalisis.TabIndex = 8
        '
        'Cbx_Digitador
        '
        Me.Cbx_Digitador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Digitador.Location = New System.Drawing.Point(125, 54)
        Me.Cbx_Digitador.Name = "Cbx_Digitador"
        Me.Cbx_Digitador.Size = New System.Drawing.Size(122, 22)
        Me.Cbx_Digitador.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(281, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Análista"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(281, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Análisis"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digitador"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Digitación"
        '
        'Dtp_FechaDigitacion
        '
        Me.Dtp_FechaDigitacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaDigitacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaDigitacion.Location = New System.Drawing.Point(125, 24)
        Me.Dtp_FechaDigitacion.Name = "Dtp_FechaDigitacion"
        Me.Dtp_FechaDigitacion.Size = New System.Drawing.Size(122, 20)
        Me.Dtp_FechaDigitacion.TabIndex = 100
        '
        'Lb_TipoAna
        '
        Me.Lb_TipoAna.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Lb_TipoAna.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TipoAna.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Lb_TipoAna.Location = New System.Drawing.Point(8, -8)
        Me.Lb_TipoAna.Name = "Lb_TipoAna"
        Me.Lb_TipoAna.Size = New System.Drawing.Size(100, 23)
        Me.Lb_TipoAna.TabIndex = 63
        Me.Lb_TipoAna.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox2.Controls.Add(Me.Dtp_FechaPlanilla)
        Me.GroupBox2.Controls.Add(Me.Bt_Carga)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabHasta)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabDesde)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabInicial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Dtp_FechaPlanilla
        '
        Me.Dtp_FechaPlanilla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaPlanilla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaPlanilla.Location = New System.Drawing.Point(389, 21)
        Me.Dtp_FechaPlanilla.Name = "Dtp_FechaPlanilla"
        Me.Dtp_FechaPlanilla.Size = New System.Drawing.Size(122, 20)
        Me.Dtp_FechaPlanilla.TabIndex = 10
        '
        'Bt_Carga
        '
        Me.Bt_Carga.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Carga.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Carga.Image = Global.LabSys.My.Resources.Resources.server_database
        Me.Bt_Carga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Carga.Location = New System.Drawing.Point(436, 82)
        Me.Bt_Carga.Name = "Bt_Carga"
        Me.Bt_Carga.Size = New System.Drawing.Size(75, 27)
        Me.Bt_Carga.TabIndex = 9
        Me.Bt_Carga.Text = "Cargar"
        Me.Bt_Carga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Carga.UseVisualStyleBackColor = False
        '
        'Txt_NLabHasta
        '
        Me.Txt_NLabHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabHasta.Location = New System.Drawing.Point(389, 56)
        Me.Txt_NLabHasta.Name = "Txt_NLabHasta"
        Me.Txt_NLabHasta.Size = New System.Drawing.Size(122, 20)
        Me.Txt_NLabHasta.TabIndex = 7
        '
        'Txt_NLabDesde
        '
        Me.Txt_NLabDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabDesde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabDesde.Location = New System.Drawing.Point(125, 56)
        Me.Txt_NLabDesde.Name = "Txt_NLabDesde"
        Me.Txt_NLabDesde.Size = New System.Drawing.Size(122, 20)
        Me.Txt_NLabDesde.TabIndex = 6
        '
        'Txt_NLabInicial
        '
        Me.Txt_NLabInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabInicial.Location = New System.Drawing.Point(125, 24)
        Me.Txt_NLabInicial.Name = "Txt_NLabInicial"
        Me.Txt_NLabInicial.Size = New System.Drawing.Size(122, 20)
        Me.Txt_NLabInicial.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(281, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nº Lab.Hasta"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nº Lab.Desde"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(281, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha Planifica"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cód.Planifica"
        '
        'Gbx_Regresion
        '
        Me.Gbx_Regresion.Controls.Add(Me.Txt_FactRegresion)
        Me.Gbx_Regresion.Controls.Add(Me.Txt_AforoAlicuota)
        Me.Gbx_Regresion.Controls.Add(Me.Txt_VAlicuota)
        Me.Gbx_Regresion.Controls.Add(Me.Txt_VAforo)
        Me.Gbx_Regresion.Controls.Add(Me.Label13)
        Me.Gbx_Regresion.Controls.Add(Me.Label12)
        Me.Gbx_Regresion.Controls.Add(Me.Label11)
        Me.Gbx_Regresion.Controls.Add(Me.Label10)
        Me.Gbx_Regresion.Controls.Add(Me.Txt_PMuestra)
        Me.Gbx_Regresion.Controls.Add(Me.Label9)
        Me.Gbx_Regresion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Regresion.Location = New System.Drawing.Point(600, 288)
        Me.Gbx_Regresion.Name = "Gbx_Regresion"
        Me.Gbx_Regresion.Size = New System.Drawing.Size(600, 184)
        Me.Gbx_Regresion.TabIndex = 2
        Me.Gbx_Regresion.TabStop = False
        Me.Gbx_Regresion.Text = "Regresión"
        Me.Gbx_Regresion.Visible = False
        '
        'Txt_FactRegresion
        '
        Me.Txt_FactRegresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_FactRegresion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_FactRegresion.Location = New System.Drawing.Point(200, 152)
        Me.Txt_FactRegresion.Name = "Txt_FactRegresion"
        Me.Txt_FactRegresion.Size = New System.Drawing.Size(72, 20)
        Me.Txt_FactRegresion.TabIndex = 15
        '
        'Txt_AforoAlicuota
        '
        Me.Txt_AforoAlicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_AforoAlicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_AforoAlicuota.Location = New System.Drawing.Point(200, 120)
        Me.Txt_AforoAlicuota.Name = "Txt_AforoAlicuota"
        Me.Txt_AforoAlicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_AforoAlicuota.TabIndex = 14
        '
        'Txt_VAlicuota
        '
        Me.Txt_VAlicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_VAlicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VAlicuota.Location = New System.Drawing.Point(200, 88)
        Me.Txt_VAlicuota.Name = "Txt_VAlicuota"
        Me.Txt_VAlicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_VAlicuota.TabIndex = 13
        '
        'Txt_VAforo
        '
        Me.Txt_VAforo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_VAforo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_VAforo.Location = New System.Drawing.Point(200, 56)
        Me.Txt_VAforo.Name = "Txt_VAforo"
        Me.Txt_VAforo.Size = New System.Drawing.Size(72, 20)
        Me.Txt_VAforo.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label13.Location = New System.Drawing.Point(8, 152)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Factor"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label12.Location = New System.Drawing.Point(8, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(184, 23)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Volumen Alicuota(ml)"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(184, 23)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Volumen Aforo Alicuota(ml)"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label10.Location = New System.Drawing.Point(8, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Peso Muestra(gr)"
        '
        'Txt_PMuestra
        '
        Me.Txt_PMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PMuestra.Location = New System.Drawing.Point(200, 24)
        Me.Txt_PMuestra.Name = "Txt_PMuestra"
        Me.Txt_PMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PMuestra.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label9.Location = New System.Drawing.Point(8, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 23)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Volumen Aforo(ml)"
        '
        'Gbx_Nitrogeno
        '
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_NTitrisol)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Label68)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_Chequeo)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Lnk_ChekeoNorm)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Label32)
        Me.Gbx_Nitrogeno.Controls.Add(Me.txt_FacConv)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Label31)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_PAtomico)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Label30)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Gbx_Regresion)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Lb_GasFactor)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_GasFactor)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Lb_GasNormailidad)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_GasNormalidad)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Lb_GasPMuestra)
        Me.Gbx_Nitrogeno.Controls.Add(Me.Txt_GasPMuestra)
        Me.Gbx_Nitrogeno.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Nitrogeno.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Gbx_Nitrogeno.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_Nitrogeno.Name = "Gbx_Nitrogeno"
        Me.Gbx_Nitrogeno.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_Nitrogeno.TabIndex = 17
        Me.Gbx_Nitrogeno.TabStop = False
        Me.Gbx_Nitrogeno.Visible = False
        '
        'Txt_NTitrisol
        '
        Me.Txt_NTitrisol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NTitrisol.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NTitrisol.Location = New System.Drawing.Point(444, 64)
        Me.Txt_NTitrisol.Name = "Txt_NTitrisol"
        Me.Txt_NTitrisol.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NTitrisol.TabIndex = 25
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label68.Location = New System.Drawing.Point(316, 64)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(104, 18)
        Me.Label68.TabIndex = 24
        Me.Label68.Text = "N°Lote Titrisol 1N"
        '
        'Txt_Chequeo
        '
        Me.Txt_Chequeo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Chequeo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Chequeo.Location = New System.Drawing.Point(444, 40)
        Me.Txt_Chequeo.Name = "Txt_Chequeo"
        Me.Txt_Chequeo.Size = New System.Drawing.Size(72, 20)
        Me.Txt_Chequeo.TabIndex = 23
        '
        'Lnk_ChekeoNorm
        '
        Me.Lnk_ChekeoNorm.Location = New System.Drawing.Point(316, 40)
        Me.Lnk_ChekeoNorm.Name = "Lnk_ChekeoNorm"
        Me.Lnk_ChekeoNorm.Size = New System.Drawing.Size(112, 16)
        Me.Lnk_ChekeoNorm.TabIndex = 22
        Me.Lnk_ChekeoNorm.TabStop = True
        Me.Lnk_ChekeoNorm.Text = "Chequeo Normalidad"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label32.Location = New System.Drawing.Point(56, 88)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(152, 18)
        Me.Label32.TabIndex = 21
        Me.Label32.Text = "Factor conversión"
        '
        'txt_FacConv
        '
        Me.txt_FacConv.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.txt_FacConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_FacConv.Enabled = False
        Me.txt_FacConv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FacConv.Location = New System.Drawing.Point(224, 88)
        Me.txt_FacConv.Name = "txt_FacConv"
        Me.txt_FacConv.Size = New System.Drawing.Size(72, 20)
        Me.txt_FacConv.TabIndex = 20
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label31.Location = New System.Drawing.Point(56, 64)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(152, 18)
        Me.Label31.TabIndex = 19
        Me.Label31.Text = "Peso Atomico (N)"
        '
        'Txt_PAtomico
        '
        Me.Txt_PAtomico.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Txt_PAtomico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PAtomico.Enabled = False
        Me.Txt_PAtomico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PAtomico.Location = New System.Drawing.Point(224, 64)
        Me.Txt_PAtomico.Name = "Txt_PAtomico"
        Me.Txt_PAtomico.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PAtomico.TabIndex = 18
        '
        'Label30
        '
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(8, 16)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(100, 16)
        Me.Label30.TabIndex = 17
        Me.Label30.Text = "Datos de Entrada :"
        '
        'Lb_GasFactor
        '
        Me.Lb_GasFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_GasFactor.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Lb_GasFactor.Location = New System.Drawing.Point(8, 144)
        Me.Lb_GasFactor.Name = "Lb_GasFactor"
        Me.Lb_GasFactor.Size = New System.Drawing.Size(120, 18)
        Me.Lb_GasFactor.TabIndex = 16
        Me.Lb_GasFactor.Text = "Factor Cálculo"
        '
        'Txt_GasFactor
        '
        Me.Txt_GasFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_GasFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GasFactor.Location = New System.Drawing.Point(224, 144)
        Me.Txt_GasFactor.Name = "Txt_GasFactor"
        Me.Txt_GasFactor.Size = New System.Drawing.Size(72, 20)
        Me.Txt_GasFactor.TabIndex = 15
        '
        'Lb_GasNormailidad
        '
        Me.Lb_GasNormailidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_GasNormailidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_GasNormailidad.Location = New System.Drawing.Point(56, 40)
        Me.Lb_GasNormailidad.Name = "Lb_GasNormailidad"
        Me.Lb_GasNormailidad.Size = New System.Drawing.Size(152, 18)
        Me.Lb_GasNormailidad.TabIndex = 12
        Me.Lb_GasNormailidad.Text = "Normalidad H2SO4"
        '
        'Txt_GasNormalidad
        '
        Me.Txt_GasNormalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_GasNormalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GasNormalidad.Location = New System.Drawing.Point(224, 40)
        Me.Txt_GasNormalidad.Name = "Txt_GasNormalidad"
        Me.Txt_GasNormalidad.Size = New System.Drawing.Size(72, 20)
        Me.Txt_GasNormalidad.TabIndex = 11
        '
        'Lb_GasPMuestra
        '
        Me.Lb_GasPMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_GasPMuestra.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_GasPMuestra.Location = New System.Drawing.Point(56, 112)
        Me.Lb_GasPMuestra.Name = "Lb_GasPMuestra"
        Me.Lb_GasPMuestra.Size = New System.Drawing.Size(152, 18)
        Me.Lb_GasPMuestra.TabIndex = 10
        '
        'Txt_GasPMuestra
        '
        Me.Txt_GasPMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_GasPMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_GasPMuestra.Location = New System.Drawing.Point(224, 112)
        Me.Txt_GasPMuestra.Name = "Txt_GasPMuestra"
        Me.Txt_GasPMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_GasPMuestra.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox4.Controls.Add(Me.Rdb_Todos)
        Me.GroupBox4.Controls.Add(Me.Rdb_Ocacional)
        Me.GroupBox4.Controls.Add(Me.Rdb_Frecuentes)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 594)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(528, 37)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Rdb_Todos
        '
        Me.Rdb_Todos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Todos.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Todos.Location = New System.Drawing.Point(407, 11)
        Me.Rdb_Todos.Name = "Rdb_Todos"
        Me.Rdb_Todos.Size = New System.Drawing.Size(104, 24)
        Me.Rdb_Todos.TabIndex = 2
        Me.Rdb_Todos.Text = "Todos"
        '
        'Rdb_Ocacional
        '
        Me.Rdb_Ocacional.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Ocacional.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Ocacional.Location = New System.Drawing.Point(207, 11)
        Me.Rdb_Ocacional.Name = "Rdb_Ocacional"
        Me.Rdb_Ocacional.Size = New System.Drawing.Size(104, 24)
        Me.Rdb_Ocacional.TabIndex = 1
        Me.Rdb_Ocacional.Text = "Ocacional"
        '
        'Rdb_Frecuentes
        '
        Me.Rdb_Frecuentes.Checked = True
        Me.Rdb_Frecuentes.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rdb_Frecuentes.ForeColor = System.Drawing.Color.Black
        Me.Rdb_Frecuentes.Location = New System.Drawing.Point(11, 11)
        Me.Rdb_Frecuentes.Name = "Rdb_Frecuentes"
        Me.Rdb_Frecuentes.Size = New System.Drawing.Size(104, 24)
        Me.Rdb_Frecuentes.TabIndex = 0
        Me.Rdb_Frecuentes.TabStop = True
        Me.Rdb_Frecuentes.Text = "Frecuentes"
        '
        'Gbx_Lectura
        '
        Me.Gbx_Lectura.Controls.Add(Me.Txt_LectFactDilucion)
        Me.Gbx_Lectura.Controls.Add(Me.Label29)
        Me.Gbx_Lectura.Controls.Add(Me.Label25)
        Me.Gbx_Lectura.Controls.Add(Me.Label24)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_1ºDilucion)
        Me.Gbx_Lectura.Controls.Add(Me.Label23)
        Me.Gbx_Lectura.Controls.Add(Me.Label22)
        Me.Gbx_Lectura.Controls.Add(Me.Label21)
        Me.Gbx_Lectura.Controls.Add(Me.Label20)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_Lect2ºFactor)
        Me.Gbx_Lectura.Controls.Add(Me.Lb_VolAforoAlicuota)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_LectVolAforoAlic)
        Me.Gbx_Lectura.Controls.Add(Me.Label19)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_LectVolAlicuota)
        Me.Gbx_Lectura.Controls.Add(Me.Lb_LectFactor)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_LectAforo)
        Me.Gbx_Lectura.Controls.Add(Me.Lb_LectBlanco)
        Me.Gbx_Lectura.Controls.Add(Me.Txt_LectPesoMuestra)
        Me.Gbx_Lectura.Controls.Add(Me.Gbx_NNH4)
        Me.Gbx_Lectura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Lectura.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Gbx_Lectura.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_Lectura.Name = "Gbx_Lectura"
        Me.Gbx_Lectura.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_Lectura.TabIndex = 4
        Me.Gbx_Lectura.TabStop = False
        Me.Gbx_Lectura.Visible = False
        '
        'Txt_LectFactDilucion
        '
        Me.Txt_LectFactDilucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_LectFactDilucion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LectFactDilucion.Location = New System.Drawing.Point(224, 224)
        Me.Txt_LectFactDilucion.Name = "Txt_LectFactDilucion"
        Me.Txt_LectFactDilucion.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LectFactDilucion.TabIndex = 28
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(8, 224)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(100, 18)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "Factor Dilución"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label25.Location = New System.Drawing.Point(88, 120)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(176, 16)
        Me.Label25.TabIndex = 24
        Me.Label25.Text = "(Vol.Aforo Alicuota / Vol.Alicuota)"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label24.Location = New System.Drawing.Point(8, 120)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 23
        Me.Label24.Text = "2º dilución "
        '
        'Txt_1ºDilucion
        '
        Me.Txt_1ºDilucion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_1ºDilucion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_1ºDilucion.Location = New System.Drawing.Point(224, 88)
        Me.Txt_1ºDilucion.Name = "Txt_1ºDilucion"
        Me.Txt_1ºDilucion.Size = New System.Drawing.Size(72, 20)
        Me.Txt_1ºDilucion.TabIndex = 22
        Me.Txt_1ºDilucion.Text = "50"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label23.Location = New System.Drawing.Point(56, 88)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(152, 18)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "1º dilución "
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(88, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 16)
        Me.Label22.TabIndex = 20
        Me.Label22.Text = "(Vol.Aforo / P.Muestra)"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(8, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 19
        Me.Label21.Text = "1º dilución "
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label20.Location = New System.Drawing.Point(56, 192)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(152, 18)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = " 2º dilución"
        '
        'Txt_Lect2ºFactor
        '
        Me.Txt_Lect2ºFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Lect2ºFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Lect2ºFactor.Location = New System.Drawing.Point(224, 192)
        Me.Txt_Lect2ºFactor.Name = "Txt_Lect2ºFactor"
        Me.Txt_Lect2ºFactor.Size = New System.Drawing.Size(72, 20)
        Me.Txt_Lect2ºFactor.TabIndex = 17
        '
        'Lb_VolAforoAlicuota
        '
        Me.Lb_VolAforoAlicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_VolAforoAlicuota.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_VolAforoAlicuota.Location = New System.Drawing.Point(56, 168)
        Me.Lb_VolAforoAlicuota.Name = "Lb_VolAforoAlicuota"
        Me.Lb_VolAforoAlicuota.Size = New System.Drawing.Size(152, 18)
        Me.Lb_VolAforoAlicuota.TabIndex = 16
        Me.Lb_VolAforoAlicuota.Text = "Volumen Aforo Alicuota (ml)"
        '
        'Txt_LectVolAforoAlic
        '
        Me.Txt_LectVolAforoAlic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_LectVolAforoAlic.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LectVolAforoAlic.Location = New System.Drawing.Point(224, 168)
        Me.Txt_LectVolAforoAlic.Name = "Txt_LectVolAforoAlic"
        Me.Txt_LectVolAforoAlic.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LectVolAforoAlic.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label19.Location = New System.Drawing.Point(56, 144)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(152, 18)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "Volumen Alicuota (ml)"
        '
        'Txt_LectVolAlicuota
        '
        Me.Txt_LectVolAlicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_LectVolAlicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LectVolAlicuota.Location = New System.Drawing.Point(224, 144)
        Me.Txt_LectVolAlicuota.Name = "Txt_LectVolAlicuota"
        Me.Txt_LectVolAlicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LectVolAlicuota.TabIndex = 13
        '
        'Lb_LectFactor
        '
        Me.Lb_LectFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_LectFactor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_LectFactor.Location = New System.Drawing.Point(56, 64)
        Me.Lb_LectFactor.Name = "Lb_LectFactor"
        Me.Lb_LectFactor.Size = New System.Drawing.Size(152, 18)
        Me.Lb_LectFactor.TabIndex = 12
        Me.Lb_LectFactor.Text = "Volumen Aforo (ml)"
        '
        'Txt_LectAforo
        '
        Me.Txt_LectAforo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_LectAforo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LectAforo.Location = New System.Drawing.Point(224, 64)
        Me.Txt_LectAforo.Name = "Txt_LectAforo"
        Me.Txt_LectAforo.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LectAforo.TabIndex = 11
        Me.Txt_LectAforo.Text = "50"
        '
        'Lb_LectBlanco
        '
        Me.Lb_LectBlanco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_LectBlanco.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_LectBlanco.Location = New System.Drawing.Point(56, 40)
        Me.Lb_LectBlanco.Name = "Lb_LectBlanco"
        Me.Lb_LectBlanco.Size = New System.Drawing.Size(152, 18)
        Me.Lb_LectBlanco.TabIndex = 10
        Me.Lb_LectBlanco.Text = "Peso Muestra (g)"
        '
        'Txt_LectPesoMuestra
        '
        Me.Txt_LectPesoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_LectPesoMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_LectPesoMuestra.Location = New System.Drawing.Point(224, 40)
        Me.Txt_LectPesoMuestra.Name = "Txt_LectPesoMuestra"
        Me.Txt_LectPesoMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_LectPesoMuestra.TabIndex = 9
        Me.Txt_LectPesoMuestra.Text = "1"
        '
        'Gbx_NNH4
        '
        Me.Gbx_NNH4.Controls.Add(Me.Lb_NNH4Factor)
        Me.Gbx_NNH4.Controls.Add(Me.Txt_NNH4Factor)
        Me.Gbx_NNH4.Controls.Add(Me.Label17)
        Me.Gbx_NNH4.Controls.Add(Me.Txt_NNH4Alicuota)
        Me.Gbx_NNH4.Controls.Add(Me.Label16)
        Me.Gbx_NNH4.Controls.Add(Me.Txt_NNH4VolumenAforo)
        Me.Gbx_NNH4.Controls.Add(Me.Label15)
        Me.Gbx_NNH4.Controls.Add(Me.Txt_NNH4Normalidad)
        Me.Gbx_NNH4.Controls.Add(Me.Label14)
        Me.Gbx_NNH4.Controls.Add(Me.Txt_NNH4PesoMuestra)
        Me.Gbx_NNH4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_NNH4.Location = New System.Drawing.Point(600, 288)
        Me.Gbx_NNH4.Name = "Gbx_NNH4"
        Me.Gbx_NNH4.Size = New System.Drawing.Size(600, 208)
        Me.Gbx_NNH4.TabIndex = 16
        Me.Gbx_NNH4.TabStop = False
        Me.Gbx_NNH4.Text = "NNH4"
        Me.Gbx_NNH4.Visible = False
        '
        'Lb_NNH4Factor
        '
        Me.Lb_NNH4Factor.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NNH4Factor.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_NNH4Factor.Location = New System.Drawing.Point(8, 152)
        Me.Lb_NNH4Factor.Name = "Lb_NNH4Factor"
        Me.Lb_NNH4Factor.Size = New System.Drawing.Size(184, 23)
        Me.Lb_NNH4Factor.TabIndex = 18
        Me.Lb_NNH4Factor.Text = "Factor"
        '
        'Txt_NNH4Factor
        '
        Me.Txt_NNH4Factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNH4Factor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNH4Factor.Location = New System.Drawing.Point(200, 152)
        Me.Txt_NNH4Factor.Name = "Txt_NNH4Factor"
        Me.Txt_NNH4Factor.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNH4Factor.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label17.Location = New System.Drawing.Point(8, 120)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(184, 23)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Alicuota(ml)"
        '
        'Txt_NNH4Alicuota
        '
        Me.Txt_NNH4Alicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNH4Alicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNH4Alicuota.Location = New System.Drawing.Point(200, 120)
        Me.Txt_NNH4Alicuota.Name = "Txt_NNH4Alicuota"
        Me.Txt_NNH4Alicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNH4Alicuota.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label16.Location = New System.Drawing.Point(8, 88)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(184, 23)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Volumen Aforo(ml)"
        '
        'Txt_NNH4VolumenAforo
        '
        Me.Txt_NNH4VolumenAforo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNH4VolumenAforo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNH4VolumenAforo.Location = New System.Drawing.Point(200, 88)
        Me.Txt_NNH4VolumenAforo.Name = "Txt_NNH4VolumenAforo"
        Me.Txt_NNH4VolumenAforo.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNH4VolumenAforo.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label15.Location = New System.Drawing.Point(8, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(184, 23)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Normalidad H2SO4"
        '
        'Txt_NNH4Normalidad
        '
        Me.Txt_NNH4Normalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNH4Normalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNH4Normalidad.Location = New System.Drawing.Point(200, 56)
        Me.Txt_NNH4Normalidad.Name = "Txt_NNH4Normalidad"
        Me.Txt_NNH4Normalidad.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNH4Normalidad.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label14.Location = New System.Drawing.Point(8, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(184, 23)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Peso Muestra(g)"
        '
        'Txt_NNH4PesoMuestra
        '
        Me.Txt_NNH4PesoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNH4PesoMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNH4PesoMuestra.Location = New System.Drawing.Point(200, 24)
        Me.Txt_NNH4PesoMuestra.Name = "Txt_NNH4PesoMuestra"
        Me.Txt_NNH4PesoMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNH4PesoMuestra.TabIndex = 9
        '
        'Dtg_Elementos
        '
        Me.Dtg_Elementos.CaptionVisible = False
        Me.Dtg_Elementos.DataMember = ""
        Me.Dtg_Elementos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Elementos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Elementos.Location = New System.Drawing.Point(544, 12)
        Me.Dtg_Elementos.Name = "Dtg_Elementos"
        Me.Dtg_Elementos.Size = New System.Drawing.Size(240, 652)
        Me.Dtg_Elementos.TabIndex = 5
        Me.Dtg_Elementos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Elementos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ELEMENTOS_DIGITA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "ELE_MARCA"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 9
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Elemento"
        Me.DataGridTextBoxColumn2.MappingName = "ELE_NOMBRE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 108
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Simbolo"
        Me.DataGridTextBoxColumn3.MappingName = "ELE_SIMBOLO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 45
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Unid"
        Me.DataGridTextBoxColumn4.MappingName = "ELE_UNIDAD"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 53
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Codigo"
        Me.DataGridTextBoxColumn5.MappingName = "ELE_CODIGO"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Form"
        Me.DataGridTextBoxColumn6.MappingName = "ELE_CAL_FORMULA"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 30
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Fac"
        Me.DataGridTextBoxColumn16.MappingName = "ELE_COMENTARIO1"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 10
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Met"
        Me.DataGridTextBoxColumn17.MappingName = "ELE_COMENTARIO"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 10
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Fact"
        Me.DataGridTextBoxColumn14.MappingName = "ELE_COMENTARIO2"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 5
        '
        'Dtg_Digitado
        '
        Me.Dtg_Digitado.CaptionVisible = False
        Me.Dtg_Digitado.DataMember = ""
        Me.Dtg_Digitado.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Digitado.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_Digitado.Name = "Dtg_Digitado"
        Me.Dtg_Digitado.Size = New System.Drawing.Size(470, 916)
        Me.Dtg_Digitado.TabIndex = 6
        Me.Dtg_Digitado.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.Dtg_Digitado.Visible = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.Dtg_DigitaNNO3
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn28})
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "DIGITACION"
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Nº Lab"
        Me.DataGridTextBoxColumn7.MappingName = "OT_NLABX"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Peso m"
        Me.DataGridTextBoxColumn8.MappingName = "MASA_MUE"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Vol ext"
        Me.DataGridTextBoxColumn9.MappingName = "VOLUMEN_AFO"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 50
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Vol ali"
        Me.DataGridTextBoxColumn10.MappingName = "VOLUMEN_ALI"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Aforo ali"
        Me.DataGridTextBoxColumn19.MappingName = "AFORO_ALI"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 50
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Factor"
        Me.DataGridTextBoxColumn20.MappingName = "FACTOR"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 50
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Lectura"
        Me.DataGridTextBoxColumn21.MappingName = "LECTURA"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 55
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Resultado"
        Me.DataGridTextBoxColumn22.MappingName = "RESULTADO"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 85
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 75
        '
        'Dtg_DigitaNNO3
        '
        Me.Dtg_DigitaNNO3.CaptionVisible = False
        Me.Dtg_DigitaNNO3.DataMember = ""
        Me.Dtg_DigitaNNO3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_DigitaNNO3.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_DigitaNNO3.Name = "Dtg_DigitaNNO3"
        Me.Dtg_DigitaNNO3.Size = New System.Drawing.Size(470, 916)
        Me.Dtg_DigitaNNO3.TabIndex = 5
        Me.Dtg_DigitaNNO3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.Dtg_DigitaNNO3.Visible = False
        '
        'Bt_Graba
        '
        Me.Bt_Graba.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Graba.Enabled = False
        Me.Bt_Graba.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Graba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Graba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Graba.Location = New System.Drawing.Point(431, 673)
        Me.Bt_Graba.Name = "Bt_Graba"
        Me.Bt_Graba.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Graba.TabIndex = 30
        Me.Bt_Graba.Text = "Grabar"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Bt_Imprime
        '
        Me.Bt_Imprime.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Imprime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imprime.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Bt_Imprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Imprime.Location = New System.Drawing.Point(522, 673)
        Me.Bt_Imprime.Name = "Bt_Imprime"
        Me.Bt_Imprime.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Imprime.TabIndex = 31
        Me.Bt_Imprime.Text = "Imprimir"
        Me.Bt_Imprime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Imprime.UseVisualStyleBackColor = False
        '
        'Bt_Limpiar
        '
        Me.Bt_Limpiar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Limpiar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Limpiar.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Bt_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Limpiar.Location = New System.Drawing.Point(611, 673)
        Me.Bt_Limpiar.Name = "Bt_Limpiar"
        Me.Bt_Limpiar.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Limpiar.TabIndex = 32
        Me.Bt_Limpiar.Text = "Limpiar"
        Me.Bt_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Limpiar.UseVisualStyleBackColor = False
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Salir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Bt_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Salir.Location = New System.Drawing.Point(701, 673)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 33
        Me.Bt_Salir.Text = "Salir"
        Me.Bt_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Salir.UseVisualStyleBackColor = False
        '
        'TxtLectura
        '
        Me.TxtLectura.Location = New System.Drawing.Point(838, 56)
        Me.TxtLectura.Name = "TxtLectura"
        Me.TxtLectura.Size = New System.Drawing.Size(100, 20)
        Me.TxtLectura.TabIndex = 15
        Me.TxtLectura.Visible = False
        '
        'TxtNumLab
        '
        Me.TxtNumLab.Location = New System.Drawing.Point(966, 56)
        Me.TxtNumLab.Name = "TxtNumLab"
        Me.TxtNumLab.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumLab.TabIndex = 12
        Me.TxtNumLab.Visible = False
        '
        'Txt_LecRes
        '
        Me.Txt_LecRes.Location = New System.Drawing.Point(1086, 56)
        Me.Txt_LecRes.Name = "Txt_LecRes"
        Me.Txt_LecRes.Size = New System.Drawing.Size(100, 20)
        Me.Txt_LecRes.TabIndex = 8
        Me.Txt_LecRes.Visible = False
        '
        'Dtg_Elenf
        '
        Me.Dtg_Elenf.CaptionVisible = False
        Me.Dtg_Elenf.DataMember = ""
        Me.Dtg_Elenf.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Elenf.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_Elenf.Name = "Dtg_Elenf"
        Me.Dtg_Elenf.Size = New System.Drawing.Size(354, 916)
        Me.Dtg_Elenf.TabIndex = 14
        Me.Dtg_Elenf.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.Dtg_Elenf.Visible = False
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.Dtg_DigitaVolumetrico
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle3.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "DIGITACION"
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Nº Lab"
        Me.DataGridTextBoxColumn11.MappingName = "OT_NLABX"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Peso m"
        Me.DataGridTextBoxColumn12.MappingName = "MASA_MUE"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Factor"
        Me.DataGridTextBoxColumn13.MappingName = "FACTOR"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 50
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Gasto(ml)"
        Me.DataGridTextBoxColumn23.MappingName = "LECTURA"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 55
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Resultado"
        Me.DataGridTextBoxColumn24.MappingName = "RESULTADO"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 85
        '
        'Dtg_DigitaVolumetrico
        '
        Me.Dtg_DigitaVolumetrico.CaptionVisible = False
        Me.Dtg_DigitaVolumetrico.DataMember = ""
        Me.Dtg_DigitaVolumetrico.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_DigitaVolumetrico.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_DigitaVolumetrico.Name = "Dtg_DigitaVolumetrico"
        Me.Dtg_DigitaVolumetrico.Size = New System.Drawing.Size(333, 916)
        Me.Dtg_DigitaVolumetrico.TabIndex = 54
        Me.Dtg_DigitaVolumetrico.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        Me.Dtg_DigitaVolumetrico.Visible = False
        '
        'GBX_pyb1
        '
        Me.GBX_pyb1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GBX_pyb1.Controls.Add(Me.BtCalculaCoe)
        Me.GBX_pyb1.Controls.Add(Me.LabResultado)
        Me.GBX_pyb1.Controls.Add(Me.Label18)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram10)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem10)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram9)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem9)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem7)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem8)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram8)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram7)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem5)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem6)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram6)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram5)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem3)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem4)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram4)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram3)
        Me.GBX_pyb1.Controls.Add(Me.Label27)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem1)
        Me.GBX_pyb1.Controls.Add(Me.Label28)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_elem2)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram2)
        Me.GBX_pyb1.Controls.Add(Me.txt_pyb_tram1)
        Me.GBX_pyb1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBX_pyb1.Location = New System.Drawing.Point(8, 637)
        Me.GBX_pyb1.Name = "GBX_pyb1"
        Me.GBX_pyb1.Size = New System.Drawing.Size(369, 311)
        Me.GBX_pyb1.TabIndex = 40
        Me.GBX_pyb1.TabStop = False
        Me.GBX_pyb1.Text = "Curva Standard"
        Me.GBX_pyb1.Visible = False
        '
        'BtCalculaCoe
        '
        Me.BtCalculaCoe.BackColor = System.Drawing.Color.Transparent
        Me.BtCalculaCoe.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCalculaCoe.Image = Global.LabSys.My.Resources.Resources.calculator
        Me.BtCalculaCoe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtCalculaCoe.Location = New System.Drawing.Point(304, 277)
        Me.BtCalculaCoe.Name = "BtCalculaCoe"
        Me.BtCalculaCoe.Size = New System.Drawing.Size(50, 25)
        Me.BtCalculaCoe.TabIndex = 62
        Me.BtCalculaCoe.Text = "Cal"
        Me.BtCalculaCoe.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtCalculaCoe.UseVisualStyleBackColor = False
        '
        'LabResultado
        '
        Me.LabResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabResultado.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabResultado.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabResultado.Location = New System.Drawing.Point(168, 281)
        Me.LabResultado.Name = "LabResultado"
        Me.LabResultado.Size = New System.Drawing.Size(72, 16)
        Me.LabResultado.TabIndex = 61
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(8, 280)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 16)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "R"
        '
        'txt_pyb_tram10
        '
        Me.txt_pyb_tram10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram10.Location = New System.Drawing.Point(168, 256)
        Me.txt_pyb_tram10.Name = "txt_pyb_tram10"
        Me.txt_pyb_tram10.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram10.TabIndex = 59
        '
        'txt_pyb_elem10
        '
        Me.txt_pyb_elem10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem10.Location = New System.Drawing.Point(8, 255)
        Me.txt_pyb_elem10.Name = "txt_pyb_elem10"
        Me.txt_pyb_elem10.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem10.TabIndex = 58
        Me.txt_pyb_elem10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_tram9
        '
        Me.txt_pyb_tram9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram9.Location = New System.Drawing.Point(168, 232)
        Me.txt_pyb_tram9.Name = "txt_pyb_tram9"
        Me.txt_pyb_tram9.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram9.TabIndex = 57
        '
        'txt_pyb_elem9
        '
        Me.txt_pyb_elem9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem9.Location = New System.Drawing.Point(8, 231)
        Me.txt_pyb_elem9.Name = "txt_pyb_elem9"
        Me.txt_pyb_elem9.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem9.TabIndex = 56
        Me.txt_pyb_elem9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_elem7
        '
        Me.txt_pyb_elem7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem7.Location = New System.Drawing.Point(8, 183)
        Me.txt_pyb_elem7.Name = "txt_pyb_elem7"
        Me.txt_pyb_elem7.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem7.TabIndex = 55
        Me.txt_pyb_elem7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_elem8
        '
        Me.txt_pyb_elem8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem8.Location = New System.Drawing.Point(8, 207)
        Me.txt_pyb_elem8.Name = "txt_pyb_elem8"
        Me.txt_pyb_elem8.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem8.TabIndex = 54
        Me.txt_pyb_elem8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_tram8
        '
        Me.txt_pyb_tram8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram8.Location = New System.Drawing.Point(168, 208)
        Me.txt_pyb_tram8.Name = "txt_pyb_tram8"
        Me.txt_pyb_tram8.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram8.TabIndex = 53
        '
        'txt_pyb_tram7
        '
        Me.txt_pyb_tram7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram7.Location = New System.Drawing.Point(168, 184)
        Me.txt_pyb_tram7.Name = "txt_pyb_tram7"
        Me.txt_pyb_tram7.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram7.TabIndex = 52
        '
        'txt_pyb_elem5
        '
        Me.txt_pyb_elem5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem5.Location = New System.Drawing.Point(8, 135)
        Me.txt_pyb_elem5.Name = "txt_pyb_elem5"
        Me.txt_pyb_elem5.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem5.TabIndex = 51
        Me.txt_pyb_elem5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_elem6
        '
        Me.txt_pyb_elem6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem6.Location = New System.Drawing.Point(8, 159)
        Me.txt_pyb_elem6.Name = "txt_pyb_elem6"
        Me.txt_pyb_elem6.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem6.TabIndex = 50
        Me.txt_pyb_elem6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_tram6
        '
        Me.txt_pyb_tram6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram6.Location = New System.Drawing.Point(168, 160)
        Me.txt_pyb_tram6.Name = "txt_pyb_tram6"
        Me.txt_pyb_tram6.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram6.TabIndex = 49
        '
        'txt_pyb_tram5
        '
        Me.txt_pyb_tram5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram5.Location = New System.Drawing.Point(168, 136)
        Me.txt_pyb_tram5.Name = "txt_pyb_tram5"
        Me.txt_pyb_tram5.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram5.TabIndex = 48
        '
        'txt_pyb_elem3
        '
        Me.txt_pyb_elem3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem3.Location = New System.Drawing.Point(8, 87)
        Me.txt_pyb_elem3.Name = "txt_pyb_elem3"
        Me.txt_pyb_elem3.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem3.TabIndex = 47
        Me.txt_pyb_elem3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_elem4
        '
        Me.txt_pyb_elem4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem4.Location = New System.Drawing.Point(8, 111)
        Me.txt_pyb_elem4.Name = "txt_pyb_elem4"
        Me.txt_pyb_elem4.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem4.TabIndex = 46
        Me.txt_pyb_elem4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_tram4
        '
        Me.txt_pyb_tram4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram4.Location = New System.Drawing.Point(168, 112)
        Me.txt_pyb_tram4.Name = "txt_pyb_tram4"
        Me.txt_pyb_tram4.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram4.TabIndex = 45
        '
        'txt_pyb_tram3
        '
        Me.txt_pyb_tram3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram3.Location = New System.Drawing.Point(168, 88)
        Me.txt_pyb_tram3.Name = "txt_pyb_tram3"
        Me.txt_pyb_tram3.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram3.TabIndex = 44
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(160, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(104, 16)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "Tramitancia (%)"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt_pyb_elem1
        '
        Me.txt_pyb_elem1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem1.Location = New System.Drawing.Point(8, 39)
        Me.txt_pyb_elem1.Name = "txt_pyb_elem1"
        Me.txt_pyb_elem1.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem1.TabIndex = 41
        Me.txt_pyb_elem1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(8, 15)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(104, 16)
        Me.Label28.TabIndex = 42
        Me.Label28.Text = "Elemento (ppm)"
        '
        'txt_pyb_elem2
        '
        Me.txt_pyb_elem2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_elem2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_elem2.Location = New System.Drawing.Point(8, 63)
        Me.txt_pyb_elem2.Name = "txt_pyb_elem2"
        Me.txt_pyb_elem2.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_elem2.TabIndex = 39
        Me.txt_pyb_elem2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_pyb_tram2
        '
        Me.txt_pyb_tram2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram2.Location = New System.Drawing.Point(168, 64)
        Me.txt_pyb_tram2.Name = "txt_pyb_tram2"
        Me.txt_pyb_tram2.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram2.TabIndex = 37
        '
        'txt_pyb_tram1
        '
        Me.txt_pyb_tram1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_pyb_tram1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pyb_tram1.Location = New System.Drawing.Point(168, 40)
        Me.txt_pyb_tram1.Name = "txt_pyb_tram1"
        Me.txt_pyb_tram1.Size = New System.Drawing.Size(72, 20)
        Me.txt_pyb_tram1.TabIndex = 35
        '
        'Lb_Metodo2
        '
        Me.Lb_Metodo2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Metodo2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_Metodo2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Lb_Metodo2.Location = New System.Drawing.Point(80, 66)
        Me.Lb_Metodo2.Name = "Lb_Metodo2"
        Me.Lb_Metodo2.Size = New System.Drawing.Size(431, 16)
        Me.Lb_Metodo2.TabIndex = 1
        '
        'Lb_Metodo
        '
        Me.Lb_Metodo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Metodo.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_Metodo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Lb_Metodo.Location = New System.Drawing.Point(80, 42)
        Me.Lb_Metodo.Name = "Lb_Metodo"
        Me.Lb_Metodo.Size = New System.Drawing.Size(431, 16)
        Me.Lb_Metodo.TabIndex = 0
        '
        'Gbx_Comentarios
        '
        Me.Gbx_Comentarios.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gbx_Comentarios.Controls.Add(Me.Lb_Metodologia)
        Me.Gbx_Comentarios.Controls.Add(Me.Lb_TitCalculo)
        Me.Gbx_Comentarios.Controls.Add(Me.Lb_Metodo)
        Me.Gbx_Comentarios.Controls.Add(Me.Lb_Metodo2)
        Me.Gbx_Comentarios.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Comentarios.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Gbx_Comentarios.Location = New System.Drawing.Point(8, 228)
        Me.Gbx_Comentarios.Name = "Gbx_Comentarios"
        Me.Gbx_Comentarios.Size = New System.Drawing.Size(528, 90)
        Me.Gbx_Comentarios.TabIndex = 43
        Me.Gbx_Comentarios.TabStop = False
        '
        'Lb_Metodologia
        '
        Me.Lb_Metodologia.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Metodologia.Location = New System.Drawing.Point(8, 18)
        Me.Lb_Metodologia.Name = "Lb_Metodologia"
        Me.Lb_Metodologia.Size = New System.Drawing.Size(192, 16)
        Me.Lb_Metodologia.TabIndex = 43
        '
        'Lb_TitCalculo
        '
        Me.Lb_TitCalculo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_TitCalculo.Location = New System.Drawing.Point(8, 42)
        Me.Lb_TitCalculo.Name = "Lb_TitCalculo"
        Me.Lb_TitCalculo.Size = New System.Drawing.Size(64, 16)
        Me.Lb_TitCalculo.TabIndex = 42
        '
        'Gbx_Potenciometrico
        '
        Me.Gbx_Potenciometrico.Controls.Add(Me.TextBox2)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Lnk_PotChequeo)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Label34)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Txt_PotFactor)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Lb_PotFactConv)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Txt_PotFactConv)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Lb_PotPesoAtomico)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Txt_PotPesoAtomico)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Lb_PotPesoMuestra)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Txt_PotPesoMuestra)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Lb_PotNormailidad)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Txt_PotNormalidad)
        Me.Gbx_Potenciometrico.Controls.Add(Me.Label33)
        Me.Gbx_Potenciometrico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_Potenciometrico.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Gbx_Potenciometrico.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_Potenciometrico.Name = "Gbx_Potenciometrico"
        Me.Gbx_Potenciometrico.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_Potenciometrico.TabIndex = 44
        Me.Gbx_Potenciometrico.TabStop = False
        Me.Gbx_Potenciometrico.Visible = False
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(444, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(72, 20)
        Me.TextBox2.TabIndex = 31
        '
        'Lnk_PotChequeo
        '
        Me.Lnk_PotChequeo.Location = New System.Drawing.Point(316, 40)
        Me.Lnk_PotChequeo.Name = "Lnk_PotChequeo"
        Me.Lnk_PotChequeo.Size = New System.Drawing.Size(112, 16)
        Me.Lnk_PotChequeo.TabIndex = 30
        Me.Lnk_PotChequeo.TabStop = True
        Me.Lnk_PotChequeo.Text = "Chequeo Normalidad"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label34.Location = New System.Drawing.Point(8, 144)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(128, 18)
        Me.Label34.TabIndex = 29
        Me.Label34.Text = "Factor Cálculo"
        '
        'Txt_PotFactor
        '
        Me.Txt_PotFactor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotFactor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotFactor.Location = New System.Drawing.Point(224, 144)
        Me.Txt_PotFactor.Name = "Txt_PotFactor"
        Me.Txt_PotFactor.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotFactor.TabIndex = 28
        '
        'Lb_PotFactConv
        '
        Me.Lb_PotFactConv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PotFactConv.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_PotFactConv.Location = New System.Drawing.Point(56, 88)
        Me.Lb_PotFactConv.Name = "Lb_PotFactConv"
        Me.Lb_PotFactConv.Size = New System.Drawing.Size(152, 18)
        Me.Lb_PotFactConv.TabIndex = 27
        Me.Lb_PotFactConv.Text = "Factor Conversión"
        '
        'Txt_PotFactConv
        '
        Me.Txt_PotFactConv.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Txt_PotFactConv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotFactConv.Enabled = False
        Me.Txt_PotFactConv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotFactConv.Location = New System.Drawing.Point(224, 88)
        Me.Txt_PotFactConv.Name = "Txt_PotFactConv"
        Me.Txt_PotFactConv.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotFactConv.TabIndex = 26
        Me.Txt_PotFactConv.Text = "1000"
        '
        'Lb_PotPesoAtomico
        '
        Me.Lb_PotPesoAtomico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PotPesoAtomico.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_PotPesoAtomico.Location = New System.Drawing.Point(56, 64)
        Me.Lb_PotPesoAtomico.Name = "Lb_PotPesoAtomico"
        Me.Lb_PotPesoAtomico.Size = New System.Drawing.Size(152, 18)
        Me.Lb_PotPesoAtomico.TabIndex = 25
        Me.Lb_PotPesoAtomico.Text = "Peso Atomico (Cl)"
        '
        'Txt_PotPesoAtomico
        '
        Me.Txt_PotPesoAtomico.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Txt_PotPesoAtomico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotPesoAtomico.Enabled = False
        Me.Txt_PotPesoAtomico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotPesoAtomico.Location = New System.Drawing.Point(224, 64)
        Me.Txt_PotPesoAtomico.Name = "Txt_PotPesoAtomico"
        Me.Txt_PotPesoAtomico.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotPesoAtomico.TabIndex = 24
        '
        'Lb_PotPesoMuestra
        '
        Me.Lb_PotPesoMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PotPesoMuestra.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_PotPesoMuestra.Location = New System.Drawing.Point(56, 112)
        Me.Lb_PotPesoMuestra.Name = "Lb_PotPesoMuestra"
        Me.Lb_PotPesoMuestra.Size = New System.Drawing.Size(152, 18)
        Me.Lb_PotPesoMuestra.TabIndex = 23
        Me.Lb_PotPesoMuestra.Text = "Peso Muestra (g)"
        '
        'Txt_PotPesoMuestra
        '
        Me.Txt_PotPesoMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotPesoMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotPesoMuestra.Location = New System.Drawing.Point(224, 112)
        Me.Txt_PotPesoMuestra.Name = "Txt_PotPesoMuestra"
        Me.Txt_PotPesoMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotPesoMuestra.TabIndex = 22
        '
        'Lb_PotNormailidad
        '
        Me.Lb_PotNormailidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_PotNormailidad.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Lb_PotNormailidad.Location = New System.Drawing.Point(56, 40)
        Me.Lb_PotNormailidad.Name = "Lb_PotNormailidad"
        Me.Lb_PotNormailidad.Size = New System.Drawing.Size(152, 18)
        Me.Lb_PotNormailidad.TabIndex = 20
        Me.Lb_PotNormailidad.Text = "Normalidad AgNO3"
        '
        'Txt_PotNormalidad
        '
        Me.Txt_PotNormalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNormalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNormalidad.Location = New System.Drawing.Point(224, 40)
        Me.Txt_PotNormalidad.Name = "Txt_PotNormalidad"
        Me.Txt_PotNormalidad.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNormalidad.TabIndex = 19
        '
        'Label33
        '
        Me.Label33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label33.Location = New System.Drawing.Point(8, 16)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(100, 16)
        Me.Label33.TabIndex = 18
        Me.Label33.Text = "Datos de Entrada :"
        '
        'Gbx_PotNNH4
        '
        Me.Gbx_PotNNH4.Controls.Add(Me.Label47)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4Alicuota)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label46)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4VAforo)
        Me.Gbx_PotNNH4.Controls.Add(Me.TextBox1)
        Me.Gbx_PotNNH4.Controls.Add(Me.LinkLabel1)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label35)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4FacConvercion)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label36)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4PesoAtomico)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label37)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label38)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4Factor)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label39)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4Normalidad)
        Me.Gbx_PotNNH4.Controls.Add(Me.Label40)
        Me.Gbx_PotNNH4.Controls.Add(Me.Txt_PotNNH4PMuestra)
        Me.Gbx_PotNNH4.Controls.Add(Me.GroupBox5)
        Me.Gbx_PotNNH4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_PotNNH4.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Gbx_PotNNH4.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_PotNNH4.Name = "Gbx_PotNNH4"
        Me.Gbx_PotNNH4.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_PotNNH4.TabIndex = 45
        Me.Gbx_PotNNH4.TabStop = False
        Me.Gbx_PotNNH4.Visible = False
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label47.Location = New System.Drawing.Point(56, 136)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(152, 18)
        Me.Label47.TabIndex = 27
        Me.Label47.Text = "Alicuota Tomada (ml)"
        '
        'Txt_PotNNH4Alicuota
        '
        Me.Txt_PotNNH4Alicuota.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4Alicuota.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4Alicuota.Location = New System.Drawing.Point(224, 136)
        Me.Txt_PotNNH4Alicuota.Name = "Txt_PotNNH4Alicuota"
        Me.Txt_PotNNH4Alicuota.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4Alicuota.TabIndex = 26
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label46.Location = New System.Drawing.Point(56, 160)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(152, 18)
        Me.Label46.TabIndex = 25
        Me.Label46.Text = "Volumen Aforo(ml)"
        '
        'Txt_PotNNH4VAforo
        '
        Me.Txt_PotNNH4VAforo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4VAforo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4VAforo.Location = New System.Drawing.Point(224, 160)
        Me.Txt_PotNNH4VAforo.Name = "Txt_PotNNH4VAforo"
        Me.Txt_PotNNH4VAforo.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4VAforo.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(444, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(72, 20)
        Me.TextBox1.TabIndex = 23
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Location = New System.Drawing.Point(316, 40)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(112, 16)
        Me.LinkLabel1.TabIndex = 22
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Chequeo Normalidad"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label35.Location = New System.Drawing.Point(56, 88)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(152, 18)
        Me.Label35.TabIndex = 21
        Me.Label35.Text = "Factor conversión"
        '
        'Txt_PotNNH4FacConvercion
        '
        Me.Txt_PotNNH4FacConvercion.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Txt_PotNNH4FacConvercion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4FacConvercion.Enabled = False
        Me.Txt_PotNNH4FacConvercion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4FacConvercion.Location = New System.Drawing.Point(224, 88)
        Me.Txt_PotNNH4FacConvercion.Name = "Txt_PotNNH4FacConvercion"
        Me.Txt_PotNNH4FacConvercion.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4FacConvercion.TabIndex = 20
        Me.Txt_PotNNH4FacConvercion.Text = "1000"
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label36.Location = New System.Drawing.Point(56, 64)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(152, 18)
        Me.Label36.TabIndex = 19
        Me.Label36.Text = "Peso Atomico (N)"
        '
        'Txt_PotNNH4PesoAtomico
        '
        Me.Txt_PotNNH4PesoAtomico.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Txt_PotNNH4PesoAtomico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4PesoAtomico.Enabled = False
        Me.Txt_PotNNH4PesoAtomico.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4PesoAtomico.Location = New System.Drawing.Point(224, 64)
        Me.Txt_PotNNH4PesoAtomico.Name = "Txt_PotNNH4PesoAtomico"
        Me.Txt_PotNNH4PesoAtomico.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4PesoAtomico.TabIndex = 18
        '
        'Label37
        '
        Me.Label37.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label37.Location = New System.Drawing.Point(8, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(100, 16)
        Me.Label37.TabIndex = 17
        Me.Label37.Text = "Datos de Entrada :"
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label38.Location = New System.Drawing.Point(8, 200)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(104, 18)
        Me.Label38.TabIndex = 16
        Me.Label38.Text = "Factor Cálculo"
        '
        'Txt_PotNNH4Factor
        '
        Me.Txt_PotNNH4Factor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4Factor.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4Factor.Location = New System.Drawing.Point(224, 200)
        Me.Txt_PotNNH4Factor.Name = "Txt_PotNNH4Factor"
        Me.Txt_PotNNH4Factor.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4Factor.TabIndex = 15
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label39.Location = New System.Drawing.Point(56, 40)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(152, 18)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "Normalidad H2SO4"
        '
        'Txt_PotNNH4Normalidad
        '
        Me.Txt_PotNNH4Normalidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4Normalidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4Normalidad.Location = New System.Drawing.Point(224, 40)
        Me.Txt_PotNNH4Normalidad.Name = "Txt_PotNNH4Normalidad"
        Me.Txt_PotNNH4Normalidad.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4Normalidad.TabIndex = 11
        '
        'Label40
        '
        Me.Label40.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label40.Location = New System.Drawing.Point(56, 112)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(152, 18)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "Peso Muestra (g)"
        '
        'Txt_PotNNH4PMuestra
        '
        Me.Txt_PotNNH4PMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_PotNNH4PMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PotNNH4PMuestra.Location = New System.Drawing.Point(224, 112)
        Me.Txt_PotNNH4PMuestra.Name = "Txt_PotNNH4PMuestra"
        Me.Txt_PotNNH4PMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_PotNNH4PMuestra.TabIndex = 9
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TextBox8)
        Me.GroupBox5.Controls.Add(Me.TextBox9)
        Me.GroupBox5.Controls.Add(Me.TextBox10)
        Me.GroupBox5.Controls.Add(Me.TextBox11)
        Me.GroupBox5.Controls.Add(Me.Label41)
        Me.GroupBox5.Controls.Add(Me.Label42)
        Me.GroupBox5.Controls.Add(Me.Label43)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.TextBox12)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(600, 288)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(600, 184)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Regresión"
        Me.GroupBox5.Visible = False
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(200, 152)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(72, 20)
        Me.TextBox8.TabIndex = 15
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(200, 120)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(72, 20)
        Me.TextBox9.TabIndex = 14
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(200, 88)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(72, 20)
        Me.TextBox10.TabIndex = 13
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(200, 56)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(72, 20)
        Me.TextBox11.TabIndex = 12
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label41.Location = New System.Drawing.Point(8, 152)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(184, 23)
        Me.Label41.TabIndex = 11
        Me.Label41.Text = "Factor"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label42.Location = New System.Drawing.Point(8, 88)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(184, 23)
        Me.Label42.TabIndex = 10
        Me.Label42.Text = "Volumen Alicuota(ml)"
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label43.Location = New System.Drawing.Point(8, 120)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(184, 23)
        Me.Label43.TabIndex = 9
        Me.Label43.Text = "Volumen Aforo Alicuota(ml)"
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label44.Location = New System.Drawing.Point(8, 24)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(184, 23)
        Me.Label44.TabIndex = 8
        Me.Label44.Text = "Peso Muestra(gr)"
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(200, 24)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(72, 20)
        Me.TextBox12.TabIndex = 7
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label45.Location = New System.Drawing.Point(8, 56)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(184, 23)
        Me.Label45.TabIndex = 0
        Me.Label45.Text = "Volumen Aforo(ml)"
        '
        'Gbx_Clorofila
        '
        Me.Gbx_Clorofila.Controls.Add(Me.Bt_ClorofilaAceptar)
        Me.Gbx_Clorofila.Controls.Add(Me.DataGrid1)
        Me.Gbx_Clorofila.Controls.Add(Me.Txt_CloAbs2)
        Me.Gbx_Clorofila.Controls.Add(Me.Label52)
        Me.Gbx_Clorofila.Controls.Add(Me.Txt_CloFac2)
        Me.Gbx_Clorofila.Controls.Add(Me.Label51)
        Me.Gbx_Clorofila.Controls.Add(Me.Txt_CloAbs1)
        Me.Gbx_Clorofila.Controls.Add(Me.Label50)
        Me.Gbx_Clorofila.Controls.Add(Me.Txt_CloFact1)
        Me.Gbx_Clorofila.Controls.Add(Me.Label49)
        Me.Gbx_Clorofila.Controls.Add(Me.Label48)
        Me.Gbx_Clorofila.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_Clorofila.Name = "Gbx_Clorofila"
        Me.Gbx_Clorofila.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_Clorofila.TabIndex = 46
        Me.Gbx_Clorofila.TabStop = False
        Me.Gbx_Clorofila.Visible = False
        '
        'Bt_ClorofilaAceptar
        '
        Me.Bt_ClorofilaAceptar.Location = New System.Drawing.Point(224, 152)
        Me.Bt_ClorofilaAceptar.Name = "Bt_ClorofilaAceptar"
        Me.Bt_ClorofilaAceptar.Size = New System.Drawing.Size(64, 23)
        Me.Bt_ClorofilaAceptar.TabIndex = 28
        Me.Bt_ClorofilaAceptar.Text = "Aceptar"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(316, 39)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(200, 216)
        Me.DataGrid1.TabIndex = 27
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn18})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "DIGITACION"
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Nº Laboratorio"
        Me.DataGridTextBoxColumn15.MappingName = "OT_NLABX"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 85
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Resultado"
        Me.DataGridTextBoxColumn18.MappingName = "RESULTADO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'Txt_CloAbs2
        '
        Me.Txt_CloAbs2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CloAbs2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CloAbs2.Location = New System.Drawing.Point(224, 112)
        Me.Txt_CloAbs2.Name = "Txt_CloAbs2"
        Me.Txt_CloAbs2.Size = New System.Drawing.Size(72, 20)
        Me.Txt_CloAbs2.TabIndex = 26
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label52.Location = New System.Drawing.Point(56, 112)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(152, 18)
        Me.Label52.TabIndex = 25
        Me.Label52.Text = "Absorvancia(Long.Onda645)"
        '
        'Txt_CloFac2
        '
        Me.Txt_CloFac2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CloFac2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CloFac2.Location = New System.Drawing.Point(224, 88)
        Me.Txt_CloFac2.Name = "Txt_CloFac2"
        Me.Txt_CloFac2.Size = New System.Drawing.Size(72, 20)
        Me.Txt_CloFac2.TabIndex = 24
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label51.Location = New System.Drawing.Point(56, 88)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(152, 18)
        Me.Label51.TabIndex = 23
        Me.Label51.Text = "Factor Calculo"
        '
        'Txt_CloAbs1
        '
        Me.Txt_CloAbs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CloAbs1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CloAbs1.Location = New System.Drawing.Point(224, 64)
        Me.Txt_CloAbs1.Name = "Txt_CloAbs1"
        Me.Txt_CloAbs1.Size = New System.Drawing.Size(72, 20)
        Me.Txt_CloAbs1.TabIndex = 22
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label50.Location = New System.Drawing.Point(56, 64)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(152, 18)
        Me.Label50.TabIndex = 21
        Me.Label50.Text = "Absorvancia(Long.Onda 663)"
        '
        'Txt_CloFact1
        '
        Me.Txt_CloFact1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CloFact1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CloFact1.Location = New System.Drawing.Point(224, 40)
        Me.Txt_CloFact1.Name = "Txt_CloFact1"
        Me.Txt_CloFact1.Size = New System.Drawing.Size(72, 20)
        Me.Txt_CloFact1.TabIndex = 20
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label49.Location = New System.Drawing.Point(56, 40)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(152, 18)
        Me.Label49.TabIndex = 19
        Me.Label49.Text = "Factor Cálculo"
        '
        'Label48
        '
        Me.Label48.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label48.Location = New System.Drawing.Point(8, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(100, 16)
        Me.Label48.TabIndex = 18
        Me.Label48.Text = "Datos de Entrada :"
        '
        'Txt_MasaMue
        '
        Me.Txt_MasaMue.Location = New System.Drawing.Point(806, 256)
        Me.Txt_MasaMue.Name = "Txt_MasaMue"
        Me.Txt_MasaMue.Size = New System.Drawing.Size(100, 20)
        Me.Txt_MasaMue.TabIndex = 47
        Me.Txt_MasaMue.Visible = False
        '
        'Txt_VolExt
        '
        Me.Txt_VolExt.Location = New System.Drawing.Point(926, 256)
        Me.Txt_VolExt.Name = "Txt_VolExt"
        Me.Txt_VolExt.Size = New System.Drawing.Size(100, 20)
        Me.Txt_VolExt.TabIndex = 48
        Me.Txt_VolExt.Visible = False
        '
        'Txt_VolAli
        '
        Me.Txt_VolAli.Location = New System.Drawing.Point(1046, 256)
        Me.Txt_VolAli.Name = "Txt_VolAli"
        Me.Txt_VolAli.Size = New System.Drawing.Size(100, 20)
        Me.Txt_VolAli.TabIndex = 49
        Me.Txt_VolAli.Visible = False
        '
        'Txt_AfoAli
        '
        Me.Txt_AfoAli.Location = New System.Drawing.Point(806, 296)
        Me.Txt_AfoAli.Name = "Txt_AfoAli"
        Me.Txt_AfoAli.Size = New System.Drawing.Size(100, 20)
        Me.Txt_AfoAli.TabIndex = 50
        Me.Txt_AfoAli.Visible = False
        '
        'Txt_Factor
        '
        Me.Txt_Factor.Location = New System.Drawing.Point(926, 296)
        Me.Txt_Factor.Name = "Txt_Factor"
        Me.Txt_Factor.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Factor.TabIndex = 51
        Me.Txt_Factor.Visible = False
        '
        'Txt_LecturaVolumetrico
        '
        Me.Txt_LecturaVolumetrico.Location = New System.Drawing.Point(1118, 432)
        Me.Txt_LecturaVolumetrico.Name = "Txt_LecturaVolumetrico"
        Me.Txt_LecturaVolumetrico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_LecturaVolumetrico.TabIndex = 55
        Me.Txt_LecturaVolumetrico.Visible = False
        '
        'Txt_NNO3FacDil
        '
        Me.Txt_NNO3FacDil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3FacDil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3FacDil.Location = New System.Drawing.Point(224, 224)
        Me.Txt_NNO3FacDil.Name = "Txt_NNO3FacDil"
        Me.Txt_NNO3FacDil.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3FacDil.TabIndex = 28
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(8, 224)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(100, 18)
        Me.Label26.TabIndex = 27
        Me.Label26.Text = "Factor Dilución"
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(88, 120)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(176, 16)
        Me.Label53.TabIndex = 24
        Me.Label53.Text = "(Vol.Aforo Alicuota / Vol.Alicuota)"
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label54.Location = New System.Drawing.Point(8, 120)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(64, 16)
        Me.Label54.TabIndex = 23
        Me.Label54.Text = "2º dilución "
        '
        'Txt_NNO3FacExt
        '
        Me.Txt_NNO3FacExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3FacExt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3FacExt.Location = New System.Drawing.Point(224, 88)
        Me.Txt_NNO3FacExt.Name = "Txt_NNO3FacExt"
        Me.Txt_NNO3FacExt.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3FacExt.TabIndex = 22
        Me.Txt_NNO3FacExt.Text = "50"
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label55.Location = New System.Drawing.Point(56, 88)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(152, 18)
        Me.Label55.TabIndex = 21
        Me.Label55.Text = "Factor extracción "
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label56.Location = New System.Drawing.Point(88, 16)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(128, 16)
        Me.Label56.TabIndex = 20
        Me.Label56.Text = "(Vol.ext / M.muestra)"
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label57.Location = New System.Drawing.Point(8, 16)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(64, 16)
        Me.Label57.TabIndex = 19
        Me.Label57.Text = "1º dilución "
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label58.Location = New System.Drawing.Point(56, 192)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(152, 18)
        Me.Label58.TabIndex = 18
        Me.Label58.Text = " 2º dilución"
        '
        'Txt_NNO3Fac2dil
        '
        Me.Txt_NNO3Fac2dil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3Fac2dil.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3Fac2dil.Location = New System.Drawing.Point(224, 192)
        Me.Txt_NNO3Fac2dil.Name = "Txt_NNO3Fac2dil"
        Me.Txt_NNO3Fac2dil.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3Fac2dil.TabIndex = 17
        '
        'Label59
        '
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label59.Location = New System.Drawing.Point(56, 168)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(152, 18)
        Me.Label59.TabIndex = 16
        Me.Label59.Text = "Volumen Aforo Alicuota (ml)"
        '
        'Txt_NNO3VolAfoAli
        '
        Me.Txt_NNO3VolAfoAli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3VolAfoAli.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3VolAfoAli.Location = New System.Drawing.Point(224, 168)
        Me.Txt_NNO3VolAfoAli.Name = "Txt_NNO3VolAfoAli"
        Me.Txt_NNO3VolAfoAli.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3VolAfoAli.TabIndex = 15
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label60.Location = New System.Drawing.Point(56, 144)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(152, 18)
        Me.Label60.TabIndex = 14
        Me.Label60.Text = "Volumen Alicuota (ml)"
        '
        'Txt_NNO3VolAli
        '
        Me.Txt_NNO3VolAli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3VolAli.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3VolAli.Location = New System.Drawing.Point(224, 144)
        Me.Txt_NNO3VolAli.Name = "Txt_NNO3VolAli"
        Me.Txt_NNO3VolAli.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3VolAli.TabIndex = 13
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label61.Location = New System.Drawing.Point(56, 64)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(152, 18)
        Me.Label61.TabIndex = 12
        Me.Label61.Text = "Volumen extractante (ml)"
        '
        'Txt_NNO3VolExt
        '
        Me.Txt_NNO3VolExt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3VolExt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3VolExt.Location = New System.Drawing.Point(224, 64)
        Me.Txt_NNO3VolExt.Name = "Txt_NNO3VolExt"
        Me.Txt_NNO3VolExt.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3VolExt.TabIndex = 11
        Me.Txt_NNO3VolExt.Text = "50"
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label62.Location = New System.Drawing.Point(56, 40)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(152, 18)
        Me.Label62.TabIndex = 10
        Me.Label62.Text = "Peso muestra (g)"
        '
        'Txt_NNO3MasaMuestra
        '
        Me.Txt_NNO3MasaMuestra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NNO3MasaMuestra.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NNO3MasaMuestra.Location = New System.Drawing.Point(224, 40)
        Me.Txt_NNO3MasaMuestra.Name = "Txt_NNO3MasaMuestra"
        Me.Txt_NNO3MasaMuestra.Size = New System.Drawing.Size(72, 20)
        Me.Txt_NNO3MasaMuestra.TabIndex = 9
        Me.Txt_NNO3MasaMuestra.Text = "1"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label63)
        Me.GroupBox6.Controls.Add(Me.TextBox15)
        Me.GroupBox6.Controls.Add(Me.Label64)
        Me.GroupBox6.Controls.Add(Me.TextBox16)
        Me.GroupBox6.Controls.Add(Me.Label65)
        Me.GroupBox6.Controls.Add(Me.TextBox17)
        Me.GroupBox6.Controls.Add(Me.Label66)
        Me.GroupBox6.Controls.Add(Me.TextBox18)
        Me.GroupBox6.Controls.Add(Me.Label67)
        Me.GroupBox6.Controls.Add(Me.TextBox19)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.GroupBox6.Location = New System.Drawing.Point(600, 288)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(600, 208)
        Me.GroupBox6.TabIndex = 16
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "NNH4"
        Me.GroupBox6.Visible = False
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label63.Location = New System.Drawing.Point(8, 152)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(184, 23)
        Me.Label63.TabIndex = 18
        Me.Label63.Text = "Factor"
        '
        'TextBox15
        '
        Me.TextBox15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(200, 152)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(72, 20)
        Me.TextBox15.TabIndex = 17
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label64.Location = New System.Drawing.Point(8, 120)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(184, 23)
        Me.Label64.TabIndex = 16
        Me.Label64.Text = "Alicuota(ml)"
        '
        'TextBox16
        '
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(200, 120)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(72, 20)
        Me.TextBox16.TabIndex = 15
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label65.Location = New System.Drawing.Point(8, 88)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(184, 23)
        Me.Label65.TabIndex = 14
        Me.Label65.Text = "Volumen Aforo(ml)"
        '
        'TextBox17
        '
        Me.TextBox17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox17.Location = New System.Drawing.Point(200, 88)
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Size = New System.Drawing.Size(72, 20)
        Me.TextBox17.TabIndex = 13
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label66.Location = New System.Drawing.Point(8, 56)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(184, 23)
        Me.Label66.TabIndex = 12
        Me.Label66.Text = "Normalidad H2SO4"
        '
        'TextBox18
        '
        Me.TextBox18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox18.Location = New System.Drawing.Point(200, 56)
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Size = New System.Drawing.Size(72, 20)
        Me.TextBox18.TabIndex = 11
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label67.Location = New System.Drawing.Point(8, 24)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(184, 23)
        Me.Label67.TabIndex = 10
        Me.Label67.Text = "Peso Muestra(g)"
        '
        'TextBox19
        '
        Me.TextBox19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(200, 24)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(72, 20)
        Me.TextBox19.TabIndex = 9
        '
        'Gbx_NNO3
        '
        Me.Gbx_NNO3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3FacDil)
        Me.Gbx_NNO3.Controls.Add(Me.Label26)
        Me.Gbx_NNO3.Controls.Add(Me.Label53)
        Me.Gbx_NNO3.Controls.Add(Me.Label54)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3FacExt)
        Me.Gbx_NNO3.Controls.Add(Me.Label55)
        Me.Gbx_NNO3.Controls.Add(Me.Label56)
        Me.Gbx_NNO3.Controls.Add(Me.Label57)
        Me.Gbx_NNO3.Controls.Add(Me.Label58)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3Fac2dil)
        Me.Gbx_NNO3.Controls.Add(Me.Label59)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3VolAfoAli)
        Me.Gbx_NNO3.Controls.Add(Me.Label60)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3VolAli)
        Me.Gbx_NNO3.Controls.Add(Me.Label61)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3VolExt)
        Me.Gbx_NNO3.Controls.Add(Me.Label62)
        Me.Gbx_NNO3.Controls.Add(Me.Txt_NNO3MasaMuestra)
        Me.Gbx_NNO3.Controls.Add(Me.GroupBox6)
        Me.Gbx_NNO3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbx_NNO3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Gbx_NNO3.Location = New System.Drawing.Point(8, 324)
        Me.Gbx_NNO3.Name = "Gbx_NNO3"
        Me.Gbx_NNO3.Size = New System.Drawing.Size(528, 264)
        Me.Gbx_NNO3.TabIndex = 52
        Me.Gbx_NNO3.TabStop = False
        Me.Gbx_NNO3.Visible = False
        '
        'Txt_FactorVolumetrico
        '
        Me.Txt_FactorVolumetrico.Location = New System.Drawing.Point(1118, 464)
        Me.Txt_FactorVolumetrico.Name = "Txt_FactorVolumetrico"
        Me.Txt_FactorVolumetrico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_FactorVolumetrico.TabIndex = 56
        Me.Txt_FactorVolumetrico.Visible = False
        '
        'TxtFactor
        '
        Me.TxtFactor.Location = New System.Drawing.Point(838, 96)
        Me.TxtFactor.Name = "TxtFactor"
        Me.TxtFactor.Size = New System.Drawing.Size(100, 20)
        Me.TxtFactor.TabIndex = 57
        Me.TxtFactor.Visible = False
        '
        'Dtg_Lectura
        '
        Me.Dtg_Lectura.CaptionVisible = False
        Me.Dtg_Lectura.DataMember = ""
        Me.Dtg_Lectura.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Lectura.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_Lectura.Name = "Dtg_Lectura"
        Me.Dtg_Lectura.Size = New System.Drawing.Size(352, 916)
        Me.Dtg_Lectura.TabIndex = 58
        Me.Dtg_Lectura.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        Me.Dtg_Lectura.Visible = False
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.Dtg_Lectura
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "DIGITACION"
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "N°Lab"
        Me.DataGridTextBoxColumn25.MappingName = "OT_NLABX"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 60
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Resultado"
        Me.DataGridTextBoxColumn26.MappingName = "RESULTADO"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 85
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Observación"
        Me.DataGridTextBoxColumn27.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 170
        '
        'Txt_LectResultado
        '
        Me.Txt_LectResultado.Location = New System.Drawing.Point(830, 376)
        Me.Txt_LectResultado.Name = "Txt_LectResultado"
        Me.Txt_LectResultado.Size = New System.Drawing.Size(100, 20)
        Me.Txt_LectResultado.TabIndex = 59
        Me.Txt_LectResultado.Visible = False
        '
        'Txt_LectObservacion
        '
        Me.Txt_LectObservacion.Location = New System.Drawing.Point(870, 464)
        Me.Txt_LectObservacion.Name = "Txt_LectObservacion"
        Me.Txt_LectObservacion.Size = New System.Drawing.Size(100, 20)
        Me.Txt_LectObservacion.TabIndex = 60
        Me.Txt_LectObservacion.Visible = False
        '
        'Dtg_Potenciometrico
        '
        Me.Dtg_Potenciometrico.CaptionVisible = False
        Me.Dtg_Potenciometrico.DataMember = ""
        Me.Dtg_Potenciometrico.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Potenciometrico.Location = New System.Drawing.Point(790, 12)
        Me.Dtg_Potenciometrico.Name = "Dtg_Potenciometrico"
        Me.Dtg_Potenciometrico.Size = New System.Drawing.Size(333, 916)
        Me.Dtg_Potenciometrico.TabIndex = 61
        Me.Dtg_Potenciometrico.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        Me.Dtg_Potenciometrico.Visible = False
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.Dtg_Potenciometrico
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33})
        Me.DataGridTableStyle6.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "DIGITACION"
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "N° Lab"
        Me.DataGridTextBoxColumn29.MappingName = "OT_NLABX"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 60
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Peso m"
        Me.DataGridTextBoxColumn30.MappingName = "MASA_MUE"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 50
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Factor"
        Me.DataGridTextBoxColumn31.MappingName = "FACTOR"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 50
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Gasto"
        Me.DataGridTextBoxColumn32.MappingName = "LECTURA"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 55
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "Resultado"
        Me.DataGridTextBoxColumn33.MappingName = "RESULTADO"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 85
        '
        'Txt_LectPotenciometrico
        '
        Me.Txt_LectPotenciometrico.Location = New System.Drawing.Point(854, 568)
        Me.Txt_LectPotenciometrico.Name = "Txt_LectPotenciometrico"
        Me.Txt_LectPotenciometrico.Size = New System.Drawing.Size(100, 20)
        Me.Txt_LectPotenciometrico.TabIndex = 62
        Me.Txt_LectPotenciometrico.Visible = False
        '
        'F_DigitaResultado
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Txt_LectPotenciometrico)
        Me.Controls.Add(Me.TxtLectura)
        Me.Controls.Add(Me.Txt_LectObservacion)
        Me.Controls.Add(Me.Txt_LectResultado)
        Me.Controls.Add(Me.TxtFactor)
        Me.Controls.Add(Me.Txt_FactorVolumetrico)
        Me.Controls.Add(Me.Txt_LecturaVolumetrico)
        Me.Controls.Add(Me.Txt_Factor)
        Me.Controls.Add(Me.Txt_AfoAli)
        Me.Controls.Add(Me.Txt_VolAli)
        Me.Controls.Add(Me.Txt_VolExt)
        Me.Controls.Add(Me.Txt_MasaMue)
        Me.Controls.Add(Me.Gbx_Comentarios)
        Me.Controls.Add(Me.Txt_LecRes)
        Me.Controls.Add(Me.TxtNumLab)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Gbx_Lectura)
        Me.Controls.Add(Me.Bt_Limpiar)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Gbx_Nitrogeno)
        Me.Controls.Add(Me.Gbx_PotNNH4)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dtg_Elementos)
        Me.Controls.Add(Me.GBX_pyb1)
        Me.Controls.Add(Me.Gbx_NNO3)
        Me.Controls.Add(Me.Gbx_Potenciometrico)
        Me.Controls.Add(Me.Gbx_Clorofila)
        Me.Controls.Add(Me.Dtg_Lectura)
        Me.Controls.Add(Me.Dtg_Elenf)
        Me.Controls.Add(Me.Dtg_DigitaNNO3)
        Me.Controls.Add(Me.Dtg_Digitado)
        Me.Controls.Add(Me.Dtg_Potenciometrico)
        Me.Controls.Add(Me.Dtg_DigitaVolumetrico)
        Me.Name = "F_DigitaResultado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DigitaResultado"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Gbx_Regresion.ResumeLayout(False)
        Me.Gbx_Regresion.PerformLayout()
        Me.Gbx_Nitrogeno.ResumeLayout(False)
        Me.Gbx_Nitrogeno.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Gbx_Lectura.ResumeLayout(False)
        Me.Gbx_Lectura.PerformLayout()
        Me.Gbx_NNH4.ResumeLayout(False)
        Me.Gbx_NNH4.PerformLayout()
        CType(Me.Dtg_Elementos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_Digitado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_DigitaNNO3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_Elenf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_DigitaVolumetrico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBX_pyb1.ResumeLayout(False)
        Me.GBX_pyb1.PerformLayout()
        Me.Gbx_Comentarios.ResumeLayout(False)
        Me.Gbx_Potenciometrico.ResumeLayout(False)
        Me.Gbx_Potenciometrico.PerformLayout()
        Me.Gbx_PotNNH4.ResumeLayout(False)
        Me.Gbx_PotNNH4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Gbx_Clorofila.ResumeLayout(False)
        Me.Gbx_Clorofila.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Gbx_NNO3.ResumeLayout(False)
        Me.Gbx_NNO3.PerformLayout()
        CType(Me.Dtg_Lectura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_Potenciometrico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub DigitaResultado_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TipAna As String
        Cjto_Tablas1.Tables("DIGITACION").Clear()
        Cjto_Tablas1.Tables("ELEMENTOS_DIGITA").Clear()
        Call Anti_Elimina_Lineas()
        Dim Test1 As DbManager = New DbManager("ELEMENTOS_DIGITA", Conexion1)
        Dim query1 As String = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_COMENTARIO2,ELE_COMENTARIO1,ELE_COMENTARIO,ELE_CAL_FORMULA,ELE_FRECUENCIA from ELEMENTO WHERE TMU_CODIGO=" & CodAna & "  ORDER BY ELE_PRIORIDAD"
        Test1.Selecccionar(Cjto_Tablas1, query1)
        AddCellFormattingColumnStyles(Me.Dtg_Digitado, New FormatCellEventHandler(AddressOf FormatGridCells))
        Call Carga_Grilla_El()
        If CodAna = 1000 Then
            TipAna = "Foliar"
        ElseIf CodAna = 2000 Then
            TipAna = "Tejido"
        ElseIf CodAna = 3000 Then
            TipAna = "Agua"
        ElseIf CodAna = 4000 Then
            TipAna = "Suelo"
        ElseIf CodAna = 5000 Then
            TipAna = "Fert.Quimicos"
        ElseIf CodAna = 6000 Then
            TipAna = "Fert.Organicos"
        ElseIf CodAna = 7000 Then
            TipAna = "Fitopatología"
        ElseIf CodAna = 8000 Then
            TipAna = "Kit y Otros Elem"
        End If
        Lb_TipoAna.Text = TipAna
    End Sub

    Private Sub Anti_Elimina_Lineas()
        Dtg_Elementos.DataSource = Cjto_Tablas1.Tables("ELEMENTOS_DIGITA")
        Dtg_Digitado.DataSource = Cjto_Tablas1.Tables("DIGITACION")
        Dtg_Elenf.DataSource = Cjto_Tablas1.Tables("DIGITACION")
        Dtg_DigitaNNO3.DataSource = Cjto_Tablas1.Tables("DIGITACION")
        Dtg_DigitaVolumetrico.DataSource = Cjto_Tablas1.Tables("DIGITACION")
        Dtg_Lectura.DataSource = Cjto_Tablas1.Tables("DIGITACION")
        Dtg_Potenciometrico.DataSource = Cjto_Tablas1.Tables("DIGITACION")
    End Sub

    Function PesoAtomico(ByVal Matriz As Integer, ByVal CodEle As String)
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado

        With sp
            .Inicializar()
            .AgregarParametro("@CodAna", Matriz, SqlDbType.Int)
            .AgregarParametro("@EleCodigo", CodEle, SqlDbType.NVarChar)
            PesoAtomico = .EjecutarEscalar2("usp_PesoAtomico")
        End With
        Return PesoAtomico

    End Function

    Private Sub Dtg_Elementos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Elementos.DoubleClick
        Dim fila_e As Integer
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("ELEMENTOS_DIGITA").Rows
            Fila("ELE_MARCA") = ""
        Next
        fila_e = Dtg_Elementos.CurrentCell.RowNumber()
        Dtg_Elementos.Item(fila_e, 0) = "X"

        If Dtg_Elementos.Item(fila_e, 5) = "Colorimétrico" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            GBX_pyb1.Visible = True
            Gbx_Lectura.Visible = True
            Gbx_PotNNH4.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_NNO3.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Peso_Atomico = PesoAtomico(CodAna, Codigo)
            Gbx_Lectura.Text = CalFact
            Call Lista_Analista()
            Call Rescata_Curva()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "Potenciométrico" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = True
            GBX_pyb1.Visible = True
            Gbx_Lectura.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Peso_Atomico = PesoAtomico(CodAna, Codigo)
            Gbx_Lectura.Text = CalFact
            Label27.Text = "MV+"
            Call Lista_Analista()
            Call Rescata_Curva()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "EAA" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Lectura.Visible = True
            Gbx_Regresion.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Peso_Atomico = PesoAtomico(CodAna, Codigo)
            Gbx_Lectura.Text = CalFact
            Call Lista_Analista()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "VolumétricoNNH4" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_PotNNH4.Visible = True
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_PotNNH4.Text = CalFact
            Txt_PotNNH4PesoAtomico.Text = PesoAtomico(CodAna, Codigo)
            Peso_Atomico = PesoAtomico(CodAna, Codigo)
            Call Lista_Analista()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "Volumétrico" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = True
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Txt_PAtomico.Text = PesoAtomico(CodAna, Codigo)
            Peso_Atomico = PesoAtomico(CodAna, Codigo)
            If Unidad = "%" Or Unidad = "meq/l" Or Unidad = "mg/l" Or Unidad = "mg/kg" Or Unidad = "mg/100g" Or Unidad = "ppm" Then
                txt_FacConv.Text = 1000
                Lb_GasPMuestra.Text = "Peso Muestra (g)"
            End If
            Call Lista_Analista()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "TexturaBouyouco" Then
            Dtg_Lectura.Visible = False
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_Textura
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos.Item(fila_e, 5) = "TexturaBouyouco+Are" Then
            Dtg_Lectura.Visible = False
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_DigitaTextura
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "Dap_Terron" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New DigitaDensidad
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "RetHumedad" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_DigitaRetHum
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "GravimetricoSueGran" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_DigitaGranulometria
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "Dap_Cilindro" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_DapCilindrica
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "Nematodos" Then
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_Nematodos
            Form_A_A_Y.Show()
        ElseIf Dtg_Elementos(fila_e, 5) = "Arena_GyF" Then
            Dtg_Lectura.Visible = False
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Dtg_Lectura.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
            Dim Form_A_A_Y As New Frm_ArenaFyG
            Form_A_A_Y.Show()
        Else
            Dtg_Lectura.Visible = True
            Dtg_Digitado.Visible = False
            Dtg_DigitaNNO3.Visible = False
            Dtg_Elenf.Visible = False
            Dtg_DigitaVolumetrico.Visible = False
            Gbx_NNO3.Visible = False
            GBX_pyb1.Visible = False
            Gbx_Nitrogeno.Visible = False
            Gbx_PotNNH4.Visible = False
            Gbx_Lectura.Visible = False
            Gbx_Regresion.Visible = False
            Gbx_Potenciometrico.Visible = False
            Gbx_Clorofila.Visible = False
            Nombre = Dtg_Elementos.Item(fila_e, 1)
            simbolo = Dtg_Elementos.Item(fila_e, 2)
            Unidad = Dtg_Elementos.Item(fila_e, 3)
            Codigo = Dtg_Elementos.Item(fila_e, 4)
            Elemento = Dtg_Elementos.Item(fila_e, 4)
            Tit_Formula = Dtg_Elementos.Item(fila_e, 5)
            Metodo = Dtg_Elementos.Item(fila_e, 7)
            Metodo2 = Dtg_Elementos.Item(fila_e, 6)
            CalFact = Dtg_Elementos.Item(fila_e, 8)
            Gbx_Nitrogeno.Text = CalFact
            Call Lista_Analista()
        End If

saltito:
        Lb_Metodologia.Text = "Metodología :" & " " & Tit_Formula
        Lb_TitCalculo.Text = "Cálculo :"
        Gbx_Comentarios.Text = "Cálculo" & " " & simbolo & "(" & Unidad & ")"
        Lb_Metodo.Text = Metodo
        Lb_Metodo2.Text = Metodo2
        Bt_Graba.Enabled = False
    End Sub

#Region "Filtros Elementos"
    Private Sub Rdb_Frecuentes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Frecuentes.Click
        Dim Dat As DataRow
        Dim Filas_Seleccionadas As DataRow()
        Dim dv As DataView = New DataView(Cjto_Tablas1.Tables("ELEMENTOS_DIGITA"))
        dv.RowFilter = "ELE_FRECUENCIA='FR'"
        Dtg_Elementos.DataSource = dv
    End Sub


    Private Sub Rdb_Ocacional_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Ocacional.Click
        Dim Dat As DataRow
        Dim Filas_Seleccionadas As DataRow()
        Dim dv As DataView = New DataView(Cjto_Tablas1.Tables("ELEMENTOS_DIGITA"))
        dv.RowFilter = "ELE_FRECUENCIA='OC'"
        Dtg_Elementos.DataSource = dv

    End Sub

    Private Sub Rdb_Todos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rdb_Todos.Click
        Dim Dat As DataRow
        Dim Filas_Seleccionadas As DataRow()
        Dim dv As DataView = New DataView(Cjto_Tablas1.Tables("ELEMENTOS_DIGITA"))
        Dtg_Elementos.DataSource = dv
    End Sub
#End Region

#Region "Textbox Editores Grilla"
    Private Sub TxtLectura_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLectura.KeyPress
        Dim mycell As New DataGridCell
        Dim Lec_aux, Resultado As Double
        Dim query, gatos, Formato, CanDec, Resultado_Paso As String
        Dim Mypos, Fila_Promedio, Decimales As Integer
        Dim ARRIBA, BAJO1, BAJO2, BAJO3, RCoe, BsumalogYX, BsumalogY, BsumalogY2, BsumaX, BsumaX2, BsumalogXY, BsumaLogX, BsumaLogX2, BsumaY, BsumaY2 As Double
        Dim A1, A2, B1, B2, B3, B4 As Double
        Dim n As Integer
        Dim con As New SqlConnection(Conexion1)
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado

        gatos = "######" : CanDec = "000000"
        Formato = Mid(gatos, 1, EntRes) & "." & Mid(gatos, 1, DecRes)

        If Dtg_Digitado.Visible = True Then

            If (e.KeyChar.IsLetter(e.KeyChar)) Then
                MsgBox("Error en la Digitacion")
                TxtLectura.ResetText()
            Else

                If e.KeyChar = Chr(13) And TxtLectura.Text <> "" Then
                    TxtLectura.Text = TxtLectura.Text.Replace(".", ",")
                    TxtLectura.Text.Format(Formato)

                    Mypos = InStr(Dtg_Digitado.Item(Fila_Lectura, 0), "Blanco")
                    If Mypos > 0 Or InStr(Dtg_Digitado.Item(Fila_Lectura, 0), "Promedio") > 0 Then
                        Dtg_Digitado.Item(Fila_Lectura, 6) = TxtLectura.Text
                        Ultimo_Blanco = CDbl(TxtLectura.Text)
                    Else
                        Dtg_Digitado.Item(Fila_Lectura, 6) = TxtLectura.Text

                        If Tit_Formula = "EAA" Then
                            Resultado = Lectura_Blanco(CDbl(TxtLectura.Text), Ultimo_Blanco, Dtg_Digitado.Item(Fila_Lectura, 5))
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If
                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If

                        If Tit_Formula = "Colorimétrico" Then
                            BsumalogXY = sumalogXY(n)
                            BsumaLogX = sumalogX()
                            BsumaLogX2 = sumalogX2()
                            BsumaY = sumaY()
                            BsumaY2 = sumaY2()
                            Resultado = Regresion(BsumalogXY, BsumaLogX, BsumaLogX2, BsumaY, BsumaY2, n, CDbl(TxtLectura.Text), CDbl(Dtg_Digitado.Item(Fila_Lectura, 5)))
                            'Resultado = Round(Resultado, 2)
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If
                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If




                        If Tit_Formula = "Potenciométrico" Then
                            Resultado = Potenciometria(CDbl(Dtg_Potenciometrico.Item(Fila_Lectura, 2)), CDbl(Txt_LectPotenciometrico.Text), Ultimo_Blanco)
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If

                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If

                        If Tit_Formula = "VolumetricoNNH4" Then
                            Resultado = Gasto_Blanco_NNH4(CDbl(TxtLectura.Text), Ultimo_Blanco, Dtg_Digitado.Item(Fila_Lectura, 5))
                        End If


                        With sp
                            .Inicializar()
                            .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                            .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                            Mascara = .EjecutarEscalar("usp_RescataMascara")
                        End With

                        Dtg_Digitado.Item(Fila_Lectura, 7) = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))
                    End If
SaltoxPromedio:
                    Me.TxtLectura.Focus()
                    mycell.ColumnNumber = 6
                    mycell.RowNumber = Fila_Lectura + 1
                    Dtg_Digitado.CurrentCell = mycell

                End If
            End If

        End If

        If Dtg_DigitaNNO3.Visible = True Then
            If (e.KeyChar.IsLetter(e.KeyChar)) Then
                MsgBox("Error en la Digitacion")
                TxtLectura.ResetText()
            Else

                If e.KeyChar = Chr(13) And TxtLectura.Text <> "" Then
                    TxtLectura.Text = TxtLectura.Text.Replace(".", ",")
                    TxtLectura.Text.Format(Formato)

                    Mypos = InStr(Dtg_DigitaNNO3.Item(Fila_Lectura, 0), "Blanco")
                    If Mypos > 0 Or InStr(Dtg_DigitaNNO3.Item(Fila_Lectura, 0), "Promedio") > 0 Then
                        Dtg_DigitaNNO3.Item(Fila_Lectura, 6) = TxtLectura.Text
                        Ultimo_Blanco = CDbl(TxtLectura.Text)
                    Else
                        Dtg_DigitaNNO3.Item(Fila_Lectura, 6) = TxtLectura.Text

                        If Tit_Formula = "Volumétrico" Then
                            'Resultado = RegresionNNO3(NsumalogYX(n), NsumalogY, NsumalogY2, NsumaX, NsumaX2, n, CDbl(TxtLectura.Text), CDbl(Dtg_DigitaNNO3.Item(Fila_Lectura, 5)))
                            Resultado = Gasto_Blanco_Factor(CDbl(TxtLectura.Text), Ultimo_Blanco, CDbl(Dtg_DigitaNNO3.Item(Fila_Lectura, 5)))
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If

                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If

                        If Tit_Formula = "Potenciométrico" Then
                            Resultado = RegresionNNO3(NsumalogYX(n), NsumalogY, NsumalogY2, NsumaX, NsumaX2, n, CDbl(TxtLectura.Text), CDbl(Dtg_DigitaNNO3.Item(Fila_Lectura, 5)))
                            If CodAna = 6000 Then
                                Resultado = Potenciometria(CDbl(Dtg_DigitaNNO3.Item(Fila_Lectura, 5)), CDbl(TxtLectura.Text), Ultimo_Blanco)
                            End If
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If
                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If


                        With sp
                            .Inicializar()
                            .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                            .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                            Mascara = .EjecutarEscalar("usp_RescataMascara")
                        End With


                        Dtg_DigitaNNO3.Item(Fila_Lectura, 7) = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))
                    End If

Salto:
                    Me.TxtLectura.Focus()
                    mycell.ColumnNumber = 6
                    mycell.RowNumber = Fila_Lectura + 1
                    Dtg_DigitaNNO3.CurrentCell = mycell

                End If
            End If

        End If

    End Sub
    Private Function Cantidad_Decimales(ByVal TIPOM As Integer, ByVal ResultadoR As Double) As Integer
        Dim BusRango(1) As Object
        Dim hg, CaDecimal As Integer
        Dim Fila_TMascara As DataRow
        For hg = 1 To 9
            BusRango(0) = TIPOM
            BusRango(1) = hg
            Fila_TMascara = Cjto_Tablas1.Tables("TIPO_MASCARA").Rows.Find(BusRango)
            If (Fila_TMascara Is Nothing) = False Then
                If ResultadoR >= Fila_TMascara("RANGO_DESDE") And ResultadoR < Fila_TMascara("RANGO_HASTA") Then CaDecimal = Fila_TMascara("DECIMALES") : Exit For
            End If
        Next
        Return CaDecimal
    End Function
    Private Sub TxtNumLab_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNumLab.KeyPress
        Dim EstaRevisado, MyPos, NumL, NumD, NumDigRev As Integer
        Dim respuesta As MsgBoxResult
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            MyPos = InStr(TxtNumLab.Text, "Blanco")
            If MyPos > 0 And Fila_Lectura > 3 Then MsgBox("Imposible Insertar Blanco") : GoTo SaltoNoExisteLab

            MyPos = InStr(TxtNumLab.Text, "E")
            If MyPos > 0 And Fila_Lectura > 3 Then MsgBox("Imposible Insertar Estandar") : GoTo SaltoNoExisteLab

            MyPos = InStr(TxtNumLab.Text, "T")
            If MyPos > 0 And Fila_Lectura > 3 Then MsgBox("Imposible Insertar Testigo") : GoTo SaltoNoExisteLab

            MyPos = InStr(TxtNumLab.Text, "D")
            If MyPos > 0 Then
                NumL = Mid(TxtNumLab.Text, 1, MyPos - 1)
                NumD = Mid(TxtNumLab.Text, MyPos + 1)
                NumDigRev = RevisaNumDup(NumL, NumD, Elemento, CodAna)
                If NumDigRev = 1 Then
                    MsgBox("La duplicacion no existe ¿ Desea Crearla ? ", MsgBoxStyle.YesNo)
                    If respuesta = MsgBoxResult.Yes Then
                        Dtg_Digitado.Item(Fila_Lectura, 0) = TxtNumLab.Text
                        GoTo SaltoNoExisteLab
                    End If
                End If
            End If

            EstaRevisado = 0
            EstaRevisado = RevisaNumLab(TxtNumLab.Text, Elemento, CodAna)
            If EstaRevisado = 1 Then MsgBox("El numero de laboratorio : " & TxtNumLab.Text & " presenta un estado digitado") : GoTo SaltoNoExisteLab
            If EstaRevisado = 2 Then MsgBox("El numero de laboratorio : " & TxtNumLab.Text & " NO se encuentra") : GoTo SaltoNoExisteLab
            Dtg_Digitado.Item(Fila_Lectura, 0) = TxtNumLab.Text
SaltoNoExisteLab:
            mycell.ColumnNumber = 1
            mycell.RowNumber = Fila_Lectura
            Dtg_Digitado.CurrentCell = mycell
        End If

    End Sub

    Private Sub Txt_LecRes_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LecRes.KeyPress
        Dim Fila As Integer
        Dim Mycell As New DataGridCell
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Lec_aux, Resultado As Double
        Dim query, gatos, Formato, CanDec, Resultado_Paso As String
        Dim Mypos, Fila_Promedio, Decimales As Integer
        Dim n As Integer
        Dim con As New SqlConnection(Conexion1)

        If (e.KeyChar.IsLetter(e.KeyChar)) Then
            MsgBox("Error en la Digitacion")
            TxtLectura.ResetText()
        Else
            If e.KeyChar = Chr(13) Then
                If IsNothing(Txt_LecRes.Text) = False Then
                    Txt_LecRes.Text = Txt_LecRes.Text.Replace(".", ",")
                    Dtg_Elenf.Item(Fila, 1) = Txt_LecRes.Text
                    Resultado = Txt_LecRes.Text

                    If Unidad = "ppm" Then
                        Resultado = Round(Resultado, 0)
                    Else
                        With sp
                            .Inicializar()
                            .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                            .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                            Mascara = .EjecutarEscalar("usp_RescataMascara")
                        End With
                    End If


                    Formato = ""
                    con.Open()
                    query = "Select NUMERO_RANGO,RANGO_DESDE,RANGO_HASTA,DECIMALES FROM TIPO_MASCARA WHERE TMASCARA=" & CInt(Mascara)
                    Dim myCommand2 As New SqlCommand(query, con)
                    Dim myReader2 As SqlDataReader
                    myReader2 = myCommand2.ExecuteReader()
                    While myReader2.Read()
                        If Resultado >= myReader2.GetDouble(1) And Resultado <= myReader2.GetDouble(2) Then
                            Formato = Mid(gatos, 1, EntRes) & "." & Mid(CanDec, 1, myReader2.GetInt32(3))
                        End If
                    End While
                    myReader2.Close()
                    con.Close()
                    Dtg_Elenf.Item(Fila_Lectura, 2) = Format(Resultado, Formato)

                    Mycell.ColumnNumber = 1
                    Mycell.RowNumber = Fila + 1
                    Dtg_Elenf.CurrentCell = Mycell

                    'Dtg_Elenf.Item(Fila, 2) = Txt_LecRes.Text
                    'Fila = Fila + 1

                End If

            End If
        End If
    End Sub

#End Region

    Private Sub Dtg_Elenf_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Elenf.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        If TxtLectura.Visible = True Then TxtLectura.Visible = False
        If TxtNumLab.Visible = True Then TxtNumLab.Visible = False
        If Txt_LecRes.Visible = True Then Txt_LecRes.Visible = False
        Fila_Lectura = Dtg_Elenf.CurrentCell.RowNumber()
        Revision_Digitacion = "N"
        If Dtg_Elenf.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
        If Dtg_Elenf.CurrentCell.ColumnNumber = 1 Then
            Dim CeldaAlto As Integer = Dtg_Elenf.GetCellBounds(Dtg_Elenf.CurrentCell.RowNumber, Dtg_Elenf.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Elenf.GetCellBounds(Dtg_Elenf.CurrentCell.RowNumber, Dtg_Elenf.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Elenf.GetCellBounds(Dtg_Elenf.CurrentCell.RowNumber, Dtg_Elenf.CurrentCell.ColumnNumber).X + Dtg_Elenf.Left
            Dim Posiciony As Integer = Dtg_Elenf.GetCellBounds(Dtg_Elenf.CurrentCell.RowNumber, Dtg_Elenf.CurrentCell.ColumnNumber).Y + Dtg_Elenf.Top
            Txt_LecRes.Left = Posicionx
            Txt_LecRes.Top = Posiciony
            Txt_LecRes.Height = CeldaAlto
            Txt_LecRes.Width = CeldaAncho
            Txt_LecRes.Visible = True
            Txt_LecRes.Text = ""
            Txt_LecRes.Enabled = True
            Txt_LecRes.TabIndex = 1
            SendKeys.Send("^{TAB}")
            Txt_LecRes.Focus()
            Try
                Mypos = InStr(Dtg_Elenf.Item(Fila_Lectura, 0), "BLPromedio")
                If Mypos > 0 Then
                    Dtg_Elenf.Item(Fila_Lectura, 1) = SacaPromedio()
                End If
            Catch ex As Exception
            End Try

            If IsDBNull(Dtg_Elenf.Item(Fila_Lectura, 1)) = False Then Txt_LecRes.Text = Dtg_Elenf.Item(Fila_Lectura, 1) : Exit Sub
        End If
    End Sub

    Private Sub Dtg_Digitado_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Digitado.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo

        If TxtLectura.Visible = True Then TxtLectura.Visible = False
        If TxtNumLab.Visible = True Then TxtNumLab.Visible = False
        If Txt_MasaMue.Visible = True Then Txt_MasaMue.Visible = False
        If Txt_VolExt.Visible = True Then Txt_VolExt.Visible = False
        If Txt_VolAli.Visible = True Then Txt_VolAli.Visible = False
        If Txt_AfoAli.Visible = True Then Txt_AfoAli.Visible = False

        Fila_Lectura = Dtg_Digitado.CurrentCell.RowNumber()
        Revision_Digitacion = "N"
        If Dtg_Digitado.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
        If Dtg_Digitado.CurrentCell.ColumnNumber = 6 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            TxtLectura.Left = Posicionx
            TxtLectura.Top = Posiciony
            TxtLectura.Height = CeldaAlto
            TxtLectura.Width = CeldaAncho
            TxtLectura.Visible = True
            TxtLectura.Text = ""
            TxtLectura.Enabled = True
            TxtLectura.TabIndex = 15
            SendKeys.Send("^{TAB}")
            TxtLectura.Focus()
            Try
                Mypos = InStr(Dtg_Digitado.Item(Fila_Lectura, 0), "BLPromedio")
                If Mypos > 0 Then
                    Dtg_Digitado.Item(Fila_Lectura, 6) = SacaPromedio()
                End If
            Catch ex As Exception
            End Try

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 6)) = False Then TxtLectura.Text = Dtg_Digitado.Item(Fila_Lectura, 6) : Exit Sub
        End If

        If Dtg_Digitado.CurrentCell.ColumnNumber = 1 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            Txt_MasaMue.Left = Posicionx
            Txt_MasaMue.Top = Posiciony
            Txt_MasaMue.Height = CeldaAlto
            Txt_MasaMue.Width = CeldaAncho
            Txt_MasaMue.Visible = True
            Txt_MasaMue.Text = ""
            Txt_MasaMue.Enabled = True
            Txt_MasaMue.TabIndex = 47
            SendKeys.Send("^{TAB}")
            Txt_MasaMue.Focus()

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 1)) = False Then Txt_MasaMue.Text = Dtg_Digitado.Item(Fila_Lectura, 1) : Exit Sub
        End If

        If Dtg_Digitado.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            Txt_VolExt.Left = Posicionx
            Txt_VolExt.Top = Posiciony
            Txt_VolExt.Height = CeldaAlto
            Txt_VolExt.Width = CeldaAncho
            Txt_VolExt.Visible = True
            Txt_VolExt.Text = ""
            Txt_VolExt.Enabled = True
            Txt_VolExt.TabIndex = 48
            SendKeys.Send("^{TAB}")
            Txt_VolExt.Focus()

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 2)) = False Then Txt_VolExt.Text = Dtg_Digitado.Item(Fila_Lectura, 2) : Exit Sub
        End If

        If Dtg_Digitado.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            Txt_VolAli.Left = Posicionx
            Txt_VolAli.Top = Posiciony
            Txt_VolAli.Height = CeldaAlto
            Txt_VolAli.Width = CeldaAncho
            Txt_VolAli.Visible = True
            Txt_VolAli.Text = ""
            Txt_VolAli.Enabled = True
            Txt_VolAli.TabIndex = 49
            SendKeys.Send("^{TAB}")
            Txt_VolAli.Focus()

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 3)) = False Then Txt_VolAli.Text = Dtg_Digitado.Item(Fila_Lectura, 3) : Exit Sub
        End If

        If Dtg_Digitado.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            Txt_AfoAli.Left = Posicionx
            Txt_AfoAli.Top = Posiciony
            Txt_AfoAli.Height = CeldaAlto
            Txt_AfoAli.Width = CeldaAncho
            Txt_AfoAli.Visible = True
            Txt_AfoAli.Text = ""
            Txt_AfoAli.Enabled = True
            Txt_AfoAli.TabIndex = 50
            SendKeys.Send("^{TAB}")
            Txt_AfoAli.Focus()

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 4)) = False Then Txt_AfoAli.Text = Dtg_Digitado.Item(Fila_Lectura, 4) : Exit Sub
        End If

        If Dtg_Digitado.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).X + Dtg_Digitado.Left
            Dim Posiciony As Integer = Dtg_Digitado.GetCellBounds(Dtg_Digitado.CurrentCell.RowNumber, Dtg_Digitado.CurrentCell.ColumnNumber).Y + Dtg_Digitado.Top
            TxtFactor.Left = Posicionx
            TxtFactor.Top = Posiciony
            TxtFactor.Height = CeldaAlto
            TxtFactor.Width = CeldaAncho
            TxtFactor.Visible = True
            TxtFactor.Text = ""
            TxtFactor.Enabled = True
            TxtFactor.TabIndex = 57
            SendKeys.Send("^{TAB}")
            TxtFactor.Focus()

            If IsDBNull(Dtg_Digitado.Item(Fila_Lectura, 5)) = False Then TxtFactor.Text = Dtg_Digitado.Item(Fila_Lectura, 5) : Exit Sub
        End If


    End Sub

    Private Function SacaPromedio() As Double
        Dim hh, Mypos As Integer
        Dim SumaLec As Double
        For hh = 0 To 4
            Mypos = InStr(Dtg_Digitado.Item(hh, 0), "Blanco")
            If Mypos > 0 Then
                If IsDBNull(Dtg_Digitado.Item(hh, 2)) = False Then SumaLec = SumaLec + CDbl(Dtg_Digitado.Item(hh, 2))
            Else
                Exit For
            End If
        Next
        SacaPromedio = (SumaLec / hh)
        Return SacaPromedio
    End Function

    Public Sub Rescata_decimales_Formula(ByVal codigoana As Integer)
        Dim query As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        query = "Select ELE_TAM_BLENTERO,ELE_TAM_BLDECIMAL,ELE_TAM_FAENTERO,ELE_TAM_FADECIMAL,ELE_TAM_LEENTERO,ELE_TAM_LEDECIMAL," & _
        "ELE_TAM_REENTERO,ELE_MASCARA,ELE_CAL_FORMULA,ELE_FACTOR_PROPU FROM ELEMENTO WHERE " & _
        "TMU_CODIGO=" & CodAna & " AND ELE_CODIGO=" & "'" & Elemento & "'"
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        myReader2.Read()
        EntBl = myReader2.GetInt32(0)
        DecBl = myReader2.GetInt32(1)
        EntFac = myReader2.GetInt32(2)
        DecFac = myReader2.GetInt32(3)
        EntLec = myReader2.GetInt32(4)
        DecLec = myReader2.GetInt32(5)
        EntRes = myReader2.GetInt32(6)
        Mascara = myReader2.GetInt32(7)
        Tit_Formula = myReader2.GetString(8)
        Factor_Propu = myReader2.GetDouble(9)

        myReader2.Close()
        con.Close()
    End Sub

    Private Function BuscaNumGri(ByVal NumLabGri As Integer, ByRef EsNuevoNum As Boolean) As Integer
        Dim NumLabDig As String
        Dim Mypos, NumDup_Aux As Integer
        Dim Fila_Digita As DataRow
        '*************************************
        'Segundo Busca en grilla de digitacion
        '*************************************
        BuscaNumGri = 0
        For Each Fila_Digita In Cjto_Tablas1.Tables("DIGITACION").Rows
            If IsDBNull(Fila_Digita("RESULTADO")) = True Then GoTo SaltoxResultado0
            Mypos = InStr(Fila_Digita("OT_NLABX"), "D")
            If Mypos > 0 Then
                NumLabDig = Mid(Fila_Digita("OT_NLABX"), 1, Mypos - 1)
                If CInt(NumLabDig) = NumLabGri Then
                    NumDup_Aux = CInt(Mid(Fila_Digita("OT_NLABX"), Mypos + 1))
                    EsNuevoNum = False
                    If BuscaNumGri <> 0 Then
                        If BuscaNumGri < NumDup_Aux Then
                            BuscaNumGri = NumDup_Aux
                        End If
                    Else
                        BuscaNumGri = NumDup_Aux
                    End If
                End If
            Else
                If Fila_Digita("OT_NLABX") = CStr(NumLabGri) Then
                    BuscaNumGri = 1
                    EsNuevoNum = True
                End If
            End If
SaltoxResultado0:
        Next
        Return BuscaNumGri
    End Function

    Private Function BuscaNumDup(ByVal numlab As Integer) As Integer
        Dim query, NumLabDig, Estado_Aux As String
        Dim Mypos, NumDup_Aux As Integer
        Dim Fila_Digita As DataRow

        '****************************************
        'Primero Busca en tabla DUPLICA_RESULTADO
        '****************************************
        BuscaNumDup = 0
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        Mypos = InStr(numlab, "D")
        If Mypos > 0 Then Return BuscaNumDup

        query = "Select NUMERO_DIGITACION,ELE_ESTADO FROM DUPLICA_RESULTADO WHERE TMU_CODIGO=" & CodAna & "AND OT_NLAB=" & numlab & " AND ELE_CODIGO=" & "'" & Elemento & "'" & " ORDER BY NUMERO_DIGITACION DESC"
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader
        Try
            myReader2 = myCommand2.ExecuteReader()
            myReader2.Read()
            NumDup_Aux = myReader2.GetInt32(0)
            If IsDBNull(myReader2.GetString(1)) = False Then Estado_Aux = myReader2.GetString(1)
            If Estado_Aux = "DuxA" Then BuscaNumDup = NumDup_Aux
        Catch ex As Exception
        End Try
        myReader2.Close()
        con.Close()
        Return BuscaNumDup
    End Function

    Private Sub Determina_Numero_Digitacion(ByRef NumRepD As Integer, ByVal MControl As String)
        Dim Fila_Digita As DataRow
        Dim Mypos As Integer
        For Each Fila_Digita In Cjto_Tablas1.Tables("DIGITACION").Rows
            Mypos = InStr(Fila_Digita("OT_NLABX"), MControl)
            If Mypos <> 0 Then
                NumRepD = CInt(Mid(Fila_Digita("OT_NLABX"), Len(Fila_Digita("OT_NLABX"))))
            End If
        Next
        NumRepD = NumRepD + 1
    End Sub

    Private Sub FormatGridCells(ByVal sender As Object, ByVal e As DataGridFormatCellEventArgs, ByVal grid As DataGrid)
        Dim Mypos, EstaRevisado, EstaMala, NumL, NumD, NumDigRev As Integer
        Dim respuesta As MsgBoxResult
        Dim BuscaNL As Object
        Dim FILA_DATAROW As DataRow
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)

        Dim mydv As DataView = CType(mycm.List, DataView)

        Dim row As DataRow
        Dim j As Integer
        j = 0 : EstaMala = 0
        If Revision_Digitacion = "S" Then
            For Each row In mydv.Table.Rows
                Try
                    Mypos = InStr(row("OT_NLABX"), "Blanco")
                    If Mypos > 0 And j > 3 Then MsgBox("Imposible Insertar Blanco") : Exit For

                    Mypos = InStr(row("OT_NLABX"), "E")
                    If Mypos > 0 And j > 3 Then MsgBox("Imposible Insertar Estandar") : Exit For
                    GoTo saltop
                    Mypos = InStr(row("OT_NLABX"), "T")
                    If Mypos > 0 And j > 3 Then MsgBox("Imposible Insertar Testigo") : Exit For
                    GoTo saltop
                    Mypos = InStr(row("OT_NLABX"), "D")
                    If Mypos > 0 Then
                        NumL = Mid(row("OT_NLABX"), 1, Mypos - 1)
                        NumD = Mid(row("OT_NLABX"), Mypos + 1)
                        NumDigRev = RevisaNumDup(NumL, NumD, Elemento_Digitacion, CodAna)
                        If NumDigRev = 1 Then
                            respuesta = MsgBox("La duplicacion no existe ¿ Desea Crearla ? ", MsgBoxStyle.YesNo)
                            If respuesta = MsgBoxResult.Yes Then
                                Exit For
                            Else
                                EstaMala = 1
                                Exit For
                            End If
                        End If
                    End If
                    EstaRevisado = 0
                    EstaRevisado = RevisaNumLab(row("OT_NLABX"), Elemento_Digitacion, CodAna)
                    If EstaRevisado = 1 Then EstaMala = 1 : MsgBox("El numero de laboratorio : " & row("OT_NLABX") & " presenta un estado digitado") : Exit For
                    If EstaRevisado = 2 Then EstaMala = 1 : MsgBox("El numero de laboratorio : " & row("OT_NLABX") & " NO se encuentra") : Exit For
                    j += 1
                Catch ex As Exception
                    j += 1
                End Try
saltop:
            Next
            If EstaMala = 1 Then
                BuscaNL = row("OT_NLABX")
                FILA_DATAROW = Cjto_Tablas1.Tables("DIGITACION").Rows.Find(BuscaNL)
                FILA_DATAROW("OT_NLABX") = ""
            End If
            Revision_Digitacion = "N"
        End If

    End Sub

    Private Sub AddCellFormattingColumnStyles(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim Colum As Integer
        Dim ts As DataGridTableStyle
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        Dim mydv As DataView = CType(mycm.List, DataView)
        ts = New DataGridTableStyle
        Dim dt As DataTable
        Dim row As DataRow
        Dim S As String
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j, fil As Integer
        j = 0
        fil = 0
        Dim numRows As Integer = grid.BindingContext(grid.DataSource, grid.DataMember).Count
        Do While (j < dt.Columns.Count)
            fil = fil + 1
            Dim cs As DataGridFormattableTextBoxColumn
            cs = New DataGridFormattableTextBoxColumn(j)
            cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
            cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
            cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
            cs.grid = grid
            If j = 0 Then AddHandler cs.SetCellFormat, handler
            ts.GridColumnStyles.Add(cs)
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub Lista_Analista()
        Dim Fila_i, Fila_Personal As DataRow
        Dim DESP As String
        Dim Busca As Object
        DESP = "SI"
        Cbx_Analista.Items.Clear()
        Cbx_Digitador.Items.Clear()
        Cbx_Analista.Text = ""
        Cbx_Digitador.Text = ""
        For Each Fila_i In Cjto_Tablas1.Tables("ANALISTA_ELEMENTO").Rows
            If Elemento = Fila_i("ELE_CODIGO") Then
                Busca = Fila_i("PER_RUT")
                Fila_Personal = Cjto_Tablas1.Tables("PERSONAL").Rows.Find(Busca)
                If DESP = "SI" Then Cbx_Analista.Text = Fila_Personal("PER_APENOM") : Cbx_Digitador.Text = Fila_Personal("PER_APENOM") : DESP = "NO"
                Cbx_Analista.Items.Add(Fila_Personal("PER_APENOM"))
            End If
        Next

        For Each Fila_i In Cjto_Tablas1.Tables("PERSONAL").Rows
            Cbx_Digitador.Items.Add(Fila_i("PER_APENOM"))
        Next

    End Sub

    Private Sub Bt_Carga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click

        Try
            If Tit_Formula = "EAA" Or Tit_Formula = "Colorimétrico" Then
                Dtg_Digitado.Visible = False
                Dtg_DigitaNNO3.Visible = False
                Dtg_Elenf.Visible = False

                PMuestra = CDbl(Txt_LectPesoMuestra.Text)
                VAforo = CDbl(Txt_LectAforo.Text)
                If Txt_LectVolAlicuota.Text = "" Then
                    VAlicuota = 1
                Else
                    VAlicuota = CDbl(Txt_LectVolAlicuota.Text)

                End If
                If Txt_LectVolAforoAlic.Text = "" Then
                    VAforoAlicuota = 1
                Else
                    VAforoAlicuota = CDbl(Txt_LectVolAforoAlic.Text)
                End If
                PFactor = CDbl(Txt_LectFactDilucion.Text)

            ElseIf Tit_Formula = "Potenciométrico" Then
                Dtg_Digitado.Visible = False
                Dtg_DigitaNNO3.Visible = False
                Dtg_Elenf.Visible = False

                PMuestra = CDbl(Txt_NNO3MasaMuestra.Text)
                VAforo = CDbl(Txt_NNO3VolExt.Text)

                If Txt_NNO3VolAli.Text = "" Then
                    VAlicuota = 1
                Else
                    VAlicuota = CDbl(Txt_NNO3VolAli.Text)
                End If

                If Txt_NNO3VolAfoAli.Text = "" Then
                    VAforoAlicuota = 1
                Else
                    VAforoAlicuota = CDbl(Txt_NNO3VolAfoAli.Text)
                End If
                Call Carga_PlanillaNNO3()
                Dtg_DigitaNNO3.Visible = True
                GoTo salto
            ElseIf Tit_Formula = "Volumétrico" Then
                Dtg_Digitado.Visible = False
                Dtg_DigitaNNO3.Visible = False
                Dtg_Elenf.Visible = False
                PMuestra = CDbl(Txt_GasPMuestra.Text)
                Normalidad = CDbl(Txt_GasNormalidad.Text)
                PFactor = CDbl(Txt_GasFactor.Text)
                Call Carga_PlanillaVolumetrica()
                Dtg_DigitaVolumetrico.Visible = True
                GoTo salto
            ElseIf Tit_Formula = "VolumétricoNNH4" Then
                Dtg_Digitado.Visible = False
                Dtg_DigitaNNO3.Visible = False
                Dtg_Elenf.Visible = False
                PMuestra = CDbl(Txt_PotNNH4PMuestra.Text)
                Normalidad = CDbl(Txt_PotNNH4Normalidad.Text)
                PFactor = CDbl(Txt_PotNNH4Factor.Text)
                Call Carga_PlanillaVolumetrica()
                Dtg_DigitaVolumetrico.Visible = True
                GoTo salto
            ElseIf Tit_Formula = "Autogenerado" Then
                GoTo salto
            Else
                Dtg_Digitado.Visible = False
                Dtg_DigitaNNO3.Visible = False
                Dtg_Elenf.Visible = False
                Call Carga_Planilla2()
                Dtg_Elenf.Visible = True
                GoTo salto
            End If
            Call Carga_Planilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dtg_Digitado.Visible = True
salto:
        Bt_Imprime.Visible = True
        Bt_Graba.Visible = True
        Bt_Limpiar.Visible = True
        Bt_Salir.Visible = True
        Revision_Digitacion = "S"
        TxtLectura.Focus()
    End Sub

    Private Sub Carga_PlanillaVolumetrica()
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim FactorE, MasaE, VolExtE, VolAliE, AforoE As Double
        Dim Indice As Integer
        Dim SqlConn As New SqlConnection
        SqlConn = New SqlConnection(Conexion1)

        If Tit_Formula = "Volumétrico" Then
            FactorE = CDbl(Txt_GasFactor.Text)
            MasaE = CDbl(Txt_GasPMuestra.Text)
        End If

        If Tit_Formula = "VolumétricoNNH4" Then
            FactorE = CDbl(Txt_PotNNH4Factor.Text)
            MasaE = CDbl(Txt_PotNNH4PMuestra.Text)
        End If

        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
            Cjto_Tablas1.Tables("DIGITACION").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
            SqlConn.Open()
            Dim myCommand As New SqlCommand(query, SqlConn)
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()

            While myReader.Read()
                Mypos = InStr(myReader.GetString(0), "Blanco")
                If Mypos > 0 Then GoTo Jump

                Mypos = InStr(myReader.GetString(0), "S")
                If Mypos > 0 Then GoTo Jump

                Mypos = InStr(myReader.GetString(0), "T")
                If Mypos > 0 Then GoTo jump

                Mypos = InStr(myReader.GetString(0), "D")
                If Mypos > 0 Then GoTo jump


                If myReader.GetString(0) >= CInt(Txt_NLabDesde.Text) And myReader.GetString(0) <= CInt(Txt_NLabHasta.Text) Then
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, CodAna)
                    If EstaRevisado = 0 Then
Jump:                   Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                        Fila_Digitacion("OT_NLABX") = myReader.GetString(0)
                        Fila_Digitacion("FACTOR") = FactorE
                        Fila_Digitacion("MASA_MUE") = MasaE
                        Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                    ElseIf EstaRevisado = 1 Then
                        MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                    End If
                End If
            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If



        Cjto_Tablas1.Tables("DIGITACION").Clear()
        Son_Blancos = "S"
        Cuenta_Blancos = 0
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=" & CodAna & "ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            Carga_Digitacion = "N"
            Mypos = 0

            Mypos = InStr(myReader1.GetString(0), "Blanco")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga

            Mypos = InStr(myReader1.GetString(0), "S")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "T")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "D")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, CodAna)
                If EstaRevisado = 1 Then
                    MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                    Bt_Graba.Enabled = False
                    GoTo SaltoxIngresoDup
                End If
            End If

            If Carga_Digitacion = "S" Then
                Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                Mypos = InStr(myReader1.GetString(0), "Blanco")
                If Mypos > 0 Then
                    Cuenta_Blancos = Cuenta_Blancos + 1
                End If

                Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                If Mypos = 0 Then
                    Fila_Digitacion("FACTOR") = FactorE
                    Fila_Digitacion("MASA_MUE") = MasaE
                End If
                Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
            End If

        End While
        myReader1.Close()

SaltoxIngresoDup:


        SqlConn.Close()

    End Sub

    Private Sub Carga_PlanillaNNO3()
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim FactorE, MasaE, VolExtE, VolAliE, AforoE As Double
        Dim SqlConn As New SqlConnection
        Dim Indice As Integer
        SqlConn = New SqlConnection(Conexion1)



        FactorE = CDbl(Txt_NNO3FacDil.Text)
        MasaE = CDbl(Txt_NNO3MasaMuestra.Text)
        VolExtE = CDbl(Txt_NNO3VolExt.Text)
        If Txt_NNO3VolAli.Text = "" Then
            VolAliE = 0
        Else
            VolAliE = CDbl(Txt_NNO3VolAli.Text)
        End If
        If Txt_NNO3VolAfoAli.Text = "" Then
            AforoE = 0
        Else
            AforoE = Txt_NNO3VolAfoAli.Text
        End If


        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
            Cjto_Tablas1.Tables("DIGITACION").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Mypos = InStr(myReader.GetString(0), "Blanco")
                If Mypos > 0 Then GoTo jump

                Mypos = InStr(myReader.GetString(0), "S")
                If Mypos > 0 Then GoTo jump

                Mypos = InStr(myReader.GetString(0), "T")
                If Mypos > 0 Then GoTo jump

                Mypos = InStr(myReader.GetString(0), "D")
                If Mypos > 0 Then GoTo jump

                If myReader.GetString(0) >= CInt(Txt_NLabDesde.Text) And myReader.GetString(0) <= CInt(Txt_NLabHasta.Text) Then
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, CodAna)
                    If EstaRevisado = 0 Then
Jump:                   Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                        Fila_Digitacion("OT_NLABX") = myReader.GetString(0)
                        Fila_Digitacion("FACTOR") = FactorE
                        Fila_Digitacion("MASA_MUE") = MasaE
                        Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                        Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                        Fila_Digitacion("AFORO_ALI") = AforoE
                        Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                    ElseIf EstaRevisado = 1 Then
                        MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                    End If
                End If

            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If


        Cjto_Tablas1.Tables("DIGITACION").Clear()
        Son_Blancos = "S"
        Cuenta_Blancos = 0
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=" & CodAna & "ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            Carga_Digitacion = "N"
            Mypos = 0

            Mypos = InStr(myReader1.GetString(0), "Blanco")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga

            Mypos = InStr(myReader1.GetString(0), "S")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "T")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "D")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, CodAna)
                If EstaRevisado = 1 Then
                    MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                    Bt_Graba.Enabled = False
                    GoTo SaltoxIngresoDup
                End If
            End If
            If Carga_Digitacion = "S" Then
                Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                Mypos = InStr(myReader1.GetString(0), "Blanco")
                If Mypos > 0 Then
                    Cuenta_Blancos = Cuenta_Blancos + 1
                End If

                Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                If Mypos = 0 Then
                    Fila_Digitacion("FACTOR") = FactorE
                    Fila_Digitacion("MASA_MUE") = MasaE
                    Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                    Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                    Fila_Digitacion("AFORO_ALI") = AforoE
                End If
                Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:
        SqlConn.Close()

    End Sub

    Private Sub Carga_PlanillaPotenciometrico()
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim FactorE, MasaE, VolExtE, VolAliE, AforoE As Double

        Dim SqlConn As New SqlConnection
        SqlConn = New SqlConnection(Conexion1)

        If Tit_Formula = "Potenciométrico" Then
            FactorE = CDbl(Txt_PotFactor.Text)
            MasaE = CDbl(Txt_PotPesoMuestra.Text)
        End If




        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
            Cjto_Tablas1.Tables("DIGITACION").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Mypos = InStr(myReader.GetString(0), "Blanco")
                If Mypos > 0 Then GoTo Jump

                Mypos = InStr(myReader.GetString(0), "S")
                If Mypos > 0 Then GoTo Jump

                Mypos = InStr(myReader.GetString(0), "T")
                If Mypos > 0 Then GoTo jump

                Mypos = InStr(myReader.GetString(0), "D")
                If Mypos > 0 Then GoTo jump


                If myReader.GetString(0) >= CInt(Txt_NLabDesde.Text) And myReader.GetString(0) <= CInt(Txt_NLabHasta.Text) Then
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, CodAna)
                    If EstaRevisado = 0 Then
Jump:                   Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                        Fila_Digitacion("OT_NLABX") = myReader.GetString(0)
                        Fila_Digitacion("FACTOR") = FactorE
                        Fila_Digitacion("MASA_MUE") = MasaE
                        Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                    ElseIf EstaRevisado = 1 Then
                        MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                    End If
                End If
            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If


        Cjto_Tablas1.Tables("DIGITACION").Clear()
        Son_Blancos = "S"
        Cuenta_Blancos = 0
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=" & CodAna & "ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            Carga_Digitacion = "N"
            Mypos = 0

            Mypos = InStr(myReader1.GetString(0), "Blanco")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga

            Mypos = InStr(myReader1.GetString(0), "S")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "T")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            Mypos = InStr(myReader1.GetString(0), "D")
            If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, CodAna)
                If EstaRevisado = 1 Then
                    MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                    Bt_Graba.Enabled = False
                    GoTo SaltoxIngresoDup
                End If
            End If
            If Carga_Digitacion = "S" Then
                Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                Mypos = InStr(myReader1.GetString(0), "Blanco")
                If Mypos > 0 Then
                    Cuenta_Blancos = Cuenta_Blancos + 1
                End If

                Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                If Mypos = 0 Then
                    Fila_Digitacion("FACTOR") = FactorE
                    Fila_Digitacion("MASA_MUE") = MasaE
                End If
                Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:

        SqlConn.Close()

    End Sub

    Function Carga_Spectro(ByVal NumLab As String, ByVal Codigo As String)
        Dim Sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With Sp
                .Inicializar()
                .AgregarParametro("@NumLab", NumLab, SqlDbType.NVarChar)
                .AgregarParametro("@Codigo", Codigo, SqlDbType.NVarChar)
                Carga_Spectro = .EjecutarEscalar3("usp_CargaSpectro")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        return Carga_Spectro
    End Function
    Private Sub Carga_Planilla()
        Try
            Dim Fila_Digitacion, Fila_Carga As DataRow
            Dim Carga_Digitacion, query, Son_Blancos As String
            Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
            Dim FactorE, MasaE, VolExtE, VolAliE, AforoE As Double
            Dim Indice As Integer
            Dim SqlConn As New SqlConnection
            Dim CodigoM As String
            Dim Para As Integer
            Dim Resultado As Double
            Dim x As String
            Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim Numero As Integer
            SqlConn = New SqlConnection(Conexion1)
            Para = InStr(Elemento, "_")


            If Tit_Formula = "EAA" Then

                FactorE = CDbl(Txt_LectFactDilucion.Text)
                MasaE = CDbl(Txt_LectPesoMuestra.Text)
                VolExtE = CDbl(Txt_LectAforo.Text)
                If Txt_LectVolAlicuota.Text = "" Then Txt_LectVolAlicuota.Text = 0
                VolAliE = CDbl(Txt_LectVolAlicuota.Text)
                If Txt_LectVolAforoAlic.Text = "" Then Txt_LectVolAforoAlic.Text = 0
                AforoE = CDbl(Txt_LectVolAforoAlic.Text)

                If Para = 0 Then
                    CodigoM = Elemento
                Else
                    CodigoM = Mid(Elemento, 1, Para - 1)
                End If
                If CodigoM = "CIC" Then CodigoM = "Na"

                If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
                    Cjto_Tablas1.Tables("DIGITACION").Clear()
                    query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
                    Dim myCommand3 As New SqlCommand(query, SqlConn)
                    SqlConn.Open()
                    Dim myReader3 As SqlDataReader = myCommand3.ExecuteReader()
                    While myReader3.Read()
                        Mypos = InStr(myReader3.GetString(0), "Blanco")
                        If Mypos > 0 Then GoTo Jump1

                        Mypos = InStr(myReader3.GetString(0), "S")
                        If Mypos > 0 Then GoTo Jump1

                        Mypos = InStr(myReader3.GetString(0), "T")
                        If Mypos > 0 Then GoTo Jump1

                        Mypos = InStr(myReader3.GetString(0), "D")
                        If Mypos > 0 Then GoTo Jump1

                        If InStr(myReader3.GetString(0), "C") Then
                            Numero = CInt(Mid(myReader3.GetString(0), 1, Len(myReader3.GetString(0)) - 1))
                        ElseIf InStr(myReader3.GetString(0), "H") Then
                            Numero = CInt(Mid(myReader3.GetString(0), 1, Len(myReader3.GetString(0)) - 1))
                        ElseIf InStr(myReader3.GetString(0), "M") Then
                            Numero = CInt(Mid(myReader3.GetString(0), 1, Len(myReader3.GetString(0)) - 1))
                        ElseIf InStr(myReader3.GetString(0), "L") Then
                            Numero = CInt(Mid(myReader3.GetString(0), 1, Len(myReader3.GetString(0)) - 1))
                        ElseIf InStr(myReader3.GetString(0), "E") Then
                            Numero = CInt(Mid(myReader3.GetString(0), 1, Len(myReader3.GetString(0)) - 1))
                        End If

                        If Numero = 0 Then Numero = myReader3.GetString(0)

                        If Numero >= CInt(Txt_NLabDesde.Text) And Numero <= CInt(Txt_NLabHasta.Text) Then

                            EstaRevisado = RevisaNumLab(Numero, Elemento, CodAna)
                            If EstaRevisado = 0 Then
Jump1:                          Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow

                                If Numero = 0 Then
                                    Fila_Digitacion("OT_NLABX") = myReader3.GetString(0)
                                Else
                                    Fila_Digitacion("OT_NLABX") = Numero
                                End If

                                Fila_Digitacion("FACTOR") = FactorE
                                Fila_Digitacion("MASA_MUE") = MasaE
                                Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                                Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                                Fila_Digitacion("AFORO_ALI") = AforoE

                                If CDbl(Carga_Spectro(myReader3.GetString(0), CodigoM)) <> 0 Then

                                    Fila_Digitacion("LECTURA") = CDbl(Replace(Carga_Spectro(myReader3.GetString(0), CodigoM), ".", ","))
                                    If Fila_Digitacion("OT_NLABX") = "Blanco1" Then Ultimo_Blanco = CDbl(Fila_Digitacion("LECTURA"))
                                    If Fila_Digitacion("OT_NLABX") <> "Blanco1" Then
                                        Resultado = Lectura_Blanco(CDbl(Fila_Digitacion("LECTURA")), Ultimo_Blanco, CDbl(Fila_Digitacion("FACTOR")))
                                    End If

                                    If Unidad = "%" Then
                                        Resultado = Resultado / 10000
                                    End If
                                    If Unidad = "meq/l" Then
                                        Resultado = Resultado / Peso_Atomico
                                    End If
                                    If Unidad = "meq/100g" Then
                                        Resultado = Resultado / (Peso_Atomico * 10)
                                    End If
                                    If Unidad = "g/kg" Then
                                        Resultado = Resultado / 1000
                                    End If
                                    If Unidad = "mg/100g" Then
                                        Resultado = Resultado / 10
                                    End If

                                    If Fila_Digitacion("OT_NLABX") <> "Blanco1" Then
                                        With SP
                                            .Inicializar()
                                            .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                                            .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                                            Mascara = .EjecutarEscalar("usp_RescataMascara")
                                        End With
                                    End If


                                    Fila_Digitacion("RESULTADO") = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))

                                Else
                                    Fila_Digitacion("LECTURA") = 0
                                End If


                                Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                                Numero = 0
                            ElseIf EstaRevisado = 1 Then
                                MsgBox("El numero de laboratorio : " & myReader3.GetString(0) & " presenta un estado digitado")
                            End If

                        End If
                        Numero = 0
                    End While
                    myReader3.Close()
                    GoTo SaltoxIngresoDup
                End If

                Cjto_Tablas1.Tables("DIGITACION").Clear()
                Son_Blancos = "S"
                Cuenta_Blancos = 0
                query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=" & CodAna & "ORDER BY PRIORIDAD"
                Dim myCommand4 As New SqlCommand(query, SqlConn)
                SqlConn.Open()
                Dim myReader4 As SqlDataReader = myCommand4.ExecuteReader()
                While myReader4.Read()

                    Carga_Digitacion = "N"
                    Mypos = 0

                    Mypos = InStr(myReader4.GetString(0), "Blanco")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga4

                    Mypos = InStr(myReader4.GetString(0), "S")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga4

                    Mypos = InStr(myReader4.GetString(0), "T")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga4

                    Mypos = InStr(myReader4.GetString(0), "D")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga4

                    If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga4
                    If CInt(myReader4.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader4.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga4:
                    If Mypos = 0 Then
                        EstaRevisado = 0

                        If InStr(myReader4.GetString(0), "C") Then
                            Numero = CInt(Mid(myReader4.GetString(0), 1, Len(myReader4.GetString(0)) - 1))
                        ElseIf InStr(myReader4.GetString(0), "H") Then
                            Numero = CInt(Mid(myReader4.GetString(0), 1, Len(myReader4.GetString(0)) - 1))
                        ElseIf InStr(myReader4.GetString(0), "M") Then
                            Numero = CInt(Mid(myReader4.GetString(0), 1, Len(myReader4.GetString(0)) - 1))
                        ElseIf InStr(myReader4.GetString(0), "L") Then
                            Numero = CInt(Mid(myReader4.GetString(0), 1, Len(myReader4.GetString(0)) - 1))
                        ElseIf InStr(myReader4.GetString(0), "E") Then
                            Numero = CInt(Mid(myReader4.GetString(0), 1, Len(myReader4.GetString(0)) - 1))
                        End If

                        If Numero = 0 Then Numero = myReader4.GetString(0)

                        EstaRevisado = RevisaNumLab(Numero, Elemento, CodAna)
                        If EstaRevisado = 1 Then
                            MsgBox("El numero de laboratorio : " & myReader4.GetString(0) & " presenta un estado digitado")
                            Bt_Graba.Enabled = False
                            Carga_Digitacion = "N"
                            ' GoTo SaltoxIngresoDup
                        End If
                    End If
                    If Carga_Digitacion = "S" Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                        Mypos = InStr(myReader4.GetString(0), "Blanco")
                        If Mypos > 0 Then
                            Cuenta_Blancos = Cuenta_Blancos + 1
                        End If

                        If Numero = 0 Then
                            Fila_Digitacion("OT_NLABX") = myReader4.GetString(0)
                        Else
                            Fila_Digitacion("OT_NLABX") = Numero
                        End If

                        If EstaRevisado = 0 Then
                            Fila_Digitacion("FACTOR") = FactorE
                            Fila_Digitacion("MASA_MUE") = MasaE
                            Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                            Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                            Fila_Digitacion("AFORO_ALI") = AforoE

                            If CDbl(Carga_Spectro(myReader4.GetString(0), CodigoM)) <> 0 Then

                                Fila_Digitacion("LECTURA") = CDbl(Replace(Carga_Spectro(myReader4.GetString(0), CodigoM), ".", ","))

                                If Fila_Digitacion("OT_NLABX") = "Blanco1" Then Ultimo_Blanco = CDbl(Fila_Digitacion("LECTURA"))

                                If Fila_Digitacion("OT_NLABX") <> "Blanco1" Then
                                    Resultado = Lectura_Blanco(CDbl(Fila_Digitacion("LECTURA")), Ultimo_Blanco, CDbl(Fila_Digitacion("FACTOR")))
                                End If

                                If Unidad = "%" Then
                                    Resultado = Resultado / 10000
                                End If
                                If Unidad = "meq/l" Then
                                    Resultado = Resultado / Peso_Atomico
                                End If
                                If Unidad = "meq/100g" Then
                                    Resultado = Resultado / (Peso_Atomico * 10)
                                End If
                                If Unidad = "g/kg" Then
                                    Resultado = Resultado / 1000
                                End If
                                If Unidad = "mg/100g" Then
                                    Resultado = Resultado / 10
                                End If

                                If Fila_Digitacion("OT_NLABX") <> "Blanco1" Then
                                    With SP
                                        .Inicializar()
                                        .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                                        .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                                        Mascara = .EjecutarEscalar("usp_RescataMascara")
                                    End With
                                End If


                                Fila_Digitacion("RESULTADO") = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))

                            Else
                                Fila_Digitacion("LECTURA") = 0
                            End If

                        End If
                        Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)

                    End If
                    Numero = 0
                End While
                myReader4.Close()
                GoTo SaltoxIngresoDup
            End If



            If Tit_Formula = "Colorimétrico" Then

                FactorE = CDbl(Txt_LectFactDilucion.Text)
                MasaE = CDbl(Txt_LectPesoMuestra.Text)
                VolExtE = CDbl(Txt_LectAforo.Text)
                If Txt_LectVolAlicuota.Text = "" Then Txt_LectVolAlicuota.Text = 0
                VolAliE = CDbl(Txt_LectVolAlicuota.Text)
                If Txt_LectVolAforoAlic.Text = "" Then Txt_LectVolAforoAlic.Text = 0
                AforoE = CDbl(Txt_LectVolAforoAlic.Text)

                If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
                    Cjto_Tablas1.Tables("DIGITACION").Clear()
                    query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
                    Dim myCommand As New SqlCommand(query, SqlConn)
                    SqlConn.Open()
                    Dim myReader As SqlDataReader = myCommand.ExecuteReader()
                    While myReader.Read()
                        Mypos = InStr(myReader.GetString(0), "Blanco")
                        If Mypos > 0 Then GoTo Jump

                        Mypos = InStr(myReader.GetString(0), "S")
                        If Mypos > 0 Then GoTo Jump

                        Mypos = InStr(myReader.GetString(0), "T")
                        If Mypos > 0 Then GoTo Jump

                        Mypos = InStr(myReader.GetString(0), "D")
                        If Mypos > 0 Then GoTo Jump


                        If myReader.GetString(0) >= CInt(Txt_NLabDesde.Text) And myReader.GetString(0) <= CInt(Txt_NLabHasta.Text) Then
                            EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, CodAna)
                            If EstaRevisado = 0 Then
Jump:                           Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                                Fila_Digitacion("OT_NLABX") = myReader.GetString(0)
                                Fila_Digitacion("FACTOR") = FactorE
                                Fila_Digitacion("MASA_MUE") = MasaE
                                Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                                Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                                Fila_Digitacion("AFORO_ALI") = AforoE
                                Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                            ElseIf EstaRevisado = 1 Then
                                MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                            End If

                        End If
                    End While
                    myReader.Close()
                    GoTo SaltoxIngresoDup
                End If

                Cjto_Tablas1.Tables("DIGITACION").Clear()
                Son_Blancos = "S"
                Cuenta_Blancos = 0
                query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=" & CodAna & "ORDER BY PRIORIDAD"
                Dim myCommand1 As New SqlCommand(query, SqlConn)
                SqlConn.Open()
                Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
                While myReader1.Read()

                    Carga_Digitacion = "N"
                    Mypos = 0

                    Mypos = InStr(myReader1.GetString(0), "Blanco")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga

                    Mypos = InStr(myReader1.GetString(0), "S")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                    Mypos = InStr(myReader1.GetString(0), "T")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                    Mypos = InStr(myReader1.GetString(0), "D")
                    If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                    If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
                    If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
                    If Mypos = 0 Then
                        EstaRevisado = 0
                        EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, CodAna)
                        If EstaRevisado = 1 Then
                            MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                            Bt_Graba.Enabled = False
                            GoTo SaltoxIngresoDup
                        End If
                    End If
                    If Carga_Digitacion = "S" Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                        Mypos = InStr(myReader1.GetString(0), "Blanco")
                        If Mypos > 0 Then
                            Cuenta_Blancos = Cuenta_Blancos + 1
                        End If

                        Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                        If Mypos = 0 Then
                            Fila_Digitacion("FACTOR") = FactorE
                            Fila_Digitacion("MASA_MUE") = MasaE
                            Fila_Digitacion("VOLUMEN_AFO") = VolExtE
                            Fila_Digitacion("VOLUMEN_ALI") = VolAliE
                            Fila_Digitacion("AFORO_ALI") = AforoE
                        End If
                        Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                    End If

                End While
                myReader1.Close()
            End If






SaltoxIngresoDup:

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("error en proc: Carga_Planilla " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Carga_Planilla2()
        Try
            Dim Fila_Digitacion, Fila_Carga As DataRow
            Dim Carga_Digitacion, query, Son_Blancos As String
            Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
            Dim FactorE As Double
            Dim Indice As Integer
            Dim SqlConn As New SqlConnection
            SqlConn = New SqlConnection(Conexion1)

            If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
                Cjto_Tablas1.Tables("DIGITACION").Clear()
                query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "'  and tmu_codigo=" & CodAna & "  ORDER BY PRIORIDAD"
                Dim myCommand As New SqlCommand(query, SqlConn)
                SqlConn.Open()
                Dim myReader As SqlDataReader = myCommand.ExecuteReader()
                While myReader.Read()
                    Mypos = InStr(myReader.GetString(0), "Blanco")
                    If Mypos > 0 Then GoTo jump

                    Mypos = InStr(myReader.GetString(0), "S")
                    If Mypos > 0 Then GoTo jump

                    Mypos = InStr(myReader.GetString(0), "T")
                    If Mypos > 0 Then GoTo jump

                    Mypos = InStr(myReader.GetString(0), "D")
                    If Mypos > 0 Then GoTo jump

                    If myReader.GetString(0) >= CInt(Txt_NLabDesde.Text) And myReader.GetString(0) <= CInt(Txt_NLabHasta.Text) Then
                        EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, CodAna)
                        If EstaRevisado = 0 Then
Jump:                       Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                            Fila_Digitacion("OT_NLABX") = myReader.GetString(0)
                            Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                        ElseIf EstaRevisado = 1 Then
                            MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                        End If
                    End If
                End While
                myReader.Close()
                GoTo SaltoxIngresoDup
            End If

            Cjto_Tablas1.Tables("DIGITACION").Clear()
            Son_Blancos = "S"
            Cuenta_Blancos = 0
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Me.Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo='" & CodAna & "' ORDER BY PRIORIDAD"
            Dim myCommand1 As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
            While myReader1.Read()

                Carga_Digitacion = "N"
                Mypos = 0

                Mypos = InStr(myReader1.GetString(0), "Blanco")
                If Mypos > 0 Then Carga_Digitacion = "S" : GoTo SaltoCarga

                Mypos = InStr(myReader1.GetString(0), "S")
                If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                Mypos = InStr(myReader1.GetString(0), "T")
                If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                Mypos = InStr(myReader1.GetString(0), "D")
                If Mypos > 0 Then Carga_Digitacion = "S" : GoTo saltocarga

                If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
                If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
                If Mypos = 0 Then
                    EstaRevisado = 0
                    EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, CodAna)
                End If

                If EstaRevisado = 0 Then
                    Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                    Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                    Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                ElseIf EstaRevisado = 1 Then
                    MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
                End If

                'If Carga_Digitacion = "S" Then
                '    Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                '    Mypos = InStr(myReader1.GetString(0), "Blanco")
                '    If Mypos > 0 Then
                '        Cuenta_Blancos = Cuenta_Blancos + 1
                '    Else
                '        If Son_Blancos = "S" And Cuenta_Blancos > 1 Then
                '            Fila_Digitacion("OT_NLABX") = "BLPromedio"
                '            Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                '            Son_Blancos = "N"
                '            Fila_Digitacion = Cjto_Tablas1.Tables("DIGITACION").NewRow
                '        End If
                '    End If

                '    Fila_Digitacion("OT_NLABX") = myReader1.GetString(0)
                '    Cjto_Tablas1.Tables("DIGITACION").Rows.Add(Fila_Digitacion)
                'End If

            End While
            myReader1.Close()
SaltoxIngresoDup:

            SqlConn.Close()
        Catch ex As Exception
            MsgBox("error en proc: Carga_Planilla2 " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub
#Region "Curva"
    Private Sub BtCalculaCoe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtCalculaCoe.Click
        Dim ARRIBA, BAJO1, BAJO2, BAJO3, RCoe, BsumalogYX, BsumaLogY, BsumaLogY2, BsumaX, BsumaX2, BsumalogXY, BsumaLogX, BsumaLogX2, BsumaY, BsumaY2 As Double
        Dim NNsumaLogYX, NNsumaX, NNsumaLogY, NNsumaX2, NNsumalogY2 As Double
        Dim A1, A2, B1, B2, B3, B4 As Double
        Dim n As Integer
        Try
            If Tit_Formula = "Colorimétrico" Then
                BsumalogXY = sumalogXY(n)
                BsumaLogX = sumalogX()
                BsumaLogX2 = sumalogX2()
                BsumaY = sumaY()
                BsumaY2 = sumaY2()

                A1 = n * BsumalogXY
                A2 = BsumaY * BsumaLogX
                ARRIBA = A2 - A1

                B1 = n * BsumaLogX2
                B2 = Pow(BsumaLogX, 2)
                BAJO1 = B1 - B2

                B3 = n * BsumaY2
                B4 = Pow(BsumaY, 2)
                BAJO2 = B3 - B4

                BAJO3 = Pow(BAJO1 * BAJO2, 0.5)

                RCoe = ARRIBA / BAJO3
                LabResultado.Text = Round(RCoe, 4)
            End If

            If Tit_Formula = "Potenciométrico" Or Elemento = "NNO3" Then
                NNsumaLogYX = NsumalogYX(n) * -1
                NNsumaX = NsumaX()
                NNsumaLogY = NsumalogY() * -1
                NNsumaX2 = NsumaX2()
                NNsumalogY2 = NsumalogY2()

                A1 = n * NNsumaLogYX
                A2 = NNsumaX * NNsumaLogY
                ARRIBA = A1 - A2

                B1 = n * NNsumaX2
                B2 = Pow(NNsumaX, 2)
                BAJO1 = B1 - B2

                B3 = n * NNsumalogY2
                B4 = Pow(NNsumaLogY, 2)
                BAJO2 = B3 - B4

                BAJO3 = Pow(BAJO1 * BAJO2, 0.5)

                RCoe = ARRIBA / BAJO3

                LabResultado.Text = Round(RCoe, 4)
            End If

            Call Graba_Curva()
            MsgBox("Calculo Realizado")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub Graba_Curva()
        Dim te1, te2, te3, te4, te5, te6, te7, te8, te9, t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, te10, tr As String
        Dim Mypos As Integer
        Dim query As String
        Dim con1 As New SqlConnection(Conexion1)
        Mypos = InStr(txt_pyb_tram1.Text, ",")
        If Mypos > 0 Then t1 = Mid(txt_pyb_tram1.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram1.Text, Mypos + 1) Else t1 = txt_pyb_tram1.Text
        Mypos = InStr(txt_pyb_tram2.Text, ",")
        If Mypos > 0 Then t2 = Mid(txt_pyb_tram2.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram2.Text, Mypos + 1) Else t2 = txt_pyb_tram2.Text
        Mypos = InStr(txt_pyb_tram3.Text, ",")
        If Mypos > 0 Then t3 = Mid(txt_pyb_tram3.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram3.Text, Mypos + 1) Else t3 = txt_pyb_tram3.Text
        Mypos = InStr(txt_pyb_tram4.Text, ",")
        If Mypos > 0 Then t4 = Mid(txt_pyb_tram4.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram4.Text, Mypos + 1) Else t4 = txt_pyb_tram4.Text
        Mypos = InStr(txt_pyb_tram5.Text, ",")
        If Mypos > 0 Then t5 = Mid(txt_pyb_tram5.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram5.Text, Mypos + 1) Else t5 = txt_pyb_tram5.Text
        Mypos = InStr(txt_pyb_tram6.Text, ",")
        If Mypos > 0 Then t6 = Mid(txt_pyb_tram6.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram6.Text, Mypos + 1) Else t6 = txt_pyb_tram6.Text
        Mypos = InStr(txt_pyb_tram7.Text, ",")
        If Mypos > 0 Then t7 = Mid(txt_pyb_tram7.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram7.Text, Mypos + 1) Else t7 = txt_pyb_tram7.Text
        Mypos = InStr(txt_pyb_tram8.Text, ",")
        If Mypos > 0 Then t8 = Mid(txt_pyb_tram8.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram8.Text, Mypos + 1) Else t8 = txt_pyb_tram8.Text
        Mypos = InStr(txt_pyb_tram9.Text, ",")
        If Mypos > 0 Then t9 = Mid(txt_pyb_tram9.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram9.Text, Mypos + 1) Else t9 = txt_pyb_tram9.Text
        Mypos = InStr(txt_pyb_tram10.Text, ",")
        If Mypos > 0 Then t10 = Mid(txt_pyb_tram10.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_tram10.Text, Mypos + 1) Else t10 = txt_pyb_tram10.Text
        If txt_pyb_tram10.Text = "" Then t10 = 0

        Mypos = InStr(txt_pyb_elem1.Text, ",")
        If Mypos > 0 Then te1 = Mid(txt_pyb_elem1.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem1.Text, Mypos + 1) Else te1 = txt_pyb_elem1.Text
        Mypos = InStr(txt_pyb_elem2.Text, ",")
        If Mypos > 0 Then te2 = Mid(txt_pyb_elem2.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem2.Text, Mypos + 1) Else te2 = txt_pyb_elem2.Text
        Mypos = InStr(txt_pyb_elem3.Text, ",")
        If Mypos > 0 Then te3 = Mid(txt_pyb_elem3.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem3.Text, Mypos + 1) Else te3 = txt_pyb_elem3.Text
        Mypos = InStr(txt_pyb_elem4.Text, ",")
        If Mypos > 0 Then te4 = Mid(txt_pyb_elem4.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem4.Text, Mypos + 1) Else te4 = txt_pyb_elem4.Text
        Mypos = InStr(txt_pyb_elem5.Text, ",")
        If Mypos > 0 Then te5 = Mid(txt_pyb_elem5.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem5.Text, Mypos + 1) Else te5 = txt_pyb_elem5.Text
        Mypos = InStr(txt_pyb_elem6.Text, ",")
        If Mypos > 0 Then te6 = Mid(txt_pyb_elem6.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem6.Text, Mypos + 1) Else te6 = txt_pyb_elem6.Text
        Mypos = InStr(txt_pyb_elem7.Text, ",")
        If Mypos > 0 Then te7 = Mid(txt_pyb_elem7.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem7.Text, Mypos + 1) Else te7 = txt_pyb_elem7.Text
        Mypos = InStr(txt_pyb_elem8.Text, ",")
        If Mypos > 0 Then te8 = Mid(txt_pyb_elem8.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem8.Text, Mypos + 1) Else te8 = txt_pyb_elem8.Text
        Mypos = InStr(txt_pyb_elem9.Text, ",")
        If Mypos > 0 Then te9 = Mid(txt_pyb_elem9.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem9.Text, Mypos + 1) Else te9 = txt_pyb_elem9.Text
        Mypos = InStr(txt_pyb_elem10.Text, ",")
        If Mypos > 0 Then te10 = Mid(txt_pyb_elem10.Text, 1, Mypos - 1) & "." & Mid(txt_pyb_elem10.Text, Mypos + 1) Else te10 = txt_pyb_elem10.Text
        If txt_pyb_elem10.Text = "" Then te10 = 0

        Mypos = InStr(LabResultado.Text, ",")
        If Mypos > 0 Then tr = Mid(LabResultado.Text, 1, Mypos - 1) & "." & Mid(LabResultado.Text, Mypos + 1) Else tr = LabResultado.Text

        If txt_pyb_elem1.Text = "" Then te1 = 0
        If txt_pyb_elem2.Text = "" Then te2 = 0
        If txt_pyb_elem3.Text = "" Then te3 = 0
        If txt_pyb_elem4.Text = "" Then te4 = 0
        If txt_pyb_elem5.Text = "" Then te5 = 0
        If txt_pyb_elem6.Text = "" Then te6 = 0
        If txt_pyb_elem7.Text = "" Then te7 = 0
        If txt_pyb_elem8.Text = "" Then te8 = 0
        If txt_pyb_elem9.Text = "" Then te9 = 0
        If txt_pyb_elem10.Text = "" Then te10 = 0

        If txt_pyb_tram1.Text = "" Then t1 = 0
        If txt_pyb_tram2.Text = "" Then t2 = 0
        If txt_pyb_tram3.Text = "" Then t3 = 0
        If txt_pyb_tram4.Text = "" Then t4 = 0
        If txt_pyb_tram5.Text = "" Then t5 = 0
        If txt_pyb_tram6.Text = "" Then t6 = 0
        If txt_pyb_tram7.Text = "" Then t7 = 0
        If txt_pyb_tram8.Text = "" Then t8 = 0
        If txt_pyb_tram9.Text = "" Then t9 = 0
        If txt_pyb_tram10.Text = "" Then t10 = 0

        con1.Open()
        query = "INSERT INTO CURVA_STANDAR (FECHA_CREACION,TMU_CODIGO,ELE_CODIGO,CONCENTRACION1,LECTURA1,CONCENTRACION2,LECTURA2,CONCENTRACION3,LECTURA3" & _
                                ",CONCENTRACION4,LECTURA4,CONCENTRACION5,LECTURA5,CONCENTRACION6,LECTURA6,CONCENTRACION7,LECTURA7" & _
                                ",CONCENTRACION8,LECTURA8,CONCENTRACION9,LECTURA9,CONCENTRACION10,LECTURA10,RESULTADO_CURVA) " & _
                                "VALUES ('" & Me.Dtp_FechaDigitacion.Text & "','" & CodAna & "','" & Elemento & "'," & _
                                te1 & "," & t1 & "," & _
                                te2 & "," & t2 & "," & _
                                te3 & "," & t3 & "," & _
                                te4 & "," & t4 & "," & _
                                te5 & "," & t5 & "," & _
                                te6 & "," & t6 & "," & _
                                te7 & "," & t7 & "," & _
                                te8 & "," & t8 & "," & _
                                te9 & "," & t9 & "," & _
                                te10 & "," & t10 & "," & _
                                tr & ")"
        Dim myCommand1 As New SqlCommand(query, con1)
        Dim myReader1 As SqlDataReader
        Try
            myReader1 = myCommand1.ExecuteReader()
            myReader1.Close()
        Catch ex As Exception
            query = "UPDATE CURVA_STANDAR SET CONCENTRACION1=" & te1 & ",LECTURA1=" & t1 & "," & _
                                            "CONCENTRACION2=" & te2 & ",LECTURA2=" & t2 & "," & _
                                            "CONCENTRACION3=" & te3 & ",LECTURA3=" & t3 & "," & _
                                            "CONCENTRACION4=" & te4 & ",LECTURA4=" & t4 & "," & _
                                            "CONCENTRACION5=" & te5 & ",LECTURA5=" & t5 & "," & _
                                            "CONCENTRACION6=" & te6 & ",LECTURA6=" & t6 & "," & _
                                            "CONCENTRACION7=" & te7 & ",LECTURA7=" & t7 & "," & _
                                            "CONCENTRACION8=" & te8 & ",LECTURA8=" & t8 & "," & _
                                            "CONCENTRACION9=" & te9 & ",LECTURA9=" & t9 & "," & _
                                            "CONCENTRACION10=" & te10 & ",LECTURA10=" & t10 & "," & _
                                            "RESULTADO_CURVA=" & tr & _
                                            " WHERE FECHA_CREACION=" & "'" & Me.Dtp_FechaDigitacion.Text & "' AND TMU_CODIGO= & '" & CodAna & "' AND  ELE_CODIGO=" & "'" & Elemento & "'"
            Dim myCommand As New SqlCommand(query, con1)
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            myReader.Close()
        End Try
        con1.Close()
    End Sub

    Public Sub Rescata_Curva()
        Dim query As String
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        query = "Select CONCENTRACION1,LECTURA1,CONCENTRACION2,LECTURA2,CONCENTRACION3,LECTURA3,CONCENTRACION4,LECTURA4,CONCENTRACION5,LECTURA5," & _
        "CONCENTRACION6,LECTURA6,CONCENTRACION7,LECTURA7,CONCENTRACION8,LECTURA8,CONCENTRACION9,LECTURA9,CONCENTRACION10,LECTURA10,RESULTADO_CURVA " & _
        "FROM CURVA_STANDAR WHERE ELE_CODIGO=" & "'" & Elemento & "' ORDER BY FECHA_CREACION DESC"
        Dim myCommand2 As New SqlCommand(query, con)
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        Try
            myReader2.Read()
            txt_pyb_elem1.Text = myReader2.GetDouble(0)
            'If txt_pyb_elem1.Text = 0 Then txt_pyb_elem1.Text = ""
            txt_pyb_tram1.Text = myReader2.GetDouble(1)
            If txt_pyb_tram1.Text = 0 Then txt_pyb_tram1.Text = ""

            txt_pyb_elem2.Text = myReader2.GetDouble(2)
            If txt_pyb_elem2.Text = 0 Then txt_pyb_elem2.Text = ""
            txt_pyb_tram2.Text = myReader2.GetDouble(3)
            If txt_pyb_tram2.Text = 0 Then txt_pyb_tram2.Text = ""

            txt_pyb_elem3.Text = myReader2.GetDouble(4)
            If txt_pyb_elem3.Text = 0 Then txt_pyb_elem3.Text = ""
            txt_pyb_tram3.Text = myReader2.GetDouble(5)
            If txt_pyb_tram3.Text = 0 Then txt_pyb_tram3.Text = ""

            txt_pyb_elem4.Text = myReader2.GetDouble(6)
            If txt_pyb_elem4.Text = 0 Then txt_pyb_elem4.Text = ""
            txt_pyb_tram4.Text = myReader2.GetDouble(7)
            If txt_pyb_tram4.Text = 0 Then txt_pyb_tram4.Text = ""

            txt_pyb_elem5.Text = myReader2.GetDouble(8)
            If txt_pyb_elem5.Text = 0 Then txt_pyb_elem5.Text = ""
            txt_pyb_tram5.Text = myReader2.GetDouble(9)
            If txt_pyb_tram5.Text = 0 Then txt_pyb_tram5.Text = ""

            txt_pyb_elem6.Text = myReader2.GetDouble(10)
            If txt_pyb_elem6.Text = 0 Then txt_pyb_elem6.Text = ""
            txt_pyb_tram6.Text = myReader2.GetDouble(11)
            If txt_pyb_tram6.Text = 0 Then txt_pyb_tram6.Text = ""

            txt_pyb_elem7.Text = myReader2.GetDouble(12)
            If txt_pyb_elem7.Text = 0 Then txt_pyb_elem7.Text = ""
            txt_pyb_tram7.Text = myReader2.GetDouble(13)
            If txt_pyb_tram7.Text = 0 Then txt_pyb_tram7.Text = ""

            txt_pyb_elem8.Text = myReader2.GetDouble(14)
            If txt_pyb_elem8.Text = 0 Then txt_pyb_elem8.Text = ""
            txt_pyb_tram8.Text = myReader2.GetDouble(15)
            If txt_pyb_tram8.Text = 0 Then txt_pyb_tram8.Text = ""

            txt_pyb_elem9.Text = myReader2.GetDouble(16)
            If txt_pyb_elem9.Text = 0 Then txt_pyb_elem9.Text = ""
            txt_pyb_tram9.Text = myReader2.GetDouble(17)
            If txt_pyb_tram9.Text = 0 Then txt_pyb_tram9.Text = ""

            If myReader2.GetDouble(18) <> 0 Then txt_pyb_elem10.Text = myReader2.GetDouble(18)
            If myReader2.GetDouble(19) <> 0 Then txt_pyb_tram10.Text = myReader2.GetDouble(19)
            LabResultado.Text = myReader2.GetDouble(20)
            myReader2.Close()
        Catch ex As Exception

        End Try
        con.Close()
    End Sub

#End Region

    Private Sub Bt_Imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprime.Click
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel, objHojaExcel1 As Excel.Worksheet
        Dim destino, destino2, Entrando, CambioCol As String
        Dim fila As String
        Dim fd, anal, dig, f_anal As String

        Dim FILA_ELEMENTO As DataRow
        destino = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2008\040  DIGITACION Y CALCULO RESULTADOS\Formato Base\Copia de Formatos Resultados.xls"
        If CodAna = 1000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Foliar\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 2000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Tejido\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 3000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Agua\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 4000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Suelo\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 5000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Fer.Quimico\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 6000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Fer.Organico\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        ElseIf CodAna = 8000 Then
            destino2 = "F:\Mis documentos\Graba Planillas\Fer.Organico\" & simbolo & " " & Txt_NLabInicial.Text & ".xls"
        End If


        Try
            FileCopy(destino, destino2)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Dim fila_BordeIni As Integer
        m_Excel = CreateObject("EXCEL.APPLICATION")
        objLibroExcel = m_Excel.Workbooks.Open(destino2)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()

        Dim Fila_c, Fila_p, Fila_f, Fila_r, Fila_t, Fila_q, Fila_m, Fila_z As Integer
        Fila_c = 6
        Fila_p = 9
        Fila_f = 9
        Fila_r = 23
        Fila_t = 8
        Fila_q = 8
        Fila_m = 13
        Fila_z = 14
        Entrando = "S"
        CambioCol = "N"


        Call Imprime_EncPag(objHojaExcel)
        Call Imprime_PiePag(objHojaExcel)

        If Tit_Formula = "Colorimétrico" Then
            Call Encavezado_CurvaColorimetrica(objHojaExcel, Metodo, Metodo2, CalFact)
            Call Imprime_ResultadosColorimetricos(objHojaExcel, Fila_Exp + 5)

        ElseIf Tit_Formula = "EAA" Then
            Call Encavezado_EAA(objHojaExcel, Metodo, Metodo2, CalFact)
            Call Imprime_ResultadoEAA(objHojaExcel, Fila_Exp + 5)

        ElseIf Tit_Formula = "Volumétrico" Or Tit_Formula = "VolumétricoNNH4" Then
            Call Encavezado_Volumetrico(objHojaExcel, Metodo, Metodo2, CalFact)
            Call Imprime_ResultadosVolumetricos(objHojaExcel, Fila_Exp + 5)

        ElseIf Tit_Formula = "Potenciométrico" Then
            If Nombre = "N-Nítrico" Then
                Call Encavezado_CurvaColorimetrica(objHojaExcel, Metodo, Metodo2, CalFact)
                Call Imprime_ResultadosColorimetricos(objHojaExcel, Fila_Exp + 5)
            Else
                Call Encavezado_Volumetrico(objHojaExcel, Metodo, Metodo2, CalFact)
                Call Imprime_ResultadosVolumetricos(objHojaExcel, Fila_Exp + 5)
            End If
        Else
            Call Imprime_ResultadosLectura(objHojaExcel, 19)
        End If

        ' ++++++++++++++        Codigo de Formulas Potenciométricas           ++++++++++++++++

        'Call Encavezado_CurvaPotenciometrica(objHojaExcel, Metodo, Metodo2, CalFact)
        'If Fila_Exp < 53 And CambioCol = "N" Then
        '    Call Imprime_ResultadosPotenciometricos1(objHojaExcel, Fila_Exp + 5)
        '    CambioCol = "S"
        'End If

        'If Fila_Exp >= 53 And CambioCol = "S" Then
        '    Call Imprime_ResultadosPotenciometricos2(objHojaExcel, Fila_Exp + 5)
        'End If


        Bt_Graba.Enabled = True



    End Sub

#Region "Impresion de datos Digitados"



    Private Sub Imprime_EncPag(ByVal objHojaExcel As Excel.Worksheet)
        Dim Mat As String
        Dim fecha As Date
        Dim Fila_E As Integer = 2
        Dim Fila_I As Integer = 6
        Fila_ini = Fila_E
        Fila_ini2 = Fila_I
        If CodAna = 1000 Then
            Mat = "Foliar"
        ElseIf CodAna = 2000 Then
            Mat = "Tejidos"
        ElseIf CodAna = 3000 Then
            Mat = "Agua"
        ElseIf CodAna = "4000" Then
            Mat = "Suelo"
        End If
        ' Imprecion de Encavezado de la Planilla

        objHojaExcel.Range("AI" & Fila_E.ToString & ":BE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_E.ToString).Value = "Registro Resultados"
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("AI" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("AI" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AI" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BG" & Fila_E.ToString & ":BM" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_E.ToString).Value = "Análisis"
        objHojaExcel.Range("BG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("BN" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("BN" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BN" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & Fila_E.ToString & ":CE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BO" & Fila_E.ToString).Value = Nombre
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("BO" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("BO" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BO" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_E.ToString & ":CL" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_E.ToString).Value = "Matriz"
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        objHojaExcel.Range("CM" & Fila_E.ToString & ":CM" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CM" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CM" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CM" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CN" & Fila_E.ToString & ":DB" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CN" & Fila_E.ToString).Value = Mat
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Size = 12
        objHojaExcel.Range("CN" & Fila_E.ToString).Font.Bold = 12
        objHojaExcel.Range("CN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_E.ToString & ":DE" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DC" & Fila_E.ToString).Value = "pág"
        objHojaExcel.Range("DC" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DF" & Fila_E.ToString).Value = "."
        objHojaExcel.Range("DF" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DF" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DF" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DF" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DG" & Fila_E.ToString & ":DJ" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DG" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("DG" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DG" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DG" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DG" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 2


        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Cód.documento"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":BT" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("BV" & Fila_E.ToString & ":CD" & Fila_E.ToString).Merge()
        objHojaExcel.Range("BV" & Fila_E.ToString).Value = "F.digitación"
        objHojaExcel.Range("BV" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BV" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("BV" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BV" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CE" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CE" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CE" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CE" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CE" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_E.ToString & ":CP" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CF" & Fila_E.ToString).Value = FormatDateTime(Dtp_FechaDigitacion.Text, DateFormat.GeneralDate)
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CR" & Fila_E.ToString & ":CY" & Fila_E.ToString).Merge()
        objHojaExcel.Range("CR" & Fila_E.ToString).Value = "F.análisis"
        objHojaExcel.Range("CR" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CR" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CR" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CR" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CZ" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("CZ" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CZ" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("CZ" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CZ" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DA" & Fila_E.ToString & ":DK" & Fila_E.ToString).Merge()
        objHojaExcel.Range("DA" & Fila_E.ToString).Value = FormatDateTime(Dtp_FechaAnalisis.Text, DateFormat.GeneralDate)
        objHojaExcel.Range("DA" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DA" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("DA" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DA" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        Fila_E = Fila_E + 1

        objHojaExcel.Range("A" & Fila_E.ToString & ":M" & Fila_E.ToString).Merge()
        objHojaExcel.Range("A" & Fila_E.ToString).Value = "Metodología"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("N" & Fila_E.ToString).Value = ":"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("N" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("N" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("N" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("O" & Fila_E.ToString & ":CK" & Fila_E.ToString).Merge()
        objHojaExcel.Range("O" & Fila_E.ToString).Value = ""
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_E.ToString).Font.Size = 8
        objHojaExcel.Range("O" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("O" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


    End Sub
    Private Sub Imprime_PiePag(ByVal objHojaExcel As Excel.Worksheet)

        Dim Fila_P As Integer = 59
        Fila_ini = Fila_P

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Analista"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("J" & Fila_P.ToString).Value = Cbx_Analista.Text
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Digita"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AV" & Fila_P.ToString).Value = Cbx_Digitador.Text
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AV" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AV" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Revisa"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CH" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CH" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CH" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CH" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("J" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AV" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AV" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AV" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Cargo"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CH" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CH" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CH" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CH" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_P = Fila_P + 1

        objHojaExcel.Range("A" & Fila_P.ToString & ":G" & Fila_P.ToString).Merge()
        objHojaExcel.Range("A" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("H" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("H" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("H" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("H" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_P.ToString & ":AL" & Fila_P.ToString).Merge()
        objHojaExcel.Range("J" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("AM" & Fila_P.ToString & ":AS" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AM" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AM" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AT" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AT" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AT" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AT" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & Fila_P.ToString & ":BX" & Fila_P.ToString).Merge()
        objHojaExcel.Range("AV" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("AV" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AV" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Salto de Grupo

        objHojaExcel.Range("BY" & Fila_P.ToString & ":CE" & Fila_P.ToString).Merge()
        objHojaExcel.Range("BY" & Fila_P.ToString).Value = "Firma"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BY" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("BY" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BY" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CF" & Fila_P.ToString).Value = ":"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CF" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CF" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CF" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CH" & Fila_P.ToString & ":DJ" & Fila_P.ToString).Merge()
        objHojaExcel.Range("CH" & Fila_P.ToString).Value = ""
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CH" & Fila_P.ToString).Font.Size = 8
        objHojaExcel.Range("CH" & Fila_P.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CH" & Fila_P.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '                                   Imprime Bordes

        'BORDES_IZQ(objHojaExcel, "A", Fila_ini, Fila_ini + 3)
        'BORDES_DER(objHojaExcel, "DJ", Fila_ini, Fila_ini + 3)
        'BORDES(objHojaExcel, Fila_ini, Fila_ini, "A", "DJ")
        'BORDES2(objHojaExcel, Fila_ini, Fila_ini, "A", "DJ")
        'BORDES2(objHojaExcel, Fila_ini + 4, Fila_ini + 4, "A", "DJ")
        'BORDES_DER(objHojaExcel, "AL", Fila_ini, Fila_ini + 3)
        'BORDES_DER(objHojaExcel, "BX", Fila_ini, Fila_ini + 3)

    End Sub
    Private Sub Encavezado_CurvaColorimetrica(ByVal objHojaExcel As Excel.Worksheet, ByVal Formula As String, ByVal Formula2 As String, ByVal Fdil As String)
        Dim Fila_A As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Fila_Ini, Fila_Ini1 As Integer

        objHojaExcel.Range("A" & Fila_A.ToString & ":M" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_A.ToString & ":DJ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_A.ToString).Value = "Datos dilución"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula2
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Fdil
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 2

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Curva calibración"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1
        Fila_Ini1 = Fila_A


        objHojaExcel.Range("A" & Fila_A.ToString & ":P" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Concentración(ppm)"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila_A.ToString & ":V" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Q" & Fila_A.ToString).Value = txt_pyb_elem1.Text
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Q" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Q" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila_A.ToString & ":AB" & Fila_A.ToString).Merge()
        objHojaExcel.Range("W" & Fila_A.ToString).Value = txt_pyb_elem2.Text
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("W" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("W" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila_A.ToString & ":AH" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AC" & Fila_A.ToString).Value = txt_pyb_elem3.Text
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AC" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AC" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila_A.ToString & ":AN" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_A.ToString).Value = txt_pyb_elem4.Text
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AI" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AI" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AO" & Fila_A.ToString & ":AT" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AO" & Fila_A.ToString).Value = txt_pyb_elem5.Text
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AO" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AO" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem6.Text = "" Then txt_pyb_elem6.Text = 0
        objHojaExcel.Range("AU" & Fila_A.ToString & ":AZ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AU" & Fila_A.ToString).Value = txt_pyb_elem6.Text
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AU" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AU" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem7.Text = "" Then txt_pyb_elem7.Text = 0
        objHojaExcel.Range("BA" & Fila_A.ToString & ":BF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BA" & Fila_A.ToString).Value = txt_pyb_elem7.Text
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BA" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BA" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem8.Text = "" Then txt_pyb_elem8.Text = 0
        objHojaExcel.Range("BG" & Fila_A.ToString & ":BL" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_A.ToString).Value = txt_pyb_elem8.Text
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem9.Text = "" Then txt_pyb_elem9.Text = 0
        objHojaExcel.Range("BM" & Fila_A.ToString & ":BR" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BM" & Fila_A.ToString).Value = txt_pyb_elem9.Text
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BM" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BM" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem10.Text = "" Then txt_pyb_elem10.Text = 0
        objHojaExcel.Range("BS" & Fila_A.ToString & ":BX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BS" & Fila_A.ToString).Value = txt_pyb_elem10.Text
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BS" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":P" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Lectura(absorbancia)"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila_A.ToString & ":V" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Q" & Fila_A.ToString).Value = txt_pyb_tram1.Text
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Q" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Q" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila_A.ToString & ":AB" & Fila_A.ToString).Merge()
        objHojaExcel.Range("W" & Fila_A.ToString).Value = txt_pyb_tram2.Text
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("W" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("W" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila_A.ToString & ":AH" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AC" & Fila_A.ToString).Value = txt_pyb_tram3.Text
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AC" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AC" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila_A.ToString & ":AN" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_A.ToString).Value = txt_pyb_tram4.Text
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AI" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AI" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram5.Text = "" Then txt_pyb_tram5.Text = 0
        objHojaExcel.Range("AO" & Fila_A.ToString & ":AT" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AO" & Fila_A.ToString).Value = txt_pyb_tram5.Text
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AO" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AO" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram6.Text = "" Then txt_pyb_tram6.Text = 0
        objHojaExcel.Range("AU" & Fila_A.ToString & ":AZ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AU" & Fila_A.ToString).Value = txt_pyb_tram6.Text
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AU" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AU" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram7.Text = "" Then txt_pyb_tram7.Text = 0
        objHojaExcel.Range("BA" & Fila_A.ToString & ":BF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BA" & Fila_A.ToString).Value = txt_pyb_tram7.Text
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BA" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BA" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram8.Text = "" Then txt_pyb_tram8.Text = 0
        objHojaExcel.Range("BG" & Fila_A.ToString & ":BL" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_A.ToString).Value = txt_pyb_tram8.Text
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram9.Text = "" Then txt_pyb_tram9.Text = 0
        objHojaExcel.Range("BM" & Fila_A.ToString & ":BR" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BM" & Fila_A.ToString).Value = txt_pyb_tram9.Text
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BM" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BM" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram10.Text = "" Then txt_pyb_tram10.Text = 0
        objHojaExcel.Range("BS" & Fila_A.ToString & ":BX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BS" & Fila_A.ToString).Value = txt_pyb_tram10.Text
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BS" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":H" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Intercepto"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("I" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_A.ToString & ":Q" & Fila_A.ToString).Merge()
        objHojaExcel.Range("J" & Fila_A.ToString).Value = ""
        objHojaExcel.Range("J" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Y" & Fila_A.ToString & ":AF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Y" & Fila_A.ToString).Value = "Pendiente"
        objHojaExcel.Range("Y" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Y" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Y" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Y" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("AG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AH" & Fila_A.ToString & ":AO" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AH" & Fila_A.ToString).Value = ""
        objHojaExcel.Range("AH" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AH" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AH" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AH" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AQ" & Fila_A.ToString & ":AX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AQ" & Fila_A.ToString).Value = "Corr(R2)"
        objHojaExcel.Range("AQ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AQ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AQ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AQ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AY" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("AY" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AY" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AY" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AY" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AZ" & Fila_A.ToString & ":BG" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AZ" & Fila_A.ToString).Value = LabResultado.Text
        objHojaExcel.Range("AZ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AZ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AZ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AZ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Datos Calculo Factor
        Fila_Ini = Fila_D

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa muestra"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectPesoMuestra.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol aforo"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectAforo.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor 1º dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_1ºDilucion.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAlicuota.Text = "" Then Txt_LectVolAlicuota.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectVolAlicuota.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol aforo alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAforoAlic.Text = "" Then Txt_LectVolAforoAlic.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectVolAforoAlic.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor 2º dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_Lect2ºFactor.Text = "" Then Txt_Lect2ºFactor.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_Lect2ºFactor.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectFactDilucion.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Borde

        ' objHojaExcel.Range("CJ" & Fila_Ini.ToString & ":DJ" & Fila_D.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "P", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "V", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AB", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AH", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AN", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AT", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AZ", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BF", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BL", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BR", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BX", Fila_Ini1, Fila_Ini1 + 1)
        BORDES(objHojaExcel, 12, 12, "A", "BX")
        BORDES(objHojaExcel, 13, 13, "A", "BX")
        BORDES(objHojaExcel, 14, 14, "A", "BX")
        BORDES_IZQ(objHojaExcel, "A", Fila_Ini1, Fila_Ini1 + 1)
        BORDES2(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 1, Fila_Ini + 1, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 2, Fila_Ini + 2, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 3, Fila_Ini + 3, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 4, Fila_Ini + 4, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 5, Fila_Ini + 5, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 6, Fila_Ini + 6, "CJ", "DJ")
        BORDES_IZQ(objHojaExcel, "CJ", Fila_Ini, Fila_Ini + 6)
        BORDES_DER(objHojaExcel, "DJ", Fila_Ini, Fila_Ini + 6)
        Fila_Exp = Fila_D
    End Sub
    Private Sub Encavezado_EAA(ByVal objHojaExcel As Excel.Worksheet, ByVal Formula As String, ByVal Formula2 As String, ByVal Fdil As String)
        Dim Fila_A As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Fila_Ini, Fila_Ini1 As Integer

        objHojaExcel.Range("A" & Fila_A.ToString & ":M" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_A.ToString & ":DJ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_A.ToString).Value = "Datos dilución"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula2
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Fdil
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        'Datos del Calculo del Factor

        Fila_Ini = Fila_D

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa muestra"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectPesoMuestra.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol aforo"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectAforo.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor 1º dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_1ºDilucion.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAlicuota.Text = "" Then Txt_LectVolAlicuota.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectVolAlicuota.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol aforo alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAforoAlic.Text = "" Then Txt_LectVolAforoAlic.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectVolAforoAlic.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor 2º dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_Lect2ºFactor.Text = "" Then Txt_Lect2ºFactor.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_Lect2ºFactor.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_LectFactDilucion.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Bordes

        BORDES2(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 1, Fila_Ini + 1, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 2, Fila_Ini + 2, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 3, Fila_Ini + 3, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 4, Fila_Ini + 4, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 5, Fila_Ini + 5, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 6, Fila_Ini + 6, "CJ", "DJ")
        BORDES_IZQ(objHojaExcel, "CJ", Fila_Ini, Fila_Ini + 6)
        BORDES_DER(objHojaExcel, "DJ", Fila_Ini, Fila_Ini + 6)
        Fila_Exp = Fila_D

    End Sub
    Private Sub Encavezado_CurvaPotenciometrica(ByVal objHojaExcel As Excel.Worksheet, ByVal Formula As String, ByVal Formula2 As String, ByVal Fdil As String)
        Dim Fila_A As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Fila_Ini, Fila_Ini1 As Integer

        objHojaExcel.Range("A" & Fila_A.ToString & ":M" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_A.ToString & ":DJ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_A.ToString).Value = "Datos dilución"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula2
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Fdil
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 2

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Curva calibración"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1
        Fila_Ini1 = Fila_A


        objHojaExcel.Range("A" & Fila_A.ToString & ":P" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Concentración(ppm)"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila_A.ToString & ":V" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Q" & Fila_A.ToString).Value = txt_pyb_elem1.Text
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Q" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Q" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila_A.ToString & ":AB" & Fila_A.ToString).Merge()
        objHojaExcel.Range("W" & Fila_A.ToString).Value = txt_pyb_elem2.Text
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("W" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("W" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila_A.ToString & ":AH" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AC" & Fila_A.ToString).Value = txt_pyb_elem3.Text
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AC" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AC" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila_A.ToString & ":AN" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_A.ToString).Value = txt_pyb_elem4.Text
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AI" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AI" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AO" & Fila_A.ToString & ":AT" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AO" & Fila_A.ToString).Value = txt_pyb_elem5.Text
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AO" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AO" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem6.Text = "" Then txt_pyb_elem6.Text = 0
        objHojaExcel.Range("AU" & Fila_A.ToString & ":AZ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AU" & Fila_A.ToString).Value = txt_pyb_elem6.Text
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AU" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AU" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem7.Text = "" Then txt_pyb_elem7.Text = 0
        objHojaExcel.Range("BA" & Fila_A.ToString & ":BF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BA" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BA" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem8.Text = "" Then txt_pyb_elem8.Text = 0
        objHojaExcel.Range("BG" & Fila_A.ToString & ":BL" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_A.ToString).Value = txt_pyb_elem8.Text
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem9.Text = "" Then txt_pyb_elem9.Text = 0
        objHojaExcel.Range("BM" & Fila_A.ToString & ":BR" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BM" & Fila_A.ToString).Value = txt_pyb_elem9.Text
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BM" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BM" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_elem10.Text = "" Then txt_pyb_elem10.Text = 0
        objHojaExcel.Range("BS" & Fila_A.ToString & ":BX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BS" & Fila_A.ToString).Value = txt_pyb_elem10.Text
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BS" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":P" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Lectura(mV)"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Q" & Fila_A.ToString & ":V" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Q" & Fila_A.ToString).Value = txt_pyb_tram1.Text
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Q" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Q" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Q" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("W" & Fila_A.ToString & ":AB" & Fila_A.ToString).Merge()
        objHojaExcel.Range("W" & Fila_A.ToString).Value = txt_pyb_tram2.Text
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("W" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("W" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("W" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AC" & Fila_A.ToString & ":AH" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AC" & Fila_A.ToString).Value = txt_pyb_tram3.Text
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AC" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AC" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AC" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AI" & Fila_A.ToString & ":AN" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AI" & Fila_A.ToString).Value = txt_pyb_tram4.Text
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AI" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AI" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AI" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram5.Text = "" Then txt_pyb_tram5.Text = 0
        objHojaExcel.Range("AO" & Fila_A.ToString & ":AT" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AO" & Fila_A.ToString).Value = txt_pyb_tram5.Text
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AO" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AO" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram6.Text = "" Then txt_pyb_tram6.Text = 0
        objHojaExcel.Range("AU" & Fila_A.ToString & ":AZ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AU" & Fila_A.ToString).Value = txt_pyb_tram6.Text
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AU" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AU" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AU" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram7.Text = "" Then txt_pyb_tram7.Text = 0
        objHojaExcel.Range("BA" & Fila_A.ToString & ":BF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BA" & Fila_A.ToString).Value = txt_pyb_tram7.Text
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BA" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BA" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BA" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram8.Text = "" Then txt_pyb_tram8.Text = 0
        objHojaExcel.Range("BG" & Fila_A.ToString & ":BL" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_A.ToString).Value = txt_pyb_tram8.Text
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram9.Text = "" Then txt_pyb_tram9.Text = 0
        objHojaExcel.Range("BM" & Fila_A.ToString & ":BR" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BM" & Fila_A.ToString).Value = txt_pyb_tram9.Text
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BM" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BM" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BM" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If txt_pyb_tram10.Text = "" Then txt_pyb_tram10.Text = 0
        objHojaExcel.Range("BS" & Fila_A.ToString & ":BX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("BS" & Fila_A.ToString).Value = txt_pyb_tram10.Text
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BS" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("BS" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("BS" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":H" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Intercepto"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("I" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("I" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("I" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("J" & Fila_A.ToString & ":Q" & Fila_A.ToString).Merge()
        objHojaExcel.Range("J" & Fila_A.ToString).Value = ""
        objHojaExcel.Range("J" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("J" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("J" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("J" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("Y" & Fila_A.ToString & ":AF" & Fila_A.ToString).Merge()
        objHojaExcel.Range("Y" & Fila_A.ToString).Value = "Pendiente"
        objHojaExcel.Range("Y" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("Y" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("Y" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("Y" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("AG" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AG" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AG" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AH" & Fila_A.ToString & ":AO" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AH" & Fila_A.ToString).Value = ""
        objHojaExcel.Range("AH" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AH" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AH" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AH" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AQ" & Fila_A.ToString & ":AX" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AQ" & Fila_A.ToString).Value = "Corr(R2)"
        objHojaExcel.Range("AQ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AQ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AQ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AQ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AY" & Fila_A.ToString).Value = ":"
        objHojaExcel.Range("AY" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AY" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AY" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AY" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AZ" & Fila_A.ToString & ":BG" & Fila_A.ToString).Merge()
        objHojaExcel.Range("AZ" & Fila_A.ToString).Value = LabResultado.Text
        objHojaExcel.Range("AZ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AZ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("AZ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("AZ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Datos Calculo Factor
        Fila_Ini = Fila_D

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa muestra"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3MasaMuestra.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol extractante"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3VolExt.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor extracción"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3FacExt.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAlicuota.Text = "" Then Txt_LectVolAlicuota.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3VolAli.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Vol aforo alicuota"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(ml)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_LectVolAforoAlic.Text = "" Then Txt_LectVolAforoAlic.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3VolAfoAli.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor 2º dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        If Txt_Lect2ºFactor.Text = "" Then Txt_Lect2ºFactor.Text = 0
        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3Fac2dil.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor dilución"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = Txt_NNO3FacDil.Text
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 9
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Borde

        ' objHojaExcel.Range("CJ" & Fila_Ini.ToString & ":DJ" & Fila_D.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "P", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "V", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AB", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AH", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AN", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AT", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "AZ", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BF", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BL", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BR", Fila_Ini1, Fila_Ini1 + 1)
        BORDES_DER(objHojaExcel, "BX", Fila_Ini1, Fila_Ini1 + 1)
        BORDES(objHojaExcel, 12, 12, "A", "BX")
        BORDES(objHojaExcel, 13, 13, "A", "BX")
        BORDES(objHojaExcel, 14, 14, "A", "BX")
        BORDES_IZQ(objHojaExcel, "A", Fila_Ini1, Fila_Ini1 + 1)
        BORDES2(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 1, Fila_Ini + 1, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 2, Fila_Ini + 2, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 3, Fila_Ini + 3, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 4, Fila_Ini + 4, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 5, Fila_Ini + 5, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 6, Fila_Ini + 6, "CJ", "DJ")
        BORDES_IZQ(objHojaExcel, "CJ", Fila_Ini, Fila_Ini + 6)
        BORDES_DER(objHojaExcel, "DJ", Fila_Ini, Fila_Ini + 6)
        Fila_Exp = Fila_D
    End Sub

    Private Sub Encavezado_ResultadoPotenciometrico1(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 18
        Dim Fila_C As Integer = 55
        Dim Fila_E As Integer = 55
        Dim Fila_Ini As Integer

        'Encavezado Resultados
        Fila_Ini = Fila_R
        objHojaExcel.Range("A" & Fila_R.ToString & ":H" & Fila_R.ToString).Merge()
        objHojaExcel.Range("A" & Fila_R.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_R.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_R.ToString & ":N" & Fila_R.ToString).Merge()
        objHojaExcel.Range("I" & Fila_R.ToString).Value = "Masa m"
        objHojaExcel.Range("I" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("I" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & Fila_R.ToString & ":T" & Fila_R.ToString).Merge()
        objHojaExcel.Range("O" & Fila_R.ToString).Value = "Vol ext"
        objHojaExcel.Range("O" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("O" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_R.ToString & ":Z" & Fila_R.ToString).Merge()
        objHojaExcel.Range("U" & Fila_R.ToString).Value = "Vol ali"
        objHojaExcel.Range("U" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("U" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AA" & Fila_R.ToString & ":AF" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AA" & Fila_R.ToString).Value = "Aforo ali"
        objHojaExcel.Range("AA" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AA" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & Fila_R.ToString & ":AL" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AG" & Fila_R.ToString).Value = "Factor"
        objHojaExcel.Range("AG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & Fila_R.ToString & ":AU" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_R.ToString).Value = "Lectura(mV)"
        objHojaExcel.Range("AM" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & Fila_R.ToString & ":BD" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AV" & Fila_R.ToString).Value = "Resultado(ppm)"
        objHojaExcel.Range("AV" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AV" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AV" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BD" & Fila_R.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "N", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "T", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "Z", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AF", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AL", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AU", Fila_R, Fila_R)


        ' Precisión


        Fila_C = Fila_C + 1

        objHojaExcel.Range("A" & Fila_C.ToString & ":T" & Fila_C.ToString).Merge()
        objHojaExcel.Range("A" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("V" & Fila_C.ToString & ":AH" & Fila_C.ToString).Merge()
        objHojaExcel.Range("V" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("V" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("V" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '''''''''''''''Salto de Grupo''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("AL" & Fila_C.ToString & ":BD" & Fila_C.ToString).Merge()
        objHojaExcel.Range("AL" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("AL" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AL" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_C.ToString & ":BR" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BD" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''''''''''''''''''Salto de Grupo'''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("BX" & Fila_C.ToString & ":CT" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BX" & Fila_C.ToString).Value = "Aceptación de Standar entre"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BX" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BX" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CU" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CU" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CU" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CV" & Fila_C.ToString & ":CZ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("CV" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CV" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CV" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_C.ToString).Value = "y"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila_C.ToString & ":DJ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("DE" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DE" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


    End Sub
    Private Sub Encavezado_ResultadoPotenciometrico2(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 18
        'Encavezado Resultados

        objHojaExcel.Range("BG" & Fila_R.ToString & ":BN" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_R.ToString).Value = "NºLab"
        objHojaExcel.Range("BG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_R.ToString).Font.Size = 9
        objHojaExcel.Range("BG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & Fila_R.ToString & ":BT" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BO" & Fila_R.ToString).Value = "Masa m"
        objHojaExcel.Range("BO" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("BO" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BO" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & Fila_R.ToString & ":BZ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BU" & Fila_R.ToString).Value = "Vol ext"
        objHojaExcel.Range("BU" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("BU" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & Fila_R.ToString & ":CF" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CA" & Fila_R.ToString).Value = "Vol ali"
        objHojaExcel.Range("CA" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_R.ToString & ":CL" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_R.ToString).Value = "Aforo ali"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & Fila_R.ToString & ":CR" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CM" & Fila_R.ToString).Value = "Factor"
        objHojaExcel.Range("CM" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CS" & Fila_R.ToString & ":DA" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CS" & Fila_R.ToString).Value = "Lectura(mV)"
        objHojaExcel.Range("CS" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CS" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CS" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CS" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DB" & Fila_R.ToString & ":DJ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("DB" & Fila_R.ToString).Value = "Resultado(ppm)"
        objHojaExcel.Range("DB" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DB" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("DB" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DB" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        'Imprime Bordes

        objHojaExcel.Range("BG" & Fila_R.ToString & ":DJ" & Fila_R.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BN", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "BT", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "BZ", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CF", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CL", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CR", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "DA", Fila_R, Fila_R)


    End Sub
    Private Sub Encavezado_Volumetrico(ByVal objHojaExcel As Excel.Worksheet, ByVal Formula As String, ByVal Formula2 As String, ByVal Fdil As String)
        Dim Fila_A As Integer = 7
        Dim Fila_D As Integer = 8
        Dim Fila_Ini As Integer = 8
        objHojaExcel.Range("A" & Fila_A.ToString & ":M" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = "Calculo"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CJ" & Fila_A.ToString & ":DJ" & Fila_A.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_A.ToString).Value = "Datos dilución"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).Font.Bold = 8
        objHojaExcel.Range("CJ" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Formula2
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_A = Fila_A + 1

        objHojaExcel.Range("A" & Fila_A.ToString & ":CI" & Fila_A.ToString).Merge()
        objHojaExcel.Range("A" & Fila_A.ToString).Value = Fdil
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_A.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_A.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("A" & Fila_A.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''''''''''''''' Datos de Calculo '''''''''''''''''''

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Masa muestra"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(g)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "0.10"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Normalidad ácido"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(eq/L)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "0.02"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Chequeo N ácido"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CX" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CX" & Fila_D.ToString).Value = "(eq/L)"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CX" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CX" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CX" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "0.02"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CY" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "N°Lote Titrisol 1N"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        objHojaExcel.Range("CZ" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("CZ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CZ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CZ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CZ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DA" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DA" & Fila_D.ToString).Value = "OC 68336"
        objHojaExcel.Range("DA" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DA" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DA" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DA" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":CW" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Peso Atómico"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "14"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Fac convierte g en kg"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "1000"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        Fila_D = Fila_D + 1

        objHojaExcel.Range("CJ" & Fila_D.ToString & ":DB" & Fila_D.ToString).Merge()
        objHojaExcel.Range("CJ" & Fila_D.ToString).Value = "Factor cálculo"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CJ" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("CJ" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("CJ" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_D.ToString).Value = ":"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        objHojaExcel.Range("DC" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DD" & Fila_D.ToString & ":DJ" & Fila_D.ToString).Merge()
        objHojaExcel.Range("DD" & Fila_D.ToString).Value = "280"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DD" & Fila_D.ToString).Font.Size = 8
        objHojaExcel.Range("DD" & Fila_D.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("DD" & Fila_D.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ' Imprime Bordes

        BORDES2(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini, Fila_Ini, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 1, Fila_Ini + 1, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 2, Fila_Ini + 2, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 3, Fila_Ini + 3, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 4, Fila_Ini + 4, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 5, Fila_Ini + 5, "CJ", "DJ")
        BORDES(objHojaExcel, Fila_Ini + 6, Fila_Ini + 6, "CJ", "DJ")
        BORDES_IZQ(objHojaExcel, "CJ", Fila_Ini, Fila_Ini + 6)
        BORDES_DER(objHojaExcel, "DJ", Fila_Ini, Fila_Ini + 6)
        Fila_Exp = Fila_D
    End Sub
    Private Sub Encavezado_ResultadoVolumetrico1(ByVal objHojaExcel As Excel.Worksheet, ByVal fila_r As Integer)
        'Dim Fila_R As Integer = 18
        Dim Fila_C As Integer = 57

        objHojaExcel.Range("A" & fila_r.ToString & ":H" & fila_r.ToString).Merge()
        objHojaExcel.Range("A" & fila_r.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Size = 9
        objHojaExcel.Range("A" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & fila_r.ToString & ":N" & fila_r.ToString).Merge()
        objHojaExcel.Range("I" & fila_r.ToString).Value = "Masa m"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("I" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & fila_r.ToString & ":T" & fila_r.ToString).Merge()
        objHojaExcel.Range("O" & fila_r.ToString).Value = "Factor"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("O" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & fila_r.ToString & ":AC" & fila_r.ToString).Merge()
        objHojaExcel.Range("U" & fila_r.ToString).Value = "Gasto (ml)"
        objHojaExcel.Range("U" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("U" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AD" & fila_r.ToString & ":AL" & fila_r.ToString).Merge()
        objHojaExcel.Range("AD" & fila_r.ToString).Value = "Resultado (%)"
        objHojaExcel.Range("AD" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AD" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("AD" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AD" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



        'Bordes

        objHojaExcel.Range("A" & fila_r.ToString & ":AL" & fila_r.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "N", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "T", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "AC", fila_r, fila_r)

        'DATOS DE PRESICION

        objHojaExcel.Range("A" & Fila_C.ToString & ":T" & Fila_C.ToString).Merge()
        objHojaExcel.Range("A" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("V" & Fila_C.ToString & ":AH" & Fila_C.ToString).Merge()
        objHojaExcel.Range("V" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("V" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("V" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '''''''''''''''Salto de Grupo''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("AL" & Fila_C.ToString & ":BD" & Fila_C.ToString).Merge()
        objHojaExcel.Range("AL" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("AL" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AL" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_C.ToString & ":BR" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BD" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''''''''''''''''''Salto de Grupo'''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("BX" & Fila_C.ToString & ":CT" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BX" & Fila_C.ToString).Value = "Aceptación de Standar entre"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BX" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BX" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CU" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CU" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CU" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CV" & Fila_C.ToString & ":CZ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("CV" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CV" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CV" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_C.ToString).Value = "y"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila_C.ToString & ":DJ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("DE" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DE" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


    End Sub
    Private Sub Encavezado_ResultadoVolumetrico2(ByVal objHojaExcel As Excel.Worksheet, ByVal FILA_R As Integer)
        'Dim Fila_R As Integer = 18
        objHojaExcel.Range("BF" & FILA_R.ToString & ":BM" & FILA_R.ToString).Merge()
        objHojaExcel.Range("BF" & FILA_R.ToString).Value = "NºLab"
        objHojaExcel.Range("BF" & FILA_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BF" & FILA_R.ToString).Font.Size = 9
        objHojaExcel.Range("BF" & FILA_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BF" & FILA_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BN" & FILA_R.ToString & ":BS" & FILA_R.ToString).Merge()
        objHojaExcel.Range("BN" & FILA_R.ToString).Value = "Masa m"
        objHojaExcel.Range("BN" & FILA_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BN" & FILA_R.ToString).Font.Size = 6
        objHojaExcel.Range("BN" & FILA_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BN" & FILA_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BT" & FILA_R.ToString & ":BY" & FILA_R.ToString).Merge()
        objHojaExcel.Range("BT" & FILA_R.ToString).Value = "Factor"
        objHojaExcel.Range("BT" & FILA_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BT" & FILA_R.ToString).Font.Size = 6
        objHojaExcel.Range("BT" & FILA_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BT" & FILA_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BZ" & FILA_R.ToString & ":CH" & FILA_R.ToString).Merge()
        objHojaExcel.Range("BZ" & FILA_R.ToString).Value = "Gasto (ml)"
        objHojaExcel.Range("BZ" & FILA_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BZ" & FILA_R.ToString).Font.Size = 6
        objHojaExcel.Range("BZ" & FILA_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BZ" & FILA_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CI" & FILA_R.ToString & ":CQ" & FILA_R.ToString).Merge()
        objHojaExcel.Range("CI" & FILA_R.ToString).Value = "Resultado (%)"
        objHojaExcel.Range("CI" & FILA_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CI" & FILA_R.ToString).Font.Size = 6
        objHojaExcel.Range("CI" & FILA_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CI" & FILA_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Bordes

        objHojaExcel.Range("BF" & FILA_R.ToString & ":CQ" & FILA_R.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BM", FILA_R, FILA_R)
        BORDES_DER(objHojaExcel, "BS", FILA_R, FILA_R)
        BORDES_DER(objHojaExcel, "BY", FILA_R, FILA_R)
        BORDES_DER(objHojaExcel, "CH", FILA_R, FILA_R)

    End Sub
    Private Sub Encavezado_Resultado_NHoja(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)

        Fila = Fila + 11

        'Encavezado Resultados

        objHojaExcel.Range("A" & Fila.ToString & ":J" & Fila.ToString).Merge()
        objHojaExcel.Range("A" & Fila.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("K" & Fila.ToString & ":T" & Fila.ToString).Merge()
        objHojaExcel.Range("K" & Fila.ToString).Value = "Lectura"
        objHojaExcel.Range("K" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("K" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("K" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("K" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila.ToString & ":AD" & Fila.ToString).Merge()
        objHojaExcel.Range("U" & Fila.ToString).Value = "Interpola"
        objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AE" & Fila.ToString & ":AN" & Fila.ToString).Merge()
        objHojaExcel.Range("AE" & Fila.ToString).Value = "Factor"
        objHojaExcel.Range("AE" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AE" & Fila.ToString).Font.Size = 8
        objHojaExcel.Range("AE" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AE" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AO" & Fila.ToString & ":AX" & Fila.ToString).Merge()
        objHojaExcel.Range("AO" & Fila.ToString).Value = "Resultado"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AO" & Fila.ToString).Font.Size = 10
        objHojaExcel.Range("AO" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AO" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila.ToString & ":AX" & Fila.ToString).BorderAround()
        objHojaExcel.Range("J" & Fila.ToString & ":J" & Fila.ToString).BorderAround()
        objHojaExcel.Range("T" & Fila.ToString & ":T" & Fila.ToString).BorderAround()
        objHojaExcel.Range("AD" & Fila.ToString & ":AD" & Fila.ToString).BorderAround()
        objHojaExcel.Range("AN" & Fila.ToString & ":AN" & Fila.ToString).BorderAround()
    End Sub
    Private Sub Encavezado_Resultado2_NHoja2(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 62
        'Encavezado Resultados

        objHojaExcel.Range("BM" & Fila_R.ToString & ":BV" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BM" & Fila_R.ToString).Value = "NºLab"
        objHojaExcel.Range("BM" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BM" & Fila_R.ToString).Font.Size = 10
        objHojaExcel.Range("BM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BW" & Fila_R.ToString & ":CF" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BW" & Fila_R.ToString).Value = "Lectura"
        objHojaExcel.Range("BW" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BW" & Fila_R.ToString).Font.Size = 10
        objHojaExcel.Range("BW" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BW" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_R.ToString & ":CP" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_R.ToString).Value = "Interpola"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Size = 8
        objHojaExcel.Range("CG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CQ" & Fila_R.ToString & ":CZ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CQ" & Fila_R.ToString).Value = "Factor"
        objHojaExcel.Range("CQ" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CQ" & Fila_R.ToString).Font.Size = 8
        objHojaExcel.Range("CQ" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CQ" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DA" & Fila_R.ToString & ":DJ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("DA" & Fila_R.ToString).Value = "Resultado"
        objHojaExcel.Range("DA" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DA" & Fila_R.ToString).Font.Size = 10
        objHojaExcel.Range("DA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("BM" & Fila_R.ToString & ":DJ" & Fila_R.ToString).BorderAround()
        objHojaExcel.Range("BV" & Fila_R.ToString & ":BV" & Fila_R.ToString).BorderAround()
        objHojaExcel.Range("CF" & Fila_R.ToString & ":CF" & Fila_R.ToString).BorderAround()
        objHojaExcel.Range("CP" & Fila_R.ToString & ":CP" & Fila_R.ToString).BorderAround()
        objHojaExcel.Range("CZ" & Fila_R.ToString & ":CZ" & Fila_R.ToString).BorderAround()

    End Sub
    Private Sub Encavezado_ResultadoColorimetrico2(ByVal objHojaExcel As Excel.Worksheet, ByVal fila_r As Integer)

        'Encavezado Resultados

        objHojaExcel.Range("BG" & fila_r.ToString & ":BN" & fila_r.ToString).Merge()
        objHojaExcel.Range("BG" & fila_r.ToString).Value = "NºLab"
        objHojaExcel.Range("BG" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & fila_r.ToString).Font.Size = 9
        objHojaExcel.Range("BG" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BG" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & fila_r.ToString & ":BT" & fila_r.ToString).Merge()
        objHojaExcel.Range("BO" & fila_r.ToString).Value = "Masa m"
        objHojaExcel.Range("BO" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("BO" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BO" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & fila_r.ToString & ":BZ" & fila_r.ToString).Merge()
        objHojaExcel.Range("BU" & fila_r.ToString).Value = "Vol af"
        objHojaExcel.Range("BU" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("BU" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & fila_r.ToString & ":CF" & fila_r.ToString).Merge()
        objHojaExcel.Range("CA" & fila_r.ToString).Value = "Vol ali"
        objHojaExcel.Range("CA" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & fila_r.ToString & ":CL" & fila_r.ToString).Merge()
        objHojaExcel.Range("CG" & fila_r.ToString).Value = "Aforo ali"
        objHojaExcel.Range("CG" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("CG" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & fila_r.ToString & ":CR" & fila_r.ToString).Merge()
        objHojaExcel.Range("CM" & fila_r.ToString).Value = "Factor"
        objHojaExcel.Range("CM" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("CM" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CS" & fila_r.ToString & ":DA" & fila_r.ToString).Merge()
        objHojaExcel.Range("CS" & fila_r.ToString).Value = "Lectura(Abs)"
        objHojaExcel.Range("CS" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CS" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("CS" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CS" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DB" & fila_r.ToString & ":DJ" & fila_r.ToString).Merge()
        objHojaExcel.Range("DB" & fila_r.ToString).Value = "Resultado(%)"
        objHojaExcel.Range("DB" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DB" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("DB" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DB" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        'Imprime Bordes

        objHojaExcel.Range("BG" & fila_r.ToString & ":DJ" & fila_r.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BN", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "BT", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "BZ", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "CF", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "CL", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "CR", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "DA", fila_r, fila_r)



    End Sub
    Private Sub Encavezado_ResultadoColorimetrico(ByVal objHojaExcel As Excel.Worksheet, ByVal fila_r As Integer)

        Dim Fila_C As Integer = 55
        Dim Fila_E As Integer = 55
        Dim Fila_Ini As Integer

        'Encavezado Resultados
        Fila_Ini = fila_r
        objHojaExcel.Range("A" & fila_r.ToString & ":H" & fila_r.ToString).Merge()
        objHojaExcel.Range("A" & fila_r.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Size = 9
        objHojaExcel.Range("A" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & fila_r.ToString & ":N" & fila_r.ToString).Merge()
        objHojaExcel.Range("I" & fila_r.ToString).Value = "Masa m"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("I" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & fila_r.ToString & ":T" & fila_r.ToString).Merge()
        objHojaExcel.Range("O" & fila_r.ToString).Value = "Vol af"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("O" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & fila_r.ToString & ":Z" & fila_r.ToString).Merge()
        objHojaExcel.Range("U" & fila_r.ToString).Value = "Vol ali"
        objHojaExcel.Range("U" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("U" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AA" & fila_r.ToString & ":AF" & fila_r.ToString).Merge()
        objHojaExcel.Range("AA" & fila_r.ToString).Value = "Aforo ali"
        objHojaExcel.Range("AA" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AA" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("AA" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AA" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & fila_r.ToString & ":AL" & fila_r.ToString).Merge()
        objHojaExcel.Range("AG" & fila_r.ToString).Value = "Factor"
        objHojaExcel.Range("AG" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("AG" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AG" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & fila_r.ToString & ":AU" & fila_r.ToString).Merge()
        objHojaExcel.Range("AM" & fila_r.ToString).Value = "Lectura(Abs)"
        objHojaExcel.Range("AM" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("AM" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & fila_r.ToString & ":BD" & fila_r.ToString).Merge()
        objHojaExcel.Range("AV" & fila_r.ToString).Value = "Resultado(%)"
        objHojaExcel.Range("AV" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("AV" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AV" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BD" & fila_r.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "N", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "T", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "Z", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "AF", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "AL", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "AU", fila_r, fila_r)


        ' Precisión


        Fila_C = Fila_C + 1

        objHojaExcel.Range("A" & Fila_C.ToString & ":T" & Fila_C.ToString).Merge()
        objHojaExcel.Range("A" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("V" & Fila_C.ToString & ":AH" & Fila_C.ToString).Merge()
        objHojaExcel.Range("V" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("V" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("V" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '''''''''''''''Salto de Grupo''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("AL" & Fila_C.ToString & ":BD" & Fila_C.ToString).Merge()
        objHojaExcel.Range("AL" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("AL" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AL" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_C.ToString & ":BR" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BD" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''''''''''''''''''Salto de Grupo'''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("BX" & Fila_C.ToString & ":CT" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BX" & Fila_C.ToString).Value = "Aceptación de Standar entre"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BX" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BX" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CU" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CU" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CU" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CV" & Fila_C.ToString & ":CZ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("CV" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CV" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CV" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_C.ToString).Value = "y"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila_C.ToString & ":DJ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("DE" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DE" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '' Imprime BORDES

        'objHojaExcel.Range("A" & Fila_C - 1.ToString & ":AU" & Fila_C.ToString).BorderAround()


        ''Estandares


        'objHojaExcel.Range("AW" & Fila_E.ToString & ":BM" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("AW" & Fila_E.ToString).Value = "Aceptación Estándar"
        'objHojaExcel.Range("AW" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("AW" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("AW" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("AW" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("BN" & Fila_E.ToString).Value = ":"
        'objHojaExcel.Range("BN" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("BN" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("BN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("BN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("BO" & Fila_E.ToString & ":CD" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("BO" & Fila_E.ToString).Value = ""
        'objHojaExcel.Range("BO" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("BO" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("BO" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("BO" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Fila_E = Fila_E + 1

        'objHojaExcel.Range("AW" & Fila_E.ToString & ":BM" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("AW" & Fila_E.ToString).Value = "Valores entre"
        'objHojaExcel.Range("AW" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("AW" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("AW" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("AW" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("BN" & Fila_E.ToString).Value = ":"
        'objHojaExcel.Range("BN" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("BN" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("BN" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("BN" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'objHojaExcel.Range("BO" & Fila_E.ToString & ":CD" & Fila_E.ToString).Merge()
        'objHojaExcel.Range("BO" & Fila_E.ToString).Value = ""
        'objHojaExcel.Range("BO" & Fila_E.ToString).Font.Name = "Times New Roman"
        'objHojaExcel.Range("BO" & Fila_E.ToString).Font.Size = 8
        'objHojaExcel.Range("BO" & Fila_E.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        'objHojaExcel.Range("BO" & Fila_E.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''Borde

        'objHojaExcel.Range("AW" & Fila_E - 1.ToString & ":CD" & Fila_E.ToString).BorderAround()


    End Sub
    Private Sub Encavezado_ResultadoEAA(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 18
        Dim Fila_C As Integer = 55
        Dim Fila_E As Integer = 55
        Dim Fila_Ini As Integer

        'Encavezado Resultados
        Fila_Ini = Fila_R
        objHojaExcel.Range("A" & Fila_R.ToString & ":H" & Fila_R.ToString).Merge()
        objHojaExcel.Range("A" & Fila_R.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_R.ToString).Font.Size = 9
        objHojaExcel.Range("A" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & Fila_R.ToString & ":N" & Fila_R.ToString).Merge()
        objHojaExcel.Range("I" & Fila_R.ToString).Value = "Masa m"
        objHojaExcel.Range("I" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("I" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & Fila_R.ToString & ":T" & Fila_R.ToString).Merge()
        objHojaExcel.Range("O" & Fila_R.ToString).Value = "Vol af"
        objHojaExcel.Range("O" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("O" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_R.ToString & ":Z" & Fila_R.ToString).Merge()
        objHojaExcel.Range("U" & Fila_R.ToString).Value = "Vol ali"
        objHojaExcel.Range("U" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("U" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AA" & Fila_R.ToString & ":AF" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AA" & Fila_R.ToString).Value = "Aforo ali"
        objHojaExcel.Range("AA" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AA" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AG" & Fila_R.ToString & ":AL" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AG" & Fila_R.ToString).Value = "Factor"
        objHojaExcel.Range("AG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AG" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AM" & Fila_R.ToString & ":AU" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AM" & Fila_R.ToString).Value = "Lectura(Abs)"
        objHojaExcel.Range("AM" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AM" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("AV" & Fila_R.ToString & ":BD" & Fila_R.ToString).Merge()
        objHojaExcel.Range("AV" & Fila_R.ToString).Value = "Resultado(%)"
        objHojaExcel.Range("AV" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AV" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("AV" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AV" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Imprime Bordes

        objHojaExcel.Range("A" & Fila_Ini.ToString & ":BD" & Fila_R.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "N", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "T", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "Z", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AF", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AL", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "AU", Fila_R, Fila_R)


        ' Precisión


        Fila_C = Fila_C + 1

        objHojaExcel.Range("A" & Fila_C.ToString & ":T" & Fila_C.ToString).Merge()
        objHojaExcel.Range("A" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("A" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("U" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("U" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("U" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("U" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("V" & Fila_C.ToString & ":AH" & Fila_C.ToString).Merge()
        objHojaExcel.Range("V" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("V" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("V" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("V" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        '''''''''''''''Salto de Grupo''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("AL" & Fila_C.ToString & ":BD" & Fila_C.ToString).Merge()
        objHojaExcel.Range("AL" & Fila_C.ToString).Value = "Precisión Lab.Muestras"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("AL" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("AL" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("AL" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BC" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BD" & Fila_C.ToString & ":BR" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BD" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BD" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BD" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BD" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        ''''''''''''''''''Salto de Grupo'''''''''''''''''''''''''''''''''''''''

        objHojaExcel.Range("BX" & Fila_C.ToString & ":CT" & Fila_C.ToString).Merge()
        objHojaExcel.Range("BX" & Fila_C.ToString).Value = "Aceptación de Standar entre"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BX" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("BX" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BX" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CU" & Fila_C.ToString).Value = ":"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CU" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CU" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CU" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CV" & Fila_C.ToString & ":CZ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("CV" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CV" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("CV" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CV" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DC" & Fila_C.ToString).Value = "y"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DC" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DC" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DC" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DE" & Fila_C.ToString & ":DJ" & Fila_C.ToString).Merge()
        objHojaExcel.Range("DE" & Fila_C.ToString).Value = ""
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DE" & Fila_C.ToString).Font.Size = 8
        objHojaExcel.Range("DE" & Fila_C.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DE" & Fila_C.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



    End Sub
    Private Sub Encavezado_ResultadoEAA2(ByVal objHojaExcel As Excel.Worksheet)
        Dim Fila_R As Integer = 18
        'Encavezado Resultados

        objHojaExcel.Range("BG" & Fila_R.ToString & ":BN" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BG" & Fila_R.ToString).Value = "NºLab"
        objHojaExcel.Range("BG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BG" & Fila_R.ToString).Font.Size = 9
        objHojaExcel.Range("BG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BO" & Fila_R.ToString & ":BT" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BO" & Fila_R.ToString).Value = "Masa m"
        objHojaExcel.Range("BO" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BO" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("BO" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BO" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("BU" & Fila_R.ToString & ":BZ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("BU" & Fila_R.ToString).Value = "Vol af"
        objHojaExcel.Range("BU" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("BU" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("BU" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("BU" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CA" & Fila_R.ToString & ":CF" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CA" & Fila_R.ToString).Value = "Vol ali"
        objHojaExcel.Range("CA" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CA" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CA" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CA" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CG" & Fila_R.ToString & ":CL" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CG" & Fila_R.ToString).Value = "Aforo ali"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CG" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CG" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CG" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CM" & Fila_R.ToString & ":CR" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CM" & Fila_R.ToString).Value = "Factor"
        objHojaExcel.Range("CM" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CM" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CM" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CM" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("CS" & Fila_R.ToString & ":DA" & Fila_R.ToString).Merge()
        objHojaExcel.Range("CS" & Fila_R.ToString).Value = "Lectura(Abs)"
        objHojaExcel.Range("CS" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("CS" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("CS" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("CS" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("DB" & Fila_R.ToString & ":DJ" & Fila_R.ToString).Merge()
        objHojaExcel.Range("DB" & Fila_R.ToString).Value = "Resultado(%)"
        objHojaExcel.Range("DB" & Fila_R.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("DB" & Fila_R.ToString).Font.Size = 6
        objHojaExcel.Range("DB" & Fila_R.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("DB" & Fila_R.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        'Imprime Bordes

        objHojaExcel.Range("BG" & Fila_R.ToString & ":DJ" & Fila_R.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "BN", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "BT", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "BZ", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CF", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CL", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "CR", Fila_R, Fila_R)
        BORDES_DER(objHojaExcel, "DA", Fila_R, Fila_R)


    End Sub
    Private Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer, ByVal fila2 As Integer, ByVal Letra1 As String, ByVal Letra2 As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila2.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub
    Private Sub BORDES2(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila As Integer, ByVal fila2 As Integer, ByVal Letra1 As String, ByVal Letra2 As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(Letra1 & fila.ToString & ":" & Letra2 & fila2.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub
    Private Sub BORDES_IZQ(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal letra As String, ByVal fila_i As String, ByVal fila_f As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(letra & fila_i.ToString & ":" & letra & fila_f.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub
    Private Sub BORDES_DER(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal letra As String, ByVal fila_i As String, ByVal fila_f As String)
        Dim LIN As Integer
        With HOJA_EXCEL.Range(letra & fila_i.ToString & ":" & letra & fila_f.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    ' Imeprime Resultados  Separados


    Private Sub Imprime_ResultadoEAA(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Dato As Integer = Fila
        Dim Cam_Col As String
        Dim Fila2, cont As Integer
        Dim Fila_Elemento As DataRow
        Num_Pag = 1
        Cam_Col = "N"
        cont = 1
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DIGITACION").Rows

            If Num_Pag < 2 Then
                If Fila < Fila + 34 And Cam_Col = "N" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AG" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AM" & Fila.ToString & ":AU" & Fila.ToString).Merge()
                    objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AV" & Fila.ToString & ":BD" & Fila.ToString).Merge()
                    objHojaExcel.Range("AV" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AV" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AV" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "BD")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "Z", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AF", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AL", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AU", Fila, Fila)

                    Fila = Fila + 1

                    If Fila = 54 Then
                        Cam_Col = "S"
                        GoTo salto
                    End If

                End If

                If Fila > Dato + 34 And Cam_Col = "S" Then

                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BG" & Fila2.ToString & ":BN" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BG" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BO" & Fila2.ToString & ":BT" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BO" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BO" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BO" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BU" & Fila2.ToString & ":BZ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BU" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BU" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BU" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CA" & Fila2.ToString & ":CF" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CA" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CA" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CA" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CG" & Fila2.ToString & ":CL" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CG" & Fila2.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CM" & Fila2.ToString & ":CR" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CM" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CM" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CM" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CS" & Fila2.ToString & ":DA" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CS" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CS" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CS" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DB" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DB" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DB" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DB" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila2, Fila2, "BG", "DJ")
                    BORDES_DER(objHojaExcel, "BN", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BT", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BZ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CF", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CL", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CR", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DA", Fila2, Fila2)

                    Fila2 = Fila2 + 1

                    If Fila2 = 54 Then
                        Cam_Col = "N"
                        Fila = Fila2 + 11
                        Num_Pag = Num_Pag + 1
                        GoTo salto
                    End If

                End If

            Else
                If Cam_Col = "N" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AG" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AM" & Fila.ToString & ":AU" & Fila.ToString).Merge()
                    objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AV" & Fila.ToString & ":BD" & Fila.ToString).Merge()
                    objHojaExcel.Range("AV" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AV" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AV" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "BD")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "Z", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AF", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AL", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AU", Fila, Fila)

                    Fila = Fila + 1
                    cont = cont + 1
                    If cont = 59 Then
                        Cam_Col = "S"
                        cont = 1
                        GoTo salto
                    End If
                End If

                If Cam_Col = "S" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BG" & Fila2.ToString & ":BN" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BG" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BO" & Fila2.ToString & ":BT" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BO" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BO" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BO" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BU" & Fila2.ToString & ":BZ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BU" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BU" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BU" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CA" & Fila2.ToString & ":CF" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CA" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CA" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CA" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CG" & Fila2.ToString & ":CL" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CG" & Fila2.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CM" & Fila2.ToString & ":CR" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CM" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CM" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CM" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CS" & Fila2.ToString & ":DA" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CS" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CS" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CS" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DB" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DB" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DB" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DB" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila2, Fila2, "BG", "DJ")
                    BORDES_DER(objHojaExcel, "BN", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BT", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BZ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CF", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CL", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CR", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DA", Fila2, Fila2)

                    Fila2 = Fila2 + 1
                    cont = cont + 1
                    If cont = 59 Then
                        Cam_Col = "N"
                        Fila = Fila2 + 5
                        Num_Pag = Num_Pag + 1
                        cont = 1
                        GoTo salto
                    End If
                End If
            End If
salto:
        Next


    End Sub
    Private Sub Imprime_ResultadosColorimetricos(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Cam_Col As String
        Dim Dato As Integer = Fila
        Dim F_Paso, cont As Integer
        Dim Fila2 As Integer = Dato
        Dim Fila_Elemento As DataRow
        Num_Pag = 1
        Cam_Col = "N"
        cont = 1

        For Each Fila_Elemento In Cjto_Tablas1.Tables("DIGITACION").Rows

            If Num_Pag < 2 Then

                If Fila < Fila + 34 And Cam_Col = "N" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AG" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AM" & Fila.ToString & ":AU" & Fila.ToString).Merge()
                    objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AV" & Fila.ToString & ":BD" & Fila.ToString).Merge()
                    objHojaExcel.Range("AV" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AV" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AV" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "BD")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "Z", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AF", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AL", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AU", Fila, Fila)

                    Fila = Fila + 1

                    If Fila = 54 Then
                        Cam_Col = "S"
                        GoTo saltocol
                    End If
                End If

                If Fila > Dato + 34 And Cam_Col = "S" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BG" & Fila2.ToString & ":BN" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BG" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BO" & Fila2.ToString & ":BT" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BO" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BO" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BO" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BU" & Fila2.ToString & ":BZ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BU" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BU" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BU" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CA" & Fila2.ToString & ":CF" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CA" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CA" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CA" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CG" & Fila2.ToString & ":CL" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CG" & Fila2.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CM" & Fila2.ToString & ":CR" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CM" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CM" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CM" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CS" & Fila2.ToString & ":DA" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CS" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CS" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CS" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DB" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DB" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DB" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DB" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    BORDES(objHojaExcel, Fila2, Fila2, "BG", "DJ")
                    BORDES_DER(objHojaExcel, "BN", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BT", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BZ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CF", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CL", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CR", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DA", Fila2, Fila2)

                    Fila2 = Fila2 + 1

                    If Fila2 = 54 Then
                        Cam_Col = "N"
                        Fila = Fila2 + 11
                        Num_Pag = Num_Pag + 1
                        GoTo saltocol
                    End If
                End If

            Else

                If Cam_Col = "N" Then

                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":Z" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AA" & Fila.ToString & ":AF" & Fila.ToString).Merge()
                    objHojaExcel.Range("AA" & Fila.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AA" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AA" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AA" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AG" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AG" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AG" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AG" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AG" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AM" & Fila.ToString & ":AU" & Fila.ToString).Merge()
                    objHojaExcel.Range("AM" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AM" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AM" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AM" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AV" & Fila.ToString & ":BD" & Fila.ToString).Merge()
                    objHojaExcel.Range("AV" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AV" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AV" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AV" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter



                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "BD")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "Z", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AF", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AL", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AU", Fila, Fila)

                    Fila = Fila + 1
                    cont = cont + 1

                    If cont = 59 Then
                        Cam_Col = "S"
                        cont = 1
                        GoTo saltocol
                    End If
                End If

                If Cam_Col = "S" Then

                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoColorimetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BG" & Fila2.ToString & ":BN" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BG" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BO" & Fila2.ToString & ":BT" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BO" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BO" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BO" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BO" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BU" & Fila2.ToString & ":BZ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BU" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_AFO")
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BU" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BU" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BU" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CA" & Fila2.ToString & ":CF" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CA" & Fila2.ToString).Value = Fila_Elemento("VOLUMEN_ALI")
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CA" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CA" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CA" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CG" & Fila2.ToString & ":CL" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CG" & Fila2.ToString).Value = Fila_Elemento("AFORO_ALI")
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CG" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CG" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CG" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CM" & Fila2.ToString & ":CR" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CM" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CM" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CM" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CM" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CS" & Fila2.ToString & ":DA" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CS" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CS" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CS" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CS" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("DB" & Fila2.ToString & ":DJ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("DB" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("DB" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("DB" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("DB" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    BORDES(objHojaExcel, Fila2, Fila2, "BG", "DJ")
                    BORDES_DER(objHojaExcel, "BN", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BT", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BZ", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CF", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CL", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CR", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "DA", Fila2, Fila2)

                    Fila2 = Fila2 + 1
                    cont = cont + 1

                    If cont = 59 Then
                        Cam_Col = "N"
                        Num_Pag = Num_Pag + 1
                        Fila = Fila2 + 5
                        cont = 1
                        GoTo saltocol
                    End If
                End If
            End If
saltocol:
        Next


    End Sub
    Private Sub Imprime_ResultadosVolumetricos(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Cam_Col As String
        Dim Dato As Integer = Fila
        Dim Fila2 As Integer = Dato
        Dim F_Paso, cont As Integer
        Dim Fila_Elemento As DataRow
        Num_Pag = 1
        Cam_Col = "N"
        cont = 1

        For Each Fila_Elemento In Cjto_Tablas1.Tables("DIGITACION").Rows
            If Num_Pag < 2 Then
                If Fila < Fila + 34 And Cam_Col = "N" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":AC" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AD" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AD" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AD" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AD" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AD" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AD" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "AL")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AC", Fila, Fila)
                    'objHojaExcel.Range("A" & Dato.ToString & ":AL" & Fila - 1.ToString).BorderAround()
                    Fila = Fila + 1
                    If Fila = 54 Then
                        Cam_Col = "S"
                        GoTo saltovol
                    End If
                End If

                If Fila > Dato + 34 And Cam_Col = "S" Then
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BF" & Fila2.ToString & ":BM" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BF" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BF" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BF" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BF" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BF" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BN" & Fila2.ToString & ":BS" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BN" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BN" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BN" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BN" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BN" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BT" & Fila2.ToString & ":BY" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BT" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("BT" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BT" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BT" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BT" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BZ" & Fila2.ToString & ":CH" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BZ" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("BZ" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BZ" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BZ" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BZ" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CI" & Fila2.ToString & ":CQ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CI" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("CI" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CI" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CI" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CI" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    'Bordes

                    BORDES(objHojaExcel, Fila2, Fila2, "BF", "CQ")
                    BORDES_DER(objHojaExcel, "BM", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BS", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BY", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CH", Fila2, Fila2)
                    Fila2 = Fila2 + 1
                    If Fila2 = 54 Then
                        Cam_Col = "N"
                        Fila = Fila2 + 11
                        Num_Pag = Num_Pag + 1
                        GoTo saltovol
                    End If
                End If

            Else

                If Cam_Col = "N" Then
                    cont = 1
                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 18)
                        Fila2 = 19
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 64)
                        Fila2 = 65
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 126)
                        Fila2 = 127
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoVolumetrico1(objHojaExcel, 188)
                        Fila2 = 189
                    End If
                    objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
                    objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
                    objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
                    objHojaExcel.Range("O" & Fila.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("U" & Fila.ToString & ":AC" & Fila.ToString).Merge()
                    objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("AD" & Fila.ToString & ":AL" & Fila.ToString).Merge()
                    objHojaExcel.Range("AD" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("AD" & Fila.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("AD" & Fila.ToString).Font.Size = 9
                    objHojaExcel.Range("AD" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("AD" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    'Bordes

                    BORDES(objHojaExcel, Fila, Fila, "A", "AL")
                    BORDES_DER(objHojaExcel, "H", Fila, Fila)
                    BORDES_DER(objHojaExcel, "N", Fila, Fila)
                    BORDES_DER(objHojaExcel, "T", Fila, Fila)
                    BORDES_DER(objHojaExcel, "AC", Fila, Fila)
                    'objHojaExcel.Range("A" & Dato.ToString & ":AL" & Fila - 1.ToString).BorderAround()
                    Fila = Fila + 1
                    cont = cont + 1
                    If cont = 59 Then
                        Cam_Col = "S"
                        cont = 1
                        GoTo saltovol
                    End If
                End If


                If Cam_Col = "S" Then

                    If Num_Pag = 1 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 18)
                    ElseIf Num_Pag = 2 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 64)
                    ElseIf Num_Pag = 3 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 126)
                    ElseIf Num_Pag = 4 Then
                        Call Encavezado_ResultadoVolumetrico2(objHojaExcel, 188)
                    End If

                    objHojaExcel.Range("BF" & Fila2.ToString & ":BM" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BF" & Fila2.ToString).Value = Fila_Elemento("OT_NLABX")
                    objHojaExcel.Range("BF" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BF" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BF" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BF" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BN" & Fila2.ToString & ":BS" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BN" & Fila2.ToString).Value = Fila_Elemento("MASA_MUE")
                    objHojaExcel.Range("BN" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BN" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BN" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BN" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BT" & Fila2.ToString & ":BY" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BT" & Fila2.ToString).Value = Fila_Elemento("FACTOR")
                    objHojaExcel.Range("BT" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BT" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BT" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BT" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("BZ" & Fila2.ToString & ":CH" & Fila2.ToString).Merge()
                    objHojaExcel.Range("BZ" & Fila2.ToString).Value = Fila_Elemento("LECTURA")
                    objHojaExcel.Range("BZ" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("BZ" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("BZ" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("BZ" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    objHojaExcel.Range("CI" & Fila2.ToString & ":CQ" & Fila2.ToString).Merge()
                    objHojaExcel.Range("CI" & Fila2.ToString).Value = Fila_Elemento("RESULTADO")
                    objHojaExcel.Range("CI" & Fila2.ToString).Font.Name = "Times New Roman"
                    objHojaExcel.Range("CI" & Fila2.ToString).Font.Size = 9
                    objHojaExcel.Range("CI" & Fila2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    objHojaExcel.Range("CI" & Fila2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                    'Bordes

                    BORDES(objHojaExcel, Fila2, Fila2, "BF", "CQ")
                    BORDES_DER(objHojaExcel, "BM", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BS", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "BY", Fila2, Fila2)
                    BORDES_DER(objHojaExcel, "CH", Fila2, Fila2)
                    Fila2 = Fila2 + 1
                    cont = cont + 1
                    If cont = 59 Then
                        Cam_Col = "N"
                        Fila = Fila2 + 5
                        Num_Pag = Num_Pag + 1
                        cont = 1
                        GoTo saltovol
                    End If
                End If
            End If
saltovol:
        Next

    End Sub
    Private Sub Encavezado_ResultadosLectura(ByVal objHojaExcel As Excel.Worksheet, ByVal fila_r As Integer)
        ' Dim Fila_R As Integer = 18
        Dim Fila_C As Integer = 55
        Dim Fila_E As Integer = 55
        Dim Fila_Ini As Integer

        'Encavezado Resultados
        Fila_Ini = fila_r
        objHojaExcel.Range("A" & fila_r.ToString & ":H" & fila_r.ToString).Merge()
        objHojaExcel.Range("A" & fila_r.ToString).Value = "NºLab"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("A" & fila_r.ToString).Font.Size = 9
        objHojaExcel.Range("A" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("I" & fila_r.ToString & ":N" & fila_r.ToString).Merge()
        objHojaExcel.Range("I" & fila_r.ToString).Value = "Resultado"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("I" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("I" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("I" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("O" & fila_r.ToString & ":T" & fila_r.ToString).Merge()
        objHojaExcel.Range("O" & fila_r.ToString).Value = "Unidad"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("O" & fila_r.ToString).Font.Size = 6
        objHojaExcel.Range("O" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("O" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        objHojaExcel.Range("V" & fila_r.ToString & ":DJ" & fila_r.ToString).Merge()
        objHojaExcel.Range("V" & fila_r.ToString).Value = "Observaciones"
        objHojaExcel.Range("V" & fila_r.ToString).Font.Name = "Times New Roman"
        objHojaExcel.Range("V" & fila_r.ToString).Font.Size = 9
        objHojaExcel.Range("V" & fila_r.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("V" & fila_r.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        'Bordes

        objHojaExcel.Range("A" & fila_r.ToString & ":DJ" & fila_r.ToString).BorderAround()
        BORDES_DER(objHojaExcel, "H", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "N", fila_r, fila_r)
        BORDES_DER(objHojaExcel, "T", fila_r, fila_r)


    End Sub
    Private Sub Imprime_ResultadosLectura(ByVal objHojaExcel As Excel.Worksheet, ByVal Fila As Integer)
        Dim Fila_Elemento As DataRow
        Dim dato As Integer = Fila
        Num_Pag = 1
        For Each Fila_Elemento In Cjto_Tablas1.Tables("DIGITACION").Rows
            If Num_Pag = 1 Then
                Call Encavezado_ResultadosLectura(objHojaExcel, 18)
            ElseIf Num_Pag = 2 Then
                Call Encavezado_ResultadosLectura(objHojaExcel, 64)
            ElseIf Num_Pag = 3 Then
                Call Encavezado_ResultadosLectura(objHojaExcel, 125)
            ElseIf Num_Pag = 4 Then
                Call Encavezado_ResultadosLectura(objHojaExcel, 187)
            ElseIf Num_Pag = 5 Then
                Call Encavezado_ResultadosLectura(objHojaExcel, 249)
            End If
            objHojaExcel.Range("A" & Fila.ToString & ":H" & Fila.ToString).Merge()
            objHojaExcel.Range("A" & Fila.ToString).Value = Fila_Elemento("OT_NLABX")
            objHojaExcel.Range("A" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("A" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("A" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("A" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


            objHojaExcel.Range("I" & Fila.ToString & ":N" & Fila.ToString).Merge()
            objHojaExcel.Range("I" & Fila.ToString).Value = Fila_Elemento("RESULTADO")
            objHojaExcel.Range("I" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("I" & Fila.ToString).Font.Size = 9

            objHojaExcel.Range("I" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("I" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("O" & Fila.ToString & ":T" & Fila.ToString).Merge()
            objHojaExcel.Range("O" & Fila.ToString).Value = ""
            objHojaExcel.Range("O" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("O" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("O" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            objHojaExcel.Range("O" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            objHojaExcel.Range("U" & Fila.ToString & ":DJ" & Fila.ToString).Merge()
            objHojaExcel.Range("U" & Fila.ToString).Value = Fila_Elemento("OBSERVACION")
            objHojaExcel.Range("U" & Fila.ToString).Font.Name = "Times New Roman"
            objHojaExcel.Range("U" & Fila.ToString).Font.Size = 9
            objHojaExcel.Range("U" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            objHojaExcel.Range("U" & Fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            BORDES(objHojaExcel, Fila, Fila, "A", "DJ")
            BORDES_DER(objHojaExcel, "H", Fila, Fila)
            BORDES_DER(objHojaExcel, "N", Fila, Fila)
            BORDES_DER(objHojaExcel, "T", Fila, Fila)
            Fila = Fila + 1

            If Fila = 54 And Num_Pag = 1 Then
                Fila = Fila + 11
                Num_Pag = Num_Pag + 1
            ElseIf Fila = 123 And Num_Pag = 2 Then
                Fila = Fila + 3
                Num_Pag = Num_Pag + 1
            ElseIf Fila = 185 And Num_Pag = 3 Then
                Fila = Fila + 3
                Num_Pag = Num_Pag + 1
            ElseIf Fila = 247 And Num_Pag = 4 Then
                Fila = Fila + 3
                Num_Pag = Num_Pag + 1
            End If
        Next



    End Sub
#End Region

    Private Sub Bt_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Limpiar.Click

        Txt_GasFactor.ResetText()
        Txt_GasNormalidad.ResetText()
        Txt_GasPMuestra.ResetText()

        Txt_LecRes.ResetText()
        Txt_Lect2ºFactor.ResetText()
        Txt_LectAforo.ResetText()
        Txt_LectFactDilucion.ResetText()
        Txt_LectPesoMuestra.ResetText()
        Txt_LectVolAforoAlic.ResetText()
        Txt_LectVolAlicuota.ResetText()
        Txt_1ºDilucion.ResetText()

        Txt_PotFactor.ResetText()
        Txt_PotNormalidad.ResetText()
        Txt_PotPesoMuestra.ResetText()

        Txt_PotNNH4Alicuota.ResetText()
        Txt_PotNNH4Factor.ResetText()
        Txt_PotNNH4Normalidad.ResetText()
        Txt_PotNNH4PMuestra.ResetText()
        Txt_PotNNH4VAforo.ResetText()

        Txt_NNO3Fac2dil.ResetText()
        Txt_NNO3FacDil.ResetText()
        Txt_NNO3FacExt.ResetText()
        Txt_NNO3MasaMuestra.ResetText()
        Txt_NNO3VolAfoAli.ResetText()
        Txt_NNO3VolAli.ResetText()
        Txt_NNO3VolExt.ResetText()

        txt_pyb_elem1.ResetText()
        txt_pyb_elem10.ResetText()
        txt_pyb_elem2.ResetText()
        txt_pyb_elem3.ResetText()
        txt_pyb_elem4.ResetText()
        txt_pyb_elem5.ResetText()
        txt_pyb_elem6.ResetText()
        txt_pyb_elem7.ResetText()
        txt_pyb_elem8.ResetText()
        txt_pyb_elem9.ResetText()
        txt_pyb_tram1.ResetText()
        txt_pyb_tram10.ResetText()
        txt_pyb_tram2.ResetText()
        txt_pyb_tram3.ResetText()
        txt_pyb_tram4.ResetText()
        txt_pyb_tram5.ResetText()
        txt_pyb_tram6.ResetText()
        txt_pyb_tram7.ResetText()
        txt_pyb_tram8.ResetText()
        txt_pyb_tram9.ResetText()

        ' Txt_NLabInicial.ResetText()

        TxtLectura.Visible = False
        TxtNumLab.Visible = False
        Txt_LecRes.Visible = False
        TxtFactor.Visible = False
        Txt_MasaMue.Visible = False
        Txt_VolExt.Visible = False
        Txt_VolAli.Visible = False
        Txt_AfoAli.Visible = False
        Txt_Factor.Visible = False
        Txt_LectResultado.Visible = False
        Txt_LectObservacion.Visible = False
        Txt_LecturaVolumetrico.Visible = False
        Txt_FactorVolumetrico.Visible = False
        Txt_LectPotenciometrico.Text = ""
        Dtg_Potenciometrico.Visible = False

        Cjto_Tablas1.Tables("DIGITACION").Clear()

    End Sub

    Private Sub Limpia_Txtbox()
        TxtLectura.Visible = False
        TxtNumLab.Visible = False
        Txt_LecRes.Visible = False
        TxtFactor.Visible = False
        Txt_MasaMue.Visible = False
        Txt_VolExt.Visible = False
        Txt_VolAli.Visible = False
        Txt_AfoAli.Visible = False
        Txt_Factor.Visible = False
        Txt_LectResultado.Visible = False
        Txt_LectObservacion.Visible = False
        Txt_LecturaVolumetrico.Visible = False
        Txt_FactorVolumetrico.Visible = False
    End Sub

#Region "FORMULAS"

    Private Function sumaY() As Double
        If txt_pyb_elem1.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem1.Text)
        If txt_pyb_elem2.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem2.Text)
        If txt_pyb_elem3.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem3.Text)
        If txt_pyb_elem4.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem4.Text)
        If txt_pyb_elem5.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem5.Text)
        If txt_pyb_elem6.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem6.Text)
        If txt_pyb_elem7.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem7.Text)
        If txt_pyb_elem8.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem8.Text)
        If txt_pyb_elem9.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem9.Text)
        If txt_pyb_elem10.Text <> "" Then sumaY = sumaY + CDbl(txt_pyb_elem10.Text)
        Return sumaY
    End Function
    Private Function sumaY2() As Double
        If txt_pyb_elem1.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem1.Text), 2))
        If txt_pyb_elem2.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem2.Text), 2))
        If txt_pyb_elem3.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem3.Text), 2))
        If txt_pyb_elem4.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem4.Text), 2))
        If txt_pyb_elem5.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem5.Text), 2))
        If txt_pyb_elem6.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem6.Text), 2))
        If txt_pyb_elem7.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem7.Text), 2))
        If txt_pyb_elem8.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem8.Text), 2))
        If txt_pyb_elem9.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem9.Text), 2))
        If txt_pyb_elem10.Text <> "" Then sumaY2 = sumaY2 + CDbl(Pow(CDbl(txt_pyb_elem10.Text), 2))
        Return sumaY2
    End Function
    Private Function NsumalogY() As Double
        If txt_pyb_elem1.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem1.Text)))
        If txt_pyb_elem2.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem2.Text)))
        If txt_pyb_elem3.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem3.Text)))
        If txt_pyb_elem4.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem4.Text)))
        If txt_pyb_elem5.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem5.Text)))
        If txt_pyb_elem6.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem6.Text)))
        If txt_pyb_elem7.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem7.Text)))
        If txt_pyb_elem8.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem8.Text)))
        If txt_pyb_elem9.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem9.Text)))
        If txt_pyb_elem10.Text <> "" Then NsumalogY = NsumalogY + CDbl(Log10(CDbl(txt_pyb_elem10.Text)))
        Return NsumalogY
    End Function
    Private Function NsumalogY2() As Double
        If txt_pyb_elem1.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem1.Text)), 2))
        If txt_pyb_elem2.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem2.Text)), 2))
        If txt_pyb_elem3.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem3.Text)), 2))
        If txt_pyb_elem4.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem4.Text)), 2))
        If txt_pyb_elem5.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem5.Text)), 2))
        If txt_pyb_elem6.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem6.Text)), 2))
        If txt_pyb_elem7.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem7.Text)), 2))
        If txt_pyb_elem8.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem8.Text)), 2))
        If txt_pyb_elem9.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem9.Text)), 2))
        If txt_pyb_elem10.Text <> "" Then NsumalogY2 = NsumalogY2 + CDbl(Pow(Log10(CDbl(txt_pyb_elem10.Text)), 2))
        Return NsumalogY2
    End Function
    Private Function sumalogX() As Double
        If txt_pyb_tram1.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram1.Text)))
        If txt_pyb_tram2.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram2.Text)))
        If txt_pyb_tram3.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram3.Text)))
        If txt_pyb_tram4.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram4.Text)))
        If txt_pyb_tram5.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram5.Text)))
        If txt_pyb_tram6.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram6.Text)))
        If txt_pyb_tram7.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram7.Text)))
        If txt_pyb_tram8.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram8.Text)))
        If txt_pyb_tram9.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram9.Text)))
        If txt_pyb_tram10.Text <> "" Then sumalogX = sumalogX + CDbl(Log10(CDbl(txt_pyb_tram10.Text)))
        Return sumalogX
    End Function
    Private Function sumalogX2() As Double
        If txt_pyb_tram1.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram1.Text)), 2))
        If txt_pyb_tram2.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram2.Text)), 2))
        If txt_pyb_tram3.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram3.Text)), 2))
        If txt_pyb_tram4.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram4.Text)), 2))
        If txt_pyb_tram5.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram5.Text)), 2))
        If txt_pyb_tram6.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram6.Text)), 2))
        If txt_pyb_tram7.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram7.Text)), 2))
        If txt_pyb_tram8.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram8.Text)), 2))
        If txt_pyb_tram9.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram9.Text)), 2))
        If txt_pyb_tram10.Text <> "" Then sumalogX2 = sumalogX2 + CDbl(Pow(Log10(CDbl(txt_pyb_tram10.Text)), 2))
        Return sumalogX2
    End Function
    Private Function NsumaX() As Double
        If txt_pyb_tram1.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram1.Text)
        If txt_pyb_tram2.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram2.Text)
        If txt_pyb_tram3.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram3.Text)
        If txt_pyb_tram4.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram4.Text)
        If txt_pyb_tram5.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram5.Text)
        If txt_pyb_tram6.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram6.Text)
        If txt_pyb_tram7.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram7.Text)
        If txt_pyb_tram8.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram8.Text)
        If txt_pyb_tram9.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram9.Text)
        If txt_pyb_tram10.Text <> "" Then NsumaX = NsumaX + CDbl(txt_pyb_tram10.Text)
        Return NsumaX
    End Function
    Private Function NsumaX2() As Double
        If txt_pyb_tram1.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram1.Text), 2))
        If txt_pyb_tram2.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram2.Text), 2))
        If txt_pyb_tram3.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram3.Text), 2))
        If txt_pyb_tram4.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram4.Text), 2))
        If txt_pyb_tram5.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram5.Text), 2))
        If txt_pyb_tram6.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram6.Text), 2))
        If txt_pyb_tram7.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram7.Text), 2))
        If txt_pyb_tram8.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram8.Text), 2))
        If txt_pyb_tram9.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram9.Text), 2))
        If txt_pyb_tram10.Text <> "" Then NsumaX2 = NsumaX2 + CDbl(Pow(CDbl(txt_pyb_tram10.Text), 2))
        Return NsumaX2
    End Function
    Private Function sumalogXY(ByRef n As Integer) As Double
        If txt_pyb_elem1.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram1.Text)) * CDbl(txt_pyb_elem1.Text)) : n = n + 1
        If txt_pyb_elem2.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram2.Text)) * CDbl(txt_pyb_elem2.Text)) : n = n + 1
        If txt_pyb_elem3.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram3.Text)) * CDbl(txt_pyb_elem3.Text)) : n = n + 1
        If txt_pyb_elem4.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram4.Text)) * CDbl(txt_pyb_elem4.Text)) : n = n + 1
        If txt_pyb_elem5.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram5.Text)) * CDbl(txt_pyb_elem5.Text)) : n = n + 1
        If txt_pyb_elem6.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram6.Text)) * CDbl(txt_pyb_elem6.Text)) : n = n + 1
        If txt_pyb_elem7.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram7.Text)) * CDbl(txt_pyb_elem7.Text)) : n = n + 1
        If txt_pyb_elem8.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram8.Text)) * CDbl(txt_pyb_elem8.Text)) : n = n + 1
        If txt_pyb_elem9.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram9.Text)) * CDbl(txt_pyb_elem9.Text)) : n = n + 1
        If txt_pyb_elem10.Text <> "" Then sumalogXY = sumalogXY + CDbl(Log10(CDbl(txt_pyb_tram10.Text)) * CDbl(txt_pyb_elem10.Text)) : n = n + 1
        Return sumalogXY
    End Function
    Private Function NsumalogYX(ByRef n As Integer) As Double
        If txt_pyb_elem1.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem1.Text)) * CDbl(txt_pyb_tram1.Text)) : n = n + 1
        If txt_pyb_elem2.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem2.Text)) * CDbl(txt_pyb_tram2.Text)) : n = n + 1
        If txt_pyb_elem3.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem3.Text)) * CDbl(txt_pyb_tram3.Text)) : n = n + 1
        If txt_pyb_elem4.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem4.Text)) * CDbl(txt_pyb_tram4.Text)) : n = n + 1
        If txt_pyb_elem5.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem5.Text)) * CDbl(txt_pyb_tram5.Text)) : n = n + 1
        If txt_pyb_elem6.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem6.Text)) * CDbl(txt_pyb_tram6.Text)) : n = n + 1
        If txt_pyb_elem7.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem7.Text)) * CDbl(txt_pyb_tram7.Text)) : n = n + 1
        If txt_pyb_elem8.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem8.Text)) * CDbl(txt_pyb_tram8.Text)) : n = n + 1
        If txt_pyb_elem9.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem9.Text)) * CDbl(txt_pyb_tram9.Text)) : n = n + 1
        If txt_pyb_elem10.Text <> "" Then NsumalogYX = NsumalogYX + CDbl(Log10(CDbl(txt_pyb_elem10.Text)) * CDbl(txt_pyb_tram10.Text)) : n = n + 1
        Return NsumalogYX
    End Function
#End Region

#Region "Calculo Factor "
    Private Sub FDil1()
        Dim vAfo, pMue As Double
        vAfo = CDbl(Txt_LectAforo.Text)
        pMue = CDbl(Txt_LectPesoMuestra.Text)
        Dilucion1 = vAfo / pMue
        Txt_1ºDilucion.Text = Round(Dilucion1, 2)
    End Sub
    Private Function Factor1(ByVal Volumen As Double, ByVal Masa As Double)
        Factor1 = Volumen / Masa
        Return Factor1
    End Function

    Private Function Factor2(ByVal VAfoAli As Double, ByVal VAlic As Double)
        Factor2 = VAfoAli / VAlic
        Return Factor2
    End Function

    Private Function Fac_Final(ByVal Fac1 As Double, ByVal Fac2 As Double)
        Fac_Final = Fac1 * Fac2
        Return Fac_Final
    End Function

    Private Sub FDil2()
        Dim vAli, vAgu, vAfoAli As Double
        If Txt_LectVolAlicuota.Text = "" Then
            vAli = 1
        Else
            vAli = CDbl(Txt_LectVolAlicuota.Text)
        End If

        If Txt_LectVolAforoAlic.Text = "" Then
            vAfoAli = 1
        Else
            vAfoAli = CDbl(Txt_LectVolAforoAlic.Text)
        End If
        Dilucion2 = vAfoAli / vAli
        Txt_Lect2ºFactor.Text = Round(Dilucion2, 2)
salto:
    End Sub

    Private Sub FacDil()
        FDilucion = CDbl(Txt_1ºDilucion.Text) * Dilucion2
        Txt_LectFactDilucion.Text = Round(FDilucion, 3)
    End Sub

    Private Sub FacCalculo()
        Dim Normalidad, PAtomico, FacConv, PMuestra As Double
        Normalidad = CDbl(Txt_GasNormalidad.Text)
        PAtomico = CDbl(Txt_PAtomico.Text)
        FacConv = CDbl(txt_FacConv.Text)
        PMuestra = CDbl(Txt_GasPMuestra.Text)
        FCalculo = (Normalidad * PAtomico * FacConv) / PMuestra
        Txt_GasFactor.Text = Round(FCalculo, 3)
    End Sub

    Private Sub FacPotenciometrico()
        Dim Norm, Patomico, FacConv, Pmuestra As Double
        Norm = CDbl(Txt_PotNormalidad.Text)
        Patomico = CDbl(Txt_PotPesoAtomico.Text)
        FacConv = CDbl(Txt_PotFactConv.Text)
        Pmuestra = CDbl(Txt_PotPesoMuestra.Text)
        FCalPoten = (Norm * Patomico * FacConv) / Pmuestra
        Txt_PotFactor.Text = FCalPoten
    End Sub

    Private Sub FacNNH4()
        Dim Normalidad, VAforo, PAtomico, FConv, PesoMuestra, AlicuotaTomada As Double
        Normalidad = CDbl(Txt_PotNNH4Normalidad.Text)
        VAforo = CDbl(Txt_PotNNH4VAforo.Text)
        PAtomico = CDbl(Txt_PotNNH4PesoAtomico.Text)
        FConv = CDbl(Txt_PotNNH4FacConvercion.Text)
        PesoMuestra = CDbl(Txt_PotNNH4PMuestra.Text)
        AlicuotaTomada = CDbl(Txt_PotNNH4Alicuota.Text)
        FCalNNH4 = (Normalidad * VAforo * PAtomico * FConv) / (PesoMuestra * AlicuotaTomada)
        Txt_PotNNH4Factor.Text = FCalNNH4
    End Sub

    ' LLamada a los procesos y posicion del cursor

    Private Sub Txt_LectPesoMuestra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectPesoMuestra.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_LectPesoMuestra.Text = Txt_LectPesoMuestra.Text.Replace(".", ",")
            Round(CDbl(Txt_LectPesoMuestra.Text), 2)
            Txt_LectAforo.Focus()
        End If
    End Sub
    Private Sub Txt_LectAforo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectAforo.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_LectAforo.Text = Txt_LectAforo.Text.Replace(".", ",")
            Call FDil1()
            Txt_LectVolAlicuota.Focus()
        End If
    End Sub

    Private Sub Txt_LectVolAlicuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectVolAlicuota.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_LectVolAlicuota.Text = Txt_LectVolAlicuota.Text.Replace(".", ",")
            Txt_LectVolAforoAlic.Focus()
        End If
    End Sub

    Private Sub Valida(ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If e.KeyChar.IsLetter(e.KeyChar) Then
            MsgBox("Error en el ingreso de datos")
        End If

    End Sub

    Private Sub Txt_LectVolAforoAlic_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectVolAforoAlic.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_LectVolAforoAlic.Text = Txt_LectVolAforoAlic.Text.Replace(".", ",")
            Call FDil2()
            Call FacDil()
        End If
    End Sub

    ' Focus de los textbox del Metodo Volumetrico

    Private Sub Txt_GasNormalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_GasNormalidad.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_GasNormalidad.Text = Txt_GasNormalidad.Text.Replace(".", ",")
            Txt_GasPMuestra.Focus()
        End If
    End Sub
    Private Sub Txt_GasPMuestra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_GasPMuestra.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_GasPMuestra.Text = Txt_GasPMuestra.Text.Replace(".", ",")
            Call FacCalculo()
            Bt_Carga.Focus()
        End If
    End Sub

    ' Focus grupo Potenciometrico

    Private Sub Txt_PotNormalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotNormalidad.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotNormalidad.Text = Txt_PotNormalidad.Text.Replace(".", ",")
            Txt_PotPesoMuestra.Focus()
        End If
    End Sub

    Private Sub Txt_PotPesoMuestra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotPesoMuestra.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotPesoMuestra.Text = Txt_PotPesoMuestra.Text.Replace(".", ",")
            Call FacPotenciometrico()
            Bt_Carga.Focus()
        End If
    End Sub

    ' Focus Potenciometrico NNH4

    Private Sub Txt_PotNNH4Normalidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotNNH4Normalidad.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotNNH4Normalidad.Text = Txt_PotNNH4Normalidad.Text.Replace(".", ",")
            Txt_PotNNH4PMuestra.Focus()
        End If
    End Sub

    Private Sub Txt_PotNNH4VAforo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotNNH4VAforo.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotNNH4VAforo.Text = Txt_PotNNH4VAforo.Text.Replace(".", ",")
            Call FacNNH4()
            Bt_Carga.Focus()

        End If
    End Sub

    Private Sub Txt_PotNNH4PMuestra_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotNNH4PMuestra.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotNNH4PMuestra.Text = Txt_PotNNH4PMuestra.Text.Replace(".", ",")
            Txt_PotNNH4Alicuota.Focus()
        End If
    End Sub

    Private Sub Txt_PotNNH4Alicuota_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PotNNH4Alicuota.KeyPress
        Call Valida(e)
        If e.KeyChar = Chr(13) Then
            Txt_PotNNH4Alicuota.Text = Txt_PotNNH4Alicuota.Text.Replace(".", ",")
            Txt_PotNNH4VAforo.Focus()
        End If
    End Sub

#End Region


    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Try
            If Tit_Formula = "Colorimétrico" Or Tit_Formula = "Potenciométrico" Or Tit_Formula = "Volumétrico" Or Tit_Formula = "VolumétricoNNH4" Then
                Call Graba(Dtp_FechaAnalisis.Text, Dtp_FechaDigitacion.Text, Elemento, Cbx_Analista.Text, Cbx_Digitador.Text, CodAna)
            ElseIf Tit_Formula = "EAA" Then
                Call Graba_EAA(Dtp_FechaAnalisis.Text, Dtp_FechaDigitacion.Text, Elemento, Cbx_Analista.Text, Cbx_Digitador.Text, CodAna)
            Else
                Call Graba_LecturaDirecta(Dtp_FechaAnalisis.Text, Dtp_FechaDigitacion.Text, Elemento, Cbx_Analista.Text, Cbx_Digitador.Text, CodAna)
            End If
        Catch ex As Exception
            MsgBox("error en proc: Bt_Graba_Click " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Lnk_ChekeoNorm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lnk_ChekeoNorm.LinkClicked
        Dim aa As New Frm_Chequeo
        aa.Show()
    End Sub

    Private Sub Lnk_PotChequeo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles Lnk_PotChequeo.LinkClicked
        Dim aa As New Frm_Chequeo
        aa.Show()
    End Sub

#Region "Focus Curva"

    Private Sub txt_pyb_elem1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem1.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem1.Text = txt_pyb_elem1.Text.Replace(".", ",")
            txt_pyb_elem2.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem2.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem2.Text = txt_pyb_elem2.Text.Replace(".", ",")
            txt_pyb_elem3.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem3.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem3.Text = txt_pyb_elem3.Text.Replace(".", ",")
            txt_pyb_elem4.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem4.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem4.Text = txt_pyb_elem4.Text.Replace(".", ",")
            txt_pyb_elem5.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem5.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem5.Text = txt_pyb_elem5.Text.Replace(".", ",")
            txt_pyb_elem6.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem6.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem6.Text = txt_pyb_elem6.Text.Replace(".", ",")
            txt_pyb_elem7.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem7.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem7.Text = txt_pyb_elem7.Text.Replace(".", ",")
            txt_pyb_elem8.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem8.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem8.Text = txt_pyb_elem8.Text.Replace(".", ",")
            txt_pyb_elem9.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem9.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem9.Text = txt_pyb_elem9.Text.Replace(".", ",")
            txt_pyb_elem10.Focus()
        End If
    End Sub

    Private Sub txt_pyb_elem10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_elem10.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_elem10.Text = txt_pyb_elem10.Text.Replace(".", ",")
            txt_pyb_tram1.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram1.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram1.Text = txt_pyb_tram1.Text.Replace(".", ",")
            txt_pyb_tram2.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram2.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram2.Text = txt_pyb_tram2.Text.Replace(".", ",")
            txt_pyb_tram3.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram3.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram3.Text = txt_pyb_tram3.Text.Replace(".", ",")
            txt_pyb_tram4.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram4.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram4.Text = txt_pyb_tram4.Text.Replace(".", ",")
            txt_pyb_tram5.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram5.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram5.Text = txt_pyb_tram5.Text.Replace(".", ",")
            txt_pyb_tram6.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram6.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram6.Text = txt_pyb_tram6.Text.Replace(".", ",")
            txt_pyb_tram7.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram7.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram7.Text = txt_pyb_tram7.Text.Replace(".", ",")
            txt_pyb_tram8.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram8.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram8.Text = txt_pyb_tram8.Text.Replace(".", ",")
            txt_pyb_tram9.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram9.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram9.Text = txt_pyb_tram9.Text.Replace(".", ",")
            txt_pyb_tram10.Focus()
        End If
    End Sub

    Private Sub txt_pyb_tram10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_pyb_tram10.KeyPress
        If e.KeyChar = Chr(13) Then
            txt_pyb_tram10.Text = txt_pyb_tram10.Text.Replace(".", ",")
        End If
    End Sub

#End Region

#Region " Focus Texbox editables grilla"
    Private Sub Txt_MasaMue_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_MasaMue.KeyPress
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            Txt_MasaMue.Text = Txt_MasaMue.Text.Replace(".", ",")

            If Dtg_Digitado.Visible = True Then
                Dtg_Digitado.Item(Fila_Lectura, 1) = Txt_MasaMue.Text
                Txt_MasaMue.Visible = False

                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura
                Dtg_Digitado.CurrentCell = mycell

                Me.Txt_VolExt.Focus()
            End If

            If Dtg_DigitaNNO3.Visible = True Then
                Dtg_DigitaNNO3.Item(Fila_Lectura, 1) = Txt_MasaMue.Text
                Txt_MasaMue.Visible = False

                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura
                Dtg_DigitaNNO3.CurrentCell = mycell

                Me.Txt_VolExt.Focus()

            End If


        End If
    End Sub


    Private Sub Txt_VolExt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_VolExt.KeyPress
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            Txt_VolExt.Text = Txt_VolExt.Text.Replace(".", ",")
            If Dtg_Digitado.Visible = True Then
                Dtg_Digitado.Item(Fila_Lectura, 2) = Txt_VolExt.Text
                Txt_VolExt.Visible = False

                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_Digitado.CurrentCell = mycell

                Me.Txt_VolAli.Focus()
            End If

            If Dtg_DigitaNNO3.Visible = True Then
                Dtg_DigitaNNO3.Item(Fila_Lectura, 2) = Txt_VolExt.Text
                Txt_VolExt.Visible = False

                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_DigitaNNO3.CurrentCell = mycell

                Me.Txt_VolAli.Focus()
            End If


        End If
    End Sub

    Private Sub Txt_VolAli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_VolAli.KeyPress
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            Txt_VolAli.Text = Txt_VolAli.Text.Replace(".", ",")

            If Dtg_Digitado.Visible = True Then
                Dtg_Digitado.Item(Fila_Lectura, 3) = Txt_VolAli.Text
                Txt_VolAli.Visible = False

                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_Digitado.CurrentCell = mycell

                Me.Txt_AfoAli.Focus()
            End If

            If Dtg_DigitaNNO3.Visible = True Then
                Dtg_DigitaNNO3.Item(Fila_Lectura, 3) = Txt_VolAli.Text
                Txt_VolAli.Visible = False

                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_DigitaNNO3.CurrentCell = mycell

                Me.Txt_AfoAli.Focus()

            End If

        End If
    End Sub

    Private Sub Txt_AfoAli_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_AfoAli.KeyPress
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            Txt_AfoAli.Text = Txt_AfoAli.Text.Replace(".", ",")

            If Dtg_Digitado.Visible = True Then
                Dtg_Digitado.Item(Fila_Lectura, 4) = Txt_AfoAli.Text
                Txt_AfoAli.Visible = False

                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_Digitado.CurrentCell = mycell

            End If

            If Dtg_DigitaNNO3.Visible = True Then
                Dtg_DigitaNNO3.Item(Fila_Lectura, 4) = Txt_AfoAli.Text
                Txt_AfoAli.Visible = False

                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_DigitaNNO3.CurrentCell = mycell

            End If
        End If
    End Sub

#End Region

#Region "Focus Grupo NNO3"
    Private Sub Txt_NNO3MasaMuestra_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NNO3MasaMuestra.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NNO3MasaMuestra.Text = Txt_NNO3MasaMuestra.Text.Replace(".", ",")
            Txt_NNO3VolExt.Focus()
        End If
    End Sub

    Private Sub Txt_NNO3VolExt_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NNO3VolExt.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NNO3VolExt.Text = Txt_NNO3VolExt.Text.Replace(".", ",")
            Txt_NNO3FacExt.Text = Factor1(CDbl(Txt_NNO3VolExt.Text), CDbl(Txt_NNO3MasaMuestra.Text))
            Txt_NNO3VolAli.Focus()
        End If
    End Sub

    Private Sub Txt_NNO3VolAli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NNO3VolAli.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NNO3VolAli.Text = Txt_NNO3VolAli.Text.Replace(".", ",")
            Txt_NNO3VolAfoAli.Focus()
        End If
    End Sub

    Private Sub Txt_NNO3VolAfoAli_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NNO3VolAfoAli.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_NNO3VolAfoAli.Text = Txt_NNO3VolAfoAli.Text.Replace(".", ",")
            If Txt_NNO3VolAfoAli.Text = "" Then Txt_NNO3VolAfoAli.Text = 1
            If Txt_NNO3VolAli.Text = "" Then Txt_NNO3VolAli.Text = 1
            Txt_NNO3Fac2dil.Text = Factor2(CDbl(Txt_NNO3VolAfoAli.Text), CDbl(Txt_NNO3VolAli.Text))
            Txt_NNO3FacDil.Text = Fac_Final(CDbl(Txt_NNO3FacExt.Text), CDbl(Txt_NNO3Fac2dil.Text))

        End If
    End Sub
#End Region

    Private Sub Dtg_DigitaNNO3_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_DigitaNNO3.CurrentCellChanged
        Try
            Dim mycell As New DataGridCell
            Dim numerofil, Mypos As Integer
            Dim myHitTest As DataGrid.HitTestInfo

            If TxtLectura.Visible = True Then TxtLectura.Visible = False
            If TxtNumLab.Visible = True Then TxtNumLab.Visible = False
            If Txt_MasaMue.Visible = True Then Txt_MasaMue.Visible = False
            If Txt_VolExt.Visible = True Then Txt_VolExt.Visible = False
            If Txt_VolAli.Visible = True Then Txt_VolAli.Visible = False
            If Txt_AfoAli.Visible = True Then Txt_AfoAli.Visible = False

            Fila_Lectura = Dtg_DigitaNNO3.CurrentCell.RowNumber()
            Revision_Digitacion = "N"
            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 6 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                TxtLectura.Left = Posicionx
                TxtLectura.Top = Posiciony
                TxtLectura.Height = CeldaAlto
                TxtLectura.Width = CeldaAncho
                TxtLectura.Visible = True
                TxtLectura.Text = ""
                TxtLectura.Enabled = True
                TxtLectura.TabIndex = 15
                SendKeys.Send("^{TAB}")
                TxtLectura.Focus()
                Try
                    Mypos = InStr(Dtg_DigitaNNO3.Item(Fila_Lectura, 0), "BLPromedio")
                    If Mypos > 0 Then
                        Dtg_DigitaNNO3.Item(Fila_Lectura, 6) = SacaPromedio()
                    End If
                Catch ex As Exception
                End Try

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 6)) = False Then TxtLectura.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 6) : Exit Sub
            End If

            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 1 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                Txt_MasaMue.Left = Posicionx
                Txt_MasaMue.Top = Posiciony
                Txt_MasaMue.Height = CeldaAlto
                Txt_MasaMue.Width = CeldaAncho
                Txt_MasaMue.Visible = True
                Txt_MasaMue.Text = ""
                Txt_MasaMue.Enabled = True
                Txt_MasaMue.TabIndex = 47
                SendKeys.Send("^{TAB}")
                Txt_MasaMue.Focus()

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 1)) = False Then Txt_MasaMue.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 1) : Exit Sub
            End If

            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 2 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                Txt_VolExt.Left = Posicionx
                Txt_VolExt.Top = Posiciony
                Txt_VolExt.Height = CeldaAlto
                Txt_VolExt.Width = CeldaAncho
                Txt_VolExt.Visible = True
                Txt_VolExt.Text = ""
                Txt_VolExt.Enabled = True
                Txt_VolExt.TabIndex = 48
                SendKeys.Send("^{TAB}")
                Txt_VolExt.Focus()

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 2)) = False Then Txt_VolExt.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 2) : Exit Sub
            End If

            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 3 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                Txt_VolAli.Left = Posicionx
                Txt_VolAli.Top = Posiciony
                Txt_VolAli.Height = CeldaAlto
                Txt_VolAli.Width = CeldaAncho
                Txt_VolAli.Visible = True
                Txt_VolAli.Text = ""
                Txt_VolAli.Enabled = True
                Txt_VolAli.TabIndex = 49
                SendKeys.Send("^{TAB}")
                Txt_VolAli.Focus()

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 3)) = False Then Txt_VolAli.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 3) : Exit Sub
            End If

            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 4 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                Txt_AfoAli.Left = Posicionx
                Txt_AfoAli.Top = Posiciony
                Txt_AfoAli.Height = CeldaAlto
                Txt_AfoAli.Width = CeldaAncho
                Txt_AfoAli.Visible = True
                Txt_AfoAli.Text = ""
                Txt_AfoAli.Enabled = True
                Txt_AfoAli.TabIndex = 50
                SendKeys.Send("^{TAB}")
                Txt_AfoAli.Focus()

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 4)) = False Then Txt_AfoAli.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 4) : Exit Sub
            End If

            If Dtg_DigitaNNO3.CurrentCell.ColumnNumber = 5 Then
                Dim CeldaAlto As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).X + Dtg_DigitaNNO3.Left
                Dim Posiciony As Integer = Dtg_DigitaNNO3.GetCellBounds(Dtg_DigitaNNO3.CurrentCell.RowNumber, Dtg_DigitaNNO3.CurrentCell.ColumnNumber).Y + Dtg_DigitaNNO3.Top
                TxtFactor.Left = Posicionx
                TxtFactor.Top = Posiciony
                TxtFactor.Height = CeldaAlto
                TxtFactor.Width = CeldaAncho
                TxtFactor.Visible = True
                TxtFactor.Text = ""
                TxtFactor.Enabled = True
                TxtFactor.TabIndex = 57
                SendKeys.Send("^{TAB}")
                TxtFactor.Focus()

                If IsDBNull(Dtg_DigitaNNO3.Item(Fila_Lectura, 5)) = False Then TxtFactor.Text = Dtg_DigitaNNO3.Item(Fila_Lectura, 5) : Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error en proc: Dtg_DigitaNNO3_CurrentCellChanged " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Dtg_DigitaVolumetrico_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_DigitaVolumetrico.CurrentCellChanged
        Try
            Dim mycell As New DataGridCell
            Dim numerofil, Mypos As Integer
            Dim myHitTest As DataGrid.HitTestInfo

            If Txt_LecturaVolumetrico.Visible = True Then Txt_LecturaVolumetrico.Visible = False
            If TxtLectura.Visible = True Then TxtLectura.Visible = False
            If TxtNumLab.Visible = True Then TxtNumLab.Visible = False
            If Txt_MasaMue.Visible = True Then Txt_MasaMue.Visible = False
            If Txt_VolExt.Visible = True Then Txt_VolExt.Visible = False
            If Txt_VolAli.Visible = True Then Txt_VolAli.Visible = False
            If Txt_AfoAli.Visible = True Then Txt_AfoAli.Visible = False

            Fila_Lectura = Dtg_DigitaVolumetrico.CurrentCell.RowNumber()
            Revision_Digitacion = "N"
            If Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
            If Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber = 3 Then
                Dim CeldaAlto As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).X + Dtg_DigitaVolumetrico.Left
                Dim Posiciony As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Y + Dtg_DigitaVolumetrico.Top
                Txt_LecturaVolumetrico.Left = Posicionx
                Txt_LecturaVolumetrico.Top = Posiciony
                Txt_LecturaVolumetrico.Height = CeldaAlto
                Txt_LecturaVolumetrico.Width = CeldaAncho
                Txt_LecturaVolumetrico.Visible = True
                Txt_LecturaVolumetrico.Text = ""
                Txt_LecturaVolumetrico.Enabled = True
                Txt_LecturaVolumetrico.TabIndex = 55
                SendKeys.Send("^{TAB}")
                Txt_LecturaVolumetrico.Focus()
                Try
                    Mypos = InStr(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 0), "BLPromedio")
                    If Mypos > 0 Then
                        Dtg_DigitaVolumetrico.Item(Fila_Lectura, 3) = SacaPromedio()
                    End If
                Catch ex As Exception
                End Try

                If IsDBNull(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 3)) = False Then Txt_LecturaVolumetrico.Text = Dtg_DigitaVolumetrico.Item(Fila_Lectura, 3) : Exit Sub
            End If

            If Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber = 2 Then
                Dim CeldaAlto As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).X + Dtg_DigitaVolumetrico.Left
                Dim Posiciony As Integer = Dtg_DigitaVolumetrico.GetCellBounds(Dtg_DigitaVolumetrico.CurrentCell.RowNumber, Dtg_DigitaVolumetrico.CurrentCell.ColumnNumber).Y + Dtg_DigitaVolumetrico.Top
                Txt_FactorVolumetrico.Left = Posicionx
                Txt_FactorVolumetrico.Top = Posiciony
                Txt_FactorVolumetrico.Height = CeldaAlto
                Txt_FactorVolumetrico.Width = CeldaAncho
                Txt_FactorVolumetrico.Visible = True
                Txt_FactorVolumetrico.Text = ""
                Txt_FactorVolumetrico.Enabled = True
                Txt_FactorVolumetrico.TabIndex = 56
                SendKeys.Send("^{TAB}")
                Txt_FactorVolumetrico.Focus()

                If IsDBNull(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 2)) = False Then Txt_FactorVolumetrico.Text = Dtg_DigitaVolumetrico.Item(Fila_Lectura, 2) : Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error en proc: Dtg_DigitaVolumetrico_CurrentCellChanged " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Txt_LecturaVolumetrico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LecturaVolumetrico.KeyPress
        Try
            Dim mycell As New DataGridCell
            Dim Lec_aux, Resultado As Double
            Dim query, gatos, Formato, CanDec, Resultado_Paso As String
            Dim Mypos, Fila_Promedio, Decimales As Integer
            Dim ARRIBA, BAJO1, BAJO2, BAJO3, RCoe, BsumalogYX, BsumalogY, BsumalogY2, BsumaX, BsumaX2, BsumalogXY, BsumaLogX, BsumaLogX2, BsumaY, BsumaY2 As Double
            Dim A1, A2, B1, B2, B3, B4 As Double
            Dim n As Integer
            Dim con As New SqlConnection(Conexion1)
            Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado

            gatos = "######" : CanDec = "000000"
            Formato = Mid(gatos, 1, EntRes) & "." & Mid(gatos, 1, DecRes)


            If (e.KeyChar.IsLetter(e.KeyChar)) Then
                MsgBox("Error en la Digitacion")
                Txt_LecturaVolumetrico.ResetText()
            Else

                If e.KeyChar = Chr(13) And Txt_LecturaVolumetrico.Text <> "" Then
                    Txt_LecturaVolumetrico.Text = Txt_LecturaVolumetrico.Text.Replace(".", ",")
                    Txt_LecturaVolumetrico.Text.Format(Formato)

                    Mypos = InStr(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 0), "Blanco")
                    If Mypos > 0 Or InStr(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 0), "Promedio") > 0 Then
                        Dtg_DigitaVolumetrico.Item(Fila_Lectura, 3) = Txt_LecturaVolumetrico.Text
                        Ultimo_Blanco = CDbl(Txt_LecturaVolumetrico.Text)
                    Else
                        Dtg_DigitaVolumetrico.Item(Fila_Lectura, 3) = Txt_LecturaVolumetrico.Text

                        If Tit_Formula = "Volumétrico" Or Tit_Formula = "VolumétricoNNH4" Then
                            Resultado = Gasto_Blanco_Factor(CDbl(Txt_LecturaVolumetrico.Text), Ultimo_Blanco, CDbl(Dtg_DigitaVolumetrico.Item(Fila_Lectura, 2)))
                            If Unidad = "%" Then
                                Resultado = Resultado / 10000
                            End If
                            If Unidad = "meq/l" Then
                                Resultado = Resultado / Peso_Atomico
                            End If
                            If Unidad = "meq/100g" Then
                                Resultado = Resultado / (Peso_Atomico * 10)
                            End If
                            If Unidad = "g/kg" Then
                                Resultado = Resultado / 1000
                            End If
                            If Unidad = "mg/100g" Then
                                Resultado = Resultado / 10
                            End If
                        End If


                        With sp
                            .Inicializar()
                            .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                            .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                            Mascara = .EjecutarEscalar("usp_RescataMascara")
                        End With

                        Dtg_DigitaVolumetrico.Item(Fila_Lectura, 4) = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))
                    End If
SaltoxPromedio:
                    Me.Txt_LecturaVolumetrico.Focus()
                    mycell.ColumnNumber = 3
                    mycell.RowNumber = Fila_Lectura + 1
                    Dtg_DigitaVolumetrico.CurrentCell = mycell

                End If
            End If

        Catch ex As Exception
            MsgBox("error en proc: Txt_LecturaVolumetrico_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Txt_FactorVolumetrico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_FactorVolumetrico.KeyPress
        Try
            Dim mycell As New DataGridCell

            If e.KeyChar = Chr(13) Then
                Txt_FactorVolumetrico.Text = Txt_FactorVolumetrico.Text.Replace(".", ",")
                Dtg_DigitaVolumetrico.Item(Fila_Lectura, 2) = Txt_FactorVolumetrico.Text
                Txt_FactorVolumetrico.Visible = False
                mycell.ColumnNumber = 3
                mycell.ColumnNumber = Fila_Lectura
                Dtg_DigitaVolumetrico.CurrentCell = mycell
            End If
        Catch ex As Exception
            MsgBox("error en proc: Txt_FactorVolumetrico_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub TxtFactor_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFactor.KeyPress
        Try
            Dim mycell As New DataGridCell

            If e.KeyChar = Chr(13) Then
                TxtFactor.Text = TxtFactor.Text.Replace(".", ",")
                If Dtg_Digitado.Visible = True Then
                    Dtg_Digitado.Item(Fila_Lectura, 5) = TxtFactor.Text
                    TxtFactor.Visible = False

                    mycell.ColumnNumber = 6
                    mycell.RowNumber = Fila_Lectura
                    Dtg_Digitado.CurrentCell = mycell
                End If
                If Dtg_DigitaNNO3.Visible = True Then
                    Dtg_DigitaNNO3.Item(Fila_Lectura, 5) = TxtFactor.Text
                    TxtFactor.Visible = False
                    mycell.ColumnNumber = 6
                    mycell.RowNumber = Fila_Lectura
                    Dtg_DigitaNNO3.CurrentCell = mycell
                End If

            End If

        Catch ex As Exception
            MsgBox("error en proc: TxtFactor_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Dtg_Lectura_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Lectura.CurrentCellChanged
        Try

       
            Dim mycell As New DataGridCell
            Dim numerofil, Mypos As Integer
            Dim myHitTest As DataGrid.HitTestInfo

            If Txt_LectResultado.Visible = True Then Txt_LectResultado.Visible = False
            If Txt_LectObservacion.Visible = True Then Txt_LectObservacion.Visible = False

            Fila_Lectura = Dtg_Lectura.CurrentCell.RowNumber()
            Revision_Digitacion = "N"
            If Dtg_Lectura.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
            If Dtg_Lectura.CurrentCell.ColumnNumber = 1 Then
                Dim CeldaAlto As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).X + Dtg_Lectura.Left
                Dim Posiciony As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Y + Dtg_Lectura.Top
                Txt_LectResultado.Left = Posicionx
                Txt_LectResultado.Top = Posiciony
                Txt_LectResultado.Height = CeldaAlto
                Txt_LectResultado.Width = CeldaAncho
                Txt_LectResultado.Visible = True
                Txt_LectResultado.Text = ""
                Txt_LectResultado.Enabled = True
                Txt_LectResultado.TabIndex = 59
                SendKeys.Send("^{TAB}")
                Txt_LectResultado.Focus()
                If IsDBNull(Dtg_Lectura.Item(Fila_Lectura, 1)) = False Then Txt_LectResultado.Text = Dtg_Lectura.Item(Fila_Lectura, 1)
            End If

            If Dtg_Lectura.CurrentCell.ColumnNumber = 2 Then
                Dim CeldaAlto As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).X + Dtg_Lectura.Left
                Dim Posiciony As Integer = Dtg_Lectura.GetCellBounds(Dtg_Lectura.CurrentCell.RowNumber, Dtg_Lectura.CurrentCell.ColumnNumber).Y + Dtg_Lectura.Top
                Txt_LectObservacion.Left = Posicionx
                Txt_LectObservacion.Top = Posiciony
                Txt_LectObservacion.Height = CeldaAlto
                Txt_LectObservacion.Width = CeldaAncho
                Txt_LectObservacion.Visible = True
                Txt_LectObservacion.Text = ""
                Txt_LectObservacion.Enabled = True
                Txt_LectObservacion.TabIndex = 60
                SendKeys.Send("^{TAB}")
                Txt_LectObservacion.Focus()
            End If
        Catch ex As Exception
            MsgBox("error en proc: Dtg_Lectura_CurrentCellChanged " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Txt_LectResultado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectResultado.KeyPress
        Try
            Dim mycell As New DataGridCell
            Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim Resultado As Double

            If e.KeyChar = Chr(13) Then
                Txt_LectResultado.Text = Txt_LectResultado.Text.Replace(".", ",")
                Resultado = Txt_LectResultado.Text

                With sp
                    .Inicializar()
                    .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                    .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                    Mascara = .EjecutarEscalar("usp_RescataMascara")
                End With

                Dtg_Lectura.Item(Fila_Lectura, 1) = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))

                Txt_LectResultado.Visible = False
                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura
                Dtg_Lectura.CurrentCell = mycell
            End If
        Catch ex As Exception
            MsgBox("error en proc: Txt_LectResultado_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Txt_LectObservacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectObservacion.KeyPress
        Try
            Dim mycell As New DataGridCell

            If e.KeyChar = Chr(13) Then
                Dtg_Lectura.Item(Fila_Lectura, 2) = Txt_LectObservacion.Text
                Txt_LectResultado.Visible = False
                mycell.ColumnNumber = 1
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_Lectura.CurrentCell = mycell
            End If
        Catch ex As Exception
            MsgBox("error en proc: Txt_LectObservacion_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Txt_NLabDesde_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_NLabDesde.KeyPress
        Try
            If e.KeyChar = Chr(13) Then
                Txt_NLabHasta.Focus()
            End If
        Catch ex As Exception
            MsgBox("error en proc: Txt_NLabDesde_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Carga_Grilla_El()
        Try
            Dim Dat As DataRow
            Dim Filas_Seleccionadas As DataRow()
            Dim dv As DataView = New DataView(Cjto_Tablas1.Tables("ELEMENTOS_DIGITA"))
            dv.RowFilter = "ELE_FRECUENCIA='FR'"
            Dtg_Elementos.DataSource = dv
        Catch ex As Exception
            MsgBox("error en proc: Carga_Grilla_El " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub Dtg_Potenciometrico_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Potenciometrico.CurrentCellChanged
        Try
            Dim mycell As New DataGridCell
            Dim numerofil, Mypos As Integer
            Dim myHitTest As DataGrid.HitTestInfo
            If Txt_LectPotenciometrico.Visible = True Then Txt_LectPotenciometrico.Visible = False
            Fila_Lectura = Dtg_Potenciometrico.CurrentCell.RowNumber()
            Revision_Digitacion = "N"
            If Dtg_Potenciometrico.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"
            If Dtg_Potenciometrico.CurrentCell.ColumnNumber = 3 Then
                Dim CeldaAlto As Integer = Dtg_Potenciometrico.GetCellBounds(Dtg_Potenciometrico.CurrentCell.RowNumber, Dtg_Potenciometrico.CurrentCell.ColumnNumber).Height
                Dim CeldaAncho As Integer = Dtg_Potenciometrico.GetCellBounds(Dtg_Potenciometrico.CurrentCell.RowNumber, Dtg_Potenciometrico.CurrentCell.ColumnNumber).Width
                Dim Posicionx As Integer = Dtg_Potenciometrico.GetCellBounds(Dtg_Potenciometrico.CurrentCell.RowNumber, Dtg_Potenciometrico.CurrentCell.ColumnNumber).X + Dtg_Potenciometrico.Left
                Dim Posiciony As Integer = Dtg_Potenciometrico.GetCellBounds(Dtg_Potenciometrico.CurrentCell.RowNumber, Dtg_Potenciometrico.CurrentCell.ColumnNumber).Y + Dtg_Potenciometrico.Top
                Txt_LectPotenciometrico.Left = Posicionx
                Txt_LectPotenciometrico.Top = Posiciony
                Txt_LectPotenciometrico.Height = CeldaAlto
                Txt_LectPotenciometrico.Width = CeldaAncho
                Txt_LectPotenciometrico.Visible = True
                Txt_LectPotenciometrico.Text = ""
                Txt_LectPotenciometrico.Enabled = True
                Txt_LectPotenciometrico.TabIndex = 62
                SendKeys.Send("^{TAB}")
                Txt_LectPotenciometrico.Focus()

                If IsDBNull(Dtg_Potenciometrico.Item(Fila_Lectura, 3)) = False Then Txt_LectPotenciometrico.Text = Dtg_Potenciometrico.Item(Fila_Lectura, 3) : Exit Sub
            End If
        Catch ex As Exception
            MsgBox("error en proc: Dtg_Potenciometrico_CurrentCellChanged " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub Txt_LectPotenciometrico_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_LectPotenciometrico.KeyPress
        Try
            Dim mycell As New DataGridCell
            Dim Lec_aux, Resultado As Double
            Dim query, gatos, Formato, CanDec, Resultado_Paso As String
            Dim Mypos, Fila_Promedio, Decimales As Integer
            Dim ARRIBA, BAJO1, BAJO2, BAJO3, RCoe, BsumalogYX, BsumalogY, BsumalogY2, BsumaX, BsumaX2, BsumalogXY, BsumaLogX, BsumaLogX2, BsumaY, BsumaY2 As Double
            Dim A1, A2, B1, B2, B3, B4 As Double
            Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
            Dim con As New SqlConnection(Conexion1)

            gatos = "######" : CanDec = "000000"
            Formato = Mid(gatos, 1, EntRes) & "." & Mid(gatos, 1, DecRes)

            If Dtg_Potenciometrico.Visible = True Then

                If (e.KeyChar.IsLetter(e.KeyChar)) Then
                    MsgBox("Error en la Digitacion")
                    TxtLectura.ResetText()
                Else

                    If e.KeyChar = Chr(13) And Txt_LectPotenciometrico.Text <> "" Then
                        Txt_LectPotenciometrico.Text = Txt_LectPotenciometrico.Text.Replace(".", ",")
                        Txt_LectPotenciometrico.Text.Format(Formato)

                        Mypos = InStr(Dtg_Potenciometrico.Item(Fila_Lectura, 0), "Blanco")
                        If Mypos > 0 Or InStr(Dtg_Potenciometrico.Item(Fila_Lectura, 0), "Promedio") > 0 Then
                            Dtg_Potenciometrico.Item(Fila_Lectura, 3) = Txt_LectPotenciometrico.Text
                            Ultimo_Blanco = CDbl(Txt_LectPotenciometrico.Text)
                        Else
                            Dtg_Potenciometrico.Item(Fila_Lectura, 3) = Txt_LectPotenciometrico.Text

                            If Tit_Formula = "Potenciométrico" Then
                                Resultado = Potenciometria(CDbl(Dtg_Potenciometrico.Item(Fila_Lectura, 2)), CDbl(Txt_LectPotenciometrico.Text), Ultimo_Blanco)
                                If Unidad = "%" Then
                                    Resultado = Resultado / 10000
                                End If
                                If Unidad = "meq/l" Then
                                    Resultado = Resultado / Peso_Atomico
                                End If
                                If Unidad = "meq/100g" Then
                                    Resultado = Resultado / (Peso_Atomico * 10)
                                End If
                                If Unidad = "g/kg" Then
                                    Resultado = Resultado / 1000
                                End If
                                If Unidad = "mg/100g" Then
                                    Resultado = Resultado / 10
                                End If
                            End If

                            With sp
                                .Inicializar()
                                .AgregarParametro("@codana", CodAna, SqlDbType.Int)
                                .AgregarParametro("@elemento", Codigo, SqlDbType.NVarChar)
                                Mascara = .EjecutarEscalar("usp_RescataMascara")
                            End With

                            Dtg_Potenciometrico.Item(Fila_Lectura, 4) = Round(Resultado, Cantidad_Decimales(Mascara, Resultado))
                        End If
SaltoxPromedio:
                        Me.Txt_LectPotenciometrico.Focus()
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = Fila_Lectura + 1
                        Dtg_Potenciometrico.CurrentCell = mycell

                    End If
                End If

            End If

        Catch ex As Exception
            MsgBox("error en proc: Txt_LectPotenciometrico_KeyPress " & ex.Message.ToString, MsgBoxStyle.Exclamation)
        End Try

    End Sub




End Class
