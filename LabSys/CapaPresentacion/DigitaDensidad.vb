Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.Office.Interop

Public Class DigitaDensidad
    Inherits System.Windows.Forms.Form
    Dim Fila_Lectura, Fila_M As Integer
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_DenPseco As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DenPhumedo As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DenPparaf As System.Windows.Forms.TextBox
    Friend WithEvents Txt_DenPagua As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_Densidad As System.Windows.Forms.DataGrid
    Friend WithEvents Txt_DenObs As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
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
        Me.Dtg_Densidad = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Txt_DenPseco = New System.Windows.Forms.TextBox
        Me.Txt_DenPhumedo = New System.Windows.Forms.TextBox
        Me.Txt_DenPparaf = New System.Windows.Forms.TextBox
        Me.Txt_DenPagua = New System.Windows.Forms.TextBox
        Me.Txt_DenObs = New System.Windows.Forms.TextBox
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_Densidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(0, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(304, 192)
        Me.GroupBox2.TabIndex = 5
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
        Me.Label8.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label8.Location = New System.Drawing.Point(8, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Nº Lab.Hasta"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label7.Location = New System.Drawing.Point(8, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Nº Lab.Desde"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label6.Location = New System.Drawing.Point(8, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Fecha Planilla"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Nº Lab.Inicial"
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
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 152)
        Me.GroupBox1.TabIndex = 4
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
        Me.Label4.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Análista"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha Análisis"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digitador"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
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
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "N°t"
        Me.DataGridTextBoxColumn2.MappingName = "INDICE"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 25
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Seco"
        Me.DataGridTextBoxColumn3.MappingName = "PESO_SECO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Húmedo"
        Me.DataGridTextBoxColumn4.MappingName = "PESO_HUME"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "+Parafa"
        Me.DataGridTextBoxColumn6.MappingName = "PESO_EMP"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "en agua"
        Me.DataGridTextBoxColumn7.MappingName = "PESO_EMP_AGUA"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "terrón"
        Me.DataGridTextBoxColumn8.MappingName = "DENSIDAD_APA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 65
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "prom"
        Me.DataGridTextBoxColumn9.MappingName = "PROMEDIO"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 65
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Obs"
        Me.DataGridTextBoxColumn10.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = -1
        '
        'Dtg_Densidad
        '
        Me.Dtg_Densidad.CaptionVisible = False
        Me.Dtg_Densidad.DataMember = ""
        Me.Dtg_Densidad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_Densidad.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_Densidad.Location = New System.Drawing.Point(304, 8)
        Me.Dtg_Densidad.Name = "Dtg_Densidad"
        Me.Dtg_Densidad.Size = New System.Drawing.Size(672, 920)
        Me.Dtg_Densidad.TabIndex = 41
        Me.Dtg_Densidad.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_Densidad
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn19})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "DENSIDAD"
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "N°Lab"
        Me.DataGridTextBoxColumn11.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 65
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "N°t"
        Me.DataGridTextBoxColumn12.MappingName = "INDICE"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 25
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Seco"
        Me.DataGridTextBoxColumn13.MappingName = "PESO_SECO"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Húmedo"
        Me.DataGridTextBoxColumn14.MappingName = "PESO_HUME"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "+Parafa"
        Me.DataGridTextBoxColumn15.MappingName = "PESO_EMP"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "en agua"
        Me.DataGridTextBoxColumn16.MappingName = "PESO_EMP_AGUA"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "terrón"
        Me.DataGridTextBoxColumn17.MappingName = "DENSIDAD_APA"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "Obs"
        Me.DataGridTextBoxColumn19.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 168
        '
        'Txt_DenPseco
        '
        Me.Txt_DenPseco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DenPseco.Location = New System.Drawing.Point(360, 184)
        Me.Txt_DenPseco.Name = "Txt_DenPseco"
        Me.Txt_DenPseco.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DenPseco.TabIndex = 42
        Me.Txt_DenPseco.Visible = False
        '
        'Txt_DenPhumedo
        '
        Me.Txt_DenPhumedo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DenPhumedo.Location = New System.Drawing.Point(360, 256)
        Me.Txt_DenPhumedo.Name = "Txt_DenPhumedo"
        Me.Txt_DenPhumedo.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DenPhumedo.TabIndex = 43
        Me.Txt_DenPhumedo.Visible = False
        '
        'Txt_DenPparaf
        '
        Me.Txt_DenPparaf.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DenPparaf.Location = New System.Drawing.Point(360, 224)
        Me.Txt_DenPparaf.Name = "Txt_DenPparaf"
        Me.Txt_DenPparaf.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DenPparaf.TabIndex = 44
        Me.Txt_DenPparaf.Visible = False
        '
        'Txt_DenPagua
        '
        Me.Txt_DenPagua.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DenPagua.Location = New System.Drawing.Point(360, 144)
        Me.Txt_DenPagua.Name = "Txt_DenPagua"
        Me.Txt_DenPagua.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DenPagua.TabIndex = 45
        Me.Txt_DenPagua.Visible = False
        '
        'Txt_DenObs
        '
        Me.Txt_DenObs.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DenObs.Location = New System.Drawing.Point(352, 304)
        Me.Txt_DenObs.Name = "Txt_DenObs"
        Me.Txt_DenObs.Size = New System.Drawing.Size(100, 20)
        Me.Txt_DenObs.TabIndex = 46
        Me.Txt_DenObs.Visible = False
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Salir.Image = Global.LabSys.My.Resources.Resources.cross
        Me.Bt_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Salir.Location = New System.Drawing.Point(1176, 944)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 40
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
        Me.Bt_Imprime.TabIndex = 39
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
        Me.Bt_Graba.TabIndex = 38
        Me.Bt_Graba.Text = "Grabar"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1081, 944)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DigitaDensidad
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt_DenObs)
        Me.Controls.Add(Me.Txt_DenPagua)
        Me.Controls.Add(Me.Txt_DenPparaf)
        Me.Controls.Add(Me.Txt_DenPhumedo)
        Me.Controls.Add(Me.Txt_DenPseco)
        Me.Controls.Add(Me.Dtg_Densidad)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "DigitaDensidad"
        Me.Text = "Digita Densidad"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dtg_Densidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Private Sub Dtg_Densidad_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_Densidad.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_Densidad.CurrentCell.RowNumber()
        Revision_Digitacion = "N"


        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.

        If Dtg_Densidad.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"



        If Dtg_Densidad.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).X + Dtg_Densidad.Left
            Dim Posiciony As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Y + Dtg_Densidad.Top
            Txt_DenPseco.Left = Posicionx
            Txt_DenPseco.Top = Posiciony
            Txt_DenPseco.Height = CeldaAlto
            Txt_DenPseco.Width = CeldaAncho
            Txt_DenPseco.Visible = True
            Txt_DenPseco.Text = ""
            Txt_DenPseco.Enabled = True
            Txt_DenPseco.TabIndex = 42
            Txt_DenPseco.Focus()
        End If

        If Dtg_Densidad.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).X + Dtg_Densidad.Left
            Dim Posiciony As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Y + Dtg_Densidad.Top
            Txt_DenPhumedo.Left = Posicionx
            Txt_DenPhumedo.Top = Posiciony
            Txt_DenPhumedo.Height = CeldaAlto
            Txt_DenPhumedo.Width = CeldaAncho
            Txt_DenPhumedo.Visible = True
            Txt_DenPhumedo.Text = ""
            Txt_DenPhumedo.Enabled = True
            Txt_DenPhumedo.TabIndex = 43
            Txt_DenPhumedo.Focus()
        End If

        If Dtg_Densidad.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).X + Dtg_Densidad.Left
            Dim Posiciony As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Y + Dtg_Densidad.Top
            Txt_DenPparaf.Left = Posicionx
            Txt_DenPparaf.Top = Posiciony
            Txt_DenPparaf.Height = CeldaAlto
            Txt_DenPparaf.Width = CeldaAncho
            Txt_DenPparaf.Visible = True
            Txt_DenPparaf.Text = ""
            Txt_DenPparaf.Enabled = True
            Txt_DenPparaf.TabIndex = 44
            Txt_DenPparaf.Focus()
        End If

        If Dtg_Densidad.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).X + Dtg_Densidad.Left
            Dim Posiciony As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Y + Dtg_Densidad.Top
            Txt_DenPagua.Left = Posicionx
            Txt_DenPagua.Top = Posiciony
            Txt_DenPagua.Height = CeldaAlto
            Txt_DenPagua.Width = CeldaAncho
            Txt_DenPagua.Visible = True
            Txt_DenPagua.Text = ""
            Txt_DenPagua.Enabled = True
            Txt_DenPagua.TabIndex = 45
            Txt_DenPagua.Focus()
        End If

        If Dtg_Densidad.CurrentCell.ColumnNumber = 8 Then
            Dim CeldaAlto As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).X + Dtg_Densidad.Left
            Dim Posiciony As Integer = Dtg_Densidad.GetCellBounds(Dtg_Densidad.CurrentCell.RowNumber, Dtg_Densidad.CurrentCell.ColumnNumber).Y + Dtg_Densidad.Top
            Txt_DenObs.Left = Posicionx
            Txt_DenObs.Top = Posiciony
            Txt_DenObs.Height = CeldaAlto
            Txt_DenObs.Width = CeldaAncho
            Txt_DenObs.Visible = True
            Txt_DenObs.Text = ""
            Txt_DenObs.Enabled = True
            Txt_DenObs.TabIndex = 46
            Txt_DenObs.Focus()
        End If
    End Sub

    Private Sub Bt_Carga_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos, query2 As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer
        Dim i As Integer

        Dim SqlConn As New SqlConnection
        Dim Con1 As New SqlConnection
        Dim Command As SqlCommand
        SqlConn = New SqlConnection(Conexion1)
        Son_Blancos = "S"

        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then

            Cjto_Tablas1.Tables("DENSIDAD").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Carga_Digitacion = "N"

                If CInt(myReader.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"


                If Mypos = 0 Then
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 4000)
                End If
                If Carga_Digitacion = "S" And EstaRevisado = 0 Then
                    For i = 1 To 5
                        If i = 1 Then
                            Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD").NewRow
                            Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                            Fila_Digitacion("INDICE") = i
                            Cjto_Tablas1.Tables("DENSIDAD").Rows.Add(Fila_Digitacion)
                        Else
                            Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD").NewRow
                            Fila_Digitacion("INDICE") = i
                            Cjto_Tablas1.Tables("DENSIDAD").Rows.Add(Fila_Digitacion)
                        End If

                    Next
                ElseIf EstaRevisado <> 0 Then
                    MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                End If

            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If

        Cjto_Tablas1.Tables("DENSIDAD").Clear()
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga
            If CInt(myReader1.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader1.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = 0
                'EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 4000)
            End If
            If Carga_Digitacion = "S" Then
                For i = 1 To 5
                    If i = 1 Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD").NewRow
                        Fila_Digitacion("OT_NLAB") = myReader1.GetString(0)
                        Fila_Digitacion("INDICE") = i
                        Cjto_Tablas1.Tables("DENSIDAD").Rows.Add(Fila_Digitacion)
                    Else
                        Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD").NewRow
                        Fila_Digitacion("INDICE") = i
                        Cjto_Tablas1.Tables("DENSIDAD").Rows.Add(Fila_Digitacion)
                    End If

                Next
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:
        SqlConn.Close()
    End Sub

    Private Sub Txt_DenPseco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DenPseco.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_DenPseco.Text = "" Then
                Dtg_Densidad.Item(Fila_Lectura, 2) = 0
                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPhumedo.Focus()
                Txt_DenPseco.Visible = False
            Else
                Txt_DenPseco.Text = Txt_DenPseco.Text.Replace(".", ",")
                Dtg_Densidad.Item(Fila_Lectura, 2) = Txt_DenPseco.Text
                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPhumedo.Focus()
                Txt_DenPseco.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_DenPhumedo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DenPhumedo.KeyPress
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            If Txt_DenPhumedo.Text = "" Then
                Dtg_Densidad.Item(Fila_Lectura, 3) = 0
                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPparaf.Focus()
                Txt_DenPhumedo.Visible = False
            Else
                Txt_DenPhumedo.Text = Txt_DenPhumedo.Text.Replace(".", ",")
                Dtg_Densidad.Item(Fila_Lectura, 3) = Txt_DenPhumedo.Text
                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPparaf.Focus()
                Txt_DenPhumedo.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_DenPparaf_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DenPparaf.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_DenPparaf.Text = "" Then
                Dtg_Densidad.Item(Fila_Lectura, 4) = 0
                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPagua.Focus()
                Txt_DenPparaf.Visible = False
            Else
                Txt_DenPparaf.Text = Txt_DenPparaf.Text.Replace(".", ",")
                Dtg_Densidad.Item(Fila_Lectura, 4) = Txt_DenPparaf.Text
                mycell.ColumnNumber = 5
                mycell.RowNumber = Fila_Lectura
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPagua.Focus()
                Txt_DenPparaf.Visible = False
            End If

        End If
    End Sub


    Private Sub Txt_DenPagua_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_DenPagua.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_DenPagua.Text = "" Then
                Dtg_Densidad.Item(Fila_Lectura, 5) = 0
                Dtg_Densidad(Fila_Lectura, 6) = Round(Densidad(Dtg_Densidad(Fila_Lectura, 2), Dtg_Densidad(Fila_Lectura, 3), Dtg_Densidad(Fila_Lectura, 4), Dtg_Densidad(Fila_Lectura, 5)), 2)
                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPseco.Focus()
                Txt_DenPagua.Visible = False
            Else
                Txt_DenPagua.Text = Txt_DenPagua.Text.Replace(".", ",")
                Dtg_Densidad.Item(Fila_Lectura, 5) = Txt_DenPagua.Text
                Dtg_Densidad(Fila_Lectura, 6) = Round(Densidad(Dtg_Densidad(Fila_Lectura, 2), Dtg_Densidad(Fila_Lectura, 3), Dtg_Densidad(Fila_Lectura, 4), Dtg_Densidad(Fila_Lectura, 5)), 2)
                mycell.ColumnNumber = 2
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_Densidad.CurrentCell = mycell
                Me.Txt_DenPseco.Focus()
                Txt_DenPagua.Visible = False
            End If

        End If
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim indice As Integer
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim cont, Promedio As Integer
        Dim DatoPaso As String
        Dim pSeco, pHume, pEmp, pEmpAgua, dAparente As Double
        Promedio = 0

        cont = Fila_Lectura
        Try
            With SP

                For indice = 0 To cont
                    If IsDBNull(Dtg_Densidad(indice, 0)) = False And Dtg_Densidad(indice, 1) = 1 Then
                        DatoPaso = Dtg_Densidad(indice, 0)
                    End If

                    .Inicializar()
                    .AgregarParametro("@Numlab", CStr(DatoPaso), SqlDbType.NVarChar)

                    If IsDBNull(Dtg_Densidad(indice, 2)) Then
                        pSeco = 0
                    Else
                        pSeco = Dtg_Densidad(indice, 2)
                    End If
                    .AgregarParametro("@Pseco", CDbl(pSeco), SqlDbType.Float)

                    If IsDBNull(Dtg_Densidad(indice, 3)) Then
                        pHume = 0
                    Else
                        pHume = Dtg_Densidad(indice, 3)
                    End If
                    .AgregarParametro("@Phumedo", CDbl(pHume), SqlDbType.Float)

                    If IsDBNull(Dtg_Densidad(indice, 4)) Then
                        pEmp = 0
                    Else
                        pEmp = Dtg_Densidad(indice, 4)
                    End If
                    .AgregarParametro("@Pemp", CDbl(pEmp), SqlDbType.Float)

                    If IsDBNull(Dtg_Densidad(indice, 5)) Then
                        pEmpAgua = 0
                    Else
                        pEmpAgua = Dtg_Densidad(indice, 5)
                    End If
                    .AgregarParametro("@Pempagua", CDbl(pEmpAgua), SqlDbType.Float)

                    If IsDBNull(Dtg_Densidad(indice, 6)) Then
                        dAparente = 0
                    Else
                        dAparente = Dtg_Densidad(indice, 6)
                    End If

                    .AgregarParametro("@Denapa", CDbl(dAparente), SqlDbType.Float)
                    .AgregarParametro("@Indice", CInt(Dtg_Densidad(indice, 1)), SqlDbType.Int)
                    .EjecutarEscalar("usp_GrabaDensidad")
                Next


            End With

            With SP
                .Inicializar()
                .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                .AgregarParametro("@Num_lab", CInt(DatoPaso), SqlDbType.Int)
                .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                .EjecutarEscalar("usp_Update_DigitaResultados")
            End With

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub Anti_Elimina_Lineas()
        Dtg_Densidad.DataSource = Cjto_Tablas1.Tables("DENSIDAD")
    End Sub

    Private Sub Bt_Imprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Imprime.Click
        Dim m_Excel As Excel.Application
        Dim objLibroExcel As Excel.Workbook
        Dim objHojaExcel As Excel.Worksheet
        Dim Destino As String = "F:\Mis documentos\Traspaso Archivos entre PCs\01.  Sistema LabSys 2008\040  DIGITACION Y CALCULO RESULTADOS\Formato Base\Copia de Formatos Resultados.xls"
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

        Call EncavezadoPag(Dtp_FechaDigitacion.Text, Dtp_FechaAnalisis.Text, objHojaExcel)
        Call Imprime_PiePagTex(objHojaExcel, Cbx_Analista.Text, Cbx_Digitador.Text)
        Call Encavezado_Densidad(objHojaExcel, Metodo)
        Call Imprime_Resultados_Densidad(objHojaExcel, Fila_Exp + 1)
        'If Fila_Exp <= 59 Then
        '    Call Encavezado_Resultado_Densidad(objHojaExcel, Fila_Exp + 2)
        '    Call Imprime_Resultados_Densidad(objHojaExcel, Fila_Exp + 1)
        'End If

        'If Fila_Exp > 59 Then
        '    Call Encavezado_Resultado_Densidad2(objHojaExcel, Fila_Exp + 2)
        '    Call Imprime_Resultados_Densidad2(objHojaExcel, Fila_Exp + 1)
        'End If

    End Sub

    Private Sub DigitaDensidad_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cjto_Tablas1.Tables("DENSIDAD").Clear()
        Txt_NLabInicial.ResetText()
    End Sub
End Class
