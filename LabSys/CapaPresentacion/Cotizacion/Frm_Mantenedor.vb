Imports System.Data.SqlClient
Public Class Frm_Mantenedor
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
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid2 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid3 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid4 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid5 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid6 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGrid7 As System.Windows.Forms.DataGrid
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents Adap_Analisis As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents Cjto_Mantenedor1 As Cjto_Mantenedor
    Public MODIFICAR As String
    Public le As Integer
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
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid9 As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle9 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn55 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn56 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn57 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn58 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SqlDataAdapter1 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter2 As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents TxtAyuda As System.Windows.Forms.Button
    Friend WithEvents GrbAyuda As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frm_Mantenedor))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGrid2 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.DataGrid3 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.DataGrid4 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.DataGrid5 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.DataGrid9 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle9 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn55 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn56 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn57 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn58 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.DataGrid6 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.DataGrid7 = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GrbAyuda = New System.Windows.Forms.GroupBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cjto_Mantenedor1 = New Cjto_Mantenedor
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.Adap_Analisis = New System.Data.SqlClient.SqlDataAdapter
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtAyuda = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button9 = New System.Windows.Forms.Button
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button11 = New System.Windows.Forms.Button
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDataAdapter2 = New System.Data.SqlClient.SqlDataAdapter
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrbAyuda.SuspendLayout()
        CType(Me.Cjto_Mantenedor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(816, 762)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(808, 734)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "1.Foliar"
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.CaptionVisible = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.DataGrid1
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ANALISIS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "Cod."
        Me.DataGridTextBoxColumn1.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 35
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn2.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 550
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "#,###,###"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn3.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Niv"
        Me.DataGridTextBoxColumn4.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 30
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn5.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 25
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn6.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 30
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "SubM"
        Me.DataGridTextBoxColumn7.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 30
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(808, 734)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "2.+Tejido"
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.CaptionVisible = False
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid2.TabIndex = 0
        Me.DataGrid2.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.DataGrid2
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ANALISIS1"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Cod."
        Me.DataGridTextBoxColumn8.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 35
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
        Me.DataGridTextBoxColumn10.Format = "#,###,###"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn10.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Niv"
        Me.DataGridTextBoxColumn11.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 30
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn12.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 25
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn13.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 30
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "SubM"
        Me.DataGridTextBoxColumn14.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 30
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGrid3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(808, 734)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "3.Agua"
        '
        'DataGrid3
        '
        Me.DataGrid3.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.CaptionVisible = False
        Me.DataGrid3.DataMember = ""
        Me.DataGrid3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid3.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid3.Name = "DataGrid3"
        Me.DataGrid3.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid3.TabIndex = 0
        Me.DataGrid3.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.AllowSorting = False
        Me.DataGridTableStyle3.DataGrid = Me.DataGrid3
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "ANALISIS2"
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Cod."
        Me.DataGridTextBoxColumn15.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 35
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn16.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 550
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = "#,###,###"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn17.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 50
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "Niv"
        Me.DataGridTextBoxColumn18.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 30
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn19.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 25
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn20.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 30
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "SubM"
        Me.DataGridTextBoxColumn21.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 30
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DataGrid4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 24)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(808, 734)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "4.Suelo"
        '
        'DataGrid4
        '
        Me.DataGrid4.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid4.CaptionVisible = False
        Me.DataGrid4.DataMember = ""
        Me.DataGrid4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid4.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid4.Name = "DataGrid4"
        Me.DataGrid4.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid4.TabIndex = 0
        Me.DataGrid4.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AllowSorting = False
        Me.DataGridTableStyle4.DataGrid = Me.DataGrid4
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25, Me.DataGridTextBoxColumn26, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "ANALISIS3"
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "Cod."
        Me.DataGridTextBoxColumn22.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 35
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn23.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 550
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = "#,###,###"
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn24.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 50
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "Niv"
        Me.DataGridTextBoxColumn25.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 30
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn26.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 25
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn27.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 30
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "SubM"
        Me.DataGridTextBoxColumn28.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 30
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.DataGrid5)
        Me.TabPage5.Location = New System.Drawing.Point(4, 24)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(808, 734)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "5.Fert-Qui"
        '
        'DataGrid5
        '
        Me.DataGrid5.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid5.CaptionVisible = False
        Me.DataGrid5.DataMember = ""
        Me.DataGrid5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid5.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid5.Name = "DataGrid5"
        Me.DataGrid5.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid5.TabIndex = 0
        Me.DataGrid5.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.AllowSorting = False
        Me.DataGridTableStyle5.DataGrid = Me.DataGrid5
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "ANALISIS4"
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "Cod."
        Me.DataGridTextBoxColumn29.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 35
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn30.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 550
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = "#,###,###"
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn31.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 50
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "Niv"
        Me.DataGridTextBoxColumn32.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 30
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn33.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 25
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn34.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 30
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "SubM"
        Me.DataGridTextBoxColumn35.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 30
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.DataGrid9)
        Me.TabPage8.Location = New System.Drawing.Point(4, 24)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(808, 734)
        Me.TabPage8.TabIndex = 7
        Me.TabPage8.Text = "6.Fert-Org"
        '
        'DataGrid9
        '
        Me.DataGrid9.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid9.CaptionVisible = False
        Me.DataGrid9.DataMember = ""
        Me.DataGrid9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid9.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid9.Name = "DataGrid9"
        Me.DataGrid9.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid9.TabIndex = 0
        Me.DataGrid9.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle9})
        '
        'DataGridTableStyle9
        '
        Me.DataGridTableStyle9.DataGrid = Me.DataGrid9
        Me.DataGridTableStyle9.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54, Me.DataGridTextBoxColumn55, Me.DataGridTextBoxColumn56, Me.DataGridTextBoxColumn57, Me.DataGridTextBoxColumn58})
        Me.DataGridTableStyle9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle9.MappingName = "ANALISIS7"
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Format = ""
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "Cod."
        Me.DataGridTextBoxColumn52.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 35
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
        Me.DataGridTextBoxColumn54.Format = "#,###,###"
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn54.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 50
        '
        'DataGridTextBoxColumn55
        '
        Me.DataGridTextBoxColumn55.Format = ""
        Me.DataGridTextBoxColumn55.FormatInfo = Nothing
        Me.DataGridTextBoxColumn55.HeaderText = "Niv"
        Me.DataGridTextBoxColumn55.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn55.NullText = ""
        Me.DataGridTextBoxColumn55.Width = 30
        '
        'DataGridTextBoxColumn56
        '
        Me.DataGridTextBoxColumn56.Format = ""
        Me.DataGridTextBoxColumn56.FormatInfo = Nothing
        Me.DataGridTextBoxColumn56.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn56.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn56.NullText = ""
        Me.DataGridTextBoxColumn56.Width = 25
        '
        'DataGridTextBoxColumn57
        '
        Me.DataGridTextBoxColumn57.Format = ""
        Me.DataGridTextBoxColumn57.FormatInfo = Nothing
        Me.DataGridTextBoxColumn57.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn57.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn57.NullText = ""
        Me.DataGridTextBoxColumn57.Width = 30
        '
        'DataGridTextBoxColumn58
        '
        Me.DataGridTextBoxColumn58.Format = ""
        Me.DataGridTextBoxColumn58.FormatInfo = Nothing
        Me.DataGridTextBoxColumn58.HeaderText = "SubM"
        Me.DataGridTextBoxColumn58.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn58.NullText = ""
        Me.DataGridTextBoxColumn58.Width = 30
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.DataGrid6)
        Me.TabPage6.Location = New System.Drawing.Point(4, 24)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(808, 734)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "7.+Análisis"
        '
        'DataGrid6
        '
        Me.DataGrid6.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid6.CaptionVisible = False
        Me.DataGrid6.DataMember = ""
        Me.DataGrid6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid6.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid6.Name = "DataGrid6"
        Me.DataGrid6.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid6.TabIndex = 0
        Me.DataGrid6.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.AllowSorting = False
        Me.DataGridTableStyle6.DataGrid = Me.DataGrid6
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39, Me.DataGridTextBoxColumn40, Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn42})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "ANALISIS5"
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = ""
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "Cod."
        Me.DataGridTextBoxColumn36.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 35
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Format = ""
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn37.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 550
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Format = "#,###,###"
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn38.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 50
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Format = ""
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "Niv"
        Me.DataGridTextBoxColumn39.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 30
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn40.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 25
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn41.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 30
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "SubM"
        Me.DataGridTextBoxColumn42.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.Width = 30
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.DataGrid7)
        Me.TabPage7.Location = New System.Drawing.Point(4, 24)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(808, 734)
        Me.TabPage7.TabIndex = 6
        Me.TabPage7.Text = "8.Kit,Otros"
        '
        'DataGrid7
        '
        Me.DataGrid7.CaptionFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid7.CaptionVisible = False
        Me.DataGrid7.DataMember = ""
        Me.DataGrid7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGrid7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid7.Location = New System.Drawing.Point(0, 0)
        Me.DataGrid7.Name = "DataGrid7"
        Me.DataGrid7.Size = New System.Drawing.Size(808, 728)
        Me.DataGrid7.TabIndex = 0
        Me.DataGrid7.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle7})
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.AllowSorting = False
        Me.DataGridTableStyle7.DataGrid = Me.DataGrid7
        Me.DataGridTableStyle7.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45, Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn47, Me.DataGridTextBoxColumn48, Me.DataGridTextBoxColumn49})
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "ANALISIS6"
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Format = ""
        Me.DataGridTextBoxColumn43.FormatInfo = Nothing
        Me.DataGridTextBoxColumn43.HeaderText = "Cod."
        Me.DataGridTextBoxColumn43.MappingName = "ANA_CODIGO"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 35
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "Descripción"
        Me.DataGridTextBoxColumn44.MappingName = "ANA_ANALISIS"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 550
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = "#,###,###"
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.HeaderText = "$ Neto"
        Me.DataGridTextBoxColumn45.MappingName = "ANA_NETO"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.Width = 50
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "Niv"
        Me.DataGridTextBoxColumn46.MappingName = "ANA_NIVEL_PRECIO"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 30
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Format = ""
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "Tpo"
        Me.DataGridTextBoxColumn47.MappingName = "TIPO_COD"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.Width = 25
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Format = ""
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "Mstr"
        Me.DataGridTextBoxColumn48.MappingName = "TMU_CODIGO"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 30
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Format = ""
        Me.DataGridTextBoxColumn49.FormatInfo = Nothing
        Me.DataGridTextBoxColumn49.HeaderText = "SubM"
        Me.DataGridTextBoxColumn49.MappingName = "SUB_CODIGO"
        Me.DataGridTextBoxColumn49.NullText = ""
        Me.DataGridTextBoxColumn49.Width = 30
        '
        'GrbAyuda
        '
        Me.GrbAyuda.Controls.Add(Me.Label24)
        Me.GrbAyuda.Controls.Add(Me.Label23)
        Me.GrbAyuda.Controls.Add(Me.Label22)
        Me.GrbAyuda.Controls.Add(Me.Label21)
        Me.GrbAyuda.Controls.Add(Me.Label20)
        Me.GrbAyuda.Controls.Add(Me.Label5)
        Me.GrbAyuda.Controls.Add(Me.Label18)
        Me.GrbAyuda.Controls.Add(Me.Label17)
        Me.GrbAyuda.Controls.Add(Me.Label19)
        Me.GrbAyuda.Controls.Add(Me.Label2)
        Me.GrbAyuda.Controls.Add(Me.Label16)
        Me.GrbAyuda.Controls.Add(Me.Label14)
        Me.GrbAyuda.Controls.Add(Me.Label15)
        Me.GrbAyuda.Controls.Add(Me.Label10)
        Me.GrbAyuda.Controls.Add(Me.Label9)
        Me.GrbAyuda.Controls.Add(Me.Label8)
        Me.GrbAyuda.Controls.Add(Me.Label7)
        Me.GrbAyuda.Controls.Add(Me.Label13)
        Me.GrbAyuda.Controls.Add(Me.Button1)
        Me.GrbAyuda.Controls.Add(Me.Label11)
        Me.GrbAyuda.Controls.Add(Me.Label12)
        Me.GrbAyuda.Controls.Add(Me.Label6)
        Me.GrbAyuda.Controls.Add(Me.Label3)
        Me.GrbAyuda.Controls.Add(Me.Label1)
        Me.GrbAyuda.Location = New System.Drawing.Point(0, 80)
        Me.GrbAyuda.Name = "GrbAyuda"
        Me.GrbAyuda.Size = New System.Drawing.Size(824, 368)
        Me.GrbAyuda.TabIndex = 1
        Me.GrbAyuda.TabStop = False
        Me.GrbAyuda.Visible = False
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(8, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(704, 16)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "            Sub : Define al tipo de sub muestra al cual pertenece éste análisis (" & _
        "Ej: 1200:Vides en flor, etc)"
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(8, 184)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(704, 16)
        Me.Label23.TabIndex = 31
        Me.Label23.Text = "            Mstr : Define al tipo de muestra al cual pertenece éste análisis (100" & _
        "0:Foliar, 2000:+Tejidos, 3000:Agua, etc)"
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 168)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(704, 16)
        Me.Label22.TabIndex = 30
        Me.Label22.Text = "            Tpo : Define si el codigo corresponde a un análisis (AN), Joker (JO) " & _
        " o  es un texto (TE)."
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(8, 152)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(704, 16)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "                     que figuren primero los análisis FR y al final los  OC (esto" & _
        "s pintados de azul)."
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 136)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(704, 16)
        Me.Label20.TabIndex = 28
        Me.Label20.Text = "                     Permite ordenar los análisis que figuran en las pestañas de " & _
        "las diferentes muestras de tal forma"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(704, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "            Niv :  Define si el análisis es frecuente (FR)  o  ocacional (OC)"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(0, 8)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(808, 16)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Ayuda"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(562, 256)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 16)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = ") + Enter al mismo tiempo."
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.LightGray
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label19.Location = New System.Drawing.Point(552, 256)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 16)
        Me.Label19.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(544, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "            Si el nuevo análisis ocupa más de una línea : Posicionese al final de" & _
        " la fila y presione shif ("
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(8, 336)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(704, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "          Dar click en boton ""Elimina""  y  luego en boton ""Graba"""
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(8, 320)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(704, 16)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "          Posicionarse en la fila del análisis que se desea eliminar."
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(8, 304)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(704, 16)
        Me.Label15.TabIndex = 19
        Me.Label15.Text = "Eliminar análisis:"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(704, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "         Notas:"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(704, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "         Finalmente dar click en boton ""Graba""."
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(704, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "         Digitar el nuevo código , descripción , $ Neto y toda la informacion en " & _
        "las columnas restantes."
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 40)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(704, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "         Dar Click en boton ""Nuevo"". El cursor se ubicará en la última fila."
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(8, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(704, 16)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "            Si un análisis no tiene precio definido, completar con un 0 la column" & _
        "a ""$ Neto""."
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(808, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "X"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 288)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(704, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "        Realizar la modificación directamente en la grilla, luego dar click en el" & _
        " botón ""Graba""."
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 272)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(704, 16)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Moficar (Código, Descripción , $ Neto , etc.):"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(704, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "            Los precios deben digitarse sin el punto separador de miles."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(704, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "            Todos los campos deben contener información, incluyendo las columnas " & _
        "Niv, Tipo, Mstr y Sub."
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(704, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nuevo análisis:"
        '
        'Cjto_Mantenedor1
        '
        Me.Cjto_Mantenedor1.DataSetName = "Cjto_Mantenedor"
        Me.Cjto_Mantenedor1.Locale = New System.Globalization.CultureInfo("es-CL")
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PREC" & _
        "IO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET, TIPO_COD FROM ANALISIS"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1

        '
        Me.SqlConnection1.ConnectionString = "workstation id=DESARROLLO;packet size=4096;user id=sa;data source=HP-INF-SANDO;pe" & _
            "rsist security info=True;initial catalog=LabSys;password=agrolito"
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO ANALISIS(ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, " & _
        "ANA_NIVEL_PRECIO, CLIENTE1, CLIENTE2, CLIENTE3, CLIENTET, TIPO_COD) VALUES (@ANA" & _
        "_CODIGO, @ANA_ANALISIS, @TMU_CODIGO, @SUB_CODIGO, @ANA_NETO, @ANA_NIVEL_PRECIO, " & _
        "@CLIENTE1, @CLIENTE2, @CLIENTE3, @CLIENTET, @TIPO_COD); SELECT ANA_CODIGO, ANA_A" & _
        "NALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PRECIO, CLIENTE1, CLIENTE2," & _
        " CLIENTE3, CLIENTET, TIPO_COD FROM ANALISIS WHERE (ANA_CODIGO = @ANA_CODIGO)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, "ANA_ANALISIS"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIPO_COD", System.Data.SqlDbType.NVarChar, 5, "TIPO_COD"))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE ANALISIS SET ANA_CODIGO = @ANA_CODIGO, ANA_ANALISIS = @ANA_ANALISIS, TMU_C" & _
        "ODIGO = @TMU_CODIGO, SUB_CODIGO = @SUB_CODIGO, ANA_NETO = @ANA_NETO, ANA_NIVEL_P" & _
        "RECIO = @ANA_NIVEL_PRECIO, CLIENTE1 = @CLIENTE1, CLIENTE2 = @CLIENTE2, CLIENTE3 " & _
        "= @CLIENTE3, CLIENTET = @CLIENTET, TIPO_COD = @TIPO_COD WHERE (ANA_CODIGO = @Ori" & _
        "ginal_ANA_CODIGO) AND (ANA_ANALISIS = @Original_ANA_ANALISIS OR @Original_ANA_AN" & _
        "ALISIS IS NULL AND ANA_ANALISIS IS NULL) AND (ANA_NETO = @Original_ANA_NETO OR @" & _
        "Original_ANA_NETO IS NULL AND ANA_NETO IS NULL) AND (ANA_NIVEL_PRECIO = @Origina" & _
        "l_ANA_NIVEL_PRECIO OR @Original_ANA_NIVEL_PRECIO IS NULL AND ANA_NIVEL_PRECIO IS" & _
        " NULL) AND (CLIENTE1 = @Original_CLIENTE1 OR @Original_CLIENTE1 IS NULL AND CLIE" & _
        "NTE1 IS NULL) AND (CLIENTE2 = @Original_CLIENTE2 OR @Original_CLIENTE2 IS NULL A" & _
        "ND CLIENTE2 IS NULL) AND (CLIENTE3 = @Original_CLIENTE3 OR @Original_CLIENTE3 IS" & _
        " NULL AND CLIENTE3 IS NULL) AND (CLIENTET = @Original_CLIENTET OR @Original_CLIE" & _
        "NTET IS NULL AND CLIENTET IS NULL) AND (SUB_CODIGO = @Original_SUB_CODIGO OR @Or" & _
        "iginal_SUB_CODIGO IS NULL AND SUB_CODIGO IS NULL) AND (TIPO_COD = @Original_TIPO" & _
        "_COD OR @Original_TIPO_COD IS NULL AND TIPO_COD IS NULL) AND (TMU_CODIGO = @Orig" & _
        "inal_TMU_CODIGO OR @Original_TMU_CODIGO IS NULL AND TMU_CODIGO IS NULL); SELECT " & _
        "ANA_CODIGO, ANA_ANALISIS, TMU_CODIGO, SUB_CODIGO, ANA_NETO, ANA_NIVEL_PRECIO, CL" & _
        "IENTE1, CLIENTE2, CLIENTE3, CLIENTET, TIPO_COD FROM ANALISIS WHERE (ANA_CODIGO =" & _
        " @ANA_CODIGO)"
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_CODIGO", System.Data.SqlDbType.Float, 8, "ANA_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, "ANA_ANALISIS"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NETO", System.Data.SqlDbType.Float, 8, "ANA_NETO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, "ANA_NIVEL_PRECIO"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE1", System.Data.SqlDbType.NVarChar, 1, "CLIENTE1"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE2", System.Data.SqlDbType.NVarChar, 1, "CLIENTE2"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTE3", System.Data.SqlDbType.NVarChar, 1, "CLIENTE3"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CLIENTET", System.Data.SqlDbType.NVarChar, 1, "CLIENTET"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TIPO_COD", System.Data.SqlDbType.NVarChar, 5, "TIPO_COD"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TIPO_COD", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIPO_COD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM ANALISIS WHERE (ANA_CODIGO = @Original_ANA_CODIGO) AND (ANA_ANALISIS " & _
        "= @Original_ANA_ANALISIS OR @Original_ANA_ANALISIS IS NULL AND ANA_ANALISIS IS N" & _
        "ULL) AND (ANA_NETO = @Original_ANA_NETO OR @Original_ANA_NETO IS NULL AND ANA_NE" & _
        "TO IS NULL) AND (ANA_NIVEL_PRECIO = @Original_ANA_NIVEL_PRECIO OR @Original_ANA_" & _
        "NIVEL_PRECIO IS NULL AND ANA_NIVEL_PRECIO IS NULL) AND (CLIENTE1 = @Original_CLI" & _
        "ENTE1 OR @Original_CLIENTE1 IS NULL AND CLIENTE1 IS NULL) AND (CLIENTE2 = @Origi" & _
        "nal_CLIENTE2 OR @Original_CLIENTE2 IS NULL AND CLIENTE2 IS NULL) AND (CLIENTE3 =" & _
        " @Original_CLIENTE3 OR @Original_CLIENTE3 IS NULL AND CLIENTE3 IS NULL) AND (CLI" & _
        "ENTET = @Original_CLIENTET OR @Original_CLIENTET IS NULL AND CLIENTET IS NULL) A" & _
        "ND (SUB_CODIGO = @Original_SUB_CODIGO OR @Original_SUB_CODIGO IS NULL AND SUB_CO" & _
        "DIGO IS NULL) AND (TIPO_COD = @Original_TIPO_COD OR @Original_TIPO_COD IS NULL A" & _
        "ND TIPO_COD IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU_COD" & _
        "IGO IS NULL AND TMU_CODIGO IS NULL)"
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_CODIGO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_ANALISIS", System.Data.SqlDbType.Text, 1000, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_ANALISIS", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NETO", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NETO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ANA_NIVEL_PRECIO", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ANA_NIVEL_PRECIO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE1", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE1", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE2", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE2", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTE3", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTE3", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CLIENTET", System.Data.SqlDbType.NVarChar, 1, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CLIENTET", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TIPO_COD", System.Data.SqlDbType.NVarChar, 5, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TIPO_COD", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'Adap_Analisis
        '
        Me.Adap_Analisis.DeleteCommand = Me.SqlDeleteCommand1
        Me.Adap_Analisis.InsertCommand = Me.SqlInsertCommand1
        Me.Adap_Analisis.SelectCommand = Me.SqlSelectCommand1
        Me.Adap_Analisis.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "ANALISIS", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("ANA_CODIGO", "ANA_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_ANALISIS", "ANA_ANALISIS"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("ANA_NETO", "ANA_NETO"), New System.Data.Common.DataColumnMapping("ANA_NIVEL_PRECIO", "ANA_NIVEL_PRECIO"), New System.Data.Common.DataColumnMapping("CLIENTE1", "CLIENTE1"), New System.Data.Common.DataColumnMapping("CLIENTE2", "CLIENTE2"), New System.Data.Common.DataColumnMapping("CLIENTE3", "CLIENTE3"), New System.Data.Common.DataColumnMapping("CLIENTET", "CLIENTET"), New System.Data.Common.DataColumnMapping("TIPO_COD", "TIPO_COD")})})
        Me.Adap_Analisis.UpdateCommand = Me.SqlUpdateCommand1
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(720, 776)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(60, 28)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Elimina"
        Me.ToolTip1.SetToolTip(Me.Button4, "Elimina análisis:  Seleccionar la fila, dar click en  boton ""Elimina"" ,  luego en" & _
        " ""Graba""")
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(648, 776)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(60, 28)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "Graba"
        Me.ToolTip1.SetToolTip(Me.Button6, "Graba el cambio realizado")
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(576, 776)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 28)
        Me.Button7.TabIndex = 2
        Me.Button7.Text = "Nuevo"
        Me.ToolTip1.SetToolTip(Me.Button7, "Agrega un nuevo análisis a la base Agrolab")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 7000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.ReshowDelay = 10
        '
        'TxtAyuda
        '
        Me.TxtAyuda.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAyuda.Location = New System.Drawing.Point(8, 776)
        Me.TxtAyuda.Name = "TxtAyuda"
        Me.TxtAyuda.Size = New System.Drawing.Size(24, 22)
        Me.TxtAyuda.TabIndex = 12
        Me.TxtAyuda.Text = "?"
        Me.ToolTip1.SetToolTip(Me.TxtAyuda, "Ayuda")
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label69)
        Me.GroupBox3.Controls.Add(Me.Button10)
        Me.GroupBox3.Controls.Add(Me.Button9)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(824, 56)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label69
        '
        Me.Label69.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Label69.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label69.Location = New System.Drawing.Point(0, 8)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(807, 16)
        Me.Label69.TabIndex = 15
        Me.Label69.Text = "Busca Análisis"
        '
        'Button10
        '
        Me.Button10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(616, 24)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(104, 24)
        Me.Button10.TabIndex = 3
        Me.Button10.Text = "Buscar Siguiente"
        '
        'Button9
        '
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button9.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(808, 8)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(16, 16)
        Me.Button9.TabIndex = 2
        Me.Button9.Text = "X"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(64, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(544, 20)
        Me.TextBox3.TabIndex = 1
        Me.TextBox3.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Buscar"
        '
        'Button11
        '
        Me.Button11.BackgroundImage = CType(resources.GetObject("Button11.BackgroundImage"), System.Drawing.Image)
        Me.Button11.Location = New System.Drawing.Point(40, 776)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(24, 22)
        Me.Button11.TabIndex = 10
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand2
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand2
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand2
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "MUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("Expr1", "Expr1"), New System.Data.Common.DataColumnMapping("Expr2", "Expr2"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO"), New System.Data.Common.DataColumnMapping("TMU_MUESTRA", "TMU_MUESTRA")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand2
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM MUESTRA WHERE (TMU_CODIGO = @Original_TMU_CODIGO) AND (TMU_MUESTRA = " & _
        "@Original_TMU_MUESTRA OR @Original_TMU_MUESTRA IS NULL AND TMU_MUESTRA IS NULL) " & _
        "AND (TMU_MUESTRA = @Original_Expr2 OR @Original_Expr2 IS NULL AND TMU_MUESTRA IS" & _
        " NULL)"
        Me.SqlDeleteCommand2.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO MUESTRA(TMU_CODIGO, TMU_MUESTRA) VALUES (@TMU_CODIGO, @TMU_MUESTRA); " & _
        "SELECT TMU_CODIGO AS Expr1, TMU_MUESTRA AS Expr2, TMU_CODIGO, TMU_MUESTRA FROM M" & _
        "UESTRA WHERE (TMU_CODIGO = @TMU_CODIGO) AND (TMU_CODIGO = @TMU_CODIGO1)"
        Me.SqlInsertCommand2.Connection = Me.SqlConnection1
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO1", System.Data.SqlDbType.Int, 4, "Expr1"))
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT TMU_CODIGO AS Expr1, TMU_MUESTRA AS Expr2, TMU_CODIGO, TMU_MUESTRA FROM MU" & _
        "ESTRA"
        Me.SqlSelectCommand2.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE MUESTRA SET TMU_CODIGO = @TMU_CODIGO, TMU_MUESTRA = @TMU_MUESTRA WHERE (TM" & _
        "U_CODIGO = @Original_TMU_CODIGO) AND (TMU_MUESTRA = @Original_TMU_MUESTRA OR @Or" & _
        "iginal_TMU_MUESTRA IS NULL AND TMU_MUESTRA IS NULL) AND (TMU_MUESTRA = @Original" & _
        "_Expr2 OR @Original_Expr2 IS NULL AND TMU_MUESTRA IS NULL); SELECT TMU_CODIGO AS" & _
        " Expr1, TMU_MUESTRA AS Expr2, TMU_CODIGO, TMU_MUESTRA FROM MUESTRA WHERE (TMU_CO" & _
        "DIGO = @TMU_CODIGO) AND (TMU_CODIGO = @TMU_CODIGO1)"
        Me.SqlUpdateCommand2.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, "TMU_MUESTRA"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_MUESTRA", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Expr2", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_MUESTRA", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO1", System.Data.SqlDbType.Int, 4, "Expr1"))
        '
        'SqlDataAdapter2
        '
        Me.SqlDataAdapter2.DeleteCommand = Me.SqlDeleteCommand3
        Me.SqlDataAdapter2.InsertCommand = Me.SqlInsertCommand3
        Me.SqlDataAdapter2.SelectCommand = Me.SqlSelectCommand3
        Me.SqlDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "SUBMUESTRA", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("SUB_CODIGO", "SUB_CODIGO"), New System.Data.Common.DataColumnMapping("SUB_DESCRIPCION", "SUB_DESCRIPCION"), New System.Data.Common.DataColumnMapping("TMU_CODIGO", "TMU_CODIGO")})})
        Me.SqlDataAdapter2.UpdateCommand = Me.SqlUpdateCommand3
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM SUBMUESTRA WHERE (SUB_CODIGO = @Original_SUB_CODIGO) AND (SUB_DESCRIP" & _
        "CION = @Original_SUB_DESCRIPCION OR @Original_SUB_DESCRIPCION IS NULL AND SUB_DE" & _
        "SCRIPCION IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU_CODIG" & _
        "O IS NULL AND TMU_CODIGO IS NULL)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO SUBMUESTRA(SUB_CODIGO, SUB_DESCRIPCION, TMU_CODIGO) VALUES (@SUB_CODI" & _
        "GO, @SUB_DESCRIPCION, @TMU_CODIGO); SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU_CODI" & _
        "GO FROM SUBMUESTRA WHERE (SUB_CODIGO = @SUB_CODIGO)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, "SUB_DESCRIPCION"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU_CODIGO FROM SUBMUESTRA"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE SUBMUESTRA SET SUB_CODIGO = @SUB_CODIGO, SUB_DESCRIPCION = @SUB_DESCRIPCIO" & _
        "N, TMU_CODIGO = @TMU_CODIGO WHERE (SUB_CODIGO = @Original_SUB_CODIGO) AND (SUB_D" & _
        "ESCRIPCION = @Original_SUB_DESCRIPCION OR @Original_SUB_DESCRIPCION IS NULL AND " & _
        "SUB_DESCRIPCION IS NULL) AND (TMU_CODIGO = @Original_TMU_CODIGO OR @Original_TMU" & _
        "_CODIGO IS NULL AND TMU_CODIGO IS NULL); SELECT SUB_CODIGO, SUB_DESCRIPCION, TMU" & _
        "_CODIGO FROM SUBMUESTRA WHERE (SUB_CODIGO = @SUB_CODIGO)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_CODIGO", System.Data.SqlDbType.Int, 4, "SUB_CODIGO"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, "SUB_DESCRIPCION"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@TMU_CODIGO", System.Data.SqlDbType.Int, 4, "TMU_CODIGO"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_SUB_DESCRIPCION", System.Data.SqlDbType.NVarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "SUB_DESCRIPCION", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_TMU_CODIGO", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "TMU_CODIGO", System.Data.DataRowVersion.Original, Nothing))
        '
        'Frm_Mantenedor
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(832, 808)
        Me.Controls.Add(Me.GrbAyuda)
        Me.Controls.Add(Me.TxtAyuda)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Mantenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenedor de Análisis"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGrid3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DataGrid4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.DataGrid5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        CType(Me.DataGrid9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DataGrid6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        CType(Me.DataGrid7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrbAyuda.ResumeLayout(False)
        CType(Me.Cjto_Mantenedor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Frm_Mantenedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim ulti_tab_loc As String
        MODIFICAR = "N"
        Select Case ultima_tabff
            Case "TabPage2"
                ulti_tab_loc = "TabPage1"
            Case "TabPage5"
                ulti_tab_loc = "TabPage2"
            Case "TabPage4"
                ulti_tab_loc = "TabPage3"
            Case "TabPage3"
                ulti_tab_loc = "TabPage4"
            Case "TabPage11"
                ulti_tab_loc = "TabPage5"
            Case "TabPage8"
                ulti_tab_loc = "TabPage6"
            Case "TabPage12"
                ulti_tab_loc = "TabPage7"
            Case "TabPage13"
                ulti_tab_loc = "TabPage8"

        End Select

        Adap_Analisis.Fill(Cjto_Mantenedor1, "ANALISIS")
        Me.SqlDataAdapter1.Fill(Me.Cjto_Mantenedor1, "MUESTRA")
        Me.SqlDataAdapter2.Fill(Me.Cjto_Mantenedor1, "SUBMUESTRA")
        Call TRASPASO_ANALISIS()
        Select Case ulti_tab_loc
            Case "TabPage1"
                TabControl1.SelectedTab = TabControl1.TabPages(0)
                DataGrid1.Focus()
            Case "TabPage2"
                TabControl1.SelectedTab = TabControl1.TabPages(1)
                DataGrid2.Focus()
            Case "TabPage3"
                TabControl1.SelectedTab = TabControl1.TabPages(2)
                DataGrid3.Focus()
            Case "TabPage4"
                TabControl1.SelectedTab = TabControl1.TabPages(3)
                DataGrid4.Focus()
            Case "TabPage5"
                TabControl1.SelectedTab = TabControl1.TabPages(4)
                DataGrid5.Focus()
            Case "TabPage8"
                TabControl1.SelectedTab = TabControl1.TabPages(7)
                DataGrid5.Focus()
            Case "TabPage6"
                TabControl1.SelectedTab = TabControl1.TabPages(5)
                DataGrid6.Focus()
            Case "TabPage7"
                TabControl1.SelectedTab = TabControl1.TabPages(6)
                DataGrid7.Focus()
        End Select
        Me.anti_elimina_lineas()
        AddCellFormattingColumnStyles(Me.DataGrid1, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid2, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid3, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid4, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid5, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid9, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid6, New FormatCellEventHandler(AddressOf FormatGridCells))
        AddCellFormattingColumnStyles(Me.DataGrid7, New FormatCellEventHandler(AddressOf FormatGridCells))
    End Sub
    Private Sub anti_elimina_lineas()
        Me.DataGrid1.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS")
        Me.DataGrid2.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS1")
        Me.DataGrid3.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS2")
        Me.DataGrid4.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS3")
        Me.DataGrid5.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS4")
        Me.DataGrid9.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS7")
        Me.DataGrid6.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS5")
        Me.DataGrid7.DataSource = Me.Cjto_Mantenedor1.Tables("ANALISIS6")

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

            If Me.Cjto_Mantenedor1.Tables("SUBMUESTRA").Rows.Contains(row("ANA_CODIGO")) Or Me.Cjto_Mantenedor1.Tables("MUESTRA").Rows.Contains(row("ANA_CODIGO")) Then
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
        Do While (j < 7)
            Dim cs As DataGridFormattableTextBoxColumn
            cs = New DataGridFormattableTextBoxColumn(j)
            cs.MappingName = grid.TableStyles(0).GridColumnStyles(j).MappingName
            cs.HeaderText = grid.TableStyles(0).GridColumnStyles(j).HeaderText
            cs.Width = grid.TableStyles(0).GridColumnStyles(j).Width
            cs.NullText = grid.TableStyles(0).GridColumnStyles(j).NullText
            cs.Alignment = grid.TableStyles(0).GridColumnStyles(j).Alignment
            cs.grid = grid
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
    Public Sub TRASPASO_ANALISIS()
        Dim FILA_COTIZA11, FILA_COTIZA1, FILA_COTIZA12, FILA_COTIZA13 As DataRow
        Dim FILA_COTIZA14, FILA_COTIZA15, FILA_COTIZA16 As DataRow
        Dim BOLA1 As Object
        For Each FILA_COTIZA1 In Cjto_Mantenedor1.Tables("ANALISIS").Rows
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 2 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS1").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS1").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 3 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS2").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS2").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 4 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS3").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS3").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 5 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS4").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS4").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 6 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS7").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS7").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 7 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS5").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS5").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
            If Val(Mid(FILA_COTIZA1.Item("ANA_CODIGO"), 1, 1)) = 8 Then
                FILA_COTIZA11 = Cjto_Mantenedor1.Tables("ANALISIS6").NewRow
                FILA_COTIZA11.BeginEdit()
                FILA_COTIZA11.Item("ANA_CODIGO") = FILA_COTIZA1.Item("ANA_CODIGO")
                FILA_COTIZA11.Item("ANA_ANALISIS") = FILA_COTIZA1.Item("ANA_ANALISIS")
                FILA_COTIZA11.Item("ANA_NETO") = FILA_COTIZA1.Item("ANA_NETO")
                FILA_COTIZA11.Item("ANA_NIVEL_PRECIO") = FILA_COTIZA1.Item("ANA_NIVEL_PRECIO")
                FILA_COTIZA11.Item("TIPO_COD") = FILA_COTIZA1.Item("TIPO_COD")
                FILA_COTIZA11.Item("TMU_CODIGO") = FILA_COTIZA1.Item("TMU_CODIGO")
                FILA_COTIZA11.Item("SUB_CODIGO") = FILA_COTIZA1.Item("SUB_CODIGO")
                FILA_COTIZA11.EndEdit()
                Cjto_Mantenedor1.Tables("ANALISIS6").Rows.Add(FILA_COTIZA11)
                'Cjto_Cotizacion1.Tables("COTIZA_ANALISIS1").Rows.Remove(FILA_COTIZA1)
            End If
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS1").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS2").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS3").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS4").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS7").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS5").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        For Each FILA_COTIZA11 In Cjto_Mantenedor1.Tables("ANALISIS6").Rows
            BOLA1 = FILA_COTIZA11("ANA_CODIGO")
            FILA_COTIZA1 = Cjto_Mantenedor1.Tables("ANALISIS").Rows.Find(BOLA1)
            Cjto_Mantenedor1.Tables("ANALISIS").Rows.Remove(FILA_COTIZA1)
        Next
        Cjto_Mantenedor1.Tables("ANALISIS").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS1").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS2").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS3").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS4").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS5").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS6").AcceptChanges()
        Cjto_Mantenedor1.Tables("ANALISIS7").AcceptChanges()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim mycell As New DataGridCell
        Dim fii As Integer
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage1"
                fii = DataGrid1.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid1.CurrentCell = mycell
            Case "TabPage2"
                fii = DataGrid2.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid2.CurrentCell = mycell
            Case "TabPage3"
                fii = DataGrid3.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid3.CurrentCell = mycell
            Case "TabPage4"
                fii = DataGrid4.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid4.CurrentCell = mycell
            Case "TabPage5"
                fii = DataGrid5.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid5.CurrentCell = mycell
            Case "TabPage8"
                fii = DataGrid9.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid9.CurrentCell = mycell
            Case "TabPage6"
                fii = DataGrid6.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid6.CurrentCell = mycell
            Case "TabPage7"
                fii = DataGrid7.CurrentCell.RowNumber.MaxValue
                mycell.ColumnNumber = 0
                mycell.RowNumber = fii
                DataGrid7.CurrentCell = mycell
        End Select
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim USU, MER As String
        Dim FILA_ESTADO, FILA_LISTA As DataRow
        MER = 0
        USU = System.Environment.UserName
        Call Graba_Todas("ANALISIS")
        Call Graba_Todas("ANALISIS1")
        Call Graba_Todas("ANALISIS2")
        Call Graba_Todas("ANALISIS3")
        Call Graba_Todas("ANALISIS4")
        Call Graba_Todas("ANALISIS5")
        Call Graba_Todas("ANALISIS6")
        Call Graba_Todas("ANALISIS7")
        Cjto_Mantenedor1.Tables("ANALISIS").Clear()
        Adap_Analisis.Fill(Cjto_Mantenedor1, "ANALISIS")
        Cjto_Mantenedor1.Tables("ANALISIS1").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS2").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS3").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS4").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS5").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS6").Clear()
        Cjto_Mantenedor1.Tables("ANALISIS7").Clear()
        Call TRASPASO_ANALISIS()
        MODIFICADOR = "S"
    End Sub
    Private Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim cll, fila, DALE As Integer
        Dim FILA_DATAROW, FILA_COMBO As DataRow
        Dim Cod_Ana As Double
        Dim respuesta As MsgBoxResult
        Select Case TabControl1.SelectedTab.Name
            Case "TabPage1"
                cll = DataGrid1.CurrentCell.ColumnNumber
                fila = DataGrid1.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage2"
                cll = DataGrid2.CurrentCell.ColumnNumber
                fila = DataGrid2.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS1").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS1", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage3"
                cll = DataGrid3.CurrentCell.ColumnNumber
                fila = DataGrid3.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS2").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS2", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage4"
                cll = DataGrid4.CurrentCell.ColumnNumber
                fila = DataGrid4.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS3").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS3", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage5"
                cll = DataGrid5.CurrentCell.ColumnNumber
                fila = DataGrid5.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS4").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS4", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage8"
                cll = DataGrid9.CurrentCell.ColumnNumber
                fila = DataGrid9.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS7").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS7", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage6"
                cll = DataGrid6.CurrentCell.ColumnNumber
                fila = DataGrid6.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS5").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS5", Cod_Ana, FILA_DATAROW)
                End If
            Case "TabPage7"
                cll = DataGrid7.CurrentCell.ColumnNumber
                fila = DataGrid7.CurrentCell.RowNumber
                FILA_DATAROW = Cjto_Mantenedor1.Tables("ANALISIS6").Rows(fila)
                Cod_Ana = FILA_DATAROW("ANA_CODIGO")
                respuesta = MsgBox("Esta seguro de eliminar codigo : " & Cod_Ana, MsgBoxStyle.YesNo)
                If respuesta = MsgBoxResult.Yes Then
                    Call elimina_fila_grilla("ANALISIS6", Cod_Ana, FILA_DATAROW)
                End If
        End Select
    End Sub
    Private Sub Frm_Mantenedor_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If MODIFICAR = "S" Then
            Select Case TabControl1.SelectedTab.Name
                Case "TabPage1"
                    DataGrid1.Focus()
                Case "TabPage2"
                    DataGrid2.Focus()
                Case "TabPage3"
                    DataGrid3.Focus()
                Case "TabPage4"
                    DataGrid4.Focus()
                Case "TabPage5"
                    DataGrid5.Focus()
                Case "TabPage8"
                    DataGrid9.Focus()
                Case "TabPage6"
                    DataGrid6.Focus()
                Case "TabPage7"
                    DataGrid7.Focus()
            End Select
        End If
    End Sub
    Private Sub Graba_Todas(ByVal a As String)
        Dim FILA_DATAROW, dr As DataRow
        Dim ana_codigo, ana_neto As Double
        Dim fila, tmu_codigo, sub_codigo As Integer
        Dim consulta_nota, consulta_nota2, ana_analisis, ana_original, ana_nivel_precio, cliente1, cliente2, cliente3, clientet, tipo_cod As String
        SqlConnection1.Open()
        For Each FILA_DATAROW In Cjto_Mantenedor1.Tables(a).Rows
            If FILA_DATAROW.RowState = DataRowState.Added Then
                ana_codigo = FILA_DATAROW("ANA_CODIGO")
                ana_analisis = FILA_DATAROW("ANA_ANALISIS")
                tmu_codigo = FILA_DATAROW("TMU_CODIGO")
                sub_codigo = FILA_DATAROW("SUB_CODIGO")
                ana_neto = FILA_DATAROW("ANA_NETO")
                ana_nivel_precio = FILA_DATAROW("ANA_NIVEL_PRECIO")
                cliente1 = ""
                cliente2 = ""
                cliente3 = ""
                clientet = "x"
                tipo_cod = FILA_DATAROW("TIPO_COD")
                consulta_nota = "INSERT INTO ANALISIS (ANA_CODIGO,ANA_ANALISIS,TMU_CODIGO,SUB_CODIGO,ANA_NETO,ANA_NIVEL_PRECIO,CLIENTE1,CLIENTE2,CLIENTE3,CLIENTET,TIPO_COD) VALUES (" & ana_codigo & "," & "'" & ana_analisis & "'" & "," & tmu_codigo & "," & sub_codigo & "," & ana_neto & "," & "'" & ana_nivel_precio & "'" & "," & "'" & cliente1 & "'" & "," & "'" & cliente2 & "'" & "," & "'" & cliente3 & "'" & "," & "'" & clientet & "'" & "," & "'" & tipo_cod & "'" & ")"
                Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        For Each FILA_DATAROW In Cjto_Mantenedor1.Tables(a).Rows
            If FILA_DATAROW.RowState = DataRowState.Modified Then
                ana_original = FILA_DATAROW("ANA_CODIGO", DataRowVersion.Original)
                ana_codigo = FILA_DATAROW("ANA_CODIGO")
                ana_analisis = FILA_DATAROW("ANA_ANALISIS")
                tmu_codigo = FILA_DATAROW("TMU_CODIGO")
                sub_codigo = FILA_DATAROW("SUB_CODIGO")
                ana_neto = Format(FILA_DATAROW("ANA_NETO"), "#####0")
                ana_nivel_precio = FILA_DATAROW("ANA_NIVEL_PRECIO")
                cliente1 = ""
                cliente2 = ""
                cliente3 = ""
                clientet = "x"
                tipo_cod = FILA_DATAROW("TIPO_COD")
                consulta_nota = "DELETE FROM ANALISIS WHERE ANA_CODIGO=" & ana_original
                consulta_nota2 = "INSERT INTO ANALISIS (ANA_CODIGO,ANA_ANALISIS,TMU_CODIGO,SUB_CODIGO,ANA_NETO,ANA_NIVEL_PRECIO,CLIENTE1,CLIENTE2,CLIENTE3,CLIENTET,TIPO_COD) VALUES (" & ana_codigo & "," & "'" & ana_analisis & "'" & "," & tmu_codigo & "," & sub_codigo & "," & ana_neto & "," & "'" & ana_nivel_precio & "'" & "," & "'" & cliente1 & "'" & "," & "'" & cliente2 & "'" & "," & "'" & cliente3 & "'" & "," & "'" & clientet & "'" & "," & "'" & tipo_cod & "'" & ")"
                Dim mycom As New SqlCommand(consulta_nota, SqlConnection1)
                If Me.SqlConnection1.State = ConnectionState.Closed Then
                    Me.SqlConnection1.Open()
                End If
                Try
                    mycom.ExecuteNonQuery()
                    mycom.CommandText = consulta_nota2
                    mycom.ExecuteNonQuery()
                    Me.SqlConnection1.Close()
                Catch ex As Exception

                End Try
            End If
        Next
        For Each FILA_DATAROW In Cjto_Mantenedor1.Tables(a).Rows
            If FILA_DATAROW.RowState = DataRowState.Deleted Then
                ana_codigo = FILA_DATAROW("ANA_CODIGO")
                consulta_nota = "DELETE FROM ANALISIS WHERE ANA_CODIGO=" & ana_codigo
                Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
                Dim myReader3 As SqlDataReader
                myReader3 = myCommand4.ExecuteReader()
                myReader3.Close()
            End If
        Next
        SqlConnection1.Close()
        Cjto_Mantenedor1.Tables(a).AcceptChanges()
    End Sub
    Private Sub elimina_fila_grilla(ByVal a As String, ByVal codana As Double, ByVal FILA_D As DataRow)
        Dim consulta_nota As String
        SqlConnection1.Open()
        consulta_nota = "DELETE FROM ANALISIS WHERE ANA_CODIGO=" & codana
        Dim myCommand3 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader2 As SqlDataReader
        myReader2 = myCommand3.ExecuteReader()
        myReader2.Close()
        SqlConnection1.Close()
        Cjto_Mantenedor1.Tables(a).Rows.Remove(FILA_D)

        SqlConnection1.Open()
        consulta_nota = "DELETE FROM COMBO_ANALISIS WHERE COB_CODIGO=" & codana
        Dim myCommand4 As New SqlCommand(consulta_nota, SqlConnection1)
        Dim myReader3 As SqlDataReader
        myReader3 = myCommand4.ExecuteReader()
        myReader3.Close()
        SqlConnection1.Close()
    End Sub
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim yll As String
        yll = TabControl1.SelectedTab.Name
        Select Case yll
            Case "TabPage1"
                DataGrid1.Focus()
            Case "TabPage2"
                DataGrid2.Focus()
            Case "TabPage3"
                DataGrid3.Focus()
            Case "TabPage4"
                DataGrid4.Focus()
            Case "TabPage5"
                DataGrid5.Focus()
            Case "TabPage8"
                DataGrid9.Focus()
            Case "TabPage6"
                DataGrid6.Focus()
            Case "TabPage7"
                DataGrid7.Focus()
        End Select
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        GroupBox3.Visible = True
        TextBox3.Focus()
        le = 0
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        GroupBox3.Visible = False
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim yll, texto, buscat As String
        Dim av, MyPos, filmax As Integer
        Dim FILA_DATAROW As DataRow
        Dim mycell As New DataGridCell
        yll = TabControl1.SelectedTab.Name
        texto = TextBox3.Text
        av = 0
        Select Case yll
            Case "TabPage1"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
                        mycell.RowNumber = av
                        DataGrid1.CurrentCell = mycell
                        DataGrid1.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage2"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS1").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
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
            Case "TabPage3"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS2").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
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
            Case "TabPage4"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS3").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
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
            Case "TabPage5"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS4").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
                        mycell.RowNumber = av
                        DataGrid5.CurrentCell = mycell
                        DataGrid5.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage8"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS7").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
                        mycell.RowNumber = av
                        DataGrid9.CurrentCell = mycell
                        DataGrid9.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage6"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS5").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
                        mycell.RowNumber = av
                        DataGrid6.CurrentCell = mycell
                        DataGrid6.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
            Case "TabPage7"
                For Each FILA_DATAROW In Cjto_Mantenedor1.Tables("ANALISIS6").Rows
                    buscat = UCase(FILA_DATAROW("ANA_ANALISIS"))
                    MyPos = InStr(buscat, UCase(texto))
                    If MyPos > 0 And av > le Then
                        mycell.ColumnNumber = 1
                        mycell.RowNumber = av
                        DataGrid7.CurrentCell = mycell
                        DataGrid7.Focus()
                        filmax = 1
                        Exit For
                    End If
                    av = av + 1
                Next
                If filmax = 0 Then MsgBox("Busqueda Finalizada")
                le = av
        End Select
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        GrbAyuda.Visible = False
    End Sub
    Private Sub TxtAyuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtAyuda.Click
        GrbAyuda.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub
End Class