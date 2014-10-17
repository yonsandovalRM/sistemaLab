Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.Office.Interop

Public Class Frm_DigitaTextura
    Inherits System.Windows.Forms.Form
    Dim Fila_Lectura, Fila_M As Integer
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
    Friend WithEvents Txt_1Lect As System.Windows.Forms.TextBox
    Friend WithEvents Txt_temp1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_2Lec As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cap1 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_temp2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cap2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PesoMueafina As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PesoAgruesa As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_TexturaSeparacionArenas As System.Windows.Forms.DataGrid
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Bt_Limpia As System.Windows.Forms.Button
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
        Me.Dtg_TexturaSeparacionArenas = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Txt_1Lect = New System.Windows.Forms.TextBox
        Me.Txt_cap1 = New System.Windows.Forms.TextBox
        Me.Txt_temp2 = New System.Windows.Forms.TextBox
        Me.Txt_temp1 = New System.Windows.Forms.TextBox
        Me.Txt_2Lec = New System.Windows.Forms.TextBox
        Me.Txt_Cap2 = New System.Windows.Forms.TextBox
        Me.Txt_PesoMueafina = New System.Windows.Forms.TextBox
        Me.Txt_PesoAgruesa = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Bt_Limpia = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_TexturaSeparacionArenas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.TabIndex = 3
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
        Me.GroupBox1.TabIndex = 2
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
        'Dtg_TexturaSeparacionArenas
        '
        Me.Dtg_TexturaSeparacionArenas.CaptionVisible = False
        Me.Dtg_TexturaSeparacionArenas.DataMember = ""
        Me.Dtg_TexturaSeparacionArenas.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_TexturaSeparacionArenas.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_TexturaSeparacionArenas.Location = New System.Drawing.Point(304, 24)
        Me.Dtg_TexturaSeparacionArenas.Name = "Dtg_TexturaSeparacionArenas"
        Me.Dtg_TexturaSeparacionArenas.Size = New System.Drawing.Size(964, 896)
        Me.Dtg_TexturaSeparacionArenas.TabIndex = 4
        Me.Dtg_TexturaSeparacionArenas.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_TexturaSeparacionArenas
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TEXTURA_SUELO1"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N°Lab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Bl"
        Me.DataGridTextBoxColumn2.MappingName = "BLANCO"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 50
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "1°Lec"
        Me.DataGridTextBoxColumn3.MappingName = "LECTURA1"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 45
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "t°"
        Me.DataGridTextBoxColumn4.MappingName = "TEMP1"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 45
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "2°Lec"
        Me.DataGridTextBoxColumn5.MappingName = "LECTURA2"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 45
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "t°"
        Me.DataGridTextBoxColumn6.MappingName = "TEMP2"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 45
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "Arena"
        Me.DataGridTextBoxColumn15.MappingName = "ARENA"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 45
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "Limo"
        Me.DataGridTextBoxColumn14.MappingName = "LIMO"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 45
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "Arcilla"
        Me.DataGridTextBoxColumn13.MappingName = "ARC"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 45
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.MappingName = "CLASE_TEXTURAL"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 110
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "N°Cap"
        Me.DataGridTextBoxColumn7.MappingName = "ID_CAPSULA"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 45
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "P.cap"
        Me.DataGridTextBoxColumn8.MappingName = "TARA_CAPSULA"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 45
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "P.cap+are"
        Me.DataGridTextBoxColumn11.MappingName = "PESO_CAPSULAMASMUESTRA"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "N°Cap"
        Me.DataGridTextBoxColumn9.MappingName = "ID_CAPSULA2"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 45
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "P.cap"
        Me.DataGridTextBoxColumn10.MappingName = "TARA_CAPSULA2"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 45
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "P.cap+are"
        Me.DataGridTextBoxColumn12.MappingName = "PESO_CAPSULAMASMUESTRA2"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 60
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "gruesa"
        Me.DataGridTextBoxColumn16.MappingName = "FRACCION_ARENA"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 45
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "fina"
        Me.DataGridTextBoxColumn17.MappingName = "FRACCION_ARENA2"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 45
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Salir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Bt_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Salir.Location = New System.Drawing.Point(1184, 944)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 37
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
        Me.Bt_Imprime.Location = New System.Drawing.Point(992, 944)
        Me.Bt_Imprime.Name = "Bt_Imprime"
        Me.Bt_Imprime.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Imprime.TabIndex = 35
        Me.Bt_Imprime.Text = "Imprime"
        Me.Bt_Imprime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Imprime.UseVisualStyleBackColor = False
        '
        'Bt_Graba
        '
        Me.Bt_Graba.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Graba.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Graba.Image = Global.LabSys.My.Resources.Resources.bullet_disk
        Me.Bt_Graba.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Graba.Location = New System.Drawing.Point(896, 944)
        Me.Bt_Graba.Name = "Bt_Graba"
        Me.Bt_Graba.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Graba.TabIndex = 34
        Me.Bt_Graba.Text = "Graba"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Txt_1Lect
        '
        Me.Txt_1Lect.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_1Lect.Location = New System.Drawing.Point(312, 160)
        Me.Txt_1Lect.Name = "Txt_1Lect"
        Me.Txt_1Lect.Size = New System.Drawing.Size(100, 20)
        Me.Txt_1Lect.TabIndex = 38
        Me.Txt_1Lect.Visible = False
        '
        'Txt_cap1
        '
        Me.Txt_cap1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cap1.Location = New System.Drawing.Point(304, 288)
        Me.Txt_cap1.Name = "Txt_cap1"
        Me.Txt_cap1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_cap1.TabIndex = 39
        Me.Txt_cap1.Visible = False
        '
        'Txt_temp2
        '
        Me.Txt_temp2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_temp2.Location = New System.Drawing.Point(304, 256)
        Me.Txt_temp2.Name = "Txt_temp2"
        Me.Txt_temp2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_temp2.TabIndex = 40
        Me.Txt_temp2.Visible = False
        '
        'Txt_temp1
        '
        Me.Txt_temp1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_temp1.Location = New System.Drawing.Point(304, 224)
        Me.Txt_temp1.Name = "Txt_temp1"
        Me.Txt_temp1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_temp1.TabIndex = 41
        Me.Txt_temp1.Visible = False
        '
        'Txt_2Lec
        '
        Me.Txt_2Lec.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_2Lec.Location = New System.Drawing.Point(304, 192)
        Me.Txt_2Lec.Name = "Txt_2Lec"
        Me.Txt_2Lec.Size = New System.Drawing.Size(100, 20)
        Me.Txt_2Lec.TabIndex = 42
        Me.Txt_2Lec.Visible = False
        '
        'Txt_Cap2
        '
        Me.Txt_Cap2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cap2.Location = New System.Drawing.Point(304, 336)
        Me.Txt_Cap2.Name = "Txt_Cap2"
        Me.Txt_Cap2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Cap2.TabIndex = 43
        Me.Txt_Cap2.Visible = False
        '
        'Txt_PesoMueafina
        '
        Me.Txt_PesoMueafina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PesoMueafina.Location = New System.Drawing.Point(304, 368)
        Me.Txt_PesoMueafina.Name = "Txt_PesoMueafina"
        Me.Txt_PesoMueafina.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PesoMueafina.TabIndex = 44
        Me.Txt_PesoMueafina.Visible = False
        '
        'Txt_PesoAgruesa
        '
        Me.Txt_PesoAgruesa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PesoAgruesa.Location = New System.Drawing.Point(304, 408)
        Me.Txt_PesoAgruesa.Name = "Txt_PesoAgruesa"
        Me.Txt_PesoAgruesa.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PesoAgruesa.TabIndex = 46
        Me.Txt_PesoAgruesa.Visible = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(0, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 20)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Blanco"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(144, 360)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 20)
        Me.TextBox1.TabIndex = 48
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(400, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(240, 24)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "Lecturas"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(640, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(128, 24)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Textura(%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(768, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(112, 24)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Clase Textural"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(1184, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 24)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "Arenas (%)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(880, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(160, 24)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Separa arena gruesa (g)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(1032, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(152, 24)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Separa arena fina (g)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(344, 7)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 17)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "N°Lab"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bt_Limpia
        '
        Me.Bt_Limpia.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Limpia.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Limpia.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Bt_Limpia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Limpia.Location = New System.Drawing.Point(1088, 944)
        Me.Bt_Limpia.Name = "Bt_Limpia"
        Me.Bt_Limpia.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Limpia.TabIndex = 56
        Me.Bt_Limpia.Text = "Limpiar"
        Me.Bt_Limpia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Limpia.UseVisualStyleBackColor = False
        '
        'Frm_DigitaTextura
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Bt_Limpia)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_PesoAgruesa)
        Me.Controls.Add(Me.Txt_PesoMueafina)
        Me.Controls.Add(Me.Txt_Cap2)
        Me.Controls.Add(Me.Txt_2Lec)
        Me.Controls.Add(Me.Txt_temp1)
        Me.Controls.Add(Me.Txt_temp2)
        Me.Controls.Add(Me.Txt_cap1)
        Me.Controls.Add(Me.Txt_1Lect)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Dtg_TexturaSeparacionArenas)
        Me.Name = "Frm_DigitaTextura"
        Me.Text = "Frm_DigitaTextura"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dtg_TexturaSeparacionArenas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Anti_Elimina_Lineas()
        Dtg_TexturaSeparacionArenas.DataSource = Cjto_Tablas1.Tables("TEXTURA_SUELO1")
    End Sub
    Private Sub Dtg_TexturaSeparacionArenas_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_TexturaSeparacionArenas.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber()
        Revision_Digitacion = "N"


        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 2 Then Revision_Digitacion = "S"



        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_1Lect.Left = Posicionx
            Txt_1Lect.Top = Posiciony
            Txt_1Lect.Height = CeldaAlto
            Txt_1Lect.Width = CeldaAncho
            Txt_1Lect.Visible = True
            Txt_1Lect.Text = ""
            Txt_1Lect.Enabled = True
            Txt_1Lect.TabIndex = 38
            Txt_1Lect.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_2Lec.Left = Posicionx
            Txt_2Lec.Top = Posiciony
            Txt_2Lec.Height = CeldaAlto
            Txt_2Lec.Width = CeldaAncho
            Txt_2Lec.Visible = True
            Txt_2Lec.Text = ""
            Txt_2Lec.Enabled = True
            Txt_2Lec.TabIndex = 42
            Txt_2Lec.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_temp1.Left = Posicionx
            Txt_temp1.Top = Posiciony
            Txt_temp1.Height = CeldaAlto
            Txt_temp1.Width = CeldaAncho
            Txt_temp1.Visible = True
            Txt_temp1.Text = ""
            Txt_temp1.Enabled = True
            Txt_temp1.TabIndex = 41
            Txt_temp1.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_temp2.Left = Posicionx
            Txt_temp2.Top = Posiciony
            Txt_temp2.Height = CeldaAlto
            Txt_temp2.Width = CeldaAncho
            Txt_temp2.Visible = True
            Txt_temp2.Text = ""
            Txt_temp2.Enabled = True
            Txt_temp2.TabIndex = 40
            Txt_temp2.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 10 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_cap1.Left = Posicionx
            Txt_cap1.Top = Posiciony
            Txt_cap1.Height = CeldaAlto
            Txt_cap1.Width = CeldaAncho
            Txt_cap1.Visible = True
            Txt_cap1.Text = ""
            Txt_cap1.Enabled = True
            Txt_cap1.TabIndex = 39
            Txt_cap1.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 13 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_Cap2.Left = Posicionx
            Txt_Cap2.Top = Posiciony
            Txt_Cap2.Height = CeldaAlto
            Txt_Cap2.Width = CeldaAncho
            Txt_Cap2.Visible = True
            Txt_Cap2.Text = ""
            Txt_Cap2.Enabled = True
            Txt_Cap2.TabIndex = 43
            Txt_Cap2.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 12 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_PesoAgruesa.Left = Posicionx
            Txt_PesoAgruesa.Top = Posiciony
            Txt_PesoAgruesa.Height = CeldaAlto
            Txt_PesoAgruesa.Width = CeldaAncho
            Txt_PesoAgruesa.Visible = True
            Txt_PesoAgruesa.Text = ""
            Txt_PesoAgruesa.Enabled = True
            Txt_PesoAgruesa.TabIndex = 46
            Txt_PesoAgruesa.Focus()
        End If

        If Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber = 15 Then
            Dim CeldaAlto As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).X + Dtg_TexturaSeparacionArenas.Left
            Dim Posiciony As Integer = Dtg_TexturaSeparacionArenas.GetCellBounds(Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber, Dtg_TexturaSeparacionArenas.CurrentCell.ColumnNumber).Y + Dtg_TexturaSeparacionArenas.Top
            Txt_PesoMueafina.Left = Posicionx
            Txt_PesoMueafina.Top = Posiciony
            Txt_PesoMueafina.Height = CeldaAlto
            Txt_PesoMueafina.Width = CeldaAncho
            Txt_PesoMueafina.Visible = True
            Txt_PesoMueafina.Text = ""
            Txt_PesoMueafina.Enabled = True
            Txt_PesoMueafina.TabIndex = 44
            Txt_PesoMueafina.Focus()
        End If

    End Sub

    Private Sub Carga_Planilla()
        Dim Fila_Digitacion, Fila_Carga As DataRow
        Dim Carga_Digitacion, query, Son_Blancos, query2 As String
        Dim EstaRevisado, NumRepD, ii, Cuenta_Blancos, Mypos As Integer

        Dim SqlConn As New SqlConnection
        Dim Con1 As New SqlConnection
        Dim Command As SqlCommand
        SqlConn = New SqlConnection(Conexion1)
        Son_Blancos = "S"
        'Elemento = "WTexBouyouco"
        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then

            Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()
                Carga_Digitacion = "N"
                ' If Me.Txt_NLabDesde.Text <> "" Or Me.Txt_NLabHasta.Text <> "" Then Carga_Digitacion = "S" 'GoTo saltocarga
                If CInt(myReader.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"


                If Mypos = 0 Then
                    EstaRevisado = 0
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 4000)
                End If
                If Carga_Digitacion = "S" And EstaRevisado = 0 Then
                    Fila_Digitacion = Cjto_Tablas1.Tables("TEXTURA_SUELO1").NewRow
                    Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                    Cjto_Tablas1.Tables("TEXTURA_SUELO1").Rows.Add(Fila_Digitacion)
                ElseIf EstaRevisado <> 0 Then
                    MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                End If
            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If

        Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
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
                EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, 4000)
            End If
            If Carga_Digitacion = "S" And EstaRevisado = 0 Then
                Fila_Digitacion = Cjto_Tablas1.Tables("TEXTURA_SUELO1").NewRow
                Fila_Digitacion("OT_NLAB") = myReader1.GetString(0)
                Cjto_Tablas1.Tables("TEXTURA_SUELO1").Rows.Add(Fila_Digitacion)
            Else
                MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:
        SqlConn.Close()

    End Sub

    Private Sub Bt_Carga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click
        Call Carga_Planilla()
    End Sub
#Region "Textura"
    Private Sub Txt_temp2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_temp2.KeyPress
        Dim ARE, ARC, LIM, TOTAL, FILA As Double
        Dim mycell As New DataGridCell
        Dim a, b As Integer
        Dim Tipo As String
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 5) = Txt_temp2.Text

            'El llamado a la funcion Clasificacion es para obtener los resultados de Arena, Limo y Arcilla
            Call Clasificacion(CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 2)), CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 4)), CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 3)), CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 5)), ARC, ARE, LIM, TOTAL)
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 8) = ARC
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 7) = LIM
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 6) = ARE

            ' Al llamar a la funcion de Clase Textural, se obtiene el nombre de la clase
            ' Ej:Franca,Arcillosa

            Call Clase_Textural(ARC, LIM, ARE, Tipo)

            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 9) = Tipo

            If e.KeyChar = Chr(13) Then
                Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 5) = Txt_temp2.Text
                mycell.ColumnNumber = 10
                mycell.RowNumber = Fila_Lectura
                Dtg_TexturaSeparacionArenas.CurrentCell = mycell
                Me.Txt_cap1.Focus()
                Txt_temp2.Visible = False
            End If
        End If

    End Sub

    Private Sub Txt_1Lect_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_1Lect.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 2) = Txt_1Lect.Text
            mycell.ColumnNumber = 3
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_temp1.Focus()
            Txt_1Lect.Visible = False
        End If

    End Sub

    Private Sub Txt_temp1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_temp1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 3) = Txt_temp1.Text
            mycell.ColumnNumber = 4
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_2Lec.Focus()
            Txt_temp1.Visible = False
        End If
    End Sub

    Private Sub Txt_2Lec_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_2Lec.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 4) = Txt_2Lec.Text
            mycell.ColumnNumber = 5
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_temp2.Focus()
            Txt_2Lec.Visible = False
        End If
    End Sub

#End Region


    Private Sub Txt_cap1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cap1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 10) = Txt_cap1.Text
            mycell.ColumnNumber = 13
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_Cap2.Focus()
            Txt_cap1.Visible = False
        End If

    End Sub

    Private Sub Txt_Cap2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Cap2.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 13) = Txt_Cap2.Text
            mycell.ColumnNumber = 12
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Call Carga_TaraCapsula()
            Me.Txt_PesoAgruesa.Focus()
            Txt_Cap2.Visible = False
        End If
    End Sub

    Private Sub Carga_TaraCapsula()
        'El codigo carga el peso de las capsulas en la grilla, el ciclo For es el limitador 
        'de las filas

        Dim dato1, dato2, IdCapsula, i As Integer
        Dim TaraCapsula As Double
        Dim FArena As String

        dato1 = CInt(Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 10))
        dato2 = CInt(Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 13))
        Call BuscarCapsula(dato1, TaraCapsula, IdCapsula, FArena)
        If dato1 = IdCapsula Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 11) = TaraCapsula
            ' Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 9) = FArena
        End If
        Call BuscarCapsula(dato2, TaraCapsula, IdCapsula, FArena)
        If dato2 = IdCapsula Then
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 14) = TaraCapsula
            ' Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 9) = FArena
        End If
    End Sub

    Function BuscarCapsula(ByVal IdCapsula1 As Int32, ByRef TaraCapsula As Double, ByRef IdCapsula As Integer, ByRef FArena As String)
        'El codigo tiene la funcion de devolver el peso de la capsula, el dato que se ingresa para su 
        'proceso es el número de la capsula
        Dim dsCaps As New DataSet
        Dim drFila As DataRow
        Dim sSql As String
        Dim sqlAdaptador As SqlClient.SqlDataAdapter

        sSql = "SELECT * FROM CAPSULAS WHERE IDCAPSULA=" & IdCapsula1
        dsCaps = New DataSet("Cjto_Tablas")
        dsCaps.Clear()
        dsCaps.Tables.Add("Capsulas")
        dsCaps.Tables("Capsulas").Columns.Add("IdCapsula", System.Type.GetType("System.Int32"))
        dsCaps.Tables("Capsulas").Columns.Add("Tara_Capsula", System.Type.GetType("System.Double"))
        dsCaps.Tables("Capsulas").Columns.Add("Fraccion_Arena", System.Type.GetType("System.String"))
        sqlAdaptador = New SqlClient.SqlDataAdapter(sSql, Conexion1)
        sqlAdaptador.Fill(dsCaps.Tables("Capsulas"))
        drFila = dsCaps.Tables("Capsulas").NewRow
        For Each drFila In dsCaps.Tables("Capsulas").Rows
            TaraCapsula = drFila.Item("Tara_Capsula")
            IdCapsula = drFila.Item("IdCapsula")
            FArena = drFila.Item("Fraccion_Arena")
        Next

    End Function

    Private Sub Txt_PesoAgruesa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PesoAgruesa.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Txt_PesoAgruesa.Text = Txt_PesoAgruesa.Text.Replace(".", ",")
            Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 12) = Txt_PesoAgruesa.Text
            mycell.ColumnNumber = 15
            mycell.RowNumber = Fila_Lectura
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_PesoMueafina.Focus()
            Txt_PesoAgruesa.Visible = False
        End If
    End Sub

    Private Sub Txt_PesoMueafina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PesoMueafina.KeyPress
        Dim Porc_Afina, Porc_Agruesa As Double
        Dim Fila_m As Integer
        Dim Peso1, Peso2, Pmue1, Pmue2, Ptex1, Ptex2, a, b, c As Double
        Dim mycell As New DataGridCell

        If e.KeyChar = Chr(13) Then
            Txt_PesoAgruesa.Text = Txt_PesoAgruesa.Text.Replace(".", ",") ' Remplasa los "." por ","
            Txt_PesoMueafina.Text = Txt_PesoMueafina.Text.Replace(".", ",") ' Remplasa los "." por ","
            Call F_Arena(CDbl(Txt_PesoAgruesa.Text), Dtg_TexturaSeparacionArenas(Fila_Lectura, 11), CDbl(Txt_PesoMueafina.Text), Dtg_TexturaSeparacionArenas(Fila_Lectura, 14), Porc_Afina, Porc_Agruesa, CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 6)))
            Dtg_TexturaSeparacionArenas(Fila_Lectura, 15) = Txt_PesoMueafina.Text
            Dtg_TexturaSeparacionArenas(Fila_Lectura, 16) = Round(Porc_Agruesa, 0)
            Dtg_TexturaSeparacionArenas(Fila_Lectura, 17) = Round(Porc_Afina, 0)
            mycell.ColumnNumber = 2
            mycell.RowNumber = Fila_Lectura + 1
            Dtg_TexturaSeparacionArenas.CurrentCell = mycell
            Me.Txt_1Lect.Focus()
            Txt_PesoMueafina.Visible = False
            Me.Txt_1Lect.Visible = True
        End If
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
        Call EncavezadoTextura(objHojaExcel)
        'Call Encavezado_ResultadoTex(objHojaExcel)
        Call Imprime_PiePagTex(objHojaExcel, Cbx_Analista.Text, Cbx_Digitador.Text)
        Call Imprime_ResultadosTex(objHojaExcel)
    End Sub

    Private Sub Frm_DigitaTextura_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Cont, i As Integer
        Cont = Dtg_TexturaSeparacionArenas.CurrentCell.RowNumber
        Fila_Lectura = 0

        Try
            For i = 0 To Cont
                With SP
                    .Inicializar()
                    .AgregarParametro("@Num_lab", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 0)), SqlDbType.Int)
                    If IsDBNull(Dtg_TexturaSeparacionArenas(Fila_Lectura, 1)) = True Then Dtg_TexturaSeparacionArenas(Fila_Lectura, 1) = 0
                    .AgregarParametro("@Blanco", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 1)), SqlDbType.Int)
                    .AgregarParametro("@Lect1", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 2)), SqlDbType.Int)
                    .AgregarParametro("@Temp1", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 3)), SqlDbType.Int)
                    .AgregarParametro("@Lect2", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 4)), SqlDbType.Int)
                    .AgregarParametro("@Temp2", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 5)), SqlDbType.Int)
                    .AgregarParametro("@Arena", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 6)), SqlDbType.Int)
                    .AgregarParametro("@Limo", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 7)), SqlDbType.Int)
                    .AgregarParametro("@Arcilla", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 8)), SqlDbType.Int)
                    .AgregarParametro("@Cla_textura", Dtg_TexturaSeparacionArenas(Fila_Lectura, 9), SqlDbType.NVarChar)
                    .AgregarParametro("@Cap1", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 10)), SqlDbType.Int)
                    .AgregarParametro("@Peso_cap1", CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 11)), SqlDbType.Float)
                    .AgregarParametro("@Cap2", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 13)), SqlDbType.Int)
                    .AgregarParametro("@Peso_cap2", CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 14)), SqlDbType.Float)
                    .AgregarParametro("@Peso_agruesa", CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 12)), SqlDbType.Float)
                    .AgregarParametro("@Peso_afina", CDbl(Dtg_TexturaSeparacionArenas(Fila_Lectura, 15)), SqlDbType.Float)
                    .AgregarParametro("@Porc_agruesa", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 16)), SqlDbType.Int)
                    .AgregarParametro("@Porc_afina", CInt(Dtg_TexturaSeparacionArenas(Fila_Lectura, 17)), SqlDbType.Int)
                    .EjecutarEscalar("usp_GrabaTextura")
                End With
                'With SP
                '    .Inicializar()
                '    .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                '    .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                '    .AgregarParametro("@Num_lab", Dtg_TexturaSeparacionArenas(Fila_Lectura, 0), SqlDbType.Int)
                '    .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                '    .EjecutarEscalar("usp_Update_DigitaResultados")
                'End With
                Fila_Lectura = Fila_Lectura + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
            
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Limpia.Click
        Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
        Txt_NLabDesde.ResetText()
        Txt_NLabHasta.ResetText()
        Txt_1Lect.Visible = False
    End Sub


End Class
