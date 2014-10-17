Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class Frm_Emision_Resultados
    Inherits System.Windows.Forms.Form
    Private TIENE_RANGOS, NOMBRE_PROD, NLAD, NLAH, ES_NOTA As String
    Private frmEsp As New Frm_Espere
    Private R1, R2 As Boolean
    Private MATRIZ_AUX(6), NomTdato, NomTIden, GProductor, GEmpresa, GFechaIngreso, GRemite, GLocalidad, GProvincia, GComuna, sTab As String
    Private NOMTAB, Filas_Pagina, Maximo_columnas, notas As Integer
    Private sender As Object
    Private btGenera As Button = CType(sender, Button)
    Private txtLabDes As TextBox = CType(sender, TextBox)
    Private txtLabHas As TextBox = CType(sender, TextBox)
    Private txtOrdDes As TextBox = CType(sender, TextBox)
    Private txtOrdHas As TextBox = CType(sender, TextBox)
    Private txtNomArch As TextBox = CType(sender, TextBox)
    Private txtNomProd As TextBox = CType(sender, TextBox)
    Private FilaCua As Integer
    Private FilaVar As Integer
    Private FilaEdad As Integer
    Private Fila_Firma As Integer
    Private Fila_Merge As Integer
    Private Fila_Borde As Integer
    Private Fila_Pie As Integer
    Private Fila_Logo As Integer
    Private Fila_Nota As Integer
    Private IncFil As Integer
    Friend WithEvents lbl_estadoAguas As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoBacte As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoSF As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoSS As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoFQ As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoFO As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoFito As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoNem As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoFoliar As System.Windows.Forms.Label
    Friend WithEvents lbl_estadoTejidos As System.Windows.Forms.Label
    Private Notas_Si As String

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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents tabFoliar As System.Windows.Forms.TabPage
    Friend WithEvents lblTítuloFoliar As System.Windows.Forms.Label
    Friend WithEvents TxtOrdHasFoliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabDesFoliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesFoliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasFoliar As System.Windows.Forms.TextBox
    Friend WithEvents tabTejidos As System.Windows.Forms.TabPage
    Friend WithEvents tabAgua As System.Windows.Forms.TabPage
    Friend WithEvents tbcFicha As System.Windows.Forms.TabControl
    Friend WithEvents TxtOrdHasTejidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabDesTejidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesTejidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasTejidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdHasAgua As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabDesAgua As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesAgua As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasAgua As System.Windows.Forms.TextBox
    Friend WithEvents tabOtros As System.Windows.Forms.TabPage
    Friend WithEvents TxtOrdHasOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabDesOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasOtros As System.Windows.Forms.TextBox
    Friend WithEvents tttBuscarOrden As System.Windows.Forms.ToolTip
    Friend WithEvents GBEnvioArchivoFoliar As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNomArchFoliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoFoliar As System.Windows.Forms.TextBox
    Friend WithEvents GBEnvioArchivoTejidos As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNomArchTejidos As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoTejidos As System.Windows.Forms.TextBox
    Friend WithEvents GBEnvioArchivoAgua As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNomArchAgua As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoAgua As System.Windows.Forms.TextBox
    Friend WithEvents GBEnvioArchivoOtros As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNomArchOtros As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoOtros As System.Windows.Forms.TextBox
    Friend WithEvents ofdCorreos As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmdConfiguraFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdNotasFoliar As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabDesSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents GBEnvioArchivoSueloFer As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNomArchSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoSueloFer As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneraFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdSalirFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdNotasTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdGeneraTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdSalirTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaFoliar As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaTejidos As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaAgua As System.Windows.Forms.Button
    Friend WithEvents CmdNotasAgua As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraAgua As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoAgua As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoAgua As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenAgua As System.Windows.Forms.Button
    Friend WithEvents CmdGeneraAgua As System.Windows.Forms.Button
    Friend WithEvents CmdSalirAgua As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdGeneraSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdSalirSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdNotasSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenSueloSal As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneraSueloSal As System.Windows.Forms.Button
    Friend WithEvents CmdSalirSueloSal As System.Windows.Forms.Button
    Friend WithEvents TxtLabDesSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents TxtOrdDesSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents CmdNotasSueloSal As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraSueloSal As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoSueloSal As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoSueloSal As System.Windows.Forms.Button
    Friend WithEvents TxtNomArchSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoSueloSal As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneraOtros As System.Windows.Forms.Button
    Friend WithEvents CmdSalirOtros As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaSueloFer As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaSueloSal As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaOtros As System.Windows.Forms.Button
    Friend WithEvents CmdNotasOtros As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraOtros As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoOtros As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoOtros As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenOtros As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoFertQui1 As System.Windows.Forms.Button
    Friend WithEvents TxtOrdDesFertQui As System.Windows.Forms.TextBox
    Friend WithEvents CmdBuscarOrdenFertQui As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasFertQui As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneraFertQui As System.Windows.Forms.Button
    Friend WithEvents CmdSalirFertQui As System.Windows.Forms.Button
    Friend WithEvents TxtLabDesFertQui As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasFertQui As System.Windows.Forms.TextBox
    Friend WithEvents CmdNotasFertQui As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraFertQui As System.Windows.Forms.Button
    Friend WithEvents CmdEMailArchivoFertQui As System.Windows.Forms.Button
    Friend WithEvents TxtNomArchFertQui As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoFertQui As System.Windows.Forms.TextBox
    Friend WithEvents GBEnvioArchivoFertQui As System.Windows.Forms.GroupBox
    Friend WithEvents CmdConsultaFertQui As System.Windows.Forms.Button
    Friend WithEvents tabSueloFert As System.Windows.Forms.TabPage
    Friend WithEvents tabSuelo As System.Windows.Forms.TabPage
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdDesFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents CmdConsultaFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents CmdGeneraFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents CmdSalirFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents TxtLabDesFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents CmdConfiguraFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents GBEnvioArchivoFertOrgFis As System.Windows.Forms.GroupBox
    Friend WithEvents CmdEMailArchivoFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents CmdBuscaArchivoFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents TxtNomArchFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoFertOrgFis As System.Windows.Forms.TextBox
    Friend WithEvents CmdBuscarOrdenFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents CmdNotasFertOrgFis As System.Windows.Forms.Button
    Friend WithEvents tabFertQuimico As System.Windows.Forms.TabPage
    Friend WithEvents tabFertOrganico As System.Windows.Forms.TabPage
    Friend WithEvents tabNematodos As System.Windows.Forms.TabPage
    Friend WithEvents CmdNotasNema As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraNema As System.Windows.Forms.Button
    Friend WithEvents CmdConsultaNema As System.Windows.Forms.Button
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenNema As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasNema As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneraNema As System.Windows.Forms.Button
    Friend WithEvents CmdSalirNema As System.Windows.Forms.Button
    Friend WithEvents TxtLabDesNema As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdDesNema As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasNema As System.Windows.Forms.TextBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents CmdConsultaColi As System.Windows.Forms.Button
    Friend WithEvents CmdNotasColi As System.Windows.Forms.Button
    Friend WithEvents CmdConfiguraColi As System.Windows.Forms.Button
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents CmdBuscarOrdenColi As System.Windows.Forms.Button
    Friend WithEvents TxtOrdHasColi As System.Windows.Forms.TextBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents CmdGeneraColi As System.Windows.Forms.Button
    Friend WithEvents CmdSalirColi As System.Windows.Forms.Button
    Friend WithEvents TxtLabDesColi As System.Windows.Forms.TextBox
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents TxtOrdDesColi As System.Windows.Forms.TextBox
    Friend WithEvents TxtLabHasColi As System.Windows.Forms.TextBox
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents TxtNomArchColi As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoColi As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomArchNema As System.Windows.Forms.TextBox
    Friend WithEvents TxtNomProdArchivoNema As System.Windows.Forms.TextBox
    Friend WithEvents tabBactereologicos As System.Windows.Forms.TabPage
    Friend WithEvents ChkTransSecFre As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.tbcFicha = New System.Windows.Forms.TabControl
        Me.tabFoliar = New System.Windows.Forms.TabPage
        Me.lbl_estadoFoliar = New System.Windows.Forms.Label
        Me.CmdNotasFoliar = New System.Windows.Forms.Button
        Me.CmdConfiguraFoliar = New System.Windows.Forms.Button
        Me.CmdConsultaFoliar = New System.Windows.Forms.Button
        Me.lblTítuloFoliar = New System.Windows.Forms.Label
        Me.GBEnvioArchivoFoliar = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoFoliar = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoFoliar = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtNomArchFoliar = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoFoliar = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenFoliar = New System.Windows.Forms.Button
        Me.TxtOrdHasFoliar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdGeneraFoliar = New System.Windows.Forms.Button
        Me.CmdSalirFoliar = New System.Windows.Forms.Button
        Me.TxtLabDesFoliar = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtOrdDesFoliar = New System.Windows.Forms.TextBox
        Me.TxtLabHasFoliar = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tabTejidos = New System.Windows.Forms.TabPage
        Me.lbl_estadoTejidos = New System.Windows.Forms.Label
        Me.ChkTransSecFre = New System.Windows.Forms.CheckBox
        Me.CmdNotasTejidos = New System.Windows.Forms.Button
        Me.CmdConfiguraTejidos = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoTejidos = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoTejidos = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoTejidos = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtNomArchTejidos = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoTejidos = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TxtOrdHasTejidos = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdGeneraTejidos = New System.Windows.Forms.Button
        Me.CmdSalirTejidos = New System.Windows.Forms.Button
        Me.TxtLabDesTejidos = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtOrdDesTejidos = New System.Windows.Forms.TextBox
        Me.TxtLabHasTejidos = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.CmdConsultaTejidos = New System.Windows.Forms.Button
        Me.CmdBuscarOrdenTejidos = New System.Windows.Forms.Button
        Me.tabAgua = New System.Windows.Forms.TabPage
        Me.lbl_estadoAguas = New System.Windows.Forms.Label
        Me.CmdConsultaAgua = New System.Windows.Forms.Button
        Me.CmdNotasAgua = New System.Windows.Forms.Button
        Me.CmdConfiguraAgua = New System.Windows.Forms.Button
        Me.Label16 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoAgua = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoAgua = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoAgua = New System.Windows.Forms.Button
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.TxtNomArchAgua = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoAgua = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.TxtOrdHasAgua = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.CmdGeneraAgua = New System.Windows.Forms.Button
        Me.CmdSalirAgua = New System.Windows.Forms.Button
        Me.TxtLabDesAgua = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.TxtOrdDesAgua = New System.Windows.Forms.TextBox
        Me.TxtLabHasAgua = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenAgua = New System.Windows.Forms.Button
        Me.tabBactereologicos = New System.Windows.Forms.TabPage
        Me.lbl_estadoBacte = New System.Windows.Forms.Label
        Me.CmdConsultaColi = New System.Windows.Forms.Button
        Me.CmdNotasColi = New System.Windows.Forms.Button
        Me.CmdConfiguraColi = New System.Windows.Forms.Button
        Me.Label72 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.TxtNomArchColi = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoColi = New System.Windows.Forms.TextBox
        Me.Label75 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.TxtOrdHasColi = New System.Windows.Forms.TextBox
        Me.Label76 = New System.Windows.Forms.Label
        Me.CmdGeneraColi = New System.Windows.Forms.Button
        Me.CmdSalirColi = New System.Windows.Forms.Button
        Me.TxtLabDesColi = New System.Windows.Forms.TextBox
        Me.Label77 = New System.Windows.Forms.Label
        Me.TxtOrdDesColi = New System.Windows.Forms.TextBox
        Me.TxtLabHasColi = New System.Windows.Forms.TextBox
        Me.Label78 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenColi = New System.Windows.Forms.Button
        Me.tabSueloFert = New System.Windows.Forms.TabPage
        Me.lbl_estadoSF = New System.Windows.Forms.Label
        Me.CmdConsultaSueloFer = New System.Windows.Forms.Button
        Me.CmdNotasSueloFer = New System.Windows.Forms.Button
        Me.CmdConfiguraSueloFer = New System.Windows.Forms.Button
        Me.Label26 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoSueloFer = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoSueloFer = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoSueloFer = New System.Windows.Forms.Button
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.TxtNomArchSueloFer = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoSueloFer = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtOrdHasSueloFer = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.CmdGeneraSueloFer = New System.Windows.Forms.Button
        Me.CmdSalirSueloFer = New System.Windows.Forms.Button
        Me.TxtLabDesSueloFer = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.TxtOrdDesSueloFer = New System.Windows.Forms.TextBox
        Me.TxtLabHasSueloFer = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenSueloFer = New System.Windows.Forms.Button
        Me.tabSuelo = New System.Windows.Forms.TabPage
        Me.lbl_estadoSS = New System.Windows.Forms.Label
        Me.CmdConsultaSueloSal = New System.Windows.Forms.Button
        Me.CmdNotasSueloSal = New System.Windows.Forms.Button
        Me.CmdConfiguraSueloSal = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoSueloSal = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoSueloSal = New System.Windows.Forms.Button
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.TxtNomArchSueloSal = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoSueloSal = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.TxtOrdHasSueloSal = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.CmdGeneraSueloSal = New System.Windows.Forms.Button
        Me.CmdSalirSueloSal = New System.Windows.Forms.Button
        Me.TxtLabDesSueloSal = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.TxtOrdDesSueloSal = New System.Windows.Forms.TextBox
        Me.TxtLabHasSueloSal = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenSueloSal = New System.Windows.Forms.Button
        Me.tabFertQuimico = New System.Windows.Forms.TabPage
        Me.lbl_estadoFQ = New System.Windows.Forms.Label
        Me.CmdConsultaFertQui = New System.Windows.Forms.Button
        Me.CmdNotasFertQui = New System.Windows.Forms.Button
        Me.CmdConfiguraFertQui = New System.Windows.Forms.Button
        Me.Label43 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoFertQui = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoFertQui = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoFertQui1 = New System.Windows.Forms.Button
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label45 = New System.Windows.Forms.Label
        Me.TxtNomArchFertQui = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoFertQui = New System.Windows.Forms.TextBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.TxtOrdHasFertQui = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.CmdGeneraFertQui = New System.Windows.Forms.Button
        Me.CmdSalirFertQui = New System.Windows.Forms.Button
        Me.TxtLabDesFertQui = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.TxtOrdDesFertQui = New System.Windows.Forms.TextBox
        Me.TxtLabHasFertQui = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenFertQui = New System.Windows.Forms.Button
        Me.tabFertOrganico = New System.Windows.Forms.TabPage
        Me.lbl_estadoFO = New System.Windows.Forms.Label
        Me.CmdConsultaFertOrgFis = New System.Windows.Forms.Button
        Me.CmdNotasFertOrgFis = New System.Windows.Forms.Button
        Me.CmdConfiguraFertOrgFis = New System.Windows.Forms.Button
        Me.Label40 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoFertOrgFis = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoFertOrgFis = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoFertOrgFis = New System.Windows.Forms.Button
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.TxtNomArchFertOrgFis = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoFertOrgFis = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.TxtOrdHasFertOrgFis = New System.Windows.Forms.TextBox
        Me.Label68 = New System.Windows.Forms.Label
        Me.CmdGeneraFertOrgFis = New System.Windows.Forms.Button
        Me.CmdSalirFertOrgFis = New System.Windows.Forms.Button
        Me.TxtLabDesFertOrgFis = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.TxtOrdDesFertOrgFis = New System.Windows.Forms.TextBox
        Me.TxtLabHasFertOrgFis = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label71 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenFertOrgFis = New System.Windows.Forms.Button
        Me.tabOtros = New System.Windows.Forms.TabPage
        Me.lbl_estadoFito = New System.Windows.Forms.Label
        Me.CmdConsultaOtros = New System.Windows.Forms.Button
        Me.CmdNotasOtros = New System.Windows.Forms.Button
        Me.CmdConfiguraOtros = New System.Windows.Forms.Button
        Me.Label59 = New System.Windows.Forms.Label
        Me.GBEnvioArchivoOtros = New System.Windows.Forms.GroupBox
        Me.CmdEMailArchivoOtros = New System.Windows.Forms.Button
        Me.CmdBuscaArchivoOtros = New System.Windows.Forms.Button
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.TxtNomArchOtros = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoOtros = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.TxtOrdHasOtros = New System.Windows.Forms.TextBox
        Me.Label63 = New System.Windows.Forms.Label
        Me.CmdGeneraOtros = New System.Windows.Forms.Button
        Me.CmdSalirOtros = New System.Windows.Forms.Button
        Me.TxtLabDesOtros = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.TxtOrdDesOtros = New System.Windows.Forms.TextBox
        Me.TxtLabHasOtros = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.CmdBuscarOrdenOtros = New System.Windows.Forms.Button
        Me.tabNematodos = New System.Windows.Forms.TabPage
        Me.lbl_estadoNem = New System.Windows.Forms.Label
        Me.CmdNotasNema = New System.Windows.Forms.Button
        Me.CmdConfiguraNema = New System.Windows.Forms.Button
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.Label52 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.TxtNomArchNema = New System.Windows.Forms.TextBox
        Me.TxtNomProdArchivoNema = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.TxtOrdHasNema = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.CmdGeneraNema = New System.Windows.Forms.Button
        Me.CmdSalirNema = New System.Windows.Forms.Button
        Me.TxtLabDesNema = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.TxtOrdDesNema = New System.Windows.Forms.TextBox
        Me.TxtLabHasNema = New System.Windows.Forms.TextBox
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.CmdConsultaNema = New System.Windows.Forms.Button
        Me.CmdBuscarOrdenNema = New System.Windows.Forms.Button
        Me.tttBuscarOrden = New System.Windows.Forms.ToolTip(Me.components)
        Me.ofdCorreos = New System.Windows.Forms.OpenFileDialog
        Me.tbcFicha.SuspendLayout()
        Me.tabFoliar.SuspendLayout()
        Me.GBEnvioArchivoFoliar.SuspendLayout()
        Me.tabTejidos.SuspendLayout()
        Me.GBEnvioArchivoTejidos.SuspendLayout()
        Me.tabAgua.SuspendLayout()
        Me.GBEnvioArchivoAgua.SuspendLayout()
        Me.tabBactereologicos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.tabSueloFert.SuspendLayout()
        Me.GBEnvioArchivoSueloFer.SuspendLayout()
        Me.tabSuelo.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tabFertQuimico.SuspendLayout()
        Me.GBEnvioArchivoFertQui.SuspendLayout()
        Me.tabFertOrganico.SuspendLayout()
        Me.GBEnvioArchivoFertOrgFis.SuspendLayout()
        Me.tabOtros.SuspendLayout()
        Me.GBEnvioArchivoOtros.SuspendLayout()
        Me.tabNematodos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbcFicha
        '
        Me.tbcFicha.Controls.Add(Me.tabFoliar)
        Me.tbcFicha.Controls.Add(Me.tabTejidos)
        Me.tbcFicha.Controls.Add(Me.tabAgua)
        Me.tbcFicha.Controls.Add(Me.tabBactereologicos)
        Me.tbcFicha.Controls.Add(Me.tabSueloFert)
        Me.tbcFicha.Controls.Add(Me.tabSuelo)
        Me.tbcFicha.Controls.Add(Me.tabFertQuimico)
        Me.tbcFicha.Controls.Add(Me.tabFertOrganico)
        Me.tbcFicha.Controls.Add(Me.tabOtros)
        Me.tbcFicha.Controls.Add(Me.tabNematodos)
        Me.tbcFicha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbcFicha.Location = New System.Drawing.Point(77, 40)
        Me.tbcFicha.Name = "tbcFicha"
        Me.tbcFicha.SelectedIndex = 0
        Me.tbcFicha.Size = New System.Drawing.Size(1123, 800)
        Me.tbcFicha.TabIndex = 0
        '
        'tabFoliar
        '
        Me.tabFoliar.BackColor = System.Drawing.SystemColors.Control
        Me.tabFoliar.Controls.Add(Me.lbl_estadoFoliar)
        Me.tabFoliar.Controls.Add(Me.CmdNotasFoliar)
        Me.tabFoliar.Controls.Add(Me.CmdConfiguraFoliar)
        Me.tabFoliar.Controls.Add(Me.CmdConsultaFoliar)
        Me.tabFoliar.Controls.Add(Me.lblTítuloFoliar)
        Me.tabFoliar.Controls.Add(Me.GBEnvioArchivoFoliar)
        Me.tabFoliar.Controls.Add(Me.CmdBuscarOrdenFoliar)
        Me.tabFoliar.Controls.Add(Me.TxtOrdHasFoliar)
        Me.tabFoliar.Controls.Add(Me.Label3)
        Me.tabFoliar.Controls.Add(Me.CmdGeneraFoliar)
        Me.tabFoliar.Controls.Add(Me.CmdSalirFoliar)
        Me.tabFoliar.Controls.Add(Me.TxtLabDesFoliar)
        Me.tabFoliar.Controls.Add(Me.Label2)
        Me.tabFoliar.Controls.Add(Me.TxtOrdDesFoliar)
        Me.tabFoliar.Controls.Add(Me.TxtLabHasFoliar)
        Me.tabFoliar.Controls.Add(Me.Label13)
        Me.tabFoliar.Controls.Add(Me.Label9)
        Me.tabFoliar.Font = New System.Drawing.Font("Bar Code", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabFoliar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabFoliar.Location = New System.Drawing.Point(4, 26)
        Me.tabFoliar.Name = "tabFoliar"
        Me.tabFoliar.Size = New System.Drawing.Size(1115, 770)
        Me.tabFoliar.TabIndex = 0
        Me.tabFoliar.Text = "1. Foliar"
        '
        'lbl_estadoFoliar
        '
        Me.lbl_estadoFoliar.AutoSize = True
        Me.lbl_estadoFoliar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estadoFoliar.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoFoliar.Location = New System.Drawing.Point(248, 305)
        Me.lbl_estadoFoliar.Name = "lbl_estadoFoliar"
        Me.lbl_estadoFoliar.Size = New System.Drawing.Size(50, 16)
        Me.lbl_estadoFoliar.TabIndex = 70
        Me.lbl_estadoFoliar.Text = "estado"
        Me.lbl_estadoFoliar.Visible = False
        '
        'CmdNotasFoliar
        '
        Me.CmdNotasFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasFoliar.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasFoliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasFoliar.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasFoliar.Name = "CmdNotasFoliar"
        Me.CmdNotasFoliar.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasFoliar.TabIndex = 51
        Me.CmdNotasFoliar.Text = "Notas"
        Me.CmdNotasFoliar.UseVisualStyleBackColor = False
        '
        'CmdConfiguraFoliar
        '
        Me.CmdConfiguraFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraFoliar.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraFoliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraFoliar.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraFoliar.Name = "CmdConfiguraFoliar"
        Me.CmdConfiguraFoliar.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraFoliar.TabIndex = 50
        Me.CmdConfiguraFoliar.Text = "Configuración"
        Me.CmdConfiguraFoliar.UseVisualStyleBackColor = False
        '
        'CmdConsultaFoliar
        '
        Me.CmdConsultaFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaFoliar.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaFoliar.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaFoliar.Name = "CmdConsultaFoliar"
        Me.CmdConsultaFoliar.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaFoliar.TabIndex = 49
        Me.CmdConsultaFoliar.UseVisualStyleBackColor = False
        '
        'lblTítuloFoliar
        '
        Me.lblTítuloFoliar.Font = New System.Drawing.Font("Bar Code", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTítuloFoliar.Location = New System.Drawing.Point(460, 72)
        Me.lblTítuloFoliar.Name = "lblTítuloFoliar"
        Me.lblTítuloFoliar.Size = New System.Drawing.Size(96, 32)
        Me.lblTítuloFoliar.TabIndex = 48
        Me.lblTítuloFoliar.Text = "FOLIAR"
        '
        'GBEnvioArchivoFoliar
        '
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.CmdEMailArchivoFoliar)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.CmdBuscaArchivoFoliar)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.Label10)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.Label11)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.TxtNomArchFoliar)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.TxtNomProdArchivoFoliar)
        Me.GBEnvioArchivoFoliar.Controls.Add(Me.Label12)
        Me.GBEnvioArchivoFoliar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoFoliar.Location = New System.Drawing.Point(244, 424)
        Me.GBEnvioArchivoFoliar.Name = "GBEnvioArchivoFoliar"
        Me.GBEnvioArchivoFoliar.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoFoliar.TabIndex = 47
        Me.GBEnvioArchivoFoliar.TabStop = False
        Me.GBEnvioArchivoFoliar.Visible = False
        '
        'CmdEMailArchivoFoliar
        '
        Me.CmdEMailArchivoFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoFoliar.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoFoliar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoFoliar.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoFoliar.Name = "CmdEMailArchivoFoliar"
        Me.CmdEMailArchivoFoliar.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoFoliar.TabIndex = 35
        Me.CmdEMailArchivoFoliar.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoFoliar.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoFoliar
        '
        Me.CmdBuscaArchivoFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoFoliar.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoFoliar.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoFoliar.Name = "CmdBuscaArchivoFoliar"
        Me.CmdBuscaArchivoFoliar.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoFoliar.TabIndex = 34
        Me.CmdBuscaArchivoFoliar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(72, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Productor"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(72, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 23)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "Archivo"
        '
        'TxtNomArchFoliar
        '
        Me.TxtNomArchFoliar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchFoliar.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchFoliar.Name = "TxtNomArchFoliar"
        Me.TxtNomArchFoliar.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchFoliar.TabIndex = 29
        '
        'TxtNomProdArchivoFoliar
        '
        Me.TxtNomProdArchivoFoliar.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoFoliar.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoFoliar.Name = "TxtNomProdArchivoFoliar"
        Me.TxtNomProdArchivoFoliar.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoFoliar.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(184, 80)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 16)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Para enviar un archivo creado"
        '
        'CmdBuscarOrdenFoliar
        '
        Me.CmdBuscarOrdenFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenFoliar.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenFoliar.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenFoliar.Name = "CmdBuscarOrdenFoliar"
        Me.CmdBuscarOrdenFoliar.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenFoliar.TabIndex = 45
        Me.CmdBuscarOrdenFoliar.UseVisualStyleBackColor = False
        '
        'TxtOrdHasFoliar
        '
        Me.TxtOrdHasFoliar.Enabled = False
        Me.TxtOrdHasFoliar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasFoliar.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasFoliar.Name = "TxtOrdHasFoliar"
        Me.TxtOrdHasFoliar.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasFoliar.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(516, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "N° Orden Hasta"
        '
        'CmdGeneraFoliar
        '
        Me.CmdGeneraFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraFoliar.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraFoliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraFoliar.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraFoliar.Name = "CmdGeneraFoliar"
        Me.CmdGeneraFoliar.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraFoliar.TabIndex = 42
        Me.CmdGeneraFoliar.Text = "Generar"
        Me.CmdGeneraFoliar.UseVisualStyleBackColor = False
        '
        'CmdSalirFoliar
        '
        Me.CmdSalirFoliar.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirFoliar.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirFoliar.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirFoliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirFoliar.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirFoliar.Name = "CmdSalirFoliar"
        Me.CmdSalirFoliar.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirFoliar.TabIndex = 40
        Me.CmdSalirFoliar.Text = "Salir"
        Me.CmdSalirFoliar.UseVisualStyleBackColor = False
        '
        'TxtLabDesFoliar
        '
        Me.TxtLabDesFoliar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesFoliar.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesFoliar.Name = "TxtLabDesFoliar"
        Me.TxtLabDesFoliar.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesFoliar.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(284, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "N° Lab. Desde"
        '
        'TxtOrdDesFoliar
        '
        Me.TxtOrdDesFoliar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesFoliar.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesFoliar.Name = "TxtOrdDesFoliar"
        Me.TxtOrdDesFoliar.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesFoliar.TabIndex = 37
        '
        'TxtLabHasFoliar
        '
        Me.TxtLabHasFoliar.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasFoliar.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasFoliar.Name = "TxtLabHasFoliar"
        Me.TxtLabHasFoliar.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasFoliar.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(284, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "N° Orden Desde"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(516, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "N° Lab Hasta"
        '
        'tabTejidos
        '
        Me.tabTejidos.BackColor = System.Drawing.SystemColors.Control
        Me.tabTejidos.Controls.Add(Me.lbl_estadoTejidos)
        Me.tabTejidos.Controls.Add(Me.ChkTransSecFre)
        Me.tabTejidos.Controls.Add(Me.CmdNotasTejidos)
        Me.tabTejidos.Controls.Add(Me.CmdConfiguraTejidos)
        Me.tabTejidos.Controls.Add(Me.Label1)
        Me.tabTejidos.Controls.Add(Me.GBEnvioArchivoTejidos)
        Me.tabTejidos.Controls.Add(Me.TxtOrdHasTejidos)
        Me.tabTejidos.Controls.Add(Me.Label7)
        Me.tabTejidos.Controls.Add(Me.CmdGeneraTejidos)
        Me.tabTejidos.Controls.Add(Me.CmdSalirTejidos)
        Me.tabTejidos.Controls.Add(Me.TxtLabDesTejidos)
        Me.tabTejidos.Controls.Add(Me.Label8)
        Me.tabTejidos.Controls.Add(Me.TxtOrdDesTejidos)
        Me.tabTejidos.Controls.Add(Me.TxtLabHasTejidos)
        Me.tabTejidos.Controls.Add(Me.Label14)
        Me.tabTejidos.Controls.Add(Me.Label15)
        Me.tabTejidos.Controls.Add(Me.CmdConsultaTejidos)
        Me.tabTejidos.Controls.Add(Me.CmdBuscarOrdenTejidos)
        Me.tabTejidos.Location = New System.Drawing.Point(4, 26)
        Me.tabTejidos.Name = "tabTejidos"
        Me.tabTejidos.Size = New System.Drawing.Size(1115, 770)
        Me.tabTejidos.TabIndex = 2
        Me.tabTejidos.Text = "2. Tejidos"
        '
        'lbl_estadoTejidos
        '
        Me.lbl_estadoTejidos.AutoSize = True
        Me.lbl_estadoTejidos.Font = New System.Drawing.Font("Bar Code", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estadoTejidos.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoTejidos.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoTejidos.Name = "lbl_estadoTejidos"
        Me.lbl_estadoTejidos.Size = New System.Drawing.Size(59, 18)
        Me.lbl_estadoTejidos.TabIndex = 70
        Me.lbl_estadoTejidos.Text = "estado"
        Me.lbl_estadoTejidos.Visible = False
        '
        'ChkTransSecFre
        '
        Me.ChkTransSecFre.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTransSecFre.Location = New System.Drawing.Point(424, 512)
        Me.ChkTransSecFre.Name = "ChkTransSecFre"
        Me.ChkTransSecFre.Size = New System.Drawing.Size(160, 16)
        Me.ChkTransSecFre.TabIndex = 67
        Me.ChkTransSecFre.Text = "Transforma Fresco a Seco"
        '
        'CmdNotasTejidos
        '
        Me.CmdNotasTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasTejidos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasTejidos.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasTejidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasTejidos.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasTejidos.Name = "CmdNotasTejidos"
        Me.CmdNotasTejidos.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasTejidos.TabIndex = 65
        Me.CmdNotasTejidos.Text = "Notas"
        Me.CmdNotasTejidos.UseVisualStyleBackColor = False
        '
        'CmdConfiguraTejidos
        '
        Me.CmdConfiguraTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraTejidos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraTejidos.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraTejidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraTejidos.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraTejidos.Name = "CmdConfiguraTejidos"
        Me.CmdConfiguraTejidos.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraTejidos.TabIndex = 64
        Me.CmdConfiguraTejidos.Text = "Configuración"
        Me.CmdConfiguraTejidos.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bar Code", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(460, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "TEJIDOS"
        '
        'GBEnvioArchivoTejidos
        '
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.CmdEMailArchivoTejidos)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.CmdBuscaArchivoTejidos)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.Label4)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.Label5)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.TxtNomArchTejidos)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.TxtNomProdArchivoTejidos)
        Me.GBEnvioArchivoTejidos.Controls.Add(Me.Label6)
        Me.GBEnvioArchivoTejidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoTejidos.Location = New System.Drawing.Point(244, 384)
        Me.GBEnvioArchivoTejidos.Name = "GBEnvioArchivoTejidos"
        Me.GBEnvioArchivoTejidos.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoTejidos.TabIndex = 62
        Me.GBEnvioArchivoTejidos.TabStop = False
        Me.GBEnvioArchivoTejidos.Visible = False
        '
        'CmdEMailArchivoTejidos
        '
        Me.CmdEMailArchivoTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoTejidos.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoTejidos.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoTejidos.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoTejidos.Name = "CmdEMailArchivoTejidos"
        Me.CmdEMailArchivoTejidos.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoTejidos.TabIndex = 35
        Me.CmdEMailArchivoTejidos.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoTejidos.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoTejidos
        '
        Me.CmdBuscaArchivoTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoTejidos.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoTejidos.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoTejidos.Name = "CmdBuscaArchivoTejidos"
        Me.CmdBuscaArchivoTejidos.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoTejidos.TabIndex = 34
        Me.CmdBuscaArchivoTejidos.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoTejidos.Visible = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Productor"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(72, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Archivo"
        '
        'TxtNomArchTejidos
        '
        Me.TxtNomArchTejidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchTejidos.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchTejidos.Name = "TxtNomArchTejidos"
        Me.TxtNomArchTejidos.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchTejidos.TabIndex = 29
        '
        'TxtNomProdArchivoTejidos
        '
        Me.TxtNomProdArchivoTejidos.Enabled = False
        Me.TxtNomProdArchivoTejidos.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoTejidos.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoTejidos.Name = "TxtNomProdArchivoTejidos"
        Me.TxtNomProdArchivoTejidos.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoTejidos.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 80)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(168, 16)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasTejidos
        '
        Me.TxtOrdHasTejidos.Enabled = False
        Me.TxtOrdHasTejidos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasTejidos.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasTejidos.Name = "TxtOrdHasTejidos"
        Me.TxtOrdHasTejidos.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasTejidos.TabIndex = 53
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(516, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 16)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "N° Orden Hasta"
        '
        'CmdGeneraTejidos
        '
        Me.CmdGeneraTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraTejidos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraTejidos.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraTejidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraTejidos.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraTejidos.Name = "CmdGeneraTejidos"
        Me.CmdGeneraTejidos.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraTejidos.TabIndex = 57
        Me.CmdGeneraTejidos.Text = "Generar"
        Me.CmdGeneraTejidos.UseVisualStyleBackColor = False
        '
        'CmdSalirTejidos
        '
        Me.CmdSalirTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirTejidos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirTejidos.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirTejidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirTejidos.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirTejidos.Name = "CmdSalirTejidos"
        Me.CmdSalirTejidos.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirTejidos.TabIndex = 55
        Me.CmdSalirTejidos.Text = "Salir"
        Me.CmdSalirTejidos.UseVisualStyleBackColor = False
        '
        'TxtLabDesTejidos
        '
        Me.TxtLabDesTejidos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesTejidos.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesTejidos.Name = "TxtLabDesTejidos"
        Me.TxtLabDesTejidos.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesTejidos.TabIndex = 56
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(284, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "N° Lab. Desde"
        '
        'TxtOrdDesTejidos
        '
        Me.TxtOrdDesTejidos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesTejidos.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesTejidos.Name = "TxtOrdDesTejidos"
        Me.TxtOrdDesTejidos.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesTejidos.TabIndex = 52
        '
        'TxtLabHasTejidos
        '
        Me.TxtLabHasTejidos.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasTejidos.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasTejidos.Name = "TxtLabHasTejidos"
        Me.TxtLabHasTejidos.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasTejidos.TabIndex = 58
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(284, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(96, 16)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "N° Orden Desde"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(516, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "N° Lab Hasta"
        '
        'CmdConsultaTejidos
        '
        Me.CmdConsultaTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaTejidos.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaTejidos.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaTejidos.Name = "CmdConsultaTejidos"
        Me.CmdConsultaTejidos.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaTejidos.TabIndex = 66
        Me.CmdConsultaTejidos.UseVisualStyleBackColor = False
        '
        'CmdBuscarOrdenTejidos
        '
        Me.CmdBuscarOrdenTejidos.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenTejidos.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenTejidos.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenTejidos.Name = "CmdBuscarOrdenTejidos"
        Me.CmdBuscarOrdenTejidos.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenTejidos.TabIndex = 60
        Me.CmdBuscarOrdenTejidos.UseVisualStyleBackColor = False
        '
        'tabAgua
        '
        Me.tabAgua.BackColor = System.Drawing.SystemColors.Control
        Me.tabAgua.Controls.Add(Me.lbl_estadoAguas)
        Me.tabAgua.Controls.Add(Me.CmdConsultaAgua)
        Me.tabAgua.Controls.Add(Me.CmdNotasAgua)
        Me.tabAgua.Controls.Add(Me.CmdConfiguraAgua)
        Me.tabAgua.Controls.Add(Me.Label16)
        Me.tabAgua.Controls.Add(Me.GBEnvioArchivoAgua)
        Me.tabAgua.Controls.Add(Me.TxtOrdHasAgua)
        Me.tabAgua.Controls.Add(Me.Label20)
        Me.tabAgua.Controls.Add(Me.CmdGeneraAgua)
        Me.tabAgua.Controls.Add(Me.CmdSalirAgua)
        Me.tabAgua.Controls.Add(Me.TxtLabDesAgua)
        Me.tabAgua.Controls.Add(Me.Label21)
        Me.tabAgua.Controls.Add(Me.TxtOrdDesAgua)
        Me.tabAgua.Controls.Add(Me.TxtLabHasAgua)
        Me.tabAgua.Controls.Add(Me.Label22)
        Me.tabAgua.Controls.Add(Me.Label24)
        Me.tabAgua.Controls.Add(Me.CmdBuscarOrdenAgua)
        Me.tabAgua.Location = New System.Drawing.Point(4, 26)
        Me.tabAgua.Name = "tabAgua"
        Me.tabAgua.Size = New System.Drawing.Size(1115, 770)
        Me.tabAgua.TabIndex = 3
        Me.tabAgua.Text = "3. Agua"
        '
        'lbl_estadoAguas
        '
        Me.lbl_estadoAguas.AutoSize = True
        Me.lbl_estadoAguas.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoAguas.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoAguas.Name = "lbl_estadoAguas"
        Me.lbl_estadoAguas.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoAguas.TabIndex = 69
        Me.lbl_estadoAguas.Text = "estado"
        Me.lbl_estadoAguas.Visible = False
        '
        'CmdConsultaAgua
        '
        Me.CmdConsultaAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaAgua.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaAgua.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaAgua.Name = "CmdConsultaAgua"
        Me.CmdConsultaAgua.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaAgua.TabIndex = 68
        Me.CmdConsultaAgua.UseVisualStyleBackColor = False
        '
        'CmdNotasAgua
        '
        Me.CmdNotasAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasAgua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasAgua.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasAgua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasAgua.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasAgua.Name = "CmdNotasAgua"
        Me.CmdNotasAgua.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasAgua.TabIndex = 67
        Me.CmdNotasAgua.Text = "Notas"
        Me.CmdNotasAgua.UseVisualStyleBackColor = False
        '
        'CmdConfiguraAgua
        '
        Me.CmdConfiguraAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraAgua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraAgua.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraAgua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraAgua.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraAgua.Name = "CmdConfiguraAgua"
        Me.CmdConfiguraAgua.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraAgua.TabIndex = 66
        Me.CmdConfiguraAgua.Text = "Configuración"
        Me.CmdConfiguraAgua.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(460, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 32)
        Me.Label16.TabIndex = 63
        Me.Label16.Text = "AGUA"
        '
        'GBEnvioArchivoAgua
        '
        Me.GBEnvioArchivoAgua.Controls.Add(Me.CmdEMailArchivoAgua)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.CmdBuscaArchivoAgua)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.Label17)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.Label18)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.TxtNomArchAgua)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.TxtNomProdArchivoAgua)
        Me.GBEnvioArchivoAgua.Controls.Add(Me.Label19)
        Me.GBEnvioArchivoAgua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoAgua.Location = New System.Drawing.Point(244, 400)
        Me.GBEnvioArchivoAgua.Name = "GBEnvioArchivoAgua"
        Me.GBEnvioArchivoAgua.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoAgua.TabIndex = 62
        Me.GBEnvioArchivoAgua.TabStop = False
        Me.GBEnvioArchivoAgua.Visible = False
        '
        'CmdEMailArchivoAgua
        '
        Me.CmdEMailArchivoAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoAgua.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoAgua.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoAgua.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoAgua.Name = "CmdEMailArchivoAgua"
        Me.CmdEMailArchivoAgua.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoAgua.TabIndex = 35
        Me.CmdEMailArchivoAgua.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoAgua.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoAgua
        '
        Me.CmdBuscaArchivoAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoAgua.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoAgua.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoAgua.Name = "CmdBuscaArchivoAgua"
        Me.CmdBuscaArchivoAgua.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoAgua.TabIndex = 34
        Me.CmdBuscaArchivoAgua.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoAgua.Visible = False
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(72, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 23)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "Productor"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(72, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 23)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "Archivo"
        '
        'TxtNomArchAgua
        '
        Me.TxtNomArchAgua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchAgua.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchAgua.Name = "TxtNomArchAgua"
        Me.TxtNomArchAgua.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchAgua.TabIndex = 29
        '
        'TxtNomProdArchivoAgua
        '
        Me.TxtNomProdArchivoAgua.Enabled = False
        Me.TxtNomProdArchivoAgua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoAgua.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoAgua.Name = "TxtNomProdArchivoAgua"
        Me.TxtNomProdArchivoAgua.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoAgua.TabIndex = 28
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(184, 80)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 16)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasAgua
        '
        Me.TxtOrdHasAgua.Enabled = False
        Me.TxtOrdHasAgua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasAgua.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasAgua.Name = "TxtOrdHasAgua"
        Me.TxtOrdHasAgua.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasAgua.TabIndex = 53
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(516, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 16)
        Me.Label20.TabIndex = 59
        Me.Label20.Text = "N° Orden Hasta"
        '
        'CmdGeneraAgua
        '
        Me.CmdGeneraAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraAgua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraAgua.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraAgua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraAgua.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraAgua.Name = "CmdGeneraAgua"
        Me.CmdGeneraAgua.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraAgua.TabIndex = 57
        Me.CmdGeneraAgua.Text = "Generar"
        Me.CmdGeneraAgua.UseVisualStyleBackColor = False
        '
        'CmdSalirAgua
        '
        Me.CmdSalirAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirAgua.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirAgua.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirAgua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirAgua.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirAgua.Name = "CmdSalirAgua"
        Me.CmdSalirAgua.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirAgua.TabIndex = 55
        Me.CmdSalirAgua.Text = "Salir"
        Me.CmdSalirAgua.UseVisualStyleBackColor = False
        '
        'TxtLabDesAgua
        '
        Me.TxtLabDesAgua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesAgua.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesAgua.Name = "TxtLabDesAgua"
        Me.TxtLabDesAgua.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesAgua.TabIndex = 56
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(284, 176)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(88, 16)
        Me.Label21.TabIndex = 50
        Me.Label21.Text = "N° Lab. Desde"
        '
        'TxtOrdDesAgua
        '
        Me.TxtOrdDesAgua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesAgua.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesAgua.Name = "TxtOrdDesAgua"
        Me.TxtOrdDesAgua.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesAgua.TabIndex = 52
        '
        'TxtLabHasAgua
        '
        Me.TxtLabHasAgua.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasAgua.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasAgua.Name = "TxtLabHasAgua"
        Me.TxtLabHasAgua.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasAgua.TabIndex = 58
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(284, 136)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(96, 16)
        Me.Label22.TabIndex = 49
        Me.Label22.Text = "N° Orden Desde"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(516, 176)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 16)
        Me.Label24.TabIndex = 51
        Me.Label24.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenAgua
        '
        Me.CmdBuscarOrdenAgua.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenAgua.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenAgua.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenAgua.Name = "CmdBuscarOrdenAgua"
        Me.CmdBuscarOrdenAgua.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenAgua.TabIndex = 60
        Me.CmdBuscarOrdenAgua.UseVisualStyleBackColor = False
        '
        'tabBactereologicos
        '
        Me.tabBactereologicos.BackColor = System.Drawing.SystemColors.Control
        Me.tabBactereologicos.Controls.Add(Me.lbl_estadoBacte)
        Me.tabBactereologicos.Controls.Add(Me.CmdConsultaColi)
        Me.tabBactereologicos.Controls.Add(Me.CmdNotasColi)
        Me.tabBactereologicos.Controls.Add(Me.CmdConfiguraColi)
        Me.tabBactereologicos.Controls.Add(Me.Label72)
        Me.tabBactereologicos.Controls.Add(Me.GroupBox3)
        Me.tabBactereologicos.Controls.Add(Me.TxtOrdHasColi)
        Me.tabBactereologicos.Controls.Add(Me.Label76)
        Me.tabBactereologicos.Controls.Add(Me.CmdGeneraColi)
        Me.tabBactereologicos.Controls.Add(Me.CmdSalirColi)
        Me.tabBactereologicos.Controls.Add(Me.TxtLabDesColi)
        Me.tabBactereologicos.Controls.Add(Me.Label77)
        Me.tabBactereologicos.Controls.Add(Me.TxtOrdDesColi)
        Me.tabBactereologicos.Controls.Add(Me.TxtLabHasColi)
        Me.tabBactereologicos.Controls.Add(Me.Label78)
        Me.tabBactereologicos.Controls.Add(Me.Label79)
        Me.tabBactereologicos.Controls.Add(Me.CmdBuscarOrdenColi)
        Me.tabBactereologicos.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabBactereologicos.Location = New System.Drawing.Point(4, 26)
        Me.tabBactereologicos.Name = "tabBactereologicos"
        Me.tabBactereologicos.Size = New System.Drawing.Size(1115, 770)
        Me.tabBactereologicos.TabIndex = 12
        Me.tabBactereologicos.Text = "3.Bacteriologicos"
        '
        'lbl_estadoBacte
        '
        Me.lbl_estadoBacte.AutoSize = True
        Me.lbl_estadoBacte.Font = New System.Drawing.Font("Bar Code", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_estadoBacte.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoBacte.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoBacte.Name = "lbl_estadoBacte"
        Me.lbl_estadoBacte.Size = New System.Drawing.Size(59, 18)
        Me.lbl_estadoBacte.TabIndex = 85
        Me.lbl_estadoBacte.Text = "estado"
        Me.lbl_estadoBacte.Visible = False
        '
        'CmdConsultaColi
        '
        Me.CmdConsultaColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaColi.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaColi.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaColi.Name = "CmdConsultaColi"
        Me.CmdConsultaColi.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaColi.TabIndex = 84
        Me.CmdConsultaColi.UseVisualStyleBackColor = False
        '
        'CmdNotasColi
        '
        Me.CmdNotasColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasColi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasColi.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasColi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasColi.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasColi.Name = "CmdNotasColi"
        Me.CmdNotasColi.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasColi.TabIndex = 83
        Me.CmdNotasColi.Text = "Notas"
        Me.CmdNotasColi.UseVisualStyleBackColor = False
        '
        'CmdConfiguraColi
        '
        Me.CmdConfiguraColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraColi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraColi.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraColi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraColi.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraColi.Name = "CmdConfiguraColi"
        Me.CmdConfiguraColi.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraColi.TabIndex = 82
        Me.CmdConfiguraColi.Text = "Configuración"
        Me.CmdConfiguraColi.UseVisualStyleBackColor = False
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.Location = New System.Drawing.Point(432, 72)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(198, 32)
        Me.Label72.TabIndex = 81
        Me.Label72.Text = "BACTERIOLÓGICOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Label73)
        Me.GroupBox3.Controls.Add(Me.Label74)
        Me.GroupBox3.Controls.Add(Me.TxtNomArchColi)
        Me.GroupBox3.Controls.Add(Me.TxtNomProdArchivoColi)
        Me.GroupBox3.Controls.Add(Me.Label75)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(244, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(504, 104)
        Me.GroupBox3.TabIndex = 80
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Image = Global.LabSys.My.Resources.Resources.email
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.Location = New System.Drawing.Point(424, 32)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(32, 24)
        Me.Button6.TabIndex = 35
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(72, 48)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(64, 23)
        Me.Label73.TabIndex = 30
        Me.Label73.Text = "Productor"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label74.Location = New System.Drawing.Point(72, 16)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(64, 23)
        Me.Label74.TabIndex = 31
        Me.Label74.Text = "Archivo"
        '
        'TxtNomArchColi
        '
        Me.TxtNomArchColi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchColi.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchColi.Name = "TxtNomArchColi"
        Me.TxtNomArchColi.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchColi.TabIndex = 29
        '
        'TxtNomProdArchivoColi
        '
        Me.TxtNomProdArchivoColi.Enabled = False
        Me.TxtNomProdArchivoColi.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoColi.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoColi.Name = "TxtNomProdArchivoColi"
        Me.TxtNomProdArchivoColi.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoColi.TabIndex = 28
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(184, 80)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(168, 16)
        Me.Label75.TabIndex = 33
        Me.Label75.Text = "Para enviar un archivo creado"
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.Button7.Location = New System.Drawing.Point(16, 32)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(32, 24)
        Me.Button7.TabIndex = 34
        Me.Button7.UseVisualStyleBackColor = False
        Me.Button7.Visible = False
        '
        'TxtOrdHasColi
        '
        Me.TxtOrdHasColi.Enabled = False
        Me.TxtOrdHasColi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasColi.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasColi.Name = "TxtOrdHasColi"
        Me.TxtOrdHasColi.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasColi.TabIndex = 73
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label76.Location = New System.Drawing.Point(516, 136)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(96, 16)
        Me.Label76.TabIndex = 78
        Me.Label76.Text = "N° Orden Hasta"
        '
        'CmdGeneraColi
        '
        Me.CmdGeneraColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraColi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraColi.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraColi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraColi.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraColi.Name = "CmdGeneraColi"
        Me.CmdGeneraColi.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraColi.TabIndex = 76
        Me.CmdGeneraColi.Text = "Generar"
        Me.CmdGeneraColi.UseVisualStyleBackColor = False
        '
        'CmdSalirColi
        '
        Me.CmdSalirColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirColi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirColi.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirColi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirColi.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirColi.Name = "CmdSalirColi"
        Me.CmdSalirColi.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirColi.TabIndex = 74
        Me.CmdSalirColi.Text = "Salir"
        Me.CmdSalirColi.UseVisualStyleBackColor = False
        '
        'TxtLabDesColi
        '
        Me.TxtLabDesColi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesColi.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesColi.Name = "TxtLabDesColi"
        Me.TxtLabDesColi.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesColi.TabIndex = 75
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(284, 176)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(88, 16)
        Me.Label77.TabIndex = 70
        Me.Label77.Text = "N° Lab. Desde"
        '
        'TxtOrdDesColi
        '
        Me.TxtOrdDesColi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesColi.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesColi.Name = "TxtOrdDesColi"
        Me.TxtOrdDesColi.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesColi.TabIndex = 72
        '
        'TxtLabHasColi
        '
        Me.TxtLabHasColi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasColi.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasColi.Name = "TxtLabHasColi"
        Me.TxtLabHasColi.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasColi.TabIndex = 77
        '
        'Label78
        '
        Me.Label78.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.Location = New System.Drawing.Point(284, 136)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(96, 16)
        Me.Label78.TabIndex = 69
        Me.Label78.Text = "N° Orden Desde"
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(516, 176)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(88, 16)
        Me.Label79.TabIndex = 71
        Me.Label79.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenColi
        '
        Me.CmdBuscarOrdenColi.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenColi.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenColi.Location = New System.Drawing.Point(495, 328)
        Me.CmdBuscarOrdenColi.Name = "CmdBuscarOrdenColi"
        Me.CmdBuscarOrdenColi.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenColi.TabIndex = 79
        Me.CmdBuscarOrdenColi.UseVisualStyleBackColor = False
        '
        'tabSueloFert
        '
        Me.tabSueloFert.BackColor = System.Drawing.SystemColors.Control
        Me.tabSueloFert.Controls.Add(Me.lbl_estadoSF)
        Me.tabSueloFert.Controls.Add(Me.CmdConsultaSueloFer)
        Me.tabSueloFert.Controls.Add(Me.CmdNotasSueloFer)
        Me.tabSueloFert.Controls.Add(Me.CmdConfiguraSueloFer)
        Me.tabSueloFert.Controls.Add(Me.Label26)
        Me.tabSueloFert.Controls.Add(Me.GBEnvioArchivoSueloFer)
        Me.tabSueloFert.Controls.Add(Me.TxtOrdHasSueloFer)
        Me.tabSueloFert.Controls.Add(Me.Label30)
        Me.tabSueloFert.Controls.Add(Me.CmdGeneraSueloFer)
        Me.tabSueloFert.Controls.Add(Me.CmdSalirSueloFer)
        Me.tabSueloFert.Controls.Add(Me.TxtLabDesSueloFer)
        Me.tabSueloFert.Controls.Add(Me.Label32)
        Me.tabSueloFert.Controls.Add(Me.TxtOrdDesSueloFer)
        Me.tabSueloFert.Controls.Add(Me.TxtLabHasSueloFer)
        Me.tabSueloFert.Controls.Add(Me.Label33)
        Me.tabSueloFert.Controls.Add(Me.Label34)
        Me.tabSueloFert.Controls.Add(Me.CmdBuscarOrdenSueloFer)
        Me.tabSueloFert.Location = New System.Drawing.Point(4, 26)
        Me.tabSueloFert.Name = "tabSueloFert"
        Me.tabSueloFert.Size = New System.Drawing.Size(1115, 770)
        Me.tabSueloFert.TabIndex = 4
        Me.tabSueloFert.Text = "4. Suelo (Fer)"
        '
        'lbl_estadoSF
        '
        Me.lbl_estadoSF.AutoSize = True
        Me.lbl_estadoSF.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoSF.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoSF.Name = "lbl_estadoSF"
        Me.lbl_estadoSF.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoSF.TabIndex = 71
        Me.lbl_estadoSF.Text = "estado"
        Me.lbl_estadoSF.Visible = False
        '
        'CmdConsultaSueloFer
        '
        Me.CmdConsultaSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaSueloFer.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaSueloFer.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaSueloFer.Name = "CmdConsultaSueloFer"
        Me.CmdConsultaSueloFer.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaSueloFer.TabIndex = 70
        Me.CmdConsultaSueloFer.UseVisualStyleBackColor = False
        '
        'CmdNotasSueloFer
        '
        Me.CmdNotasSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasSueloFer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasSueloFer.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasSueloFer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasSueloFer.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasSueloFer.Name = "CmdNotasSueloFer"
        Me.CmdNotasSueloFer.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasSueloFer.TabIndex = 69
        Me.CmdNotasSueloFer.Text = "Notas"
        Me.CmdNotasSueloFer.UseVisualStyleBackColor = False
        '
        'CmdConfiguraSueloFer
        '
        Me.CmdConfiguraSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraSueloFer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraSueloFer.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraSueloFer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraSueloFer.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraSueloFer.Name = "CmdConfiguraSueloFer"
        Me.CmdConfiguraSueloFer.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraSueloFer.TabIndex = 68
        Me.CmdConfiguraSueloFer.Text = "Configuración"
        Me.CmdConfiguraSueloFer.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label26.Location = New System.Drawing.Point(440, 72)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(174, 18)
        Me.Label26.TabIndex = 63
        Me.Label26.Text = "SUELOS FERTILIDAD"
        '
        'GBEnvioArchivoSueloFer
        '
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.CmdEMailArchivoSueloFer)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.CmdBuscaArchivoSueloFer)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.Label27)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.Label28)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.TxtNomArchSueloFer)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.TxtNomProdArchivoSueloFer)
        Me.GBEnvioArchivoSueloFer.Controls.Add(Me.Label29)
        Me.GBEnvioArchivoSueloFer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoSueloFer.Location = New System.Drawing.Point(244, 400)
        Me.GBEnvioArchivoSueloFer.Name = "GBEnvioArchivoSueloFer"
        Me.GBEnvioArchivoSueloFer.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoSueloFer.TabIndex = 62
        Me.GBEnvioArchivoSueloFer.TabStop = False
        Me.GBEnvioArchivoSueloFer.Visible = False
        '
        'CmdEMailArchivoSueloFer
        '
        Me.CmdEMailArchivoSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoSueloFer.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoSueloFer.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoSueloFer.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoSueloFer.Name = "CmdEMailArchivoSueloFer"
        Me.CmdEMailArchivoSueloFer.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoSueloFer.TabIndex = 35
        Me.CmdEMailArchivoSueloFer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoSueloFer.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoSueloFer
        '
        Me.CmdBuscaArchivoSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoSueloFer.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoSueloFer.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoSueloFer.Name = "CmdBuscaArchivoSueloFer"
        Me.CmdBuscaArchivoSueloFer.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoSueloFer.TabIndex = 34
        Me.CmdBuscaArchivoSueloFer.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoSueloFer.Visible = False
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(72, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(64, 23)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Productor"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(72, 16)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(64, 23)
        Me.Label28.TabIndex = 31
        Me.Label28.Text = "Archivo"
        '
        'TxtNomArchSueloFer
        '
        Me.TxtNomArchSueloFer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchSueloFer.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchSueloFer.Name = "TxtNomArchSueloFer"
        Me.TxtNomArchSueloFer.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchSueloFer.TabIndex = 29
        '
        'TxtNomProdArchivoSueloFer
        '
        Me.TxtNomProdArchivoSueloFer.Enabled = False
        Me.TxtNomProdArchivoSueloFer.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoSueloFer.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoSueloFer.Name = "TxtNomProdArchivoSueloFer"
        Me.TxtNomProdArchivoSueloFer.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoSueloFer.TabIndex = 28
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(184, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(168, 16)
        Me.Label29.TabIndex = 33
        Me.Label29.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasSueloFer
        '
        Me.TxtOrdHasSueloFer.Enabled = False
        Me.TxtOrdHasSueloFer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasSueloFer.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasSueloFer.Name = "TxtOrdHasSueloFer"
        Me.TxtOrdHasSueloFer.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasSueloFer.TabIndex = 53
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(516, 136)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(96, 16)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = "N° Orden Hasta"
        '
        'CmdGeneraSueloFer
        '
        Me.CmdGeneraSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraSueloFer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraSueloFer.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraSueloFer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraSueloFer.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraSueloFer.Name = "CmdGeneraSueloFer"
        Me.CmdGeneraSueloFer.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraSueloFer.TabIndex = 57
        Me.CmdGeneraSueloFer.Text = "Generar"
        Me.CmdGeneraSueloFer.UseVisualStyleBackColor = False
        '
        'CmdSalirSueloFer
        '
        Me.CmdSalirSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirSueloFer.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirSueloFer.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirSueloFer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirSueloFer.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirSueloFer.Name = "CmdSalirSueloFer"
        Me.CmdSalirSueloFer.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirSueloFer.TabIndex = 55
        Me.CmdSalirSueloFer.Text = "Salir"
        Me.CmdSalirSueloFer.UseVisualStyleBackColor = False
        '
        'TxtLabDesSueloFer
        '
        Me.TxtLabDesSueloFer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesSueloFer.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesSueloFer.Name = "TxtLabDesSueloFer"
        Me.TxtLabDesSueloFer.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesSueloFer.TabIndex = 56
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(284, 176)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(88, 16)
        Me.Label32.TabIndex = 50
        Me.Label32.Text = "N° Lab. Desde"
        '
        'TxtOrdDesSueloFer
        '
        Me.TxtOrdDesSueloFer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesSueloFer.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesSueloFer.Name = "TxtOrdDesSueloFer"
        Me.TxtOrdDesSueloFer.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesSueloFer.TabIndex = 52
        '
        'TxtLabHasSueloFer
        '
        Me.TxtLabHasSueloFer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasSueloFer.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasSueloFer.Name = "TxtLabHasSueloFer"
        Me.TxtLabHasSueloFer.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasSueloFer.TabIndex = 58
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(284, 136)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(96, 16)
        Me.Label33.TabIndex = 49
        Me.Label33.Text = "N° Orden Desde"
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(516, 176)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(88, 16)
        Me.Label34.TabIndex = 51
        Me.Label34.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenSueloFer
        '
        Me.CmdBuscarOrdenSueloFer.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenSueloFer.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenSueloFer.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenSueloFer.Name = "CmdBuscarOrdenSueloFer"
        Me.CmdBuscarOrdenSueloFer.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenSueloFer.TabIndex = 60
        Me.CmdBuscarOrdenSueloFer.UseVisualStyleBackColor = False
        '
        'tabSuelo
        '
        Me.tabSuelo.BackColor = System.Drawing.SystemColors.Control
        Me.tabSuelo.Controls.Add(Me.lbl_estadoSS)
        Me.tabSuelo.Controls.Add(Me.CmdConsultaSueloSal)
        Me.tabSuelo.Controls.Add(Me.CmdNotasSueloSal)
        Me.tabSuelo.Controls.Add(Me.CmdConfiguraSueloSal)
        Me.tabSuelo.Controls.Add(Me.Label23)
        Me.tabSuelo.Controls.Add(Me.GroupBox1)
        Me.tabSuelo.Controls.Add(Me.TxtOrdHasSueloSal)
        Me.tabSuelo.Controls.Add(Me.Label36)
        Me.tabSuelo.Controls.Add(Me.CmdGeneraSueloSal)
        Me.tabSuelo.Controls.Add(Me.CmdSalirSueloSal)
        Me.tabSuelo.Controls.Add(Me.TxtLabDesSueloSal)
        Me.tabSuelo.Controls.Add(Me.Label37)
        Me.tabSuelo.Controls.Add(Me.TxtOrdDesSueloSal)
        Me.tabSuelo.Controls.Add(Me.TxtLabHasSueloSal)
        Me.tabSuelo.Controls.Add(Me.Label38)
        Me.tabSuelo.Controls.Add(Me.Label39)
        Me.tabSuelo.Controls.Add(Me.CmdBuscarOrdenSueloSal)
        Me.tabSuelo.Location = New System.Drawing.Point(4, 26)
        Me.tabSuelo.Name = "tabSuelo"
        Me.tabSuelo.Size = New System.Drawing.Size(1115, 770)
        Me.tabSuelo.TabIndex = 9
        Me.tabSuelo.Text = "4. Suelo (Sal)"
        '
        'lbl_estadoSS
        '
        Me.lbl_estadoSS.AutoSize = True
        Me.lbl_estadoSS.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoSS.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoSS.Name = "lbl_estadoSS"
        Me.lbl_estadoSS.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoSS.TabIndex = 82
        Me.lbl_estadoSS.Text = "estado"
        Me.lbl_estadoSS.Visible = False
        '
        'CmdConsultaSueloSal
        '
        Me.CmdConsultaSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaSueloSal.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaSueloSal.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaSueloSal.Name = "CmdConsultaSueloSal"
        Me.CmdConsultaSueloSal.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaSueloSal.TabIndex = 81
        Me.CmdConsultaSueloSal.UseVisualStyleBackColor = False
        '
        'CmdNotasSueloSal
        '
        Me.CmdNotasSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasSueloSal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasSueloSal.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasSueloSal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasSueloSal.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasSueloSal.Name = "CmdNotasSueloSal"
        Me.CmdNotasSueloSal.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasSueloSal.TabIndex = 80
        Me.CmdNotasSueloSal.Text = "Notas"
        Me.CmdNotasSueloSal.UseVisualStyleBackColor = False
        '
        'CmdConfiguraSueloSal
        '
        Me.CmdConfiguraSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraSueloSal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraSueloSal.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraSueloSal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraSueloSal.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraSueloSal.Name = "CmdConfiguraSueloSal"
        Me.CmdConfiguraSueloSal.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraSueloSal.TabIndex = 79
        Me.CmdConfiguraSueloSal.Text = "Configuración"
        Me.CmdConfiguraSueloSal.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label23.Location = New System.Drawing.Point(440, 72)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(164, 18)
        Me.Label23.TabIndex = 78
        Me.Label23.Text = "SUELOS SALINIDAD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdEMailArchivoSueloSal)
        Me.GroupBox1.Controls.Add(Me.CmdBuscaArchivoSueloSal)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.Label31)
        Me.GroupBox1.Controls.Add(Me.TxtNomArchSueloSal)
        Me.GroupBox1.Controls.Add(Me.TxtNomProdArchivoSueloSal)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(244, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(504, 104)
        Me.GroupBox1.TabIndex = 77
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'CmdEMailArchivoSueloSal
        '
        Me.CmdEMailArchivoSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoSueloSal.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoSueloSal.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoSueloSal.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoSueloSal.Name = "CmdEMailArchivoSueloSal"
        Me.CmdEMailArchivoSueloSal.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoSueloSal.TabIndex = 35
        Me.CmdEMailArchivoSueloSal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoSueloSal.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoSueloSal
        '
        Me.CmdBuscaArchivoSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoSueloSal.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoSueloSal.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoSueloSal.Name = "CmdBuscaArchivoSueloSal"
        Me.CmdBuscaArchivoSueloSal.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoSueloSal.TabIndex = 34
        Me.CmdBuscaArchivoSueloSal.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoSueloSal.Visible = False
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(72, 48)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 23)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Productor"
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label31.Location = New System.Drawing.Point(72, 16)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 23)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "Archivo"
        '
        'TxtNomArchSueloSal
        '
        Me.TxtNomArchSueloSal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchSueloSal.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchSueloSal.Name = "TxtNomArchSueloSal"
        Me.TxtNomArchSueloSal.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchSueloSal.TabIndex = 29
        '
        'TxtNomProdArchivoSueloSal
        '
        Me.TxtNomProdArchivoSueloSal.Enabled = False
        Me.TxtNomProdArchivoSueloSal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoSueloSal.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoSueloSal.Name = "TxtNomProdArchivoSueloSal"
        Me.TxtNomProdArchivoSueloSal.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoSueloSal.TabIndex = 28
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(184, 80)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(168, 16)
        Me.Label35.TabIndex = 33
        Me.Label35.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasSueloSal
        '
        Me.TxtOrdHasSueloSal.Enabled = False
        Me.TxtOrdHasSueloSal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasSueloSal.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasSueloSal.Name = "TxtOrdHasSueloSal"
        Me.TxtOrdHasSueloSal.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasSueloSal.TabIndex = 68
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label36.Location = New System.Drawing.Point(516, 136)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(96, 16)
        Me.Label36.TabIndex = 74
        Me.Label36.Text = "N° Orden Hasta"
        '
        'CmdGeneraSueloSal
        '
        Me.CmdGeneraSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraSueloSal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraSueloSal.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraSueloSal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraSueloSal.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraSueloSal.Name = "CmdGeneraSueloSal"
        Me.CmdGeneraSueloSal.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraSueloSal.TabIndex = 72
        Me.CmdGeneraSueloSal.Text = "Generar"
        Me.CmdGeneraSueloSal.UseVisualStyleBackColor = False
        '
        'CmdSalirSueloSal
        '
        Me.CmdSalirSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirSueloSal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirSueloSal.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirSueloSal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirSueloSal.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirSueloSal.Name = "CmdSalirSueloSal"
        Me.CmdSalirSueloSal.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirSueloSal.TabIndex = 70
        Me.CmdSalirSueloSal.Text = "Salir"
        Me.CmdSalirSueloSal.UseVisualStyleBackColor = False
        '
        'TxtLabDesSueloSal
        '
        Me.TxtLabDesSueloSal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesSueloSal.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesSueloSal.Name = "TxtLabDesSueloSal"
        Me.TxtLabDesSueloSal.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesSueloSal.TabIndex = 71
        '
        'Label37
        '
        Me.Label37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(284, 176)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(88, 16)
        Me.Label37.TabIndex = 65
        Me.Label37.Text = "N° Lab. Desde"
        '
        'TxtOrdDesSueloSal
        '
        Me.TxtOrdDesSueloSal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesSueloSal.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesSueloSal.Name = "TxtOrdDesSueloSal"
        Me.TxtOrdDesSueloSal.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesSueloSal.TabIndex = 67
        '
        'TxtLabHasSueloSal
        '
        Me.TxtLabHasSueloSal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasSueloSal.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasSueloSal.Name = "TxtLabHasSueloSal"
        Me.TxtLabHasSueloSal.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasSueloSal.TabIndex = 73
        '
        'Label38
        '
        Me.Label38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(284, 136)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(96, 16)
        Me.Label38.TabIndex = 64
        Me.Label38.Text = "N° Orden Desde"
        '
        'Label39
        '
        Me.Label39.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(516, 176)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(88, 16)
        Me.Label39.TabIndex = 66
        Me.Label39.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenSueloSal
        '
        Me.CmdBuscarOrdenSueloSal.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenSueloSal.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenSueloSal.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenSueloSal.Name = "CmdBuscarOrdenSueloSal"
        Me.CmdBuscarOrdenSueloSal.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenSueloSal.TabIndex = 75
        Me.CmdBuscarOrdenSueloSal.UseVisualStyleBackColor = False
        '
        'tabFertQuimico
        '
        Me.tabFertQuimico.BackColor = System.Drawing.SystemColors.Control
        Me.tabFertQuimico.Controls.Add(Me.lbl_estadoFQ)
        Me.tabFertQuimico.Controls.Add(Me.CmdConsultaFertQui)
        Me.tabFertQuimico.Controls.Add(Me.CmdNotasFertQui)
        Me.tabFertQuimico.Controls.Add(Me.CmdConfiguraFertQui)
        Me.tabFertQuimico.Controls.Add(Me.Label43)
        Me.tabFertQuimico.Controls.Add(Me.GBEnvioArchivoFertQui)
        Me.tabFertQuimico.Controls.Add(Me.TxtOrdHasFertQui)
        Me.tabFertQuimico.Controls.Add(Me.Label47)
        Me.tabFertQuimico.Controls.Add(Me.CmdGeneraFertQui)
        Me.tabFertQuimico.Controls.Add(Me.CmdSalirFertQui)
        Me.tabFertQuimico.Controls.Add(Me.TxtLabDesFertQui)
        Me.tabFertQuimico.Controls.Add(Me.Label48)
        Me.tabFertQuimico.Controls.Add(Me.TxtOrdDesFertQui)
        Me.tabFertQuimico.Controls.Add(Me.TxtLabHasFertQui)
        Me.tabFertQuimico.Controls.Add(Me.Label49)
        Me.tabFertQuimico.Controls.Add(Me.Label50)
        Me.tabFertQuimico.Controls.Add(Me.CmdBuscarOrdenFertQui)
        Me.tabFertQuimico.Location = New System.Drawing.Point(4, 26)
        Me.tabFertQuimico.Name = "tabFertQuimico"
        Me.tabFertQuimico.Size = New System.Drawing.Size(1115, 770)
        Me.tabFertQuimico.TabIndex = 6
        Me.tabFertQuimico.Text = "5. Fert. Qui."
        '
        'lbl_estadoFQ
        '
        Me.lbl_estadoFQ.AutoSize = True
        Me.lbl_estadoFQ.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoFQ.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoFQ.Name = "lbl_estadoFQ"
        Me.lbl_estadoFQ.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoFQ.TabIndex = 84
        Me.lbl_estadoFQ.Text = "estado"
        Me.lbl_estadoFQ.Visible = False
        '
        'CmdConsultaFertQui
        '
        Me.CmdConsultaFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaFertQui.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaFertQui.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaFertQui.Name = "CmdConsultaFertQui"
        Me.CmdConsultaFertQui.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaFertQui.TabIndex = 83
        Me.CmdConsultaFertQui.UseVisualStyleBackColor = False
        '
        'CmdNotasFertQui
        '
        Me.CmdNotasFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasFertQui.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasFertQui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasFertQui.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasFertQui.Name = "CmdNotasFertQui"
        Me.CmdNotasFertQui.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasFertQui.TabIndex = 82
        Me.CmdNotasFertQui.Text = "Notas"
        Me.CmdNotasFertQui.UseVisualStyleBackColor = False
        '
        'CmdConfiguraFertQui
        '
        Me.CmdConfiguraFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraFertQui.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraFertQui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraFertQui.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraFertQui.Name = "CmdConfiguraFertQui"
        Me.CmdConfiguraFertQui.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraFertQui.TabIndex = 81
        Me.CmdConfiguraFertQui.Text = "Configuración"
        Me.CmdConfiguraFertQui.UseVisualStyleBackColor = False
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label43.Location = New System.Drawing.Point(441, 72)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(144, 18)
        Me.Label43.TabIndex = 63
        Me.Label43.Text = "FERT. QUÍMICOS"
        '
        'GBEnvioArchivoFertQui
        '
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.CmdEMailArchivoFertQui)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.CmdBuscaArchivoFertQui1)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.Label44)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.Label45)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.TxtNomArchFertQui)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.TxtNomProdArchivoFertQui)
        Me.GBEnvioArchivoFertQui.Controls.Add(Me.Label46)
        Me.GBEnvioArchivoFertQui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoFertQui.Location = New System.Drawing.Point(244, 400)
        Me.GBEnvioArchivoFertQui.Name = "GBEnvioArchivoFertQui"
        Me.GBEnvioArchivoFertQui.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoFertQui.TabIndex = 62
        Me.GBEnvioArchivoFertQui.TabStop = False
        Me.GBEnvioArchivoFertQui.Visible = False
        '
        'CmdEMailArchivoFertQui
        '
        Me.CmdEMailArchivoFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoFertQui.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoFertQui.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoFertQui.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoFertQui.Name = "CmdEMailArchivoFertQui"
        Me.CmdEMailArchivoFertQui.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoFertQui.TabIndex = 35
        Me.CmdEMailArchivoFertQui.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoFertQui.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoFertQui1
        '
        Me.CmdBuscaArchivoFertQui1.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoFertQui1.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoFertQui1.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoFertQui1.Name = "CmdBuscaArchivoFertQui1"
        Me.CmdBuscaArchivoFertQui1.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoFertQui1.TabIndex = 34
        Me.CmdBuscaArchivoFertQui1.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoFertQui1.Visible = False
        '
        'Label44
        '
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(72, 48)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(64, 23)
        Me.Label44.TabIndex = 30
        Me.Label44.Text = "Productor"
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label45.Location = New System.Drawing.Point(72, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 23)
        Me.Label45.TabIndex = 31
        Me.Label45.Text = "Archivo"
        '
        'TxtNomArchFertQui
        '
        Me.TxtNomArchFertQui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchFertQui.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchFertQui.Name = "TxtNomArchFertQui"
        Me.TxtNomArchFertQui.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchFertQui.TabIndex = 29
        '
        'TxtNomProdArchivoFertQui
        '
        Me.TxtNomProdArchivoFertQui.Enabled = False
        Me.TxtNomProdArchivoFertQui.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoFertQui.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoFertQui.Name = "TxtNomProdArchivoFertQui"
        Me.TxtNomProdArchivoFertQui.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoFertQui.TabIndex = 28
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.Location = New System.Drawing.Point(184, 80)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(168, 16)
        Me.Label46.TabIndex = 33
        Me.Label46.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasFertQui
        '
        Me.TxtOrdHasFertQui.Enabled = False
        Me.TxtOrdHasFertQui.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasFertQui.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasFertQui.Name = "TxtOrdHasFertQui"
        Me.TxtOrdHasFertQui.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasFertQui.TabIndex = 53
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label47.Location = New System.Drawing.Point(516, 136)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(96, 16)
        Me.Label47.TabIndex = 59
        Me.Label47.Text = "N° Orden Hasta"
        '
        'CmdGeneraFertQui
        '
        Me.CmdGeneraFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraFertQui.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraFertQui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraFertQui.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraFertQui.Name = "CmdGeneraFertQui"
        Me.CmdGeneraFertQui.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraFertQui.TabIndex = 57
        Me.CmdGeneraFertQui.Text = "Generar"
        Me.CmdGeneraFertQui.UseVisualStyleBackColor = False
        '
        'CmdSalirFertQui
        '
        Me.CmdSalirFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirFertQui.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirFertQui.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirFertQui.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirFertQui.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirFertQui.Name = "CmdSalirFertQui"
        Me.CmdSalirFertQui.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirFertQui.TabIndex = 55
        Me.CmdSalirFertQui.Text = "Salir"
        Me.CmdSalirFertQui.UseVisualStyleBackColor = False
        '
        'TxtLabDesFertQui
        '
        Me.TxtLabDesFertQui.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesFertQui.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesFertQui.Name = "TxtLabDesFertQui"
        Me.TxtLabDesFertQui.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesFertQui.TabIndex = 56
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.Location = New System.Drawing.Point(284, 176)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(88, 16)
        Me.Label48.TabIndex = 50
        Me.Label48.Text = "N° Lab. Desde"
        '
        'TxtOrdDesFertQui
        '
        Me.TxtOrdDesFertQui.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesFertQui.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesFertQui.Name = "TxtOrdDesFertQui"
        Me.TxtOrdDesFertQui.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesFertQui.TabIndex = 52
        '
        'TxtLabHasFertQui
        '
        Me.TxtLabHasFertQui.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasFertQui.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasFertQui.Name = "TxtLabHasFertQui"
        Me.TxtLabHasFertQui.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasFertQui.TabIndex = 58
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.Location = New System.Drawing.Point(284, 136)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(96, 16)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "N° Orden Desde"
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.Location = New System.Drawing.Point(516, 176)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(88, 16)
        Me.Label50.TabIndex = 51
        Me.Label50.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenFertQui
        '
        Me.CmdBuscarOrdenFertQui.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenFertQui.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenFertQui.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenFertQui.Name = "CmdBuscarOrdenFertQui"
        Me.CmdBuscarOrdenFertQui.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenFertQui.TabIndex = 60
        Me.CmdBuscarOrdenFertQui.UseVisualStyleBackColor = False
        '
        'tabFertOrganico
        '
        Me.tabFertOrganico.BackColor = System.Drawing.SystemColors.Control
        Me.tabFertOrganico.Controls.Add(Me.lbl_estadoFO)
        Me.tabFertOrganico.Controls.Add(Me.CmdConsultaFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.CmdNotasFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.CmdConfiguraFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.Label40)
        Me.tabFertOrganico.Controls.Add(Me.GBEnvioArchivoFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.TxtOrdHasFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.Label68)
        Me.tabFertOrganico.Controls.Add(Me.CmdGeneraFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.CmdSalirFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.TxtLabDesFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.Label69)
        Me.tabFertOrganico.Controls.Add(Me.TxtOrdDesFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.TxtLabHasFertOrgFis)
        Me.tabFertOrganico.Controls.Add(Me.Label70)
        Me.tabFertOrganico.Controls.Add(Me.Label71)
        Me.tabFertOrganico.Controls.Add(Me.CmdBuscarOrdenFertOrgFis)
        Me.tabFertOrganico.Location = New System.Drawing.Point(4, 26)
        Me.tabFertOrganico.Name = "tabFertOrganico"
        Me.tabFertOrganico.Size = New System.Drawing.Size(1115, 770)
        Me.tabFertOrganico.TabIndex = 10
        Me.tabFertOrganico.Text = "6. Fert.Org."
        '
        'lbl_estadoFO
        '
        Me.lbl_estadoFO.AutoSize = True
        Me.lbl_estadoFO.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoFO.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoFO.Name = "lbl_estadoFO"
        Me.lbl_estadoFO.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoFO.TabIndex = 104
        Me.lbl_estadoFO.Text = "estado"
        Me.lbl_estadoFO.Visible = False
        '
        'CmdConsultaFertOrgFis
        '
        Me.CmdConsultaFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaFertOrgFis.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaFertOrgFis.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaFertOrgFis.Name = "CmdConsultaFertOrgFis"
        Me.CmdConsultaFertOrgFis.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaFertOrgFis.TabIndex = 103
        Me.CmdConsultaFertOrgFis.UseVisualStyleBackColor = False
        '
        'CmdNotasFertOrgFis
        '
        Me.CmdNotasFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasFertOrgFis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasFertOrgFis.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasFertOrgFis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasFertOrgFis.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasFertOrgFis.Name = "CmdNotasFertOrgFis"
        Me.CmdNotasFertOrgFis.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasFertOrgFis.TabIndex = 102
        Me.CmdNotasFertOrgFis.Text = "Notas"
        Me.CmdNotasFertOrgFis.UseVisualStyleBackColor = False
        '
        'CmdConfiguraFertOrgFis
        '
        Me.CmdConfiguraFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraFertOrgFis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraFertOrgFis.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraFertOrgFis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraFertOrgFis.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraFertOrgFis.Name = "CmdConfiguraFertOrgFis"
        Me.CmdConfiguraFertOrgFis.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraFertOrgFis.TabIndex = 101
        Me.CmdConfiguraFertOrgFis.Text = "Configuración"
        Me.CmdConfiguraFertOrgFis.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label40.Location = New System.Drawing.Point(435, 73)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(161, 18)
        Me.Label40.TabIndex = 100
        Me.Label40.Text = "FERT. ORGÁNICOS"
        '
        'GBEnvioArchivoFertOrgFis
        '
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.CmdEMailArchivoFertOrgFis)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.CmdBuscaArchivoFertOrgFis)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.Label41)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.Label42)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.TxtNomArchFertOrgFis)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.TxtNomProdArchivoFertOrgFis)
        Me.GBEnvioArchivoFertOrgFis.Controls.Add(Me.Label67)
        Me.GBEnvioArchivoFertOrgFis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoFertOrgFis.Location = New System.Drawing.Point(244, 400)
        Me.GBEnvioArchivoFertOrgFis.Name = "GBEnvioArchivoFertOrgFis"
        Me.GBEnvioArchivoFertOrgFis.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoFertOrgFis.TabIndex = 99
        Me.GBEnvioArchivoFertOrgFis.TabStop = False
        Me.GBEnvioArchivoFertOrgFis.Visible = False
        '
        'CmdEMailArchivoFertOrgFis
        '
        Me.CmdEMailArchivoFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoFertOrgFis.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoFertOrgFis.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoFertOrgFis.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoFertOrgFis.Name = "CmdEMailArchivoFertOrgFis"
        Me.CmdEMailArchivoFertOrgFis.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoFertOrgFis.TabIndex = 35
        Me.CmdEMailArchivoFertOrgFis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoFertOrgFis.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoFertOrgFis
        '
        Me.CmdBuscaArchivoFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoFertOrgFis.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoFertOrgFis.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoFertOrgFis.Name = "CmdBuscaArchivoFertOrgFis"
        Me.CmdBuscaArchivoFertOrgFis.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoFertOrgFis.TabIndex = 34
        Me.CmdBuscaArchivoFertOrgFis.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoFertOrgFis.Visible = False
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(72, 48)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(64, 23)
        Me.Label41.TabIndex = 30
        Me.Label41.Text = "Productor"
        '
        'Label42
        '
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label42.Location = New System.Drawing.Point(72, 16)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(64, 23)
        Me.Label42.TabIndex = 31
        Me.Label42.Text = "Archivo"
        '
        'TxtNomArchFertOrgFis
        '
        Me.TxtNomArchFertOrgFis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchFertOrgFis.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchFertOrgFis.Name = "TxtNomArchFertOrgFis"
        Me.TxtNomArchFertOrgFis.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchFertOrgFis.TabIndex = 29
        '
        'TxtNomProdArchivoFertOrgFis
        '
        Me.TxtNomProdArchivoFertOrgFis.Enabled = False
        Me.TxtNomProdArchivoFertOrgFis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoFertOrgFis.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoFertOrgFis.Name = "TxtNomProdArchivoFertOrgFis"
        Me.TxtNomProdArchivoFertOrgFis.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoFertOrgFis.TabIndex = 28
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(184, 80)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(168, 16)
        Me.Label67.TabIndex = 33
        Me.Label67.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasFertOrgFis
        '
        Me.TxtOrdHasFertOrgFis.Enabled = False
        Me.TxtOrdHasFertOrgFis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasFertOrgFis.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasFertOrgFis.Name = "TxtOrdHasFertOrgFis"
        Me.TxtOrdHasFertOrgFis.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasFertOrgFis.TabIndex = 90
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label68.Location = New System.Drawing.Point(516, 136)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(96, 16)
        Me.Label68.TabIndex = 96
        Me.Label68.Text = "N° Orden Hasta"
        '
        'CmdGeneraFertOrgFis
        '
        Me.CmdGeneraFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraFertOrgFis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraFertOrgFis.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraFertOrgFis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraFertOrgFis.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraFertOrgFis.Name = "CmdGeneraFertOrgFis"
        Me.CmdGeneraFertOrgFis.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraFertOrgFis.TabIndex = 94
        Me.CmdGeneraFertOrgFis.Text = "Generar"
        Me.CmdGeneraFertOrgFis.UseVisualStyleBackColor = False
        '
        'CmdSalirFertOrgFis
        '
        Me.CmdSalirFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirFertOrgFis.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirFertOrgFis.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirFertOrgFis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirFertOrgFis.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirFertOrgFis.Name = "CmdSalirFertOrgFis"
        Me.CmdSalirFertOrgFis.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirFertOrgFis.TabIndex = 92
        Me.CmdSalirFertOrgFis.Text = "Salir"
        Me.CmdSalirFertOrgFis.UseVisualStyleBackColor = False
        '
        'TxtLabDesFertOrgFis
        '
        Me.TxtLabDesFertOrgFis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesFertOrgFis.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesFertOrgFis.Name = "TxtLabDesFertOrgFis"
        Me.TxtLabDesFertOrgFis.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesFertOrgFis.TabIndex = 93
        '
        'Label69
        '
        Me.Label69.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(284, 176)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(88, 16)
        Me.Label69.TabIndex = 87
        Me.Label69.Text = "N° Lab. Desde"
        '
        'TxtOrdDesFertOrgFis
        '
        Me.TxtOrdDesFertOrgFis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesFertOrgFis.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesFertOrgFis.Name = "TxtOrdDesFertOrgFis"
        Me.TxtOrdDesFertOrgFis.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesFertOrgFis.TabIndex = 89
        '
        'TxtLabHasFertOrgFis
        '
        Me.TxtLabHasFertOrgFis.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasFertOrgFis.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasFertOrgFis.Name = "TxtLabHasFertOrgFis"
        Me.TxtLabHasFertOrgFis.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasFertOrgFis.TabIndex = 95
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(284, 136)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(96, 16)
        Me.Label70.TabIndex = 86
        Me.Label70.Text = "N° Orden Desde"
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(516, 176)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(88, 16)
        Me.Label71.TabIndex = 88
        Me.Label71.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenFertOrgFis
        '
        Me.CmdBuscarOrdenFertOrgFis.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenFertOrgFis.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenFertOrgFis.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenFertOrgFis.Name = "CmdBuscarOrdenFertOrgFis"
        Me.CmdBuscarOrdenFertOrgFis.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenFertOrgFis.TabIndex = 97
        Me.CmdBuscarOrdenFertOrgFis.UseVisualStyleBackColor = False
        '
        'tabOtros
        '
        Me.tabOtros.BackColor = System.Drawing.SystemColors.Control
        Me.tabOtros.Controls.Add(Me.lbl_estadoFito)
        Me.tabOtros.Controls.Add(Me.CmdConsultaOtros)
        Me.tabOtros.Controls.Add(Me.CmdNotasOtros)
        Me.tabOtros.Controls.Add(Me.CmdConfiguraOtros)
        Me.tabOtros.Controls.Add(Me.Label59)
        Me.tabOtros.Controls.Add(Me.GBEnvioArchivoOtros)
        Me.tabOtros.Controls.Add(Me.TxtOrdHasOtros)
        Me.tabOtros.Controls.Add(Me.Label63)
        Me.tabOtros.Controls.Add(Me.CmdGeneraOtros)
        Me.tabOtros.Controls.Add(Me.CmdSalirOtros)
        Me.tabOtros.Controls.Add(Me.TxtLabDesOtros)
        Me.tabOtros.Controls.Add(Me.Label64)
        Me.tabOtros.Controls.Add(Me.TxtOrdDesOtros)
        Me.tabOtros.Controls.Add(Me.TxtLabHasOtros)
        Me.tabOtros.Controls.Add(Me.Label65)
        Me.tabOtros.Controls.Add(Me.Label66)
        Me.tabOtros.Controls.Add(Me.CmdBuscarOrdenOtros)
        Me.tabOtros.Location = New System.Drawing.Point(4, 26)
        Me.tabOtros.Name = "tabOtros"
        Me.tabOtros.Size = New System.Drawing.Size(1115, 770)
        Me.tabOtros.TabIndex = 8
        Me.tabOtros.Text = "7. Fitopatología"
        '
        'lbl_estadoFito
        '
        Me.lbl_estadoFito.AutoSize = True
        Me.lbl_estadoFito.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoFito.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoFito.Name = "lbl_estadoFito"
        Me.lbl_estadoFito.Size = New System.Drawing.Size(52, 17)
        Me.lbl_estadoFito.TabIndex = 86
        Me.lbl_estadoFito.Text = "estado"
        Me.lbl_estadoFito.Visible = False
        '
        'CmdConsultaOtros
        '
        Me.CmdConsultaOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaOtros.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaOtros.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaOtros.Name = "CmdConsultaOtros"
        Me.CmdConsultaOtros.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaOtros.TabIndex = 85
        Me.CmdConsultaOtros.UseVisualStyleBackColor = False
        '
        'CmdNotasOtros
        '
        Me.CmdNotasOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasOtros.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasOtros.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasOtros.Name = "CmdNotasOtros"
        Me.CmdNotasOtros.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasOtros.TabIndex = 84
        Me.CmdNotasOtros.Text = "Notas"
        Me.CmdNotasOtros.UseVisualStyleBackColor = False
        '
        'CmdConfiguraOtros
        '
        Me.CmdConfiguraOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraOtros.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraOtros.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraOtros.Name = "CmdConfiguraOtros"
        Me.CmdConfiguraOtros.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraOtros.TabIndex = 83
        Me.CmdConfiguraOtros.Text = "Configuración"
        Me.CmdConfiguraOtros.UseVisualStyleBackColor = False
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label59.Location = New System.Drawing.Point(442, 72)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(138, 18)
        Me.Label59.TabIndex = 63
        Me.Label59.Text = "FITOPATOLOGÍA"
        '
        'GBEnvioArchivoOtros
        '
        Me.GBEnvioArchivoOtros.Controls.Add(Me.CmdEMailArchivoOtros)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.CmdBuscaArchivoOtros)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.Label60)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.Label61)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.TxtNomArchOtros)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.TxtNomProdArchivoOtros)
        Me.GBEnvioArchivoOtros.Controls.Add(Me.Label62)
        Me.GBEnvioArchivoOtros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBEnvioArchivoOtros.Location = New System.Drawing.Point(244, 400)
        Me.GBEnvioArchivoOtros.Name = "GBEnvioArchivoOtros"
        Me.GBEnvioArchivoOtros.Size = New System.Drawing.Size(504, 104)
        Me.GBEnvioArchivoOtros.TabIndex = 62
        Me.GBEnvioArchivoOtros.TabStop = False
        Me.GBEnvioArchivoOtros.Visible = False
        '
        'CmdEMailArchivoOtros
        '
        Me.CmdEMailArchivoOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdEMailArchivoOtros.Image = Global.LabSys.My.Resources.Resources.email
        Me.CmdEMailArchivoOtros.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CmdEMailArchivoOtros.Location = New System.Drawing.Point(424, 32)
        Me.CmdEMailArchivoOtros.Name = "CmdEMailArchivoOtros"
        Me.CmdEMailArchivoOtros.Size = New System.Drawing.Size(32, 24)
        Me.CmdEMailArchivoOtros.TabIndex = 35
        Me.CmdEMailArchivoOtros.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEMailArchivoOtros.UseVisualStyleBackColor = False
        '
        'CmdBuscaArchivoOtros
        '
        Me.CmdBuscaArchivoOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscaArchivoOtros.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscaArchivoOtros.Location = New System.Drawing.Point(16, 32)
        Me.CmdBuscaArchivoOtros.Name = "CmdBuscaArchivoOtros"
        Me.CmdBuscaArchivoOtros.Size = New System.Drawing.Size(32, 24)
        Me.CmdBuscaArchivoOtros.TabIndex = 34
        Me.CmdBuscaArchivoOtros.UseVisualStyleBackColor = False
        Me.CmdBuscaArchivoOtros.Visible = False
        '
        'Label60
        '
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(72, 48)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(64, 23)
        Me.Label60.TabIndex = 30
        Me.Label60.Text = "Productor"
        '
        'Label61
        '
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label61.Location = New System.Drawing.Point(72, 16)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(64, 23)
        Me.Label61.TabIndex = 31
        Me.Label61.Text = "Archivo"
        '
        'TxtNomArchOtros
        '
        Me.TxtNomArchOtros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchOtros.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchOtros.Name = "TxtNomArchOtros"
        Me.TxtNomArchOtros.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchOtros.TabIndex = 29
        '
        'TxtNomProdArchivoOtros
        '
        Me.TxtNomProdArchivoOtros.Enabled = False
        Me.TxtNomProdArchivoOtros.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoOtros.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoOtros.Name = "TxtNomProdArchivoOtros"
        Me.TxtNomProdArchivoOtros.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoOtros.TabIndex = 28
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(184, 80)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(168, 16)
        Me.Label62.TabIndex = 33
        Me.Label62.Text = "Para enviar un archivo creado"
        '
        'TxtOrdHasOtros
        '
        Me.TxtOrdHasOtros.Enabled = False
        Me.TxtOrdHasOtros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasOtros.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasOtros.Name = "TxtOrdHasOtros"
        Me.TxtOrdHasOtros.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasOtros.TabIndex = 53
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label63.Location = New System.Drawing.Point(516, 136)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(96, 16)
        Me.Label63.TabIndex = 59
        Me.Label63.Text = "N° Orden Hasta"
        '
        'CmdGeneraOtros
        '
        Me.CmdGeneraOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraOtros.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraOtros.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraOtros.Name = "CmdGeneraOtros"
        Me.CmdGeneraOtros.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraOtros.TabIndex = 57
        Me.CmdGeneraOtros.Text = "Generar"
        Me.CmdGeneraOtros.UseVisualStyleBackColor = False
        '
        'CmdSalirOtros
        '
        Me.CmdSalirOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirOtros.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirOtros.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirOtros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirOtros.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirOtros.Name = "CmdSalirOtros"
        Me.CmdSalirOtros.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirOtros.TabIndex = 55
        Me.CmdSalirOtros.Text = "Salir"
        Me.CmdSalirOtros.UseVisualStyleBackColor = False
        '
        'TxtLabDesOtros
        '
        Me.TxtLabDesOtros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesOtros.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesOtros.Name = "TxtLabDesOtros"
        Me.TxtLabDesOtros.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesOtros.TabIndex = 56
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(284, 176)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(88, 16)
        Me.Label64.TabIndex = 50
        Me.Label64.Text = "N° Lab. Desde"
        '
        'TxtOrdDesOtros
        '
        Me.TxtOrdDesOtros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesOtros.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesOtros.Name = "TxtOrdDesOtros"
        Me.TxtOrdDesOtros.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesOtros.TabIndex = 52
        '
        'TxtLabHasOtros
        '
        Me.TxtLabHasOtros.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasOtros.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasOtros.Name = "TxtLabHasOtros"
        Me.TxtLabHasOtros.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasOtros.TabIndex = 58
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(284, 136)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(96, 16)
        Me.Label65.TabIndex = 49
        Me.Label65.Text = "N° Orden Desde"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(516, 176)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(88, 16)
        Me.Label66.TabIndex = 51
        Me.Label66.Text = "N° Lab Hasta"
        '
        'CmdBuscarOrdenOtros
        '
        Me.CmdBuscarOrdenOtros.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenOtros.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenOtros.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenOtros.Name = "CmdBuscarOrdenOtros"
        Me.CmdBuscarOrdenOtros.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenOtros.TabIndex = 60
        Me.CmdBuscarOrdenOtros.UseVisualStyleBackColor = False
        '
        'tabNematodos
        '
        Me.tabNematodos.BackColor = System.Drawing.SystemColors.Control
        Me.tabNematodos.Controls.Add(Me.lbl_estadoNem)
        Me.tabNematodos.Controls.Add(Me.CmdNotasNema)
        Me.tabNematodos.Controls.Add(Me.CmdConfiguraNema)
        Me.tabNematodos.Controls.Add(Me.Label51)
        Me.tabNematodos.Controls.Add(Me.GroupBox2)
        Me.tabNematodos.Controls.Add(Me.TxtOrdHasNema)
        Me.tabNematodos.Controls.Add(Me.Label55)
        Me.tabNematodos.Controls.Add(Me.CmdGeneraNema)
        Me.tabNematodos.Controls.Add(Me.CmdSalirNema)
        Me.tabNematodos.Controls.Add(Me.TxtLabDesNema)
        Me.tabNematodos.Controls.Add(Me.Label56)
        Me.tabNematodos.Controls.Add(Me.TxtOrdDesNema)
        Me.tabNematodos.Controls.Add(Me.TxtLabHasNema)
        Me.tabNematodos.Controls.Add(Me.Label57)
        Me.tabNematodos.Controls.Add(Me.Label58)
        Me.tabNematodos.Controls.Add(Me.CmdConsultaNema)
        Me.tabNematodos.Controls.Add(Me.CmdBuscarOrdenNema)
        Me.tabNematodos.Font = New System.Drawing.Font("Bar Code", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabNematodos.Location = New System.Drawing.Point(4, 26)
        Me.tabNematodos.Name = "tabNematodos"
        Me.tabNematodos.Size = New System.Drawing.Size(1115, 770)
        Me.tabNematodos.TabIndex = 11
        Me.tabNematodos.Text = "8.Nematodos"
        '
        'lbl_estadoNem
        '
        Me.lbl_estadoNem.AutoSize = True
        Me.lbl_estadoNem.ForeColor = System.Drawing.Color.DarkGreen
        Me.lbl_estadoNem.Location = New System.Drawing.Point(245, 305)
        Me.lbl_estadoNem.Name = "lbl_estadoNem"
        Me.lbl_estadoNem.Size = New System.Drawing.Size(59, 18)
        Me.lbl_estadoNem.TabIndex = 70
        Me.lbl_estadoNem.Text = "estado"
        Me.lbl_estadoNem.Visible = False
        '
        'CmdNotasNema
        '
        Me.CmdNotasNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdNotasNema.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNotasNema.Image = Global.LabSys.My.Resources.Resources.note
        Me.CmdNotasNema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdNotasNema.Location = New System.Drawing.Point(536, 256)
        Me.CmdNotasNema.Name = "CmdNotasNema"
        Me.CmdNotasNema.Size = New System.Drawing.Size(120, 46)
        Me.CmdNotasNema.TabIndex = 67
        Me.CmdNotasNema.Text = "Notas"
        Me.CmdNotasNema.UseVisualStyleBackColor = False
        '
        'CmdConfiguraNema
        '
        Me.CmdConfiguraNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdConfiguraNema.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdConfiguraNema.Image = Global.LabSys.My.Resources.Resources.cog
        Me.CmdConfiguraNema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdConfiguraNema.Location = New System.Drawing.Point(392, 256)
        Me.CmdConfiguraNema.Name = "CmdConfiguraNema"
        Me.CmdConfiguraNema.Size = New System.Drawing.Size(120, 46)
        Me.CmdConfiguraNema.TabIndex = 66
        Me.CmdConfiguraNema.Text = "Configuración"
        Me.CmdConfiguraNema.UseVisualStyleBackColor = False
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Bar Code", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle))
        Me.Label51.Location = New System.Drawing.Point(437, 73)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(136, 32)
        Me.Label51.TabIndex = 64
        Me.Label51.Text = "NEMÁTODOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Label52)
        Me.GroupBox2.Controls.Add(Me.Label53)
        Me.GroupBox2.Controls.Add(Me.TxtNomArchNema)
        Me.GroupBox2.Controls.Add(Me.TxtNomProdArchivoNema)
        Me.GroupBox2.Controls.Add(Me.Label54)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(244, 400)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(504, 104)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Visible = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.LabSys.My.Resources.Resources.email
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.Location = New System.Drawing.Point(424, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(32, 24)
        Me.Button4.TabIndex = 35
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.Location = New System.Drawing.Point(72, 48)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(64, 23)
        Me.Label52.TabIndex = 30
        Me.Label52.Text = "Productor"
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label53.Location = New System.Drawing.Point(72, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(64, 23)
        Me.Label53.TabIndex = 31
        Me.Label53.Text = "Archivo"
        '
        'TxtNomArchNema
        '
        Me.TxtNomArchNema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomArchNema.Location = New System.Drawing.Point(136, 16)
        Me.TxtNomArchNema.Name = "TxtNomArchNema"
        Me.TxtNomArchNema.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomArchNema.TabIndex = 29
        '
        'TxtNomProdArchivoNema
        '
        Me.TxtNomProdArchivoNema.Enabled = False
        Me.TxtNomProdArchivoNema.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNomProdArchivoNema.Location = New System.Drawing.Point(136, 48)
        Me.TxtNomProdArchivoNema.Name = "TxtNomProdArchivoNema"
        Me.TxtNomProdArchivoNema.Size = New System.Drawing.Size(264, 20)
        Me.TxtNomProdArchivoNema.TabIndex = 28
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.Location = New System.Drawing.Point(184, 80)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(168, 16)
        Me.Label54.TabIndex = 33
        Me.Label54.Text = "Para enviar un archivo creado"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.Button5.Location = New System.Drawing.Point(16, 32)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(32, 24)
        Me.Button5.TabIndex = 34
        Me.Button5.UseVisualStyleBackColor = False
        Me.Button5.Visible = False
        '
        'TxtOrdHasNema
        '
        Me.TxtOrdHasNema.Enabled = False
        Me.TxtOrdHasNema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdHasNema.Location = New System.Drawing.Point(620, 136)
        Me.TxtOrdHasNema.Name = "TxtOrdHasNema"
        Me.TxtOrdHasNema.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdHasNema.TabIndex = 56
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label55.Location = New System.Drawing.Point(516, 136)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(96, 16)
        Me.Label55.TabIndex = 61
        Me.Label55.Text = "N° Orden Hasta"
        '
        'CmdGeneraNema
        '
        Me.CmdGeneraNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdGeneraNema.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdGeneraNema.Image = Global.LabSys.My.Resources.Resources.accept
        Me.CmdGeneraNema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdGeneraNema.Location = New System.Drawing.Point(248, 256)
        Me.CmdGeneraNema.Name = "CmdGeneraNema"
        Me.CmdGeneraNema.Size = New System.Drawing.Size(120, 46)
        Me.CmdGeneraNema.TabIndex = 59
        Me.CmdGeneraNema.Text = "Generar"
        Me.CmdGeneraNema.UseVisualStyleBackColor = False
        '
        'CmdSalirNema
        '
        Me.CmdSalirNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdSalirNema.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSalirNema.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CmdSalirNema.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdSalirNema.Location = New System.Drawing.Point(688, 256)
        Me.CmdSalirNema.Name = "CmdSalirNema"
        Me.CmdSalirNema.Size = New System.Drawing.Size(120, 46)
        Me.CmdSalirNema.TabIndex = 57
        Me.CmdSalirNema.Text = "Salir"
        Me.CmdSalirNema.UseVisualStyleBackColor = False
        '
        'TxtLabDesNema
        '
        Me.TxtLabDesNema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabDesNema.Location = New System.Drawing.Point(388, 176)
        Me.TxtLabDesNema.Name = "TxtLabDesNema"
        Me.TxtLabDesNema.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabDesNema.TabIndex = 58
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.Location = New System.Drawing.Point(284, 176)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(88, 16)
        Me.Label56.TabIndex = 53
        Me.Label56.Text = "N° Lab. Desde"
        '
        'TxtOrdDesNema
        '
        Me.TxtOrdDesNema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOrdDesNema.Location = New System.Drawing.Point(388, 136)
        Me.TxtOrdDesNema.Name = "TxtOrdDesNema"
        Me.TxtOrdDesNema.Size = New System.Drawing.Size(72, 22)
        Me.TxtOrdDesNema.TabIndex = 55
        '
        'TxtLabHasNema
        '
        Me.TxtLabHasNema.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLabHasNema.Location = New System.Drawing.Point(620, 176)
        Me.TxtLabHasNema.Name = "TxtLabHasNema"
        Me.TxtLabHasNema.Size = New System.Drawing.Size(72, 22)
        Me.TxtLabHasNema.TabIndex = 60
        '
        'Label57
        '
        Me.Label57.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.Location = New System.Drawing.Point(284, 136)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(96, 16)
        Me.Label57.TabIndex = 52
        Me.Label57.Text = "N° Orden Desde"
        '
        'Label58
        '
        Me.Label58.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.Location = New System.Drawing.Point(516, 176)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(88, 16)
        Me.Label58.TabIndex = 54
        Me.Label58.Text = "N° Lab Hasta"
        '
        'CmdConsultaNema
        '
        Me.CmdConsultaNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdConsultaNema.Image = Global.LabSys.My.Resources.Resources.find
        Me.CmdConsultaNema.Location = New System.Drawing.Point(464, 136)
        Me.CmdConsultaNema.Name = "CmdConsultaNema"
        Me.CmdConsultaNema.Size = New System.Drawing.Size(24, 24)
        Me.CmdConsultaNema.TabIndex = 65
        Me.CmdConsultaNema.UseVisualStyleBackColor = False
        '
        'CmdBuscarOrdenNema
        '
        Me.CmdBuscarOrdenNema.BackColor = System.Drawing.Color.Transparent
        Me.CmdBuscarOrdenNema.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.CmdBuscarOrdenNema.Location = New System.Drawing.Point(496, 320)
        Me.CmdBuscarOrdenNema.Name = "CmdBuscarOrdenNema"
        Me.CmdBuscarOrdenNema.Size = New System.Drawing.Size(37, 35)
        Me.CmdBuscarOrdenNema.TabIndex = 62
        Me.CmdBuscarOrdenNema.UseVisualStyleBackColor = False
        '
        'Frm_Emision_Resultados
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1284, 986)
        Me.Controls.Add(Me.tbcFicha)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Frm_Emision_Resultados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Emisión de Resultados"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tbcFicha.ResumeLayout(False)
        Me.tabFoliar.ResumeLayout(False)
        Me.tabFoliar.PerformLayout()
        Me.GBEnvioArchivoFoliar.ResumeLayout(False)
        Me.GBEnvioArchivoFoliar.PerformLayout()
        Me.tabTejidos.ResumeLayout(False)
        Me.tabTejidos.PerformLayout()
        Me.GBEnvioArchivoTejidos.ResumeLayout(False)
        Me.GBEnvioArchivoTejidos.PerformLayout()
        Me.tabAgua.ResumeLayout(False)
        Me.tabAgua.PerformLayout()
        Me.GBEnvioArchivoAgua.ResumeLayout(False)
        Me.GBEnvioArchivoAgua.PerformLayout()
        Me.tabBactereologicos.ResumeLayout(False)
        Me.tabBactereologicos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.tabSueloFert.ResumeLayout(False)
        Me.tabSueloFert.PerformLayout()
        Me.GBEnvioArchivoSueloFer.ResumeLayout(False)
        Me.GBEnvioArchivoSueloFer.PerformLayout()
        Me.tabSuelo.ResumeLayout(False)
        Me.tabSuelo.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabFertQuimico.ResumeLayout(False)
        Me.tabFertQuimico.PerformLayout()
        Me.GBEnvioArchivoFertQui.ResumeLayout(False)
        Me.GBEnvioArchivoFertQui.PerformLayout()
        Me.tabFertOrganico.ResumeLayout(False)
        Me.tabFertOrganico.PerformLayout()
        Me.GBEnvioArchivoFertOrgFis.ResumeLayout(False)
        Me.GBEnvioArchivoFertOrgFis.PerformLayout()
        Me.tabOtros.ResumeLayout(False)
        Me.tabOtros.PerformLayout()
        Me.GBEnvioArchivoOtros.ResumeLayout(False)
        Me.GBEnvioArchivoOtros.PerformLayout()
        Me.tabNematodos.ResumeLayout(False)
        Me.tabNematodos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub TxtOrdDesFoliar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtOrdDesFoliar.KeyPress, TxtOrdDesTejidos.KeyPress, TxtOrdDesAgua.KeyPress, TxtOrdDesOtros.KeyPress, TxtOrdDesSueloFer.KeyPress, TxtOrdDesFertQui.KeyPress, TxtOrdDesSueloSal.KeyPress, TxtOrdDesFertOrgFis.KeyPress, TxtOrdDesColi.KeyPress, TxtOrdDesNema.KeyPress
        Dim query As String
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim regi As DataRow




        Dim con As New SqlConnection(Conexion1)
        Dim RecNo As Integer
        Select Case tbcFicha.SelectedTab.Name
            Case "tabFoliar"
                txtLabDes = TxtLabDesFoliar
                txtLabHas = TxtLabHasFoliar
                txtOrdDes = TxtOrdDesFoliar
                btGenera = CmdGeneraFoliar
                NOMTAB = 1000
            Case "tabTejidos"
                txtLabDes = TxtLabDesTejidos
                txtLabHas = TxtLabHasTejidos
                txtOrdDes = TxtOrdDesTejidos
                btGenera = CmdGeneraTejidos
                NOMTAB = 2000
            Case "tabAgua"
                txtLabDes = TxtLabDesAgua
                txtLabHas = TxtLabHasAgua
                txtOrdDes = TxtOrdDesAgua
                btGenera = CmdGeneraAgua
                NOMTAB = 3000
            Case "tabBactereologicos"
                txtLabDes = TxtLabDesColi
                txtLabHas = TxtLabHasColi
                txtOrdDes = TxtOrdDesColi
                btGenera = CmdGeneraColi
                NOMTAB = 3000
            Case "tabSuelo"
                txtLabDes = TxtLabDesSueloSal
                txtLabHas = TxtLabHasSueloSal
                txtOrdDes = TxtOrdDesSueloSal
                btGenera = CmdGeneraSueloSal
                NOMTAB = 4000
            Case "tabSueloFert"
                txtLabDes = TxtLabDesSueloFer
                txtLabHas = TxtLabHasSueloFer
                txtOrdDes = TxtOrdDesSueloFer
                btGenera = CmdGeneraSueloFer
                NOMTAB = 4000
            Case "tabFertQuimico"
                txtLabDes = TxtLabDesFertQui
                txtLabHas = TxtLabHasFertQui
                txtOrdDes = TxtOrdDesFertQui
                btGenera = CmdGeneraFertQui
                NOMTAB = 5000
            Case "tabFertOrganico"
                txtLabDes = TxtLabDesFertOrgFis
                txtLabHas = TxtLabHasFertOrgFis
                txtOrdDes = TxtOrdDesFertOrgFis
                btGenera = CmdGeneraFertOrgFis
                NOMTAB = 6000
            Case "tabOtros"
                txtLabDes = TxtLabDesOtros
                txtLabHas = TxtLabHasOtros
                txtOrdDes = TxtOrdDesOtros
                btGenera = CmdGeneraOtros
                NOMTAB = 7000
            Case "tabNematodos"
                txtLabDes = TxtLabDesNema
                txtLabHas = TxtLabHasNema
                txtOrdDes = TxtOrdDesNema
                btGenera = CmdGeneraNema
                NOMTAB = 8758
        End Select
        If e.KeyChar = Chr(13) Then
            txtLabDes.Text = ""
            txtLabHas.Text = ""

            With SP
                .Inicializar()
                .AgregarParametro("@OT", CInt(txtOrdDes.Text), SqlDbType.Int)
                .AgregarParametro("@TMU", NOMTAB, SqlDbType.Int)
                ds = .EjecutarQuery("ys_BuscaNlabDH")
            End With

            Dim i, maxim, grabaNumero As Integer
            grabaNumero = 0
            maxim = ds.Tables(0).Rows.Count
            Try
                For i = 0 To maxim - 1

                    If grabaNumero = 0 Then
                        txtLabDes.Text = ds.Tables(0).Rows(i).Item(0)
                    End If
                    txtLabHas.Text = ds.Tables(0).Rows(i).Item(1)
                    grabaNumero = grabaNumero + 1

                Next
            Catch ex As Exception
                MsgBox("ORDEN NO PERTENECE A LA MUESTRA")
                GoTo SaltoxMuestra
            End Try
          
            'con.Open()
            'query = "Select OTC_NLAB_DESDE,OTC_NLAB_HASTA FROM OT_CODIFICACION " & _
            '       "WHERE OT_NUMERO=" & CInt(txtOrdDes.Text) & " AND TMU_CODIGO=" & NOMTAB
            'Dim myCommand3 As New SqlCommand(query, con)
            'Dim myReader3 As SqlDataReader = myCommand3.ExecuteReader()
            'Do While True
            '    myReader3.Read()
            '    Try
            '        Try
            '            If RecNo = 0 Then
            '                txtLabDes.Text = myReader3.GetInt32(0)
            '            End If
            '            txtLabHas.Text = myReader3.GetInt32(1)
            '            RecNo = RecNo + 1
            '        Catch excep As Exception
            '            Exit Do
            '        End Try
            '    Catch ex As Exception
            '        MsgBox("ORDEN NO PERTENECE A LA MUESTRA")
            '        GoTo SaltoxMuestra
            '    End Try
            'Loop
            'myReader3.Close()
            'con.Close()
            Cjto_Tablas1.Tables("RANGO_DBF").Clear()
            Cjto_Tablas1.Tables("NLAB_COLUMNAS").Clear()
            Cjto_Tablas1.Tables("TABLA_CICLO").Clear()
            Cjto_Tablas1.Tables("ELEMENTO_PRIORIDAD").Clear()
            btGenera.Focus()
        End If
SaltoxMuestra:

    End Sub

    Private Sub TxtLabDesFoliar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLabDesFoliar.KeyPress
        If e.KeyChar = Chr(13) Then
            txtLabHas.Focus()
        End If
    End Sub

    Private Sub TxtLabHasFoliar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLabHasFoliar.KeyPress
        If e.KeyChar = Chr(13) Then
            btGenera.Focus()
        End If
    End Sub

    Sub estadoslbl(ByVal estadoG)
        Dim texto1, texto2 As String
        texto1 = "Generando Resultado ..."
        texto2 = "Resultado Generado!"

        If estadoG = "entra" Then

            CmdGeneraAgua.Enabled = False
            CmdGeneraSueloSal.Enabled = False
            CmdGeneraFoliar.Enabled = False
            CmdGeneraTejidos.Enabled = False
            CmdGeneraSueloFer.Enabled = False
            CmdGeneraOtros.Enabled = False
            CmdGeneraFertQui.Enabled = False
            CmdGeneraFertOrgFis.Enabled = False
            CmdGeneraSueloSal.Enabled = False
            CmdGeneraColi.Enabled = False
            CmdGeneraNema.Enabled = False

            Me.lbl_estadoFoliar.Visible = True
            Me.lbl_estadoTejidos.Visible = True
            Me.lbl_estadoAguas.Visible = True
            Me.lbl_estadoBacte.Visible = True
            Me.lbl_estadoSF.Visible = True
            Me.lbl_estadoSS.Visible = True
            Me.lbl_estadoFQ.Visible = True
            Me.lbl_estadoFO.Visible = True
            Me.lbl_estadoFito.Visible = True
            Me.lbl_estadoNem.Visible = True


            Me.lbl_estadoFoliar.Text = texto1
            Me.lbl_estadoTejidos.Text = texto1
            Me.lbl_estadoAguas.Text = texto1
            Me.lbl_estadoBacte.Text = texto1
            Me.lbl_estadoSF.Text = texto1
            Me.lbl_estadoSS.Text = texto1
            Me.lbl_estadoFQ.Text = texto1
            Me.lbl_estadoFO.Text = texto1
            Me.lbl_estadoFito.Text = texto1
            Me.lbl_estadoNem.Text = texto1


        ElseIf estadoG = "sale" Then

            CmdGeneraAgua.Enabled = True
            CmdGeneraSueloSal.Enabled = True
            CmdGeneraFoliar.Enabled = True
            CmdGeneraTejidos.Enabled = True
            CmdGeneraSueloFer.Enabled = True
            CmdGeneraOtros.Enabled = True
            CmdGeneraFertQui.Enabled = True
            CmdGeneraFertOrgFis.Enabled = True
            CmdGeneraSueloSal.Enabled = True
            CmdGeneraColi.Enabled = True
            CmdGeneraNema.Enabled = True

            Me.lbl_estadoFoliar.Text = texto2
            Me.lbl_estadoTejidos.Text = texto2
            Me.lbl_estadoAguas.Text = texto2
            Me.lbl_estadoBacte.Text = texto2
            Me.lbl_estadoSF.Text = texto2
            Me.lbl_estadoSS.Text = texto2
            Me.lbl_estadoFQ.Text = texto2
            Me.lbl_estadoFO.Text = texto2
            Me.lbl_estadoFito.Text = texto2
            Me.lbl_estadoNem.Text = texto2

            Me.lbl_estadoFoliar.Visible = False
            Me.lbl_estadoTejidos.Visible = False
            Me.lbl_estadoAguas.Visible = False
            Me.lbl_estadoBacte.Visible = False
            Me.lbl_estadoSF.Visible = False
            Me.lbl_estadoSS.Visible = False
            Me.lbl_estadoFQ.Visible = False
            Me.lbl_estadoFO.Visible = False
            Me.lbl_estadoFito.Visible = False
            Me.lbl_estadoNem.Visible = False

            

        End If

        




    End Sub
    Private Sub BTGeneraFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdGeneraSueloSal.Click, CmdGeneraFoliar.Click, CmdGeneraTejidos.Click, CmdGeneraAgua.Click, CmdGeneraSueloFer.Click, CmdGeneraOtros.Click, CmdGeneraFertQui.Click, CmdGeneraFertOrgFis.Click, CmdGeneraSueloSal.Click, CmdGeneraColi.Click, CmdGeneraNema.Click
        'Try
      

        estadoslbl("entra")

        Dim Fila_DigRes, Fila_EleDig, Fila_Ciclo_Rev, Fila_Elemento_Prioridad As DataRow
        Dim query, sMsg As String
        Dim nohay, EstadoOT, msgMatriz, EleTipo As String
        Dim con As New SqlConnection(Conexion1)
        Dim fila_ciclo As DataRow
        Dim OrdenDesde, OtNlab As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Select Case tbcFicha.SelectedTab.Name
            Case "tabFoliar"
                ' ***********************  Para Foliar  ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 1000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesFoliar.Text
                '************************ Fin Foliar **********************
            Case "tabTejidos"
                ' ***********************  Para tejidos  ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 2000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesTejidos.Text

                '************************ Fin tejidos **********************
            Case "tabAgua"
                ' ***********************  Para agua  ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 3000
                Maximo_columnas = 3
                OrdenDesde = TxtOrdDesAgua.Text

                '************************ Fin agua **********************
            Case "tabBactereologicos"
                ' ***********************  Para agua  ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 3600
                Maximo_columnas = 3
                OrdenDesde = TxtOrdDesColi.Text

                '************************ Fin agua **********************
            Case "tabSueloFert"
                ' ***********************  Para Suelo Fertilidad ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 4000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesSueloFer.Text

                '************************ Fin Suelo Fertilidad **********************
            Case "tabSuelo"
                ' ***********************  Para Suelo Salinidad ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 4500
                Maximo_columnas = 4
                Try
                    OrdenDesde = TxtOrdDesSueloSal.Text
                Catch ex As Exception
                    GoTo nohaynada
                End Try

                '************************ Fin Suelo Salinidad **********************
            Case "tabFertQuimico"
                ' ***********************  Para Fertilidad Quimica ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 5000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesFertQui.Text

                '************************ Fin Fertilidad Quimica **********************
            Case "tabFertOrganico"
                ' ***********************  Para Fertilidad Organica ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 6000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesFertOrgFis.Text

            Case "tabOtros"
                ' ***********************  Para Otros analisis ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 7000
                Maximo_columnas = 4
                '************************ Fin Otros analisis **********************
            Case "tabNematodos"
                ' ***********************  Para Otros analisis ******************************* 
                ' Lo identifica via pestaña
                NOMTAB = 8000
                Maximo_columnas = 4
                OrdenDesde = TxtOrdDesNema.Text

                '************************ Fin Otros analisis **********************

        End Select

        Cjto_Tablas1.Tables("RANGO_DBF").Clear()
        Cjto_Tablas1.Tables("NLAB_COLUMNAS").Clear()
        Cjto_Tablas1.Tables("TABLA_CICLO").Clear()
        Cjto_Tablas1.Tables("ELEMENTO_PRIORIDAD").Clear()

        Cjto_Tablas1.Tables("TABLA_ELEDIG").Clear()
        Cjto_Tablas1.Tables("TABLA_DIGRES").Clear()
        Cjto_Resultados1.Tables("TABLA_DIGRES2").Clear()
        Cjto_Resultados1.Tables("ANALISIS_ELEMENTOS").Clear()
        Cjto_Resultados1.Tables("ANALISIS_ELE").Clear()

        Call Genera_Tabla_EleDig()

        For Each Fila_EleDig In Cjto_Tablas1.Tables("TABLA_ELEDIG").Rows

            If Fila_EleDig("ELE_PROCESO") = "Autogenerado" Then

            End If
            frmEsp.Refresh()
            'If Fila_EleDig("ELE_CODIGO") = "%Piedra" Then GoTo SaltoxPiedra
            If Fila_EleDig("ELE_ESTADO") <> "Re" And Fila_EleDig("ELE_ESTADO") <> "Nula" And Fila_EleDig("ELE_ESTADO") <> "DuRe" And Fila_EleDig("ELE_ESTADO") <> "ReOt" Then
                sMsg = sMsg + Fila_EleDig("ELE_CODIGO") + ", "
            End If
        Next

        If NOMTAB = 4000 Or NOMTAB = 4500 Then
            msgMatriz = ""
            For Each Fila_EleDig In Cjto_Tablas1.Tables("TABLA_ELEDIG").Rows
                If IsDBNull(Fila_EleDig("ELE_TIPO_M")) = False Then
                    If Fila_EleDig("ELE_TIPO_M") = "SA " And NOMTAB = 4500 Then
                        msgMatriz = "*"
                        Exit For
                    End If
                    If Fila_EleDig("ELE_TIPO_M") = "FE " And NOMTAB = 4000 Then
                        msgMatriz = "*"
                        Exit For
                    End If
                End If
            Next
            If msgMatriz = "" Then MsgBox("Orden no pertenece a Matriz") : GoTo nohaynada
        End If


        'If Len(sMsg) <> 0 Then
        '    sMsg = Mid(sMsg, 1, Len(sMsg) - 2)
        '    MsgBox("Estado para elementos " & sMsg & " EstadoOT = Dex")
        'End If


        Call Genera_Tabla_DigRes()
        'EstadoOT = "xDe"

        Call Busca_Datos_orden(OrdenDesde)
        Call Genera_Tabla_Ciclo_Resultados()

        msgMatriz = ""

        For Each Fila_Ciclo_Rev In Cjto_Tablas1.Tables("TABLA_CICLO").Rows
            OtNlab = Fila_Ciclo_Rev("OT_NLAB")
            msgMatriz = "*"
            Exit For
        Next

        If msgMatriz = "" Then MsgBox("Orden no pertenece a Matriz") : GoTo nohaynada

        Call Genera_Tabla_Elementos_Prioridad_Rango()


        Call Genera_Impresion(Maximo_columnas)
        Call Graba_Estado_OT(OrdenDesde)

nohaynada:
        frmEsp.Dispose()
        frmEsp.Close()

        Orden_Trabajo = OrdenDesde
        Call LimpiaText()

        estadoslbl("sale")
       
        'Me.Close()

        'Catch ex As Exception

        ' End Try

    End Sub
    Private Sub LimpiaText()
        TxtOrdDesFoliar.Text = ""
        TxtLabDesFoliar.Text = ""
        TxtLabHasFoliar.Text = ""

        TxtOrdDesTejidos.Text = ""
        TxtLabDesTejidos.Text = ""
        TxtLabHasTejidos.Text = ""

        TxtOrdDesAgua.Text = ""
        TxtLabDesAgua.Text = ""
        TxtLabHasAgua.Text = ""

        TxtOrdDesSueloFer.Text = ""
        TxtLabDesSueloFer.Text = ""
        TxtLabHasSueloFer.Text = ""

        TxtOrdDesSueloSal.Text = ""
        TxtLabDesSueloSal.Text = ""
        TxtLabHasSueloSal.Text = ""

        TxtOrdDesFertOrgFis.Text = ""
        TxtLabDesFertOrgFis.Text = ""
        TxtLabHasFertOrgFis.Text = ""

        TxtOrdDesFertQui.Text = ""
        TxtLabDesFertQui.Text = ""
        TxtLabHasFertQui.Text = ""

        TxtOrdDesColi.Text = ""
        TxtLabDesColi.Text = ""
        TxtLabHasColi.Text = ""

        TxtOrdDesNema.Text = ""
        TxtLabDesNema.Text = ""
        TxtLabHasNema.Text = ""

        TxtOrdDesOtros.Text = ""
        TxtLabDesOtros.Text = ""
        TxtLabHasOtros.Text = ""
    End Sub
    Private Sub Graba_Estado_OT(ByVal OrdenDesde As Integer)
        Dim SP1 As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim SP2 As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim estado As String


        With SP1
            .Inicializar()
            .AgregarParametro("@NumOt", OrdenDesde, SqlDbType.Int)
            ds = .EjecutarQuery("ys_BuscaEstadoOT")
        End With

        estado = ds.Tables(0).Rows(0).Item("OT_ESTADO_ANA")

        If estado = "De" Then
            If MsgBox("¿La Orden " & OrdenDesde & " tiene como estado " & estado & ", desea reemplazarlo por (xDe)?", MsgBoxStyle.YesNo, "Cambiando Estado ...") = MsgBoxResult.Yes Then
                With SP2
                    .Inicializar()
                    .AgregarParametro("@NumOt", OrdenDesde, SqlDbType.Int)
                    .AgregarParametro("@EstadoOt", "xDe", SqlDbType.NVarChar)
                    .EjecutarQuery("usp_UpdateEstadoOT")
                End With
            Else
                MsgBox("Se ha mantenido el estado anterior correctamente!")
            End If
        Else
            With SP2
                .Inicializar()
                .AgregarParametro("@NumOt", OrdenDesde, SqlDbType.Int)
                .AgregarParametro("@EstadoOt", "xDe", SqlDbType.NVarChar)
                .EjecutarQuery("usp_UpdateEstadoOT")
            End With
        End If

    End Sub

    Private Sub Busca_Datos_orden(ByVal OrdenDesde As Integer)
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        With SP
            .Inicializar()
            .AgregarParametro("@NumOt", OrdenDesde, SqlDbType.Int)
            ds = .EjecutarQuery("usp_SelectOrden")
        End With

        Try
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_FECHA_ORDEN")) = False Then
                GFechaIngreso = ds.Tables(0).Rows(0).Item("OT_FECHA_ORDEN")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR")) = False Then
                GProductor = ds.Tables(0).Rows(0).Item("PRO_PRODUCTOR")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_EMPRESA")) = False Then
                GEmpresa = ds.Tables(0).Rows(0).Item("OT_EMPRESA")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_REMITE")) = False Then
                GRemite = ds.Tables(0).Rows(0).Item("OT_REMITE")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_COMUNA")) = False Then
                GProvincia = ds.Tables(0).Rows(0).Item("OT_COMUNA")
            End If
            If IsDBNull(ds.Tables(0).Rows(0).Item("OT_PROVINCIA")) = False Then
                GComuna = ds.Tables(0).Rows(0).Item("OT_PROVINCIA")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Genera_Impresion(ByVal Maximo_columnas As Integer)

        If NOMTAB = 1000 Then Genera_Impresion_Foliar(CInt(TxtOrdDesFoliar.Text), CInt(TxtLabDesFoliar.Text), CInt(TxtLabHasFoliar.Text))
        If NOMTAB = 2000 Then Genera_Impresion_Tejidos(ChkTransSecFre.Checked, CInt(txtOrdDes.Text), CInt(txtLabDes.Text), CInt(txtLabHas.Text))
        If NOMTAB = 3000 Then Genera_Impresion_Agua(CInt(TxtOrdDesAgua.Text), CInt(TxtLabDesAgua.Text), CInt(TxtLabHasAgua.Text))
        If NOMTAB = 3600 Then Genera_Impresion_Bactereologicos(CInt(TxtOrdDesColi.Text), CInt(TxtLabDesColi.Text), CInt(TxtLabHasColi.Text))
        If NOMTAB = 4000 Then Genera_Impresion_SueloFert(CInt(TxtOrdDesSueloFer.Text), CInt(TxtLabDesSueloFer.Text), CInt(TxtLabHasSueloFer.Text))
        If NOMTAB = 4500 Then Genera_Impresion_SueloSal(CInt(TxtOrdDesSueloSal.Text), CInt(TxtLabDesSueloSal.Text), CInt(TxtLabHasSueloSal.Text))
        If NOMTAB = 5000 Then Genera_Impresion_FertQuimico(CInt(TxtOrdDesFertQui.Text), CInt(TxtLabDesFertQui.Text), CInt(TxtLabHasFertQui.Text))
        If NOMTAB = 6000 Then Genera_Impresion_FertOrganico(CInt(TxtOrdDesFertOrgFis.Text), CInt(TxtLabDesFertOrgFis.Text), CInt(TxtLabHasFertOrgFis.Text))
        If NOMTAB = 8000 Then Genera_Impresion_Nematodos(CInt(TxtOrdDesNema.Text), CInt(TxtLabDesNema.Text), CInt(TxtLabHasNema.Text))
        'If NOMTAB = 6500 Then Genera_Impresion_FertOrgFis(CInt(txtOrdDesFertOrgFis.Text), CInt(txtLabDesFertOrgFis.Text), CInt(txtLabHasFertOrgFis.Text))
        'If NOMTAB = 7000 Then Genera_Impresion_Foliar(CInt(txtOrdDes.Text), CInt(txtLabDes.Text), CInt(txtLabHas.Text))
        'If NOMTAB = 8000 Then Genera_Impresion_Foliar(CInt(txtOrdDes.Text), CInt(txtLabDes.Text), CInt(txtLabHas.Text))

        '        Dim Fila_Ciclo, Fila_Identifica, Fila_Identifica2, Fila_SubTit, Fila_Seleccion As DataRow
        '        Dim MATRIZ_AUX(9), fuente, destino, PRO As String
        '        Dim SALTO_PAGINA, Ciclo_Inicial, Revisa_Filas As Boolean
        '        Dim fecha_informe As Date, sAño, sRutaDest As String
        '        Dim BuscaEle(0) As Object

        '        Dim Con1 As New SqlConnection(Conexion1)
        '        Dim Con2 As New SqlConnection(Conexion1)
        '        Dim Query1, Query2 As String

        '        Dim objLibroExcel As Excel.Workbook
        '        Dim m_Excel As Excel.Application
        '        Dim Hoja_Excel As Excel.Worksheet
        '        Dim Fila_Ini, Fila_Fin, pagina, Fila, Cuenta_Columnas, Cuantas_Filas As Integer
        '        frmEsp.Refresh()
        '        fuente = "D:\Prueba Resultado\Formatos Resultados.xls"
        '        fuente = "F:\Mis documentos\LabSys-Pruebas\Formatos Bases\Formatos Resultados.xls"
        '        NLAD = txtLabDes.Text
        '        NLAH = " - " & Mid(CStr(txtLabHas.Text), Len(txtLabHas.Text) - 4)
        '        NLAH = " - " & Microsoft.VisualBasic.Right(CStr(txtLabHas.Text), 3)
        '        If txtLabDes.Text = txtLabHas.Text Then NLAH = ""
        '        PRO = GProductor
        '        NOMBRE_PROD = GProductor
        '        sAño = CStr(Year(Now))
        '        If NOMTAB = 1000 Then destino = "D:\Prueba Resultado\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 1000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Foliar-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 2000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Frutos-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 3000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Agua-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 4000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".Suelo-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 5000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".FertOrg-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = 6000 Then sRutaDest = "F:\Mis Documentos\LabSys-Pruebas\" + sAño + ".FertQui-Labsys" : destino = sRutaDest & "\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = "MAGU" Then destino = "F:\Mis Documentos\2005.Agua-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If NOMTAB = "MNEM" Then destino = "F:\Mis Documentos\Labsys prueba 2005.Nematodos-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"
        '        If Dir(sRutaDest, FileAttribute.Directory) = "" Then
        '            MkDir(sRutaDest)
        '        End If
        '        m_Excel = CreateObject("EXCEL.APPLICATION")
        '        FileCopy(fuente, destino)
        '        objLibroExcel = m_Excel.Workbooks.Open(destino)
        '        m_Excel.Visible = True 'Dejar en Falso
        '        Hoja_Excel = objLibroExcel.Worksheets(1)
        '        Hoja_Excel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        '        Hoja_Excel.Activate()
        '        Fila = Fila + 1
        '        pagina = 1
        '        Ciclo_Inicial = True
        '        R1 = True ': R2 = True
        '        Revisa_Filas = False
        '        Cuantas_Filas = 0
        '        Cuenta_Columnas = 0
        '        Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Clear()
        '        Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Clear()
        '        Try
        '            For Each Fila_Ciclo In Cjto_Tablas1.Tables("TABLA_CICLO").Rows
        '                Cuenta_Columnas = Cuenta_Columnas + 1

        '                Call Revisa_Salto_Por_Encabezado(Fila_Ciclo, SALTO_PAGINA, NOMTAB)
        '                Call Cuenta_Filas_Notas(Cuantas_Filas)
        '                If Ciclo_Inicial = True Then Ciclo_Inicial = False : GoTo SaltoxCicloInicial
        '                If SALTO_PAGINA = True Or Cuenta_Columnas > Maximo_columnas Then
        '                    Call Coloca_Columnas_Foliar(Cuenta_Columnas)
        '                    fecha_informe = Today
        '                    Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, R1, R2, NOMTAB, fecha_informe, Fila_Firma)
        '                    Fila_Ini = Fila
        '                    Call Imprime_Detalle(Hoja_Excel, Fila)
        '                    Fila_Fin = Fila - 1
        '                    Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin, NOMTAB)
        '                    Revisa_Filas = True
        '                    pagina = pagina + 1
        '                    Cuenta_Columnas = 1
        '                    Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Clear()
        '                    Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Clear()
        '                End If
        'SaltoxCicloInicial:
        '                Fila_Identifica = Cjto_Tablas1.Tables("NLAB_COLUMNAS").NewRow
        '                Fila_Identifica.Item("OT_NLAB") = Fila_Ciclo("OT_NLAB")
        '                Fila_Identifica.Item("COLUMNAD") = ""
        '                Fila_Identifica.Item("COLUMNAH") = ""
        '                Fila_Identifica2 = Cjto_Resultados1.Tables("NLAB_COLUMNAS").NewRow
        '                Fila_Identifica2.Item("OT_NLAB") = Fila_Ciclo("OT_NLAB")
        '                Fila_Identifica2.Item("COLUMNAD_ENT") = ""
        '                Fila_Identifica2.Item("COLUMNAH_ENT") = ""
        '                Fila_Identifica2.Item("COLUMNA_COMA") = ""
        '                Fila_Identifica2.Item("COLUMNAD_DEC") = ""
        '                Fila_Identifica2.Item("COLUMNAH_DEC") = ""
        '                Try
        '                    Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica)
        '                    Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows.Add(Fila_Identifica2)
        '                Catch ex As Exception
        '                End Try
        '                SALTO_PAGINA = False
        '            Next

        '            Call Coloca_Columnas_Foliar(Cuenta_Columnas)
        '            fecha_informe = Today
        '            *** Condición para R2 ***
        '            Query1 = "SELECT OT_NLAB, ELE_CODIGO, ELE_ESTADO, ANA_CODIGO FROM DIGITA_RESULTADOS " & _
        '             "WHERE OT_NUMERO=" & CInt(txtOrdDes.Text) & " AND TMU_CODIGO=" & NOMTAB
        '            Try
        '                BuscaEle(0) = NOMTAB
        '                Con1.Open()
        '                Dim myCommand1 As New SqlCommand(Query1, Con1)
        '                Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        '                myReader1.Read()
        '                BuscaEle(0) = myReader1.GetDouble(3)
        '                BuscaEle(2) = myReader1.GetString(1)
        '                Fila_Seleccion = Cjto_Resultados1.Tables("ANALISIS_ELE").Rows.Find(BuscaEle)
        '                myReader1.Close()
        '                Con1.Close()
        '                If IsDBNull(Fila_Seleccion("ANA_ANALISIS")) = False Then
        '                    If NOMTAB = 1000 Then
        '                        * CATEGÓRICO!!
        '                        R2 = True
        '                    End If
        '                    If NOMTAB = 2000 Then
        '                        * CATEGÓRICO!!
        '                        R2 = False
        '                    End If
        '                    If NOMTAB = 3000 Then
        '                        R2 = True
        '                    End If
        '                    If NOMTAB = 4000 Then
        '                        Select Case Fila_Seleccion("ANA_ANALISIS")
        '                            Case "Fertilidad"
        '                                R2 = False
        '                            Case "Salinidad"
        '                                R2 = True
        '                            Case Else
        '                                R2 = False
        '                        End Select
        '                    End If
        '                    If NOMTAB = 5000 Then
        '                        R2 = True
        '                    End If
        '                    If NOMTAB = 6000 Then
        '                        R2 = True
        '                    End If
        '                    If NOMTAB = 7000 Then
        '                        R2 = False
        '                    End If
        '                End If
        '            Catch ex As Exception
        '                MsgBox(ex.ToString)
        '            End Try
        '            *************************
        '            Call Imprime_Encabezado(Hoja_Excel, pagina, Fila, R1, R2, NOMTAB, fecha_informe, Fila_Firma)
        '            Fila_Ini = Fila
        '            Call Imprime_Detalle(Hoja_Excel, Fila)
        '            Fila_Fin = Fila - 1
        '            Call Imprime_Marco(Hoja_Excel, Fila_Ini, Fila_Fin, NOMTAB)
        '            Call Me.Imprime_Firmas(Hoja_Excel, Fila_Firma)

        '            Call IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina)
        '            m_Excel.Visible = True
        '            Hoja_Excel.PrintPreview()
        '            objLibroExcel.Save()
        '            objLibroExcel.Close()
        '        Catch ex As Exception
        '            MsgBox("Primero debe generar el archivo")
        '        End Try
    End Sub

    Private Sub Imprime_Marco(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal Fila_Ini As Integer, ByVal Fila_Fin As Integer, ByVal NOMTAB As Integer)
        If NOMTAB = 1000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
            HOJA_EXCEL.Range("CT" & (Fila_Ini - 5).ToString & ":DF" & (Fila_Fin).ToString).Interior.Color = RGB(175, 238, 238)
            HOJA_EXCEL.Range("CT" & (Fila_Ini - 5).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
            Call Me.Notas_Automaticas(MATRIZ_AUX(2), HOJA_EXCEL, Fila_Fin)
        End If

        If NOMTAB = 2000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini - 1).ToString & ":DF" & (Fila_Fin + 1).ToString).BorderAround()
            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
        End If

        If NOMTAB = 3000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
        End If

        If NOMTAB = 4000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
            'Hoja_Excel.Range("CT" & (Fila_Ini - 5).ToString & ":DF" & (Fila_Fin).ToString).Interior.Color = RGB(175, 238, 238)
            'Hoja_Excel.Range("CT" & (Fila_Ini - 5).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
            'Call Me.Notas_Automaticas(MATRIZ_AUX(2), Hoja_Excel, Fila_Fin)
        End If

        If NOMTAB = 5000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
        End If

        If NOMTAB = 6000 Then
            HOJA_EXCEL.Range("A" & (Fila_Ini).ToString & ":DF" & (Fila_Fin).ToString).BorderAround()
        End If
    End Sub

    Private Sub Imprime_Detalle(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef Fila As Integer)
        Dim Fila_DigRes, Fila_Elemento, Fila_Nlab, Fila_Rango, Fila_SubTit As DataRow
        Dim Encontro As Boolean
        Dim BusDig(1), BusRango(2) As Object
        Dim COLD, COLH, Masd, Mascara, sQuery, sSubTit_Comp As String
        Dim COLD_ENT, COLH_ENT, COL_COMA, COLD_DEC, COLH_DEC As String
        Dim peq, CDecimales, Fila_Ini As Integer
        Dim Resultado As Double

        Masd = "0000"
        sSubTit_Comp = ""
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            Fila = Fila + 1
        End If
        Fila_Ini = Fila
        peq = 1

        For Each Fila_Elemento In Cjto_Tablas1.Tables("ELEMENTO_PRIORIDAD").Rows
            Encontro = False
            For Each Fila_Nlab In Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows
                'COLD = Fila_Nlab("COLUMNAD")
                'COLH = Fila_Nlab("COLUMNAH")
                COLD_ENT = Fila_Nlab("COLUMNAD_ENT")
                COLH_ENT = Fila_Nlab("COLUMNAH_ENT")
                COL_COMA = Fila_Nlab("COLUMNA_COMA")
                COLD_DEC = Fila_Nlab("COLUMNAD_DEC")
                COLH_DEC = Fila_Nlab("COLUMNAH_DEC")
                BusDig(0) = Fila_Nlab("OT_NLAB")
                BusDig(1) = Fila_Elemento("ELE_CODIGO")
                Fila_DigRes = Cjto_Tablas1.Tables("TABLA_DIGRES").Rows.Find(BusDig)
                If (Fila_DigRes Is Nothing) = False Then
                    '****************************
                    If NOMTAB = 3000 Or NOMTAB = 4000 Or NOMTAB = 5000 Or NOMTAB = 6000 Then
                        'Fila_SubTit = Cjto_Tablas1.Tables("ANALISIS_ELEMENTOS").Rows.Find(key)
                        If IsDBNull(Fila_Elemento("ELE_SUBTITULO_RES")) = False And sSubTit_Comp <> Fila_Elemento("ELE_SUBTITULO_RES") Then
                            sSubTit_Comp = Fila_Elemento("ELE_SUBTITULO_RES")
                            HOJA_EXCEL.Range("A" & Fila.ToString).Value = Fila_Elemento("ELE_SUBTITULO_RES")
                            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 9
                            HOJA_EXCEL.Range("A" & Fila.ToString).Font.Bold = True
                            Fila = Fila + 1
                        End If
                    End If
                    '****************************
                    If peq <> Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1) Then Fila = Fila + 1 : peq = Mid(Fila_Elemento("ELE_PRIORIDAD"), 1, 1)
                    HOJA_EXCEL.Range("A" & Fila.ToString & ":R" & Fila.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Fila.ToString).Value = Fila_Elemento("ELE_NOMBRE")
                    HOJA_EXCEL.Range("A" & Fila.ToString).Font.Size = 8
                    If IsDBNull(Fila_Elemento("ELE_SIMBOLO")) = False Or Fila_Elemento("ELE_SIMBOLO") <> "" Then
                        HOJA_EXCEL.Range("S" & Fila.ToString & ":Y" & Fila.ToString).Merge()
                        HOJA_EXCEL.Range("S" & Fila.ToString).Value = "(" & Fila_Elemento("ELE_SIMBOLO") & ")"
                        HOJA_EXCEL.Range("S" & Fila.ToString).Font.Size = 8
                        HOJA_EXCEL.Range("S" & Fila.ToString & ":Y" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    End If
                    If IsDBNull(Fila_Elemento("ELE_UNIDAD")) = False Or Fila_Elemento("ELE_UNIDAD") <> "" Then
                        HOJA_EXCEL.Range("AA" & Fila.ToString & ":AD" & Fila.ToString).Merge()
                        HOJA_EXCEL.Range("AA" & Fila.ToString).Value = "'" & Fila_Elemento("ELE_UNIDAD")
                        HOJA_EXCEL.Range("AA" & Fila.ToString).Font.Size = 7
                        HOJA_EXCEL.Range("AA" & Fila.ToString & ":AD" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    End If
                    'If IsDBNull(Fila_DigRes("DIGRES_RESULTADO")) = False Then
                    '    HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).Merge()
                    '    HOJA_EXCEL.Range(COLD & Fila.ToString).Value = Fila_DigRes("DIGRES_RESULTADO")
                    '    HOJA_EXCEL.Range(COLD & Fila.ToString).Font.Size = 9
                    '    'HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                    '    HOJA_EXCEL.Range(COLD & Fila.ToString & ":" & COLH & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignDistributed
                    '    CDecimales = Cantidad_Decimales(Fila_Elemento("ELE_MASCARA"), Fila_DigRes("DIGRES_RESULTADO"))
                    '    If CDecimales > 0 Then Mascara = "####0" & "," & Mid(Masd, 1, CDecimales) Else Mascara = "####0"
                    '    HOJA_EXCEL.Range(COLD & Fila.ToString).NumberFormat = Mascara
                    'End If
                    If IsDBNull(Fila_DigRes("DIGRES_RESULTADO")) = False Then
                        Resultado = Fila_DigRes("DIGRES_RESULTADO")
                        HOJA_EXCEL.Range(COLD_ENT & Fila.ToString & ":" & COLH_ENT & Fila.ToString).Merge()
                        HOJA_EXCEL.Range(COLD_ENT & Fila.ToString).Value = Int(Resultado)
                        HOJA_EXCEL.Range(COLD_ENT & Fila.ToString).Font.Size = 9
                        HOJA_EXCEL.Range(COLD_ENT & Fila.ToString & ":" & COLH_ENT & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        CDecimales = Cantidad_Decimales(Fila_Elemento("ELE_MASCARA"), Fila_DigRes("DIGRES_RESULTADO"))
                        If CDecimales > 0 Then
                            'HOJA_EXCEL.Range(COL_COMA & Fila.ToString).Value = ","
                            'HOJA_EXCEL.Range(COL_COMA & Fila.ToString).Font.Size = 9
                            'Mascara = "####0" & "," & Mid(Masd, 1, CDecimales)
                            Mascara = "'," & CStr(Int((Resultado - Int(Resultado)) * 10 ^ CDecimales))
                            HOJA_EXCEL.Range(COL_COMA & Fila.ToString & ":" & COLH_DEC & Fila.ToString).Merge()
                            HOJA_EXCEL.Range(COL_COMA & Fila.ToString).Value = Mascara
                            HOJA_EXCEL.Range(COL_COMA & Fila.ToString).Font.Size = 9
                            HOJA_EXCEL.Range(COL_COMA & Fila.ToString & ":" & COLH_DEC & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                            'Else
                            '    '    Mascara = "####0"
                            '    HOJA_EXCEL.Range(COLD_ENT & Fila.ToString & ":" & COLH_ENT & Fila.ToString).Merge()
                            '    HOJA_EXCEL.Range(COLD_ENT & Fila.ToString).Value = Int(Resultado)
                            '    HOJA_EXCEL.Range(COLD_ENT & Fila.ToString).Font.Size = 9
                            '    HOJA_EXCEL.Range(COLD_ENT & Fila.ToString & ":" & COLH_ENT & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                        End If
                        'If CDecimales > 0 Then Mascara = "####0" & "," & Mid(Masd, 1, CDecimales) Else Mascara = "####0"
                        'HOJA_EXCEL.Range(COLD & Fila.ToString).NumberFormat = Mascara
                    End If
                    'R2 = True
                    If R2 = True Then
                        BusRango(0) = NOMTAB
                        BusRango(1) = MATRIZ_AUX(2)
                        BusRango(2) = Fila_Elemento("ELE_CODIGO")
                        Fila_Rango = Cjto_Tablas1.Tables("RANGO_DBF").Rows.Find(BusRango)
                        If (Fila_Rango Is Nothing) = False Then
                            HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).Merge()
                            If Trim(Fila_Elemento("ELE_UNIDAD")) <> "ppm" Then HOJA_EXCEL.Range("CT" & Fila.ToString).NumberFormat = "#0,00"
                            HOJA_EXCEL.Range("CT" & Fila.ToString).Value = Fila_Rango("RANGO_DESDE")
                            HOJA_EXCEL.Range("CT" & Fila.ToString).Font.Size = 9
                            HOJA_EXCEL.Range("CT" & Fila.ToString & ":CY" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            'HOJA_EXCEL.Range("CV" & filELE.ToString & ":CZ" & filELE.ToString).NumberFormat = "General"

                            HOJA_EXCEL.Range("CZ" & Fila.ToString).Value = Fila_Rango("SIMBOLO")
                            HOJA_EXCEL.Range("CZ" & Fila.ToString).Font.Size = 9
                            HOJA_EXCEL.Range("CZ" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                            HOJA_EXCEL.Range("DA" & Fila.ToString & ":DF" & Fila.ToString).Merge()
                            HOJA_EXCEL.Range("DA" & Fila.ToString).Value = Fila_Rango("RANGO_HASTA")
                            HOJA_EXCEL.Range("DA" & Fila.ToString).Font.Size = 9
                            HOJA_EXCEL.Range("DA" & Fila.ToString & ":DF" & Fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            'HOJA_EXCEL.Range("DB" & filELE.ToString & ":DF" & filELE.ToString).NumberFormat = "General"
                        End If
                    End If
                    Encontro = True
                End If
            Next
            If Encontro Then
                Fila = Fila + 1
            End If
        Next
        'HOJA_EXCEL.Range("A" & (Fila_Ini + 1).ToString & ":DF" & (Fila).ToString).BorderAround()
        If NOMTAB <> 4000 Then
            If R2 = True Then
                HOJA_EXCEL.Range("CT" & (Fila_Ini - 6).ToString & ":DF" & (Fila).ToString).Interior.Color = RGB(175, 238, 238)
                HOJA_EXCEL.Range("CT" & (Fila_Ini - 6).ToString & ":DF" & (Fila).ToString).BorderAround()
            End If
        Else
            If R2 = True Then
                HOJA_EXCEL.Range("CS" & (Fila_Ini - 6).ToString & ":DF" & (Fila - 3).ToString).Interior.Color = RGB(175, 238, 238)
                HOJA_EXCEL.Range("CS" & (Fila_Ini - 5).ToString & ":DF" & (Fila).ToString).Interior.Color = RGB(175, 238, 238)
                HOJA_EXCEL.Range("CS" & (Fila_Ini - 6).ToString & ":DF" & (Fila - 3).ToString).BorderAround()
                HOJA_EXCEL.Range("CS" & (Fila_Ini - 5).ToString & ":DF" & (Fila).ToString).BorderAround()
            End If
        End If

        Fila = Fila + 1
        Call Me.Notas_Automaticas(MATRIZ_AUX(2), HOJA_EXCEL, Fila)
        '        Call Me.Imprime_Firmas(HOJA_EXCEL, Fila_Firma)
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

    Private Sub Coloca_Columnas_Foliar(ByVal cuenord As Integer)
        Dim FILA_REC, FILA_REC2 As DataRow
        Dim CUFI As Integer = 1
        For Each FILA_REC In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            If NOMTAB = 1000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 2000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 3000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 4000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 5000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 6000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 2
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC("COLUMNAD") = "AG"
                            FILA_REC("COLUMNAH") = "AV"
                        Case 2
                            FILA_REC("COLUMNAD") = "AW"
                            FILA_REC("COLUMNAH") = "BL"
                        Case 3
                            FILA_REC("COLUMNAD") = "BM"
                            FILA_REC("COLUMNAH") = "CB"
                        Case 4
                            FILA_REC("COLUMNAD") = "CC"
                            FILA_REC("COLUMNAH") = "CR"
                    End Select
                End If
            End If
            CUFI = CUFI + 1
        Next
        CUFI = 1
        For Each FILA_REC2 In Cjto_Resultados1.Tables("NLAB_COLUMNAS").Rows
            If NOMTAB = 1000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 2000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 3000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 4000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 5000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            If NOMTAB = 6000 Then
                If cuenord < 3 Then
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                    End Select
                Else
                    Select Case CUFI
                        Case 1
                            FILA_REC2("COLUMNAD_ENT") = "AG"
                            FILA_REC2("COLUMNAH_ENT") = "AM"
                            FILA_REC2("COLUMNA_COMA") = "AN"
                            FILA_REC2("COLUMNAD_DEC") = "AO"
                            FILA_REC2("COLUMNAH_DEC") = "AV"
                        Case 2
                            FILA_REC2("COLUMNAD_ENT") = "AW"
                            FILA_REC2("COLUMNAH_ENT") = "BC"
                            FILA_REC2("COLUMNA_COMA") = "BD"
                            FILA_REC2("COLUMNAD_DEC") = "BE"
                            FILA_REC2("COLUMNAH_DEC") = "BL"
                        Case 3
                            FILA_REC2("COLUMNAD_ENT") = "BM"
                            FILA_REC2("COLUMNAH_ENT") = "BS"
                            FILA_REC2("COLUMNA_COMA") = "BT"
                            FILA_REC2("COLUMNAD_DEC") = "BU"
                            FILA_REC2("COLUMNAH_DEC") = "CB"
                        Case 4
                            FILA_REC2("COLUMNAD_ENT") = "CC"
                            FILA_REC2("COLUMNAH_ENT") = "CI"
                            FILA_REC2("COLUMNA_COMA") = "CJ"
                            FILA_REC2("COLUMNAD_DEC") = "CK"
                            FILA_REC2("COLUMNAH_DEC") = "CR"
                    End Select
                End If
            End If
            CUFI = CUFI + 1
        Next
    End Sub
    Private Sub Imprime_Firmas(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila_firma As Integer)
        'If RBFirmaAmbos.Checked = True Then
        '    HOJA_EXCEL.Range("G" & fila_firma.ToString & ":BF" & fila_firma.ToString).Merge()
        '    HOJA_EXCEL.Range("G" & fila_firma.ToString).Value = "Rodrigo Millán Armijo"
        '    HOJA_EXCEL.Range("G" & fila_firma.ToString & ":BF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("G" & fila_firma.ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString & ":BF" & (fila_firma + 1).ToString).Merge()
        '    HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString).Value = "Agrónomo"
        '    HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString & ":BF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("G" & (fila_firma + 1).ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = "Rosa Espinoza Astudillo"
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = "Jefe Laboratorio"
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Font.Size = 9
        'End If
        'If RBFirmaREA.Checked = True Then
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = "Rosa Espinoza Astudillo"
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = "Jefe Laboratorio"
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Font.Size = 9
        'End If
        'If RBFirmaRMA.Checked = True Then
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Value = "Rodrigo Millán Armijo"
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString & ":DF" & fila_firma.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & fila_firma.ToString).Font.Size = 9

        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).Merge()
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Value = "Agrónomo"
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString & ":DF" & (fila_firma + 1).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        '    HOJA_EXCEL.Range("BG" & (fila_firma + 1).ToString).Font.Size = 9
        'End If
    End Sub
    Private Sub Imprime_Encabezado(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pagina As Integer, ByRef fila As Integer, ByVal R1 As Boolean, ByVal R2 As Boolean, ByVal NOMTAB As String, ByVal fecha_informe As String, ByRef Fila_Firma As Integer)
        Dim VerNom, ColD, ColH, CuartelTotal, O1, O2, O3, O4, O5, O6 As String
        Dim BOLA2, BusIden As Object
        Dim FILA_HOMO, Fila_NColumnas, Fila_Iden As DataRow

        If pagina <> 1 Then
            Fila_Firma = 50 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Firma = 50
        End If

        If pagina <> 1 Then
            Fila_Nota = 58 + (Filas_Pagina * (pagina - 1))
        Else
            Fila_Nota = 58
        End If
        IncFil = 0


        '*********************************************************************************

        If O1 <> "" Or O2 <> "" Or O3 <> "" Or O4 <> "" Or O5 <> "" Or O6 <> "" Then
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Value = "Notas:"
            HOJA_EXCEL.Range("A" & Fila_Nota.ToString).Font.Size = 9
            IncFil = IncFil + 1
        End If
        If O1 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O1
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If O2 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O2
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If O3 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O3
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If O4 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O4
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If O5 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O5
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If
        If O6 <> "" Then
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Value = O6
            HOJA_EXCEL.Range("A" & (Fila_Nota + IncFil).ToString).Font.Size = 7
            IncFil = IncFil + 1
        End If

        '*********************************************************************************

        If R1 = True Then
            If pagina <> 1 Then
                Fila_Pie = Filas_Pagina + ((pagina - 1) * Filas_Pagina)
            Else
                Fila_Pie = Filas_Pagina
            End If
            HOJA_EXCEL.Range("A" & (Fila_Pie).ToString & ":DF" & (Fila_Pie).ToString).Merge()
            HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
            HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Font.Size = 9
            'HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Bold = True
            HOJA_EXCEL.Range("A" & (Fila_Pie).ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("A" & (Fila_Pie).ToString & ":DF" & (Fila_Pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If pagina <> 1 Then fila = ((pagina - 1) * Filas_Pagina) + 1

        If pagina <> 1 Then
            Fila_Logo = fila : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        Else
            Fila_Logo = 1 : HOJA_EXCEL.Range("A" & Fila_Logo.ToString).Select()
        End If

        If R1 = True Then
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "LABORATORIO AGRICOLA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 7
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 1
        If R1 = True Then
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "ANALISIS DE SUELO - FOLIAR - AGUA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 6
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 4
        Fila_Merge = fila + 1
        HOJA_EXCEL.Range("AE" & fila.ToString).Value = "INFORME DE RESULTADOS  -"
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AE" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("BK" & fila.ToString).Value = "Nº Orden:"
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter


        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("BV" & fila.ToString).Value = Format(CInt(txtOrdDes.Text), "###,###")
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        fila = fila + 1
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).Merge()
        If NOMTAB = 1000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS FOLIAR"
        End If
        If NOMTAB = 2000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS FRUTO"
        End If
        If NOMTAB = 3000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS AGUA"
        End If
        If NOMTAB = 4000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS SUELO"
        End If
        If NOMTAB = 5000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS FERTILIZANTES ORGÁNICOS"
        End If
        If NOMTAB = 6000 Then
            HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS FERTILIZANTES QUÍMICOS"
        End If
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = Fila_Merge
        'PRODUCTOR
        fila = fila + 3
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = GProductor
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            'Especie
            HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Especie"
            HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
            VerNom = MATRIZ_AUX(2)
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        Else
            'Empresa
            HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Empresa"
            HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
            VerNom = GEmpresa
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        End If
        'Predio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = MATRIZ_AUX(4)
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            'Tejido
            HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Tejido"
            HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
            VerNom = MATRIZ_AUX(3)
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        Else
            'Remite
            HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
            HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
            VerNom = GRemite
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        End If
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            'EMPRESA
            fila = fila + 1
            HOJA_EXCEL.Range("A" & fila.ToString).Value = "Empresa"
            HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
            VerNom = GEmpresa
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
            'Remite
            HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
            HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
            HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
            VerNom = GRemite
            Call control_nombre(VerNom)
            HOJA_EXCEL.Range("CF" & fila.ToString).Value = VerNom
            HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        End If
        'Localidad
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        VerNom = MATRIZ_AUX(1)
        Call control_nombre(VerNom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = VerNom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'F.Muestreo
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha muestreo"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ_AUX(5)
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom

        'F.Ingreso
        HOJA_EXCEL.Range("CP" & fila.ToString).Value = "F.Ingreso"
        HOJA_EXCEL.Range("CP" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CP" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CW" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CW" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = GFechaIngreso
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CX" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'F.Informe
        fila = fila + 1
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "F.del informe"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = fecha_informe
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignBottom
        'pag
        fila = fila + 1
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = "Pag."
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        fila = fila + 1 : FilaCua = fila
        Fila_Borde = fila
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificación Cuartel"
        Else
            HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificación Muestra"
        End If
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        If R2 = True And NOMTAB = 1000 Then
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).Merge()
            HOJA_EXCEL.Range("CT" & fila.ToString).Value = "Rango Adecuado*"
            HOJA_EXCEL.Range("CT" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).WrapText = True
        End If
        If R2 = True And NOMTAB = 2000 Then
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).Merge()
            HOJA_EXCEL.Range("CT" & fila.ToString).Value = "Rango Adecuado*"
            HOJA_EXCEL.Range("CT" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).WrapText = True
        End If
        If R2 = True And NOMTAB = 3000 Then
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).Merge()
            HOJA_EXCEL.Range("CT" & fila.ToString).Value = "Rango Adecuado*"
            HOJA_EXCEL.Range("CT" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).WrapText = True
        End If
        If R2 = True And NOMTAB = 4000 Then
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila.ToString).Value = "Rango para Interpretación"
            HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila + 1.ToString).WrapText = True
            fila = fila + 2
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CY" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila.ToString).Value = "Sin Problema"
            HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CY" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CY" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":CY" & fila + 1.ToString).WrapText = True

            HOJA_EXCEL.Range("CZ" & fila.ToString & ":DF" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CZ" & fila.ToString).Value = "Problema Severo"
            HOJA_EXCEL.Range("CZ" & fila.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CZ" & fila.ToString & ":DF" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CZ" & fila.ToString & ":DF" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CZ" & fila.ToString & ":DF" & fila + 1.ToString).WrapText = True
        End If
        If R2 = True And NOMTAB = 5000 Then
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).Merge()
            HOJA_EXCEL.Range("CT" & fila.ToString).Value = "Rango Adecuado*"
            HOJA_EXCEL.Range("CT" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).WrapText = True
        End If
        If R2 = True And NOMTAB = 6000 Then
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).Merge()
            HOJA_EXCEL.Range("CT" & fila.ToString).Value = "Rango Adecuado*"
            HOJA_EXCEL.Range("CT" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CT" & fila.ToString & ":DF" & fila + 4.ToString).WrapText = True
        End If
        If NOMTAB = 1000 Or NOMTAB = 2000 Then
            'Variedad
            fila = fila + 2 : FilaVar = fila
            HOJA_EXCEL.Range("A" & fila.ToString).Value = "Variedad"
            HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'EDAD
            fila = fila + 1 : FilaEdad = fila
            HOJA_EXCEL.Range("A" & fila.ToString).Value = "Edad"
            HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
            HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        If NOMTAB = 3000 Then
            fila = fila + 1
        End If
        If NOMTAB = 4000 Then
            fila = fila + 1
        End If
        If NOMTAB = 5000 Then
            fila = fila + 1
        End If
        If NOMTAB = 6000 Then
            fila = fila + 1
        End If
        'n°laboratorio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N° de Laboratorio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        ' imprime identificacion *************

        For Each Fila_NColumnas In Cjto_Tablas1.Tables("NLAB_COLUMNAS").Rows
            ColD = Fila_NColumnas("COLUMNAD")
            ColH = Fila_NColumnas("COLUMNAH")
            BusIden = Fila_NColumnas("OT_NLAB")
            Fila_Iden = Cjto_Tablas1.Tables("TABLA_CICLO").Rows.Find(BusIden)
            If NOMTAB = 1000 Then
                CuartelTotal = Fila_Iden("FOLANT_CUARTEL1") & Fila_Iden("FOLANT_CUARTEL2")
            End If
            If NOMTAB = 2000 Then
                CuartelTotal = Fila_Iden("TEJANT_CUARTEL1") & Fila_Iden("TEJANT_CUARTEL2")
            End If
            If NOMTAB = 3000 Then
                CuartelTotal = Fila_Iden("AGUANT_IDENTIFICACION1") & Fila_Iden("AGUANT_IDENTIFICACION2")
            End If
            If NOMTAB = 4000 Then
                CuartelTotal = Fila_Iden("SUEANT_IDENTIFICACION1") & Fila_Iden("SUEANT_IDENTIFICACION2")
            End If
            If NOMTAB = 5000 Then
                CuartelTotal = Fila_Iden("FEOANT_IDENTIFICACION")
            End If
            If NOMTAB = 6000 Then
                CuartelTotal = Fila_Iden("FEQANT_IDENTIFICACION")
            End If
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).Merge()
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Value = CuartelTotal
            HOJA_EXCEL.Range(ColD & FilaCua.ToString).Font.Size = 9
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range(ColD & FilaCua.ToString & ":" & ColH & FilaCua + 1.ToString).WrapText = True

            If NOMTAB = 1000 Then
                HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).Merge()
                HOJA_EXCEL.Range(ColD & FilaVar.ToString).Value = Fila_Iden("VARIEDAD")
                HOJA_EXCEL.Range(ColD & FilaVar.ToString).Font.Size = 9
                HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                HOJA_EXCEL.Range(ColD & FilaVar.ToString & ":" & ColH & FilaVar.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

                HOJA_EXCEL.Range(ColD & FilaEdad.ToString & ":" & ColH & FilaEdad.ToString).Merge()
                HOJA_EXCEL.Range(ColD & FilaEdad.ToString).Value = Fila_Iden("FOLANT_EDAD")
                HOJA_EXCEL.Range(ColD & FilaEdad.ToString).Font.Size = 9
                HOJA_EXCEL.Range(ColD & FilaEdad.ToString & ":" & ColH & FilaEdad.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                HOJA_EXCEL.Range(ColD & FilaEdad.ToString & ":" & ColH & FilaEdad.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            End If

            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).Merge()
            HOJA_EXCEL.Range(ColD & fila.ToString).Value = Fila_NColumnas("OT_NLAB")
            HOJA_EXCEL.Range(ColD & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range(ColD & fila.ToString & ":" & ColH & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
        HOJA_EXCEL.Range("A" & Fila_Borde.ToString & ":DF" & fila.ToString).BorderAround()
        fila = fila + 1
    End Sub
    Private Sub Cuenta_Filas_Notas(ByRef Cuanta_Filas As Integer)
        Dim FILA_NOTA As DataRow
        Dim BusEsp As Object
        Dim varmer, largoco, k As Integer
        BusEsp = MATRIZ_AUX(2)
        FILA_NOTA = Cjto_Tablas1.Tables("NOTA_AUTO_RESULTADOS").Rows.Find(BusEsp)

        If Not (FILA_NOTA Is Nothing) Then
            If IsDBNull(FILA_NOTA("DESCRIPCION")) <> True Then
                largoco = Len(FILA_NOTA("DESCRIPCION"))
                varmer = CInt(largoco / 110)
                Cuanta_Filas = Cuanta_Filas + varmer
            End If
        End If

        'If TxtNota1.Text <> "" Then
        '    largoco = Len(TxtNota1.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtNota2.Text <> "" Then
        '    largoco = Len(TxtNota2.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtNota3.Text <> "" Then
        '    largoco = Len(TxtNota3.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtNota4.Text <> "" Then
        '    largoco = Len(TxtNota4.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtNota5.Text <> "" Then
        '    largoco = Len(TxtNota5.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtNota6.Text <> "" Then
        '    largoco = Len(TxtNota6.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtObs1.Text <> "" Then
        '    largoco = Len(TxtObs1.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtObs2.Text <> "" Then
        '    largoco = Len(TxtObs2.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtObs3.Text <> "" Then
        '    largoco = Len(TxtObs3.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

        'If TxtObs4.Text <> "" Then
        '    largoco = Len(TxtObs4.Text)
        '    varmer = CInt(largoco / 110)
        '    Cuanta_Filas = Cuanta_Filas + varmer
        'End If

    End Sub

    Public Sub Salto_De_Pagina_Suelo(ByVal total_paginas As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pagina As Integer, ByVal MATRIZ() As String, ByRef fila As Integer, ByRef fila_firma As Integer, ByVal HOMO As DataTable, ByVal O1 As String, ByVal O2 As String, ByVal O3 As String, ByVal O4 As String, ByVal O5 As String, ByVal O6 As String, ByVal R1 As Boolean, ByVal R2 As Boolean, ByVal NOMTAB As String, ByVal fecha_informe As String)
        Dim fila_merge, fila_borde, fila_pie, fila_logo, fila_nota, incfil As Integer
        Dim vernom As String
        Dim BOLA2 As Object
        Dim FILA_HOMO As DataRow
        If pagina <> 1 Then
            If NOMTAB = "MSUE" Then fila_firma = 55 + (Filas_Pagina * (pagina - 1))
            If NOMTAB = "MSAL" Then fila_firma = 52 + (Filas_Pagina * (pagina - 1))
        Else
            If NOMTAB = "MSUE" Then fila_firma = 55
            If NOMTAB = "MSAL" Then fila_firma = 52
        End If
        If pagina <> 1 Then
            If NOMTAB = "MSUE" Then fila_nota = 60 + (Filas_Pagina * (pagina - 1))
            If NOMTAB = "MSAL" Then fila_nota = 56 + (Filas_Pagina * (pagina - 1))
        Else
            If NOMTAB = "MSUE" Then fila_nota = 60
            If NOMTAB = "MSAL" Then fila_nota = 56
        End If
        incfil = 0
        If O1 <> "" Or O2 <> "" Or O3 <> "" Or O4 <> "" Or O5 <> "" Or O6 <> "" Then
            HOJA_EXCEL.Range("A" & fila_nota.ToString).Value = "Notas:"
            HOJA_EXCEL.Range("A" & fila_nota.ToString).Font.Size = 9
            incfil = incfil + 1
        End If
        If O1 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O1
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If O2 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O2
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If O3 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O3
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If O4 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O4
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If O5 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O5
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If O6 <> "" Then
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Value = O6
            HOJA_EXCEL.Range("A" & (fila_nota + incfil).ToString).Font.Size = 7
            incfil = incfil + 1
        End If
        If R1 = True Then
            If pagina <> 1 Then
                fila_pie = Filas_Pagina + ((pagina - 1) * Filas_Pagina)
            Else
                fila_pie = Filas_Pagina
            End If
            HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).Merge()
            HOJA_EXCEL.Range("A" & (fila_pie).ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
            HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Size = 9
            'HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Bold = True
            HOJA_EXCEL.Range("A" & (fila_pie).ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("A" & (fila_pie).ToString & ":DF" & (fila_pie).ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If pagina <> 1 Then fila = ((pagina - 1) * Filas_Pagina) + 1

        If pagina <> 1 Then
            fila_logo = fila : HOJA_EXCEL.Range("A" & fila_logo.ToString).Select()
        Else
            fila_logo = 1 : HOJA_EXCEL.Range("A" & fila_logo.ToString).Select()
        End If
        If R1 = True Then
            HOJA_EXCEL.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "LABORATORIO AGRICOLA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 7
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 1
        If R1 = True Then
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CG" & fila.ToString).Value = "ANALISIS DE SUELO - FOLIAR - AGUA"
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Size = 6
            'HOJA_EXCEL.Range("CG" & fila.ToString).Font.Bold = True
            HOJA_EXCEL.Range("CG" & fila.ToString).Font.Color = RGB(0, 0, 128)
            HOJA_EXCEL.Range("CG" & fila.ToString & ":DH" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        fila = fila + 2
        fila_merge = fila + 1
        HOJA_EXCEL.Range("AE" & fila.ToString).Value = "INFORME DE RESULTADOS  -"
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("AE" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AE" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("AE" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        HOJA_EXCEL.Range("BK" & fila.ToString).Value = "Nº Orden:"
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BK" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BK" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BK" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).Merge()
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).NumberFormat = "###.###"
        HOJA_EXCEL.Range("BV" & fila.ToString).Value = Format(CInt(MATRIZ(6)), "###,###")
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BV" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("BV" & fila.ToString & ":CC" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

        fila = fila + 1
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).Merge()
        HOJA_EXCEL.Range("AJ" & fila.ToString).Value = "ANALISIS SUELO"
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Size = 14
        HOJA_EXCEL.Range("AJ" & fila.ToString).Font.Bold = True
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        HOJA_EXCEL.Range("AJ" & fila.ToString & ":BW" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        fila = fila_merge
        'PRODUCTOR
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Productor"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = MATRIZ(7)
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'EMPRESA
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Empresa"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = MATRIZ(0)
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'predio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Predio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = MATRIZ(1)
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'Remite
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Remite"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 10
        vernom = MATRIZ(3)
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 10
        'localidad
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Localidad"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 10
        HOJA_EXCEL.Range("K" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("K" & fila.ToString).Font.Size = 10
        vernom = MATRIZ(2)
        Call control_nombre(vernom)
        HOJA_EXCEL.Range("M" & fila.ToString).Value = vernom
        HOJA_EXCEL.Range("M" & fila.ToString).Font.Size = 10
        'F.Muestreo
        'HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha muestreo"
        'HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        'HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        'HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ(9)
        'HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'F.Ingreso
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha Ingreso"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = MATRIZ(8)
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'F.Informe
        fila = fila + 1
        HOJA_EXCEL.Range("BR" & fila.ToString).Value = "Fecha informe"
        HOJA_EXCEL.Range("BR" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("BR" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CD" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("CD" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CD" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral

        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).NumberFormat = "dd-mm-yyyy"
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).Merge()
        HOJA_EXCEL.Range("CF" & fila.ToString).Value = fecha_informe
        HOJA_EXCEL.Range("CF" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CF" & fila.ToString & ":CN" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
        'pag
        fila = fila + 1
        HOJA_EXCEL.Range("CX" & fila.ToString).Value = "Pag."
        HOJA_EXCEL.Range("CX" & fila.ToString).Font.Size = 7
        HOJA_EXCEL.Range("CX" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
        fila = fila + 1
        fila_borde = fila
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Identificación muestra"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        If R2 = True And NOMTAB <> "MSUE" Then
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila.ToString).Value = "Rango para"
            HOJA_EXCEL.Range("CS" & fila.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":DF" & fila + 1.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 1.ToString).Value = "Interpretación"
            HOJA_EXCEL.Range("CS" & fila + 1.ToString).Font.Size = 9
            HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":DF" & fila + 1.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila + 1.ToString & ":DF" & fila + 1.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CS" & fila.ToString & ":DF" & fila + 1.ToString).BorderAround()

            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":CY" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 2.ToString).Value = "Sin"
            HOJA_EXCEL.Range("CS" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":CY" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":CY" & fila + 2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range("CS" & fila + 3.ToString & ":CY" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CS" & fila + 3.ToString).Value = "Problema"
            HOJA_EXCEL.Range("CS" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CS" & fila + 3.ToString & ":CY" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CS" & fila + 3.ToString & ":CY" & fila + 3.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CS" & fila + 2.ToString & ":CY" & fila + 3.ToString).BorderAround()

            HOJA_EXCEL.Range("CZ" & fila + 2.ToString & ":DF" & fila + 2.ToString).Merge()
            HOJA_EXCEL.Range("CZ" & fila + 2.ToString).Value = "Problema"
            HOJA_EXCEL.Range("CZ" & fila + 2.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CZ" & fila + 2.ToString & ":DF" & fila + 2.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CZ" & fila + 2.ToString & ":DF" & fila + 2.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter

            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).Merge()
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString).Value = "Severo"
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString).Font.Size = 7
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("CZ" & fila + 3.ToString & ":DF" & fila + 3.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("CZ" & fila + 2.ToString & ":DF" & fila + 3.ToString).BorderAround()
        End If
        'Profundidad muestreo (cm)
        fila = fila + 2
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "Profundidad muestreo(cm)"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        'n°laboratorio
        fila = fila + 1
        HOJA_EXCEL.Range("A" & fila.ToString).Value = "N° de Laboratorio"
        HOJA_EXCEL.Range("A" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("AA" & fila.ToString).Value = ":"
        HOJA_EXCEL.Range("AA" & fila.ToString).Font.Size = 9
        HOJA_EXCEL.Range("A" & fila_borde.ToString & ":DF" & fila.ToString).BorderAround()
    End Sub


    Private Sub Genera_Tabla_Ciclo_Resultados()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet
        Dim NLabDesR, NLabHasR As Integer
        Dim OrdenT As Integer
        If NOMTAB = 1000 Then NLabDesR = CInt(TxtLabDesFoliar.Text) : NLabHasR = CInt(TxtLabHasFoliar.Text)
        If NOMTAB = 2000 Then NLabDesR = CInt(TxtLabDesTejidos.Text) : NLabHasR = CInt(TxtLabHasTejidos.Text)
        If NOMTAB = 3000 Then NLabDesR = CInt(TxtLabDesAgua.Text) : NLabHasR = CInt(TxtLabHasAgua.Text)
        If NOMTAB = 3600 Then NLabDesR = CInt(TxtLabDesColi.Text) : NLabHasR = CInt(TxtLabHasColi.Text)
        If NOMTAB = 4000 Then NLabDesR = CInt(TxtLabDesSueloFer.Text) : NLabHasR = CInt(TxtLabHasSueloFer.Text)
        If NOMTAB = 4500 Then NLabDesR = CInt(TxtLabDesSueloSal.Text) : NLabHasR = CInt(TxtLabHasSueloSal.Text)
        If NOMTAB = 5000 Then NLabDesR = CInt(TxtLabDesFertQui.Text) : NLabHasR = CInt(TxtLabHasFertQui.Text)
        If NOMTAB = 6000 Then NLabDesR = CInt(TxtLabDesFertOrgFis.Text) : NLabHasR = CInt(TxtLabHasFertOrgFis.Text)
        If NOMTAB = 8000 Then NLabDesR = CInt(TxtLabDesNema.Text) : NLabHasR = CInt(TxtLabHasNema.Text)

        If NOMTAB = 1000 Then OrdenT = CInt(TxtOrdDesFoliar.Text)
        If NOMTAB = 2000 Then OrdenT = CInt(TxtOrdDesTejidos.Text)
        If NOMTAB = 3000 Then OrdenT = CInt(TxtOrdDesAgua.Text)
        If NOMTAB = 3600 Then OrdenT = CInt(TxtOrdDesColi.Text)
        If NOMTAB = 4000 Then OrdenT = CInt(TxtOrdDesSueloFer.Text)
        If NOMTAB = 4500 Then OrdenT = CInt(TxtOrdDesSueloSal.Text)
        If NOMTAB = 5000 Then OrdenT = CInt(TxtOrdDesFertQui.Text)
        If NOMTAB = 6000 Then OrdenT = CInt(TxtOrdDesFertOrgFis.Text)
        If NOMTAB = 8000 Then OrdenT = CInt(TxtOrdDesNema.Text)

        With SP
            .Inicializar()
            .AgregarParametro("@NLabDesde", NLabDesR, SqlDbType.Int)
            .AgregarParametro("@NLabHasta", NLabHasR, SqlDbType.Int)
            .AgregarParametro("@TMuestra", NOMTAB, SqlDbType.Int)
            .AgregarParametro("@NumOt", OrdenT, SqlDbType.Int)
            .EjecutarQueryDt("usp_SelectResultadosLlenoAntecedentes", Cjto_Tablas1, "TABLA_CICLO")
        End With
    End Sub

    Private Sub Genera_Tabla_Elementos_Prioridad_Rango()
        Dim query As String
        Dim Test1 As DbManager = New DbManager("ELEMENTO_PRIORIDAD", Conexion1)
        Dim query1 As String


        If NOMTAB = 1000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE TMU_CODIGO=" & NOMTAB & " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If


        If NOMTAB = 2000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE TMU_CODIGO=" & NOMTAB & " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 3000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                      "WHERE TMU_CODIGO=3000 AND (ELE_CODIGO <> 'Coli_Fecales' AND " & _
                                                             "ELE_CODIGO <> 'Coli_Totales' AND " & _
                                                             "ELE_CODIGO <> 'EColi' AND " & _
                                                             "ELE_CODIGO <> 'Clostridios' AND " & _
                                                             "ELE_CODIGO <> 'Pseudomonas' AND " & _
                                                             "ELE_CODIGO <> 'Salmonella')" & _
                      " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 3600 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                      "WHERE TMU_CODIGO=3000 AND (ELE_CODIGO = 'Coli_Fecales' OR " & _
                                                             "ELE_CODIGO = 'Coli_Totales' OR " & _
                                                             "ELE_CODIGO = 'EColi' OR " & _
                                                             "ELE_CODIGO = 'Clostridios' OR " & _
                                                             "ELE_CODIGO = 'Pseudomonas' OR " & _
                                                             "ELE_CODIGO = 'Salmonella')" & _
                      " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 4000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE (ELE_TIPO_M='FE' OR ELE_TIPO_M='SF') AND TMU_CODIGO=4000 ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 4500 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE (ELE_TIPO_M='SA' OR ELE_TIPO_M='SF') AND TMU_CODIGO=4000 ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 5000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE TMU_CODIGO=" & NOMTAB & " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 6000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE TMU_CODIGO=" & NOMTAB & " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If


        If NOMTAB = 8000 Then
            query1 = "Select ELE_CODIGO,ELE_NOMBRE,ELE_SIMBOLO,ELE_UNIDAD,ELE_MASCARA,ELE_PRIORIDAD,ELE_FORMATO_RES,ELE_TITULO_RES,ELE_PROCESO FROM ELEMENTO " & _
                     "WHERE TMU_CODIGO=" & NOMTAB & " ORDER BY ELE_PRIORIDAD"
            Test1.Selecccionar(Cjto_Tablas1, query1)
        End If

        '------------ rangos DBF ------------------
        If NOMTAB = 1000 Or NOMTAB = 3600 Then
            Dim Test2 As DbManager = New DbManager("RANGO_DBF", Conexion1)
            query1 = "Select TMU_CODIGO,COD_ESP,COD_ELE_RANGO,RANGO_DESDE,SIMBOLO,RANGO_HASTA FROM RANGO_DBF " & _
                     "WHERE TMU_CODIGO=" & NOMTAB
            Test2.Selecccionar(Cjto_Tablas1, query1)
        End If

        If NOMTAB = 2000 Then
            Dim Test2 As DbManager = New DbManager("RANGO_DBF", Conexion1)
            query1 = "Select TMU_CODIGO,COD_ESP,COD_ELE_RANGO,RANGO_DESDE,SIMBOLO,RANGO_HASTA FROM RANGO_DBF " & _
                     "WHERE TMU_CODIGO=" & NOMTAB
            Test2.Selecccionar(Cjto_Tablas1, query1)
        End If

    End Sub

    Private Sub Genera_Tabla_DigRes()
        Dim OrdenT As Integer
        Dim Query, Query1, Query2, Query3 As String
        Dim Test1 As DbManager = New DbManager("TABLA_DIGRES", Conexion1)
        Dim Test2 As DbManager = New DbManager("TABLA_DIGRES2", Conexion1)
        Dim Test3 As DbManager = New DbManager("ANALISIS_ELEMENTOS", Conexion1)
        Dim Test4 As DbManager = New DbManager("ANALISIS_ELE", Conexion1)
        If NOMTAB = 1000 Then OrdenT = CInt(TxtOrdDesFoliar.Text)
        If NOMTAB = 2000 Then OrdenT = CInt(TxtOrdDesTejidos.Text)
        If NOMTAB = 3000 Then OrdenT = CInt(TxtOrdDesAgua.Text)
        If NOMTAB = 3600 Then OrdenT = CInt(TxtOrdDesColi.Text)
        If NOMTAB = 4000 Then OrdenT = CInt(TxtOrdDesSueloFer.Text)
        If NOMTAB = 4500 Then OrdenT = CInt(TxtOrdDesSueloSal.Text)
        If NOMTAB = 5000 Then OrdenT = CInt(TxtOrdDesFertQui.Text)
        If NOMTAB = 6000 Then OrdenT = CInt(TxtOrdDesFertOrgFis.Text)
        If NOMTAB = 8000 Then OrdenT = CInt(TxtOrdDesNema.Text)
        If NOMTAB = 4500 Then
            Query = "Select OT_NLAB,ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,TMU_CODIGO FROM DIGITA_RESULTADOS " & _
                             "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=4000"
            Test1.Selecccionar(Cjto_Tablas1, Query)

            Query1 = "SELECT TMU_CODIGO, OT_NLAB, ELE_CODIGO, ELE_ESTADO, ANA_CODIGO FROM DIGITA_RESULTADOS " & _
                     "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=4000"
            Test2.Selecccionar(Cjto_Resultados1, Query1)

            Query2 = "SELECT TMU_CODIGO, ANA_CODIGO, ELE_CODIGO, ELE_PRIORIDAD, TITULO_FILA FROM ANALISIS_ELEMENTOS " & _
                     "WHERE TMU_CODIGO=4000"
            Test3.Selecccionar(Cjto_Resultados1, Query2)

            Query3 = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, TIPO_COD FROM ANALISIS " & _
                     "WHERE TMU_CODIGO=4000"
            Test4.Selecccionar(Cjto_Resultados1, Query3)
        ElseIf NOMTAB = 3600 Then
            Query = "Select OT_NLAB,ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,TMU_CODIGO,OBSERVACION FROM DIGITA_RESULTADOS " & _
                             "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=3000"
            Test1.Selecccionar(Cjto_Tablas1, Query)

            Query1 = "SELECT TMU_CODIGO, OT_NLAB, ELE_CODIGO, ELE_ESTADO, ANA_CODIGO FROM DIGITA_RESULTADOS " & _
                     "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=3000"
            Test2.Selecccionar(Cjto_Resultados1, Query1)

            Query2 = "SELECT TMU_CODIGO, ANA_CODIGO, ELE_CODIGO, ELE_PRIORIDAD, TITULO_FILA FROM ANALISIS_ELEMENTOS " & _
                     "WHERE TMU_CODIGO=3000"
            Test3.Selecccionar(Cjto_Resultados1, Query2)

            Query3 = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, TIPO_COD FROM ANALISIS " & _
                     "WHERE TMU_CODIGO=3000"
            Test4.Selecccionar(Cjto_Resultados1, Query3)
        Else
            Query = "Select OT_NLAB,ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,TMU_CODIGO FROM DIGITA_RESULTADOS " & _
                     "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=" & NOMTAB
            Test1.Selecccionar(Cjto_Tablas1, Query)

            Query1 = "SELECT TMU_CODIGO, OT_NLAB, ELE_CODIGO, ELE_ESTADO, ANA_CODIGO FROM DIGITA_RESULTADOS " & _
                     "WHERE OT_NUMERO=" & OrdenT & " AND TMU_CODIGO=" & NOMTAB
            Test2.Selecccionar(Cjto_Resultados1, Query1)

            Query2 = "SELECT TMU_CODIGO, ANA_CODIGO, ELE_CODIGO, ELE_PRIORIDAD, TITULO_FILA FROM ANALISIS_ELEMENTOS " & _
                     "WHERE TMU_CODIGO=" & NOMTAB
            Test3.Selecccionar(Cjto_Resultados1, Query2)

            Query3 = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, TIPO_COD FROM ANALISIS " & _
                     "WHERE TMU_CODIGO=" & NOMTAB
            Test4.Selecccionar(Cjto_Resultados1, Query3)
        End If
    End Sub

    Private Sub Genera_Tabla_EleDig()
        Dim OrdenT As Integer
        Dim Query As String
        Dim Test1 As DbManager = New DbManager("TABLA_ELEDIG", Conexion1)
        If NOMTAB = 1000 Then OrdenT = CInt(TxtOrdDesFoliar.Text)
        If NOMTAB = 2000 Then OrdenT = CInt(TxtOrdDesTejidos.Text)
        If NOMTAB = 3000 Then OrdenT = CInt(TxtOrdDesAgua.Text)
        If NOMTAB = 3600 Then OrdenT = CInt(TxtOrdDesColi.Text)
        If NOMTAB = 4000 Then OrdenT = CInt(TxtOrdDesSueloFer.Text)
        If NOMTAB = 4500 Then OrdenT = CInt(TxtOrdDesSueloSal.Text)
        If NOMTAB = 5000 Then OrdenT = CInt(TxtOrdDesFertQui.Text)
        If NOMTAB = 6000 Then OrdenT = CInt(TxtOrdDesFertOrgFis.Text)
        If NOMTAB = 8000 Then OrdenT = CInt(TxtOrdDesNema.Text)
        If NOMTAB = 4500 Then
            Query = " SELECT DIGITA_RESULTADOS.OT_NLAB,DIGITA_RESULTADOS.ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,DIGITA_RESULTADOS.TMU_CODIGO,ELE_PROCESO,ELE_TIPO_M" & _
                    " FROM DIGITA_RESULTADOS " & _
                    " LEFT JOIN ELEMENTO ON (DIGITA_RESULTADOS.ELE_CODIGO=ELEMENTO.ELE_CODIGO AND DIGITA_RESULTADOS.TMU_CODIGO=ELEMENTO.TMU_CODIGO)" & _
                    " WHERE OT_NUMERO=" & OrdenT & " AND DIGITA_RESULTADOS.TMU_CODIGO=4000"
            Test1.Selecccionar(Cjto_Tablas1, Query)

        ElseIf NOMTAB = 3600 Then
            Query = " SELECT DIGITA_RESULTADOS.OT_NLAB,DIGITA_RESULTADOS.ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,DIGITA_RESULTADOS.TMU_CODIGO,ELE_PROCESO,ELE_TIPO_M" & _
                    " FROM DIGITA_RESULTADOS " & _
                    " LEFT JOIN ELEMENTO ON (DIGITA_RESULTADOS.ELE_CODIGO=ELEMENTO.ELE_CODIGO AND DIGITA_RESULTADOS.TMU_CODIGO=ELEMENTO.TMU_CODIGO)" & _
                    " WHERE OT_NUMERO=" & OrdenT & " AND DIGITA_RESULTADOS.TMU_CODIGO=3000"
            Test1.Selecccionar(Cjto_Tablas1, Query)

        Else
            Query = " SELECT DIGITA_RESULTADOS.OT_NLAB,DIGITA_RESULTADOS.ELE_CODIGO,DIGRES_RESULTADO,ELE_ESTADO,DIGITA_RESULTADOS.TMU_CODIGO,ELE_PROCESO,ELE_TIPO_M" & _
                    " FROM DIGITA_RESULTADOS " & _
                    " LEFT JOIN ELEMENTO ON (DIGITA_RESULTADOS.ELE_CODIGO=ELEMENTO.ELE_CODIGO AND DIGITA_RESULTADOS.TMU_CODIGO=ELEMENTO.TMU_CODIGO)" & _
                    " WHERE OT_NUMERO=" & OrdenT & " AND DIGITA_RESULTADOS.TMU_CODIGO=" & NOMTAB
            Test1.Selecccionar(Cjto_Tablas1, Query)
        End If
    End Sub

    Private Sub Genera_Tabla_Notas_Automaticas()
        Dim Query As String
        Dim Test1 As DbManager = New DbManager("NOTA_AUTO_RESULTADOS", Conexion1)
        frmEsp.Refresh()
        Query = "SELECT ESP_ESPECIE, DESCRIPCION FROM NOTA_AUTO_RESULTADOS ORDER BY ESP_ESPECIE"
        Test1.Selecccionar(Cjto_Tablas1, Query)
    End Sub
    Public Sub Revisa_Salto_Por_Encabezado(ByVal FILA_SET As DataRow, ByRef SALTO_PAGINA As Boolean, ByVal NOMTAB As String)

        If IsDBNull(FILA_SET("PREDIO")) Then FILA_SET("PREDIO") = ""
        If IsDBNull(FILA_SET("LOCALIDAD")) Then FILA_SET("LOCALIDAD") = ""
        If IsDBNull(FILA_SET("FMUESTREO")) Then FILA_SET("FMUESTREO") = ""
        If IsDBNull(FILA_SET("MUESTREADOR")) Then FILA_SET("MUESTREADOR") = ""
        If IsDBNull(FILA_SET("CAMPO1")) Then FILA_SET("CAMPO1") = ""
        If IsDBNull(FILA_SET("CAMPO2")) Then FILA_SET("CAMPO2") = ""

        If FILA_SET("FOLANT_PREDIO") <> MATRIZ_AUX(1) Then SALTO_PAGINA = True
        If FILA_SET("LOCALIDAD") <> MATRIZ_AUX(2) Then SALTO_PAGINA = True
        If FILA_SET("FMUESTREO") <> MATRIZ_AUX(3) Then SALTO_PAGINA = True
        If FILA_SET("MUESTREADOR") <> MATRIZ_AUX(4) Then SALTO_PAGINA = True
        If FILA_SET("CAMPO1") <> MATRIZ_AUX(5) Then SALTO_PAGINA = True
        If FILA_SET("CAMPO2") <> MATRIZ_AUX(6) Then SALTO_PAGINA = True

        MATRIZ_AUX(1) = FILA_SET("PREDIO")
        MATRIZ_AUX(2) = FILA_SET("LOCALIDAD")
        MATRIZ_AUX(3) = FILA_SET("FMUESTREO")
        MATRIZ_AUX(4) = FILA_SET("MUESTREADOR")
        MATRIZ_AUX(5) = FILA_SET("CAMPO1")
        MATRIZ_AUX(6) = FILA_SET("CAMPO2")
    End Sub

    '    Private Sub Genera_Impresion(ByVal NOMTAB As String)
    '        Dim FILA_MFOL, FILA_IMP1 As DataRow
    '        Dim MIMPRESION As Impresion = New Impresion
    '        Dim MATRIZ_AUX(9), TITULO(1, 3), not1, not2, not3, not4, fuente, destino As String
    '        Dim ORD_AUX, NLAD, NLAH, PRO, COLUMNA, ULT_NLA, especie, NLAH_GRABA, NLAD_GRABA As String
    '        Dim PRIMERO As Integer = 0
    '        Dim fila, CONTADOR_NLA, pagina, total_paginas, Fila_Fin_Aux, fila_ini, fila_fin, MAXI_COL As Integer
    '        Dim SALTO_PAGINA, GENERA_ARCHIVO As Boolean
    '        Dim objLibroExcel As Excel.Workbook
    '        Dim m_Excel As Excel.Application
    '        Dim Hoja_Excel As Excel.Worksheet
    '        Dim BOLA As Object
    '        Dim ELE_AGUA() As Double
    '        ReDim RANGO_CE(3, 2)
    '        SALTO_PAGINA = False
    '        GENERA_ARCHIVO = False
    '        not1 = TextBox11.Text
    '        not2 = TextBox18.Text
    '        not3 = TextBox19.Text
    '        not4 = TextBox34.Text
    '        If RadioButton10.Checked = True Then
    '            MAXI_COL = 5
    '        Else
    '            MAXI_COL = 6
    '        End If
    '        If NOMTAB = "MAGU" Then MAXI_COL = 4
    '        pagina = 0 : total_paginas = 0
    '        fila = 1 : CONTADOR_NLA = 0
    '        Fila_Fin_Aux = 0
    '        For Each FILA_MFOL In Cjto_Resultados1.Tables(NOMTAB).Rows
    '            If FILA_MFOL.RowState <> DataRowState.Deleted Then
    '                If NOMTAB = "MAGU" Then
    '                    ReDim ELE_AGUA(26)
    '                    If IsDBNull(FILA_MFOL("IPH")) = False Then ELE_AGUA(0) = FILA_MFOL("IPH") Else ELE_AGUA(0) = 0
    '                    If IsDBNull(FILA_MFOL("ICE")) = False Then ELE_AGUA(1) = FILA_MFOL("ICE") Else ELE_AGUA(1) = 0
    '                    If IsDBNull(FILA_MFOL("IRAZ")) = False Then ELE_AGUA(2) = FILA_MFOL("IRAZ") Else ELE_AGUA(2) = 0
    '                    If IsDBNull(FILA_MFOL("ICA")) = False Then ELE_AGUA(3) = FILA_MFOL("ICA") Else ELE_AGUA(3) = 0
    '                    If IsDBNull(FILA_MFOL("IMG")) = False Then ELE_AGUA(4) = FILA_MFOL("IMG") Else ELE_AGUA(4) = 0
    '                    If IsDBNull(FILA_MFOL("INA")) = False Then ELE_AGUA(5) = FILA_MFOL("INA") Else ELE_AGUA(5) = 0
    '                    If IsDBNull(FILA_MFOL("IK")) = False Then ELE_AGUA(6) = FILA_MFOL("IK") Else ELE_AGUA(6) = 0
    '                    If IsDBNull(FILA_MFOL("ICL")) = False Then ELE_AGUA(7) = FILA_MFOL("ICL") Else ELE_AGUA(7) = 0
    '                    If IsDBNull(FILA_MFOL("ISO4")) = False Then ELE_AGUA(8) = FILA_MFOL("ISO4") Else ELE_AGUA(8) = 0
    '                    If IsDBNull(FILA_MFOL("IHCO3")) = False Then ELE_AGUA(9) = FILA_MFOL("IHCO3") Else ELE_AGUA(9) = 0
    '                    If IsDBNull(FILA_MFOL("INO3")) = False Then ELE_AGUA(10) = FILA_MFOL("INO3") Else ELE_AGUA(10) = 0
    '                    If IsDBNull(FILA_MFOL("NITRITO")) = False Then ELE_AGUA(11) = FILA_MFOL("NITRITO") Else ELE_AGUA(11) = 0
    '                    If IsDBNull(FILA_MFOL("AMONIACAL")) = False Then ELE_AGUA(12) = FILA_MFOL("AMONIACAL") Else ELE_AGUA(12) = 0
    '                    If IsDBNull(FILA_MFOL("IP")) = False Then ELE_AGUA(13) = FILA_MFOL("IP") Else ELE_AGUA(13) = 0
    '                    If IsDBNull(FILA_MFOL("IZN")) = False Then ELE_AGUA(14) = FILA_MFOL("IZN") Else ELE_AGUA(14) = 0
    '                    If IsDBNull(FILA_MFOL("IMN")) = False Then ELE_AGUA(15) = FILA_MFOL("IMN") Else ELE_AGUA(15) = 0
    '                    If IsDBNull(FILA_MFOL("IFE")) = False Then ELE_AGUA(16) = FILA_MFOL("IFE") Else ELE_AGUA(16) = 0
    '                    If IsDBNull(FILA_MFOL("ICU")) = False Then ELE_AGUA(17) = FILA_MFOL("ICU") Else ELE_AGUA(17) = 0
    '                    If IsDBNull(FILA_MFOL("IBO")) = False Then ELE_AGUA(18) = FILA_MFOL("IBO") Else ELE_AGUA(18) = 0
    '                    If IsDBNull(FILA_MFOL("ARSENICO")) = False Then ELE_AGUA(19) = FILA_MFOL("ARSENICO") Else ELE_AGUA(19) = 0
    '                    If IsDBNull(FILA_MFOL("PLOMO")) = False Then ELE_AGUA(20) = FILA_MFOL("PLOMO") Else ELE_AGUA(20) = 0
    '                    If IsDBNull(FILA_MFOL("CADMIO")) = False Then ELE_AGUA(21) = FILA_MFOL("CADMIO") Else ELE_AGUA(21) = 0
    '                    If IsDBNull(FILA_MFOL("MOLIBDENO")) = False Then ELE_AGUA(22) = FILA_MFOL("MOLIBDENO") Else ELE_AGUA(22) = 0
    '                    If IsDBNull(FILA_MFOL("MERCURIO")) = False Then ELE_AGUA(23) = FILA_MFOL("MERCURIO") Else ELE_AGUA(23) = 0
    '                    If IsDBNull(FILA_MFOL("IMN")) = False Then ELE_AGUA(24) = FILA_MFOL("IMN") Else ELE_AGUA(24) = 0
    '                    If IsDBNull(FILA_MFOL("IFE")) = False Then ELE_AGUA(25) = FILA_MFOL("IFE") Else ELE_AGUA(25) = 0
    '                    If IsDBNull(FILA_MFOL("ICU")) = False Then ELE_AGUA(26) = FILA_MFOL("ICU") Else ELE_AGUA(26) = 0
    '                    If ELE_AGUA(0) = 0 And ELE_AGUA(1) = 0 And ELE_AGUA(2) = 0 And _
    '                        ELE_AGUA(3) = 0 And ELE_AGUA(4) = 0 And ELE_AGUA(5) = 0 And _
    '                        ELE_AGUA(6) = 0 And ELE_AGUA(7) = 0 And ELE_AGUA(8) = 0 And _
    '                        ELE_AGUA(9) = 0 And ELE_AGUA(10) = 0 And ELE_AGUA(11) = 0 And _
    '                        ELE_AGUA(12) = 0 And ELE_AGUA(13) = 0 And ELE_AGUA(14) = 0 And _
    '                        ELE_AGUA(15) = 0 And ELE_AGUA(16) = 0 And ELE_AGUA(17) = 0 And _
    '                        ELE_AGUA(18) = 0 And ELE_AGUA(19) = 0 And ELE_AGUA(20) = 0 And _
    '                        ELE_AGUA(21) = 0 And ELE_AGUA(22) = 0 And ELE_AGUA(23) = 0 And _
    '                        ELE_AGUA(24) = 0 And ELE_AGUA(25) = 0 And ELE_AGUA(26) = 0 Then
    '                        GoTo SALTOBACTER
    '                    End If
    '                End If
    '                GENERA_ARCHIVO = False
    '                SALTO_PAGINA = False
    '                NLAD = "" : NLAH = ""
    '                CONTADOR_NLA = CONTADOR_NLA + 1
    '                PRO = FILA_MFOL("IPRO")
    '                MIMPRESION.Revisa_Generacion_Archivo(FILA_MFOL, GENERA_ARCHIVO, ORD_AUX, NLAD, NLAH, Cjto_Resultados1.Tables(NOMTAB))
    '                If GENERA_ARCHIVO = True Then
    '                    NLADE = NLAD : NLAHA = NLAH : NOMBRE_PROD = PRO
    '                    If fila_ini <> 0 Then Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround() : MIMPRESION.notas_automaticas(especie, Hoja_Excel, fila_fin, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("NOTA_AUTO_RESULTADO"), not1, not2, not3, not4)
    '                    MIMPRESION.IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina, NOMTAB)
    '                    '
    '                    'proceso generacion
    '                    '
    '                    Call MIMPRESION.control_nombre(PRO, Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    m_Excel = CreateObject("EXCEL.APPLICATION")
    '                    If NLAH = "" Then NLAH = "       "
    '                    fuente = "F:\Mis Documentos\2005.Foliar-Labsys\Formatos Resultados.xls"
    '                    If NOMTAB = "MFOL" Then destino = "F:\Mis Documentos\2005.Foliar-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"
    '                    If NOMTAB = "MFRU" Then destino = "F:\Mis Documentos\2005.Frutos-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"
    '                    If NOMTAB = "MSAL" Then destino = "F:\Mis Documentos\2005.Suelo-Labsys\" & NLAD & NLAH & "   " & PRO & " (S).xls"
    '                    If NOMTAB = "MSUE" Then destino = "F:\Mis Documentos\2005.Suelo-Labsys\" & NLAD & NLAH & "   " & PRO & " (F).xls"
    '                    If NOMTAB = "MAGU" Then destino = "F:\Mis Documentos\2005.Agua-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"
    '                    If NOMTAB = "MNEM" Then destino = "F:\Mis Documentos\Labsys prueba 2005.Nematodos-Labsys\" & NLAD & NLAH & "   " & PRO & ".xls"

    '                    NLAH_GRABA = NLAH : NLAD_GRABA = NLAD
    '                    'Try
    '                    '    FileCopy(fuente, destino)
    '                    'Catch ex As Exception
    '                    '    MsgBox("Documento Abierto")
    '                    'End Try
    '                    objLibroExcel = m_Excel.Workbooks.Open(fuente)
    '                    m_Excel.Visible = True
    '                    Hoja_Excel = objLibroExcel.Worksheets(1)
    '                    Hoja_Excel.Visible = Excel.XlSheetVisibility.xlSheetVisible
    '                    Hoja_Excel.Activate()
    '                    '
    '                    'fin proceso de generacion
    '                    '
    '                    pagina = 0 : total_paginas = 0
    '                    fila = 1 : CONTADOR_NLA = 0
    '                    MIMPRESION.Revisa_Salto_Por_Encabezado(FILA_MFOL, SALTO_PAGINA, MATRIZ_AUX, NOMTAB)
    '                End If
    '                If GENERA_ARCHIVO = False Then MIMPRESION.Revisa_Salto_Por_Encabezado(FILA_MFOL, SALTO_PAGINA, MATRIZ_AUX, NOMTAB)
    '                If SALTO_PAGINA = True Or CONTADOR_NLA = MAXI_COL Then
    '                    pagina = pagina + 1
    '                    If NOMTAB = "MFOL" Or NOMTAB = "MFRU" Then MIMPRESION.Salto_De_Pagina(total_paginas, Hoja_Excel, pagina, MATRIZ_AUX, fila, Cjto_Resultados1.Tables("DICCIONARIO"), fila_firma, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox27.Text, TextBox28.Text, TextBox31.Text, RadioButton12.Checked, RadioButton2.Checked, NOMTAB, TextBox29.Text)
    '                    If NOMTAB = "MSAL" Then MIMPRESION.Salto_De_Pagina_Suelo(total_paginas, Hoja_Excel, pagina, MATRIZ_AUX, fila, Cjto_Resultados1.Tables("DICCIONARIO"), fila_firma, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox27.Text, TextBox28.Text, TextBox31.Text, RadioButton12.Checked, RadioButton2.Checked, NOMTAB, TextBox29.Text)
    '                    If NOMTAB = "MSUE" Then MIMPRESION.Salto_De_Pagina_Suelo(total_paginas, Hoja_Excel, pagina, MATRIZ_AUX, fila, Cjto_Resultados1.Tables("DICCIONARIO"), fila_firma, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox27.Text, TextBox28.Text, TextBox31.Text, RadioButton12.Checked, RadioButton2.Checked, NOMTAB, TextBox29.Text)
    '                    If NOMTAB = "MAGU" Then MIMPRESION.Salto_De_Pagina_Agua(total_paginas, Hoja_Excel, pagina, MATRIZ_AUX, fila, Cjto_Resultados1.Tables("DICCIONARIO"), fila_firma, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox27.Text, TextBox28.Text, TextBox31.Text, RadioButton12.Checked, RadioButton2.Checked, NOMTAB, TextBox29.Text)
    '                    If NOMTAB = "MNEM" Then MIMPRESION.Salto_De_Pagina_Nema(total_paginas, Hoja_Excel, pagina, MATRIZ_AUX, fila, Cjto_Resultados1.Tables("DICCIONARIO"), fila_firma, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), TextBox20.Text, TextBox21.Text, TextBox22.Text, TextBox27.Text, TextBox28.Text, TextBox31.Text, RadioButton12.Checked, RadioButton2.Checked, NOMTAB, TextBox29.Text)
    '                    CONTADOR_NLA = 1
    '                    SALTO_PAGINA = True
    '                End If
    '                If SALTO_PAGINA = True Then
    '                    If GENERA_ARCHIVO = False Then
    '                        If NOMTAB = "MFOL" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                            Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '                            Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                        End If
    '                        If NOMTAB = "MFRU" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '                            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                        End If
    '                        If NOMTAB = "MSAL" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                            Hoja_Excel.Range("CS" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '                            Hoja_Excel.Range("CS" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                        End If
    '                        If NOMTAB = "MSUE" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                        End If
    '                        If NOMTAB = "MAGU" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                            Hoja_Excel.Range("CL" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '                        End If
    '                        If NOMTAB = "MNEM" Then
    '                            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                            'Hoja_Excel.Range("CL" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '                            'Hoja_Excel.Range("CL" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '                        End If
    '                        If NOMTAB = "MAGU" Then
    '                            MIMPRESION.notas_ce(Hoja_Excel, fila_fin, Cjto_Resultados1.Tables("RANGO_AGUA_CE"), not1, not2, not3, not4)
    '                        Else
    '                            MIMPRESION.notas_automaticas(especie, Hoja_Excel, fila_fin, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("NOTA_AUTO_RESULTADOS"), not1, not2, not3, not4)
    '                        End If
    '                        ReDim RANGO_CE(3, 2)
    '                    End If
    '                    fila_ini = 0 : fila_fin = 0
    '                    Cjto_Resultados1.Tables("ELEMENTOS").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA_SUELO").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA1").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA_SUELOF").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA2").Clear()
    '                    Cjto_Resultados1.Tables("IMPXHOJA_AGUA").Clear()

    '                    If NOMTAB = "MFOL" Then Call MIMPRESION.Llena_Pasos(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MFOL"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_DBF"), Cjto_Resultados1.Tables("IMPXHOJA1"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    If NOMTAB = "MFRU" Then Call MIMPRESION.Llena_Pasos_Frutos(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MFRU"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_DBF"), Cjto_Resultados1.Tables("IMPXHOJA1"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    If NOMTAB = "MSAL" Then Call MIMPRESION.Llena_Pasos_Suelo(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MSAL"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELO"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_SUELO"), Cjto_Resultados1.Tables("IMPXHOJA1"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    If NOMTAB = "MSUE" Then Call MIMPRESION.Llena_Pasos_Suelo_Fertilidad(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MSUE"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELOF"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_SUELO"), Cjto_Resultados1.Tables("IMPXHOJA2"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    If NOMTAB = "MAGU" Then Call MIMPRESION.Llena_Pasos_Agua(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MAGU"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA_AGUA"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_MUESTRA"), Cjto_Resultados1.Tables("IMPXHOJA1"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                    If NOMTAB = "MNEM" Then Call MIMPRESION.Llena_Pasos_Nema(FILA_MFOL, fila, ULT_NLA, Cjto_Resultados1.Tables("MNEM"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("FORMATO_RESULTADO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELOF"), Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("RANGO_MUESTRA"), Cjto_Resultados1.Tables("IMPXHOJA2"), Cjto_Resultados1.Tables("DICCIONARIO"))
    '                End If
    '                If NOMTAB = "MSUE" Then Fila_Fin_Aux = fila_fin
    '                If NOMTAB = "MFOL" Then MIMPRESION.Imprime_Columna(Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA1"), RadioButton2.Checked)
    '                If NOMTAB = "MFRU" Then MIMPRESION.Imprime_Columna_Frutos(Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA1"), RadioButton2.Checked)
    '                If NOMTAB = "MSAL" Then MIMPRESION.Imprime_Columna_Suelo(Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELO"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA1"), RadioButton2.Checked)
    '                If NOMTAB = "MSUE" Then MIMPRESION.Imprime_Columna_Suelo_Fertilidad(m_Excel, Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELOF"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA2"), RadioButton2.Checked)
    '                If NOMTAB = "MAGU" Then MIMPRESION.Imprime_Columna_Agua(Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA_AGUA"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA1"), RadioButton2.Checked)
    '                If NOMTAB = "MNEM" Then MIMPRESION.Imprime_Columna_Nema(Hoja_Excel, FILA_MFOL, pagina, fila_ini, fila_fin, Cjto_Resultados1.Tables("DICCIONARIO"), Cjto_Resultados1.Tables("IMPXHOJA_SUELOF"), Cjto_Resultados1.Tables("ELEMENTOS"), Cjto_Resultados1.Tables("IMPXHOJA2"), RadioButton2.Checked)
    '                If NOMTAB = "MSUE" And Fila_Fin_Aux > fila_fin Then fila_fin = Fila_Fin_Aux

    '                ULT_NLA = FILA_MFOL("INLA")
    '                If NOMTAB = "MFOL" Then especie = FILA_MFOL("IESP")
    '                If NOMTAB = "MFRU" Then especie = "Frutos"
    '                If NOMTAB = "MSAL" Then especie = "Salinidad"
    '                If NOMTAB = "MSUE" Then especie = "Fertilidad"
    '                If NOMTAB = "MAGU" Then
    '                    If IsDBNull(FILA_MFOL("ICE")) = False Then RANGO_CE(CONTADOR_NLA, 1) = FILA_MFOL("INLA") : RANGO_CE(CONTADOR_NLA, 2) = FILA_MFOL("ICE") Else RANGO_CE(CONTADOR_NLA, 1) = FILA_MFOL("INLA") : RANGO_CE(CONTADOR_NLA, 2) = 0
    '                End If
    '                If NOMTAB = "MNEM" Then especie = "Nemátodos"
    '            End If
    'SALTOBACTER:
    '        Next
    '        If NOMTAB = "MFOL" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '            Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '            Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '        End If
    '        If NOMTAB = "MFRU" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '            'Hoja_Excel.Range("CT" & (fila_ini - 6).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '        End If
    '        If NOMTAB = "MSAL" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '            Hoja_Excel.Range("CS" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '            Hoja_Excel.Range("CS" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '        End If
    '        If NOMTAB = "MAGU" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '            Hoja_Excel.Range("CL" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).Interior.Color = RGB(175, 238, 238)
    '            'Hoja_Excel.Range("CL" & (fila_ini - 5).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '            With Hoja_Excel.Range("CK" & fila_fin + 1.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
    '                .LineStyle = Excel.XlLineStyle.xlContinuous
    '                .Weight = Excel.XlBorderWeight.xlHairline
    '                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
    '            End With
    '        End If
    '        If NOMTAB = "MSUE" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '        End If
    '        If NOMTAB = "MNEM" Then
    '            Hoja_Excel.Range("A" & (fila_ini - 1).ToString & ":DF" & (fila_fin + 1).ToString).BorderAround()
    '        End If
    '        If NOMTAB = "MAGU" Then
    '            MIMPRESION.notas_ce(Hoja_Excel, fila_fin, Cjto_Resultados1.Tables("RANGO_AGUA_CE"), not1, not2, not3, not4)
    '        Else
    '            MIMPRESION.notas_automaticas(especie, Hoja_Excel, fila_fin, Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE"), Cjto_Resultados1.Tables("NOTA_AUTO_RESULTADOS"), not1, not2, not3, not4)
    '        End If
    '        MIMPRESION.IMPRIME_FIRMAS(Hoja_Excel, RadioButton15.Checked, fila_firma, RadioButton14.Checked, RadioButton13.Checked)
    '        MIMPRESION.IMPRIME_NUMERO_PAGINAS(Hoja_Excel, pagina, NOMTAB)
    '        Hoja_Excel.Range("A8").Select()
    '        Call graba_SQL_Nota(NOMTAB)
    '        Try
    '            Call MIMPRESION.control_nombre(PRO, Cjto_Resultados1.Tables("DICCIONARIO"))
    '            If NOMTAB = "MFOL" Then Hoja_Excel.SaveAs("F:\Mis Documentos\2005.Foliar-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & ".xls")
    '            If NOMTAB = "MFRU" Then Hoja_Excel.SaveAs("F:\Mis Documentos\2005.Frutos-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & ".xls")
    '            If NOMTAB = "MSAL" Then Hoja_Excel.SaveAs("F:\Mis Documentos\2005.Suelo-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & " (S).xls")
    '            If NOMTAB = "MSUE" Then Hoja_Excel.SaveAs("F:\Mis Documentos\2005.Suelo-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & " (F).xls")
    '            If NOMTAB = "MAGU" Then Hoja_Excel.SaveAs("F:\Mis Documentos\2005.Agua-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & ".xls")
    '            If NOMTAB = "MNEM" Then Hoja_Excel.SaveAs("F:\Mis Documentos\Labsys prueba 2005.Nematodos-Labsys\" & NLAD_GRABA & NLAH_GRABA & "   " & PRO & ".xls")
    '        Catch ex As Exception
    '            objLibroExcel.Close(False, , )
    '            m_Excel.Quit()
    '        End Try
    '    End Sub
    '    Private Sub notas_automaticas(ByVal esp As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila_fin As Integer)
    '        Dim FILA_NOTA, FILA_HOMO As DataRow
    '        Dim BOLA, BOLA1 As Object
    '        Dim varmer, largoco, k As Integer
    '        BOLA1 = esp
    '        FILA_HOMO = Cjto_Resultados1.Tables("HOMOLOGACION_ESPECIE").Rows.Find(BOLA1)
    '        If Not (FILA_HOMO Is Nothing) Then
    '            esp = FILA_HOMO("ESP_ESPECIE")
    '        End If
    '        BOLA = esp
    '        FILA_NOTA = Cjto_Resultados1.Tables("NOTA_AUTO_RESULTADOS").Rows.Find(BOLA)
    '        If Not (FILA_NOTA Is Nothing) Then
    '            If IsDBNull(FILA_NOTA("DESCRIPCION")) <> True Then
    '                largoco = Len(FILA_NOTA("DESCRIPCION"))
    '                varmer = CInt(largoco / 110)
    '                k = fila_fin + varmer
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString & ":DF" & (fila_fin + 2) + varmer.ToString).Merge()
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString).Value = FILA_NOTA("DESCRIPCION")
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString).Font.Size = 9
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString & ":DF" & (fila_fin + 2) + varmer.ToString).WrapText = True
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString & ":DF" & (fila_fin + 2) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    '                HOJA_EXCEL.Range("A" & (fila_fin + 2).ToString & ":DF" & (fila_fin + 2) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
    '            End If
    '        End If
    '        fila_fin = fila_fin + 1 + varmer
    '        If TextBox11.Text <> "" Then
    '            largoco = Len(TextBox11.Text)
    '            varmer = CInt(largoco / 110)
    '            k = fila_fin + varmer
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).Merge()
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Value = TextBox11.Text
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Font.Size = 9
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).WrapText = True
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
    '        End If
    '        fila_fin = fila_fin + 1 + varmer
    '        If TextBox18.Text <> "" Then
    '            largoco = Len(TextBox18.Text)
    '            varmer = CInt(largoco / 110)
    '            k = fila_fin + varmer
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).Merge()
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Value = TextBox18.Text
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Font.Size = 9
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).WrapText = True
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
    '        End If
    '        fila_fin = fila_fin + 1 + varmer
    '        If TextBox19.Text <> "" Then
    '            largoco = Len(TextBox19.Text)
    '            varmer = CInt(largoco / 110)
    '            k = fila_fin + varmer
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).Merge()
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Value = TextBox19.Text
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString).Font.Size = 9
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).WrapText = True
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
    '            HOJA_EXCEL.Range("A" & (fila_fin + 3).ToString & ":DF" & (fila_fin + 3) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
    '        End If
    '    End Sub


    Public Sub control_nombre(ByRef nomb As String)
        Dim lar, i, j, MyPos, larpal, laracu, dif As Integer
        Dim acumula, cortes, palabra As String
        Dim BOLAI As Object
        Dim FILA_DIC As DataRow
        lar = Len(nomb)
        cortes = " ,.-("
        acumula = "" : j = 0
        For i = 1 To lar
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 And InStr(cortes, Mid(nomb, i, 1)) = 0 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : palabra = palabra + Mid(nomb, i, 1) : GoTo continuar
            MyPos = InStr(cortes, Mid(nomb, i, 1))
            If MyPos > 0 Then
                j = 1
                BOLAI = palabra
                FILA_DIC = Cjto_Tablas1.Tables("DICCIONARIO").Rows.Find(BOLAI)
                If (FILA_DIC Is Nothing) Then
                    acumula = acumula & Mid(cortes, MyPos, 1)
                    palabra = ""
                    GoTo continuar
                Else
                    larpal = Len(palabra)
                    laracu = Len(acumula)
                    dif = laracu - larpal
                    acumula = Mid(acumula, 1, dif) & LCase(palabra) & Mid(cortes, MyPos, 1)
                    palabra = ""
                    GoTo continuar
                End If
            End If
            acumula = acumula & LCase(Mid(nomb, i, 1))
            palabra = palabra + Mid(nomb, i, 1)
continuar:
        Next
        nomb = acumula
    End Sub

    Public Sub IMPRIME_NUMERO_PAGINAS(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal pag As Integer)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin, pos_pag As Integer
        Dim junto As String
        ult_fin = pag - 1
        If NOMTAB = 1000 Or NOMTAB = 2000 Then pos_pag = 16
        If NOMTAB = 3000 Then pos_pag = 12
        If NOMTAB = 4000 Then pos_pag = 15
        If NOMTAB = 5000 Then pos_pag = 12
        If NOMTAB = 6000 Then pos_pag = 12
        If NOMTAB = 7000 Then pos_pag = 12
        For jy = 1 To pag
            If jy = 1 Then filP = pos_pag
            If jy <> 1 Then filP = pos_pag + (Filas_Pagina * (jy - 1))
            junto = CStr(jy & "/" & pag)
            'HOJA_EXCEL.Range("DD" & filP.ToString & ":DF" & filP.ToString).NumberFormat = "Texto"
            HOJA_EXCEL.Range("DC" & filP.ToString).Value = "'" & CStr(junto)
            HOJA_EXCEL.Range("DC" & filP.ToString).Font.Size = 7
            HOJA_EXCEL.Range("DC" & filP.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignGeneral
            HOJA_EXCEL.Range("DC" & filP.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        Next
    End Sub

#Region " Notas "

    Public Sub Notas_Automaticas(ByVal esp As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal fila_fin As Integer)
        Dim FILA_NOTA, FILA_HOMO As DataRow
        Dim BOLA, BOLA1 As Object
        Dim varmer, largoco, k As Integer
        BOLA = esp
        FILA_NOTA = Cjto_Tablas1.Tables("NOTA_AUTO_RESULTADOS").Rows.Find(BOLA)

        If Not (FILA_NOTA Is Nothing) Then
            If IsDBNull(FILA_NOTA("DESCRIPCION")) <> True Then
                fila_fin = fila_fin + 1
                largoco = Len(FILA_NOTA("DESCRIPCION"))
                varmer = CInt(largoco / 110)
                k = fila_fin + varmer
                HOJA_EXCEL.Range("A" & (fila_fin).ToString & ":DF" & (fila_fin) + varmer.ToString).Merge()
                HOJA_EXCEL.Range("A" & (fila_fin).ToString).Value = FILA_NOTA("DESCRIPCION")
                HOJA_EXCEL.Range("A" & (fila_fin).ToString).Font.Size = 9
                HOJA_EXCEL.Range("A" & (fila_fin).ToString & ":DF" & (fila_fin) + varmer.ToString).WrapText = True
                HOJA_EXCEL.Range("A" & (fila_fin).ToString & ":DF" & (fila_fin) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                HOJA_EXCEL.Range("A" & (fila_fin).ToString & ":DF" & (fila_fin) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            End If
        End If

        fila_fin = fila_fin + 1 + varmer

        'If TxtObs1.Text <> "" Then
        '    largoco = Len(TxtObs1.Text)
        '    varmer = CInt(largoco / 110)
        '    k = fila_fin + varmer
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).Merge()
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Value = TxtObs1.Text
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Font.Size = 9
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).WrapText = True
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'End If

        'fila_fin = fila_fin + 1 + varmer

        'If TxtObs2.Text <> "" Then
        '    largoco = Len(TxtObs2.Text)
        '    varmer = CInt(largoco / 110)
        '    k = fila_fin + varmer
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).Merge()
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Value = TxtObs2.Text
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Font.Size = 9
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).WrapText = True
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'End If

        'fila_fin = fila_fin + 1 + varmer

        'If TxtObs3.Text <> "" Then
        '    largoco = Len(TxtObs3.Text)
        '    varmer = CInt(largoco / 110)
        '    k = fila_fin + varmer
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).Merge()
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Value = TxtObs3.Text
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Font.Size = 9
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).WrapText = True
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'End If

        'fila_fin = fila_fin + 1 + varmer

        'If TxtObs4.Text <> "" Then
        '    largoco = Len(TxtObs4.Text)
        '    varmer = CInt(largoco / 110)
        '    k = fila_fin + varmer
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).Merge()
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Value = TxtObs4.Text
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString).Font.Size = 9
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).WrapText = True
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        '    HOJA_EXCEL.Range("A" & (fila_fin + 1).ToString & ":DF" & (fila_fin + 1) + varmer.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
        'End If

        'fila_fin = fila_fin + 1 + varmer

    End Sub

#End Region


    Private Sub Frm_Emision_Resultados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CargaDefault()
    End Sub
    Private Sub CargaDefault()
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim FInforme As Date
        Dim CantMuePag As Integer
        FInforme = Today
        FInforme = Format(FInforme, "dd-MM-yyyy")
        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 3000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 3, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 3600, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With



        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With


        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 4500, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With


        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 3, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", 8000, SqlDbType.Int)
            .AgregarParametro("@Posicion", "V", SqlDbType.NVarChar)
            .AgregarParametro("@Logo", "S", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre1", "Rosa Espinoza Astudillo", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo1", "Jefe Laboratorio", SqlDbType.NVarChar)
            .AgregarParametro("@Nombre2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Cargo2", "", SqlDbType.NVarChar)
            .AgregarParametro("@Rango", "1", SqlDbType.NVarChar)
            .AgregarParametro("@Fecha_Informe", FInforme, SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Ingreso", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Muestra_Pagina", 4, SqlDbType.Int)
            .AgregarParametro("@Fecha_Analisis", "01-01-1900", SqlDbType.DateTime)
            .AgregarParametro("@Fecha_Termino", "01-01-1900", SqlDbType.DateTime)
            .EjecutarQuery("usp_UpdateResultadosConfiguracion")
        End With

    End Sub
    Private Sub BTSalirFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalirFoliar.Click, CmdSalirTejidos.Click, CmdSalirAgua.Click, CmdSalirSueloFer.Click, CmdSalirOtros.Click, CmdSalirFertQui.Click
        Me.Close()
    End Sub

    Private Sub BTImprimeFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Genera_Impresion(Maximo_columnas)
    End Sub

    Private Sub BTBuscarOrdenFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBuscarOrdenFoliar.Click, CmdBuscarOrdenTejidos.Click, CmdBuscarOrdenAgua.Click, CmdBuscarOrdenSueloSal.Click, CmdBuscarOrdenSueloFer.Click, CmdBuscarOrdenOtros.Click, CmdBuscarOrdenFertQui.Click, CmdBuscarOrdenColi.Click, CmdBuscarOrdenNema.Click
        Dim Año As String = CStr(Year(Today))

        Select Case tbcFicha.SelectedTab.Name
            Case "tabFoliar"
                Process.Start("Explorer.exe", "F:\Mis documentos\" & Año & ".Frutos-Labsys")
            Case "tabTejidos"
                Process.Start("Explorer.exe", "F:\Mis Documentos\" & Año & ".Frutos-Labsys")
            Case "tabAgua"
                Process.Start("Explorer.exe", "F:\Mis Documentos\" & Año & ".Agua-Labsys")
            Case "tabSueloFert"
                Process.Start("Explorer.exe", "F:\Mis Documentos\" & Año & ".Suelo-Labsys")
            Case "tabSuelo"
                Process.Start("Explorer.exe", "F:\Mis Documentos\" & Año & ".Suelo-Labsys")
            Case "tabFertOrganico"
                Process.Start("Explorer.exe", "F:\Mis Documentos")
            Case "tabFertQuimico"
                Process.Start("Explorer.exe", "F:\Mis Documentos")
            Case "tabOtros"
                Process.Start("Explorer.exe", "F:\Mis Documentos")
        End Select
    End Sub

    Private Sub BTEMailOrdenFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim explorador As Outlook.Explorer
        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim NomPr, CarPr, Via, EmpN, Sww, Año, Ruta As String
        Dim Num_Com, f As Integer

        Año = CStr(Year(Today))

        Select Case tbcFicha.SelectedTab.Name
            Case "tabFoliar"
                Ruta = Año & ".Foliar-Labsys\"
                txtOrdHas = TxtOrdHasFoliar
                txtNomArch = TxtNomArchFoliar
                txtNomProd = TxtNomProdArchivoFoliar
            Case "tabTejidos"
                Ruta = Año & ".Frutos-Labsys\"
                txtOrdHas = TxtOrdHasTejidos
                txtNomArch = TxtNomArchTejidos
                txtNomProd = TxtNomProdArchivoTejidos
            Case "tabAgua"
                Ruta = Año & ".Agua-Labsys\"
                txtOrdHas = TxtOrdHasAgua
                txtNomArch = TxtNomArchAgua
                txtNomProd = TxtNomProdArchivoAgua
            Case "tabSueloFer"
                Ruta = Año & ".Suelo-Labsys\"
                txtOrdHas = TxtOrdHasSueloFer
                txtNomArch = TxtNomArchSueloFer
                txtNomProd = TxtNomProdArchivoSueloFer
            Case "tabSueloSal"
                Ruta = Año & ".Suelo-Labsys\"
                txtOrdHas = TxtOrdHasSueloSal
                txtNomArch = TxtNomArchSueloSal
                txtNomProd = TxtNomProdArchivoSueloSal
            Case "tabFertOrganico"
                Ruta = ""
                txtOrdHas = TxtOrdHasFertOrgFis
                txtNomArch = TxtNomArchFertOrgFis
                txtNomProd = TxtNomProdArchivoFertOrgFis
            Case "tabFertQuimico"
                Ruta = ""
                txtOrdHas = TxtOrdHasFertQui
                txtNomArch = TxtNomArchFertQui
                txtNomProd = TxtNomProdArchivoFertQui
            Case "tabOtros"
                Ruta = ""
                txtOrdHas = TxtOrdHasOtros
                txtNomArch = TxtNomArchOtros
                txtNomProd = TxtNomProdArchivoOtros
        End Select
        Via = "" : Sww = "N"
        For f = 1 To Len(NomPr)
            CarPr = Mid(NomPr, f, 1)
            If CarPr = "." Then CarPr = " "
            Via = Via + CarPr
        Next
        Num_Com = Val(txtOrdHas.Text)
        mOutLookApp = New Outlook.Application
        mNameSpace = mOutLookApp.GetNamespace("MAPI")
        mItem = mOutLookApp.CreateItem(0)
        mItem.To = "" 'EMAIL
        mItem.Subject = "Resultados Agrolab Ltda."
        mItem.Body = "Señor(es):" & Chr(13) & Chr(13) & _
                     "Adjunto resultados de análisis foliares del productor " & NOMBRE_PROD & Chr(13) & _
                     "Atentamente," & Chr(13) & Chr(13) & _
                     "Agrolab Ltda." & Chr(13) & Chr(13) & _
                     "Fono   :(02) 225 8087" & Chr(13) & _
                     "e-mail : laboratorio@agrolab.cl" & Chr(13) & _
                     "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
        colAttach = mItem.Attachments
        l_Attach = colAttach.Add("F:\Mis Documentos\LabSys-Pruebas\" & Ruta & NLAD & NLAH & "   " & NOMBRE_PROD & ".xls")
        txtNomArch.Text = ""
        txtNomProd.Text = ""
        mItem.Display()
    End Sub

    Private Sub BTEMailArchivoFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEMailArchivoFoliar.Click, CmdEMailArchivoTejidos.Click, CmdEMailArchivoAgua.Click, CmdEMailArchivoSueloFer.Click, CmdEMailArchivoOtros.Click, CmdEMailArchivoFertQui.Click
        Dim explorador As Outlook.Explorer
        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim NomPr, CarPr, Via, EmpN, Sww, Año, Ruta, NomArch As String
        Dim Num_Com, f As Integer
        Try
            Año = CStr(Year(Today))

            Select Case tbcFicha.SelectedTab.Name
                Case "tabFoliar"
                    Ruta = Año & ".Foliar-Labsys\"
                    txtOrdHas = TxtOrdHasFoliar
                    txtNomArch = TxtNomArchFoliar
                    txtNomProd = TxtNomProdArchivoFoliar
                Case "tabTejidos"
                    Ruta = Año & ".Frutos-Labsys\"
                    txtOrdHas = TxtOrdHasTejidos
                    txtNomArch = TxtNomArchTejidos
                    txtNomProd = TxtNomProdArchivoTejidos
                Case "tabAgua"
                    Ruta = Año & ".Agua-Labsys\"
                    txtOrdHas = TxtOrdHasAgua
                    txtNomArch = TxtNomArchAgua
                    txtNomProd = TxtNomProdArchivoAgua
                Case "tabSueloFer"
                    Ruta = Año & ".Suelo-Labsys\"
                    txtOrdHas = TxtOrdHasSueloFer
                    txtNomArch = TxtNomArchSueloFer
                    txtNomProd = TxtNomProdArchivoSueloFer
                Case "tabSueloSal"
                    Ruta = Año & ".Suelo-Labsys\"
                    txtOrdHas = TxtOrdHasSueloSal
                    txtNomArch = TxtNomArchSueloSal
                    txtNomProd = TxtNomProdArchivoSueloSal
                Case "tabFertOrganico"
                    Ruta = ""
                    txtOrdHas = TxtOrdHasFertOrgFis
                    txtNomArch = TxtNomArchFertOrgFis
                    txtNomProd = TxtNomProdArchivoFertOrgFis
                Case "tabFertQuimico"
                    Ruta = ""
                    txtOrdHas = TxtOrdHasFertQui
                    txtNomArch = TxtNomArchFertQui
                    txtNomProd = TxtNomProdArchivoFertQui
                Case "tabOtros"
                    Ruta = ""
                    txtOrdHas = TxtOrdHasOtros
                    txtNomArch = TxtNomArchOtros
                    txtNomProd = TxtNomProdArchivoOtros
            End Select
            Via = "" : Sww = "N"
            For f = 1 To Len(NomPr)
                CarPr = Mid(NomPr, f, 1)
                If CarPr = "." Then CarPr = " "
                Via = Via + CarPr
            Next
            '        Num_Com = Val(txtOrdHas.Text)
            mOutLookApp = New Outlook.Application
            mNameSpace = mOutLookApp.GetNamespace("MAPI")
            mItem = mOutLookApp.CreateItem(0)
            mItem.To = "" 'EMAIL
            mItem.Subject = "Resultados Agrolab Ltda."
            With ofdCorreos
                .Filter = "Archivos de resultados|*.xls"
                .InitialDirectory = "F:\Mis Documentos\" & Ruta
                .FileName = "27"
                .ShowDialog()
                NomArch = .FileName
                txtNomArch.Text = Mid(.FileName, Len(.InitialDirectory) + 1)
                .Reset()
            End With
            NOMBRE_PROD = Mid(txtNomProd.Text, 1, Len(txtNomProd.Text) - 4)
            mItem.Body = "Señor(es):" & Chr(13) & Chr(13) & _
                         "Adjunto resultados de análisis foliares del productor " & NOMBRE_PROD & Chr(13) & _
                         "Atentamente," & Chr(13) & Chr(13) & _
                         "Agrolab Ltda." & Chr(13) & Chr(13) & _
                         "Fono   :(02) 225 8087" & Chr(13) & _
                         "e-mail : laboratorio@agrolab.cl" & Chr(13) & _
                         "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
            colAttach = mItem.Attachments
            'l_Attach = colAttach.Add("F:\Mis Documentos\" & Ruta & NLADE & NLAHA & "   " & NOMBRE_PROD & ".xls")
            l_Attach = colAttach.Add(NomArch)
            txtNomArch.Text = ""
            txtNomProd.Text = ""
            mItem.Display()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtNomArchFoliar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtNomArchFoliar.TextChanged, TxtNomArchTejidos.TextChanged, TxtNomArchAgua.TextChanged, TxtNomArchOtros.TextChanged, TxtNomArchSueloFer.TextChanged, TxtNomArchFertQui.TextChanged, TxtNomArchColi.TextChanged, TxtNomArchNema.TextChanged
        Select Case tbcFicha.SelectedTab.Name
            Case "tabFoliar"
                txtNomArch = TxtNomArchFoliar
                txtNomProd = TxtNomProdArchivoFoliar
            Case "tabTejidos"
                txtNomArch = TxtNomArchTejidos
                txtNomProd = TxtNomProdArchivoTejidos
            Case "tabAgua"
                txtNomArch = TxtNomArchAgua
                txtNomProd = TxtNomProdArchivoAgua
            Case "tabBactereologicos"
                txtNomArch = TxtNomArchColi
                txtNomProd = TxtNomProdArchivoColi
            Case "tabSueloFer"
                txtNomArch = TxtNomArchSueloFer
                txtNomProd = TxtNomProdArchivoSueloFer
            Case "tabSuelo"
                txtNomArch = TxtNomArchSueloSal
                txtNomProd = TxtNomProdArchivoSueloSal
            Case "tabFertOrganico"
                txtNomArch = TxtNomArchFertOrgFis
                txtNomProd = TxtNomProdArchivoFertOrgFis
            Case "tabFertQuimico"
                txtNomArch = TxtNomArchFertQui
                txtNomProd = TxtNomProdArchivoFertQui
            Case "tabOtros"
                txtNomArch = TxtNomArchOtros
                txtNomProd = TxtNomProdArchivoOtros
            Case "tabNematodos"
                txtNomArch = TxtNomArchNema
                txtNomProd = TxtNomProdArchivoNema
        End Select
        txtNomProd.Text = Trim(Mid(txtNomArch.Text, 13))
    End Sub

    Private Sub CmdConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConsultaFoliar.Click, CmdConsultaTejidos.Click, CmdConsultaAgua.Click, CmdConsultaSueloFer.Click, CmdConsultaSueloSal.Click, CmdConsultaOtros.Click, CmdConsultaFertQui.Click, CmdConfiguraColi.Click, CmdConsultaNema.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim VueltaMuestra As Integer
        Orden_Trabajo = 0
        If Orden_Trabajo <> 0 Then MsgBox("Ingresando Orden de Trabajo Consulte en otra Instancia") : GoTo NoMuestra
        Tipo_Ingreso_OT = "Resultados"
        If sender Is CmdConsultaFoliar Then ResultadosMuestrayOrden = 1000 : VueltaMuestra = 1000
        If sender Is CmdConsultaTejidos Then ResultadosMuestrayOrden = 2000 : VueltaMuestra = 2000
        If sender Is CmdConsultaAgua Then ResultadosMuestrayOrden = 3000 : VueltaMuestra = 3000
        If sender Is CmdConsultaSueloFer Then ResultadosMuestrayOrden = 4000 : VueltaMuestra = 4000
        If sender Is CmdConsultaSueloSal Then ResultadosMuestrayOrden = 4500 : VueltaMuestra = 4500
        If sender Is CmdConsultaFertQui Then ResultadosMuestrayOrden = 5000 : VueltaMuestra = 5000
        If sender Is CmdConsultaFertOrgFis Then ResultadosMuestrayOrden = 6000 : VueltaMuestra = 6000

        If sender Is CmdConsultaOtros Then ResultadosMuestrayOrden = 7000 : VueltaMuestra = 7000

        Dim Form_Aux As New F_ModificaOT : Form_Aux.ShowDialog()
        Form_Aux = Nothing

        If VueltaMuestra = 1000 Then
            TxtOrdDesFoliar.Text = ResultadosMuestrayOrden
            TxtLabDesFoliar.Text = ResultadosNLab
            TxtLabHasFoliar.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 2000 Then
            TxtOrdDesTejidos.Text = ResultadosMuestrayOrden
            TxtLabDesTejidos.Text = ResultadosNLab
            TxtLabHasTejidos.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 3000 Then
            TxtOrdDesAgua.Text = ResultadosMuestrayOrden
            TxtLabDesAgua.Text = ResultadosNLab
            TxtLabHasAgua.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 4000 Then
            TxtOrdDesSueloFer.Text = ResultadosMuestrayOrden
            TxtLabDesSueloFer.Text = ResultadosNLab
            TxtLabHasSueloFer.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 4500 Then
            TxtOrdDesSueloSal.Text = ResultadosMuestrayOrden
            TxtLabDesSueloSal.Text = ResultadosNLab
            TxtLabHasSueloSal.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 5000 Then
            TxtOrdDesFertQui.Text = ResultadosMuestrayOrden
            TxtLabDesFertQui.Text = ResultadosNLab
            TxtLabHasFertQui.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 6000 Then
            TxtOrdDesFertOrgFis.Text = ResultadosMuestrayOrden
            TxtLabDesFertOrgFis.Text = ResultadosNLab
            TxtLabHasFertOrgFis.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        If VueltaMuestra = 7000 Then
            TxtOrdDesOtros.Text = ResultadosMuestrayOrden
            TxtLabDesOtros.Text = ResultadosNLab
            TxtLabHasOtros.Text = (ResultadosNLab + (ResultadosCantidad - 1))
        End If

        With SP
            .Inicializar()
            .AgregarParametro("@TMuestra", VueltaMuestra, SqlDbType.Int)
            .AgregarParametro("@NumOt", ResultadosMuestrayOrden, SqlDbType.Int)
            .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
        End With
NoMuestra:
    End Sub

    Private Sub CmdConfiguraFoliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdConfiguraFoliar.Click, CmdConfiguraTejidos.Click, CmdConfiguraAgua.Click, CmdConfiguraSueloFer.Click, CmdConfiguraSueloSal.Click, CmdConfiguraOtros.Click, CmdConfiguraFertQui.Click, CmdConfiguraFertOrgFis.Click, CmdConfiguraColi.Click, CmdConfiguraNema.Click
        If sender Is CmdConfiguraFoliar Then ResultadosMuestrayOrden = 1000
        If sender Is CmdConfiguraTejidos Then ResultadosMuestrayOrden = 2000
        If sender Is CmdConfiguraAgua Then ResultadosMuestrayOrden = 3000
        If sender Is CmdConfiguraColi Then ResultadosMuestrayOrden = 3600

        If sender Is CmdConfiguraSueloFer Then ResultadosMuestrayOrden = 4000
        If sender Is CmdConfiguraSueloSal Then ResultadosMuestrayOrden = 4500
        If sender Is CmdConfiguraFertQui Then ResultadosMuestrayOrden = 5000
        If sender Is CmdConfiguraFertOrgFis Then ResultadosMuestrayOrden = 6000
        If sender Is CmdConfiguraOtros Then ResultadosMuestrayOrden = 7000
        If sender Is CmdConfiguraNema Then ResultadosMuestrayOrden = 8000
        Dim Form_Aux As New Frm_Resultados_Configuracion : Form_Aux.ShowDialog()
        Form_Aux = Nothing
    End Sub

    Private Sub CmdNotas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNotasFoliar.Click, CmdNotasTejidos.Click, CmdNotasAgua.Click, CmdNotasSueloFer.Click, CmdNotasSueloSal.Click, CmdNotasOtros.Click, CmdNotasFertQui.Click, CmdNotasFertOrgFis.Click, CmdNotasColi.Click, CmdNotasNema.Click
        If sender Is CmdNotasFoliar Then ResultadosMuestrayOrden = 1000
        If sender Is CmdNotasTejidos Then ResultadosMuestrayOrden = 2000
        If sender Is CmdNotasAgua Then ResultadosMuestrayOrden = 3000
        If sender Is CmdNotasColi Then ResultadosMuestrayOrden = 3600
        If sender Is CmdNotasSueloFer Then ResultadosMuestrayOrden = 4000
        If sender Is CmdNotasSueloSal Then ResultadosMuestrayOrden = 4500
        If sender Is CmdNotasFertQui Then ResultadosMuestrayOrden = 5000
        If sender Is CmdNotasFertOrgFis Then ResultadosMuestrayOrden = 6000
        If sender Is CmdNotasOtros Then ResultadosMuestrayOrden = 7000
        If sender Is CmdNotasNema Then ResultadosMuestrayOrden = 8000

        Dim Form_Aux As New Frm_Resultados_Notas : Form_Aux.ShowDialog()
        Form_Aux = Nothing
    End Sub

    Private Sub TxtOrdDesFoliar_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesFoliar.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 1000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesTejido_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesTejidos.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 2000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesAgua_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesAgua.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", NOMTAB, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesSueloFer_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesSueloFer.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 4000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesSueloSal_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesSueloSal.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 4500, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesFertQui_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesFertQui.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 5000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesFertOrgFis_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesFertOrgFis.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 6000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TxtOrdDesOtros_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesOtros.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 7000, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub TxtOrdDesNema_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtOrdDesNema.LostFocus
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With SP
                .Inicializar()
                .AgregarParametro("@TMuestra", 8758, SqlDbType.Int)
                .AgregarParametro("@NumOt", CInt(txtOrdDes.Text), SqlDbType.Int)
                .EjecutarQuery("usp_UpdateResultadosFechaIngreso")
            End With
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CmdSalirNema_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSalirNema.Click
        Me.Close()
    End Sub

End Class
