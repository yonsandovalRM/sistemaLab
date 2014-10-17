Imports System.Data.SqlClient
Imports System.Math
Imports Microsoft.Office.Interop

Public Class Frm_DapCilindrica
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txt_CilRadio As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CilAltura As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Txt_CilVolumen As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTG_DAPCILINDRICA As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Txt_Radio As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Altura As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Volumen As System.Windows.Forms.TextBox
    Friend WithEvents Txt_PSeco As System.Windows.Forms.TextBox
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
        Me.DTG_DAPCILINDRICA = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Bt_Salir = New System.Windows.Forms.Button
        Me.Bt_Imprime = New System.Windows.Forms.Button
        Me.Bt_Graba = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Txt_CilVolumen = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Txt_CilAltura = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Txt_CilRadio = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txt_Radio = New System.Windows.Forms.TextBox
        Me.Txt_Altura = New System.Windows.Forms.TextBox
        Me.Txt_Volumen = New System.Windows.Forms.TextBox
        Me.Txt_PSeco = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DTG_DAPCILINDRICA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
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
        Me.GroupBox2.TabIndex = 11
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
        Me.GroupBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Controls.Add(Me.Cbx_Analista)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaAnalisis)
        Me.GroupBox1.Controls.Add(Me.Cbx_Digitador)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Dtp_FechaDigitacion)
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 152)
        Me.GroupBox1.TabIndex = 10
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
        'DTG_DAPCILINDRICA
        '
        Me.DTG_DAPCILINDRICA.CaptionVisible = False
        Me.DTG_DAPCILINDRICA.DataMember = ""
        Me.DTG_DAPCILINDRICA.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DTG_DAPCILINDRICA.Location = New System.Drawing.Point(304, 0)
        Me.DTG_DAPCILINDRICA.Name = "DTG_DAPCILINDRICA"
        Me.DTG_DAPCILINDRICA.Size = New System.Drawing.Size(456, 912)
        Me.DTG_DAPCILINDRICA.TabIndex = 12
        Me.DTG_DAPCILINDRICA.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.DTG_DAPCILINDRICA
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "DENSIDAD_CILINDRICA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "N°Lab"
        Me.DataGridTextBoxColumn1.MappingName = "OT_NLAB"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 66
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "N°C"
        Me.DataGridTextBoxColumn2.MappingName = "LINEA"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 25
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Radio"
        Me.DataGridTextBoxColumn3.MappingName = "RADIO"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Altura"
        Me.DataGridTextBoxColumn4.MappingName = "ALTURA"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Volumen"
        Me.DataGridTextBoxColumn5.MappingName = "VOLUMEN"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 65
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "Peso Seco"
        Me.DataGridTextBoxColumn6.MappingName = "PESO_SECO"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Cilindro"
        Me.DataGridTextBoxColumn7.MappingName = "DENSIDAD"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 65
        '
        'Bt_Salir
        '
        Me.Bt_Salir.BackColor = System.Drawing.Color.Transparent
        Me.Bt_Salir.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bt_Salir.Image = Global.LabSys.My.Resources.Resources.door_out
        Me.Bt_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bt_Salir.Location = New System.Drawing.Point(1176, 936)
        Me.Bt_Salir.Name = "Bt_Salir"
        Me.Bt_Salir.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Salir.TabIndex = 74
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
        Me.Bt_Imprime.Location = New System.Drawing.Point(984, 936)
        Me.Bt_Imprime.Name = "Bt_Imprime"
        Me.Bt_Imprime.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Imprime.TabIndex = 73
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
        Me.Bt_Graba.Location = New System.Drawing.Point(888, 936)
        Me.Bt_Graba.Name = "Bt_Graba"
        Me.Bt_Graba.Size = New System.Drawing.Size(80, 24)
        Me.Bt_Graba.TabIndex = 72
        Me.Bt_Graba.Text = "Graba"
        Me.Bt_Graba.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bt_Graba.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(0, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 23)
        Me.Label10.TabIndex = 75
        Me.Label10.Text = "Volumen del Cilindro"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBox3.Controls.Add(Me.Txt_CilVolumen)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Txt_CilAltura)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Txt_CilRadio)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 368)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 136)
        Me.GroupBox3.TabIndex = 76
        Me.GroupBox3.TabStop = False
        '
        'Txt_CilVolumen
        '
        Me.Txt_CilVolumen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CilVolumen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CilVolumen.Location = New System.Drawing.Point(144, 88)
        Me.Txt_CilVolumen.Name = "Txt_CilVolumen"
        Me.Txt_CilVolumen.Size = New System.Drawing.Size(56, 20)
        Me.Txt_CilVolumen.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(8, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(120, 20)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Volumen"
        '
        'Txt_CilAltura
        '
        Me.Txt_CilAltura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CilAltura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CilAltura.Location = New System.Drawing.Point(144, 56)
        Me.Txt_CilAltura.Name = "Txt_CilAltura"
        Me.Txt_CilAltura.Size = New System.Drawing.Size(56, 20)
        Me.Txt_CilAltura.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(8, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "Altura"
        '
        'Txt_CilRadio
        '
        Me.Txt_CilRadio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Txt_CilRadio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CilRadio.Location = New System.Drawing.Point(144, 24)
        Me.Txt_CilRadio.Name = "Txt_CilRadio"
        Me.Txt_CilRadio.Size = New System.Drawing.Size(56, 20)
        Me.Txt_CilRadio.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(8, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 20)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Radio"
        '
        'Txt_Radio
        '
        Me.Txt_Radio.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Radio.Location = New System.Drawing.Point(312, 104)
        Me.Txt_Radio.Name = "Txt_Radio"
        Me.Txt_Radio.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Radio.TabIndex = 77
        Me.Txt_Radio.Visible = False
        '
        'Txt_Altura
        '
        Me.Txt_Altura.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Altura.Location = New System.Drawing.Point(312, 144)
        Me.Txt_Altura.Name = "Txt_Altura"
        Me.Txt_Altura.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Altura.TabIndex = 78
        Me.Txt_Altura.Visible = False
        '
        'Txt_Volumen
        '
        Me.Txt_Volumen.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Volumen.Location = New System.Drawing.Point(312, 184)
        Me.Txt_Volumen.Name = "Txt_Volumen"
        Me.Txt_Volumen.Size = New System.Drawing.Size(100, 20)
        Me.Txt_Volumen.TabIndex = 79
        Me.Txt_Volumen.Visible = False
        '
        'Txt_PSeco
        '
        Me.Txt_PSeco.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PSeco.Location = New System.Drawing.Point(312, 264)
        Me.Txt_PSeco.Name = "Txt_PSeco"
        Me.Txt_PSeco.Size = New System.Drawing.Size(100, 20)
        Me.Txt_PSeco.TabIndex = 81
        Me.Txt_PSeco.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.LabSys.My.Resources.Resources.limpiar
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1080, 936)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 24)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Limpiar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Frm_DapCilindrica
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1272, 997)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txt_PSeco)
        Me.Controls.Add(Me.Txt_Volumen)
        Me.Controls.Add(Me.Txt_Altura)
        Me.Controls.Add(Me.Txt_Radio)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Bt_Salir)
        Me.Controls.Add(Me.Bt_Imprime)
        Me.Controls.Add(Me.Bt_Graba)
        Me.Controls.Add(Me.DTG_DAPCILINDRICA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_DapCilindrica"
        Me.Text = "DapCilindrica"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DTG_DAPCILINDRICA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub DTG_DAPCILINDRICA_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DTG_DAPCILINDRICA.CurrentCellChanged
        Dim numerofil, Mypos As Integer
        Dim myHitTest As DataGrid.HitTestInfo
        Fila_Lectura = DTG_DAPCILINDRICA.CurrentCell.RowNumber()
        Revision_Digitacion = "N"


        'El siguiente  codigo tiene la mision de posicionar el TexBox en una determinada columna de
        'la Grilla, para si poder trabajar con los datos en ella.

        If DTG_DAPCILINDRICA.CurrentCell.ColumnNumber = 0 Then Revision_Digitacion = "S"

        If DTG_DAPCILINDRICA.CurrentCell.ColumnNumber = 2 Then
            Dim CeldaAlto As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).X + DTG_DAPCILINDRICA.Left
            Dim Posiciony As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Y + DTG_DAPCILINDRICA.Top
            Txt_Radio.Left = Posicionx
            Txt_Radio.Top = Posiciony
            Txt_Radio.Height = CeldaAlto
            Txt_Radio.Width = CeldaAncho
            Txt_Radio.Visible = True
            Txt_Radio.Text = ""
            Txt_Radio.Enabled = True
            Txt_Radio.TabIndex = 77
            Txt_Radio.Focus()
        End If

        If DTG_DAPCILINDRICA.CurrentCell.ColumnNumber = 3 Then
            Dim CeldaAlto As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).X + DTG_DAPCILINDRICA.Left
            Dim Posiciony As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Y + DTG_DAPCILINDRICA.Top
            Txt_Altura.Left = Posicionx
            Txt_Altura.Top = Posiciony
            Txt_Altura.Height = CeldaAlto
            Txt_Altura.Width = CeldaAncho
            Txt_Altura.Visible = True
            Txt_Altura.Text = ""
            Txt_Altura.Enabled = True
            Txt_Altura.TabIndex = 78
            Txt_Altura.Focus()
        End If

        If DTG_DAPCILINDRICA.CurrentCell.ColumnNumber = 4 Then
            Dim CeldaAlto As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).X + DTG_DAPCILINDRICA.Left
            Dim Posiciony As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Y + DTG_DAPCILINDRICA.Top
            Txt_Volumen.Left = Posicionx
            Txt_Volumen.Top = Posiciony
            Txt_Volumen.Height = CeldaAlto
            Txt_Volumen.Width = CeldaAncho
            Txt_Volumen.Visible = True
            Txt_Volumen.Text = ""
            Txt_Volumen.Enabled = True
            Txt_Volumen.TabIndex = 79
            Txt_Volumen.Focus()
        End If


       

        If DTG_DAPCILINDRICA.CurrentCell.ColumnNumber = 5 Then
            Dim CeldaAlto As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Height
            Dim CeldaAncho As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Width
            Dim Posicionx As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).X + DTG_DAPCILINDRICA.Left
            Dim Posiciony As Integer = DTG_DAPCILINDRICA.GetCellBounds(DTG_DAPCILINDRICA.CurrentCell.RowNumber, DTG_DAPCILINDRICA.CurrentCell.ColumnNumber).Y + DTG_DAPCILINDRICA.Top
            Txt_PSeco.Left = Posicionx
            Txt_PSeco.Top = Posiciony
            Txt_PSeco.Height = CeldaAlto
            Txt_PSeco.Width = CeldaAncho
            Txt_PSeco.Visible = True
            Txt_PSeco.Text = ""
            Txt_PSeco.Enabled = True
            Txt_PSeco.TabIndex = 81
            Txt_PSeco.Focus()
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

        Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Clear()
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
                For i = 1 To 3
                    If i = 1 Then
                        Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").NewRow
                        Fila_Digitacion("OT_NLAB") = myReader.GetString(0)
                        Fila_Digitacion("LINEA") = i
                        Fila_Digitacion("RADIO") = Txt_CilRadio.Text
                        Fila_Digitacion("ALTURA") = Txt_CilAltura.Text
                        Fila_Digitacion("VOLUMEN") = Txt_CilVolumen.Text
                        Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Rows.Add(Fila_Digitacion)
                    Else
                        Fila_Digitacion = Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").NewRow
                        Fila_Digitacion("LINEA") = i
                        Fila_Digitacion("RADIO") = Txt_CilRadio.Text
                        Fila_Digitacion("ALTURA") = Txt_CilAltura.Text
                        Fila_Digitacion("VOLUMEN") = Txt_CilVolumen.Text
                        Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Rows.Add(Fila_Digitacion)
                    End If

                Next
            End If
SaltoxIngresoDup:
        End While
        myReader.Close()
        SqlConn.Close()
    End Sub

    Private Sub Txt_CilAltura_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CilAltura.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_CilAltura.Text = Txt_CilAltura.Text.Replace(".", ",")
            Txt_CilVolumen.Text = Round(Volumen(CDbl(Txt_CilRadio.Text), CDbl(Txt_CilAltura.Text)), 1)
        End If
    End Sub

    Private Function Volumen(ByVal r As Double, ByVal h As Double)
        Volumen = ((3.14) * (r) ^ 2) * h
        Return Volumen
    End Function

    Private Sub Txt_CilRadio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_CilRadio.KeyPress
        If e.KeyChar = Chr(13) Then
            Txt_CilRadio.Text = Txt_CilRadio.Text.Replace(".", ",")
            Txt_CilAltura.Focus()
        End If
    End Sub

    Private Sub Txt_PSeco_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_PSeco.KeyPress
        Dim mycell As New DataGridCell
        If e.KeyChar = Chr(13) Then
            Txt_PSeco.Text = Txt_PSeco.Text.Replace(".", ",")
            DTG_DAPCILINDRICA(Fila_Lectura, 5) = Txt_PSeco.Text
            DTG_DAPCILINDRICA(Fila_Lectura, 6) = Round(Dap_Cilindrica(CDbl(DTG_DAPCILINDRICA(Fila_Lectura, 5)), CDbl(DTG_DAPCILINDRICA(Fila_Lectura, 4)), (2.5)), 2)
            mycell.ColumnNumber = 5
            mycell.RowNumber = Fila_Lectura + 1
            DTG_DAPCILINDRICA.CurrentCell = mycell
            Txt_PSeco.Focus()
        End If
    End Sub

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
        Call Encavezado_DapCilindrico(objHojaExcel)
        Call Encavezado_ResultadoDapCilindro(objHojaExcel, Fila_Exp + 8)
        Call Imprime_ResultadoDapCilindrica(objHojaExcel, Fila_Exp + 1)
    End Sub

    Private Sub Anti_Elimina_Lineas()
        DTG_DAPCILINDRICA.DataSource = Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA")
    End Sub

    Private Sub Frm_DapCilindrica_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Anti_Elimina_Lineas()
    End Sub

    Private Sub Bt_Graba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bt_Graba.Click
        Dim SP As Procedimiento_Almacenado = New Procedimiento_Almacenado
        Dim i As Integer
        Dim Dato As String

        Try

            For i = 0 To Fila_Lectura
                With SP
                    If IsDBNull(DTG_DAPCILINDRICA(i, 0)) = False And DTG_DAPCILINDRICA(i, 1) = 1 Then
                        Dato = DTG_DAPCILINDRICA(i, 0)
                    End If
                    .Inicializar()
                    .AgregarParametro("@NumLab", Dato, SqlDbType.NVarChar)
                    .AgregarParametro("@Indice", DTG_DAPCILINDRICA(i, 1), SqlDbType.Int)
                    .AgregarParametro("@Radio", DTG_DAPCILINDRICA(i, 2), SqlDbType.Float)
                    .AgregarParametro("@Altura", DTG_DAPCILINDRICA(i, 3), SqlDbType.Float)
                    .AgregarParametro("@Volumen", DTG_DAPCILINDRICA(i, 4), SqlDbType.Float)
                    .AgregarParametro("@T_BAndeja", "2.5", SqlDbType.Float)
                    .AgregarParametro("@Peso_Seco", DTG_DAPCILINDRICA(i, 5), SqlDbType.Float)
                    .AgregarParametro("@Resultado", DTG_DAPCILINDRICA(i, 6), SqlDbType.Float)
                    .EjecutarEscalar("usp_Graba_DapCilindrica")

                End With

                With SP
                    .Inicializar()
                    .AgregarParametro("@Fecha_analisis", Dtp_FechaAnalisis.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Fecha_digita", Dtp_FechaDigitacion.Text, SqlDbType.DateTime)
                    .AgregarParametro("@Num_lab", CInt(Dato), SqlDbType.Int)
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
        Cjto_Tablas1.Tables("DENSIDAD_CILINDRICA").Clear()
        Txt_CilRadio.ResetText()
        Txt_CilAltura.ResetText()
        Txt_CilVolumen.ResetText()
        Txt_NLabInicial.ResetText()
    End Sub
End Class
