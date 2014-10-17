Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports System.IO


Public Class class_COTIZADOR
    Inherits System.Windows.Forms.Form
    Dim excelApplication As Excel.ApplicationClass = New Excel.ApplicationClass()
    Dim excelWorkbook As Excel.Workbook = Nothing
    Public ncoti As Double
    Public Nivel, CuentaIntentos, Lj, Lpag, Lcont, Lll, LES_SIMPLE, carta, carta2, ConFrec, Suma_Para_Neto, Suma_Valor_Jocker As Integer
    Public Lpix, Lsuma_pixeles As Double
    Public Lfechaf, cotiza_listado, Listado_codigos, Carta_Lista, Es_SubMuestra, Es_Combo_Cot, ElPrimero, concu, Des_Jocker_Fila As String
    Friend WithEvents CBComuna As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents CBCierra As System.Windows.Forms.Button
    Friend WithEvents CBElimina As System.Windows.Forms.Button
    Friend WithEvents CmdEnviar As System.Windows.Forms.Button
    Friend WithEvents CmdVerExcel As System.Windows.Forms.Button
    Friend WithEvents CmdCreaNueva As System.Windows.Forms.Button
    Friend WithEvents CmdModificaAnt As System.Windows.Forms.Button
    Friend WithEvents CBCiudad As System.Windows.Forms.ComboBox

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
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adap_Cotiza_Analisis As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cjto_Cotizacion1 As Cjto_Cotizacion
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn137 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand9 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Productor As System.Data.SqlClient.SqlDataAdapter
    Public FILA_DATA, FILA_DATA3, FILA_DATA4, FILA_DATAGRID2, le As Integer
    Public MODIFICAR, MOD_MUE, MOD_SUB, ultima_tab As String
    Public MUESTRA1, MUESTRA2, MUESTRA3, MUESTRA4 As String
    Public COL56, DEL_GRA, ES_COMBO, ES_SIMPLE, DESDE_CONSULTA As Integer
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Adap_Analisis As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Notas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Combo_pro As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents TextBox16 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand10 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Con_Cot As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand11 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Con_Det As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand12 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlSelectCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand13 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Con_Analisis As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand14 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Con_Notas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataGrid6 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents SqlSelectCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand15 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Combo_Ana As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents SqlSelectCommand4 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Detalle As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox15 As System.Windows.Forms.TextBox
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox19 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox20 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand16 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataGrid8 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle8 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox21 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand17 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Empresa As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlSelectCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand18 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Cot_Emp As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand19 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Cot_At As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand20 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Empresa_Con As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand21 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Atencion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents COTEMP As System.Windows.Forms.Button
    Friend WithEvents TextBox14 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Cotizacion As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand8 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand5 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Cotiza_Notas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlConnection2 As System.Data.SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox22 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox23 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents SqlSelectCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Man_Com As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Man_Ann As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlInsertCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand26 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents SqlSelectCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand27 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Submuestra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand22 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Muestra As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TabPage11 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage12 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid16 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid17 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle16 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn87 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn88 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn89 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn90 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn91 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn92 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn93 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle17 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn94 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn95 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn96 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn97 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn98 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn99 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn100 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox29 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox30 As System.Windows.Forms.TextBox
    Friend WithEvents SqlInsertCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand28 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TabPage13 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid18 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle18 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn101 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn102 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn103 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn104 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn105 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn106 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn107 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TextBox31 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand25 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand24 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand23 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Man_Ana As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Button21 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button34 As System.Windows.Forms.Button
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents TextBox35 As System.Windows.Forms.TextBox
    Friend WithEvents Button35 As System.Windows.Forms.Button
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents TextBox36 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox37 As System.Windows.Forms.TextBox
    Friend WithEvents Button40 As System.Windows.Forms.Button
    Friend WithEvents SqlSelectCommand6 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Comunas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand7 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand30 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Comunas1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents TextBox38 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox39 As System.Windows.Forms.TextBox
    Friend WithEvents SqlSelectCommand29 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand32 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand31 As System.Data.SqlClient.SqlCommand
    Friend WithEvents Adap_Comunas2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox40 As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Button44 As System.Windows.Forms.Button
    Friend WithEvents Button45 As System.Windows.Forms.Button
    Friend WithEvents Button46 As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents Button47 As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid27 As System.Windows.Forms.DataGrid
    Friend WithEvents TextBox41 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle28 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn122 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn123 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn124 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn125 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn126 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn127 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn128 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn129 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn130 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn131 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn132 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn133 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn134 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn135 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn136 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents SqlConnection3 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents BTAlto As System.Windows.Forms.Button
    Friend WithEvents BTBajo As System.Windows.Forms.Button
    Friend WithEvents BTMedio As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents RTxtAlto As System.Windows.Forms.RichTextBox
    Friend WithEvents RTxtMedio As System.Windows.Forms.RichTextBox
    Friend WithEvents RTxtBajo As System.Windows.Forms.RichTextBox
    Friend WithEvents GrbListado As System.Windows.Forms.GroupBox
    Friend WithEvents BTGrabaListado As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label105 As System.Windows.Forms.Label
    Friend WithEvents GroupBox28 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Button48 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button49 As System.Windows.Forms.Button
    Friend WithEvents GroupBox30 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Label106 As System.Windows.Forms.Label
    Friend WithEvents Label108 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button51 As System.Windows.Forms.Button
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Button53 As System.Windows.Forms.Button
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Button54 As System.Windows.Forms.Button
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label96 As System.Windows.Forms.Label
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Friend WithEvents Label98 As System.Windows.Forms.Label
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents Label100 As System.Windows.Forms.Label
    Friend WithEvents Label101 As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Label131 As System.Windows.Forms.Label
    Friend WithEvents Label132 As System.Windows.Forms.Label
    Friend WithEvents Label82 As System.Windows.Forms.Label
    Friend WithEvents Label83 As System.Windows.Forms.Label
    Friend WithEvents Label84 As System.Windows.Forms.Label
    Friend WithEvents Label85 As System.Windows.Forms.Label
    Friend WithEvents Label86 As System.Windows.Forms.Label
    Friend WithEvents Label87 As System.Windows.Forms.Label
    Friend WithEvents Label89 As System.Windows.Forms.Label
    Friend WithEvents Label90 As System.Windows.Forms.Label
    Friend WithEvents Label91 As System.Windows.Forms.Label
    Friend WithEvents Label92 As System.Windows.Forms.Label
    Friend WithEvents Label93 As System.Windows.Forms.Label
    Friend WithEvents Label94 As System.Windows.Forms.Label
    Friend WithEvents Label95 As System.Windows.Forms.Label
    Friend WithEvents Label102 As System.Windows.Forms.Label
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents Label113 As System.Windows.Forms.Label
    Friend WithEvents Label114 As System.Windows.Forms.Label
    Friend WithEvents Label115 As System.Windows.Forms.Label
    Friend WithEvents Label117 As System.Windows.Forms.Label
    Friend WithEvents Label88 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents GroupBox31 As System.Windows.Forms.GroupBox
    Friend WithEvents Label133 As System.Windows.Forms.Label
    Friend WithEvents Label134 As System.Windows.Forms.Label
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Label135 As System.Windows.Forms.Label
    Friend WithEvents Label136 As System.Windows.Forms.Label
    Friend WithEvents TabPage15 As System.Windows.Forms.TabPage
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage16 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage21 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage18 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage19 As System.Windows.Forms.TabPage
    Friend WithEvents DataGridTextBoxColumn74 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn75 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn76 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn77 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn78 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn79 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn80 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn116 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn81 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGrid13 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle13 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn138 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn139 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn140 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn141 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn142 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn143 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn144 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn145 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn146 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox27 As System.Windows.Forms.GroupBox
    Friend WithEvents Label109 As System.Windows.Forms.Label
    Friend WithEvents Label104 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label103 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox42 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox41 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox40 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox39 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox38 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox37 As System.Windows.Forms.CheckBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox48 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox47 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox46 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox45 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox44 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox43 As System.Windows.Forms.CheckBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Friend WithEvents CBNotasPla As System.Windows.Forms.Button
    Friend WithEvents CBCartaL As System.Windows.Forms.Button
    Friend WithEvents CBCotLis As System.Windows.Forms.Button
    Friend WithEvents CBExcel As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents TextBox45 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents TextBox43 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox44 As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Button52 As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Button23 As System.Windows.Forms.Button
    Friend WithEvents Button30 As System.Windows.Forms.Button
    Friend WithEvents Button31 As System.Windows.Forms.Button
    Friend WithEvents Button32 As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button20 As System.Windows.Forms.Button
    Friend WithEvents Button27 As System.Windows.Forms.Button
    Friend WithEvents Button28 As System.Windows.Forms.Button
    Friend WithEvents Button29 As System.Windows.Forms.Button
    Friend WithEvents DataGrid15 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid14 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle14 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn82 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn83 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle15 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn84 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn85 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn86 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn59 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn62 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn63 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn115 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn60 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn61 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents CheckBox49 As System.Windows.Forms.CheckBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents GroupBox26 As System.Windows.Forms.GroupBox
    Friend WithEvents Label111 As System.Windows.Forms.Label
    Friend WithEvents Label110 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Button22 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Button24 As System.Windows.Forms.Button
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Button33 As System.Windows.Forms.Button
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Button36 As System.Windows.Forms.Button
    Friend WithEvents CheckBox56 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox57 As System.Windows.Forms.CheckBox
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents Label107 As System.Windows.Forms.Label
    Friend WithEvents Label118 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    Friend WithEvents Label121 As System.Windows.Forms.Label
    Friend WithEvents Label137 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label138 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents Label145 As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label146 As System.Windows.Forms.Label
    Friend WithEvents TxtFirma1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtFirma6 As System.Windows.Forms.TextBox
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents TxtKFirma3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtKFirma2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtKFirma1 As System.Windows.Forms.TextBox
    Friend WithEvents Label147 As System.Windows.Forms.Label
    Friend WithEvents Label148 As System.Windows.Forms.Label
    Friend WithEvents Button25 As System.Windows.Forms.Button
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents GrbAcceso As System.Windows.Forms.GroupBox
    Friend WithEvents BTAceptaUsu As System.Windows.Forms.Button
    Friend WithEvents BTCancelaUsu As System.Windows.Forms.Button
    Friend WithEvents TxtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton7 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton6 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox55 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox36 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox35 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox34 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox33 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox32 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox31 As System.Windows.Forms.CheckBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox54 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox30 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox29 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox28 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox27 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox26 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox25 As System.Windows.Forms.CheckBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox53 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox24 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox23 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox22 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox21 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox20 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox19 As System.Windows.Forms.CheckBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox52 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox18 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox17 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox16 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox15 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox14 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox13 As System.Windows.Forms.CheckBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox51 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox12 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox11 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox10 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox9 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox8 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox7 As System.Windows.Forms.CheckBox
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBox50 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox6 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents Label81 As System.Windows.Forms.Label
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label75 As System.Windows.Forms.Label
    Friend WithEvents Label77 As System.Windows.Forms.Label
    Friend WithEvents Label74 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox25 As System.Windows.Forms.GroupBox
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(class_COTIZADOR))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Cjto_Cotizacion1 = New LabSys.Cjto_Cotizacion
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TextBox15 = New System.Windows.Forms.TextBox
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn129 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.TextBox21 = New System.Windows.Forms.TextBox
        Me.DataGrid8 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle8 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn130 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.TextBox20 = New System.Windows.Forms.TextBox
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn131 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.TextBox19 = New System.Windows.Forms.TextBox
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn132 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage11 = New System.Windows.Forms.TabPage
        Me.TextBox29 = New System.Windows.Forms.TextBox
        Me.DataGrid16 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle16 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn87 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn88 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn89 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn90 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn91 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn92 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn93 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn133 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.TextBox41 = New System.Windows.Forms.TextBox
        Me.DataGrid27 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle28 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn122 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn123 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn124 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn125 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn126 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn127 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn128 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn134 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage12 = New System.Windows.Forms.TabPage
        Me.TextBox30 = New System.Windows.Forms.TextBox
        Me.DataGrid17 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle17 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn94 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn95 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn96 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn97 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn98 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn99 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn100 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn135 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage13 = New System.Windows.Forms.TabPage
        Me.TextBox31 = New System.Windows.Forms.TextBox
        Me.DataGrid18 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle18 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn101 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn102 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn103 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn104 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn105 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn106 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn107 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn136 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.TxtFirma6 = New System.Windows.Forms.TextBox
        Me.TxtFirma5 = New System.Windows.Forms.TextBox
        Me.TxtFirma4 = New System.Windows.Forms.TextBox
        Me.TxtFirma3 = New System.Windows.Forms.TextBox
        Me.TxtFirma2 = New System.Windows.Forms.TextBox
        Me.TxtFirma1 = New System.Windows.Forms.TextBox
        Me.Label146 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button15 = New System.Windows.Forms.Button
        Me.RTxtBajo = New System.Windows.Forms.RichTextBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.BTBajo = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button14 = New System.Windows.Forms.Button
        Me.RTxtMedio = New System.Windows.Forms.RichTextBox
        Me.BTMedio = New System.Windows.Forms.Button
        Me.Label14 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Button12 = New System.Windows.Forms.Button
        Me.RTxtAlto = New System.Windows.Forms.RichTextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.BTAlto = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.TabPage15 = New System.Windows.Forms.TabPage
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.TxtKFirma3 = New System.Windows.Forms.TextBox
        Me.TxtKFirma2 = New System.Windows.Forms.TextBox
        Me.TxtKFirma1 = New System.Windows.Forms.TextBox
        Me.Label147 = New System.Windows.Forms.Label
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Button33 = New System.Windows.Forms.Button
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.Button36 = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Button22 = New System.Windows.Forms.Button
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Button24 = New System.Windows.Forms.Button
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.CBCierra = New System.Windows.Forms.Button
        Me.CBElimina = New System.Windows.Forms.Button
        Me.CmdEnviar = New System.Windows.Forms.Button
        Me.CmdVerExcel = New System.Windows.Forms.Button
        Me.CmdCreaNueva = New System.Windows.Forms.Button
        Me.CmdModificaAnt = New System.Windows.Forms.Button
        Me.GroupBox25 = New System.Windows.Forms.GroupBox
        Me.Button11 = New System.Windows.Forms.Button
        Me.GroupBox26 = New System.Windows.Forms.GroupBox
        Me.Label111 = New System.Windows.Forms.Label
        Me.Label110 = New System.Windows.Forms.Label
        Me.Label76 = New System.Windows.Forms.Label
        Me.Label78 = New System.Windows.Forms.Label
        Me.Button9 = New System.Windows.Forms.Button
        Me.Label34 = New System.Windows.Forms.Label
        Me.Button47 = New System.Windows.Forms.Button
        Me.DataGrid6 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.DataGridTextBoxColumn137 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand7 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Cotiza_Analisis = New System.Data.SqlClient.SqlDataAdapter
        Me.Label11 = New System.Windows.Forms.Label
        Me.SqlSelectCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand9 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand9 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Productor = New System.Data.SqlClient.SqlDataAdapter
        Me.Adap_Analisis = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand4 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Notas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand8 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Combo_pro = New System.Data.SqlClient.SqlDataAdapter
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.TextBox16 = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand10 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand10 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Con_Cot = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand11 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand11 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Con_Det = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand12 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand13 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand13 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Con_Analisis = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand14 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand14 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Con_Notas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand15 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand15 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Combo_Ana = New System.Data.SqlClient.SqlDataAdapter
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.SqlSelectCommand4 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Detalle = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand17 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand16 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.Label13 = New System.Windows.Forms.Label
        Me.SqlSelectCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand17 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand17 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand17 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Empresa = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand18 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand18 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Cot_Emp = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand19 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand19 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Cot_At = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand20 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand20 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Empresa_Con = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand22 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand21 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand21 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Atencion = New System.Data.SqlClient.SqlDataAdapter
        Me.TextBox14 = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Cotizacion = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand8 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand5 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand5 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Cotiza_Notas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand22 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlConnection2 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand6 = New System.Data.SqlClient.SqlCommand
        Me.Button21 = New System.Windows.Forms.Button
        Me.TextBox22 = New System.Windows.Forms.TextBox
        Me.TextBox23 = New System.Windows.Forms.TextBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.SqlSelectCommand26 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand25 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand24 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand24 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Man_Com = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand27 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand26 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand25 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand25 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Man_Ann = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand27 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand26 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand26 = New System.Data.SqlClient.SqlCommand
        Me.Label30 = New System.Windows.Forms.Label
        Me.SqlSelectCommand28 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand28 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand27 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand27 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Submuestra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand24 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand22 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand22 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Muestra = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlInsertCommand29 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand28 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand28 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.TextBox6 = New System.Windows.Forms.TextBox
        Me.Label139 = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label138 = New System.Windows.Forms.Label
        Me.Label69 = New System.Windows.Forms.Label
        Me.TextBox37 = New System.Windows.Forms.TextBox
        Me.TextBox36 = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Button35 = New System.Windows.Forms.Button
        Me.TextBox35 = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.Button34 = New System.Windows.Forms.Button
        Me.SqlSelectCommand25 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand24 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand23 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand23 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Man_Ana = New System.Data.SqlClient.SqlDataAdapter
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button40 = New System.Windows.Forms.Button
        Me.SqlSelectCommand6 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand30 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand29 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand29 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Comunas = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlSelectCommand7 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand31 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand30 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand30 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Comunas1 = New System.Data.SqlClient.SqlDataAdapter
        Me.TextBox38 = New System.Windows.Forms.TextBox
        Me.TextBox39 = New System.Windows.Forms.TextBox
        Me.SqlSelectCommand29 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand32 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand31 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand31 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Comunas2 = New System.Data.SqlClient.SqlDataAdapter
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Label105 = New System.Windows.Forms.Label
        Me.Button45 = New System.Windows.Forms.Button
        Me.Button44 = New System.Windows.Forms.Button
        Me.Label40 = New System.Windows.Forms.Label
        Me.TextBox40 = New System.Windows.Forms.TextBox
        Me.SqlConnection3 = New System.Data.SqlClient.SqlConnection
        Me.GrbListado = New System.Windows.Forms.GroupBox
        Me.Button16 = New System.Windows.Forms.Button
        Me.BTGrabaListado = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button17 = New System.Windows.Forms.Button
        Me.Button51 = New System.Windows.Forms.Button
        Me.Button53 = New System.Windows.Forms.Button
        Me.Button54 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button48 = New System.Windows.Forms.Button
        Me.Button49 = New System.Windows.Forms.Button
        Me.Button46 = New System.Windows.Forms.Button
        Me.GroupBox22 = New System.Windows.Forms.GroupBox
        Me.Label145 = New System.Windows.Forms.Label
        Me.Label144 = New System.Windows.Forms.Label
        Me.Label143 = New System.Windows.Forms.Label
        Me.Label140 = New System.Windows.Forms.Label
        Me.Label137 = New System.Windows.Forms.Label
        Me.Label118 = New System.Windows.Forms.Label
        Me.Label119 = New System.Windows.Forms.Label
        Me.Label120 = New System.Windows.Forms.Label
        Me.Label121 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label73 = New System.Windows.Forms.Label
        Me.Label107 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label28 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label66 = New System.Windows.Forms.Label
        Me.Label67 = New System.Windows.Forms.Label
        Me.Label68 = New System.Windows.Forms.Label
        Me.Label96 = New System.Windows.Forms.Label
        Me.Label97 = New System.Windows.Forms.Label
        Me.Label98 = New System.Windows.Forms.Label
        Me.Label99 = New System.Windows.Forms.Label
        Me.Label100 = New System.Windows.Forms.Label
        Me.Label101 = New System.Windows.Forms.Label
        Me.Label116 = New System.Windows.Forms.Label
        Me.Label122 = New System.Windows.Forms.Label
        Me.Label123 = New System.Windows.Forms.Label
        Me.Label124 = New System.Windows.Forms.Label
        Me.Label125 = New System.Windows.Forms.Label
        Me.Label126 = New System.Windows.Forms.Label
        Me.Label127 = New System.Windows.Forms.Label
        Me.Label128 = New System.Windows.Forms.Label
        Me.Label129 = New System.Windows.Forms.Label
        Me.Label130 = New System.Windows.Forms.Label
        Me.Label131 = New System.Windows.Forms.Label
        Me.Label132 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.Label117 = New System.Windows.Forms.Label
        Me.Label115 = New System.Windows.Forms.Label
        Me.Label114 = New System.Windows.Forms.Label
        Me.Label113 = New System.Windows.Forms.Label
        Me.Label112 = New System.Windows.Forms.Label
        Me.Label102 = New System.Windows.Forms.Label
        Me.Label95 = New System.Windows.Forms.Label
        Me.Label94 = New System.Windows.Forms.Label
        Me.Label93 = New System.Windows.Forms.Label
        Me.Label92 = New System.Windows.Forms.Label
        Me.Label91 = New System.Windows.Forms.Label
        Me.Label90 = New System.Windows.Forms.Label
        Me.Label89 = New System.Windows.Forms.Label
        Me.Label88 = New System.Windows.Forms.Label
        Me.Label44 = New System.Windows.Forms.Label
        Me.Button5 = New System.Windows.Forms.Button
        Me.GroupBox28 = New System.Windows.Forms.GroupBox
        Me.GroupBox30 = New System.Windows.Forms.GroupBox
        Me.Label148 = New System.Windows.Forms.Label
        Me.Label87 = New System.Windows.Forms.Label
        Me.Label84 = New System.Windows.Forms.Label
        Me.Label86 = New System.Windows.Forms.Label
        Me.Label85 = New System.Windows.Forms.Label
        Me.Label83 = New System.Windows.Forms.Label
        Me.Label82 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label42 = New System.Windows.Forms.Label
        Me.Button18 = New System.Windows.Forms.Button
        Me.Label106 = New System.Windows.Forms.Label
        Me.Label108 = New System.Windows.Forms.Label
        Me.GroupBox31 = New System.Windows.Forms.GroupBox
        Me.Label133 = New System.Windows.Forms.Label
        Me.Label134 = New System.Windows.Forms.Label
        Me.Button19 = New System.Windows.Forms.Button
        Me.Label135 = New System.Windows.Forms.Label
        Me.Label136 = New System.Windows.Forms.Label
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage21 = New System.Windows.Forms.TabPage
        Me.TabPage18 = New System.Windows.Forms.TabPage
        Me.DataGrid13 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle13 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn138 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn139 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn140 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn141 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn142 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn143 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn144 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn145 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn146 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage16 = New System.Windows.Forms.TabPage
        Me.GroupBox27 = New System.Windows.Forms.GroupBox
        Me.Label71 = New System.Windows.Forms.Label
        Me.Label109 = New System.Windows.Forms.Label
        Me.Label104 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label103 = New System.Windows.Forms.Label
        Me.Label60 = New System.Windows.Forms.Label
        Me.Label59 = New System.Windows.Forms.Label
        Me.Label58 = New System.Windows.Forms.Label
        Me.GroupBox21 = New System.Windows.Forms.GroupBox
        Me.CheckBox50 = New System.Windows.Forms.CheckBox
        Me.CheckBox6 = New System.Windows.Forms.CheckBox
        Me.CheckBox5 = New System.Windows.Forms.CheckBox
        Me.CheckBox4 = New System.Windows.Forms.CheckBox
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.GroupBox20 = New System.Windows.Forms.GroupBox
        Me.CheckBox51 = New System.Windows.Forms.CheckBox
        Me.CheckBox12 = New System.Windows.Forms.CheckBox
        Me.CheckBox11 = New System.Windows.Forms.CheckBox
        Me.CheckBox10 = New System.Windows.Forms.CheckBox
        Me.CheckBox9 = New System.Windows.Forms.CheckBox
        Me.CheckBox8 = New System.Windows.Forms.CheckBox
        Me.CheckBox7 = New System.Windows.Forms.CheckBox
        Me.Label55 = New System.Windows.Forms.Label
        Me.GroupBox19 = New System.Windows.Forms.GroupBox
        Me.CheckBox52 = New System.Windows.Forms.CheckBox
        Me.CheckBox18 = New System.Windows.Forms.CheckBox
        Me.CheckBox17 = New System.Windows.Forms.CheckBox
        Me.CheckBox16 = New System.Windows.Forms.CheckBox
        Me.CheckBox15 = New System.Windows.Forms.CheckBox
        Me.CheckBox14 = New System.Windows.Forms.CheckBox
        Me.CheckBox13 = New System.Windows.Forms.CheckBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.CheckBox53 = New System.Windows.Forms.CheckBox
        Me.CheckBox24 = New System.Windows.Forms.CheckBox
        Me.CheckBox23 = New System.Windows.Forms.CheckBox
        Me.CheckBox22 = New System.Windows.Forms.CheckBox
        Me.CheckBox21 = New System.Windows.Forms.CheckBox
        Me.CheckBox20 = New System.Windows.Forms.CheckBox
        Me.CheckBox19 = New System.Windows.Forms.CheckBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.CheckBox54 = New System.Windows.Forms.CheckBox
        Me.CheckBox30 = New System.Windows.Forms.CheckBox
        Me.CheckBox29 = New System.Windows.Forms.CheckBox
        Me.CheckBox28 = New System.Windows.Forms.CheckBox
        Me.CheckBox27 = New System.Windows.Forms.CheckBox
        Me.CheckBox26 = New System.Windows.Forms.CheckBox
        Me.CheckBox25 = New System.Windows.Forms.CheckBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.CheckBox55 = New System.Windows.Forms.CheckBox
        Me.CheckBox36 = New System.Windows.Forms.CheckBox
        Me.CheckBox35 = New System.Windows.Forms.CheckBox
        Me.CheckBox34 = New System.Windows.Forms.CheckBox
        Me.CheckBox33 = New System.Windows.Forms.CheckBox
        Me.CheckBox32 = New System.Windows.Forms.CheckBox
        Me.CheckBox31 = New System.Windows.Forms.CheckBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.CheckBox56 = New System.Windows.Forms.CheckBox
        Me.CheckBox42 = New System.Windows.Forms.CheckBox
        Me.CheckBox41 = New System.Windows.Forms.CheckBox
        Me.CheckBox40 = New System.Windows.Forms.CheckBox
        Me.CheckBox39 = New System.Windows.Forms.CheckBox
        Me.CheckBox38 = New System.Windows.Forms.CheckBox
        Me.CheckBox37 = New System.Windows.Forms.CheckBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.CheckBox57 = New System.Windows.Forms.CheckBox
        Me.CheckBox48 = New System.Windows.Forms.CheckBox
        Me.CheckBox47 = New System.Windows.Forms.CheckBox
        Me.CheckBox46 = New System.Windows.Forms.CheckBox
        Me.CheckBox45 = New System.Windows.Forms.CheckBox
        Me.CheckBox44 = New System.Windows.Forms.CheckBox
        Me.CheckBox43 = New System.Windows.Forms.CheckBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.GroupBox24 = New System.Windows.Forms.GroupBox
        Me.CBNotasPla = New System.Windows.Forms.Button
        Me.CBCartaL = New System.Windows.Forms.Button
        Me.CBCotLis = New System.Windows.Forms.Button
        Me.CBExcel = New System.Windows.Forms.Button
        Me.TabPage19 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.TextBox45 = New System.Windows.Forms.TextBox
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.Label46 = New System.Windows.Forms.Label
        Me.Label47 = New System.Windows.Forms.Label
        Me.TextBox43 = New System.Windows.Forms.TextBox
        Me.TextBox44 = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.Button52 = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Button23 = New System.Windows.Forms.Button
        Me.Button30 = New System.Windows.Forms.Button
        Me.Button31 = New System.Windows.Forms.Button
        Me.Button32 = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Button20 = New System.Windows.Forms.Button
        Me.Button27 = New System.Windows.Forms.Button
        Me.Button28 = New System.Windows.Forms.Button
        Me.Button29 = New System.Windows.Forms.Button
        Me.DataGrid15 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle15 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn84 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn85 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn86 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGrid14 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle14 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn82 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn83 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn74 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn75 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn76 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn77 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn78 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn79 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn80 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn116 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn81 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn59 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn62 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn63 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn115 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn60 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn61 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.CheckBox49 = New System.Windows.Forms.CheckBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label72 = New System.Windows.Forms.Label
        Me.TextBox12 = New System.Windows.Forms.TextBox
        Me.GrbAcceso = New System.Windows.Forms.GroupBox
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.Label150 = New System.Windows.Forms.Label
        Me.TxtUsuario = New System.Windows.Forms.TextBox
        Me.Label149 = New System.Windows.Forms.Label
        Me.BTCancelaUsu = New System.Windows.Forms.Button
        Me.BTAceptaUsu = New System.Windows.Forms.Button
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.RadioButton7 = New System.Windows.Forms.RadioButton
        Me.RadioButton6 = New System.Windows.Forms.RadioButton
        Me.RadioButton5 = New System.Windows.Forms.RadioButton
        Me.Label142 = New System.Windows.Forms.Label
        Me.RadioButton4 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Label151 = New System.Windows.Forms.Label
        Me.Label81 = New System.Windows.Forms.Label
        Me.Label80 = New System.Windows.Forms.Label
        Me.Label79 = New System.Windows.Forms.Label
        Me.Label75 = New System.Windows.Forms.Label
        Me.Label77 = New System.Windows.Forms.Label
        Me.Label74 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label64 = New System.Windows.Forms.Label
        Me.Label61 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label62 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.GroupBox23 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label141 = New System.Windows.Forms.Label
        Me.CBComuna = New System.Windows.Forms.ComboBox
        Me.CBCiudad = New System.Windows.Forms.ComboBox
        Me.Button13 = New System.Windows.Forms.Button
        Me.COTEMP = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button25 = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Cotizacion1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage11.SuspendLayout()
        CType(Me.DataGrid16, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.DataGrid27, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage12.SuspendLayout()
        CType(Me.DataGrid17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage13.SuspendLayout()
        CType(Me.DataGrid18, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage15.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox25.SuspendLayout()
        Me.GroupBox26.SuspendLayout()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GrbListado.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox28.SuspendLayout()
        Me.GroupBox30.SuspendLayout()
        Me.GroupBox31.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage18.SuspendLayout()
        CType(Me.DataGrid13, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage16.SuspendLayout()
        Me.GroupBox27.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.GroupBox18.SuspendLayout()
        Me.GroupBox17.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        Me.TabPage19.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbAcceso.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage11)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage12)
        Me.TabControl1.Controls.Add(Me.TabPage13)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage15)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(110, 132)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(940, 685)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(932, 658)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "   Cotiza   "
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = "COTIZA_DETALLE"
        Me.DataGrid1.DataSource = Me.Cjto_Cotizacion1
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(920, 662)
        Me.DataGrid1.TabIndex = 14
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Cjto_Cotizacion1
        '
        Me.Cjto_Cotizacion1.DataSetName = "Cjto_Cotizacion"
        Me.Cjto_Cotizacion1.Locale = New System.Globalization.CultureInfo("es-CL")
        Me.Cjto_Cotizacion1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "COTIZA_DETALLE"
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn31.MappingName = "CTD_MUESTRA"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.ReadOnly = True
        Me.DataGridTextBoxColumn31.Width = 64
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Código"
        Me.DataGridTextBoxColumn2.MappingName = "CTD_ANALISIS"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 64
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Detalle Análisis"
        Me.DataGridTextBoxColumn3.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 694
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = "##,###,###"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Unitario"
        Me.DataGridTextBoxColumn5.MappingName = "CTD_SUBTOTAL"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TextBox15)
        Me.TabPage2.Controls.Add(Me.DataGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(932, 658)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "    1. Foliar   "
        '
        'TextBox15
        '
        Me.TextBox15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox15.Location = New System.Drawing.Point(88, 152)
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.TextBox15.TabIndex = 3
        Me.TextBox15.Visible = False
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid2.TabIndex = 2
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn129})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "COTIZA_ANALISIS1"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "M"
        Me.DataGridTextBoxColumn1.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 15
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Código"
        Me.DataGridTextBoxColumn8.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 40
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn10.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 675
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = "###,###"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn11.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 51
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn12.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 40
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = "###,###"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "$ c/dcto."
        Me.DataGridTextBoxColumn13.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 46
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Niv"
        Me.DataGridTextBoxColumn9.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 30
        '
        'DataGridTextBoxColumn129
        '
        Me.DataGridTextBoxColumn129.Format = ""
        Me.DataGridTextBoxColumn129.FormatInfo = Nothing
        Me.DataGridTextBoxColumn129.HeaderText = "tpo"
        Me.DataGridTextBoxColumn129.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn129.NullText = ""
        Me.DataGridTextBoxColumn129.Width = 30
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TextBox21)
        Me.TabPage5.Controls.Add(Me.DataGrid8)
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(932, 658)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = " 2. +Tejidos"
        '
        'TextBox21
        '
        Me.TextBox21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox21.Location = New System.Drawing.Point(56, 160)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.TextBox21.TabIndex = 1
        Me.TextBox21.Visible = False
        '
        'DataGrid8
        '
        Me.DataGrid8.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid8.CaptionVisible = False
        Me.DataGrid8.DataMember = ""
        Me.DataGrid8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid8.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid8.Name = "DataGrid8"
        Me.DataGrid8.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid8.TabIndex = 0
        Me.DataGrid8.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle8})
        '
        'DataGridTableStyle8
        '
        Me.DataGridTableStyle8.DataGrid = Me.DataGrid8
        Me.DataGridTableStyle8.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn39, Me.DataGridTextBoxColumn40, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn130})
        Me.DataGridTableStyle8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle8.MappingName = "COTIZA_ANALISIS13"
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Format = ""
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "M"
        Me.DataGridTextBoxColumn39.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.ReadOnly = True
        Me.DataGridTextBoxColumn39.Width = 15
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Código"
        Me.DataGridTextBoxColumn40.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn40.ReadOnly = True
        Me.DataGridTextBoxColumn40.Width = 40
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn42.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn42.ReadOnly = True
        Me.DataGridTextBoxColumn42.Width = 687
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Format = "###,###"
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn43.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.ReadOnly = True
        Me.DataGridTextBoxColumn43.Width = 52
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn44.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 40
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = ""
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.HeaderText = "$ c/dcto."
        Me.DataGridTextBoxColumn45.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.Width = 46
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "Niv"
        Me.DataGridTextBoxColumn41.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn41.ReadOnly = True
        Me.DataGridTextBoxColumn41.Width = 30
        '
        'DataGridTextBoxColumn130
        '
        Me.DataGridTextBoxColumn130.Format = ""
        Me.DataGridTextBoxColumn130.FormatInfo = Nothing
        Me.DataGridTextBoxColumn130.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn130.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn130.NullText = ""
        Me.DataGridTextBoxColumn130.ReadOnly = True
        Me.DataGridTextBoxColumn130.Width = 30
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.TextBox20)
        Me.TabPage4.Controls.Add(Me.DataGrid4)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(932, 658)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "   3. Agua   "
        '
        'TextBox20
        '
        Me.TextBox20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox20.Location = New System.Drawing.Point(88, 128)
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.TextBox20.TabIndex = 54
        Me.TextBox20.Visible = False
        '
        'DataGrid4
        '
        Me.DataGrid4.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid4.CaptionVisible = False
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid4.TabIndex = 0
        Me.DataGrid4.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.AllowSorting = False
        Me.DataGridTableStyle5.DataGrid = Me.DataGrid4
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn131})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "COTIZA_ANALISIS12"
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "M"
        Me.DataGridTextBoxColumn18.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.ReadOnly = True
        Me.DataGridTextBoxColumn18.Width = 15
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Código"
        Me.DataGridTextBoxColumn19.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.ReadOnly = True
        Me.DataGridTextBoxColumn19.Width = 40
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn21.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.ReadOnly = True
        Me.DataGridTextBoxColumn21.Width = 685
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = "###,###"
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn22.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.ReadOnly = True
        Me.DataGridTextBoxColumn22.Width = 54
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn35.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 40
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn36.Format = "####,###"
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "$ c/dcto."
        Me.DataGridTextBoxColumn36.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 46
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Niv"
        Me.DataGridTextBoxColumn20.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.ReadOnly = True
        Me.DataGridTextBoxColumn20.Width = 30
        '
        'DataGridTextBoxColumn131
        '
        Me.DataGridTextBoxColumn131.Format = ""
        Me.DataGridTextBoxColumn131.FormatInfo = Nothing
        Me.DataGridTextBoxColumn131.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn131.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn131.NullText = ""
        Me.DataGridTextBoxColumn131.ReadOnly = True
        Me.DataGridTextBoxColumn131.Width = 30
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cjto_Cotizacion1, "PRODUCTOR.PRO_DIRECCION", True))
        Me.TextBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(112, 48)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(248, 20)
        Me.TextBox5.TabIndex = 53
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TextBox19)
        Me.TabPage3.Controls.Add(Me.DataGrid3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(932, 658)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "   4. Suelo  "
        '
        'TextBox19
        '
        Me.TextBox19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox19.Location = New System.Drawing.Point(24, 112)
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.TextBox19.TabIndex = 1
        Me.TextBox19.Visible = False
        '
        'DataGrid3
        '
        Me.DataGrid3.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid3.TabIndex = 0
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AllowSorting = False
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid3
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn132})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "COTIZA_ANALISIS11"
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "M"
        Me.DataGridTextBoxColumn14.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.ReadOnly = True
        Me.DataGridTextBoxColumn14.Width = 15
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Código"
        Me.DataGridTextBoxColumn15.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 40
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn17.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn17.ReadOnly = True
        Me.DataGridTextBoxColumn17.Width = 675
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn32.Format = "###,###"
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn32.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.ReadOnly = True
        Me.DataGridTextBoxColumn32.Width = 52
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn33.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 40
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn34.Format = "###,###"
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "$ c/dcto"
        Me.DataGridTextBoxColumn34.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 46
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Niv"
        Me.DataGridTextBoxColumn16.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn16.ReadOnly = True
        Me.DataGridTextBoxColumn16.Width = 30
        '
        'DataGridTextBoxColumn132
        '
        Me.DataGridTextBoxColumn132.Format = ""
        Me.DataGridTextBoxColumn132.FormatInfo = Nothing
        Me.DataGridTextBoxColumn132.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn132.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn132.NullText = ""
        Me.DataGridTextBoxColumn132.ReadOnly = True
        Me.DataGridTextBoxColumn132.Width = 30
        '
        'TabPage11
        '
        Me.TabPage11.Controls.Add(Me.TextBox29)
        Me.TabPage11.Controls.Add(Me.DataGrid16)
        Me.TabPage11.Location = New System.Drawing.Point(4, 23)
        Me.TabPage11.Name = "TabPage11"
        Me.TabPage11.Size = New System.Drawing.Size(932, 658)
        Me.TabPage11.TabIndex = 10
        Me.TabPage11.Text = "5. Fert-Qui  "
        '
        'TextBox29
        '
        Me.TextBox29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox29.Location = New System.Drawing.Point(72, 112)
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.TextBox29.TabIndex = 1
        Me.TextBox29.Visible = False
        '
        'DataGrid16
        '
        Me.DataGrid16.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid16.CaptionVisible = False
        Me.DataGrid16.DataMember = ""
        Me.DataGrid16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid16.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid16.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid16.Name = "DataGrid16"
        Me.DataGrid16.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid16.TabIndex = 0
        Me.DataGrid16.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle16})
        '
        'DataGridTableStyle16
        '
        Me.DataGridTableStyle16.AllowSorting = False
        Me.DataGridTableStyle16.DataGrid = Me.DataGrid16
        Me.DataGridTableStyle16.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn87, Me.DataGridTextBoxColumn88, Me.DataGridTextBoxColumn89, Me.DataGridTextBoxColumn90, Me.DataGridTextBoxColumn91, Me.DataGridTextBoxColumn92, Me.DataGridTextBoxColumn93, Me.DataGridTextBoxColumn133})
        Me.DataGridTableStyle16.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle16.MappingName = "COTIZA_ANALISIS14"
        '
        'DataGridTextBoxColumn87
        '
        Me.DataGridTextBoxColumn87.Format = ""
        Me.DataGridTextBoxColumn87.FormatInfo = Nothing
        Me.DataGridTextBoxColumn87.HeaderText = "M"
        Me.DataGridTextBoxColumn87.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn87.NullText = ""
        Me.DataGridTextBoxColumn87.Width = 15
        '
        'DataGridTextBoxColumn88
        '
        Me.DataGridTextBoxColumn88.Format = ""
        Me.DataGridTextBoxColumn88.FormatInfo = Nothing
        Me.DataGridTextBoxColumn88.HeaderText = "Código"
        Me.DataGridTextBoxColumn88.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn88.NullText = ""
        Me.DataGridTextBoxColumn88.Width = 40
        '
        'DataGridTextBoxColumn89
        '
        Me.DataGridTextBoxColumn89.Format = ""
        Me.DataGridTextBoxColumn89.FormatInfo = Nothing
        Me.DataGridTextBoxColumn89.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn89.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn89.NullText = ""
        Me.DataGridTextBoxColumn89.Width = 675
        '
        'DataGridTextBoxColumn90
        '
        Me.DataGridTextBoxColumn90.Format = "###,###"
        Me.DataGridTextBoxColumn90.FormatInfo = Nothing
        Me.DataGridTextBoxColumn90.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn90.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn90.NullText = ""
        Me.DataGridTextBoxColumn90.Width = 52
        '
        'DataGridTextBoxColumn91
        '
        Me.DataGridTextBoxColumn91.Format = ""
        Me.DataGridTextBoxColumn91.FormatInfo = Nothing
        Me.DataGridTextBoxColumn91.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn91.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn91.NullText = ""
        Me.DataGridTextBoxColumn91.Width = 40
        '
        'DataGridTextBoxColumn92
        '
        Me.DataGridTextBoxColumn92.Format = ""
        Me.DataGridTextBoxColumn92.FormatInfo = Nothing
        Me.DataGridTextBoxColumn92.HeaderText = "$ c/dcto"
        Me.DataGridTextBoxColumn92.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn92.NullText = ""
        Me.DataGridTextBoxColumn92.Width = 46
        '
        'DataGridTextBoxColumn93
        '
        Me.DataGridTextBoxColumn93.Format = ""
        Me.DataGridTextBoxColumn93.FormatInfo = Nothing
        Me.DataGridTextBoxColumn93.HeaderText = "Niv"
        Me.DataGridTextBoxColumn93.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn93.NullText = ""
        Me.DataGridTextBoxColumn93.Width = 30
        '
        'DataGridTextBoxColumn133
        '
        Me.DataGridTextBoxColumn133.Format = ""
        Me.DataGridTextBoxColumn133.FormatInfo = Nothing
        Me.DataGridTextBoxColumn133.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn133.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn133.NullText = ""
        Me.DataGridTextBoxColumn133.ReadOnly = True
        Me.DataGridTextBoxColumn133.Width = 30
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.TextBox41)
        Me.TabPage8.Controls.Add(Me.DataGrid27)
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(932, 658)
        Me.TabPage8.TabIndex = 13
        Me.TabPage8.Text = "  6. Fert-Org"
        '
        'TextBox41
        '
        Me.TextBox41.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox41.Location = New System.Drawing.Point(32, 64)
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Size = New System.Drawing.Size(72, 20)
        Me.TextBox41.TabIndex = 1
        Me.TextBox41.Visible = False
        '
        'DataGrid27
        '
        Me.DataGrid27.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid27.CaptionVisible = False
        Me.DataGrid27.DataMember = ""
        Me.DataGrid27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid27.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid27.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid27.Name = "DataGrid27"
        Me.DataGrid27.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid27.TabIndex = 0
        Me.DataGrid27.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle28})
        '
        'DataGridTableStyle28
        '
        Me.DataGridTableStyle28.AllowSorting = False
        Me.DataGridTableStyle28.DataGrid = Me.DataGrid27
        Me.DataGridTableStyle28.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn122, Me.DataGridTextBoxColumn123, Me.DataGridTextBoxColumn124, Me.DataGridTextBoxColumn125, Me.DataGridTextBoxColumn126, Me.DataGridTextBoxColumn127, Me.DataGridTextBoxColumn128, Me.DataGridTextBoxColumn134})
        Me.DataGridTableStyle28.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle28.MappingName = "COTIZA_ANALISIS17"
        '
        'DataGridTextBoxColumn122
        '
        Me.DataGridTextBoxColumn122.Format = ""
        Me.DataGridTextBoxColumn122.FormatInfo = Nothing
        Me.DataGridTextBoxColumn122.HeaderText = "M"
        Me.DataGridTextBoxColumn122.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn122.NullText = ""
        Me.DataGridTextBoxColumn122.ReadOnly = True
        Me.DataGridTextBoxColumn122.Width = 15
        '
        'DataGridTextBoxColumn123
        '
        Me.DataGridTextBoxColumn123.Format = ""
        Me.DataGridTextBoxColumn123.FormatInfo = Nothing
        Me.DataGridTextBoxColumn123.HeaderText = "Código"
        Me.DataGridTextBoxColumn123.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn123.NullText = ""
        Me.DataGridTextBoxColumn123.ReadOnly = True
        Me.DataGridTextBoxColumn123.Width = 40
        '
        'DataGridTextBoxColumn124
        '
        Me.DataGridTextBoxColumn124.Format = ""
        Me.DataGridTextBoxColumn124.FormatInfo = Nothing
        Me.DataGridTextBoxColumn124.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn124.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn124.NullText = ""
        Me.DataGridTextBoxColumn124.ReadOnly = True
        Me.DataGridTextBoxColumn124.Width = 680
        '
        'DataGridTextBoxColumn125
        '
        Me.DataGridTextBoxColumn125.Format = "###,###"
        Me.DataGridTextBoxColumn125.FormatInfo = Nothing
        Me.DataGridTextBoxColumn125.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn125.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn125.NullText = ""
        Me.DataGridTextBoxColumn125.ReadOnly = True
        Me.DataGridTextBoxColumn125.Width = 46
        '
        'DataGridTextBoxColumn126
        '
        Me.DataGridTextBoxColumn126.Format = ""
        Me.DataGridTextBoxColumn126.FormatInfo = Nothing
        Me.DataGridTextBoxColumn126.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn126.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn126.NullText = ""
        Me.DataGridTextBoxColumn126.ReadOnly = True
        Me.DataGridTextBoxColumn126.Width = 40
        '
        'DataGridTextBoxColumn127
        '
        Me.DataGridTextBoxColumn127.Format = "###,###"
        Me.DataGridTextBoxColumn127.FormatInfo = Nothing
        Me.DataGridTextBoxColumn127.HeaderText = "$ c/dcto"
        Me.DataGridTextBoxColumn127.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn127.NullText = ""
        Me.DataGridTextBoxColumn127.ReadOnly = True
        Me.DataGridTextBoxColumn127.Width = 46
        '
        'DataGridTextBoxColumn128
        '
        Me.DataGridTextBoxColumn128.Format = ""
        Me.DataGridTextBoxColumn128.FormatInfo = Nothing
        Me.DataGridTextBoxColumn128.HeaderText = "Niv"
        Me.DataGridTextBoxColumn128.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn128.NullText = ""
        Me.DataGridTextBoxColumn128.Width = 30
        '
        'DataGridTextBoxColumn134
        '
        Me.DataGridTextBoxColumn134.Format = ""
        Me.DataGridTextBoxColumn134.FormatInfo = Nothing
        Me.DataGridTextBoxColumn134.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn134.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn134.NullText = ""
        Me.DataGridTextBoxColumn134.ReadOnly = True
        Me.DataGridTextBoxColumn134.Width = 30
        '
        'TabPage12
        '
        Me.TabPage12.Controls.Add(Me.TextBox30)
        Me.TabPage12.Controls.Add(Me.DataGrid17)
        Me.TabPage12.Location = New System.Drawing.Point(4, 23)
        Me.TabPage12.Name = "TabPage12"
        Me.TabPage12.Size = New System.Drawing.Size(932, 658)
        Me.TabPage12.TabIndex = 11
        Me.TabPage12.Text = " 7. +Análisis"
        '
        'TextBox30
        '
        Me.TextBox30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox30.Location = New System.Drawing.Point(72, 112)
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.TextBox30.TabIndex = 1
        Me.TextBox30.Visible = False
        '
        'DataGrid17
        '
        Me.DataGrid17.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid17.CaptionVisible = False
        Me.DataGrid17.DataMember = ""
        Me.DataGrid17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid17.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid17.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid17.Name = "DataGrid17"
        Me.DataGrid17.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid17.TabIndex = 0
        Me.DataGrid17.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle17})
        '
        'DataGridTableStyle17
        '
        Me.DataGridTableStyle17.DataGrid = Me.DataGrid17
        Me.DataGridTableStyle17.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn94, Me.DataGridTextBoxColumn95, Me.DataGridTextBoxColumn96, Me.DataGridTextBoxColumn97, Me.DataGridTextBoxColumn98, Me.DataGridTextBoxColumn99, Me.DataGridTextBoxColumn100, Me.DataGridTextBoxColumn135})
        Me.DataGridTableStyle17.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle17.MappingName = "COTIZA_ANALISIS15"
        '
        'DataGridTextBoxColumn94
        '
        Me.DataGridTextBoxColumn94.Format = ""
        Me.DataGridTextBoxColumn94.FormatInfo = Nothing
        Me.DataGridTextBoxColumn94.HeaderText = "M"
        Me.DataGridTextBoxColumn94.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn94.NullText = ""
        Me.DataGridTextBoxColumn94.Width = 15
        '
        'DataGridTextBoxColumn95
        '
        Me.DataGridTextBoxColumn95.Format = ""
        Me.DataGridTextBoxColumn95.FormatInfo = Nothing
        Me.DataGridTextBoxColumn95.HeaderText = "Código"
        Me.DataGridTextBoxColumn95.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn95.NullText = ""
        Me.DataGridTextBoxColumn95.Width = 40
        '
        'DataGridTextBoxColumn96
        '
        Me.DataGridTextBoxColumn96.Format = ""
        Me.DataGridTextBoxColumn96.FormatInfo = Nothing
        Me.DataGridTextBoxColumn96.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn96.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn96.NullText = ""
        Me.DataGridTextBoxColumn96.Width = 680
        '
        'DataGridTextBoxColumn97
        '
        Me.DataGridTextBoxColumn97.Format = "###,###"
        Me.DataGridTextBoxColumn97.FormatInfo = Nothing
        Me.DataGridTextBoxColumn97.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn97.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn97.NullText = ""
        Me.DataGridTextBoxColumn97.Width = 46
        '
        'DataGridTextBoxColumn98
        '
        Me.DataGridTextBoxColumn98.Format = ""
        Me.DataGridTextBoxColumn98.FormatInfo = Nothing
        Me.DataGridTextBoxColumn98.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn98.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn98.NullText = ""
        Me.DataGridTextBoxColumn98.Width = 40
        '
        'DataGridTextBoxColumn99
        '
        Me.DataGridTextBoxColumn99.Format = ""
        Me.DataGridTextBoxColumn99.FormatInfo = Nothing
        Me.DataGridTextBoxColumn99.HeaderText = "$ c/dcto"
        Me.DataGridTextBoxColumn99.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn99.NullText = ""
        Me.DataGridTextBoxColumn99.Width = 46
        '
        'DataGridTextBoxColumn100
        '
        Me.DataGridTextBoxColumn100.Format = ""
        Me.DataGridTextBoxColumn100.FormatInfo = Nothing
        Me.DataGridTextBoxColumn100.HeaderText = "Niv"
        Me.DataGridTextBoxColumn100.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn100.NullText = ""
        Me.DataGridTextBoxColumn100.Width = 30
        '
        'DataGridTextBoxColumn135
        '
        Me.DataGridTextBoxColumn135.Format = ""
        Me.DataGridTextBoxColumn135.FormatInfo = Nothing
        Me.DataGridTextBoxColumn135.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn135.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn135.NullText = ""
        Me.DataGridTextBoxColumn135.ReadOnly = True
        Me.DataGridTextBoxColumn135.Width = 30
        '
        'TabPage13
        '
        Me.TabPage13.Controls.Add(Me.TextBox31)
        Me.TabPage13.Controls.Add(Me.DataGrid18)
        Me.TabPage13.Location = New System.Drawing.Point(4, 23)
        Me.TabPage13.Name = "TabPage13"
        Me.TabPage13.Size = New System.Drawing.Size(932, 658)
        Me.TabPage13.TabIndex = 12
        Me.TabPage13.Text = " 8. Kit,Otros"
        '
        'TextBox31
        '
        Me.TextBox31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox31.Location = New System.Drawing.Point(96, 72)
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.Size = New System.Drawing.Size(100, 20)
        Me.TextBox31.TabIndex = 1
        Me.TextBox31.Visible = False
        '
        'DataGrid18
        '
        Me.DataGrid18.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid18.CaptionVisible = False
        Me.DataGrid18.DataMember = ""
        Me.DataGrid18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid18.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid18.Location = New System.Drawing.Point(8, 0)
        Me.DataGrid18.Name = "DataGrid18"
        Me.DataGrid18.Size = New System.Drawing.Size(920, 661)
        Me.DataGrid18.TabIndex = 0
        Me.DataGrid18.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle18})
        '
        'DataGridTableStyle18
        '
        Me.DataGridTableStyle18.DataGrid = Me.DataGrid18
        Me.DataGridTableStyle18.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn101, Me.DataGridTextBoxColumn102, Me.DataGridTextBoxColumn103, Me.DataGridTextBoxColumn104, Me.DataGridTextBoxColumn105, Me.DataGridTextBoxColumn106, Me.DataGridTextBoxColumn107, Me.DataGridTextBoxColumn136})
        Me.DataGridTableStyle18.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle18.MappingName = "COTIZA_ANALISIS16"
        '
        'DataGridTextBoxColumn101
        '
        Me.DataGridTextBoxColumn101.Format = ""
        Me.DataGridTextBoxColumn101.FormatInfo = Nothing
        Me.DataGridTextBoxColumn101.HeaderText = "M"
        Me.DataGridTextBoxColumn101.MappingName = "CHEQUEO"
        Me.DataGridTextBoxColumn101.NullText = ""
        Me.DataGridTextBoxColumn101.ReadOnly = True
        Me.DataGridTextBoxColumn101.Width = 15
        '
        'DataGridTextBoxColumn102
        '
        Me.DataGridTextBoxColumn102.Format = ""
        Me.DataGridTextBoxColumn102.FormatInfo = Nothing
        Me.DataGridTextBoxColumn102.HeaderText = "Codi"
        Me.DataGridTextBoxColumn102.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn102.NullText = ""
        Me.DataGridTextBoxColumn102.ReadOnly = True
        Me.DataGridTextBoxColumn102.Width = 40
        '
        'DataGridTextBoxColumn103
        '
        Me.DataGridTextBoxColumn103.Format = ""
        Me.DataGridTextBoxColumn103.FormatInfo = Nothing
        Me.DataGridTextBoxColumn103.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn103.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn103.NullText = ""
        Me.DataGridTextBoxColumn103.ReadOnly = True
        Me.DataGridTextBoxColumn103.Width = 680
        '
        'DataGridTextBoxColumn104
        '
        Me.DataGridTextBoxColumn104.Format = "###,###"
        Me.DataGridTextBoxColumn104.FormatInfo = Nothing
        Me.DataGridTextBoxColumn104.HeaderText = "$ Valor"
        Me.DataGridTextBoxColumn104.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn104.NullText = ""
        Me.DataGridTextBoxColumn104.ReadOnly = True
        Me.DataGridTextBoxColumn104.Width = 46
        '
        'DataGridTextBoxColumn105
        '
        Me.DataGridTextBoxColumn105.Format = ""
        Me.DataGridTextBoxColumn105.FormatInfo = Nothing
        Me.DataGridTextBoxColumn105.HeaderText = "%dcto"
        Me.DataGridTextBoxColumn105.MappingName = "CTA_DESCUENTO"
        Me.DataGridTextBoxColumn105.NullText = ""
        Me.DataGridTextBoxColumn105.Width = 40
        '
        'DataGridTextBoxColumn106
        '
        Me.DataGridTextBoxColumn106.Format = "###,###"
        Me.DataGridTextBoxColumn106.FormatInfo = Nothing
        Me.DataGridTextBoxColumn106.HeaderText = "$ c/dcto"
        Me.DataGridTextBoxColumn106.MappingName = "CTA_NETO"
        Me.DataGridTextBoxColumn106.NullText = ""
        Me.DataGridTextBoxColumn106.Width = 46
        '
        'DataGridTextBoxColumn107
        '
        Me.DataGridTextBoxColumn107.Format = ""
        Me.DataGridTextBoxColumn107.FormatInfo = Nothing
        Me.DataGridTextBoxColumn107.HeaderText = "Niv"
        Me.DataGridTextBoxColumn107.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn107.NullText = ""
        Me.DataGridTextBoxColumn107.ReadOnly = True
        Me.DataGridTextBoxColumn107.Width = 30
        '
        'DataGridTextBoxColumn136
        '
        Me.DataGridTextBoxColumn136.Format = ""
        Me.DataGridTextBoxColumn136.FormatInfo = Nothing
        Me.DataGridTextBoxColumn136.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn136.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn136.NullText = ""
        Me.DataGridTextBoxColumn136.ReadOnly = True
        Me.DataGridTextBoxColumn136.Width = 30
        '
        'TabPage6
        '
        Me.TabPage6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage6.Controls.Add(Me.Panel5)
        Me.TabPage6.Controls.Add(Me.Panel2)
        Me.TabPage6.Controls.Add(Me.Panel1)
        Me.TabPage6.Controls.Add(Me.Panel3)
        Me.TabPage6.Controls.Add(Me.PictureBox1)
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(932, 658)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = " Nota Análsis"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.TxtFirma6)
        Me.Panel5.Controls.Add(Me.TxtFirma5)
        Me.Panel5.Controls.Add(Me.TxtFirma4)
        Me.Panel5.Controls.Add(Me.TxtFirma3)
        Me.Panel5.Controls.Add(Me.TxtFirma2)
        Me.Panel5.Controls.Add(Me.TxtFirma1)
        Me.Panel5.Controls.Add(Me.Label146)
        Me.Panel5.Location = New System.Drawing.Point(16, 585)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(900, 62)
        Me.Panel5.TabIndex = 84
        '
        'TxtFirma6
        '
        Me.TxtFirma6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma6.Location = New System.Drawing.Point(568, 32)
        Me.TxtFirma6.Name = "TxtFirma6"
        Me.TxtFirma6.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma6.TabIndex = 99
        '
        'TxtFirma5
        '
        Me.TxtFirma5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma5.Location = New System.Drawing.Point(568, 16)
        Me.TxtFirma5.Name = "TxtFirma5"
        Me.TxtFirma5.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma5.TabIndex = 98
        Me.TxtFirma5.Text = "Ingeniero Agrónomo"
        '
        'TxtFirma4
        '
        Me.TxtFirma4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma4.Location = New System.Drawing.Point(568, 0)
        Me.TxtFirma4.Name = "TxtFirma4"
        Me.TxtFirma4.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma4.TabIndex = 97
        Me.TxtFirma4.Text = "Rodrigo Millán Armijo"
        '
        'TxtFirma3
        '
        Me.TxtFirma3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma3.Location = New System.Drawing.Point(104, 32)
        Me.TxtFirma3.Name = "TxtFirma3"
        Me.TxtFirma3.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma3.TabIndex = 96
        '
        'TxtFirma2
        '
        Me.TxtFirma2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma2.Location = New System.Drawing.Point(104, 16)
        Me.TxtFirma2.Name = "TxtFirma2"
        Me.TxtFirma2.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma2.TabIndex = 95
        Me.TxtFirma2.Text = "Jefe Laboratorio"
        '
        'TxtFirma1
        '
        Me.TxtFirma1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFirma1.Location = New System.Drawing.Point(104, 0)
        Me.TxtFirma1.Name = "TxtFirma1"
        Me.TxtFirma1.Size = New System.Drawing.Size(128, 18)
        Me.TxtFirma1.TabIndex = 94
        Me.TxtFirma1.Text = "Rosa Espinoza Astudillo"
        '
        'Label146
        '
        Me.Label146.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label146.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label146.Location = New System.Drawing.Point(8, 0)
        Me.Label146.Name = "Label146"
        Me.Label146.Size = New System.Drawing.Size(48, 16)
        Me.Label146.TabIndex = 93
        Me.Label146.Text = "Firmas"
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button15)
        Me.Panel2.Controls.Add(Me.RTxtBajo)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.BTBajo)
        Me.Panel2.Location = New System.Drawing.Point(16, 325)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(910, 244)
        Me.Panel2.TabIndex = 82
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.Transparent
        Me.Button15.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button15.Location = New System.Drawing.Point(8, 56)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(33, 32)
        Me.Button15.TabIndex = 94
        Me.Button15.Text = "Borra"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'RTxtBajo
        '
        Me.RTxtBajo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtBajo.Location = New System.Drawing.Point(48, 8)
        Me.RTxtBajo.Name = "RTxtBajo"
        Me.RTxtBajo.Size = New System.Drawing.Size(900, 228)
        Me.RTxtBajo.TabIndex = 93
        Me.RTxtBajo.Text = ""
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label27.Location = New System.Drawing.Point(8, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(32, 16)
        Me.Label27.TabIndex = 92
        Me.Label27.Text = "Bajo"
        '
        'BTBajo
        '
        Me.BTBajo.BackColor = System.Drawing.Color.Transparent
        Me.BTBajo.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBajo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTBajo.Location = New System.Drawing.Point(8, 16)
        Me.BTBajo.Name = "BTBajo"
        Me.BTBajo.Size = New System.Drawing.Size(33, 32)
        Me.BTBajo.TabIndex = 83
        Me.BTBajo.Text = "Texto"
        Me.BTBajo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Button14)
        Me.Panel1.Controls.Add(Me.RTxtMedio)
        Me.Panel1.Controls.Add(Me.BTMedio)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Location = New System.Drawing.Point(16, 149)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 160)
        Me.Panel1.TabIndex = 81
        '
        'Button14
        '
        Me.Button14.BackColor = System.Drawing.Color.Transparent
        Me.Button14.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button14.Location = New System.Drawing.Point(8, 64)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(33, 32)
        Me.Button14.TabIndex = 76
        Me.Button14.Text = "Borra"
        Me.Button14.UseVisualStyleBackColor = False
        '
        'RTxtMedio
        '
        Me.RTxtMedio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtMedio.Location = New System.Drawing.Point(48, 0)
        Me.RTxtMedio.Name = "RTxtMedio"
        Me.RTxtMedio.Size = New System.Drawing.Size(900, 128)
        Me.RTxtMedio.TabIndex = 75
        Me.RTxtMedio.Text = ""
        '
        'BTMedio
        '
        Me.BTMedio.BackColor = System.Drawing.Color.Transparent
        Me.BTMedio.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTMedio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTMedio.Location = New System.Drawing.Point(8, 16)
        Me.BTMedio.Name = "BTMedio"
        Me.BTMedio.Size = New System.Drawing.Size(33, 32)
        Me.BTMedio.TabIndex = 42
        Me.BTMedio.Text = "Texto"
        Me.BTMedio.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label14.Location = New System.Drawing.Point(8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 16)
        Me.Label14.TabIndex = 74
        Me.Label14.Text = "Medio"
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button12)
        Me.Panel3.Controls.Add(Me.RTxtAlto)
        Me.Panel3.Controls.Add(Me.Label43)
        Me.Panel3.Controls.Add(Me.BTAlto)
        Me.Panel3.Location = New System.Drawing.Point(16, 8)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(910, 130)
        Me.Panel3.TabIndex = 83
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Transparent
        Me.Button12.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button12.Location = New System.Drawing.Point(8, 56)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(33, 32)
        Me.Button12.TabIndex = 77
        Me.Button12.Text = "Borra"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'RTxtAlto
        '
        Me.RTxtAlto.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RTxtAlto.Location = New System.Drawing.Point(48, 8)
        Me.RTxtAlto.Name = "RTxtAlto"
        Me.RTxtAlto.Size = New System.Drawing.Size(900, 130)
        Me.RTxtAlto.TabIndex = 76
        Me.RTxtAlto.Text = ""
        '
        'Label43
        '
        Me.Label43.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label43.Location = New System.Drawing.Point(8, 0)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(32, 16)
        Me.Label43.TabIndex = 75
        Me.Label43.Text = "Alto"
        '
        'BTAlto
        '
        Me.BTAlto.BackColor = System.Drawing.Color.Transparent
        Me.BTAlto.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTAlto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BTAlto.Location = New System.Drawing.Point(8, 16)
        Me.BTAlto.Name = "BTAlto"
        Me.BTAlto.Size = New System.Drawing.Size(33, 32)
        Me.BTAlto.TabIndex = 54
        Me.BTAlto.Text = "Texto"
        Me.BTAlto.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(48, 72)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 8)
        Me.PictureBox1.TabIndex = 77
        Me.PictureBox1.TabStop = False
        '
        'TabPage15
        '
        Me.TabPage15.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage15.Controls.Add(Me.Panel7)
        Me.TabPage15.Controls.Add(Me.Panel6)
        Me.TabPage15.Controls.Add(Me.Panel4)
        Me.TabPage15.Location = New System.Drawing.Point(4, 23)
        Me.TabPage15.Name = "TabPage15"
        Me.TabPage15.Size = New System.Drawing.Size(932, 658)
        Me.TabPage15.TabIndex = 15
        Me.TabPage15.Text = "Nota Kits  "
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.TxtKFirma3)
        Me.Panel7.Controls.Add(Me.TxtKFirma2)
        Me.Panel7.Controls.Add(Me.TxtKFirma1)
        Me.Panel7.Controls.Add(Me.Label147)
        Me.Panel7.Location = New System.Drawing.Point(16, 590)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(782, 60)
        Me.Panel7.TabIndex = 87
        '
        'TxtKFirma3
        '
        Me.TxtKFirma3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKFirma3.Location = New System.Drawing.Point(64, 32)
        Me.TxtKFirma3.Name = "TxtKFirma3"
        Me.TxtKFirma3.Size = New System.Drawing.Size(128, 18)
        Me.TxtKFirma3.TabIndex = 96
        '
        'TxtKFirma2
        '
        Me.TxtKFirma2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKFirma2.Location = New System.Drawing.Point(64, 16)
        Me.TxtKFirma2.Name = "TxtKFirma2"
        Me.TxtKFirma2.Size = New System.Drawing.Size(128, 18)
        Me.TxtKFirma2.TabIndex = 95
        Me.TxtKFirma2.Text = "Jefe Laboratorio"
        '
        'TxtKFirma1
        '
        Me.TxtKFirma1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtKFirma1.Location = New System.Drawing.Point(64, 0)
        Me.TxtKFirma1.Name = "TxtKFirma1"
        Me.TxtKFirma1.Size = New System.Drawing.Size(128, 18)
        Me.TxtKFirma1.TabIndex = 94
        Me.TxtKFirma1.Text = "Rosa Espinoza Astudillo"
        '
        'Label147
        '
        Me.Label147.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label147.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label147.Location = New System.Drawing.Point(8, 0)
        Me.Label147.Name = "Label147"
        Me.Label147.Size = New System.Drawing.Size(48, 16)
        Me.Label147.TabIndex = 93
        Me.Label147.Text = "Firmas"
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.Button33)
        Me.Panel6.Controls.Add(Me.RichTextBox3)
        Me.Panel6.Controls.Add(Me.Label36)
        Me.Panel6.Controls.Add(Me.Button36)
        Me.Panel6.Location = New System.Drawing.Point(16, 260)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(910, 320)
        Me.Panel6.TabIndex = 86
        '
        'Button33
        '
        Me.Button33.BackColor = System.Drawing.Color.Transparent
        Me.Button33.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button33.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button33.Location = New System.Drawing.Point(8, 56)
        Me.Button33.Name = "Button33"
        Me.Button33.Size = New System.Drawing.Size(33, 32)
        Me.Button33.TabIndex = 94
        Me.Button33.Text = "Borra"
        Me.Button33.UseVisualStyleBackColor = False
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox3.Location = New System.Drawing.Point(48, 8)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(890, 290)
        Me.RichTextBox3.TabIndex = 93
        Me.RichTextBox3.Text = ""
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label36.Location = New System.Drawing.Point(8, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(32, 16)
        Me.Label36.TabIndex = 92
        Me.Label36.Text = "Bajo"
        '
        'Button36
        '
        Me.Button36.BackColor = System.Drawing.Color.Transparent
        Me.Button36.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button36.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button36.Location = New System.Drawing.Point(8, 16)
        Me.Button36.Name = "Button36"
        Me.Button36.Size = New System.Drawing.Size(33, 32)
        Me.Button36.TabIndex = 83
        Me.Button36.Text = "Texto"
        Me.Button36.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Button22)
        Me.Panel4.Controls.Add(Me.RichTextBox1)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Controls.Add(Me.Button24)
        Me.Panel4.Location = New System.Drawing.Point(16, 8)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(910, 235)
        Me.Panel4.TabIndex = 84
        '
        'Button22
        '
        Me.Button22.BackColor = System.Drawing.Color.Transparent
        Me.Button22.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button22.Location = New System.Drawing.Point(8, 56)
        Me.Button22.Name = "Button22"
        Me.Button22.Size = New System.Drawing.Size(33, 32)
        Me.Button22.TabIndex = 77
        Me.Button22.Text = "Borra"
        Me.Button22.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(48, 8)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(900, 205)
        Me.RichTextBox1.TabIndex = 76
        Me.RichTextBox1.Text = ""
        '
        'Label32
        '
        Me.Label32.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label32.Location = New System.Drawing.Point(8, 0)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(32, 16)
        Me.Label32.TabIndex = 75
        Me.Label32.Text = "Alto"
        '
        'Button24
        '
        Me.Button24.BackColor = System.Drawing.Color.Transparent
        Me.Button24.Font = New System.Drawing.Font("Arial", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button24.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button24.Location = New System.Drawing.Point(8, 16)
        Me.Button24.Name = "Button24"
        Me.Button24.Size = New System.Drawing.Size(33, 32)
        Me.Button24.TabIndex = 54
        Me.Button24.Text = "Texto"
        Me.Button24.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox10.Controls.Add(Me.GroupBox11)
        Me.GroupBox10.Controls.Add(Me.GroupBox25)
        Me.GroupBox10.Controls.Add(Me.GroupBox26)
        Me.GroupBox10.Controls.Add(Me.Label34)
        Me.GroupBox10.Controls.Add(Me.Button47)
        Me.GroupBox10.Controls.Add(Me.DataGrid6)
        Me.GroupBox10.Location = New System.Drawing.Point(328, 42)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(842, 808)
        Me.GroupBox10.TabIndex = 108
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Visible = False
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.CBCierra)
        Me.GroupBox11.Controls.Add(Me.CBElimina)
        Me.GroupBox11.Controls.Add(Me.CmdEnviar)
        Me.GroupBox11.Controls.Add(Me.CmdVerExcel)
        Me.GroupBox11.Controls.Add(Me.CmdCreaNueva)
        Me.GroupBox11.Controls.Add(Me.CmdModificaAnt)
        Me.GroupBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox11.Location = New System.Drawing.Point(105, 352)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(613, 104)
        Me.GroupBox11.TabIndex = 191
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Cotizador"
        Me.GroupBox11.Visible = False
        '
        'CBCierra
        '
        Me.CBCierra.BackColor = System.Drawing.Color.Transparent
        Me.CBCierra.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.CBCierra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CBCierra.Location = New System.Drawing.Point(523, 39)
        Me.CBCierra.Name = "CBCierra"
        Me.CBCierra.Size = New System.Drawing.Size(70, 32)
        Me.CBCierra.TabIndex = 5
        Me.CBCierra.Text = "Cerrar"
        Me.CBCierra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBCierra.UseVisualStyleBackColor = False
        '
        'CBElimina
        '
        Me.CBElimina.BackColor = System.Drawing.Color.Transparent
        Me.CBElimina.Image = Global.LabSys.My.Resources.Resources.cross
        Me.CBElimina.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CBElimina.Location = New System.Drawing.Point(432, 40)
        Me.CBElimina.Name = "CBElimina"
        Me.CBElimina.Size = New System.Drawing.Size(63, 32)
        Me.CBElimina.TabIndex = 4
        Me.CBElimina.Text = "Elimina"
        Me.CBElimina.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CBElimina.UseVisualStyleBackColor = False
        '
        'CmdEnviar
        '
        Me.CmdEnviar.BackColor = System.Drawing.Color.Transparent
        Me.CmdEnviar.Image = Global.LabSys.My.Resources.Resources.email_go1
        Me.CmdEnviar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdEnviar.Location = New System.Drawing.Point(216, 40)
        Me.CmdEnviar.Name = "CmdEnviar"
        Me.CmdEnviar.Size = New System.Drawing.Size(88, 32)
        Me.CmdEnviar.TabIndex = 3
        Me.CmdEnviar.Text = "Envia e-mail"
        Me.CmdEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdEnviar.UseVisualStyleBackColor = False
        '
        'CmdVerExcel
        '
        Me.CmdVerExcel.BackColor = System.Drawing.Color.Transparent
        Me.CmdVerExcel.Image = Global.LabSys.My.Resources.Resources.page_excel
        Me.CmdVerExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdVerExcel.Location = New System.Drawing.Point(19, 40)
        Me.CmdVerExcel.Name = "CmdVerExcel"
        Me.CmdVerExcel.Size = New System.Drawing.Size(77, 32)
        Me.CmdVerExcel.TabIndex = 2
        Me.CmdVerExcel.Text = "Ver Excel"
        Me.CmdVerExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdVerExcel.UseVisualStyleBackColor = False
        '
        'CmdCreaNueva
        '
        Me.CmdCreaNueva.BackColor = System.Drawing.Color.Transparent
        Me.CmdCreaNueva.Location = New System.Drawing.Point(323, 40)
        Me.CmdCreaNueva.Name = "CmdCreaNueva"
        Me.CmdCreaNueva.Size = New System.Drawing.Size(88, 32)
        Me.CmdCreaNueva.TabIndex = 1
        Me.CmdCreaNueva.Text = "Button52"
        Me.CmdCreaNueva.UseVisualStyleBackColor = False
        '
        'CmdModificaAnt
        '
        Me.CmdModificaAnt.BackColor = System.Drawing.Color.Transparent
        Me.CmdModificaAnt.Image = Global.LabSys.My.Resources.Resources.application_form_edit
        Me.CmdModificaAnt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdModificaAnt.Location = New System.Drawing.Point(122, 40)
        Me.CmdModificaAnt.Name = "CmdModificaAnt"
        Me.CmdModificaAnt.Size = New System.Drawing.Size(74, 32)
        Me.CmdModificaAnt.TabIndex = 0
        Me.CmdModificaAnt.Text = "Modifica"
        Me.CmdModificaAnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CmdModificaAnt.UseVisualStyleBackColor = False
        '
        'GroupBox25
        '
        Me.GroupBox25.Controls.Add(Me.Button11)
        Me.GroupBox25.Location = New System.Drawing.Point(6, 760)
        Me.GroupBox25.Name = "GroupBox25"
        Me.GroupBox25.Size = New System.Drawing.Size(825, 40)
        Me.GroupBox25.TabIndex = 137
        Me.GroupBox25.TabStop = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.Transparent
        Me.Button11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(8, 8)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(22, 22)
        Me.Button11.TabIndex = 117
        Me.Button11.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button11, "Ayuda")
        Me.Button11.UseVisualStyleBackColor = False
        '
        'GroupBox26
        '
        Me.GroupBox26.Controls.Add(Me.Label111)
        Me.GroupBox26.Controls.Add(Me.Label110)
        Me.GroupBox26.Controls.Add(Me.Label76)
        Me.GroupBox26.Controls.Add(Me.Label78)
        Me.GroupBox26.Controls.Add(Me.Button9)
        Me.GroupBox26.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox26.Location = New System.Drawing.Point(11, 546)
        Me.GroupBox26.Name = "GroupBox26"
        Me.GroupBox26.Size = New System.Drawing.Size(828, 96)
        Me.GroupBox26.TabIndex = 136
        Me.GroupBox26.TabStop = False
        Me.GroupBox26.Visible = False
        '
        'Label111
        '
        Me.Label111.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label111.Location = New System.Drawing.Point(8, 48)
        Me.Label111.Name = "Label111"
        Me.Label111.Size = New System.Drawing.Size(712, 16)
        Me.Label111.TabIndex = 113
        Me.Label111.Text = "          Posicionarse en la primera fila (N°Cot, fecha, empresa, productor,etc.)" & _
            " y dar click en la"
        '
        'Label110
        '
        Me.Label110.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label110.Location = New System.Drawing.Point(8, 64)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(712, 16)
        Me.Label110.TabIndex = 111
        Me.Label110.Text = "          columna que le interesa indexar, finalmente buscar el nombre deseado."
        '
        'Label76
        '
        Me.Label76.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.Location = New System.Drawing.Point(8, 32)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(712, 16)
        Me.Label76.TabIndex = 34
        Me.Label76.Text = "Buscar una Empresa, Productor, etc."
        '
        'Label78
        '
        Me.Label78.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label78.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label78.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label78.Location = New System.Drawing.Point(0, 1)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(808, 16)
        Me.Label78.TabIndex = 13
        Me.Label78.Text = "Ayuda"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(809, -2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(20, 21)
        Me.Button9.TabIndex = 12
        Me.Button9.Text = "X"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label34
        '
        Me.Label34.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(8, 0)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(816, 16)
        Me.Label34.TabIndex = 62
        Me.Label34.Text = "Consulta Cotizaciones "
        '
        'Button47
        '
        Me.Button47.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button47.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button47.Location = New System.Drawing.Point(824, -1)
        Me.Button47.Name = "Button47"
        Me.Button47.Size = New System.Drawing.Size(16, 16)
        Me.Button47.TabIndex = 61
        Me.Button47.Text = "X"
        '
        'DataGrid6
        '
        Me.DataGrid6.CaptionVisible = False
        Me.DataGrid6.DataMember = "COTIZACION1"
        Me.DataGrid6.DataSource = Me.Cjto_Cotizacion1
        Me.DataGrid6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid6.Location = New System.Drawing.Point(8, 24)
        Me.DataGrid6.Name = "DataGrid6"
        Me.DataGrid6.Size = New System.Drawing.Size(832, 738)
        Me.DataGrid6.TabIndex = 60
        Me.DataGrid6.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.DataGrid6
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn28, Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn46})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "COTIZACION1"
        Me.DataGridTableStyle6.ReadOnly = True
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Nº Cot."
        Me.DataGridTextBoxColumn23.MappingName = "COT_NUMERO"
        Me.DataGridTextBoxColumn23.Width = 40
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = "dd/MM/yy"
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Fecha"
        Me.DataGridTextBoxColumn24.MappingName = "COT_FECHA"
        Me.DataGridTextBoxColumn24.Width = 62
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Empresa"
        Me.DataGridTextBoxColumn25.MappingName = "COT_EMPRESA"
        Me.DataGridTextBoxColumn25.Width = 140
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Productor"
        Me.DataGridTextBoxColumn26.MappingName = "COT_NOMBRE"
        Me.DataGridTextBoxColumn26.Width = 130
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Atención"
        Me.DataGridTextBoxColumn27.MappingName = "COT_ATENCION"
        Me.DataGridTextBoxColumn27.Width = 130
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Rut"
        Me.DataGridTextBoxColumn4.MappingName = "COT_RUT"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 70
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "Mue-1"
        Me.DataGridTextBoxColumn28.MappingName = "COT_MUE1"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 40
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Mue-2"
        Me.DataGridTextBoxColumn29.MappingName = "COT_MUE2"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 40
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Mue-3"
        Me.DataGridTextBoxColumn30.MappingName = "COT_MUE3"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 40
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "Mue-4"
        Me.DataGridTextBoxColumn46.MappingName = "COT_MUE4"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 40
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(229, 41)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 61
        Me.MonthCalendar1.Visible = False
        '
        'DataGridTextBoxColumn137
        '
        Me.DataGridTextBoxColumn137.Format = ""
        Me.DataGridTextBoxColumn137.FormatInfo = Nothing
        Me.DataGridTextBoxColumn137.Width = -1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nº Cotización:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.TextBox1.Location = New System.Drawing.Point(110, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(64, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Dirección:"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(361, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fono:"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(679, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Atención:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "E-mail:"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(361, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Comuna:"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(917, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 16)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Fax:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(697, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 16)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Rut:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(205, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 16)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Fecha:"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(736, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(136, 20)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(254, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(64, 20)
        Me.TextBox3.TabIndex = 13
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(110, 74)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(236, 20)
        Me.TextBox7.TabIndex = 76
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cjto_Cotizacion1, "PRODUCTOR1.PRO_ATENCION", True))
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(736, 48)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(136, 20)
        Me.TextBox8.TabIndex = 75
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(110, 100)
        Me.TextBox9.MaxLength = 50
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(236, 20)
        Me.TextBox9.TabIndex = 79
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(422, 100)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(112, 20)
        Me.TextBox10.TabIndex = 82
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(964, 100)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(136, 20)
        Me.TextBox11.TabIndex = 81
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=HP-INF-SANDO;pe" & _
            "rsist security info=True;initial catalog=LabSys;password=agrolito"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT COT_NUMERO, CTD_ANALISIS, CTA_UNITARIO, CTA_DESCUENTO, CTA_NETO FROM COTIZ" & _
            "A_ANALISIS"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = resources.GetString("SqlInsertCommand3.CommandText")
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CTD_ANALISIS", System.Data.SqlDbType.Float, 8, "CTD_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTA_UNITARIO", System.Data.SqlDbType.Int, 4, "CTA_UNITARIO"), New System.Data.SqlClient.SqlParameter("@CTA_DESCUENTO", System.Data.SqlDbType.Float, 8, "CTA_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@CTA_NETO", System.Data.SqlDbType.Int, 4, "CTA_NETO")})
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = resources.GetString("SqlUpdateCommand3.CommandText")
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CTD_ANALISIS", System.Data.SqlDbType.Float, 8, "CTD_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTA_UNITARIO", System.Data.SqlDbType.Int, 4, "CTA_UNITARIO"), New System.Data.SqlClient.SqlParameter("@CTA_DESCUENTO", System.Data.SqlDbType.Float, 8, "CTA_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@CTA_NETO", System.Data.SqlDbType.Int, 4, "CTA_NETO"), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_ANALISIS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_NETO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_UNITARIO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_UNITARIO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = resources.GetString("SqlDeleteCommand3.CommandText")
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_ANALISIS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_NETO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTA_UNITARIO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTA_UNITARIO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlInsertCommand7
        '
        Me.SqlInsertCommand7.CommandText = "INSERT INTO COMUNAS(COM_COMUNA, PRO_PROVINCIA, REG_CODIGO) VALUES (@COM_COMUNA, @" & _
            "PRO_PROVINCIA, @REG_CODIGO); SELECT COM_COMUNA, PRO_PROVINCIA, REG_CODIGO FROM C" & _
            "OMUNAS WHERE (COM_COMUNA = @COM_COMUNA)"
        Me.SqlInsertCommand7.Connection = Me.SqlConnection1
        Me.SqlInsertCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COM_COMUNA"), New System.Data.SqlClient.SqlParameter("@PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, "PRO_PROVINCIA"), New System.Data.SqlClient.SqlParameter("@REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, "REG_CODIGO")})
        '
        'SqlUpdateCommand7
        '
        Me.SqlUpdateCommand7.CommandText = resources.GetString("SqlUpdateCommand7.CommandText")
        Me.SqlUpdateCommand7.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COM_COMUNA"), New System.Data.SqlClient.SqlParameter("@PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, "PRO_PROVINCIA"), New System.Data.SqlClient.SqlParameter("@REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, "REG_CODIGO"), New System.Data.SqlClient.SqlParameter("@Original_COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COM_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PRO_PROVINCIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REG_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand7
        '
        Me.SqlDeleteCommand7.CommandText = resources.GetString("SqlDeleteCommand7.CommandText")
        Me.SqlDeleteCommand7.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COM_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PRO_PROVINCIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REG_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Cotiza_Analisis
        '
        Me.Adap_Cotiza_Analisis.DeleteCommand = Me.SqlDeleteCommand3
        Me.Adap_Cotiza_Analisis.InsertCommand = Me.SqlInsertCommand3
        Me.Adap_Cotiza_Analisis.SelectCommand = Me.SqlSelectCommand3
        Me.Adap_Cotiza_Analisis.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CTD_ANALISIS", "CTD_ANALISIS"), New System.Data.Common.DataColumnMapping("CTA_UNITARIO", "CTA_UNITARIO"), New System.Data.Common.DataColumnMapping("CTA_DESCUENTO", "CTA_DESCUENTO"), New System.Data.Common.DataColumnMapping("CTA_NETO", "CTA_NETO")})})
        Me.Adap_Cotiza_Analisis.UpdateCommand = Me.SqlUpdateCommand3
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(361, 49)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Srs/Pro:"
        '
        'SqlSelectCommand9
        '
        Me.SqlSelectCommand9.CommandText = "SELECT PRO_RUT,PRO_NOMBRE,PRO_DIRECCION,PRO_FONO1,PRO_FAX,PRO_EMAIL1,COM_COMUNA,P" & _
            "RO_EMPRESA,PRO_ATENCION,PRO_EMAIL2 FROM PRODUCTOR WHERE (PRO_RUT LIKE @PRO_RUT)O" & _
            "R (PRO_NOMBRE LIKE @PRO_NOMBRE)"
        Me.SqlSelectCommand9.Connection = Me.SqlConnection1
        Me.SqlSelectCommand9.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRO_RUT", System.Data.SqlDbType.NVarChar, 13, "PRO_RUT"), New System.Data.SqlClient.SqlParameter("@PRO_NOMBRE", System.Data.SqlDbType.NVarChar, 50, "PRO_NOMBRE")})
        '
        'Adap_Productor
        '
        Me.Adap_Productor.SelectCommand = Me.SqlSelectCommand9
        Me.Adap_Productor.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PRODUCTOR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PRO_RUT", "PRO_RUT"), New System.Data.Common.DataColumnMapping("PRO_NOMBRE", "PRO_NOMBRE"), New System.Data.Common.DataColumnMapping("PRO_DIRECCION", "PRO_DIRECCION"), New System.Data.Common.DataColumnMapping("PRO_FONO1", "PRO_FONO1"), New System.Data.Common.DataColumnMapping("PRO_FONO2", "PRO_FONO2"), New System.Data.Common.DataColumnMapping("PRO_CELULAR", "PRO_CELULAR"), New System.Data.Common.DataColumnMapping("PRO_FAX", "PRO_FAX"), New System.Data.Common.DataColumnMapping("PRO_EMAIL1", "PRO_EMAIL1"), New System.Data.Common.DataColumnMapping("PRO_EMAIL2", "PRO_EMAIL2"), New System.Data.Common.DataColumnMapping("PRO_CASILLA", "PRO_CASILLA"), New System.Data.Common.DataColumnMapping("PRO_DESCUENTO", "PRO_DESCUENTO"), New System.Data.Common.DataColumnMapping("CIU_NOMBRE", "CIU_NOMBRE"), New System.Data.Common.DataColumnMapping("LOC_LOCALIDAD", "LOC_LOCALIDAD"), New System.Data.Common.DataColumnMapping("COM_COMUNA", "COM_COMUNA")})})
        '
        'Adap_Analisis
        '
        Me.Adap_Analisis.SelectCommand = Me.SqlSelectCommand1
        Me.Adap_Analisis.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_ANALISIS1", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_NIVEL_PRECIO", "ANA_NIVEL_PRECIO"), New System.Data.Common.DataColumnMapping("ANA_NETO", "ANA_NETO"), New System.Data.Common.DataColumnMapping("CTA_DESCUENTO", "CTA_DESCUENTO"), New System.Data.Common.DataColumnMapping("CTA_NETO", "CTA_NETO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS")})})
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = resources.GetString("SqlSelectCommand1.CommandText")
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        Me.SqlSelectCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NUMERO_COT", System.Data.SqlDbType.NVarChar, 10, "NUMERO_COT")})
        '
        'SqlSelectCommand5
        '
        Me.SqlSelectCommand5.CommandText = "SELECT COT_NUMERO, CON_NUMERO, NOT_NOTAS FROM COTIZA_NOTAS"
        Me.SqlSelectCommand5.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand4
        '
        Me.SqlInsertCommand4.CommandText = resources.GetString("SqlInsertCommand4.CommandText")
        Me.SqlInsertCommand4.Connection = Me.SqlConnection1
        Me.SqlInsertCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CON_NUMERO", System.Data.SqlDbType.Int, 4, "CON_NUMERO"), New System.Data.SqlClient.SqlParameter("@NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, "NOT_NOTAS")})
        '
        'SqlUpdateCommand4
        '
        Me.SqlUpdateCommand4.CommandText = resources.GetString("SqlUpdateCommand4.CommandText")
        Me.SqlUpdateCommand4.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CON_NUMERO", System.Data.SqlDbType.Int, 4, "CON_NUMERO"), New System.Data.SqlClient.SqlParameter("@NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, "NOT_NOTAS"), New System.Data.SqlClient.SqlParameter("@Original_CON_NUMERO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CON_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOT_NOTAS", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand4
        '
        Me.SqlDeleteCommand4.CommandText = "DELETE FROM COTIZA_NOTAS WHERE (CON_NUMERO = @Original_CON_NUMERO) AND (COT_NUMER" & _
            "O = @Original_COT_NUMERO) AND (NOT_NOTAS = @Original_NOT_NOTAS OR @Original_NOT_" & _
            "NOTAS IS NULL AND NOT_NOTAS IS NULL)"
        Me.SqlDeleteCommand4.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand4.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CON_NUMERO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CON_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOT_NOTAS", System.Data.SqlDbType.NVarChar, 110, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOT_NOTAS", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Notas
        '
        Me.Adap_Notas.DeleteCommand = Me.SqlDeleteCommand4
        Me.Adap_Notas.InsertCommand = Me.SqlInsertCommand4
        Me.Adap_Notas.SelectCommand = Me.SqlSelectCommand5
        Me.Adap_Notas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_NOTAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CON_NUMERO", "CON_NUMERO"), New System.Data.Common.DataColumnMapping("NOT_NOTAS", "NOT_NOTAS")})})
        Me.Adap_Notas.UpdateCommand = Me.SqlUpdateCommand4
        '
        'SqlSelectCommand10
        '
        Me.SqlSelectCommand10.CommandText = resources.GetString("SqlSelectCommand10.CommandText")
        Me.SqlSelectCommand10.Connection = Me.SqlConnection1
        '
        'Adap_Combo_pro
        '
        Me.Adap_Combo_pro.SelectCommand = Me.SqlSelectCommand10
        Me.Adap_Combo_pro.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PRODUCTOR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PRO_RUT", "PRO_RUT"), New System.Data.Common.DataColumnMapping("PRO_NOMBRE", "PRO_NOMBRE"), New System.Data.Common.DataColumnMapping("PRO_DIRECCION", "PRO_DIRECCION"), New System.Data.Common.DataColumnMapping("PRO_FONO1", "PRO_FONO1"), New System.Data.Common.DataColumnMapping("PRO_FONO2", "PRO_FONO2"), New System.Data.Common.DataColumnMapping("PRO_CELULAR", "PRO_CELULAR"), New System.Data.Common.DataColumnMapping("PRO_FAX", "PRO_FAX"), New System.Data.Common.DataColumnMapping("PRO_EMAIL1", "PRO_EMAIL1"), New System.Data.Common.DataColumnMapping("PRO_EMAIL2", "PRO_EMAIL2"), New System.Data.Common.DataColumnMapping("PRO_CASILLA", "PRO_CASILLA"), New System.Data.Common.DataColumnMapping("PRO_DESCUENTO", "PRO_DESCUENTO"), New System.Data.Common.DataColumnMapping("CIU_NOMBRE", "CIU_NOMBRE"), New System.Data.Common.DataColumnMapping("LOC_LOCALIDAD", "LOC_LOCALIDAD"), New System.Data.Common.DataColumnMapping("COM_COMUNA", "COM_COMUNA")})})
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(680, 75)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 16)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "Ciudad:"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(679, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 16)
        Me.Label21.TabIndex = 58
        Me.Label21.Text = "Celular:"
        '
        'TextBox16
        '
        Me.TextBox16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox16.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cjto_Cotizacion1, "PRODUCTOR1.PRO_CELULAR", True))
        Me.TextBox16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox16.Location = New System.Drawing.Point(736, 101)
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Size = New System.Drawing.Size(136, 20)
        Me.TextBox16.TabIndex = 83
        '
        'SqlSelectCommand11
        '
        Me.SqlSelectCommand11.CommandText = resources.GetString("SqlSelectCommand11.CommandText")
        Me.SqlSelectCommand11.Connection = Me.SqlConnection1
        Me.SqlSelectCommand11.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RUT_COT", System.Data.SqlDbType.NVarChar, 13, "RUT_COT"), New System.Data.SqlClient.SqlParameter("@NOMBRE_COT", System.Data.SqlDbType.NVarChar, 50, "NOMBRE_COT")})
        '
        'Adap_Con_Cot
        '
        Me.Adap_Con_Cot.SelectCommand = Me.SqlSelectCommand11
        Me.Adap_Con_Cot.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("COT_RUT", "COT_RUT"), New System.Data.Common.DataColumnMapping("COT_NOMBRE", "COT_NOMBRE"), New System.Data.Common.DataColumnMapping("COT_EMAIL", "COT_EMAIL"), New System.Data.Common.DataColumnMapping("COT_ATENCION", "COT_ATENCION"), New System.Data.Common.DataColumnMapping("COT_DIRECCION", "COT_DIRECCION"), New System.Data.Common.DataColumnMapping("COT_COMUNA", "COT_COMUNA"), New System.Data.Common.DataColumnMapping("COT_FONO", "COT_FONO"), New System.Data.Common.DataColumnMapping("COT_FAX", "COT_FAX"), New System.Data.Common.DataColumnMapping("COT_SUBTOTAL", "COT_SUBTOTAL"), New System.Data.Common.DataColumnMapping("COT_DESCUENTO", "COT_DESCUENTO"), New System.Data.Common.DataColumnMapping("COT_NETO", "COT_NETO"), New System.Data.Common.DataColumnMapping("COT_IVA", "COT_IVA"), New System.Data.Common.DataColumnMapping("COT_TOTAL", "COT_TOTAL"), New System.Data.Common.DataColumnMapping("COT_FECHA", "COT_FECHA"), New System.Data.Common.DataColumnMapping("COT_CELULAR", "COT_CELULAR"), New System.Data.Common.DataColumnMapping("COT_CIUDAD", "COT_CIUDAD")})})
        '
        'SqlSelectCommand12
        '
        Me.SqlSelectCommand12.CommandText = "SELECT COT_NUMERO, CTD_ANALISIS, CTD_CANTIDAD, CTD_UNITARIO, CTD_SUBTOTAL, CTD_DE" & _
            "SCUENTO, CTD_TOTAL, ANA_ANALISIS,CTD_MUESTRA FROM COTIZA_DETALLE WHERE COT_NUMER" & _
            "O=@NUMERO_COT"
        Me.SqlSelectCommand12.Connection = Me.SqlConnection1
        Me.SqlSelectCommand12.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NUMERO_COT", System.Data.SqlDbType.NVarChar, 10, "NUMERO_COT")})
        '
        'Adap_Con_Det
        '
        Me.Adap_Con_Det.SelectCommand = Me.SqlSelectCommand12
        Me.Adap_Con_Det.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_DETALLE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CTD_ANALISIS", "CTD_ANALISIS"), New System.Data.Common.DataColumnMapping("CTD_CANTIDAD", "CTD_CANTIDAD"), New System.Data.Common.DataColumnMapping("CTD_UNITARIO", "CTD_UNITARIO"), New System.Data.Common.DataColumnMapping("CTD_SUBTOTAL", "CTD_SUBTOTAL"), New System.Data.Common.DataColumnMapping("CTD_DESCUENTO", "CTD_DESCUENTO"), New System.Data.Common.DataColumnMapping("CTD_TOTAL", "CTD_TOTAL"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS")})})
        '
        'SqlSelectCommand14
        '
        Me.SqlSelectCommand14.CommandText = "SELECT COT_NUMERO, CTD_ANALISIS, CTA_UNITARIO, CTA_DESCUENTO, CTA_NETO FROM COTIZ" & _
            "A_ANALISIS WHERE COT_NUMERO=@NUMERO_COT"
        Me.SqlSelectCommand14.Connection = Me.SqlConnection1
        Me.SqlSelectCommand14.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NUMERO_COT", System.Data.SqlDbType.NVarChar, 10, "NUMERO_COT")})
        '
        'Adap_Con_Analisis
        '
        Me.Adap_Con_Analisis.SelectCommand = Me.SqlSelectCommand14
        Me.Adap_Con_Analisis.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CTD_ANALISIS", "CTD_ANALISIS"), New System.Data.Common.DataColumnMapping("CTA_UNITARIO", "CTA_UNITARIO"), New System.Data.Common.DataColumnMapping("CTA_DESCUENTO", "CTA_DESCUENTO"), New System.Data.Common.DataColumnMapping("CTA_NETO", "CTA_NETO")})})
        '
        'SqlSelectCommand15
        '
        Me.SqlSelectCommand15.CommandText = "SELECT COT_NUMERO, CON_NUMERO, NOT_NOTAS,NOTA_COT_TIPO FROM COTIZA_NOTAS WHERE CO" & _
            "T_NUMERO=@NUMERO_COT"
        Me.SqlSelectCommand15.Connection = Me.SqlConnection1
        Me.SqlSelectCommand15.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@NUMERO_COT", System.Data.SqlDbType.NVarChar, 10, "NUMERO_COT")})
        '
        'Adap_Con_Notas
        '
        Me.Adap_Con_Notas.SelectCommand = Me.SqlSelectCommand15
        Me.Adap_Con_Notas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_NOTAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CON_NUMERO", "CON_NUMERO"), New System.Data.Common.DataColumnMapping("NOT_NOTAS", "NOT_NOTAS")})})
        '
        'SqlSelectCommand16
        '
        Me.SqlSelectCommand16.CommandText = resources.GetString("SqlSelectCommand16.CommandText")
        Me.SqlSelectCommand16.Connection = Me.SqlConnection1
        '
        'Adap_Combo_Ana
        '
        Me.Adap_Combo_Ana.SelectCommand = Me.SqlSelectCommand16
        Me.Adap_Combo_Ana.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COMBO_ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COB_CODIGO", "COB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS")})})
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'SqlSelectCommand4
        '
        Me.SqlSelectCommand4.CommandText = "SELECT COT_NUMERO, CTD_ANALISIS, CTD_CANTIDAD, CTD_UNITARIO, CTD_SUBTOTAL, CTD_DE" & _
            "SCUENTO, CTD_TOTAL, ANA_ANALISIS, CTD_MUESTRA FROM COTIZA_DETALLE"
        Me.SqlSelectCommand4.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = resources.GetString("SqlInsertCommand1.CommandText")
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CTD_ANALISIS", System.Data.SqlDbType.Float, 8, "CTD_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTD_CANTIDAD", System.Data.SqlDbType.Int, 4, "CTD_CANTIDAD"), New System.Data.SqlClient.SqlParameter("@CTD_UNITARIO", System.Data.SqlDbType.Int, 4, "CTD_UNITARIO"), New System.Data.SqlClient.SqlParameter("@CTD_SUBTOTAL", System.Data.SqlDbType.Int, 4, "CTD_SUBTOTAL"), New System.Data.SqlClient.SqlParameter("@CTD_DESCUENTO", System.Data.SqlDbType.Float, 8, "CTD_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@CTD_TOTAL", System.Data.SqlDbType.Int, 4, "CTD_TOTAL"), New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, "ANA_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTD_MUESTRA", System.Data.SqlDbType.NVarChar, 10, "CTD_MUESTRA")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CTD_ANALISIS", System.Data.SqlDbType.Float, 8, "CTD_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTD_CANTIDAD", System.Data.SqlDbType.Int, 4, "CTD_CANTIDAD"), New System.Data.SqlClient.SqlParameter("@CTD_UNITARIO", System.Data.SqlDbType.Int, 4, "CTD_UNITARIO"), New System.Data.SqlClient.SqlParameter("@CTD_SUBTOTAL", System.Data.SqlDbType.Int, 4, "CTD_SUBTOTAL"), New System.Data.SqlClient.SqlParameter("@CTD_DESCUENTO", System.Data.SqlDbType.Float, 8, "CTD_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@CTD_TOTAL", System.Data.SqlDbType.Int, 4, "CTD_TOTAL"), New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, "ANA_ANALISIS"), New System.Data.SqlClient.SqlParameter("@CTD_MUESTRA", System.Data.SqlDbType.NVarChar, 10, "CTD_MUESTRA"), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_ANALISIS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_CANTIDAD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_CANTIDAD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_MUESTRA", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_MUESTRA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_SUBTOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_SUBTOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_TOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_TOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_UNITARIO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_UNITARIO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_ANALISIS", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_CANTIDAD", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_CANTIDAD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_MUESTRA", System.Data.SqlDbType.NVarChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_MUESTRA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_SUBTOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_SUBTOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_TOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_TOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CTD_UNITARIO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CTD_UNITARIO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Detalle
        '
        Me.Adap_Detalle.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adap_Detalle.InsertCommand = Me.SqlInsertCommand1
        Me.Adap_Detalle.SelectCommand = Me.SqlSelectCommand4
        Me.Adap_Detalle.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_DETALLE", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CTD_ANALISIS", "CTD_ANALISIS"), New System.Data.Common.DataColumnMapping("CTD_CANTIDAD", "CTD_CANTIDAD"), New System.Data.Common.DataColumnMapping("CTD_UNITARIO", "CTD_UNITARIO"), New System.Data.Common.DataColumnMapping("CTD_SUBTOTAL", "CTD_SUBTOTAL"), New System.Data.Common.DataColumnMapping("CTD_DESCUENTO", "CTD_DESCUENTO"), New System.Data.Common.DataColumnMapping("CTD_TOTAL", "CTD_TOTAL"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("CTD_MUESTRA", "CTD_MUESTRA")})})
        Me.Adap_Detalle.UpdateCommand = Me.SqlUpdateCommand1
        '
        'SqlSelectCommand17
        '
        Me.SqlSelectCommand17.CommandText = "SELECT COM_COMUNA, PRO_PROVINCIA, REG_CODIGO FROM COMUNAS"
        Me.SqlSelectCommand17.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand16
        '
        Me.SqlInsertCommand16.CommandText = "INSERT INTO COMUNAS(COM_COMUNA, PRO_PROVINCIA, REG_CODIGO) VALUES (@COM_COMUNA, @" & _
            "PRO_PROVINCIA, @REG_CODIGO); SELECT COM_COMUNA, PRO_PROVINCIA, REG_CODIGO FROM C" & _
            "OMUNAS WHERE (COM_COMUNA = @COM_COMUNA)"
        Me.SqlInsertCommand16.Connection = Me.SqlConnection1
        Me.SqlInsertCommand16.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COM_COMUNA"), New System.Data.SqlClient.SqlParameter("@PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, "PRO_PROVINCIA"), New System.Data.SqlClient.SqlParameter("@REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, "REG_CODIGO")})
        '
        'SqlUpdateCommand16
        '
        Me.SqlUpdateCommand16.CommandText = resources.GetString("SqlUpdateCommand16.CommandText")
        Me.SqlUpdateCommand16.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand16.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COM_COMUNA"), New System.Data.SqlClient.SqlParameter("@PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, "PRO_PROVINCIA"), New System.Data.SqlClient.SqlParameter("@REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, "REG_CODIGO"), New System.Data.SqlClient.SqlParameter("@Original_COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COM_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PRO_PROVINCIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REG_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand16
        '
        Me.SqlDeleteCommand16.CommandText = resources.GetString("SqlDeleteCommand16.CommandText")
        Me.SqlDeleteCommand16.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand16.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COM_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COM_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_PRO_PROVINCIA", System.Data.SqlDbType.NVarChar, 25, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "PRO_PROVINCIA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_REG_CODIGO", System.Data.SqlDbType.NVarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "REG_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand16
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand16
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand17
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COMUNAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COM_COMUNA", "COM_COMUNA"), New System.Data.Common.DataColumnMapping("PRO_PROVINCIA", "PRO_PROVINCIA"), New System.Data.Common.DataColumnMapping("REG_CODIGO", "REG_CODIGO")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand16
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(16, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 16)
        Me.Label13.TabIndex = 62
        Me.Label13.Text = "Srs/Emp:"
        '
        'SqlSelectCommand18
        '
        Me.SqlSelectCommand18.CommandText = "SELECT DISTINCT PRO_EMPRESA FROM PRODUCTOR"
        Me.SqlSelectCommand18.Connection = Me.SqlConnection1
        '
        'Adap_Empresa
        '
        Me.Adap_Empresa.SelectCommand = Me.SqlSelectCommand18
        Me.Adap_Empresa.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("COT_RUT", "COT_RUT"), New System.Data.Common.DataColumnMapping("COT_NOMBRE", "COT_NOMBRE"), New System.Data.Common.DataColumnMapping("COT_EMAIL", "COT_EMAIL"), New System.Data.Common.DataColumnMapping("COT_ATENCION", "COT_ATENCION"), New System.Data.Common.DataColumnMapping("COT_DIRECCION", "COT_DIRECCION"), New System.Data.Common.DataColumnMapping("COT_COMUNA", "COT_COMUNA"), New System.Data.Common.DataColumnMapping("COT_FONO", "COT_FONO"), New System.Data.Common.DataColumnMapping("COT_FAX", "COT_FAX"), New System.Data.Common.DataColumnMapping("COT_SUBTOTAL", "COT_SUBTOTAL"), New System.Data.Common.DataColumnMapping("COT_DESCUENTO", "COT_DESCUENTO"), New System.Data.Common.DataColumnMapping("COT_NETO", "COT_NETO"), New System.Data.Common.DataColumnMapping("COT_IVA", "COT_IVA"), New System.Data.Common.DataColumnMapping("COT_TOTAL", "COT_TOTAL"), New System.Data.Common.DataColumnMapping("COT_FECHA", "COT_FECHA"), New System.Data.Common.DataColumnMapping("COT_CELULAR", "COT_CELULAR"), New System.Data.Common.DataColumnMapping("COT_CIUDAD", "COT_CIUDAD"), New System.Data.Common.DataColumnMapping("COT_EMPRESA", "COT_EMPRESA")})})
        '
        'SqlSelectCommand19
        '
        Me.SqlSelectCommand19.CommandText = resources.GetString("SqlSelectCommand19.CommandText")
        Me.SqlSelectCommand19.Connection = Me.SqlConnection1
        Me.SqlSelectCommand19.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RUT_COT", System.Data.SqlDbType.NVarChar, 13, "RUT_COT"), New System.Data.SqlClient.SqlParameter("@EMPRESA_COT", System.Data.SqlDbType.NVarChar, 50, "EMPRESA_COT")})
        '
        'Adap_Cot_Emp
        '
        Me.Adap_Cot_Emp.SelectCommand = Me.SqlSelectCommand19
        Me.Adap_Cot_Emp.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("COT_RUT", "COT_RUT"), New System.Data.Common.DataColumnMapping("COT_NOMBRE", "COT_NOMBRE"), New System.Data.Common.DataColumnMapping("COT_EMAIL", "COT_EMAIL"), New System.Data.Common.DataColumnMapping("COT_ATENCION", "COT_ATENCION"), New System.Data.Common.DataColumnMapping("COT_DIRECCION", "COT_DIRECCION"), New System.Data.Common.DataColumnMapping("COT_COMUNA", "COT_COMUNA"), New System.Data.Common.DataColumnMapping("COT_FONO", "COT_FONO"), New System.Data.Common.DataColumnMapping("COT_FAX", "COT_FAX"), New System.Data.Common.DataColumnMapping("COT_SUBTOTAL", "COT_SUBTOTAL"), New System.Data.Common.DataColumnMapping("COT_DESCUENTO", "COT_DESCUENTO"), New System.Data.Common.DataColumnMapping("COT_NETO", "COT_NETO"), New System.Data.Common.DataColumnMapping("COT_IVA", "COT_IVA"), New System.Data.Common.DataColumnMapping("COT_TOTAL", "COT_TOTAL"), New System.Data.Common.DataColumnMapping("COT_FECHA", "COT_FECHA"), New System.Data.Common.DataColumnMapping("COT_CELULAR", "COT_CELULAR"), New System.Data.Common.DataColumnMapping("COT_CIUDAD", "COT_CIUDAD"), New System.Data.Common.DataColumnMapping("COT_EMPRESA", "COT_EMPRESA"), New System.Data.Common.DataColumnMapping("COT_MUE1", "COT_MUE1"), New System.Data.Common.DataColumnMapping("COT_MUE2", "COT_MUE2"), New System.Data.Common.DataColumnMapping("COT_MUE3", "COT_MUE3"), New System.Data.Common.DataColumnMapping("COT_MUE4", "COT_MUE4")})})
        '
        'SqlSelectCommand20
        '
        Me.SqlSelectCommand20.CommandText = resources.GetString("SqlSelectCommand20.CommandText")
        Me.SqlSelectCommand20.Connection = Me.SqlConnection1
        Me.SqlSelectCommand20.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@RUT_COT", System.Data.SqlDbType.NVarChar, 13, "RUT_COT"), New System.Data.SqlClient.SqlParameter("@ATENCION_COT", System.Data.SqlDbType.NVarChar, 50, "ATENCION_COT")})
        '
        'Adap_Cot_At
        '
        Me.Adap_Cot_At.SelectCommand = Me.SqlSelectCommand20
        Me.Adap_Cot_At.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("COT_RUT", "COT_RUT"), New System.Data.Common.DataColumnMapping("COT_NOMBRE", "COT_NOMBRE"), New System.Data.Common.DataColumnMapping("COT_EMAIL", "COT_EMAIL"), New System.Data.Common.DataColumnMapping("COT_ATENCION", "COT_ATENCION"), New System.Data.Common.DataColumnMapping("COT_DIRECCION", "COT_DIRECCION"), New System.Data.Common.DataColumnMapping("COT_COMUNA", "COT_COMUNA"), New System.Data.Common.DataColumnMapping("COT_FONO", "COT_FONO"), New System.Data.Common.DataColumnMapping("COT_FAX", "COT_FAX"), New System.Data.Common.DataColumnMapping("COT_SUBTOTAL", "COT_SUBTOTAL"), New System.Data.Common.DataColumnMapping("COT_DESCUENTO", "COT_DESCUENTO"), New System.Data.Common.DataColumnMapping("COT_NETO", "COT_NETO"), New System.Data.Common.DataColumnMapping("COT_IVA", "COT_IVA"), New System.Data.Common.DataColumnMapping("COT_TOTAL", "COT_TOTAL"), New System.Data.Common.DataColumnMapping("COT_FECHA", "COT_FECHA"), New System.Data.Common.DataColumnMapping("COT_CELULAR", "COT_CELULAR"), New System.Data.Common.DataColumnMapping("COT_CIUDAD", "COT_CIUDAD"), New System.Data.Common.DataColumnMapping("COT_EMPRESA", "COT_EMPRESA"), New System.Data.Common.DataColumnMapping("COT_MUE1", "COT_MUE1"), New System.Data.Common.DataColumnMapping("COT_MUE2", "COT_MUE2"), New System.Data.Common.DataColumnMapping("COT_MUE3", "COT_MUE3"), New System.Data.Common.DataColumnMapping("COT_MUE4", "COT_MUE4")})})
        '
        'SqlSelectCommand21
        '
        Me.SqlSelectCommand21.CommandText = "SELECT PRO_RUT,PRO_NOMBRE,PRO_DIRECCION,PRO_FONO1,PRO_FAX,PRO_EMAIL1,COM_COMUNA,P" & _
            "RO_EMPRESA,PRO_ATENCION,PRO_EMAIL2 FROM PRODUCTOR WHERE (PRO_RUT LIKE @PRO_RUT)O" & _
            "R (PRO_EMPRESA LIKE @PRO_EMPRESA)"
        Me.SqlSelectCommand21.Connection = Me.SqlConnection1
        Me.SqlSelectCommand21.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRO_RUT", System.Data.SqlDbType.NVarChar, 13, "PRO_RUT"), New System.Data.SqlClient.SqlParameter("@PRO_EMPRESA", System.Data.SqlDbType.NVarChar, 50, "PRO_EMPRESA")})
        '
        'Adap_Empresa_Con
        '
        Me.Adap_Empresa_Con.SelectCommand = Me.SqlSelectCommand21
        Me.Adap_Empresa_Con.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PRODUCTOR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PRO_RUT", "PRO_RUT"), New System.Data.Common.DataColumnMapping("PRO_NOMBRE", "PRO_NOMBRE"), New System.Data.Common.DataColumnMapping("PRO_DIRECCION", "PRO_DIRECCION"), New System.Data.Common.DataColumnMapping("PRO_FONO1", "PRO_FONO1"), New System.Data.Common.DataColumnMapping("PRO_FONO2", "PRO_FONO2"), New System.Data.Common.DataColumnMapping("PRO_CELULAR", "PRO_CELULAR"), New System.Data.Common.DataColumnMapping("PRO_FAX", "PRO_FAX"), New System.Data.Common.DataColumnMapping("PRO_EMAIL1", "PRO_EMAIL1"), New System.Data.Common.DataColumnMapping("PRO_EMAIL2", "PRO_EMAIL2"), New System.Data.Common.DataColumnMapping("PRO_CASILLA", "PRO_CASILLA"), New System.Data.Common.DataColumnMapping("PRO_DESCUENTO", "PRO_DESCUENTO"), New System.Data.Common.DataColumnMapping("CIU_NOMBRE", "CIU_NOMBRE"), New System.Data.Common.DataColumnMapping("LOC_LOCALIDAD", "LOC_LOCALIDAD"), New System.Data.Common.DataColumnMapping("COM_COMUNA", "COM_COMUNA"), New System.Data.Common.DataColumnMapping("PRO_ATENCION", "PRO_ATENCION"), New System.Data.Common.DataColumnMapping("PRO_EMPRESA", "PRO_EMPRESA")})})
        '
        'SqlSelectCommand22
        '
        Me.SqlSelectCommand22.CommandText = "SELECT PRO_RUT,PRO_NOMBRE,PRO_DIRECCION,PRO_FONO1,PRO_FAX,PRO_EMAIL1,COM_COMUNA,P" & _
            "RO_EMPRESA,PRO_ATENCION,PRO_EMAIL2 FROM PRODUCTOR WHERE (PRO_RUT LIKE @PRO_RUT)O" & _
            "R (PRO_ATENCION LIKE @PRO_ATENCION)"
        Me.SqlSelectCommand22.Connection = Me.SqlConnection1
        Me.SqlSelectCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@PRO_RUT", System.Data.SqlDbType.NVarChar, 13, "PRO_RUT"), New System.Data.SqlClient.SqlParameter("@PRO_ATENCION", System.Data.SqlDbType.NVarChar, 50, "PRO_ATENCION")})
        '
        'Adap_Atencion
        '
        Me.Adap_Atencion.SelectCommand = Me.SqlSelectCommand22
        Me.Adap_Atencion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "PRODUCTOR", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("PRO_RUT", "PRO_RUT"), New System.Data.Common.DataColumnMapping("PRO_NOMBRE", "PRO_NOMBRE"), New System.Data.Common.DataColumnMapping("PRO_DIRECCION", "PRO_DIRECCION"), New System.Data.Common.DataColumnMapping("PRO_FONO1", "PRO_FONO1"), New System.Data.Common.DataColumnMapping("PRO_FONO2", "PRO_FONO2"), New System.Data.Common.DataColumnMapping("PRO_CELULAR", "PRO_CELULAR"), New System.Data.Common.DataColumnMapping("PRO_FAX", "PRO_FAX"), New System.Data.Common.DataColumnMapping("PRO_EMAIL1", "PRO_EMAIL1"), New System.Data.Common.DataColumnMapping("PRO_EMAIL2", "PRO_EMAIL2"), New System.Data.Common.DataColumnMapping("PRO_CASILLA", "PRO_CASILLA"), New System.Data.Common.DataColumnMapping("PRO_DESCUENTO", "PRO_DESCUENTO"), New System.Data.Common.DataColumnMapping("CIU_NOMBRE", "CIU_NOMBRE"), New System.Data.Common.DataColumnMapping("LOC_LOCALIDAD", "LOC_LOCALIDAD"), New System.Data.Common.DataColumnMapping("COM_COMUNA", "COM_COMUNA"), New System.Data.Common.DataColumnMapping("PRO_ATENCION", "PRO_ATENCION"), New System.Data.Common.DataColumnMapping("PRO_EMPRESA", "PRO_EMPRESA")})})
        '
        'TextBox14
        '
        Me.TextBox14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox14.Location = New System.Drawing.Point(1106, 101)
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.TextBox14.TabIndex = 80
        Me.TextBox14.Visible = False
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = resources.GetString("SqlSelectCommand2.CommandText")
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = resources.GetString("SqlInsertCommand2.CommandText")
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@COT_RUT", System.Data.SqlDbType.NVarChar, 20, "COT_RUT"), New System.Data.SqlClient.SqlParameter("@COT_NOMBRE", System.Data.SqlDbType.NVarChar, 50, "COT_NOMBRE"), New System.Data.SqlClient.SqlParameter("@COT_EMAIL", System.Data.SqlDbType.NVarChar, 50, "COT_EMAIL"), New System.Data.SqlClient.SqlParameter("@COT_ATENCION", System.Data.SqlDbType.NVarChar, 50, "COT_ATENCION"), New System.Data.SqlClient.SqlParameter("@COT_DIRECCION", System.Data.SqlDbType.NVarChar, 50, "COT_DIRECCION"), New System.Data.SqlClient.SqlParameter("@COT_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COT_COMUNA"), New System.Data.SqlClient.SqlParameter("@COT_FONO", System.Data.SqlDbType.NVarChar, 20, "COT_FONO"), New System.Data.SqlClient.SqlParameter("@COT_FAX", System.Data.SqlDbType.NVarChar, 20, "COT_FAX"), New System.Data.SqlClient.SqlParameter("@COT_SUBTOTAL", System.Data.SqlDbType.Int, 4, "COT_SUBTOTAL"), New System.Data.SqlClient.SqlParameter("@COT_DESCUENTO", System.Data.SqlDbType.Float, 8, "COT_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@COT_NETO", System.Data.SqlDbType.Int, 4, "COT_NETO"), New System.Data.SqlClient.SqlParameter("@COT_IVA", System.Data.SqlDbType.Int, 4, "COT_IVA"), New System.Data.SqlClient.SqlParameter("@COT_TOTAL", System.Data.SqlDbType.Int, 4, "COT_TOTAL"), New System.Data.SqlClient.SqlParameter("@COT_FECHA", System.Data.SqlDbType.DateTime, 8, "COT_FECHA"), New System.Data.SqlClient.SqlParameter("@COT_CELULAR", System.Data.SqlDbType.NVarChar, 20, "COT_CELULAR"), New System.Data.SqlClient.SqlParameter("@COT_CIUDAD", System.Data.SqlDbType.NVarChar, 30, "COT_CIUDAD"), New System.Data.SqlClient.SqlParameter("@COT_EMPRESA", System.Data.SqlDbType.NVarChar, 50, "COT_EMPRESA"), New System.Data.SqlClient.SqlParameter("@COT_MUE1", System.Data.SqlDbType.NVarChar, 3, "COT_MUE1"), New System.Data.SqlClient.SqlParameter("@COT_MUE2", System.Data.SqlDbType.NVarChar, 3, "COT_MUE2"), New System.Data.SqlClient.SqlParameter("@COT_MUE3", System.Data.SqlDbType.NVarChar, 3, "COT_MUE3"), New System.Data.SqlClient.SqlParameter("@COT_MUE4", System.Data.SqlDbType.NVarChar, 3, "COT_MUE4"), New System.Data.SqlClient.SqlParameter("@COT_EMAIL2", System.Data.SqlDbType.NVarChar, 50, "COT_EMAIL2")})
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = resources.GetString("SqlUpdateCommand2.CommandText")
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@COT_RUT", System.Data.SqlDbType.NVarChar, 20, "COT_RUT"), New System.Data.SqlClient.SqlParameter("@COT_NOMBRE", System.Data.SqlDbType.NVarChar, 50, "COT_NOMBRE"), New System.Data.SqlClient.SqlParameter("@COT_EMAIL", System.Data.SqlDbType.NVarChar, 50, "COT_EMAIL"), New System.Data.SqlClient.SqlParameter("@COT_ATENCION", System.Data.SqlDbType.NVarChar, 50, "COT_ATENCION"), New System.Data.SqlClient.SqlParameter("@COT_DIRECCION", System.Data.SqlDbType.NVarChar, 50, "COT_DIRECCION"), New System.Data.SqlClient.SqlParameter("@COT_COMUNA", System.Data.SqlDbType.NVarChar, 30, "COT_COMUNA"), New System.Data.SqlClient.SqlParameter("@COT_FONO", System.Data.SqlDbType.NVarChar, 20, "COT_FONO"), New System.Data.SqlClient.SqlParameter("@COT_FAX", System.Data.SqlDbType.NVarChar, 20, "COT_FAX"), New System.Data.SqlClient.SqlParameter("@COT_SUBTOTAL", System.Data.SqlDbType.Int, 4, "COT_SUBTOTAL"), New System.Data.SqlClient.SqlParameter("@COT_DESCUENTO", System.Data.SqlDbType.Float, 8, "COT_DESCUENTO"), New System.Data.SqlClient.SqlParameter("@COT_NETO", System.Data.SqlDbType.Int, 4, "COT_NETO"), New System.Data.SqlClient.SqlParameter("@COT_IVA", System.Data.SqlDbType.Int, 4, "COT_IVA"), New System.Data.SqlClient.SqlParameter("@COT_TOTAL", System.Data.SqlDbType.Int, 4, "COT_TOTAL"), New System.Data.SqlClient.SqlParameter("@COT_FECHA", System.Data.SqlDbType.DateTime, 8, "COT_FECHA"), New System.Data.SqlClient.SqlParameter("@COT_CELULAR", System.Data.SqlDbType.NVarChar, 20, "COT_CELULAR"), New System.Data.SqlClient.SqlParameter("@COT_CIUDAD", System.Data.SqlDbType.NVarChar, 30, "COT_CIUDAD"), New System.Data.SqlClient.SqlParameter("@COT_EMPRESA", System.Data.SqlDbType.NVarChar, 50, "COT_EMPRESA"), New System.Data.SqlClient.SqlParameter("@COT_MUE1", System.Data.SqlDbType.NVarChar, 3, "COT_MUE1"), New System.Data.SqlClient.SqlParameter("@COT_MUE2", System.Data.SqlDbType.NVarChar, 3, "COT_MUE2"), New System.Data.SqlClient.SqlParameter("@COT_MUE3", System.Data.SqlDbType.NVarChar, 3, "COT_MUE3"), New System.Data.SqlClient.SqlParameter("@COT_MUE4", System.Data.SqlDbType.NVarChar, 3, "COT_MUE4"), New System.Data.SqlClient.SqlParameter("@COT_EMAIL2", System.Data.SqlDbType.NVarChar, 50, "COT_EMAIL2"), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_ATENCION", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_ATENCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_CELULAR", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_CELULAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_CIUDAD", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_CIUDAD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_DIRECCION", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_DIRECCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMAIL", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMAIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMAIL2", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMAIL2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMPRESA", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMPRESA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FAX", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FAX", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FECHA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FECHA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FONO", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FONO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_IVA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_IVA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE1", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE2", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE3", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE4", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NETO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NOMBRE", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NOMBRE", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_RUT", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_RUT", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_SUBTOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_SUBTOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_TOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_TOTAL", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = resources.GetString("SqlDeleteCommand2.CommandText")
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_ATENCION", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_ATENCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_CELULAR", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_CELULAR", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_CIUDAD", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_CIUDAD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_COMUNA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_DESCUENTO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_DESCUENTO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_DIRECCION", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_DIRECCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMAIL", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMAIL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMAIL2", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMAIL2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_EMPRESA", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_EMPRESA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FAX", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FAX", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FECHA", System.Data.SqlDbType.DateTime, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FECHA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_FONO", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_FONO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_IVA", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_IVA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE1", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE2", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE3", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_MUE4", System.Data.SqlDbType.NVarChar, 3, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_MUE4", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NETO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NOMBRE", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NOMBRE", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_RUT", System.Data.SqlDbType.NVarChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_RUT", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_SUBTOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_SUBTOTAL", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_TOTAL", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_TOTAL", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Cotizacion
        '
        Me.Adap_Cotizacion.DeleteCommand = Me.SqlDeleteCommand2
        Me.Adap_Cotizacion.InsertCommand = Me.SqlInsertCommand2
        Me.Adap_Cotizacion.SelectCommand = Me.SqlSelectCommand2
        Me.Adap_Cotizacion.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZACION", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("COT_RUT", "COT_RUT"), New System.Data.Common.DataColumnMapping("COT_NOMBRE", "COT_NOMBRE"), New System.Data.Common.DataColumnMapping("COT_EMAIL", "COT_EMAIL"), New System.Data.Common.DataColumnMapping("COT_ATENCION", "COT_ATENCION"), New System.Data.Common.DataColumnMapping("COT_DIRECCION", "COT_DIRECCION"), New System.Data.Common.DataColumnMapping("COT_COMUNA", "COT_COMUNA"), New System.Data.Common.DataColumnMapping("COT_FONO", "COT_FONO"), New System.Data.Common.DataColumnMapping("COT_FAX", "COT_FAX"), New System.Data.Common.DataColumnMapping("COT_SUBTOTAL", "COT_SUBTOTAL"), New System.Data.Common.DataColumnMapping("COT_DESCUENTO", "COT_DESCUENTO"), New System.Data.Common.DataColumnMapping("COT_NETO", "COT_NETO"), New System.Data.Common.DataColumnMapping("COT_IVA", "COT_IVA"), New System.Data.Common.DataColumnMapping("COT_TOTAL", "COT_TOTAL"), New System.Data.Common.DataColumnMapping("COT_FECHA", "COT_FECHA"), New System.Data.Common.DataColumnMapping("COT_CELULAR", "COT_CELULAR"), New System.Data.Common.DataColumnMapping("COT_CIUDAD", "COT_CIUDAD"), New System.Data.Common.DataColumnMapping("COT_EMPRESA", "COT_EMPRESA"), New System.Data.Common.DataColumnMapping("COT_MUE1", "COT_MUE1"), New System.Data.Common.DataColumnMapping("COT_MUE2", "COT_MUE2"), New System.Data.Common.DataColumnMapping("COT_MUE3", "COT_MUE3"), New System.Data.Common.DataColumnMapping("COT_MUE4", "COT_MUE4"), New System.Data.Common.DataColumnMapping("COT_EMAIL2", "COT_EMAIL2")})})
        Me.Adap_Cotizacion.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlSelectCommand8
        '
        Me.SqlSelectCommand8.CommandText = "SELECT COT_NUMERO, CON_NUMERO, NOT_NOTAS, NOTA_COT_TIPO FROM COTIZA_NOTAS"
        Me.SqlSelectCommand8.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand5
        '
        Me.SqlInsertCommand5.CommandText = resources.GetString("SqlInsertCommand5.CommandText")
        Me.SqlInsertCommand5.Connection = Me.SqlConnection1
        Me.SqlInsertCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CON_NUMERO", System.Data.SqlDbType.Int, 4, "CON_NUMERO"), New System.Data.SqlClient.SqlParameter("@NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, "NOT_NOTAS"), New System.Data.SqlClient.SqlParameter("@NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, "NOTA_COT_TIPO")})
        '
        'SqlUpdateCommand5
        '
        Me.SqlUpdateCommand5.CommandText = resources.GetString("SqlUpdateCommand5.CommandText")
        Me.SqlUpdateCommand5.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COT_NUMERO", System.Data.SqlDbType.Float, 8, "COT_NUMERO"), New System.Data.SqlClient.SqlParameter("@CON_NUMERO", System.Data.SqlDbType.Int, 4, "CON_NUMERO"), New System.Data.SqlClient.SqlParameter("@NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, "NOT_NOTAS"), New System.Data.SqlClient.SqlParameter("@NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, "NOTA_COT_TIPO"), New System.Data.SqlClient.SqlParameter("@Original_CON_NUMERO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CON_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_TIPO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOT_NOTAS", System.Data.SqlDbType.NVarChar, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOT_NOTAS", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand5
        '
        Me.SqlDeleteCommand5.CommandText = resources.GetString("SqlDeleteCommand5.CommandText")
        Me.SqlDeleteCommand5.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand5.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_CON_NUMERO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CON_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COT_NUMERO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COT_NUMERO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOTA_COT_TIPO", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOTA_COT_TIPO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_NOT_NOTAS", System.Data.SqlDbType.NVarChar, 110, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "NOT_NOTAS", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Cotiza_Notas
        '
        Me.Adap_Cotiza_Notas.DeleteCommand = Me.SqlDeleteCommand5
        Me.Adap_Cotiza_Notas.InsertCommand = Me.SqlInsertCommand5
        Me.Adap_Cotiza_Notas.SelectCommand = Me.SqlSelectCommand8
        Me.Adap_Cotiza_Notas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_NOTAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COT_NUMERO", "COT_NUMERO"), New System.Data.Common.DataColumnMapping("CON_NUMERO", "CON_NUMERO"), New System.Data.Common.DataColumnMapping("NOT_NOTAS", "NOT_NOTAS"), New System.Data.Common.DataColumnMapping("NOTA_COT_TIPO", "NOTA_COT_TIPO")})})
        Me.Adap_Cotiza_Notas.UpdateCommand = Me.SqlUpdateCommand5
        '
        'SqlSelectCommand23
        '
        Me.SqlSelectCommand23.CommandText = "SELECT CUL_CODIGO, CUL_DESCRIPCION FROM CULTIVO"
        Me.SqlSelectCommand23.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand22
        '
        Me.SqlInsertCommand22.CommandText = "INSERT INTO CULTIVO(CUL_CODIGO, CUL_DESCRIPCION) VALUES (@CUL_CODIGO, @CUL_DESCRI" & _
            "PCION); SELECT CUL_CODIGO, CUL_DESCRIPCION FROM CULTIVO"
        Me.SqlInsertCommand22.Connection = Me.SqlConnection1
        Me.SqlInsertCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CUL_CODIGO", System.Data.SqlDbType.NVarChar, 3, "CUL_CODIGO"), New System.Data.SqlClient.SqlParameter("@CUL_DESCRIPCION", System.Data.SqlDbType.NVarChar, 50, "CUL_DESCRIPCION")})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand22
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand23
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "CULTIVO", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CUL_CODIGO", "CUL_CODIGO"), New System.Data.Common.DataColumnMapping("CUL_DESCRIPCION", "CUL_DESCRIPCION")})})
        '
        'SqlConnection2
        '
        Me.SqlConnection2.FireInfoMessageEventOnUserErrors = False
        '
        'Button21
        '
        Me.Button21.BackColor = System.Drawing.Color.Transparent
        Me.Button21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button21.Image = Global.LabSys.My.Resources.Resources.table_relationship
        Me.Button21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button21.Location = New System.Drawing.Point(16, 152)
        Me.Button21.Name = "Button21"
        Me.Button21.Size = New System.Drawing.Size(64, 24)
        Me.Button21.TabIndex = 86
        Me.Button21.Text = "Unir "
        Me.Button21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button21.UseVisualStyleBackColor = False
        '
        'TextBox22
        '
        Me.TextBox22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox22.Location = New System.Drawing.Point(110, 48)
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Size = New System.Drawing.Size(192, 20)
        Me.TextBox22.TabIndex = 73
        '
        'TextBox23
        '
        Me.TextBox23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox23.Location = New System.Drawing.Point(423, 47)
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Size = New System.Drawing.Size(203, 20)
        Me.TextBox23.TabIndex = 74
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RadioButton2)
        Me.GroupBox4.Controls.Add(Me.RadioButton1)
        Me.GroupBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(362, 5)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(157, 32)
        Me.GroupBox4.TabIndex = 95
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = " Base"
        '
        'RadioButton2
        '
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(86, 12)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "Agrolab"
        '
        'RadioButton1
        '
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(2, 12)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton1.Size = New System.Drawing.Size(78, 16)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Cotización"
        '
        'SqlSelectCommand26
        '
        Me.SqlSelectCommand26.CommandText = resources.GetString("SqlSelectCommand26.CommandText")
        Me.SqlSelectCommand26.Connection = Me.SqlConnection1
        Me.SqlSelectCommand26.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CODIGO_COB", System.Data.SqlDbType.NVarChar, 13, "CODIGO_COB")})
        '
        'Adap_Man_Com
        '
        Me.Adap_Man_Com.SelectCommand = Me.SqlSelectCommand26
        Me.Adap_Man_Com.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COMBO_ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COB_CODIGO", "COB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("IMP_COTIZA", "IMP_COTIZA")})})
        '
        'SqlSelectCommand27
        '
        Me.SqlSelectCommand27.CommandText = resources.GetString("SqlSelectCommand27.CommandText")
        Me.SqlSelectCommand27.Connection = Me.SqlConnection1
        '
        'Adap_Man_Ann
        '
        Me.Adap_Man_Ann.SelectCommand = Me.SqlSelectCommand27
        Me.Adap_Man_Ann.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_NETO", "ANA_NETO"), New System.Data.Common.DataColumnMapping("ANA_NIVEL_PRECIO", "ANA_NIVEL_PRECIO")})})
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(6, 10)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(64, 16)
        Me.Label30.TabIndex = 84
        Me.Label30.Text = "Cotización"
        '
        'SqlSelectCommand28
        '
        Me.SqlSelectCommand28.CommandText = "SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU_CODIGO FROM SUBMUESTRA"
        Me.SqlSelectCommand28.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand28
        '
        Me.SqlInsertCommand28.CommandText = resources.GetString("SqlInsertCommand28.CommandText")
        Me.SqlInsertCommand28.Connection = Me.SqlConnection1
        Me.SqlInsertCommand28.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"), New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 60, "SUB_DESCRIPCION"), New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO")})
        '
        'SqlUpdateCommand27
        '
        Me.SqlUpdateCommand27.CommandText = resources.GetString("SqlUpdateCommand27.CommandText")
        Me.SqlUpdateCommand27.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand27.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"), New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 60, "SUB_DESCRIPCION"), New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"), New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand27
        '
        Me.SqlDeleteCommand27.CommandText = resources.GetString("SqlDeleteCommand27.CommandText")
        Me.SqlDeleteCommand27.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand27.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 60, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Submuestra
        '
        Me.Adap_Submuestra.DeleteCommand = Me.SqlDeleteCommand27
        Me.Adap_Submuestra.InsertCommand = Me.SqlInsertCommand28
        Me.Adap_Submuestra.SelectCommand = Me.SqlSelectCommand28
        Me.Adap_Submuestra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SUBMUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_DESCRIPCION", "SUB_DESCRIPCION"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO")})})
        Me.Adap_Submuestra.UpdateCommand = Me.SqlUpdateCommand27
        '
        'SqlSelectCommand24
        '
        Me.SqlSelectCommand24.CommandText = "SELECT TMU_CODIGO, TMU_MUESTRA FROM MUESTRA"
        Me.SqlSelectCommand24.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand23
        '
        Me.SqlInsertCommand23.CommandText = "INSERT INTO MUESTRA(TMU_CODIGO, TMU_MUESTRA) VALUES (@TMU_CODIGO, @TMU_MUESTRA); " & _
            "SELECT TMU_CODIGO, TMU_MUESTRA FROM MUESTRA WHERE (TMU_CODIGO = @TMU_CODIGO)"
        Me.SqlInsertCommand23.Connection = Me.SqlConnection1
        Me.SqlInsertCommand23.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Float, 8, "TMU_CODIGO"), New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA")})
        '
        'SqlUpdateCommand22
        '
        Me.SqlUpdateCommand22.CommandText = resources.GetString("SqlUpdateCommand22.CommandText")
        Me.SqlUpdateCommand22.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Float, 8, "TMU_CODIGO"), New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA"), New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand22
        '
        Me.SqlDeleteCommand22.CommandText = "DELETE FROM MUESTRA WHERE (TMU_CODIGO = @Original_TMU_CODIGO) AND (TMU_MUESTRA = " & _
            "@Original_TMU_MUESTRA OR @Original_TMU_MUESTRA IS NULL AND TMU_MUESTRA IS NULL)"
        Me.SqlDeleteCommand22.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand22.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Muestra
        '
        Me.Adap_Muestra.DeleteCommand = Me.SqlDeleteCommand22
        Me.Adap_Muestra.InsertCommand = Me.SqlInsertCommand23
        Me.Adap_Muestra.SelectCommand = Me.SqlSelectCommand24
        Me.Adap_Muestra.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("TMU_MUESTRA", "TMU_MUESTRA")})})
        Me.Adap_Muestra.UpdateCommand = Me.SqlUpdateCommand22
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TextBox6)
        Me.GroupBox8.Controls.Add(Me.Label139)
        Me.GroupBox8.Controls.Add(Me.TextBox4)
        Me.GroupBox8.Controls.Add(Me.Label138)
        Me.GroupBox8.Controls.Add(Me.Label69)
        Me.GroupBox8.Controls.Add(Me.TextBox37)
        Me.GroupBox8.Controls.Add(Me.TextBox36)
        Me.GroupBox8.Controls.Add(Me.Label39)
        Me.GroupBox8.Controls.Add(Me.Label38)
        Me.GroupBox8.Controls.Add(Me.Button35)
        Me.GroupBox8.Controls.Add(Me.TextBox35)
        Me.GroupBox8.Controls.Add(Me.Label37)
        Me.GroupBox8.Controls.Add(Me.Button34)
        Me.GroupBox8.Location = New System.Drawing.Point(107, 35)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(880, 152)
        Me.GroupBox8.TabIndex = 11
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Visible = False
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(720, 48)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(48, 64)
        Me.TextBox6.TabIndex = 18
        '
        'Label139
        '
        Me.Label139.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label139.Location = New System.Drawing.Point(720, 32)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(48, 16)
        Me.Label139.TabIndex = 17
        Me.Label139.Text = "$ c/dcto"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(672, 48)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(48, 64)
        Me.TextBox4.TabIndex = 16
        '
        'Label138
        '
        Me.Label138.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label138.Location = New System.Drawing.Point(672, 32)
        Me.Label138.Name = "Label138"
        Me.Label138.Size = New System.Drawing.Size(48, 16)
        Me.Label138.TabIndex = 15
        Me.Label138.Text = "% dcto"
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label69.Location = New System.Drawing.Point(-1, 2)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(862, 16)
        Me.Label69.TabIndex = 14
        Me.Label69.Text = "Jocker Análisis"
        '
        'TextBox37
        '
        Me.TextBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox37.Location = New System.Drawing.Point(624, 48)
        Me.TextBox37.Multiline = True
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(48, 64)
        Me.TextBox37.TabIndex = 7
        '
        'TextBox36
        '
        Me.TextBox36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox36.Location = New System.Drawing.Point(152, 48)
        Me.TextBox36.Multiline = True
        Me.TextBox36.Name = "TextBox36"
        Me.TextBox36.Size = New System.Drawing.Size(472, 64)
        Me.TextBox36.TabIndex = 6
        '
        'Label39
        '
        Me.Label39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label39.Location = New System.Drawing.Point(624, 32)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(48, 16)
        Me.Label39.TabIndex = 5
        Me.Label39.Text = "$ Valor"
        '
        'Label38
        '
        Me.Label38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label38.Location = New System.Drawing.Point(152, 32)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(472, 16)
        Me.Label38.TabIndex = 4
        Me.Label38.Text = "Descripción"
        '
        'Button35
        '
        Me.Button35.BackColor = System.Drawing.Color.Transparent
        Me.Button35.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button35.Location = New System.Drawing.Point(859, 1)
        Me.Button35.Name = "Button35"
        Me.Button35.Size = New System.Drawing.Size(22, 18)
        Me.Button35.TabIndex = 3
        Me.Button35.Text = "X"
        Me.Button35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button35.UseVisualStyleBackColor = False
        '
        'TextBox35
        '
        Me.TextBox35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox35.Location = New System.Drawing.Point(112, 48)
        Me.TextBox35.Multiline = True
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.Size = New System.Drawing.Size(40, 64)
        Me.TextBox35.TabIndex = 2
        '
        'Label37
        '
        Me.Label37.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label37.Location = New System.Drawing.Point(112, 32)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(40, 16)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "Cod"
        '
        'Button34
        '
        Me.Button34.BackColor = System.Drawing.Color.Transparent
        Me.Button34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button34.Location = New System.Drawing.Point(408, 120)
        Me.Button34.Name = "Button34"
        Me.Button34.Size = New System.Drawing.Size(75, 23)
        Me.Button34.TabIndex = 0
        Me.Button34.Text = "Carga"
        Me.Button34.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand25
        '
        Me.SqlSelectCommand25.CommandText = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PREC" & _
            "IO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET, TIPO_COD FROM ANALISIS order by ANA_" & _
            "CODIGO"
        Me.SqlSelectCommand25.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand24
        '
        Me.SqlInsertCommand24.CommandText = resources.GetString("SqlInsertCommand24.CommandText")
        Me.SqlInsertCommand24.Connection = Me.SqlConnection1
        Me.SqlInsertCommand24.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"), New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, "ANA_ANALISIS"), New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"), New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"), New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"), New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"), New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"), New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"), New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"), New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"), New System.Data.SqlClient.SqlParameter("@TIPO_COD", System.Data.SqlDbType.NVarChar, 5, "TIPO_COD")})
        '
        'SqlUpdateCommand23
        '
        Me.SqlUpdateCommand23.CommandText = resources.GetString("SqlUpdateCommand23.CommandText")
        Me.SqlUpdateCommand23.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand23.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"), New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 16, "ANA_ANALISIS"), New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"), New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"), New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"), New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"), New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"), New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"), New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"), New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"), New System.Data.SqlClient.SqlParameter("@TIPO_COD", System.Data.SqlDbType.NVarChar, 5, "TIPO_COD"), New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 16, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TIPO_COD", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIPO_COD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand23
        '
        Me.SqlDeleteCommand23.CommandText = resources.GetString("SqlDeleteCommand23.CommandText")
        Me.SqlDeleteCommand23.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand23.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TIPO_COD", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIPO_COD", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Man_Ana
        '
        Me.Adap_Man_Ana.DeleteCommand = Me.SqlDeleteCommand23
        Me.Adap_Man_Ana.InsertCommand = Me.SqlInsertCommand24
        Me.Adap_Man_Ana.SelectCommand = Me.SqlSelectCommand25
        Me.Adap_Man_Ana.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_NETO", "ANA_NETO"), New System.Data.Common.DataColumnMapping("ANA_NIVEL_PRECIO", "ANA_NIVEL_PRECIO"), New System.Data.Common.DataColumnMapping("CLIENTE1", "CLIENTE1"), New System.Data.Common.DataColumnMapping("CLIENTE2", "CLIENTE2"), New System.Data.Common.DataColumnMapping("CLIENTE3", "CLIENTE3"), New System.Data.Common.DataColumnMapping("CLIENTET", "CLIENTET"), New System.Data.Common.DataColumnMapping("TIPO_COD", "TIPO_COD")})})
        Me.Adap_Man_Ana.UpdateCommand = Me.SqlUpdateCommand23
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.Transparent
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Image = Global.LabSys.My.Resources.Resources.page_white
        Me.Button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button10.Location = New System.Drawing.Point(8, 120)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(82, 26)
        Me.Button10.TabIndex = 112
        Me.Button10.Text = "Nueva"
        Me.Button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button10, "Genera una nueva cotización (nuevo Nº Cot.)")
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button40
        '
        Me.Button40.BackColor = System.Drawing.Color.Transparent
        Me.Button40.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button40.Location = New System.Drawing.Point(8, 80)
        Me.Button40.Name = "Button40"
        Me.Button40.Size = New System.Drawing.Size(82, 26)
        Me.Button40.TabIndex = 85
        Me.Button40.Text = "Limpia detalle"
        Me.ToolTip1.SetToolTip(Me.Button40, "Solo limpia los análisis permitiendo cotizar al mismo cliente")
        Me.Button40.UseVisualStyleBackColor = False
        '
        'SqlSelectCommand6
        '
        Me.SqlSelectCommand6.CommandText = "SELECT COD_COMUNA, COD_CIUDAD FROM COTIZA_COMUNAS"
        Me.SqlSelectCommand6.Connection = Me.SqlConnection1
        '
        'SqlInsertCommand30
        '
        Me.SqlInsertCommand30.CommandText = "INSERT INTO COTIZA_COMUNAS(COD_COMUNA, COD_CIUDAD) VALUES (@COD_COMUNA, @COD_CIUD" & _
            "AD); SELECT COD_COMUNA, COD_CIUDAD FROM COTIZA_COMUNAS WHERE (COD_COMUNA = @COD_" & _
            "COMUNA)"
        Me.SqlInsertCommand30.Connection = Me.SqlConnection1
        Me.SqlInsertCommand30.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COD_COMUNA", System.Data.SqlDbType.NVarChar, 50, "COD_COMUNA"), New System.Data.SqlClient.SqlParameter("@COD_CIUDAD", System.Data.SqlDbType.NVarChar, 50, "COD_CIUDAD")})
        '
        'SqlUpdateCommand29
        '
        Me.SqlUpdateCommand29.CommandText = resources.GetString("SqlUpdateCommand29.CommandText")
        Me.SqlUpdateCommand29.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand29.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COD_COMUNA", System.Data.SqlDbType.NVarChar, 50, "COD_COMUNA"), New System.Data.SqlClient.SqlParameter("@COD_CIUDAD", System.Data.SqlDbType.NVarChar, 50, "COD_CIUDAD"), New System.Data.SqlClient.SqlParameter("@Original_COD_COMUNA", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COD_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COD_CIUDAD", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COD_CIUDAD", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand29
        '
        Me.SqlDeleteCommand29.CommandText = "DELETE FROM COTIZA_COMUNAS WHERE (COD_COMUNA = @Original_COD_COMUNA) AND (COD_CIU" & _
            "DAD = @Original_COD_CIUDAD OR @Original_COD_CIUDAD IS NULL AND COD_CIUDAD IS NUL" & _
            "L)"
        Me.SqlDeleteCommand29.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand29.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_COD_COMUNA", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COD_COMUNA", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_COD_CIUDAD", System.Data.SqlDbType.NVarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "COD_CIUDAD", System.Data.DataRowVersion.Original, Nothing)})
        '
        'Adap_Comunas
        '
        Me.Adap_Comunas.DeleteCommand = Me.SqlDeleteCommand29
        Me.Adap_Comunas.InsertCommand = Me.SqlInsertCommand30
        Me.Adap_Comunas.SelectCommand = Me.SqlSelectCommand6
        Me.Adap_Comunas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_COMUNAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_COMUNA", "COD_COMUNA"), New System.Data.Common.DataColumnMapping("COD_CIUDAD", "COD_CIUDAD")})})
        Me.Adap_Comunas.UpdateCommand = Me.SqlUpdateCommand29
        '
        'SqlSelectCommand7
        '
        Me.SqlSelectCommand7.CommandText = "SELECT COD_COMUNA, COD_CIUDAD FROM COTIZA_COMUNAS WHERE COD_CIUDAD LIKE @CIUDAD_C" & _
            "OD ORDER BY COD_CIUDAD"
        Me.SqlSelectCommand7.Connection = Me.SqlConnection1
        Me.SqlSelectCommand7.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@CIUDAD_COD", System.Data.SqlDbType.NVarChar, 50, "CIUDAD_COD")})
        '
        'Adap_Comunas1
        '
        Me.Adap_Comunas1.SelectCommand = Me.SqlSelectCommand7
        Me.Adap_Comunas1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_COMUNAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_COMUNA", "COD_COMUNA"), New System.Data.Common.DataColumnMapping("COD_CIUDAD", "COD_CIUDAD")})})
        '
        'TextBox38
        '
        Me.TextBox38.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox38.Location = New System.Drawing.Point(1106, 74)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(100, 20)
        Me.TextBox38.TabIndex = 100
        '
        'TextBox39
        '
        Me.TextBox39.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox39.Location = New System.Drawing.Point(964, 73)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(136, 20)
        Me.TextBox39.TabIndex = 103
        '
        'SqlSelectCommand29
        '
        Me.SqlSelectCommand29.CommandText = "SELECT COD_COMUNA, COD_CIUDAD FROM COTIZA_COMUNAS WHERE COD_COMUNA LIKE @COMUNA_C" & _
            "OD"
        Me.SqlSelectCommand29.Connection = Me.SqlConnection1
        Me.SqlSelectCommand29.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@COMUNA_COD", System.Data.SqlDbType.NVarChar, 50, "COMUNA_COD")})
        '
        'Adap_Comunas2
        '
        Me.Adap_Comunas2.SelectCommand = Me.SqlSelectCommand29
        Me.Adap_Comunas2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "COTIZA_COMUNAS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("COD_COMUNA", "COD_COMUNA"), New System.Data.Common.DataColumnMapping("COD_CIUDAD", "COD_CIUDAD")})})
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label105)
        Me.GroupBox9.Controls.Add(Me.Button45)
        Me.GroupBox9.Controls.Add(Me.Button44)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.TextBox40)
        Me.GroupBox9.Location = New System.Drawing.Point(93, 550)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(832, 121)
        Me.GroupBox9.TabIndex = 106
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Visible = False
        '
        'Label105
        '
        Me.Label105.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label105.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label105.Location = New System.Drawing.Point(0, 1)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(811, 17)
        Me.Label105.TabIndex = 15
        Me.Label105.Text = "Busca Análisis"
        '
        'Button45
        '
        Me.Button45.BackColor = System.Drawing.Color.Transparent
        Me.Button45.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button45.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button45.Location = New System.Drawing.Point(592, 40)
        Me.Button45.Name = "Button45"
        Me.Button45.Size = New System.Drawing.Size(111, 23)
        Me.Button45.TabIndex = 3
        Me.Button45.Text = "Buscar Siguiente"
        Me.Button45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button45.UseVisualStyleBackColor = False
        '
        'Button44
        '
        Me.Button44.BackColor = System.Drawing.Color.Transparent
        Me.Button44.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button44.Location = New System.Drawing.Point(811, -1)
        Me.Button44.Name = "Button44"
        Me.Button44.Size = New System.Drawing.Size(22, 18)
        Me.Button44.TabIndex = 2
        Me.Button44.Text = "X"
        Me.Button44.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button44.UseVisualStyleBackColor = False
        '
        'Label40
        '
        Me.Label40.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label40.Location = New System.Drawing.Point(24, 42)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(40, 16)
        Me.Label40.TabIndex = 1
        Me.Label40.Text = "Buscar"
        '
        'TextBox40
        '
        Me.TextBox40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox40.Location = New System.Drawing.Point(64, 40)
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Size = New System.Drawing.Size(520, 20)
        Me.TextBox40.TabIndex = 0
        '
        'SqlConnection3
        '
        Me.SqlConnection3.ConnectionString = "workstation id=SECREAGRO;packet size=4096;user id=sa;data source=AGROSERV;persist" & _
            " security info=True;initial catalog=BASE_RES;password=sa"
        Me.SqlConnection3.FireInfoMessageEventOnUserErrors = False
        '
        'GrbListado
        '
        Me.GrbListado.Controls.Add(Me.Button16)
        Me.GrbListado.Controls.Add(Me.BTGrabaListado)
        Me.GrbListado.Location = New System.Drawing.Point(0, 616)
        Me.GrbListado.Name = "GrbListado"
        Me.GrbListado.Size = New System.Drawing.Size(962, 36)
        Me.GrbListado.TabIndex = 115
        Me.GrbListado.TabStop = False
        Me.GrbListado.Visible = False
        '
        'Button16
        '
        Me.Button16.BackColor = System.Drawing.Color.Transparent
        Me.Button16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button16.Location = New System.Drawing.Point(8, 8)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(22, 22)
        Me.Button16.TabIndex = 118
        Me.Button16.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button16, "Ayuda")
        Me.Button16.UseVisualStyleBackColor = False
        '
        'BTGrabaListado
        '
        Me.BTGrabaListado.BackColor = System.Drawing.Color.Transparent
        Me.BTGrabaListado.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTGrabaListado.Location = New System.Drawing.Point(424, 8)
        Me.BTGrabaListado.Name = "BTGrabaListado"
        Me.BTGrabaListado.Size = New System.Drawing.Size(104, 24)
        Me.BTGrabaListado.TabIndex = 86
        Me.BTGrabaListado.Text = "Graba Listado"
        Me.BTGrabaListado.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(40, 784)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(22, 26)
        Me.Button2.TabIndex = 128
        Me.Button2.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button2, "Ayuda")
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button17
        '
        Me.Button17.BackColor = System.Drawing.Color.Transparent
        Me.Button17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button17.Location = New System.Drawing.Point(8, 8)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(22, 22)
        Me.Button17.TabIndex = 118
        Me.Button17.Text = "?"
        Me.ToolTip1.SetToolTip(Me.Button17, "Ayuda")
        Me.Button17.UseVisualStyleBackColor = False
        '
        'Button51
        '
        Me.Button51.Image = CType(resources.GetObject("Button51.Image"), System.Drawing.Image)
        Me.Button51.Location = New System.Drawing.Point(312, 464)
        Me.Button51.Name = "Button51"
        Me.Button51.Size = New System.Drawing.Size(16, 18)
        Me.Button51.TabIndex = 164
        Me.ToolTip1.SetToolTip(Me.Button51, "Archivos de cotizaciones en xls")
        '
        'Button53
        '
        Me.Button53.BackColor = System.Drawing.Color.Transparent
        Me.Button53.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button53.Location = New System.Drawing.Point(75, 368)
        Me.Button53.Name = "Button53"
        Me.Button53.Size = New System.Drawing.Size(21, 18)
        Me.Button53.TabIndex = 154
        Me.ToolTip1.SetToolTip(Me.Button53, "Busca texto en descripción de análisis")
        Me.Button53.UseVisualStyleBackColor = False
        '
        'Button54
        '
        Me.Button54.Image = CType(resources.GetObject("Button54.Image"), System.Drawing.Image)
        Me.Button54.Location = New System.Drawing.Point(616, 336)
        Me.Button54.Name = "Button54"
        Me.Button54.Size = New System.Drawing.Size(16, 18)
        Me.Button54.TabIndex = 150
        Me.ToolTip1.SetToolTip(Me.Button54, "Busca texto en descripción de análisis")
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(6, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(82, 26)
        Me.Button3.TabIndex = 41
        Me.Button3.Text = "Imprime"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToolTip1.SetToolTip(Me.Button3, "Graba y genera cotización en xls.")
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button48
        '
        Me.Button48.BackColor = System.Drawing.Color.Transparent
        Me.Button48.Image = Global.LabSys.My.Resources.Resources.folder_explore
        Me.Button48.Location = New System.Drawing.Point(39, 629)
        Me.Button48.Name = "Button48"
        Me.Button48.Size = New System.Drawing.Size(24, 24)
        Me.Button48.TabIndex = 126
        Me.ToolTip1.SetToolTip(Me.Button48, "Archivos de cotizaciones en xls")
        Me.Button48.UseVisualStyleBackColor = False
        '
        'Button49
        '
        Me.Button49.BackColor = System.Drawing.Color.Transparent
        Me.Button49.Image = Global.LabSys.My.Resources.Resources.Microsoft_Office_Outlook__1_
        Me.Button49.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Button49.Location = New System.Drawing.Point(37, 550)
        Me.Button49.Name = "Button49"
        Me.Button49.Size = New System.Drawing.Size(33, 32)
        Me.Button49.TabIndex = 125
        Me.Button49.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.Button49, "Envía email")
        Me.Button49.UseVisualStyleBackColor = False
        '
        'Button46
        '
        Me.Button46.BackColor = System.Drawing.Color.Transparent
        Me.Button46.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button46.Location = New System.Drawing.Point(40, 736)
        Me.Button46.Name = "Button46"
        Me.Button46.Size = New System.Drawing.Size(22, 26)
        Me.Button46.TabIndex = 107
        Me.ToolTip1.SetToolTip(Me.Button46, "Busca texto en descripción de análisis")
        Me.Button46.UseVisualStyleBackColor = False
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.Label145)
        Me.GroupBox22.Controls.Add(Me.Label144)
        Me.GroupBox22.Controls.Add(Me.Label143)
        Me.GroupBox22.Controls.Add(Me.Label140)
        Me.GroupBox22.Controls.Add(Me.Label137)
        Me.GroupBox22.Controls.Add(Me.Label118)
        Me.GroupBox22.Controls.Add(Me.Label119)
        Me.GroupBox22.Controls.Add(Me.Label120)
        Me.GroupBox22.Controls.Add(Me.Label121)
        Me.GroupBox22.Controls.Add(Me.Label33)
        Me.GroupBox22.Controls.Add(Me.Label73)
        Me.GroupBox22.Controls.Add(Me.Label107)
        Me.GroupBox22.Controls.Add(Me.Label3)
        Me.GroupBox22.Controls.Add(Me.Button51)
        Me.GroupBox22.Controls.Add(Me.Label15)
        Me.GroupBox22.Controls.Add(Me.Label17)
        Me.GroupBox22.Controls.Add(Me.Label18)
        Me.GroupBox22.Controls.Add(Me.Label19)
        Me.GroupBox22.Controls.Add(Me.Label22)
        Me.GroupBox22.Controls.Add(Me.Label23)
        Me.GroupBox22.Controls.Add(Me.Label24)
        Me.GroupBox22.Controls.Add(Me.Label25)
        Me.GroupBox22.Controls.Add(Me.Label26)
        Me.GroupBox22.Controls.Add(Me.Button53)
        Me.GroupBox22.Controls.Add(Me.Label28)
        Me.GroupBox22.Controls.Add(Me.Label29)
        Me.GroupBox22.Controls.Add(Me.Label65)
        Me.GroupBox22.Controls.Add(Me.Button54)
        Me.GroupBox22.Controls.Add(Me.Label66)
        Me.GroupBox22.Controls.Add(Me.Label67)
        Me.GroupBox22.Controls.Add(Me.Label68)
        Me.GroupBox22.Controls.Add(Me.Label96)
        Me.GroupBox22.Controls.Add(Me.Label97)
        Me.GroupBox22.Controls.Add(Me.Label98)
        Me.GroupBox22.Controls.Add(Me.Label99)
        Me.GroupBox22.Controls.Add(Me.Label100)
        Me.GroupBox22.Controls.Add(Me.Label101)
        Me.GroupBox22.Controls.Add(Me.Label116)
        Me.GroupBox22.Controls.Add(Me.Label122)
        Me.GroupBox22.Controls.Add(Me.Label123)
        Me.GroupBox22.Controls.Add(Me.Label124)
        Me.GroupBox22.Controls.Add(Me.Label125)
        Me.GroupBox22.Controls.Add(Me.Label126)
        Me.GroupBox22.Controls.Add(Me.Label127)
        Me.GroupBox22.Controls.Add(Me.Label128)
        Me.GroupBox22.Controls.Add(Me.Label129)
        Me.GroupBox22.Controls.Add(Me.Label130)
        Me.GroupBox22.Controls.Add(Me.Label131)
        Me.GroupBox22.Controls.Add(Me.Label132)
        Me.GroupBox22.Controls.Add(Me.Label31)
        Me.GroupBox22.Controls.Add(Me.Button4)
        Me.GroupBox22.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox22.Location = New System.Drawing.Point(99, 141)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(840, 698)
        Me.GroupBox22.TabIndex = 118
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Visible = False
        '
        'Label145
        '
        Me.Label145.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label145.Location = New System.Drawing.Point(8, 256)
        Me.Label145.Name = "Label145"
        Me.Label145.Size = New System.Drawing.Size(712, 16)
        Me.Label145.TabIndex = 178
        Me.Label145.Text = "         en el formato el Neto,IVA y total de lo cotizado"
        '
        'Label144
        '
        Me.Label144.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.Location = New System.Drawing.Point(8, 240)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(720, 16)
        Me.Label144.TabIndex = 177
        Me.Label144.Text = "         Crea cotización con una cantidad determinada de unidades (Kits, producto" & _
            "s,muestras) para un mismo código, desplegando"
        '
        'Label143
        '
        Me.Label143.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label143.Location = New System.Drawing.Point(8, 576)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(712, 16)
        Me.Label143.TabIndex = 176
        Me.Label143.Text = "         Opción para casos especiales en que el formato estandar del sistema no s" & _
            "e ajusta a lo solicitado"
        '
        'Label140
        '
        Me.Label140.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.Location = New System.Drawing.Point(8, 208)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(712, 16)
        Me.Label140.TabIndex = 175
        Me.Label140.Text = "         esto ademàs agregara o sumara el valor en la columna ""$ Valor"". Una ves " & _
            "finalizada la operación precionar boton ""Carga"""
        '
        'Label137
        '
        Me.Label137.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label137.Location = New System.Drawing.Point(8, 640)
        Me.Label137.Name = "Label137"
        Me.Label137.Size = New System.Drawing.Size(728, 16)
        Me.Label137.TabIndex = 174
        Me.Label137.Text = "         Para no perder las modificaciones realizadas, este documento no se podra" & _
            " volver a generar desde el sistema de cotizaciones"
        '
        'Label118
        '
        Me.Label118.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label118.Location = New System.Drawing.Point(8, 608)
        Me.Label118.Name = "Label118"
        Me.Label118.Size = New System.Drawing.Size(712, 16)
        Me.Label118.TabIndex = 173
        Me.Label118.Text = "         Una vez seleccionado los datos del productor y las notas podrá imprimir " & _
            "este documento y realizar modificaciones en él ,"
        '
        'Label119
        '
        Me.Label119.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.Location = New System.Drawing.Point(8, 592)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(712, 16)
        Me.Label119.TabIndex = 172
        Me.Label119.Text = "         Para generar este tipo de archivo, el detalle de la cotización deberá es" & _
            "tar vacía"
        '
        'Label120
        '
        Me.Label120.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label120.Location = New System.Drawing.Point(8, 624)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(712, 16)
        Me.Label120.TabIndex = 171
        Me.Label120.Text = "         efectuando cambios por ej:eliminar filas, agregar textos, establecer nue" & _
            "vas areas de impresión ,etc"
        '
        'Label121
        '
        Me.Label121.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label121.Location = New System.Drawing.Point(8, 560)
        Me.Label121.Name = "Label121"
        Me.Label121.Size = New System.Drawing.Size(712, 16)
        Me.Label121.TabIndex = 170
        Me.Label121.Text = "Cotizar con formato diferente al que entrega el sistema"
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(8, 272)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(712, 16)
        Me.Label33.TabIndex = 169
        Me.Label33.Text = "         Chequeando la casilla ""Formato c/cant"" en la pestaña cotiza se desplegar" & _
            "á la columna ""Cant"", la cual permitirá"
        '
        'Label73
        '
        Me.Label73.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label73.Location = New System.Drawing.Point(8, 288)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(712, 16)
        Me.Label73.TabIndex = 167
        Me.Label73.Text = "         ingresar el número de análisis que necesite  cotizar"
        '
        'Label107
        '
        Me.Label107.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(8, 224)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(712, 16)
        Me.Label107.TabIndex = 166
        Me.Label107.Text = "Cotizar varias unidades del mismo codigo (con neto,IVA,Total)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 464)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 16)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "el cual se encuentra ubicado en la parte inferior de la pantalla"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(192, 464)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(128, 16)
        Me.Label15.TabIndex = 163
        Me.Label15.Text = "Dar click en el botón"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(232, 480)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(408, 16)
        Me.Label17.TabIndex = 162
        Me.Label17.Text = "Ver lo descrito en ""Buscar una Empresa, Productor, etc."""
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(40, 480)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(200, 16)
        Me.Label18.TabIndex = 161
        Me.Label18.Text = "Buscar datos  productor en SQL:"
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(40, 464)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(160, 16)
        Me.Label19.TabIndex = 160
        Me.Label19.Text = "Buscar Cotización en xls:"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 448)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(712, 16)
        Me.Label22.TabIndex = 159
        Me.Label22.Text = "          la codificación de los análisis ha cambiado."
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 432)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(712, 16)
        Me.Label23.TabIndex = 158
        Me.Label23.Text = "          recomienda para buscar los datos del productor, no los análisis, ya que" & _
            " estos pueden haber cambiado si es que"
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 416)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(712, 16)
        Me.Label24.TabIndex = 157
        Me.Label24.Text = "          Se puede buscar de dos formas: la copia guardada en xls o los datos gua" & _
            "rdados en SQL, esto último sólo se"
        '
        'Label25
        '
        Me.Label25.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(8, 400)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(712, 16)
        Me.Label25.TabIndex = 156
        Me.Label25.Text = "Buscar Cotización realizada:"
        '
        'Label26
        '
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(96, 368)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(624, 16)
        Me.Label26.TabIndex = 155
        Me.Label26.Text = ". Luego posicionarse en la primera fila (N°Cot, fecha, empresa, productor,etc.) y" & _
            " dar click en la"
        '
        'Label28
        '
        Me.Label28.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(40, 384)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(680, 16)
        Me.Label28.TabIndex = 153
        Me.Label28.Text = "columna que le interesa indexar, finalmente buscar el nombre deseado."
        '
        'Label29
        '
        Me.Label29.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(8, 368)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 16)
        Me.Label29.TabIndex = 152
        Me.Label29.Text = "          botón "
        '
        'Label65
        '
        Me.Label65.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(8, 352)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(712, 16)
        Me.Label65.TabIndex = 151
        Me.Label65.Text = "          Otra manera para buscar en posicionarse en el campo Srs/Emp, estando és" & _
            "ta vacia, dar click en el"
        '
        'Label66
        '
        Me.Label66.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(8, 336)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(616, 16)
        Me.Label66.TabIndex = 149
        Me.Label66.Text = "          buscar(Rut, Empresa, Productor o Atención) y digitar el nombre buscado," & _
            " finalmente dar click en el botón"
        '
        'Label67
        '
        Me.Label67.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(8, 320)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(712, 16)
        Me.Label67.TabIndex = 148
        Me.Label67.Text = "          Primero seleccionar la Base (Cotizaciones o Agrolab), luego posicionars" & _
            "e en le campo que desea"
        '
        'Label68
        '
        Me.Label68.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(8, 304)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(712, 16)
        Me.Label68.TabIndex = 147
        Me.Label68.Text = "Buscar una Empresa, Productor, etc.:"
        '
        'Label96
        '
        Me.Label96.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label96.Location = New System.Drawing.Point(8, 96)
        Me.Label96.Name = "Label96"
        Me.Label96.Size = New System.Drawing.Size(712, 16)
        Me.Label96.TabIndex = 146
        Me.Label96.Text = "          cabecera (primera columna a mano izquierda)."
        '
        'Label97
        '
        Me.Label97.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label97.Location = New System.Drawing.Point(176, 512)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(544, 16)
        Me.Label97.TabIndex = 145
        Me.Label97.Text = ", estando en outlook espere que la dirección se encuentre subrayada antes de dar " & _
            "click"
        '
        'Label98
        '
        Me.Label98.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label98.Location = New System.Drawing.Point(8, 528)
        Me.Label98.Name = "Label98"
        Me.Label98.Size = New System.Drawing.Size(712, 16)
        Me.Label98.TabIndex = 144
        Me.Label98.Text = "         en botón ""Enviar"" (puede demorar 5 - 10 seg.)"
        '
        'Label99
        '
        Me.Label99.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Image = CType(resources.GetObject("Label99.Image"), System.Drawing.Image)
        Me.Label99.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label99.Location = New System.Drawing.Point(160, 512)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(16, 18)
        Me.Label99.TabIndex = 143
        '
        'Label100
        '
        Me.Label100.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label100.Location = New System.Drawing.Point(8, 512)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(152, 16)
        Me.Label100.TabIndex = 142
        Me.Label100.Text = "         Dar click en el bóton"
        '
        'Label101
        '
        Me.Label101.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label101.Location = New System.Drawing.Point(8, 544)
        Me.Label101.Name = "Label101"
        Me.Label101.Size = New System.Drawing.Size(712, 16)
        Me.Label101.TabIndex = 141
        Me.Label101.Text = "         Para enviar una cotización a varias direcciones email,  separe estas por" & _
            " punto y coma (;) en la pantalla cotización"
        '
        'Label116
        '
        Me.Label116.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label116.Location = New System.Drawing.Point(8, 496)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(712, 16)
        Me.Label116.TabIndex = 140
        Me.Label116.Text = "Envío por email:"
        '
        'Label122
        '
        Me.Label122.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.Location = New System.Drawing.Point(8, 192)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(712, 16)
        Me.Label122.TabIndex = 139
        Me.Label122.Text = "         Para agregar una descripcion de algùn anàlisis debera dar doble click en" & _
            " la columna cabecera  de la fila correspondiente,"
        '
        'Label123
        '
        Me.Label123.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.Location = New System.Drawing.Point(272, 160)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(456, 16)
        Me.Label123.TabIndex = 138
        Me.Label123.Text = "(nuevo análisis solo para cotización , no lo incorpora a la base de análisis):"
        '
        'Label124
        '
        Me.Label124.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.Location = New System.Drawing.Point(8, 176)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(712, 16)
        Me.Label124.TabIndex = 137
        Me.Label124.Text = "         Dar click en boton ""Jocker Análisis"", esto abrira una nueva pantalla."
        '
        'Label125
        '
        Me.Label125.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.Location = New System.Drawing.Point(8, 160)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(272, 16)
        Me.Label125.TabIndex = 136
        Me.Label125.Text = "Cotizar un análisis que no figura en el listado"
        '
        'Label126
        '
        Me.Label126.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.Location = New System.Drawing.Point(8, 144)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(712, 16)
        Me.Label126.TabIndex = 135
        Me.Label126.Text = "         Los valores deben digitarse sin el punto separador de miles."
        '
        'Label127
        '
        Me.Label127.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.Location = New System.Drawing.Point(8, 128)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(712, 16)
        Me.Label127.TabIndex = 134
        Me.Label127.Text = "         Dar un click en la columna ""%dcto"" o ""$ c/dcto"", luego ingresar el valor" & _
            " deseado."
        '
        'Label128
        '
        Me.Label128.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.Location = New System.Drawing.Point(8, 112)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(712, 16)
        Me.Label128.TabIndex = 133
        Me.Label128.Text = "Cotizar un análisis con descuento:"
        '
        'Label129
        '
        Me.Label129.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.Location = New System.Drawing.Point(8, 80)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(712, 16)
        Me.Label129.TabIndex = 132
        Me.Label129.Text = "          Primero seleccionar la pestaña ""Cotiza"", luego frente al análisis que d" & _
            "esea eliminar dar doble click en la columna"
        '
        'Label130
        '
        Me.Label130.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label130.Location = New System.Drawing.Point(8, 64)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(712, 16)
        Me.Label130.TabIndex = 131
        Me.Label130.Text = "Eliminar un análisis selccionado:"
        '
        'Label131
        '
        Me.Label131.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label131.Location = New System.Drawing.Point(8, 48)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(712, 16)
        Me.Label131.TabIndex = 130
        Me.Label131.Text = "          Efectuardoble click en la columna cabecera (primera columna a mano izqu" & _
            "ierda)."
        '
        'Label132
        '
        Me.Label132.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label132.Location = New System.Drawing.Point(8, 32)
        Me.Label132.Name = "Label132"
        Me.Label132.Size = New System.Drawing.Size(712, 16)
        Me.Label132.TabIndex = 129
        Me.Label132.Text = "Seleccionar un análisis:"
        '
        'Label31
        '
        Me.Label31.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(0, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(816, 16)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Ayuda Cotización"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(816, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(24, 18)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label70)
        Me.GroupBox7.Controls.Add(Me.Label117)
        Me.GroupBox7.Controls.Add(Me.Label115)
        Me.GroupBox7.Controls.Add(Me.Label114)
        Me.GroupBox7.Controls.Add(Me.Label113)
        Me.GroupBox7.Controls.Add(Me.Label112)
        Me.GroupBox7.Controls.Add(Me.Label102)
        Me.GroupBox7.Controls.Add(Me.Label95)
        Me.GroupBox7.Controls.Add(Me.Label94)
        Me.GroupBox7.Controls.Add(Me.Label93)
        Me.GroupBox7.Controls.Add(Me.Label92)
        Me.GroupBox7.Controls.Add(Me.Label91)
        Me.GroupBox7.Controls.Add(Me.Label90)
        Me.GroupBox7.Controls.Add(Me.Label89)
        Me.GroupBox7.Controls.Add(Me.Label88)
        Me.GroupBox7.Controls.Add(Me.Label44)
        Me.GroupBox7.Controls.Add(Me.Button5)
        Me.GroupBox7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.Location = New System.Drawing.Point(93, 513)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(792, 304)
        Me.GroupBox7.TabIndex = 119
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Visible = False
        '
        'Label70
        '
        Me.Label70.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(8, 240)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(768, 16)
        Me.Label70.TabIndex = 30
        Me.Label70.Text = "Nota:"
        '
        'Label117
        '
        Me.Label117.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label117.Location = New System.Drawing.Point(8, 272)
        Me.Label117.Name = "Label117"
        Me.Label117.Size = New System.Drawing.Size(768, 16)
        Me.Label117.TabIndex = 29
        Me.Label117.Text = "           Re , C2 y C3 preferimos mantenerlas sin modificarlos"
        '
        'Label115
        '
        Me.Label115.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label115.Location = New System.Drawing.Point(8, 256)
        Me.Label115.Name = "Label115"
        Me.Label115.Size = New System.Drawing.Size(768, 16)
        Me.Label115.TabIndex = 28
        Me.Label115.Text = "           Para agregar o eliminar análisis a los listados solo pude utilizar el " & _
            "listado C1."
        '
        'Label114
        '
        Me.Label114.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label114.Location = New System.Drawing.Point(8, 208)
        Me.Label114.Name = "Label114"
        Me.Label114.Size = New System.Drawing.Size(768, 16)
        Me.Label114.TabIndex = 27
        Me.Label114.Text = "          que le interesa (Listado C1 o C2), de tal forma que desaparesca la  "" x" & _
            " ""."
        '
        'Label113
        '
        Me.Label113.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label113.Location = New System.Drawing.Point(8, 192)
        Me.Label113.Name = "Label113"
        Me.Label113.Size = New System.Drawing.Size(768, 16)
        Me.Label113.TabIndex = 26
        Me.Label113.Text = "          Ubicar el análisis que le interesa eliminar, luego dar clik en la colum" & _
            "na correspondiente al listado"
        '
        'Label112
        '
        Me.Label112.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label112.Location = New System.Drawing.Point(8, 176)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(768, 16)
        Me.Label112.TabIndex = 25
        Me.Label112.Text = "Eliminar análisis del listado:"
        '
        'Label102
        '
        Me.Label102.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(8, 160)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(768, 16)
        Me.Label102.TabIndex = 24
        Me.Label102.Text = "          que le interesa (Listado C1 o C2), de tal forma que aparesca una "" x """
        '
        'Label95
        '
        Me.Label95.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label95.Location = New System.Drawing.Point(8, 144)
        Me.Label95.Name = "Label95"
        Me.Label95.Size = New System.Drawing.Size(768, 16)
        Me.Label95.TabIndex = 23
        Me.Label95.Text = "          Ubicar el análisis que le interesa agregar al listado, luego dar clik e" & _
            "n la columna correspondiente al listado"
        '
        'Label94
        '
        Me.Label94.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label94.Location = New System.Drawing.Point(8, 128)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(768, 16)
        Me.Label94.TabIndex = 22
        Me.Label94.Text = "Agregar análisis al listado (Listado C1 o C2):"
        '
        'Label93
        '
        Me.Label93.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label93.Location = New System.Drawing.Point(8, 112)
        Me.Label93.Name = "Label93"
        Me.Label93.Size = New System.Drawing.Size(768, 16)
        Me.Label93.TabIndex = 21
        Me.Label93.Text = "          Listado C3:  Es el listado de análisis más completo"
        '
        'Label92
        '
        Me.Label92.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label92.Location = New System.Drawing.Point(8, 96)
        Me.Label92.Name = "Label92"
        Me.Label92.Size = New System.Drawing.Size(768, 16)
        Me.Label92.TabIndex = 20
        Me.Label92.Text = "          Listado C2:  Listado con diferentes análisis, cuando requiera modificar" & _
            " un listado prefiera realizarlo en este listado"
        '
        'Label91
        '
        Me.Label91.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label91.Location = New System.Drawing.Point(8, 80)
        Me.Label91.Name = "Label91"
        Me.Label91.Size = New System.Drawing.Size(768, 16)
        Me.Label91.TabIndex = 19
        Me.Label91.Text = "          Listado C1:  Listado con diferentes análisis, cuando requiera modificar" & _
            " un listado prefiera realizarlo en este listado"
        '
        'Label90
        '
        Me.Label90.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label90.Location = New System.Drawing.Point(8, 64)
        Me.Label90.Name = "Label90"
        Me.Label90.Size = New System.Drawing.Size(768, 16)
        Me.Label90.TabIndex = 18
        Me.Label90.Text = "          Listado Re:  Listado de precio con los principales análisis, resumido e" & _
            "n una página."
        '
        'Label89
        '
        Me.Label89.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label89.Location = New System.Drawing.Point(8, 48)
        Me.Label89.Name = "Label89"
        Me.Label89.Size = New System.Drawing.Size(768, 16)
        Me.Label89.TabIndex = 17
        Me.Label89.Text = "          de precios (Re, C1,C2,C3)"
        '
        'Label88
        '
        Me.Label88.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label88.Location = New System.Drawing.Point(6, 32)
        Me.Label88.Name = "Label88"
        Me.Label88.Size = New System.Drawing.Size(768, 16)
        Me.Label88.TabIndex = 16
        Me.Label88.Text = "          Esta pantalla permite seleccionar los análisis que se deseen listar en " & _
            "cualquiera de las 4 alternativas de listados"
        '
        'Label44
        '
        Me.Label44.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label44.Location = New System.Drawing.Point(0, 0)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(772, 16)
        Me.Label44.TabIndex = 13
        Me.Label44.Text = "Ayuda Listado"
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(772, -1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(20, 17)
        Me.Button5.TabIndex = 12
        Me.Button5.Text = "X"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'GroupBox28
        '
        Me.GroupBox28.Controls.Add(Me.Button17)
        Me.GroupBox28.Location = New System.Drawing.Point(107, 571)
        Me.GroupBox28.Name = "GroupBox28"
        Me.GroupBox28.Size = New System.Drawing.Size(808, 40)
        Me.GroupBox28.TabIndex = 122
        Me.GroupBox28.TabStop = False
        Me.GroupBox28.Visible = False
        '
        'GroupBox30
        '
        Me.GroupBox30.Controls.Add(Me.Label148)
        Me.GroupBox30.Controls.Add(Me.Label87)
        Me.GroupBox30.Controls.Add(Me.Label84)
        Me.GroupBox30.Controls.Add(Me.Label86)
        Me.GroupBox30.Controls.Add(Me.Label85)
        Me.GroupBox30.Controls.Add(Me.Label83)
        Me.GroupBox30.Controls.Add(Me.Label82)
        Me.GroupBox30.Controls.Add(Me.Label12)
        Me.GroupBox30.Controls.Add(Me.Label42)
        Me.GroupBox30.Controls.Add(Me.Button18)
        Me.GroupBox30.Controls.Add(Me.Label106)
        Me.GroupBox30.Controls.Add(Me.Label108)
        Me.GroupBox30.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox30.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox30.Location = New System.Drawing.Point(107, 610)
        Me.GroupBox30.Name = "GroupBox30"
        Me.GroupBox30.Size = New System.Drawing.Size(792, 200)
        Me.GroupBox30.TabIndex = 130
        Me.GroupBox30.TabStop = False
        Me.GroupBox30.Visible = False
        '
        'Label148
        '
        Me.Label148.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label148.Location = New System.Drawing.Point(8, 168)
        Me.Label148.Name = "Label148"
        Me.Label148.Size = New System.Drawing.Size(712, 16)
        Me.Label148.TabIndex = 21
        Me.Label148.Text = "          Para desplazarse dentro de las notas: Dar click dentro de cualquier not" & _
            "a de tal forma de activar el scroll"
        '
        'Label87
        '
        Me.Label87.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label87.Location = New System.Drawing.Point(104, 104)
        Me.Label87.Name = "Label87"
        Me.Label87.Size = New System.Drawing.Size(616, 16)
        Me.Label87.TabIndex = 20
        Me.Label87.Text = "la próxima pantalla)"
        '
        'Label84
        '
        Me.Label84.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label84.Location = New System.Drawing.Point(104, 72)
        Me.Label84.Name = "Label84"
        Me.Label84.Size = New System.Drawing.Size(552, 16)
        Me.Label84.TabIndex = 17
        Me.Label84.Text = "Primero borrar el que tiene (si es que aparece), dando clik en el botón ""Borra"" y" & _
            " luego dar clik en el"
        '
        'Label86
        '
        Me.Label86.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label86.Location = New System.Drawing.Point(8, 72)
        Me.Label86.Name = "Label86"
        Me.Label86.Size = New System.Drawing.Size(104, 16)
        Me.Label86.TabIndex = 19
        Me.Label86.Text = "Modificar texto:"
        '
        'Label85
        '
        Me.Label85.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label85.Location = New System.Drawing.Point(104, 88)
        Me.Label85.Name = "Label85"
        Me.Label85.Size = New System.Drawing.Size(616, 16)
        Me.Label85.TabIndex = 18
        Me.Label85.Text = "botón ""texto"" y seleccionar el que le interese de entre los propuestos o cree uno" & _
            " nuevo (consultar ? en"
        '
        'Label83
        '
        Me.Label83.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label83.Location = New System.Drawing.Point(8, 48)
        Me.Label83.Name = "Label83"
        Me.Label83.Size = New System.Drawing.Size(712, 16)
        Me.Label83.TabIndex = 16
        Me.Label83.Text = "una de estas secciones se puede agregar, modificar o borrar un texto."
        '
        'Label82
        '
        Me.Label82.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.Location = New System.Drawing.Point(8, 32)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(712, 16)
        Me.Label82.TabIndex = 15
        Me.Label82.Text = "El texto de las cotizaciones se encuentra dividido en tres secciónes: Alto, Medio" & _
            " y Bajo. En cada"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(712, 16)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "          Para limpiar el texto actual: Dar click en boton ""Borra""  "
        '
        'Label42
        '
        Me.Label42.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label42.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label42.Location = New System.Drawing.Point(0, 1)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(776, 16)
        Me.Label42.TabIndex = 13
        Me.Label42.Text = "Ayuda"
        '
        'Button18
        '
        Me.Button18.BackColor = System.Drawing.Color.Transparent
        Me.Button18.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button18.Location = New System.Drawing.Point(776, 0)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(16, 16)
        Me.Button18.TabIndex = 12
        Me.Button18.Text = "X"
        Me.Button18.UseVisualStyleBackColor = False
        '
        'Label106
        '
        Me.Label106.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label106.Location = New System.Drawing.Point(8, 136)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(712, 16)
        Me.Label106.TabIndex = 1
        Me.Label106.Text = "          Para seleccionar una nueva nota: Dar click en boton ""Texto"" de la respe" & _
            "ctiva sección"
        '
        'Label108
        '
        Me.Label108.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label108.Location = New System.Drawing.Point(8, 120)
        Me.Label108.Name = "Label108"
        Me.Label108.Size = New System.Drawing.Size(712, 16)
        Me.Label108.TabIndex = 0
        Me.Label108.Text = "Notas:"
        '
        'GroupBox31
        '
        Me.GroupBox31.Controls.Add(Me.Label133)
        Me.GroupBox31.Controls.Add(Me.Button19)
        Me.GroupBox31.Controls.Add(Me.Label135)
        Me.GroupBox31.Controls.Add(Me.Label136)
        Me.GroupBox31.Controls.Add(Me.Label134)
        Me.GroupBox31.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox31.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox31.Location = New System.Drawing.Point(107, 650)
        Me.GroupBox31.Name = "GroupBox31"
        Me.GroupBox31.Size = New System.Drawing.Size(824, 96)
        Me.GroupBox31.TabIndex = 131
        Me.GroupBox31.TabStop = False
        Me.GroupBox31.Visible = False
        '
        'Label133
        '
        Me.Label133.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label133.Location = New System.Drawing.Point(8, 64)
        Me.Label133.Name = "Label133"
        Me.Label133.Size = New System.Drawing.Size(712, 16)
        Me.Label133.TabIndex = 14
        Me.Label133.Text = "          Permite remarcar este texto en los listados."
        '
        'Label134
        '
        Me.Label134.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label134.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label134.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label134.Location = New System.Drawing.Point(0, 1)
        Me.Label134.Name = "Label134"
        Me.Label134.Size = New System.Drawing.Size(804, 16)
        Me.Label134.TabIndex = 13
        Me.Label134.Text = "Ayuda Otro"
        '
        'Button19
        '
        Me.Button19.BackColor = System.Drawing.Color.Transparent
        Me.Button19.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button19.Location = New System.Drawing.Point(802, -1)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(23, 18)
        Me.Button19.TabIndex = 12
        Me.Button19.Text = "X"
        Me.Button19.UseVisualStyleBackColor = False
        '
        'Label135
        '
        Me.Label135.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label135.Location = New System.Drawing.Point(8, 48)
        Me.Label135.Name = "Label135"
        Me.Label135.Size = New System.Drawing.Size(712, 16)
        Me.Label135.TabIndex = 1
        Me.Label135.Text = "          Permite definir los tipos de muestras"
        '
        'Label136
        '
        Me.Label136.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label136.Location = New System.Drawing.Point(8, 32)
        Me.Label136.Name = "Label136"
        Me.Label136.Size = New System.Drawing.Size(712, 16)
        Me.Label136.TabIndex = 0
        Me.Label136.Text = "Mantenedor Muestra y Submuestra:"
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Right
        Me.TabControl2.Controls.Add(Me.TabPage18)
        Me.TabControl2.Controls.Add(Me.TabPage16)
        Me.TabControl2.Controls.Add(Me.TabPage19)
        Me.TabControl2.Controls.Add(Me.TabPage21)
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Location = New System.Drawing.Point(110, 155)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(962, 662)
        Me.TabControl2.TabIndex = 132
        '
        'TabPage21
        '
        Me.TabPage21.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage21.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage21.Location = New System.Drawing.Point(4, 4)
        Me.TabPage21.Name = "TabPage21"
        Me.TabPage21.Size = New System.Drawing.Size(935, 654)
        Me.TabPage21.TabIndex = 5
        Me.TabPage21.Text = "Análisis"
        Me.TabPage21.Visible = False
        '
        'TabPage18
        '
        Me.TabPage18.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage18.Controls.Add(Me.GrbListado)
        Me.TabPage18.Controls.Add(Me.DataGrid13)
        Me.TabPage18.Location = New System.Drawing.Point(4, 4)
        Me.TabPage18.Name = "TabPage18"
        Me.TabPage18.Size = New System.Drawing.Size(935, 654)
        Me.TabPage18.TabIndex = 2
        Me.TabPage18.Text = "Listados"
        Me.TabPage18.Visible = False
        '
        'DataGrid13
        '
        Me.DataGrid13.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid13.CaptionVisible = False
        Me.DataGrid13.DataMember = "ANALISIS"
        Me.DataGrid13.DataSource = Me.Cjto_Cotizacion1
        Me.DataGrid13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid13.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid13.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid13.Name = "DataGrid13"
        Me.DataGrid13.Size = New System.Drawing.Size(920, 616)
        Me.DataGrid13.TabIndex = 2
        Me.DataGrid13.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle13})
        '
        'DataGridTableStyle13
        '
        Me.DataGridTableStyle13.DataGrid = Me.DataGrid13
        Me.DataGridTableStyle13.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn138, Me.DataGridTextBoxColumn139, Me.DataGridTextBoxColumn140, Me.DataGridTextBoxColumn141, Me.DataGridTextBoxColumn142, Me.DataGridTextBoxColumn143, Me.DataGridTextBoxColumn144, Me.DataGridTextBoxColumn145, Me.DataGridTextBoxColumn146})
        Me.DataGridTableStyle13.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle13.MappingName = "ANALISIS"
        '
        'DataGridTextBoxColumn138
        '
        Me.DataGridTextBoxColumn138.Format = ""
        Me.DataGridTextBoxColumn138.FormatInfo = Nothing
        Me.DataGridTextBoxColumn138.HeaderText = "Cod."
        Me.DataGridTextBoxColumn138.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn138.NullText = ""
        Me.DataGridTextBoxColumn138.Width = 30
        '
        'DataGridTextBoxColumn139
        '
        Me.DataGridTextBoxColumn139.Format = ""
        Me.DataGridTextBoxColumn139.FormatInfo = Nothing
        Me.DataGridTextBoxColumn139.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn139.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn139.NullText = ""
        Me.DataGridTextBoxColumn139.Width = 614
        '
        'DataGridTextBoxColumn140
        '
        Me.DataGridTextBoxColumn140.Format = "###,###"
        Me.DataGridTextBoxColumn140.FormatInfo = Nothing
        Me.DataGridTextBoxColumn140.HeaderText = "Valor"
        Me.DataGridTextBoxColumn140.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn140.NullText = ""
        Me.DataGridTextBoxColumn140.Width = 52
        '
        'DataGridTextBoxColumn141
        '
        Me.DataGridTextBoxColumn141.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn141.Format = ""
        Me.DataGridTextBoxColumn141.FormatInfo = Nothing
        Me.DataGridTextBoxColumn141.HeaderText = "Re"
        Me.DataGridTextBoxColumn141.MappingName = "CLIENTE1"
        Me.DataGridTextBoxColumn141.NullText = ""
        Me.DataGridTextBoxColumn141.Width = 30
        '
        'DataGridTextBoxColumn142
        '
        Me.DataGridTextBoxColumn142.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn142.Format = ""
        Me.DataGridTextBoxColumn142.FormatInfo = Nothing
        Me.DataGridTextBoxColumn142.HeaderText = "C-1"
        Me.DataGridTextBoxColumn142.MappingName = "CLIENTE2"
        Me.DataGridTextBoxColumn142.NullText = ""
        Me.DataGridTextBoxColumn142.Width = 31
        '
        'DataGridTextBoxColumn143
        '
        Me.DataGridTextBoxColumn143.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn143.Format = ""
        Me.DataGridTextBoxColumn143.FormatInfo = Nothing
        Me.DataGridTextBoxColumn143.HeaderText = "C-2"
        Me.DataGridTextBoxColumn143.MappingName = "CLIENTE3"
        Me.DataGridTextBoxColumn143.NullText = ""
        Me.DataGridTextBoxColumn143.Width = 31
        '
        'DataGridTextBoxColumn144
        '
        Me.DataGridTextBoxColumn144.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn144.Format = ""
        Me.DataGridTextBoxColumn144.FormatInfo = Nothing
        Me.DataGridTextBoxColumn144.HeaderText = "C-3"
        Me.DataGridTextBoxColumn144.MappingName = "CLIENTET"
        Me.DataGridTextBoxColumn144.NullText = ""
        Me.DataGridTextBoxColumn144.Width = 31
        '
        'DataGridTextBoxColumn145
        '
        Me.DataGridTextBoxColumn145.Format = ""
        Me.DataGridTextBoxColumn145.FormatInfo = Nothing
        Me.DataGridTextBoxColumn145.HeaderText = "Tpo."
        Me.DataGridTextBoxColumn145.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn145.NullText = ""
        Me.DataGridTextBoxColumn145.Width = 30
        '
        'DataGridTextBoxColumn146
        '
        Me.DataGridTextBoxColumn146.Format = ""
        Me.DataGridTextBoxColumn146.FormatInfo = Nothing
        Me.DataGridTextBoxColumn146.HeaderText = "Nivel"
        Me.DataGridTextBoxColumn146.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn146.NullText = ""
        Me.DataGridTextBoxColumn146.Width = 30
        '
        'TabPage16
        '
        Me.TabPage16.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage16.Controls.Add(Me.GroupBox27)
        Me.TabPage16.Controls.Add(Me.GroupBox24)
        Me.TabPage16.Controls.Add(Me.CBCotLis)
        Me.TabPage16.Controls.Add(Me.CBExcel)
        Me.TabPage16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage16.Location = New System.Drawing.Point(4, 4)
        Me.TabPage16.Name = "TabPage16"
        Me.TabPage16.Size = New System.Drawing.Size(935, 654)
        Me.TabPage16.TabIndex = 0
        Me.TabPage16.Text = "  Lista $  "
        '
        'GroupBox27
        '
        Me.GroupBox27.Controls.Add(Me.Label71)
        Me.GroupBox27.Controls.Add(Me.Label109)
        Me.GroupBox27.Controls.Add(Me.Label104)
        Me.GroupBox27.Controls.Add(Me.Label57)
        Me.GroupBox27.Controls.Add(Me.Label103)
        Me.GroupBox27.Controls.Add(Me.Label60)
        Me.GroupBox27.Controls.Add(Me.Label59)
        Me.GroupBox27.Controls.Add(Me.Label58)
        Me.GroupBox27.Controls.Add(Me.GroupBox21)
        Me.GroupBox27.Controls.Add(Me.GroupBox20)
        Me.GroupBox27.Controls.Add(Me.GroupBox19)
        Me.GroupBox27.Controls.Add(Me.GroupBox18)
        Me.GroupBox27.Controls.Add(Me.GroupBox17)
        Me.GroupBox27.Controls.Add(Me.GroupBox16)
        Me.GroupBox27.Controls.Add(Me.GroupBox15)
        Me.GroupBox27.Controls.Add(Me.GroupBox14)
        Me.GroupBox27.Location = New System.Drawing.Point(16, 0)
        Me.GroupBox27.Name = "GroupBox27"
        Me.GroupBox27.Size = New System.Drawing.Size(592, 344)
        Me.GroupBox27.TabIndex = 34
        Me.GroupBox27.TabStop = False
        '
        'Label71
        '
        Me.Label71.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label71.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Black
        Me.Label71.Location = New System.Drawing.Point(128, 56)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(256, 16)
        Me.Label71.TabIndex = 34
        Me.Label71.Text = "Listado Cliente"
        Me.Label71.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label109
        '
        Me.Label109.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label109.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label109.ForeColor = System.Drawing.Color.Black
        Me.Label109.Location = New System.Drawing.Point(384, 56)
        Me.Label109.Name = "Label109"
        Me.Label109.Size = New System.Drawing.Size(208, 16)
        Me.Label109.TabIndex = 32
        Me.Label109.Text = "Listado Códigos"
        Me.Label109.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label104
        '
        Me.Label104.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label104.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label104.ForeColor = System.Drawing.Color.Black
        Me.Label104.Location = New System.Drawing.Point(384, 72)
        Me.Label104.Name = "Label104"
        Me.Label104.Size = New System.Drawing.Size(208, 16)
        Me.Label104.TabIndex = 31
        Me.Label104.Text = "Frecuentes       Todos(FR+OC)   Interno"
        '
        'Label57
        '
        Me.Label57.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label57.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.Black
        Me.Label57.Location = New System.Drawing.Point(320, 72)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(64, 16)
        Me.Label57.TabIndex = 30
        Me.Label57.Text = "C-3"
        Me.Label57.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label103
        '
        Me.Label103.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label103.ForeColor = System.Drawing.Color.Black
        Me.Label103.Location = New System.Drawing.Point(216, 16)
        Me.Label103.Name = "Label103"
        Me.Label103.Size = New System.Drawing.Size(240, 16)
        Me.Label103.TabIndex = 25
        Me.Label103.Text = "L i s t a d o s   d e   A n á l i s i s "
        '
        'Label60
        '
        Me.Label60.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label60.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Black
        Me.Label60.Location = New System.Drawing.Point(128, 72)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 21
        Me.Label60.Text = "Resumen"
        Me.Label60.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label59
        '
        Me.Label59.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label59.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Black
        Me.Label59.Location = New System.Drawing.Point(184, 72)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(72, 16)
        Me.Label59.TabIndex = 22
        Me.Label59.Text = "C-1"
        Me.Label59.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label58
        '
        Me.Label58.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label58.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label58.ForeColor = System.Drawing.Color.Black
        Me.Label58.Location = New System.Drawing.Point(256, 72)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(64, 16)
        Me.Label58.TabIndex = 23
        Me.Label58.Text = "C-2"
        Me.Label58.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox21
        '
        Me.GroupBox21.Controls.Add(Me.CheckBox50)
        Me.GroupBox21.Controls.Add(Me.CheckBox6)
        Me.GroupBox21.Controls.Add(Me.CheckBox5)
        Me.GroupBox21.Controls.Add(Me.CheckBox4)
        Me.GroupBox21.Controls.Add(Me.CheckBox3)
        Me.GroupBox21.Controls.Add(Me.CheckBox2)
        Me.GroupBox21.Controls.Add(Me.CheckBox1)
        Me.GroupBox21.Controls.Add(Me.Label56)
        Me.GroupBox21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox21.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox21.Location = New System.Drawing.Point(0, 80)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox21.TabIndex = 13
        Me.GroupBox21.TabStop = False
        '
        'CheckBox50
        '
        Me.CheckBox50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox50.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox50.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox50.Name = "CheckBox50"
        Me.CheckBox50.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox50.TabIndex = 11
        '
        'CheckBox6
        '
        Me.CheckBox6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox6.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox6.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox6.TabIndex = 10
        '
        'CheckBox5
        '
        Me.CheckBox5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox5.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox5.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox5.TabIndex = 9
        '
        'CheckBox4
        '
        Me.CheckBox4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox4.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox4.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox4.TabIndex = 8
        '
        'CheckBox3
        '
        Me.CheckBox3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox3.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox3.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox3.TabIndex = 7
        '
        'CheckBox2
        '
        Me.CheckBox2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox2.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox2.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox2.TabIndex = 6
        '
        'CheckBox1
        '
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox1.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox1.TabIndex = 5
        '
        'Label56
        '
        Me.Label56.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.Color.Black
        Me.Label56.Location = New System.Drawing.Point(16, 16)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(88, 16)
        Me.Label56.TabIndex = 4
        Me.Label56.Text = "1.  Foliar"
        '
        'GroupBox20
        '
        Me.GroupBox20.Controls.Add(Me.CheckBox51)
        Me.GroupBox20.Controls.Add(Me.CheckBox12)
        Me.GroupBox20.Controls.Add(Me.CheckBox11)
        Me.GroupBox20.Controls.Add(Me.CheckBox10)
        Me.GroupBox20.Controls.Add(Me.CheckBox9)
        Me.GroupBox20.Controls.Add(Me.CheckBox8)
        Me.GroupBox20.Controls.Add(Me.CheckBox7)
        Me.GroupBox20.Controls.Add(Me.Label55)
        Me.GroupBox20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox20.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox20.Location = New System.Drawing.Point(0, 112)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox20.TabIndex = 14
        Me.GroupBox20.TabStop = False
        '
        'CheckBox51
        '
        Me.CheckBox51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox51.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox51.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox51.Name = "CheckBox51"
        Me.CheckBox51.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox51.TabIndex = 12
        '
        'CheckBox12
        '
        Me.CheckBox12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox12.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox12.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox12.Name = "CheckBox12"
        Me.CheckBox12.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox12.TabIndex = 11
        '
        'CheckBox11
        '
        Me.CheckBox11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox11.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox11.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox11.Name = "CheckBox11"
        Me.CheckBox11.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox11.TabIndex = 10
        '
        'CheckBox10
        '
        Me.CheckBox10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox10.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox10.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox10.Name = "CheckBox10"
        Me.CheckBox10.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox10.TabIndex = 9
        '
        'CheckBox9
        '
        Me.CheckBox9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox9.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox9.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox9.Name = "CheckBox9"
        Me.CheckBox9.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox9.TabIndex = 8
        '
        'CheckBox8
        '
        Me.CheckBox8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox8.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox8.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox8.TabIndex = 7
        '
        'CheckBox7
        '
        Me.CheckBox7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox7.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox7.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox7.TabIndex = 6
        '
        'Label55
        '
        Me.Label55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.Color.Black
        Me.Label55.Location = New System.Drawing.Point(16, 16)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(88, 16)
        Me.Label55.TabIndex = 5
        Me.Label55.Text = "2.  +Tejidos"
        '
        'GroupBox19
        '
        Me.GroupBox19.Controls.Add(Me.CheckBox52)
        Me.GroupBox19.Controls.Add(Me.CheckBox18)
        Me.GroupBox19.Controls.Add(Me.CheckBox17)
        Me.GroupBox19.Controls.Add(Me.CheckBox16)
        Me.GroupBox19.Controls.Add(Me.CheckBox15)
        Me.GroupBox19.Controls.Add(Me.CheckBox14)
        Me.GroupBox19.Controls.Add(Me.CheckBox13)
        Me.GroupBox19.Controls.Add(Me.Label54)
        Me.GroupBox19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox19.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox19.Location = New System.Drawing.Point(0, 144)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox19.TabIndex = 15
        Me.GroupBox19.TabStop = False
        '
        'CheckBox52
        '
        Me.CheckBox52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox52.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox52.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox52.Name = "CheckBox52"
        Me.CheckBox52.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox52.TabIndex = 12
        '
        'CheckBox18
        '
        Me.CheckBox18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox18.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox18.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox18.Name = "CheckBox18"
        Me.CheckBox18.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox18.TabIndex = 11
        '
        'CheckBox17
        '
        Me.CheckBox17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox17.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox17.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox17.Name = "CheckBox17"
        Me.CheckBox17.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox17.TabIndex = 10
        '
        'CheckBox16
        '
        Me.CheckBox16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox16.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox16.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox16.Name = "CheckBox16"
        Me.CheckBox16.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox16.TabIndex = 9
        '
        'CheckBox15
        '
        Me.CheckBox15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox15.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox15.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox15.Name = "CheckBox15"
        Me.CheckBox15.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox15.TabIndex = 8
        '
        'CheckBox14
        '
        Me.CheckBox14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox14.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox14.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox14.Name = "CheckBox14"
        Me.CheckBox14.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox14.TabIndex = 7
        '
        'CheckBox13
        '
        Me.CheckBox13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox13.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox13.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox13.Name = "CheckBox13"
        Me.CheckBox13.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox13.TabIndex = 6
        '
        'Label54
        '
        Me.Label54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Black
        Me.Label54.Location = New System.Drawing.Point(16, 16)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(88, 16)
        Me.Label54.TabIndex = 5
        Me.Label54.Text = "3.  Agua"
        '
        'GroupBox18
        '
        Me.GroupBox18.Controls.Add(Me.CheckBox53)
        Me.GroupBox18.Controls.Add(Me.CheckBox24)
        Me.GroupBox18.Controls.Add(Me.CheckBox23)
        Me.GroupBox18.Controls.Add(Me.CheckBox22)
        Me.GroupBox18.Controls.Add(Me.CheckBox21)
        Me.GroupBox18.Controls.Add(Me.CheckBox20)
        Me.GroupBox18.Controls.Add(Me.CheckBox19)
        Me.GroupBox18.Controls.Add(Me.Label53)
        Me.GroupBox18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox18.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox18.Location = New System.Drawing.Point(0, 176)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox18.TabIndex = 16
        Me.GroupBox18.TabStop = False
        '
        'CheckBox53
        '
        Me.CheckBox53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox53.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox53.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox53.Name = "CheckBox53"
        Me.CheckBox53.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox53.TabIndex = 13
        '
        'CheckBox24
        '
        Me.CheckBox24.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox24.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox24.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox24.Name = "CheckBox24"
        Me.CheckBox24.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox24.TabIndex = 12
        '
        'CheckBox23
        '
        Me.CheckBox23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox23.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox23.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox23.Name = "CheckBox23"
        Me.CheckBox23.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox23.TabIndex = 11
        '
        'CheckBox22
        '
        Me.CheckBox22.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox22.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox22.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox22.Name = "CheckBox22"
        Me.CheckBox22.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox22.TabIndex = 10
        '
        'CheckBox21
        '
        Me.CheckBox21.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox21.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox21.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox21.Name = "CheckBox21"
        Me.CheckBox21.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox21.TabIndex = 9
        '
        'CheckBox20
        '
        Me.CheckBox20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox20.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox20.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox20.Name = "CheckBox20"
        Me.CheckBox20.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox20.TabIndex = 8
        '
        'CheckBox19
        '
        Me.CheckBox19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox19.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox19.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox19.Name = "CheckBox19"
        Me.CheckBox19.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox19.TabIndex = 7
        '
        'Label53
        '
        Me.Label53.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Black
        Me.Label53.Location = New System.Drawing.Point(16, 16)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(88, 16)
        Me.Label53.TabIndex = 6
        Me.Label53.Text = "4.  Suelo"
        '
        'GroupBox17
        '
        Me.GroupBox17.Controls.Add(Me.CheckBox54)
        Me.GroupBox17.Controls.Add(Me.CheckBox30)
        Me.GroupBox17.Controls.Add(Me.CheckBox29)
        Me.GroupBox17.Controls.Add(Me.CheckBox28)
        Me.GroupBox17.Controls.Add(Me.CheckBox27)
        Me.GroupBox17.Controls.Add(Me.CheckBox26)
        Me.GroupBox17.Controls.Add(Me.CheckBox25)
        Me.GroupBox17.Controls.Add(Me.Label52)
        Me.GroupBox17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox17.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox17.Location = New System.Drawing.Point(0, 208)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox17.TabIndex = 17
        Me.GroupBox17.TabStop = False
        '
        'CheckBox54
        '
        Me.CheckBox54.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox54.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox54.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox54.Name = "CheckBox54"
        Me.CheckBox54.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox54.TabIndex = 13
        '
        'CheckBox30
        '
        Me.CheckBox30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox30.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox30.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox30.Name = "CheckBox30"
        Me.CheckBox30.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox30.TabIndex = 12
        '
        'CheckBox29
        '
        Me.CheckBox29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox29.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox29.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox29.Name = "CheckBox29"
        Me.CheckBox29.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox29.TabIndex = 11
        '
        'CheckBox28
        '
        Me.CheckBox28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox28.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox28.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox28.Name = "CheckBox28"
        Me.CheckBox28.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox28.TabIndex = 10
        '
        'CheckBox27
        '
        Me.CheckBox27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox27.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox27.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox27.Name = "CheckBox27"
        Me.CheckBox27.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox27.TabIndex = 9
        '
        'CheckBox26
        '
        Me.CheckBox26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox26.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox26.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox26.Name = "CheckBox26"
        Me.CheckBox26.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox26.TabIndex = 8
        '
        'CheckBox25
        '
        Me.CheckBox25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox25.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox25.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox25.Name = "CheckBox25"
        Me.CheckBox25.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox25.TabIndex = 7
        '
        'Label52
        '
        Me.Label52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Black
        Me.Label52.Location = New System.Drawing.Point(16, 16)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(88, 16)
        Me.Label52.TabIndex = 6
        Me.Label52.Text = "5.  Fert-Qui"
        '
        'GroupBox16
        '
        Me.GroupBox16.Controls.Add(Me.CheckBox55)
        Me.GroupBox16.Controls.Add(Me.CheckBox36)
        Me.GroupBox16.Controls.Add(Me.CheckBox35)
        Me.GroupBox16.Controls.Add(Me.CheckBox34)
        Me.GroupBox16.Controls.Add(Me.CheckBox33)
        Me.GroupBox16.Controls.Add(Me.CheckBox32)
        Me.GroupBox16.Controls.Add(Me.CheckBox31)
        Me.GroupBox16.Controls.Add(Me.Label51)
        Me.GroupBox16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox16.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox16.Location = New System.Drawing.Point(0, 240)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox16.TabIndex = 18
        Me.GroupBox16.TabStop = False
        '
        'CheckBox55
        '
        Me.CheckBox55.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox55.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox55.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox55.Name = "CheckBox55"
        Me.CheckBox55.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox55.TabIndex = 13
        '
        'CheckBox36
        '
        Me.CheckBox36.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox36.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox36.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox36.Name = "CheckBox36"
        Me.CheckBox36.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox36.TabIndex = 12
        '
        'CheckBox35
        '
        Me.CheckBox35.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox35.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox35.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox35.Name = "CheckBox35"
        Me.CheckBox35.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox35.TabIndex = 11
        '
        'CheckBox34
        '
        Me.CheckBox34.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox34.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox34.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox34.Name = "CheckBox34"
        Me.CheckBox34.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox34.TabIndex = 10
        '
        'CheckBox33
        '
        Me.CheckBox33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox33.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox33.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox33.Name = "CheckBox33"
        Me.CheckBox33.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox33.TabIndex = 9
        '
        'CheckBox32
        '
        Me.CheckBox32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox32.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox32.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox32.Name = "CheckBox32"
        Me.CheckBox32.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox32.TabIndex = 8
        '
        'CheckBox31
        '
        Me.CheckBox31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox31.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox31.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox31.Name = "CheckBox31"
        Me.CheckBox31.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox31.TabIndex = 7
        '
        'Label51
        '
        Me.Label51.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Black
        Me.Label51.Location = New System.Drawing.Point(16, 16)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(104, 16)
        Me.Label51.TabIndex = 6
        Me.Label51.Text = "6.  Fert-Org"
        '
        'GroupBox15
        '
        Me.GroupBox15.Controls.Add(Me.CheckBox56)
        Me.GroupBox15.Controls.Add(Me.CheckBox42)
        Me.GroupBox15.Controls.Add(Me.CheckBox41)
        Me.GroupBox15.Controls.Add(Me.CheckBox40)
        Me.GroupBox15.Controls.Add(Me.CheckBox39)
        Me.GroupBox15.Controls.Add(Me.CheckBox38)
        Me.GroupBox15.Controls.Add(Me.CheckBox37)
        Me.GroupBox15.Controls.Add(Me.Label50)
        Me.GroupBox15.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox15.Location = New System.Drawing.Point(0, 272)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox15.TabIndex = 19
        Me.GroupBox15.TabStop = False
        '
        'CheckBox56
        '
        Me.CheckBox56.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox56.Name = "CheckBox56"
        Me.CheckBox56.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox56.TabIndex = 13
        '
        'CheckBox42
        '
        Me.CheckBox42.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox42.Name = "CheckBox42"
        Me.CheckBox42.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox42.TabIndex = 12
        '
        'CheckBox41
        '
        Me.CheckBox41.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox41.Name = "CheckBox41"
        Me.CheckBox41.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox41.TabIndex = 11
        '
        'CheckBox40
        '
        Me.CheckBox40.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox40.Name = "CheckBox40"
        Me.CheckBox40.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox40.TabIndex = 10
        '
        'CheckBox39
        '
        Me.CheckBox39.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox39.Name = "CheckBox39"
        Me.CheckBox39.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox39.TabIndex = 9
        '
        'CheckBox38
        '
        Me.CheckBox38.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox38.Name = "CheckBox38"
        Me.CheckBox38.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox38.TabIndex = 8
        '
        'CheckBox37
        '
        Me.CheckBox37.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox37.Name = "CheckBox37"
        Me.CheckBox37.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox37.TabIndex = 7
        '
        'Label50
        '
        Me.Label50.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Black
        Me.Label50.Location = New System.Drawing.Point(16, 16)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(112, 16)
        Me.Label50.TabIndex = 6
        Me.Label50.Text = "7.  +Análisis"
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.CheckBox57)
        Me.GroupBox14.Controls.Add(Me.CheckBox48)
        Me.GroupBox14.Controls.Add(Me.CheckBox47)
        Me.GroupBox14.Controls.Add(Me.CheckBox46)
        Me.GroupBox14.Controls.Add(Me.CheckBox45)
        Me.GroupBox14.Controls.Add(Me.CheckBox44)
        Me.GroupBox14.Controls.Add(Me.CheckBox43)
        Me.GroupBox14.Controls.Add(Me.Label45)
        Me.GroupBox14.ForeColor = System.Drawing.Color.MediumBlue
        Me.GroupBox14.Location = New System.Drawing.Point(0, 304)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(592, 40)
        Me.GroupBox14.TabIndex = 20
        Me.GroupBox14.TabStop = False
        '
        'CheckBox57
        '
        Me.CheckBox57.Location = New System.Drawing.Point(536, 16)
        Me.CheckBox57.Name = "CheckBox57"
        Me.CheckBox57.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox57.TabIndex = 13
        '
        'CheckBox48
        '
        Me.CheckBox48.Location = New System.Drawing.Point(488, 16)
        Me.CheckBox48.Name = "CheckBox48"
        Me.CheckBox48.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox48.TabIndex = 12
        '
        'CheckBox47
        '
        Me.CheckBox47.Location = New System.Drawing.Point(432, 16)
        Me.CheckBox47.Name = "CheckBox47"
        Me.CheckBox47.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox47.TabIndex = 11
        '
        'CheckBox46
        '
        Me.CheckBox46.Location = New System.Drawing.Point(344, 16)
        Me.CheckBox46.Name = "CheckBox46"
        Me.CheckBox46.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox46.TabIndex = 10
        '
        'CheckBox45
        '
        Me.CheckBox45.Location = New System.Drawing.Point(280, 16)
        Me.CheckBox45.Name = "CheckBox45"
        Me.CheckBox45.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox45.TabIndex = 9
        '
        'CheckBox44
        '
        Me.CheckBox44.Location = New System.Drawing.Point(216, 16)
        Me.CheckBox44.Name = "CheckBox44"
        Me.CheckBox44.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox44.TabIndex = 8
        '
        'CheckBox43
        '
        Me.CheckBox43.Location = New System.Drawing.Point(152, 16)
        Me.CheckBox43.Name = "CheckBox43"
        Me.CheckBox43.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox43.TabIndex = 7
        '
        'Label45
        '
        Me.Label45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Black
        Me.Label45.Location = New System.Drawing.Point(16, 16)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(112, 16)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "8.  Kit,Otros"
        '
        'GroupBox24
        '
        Me.GroupBox24.Controls.Add(Me.CBNotasPla)
        Me.GroupBox24.Controls.Add(Me.CBCartaL)
        Me.GroupBox24.Location = New System.Drawing.Point(640, 144)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(144, 80)
        Me.GroupBox24.TabIndex = 33
        Me.GroupBox24.TabStop = False
        '
        'CBNotasPla
        '
        Me.CBNotasPla.BackColor = System.Drawing.Color.Transparent
        Me.CBNotasPla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBNotasPla.Location = New System.Drawing.Point(16, 48)
        Me.CBNotasPla.Name = "CBNotasPla"
        Me.CBNotasPla.Size = New System.Drawing.Size(112, 23)
        Me.CBNotasPla.TabIndex = 28
        Me.CBNotasPla.Text = "Plantilla Cartas"
        Me.CBNotasPla.UseVisualStyleBackColor = False
        '
        'CBCartaL
        '
        Me.CBCartaL.BackColor = System.Drawing.Color.Transparent
        Me.CBCartaL.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCartaL.Location = New System.Drawing.Point(16, 16)
        Me.CBCartaL.Name = "CBCartaL"
        Me.CBCartaL.Size = New System.Drawing.Size(112, 23)
        Me.CBCartaL.TabIndex = 26
        Me.CBCartaL.Text = "Lista $ + Carta "
        Me.CBCartaL.UseVisualStyleBackColor = False
        '
        'CBCotLis
        '
        Me.CBCotLis.BackColor = System.Drawing.Color.Transparent
        Me.CBCotLis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCotLis.Location = New System.Drawing.Point(656, 112)
        Me.CBCotLis.Name = "CBCotLis"
        Me.CBCotLis.Size = New System.Drawing.Size(112, 23)
        Me.CBCotLis.TabIndex = 32
        Me.CBCotLis.Text = "Lista $ + Cotiza"
        Me.CBCotLis.UseVisualStyleBackColor = False
        '
        'CBExcel
        '
        Me.CBExcel.BackColor = System.Drawing.Color.Transparent
        Me.CBExcel.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBExcel.Location = New System.Drawing.Point(656, 80)
        Me.CBExcel.Name = "CBExcel"
        Me.CBExcel.Size = New System.Drawing.Size(112, 23)
        Me.CBExcel.TabIndex = 31
        Me.CBExcel.Text = "Lista $"
        Me.CBExcel.UseVisualStyleBackColor = False
        '
        'TabPage19
        '
        Me.TabPage19.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage19.Controls.Add(Me.GroupBox1)
        Me.TabPage19.Controls.Add(Me.GroupBox5)
        Me.TabPage19.Controls.Add(Me.GroupBox3)
        Me.TabPage19.Controls.Add(Me.DataGrid15)
        Me.TabPage19.Controls.Add(Me.DataGrid14)
        Me.TabPage19.Location = New System.Drawing.Point(4, 4)
        Me.TabPage19.Name = "TabPage19"
        Me.TabPage19.Size = New System.Drawing.Size(935, 654)
        Me.TabPage19.TabIndex = 3
        Me.TabPage19.Text = "  Otros   "
        Me.TabPage19.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox13)
        Me.GroupBox1.Controls.Add(Me.GroupBox12)
        Me.GroupBox1.Controls.Add(Me.Button52)
        Me.GroupBox1.Location = New System.Drawing.Point(625, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 220)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Actualizacion de Precios                                                  "
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.Label49)
        Me.GroupBox13.Controls.Add(Me.TextBox45)
        Me.GroupBox13.Location = New System.Drawing.Point(18, 109)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(245, 67)
        Me.GroupBox13.TabIndex = 17
        Me.GroupBox13.TabStop = False
        '
        'Label49
        '
        Me.Label49.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.Color.Black
        Me.Label49.Location = New System.Drawing.Point(8, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(88, 16)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "% Reajuste"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TextBox45
        '
        Me.TextBox45.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox45.Location = New System.Drawing.Point(104, 24)
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Size = New System.Drawing.Size(56, 20)
        Me.TextBox45.TabIndex = 6
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.Label46)
        Me.GroupBox12.Controls.Add(Me.Label47)
        Me.GroupBox12.Controls.Add(Me.TextBox43)
        Me.GroupBox12.Controls.Add(Me.TextBox44)
        Me.GroupBox12.Controls.Add(Me.Label48)
        Me.GroupBox12.Location = New System.Drawing.Point(18, 16)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(245, 95)
        Me.GroupBox12.TabIndex = 16
        Me.GroupBox12.TabStop = False
        '
        'Label46
        '
        Me.Label46.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Black
        Me.Label46.Location = New System.Drawing.Point(8, 8)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(88, 16)
        Me.Label46.TabIndex = 9
        Me.Label46.Text = "Rango Codigo"
        '
        'Label47
        '
        Me.Label47.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Black
        Me.Label47.Location = New System.Drawing.Point(8, 32)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(40, 16)
        Me.Label47.TabIndex = 10
        Me.Label47.Text = "Desde"
        '
        'TextBox43
        '
        Me.TextBox43.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox43.Location = New System.Drawing.Point(48, 32)
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Size = New System.Drawing.Size(56, 20)
        Me.TextBox43.TabIndex = 6
        '
        'TextBox44
        '
        Me.TextBox44.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox44.Location = New System.Drawing.Point(168, 32)
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Size = New System.Drawing.Size(56, 20)
        Me.TextBox44.TabIndex = 11
        '
        'Label48
        '
        Me.Label48.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Black
        Me.Label48.Location = New System.Drawing.Point(120, 32)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(40, 16)
        Me.Label48.TabIndex = 12
        Me.Label48.Text = "Hasta"
        '
        'Button52
        '
        Me.Button52.BackColor = System.Drawing.Color.Transparent
        Me.Button52.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button52.Location = New System.Drawing.Point(106, 183)
        Me.Button52.Name = "Button52"
        Me.Button52.Size = New System.Drawing.Size(80, 27)
        Me.Button52.TabIndex = 5
        Me.Button52.Text = "Procesa"
        Me.Button52.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Button23)
        Me.GroupBox5.Controls.Add(Me.Button30)
        Me.GroupBox5.Controls.Add(Me.Button31)
        Me.GroupBox5.Controls.Add(Me.Button32)
        Me.GroupBox5.Location = New System.Drawing.Point(440, 238)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(136, 205)
        Me.GroupBox5.TabIndex = 16
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mant. Sub-Muestra"
        '
        'Button23
        '
        Me.Button23.BackColor = System.Drawing.Color.Transparent
        Me.Button23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button23.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Button23.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button23.Location = New System.Drawing.Point(32, 24)
        Me.Button23.Name = "Button23"
        Me.Button23.Size = New System.Drawing.Size(72, 27)
        Me.Button23.TabIndex = 3
        Me.Button23.Text = "Graba"
        Me.Button23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button23.UseVisualStyleBackColor = False
        '
        'Button30
        '
        Me.Button30.BackColor = System.Drawing.Color.Transparent
        Me.Button30.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button30.Image = Global.LabSys.My.Resources.Resources.page_white
        Me.Button30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button30.Location = New System.Drawing.Point(32, 57)
        Me.Button30.Name = "Button30"
        Me.Button30.Size = New System.Drawing.Size(72, 27)
        Me.Button30.TabIndex = 7
        Me.Button30.Text = "Nuevo"
        Me.Button30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button30.UseVisualStyleBackColor = False
        '
        'Button31
        '
        Me.Button31.BackColor = System.Drawing.Color.Transparent
        Me.Button31.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button31.Image = Global.LabSys.My.Resources.Resources.application_form_edit
        Me.Button31.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button31.Location = New System.Drawing.Point(32, 90)
        Me.Button31.Name = "Button31"
        Me.Button31.Size = New System.Drawing.Size(72, 27)
        Me.Button31.TabIndex = 8
        Me.Button31.Text = "Modifica"
        Me.Button31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button31.UseVisualStyleBackColor = False
        '
        'Button32
        '
        Me.Button32.BackColor = System.Drawing.Color.Transparent
        Me.Button32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button32.Image = Global.LabSys.My.Resources.Resources.cross
        Me.Button32.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button32.Location = New System.Drawing.Point(32, 123)
        Me.Button32.Name = "Button32"
        Me.Button32.Size = New System.Drawing.Size(72, 27)
        Me.Button32.TabIndex = 9
        Me.Button32.Text = "Elimina"
        Me.Button32.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button32.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button20)
        Me.GroupBox3.Controls.Add(Me.Button27)
        Me.GroupBox3.Controls.Add(Me.Button28)
        Me.GroupBox3.Controls.Add(Me.Button29)
        Me.GroupBox3.Location = New System.Drawing.Point(440, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(136, 200)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mantenedor Muestra"
        '
        'Button20
        '
        Me.Button20.BackColor = System.Drawing.Color.Transparent
        Me.Button20.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button20.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Button20.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button20.Location = New System.Drawing.Point(32, 33)
        Me.Button20.Name = "Button20"
        Me.Button20.Size = New System.Drawing.Size(72, 27)
        Me.Button20.TabIndex = 2
        Me.Button20.Text = "Graba"
        Me.Button20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button20.UseVisualStyleBackColor = False
        '
        'Button27
        '
        Me.Button27.BackColor = System.Drawing.Color.Transparent
        Me.Button27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button27.Image = Global.LabSys.My.Resources.Resources.page_white1
        Me.Button27.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button27.Location = New System.Drawing.Point(32, 66)
        Me.Button27.Name = "Button27"
        Me.Button27.Size = New System.Drawing.Size(72, 27)
        Me.Button27.TabIndex = 4
        Me.Button27.Text = "Nuevo"
        Me.Button27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button27.UseVisualStyleBackColor = False
        '
        'Button28
        '
        Me.Button28.BackColor = System.Drawing.Color.Transparent
        Me.Button28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button28.Image = Global.LabSys.My.Resources.Resources.application_form_edit
        Me.Button28.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button28.Location = New System.Drawing.Point(32, 99)
        Me.Button28.Name = "Button28"
        Me.Button28.Size = New System.Drawing.Size(72, 27)
        Me.Button28.TabIndex = 5
        Me.Button28.Text = "Modifica"
        Me.Button28.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button28.UseVisualStyleBackColor = False
        '
        'Button29
        '
        Me.Button29.BackColor = System.Drawing.Color.Transparent
        Me.Button29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button29.Image = Global.LabSys.My.Resources.Resources.cross
        Me.Button29.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button29.Location = New System.Drawing.Point(32, 132)
        Me.Button29.Name = "Button29"
        Me.Button29.Size = New System.Drawing.Size(72, 27)
        Me.Button29.TabIndex = 6
        Me.Button29.Text = "Elimina"
        Me.Button29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button29.UseVisualStyleBackColor = False
        '
        'DataGrid15
        '
        Me.DataGrid15.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid15.CaptionVisible = False
        Me.DataGrid15.DataMember = "SUBMUESTRA"
        Me.DataGrid15.DataSource = Me.Cjto_Cotizacion1
        Me.DataGrid15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid15.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid15.Location = New System.Drawing.Point(18, 240)
        Me.DataGrid15.Name = "DataGrid15"
        Me.DataGrid15.Size = New System.Drawing.Size(400, 396)
        Me.DataGrid15.TabIndex = 14
        Me.DataGrid15.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle15})
        '
        'DataGridTableStyle15
        '
        Me.DataGridTableStyle15.DataGrid = Me.DataGrid15
        Me.DataGridTableStyle15.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn84, Me.DataGridTextBoxColumn85, Me.DataGridTextBoxColumn86})
        Me.DataGridTableStyle15.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle15.MappingName = "SUBMUESTRA"
        '
        'DataGridTextBoxColumn84
        '
        Me.DataGridTextBoxColumn84.Format = ""
        Me.DataGridTextBoxColumn84.FormatInfo = Nothing
        Me.DataGridTextBoxColumn84.HeaderText = "Código"
        Me.DataGridTextBoxColumn84.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn84.NullText = ""
        Me.DataGridTextBoxColumn84.Width = 40
        '
        'DataGridTextBoxColumn85
        '
        Me.DataGridTextBoxColumn85.Format = ""
        Me.DataGridTextBoxColumn85.FormatInfo = Nothing
        Me.DataGridTextBoxColumn85.HeaderText = "Sub-Muestra"
        Me.DataGridTextBoxColumn85.MappingName = "SUB_DESCRIPCION"
        Me.DataGridTextBoxColumn85.NullText = ""
        Me.DataGridTextBoxColumn85.Width = 256
        '
        'DataGridTextBoxColumn86
        '
        Me.DataGridTextBoxColumn86.Format = ""
        Me.DataGridTextBoxColumn86.FormatInfo = Nothing
        Me.DataGridTextBoxColumn86.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn86.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn86.NullText = ""
        Me.DataGridTextBoxColumn86.Width = 60
        '
        'DataGrid14
        '
        Me.DataGrid14.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid14.CaptionVisible = False
        Me.DataGrid14.DataMember = "MUESTRA"
        Me.DataGrid14.DataSource = Me.Cjto_Cotizacion1
        Me.DataGrid14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid14.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid14.Location = New System.Drawing.Point(18, 12)
        Me.DataGrid14.Name = "DataGrid14"
        Me.DataGrid14.Size = New System.Drawing.Size(400, 210)
        Me.DataGrid14.TabIndex = 13
        Me.DataGrid14.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle14})
        '
        'DataGridTableStyle14
        '
        Me.DataGridTableStyle14.DataGrid = Me.DataGrid14
        Me.DataGridTableStyle14.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn82, Me.DataGridTextBoxColumn83})
        Me.DataGridTableStyle14.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle14.MappingName = "MUESTRA"
        '
        'DataGridTextBoxColumn82
        '
        Me.DataGridTextBoxColumn82.Format = ""
        Me.DataGridTextBoxColumn82.FormatInfo = Nothing
        Me.DataGridTextBoxColumn82.HeaderText = "Código"
        Me.DataGridTextBoxColumn82.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn82.NullText = ""
        Me.DataGridTextBoxColumn82.Width = 60
        '
        'DataGridTextBoxColumn83
        '
        Me.DataGridTextBoxColumn83.Format = ""
        Me.DataGridTextBoxColumn83.FormatInfo = Nothing
        Me.DataGridTextBoxColumn83.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn83.MappingName = "TMU_MUESTRA"
        Me.DataGridTextBoxColumn83.NullText = ""
        Me.DataGridTextBoxColumn83.Width = 300
        '
        'DataGridTextBoxColumn74
        '
        Me.DataGridTextBoxColumn74.Format = ""
        Me.DataGridTextBoxColumn74.FormatInfo = Nothing
        Me.DataGridTextBoxColumn74.HeaderText = "Cod."
        Me.DataGridTextBoxColumn74.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn74.NullText = ""
        Me.DataGridTextBoxColumn74.Width = 30
        '
        'DataGridTextBoxColumn75
        '
        Me.DataGridTextBoxColumn75.Format = ""
        Me.DataGridTextBoxColumn75.FormatInfo = Nothing
        Me.DataGridTextBoxColumn75.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn75.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn75.NullText = ""
        Me.DataGridTextBoxColumn75.Width = 540
        '
        'DataGridTextBoxColumn76
        '
        Me.DataGridTextBoxColumn76.Format = "#,###,###"
        Me.DataGridTextBoxColumn76.FormatInfo = Nothing
        Me.DataGridTextBoxColumn76.HeaderText = "Valor"
        Me.DataGridTextBoxColumn76.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn76.NullText = ""
        Me.DataGridTextBoxColumn76.Width = 50
        '
        'DataGridTextBoxColumn77
        '
        Me.DataGridTextBoxColumn77.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn77.Format = ""
        Me.DataGridTextBoxColumn77.FormatInfo = Nothing
        Me.DataGridTextBoxColumn77.HeaderText = "Re."
        Me.DataGridTextBoxColumn77.MappingName = "CLIENTE1"
        Me.DataGridTextBoxColumn77.NullText = ""
        Me.DataGridTextBoxColumn77.Width = 26
        '
        'DataGridTextBoxColumn78
        '
        Me.DataGridTextBoxColumn78.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn78.Format = ""
        Me.DataGridTextBoxColumn78.FormatInfo = Nothing
        Me.DataGridTextBoxColumn78.HeaderText = "C-1"
        Me.DataGridTextBoxColumn78.MappingName = "CLIENTE2"
        Me.DataGridTextBoxColumn78.NullText = ""
        Me.DataGridTextBoxColumn78.Width = 27
        '
        'DataGridTextBoxColumn79
        '
        Me.DataGridTextBoxColumn79.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn79.Format = ""
        Me.DataGridTextBoxColumn79.FormatInfo = Nothing
        Me.DataGridTextBoxColumn79.HeaderText = "C-2"
        Me.DataGridTextBoxColumn79.MappingName = "CLIENTE3"
        Me.DataGridTextBoxColumn79.NullText = ""
        Me.DataGridTextBoxColumn79.Width = 27
        '
        'DataGridTextBoxColumn80
        '
        Me.DataGridTextBoxColumn80.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn80.Format = ""
        Me.DataGridTextBoxColumn80.FormatInfo = Nothing
        Me.DataGridTextBoxColumn80.HeaderText = "C-3"
        Me.DataGridTextBoxColumn80.MappingName = "CLIENTET"
        Me.DataGridTextBoxColumn80.NullText = ""
        Me.DataGridTextBoxColumn80.Width = 27
        '
        'DataGridTextBoxColumn116
        '
        Me.DataGridTextBoxColumn116.Format = ""
        Me.DataGridTextBoxColumn116.FormatInfo = Nothing
        Me.DataGridTextBoxColumn116.HeaderText = "Tpo."
        Me.DataGridTextBoxColumn116.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn116.NullText = ""
        Me.DataGridTextBoxColumn116.ReadOnly = True
        Me.DataGridTextBoxColumn116.Width = 30
        '
        'DataGridTextBoxColumn81
        '
        Me.DataGridTextBoxColumn81.Format = ""
        Me.DataGridTextBoxColumn81.FormatInfo = Nothing
        Me.DataGridTextBoxColumn81.HeaderText = "Nivel"
        Me.DataGridTextBoxColumn81.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn81.NullText = ""
        Me.DataGridTextBoxColumn81.Width = 30
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "Cod."
        Me.DataGridTextBoxColumn58.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 35
        '
        'DataGridTextBoxColumn59
        '
        Me.DataGridTextBoxColumn59.Format = ""
        Me.DataGridTextBoxColumn59.FormatInfo = Nothing
        Me.DataGridTextBoxColumn59.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn59.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn59.NullText = ""
        Me.DataGridTextBoxColumn59.Width = 540
        '
        'DataGridTextBoxColumn62
        '
        Me.DataGridTextBoxColumn62.Format = "#,###,###"
        Me.DataGridTextBoxColumn62.FormatInfo = Nothing
        Me.DataGridTextBoxColumn62.HeaderText = "Neto"
        Me.DataGridTextBoxColumn62.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn62.NullText = ""
        Me.DataGridTextBoxColumn62.Width = 50
        '
        'DataGridTextBoxColumn63
        '
        Me.DataGridTextBoxColumn63.Format = ""
        Me.DataGridTextBoxColumn63.FormatInfo = Nothing
        Me.DataGridTextBoxColumn63.HeaderText = "Niv"
        Me.DataGridTextBoxColumn63.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn63.NullText = ""
        Me.DataGridTextBoxColumn63.Width = 25
        '
        'DataGridTextBoxColumn115
        '
        Me.DataGridTextBoxColumn115.Format = ""
        Me.DataGridTextBoxColumn115.FormatInfo = Nothing
        Me.DataGridTextBoxColumn115.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn115.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn115.NullText = ""
        Me.DataGridTextBoxColumn115.Width = 25
        '
        'DataGridTextBoxColumn60
        '
        Me.DataGridTextBoxColumn60.Format = ""
        Me.DataGridTextBoxColumn60.FormatInfo = Nothing
        Me.DataGridTextBoxColumn60.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn60.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn60.NullText = ""
        Me.DataGridTextBoxColumn60.Width = 30
        '
        'DataGridTextBoxColumn61
        '
        Me.DataGridTextBoxColumn61.Format = ""
        Me.DataGridTextBoxColumn61.FormatInfo = Nothing
        Me.DataGridTextBoxColumn61.HeaderText = "SubM"
        Me.DataGridTextBoxColumn61.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn61.NullText = ""
        Me.DataGridTextBoxColumn61.Width = 30
        '
        'CheckBox49
        '
        Me.CheckBox49.ForeColor = System.Drawing.Color.MediumBlue
        Me.CheckBox49.Location = New System.Drawing.Point(632, 16)
        Me.CheckBox49.Name = "CheckBox49"
        Me.CheckBox49.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox49.Size = New System.Drawing.Size(16, 16)
        Me.CheckBox49.TabIndex = 133
        Me.CheckBox49.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label35.Location = New System.Drawing.Point(542, 16)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(100, 16)
        Me.Label35.TabIndex = 134
        Me.Label35.Text = "Formato c/cant"
        '
        'Label72
        '
        Me.Label72.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Black
        Me.Label72.Location = New System.Drawing.Point(917, 50)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(48, 16)
        Me.Label72.TabIndex = 136
        Me.Label72.Text = "Cargo:"
        '
        'TextBox12
        '
        Me.TextBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Cjto_Cotizacion1, "PRODUCTOR1.PRO_ATENCION", True))
        Me.TextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox12.Location = New System.Drawing.Point(964, 49)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(160, 20)
        Me.TextBox12.TabIndex = 179
        '
        'GrbAcceso
        '
        Me.GrbAcceso.Controls.Add(Me.TxtPassword)
        Me.GrbAcceso.Controls.Add(Me.Label150)
        Me.GrbAcceso.Controls.Add(Me.TxtUsuario)
        Me.GrbAcceso.Controls.Add(Me.Label149)
        Me.GrbAcceso.Controls.Add(Me.BTCancelaUsu)
        Me.GrbAcceso.Controls.Add(Me.BTAceptaUsu)
        Me.GrbAcceso.Location = New System.Drawing.Point(122, 551)
        Me.GrbAcceso.Name = "GrbAcceso"
        Me.GrbAcceso.Size = New System.Drawing.Size(312, 176)
        Me.GrbAcceso.TabIndex = 181
        Me.GrbAcceso.TabStop = False
        Me.GrbAcceso.Visible = False
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(120, 64)
        Me.TxtPassword.MaxLength = 20
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(128, 20)
        Me.TxtPassword.TabIndex = 0
        '
        'Label150
        '
        Me.Label150.Location = New System.Drawing.Point(24, 64)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(88, 16)
        Me.Label150.TabIndex = 4
        Me.Label150.Text = "Password"
        '
        'TxtUsuario
        '
        Me.TxtUsuario.Location = New System.Drawing.Point(120, 32)
        Me.TxtUsuario.MaxLength = 25
        Me.TxtUsuario.Name = "TxtUsuario"
        Me.TxtUsuario.Size = New System.Drawing.Size(128, 20)
        Me.TxtUsuario.TabIndex = 3
        '
        'Label149
        '
        Me.Label149.Location = New System.Drawing.Point(24, 32)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(88, 16)
        Me.Label149.TabIndex = 2
        Me.Label149.Text = "Usuario"
        '
        'BTCancelaUsu
        '
        Me.BTCancelaUsu.BackColor = System.Drawing.Color.Transparent
        Me.BTCancelaUsu.Location = New System.Drawing.Point(176, 128)
        Me.BTCancelaUsu.Name = "BTCancelaUsu"
        Me.BTCancelaUsu.Size = New System.Drawing.Size(80, 24)
        Me.BTCancelaUsu.TabIndex = 1
        Me.BTCancelaUsu.Text = "Cancelar"
        Me.BTCancelaUsu.UseVisualStyleBackColor = False
        '
        'BTAceptaUsu
        '
        Me.BTAceptaUsu.BackColor = System.Drawing.Color.Transparent
        Me.BTAceptaUsu.Location = New System.Drawing.Point(64, 128)
        Me.BTAceptaUsu.Name = "BTAceptaUsu"
        Me.BTAceptaUsu.Size = New System.Drawing.Size(80, 24)
        Me.BTAceptaUsu.TabIndex = 0
        Me.BTAceptaUsu.Text = "Aceptar"
        Me.BTAceptaUsu.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button3)
        Me.GroupBox6.Controls.Add(Me.Button40)
        Me.GroupBox6.Controls.Add(Me.Button10)
        Me.GroupBox6.Controls.Add(Me.Label30)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(94, 160)
        Me.GroupBox6.TabIndex = 182
        Me.GroupBox6.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton7)
        Me.GroupBox2.Controls.Add(Me.RadioButton6)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.Label142)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.Label151)
        Me.GroupBox2.Controls.Add(Me.Button21)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(94, 185)
        Me.GroupBox2.TabIndex = 183
        Me.GroupBox2.TabStop = False
        '
        'RadioButton7
        '
        Me.RadioButton7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7.Location = New System.Drawing.Point(16, 126)
        Me.RadioButton7.Name = "RadioButton7"
        Me.RadioButton7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton7.Size = New System.Drawing.Size(56, 14)
        Me.RadioButton7.TabIndex = 9
        Me.RadioButton7.Text = "Todos"
        '
        'RadioButton6
        '
        Me.RadioButton6.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton6.Location = New System.Drawing.Point(8, 106)
        Me.RadioButton6.Name = "RadioButton6"
        Me.RadioButton6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton6.Size = New System.Drawing.Size(64, 16)
        Me.RadioButton6.TabIndex = 8
        Me.RadioButton6.Text = "IFR+IOC"
        Me.RadioButton6.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RadioButton5
        '
        Me.RadioButton5.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton5.Location = New System.Drawing.Point(32, 86)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton5.Size = New System.Drawing.Size(40, 16)
        Me.RadioButton5.TabIndex = 7
        Me.RadioButton5.Text = "IFR"
        Me.RadioButton5.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label142
        '
        Me.Label142.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.Location = New System.Drawing.Point(6, 70)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(64, 12)
        Me.Label142.TabIndex = 6
        Me.Label142.Text = "Individual:"
        '
        'RadioButton4
        '
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(24, 46)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton4.Size = New System.Drawing.Size(48, 16)
        Me.RadioButton4.TabIndex = 5
        Me.RadioButton4.Text = "CFR+COC"
        Me.RadioButton4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'RadioButton3
        '
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(24, 26)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RadioButton3.Size = New System.Drawing.Size(48, 16)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.Text = "CFR"
        Me.RadioButton3.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Label151
        '
        Me.Label151.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label151.Location = New System.Drawing.Point(6, 10)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(66, 12)
        Me.Label151.TabIndex = 3
        Me.Label151.Text = "Combos  :"
        '
        'Label81
        '
        Me.Label81.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label81.Location = New System.Drawing.Point(152, 144)
        Me.Label81.Name = "Label81"
        Me.Label81.Size = New System.Drawing.Size(568, 16)
        Me.Label81.TabIndex = 22
        Me.Label81.Text = "listado de los análisis seleccionados"
        '
        'Label80
        '
        Me.Label80.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label80.Location = New System.Drawing.Point(8, 128)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(136, 16)
        Me.Label80.TabIndex = 21
        Me.Label80.Text = "          Lista $ + Carta  :"
        '
        'Label79
        '
        Me.Label79.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.Location = New System.Drawing.Point(152, 128)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(568, 16)
        Me.Label79.TabIndex = 20
        Me.Label79.Text = "Emite una carta (puede escoger diferentes alternativas de plantillas pre escritas" & _
            ") más un"
        '
        'Label75
        '
        Me.Label75.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label75.Location = New System.Drawing.Point(152, 104)
        Me.Label75.Name = "Label75"
        Me.Label75.Size = New System.Drawing.Size(568, 16)
        Me.Label75.TabIndex = 18
        Me.Label75.Text = "Emite una cotización más el listado de análisis seleccionado"
        '
        'Label77
        '
        Me.Label77.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label77.Location = New System.Drawing.Point(8, 104)
        Me.Label77.Name = "Label77"
        Me.Label77.Size = New System.Drawing.Size(144, 16)
        Me.Label77.TabIndex = 17
        Me.Label77.Text = "          Lista $ + Cotiza :"
        '
        'Label74
        '
        Me.Label74.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label74.Location = New System.Drawing.Point(152, 80)
        Me.Label74.Name = "Label74"
        Me.Label74.Size = New System.Drawing.Size(568, 16)
        Me.Label74.TabIndex = 16
        Me.Label74.Text = "Emite sólo un listado de los análisis seleccionados"
        '
        'Label41
        '
        Me.Label41.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(8, 80)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(144, 16)
        Me.Label41.TabIndex = 15
        Me.Label41.Text = "          Lista $                 :"
        '
        'Label64
        '
        Me.Label64.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(8, 64)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(712, 16)
        Me.Label64.TabIndex = 14
        Me.Label64.Text = "          C-1, C-2, etc.), luego dar click en una de las siguientes opciones : "
        '
        'Label61
        '
        Me.Label61.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label61.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label61.Location = New System.Drawing.Point(0, 0)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(771, 16)
        Me.Label61.TabIndex = 13
        Me.Label61.Text = "Ayuda Lista $"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Transparent
        Me.Button6.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(771, -2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(21, 21)
        Me.Button6.TabIndex = 12
        Me.Button6.Text = "X"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label62
        '
        Me.Label62.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label62.Location = New System.Drawing.Point(8, 48)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(712, 16)
        Me.Label62.TabIndex = 1
        Me.Label62.Text = "          Primero seleccione los tipos de muestra (Foliar, +Tejidos, Agua, Suelo," & _
            " etc.) con el nivel de detalle deseado (Resumen,"
        '
        'Label63
        '
        Me.Label63.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(8, 32)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(712, 16)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "Seleccionar listado"
        '
        'GroupBox23
        '
        Me.GroupBox23.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox23.Controls.Add(Me.Label81)
        Me.GroupBox23.Controls.Add(Me.Label80)
        Me.GroupBox23.Controls.Add(Me.Label79)
        Me.GroupBox23.Controls.Add(Me.Label75)
        Me.GroupBox23.Controls.Add(Me.Label77)
        Me.GroupBox23.Controls.Add(Me.Label74)
        Me.GroupBox23.Controls.Add(Me.Label41)
        Me.GroupBox23.Controls.Add(Me.Label64)
        Me.GroupBox23.Controls.Add(Me.Label61)
        Me.GroupBox23.Controls.Add(Me.Button6)
        Me.GroupBox23.Controls.Add(Me.Label62)
        Me.GroupBox23.Controls.Add(Me.Label63)
        Me.GroupBox23.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox23.Location = New System.Drawing.Point(107, 503)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(792, 176)
        Me.GroupBox23.TabIndex = 120
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 520)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(96, 16)
        Me.Label16.TabIndex = 187
        Me.Label16.Text = "Envio por Email"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label141
        '
        Me.Label141.Font = New System.Drawing.Font("Arial", 7.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label141.Location = New System.Drawing.Point(8, 600)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(100, 23)
        Me.Label141.TabIndex = 188
        Me.Label141.Text = "Carpeta Cotizacion"
        Me.Label141.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBComuna
        '
        Me.CBComuna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBComuna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBComuna.FormattingEnabled = True
        Me.CBComuna.Location = New System.Drawing.Point(423, 73)
        Me.CBComuna.Name = "CBComuna"
        Me.CBComuna.Size = New System.Drawing.Size(157, 21)
        Me.CBComuna.TabIndex = 15
        '
        'CBCiudad
        '
        Me.CBCiudad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.CBCiudad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBCiudad.FormattingEnabled = True
        Me.CBCiudad.Location = New System.Drawing.Point(736, 74)
        Me.CBCiudad.Name = "CBCiudad"
        Me.CBCiudad.Size = New System.Drawing.Size(134, 21)
        Me.CBCiudad.TabIndex = 189
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.Transparent
        Me.Button13.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button13.Location = New System.Drawing.Point(872, 48)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(22, 20)
        Me.Button13.TabIndex = 65
        Me.Button13.UseVisualStyleBackColor = False
        '
        'COTEMP
        '
        Me.COTEMP.BackColor = System.Drawing.Color.Transparent
        Me.COTEMP.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.COTEMP.Image = Global.LabSys.My.Resources.Resources.find
        Me.COTEMP.Location = New System.Drawing.Point(302, 48)
        Me.COTEMP.Name = "COTEMP"
        Me.COTEMP.Size = New System.Drawing.Size(22, 20)
        Me.COTEMP.TabIndex = 64
        Me.COTEMP.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.Transparent
        Me.Button8.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button8.Location = New System.Drawing.Point(627, 47)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(22, 20)
        Me.Button8.TabIndex = 52
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(318, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(24, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Transparent
        Me.Button7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Image = Global.LabSys.My.Resources.Resources.find
        Me.Button7.Location = New System.Drawing.Point(875, 14)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(22, 20)
        Me.Button7.TabIndex = 90
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button25
        '
        Me.Button25.BackColor = System.Drawing.Color.Transparent
        Me.Button25.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button25.Image = Global.LabSys.My.Resources.Resources.arrow_left
        Me.Button25.Location = New System.Drawing.Point(324, 48)
        Me.Button25.Name = "Button25"
        Me.Button25.Size = New System.Drawing.Size(22, 20)
        Me.Button25.TabIndex = 180
        Me.Button25.UseVisualStyleBackColor = False
        '
        'class_COTIZADOR
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1276, 998)
        Me.Controls.Add(Me.GroupBox31)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.GroupBox28)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox30)
        Me.Controls.Add(Me.GroupBox22)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.CBCiudad)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.CBComuna)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Label141)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GrbAcceso)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.Label72)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.CheckBox49)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Button48)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button49)
        Me.Controls.Add(Me.Button46)
        Me.Controls.Add(Me.Button13)
        Me.Controls.Add(Me.COTEMP)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox22)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox16)
        Me.Controls.Add(Me.TextBox14)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox23)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox38)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox23)
        Me.Controls.Add(Me.Button25)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "class_COTIZADOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cotizador"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Cotizacion1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        CType(Me.DataGrid8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage11.ResumeLayout(False)
        Me.TabPage11.PerformLayout()
        CType(Me.DataGrid16, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        CType(Me.DataGrid27, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage12.ResumeLayout(False)
        Me.TabPage12.PerformLayout()
        CType(Me.DataGrid17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage13.ResumeLayout(False)
        Me.TabPage13.PerformLayout()
        CType(Me.DataGrid18, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage15.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox25.ResumeLayout(False)
        Me.GroupBox26.ResumeLayout(False)
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GrbListado.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox28.ResumeLayout(False)
        Me.GroupBox30.ResumeLayout(False)
        Me.GroupBox31.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage18.ResumeLayout(False)
        CType(Me.DataGrid13, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage16.ResumeLayout(False)
        Me.GroupBox27.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.GroupBox18.ResumeLayout(False)
        Me.GroupBox17.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        Me.TabPage19.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DataGrid15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbAcceso.ResumeLayout(False)
        Me.GrbAcceso.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim USU, Pass As String
        Dim MyDate As Date
        Dim fii As Integer
        Dim mycell As New DataGridCell
        'CuentaIntentos = 1
        'GrbAcceso.Visible = True
        'USU = System.Environment.UserName
        'TxtUsuario.Text = USU
        'Call BuscaNivel(USU)
        'TxtPassword.Text = Pass
        'Me.TxtPassword.Focus()
        Cjto_Cotizacion1.Tables("ANALISIS").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_COMUNAS").Clear()
        MyDate = Today
        TextBox3.Text = MyDate
        com_act = "N"
        DEL_GRA = 0
        Carta_Lista = "N"
        DESDE_CONSULTA = 0
        MODIFICA_COMBO = "N"
        ultima_tab = "Cotización"
        carta = 0
        RadioButton1.Checked = True
        RadioButton3.Checked = True
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        'ToolTip1.SetToolTip(Me.DataGrid1, "Eliminar Fila : Doble Click en Columna Cabecera")
        'toolTip1.SetToolTip(Me.checkBox1, "My checkBox1")
        Adap_Man_Ana.Fill(Cjto_Cotizacion1, "ANALISIS")
        Adap_Comunas.Fill(Cjto_Cotizacion1, "COTIZA_COMUNAS")
        'Adap_Comunas1.Fill(Cjto_Cotizacion1, "COTIZA_COMUNAS1")
        Adap_Combo_pro.Fill(Cjto_Cotizacion1, "PRODUCTOR1")
        Adap_Muestra.Fill(Cjto_Cotizacion1, "MUESTRA")
        Call ULTIMA_COTIZA()
        Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = TextBox1.Text
        Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
        Adap_Man_Ann.Fill(Cjto_Cotizacion1, "ANALISIS1")
        Call TRASPASO_ANALISIS()
        Adap_Combo_Ana.Fill(Cjto_Cotizacion1, "COMBO_ANALISIS")
        Adap_Empresa.Fill(Cjto_Cotizacion1, "EMPRESA")
        Adap_Submuestra.Fill(Cjto_Cotizacion1, "SUBMUESTRA")
        Me.Anti_Elimina_lineas()
        AddCellFormattingColumnStyles(Me.DataGrid2, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid4, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid8, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid3, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid16, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid27, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid17, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid18, New FormatCellEventHandler(AddressOf FormatGridCells))
        Me.TransformaMultilinea(Me.DataGrid1)
        'Me.TransformaMultilinea(Me.DataGrid13)
        AddCellFormattingColumnStyles2(Me.DataGrid13, New FormatCellEventHandler(AddressOf FormatGridCells))
        Me.TextBox38.Visible = False
        Me.TextBox39.Visible = False
        Dim tempAdapter As New SqlDataAdapter
        Dim datos As New DataSet
        Dim query As String
        Dim fila As DataRow
        'Me.SqlConnection1.Open()
        query = "select * from cotiza_comunas"
        tempAdapter.SelectCommand = New SqlCommand(query, Me.SqlConnection1)
        tempAdapter.Fill(datos, "Cotiza_comunas")
        Me.CBComuna.SendToBack()
        Me.CBCiudad.SendToBack()
        For Each fila In datos.Tables(0).Rows
            CBComuna.Items.Add(fila("COD_COMUNA"))
            CBCiudad.Items.Add(fila("COD_CIUDAD"))
        Next
        Call ULTIMA_COTIZA_PLA()
        Call MIDE_CONCURRENCIA()
        If concu = "S" Then
            MsgBox("Advertencia : El sistema se encuentra en uso por otro usuario")
        Else
            Call GRABA_CONCURRENCIA("S")
        End If

        'Me.SqlConnection1.Close()
    End Sub

    Private Sub BuscaNivel(ByVal Usu As String)
        Dim myselectquery, consulta_nota As String
        myselectquery = "select USU_USUARIO,MODULO,USU_CLAVE,USU_NOMBRE,NIV_NIVEL FROM NIVEL_USUARIO WHERE USU_USUARIO=" & "'" & TxtUsuario.Text & "'" & " AND MODULO='COTIZADOR'"
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        myReader.Read()
        Try
            Nivel = myReader.GetInt32(4)
            myReader.Close()
            SqlConnection1.Close()
        Catch ex As Exception
        End Try
        myReader.Close()
        SqlConnection1.Close()
    End Sub

    Private Function IsScrollBarVisible(ByVal aControl As Control) As Boolean
        Dim c As Control
        For Each c In aControl.Controls
            If c.GetType() Is GetType(VScrollBar) Then
                Return c.Visible
            End If
        Next
        Return False
    End Function

    Private Sub Anti_Elimina_lineas()
        'tablas muestras
        Me.DataGrid2.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1")
        Me.DataGrid8.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13")
        Me.DataGrid4.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12")
        Me.DataGrid3.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11")
        Me.DataGrid16.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14")
        Me.DataGrid27.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17")
        Me.DataGrid17.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15")
        Me.DataGrid18.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16")
        'tabla cotizacion
        Me.DataGrid1.DataSource = Me.Cjto_Cotizacion1.Tables("COTIZA_DETALLE")
        'tabla listado
        Me.DataGrid13.DataSource = Me.Cjto_Cotizacion1.Tables("ANALISIS")
    End Sub

    Private Sub FormatGridCells(ByVal sender As Object, ByVal e As DataGridFormatCellEventArgs, ByVal grid As DataGrid)
        'color row 1 red
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
            If grid.Name <> "DataGrid13" Then
                If row("ANA_NIVEL_PRECIO") = "COC" Or row("ANA_NIVEL_PRECIO") = "IOC" Then
                    If e.Row = j Then
                        e.BackBrush = System.Drawing.Brushes.SkyBlue
                    End If
                End If
            End If
            If Me.Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Contains(row("ANA_CODIGO")) Or Me.Cjto_Cotizacion1.Tables("MUESTRA").Rows.Contains(row("ANA_CODIGO")) Then
                If (e.Row = j) Then
                    'e.BackBrush = Brushes.Beige
                    e.TextFont = New Font(e.TextFont.Name, 8, FontStyle.Bold)
                End If
            End If
            j += 1
        Next
    End Sub

    Private Sub SelectWholeRow(ByVal sender As Object, ByVal e As EventArgs)
        If (Me.DataGrid2.CurrentRowIndex > -(1)) Then
            Me.DataGrid2.Select(Me.DataGrid2.CurrentRowIndex)
        End If
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
                'Dim cs As DataGridFormattableTextBoxColumn
                cs = New DataGridFormattableTextBoxColumn(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid
                AddHandler cs.SetCellFormat, handler
            Catch ex As Exception
            End Try
            If j >= 3 Then
                Try
                    ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
                Catch ex As Exception
                End Try
            ElseIf j = 2 Then
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
                'Dim cs As DataGridFormattableTextBoxColumn
                cs = New DataGridFormattableTextBoxColumn(j)
                cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
                cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
                cs.grid = grid
                AddHandler cs.SetCellFormat, handler
            Catch ex As Exception
            End Try
            If j >= 2 Then
                Try
                    ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
                Catch ex As Exception
                End Try
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

    Private Sub TransformaMultilinea(ByVal grid As DataGrid)
        Dim ts As DataGridTableStyle
        ts = New DataGridTableStyle
        Dim dt As DataTable
        dt = CType(grid.DataSource, DataTable)
        ts.MappingName = dt.TableName
        Dim j, comp As Integer
        'If grid.Name = "DataGrid1" Then
        '    comp = 2
        'Else
        '    comp = 1
        'End If
        j = 0
        Do While (j < dt.Columns.Count)
            If j <= 2 Then
                Dim cs As New CGridMultiLineTextBoxStyle(grid.TableStyles(0).GridColumnStyles(j).MappingName)
                cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
                cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
                ts.GridColumnStyles.Add(cs)
            Else
                Try
                    ts.GridColumnStyles.Add(grid.TableStyles(0).GridColumnStyles(j))
                Catch ex As Exception
                End Try
            End If
            j = (j + 1)
        Loop
        grid.TableStyles.Clear()
        grid.TableStyles.Add(ts)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.MonthCalendar1.Visible = True
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim RUT_TEX, cade, num As String
        Dim ll, y, cue As Integer
        RUT_TEX = TextBox2.Text
        If e.KeyChar = Chr(13) Then
            If TextBox2.Text = "" Then
                TextBox23.Focus()
            Else
                ll = Len(RUT_TEX)
                cue = 0
                For y = (ll - 1) To 1 Step -1
                    num = Mid(RUT_TEX, y, 1)
                    cue = cue + 1
                    cade = num & cade
                    If (cue Mod 3) = 0 Then cade = "" & cade : cue = 0
                Next
                If Mid(Me.TextBox2.Text, Len(Me.TextBox2.Text) - 1, 1) <> "-" Then
                    cade = cade & "-" & Mid(RUT_TEX, Len(RUT_TEX), 1)
                Else
                    cade = cade & "" & Mid(RUT_TEX, Len(RUT_TEX), 1)
                End If

                TextBox2.Text = cade : RUT_TEX = cade
                Dim myselectquery As String
                myselectquery = "select top 1 PRO_Productor,PRO_EMAIL1,PRO_DIRECCION,Pro_COMUNA,PRO_FONO1,PRO_FAX1 FROM PRODUCTOR_labsys WHERE PRO_RUT =" & "'" & RUT_TEX & "'"
                Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
                SqlConnection1.Open()
                Dim myReader1 As SqlDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)
                Try
                    myReader1.Read()
                    TextBox23.Text = myReader1.GetString(0)
                    TextBox9.Text = myReader1.GetString(1)
                    TextBox7.Text = myReader1.GetString(2)
                    CBComuna.Text = myReader1.GetString(3)
                    TextBox10.Text = myReader1.GetString(4)
                    TextBox11.Text = myReader1.GetString(5)
                    myReader1.Close()
                    SqlConnection1.Close()
                    TextBox22.Focus()
                Catch ex As Exception
                    'TextBox2.Text = ""
                    SqlConnection1.Close()
                    TextBox22.Focus()
                End Try
            End If
        End If
    End Sub

    Private Sub DataGrid5_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim TT As Integer
        Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        hti = myGrid.HitTest(e.X, e.Y)
        Select Case hti.Type
            Case System.Windows.Forms.DataGrid.HitTestType.RowHeader
                Try
                    For TT = 0 To 11
                        If IsDBNull(myGrid.Item(hti.Row, TT)) = True Then myGrid.Item(hti.Row, TT) = ""
                    Next
                    TextBox2.Text = myGrid.Item(hti.Row, 0)
                    TextBox22.Text = myGrid.Item(hti.Row, 1)
                    TextBox23.Text = myGrid.Item(hti.Row, 2)
                    TextBox8.Text = myGrid.Item(hti.Row, 3)
                    TextBox7.Text = myGrid.Item(hti.Row, 4)
                    CBComuna.Text = myGrid.Item(hti.Row, 5)
                    CBCiudad.Text = myGrid.Item(hti.Row, 6)
                    TextBox9.Text = myGrid.Item(hti.Row, 7)
                    TextBox14.Text = myGrid.Item(hti.Row, 8)
                    TextBox10.Text = myGrid.Item(hti.Row, 9)
                    TextBox16.Text = myGrid.Item(hti.Row, 10)
                    TextBox11.Text = myGrid.Item(hti.Row, 11)
                Catch ex As Exception
                End Try
        End Select
        'DataGrid5.Visible = False
        TextBox2.Focus()
    End Sub

    Private Sub Proceso_Impresion()
        Dim FILA_COT, FILA_DETA, fila_cotiza, FILA_BUSCA, fila_combo, fila_sub As DataRow
        Dim carpr, nompr, fuente, destino, fechaf, fcorta, RCOMUNA, RCIUDAD, CCOMUNA, Cargo, NomD As String
        Dim uu, Iva, Total_Cot, A, fila, largo, LARGO_FILA, may, min, i, fila_llave, disminucion, otro, llave_posicion As Integer
        Dim FILA_PARA_PRECIO_F, FILA_PARA_PRECIO_A, FILA_PARA_PRECIO_FR, FILA_PARA_PRECIO_S As Integer
        Dim PASO_FOLIAR, PASO_SUELO, PASO_AGUA, PASO_FRUTO, PASO_FERTQUI, PASO_FERTORG, PASO_OTRO, PASO_VENSER, CEL, MAIL2 As String
        Dim f, largoco, j, k, varmer, INIBOR, FINBOR, l, ultcod, lno, num_com As Integer
        Dim strnot As String
        Dim cnvn As New Coversion1
        PASO_FOLIAR = "N"
        PASO_SUELO = "N"
        PASO_AGUA = "N"
        PASO_FRUTO = "N"
        PASO_FERTQUI = "N"
        PASO_FERTORG = "N"
        PASO_OTRO = "N"
        lno = 0
        ES_SIMPLE = 0
        Dim pix As Double = 12.75
        Dim revcal, cod_aux, cod_ult, suma_pixeles As Double
        Dim BOLA As Object
        Dim valnet As Integer = 0
        Dim ess, otral, mensaje_advertencia As Boolean
        Dim m_outlook As Outlook.Application
        Dim m_Excel As Excel.Application
        Dim respuesta As MsgBoxResult
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim via As String
        Dim EsXls, PUNTOS, PUNTOS_X, nomb, vv As String
        PUNTOS_X = "..........................................................................................................................................................................................."
        If CheckBox49.Checked = True Then PUNTOS_X = ""
        mensaje_advertencia = False
        Suma_Para_Neto = 0
        Call Revisa_Cotizacion_Grabada(mensaje_advertencia)
        'If mensaje_advertencia = True Then
        '    respuesta = MsgBox("Se Sobreescribirá actual archivo generado en Excel.  ¿ Desea Continuar ?", MsgBoxStyle.YesNo)
        '    If respuesta = MsgBoxResult.No Then GoTo noimprime
        'End If
        Call SACA_MUESTRA()
        EsXls = "S"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                EsXls = "N"
                Exit For
            End If
        Next
        If EsXls = "S" Then MUESTRA1 = "XLS" : MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = ""

        Call graba_cotizacion()

        Call graba_Combo_Cotiza()
        Call graba_SQL_Nota()
        Call graba_analisis_desc()

        Call graba_SQL_Cotiza()
        Call graba_SQL_Detalle()

        Call graba_SQL_combo_cotiza()

        Call graba_SQL_cotiza_analisis()
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").AcceptChanges()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").AcceptChanges()
        Cjto_Cotizacion1.Tables("COTIZACION").AcceptChanges()
        Cjto_Cotizacion1.Tables("COMBO_COTIZA").AcceptChanges()
        If mensaje_advertencia = False Then MsgBox("Grabación Finalizada Exitosamente")
        If TextBox22.Text <> "" Then
            nompr = TextBox22.Text
        Else
            nompr = TextBox23.Text
        End If
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        num_com = Val(TextBox1.Text)
        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato_Cotizacion.xls"
        destino = "F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .xls"
        m_Excel = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
            GoTo noimprime
        End Try
        objLibroExcel = m_Excel.Workbooks.Open(fuente)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        BOLA = CDbl(Val(TextBox1.Text))
        FILA_BUSCA = Cjto_Cotizacion1.Tables("COTIZACION").Rows.Find(BOLA)
        Try
            fcorta = Format(FILA_BUSCA("COT_FECHA"), "dd MMMMMMMMMM yyyy")
            largo = Len(fcorta)
            fechaf = Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
            objHojaExcel.Range("X3").Value = fechaf
            objHojaExcel.Range("X3").Font.Size = 10

        Catch ex As Exception
        End Try

        If TxtFirma1.Text <> "" Then
            objHojaExcel.Range("D57:K57").Merge()
            objHojaExcel.Range("D57").Value = TxtFirma1.Text
            objHojaExcel.Range("D57").Font.Size = 10
            objHojaExcel.Range("D57:K57").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If TxtFirma2.Text <> "" Then
            objHojaExcel.Range("D58:K58").Merge()
            objHojaExcel.Range("D58").Value = TxtFirma2.Text
            objHojaExcel.Range("D58").Font.Size = 10
            objHojaExcel.Range("D58:K58").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If TxtFirma3.Text <> "" Then
            objHojaExcel.Range("D59:K59").Merge()
            objHojaExcel.Range("D59").Value = TxtFirma3.Text
            objHojaExcel.Range("D59").Font.Size = 10
            objHojaExcel.Range("D59:K59").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If TxtFirma4.Text <> "" Then
            objHojaExcel.Range("Z57:AG57").Merge()
            objHojaExcel.Range("Z57").Value = TxtFirma4.Text
            objHojaExcel.Range("Z57").Font.Size = 10
            objHojaExcel.Range("Z57:AG57").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If TxtFirma5.Text <> "" Then
            objHojaExcel.Range("Z58:AG58").Merge()
            objHojaExcel.Range("Z58").Value = TxtFirma5.Text
            objHojaExcel.Range("Z58").Font.Size = 10
            objHojaExcel.Range("Z58:AG58").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        If TxtFirma6.Text <> "" Then
            objHojaExcel.Range("Z59:AG59").Merge()
            objHojaExcel.Range("Z59").Value = TxtFirma6.Text
            objHojaExcel.Range("Z59").Font.Size = 10
            objHojaExcel.Range("Z59:AG59").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If

        objHojaExcel.Range("A61:AH61").Merge()
        objHojaExcel.Range("A61").Font.Size = 9
        objHojaExcel.Range("A61").Font.Color = RGB(0, 0, 128)
        objHojaExcel.Range("A61").Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        objHojaExcel.Range("A61:AH61").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter


        If MUESTRA1 = "KIT" Then
            objHojaExcel.Range("Z57").Value = ""
            objHojaExcel.Range("Z58").Value = ""
            objHojaExcel.Range("Z59").Value = ""
            objHojaExcel.Range("D57").Value = ""
            objHojaExcel.Range("D58").Value = ""
            objHojaExcel.Range("D59").Value = ""

            objHojaExcel.Range("D53:K53").Merge()
            objHojaExcel.Range("D53").Value = TxtKFirma1.Text
            objHojaExcel.Range("D53").Font.Size = 10
            objHojaExcel.Range("D53:K53").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            objHojaExcel.Range("D54:K54").Merge()
            objHojaExcel.Range("D54").Value = TxtKFirma2.Text
            objHojaExcel.Range("D54").Font.Size = 10
            objHojaExcel.Range("D54:K54").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            objHojaExcel.Range("D55:K55").Merge()
            objHojaExcel.Range("D55").Value = TxtKFirma3.Text
            objHojaExcel.Range("D55").Font.Size = 10
            objHojaExcel.Range("D55:K55").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If


        objHojaExcel.Range("A6").Value = "Señor(es):"
        objHojaExcel.Range("A6").Font.Size = 10
        objHojaExcel.Range("AB4").Value = "Cot/" & TextBox1.Text
        l = 7
        'suma_pixeles = 89.25
        suma_pixeles = 89.25 + 12.75


        Try
            If FILA_BUSCA("COT_EMPRESA") <> "" Then
                objHojaExcel.Range("A" & l.ToString).Value = FILA_BUSCA("COT_EMPRESA")
                objHojaExcel.Range("A" & l.ToString).Font.Bold = True
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
                GoTo nopodu
            End If
            objHojaExcel.Range("A" & l.ToString).Value = FILA_BUSCA("COT_NOMBRE")
            objHojaExcel.Range("A" & l.ToString).Font.Bold = True
            objHojaExcel.Range("A" & l.ToString).Font.Size = 10

        Catch ex As Exception
        End Try
nopodu:
        MAIL2 = ""


        Try
            If FILA_BUSCA("COT_EMAIL2") <> "" And IsDBNull(FILA_BUSCA("COT_EMAIL2")) = False Then
                MAIL2 = FILA_BUSCA("COT_EMAIL2")
                MAIL2 = " ; " & MAIL2
            End If
        Catch ex As Exception
        End Try



        Try
            If IsDBNull(FILA_BUSCA("COT_EMAIL")) = False And FILA_BUSCA("COT_EMAIL") <> "" Then
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                objHojaExcel.Range("D" & l.ToString).Value = ": " & FILA_BUSCA("COT_EMAIL") & MAIL2
                objHojaExcel.Range("D" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Value = "e-mail"
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try


        Try
            CEL = FILA_BUSCA("COT_CELULAR")
            CEL = " /" & CEL
        Catch ex As Exception
        End Try


        If CEL = " /" Then CEL = ""
        Try
            If IsDBNull(FILA_BUSCA("COT_FONO")) = False And FILA_BUSCA("COT_FONO") <> "" Then
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                objHojaExcel.Range("D" & l.ToString).Value = ": " & FILA_BUSCA("COT_FONO") & CEL
                objHojaExcel.Range("D" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Value = "Fono"
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
            ElseIf CEL <> "" Then
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                objHojaExcel.Range("D" & l.ToString).Value = ": " & Mid(CEL, 3)
                objHojaExcel.Range("D" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Value = "Celular"
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try

        Try
            If IsDBNull(FILA_BUSCA("COT_FAX")) = False And FILA_BUSCA("COT_FAX") <> "" Then
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                objHojaExcel.Range("D" & l.ToString).Value = ": " & FILA_BUSCA("COT_FAX")
                objHojaExcel.Range("D" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Value = "Fax"
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try



        Try
            RCIUDAD = FILA_BUSCA("COT_CIUDAD")
        Catch ex As Exception
        End Try

        Try
            RCOMUNA = FILA_BUSCA("COT_COMUNA")
        Catch ex As Exception
        End Try



        Try
            If IsDBNull(FILA_BUSCA("COT_DIRECCION")) = False And FILA_BUSCA("COT_DIRECCION") <> "" Then
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                NomD = FILA_BUSCA("COT_DIRECCION") : cnvn.Minuscula(NomD)
                If RCOMUNA <> "" And RCOMUNA <> RCIUDAD And RCIUDAD <> "" Then
                    nomb = FILA_BUSCA("COT_COMUNA") : cnvn.Minuscula(nomb)
                    objHojaExcel.Range("A" & l.ToString).Value = NomD & ", " & nomb
                Else
                    objHojaExcel.Range("A" & l.ToString).Value = NomD
                End If
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try



        Try
            If RCIUDAD = RCOMUNA Or RCIUDAD = "" Then
                RCOMUNA = FILA_BUSCA("COT_COMUNA")
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                nomb = FILA_BUSCA("COT_COMUNA")
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & l.ToString).Value = nomb
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Font.Underline = True
            Else
                RCIUDAD = FILA_BUSCA("COT_CIUDAD")
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                nomb = FILA_BUSCA("COT_CIUDAD")
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & l.ToString).Value = nomb
                objHojaExcel.Range("A" & l.ToString).Font.Size = 10
                objHojaExcel.Range("A" & l.ToString).Font.Underline = True
            End If
        Catch ex As Exception
        End Try

        Try
            Cargo = ""
            nomb = FILA_BUSCA("COT_ATENCION")
            If nomb <> "" Then
                Call control_nombre(nomb)
                objHojaExcel.Range("U" & l.ToString & ":AH" & l.ToString).Merge()
                objHojaExcel.Range("U" & l.ToString).Value = "At. : " & nomb
                objHojaExcel.Range("U" & l.ToString).Font.Size = 10
                objHojaExcel.Range("U" & l.ToString & ":AH" & l.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
            If IsDBNull(FILA_BUSCA("COT_CARGO")) = False Then Cargo = FILA_BUSCA("COT_CARGO")
            If Cargo <> "" Then
                Call control_nombre(Cargo)
                l = l + 1
                suma_pixeles = suma_pixeles + pix
                objHojaExcel.Range("R" & l.ToString & ":AH" & l.ToString).Merge()
                objHojaExcel.Range("R" & l.ToString).Value = Cargo
                objHojaExcel.Range("R" & l.ToString).Font.Size = 10
                objHojaExcel.Range("R" & l.ToString & ":AH" & l.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        Catch ex As Exception

        End Try




        If Cargo = "" Then l = l + 2 : suma_pixeles = suma_pixeles + (pix * 2) Else l = l + 1 : suma_pixeles = suma_pixeles + pix
        j = l
        vv = "                                                                                                                           "
        objHojaExcel.Range("A" & j.ToString).Value = "De nuestra consideracion:"
        objHojaExcel.Range("A" & j.ToString).Font.Size = 10
        j = j + 1
        suma_pixeles = suma_pixeles + pix
        If MUESTRA1 = "KIT" Then
            Call impsep_notas(suma_pixeles, pix, objHojaExcel, j, RichTextBox1.Text)
        Else
            Call impsep_notas(suma_pixeles, pix, objHojaExcel, j, RTxtAlto.Text)
        End If
        'If lno = 0 Then MsgBox("Falta Nota de encabezado , por favor ingresela") : GoTo noimprime
        j = j + 1
        suma_pixeles = suma_pixeles + pix
        INIBOR = j
        If CheckBox49.Checked = False Then
            objHojaExcel.Range("A" & j.ToString & ":AD" & j.ToString).Merge()
            objHojaExcel.Range("A" & j.ToString).Value = "Descripción"
            objHojaExcel.Range("A" & j.ToString).Font.Bold = True
            objHojaExcel.Range("A" & j.ToString).Font.Size = 10

            objHojaExcel.Range("AE" & j.ToString).Value = "$"
            objHojaExcel.Range("AE" & j.ToString).Font.Bold = True
            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
            objHojaExcel.Range("AF" & j.ToString).Value = "Neto (c/u)"
            objHojaExcel.Range("AF" & j.ToString).Font.Bold = True
        Else
            objHojaExcel.Range("A" & j.ToString & ":Z" & j.ToString).Merge()
            objHojaExcel.Range("A" & j.ToString).Value = "Descripción"
            objHojaExcel.Range("A" & j.ToString).Font.Bold = True
            objHojaExcel.Range("A" & j.ToString).Font.Size = 8.5

            objHojaExcel.Range("AA" & j.ToString & ":AB" & j.ToString).Merge()
            objHojaExcel.Range("AA" & j.ToString).Value = "Cant"
            objHojaExcel.Range("AA" & j.ToString).Font.Bold = True
            objHojaExcel.Range("AA" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AA" & j.ToString & ":AB" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).Merge()
            objHojaExcel.Range("AC" & j.ToString).Value = "$ Unitario"
            objHojaExcel.Range("AC" & j.ToString).Font.Bold = True
            objHojaExcel.Range("AC" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
            objHojaExcel.Range("AF" & j.ToString).Value = "$ Total"
            objHojaExcel.Range("AF" & j.ToString).Font.Bold = True
            objHojaExcel.Range("AF" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            objHojaExcel.Range("A" & j.ToString & ":AH" & j.ToString).BorderAround()
        End If
        '
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
        Me.SqlSelectCommand12.Parameters("@NUMERO_COT").Value = CDbl(TextBox1.Text)
        Adap_Con_Det.Fill(Cjto_Cotizacion1, "COTIZA_DETALLE1")
        For Each FILA_COT In Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Rows
            FILA_DETA = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
            FILA_DETA.BeginEdit()
            FILA_DETA.Item("COT_NUMERO") = CDbl(TextBox1.Text)
            FILA_DETA.Item("CTD_ANALISIS") = FILA_COT("CTD_ANALISIS")
            FILA_DETA.Item("CTD_CANTIDAD") = FILA_COT("CTD_CANTIDAD")
            FILA_DETA.Item("CTD_UNITARIO") = FILA_COT("CTD_UNITARIO")
            FILA_DETA.Item("CTD_SUBTOTAL") = FILA_COT("CTD_SUBTOTAL")
            FILA_DETA.Item("CTD_DESCUENTO") = FILA_COT("CTD_DESCUENTO")
            FILA_DETA.Item("CTD_TOTAL") = FILA_COT("CTD_TOTAL")
            FILA_DETA.Item("ANA_ANALISIS") = FILA_COT("ANA_ANALISIS")
            FILA_DETA.Item("CTD_MUESTRA") = FILA_COT("CTD_MUESTRA")
            FILA_DETA.EndEdit()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_DETA)
        Next
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").AcceptChanges()
        cod_ult = 0
        For Each FILA_COT In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            cod_aux = FILA_COT("CTD_ANALISIS")
            If cod_aux > cod_ult Then cod_ult = cod_aux
        Next
        '************** FOLIAR *******************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N" : Es_Combo_Cot = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 1 Then
                    PASO_FOLIAR = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub2
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub2:
                    Es_SubMuestra = "N"
                End If
            End If
        Next
        ' 
        '************** FRUTO *******************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 2 Then
                    otral = False
                    If PASO_FOLIAR = "S" Then otral = True
                    PASO_FRUTO = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub4
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub4:
                    Es_SubMuestra = "N"
                End If
            End If
        Next
        ' 
        '************** AGUA *******************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows()
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 3 Then
                    otral = False
                    If PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Then otral = True
                    PASO_FRUTO = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub3
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub3:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        '
        ' ******************* SUELO *************************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 4 Then
                    If PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Or PASO_AGUA = "S" Then otral = True
                    PASO_SUELO = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub1
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub1:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        '
        ' ******************* FETILIZANTE QUIMICO *************************
        '
        ' **** DETALLE
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 5 Then
                    otral = False
                    If PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Or PASO_AGUA = "S" Or PASO_SUELO = "S" Then otral = True
                    PASO_FERTQUI = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo subQUI
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
subQUI:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        '
        ' ******************* FETILIZANTE ORGANICO *************************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 6 Then
                    otral = False
                    If PASO_FERTQUI = "S" Or PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Or PASO_AGUA = "S" Or PASO_SUELO = "S" Then otral = True
                    PASO_FERTORG = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub5
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub5:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        '
        ' ******************* OTROS ANALISIS *************************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 7 Then
                    otral = False
                    If PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Or PASO_AGUA = "S" Or PASO_FERTQUI = "S" Or PASO_FERTORG = "S" Then otral = True
                    PASO_OTRO = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub6
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub6:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        '
        ' ******************* KIT-SER *************************
        '
        ' **** DETALLE 
        otral = False : Es_SubMuestra = "N"
        For Each fila_cotiza In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            If fila_cotiza.RowState <> DataRowState.Deleted Then
                If Val(Mid(fila_cotiza("CTD_ANALISIS"), 1, 1)) = 8 Then
                    otral = False
                    If PASO_FOLIAR = "S" Or PASO_FRUTO = "S" Or PASO_AGUA = "S" Or PASO_FERTQUI = "S" Or PASO_FERTORG = "S" Or PASO_OTRO = "S" Then otral = True
                    PASO_VENSER = "S"
                    ess = False
                    Call LISTA_CODIGO_M_S(otral, pix, suma_pixeles, j, fila_cotiza("CTD_ANALISIS"), ess, objHojaExcel)
                    If ess = True Then GoTo sub7
                    Call IMPRIME_LINEA_COTIZACION(fila_cotiza, cod_ult, objHojaExcel, j, suma_pixeles, pix)
sub7:
                    Es_SubMuestra = "N"
                End If
            End If
            'suma_pixeles = suma_pixeles + pix
            'A = 0
        Next
        Cjto_Cotizacion1.Tables("LISTADO_DETALLE").Clear()
        DEL_GRA = 1
        ' 
        ' ********* NOTAS FINALES *******
        '
        If Es_Combo_Cot = "S" Then j = j - 1
        FINBOR = j
        If CheckBox49.Checked = False Then Call BORDES(objHojaExcel, INIBOR, FINBOR)
        If CheckBox49.Checked = True Then
            j = j + 1 : suma_pixeles += pix
            FINBOR = j
            Call BORDES_KIT(objHojaExcel, INIBOR, FINBOR)
            j = j + 1 : suma_pixeles += pix
            'NETO
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).Merge()
            objHojaExcel.Range("AC" & j.ToString).Value = "NETO      $"
            objHojaExcel.Range("AC" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
            objHojaExcel.Range("AF" & j.ToString).Value = Format(Suma_Para_Neto, "##,###,###")
            objHojaExcel.Range("AF" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            With objHojaExcel.Range("AC" & j.ToString & ":AH" & j.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            'IVA 19%
            j = j + 1 : suma_pixeles += pix
            Iva = Suma_Para_Neto * 0.19
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).Merge()
            objHojaExcel.Range("AC" & j.ToString).Value = "IVA 19% $"
            objHojaExcel.Range("AC" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
            objHojaExcel.Range("AF" & j.ToString).Value = Format(Iva, "##,###,###")
            objHojaExcel.Range("AF" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            With objHojaExcel.Range("AC" & j.ToString & ":AH" & j.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            'TOTAL
            j = j + 1 : suma_pixeles += pix
            Total_Cot = Suma_Para_Neto + Iva
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).Merge()
            objHojaExcel.Range("AC" & j.ToString).Value = "TOTAL    $"
            objHojaExcel.Range("AC" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AC" & j.ToString).Font.Bold = True
            objHojaExcel.Range("AC" & j.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight

            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).Merge()
            objHojaExcel.Range("AF" & j.ToString).Value = Format(Total_Cot, "##,###,###")
            objHojaExcel.Range("AF" & j.ToString).Font.Size = 8.5
            objHojaExcel.Range("AF" & j.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            objHojaExcel.Range("AH:AH").ColumnWidth = 2.29
            objHojaExcel.Range("AF" & j.ToString).Font.Bold = True

            objHojaExcel.Range("AC" & (FINBOR + 1).ToString & ":AE" & j.ToString).BorderAround()
            objHojaExcel.Range("AF" & (FINBOR + 1).ToString & ":AH" & j.ToString).BorderAround()


            'objHojaExcel.Range("AA" & FILA_PARA_PRECIO_F.ToString & ":AB" & FILA_PARA_PRECIO_F.ToString).NumberFormat = "####"
        End If
        If MUESTRA1 = "KIT" Then
            If RichTextBox3.Text.Length > 0 Then
                j = j + 2
                suma_pixeles = suma_pixeles + (pix * 2)
            End If
            Call impsep_notas(suma_pixeles, pix, objHojaExcel, j, RichTextBox3.Text)

        Else
            If RTxtMedio.Text.Length > 0 Then
                j = j + 2
                suma_pixeles = suma_pixeles + (pix * 2)
            Else
                j += 1
                suma_pixeles += pix
            End If
            Call impsep_notas(suma_pixeles, pix, objHojaExcel, j, RTxtMedio.Text)

            If RTxtMedio.Text.Length > 0 Then
                j = j + 1
                suma_pixeles = suma_pixeles + pix
            End If
            Call impsep_notas(suma_pixeles, pix, objHojaExcel, j, RTxtBajo.Text)

        End If

        If cotiza_listado = "S" Then Call Inicio_Imprime_Lista(objHojaExcel, False, False)
        Try
            objHojaExcel.SaveAs("F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .xls")
        Catch ex As Exception
            objLibroExcel.Close(False, , )
            m_Excel.Quit()
        End Try
noimprime:

    End Sub

    Private Sub impsep_notas(ByRef suma_pixeles As Integer, ByVal pix As Integer, ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByVal query As String)
        Dim temp, temp2, acumula As String
        Dim i, concar, fila_inicial As Integer
        concar = 0
        fila_inicial = j
        For i = 1 To query.Length
            temp = Mid(query, i, 1)
            If Asc(temp) = 10 Or concar = 100 Then
                j = j + 1
                suma_pixeles = suma_pixeles + pix
                concar = 0
            End If
            concar = concar + 1
        Next
        If query.Length > 0 Then
            HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":AH" & j.ToString).Merge()
            HOJA_EXCEL.Range("A" & fila_inicial.ToString).Value = query
            HOJA_EXCEL.Range("A" & fila_inicial.ToString).Font.Size = 10
            HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
        End If
    End Sub

    Private Sub impsep_notas_Planilla(ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByVal query As String)
        Dim temp, temp2, acumula As String
        Dim i, concar, fila_inicial, sw As Integer
        concar = 0
        sw = 0
        fila_inicial = j + 1
        temp2 = ""
        For i = 1 To query.Length
            temp = Mid(query, i, 1)
            If Asc(temp) = 10 Then
                'If sw = 1 Then
                '    j -= 1
                'End If
                HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":AH" & j.ToString).Merge()
                HOJA_EXCEL.Range("A" & fila_inicial.ToString).Value = temp2
                HOJA_EXCEL.Range("A" & fila_inicial.ToString).Font.Size = 10
                HOJA_EXCEL.Range("A" & fila_inicial.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignJustify
                temp2 = ""
                j = j + 1
                fila_inicial = j
                sw = 0
            End If
            If concar = 80 Then
                j = j + 1
                concar = 0
                sw = 1
            End If
            concar = concar + 1
            temp2 = temp2 + temp
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If concu = "S" Then MsgBox("Imposible grabar, existe otro usuario en el sistema") : GoTo NOO
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo NOO
        Call Proceso_Impresion()
NOO:
    End Sub

    Private Sub ORDENA_GRILLA(ByVal sortedView As DataView)
        Dim FILA1, FILA_ORD, FILA2, FILA_A As DataRow
        Dim codi, men, MATRIZ(30) As Double
        Dim BOLA1 As Object
        Dim nuepe, FREC_AUX As String
        Dim TT, J, K As Integer
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE_ORD").Clear()
        For Each FILA1 In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
            BOLA1 = FILA1("CTD_ANALISIS")
            FILA_A = Cjto_Cotizacion1.Tables("ANALISIS").Rows.Find(BOLA1)
            FILA_ORD = Cjto_Cotizacion1.Tables("COTIZA_DETALLE_ORD").NewRow
            FILA_ORD.Item("CTD_ANALISIS") = FILA1("CTD_ANALISIS")
            FILA_ORD.Item("CTD_CANTIDAD") = FILA1("CTD_CANTIDAD")
            FILA_ORD.Item("CTD_UNITARIO") = FILA1("CTD_UNITARIO")
            FILA_ORD.Item("CTD_SUBTOTAL") = FILA1("CTD_SUBTOTAL")
            FILA_ORD.Item("CTD_DESCUENTO") = FILA1("CTD_DESCUENTO")
            FILA_ORD.Item("CTD_TOTAL") = FILA1("CTD_TOTAL")
            FILA_ORD.Item("ANA_ANALISIS") = FILA1("ANA_ANALISIS")
            FILA_ORD.Item("CTD_MUESTRA") = FILA1("CTD_MUESTRA")
            FILA_ORD.Item("ANA_NIVEL_PRECIO") = FILA_A("ANA_NIVEL_PRECIO")
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE_ORD").Rows.Add(FILA_ORD)
        Next
        sortedView.Sort = "ANA_NIVEL_PRECIO ASC"
    End Sub

    Public Sub LISTA_CODIGO_M_S(ByVal otral As Boolean, ByRef pix As Double, ByRef suma_pixeles As Double, ByRef li As Integer, ByVal CODIGO_MS As Double, ByRef ess As Boolean, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim FILA_LI, FILA_D, FILA_AG, FILA_ANA, FILA_DET, FILA_MU, FILA_SUB As DataRow
        Dim BOLA, BOLAS(1), BOL As Object
        Try
            BOLA = CODIGO_MS
            FILA_ANA = Cjto_Cotizacion1.Tables("ANALISIS").Rows.Find(BOLA)

            BOLA = FILA_ANA("TMU_CODIGO")
            FILA_MU = Cjto_Cotizacion1.Tables("MUESTRA").Rows.Find(BOLA)

            If Not (FILA_MU Is Nothing) Then
                BOLAS(0) = CDbl(TextBox1.Text)
                BOLAS(1) = FILA_MU("TMU_CODIGO")
                FILA_DET = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLAS)
                BOL = FILA_MU("TMU_CODIGO")
                FILA_LI = Cjto_Cotizacion1.Tables("LISTADO_DETALLE").Rows.Find(BOL)

                If (FILA_LI Is Nothing) Then
                    If Not (FILA_DET Is Nothing) Then ess = True
                    If FILA_MU("TMU_CODIGO") <> 8000 Then
                        If otral = True And Es_Combo_Cot = "N" Then
                            li = li + 1 : suma_pixeles = suma_pixeles + pix
                            If CheckBox49.Checked = True Then BORDES_KIT_SUAVES(HOJA_EXCEL, li)
                            li = li + 1 : suma_pixeles = suma_pixeles + pix
                        Else
                            li = li + 1 : suma_pixeles = suma_pixeles + pix
                        End If
                        HOJA_EXCEL.Range("A" & li.ToString).Value = FILA_MU("TMU_MUESTRA")
                        HOJA_EXCEL.Range("A" & li.ToString).Font.Bold = True
                        HOJA_EXCEL.Range("A" & li.ToString).Font.Size = 9
                        If CheckBox49.Checked = True Then BORDES_KIT_SUAVES(HOJA_EXCEL, li)
                    End If
                    FILA_D = Cjto_Cotizacion1.Tables("LISTADO_DETALLE").NewRow
                    FILA_D.Item("ANA_CODIGO") = FILA_MU("TMU_CODIGO")
                    Cjto_Cotizacion1.Tables("LISTADO_DETALLE").Rows.Add(FILA_D)
                    Es_SubMuestra = "S" : Es_Combo_Cot = "S"
                    ES_SIMPLE = 0
                    otral = True
                End If
            End If

            BOLA = FILA_ANA("SUB_CODIGO")
            FILA_SUB = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(BOLA)

            If Not (FILA_SUB Is Nothing) Then
                BOLAS(0) = CDbl(TextBox1.Text)
                BOLAS(1) = FILA_SUB("SUB_CODIGO")
                FILA_DET = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLAS)
                BOL = FILA_SUB("SUB_CODIGO")
                FILA_LI = Cjto_Cotizacion1.Tables("LISTADO_DETALLE").Rows.Find(BOL)
                If (FILA_LI Is Nothing) Then
                    If Not (FILA_DET Is Nothing) Then ess = True
                    If otral = False Then
                        li = li + 1 : suma_pixeles = suma_pixeles + pix
                        If CheckBox49.Checked = True Then Call BORDES_KIT_SUAVES(HOJA_EXCEL, li)
                        li = li + 1 : suma_pixeles = suma_pixeles + pix
                    Else
                        li = li + 1 : suma_pixeles = suma_pixeles + pix
                    End If
                    HOJA_EXCEL.Range("A" & li.ToString).Value = " " & FILA_SUB("SUB_DESCRIPCION")
                    HOJA_EXCEL.Range("A" & li.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & li.ToString).Font.Size = 9
                    If CheckBox49.Checked = True Then BORDES_KIT_SUAVES(HOJA_EXCEL, li)
                    FILA_DET = Cjto_Cotizacion1.Tables("LISTADO_DETALLE").NewRow()
                    FILA_DET.Item("ANA_CODIGO") = FILA_SUB("SUB_CODIGO")
                    Cjto_Cotizacion1.Tables("LISTADO_DETALLE").Rows.Add(FILA_DET)
                    Es_SubMuestra = "S" : Es_Combo_Cot = "S"
                    ES_SIMPLE = 0
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Function conneg(ByVal fila_cc As DataRow, ByVal wwo As Word.Document, ByVal ff As Integer, ByVal nume As Integer) As Boolean
        Dim AGROLAB As String = "AGROLAB LTDA." '13
        Dim FONO As String = "fono 2258087" '12
        Dim BANCO As String = "Banco de Chile. Cuenta Nº 160-68652-00" '38
        Dim Texto, Completo As String
        Dim NEGRA As Boolean = False
        Dim posicion1, posicion2, posicion3 As Integer
        Texto = fila_cc("NOT_NOTAS")
        posicion1 = Texto.IndexOf(AGROLAB)
        posicion2 = Texto.IndexOf(FONO)
        posicion3 = Texto.IndexOf(BANCO)
        If nume = 2 Then
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 1, 101))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed

            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(" " & AGROLAB)
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = True

            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 114, 29))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            'wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = False

            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(" " & FONO)
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            'wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = True

            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 153))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            'wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = False
            NEGRA = True
        End If
        If nume = 25 Then
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 1, 44))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(" " & BANCO)
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = True
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 83, 13))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = False
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(" " & AGROLAB)
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = True
            wwo.Tables.Item(3).Cell(ff, 1).Range.InsertAfter(Mid(fila_cc("NOT_NOTAS"), 109))
            wwo.Tables.Item(3).Cell(ff, 1).Range.Paragraphs.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustifyMed
            wwo.Tables.Item(3).Cell(ff, 1).Range.Font.Bold = False
            NEGRA = True
        End If
        Return NEGRA
    End Function

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.SqlSelectCommand9.Parameters("@PRO_RUT").Value = TextBox2.Text & "%"
        Me.SqlSelectCommand9.Parameters("@PRO_NOMBRE").Value = TextBox2.Text & "%"
        Call cambio_color_boton()
        'Button7.BackColor = Color.FromName("Info")
        Cjto_Cotizacion1.Tables("PRODUCTOR").Clear()
        Adap_Productor.Fill(Cjto_Cotizacion1, "PRODUCTOR")
        'DataGrid5.Visible = True
        'DataGrid5.Focus()
    End Sub

    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid2.CurrentCell.RowNumber
        If DataGrid2.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid23.Visible = True
            GoTo yam
        End If
        If TextBox15.Visible = True Then TextBox15.Visible = False
        If DataGrid2.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid2.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid2.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid2.GetCellBounds(DataGrid2.CurrentCell.RowNumber, DataGrid2.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid2.GetCellBounds(DataGrid2.CurrentCell.RowNumber, DataGrid2.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid2.GetCellBounds(DataGrid2.CurrentCell.RowNumber, DataGrid2.CurrentCell.ColumnNumber).X + DataGrid2.Left
        Dim Posiciony As Integer = DataGrid2.GetCellBounds(DataGrid2.CurrentCell.RowNumber, DataGrid2.CurrentCell.ColumnNumber).Y + DataGrid2.Top
        TextBox15.Left = Posicionx
        TextBox15.Top = Posiciony
        TextBox15.Height = CeldaAlto
        TextBox15.Width = CeldaAncho
        TextBox15.Visible = True
        TextBox15.Text = ""
        TextBox15.Enabled = True
        TextBox15.Focus()
        TextBox15.SelectionStart = 1
        If IsDBNull(DataGrid2.Item(FILA_DATA, 4)) = False Then TextBox15.Text = DataGrid2.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid2.Item(FILA_DATA, 5)) = False Then TextBox15.Text = DataGrid2.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub TextBox15_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox15.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox15.Text <> "" Then
                        NETO = CInt(DataGrid2.Item(FILA_DATA, 3))
                        DataGrid2.Item(FILA_DATA, 4) = TextBox15.Text
                        DESCUENTO = (CDbl(DataGrid2.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid2.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid2.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox15.Text <> "" Then
                        DataGrid2.Item(FILA_DATA, 5) = TextBox15.Text
                        RESTA = CInt(DataGrid2.Item(FILA_DATA, 3)) - CInt(DataGrid2.Item(FILA_DATA, 5))
                        NET = DataGrid2.Item(FILA_DATA, 3)
                        DataGrid2.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid2.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox15_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.GotFocus
        TextBox15.SelectionStart = 1
    End Sub

    Private Sub DataGrid2_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid2.DoubleClick
        'Dim respuesta As MsgBoxResult
        'Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO, FILA_COTDET As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL, fila As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum, Obje(1) As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "2" Then MUESTRA = "FRUTO"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            'AddHandler myGrid.Paint, AddressOf DATAGRID2_Paint
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub DataGrid18_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid18.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid18.CurrentCell.RowNumber
        If DataGrid18.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid21.Visible = True
            GoTo yam
        End If
        If TextBox31.Visible = True Then TextBox31.Visible = False
        If DataGrid18.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid18.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid18.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid18.GetCellBounds(DataGrid18.CurrentCell.RowNumber, DataGrid18.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid18.GetCellBounds(DataGrid18.CurrentCell.RowNumber, DataGrid18.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid18.GetCellBounds(DataGrid18.CurrentCell.RowNumber, DataGrid18.CurrentCell.ColumnNumber).X + DataGrid18.Left
        Dim Posiciony As Integer = DataGrid18.GetCellBounds(DataGrid18.CurrentCell.RowNumber, DataGrid18.CurrentCell.ColumnNumber).Y + DataGrid18.Top
        TextBox31.Left = Posicionx
        TextBox31.Top = Posiciony
        TextBox31.Height = CeldaAlto
        TextBox31.Width = CeldaAncho
        TextBox31.Visible = True
        TextBox31.Text = ""
        TextBox31.Enabled = True
        TextBox31.Focus()
        TextBox31.SelectionStart = 1
        If IsDBNull(DataGrid18.Item(FILA_DATA, 4)) = False Then TextBox31.Text = DataGrid18.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid18.Item(FILA_DATA, 5)) = False Then TextBox31.Text = DataGrid18.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub TextBox31_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox31.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox31.Text <> "" Then
                        NETO = CInt(DataGrid18.Item(FILA_DATA, 3))
                        DataGrid18.Item(FILA_DATA, 4) = TextBox31.Text
                        DESCUENTO = (CDbl(DataGrid18.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid18.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid18.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox31.Text <> "" Then
                        DataGrid18.Item(FILA_DATA, 5) = TextBox31.Text
                        RESTA = CInt(DataGrid18.Item(FILA_DATA, 3)) - CInt(DataGrid18.Item(FILA_DATA, 5))
                        NET = DataGrid18.Item(FILA_DATA, 3)
                        DataGrid18.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid18.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox31_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.GotFocus
        TextBox31.SelectionStart = 1
    End Sub

    Private Sub DataGrid18_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid18.DoubleClick
        'Dim respuesta As MsgBoxResult
        'Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "8" Then MUESTRA = "KIT,OTROS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            'AddHandler myGrid.Paint, AddressOf DATAGRID2_Paint
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub DataGrid16_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid16.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid16.CurrentCell.RowNumber
        If DataGrid16.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid12.Visible = True
            GoTo yam
        End If
        If TextBox29.Visible = True Then TextBox29.Visible = False
        If DataGrid16.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid16.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid16.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid16.GetCellBounds(DataGrid16.CurrentCell.RowNumber, DataGrid16.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid16.GetCellBounds(DataGrid16.CurrentCell.RowNumber, DataGrid16.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid16.GetCellBounds(DataGrid16.CurrentCell.RowNumber, DataGrid16.CurrentCell.ColumnNumber).X + DataGrid16.Left
        Dim Posiciony As Integer = DataGrid16.GetCellBounds(DataGrid16.CurrentCell.RowNumber, DataGrid16.CurrentCell.ColumnNumber).Y + DataGrid16.Top
        TextBox29.Left = Posicionx
        TextBox29.Top = Posiciony
        TextBox29.Height = CeldaAlto
        TextBox29.Width = CeldaAncho
        TextBox29.Visible = True
        TextBox29.Text = ""
        TextBox29.Enabled = True
        TextBox29.Focus()
        TextBox29.SelectionStart = 1
        If IsDBNull(DataGrid16.Item(FILA_DATA, 4)) = False Then TextBox29.Text = DataGrid16.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid16.Item(FILA_DATA, 5)) = False Then TextBox29.Text = DataGrid16.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub TextBox29_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox29.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox29.Text <> "" Then
                        NETO = CInt(DataGrid16.Item(FILA_DATA, 3))
                        DataGrid16.Item(FILA_DATA, 4) = TextBox29.Text
                        DESCUENTO = (CDbl(DataGrid16.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid16.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid16.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox29.Text <> "" Then
                        DataGrid16.Item(FILA_DATA, 5) = TextBox29.Text
                        RESTA = CInt(DataGrid16.Item(FILA_DATA, 3)) - CInt(DataGrid16.Item(FILA_DATA, 5))
                        NET = DataGrid16.Item(FILA_DATA, 3)
                        DataGrid16.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid16.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox29_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.GotFocus
        TextBox29.SelectionStart = 1
    End Sub

    Private Sub DataGrid16_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid16.DoubleClick
        'Dim respuesta As MsgBoxResult
        'Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "2" Then MUESTRA = "FRUTO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "5" Then MUESTRA = "FERT-QUI"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "6" Then MUESTRA = "FERT-ORG"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "7" Then MUESTRA = "+ANALISIS"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "8" Then MUESTRA = "KIT,OTROS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            'AddHandler myGrid.Paint, AddressOf DATAGRID2_Paint
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub DataGrid27_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid27.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid16.CurrentCell.RowNumber
        If DataGrid16.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid12.Visible = True
            GoTo yam
        End If
        If TextBox41.Visible = True Then TextBox41.Visible = False
        If DataGrid27.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid27.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid27.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid27.GetCellBounds(DataGrid27.CurrentCell.RowNumber, DataGrid27.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid27.GetCellBounds(DataGrid27.CurrentCell.RowNumber, DataGrid27.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid27.GetCellBounds(DataGrid27.CurrentCell.RowNumber, DataGrid27.CurrentCell.ColumnNumber).X + DataGrid27.Left
        Dim Posiciony As Integer = DataGrid27.GetCellBounds(DataGrid27.CurrentCell.RowNumber, DataGrid27.CurrentCell.ColumnNumber).Y + DataGrid27.Top
        TextBox41.Left = Posicionx
        TextBox41.Top = Posiciony
        TextBox41.Height = CeldaAlto
        TextBox41.Width = CeldaAncho
        TextBox41.Visible = True
        TextBox41.Text = ""
        TextBox41.Enabled = True
        TextBox41.Focus()
        TextBox41.SelectionStart = 1
        If IsDBNull(DataGrid27.Item(FILA_DATA, 4)) = False Then TextBox41.Text = DataGrid27.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid27.Item(FILA_DATA, 5)) = False Then TextBox41.Text = DataGrid27.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub TextBox41_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox41.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox41.Text <> "" Then
                        NETO = CInt(DataGrid27.Item(FILA_DATA, 3))
                        DataGrid27.Item(FILA_DATA, 4) = TextBox41.Text
                        DESCUENTO = (CDbl(DataGrid27.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid27.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid27.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox41.Text <> "" Then
                        DataGrid27.Item(FILA_DATA, 5) = TextBox41.Text
                        RESTA = CInt(DataGrid27.Item(FILA_DATA, 3)) - CInt(DataGrid27.Item(FILA_DATA, 5))
                        NET = DataGrid27.Item(FILA_DATA, 3)
                        DataGrid27.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid27.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox41_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox41.GotFocus
        TextBox41.SelectionStart = 1
    End Sub

    Private Sub DataGrid27_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid27.DoubleClick
        'Dim respuesta As MsgBoxResult
        'Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "2" Then MUESTRA = "+TEJIDO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "5" Then MUESTRA = "FERT-QUI"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "6" Then MUESTRA = "FERT-ORG"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "7" Then MUESTRA = "+ANALISIS"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "8" Then MUESTRA = "KIT,OTROS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            'AddHandler myGrid.Paint, AddressOf DATAGRID2_Paint
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub DataGrid17_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid17.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid17.CurrentCell.RowNumber
        If DataGrid17.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid20.Visible = True
            GoTo yam
        End If
        If TextBox30.Visible = True Then TextBox30.Visible = False
        If DataGrid17.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid17.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid17.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid17.GetCellBounds(DataGrid17.CurrentCell.RowNumber, DataGrid17.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid17.GetCellBounds(DataGrid17.CurrentCell.RowNumber, DataGrid17.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid17.GetCellBounds(DataGrid17.CurrentCell.RowNumber, DataGrid17.CurrentCell.ColumnNumber).X + DataGrid17.Left
        Dim Posiciony As Integer = DataGrid17.GetCellBounds(DataGrid17.CurrentCell.RowNumber, DataGrid17.CurrentCell.ColumnNumber).Y + DataGrid17.Top
        TextBox30.Left = Posicionx
        TextBox30.Top = Posiciony
        TextBox30.Height = CeldaAlto
        TextBox30.Width = CeldaAncho
        TextBox30.Visible = True
        TextBox30.Text = ""
        TextBox30.Enabled = True
        TextBox30.Focus()
        TextBox30.SelectionStart = 1
        If IsDBNull(DataGrid17.Item(FILA_DATA, 4)) = False Then TextBox30.Text = DataGrid17.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid17.Item(FILA_DATA, 5)) = False Then TextBox30.Text = DataGrid17.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub TextBox30_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox30.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox30.Text <> "" Then
                        NETO = CInt(DataGrid17.Item(FILA_DATA, 3))
                        DataGrid17.Item(FILA_DATA, 4) = TextBox30.Text
                        DESCUENTO = (CDbl(DataGrid17.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid17.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid17.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox30.Text <> "" Then
                        DataGrid17.Item(FILA_DATA, 5) = TextBox30.Text
                        RESTA = CInt(DataGrid17.Item(FILA_DATA, 3)) - CInt(DataGrid17.Item(FILA_DATA, 5))
                        NET = DataGrid17.Item(FILA_DATA, 3)
                        DataGrid17.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid17.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox30_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.GotFocus
        TextBox30.SelectionStart = 1
    End Sub

    Private Sub DataGrid17_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid17.DoubleClick
        'Dim respuesta As MsgBoxResult
        'Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "2" Then MUESTRA = "FRUTO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "5" Then MUESTRA = "FERT-QUI"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "6" Then MUESTRA = "FERT-ORG"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "7" Then MUESTRA = "+ANALISIS"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "8" Then MUESTRA = "KIT,OTROS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            'AddHandler myGrid.Paint, AddressOf DATAGRID2_Paint
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub DataGrid8_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid8.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid8.CurrentCell.RowNumber
        If DataGrid8.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid23.Visible = True
            GoTo yam
        End If
        If TextBox21.Visible = True Then TextBox21.Visible = False
        If DataGrid8.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid8.CurrentCell.ColumnNumber
        FILA_DATA = DataGrid8.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid8.GetCellBounds(DataGrid8.CurrentCell.RowNumber, DataGrid8.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid8.GetCellBounds(DataGrid8.CurrentCell.RowNumber, DataGrid8.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid8.GetCellBounds(DataGrid8.CurrentCell.RowNumber, DataGrid8.CurrentCell.ColumnNumber).X + DataGrid8.Left
        Dim Posiciony As Integer = DataGrid8.GetCellBounds(DataGrid8.CurrentCell.RowNumber, DataGrid8.CurrentCell.ColumnNumber).Y + DataGrid8.Top
        TextBox21.Left = Posicionx
        TextBox21.Top = Posiciony
        TextBox21.Height = CeldaAlto
        TextBox21.Width = CeldaAncho
        TextBox21.Visible = True
        TextBox21.Text = ""
        TextBox21.Enabled = True
        TextBox21.Focus()
        TextBox21.SelectionStart = 1
        If IsDBNull(DataGrid8.Item(FILA_DATA, 4)) = False Then TextBox21.Text = DataGrid8.Item(FILA_DATA, 4)
        If IsDBNull(DataGrid8.Item(FILA_DATA, 5)) = False Then TextBox21.Text = DataGrid8.Item(FILA_DATA, 5)
yam:
    End Sub

    Private Sub DataGrid8_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid8.DoubleClick
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim Es_Combo As Boolean
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID2 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID2) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 3)) = True Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID2, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID2, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID2, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID2, 2)
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID2, 1), 1, 1) = "2" Then MUESTRA = "+TEJIDOS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            myGrid.Item(FILA_DATAGRID2, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Private Sub TextBox21_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox21.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, NET, TOT As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox21.Text <> "" Then
                        NETO = CInt(DataGrid8.Item(FILA_DATA, 3))
                        DataGrid8.Item(FILA_DATA, 4) = TextBox21.Text
                        DESCUENTO = (CDbl(DataGrid8.Item(FILA_DATA, 4)) / 100) * NETO
                        DataGrid8.Item(FILA_DATA, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 5
                        mycell.RowNumber = FILA_DATA
                        DataGrid8.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox21.Text <> "" Then
                        DataGrid8.Item(FILA_DATA, 5) = TextBox21.Text
                        RESTA = CInt(DataGrid8.Item(FILA_DATA, 3)) - CInt(DataGrid8.Item(FILA_DATA, 5))
                        NET = DataGrid8.Item(FILA_DATA, 3)
                        DataGrid8.Item(FILA_DATA, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA
                        DataGrid8.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox21_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.GotFocus
        TextBox21.SelectionStart = 1
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim fila, SUBTOTAL, NETO, IVA, TOTAL, DESCU_PESOS As Integer
        Dim FILA_DATAROW, FILA_RANGO, FILA_DETA, FILA_COT As DataRow
        Dim DESC As Double
        Dim OBJSUM, BOLA As Object
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        fila = MYGRID.CurrentCell.RowNumber()
        FILA_DATAROW = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows(fila)
        Try
            BOLA = MYGRID.Item(fila, 1)
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Rows.Find(BOLA)
            If Not (FILA_RANGO Is Nothing) Then
                FILA_RANGO.Item("CHEQUEO") = ""
                FILA_RANGO.Item("CTA_DESCUENTO") = 0
                FILA_RANGO.Item("CTA_NETO") = 0
            End If
            'Call ELIMINA_COMBO_COTIZA(FILA_DATAROW)
            Call elimina_cotiza_analisis(FILA_DATAROW)
            Call elimina_detalle_cotiza(FILA_DATAROW, fila)
            'OBJSUM = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            'Adap_Detalle.Update(Cjto_Cotizacion1, "COTIZA_DETALLE")
            'If IsDBNull(OBJSUM) = False Then
            'SUBTOTAL = CDbl(OBJSUM)
            'Else
            '    SUBTOTAL = 0
            'End If
            'Label3.Text = Format(SUBTOTAL, "####,##0")
        Catch ex As Exception
            MsgBox("No puede eliminar esta fila")
        End Try
    End Sub

    Private Sub elimina_detalle_cotiza(ByVal FILA_DATAROW As DataRow, ByVal fila As Integer)
        Dim FILA_COT, FILA_DETA, fila2 As DataRow
        Dim query As String
        If DEL_GRA = 1 Then
            If Me.SqlConnection1.State = ConnectionState.Closed Then
                Me.SqlConnection1.Open()
            End If
            For Each fila2 In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
                If fila2 Is Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows(fila) Then
                    query = "DELETE FROM COTIZA_DETALLE WHERE COT_NUMERO=" & fila2.Item("COT_NUMERO") & " AND CTD_ANALISIS=" & fila2.Item("CTD_ANALISIS")
                    Dim command As New SqlCommand(query, Me.SqlConnection1)
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                    End Try
                End If
            Next
            Me.SqlConnection1.Close()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
            Me.SqlSelectCommand12.Parameters("@NUMERO_COT").Value = CDbl(TextBox1.Text)
            Adap_Con_Det.Fill(Cjto_Cotizacion1, "COTIZA_DETALLE1")
            For Each FILA_COT In Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Rows
                FILA_DETA = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                FILA_DETA.BeginEdit()
                FILA_DETA.Item("COT_NUMERO") = CDbl(TextBox1.Text)
                FILA_DETA.Item("CTD_ANALISIS") = FILA_COT("CTD_ANALISIS")
                FILA_DETA.Item("CTD_CANTIDAD") = FILA_COT("CTD_CANTIDAD")
                FILA_DETA.Item("CTD_UNITARIO") = FILA_COT("CTD_UNITARIO")
                FILA_DETA.Item("CTD_SUBTOTAL") = FILA_COT("CTD_SUBTOTAL")
                FILA_DETA.Item("CTD_DESCUENTO") = FILA_COT("CTD_DESCUENTO")
                FILA_DETA.Item("CTD_TOTAL") = FILA_COT("CTD_TOTAL")
                FILA_DETA.Item("ANA_ANALISIS") = FILA_COT("ANA_ANALISIS")
                FILA_DETA.Item("CTD_MUESTRA") = FILA_COT("CTD_MUESTRA")
                FILA_DETA.EndEdit()
                Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_DETA)
            Next
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").AcceptChanges()
        Else
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Remove(FILA_DATAROW)
        End If

    End Sub

    Private Sub class_COTIZADOR_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim FILA_RANGO, FILA_COMO, dr As DataRow
        Dim BOLA(1) As Object
        Select Case boton_notas
            Case 1
                RTxtAlto.Text = obs1
            Case 2
                RTxtMedio.Text = obs2
            Case 3
                RTxtBajo.Text = obs3
        End Select
        boton_notas = 0
        Select Case boton_notasK
            Case 1
                RichTextBox1.Text = obsK1
            Case 3
                RichTextBox3.Text = obsK3
        End Select
        boton_notasK = 0
        If com_act = "S" Then
            If com_cod1 <> 0 Then
                FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_COMO.Item("CTD_ANALISIS") = com_cod1
                FILA_COMO.Item("CTD_CANTIDAD") = 1
                FILA_COMO.Item("CTD_UNITARIO") = com_val1
                FILA_COMO.Item("CTD_SUBTOTAL") = com_val1
                FILA_COMO.Item("CTD_DESCUENTO") = 0
                FILA_COMO.Item("CTD_TOTAL") = com_val1
                FILA_COMO.Item("ANA_ANALISIS") = com_des1
                FILA_COMO.Item("CTD_MUESTRA") = com_tmu1
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_COMO)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = com_cod1
                    FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA)
                    FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                    FILA_COMO.Item("CTD_ANALISIS") = com_cod1
                    FILA_COMO.Item("CTD_CANTIDAD") = 1
                    FILA_COMO.Item("CTD_UNITARIO") = com_val1
                    FILA_COMO.Item("CTD_SUBTOTAL") = com_val1
                    FILA_COMO.Item("CTD_DESCUENTO") = 0
                    FILA_COMO.Item("CTD_TOTAL") = com_val1
                    FILA_COMO.Item("ANA_ANALISIS") = com_des1
                    FILA_COMO.Item("CTD_MUESTRA") = com_tmu1
                End Try
                If com_des2 <> "" Then
                    FILA_COMO = Cjto_Cotizacion1.Tables("COMBO_ANALISIS").NewRow
                    FILA_COMO.Item("COB_CODIGO") = com_cod1
                    FILA_COMO.Item("ANA_CODIGO") = com_cod2
                    FILA_COMO.Item("ANA_ANALISIS") = com_des2
                    Try
                        Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Rows.Add(FILA_COMO)
                    Catch ex As Exception
                        BOLA(0) = com_cod1
                        BOLA(1) = com_cod2
                        FILA_COMO = Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Rows.Find(BOLA)
                        FILA_COMO.Item("COB_CODIGO") = com_cod1
                        FILA_COMO.Item("ANA_CODIGO") = com_cod2
                        FILA_COMO.Item("ANA_ANALISIS") = com_des2
                    End Try
                End If
                If com_des3 <> "" Then
                    FILA_COMO = Cjto_Cotizacion1.Tables("COMBO_ANALISIS").NewRow
                    FILA_COMO.Item("COB_CODIGO") = com_cod1
                    FILA_COMO.Item("ANA_CODIGO") = com_cod3
                    FILA_COMO.Item("ANA_ANALISIS") = com_des3
                    Try
                        Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Rows.Add(FILA_COMO)
                    Catch ex As Exception
                        BOLA(0) = com_cod1
                        BOLA(1) = com_cod2
                        FILA_COMO = Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Rows.Find(BOLA)
                        FILA_COMO.Item("COB_CODIGO") = com_cod1
                        FILA_COMO.Item("ANA_CODIGO") = com_cod3
                        FILA_COMO.Item("ANA_ANALISIS") = com_des3
                    End Try
                End If
            Else
                If com_des2 <> "" Then
                    FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                    FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                    FILA_COMO.Item("CTD_ANALISIS") = com_cod2
                    FILA_COMO.Item("CTD_CANTIDAD") = 1
                    FILA_COMO.Item("CTD_UNITARIO") = com_val2
                    FILA_COMO.Item("CTD_SUBTOTAL") = com_val2
                    FILA_COMO.Item("CTD_DESCUENTO") = 0
                    FILA_COMO.Item("CTD_TOTAL") = com_val2
                    FILA_COMO.Item("ANA_ANALISIS") = com_des2
                    FILA_COMO.Item("CTD_MUESTRA") = com_tmu2
                    Try
                        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_COMO)
                    Catch ex As Exception
                        BOLA(0) = CDbl(Val(TextBox1.Text))
                        BOLA(1) = com_cod2
                        FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA)
                        FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                        FILA_COMO.Item("CTD_ANALISIS") = com_cod2
                        FILA_COMO.Item("CTD_CANTIDAD") = 1
                        FILA_COMO.Item("CTD_UNITARIO") = com_val2
                        FILA_COMO.Item("CTD_SUBTOTAL") = com_val2
                        FILA_COMO.Item("CTD_DESCUENTO") = 0
                        FILA_COMO.Item("CTD_TOTAL") = com_val2
                        FILA_COMO.Item("ANA_ANALISIS") = com_des2
                        FILA_COMO.Item("CTD_MUESTRA") = com_tmu2
                    End Try
                End If
                If com_des3 <> "" Then
                    FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                    FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                    FILA_COMO.Item("CTD_ANALISIS") = com_cod3
                    FILA_COMO.Item("CTD_CANTIDAD") = 1
                    FILA_COMO.Item("CTD_UNITARIO") = com_val3
                    FILA_COMO.Item("CTD_SUBTOTAL") = com_val3
                    FILA_COMO.Item("CTD_DESCUENTO") = 0
                    FILA_COMO.Item("CTD_TOTAL") = com_val3
                    FILA_COMO.Item("ANA_ANALISIS") = com_des3
                    FILA_COMO.Item("CTD_MUESTRA") = com_tmu3
                    Try
                        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_COMO)
                    Catch ex As Exception
                        BOLA(0) = CDbl(Val(TextBox1.Text))
                        BOLA(1) = com_cod3
                        FILA_COMO = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA)
                        FILA_COMO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                        FILA_COMO.Item("CTD_ANALISIS") = com_cod3
                        FILA_COMO.Item("CTD_CANTIDAD") = 1
                        FILA_COMO.Item("CTD_UNITARIO") = com_val3
                        FILA_COMO.Item("CTD_SUBTOTAL") = com_val3
                        FILA_COMO.Item("CTD_DESCUENTO") = 0
                        FILA_COMO.Item("CTD_TOTAL") = com_val3
                        FILA_COMO.Item("ANA_ANALISIS") = com_des3
                        FILA_COMO.Item("CTD_MUESTRA") = com_tmu3
                    End Try
                End If
            End If
            com_act = "N"
        End If
        If MODIFICADOR = "S" Then
            Try
                Adap_Man_Ana.Update(Cjto_Cotizacion1, "ANALISIS")
                Cjto_Cotizacion1.Tables("ANALISIS").Clear()
                Adap_Man_Ana.Fill(Cjto_Cotizacion1, "ANALISIS")
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
                Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Clear()
                Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = TextBox1.Text
                Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
                Adap_Combo_Ana.Fill(Cjto_Cotizacion1, "COMBO_ANALISIS")
                RadioButton3.Checked = True
                Call TRASPASO_ANALISIS()
            Catch ex As Exception
                'MsgBox("Error en grabación")
            End Try
            Select Case ultima_tab
                Case "TabPage2"
                    TabControl1.SelectedTab = TabControl1.TabPages(1)
                Case "TabPage5"
                    TabControl1.SelectedTab = TabControl1.TabPages(2)
                Case "TabPage4"
                    TabControl1.SelectedTab = TabControl1.TabPages(3)
                Case "TabPage3"
                    TabControl1.SelectedTab = TabControl1.TabPages(4)
                Case "TabPage11"
                    TabControl1.SelectedTab = TabControl1.TabPages(5)
                Case "TabPage8"
                    TabControl1.SelectedTab = TabControl1.TabPages(6)
                Case "TabPage12"
                    TabControl1.SelectedTab = TabControl1.TabPages(7)
                Case "TabPage13"
                    TabControl1.SelectedTab = TabControl1.TabPages(8)
                Case "TabPage7"
                    TabControl1.SelectedTab = TabControl1.TabPages(10)
                Case "TabPage9"
                    TabControl1.SelectedTab = TabControl1.TabPages(11)
                Case "TabPage10"
                    TabControl1.SelectedTab = TabControl1.TabPages(12)
                Case "TabPage1"
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                Case "TabPage6"
                    TabControl1.SelectedTab = TabControl1.TabPages(9)
            End Select
            MODIFICADOR = "N"
        End If
        If MOD_MUE = "S" Then
            dr = Cjto_Cotizacion1.Tables("MUESTRA").NewRow
            dr.BeginEdit()
            dr.Item("TMU_CODIGO") = mue_cod
            dr.Item("TMU_MUESTRA") = mue_des
            dr.EndEdit()
            Try
                Cjto_Cotizacion1.Tables("MUESTRA").Rows.Add(dr)
                Adap_Muestra.Update(Cjto_Cotizacion1, "MUESTRA")
                Adap_Muestra.Fill(Cjto_Cotizacion1, "MUESTRA")
            Catch ex As Exception
                MsgBox("Análisis ya fue creado")
            End Try
            MOD_MUE = "N"
        End If
        If MOD_SUB = "S" Then
            dr = Cjto_Cotizacion1.Tables("SUBMUESTRA").NewRow
            dr.BeginEdit()
            dr.Item("SUB_CODIGO") = sub_sub
            dr.Item("SUB_DESCRIPCION") = sub_des
            dr.Item("TMU_CODIGO") = sub_cod
            dr.EndEdit()
            Try
                Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Add(dr)
                Adap_Submuestra.Update(Cjto_Cotizacion1, "SUBMUESTRA")
                Adap_Submuestra.Fill(Cjto_Cotizacion1, "SUBMUESTRA")
            Catch ex As Exception
                MsgBox("Análisis ya fue creado")
            End Try
            MOD_SUB = "N"
        End If
        If MODIFICA_COMBO = "S" Then
            Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Clear()
            Adap_Combo_Ana.Fill(Cjto_Cotizacion1, "COMBO_ANALISIS")
            MODIFICA_COMBO = "N"
        End If
    End Sub

    Private Sub BTAlto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAlto.Click
        Dim Form_notas As New Notas
        Form_notas.Owner = Me
        boton_notas = 1
        obs1 = RTxtAlto.Text
        seccion = "1"
        Form_notas.Show()
    End Sub

    Private Sub BTMedio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTMedio.Click
        Dim Form_notas As New Notas
        Form_notas.Owner = Me
        boton_notas = 2
        obs2 = RTxtMedio.Text
        seccion = "2"
        Form_notas.Show()
    End Sub

    Private Sub BTBajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTBajo.Click
        Dim Form_notas As New Notas
        Form_notas.Owner = Me
        boton_notas = 3
        obs3 = RTxtBajo.Text
        seccion = "3"
        Form_notas.Show()
    End Sub

    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        Dim Form_notas As New NotaKit
        Form_notas.Owner = Me
        boton_notasK = 1
        obsK1 = RichTextBox1.Text
        seccion = "1"
        Form_notas.Show()
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        Dim Form_notas As New NotaKit
        Form_notas.Owner = Me
        boton_notasK = 3
        obsK3 = RichTextBox3.Text
        seccion = "2"
        Form_notas.Show()
    End Sub

    Private Sub graba_cotizacion()
        Try
            Dim FILA_RANGO, FILA_COM, FILA_ACOM As DataRow
            Dim BOLA, BOLA1 As Object
            Dim caracter, junto, A, CO, CI As String
            Dim CONVERSION As Double
            Dim fecha As DateTime
            Dim conversion1, largo, i As Integer
            FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZACION").NewRow
            FILA_RANGO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
            FILA_RANGO.Item("COT_RUT") = TextBox2.Text
            FILA_RANGO.Item("COT_NOMBRE") = TextBox23.Text
            FILA_RANGO.Item("COT_EMAIL") = TextBox9.Text
            FILA_RANGO.Item("COT_ATENCION") = TextBox8.Text
            FILA_RANGO.Item("COT_DIRECCION") = TextBox7.Text
            BOLA1 = FILA_RANGO.Item("COT_COMUNA")
            FILA_COM = Cjto_Cotizacion1.Tables("COTIZA_COMUNAS").Rows.Find(BOLA1)
            If (FILA_COM Is Nothing) Then
                FILA_ACOM = Cjto_Cotizacion1.Tables("COTIZA_COMUNAS").NewRow
                FILA_ACOM.Item("COD_COMUNA") = UCase(CBComuna.Text)
                FILA_ACOM.Item("COD_CIUDAD") = UCase(CBCiudad.Text)
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_COMUNAS").Rows.Add(FILA_ACOM)
                Catch ex As Exception
                End Try
                Adap_Comunas.Update(Cjto_Cotizacion1, "COTIZA_COMUNAS")
                Cjto_Cotizacion1.Tables("COTIZA_COMUNAS").Clear()
                Adap_Comunas.Fill(Cjto_Cotizacion1, "COTIZA_COMUNAS")
            End If
            FILA_RANGO.Item("COT_CIUDAD") = CBCiudad.Text
            FILA_RANGO.Item("COT_COMUNA") = CBComuna.Text
            FILA_RANGO.Item("COT_FONO") = TextBox10.Text
            FILA_RANGO.Item("COT_FAX") = TextBox11.Text
            FILA_RANGO.Item("COT_CELULAR") = TextBox16.Text
            FILA_RANGO.Item("COT_EMPRESA") = TextBox22.Text
            FILA_RANGO.Item("COT_MUE1") = MUESTRA1
            FILA_RANGO.Item("COT_MUE2") = MUESTRA2
            FILA_RANGO.Item("COT_MUE3") = MUESTRA3
            FILA_RANGO.Item("COT_MUE4") = MUESTRA4
            FILA_RANGO.Item("COT_EMAIL2") = TextBox14.Text
            FILA_RANGO.Item("COT_CARGO") = TextBox12.Text
            'largo = Len(Label3.Text)
            junto = ""
            For i = 1 To largo
                'caracter = Mid(Label3.Text, i, 1)
                If caracter = "." Or caracter = "," Then A = "0" Else junto = junto + caracter
            Next

            Try
                If junto = "" Then
                    junto = 0
                End If
                FILA_RANGO.Item("COT_SUBTOTAL") = junto
            Catch ex As Exception

            End Try


            FILA_RANGO.Item("COT_DESCUENTO") = 0
            FILA_RANGO.Item("COT_NETO") = 0
            FILA_RANGO.Item("COT_IVA") = 0
            FILA_RANGO.Item("COT_TOTAL") = 0
            fecha = CDate(TextBox3.Text)
            'fecha = Mid(fecha, 1, 2) & Mid(fecha, 4, 2) & Mid(fecha, 7, 4)
            FILA_RANGO.Item("COT_FECHA") = fecha
            Try
                Cjto_Cotizacion1.Tables("COTIZACION").Rows.Add(FILA_RANGO)
                If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COTIZACION").AcceptChanges()
            Catch ex As Exception
                BOLA = CDbl(Val(TextBox1.Text))
                FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZACION").Rows.Find(BOLA)
                FILA_RANGO.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_RANGO.Item("COT_RUT") = TextBox2.Text
                FILA_RANGO.Item("COT_NOMBRE") = TextBox23.Text
                FILA_RANGO.Item("COT_EMAIL") = TextBox9.Text
                FILA_RANGO.Item("COT_ATENCION") = TextBox8.Text
                FILA_RANGO.Item("COT_DIRECCION") = TextBox7.Text
                FILA_RANGO.Item("COT_COMUNA") = CBComuna.Text
                FILA_RANGO.Item("COT_FONO") = TextBox10.Text
                FILA_RANGO.Item("COT_FAX") = TextBox11.Text
                FILA_RANGO.Item("COT_SUBTOTAL") = 0
                FILA_RANGO.Item("COT_DESCUENTO") = 0
                FILA_RANGO.Item("COT_NETO") = 0
                FILA_RANGO.Item("COT_IVA") = 0
                FILA_RANGO.Item("COT_TOTAL") = 0
                FILA_RANGO.Item("COT_FECHA") = CDate(TextBox3.Text)
                FILA_RANGO.Item("COT_CIUDAD") = CBCiudad.Text
                FILA_RANGO.Item("COT_EMPRESA") = TextBox22.Text
                FILA_RANGO.Item("COT_MUE1") = MUESTRA1
                FILA_RANGO.Item("COT_MUE2") = MUESTRA2
                FILA_RANGO.Item("COT_MUE3") = MUESTRA3
                FILA_RANGO.Item("COT_MUE4") = MUESTRA4
                FILA_RANGO.Item("COT_EMAIL2") = TextBox14.Text
                FILA_RANGO.Item("COT_CARGO") = TextBox12.Text
            End Try
        Catch ex As Exception
            ' MsgBox("No se puede imprimir una cotización sin asignar analisis a un productor, error: " & ex.Message.ToString)
        End Try

    End Sub

    Private Sub graba_detalle()
        Adap_Detalle.Update(Cjto_Cotizacion1, "COTIZA_DETALLE")
    End Sub

    Private Sub COTIZACION_DESDE_CONSULTA(ByVal FILA_COTIZACION As DataRow)
        Dim FILA_RANGO As DataRow
        Dim BOLA As Object
        BOLA = CDbl(Val(TextBox1.Text))
        FILA_RANGO = Cjto_Cotizacion1.Tables("COTIZACION").Rows.Find(BOLA)
        FILA_RANGO.Item("COT_NUMERO") = FILA_COTIZACION("COT_NUMERO")
        FILA_RANGO.Item("COT_RUT") = FILA_COTIZACION("COT_RUT")
        FILA_RANGO.Item("COT_NOMBRE") = FILA_COTIZACION("COT_NOMBRE")
        FILA_RANGO.Item("COT_EMAIL") = FILA_COTIZACION("COT_EMAIL")
        FILA_RANGO.Item("COT_ATENCION") = FILA_COTIZACION("COT_ATENCION")
        FILA_RANGO.Item("COT_DIRECCION") = FILA_COTIZACION("COT_DIRECCION")
        FILA_RANGO.Item("COT_CIUDAD") = FILA_COTIZACION("COT_CIUDAD")
        FILA_RANGO.Item("COT_COMUNA") = FILA_COTIZACION("COT_COMUNA")
        FILA_RANGO.Item("COT_FONO") = FILA_COTIZACION("COT_FONO")
        FILA_RANGO.Item("COT_FAX") = FILA_COTIZACION("COT_FAX")
        FILA_RANGO.Item("COT_CELULAR") = FILA_COTIZACION("COT_CELULAR")
        FILA_RANGO.Item("COT_EMPRESA") = FILA_COTIZACION("COT_EMPRESA")
        FILA_RANGO.Item("COT_MUE1") = FILA_COTIZACION("COT_MUE1")
        FILA_RANGO.Item("COT_MUE2") = FILA_COTIZACION("COT_MUE2")
        FILA_RANGO.Item("COT_MUE3") = FILA_COTIZACION("COT_MUE3")
        FILA_RANGO.Item("COT_MUE4") = FILA_COTIZACION("COT_MUE4")
        FILA_RANGO.Item("COT_EMAIL2") = FILA_COTIZACION("COT_EMAIL2")
        FILA_RANGO.Item("COT_SUBTOTAL") = 0
        FILA_RANGO.Item("COT_DESCUENTO") = 0
        FILA_RANGO.Item("COT_NETO") = 0
        FILA_RANGO.Item("COT_IVA") = 0
        FILA_RANGO.Item("COT_TOTAL") = 0
        FILA_RANGO.Item("COT_FECHA") = FILA_COTIZACION("COT_FECHA")
    End Sub

    Private Sub SACA_MUESTRA()
        Try
            Dim FILA_MUE As DataRow
            Dim pas_fo, pas_fr, pas_ag, pas_su, pas_forg, pas_fqui, pas_otros, pas_kit As String
            pas_fo = "n" : pas_fr = "n" : pas_ag = "n" : pas_su = "n" : pas_forg = "n" : pas_fqui = "n"
            pas_otros = "n" : pas_kit = "n"
            If MUESTRA1 = "LIS" Then MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = "" Else MUESTRA1 = "" : MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = ""

            For Each FILA_MUE In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
                Select Case FILA_MUE("CTD_MUESTRA")
                    Case "FOLIAR"
                        If pas_fo = "s" Then Exit Select
                        pas_fo = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "FOL" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "FOL" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "FOL" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "FOL" : Exit Select
                    Case "AGUA"
                        If pas_ag = "s" Then Exit Select
                        pas_ag = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "AGU" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "AGU" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "AGU" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "AGU" : Exit Select
                    Case "SUELO"
                        If pas_su = "s" Then Exit Select
                        pas_su = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "SUE" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "SUE" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "SUE" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "SUE" : Exit Select
                    Case "+TEJIDOS"
                        If pas_fr = "s" Then Exit Select
                        pas_fr = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "TEJ" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "TEJ" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "TEJ" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "TEJ" : Exit Select
                    Case "FERT-QUI"
                        If pas_fqui = "s" Then Exit Select
                        pas_fqui = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "FEQ" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "FEQ" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "FEQ" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "FEQ" : Exit Select
                    Case "FERT-ORG"
                        If pas_forg = "s" Then Exit Select
                        pas_forg = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "FEQ" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "FEQ" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "FEQ" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "FEQ" : Exit Select
                    Case "+ANALISIS"
                        If pas_otros = "s" Then Exit Select
                        pas_otros = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "FRU" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "FRU" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "FRU" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "FRU" : Exit Select
                    Case "KIT,OTROS"
                        If pas_kit = "s" Then Exit Select
                        pas_kit = "s"
                        If MUESTRA1 = "" Then MUESTRA1 = "KIT" : Exit Select
                        If MUESTRA2 = "" Then MUESTRA2 = "KIT" : Exit Select
                        If MUESTRA3 = "" Then MUESTRA3 = "KIT" : Exit Select
                        If MUESTRA4 = "" Then MUESTRA4 = "KIT" : Exit Select
                End Select
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub graba_analisis_desc()
        Dim BOLA(1) As Object
        Dim OPERA As Integer
        Dim FILA_ANALISIS, FILA_DATA, DR As DataRow

        ' ***** FOLIAR ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        ' ***** SUELO *****

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        '******* AGUA ********

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        ' ***** FRUTO ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        ' ***** Fert QUI ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        ' ***** OTROS ANALISIS  ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next

        ' ***** KIT-SERV  ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next
        ' ***** Fert ORG ******

        For Each FILA_DATA In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Rows
            If IsDBNull(FILA_DATA("CTA_NETO")) = False Then
                OPERA = FILA_DATA("CTA_NETO")
            Else
                OPERA = 0
            End If
            If OPERA <> 0 Then
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_DATA("ANA_CODIGO")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_DATA("ANA_NETO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = OPERA
                Try
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
                Catch ex As Exception
                    BOLA(0) = CDbl(Val(TextBox1.Text))
                    BOLA(1) = FILA_DATA("ANA_CODIGO")
                    FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA)
                    FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_DATA("CTA_DESCUENTO")
                    FILA_ANALISIS.Item("CTA_NETO") = OPERA
                End Try
            End If
        Next
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        RadioButton3.Checked = True
        Call LIMPIA()
        Call ULTIMA_COTIZA()
        MUESTRA1 = "" : MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = ""
        Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = TextBox1.Text
        Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
        Call TRASPASO_ANALISIS()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        DEL_GRA = 0 : DESDE_CONSULTA = 0
    End Sub

    Private Sub Button40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button40.Click
        Call LIMPIA2()
        Call ELIMINA_DETALLE()
        Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = TextBox1.Text
        Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
        Call TRASPASO_ANALISIS()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        DEL_GRA = 0
    End Sub

    Private Sub ELIMINA_DETALLE()
        Dim FILA_NOTAS_R As DataRow
        Dim myselectquery, consulta_nota As String
        myselectquery = "DELETE FROM COTIZA_DETALLE WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text))
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        myReader.Close()
        myselectquery = "DELETE FROM COMBO_COTIZA WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text))
        Dim myCommand1 As New SqlCommand(myselectquery, SqlConnection1)
        Dim myReader1 As SqlDataReader = myCommand.ExecuteReader()
        myReader1.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub ULTIMA_COTIZA()
        Dim FILA_NOTAS_R As DataRow
        Dim myselectquery, consulta_nota As String
        Dim ULTIMA_COTIZACION As Double
        Dim ULT_MAS_UNA, numero_coti As Integer
        Cjto_Cotizacion1.Tables("COTIZA_NOTAS").Clear()
        myselectquery = "select max(COT_NUMERO) FROM COTIZACION"
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        myReader.Read()
        ULTIMA_COTIZACION = myReader.GetDouble(0)
        ULT_MAS_UNA = CInt(ULTIMA_COTIZACION) + 1
        TextBox1.Text = CStr(ULT_MAS_UNA)
        myReader.Close()
        SqlConnection1.Close()
        SqlConnection1.Open()
        consulta_nota = "select NOTA_NUM,NOTA_DESCRIPCION from NOTA_ULTIMA_COT "
        Dim myCommand2 As New SqlCommand(consulta_nota, SqlConnection1)
        ' myCommand2.Parameters.Add("@UC", SqlDbType.NVarChar, 4).Value = ULTIMA_COTIZACION
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        While myReader2.Read()
            Try
                numero_coti = myReader2.GetInt32(0)
                'FILA_NOTAS_R = Cjto_Cotizacion1.Tables("COTIZA_NOTAS").NewRow
                Select Case numero_coti
                    Case 1
                        RTxtAlto.Text = myReader2.GetString(1)
                    Case 2
                        RTxtMedio.Text = myReader2.GetString(1)
                    Case 3
                        RTxtBajo.Text = myReader2.GetString(1)
                End Select
            Catch ex As Exception

            End Try
        End While
        myReader2.Close()
        '
        'NOTA KITS
        '
        consulta_nota = "select NOTA_NUM,NOTA_DESCRIPCION from NOTA_ULTIMA_COTK "
        Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader3 As SqlDataReader = myCommand3.ExecuteReader()
        While myReader3.Read()
            Try
                numero_coti = myReader3.GetInt32(0)
                Select Case numero_coti
                    Case 1
                        RichTextBox1.Text = myReader3.GetString(1)
                    Case 3
                        RichTextBox3.Text = myReader3.GetString(1)
                End Select
            Catch ex As Exception
            End Try
        End While
        myReader3.Close()
        SqlConnection1.Close()
        DESDE_CONSULTA = 0
    End Sub

    Private Sub ULTIMO_NUMERO_COTIZACION()
        Dim FILA_NOTAS_R As DataRow
        Dim myselectquery, consulta_nota As String
        Dim ULTIMA_COTIZACION As Double
        Dim ULT_MAS_UNA, numero_coti As Integer
        myselectquery = "select max(COT_NUMERO) FROM COTIZACION"
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        myReader.Read()
        ULTIMA_COTIZACION = myReader.GetDouble(0)
        ULT_MAS_UNA = CInt(ULTIMA_COTIZACION) + 1
        TextBox1.Text = CStr(ULT_MAS_UNA)
        myReader.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub MIDE_CONCURRENCIA()
        Dim myselectquery, consulta_nota As String
        Dim ULTIMA_COTIZACION As Double
        Dim ULT_MAS_UNA, numero_coti As Integer
        myselectquery = "select NUM_CON,CONCURRENCIA FROM CONCURRENCIA_COT"
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        myReader.Read()
        concu = myReader.GetString(1)
        myReader.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub LIMPIA()
        TextBox22.Text = ""
        If CBComuna.Text <> "" Then CBComuna.Text = ""
        TextBox23.Text = ""
        TextBox9.Text = ""
        TextBox2.Text = ""
        TextBox8.Text = ""
        TextBox7.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
        TextBox12.Text = ""
        'Label3.Text = ""
        If CBCiudad.Text <> "" Then CBCiudad.Text = ""
        TextBox14.Text = ""
        TextBox16.Text = ""
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
        Cjto_Cotizacion1.Tables("COMBO_COTIZA").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
        TextBox2.Focus()
    End Sub

    Private Sub LIMPIA2()
        Cjto_Cotizacion1.Tables("COMBO_COTIZA").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
        Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
        TextBox2.Focus()
    End Sub

    Private Sub TextBox8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox8.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox7.Focus()
        End If
    End Sub

    Private Sub ComboBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            TextBox8.Focus()
        End If
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Seleccione base para realizar busqueda")
        End If
        If RadioButton1.Checked = True Then
            Cjto_Cotizacion1.Tables("COTIZACION1").Clear()
            Me.SqlSelectCommand11.Parameters("@RUT_COT").Value = TextBox23.Text & "%"
            Me.SqlSelectCommand11.Parameters("@NOMBRE_COT").Value = TextBox23.Text & "%"
            'Call cambio_color_boton()
            'Button8.BackColor = Color.FromName("Info")
            Adap_Con_Cot.Fill(Cjto_Cotizacion1, "COTIZACION1")
            GroupBox10.Visible = True
            GroupBox25.Visible = True
            'DataGrid6.Visible = True
            DataGrid6.Focus()
        End If
        If RadioButton2.Checked = True Then
            Me.SqlSelectCommand9.Parameters("@PRO_RUT").Value = TextBox23.Text & "%"
            Me.SqlSelectCommand9.Parameters("@PRO_NOMBRE").Value = TextBox23.Text & "%"
            'Call cambio_color_boton()
            Cjto_Cotizacion1.Tables("PRODUCTOR").Clear()
            Adap_Productor.Fill(Cjto_Cotizacion1, "PRODUCTOR")
            GroupBox10.Visible = True
            GroupBox25.Visible = True
            DataGrid6.Visible = True
            'DataGrid5.Focus()
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Me.TextBox3.Text = Me.MonthCalendar1.SelectionRange.Start
        Me.MonthCalendar1.Visible = False
    End Sub

    Public Sub TRASPASO_ANALISIS()
        Dim FILA_COTIZA11, FILA_COTIZA1, FILA_COTIZA12, FILA_COTIZA13 As DataRow
        Dim FILA_COTIZA14, FILA_COTIZA15, FILA_COTIZA16 As DataRow
        Dim BOLA1 As Object
        For Each FILA_COTIZA1 In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS_BASE").Rows
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 1 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA11 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").NewRow
                    FILA_COTIZA11.BeginEdit()
                    FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA11.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA11.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA11.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA11.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Add(FILA_COTIZA11)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If

            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 4 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA11 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").NewRow
                    FILA_COTIZA11.BeginEdit()
                    FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA11.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA11.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA11.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA11.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Rows.Add(FILA_COTIZA11)
                End If
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 3 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA12 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").NewRow
                    FILA_COTIZA12.BeginEdit()
                    FILA_COTIZA12.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA12.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA12.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA12.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA12.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA12.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA12.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA12.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA12.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Rows.Add(FILA_COTIZA12)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 2 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA13 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").NewRow
                    FILA_COTIZA13.BeginEdit()
                    FILA_COTIZA13.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA13.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA13.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA13.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA13.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA13.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA13.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA13.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA13.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Rows.Add(FILA_COTIZA13)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 5 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA14 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").NewRow
                    FILA_COTIZA14.BeginEdit()
                    FILA_COTIZA14.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA14.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA14.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA14.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA14.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA14.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA14.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA14.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA14.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Rows.Add(FILA_COTIZA14)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 6 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA14 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").NewRow
                    FILA_COTIZA14.BeginEdit()
                    FILA_COTIZA14.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA14.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA14.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA14.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA14.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA14.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA14.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA14.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA14.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Rows.Add(FILA_COTIZA14)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If

            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 7 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA15 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").NewRow
                    FILA_COTIZA15.BeginEdit()
                    FILA_COTIZA15.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA15.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA15.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA15.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA15.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA15.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA15.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA15.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA15.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Rows.Add(FILA_COTIZA15)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 8 Then
                If FILA_COTIZA1.Item("ANA_NIVEL_PRECIO") = "CFR" Then
                    FILA_COTIZA16 = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").NewRow
                    FILA_COTIZA16.BeginEdit()
                    FILA_COTIZA16.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                    FILA_COTIZA16.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                    FILA_COTIZA16.Item("CTA_DESCUENTO") = FILA_COTIZA1.Item("CTA_DESCUENTO")
                    FILA_COTIZA16.Item("CTA_NETO") = FILA_COTIZA1.Item("CTA_NETO")
                    FILA_COTIZA16.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                    FILA_COTIZA16.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                    FILA_COTIZA16.Item("CHEQUEO") = FILA_COTIZA1.Item("CHEQUEO")
                    FILA_COTIZA16.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                    FILA_COTIZA16.EndEdit()
                    Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Rows.Add(FILA_COTIZA16)
                    'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
                End If
            End If
        Next
    End Sub

    Private Sub DataGrid3_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid3.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid3.CurrentCell.RowNumber
        If DataGrid3.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid11.Visible = True
            GoTo yam
        End If
        If TextBox19.Visible = True Then TextBox19.Visible = False
        If DataGrid3.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid3.CurrentCell.ColumnNumber
        FILA_DATA3 = DataGrid3.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid3.GetCellBounds(DataGrid3.CurrentCell.RowNumber, DataGrid3.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid3.GetCellBounds(DataGrid3.CurrentCell.RowNumber, DataGrid3.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid3.GetCellBounds(DataGrid3.CurrentCell.RowNumber, DataGrid3.CurrentCell.ColumnNumber).X + DataGrid3.Left
        Dim Posiciony As Integer = DataGrid3.GetCellBounds(DataGrid3.CurrentCell.RowNumber, DataGrid3.CurrentCell.ColumnNumber).Y + DataGrid3.Top
        TextBox19.Left = Posicionx
        TextBox19.Top = Posiciony
        TextBox19.Height = CeldaAlto
        TextBox19.Width = CeldaAncho
        TextBox19.Visible = True
        TextBox19.Text = ""
        TextBox19.Enabled = True
        TextBox19.Focus()
        'TextBox19.SelectionStart = 1
        SendKeys.Send("^{TAB}")
        If IsDBNull(DataGrid3.Item(FILA_DATA3, 4)) = False And COL56 = 4 Then TextBox19.Text = DataGrid3.Item(FILA_DATA3, 4)
        If IsDBNull(DataGrid3.Item(FILA_DATA3, 5)) = False And COL56 = 5 Then TextBox19.Text = DataGrid3.Item(FILA_DATA3, 5)
yam:
    End Sub

    Private Sub TextBox19_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox19.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO, RESTA As Integer
        Dim TOT, NET As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox19.Text <> "" Then
                        NETO = CInt(DataGrid3.Item(FILA_DATA3, 3))
                        DataGrid3.Item(FILA_DATA3, 4) = TextBox19.Text
                        DESCUENTO = (CDbl(DataGrid3.Item(FILA_DATA3, 4)) / 100) * NETO
                        DataGrid3.Item(FILA_DATA3, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA3
                        DataGrid3.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox19.Text <> "" Then
                        DataGrid3.Item(FILA_DATA3, 5) = TextBox19.Text
                        RESTA = CInt(DataGrid3.Item(FILA_DATA3, 3)) - CInt(DataGrid3.Item(FILA_DATA3, 5))
                        NET = DataGrid3.Item(FILA_DATA3, 3)
                        DESCUENTO = CDbl(((TOT / NET) - 1) * 100)
                        DataGrid3.Item(FILA_DATA3, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA3
                        DataGrid3.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox19_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.GotFocus
        TextBox19.SelectionStart = 1
    End Sub

    Private Sub DataGrid3_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid3.DoubleClick
        Dim respuesta As MsgBoxResult
        Dim FILA_DATAGRID3 As Integer
        Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID3 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID3) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID3, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If IsDBNull(myGrid.Item(FILA_DATAGRID3, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID3, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID3, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID3, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID3, 2)
        If Mid(myGrid.Item(FILA_DATAGRID3, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID3, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID3, 1), 1, 1) = "2" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID3, 1), 1, 1) = "3" Then MUESTRA = "FRUTO"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            myGrid.Item(FILA_DATAGRID3, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub
   
    Private Sub DataGrid4_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid4.CurrentCellChanged
        Dim mycell As New DataGridCell
        Dim codana As Double
        Dim ffi As Integer
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        ffi = DataGrid4.CurrentCell.RowNumber
        If DataGrid4.CurrentCell.ColumnNumber = 1 Then
            codana = myGrid_j.Item(ffi, 1)
            Call CARGA_CODIGO_ANALISIS(codana, muestra)
            'If muestra = True Then DataGrid22.Visible = True
            GoTo yam
        End If
        If TextBox20.Visible = True Then TextBox20.Visible = False
        If DataGrid4.CurrentCell.ColumnNumber < 4 Then Exit Sub
        COL56 = DataGrid4.CurrentCell.ColumnNumber
        FILA_DATA4 = DataGrid4.CurrentCell.RowNumber
        Dim CeldaAlto As Integer = DataGrid4.GetCellBounds(DataGrid4.CurrentCell.RowNumber, DataGrid4.CurrentCell.ColumnNumber).Height
        Dim CeldaAncho As Integer = DataGrid4.GetCellBounds(DataGrid4.CurrentCell.RowNumber, DataGrid4.CurrentCell.ColumnNumber).Width
        Dim Posicionx As Integer = DataGrid4.GetCellBounds(DataGrid4.CurrentCell.RowNumber, DataGrid4.CurrentCell.ColumnNumber).X + DataGrid4.Left
        Dim Posiciony As Integer = DataGrid4.GetCellBounds(DataGrid4.CurrentCell.RowNumber, DataGrid4.CurrentCell.ColumnNumber).Y + DataGrid4.Top
        TextBox20.Left = Posicionx
        TextBox20.Top = Posiciony
        TextBox20.Height = CeldaAlto
        TextBox20.Width = CeldaAncho
        TextBox20.Visible = True
        TextBox20.Text = ""
        TextBox20.Enabled = True
        TextBox20.Focus()
        TextBox20.SelectionStart = 1
        If IsDBNull(DataGrid4.Item(FILA_DATA4, 4)) = False Then TextBox20.Text = DataGrid4.Item(FILA_DATA4, 4)
        If IsDBNull(DataGrid4.Item(FILA_DATA4, 5)) = False Then TextBox20.Text = DataGrid4.Item(FILA_DATA4, 5)
yam:
    End Sub

    Private Sub TextBox20_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox20.KeyPress
        Dim mycell As New DataGridCell
        Dim TOTAL, NETO As Integer
        Dim RESTA, TOT, NET As Integer
        Dim DESCUENTO As Double
        Select Case COL56
            Case 4
                If e.KeyChar = Chr(13) Then
                    If TextBox20.Text <> "" Then
                        NETO = CInt(DataGrid4.Item(FILA_DATA4, 3))
                        DataGrid4.Item(FILA_DATA4, 4) = TextBox20.Text
                        DESCUENTO = (CDbl(DataGrid4.Item(FILA_DATA4, 4)) / 100) * NETO
                        DataGrid4.Item(FILA_DATA4, 5) = NETO - DESCUENTO
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA4
                        DataGrid4.CurrentCell = mycell
                    End If
                End If
            Case 5
                If e.KeyChar = Chr(13) Then
                    If TextBox20.Text <> "" Then
                        DataGrid4.Item(FILA_DATA4, 5) = TextBox20.Text
                        RESTA = CInt(DataGrid4.Item(FILA_DATA4, 3)) - CInt(DataGrid4.Item(FILA_DATA4, 5))
                        NET = DataGrid4.Item(FILA_DATA4, 3)
                        DataGrid4.Item(FILA_DATA4, 4) = Format(CDbl(((RESTA / NET)) * 100), "##.#")
                        mycell.ColumnNumber = 3
                        mycell.RowNumber = FILA_DATA4
                        DataGrid4.CurrentCell = mycell
                    End If
                End If
        End Select
    End Sub

    Private Sub TextBox20_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.GotFocus
        TextBox20.SelectionStart = 1
    End Sub

    Private Sub DataGrid4_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid4.DoubleClick
        Dim respuesta As MsgBoxResult
        Dim FILA_DATAGRID4 As Integer
        Dim style As MsgBoxStyle
        Dim dr, FILA_DATAROW, FILA_COMBO As DataRow
        Dim Es_Combo As Boolean
        Dim MUESTRA, msg, CODIGO_ELE, COSTO, UNIDAD As String
        Dim COLUMNA, TOTAL, DESCUENTO, SUBTOTAL As Integer
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim objSum As Object
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo noprecio
        FILA_DATAGRID4 = myGrid.CurrentCell.RowNumber
        If GroupBox8.Visible = True Then
            Call Extraer_Descripcion(myGrid, FILA_DATAGRID4) : GoTo noprecio
        End If
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = myGrid.Item(FILA_DATAGRID4, 1)
        dr.Item("CTD_CANTIDAD") = 1
        If myGrid.Item(FILA_DATAGRID4, 3) = 0 Then
            MsgBox("No existe precio para este analisis")
            GoTo noprecio
        End If
        If IsDBNull(myGrid.Item(FILA_DATAGRID4, 4)) = False Then
            DESCUENTO = myGrid.Item(FILA_DATAGRID4, 4)
        Else
            DESCUENTO = 0
        End If
        If DESCUENTO <> 0 Then
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID4, 5)
        Else
            dr.Item("CTD_UNITARIO") = myGrid.Item(FILA_DATAGRID4, 3)
        End If
        dr.Item("CTD_SUBTOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = dr.Item("CTD_UNITARIO")
        dr.Item("ANA_ANALISIS") = myGrid.Item(FILA_DATAGRID4, 2)
        If Mid(myGrid.Item(FILA_DATAGRID4, 1), 1, 1) = "1" Then MUESTRA = "FOLIAR"
        If Mid(myGrid.Item(FILA_DATAGRID4, 1), 1, 1) = "4" Then MUESTRA = "SUELO"
        If Mid(myGrid.Item(FILA_DATAGRID4, 1), 1, 1) = "3" Then MUESTRA = "AGUA"
        If Mid(myGrid.Item(FILA_DATAGRID4, 1), 1, 1) = "2" Then MUESTRA = "FRUTO"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
            objSum = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            SUBTOTAL = CInt(objSum)
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            myGrid.Item(FILA_DATAGRID4, 0) = "X"
            'MsgBox("Análisis cargado al Detalle de Cotización")
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
noprecio:
    End Sub

    Public Sub CARGA_CODIGO_ANALISIS(ByVal CODIGO_COB As Double, ByRef muestra As Boolean)
        Dim FILA_NOTAS_C As DataRow
        Dim consulta_nota As String
        SqlConnection1.Open()
        Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").Clear()
        consulta_nota = "select COMBO_ANALISIS.ANA_CODIGO,ANALISIS.ANA_ANALISIS from COMBO_ANALISIS,ANALISIS WHERE COMBO_ANALISIS.ANA_CODIGO=ANALISIS.ANA_CODIGO AND COB_CODIGO=" & CODIGO_COB & "ORDER BY COMBO_ANALISIS.ANA_CODIGO"
        Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader = myCommand3.ExecuteReader()
        While myReader2.Read()
            Try
                FILA_NOTAS_C = Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").NewRow
                FILA_NOTAS_C.Item("ANA_CODIGO") = myReader2.GetDouble(0)
                FILA_NOTAS_C.Item("ANA_ANALISIS") = myReader2.GetString(1)
                Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").Rows.Add(FILA_NOTAS_C)
                muestra = True
            Catch ex As Exception
                muestra = False
            End Try
        End While
        myReader2.Close()
        SqlConnection1.Close()
    End Sub

    Public Sub TRASPASA_COMBO_COTIZA(ByVal numero_c As Double)
        Dim FILA_C As DataRow
        Dim consulta_nota As String
        SqlConnection1.Open()
        Cjto_Cotizacion1.Tables("COMBO_COTIZA").Clear()
        consulta_nota = "select COMBO_COTIZA.COB_CODIGO,COMBO_COTIZA.ANA_CODIGO,ANALISIS.ANA_ANALISIS from COMBO_COTIZA,ANALISIS WHERE COMBO_COTIZA.ANA_CODIGO=ANALISIS.ANA_CODIGO AND COMBO_COTIZA.COT_NUMERO=" & numero_c
        Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader = myCommand3.ExecuteReader()
        While myReader2.Read()
            Try
                FILA_C = Cjto_Cotizacion1.Tables("COMBO_COTIZA").NewRow
                FILA_C.Item("COB_CODIGO") = myReader2.GetDouble(0)
                FILA_C.Item("ANA_CODIGO") = myReader2.GetDouble(1)
                FILA_C.Item("ANA_ANALISIS") = myReader2.GetString(2)
                Cjto_Cotizacion1.Tables("COMBO_COTIZA").Rows.Add(FILA_C)
            Catch ex As Exception
            End Try
        End While
        If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COMBO_COTIZA").AcceptChanges()
        myReader2.Close()
        SqlConnection1.Close()
    End Sub

    Public Sub REVISA_COMBO_COTIZA(ByRef ES_COMBO As Boolean, ByVal COD_AN As Double)
        Dim FILA_Cc, FILA_AA As DataRow
        Dim bola As Object
        Dim consulta_nota, TIPO As String
        bola = COD_AN
        FILA_AA = Cjto_Cotizacion1.Tables("ANALISIS").Rows.Find(bola)
        TIPO = FILA_AA("TIPO_COD")
        If TIPO = "CO" Then
            SqlConnection1.Open()
            consulta_nota = "select COMBO_ANALISIS.COB_CODIGO,COMBO_ANALISIS.ANA_CODIGO,ANALISIS.ANA_ANALISIS from COMBO_ANALISIS,ANALISIS WHERE COMBO_ANALISIS.ANA_CODIGO=ANALISIS.ANA_CODIGO AND COMBO_ANALISIS.COB_CODIGO=" & COD_AN
            Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader2 As SqlDataReader = myCommand3.ExecuteReader()
            While myReader2.Read()
                Try
                    FILA_Cc = Cjto_Cotizacion1.Tables("COMBO_ANALISIS1").NewRow
                    FILA_Cc.Item("ANA_CODIGO") = myReader2.GetDouble(1)
                    FILA_Cc.Item("ANA_ANALISIS") = myReader2.GetString(2)
                    Cjto_Cotizacion1.Tables("COMBO_ANALISIS1").Rows.Add(FILA_Cc)
                    ES_COMBO = True
                Catch ex As Exception
                End Try
            End While
            myReader2.Close()
            SqlConnection1.Close()
        End If
    End Sub

    Private Sub graba_Combo_Cotiza()
        Dim FILA_DATAROW As DataRow
        Dim Combo_Cod, Combo_Can As Double
        Dim consulta_nota As String
        SqlConnection1.Open()
        For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COMBO_COTIZA").Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                Combo_Can = FILA_DATAROW("COB_CODIGO")
                Combo_Cod = FILA_DATAROW("ANA_CODIGO")
                consulta_nota = "INSERT INTO COMBO_COTIZA (COT_NUMERO,COB_CODIGO,ANA_CODIGO) VALUES (" & CDbl(TextBox1.Text) & "," & Combo_Can & "," & Combo_Cod & ")"
                Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        SqlConnection1.Close()
        Cjto_Cotizacion1.Tables("COMBO_COTIZA").AcceptChanges()
    End Sub

    Private Sub graba_SQL_Cotiza()
        Dim FILA_DATAROW As DataRow
        Dim Combo_Cod, Combo_Can As Double
        Dim consulta_nota, fecha_inv, atencion As String
        SqlConnection1.Open()
        atencion = Me.TextBox8.Text
        Me.control_nombre(atencion)
        fecha_inv = Mid(TextBox3.Text, 1, 2) & "-" & Mid(TextBox3.Text, 4, 2) & "-" & Mid(TextBox3.Text, 7, 4)
        For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZACION").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                atencion = Me.TextBox8.Text
                Me.control_nombre(atencion)
                consulta_nota = "UPDATE COTIZACION SET COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & "," & _
                "COT_RUT=" & "'" & TextBox2.Text & "'" & "," & _
                "COT_NOMBRE=" & "'" & TextBox23.Text & "'" & "," & _
                "COT_EMAIL=" & "'" & TextBox9.Text & "'" & "," & _
                "COT_ATENCION=" & "'" & atencion & "'" & "," & _
                "COT_DIRECCION=" & "'" & TextBox7.Text & "'" & "," & _
                "COT_COMUNA=" & "'" & CBComuna.Text & "'" & "," & _
                "COT_FONO=" & "'" & TextBox10.Text & "'" & "," & _
                "COT_FAX=" & "'" & TextBox11.Text & "'" & "," & _
                "COT_SUBTOTAL=0," & _
                "COT_DESCUENTO=0," & _
                "COT_NETO=0," & _
                "COT_IVA=0," & _
                "COT_TOTAL=0," & _
                "COT_FECHA=" & "'" & fecha_inv & "'" & "," & _
                "COT_CELULAR=" & "'" & TextBox16.Text & "'" & "," & _
                "COT_CIUDAD=" & "'" & CBCiudad.Text & "'" & "," & _
                "COT_EMPRESA=" & "'" & TextBox22.Text & "'" & "," & _
                "COT_MUE1=" & "'" & MUESTRA1 & "'" & "," & _
                "COT_MUE2=" & "'" & MUESTRA2 & "'" & "," & _
                "COT_MUE3=" & "'" & MUESTRA3 & "'" & "," & _
                "COT_MUE4=" & "'" & MUESTRA4 & "'" & "," & _
                "COT_EMAIL2=" & "'" & TextBox14.Text & "'" & "," & _
               "COT_CARGO=" & "'" & TextBox12.Text & "'" & " " & _
               "WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text))
                Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                End Try

            End If

            If FILA_DATAROW.RowState = DataRowState.Added Then
                consulta_nota = "INSERT INTO COTIZACION " & _
                "(COT_NUMERO,COT_RUT,COT_NOMBRE,COT_EMAIL,COT_ATENCION,COT_DIRECCION,COT_COMUNA,COT_FONO,COT_FAX,COT_SUBTOTAL,COT_DESCUENTO,COT_NETO,COT_IVA,COT_TOTAL,COT_FECHA,COT_CELULAR,COT_CIUDAD,COT_EMPRESA,COT_MUE1,COT_MUE2,COT_MUE3,COT_MUE4,COT_EMAIL2,COT_CARGO) " & _
                "VALUES (" & CDbl(Val(TextBox1.Text)) & "," & _
                 "'" & TextBox2.Text & "'" & "," & _
                 "'" & TextBox23.Text & "'" & "," & _
                 "'" & TextBox9.Text & "'" & "," & _
                 "'" & atencion & "'" & "," & _
                 "'" & TextBox7.Text & "'" & "," & _
                 " '" & CBCiudad.Text & "'" & "," & _
                 "'" & TextBox10.Text & "'" & "," & _
                 " '" & TextBox11.Text & "'" & "," & _
                 "0,0,0,0,0" & "," & _
                 "'" & fecha_inv & "'" & "," & _
                 "'" & TextBox16.Text & "'" & "," & _
                 "'" & CBCiudad.Text & "'" & "," & _
                 "'" & TextBox22.Text & "'" & "," & _
                 "'" & MUESTRA1 & "'" & "," & _
                 "'" & MUESTRA2 & "'" & "," & _
                 "'" & MUESTRA3 & "'" & "," & _
                 "'" & MUESTRA4 & "'" & "," & _
                 "'" & TextBox14.Text & "'" & "," & _
                 "'" & TextBox12.Text & "'" & ")"
                Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                Dim myReader3 As SqlDataReader
                Try
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                Catch ex As Exception
                End Try
            End If
        Next
        SqlConnection1.Close()
    End Sub

    Private Sub GRABA_CONCURRENCIA(ByVal SiNo As String)
        Dim consulta_nota As String
        SqlConnection1.Open()
        consulta_nota = "UPDATE CONCURRENCIA_COT SET CONCURRENCIA=" & "'" & SiNo & "'" & " WHERE NUM_CON=1"
        Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader3 As SqlDataReader
        Try
            myReader3 = myCommand4.ExecuteReader()
            myReader3.Close()
        Catch ex As Exception
        End Try
        SqlConnection1.Close()
    End Sub

    Private Sub graba_SQL_Detalle()
        Try
            Dim FILA_DATAROW As DataRow
            Dim Combo_Cod, Combo_Can As Double
            Dim consulta_nota As String
            SqlConnection1.Open()
            For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows
                If FILA_DATAROW.RowState = DataRowState.Modified Then
                    consulta_nota = "UPDATE COTIZA_DETALLE SET COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & "," & _
                    "CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS") & "," & _
                    "CTD_CANTIDAD=" & FILA_DATAROW("CTD_CANTIDAD") & "," & _
                    "CTD_UNITARIO=" & FILA_DATAROW("CTD_UNITARIO") & "," & _
                    "CTD_SUBTOTAL=" & FILA_DATAROW("CTD_SUBTOTAL") & "," & _
                    "CTD_DESCUENTO=" & FILA_DATAROW("CTD_DESCUENTO") & "," & _
                    "CTD_TOTAL=" & FILA_DATAROW("CTD_TOTAL") & "," & _
                    "ANA_ANALISIS=" & "'" & FILA_DATAROW("ANA_ANALISIS") & "'" & "," & _
                    "CTD_MUESTRA=" & "'" & FILA_DATAROW("CTD_MUESTRA") & "'" & " " & _
                    "WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
                If FILA_DATAROW.RowState = DataRowState.Added Then
                    consulta_nota = "INSERT INTO COTIZA_DETALLE " & _
    "(COT_NUMERO,CTD_ANALISIS,CTD_CANTIDAD,CTD_UNITARIO,CTD_SUBTOTAL,CTD_DESCUENTO,CTD_TOTAL,ANA_ANALISIS,CTD_MUESTRA) " & _
    "VALUES (" & FILA_DATAROW("COT_NUMERO") & "," & _
    FILA_DATAROW("CTD_ANALISIS") & "," & FILA_DATAROW("CTD_CANTIDAD") & "," & _
    FILA_DATAROW("CTD_UNITARIO") & "," & FILA_DATAROW("CTD_SUBTOTAL") & "," & _
    FILA_DATAROW("CTD_DESCUENTO") & "," & FILA_DATAROW("CTD_TOTAL") & "," & _
    "'" & FILA_DATAROW("ANA_ANALISIS") & "'" & "," & "'" & FILA_DATAROW("CTD_MUESTRA") & "'" & ")"
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    Try
                        myReader3 = myCommand4.ExecuteReader()
                        myReader3.Close()
                    Catch ex As SqlException
                        MsgBox(ex.Message)
                    End Try

                End If
                If FILA_DATAROW.RowState = DataRowState.Deleted Then
                    consulta_nota = "DELETE FROM COTIZA_DETALLE WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
            Next
            SqlConnection1.Close()
        Catch ex As Exception
            SqlConnection1.Close()
        End Try
    End Sub

    Private Sub graba_SQL_Nota()
        Dim FILA_DATAROW As DataRow
        Dim Combo_Cod, Combo_Can As Double
        Dim consulta_nota As String
        SqlConnection1.Open()

        consulta_nota = "UPDATE NOTA_ULTIMA_COT SET NOTA_NUM=1" & _
                        ",NOTA_DESCRIPCION=" & "'" & RTxtAlto.Text & "'" & _
                        " WHERE NOTA_NUM=1"
        Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader4 As SqlDataReader
        myReader4 = myCommand4.ExecuteReader()
        myReader4.Close()

        consulta_nota = "UPDATE NOTA_ULTIMA_COT SET NOTA_NUM=2" & _
                                ",NOTA_DESCRIPCION=" & "'" & RTxtMedio.Text & "'" & _
                                " WHERE NOTA_NUM=2"
        Dim myCommand5 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader5 As SqlDataReader
        myReader5 = myCommand5.ExecuteReader()
        myReader5.Close()

        consulta_nota = "UPDATE NOTA_ULTIMA_COT SET NOTA_NUM=3" & _
                                ",NOTA_DESCRIPCION=" & "'" & RTxtBajo.Text & "'" & _
                                " WHERE NOTA_NUM=3"
        Dim myCommand6 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader6 As SqlDataReader
        myReader6 = myCommand6.ExecuteReader()
        myReader6.Close()
        '
        'NOTAS KITS
        '
        consulta_nota = "UPDATE NOTA_ULTIMA_COTK SET NOTA_NUM=1" & _
                                ",NOTA_DESCRIPCION=" & "'" & RichTextBox1.Text & "'" & _
                                " WHERE NOTA_NUM=1"
        Dim myCommand7 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader7 As SqlDataReader
        myReader7 = myCommand7.ExecuteReader()
        myReader7.Close()

        consulta_nota = "UPDATE NOTA_ULTIMA_COTK SET NOTA_NUM=3" & _
                         ",NOTA_DESCRIPCION=" & "'" & RichTextBox3.Text & "'" & _
                         " WHERE NOTA_NUM=3"
        Dim myCommand9 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader9 As SqlDataReader
        myReader9 = myCommand9.ExecuteReader()
        myReader9.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub graba_SQL_cotiza_analisis()
        Try

   
            Dim FILA_DATAROW As DataRow
            Dim lag, posi As Integer
            Dim Combo_Cod, Combo_Can As Double
            Dim consulta_nota, des, des_paso, des_pri, des_ult As String
            SqlConnection1.Open()
            For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows
                lag = Len(FILA_DATAROW("CTA_DESCUENTO"))
                posi = InStr(FILA_DATAROW("CTA_DESCUENTO"), ",")
                If posi <> 0 Then
                    des_pri = Mid(FILA_DATAROW("CTA_DESCUENTO"), 1, (posi - 1))
                    des_ult = Mid(FILA_DATAROW("CTA_DESCUENTO"), (posi + 1), lag)
                    des = des_pri & "." & des_ult
                Else
                    des = CStr(FILA_DATAROW("CTA_DESCUENTO"))
                End If
                If FILA_DATAROW.RowState = DataRowState.Modified Then
                    consulta_nota = "UPDATE COTIZA_ANALISIS SET COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & "," & _
                    "CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS") & "," & _
                    "CTA_UNITARIO=" & FILA_DATAROW("CTA_UNITARIO") & "," & _
                    "CTA_DESCUENTO=" & des & "," & _
                    "CTA_NETO=" & FILA_DATAROW("CTA_NETO") & " " & _
                    "WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
                If FILA_DATAROW.RowState = DataRowState.Added Then
                    consulta_nota = "INSERT INTO COTIZA_ANALISIS " & _
                    "(COT_NUMERO,CTD_ANALISIS,CTA_UNITARIO,CTA_DESCUENTO,CTA_NETO) " & _
                    "VALUES (" & FILA_DATAROW("COT_NUMERO") & "," & _
                    FILA_DATAROW("CTD_ANALISIS") & "," & _
                    FILA_DATAROW("CTA_UNITARIO") & "," & _
                    des & "," & FILA_DATAROW("CTA_NETO") & ")"
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
                If FILA_DATAROW.RowState = DataRowState.Deleted Then
                    consulta_nota = "DELETE FROM COTIZA_ANALISIS WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND CTD_ANALISIS=" & FILA_DATAROW("CTD_ANALISIS")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
            Next
            SqlConnection1.Close()
        Catch ex As Exception
            SqlConnection1.Close()
        End Try
    End Sub

    Private Sub graba_SQL_combo_cotiza()
        Try

      
            Dim FILA_DATAROW As DataRow
            Dim Combo_Cod, Combo_Can As Double
            Dim consulta_nota As String
            SqlConnection1.Open()
            For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COMBO_COTIZA").Rows
                If FILA_DATAROW.RowState = DataRowState.Modified Then
                    consulta_nota = "UPDATE COMBO_COTIZA SET COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & "," & _
                    "COB_CODIGO=" & FILA_DATAROW("COB_CODIGO") & "," & _
                    "ANA_CODIGO=" & FILA_DATAROW("ANA_CODIGO") & "," & _
                    "WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND COB_CODIGO=" & FILA_DATAROW("COD_CODIGO") & " AND ANA_CODIGO=" & FILA_DATAROW("ANA_CODIGO")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
                If FILA_DATAROW.RowState = DataRowState.Added Then
                    consulta_nota = "INSERT INTO COMBO_COTIZA " & _
                    "(COT_NUMERO,COB_CODIGO,ANA_CODIGO) " & _
                    "VALUES (" & FILA_DATAROW("COT_NUMERO") & "," & _
                    FILA_DATAROW("COB_CODIGO") & "," & FILA_DATAROW("ANA_CODIGO") & ")"
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
                If FILA_DATAROW.RowState = DataRowState.Deleted Then
                    consulta_nota = "DELETE FROM COMBO_COTIZA WHERE COT_NUMERO=" & CDbl(Val(TextBox1.Text)) & " AND COB_CODIGO=" & FILA_DATAROW("COB_CODIGO") & " AND ANA_CODIGO=" & FILA_DATAROW("ANA_CODIGO")
                    Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                    Dim myReader3 As SqlDataReader
                    myReader3 = myCommand4.ExecuteReader()
                    myReader3.Close()
                End If
            Next
            SqlConnection1.Close()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub CARGA_COMBO_COTIZA(ByVal CODIGO_COB As Double, ByRef muestra As Boolean)
        Dim FILA_COMCOT, FILA_CO As DataRow
        Dim consulta_nota As String
        Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").Clear()
        For Each FILA_COMCOT In Cjto_Cotizacion1.Tables("COMBO_COTIZA").Rows
            Try
                If CODIGO_COB = FILA_COMCOT("COB_CODIGO") Then
                    FILA_CO = Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").NewRow
                    FILA_CO.Item("ANA_CODIGO") = FILA_COMCOT.Item("ANA_CODIGO")
                    FILA_CO.Item("ANA_ANALISIS") = FILA_COMCOT.Item("ANA_ANALISIS")
                    Cjto_Cotizacion1.Tables("CODIGO_ANALISIS").Rows.Add(FILA_CO)
                    muestra = True
                End If
            Catch ex As Exception
                muestra = False
            End Try
        Next
    End Sub

    Private Sub DataGrid1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid1.MouseDown
        Dim codana As Double
        Dim TIPO As String
        Dim FILA_ANALISIS As DataRow
        Dim BOLA As Object
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        hti = myGrid_j.HitTest(e.X, e.Y)
        If hti.Column = 1 And hti.Row <> -1 Then
            Try
                BOLA = myGrid_j.Item(hti.Row, 1)
                codana = myGrid_j.Item(hti.Row, 1)
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("ANALISIS").Rows.Find(BOLA)
                TIPO = FILA_ANALISIS("TIPO_COD")
                If TIPO = "JC" Then
                    Call CARGA_COMBO_COTIZA(codana, muestra)
                Else
                    Call CARGA_CODIGO_ANALISIS(codana, muestra)
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub COTEMP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COTEMP.Click
        Try

     
            If RadioButton1.Checked = False And RadioButton2.Checked = False Then
                MsgBox("Seleccione base para realizar busqueda")
            End If
            If RadioButton1.Checked = True Then
                Me.SqlSelectCommand19.Parameters("@RUT_COT").Value = TextBox22.Text & "%"
                Me.SqlSelectCommand19.Parameters("@EMPRESA_COT").Value = TextBox22.Text & "%"
                'Call cambio_color_boton()
                COTEMP.BackColor = Color.FromName("Info")
                Cjto_Cotizacion1.Tables("COTIZACION1").Clear()
                Adap_Cot_Emp.Fill(Cjto_Cotizacion1, "COTIZACION1")
                GroupBox10.Visible = True
                GroupBox25.Visible = True
                DataGrid6.Focus()
            End If

            If RadioButton2.Checked = True Then
                Me.SqlSelectCommand21.Parameters("@PRO_RUT").Value = TextBox22.Text & "%"
                Me.SqlSelectCommand21.Parameters("@PRO_EMPRESA").Value = TextBox22.Text & "%"
                'Call cambio_color_boton()
                Cjto_Cotizacion1.Tables("PRODUCTOR").Clear()
                Adap_Empresa_Con.Fill(Cjto_Cotizacion1, "PRODUCTOR")
                'DataGrid5.Visible = True
                'DataGrid5.Focus()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Seleccione base para realizar busqueda")
        End If
        'Call cambio_color_boton()
        If RadioButton1.Checked = True Then
            Me.SqlSelectCommand20.Parameters("@RUT_COT").Value = TextBox8.Text & "%"
            Me.SqlSelectCommand20.Parameters("@ATENCION_COT").Value = TextBox8.Text & "%"
            Button13.BackColor = Color.FromName("Info")
            Cjto_Cotizacion1.Tables("COTIZACION1").Clear()
            Adap_Cot_At.Fill(Cjto_Cotizacion1, "COTIZACION1")
            GroupBox10.Visible = True
            GroupBox25.Visible = True
            'DataGrid6.Visible = True
            DataGrid6.Focus()
        End If
        If RadioButton2.Checked = True Then
            Me.SqlSelectCommand22.Parameters("@PRO_RUT").Value = TextBox8.Text & "%"
            Me.SqlSelectCommand22.Parameters("@PRO_ATENCION").Value = TextBox8.Text & "%"
            Call cambio_color_boton()
            'Button15.BackColor = Color.FromName("Info")
            Cjto_Cotizacion1.Tables("PRODUCTOR").Clear()
            Adap_Atencion.Fill(Cjto_Cotizacion1, "PRODUCTOR")
            'DataGrid5.Visible = True
            'DataGrid5.Focus()
        End If
    End Sub

    Private Sub cambio_color_boton()
        COTEMP.BackColor = Color.FromName("Control")
        Button13.BackColor = Color.FromName("Control")
        'Button14.BackColor = Color.FromName("Control")
        Button8.BackColor = Color.FromName("Control")
        'Button7.BackColor = Color.FromName("Control")
        'Button15.BackColor = Color.FromName("Control")
    End Sub

    Private Sub control_nombre(ByRef nomb As String)
        Dim lar, i, j As Integer
        Dim acumula As String
        lar = Len(nomb)
        acumula = "" : j = 0
        For i = 1 To lar
            If Mid(nomb, i, 4) = "S.A." Then acumula = acumula & "S.A." : Exit For
            If i = 1 Then acumula = UCase(Mid(nomb, 1, 1)) : GoTo continuar
            If j = 1 Then acumula = acumula & UCase(Mid(nomb, i, 1)) : j = 0 : GoTo continuar
            If Mid(nomb, i, 1) = " " Then acumula = acumula & " " : j = 1 : GoTo continuar
            acumula = acumula & LCase(Mid(nomb, i, 1))
continuar:
        Next
        nomb = acumula
    End Sub

    Private Sub BORDES_KIT(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal IB As Integer, ByVal FB As Integer)
        HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & FB.ToString).BorderAround()
        HOJA_EXCEL.Range("AA" & IB.ToString & ":AB" & FB.ToString).BorderAround()
        HOJA_EXCEL.Range("AC" & IB.ToString & ":AE" & FB.ToString).BorderAround()
        HOJA_EXCEL.Range("AF" & IB.ToString & ":AH" & FB.ToString).BorderAround()
    End Sub

    Private Sub BORDES_KIT_SUAVES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal FB As Integer)
        With HOJA_EXCEL.Range("A" & FB.ToString & ":Z" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AA" & FB.ToString & ":AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & FB.ToString & ":AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & FB.ToString & ":AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Private Sub BORDES_INTERNOS(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal INB As Integer, ByVal FB As Integer)
        With HOJA_EXCEL.Range("A" & INB.ToString & ":Y" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & INB.ToString & ":Y" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & INB.ToString & ":Y" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & INB.ToString & ":Y" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & INB.ToString & ":AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & INB.ToString & ":AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & INB.ToString & ":AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & INB.ToString & ":AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'RE
        With HOJA_EXCEL.Range("AC" & INB.ToString & ":AC" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & INB.ToString & ":AC" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & INB.ToString & ":AC" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & INB.ToString & ":AC" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'C1
        With HOJA_EXCEL.Range("AD" & INB.ToString & ":AD" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("AD" & INB.ToString & ":AD" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("AD" & INB.ToString & ":AD" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AD" & INB.ToString & ":AD" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'C2
        With HOJA_EXCEL.Range("AE" & INB.ToString & ":AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & INB.ToString & ":AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & INB.ToString & ":AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & INB.ToString & ":AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'C3
        With HOJA_EXCEL.Range("AF" & INB.ToString & ":AF" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & INB.ToString & ":AF" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & INB.ToString & ":AF" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & INB.ToString & ":AF" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'TPO
        With HOJA_EXCEL.Range("AG" & INB.ToString & ":AG" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & INB.ToString & ":AG" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & INB.ToString & ":AG" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & INB.ToString & ":AG" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'NIV
        With HOJA_EXCEL.Range("AH" & INB.ToString & ":AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & INB.ToString & ":AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & INB.ToString & ":AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & INB.ToString & ":AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

    End Sub

    Public Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal IB As Integer, ByVal FB As Integer)
        Dim LIN As Integer
        With HOJA_EXCEL.Range("A" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("B" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("B" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("C" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("C" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("D" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("D" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("E" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("E" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("F" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("F" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("G" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("G" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("H" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("H" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("I" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("I" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("J" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("J" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("K" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("K" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("L" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("L" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("M" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("M" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("N" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("N" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("O" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("O" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("P" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("P" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Q" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Q" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("R" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("R" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("S" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("S" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("T" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("T" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("U" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("U" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("V" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("V" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("W" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("W" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("X" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("X" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Y" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Y" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AA" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AA" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AB" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AB" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AD" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AD" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        'With HOJA_EXCEL.Range("AI" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
        '    .LineStyle = Excel.XlLineStyle.xlContinuous
        '    .Weight = Excel.XlBorderWeight.xlHairline
        '    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        'End With
        'With HOJA_EXCEL.Range("AI" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
        '    .LineStyle = Excel.XlLineStyle.xlContinuous
        '    .Weight = Excel.XlBorderWeight.xlHairline
        '    .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        'End With

        For LIN = IB To FB
            With HOJA_EXCEL.Range("A" & LIN.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("AH" & LIN.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        Next

        With HOJA_EXCEL.Range("A" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With

        With HOJA_EXCEL.Range("B" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("C" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("D" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("E" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("F" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("G" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("H" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("I" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("J" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("K" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("L" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("M" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("N" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("O" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("P" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Q" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("R" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("S" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("T" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("U" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("V" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("W" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("X" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Y" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("Z" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AA" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AB" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AC" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AD" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AE" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AF" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AG" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & FB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim USU, MER As String
        Dim FILA_ESTADO, FILA_LISTA As DataRow
        MER = 0
        USU = System.Environment.UserName
        'If USU <> "Rmillan" Then
        'MsgBox("El usuario no esta autorizado para Grabar")
        'Else
        Try
            Adap_Man_Ana.Update(Cjto_Cotizacion1, "ANALISIS")
            Cjto_Cotizacion1.Tables("ANALISIS").Clear()
            Adap_Man_Ana.Fill(Cjto_Cotizacion1, "ANALISIS")
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
            Cjto_Cotizacion1.Tables("COMBO_ANALISIS").Clear()
            Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = TextBox1.Text
            Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
            Adap_Combo_Ana.Fill(Cjto_Cotizacion1, "COMBO_ANALISIS")
            Call TRASPASO_ANALISIS()
        Catch ex As Exception
            MsgBox("Debe ingresar todos los datos (Código,$Neto,Nivel)", "", "Analisis Incompleto")
        End Try

    End Sub

    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MsgBox("Seleccione base para realizar busqueda")
        End If
        If RadioButton1.Checked = True Then
            Me.SqlSelectCommand11.Parameters("@RUT_COT").Value = TextBox2.Text & "%"
            Me.SqlSelectCommand11.Parameters("@NOMBRE_COT").Value = TextBox2.Text & "%"
            'Call cambio_color_boton()
            Button8.BackColor = Color.FromName("Info")
            Cjto_Cotizacion1.Tables("COTIZACION1").Clear()
            Adap_Con_Cot.Fill(Cjto_Cotizacion1, "COTIZACION1")
            GroupBox10.Visible = True
            GroupBox25.Visible = True
            'DataGrid6.Visible = True
            DataGrid6.Focus()
        End If
        If RadioButton2.Checked = True Then
            Me.SqlSelectCommand9.Parameters("@PRO_RUT").Value = TextBox2.Text & "%"
            Me.SqlSelectCommand9.Parameters("@PRO_NOMBRE").Value = TextBox2.Text & "%"
            'Call cambio_color_boton()
            Cjto_Cotizacion1.Tables("PRODUCTOR").Clear()
            Adap_Productor.Fill(Cjto_Cotizacion1, "PRODUCTOR")
            'DataGrid5.Visible = True
            'DataGrid5.Focus()
        End If
    End Sub

    Private Sub DataGrid9_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim codana As Double
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        Dim FILA_DATAROW, dr As DataRow
        Dim fila As Integer
        Dim Form_mod As New frm_modificar
        hti = myGrid_j.HitTest(e.X, e.Y)
        If hti.Column = 0 And hti.Row <> -1 Then
            Try
                'codana = myGrid_j.Item(hti.Row, 0)
                'Call CARGA_CODIGO_ANALISIS(codana, muestra)
                'If muestra = True Then DataGrid10.Visible = True
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub DataGrid13_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGrid13.MouseDown
        Dim codana As Double
        Dim muestra As Boolean = False
        Dim myGrid_j As DataGrid = CType(sender, DataGrid)
        Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        hti = myGrid_j.HitTest(e.X, e.Y)
        If (hti.Column = 3 Or hti.Column = 5 Or hti.Column = 6) Then
            If Nivel > 1 Then
                MsgBox("El usuario no esta autorizado para modificar esta columna. Solo puede modificar C-1")
                GoTo NOUSUARIO
            End If
        End If
        If (hti.Column = 3 Or hti.Column = 4 Or hti.Column = 5 Or hti.Column = 6) And hti.Row <> -1 Then
            Try
                If IsDBNull(myGrid_j.Item(hti.Row, hti.Column)) = True Then myGrid_j.Item(hti.Row, hti.Column) = ""
                If myGrid_j.Item(hti.Row, hti.Column) = "x" Then
                    myGrid_j.Item(hti.Row, hti.Column) = ""
                Else
                    myGrid_j.Item(hti.Row, hti.Column) = "x"
                End If
            Catch ex As Exception

            End Try
        End If
NOUSUARIO:
    End Sub

    Private Sub DataGrid14_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim response As MsgBoxResult
        Dim COLLU, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Double
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        COLLU = MYGRID.CurrentCell.ColumnNumber
        fila = MYGRID.CurrentCell.RowNumber
        If COLLU = 0 Then
            FILA_DATAROW = Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila)
            Cod_Ana = FILA_DATAROW("TMU_CODIGO")
            Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila).Delete()
            Adap_Muestra.Update(Cjto_Cotizacion1, "MUESTRA")
            Cjto_Cotizacion1.Tables("MUESTRA").Clear()
            Adap_Muestra.Fill(Cjto_Cotizacion1, "MUESTRA")
        End If
    End Sub

    Private Sub DataGrid15_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim COLLU, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Double
        Dim MYGRID As DataGrid = CType(sender, DataGrid)
        COLLU = MYGRID.CurrentCell.ColumnNumber
        fila = MYGRID.CurrentCell.RowNumber
        If COLLU = 0 Then
            FILA_DATAROW = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila)
            Cod_Ana = FILA_DATAROW("SUB_CODIGO")
            Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila).Delete()
            Adap_Submuestra.Update(Cjto_Cotizacion1, "SUBMUESTRA")
            Cjto_Cotizacion1.Tables("SUBMUESTRA").Clear()
            Adap_Submuestra.Fill(Cjto_Cotizacion1, "SUBMUESTRA")
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        Adap_Muestra.Update(Cjto_Cotizacion1, "MUESTRA")
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        Adap_Submuestra.Update(Cjto_Cotizacion1, "SUBMUESTRA")
        Cjto_Cotizacion1.Tables("SUBMUESTRA").Clear()
        Adap_Submuestra.Fill(Cjto_Cotizacion1, "SUBMUESTRA")
    End Sub

    Private Sub TextBox22_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox22.LostFocus
        TextBox22.Text = UCase(TextBox22.Text)
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DataGrid14.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DataGrid14.CurrentCell = mycell
    End Sub

    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        Dim FILA_DATAROW, dr As DataRow
        Dim fila As Integer
        Dim Form_mue As New frm_Muestra
        Form_mue.BackColor = Color.LightSteelBlue
        mod_nuevo = 0
        fila = DataGrid14.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila)
        Try
            mue_cod = FILA_DATAROW("TMU_CODIGO")
            mue_des = FILA_DATAROW("TMU_MUESTRA")
            MOD_MUE = "S"
            Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila).Delete()
            Adap_Muestra.Update(Cjto_Cotizacion1, "MUESTRA")
            Adap_Muestra.Fill(Cjto_Cotizacion1, "MUESTRA")
            Form_mue.Show()
        Catch ex As Exception
            MsgBox("Seleccione código")
        End Try
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Double
        Dim respuesta As MsgBoxResult
        cll = DataGrid14.CurrentCell.ColumnNumber
        fila = DataGrid14.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila)
        Cod_Ana = FILA_DATAROW("TMU_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            If cll = 0 Then
                DALE = 1
                Cjto_Cotizacion1.Tables("MUESTRA").Rows(fila).Delete()
            End If
        End If
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        fii = DataGrid15.CurrentCell.RowNumber.MaxValue
        mycell.ColumnNumber = 0
        mycell.RowNumber = fii
        DataGrid15.CurrentCell = mycell
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        Dim FILA_DATAROW, dr As DataRow
        Dim fila As Integer
        Dim Form_submue As New frm_Submuestra
        mod_nuevo = 0
        fila = DataGrid15.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila)
        Try
            sub_sub = FILA_DATAROW("SUB_CODIGO")
            sub_des = FILA_DATAROW("SUB_DESCRIPCION")
            sub_cod = FILA_DATAROW("TMU_CODIGO")
            MOD_SUB = "S"
            Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila).Delete()
            Adap_Submuestra.Update(Cjto_Cotizacion1, "SUBMUESTRA")
            Adap_Submuestra.Fill(Cjto_Cotizacion1, "SUBMUESTRA")
            Form_submue.Show()
        Catch ex As Exception
            MsgBox("Seleccione código")
        End Try
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Double
        Dim respuesta As MsgBoxResult
        cll = DataGrid15.CurrentCell.ColumnNumber
        fila = DataGrid15.CurrentCell.RowNumber
        FILA_DATAROW = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila)
        Cod_Ana = FILA_DATAROW("SUB_CODIGO")
        respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            If cll = 0 Then
                DALE = 1
                Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows(fila).Delete()
            End If
        End If
    End Sub

    Private Sub Button21_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button21.Click
        Dim FILA_DATAROW, dr, FILA_B As DataRow
        Dim FILA_NOTAS_C, FILA_CC As DataRow
        Dim BOLA1(1) As Object
        Dim consulta_nota, ff As String
        Des_Jocker_Fila = ""
        Suma_Valor_Jocker = 0
        TextBox36.Text = ""
        TextBox37.Text = ""
        TextBox4.Text = ""
        TextBox6.Text = ""
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage2"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 1 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage5"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 2 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage4"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 3 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage3"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 4 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage11"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 5 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage8"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 6 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage12"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 7 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
            Case "TabPage13"
                For Each FILA_B In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    BOLA1(0) = CDbl(Val(TextBox1.Text))
                    BOLA1(1) = FILA_B("ANA_CODIGO")
                    FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Find(BOLA1)
                    If (FILA_CC Is Nothing) Then
                        If Val(Mid(FILA_B("ANA_CODIGO"), 1, 1)) = 8 And FILA_B("TIPO_COD") = "JA" Then
                            GroupBox8.Visible = True
                            TextBox35.Text = FILA_B("ANA_CODIGO")
                            TextBox36.Text = FILA_B("ANA_ANALISIS")
                            TextBox37.Text = FILA_B("ANA_NETO")
                            Exit For
                        End If
                    End If
                Next
        End Select
    End Sub

    Private Sub Button39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage2"
                DataGrid2.Focus()
            Case "TabPage5"
                DataGrid8.Focus()
            Case "TabPage4"
                DataGrid4.Focus()
            Case "TabPage3"
                DataGrid3.Focus()
            Case "TabPage11"
                DataGrid16.Focus()
            Case "TabPage8"
                DataGrid27.Focus()
            Case "TabPage12"
                DataGrid17.Focus()
            Case "8.Kit-Ven"
                DataGrid18.Focus()
        End Select
    End Sub

    Private Sub elimina_cotiza_analisis(ByVal FILA_DATAROW As DataRow)
        Dim FILA_CC As DataRow
        Dim BOLA1(1) As Object
        Dim numero_cot, codigo_analisis As Double
        Dim consulta_nota As String
        SqlConnection1.Open()
        numero_cot = CDbl(TextBox1.Text)
        codigo_analisis = FILA_DATAROW("CTD_ANALISIS")
        consulta_nota = "DELETE FROM COTIZA_ANALISIS WHERE COT_NUMERO=" & numero_cot & " AND CTD_ANALISIS=" & codigo_analisis
        Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        SqlConnection1.Close()
        BOLA1(0) = CDbl(Val(TextBox1.Text))
        BOLA1(1) = FILA_DATAROW("CTD_ANALISIS")
        FILA_CC = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Find(BOLA1)
        Try
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Remove(FILA_CC)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TextBox22_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox22.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox23.Focus()
        End If
    End Sub

    Private Sub TextBox23_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox23.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox8.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.CBComuna.Focus()
        End If
    End Sub

    Private Sub TextBox38_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox38.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox39.Focus()
        End If
    End Sub

    Private Sub TextBox39_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox39.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox9.Focus()
        End If
    End Sub

    Private Sub TextBox9_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox9.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox14.Focus()
        End If
    End Sub

    Private Sub TextBox14_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox14.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox10_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox10.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox16.Focus()
        End If
    End Sub

    Private Sub TextBox11_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox11.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox10.Focus()
        End If
    End Sub

    Private Sub IMPRIME_LINEA_COTIZACION(ByVal fila_cotiza1 As DataRow, ByVal cod_ult As Double, ByVal HOJA_EXCEL As Excel.Worksheet, ByRef j As Integer, ByRef suma_pixeles As Double, ByVal pix As Double)
        Dim fila_combo, fila_analisis As DataRow
        Dim primera_linea_combo, PUNTOS_X, TIPO, Acumula As String
        Dim bola As Object
        Dim suma_pix, suma_pix2, RestaExt As Double
        Dim prim As Integer
        Dim A, fila_llave, FILA_PARA_PRECIO_F, SinPuntos, CuentaBlancos, Total_Kit As Integer
        Dim query, Caracter As String
        Dim i, ant, linea As Integer
        PUNTOS_X = "......................................................................................................................................................................................................................................"
        If CheckBox49.Checked = True Then PUNTOS_X = ""
        bola = fila_cotiza1("CTD_ANALISIS")
        fila_analisis = Cjto_Cotizacion1.Tables("ANALISIS").Rows.Find(bola)
        query = fila_cotiza1("ANA_ANALISIS")
        If Es_SubMuestra = "N" Then
            For i = 1 To query.Length
                Caracter = Mid(query, i, 1)
                If Asc(Caracter) = 10 Then
                    If Es_Combo_Cot = "N" And CheckBox49.Checked = False Then j = j + 1 : suma_pixeles = suma_pixeles + pix
                    Exit For
                End If
            Next
        End If
        suma_pix = suma_pixeles
        j = j + 1 : suma_pixeles = suma_pixeles + pix
        FILA_PARA_PRECIO_F = j
        fila_llave = 1
        Es_Combo_Cot = "N"
        primera_linea_combo = "S"
        SinPuntos = 0 : CuentaBlancos = 0
        For i = 1 To query.Length
            Caracter = Mid(query, i, 1)
            If Asc(Caracter) = 13 Then Caracter = " "
            If Caracter = " " Then CuentaBlancos = CuentaBlancos + 1
            If Asc(Caracter) <> 10 And Caracter <> " " Then CuentaBlancos = 0
            If Asc(Caracter) = 10 Then
                If CuentaBlancos > 4 Then SinPuntos = 1
                HOJA_EXCEL.Range("A" & j.ToString).Value = "  " & Acumula & "   " & PUNTOS_X
                If primera_linea_combo = "S" Then
                    HOJA_EXCEL.Range("AE" & j.ToString).Value = " " : primera_linea_combo = "N"
                End If
                fila_llave = fila_llave + 1
                j = j + 1 : suma_pixeles = suma_pixeles + pix
                Acumula = ""
            Else
                Acumula = Acumula + Caracter
            End If
        Next
        HOJA_EXCEL.Range("A" & j.ToString).Value = "  " & Acumula & "   " & PUNTOS_X
        If fila_llave > 1 And CheckBox49.Checked = False Then FILA_PARA_PRECIO_F = FILA_PARA_PRECIO_F + 1
        If CheckBox49.Checked = False Then
            HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).Merge()
            HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO_F.ToString).Value = "$"
            HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).Merge()
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString).Value = Format(fila_cotiza1("CTD_SUBTOTAL"), "####,###")
        Else
            'Cant
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString & ":AB" & j.ToString).Merge()
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString).Value = Format(fila_cotiza1("CTD_CANTIDAD"), "####")
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString & ":AB" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString & ":AB" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            HOJA_EXCEL.Range("AA" & FILA_PARA_PRECIO_F.ToString & ":AB" & j.ToString).NumberFormat = "####"
            '$ Unitario
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).Merge()
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString).Value = Format(fila_cotiza1("CTD_UNITARIO"), "####,###")
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).NumberFormat = "###.###"

            '$ Total
            Total_Kit = CInt(fila_cotiza1("CTD_CANTIDAD")) * CInt(fila_cotiza1("CTD_UNITARIO"))
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).Merge()
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString & ":AH" & j.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString).Font.Size = 8.5
            HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO_F.ToString).Value = Format(Total_Kit, "####,###")
            HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO_F.ToString & ":AE" & j.ToString).NumberFormat = "####.###"
            Call BORDES_KIT_SUAVES(HOJA_EXCEL, j)
        End If
        Suma_Para_Neto = Suma_Para_Neto + CInt(Total_Kit)
        If CheckBox49.Checked = False Then
            If fila_llave > 1 Then
                suma_pix2 = suma_pix - 5
                If SinPuntos = 1 Then
                    suma_pix2 = suma_pix2 + 12
                    RestaExt = 5
                Else
                    RestaExt = -5
                End If
                If fila_llave = 2 And RestaExt <> -5 Then
                    RestaExt = -5
                Else
                    HOJA_EXCEL.Shapes.AddShape(32, 428.25, suma_pix2, 5, ((fila_llave - 1) * 12) - RestaExt)
                End If
                j = j + 1 : suma_pixeles = suma_pixeles + pix
                Es_Combo_Cot = "S"
            End If
        End If
    End Sub

    Private Sub Button34_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button34.Click
        Dim FILA_C, FILA_COM, dr As DataRow
        Dim MUESTRA As String
        Dim Valor_Det As Integer
        If CInt(TextBox37.Text) = 0 Then MsgBox("Falta Precio Jocker Análisis") : GoTo nosale
        dr = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
        dr.BeginEdit()
        dr.Item("COT_NUMERO") = CDbl(Val(TextBox1.Text))
        dr.Item("CTD_ANALISIS") = CDbl(TextBox35.Text)
        dr.Item("CTD_CANTIDAD") = 1
        If TextBox6.Text <> "" Then Valor_Det = CInt(TextBox6.Text) Else Valor_Det = CInt(TextBox37.Text)
        dr.Item("CTD_UNITARIO") = Valor_Det 'CInt(TextBox37.Text)
        dr.Item("CTD_SUBTOTAL") = Valor_Det 'CInt(TextBox37.Text)
        dr.Item("CTD_DESCUENTO") = 0
        dr.Item("CTD_TOTAL") = Valor_Det 'CInt(TextBox37.Text)
        dr.Item("ANA_ANALISIS") = TextBox36.Text
        If Val(Mid(TextBox35.Text, 1, 1)) = 1 Then MUESTRA = "FOLIAR"
        If Val(Mid(TextBox35.Text, 1, 1)) = 2 Then MUESTRA = "FRUTO"
        If Val(Mid(TextBox35.Text, 1, 1)) = 3 Then MUESTRA = "AGUA"
        If Val(Mid(TextBox35.Text, 1, 1)) = 4 Then MUESTRA = "SUELO"
        If Val(Mid(TextBox35.Text, 1, 1)) = 5 Then MUESTRA = "FERT-QUI"
        If Val(Mid(TextBox35.Text, 1, 1)) = 6 Then MUESTRA = "FERT-ORG"
        If Val(Mid(TextBox35.Text, 1, 1)) = 7 Then MUESTRA = "+ANALISIS"
        If Val(Mid(TextBox35.Text, 1, 1)) = 8 Then MUESTRA = "KIT,OTROS"
        dr.Item("CTD_MUESTRA") = MUESTRA
        dr.EndEdit()
        Try
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(dr)
        Catch ex As Exception
            MsgBox("Análisis ya fue cargado")
        End Try
        GroupBox8.Visible = False
nosale:
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        GroupBox8.Visible = False
    End Sub

    Private Sub Button44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button44.Click
        GroupBox9.Visible = False
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage2"
                DataGrid2.Focus()
            Case "TabPage5"
                DataGrid8.Focus()
            Case "TabPage4"
                DataGrid4.Focus()
            Case "TabPage3"
                DataGrid3.Focus()
            Case "TabPage11"
                DataGrid16.Focus()
            Case "TabPage8"
                DataGrid16.Focus()
            Case "TabPage12"
                DataGrid17.Focus()
            Case "TabPage13"
                DataGrid18.Focus()
        End Select
    End Sub

    Private Sub Button46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button46.Click
        GroupBox9.Visible = True
        TextBox40.Focus()
        le = 0
    End Sub

    Private Sub Button45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button45.Click
        Dim yll, texto, MAYU As String
        Dim av, MyPos, filmax As Integer
        Dim FILA_DATAROW As DataRow
        Dim mycell As New DataGridCell
        yll = TabControl1.SelectedTab.Name
        texto = TextBox40.Text
        av = 0
        Select Case yll
            Case "TabPage2"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid2.CurrentCell = mycell
                        DataGrid2.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage5"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid8.CurrentCell = mycell
                        DataGrid8.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage4"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid4.CurrentCell = mycell
                        DataGrid4.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage3"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid3.CurrentCell = mycell
                        DataGrid3.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage11"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid16.CurrentCell = mycell
                        DataGrid16.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage8"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid27.CurrentCell = mycell
                        DataGrid27.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage12"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid17.CurrentCell = mycell
                        DataGrid17.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage13"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid18.CurrentCell = mycell
                        DataGrid18.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage9"
                For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                    MAYU = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    If IsDBNull(FILA_DATAROW("ANA_ANALISIS")) = False Then MyPos = InStr(MAYU, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 0
                        mycell.RowNumber = av
                        DataGrid13.CurrentCell = mycell
                        DataGrid13.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
        End Select
    End Sub

    Private Sub Button47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button47.Click
        GroupBox10.Visible = False
        GroupBox25.Visible = False
        GroupBox26.Visible = False
        ' TextBox22.Text = ""
        'TextBox23.Text = ""
        'TextBox2.Text = ""
        'TextBox8.Text = ""
    End Sub

    Private Sub Button48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button48.Click
        Try
            Process.Start("C:\WINNT\Explorer.exe", "F:\Archivos LabSys\Cotizacion")
        Catch ex As Exception
            Process.Start("C:\WINDOWS\Explorer.exe", "F:\Archivos LabSys\Cotizacion")
        End Try

    End Sub

    Private Sub Button49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button49.Click
        Try
            Dim explorador As Outlook.Explorer
            Dim mOutLookApp As Outlook.Application
            Dim mNameSpace As Outlook.NameSpace
            Dim mItem As Outlook.MailItem
            Dim colAttach As Outlook.Attachments
            Dim l_Attach As Outlook.Attachment
            Dim nompr, carpr, via, empn, ate As String
            Dim num_com, f As Integer
            If TextBox22.Text <> "" Then
                nompr = TextBox22.Text
            Else
                nompr = TextBox23.Text
            End If
            via = ""
            For f = 1 To Len(nompr)
                carpr = Mid(nompr, f, 1)
                If carpr = "." Then carpr = " "
                via = via + carpr
            Next
            ate = TextBox8.Text
            Call control_nombre(ate)
            If ate <> "" Then ate = "Atención:" & ate & Chr(13)
            num_com = Val(TextBox1.Text)
            mOutLookApp = New Outlook.Application
            mNameSpace = mOutLookApp.GetNamespace("MAPI")
            'mNameSpace.Logon(, , False, True)
            mItem = mOutLookApp.CreateItem(0)
            mItem.To = TextBox9.Text
            mItem.CC = TextBox14.Text
            mItem.Subject = "Cotizacion Agrolab Ltda."
            If TextBox22.Text <> "" Then
                empn = TextBox22.Text
            Else
                empn = TextBox23.Text
            End If
            mItem.Body = "Señor(es):" & Chr(13) & _
                         empn & Chr(13) & _
                         ate & Chr(13) & _
                         "Adjunto cotización solicitada. Si tiene alguna duda acerca de esta, envíenos un mail o llamenos a nuestro fono donde con gusto resolveremos su inquietud." & Chr(13) & _
                         "Atentamente," & Chr(13) & Chr(13) & _
                         "Agrolab Ltda." & Chr(13) & Chr(13) & _
                         "Fono   :(02) 225 8087" & Chr(13) & _
                         "e-mail : laboratorio@agrolab.cl" & Chr(13) & _
                         "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
            colAttach = mItem.Attachments
            Dim xls As String = "F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .xls"
            Dim pdf As String = "F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .pdf"
            convierteApdf(xls, pdf)
            l_Attach = colAttach.Add(pdf)
            'l_Attach = colAttach.Add("F:\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .xls")
            mItem.Display()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CBElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBElimina.Click
        Dim Combo_Cod, Combo_Can As Double
        Dim respuesta As MsgBoxResult
        Dim consulta_nota As String
        respuesta = MsgBox("¿ ELIMINA COTIZACION ? ", MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            SqlConnection1.Open()
            consulta_nota = "DELETE FROM COTIZACION WHERE COT_NUMERO=" & ncoti
            Dim myCommand1 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
            myReader1.Close()

            consulta_nota = "DELETE FROM COTIZA_DETALLE WHERE COT_NUMERO=" & ncoti
            Dim myCommand2 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
            myReader2.Close()


            consulta_nota = "DELETE FROM COTIZA_ANALISIS WHERE COT_NUMERO=" & ncoti
            Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader4 As SqlDataReader = myCommand4.ExecuteReader()
            myReader4.Close()

            consulta_nota = "DELETE FROM COMBO_COTIZA WHERE COT_NUMERO=" & ncoti
            Dim myCommand5 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader5 As SqlDataReader = myCommand5.ExecuteReader()
            myReader5.Close()
            SqlConnection1.Close()
            Me.Close()
        End If
    End Sub

    Private Sub CmdModificaAnt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdModificaAnt.Click
        Dim BOLA, BOLA1, OBJSUM As Object
        Dim respuesta As MsgBoxResult
        Dim fecha_deg, mensajes As String
        Dim NCOT As Double
        Dim FILA_ANALISIS, FILA_OTRO, FILA_NOTAS, FILA_COTIZA2, FILA_COTIZA3, FILA_COTIZA, fila_cot, FILA_DETALLE, Fila_Rev As DataRow
        Dim SUBTOTAL, ffi As Integer
        DESDE_CONSULTA = 0
        Try
            NCOT = ncoti
            BOLA = NCOT
            fila_cot = Cjto_Cotizacion1.Tables("COTIZACION1").Rows.Find(BOLA)
            If Not (fila_cot Is Nothing) Then

                TextBox1.Text = fila_cot("COT_NUMERO")
                DESDE_CONSULTA = 1
                TextBox2.Text = fila_cot("COT_RUT")
                TextBox9.Text = fila_cot("COT_EMAIL")
                TextBox8.Text = fila_cot("COT_ATENCION")
                TextBox7.Text = fila_cot("COT_DIRECCION")
                TextBox10.Text = fila_cot("COT_FONO")
                TextBox11.Text = fila_cot("COT_FAX")
                fecha_deg = fila_cot("COT_FECHA")
                'fecha_deg = Mid(fecha_deg, 4, 2) & "-" & Mid(fecha_deg, 1, 2) & "-" & Mid(fecha_deg, 7, 4)
                TextBox3.Text = fecha_deg
                TextBox16.Text = fila_cot("COT_CELULAR")
                If fila_cot("COT_CIUDAD") <> "" Then CBCiudad.Text = fila_cot("COT_CIUDAD")
                If fila_cot("COT_COMUNA") <> "" Then CBComuna.Text = fila_cot("COT_COMUNA")
                TextBox23.Text = fila_cot("COT_NOMBRE")
                TextBox22.Text = fila_cot("COT_EMPRESA")
                TextBox14.Text = fila_cot("COT_EMAIL2")
                If IsDBNull(fila_cot("COT_CARGO")) = False Then TextBox12.Text = fila_cot("COT_CARGO")
                If fila_cot("COT_MUE1") = "XLS" Then MUESTRA1 = "XLS"
                DEL_GRA = 1
            End If
            Cjto_Cotizacion1.Tables("COTIZACION").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS2").Clear()
            Me.SqlSelectCommand12.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Con_Det.Fill(Cjto_Cotizacion1, "COTIZA_DETALLE1")
            Me.SqlSelectCommand15.Parameters("@NUMERO_COT").Value = NCOT
            Me.SqlSelectCommand14.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Con_Notas.Fill(Cjto_Cotizacion1, "COTIZA_NOTAS1")
            Adap_Con_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS2")
            Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
            If mensajes = "" Then
                Call TRASPASA_COMBO_COTIZA(NCOT)
                For Each FILA_COTIZA In Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Rows
                    FILA_DETALLE = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                    FILA_DETALLE.BeginEdit()
                    FILA_DETALLE.Item("COT_NUMERO") = CDbl(TextBox1.Text)
                    FILA_DETALLE.Item("CTD_ANALISIS") = FILA_COTIZA("CTD_ANALISIS")
                    FILA_DETALLE.Item("CTD_CANTIDAD") = FILA_COTIZA("CTD_CANTIDAD")
                    FILA_DETALLE.Item("CTD_UNITARIO") = FILA_COTIZA("CTD_UNITARIO")
                    FILA_DETALLE.Item("CTD_SUBTOTAL") = FILA_COTIZA("CTD_SUBTOTAL")
                    FILA_DETALLE.Item("CTD_DESCUENTO") = FILA_COTIZA("CTD_DESCUENTO")
                    FILA_DETALLE.Item("CTD_TOTAL") = FILA_COTIZA("CTD_TOTAL")
                    FILA_DETALLE.Item("ANA_ANALISIS") = FILA_COTIZA("ANA_ANALISIS")
                    FILA_DETALLE.Item("CTD_MUESTRA") = FILA_COTIZA("CTD_MUESTRA")
                    FILA_DETALLE.EndEdit()
                    BOLA1 = FILA_COTIZA("CTD_ANALISIS")
                    FILA_OTRO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS_BASE").Rows.Find(BOLA1)
                    Try
                        FILA_OTRO.Item("CHEQUEO") = "X"
                        Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_DETALLE)
                    Catch ex As Exception

                    End Try

                Next
                If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COTIZA_DETALLE").AcceptChanges()
            End If
            Call TRASPASO_ANALISIS()
            For Each FILA_COTIZA3 In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS2").Rows
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.BeginEdit()
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(TextBox1.Text)
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_COTIZA3.Item("CTD_ANALISIS")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_COTIZA3.Item("CTA_UNITARIO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_COTIZA3.Item("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = FILA_COTIZA3.Item("CTA_NETO")
                FILA_ANALISIS.EndEdit()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
            Next
            If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").AcceptChanges()
            'ComboBox2.Text = myGrid.Item(hti.Row, 3)
            OBJSUM = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            If IsDBNull(OBJSUM) = False Then
                SUBTOTAL = CDbl(OBJSUM)
            Else
                SUBTOTAL = 0
            End If
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            Call graba_cotizacion()
        Catch ex As Exception

        End Try
        GroupBox10.Visible = False
        GroupBox25.Visible = False
        Me.GroupBox11.Visible = False
    End Sub

    Private Sub CmdCreaNueva_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdCreaNueva.Click
        Dim BOLA, BOLA1, OBJSUM As Object
        Dim respuesta As MsgBoxResult
        Dim fecha_deg, mensajes As String
        Dim NCOT As Double
        Dim FILA_ANALISIS, FILA_OTRO, FILA_NOTAS, FILA_COTIZA2, FILA_COTIZA3, FILA_COTIZA, fila_cot, FILA_DETALLE, Fila_Rev As DataRow
        Dim SUBTOTAL, ffi As Integer

        DESDE_CONSULTA = 0
        mensajes = ""
        MUESTRA1 = "" : MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = ""
        Try
            NCOT = ncoti
            BOLA = NCOT
            fila_cot = Cjto_Cotizacion1.Tables("COTIZACION1").Rows.Find(BOLA)
            If Not (fila_cot Is Nothing) Then
                TextBox2.Text = fila_cot("COT_RUT")
                TextBox9.Text = fila_cot("COT_EMAIL")
                TextBox8.Text = fila_cot("COT_ATENCION")
                TextBox7.Text = fila_cot("COT_DIRECCION")
                TextBox10.Text = fila_cot("COT_FONO")
                TextBox11.Text = fila_cot("COT_FAX")
                'fecha_deg = fila_cot("COT_FECHA")
                'fecha_deg = Mid(fecha_deg, 4, 2) & "-" & Mid(fecha_deg, 1, 2) & "-" & Mid(fecha_deg, 7, 4)
                'TextBox3.Text = fecha_deg
                TextBox16.Text = fila_cot("COT_CELULAR")
                If fila_cot("COT_CIUDAD") <> "" Then CBCiudad.Text = fila_cot("COT_CIUDAD")
                If fila_cot("COT_COMUNA") <> "" Then CBComuna.Text = fila_cot("COT_COMUNA")
                TextBox23.Text = fila_cot("COT_NOMBRE")
                TextBox22.Text = fila_cot("COT_EMPRESA")
                TextBox14.Text = fila_cot("COT_EMAIL2")
                If IsDBNull(fila_cot("COT_CARGO")) = False Then TextBox12.Text = fila_cot("COT_CARGO")
                DEL_GRA = 1
            End If
            Cjto_Cotizacion1.Tables("COTIZACION").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_ANALISIS2").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_NOTAS1").Clear()
            Cjto_Cotizacion1.Tables("COTIZA_NOTAS").Clear()
            Me.SqlSelectCommand12.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Con_Det.Fill(Cjto_Cotizacion1, "COTIZA_DETALLE1")
            Me.SqlSelectCommand15.Parameters("@NUMERO_COT").Value = NCOT
            Me.SqlSelectCommand14.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Con_Notas.Fill(Cjto_Cotizacion1, "COTIZA_NOTAS1")
            Adap_Con_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS2")
            Me.SqlSelectCommand1.Parameters("@NUMERO_COT").Value = NCOT
            Adap_Analisis.Fill(Cjto_Cotizacion1, "COTIZA_ANALISIS_BASE")
            For Each FILA_COTIZA In Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Rows
                BOLA1 = FILA_COTIZA("CTD_ANALISIS")
                Fila_Rev = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS_BASE").Rows.Find(BOLA1)
                If Not (Fila_Rev Is Nothing) Then
                    If Fila_Rev("ANA_ANALISIS") <> FILA_COTIZA("ANA_ANALISIS") Then
                        mensajes = "Se encontro cambio de Descripción en el codigo análisis" & FILA_COTIZA("CTD_ANALISIS")
                        MsgBox(mensajes)
                        Exit For
                    End If
                Else
                    mensajes = "No se encontro código análisis " & FILA_COTIZA("CTD_ANALISIS") & " , ver original Excel"
                    MsgBox(mensajes)
                    Exit For
                End If
            Next
            If mensajes = "" Then
                Call TRASPASA_COMBO_COTIZA(NCOT)
                For Each FILA_COTIZA In Cjto_Cotizacion1.Tables("COTIZA_DETALLE1").Rows
                    FILA_DETALLE = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").NewRow
                    FILA_DETALLE.BeginEdit()
                    FILA_DETALLE.Item("COT_NUMERO") = CDbl(TextBox1.Text)
                    FILA_DETALLE.Item("CTD_ANALISIS") = FILA_COTIZA("CTD_ANALISIS")
                    FILA_DETALLE.Item("CTD_CANTIDAD") = FILA_COTIZA("CTD_CANTIDAD")
                    FILA_DETALLE.Item("CTD_UNITARIO") = FILA_COTIZA("CTD_UNITARIO")
                    FILA_DETALLE.Item("CTD_SUBTOTAL") = FILA_COTIZA("CTD_SUBTOTAL")
                    FILA_DETALLE.Item("CTD_DESCUENTO") = FILA_COTIZA("CTD_DESCUENTO")
                    FILA_DETALLE.Item("CTD_TOTAL") = FILA_COTIZA("CTD_TOTAL")
                    FILA_DETALLE.Item("ANA_ANALISIS") = FILA_COTIZA("ANA_ANALISIS")
                    FILA_DETALLE.Item("CTD_MUESTRA") = FILA_COTIZA("CTD_MUESTRA")
                    FILA_DETALLE.EndEdit()
                    BOLA1 = FILA_COTIZA("CTD_ANALISIS")
                    FILA_OTRO = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Find(BOLA1)
                    FILA_OTRO.Item("CHEQUEO") = "X"
                    Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Rows.Add(FILA_DETALLE)
                Next
                If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COTIZA_DETALLE").AcceptChanges()
            End If
            Call TRASPASO_ANALISIS()
            For Each FILA_COTIZA3 In Cjto_Cotizacion1.Tables("COTIZA_ANALISIS2").Rows
                FILA_ANALISIS = Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").NewRow
                FILA_ANALISIS.BeginEdit()
                FILA_ANALISIS.Item("COT_NUMERO") = CDbl(TextBox1.Text)
                FILA_ANALISIS.Item("CTD_ANALISIS") = FILA_COTIZA3.Item("CTD_ANALISIS")
                FILA_ANALISIS.Item("CTA_UNITARIO") = FILA_COTIZA3.Item("CTA_UNITARIO")
                FILA_ANALISIS.Item("CTA_DESCUENTO") = FILA_COTIZA3.Item("CTA_DESCUENTO")
                FILA_ANALISIS.Item("CTA_NETO") = FILA_COTIZA3.Item("CTA_NETO")
                FILA_ANALISIS.EndEdit()
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").Rows.Add(FILA_ANALISIS)
            Next
            If DESDE_CONSULTA = 1 Then Cjto_Cotizacion1.Tables("COTIZA_ANALISIS").AcceptChanges()
            'ComboBox2.Text = myGrid.Item(hti.Row, 3)
            OBJSUM = Cjto_Cotizacion1.Tables("COTIZA_DETALLE").Compute("Sum(CTD_SUBTOTAL)", "CTD_SUBTOTAL > 0")
            If IsDBNull(OBJSUM) = False Then
                SUBTOTAL = CDbl(OBJSUM)
            Else
                SUBTOTAL = 0
            End If
            'Label3.Text = Format(SUBTOTAL, "####,##0")
            Call graba_cotizacion()
        Catch ex As Exception
        End Try
        GroupBox10.Visible = False
        GroupBox25.Visible = False
        Me.GroupBox11.Visible = False
        RadioButton3.Checked = True
    End Sub

    Private Sub DataGrid6_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid6.DoubleClick
        Dim myGrid As DataGrid = CType(sender, DataGrid)
        Dim hti As System.Windows.Forms.DataGrid.HitTestInfo
        Dim ffi As Integer
        ffi = DataGrid6.CurrentCell.RowNumber
        ncoti = myGrid.Item(ffi, 0)
        Me.CmdModificaAnt.Text = "Modifica"
        Me.CmdCreaNueva.Text = "Nueva"
        Me.CmdVerExcel.Text = "Ver Excel"
        Me.GroupBox11.Visible = True
    End Sub

    Private Sub CmdVerExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdVerExcel.Click
        Dim m_outlook As Outlook.Application
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim BOLA As Object
        Dim fila_cot As DataRow
        Dim nomb, destino, carpr, via As String
        Dim f As Integer
        BOLA = ncoti
        fila_cot = Cjto_Cotizacion1.Tables("COTIZACION1").Rows.Find(BOLA)
        nomb = fila_cot("COT_EMPRESA")
        For f = 1 To Len(nomb)
            carpr = Mid(nomb, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        destino = "F:\Archivos LabSys\Cotizacion\" & ncoti & " " & "Cotizacion  " & via & " .xls"

        m_Excel = CreateObject("EXCEL.APPLICATION")
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
    End Sub

    Private Sub CBComuna_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 
        If e.KeyChar = Chr(13) Then
            Dim tempAdapter As New SqlDataAdapter
            Dim datos As New DataSet
            Dim query As String
            Dim fila As DataRow
            'Me.SqlConnection1.Open()
            query = "select * from cotiza_comunas where cod_comuna = '" & Me.CBComuna.Text & "'"
            tempAdapter.SelectCommand = New SqlCommand(query, Me.SqlConnection1)
            tempAdapter.Fill(datos, "Cotiza_comunas")
            For Each fila In datos.Tables(0).Rows
                CBCiudad.Text = fila("COD_CIUDAD")
            Next
            Me.CBCiudad.Focus()
        End If
    End Sub

    Private Sub CBCiudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) 
        If e.KeyChar = Chr(13) Then
            TextBox9.Focus()
        End If
    End Sub

    Private Sub CmdEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEnviar.Click
        Dim fila_cot As DataRow
        Dim BOLA As Object
        Dim mOutLookApp As Outlook.Application
        Dim mNameSpace As Outlook.NameSpace
        Dim mItem As Outlook.MailItem
        Dim colAttach As Outlook.Attachments
        Dim l_Attach As Outlook.Attachment
        Dim nompr, carpr, via, empn, ate, email, email2 As String
        Dim num_com, f As Integer
        BOLA = ncoti
        fila_cot = Cjto_Cotizacion1.Tables("COTIZACION1").Rows.Find(BOLA)
        nompr = fila_cot("COT_EMPRESA")
        ate = fila_cot("COT_ATENCION")
        Call control_nombre(ate)
        If ate <> "" Then ate = "Atención:" & ate & Chr(13) Else ate = ""
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        num_com = Val(ncoti)
        email = fila_cot("COT_EMAIL")
        email2 = fila_cot("COT_EMAIL2")
        mOutLookApp = New Outlook.Application
        mNameSpace = mOutLookApp.GetNamespace("MAPI")
        'mNameSpace.Logon(, , False, True)
        mItem = mOutLookApp.CreateItem(0)
        mItem.To = email
        mItem.CC = email2
        mItem.Subject = "Cotizacion Agrolab Ltda."
        mItem.Body = "Señor(es):" & Chr(13) & _
                     nompr & Chr(13) & _
                     ate & Chr(13) & _
                     "Adjunto cotización solicitada. Si tiene alguna duda acerca de esta, envíenos un mail o llamenos a nuestro fono donde con gusto resolveremos su inquietud." & Chr(13) & _
                     "Atentamente," & Chr(13) & Chr(13) & _
                     "Agrolab Ltda." & Chr(13) & Chr(13) & _
                     "Fono   :(02) 225 8087" & Chr(13) & _
                     "e-mail : laboratorio@agrolab.cl" & Chr(13) & _
                     "Web    : www.agrolab.cl" & Chr(13) & Chr(13)
        colAttach = mItem.Attachments
        Dim xls As String = "F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .xls"
        Dim pdf As String = "F:\Archivos LabSys\Cotizacion\" & num_com & " " & "Cotizacion  " & via & " .pdf"
        convierteApdf(xls, pdf)
        l_Attach = colAttach.Add(pdf)
        'l_Attach = colAttach.Add("F:\Cotizacion\7712 Cotizacion  AGRICOLA BAUZA .xls")
        mItem.Display()
    End Sub

    Public Sub convierteApdf(ByVal xls As String, ByVal pdf As String)
        Dim paramSourceBookPath As String = xls
        Dim paramExportFilePath As String = pdf
        Dim paramExportFormat As Excel.XlFixedFormatType = Excel.XlFixedFormatType.xlTypePDF
        Dim paramExportQuality As Excel.XlFixedFormatQuality = Excel.XlFixedFormatQuality.xlQualityStandard
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



        'Dim workbook1 As Microsoft.Office.Interop.Excel.Workbook

        'Dim excelapp As New Microsoft.Office.Interop.Excel.Application

        'workbook1 = excelapp.Workbooks.Open(xls)

        'CType(workbook1.Sheets(1), Microsoft.Office.Interop.Excel.Worksheet).PrintOut(, , 1, False, ActivePrinter:="Acrobat Distiller sur Ne07:", PrintToFile:=True, Collate:=False, PrToFileName:=pdf)

        ''Dim xtp As New SautinSoft.UseOffice
        'Dim result As Integer = xtp.ConvertFile(xls, pdf, SautinSoft.UseOffice.eDirection.XLS_to_PDF)
        'If result = 0 Then
        '    System.Console.WriteLine("Converted successfully!")
        '    System.Diagnostics.Process.Start(pdf)
        'Else
        '    System.Console.WriteLine("Converting Error!")
        'End If

    End Sub

    Private Sub Button52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button52.Click
        Dim FILA_DATAROW, dr As DataRow
        Dim respuesta As MsgBoxResult
        Dim ana_neto, cdesde, chasta, valrea As Double
        Dim tmu_codigo, largorea, h As Integer
        Dim consulta_nota, reajuste As String
        respuesta = MsgBox("........Confirma Reajuste........", MsgBoxStyle.YesNo)
        If respuesta = MsgBoxResult.Yes Then
            valrea = Math.Abs(CDbl(Val(TextBox45.Text)))
            reajuste = CStr(1 + valrea / 100)
            largorea = Len(reajuste)
            For h = 1 To largorea
                If Mid(reajuste, h, 1) = "," Then
                    Mid(reajuste, h, 1) = "."
                    Exit For
                End If
            Next
            cdesde = CDbl(Val(TextBox43.Text))
            chasta = CDbl(Val(TextBox44.Text))
            SqlConnection1.Open()
            If TextBox43.Text <> "" And TextBox44.Text <> "" Then
                If Mid(TextBox45.Text, 1, 1) = "-" Then
                    consulta_nota = "UPDATE ANALISIS SET ANA_NETO=ANA_NETO / " & reajuste & " WHERE ANA_CODIGO BETWEEN " & cdesde & " AND " & chasta
                Else
                    consulta_nota = "UPDATE ANALISIS SET ANA_NETO=ANA_NETO * " & reajuste & " WHERE ANA_CODIGO BETWEEN " & cdesde & " AND " & chasta
                End If
            End If
            Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
            Dim myReader3 As SqlDataReader
            myReader3 = myCommand4.ExecuteReader()
            myReader3.Close()
            SqlConnection1.Close()
        End If
        TextBox43.Text = ""
        TextBox44.Text = ""
        TextBox45.Text = ""
        TextBox43.Focus()
    End Sub

    Private Sub CBCierra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCierra.Click
        GroupBox11.Visible = False
    End Sub

    '***************************************************************************************
    '********************   proceso listados ***********************************************
    '***************************************************************************************

    Private Sub BTGrabaListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTGrabaListado.Click
        Dim FILA_DATAROW, dr As DataRow
        Dim consulta_nota, consulta_nota2, ana_analisis, ana_original, ana_nivel_precio, cliente1, cliente2, cliente3, clientet, tipo_cod As String
        Dim ana_codigo, ana_neto As Double
        Dim fila, tmu_codigo, sub_codigo As Integer
        Dim cfec, clog As Boolean
        cfec = True
        clog = True

        For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                ana_codigo = FILA_DATAROW("ANA_CODIGO")
                ana_analisis = FILA_DATAROW("ANA_ANALISIS")
                tmu_codigo = FILA_DATAROW("TMU_CODIGO")
                sub_codigo = FILA_DATAROW("SUB_CODIGO")
                If Not (IsDBNull(FILA_DATAROW("ANA_NETO"))) Then
                    ana_neto = Format(FILA_DATAROW("ANA_NETO"), "#####0")
                End If
                ana_nivel_precio = FILA_DATAROW("ANA_NIVEL_PRECIO")
                If Not (IsDBNull(FILA_DATAROW("CLIENTE1"))) Then
                    cliente1 = FILA_DATAROW("CLIENTE1")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTE2"))) Then
                    cliente2 = FILA_DATAROW("CLIENTE2")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTE3"))) Then
                    cliente3 = FILA_DATAROW("CLIENTE3")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTET"))) Then
                    clientet = FILA_DATAROW("CLIENTET")
                End If
                tipo_cod = FILA_DATAROW("TIPO_COD")
                consulta_nota = "UPDATE ANALISIS SET ANA_ANALISIS=" & "'" & ana_analisis & "'" & ",TMU_CODIGO=" & tmu_codigo & ",SUB_CODIGO=" & sub_codigo & ",ANA_NETO=" & ana_neto & ",ANA_NIVEL_PRECIO=" & "'" & ana_nivel_precio & "'" & ",CLIENTE1=" & "'" & cliente1 & "'" & ",CLIENTE2=" & "'" & cliente2 & "'" & ",CLIENTE3=" & "'" & cliente3 & "'" & ",CLIENTET=" & "'" & clientet & "'" & ",TIPO_COD=" & "'" & tipo_cod & "'" & " WHERE ANA_CODIGO=" & ana_codigo
                Dim mycom As New SqlCommand(consulta_nota, SqlConnection1)
                If Me.SqlConnection1.State = ConnectionState.Closed Then
                    Me.SqlConnection1.Open()
                End If
                Try
                    mycom.ExecuteNonQuery()
                    Me.SqlConnection1.Close()
                Catch ex As Exception
                End Try
            End If
        Next
        Cjto_Cotizacion1.Tables("ANALISIS").Clear()
        Adap_Man_Ana.Fill(Cjto_Cotizacion1, "ANALISIS")
        MsgBox("Grabación de Listados Finalizada")
    End Sub

    Private Sub CBExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBExcel.Click
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim FILA_DATAROW, dr As DataRow
        Dim consulta_nota, consulta_nota2, ana_analisis, ana_original, ana_nivel_precio, cliente1, cliente2, cliente3, clientet, tipo_cod As String
        Dim ana_codigo, ana_neto As Double
        Dim fila, tmu_codigo, sub_codigo As Integer
        Dim cfec, clog As Boolean
        cfec = True
        clog = True
        Lj = 1
        Lll = 7
        'Lsuma_pixeles = 63.75
        Lsuma_pixeles = 76.5
        Lcont = 60
        Carta_Lista = "N"
        'Adap_Man_Ana.Update(Cjto_Cotizacion1, "ANALISIS")
        For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                ana_codigo = FILA_DATAROW("ANA_CODIGO")
                ana_analisis = FILA_DATAROW("ANA_ANALISIS")
                tmu_codigo = FILA_DATAROW("TMU_CODIGO")
                sub_codigo = FILA_DATAROW("SUB_CODIGO")
                ana_neto = Format(FILA_DATAROW("ANA_NETO"), "#####0")
                ana_nivel_precio = FILA_DATAROW("ANA_NIVEL_PRECIO")
                If Not (IsDBNull(FILA_DATAROW("CLIENTE1"))) Then
                    cliente1 = FILA_DATAROW("CLIENTE1")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTE2"))) Then
                    cliente2 = FILA_DATAROW("CLIENTE2")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTE3"))) Then
                    cliente3 = FILA_DATAROW("CLIENTE3")
                End If
                If Not (IsDBNull(FILA_DATAROW("CLIENTET"))) Then
                    clientet = FILA_DATAROW("CLIENTET")
                End If
                tipo_cod = FILA_DATAROW("TIPO_COD")
                consulta_nota = "UPDATE ANALISIS SET ANA_ANALISIS=" & "'" & ana_analisis & "'" & ",TMU_CODIGO=" & tmu_codigo & ",SUB_CODIGO=" & sub_codigo & ",ANA_NETO=" & ana_neto & ",ANA_NIVEL_PRECIO=" & "'" & ana_nivel_precio & "'" & ",CLIENTE1=" & "'" & cliente1 & "'" & ",CLIENTE2=" & "'" & cliente2 & "'" & ",CLIENTE3=" & "'" & cliente3 & "'" & ",CLIENTET='x',TIPO_COD=" & "'" & tipo_cod & "'" & " WHERE ANA_CODIGO=" & ana_codigo
                Dim mycom As New SqlCommand(consulta_nota, SqlConnection1)
                If Me.SqlConnection1.State = ConnectionState.Closed Then
                    Me.SqlConnection1.Open()
                End If
                Try
                    mycom.ExecuteNonQuery()
                    Me.SqlConnection1.Close()
                Catch ex As Exception

                End Try
            End If
        Next
        Call Creacion_Excel_Lista(objHojaExcel, objLibroExcel)
        Call Inicio_Imprime_Lista(objHojaExcel, cfec, clog)
    End Sub

    Private Sub Creacion_Excel_Lista(ByRef objHojaExcel As Excel.Worksheet, ByVal objLibroExcel As Excel.Workbook)
        Dim fuente, destino, fcorta, fecha_alreves, nompr, carpr, num_com As String
        Dim m_Excel As Excel.Application
        Dim f As Integer
        Dim via As String
        Dim MyDate As Date
        MyDate = Today
        fecha_alreves = Mid(MyDate, 7, 4) & "-" & Mid(MyDate, 4, 2) & "-" & Mid(MyDate, 1, 2)

        If TextBox22.Text <> "" Then
            nompr = TextBox22.Text
        Else
            nompr = TextBox23.Text
        End If
        via = ""
        For f = 1 To Len(nompr)
            carpr = Mid(nompr, f, 1)
            If carpr = "." Then carpr = " "
            via = via + carpr
        Next
        num_com = Val(TextBox1.Text)

        fuente = "F:\Archivos LabSys\Formatos Labsys\Formato_Impresion.xls"
        If Lsuma_pixeles = 867 Then
            destino = "F:\Archivos LabSys\Cotizacion\Listados\" & num_com & " " & "Cotizacion  " & via & " .xls"
        Else
            destino = "F:\Archivos LabSys\Cotizacion\Listados\Lista de Precio " & fecha_alreves & ".xls"
        End If
        m_Excel = CreateObject("EXCEL.APPLICATION")
        Try
            FileCopy(fuente, destino)
        Catch ex As Exception
            MsgBox("Documento Abierto")
            GoTo noimprime
        End Try
        objLibroExcel = m_Excel.Workbooks.Open(destino)
        m_Excel.Visible = True
        objHojaExcel = objLibroExcel.Worksheets(1)
        objHojaExcel.Visible = Excel.XlSheetVisibility.xlSheetVisible
        objHojaExcel.Activate()
noimprime:
    End Sub

    Private Sub Inicio_Imprime_Lista(ByRef objHojaExcel As Excel.Worksheet, ByVal cfec As Boolean, ByVal clog As Boolean)
        Dim fuente, destino, fcorta, fecha_alreves As String
        Dim largo, Fila_Consulte, Fila_Pie As Integer
        Dim MyDate As Date
        Lpix = 12.75
        MyDate = Today
        ElPrimero = "S"
        ConFrec = 0
        If Lj = 62 Then
            objHojaExcel.Range("A63").Select()
            objHojaExcel.Pictures.Insert("F:\Archivos LabSys\Imagenes\Logo  mediano Agro.jpg").Select()
        Else
            objHojaExcel.Range("A62:AH62").Merge()
            objHojaExcel.Range("A62").Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
            objHojaExcel.Range("A62").Font.Size = 8
            objHojaExcel.Range("A62:AH62").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        End If
        Try
            Lj = Lj + 1
            If cfec = True Then
                If CheckBox5.Checked = True Or CheckBox6.Checked = True _
                   Or CheckBox11.Checked = True Or CheckBox12.Checked = True _
                   Or CheckBox17.Checked = True Or CheckBox18.Checked = True _
                   Or CheckBox23.Checked = True Or CheckBox24.Checked = True _
                   Or CheckBox29.Checked = True Or CheckBox30.Checked = True _
                   Or CheckBox35.Checked = True Or CheckBox36.Checked = True _
                   Or CheckBox41.Checked = True Or CheckBox42.Checked = True _
                   Or CheckBox47.Checked = True Or CheckBox48.Checked = True _
                   Or CheckBox50.Checked = True Or CheckBox51.Checked = True _
                   Or CheckBox52.Checked = True Or CheckBox53.Checked = True _
                   Or CheckBox54.Checked = True Or CheckBox55.Checked = True _
                   Or CheckBox56.Checked = True Or CheckBox57.Checked = True Then
                    fcorta = Format(MyDate, "dd MMMMMMMM yyyy")
                    largo = Len(fcorta)
                    Lfechaf = Mid(fcorta, 1, 2) & " de" & Mid(fcorta, 3)
                    'Lfechaf = fcorta
                    objHojaExcel.Range("X" & Lj.ToString).Value = "'" & Lfechaf
                    objHojaExcel.Range("X" & Lj.ToString).Font.Size = 8
                Else
                    fcorta = Format(MyDate, "MMMM yyyy")
                    largo = Len(fcorta)
                    Lfechaf = fcorta
                    objHojaExcel.Range("X" & Lj.ToString).Value = "'" & fcorta
                    objHojaExcel.Range("X" & Lj.ToString).Font.Size = 8
                End If
            End If
        Catch ex As Exception
        End Try
        Lpag = 1
        If Carta_Lista = "S" Or cotiza_listado = "S" Then
            Lj = Lj + 1
            objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
            objHojaExcel.Range("AE" & Lj.ToString).Value = "Cot/" & TextBox1.Text
            objHojaExcel.Range("AE" & Lj.ToString).Font.Size = 8
            objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        End If
        Lj = Lj + 1
        'objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
        'objHojaExcel.Range("AE" & Lj.ToString).Value = "pág: " & Lpag
        'objHojaExcel.Range("AE" & Lj.ToString).Font.Size = 7
        'objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Lj = Lj + 1
        If CheckBox5.Checked = True Or CheckBox6.Checked = True _
        Or CheckBox11.Checked = True Or CheckBox12.Checked = True _
        Or CheckBox17.Checked = True Or CheckBox18.Checked = True _
        Or CheckBox23.Checked = True Or CheckBox24.Checked = True _
        Or CheckBox29.Checked = True Or CheckBox30.Checked = True _
        Or CheckBox35.Checked = True Or CheckBox36.Checked = True _
        Or CheckBox41.Checked = True Or CheckBox42.Checked = True _
        Or CheckBox47.Checked = True Or CheckBox48.Checked = True _
        Or CheckBox50.Checked = True Or CheckBox51.Checked = True _
        Or CheckBox52.Checked = True Or CheckBox53.Checked = True _
        Or CheckBox54.Checked = True Or CheckBox55.Checked = True _
        Or CheckBox56.Checked = True Or CheckBox57.Checked = True Then

            If CheckBox50.Checked = True Or CheckBox51.Checked = True _
                Or CheckBox52.Checked = True Or CheckBox53.Checked = True _
                Or CheckBox54.Checked = True Or CheckBox55.Checked = True _
                Or CheckBox56.Checked = True Or CheckBox57.Checked = True Then

                objHojaExcel.Range("K" & Lj.ToString).Value = "LISTADO DE ANALISIS (Interno)"
                objHojaExcel.Range("K" & Lj.ToString).Font.Size = 14
                objHojaExcel.Range("K" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                Lj = Lj + 2
                objHojaExcel.Range("A" & Lj.ToString & ":B" & Lj.ToString).Merge()
                objHojaExcel.Range("A" & Lj.ToString).Value = "Cód."
                objHojaExcel.Range("A" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("A" & Lj.ToString & ":B" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                objHojaExcel.Range("A" & Lj.ToString).RowHeight = 12.75
                'objHojaExcel.Range("C" & Lj.ToString & ":AD" & Lj.ToString).Merge()
                objHojaExcel.Range("C" & Lj.ToString).Value = "Análisis"
                objHojaExcel.Range("C" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("C" & Lj.ToString & ":AD" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                objHojaExcel.Range("Z" & Lj.ToString & ":AB" & Lj.ToString).Merge()
                objHojaExcel.Range("Z" & Lj.ToString).Value = "Valor Neto"
                objHojaExcel.Range("Z" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("Z" & Lj.ToString & ":AB" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AC" & Lj.ToString).Value = "Re"
                objHojaExcel.Range("AC" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AC" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AD" & Lj.ToString).Value = "C1"
                objHojaExcel.Range("AD" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AD" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AE" & Lj.ToString).Value = "C2"
                objHojaExcel.Range("AE" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AE" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AF" & Lj.ToString).Value = "C3"
                objHojaExcel.Range("AF" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AF" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AG" & Lj.ToString).Value = "Tpo"
                objHojaExcel.Range("AG" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AG" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                objHojaExcel.Range("AH" & Lj.ToString).Value = "Niv"
                objHojaExcel.Range("AH" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AH" & Lj.ToString & ":AC" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                Call BORDES_INTERNOS(objHojaExcel, Lj, Lj)
            Else
                objHojaExcel.Range("K" & Lj.ToString).Value = "LISTADO DE ANALISIS"
                objHojaExcel.Range("K" & Lj.ToString).Font.Size = 14
                objHojaExcel.Range("K" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                Lj = Lj + 2
                objHojaExcel.Range("A" & Lj.ToString & ":B" & Lj.ToString).Merge()
                objHojaExcel.Range("A" & Lj.ToString).Value = "Cód."
                objHojaExcel.Range("A" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("A" & Lj.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lj.ToString & ":B" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                objHojaExcel.Range("C" & Lj.ToString & ":AD" & Lj.ToString).Merge()
                objHojaExcel.Range("C" & Lj.ToString).Value = "Análisis"
                objHojaExcel.Range("C" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("C" & Lj.ToString).Font.Size = 10
                objHojaExcel.Range("C" & Lj.ToString & ":AD" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
                objHojaExcel.Range("AE" & Lj.ToString).Value = "Valor Neto"
                objHojaExcel.Range("AE" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("AE" & Lj.ToString).Font.Size = 8
                objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        Else
            If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True _
            Or CheckBox7.Checked = True Or CheckBox8.Checked = True Or CheckBox9.Checked = True Or CheckBox10.Checked = True _
            Or CheckBox13.Checked = True Or CheckBox14.Checked = True Or CheckBox15.Checked = True Or CheckBox16.Checked = True _
            Or CheckBox19.Checked = True Or CheckBox20.Checked = True Or CheckBox21.Checked = True Or CheckBox22.Checked = True _
            Or CheckBox25.Checked = True Or CheckBox26.Checked = True Or CheckBox27.Checked = True Or CheckBox28.Checked = True _
            Or CheckBox31.Checked = True Or CheckBox32.Checked = True Or CheckBox33.Checked = True Or CheckBox34.Checked = True _
            Or CheckBox37.Checked = True Or CheckBox38.Checked = True Or CheckBox39.Checked = True Or CheckBox40.Checked = True _
            Or CheckBox43.Checked = True Or CheckBox44.Checked = True Or CheckBox45.Checked = True Or CheckBox46.Checked = True Then

                If CheckBox1.Checked = True Or CheckBox7.Checked = True _
                Or CheckBox13.Checked = True Or CheckBox19.Checked = True _
                Or CheckBox25.Checked = True Or CheckBox31.Checked = True _
                Or CheckBox37.Checked = True Or CheckBox43.Checked = True Then
                    objHojaExcel.Range("K" & Lj.ToString).Value = "LISTADO RESUMEN DE ANALISIS"
                Else
                    objHojaExcel.Range("K" & Lj.ToString).Value = "LISTADO PRECIOS DE ANALISIS"
                End If

                objHojaExcel.Range("K" & Lj.ToString).Font.Size = 14
                objHojaExcel.Range("K" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("K" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("K" & Lj.ToString).RowHeight = 12.75
                Lj = Lj + 2
                objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
                objHojaExcel.Range("AE" & Lj.ToString).Value = "$ Valor Neto"
                objHojaExcel.Range("AE" & Lj.ToString).Font.Bold = True
                objHojaExcel.Range("AE" & Lj.ToString).Font.Size = 9
                objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                objHojaExcel.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        End If

        If CheckBox5.Checked = True Or CheckBox6.Checked = True Or CheckBox50.Checked = True Then
            If CheckBox5.Checked = True Then ConFrec = 1
            If CheckBox50.Checked = True Then
                Call listado_codigo_Interno(1000, 2000, objHojaExcel)
            Else
                Call listado_codigo(1000, 2000, objHojaExcel)
            End If

        Else
            If CheckBox1.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox2.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox3.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox4.Checked = True Then
                Call listado_cliente(1000, 2000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox11.Checked = True Or CheckBox12.Checked = True Or CheckBox51.Checked = True Then
            If CheckBox11.Checked = True Then ConFrec = 1
            If CheckBox51.Checked = True Then
                Call listado_codigo_Interno(2000, 3000, objHojaExcel)
            Else
                Call listado_codigo(2000, 3000, objHojaExcel)
            End If

        Else
            If CheckBox7.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox8.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox9.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox10.Checked = True Then
                Call listado_cliente(2000, 3000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox17.Checked = True Or CheckBox18.Checked = True Or CheckBox52.Checked = True Then
            If CheckBox17.Checked = True Then ConFrec = 1
            If CheckBox52.Checked = True Then
                Call listado_codigo_Interno(3000, 4000, objHojaExcel)
            Else
                Call listado_codigo(3000, 4000, objHojaExcel)
            End If
        Else
            If CheckBox13.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox14.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox15.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox16.Checked = True Then
                Call listado_cliente(3000, 4000, objHojaExcel, "CLIENTET")
            End If
        End If

        If CheckBox23.Checked = True Or CheckBox24.Checked = True Or CheckBox53.Checked = True Then
            If CheckBox23.Checked = True Then ConFrec = 1
            If CheckBox53.Checked = True Then
                Call listado_codigo_Interno(4000, 5000, objHojaExcel)
            Else
                Call listado_codigo(4000, 5000, objHojaExcel)
            End If

        Else
            If CheckBox19.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox20.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox21.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox22.Checked = True Then
                Call listado_cliente(4000, 5000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox29.Checked = True Or CheckBox30.Checked = True Or CheckBox54.Checked = True Then
            If CheckBox29.Checked = True Then ConFrec = 1
            If CheckBox54.Checked = True Then
                Call listado_codigo_Interno(5000, 6000, objHojaExcel)
            Else
                Call listado_codigo(5000, 6000, objHojaExcel)
            End If

        Else
            If CheckBox25.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox26.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox27.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox28.Checked = True Then
                Call listado_cliente(5000, 6000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox35.Checked = True Or CheckBox36.Checked = True Or CheckBox55.Checked = True Then
            If CheckBox35.Checked = True Then ConFrec = 1
            If CheckBox55.Checked = True Then
                Call listado_codigo_Interno(6000, 7000, objHojaExcel)
            Else
                Call listado_codigo(6000, 7000, objHojaExcel)
            End If

        Else
            If CheckBox31.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox32.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox33.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox34.Checked = True Then
                Call listado_cliente(6000, 7000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox41.Checked = True Or CheckBox42.Checked = True Or CheckBox56.Checked = True Then
            If CheckBox41.Checked = True Then ConFrec = 1
            If CheckBox56.Checked = True Then
                Call listado_codigo_Interno(7000, 8000, objHojaExcel)
            Else
                Call listado_codigo(7000, 8000, objHojaExcel)
            End If

        Else
            If CheckBox37.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox38.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox39.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox40.Checked = True Then
                Call listado_cliente(7000, 8000, objHojaExcel, "CLIENTET")
            End If

        End If

        If CheckBox47.Checked = True Or CheckBox48.Checked = True Or CheckBox57.Checked = True Then
            If CheckBox47.Checked = True Then ConFrec = 1
            If CheckBox57.Checked = True Then
                Call listado_codigo_Interno(8000, 9000, objHojaExcel)
            Else
                Call listado_codigo(8000, 9000, objHojaExcel)
            End If

        Else
            If CheckBox43.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE1")
            End If

            If CheckBox44.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE2")
            End If

            If CheckBox45.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTE3")
            End If
            If CheckBox46.Checked = True Then
                Call listado_cliente(8000, 9000, objHojaExcel, "CLIENTET")
            End If

        End If
noimprime:

        If CheckBox1.Checked = True Or CheckBox2.Checked = True Or CheckBox3.Checked = True Or CheckBox4.Checked = True _
            Or CheckBox7.Checked = True Or CheckBox8.Checked = True Or CheckBox9.Checked = True Or CheckBox10.Checked = True _
            Or CheckBox13.Checked = True Or CheckBox14.Checked = True Or CheckBox15.Checked = True Or CheckBox16.Checked = True _
            Or CheckBox19.Checked = True Or CheckBox20.Checked = True Or CheckBox21.Checked = True Or CheckBox22.Checked = True _
            Or CheckBox25.Checked = True Or CheckBox26.Checked = True Or CheckBox27.Checked = True Or CheckBox28.Checked = True _
            Or CheckBox31.Checked = True Or CheckBox32.Checked = True Or CheckBox33.Checked = True Or CheckBox34.Checked = True _
            Or CheckBox37.Checked = True Or CheckBox38.Checked = True Or CheckBox39.Checked = True Or CheckBox40.Checked = True _
            Or CheckBox43.Checked = True Or CheckBox44.Checked = True Or CheckBox45.Checked = True Or CheckBox46.Checked = True Then
            Fila_Consulte = 60 : Fila_Pie = 62
            If Lj >= 62 And Lj <= 124 Then Fila_Consulte = 120 : Fila_Pie = 124
            If Lj >= 125 And Lj <= 186 Then Fila_Consulte = 182 : Fila_Pie = 186
            If Lj >= 187 And Lj <= 248 Then Fila_Consulte = 1245 : Fila_Pie = 248
            objHojaExcel.Range("E" & Fila_Consulte & ":AC" & Fila_Consulte).Merge()
            objHojaExcel.Range("E" & Fila_Consulte).Value = "Consulte por otros análisis que ofrece Agrolab"
            objHojaExcel.Range("E" & Fila_Consulte).Font.Bold = True
            objHojaExcel.Range("E" & Fila_Consulte).Font.Size = 10
            objHojaExcel.Range("E" & Fila_Consulte & ":AC" & Fila_Consulte).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            'pie
            objHojaExcel.Range("A" & Fila_Pie.ToString & ":AH" & Fila_Pie.ToString).Merge()
            objHojaExcel.Range("A" & Fila_Pie.ToString).Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
            objHojaExcel.Range("A" & Fila_Pie.ToString).Font.Size = 8
            objHojaExcel.Range("A" & Fila_Pie.ToString & ":AH" & Fila_Pie.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

        End If
        If Lpag > 1 Then Call IMPRIME_NUMERO_PAGINAS(objHojaExcel)
        If Lj >= 63 And Lj <= 123 Then objHojaExcel.PageSetup.PrintArea = "$A$1:$AH$124"
        If Lj >= 124 And Lj <= 185 Then objHojaExcel.PageSetup.PrintArea = "$A$1:$AH$186"
        If Lj >= 186 And Lj <= 247 Then objHojaExcel.PageSetup.PrintArea = "$A$1:$AH$248"
        objHojaExcel.Range("A11").Select()
        'Me.Close()
    End Sub

    Private Sub CAMBIA_HOJA(ByVal HOJA_EXCEL As Excel.Worksheet)
        'HOJA_EXCEL.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
        'HOJA_EXCEL.Range("AE" & Lj.ToString).Value = "pág: " & Lpag
        'HOJA_EXCEL.Range("AE" & Lj.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Lj = Lj + 1
        HOJA_EXCEL.Range("K" & Lj.ToString).Value = "LISTADO DE ANALISIS"
        HOJA_EXCEL.Range("K" & Lj.ToString).Font.Size = 14
        HOJA_EXCEL.Range("K" & Lj.ToString).Font.Bold = True
        HOJA_EXCEL.Range("K" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        HOJA_EXCEL.Range("K" & Lj.ToString).RowHeight = 12.75
        Lj = Lj + 2
    End Sub

    Private Sub CAMBIA_HOJA_CLIENTE(ByVal HOJA_EXCEL As Excel.Worksheet)
        'HOJA_EXCEL.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).Merge()
        'HOJA_EXCEL.Range("AE" & Lj.ToString).Value = "pág: " & Lpag
        'HOJA_EXCEL.Range("AE" & Lj.ToString).Font.Size = 7
        'HOJA_EXCEL.Range("AE" & Lj.ToString & ":AH" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
        HOJA_EXCEL.Range("K" & Lj.ToString).Value = "LISTADO PRECIOS DE ANALISIS"
        HOJA_EXCEL.Range("K" & Lj.ToString).Font.Size = 14
        HOJA_EXCEL.Range("K" & Lj.ToString).Font.Bold = True
        HOJA_EXCEL.Range("K" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
        HOJA_EXCEL.Range("K" & Lj.ToString).RowHeight = 12.75
        Lj = Lj + 2 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 2)
    End Sub

    Public Sub BORDES(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal IB As Integer)
        Dim LIN As Integer
        'HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).BorderAround()
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        With HOJA_EXCEL.Range("AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Public Sub listado_cliente(ByVal DESDE As Double, ByVal HASTA As Double, _
        ByVal HOJA_EXCEL As Excel.Worksheet, ByVal CLIENTE As String)
        Dim A, fila_llave, FILA_PARA_PRECIO, linea, i, ant, j, dif, factor As Integer
        Dim FILA_IMPRIME, FILA_RANGO, fila_combo As DataRow
        Dim BOLA As Object
        Dim Acumula, Caracter, cambio_de_Hoja, puntosx, query, Es_Muestra, Es_ComAnt, primera_linea_combo As String
        Dim suma_pix, suma_pix2, RestaExt As Double
        Dim prim, Cuenta_Fila_Combo, CuentaBlancos, SinPuntos As Integer
        ES_SIMPLE = 0
        puntosx = "................................................................" & _
        "........................................................................" & _
        "........................................................................"
        Listado_codigos = "N"
        Es_Muestra = "N" : Es_ComAnt = "N"
        For Each FILA_IMPRIME In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            If IsDBNull(FILA_IMPRIME("CLIENTE1")) = True Then FILA_IMPRIME("CLIENTE1") = ""
            If IsDBNull(FILA_IMPRIME("CLIENTE2")) = True Then FILA_IMPRIME("CLIENTE2") = ""
            If IsDBNull(FILA_IMPRIME("CLIENTE3")) = True Then FILA_IMPRIME("CLIENTE3") = ""
            If IsDBNull(FILA_IMPRIME("CLIENTET")) = True Then FILA_IMPRIME("CLIENTET") = ""
            fila_llave = 0
            If FILA_IMPRIME("ANA_CODIGO") >= DESDE And FILA_IMPRIME("ANA_CODIGO") < HASTA And _
                   FILA_IMPRIME(CLIENTE) = "x" Then
                Call SaltoxLinea(cambio_de_Hoja, HOJA_EXCEL)
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("MUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    If ElPrimero = "S" Then
                        Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 1) : ElPrimero = "N"
                    Else
                        Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
                        Call SaltoxLinea(cambio_de_Hoja, HOJA_EXCEL)
                        If cambio_de_Hoja = "N" Then Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix : Call SaltoxLinea(cambio_de_Hoja, HOJA_EXCEL)
                    End If
                    Control_MuestraySub("S", HOJA_EXCEL, CLIENTE, DESDE, HASTA, 0, FILA_IMPRIME("ANA_CODIGO"))
                    Es_Muestra = "S"
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AD" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Underline = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AD" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    'Call BORDES(HOJA_EXCEL, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
                    Control_MuestraySub("N", HOJA_EXCEL, CLIENTE, DESDE, HASTA, 0, FILA_IMPRIME("ANA_CODIGO"))
                    Es_Muestra = "S"
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AD" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AD" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    'Call BORDES(HOJA_EXCEL, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                '
                'imprime linea
                '
                cambio_de_Hoja = "N"
                query = FILA_IMPRIME("ANA_ANALISIS")
                Cuenta_Fila_Combo = Lj
                fila_llave = 1
                SinPuntos = 0 : CuentaBlancos = 0
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Caracter = " " Then CuentaBlancos = CuentaBlancos + 1
                    If Asc(Caracter) <> 10 And Caracter <> " " Then CuentaBlancos = 0
                    If Asc(Caracter) = 10 Then
                        If CuentaBlancos > 4 Then SinPuntos = 1
                        Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1
                        If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                        If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                        If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                        fila_llave = fila_llave + 1
                    End If
                Next
                If fila_llave > 1 Then Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1

                If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                If fila_llave > 1 Then Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1

                If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"

                If cambio_de_Hoja = "S" Then
                    dif = Lcont - Lj
                    Lcont = 62 + (Lj + dif)
                    Lpag = Lpag + 1
                    Lj = Lj + (3 + dif) : Lsuma_pixeles = Lsuma_pixeles + (Lpix * (3 + dif))
                    Call CAMBIA_HOJA_CLIENTE(HOJA_EXCEL)
                    GoTo saltoporcam
                End If
                If fila_llave = 1 Or Es_Muestra = "S" Or Es_ComAnt = "S" Then Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix Else Lj = Lj + 2 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 2)
saltoporcam:
                Es_ComAnt = "N"
                suma_pix = Lsuma_pixeles
                FILA_PARA_PRECIO = Lj
                Acumula = ""
                primera_linea_combo = "S"
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Asc(Caracter) = 10 Then
                        HOJA_EXCEL.Range("A" & Lj.ToString).Value = Acumula & "   " & puntosx
                        HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("A" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        If primera_linea_combo = "S" Then HOJA_EXCEL.Range("AE" & Lj.ToString).Value = " " : primera_linea_combo = "N"
                        Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
                        Acumula = ""
                    Else
                        Acumula = Acumula + Caracter
                    End If
                Next
                HOJA_EXCEL.Range("A" & Lj.ToString).Value = Acumula & "   " & puntosx
                HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                HOJA_EXCEL.Range("A" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                If fila_llave > 1 Then FILA_PARA_PRECIO = FILA_PARA_PRECIO + 1
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString & ":AE" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).Value = "$"
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString & ":AE" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString & ":AE" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).Font.Size = 9
                If IsDBNull(FILA_IMPRIME("ANA_NETO")) = True Then FILA_IMPRIME("ANA_NETO") = "0"
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString & ":AH" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Value = Format(FILA_IMPRIME("ANA_NETO"), "####,###")
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Font.Size = 9
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
                '
                'BORDES2(HOJA_EXCEL, FILA_PARA_PRECIO, Lj)
                Es_Muestra = "N"
sub13:
            End If
            cambio_de_Hoja = "N"
            If fila_llave > 1 Then
                suma_pix2 = suma_pix - 5
                If SinPuntos = 1 Then
                    suma_pix2 = suma_pix2 + 12
                    RestaExt = 5
                Else
                    RestaExt = -5
                End If
                If fila_llave = 2 And RestaExt <> -5 Then
                    RestaExt = -5
                Else
                    HOJA_EXCEL.Shapes.AddShape(32, 428.25, suma_pix2, 5, ((fila_llave - 1) * 12) - RestaExt)
                End If
                Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
                Es_ComAnt = "S"
            End If
        Next

    End Sub

    Private Sub SaltoxLinea(ByRef cambio_de_Hoja As String, ByVal HOJA_EXCEL As Excel.Worksheet)
        If Lpag = 1 And Lj = 60 Then
            Lcont = Lj + 62
            Lpag = Lpag + 1
            Lj = Lj + 3 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 3)
            Call CAMBIA_HOJA_CLIENTE(HOJA_EXCEL)
            cambio_de_Hoja = "S"
        End If
        If Lpag = 1 And (Lj Mod Lcont = 0) Then
            Lcont = Lj + 62
            Lpag = Lpag + 1
            Lj = Lj + 3 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 3)
            Call CAMBIA_HOJA_CLIENTE(HOJA_EXCEL)
            cambio_de_Hoja = "S"
        End If
        If Lpag <> 1 And (Lj Mod Lcont = 0) Then
            Lcont = Lj + 62
            Lpag = Lpag + 1
            Lj = Lj + 3 : Lsuma_pixeles = Lsuma_pixeles + (Lpix * 3)
            Call CAMBIA_HOJA_CLIENTE(HOJA_EXCEL)
            cambio_de_Hoja = "S"
        End If
    End Sub

    Public Sub listado_codigo(ByVal desde As Integer, ByVal hasta As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim FILA_IMPRIME, FILA_RANGO As DataRow
        Dim A, fila_llave, FILA_PARA_PRECIO, linea, i, ant, j, Cuenta_Fila_Combo, dif As Integer
        Dim Acumula, puntosx, query, cambio_de_Hoja, Caracter As String
        Dim suma_pix, filas As Double
        Dim prim As Integer
        Dim BOLA As Object
        Listado_codigos = "S"
        cambio_de_Hoja = "N"
        For Each FILA_IMPRIME In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            If FILA_IMPRIME("ANA_CODIGO") >= desde And FILA_IMPRIME("ANA_CODIGO") < hasta Then
                If ConFrec = 1 And Mid(FILA_IMPRIME("ANA_NIVEL_PRECIO"), 2, 2) <> "FR" Then GoTo sub13
                If Lpag = 1 And Lj = 60 Then
                    Lcont = Lj + 62
                    Lpag = Lpag + 1
                    Lj = Lj + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                    cambio_de_Hoja = "S"
                End If
                If Lpag <> 1 And (Lj Mod Lcont = 0) Then
                    Lcont = Lj + 62
                    Lpag = Lpag + 1
                    Lj = Lj + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                    cambio_de_Hoja = "S"
                End If
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("MUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    Lj = Lj + 1
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AE" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AE" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Call BORDES(HOJA_EXCEL, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    Lj = Lj + 1
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AE" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 9
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":AE" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Call BORDES(HOJA_EXCEL, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                '
                'imprime linea
                '
                cambio_de_Hoja = "N"
                query = FILA_IMPRIME("ANA_ANALISIS")
                Cuenta_Fila_Combo = Lj
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Asc(Caracter) = 10 Then
                        Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1
                        If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                        If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                    End If
                Next
                If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                If Lpag <> 1 And (Cuenta_Fila_Combo Mod 62) = 0 Then cambio_de_Hoja = "S"
                If cambio_de_Hoja = "S" Then
                    dif = Lcont - Lj
                    Lcont = 62 + (Lj + dif)
                    Lpag = Lpag + 1
                    Lj = Lj + (3 + dif)
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                End If
                Lj = Lj + 1
                FILA_PARA_PRECIO = Lj
                Acumula = ""
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Asc(Caracter) = 13 Then Caracter = " "
                    If Asc(Caracter) = 10 Then
                        HOJA_EXCEL.Range("C" & Lj.ToString).Value = Acumula & "   " & puntosx
                        HOJA_EXCEL.Range("C" & Lj.ToString).Font.Size = 9
                        HOJA_EXCEL.Range("C" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        Lj = Lj + 1
                        Acumula = ""
                    Else
                        Acumula = Acumula + Caracter
                    End If
                Next
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("ANA_CODIGO")
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString).Font.Size = 9
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                HOJA_EXCEL.Range("C" & Lj.ToString).Value = Acumula & "   " & puntosx
                HOJA_EXCEL.Range("C" & Lj.ToString).Font.Size = 9
                HOJA_EXCEL.Range("C" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                If IsDBNull(FILA_IMPRIME("ANA_NETO")) = True Then FILA_IMPRIME("ANA_NETO") = "0"
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString & ":AH" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Value = Format(FILA_IMPRIME("ANA_NETO"), "####,###")
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Font.Size = 9
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                '
                BORDES2(HOJA_EXCEL, FILA_PARA_PRECIO, Lj)
sub13:
            End If
            cambio_de_Hoja = "N"
        Next
    End Sub

    Public Sub listado_codigo_Interno(ByVal desde As Integer, ByVal hasta As Integer, ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim FILA_IMPRIME, FILA_RANGO As DataRow
        Dim A, fila_llave, FILA_PARA_PRECIO, linea, i, ant, j, Cuenta_Fila_Combo, dif As Integer
        Dim Acumula, puntosx, query, cambio_de_Hoja, Caracter As String
        Dim suma_pix, filas As Double
        Dim prim As Integer
        Dim BOLA As Object
        Listado_codigos = "S"
        cambio_de_Hoja = "N"
        For Each FILA_IMPRIME In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            If FILA_IMPRIME("ANA_CODIGO") >= desde And FILA_IMPRIME("ANA_CODIGO") < hasta Then
                If ConFrec = 1 And Mid(FILA_IMPRIME("ANA_NIVEL_PRECIO"), 2, 2) <> "FR" Then GoTo sub13
                If Lpag = 1 And Lj = 60 Then
                    Lcont = Lj + 62
                    Lpag = Lpag + 1
                    Lj = Lj + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                    cambio_de_Hoja = "S"
                End If
                If Lpag <> 1 And (Lj Mod Lcont = 0) Then
                    Lcont = Lj + 62
                    Lpag = Lpag + 1
                    Lj = Lj + 3
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                    cambio_de_Hoja = "S"
                End If
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("MUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    Lj = Lj + 1
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":Y" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":Y" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Call BORDES_INTERNOS(HOJA_EXCEL, Lj, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                BOLA = FILA_IMPRIME("ANA_CODIGO")
                FILA_RANGO = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(BOLA)
                If Not (FILA_RANGO Is Nothing) Then
                    Lj = Lj + 1
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":Y" & Lj.ToString).Merge()
                    HOJA_EXCEL.Range("A" & Lj.ToString).Value = FILA_IMPRIME("ANA_ANALISIS")
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Size = 8
                    HOJA_EXCEL.Range("A" & Lj.ToString).Font.Bold = True
                    HOJA_EXCEL.Range("A" & Lj.ToString & ":Y" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                    Call BORDES_INTERNOS(HOJA_EXCEL, Lj, Lj)
                    cambio_de_Hoja = "N"
                    GoTo sub13
                End If
                '
                'imprime linea
                '
                cambio_de_Hoja = "N"
                query = FILA_IMPRIME("ANA_ANALISIS")
                Cuenta_Fila_Combo = Lj
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Asc(Caracter) = 10 Then
                        Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1
                        If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                        If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                    End If
                Next
                If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                If Lpag <> 1 And (Cuenta_Fila_Combo Mod 62) = 0 Then cambio_de_Hoja = "S"
                If cambio_de_Hoja = "S" Then
                    dif = Lcont - Lj
                    Lcont = 62 + (Lj + dif)
                    Lpag = Lpag + 1
                    Lj = Lj + (3 + dif)
                    Call CAMBIA_HOJA(HOJA_EXCEL)
                End If
                Lj = Lj + 1
                FILA_PARA_PRECIO = Lj
                Acumula = ""
                For i = 1 To query.Length
                    Caracter = Mid(query, i, 1)
                    If Asc(Caracter) = 13 Then Caracter = " "
                    If Asc(Caracter) = 10 Then
                        HOJA_EXCEL.Range("C" & Lj.ToString).Value = Acumula & "   " & puntosx
                        HOJA_EXCEL.Range("C" & Lj.ToString).Font.Size = 8
                        HOJA_EXCEL.Range("C" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                        Lj = Lj + 1
                        Acumula = ""
                    Else
                        Acumula = Acumula + Caracter
                    End If
                Next
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("ANA_CODIGO")
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                HOJA_EXCEL.Range("A" & FILA_PARA_PRECIO.ToString & ":B" & Lj.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                HOJA_EXCEL.Range("C" & Lj.ToString).Value = Acumula & "   " & puntosx
                HOJA_EXCEL.Range("C" & Lj.ToString).Font.Size = 8
                HOJA_EXCEL.Range("C" & Lj.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft

                If IsDBNull(FILA_IMPRIME("ANA_NETO")) = True Then FILA_IMPRIME("ANA_NETO") = "0"
                HOJA_EXCEL.Range("Z" & FILA_PARA_PRECIO.ToString & ":AB" & Lj.ToString).Merge()
                HOJA_EXCEL.Range("Z" & FILA_PARA_PRECIO.ToString).Value = Format(FILA_IMPRIME("ANA_NETO"), "####,###")
                HOJA_EXCEL.Range("Z" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("Z" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
                HOJA_EXCEL.Range("Z" & FILA_PARA_PRECIO.ToString).VerticalAlignment = Excel.XlVAlign.xlVAlignTop
                '
                HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("CLIENTE1")
                HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AC" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("AD" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("CLIENTE2")
                HOJA_EXCEL.Range("AD" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AD" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("CLIENTE3")
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AE" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("CLIENTET")
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AF" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("AG" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("TIPO_COD")
                HOJA_EXCEL.Range("AG" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AG" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                HOJA_EXCEL.Range("AH" & FILA_PARA_PRECIO.ToString).Value = FILA_IMPRIME("ANA_NIVEL_PRECIO")
                HOJA_EXCEL.Range("AH" & FILA_PARA_PRECIO.ToString).Font.Size = 8
                HOJA_EXCEL.Range("AH" & FILA_PARA_PRECIO.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

                BORDES_INTERNOS(HOJA_EXCEL, FILA_PARA_PRECIO, Lj)
sub13:
            End If
            cambio_de_Hoja = "N"
        Next
    End Sub

    Public Sub BORDES2(ByVal HOJA_EXCEL As Excel.Worksheet, ByVal IB As Integer, ByVal IBB As Integer)
        Dim LIN, i As Integer
        With HOJA_EXCEL.Range("A" & IB.ToString & ":AH" & IB.ToString).Borders(Excel.XlBordersIndex.xlEdgeTop)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
        For i = IB To IBB
            With HOJA_EXCEL.Range("A" & i.ToString).Borders(Excel.XlBordersIndex.xlEdgeLeft)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
            With HOJA_EXCEL.Range("AH" & i.ToString).Borders(Excel.XlBordersIndex.xlEdgeRight)
                .LineStyle = Excel.XlLineStyle.xlContinuous
                .Weight = Excel.XlBorderWeight.xlHairline
                .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
            End With
        Next
        With HOJA_EXCEL.Range("A" & IBB.ToString & ":AH" & IBB.ToString).Borders(Excel.XlBordersIndex.xlEdgeBottom)
            .LineStyle = Excel.XlLineStyle.xlContinuous
            .Weight = Excel.XlBorderWeight.xlHairline
            .ColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
        End With
    End Sub

    Private Sub CBNotasPla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBNotasPla.Click
        Dim Form_Notas_Listado As New Notas_Listado
        Form_Notas_Listado.Show()
    End Sub

    Private Sub pagina_notas(ByVal objHojaExcel As Excel.Worksheet)
        Dim fcorta, MAIL2, CEL, RCOMUNA, RCIUDAD, nomb, Cargo As String
        Dim largo, k, largoco, Lfila, varmer As Integer
        Dim cnvn As New Coversion1
        'objHojaExcel.Pictures.Insert("F:\Mis documentos\Mis Imagenes\Logos,firmas,hojas\Logo  mediano Agro.jpg").Select()
        Try
            fcorta = Format(CDate(TextBox3.Text), "dd MMMMMMMMMM yyyy")
            largo = Len(fcorta)
            Lfechaf = Mid(fcorta, 1, 2) & " de " + Mid(fcorta, 4, (largo - 8)) & " de" & Mid(fcorta, (largo - 4))
            objHojaExcel.Range("X2").Value = Lfechaf
            objHojaExcel.Range("X2").Font.Size = 10
        Catch ex As Exception
        End Try
        objHojaExcel.Range("AE3:AH3").Merge()
        objHojaExcel.Range("AE3").Value = "Cot/" & TextBox1.Text
        objHojaExcel.Range("AE3:AH3").HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        objHojaExcel.Range("AE3").Font.Size = 8

        objHojaExcel.Range("A6").Value = "Señor(es):"

        Try
            If TextBox22.Text <> "" Then
                objHojaExcel.Range("A7").Value = TextBox22.Text
                objHojaExcel.Range("A7").Font.Bold = True
                objHojaExcel.Range("A7").Font.Size = 10
                GoTo nopodu
            End If
            objHojaExcel.Range("A7").Value = TextBox22.Text
            objHojaExcel.Range("A7").Font.Bold = True
            objHojaExcel.Range("A7").Font.Size = 10
        Catch ex As Exception
        End Try
nopodu:
        Lfila = 7
        MAIL2 = ""
        Try
            If TextBox14.Text <> "" And IsDBNull(TextBox14.Text) = False Then
                MAIL2 = TextBox14.Text
                MAIL2 = " ; " & MAIL2
            End If
        Catch ex As Exception
        End Try


        Try
            If IsDBNull(TextBox9.Text) = False And TextBox9.Text <> "" Then
                Lfila = Lfila + 1
                objHojaExcel.Range("D" & Lfila.ToString).Value = ": " & TextBox9.Text & MAIL2
                objHojaExcel.Range("D" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lfila.ToString).Value = "e-mail"
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
            End If

        Catch ex As Exception

        End Try

        Try
            CEL = TextBox16.Text
            CEL = " /" & CEL
        Catch ex As Exception
        End Try
        If CEL = " /" Then CEL = ""


        Try
            If IsDBNull(TextBox10.Text) = False And TextBox10.Text <> "" Then
                Lfila = Lfila + 1
                objHojaExcel.Range("D" & Lfila.ToString).Value = ": " & TextBox10.Text & CEL
                objHojaExcel.Range("D" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lfila.ToString).Value = "Fono"
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
            End If
        Catch ex As Exception
        End Try


        Try
            If IsDBNull(TextBox11.Text) = False And TextBox11.Text <> "" Then
                Lfila = Lfila + 1
                objHojaExcel.Range("D" & Lfila.ToString).Value = ": " & TextBox11.Text
                objHojaExcel.Range("D" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lfila.ToString).Value = "Fax"
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
            End If

        Catch ex As Exception
        End Try


        Try
            RCIUDAD = CBCiudad.Text
        Catch ex As Exception
        End Try

        Try
            RCOMUNA = CBComuna.Text
        Catch ex As Exception
        End Try

        Try
            If IsDBNull(TextBox7.Text) = False And TextBox7.Text <> "" Then
                Lfila = Lfila + 1
                If RCOMUNA <> "" And RCOMUNA <> RCIUDAD And RCIUDAD <> "" Then
                    nomb = CBComuna.Text : cnvn.Minuscula(nomb)
                    objHojaExcel.Range("A" & Lfila.ToString).Value = TextBox7.Text & ", " & nomb
                Else
                    objHojaExcel.Range("A" & Lfila.ToString).Value = TextBox7.Text
                End If
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
            End If
        Catch ex As Exception

        End Try

        Try
            If RCIUDAD = RCOMUNA Or RCIUDAD = "" Then
                RCOMUNA = CBComuna.Text
                Lfila = Lfila + 1
                nomb = CBComuna.Text
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & Lfila.ToString).Value = nomb
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lfila.ToString).Font.Underline = True
            Else
                RCIUDAD = CBCiudad.Text
                Lfila = Lfila + 1
                nomb = CBCiudad.Text
                cnvn.Minuscula(nomb)
                objHojaExcel.Range("A" & Lfila.ToString).Value = nomb
                objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("A" & Lfila.ToString).Font.Underline = True
            End If
        Catch ex As Exception
        End Try

        Try

            nomb = TextBox8.Text
            If nomb <> "" Then
                Call control_nombre(nomb)
                objHojaExcel.Range("W" & Lfila.ToString & ":AH" & Lfila.ToString).Merge()
                objHojaExcel.Range("W" & Lfila.ToString).Value = "At. : " & nomb
                objHojaExcel.Range("W" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("W" & Lfila.ToString & ":AH" & Lfila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        Catch ex As Exception

        End Try
        Try

            Cargo = TextBox12.Text
            If Cargo <> "" Then
                Call control_nombre(nomb)
                Lfila = Lfila + 1
                objHojaExcel.Range("W" & Lfila.ToString & ":AH" & Lfila.ToString).Merge()
                objHojaExcel.Range("W" & Lfila.ToString).Value = Cargo
                objHojaExcel.Range("W" & Lfila.ToString).Font.Size = 10
                objHojaExcel.Range("W" & Lfila.ToString & ":AH" & Lfila.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
            End If
        Catch ex As Exception

        End Try

        If Cargo = "" Then Lfila = Lfila + 2 Else Lfila = Lfila + 1
        objHojaExcel.Range("A" & Lfila.ToString).Value = "De nuestra consideracion:"
        objHojaExcel.Range("A" & Lfila.ToString).Font.Size = 10
        Lfila = Lfila + 1
        If Npl1 <> "" Then
            Call impsep_notas_Planilla(objHojaExcel, Lfila, Npl1)
        End If

        objHojaExcel.Range("A55:P55").Merge()
        objHojaExcel.Range("A55").Value = ""
        objHojaExcel.Range("A55:P55").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A55").Font.Size = 10

        objHojaExcel.Range("A56:P56").Merge()
        objHojaExcel.Range("A56").Value = ""
        objHojaExcel.Range("A56:P56").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("A56").Font.Size = 9

        objHojaExcel.Range("Q55:AH55").Merge()
        objHojaExcel.Range("Q55").Value = "Rosa Espinoza Astudillo"
        objHojaExcel.Range("Q55:AH55").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("Q55").Font.Size = 10

        objHojaExcel.Range("Q56:AH56").Merge()
        objHojaExcel.Range("Q56").Value = "Jefe Laboratorio"
        objHojaExcel.Range("Q56:AH56").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
        objHojaExcel.Range("Q56").Font.Size = 9

        objHojaExcel.Range("A62:AH62").Merge()
        objHojaExcel.Range("A62").Value = "José Domingo Cañas # 2914   -   Santiago   -   Teléfono: (02) 225 80 87   -   e-mail: laboratorio@agrolab.cl"
        objHojaExcel.Range("A62").Font.Size = 8
        objHojaExcel.Range("A62:AH62").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
    End Sub

    Private Sub CBCartaL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCartaL.Click
        Try

      
            Dim objLibroExcel As Excel.Workbook
            Dim objHojaExcel As Excel.Worksheet
            Dim FILA_DATAROW, dr As DataRow
            Dim consulta_nota, consulta_nota2, ana_analisis, ana_original, ana_nivel_precio, cliente1, cliente2, cliente3, clientet, tipo_cod As String
            Dim ana_codigo, ana_neto As Double
            Dim fila, tmu_codigo, sub_codigo As Integer
            Dim cfec, clog As Boolean
            If concu = "S" Then MsgBox("Advertencia : El sistema se encuentra en uso por otro usuario") : GoTo CONCUR
            If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo CONCUR
            cfec = False
            clog = False
            Lj = 62
            Lll = 69
            Lsuma_pixeles = 790.5 + 63.75 + 12.75
            Lcont = 122
            Carta_Lista = "S"
            For Each FILA_DATAROW In Cjto_Cotizacion1.Tables("ANALISIS").Rows
                If FILA_DATAROW.RowState = DataRowState.Modified Then
                    ana_codigo = FILA_DATAROW("ANA_CODIGO")
                    ana_analisis = FILA_DATAROW("ANA_ANALISIS")
                    tmu_codigo = FILA_DATAROW("TMU_CODIGO")
                    sub_codigo = FILA_DATAROW("SUB_CODIGO")
                    ana_neto = Format(FILA_DATAROW("ANA_NETO"), "#####0")
                    ana_nivel_precio = FILA_DATAROW("ANA_NIVEL_PRECIO")
                    If Not (IsDBNull(FILA_DATAROW("CLIENTE1"))) Then
                        cliente1 = FILA_DATAROW("CLIENTE1")
                    End If
                    If Not (IsDBNull(FILA_DATAROW("CLIENTE2"))) Then
                        cliente2 = FILA_DATAROW("CLIENTE2")
                    End If
                    If Not (IsDBNull(FILA_DATAROW("CLIENTE3"))) Then
                        cliente3 = FILA_DATAROW("CLIENTE3")
                    End If
                    If Not (IsDBNull(FILA_DATAROW("CLIENTET"))) Then
                        clientet = FILA_DATAROW("CLIENTET")
                    End If
                    If Not (IsDBNull(FILA_DATAROW("TIPO_COD"))) Then
                        tipo_cod = FILA_DATAROW("TIPO_COD")
                    End If
                    'tipo_cod = FILA_DATAROW("TIPO_COD")
                    consulta_nota = "UPDATE ANALISIS SET ANA_ANALISIS=" & "'" & ana_analisis & "'" & ",TMU_CODIGO=" & tmu_codigo & ",SUB_CODIGO=" & sub_codigo & ",ANA_NETO=" & ana_neto & ",ANA_NIVEL_PRECIO=" & "'" & ana_nivel_precio & "'" & ",CLIENTE1=" & "'" & cliente1 & "'" & ",CLIENTE2=" & "'" & cliente2 & "'" & ",CLIENTE3=" & "'" & cliente3 & "'" & ",CLIENTET='x',TIPO_COD=" & "'" & tipo_cod & "'" & " WHERE ANA_CODIGO=" & ana_codigo
                    Dim mycom As New SqlCommand(consulta_nota, SqlConnection1)
                    If Me.SqlConnection1.State = ConnectionState.Closed Then
                        Me.SqlConnection1.Open()
                    End If
                    Try
                        mycom.ExecuteNonQuery()
                        Me.SqlConnection1.Close()
                    Catch ex As Exception

                    End Try
                End If
            Next
            Call Creacion_Excel_Lista(objHojaExcel, objLibroExcel)
            Call pagina_notas(objHojaExcel)
            Call Inicio_Imprime_Lista(objHojaExcel, cfec, clog)
            MUESTRA1 = "LIS" : MUESTRA2 = "" : MUESTRA3 = "" : MUESTRA4 = ""
            Call graba_cotizacion()
            Call graba_SQL_Cotiza()
            carta = 0
            Lpag = 1
            Lsuma_pixeles = 94.5
CONCUR:
        Catch ex As Exception
            MsgBox(" Ha ocurrido un error, contatese con su administrador. ", MsgBoxStyle.Information)
        End Try
    End Sub

    Private Sub CBCotLis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCotLis.Click
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim cfec, clog As Boolean
        If MUESTRA1 = "XLS" Then MsgBox("Imposible grabar, el archivo es de tipo XLS") : GoTo NOO
        If concu = "S" Then MsgBox("Advertencia : El sistema se encuentra en uso por otro usuario") : GoTo NOO
        cfec = False
        clog = False
        Lj = 62
        Lll = 69
        Lsuma_pixeles = 790.5 + 63.75 + 12.75
        Lcont = 122
        cotiza_listado = "S"
        MUESTRA1 = "LIS"
        Call Proceso_Impresion()
        cotiza_listado = "N"
        carta = 0
        Lpag = 1
        Lsuma_pixeles = 94.5
NOO:
    End Sub

    Private Sub Revisa_Cotizacion_Grabada(ByRef mensaje_advertencia As Boolean)
        Dim FILA_NOTAS_R As DataRow
        Dim myselectquery, consulta_nota As String
        Dim NUMCOT1 As Double
        Dim ULT_MAS_UNA, numero_coti As Integer
        SqlConnection1.Open()
        consulta_nota = "select COT_NUMERO from COTIZACION WHERE COT_NUMERO=" & TextBox1.Text
        Dim myCommand2 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        myReader2.Read()
        Try
            NUMCOT1 = myReader2.GetValue(0)
            mensaje_advertencia = True
        Catch ex As Exception
            mensaje_advertencia = False
        End Try
        myReader2.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub ULTIMA_COTIZA_PLA()
        Dim consulta_nota As String
        SqlConnection1.Open()
        consulta_nota = "select NPL_NOMBRE,NPL_OBSERVACION from NOTA_PLANILLA WHERE NPL_NOMBRE='Carta  St 1'"
        Dim myCommand2 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader = myCommand2.ExecuteReader()
        myReader2.Read()
        Npl1 = myReader2.GetString(1)
        myReader2.Close()
        SqlConnection1.Close()
    End Sub

    Private Sub IMPRIME_NUMERO_PAGINAS(ByVal HOJA_EXCEL As Excel.Worksheet)
        Dim NUM_PAG, TOT_PAG, jy, filP, ult_fin As Integer
        Dim junto As String
        ult_fin = Lpag - 1
        For jy = 1 To Lpag
            If Carta_Lista = "S" Or cotiza_listado = "S" Then
                If jy = 1 Then filP = 63
                If jy = 2 Then filP = 125
                If jy > 2 Then filP = 1 + (62 * (jy - 1))
            Else
                If jy = 1 Then filP = 3
                If jy = 2 Then filP = 63
                If jy > 2 Then filP = 1 + (62 * (jy - 1))
            End If
            If jy = 1 Then filP = 3
            If jy = 2 Then filP = 63
            If jy > 2 Then filP = 1 + (62 * (jy - 1))
            junto = CStr(jy & "/" & Lpag)
            HOJA_EXCEL.Range("AE" & filP.ToString & ":AH" & filP.ToString).Merge()
            HOJA_EXCEL.Range("AE" & filP.ToString).Value = "pág: " & junto
            HOJA_EXCEL.Range("AE" & filP.ToString).Font.Size = 7
            HOJA_EXCEL.Range("AE" & filP.ToString & ":AH" & filP.ToString).HorizontalAlignment = Excel.XlHAlign.xlHAlignRight
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage1"
                GroupBox22.Visible = True
            Case "TabPage2"
                GroupBox22.Visible = True
            Case "TabPage5"
                GroupBox22.Visible = True
            Case "TabPage4"
                GroupBox22.Visible = True
            Case "TabPage3"
                GroupBox22.Visible = True
            Case "TabPage11"
                GroupBox22.Visible = True
            Case "TabPage8"
                GroupBox22.Visible = True
            Case "TabPage12"
                GroupBox22.Visible = True
            Case "TabPage13"
                GroupBox22.Visible = True
            Case "TabPage14"
                GroupBox23.Visible = True
            Case "TabPage9"
                GroupBox7.Visible = True
            Case "TabPage10"
                GroupBox31.Visible = True
            Case "TabPage6"
                GroupBox30.Visible = True
            Case "TabPage15"
                GroupBox30.Visible = True
        End Select
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        GroupBox22.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.GroupBox23.Visible = False
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.GroupBox7.Visible = False
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.GroupBox26.Visible = True
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.GroupBox26.Visible = False
    End Sub

    Private Sub Control_MuestraySub(ByVal esmuestra As String, ByVal HOJA_EXCEL As Excel.Worksheet, ByVal CLIENTE As String, ByVal DESDE As Double, ByVal HASTA As Double, ByVal quetipo As Integer, ByVal codigo As Double)
        Dim Fila_Siguiente, Fila_Sub As DataRow
        Dim Caracter, cambio_de_Hoja, query, essubmuestra As String
        Dim dif, i, Cuenta_Fila_Combo, Fila_l As Integer
        Dim BusSub As Object
        Cuenta_Fila_Combo = Lj
        For Each Fila_Siguiente In Cjto_Cotizacion1.Tables("ANALISIS").Rows
            essubmuestra = "N"
            If quetipo > 0 Then
                If Fila_Siguiente("ANA_CODIGO") >= DESDE And Fila_Siguiente("ANA_CODIGO") < HASTA And Fila_Siguiente(CLIENTE) = "x" Then
                    query = Fila_Siguiente("ANA_ANALISIS")
                    Fila_l = 1
                    For i = 1 To query.Length
                        Caracter = Mid(query, i, 1)
                        If Asc(Caracter) = 10 Then
                            If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                            If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                            If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                            Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1
                            If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                            If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                            If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                            Fila_l = Fila_l + 1
                        End If
                    Next
                    Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1
                    'If Fila_l > 1 Then Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1

                    If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                    If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                    If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"

                    If Fila_l > 1 Then Cuenta_Fila_Combo = Cuenta_Fila_Combo + 1

                    If Lpag = 1 And (Cuenta_Fila_Combo Mod 60) = 0 Then cambio_de_Hoja = "S"
                    If Lpag = 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                    If Lpag <> 1 And (Cuenta_Fila_Combo Mod Lcont) = 0 Then cambio_de_Hoja = "S"
                    quetipo = quetipo + 1
                    BusSub = Fila_Siguiente("ANA_CODIGO")
                    Fila_Sub = Cjto_Cotizacion1.Tables("SUBMUESTRA").Rows.Find(BusSub)
                    If Not (Fila_Sub Is Nothing) Then essubmuestra = "S"
                    If essubmuestra = "N" Then Exit For
                    'If quetipo > 3 Then Exit For
                End If
            End If
            If Fila_Siguiente("ANA_CODIGO") = codigo Then quetipo = quetipo + 1
        Next
        If cambio_de_Hoja = "S" Then
            dif = Lcont - Lj
            Lcont = 62 + (Lj + dif)
            Lpag = Lpag + 1
            Lj = Lj + (3 + dif) : Lsuma_pixeles = Lsuma_pixeles + (Lpix * (3 + dif))
            Call CAMBIA_HOJA_CLIENTE(HOJA_EXCEL)
            If esmuestra = "N" Then Lj = Lj + 1 : Lsuma_pixeles = Lsuma_pixeles + Lpix
        End If
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        RTxtAlto.Text = ""
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        RTxtMedio.Text = ""
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        RTxtBajo.Text = ""
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        RichTextBox1.Text = ""
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        RichTextBox3.Text = ""
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GroupBox30.Visible = True
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        GroupBox30.Visible = False
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        GroupBox31.Visible = False
    End Sub

    Private Sub TabControl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl2.Click
        TabControl2.BringToFront()
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))

        GroupBox31.BringToFront()
        GroupBox23.BringToFront()
        GroupBox7.BringToFront()
        GroupBox31.Visible = False
        GroupBox23.Visible = False
        GroupBox7.Visible = False
        GroupBox28.Visible = False
        GrbListado.Visible = False
        If TabControl2.SelectedTab.Text() = "Análisis" Then
            Dim Form_man As New Frm_Mantenedor
            MODIFICADOR = "S"
            Form_man.Show()
        End If
        If TabControl2.SelectedTab.Text() = "Listados" Then
            GrbListado.Visible = True
            Button16.Visible = True
            BTGrabaListado.Visible = True
        End If
        If TabControl2.SelectedTab.Text() = "  Lista $  " Then
            GroupBox28.Visible = True
        End If
        If TabControl2.SelectedTab.Text() = "  Otros   " Then
            GroupBox28.Visible = True
        End If
    End Sub

    Private Sub Button16_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        GroupBox7.Visible = True
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Dim fecha_inv As String
        Dim mycell As New DataGridCell
        Dim fii As Integer
        TabControl2.SendToBack()
        Me.TabControl2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Button21.Visible = True
        GrbListado.Visible = False
        GroupBox28.Visible = False
        GroupBox22.Visible = False
        GroupBox26.Visible = False
        GroupBox31.Visible = False
        GroupBox30.Visible = False
        GroupBox7.Visible = False
        GroupBox23.Visible = False
        ultima_tab = TabControl1.SelectedTab.Name
        ultima_tabff = TabControl1.SelectedTab.Name
        RadioButton3.Checked = True
        Filtro_Muestra()
        Select Case ultima_tab
            Case "TabPage2"
                DataGrid2.Focus()
            Case "TabPage5"
                DataGrid8.Focus()
            Case "TabPage4"
                DataGrid4.Focus()
                'fii = DataGrid4.CurrentCell.RowNumber.MaxValue
                'mycell.ColumnNumber = 2
                'mycell.RowNumber = fii
                'DataGrid4.CurrentCell = mycell
            Case "TabPage3"
                DataGrid3.Focus()
                'fii = DataGrid3.CurrentCell.RowNumber.MaxValue
                'mycell.ColumnNumber = 2
                'mycell.RowNumber = fii
                'DataGrid3.CurrentCell = mycell
            Case "TabPage11"
                DataGrid16.Focus()
            Case "TabPage8"
                DataGrid27.Focus()
            Case "TabPage12"
                DataGrid17.Focus()
            Case "TabPage10"
                GroupBox28.Visible = True
            Case "TabPage6"
                Button21.Visible = False
            Case "TabPage15"
                Button21.Visible = False
            Case "TabPage13"
                DataGrid18.Focus()
            Case "TabPage14"
                GroupBox28.Visible = True
            Case "TabPage9"
                fecha_inv = Mid(TextBox3.Text, 1, 2) & "-" & Mid(TextBox3.Text, 4, 2) & "-" & Mid(TextBox3.Text, 7, 4)
                LFecha = fecha_inv
                LEmpresa = TextBox22.Text
                LNombre = TextBox23.Text
                LEmail2 = TextBox14.Text
                LEmail = TextBox9.Text
                LCelular = TextBox16.Text
                LFono = TextBox10.Text
                LFax = TextBox11.Text
                LCiudad = CBCiudad.Text
                LComuna = CBComuna.Text
                LDireccion = TextBox7.Text
                LAtencion = TextBox8.Text
                GrbListado.Visible = True
                DataGrid13.Focus()
            Case "Cotización"
                DataGrid1.Focus()
        End Select

    End Sub

    Private Sub Button17_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        If TabControl2.SelectedTab.Text() = "  Otros   " Then
            GroupBox31.Visible = True
        End If
        If TabControl2.SelectedTab.Text() = "  Lista $  " Then
            GroupBox23.Visible = True
        End If
    End Sub

    Private Sub CheckBox49_CheckStateChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckBox49.CheckStateChanged
        DataGrid1.TableStyles.Remove(DataGrid1.TableStyles(0))

        Dim TS1 As New DataGridTableStyle
        TS1.MappingName = "COTIZA_DETALLE"
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "Muestra"
        Me.DataGridTextBoxColumn31.MappingName = "CTD_MUESTRA"
        Me.DataGridTextBoxColumn31.ReadOnly = True
        Me.DataGridTextBoxColumn31.Width = 60
        TS1.GridColumnStyles.Add(DataGridTextBoxColumn31)
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Código"
        Me.DataGridTextBoxColumn2.MappingName = "CTD_ANALISIS"
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 60
        TS1.GridColumnStyles.Add(DataGridTextBoxColumn2)
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Detalle Análisis"
        Me.DataGridTextBoxColumn3.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 550
        TS1.GridColumnStyles.Add(DataGridTextBoxColumn3)
        If CheckBox49.Checked = True Then
            '
            'DataGridTextBoxColumn137
            '
            Me.DataGridTextBoxColumn137.Alignment = System.Windows.Forms.HorizontalAlignment.Center
            Me.DataGridTextBoxColumn137.Format = ""
            Me.DataGridTextBoxColumn137.FormatInfo = Nothing
            Me.DataGridTextBoxColumn137.HeaderText = "Cant."
            Me.DataGridTextBoxColumn137.MappingName = "CTD_CANTIDAD"
            Me.DataGridTextBoxColumn137.NullText = ""
            Me.DataGridTextBoxColumn137.Width = 30
            TS1.GridColumnStyles.Add(DataGridTextBoxColumn137)
        End If
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = "##,###,###"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Unitario"
        Me.DataGridTextBoxColumn5.MappingName = "CTD_SUBTOTAL"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 60

        TS1.GridColumnStyles.Add(DataGridTextBoxColumn5)

        DataGrid1.TableStyles.Add(TS1)

        Me.TransformaMultilinea(Me.DataGrid1)
    End Sub

    Private Sub Extraer_Descripcion(ByVal myGrid As DataGrid, ByVal Fila_Num As Integer)
        Dim Descuento, Largo_Jocker As Integer

        If TextBox36.Text = "" Then
            TextBox36.Text = myGrid.Item(Fila_Num, 2)
        Else
            TextBox36.Text = TextBox36.Text & "-" & myGrid.Item(Fila_Num, 2)
        End If


        If IsDBNull(myGrid.Item(Fila_Num, 4)) = False Then
            Descuento = myGrid.Item(Fila_Num, 4)
        Else
            Descuento = 0
        End If
        If Descuento <> 0 Then
            Suma_Valor_Jocker = Suma_Valor_Jocker + CInt(myGrid.Item(Fila_Num, 5))
            TextBox37.Text = Suma_Valor_Jocker
        Else
            Suma_Valor_Jocker = Suma_Valor_Jocker + CInt(myGrid.Item(Fila_Num, 3))
            TextBox37.Text = Suma_Valor_Jocker
        End If

Largo_Max:
    End Sub

    Private Sub class_COTIZADOR_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        Call GRABA_CONCURRENCIA("N")
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim NetoJ, Descuento_J As Integer
        If e.KeyChar = Chr(13) Then
            If TextBox37.Text <> "" Then
                NetoJ = CInt(TextBox37.Text)
                Descuento_J = (CDbl(TextBox4.Text) / 100) * NetoJ
                TextBox6.Text = NetoJ - Descuento_J
            End If
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        Dim Restaj, Netj As Integer
        If e.KeyChar = Chr(13) Then
            If TextBox37.Text <> "" Then
                Restaj = CInt(TextBox37.Text) - CInt(TextBox6.Text)
                Netj = CInt(TextBox37.Text)
                TextBox4.Text = Format(CDbl(((Restaj / Netj)) * 100), "##.#")
            End If
        End If
    End Sub

    Private Sub Filtro_Muestra()
        Dim yll, texto, MAYU As String
        Dim fii As Integer
        Dim FILA_DATAROW As DataRow
        Dim mycell As New DataGridCell
        yll = TabControl1.SelectedTab.Name
        Select Case yll
            Case "TabPage2"
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Clear()
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS1", Me.SqlConnection1.ConnectionString)
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=1000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage5"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS13", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS13").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=2000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage4"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS12", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS12").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=3000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                'DataGrid4.Focus()
                'fii = DataGrid4.CurrentCell.RowNumber.MaxValue
                'mycell.ColumnNumber = 2
                'mycell.RowNumber = fii
                'DataGrid4.CurrentCell = mycell
            Case "TabPage3"
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS11").Clear()
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS11", Me.SqlConnection1.ConnectionString)
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=4000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage11"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS14", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS14").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=5000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage8"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS17", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS17").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=6000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage12"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS15", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS15").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=7000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
            Case "TabPage13"
                Dim Test1 As DbManager = New DbManager("COTIZA_ANALISIS16", Me.SqlConnection1.ConnectionString)
                Cjto_Cotizacion1.Tables("COTIZA_ANALISIS16").Clear()
                If RadioButton3.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND ANA_NIVEL_PRECIO='CFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton4.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='CFR' OR ANA_NIVEL_PRECIO='COC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton5.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND ANA_NIVEL_PRECIO='IFR' AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton6.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND TIPO_COD<>'JA' AND (ANA_NIVEL_PRECIO='IFR' OR ANA_NIVEL_PRECIO='IOC') ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
                If RadioButton7.Checked = True Then
                    Dim query1 As String = "Select * from ANALISIS WHERE TMU_CODIGO=8000 AND TIPO_COD<>'JA' ORDER BY ANA_CODIGO"
                    Test1.Selecccionar(Cjto_Cotizacion1, query1)
                End If
        End Select
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Filtro_Muestra()
    End Sub

    Private Sub Button25_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button25.Click
        TextBox22.Text = ""
        TextBox22.Focus()
    End Sub

    Private Sub BTAceptaUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTAceptaUsu.Click
        Dim myselectquery, consulta_nota As String
        myselectquery = "select USU_USUARIO,MODULO,USU_CLAVE,USU_NOMBRE,NIV_NIVEL FROM NIVEL_USUARIO WHERE USU_USUARIO=" & "'" & TxtUsuario.Text & "'" & " AND MODULO='COTIZADOR'"
        Dim myCommand As New SqlCommand(myselectquery, SqlConnection1)
        SqlConnection1.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        Try
            myReader.Read()
            If myReader.GetString(2) <> TxtPassword.Text Then
                MsgBox("Clave Incorrecta")
                If CuentaIntentos < 4 Then
                    myReader.Close()
                    SqlConnection1.Close()
                    GoTo CLAVEINTENTO
                End If
                GoTo CLAVEMALA
            Else
                Nivel = myReader.GetInt32(4)
                GoTo CLAVEBUENA
            End If
        Catch ex As Exception
            MsgBox("Clave Incorrecta")
            If CuentaIntentos < 4 Then
                myReader.Close()
                SqlConnection1.Close()
                GoTo CLAVEINTENTO
            End If
            GoTo CLAVEMALA
        End Try
CLAVEMALA:
        myReader.Close()
        SqlConnection1.Close()
        Me.Close()
CLAVEBUENA:
        myReader.Close()
        SqlConnection1.Close()
        GrbAcceso.Visible = False
CLAVEINTENTO:
        CuentaIntentos = CuentaIntentos + 1
    End Sub

    Private Sub BTCancelaUsu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTCancelaUsu.Click
        Me.Close()
    End Sub

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.BTAceptaUsu.Focus()
        End If
    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged
        Call Filtro_Muestra()
    End Sub


End Class

