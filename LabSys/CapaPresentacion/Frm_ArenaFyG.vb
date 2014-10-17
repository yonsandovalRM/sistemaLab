Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.Office.Interop

Public Class Frm_ArenaFyG
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Cbx_Analista As System.Windows.Forms.ComboBox
    Friend WithEvents Dtp_FechaAnalisis As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cbx_Digitador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Dtp_FechaDigitacion As System.Windows.Forms.DateTimePicker
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
    Friend WithEvents Bt_Limpia As System.Windows.Forms.Button
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
    Friend WithEvents Dtg_ArenaFyG As System.Windows.Forms.DataGrid
    Friend WithEvents Txt_PesoAgruesa As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PesoMueafina As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Cap2 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_cap1 As System.Windows.Forms.TextBox
    Friend WithEvents Cjto_Tablas1 As LabSys.Cjto_Tablas
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
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
        Me.Dtg_ArenaFyG = New System.Windows.Forms.DataGrid
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
        Me.Bt_Limpia = New System.Windows.Forms.Button
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Txt_PesoAgruesa = New System.Windows.Forms.TextBox
        Me.Txt_PesoMueafina = New System.Windows.Forms.TextBox
        Me.Txt_Cap2 = New System.Windows.Forms.TextBox
        Me.Txt_cap1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Dtg_ArenaFyG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox1.TabIndex = 3
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
        Me.GroupBox2.TabIndex = 4
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
        'Dtg_ArenaFyG
        '
        Me.Dtg_ArenaFyG.CaptionVisible = False
        Me.Dtg_ArenaFyG.DataMember = "TEXTURA_SUELO1"
        Me.Dtg_ArenaFyG.DataSource = Me.Cjto_Tablas1
        Me.Dtg_ArenaFyG.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_ArenaFyG.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_ArenaFyG.Location = New System.Drawing.Point(304, 32)
        Me.Dtg_ArenaFyG.Name = "Dtg_ArenaFyG"
        Me.Dtg_ArenaFyG.Size = New System.Drawing.Size(696, 888)
        Me.Dtg_ArenaFyG.TabIndex = 5
        Me.Dtg_ArenaFyG.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'Cjto_Tablas1
        '
        Me.Cjto_Tablas1.DataSetName = "Cjto_Tablas"
        Me.Cjto_Tablas1.Locale = New System.Globalization.CultureInfo("en-US")
        Me.Cjto_Tablas1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_ArenaFyG
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TEXTURA_SUELO1"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "NºLab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "Arena"
        Me.DataGridTextBoxColumn2.MappingName = "ARENA"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 60
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "NºCap"
        Me.DataGridTextBoxColumn3.MappingName = "ID_CAPSULA"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 60
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "P.Cap"
        Me.DataGridTextBoxColumn4.MappingName = "TARA_CAPSULA"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "P.cap+are"
        Me.DataGridTextBoxColumn5.MappingName = "PESO_CAPSULAMASMUESTRA"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "NºCap"
        Me.DataGridTextBoxColumn6.MappingName = "ID_CAPSULA2"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "P.Cap"
        Me.DataGridTextBoxColumn7.MappingName = "TARA_CAPSULA2"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "P.cap+are"
        Me.DataGridTextBoxColumn8.MappingName = "PESO_CAPSULAMASMUESTRA2"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "A.gruesa"
        Me.DataGridTextBoxColumn9.MappingName = "PORC_ARENA"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "A.fina"
        Me.DataGridTextBoxColumn10.MappingName = "PORC_ARENA2"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
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
        Me.Bt_Limpia.TabIndex = 60
        Me.Bt_Limpia.Text = "Limpiar"
        Me.Bt_Limpia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Limpia.UseVisualStyleBackColor = False
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
        Me.Bt_Salir.TabIndex = 59
        Me.Bt_Salir.Text = "Salir"
        Me.Bt_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Salir.UseVisualStyleBackColor = False
        '
        'Bt_Imprime
        '
        Me.Bt_Imprime.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Imprime.Enabled = False
        Me.Bt_Imprime.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Imprime.Image = Global.LabSys.My.Resources.Resources.printer
        Me.Bt_Imprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Imprime.Location = New System.Drawing.Point(992, 944)
        Me.Bt_Imprime.Name = "Bt_Imprime"
        Me.Bt_Imprime.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Imprime.TabIndex = 58
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
        Me.Bt_Graba.TabIndex = 57
        Me.Bt_Graba.Text = "Graba"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Txt_PesoAgruesa
        '
        Me.Txt_PesoAgruesa.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PesoAgruesa.Location = New System.Drawing.Point(312, 280)
        Me.Txt_PesoAgruesa.Name = "Txt_PesoAgruesa"
        Me.Txt_PesoAgruesa.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PesoAgruesa.TabIndex = 64
        Me.Txt_PesoAgruesa.Visible = False
        '
        'Txt_PesoMueafina
        '
        Me.Txt_PesoMueafina.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PesoMueafina.Location = New System.Drawing.Point(312, 256)
        Me.Txt_PesoMueafina.Name = "Txt_PesoMueafina"
        Me.Txt_PesoMueafina.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PesoMueafina.TabIndex = 63
        Me.Txt_PesoMueafina.Visible = False
        '
        'Txt_Cap2
        '
        Me.Txt_Cap2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Cap2.Location = New System.Drawing.Point(312, 232)
        Me.Txt_Cap2.Name = "Txt_Cap2"
        Me.Txt_Cap2.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Cap2.TabIndex = 62
        Me.Txt_Cap2.Visible = False
        '
        'Txt_cap1
        '
        Me.Txt_cap1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_cap1.Location = New System.Drawing.Point(312, 208)
        Me.Txt_cap1.Name = "Txt_cap1"
        Me.Txt_cap1.Size = New System.Drawing.Size(100, 20)
        Me.Txt_cap1.TabIndex = 61
        Me.Txt_cap1.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(464, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(192, 16)
        Me.Label9.TabIndex = 66
        Me.Label9.Text = "Separación arena gruesa(g)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(664, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 16)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Separación arena fina(g)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(864, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 16)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Arenas (%)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Frm_ArenaFyG
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_PesoAgruesa)
        Me.Controls.Add(Me.Txt_PesoMueafina)
        Me.Controls.Add(Me.Txt_Cap2)
        Me.Controls.Add(Me.Txt_cap1)
        Me.Controls.Add(Me.Bt_Limpia)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.Dtg_ArenaFyG)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Frm_ArenaFyG"
        Me.Text = "Frm_ArenaFyG"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Dtg_ArenaFyG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cjto_Tablas1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
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
                    Fila_Digitacion("ARENA") = CInt(Carga_Arena(CInt(myReader.GetString(0))))
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
                Fila_Digitacion("ARENA") = CInt(Carga_Arena(CInt(myReader1.GetString(0))))
                Cjto_Tablas1.Tables("TEXTURA_SUELO1").Rows.Add(Fila_Digitacion)
            Else
                MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:
        SqlConn.Close()

    End Sub
    Function Carga_Arena(ByVal NumLab As String)
        Dim Sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Try
            With Sp
                .Inicializar()
                .AgregarParametro("@NumLab", NumLab, SqlDbType.NVarChar)
                Carga_Arena = .EjecutarEscalar3("usp_CargaArenaFyG")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Carga_Arena
    End Function

    Private Sub Bt_Graba_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim Sp As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Cont, i As Integer
        Cont = Dtg_ArenaFyG.CurrentCell.RowNumber
        Fila_Lectura = 0

        Try
            For i = 0 To Cont
                With Sp
                    .Inicializar()
                    .AgregarParametro("@Num_lab", CInt(Dtg_ArenaFyG(Fila_Lectura, 0)), SqlDbType.Int)
                    .AgregarParametro("@Cap1", CInt(Dtg_ArenaFyG(Fila_Lectura, 2)), SqlDbType.Int)
                    .AgregarParametro("@Peso_cap1", CDbl(Dtg_ArenaFyG(Fila_Lectura, 3)), SqlDbType.Float)
                    .AgregarParametro("@Cap2", CInt(Dtg_ArenaFyG(Fila_Lectura, 5)), SqlDbType.Int)
                    .AgregarParametro("@Peso_cap2", CDbl(Dtg_ArenaFyG(Fila_Lectura, 6)), SqlDbType.Float)
                    .AgregarParametro("@Peso_agruesa", CDbl(Dtg_ArenaFyG(Fila_Lectura, 4)), SqlDbType.Float)
                    .AgregarParametro("@Peso_afina", CDbl(Dtg_ArenaFyG(Fila_Lectura, 7)), SqlDbType.Float)
                    .AgregarParametro("@Porc_agruesa", CInt(Dtg_ArenaFyG(Fila_Lectura, 8)), SqlDbType.Int)
                    .AgregarParametro("@Porc_afina", CInt(Dtg_ArenaFyG(Fila_Lectura, 9)), SqlDbType.Int)
                    .EjecutarEscalar("usp_GrabaArenaFyG")
                End With
                With Sp
                    .Inicializar()
                    .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Num_lab", Dtg_ArenaFyG(Fila_Lectura, 0), SqlDbType.Int)
                    .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                    .EjecutarEscalar("usp_Update_DigitaResultados")
                End With
                Fila_Lectura = Fila_Lectura + 1
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Grabación Finalizada")
    End Sub

    Private Sub Dtg_ArenaFyG_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_ArenaFyG.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_ArenaFyG.CurrentCell.RowNumber()
        Revision_Digitacion = "N"
        If Dtg_ArenaFyG.CurrentCell.ColumnNumber = 2 Then Revision_Digitacion = "S"

        If Dtg_ArenaFyG.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).X + Dtg_ArenaFyG.Left
            Dim Posiciony As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Y + Dtg_ArenaFyG.Top
            Txt_cap1.Left = Posicionx
            Txt_cap1.Top = Posiciony
            Txt_cap1.Height = CeldaAlto
            Txt_cap1.Width = CeldaAncho
            Txt_cap1.Visible = True
            Txt_cap1.Text = ""
            Txt_cap1.Enabled = True
            Txt_cap1.TabIndex = 61
            Txt_cap1.Focus()
        End If

        If Dtg_ArenaFyG.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).X + Dtg_ArenaFyG.Left
            Dim Posiciony As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Y + Dtg_ArenaFyG.Top
            Txt_PesoAgruesa.Left = Posicionx
            Txt_PesoAgruesa.Top = Posiciony
            Txt_PesoAgruesa.Height = CeldaAlto
            Txt_PesoAgruesa.Width = CeldaAncho
            Txt_PesoAgruesa.Visible = True
            Txt_PesoAgruesa.Text = ""
            Txt_PesoAgruesa.Enabled = True
            Txt_PesoAgruesa.TabIndex = 64
            Txt_PesoAgruesa.Focus()
        End If

        If Dtg_ArenaFyG.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).X + Dtg_ArenaFyG.Left
            Dim Posiciony As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Y + Dtg_ArenaFyG.Top
            Txt_Cap2.Left = Posicionx
            Txt_Cap2.Top = Posiciony
            Txt_Cap2.Height = CeldaAlto
            Txt_Cap2.Width = CeldaAncho
            Txt_Cap2.Visible = True
            Txt_Cap2.Text = ""
            Txt_Cap2.Enabled = True
            Txt_Cap2.TabIndex = 62
            Txt_Cap2.Focus()
        End If

        If Dtg_ArenaFyG.CurrentCell.ColumnNumber = 7 Then
            Dim CeldaAlto As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).X + Dtg_ArenaFyG.Left
            Dim Posiciony As Integer = Dtg_ArenaFyG.GetCellBounds(Dtg_ArenaFyG.CurrentCell.RowNumber, Dtg_ArenaFyG.CurrentCell.ColumnNumber).Y + Dtg_ArenaFyG.Top
            Txt_PesoMueafina.Left = Posicionx
            Txt_PesoMueafina.Top = Posiciony
            Txt_PesoMueafina.Height = CeldaAlto
            Txt_PesoMueafina.Width = CeldaAncho
            Txt_PesoMueafina.Visible = True
            Txt_PesoMueafina.Text = ""
            Txt_PesoMueafina.Enabled = True
            Txt_PesoMueafina.TabIndex = 63
            Txt_PesoMueafina.Focus()
        End If


    End Sub

    Private Sub Txt_cap1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_cap1.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_ArenaFyG.Item(Fila_Lectura, 2) = Txt_cap1.Text
            mycell.ColumnNumber = 4
            mycell.RowNumber = Fila_Lectura
            Dtg_ArenaFyG.CurrentCell = mycell
            Me.Txt_PesoAgruesa.Focus()
            Txt_cap1.Visible = False
        End If
    End Sub

    Private Sub Txt_PesoAgruesa_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PesoAgruesa.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Txt_PesoAgruesa.Text = Txt_PesoAgruesa.Text.Replace(".", ",")
            Dtg_ArenaFyG.Item(Fila_Lectura, 4) = Txt_PesoAgruesa.Text
            mycell.ColumnNumber = 5
            mycell.RowNumber = Fila_Lectura
            Dtg_ArenaFyG.CurrentCell = mycell
            Me.Txt_Cap2.Focus()
            Txt_PesoAgruesa.Visible = False
        End If
    End Sub


    Private Sub Txt_Cap2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Cap2.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Dtg_ArenaFyG.Item(Fila_Lectura, 5) = Txt_Cap2.Text
            mycell.ColumnNumber = 7
            mycell.RowNumber = Fila_Lectura
            Dtg_ArenaFyG.CurrentCell = mycell
            Call Carga_TaraCapsula()
            Me.Txt_PesoMueafina.Focus()
            Txt_Cap2.Visible = False
        End If
    End Sub

    Private Sub Txt_PesoMueafina_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PesoMueafina.KeyPress
        Dim mycell As New DataGridCell
        Dim Porc_Afina, Porc_Agruesa As Double
        If e.KeyChar = Chr(13) Then
            Txt_PesoMueafina.Text = Txt_PesoMueafina.Text.Replace(".", ",")
            Txt_PesoAgruesa.Text = Txt_PesoAgruesa.Text.Replace(".", ",")
            Call F_Arena(CDbl(Txt_PesoAgruesa.Text), Dtg_ArenaFyG(Fila_Lectura, 3), CDbl(Txt_PesoMueafina.Text), Dtg_ArenaFyG(Fila_Lectura, 6), Porc_Afina, Porc_Agruesa, CDbl(Dtg_ArenaFyG(Fila_Lectura, 1)))
            Dtg_ArenaFyG.Item(Fila_Lectura, 7) = Txt_PesoMueafina.Text
            Dtg_ArenaFyG(Fila_Lectura, 8) = Round(Porc_Agruesa, 0)
            Dtg_ArenaFyG(Fila_Lectura, 9) = Round(Porc_Afina, 0)

            mycell.ColumnNumber = 2
            mycell.RowNumber = Fila_Lectura + 1
            Dtg_ArenaFyG.CurrentCell = mycell
            Me.Txt_cap1.Focus()
            Txt_PesoMueafina.Visible = False
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
        ' Call Encavezado_ResultadoTex(objHojaExcel)
        Call Imprime_PiePagTex(objHojaExcel, Cbx_Analista.Text, Cbx_Digitador.Text)
        Call Imprime_ResultadosTex(objHojaExcel)
    End Sub

    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
    End Sub

    Private Sub Bt_Limpia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Limpia.Click
        Cjto_Tablas1.Tables("TEXTURA_SUELO1").Clear()
        Txt_NLabDesde.ResetText()
        Txt_NLabHasta.ResetText()
    End Sub

    Private Sub Carga_TaraCapsula()
        'El codigo carga el peso de las capsulas en la grilla, el ciclo For es el limitador 
        'de las filas

        Dim dato1, dato2, IdCapsula, i As Integer
        Dim TaraCapsula As Double
        Dim FArena As String

        dato1 = CInt(Dtg_ArenaFyG.Item(Fila_Lectura, 2))
        dato2 = CInt(Dtg_ArenaFyG.Item(Fila_Lectura, 5))
        Call BuscarCapsula(dato1, TaraCapsula, IdCapsula, FArena)
        If dato1 = IdCapsula Then
            Dtg_ArenaFyG.Item(Fila_Lectura, 3) = TaraCapsula
            ' Dtg_TexturaSeparacionArenas.Item(Fila_Lectura, 9) = FArena
        End If
        Call BuscarCapsula(dato2, TaraCapsula, IdCapsula, FArena)
        If dato2 = IdCapsula Then
            Dtg_ArenaFyG.Item(Fila_Lectura, 6) = TaraCapsula
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

    Private Sub Bt_Carga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click
        Call Carga_Planilla()
    End Sub

    Private Sub Frm_ArenaFyG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
