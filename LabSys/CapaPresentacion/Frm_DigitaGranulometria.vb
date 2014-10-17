Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.Office.Interop

Public Class Frm_DigitaGranulometria
    Inherits System.Windows.Forms.Form
    Dim Fila_Lectura As Integer
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
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_Maza16 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza8 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza4 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza05 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza025 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza01 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza005 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Maza_Fondo As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Granulometria As System.Windows.Forms.DataGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_FechaPlanilla As System.Windows.Forms.DateTimePicker
    Friend WithEvents Bt_Carga As System.Windows.Forms.Button
    Friend WithEvents Txt_NLabHasta As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NLabDesde As System.Windows.Forms.TextBox
    Friend WithEvents Txt_NLabInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbx_Analista As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_FechaAnalisis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbx_Digitador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dtp_FechaDigitacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Dtg_Granulometria = New System.Windows.Forms.DataGrid
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
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Txt_Maza16 = New System.Windows.Forms.TextBox
        Me.Txt_Maza8 = New System.Windows.Forms.TextBox
        Me.Txt_Maza4 = New System.Windows.Forms.TextBox
        Me.Txt_Maza2 = New System.Windows.Forms.TextBox
        Me.Txt_Maza1 = New System.Windows.Forms.TextBox
        Me.Txt_Maza05 = New System.Windows.Forms.TextBox
        Me.Txt_Maza025 = New System.Windows.Forms.TextBox
        Me.Txt_Maza01 = New System.Windows.Forms.TextBox
        Me.Txt_Maza005 = New System.Windows.Forms.TextBox
        Me.Txt_Maza_Fondo = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Cbx_Analista = New System.Windows.Forms.ComboBox
        Me.Dtp_FechaAnalisis = New System.Windows.Forms.DateTimePicker
        Me.Cbx_Digitador = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Dtp_FechaDigitacion = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.Dtg_Granulometria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dtg_Granulometria
        '
        Me.Dtg_Granulometria.CaptionVisible = False
        Me.Dtg_Granulometria.DataMember = ""
        Me.Dtg_Granulometria.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Granulometria.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Granulometria.Location = New System.Drawing.Point(0, 24)
        Me.Dtg_Granulometria.Name = "Dtg_Granulometria"
        Me.Dtg_Granulometria.Size = New System.Drawing.Size(1229, 896)
        Me.Dtg_Granulometria.TabIndex = 10
        Me.Dtg_Granulometria.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.Dtg_Granulometria.Visible = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Granulometria
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "GRANULOMETRIA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N°Lab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 65
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "N°R"
        Me.DataGridTextBoxColumn2.MappingName = "INDICE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 25
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "16 mm"
        Me.DataGridTextBoxColumn3.MappingName = "MAZA_16"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "8 mm"
        Me.DataGridTextBoxColumn4.MappingName = "MAZA_8"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "4 mm"
        Me.DataGridTextBoxColumn5.MappingName = "MAZA_4"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 50
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "2 mm"
        Me.DataGridTextBoxColumn6.MappingName = "MAZA_2"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "1 mm"
        Me.DataGridTextBoxColumn7.MappingName = "MAZA_1"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 50
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "0,5 mm"
        Me.DataGridTextBoxColumn8.MappingName = "MAZA_05"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 50
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "0,25 mm"
        Me.DataGridTextBoxColumn9.MappingName = "MAZA_025"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 50
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "0,1 mm"
        Me.DataGridTextBoxColumn10.MappingName = "MAZA_01"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 50
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "0,05 mm"
        Me.DataGridTextBoxColumn11.MappingName = "MAZA_005"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 50
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "Fondo"
        Me.DataGridTextBoxColumn12.MappingName = "MAZA_FONDO"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 50
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Total"
        Me.DataGridTextBoxColumn13.MappingName = "MAZA_TOTAL"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 50
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "16 mm"
        Me.DataGridTextBoxColumn14.MappingName = "PORC_16"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 50
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "8 mm"
        Me.DataGridTextBoxColumn15.MappingName = "PORC_8"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 50
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "4 mm"
        Me.DataGridTextBoxColumn16.MappingName = "PORC_4"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 50
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "2 mm"
        Me.DataGridTextBoxColumn17.MappingName = "PORC_2"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 50
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "1 mm"
        Me.DataGridTextBoxColumn18.MappingName = "PORC_1"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 50
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "0,5 mm"
        Me.DataGridTextBoxColumn19.MappingName = "PORC_05"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 50
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "0,25"
        Me.DataGridTextBoxColumn20.MappingName = "PORC_025"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 50
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "0,1 mm"
        Me.DataGridTextBoxColumn21.MappingName = "PORC_01"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 50
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "0,05 mm"
        Me.DataGridTextBoxColumn22.MappingName = "PORC_005"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 50
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "Fondo"
        Me.DataGridTextBoxColumn23.MappingName = "PORC_FONDO"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 50
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "Total"
        Me.DataGridTextBoxColumn24.MappingName = "PORC_TOTAL"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 50
        '
        'Txt_Maza16
        '
        Me.Txt_Maza16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza16.Location = New System.Drawing.Point(312, 56)
        Me.Txt_Maza16.Name = "Txt_Maza16"
        Me.Txt_Maza16.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza16.TabIndex = 47
        Me.Txt_Maza16.Visible = False
        '
        'Txt_Maza8
        '
        Me.Txt_Maza8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza8.Location = New System.Drawing.Point(312, 88)
        Me.Txt_Maza8.Name = "Txt_Maza8"
        Me.Txt_Maza8.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza8.TabIndex = 48
        Me.Txt_Maza8.Visible = False
        '
        'Txt_Maza4
        '
        Me.Txt_Maza4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza4.Location = New System.Drawing.Point(312, 120)
        Me.Txt_Maza4.Name = "Txt_Maza4"
        Me.Txt_Maza4.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza4.TabIndex = 49
        Me.Txt_Maza4.Visible = False
        '
        'Txt_Maza2
        '
        Me.Txt_Maza2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza2.Location = New System.Drawing.Point(312, 152)
        Me.Txt_Maza2.Name = "Txt_Maza2"
        Me.Txt_Maza2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza2.TabIndex = 50
        Me.Txt_Maza2.Visible = False
        '
        'Txt_Maza1
        '
        Me.Txt_Maza1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza1.Location = New System.Drawing.Point(312, 184)
        Me.Txt_Maza1.Name = "Txt_Maza1"
        Me.Txt_Maza1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza1.TabIndex = 51
        Me.Txt_Maza1.Visible = False
        '
        'Txt_Maza05
        '
        Me.Txt_Maza05.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza05.Location = New System.Drawing.Point(312, 216)
        Me.Txt_Maza05.Name = "Txt_Maza05"
        Me.Txt_Maza05.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza05.TabIndex = 52
        Me.Txt_Maza05.Visible = False
        '
        'Txt_Maza025
        '
        Me.Txt_Maza025.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza025.Location = New System.Drawing.Point(312, 248)
        Me.Txt_Maza025.Name = "Txt_Maza025"
        Me.Txt_Maza025.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza025.TabIndex = 53
        Me.Txt_Maza025.Visible = False
        '
        'Txt_Maza01
        '
        Me.Txt_Maza01.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza01.Location = New System.Drawing.Point(312, 280)
        Me.Txt_Maza01.Name = "Txt_Maza01"
        Me.Txt_Maza01.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza01.TabIndex = 54
        Me.Txt_Maza01.Visible = False
        '
        'Txt_Maza005
        '
        Me.Txt_Maza005.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza005.Location = New System.Drawing.Point(312, 312)
        Me.Txt_Maza005.Name = "Txt_Maza005"
        Me.Txt_Maza005.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza005.TabIndex = 55
        Me.Txt_Maza005.Visible = False
        '
        'Txt_Maza_Fondo
        '
        Me.Txt_Maza_Fondo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Maza_Fondo.Location = New System.Drawing.Point(312, 344)
        Me.Txt_Maza_Fondo.Name = "Txt_Maza_Fondo"
        Me.Txt_Maza_Fondo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Maza_Fondo.TabIndex = 56
        Me.Txt_Maza_Fondo.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(128, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(504, 23)
        Me.Label9.TabIndex = 67
        Me.Label9.Text = "Maza en cada tamiz (g)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(632, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(504, 23)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Porcentaje partículas en cada tamiz (%)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Salir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Bt_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Salir.Location = New System.Drawing.Point(1176, 944)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 71
        Me.Bt_Salir.Text = "Salir"
        Me.Bt_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Salir.UseVisualStyleBackColor = False
        '
        'Bt_Imprime
        '
        Me.Bt_Imprime.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Imprime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imprime.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Bt_Imprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Imprime.Location = New System.Drawing.Point(984, 944)
        Me.Bt_Imprime.Name = "Bt_Imprime"
        Me.Bt_Imprime.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Imprime.TabIndex = 70
        Me.Bt_Imprime.Text = "Imprimir"
        Me.Bt_Imprime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Imprime.UseVisualStyleBackColor = False
        '
        'Bt_Graba
        '
        Me.Bt_Graba.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Graba.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Graba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Graba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Graba.Location = New System.Drawing.Point(888, 944)
        Me.Bt_Graba.Name = "Bt_Graba"
        Me.Bt_Graba.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Graba.TabIndex = 69
        Me.Bt_Graba.Text = "Grabar"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Dtp_FechaPlanilla)
        Me.GroupBox2.Controls.Add(Me.Bt_Carga)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabHasta)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabDesde)
        Me.GroupBox2.Controls.Add(Me.Txt_NLabInicial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 192)
        Me.GroupBox2.TabIndex = 73
        Me.GroupBox2.TabStop = False
        '
        'Dtp_FechaPlanilla
        '
        Me.Dtp_FechaPlanilla.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaPlanilla.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaPlanilla.Location = New System.Drawing.Point(144, 56)
        Me.Dtp_FechaPlanilla.Name = "Dtp_FechaPlanilla"
        Me.Dtp_FechaPlanilla.Size = New System.Drawing.Size(88, 20)
        Me.Dtp_FechaPlanilla.TabIndex = 10
        '
        'Bt_Carga
        '
        Me.Bt_Carga.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Carga.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Carga.Image = Global.LabSys.My.Resources.Resources.server_database
        Me.Bt_Carga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Carga.Location = New System.Drawing.Point(144, 160)
        Me.Bt_Carga.Name = "Bt_Carga"
        Me.Bt_Carga.Size = New System.Drawing.Size(75, 26)
        Me.Bt_Carga.TabIndex = 9
        Me.Bt_Carga.Text = "Carga"
        Me.Bt_Carga.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Carga.UseVisualStyleBackColor = False
        '
        'Txt_NLabHasta
        '
        Me.Txt_NLabHasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabHasta.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabHasta.Location = New System.Drawing.Point(144, 120)
        Me.Txt_NLabHasta.Name = "Txt_NLabHasta"
        Me.Txt_NLabHasta.Size = New System.Drawing.Size(56, 20)
        Me.Txt_NLabHasta.TabIndex = 7
        '
        'Txt_NLabDesde
        '
        Me.Txt_NLabDesde.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabDesde.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabDesde.Location = New System.Drawing.Point(144, 88)
        Me.Txt_NLabDesde.Name = "Txt_NLabDesde"
        Me.Txt_NLabDesde.Size = New System.Drawing.Size(56, 20)
        Me.Txt_NLabDesde.TabIndex = 6
        '
        'Txt_NLabInicial
        '
        Me.Txt_NLabInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_NLabInicial.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NLabInicial.Location = New System.Drawing.Point(144, 24)
        Me.Txt_NLabInicial.Name = "Txt_NLabInicial"
        Me.Txt_NLabInicial.Size = New System.Drawing.Size(56, 20)
        Me.Txt_NLabInicial.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nº Lab.Hasta"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nº Lab.Desde"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha Planilla"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nº Lab.Inicial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbx_Analista)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaAnalisis)
        Me.GroupBox1.Controls.Add(Me.Cbx_Digitador)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaDigitacion)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 152)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Cbx_Analista
        '
        Me.Cbx_Analista.Location = New System.Drawing.Point(144, 120)
        Me.Cbx_Analista.Name = "Cbx_Analista"
        Me.Cbx_Analista.Size = New System.Drawing.Size(122, 21)
        Me.Cbx_Analista.TabIndex = 9
        '
        'Dtp_FechaAnalisis
        '
        Me.Dtp_FechaAnalisis.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaAnalisis.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaAnalisis.Location = New System.Drawing.Point(144, 56)
        Me.Dtp_FechaAnalisis.Name = "Dtp_FechaAnalisis"
        Me.Dtp_FechaAnalisis.Size = New System.Drawing.Size(88, 20)
        Me.Dtp_FechaAnalisis.TabIndex = 8
        '
        'Cbx_Digitador
        '
        Me.Cbx_Digitador.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cbx_Digitador.Location = New System.Drawing.Point(144, 88)
        Me.Cbx_Digitador.Name = "Cbx_Digitador"
        Me.Cbx_Digitador.Size = New System.Drawing.Size(122, 22)
        Me.Cbx_Digitador.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Análista"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Análisis"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digitador"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Digitación"
        '
        'Dtp_FechaDigitacion
        '
        Me.Dtp_FechaDigitacion.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_FechaDigitacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_FechaDigitacion.Location = New System.Drawing.Point(144, 24)
        Me.Dtp_FechaDigitacion.Name = "Dtp_FechaDigitacion"
        Me.Dtp_FechaDigitacion.Size = New System.Drawing.Size(88, 20)
        Me.Dtp_FechaDigitacion.TabIndex = 100
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1080, 944)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_DigitaGranulometria
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_Maza_Fondo)
        Me.Controls.Add(Me.Txt_Maza005)
        Me.Controls.Add(Me.Txt_Maza01)
        Me.Controls.Add(Me.Txt_Maza025)
        Me.Controls.Add(Me.Txt_Maza05)
        Me.Controls.Add(Me.Txt_Maza1)
        Me.Controls.Add(Me.Txt_Maza2)
        Me.Controls.Add(Me.Txt_Maza4)
        Me.Controls.Add(Me.Txt_Maza8)
        Me.Controls.Add(Me.Txt_Maza16)
        Me.Controls.Add(Me.Dtg_Granulometria)
        Me.Name = "Frm_DigitaGranulometria"
        Me.Text = "Digita Granulometria"
        CType(Me.Dtg_Granulometria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Dtg_Granulometria_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Granulometria.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_Granulometria.CurrentCell.RowNumber()
        Revision_Digitacion = "N"


        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza16.Left = Posicionx
            Txt_Maza16.Top = Posiciony
            Txt_Maza16.Height = CeldaAlto
            Txt_Maza16.Width = CeldaAncho
            Txt_Maza16.Visible = True
            Txt_Maza16.Text = ""
            Txt_Maza16.Enabled = True
            Txt_Maza16.TabIndex = 47
            Txt_Maza16.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza8.Left = Posicionx
            Txt_Maza8.Top = Posiciony
            Txt_Maza8.Height = CeldaAlto
            Txt_Maza8.Width = CeldaAncho
            Txt_Maza8.Visible = True
            Txt_Maza8.Text = ""
            Txt_Maza8.Enabled = True
            Txt_Maza8.TabIndex = 48
            Txt_Maza8.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza4.Left = Posicionx
            Txt_Maza4.Top = Posiciony
            Txt_Maza4.Height = CeldaAlto
            Txt_Maza4.Width = CeldaAncho
            Txt_Maza4.Visible = True
            Txt_Maza4.Text = ""
            Txt_Maza4.Enabled = True
            Txt_Maza4.TabIndex = 49
            Txt_Maza4.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza2.Left = Posicionx
            Txt_Maza2.Top = Posiciony
            Txt_Maza2.Height = CeldaAlto
            Txt_Maza2.Width = CeldaAncho
            Txt_Maza2.Visible = True
            Txt_Maza2.Text = ""
            Txt_Maza2.Enabled = True
            Txt_Maza2.TabIndex = 50
            Txt_Maza2.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 6 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza1.Left = Posicionx
            Txt_Maza1.Top = Posiciony
            Txt_Maza1.Height = CeldaAlto
            Txt_Maza1.Width = CeldaAncho
            Txt_Maza1.Visible = True
            Txt_Maza1.Text = ""
            Txt_Maza1.Enabled = True
            Txt_Maza1.TabIndex = 51
            Txt_Maza1.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 7 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza05.Left = Posicionx
            Txt_Maza05.Top = Posiciony
            Txt_Maza05.Height = CeldaAlto
            Txt_Maza05.Width = CeldaAncho
            Txt_Maza05.Visible = True
            Txt_Maza05.Text = ""
            Txt_Maza05.Enabled = True
            Txt_Maza05.TabIndex = 52
            Txt_Maza05.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 8 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza025.Left = Posicionx
            Txt_Maza025.Top = Posiciony
            Txt_Maza025.Height = CeldaAlto
            Txt_Maza025.Width = CeldaAncho
            Txt_Maza025.Visible = True
            Txt_Maza025.Text = ""
            Txt_Maza025.Enabled = True
            Txt_Maza025.TabIndex = 53
            Txt_Maza025.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 9 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza01.Left = Posicionx
            Txt_Maza01.Top = Posiciony
            Txt_Maza01.Height = CeldaAlto
            Txt_Maza01.Width = CeldaAncho
            Txt_Maza01.Visible = True
            Txt_Maza01.Text = ""
            Txt_Maza01.Enabled = True
            Txt_Maza01.TabIndex = 54
            Txt_Maza01.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 10 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza005.Left = Posicionx
            Txt_Maza005.Top = Posiciony
            Txt_Maza005.Height = CeldaAlto
            Txt_Maza005.Width = CeldaAncho
            Txt_Maza005.Visible = True
            Txt_Maza005.Text = ""
            Txt_Maza005.Enabled = True
            Txt_Maza005.TabIndex = 55
            Txt_Maza005.Focus()
        End If

        If Dtg_Granulometria.CurrentCell.ColumnNumber = 11 Then
            Dim CeldaAlto As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).X + Dtg_Granulometria.Left
            Dim Posiciony As Integer = Dtg_Granulometria.GetCellBounds(Dtg_Granulometria.CurrentCell.RowNumber, Dtg_Granulometria.CurrentCell.ColumnNumber).Y + Dtg_Granulometria.Top
            Txt_Maza_Fondo.Left = Posicionx
            Txt_Maza_Fondo.Top = Posiciony
            Txt_Maza_Fondo.Height = CeldaAlto
            Txt_Maza_Fondo.Width = CeldaAncho
            Txt_Maza_Fondo.Visible = True
            Txt_Maza_Fondo.Text = ""
            Txt_Maza_Fondo.Enabled = True
            Txt_Maza_Fondo.TabIndex = 56
            Txt_Maza_Fondo.Focus()
        End If
    End Sub
#Region "Texbox Grilla"
    Private Sub Txt_Maza_Fondo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza_Fondo.KeyPress
        Dim Porc16, Porc8, Porc4, Porc2, Porc1, Porc05, Porc025, Porc01, Porc005, PorcFondo, PorcTotal, TotalMasa As Double
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza_Fondo.Text = "" Then
                Txt_Maza_Fondo.Text = 0
            End If
            Txt_Maza_Fondo.Text = Txt_Maza_Fondo.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 11) = Txt_Maza_Fondo.Text
            Call Granulometria(Dtg_Granulometria(Fila_Lectura, 2), Dtg_Granulometria(Fila_Lectura, 3), Dtg_Granulometria(Fila_Lectura, 4), Dtg_Granulometria(Fila_Lectura, 5), Dtg_Granulometria(Fila_Lectura, 6), Dtg_Granulometria(Fila_Lectura, 7), Dtg_Granulometria(Fila_Lectura, 8), Dtg_Granulometria(Fila_Lectura, 9), Dtg_Granulometria(Fila_Lectura, 10), Dtg_Granulometria(Fila_Lectura, 11), TotalMasa, Porc16, Porc8, Porc4, Porc2, Porc1, Porc05, Porc025, Porc01, Porc005, PorcFondo, PorcTotal)
            Dtg_Granulometria(Fila_Lectura, 12) = Round(TotalMasa, 1)
            Dtg_Granulometria(Fila_Lectura, 13) = Round(Porc16, 0)
            Dtg_Granulometria(Fila_Lectura, 14) = Round(Porc8, 0)
            Dtg_Granulometria(Fila_Lectura, 15) = Round(Porc4, 0)
            Dtg_Granulometria(Fila_Lectura, 16) = Round(Porc2, 0)
            Dtg_Granulometria(Fila_Lectura, 17) = Round(Porc1, 0)
            Dtg_Granulometria(Fila_Lectura, 18) = Round(Porc05, 0)
            Dtg_Granulometria(Fila_Lectura, 19) = Round(Porc025, 0)
            Dtg_Granulometria(Fila_Lectura, 20) = Round(Porc01, 0)
            Dtg_Granulometria(Fila_Lectura, 21) = Round(Porc005, 0)
            Dtg_Granulometria(Fila_Lectura, 22) = Round(PorcFondo, 0)
            Dtg_Granulometria(Fila_Lectura, 23) = Round(PorcTotal, 0)
            mycell.ColumnNumber = 2
            mycell.RowNumber = Fila_Lectura + 1
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza16.Focus()
            Txt_Maza_Fondo.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza16_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza16.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza16.Text = "" Then Txt_Maza16.Text = 0
            Txt_Maza16.Text = Txt_Maza16.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 2) = Txt_Maza16.Text
            mycell.ColumnNumber = 3
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza8.Focus()
            Txt_Maza16.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza8_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza8.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza8.Text = "" Then Txt_Maza8.Text = 0
            Txt_Maza8.Text = Txt_Maza8.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 3) = Txt_Maza8.Text
            mycell.ColumnNumber = 4
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza4.Focus()
            Txt_Maza8.Visible = False
        End If
    End Sub


    Private Sub Txt_Maza4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza4.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza4.Text = "" Then Txt_Maza4.Text = 0
            Txt_Maza4.Text = Txt_Maza4.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 4) = Txt_Maza4.Text
            mycell.ColumnNumber = 5
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza2.Focus()
            Txt_Maza4.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza2.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza2.Text = "" Then Txt_Maza2.Text = 0
            Txt_Maza2.Text = Txt_Maza2.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 5) = Txt_Maza2.Text
            mycell.ColumnNumber = 6
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza1.Focus()
            Txt_Maza2.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza1.Text = "" Then Txt_Maza1.Text = 0
            Txt_Maza1.Text = Txt_Maza1.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 6) = Txt_Maza1.Text
            mycell.ColumnNumber = 7
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza05.Focus()
            Txt_Maza1.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza05_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza05.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza05.Text = "" Then Txt_Maza05.Text = 0
            Txt_Maza05.Text = Txt_Maza05.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 7) = Txt_Maza05.Text
            mycell.ColumnNumber = 8
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza025.Focus()
            Txt_Maza05.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza025_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza025.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza025.Text = "" Then Txt_Maza025.Text = 0
            Txt_Maza025.Text = Txt_Maza025.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 8) = Txt_Maza025.Text
            mycell.ColumnNumber = 9
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza01.Focus()
            Txt_Maza025.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza01_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza01.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza01.Text = "" Then Txt_Maza01.Text = 0
            Txt_Maza01.Text = Txt_Maza01.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 9) = Txt_Maza01.Text
            mycell.ColumnNumber = 10
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza005.Focus()
            Txt_Maza01.Visible = False
        End If
    End Sub

    Private Sub Txt_Maza005_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Maza005.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_Maza005.Text = "" Then Txt_Maza005.Text = 0
            Txt_Maza005.Text = Txt_Maza005.Text.Replace(".", ",")
            Dtg_Granulometria(Fila_Lectura, 10) = Txt_Maza005.Text
            mycell.ColumnNumber = 11
            mycell.RowNumber = Fila_Lectura
            Dtg_Granulometria.CurrentCell = mycell
            Me.Txt_Maza_Fondo.Focus()
            Txt_Maza005.Visible = False
        End If
    End Sub

#End Region

    Private Sub Bt_Carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos, query2 As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim i, cont, n As Integer

        Dim SqlConn As New SqlConnection
        Dim Con1 As New SqlConnection
        Dim Command As SqlCommand
        SqlConn = New SqlConnection(Conexion1)
        Son_Blancos = "S"
        cont = 0
        Cjto_Tablas1.Tables("GRANULOMETRIA").Clear()
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
        Dim myCommand As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader As SqlDataReader = myCommand.ExecuteReader()
        While myReader.Read()

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                'EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 4000)
            End If

            If Carga_Digitacion = "S" Then
                For i = 1 To 2
                    If i = 1 Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("GRANULOMETRIA").NewRow
                        Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                        cont = cont + 1
                        Fila_Digitacion("INDICE") = cont

                        Cjto_Tablas1.Tables("GRANULOMETRIA").Rows.Add(Fila_Digitacion)
                    Else
                        Fila_Digitacion = Cjto_Tablas1.Tables("GRANULOMETRIA").NewRow
                        cont = cont + 1
                        Fila_Digitacion("INDICE") = cont
                        Cjto_Tablas1.Tables("GRANULOMETRIA").Rows.Add(Fila_Digitacion)
                    End If
                Next
            End If
SaltoxIngresoDup:
        End While
        myReader.Close()
        SqlConn.Close()

        Label10.Visible = True
        Label9.Visible = True
        Dtg_Granulometria.Visible = True
        GroupBox1.Visible = False
        GroupBox2.Visible = False
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt_Imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprime.Click
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim Destino As String = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2008\040  DIGITACION Y CALCULO RESULTADOS\Formato Base\Formato Resultado Granulometria.xls"
        Dim Destino2 As String = "F:\Mis documentos\Graba Planillas\Suelo\" & Nombre & " " & Txt_NLabInicial.Text & ".xls"
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

        Call EncavezadoPagGranulometria(Dtp_FechaDigitacion.Text, Dtp_FechaAnalisis.Text, objHojaExcel)
        Call Imprime_PiePagGranulometria(objHojaExcel, Cbx_Analista.Text, Cbx_Digitador.Text)
        Call Encavezado_Granulometria(objHojaExcel)
        Call Encavezado_ResultadoGranulometria(objHojaExcel, Fila_Exp + 5)
        Call Imprime_Resultado_Granulometria(objHojaExcel, Fila_Exp + 1)
    End Sub

    Private Sub Anti_Elimina_Lineas()
        Dtg_Granulometria.DataSource = Cjto_Tablas1.Tables("GRANULOMETRIA")
    End Sub

    Private Sub Frm_DigitaGranulometria_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim i As Integer
        Dim DatoPaso As String
        Try
            For i = 0 To Fila_Lectura
                With SP
                    If IsDBNull(Dtg_Granulometria(i, 0)) = False Then
                        DatoPaso = Dtg_Granulometria(i, 0)
                    End If
                    .Inicializar()
                    .AgregarParametro("@NumLab", DatoPaso, SqlDbType.NVarChar)
                    .AgregarParametro("@Indice", Dtg_Granulometria(i, 1), SqlDbType.Int)
                    .AgregarParametro("@Maza16", CDbl(Dtg_Granulometria(i, 2)), SqlDbType.Float)
                    .AgregarParametro("@Maza8", CDbl(Dtg_Granulometria(i, 3)), SqlDbType.Float)
                    .AgregarParametro("@Maza4", CDbl(Dtg_Granulometria(i, 4)), SqlDbType.Float)
                    .AgregarParametro("@Maza2", CDbl(Dtg_Granulometria(i, 5)), SqlDbType.Float)
                    .AgregarParametro("@Maza1", CDbl(Dtg_Granulometria(i, 6)), SqlDbType.Float)
                    .AgregarParametro("@Maza05", CDbl(Dtg_Granulometria(i, 7)), SqlDbType.Float)
                    .AgregarParametro("@Maza025", CDbl(Dtg_Granulometria(i, 8)), SqlDbType.Float)
                    .AgregarParametro("@Maza01", CDbl(Dtg_Granulometria(i, 9)), SqlDbType.Float)
                    .AgregarParametro("@Maza005", CDbl(Dtg_Granulometria(i, 10)), SqlDbType.Float)
                    .AgregarParametro("@MazaFondo", CDbl(Dtg_Granulometria(i, 11)), SqlDbType.Float)
                    .AgregarParametro("@MazaTotal", CDbl(Dtg_Granulometria(i, 12)), SqlDbType.Float)
                    .AgregarParametro("@Porc16", CDbl(Dtg_Granulometria(i, 13)), SqlDbType.Float)
                    .AgregarParametro("@Porc8", CDbl(Dtg_Granulometria(i, 14)), SqlDbType.Float)
                    .AgregarParametro("@Porc4", CDbl(Dtg_Granulometria(i, 15)), SqlDbType.Float)
                    .AgregarParametro("@Porc2", CDbl(Dtg_Granulometria(i, 16)), SqlDbType.Float)
                    .AgregarParametro("@Porc1", CDbl(Dtg_Granulometria(i, 17)), SqlDbType.Float)
                    .AgregarParametro("@Porc05", CDbl(Dtg_Granulometria(i, 18)), SqlDbType.Float)
                    .AgregarParametro("@Porc025", CDbl(Dtg_Granulometria(i, 19)), SqlDbType.Float)
                    .AgregarParametro("@Porc01", CDbl(Dtg_Granulometria(i, 20)), SqlDbType.Float)
                    .AgregarParametro("@Porc005", CDbl(Dtg_Granulometria(i, 21)), SqlDbType.Float)
                    .AgregarParametro("@PorcFondo", CDbl(Dtg_Granulometria(i, 22)), SqlDbType.Float)
                    .AgregarParametro("@PorcTotal", CDbl(Dtg_Granulometria(i, 23)), SqlDbType.Float)
                    .EjecutarEscalar("usp_GrabaGranulometria")

                End With

                With SP
                    .Inicializar()
                    .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Num_lab", CInt(DatoPaso), SqlDbType.Int)
                    .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                    .EjecutarEscalar("usp_Update_DigitaResultados")
                End With
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Grabación Finalizada")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cjto_Tablas1.Tables("GRANULOMETRIA").Clear()
        Txt_NLabInicial.ResetText()
    End Sub


    Private Sub Bt_Carga_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click

    End Sub
End Class

