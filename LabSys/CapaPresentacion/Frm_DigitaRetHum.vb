Imports System.Math
Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Public Class Frm_DigitaRetHum
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Txt_RetHum33 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_RetSeco33 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_RetHum15 As System.Windows.Forms.TextBox
    Friend WithEvents Txt_RetSeco15 As System.Windows.Forms.TextBox
    Friend WithEvents Dtg_RetHumedad As System.Windows.Forms.DataGrid
    Friend WithEvents Bt_Salir As System.Windows.Forms.Button
    Friend WithEvents Bt_Imprime As System.Windows.Forms.Button
    Friend WithEvents Bt_Graba As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
        Me.Dtg_RetHumedad = New System.Windows.Forms.DataGrid
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
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Txt_RetHum33 = New System.Windows.Forms.TextBox
        Me.Txt_RetSeco33 = New System.Windows.Forms.TextBox
        Me.Txt_RetHum15 = New System.Windows.Forms.TextBox
        Me.Txt_RetSeco15 = New System.Windows.Forms.TextBox
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Dtg_RetHumedad, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.TabIndex = 7
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
        Me.Label5.Text = "Cód.Planifica"
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
        Me.GroupBox1.TabIndex = 6
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
        'Dtg_RetHumedad
        '
        Me.Dtg_RetHumedad.CaptionVisible = False
        Me.Dtg_RetHumedad.DataMember = ""
        Me.Dtg_RetHumedad.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtg_RetHumedad.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.Dtg_RetHumedad.Location = New System.Drawing.Point(304, 24)
        Me.Dtg_RetHumedad.Name = "Dtg_RetHumedad"
        Me.Dtg_RetHumedad.Size = New System.Drawing.Size(684, 896)
        Me.Dtg_RetHumedad.TabIndex = 8
        Me.Dtg_RetHumedad.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.Dtg_RetHumedad
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "RET_HUMEDAD"
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
        Me.DataGridTextBoxColumn2.HeaderText = "N°b"
        Me.DataGridTextBoxColumn2.MappingName = "NUM_BANDEJA33"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 30
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Tara band"
        Me.DataGridTextBoxColumn3.MappingName = "TARA_BANDEJA33"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Humedo"
        Me.DataGridTextBoxColumn4.MappingName = "MUE_HUM33"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Seco"
        Me.DataGridTextBoxColumn5.MappingName = "MUE_SEC33"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 65
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Res"
        Me.DataGridTextBoxColumn6.MappingName = "RESULTADO33"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "N°b"
        Me.DataGridTextBoxColumn7.MappingName = "NUM_BANDEJA15"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 30
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Tara band"
        Me.DataGridTextBoxColumn8.MappingName = "TARA_BANDEJA15"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 65
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "Humedo"
        Me.DataGridTextBoxColumn9.MappingName = "MUE_HUM15"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 65
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Seco"
        Me.DataGridTextBoxColumn10.MappingName = "MUE_SEC15"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 65
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "Res"
        Me.DataGridTextBoxColumn11.MappingName = "RESULTADO15"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 65
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(408, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(288, 23)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Masa 0.33 bar (g)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(696, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(292, 23)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Masa 0.15 bar (g)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_RetHum33
        '
        Me.Txt_RetHum33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RetHum33.Location = New System.Drawing.Point(328, 224)
        Me.Txt_RetHum33.Name = "Txt_RetHum33"
        Me.Txt_RetHum33.Size = New System.Drawing.Size(100, 20)
        Me.Txt_RetHum33.TabIndex = 46
        Me.Txt_RetHum33.Visible = False
        '
        'Txt_RetSeco33
        '
        Me.Txt_RetSeco33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RetSeco33.Location = New System.Drawing.Point(328, 256)
        Me.Txt_RetSeco33.Name = "Txt_RetSeco33"
        Me.Txt_RetSeco33.Size = New System.Drawing.Size(100, 20)
        Me.Txt_RetSeco33.TabIndex = 47
        Me.Txt_RetSeco33.Visible = False
        '
        'Txt_RetHum15
        '
        Me.Txt_RetHum15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RetHum15.Location = New System.Drawing.Point(328, 288)
        Me.Txt_RetHum15.Name = "Txt_RetHum15"
        Me.Txt_RetHum15.Size = New System.Drawing.Size(100, 20)
        Me.Txt_RetHum15.TabIndex = 48
        Me.Txt_RetHum15.Visible = False
        '
        'Txt_RetSeco15
        '
        Me.Txt_RetSeco15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_RetSeco15.Location = New System.Drawing.Point(328, 320)
        Me.Txt_RetSeco15.Name = "Txt_RetSeco15"
        Me.Txt_RetSeco15.Size = New System.Drawing.Size(100, 20)
        Me.Txt_RetSeco15.TabIndex = 49
        Me.Txt_RetSeco15.Visible = False
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
        Me.Bt_Salir.TabIndex = 52
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
        Me.Bt_Imprime.TabIndex = 51
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
        Me.Bt_Graba.TabIndex = 50
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
        Me.Button1.Location = New System.Drawing.Point(1080, 944)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_DigitaRetHum
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.Txt_RetSeco15)
        Me.Controls.Add(Me.Txt_RetHum15)
        Me.Controls.Add(Me.Txt_RetSeco33)
        Me.Controls.Add(Me.Txt_RetHum33)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Dtg_RetHumedad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_DigitaRetHum"
        Me.Text = "Digita Retención de Humedad"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Dtg_RetHumedad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Dtg_RetHumedad_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Dtg_RetHumedad.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = Dtg_RetHumedad.CurrentCell.RowNumber()
        Revision_Digitacion = "N"


        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.

        If Dtg_RetHumedad.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"

        If Dtg_RetHumedad.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).X + Dtg_RetHumedad.Left
            Dim Posiciony As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Y + Dtg_RetHumedad.Top
            Txt_RetHum33.Left = Posicionx
            Txt_RetHum33.Top = Posiciony
            Txt_RetHum33.Height = CeldaAlto
            Txt_RetHum33.Width = CeldaAncho
            Txt_RetHum33.Visible = True
            Txt_RetHum33.Text = ""
            Txt_RetHum33.Enabled = True
            Txt_RetHum33.TabIndex = 46
            Txt_RetHum33.Focus()
        End If

        If Dtg_RetHumedad.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).X + Dtg_RetHumedad.Left
            Dim Posiciony As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Y + Dtg_RetHumedad.Top
            Txt_RetSeco33.Left = Posicionx
            Txt_RetSeco33.Top = Posiciony
            Txt_RetSeco33.Height = CeldaAlto
            Txt_RetSeco33.Width = CeldaAncho
            Txt_RetSeco33.Visible = True
            Txt_RetSeco33.Text = ""
            Txt_RetSeco33.Enabled = True
            Txt_RetSeco33.TabIndex = 47
            Txt_RetSeco33.Focus()
        End If

        If Dtg_RetHumedad.CurrentCell.ColumnNumber = 8 Then
            Dim CeldaAlto As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).X + Dtg_RetHumedad.Left
            Dim Posiciony As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Y + Dtg_RetHumedad.Top
            Txt_RetHum15.Left = Posicionx
            Txt_RetHum15.Top = Posiciony
            Txt_RetHum15.Height = CeldaAlto
            Txt_RetHum15.Width = CeldaAncho
            Txt_RetHum15.Visible = True
            Txt_RetHum15.Text = ""
            Txt_RetHum15.Enabled = True
            Txt_RetHum15.TabIndex = 48
            Txt_RetHum15.Focus()
        End If

        If Dtg_RetHumedad.CurrentCell.ColumnNumber = 9 Then
            Dim CeldaAlto As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).X + Dtg_RetHumedad.Left
            Dim Posiciony As Integer = Dtg_RetHumedad.GetCellBounds(Dtg_RetHumedad.CurrentCell.RowNumber, Dtg_RetHumedad.CurrentCell.ColumnNumber).Y + Dtg_RetHumedad.Top
            Txt_RetSeco15.Left = Posicionx
            Txt_RetSeco15.Top = Posiciony
            Txt_RetSeco15.Height = CeldaAlto
            Txt_RetSeco15.Width = CeldaAncho
            Txt_RetSeco15.Visible = True
            Txt_RetSeco15.Text = ""
            Txt_RetSeco15.Enabled = True
            Txt_RetSeco15.TabIndex = 49
            Txt_RetSeco15.Focus()
        End If
    End Sub

    Private Sub Bt_Carga_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Bt_Carga.Click
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

        If Txt_NLabDesde.Text <> "" And Txt_NLabHasta.Text <> "" Then
            Cjto_Tablas1.Tables("RET_HUMEDAD").Clear()
            query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
            Dim myCommand As New SqlCommand(query, SqlConn)
            SqlConn.Open()
            Dim myReader As SqlDataReader = myCommand.ExecuteReader()
            While myReader.Read()

                If CInt(myReader.GetString(0)) >= CInt(Txt_NLabDesde.Text) And CInt(myReader.GetString(0)) <= CInt(Txt_NLabHasta.Text) Then Carga_Digitacion = "S"

                If Mypos = 0 Then
                    EstaRevisado = RevisaNumLab(myReader.GetString(0), Elemento, 4000)
                End If

                If Carga_Digitacion = "S" And EstaRevisado = 0 Then
                    For i = 1 To 2
                        If i = 1 Then
                            Fila_Digitacion = Cjto_Tablas1.Tables("RET_HUMEDAD").NewRow
                            Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                            cont = cont + 1
                            Fila_Digitacion("NUM_BANDEJA33") = cont
                            Fila_Digitacion("NUM_BANDEJA15") = cont
                            Fila_Digitacion("TARA_BANDEJA15") = 2.5
                            Fila_Digitacion("TARA_BANDEJA33") = 2.5
                            Cjto_Tablas1.Tables("RET_HUMEDAD").Rows.Add(Fila_Digitacion)
                        Else
                            Fila_Digitacion = Cjto_Tablas1.Tables("RET_HUMEDAD").NewRow
                            cont = cont + 1
                            Fila_Digitacion("NUM_BANDEJA33") = cont
                            Fila_Digitacion("NUM_BANDEJA15") = cont
                            Fila_Digitacion("TARA_BANDEJA15") = 2.5
                            Fila_Digitacion("TARA_BANDEJA33") = 2.5
                            Cjto_Tablas1.Tables("RET_HUMEDAD").Rows.Add(Fila_Digitacion)
                        End If
                    Next
                ElseIf EstaRevisado <> 0 Then
                    MsgBox("El numero de laboratorio : " & myReader.GetString(0) & " presenta un estado digitado")
                End If

            End While
            myReader.Close()
            GoTo SaltoxIngresoDup
        End If

        Cjto_Tablas1.Tables("RET_HUMEDAD").Clear()
        query = "select OT_NLABD FROM PLANILLA_PLANI WHERE ELE_CODIGO='" & Elemento & "' AND OTC_NLAB_DESDED='" & Txt_NLabInicial.Text & "' AND OTC_FECHA_PLANI='" & Me.Dtp_FechaPlanilla.Text & "' and tmu_codigo=4000  ORDER BY PRIORIDAD"
        Dim myCommand1 As New SqlCommand(query, SqlConn)
        SqlConn.Open()
        Dim myReader1 As SqlDataReader = myCommand1.ExecuteReader()
        While myReader1.Read()

            If Me.Txt_NLabDesde.Text = "" Or Me.Txt_NLabHasta.Text = "" Then Carga_Digitacion = "S" : GoTo saltocarga

SaltoCarga:
            If Mypos = 0 Then
                EstaRevisado = RevisaNumLab(myReader1.GetString(0), Elemento, 4000)
            End If

            If Carga_Digitacion = "S" And EstaRevisado = 0 Then
                For i = 1 To 2
                    If i = 1 Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("RET_HUMEDAD").NewRow
                        Fila_Digitacion("OT_NLAB") = myReader1.GetString(0)
                        cont = cont + 1
                        Fila_Digitacion("NUM_BANDEJA33") = cont
                        Fila_Digitacion("NUM_BANDEJA15") = cont
                        Fila_Digitacion("TARA_BANDEJA15") = 2.5
                        Fila_Digitacion("TARA_BANDEJA33") = 2.5
                        Cjto_Tablas1.Tables("RET_HUMEDAD").Rows.Add(Fila_Digitacion)
                    Else
                        Fila_Digitacion = Cjto_Tablas1.Tables("RET_HUMEDAD").NewRow
                        cont = cont + 1
                        Fila_Digitacion("NUM_BANDEJA33") = cont
                        Fila_Digitacion("NUM_BANDEJA15") = cont
                        Fila_Digitacion("TARA_BANDEJA15") = 2.5
                        Fila_Digitacion("TARA_BANDEJA33") = 2.5
                        Cjto_Tablas1.Tables("RET_HUMEDAD").Rows.Add(Fila_Digitacion)
                    End If
                Next
            ElseIf EstaRevisado <> 0 Then
                MsgBox("El numero de laboratorio : " & myReader1.GetString(0) & " presenta un estado digitado")
            End If

        End While
        myReader1.Close()
SaltoxIngresoDup:
        SqlConn.Close()
    End Sub

    Private Sub Anti_Elimina_Lineas()
        Dtg_RetHumedad.DataSource = Cjto_Tablas1.Tables("RET_HUMEDAD")
    End Sub


    Private Sub Frm_DigitaRetHum_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub
#Region "Textbox de Grilla"
    Private Sub Txt_RetHum33_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_RetHum33.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_RetHum33.Text = "" Then
                Dtg_RetHumedad.Item(Fila_Lectura, 3) = 0
                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetSeco33.Focus()
                Txt_RetHum33.Visible = False
            Else
                Txt_RetHum33.Text = Txt_RetHum33.Text.Replace(".", ",")
                Dtg_RetHumedad.Item(Fila_Lectura, 3) = Txt_RetHum33.Text
                mycell.ColumnNumber = 4
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetSeco33.Focus()
                Txt_RetHum33.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_RetSeco33_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_RetSeco33.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_RetSeco33.Text = "" Then
                Dtg_RetHumedad.Item(Fila_Lectura, 4) = 0
                Dtg_RetHumedad.Item(Fila_Lectura, 5) = Round(RetHumedad(CDbl(Dtg_RetHumedad(Fila_Lectura, 3)), CDbl(Dtg_RetHumedad(Fila_Lectura, 4)), 2.5), 1)
                mycell.ColumnNumber = 8
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetHum15.Focus()
                Txt_RetSeco33.Visible = False
            Else
                Txt_RetSeco33.Text = Txt_RetSeco33.Text.Replace(".", ",")
                Dtg_RetHumedad.Item(Fila_Lectura, 4) = Txt_RetSeco33.Text
                Dtg_RetHumedad.Item(Fila_Lectura, 5) = Round(RetHumedad(CDbl(Dtg_RetHumedad(Fila_Lectura, 3)), CDbl(Dtg_RetHumedad(Fila_Lectura, 4)), 2.5), 1)
                mycell.ColumnNumber = 8
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetHum15.Focus()
                Txt_RetSeco33.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_RetHum15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_RetHum15.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_RetHum15.Text = "" Then
                Dtg_RetHumedad.Item(Fila_Lectura, 8) = 0
                mycell.ColumnNumber = 9
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetSeco15.Focus()
                Txt_RetHum15.Visible = False
            Else
                Txt_RetHum15.Text = Txt_RetHum15.Text.Replace(".", ",")
                Dtg_RetHumedad.Item(Fila_Lectura, 8) = Txt_RetHum15.Text
                mycell.ColumnNumber = 9
                mycell.RowNumber = Fila_Lectura
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetSeco15.Focus()
                Txt_RetHum15.Visible = False
            End If

        End If
    End Sub

    Private Sub Txt_RetSeco15_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_RetSeco15.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            If Txt_RetSeco15.Text = "" Then
                Dtg_RetHumedad.Item(Fila_Lectura, 9) = 0
                Dtg_RetHumedad.Item(Fila_Lectura, 10) = Round(RetHumedad(CDbl(Dtg_RetHumedad(Fila_Lectura, 8)), CDbl(Dtg_RetHumedad(Fila_Lectura, 9)), 2.5), 1)
                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetHum33.Focus()
                Txt_RetSeco15.Visible = False
            Else
                Txt_RetSeco15.Text = Txt_RetSeco15.Text.Replace(".", ",")
                Dtg_RetHumedad.Item(Fila_Lectura, 9) = Txt_RetSeco15.Text
                Dtg_RetHumedad.Item(Fila_Lectura, 10) = Round(RetHumedad(CDbl(Dtg_RetHumedad(Fila_Lectura, 8)), CDbl(Dtg_RetHumedad(Fila_Lectura, 9)), 2.5), 1)
                mycell.ColumnNumber = 3
                mycell.RowNumber = Fila_Lectura + 1
                Dtg_RetHumedad.CurrentCell = mycell
                Me.Txt_RetHum33.Focus()
                Txt_RetSeco15.Visible = False
            End If

        End If
    End Sub
#End Region
    
    Private Sub Bt_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Salir.Click
        Me.Close()
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
        Call Encavezado_RetHumedad(objHojaExcel)
        If Fila_Exp < 59 Then
            Call Encavezado_Resultado_RetHumedad(objHojaExcel, Fila_Exp + 3)
            Call Imprime_Resultado_RetHumedad(objHojaExcel, Fila_Exp + 1)
        End If

        If Fila_Exp >= 59 Then
            Call Encavezado_Resultado_RetHumedad(objHojaExcel, Fila_Exp + 9)
            Call Imprime_Resultado_RetHumedad(objHojaExcel, Fila_Exp + 1)
        End If
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cjto_Tablas1.Tables("RET_HUMEDAD").Clear()
        Txt_NLabInicial.ResetText()
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim Fila As Integer = 0
        Dim Aux As Integer = 0
        Dim Nlab As Integer
        Dim Hum_Ap As Double
        Dim Cont, i As Integer
        Cont = Dtg_RetHumedad.CurrentCell.RowNumber

        Try
            For i = 0 To Cont
                With SP
                    .Inicializar()
                    If IsDBNull(Dtg_RetHumedad(Fila, 0)) = True Then
                        Nlab = Dtg_RetHumedad(Fila - 1, 0)
                    Else
                        Nlab = Dtg_RetHumedad(Fila, 0)
                    End If
                    .AgregarParametro("@OT_NLAB", Nlab, SqlDbType.NVarChar)
                    .AgregarParametro("@NUM_BAN33", CInt(Dtg_RetHumedad(Fila, 1)), SqlDbType.Int)
                    .AgregarParametro("@T_BAN33", CDbl(Dtg_RetHumedad(Fila, 2)), SqlDbType.Float)
                    .AgregarParametro("@MUE_HUM33", CDbl(Dtg_RetHumedad(Fila, 3)), SqlDbType.Float)
                    .AgregarParametro("@MUE_SEC33", CDbl(Dtg_RetHumedad(Fila, 4)), SqlDbType.Float)
                    .AgregarParametro("@RESUL33", CDbl(Dtg_RetHumedad(Fila, 5)), SqlDbType.Float)
                    .AgregarParametro("@NUM_BAN15", CDbl(Dtg_RetHumedad(Fila, 6)), SqlDbType.Int)
                    .AgregarParametro("@T_BAN15", CDbl(Dtg_RetHumedad(Fila, 7)), SqlDbType.Float)
                    .AgregarParametro("@MUE_HUM15", CDbl(Dtg_RetHumedad(Fila, 8)), SqlDbType.Float)
                    .AgregarParametro("@MUE_SEC15", CDbl(Dtg_RetHumedad(Fila, 9)), SqlDbType.Float)
                    .AgregarParametro("@RESUL15", CDbl(Dtg_RetHumedad(Fila, 10)), SqlDbType.Float)
                    .AgregarParametro("@DIF33", Aux, SqlDbType.Float)
                    .AgregarParametro("@DIF15", Aux, SqlDbType.Float)
                    .AgregarParametro("@PROM33", Aux, SqlDbType.Float)
                    .AgregarParametro("@PROM15", Aux, SqlDbType.Float)
                    Hum_Ap = (CDbl(Dtg_RetHumedad(Fila, 5)) - CDbl(Dtg_RetHumedad(Fila, 10)))
                    .AgregarParametro("@HUM_APR", Round(Hum_Ap, 1), SqlDbType.Float)
                    .AgregarParametro("@DIF_HAPR", Aux, SqlDbType.Float)
                    .AgregarParametro("@PROM_HAPR", Aux, SqlDbType.Float)
                    .EjecutarEscalar("usp_GrabaRetHum")
                End With
                If i Mod 2 = 0 Then
                    With SP
                        .Inicializar()
                        .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                        .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                        .AgregarParametro("@Num_lab", CInt(Dtg_RetHumedad(Fila, 0)), SqlDbType.Int)
                        .AgregarParametro("@Elemento", Elemento, SqlDbType.NVarChar)
                        .EjecutarEscalar("usp_Update_DigitaResultados")
                    End With
                End If
                
                Fila = Fila + 1
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        MsgBox("Grabación Finalizada")

    End Sub
End Class
