Public Class Form1
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents Cjto_Tablas1 As Cjto_Tablas
    Friend WithEvents Dtg_Inicio As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lb_Deuda As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cob_Solicita As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_Nota1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_Nota2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Lb_Cob_Deuda As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Dtg_Cobranza As System.Windows.Forms.DataGrid
    Friend WithEvents Txt_Cob_FonoPago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_EncPago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_Obs As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_SolEmail As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_SolCelular As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_SolFono As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cob_CondPago As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cob_OCompra As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Dtp_FechaProp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_FechaProp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bt_Cob_Grabar As System.Windows.Forms.Button
    Friend WithEvents Bt_Cob_Limpiar As System.Windows.Forms.Button
    Friend WithEvents Dtg_CambioEstado As System.Windows.Forms.DataGrid
    Friend WithEvents Bt_Cob_Actualiza As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Txt_Cob_Buscar As System.Windows.Forms.TextBox
    Friend WithEvents Bt_CEst_Actualiza As System.Windows.Forms.Button
    Friend WithEvents Dtg_Morosos As System.Windows.Forms.DataGrid
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Txt_Mor_Email As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Mor_Fono As System.Windows.Forms.TextBox
    Friend WithEvents Chk_EnvCarta As System.Windows.Forms.CheckBox
    Friend WithEvents Bt_Mor_Grabar As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
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
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Txt_Mor_Deuda As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Mor_Atencion As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Txt_Mor_RSocial As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Txt_Llamar_el As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CmdAsignados As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn50 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn51 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn55 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn57 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn59 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn60 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn61 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn62 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn63 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtClave As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Dtg_FacturasNoAsignas As System.Windows.Forms.DataGrid
    Friend WithEvents DTPFechaAsigna As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridTextBoxColumn64 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn65 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn66 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn67 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Txt_Factura As System.Windows.Forms.TextBox
    Friend WithEvents RdbMoroso As System.Windows.Forms.RadioButton
    Friend WithEvents BTAceptaCambio As System.Windows.Forms.Button
    Friend WithEvents Txt_Nota1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Nota2 As System.Windows.Forms.TextBox
    Friend WithEvents RdbJudicial As System.Windows.Forms.RadioButton
    Friend WithEvents RdbIncobrable As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTextBoxColumn68 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents RdbMorosoJudi As System.Windows.Forms.RadioButton
    Friend WithEvents RdbMorosoInco As System.Windows.Forms.RadioButton
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Txt_Moroso_factura As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Moroso_Nota1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Moroso_Nota2 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn69 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn70 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Dtg_Inicio = New System.Windows.Forms.DataGrid
        Me.Cjto_Tablas1 = New LabSys.Cjto_Tablas
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn64 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Txt_Cob_Buscar = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Bt_Cob_Actualiza = New System.Windows.Forms.Button
        Me.Lb_Deuda = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Txt_Llamar_el = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Bt_Cob_Limpiar = New System.Windows.Forms.Button
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Txt_Cob_OCompra = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txt_Cob_CondPago = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txt_Cob_Obs = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Bt_Cob_Grabar = New System.Windows.Forms.Button
        Me.Dtp_FechaProp2 = New System.Windows.Forms.DateTimePicker
        Me.Dtp_FechaProp1 = New System.Windows.Forms.DateTimePicker
        Me.Txt_Cob_FonoPago = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txt_Cob_EncPago = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Lb_Cob_Deuda = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Txt_Cob_Nota2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Txt_Cob_Nota1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Txt_Cob_SolEmail = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Txt_Cob_SolCelular = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Txt_Cob_SolFono = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Txt_Cob_Solicita = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Dtg_Cobranza = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn65 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.RdbMorosoJudi = New System.Windows.Forms.RadioButton
        Me.RdbMorosoInco = New System.Windows.Forms.RadioButton
        Me.Txt_Moroso_factura = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label35 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Txt_Moroso_Nota2 = New System.Windows.Forms.TextBox
        Me.Txt_Moroso_Nota1 = New System.Windows.Forms.TextBox
        Me.Txt_Mor_Atencion = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Txt_Mor_Deuda = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Txt_Mor_Email = New System.Windows.Forms.TextBox
        Me.Txt_Mor_RSocial = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Txt_Mor_Fono = New System.Windows.Forms.TextBox
        Me.Dtg_Morosos = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn68 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Bt_Mor_Grabar = New System.Windows.Forms.Button
        Me.Chk_EnvCarta = New System.Windows.Forms.CheckBox
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.BTAceptaCambio = New System.Windows.Forms.Button
        Me.RdbJudicial = New System.Windows.Forms.RadioButton
        Me.RdbIncobrable = New System.Windows.Forms.RadioButton
        Me.RdbMoroso = New System.Windows.Forms.RadioButton
        Me.Txt_Factura = New System.Windows.Forms.TextBox
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.Txt_Nota2 = New System.Windows.Forms.TextBox
        Me.Txt_Nota1 = New System.Windows.Forms.TextBox
        Me.Bt_CEst_Actualiza = New System.Windows.Forms.Button
        Me.Dtg_CambioEstado = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
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
        Me.DataGridTextBoxColumn69 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn70 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.Label29 = New System.Windows.Forms.Label
        Me.TxtClave = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.DTPFechaAsigna = New System.Windows.Forms.DateTimePicker
        Me.CmdAsignados = New System.Windows.Forms.ComboBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn57 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn67 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn59 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn60 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn61 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn62 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn63 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Dtg_FacturasNoAsignas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn66 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn50 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn51 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn55 = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.Dtg_Inicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_Cobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_Morosos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.Dtg_CambioEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dtg_FacturasNoAsignas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dtg_Inicio
        '
        Me.Dtg_Inicio.CaptionVisible = False
        Me.Dtg_Inicio.DataMember = "COBRANZA"
        Me.Dtg_Inicio.DataSource = Me.Cjto_Tablas1
        Me.Dtg_Inicio.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Inicio.Location = New System.Drawing.Point(8, 16)
        Me.Dtg_Inicio.Name = "Dtg_Inicio"
        Me.Dtg_Inicio.Size = New System.Drawing.Size(1240, 776)
        Me.Dtg_Inicio.TabIndex = 0
        Me.Dtg_Inicio.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Cjto_Tablas1
        '
        Me.Cjto_Tablas1.DataSetName = "Cjto_Tablas"
        Me.Cjto_Tablas1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Cjto_Tablas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Inicio
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn64, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "COBRANZA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "NºFactura"
        Me.DataGridTextBoxColumn1.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "F.Emisión"
        Me.DataGridTextBoxColumn2.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "Llamar el"
        Me.DataGridTextBoxColumn42.MappingName = "FAC_FECHA_LLAMAR"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.ReadOnly = True
        Me.DataGridTextBoxColumn42.Width = 70
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn3.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn4.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = "####,###"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Monto"
        Me.DataGridTextBoxColumn5.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = "####,###"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Abono"
        Me.DataGridTextBoxColumn6.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = "####,###"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn7.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn8.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 200
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "RUT"
        Me.DataGridTextBoxColumn9.MappingName = "FAC_RUT"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn64
        '
        Me.DataGridTextBoxColumn64.Format = ""
        Me.DataGridTextBoxColumn64.FormatInfo = Nothing
        Me.DataGridTextBoxColumn64.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn64.MappingName = "FAC_EMPRESA"
        Me.DataGridTextBoxColumn64.NullText = ""
        Me.DataGridTextBoxColumn64.Width = 140
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "N1"
        Me.DataGridTextBoxColumn10.MappingName = "FAC_NOTA_COBRANZA"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 20
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "N2"
        Me.DataGridTextBoxColumn11.MappingName = "FAC_NOTA_COBRANZA2"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 20
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "Asignada"
        Me.DataGridTextBoxColumn44.MappingName = "FAC_ASIGNADA"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.ReadOnly = True
        Me.DataGridTextBoxColumn44.Width = 80
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn45.Format = ""
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.HeaderText = "Fecha Asignada"
        Me.DataGridTextBoxColumn45.MappingName = "FAC_FECHA_ASIGNADA"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.ReadOnly = True
        Me.DataGridTextBoxColumn45.Width = 85
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(0, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1264, 904)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage1.Controls.Add(Me.Txt_Cob_Buscar)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.Bt_Cob_Actualiza)
        Me.TabPage1.Controls.Add(Me.Lb_Deuda)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Dtg_Inicio)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1256, 877)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Inicio"
        '
        'Txt_Cob_Buscar
        '
        Me.Txt_Cob_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_Buscar.Location = New System.Drawing.Point(328, 816)
        Me.Txt_Cob_Buscar.Name = "Txt_Cob_Buscar"
        Me.Txt_Cob_Buscar.Size = New System.Drawing.Size(104, 20)
        Me.Txt_Cob_Buscar.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label16.Location = New System.Drawing.Point(264, 816)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 23)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Buscar :"
        '
        'Bt_Cob_Actualiza
        '
        Me.Bt_Cob_Actualiza.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Cob_Actualiza.Image = Global.LabSys.My.Resources.Resources.arrow_refresh_small
        Me.Bt_Cob_Actualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Cob_Actualiza.Location = New System.Drawing.Point(816, 816)
        Me.Bt_Cob_Actualiza.Name = "Bt_Cob_Actualiza"
        Me.Bt_Cob_Actualiza.Size = New System.Drawing.Size(78, 23)
        Me.Bt_Cob_Actualiza.TabIndex = 3
        Me.Bt_Cob_Actualiza.Text = "Actualizar"
        Me.Bt_Cob_Actualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Cob_Actualiza.UseVisualStyleBackColor = False
        '
        'Lb_Deuda
        '
        Me.Lb_Deuda.BackColor = System.Drawing.Color.Gainsboro
        Me.Lb_Deuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Deuda.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Deuda.Location = New System.Drawing.Point(104, 816)
        Me.Lb_Deuda.Name = "Lb_Deuda"
        Me.Lb_Deuda.Size = New System.Drawing.Size(136, 20)
        Me.Lb_Deuda.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label1.Location = New System.Drawing.Point(8, 816)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Deuda Total :"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Controls.Add(Me.Dtg_Cobranza)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(1256, 878)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Cobranza"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Txt_Llamar_el)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.Bt_Cob_Limpiar)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_OCompra)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_CondPago)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_Obs)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Bt_Cob_Grabar)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaProp2)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaProp1)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_FonoPago)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_EncPago)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Lb_Cob_Deuda)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_Nota2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_Nota1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_SolEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_SolCelular)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_SolFono)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Txt_Cob_Solicita)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1080, 526)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Txt_Llamar_el
        '
        Me.Txt_Llamar_el.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Llamar_el.Location = New System.Drawing.Point(648, 84)
        Me.Txt_Llamar_el.Name = "Txt_Llamar_el"
        Me.Txt_Llamar_el.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Llamar_el.TabIndex = 31
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(576, 85)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 16)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "Llamar el"
        '
        'Bt_Cob_Limpiar
        '
        Me.Bt_Cob_Limpiar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Cob_Limpiar.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Bt_Cob_Limpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Cob_Limpiar.Location = New System.Drawing.Point(760, 467)
        Me.Bt_Cob_Limpiar.Name = "Bt_Cob_Limpiar"
        Me.Bt_Cob_Limpiar.Size = New System.Drawing.Size(68, 23)
        Me.Bt_Cob_Limpiar.TabIndex = 29
        Me.Bt_Cob_Limpiar.Text = "Limpiar"
        Me.Bt_Cob_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Cob_Limpiar.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(696, 331)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 32)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Fecha Propuesta de Cancelación "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(696, 166)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 32)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "Fecha Propuesta de Cancelación "
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Cob_OCompra
        '
        Me.Txt_Cob_OCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_OCompra.Location = New System.Drawing.Point(376, 84)
        Me.Txt_Cob_OCompra.Name = "Txt_Cob_OCompra"
        Me.Txt_Cob_OCompra.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_OCompra.TabIndex = 26
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(306, 85)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "O.Compra"
        '
        'Txt_Cob_CondPago
        '
        Me.Txt_Cob_CondPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_CondPago.Location = New System.Drawing.Point(104, 84)
        Me.Txt_Cob_CondPago.Name = "Txt_Cob_CondPago"
        Me.Txt_Cob_CondPago.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_CondPago.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 85)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Con.Pago"
        '
        'Txt_Cob_Obs
        '
        Me.Txt_Cob_Obs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_Obs.Location = New System.Drawing.Point(104, 110)
        Me.Txt_Cob_Obs.Name = "Txt_Cob_Obs"
        Me.Txt_Cob_Obs.Size = New System.Drawing.Size(424, 20)
        Me.Txt_Cob_Obs.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Observaciones"
        '
        'Bt_Cob_Grabar
        '
        Me.Bt_Cob_Grabar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Cob_Grabar.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Cob_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Cob_Grabar.Location = New System.Drawing.Point(680, 467)
        Me.Bt_Cob_Grabar.Name = "Bt_Cob_Grabar"
        Me.Bt_Cob_Grabar.Size = New System.Drawing.Size(66, 23)
        Me.Bt_Cob_Grabar.TabIndex = 20
        Me.Bt_Cob_Grabar.Text = "Grabar"
        Me.Bt_Cob_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Cob_Grabar.UseVisualStyleBackColor = False
        '
        'Dtp_FechaProp2
        '
        Me.Dtp_FechaProp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaProp2.Location = New System.Drawing.Point(704, 379)
        Me.Dtp_FechaProp2.Name = "Dtp_FechaProp2"
        Me.Dtp_FechaProp2.Size = New System.Drawing.Size(104, 20)
        Me.Dtp_FechaProp2.TabIndex = 19
        '
        'Dtp_FechaProp1
        '
        Me.Dtp_FechaProp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaProp1.Location = New System.Drawing.Point(704, 214)
        Me.Dtp_FechaProp1.Name = "Dtp_FechaProp1"
        Me.Dtp_FechaProp1.Size = New System.Drawing.Size(104, 20)
        Me.Dtp_FechaProp1.TabIndex = 18
        '
        'Txt_Cob_FonoPago
        '
        Me.Txt_Cob_FonoPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_FonoPago.Location = New System.Drawing.Point(648, 58)
        Me.Txt_Cob_FonoPago.Name = "Txt_Cob_FonoPago"
        Me.Txt_Cob_FonoPago.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_FonoPago.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(576, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 16)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "F. Pago"
        '
        'Txt_Cob_EncPago
        '
        Me.Txt_Cob_EncPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_EncPago.Location = New System.Drawing.Point(376, 58)
        Me.Txt_Cob_EncPago.Name = "Txt_Cob_EncPago"
        Me.Txt_Cob_EncPago.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_EncPago.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(306, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Enc.Pago"
        '
        'Lb_Cob_Deuda
        '
        Me.Lb_Cob_Deuda.BackColor = System.Drawing.Color.Gainsboro
        Me.Lb_Cob_Deuda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lb_Cob_Deuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Cob_Deuda.Location = New System.Drawing.Point(104, 137)
        Me.Lb_Cob_Deuda.Name = "Lb_Cob_Deuda"
        Me.Lb_Cob_Deuda.Size = New System.Drawing.Size(112, 20)
        Me.Lb_Cob_Deuda.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Deuda"
        '
        'Txt_Cob_Nota2
        '
        Me.Txt_Cob_Nota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_Nota2.Enabled = False
        Me.Txt_Cob_Nota2.Location = New System.Drawing.Point(104, 331)
        Me.Txt_Cob_Nota2.Multiline = True
        Me.Txt_Cob_Nota2.Name = "Txt_Cob_Nota2"
        Me.Txt_Cob_Nota2.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Cob_Nota2.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 332)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Nota2"
        '
        'Txt_Cob_Nota1
        '
        Me.Txt_Cob_Nota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_Nota1.Enabled = False
        Me.Txt_Cob_Nota1.Location = New System.Drawing.Point(104, 165)
        Me.Txt_Cob_Nota1.Multiline = True
        Me.Txt_Cob_Nota1.Name = "Txt_Cob_Nota1"
        Me.Txt_Cob_Nota1.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Cob_Nota1.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Nota1"
        '
        'Txt_Cob_SolEmail
        '
        Me.Txt_Cob_SolEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_SolEmail.Location = New System.Drawing.Point(104, 58)
        Me.Txt_Cob_SolEmail.Name = "Txt_Cob_SolEmail"
        Me.Txt_Cob_SolEmail.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_SolEmail.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Email"
        '
        'Txt_Cob_SolCelular
        '
        Me.Txt_Cob_SolCelular.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_SolCelular.Location = New System.Drawing.Point(648, 32)
        Me.Txt_Cob_SolCelular.Name = "Txt_Cob_SolCelular"
        Me.Txt_Cob_SolCelular.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_SolCelular.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(576, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Celular"
        '
        'Txt_Cob_SolFono
        '
        Me.Txt_Cob_SolFono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_SolFono.Location = New System.Drawing.Point(376, 32)
        Me.Txt_Cob_SolFono.Name = "Txt_Cob_SolFono"
        Me.Txt_Cob_SolFono.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_SolFono.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(306, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fono"
        '
        'Txt_Cob_Solicita
        '
        Me.Txt_Cob_Solicita.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Cob_Solicita.Location = New System.Drawing.Point(104, 32)
        Me.Txt_Cob_Solicita.Name = "Txt_Cob_Solicita"
        Me.Txt_Cob_Solicita.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Cob_Solicita.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Solicita"
        '
        'Dtg_Cobranza
        '
        Me.Dtg_Cobranza.CaptionVisible = False
        Me.Dtg_Cobranza.DataMember = "COBRANZA_FILTRO"
        Me.Dtg_Cobranza.DataSource = Me.Cjto_Tablas1
        Me.Dtg_Cobranza.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Cobranza.Location = New System.Drawing.Point(8, 16)
        Me.Dtg_Cobranza.Name = "Dtg_Cobranza"
        Me.Dtg_Cobranza.Size = New System.Drawing.Size(1240, 210)
        Me.Dtg_Cobranza.TabIndex = 0
        Me.Dtg_Cobranza.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.Dtg_Cobranza
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn65, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn47})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "COBRANZA_FILTRO"
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "NºFactura"
        Me.DataGridTextBoxColumn12.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 65
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "F.Emisión"
        Me.DataGridTextBoxColumn13.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn43.Format = ""
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.HeaderText = "Llamar el"
        Me.DataGridTextBoxColumn43.MappingName = "FAC_FECHA_LLAMAR"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn14.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn15.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 70
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = "####,###"
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Monto"
        Me.DataGridTextBoxColumn16.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = "####,###"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Abono"
        Me.DataGridTextBoxColumn17.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = "####,###"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn18.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn19.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 200
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "RUT"
        Me.DataGridTextBoxColumn20.MappingName = "FAC_RUT"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 75
        '
        'DataGridTextBoxColumn65
        '
        Me.DataGridTextBoxColumn65.Format = ""
        Me.DataGridTextBoxColumn65.FormatInfo = Nothing
        Me.DataGridTextBoxColumn65.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn65.MappingName = "FAC_EMPRESA"
        Me.DataGridTextBoxColumn65.NullText = ""
        Me.DataGridTextBoxColumn65.Width = 130
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "N1"
        Me.DataGridTextBoxColumn21.MappingName = "FAC_NOTA_COBRANZA"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 20
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "N2"
        Me.DataGridTextBoxColumn22.MappingName = "FAC_NOTA_COBRANZA2"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 20
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "Asignada"
        Me.DataGridTextBoxColumn46.MappingName = "FAC_ASIGNADA"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.ReadOnly = True
        Me.DataGridTextBoxColumn46.Width = 80
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Format = ""
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "Fecha Asignada"
        Me.DataGridTextBoxColumn47.MappingName = "FAC_FECHA_ASIGNADA"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.ReadOnly = True
        Me.DataGridTextBoxColumn47.Width = 85
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.Dtg_Morosos)
        Me.TabPage3.Controls.Add(Me.Bt_Mor_Grabar)
        Me.TabPage3.Controls.Add(Me.Chk_EnvCarta)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1256, 878)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Morosos"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Button3)
        Me.GroupBox4.Controls.Add(Me.RdbMorosoJudi)
        Me.GroupBox4.Controls.Add(Me.RdbMorosoInco)
        Me.GroupBox4.Controls.Add(Me.Txt_Moroso_factura)
        Me.GroupBox4.Controls.Add(Me.Label34)
        Me.GroupBox4.Controls.Add(Me.Label35)
        Me.GroupBox4.Location = New System.Drawing.Point(983, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(232, 193)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Location = New System.Drawing.Point(80, 131)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Cambio Estado"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'RdbMorosoJudi
        '
        Me.RdbMorosoJudi.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMorosoJudi.Location = New System.Drawing.Point(80, 101)
        Me.RdbMorosoJudi.Name = "RdbMorosoJudi"
        Me.RdbMorosoJudi.Size = New System.Drawing.Size(104, 24)
        Me.RdbMorosoJudi.TabIndex = 18
        Me.RdbMorosoJudi.Text = "Judicial"
        '
        'RdbMorosoInco
        '
        Me.RdbMorosoInco.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMorosoInco.Location = New System.Drawing.Point(80, 82)
        Me.RdbMorosoInco.Name = "RdbMorosoInco"
        Me.RdbMorosoInco.Size = New System.Drawing.Size(104, 24)
        Me.RdbMorosoInco.TabIndex = 17
        Me.RdbMorosoInco.Text = "Incobrable"
        '
        'Txt_Moroso_factura
        '
        Me.Txt_Moroso_factura.Location = New System.Drawing.Point(80, 56)
        Me.Txt_Moroso_factura.Name = "Txt_Moroso_factura"
        Me.Txt_Moroso_factura.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Moroso_factura.TabIndex = 15
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(8, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 16)
        Me.Label34.TabIndex = 14
        Me.Label34.Text = "Factura"
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(24, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(176, 16)
        Me.Label35.TabIndex = 13
        Me.Label35.Text = "Cambio de Estado"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Txt_Moroso_Nota2)
        Me.GroupBox2.Controls.Add(Me.Txt_Moroso_Nota1)
        Me.GroupBox2.Controls.Add(Me.Txt_Mor_Atencion)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Txt_Mor_Deuda)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Txt_Mor_Email)
        Me.GroupBox2.Controls.Add(Me.Txt_Mor_RSocial)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Txt_Mor_Fono)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(936, 448)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 252)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Nota2"
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 79)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(64, 16)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Nota1"
        '
        'Txt_Moroso_Nota2
        '
        Me.Txt_Moroso_Nota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Moroso_Nota2.Location = New System.Drawing.Point(80, 251)
        Me.Txt_Moroso_Nota2.Multiline = True
        Me.Txt_Moroso_Nota2.Name = "Txt_Moroso_Nota2"
        Me.Txt_Moroso_Nota2.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Moroso_Nota2.TabIndex = 29
        '
        'Txt_Moroso_Nota1
        '
        Me.Txt_Moroso_Nota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Moroso_Nota1.Location = New System.Drawing.Point(80, 78)
        Me.Txt_Moroso_Nota1.Multiline = True
        Me.Txt_Moroso_Nota1.Name = "Txt_Moroso_Nota1"
        Me.Txt_Moroso_Nota1.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Moroso_Nota1.TabIndex = 28
        '
        'Txt_Mor_Atencion
        '
        Me.Txt_Mor_Atencion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mor_Atencion.Location = New System.Drawing.Point(80, 42)
        Me.Txt_Mor_Atencion.Name = "Txt_Mor_Atencion"
        Me.Txt_Mor_Atencion.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Mor_Atencion.TabIndex = 27
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 43)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 16)
        Me.Label25.TabIndex = 26
        Me.Label25.Text = "Atención"
        '
        'Txt_Mor_Deuda
        '
        Me.Txt_Mor_Deuda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mor_Deuda.Location = New System.Drawing.Point(352, 42)
        Me.Txt_Mor_Deuda.Name = "Txt_Mor_Deuda"
        Me.Txt_Mor_Deuda.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Mor_Deuda.TabIndex = 23
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(282, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 16)
        Me.Label23.TabIndex = 22
        Me.Label23.Text = "Deuda"
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(282, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Fono"
        '
        'Txt_Mor_Email
        '
        Me.Txt_Mor_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mor_Email.Location = New System.Drawing.Point(624, 16)
        Me.Txt_Mor_Email.Name = "Txt_Mor_Email"
        Me.Txt_Mor_Email.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Mor_Email.TabIndex = 11
        '
        'Txt_Mor_RSocial
        '
        Me.Txt_Mor_RSocial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mor_RSocial.Location = New System.Drawing.Point(80, 16)
        Me.Txt_Mor_RSocial.Name = "Txt_Mor_RSocial"
        Me.Txt_Mor_RSocial.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Mor_RSocial.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(554, 17)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Email"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 17)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 16)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "R.Social"
        '
        'Txt_Mor_Fono
        '
        Me.Txt_Mor_Fono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Mor_Fono.Location = New System.Drawing.Point(352, 16)
        Me.Txt_Mor_Fono.Name = "Txt_Mor_Fono"
        Me.Txt_Mor_Fono.Size = New System.Drawing.Size(152, 20)
        Me.Txt_Mor_Fono.TabIndex = 9
        '
        'Dtg_Morosos
        '
        Me.Dtg_Morosos.CaptionVisible = False
        Me.Dtg_Morosos.DataMember = "COBRANZA_MOROSO"
        Me.Dtg_Morosos.DataSource = Me.Cjto_Tablas1
        Me.Dtg_Morosos.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Morosos.Location = New System.Drawing.Point(8, 16)
        Me.Dtg_Morosos.Name = "Dtg_Morosos"
        Me.Dtg_Morosos.Size = New System.Drawing.Size(936, 392)
        Me.Dtg_Morosos.TabIndex = 0
        Me.Dtg_Morosos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.Dtg_Morosos
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39, Me.DataGridTextBoxColumn40, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn68})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "COBRANZA_MOROSO"
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "NºFactura"
        Me.DataGridTextBoxColumn33.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 65
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "F.Emisión"
        Me.DataGridTextBoxColumn34.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 75
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn35.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 75
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn36.Format = ""
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn36.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 70
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn37.Format = "####,###"
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.HeaderText = "Monto"
        Me.DataGridTextBoxColumn37.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 75
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn38.Format = "####,###"
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.HeaderText = "Abono"
        Me.DataGridTextBoxColumn38.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 75
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn39.Format = "####,###"
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn39.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 75
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn40.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 200
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "RUT"
        Me.DataGridTextBoxColumn41.MappingName = "FAC_RUT"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 75
        '
        'DataGridTextBoxColumn68
        '
        Me.DataGridTextBoxColumn68.Format = ""
        Me.DataGridTextBoxColumn68.FormatInfo = Nothing
        Me.DataGridTextBoxColumn68.HeaderText = "Fecha Moroso"
        Me.DataGridTextBoxColumn68.MappingName = "FAC_FECHA_MOROSO"
        Me.DataGridTextBoxColumn68.NullText = ""
        Me.DataGridTextBoxColumn68.Width = 80
        '
        'Bt_Mor_Grabar
        '
        Me.Bt_Mor_Grabar.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Mor_Grabar.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Mor_Grabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Mor_Grabar.Location = New System.Drawing.Point(1137, 665)
        Me.Bt_Mor_Grabar.Name = "Bt_Mor_Grabar"
        Me.Bt_Mor_Grabar.Size = New System.Drawing.Size(63, 23)
        Me.Bt_Mor_Grabar.TabIndex = 21
        Me.Bt_Mor_Grabar.Text = "Grabar"
        Me.Bt_Mor_Grabar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Mor_Grabar.UseVisualStyleBackColor = False
        Me.Bt_Mor_Grabar.Visible = False
        '
        'Chk_EnvCarta
        '
        Me.Chk_EnvCarta.Location = New System.Drawing.Point(1120, 635)
        Me.Chk_EnvCarta.Name = "Chk_EnvCarta"
        Me.Chk_EnvCarta.Size = New System.Drawing.Size(104, 24)
        Me.Chk_EnvCarta.TabIndex = 18
        Me.Chk_EnvCarta.Text = "Enviar Carta"
        Me.Chk_EnvCarta.Visible = False
        '
        'TabPage4
        '
        Me.TabPage4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage4.Controls.Add(Me.GroupBox3)
        Me.TabPage4.Controls.Add(Me.Label31)
        Me.TabPage4.Controls.Add(Me.Label30)
        Me.TabPage4.Controls.Add(Me.Txt_Nota2)
        Me.TabPage4.Controls.Add(Me.Txt_Nota1)
        Me.TabPage4.Controls.Add(Me.Bt_CEst_Actualiza)
        Me.TabPage4.Controls.Add(Me.Dtg_CambioEstado)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1256, 878)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Cambio de Estado"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BTAceptaCambio)
        Me.GroupBox3.Controls.Add(Me.RdbJudicial)
        Me.GroupBox3.Controls.Add(Me.RdbIncobrable)
        Me.GroupBox3.Controls.Add(Me.RdbMoroso)
        Me.GroupBox3.Controls.Add(Me.Txt_Factura)
        Me.GroupBox3.Controls.Add(Me.Label33)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Location = New System.Drawing.Point(1016, 48)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(232, 202)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'BTAceptaCambio
        '
        Me.BTAceptaCambio.Location = New System.Drawing.Point(68, 147)
        Me.BTAceptaCambio.Name = "BTAceptaCambio"
        Me.BTAceptaCambio.Size = New System.Drawing.Size(104, 23)
        Me.BTAceptaCambio.TabIndex = 19
        Me.BTAceptaCambio.Text = "Cambio Estado"
        '
        'RdbJudicial
        '
        Me.RdbJudicial.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbJudicial.Location = New System.Drawing.Point(76, 111)
        Me.RdbJudicial.Name = "RdbJudicial"
        Me.RdbJudicial.Size = New System.Drawing.Size(92, 24)
        Me.RdbJudicial.TabIndex = 18
        Me.RdbJudicial.Text = "Judicial"
        '
        'RdbIncobrable
        '
        Me.RdbIncobrable.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbIncobrable.Location = New System.Drawing.Point(76, 90)
        Me.RdbIncobrable.Name = "RdbIncobrable"
        Me.RdbIncobrable.Size = New System.Drawing.Size(92, 24)
        Me.RdbIncobrable.TabIndex = 17
        Me.RdbIncobrable.Text = "Incobrable"
        '
        'RdbMoroso
        '
        Me.RdbMoroso.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbMoroso.Location = New System.Drawing.Point(76, 71)
        Me.RdbMoroso.Name = "RdbMoroso"
        Me.RdbMoroso.Size = New System.Drawing.Size(92, 24)
        Me.RdbMoroso.TabIndex = 16
        Me.RdbMoroso.Text = "Moroso"
        '
        'Txt_Factura
        '
        Me.Txt_Factura.Location = New System.Drawing.Point(76, 45)
        Me.Txt_Factura.Name = "Txt_Factura"
        Me.Txt_Factura.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Factura.TabIndex = 15
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 46)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(68, 16)
        Me.Label33.TabIndex = 14
        Me.Label33.Text = "Factura"
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(24, 16)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(176, 16)
        Me.Label32.TabIndex = 13
        Me.Label32.Text = "Cambio de Estado"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(80, 577)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Nota2"
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(80, 400)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Nota1"
        '
        'Txt_Nota2
        '
        Me.Txt_Nota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Nota2.Location = New System.Drawing.Point(160, 576)
        Me.Txt_Nota2.Multiline = True
        Me.Txt_Nota2.Name = "Txt_Nota2"
        Me.Txt_Nota2.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Nota2.TabIndex = 11
        '
        'Txt_Nota1
        '
        Me.Txt_Nota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_Nota1.Location = New System.Drawing.Point(160, 399)
        Me.Txt_Nota1.Multiline = True
        Me.Txt_Nota1.Name = "Txt_Nota1"
        Me.Txt_Nota1.Size = New System.Drawing.Size(560, 160)
        Me.Txt_Nota1.TabIndex = 10
        '
        'Bt_CEst_Actualiza
        '
        Me.Bt_CEst_Actualiza.BackColor = System.Drawing.Color.Transparent
        Me.Bt_CEst_Actualiza.Image = Global.LabSys.My.Resources.Resources.arrow_refresh_small
        Me.Bt_CEst_Actualiza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_CEst_Actualiza.Location = New System.Drawing.Point(912, 16)
        Me.Bt_CEst_Actualiza.Name = "Bt_CEst_Actualiza"
        Me.Bt_CEst_Actualiza.Size = New System.Drawing.Size(80, 23)
        Me.Bt_CEst_Actualiza.TabIndex = 1
        Me.Bt_CEst_Actualiza.Text = "Actualizar"
        Me.Bt_CEst_Actualiza.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_CEst_Actualiza.UseVisualStyleBackColor = False
        '
        'Dtg_CambioEstado
        '
        Me.Dtg_CambioEstado.CaptionVisible = False
        Me.Dtg_CambioEstado.DataMember = "COBRANZA_CAMBIO_ESTADO"
        Me.Dtg_CambioEstado.DataSource = Me.Cjto_Tablas1
        Me.Dtg_CambioEstado.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_CambioEstado.Location = New System.Drawing.Point(8, 48)
        Me.Dtg_CambioEstado.Name = "Dtg_CambioEstado"
        Me.Dtg_CambioEstado.Size = New System.Drawing.Size(984, 328)
        Me.Dtg_CambioEstado.TabIndex = 0
        Me.Dtg_CambioEstado.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.Dtg_CambioEstado
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn69, Me.DataGridTextBoxColumn70})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "COBRANZA_CAMBIO_ESTADO"
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "NºFactura"
        Me.DataGridTextBoxColumn23.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 65
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "F.Emisión"
        Me.DataGridTextBoxColumn24.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 75
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn25.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 75
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn26.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 70
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn27.Format = "####,###"
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Monto"
        Me.DataGridTextBoxColumn27.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 75
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn28.Format = "####,###"
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "Abono"
        Me.DataGridTextBoxColumn28.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 75
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn29.Format = "####,###"
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn29.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 75
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn30.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 200
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "RUT"
        Me.DataGridTextBoxColumn31.MappingName = "FAC_RUT"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 75
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.Width = 75
        '
        'DataGridTextBoxColumn69
        '
        Me.DataGridTextBoxColumn69.Format = ""
        Me.DataGridTextBoxColumn69.FormatInfo = Nothing
        Me.DataGridTextBoxColumn69.HeaderText = "Asignada"
        Me.DataGridTextBoxColumn69.MappingName = "FAC_ASIGNADA"
        Me.DataGridTextBoxColumn69.NullText = ""
        Me.DataGridTextBoxColumn69.Width = 75
        '
        'DataGridTextBoxColumn70
        '
        Me.DataGridTextBoxColumn70.Format = ""
        Me.DataGridTextBoxColumn70.FormatInfo = Nothing
        Me.DataGridTextBoxColumn70.HeaderText = "Fecha Asignada"
        Me.DataGridTextBoxColumn70.MappingName = "FAC_FECHA_ASIGNADA"
        Me.DataGridTextBoxColumn70.NullText = ""
        Me.DataGridTextBoxColumn70.Width = 75
        '
        'TabPage5
        '
        Me.TabPage5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabPage5.Controls.Add(Me.Label29)
        Me.TabPage5.Controls.Add(Me.TxtClave)
        Me.TabPage5.Controls.Add(Me.Label28)
        Me.TabPage5.Controls.Add(Me.Label27)
        Me.TabPage5.Controls.Add(Me.Label26)
        Me.TabPage5.Controls.Add(Me.DTPFechaAsigna)
        Me.TabPage5.Controls.Add(Me.CmdAsignados)
        Me.TabPage5.Controls.Add(Me.Button2)
        Me.TabPage5.Controls.Add(Me.Button1)
        Me.TabPage5.Controls.Add(Me.DataGrid2)
        Me.TabPage5.Controls.Add(Me.Dtg_FacturasNoAsignas)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(1256, 878)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Asignacion"
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(264, 848)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 16)
        Me.Label29.TabIndex = 10
        Me.Label29.Text = "Clave"
        '
        'TxtClave
        '
        Me.TxtClave.Location = New System.Drawing.Point(384, 848)
        Me.TxtClave.Name = "TxtClave"
        Me.TxtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtClave.Size = New System.Drawing.Size(120, 20)
        Me.TxtClave.TabIndex = 9
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(264, 816)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(112, 16)
        Me.Label28.TabIndex = 8
        Me.Label28.Text = "Fecha Asignación"
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(264, 784)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(120, 16)
        Me.Label27.TabIndex = 7
        Me.Label27.Text = "Persona Asignada"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(8, 480)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(136, 16)
        Me.Label26.TabIndex = 6
        Me.Label26.Text = "Facturas Por  Asignar"
        '
        'DTPFechaAsigna
        '
        Me.DTPFechaAsigna.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFechaAsigna.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPFechaAsigna.Location = New System.Drawing.Point(384, 816)
        Me.DTPFechaAsigna.Name = "DTPFechaAsigna"
        Me.DTPFechaAsigna.Size = New System.Drawing.Size(120, 21)
        Me.DTPFechaAsigna.TabIndex = 5
        '
        'CmdAsignados
        '
        Me.CmdAsignados.DataSource = Me.Cjto_Tablas1
        Me.CmdAsignados.DisplayMember = "PERSONAL.NOMBRE"
        Me.CmdAsignados.Location = New System.Drawing.Point(384, 784)
        Me.CmdAsignados.Name = "CmdAsignados"
        Me.CmdAsignados.Size = New System.Drawing.Size(121, 22)
        Me.CmdAsignados.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(632, 808)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Limpiar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.accept
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(536, 808)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Asignar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = "FACTURAS_PORASIGNAR"
        Me.DataGrid2.DataSource = Me.Cjto_Tablas1
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 496)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(1088, 272)
        Me.DataGrid2.TabIndex = 1
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn56, Me.DataGridTextBoxColumn57, Me.DataGridTextBoxColumn67, Me.DataGridTextBoxColumn58, Me.DataGridTextBoxColumn59, Me.DataGridTextBoxColumn60, Me.DataGridTextBoxColumn61, Me.DataGridTextBoxColumn62, Me.DataGridTextBoxColumn63})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "FACTURAS_PORASIGNAR"
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn56.Format = ""
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.HeaderText = "N° Factura"
        Me.DataGridTextBoxColumn56.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 75
        '
        'DataGridTextBoxColumn57
        '
        Me.DataGridTextBoxColumn57.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn57.Format = ""
        Me.DataGridTextBoxColumn57.FormatInfo = Nothing
        Me.DataGridTextBoxColumn57.HeaderText = "F.Emisión"
        Me.DataGridTextBoxColumn57.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn57.NullText = ""
        Me.DataGridTextBoxColumn57.Width = 75
        '
        'DataGridTextBoxColumn67
        '
        Me.DataGridTextBoxColumn67.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn67.Format = ""
        Me.DataGridTextBoxColumn67.FormatInfo = Nothing
        Me.DataGridTextBoxColumn67.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn67.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn67.NullText = ""
        Me.DataGridTextBoxColumn67.Width = 75
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn58.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 85
        '
        'DataGridTextBoxColumn59
        '
        Me.DataGridTextBoxColumn59.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn59.Format = "####,###"
        Me.DataGridTextBoxColumn59.FormatInfo = Nothing
        Me.DataGridTextBoxColumn59.HeaderText = "Monto"
        Me.DataGridTextBoxColumn59.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn59.NullText = ""
        Me.DataGridTextBoxColumn59.Width = 75
        '
        'DataGridTextBoxColumn60
        '
        Me.DataGridTextBoxColumn60.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn60.Format = "####,###"
        Me.DataGridTextBoxColumn60.FormatInfo = Nothing
        Me.DataGridTextBoxColumn60.HeaderText = "Abono"
        Me.DataGridTextBoxColumn60.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn60.NullText = ""
        Me.DataGridTextBoxColumn60.Width = 75
        '
        'DataGridTextBoxColumn61
        '
        Me.DataGridTextBoxColumn61.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn61.Format = "####,###"
        Me.DataGridTextBoxColumn61.FormatInfo = Nothing
        Me.DataGridTextBoxColumn61.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn61.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn61.NullText = ""
        Me.DataGridTextBoxColumn61.Width = 75
        '
        'DataGridTextBoxColumn62
        '
        Me.DataGridTextBoxColumn62.Format = ""
        Me.DataGridTextBoxColumn62.FormatInfo = Nothing
        Me.DataGridTextBoxColumn62.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn62.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn62.NullText = ""
        Me.DataGridTextBoxColumn62.Width = 300
        '
        'DataGridTextBoxColumn63
        '
        Me.DataGridTextBoxColumn63.Format = ""
        Me.DataGridTextBoxColumn63.FormatInfo = Nothing
        Me.DataGridTextBoxColumn63.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn63.MappingName = "FAC_EMPRESA"
        Me.DataGridTextBoxColumn63.NullText = ""
        Me.DataGridTextBoxColumn63.Width = 200
        '
        'Dtg_FacturasNoAsignas
        '
        Me.Dtg_FacturasNoAsignas.CaptionVisible = False
        Me.Dtg_FacturasNoAsignas.DataMember = "FACTURAS_NOASIGNADAS"
        Me.Dtg_FacturasNoAsignas.DataSource = Me.Cjto_Tablas1
        Me.Dtg_FacturasNoAsignas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_FacturasNoAsignas.Location = New System.Drawing.Point(8, 8)
        Me.Dtg_FacturasNoAsignas.Name = "Dtg_FacturasNoAsignas"
        Me.Dtg_FacturasNoAsignas.Size = New System.Drawing.Size(1088, 456)
        Me.Dtg_FacturasNoAsignas.TabIndex = 0
        Me.Dtg_FacturasNoAsignas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.Dtg_FacturasNoAsignas
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn48, Me.DataGridTextBoxColumn49, Me.DataGridTextBoxColumn66, Me.DataGridTextBoxColumn50, Me.DataGridTextBoxColumn51, Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54, Me.DataGridTextBoxColumn55})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "FACTURAS_NOASIGNADAS"
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn48.Format = ""
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "N° Factura"
        Me.DataGridTextBoxColumn48.MappingName = "FAC_NUMERO"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 75
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.HeaderText = "F.Emision"
        Me.DataGridTextBoxColumn49.MappingName = "FAC_FECHA_EMISION"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 75
        '
        'DataGridTextBoxColumn66
        '
        Me.DataGridTextBoxColumn66.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn66.Format = ""
        Me.DataGridTextBoxColumn66.FormatInfo = Nothing
        Me.DataGridTextBoxColumn66.HeaderText = "F.Pactada"
        Me.DataGridTextBoxColumn66.MappingName = "FAC_FECHA_PACTADA"
        Me.DataGridTextBoxColumn66.NullText = ""
        Me.DataGridTextBoxColumn66.Width = 75
        '
        'DataGridTextBoxColumn50
        '
        Me.DataGridTextBoxColumn50.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn50.Format = ""
        Me.DataGridTextBoxColumn50.FormatInfo = Nothing
        Me.DataGridTextBoxColumn50.HeaderText = "Cond.Pago"
        Me.DataGridTextBoxColumn50.MappingName = "FAC_CONDICION_PAGO"
        Me.DataGridTextBoxColumn50.NullText = ""
        Me.DataGridTextBoxColumn50.Width = 85
        '
        'DataGridTextBoxColumn51
        '
        Me.DataGridTextBoxColumn51.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn51.Format = "####,###"
        Me.DataGridTextBoxColumn51.FormatInfo = Nothing
        Me.DataGridTextBoxColumn51.HeaderText = "Monto"
        Me.DataGridTextBoxColumn51.MappingName = "FAC_TOTAL"
        Me.DataGridTextBoxColumn51.NullText = ""
        Me.DataGridTextBoxColumn51.Width = 75
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn52.Format = "####,###"
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "Abono"
        Me.DataGridTextBoxColumn52.MappingName = "FAC_ABONO"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 75
        '
        'DataGridTextBoxColumn53
        '
        Me.DataGridTextBoxColumn53.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn53.Format = "####,###"
        Me.DataGridTextBoxColumn53.FormatInfo = Nothing
        Me.DataGridTextBoxColumn53.HeaderText = "Saldo"
        Me.DataGridTextBoxColumn53.MappingName = "FAC_SALDO"
        Me.DataGridTextBoxColumn53.NullText = ""
        Me.DataGridTextBoxColumn53.Width = 75
        '
        'DataGridTextBoxColumn54
        '
        Me.DataGridTextBoxColumn54.Format = ""
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "Razón Social"
        Me.DataGridTextBoxColumn54.MappingName = "FAC_RSOCIAL"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 300
        '
        'DataGridTextBoxColumn55
        '
        Me.DataGridTextBoxColumn55.Format = ""
        Me.DataGridTextBoxColumn55.FormatInfo = Nothing
        Me.DataGridTextBoxColumn55.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn55.MappingName = "FAC_EMPRESA"
        Me.DataGridTextBoxColumn55.NullText = ""
        Me.DataGridTextBoxColumn55.Width = 200
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 994)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobranza"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Dtg_Inicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Dtg_Cobranza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dtg_Morosos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.Dtg_CambioEstado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dtg_FacturasNoAsignas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Rut As String

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Deuda As Integer
        Cjto_Tablas1.Tables("COBRANZA").Clear()
        Cjto_Tablas1.Tables("COBRANZA_FILTRO").Clear()
        Cjto_Tablas1.Tables("COBRANZA_CAMBIO_ESTADO").Clear()
        Cjto_Tablas1.Tables("FACTURAS_NOASIGNADAS").Clear()
        Cjto_Tablas1.Tables("FACTURAS_PORASIGNAR").Clear()

        Try
            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaCobranza3", Cjto_Tablas1, "COBRANZA")
            End With

            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaCobranzaMoroso2", Cjto_Tablas1, "COBRANZA_MOROSO")
            End With

            Call Calcula_SaldoTotal()

            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_Cobranza_CargaPersonal", Cjto_Tablas1, "PERSONAL1")
            End With

            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaFacturasNoAsignadas2", Cjto_Tablas1, "FACTURAS_NOASIGNADAS")
            End With

            Call Calcula_SaldoTotal3()
            Call Calcula_SaldoTotal5()


            Call Formato_Grilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Formato_Grilla()
        Dim Fila_D As DataRow
        Dim Fila As Integer = 0
        Dim Mycell As DataGridCell
        For Each Fila_D In Cjto_Tablas1.Tables("COBRANZA").Rows
            If IsDBNull(Fila_D("FAC_NOTA_COBRANZA")) = False Then
                If Len(LTrim(Fila_D("FAC_NOTA_COBRANZA"))) <> 0 Then
                    Dtg_Inicio.Item(Fila, 11) = "X"
                End If
            End If

            If IsDBNull(Fila_D("FAC_NOTA_COBRANZA2")) = False Then
                If Len(LTrim(Fila_D("FAC_NOTA_COBRANZA2"))) <> 0 Then
                    Dtg_Inicio.Item(Fila, 12) = "X"
                End If
            End If
            Fila = Fila + 1
        Next
        Mycell.ColumnNumber = 0
        Mycell.RowNumber = 0
        Dtg_Inicio.CurrentCell = Mycell
    End Sub


    Private Sub Formato_GrillaFiltrada()
        Dim Fila_D As DataRow
        Dim Fila As Integer = 0
        '   Dim Mycell As DataGridCell
        For Each Fila_D In Cjto_Tablas1.Tables("COBRANZA_FILTRO").Rows

            If IsDBNull(Fila_D("FAC_NOTA_COBRANZA")) = False Then
                If Len(LTrim(Fila_D("FAC_NOTA_COBRANZA"))) <> 0 Then
                    Dtg_Cobranza.Item(Fila, 11) = "X"
                End If
            End If

            If IsDBNull(Fila_D("FAC_NOTA_COBRANZA2")) = False Then
                If Len(LTrim(Fila_D("FAC_NOTA_COBRANZA2"))) <> 0 Then
                    Dtg_Cobranza.Item(Fila, 12) = "X"
                End If
            End If

            'If IsDBNull(Fila_D("FAC_TOTAL")) = False Then
            '    Dtg_Inicio.Item(Fila, 3) = Format(CStr(Fila_D("FAC_TOTAL")), "###,###,###")
            'End If

            Fila = Fila + 1
        Next
        'Mycell.ColumnNumber = 0
        'Mycell.RowNumber = 0
        'Dtg_Cobranza.CurrentCell = Mycell
    End Sub


    Private Sub Dtg_Inicio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Inicio.DoubleClick
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim fila = Dtg_Inicio.CurrentCell.RowNumber
        Dim Deuda_F As Integer
        Dim x As String
        Rut = Dtg_Inicio.Item(fila, 9)
        Try
            With sp
                .Inicializar()
                .AgregarParametro("@Rut", Rut, SqlDbType.NVarChar)
                .EjecutarQueryDt("usp_CargaCobranzaFiltrado3", Cjto_Tablas1, "COBRANZA_FILTRO")
            End With

            Call Calcula_Saldo()


            'Call Formato_GrillaFiltrada()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Calcula_Saldo()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("COBRANZA_FILTRO").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
            Total = Total + Fila("FAC_SALDO")
        Next
        Lb_Cob_Deuda.Text = Format(Total, "###,###,###")
    End Sub

    Private Sub Calcula_SaldoTotal()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("COBRANZA").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
            Total = Total + Fila("FAC_SALDO")
        Next
        Lb_Deuda.Text = Format(Total, "###,###,###")
    End Sub

    Private Sub Calcula_SaldoTotal2()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("COBRANZA_CAMBIO_ESTADO").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
        Next
    End Sub

    Private Sub Calcula_SaldoTotal3()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("FACTURAS_NOASIGNADAS").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
        Next
    End Sub

    Private Sub Calcula_SaldoTotal4()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("FACTURAS_PORASIGNAR").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
        Next
    End Sub

    Private Sub Calcula_SaldoTotal5()
        Dim Saldo, Total As Double
        Total = 0
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("COBRANZA_MOROSO").Rows
            Fila("FAC_SALDO") = Fila("FAC_TOTAL") - Fila("FAC_ABONO")
        Next
    End Sub


    Private Sub Carga_DatosCobranza(ByVal Num_Fact As Integer)
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila As DataRow
        Txt_Cob_Solicita.ResetText()
        Txt_Cob_SolFono.ResetText()
        Txt_Cob_SolCelular.ResetText()
        Txt_Cob_SolEmail.ResetText()
        Txt_Cob_OCompra.ResetText()
        Txt_Cob_EncPago.ResetText()
        Txt_Cob_FonoPago.ResetText()

        Try
            Cjto_Tablas1.Tables("COBRANZA_DATOSORDENES").Clear()
            With sp
                .Inicializar()
                .AgregarParametro("@Num_Fact", Num_Fact, SqlDbType.Int)
                .EjecutarQueryDt("usp_Cobranza_DatosOrdenes2", Cjto_Tablas1, "COBRANZA_DATOSORDENES")
            End With

            For Each Fila In Cjto_Tablas1.Tables("COBRANZA_DATOSORDENES").Rows
                If IsDBNull(Fila("OT_SOL_NOMBRE")) = False And Fila("OT_SOL_NOMBRE") <> "" Then
                    Txt_Cob_Solicita.Text = Fila("OT_SOL_NOMBRE")
                End If

                If IsDBNull(Fila("OT_SOL_FONO1")) = False And Fila("OT_SOL_FONO1") <> "" Then
                    Txt_Cob_SolFono.Text = Fila("OT_SOL_FONO1")
                End If

                If IsDBNull(Fila("OT_SOL_CELULAR1")) = False And Fila("OT_SOL_CELULAR1") <> "" Then
                    Txt_Cob_SolCelular.Text = Fila("OT_SOL_CELULAR1")
                End If

                If IsDBNull(Fila("OT_SOL_EMAIL1")) = False And Fila("OT_SOL_EMAIL1") <> "" Then
                    Txt_Cob_SolEmail.Text = Fila("OT_SOL_EMAIL1")
                End If

                If Fila("OT_ORDENCOMPRA") <> "0" And IsDBNull(Fila("OT_ORDENCOMPRA")) = False Then
                    Txt_Cob_OCompra.Text = Fila("OT_ORDENCOMPRA")
                End If

                If IsDBNull(Fila("OT_OBSERVACIONES")) = False And Fila("OT_OBSERVACIONES") <> "" Then
                    Txt_Cob_Obs.Text = Fila("OT_OBSERVACIONES")
                End If

                If IsDBNull(Fila("OT_FAC_ENCPAGO")) = False And Fila("OT_FAC_ENCPAGO") <> "" Then
                    Txt_Cob_EncPago.Text = Fila("OT_FAC_ENCPAGO")
                End If

                If IsDBNull(Fila("OT_FAC_F1PAGO")) = False And Fila("OT_FAC_F1PAGO") <> "" Then
                    Txt_Cob_FonoPago.Text = Fila("OT_FAC_F1PAGO")
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub Carga_DatosEncPago(ByVal Num_Fact As Integer)
        Dim Fila As DataRow
        'Txt_Cob_EncPago.ResetText()
        'Txt_Cob_FonoPago.ResetText()
        Txt_Cob_CondPago.ResetText()



        For Each Fila In Cjto_Tablas1.Tables("COBRANZA_FILTRO").Rows
            If Fila("FAC_NUMERO") = Num_Fact Then
                If Txt_Cob_EncPago.Text = "" Then
                    If IsDBNull(Fila("FAC_ENCPAGO")) = False Then
                        Txt_Cob_EncPago.Text = Fila("FAC_ENCPAGO")
                    End If

                End If

                If Txt_Cob_FonoPago.Text = "" Then
                    If IsDBNull(Fila("FAC_F1PAGO")) = False Then
                        Txt_Cob_FonoPago.Text = Fila("FAC_F1PAGO")
                    End If
                End If

                If IsDBNull(Fila("FAC_CONDICION_PAGO")) = False Then
                    Txt_Cob_CondPago.Text = Fila("FAC_CONDICION_PAGO")
                End If
            End If
        Next

    End Sub

    Private Sub Dtg_Cobranza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Cobranza.Click
        Dim N_Fac As Integer
        Dim fila As Integer
        fila = Dtg_Cobranza.CurrentCell.RowNumber
        N_Fac = Dtg_Cobranza.Item(fila, 0)
        Call Limpiar_Click()
        Call Carga_DatosCobranza(N_Fac)
        Call Carga_DatosEncPago(N_Fac)
    End Sub


    Private Sub Dtg_Cobranza_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Cobranza.DoubleClick
        Dim fila As Integer
        fila = Dtg_Cobranza.CurrentCell.RowNumber
        Dim Factura As Integer = Dtg_Cobranza.Item(fila, 0)

        Txt_Cob_Nota1.Enabled = True
        Dtp_FechaProp1.Enabled = True
        Txt_Cob_Nota2.Enabled = True
        Dtp_FechaProp2.Enabled = True
        Txt_Llamar_el.Enabled = True

        'If IsDBNull(Dtg_Cobranza.Item(fila, 10)) = False Then
        '    Txt_Cob_Nota1.Enabled = False
        '    Dtp_FechaProp1.Enabled = False
        '    Txt_Cob_Nota2.Enabled = True
        '    Dtp_FechaProp2.Enabled = True
        'ElseIf IsDBNull(Dtg_Cobranza.Item(fila, 11)) = False Then
        '    Txt_Cob_Nota1.Enabled = True
        '    Dtp_FechaProp1.Enabled = True
        '    Txt_Cob_Nota2.Enabled = False
        '    Dtp_FechaProp2.Enabled = False

        If IsDBNull(Dtg_Cobranza.Item(fila, 11)) = False And IsDBNull(Dtg_Cobranza.Item(fila, 12)) = False Then
            If Len(LTrim(Dtg_Cobranza.Item(fila, 11))) <> 0 And Len(LTrim(Dtg_Cobranza.Item(fila, 12))) <> 0 Then
                Txt_Cob_Nota1.Enabled = False
                Dtp_FechaProp1.Enabled = False
                Txt_Cob_Nota2.Enabled = False
                Dtp_FechaProp2.Enabled = False
                Txt_Llamar_el.Enabled = False
            End If
        End If

        Call Carga_Notas(Factura)

    End Sub

    Private Sub Carga_Notas(ByVal Num_Factura As Integer)
        Dim Fila As DataRow
        For Each Fila In Cjto_Tablas1.Tables("COBRANZA_FILTRO").Rows
            If Fila("FAC_NUMERO") = Num_Factura Then

                If IsDBNull(Fila("FAC_NOTA_COBRANZA")) = False Then
                    Txt_Cob_Nota1.Text = Fila("FAC_NOTA_COBRANZA")
                End If

                If IsDBNull(Fila("FAC_NOTA_COBRANZA2")) = False Then
                    Txt_Cob_Nota2.Text = Fila("FAC_NOTA_COBRANZA2")
                End If

                If IsDBNull(Fila("FAC_FECHA_LLAMAR")) = False Then
                    Txt_Llamar_el.Text = Fila("FAC_FECHA_LLAMAR")
                End If

            End If
        Next
    End Sub

    Private Sub Bt_Cob_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cob_Grabar.Click
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fac, Fila As Integer
        Fila = Dtg_Cobranza.CurrentCell.RowNumber
        Fac = Dtg_Cobranza.Item(Fila, 0)
        Try
            If Txt_Cob_Nota1.Enabled = True And Len(LTrim(Txt_Cob_Nota1.Text)) <> 0 Then
                With sp
                    .Inicializar()
                    .AgregarParametro("@Factura", Fac, SqlDbType.Int)
                    .AgregarParametro("@Nota1", Txt_Cob_Nota1.Text, SqlDbType.NVarChar)
                    .AgregarParametro("@Fecha1", Date.Today, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_Pactada", Dtp_FechaProp1.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Llamar_el", Txt_Llamar_el.Text, SqlDbType.NVarChar)
                    .EjecutarAccion("usp_Cobranza_ActDatosCobranza3")
                    MsgBox("Grabación Finalizada")
                End With
            End If

            If Txt_Cob_Nota2.Enabled = True And Len(LTrim(Txt_Cob_Nota2.Text)) <> 0 Then
                With sp
                    .Inicializar()
                    .AgregarParametro("@Factura", Fac, SqlDbType.Int)
                    .AgregarParametro("@Nota2", Txt_Cob_Nota2.Text, SqlDbType.NVarChar)
                    .AgregarParametro("@Fecha2", Date.Today, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_Pactada", Dtp_FechaProp2.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Llamar_el", Txt_Llamar_el.Text, SqlDbType.NVarChar)
                    .EjecutarAccion("usp_Cobranza_ActDatosCobranza4")
                    MsgBox("Grabación Finalizada")
                End With
            End If


            With sp
                .Inicializar()
                .AgregarParametro("@Factura", Fac, SqlDbType.Int)
                .AgregarParametro("@EncPago", Txt_Cob_EncPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@FonoPago", Txt_Cob_FonoPago.Text, SqlDbType.NVarChar)
                .EjecutarAccion("usp_Cobranza_ActDatosEncFono")
            End With


            With sp
                .Inicializar()
                .AgregarParametro("@Factura", Fac, SqlDbType.Int)
                .AgregarParametro("@Solicita", Txt_Cob_Solicita.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Fono1", Txt_Cob_SolFono.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Cel1", Txt_Cob_SolCelular.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Email1", Txt_Cob_SolEmail.Text, SqlDbType.NVarChar)
                .AgregarParametro("@Obs", Txt_Cob_Obs.Text, SqlDbType.NVarChar)
                .AgregarParametro("@OCompra", Txt_Cob_OCompra.Text, SqlDbType.NVarChar)
                .AgregarParametro("@FonoPago", Txt_Cob_FonoPago.Text, SqlDbType.NVarChar)
                .AgregarParametro("@EncPago", Txt_Cob_EncPago.Text, SqlDbType.NVarChar)
                .EjecutarAccion("usp_Cobranza_ActDatosOrdenes2")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bt_Cob_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cob_Limpiar.Click
        Call Limpiar()
    End Sub

    Private Sub Limpiar()
        Cjto_Tablas1.Tables("COBRANZA_FILTRO").Clear()
        Txt_Cob_CondPago.ResetText()
        Txt_Cob_EncPago.ResetText()
        Txt_Cob_FonoPago.ResetText()
        Txt_Cob_Nota1.ResetText()
        Txt_Cob_Nota2.ResetText()
        Txt_Cob_Obs.ResetText()
        Txt_Cob_OCompra.ResetText()
        Txt_Cob_SolCelular.ResetText()
        Txt_Cob_SolEmail.ResetText()
        Txt_Cob_SolFono.ResetText()
        Txt_Cob_SolFono.ResetText()
        Txt_Cob_Solicita.ResetText()
        Txt_Llamar_el.ResetText()
        Lb_Cob_Deuda.ResetText()
        Txt_Cob_Nota1.Enabled = False
        Txt_Cob_Nota2.Enabled = False
    End Sub

    Private Sub Limpiar_Click()
        Txt_Cob_CondPago.ResetText()
        Txt_Cob_EncPago.ResetText()
        Txt_Cob_FonoPago.ResetText()
        Txt_Cob_Nota1.ResetText()
        Txt_Cob_Nota2.ResetText()
        Txt_Cob_Obs.ResetText()
        Txt_Cob_OCompra.ResetText()
        Txt_Cob_SolCelular.ResetText()
        Txt_Cob_SolEmail.ResetText()
        Txt_Cob_SolFono.ResetText()
        Txt_Cob_SolFono.ResetText()
        Txt_Cob_Solicita.ResetText()
        Txt_Cob_Nota1.Enabled = False
        Txt_Cob_Nota2.Enabled = False
        Txt_Llamar_el.Text = ""
    End Sub

    Private Sub Dtg_CambioEstado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_CambioEstado.DoubleClick
        Dim Factura, Fila As Integer
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Dim Respuesta As MsgBoxResult

        Txt_Nota1.Text = ""
        Txt_Nota2.Text = ""
        Txt_Factura.Text = ""

        Fila = Dtg_CambioEstado.CurrentCell.RowNumber
        Factura = Dtg_CambioEstado.Item(Fila, 0)
        Txt_Factura.Text = Factura

        With SP
            .Inicializar()
            .AgregarParametro("@Factura", Factura, SqlDbType.Int)
            ds = .EjecutarQuery("usp_Cobranza_SelectNota")
        End With

        If IsDBNull(ds.Tables(0).Rows(0).Item("fac_nota_cobranza")) = False Then Txt_Nota1.Text = ds.Tables(0).Rows(0).Item("fac_nota_cobranza")
        If IsDBNull(ds.Tables(0).Rows(0).Item("fac_nota_cobranza2")) = False Then Txt_Nota2.Text = ds.Tables(0).Rows(0).Item("fac_nota_cobranza2")

        RdbMoroso.Checked = True

    End Sub

    Private Sub Bt_Cob_Actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Cob_Actualiza.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Cjto_Tablas1.Tables("COBRANZA").Clear()
        Try
            With SP
                .Inicializar()
                .EjecutarQueryDt("usp_CargaCobranza3", Cjto_Tablas1, "COBRANZA")
            End With
            Call Formato_Grilla()

            Call Calcula_SaldoTotal()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Txt_Cob_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Cob_Buscar.KeyPress
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        If e.KeyChar = Chr(13) Then
            Cjto_Tablas1.Tables("COBRANZA").Clear()
            Try
                With sp
                    .Inicializar()
                    .AgregarParametro("@Palabra", Txt_Cob_Buscar.Text, SqlDbType.NVarChar)
                    .EjecutarQueryDt("usp_Cobranza_CargaBusqueda", Cjto_Tablas1, "COBRANZA")
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub


    Private Sub Bt_CEst_Actualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_CEst_Actualiza.Click
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Deuda As Integer
        Cjto_Tablas1.Tables("COBRANZA").Clear()
        Cjto_Tablas1.Tables("COBRANZA_FILTRO").Clear()
        Cjto_Tablas1.Tables("COBRANZA_CAMBIO_ESTADO").Clear()
        Try
            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaCobranza3", Cjto_Tablas1, "COBRANZA")
            End With


            Call Calcula_SaldoTotal()

            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_Cobranza_GrillaCambioEstado", Cjto_Tablas1, "COBRANZA_CAMBIO_ESTADO")
            End With
            Call Calcula_SaldoTotal2()

            Call Formato_Grilla()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Bt_Mor_Grabar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Mor_Grabar.Click
        If Chk_EnvCarta.Checked = True Then
            Llena_DatosCarta()
            Dim Form_A_A_S As New Carta
            Form_A_A_S.Show()
        End If
    End Sub

    Private Sub Dtg_Morosos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Morosos.Click
        Dim Fact, fila As Integer
        fila = Dtg_Morosos.CurrentCell.RowNumber
        Fact = Dtg_Morosos.Item(fila, 0)
        Txt_Mor_Email.Text = ""
        Txt_Moroso_Nota1.Text = ""
        Txt_Moroso_Nota2.Text = ""
        Call Carga_Datos_Morosos(Fact)
    End Sub

    Private Sub Carga_Datos_Morosos(ByVal Factura As Integer)
        Dim Fila_Mor, Fila_Mor2 As DataRow
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim ds As DataSet = New DataSet

        Try
            For Each Fila_Mor In Cjto_Tablas1.Tables("COBRANZA_MOROSO").Rows
                If Fila_Mor("FAC_NUMERO") = Factura Then

                    If IsDBNull(Fila_Mor("FAC_RSOCIAL")) = False Then
                        Txt_Mor_RSocial.Text = Fila_Mor("FAC_RSOCIAL")
                    End If

                    If IsDBNull(Fila_Mor("FAC_F1PAGO")) = False Then
                        Txt_Mor_Fono.Text = Fila_Mor("FAC_F1PAGO")
                    End If

                    If IsDBNull(Fila_Mor("FAC_ENCPAGO")) = False Then
                        Txt_Mor_Atencion.Text = Fila_Mor("FAC_ENCPAGO")
                    End If

                    If IsDBNull(Fila_Mor("FAC_TOTAL")) = False Then
                        Txt_Mor_Deuda.Text = Fila_Mor("FAC_TOTAL")
                    End If
                End If
            Next

            Cjto_Tablas1.Tables("COBRANZA_DATOSORDENES_MOROSOS").Clear()
            With sp
                .Inicializar()
                .AgregarParametro("@Num_Fact", Factura, SqlDbType.Int)
                .EjecutarQueryDt("usp_Cobranza_DatosOrdenes2", Cjto_Tablas1, "COBRANZA_DATOSORDENES_MOROSOS")
            End With

            For Each Fila_Mor2 In Cjto_Tablas1.Tables("COBRANZA_DATOSORDENES_MOROSOS").Rows
                If IsDBNull(Fila_Mor2("OT_SOL_EMAIL1")) = False Then
                    Txt_Mor_Email.Text = Fila_Mor2("OT_SOL_EMAIL1")
                End If
            Next

            With sp
                .Inicializar()
                .AgregarParametro("@Factura", Factura, SqlDbType.Int)
                ds = .EjecutarQuery("usp_Cobranza_SelectNota")
            End With

            If IsDBNull(ds.Tables(0).Rows(0).Item("fac_nota_cobranza")) = False Then Txt_Moroso_Nota1.Text = ds.Tables(0).Rows(0).Item("fac_nota_cobranza")
            If IsDBNull(ds.Tables(0).Rows(0).Item("fac_nota_cobranza2")) = False Then Txt_Moroso_Nota2.Text = ds.Tables(0).Rows(0).Item("fac_nota_cobranza2")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Llena_DatosCarta()
        Dim Data As DataRow
        Cjto_Carta1.Tables("CARTA").Clear()
        Data = Cjto_Carta1.Tables("CARTA").NewRow
        Data("RAZON_SOCIAL") = "Soc. Agr. Las Pillalas" 'Txt_Mor_RSocial.Text
        Data("FONO") = "5478454" 'Txt_Mor_Fono.Text
        Data("EMAIL") = "aprado@tie.cl" 'Txt_Mor_Email.Text
        Data("ATENCION") = "Antonieta Prado" 'Txt_Mor_Atencion.Text
        Data("DEUDA") = "100000" 'Txt_Mor_Deuda.Text

        Cjto_Carta1.Tables("CARTA").Rows.Add(Data)
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CmdAsignados.Text = ""
        TxtClave.Text = ""
        Cjto_Tablas1.Tables("FACTURAS_PORASIGNAR").Clear()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila_Asigna As DataRow
        If TxtClave.Text = Format(Now.Today, "dd-MM-yy") Then
            For Each Fila_Asigna In Cjto_Tablas1.Tables("FACTURAS_PORASIGNAR").Rows
                With sp
                    .Inicializar()
                    .AgregarParametro("@NumFac", Fila_Asigna("FAC_NUMERO"), SqlDbType.Int)
                    .AgregarParametro("@NomAsigna", CmdAsignados.Text, SqlDbType.NVarChar)
                    .AgregarParametro("@FechaAsigna", DTPFechaAsigna.Text, SqlDbType.DateTime)
                    .EjecutarQuery("usp_Update_CobranzaAsigna")
                End With
            Next

            CmdAsignados.Text = ""
            TxtClave.Text = ""
            Cjto_Tablas1.Tables("FACTURAS_PORASIGNAR").Clear()
            Cjto_Tablas1.Tables("FACTURAS_NOASIGNADAS").Clear()

            With sp
                .Inicializar()
                .EjecutarQueryDt("usp_CargaFacturasNoAsignadas2", Cjto_Tablas1, "FACTURAS_NOASIGNADAS")
            End With
        Else
            MsgBox("¡¡¡¡¡¡¡¡  Clave Erronea  ¡¡¡¡¡¡¡¡¡")
        End If
    End Sub

    Private Sub Dtg_FacturasNoAsignas_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtg_FacturasNoAsignas.DoubleClick
        Dim Fila, Factura As Integer
        Dim sp As Procedimiento_Almacenado = New Procedimiento_Almacenado

        Try
            Fila = Dtg_FacturasNoAsignas.CurrentCell.RowNumber
            Factura = Dtg_FacturasNoAsignas.Item(Fila, 0)
            With sp
                .Inicializar()
                .AgregarParametro("@NumFac", Factura, SqlDbType.Int)
                .EjecutarQueryDt("usp_Cobranza_PorAsignar2", Cjto_Tablas1, "FACTURAS_PORASIGNAR")
            End With

            Call Calcula_SaldoTotal4()

        Catch ex As Exception
        End Try

    End Sub

    Private Sub BTAceptaCambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAceptaCambio.Click
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim CamEst As String

        If RdbMoroso.Checked = True Then CamEst = "Mor"
        If RdbIncobrable.Checked = True Then CamEst = "Inc"
        If RdbJudicial.Checked = True Then CamEst = "Jud"

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@Factura", CInt(Txt_Factura.Text), SqlDbType.Int)
                .AgregarParametro("@Estado", CamEst, SqlDbType.NVarChar)
                .AgregarParametro("@FechaCambio", Date.Today, SqlDbType.DateTime)
                .EjecutarAccion("usp_Cobranza_CambioEstado")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cjto_Tablas1.Tables("COBRANZA_CAMBIO_ESTADO").Clear()
        Cjto_Tablas1.Tables("COBRANZA_MOROSO").Clear()

        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_Cobranza_GrillaCambioEstado", Cjto_Tablas1, "COBRANZA_CAMBIO_ESTADO")
        End With
        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_CargaCobranzaMoroso2", Cjto_Tablas1, "COBRANZA_MOROSO")
        End With

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim ds As DataSet = New DataSet
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim CamEst As String = ""

        If RdbMorosoInco.Checked = True Then CamEst = "Inc"
        If RdbMorosoJudi.Checked = True Then CamEst = "Jud"

        Try
            With SP
                .Inicializar()
                .AgregarParametro("@Factura", CInt(Txt_Moroso_factura.Text), SqlDbType.Int)
                .AgregarParametro("@Estado", CamEst, SqlDbType.NVarChar)
                .AgregarParametro("@FechaCambio", Date.Today, SqlDbType.DateTime)
                .EjecutarAccion("usp_Cobranza_CambioEstado")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Cjto_Tablas1.Tables("COBRANZA_MOROSO").Clear()

        With SP
            .Inicializar()
            .EjecutarQueryDt("usp_CargaCobranzaMoroso2", Cjto_Tablas1, "COBRANZA_MOROSO")
        End With

    End Sub
End Class
