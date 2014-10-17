Imports System.Data.SqlClient
Public Class F_Mantenedor_OTCodificacion
    Inherits System.Windows.Forms.Form
    Private myGriC As DataGrid
    Private ffiCam, ColumnaCam, Fila_Ant, Total_Factura As Integer
    Private Ot_Est_Fac As String
    Private Fila_grilla, codigo_antiguo, TxtDeDG, Muestra, ffi, Columna34, Num_Muestra, PreAna1, PreAna2, PreAna3, le, Fila_Cod, Columna_Cod As Integer



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
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents tt As LabSys.Cjto_Tablas
    Friend WithEvents oo As LabSys.Cjto_Orden
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GRBNLabCod As System.Windows.Forms.GroupBox
    Friend WithEvents DGTablaNlab As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTJocker As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TxtCPrecio As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BTJockerMod As System.Windows.Forms.Button
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents BTGraba As System.Windows.Forms.Button
    Friend WithEvents DGCodificacion As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GrbJockerMod As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ChkCancelado As System.Windows.Forms.CheckBox
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents RdbAbonoEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents RdbAbonoCheque As System.Windows.Forms.RadioButton
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents TxtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreoPrecioUn As System.Windows.Forms.TextBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreoCant As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents TxtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents TxtMuestreo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNeto As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents TxtSubTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents TxtDesctPesos As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescto As System.Windows.Forms.TextBox
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TABMuestrasMod As System.Windows.Forms.TabControl
    Friend WithEvents DGFoliarMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGTejidosMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGAguaMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGSueloMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGOtrosMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGVentaMod As System.Windows.Forms.DataGrid
    Friend WithEvents TxtValorMod As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle8 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn50 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn51 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle9 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn55 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn57 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle10 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn59 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn60 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn61 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn62 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn63 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DGFertOrgMod As System.Windows.Forms.DataGrid
    Friend WithEvents DGFertQuiMod As System.Windows.Forms.DataGrid
    Friend WithEvents TxtPrecioMod As System.Windows.Forms.TextBox
    Friend WithEvents TxtDescripcionMod As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigoMod As System.Windows.Forms.TextBox
    Friend WithEvents TxtAbono As System.Windows.Forms.TextBox
    Friend WithEvents RdbIfrIoc As System.Windows.Forms.RadioButton
    Friend WithEvents RdbTodosMod As System.Windows.Forms.RadioButton
    Friend WithEvents RdbIfr As System.Windows.Forms.RadioButton
    Friend WithEvents RdbCfrCoc As System.Windows.Forms.RadioButton
    Friend WithEvents RdbCfr As System.Windows.Forms.RadioButton
    Friend WithEvents BTCerrarJocker As System.Windows.Forms.Button
    Friend WithEvents CmdAceptarJockerMod As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tt = New LabSys.Cjto_Tablas
        Me.oo = New LabSys.Cjto_Orden
        Me.DGCodificacion = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.BTJocker = New System.Windows.Forms.Button
        Me.TABMuestrasMod = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DGFoliarMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DGTejidosMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.DGAguaMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DGSueloMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.DGFertOrgMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.DGFertQuiMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle8 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn50 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn51 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.DGOtrosMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle9 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn55 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn57 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.DGVentaMod = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle10 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn59 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn60 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn61 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn62 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn63 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.BTJockerMod = New System.Windows.Forms.Button
        Me.RdbIfrIoc = New System.Windows.Forms.RadioButton
        Me.RdbTodosMod = New System.Windows.Forms.RadioButton
        Me.RdbIfr = New System.Windows.Forms.RadioButton
        Me.Label142 = New System.Windows.Forms.Label
        Me.Label141 = New System.Windows.Forms.Label
        Me.RdbCfrCoc = New System.Windows.Forms.RadioButton
        Me.RdbCfr = New System.Windows.Forms.RadioButton
        Me.Label76 = New System.Windows.Forms.Label
        Me.GRBNLabCod = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.DGTablaNlab = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GrbJockerMod = New System.Windows.Forms.GroupBox
        Me.BTCerrarJocker = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtPrecioMod = New System.Windows.Forms.TextBox
        Me.TxtDescripcionMod = New System.Windows.Forms.TextBox
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.CmdAceptarJockerMod = New System.Windows.Forms.Button
        Me.TxtCodigoMod = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.TxtCPrecio = New System.Windows.Forms.TextBox
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label87 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.BTGraba = New System.Windows.Forms.Button
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.ChkCancelado = New System.Windows.Forms.CheckBox
        Me.Label91 = New System.Windows.Forms.Label
        Me.RdbAbonoEfectivo = New System.Windows.Forms.RadioButton
        Me.RdbAbonoCheque = New System.Windows.Forms.RadioButton
        Me.Label90 = New System.Windows.Forms.Label
        Me.TxtAbono = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.TxtSaldo = New System.Windows.Forms.TextBox
        Me.Label94 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label86 = New System.Windows.Forms.Label
        Me.TxtMuestreoPrecioUn = New System.Windows.Forms.TextBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.TxtMuestreoCant = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.TxtIva = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.TxtMuestreo = New System.Windows.Forms.TextBox
        Me.TxtNeto = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.TxtSubTotal = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.TxtDesctPesos = New System.Windows.Forms.TextBox
        Me.TxtDescto = New System.Windows.Forms.TextBox
        Me.Label92 = New System.Windows.Forms.Label
        Me.TxtValorMod = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.tt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.oo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCodificacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABMuestrasMod.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DGFoliarMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGTejidosMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DGAguaMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DGSueloMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DGFertOrgMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DGFertQuiMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DGOtrosMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.DGVentaMod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GRBNLabCod.SuspendLayout()
        CType(Me.DGTablaNlab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbJockerMod.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tt
        '
        Me.tt.DataSetName = "Cjto_Tablas"
        Me.tt.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'oo
        '
        Me.oo.DataSetName = "Cjto_Orden"
        Me.oo.Locale = New System.Globalization.CultureInfo("en-US")
        '
        'DGCodificacion
        '
        Me.DGCodificacion.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGCodificacion.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGCodificacion.CaptionVisible = False
        Me.DGCodificacion.DataMember = "OT_CODIFICACION_PASO"
        Me.DGCodificacion.DataSource = Me.oo
        Me.DGCodificacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGCodificacion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGCodificacion.Location = New System.Drawing.Point(0, 0)
        Me.DGCodificacion.Name = "DGCodificacion"
        Me.DGCodificacion.ReadOnly = True
        Me.DGCodificacion.Size = New System.Drawing.Size(1136, 152)
        Me.DGCodificacion.TabIndex = 141
        Me.DGCodificacion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DGCodificacion
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn27})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "OT_CODIFICACION_PASO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Código"
        Me.DataGridTextBoxColumn1.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 45
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 610
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Lab-Desde"
        Me.DataGridTextBoxColumn3.MappingName = "OTC_NLAB_DESDE"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 70
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Lab_Hasta"
        Me.DataGridTextBoxColumn4.MappingName = "OTC_NLAB_HASTA"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 70
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Cant"
        Me.DataGridTextBoxColumn5.MappingName = "OTC_CANT_MUESTRAS"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "####,###"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn6.MappingName = "OTC_PRECIOUN"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "####,###"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Neto"
        Me.DataGridTextBoxColumn7.MappingName = "OTC_PRECIONET"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Gr"
        Me.DataGridTextBoxColumn27.MappingName = "OTC_GRUPO"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 20
        '
        'BTJocker
        '
        Me.BTJocker.Location = New System.Drawing.Point(953, 608)
        Me.BTJocker.Name = "BTJocker"
        Me.BTJocker.Size = New System.Drawing.Size(88, 23)
        Me.BTJocker.TabIndex = 137
        Me.BTJocker.Text = "Jocker"
        '
        'TABMuestrasMod
        '
        Me.TABMuestrasMod.Controls.Add(Me.TabPage1)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage2)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage3)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage4)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage6)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage5)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage7)
        Me.TABMuestrasMod.Controls.Add(Me.TabPage8)
        Me.TABMuestrasMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TABMuestrasMod.Location = New System.Drawing.Point(0, 312)
        Me.TABMuestrasMod.Name = "TABMuestrasMod"
        Me.TABMuestrasMod.SelectedIndex = 0
        Me.TABMuestrasMod.Size = New System.Drawing.Size(848, 440)
        Me.TABMuestrasMod.TabIndex = 20
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DGFoliarMod)
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(840, 413)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1.Foliar             "
        '
        'DGFoliarMod
        '
        Me.DGFoliarMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFoliarMod.CaptionVisible = False
        Me.DGFoliarMod.DataMember = "ANALISIS_FOLIAR"
        Me.DGFoliarMod.DataSource = Me.tt
        Me.DGFoliarMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFoliarMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGFoliarMod.Location = New System.Drawing.Point(0, 8)
        Me.DGFoliarMod.Name = "DGFoliarMod"
        Me.DGFoliarMod.ReadOnly = True
        Me.DGFoliarMod.Size = New System.Drawing.Size(792, 384)
        Me.DGFoliarMod.TabIndex = 0
        Me.DGFoliarMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.DGFoliarMod
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ANALISIS_FOLIAR"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Cód"
        Me.DataGridTextBoxColumn8.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 40
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn9.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 550
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = "###,###"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn10.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 46
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 40
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 46
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 30
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGTejidosMod)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(840, 413)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2. + Tejidos"
        Me.TabPage2.Visible = False
        '
        'DGTejidosMod
        '
        Me.DGTejidosMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGTejidosMod.CaptionVisible = False
        Me.DGTejidosMod.DataMember = "ANALISIS_TEJIDO"
        Me.DGTejidosMod.DataSource = Me.tt
        Me.DGTejidosMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGTejidosMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTejidosMod.Location = New System.Drawing.Point(0, 8)
        Me.DGTejidosMod.Name = "DGTejidosMod"
        Me.DGTejidosMod.ReadOnly = True
        Me.DGTejidosMod.Size = New System.Drawing.Size(792, 384)
        Me.DGTejidosMod.TabIndex = 3
        Me.DGTejidosMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.DGTejidosMod
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "ANALISIS_TEJIDO"
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "Cód."
        Me.DataGridTextBoxColumn28.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 40
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn29.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 550
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn30.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 46
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 40
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 46
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DGAguaMod)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(840, 413)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3. Agua             "
        Me.TabPage3.Visible = False
        '
        'DGAguaMod
        '
        Me.DGAguaMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAguaMod.CaptionVisible = False
        Me.DGAguaMod.DataMember = "ANALISIS_AGUA"
        Me.DGAguaMod.DataSource = Me.tt
        Me.DGAguaMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGAguaMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGAguaMod.Location = New System.Drawing.Point(0, 8)
        Me.DGAguaMod.Name = "DGAguaMod"
        Me.DGAguaMod.ReadOnly = True
        Me.DGAguaMod.Size = New System.Drawing.Size(792, 384)
        Me.DGAguaMod.TabIndex = 3
        Me.DGAguaMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.DGAguaMod
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "ANALISIS_AGUA"
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "Cód."
        Me.DataGridTextBoxColumn34.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 40
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn35.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 550
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = "###,###"
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn36.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 46
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Format = ""
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 40
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Format = ""
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 46
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Format = ""
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 30
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DGSueloMod)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(840, 413)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "4. Suelo           "
        Me.TabPage4.Visible = False
        '
        'DGSueloMod
        '
        Me.DGSueloMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGSueloMod.CaptionVisible = False
        Me.DGSueloMod.DataMember = "ANALISIS_SUELO"
        Me.DGSueloMod.DataSource = Me.tt
        Me.DGSueloMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGSueloMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGSueloMod.Location = New System.Drawing.Point(0, 8)
        Me.DGSueloMod.Name = "DGSueloMod"
        Me.DGSueloMod.ReadOnly = True
        Me.DGSueloMod.Size = New System.Drawing.Size(792, 384)
        Me.DGSueloMod.TabIndex = 3
        Me.DGSueloMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DGSueloMod
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "ANALISIS_SUELO"
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Cód"
        Me.DataGridTextBoxColumn14.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 40
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn15.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 550
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn16.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 46
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 40
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 46
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 30
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DGFertOrgMod)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(840, 413)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "5. Fert-Org        "
        Me.TabPage6.Visible = False
        '
        'DGFertOrgMod
        '
        Me.DGFertOrgMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFertOrgMod.CaptionVisible = False
        Me.DGFertOrgMod.DataMember = "ANALISIS_FERORG"
        Me.DGFertOrgMod.DataSource = Me.tt
        Me.DGFertOrgMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFertOrgMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGFertOrgMod.Location = New System.Drawing.Point(0, 8)
        Me.DGFertOrgMod.Name = "DGFertOrgMod"
        Me.DGFertOrgMod.ReadOnly = True
        Me.DGFertOrgMod.Size = New System.Drawing.Size(792, 384)
        Me.DGFertOrgMod.TabIndex = 3
        Me.DGFertOrgMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle7})
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.DataGrid = Me.DGFertOrgMod
        Me.DataGridTableStyle7.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn40, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45})
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "ANALISIS_FERORG"
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Cód"
        Me.DataGridTextBoxColumn40.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 40
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn41.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 550
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Format = "###,###"
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn42.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.Width = 46
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Format = ""
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 40
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 46
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = ""
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.Width = 30
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DGFertQuiMod)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(840, 413)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "6. Fert-Qui        "
        Me.TabPage5.Visible = False
        '
        'DGFertQuiMod
        '
        Me.DGFertQuiMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFertQuiMod.CaptionVisible = False
        Me.DGFertQuiMod.DataMember = "ANALISIS_FERQUI"
        Me.DGFertQuiMod.DataSource = Me.tt
        Me.DGFertQuiMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGFertQuiMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGFertQuiMod.Location = New System.Drawing.Point(0, 8)
        Me.DGFertQuiMod.Name = "DGFertQuiMod"
        Me.DGFertQuiMod.ReadOnly = True
        Me.DGFertQuiMod.Size = New System.Drawing.Size(792, 384)
        Me.DGFertQuiMod.TabIndex = 3
        Me.DGFertQuiMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle8})
        '
        'DataGridTableStyle8
        '
        Me.DataGridTableStyle8.DataGrid = Me.DGFertQuiMod
        Me.DataGridTableStyle8.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn47, Me.DataGridTextBoxColumn48, Me.DataGridTextBoxColumn49, Me.DataGridTextBoxColumn50, Me.DataGridTextBoxColumn51})
        Me.DataGridTableStyle8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle8.MappingName = "ANALISIS_FERQUI"
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "Cód."
        Me.DataGridTextBoxColumn46.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 40
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Format = ""
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn47.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.Width = 550
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Format = "###,###"
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn48.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 46
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 40
        '
        'DataGridTextBoxColumn50
        '
        Me.DataGridTextBoxColumn50.Format = ""
        Me.DataGridTextBoxColumn50.FormatInfo = Nothing
        Me.DataGridTextBoxColumn50.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn50.NullText = ""
        Me.DataGridTextBoxColumn50.Width = 46
        '
        'DataGridTextBoxColumn51
        '
        Me.DataGridTextBoxColumn51.Format = ""
        Me.DataGridTextBoxColumn51.FormatInfo = Nothing
        Me.DataGridTextBoxColumn51.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn51.NullText = ""
        Me.DataGridTextBoxColumn51.Width = 30
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DGOtrosMod)
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(840, 413)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "7.+Análisis       "
        Me.TabPage7.Visible = False
        '
        'DGOtrosMod
        '
        Me.DGOtrosMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOtrosMod.CaptionVisible = False
        Me.DGOtrosMod.DataMember = "ANALISIS_OTROS"
        Me.DGOtrosMod.DataSource = Me.tt
        Me.DGOtrosMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGOtrosMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGOtrosMod.Location = New System.Drawing.Point(0, 8)
        Me.DGOtrosMod.Name = "DGOtrosMod"
        Me.DGOtrosMod.ReadOnly = True
        Me.DGOtrosMod.Size = New System.Drawing.Size(792, 384)
        Me.DGOtrosMod.TabIndex = 3
        Me.DGOtrosMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle9})
        '
        'DataGridTableStyle9
        '
        Me.DataGridTableStyle9.DataGrid = Me.DGOtrosMod
        Me.DataGridTableStyle9.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54, Me.DataGridTextBoxColumn55, Me.DataGridTextBoxColumn56, Me.DataGridTextBoxColumn57})
        Me.DataGridTableStyle9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle9.MappingName = "ANALISIS_OTROS"
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Format = ""
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "Cód"
        Me.DataGridTextBoxColumn52.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 40
        '
        'DataGridTextBoxColumn53
        '
        Me.DataGridTextBoxColumn53.Format = ""
        Me.DataGridTextBoxColumn53.FormatInfo = Nothing
        Me.DataGridTextBoxColumn53.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn53.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn53.NullText = ""
        Me.DataGridTextBoxColumn53.Width = 550
        '
        'DataGridTextBoxColumn54
        '
        Me.DataGridTextBoxColumn54.Format = ""
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn54.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 46
        '
        'DataGridTextBoxColumn55
        '
        Me.DataGridTextBoxColumn55.Format = ""
        Me.DataGridTextBoxColumn55.FormatInfo = Nothing
        Me.DataGridTextBoxColumn55.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn55.NullText = ""
        Me.DataGridTextBoxColumn55.Width = 40
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Format = ""
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 46
        '
        'DataGridTextBoxColumn57
        '
        Me.DataGridTextBoxColumn57.Format = ""
        Me.DataGridTextBoxColumn57.FormatInfo = Nothing
        Me.DataGridTextBoxColumn57.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn57.NullText = ""
        Me.DataGridTextBoxColumn57.Width = 30
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.DGVentaMod)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(840, 413)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "8. Kit,Otros       "
        Me.TabPage8.Visible = False
        '
        'DGVentaMod
        '
        Me.DGVentaMod.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVentaMod.CaptionVisible = False
        Me.DGVentaMod.DataMember = "ANALISIS_VENTA"
        Me.DGVentaMod.DataSource = Me.tt
        Me.DGVentaMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVentaMod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGVentaMod.Location = New System.Drawing.Point(0, 8)
        Me.DGVentaMod.Name = "DGVentaMod"
        Me.DGVentaMod.ReadOnly = True
        Me.DGVentaMod.Size = New System.Drawing.Size(792, 384)
        Me.DGVentaMod.TabIndex = 3
        Me.DGVentaMod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle10})
        '
        'DataGridTableStyle10
        '
        Me.DataGridTableStyle10.DataGrid = Me.DGVentaMod
        Me.DataGridTableStyle10.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn58, Me.DataGridTextBoxColumn59, Me.DataGridTextBoxColumn60, Me.DataGridTextBoxColumn61, Me.DataGridTextBoxColumn62, Me.DataGridTextBoxColumn63})
        Me.DataGridTableStyle10.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle10.MappingName = "ANALISIS_VENTA"
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "Cód."
        Me.DataGridTextBoxColumn58.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 40
        '
        'DataGridTextBoxColumn59
        '
        Me.DataGridTextBoxColumn59.Format = ""
        Me.DataGridTextBoxColumn59.FormatInfo = Nothing
        Me.DataGridTextBoxColumn59.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn59.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn59.NullText = ""
        Me.DataGridTextBoxColumn59.Width = 550
        '
        'DataGridTextBoxColumn60
        '
        Me.DataGridTextBoxColumn60.Format = ""
        Me.DataGridTextBoxColumn60.FormatInfo = Nothing
        Me.DataGridTextBoxColumn60.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn60.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn60.NullText = ""
        Me.DataGridTextBoxColumn60.Width = 46
        '
        'DataGridTextBoxColumn61
        '
        Me.DataGridTextBoxColumn61.Format = ""
        Me.DataGridTextBoxColumn61.FormatInfo = Nothing
        Me.DataGridTextBoxColumn61.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn61.NullText = ""
        Me.DataGridTextBoxColumn61.Width = 40
        '
        'DataGridTextBoxColumn62
        '
        Me.DataGridTextBoxColumn62.Format = ""
        Me.DataGridTextBoxColumn62.FormatInfo = Nothing
        Me.DataGridTextBoxColumn62.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn62.NullText = ""
        Me.DataGridTextBoxColumn62.Width = 46
        '
        'DataGridTextBoxColumn63
        '
        Me.DataGridTextBoxColumn63.Format = ""
        Me.DataGridTextBoxColumn63.FormatInfo = Nothing
        Me.DataGridTextBoxColumn63.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn63.NullText = ""
        Me.DataGridTextBoxColumn63.Width = 30
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.BTJockerMod)
        Me.GroupBox4.Controls.Add(Me.RdbIfrIoc)
        Me.GroupBox4.Controls.Add(Me.RdbTodosMod)
        Me.GroupBox4.Controls.Add(Me.RdbIfr)
        Me.GroupBox4.Controls.Add(Me.Label142)
        Me.GroupBox4.Controls.Add(Me.Label141)
        Me.GroupBox4.Controls.Add(Me.RdbCfrCoc)
        Me.GroupBox4.Controls.Add(Me.RdbCfr)
        Me.GroupBox4.Controls.Add(Me.Label76)
        Me.GroupBox4.Location = New System.Drawing.Point(896, 336)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 152)
        Me.GroupBox4.TabIndex = 136
        Me.GroupBox4.TabStop = False
        '
        'BTJockerMod
        '
        Me.BTJockerMod.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTJockerMod.Location = New System.Drawing.Point(88, 120)
        Me.BTJockerMod.Name = "BTJockerMod"
        Me.BTJockerMod.Size = New System.Drawing.Size(72, 24)
        Me.BTJockerMod.TabIndex = 33
        Me.BTJockerMod.Text = "Jocker"
        '
        'RdbIfrIoc
        '
        Me.RdbIfrIoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbIfrIoc.Location = New System.Drawing.Point(144, 64)
        Me.RdbIfrIoc.Name = "RdbIfrIoc"
        Me.RdbIfrIoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbIfrIoc.Size = New System.Drawing.Size(64, 13)
        Me.RdbIfrIoc.TabIndex = 5
        Me.RdbIfrIoc.Text = "IFR+IOC"
        Me.RdbIfrIoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RdbTodosMod
        '
        Me.RdbTodosMod.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbTodosMod.Location = New System.Drawing.Point(88, 96)
        Me.RdbTodosMod.Name = "RdbTodosMod"
        Me.RdbTodosMod.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbTodosMod.Size = New System.Drawing.Size(56, 13)
        Me.RdbTodosMod.TabIndex = 6
        Me.RdbTodosMod.Text = "Todos"
        '
        'RdbIfr
        '
        Me.RdbIfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbIfr.Location = New System.Drawing.Point(88, 64)
        Me.RdbIfr.Name = "RdbIfr"
        Me.RdbIfr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbIfr.Size = New System.Drawing.Size(40, 13)
        Me.RdbIfr.TabIndex = 4
        Me.RdbIfr.Text = "IFR"
        Me.RdbIfr.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label142
        '
        Me.Label142.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(32, 64)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(56, 16)
        Me.Label142.TabIndex = 3
        Me.Label142.Text = "Individual:"
        '
        'Label141
        '
        Me.Label141.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.Location = New System.Drawing.Point(32, 40)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(56, 16)
        Me.Label141.TabIndex = 2
        Me.Label141.Text = "Combos  :"
        '
        'RdbCfrCoc
        '
        Me.RdbCfrCoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCfrCoc.Location = New System.Drawing.Point(136, 40)
        Me.RdbCfrCoc.Name = "RdbCfrCoc"
        Me.RdbCfrCoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbCfrCoc.Size = New System.Drawing.Size(72, 13)
        Me.RdbCfrCoc.TabIndex = 1
        Me.RdbCfrCoc.Text = "CFR+COC"
        Me.RdbCfrCoc.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RdbCfr
        '
        Me.RdbCfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbCfr.Location = New System.Drawing.Point(72, 40)
        Me.RdbCfr.Name = "RdbCfr"
        Me.RdbCfr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbCfr.Size = New System.Drawing.Size(56, 14)
        Me.RdbCfr.TabIndex = 0
        Me.RdbCfr.Text = "CFR"
        Me.RdbCfr.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label76.Location = New System.Drawing.Point(40, 8)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(176, 16)
        Me.Label76.TabIndex = 7
        Me.Label76.Text = "Filtro de Análisis"
        Me.Label76.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GRBNLabCod
        '
        Me.GRBNLabCod.Controls.Add(Me.Button1)
        Me.GRBNLabCod.Controls.Add(Me.Label1)
        Me.GRBNLabCod.Controls.Add(Me.DGTablaNlab)
        Me.GRBNLabCod.Location = New System.Drawing.Point(0, -8)
        Me.GRBNLabCod.Name = "GRBNLabCod"
        Me.GRBNLabCod.Size = New System.Drawing.Size(1144, 304)
        Me.GRBNLabCod.TabIndex = 145
        Me.GRBNLabCod.TabStop = False
        Me.GRBNLabCod.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1128, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "X"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mantenedor N° Laboratorios / Codigos de análisis"
        '
        'DGTablaNlab
        '
        Me.DGTablaNlab.BackgroundColor = System.Drawing.SystemColors.Info
        Me.DGTablaNlab.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGTablaNlab.CaptionVisible = False
        Me.DGTablaNlab.DataMember = "TABLA_NLABCOD"
        Me.DGTablaNlab.DataSource = Me.tt
        Me.DGTablaNlab.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGTablaNlab.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DGTablaNlab.Location = New System.Drawing.Point(0, 24)
        Me.DGTablaNlab.Name = "DGTablaNlab"
        Me.DGTablaNlab.ReadOnly = True
        Me.DGTablaNlab.Size = New System.Drawing.Size(1144, 280)
        Me.DGTablaNlab.TabIndex = 1
        Me.DGTablaNlab.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.DGTablaNlab
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "TABLA_NLABCOD"
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn20.MappingName = "TMU_MUESTRA"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 60
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "N° Lab"
        Me.DataGridTextBoxColumn21.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 50
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Identificación-1"
        Me.DataGridTextBoxColumn22.MappingName = "OT_NLAB_IDENTIFICACION1"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 95
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Identificación-2"
        Me.DataGridTextBoxColumn26.MappingName = "OT_NLAB_IDENTIFICACION2"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 95
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Cód"
        Me.DataGridTextBoxColumn23.MappingName = "ANA_CODIGO1"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 40
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn24.MappingName = "ANA_DESCRIPCION1"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 550
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn25.Format = "####,###"
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn25.MappingName = "ANA_NETO1"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 75
        '
        'GrbJockerMod
        '
        Me.GrbJockerMod.Controls.Add(Me.BTCerrarJocker)
        Me.GrbJockerMod.Controls.Add(Me.Label2)
        Me.GrbJockerMod.Controls.Add(Me.TxtPrecioMod)
        Me.GrbJockerMod.Controls.Add(Me.TxtDescripcionMod)
        Me.GrbJockerMod.Controls.Add(Me.Label74)
        Me.GrbJockerMod.Controls.Add(Me.Label73)
        Me.GrbJockerMod.Controls.Add(Me.CmdAceptarJockerMod)
        Me.GrbJockerMod.Controls.Add(Me.TxtCodigoMod)
        Me.GrbJockerMod.Controls.Add(Me.Label56)
        Me.GrbJockerMod.Location = New System.Drawing.Point(152, 80)
        Me.GrbJockerMod.Name = "GrbJockerMod"
        Me.GrbJockerMod.Size = New System.Drawing.Size(848, 144)
        Me.GrbJockerMod.TabIndex = 146
        Me.GrbJockerMod.TabStop = False
        Me.GrbJockerMod.Visible = False
        '
        'BTCerrarJocker
        '
        Me.BTCerrarJocker.Location = New System.Drawing.Point(832, 8)
        Me.BTCerrarJocker.Name = "BTCerrarJocker"
        Me.BTCerrarJocker.Size = New System.Drawing.Size(16, 16)
        Me.BTCerrarJocker.TabIndex = 8
        Me.BTCerrarJocker.Text = "X"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(824, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Ingreso Jocker"
        '
        'TxtPrecioMod
        '
        Me.TxtPrecioMod.Location = New System.Drawing.Point(768, 48)
        Me.TxtPrecioMod.Multiline = True
        Me.TxtPrecioMod.Name = "TxtPrecioMod"
        Me.TxtPrecioMod.Size = New System.Drawing.Size(72, 48)
        Me.TxtPrecioMod.TabIndex = 6
        Me.TxtPrecioMod.Text = ""
        '
        'TxtDescripcionMod
        '
        Me.TxtDescripcionMod.Location = New System.Drawing.Point(72, 48)
        Me.TxtDescripcionMod.Multiline = True
        Me.TxtDescripcionMod.Name = "TxtDescripcionMod"
        Me.TxtDescripcionMod.Size = New System.Drawing.Size(696, 48)
        Me.TxtDescripcionMod.TabIndex = 5
        Me.TxtDescripcionMod.Text = ""
        '
        'Label74
        '
        Me.Label74.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label74.Location = New System.Drawing.Point(768, 32)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(72, 16)
        Me.Label74.TabIndex = 4
        Me.Label74.Text = "$ Valor"
        '
        'Label73
        '
        Me.Label73.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label73.Location = New System.Drawing.Point(72, 32)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(696, 16)
        Me.Label73.TabIndex = 3
        Me.Label73.Text = "Descripción"
        '
        'CmdAceptarJockerMod
        '
        Me.CmdAceptarJockerMod.Location = New System.Drawing.Point(384, 104)
        Me.CmdAceptarJockerMod.Name = "CmdAceptarJockerMod"
        Me.CmdAceptarJockerMod.Size = New System.Drawing.Size(75, 24)
        Me.CmdAceptarJockerMod.TabIndex = 2
        Me.CmdAceptarJockerMod.Text = "Acepta"
        '
        'TxtCodigoMod
        '
        Me.TxtCodigoMod.Location = New System.Drawing.Point(8, 48)
        Me.TxtCodigoMod.Multiline = True
        Me.TxtCodigoMod.Name = "TxtCodigoMod"
        Me.TxtCodigoMod.Size = New System.Drawing.Size(64, 48)
        Me.TxtCodigoMod.TabIndex = 1
        Me.TxtCodigoMod.Text = ""
        '
        'Label56
        '
        Me.Label56.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label56.Location = New System.Drawing.Point(8, 32)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(64, 16)
        Me.Label56.TabIndex = 0
        Me.Label56.Text = "Código"
        '
        'TxtCPrecio
        '
        Me.TxtCPrecio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPrecio.Location = New System.Drawing.Point(920, 88)
        Me.TxtCPrecio.Name = "TxtCPrecio"
        Me.TxtCPrecio.TabIndex = 147
        Me.TxtCPrecio.Text = ""
        Me.TxtCPrecio.Visible = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.GroupBox12)
        Me.GroupBox9.Controls.Add(Me.BTGraba)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.Location = New System.Drawing.Point(896, 488)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(248, 232)
        Me.GroupBox9.TabIndex = 148
        Me.GroupBox9.TabStop = False
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label87)
        Me.GroupBox12.Controls.Add(Me.Button5)
        Me.GroupBox12.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(120, 96)
        Me.GroupBox12.TabIndex = 36
        Me.GroupBox12.TabStop = False
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label87.Location = New System.Drawing.Point(8, 8)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(100, 16)
        Me.Label87.TabIndex = 35
        Me.Label87.Text = "Modifica Códigos"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(24, 40)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 24)
        Me.Button5.TabIndex = 34
        Me.Button5.Text = "c/u"
        '
        'BTGraba
        '
        Me.BTGraba.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTGraba.Location = New System.Drawing.Point(128, 48)
        Me.BTGraba.Name = "BTGraba"
        Me.BTGraba.Size = New System.Drawing.Size(96, 24)
        Me.BTGraba.TabIndex = 30
        Me.BTGraba.Text = "Graba OT"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.ChkCancelado)
        Me.GroupBox15.Controls.Add(Me.Label91)
        Me.GroupBox15.Controls.Add(Me.RdbAbonoEfectivo)
        Me.GroupBox15.Controls.Add(Me.RdbAbonoCheque)
        Me.GroupBox15.Controls.Add(Me.Label90)
        Me.GroupBox15.Controls.Add(Me.TxtAbono)
        Me.GroupBox15.Controls.Add(Me.Label3)
        Me.GroupBox15.Controls.Add(Me.Label93)
        Me.GroupBox15.Controls.Add(Me.TxtSaldo)
        Me.GroupBox15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox15.Location = New System.Drawing.Point(384, 160)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(264, 96)
        Me.GroupBox15.TabIndex = 151
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "Cancelación"
        '
        'ChkCancelado
        '
        Me.ChkCancelado.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkCancelado.ForeColor = System.Drawing.Color.MediumBlue
        Me.ChkCancelado.Location = New System.Drawing.Point(16, 24)
        Me.ChkCancelado.Name = "ChkCancelado"
        Me.ChkCancelado.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkCancelado.Size = New System.Drawing.Size(88, 16)
        Me.ChkCancelado.TabIndex = 32
        Me.ChkCancelado.Text = "Cancelada"
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label91.Location = New System.Drawing.Point(24, 48)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(40, 16)
        Me.Label91.TabIndex = 31
        Me.Label91.Text = "Abono"
        '
        'RdbAbonoEfectivo
        '
        Me.RdbAbonoEfectivo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAbonoEfectivo.ForeColor = System.Drawing.Color.MediumBlue
        Me.RdbAbonoEfectivo.Location = New System.Drawing.Point(176, 72)
        Me.RdbAbonoEfectivo.Name = "RdbAbonoEfectivo"
        Me.RdbAbonoEfectivo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbAbonoEfectivo.Size = New System.Drawing.Size(72, 16)
        Me.RdbAbonoEfectivo.TabIndex = 25
        Me.RdbAbonoEfectivo.Text = "Efectivo"
        '
        'RdbAbonoCheque
        '
        Me.RdbAbonoCheque.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdbAbonoCheque.ForeColor = System.Drawing.Color.MediumBlue
        Me.RdbAbonoCheque.Location = New System.Drawing.Point(176, 56)
        Me.RdbAbonoCheque.Name = "RdbAbonoCheque"
        Me.RdbAbonoCheque.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RdbAbonoCheque.Size = New System.Drawing.Size(72, 16)
        Me.RdbAbonoCheque.TabIndex = 26
        Me.RdbAbonoCheque.Text = "Cheque"
        '
        'Label90
        '
        Me.Label90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label90.Location = New System.Drawing.Point(56, 48)
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
        Me.TxtAbono.Location = New System.Drawing.Point(88, 48)
        Me.TxtAbono.Name = "TxtAbono"
        Me.TxtAbono.Size = New System.Drawing.Size(64, 21)
        Me.TxtAbono.TabIndex = 11
        Me.TxtAbono.Text = ""
        Me.TxtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(24, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Saldo"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label93.Location = New System.Drawing.Point(56, 72)
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
        Me.TxtSaldo.Location = New System.Drawing.Point(88, 72)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.Size = New System.Drawing.Size(64, 21)
        Me.TxtSaldo.TabIndex = 29
        Me.TxtSaldo.Text = ""
        Me.TxtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label94
        '
        Me.Label94.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label94.Location = New System.Drawing.Point(8, 32)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(64, 16)
        Me.Label94.TabIndex = 34
        Me.Label94.Text = "O.Compra"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(96, 32)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 21)
        Me.TextBox1.TabIndex = 33
        Me.TextBox1.Text = ""
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label86)
        Me.GroupBox5.Controls.Add(Me.TxtMuestreoPrecioUn)
        Me.GroupBox5.Controls.Add(Me.Label55)
        Me.GroupBox5.Controls.Add(Me.TxtMuestreoCant)
        Me.GroupBox5.Controls.Add(Me.Label45)
        Me.GroupBox5.Location = New System.Drawing.Point(648, 160)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(224, 96)
        Me.GroupBox5.TabIndex = 152
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Muestreo"
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.ForeColor = System.Drawing.Color.MediumBlue
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
        Me.TxtMuestreoPrecioUn.Location = New System.Drawing.Point(80, 64)
        Me.TxtMuestreoPrecioUn.Name = "TxtMuestreoPrecioUn"
        Me.TxtMuestreoPrecioUn.Size = New System.Drawing.Size(64, 21)
        Me.TxtMuestreoPrecioUn.TabIndex = 17
        Me.TxtMuestreoPrecioUn.Text = ""
        Me.TxtMuestreoPrecioUn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label55.Location = New System.Drawing.Point(16, 64)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(72, 16)
        Me.Label55.TabIndex = 19
        Me.Label55.Text = "Valor Unit."
        '
        'TxtMuestreoCant
        '
        Me.TxtMuestreoCant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMuestreoCant.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestreoCant.Location = New System.Drawing.Point(80, 32)
        Me.TxtMuestreoCant.Name = "TxtMuestreoCant"
        Me.TxtMuestreoCant.Size = New System.Drawing.Size(32, 21)
        Me.TxtMuestreoCant.TabIndex = 18
        Me.TxtMuestreoCant.Text = ""
        Me.TxtMuestreoCant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label45.Location = New System.Drawing.Point(16, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(64, 16)
        Me.Label45.TabIndex = 16
        Me.Label45.Text = "Cantidad"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label71)
        Me.GroupBox6.Controls.Add(Me.TxtTotal)
        Me.GroupBox6.Controls.Add(Me.Label52)
        Me.GroupBox6.Controls.Add(Me.TxtIva)
        Me.GroupBox6.Controls.Add(Me.Label51)
        Me.GroupBox6.Controls.Add(Me.TxtMuestreo)
        Me.GroupBox6.Controls.Add(Me.TxtNeto)
        Me.GroupBox6.Controls.Add(Me.Label70)
        Me.GroupBox6.Controls.Add(Me.TxtSubTotal)
        Me.GroupBox6.Controls.Add(Me.Label53)
        Me.GroupBox6.Controls.Add(Me.TxtDesctPesos)
        Me.GroupBox6.Controls.Add(Me.TxtDescto)
        Me.GroupBox6.Controls.Add(Me.Label92)
        Me.GroupBox6.Location = New System.Drawing.Point(992, 160)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(152, 168)
        Me.GroupBox6.TabIndex = 153
        Me.GroupBox6.TabStop = False
        '
        'Label71
        '
        Me.Label71.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label71.Location = New System.Drawing.Point(8, 136)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(64, 16)
        Me.Label71.TabIndex = 22
        Me.Label71.Text = "Total     $"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(72, 136)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(64, 21)
        Me.TxtTotal.TabIndex = 23
        Me.TxtTotal.Text = ""
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label52.Location = New System.Drawing.Point(8, 112)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(64, 16)
        Me.Label52.TabIndex = 20
        Me.Label52.Text = "IVA 19%"
        '
        'TxtIva
        '
        Me.TxtIva.BackColor = System.Drawing.SystemColors.Info
        Me.TxtIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIva.Enabled = False
        Me.TxtIva.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIva.Location = New System.Drawing.Point(72, 112)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(64, 21)
        Me.TxtIva.TabIndex = 21
        Me.TxtIva.Text = ""
        Me.TxtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label51.Location = New System.Drawing.Point(8, 64)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(64, 16)
        Me.Label51.TabIndex = 18
        Me.Label51.Text = "Muestreo"
        '
        'TxtMuestreo
        '
        Me.TxtMuestreo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMuestreo.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMuestreo.Location = New System.Drawing.Point(72, 64)
        Me.TxtMuestreo.Name = "TxtMuestreo"
        Me.TxtMuestreo.Size = New System.Drawing.Size(64, 21)
        Me.TxtMuestreo.TabIndex = 19
        Me.TxtMuestreo.Text = ""
        Me.TxtMuestreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNeto
        '
        Me.TxtNeto.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNeto.Enabled = False
        Me.TxtNeto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNeto.Location = New System.Drawing.Point(72, 88)
        Me.TxtNeto.Name = "TxtNeto"
        Me.TxtNeto.Size = New System.Drawing.Size(64, 21)
        Me.TxtNeto.TabIndex = 15
        Me.TxtNeto.Text = ""
        Me.TxtNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label70.Location = New System.Drawing.Point(8, 88)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(48, 16)
        Me.Label70.TabIndex = 14
        Me.Label70.Text = "Neto"
        '
        'TxtSubTotal
        '
        Me.TxtSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSubTotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubTotal.Location = New System.Drawing.Point(72, 40)
        Me.TxtSubTotal.Name = "TxtSubTotal"
        Me.TxtSubTotal.Size = New System.Drawing.Size(64, 21)
        Me.TxtSubTotal.TabIndex = 9
        Me.TxtSubTotal.Text = ""
        Me.TxtSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label53.Location = New System.Drawing.Point(8, 40)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(64, 16)
        Me.Label53.TabIndex = 8
        Me.Label53.Text = "Subtotal"
        '
        'TxtDesctPesos
        '
        Me.TxtDesctPesos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesctPesos.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDesctPesos.Location = New System.Drawing.Point(72, 16)
        Me.TxtDesctPesos.Name = "TxtDesctPesos"
        Me.TxtDesctPesos.Size = New System.Drawing.Size(64, 21)
        Me.TxtDesctPesos.TabIndex = 22
        Me.TxtDesctPesos.Text = ""
        Me.TxtDesctPesos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtDescto
        '
        Me.TxtDescto.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDescto.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescto.Location = New System.Drawing.Point(8, 16)
        Me.TxtDescto.Name = "TxtDescto"
        Me.TxtDescto.Size = New System.Drawing.Size(24, 21)
        Me.TxtDescto.TabIndex = 17
        Me.TxtDescto.Text = ""
        Me.TxtDescto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label92.Location = New System.Drawing.Point(48, 16)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(24, 16)
        Me.Label92.TabIndex = 24
        Me.Label92.Text = "  $"
        Me.Label92.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtValorMod
        '
        Me.TxtValorMod.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtValorMod.Location = New System.Drawing.Point(8, 288)
        Me.TxtValorMod.Name = "TxtValorMod"
        Me.TxtValorMod.Size = New System.Drawing.Size(96, 21)
        Me.TxtValorMod.TabIndex = 154
        Me.TxtValorMod.Text = ""
        Me.TxtValorMod.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label94)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(168, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(216, 96)
        Me.GroupBox1.TabIndex = 155
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orden de Compra"
        '
        'Frm_Mantenedor_OTCodificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1147, 769)
        Me.Controls.Add(Me.TxtValorMod)
        Me.Controls.Add(Me.TxtCPrecio)
        Me.Controls.Add(Me.GrbJockerMod)
        Me.Controls.Add(Me.GRBNLabCod)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox15)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.DGCodificacion)
        Me.Controls.Add(Me.TABMuestrasMod)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.BTJocker)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Mantenedor_OTCodificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor Codigos"
        CType(Me.tt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.oo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCodificacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABMuestrasMod.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DGFoliarMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DGTejidosMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DGAguaMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DGSueloMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DGFertOrgMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DGFertQuiMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DGOtrosMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.DGVentaMod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GRBNLabCod.ResumeLayout(False)
        CType(Me.DGTablaNlab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbJockerMod.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub Frm_Mantenedor_OTCodificacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim FILA_PASO As DataRow
        Dim MyDate As Date
        Dim fila_p As DataRow
        Dim tempAdapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim query As String
        Dim fila As DataRow
        Dim conexion As New SqlConnection(Conexion1)
        Dim dbman As DbManager
        Modifica_Cod = "N"
        'SendKeys.Send("{TAB}")
        Es_Modificacion = "N"
        Esta_Grabada_OT = "N"

        RdbAbonoCheque.Checked = True
        Call Anti_Elimina_lineas()

        AddCellFormattingColumnStyles(Me.DGFoliarMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGTejidosMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGAguaMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGSueloMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGFertQuiMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGFertOrgMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGOtrosMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGVentaMod, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DGCodificacion, New FormatCellEventHandler(AddressOf FormatGridCells))


        AddCellFormattingColumnStyles2(Me.DGTablaNlab, New FormatCellEventHandler(AddressOf FormatGridCells))

        'Me.TransformaMultilinea(Me.DGCodificacion)
        Call Carga_Analisis(1000, "ANALISIS_FOLIAR")
        Call Carga_Analisis(2000, "ANALISIS_TEJIDO")
        Call Carga_Analisis(3000, "ANALISIS_AGUA")
        Call Carga_Analisis(4000, "ANALISIS_SUELO")
        Call Carga_Analisis(5000, "ANALISIS_FERQUI")
        Call Carga_Analisis(6000, "ANALISIS_FERORG")
        Call Carga_Analisis(7000, "ANALISIS_OTROS")
        Call Carga_Analisis(8000, "ANALISIS_VENTA")

        MyDate = Today
        RdbCfr.Checked = True
        Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Clear()
        Cjto_Orden1.Tables("OT_CODIFICACION").Clear()
        Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Clear()
        Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO").Clear()
        Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO3").Clear()


        Call Llena_OtCodificacion()
        Call Llena_Digita_Paso()
        Call Rescata_Valores_y_Factura()

        'Cjto_Orden1.Tables("OTEST_NLAB").Clear()
        'Cjto_Orden1.Tables("ORDEN_TRABAJO").Clear()

        'Cjto_Tablas1.Tables("OTEST_ELEMENTO").Clear()
        'Cjto_Tablas1.Tables("OTEST_ELEMENTO_COMP").Clear()
    End Sub
    Private Sub Rescata_Valores_y_Factura()
        Dim con As New SqlConnection(Conexion1)
        Dim Consulta As String
        con.Open()
        Consulta = "Select OT_SUBTOTAL,OT_NETO,OT_IVA,OT_DESCUENTOPOR,OT_DESCUENTOPESOS," & _
                            "OT_MUESTREO_CANT,OT_MUESTREO_PRECIOUN,OT_MUESTREO," & _
                            "OT_ABONO,OT_ABONOCON,OT_TOTAL FROM ORDEN_TRABAJO WHERE OT_NUMERO=" & Orden_Trabajo
        Dim myCommand1 As New SqlCommand(Consulta, con)
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        myReader1.Read()
        If IsDBNull(myReader1.GetInt32(0)) = False Then TxtSubTotal.Text = Format(myReader1.GetInt32(0), "####,##0")
        If IsDBNull(myReader1.GetInt32(1)) = False Then TxtNeto.Text = Format(myReader1.GetInt32(1), "####,##0")
        If IsDBNull(myReader1.GetInt32(2)) = False Then TxtIva.Text = Format(myReader1.GetInt32(2), "####,##0")
        If IsDBNull(myReader1.GetDouble(3)) = False Then TxtDescto.Text = myReader1.GetDouble(3)
        If IsDBNull(myReader1.GetInt32(4)) = False Then TxtDesctPesos.Text = Format(myReader1.GetInt32(4), "###,##0")
        If IsDBNull(myReader1.GetInt32(5)) = False Then TxtMuestreoCant.Text = myReader1.GetInt32(5)
        If IsDBNull(myReader1.GetInt32(6)) = False Then TxtMuestreoPrecioUn.Text = Format(myReader1.GetInt32(6), "###,##0")
        If IsDBNull(myReader1.GetInt32(7)) = False Then TxtMuestreo.Text = Format(myReader1.GetInt32(7), "###,##0")
        If IsDBNull(myReader1.GetInt32(8)) = False Then TxtAbono.Text = Format(myReader1.GetInt32(8), "####,##0")
        If IsDBNull(myReader1.GetInt32(9)) = False Then
            If myReader1.GetInt32(9) = 1 Then Me.RdbAbonoCheque.Checked = True
            If myReader1.GetInt32(9) = 2 Then Me.RdbAbonoEfectivo.Checked = True
        End If
        If IsDBNull(myReader1.GetInt32(10)) = False Then TxtTotal.Text = Format(myReader1.GetInt32(10), "####,##0") : Total_Factura = myReader1.GetInt32(10)
        If TxtTotal.Text = TxtAbono.Text Then Me.ChkCancelado.Checked = True
        If TxtAbono.Text <> "" Then TxtSaldo.Text = TxtTotal.Text - TxtAbono.Text Else TxtSaldo.Text = TxtTotal.Text
        Ot_Est_Fac = ""
        myReader1.Close()
        con.Close()
    End Sub
    Private Sub Llena_OtCodificacion()
        Dim Fila_Ot_Paso, Fila_Ot_Cod As DataRow
        Dim DbMan As DbManager
        Dim Nlab_Aux, IncGrupo As Integer
        Dim DesMuestra As String
        Dim Test1 As DbManager = New DbManager("OT_CODIFICACION", Conexion1)
        Dim query1 As String = "Select OT_NUMERO,TMU_CODIGO,OTC_NLAB_DESDE,ANA_CODIGO,ANA_ANALISIS,OTC_CANT_MUESTRAS,OTC_NLAB_HASTA,OTC_PRECIOUN,OTC_PRECIONET from OT_CODIFICACION where OT_NUMERO=" & Orden_Trabajo
        Test1.Selecccionar(Cjto_Orden1, query1)
        IncGrupo = 1
        For Each Fila_Ot_Cod In Cjto_Orden1.Tables("OT_CODIFICACION").Rows
            If Nlab_Aux <> 0 And Nlab_Aux <> Fila_Ot_Cod("OTC_NLAB_HASTA") Then IncGrupo = IncGrupo + 1
            Fila_Ot_Paso = Cjto_Orden1.Tables("OT_CODIFICACION_PASO").NewRow
            Fila_Ot_Paso.Item("ANA_CODIGO") = Fila_Ot_Cod("ANA_CODIGO")
            Fila_Ot_Paso.Item("ANA_ANALISIS") = Fila_Ot_Cod("ANA_ANALISIS")
            Fila_Ot_Paso.Item("OTC_CANT_MUESTRAS") = Fila_Ot_Cod("OTC_CANT_MUESTRAS")
            Fila_Ot_Paso.Item("OTC_NLAB_DESDE") = Fila_Ot_Cod("OTC_NLAB_DESDE")
            Fila_Ot_Paso.Item("OTC_NLAB_HASTA") = Fila_Ot_Cod("OTC_NLAB_HASTA")
            Fila_Ot_Paso.Item("OTC_PRECIOUN") = Fila_Ot_Cod("OTC_PRECIOUN")
            Fila_Ot_Paso.Item("OTC_PRECIONET") = Fila_Ot_Cod("OTC_PRECIONET")
            Fila_Ot_Paso.Item("OTC_GRUPO") = IncGrupo
            Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows.Add(Fila_Ot_Paso)
        Next
    End Sub

    Private Sub Llena_Digita_Paso()
        Dim DbMan As DbManager
        Dim Test1 As DbManager = New DbManager("DIGITA_RESULTADOS_PASO", Conexion1)
        Dim query1 As String = "Select TMU_CODIGO,OT_NLAB,ELE_CODIGO,DIGRES_FECHA,DIGRES_ANALIZADO_POR,DIGRES_DIGITADO_POR,DIGRES_BLANCO,DIGRES_FACTOR,DIGRES_LECTURA,DIGRES_RESULTADO,ELE_ESTADO from DIGITA_RESULTADOS where OT_NUMERO=" & Orden_Trabajo
        Test1.Selecccionar(Cjto_Tablas1, query1)
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

    Private Sub Anti_Elimina_lineas()
        DGCodificacion.DataSource = Cjto_Orden1.Tables("OT_CODIFICACION_PASO")
        DGTablaNlab.DataSource = Cjto_Tablas1.Tables("TABLA_NLABCOD")
        DGFoliarMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_FOLIAR")
        DGTejidosMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_TEJIDO")
        DGAguaMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_AGUA")
        DGSueloMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_SUELO")
        DGFertQuiMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_FERQUI")
        DGFertOrgMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_FERORG")
        DGOtrosMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_OTROS")
        DGVentaMod.DataSource = Cjto_Tablas1.Tables("ANALISIS_VENTA")
    End Sub

    Private Sub FormatGridCells(ByVal sender As Object, ByVal e As DataGridFormatCellEventArgs, ByVal grid As DataGrid)
        ' color row 1 red
        'color column 4 blue
        Dim mycm As CurrencyManager = CType(Me.BindingContext(grid.DataSource, grid.DataMember), CurrencyManager)
        ' Retrieve the default DataView of the DataGrid
        Dim mydv As DataView = CType(mycm.List, DataView)
        ' Use Currency Manager and DataView to retrieve the Current Row
        Dim row As DataRow
        Dim j As Integer
        j = 0
        For Each row In mydv.Table.Rows
            'Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(row("ANA_CODIGO"))
            Try
                If Mid(row("ANA_NIVEL_PRECIO"), 2, 2) = "OC" Then
                    If e.Row = j Then
                        e.BackBrush = System.Drawing.Brushes.SkyBlue
                    End If
                End If
                If Cjto_Tablas1.Tables("SUBMUESTRA").Rows.Contains(row("ANA_CODIGO")) Or Cjto_Tablas1.Tables("MUESTRA").Rows.Contains(row("ANA_CODIGO")) Then
                    If (e.Row = j) Then
                        'e.BackBrush = Brushes.Beige
                        e.TextFont = New Font(e.TextFont.Name, 8, FontStyle.Bold)
                    End If
                End If
                j += 1
            Catch ex As Exception
            End Try
        Next
    End Sub

    Private Sub AddCellFormattingColumnStyles(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < dt.Columns.Count)
            Dim cs As DataGridFormattableTextBoxColumn
            Try
                cs = New DataGridFormattableTextBoxColumn(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid
            Catch ex As Exception
                Exit Do
            End Try
            AddHandler cs.SetCellFormat, handler
            If j >= 2 Then
                ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
            ElseIf j = 1 Then
                Dim cs2 As New CGridMultiLineTextBoxStyle(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
                cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs2.grid = grid
                AddHandler cs2.SetCellFormat, handler
                ts.GridColumnStyles.Add(cs2)
            Else
                ts.GridColumnStyles.Add(cs)
            End If
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub
    Private Sub AddCellFormattingColumnStyles2(ByVal grid As DataGrid, ByVal handler As FormatCellEventHandler)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j As Integer
        j = 0
        Do While (j < dt.Columns.Count)
            Dim cs As DataGridFormattableTextBoxColumn
            Try
                cs = New DataGridFormattableTextBoxColumn(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid
            Catch ex As Exception
                Exit Do
            End Try
            AddHandler cs.SetCellFormat, handler
            If j >= 6 Then
                ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
            ElseIf j = 5 Then
                Dim cs2 As New CGridMultiLineTextBoxStyle(grid.TableStyles(0).GridColumnStyles(j).MappingName, j)
                cs2.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs2.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs2.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs2.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs2.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs2.grid = grid
                AddHandler cs2.SetCellFormat, handler
                ts.GridColumnStyles.Add(cs2)
            Else
                ts.GridColumnStyles.Add(cs)
            End If
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub DGValorMod_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGFoliarMod.CurrentCellChanged, DGTejidosMod.CurrentCellChanged, _
        DGAguaMod.CurrentCellChanged, DGSueloMod.CurrentCellChanged, DGFertOrgMod.CurrentCellChanged, DGFertQuiMod.CurrentCellChanged, DGOtrosMod.CurrentCellChanged, DGVentaMod.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim Fila_Grilla_C As Integer

        Dim muestra As Boolean = False
        myGriC = CType(sender, DataGrid)
        ffi = myGriC.CurrentCell.RowNumber
        If TxtValorMod.Visible = True Then TxtValorMod.Visible = False
        'If myGriC.CurrentCell.ColumnNumber = 1 Then GRBusca.Visible = True : Exit Sub
        If myGriC.CurrentCell.ColumnNumber < 3 Then Exit Sub
        Columna34 = myGriC.CurrentCell.ColumnNumber
        Dim CeldaAlto As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).X + myGriC.Left
        Dim Posiciony As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Y + myGriC.Top
        TxtValorMod.Left = Posicionx + 4
        TxtValorMod.Top = Posiciony + 283
        TxtValorMod.Height = CeldaAlto
        TxtValorMod.Width = CeldaAncho
        TxtValorMod.Visible = True
        TxtValorMod.Text = ""
        TxtValorMod.Enabled = True
        TxtValorMod.Focus()
        TxtValorMod.SelectionStart = 1
        If IsDBNull(myGriC.Item(ffi, 3)) = False Then TxtValorMod.Text = myGriC.Item(ffi, 3)
        If IsDBNull(myGriC.Item(ffi, 4)) = False Then TxtValorMod.Text = myGriC.Item(ffi, 4)
yam:
    End Sub

    Private Sub TxtValorMod_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtValorMod.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case Columna34
            Case 3
                If e.KeyChar = Chr(13) Then
                    If TxtValorMod.Text <> "" Then
                        NETO = CInt(myGriC.Item(ffi, 2))
                        myGriC.Item(ffi, 3) = TxtValorMod.Text
                        DESCUENTO = (CDbl(myGriC.Item(ffi, 3)) / 100) * NETO
                        myGriC.Item(ffi, 4) = NETO - DESCUENTO
                        mycell.ColumnNumber = 4
                        mycell.RowNumber = ffi
                        myGriC.CurrentCell = mycell
                    End If
                End If
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TxtValorMod.Text <> "" Then
                        myGriC.Item(ffi, 4) = TxtValorMod.Text
                        RESTA = CInt(myGriC.Item(ffi, 2)) - CInt(myGriC.Item(ffi, 4))
                        NET = myGriC.Item(ffi, 2)
                        Try
                            myGriC.Item(ffi, 3) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        Catch ex As Exception
                        End Try

                        mycell.ColumnNumber = 2
                        mycell.RowNumber = ffi
                        myGriC.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub DGFoliarMod_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGFoliarMod.DoubleClick, DGTejidosMod.DoubleClick, _
    DGAguaMod.DoubleClick, DGSueloMod.DoubleClick, DGFertOrgMod.DoubleClick, DGFertQuiMod.DoubleClick, DGVentaMod.DoubleClick, DGVentaMod.DoubleClick
        Dim Fila_Muestra As DataRow
        Dim mycell As New DataGridCell
        Dim SubTotal, Neto, Suma_Cod, Fila_Num, pos As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim ObjSum As Object
        Fila_Num = myGrid.CurrentCell.RowNumber
        codigo_antiguo = 0

        If GrbJockerMod.Visible = True Then
            If TxtDescripcionMod.Text = "" Then
                TxtDescripcionMod.Text = myGrid.Item(Fila_Num, 1)
                If IsDBNull(myGrid.Item(Fila_Num, 4)) = False Then
                    TxtPrecioMod.Text = myGrid.Item(Fila_Num, 4)
                Else
                    TxtPrecioMod.Text = myGrid.Item(Fila_Num, 2)
                End If
            Else
                TxtDescripcionMod.Text = TxtDescripcionMod.Text & "-" & myGrid.Item(Fila_Num, 1)
                If IsDBNull(myGrid.Item(Fila_Num, 4)) = False Then
                    TxtPrecioMod.Text = CInt(TxtPrecioMod.Text) + CInt(myGrid.Item(Fila_Num, 4))
                Else
                    TxtPrecioMod.Text = CInt(TxtPrecioMod.Text) + CInt(myGrid.Item(Fila_Num, 2))
                End If
            End If
            Call Carga_Elementos_Jocker_Mod(myGrid.Item(Fila_Num, 0))
            GoTo JockerUOtro
        End If

        If Me.GRBNLabCod.Visible = True Then
            If Mid(CStr(myGrid.Item(Fila_Num, 0)), 1, 1) <> Mid(CStr(DGTablaNlab.Item(Fila_Cod, 4)), 1, 1) Then MsgBox("No coinciden los tipo de muestra") : GoTo JockerUOtro
            Me.DGTablaNlab.Item(Fila_Cod, Columna_Cod) = myGrid.Item(Fila_Num, 0)
            Me.DGTablaNlab.Item(Fila_Cod, 5) = myGrid.Item(Fila_Num, 1)
            If IsDBNull(myGrid.Item(Fila_Num, 4)) = False Then
                Me.DGTablaNlab.Item(Fila_Cod, 6) = myGrid.Item(Fila_Num, 4)
            Else
                Me.DGTablaNlab.Item(Fila_Cod, 6) = myGrid.Item(Fila_Num, 2)
            End If
        Else
            If Mid(CStr(myGrid.Item(Fila_Num, 0)), 1, 1) = Mid(CStr(DGCodificacion.Item(Fila_Ant, 0)), 1, 1) Then
                codigo_antiguo = Me.DGCodificacion.Item(Fila_Cod, 0)
                Me.DGCodificacion.Item(Fila_Ant, 0) = myGrid.Item(Fila_Num, 0)
                Me.DGCodificacion.Item(Fila_Ant, 1) = myGrid.Item(Fila_Num, 1)
                If IsDBNull(myGrid.Item(Fila_Num, 4)) = False Then
                    Me.DGCodificacion.Item(Fila_Ant, 5) = myGrid.Item(Fila_Num, 4)
                Else
                    Me.DGCodificacion.Item(Fila_Ant, 5) = myGrid.Item(Fila_Num, 2)
                End If
                Me.DGCodificacion.Item(Fila_Ant, 6) = Me.DGCodificacion.Item(Fila_Ant, 5) * Me.DGCodificacion.Item(Fila_Ant, 4)

                Call Calcula_Valores()

                If Fila_Ant = 0 Then
                    mycell.ColumnNumber = 0
                    mycell.RowNumber = Fila_Ant + 1
                    DGCodificacion.CurrentCell = mycell
                Else
                    mycell.ColumnNumber = 0
                    mycell.RowNumber = Fila_Ant - 1
                    DGCodificacion.CurrentCell = mycell
                End If
                If ChkCancelado.Checked = True Then
                    ChkCancelado.Checked = False
                    ChkCancelado.Checked = True
                End If
                TxtSubTotal.Focus()
                'Call Cambia_Codigos_nlabcod(DGCodificacion.Item(Fila_Cod, 0), DGCodificacion.Item(Fila_Cod, 2), DGCodificacion.Item(Fila_Cod, 3), Me.DGCodificacion.Item(Fila_Cod, 1))
            Else
                MsgBox("No coincide el Tipo de Muestra")
            End If

        End If
        codigo_antiguo = 0 : Fila_Ant = 0
JockerUOtro:
    End Sub

    Private Sub Carga_Elementos_Jocker_Mod(ByVal CodEle As Double)
        Dim DbMan As DbManager
        Dim query As String
        DbMan = New DbManager("ANALISIS_ELEMENTOS_PASO", Conexion1)
        query = "Select ANA_CODIGO=" & CDbl(TxtCodigoMod.Text) & ",ELE_CODIGO from ANALISIS_ELEMENTOS where ANA_CODIGO =" & CodEle
        DbMan.Selecccionar(Cjto_Orden1, query)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim HayAlgo As String
        BTGraba.Visible = False
        If Esta_Grabada_OT <> "S" Then
            'Call llena_Tabla_NlabCod(HayAlgo)
            If HayAlgo = "N" Then
                MsgBox("No hay datos para mostrar")
            Else
                Me.GRBNLabCod.Visible = True
            End If
        Else
            MsgBox("La Orden esta grabada , imposible modificar")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Fila_OTC As DataRow
        If Esta_Grabada_OT <> "S" Then
            If Ant_NLabDesde = 0 Then
                For Each Fila_OTC In Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows
                    Ant_NLabDesde = CInt(Fila_OTC("OTC_NLAB_DESDE"))
                    Ant_NLabHasta = CInt(Fila_OTC("OTC_NLAB_HASTA"))
                    Muestra = CInt(Mid(CStr(Fila_OTC("ANA_CODIGO")), 1, 1) & "000")
                    Exit For
                Next
            End If
        Else
            MsgBox("La Orden esta grabada, imposible eliminar")
        End If
    End Sub

    Private Sub Calcula_Valores()
        Dim ObjSum As Object
        Dim SubTotal As Integer
        Dim RESTA, Csubtotal, TotalDesct, CNeto, CMuestreo, Cabono, CDesctPesos, CSaldo, CDesct As Integer
        Dim Cdescuento, RestaSub As Double
        ObjSum = Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Compute("Sum(OTC_PRECIONET)", "OTC_PRECIONET > 0")
        Try
            SubTotal = CInt(ObjSum)
        Catch ex As Exception

        End Try

        If TxtMuestreo.Text <> "" Then CMuestreo = CInt(TxtMuestreo.Text) Else CMuestreo = 0
        SubTotal = SubTotal + CMuestreo
        If TxtAbono.Text <> "" Then Cabono = CDbl(Me.TxtAbono.Text) Else Cabono = 0

        If TxtDescto.Text <> "" Then Cdescuento = CDbl(Me.TxtDescto.Text) Else Cdescuento = 0
        If TxtDesctPesos.Text <> "" Then CDesctPesos = CDbl(Me.TxtDesctPesos.Text) Else CDesctPesos = 0

        If CDesctPesos <> 0 And Cdescuento = 0 Then
            If SubTotal <> 0 Then
                RestaSub = CDesctPesos / SubTotal
                Cdescuento = Format((RestaSub * 100), "##.##")
                TxtDesctPesos.Text = Format(CInt(CDesctPesos), "###,##0")
                TxtDescto.Text = Format(Cdescuento, "##.##")
            End If
        End If

        If CDesctPesos = 0 And Cdescuento <> 0 Then
            TxtDescto.Text = Format(Cdescuento, "##.##")
            CDesctPesos = (SubTotal * CDbl(Cdescuento / 100))
            TxtDesctPesos.Text = Format(CInt(CDesctPesos), "###,##0")
        End If

        TxtAbono.Text = Format(Cabono, "####,##0")
        TxtMuestreo.Text = Format(CMuestreo, "####,##0")
        CNeto = SubTotal - CDesctPesos

        TxtSubTotal.Text = Format(SubTotal, "####,##0")
        TxtNeto.Text = Format(CNeto, "####,##0")
        TxtIva.Text = Format((CNeto * 0.19), "####,##0")
        TxtTotal.Text = Format(CNeto + CInt(TxtIva.Text), "####,##0")
        CSaldo = CInt(TxtTotal.Text) - CInt(TxtAbono.Text)
        TxtSaldo.Text = Format(CSaldo, "####,##0")
        'TxtAbono.Text = ""
        'TxtMuestreoCant.Text = ""
        'TxtMuestreoPrecioUn.Text = ""
        'TxtDescto.Text = ""
        'TxtMuestreo.Text = ""
    End Sub

    Private Sub Radios_Filtros_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RdbCfr.CheckedChanged, RdbCfrCoc.CheckedChanged, RdbIfr.CheckedChanged, RdbIfrIoc.CheckedChanged, RdbTodosMod.CheckedChanged
        Call Filtro_Muestra_Mod()
    End Sub

    Private Sub Filtro_Muestra_Mod()
        Dim yll, texto, MAYU As String
        Dim FILA_DATAROW As DataRow
        Dim mycell As New DataGridCell
        yll = TABMuestrasMod.SelectedTab.Name
        Select Case yll
            Case "TabPage1"
                Cjto_Tablas1.Tables("ANALISIS_FOLIAR").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_FOLIAR", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage2"
                Cjto_Tablas1.Tables("ANALISIS_TEJIDO").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_TEJIDO", Conexion1)

                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage3"
                Cjto_Tablas1.Tables("ANALISIS_AGUA").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_AGUA", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage4"
                Cjto_Tablas1.Tables("ANALISIS_SUELO").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_SUELO", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage5"
                Cjto_Tablas1.Tables("ANALISIS_FERQUI").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_FERQUI", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage6"
                Cjto_Tablas1.Tables("ANALISIS_FERORG").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_FERORG", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage7"
                Cjto_Tablas1.Tables("ANALISIS_OTROS").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_OTROS", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
            Case "TabPage8"
                Cjto_Tablas1.Tables("ANALISIS_VENTA").Clear()
                Dim Test1 As DbManager = New DbManager("ANALISIS_VENTA", Conexion1)
                If RdbCfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND ANA_NIVEL_PRECIO='CFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbCfrCoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfr.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND ANA_NIVEL_PRECIO='IFR' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbIfrIoc.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
                If RdbTodosMod.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Tablas1, query1)
                End If
        End Select
    End Sub

    Private Sub TabMuestrasMod_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TABMuestrasMod.Click
        RdbCfr.Checked = True
        Filtro_Muestra_Mod()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mycell As New DataGridCell
        Call Proceso_Nueva_OT_Codificacion()
        Me.GRBNLabCod.Visible = False
        mycell.ColumnNumber = 6
        mycell.RowNumber = 0
        DGCodificacion.CurrentCell = mycell

        mycell.ColumnNumber = 6
        mycell.RowNumber = 1
        DGCodificacion.CurrentCell = mycell
        BTGraba.Visible = True
        If ChkCancelado.Checked = True Then
            ChkCancelado.Checked = False
            ChkCancelado.Checked = True
        End If
    End Sub

    Private Sub Proceso_Nueva_OT_Codificacion()
        Dim Fila_Otpaso, Fila_Nlab, Fila_Analisis As DataRow
        Dim CodAna_Aux1, CodAna_Aux2, CodAna_Aux3 As Double
        Dim NDesde1, NDesde2, NDesde3, NumMue, PNeto As Integer
        Dim BuscaAna, BuscaNlab(1) As Object
        Dim Muestra_Aux1, Muestra_Aux2, Muestra_Aux3 As String
        Dim NumGrup As Integer = 0
        Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Clear()

        For Each Fila_Nlab In Cjto_Tablas1.Tables("TABLA_NLABCOD").Rows
            Fila_Otpaso = Cjto_Orden1.Tables("OT_CODIFICACION_PASO").NewRow

            If IsDBNull(Fila_Nlab("ANA_CODIGO1")) = False Then
                Fila_Otpaso.Item("ANA_CODIGO") = Fila_Nlab.Item("ANA_CODIGO1")
                Fila_Otpaso.Item("ANA_ANALISIS") = Fila_Nlab.Item("ANA_DESCRIPCION1")

                If CodAna_Aux1 <> Fila_Nlab("ANA_CODIGO1") Then
                    If NDesde1 <> Fila_Nlab.Item("OT_NLAB") Then NumGrup = Encuentra_Ultimo() + 1
                    NDesde1 = Fila_Nlab.Item("OT_NLAB")
                End If

                Fila_Otpaso.Item("OTC_NLAB_DESDE") = NDesde1
                Fila_Otpaso.Item("OTC_NLAB_HASTA") = Fila_Nlab.Item("OT_NLAB")
                NumMue = (CInt(Fila_Otpaso.Item("OTC_NLAB_HASTA")) - NDesde1 + 1)
                Fila_Otpaso.Item("OTC_CANT_MUESTRAS") = NumMue
                Fila_Otpaso.Item("OTC_PRECIOUN") = Fila_Nlab.Item("ANA_NETO1")
                Fila_Otpaso.Item("OTC_PRECIONET") = Fila_Nlab.Item("ANA_NETO1") * NumMue
                Fila_Otpaso.Item("OTC_GRUPO") = NumGrup
                Try

                    Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows.Add(Fila_Otpaso)
                    BuscaAna = Fila_Nlab.Item("ANA_CODIGO1")
                    Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
                    If Fila_Analisis("TIPO_COD") = "JA" Then Call Graba_Jocker_Con_NumLab(Fila_Nlab.Item("ANA_CODIGO1"), NDesde1, NDesde1)
                Catch ex As Exception
                    BuscaNlab(0) = Fila_Nlab("ANA_CODIGO1")
                    BuscaNlab(1) = NDesde1
                    Fila_Otpaso = Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows.Find(BuscaNlab)
                    NumMue = Fila_Otpaso("OTC_CANT_MUESTRAS")
                    Fila_Otpaso.Item("OTC_CANT_MUESTRAS") = NumMue + 1
                    Fila_Otpaso.Item("OTC_NLAB_HASTA") = Fila_Nlab.Item("OT_NLAB")
                    Fila_Otpaso.Item("OTC_PRECIONET") = Fila_Nlab.Item("ANA_NETO1") * CInt(Fila_Otpaso.Item("OTC_CANT_MUESTRAS"))
                End Try
            End If
            Muestra_Aux1 = Fila_Nlab("TMU_MUESTRA")
            CodAna_Aux1 = Fila_Nlab("ANA_CODIGO1")
        Next
    End Sub

    Private Function Encuentra_Ultimo() As Integer
        Dim Fila_OTC As DataRow
        Dim Ultimo_Grupo As Integer
        Ultimo_Grupo = 0
        For Each Fila_OTC In Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows
            If Ultimo_Grupo = 0 Then Ultimo_Grupo = Fila_OTC("OTC_GRUPO")
            If Ultimo_Grupo < Fila_OTC("OTC_GRUPO") Then Ultimo_Grupo = Fila_OTC("OTC_GRUPO")
        Next
        Return Ultimo_Grupo
    End Function

    Private Sub Graba_Jocker_Con_NumLab(ByVal CODPAS As Double, ByVal NLABD As Integer, ByVal NLABH As Integer)
        Dim Fila_Jockers, Fila_GJok As DataRow
        Dim XX As Integer
        For Each Fila_Jockers In Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO").Rows
            For XX = NLABD To NLABH
                Fila_GJok = Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO3").NewRow
                Fila_GJok.Item("TMU_CODIGO") = CInt(Mid(Str(CODPAS), 1, 1) & "000")
                Fila_GJok.Item("OT_NLAB") = XX
                Fila_GJok.Item("ELE_CODIGO") = Fila_Jockers("ELE_CODIGO")
                Try
                    Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO3").Rows.Add(Fila_GJok)
                Catch ex As Exception
                    'MsgBox("El trapaso Jockers1 a Jocker2 fallo")
                End Try
            Next
        Next
    End Sub

    Private Sub DGCodificacion_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGCodificacion.CurrentCellChanged
        Dim ObjSum As Object
        Dim SubTotal As Integer
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim Fila_Grilla_C As Integer
        Dim muestra As Boolean = False
        myGriC = CType(sender, DataGrid)
        ffiCam = myGriC.CurrentCell.RowNumber
        If TxtCPrecio.Visible = True Then TxtCPrecio.Visible = False
        If myGriC.CurrentCell.ColumnNumber = 5 Then 'Or myGriC.CurrentCell.ColumnNumber = 2 Or myGriC.CurrentCell.ColumnNumber = 3 Or myGriC.CurrentCell.ColumnNumber = 4 Then
            ColumnaCam = myGriC.CurrentCell.ColumnNumber
            Dim CeldaAlto As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).X + myGriC.Left
            Dim Posiciony As Integer = myGriC.GetCellBounds(myGriC.CurrentCell.RowNumber, myGriC.CurrentCell.ColumnNumber).Y + myGriC.Top
            TxtCPrecio.Left = Posicionx
            TxtCPrecio.Top = Posiciony
            TxtCPrecio.Height = CeldaAlto
            TxtCPrecio.Width = CeldaAncho
            TxtCPrecio.Visible = True
            TxtCPrecio.Text = ""
            TxtCPrecio.Enabled = True
            TxtCPrecio.Focus()
            TxtCPrecio.SelectionStart = 1
            If IsDBNull(myGriC.Item(ffiCam, ColumnaCam)) = False Then TxtCPrecio.Text = myGriC.Item(ffiCam, ColumnaCam)
        End If
        Call Calcula_Valores()
    End Sub

    Private Sub BTGraba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGraba.Click
        Dim Consulta, VeEle As String
        Dim Busca(2), BuscaJocker As Object
        Dim ChequeoMod, CantMuestras, XX As Integer
        Dim Fila_Ot, Fila_Dig, FILA_ANALISIS As DataRow
        Dim con As New SqlConnection(Conexion1)
        Dim con2 As New SqlConnection(Conexion1)

        If EstaFacturada() = True And Total_Factura <> CInt(Me.TxtTotal.Text) Then
            MsgBox("Esta Orden esta facturada y existe un cambio de valor total , para realizar este cambio, antes deberá anular la Factura")
            GoTo nograba
        End If


        If RdbAbonoCheque.Checked = True Then ChequeoMod = 1 Else ChequeoMod = 2
        Call Calcula_Valores()
        con.Open()
        con2.Open()

        If TxtDesctPesos.Text = "" Then TxtDesctPesos.Text = 0
        If TxtDescto.Text = "" Then TxtDescto.Text = 0
        If TxtMuestreoCant.Text = "" Then TxtMuestreoCant.Text = 0
        If TxtMuestreoPrecioUn.Text = "" Then TxtMuestreoPrecioUn.Text = 0
        If TxtMuestreo.Text = "" Then TxtMuestreo.Text = 0
        If TxtAbono.Text = "" Then TxtAbono.Text = 0

        Consulta = "UPDATE ORDEN_TRABAJO SET OT_SUBTOTAL=" & CInt(TxtSubTotal.Text) & "," & _
                                    "OT_NETO=" & CInt(TxtNeto.Text) & "," & "OT_IVA=" & CInt(TxtIva.Text) & "," & _
                                    "OT_DESCUENTOPOR=" & CDbl(Me.TxtDescto.Text) & "," & "OT_DESCUENTOPESOS=" & CInt(Me.TxtDesctPesos.Text) & "," & _
                                    "OT_MUESTREO_CANT=" & CInt(Me.TxtMuestreoCant.Text) & "," & "OT_MUESTREO_PRECIOUN=" & CInt(Me.TxtMuestreoPrecioUn.Text) & "," & _
                                    "OT_MUESTREO=" & CInt(Me.TxtMuestreo.Text) & "," & "OT_ABONO=" & CInt(TxtAbono.Text) & "," & _
                                    "OT_ABONOCON=" & ChequeoMod & "," & "OT_TOTAL=" & CInt(Me.TxtTotal.Text) & " " & _
                                    "WHERE OT_NUMERO=" & Orden_Trabajo
        Dim mycom As New SqlCommand(Consulta, con)
        mycom.ExecuteNonQuery()


        Consulta = "DELETE OT_CODIFICACION WHERE OT_NUMERO=" & Orden_Trabajo
        Dim mycom1 As New SqlCommand(Consulta, con)
        mycom1.ExecuteNonQuery()

        For Each Fila_Ot In Cjto_Orden1.Tables("OT_CODIFICACION_PASO").Rows
            CantMuestras = CInt(Fila_Ot("OTC_NLAB_HASTA") - Fila_Ot("OTC_NLAB_DESDE") + 1)
            Consulta = "INSERT INTO OT_CODIFICACION (OT_NUMERO,TMU_CODIGO,OTC_NLAB_DESDE,ANA_CODIGO,ANA_ANALISIS,OTC_CANT_MUESTRAS,OTC_NLAB_HASTA,OTC_PRECIOUN,OTC_PRECIONET)" & _
                                                                      " VALUES (" & Orden_Trabajo & "," & CInt(Mid(Fila_Ot("ANA_CODIGO"), 1, 1) & "000") & "," & _
                                                                      Fila_Ot("OTC_NLAB_DESDE") & "," & Fila_Ot("ANA_CODIGO") & ",'" & Fila_Ot("ANA_ANALISIS") & "'," & CantMuestras & "," & _
                                                                      Fila_Ot("OTC_NLAB_HASTA") & "," & Fila_Ot("OTC_PRECIOUN") & "," & Fila_Ot("OTC_PRECIONET") & ")"
            Dim mycom2 As New SqlCommand(Consulta, con)
            mycom2.ExecuteNonQuery()


            BuscaJocker = Fila_Ot("ANA_CODIGO")
            FILA_ANALISIS = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaJocker)
            If FILA_ANALISIS("TIPO_COD") = "JA" Then
                Call Graba_Digita_Resultados_Con_Jocker(Fila_Ot("ANA_CODIGO"), Fila_Ot("OTC_NLAB_DESDE"), Fila_Ot("OTC_NLAB_HASTA"))
            Else
                Consulta = "Select ELE_CODIGO FROM ANALISIS_ELEMENTOS WHERE TMU_CODIGO=" & CInt(Mid(Fila_Ot("ANA_CODIGO"), 1, 1) & "000") & " AND " & _
                           "ANA_CODIGO=" & Fila_Ot("ANA_CODIGO")
                Dim myCommand As New SqlCommand(Consulta, con)
                Dim myReader As SqlDataReader = myCommand.ExecuteReader()
                While myReader.Read
                    For XX = Fila_Ot("OTC_NLAB_DESDE") To Fila_Ot("OTC_NLAB_HASTA")
                        Busca(0) = CInt(Mid(Fila_Ot("ANA_CODIGO"), 1, 1) & "000")
                        Busca(1) = XX
                        Busca(2) = myReader.GetString(0)
                        Fila_Dig = Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows.Find(Busca)
                        If (Fila_Dig Is Nothing) = True Then
                            Consulta = "INSERT INTO DIGITA_RESULTADOS (OT_NUMERO,TMU_CODIGO,OT_NLAB,ANA_CODIGO,ELE_CODIGO,ELE_ESTADO)" & _
                                                                      " VALUES (" & Orden_Trabajo & "," & CInt(Mid(Fila_Ot("ANA_CODIGO"), 1, 1) & "000") & "," & _
                                                                      XX & "," & Fila_Ot("ANA_CODIGO") & ",'" & myReader.GetString(0) & "','xA')"
                            Dim mycom3 As New SqlCommand(Consulta, con2)
                            mycom3.ExecuteNonQuery()
                        Else
                            Try
                                Consulta = "UPDATE DIGITA_RESULTADOS SET ANA_CODIGO=" & Fila_Ot("ANA_CODIGO") & " WHERE OT_NUMERO=" & Orden_Trabajo & " AND  TMU_CODIGO=" & CInt(Mid(Fila_Ot("ANA_CODIGO"), 1, 1) & "000") & _
                                                           " AND OT_NLAB=" & XX & " AND ELE_CODIGO='" & myReader.GetString(0) & "'"
                                Dim mycom7 As New SqlCommand(Consulta, con2)
                                mycom7.ExecuteNonQuery()
                                Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows.Remove(Fila_Dig)
                            Catch ex As Exception
                            End Try
                        End If
                    Next
                End While
                myReader.Close()
            End If
        Next
        con2.Close()
        con2.Open()

        For Each Fila_Dig In Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows
            Consulta = "Select ELE_CODIGO FROM DIGITA_RESULTADOS WHERE TMU_CODIGO=" & Fila_Dig("TMU_CODIGO") & " AND " & _
                                   "OT_NLAB=" & Fila_Dig("OT_NLAB") & " AND ELE_CODIGO='" & Fila_Dig("ELE_CODIGO") & "'"
            Dim myCommand1 As New SqlCommand(Consulta, con)
            Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
            Try
                myReader1.Read()
                VeEle = myReader1.GetString(0)

                '*************  con esto en la revision no se confundira con estados nula *******************
                Consulta = "DELETE DIGITA_RESULTADOS WHERE OT_NUMERO=" & Orden_Trabajo & " AND  TMU_CODIGO=" & Fila_Dig("TMU_CODIGO") & _
                                           " AND OT_NLAB=" & Fila_Dig("OT_NLAB") & " AND ELE_CODIGO='" & Fila_Dig("ELE_CODIGO") & "'"

                'Consulta = "UPDATE DIGITA_RESULTADOS SET ELE_ESTADO='Nula' WHERE OT_NUMERO=" & Orden_Trabajo & " AND  TMU_CODIGO=" & Fila_Dig("TMU_CODIGO") & _
                '           " AND OT_NLAB=" & Fila_Dig("OT_NLAB") & " AND ELE_CODIGO='" & Fila_Dig("ELE_CODIGO") & "'"
                Dim mycom5 As New SqlCommand(Consulta, con2)
                mycom5.ExecuteNonQuery()
                myReader1.Close()
            Catch ex As Exception
            End Try
        Next
        con.Close()
        con2.Close()
        'Call Refresca_Tablas()
        MsgBox("Grabación Finalizada")
Nograba:
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

    Private Sub Graba_Digita_Resultados_Con_Jocker(ByVal CodDig As Double, ByVal LabD As Integer, ByVal LabH As Integer)
        Dim Fila_Jockers, Fila_Mod_Ele, Fila_Dig As DataRow
        Dim consulta As String
        Dim muestraj As Integer
        Dim Busca(2) As Object
        Dim con As New SqlConnection(Conexion1)
        con.Open()
        For Each Fila_Jockers In Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO3").Rows
            If Fila_Jockers("OT_NLAB") >= LabD And Fila_Jockers("OT_NLAB") <= LabH Then
                Busca(0) = CInt(Mid(CStr(CodDig), 1, 1) & "000")
                Busca(1) = Fila_Jockers("OT_NLAB")
                Busca(2) = Fila_Jockers("ELE_CODIGO")
                Fila_Dig = Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows.Find(Busca)
                If (Fila_Dig Is Nothing) = True Then
                    consulta = "INSERT INTO DIGITA_RESULTADOS (OT_NUMERO,TMU_CODIGO,OT_NLAB,ANA_CODIGO,ELE_CODIGO,ELE_ESTADO)" & _
                                                              " VALUES (" & Orden_Trabajo & "," & CInt(Mid(CodDig, 1, 1) & "000") & "," & _
                                                              Fila_Jockers("OT_NLAB") & "," & CodDig & ",'" & Fila_Jockers("ELE_CODIGO") & "','xA')"
                    Dim mycom3 As New SqlCommand(consulta, con)
                    mycom3.ExecuteNonQuery()
                    'Try
                    'mycom3.ExecuteNonQuery()
                    'Catch ex As Exception
                    'consulta = "UPDATE DIGITA_RESULTADOS SET ANA_CODIGO=" & CodDig & " WHERE OT_NUMERO=" & Orden_Trabajo & " AND  TMU_CODIGO=" & CInt(Mid(CodDig, 1, 1) & "000") & _
                    '                               " AND OT_NLAB=" & Fila_Jockers("OT_NLAB") & " AND ELE_CODIGO='" & Fila_Jockers("ELE_CODIGO") & "'"
                    'Dim mycom7 As New SqlCommand(consulta, con)
                    'mycom7.ExecuteNonQuery()
                    'Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows.Remove(Fila_Dig)
                    'End Try
                Else
                    Try
                        consulta = "UPDATE DIGITA_RESULTADOS SET ANA_CODIGO=" & CodDig & " WHERE OT_NUMERO=" & Orden_Trabajo & " AND  TMU_CODIGO=" & CInt(Mid(CodDig, 1, 1) & "000") & _
                                   " AND OT_NLAB=" & Fila_Jockers("OT_NLAB") & " AND ELE_CODIGO='" & Fila_Jockers("ELE_CODIGO") & "'"
                        Dim mycom7 As New SqlCommand(consulta, con)
                        mycom7.ExecuteNonQuery()
                        Cjto_Tablas1.Tables("DIGITA_RESULTADOS_PASO").Rows.Remove(Fila_Dig)
                    Catch ex As Exception
                    End Try
                End If
            End If
        Next






        con.Close()
CodigoRepetido:
    End Sub

    Private Sub TxtAbono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAbono.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TxtAbono.Text = Format(CInt(TxtAbono.Text), "###,##0")
            Call Calcula_Valores()
        End If
    End Sub

    Private Sub TxtMuestreoCant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreoCant.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMuestreoPrecioUn.Focus()
        End If
    End Sub
    Private Sub TxtMuestreo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreo.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Calcula_Valores()
        End If
    End Sub

    Private Sub TxtDescto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDescto.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDesctPesos.Text = ""
            Call Calcula_Valores()
        End If
    End Sub

    Private Sub TxtDesctPesos_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDesctPesos.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtDesctPesos.Text = Format(CInt(TxtDesctPesos.Text), "###,##0")
            TxtDescto.Text = ""
            Call Calcula_Valores()
        End If
    End Sub

    Private Sub TxtMuestreoPrecioUn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMuestreoPrecioUn.KeyPress
        Dim totalmuestreo As Integer
        If e.KeyChar = Chr(13) Then
            If Me.TxtMuestreoCant.Text = 0 Then MsgBox("Falta cantidad de Muestreos") : GoTo falta
            totalmuestreo = CInt(TxtMuestreoCant.Text) * CInt(TxtMuestreoPrecioUn.Text)
            Me.TxtMuestreo.Text = Format(totalmuestreo, "####,##0")
            Me.TxtMuestreoPrecioUn.Text = Format(CInt(TxtMuestreoPrecioUn.Text), "###,##0")
            Call Calcula_Valores()
        End If
falta:
    End Sub
    Private Sub DGTablaNlab_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGTablaNlab.Click
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Fila_Cod = myGrid.CurrentCell.RowNumber
        Columna_Cod = 4
    End Sub

    Private Sub ChkCancelado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCancelado.CheckedChanged
        If ChkCancelado.Checked = True Then
            TxtAbono.Text = Format(CInt(TxtTotal.Text), "####,###")
            Call Calcula_Valores()
        End If

        If ChkCancelado.Checked = False Then
            TxtAbono.Text = 0
            Call Calcula_Valores()
        End If
    End Sub

    Private Sub BTJockerMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTJockerMod.Click
        Dim FILA_DATAROW, dr, FILA_B As DataRow
        Dim FILA_NOTAS_C, FILA_CC As DataRow
        Dim consulta_nota, ff As String
        Cjto_Orden1.Tables("ANALISIS_ELEMENTOS_PASO").Clear()
        Select Case TABMuestrasMod.SelectedTab.Name
            Case "TabPage1"
                Call Abrir_JockerMod(1000)
            Case "TabPage2"
                Call Abrir_JockerMod(2000)
            Case "TabPage3"
                Call Abrir_JockerMod(3000)
            Case "TabPage4"
                Call Abrir_JockerMod(4000)
            Case "TabPage5"
                Call Abrir_JockerMod(5000)
            Case "TabPage6"
                Call Abrir_JockerMod(6000)
            Case "TabPage7"
                Call Abrir_JockerMod(7000)
            Case "TabPage8"
                Call Abrir_JockerMod(8000)
        End Select
    End Sub

    Private Sub Abrir_JockerMod(ByVal CodMuestra As Integer)
        Dim FILA_B As DataRow
        For Each FILA_B In Cjto_Tablas1.Tables("ANALISIS").Rows
            If FILA_B("TIPO_COD") = "JA" And FILA_B("TMU_CODIGO") = CodMuestra Then
                GrbJockerMod.Visible = True
                GrbJockerMod.BringToFront()

                If GRBNLabCod.Visible = True Then
                    If Me.DGTablaNlab.Item(Fila_Ant, 4) <> FILA_B("ANA_CODIGO") Then
                        TxtCodigoMod.Text = FILA_B("ANA_CODIGO")
                        TxtDescripcionMod.Text = ""
                        TxtPrecioMod.Text = FILA_B("ANA_NETO")
                        Exit For
                    End If
                Else
                    TxtCodigoMod.Text = FILA_B("ANA_CODIGO")
                    TxtDescripcionMod.Text = ""
                    'TxtPrecioMod.Text = FILA_B("ANA_NETO")
                    Exit For
                End If

            End If
        Next
    End Sub

    Private Sub BTCerrarJocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCerrarJocker.Click
        GrbJockerMod.Visible = False
    End Sub

    Private Sub CmdAceptarJockerMod_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAceptarJockerMod.Click
        Dim ObjSum, BuscaAna As Object
        Dim SubTotal, Neto As Integer
        Dim Fila_Analisis As DataRow
        Dim mycell As DataGridCell
        If CInt(TxtPrecioMod.Text) = 0 Then MsgBox("Falta Precio Jocker Análisis") : GoTo nosale

        If Me.GRBNLabCod.Visible = True Then
            Me.DGTablaNlab.Item(Fila_Cod, Columna_Cod) = CInt(TxtCodigoMod.Text)
            Me.DGTablaNlab.Item(Fila_Cod, 5) = TxtDescripcionMod.Text
            Me.DGTablaNlab.Item(Fila_Cod, 6) = CInt(TxtPrecioMod.Text)
            GrbJockerMod.Visible = False
            GoTo nosale
        End If

        codigo_antiguo = Me.DGCodificacion.Item(Fila_Ant, 0)
        Me.DGCodificacion.Item(Fila_Ant, 0) = CDbl(TxtCodigoMod.Text)
        Me.DGCodificacion.Item(Fila_Ant, 1) = TxtDescripcionMod.Text
        Me.DGCodificacion.Item(Fila_Ant, 5) = CInt(TxtPrecioMod.Text)
        Me.DGCodificacion.Item(Fila_Ant, 6) = Me.DGCodificacion.Item(Fila_Ant, 5) * Me.DGCodificacion.Item(Fila_Ant, 4)

        Call Calcula_Valores()

        BuscaAna = CDbl(TxtCodigoMod.Text)
        Fila_Analisis = Cjto_Tablas1.Tables("ANALISIS").Rows.Find(BuscaAna)
        If Fila_Analisis("TIPO_COD") = "JA" Then Call Graba_Jocker_Con_NumLab(TxtCodigoMod.Text, Me.DGCodificacion.Item(Fila_Ant, 2), Me.DGCodificacion.Item(Fila_Ant, 3))

        If Fila_Ant = 0 Then
            mycell.ColumnNumber = 0
            mycell.RowNumber = Fila_Ant + 1
            DGCodificacion.CurrentCell = mycell
        Else
            mycell.ColumnNumber = 0
            mycell.RowNumber = Fila_Ant - 1
            DGCodificacion.CurrentCell = mycell
        End If
        'Call Cambia_Codigos_nlabcod(DGCodificacion.Item(Fila_Cod, 0), DGCodificacion.Item(Fila_Cod, 2), DGCodificacion.Item(Fila_Cod, 3), Me.DGCodificacion.Item(Fila_Cod, 1))
        GrbJockerMod.Visible = False
        If ChkCancelado.Checked = True Then
            ChkCancelado.Checked = False
            ChkCancelado.Checked = True
        End If
nosale:
    End Sub

    Private Sub DGCodificacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DGCodificacion.Click
        'Dim Fila_Ant As Integer
        Dim Fila_Cod As DataRow
        Dim ObjSum As Object
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        Fila_Ant = MYGRID.CurrentCell.RowNumber()
        Ant_NLabDesde = CInt(MYGRID.Item(Fila_Ant, 2))
        Ant_NLabHasta = CInt(MYGRID.Item(Fila_Ant, 3))
        Muestra = CInt(Mid(CStr(MYGRID.Item(Fila_Ant, 0)), 1, 1) & "000")
    End Sub

End Class
